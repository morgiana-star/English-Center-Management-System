using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;

namespace ECMS.Data.Repositories;

public class ScheduleRepository : BaseRepository, IScheduleRepository
{
    public async Task<IEnumerable<WeeklyScheduleSlotDto>> GetSchedulesInRangeAsync(DateTime startDate, DateTime endDate, string? filterType = null, string? filterValue = null)
    {
        using var conn = CreateConnection();
        string sql = @"
            SELECT
                cs.ScheduleId,
                cs.ClassId,
                c.ClassCode,
                co.CourseName,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                cs.Date,
                cs.StartTime,
                cs.EndTime,
                cs.SessionNumber
            FROM ClassSchedules cs
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms r ON cs.RoomId = r.RoomId
            LEFT JOIN Teachers t ON cs.TeacherId = t.TeacherId
            WHERE substr(cs.Date, 1, 10) >= @StartDate AND substr(cs.Date, 1, 10) <= @EndDate";

        var p = new DynamicParameters();
        p.Add("StartDate", startDate.ToString("yyyy-MM-dd"));
        p.Add("EndDate", endDate.ToString("yyyy-MM-dd"));

        if (!string.IsNullOrWhiteSpace(filterValue) && !filterValue.StartsWith("--"))
        {
            if (filterType == "Class")
            {
                sql += " AND c.ClassCode = @Val";
                p.Add("Val", filterValue);
            }
            else if (filterType == "Course")
            {
                sql += " AND co.CourseName = @Val";
                p.Add("Val", filterValue);
            }
            else if (filterType == "Teacher")
            {
                sql += " AND t.FullName = @Val";
                p.Add("Val", filterValue);
            }
        }

        sql += " ORDER BY cs.Date ASC, cs.StartTime ASC, cs.ScheduleId ASC;";
        return await conn.QueryAsync<WeeklyScheduleSlotDto>(sql, p);
    }

    public async Task<IEnumerable<ScheduleSummaryItemDto>> GetClassScheduleSummariesAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                c.ClassId,
                c.ClassCode,
                co.CourseName,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                MIN(cs.Date) AS MinDate,
                MAX(cs.Date) AS MaxDate,
                MIN(cs.StartTime) AS StartTime,
                MIN(cs.EndTime) AS EndTime,
                COUNT(cs.ScheduleId) AS SessionCount,
                (SELECT COUNT(*) FROM AttendanceRecords ar INNER JOIN ClassSchedules cs2 ON ar.ScheduleId = cs2.ScheduleId WHERE cs2.ClassId = c.ClassId) AS AttendanceCount
            FROM ClassSchedules cs
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            GROUP BY c.ClassId
            ORDER BY MIN(cs.Date) DESC;";

        var rows = (await conn.QueryAsync<dynamic>(sql)).ToList();
        var allDates = (await conn.QueryAsync<(int ClassId, string Date)>(
            "SELECT ClassId, Date FROM ClassSchedules;")).ToList();
        var datesByClass = allDates.GroupBy(x => x.ClassId).ToDictionary(g => g.Key, g => g.Select(x => x.Date).ToList());

        var result = new List<ScheduleSummaryItemDto>();
        foreach (var r in rows)
        {
            int cid = (int)r.ClassId;
            string minRaw = r.MinDate ?? "";
            string maxRaw = r.MaxDate ?? "";
            string startDisp = DateTime.TryParse(minRaw, out var d1) ? d1.ToString("dd/MM/yyyy") : minRaw;
            string endDisp = DateTime.TryParse(maxRaw, out var d2) ? d2.ToString("dd/MM/yyyy") : maxRaw;

            string daysText = FormatDaysText(datesByClass.TryGetValue(cid, out var dlist) ? dlist : new List<string>());
            string timeRange = $"{r.StartTime} - {r.EndTime}";

            result.Add(new ScheduleSummaryItemDto
            {
                ClassId = cid,
                ClassCode = r.ClassCode ?? "",
                CourseName = r.CourseName ?? "",
                RoomName = r.RoomName ?? "",
                TeacherName = r.TeacherName ?? "",
                SchedulePattern = $"{daysText} ({timeRange})",
                StartDateDisplay = startDisp,
                EndDateDisplay = endDisp,
                SessionCount = (int)(r.SessionCount ?? 0),
                AttendanceCount = (int)(r.AttendanceCount ?? 0)
            });
        }
        return result;
    }

    public async Task<IEnumerable<ClassForScheduleCreateDto>> GetClassesForScheduleCreationAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                c.ClassId,
                c.ClassCode,
                co.CourseName,
                COALESCE(c.MainTeacherId, 1) AS TeacherId,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(c.DefaultRoomId, 1) AS RoomId,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                c.StartDate,
                co.TotalSessions,
                (SELECT COUNT(*) FROM ClassSchedules cs WHERE cs.ClassId = c.ClassId) AS ExistingSessions,
                c.Status AS RawStatus
            FROM Classes c
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
            WHERE c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')
            ORDER BY c.ClassId DESC;";

        var rows = (await conn.QueryAsync<dynamic>(sql)).ToList();
        var scheds = (await conn.QueryAsync<(int ClassId, string Date, string StartTime, string EndTime)>(
            "SELECT ClassId, Date, StartTime, EndTime FROM ClassSchedules ORDER BY Date ASC;")).ToList();
        var schedMap = scheds.GroupBy(x => x.ClassId).ToDictionary(g => g.Key, g => g.ToList());

        var result = new List<ClassForScheduleCreateDto>();
        foreach (var r in rows)
        {
            int cid = (int)r.ClassId;
            string schedDisp = "Chưa xếp lịch";
            if (schedMap.TryGetValue(cid, out var slist) && slist.Count > 0)
            {
                string daysText = FormatDaysText(slist.Select(x => x.Date).ToList());
                schedDisp = $"{daysText} ({slist[0].StartTime} - {slist[0].EndTime})";
            }

            result.Add(new ClassForScheduleCreateDto
            {
                ClassId = cid,
                ClassCode = r.ClassCode ?? "",
                CourseName = r.CourseName ?? "",
                TeacherId = (int)(r.TeacherId ?? 1),
                TeacherName = r.TeacherName ?? "",
                RoomId = (int)(r.RoomId ?? 1),
                RoomName = r.RoomName ?? "",
                StartDate = r.StartDate ?? DateTime.Today.ToString("yyyy-MM-dd"),
                TotalSessions = (int)(r.TotalSessions ?? 24),
                ExistingSessions = (int)(r.ExistingSessions ?? 0),
                ScheduleDisplay = schedDisp,
                StatusDisplay = StatusFormatter.FormatClassStatus((string?)r.RawStatus)
            });
        }
        return result;
    }

    public async Task<(bool Success, string Message)> GenerateClassSchedulesAsync(GenerateClassScheduleRequestDto req)
    {
        if (req.ClassId <= 0) return (false, "Vui lòng chọn lớp học.");
        if (req.DaysOfWeek == null || req.DaysOfWeek.Count == 0) return (false, "Vui lòng chọn ít nhất 1 ngày học trong tuần.");
        if (req.TotalSessions <= 0) return (false, "Số buổi học phải lớn hơn 0.");

        // 1. Tạo danh sách ngày dự kiến
        var plannedDates = new List<DateTime>();
        var cursor = req.StartDate.Date;
        int guard = 0;
        while (plannedDates.Count < req.TotalSessions && guard < 1000)
        {
            if (req.DaysOfWeek.Contains(cursor.DayOfWeek))
            {
                plannedDates.Add(cursor);
            }
            cursor = cursor.AddDays(1);
            guard++;
        }

        if (plannedDates.Count == 0)
            return (false, "Không thể tạo danh sách ngày học hợp lệ.");

        using var conn = CreateConnection();

        // Kiểm tra lớp đã có buổi điểm danh chưa nếu muốn tạo lại
        int attCnt = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM AttendanceRecords ar
            INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE cs.ClassId = @ClassId;", new { req.ClassId });
        if (attCnt > 0)
            return (false, "Lớp này đã phát sinh dữ liệu điểm danh nên không thể ghi đè lịch học hàng loạt.");

        // 2. Kiểm tra xung đột lịch (trùng phòng, trùng giáo viên)
        foreach (var d in plannedDates)
        {
            string dateStr = d.ToString("yyyy-MM-dd");

            var roomConflict = await conn.QueryFirstOrDefaultAsync<(string ClassCode, string StartTime, string EndTime)?>(@"
                SELECT c.ClassCode, cs.StartTime, cs.EndTime
                FROM ClassSchedules cs
                INNER JOIN Classes c ON cs.ClassId = c.ClassId
                WHERE cs.Date = @Date
                  AND cs.RoomId = @RoomId
                  AND cs.ClassId != @ClassId
                  AND cs.StartTime < @EndTime AND cs.EndTime > @StartTime
                LIMIT 1;",
                new { Date = dateStr, req.RoomId, req.ClassId, req.StartTime, req.EndTime });

            if (roomConflict.HasValue)
            {
                return (false, $"Trùng phòng học ngày {d:dd/MM/yyyy} ({req.StartTime} - {req.EndTime}): Phòng đã được xếp cho lớp {roomConflict.Value.ClassCode} ({roomConflict.Value.StartTime} - {roomConflict.Value.EndTime}).");
            }

            var teacherConflict = await conn.QueryFirstOrDefaultAsync<(string ClassCode, string StartTime, string EndTime)?>(@"
                SELECT c.ClassCode, cs.StartTime, cs.EndTime
                FROM ClassSchedules cs
                INNER JOIN Classes c ON cs.ClassId = c.ClassId
                WHERE cs.Date = @Date
                  AND cs.TeacherId = @TeacherId
                  AND cs.ClassId != @ClassId
                  AND cs.StartTime < @EndTime AND cs.EndTime > @StartTime
                LIMIT 1;",
                new { Date = dateStr, req.TeacherId, req.ClassId, req.StartTime, req.EndTime });

            if (teacherConflict.HasValue)
            {
                return (false, $"Trùng lịch giáo viên ngày {d:dd/MM/yyyy} ({req.StartTime} - {req.EndTime}): Giáo viên đang dạy lớp {teacherConflict.Value.ClassCode} ({teacherConflict.Value.StartTime} - {teacherConflict.Value.EndTime}).");
            }
        }

        // 3. Lưu vào ClassSchedules + đồng bộ StartDate, EndDate, DefaultRoomId, MainTeacherId vào Classes
        using var tran = conn.BeginTransaction();
        try
        {
            await conn.ExecuteAsync("DELETE FROM ClassSchedules WHERE ClassId = @ClassId;", new { req.ClassId }, tran);

            for (int i = 0; i < plannedDates.Count; i++)
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO ClassSchedules (ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, Topic, IsAttendanceLocked, CreatedAt)
                    VALUES (@ClassId, @SessionNumber, @Date, @StartTime, @EndTime, @RoomId, @TeacherId, '', 0, CURRENT_TIMESTAMP);",
                    new
                    {
                        req.ClassId,
                        SessionNumber = i + 1,
                        Date = plannedDates[i].ToString("yyyy-MM-dd"),
                        req.StartTime,
                        req.EndTime,
                        req.RoomId,
                        req.TeacherId
                    }, tran);
            }

            await conn.ExecuteAsync(@"
                UPDATE Classes SET
                    StartDate = @StartDate,
                    EndDate = @EndDate,
                    DefaultRoomId = @RoomId,
                    MainTeacherId = @TeacherId,
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE ClassId = @ClassId;",
                new
                {
                    StartDate = plannedDates.First().ToString("yyyy-MM-dd"),
                    EndDate = plannedDates.Last().ToString("yyyy-MM-dd"),
                    req.RoomId,
                    req.TeacherId,
                    req.ClassId
                }, tran);

            tran.Commit();
            return (true, $"Đã tạo thành công {plannedDates.Count} buổi học ({plannedDates.First():dd/MM/yyyy} - {plannedDates.Last():dd/MM/yyyy}).");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi khi lưu lịch học: " + ex.Message);
        }
    }

    public async Task<(bool Success, string Message)> DeleteClassSchedulesAsync(int classId)
    {
        using var conn = CreateConnection();
        int attCnt = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM AttendanceRecords ar
            INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE cs.ClassId = @ClassId;", new { ClassId = classId });

        if (attCnt > 0)
            return (false, "Không thể xóa lịch học của lớp đã phát sinh dữ liệu điểm danh.");

        int rows = await conn.ExecuteAsync("DELETE FROM ClassSchedules WHERE ClassId = @ClassId;", new { ClassId = classId });
        return rows > 0
            ? (true, $"Đã xóa {rows} buổi học của lớp thành công.")
            : (false, "Lớp này chưa có buổi học nào để xóa.");
    }

    public async Task<List<string>> GetFilterTargetsAsync(string filterType)
    {
        using var conn = CreateConnection();
        return filterType switch
        {
            "Class" => (await conn.QueryAsync<string>("SELECT ClassCode FROM Classes WHERE Status != 'Cancelled' ORDER BY ClassCode;")).ToList(),
            "Course" => (await conn.QueryAsync<string>("SELECT CourseName FROM Courses WHERE IsActive = 1 ORDER BY CourseName;")).ToList(),
            "Teacher" => (await conn.QueryAsync<string>("SELECT FullName FROM Teachers WHERE IsActive = 1 ORDER BY FullName;")).ToList(),
            _ => new List<string>()
        };
    }

    private static string FormatDaysText(List<string> dates)
    {
        var dayOrder = new List<int>();
        foreach (var d in dates)
        {
            if (DateTime.TryParse(d, out var dt))
            {
                int dow = dt.DayOfWeek == DayOfWeek.Sunday ? 8 : ((int)dt.DayOfWeek + 1);
                if (!dayOrder.Contains(dow)) dayOrder.Add(dow);
            }
        }
        dayOrder.Sort();
        return dayOrder.Count > 0 ? string.Join(", ", dayOrder.Select(x => x == 8 ? "CN" : $"T{x}")) : "Chưa có";
    }
}
