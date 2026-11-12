using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using ECMS.Data.Repositories;
using Dapper;

namespace ECMS.Business.Services;

public interface IFinanceService
{
    // 1. Nghiệp vụ Kế toán (Chức năng 2.1 & 2.2)
    Task<IEnumerable<InvoiceListItemDto>> GetInvoicesAsync(string? statusFilter, string? keyword);
    Task<Invoice?> GetInvoiceByEnrollmentAsync(int enrollmentId);
    Task<(bool Success, string Message, int PaymentId, string ReceiptCode)> ProcessPaymentAsync(
        int invoiceId, decimal amountPaid, string paymentMethod, int cashierId, string? note = null);
    Task<ReceiptPrintDto?> GetReceiptPrintDataAsync(int paymentId);
    (decimal discountAmount, decimal finalAmount) CalculateTuitionDiscount(
        decimal baseTuitionFee, bool isReturningStudent, int groupSize);

    // 2. Nghiệp vụ Giám đốc (Chức năng 2.3)
    Task<DirectorDashboardSummaryDto> GetDirectorDashboardSummaryAsync();
    Task<IEnumerable<DailyPaymentTransactionDto>> GetTodayTransactionsAsync();
    Task<decimal> GetTotalRevenueThisMonthAsync();
    Task<IEnumerable<dynamic>> GetOutstandingInvoicesAsync();

    // Tương thích ngược
    Task<(bool Success, string Message, int PaymentId)> RecordPaymentAsync(
        int invoiceId, decimal paidAmount, PaymentMethod method, int cashierId, string? note = null);
}

public class FinanceService : IFinanceService
{
    private readonly IFinanceRepository _financeRepo;

    public FinanceService(IFinanceRepository? financeRepo = null)
    {
        _financeRepo = financeRepo ?? new FinanceRepository();
    }

    public async Task<IEnumerable<InvoiceListItemDto>> GetInvoicesAsync(string? statusFilter, string? keyword)
    {
        return await _financeRepo.GetInvoicesAsync(statusFilter, keyword);
    }

    public async Task<Invoice?> GetInvoiceByEnrollmentAsync(int enrollmentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Invoice>(
            "SELECT * FROM Invoices WHERE EnrollmentId = @Id;", new { Id = enrollmentId });
    }

    // Thuật toán 2: Tính lũy kế học phí & Đóng nhiều đợt chuẩn đề bài
    public async Task<(bool Success, string Message, int PaymentId, string ReceiptCode)> ProcessPaymentAsync(
        int invoiceId, decimal amountPaid, string paymentMethod, int cashierId, string? note = null)
    {
        if (amountPaid <= 0)
        {
            return (false, "Số tiền thanh toán phải lớn hơn 0 VNĐ!", 0, string.Empty);
        }

        using var conn = DatabaseConfig.CreateOpenConnection();
        using var transaction = conn.BeginTransaction();

        try
        {
            var invoice = await conn.QuerySingleOrDefaultAsync<dynamic>(
                "SELECT InvoiceId, FinalAmount, BalanceDue, Status FROM Invoices WHERE InvoiceId = @Id;",
                new { Id = invoiceId }, transaction);

            if (invoice == null)
            {
                return (false, "Không tìm thấy thông tin khoản phải thu!", 0, string.Empty);
            }

            decimal currentBalance = Convert.ToDecimal(invoice.BalanceDue);
            decimal totalAmount = Convert.ToDecimal(invoice.FinalAmount);

            if (currentBalance <= 0)
            {
                return (false, "Khoản học phí này đã được thanh toán đầy đủ 100%!", 0, string.Empty);
            }

            if (amountPaid > currentBalance)
            {
                return (false, $"Số tiền thanh toán ({amountPaid:N0} đ) vượt quá số nợ còn lại ({currentBalance:N0} đ)!", 0, string.Empty);
            }

            // Sinh mã phiếu thu chuẩn ISO: PT-yyyyMMdd-xxxx
            string prefix = $"PT-{DateTime.Now:yyyyMMdd}-";
            int countToday = await conn.ExecuteScalarAsync<int>(
                "SELECT COUNT(*) FROM Payments WHERE PaymentCode LIKE @Prefix;", 
                new { Prefix = prefix + "%" }, transaction);
            string receiptCode = $"{prefix}{(countToday + 1):D4}";

            // Insert vào bảng Payments
            string insertPaymentSql = @"
                INSERT INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                VALUES (@PaymentCode, @InvoiceId, @PaidAmount, CURRENT_TIMESTAMP, @Method, @CashierId, 'Valid', @Note);
                SELECT last_insert_rowid();";

            int paymentId = await conn.ExecuteScalarAsync<int>(insertPaymentSql, new
            {
                PaymentCode = receiptCode,
                InvoiceId = invoiceId,
                PaidAmount = amountPaid,
                Method = paymentMethod,
                CashierId = cashierId,
                Note = note
            }, transaction);

            // Cập nhật lũy kế công nợ và trạng thái
            decimal newBalance = currentBalance - amountPaid;
            string newStatus = (newBalance <= 0) ? "Paid" : "PartiallyPaid";

            await conn.ExecuteAsync(@"
                UPDATE Invoices 
                SET BalanceDue = @Balance, Status = @Status, UpdatedAt = CURRENT_TIMESTAMP
                WHERE InvoiceId = @Id;",
                new { Balance = newBalance, Status = newStatus, Id = invoiceId }, transaction);

            transaction.Commit();
            return (true, $"Thu tiền thành công! Mã biên lai: {receiptCode}", paymentId, receiptCode);
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            return (false, $"Lỗi giao dịch SQLite: {ex.Message}", 0, string.Empty);
        }
    }

    public async Task<ReceiptPrintDto?> GetReceiptPrintDataAsync(int paymentId)
    {
        return await _financeRepo.GetReceiptPrintDataAsync(paymentId);
    }

    // Thuật toán tính ưu đãi tự động theo đề bài
    public (decimal discountAmount, decimal finalAmount) CalculateTuitionDiscount(
        decimal baseTuitionFee, bool isReturningStudent, int groupSize)
    {
        decimal discountPercent = 0;
        
        // Giảm 10% nếu là học viên cũ
        if (isReturningStudent) discountPercent += 10;
        
        // Giảm theo nhóm: từ 2 người giảm 5%, từ 3 người trở lên giảm 10%
        if (groupSize >= 3) discountPercent += 10;
        else if (groupSize == 2) discountPercent += 5;

        if (discountPercent > 25) discountPercent = 25; // Giới hạn tối đa 25%

        decimal discountAmount = baseTuitionFee * (discountPercent / 100m);
        decimal finalAmount = baseTuitionFee - discountAmount;
        return (discountAmount, finalAmount);
    }

    public async Task<DirectorDashboardSummaryDto> GetDirectorDashboardSummaryAsync()
    {
        return await _financeRepo.GetDirectorDashboardSummaryAsync();
    }

    public async Task<IEnumerable<DailyPaymentTransactionDto>> GetTodayTransactionsAsync()
    {
        return await _financeRepo.GetTodayTransactionsAsync();
    }

    public async Task<decimal> GetTotalRevenueThisMonthAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string monthPrefix = DateTime.Now.ToString("yyyy-MM");
        string sql = @"
            SELECT COALESCE(SUM(PaidAmount), 0) 
            FROM Payments 
            WHERE Status = 'Valid' AND PaymentDate LIKE @Prefix;";

        return await conn.ExecuteScalarAsync<decimal>(sql, new { Prefix = monthPrefix + "%" });
    }

    public async Task<IEnumerable<dynamic>> GetOutstandingInvoicesAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT inv.InvoiceId, inv.InvoiceCode, inv.FinalAmount, inv.BalanceDue, inv.DueDate, inv.Status,
                   s.StudentCode, s.FullName AS StudentName, s.Phone AS StudentPhone,
                   c.ClassCode, c.ClassName
            FROM Invoices inv
            INNER JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            INNER JOIN Students s ON e.StudentId = s.StudentId
            INNER JOIN Classes c ON e.ClassId = c.ClassId
            WHERE inv.BalanceDue > 0 AND inv.Status != 'Cancelled'
            ORDER BY inv.DueDate ASC;";

        return await conn.QueryAsync(sql);
    }

    public async Task<(bool Success, string Message, int PaymentId)> RecordPaymentAsync(
        int invoiceId, decimal paidAmount, PaymentMethod method, int cashierId, string? note = null)
    {
        var result = await ProcessPaymentAsync(invoiceId, paidAmount, method.ToString(), cashierId, note);
        return (result.Success, result.Message, result.PaymentId);
    }
}
