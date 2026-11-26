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
    Task<IEnumerable<ClassFilterItemDto>> GetClassesForFilterAsync();
    Task<StudentDetailDto?> GetStudentDetailByIdAsync(int studentId);
    Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode);
    Task<bool> UpdateStudentProfileAsync(UpdateStudentProfileDto dto);
    Task<decimal> GetStudentOutstandingDebtAsync(int studentId);
    Task<bool> ArchiveStudentAsync(ArchiveStudentDto dto);
    Task<(bool Success, string Message)> RestoreStudentAsync(int studentId);
    Task<(bool Success, string Message)> DeleteStudentWithChecksAsync(int studentId);
    Task<(bool IsDuplicate, string Reason)> CheckDuplicateStudentAsync(string phone, string fullName, System.DateTime dateOfBirth, int excludeStudentId = 0);
    Task<(bool Success, string Message, int StudentId, string StudentCode)> CreateWaitingStudentAsync(StudentEnrollmentWithTuitionDto dto);
    Task<StudentOverviewStatsDto> GetStudentStatsAsync();
    Task<string> GenerateNextStudentCodeAsync();
    Task<IEnumerable<CourseLookupDto>> GetActiveCoursesForEnrollmentAsync();
    Task<IEnumerable<OpenClassOptionDto>> GetOpenClassesByCourseAsync(int courseId);
    Task<HashSet<string>> GetExistingStudentPhonesAsync();
    Task<StudentImportResultDto> ImportStudentsBatchAsync(List<StudentImportRowDto> validStudents);
    Task EnsureStudentSeedDataAsync();
}
