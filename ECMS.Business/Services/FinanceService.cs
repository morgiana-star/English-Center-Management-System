using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public interface IFinanceService
{
    Task<Invoice?> GetInvoiceByEnrollmentAsync(int enrollmentId);
    Task<(bool Success, string Message, int PaymentId)> RecordPaymentAsync(
        int invoiceId, decimal paidAmount, PaymentMethod method, int cashierId, string? note = null);
    Task<IEnumerable<dynamic>> GetOutstandingInvoicesAsync();
    Task<decimal> GetTotalRevenueThisMonthAsync();
}

public class FinanceService : IFinanceService
{
    public async Task<Invoice?> GetInvoiceByEnrollmentAsync(int enrollmentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Invoice>(
            "SELECT * FROM Invoices WHERE EnrollmentId = @Id;", new { Id = enrollmentId });
    }

    public async Task<(bool Success, string Message, int PaymentId)> RecordPaymentAsync(
        int invoiceId, decimal paidAmount, PaymentMethod method, int cashierId, string? note = null)
    {
        if (paidAmount <= 0)
        {
            return (false, "Số tiền thanh toán phải lớn hơn 0 VNĐ.", 0);
        }

        using var conn = DatabaseConfig.CreateOpenConnection();
        using var transaction = conn.BeginTransaction();

        try
        {
            var invoice = await conn.QuerySingleOrDefaultAsync<Invoice>(
                "SELECT * FROM Invoices WHERE InvoiceId = @Id;", new { Id = invoiceId }, transaction);

            if (invoice == null)
            {
                return (false, "Không tìm thấy thông tin khoản phải thu.", 0);
            }

            if (invoice.Status == InvoiceStatus.Paid || invoice.BalanceDue <= 0)
            {
                return (false, "Khoản học phí này đã được thanh toán đầy đủ.", 0);
            }

            if (paidAmount > invoice.BalanceDue)
            {
                return (false, $"Số tiền thanh toán ({paidAmount:N0} đ) vượt quá số tiền còn nợ ({invoice.BalanceDue:N0} đ).", 0);
            }

            // 1. Generate PaymentCode PT-yyyyMMdd-xxxx
            string prefix = $"PT-{DateTime.Now:yyyyMMdd}-";
            int countToday = await conn.ExecuteScalarAsync<int>(
                "SELECT COUNT(*) FROM Payments WHERE PaymentCode LIKE @Prefix;", 
                new { Prefix = prefix + "%" }, transaction);
            string paymentCode = $"{prefix}{(countToday + 1):D4}";

            // 2. Insert Payment
            string insertSql = @"
                INSERT INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                VALUES (@PaymentCode, @InvoiceId, @PaidAmount, CURRENT_TIMESTAMP, @Method, @CashierId, 'Valid', @Note);
                SELECT last_insert_rowid();";

            int paymentId = await conn.ExecuteScalarAsync<int>(insertSql, new
            {
                PaymentCode = paymentCode,
                InvoiceId = invoiceId,
                PaidAmount = paidAmount,
                Method = method.ToString(),
                CashierId = cashierId,
                Note = note
            }, transaction);

            // 3. Update Invoice BalanceDue & Status
            decimal newBalance = invoice.BalanceDue - paidAmount;
            string newStatus = (newBalance == 0) ? InvoiceStatus.Paid.ToString() : InvoiceStatus.PartiallyPaid.ToString();

            await conn.ExecuteAsync(@"
                UPDATE Invoices 
                SET BalanceDue = @Balance, Status = @Status, UpdatedAt = CURRENT_TIMESTAMP
                WHERE InvoiceId = @Id;",
                new { Balance = newBalance, Status = newStatus, Id = invoiceId }, transaction);

            transaction.Commit();
            return (true, $"Ghi nhận thanh toán thành công (Biên lai số: {paymentCode}).", paymentId);
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            return (false, $"Lỗi xử lý giao dịch: {ex.Message}", 0);
        }
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
}
