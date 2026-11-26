using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class ExamRepository : BaseRepository, IExamRepository
{
    public async Task<IEnumerable<ExamListItemDto>> GetAllExamsAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                ex.ExamId,
                ex.ClassId,
                c.ClassCode,
                co.CourseName,
                ex.ExamName,
                ex.Type,
                ex.ExamDate,
                COALESCE(ex.StartTime, '18:00') AS StartTime,
                COALESCE(ex.EndTime, '19:30') AS EndTime,
                ex.RoomId,
                COALESCE(r.RoomName, rDef.RoomName, 'Chưa xếp phòng') AS RoomName,
                ex.WeightPercentage,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = ex.ClassId AND e.Status IN ('Active', 'PendingPayment', 'Completed')) AS TotalStudents,
                (SELECT COUNT(*) FROM ExamScores es WHERE es.ExamId = ex.ExamId) AS GradedCount
            FROM Exams ex
            INNER JOIN Classes c ON ex.ClassId = c.ClassId
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms r ON ex.RoomId = r.RoomId
            LEFT JOIN ClassRooms rDef ON c.DefaultRoomId = rDef.RoomId
            WHERE ex.Type IN ('Regular', 'Midterm', 'Final')
            ORDER BY ex.ExamDate DESC, ex.StartTime ASC;";

        return await conn.QueryAsync<ExamListItemDto>(sql);
    }

    public async Task<(bool Success, string Message)> CreateExamsWithConflictCheckAsync(CreateExamRequestDto req)
    {
        if (string.IsNullOrWhiteSpace(req.ExamName))
            return (false, "Vui lòng nhập tên bài kiểm tra / kỳ thi.");
        if (req.ClassIds == null || req.ClassIds.Count == 0)
            return (false, "Vui lòng chọn ít nhất 1 lớp áp dụng.");
        if (string.CompareOrdinal(req.EndTime, req.StartTime) <= 0)
            return (false, "Giờ kết thúc thi phải lớn hơn giờ bắt đầu thi.");

        string dateStr = req.ExamDate.ToString("yyyy-MM-dd");
        using var conn = CreateConnection();

        foreach (int classId in req.ClassIds.Distinct())
        {
            string classCode = await conn.ExecuteScalarAsync<string>(
                "SELECT ClassCode FROM Classes WHERE ClassId = @Id;", new { Id = classId }) ?? $"#{classId}";

            int? roomIdToCheck = req.RoomId;
            if (!roomIdToCheck.HasValue || roomIdToCheck.Value <= 0)
            {
                roomIdToCheck = await conn.ExecuteScalarAsync<int?>(
                    "SELECT DefaultRoomId FROM Classes WHERE ClassId = @Id;", new { Id = classId });
            }

            // 1. Kiểm tra trùng với lịch thi khác của cùng lớp trong cùng ngày & giờ
            var dupExamClass = await conn.QueryFirstOrDefaultAsync<(string ExamName, string StartTime, string EndTime)?>(@"
                SELECT ExamName, COALESCE(StartTime, '18:00') AS StartTime, COALESCE(EndTime, '19:30') AS EndTime
                FROM Exams
                WHERE ClassId = @ClassId
                  AND ExamDate = @Date
                  AND COALESCE(StartTime, '18:00') < @EndTime
                  AND COALESCE(EndTime, '19:30') > @StartTime
                LIMIT 1;",
                new { ClassId = classId, Date = dateStr, req.StartTime, req.EndTime });

            if (dupExamClass.HasValue)
            {
                return (false, $"Trùng lịch thi: Lớp {classCode} đã có bài thi '{dupExamClass.Value.ExamName}' vào ngày {req.ExamDate:dd/MM/yyyy} ({dupExamClass.Value.StartTime} - {dupExamClass.Value.EndTime}).");
            }

            // 2. Kiểm tra trùng với lịch thi của lớp khác dùng chung phòng
            if (roomIdToCheck.HasValue && roomIdToCheck.Value > 0)
            {
                var dupExamRoom = await conn.QueryFirstOrDefaultAsync<(string ClassCode, string ExamName, string StartTime, string EndTime)?>(@"
                    SELECT c.ClassCode, ex.ExamName, COALESCE(ex.StartTime, '18:00') AS StartTime, COALESCE(ex.EndTime, '19:30') AS EndTime
                    FROM Exams ex
                    INNER JOIN Classes c ON ex.ClassId = c.ClassId
                    WHERE COALESCE(ex.RoomId, c.DefaultRoomId) = @RoomId
                      AND ex.ExamDate = @Date
                      AND ex.ClassId != @ClassId
                      AND COALESCE(ex.StartTime, '18:00') < @EndTime
                      AND COALESCE(ex.EndTime, '19:30') > @StartTime
                    LIMIT 1;",
                    new { RoomId = roomIdToCheck.Value, Date = dateStr, ClassId = classId, req.StartTime, req.EndTime });

                if (dupExamRoom.HasValue)
                {
                    return (false, $"Trùng phòng thi ngày {req.ExamDate:dd/MM/yyyy} ({req.StartTime} - {req.EndTime}): Phòng đã được xếp cho lớp {dupExamRoom.Value.ClassCode} thi '{dupExamRoom.Value.ExamName}'.");
                }

                // 3. Kiểm tra trùng phòng với lịch học của lớp khác
                var dupClassRoom = await conn.QueryFirstOrDefaultAsync<(string ClassCode, string StartTime, string EndTime)?>(@"
                    SELECT c.ClassCode, cs.StartTime, cs.EndTime
                    FROM ClassSchedules cs
                    INNER JOIN Classes c ON cs.ClassId = c.ClassId
                    WHERE cs.RoomId = @RoomId
                      AND cs.Date = @Date
                      AND cs.ClassId != @ClassId
                      AND cs.StartTime < @EndTime
                      AND cs.EndTime > @StartTime
                    LIMIT 1;",
                    new { RoomId = roomIdToCheck.Value, Date = dateStr, ClassId = classId, req.StartTime, req.EndTime });

                if (dupClassRoom.HasValue)
                {
                    return (false, $"Trùng phòng với lịch học ngày {req.ExamDate:dd/MM/yyyy}: Phòng đang có lớp {dupClassRoom.Value.ClassCode} học ({dupClassRoom.Value.StartTime} - {dupClassRoom.Value.EndTime}).");
                }
            }
        }

        using var tran = conn.BeginTransaction();
        try
        {
            foreach (int classId in req.ClassIds.Distinct())
            {
                int? finalRoomId = req.RoomId;
                if (!finalRoomId.HasValue || finalRoomId.Value <= 0)
                {
                    finalRoomId = await conn.ExecuteScalarAsync<int?>(
                        "SELECT DefaultRoomId FROM Classes WHERE ClassId = @Id;", new { Id = classId }, tran);
                }

                await conn.ExecuteAsync(@"
                    INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, StartTime, EndTime, RoomId, WeightPercentage, CreatedAt)
                    VALUES (@ClassId, @ExamName, @Type, @ExamDate, @StartTime, @EndTime, @RoomId, @WeightPercentage, CURRENT_TIMESTAMP);",
                    new
                    {
                        ClassId = classId,
                        ExamName = req.ExamName.Trim(),
                        req.Type,
                        ExamDate = dateStr,
                        req.StartTime,
                        req.EndTime,
                        RoomId = finalRoomId,
                        req.WeightPercentage
                    }, tran);
            }

            tran.Commit();
            return (true, $"Đã tạo bài kiểm tra và xếp lịch thi cho {req.ClassIds.Distinct().Count()} lớp thành công.");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi khi tạo lịch thi: " + ex.Message);
        }
    }

    public async Task<(bool Success, string Message)> DeleteExamAsync(int examId)
    {
        using var conn = CreateConnection();
        int scoreCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ExamScores WHERE ExamId = @Id;", new { Id = examId });
        if (scoreCnt > 0)
            return (false, $"Không thể xóa lịch thi đã có {scoreCnt} kết quả điểm của học viên.");

        int rows = await conn.ExecuteAsync("DELETE FROM Exams WHERE ExamId = @Id;", new { Id = examId });
        return rows > 0
            ? (true, "Đã xóa lịch thi thành công.")
            : (false, "Không tìm thấy lịch thi cần xóa.");
    }

    public async Task<IEnumerable<StudentGradeEntryDto>> GetClassGradeEntriesAsync(int classId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Regular' ORDER BY ex.ExamId DESC LIMIT 1) AS RegularScore,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Midterm' ORDER BY ex.ExamId DESC LIMIT 1) AS MidtermScore,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Final' ORDER BY ex.ExamId DESC LIMIT 1) AS FinalScore
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            WHERE e.ClassId = @ClassId
              AND e.Status IN ('Active', 'PendingPayment', 'Completed')
            ORDER BY s.StudentCode ASC;";

        return await conn.QueryAsync<StudentGradeEntryDto>(sql, new { ClassId = classId });
    }

    public async Task<(bool Success, string Message)> SaveClassGradeEntriesAsync(int classId, List<StudentGradeEntryDto> entries)
    {
        if (classId <= 0) return (false, "Mã lớp không hợp lệ.");
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            async Task<int> EnsureExamIdAsync(string type, string defaultName, double weight)
            {
                int? existing = await conn.ExecuteScalarAsync<int?>(
                    "SELECT ExamId FROM Exams WHERE ClassId = @ClassId AND Type = @Type ORDER BY ExamId DESC LIMIT 1;",
                    new { ClassId = classId, Type = type }, tran);
                if (existing.HasValue && existing.Value > 0) return existing.Value;

                return await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, StartTime, EndTime, WeightPercentage, CreatedAt)
                    VALUES (@ClassId, @Name, @Type, @Date, '18:00', '19:30', @Weight, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new { ClassId = classId, Name = defaultName, Type = type, Date = DateTime.Today.ToString("yyyy-MM-dd"), Weight = weight }, tran);
            }

            int? regExamId = null;
            int? midExamId = null;
            int? finExamId = null;

            foreach (var item in entries)
            {
                if (item.RegularScore.HasValue)
                {
                    regExamId ??= await EnsureExamIdAsync("Regular", "Kiểm tra thường xuyên", 20);
                    await UpsertScoreAsync(conn, tran, regExamId.Value, item.StudentId, item.RegularScore.Value);
                }
                if (item.MidtermScore.HasValue)
                {
                    midExamId ??= await EnsureExamIdAsync("Midterm", "Kiểm tra giữa khóa", 30);
                    await UpsertScoreAsync(conn, tran, midExamId.Value, item.StudentId, item.MidtermScore.Value);
                }
                if (item.FinalScore.HasValue)
                {
                    finExamId ??= await EnsureExamIdAsync("Final", "Thi cuối khóa", 50);
                    await UpsertScoreAsync(conn, tran, finExamId.Value, item.StudentId, item.FinalScore.Value);
                }

                // Cập nhật FinalGPA nếu có đủ 3 cột điểm
                if (item.RegularScore.HasValue && item.MidtermScore.HasValue && item.FinalScore.HasValue)
                {
                    double gpa = Math.Round(item.RegularScore.Value * 0.2 + item.MidtermScore.Value * 0.3 + item.FinalScore.Value * 0.5, 2);
                    await conn.ExecuteAsync(
                        "UPDATE Enrollments SET FinalGPA = @Gpa, UpdatedAt = CURRENT_TIMESTAMP WHERE ClassId = @ClassId AND StudentId = @StudentId;",
                        new { Gpa = gpa, ClassId = classId, item.StudentId }, tran);
                }
            }

            tran.Commit();
            return (true, $"Đã lưu bảng điểm của {entries.Count} học viên vào cơ sở dữ liệu thành công.");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi lưu bảng điểm: " + ex.Message);
        }
    }

    private static Task UpsertScoreAsync(System.Data.IDbConnection conn, System.Data.IDbTransaction tran, int examId, int studentId, double score)
    {
        return conn.ExecuteAsync(@"
            INSERT INTO ExamScores (ExamId, StudentId, ScoreValue, CreatedAt)
            VALUES (@ExamId, @StudentId, @Score, CURRENT_TIMESTAMP)
            ON CONFLICT(ExamId, StudentId) DO UPDATE SET
                ScoreValue = excluded.ScoreValue,
                UpdatedAt = CURRENT_TIMESTAMP;",
            new { ExamId = examId, StudentId = studentId, Score = Math.Clamp(score, 0, 10) }, tran);
    }

    public async Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                COALESCE(co.CourseName, 'Khóa học chung') AS CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(co.PassingScore, 5.0) AS PassingScore,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status NOT IN ('Cancelled', 'Dropped')) AS StudentCount
            FROM Classes c
            LEFT JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            ORDER BY c.ClassId ASC;";
        return await conn.QueryAsync<ClassExamLookupDto>(sql);
    }

    public async Task<int> CreateExamAsync(CreateExamDto dto)
    {
        using var conn = CreateConnection();
        string normType = dto.Type switch
        {
            var t when t.Contains("Giữa", StringComparison.OrdinalIgnoreCase) || t.Contains("Midterm", StringComparison.OrdinalIgnoreCase) => "Midterm",
            var t when t.Contains("Cuối", StringComparison.OrdinalIgnoreCase) || t.Contains("Final", StringComparison.OrdinalIgnoreCase) => "Final",
            _ => "Regular"
        };

        const string sql = @"
            INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, StartTime, EndTime, WeightPercentage, CreatedAt)
            VALUES (@ClassId, @ExamName, @Type, @ExamDate, '18:00', '19:30', @WeightPercentage, CURRENT_TIMESTAMP);
            SELECT last_insert_rowid();";
        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            dto.ClassId,
            dto.ExamName,
            Type = normType,
            ExamDate = string.IsNullOrWhiteSpace(dto.ExamDate) ? DateTime.Today.ToString("yyyy-MM-dd") : dto.ExamDate,
            dto.WeightPercentage
        });
    }

    public async Task<IEnumerable<ClassGradeRowDto>> GetClassGradeBookAsync(int classId)
    {
        using var conn = CreateConnection();
        decimal passingScore = await conn.ExecuteScalarAsync<decimal?>(@"
            SELECT COALESCE(co.PassingScore, 5.0)
            FROM Classes c
            LEFT JOIN Courses co ON c.CourseId = co.CourseId
            WHERE c.ClassId = @ClassId;", new { ClassId = classId }) ?? 5.0m;

        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                es.ListeningScore,
                es.ReadingScore,
                es.WritingScore,
                es.SpeakingScore,
                COALESCE(es.OverallScore, es.ScoreValue, e.FinalGPA) AS OverallScore
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            LEFT JOIN ExamScores es ON es.StudentId = s.StudentId
                AND es.ExamId = (SELECT ex.ExamId FROM Exams ex WHERE ex.ClassId = e.ClassId ORDER BY ex.ExamId DESC LIMIT 1)
            WHERE e.ClassId = @ClassId
              AND e.Status NOT IN ('Cancelled', 'Dropped')
            ORDER BY s.StudentCode ASC;";

        var rows = (await conn.QueryAsync<ClassGradeRowDto>(sql, new { ClassId = classId })).ToList();
        foreach (var r in rows)
        {
            if (r.OverallScore.HasValue)
            {
                r.ListeningScore ??= r.OverallScore;
                r.ReadingScore ??= r.OverallScore;
                r.WritingScore ??= r.OverallScore;
                r.SpeakingScore ??= r.OverallScore;
                r.ResultText = r.OverallScore.Value >= passingScore
                    ? $"✓ Đạt (Band {r.OverallScore.Value:0.0})"
                    : $"✕ Chưa đạt ({r.OverallScore.Value:0.0})";
            }
            else
            {
                r.ResultText = "--";
            }
        }
        return rows;
    }

    public async Task SaveClassGradeBookAsync(int classId, List<ClassGradeRowDto> rows)
    {
        if (classId <= 0) return;
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            int? examId = await conn.ExecuteScalarAsync<int?>(
                "SELECT ExamId FROM Exams WHERE ClassId = @ClassId ORDER BY ExamId DESC LIMIT 1;",
                new { ClassId = classId }, tran);

            if (!examId.HasValue || examId.Value <= 0)
            {
                examId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Exams (ClassId, ExamName, Type, ExamDate, StartTime, EndTime, WeightPercentage, CreatedAt)
                    VALUES (@ClassId, 'Kiểm tra đánh giá tổng hợp', 'Final', @Date, '18:00', '19:30', 100.0, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new { ClassId = classId, Date = DateTime.Today.ToString("yyyy-MM-dd") }, tran);
            }

            foreach (var r in rows)
            {
                if (!r.OverallScore.HasValue && !r.ListeningScore.HasValue && !r.ReadingScore.HasValue && !r.WritingScore.HasValue && !r.SpeakingScore.HasValue)
                    continue;

                decimal overall = r.OverallScore ?? 0m;
                await conn.ExecuteAsync(@"
                    INSERT INTO ExamScores (ExamId, StudentId, ListeningScore, ReadingScore, WritingScore, SpeakingScore, OverallScore, ScoreValue, TeacherComments, CreatedAt)
                    VALUES (@ExamId, @StudentId, @L, @R, @W, @S, @O, @O, @Comment, CURRENT_TIMESTAMP)
                    ON CONFLICT(ExamId, StudentId) DO UPDATE SET
                        ListeningScore = excluded.ListeningScore,
                        ReadingScore = excluded.ReadingScore,
                        WritingScore = excluded.WritingScore,
                        SpeakingScore = excluded.SpeakingScore,
                        OverallScore = excluded.OverallScore,
                        ScoreValue = excluded.ScoreValue,
                        TeacherComments = excluded.TeacherComments,
                        UpdatedAt = CURRENT_TIMESTAMP;",
                    new
                    {
                        ExamId = examId.Value,
                        r.StudentId,
                        L = r.ListeningScore,
                        R = r.ReadingScore,
                        W = r.WritingScore,
                        S = r.SpeakingScore,
                        O = overall,
                        r.Comment
                    }, tran);

                await conn.ExecuteAsync(
                    "UPDATE Enrollments SET FinalGPA = @Gpa, UpdatedAt = CURRENT_TIMESTAMP WHERE ClassId = @ClassId AND StudentId = @StudentId;",
                    new { Gpa = overall, ClassId = classId, r.StudentId }, tran);
            }

            tran.Commit();
        }
        catch
        {
            tran.Rollback();
            throw;
        }
    }
}
