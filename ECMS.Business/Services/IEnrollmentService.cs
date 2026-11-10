using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IEnrollmentService
{
    Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync();
    Task<ClassLookupDto?> GetClassByIdAsync(int classId);
    Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync();
    Task<bool> IsExistingStudentByPhoneAsync(string phone);
    Task<(bool Success, string Message, int StudentId, string StudentCode, int EnrollmentId, string InvoiceCode, decimal FinalAmount)> EnrollStudentAsync(
        StudentEnrollmentDto dto,
        int? currentUserId = null);
    Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50);
}
