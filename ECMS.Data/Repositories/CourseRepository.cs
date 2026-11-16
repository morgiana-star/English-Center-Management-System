using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Dapper;
using ECMS.Core.Entities;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class CourseRepository : ICourseRepository
{
    public async Task<IEnumerable<Course>> GetAllCoursesAsync(string? keyword = null, string? level = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT * FROM Courses 
            WHERE IsActive = 1
              AND (@Keyword IS NULL OR CourseName LIKE @Kw OR CourseCode LIKE @Kw)
            ORDER BY CourseId DESC;";

        return await conn.QueryAsync<Course>(sql, new { 
            Keyword = string.IsNullOrWhiteSpace(keyword) ? null : keyword, 
            Kw = $"%{keyword}%"
        });
    }

    public async Task<Course?> GetCourseByIdAsync(int id)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Course>(
            "SELECT * FROM Courses WHERE CourseId = @Id;", new { Id = id });
    }

    public async Task<bool> AddCourseAsync(Course c)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            INSERT INTO Courses (CourseCode, CourseName, Level, TotalHours, TotalSessions, BaseTuitionFee, PassingScore, IsActive)
            VALUES (@CourseCode, @CourseName, @Level, @TotalHours, @TotalSessions, @BaseTuitionFee, @PassingScore, 1);";
        
        int rows = await conn.ExecuteAsync(sql, c);
        return rows > 0;
    }
}