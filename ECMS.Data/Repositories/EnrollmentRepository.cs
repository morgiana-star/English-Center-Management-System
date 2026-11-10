using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class EnrollmentRepository : BaseRepository, IEnrollmentRepository
{
    private static bool _isDiscountSeedChecked = false;

    private async Task EnsureDiscountSeedDataAsync()
    {
        if (_isDiscountSeedChecked) return;
        _isDiscountSeedChecked = true;

        using var conn = CreateConnection();
        int count = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM FeeDiscounts;");
        if (count == 0)
        {
            await conn.ExecuteAsync(@"
                INSERT INTO FeeDiscounts (DiscountId, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive)
                VALUES 
                (1, 'Học viên cũ của trung tâm', 10, 0, 'Áp dụng giảm 10% học phí tri ân học viên đã từng học tại ECMS', 0, 1),
                (2, 'Đăng ký theo nhóm (>= 2 người)', 15, 0, 'Giảm 15% học phí khi đăng ký theo nhóm bạn bè / gia đình', 1, 1),
                (3, 'Ưu đãi đăng ký sớm (Early Bird)', 0, 500000, 'Giảm trực tiếp 500,000 VNĐ khi đăng ký trước ngày khai giảng', 0, 1);
            ");
        }
    }

    public async Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.BaseTuitionFee AS TuitionFee,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('PendingPayment', 'Active')) AS CurrentStudents,
                c.MaxStudents,
                c.Status
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')
            ORDER BY c.ClassId DESC;";

        return await conn.QueryAsync<ClassLookupDto>(sql);
    }

    public async Task<ClassLookupDto?> GetClassByIdAsync(int classId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.BaseTuitionFee AS TuitionFee,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('PendingPayment', 'Active')) AS CurrentStudents,
                c.MaxStudents,
                c.Status
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.ClassId = @ClassId;";

        return await conn.QuerySingleOrDefaultAsync<ClassLookupDto>(sql, new { ClassId = classId });
    }

    public async Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync()
    {
        await EnsureDiscountSeedDataAsync();
        using var conn = CreateConnection();
        const string sql = @"
            SELECT DiscountId, DiscountName, Percentage, FixedAmount, Description, RequiresApproval
            FROM FeeDiscounts
            WHERE IsActive = 1
            ORDER BY DiscountId ASC;";
        return await conn.QueryAsync<FeeDiscountDto>(sql);
    }

    public async Task<FeeDiscountDto?> GetDiscountByIdAsync(int discountId)
    {
        await EnsureDiscountSeedDataAsync();
        using var conn = CreateConnection();
        const string sql = @"
            SELECT DiscountId, DiscountName, Percentage, FixedAmount, Description, RequiresApproval
            FROM FeeDiscounts
            WHERE DiscountId = @DiscountId AND IsActive = 1;";
        return await conn.QuerySingleOrDefaultAsync<FeeDiscountDto>(sql, new { DiscountId = discountId });
    }

    public async Task<bool> IsExistingStudentByPhoneAsync(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone)) return false;

        using var conn = CreateConnection();
        const string sql = @"
            SELECT COUNT(*) 
            FROM Students s
            JOIN Enrollments e ON s.StudentId = e.StudentId
            WHERE s.Phone = @Phone;";
        int count = await conn.ExecuteScalarAsync<int>(sql, new { Phone = phone.Trim() });
        return count > 0;
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        using var conn = CreateConnection();
        string yearPrefix = $"HV-{DateTime.Now.Year}-";
        const string sql = "SELECT StudentCode FROM Students WHERE StudentCode LIKE @Pattern ORDER BY StudentId DESC LIMIT 1;";
        string? latestCode = await conn.ExecuteScalarAsync<string>(sql, new { Pattern = yearPrefix + "%" });

        int nextNumber = 1;
        if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
        {
            string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
            if (int.TryParse(numberPart, out int currentNum))
            {
                nextNumber = currentNum + 1;
            }
        }

        return $"{yearPrefix}{nextNumber:D4}";
    }

    public async Task<string> GenerateNextInvoiceCodeAsync()
    {
        using var conn = CreateConnection();
        string todayPrefix = $"INV-{DateTime.Now:yyyyMMdd}-";
        const string sql = "SELECT InvoiceCode FROM Invoices WHERE InvoiceCode LIKE @Pattern ORDER BY InvoiceId DESC LIMIT 1;";
        string? latestCode = await conn.ExecuteScalarAsync<string>(sql, new { Pattern = todayPrefix + "%" });

        int nextNumber = 1;
        if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
        {
            string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
            if (int.TryParse(numberPart, out int currentNum))
            {
                nextNumber = currentNum + 1;
            }
        }

        return $"{todayPrefix}{nextNumber:D3}";
    }

    public async Task<int?> FindStudentIdByPhoneAsync(string phone)
    {
        using var conn = CreateConnection();
        const string sql = "SELECT StudentId FROM Students WHERE Phone = @Phone LIMIT 1;";
        return await conn.ExecuteScalarAsync<int?>(sql, new { Phone = phone.Trim() });
    }

    public async Task<bool> CheckStudentEnrolledAsync(int studentId, int classId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT COUNT(*) 
            FROM Enrollments 
            WHERE StudentId = @StudentId 
              AND ClassId = @ClassId 
              AND Status NOT IN ('Dropped');";
        int count = await conn.ExecuteScalarAsync<int>(sql, new { StudentId = studentId, ClassId = classId });
        return count > 0;
    }

    public async Task<(bool Success, string Message, int StudentId, int EnrollmentId, int InvoiceId, string InvoiceCode)> ExecuteEnrollmentTransactionAsync(
        StudentEnrollmentDto dto,
        string studentCode,
        string invoiceCode)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            int studentId = dto.StudentId;

            // 1. Nếu chưa có StudentId -> Tạo mới hồ sơ Học viên
            if (studentId <= 0)
            {
                const string insertStudentSql = @"
                    INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, LeadId, CreatedAt)
                    VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, 'Active', @LeadId, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();";

                studentId = await conn.ExecuteScalarAsync<int>(insertStudentSql, new
                {
                    StudentCode = studentCode,
                    dto.FullName,
                    DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                    dto.Gender,
                    dto.Phone,
                    dto.Email,
                    dto.Address,
                    dto.LeadId
                }, tran);
            }

            // 2. Insert vào bảng Enrollments (Status = 'PendingPayment' chờ đóng học phí)
            const string insertEnrollmentSql = @"
                INSERT INTO Enrollments (StudentId, ClassId, EnrollDate, Status, CreatedAt)
                VALUES (@StudentId, @ClassId, CURRENT_TIMESTAMP, 'PendingPayment', CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int enrollmentId = await conn.ExecuteScalarAsync<int>(insertEnrollmentSql, new
            {
                StudentId = studentId,
                dto.ClassId
            }, tran);

            // 3. Tự động sinh Hóa đơn học phí (Invoices) sang phân hệ Kế toán (Bạn 2)
            string dueDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
            string invoiceStatus = dto.FinalAmount <= 0 ? "Paid" : "Unpaid";

            const string insertInvoiceSql = @"
                INSERT INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status, CreatedAt)
                VALUES (@InvoiceCode, @EnrollmentId, @OriginalAmount, @DiscountAmount, @FinalAmount, @BalanceDue, @DueDate, @Status, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int invoiceId = await conn.ExecuteScalarAsync<int>(insertInvoiceSql, new
            {
                InvoiceCode = invoiceCode,
                EnrollmentId = enrollmentId,
                dto.OriginalAmount,
                dto.DiscountAmount,
                dto.FinalAmount,
                BalanceDue = dto.FinalAmount, // Mới đăng ký chưa thu đồng nào
                DueDate = dueDate,
                Status = invoiceStatus
            }, tran);

            // Nếu miễn phí 100% -> chuyển Enrollment thành Active luôn
            if (dto.FinalAmount <= 0)
            {
                await conn.ExecuteAsync("UPDATE Enrollments SET Status = 'Active' WHERE EnrollmentId = @EnrollmentId;", new { EnrollmentId = enrollmentId }, tran);
            }

            // 4. Nếu chuyển đổi từ Lead -> Cập nhật Lead thành 'Converted'
            if (dto.LeadId.HasValue && dto.LeadId.Value > 0)
            {
                const string updateLeadSql = "UPDATE Leads SET Status = 'Converted', UpdatedAt = CURRENT_TIMESTAMP WHERE LeadId = @LeadId;";
                await conn.ExecuteAsync(updateLeadSql, new { LeadId = dto.LeadId.Value }, tran);
            }

            tran.Commit();
            return (true, "Đăng ký xếp lớp & phát hành hóa đơn thành công!", studentId, enrollmentId, invoiceId, invoiceCode);
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi giao dịch xếp lớp & sinh hóa đơn: " + ex.Message, 0, 0, 0, string.Empty);
        }
    }

    public async Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                e.EnrollmentId,
                e.StudentId,
                s.StudentCode,
                s.FullName AS StudentName,
                s.Phone,
                c.ClassId,
                c.ClassName,
                co.CourseName,
                e.EnrollDate,
                e.Status,
                COALESCE(inv.InvoiceCode, '-') AS InvoiceCode,
                COALESCE(inv.OriginalAmount, co.BaseTuitionFee) AS OriginalAmount,
                COALESCE(inv.DiscountAmount, 0) AS DiscountAmount,
                COALESCE(inv.FinalAmount, co.BaseTuitionFee) AS FinalAmount,
                COALESCE(inv.Status, 'Unpaid') AS InvoiceStatus
            FROM Enrollments e
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            ORDER BY e.EnrollmentId DESC
            LIMIT @Limit;";

        return await conn.QueryAsync<EnrollmentListItemDto>(sql, new { Limit = limit });
    }
}
