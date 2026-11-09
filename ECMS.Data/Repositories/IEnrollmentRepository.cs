using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IEnrollmentRepository
{
    Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync();
    Task<ClassLookupDto?> GetClassByIdAsync(int classId);
    Task<string> GenerateNextStudentCodeAsync();
    Task<int?> FindStudentIdByPhoneAsync(string phone);
    Task<bool> CheckStudentEnrolledAsync(int studentId, int classId);
    Task<(bool Success, string Message, int StudentId, int EnrollmentId)> ExecuteEnrollmentTransactionAsync(StudentEnrollmentDto dto, string studentCode);
    Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50);
}
