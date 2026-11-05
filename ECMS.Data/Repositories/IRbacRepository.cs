using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface IRbacRepository
{
    Task<IEnumerable<Role>> GetAllRolesAsync();
    Task<Role?> GetRoleByIdAsync(int roleId);
    Task<Role?> GetRoleByCodeAsync(string roleCode);
    Task<IEnumerable<RolePermissionDto>> GetPermissionsByRoleIdAsync(int roleId);
    Task<IEnumerable<string>> GetModulesAsync();
    Task<bool> UpdateRolePermissionsAsync(int roleId, IEnumerable<int> permissionIds, int currentAdminId);
    Task<bool> ResetRolePermissionsToDefaultAsync(int roleId, int currentAdminId);
}
