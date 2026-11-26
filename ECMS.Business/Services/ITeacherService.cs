using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface ITeacherService
{
    Task<IEnumerable<TeacherListItemDto>> GetAllTeachersAsync();
    Task<TeacherListItemDto?> GetTeacherByIdAsync(int teacherId);
    Task<string> GenerateNextTeacherCodeAsync();
    Task<(bool Success, string Message, int TeacherId)> CreateTeacherAsync(SaveTeacherDto dto);
    Task<(bool Success, string Message)> UpdateTeacherAsync(SaveTeacherDto dto);
    Task<(bool Success, string Message)> DeleteTeacherAsync(int teacherId);
}
