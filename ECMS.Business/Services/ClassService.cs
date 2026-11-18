using System;
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

    public async Task<IEnumerable<ClassListItemDto>> GetClassesAsync(string? keyword = null, string? courseName = null, string? status = null)
    {
        return await _repo.GetAllClassesAsync(keyword, courseName, status);
    }

    public async Task<Class?> GetClassByIdAsync(int id)
    {
        return await _repo.GetClassByIdAsync(id);
    }

    public async Task<(bool Success, string Message)> CreateClassAsync(Class c)
    {
        if (string.IsNullOrWhiteSpace(c.ClassCode))
            return (false, "Vui lòng nhập Mã lớp học!");

        if (string.IsNullOrWhiteSpace(c.ClassName))
            return (false, "Vui lòng nhập Tên lớp học!");

        if (c.CourseId <= 0)
            return (false, "Vui lòng chọn Khóa học áp dụng!");

        if (c.MaxStudents <= 0)
            return (false, "Sĩ số tối đa phải lớn hơn 0!");

        if (c.EndDate < c.StartDate)
            return (false, "Ngày kết thúc không được trước ngày khai giảng!");

        bool ok = await _repo.AddClassAsync(c);
        return ok ? (true, "Thêm lớp học thành công!") : (false, "Lỗi thêm lớp học vào CSDL!");
    }
}
