using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetAllCoursesAsync(string? keyword = null, string? level = null);
    Task<Course?> GetCourseByIdAsync(int id);
    Task<Course?> GetCourseByCodeAsync(string courseCode);
    Task<string> GenerateNextCourseCodeAsync();
    Task<bool> AddCourseAsync(Course course);
    Task<bool> UpdateCourseAsync(Course course);
    Task<(bool Success, string Message)> DeleteCourseAsync(int courseId);
}
