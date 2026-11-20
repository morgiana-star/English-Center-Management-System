using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface IRbacService
{
    Task<IEnumerable<Role>> GetAllRolesAsync();
    Task<Role?> GetRoleByIdAsync(int roleId);
    Task<IEnumerable<RolePermissionDto>> GetPermissionsByRoleIdAsync(int roleId);
    Task<IEnumerable<ModulePermissionsDto>> GetGroupedPermissionsByRoleIdAsync(int roleId);
    Task<(bool Success, string Message)> UpdateRolePermissionsAsync(int roleId, IEnumerable<int> permissionIds);
    Task<(bool Success, string Message)> ResetRolePermissionsToDefaultAsync(int roleId);
    Task<List<RbacMatrixRowDto>> GetSidebarMatrixAsync();
    Task<List<RbacMatrixRowDto>> ResetSidebarMatrixToDefaultAsync();
    Task<(bool Success, string Message)> SaveSidebarMatrixAsync(List<RbacMatrixRowDto> rows, int currentAdminId);
    Task<HashSet<string>> GetAllowedModuleKeysForRoleAsync(string roleCode);
}
