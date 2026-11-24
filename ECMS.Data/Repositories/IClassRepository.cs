using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface IClassRepository
{
    Task<IEnumerable<ClassListItemDto>> GetAllClassesAsync(string? keyword = null, string? courseName = null, string? status = null);
    Task<Class?> GetClassByIdAsync(int id);
    Task<Class?> GetClassByCodeAsync(string classCode);
    Task<bool> AddClassAsync(Class c);
    Task<(bool Success, string Message)> DeleteClassAsync(int classId);
    Task<IEnumerable<ClassStudentItemDto>> GetClassStudentsAsync(int classId);
    Task<IEnumerable<ClassScheduleItemDto>> GetClassSchedulesAsync(int classId);
    Task<IEnumerable<ClassAttendanceSummaryDto>> GetClassAttendanceSummaryAsync(int classId);
    Task<IEnumerable<ClassGradeItemDto>> GetClassGradesAsync(int classId);
    Task<IEnumerable<WaitingStudentItemDto>> GetWaitingStudentsForClassAsync(int classId);
    Task<(bool Success, string Message)> EnrollWaitingStudentsToClassAsync(int classId, List<int> studentIds);
    Task<IEnumerable<dynamic>> GetLookupDataAsync();
    Task<IEnumerable<ClassRoom>> GetAllRoomsAsync(string? keyword = null, string? status = null, string? capacityFilter = null);
    Task<(bool Success, string Message)> CreateRoomAsync(ClassRoom room);
    Task<(bool Success, string Message)> UpdateRoomAsync(ClassRoom room);
    Task<(bool Success, string Message)> DeleteRoomAsync(int roomId);
}
