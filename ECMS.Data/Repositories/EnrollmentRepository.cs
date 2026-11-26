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
                INSERT INTO FeeDiscounts (DiscountId, DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive)
                VALUES 
                (1, 'HVCU10', 'Học viên cũ của trung tâm', 10, 0, 'Áp dụng giảm 10% học phí tri ân học viên đã từng học tại ECMS', 0, 1),
                (2, 'NHOM15', 'Đăng ký theo nhóm (>= 2 người)', 15, 0, 'Giảm 15% học phí khi đăng ký theo nhóm bạn bè / gia đình', 1, 1),
                (3, 'EARLY500', 'Ưu đãi đăng ký sớm (Early Bird)', 0, 500000, 'Giảm trực tiếp 500,000 VNĐ khi đăng ký trước ngày khai giảng', 0, 1);
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
            SELECT DiscountId, COALESCE(DiscountCode, '') AS DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive
            FROM FeeDiscounts
            WHERE IsActive = 1
            ORDER BY DiscountId ASC;";
        return await conn.QueryAsync<FeeDiscountDto>(sql);
    }

    public async Task<IEnumerable<FeeDiscountDto>> GetAllDiscountsAsync()
    {
        await EnsureDiscountSeedDataAsync();
        using var conn = CreateConnection();
        const string sql = @"
            SELECT DiscountId, COALESCE(DiscountCode, '') AS DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive
            FROM FeeDiscounts
            ORDER BY DiscountId DESC;";
        return await conn.QueryAsync<FeeDiscountDto>(sql);
    }

    public async Task<FeeDiscountDto?> GetDiscountByIdAsync(int discountId)
    {
        await EnsureDiscountSeedDataAsync();
        using var conn = CreateConnection();
        const string sql = @"
            SELECT DiscountId, COALESCE(DiscountCode, '') AS DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive
            FROM FeeDiscounts
            WHERE DiscountId = @DiscountId AND IsActive = 1;";
        return await conn.QuerySingleOrDefaultAsync<FeeDiscountDto>(sql, new { DiscountId = discountId });
    }

    public async Task<FeeDiscountDto?> GetDiscountByCodeAsync(string discountCode)
    {
        await EnsureDiscountSeedDataAsync();
        if (string.IsNullOrWhiteSpace(discountCode)) return null;
        using var conn = CreateConnection();
        const string sql = @"
            SELECT DiscountId, COALESCE(DiscountCode, '') AS DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive
            FROM FeeDiscounts
            WHERE UPPER(TRIM(COALESCE(DiscountCode, ''))) = UPPER(TRIM(@Code)) AND IsActive = 1
            LIMIT 1;";
        return await conn.QuerySingleOrDefaultAsync<FeeDiscountDto>(sql, new { Code = discountCode.Trim() });
    }

    public async Task<(bool Success, string Message)> CreateDiscountAsync(FeeDiscountDto dto)
    {
        using var conn = CreateConnection();
        string code = (dto.DiscountCode ?? "").Trim().ToUpperInvariant();
        if (string.IsNullOrWhiteSpace(code))
            return (false, "Mã giảm giá không được để trống.");

        int dup = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM FeeDiscounts WHERE UPPER(TRIM(COALESCE(DiscountCode, ''))) = @Code;",
            new { Code = code });
        if (dup > 0)
            return (false, $"Mã giảm giá '{code}' đã tồn tại trong hệ thống.");

        await conn.ExecuteAsync(@"
            INSERT INTO FeeDiscounts (DiscountCode, DiscountName, Percentage, FixedAmount, Description, RequiresApproval, IsActive, CreatedAt)
            VALUES (@Code, @DiscountName, @Percentage, @FixedAmount, @Description, @RequiresApproval, @IsActive, CURRENT_TIMESTAMP);",
            new
            {
                Code = code,
                DiscountName = dto.DiscountName.Trim(),
                dto.Percentage,
                dto.FixedAmount,
                Description = dto.Description?.Trim() ?? "",
                RequiresApproval = dto.RequiresApproval ? 1 : 0,
                IsActive = dto.IsActive ? 1 : 0
            });
        return (true, $"Đã tạo mã giảm giá '{code}' thành công.");
    }

    public async Task<(bool Success, string Message)> UpdateDiscountAsync(FeeDiscountDto dto)
    {
        using var conn = CreateConnection();
        string code = (dto.DiscountCode ?? "").Trim().ToUpperInvariant();
        if (string.IsNullOrWhiteSpace(code))
            return (false, "Mã giảm giá không được để trống.");

        int dup = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM FeeDiscounts WHERE UPPER(TRIM(COALESCE(DiscountCode, ''))) = @Code AND DiscountId != @Id;",
            new { Code = code, Id = dto.DiscountId });
        if (dup > 0)
            return (false, $"Mã giảm giá '{code}' đã được sử dụng bởi chương trình ưu đãi khác.");

        int rows = await conn.ExecuteAsync(@"
            UPDATE FeeDiscounts SET
                DiscountCode = @Code,
                DiscountName = @DiscountName,
                Percentage = @Percentage,
                FixedAmount = @FixedAmount,
                Description = @Description,
                RequiresApproval = @RequiresApproval,
                IsActive = @IsActive,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE DiscountId = @DiscountId;",
            new
            {
                Code = code,
                DiscountName = dto.DiscountName.Trim(),
                dto.Percentage,
                dto.FixedAmount,
                Description = dto.Description?.Trim() ?? "",
                RequiresApproval = dto.RequiresApproval ? 1 : 0,
                IsActive = dto.IsActive ? 1 : 0,
                dto.DiscountId
            });
        return rows > 0
            ? (true, $"Đã cập nhật mã giảm giá '{code}' thành công.")
            : (false, "Không tìm thấy mã giảm giá cần cập nhật.");
    }

    public async Task<(bool Success, string Message)> DeleteDiscountAsync(int discountId)
    {
        using var conn = CreateConnection();
        int rows = await conn.ExecuteAsync("DELETE FROM FeeDiscounts WHERE DiscountId = @Id;", new { Id = discountId });
        return rows > 0
            ? (true, "Đã xóa mã giảm giá thành công.")
            : (false, "Không tìm thấy mã giảm giá cần xóa.");
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
        const string sql = "SELECT StudentCode FROM Students WHERE StudentCode LIKE 'HV-%' ORDER BY StudentId DESC LIMIT 1;";
        string? latestCode = await conn.ExecuteScalarAsync<string>(sql);

        int nextNumber = 1;
        if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
        {
            string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
            if (int.TryParse(numberPart, out int currentNum))
            {
                nextNumber = currentNum + 1;
            }
        }

        return $"HV-{nextNumber:D4}";
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

    public async Task<(bool Success, string Message, int StudentId, string StudentCode, string InvoiceCode, string ReceiptCode)> ExecuteEnrollmentAndTuitionTransactionAsync(
        StudentEnrollmentWithTuitionDto dto)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            // 1. Tự sinh các mã nghiệp vụ chuẩn
            string studentCode = !string.IsNullOrWhiteSpace(dto.StudentCode) ? dto.StudentCode : await GenerateNextStudentCodeAsync();
            string invoiceCode = await GenerateNextInvoiceCodeAsync();
            string receiptCode = !string.IsNullOrWhiteSpace(dto.ReceiptCode) ? dto.ReceiptCode : $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";

            // 2. Insert bảng Students
            const string insertStudentSql = @"
                INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, 'Active', CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int studentId = await conn.ExecuteScalarAsync<int>(insertStudentSql, new
            {
                StudentCode = studentCode,
                dto.FullName,
                DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                dto.Gender,
                dto.Phone,
                dto.Email,
                dto.Address
            }, tran);

            // 3. Insert bảng Parents & StudentParents (nếu có thông tin)
            if (!string.IsNullOrWhiteSpace(dto.ParentFullName))
            {
                const string insertParentSql = @"
                    INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                    VALUES (@ParentCode, @ParentFullName, @ParentPhone, '', CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();";

                int parentId = await conn.ExecuteScalarAsync<int>(insertParentSql, new
                {
                    ParentCode = $"PH-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}",
                    dto.ParentFullName,
                    dto.ParentPhone
                }, tran);

                const string insertStudentParentSql = @"
                    INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                    VALUES (@StudentId, @ParentId, @ParentRelationship, 1);";

                string normalizedRel = dto.ParentRelationship switch
                {
                    var r when r.Contains("Bố", StringComparison.OrdinalIgnoreCase) => "Bố",
                    var r when r.Contains("Mẹ", StringComparison.OrdinalIgnoreCase) => "Mẹ",
                    var r when r.Contains("Giám hộ", StringComparison.OrdinalIgnoreCase) => "Giám hộ",
                    _ => "Khác"
                };

                await conn.ExecuteAsync(insertStudentParentSql, new
                {
                    StudentId = studentId,
                    ParentId = parentId,
                    ParentRelationship = normalizedRel
                }, tran);
            }

            // 4. Xác định ClassId
            int classId = dto.ClassId;
            if (classId <= 0 && !string.IsNullOrWhiteSpace(dto.ClassCode))
            {
                int? foundClassId = await conn.ExecuteScalarAsync<int?>(
                    "SELECT ClassId FROM Classes WHERE ClassCode = @ClassCode LIMIT 1;",
                    new { dto.ClassCode }, tran);
                classId = foundClassId ?? 1;
            }
            if (classId <= 0) classId = 1;

            // 5. Insert bảng Enrollments (AttendanceRate = NULL để không mặc định 100%)
            string enrollmentStatus = dto.PayNow && dto.AmountPaidNow > 0 ? "Active" : "PendingPayment";
            const string insertEnrollmentSql = @"
                INSERT INTO Enrollments (StudentId, ClassId, EnrollDate, Status, AttendanceRate, CreatedAt)
                VALUES (@StudentId, @ClassId, CURRENT_TIMESTAMP, @EnrollStatus, NULL, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int enrollmentId = await conn.ExecuteScalarAsync<int>(insertEnrollmentSql, new
            {
                StudentId = studentId,
                ClassId = classId,
                EnrollStatus = enrollmentStatus
            }, tran);

            // 6. Insert bảng Invoices (tính hạn đóng đợt tiếp theo dựa trên số buổi / ngày kết thúc lớp)
            decimal discountAmount = Math.Max(0, dto.DiscountAmount);
            decimal finalAmount = Math.Max(0, dto.TotalTuitionFee - discountAmount);
            decimal paidNow = dto.PayNow ? Math.Max(0, dto.AmountPaidNow) : 0m;
            decimal balanceDue = Math.Max(0, finalAmount - paidNow);

            var classDurationInfo = await conn.QueryFirstOrDefaultAsync<(int TotalSessions, string? EndDate)>(@"
                SELECT COALESCE(co.TotalSessions, 24) AS TotalSessions, c.EndDate
                FROM Classes c
                LEFT JOIN Courses co ON c.CourseId = co.CourseId
                WHERE c.ClassId = @ClassId;", new { ClassId = classId }, tran);

            int totalSessions = classDurationInfo.TotalSessions > 0 ? classDurationInfo.TotalSessions : 24;
            int courseDurationDays = Math.Max(21, (int)Math.Round(totalSessions / 3.0 * 7.0));
            int stepDays = paidNow <= 0
                ? 7
                : Math.Clamp((courseDurationDays - 7) / 2, 10, 30);

            DateTime nextDueDt = DateTime.Today.AddDays(stepDays);
            if (!string.IsNullOrWhiteSpace(classDurationInfo.EndDate) &&
                DateTime.TryParse(classDurationInfo.EndDate, out var endDt) &&
                endDt > DateTime.Today.AddDays(10) &&
                nextDueDt > endDt.AddDays(-7))
            {
                nextDueDt = endDt.AddDays(-7);
            }

            string dueDate = balanceDue <= 0 ? DateTime.Today.ToString("yyyy-MM-dd") : nextDueDt.ToString("yyyy-MM-dd");
            string invoiceStatus = balanceDue <= 0 ? "Paid" : (paidNow > 0 ? "PartiallyPaid" : "Unpaid");

            const string insertInvoiceSql = @"
                INSERT INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status, CreatedAt)
                VALUES (@InvoiceCode, @EnrollmentId, @OriginalAmount, @DiscountAmount, @FinalAmount, @BalanceDue, @DueDate, @Status, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int invoiceId = await conn.ExecuteScalarAsync<int>(insertInvoiceSql, new
            {
                InvoiceCode = invoiceCode,
                EnrollmentId = enrollmentId,
                OriginalAmount = dto.TotalTuitionFee,
                DiscountAmount = discountAmount,
                FinalAmount = finalAmount,
                BalanceDue = balanceDue,
                DueDate = dueDate,
                Status = invoiceStatus
            }, tran);

            // 7. Insert bảng Payments (Chỉ tạo khi PayNow = true và AmountPaidNow > 0)
            if (dto.PayNow && paidNow > 0)
            {
                const string insertPaymentSql = @"
                    INSERT INTO Payments (PaymentCode, InvoiceId, PaidAmount, PaymentDate, PaymentMethod, CashierId, Status, Note, CreatedAt)
                    VALUES (@PaymentCode, @InvoiceId, @PaidAmount, CURRENT_TIMESTAMP, @PaymentMethod, @CashierId, 'Valid', @Note, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();";

                string normalizedMethod = dto.PaymentMethod switch
                {
                    var m when m.Contains("Tiền mặt", StringComparison.OrdinalIgnoreCase) => "Tiền mặt",
                    var m when m.Contains("POS", StringComparison.OrdinalIgnoreCase) => "POS",
                    _ => "Chuyển khoản"
                };

                await conn.ExecuteAsync(insertPaymentSql, new
                {
                    PaymentCode = receiptCode,
                    InvoiceId = invoiceId,
                    PaidAmount = paidNow,
                    PaymentMethod = normalizedMethod,
                    CashierId = dto.CashierId > 0 ? dto.CashierId : 1,
                    Note = !string.IsNullOrWhiteSpace(dto.PaymentNote) ? dto.PaymentNote : $"Thu học phí đợt 1 - {dto.FullName} ({studentCode})"
                }, tran);
            }

            tran.Commit();
            string successMsg = dto.PayNow && paidNow > 0
                ? "Ghi danh và lập phiếu thu thành công."
                : "Đã thêm học viên vào lớp (Chưa thu học phí).";
            return (true, successMsg, studentId, studentCode, invoiceCode, dto.PayNow && paidNow > 0 ? receiptCode : string.Empty);
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi giao dịch ghi danh & thu phí: " + ex.Message, 0, string.Empty, string.Empty, string.Empty);
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
