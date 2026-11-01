using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public interface IScheduleService
{
    Task<(bool IsConflict, string Message)> CheckScheduleConflictAsync(
        int teacherId, int roomId, DateTime date, TimeSpan startTime, TimeSpan endTime, int? excludeScheduleId = null);

    Task<IEnumerable<ClassSchedule>> GetSchedulesByClassAsync(int classId);
    Task<IEnumerable<ClassSchedule>> GetSchedulesByTeacherAsync(int teacherId, DateTime fromDate, DateTime toDate);
    Task<int> CreateScheduleSessionAsync(ClassSchedule schedule);
}

public class ScheduleService : IScheduleService
{
    public async Task<(bool IsConflict, string Message)> CheckScheduleConflictAsync(
        int teacherId, int roomId, DateTime date, TimeSpan startTime, TimeSpan endTime, int? excludeScheduleId = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string dateStr = date.ToString("yyyy-MM-dd");
        string startStr = startTime.ToString(@"hh\:mm");
        string endStr = endTime.ToString(@"hh\:mm");

        // 1. Check Teacher Conflict: (StartTime < NewEnd AND EndTime > NewStart)
        string teacherSql = @"
            SELECT cs.ScheduleId, c.ClassName, cs.StartTime, cs.EndTime 
            FROM ClassSchedules cs
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            WHERE cs.TeacherId = @TeacherId 
              AND cs.Date = @Date
              AND (cs.StartTime < @EndStr AND cs.EndTime > @StartStr)
              AND (@ExcludeId IS NULL OR cs.ScheduleId != @ExcludeId);";

        var teacherConflict = await conn.QueryFirstOrDefaultAsync(teacherSql, new 
        { 
            TeacherId = teacherId, 
            Date = dateStr, 
            StartStr = endStr, // End of new session
            EndStr = startStr, // Start of new session
            ExcludeId = excludeScheduleId 
        });

        // Let's refine query: cs.StartTime < @NewEnd AND cs.EndTime > @NewStart
        string refinedTeacherSql = @"
            SELECT cs.ScheduleId, c.ClassName, cs.StartTime, cs.EndTime, t.FullName as TeacherName
            FROM ClassSchedules cs
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            INNER JOIN Teachers t ON cs.TeacherId = t.TeacherId
            WHERE cs.TeacherId = @TeacherId 
              AND cs.Date = @Date
              AND (cs.StartTime < @NewEnd AND cs.EndTime > @NewStart)
              AND (@ExcludeId IS NULL OR cs.ScheduleId != @ExcludeId);";

        var tConflict = await conn.QueryFirstOrDefaultAsync(refinedTeacherSql, new
        {
            TeacherId = teacherId,
            Date = dateStr,
            NewStart = startStr,
            NewEnd = endStr,
            ExcludeId = excludeScheduleId
        });

        if (tConflict != null)
        {
            return (true, $"Xung đột lịch giáo viên: Giáo viên {tConflict.TeacherName} đã có ca dạy lớp '{tConflict.ClassName}' vào khung giờ {tConflict.StartTime} - {tConflict.EndTime} ngày {date:dd/MM/yyyy}.");
        }

        // 2. Check Room Conflict
        string refinedRoomSql = @"
            SELECT cs.ScheduleId, c.ClassName, cs.StartTime, cs.EndTime, r.RoomName
            FROM ClassSchedules cs
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            INNER JOIN ClassRooms r ON cs.RoomId = r.RoomId
            WHERE cs.RoomId = @RoomId 
              AND cs.Date = @Date
              AND (cs.StartTime < @NewEnd AND cs.EndTime > @NewStart)
              AND (@ExcludeId IS NULL OR cs.ScheduleId != @ExcludeId);";

        var rConflict = await conn.QueryFirstOrDefaultAsync(refinedRoomSql, new
        {
            RoomId = roomId,
            Date = dateStr,
            NewStart = startStr,
            NewEnd = endStr,
            ExcludeId = excludeScheduleId
        });

        if (rConflict != null)
        {
            return (true, $"Xung đột phòng học: Phòng '{rConflict.RoomName}' đã được xếp cho lớp '{rConflict.ClassName}' vào khung giờ {rConflict.StartTime} - {rConflict.EndTime} ngày {date:dd/MM/yyyy}.");
        }

        return (false, "Lịch học hợp lệ, không có xung đột.");
    }

    public async Task<IEnumerable<ClassSchedule>> GetSchedulesByClassAsync(int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync<ClassSchedule>(
            "SELECT * FROM ClassSchedules WHERE ClassId = @ClassId ORDER BY SessionNumber ASC;", 
            new { ClassId = classId });
    }

    public async Task<IEnumerable<ClassSchedule>> GetSchedulesByTeacherAsync(int teacherId, DateTime fromDate, DateTime toDate)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync<ClassSchedule>(@"
            SELECT * FROM ClassSchedules 
            WHERE TeacherId = @TeacherId AND Date BETWEEN @From AND @To
            ORDER BY Date ASC, StartTime ASC;",
            new { TeacherId = teacherId, From = fromDate.ToString("yyyy-MM-dd"), To = toDate.ToString("yyyy-MM-dd") });
    }

    public async Task<int> CreateScheduleSessionAsync(ClassSchedule schedule)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            INSERT INTO ClassSchedules (ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, Topic)
            VALUES (@ClassId, @SessionNumber, @DateStr, @StartStr, @EndStr, @RoomId, @TeacherId, @Topic);
            SELECT last_insert_rowid();";

        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            schedule.ClassId,
            schedule.SessionNumber,
            DateStr = schedule.Date.ToString("yyyy-MM-dd"),
            StartStr = schedule.StartTime.ToString(@"hh\:mm"),
            EndStr = schedule.EndTime.ToString(@"hh\:mm"),
            schedule.RoomId,
            schedule.TeacherId,
            schedule.Topic
        });
    }
}
