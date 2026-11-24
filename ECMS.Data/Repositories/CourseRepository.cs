using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.Entities;
using ECMS.Core.Helpers;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class CourseRepository : ICourseRepository
{
    public async Task<IEnumerable<Course>> GetAllCoursesAsync(string? keyword = null, string? level = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            SELECT * FROM Courses 
            WHERE (@Keyword IS NULL OR CourseName LIKE @Kw OR CourseCode LIKE @Kw)
            ORDER BY CourseId DESC;";

        return await conn.QueryAsync<Course>(sql, new
        {
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

    public async Task<Course?> GetCourseByCodeAsync(string courseCode)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Course>(
            "SELECT * FROM Courses WHERE UPPER(TRIM(CourseCode)) = UPPER(TRIM(@Code)) LIMIT 1;",
            new { Code = courseCode });
    }

    public async Task<string> GenerateNextCourseCodeAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        var codes = await conn.QueryAsync<string>("SELECT CourseCode FROM Courses WHERE CourseCode LIKE 'KH-%';");
        int maxNum = 0;
        foreach (var code in codes)
        {
            if (string.IsNullOrWhiteSpace(code) || !code.Contains('-')) continue;
            string tail = code.Substring(code.LastIndexOf('-') + 1);
            if (int.TryParse(tail, out int n) && n > maxNum) maxNum = n;
        }
        return CodeFormatHelper.FormatCourseCode(maxNum + 1);
    }

    public async Task<bool> AddCourseAsync(Course c)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            INSERT INTO Courses (CourseCode, CourseName, Level, TotalHours, TotalSessions, BaseTuitionFee, PassingScore, IsActive, CreatedAt)
            VALUES (@CourseCode, @CourseName, @Level, @TotalHours, @TotalSessions, @BaseTuitionFee, @PassingScore, @IsActive, CURRENT_TIMESTAMP);";

        int rows = await conn.ExecuteAsync(sql, new
        {
            CourseCode = c.CourseCode.Trim(),
            CourseName = c.CourseName.Trim(),
            Level = StatusFormatter.FormatCourseLevel(c.Level),
            c.TotalHours,
            c.TotalSessions,
            c.BaseTuitionFee,
            c.PassingScore,
            IsActive = c.IsActive ? 1 : 0
        });
        return rows > 0;
    }

    public async Task<bool> UpdateCourseAsync(Course c)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            UPDATE Courses SET
                CourseName = @CourseName,
                Level = @Level,
                TotalHours = @TotalHours,
                TotalSessions = @TotalSessions,
                BaseTuitionFee = @BaseTuitionFee,
                PassingScore = @PassingScore,
                IsActive = @IsActive,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE CourseId = @CourseId;";

        int rows = await conn.ExecuteAsync(sql, new
        {
            CourseName = c.CourseName.Trim(),
            Level = StatusFormatter.FormatCourseLevel(c.Level),
            c.TotalHours,
            c.TotalSessions,
            c.BaseTuitionFee,
            c.PassingScore,
            IsActive = c.IsActive ? 1 : 0,
            c.CourseId
        });
        return rows > 0;
    }

    public async Task<(bool Success, string Message)> DeleteCourseAsync(int courseId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();

        int classCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Classes WHERE CourseId = @Id;", new { Id = courseId });
        if (classCnt > 0)
            return (false, $"Không thể xóa khóa học đang có {classCnt} lớp học liên kết. Vui lòng chuyển sang trạng thái Tạm dừng.");

        int matCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM StudyMaterials WHERE CourseId = @Id;", new { Id = courseId });
        if (matCnt > 0)
            return (false, $"Không thể xóa khóa học đang có {matCnt} tài liệu học tập liên kết. Vui lòng chuyển sang trạng thái Tạm dừng.");

        int rows = await conn.ExecuteAsync("DELETE FROM Courses WHERE CourseId = @Id;", new { Id = courseId });
        return rows > 0
            ? (true, "Đã xóa khóa học thành công.")
            : (false, "Không tìm thấy khóa học cần xóa.");
    }
}
