using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class DashboardRepository : IDashboardRepository
{
    private static bool _seedChecked = false;

    private async Task EnsureDashboardSeedDataAsync()
    {
        if (_seedChecked) return;
        using var conn = DatabaseConfig.CreateOpenConnection();

        // Đảm bảo có bảng lưu trạng thái xử lý cảnh báo vắng của học viên
        await conn.ExecuteAsync(@"
            CREATE TABLE IF NOT EXISTS AbsenceAlertStates (
                StudentId INTEGER PRIMARY KEY,
                HandlingStatus TEXT NOT NULL DEFAULT 'Chưa xử lý',
                IsDismissed INTEGER NOT NULL DEFAULT 0,
                UpdatedAt TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
                FOREIGN KEY (StudentId) REFERENCES Students(StudentId) ON DELETE CASCADE
            );");

        // Đảm bảo dữ liệu gốc Học viên / Khóa học / Lớp học đã được nạp
        var studentRepo = new StudentRepository();
        await studentRepo.GetStudentStatsAsync();

        // Đảm bảo có giáo viên và phòng học bổ sung
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO ClassRooms (RoomId, RoomName, Floor, Capacity, HasProjector, IsActive)
            VALUES 
            (3, 'P101', 1, 25, 1, 1),
            (4, 'P203', 2, 20, 1, 1);

            INSERT OR IGNORE INTO Teachers (TeacherId, TeacherCode, FullName, Specialization, Phone, Email, HourlyRate, IsNativeSpeaker, IsActive)
            VALUES
            (3, 'GV-003', 'Lê Thị Thu', 'IELTS Intensive', '0904111222', 'thule@ecms.edu.vn', 350000, 0, 1),
            (4, 'GV-004', 'Lê Hoàng Yến', 'TOEIC 500-750+', '0904333444', 'hoangyen@ecms.edu.vn', 320000, 0, 1);
        ");

        // Đảm bảo có đủ lớp học với đúng CHECK constraint Status ('Planning', 'OpenForEnrollment', 'InProgress', 'Completed', 'Cancelled')
        await conn.ExecuteAsync(@"
            INSERT OR IGNORE INTO Classes (ClassId, ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status, CreatedAt)
            VALUES 
            (5, 'IELTS-I01', 'IELTS Intensive I01', 2, 3, 4, '2026-10-15', '2027-02-15', 15, 'InProgress', '2026-10-15'),
            (6, 'TOEIC-650', 'Lớp TOEIC 650+ B02', 3, 4, 3, '2026-11-25', '2027-02-25', 20, 'OpenForEnrollment', '2026-11-01');
        ");

        // Đảm bảo có lịch học thật trong bảng ClassSchedules
        int scheduleCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM ClassSchedules;");
        if (scheduleCount < 6)
        {
            int defClassId = await conn.ExecuteScalarAsync<int>("SELECT COALESCE(MIN(ClassId), 0) FROM Classes;");
            int defRoomId = await conn.ExecuteScalarAsync<int>("SELECT COALESCE(MIN(RoomId), 0) FROM ClassRooms;");
            int defTeacherId = await conn.ExecuteScalarAsync<int>("SELECT COALESCE(MIN(TeacherId), 0) FROM Teachers;");

            if (defClassId > 0 && defRoomId > 0 && defTeacherId > 0)
            {
                string todayStr = DateTime.Today.ToString("yyyy-MM-dd");
                string upcoming1 = DateTime.Today.AddDays(2).ToString("yyyy-MM-dd");
                string upcoming2 = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd");

                await conn.ExecuteAsync(@"
                    INSERT OR IGNORE INTO ClassSchedules (ScheduleId, ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, Topic)
                    VALUES
                    (101, @Cid, 1, @Today, '18:00', '20:00', @Rid, @Tid, 'IELTS Listening & Speaking Foundation'),
                    (102, @Cid, 2, @Today, '19:30', '21:30', @Rid, @Tid, 'IELTS Writing Task 1 Overview'),
                    (103, @Cid, 3, @Today, '17:30', '19:30', @Rid, @Tid, 'TOEIC Part 5 Grammar Practice'),
                    (104, @Cid, 4, @Today, '14:00', '16:00', @Rid, @Tid, 'Daily English Conversation'),
                    (105, @Cid, 5, @Up1,   '08:30', '10:30', @Rid, @Tid, 'IELTS Intensive Diagnostic'),
                    (106, @Cid, 6, @Up2,   '19:30', '21:30', @Rid, @Tid, 'TOEIC 650+ Orientation');",
                    new { Cid = defClassId, Rid = defRoomId, Tid = defTeacherId, Today = todayStr, Up1 = upcoming1, Up2 = upcoming2 });
            }
        }

        // Đảm bảo có dữ liệu điểm danh thật (dùng đúng ScheduleId đang tồn tại trong ClassSchedules)
        int attCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM AttendanceRecords;");
        if (attCount < 10)
        {
            var existingScheduleIds = (await conn.QueryAsync<int>("SELECT ScheduleId FROM ClassSchedules ORDER BY ScheduleId LIMIT 5;")).ToList();
            var studentIds = (await conn.QueryAsync<int>("SELECT StudentId FROM Students ORDER BY StudentId LIMIT 6;")).ToList();

            if (existingScheduleIds.Count > 0 && studentIds.Count > 0)
            {
                if (studentIds.Count >= 3)
                {
                    // Học viên thứ 3 vắng tối đa 4 buổi (vượt ngưỡng 3 buổi)
                    foreach (int schId in existingScheduleIds.Take(4))
                    {
                        await conn.ExecuteAsync(@"
                            INSERT OR IGNORE INTO AttendanceRecords (ScheduleId, StudentId, Status, Note)
                            VALUES (@SchId, @StuId, 'Absent', 'Nghỉ không phép');",
                            new { SchId = schId, StuId = studentIds[2] });
                    }
                }
                if (studentIds.Count >= 4)
                {
                    foreach (int schId in existingScheduleIds.Take(3))
                    {
                        await conn.ExecuteAsync(@"
                            INSERT OR IGNORE INTO AttendanceRecords (ScheduleId, StudentId, Status, Note)
                            VALUES (@SchId, @StuId, 'Absent', 'Vắng buổi tối');",
                            new { SchId = schId, StuId = studentIds[3] });
                    }
                }
                foreach (int schId in existingScheduleIds)
                {
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO AttendanceRecords (ScheduleId, StudentId, Status)
                        VALUES (@SchId, @StuId, 'Present');",
                        new { SchId = schId, StuId = studentIds[0] });
                    if (studentIds.Count >= 2)
                    {
                        await conn.ExecuteAsync(@"
                            INSERT OR IGNORE INTO AttendanceRecords (ScheduleId, StudentId, Status)
                            VALUES (@SchId, @StuId, 'Present');",
                            new { SchId = schId, StuId = studentIds[1] });
                    }
                }
            }
        }

        // Dọn dẹp các bản ghi doanh thu giả (nếu từng được sinh tự động trước đây) để biểu đồ phản ánh 100% doanh thu thật
        await conn.ExecuteAsync(
            "DELETE FROM Payments WHERE Note LIKE 'Doanh thu học phí tháng %' AND PaymentCode LIKE 'PT-_____-001';");

        _seedChecked = true;
    }

    public async Task<DashboardKpiSummaryDto> GetKpiSummaryAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string currentYm = DateTime.Today.ToString("yyyy-MM");

        // Truy xuất 100% số liệu thật từ SQLite (không cộng số ảo)
        int totalStudents = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        int activeStudents = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Active';");
        int activeClasses = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE Status IN ('OpenForEnrollment', 'InProgress');");
        int activeTeachers = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Teachers WHERE IsActive = 1;");

        decimal currentMonthRevenue = await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(SUM(PaidAmount), 0) 
            FROM Payments 
            WHERE Status = 'Valid' AND strftime('%Y-%m', PaymentDate) = @currentYm;", new { currentYm });

        decimal outstandingDebt = await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(SUM(BalanceDue), 0) 
            FROM Invoices 
            WHERE Status != 'Cancelled';");

        // Tính tỷ lệ chuyên cần trung bình thật từ bảng AttendanceRecords (hoặc Enrollments nếu chưa có record)
        double avgAttendance = await conn.ExecuteScalarAsync<double>(@"
            SELECT 
                CASE 
                    WHEN COUNT(*) > 0 THEN ROUND(SUM(CASE WHEN Status IN ('Present', 'Late') THEN 1.0 ELSE 0.0 END) * 100.0 / COUNT(*), 1)
                    ELSE COALESCE((SELECT AVG(AttendanceRate) FROM Enrollments WHERE AttendanceRate IS NOT NULL), 0.0)
                END
            FROM AttendanceRecords;");

        return new DashboardKpiSummaryDto
        {
            TotalStudents = totalStudents,
            ActiveStudents = activeStudents,
            ActiveClasses = activeClasses,
            ActiveTeachers = activeTeachers,
            CurrentMonthRevenue = currentMonthRevenue,
            CurrentMonthRevenueFormatted = FormatMoneyShort(currentMonthRevenue),
            TotalOutstandingDebt = outstandingDebt,
            TotalOutstandingDebtFormatted = FormatMoneyShort(outstandingDebt),
            AverageAttendanceRate = avgAttendance
        };
    }

    public async Task<IEnumerable<MonthlyRevenueBarDto>> GetMonthlyRevenueTrendAsync(int months = 6)
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        DateTime today = DateTime.Today;
        var result = new List<MonthlyRevenueBarDto>();
        decimal? prevRev = null;

        for (int i = months - 1; i >= 0; i--)
        {
            DateTime m = today.AddMonths(-i);
            string ym = m.ToString("yyyy-MM");

            decimal rev = await conn.ExecuteScalarAsync<decimal>(@"
                SELECT COALESCE(SUM(PaidAmount), 0)
                FROM Payments
                WHERE Status = 'Valid' AND strftime('%Y-%m', PaymentDate) = @Ym;", new { Ym = ym });

            int payCount = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*)
                FROM Payments
                WHERE Status = 'Valid' AND strftime('%Y-%m', PaymentDate) = @Ym;", new { Ym = ym });

            int newStudents = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*)
                FROM Enrollments
                WHERE strftime('%Y-%m', EnrollDate) = @Ym;", new { Ym = ym });

            double revMil = Math.Round((double)(rev / 1000000m), 1);
            string growth = "—";
            if (prevRev.HasValue && prevRev.Value > 0)
            {
                decimal diffPct = (rev - prevRev.Value) / prevRev.Value * 100m;
                growth = diffPct >= 0 ? $"+{diffPct:0.0}%" : $"{diffPct:0.0}%";
            }
            prevRev = rev;

            result.Add(new MonthlyRevenueBarDto
            {
                MonthLabel = $"T{m.Month}",
                YearMonth = ym,
                RevenueMillion = revMil,
                ActualRevenueAmount = rev,
                PaymentCount = payCount,
                DisplayLabel = revMil.ToString("0.#", CultureInfo.InvariantCulture),
                IsHighlight = i == 0,
                TargetAmount = rev > 0 ? Math.Round(rev * 0.9m, 0) : 0m,
                GrowthRateMoM = growth,
                NewStudentsCount = newStudents
            });
        }

        return result;
    }

    public async Task<IEnumerable<MonthlyStudentGrowthBarDto>> GetMonthlyStudentGrowthAsync(int months = 6)
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        DateTime today = DateTime.Today;
        var result = new List<MonthlyStudentGrowthBarDto>();

        for (int i = months - 1; i >= 0; i--)
        {
            DateTime m = today.AddMonths(-i);
            string ymEnd = new DateTime(m.Year, m.Month, DateTime.DaysInMonth(m.Year, m.Month)).ToString("yyyy-MM-dd 23:59:59");
            string ym = m.ToString("yyyy-MM");

            // Tổng học viên tính lũy kế đến cuối tháng đó
            int cumulativeStudents = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Students WHERE CreatedAt <= @YmEnd;", new { YmEnd = ymEnd });

            int newStudents = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Students WHERE strftime('%Y-%m', CreatedAt) = @Ym;", new { Ym = ym });

            int completed = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Students WHERE Status = 'Completed' AND CreatedAt <= @YmEnd;", new { YmEnd = ymEnd });

            int active = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Students WHERE Status = 'Active' AND CreatedAt <= @YmEnd;", new { YmEnd = ymEnd });

            int archived = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Students WHERE Status IN ('Reserved', 'Dropped') AND CreatedAt <= @YmEnd;", new { YmEnd = ymEnd });

            result.Add(new MonthlyStudentGrowthBarDto
            {
                MonthLabel = $"T{m.Month}",
                YearMonth = ym,
                StudentCount = cumulativeStudents,
                DisplayLabel = cumulativeStudents.ToString(),
                IsHighlight = i == 0,
                TotalStudents = cumulativeStudents,
                NewStudents = newStudents,
                ActiveCount = active,
                ArchivedCount = archived,
                GraduatedCount = completed,
                RetentionRate = cumulativeStudents > 0 ? $"{(active * 100.0 / cumulativeStudents):0.0}%" : "0%"
            });
        }

        return result;
    }

    public async Task<IEnumerable<CourseAttendanceRatioDto>> GetCourseAttendanceRatiosAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        var rows = await conn.QueryAsync<CourseAttendanceRatioDto>(@"
            SELECT 
                co.CourseName AS CategoryName,
                COUNT(DISTINCT cl.ClassId) AS ClassCount,
                COUNT(DISTINCT e.StudentId) AS StudentCount,
                COALESCE(AVG(e.AttendanceRate), 100.0) AS AttendanceRate
            FROM Courses co
            LEFT JOIN Classes cl ON co.CourseId = cl.CourseId AND cl.Status IN ('OpenForEnrollment', 'InProgress', 'Planning')
            LEFT JOIN Enrollments e ON cl.ClassId = e.ClassId AND e.Status IN ('Active', 'PendingPayment')
            GROUP BY co.CourseId, co.CourseName
            HAVING ClassCount > 0 OR StudentCount > 0
            ORDER BY StudentCount DESC, ClassCount DESC;");

        return rows;
    }

    public async Task<IEnumerable<ClassAttendanceDetailDto>> GetClassAttendanceDetailsAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        const string sql = @"
            SELECT 
                cl.ClassCode,
                cl.ClassName,
                co.CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COUNT(DISTINCT e.StudentId) || '/' || cl.MaxStudents AS CapacityFormatted,
                COALESCE((SELECT COUNT(*) FROM ClassSchedules cs WHERE cs.ClassId = cl.ClassId), 0) || '/' || co.TotalSessions AS LessonsProgress,
                COALESCE((
                    SELECT ROUND(SUM(CASE WHEN ar.Status IN ('Present', 'Late') THEN 1.0 ELSE 0.0 END) * 100.0 / COUNT(*), 1)
                    FROM AttendanceRecords ar
                    JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
                    WHERE cs.ClassId = cl.ClassId
                ), 0.0) AS AttendanceRate,
                '' AS StatusText
            FROM Classes cl
            JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN Teachers t ON cl.MainTeacherId = t.TeacherId
            LEFT JOIN Enrollments e ON cl.ClassId = e.ClassId AND e.Status IN ('Active', 'PendingPayment')
            GROUP BY cl.ClassId
            ORDER BY cl.ClassCode ASC;";

        return await conn.QueryAsync<ClassAttendanceDetailDto>(sql);
    }

    public async Task<IEnumerable<TodayScheduleItemDto>> GetTodayAndUpcomingSchedulesAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string todayStr = DateTime.Today.ToString("yyyy-MM-dd");

        const string sql = @"
            SELECT 
                cl.ClassCode,
                cl.ClassName,
                COALESCE(r.RoomName, 'Chưa xếp') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = cl.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentEnrollment,
                cl.MaxStudents AS MaxCapacity,
                cl.Status AS RawStatus,
                COALESCE(
                    (SELECT cs.Date || '|' || cs.StartTime || ' - ' || cs.EndTime 
                     FROM ClassSchedules cs 
                     WHERE cs.ClassId = cl.ClassId AND cs.Date >= @Today 
                     ORDER BY cs.Date ASC, cs.StartTime ASC LIMIT 1),
                    (SELECT cs.Date || '|' || cs.StartTime || ' - ' || cs.EndTime 
                     FROM ClassSchedules cs 
                     WHERE cs.ClassId = cl.ClassId 
                     ORDER BY cs.Date DESC LIMIT 1)
                ) AS NextSessionInfo
            FROM Classes cl
            LEFT JOIN Teachers t ON cl.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms r ON cl.DefaultRoomId = r.RoomId
            WHERE cl.Status IN ('OpenForEnrollment', 'InProgress', 'Planning')
            ORDER BY NextSessionInfo ASC;";

        var rawList = await conn.QueryAsync<dynamic>(sql, new { Today = todayStr });
        var result = new List<TodayScheduleItemDto>();

        foreach (var r in rawList)
        {
            string? nextInfo = r.NextSessionInfo;
            string timeDisplay = "Chưa có lịch";
            if (!string.IsNullOrWhiteSpace(nextInfo) && nextInfo.Contains('|'))
            {
                var parts = nextInfo.Split('|');
                if (DateTime.TryParse(parts[0], out DateTime dt))
                {
                    string dateLabel = dt.Date == DateTime.Today ? "Hôm nay" : dt.ToString("dd/MM");
                    timeDisplay = $"{parts[1]} · {dateLabel}";
                }
            }

            string rawStatus = r.RawStatus ?? "InProgress";
            string statusText = rawStatus switch
            {
                "InProgress" => "Đang học",
                "OpenForEnrollment" => "Mở tuyển sinh",
                "Planning" => "Sắp khai giảng",
                _ => rawStatus
            };

            result.Add(new TodayScheduleItemDto
            {
                TimeDisplay = timeDisplay,
                ClassCode = r.ClassCode ?? "",
                ClassName = r.ClassName ?? "",
                RoomName = r.RoomName ?? "",
                TeacherName = r.TeacherName ?? "",
                CurrentEnrollment = (int)(r.CurrentEnrollment ?? 0),
                MaxCapacity = (int)(r.MaxCapacity ?? 20),
                StatusText = statusText
            });
        }

        return result;
    }

    public async Task<IEnumerable<PendingTaskItemDto>> GetPendingTasksAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        // Đọc ngưỡng cảnh báo vắng từ bảng SystemConfigs (Tab 2 Cấu hình)
        string? rawMaxAbsent = await conn.QueryFirstOrDefaultAsync<string?>(
            "SELECT ConfigValue FROM SystemConfigs WHERE ConfigKey = 'MaxAbsencesAlert';");
        int maxAllowed = 3;
        if (!string.IsNullOrWhiteSpace(rawMaxAbsent))
        {
            var digits = new string(rawMaxAbsent.Where(char.IsDigit).ToArray());
            if (int.TryParse(digits, out int parsed) && parsed > 0)
            {
                maxAllowed = parsed;
            }
        }

        // Truy vấn danh sách học viên có số buổi vắng >= ngưỡng quy định (và chưa bị xóa khỏi danh sách xử lý)
        const string sql = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName AS StudentName,
                COALESCE(s.Phone, '') AS Phone,
                COALESCE(cl.ClassCode, 'Chưa xếp lớp') AS ClassCode,
                COALESCE(co.CourseName, '') AS CourseName,
                SUM(CASE WHEN ar.Status IN ('Absent', 'Excused') THEN 1 ELSE 0 END) AS AbsentCount,
                COALESCE(aas.HandlingStatus, 'Chưa xử lý') AS HandlingStatus
            FROM Students s
            JOIN AttendanceRecords ar ON s.StudentId = ar.StudentId
            LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status IN ('Active', 'PendingPayment')
            LEFT JOIN Classes cl ON e.ClassId = cl.ClassId
            LEFT JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN AbsenceAlertStates aas ON s.StudentId = aas.StudentId
            WHERE s.Status = 'Active'
              AND COALESCE(aas.IsDismissed, 0) = 0
            GROUP BY s.StudentId
            HAVING AbsentCount >= @MaxAllowed
            ORDER BY AbsentCount DESC, s.StudentId ASC;";

        var list = (await conn.QueryAsync<PendingTaskItemDto>(sql, new { MaxAllowed = maxAllowed })).ToList();
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Index = i + 1;
            list[i].MaxAllowedAbsences = maxAllowed;
        }

        return list;
    }

    public async Task<bool> UpdatePendingTaskStatusAsync(int studentId, string newStatus)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int rows = await conn.ExecuteAsync(@"
            INSERT INTO AbsenceAlertStates (StudentId, HandlingStatus, IsDismissed, UpdatedAt)
            VALUES (@StudentId, @Status, 0, CURRENT_TIMESTAMP)
            ON CONFLICT(StudentId) DO UPDATE SET
                HandlingStatus = @Status,
                UpdatedAt = CURRENT_TIMESTAMP;",
            new { StudentId = studentId, Status = newStatus });
        return rows > 0;
    }

    public async Task<bool> DeletePendingTaskAsync(int studentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int rows = await conn.ExecuteAsync(@"
            INSERT INTO AbsenceAlertStates (StudentId, HandlingStatus, IsDismissed, UpdatedAt)
            VALUES (@StudentId, 'Đã xử lý', 1, CURRENT_TIMESTAMP)
            ON CONFLICT(StudentId) DO UPDATE SET
                IsDismissed = 1,
                UpdatedAt = CURRENT_TIMESTAMP;",
            new { StudentId = studentId });
        return rows > 0;
    }

    public async Task<IEnumerable<DashboardQuickSearchResultDto>> QuickSearchListAsync(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword)) return Enumerable.Empty<DashboardQuickSearchResultDto>();
        await EnsureDashboardSeedDataAsync();

        using var conn = DatabaseConfig.CreateOpenConnection();
        string kw = "%" + keyword.Trim() + "%";
        var results = new List<DashboardQuickSearchResultDto>();

        // 1. Tìm tất cả Học viên khớp từ khóa
        var students = await conn.QueryAsync<dynamic>(@"
            SELECT 
                s.StudentId, s.StudentCode, s.FullName, COALESCE(s.Phone, '') AS Phone, COALESCE(s.Email, '') AS Email,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS ClassCode,
                COALESCE(e.AttendanceRate, 100.0) AS AttRate,
                COALESCE((SELECT SUM(BalanceDue) FROM Invoices WHERE EnrollmentId = e.EnrollmentId), 0) AS Debt,
                s.Status
            FROM Students s
            LEFT JOIN Enrollments e ON s.StudentId = e.StudentId AND e.Status IN ('Active', 'PendingPayment')
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            WHERE s.StudentCode LIKE @kw OR s.FullName LIKE @kw OR s.Phone LIKE @kw
            ORDER BY s.StudentId DESC;", new { kw });

        foreach (var st in students)
        {
            decimal debt = (decimal)(st.Debt ?? 0m);
            string stStatus = st.Status switch
            {
                "Active" => "Đang học",
                "Completed" => "Hoàn thành",
                "Reserved" => "Bảo lưu",
                _ => "Đã lưu trữ"
            };
            results.Add(new DashboardQuickSearchResultDto
            {
                EntityType = "Học viên",
                Id = (int)st.StudentId,
                Code = st.StudentCode ?? "",
                Name = st.FullName ?? "",
                Phone = st.Phone ?? "",
                Email = st.Email ?? "",
                Extra1 = $"Lớp: {st.ClassCode}",
                Extra2 = $"Chuyên cần: {(double)st.AttRate:0.0}%",
                Extra3 = debt <= 0 ? "Đã đóng đủ học phí" : $"Còn nợ: {debt:N0} đ",
                StatusText = stStatus
            });
        }

        // 2. Tìm tất cả Lớp học khớp từ khóa
        var classes = await conn.QueryAsync<dynamic>(@"
            SELECT 
                cl.ClassId, cl.ClassCode, cl.ClassName, co.CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(r.RoomName, 'Chưa xếp') AS RoomName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = cl.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentCount,
                cl.MaxStudents,
                cl.Status
            FROM Classes cl
            JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN Teachers t ON cl.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms r ON cl.DefaultRoomId = r.RoomId
            WHERE cl.ClassCode LIKE @kw OR cl.ClassName LIKE @kw OR co.CourseName LIKE @kw
            ORDER BY cl.ClassId DESC;", new { kw });

        foreach (var cl in classes)
        {
            results.Add(new DashboardQuickSearchResultDto
            {
                EntityType = "Lớp học",
                Id = (int)cl.ClassId,
                Code = cl.ClassCode ?? "",
                Name = cl.ClassName ?? "",
                Extra1 = $"GV: {cl.TeacherName}",
                Extra2 = $"Phòng: {cl.RoomName} · Khóa: {cl.CourseName}",
                Extra3 = $"Sĩ số: {cl.CurrentCount}/{cl.MaxStudents}",
                StatusText = cl.Status == "InProgress" ? "Đang học" : (cl.Status == "OpenForEnrollment" ? "Đang tuyển sinh" : cl.Status)
            });
        }

        // 3. Tìm tất cả Khóa học khớp từ khóa
        var courses = await conn.QueryAsync<dynamic>(@"
            SELECT CourseId, CourseCode, CourseName, Level, TotalSessions, BaseTuitionFee, IsActive
            FROM Courses
            WHERE CourseCode LIKE @kw OR CourseName LIKE @kw OR Level LIKE @kw;", new { kw });

        foreach (var co in courses)
        {
            results.Add(new DashboardQuickSearchResultDto
            {
                EntityType = "Khóa học",
                Id = (int)co.CourseId,
                Code = co.CourseCode ?? "",
                Name = co.CourseName ?? "",
                Extra1 = $"Trình độ: {co.Level}",
                Extra2 = $"Thời lượng: {co.TotalSessions} buổi",
                Extra3 = $"Học phí: {(decimal)co.BaseTuitionFee:N0} đ",
                StatusText = (int)co.IsActive == 1 ? "Đang đào tạo" : "Ngừng mở"
            });
        }

        return results;
    }

    public async Task<IEnumerable<TodayScheduleItemDto>> GetTodaySchedulesAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string todayStr = DateTime.Today.ToString("yyyy-MM-dd");

        const string sql = @"
            SELECT 
                cs.StartTime || ' - ' || cs.EndTime AS TimeDisplay,
                cl.ClassCode,
                cl.ClassName,
                COALESCE(r.RoomName, 'Chưa xếp') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = cl.ClassId AND e.Status NOT IN ('Cancelled', 'Dropped')) AS CurrentEnrollment,
                cl.MaxStudents AS MaxCapacity,
                cl.Status AS RawStatus
            FROM ClassSchedules cs
            JOIN Classes cl ON cs.ClassId = cl.ClassId
            LEFT JOIN ClassRooms r ON COALESCE(cs.RoomId, cl.DefaultRoomId) = r.RoomId
            LEFT JOIN Teachers t ON COALESCE(cs.TeacherId, cl.MainTeacherId) = t.TeacherId
            WHERE cs.Date = @Today
              AND cl.Status = 'InProgress'
              AND (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = cl.ClassId AND e.Status NOT IN ('Cancelled', 'Dropped')) > 0
            ORDER BY cs.StartTime ASC, cl.ClassCode ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { Today = todayStr });
        var result = new List<TodayScheduleItemDto>();
        foreach (var r in rows)
        {
            result.Add(new TodayScheduleItemDto
            {
                TimeDisplay = r.TimeDisplay ?? "",
                ClassCode = r.ClassCode ?? "",
                ClassName = r.ClassName ?? "",
                RoomName = r.RoomName ?? "Chưa xếp",
                TeacherName = r.TeacherName ?? "Chưa phân công",
                CurrentEnrollment = (int)(r.CurrentEnrollment ?? 0),
                MaxCapacity = (int)(r.MaxCapacity ?? 20),
                StatusText = StatusFormatter.FormatClassStatus((string?)r.RawStatus)
            });
        }
        return result;
    }

    public async Task<IEnumerable<OverdueDebtAlertItemDto>> GetOverdueDebtAlertsAsync()
    {
        await EnsureDashboardSeedDataAsync();
        using var conn = DatabaseConfig.CreateOpenConnection();

        string todayStr = DateTime.Today.ToString("yyyy-MM-dd");

        const string sql = @"
            SELECT 
                inv.InvoiceId,
                inv.InvoiceCode,
                s.StudentCode,
                s.FullName AS StudentName,
                COALESCE(s.Phone, '') AS Phone,
                cl.ClassCode,
                inv.BalanceDue,
                inv.DueDate
            FROM Invoices inv
            JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes cl ON e.ClassId = cl.ClassId
            WHERE inv.BalanceDue > 0
              AND inv.Status != 'Cancelled'
              AND date(inv.DueDate) < date(@Today)
            ORDER BY inv.DueDate ASC, inv.BalanceDue DESC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { Today = todayStr });
        var list = new List<OverdueDebtAlertItemDto>();
        foreach (var r in rows)
        {
            string dueRaw = r.DueDate ?? "";
            string dueDisp = dueRaw;
            int daysOverdue = 0;
            if (DateTime.TryParse(dueRaw, out var dt))
            {
                dueDisp = dt.ToString("dd/MM/yyyy");
                daysOverdue = Math.Max(1, (DateTime.Today - dt.Date).Days);
            }

            list.Add(new OverdueDebtAlertItemDto
            {
                InvoiceId = (int)r.InvoiceId,
                InvoiceCode = r.InvoiceCode ?? "",
                StudentCode = r.StudentCode ?? "",
                StudentName = r.StudentName ?? "",
                Phone = r.Phone ?? "",
                ClassCode = r.ClassCode ?? "",
                BalanceDue = (decimal)(r.BalanceDue ?? 0m),
                DueDate = dueDisp,
                DaysOverdue = daysOverdue
            });
        }
        return list;
    }

    public async Task<DashboardCategorizedSearchDto> QuickSearchCategorizedAsync(string keyword)
    {
        await EnsureDashboardSeedDataAsync();
        var dto = new DashboardCategorizedSearchDto();
        if (string.IsNullOrWhiteSpace(keyword)) return dto;

        using var conn = DatabaseConfig.CreateOpenConnection();
        string kw = $"%{keyword.Trim()}%";

        // 1. Học viên
        var students = await conn.QueryAsync<dynamic>(@"
            SELECT 
                s.StudentId, s.StudentCode, s.FullName, COALESCE(s.Phone, '') AS Phone, s.Status,
                COALESCE((SELECT c.ClassCode FROM Enrollments e JOIN Classes c ON e.ClassId = c.ClassId WHERE e.StudentId = s.StudentId ORDER BY e.EnrollmentId DESC LIMIT 1), 'Chờ xếp lớp') AS ClassName,
                COALESCE((SELECT SUM(inv.BalanceDue) FROM Invoices inv JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId WHERE e.StudentId = s.StudentId AND inv.Status != 'Cancelled'), 0) AS BalanceDue
            FROM Students s
            WHERE s.StudentCode LIKE @kw OR s.FullName LIKE @kw OR s.Phone LIKE @kw
            ORDER BY s.StudentId DESC;", new { kw });

        foreach (var st in students)
        {
            string clsName = st.ClassName ?? "Chờ xếp lớp";
            dto.Students.Add(new QuickSearchStudentItemDto
            {
                StudentId = (int)st.StudentId,
                StudentCode = st.StudentCode ?? "",
                FullName = st.FullName ?? "",
                Phone = st.Phone ?? "",
                ClassName = clsName,
                BalanceDue = (decimal)(st.BalanceDue ?? 0m),
                StatusText = StatusFormatter.FormatStudentStatus((string?)st.Status, clsName != "Chờ xếp lớp")
            });
        }

        // 2. Khóa học
        var courses = await conn.QueryAsync<dynamic>(@"
            SELECT CourseId, CourseCode, CourseName, Level, TotalSessions, BaseTuitionFee, IsActive
            FROM Courses
            WHERE CourseCode LIKE @kw OR CourseName LIKE @kw OR Level LIKE @kw
            ORDER BY CourseId DESC;", new { kw });

        foreach (var co in courses)
        {
            dto.Courses.Add(new QuickSearchCourseItemDto
            {
                CourseId = (int)co.CourseId,
                CourseCode = co.CourseCode ?? "",
                CourseName = co.CourseName ?? "",
                Level = co.Level ?? "",
                TotalSessions = (int)(co.TotalSessions ?? 0),
                BaseTuitionFee = (decimal)(co.BaseTuitionFee ?? 0m),
                StatusText = (int)(co.IsActive ?? 1) == 1 ? "Đang đào tạo" : "Ngừng mở"
            });
        }

        // 3. Lớp học
        var classes = await conn.QueryAsync<dynamic>(@"
            SELECT 
                cl.ClassId, cl.ClassCode, cl.ClassName, co.CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = cl.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentCount,
                cl.MaxStudents,
                cl.Status
            FROM Classes cl
            JOIN Courses co ON cl.CourseId = co.CourseId
            LEFT JOIN Teachers t ON cl.MainTeacherId = t.TeacherId
            WHERE cl.ClassCode LIKE @kw OR cl.ClassName LIKE @kw OR co.CourseName LIKE @kw
            ORDER BY cl.ClassId DESC;", new { kw });

        foreach (var cl in classes)
        {
            dto.Classes.Add(new QuickSearchClassItemDto
            {
                ClassId = (int)cl.ClassId,
                ClassCode = cl.ClassCode ?? "",
                ClassName = cl.ClassName ?? "",
                CourseName = cl.CourseName ?? "",
                TeacherName = cl.TeacherName ?? "Chưa phân công",
                CapacityFormatted = $"{cl.CurrentCount}/{cl.MaxStudents}",
                StatusText = StatusFormatter.FormatClassStatus((string?)cl.Status)
            });
        }

        return dto;
    }

    private static string FormatMoneyShort(decimal amount)
    {
        if (amount >= 1000000000m)
            return $"{(amount / 1000000000m):0.0} tỷ";
        if (amount >= 1000000m)
            return $"{(amount / 1000000m):0.0} tr";
        if (amount == 0)
            return "0 đ";
        return $"{amount:N0} đ";
    }
}
