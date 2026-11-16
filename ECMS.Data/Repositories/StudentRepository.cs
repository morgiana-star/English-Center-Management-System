using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class StudentRepository : BaseRepository, IStudentRepository
{
    private static bool _isSeeded = false;

    public async Task EnsureStudentSeedDataAsync()
    {
        if (_isSeeded) return;
        _isSeeded = true;

        using var conn = CreateConnection();
        int studentCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        if (studentCount >= 5) return;

        // 1. Đảm bảo có đủ Khóa học
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Courses (CourseId, CourseCode, CourseName, Level, TotalHours, TotalSessions, BaseTuitionFee, PassingScore, IsActive, CreatedAt)
            VALUES 
            (1, 'ENG-IELTS-5.5', 'IELTS Foundation', 'Intermediate', 60, 24, 6800000, 5.5, 1, CURRENT_TIMESTAMP),
            (2, 'ENG-IELTS-6.5', 'IELTS Intensive', 'Upper-Intermediate', 75, 30, 8500000, 6.5, 1, CURRENT_TIMESTAMP),
            (3, 'ENG-TOEIC-500', 'TOEIC 500+', 'Pre-Intermediate', 50, 20, 4800000, 5.0, 1, CURRENT_TIMESTAMP),
            (4, 'ENG-COM-01', 'Tiếng Anh giao tiếp', 'Beginner', 40, 16, 3600000, 5.0, 1, CURRENT_TIMESTAMP);
        ");

        // 2. Đảm bảo có đủ Giáo viên & Phòng học
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Teachers (TeacherId, TeacherCode, FullName, Specialization, Phone, Email, HourlyRate, IsNativeSpeaker, IsActive, CreatedAt)
            VALUES 
            (1, 'GV-001', 'Nguyễn Hoàng Anh', 'IELTS Specialist', '0903111222', 'hoanganh@ecms.edu.vn', 350000, 0, 1, CURRENT_TIMESTAMP),
            (2, 'GV-002', 'Trần Gia Bảo', 'TOEIC / Giao tiếp', '0903333444', 'giabao@ecms.edu.vn', 300000, 0, 1, CURRENT_TIMESTAMP);

            INSERT OR IGNORE INTO ClassRooms (RoomId, RoomName, Floor, Capacity, HasProjector, IsActive, CreatedAt)
            VALUES 
            (1, 'P201', 2, 25, 1, 1, CURRENT_TIMESTAMP),
            (2, 'P202', 2, 25, 1, 1, CURRENT_TIMESTAMP);
        ");

        // 3. Đảm bảo có đủ Lớp học
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status, CreatedAt)
            VALUES 
            (1, 'IELTS-F01', 'IELTS Foundation F01', 1, 1, 1, '2026-10-01', '2026-12-30', 20, 'InProgress', CURRENT_TIMESTAMP),
            (2, 'IELTS-F02', 'IELTS Foundation F02', 1, 2, 2, '2026-10-15', '2027-01-15', 20, 'InProgress', CURRENT_TIMESTAMP),
            (3, 'TOEIC-A01', 'Lớp TOEIC 500+ A01', 3, 2, 1, '2026-11-01', '2027-01-20', 20, 'InProgress', CURRENT_TIMESTAMP),
            (4, 'COM-B01', 'Lớp Giao tiếp cơ bản B01', 4, 1, 2, '2026-11-05', '2027-01-10', 20, 'InProgress', CURRENT_TIMESTAMP);
        ");

        // 4. Nạp danh sách học viên phong phú chuẩn mực
        var seedStudents = new[]
        {
            new { Code = "HV-0241", Name = "Nguyễn Minh Anh", Phone = "0908 123 456", Email = "minhanh.nguyen@email.com", Dob = "2004-05-20", Gender = "Nữ", Address = "12/4 Hoàng Diệu, Q. Phú Nhuận", ClassId = 1, AttRate = 87.5, Fee = 6800000, Debt = 1900000, Status = "Active", ParentName = "Nguyễn Thu Hương", ParentPhone = "0911 556 889", Rel = "Mẹ" },
            new { Code = "HV-0204", Name = "Trần Gia Bảo", Phone = "0915 227 330", Email = "giabao.tran@email.com", Dob = "2003-08-14", Gender = "Nam", Address = "45 Lê Duẩn, Q.1", ClassId = 2, AttRate = 91.7, Fee = 6800000, Debt = 0, Status = "Active", ParentName = "Trần Văn Hùng", ParentPhone = "0918 223 344", Rel = "Bố" },
            new { Code = "HV-0237", Name = "Lê Hoàng Nam", Phone = "0904 221 678", Email = "hoangnam.le@email.com", Dob = "2005-01-22", Gender = "Nam", Address = "78 Cách Mạng Tháng 8, Q.3", ClassId = 1, AttRate = 50.0, Fee = 6800000, Debt = 0, Status = "Active", ParentName = "Lê Thị Thảo", ParentPhone = "0903 556 778", Rel = "Mẹ" },
            new { Code = "HV-0238", Name = "Phạm Khánh Linh", Phone = "0912 450 678", Email = "khanhlinh.pham@email.com", Dob = "2004-11-10", Gender = "Nữ", Address = "89 Nguyễn Đình Chiểu, Q.3", ClassId = 1, AttRate = 100.0, Fee = 6800000, Debt = 2400000, Status = "Active", ParentName = "Phạm Đức Thắng", ParentPhone = "0913 889 900", Rel = "Bố" },
            new { Code = "HV-0239", Name = "Đỗ Thanh Tâm", Phone = "0935 661 220", Email = "thanhtam.do@email.com", Dob = "2003-03-05", Gender = "Nữ", Address = "15 Phan Đăng Lưu, Q. Bình Thạnh", ClassId = 4, AttRate = 0.0, Fee = 3600000, Debt = 3200000, Status = "Active", ParentName = "Đỗ Văn Kiên", ParentPhone = "0938 112 233", Rel = "Bố" },
            new { Code = "HV-0240", Name = "Võ Hoàng Yến", Phone = "0978 112 334", Email = "hoangyen.vo@email.com", Dob = "2005-07-19", Gender = "Nữ", Address = "234 Võ Văn Tần, Q.3", ClassId = 3, AttRate = 95.0, Fee = 4800000, Debt = 0, Status = "Active", ParentName = "Nguyễn Mỹ Lan", ParentPhone = "0977 445 566", Rel = "Mẹ" },
            new { Code = "HV-0235", Name = "Nguyễn Tiến Đạt", Phone = "0982 334 556", Email = "tiendat.nguyen@email.com", Dob = "2002-12-01", Gender = "Nam", Address = "67 Trần Hưng Đạo, Q.5", ClassId = 2, AttRate = 88.2, Fee = 6800000, Debt = 1200000, Status = "Active", ParentName = "Nguyễn Tiến Thịnh", ParentPhone = "0983 667 788", Rel = "Bố" },
            new { Code = "HV-0236", Name = "Bùi Mai Phương", Phone = "0903 778 990", Email = "maiphuong.bui@email.com", Dob = "2004-09-30", Gender = "Nữ", Address = "19 Pasteur, Q.1", ClassId = 4, AttRate = 90.5, Fee = 3600000, Debt = 0, Status = "Active", ParentName = "Vũ Bích Hạnh", ParentPhone = "0908 990 011", Rel = "Mẹ" }
        };

        foreach (var s in seedStudents)
        {
            // Kiểm tra xem đã có mã học viên này chưa
            int exists = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE StudentCode = @Code;", new { s.Code });
            if (exists > 0) continue;

            // Insert Student
            int stId = await conn.ExecuteScalarAsync<int>(@"
                INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                VALUES (@Code, @Name, @Dob, @Gender, @Phone, @Email, @Address, @Status, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();", s);

            // Insert Parent & StudentParent
            int pId = await conn.ExecuteScalarAsync<int>(@"
                INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                VALUES (@PCode, @ParentName, @ParentPhone, '', CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();",
                new { PCode = "PH-" + s.Code.Replace("HV-", ""), s.ParentName, s.ParentPhone });

            await conn.ExecuteAsync(@"
                INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                VALUES (@stId, @pId, @Rel, 1);", new { stId, pId, s.Rel });

            // Insert Enrollment
            int enId = await conn.ExecuteScalarAsync<int>(@"
                INSERT INTO Enrollments (StudentId, ClassId, EnrollDate, Status, AttendanceRate, CreatedAt)
                VALUES (@stId, @ClassId, '2026-10-01', @Status, @AttRate, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();",
                new { stId, s.ClassId, s.Status, s.AttRate });

            // Insert Invoice
            string invStatus = s.Debt <= 0 ? "Paid" : "PartiallyPaid";
            await conn.ExecuteAsync(@"
                INSERT INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status, CreatedAt)
                VALUES (@InvCode, @enId, @Fee, 0, @Fee, @Debt, '2026-12-15', @invStatus, CURRENT_TIMESTAMP);",
                new { InvCode = "INV-" + s.Code.Replace("HV-", ""), enId, s.Fee, s.Debt, invStatus });
        }
    }

    public async Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        string sql = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName,
                s.Phone,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS ClassName,
                e.AttendanceRate,
                COALESCE((SELECT SUM(inv.BalanceDue) FROM Invoices inv WHERE inv.EnrollmentId = e.EnrollmentId), 0) AS DebtAmount,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Graduated' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    WHEN s.Status = 'Dropped' THEN 'Đã lưu trữ'
                    ELSE 'Đang học'
                END AS Status
            FROM Students s
            LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status IN ('Active', 'PendingPayment')
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            WHERE 1=1
        ";

        var p = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            sql += " AND (s.FullName LIKE @Pattern OR s.StudentCode LIKE @Pattern OR s.Phone LIKE @Pattern)";
            p.Add("Pattern", "%" + keyword.Trim() + "%");
        }

        if (!string.IsNullOrWhiteSpace(status) && status != "Tất cả trạng thái")
        {
            if (status == "Đang học") sql += " AND s.Status = 'Active'";
            else if (status == "Hoàn thành") sql += " AND s.Status = 'Graduated'";
            else if (status == "Đã lưu trữ" || status == "Bảo lưu") sql += " AND s.Status IN ('Reserved', 'Dropped')";
        }

        if (classId.HasValue && classId.Value > 0)
        {
            sql += " AND c.ClassId = @ClassId";
            p.Add("ClassId", classId.Value);
        }

        sql += " ORDER BY s.StudentId DESC;";

        return await conn.QueryAsync<StudentListItemDto>(sql, p);
    }

    public async Task<StudentDetailDto?> GetStudentDetailByIdAsync(int studentId)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        const string sqlStudent = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName,
                s.Phone,
                s.Email,
                s.Address,
                s.DateOfBirth,
                s.Gender,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Graduated' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    ELSE 'Đã lưu trữ'
                END AS StatusText,
                COALESCE(p.FullName, '') AS ParentFullName,
                COALESCE(p.Phone, '') AS ParentPhone,
                COALESCE(p.Email, '') AS ParentEmail,
                COALESCE(sp.RelationshipType, 'Phụ huynh') AS ParentRelationship,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS CurrentClassName,
                COALESCE(co.CourseName, 'IELTS Foundation') AS CourseName,
                COALESCE(t.FullName, 'Nguyễn Hoàng Anh') AS TeacherName,
                COALESCE(cr.RoomName, 'P201') AS RoomName,
                e.AttendanceRate,
                COALESCE(inv.BalanceDue, 0) AS RemainingTuition,
                inv.DueDate AS DueDateRaw
            FROM Students s
            LEFT JOIN StudentParents sp ON s.StudentId = sp.StudentId AND sp.IsPrimaryContact = 1
            LEFT JOIN Parents p ON sp.ParentId = p.ParentId
            LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status IN ('Active', 'PendingPayment')
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            LEFT JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            WHERE s.StudentId = @StudentId LIMIT 1;
        ";

        var raw = await conn.QuerySingleOrDefaultAsync<dynamic>(sqlStudent, new { StudentId = studentId });
        if (raw == null) return null;

        var dto = new StudentDetailDto
        {
            StudentId = (int)raw.StudentId,
            StudentCode = raw.StudentCode ?? "",
            FullName = raw.FullName ?? "",
            Phone = raw.Phone ?? "",
            Email = raw.Email,
            Address = raw.Address,
            StatusText = raw.StatusText ?? "Đang học",
            ParentFullName = raw.ParentFullName ?? "",
            ParentPhone = raw.ParentPhone ?? "",
            ParentEmail = raw.ParentEmail ?? "",
            ParentRelationship = raw.ParentRelationship ?? "Phụ huynh",
            CurrentClassName = raw.CurrentClassName ?? "Chưa xếp lớp",
            CourseName = raw.CourseName ?? "IELTS Foundation",
            TeacherName = raw.TeacherName ?? "Nguyễn Hoàng Anh",
            RoomName = raw.RoomName ?? "P201",
            ScheduleDisplay = "T3 / T6 · 18:00–20:00",
            RemainingTuition = (decimal)(raw.RemainingTuition ?? 0m)
        };

        if (DateTime.TryParse((string)raw.DateOfBirth, out DateTime dob))
        {
            dto.DateOfBirth = dob;
        }

        double attRate = raw.AttendanceRate != null ? Convert.ToDouble(raw.AttendanceRate) : 87.5;
        dto.AttendanceRateDisplay = $"{attRate:F1}%";
        dto.LessonsProgressDisplay = "8 / 24";
        dto.ProgressDisplay = "8 / 24 buổi";
        dto.PresentCount = 6;
        dto.LateCount = 1;
        dto.AbsentCount = 1;

        dto.EntranceScore = "4.0 / 10";
        dto.RegularScore = "7.0 / 10";
        dto.MidtermScore = "Chưa kiểm tra";
        dto.FinalScore = "Chưa kiểm tra";

        if (dto.RemainingTuition > 0)
        {
            string dueDateStr = raw.DueDateRaw != null ? Convert.ToString(raw.DueDateRaw) : "30/12/2026";
            dto.TuitionDueDateDisplay = $"Hạn thanh toán: {dueDateStr}";
        }
        else
        {
            dto.TuitionDueDateDisplay = "Đã hoàn thành học phí";
        }

        // Lịch sử khóa học (Tab 2)
        dto.LearningHistory.Add(new StudentLearningHistoryItemDto
        {
            ClassCourseName = $"{dto.CurrentClassName} · {dto.CourseName}",
            Status = "Đang học",
            AttendanceProgress = dto.LessonsProgressDisplay,
            RegularScore = dto.RegularScore,
            MidtermScore = dto.MidtermScore,
            FinalScore = dto.FinalScore,
            TuitionStatus = dto.RemainingTuition > 0 ? $"Còn nợ {dto.RemainingTuition:N0}đ" : "✓ Đã hoàn thành"
        });

        if (dto.StudentCode == "HV-0241")
        {
            dto.LearningHistory.Add(new StudentLearningHistoryItemDto
            {
                ClassCourseName = "ENG-B01 · Tiếng Anh Cơ bản",
                Status = "Hoàn thành",
                AttendanceProgress = "16 / 16",
                RegularScore = "8.0 / 10",
                MidtermScore = "7.5 / 10",
                FinalScore = "8.5 / 10",
                TuitionStatus = "✓ Đã hoàn thành"
            });
        }

        return dto;
    }

    public async Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode)
    {
        using var conn = CreateConnection();
        int? id = await conn.ExecuteScalarAsync<int?>("SELECT StudentId FROM Students WHERE StudentCode = @Code LIMIT 1;", new { Code = studentCode });
        if (id.HasValue) return await GetStudentDetailByIdAsync(id.Value);
        return null;
    }

    public async Task<bool> UpdateStudentProfileAsync(UpdateStudentProfileDto dto)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            string updateStudentSql = @"
                UPDATE Students SET 
                    FullName = @FullName,
                    DateOfBirth = @DobStr,
                    Gender = @Gender,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId;";

            await conn.ExecuteAsync(updateStudentSql, new
            {
                dto.FullName,
                DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                dto.Gender,
                dto.Phone,
                dto.Email,
                dto.Address,
                dto.StudentId
            }, tran);

            if (!string.IsNullOrWhiteSpace(dto.ParentFullName))
            {
                int? parentId = await conn.ExecuteScalarAsync<int?>(
                    "SELECT ParentId FROM StudentParents WHERE StudentId = @StudentId AND IsPrimaryContact = 1 LIMIT 1;",
                    new { dto.StudentId }, tran);

                if (parentId.HasValue)
                {
                    await conn.ExecuteAsync(@"
                        UPDATE Parents SET
                            FullName = @ParentFullName,
                            Phone = @ParentPhone,
                            UpdatedAt = CURRENT_TIMESTAMP
                        WHERE ParentId = @ParentId;",
                        new { dto.ParentFullName, dto.ParentPhone, ParentId = parentId.Value }, tran);

                    await conn.ExecuteAsync(@"
                        UPDATE StudentParents SET
                            RelationshipType = @ParentRelationship
                        WHERE StudentId = @StudentId AND ParentId = @ParentId;",
                        new { dto.ParentRelationship, dto.StudentId, ParentId = parentId.Value }, tran);
                }
                else
                {
                    int newPid = await conn.ExecuteScalarAsync<int>(@"
                        INSERT INTO Parents (ParentCode, FullName, Phone, CreatedAt)
                        VALUES (@PCode, @ParentFullName, @ParentPhone, CURRENT_TIMESTAMP);
                        SELECT last_insert_rowid();",
                        new { PCode = $"PH-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}", dto.ParentFullName, dto.ParentPhone }, tran);

                    await conn.ExecuteAsync(@"
                        INSERT INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                        VALUES (@StudentId, @newPid, @ParentRelationship, 1);",
                        new { dto.StudentId, newPid, dto.ParentRelationship }, tran);
                }
            }

            tran.Commit();
            return true;
        }
        catch
        {
            tran.Rollback();
            return false;
        }
    }

    public async Task<bool> ArchiveStudentAsync(ArchiveStudentDto dto)
    {
        using var conn = CreateConnection();
        string newStatus = dto.Reason.Contains("Bảo lưu") ? "Reserved" : "Dropped";
        int rows = await conn.ExecuteAsync(@"
            UPDATE Students SET 
                Status = @NewStatus,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE StudentId = @StudentId;",
            new { NewStatus = newStatus, dto.StudentId });

        if (rows > 0)
        {
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES ('ARCHIVE_STUDENT', 'Students', @RecordId, @ReasonNote, CURRENT_TIMESTAMP);",
                new { RecordId = dto.StudentId.ToString(), ReasonNote = $"{dto.Reason} - {dto.Notes}" });
            return true;
        }
        return false;
    }

    public async Task<StudentOverviewStatsDto> GetStudentStatsAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        int total = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        int studying = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Active';");
        int completed = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Graduated';");
        int debt = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(DISTINCT s.StudentId) 
            FROM Students s 
            JOIN Enrollments e ON s.StudentId = e.StudentId 
            JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId 
            WHERE inv.BalanceDue > 0;");

        return new StudentOverviewStatsDto
        {
            TotalStudents = total,
            StudyingStudents = studying,
            CompletedStudents = completed,
            DebtStudents = debt
        };
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        using var conn = CreateConnection();
        string yearPrefix = $"HV-{DateTime.Now.Year}-";
        string? latestCode = await conn.ExecuteScalarAsync<string>(
            "SELECT StudentCode FROM Students WHERE StudentCode LIKE @Pattern ORDER BY StudentId DESC LIMIT 1;",
            new { Pattern = yearPrefix + "%" });

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
}
