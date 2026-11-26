using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IFinanceRepository
{
    Task<IEnumerable<TuitionProfileDto>> GetAllTuitionProfilesAsync(string? keyword = null, string? className = null, string? status = null);
    Task<IEnumerable<PaymentReceiptDto>> GetAllPaymentReceiptsAsync(string? keyword = null, string? className = null, string? method = null);
    Task<(bool Success, string Message, string ReceiptCode)> ProcessPaymentAsync(string studentCode, decimal amount, string paymentMethod, string note, int cashierId, decimal extraDiscount = 0);
    Task EnsureSeedTuitionDataAsync();
}
