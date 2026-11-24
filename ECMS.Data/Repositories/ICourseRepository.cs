using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
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
    Task<IEnumerable<StudyMaterialDto>> GetStudyMaterialsAsync(string? keyword = null, string? courseName = null, string? fileType = null);
    Task<(bool Success, string Message)> SaveStudyMaterialAsync(StudyMaterialDto material);
    Task<(bool Success, string Message)> DeleteStudyMaterialAsync(int materialId);
}
