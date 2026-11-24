using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetCoursesAsync(string? keyword = null, string? level = null);
    Task<Course?> GetCourseByIdAsync(int id);
    Task<Course?> GetCourseByCodeAsync(string courseCode);
    Task<string> GenerateNextCourseCodeAsync();
    Task<(bool Success, string Message)> CreateCourseAsync(Course course);
    Task<(bool Success, string Message)> UpdateCourseAsync(Course course);
    Task<(bool Success, string Message)> DeleteCourseAsync(int courseId);
}
