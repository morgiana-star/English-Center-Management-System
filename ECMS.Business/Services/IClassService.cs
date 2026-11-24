using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface IClassService
{
    Task<IEnumerable<ClassListItemDto>> GetClassesAsync(string? keyword = null, string? courseName = null, string? status = null);
    Task<Class?> GetClassByIdAsync(int id);
    Task<Class?> GetClassByCodeAsync(string classCode);
    Task<(bool Success, string Message)> CreateClassAsync(Class c);
    Task<(bool Success, string Message)> DeleteClassAsync(int classId);
    Task<IEnumerable<ClassStudentItemDto>> GetClassStudentsAsync(int classId);
    Task<IEnumerable<ClassScheduleItemDto>> GetClassSchedulesAsync(int classId);
    Task<IEnumerable<ClassAttendanceSummaryDto>> GetClassAttendanceSummaryAsync(int classId);
    Task<IEnumerable<ClassGradeItemDto>> GetClassGradesAsync(int classId);
    Task<IEnumerable<WaitingStudentItemDto>> GetWaitingStudentsForClassAsync(int classId);
    Task<(bool Success, string Message)> EnrollWaitingStudentsToClassAsync(int classId, List<int> studentIds);
}
