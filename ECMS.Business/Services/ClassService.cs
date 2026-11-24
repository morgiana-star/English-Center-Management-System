using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class ClassService : IClassService
{
    private readonly IClassRepository _repo;

    public ClassService(IClassRepository? repo = null)
    {
        _repo = repo ?? new ClassRepository();
    }

    public Task<IEnumerable<ClassListItemDto>> GetClassesAsync(string? keyword = null, string? courseName = null, string? status = null)
        => _repo.GetAllClassesAsync(keyword, courseName, status);

    public Task<Class?> GetClassByIdAsync(int id) => _repo.GetClassByIdAsync(id);

    public Task<Class?> GetClassByCodeAsync(string classCode) => _repo.GetClassByCodeAsync(classCode);

    public async Task<(bool Success, string Message)> CreateClassAsync(Class c)
    {
        if (string.IsNullOrWhiteSpace(c.ClassCode))
            return (false, "Vui lòng nhập mã lớp học.");

        if (string.IsNullOrWhiteSpace(c.ClassName))
            return (false, "Vui lòng nhập tên lớp học.");

        if (c.CourseId <= 0)
            return (false, "Vui lòng chọn khóa học áp dụng.");

        if (c.MaxStudents <= 0)
            return (false, "Sĩ số tối đa phải lớn hơn 0.");

        if (c.EndDate < c.StartDate)
            return (false, "Ngày kết thúc không được trước ngày khai giảng.");

        bool ok = await _repo.AddClassAsync(c);
        return ok ? (true, "Đã thêm lớp học thành công.") : (false, "Lỗi thêm lớp học vào cơ sở dữ liệu.");
    }

    public Task<(bool Success, string Message)> DeleteClassAsync(int classId)
        => _repo.DeleteClassAsync(classId);

    public Task<IEnumerable<ClassStudentItemDto>> GetClassStudentsAsync(int classId)
        => _repo.GetClassStudentsAsync(classId);

    public Task<IEnumerable<ClassScheduleItemDto>> GetClassSchedulesAsync(int classId)
        => _repo.GetClassSchedulesAsync(classId);

    public Task<IEnumerable<ClassAttendanceSummaryDto>> GetClassAttendanceSummaryAsync(int classId)
        => _repo.GetClassAttendanceSummaryAsync(classId);

    public Task<IEnumerable<ClassGradeItemDto>> GetClassGradesAsync(int classId)
        => _repo.GetClassGradesAsync(classId);

    public Task<IEnumerable<WaitingStudentItemDto>> GetWaitingStudentsForClassAsync(int classId)
        => _repo.GetWaitingStudentsForClassAsync(classId);

    public Task<(bool Success, string Message)> EnrollWaitingStudentsToClassAsync(int classId, List<int> studentIds)
        => _repo.EnrollWaitingStudentsToClassAsync(classId, studentIds);

    public Task<IEnumerable<ClassRoom>> GetRoomsAsync(string? keyword = null, string? status = null, string? capacityFilter = null)
        => _repo.GetAllRoomsAsync(keyword, status, capacityFilter);

    public async Task<(bool Success, string Message)> CreateRoomAsync(ClassRoom room)
    {
        if (string.IsNullOrWhiteSpace(room.RoomName))
            return (false, "Vui lòng nhập tên phòng học.");
        if (room.Capacity <= 0)
            return (false, "Sức chứa phòng phải lớn hơn 0.");
        return await _repo.CreateRoomAsync(room);
    }

    public async Task<(bool Success, string Message)> UpdateRoomAsync(ClassRoom room)
    {
        if (room.RoomId <= 0)
            return (false, "Mã phòng học không hợp lệ.");
        if (string.IsNullOrWhiteSpace(room.RoomName))
            return (false, "Vui lòng nhập tên phòng học.");
        if (room.Capacity <= 0)
            return (false, "Sức chứa phòng phải lớn hơn 0.");
        return await _repo.UpdateRoomAsync(room);
    }

    public Task<(bool Success, string Message)> DeleteRoomAsync(int roomId)
        => _repo.DeleteRoomAsync(roomId);
}
