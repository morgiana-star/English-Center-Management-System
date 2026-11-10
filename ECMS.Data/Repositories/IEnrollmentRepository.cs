using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IEnrollmentRepository
{
    Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync();
    Task<ClassLookupDto?> GetClassByIdAsync(int classId);
    Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync();
    Task<FeeDiscountDto?> GetDiscountByIdAsync(int discountId);
    Task<bool> IsExistingStudentByPhoneAsync(string phone);
    Task<string> GenerateNextStudentCodeAsync();
    Task<string> GenerateNextInvoiceCodeAsync();
    Task<int?> FindStudentIdByPhoneAsync(string phone);
    Task<bool> CheckStudentEnrolledAsync(int studentId, int classId);
    Task<(bool Success, string Message, int StudentId, int EnrollmentId, int InvoiceId, string InvoiceCode)> ExecuteEnrollmentTransactionAsync(
        StudentEnrollmentDto dto,
        string studentCode,
        string invoiceCode);
    Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50);
}
