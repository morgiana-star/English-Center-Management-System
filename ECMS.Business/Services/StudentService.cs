using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;
using ECMS.Data.Repositories;
using Dapper;

namespace ECMS.Business.Services;

public interface IStudentService
{
    // 1. Nghiệp vụ DTO theo kiến trúc 4 tầng
    Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null);
    Task<StudentDetailDto?> GetStudentDetailAsync(int studentId);
    Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode);
    Task<(bool Success, string Message)> UpdateStudentProfileAsync(UpdateStudentProfileDto dto);
    Task<(bool Success, string Message)> ArchiveStudentAsync(ArchiveStudentDto dto);
    Task<StudentOverviewStatsDto> GetStudentStatsAsync();
    Task<string> GenerateNextStudentCodeAsync();

    // 2. Nghiệp vụ Entity tương thích ngược
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task<IEnumerable<Student>> SearchStudentsAsync(string keyword);
    Task<Student?> GetStudentByIdAsync(int studentId);
    Task<int> CreateStudentAsync(Student student);
    Task<bool> UpdateStudentAsync(Student student);
    Task<(bool Success, string Message)> DeleteStudentAsync(int studentId);
}

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepo;

    public StudentService(IStudentRepository? studentRepo = null)
    {
        _studentRepo = studentRepo ?? new StudentRepository();
    }

    #region Nghiệp vụ DTO (Tầng Business 4 lớp)

    public async Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null)
    {
        string? cleanKw = !string.IsNullOrWhiteSpace(keyword) ? keyword.Trim() : null;
        return await _studentRepo.GetStudentListAsync(cleanKw, status, classId);
    }

    public async Task<StudentDetailDto?> GetStudentDetailAsync(int studentId)
    {
        if (studentId <= 0) return null;
        return await _studentRepo.GetStudentDetailByIdAsync(studentId);
    }

    public async Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode)
    {
        if (string.IsNullOrWhiteSpace(studentCode)) return null;
        return await _studentRepo.GetStudentDetailByCodeAsync(studentCode.Trim());
    }

    public async Task<(bool Success, string Message)> UpdateStudentProfileAsync(UpdateStudentProfileDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.FullName))
            return (false, "Họ và tên học viên không được để trống.");

        if (string.IsNullOrWhiteSpace(dto.Phone))
            return (false, "Số điện thoại học viên không được để trống.");

        bool updated = await _studentRepo.UpdateStudentProfileAsync(dto);
        return updated
            ? (true, "Cập nhật hồ sơ học viên thành công!")
            : (false, "Cập nhật hồ sơ học viên thất bại.");
    }

    public async Task<(bool Success, string Message)> ArchiveStudentAsync(ArchiveStudentDto dto)
    {
        if (dto.StudentId <= 0)
            return (false, "Mã định danh học viên không hợp lệ.");

        bool archived = await _studentRepo.ArchiveStudentAsync(dto);
        return archived
            ? (true, "Đã lưu trữ hồ sơ học viên thành công!")
            : (false, "Lưu trữ hồ sơ học viên thất bại.");
    }

    public async Task<StudentOverviewStatsDto> GetStudentStatsAsync()
    {
        return await _studentRepo.GetStudentStatsAsync();
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        return await _studentRepo.GenerateNextStudentCodeAsync();
    }

    #endregion

    #region Nghiệp vụ Entity (Tương thích ngược)

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

        int invoiceCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Invoices inv INNER JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId WHERE e.StudentId = @Id;",
            new { Id = studentId });

        if (invoiceCount > 0)
        {
            return (false, "Không thể xóa học viên đã phát sinh hóa đơn học phí! Bạn có thể chuyển trạng thái sang 'Nghỉ học' hoặc 'Bảo lưu'.");
        }

        int attendanceCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM AttendanceRecords WHERE StudentId = @Id;", new { Id = studentId });

        if (attendanceCount > 0)
        {
            return (false, "Không thể xóa học viên đã có lịch sử điểm danh lớp học!");
        }

        await conn.ExecuteAsync("DELETE FROM Students WHERE StudentId = @Id;", new { Id = studentId });
        return (true, "Đã xóa hồ sơ học viên thành công.");
    }

    #endregion
}
