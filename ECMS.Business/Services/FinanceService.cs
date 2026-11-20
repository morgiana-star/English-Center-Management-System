using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public class TuitionProfileItemDto
{
    public int InvoiceId { get; set; }
    public int EnrollmentId { get; set; }
    public string InvoiceCode { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public decimal OriginalFee { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalFee { get; set; }
    public decimal Paid { get; set; }
    public decimal Remaining { get; set; }
    public string DueDate { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}

public class PaymentReceiptItemDto
{
    public string ReceiptCode { get; set; } = string.Empty;
    public string PaymentDate { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Method { get; set; } = string.Empty;
    public string Collector { get; set; } = string.Empty;
}

public interface IFinanceService
{
    Task<Invoice?> GetInvoiceByEnrollmentAsync(int enrollmentId);
    Task<(bool Success, string Message, int PaymentId)> RecordPaymentAsync(
        int invoiceId, decimal paidAmount, PaymentMethod method, int cashierId, string? note = null);
    Task<IEnumerable<dynamic>> GetOutstandingInvoicesAsync();
    Task<decimal> GetTotalRevenueThisMonthAsync();
    Task<IEnumerable<TuitionProfileItemDto>> GetTuitionProfilesAsync();
    Task<IEnumerable<PaymentReceiptItemDto>> GetPaymentReceiptsHistoryAsync();
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

            string methodVi = method switch
            {
                PaymentMethod.Cash => "Tiền mặt",
                PaymentMethod.POS => "POS",
                _ => "Chuyển khoản"
            };

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
                Method = methodVi,
                CashierId = cashierId > 0 ? cashierId : 1,
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

    public async Task<IEnumerable<TuitionProfileItemDto>> GetTuitionProfilesAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT 
                inv.InvoiceId,
                inv.EnrollmentId,
                inv.InvoiceCode,
                s.StudentCode,
                s.FullName AS StudentName,
                co.CourseName,
                c.ClassCode AS ClassName,
                inv.OriginalAmount AS OriginalFee,
                inv.DiscountAmount AS Discount,
                inv.FinalAmount AS TotalFee,
                (inv.FinalAmount - inv.BalanceDue) AS Paid,
                inv.BalanceDue AS Remaining,
                inv.DueDate,
                inv.Status
            FROM Invoices inv
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            WHERE inv.Status != 'Cancelled'
            ORDER BY inv.InvoiceId DESC;";

        return await conn.QueryAsync<TuitionProfileItemDto>(sql);
    }

    public async Task<IEnumerable<PaymentReceiptItemDto>> GetPaymentReceiptsHistoryAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT 
                p.PaymentCode AS ReceiptCode,
                p.PaymentDate,
                s.StudentCode,
                s.FullName AS StudentName,
                c.ClassCode AS ClassName,
                co.CourseName,
                COALESCE(p.Note, 'Thu học phí') AS Content,
                p.PaidAmount AS Amount,
                p.PaymentMethod AS Method,
                COALESCE(emp.FullName, u.Username, 'Quản trị viên') AS Collector
            FROM Payments p
            JOIN Invoices inv ON p.InvoiceId = inv.InvoiceId
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Users u ON p.CashierId = u.UserId
            LEFT JOIN Employees emp ON u.EmployeeId = emp.EmployeeId
            WHERE p.Status = 'Valid'
            ORDER BY p.PaymentId DESC;";

        return await conn.QueryAsync<PaymentReceiptItemDto>(sql);
    }
}
