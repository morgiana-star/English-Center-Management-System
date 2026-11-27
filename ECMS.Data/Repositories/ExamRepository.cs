using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class ExamRepository : BaseRepository, IExamRepository
{
    public async Task<IEnumerable<ExamListItemDto>> GetExamsAsync(
        int? teacherId = null, int? classId = null, string? examType = null, string? keyword = null)
    {
        using var conn = CreateConnection();

        string sql = @"
            SELECT 
                e.ExamId,
                e.ClassId,
                c.ClassCode,
                c.ClassName,
                co.CourseName,
                e.ExamName,
                e.Type,
                e.ExamDate,
                e.WeightPercentage,
                (SELECT COUNT(*) FROM Enrollments en WHERE en.ClassId = e.ClassId) AS TotalStudents,
                (SELECT COUNT(*) FROM ExamScores es WHERE es.ExamId = e.ExamId) AS GradedStudents
            FROM Exams e
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            WHERE (@TeacherId IS NULL OR c.MainTeacherId = @TeacherId)
              AND (@ClassId IS NULL OR e.ClassId = @ClassId)
              AND (@Type IS NULL OR e.Type = @Type)
              AND (@Keyword IS NULL OR e.ExamName LIKE @Keyword OR c.ClassCode LIKE @Keyword OR co.CourseName LIKE @Keyword)
            ORDER BY e.ExamDate DESC, e.ExamId DESC;";

        string? kwPattern = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword.Trim()}%";

        var list = await conn.QueryAsync<ExamListItemDto>(sql, new
        {
            TeacherId = teacherId,
            ClassId = classId,
            Type = examType,
            Keyword = kwPattern
        });

        return list;
    }

    public async Task<Exam?> GetExamByIdAsync(int examId)
    {
        using var conn = CreateConnection();
        return await conn.QueryFirstOrDefaultAsync<Exam>(
            "SELECT * FROM Exams WHERE ExamId = @ExamId;",
            new { ExamId = examId });
    }

    public async Task<int> CreateExamAsync(Exam exam)
    {
        using var conn = CreateConnection();
        string sql = @"
            INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, WeightPercentage)
            VALUES (@ClassId, @ExamName, @Type, @ExamDate, @WeightPercentage);
            SELECT last_insert_rowid();";

        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            exam.ClassId,
            exam.ExamName,
            Type = exam.Type.ToString(),
            ExamDate = exam.ExamDate.ToString("yyyy-MM-dd"),
            exam.WeightPercentage
        });
    }

    public async Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync(int? teacherId = null)
    {
        using var conn = CreateConnection();
        string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                co.CourseName,
                COALESCE(co.PassingScore, 5.0) AS PassingScore,
                COALESCE(t.FullName, 'Chưa xếp GV') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments en WHERE en.ClassId = c.ClassId) AS StudentCount
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE (@TeacherId IS NULL OR c.MainTeacherId = @TeacherId)
            ORDER BY c.ClassCode ASC;";

        return await conn.QueryAsync<ClassExamLookupDto>(sql, new { TeacherId = teacherId });
    }

    public async Task<List<ClassGradeRowDto>> GetClassGradeRowsAsync(int classId)
    {
        using var conn = CreateConnection();

        // Lấy điểm chuẩn PassingScore của khóa học
        decimal passingScore = await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(co.PassingScore, 5.0) 
            FROM Classes c 
            JOIN Courses co ON c.CourseId = co.CourseId 
            WHERE c.ClassId = @ClassId LIMIT 1;", new { ClassId = classId });
        if (passingScore <= 0) passingScore = 5.0m;

        string sql = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName,
                es.ListeningScore,
                es.ReadingScore,
                es.WritingScore,
                es.SpeakingScore,
                es.OverallScore
            FROM Enrollments en
            JOIN Students s ON en.StudentId = s.StudentId
            LEFT JOIN ExamScores es ON es.StudentId = s.StudentId AND es.ExamId = (
                SELECT ExamId FROM Exams WHERE ClassId = @ClassId ORDER BY ExamId DESC LIMIT 1
            )
            WHERE en.ClassId = @ClassId
            ORDER BY s.StudentCode ASC;";

        var rows = (await conn.QueryAsync<ClassGradeRowDto>(sql, new { ClassId = classId })).ToList();

        // Nếu lớp chưa có học viên trong Enrollments, lấy danh sách học viên từ Students để hiển thị
        if (rows.Count == 0)
        {
            string fallbackSql = @"
                SELECT 
                    s.StudentId,
                    s.StudentCode,
                    s.FullName,
                    NULL AS ListeningScore,
                    NULL AS ReadingScore,
                    NULL AS WritingScore,
                    NULL AS SpeakingScore,
                    NULL AS OverallScore
                FROM Students s
                ORDER BY s.StudentCode ASC
                LIMIT 20;";

            rows = (await conn.QueryAsync<ClassGradeRowDto>(fallbackSql)).ToList();
        }

        foreach (var r in rows)
        {
            // Xóa hết ghi chú học vụ theo yêu cầu
            r.Comment = "";

            if (r.ListeningScore.HasValue || r.ReadingScore.HasValue || r.WritingScore.HasValue || r.SpeakingScore.HasValue)
            {
                var skills = new List<double>();
                if (r.ListeningScore.HasValue) skills.Add((double)r.ListeningScore.Value);
                if (r.ReadingScore.HasValue) skills.Add((double)r.ReadingScore.Value);
                if (r.WritingScore.HasValue) skills.Add((double)r.WritingScore.Value);
                if (r.SpeakingScore.HasValue) skills.Add((double)r.SpeakingScore.Value);

                double overall = CalculateIeltsBand(skills);
                r.OverallScore = (decimal)overall;

                if ((decimal)overall >= passingScore)
                {
                    r.ResultText = $"✓ Đạt (Band {overall:0.0})";
                }
                else
                {
                    r.ResultText = $"✕ Chưa đạt ({overall:0.0})";
                }
            }
            else
            {
                r.OverallScore = null;
                r.ResultText = "--";
            }
        }

        return rows;
    }

    public async Task<bool> SaveClassGradeRowsAsync(int classId, List<ClassGradeRowDto> rows)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            // Lấy hoặc tự tạo bài thi IELTS Mock Test chính cho lớp
            int examId = await conn.ExecuteScalarAsync<int>(@"
                SELECT ExamId FROM Exams 
                WHERE ClassId = @ClassId 
                ORDER BY ExamId DESC LIMIT 1;",
                new { ClassId = classId }, trans);

            if (examId <= 0)
            {
                examId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, WeightPercentage)
                    VALUES (@ClassId, 'Thi thử IELTS 4 Kỹ năng (IELTS Mock Test)', 'Final', CURRENT_DATE, 100.0);
                    SELECT last_insert_rowid();",
                    new { ClassId = classId }, trans);
            }

            string upsertSql = @"
                INSERT INTO ExamScores (ExamId, StudentId, ListeningScore, ReadingScore, WritingScore, SpeakingScore, OverallScore, ScoreValue, TeacherComments, UpdatedAt)
                VALUES (@ExamId, @StudentId, @Listening, @Reading, @Writing, @Speaking, @Overall, @ScoreValue, NULL, CURRENT_TIMESTAMP)
                ON CONFLICT(ExamId, StudentId) DO UPDATE SET
                    ListeningScore = excluded.ListeningScore,
                    ReadingScore = excluded.ReadingScore,
                    WritingScore = excluded.WritingScore,
                    SpeakingScore = excluded.SpeakingScore,
                    OverallScore = excluded.OverallScore,
                    ScoreValue = excluded.ScoreValue,
                    TeacherComments = NULL,
                    UpdatedAt = CURRENT_TIMESTAMP;";

            foreach (var r in rows)
            {
                if (r.ListeningScore.HasValue || r.ReadingScore.HasValue || r.WritingScore.HasValue || r.SpeakingScore.HasValue)
                {
                    var skills = new List<double>();
                    if (r.ListeningScore.HasValue) skills.Add((double)r.ListeningScore.Value);
                    if (r.ReadingScore.HasValue) skills.Add((double)r.ReadingScore.Value);
                    if (r.WritingScore.HasValue) skills.Add((double)r.WritingScore.Value);
                    if (r.SpeakingScore.HasValue) skills.Add((double)r.SpeakingScore.Value);

                    double overall = CalculateIeltsBand(skills);
                    decimal overallDec = (decimal)overall;

                    await conn.ExecuteAsync(upsertSql, new
                    {
                        ExamId = examId,
                        StudentId = r.StudentId,
                        Listening = r.ListeningScore,
                        Reading = r.ReadingScore,
                        Writing = r.WritingScore,
                        Speaking = r.SpeakingScore,
                        Overall = overallDec,
                        ScoreValue = overallDec
                    }, trans);

                    // Cập nhật điểm tổng kết vào Enrollments
                    await conn.ExecuteAsync(@"
                        UPDATE Enrollments 
                        SET FinalGPA = @Gpa, UpdatedAt = CURRENT_TIMESTAMP 
                        WHERE ClassId = @ClassId AND StudentId = @StudentId;",
                        new
                        {
                            Gpa = overallDec,
                            ClassId = classId,
                            StudentId = r.StudentId
                        }, trans);
                }
            }

            trans.Commit();
            return true;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    public static double CalculateIeltsBand(List<double> skills)
    {
        if (skills == null || skills.Count == 0) return 0;
        double avg = skills.Average();
        double intPart = Math.Floor(avg);
        double frac = avg - intPart;

        if (frac < 0.25)
            return intPart;
        if (frac < 0.75)
            return intPart + 0.5;
        return intPart + 1.0;
    }
}
