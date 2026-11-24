using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.Entities;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _repo;

    public CourseService(ICourseRepository? repo = null)
    {
        _repo = repo ?? new CourseRepository();
    }

    public Task<IEnumerable<Course>> GetCoursesAsync(string? keyword = null, string? level = null)
        => _repo.GetAllCoursesAsync(keyword, level);

    public Task<Course?> GetCourseByIdAsync(int id) => _repo.GetCourseByIdAsync(id);

    public Task<Course?> GetCourseByCodeAsync(string courseCode) => _repo.GetCourseByCodeAsync(courseCode);

    public Task<string> GenerateNextCourseCodeAsync() => _repo.GenerateNextCourseCodeAsync();

    public async Task<(bool Success, string Message)> CreateCourseAsync(Course c)
    {
        if (string.IsNullOrWhiteSpace(c.CourseCode))
            return (false, "Vui lòng nhập mã khóa học.");

        if (string.IsNullOrWhiteSpace(c.CourseName))
            return (false, "Vui lòng nhập tên khóa học.");

        if (c.BaseTuitionFee < 0)
            return (false, "Học phí gốc không được âm.");

        if (c.TotalSessions <= 0)
            return (false, "Số buổi học phải lớn hơn 0.");

        var dup = await _repo.GetCourseByCodeAsync(c.CourseCode);
        if (dup != null)
            return (false, $"Mã khóa học '{c.CourseCode}' đã tồn tại.");

        bool ok = await _repo.AddCourseAsync(c);
        return ok ? (true, "Đã thêm khóa học thành công.") : (false, "Lỗi thêm khóa học vào cơ sở dữ liệu.");
    }

    public async Task<(bool Success, string Message)> UpdateCourseAsync(Course c)
    {
        if (c.CourseId <= 0)
            return (false, "Mã định danh khóa học không hợp lệ.");

        if (string.IsNullOrWhiteSpace(c.CourseName))
            return (false, "Vui lòng nhập tên khóa học.");

        if (c.BaseTuitionFee < 0)
            return (false, "Học phí gốc không được âm.");

        if (c.TotalSessions <= 0)
            return (false, "Số buổi học phải lớn hơn 0.");

        bool ok = await _repo.UpdateCourseAsync(c);
        return ok ? (true, "Đã cập nhật khóa học thành công.") : (false, "Lỗi cập nhật khóa học.");
    }

    public Task<(bool Success, string Message)> DeleteCourseAsync(int courseId)
        => _repo.DeleteCourseAsync(courseId);
}
