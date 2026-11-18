using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetAllCoursesAsync(string? keyword = null, string? level = null);
    Task<Course?> GetCourseByIdAsync(int id);
    Task<bool> AddCourseAsync(Course course);
}