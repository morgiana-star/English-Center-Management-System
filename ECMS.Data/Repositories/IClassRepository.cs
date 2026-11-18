using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface IClassRepository
{
    Task<IEnumerable<ClassListItemDto>> GetAllClassesAsync(string? keyword = null, string? courseName = null, string? status = null);
    Task<Class?> GetClassByIdAsync(int id);
    Task<bool> AddClassAsync(Class c);
    Task<IEnumerable<dynamic>> GetLookupDataAsync();
}
