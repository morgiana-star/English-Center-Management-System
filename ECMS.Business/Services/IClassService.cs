using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface IClassService
{
    Task<IEnumerable<ClassListItemDto>> GetClassesAsync(string? keyword = null, string? courseName = null, string? status = null);
    Task<Class?> GetClassByIdAsync(int id);
    Task<(bool Success, string Message)> CreateClassAsync(Class c);
}
