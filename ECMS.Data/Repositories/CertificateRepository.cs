using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using ECMS.Core.DTOs;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class CertificateRepository : ICertificateRepository
{
    public Task EnsureSeedCertificatesAsync() => Task.CompletedTask;

    public async Task<IEnumerable<EligibleStudentDto>> GetEligibleStudentsAsync(string? keyword = null, string? courseName = null, string? className = null)
    {
        await EnsureSeedCertificatesAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string sql = @"
            SELECT 
                e.EnrollmentId,
                s.StudentId,
                s.StudentCode,
                s.FullName,
                co.CourseName,
                cl.ClassCode AS ClassName,
                cl.Status AS ClassStatus,
                e.FinalGPA,
                e.AttendanceRate,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Regular' ORDER BY ex.ExamId DESC LIMIT 1) AS RegularVal,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Midterm' ORDER BY ex.ExamId DESC LIMIT 1) AS MidtermVal,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Final' ORDER BY ex.ExamId DESC LIMIT 1) AS FinalVal,
                COALESCE(i.BalanceDue, 0) AS BalanceDue,
                COALESCE(co.PassingScore, 6.5) AS PassingScore
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            INNER JOIN Classes cl ON e.ClassId = cl.ClassId
            INNER JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN Invoices i ON i.EnrollmentId = e.EnrollmentId
            WHERE (@Kw IS NULL OR s.StudentCode LIKE @Kw OR s.FullName LIKE @Kw OR cl.ClassName LIKE @Kw OR co.CourseName LIKE @Kw)
              AND (@CourseName IS NULL OR co.CourseName = @CourseName)
              AND (@ClassName IS NULL OR cl.ClassName = @ClassName OR cl.ClassCode = @ClassName)
              AND e.EnrollmentId NOT IN (SELECT EnrollmentId FROM Certificates)
            ORDER BY e.EnrollmentId ASC;";

        var rawList = await conn.QueryAsync(sql, new
        {
            Kw = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword}%",
            CourseName = (courseName == "Tất cả khóa học" || string.IsNullOrWhiteSpace(courseName)) ? null : courseName,
            ClassName = (className == "Tất cả lớp" || string.IsNullOrWhiteSpace(className)) ? null : className
        });

        var result = new List<EligibleStudentDto>();
        foreach (var r in rawList)
        {
            bool hasAll3 = r.RegularVal != null && r.MidtermVal != null && r.FinalVal != null;
            bool isCompletedClass = string.Equals((string?)r.ClassStatus, "Completed", StringComparison.OrdinalIgnoreCase);

            decimal? computedGpa = null;
            if (hasAll3)
            {
                decimal reg = Convert.ToDecimal(r.RegularVal);
                decimal mid = Convert.ToDecimal(r.MidtermVal);
                decimal fin = Convert.ToDecimal(r.FinalVal);
                computedGpa = Math.Round(reg * 0.2m + mid * 0.3m + fin * 0.5m, 1);
            }
            else if (isCompletedClass && r.FinalGPA != null)
            {
                computedGpa = Convert.ToDecimal(r.FinalGPA);
            }

            decimal gpa = computedGpa ?? 0m;
            bool hasAtt = r.AttendanceRate != null;
            decimal att = hasAtt ? Convert.ToDecimal(r.AttendanceRate) : 0m;
            decimal debt = Convert.ToDecimal(r.BalanceDue);

            string rank = !computedGpa.HasValue
                ? "Chưa có điểm"
                : (gpa >= 8.5m ? "Xuất sắc" : (gpa >= 8.0m ? "Giỏi" : (gpa >= 6.5m ? "Khá" : "Trung bình")));

            bool isEligible = computedGpa.HasValue && gpa >= 6.5m && hasAtt && att >= 80m && debt <= 0;
            string statusText = isEligible ? "Đủ điều kiện" : "Chưa đủ điều kiện";

            result.Add(new EligibleStudentDto
            {
                EnrollmentId = (int)r.EnrollmentId,
                StudentId = (int)r.StudentId,
                StudentCode = (string)r.StudentCode,
                FullName = (string)r.FullName,
                CourseName = (string)r.CourseName,
                ClassName = (string)r.ClassName,
                FinalGPA = gpa,
                AttendanceRate = att,
                BalanceDue = debt,
                IsEligible = isEligible,
                StatusText = statusText,
                GradeRank = rank,
                ScoreText = computedGpa.HasValue ? $"{gpa:0.0}" : "Chưa có",
                AttendanceText = hasAtt ? $"{att:0.0}%" : "Chưa có",
                TuitionText = debt <= 0 ? "Đã hoàn tất" : $"Nợ {debt:N0}đ"
            });
        }

        return result;
    }

    public async Task<IEnumerable<IssuedCertificateDto>> GetIssuedCertificatesAsync(string? keyword = null)
    {
        await EnsureSeedCertificatesAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string sql = @"
            SELECT 
                c.CertificateId,
                c.CertificateNo AS SerialNumber,
                s.StudentCode,
                s.FullName AS StudentName,
                co.CourseName,
                cl.ClassCode AS ClassName,
                strftime('%d/%m/%Y', c.IssueDate) AS IssueDate,
                'Trần Minh Quân (Giám đốc trung tâm)' AS Approver,
                'Đã cấp · Chưa in' AS Status,
                COALESCE(printf('%.1f', e.FinalGPA) || ' / 10', '8.0 / 10') AS Score,
                c.GraduationGrade AS GradeRank,
                COALESCE(CAST(ROUND(e.AttendanceRate, 1) AS TEXT) || '%', '95%') AS Attendance
            FROM Certificates c
            INNER JOIN Enrollments e ON c.EnrollmentId = e.EnrollmentId
            INNER JOIN Students s ON c.StudentId = s.StudentId
            INNER JOIN Classes cl ON e.ClassId = cl.ClassId
            INNER JOIN Courses co ON cl.CourseId = co.CourseId
            WHERE (@Kw IS NULL OR c.CertificateNo LIKE @Kw OR s.StudentCode LIKE @Kw OR s.FullName LIKE @Kw OR cl.ClassName LIKE @Kw)
            ORDER BY c.CertificateId DESC;";

        return await conn.QueryAsync<IssuedCertificateDto>(sql, new
        {
            Kw = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword}%"
        });
    }

    public async Task<(bool Success, string Message, string SerialNumber)> IssueCertificateAsync(
        int enrollmentId, 
        int studentId, 
        string graduationGrade, 
        string approver, 
        string serialNumber)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            string insertSql = @"
                INSERT INTO Certificates (CertificateNo, EnrollmentId, StudentId, IssueDate, GraduationGrade)
                VALUES (@CertificateNo, @EnrollmentId, @StudentId, date('now', 'localtime'), @GraduationGrade);";

            await conn.ExecuteAsync(insertSql, new
            {
                CertificateNo = serialNumber,
                EnrollmentId = enrollmentId,
                StudentId = studentId,
                GraduationGrade = string.IsNullOrWhiteSpace(graduationGrade) ? "Khá" : graduationGrade
            }, trans);

            // Cập nhật trạng thái Enrollment thành Completed
            await conn.ExecuteAsync(@"
                UPDATE Enrollments 
                SET Status = 'Completed', UpdatedAt = datetime('now', 'localtime') 
                WHERE EnrollmentId = @EnrollmentId;", new { EnrollmentId = enrollmentId }, trans);

            trans.Commit();
            return (true, "Cấp chứng chỉ thành công!", serialNumber);
        }
        catch (Exception ex)
        {
            trans.Rollback();
            return (false, $"Lỗi ghi nhận CSDL: {ex.Message}", string.Empty);
        }
    }
}
