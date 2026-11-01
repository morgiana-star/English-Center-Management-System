using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public interface IAttendanceService
{
    Task<bool> SaveAttendanceBatchAsync(int scheduleId, IEnumerable<(int StudentId, AttendanceStatus Status, string? Note)> records);
    Task<int> GetStudentAbsenceCountInClassAsync(int studentId, int classId);
    Task<IEnumerable<dynamic>> GetAbsenceAlertListAsync();
}

public class AttendanceService : IAttendanceService
{
    public async Task<bool> SaveAttendanceBatchAsync(int scheduleId, IEnumerable<(int StudentId, AttendanceStatus Status, string? Note)> records)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        using var transaction = conn.BeginTransaction();

        try
        {
            foreach (var r in records)
            {
                string statusStr = r.Status.ToString();
                string upsertSql = @"
                    INSERT INTO AttendanceRecords (ScheduleId, StudentId, Status, Note, RecordedAt)
                    VALUES (@ScheduleId, @StudentId, @Status, @Note, CURRENT_TIMESTAMP)
                    ON CONFLICT(ScheduleId, StudentId) DO UPDATE SET
                        Status = excluded.Status,
                        Note = excluded.Note,
                        RecordedAt = CURRENT_TIMESTAMP;";

                await conn.ExecuteAsync(upsertSql, new
                {
                    ScheduleId = scheduleId,
                    StudentId = r.StudentId,
                    Status = statusStr,
                    Note = r.Note
                }, transaction);
            }

            transaction.Commit();
            return true;
        }
        catch
        {
            transaction.Rollback();
            return false;
        }
    }

    public async Task<int> GetStudentAbsenceCountInClassAsync(int studentId, int classId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT COUNT(*) FROM AttendanceRecords ar
            INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE ar.StudentId = @StudentId 
              AND cs.ClassId = @ClassId 
              AND ar.Status IN ('Absent', 'Excused');";

        return await conn.ExecuteScalarAsync<int>(sql, new { StudentId = studentId, ClassId = classId });
    }

    public async Task<IEnumerable<dynamic>> GetAbsenceAlertListAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT s.StudentId, s.StudentCode, s.FullName AS StudentName, s.Phone AS StudentPhone,
                   c.ClassId, c.ClassCode, c.ClassName,
                   COUNT(ar.AttendanceId) AS TotalAbsences,
                   p.FullName AS ParentName, p.Phone AS ParentPhone
            FROM AttendanceRecords ar
            INNER JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            INNER JOIN Classes c ON cs.ClassId = c.ClassId
            INNER JOIN Students s ON ar.StudentId = s.StudentId
            LEFT JOIN StudentParents sp ON s.StudentId = sp.StudentId AND sp.IsPrimaryContact = 1
            LEFT JOIN Parents p ON sp.ParentId = p.ParentId
            WHERE ar.Status IN ('Absent', 'Excused')
            GROUP BY s.StudentId, c.ClassId
            HAVING COUNT(ar.AttendanceId) >= 3
            ORDER BY TotalAbsences DESC;";

        return await conn.QueryAsync(sql);
    }
}
