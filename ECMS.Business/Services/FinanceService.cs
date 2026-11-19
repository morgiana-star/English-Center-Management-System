using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class FinanceService : IFinanceService
{
    private readonly IFinanceRepository _repo;

    public FinanceService(IFinanceRepository? repo = null)
    {
        _repo = repo ?? new FinanceRepository();
    }

    public async Task<IEnumerable<TuitionProfileDto>> GetTuitionProfilesAsync(string? keyword = null, string? className = null, string? status = null)
    {
        return await _repo.GetAllTuitionProfilesAsync(keyword, className, status);
    }

    public async Task<IEnumerable<PaymentReceiptDto>> GetPaymentReceiptsAsync(string? keyword = null, string? className = null, string? method = null)
    {
        return await _repo.GetAllPaymentReceiptsAsync(keyword, className, method);
    }

    public async Task<(bool Success, string Message, string ReceiptCode)> CollectTuitionAsync(
        string studentCode, 
        decimal amount, 
        string paymentMethod, 
        string note, 
        int cashierId)
    {
        if (string.IsNullOrWhiteSpace(studentCode))
            return (false, "Vui lòng chọn học viên cần thu phí!", string.Empty);

        if (amount <= 0)
            return (false, "Số tiền thu học phí phải lớn hơn 0đ!", string.Empty);

        if (string.IsNullOrWhiteSpace(paymentMethod))
            paymentMethod = "Chuyển khoản VietQR";

        return await _repo.ProcessPaymentAsync(studentCode, amount, paymentMethod, note, cashierId);
    }
}
