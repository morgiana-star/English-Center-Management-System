using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Core.Helpers;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class ClassRepository : IClassRepository
{
    public async Task<IEnumerable<ClassListItemDto>> GetAllClassesAsync(string? keyword = null, string? courseName = null, string? status = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                co.CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentStudents,
                c.MaxStudents,
                c.Status AS RawStatus
            FROM Classes c
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
            WHERE (@Keyword IS NULL OR c.ClassCode LIKE @Kw OR c.ClassName LIKE @Kw OR co.CourseName LIKE @Kw OR COALESCE(t.FullName, '') LIKE @Kw)
              AND (@CourseName IS NULL OR co.CourseName LIKE @CourseName)
            ORDER BY c.ClassId DESC;";

        var rows = (await conn.QueryAsync<dynamic>(sql, new
        {
            Keyword = string.IsNullOrWhiteSpace(keyword) ? null : keyword,
            Kw = $"%{keyword}%",
            CourseName = (courseName == "Tất cả khóa học" || string.IsNullOrWhiteSpace(courseName)) ? null : $"%{courseName}%"
        })).ToList();

        var scheduleRows = (await conn.QueryAsync<(int ClassId, string Date, string StartTime, string EndTime)>(
            "SELECT ClassId, Date, StartTime, EndTime FROM ClassSchedules ORDER BY Date ASC;")).ToList();

        var schedulesByClass = scheduleRows
            .GroupBy(s => s.ClassId)
            .ToDictionary(g => g.Key, g => FormatClassScheduleSummary(g.ToList()));

        var result = new List<ClassListItemDto>();
        foreach (var r in rows)
        {
            int cid = (int)r.ClassId;
            string formattedStatus = StatusFormatter.FormatClassStatus((string?)r.RawStatus);
            if (!string.IsNullOrWhiteSpace(status) && status != "Tất cả trạng thái" &&
                !formattedStatus.Equals(status, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            result.Add(new ClassListItemDto
            {
                ClassId = cid,
                ClassCode = r.ClassCode ?? "",
                ClassName = r.ClassName ?? "",
                CourseName = r.CourseName ?? "",
                TeacherName = r.TeacherName ?? "Chưa phân công",
                RoomName = r.RoomName ?? "Chưa xếp phòng",
                ScheduleInfo = schedulesByClass.TryGetValue(cid, out var sch) ? sch : "Chưa xếp lịch",
                CurrentStudents = (int)(r.CurrentStudents ?? 0),
                MaxStudents = (int)(r.MaxStudents ?? 20),
                Status = formattedStatus
            });
        }

        return result;
    }

    private static string FormatClassScheduleSummary(List<(int ClassId, string Date, string StartTime, string EndTime)> items)
    {
        if (items.Count == 0) return "Chưa xếp lịch";
        var dayOrder = new List<int>();
        foreach (var item in items)
        {
            if (DateTime.TryParse(item.Date, out var dt))
            {
                int dow = dt.DayOfWeek == DayOfWeek.Sunday ? 8 : ((int)dt.DayOfWeek + 1);
                if (!dayOrder.Contains(dow)) dayOrder.Add(dow);
            }
        }
        dayOrder.Sort();
        string daysText = dayOrder.Count > 0
            ? string.Join(", ", dayOrder.Select(d => d == 8 ? "CN" : $"T{d}"))
            : "Theo lịch";
        var first = items[0];
        return $"{daysText} ({first.StartTime} - {first.EndTime})";
    }

    public async Task<Class?> GetClassByIdAsync(int id)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Class>(
            "SELECT * FROM Classes WHERE ClassId = @Id;", new { Id = id });
    }

    public async Task<Class?> GetClassByCodeAsync(string classCode)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Class>(
            "SELECT * FROM Classes WHERE UPPER(TRIM(ClassCode)) = UPPER(TRIM(@Code)) LIMIT 1;",
            new { Code = classCode });
    }

    public async Task<bool> AddClassAsync(Class c)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            INSERT INTO Classes (ClassCode, ClassName, CourseId, MainTeacherId, DefaultRoomId, StartDate, EndDate, MaxStudents, Status)
            VALUES (@ClassCode, @ClassName, @CourseId, @MainTeacherId, @DefaultRoomId, @StartDate, @EndDate, @MaxStudents, @Status);";

        int rows = await conn.ExecuteAsync(sql, new
        {
            c.ClassCode,
            c.ClassName,
            c.CourseId,
            c.MainTeacherId,
            c.DefaultRoomId,
            StartDate = c.StartDate.ToString("yyyy-MM-dd"),
            EndDate = c.EndDate.ToString("yyyy-MM-dd"),
            c.MaxStudents,
            Status = c.Status.ToString()
        });
        return rows > 0;
    }

    public async Task<(bool Success, string Message)> DeleteClassAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();

        int enrollCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Enrollments WHERE ClassId = @Id;", new { Id = classId });
        if (enrollCnt > 0)
            return (false, $"Không thể xóa lớp học đang có {enrollCnt} hồ sơ ghi danh học viên. Vui lòng chuyển trạng thái sang Đã hủy hoặc Đã kết thúc.");

        int attCnt = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM AttendanceRecords ar
            INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE cs.ClassId = @Id;", new { Id = classId });
        if (attCnt > 0)
            return (false, "Không thể xóa lớp học đã phát sinh dữ liệu điểm danh.");

        int examCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Exams WHERE ClassId = @Id;", new { Id = classId });
        if (examCnt > 0)
            return (false, "Không thể xóa lớp học đã có kỳ thi / bảng điểm.");

        using var tran = conn.BeginTransaction();
        try
        {
            await conn.ExecuteAsync("DELETE FROM ClassSchedules WHERE ClassId = @Id;", new { Id = classId }, tran);
            int rows = await conn.ExecuteAsync("DELETE FROM Classes WHERE ClassId = @Id;", new { Id = classId }, tran);
            tran.Commit();
            return rows > 0
                ? (true, "Đã xóa lớp học thành công.")
                : (false, "Không tìm thấy lớp học cần xóa.");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi xóa lớp học: " + ex.Message);
        }
    }

    public async Task<IEnumerable<ClassStudentItemDto>> GetClassStudentsAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                COALESCE(s.Phone, '') AS Phone,
                e.Status AS EnrollStatus,
                COALESCE((SELECT SUM(inv.BalanceDue) FROM Invoices inv WHERE inv.EnrollmentId = e.EnrollmentId AND inv.Status != 'Cancelled'), 0) AS BalanceDue,
                (SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = s.StudentId AND cs.ClassId = e.ClassId) AS TotalAtt,
                (SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = s.StudentId AND cs.ClassId = e.ClassId AND ar.Status IN ('Present', 'Late')) AS PresentAtt
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            WHERE e.ClassId = @ClassId
            ORDER BY s.StudentCode ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { ClassId = classId });
        var list = new List<ClassStudentItemDto>();
        foreach (var r in rows)
        {
            string st = (string)(r.EnrollStatus ?? "Active");
            string statusVi = st switch
            {
                "PendingPayment" => "Chờ đóng phí",
                "Reserved" => "Bảo lưu",
                "Dropped" => "Đã nghỉ",
                "Completed" => "Hoàn thành",
                _ => "Đang học"
            };
            int tot = (int)(r.TotalAtt ?? 0);
            int pres = (int)(r.PresentAtt ?? 0);
            decimal bal = (decimal)(r.BalanceDue ?? 0m);

            list.Add(new ClassStudentItemDto
            {
                StudentId = (int)r.StudentId,
                StudentCode = r.StudentCode ?? "",
                FullName = r.FullName ?? "",
                Phone = r.Phone ?? "",
                StatusDisplay = statusVi,
                AttendanceDisplay = tot > 0 ? $"{Math.Round(pres * 100.0 / tot, 1):F1}% ({pres}/{tot})" : "Chưa có",
                TuitionDisplay = bal > 0 ? $"Còn nợ {bal:N0} đ" : "Đã hoàn thành"
            });
        }
        return list;
    }

    public async Task<IEnumerable<ClassScheduleItemDto>> GetClassSchedulesAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT
                cs.ScheduleId,
                cs.SessionNumber,
                cs.Date,
                cs.StartTime,
                cs.EndTime,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName
            FROM ClassSchedules cs
            LEFT JOIN ClassRooms r ON cs.RoomId = r.RoomId
            LEFT JOIN Teachers t ON cs.TeacherId = t.TeacherId
            WHERE cs.ClassId = @ClassId
            ORDER BY cs.Date ASC, cs.StartTime ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { ClassId = classId });
        var list = new List<ClassScheduleItemDto>();
        int idx = 1;
        foreach (var r in rows)
        {
            string rawDate = r.Date ?? "";
            string dateDisplay = DateTime.TryParse(rawDate, out var dt) ? dt.ToString("dd/MM/yyyy") : rawDate;
            int sessionNo = (int)(r.SessionNumber ?? idx);
            list.Add(new ClassScheduleItemDto
            {
                ScheduleId = (int)r.ScheduleId,
                SessionNumber = sessionNo > 0 ? sessionNo : idx,
                DateDisplay = dateDisplay,
                TimeRange = $"{r.StartTime} - {r.EndTime}",
                RoomName = r.RoomName ?? "",
                TeacherName = r.TeacherName ?? ""
            });
            idx++;
        }
        return list;
    }

    public async Task<IEnumerable<ClassAttendanceSummaryDto>> GetClassAttendanceSummaryAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                COALESCE((SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = s.StudentId AND cs.ClassId = e.ClassId AND ar.Status = 'Present'), 0) AS PresentCount,
                COALESCE((SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = s.StudentId AND cs.ClassId = e.ClassId AND ar.Status = 'Late'), 0) AS LateCount,
                COALESCE((SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = s.StudentId AND cs.ClassId = e.ClassId AND ar.Status IN ('Absent', 'Excused')), 0) AS AbsentCount
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            WHERE e.ClassId = @ClassId
            ORDER BY s.StudentCode ASC;";

        var rows = await conn.QueryAsync<ClassAttendanceSummaryDto>(sql, new { ClassId = classId });
        var list = rows.ToList();
        foreach (var item in list)
        {
            item.TotalRecorded = item.PresentCount + item.LateCount + item.AbsentCount;
        }
        return list;
    }

    public async Task<IEnumerable<ClassGradeItemDto>> GetClassGradesAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Regular' LIMIT 1) AS RegularVal,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Midterm' LIMIT 1) AS MidtermVal,
                (SELECT es.ScoreValue FROM ExamScores es INNER JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = s.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Final' LIMIT 1) AS FinalVal
            FROM Enrollments e
            INNER JOIN Students s ON e.StudentId = s.StudentId
            WHERE e.ClassId = @ClassId
            ORDER BY s.StudentCode ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { ClassId = classId });
        var list = new List<ClassGradeItemDto>();
        foreach (var r in rows)
        {
            double? reg = r.RegularVal != null ? Convert.ToDouble(r.RegularVal) : null;
            double? mid = r.MidtermVal != null ? Convert.ToDouble(r.MidtermVal) : null;
            double? fin = r.FinalVal != null ? Convert.ToDouble(r.FinalVal) : null;

            var available = new List<double>();
            if (reg.HasValue) available.Add(reg.Value);
            if (mid.HasValue) available.Add(mid.Value);
            if (fin.HasValue) available.Add(fin.Value);

            string avgStr = available.Count > 0 ? $"{available.Average():0.0}" : "-";

            list.Add(new ClassGradeItemDto
            {
                StudentId = (int)r.StudentId,
                StudentCode = r.StudentCode ?? "",
                FullName = r.FullName ?? "",
                RegularScore = reg.HasValue ? $"{reg.Value:0.0}" : "-",
                MidtermScore = mid.HasValue ? $"{mid.Value:0.0}" : "-",
                FinalScore = fin.HasValue ? $"{fin.Value:0.0}" : "-",
                AverageScore = avgStr
            });
        }
        return list;
    }

    public async Task<IEnumerable<WaitingStudentItemDto>> GetWaitingStudentsForClassAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        const string sql = @"
            SELECT
                s.StudentId,
                s.StudentCode,
                s.FullName,
                COALESCE(s.Phone, '') AS Phone,
                COALESCE(s.Email, '') AS Email,
                'Chờ xếp lớp' AS StatusDisplay
            FROM Students s
            WHERE s.Status = 'Active'
              AND NOT EXISTS (
                  SELECT 1 FROM Enrollments e
                  WHERE e.StudentId = s.StudentId
                    AND e.Status IN ('Active', 'PendingPayment')
              )
            ORDER BY s.StudentId DESC;";

        return await conn.QueryAsync<WaitingStudentItemDto>(sql);
    }

    public async Task<(bool Success, string Message)> EnrollWaitingStudentsToClassAsync(int classId, List<int> studentIds)
    {
        if (studentIds == null || studentIds.Count == 0)
            return (false, "Chưa chọn học viên nào để thêm vào lớp.");

        using var conn = DatabaseConfig.CreateOpenConnection();
        var clsInfo = await conn.QuerySingleOrDefaultAsync<(int ClassId, string ClassCode, int MaxStudents, decimal BaseTuitionFee, int CurrentStudents)?>(@"
            SELECT
                c.ClassId,
                c.ClassCode,
                c.MaxStudents,
                co.BaseTuitionFee,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentStudents
            FROM Classes c
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            WHERE c.ClassId = @ClassId;", new { ClassId = classId });

        if (!clsInfo.HasValue)
            return (false, "Không tìm thấy thông tin lớp học.");

        int remainingSlots = clsInfo.Value.MaxStudents - clsInfo.Value.CurrentStudents;
        if (studentIds.Count > remainingSlots)
            return (false, $"Lớp {clsInfo.Value.ClassCode} chỉ còn {Math.Max(0, remainingSlots)} chỗ trống (đang chọn {studentIds.Count} học viên).");

        using var tran = conn.BeginTransaction();
        try
        {
            int added = 0;
            string todayPrefix = $"INV-{DateTime.Now:yyyyMMdd}-";
            int seq = await conn.ExecuteScalarAsync<int>(
                "SELECT COUNT(*) FROM Invoices WHERE InvoiceCode LIKE @P;", new { P = todayPrefix + "%" }, tran);

            foreach (int stId in studentIds.Distinct())
            {
                int exists = await conn.ExecuteScalarAsync<int>(
                    "SELECT COUNT(*) FROM Enrollments WHERE StudentId = @StId AND ClassId = @ClassId AND Status IN ('Active', 'PendingPayment');",
                    new { StId = stId, ClassId = classId }, tran);
                if (exists > 0) continue;

                int enrollmentId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Enrollments (StudentId, ClassId, EnrollDate, Status, AttendanceRate, CreatedAt)
                    VALUES (@StId, @ClassId, CURRENT_TIMESTAMP, 'PendingPayment', NULL, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();", new { StId = stId, ClassId = classId }, tran);

                seq++;
                string invCode = $"{todayPrefix}{seq:D3}-{stId}";
                await conn.ExecuteAsync(@"
                    INSERT INTO Invoices (InvoiceCode, EnrollmentId, OriginalAmount, DiscountAmount, FinalAmount, BalanceDue, DueDate, Status, CreatedAt)
                    VALUES (@InvCode, @EnrollmentId, @Fee, 0, @Fee, @Fee, @DueDate, 'Unpaid', CURRENT_TIMESTAMP);",
                    new
                    {
                        InvCode = invCode,
                        EnrollmentId = enrollmentId,
                        Fee = clsInfo.Value.BaseTuitionFee,
                        DueDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd")
                    }, tran);

                added++;
            }

            tran.Commit();
            return (true, $"Đã thêm {added} học viên chờ xếp lớp vào lớp {clsInfo.Value.ClassCode} thành công.");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi khi thêm học viên vào lớp: " + ex.Message);
        }
    }

    public async Task<IEnumerable<dynamic>> GetLookupDataAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync("SELECT CourseId, CourseName FROM Courses WHERE IsActive = 1;");
    }

    public async Task<IEnumerable<ClassRoom>> GetAllRoomsAsync(string? keyword = null, string? status = null, string? capacityFilter = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT
                RoomId,
                RoomName,
                Floor,
                Capacity,
                HasProjector,
                IsActive,
                COALESCE(Equipment, CASE WHEN HasProjector = 1 THEN 'Máy chiếu, Bảng từ, Điều hòa' ELSE 'Bảng từ, Điều hòa' END) AS Equipment,
                COALESCE(NULLIF(RoomStatus, ''), CASE WHEN IsActive = 1 THEN 'Đang sử dụng' ELSE 'Ngừng sử dụng' END) AS RoomStatus
            FROM ClassRooms
            WHERE (@Kw IS NULL OR RoomName LIKE @Kw OR COALESCE(Equipment, '') LIKE @Kw)
              AND (@Status IS NULL OR COALESCE(NULLIF(RoomStatus, ''), CASE WHEN IsActive = 1 THEN 'Đang sử dụng' ELSE 'Ngừng sử dụng' END) = @Status)
              AND (
                    @Cap IS NULL
                    OR (@Cap = 'Dưới 20 chỗ' AND Capacity < 20)
                    OR (@Cap = '20 – 30 chỗ' AND Capacity BETWEEN 20 AND 30)
                    OR (@Cap = 'Trên 30 chỗ' AND Capacity > 30)
                  )
            ORDER BY RoomName ASC;";

        return await conn.QueryAsync<ClassRoom>(sql, new
        {
            Kw = string.IsNullOrWhiteSpace(keyword) ? null : $"%{keyword.Trim()}%",
            Status = string.IsNullOrWhiteSpace(status) || status == "Tất cả trạng thái" ? null : status,
            Cap = string.IsNullOrWhiteSpace(capacityFilter) || capacityFilter == "Tất cả sức chứa" ? null : capacityFilter
        });
    }

    public async Task<(bool Success, string Message)> CreateRoomAsync(ClassRoom room)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int dup = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ClassRooms WHERE LOWER(TRIM(RoomName)) = LOWER(TRIM(@Name));",
            new { Name = room.RoomName });
        if (dup > 0)
            return (false, $"Phòng học '{room.RoomName.Trim()}' đã tồn tại.");

        string status = string.IsNullOrWhiteSpace(room.RoomStatus) ? "Đang sử dụng" : room.RoomStatus.Trim();
        int isActive = status == "Đang sử dụng" ? 1 : 0;
        int hasProjector = (room.Equipment?.Contains("Máy chiếu", StringComparison.OrdinalIgnoreCase) ?? false) ? 1 : (room.HasProjector ? 1 : 0);

        await conn.ExecuteAsync(@"
            INSERT INTO ClassRooms (RoomName, Floor, Capacity, HasProjector, IsActive, Equipment, RoomStatus, CreatedAt)
            VALUES (@RoomName, @Floor, @Capacity, @HasProjector, @IsActive, @Equipment, @RoomStatus, CURRENT_TIMESTAMP);",
            new
            {
                RoomName = room.RoomName.Trim(),
                Floor = Math.Max(1, room.Floor),
                Capacity = Math.Max(1, room.Capacity),
                HasProjector = hasProjector,
                IsActive = isActive,
                Equipment = room.Equipment?.Trim() ?? string.Empty,
                RoomStatus = status
            });

        return (true, $"Đã thêm phòng học '{room.RoomName.Trim()}' thành công.");
    }

    public async Task<(bool Success, string Message)> UpdateRoomAsync(ClassRoom room)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int dup = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ClassRooms WHERE LOWER(TRIM(RoomName)) = LOWER(TRIM(@Name)) AND RoomId != @Id;",
            new { Name = room.RoomName, Id = room.RoomId });
        if (dup > 0)
            return (false, $"Tên phòng '{room.RoomName.Trim()}' đã được sử dụng cho phòng khác.");

        string status = string.IsNullOrWhiteSpace(room.RoomStatus) ? "Đang sử dụng" : room.RoomStatus.Trim();
        int isActive = status == "Đang sử dụng" ? 1 : 0;
        int hasProjector = (room.Equipment?.Contains("Máy chiếu", StringComparison.OrdinalIgnoreCase) ?? false) ? 1 : (room.HasProjector ? 1 : 0);

        int rows = await conn.ExecuteAsync(@"
            UPDATE ClassRooms SET
                RoomName = @RoomName,
                Floor = @Floor,
                Capacity = @Capacity,
                HasProjector = @HasProjector,
                IsActive = @IsActive,
                Equipment = @Equipment,
                RoomStatus = @RoomStatus,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE RoomId = @RoomId;",
            new
            {
                room.RoomId,
                RoomName = room.RoomName.Trim(),
                Floor = Math.Max(1, room.Floor),
                Capacity = Math.Max(1, room.Capacity),
                HasProjector = hasProjector,
                IsActive = isActive,
                Equipment = room.Equipment?.Trim() ?? string.Empty,
                RoomStatus = status
            });

        return rows > 0
            ? (true, $"Đã cập nhật phòng học '{room.RoomName.Trim()}' thành công.")
            : (false, "Không tìm thấy phòng học cần cập nhật.");
    }

    public async Task<(bool Success, string Message)> DeleteRoomAsync(int roomId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        int clsCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Classes WHERE DefaultRoomId = @Id;", new { Id = roomId });
        if (clsCnt > 0)
            return (false, $"Không thể xóa phòng đang gắn với {clsCnt} lớp học.");

        int schCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ClassSchedules WHERE RoomId = @Id;", new { Id = roomId });
        if (schCnt > 0)
            return (false, $"Không thể xóa phòng đang có {schCnt} buổi học trong thời khóa biểu.");

        int rows = await conn.ExecuteAsync("DELETE FROM ClassRooms WHERE RoomId = @Id;", new { Id = roomId });
        return rows > 0 ? (true, "Đã xóa phòng học thành công.") : (false, "Không tìm thấy phòng học.");
    }
}
