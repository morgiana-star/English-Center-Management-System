using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class ClassRepository : IClassRepository
{
    public async Task<IEnumerable<ClassListItemDto>> GetAllClassesAsync(string? keyword = null, string? courseName = null, string? status = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                co.CourseName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(r.RoomName, 'Chưa xếp phòng') AS RoomName,
                'T2 - T4 - T6 · 18:00–20:00' AS ScheduleInfo,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status = 'Active') AS CurrentStudents,
                c.MaxStudents,
                CASE c.Status 
                    WHEN 'InProgress' THEN 'Đang học'
                    WHEN 'OpenForEnrollment' THEN 'Sắp mở'
                    WHEN 'Completed' THEN 'Đã kết thúc'
                    WHEN 'Planning' THEN 'Bản nháp'
                    ELSE c.Status
                END AS Status
            FROM Classes c
            INNER JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
            WHERE (@Keyword IS NULL OR c.ClassCode LIKE @Kw OR c.ClassName LIKE @Kw OR co.CourseName LIKE @Kw)
              AND (@CourseName IS NULL OR co.CourseName LIKE @CourseName)
              AND (@Status IS NULL OR c.Status = @Status)
            ORDER BY c.ClassId DESC;";

        return await conn.QueryAsync<ClassListItemDto>(sql, new
        {
            Keyword = string.IsNullOrWhiteSpace(keyword) ? null : keyword,
            Kw = $"%{keyword}%",
            CourseName = (courseName == "Tất cả khóa học" || string.IsNullOrWhiteSpace(courseName)) ? null : $"%{courseName}%",
            Status = (status == "Tất cả trạng thái" || string.IsNullOrWhiteSpace(status)) ? null : status
        });
    }

    public async Task<Class?> GetClassByIdAsync(int id)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Class>(
            "SELECT * FROM Classes WHERE ClassId = @Id;", new { Id = id });
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

    public async Task<IEnumerable<dynamic>> GetLookupDataAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync("SELECT CourseId, CourseName FROM Courses WHERE IsActive = 1;");
    }
}
