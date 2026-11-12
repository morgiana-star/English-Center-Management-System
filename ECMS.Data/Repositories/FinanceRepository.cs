using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public interface IFinanceRepository
{
    Task<IEnumerable<InvoiceListItemDto>> GetInvoicesAsync(string? statusFilter, string? keyword);
    Task<ReceiptPrintDto?> GetReceiptPrintDataAsync(int paymentId);
    Task<DirectorDashboardSummaryDto> GetDirectorDashboardSummaryAsync();
    Task<IEnumerable<DailyPaymentTransactionDto>> GetTodayTransactionsAsync();
}

public class FinanceRepository : IFinanceRepository
{
    public async Task<IEnumerable<InvoiceListItemDto>> GetInvoicesAsync(string? statusFilter, string? keyword)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT inv.InvoiceId, inv.InvoiceCode, s.StudentCode, s.FullName AS StudentName, s.Phone AS StudentPhone,
                   c.ClassName, crs.CourseName, inv.OriginalAmount, inv.DiscountAmount, inv.FinalAmount, 
                   inv.BalanceDue, inv.DueDate,
                   CASE 
                       WHEN inv.BalanceDue <= 0 THEN 'Paid'
                       WHEN inv.BalanceDue < inv.FinalAmount THEN 'Partial'
                       ELSE 'Unpaid'
                   END AS Status
            FROM Invoices inv
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses crs ON c.CourseId = crs.CourseId
            WHERE (@Status IS NULL OR @Status = 'Tất cả' OR 
                  (CASE WHEN inv.BalanceDue <= 0 THEN 'Paid' WHEN inv.BalanceDue < inv.FinalAmount THEN 'Partial' ELSE 'Unpaid' END) = @Status)
              AND (@Keyword IS NULL OR s.FullName LIKE @Keyword OR inv.InvoiceCode LIKE @Keyword OR s.Phone LIKE @Keyword)
            ORDER BY inv.InvoiceId DESC;";

        return await conn.QueryAsync<InvoiceListItemDto>(sql, new
        {
            Status = (statusFilter == "Tất cả" || string.IsNullOrWhiteSpace(statusFilter)) ? null : statusFilter,
            Keyword = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword.Trim()}%"
        });
    }

    public async Task<ReceiptPrintDto?> GetReceiptPrintDataAsync(int paymentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT p.PaymentCode AS ReceiptCode, inv.InvoiceCode, s.StudentCode, s.FullName AS StudentName, s.Phone AS StudentPhone,
                   c.ClassName, crs.CourseName, inv.FinalAmount, p.PaidAmount AS AmountPaidThisTime, inv.BalanceDue AS BalanceRemaining,
                   p.PaymentMethod, p.PaymentDate, COALESCE(u.Username, 'Kế toán') AS CashierName, p.Note
            FROM Payments p
            JOIN Invoices inv ON p.InvoiceId = inv.InvoiceId
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses crs ON c.CourseId = crs.CourseId
            LEFT JOIN Users u ON p.CashierId = u.UserId
            WHERE p.PaymentId = @PaymentId;";

        return await conn.QuerySingleOrDefaultAsync<ReceiptPrintDto>(sql, new { PaymentId = paymentId });
    }

    public async Task<DirectorDashboardSummaryDto> GetDirectorDashboardSummaryAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string currentMonth = DateTime.Now.ToString("yyyy-MM") + "%";
        string lastMonth = DateTime.Now.AddMonths(-1).ToString("yyyy-MM") + "%";

        decimal revThisMonth = await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(SUM(PaidAmount), 0) FROM Payments 
            WHERE Status = 'Valid' AND PaymentDate LIKE @M;", new { M = currentMonth });

        decimal revLastMonth = await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(SUM(PaidAmount), 0) FROM Payments 
            WHERE Status = 'Valid' AND PaymentDate LIKE @M;", new { M = lastMonth });

        decimal outstandingDebt = await conn.ExecuteScalarAsync<decimal>(
            "SELECT COALESCE(SUM(BalanceDue), 0) FROM Invoices WHERE Status != 'Cancelled';");

        decimal totalFinal = await conn.ExecuteScalarAsync<decimal>(
            "SELECT COALESCE(SUM(FinalAmount), 0) FROM Invoices WHERE Status != 'Cancelled';");

        decimal collectionRate = totalFinal > 0 
            ? Math.Round(((totalFinal - outstandingDebt) / totalFinal) * 100m, 1) 
            : 0;

        int activeStudents = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Students WHERE Status = 'Active';");

        int activeClasses = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Classes WHERE Status IN ('InProgress', 'OpenForEnrollment');");

        int paidCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Invoices WHERE BalanceDue <= 0 AND Status != 'Cancelled';");

        int paymentCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Payments WHERE Status = 'Valid';");

        return new DirectorDashboardSummaryDto
        {
            TotalRevenueThisMonth = revThisMonth,
            TotalRevenueLastMonth = revLastMonth,
            TotalOutstandingDebt = outstandingDebt,
            CollectionRate = collectionRate,
            TotalActiveStudents = activeStudents,
            TotalActiveClasses = activeClasses,
            TotalPaidInvoicesCount = paidCount,
            TotalPaymentsCount = paymentCount
        };
    }

    public async Task<IEnumerable<DailyPaymentTransactionDto>> GetTodayTransactionsAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string today = DateTime.Now.ToString("yyyy-MM-dd") + "%";
        string sql = @"
            SELECT p.PaymentId, p.PaymentCode, inv.InvoiceCode, s.FullName AS StudentName, c.ClassName,
                   p.PaidAmount, p.PaymentMethod, p.PaymentDate AS PaymentTime,
                   COALESCE(u.Username, 'Kế toán') AS CashierName
            FROM Payments p
            JOIN Invoices inv ON p.InvoiceId = inv.InvoiceId
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            LEFT JOIN Users u ON p.CashierId = u.UserId
            WHERE p.PaymentDate LIKE @Today AND p.Status = 'Valid'
            ORDER BY p.PaymentId DESC;";

        return await conn.QueryAsync<DailyPaymentTransactionDto>(sql, new { Today = today });
    }
}
