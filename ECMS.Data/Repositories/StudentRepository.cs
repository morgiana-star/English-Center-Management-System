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

        // 1. Đảm bảo có đủ 4 Khóa học
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
            (2, 'P202', 2, 25, 1, 1, CURRENT_TIMESTAMP),
            (3, 'P101', 1, 25, 1, 1, CURRENT_TIMESTAMP);
        ");

        // 3. Đảm bảo có đủ Lớp học (đủ các khóa & ca sáng/chiều/tối)
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status, CreatedAt)
            VALUES 
            (1, 'IELTS-F01', 'IELTS Foundation F01', 1, 1, 1, '2026-10-01', '2026-12-30', 20, 'InProgress', CURRENT_TIMESTAMP),
            (2, 'IELTS-F02', 'IELTS Foundation F02', 1, 2, 2, '2026-10-15', '2027-01-15', 20, 'InProgress', CURRENT_TIMESTAMP),
            (3, 'TOEIC-A01', 'Lớp TOEIC 500+ A01', 3, 2, 1, '2026-11-01', '2027-01-20', 20, 'InProgress', CURRENT_TIMESTAMP),
            (4, 'COM-B01', 'Lớp Giao tiếp cơ bản B01', 4, 1, 2, '2026-11-05', '2027-01-10', 20, 'InProgress', CURRENT_TIMESTAMP),
            (7, 'IELTS-F03', 'IELTS Foundation F03 (Ca sáng)', 1, 1, 3, '2026-12-10', '2027-03-10', 20, 'OpenForEnrollment', CURRENT_TIMESTAMP),
            (8, 'IELTS-I02', 'IELTS Intensive I02 (Ca chiều)', 2, 1, 1, '2026-12-12', '2027-03-20', 15, 'OpenForEnrollment', CURRENT_TIMESTAMP),
            (9, 'COM-B02', 'Giao tiếp quốc tế B02 (Ca tối)', 4, 2, 2, '2026-12-15', '2027-02-28', 18, 'OpenForEnrollment', CURRENT_TIMESTAMP);
        ");

        // Đảm bảo mỗi lớp đều có lịch học mẫu trong ClassSchedules để hiển thị ca sáng/chiều/tối
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO ClassSchedules (ScheduleId, ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, Topic)
            VALUES
            (301, 7, 1, '2026-12-10', '08:30', '10:30', 3, 1, 'Khai giảng IELTS F03 (Sáng)'),
            (302, 8, 1, '2026-12-12', '14:00', '16:00', 1, 1, 'Khai giảng IELTS I02 (Chiều)'),
            (303, 9, 1, '2026-12-15', '18:30', '20:30', 2, 2, 'Khai giảng Giao tiếp B02 (Tối)');
        ");

        // 4. Nạp danh sách học viên mẫu nếu chưa có đủ
        int studentCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        if (studentCount < 5)
        {
            var seedStudents = new[]
            {
                new { Code = "HV-0241", Name = "Nguyễn Minh Anh", Phone = "0908 123 456", Email = "minhanh.nguyen@email.com", Dob = "2004-05-20", Gender = "Nữ", Address = "12/4 Hoàng Diệu, Q. Phú Nhuận", ClassId = 1, AttRate = 87.5, Fee = 6800000, Debt = 1900000, Status = "Active", ParentName = "Nguyễn Thu Hương", ParentPhone = "0911 556 889", Rel = "Mẹ" },
                new { Code = "HV-0204", Name = "Trần Gia Bảo", Phone = "0915 227 330", Email = "giabao.tran@email.com", Dob = "2003-08-14", Gender = "Nam", Address = "45 Lê Duẩn, Q.1", ClassId = 2, AttRate = 91.7, Fee = 6800000, Debt = 0, Status = "Completed", ParentName = "Trần Văn Hùng", ParentPhone = "0918 223 344", Rel = "Bố" },
                new { Code = "HV-0237", Name = "Lê Hoàng Nam", Phone = "0904 221 678", Email = "hoangnam.le@email.com", Dob = "2005-01-22", Gender = "Nam", Address = "78 Cách Mạng Tháng 8, Q.3", ClassId = 1, AttRate = 50.0, Fee = 6800000, Debt = 0, Status = "Active", ParentName = "Lê Thị Thảo", ParentPhone = "0903 556 778", Rel = "Mẹ" },
                new { Code = "HV-0238", Name = "Phạm Khánh Linh", Phone = "0912 450 678", Email = "khanhlinh.pham@email.com", Dob = "2004-11-10", Gender = "Nữ", Address = "89 Nguyễn Đình Chiểu, Q.3", ClassId = 1, AttRate = 100.0, Fee = 6800000, Debt = 2400000, Status = "Active", ParentName = "Phạm Đức Thắng", ParentPhone = "0913 889 900", Rel = "Bố" },
                new { Code = "HV-0239", Name = "Đỗ Thanh Tâm", Phone = "0935 661 220", Email = "thanhtam.do@email.com", Dob = "2003-03-05", Gender = "Nữ", Address = "15 Phan Đăng Lưu, Q. Bình Thạnh", ClassId = 4, AttRate = 0.0, Fee = 3600000, Debt = 3200000, Status = "Reserved", ParentName = "Đỗ Văn Kiên", ParentPhone = "0938 112 233", Rel = "Bố" },
                new { Code = "HV-0240", Name = "Võ Hoàng Yến", Phone = "0978 112 334", Email = "hoangyen.vo@email.com", Dob = "2005-07-19", Gender = "Nữ", Address = "234 Võ Văn Tần, Q.3", ClassId = 3, AttRate = 95.0, Fee = 4800000, Debt = 0, Status = "Active", ParentName = "Nguyễn Mỹ Lan", ParentPhone = "0977 445 566", Rel = "Mẹ" },
                new { Code = "HV-0235", Name = "Nguyễn Tiến Đạt", Phone = "0982 334 556", Email = "tiendat.nguyen@email.com", Dob = "2002-12-01", Gender = "Nam", Address = "67 Trần Hưng Đạo, Q.5", ClassId = 2, AttRate = 88.2, Fee = 6800000, Debt = 1200000, Status = "Active", ParentName = "Nguyễn Tiến Thịnh", ParentPhone = "0983 667 788", Rel = "Bố" },
                new { Code = "HV-0236", Name = "Bùi Mai Phương", Phone = "0903 778 990", Email = "maiphuong.bui@email.com", Dob = "2004-09-30", Gender = "Nữ", Address = "19 Pasteur, Q.1", ClassId = 4, AttRate = 90.5, Fee = 3600000, Debt = 0, Status = "Active", ParentName = "Vũ Bích Hạnh", ParentPhone = "0908 990 011", Rel = "Mẹ" }
            };

            foreach (var s in seedStudents)
            {
                int exists = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE StudentCode = @Code;", new { s.Code });
                if (exists > 0) continue;

                int stId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                    VALUES (@Code, @Name, @Dob, @Gender, @Phone, @Email, @Address, @Status, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();", s);

                int pId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                    VALUES (@PCode, @ParentName, @ParentPhone, '', CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new { PCode = "PH-" + s.Code.Replace("HV-", ""), s.ParentName, s.ParentPhone });

                await conn.ExecuteAsync(@"
                    INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                    VALUES (@stId, @pId, @Rel, 1);", new { stId, pId, s.Rel });

                string enStatus = s.Status == "Completed" ? "Completed" : (s.Status == "Reserved" ? "Reserved" : "Active");
                int enId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Enrollments (StudentId, ClassId, EnrollDate, Status, AttendanceRate, CreatedAt)
                    VALUES (@stId, @ClassId, '2026-10-01', @enStatus, @AttRate, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new { stId, s.ClassId, enStatus, s.AttRate });

                string invStatus = s.Debt <= 0 ? "Paid" : "PartiallyPaid";
                await conn.ExecuteAsync(@"
                    INSERT INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status, CreatedAt)
                    VALUES (@InvCode, @enId, @Fee, 0, @Fee, @Debt, '2026-12-15', @invStatus, CURRENT_TIMESTAMP);",
                    new { InvCode = "INV-" + s.Code.Replace("HV-", ""), enId, s.Fee, s.Debt, invStatus });
            }
        }

        // 5. Đảm bảo có dữ liệu Exams & ExamScores thật cho các lớp
        int examCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Exams;");
        if (examCount == 0)
        {
            await conn.ExecuteAsync(@"
                INSERT OR IGNORE INTO Exams (ExamId, ClassId, ExamName, Type, ExamDate, WeightPercentage)
                VALUES
                (1, 1, 'Kiểm tra đầu vào IELTS', 'Placement', '2026-10-01', 0),
                (2, 1, 'Kiểm tra thường xuyên T10', 'Regular', '2026-10-20', 20),
                (3, 1, 'Kiểm tra giữa khóa F01', 'Midterm', '2026-11-10', 30),
                (4, 2, 'Kiểm tra thường xuyên F02', 'Regular', '2026-10-22', 20),
                (5, 2, 'Kiểm tra giữa khóa F02', 'Midterm', '2026-11-12', 30),
                (6, 2, 'Thi cuối khóa F02', 'Final', '2026-12-20', 50);
            ");

            var stRows = (await conn.QueryAsync<(int StudentId, int ClassId)>(@"
                SELECT e.StudentId, e.ClassId FROM Enrollments e ORDER BY e.StudentId LIMIT 8;")).ToList();

            foreach (var st in stRows)
            {
                if (st.ClassId == 1)
                {
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO ExamScores (ExamId, StudentId, ScoreValue, TeacherComments) VALUES
                        (1, @Id, 4.5, 'Phát âm tốt, cần cải thiện từ vựng'),
                        (2, @Id, 7.5, 'Tham gia phát biểu tích cực');", new { Id = st.StudentId });
                }
                else if (st.ClassId == 2)
                {
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO ExamScores (ExamId, StudentId, ScoreValue, TeacherComments) VALUES
                        (4, @Id, 8.0, 'Bài tập về nhà đầy đủ'),
                        (5, @Id, 7.5, 'Kỹ năng Reading vững'),
                        (6, @Id, 8.5, 'Đạt chuẩn đầu ra khóa học');", new { Id = st.StudentId });
                }
            }
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
                COALESCE(s.Phone, '') AS Phone,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS ClassName,
                e.AttendanceRate,
                COALESCE((SELECT SUM(inv.BalanceDue) FROM Invoices inv WHERE inv.EnrollmentId = e.EnrollmentId), 0) AS DebtAmount,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Completed' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    WHEN s.Status = 'Dropped' THEN 'Đã lưu trữ'
                    ELSE 'Đang học'
                END AS Status
            FROM Students s
            LEFT JOIN Enrollments e ON e.EnrollmentId = (
                SELECT e2.EnrollmentId FROM Enrollments e2
                WHERE e2.StudentId = s.StudentId
                ORDER BY e2.EnrollmentId DESC LIMIT 1
            )
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            WHERE 1=1
        ";

        var p = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            sql += " AND (s.FullName LIKE @Pattern OR s.StudentCode LIKE @Pattern OR COALESCE(s.Phone, '') LIKE @Pattern)";
            p.Add("Pattern", "%" + keyword.Trim() + "%");
        }

        if (string.Equals(status, "Archived", StringComparison.OrdinalIgnoreCase))
        {
            sql += " AND s.Status IN ('Reserved', 'Dropped')";
        }
        else if (!string.IsNullOrWhiteSpace(status) && status != "Tất cả trạng thái")
        {
            if (status == "Đang học") sql += " AND s.Status = 'Active'";
            else if (status == "Hoàn thành") sql += " AND s.Status = 'Completed'";
            else if (status == "Đã lưu trữ" || status == "Bảo lưu") sql += " AND s.Status IN ('Reserved', 'Dropped')";
        }
        else
        {
            // Danh sách chính chỉ hiển thị học viên chưa đưa vào lưu trữ
            sql += " AND s.Status IN ('Active', 'Completed')";
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
                COALESCE(s.Phone, '') AS Phone,
                s.Email,
                s.Address,
                s.DateOfBirth,
                s.Gender,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Completed' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    ELSE 'Đã lưu trữ'
                END AS StatusText,
                COALESCE(p.FullName, '') AS ParentFullName,
                COALESCE(p.Phone, '') AS ParentPhone,
                COALESCE(p.Email, '') AS ParentEmail,
                COALESCE(sp.RelationshipType, 'Bố') AS ParentRelationship,
                COALESCE(e.EnrollmentId, 0) AS EnrollmentId,
                COALESCE(e.ClassId, 0) AS ClassId,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS CurrentClassName,
                COALESCE(co.CourseName, 'Chưa đăng ký') AS CourseName,
                COALESCE(co.TotalSessions, 24) AS TotalSessions,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                e.AttendanceRate,
                COALESCE(inv.BalanceDue, 0) AS RemainingTuition,
                inv.DueDate AS DueDateRaw
            FROM Students s
            LEFT JOIN StudentParents sp ON s.StudentId = sp.StudentId AND sp.IsPrimaryContact = 1
            LEFT JOIN Parents p ON sp.ParentId = p.ParentId
            LEFT JOIN Enrollments e ON e.EnrollmentId = (
                SELECT e2.EnrollmentId FROM Enrollments e2 WHERE e2.StudentId = s.StudentId ORDER BY e2.EnrollmentId DESC LIMIT 1
            )
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            LEFT JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            WHERE s.StudentId = @StudentId LIMIT 1;
        ";

        var raw = await conn.QuerySingleOrDefaultAsync<dynamic>(sqlStudent, new { StudentId = studentId });
        if (raw == null) return null;

        int currentClassId = (int)(raw.ClassId ?? 0);
        int totalSessions = (int)(raw.TotalSessions ?? 24);

        // Truy vấn lịch học thật của lớp từ ClassSchedules
        string scheduleDisplay = "Chưa xếp lịch";
        if (currentClassId > 0)
        {
            var sch = await conn.QueryFirstOrDefaultAsync<(string Date, string StartTime, string EndTime)?>(
                "SELECT Date, StartTime, EndTime FROM ClassSchedules WHERE ClassId = @ClassId ORDER BY Date DESC LIMIT 1;",
                new { ClassId = currentClassId });
            if (sch.HasValue)
            {
                scheduleDisplay = $"{sch.Value.StartTime}–{sch.Value.EndTime}";
            }
        }

        // Truy vấn số buổi điểm danh thật từ AttendanceRecords của học viên
        var attStats = await conn.QuerySingleOrDefaultAsync<(int PresentCnt, int LateCnt, int AbsentCnt)>(@"
            SELECT 
                COALESCE(SUM(CASE WHEN ar.Status = 'Present' THEN 1 ELSE 0 END), 0) AS PresentCnt,
                COALESCE(SUM(CASE WHEN ar.Status = 'Late' THEN 1 ELSE 0 END), 0) AS LateCnt,
                COALESCE(SUM(CASE WHEN ar.Status IN ('Absent', 'Excused') THEN 1 ELSE 0 END), 0) AS AbsentCnt
            FROM AttendanceRecords ar
            LEFT JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE ar.StudentId = @StudentId
              AND (@ClassId = 0 OR cs.ClassId = @ClassId);",
            new { StudentId = studentId, ClassId = currentClassId });

        int totalRecorded = attStats.PresentCnt + attStats.LateCnt + attStats.AbsentCnt;
        double attRate = totalRecorded > 0
            ? Math.Round((attStats.PresentCnt + attStats.LateCnt) * 100.0 / totalRecorded, 1)
            : 0.0;

        // Truy vấn điểm thật từ bảng ExamScores JOIN Exams
        var scoreRows = (await conn.QueryAsync<(string Type, double ScoreValue)>(@"
            SELECT ex.Type, es.ScoreValue
            FROM ExamScores es
            JOIN Exams ex ON es.ExamId = ex.ExamId
            WHERE es.StudentId = @StudentId
              AND (@ClassId = 0 OR ex.ClassId = @ClassId OR ex.Type = 'Placement');",
            new { StudentId = studentId, ClassId = currentClassId })).ToList();

        string FormatScore(string type)
        {
            var matched = scoreRows.FirstOrDefault(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
            return matched != default ? $"{matched.ScoreValue:0.0} / 10" : "Chưa có điểm";
        }

        var dto = new StudentDetailDto
        {
            StudentId = (int)raw.StudentId,
            StudentCode = raw.StudentCode ?? "",
            FullName = raw.FullName ?? "",
            Phone = raw.Phone ?? "",
            Email = raw.Email,
            Address = raw.Address,
            Gender = raw.Gender ?? "Nam",
            StatusText = raw.StatusText ?? "Đang học",
            ParentFullName = raw.ParentFullName ?? "",
            ParentPhone = raw.ParentPhone ?? "",
            ParentEmail = raw.ParentEmail ?? "",
            ParentRelationship = raw.ParentRelationship ?? "Bố",
            CurrentClassName = raw.CurrentClassName ?? "Chưa xếp lớp",
            CourseName = raw.CourseName ?? "Chưa đăng ký",
            TeacherName = raw.TeacherName ?? "Chưa phân công",
            RoomName = raw.RoomName ?? "Chưa xếp phòng",
            ScheduleDisplay = scheduleDisplay,
            RemainingTuition = (decimal)(raw.RemainingTuition ?? 0m),
            AttendanceRateDisplay = $"{attRate:F1}%",
            LessonsProgressDisplay = $"{totalRecorded} / {totalSessions}",
            ProgressDisplay = $"{totalRecorded} / {totalSessions} buổi",
            PresentCount = attStats.PresentCnt,
            LateCount = attStats.LateCnt,
            AbsentCount = attStats.AbsentCnt,
            EntranceScore = FormatScore("Placement"),
            RegularScore = FormatScore("Regular"),
            MidtermScore = FormatScore("Midterm"),
            FinalScore = FormatScore("Final")
        };

        if (DateTime.TryParse((string?)raw.DateOfBirth, out DateTime dob))
        {
            dto.DateOfBirth = dob;
        }

        if (dto.RemainingTuition > 0)
        {
            string dueDateStr = raw.DueDateRaw != null ? Convert.ToString(raw.DueDateRaw) : "30/12/2026";
            dto.TuitionDueDateDisplay = $"Hạn thanh toán: {dueDateStr}";
        }
        else
        {
            dto.TuitionDueDateDisplay = "Đã hoàn thành học phí";
        }

        // Tab 2: Truy vấn TẤT CẢ các Enrollment thật của học viên này trong DB
        const string sqlHistory = @"
            SELECT 
                e.EnrollmentId,
                e.ClassId,
                c.ClassCode,
                co.CourseName,
                co.TotalSessions,
                e.Status AS EnrollStatus,
                COALESCE(inv.BalanceDue, 0) AS BalanceDue,
                (SELECT COUNT(*) FROM AttendanceRecords ar JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = e.StudentId AND cs.ClassId = e.ClassId) AS RecordedCount,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Regular' LIMIT 1) AS RegularVal,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Midterm' LIMIT 1) AS MidtermVal,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Final' LIMIT 1) AS FinalVal
            FROM Enrollments e
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            WHERE e.StudentId = @StudentId
            ORDER BY e.EnrollmentId DESC;";

        var historyRows = await conn.QueryAsync<dynamic>(sqlHistory, new { StudentId = studentId });
        foreach (var h in historyRows)
        {
            string enStatus = (string)(h.EnrollStatus ?? "Active");
            string statusVi = enStatus switch
            {
                "Completed" => "Hoàn thành",
                "Reserved" => "Bảo lưu",
                "Dropped" => "Đã nghỉ",
                "Transferred" => "Đã chuyển lớp",
                "PendingPayment" => "Chờ đóng phí",
                _ => "Đang học"
            };

            decimal bal = (decimal)(h.BalanceDue ?? 0m);
            int recCnt = (int)(h.RecordedCount ?? 0);
            int totSess = (int)(h.TotalSessions ?? 24);

            string regStr = h.RegularVal != null ? $"{Convert.ToDouble(h.RegularVal):0.0} / 10" : "Chưa có điểm";
            string midStr = h.MidtermVal != null ? $"{Convert.ToDouble(h.MidtermVal):0.0} / 10" : "Chưa kiểm tra";
            string finStr = h.FinalVal != null ? $"{Convert.ToDouble(h.FinalVal):0.0} / 10" : "Chưa kiểm tra";

            dto.LearningHistory.Add(new StudentLearningHistoryItemDto
            {
                ClassCourseName = $"{h.ClassCode} · {h.CourseName}",
                Status = statusVi,
                AttendanceProgress = $"{recCnt} / {totSess}",
                RegularScore = regStr,
                MidtermScore = midStr,
                FinalScore = finStr,
                TuitionStatus = bal > 0 ? $"Còn nợ {bal:N0}đ" : "✓ Đã hoàn thành"
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

            string rel = NormalizeRelationship(dto.ParentRelationship);
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
                            RelationshipType = @Rel
                        WHERE StudentId = @StudentId AND ParentId = @ParentId;",
                        new { Rel = rel, dto.StudentId, ParentId = parentId.Value }, tran);
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
                        VALUES (@StudentId, @newPid, @Rel, 1);",
                        new { dto.StudentId, newPid, Rel = rel }, tran);
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

    public async Task<bool> RestoreStudentAsync(int studentId)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            int rows = await conn.ExecuteAsync(@"
                UPDATE Students SET 
                    Status = 'Active',
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId;", new { StudentId = studentId }, tran);

            await conn.ExecuteAsync(@"
                UPDATE Enrollments SET 
                    Status = 'Active',
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId AND Status IN ('Reserved', 'Dropped');",
                new { StudentId = studentId }, tran);

            if (rows > 0)
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                    VALUES ('RESTORE_STUDENT', 'Students', @RecordId, 'Khôi phục hồ sơ học viên về trạng thái Đang học', CURRENT_TIMESTAMP);",
                    new { RecordId = studentId.ToString() }, tran);
            }

            tran.Commit();
            return rows > 0;
        }
        catch
        {
            tran.Rollback();
            return false;
        }
    }

    public async Task<StudentOverviewStatsDto> GetStudentStatsAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        int total = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        int studying = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Active';");
        int completed = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Completed';");
        int archived = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status IN ('Reserved', 'Dropped');");
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
            ArchivedStudents = archived,
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

    public async Task<IEnumerable<CourseLookupDto>> GetActiveCoursesForEnrollmentAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        return await conn.QueryAsync<CourseLookupDto>(@"
            SELECT CourseId, CourseCode, CourseName, Level, TotalSessions, BaseTuitionFee
            FROM Courses
            WHERE IsActive = 1
            ORDER BY CourseId ASC;");
    }

    public async Task<IEnumerable<OpenClassOptionDto>> GetOpenClassesByCourseAsync(int courseId)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.BaseTuitionFee AS TuitionFee,
                c.StartDate,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentStudents,
                c.MaxStudents,
                COALESCE((SELECT cs.StartTime || ' - ' || cs.EndTime FROM ClassSchedules cs WHERE cs.ClassId = c.ClassId ORDER BY cs.Date DESC LIMIT 1), '18:00 - 20:00') AS TimeRange,
                COALESCE((SELECT cs.StartTime FROM ClassSchedules cs WHERE cs.ClassId = c.ClassId ORDER BY cs.Date DESC LIMIT 1), '18:00') AS StartTime
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.CourseId = @CourseId
              AND c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')
            ORDER BY c.StartDate ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { CourseId = courseId });
        var result = new List<OpenClassOptionDto>();
        foreach (var r in rows)
        {
            string startRaw = r.StartDate ?? "";
            string startDisplay = DateTime.TryParse(startRaw, out DateTime dt) ? dt.ToString("dd/MM/yyyy") : startRaw;

            result.Add(new OpenClassOptionDto
            {
                ClassId = (int)r.ClassId,
                ClassCode = r.ClassCode ?? "",
                ClassName = r.ClassName ?? "",
                CourseId = (int)r.CourseId,
                CourseName = r.CourseName ?? "",
                TuitionFee = (decimal)(r.TuitionFee ?? 0m),
                StartDateDisplay = startDisplay,
                ScheduleDisplay = r.TimeRange ?? "18:00 - 20:00",
                StartTime = r.StartTime ?? "18:00",
                RoomName = r.RoomName ?? "P201",
                TeacherName = r.TeacherName ?? "Chưa phân công",
                CurrentStudents = (int)(r.CurrentStudents ?? 0),
                MaxStudents = (int)(r.MaxStudents ?? 20)
            });
        }
        return result;
    }

    public async Task<HashSet<string>> GetExistingStudentPhonesAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        var phones = await conn.QueryAsync<string>("SELECT Phone FROM Students WHERE Phone IS NOT NULL AND Phone != '';");
        return new HashSet<string>(phones, StringComparer.OrdinalIgnoreCase);
    }

    public async Task<StudentImportResultDto> ImportStudentsBatchAsync(List<StudentImportRowDto> validStudents)
    {
        var result = new StudentImportResultDto
        {
            TotalRows = validStudents.Count
        };

        if (validStudents.Count == 0) return result;

        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();

        try
        {
            string yearPrefix = $"HV-{DateTime.Now.Year}-";
            string? latestCode = await conn.ExecuteScalarAsync<string>(
                "SELECT StudentCode FROM Students WHERE StudentCode LIKE @Pattern ORDER BY StudentId DESC LIMIT 1;",
                new { Pattern = yearPrefix + "%" }, tran);

            int nextNum = 1;
            if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
            {
                string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
                if (int.TryParse(numberPart, out int currentNum))
                {
                    nextNum = currentNum + 1;
                }
            }

            foreach (var s in validStudents)
            {
                string studentCode = $"{yearPrefix}{nextNum:D4}";
                nextNum++;

                string gender = string.Equals(s.Gender?.Trim(), "Nữ", StringComparison.OrdinalIgnoreCase) ? "Nữ" : "Nam";
                string dobStr = s.DateOfBirth?.ToString("yyyy-MM-dd") ?? DateTime.Today.AddYears(-18).ToString("yyyy-MM-dd");

                int studentId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                    VALUES (@Code, @FullName, @Dob, @Gender, @Phone, @Email, @Address, 'Active', CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new
                    {
                        Code = studentCode,
                        FullName = s.FullName.Trim(),
                        Dob = dobStr,
                        Gender = gender,
                        Phone = s.Phone?.Trim() ?? "",
                        Email = s.Email?.Trim() ?? "",
                        Address = s.Address?.Trim() ?? ""
                    }, tran);

                if (!string.IsNullOrWhiteSpace(s.ParentName) || !string.IsNullOrWhiteSpace(s.ParentPhone))
                {
                    string parentCode = $"PH-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}";
                    int parentId = await conn.ExecuteScalarAsync<int>(@"
                        INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                        VALUES (@PCode, @PName, @PPhone, '', CURRENT_TIMESTAMP);
                        SELECT last_insert_rowid();",
                        new
                        {
                            PCode = parentCode,
                            PName = string.IsNullOrWhiteSpace(s.ParentName) ? "Phụ huynh" : s.ParentName.Trim(),
                            PPhone = s.ParentPhone?.Trim() ?? ""
                        }, tran);

                    string rel = NormalizeRelationship(s.ParentRelationship);
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                        VALUES (@StudentId, @ParentId, @Rel, 1);",
                        new { StudentId = studentId, ParentId = parentId, Rel = rel }, tran);
                }

                result.InsertedStudentCodes.Add(studentCode);
                result.SuccessCount++;
            }

            // Ghi AuditLog
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES ('IMPORT_STUDENTS_EXCEL', 'Students', @Count, @Desc, CURRENT_TIMESTAMP);",
                new
                {
                    Count = result.SuccessCount.ToString(),
                    Desc = $"Nhập thành công {result.SuccessCount} học viên mới từ tệp Excel/CSV"
                }, tran);

            tran.Commit();
        }
        catch (Exception ex)
        {
            tran.Rollback();
            result.ErrorCount = validStudents.Count;
            result.SuccessCount = 0;
            result.InsertedStudentCodes.Clear();
            result.ErrorMessages.Add($"Lỗi ghi dữ liệu SQLite: {ex.Message}");
        }

        return result;
    }

    private static string NormalizeRelationship(string? raw)
    {
        if (string.IsNullOrWhiteSpace(raw)) return "Khác";
        if (raw.Contains("Bố", StringComparison.OrdinalIgnoreCase)) return "Bố";
        if (raw.Contains("Mẹ", StringComparison.OrdinalIgnoreCase)) return "Mẹ";
        if (raw.Contains("Giám hộ", StringComparison.OrdinalIgnoreCase)) return "Giám hộ";
        return "Khác";
    }
}
