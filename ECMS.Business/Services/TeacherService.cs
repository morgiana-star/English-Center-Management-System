using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _repo;

    public TeacherService(ITeacherRepository? repo = null)
    {
        _repo = repo ?? new TeacherRepository();
    }

    public Task<IEnumerable<TeacherListItemDto>> GetAllTeachersAsync() => _repo.GetAllTeachersAsync();

    public Task<TeacherListItemDto?> GetTeacherByIdAsync(int teacherId) => _repo.GetTeacherByIdAsync(teacherId);

    public Task<string> GenerateNextTeacherCodeAsync() => _repo.GenerateNextTeacherCodeAsync();

    public async Task<(bool Success, string Message, int TeacherId)> CreateTeacherAsync(SaveTeacherDto dto)
    {
        var err = ValidateTeacher(dto);
        if (err != null) return (false, err, 0);
        return await _repo.CreateTeacherAsync(dto);
    }

    public async Task<(bool Success, string Message)> UpdateTeacherAsync(SaveTeacherDto dto)
    {
        if (dto.TeacherId <= 0) return (false, "Mã định danh giáo viên không hợp lệ.");
        var err = ValidateTeacher(dto);
        if (err != null) return (false, err);
        return await _repo.UpdateTeacherAsync(dto);
    }

    public Task<(bool Success, string Message)> DeleteTeacherAsync(int teacherId)
        => _repo.DeleteTeacherAsync(teacherId);

    private static string? ValidateTeacher(SaveTeacherDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.FullName) || dto.FullName.Trim().Length < 2)
            return "Vui lòng nhập đầy đủ họ và tên giáo viên.";

        string cleanPhone = (dto.Phone ?? "").Replace(" ", "").Trim();
        if (string.IsNullOrWhiteSpace(cleanPhone) || !Regex.IsMatch(cleanPhone, @"^0\d{9}$"))
            return "Số điện thoại giáo viên phải gồm đúng 10 chữ số, bắt đầu bằng số 0.";

        if (!string.IsNullOrWhiteSpace(dto.Email) && !Regex.IsMatch(dto.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return "Địa chỉ email giáo viên không đúng định dạng.";

        if (string.IsNullOrWhiteSpace(dto.Specialization))
            return "Vui lòng chọn chuyên môn giảng dạy.";

        return null;
    }
}
