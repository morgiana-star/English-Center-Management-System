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
    public async Task EnsureSeedTuitionDataAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int invCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Invoices;");
        if (invCount > 1) return; // Đã có dữ liệu đầy đủ

        // Đảm bảo có các lớp học cơ bản
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status)
            VALUES 
            (2, 'IELTS-F01', 'Lớp IELTS Foundation 01', 1, 1, 1, '2026-09-01', '2026-11-30', 20, 'InProgress'),
            (3, 'IELTS-F02', 'Lớp IELTS Foundation 02', 1, 1, 1, '2026-09-15', '2026-12-15', 20, 'InProgress'),
            (4, 'TOEIC-A01', 'Lớp TOEIC 500+ A01', 1, 1, 1, '2026-10-01', '2026-12-30', 25, 'InProgress'),
            (5, 'COM-B01', 'Lớp Tiếng Anh Giao tiếp B01', 1, 1, 1, '2026-09-10', '2026-11-25', 18, 'InProgress');");

        // Seed 13 học viên đồng bộ hồ sơ
        var students = new[]
        {
            new { Code = "HV-0241", Name = "Nguyễn Minh Anh", Phone = "0912345601", ClassId = 2, Orig = 6000000m, Disc = 600000m, Final = 5400000m, Paid = 2000000m, Rem = 3400000m, Due = "2026-11-15", St = "PartiallyPaid" },
            new { Code = "HV-0238", Name = "Phạm Khánh Linh", Phone = "0912345602", ClassId = 2, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 3600000m, Rem = 2400000m, Due = "2026-10-31", St = "PartiallyPaid" },
            new { Code = "HV-0239", Name = "Đỗ Thanh Tâm", Phone = "0912345603", ClassId = 5, Orig = 3800000m, Disc = 600000m, Final = 3200000m, Paid = 0m, Rem = 3200000m, Due = "2026-11-02", St = "Unpaid" },
            new { Code = "HV-0215", Name = "Trần Thảo Nhi", Phone = "0912345604", ClassId = 2, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 5500000m, Rem = 500000m, Due = "2026-11-10", St = "PartiallyPaid" },
            new { Code = "HV-0235", Name = "Nguyễn Tiến Đạt", Phone = "0912345605", ClassId = 3, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 4800000m, Rem = 1200000m, Due = "2026-11-20", St = "PartiallyPaid" },
            new { Code = "HV-0204", Name = "Trần Gia Bảo", Phone = "0912345606", ClassId = 3, Orig = 6000000m, Disc = 600000m, Final = 5400000m, Paid = 5400000m, Rem = 0m, Due = "2026-08-30", St = "Paid" },
            new { Code = "HV-0205", Name = "Đặng Minh Trí", Phone = "0912345607", ClassId = 3, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 6000000m, Rem = 0m, Due = "2026-08-30", St = "Paid" },
            new { Code = "HV-0208", Name = "Lê Hoàng Yến", Phone = "0912345608", ClassId = 2, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 6000000m, Rem = 0m, Due = "2026-08-30", St = "Paid" },
            new { Code = "HV-0210", Name = "Phạm Quốc Huy", Phone = "0912345609", ClassId = 2, Orig = 6000000m, Disc = 0m, Final = 6000000m, Paid = 6000000m, Rem = 0m, Due = "2026-08-30", St = "Paid" },
            new { Code = "HV-0240", Name = "Võ Hoàng Yến", Phone = "0912345610", ClassId = 4, Orig = 4500000m, Disc = 0m, Final = 4500000m, Paid = 4500000m, Rem = 0m, Due = "2026-09-10", St = "Paid" },
            new { Code = "HV-0236", Name = "Bùi Mai Phương", Phone = "0912345611", ClassId = 5, Orig = 3800000m, Disc = 0m, Final = 3800000m, Paid = 3800000m, Rem = 0m, Due = "2026-09-15", St = "Paid" },
            new { Code = "HV-0177", Name = "Nguyễn Thành Nam", Phone = "0912345612", ClassId = 4, Orig = 4500000m, Disc = 0m, Final = 4500000m, Paid = 4500000m, Rem = 0m, Due = "2026-09-10", St = "Paid" },
            new { Code = "HV-0160", Name = "Bùi Thị Mai", Phone = "0912345613", ClassId = 5, Orig = 3800000m, Disc = 0m, Final = 3800000m, Paid = 3800000m, Rem = 0m, Due = "2026-09-15", St = "Paid" }
        };

        foreach (var s in students)
        {
            await conn.ExecuteAsync(@"
                INSERT OR IGNORE INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Status)
                VALUES (@Code, @Name, '2005-01-01', 'Nam', @Phone, 'Active');", s);

            int stuId = await conn.ExecuteScalarAsync<int>("SELECT StudentId FROM Students WHERE StudentCode = @Code;", new { s.Code });
            
            await conn.ExecuteAsync(@"
                INSERT OR IGNORE INTO Enrollments (StudentId, ClassId, EnrollDate, Status, FinalGPA, AttendanceRate)
                VALUES (@StudentId, @ClassId, '2026-09-01', 'Active', 7.5, 90.0);", 
                new { StudentId = stuId, s.ClassId });

            int enrollId = await conn.ExecuteScalarAsync<int>("SELECT EnrollmentId FROM Enrollments WHERE StudentId = @StudentId AND ClassId = @ClassId;", 
                new { StudentId = stuId, s.ClassId });

            string invCode = $"INV-{s.Code}";
            await conn.ExecuteAsync(@"
                INSERT OR IGNORE INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status)
                VALUES (@InvCode, @EnrollmentId, @Orig, @Disc, @Final, @Rem, @Due, @St);",
                new { InvCode = invCode, EnrollmentId = enrollId, s.Orig, s.Disc, s.Final, s.Rem, s.Due, s.St });

            int invId = await conn.ExecuteScalarAsync<int>("SELECT InvoiceId FROM Invoices WHERE InvoiceCode = @InvCode;", new { InvCode = invCode });

            if (s.Paid > 0)
            {
                string payCode = $"PT-{s.Code}-01";
                await conn.ExecuteAsync(@"
                    INSERT OR IGNORE INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                    VALUES (@PayCode, @InvoiceId, @Paid, '2026-10-15 10:00:00', 'Chuyển khoản', 1, 'Valid', 'Thu học phí ban đầu');",
                    new { PayCode = payCode, InvoiceId = invId, s.Paid });
            }
        }
    }

    public async Task<IEnumerable<TuitionProfileDto>> GetAllTuitionProfilesAsync(string? keyword = null, string? className = null, string? status = null)
    {
        await EnsureSeedTuitionDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string sql = @"
            SELECT 
                i.InvoiceId,
                i.InvoiceCode,
                s.StudentCode,
                s.FullName AS StudentName,
                co.CourseName,
                cl.ClassName,
                i.OriginalAmount AS OriginalFee,
                i.DiscountAmount AS Discount,
                i.FinalAmount AS TotalFee,
                (i.FinalAmount - i.BalanceDue) AS Paid,
                i.BalanceDue AS Remaining,
                strftime('%d/%m/%Y', i.DueDate) AS DueDate,
                CASE 
                    WHEN i.BalanceDue <= 0 THEN '✓ Đã tất toán'
                    WHEN (i.FinalAmount - i.BalanceDue) > 0 THEN '⚠️ Còn nợ (' || CAST(ROUND(i.BalanceDue, 0) AS INTEGER) || 'đ)'
                    ELSE '⚠️ Chưa đóng'
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
            WHERE (@Kw IS NULL OR s.StudentCode LIKE @Kw OR s.FullName LIKE @Kw OR cl.ClassName LIKE @Kw OR co.CourseName LIKE @Kw)
              AND (@ClassName IS NULL OR cl.ClassName = @ClassName OR cl.ClassCode = @ClassName)
            ORDER BY i.InvoiceId ASC;";

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
        int cashierId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            // 1. Tìm hóa đơn chưa thanh toán hết của học viên
            string findSql = @"
                SELECT i.InvoiceId, i.BalanceDue, i.FinalAmount 
                FROM Invoices i
                INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                INNER JOIN Students s ON e.StudentId = s.StudentId
                WHERE (s.StudentCode = @StudentCode OR s.FullName = @StudentCode)
                  AND i.BalanceDue > 0
                LIMIT 1;";
            var inv = await conn.QueryFirstOrDefaultAsync(findSql, new { StudentCode = studentCode }, trans);

            int invoiceId;
            decimal curBalance = 0;
            if (inv != null)
            {
                invoiceId = (int)inv.InvoiceId;
                curBalance = (decimal)inv.BalanceDue;
            }
            else
            {
                string anySql = @"
                    SELECT i.InvoiceId, i.BalanceDue, i.FinalAmount 
                    FROM Invoices i
                    INNER JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                    INNER JOIN Students s ON e.StudentId = s.StudentId
                    WHERE s.StudentCode = @StudentCode OR s.FullName = @StudentCode
                    LIMIT 1;";
                var anyInv = await conn.QueryFirstOrDefaultAsync(anySql, new { StudentCode = studentCode }, trans);
                if (anyInv == null)
                {
                    return (false, $"Không tìm thấy hóa đơn học phí của học viên {studentCode}!", string.Empty);
                }
                invoiceId = (int)anyInv.InvoiceId;
                curBalance = (decimal)anyInv.BalanceDue;
            }

            // 2. Sinh mã phiếu thu chuẩn ISO PT-yyMMdd-xxxx
            string receiptCode = $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";

            // 3. Thêm bản ghi thanh toán vào bảng Payments
            string insertPaySql = @"
                INSERT INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note)
                VALUES (@PaymentCode, @InvoiceId, @PaidAmount, datetime('now', 'localtime'), @PaymentMethod, @CashierId, 'Valid', @Note);";

            await conn.ExecuteAsync(insertPaySql, new
            {
                PaymentCode = receiptCode,
                InvoiceId = invoiceId,
                PaidAmount = amount,
                PaymentMethod = paymentMethod,
                CashierId = cashierId > 0 ? cashierId : 1,
                Note = string.IsNullOrWhiteSpace(note) ? "Thu học phí" : note
            }, trans);

            // 4. Giảm số dư công nợ trong Invoices
            decimal newBalance = Math.Max(0, curBalance - amount);
            string newStatus = newBalance <= 0 ? "Paid" : "PartiallyPaid";

            string updateInvSql = @"
                UPDATE Invoices 
                SET BalanceDue = @NewBalance, 
                    Status = @Status,
                    UpdatedAt = datetime('now', 'localtime')
                WHERE InvoiceId = @InvoiceId;";

            await conn.ExecuteAsync(updateInvSql, new
            {
                NewBalance = newBalance,
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
