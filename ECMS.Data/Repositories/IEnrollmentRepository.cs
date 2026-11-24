using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IEnrollmentRepository
{
    Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync();
    Task<ClassLookupDto?> GetClassByIdAsync(int classId);
    Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync();
    Task<IEnumerable<FeeDiscountDto>> GetAllDiscountsAsync();
    Task<FeeDiscountDto?> GetDiscountByIdAsync(int discountId);
    Task<FeeDiscountDto?> GetDiscountByCodeAsync(string discountCode);
    Task<(bool Success, string Message)> CreateDiscountAsync(FeeDiscountDto dto);
    Task<(bool Success, string Message)> UpdateDiscountAsync(FeeDiscountDto dto);
    Task<(bool Success, string Message)> DeleteDiscountAsync(int discountId);
    Task<bool> IsExistingStudentByPhoneAsync(string phone);
    Task<string> GenerateNextStudentCodeAsync();
    Task<string> GenerateNextInvoiceCodeAsync();
    Task<int?> FindStudentIdByPhoneAsync(string phone);
    Task<bool> CheckStudentEnrolledAsync(int studentId, int classId);
    Task<(bool Success, string Message, int StudentId, int EnrollmentId, int InvoiceId, string InvoiceCode)> ExecuteEnrollmentTransactionAsync(
        StudentEnrollmentDto dto,
        string studentCode,
        string invoiceCode);
    Task<(bool Success, string Message, int StudentId, string StudentCode, string InvoiceCode, string ReceiptCode)> ExecuteEnrollmentAndTuitionTransactionAsync(
        StudentEnrollmentWithTuitionDto dto);
    Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50);
}
