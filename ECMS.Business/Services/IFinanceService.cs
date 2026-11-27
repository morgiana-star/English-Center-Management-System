using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IFinanceService
{
    Task<IEnumerable<TuitionProfileDto>> GetTuitionProfilesAsync(string? keyword = null, string? className = null, string? status = null);
    Task<IEnumerable<PaymentReceiptDto>> GetPaymentReceiptsAsync(string? keyword = null, string? className = null, string? method = null);
    Task<(bool Success, string Message, string ReceiptCode)> CollectTuitionAsync(string studentCode, decimal amount, string paymentMethod, string note, int cashierId, decimal extraDiscount = 0, string? preferredReceiptCode = null);
}
