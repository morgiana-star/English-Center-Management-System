using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using ECMS.Core.DTOs;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class FinanceRepository : IFinanceRepository
{
    public Task EnsureSeedTuitionDataAsync()
    {
        // Đồng bộ 100% nguồn dữ liệu chung từ Students / Classes / Enrollments / Invoices (không chèn lớp trùng lặp)
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<TuitionProfileDto>> GetAllTuitionProfilesAsync(string? keyword = null, string? className = null, string? status = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();

        string sql = @"
            SELECT 
                i.InvoiceId,
                i.InvoiceCode,
                s.StudentCode,
                s.FullName AS StudentName,
                co.CourseName,
                cl.ClassCode AS ClassName,
                i.OriginalAmount AS OriginalFee,
                i.DiscountAmount AS Discount,
                i.FinalAmount AS TotalFee,
                (i.FinalAmount - i.BalanceDue) AS Paid,
                i.BalanceDue AS Remaining,
                strftime('%d/%m/%Y', i.DueDate) AS DueDate,
                (SELECT COUNT(*) FROM Payments p WHERE p.InvoiceId = i.InvoiceId AND p.Status = 'Valid') AS PaidInstallmentCount,
                CASE 
                    WHEN i.BalanceDue <= 0 THEN 'Đã tất toán'
                    WHEN (i.FinalAmount - i.BalanceDue) > 0 THEN 'Còn nợ (' || CAST(ROUND(i.BalanceDue, 0) AS INTEGER) || ' đ)'
                    ELSE 'Chưa đóng'
                END AS PaymentStatus,
                CASE 
                    WHEN i.BalanceDue <= 0 THEN 'Đã hoàn thành'
                    WHEN date('now') > date(i.DueDate) THEN 'Quá hạn'
                    WHEN julianday(i.DueDate) - julianday('now') <= 7 THEN 'Đến hạn trong 7 ngày'
                    ELSE 'Trong hạn'
                END AS DebtStatus
            FROM Invoices i
            INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
            INNER JOIN Students s ON e.StudentId = s.StudentId
            INNER JOIN Classes cl ON e.ClassId = cl.ClassId
            INNER JOIN Courses co ON cl.CourseId = co.CourseId
            WHERE i.Status != 'Cancelled'
              AND (@Kw IS NULL OR s.StudentCode LIKE @Kw OR s.FullName LIKE @Kw OR cl.ClassCode LIKE @Kw OR cl.ClassName LIKE @Kw OR co.CourseName LIKE @Kw)
              AND (@ClassName IS NULL OR cl.ClassCode = @ClassName OR cl.ClassName = @ClassName)
            ORDER BY i.InvoiceId DESC;";

        return await conn.QueryAsync<TuitionProfileDto>(sql, new
        {
            Kw = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword}%",
            ClassName = (className == "Tất cả lớp" || string.IsNullOrWhiteSpace(className)) ? null : className
        });
    }

    public async Task<IEnumerable<PaymentReceiptDto>> GetAllPaymentReceiptsAsync(string? keyword = null, string? className = null, string? method = null)
    {
        await EnsureSeedTuitionDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string sql = @"
            SELECT 
                p.PaymentId,
                p.PaymentCode AS ReceiptCode,
                strftime('%d/%m/%Y', p.PaymentDate) AS Date,
                s.StudentCode,
                s.FullName AS StudentName,
                cl.ClassName,
                co.CourseName,
                p.Note AS Content,
                p.PaidAmount AS Amount,
                p.PaymentMethod AS Method,
                COALESCE(u.Username, 'Trần Minh Quân') AS Collector
            FROM Payments p
            INNER JOIN Invoices i ON p.InvoiceId = i.InvoiceId
            INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
            INNER JOIN Students s ON e.StudentId = s.StudentId
            INNER JOIN Classes cl ON e.ClassId = cl.ClassId
            INNER JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN Users u ON p.CashierId = u.UserId
            WHERE (@Kw IS NULL OR p.PaymentCode LIKE @Kw OR s.StudentCode LIKE @Kw OR s.FullName LIKE @Kw OR cl.ClassName LIKE @Kw)
              AND (@ClassName IS NULL OR cl.ClassName = @ClassName OR cl.ClassCode = @ClassName)
            ORDER BY p.PaymentId DESC;";

        return await conn.QueryAsync<PaymentReceiptDto>(sql, new
        {
            Kw = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword}%",
            ClassName = (className == "Tất cả lớp" || string.IsNullOrWhiteSpace(className)) ? null : className
        });
    }

    public async Task<(bool Success, string Message, string ReceiptCode)> ProcessPaymentAsync(
        string studentCode, 
        decimal amount, 
        string paymentMethod, 
        string note, 
        int cashierId,
        decimal extraDiscount = 0)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            // 1. Tìm hóa đơn chưa thanh toán hết của học viên
            string findSql = @"
                SELECT i.InvoiceId, i.BalanceDue, i.FinalAmount, i.DiscountAmount 
                FROM Invoices i
                INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                INNER JOIN Students s ON e.StudentId = s.StudentId
                WHERE (s.StudentCode = @StudentCode OR s.FullName = @StudentCode)
                  AND i.BalanceDue > 0
                LIMIT 1;";
            var inv = await conn.QueryFirstOrDefaultAsync(findSql, new { StudentCode = studentCode }, trans);

            int invoiceId;
            decimal curBalance = 0;
            decimal curFinal = 0;
            decimal curDiscount = 0;
            if (inv != null)
            {
                invoiceId = (int)inv.InvoiceId;
                curBalance = (decimal)inv.BalanceDue;
                curFinal = (decimal)inv.FinalAmount;
                curDiscount = (decimal)inv.DiscountAmount;
            }
            else
            {
                string anySql = @"
                    SELECT i.InvoiceId, i.BalanceDue, i.FinalAmount, i.DiscountAmount 
                    FROM Invoices i
                    INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                    INNER JOIN Students s ON e.StudentId = s.StudentId
                    WHERE s.StudentCode = @StudentCode OR s.FullName = @StudentCode
                    LIMIT 1;";
                var anyInv = await conn.QueryFirstOrDefaultAsync(anySql, new { StudentCode = studentCode }, trans);
                if (anyInv == null)
                {
                    return (false, $"Không tìm thấy hóa đơn học phí của học viên {studentCode}.", string.Empty);
                }
                invoiceId = (int)anyInv.InvoiceId;
                curBalance = (decimal)anyInv.BalanceDue;
                curFinal = (decimal)anyInv.FinalAmount;
                curDiscount = (decimal)anyInv.DiscountAmount;
            }

            // 2. Sinh mã phiếu thu chuẩn ISO PT-yyMMdd-xxx
            string receiptCode = $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";
            string normalizedMethod = paymentMethod switch
            {
                var m when m.Contains("Tiền mặt", StringComparison.OrdinalIgnoreCase) => "Tiền mặt",
                var m when m.Contains("POS", StringComparison.OrdinalIgnoreCase) => "POS",
                _ => "Chuyển khoản"
            };

            // 3. Thêm bản ghi thanh toán vào bảng Payments
            string insertPaySql = @"
                INSERT INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                VALUES (@PaymentCode, @InvoiceId, @PaidAmount, datetime('now', 'localtime'), @PaymentMethod, @CashierId, 'Valid', @Note);";

            await conn.ExecuteAsync(insertPaySql, new
            {
                PaymentCode = receiptCode,
                InvoiceId = invoiceId,
                PaidAmount = amount,
                PaymentMethod = normalizedMethod,
                CashierId = cashierId > 0 ? cashierId : 1,
                Note = string.IsNullOrWhiteSpace(note) ? "Thu học phí" : note
            }, trans);

            // 4. Cập nhật DiscountAmount, FinalAmount, BalanceDue và DueDate đợt kế tiếp theo thời lượng lớp học
            decimal appliedDisc = Math.Max(0, Math.Min(extraDiscount, curBalance));
            decimal newDiscount = curDiscount + appliedDisc;
            decimal newFinal = Math.Max(0, curFinal - appliedDisc);
            decimal newBalance = Math.Max(0, curBalance - appliedDisc - amount);
            string newStatus = newBalance <= 0 ? "Paid" : "PartiallyPaid";

            var clsDur = await conn.QueryFirstOrDefaultAsync<(int TotalSessions, string? EndDate)>(@"
                SELECT COALESCE(co.TotalSessions, 24) AS TotalSessions, c.EndDate
                FROM Invoices i
                INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                INNER JOIN Classes c ON e.ClassId = c.ClassId
                LEFT JOIN Courses co ON c.CourseId = co.CourseId
                WHERE i.InvoiceId = @InvoiceId;", new { InvoiceId = invoiceId }, trans);

            int sessions = clsDur.TotalSessions > 0 ? clsDur.TotalSessions : 24;
            int durationDays = Math.Max(21, (int)Math.Round(sessions / 3.0 * 7.0));
            int nextStepDays = Math.Clamp((durationDays - 7) / 2, 10, 30);
            DateTime nextDue = DateTime.Today.AddDays(nextStepDays);
            if (!string.IsNullOrWhiteSpace(clsDur.EndDate) &&
                DateTime.TryParse(clsDur.EndDate, out var clsEndDt) &&
                clsEndDt > DateTime.Today.AddDays(10) &&
                nextDue > clsEndDt.AddDays(-7))
            {
                nextDue = clsEndDt.AddDays(-7);
            }
            string newDueDate = newBalance <= 0 ? DateTime.Today.ToString("yyyy-MM-dd") : nextDue.ToString("yyyy-MM-dd");

            string updateInvSql = @"
                UPDATE Invoices 
                SET DiscountAmount = @NewDiscount,
                    FinalAmount = @NewFinal,
                    BalanceDue = @NewBalance, 
                    DueDate = @NewDueDate,
                    Status = @Status,
                    UpdatedAt = datetime('now', 'localtime')
                WHERE InvoiceId = @InvoiceId;";

            await conn.ExecuteAsync(updateInvSql, new
            {
                NewDiscount = newDiscount,
                NewFinal = newFinal,
                NewBalance = newBalance,
                NewDueDate = newDueDate,
                Status = newStatus,
                InvoiceId = invoiceId
            }, trans);

            // 5. Nếu đã tất toán học phí, kích hoạt trạng thái Enrollment nếu đang Pending
            if (newBalance <= 0)
            {
                string updateEnrollSql = @"
                    UPDATE Enrollments 
                    SET Status = 'Active' 
                    WHERE EnrollmentId = (SELECT EnrollmentId FROM Invoices WHERE InvoiceId = @InvoiceId)
                      AND Status = 'PendingPayment';";
                await conn.ExecuteAsync(updateEnrollSql, new { InvoiceId = invoiceId }, trans);
            }

            trans.Commit();
            return (true, "Thu học phí thành công!", receiptCode);
        }
        catch (Exception ex)
        {
            trans.Rollback();
            return (false, $"Lỗi giao dịch CSDL: {ex.Message}", string.Empty);
        }
    }
}
