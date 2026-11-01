using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task<IEnumerable<Student>> SearchStudentsAsync(string keyword);
    Task<Student?> GetStudentByIdAsync(int studentId);
    Task<string> GenerateNextStudentCodeAsync();
    Task<int> CreateStudentAsync(Student student);
    Task<bool> UpdateStudentAsync(Student student);
    Task<(bool Success, string Message)> DeleteStudentAsync(int studentId);
}

public class StudentService : IStudentService
{
    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync<Student>("SELECT * FROM Students ORDER BY StudentId DESC;");
    }

    public async Task<IEnumerable<Student>> SearchStudentsAsync(string keyword)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await conn.QueryAsync<Student>("SELECT * FROM Students ORDER BY StudentId DESC;");
        }

        string sql = @"
            SELECT * FROM Students 
            WHERE FullName LIKE @Pattern OR StudentCode LIKE @Pattern OR Phone LIKE @Pattern
            ORDER BY StudentId DESC;";
        return await conn.QueryAsync<Student>(sql, new { Pattern = "%" + keyword.Trim() + "%" });
    }

    public async Task<Student?> GetStudentByIdAsync(int studentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Student>("SELECT * FROM Students WHERE StudentId = @Id;", new { Id = studentId });
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string yearPrefix = $"HV-{DateTime.Now.Year}-";
        int countThisYear = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Students WHERE StudentCode LIKE @Prefix;", new { Prefix = yearPrefix + "%" });
        return $"{yearPrefix}{(countThisYear + 1):D4}";
    }

    public async Task<int> CreateStudentAsync(Student student)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        if (string.IsNullOrWhiteSpace(student.StudentCode))
        {
            student.StudentCode = await GenerateNextStudentCodeAsync();
        }

        string sql = @"
            INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, AvatarPath, Status, LeadId)
            VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, @AvatarPath, @StatusStr, @LeadId);
            SELECT last_insert_rowid();";

        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            student.StudentCode,
            student.FullName,
            DobStr = student.DateOfBirth.ToString("yyyy-MM-dd"),
            student.Gender,
            student.Phone,
            student.Email,
            student.Address,
            student.AvatarPath,
            StatusStr = student.Status.ToString(),
            student.LeadId
        });
    }

    public async Task<bool> UpdateStudentAsync(Student student)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            UPDATE Students SET
                FullName = @FullName,
                DateOfBirth = @DobStr,
                Gender = @Gender,
                Phone = @Phone,
                Email = @Email,
                Address = @Address,
                AvatarPath = @AvatarPath,
                Status = @StatusStr,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE StudentId = @StudentId;";

        int rows = await conn.ExecuteAsync(sql, new
        {
            student.FullName,
            DobStr = student.DateOfBirth.ToString("yyyy-MM-dd"),
            student.Gender,
            student.Phone,
            student.Email,
            student.Address,
            student.AvatarPath,
            StatusStr = student.Status.ToString(),
            student.StudentId
        });

        return rows > 0;
    }

    public async Task<(bool Success, string Message)> DeleteStudentAsync(int studentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();

        // 1. Check if student has invoices or attendance records
        int invoiceCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Invoices inv INNER JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId WHERE e.StudentId = @Id;",
            new { Id = studentId });

        if (invoiceCount > 0)
        {
            return (false, "Không thể xóa học viên đã phát sinh hóa đơn học phí! Bạn có thể chuyển trạng thái sang 'Nghỉ học'.");
        }

        int attendanceCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM AttendanceRecords WHERE StudentId = @Id;", new { Id = studentId });

        if (attendanceCount > 0)
        {
            return (false, "Không thể xóa học viên đã có lịch sử điểm danh lớp học!");
        }

        // 2. Safe to delete
        await conn.ExecuteAsync("DELETE FROM Students WHERE StudentId = @Id;", new { Id = studentId });
        return (true, "Đã xóa hồ sơ học viên thành công.");
    }
}
