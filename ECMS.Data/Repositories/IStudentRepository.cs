using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

/// <summary>
/// Repository quản lý dữ liệu Học viên (Truy vấn CSDL SQLite qua Dapper)
/// </summary>
public interface IStudentRepository
{
    Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null);
    Task<StudentDetailDto?> GetStudentDetailByIdAsync(int studentId);
    Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode);
    Task<bool> UpdateStudentProfileAsync(UpdateStudentProfileDto dto);
    Task<bool> ArchiveStudentAsync(ArchiveStudentDto dto);
    Task<StudentOverviewStatsDto> GetStudentStatsAsync();
    Task<string> GenerateNextStudentCodeAsync();
    Task EnsureStudentSeedDataAsync();
}
