using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IEnrollmentService
{
    Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync();
    Task<ClassLookupDto?> GetClassByIdAsync(int classId);
    Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync();
    Task<IEnumerable<FeeDiscountDto>> GetAllDiscountsAsync();
    Task<FeeDiscountDto?> GetDiscountByCodeAsync(string discountCode);
    Task<(bool Success, string Message)> CreateDiscountAsync(FeeDiscountDto dto);
    Task<(bool Success, string Message)> UpdateDiscountAsync(FeeDiscountDto dto);
    Task<(bool Success, string Message)> DeleteDiscountAsync(int discountId);
    Task<bool> IsExistingStudentByPhoneAsync(string phone);
    Task<(bool Success, string Message, int StudentId, string StudentCode, int EnrollmentId, string InvoiceCode, decimal FinalAmount)> EnrollStudentAsync(
        StudentEnrollmentDto dto,
        int? currentUserId = null);
    Task<(bool Success, string Message, int StudentId, string StudentCode, string InvoiceCode, string ReceiptCode)> EnrollStudentWithTuitionAsync(
        StudentEnrollmentWithTuitionDto dto);
    Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50);
}
