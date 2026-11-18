using System;
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

    public async Task<IEnumerable<Course>> GetCoursesAsync(string? keyword = null, string? level = null)
    {
        return await _repo.GetAllCoursesAsync(keyword, level);
    }

    public async Task<Course?> GetCourseByIdAsync(int id)
    {
        return await _repo.GetCourseByIdAsync(id);
    }

    public async Task<(bool Success, string Message)> CreateCourseAsync(Course c)
    {
        if (string.IsNullOrWhiteSpace(c.CourseCode))
            return (false, "Vui lòng nhập Mã khóa học!");

        if (string.IsNullOrWhiteSpace(c.CourseName))
            return (false, "Vui lòng nhập Tên khóa học!");

        if (c.BaseTuitionFee < 0)
            return (false, "Học phí gốc không được âm!");

        if (c.TotalSessions <= 0)
            return (false, "Số buổi học phải lớn hơn 0!");

        bool ok = await _repo.AddCourseAsync(c);
        return ok ? (true, "Thêm khóa học thành công!") : (false, "Lỗi thêm khóa học vào CSDL!");
    }
}
