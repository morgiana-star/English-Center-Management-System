using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
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
    Task<IEnumerable<StudyMaterialDto>> GetStudyMaterialsAsync(string? keyword = null, string? courseName = null, string? fileType = null);
    Task<(bool Success, string Message)> SaveStudyMaterialAsync(StudyMaterialDto material);
    Task<(bool Success, string Message)> DeleteStudyMaterialAsync(int materialId);
}
