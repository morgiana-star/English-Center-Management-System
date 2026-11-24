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
                cl.ClassName,
                COALESCE(e.FinalGPA, 7.5) AS FinalGPA,
                COALESCE(e.AttendanceRate, 90.0) AS AttendanceRate,
                COALESCE(i.BalanceDue, 0) AS BalanceDue,
                COALESCE(co.PassingScore, 5.0) AS PassingScore
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
            decimal gpa = Convert.ToDecimal(r.FinalGPA);
            decimal att = Convert.ToDecimal(r.AttendanceRate);
            decimal debt = Convert.ToDecimal(r.BalanceDue);
            decimal passingScore = Convert.ToDecimal(r.PassingScore);

            string rank = gpa >= 8.5m ? "Xuất sắc" : (gpa >= 8.0m ? "Giỏi" : (gpa >= 6.5m ? "Khá" : "Trung bình"));
            bool isEligible = gpa >= 6.5m && att >= 80m && debt <= 0;

            string statusText;
            if (gpa < 6.5m) statusText = "✕ TB < 6.5 (Chưa đạt)";
            else if (att < 80m) statusText = "⚠️ Chuyên cần < 80%";
            else if (debt > 0) statusText = $"⚠️ Còn nợ ({debt:N0}đ)";
            else statusText = "✓ Đủ điều kiện";

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
                ScoreText = $"{gpa:N1} · {rank}",
                AttendanceText = $"{att:N1}%",
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
                cl.ClassName,
                strftime('%d/%m/%Y', c.IssueDate) AS IssueDate,
                'Trần Minh Quân (Admin)' AS Approver,
                'Đã cấp · Chưa in' AS Status,
                COALESCE(CAST(e.FinalGPA AS TEXT) || ' / 10', '8.0 / 10') AS Score,
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
