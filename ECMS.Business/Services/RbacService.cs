using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECMS.Business.Session;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class RbacService : IRbacService
{
    private readonly IRbacRepository _rbacRepo;

    public RbacService(IRbacRepository? rbacRepo = null)
    {
        _rbacRepo = rbacRepo ?? new RbacRepository();
    }

    public async Task<IEnumerable<Role>> GetAllRolesAsync()
    {
        return await _rbacRepo.GetAllRolesAsync();
    }

    public async Task<Role?> GetRoleByIdAsync(int roleId)
    {
        return await _rbacRepo.GetRoleByIdAsync(roleId);
    }

    public async Task<IEnumerable<RolePermissionDto>> GetPermissionsByRoleIdAsync(int roleId)
    {
        return await _rbacRepo.GetPermissionsByRoleIdAsync(roleId);
    }

    public async Task<IEnumerable<ModulePermissionsDto>> GetGroupedPermissionsByRoleIdAsync(int roleId)
    {
        var perms = await _rbacRepo.GetPermissionsByRoleIdAsync(roleId);

        var grouped = perms
            .GroupBy(p => p.ModuleName)
            .Select(g => new ModulePermissionsDto
            {
                ModuleName = g.Key,
                Permissions = g.ToList()
            })
            .OrderBy(m => m.ModuleName)
            .ToList();

        return grouped;
    }

    public async Task<(bool Success, string Message)> UpdateRolePermissionsAsync(int roleId, IEnumerable<int> permissionIds)
    {
        var role = await _rbacRepo.GetRoleByIdAsync(roleId);
        if (role == null)
        {
            return (false, "Không tìm thấy vai trò cần cập nhật phân quyền.");
        }

        var idList = permissionIds.ToList();

        // Protection: Ensure ROLE_ADMIN maintains core access to RBAC and Users
        if (role.RoleCode == "ROLE_ADMIN")
        {
            var allPerms = (await _rbacRepo.GetPermissionsByRoleIdAsync(roleId)).ToList();
            var criticalCodes = new[] { "USER_VIEW", "USER_CREATE", "RBAC_MANAGE", "RBAC_VIEW" };
            var criticalIds = allPerms
                .Where(p => criticalCodes.Contains(p.PermissionCode))
                .Select(p => p.PermissionId)
                .ToList();

            foreach (var cid in criticalIds)
            {
                if (!idList.Contains(cid))
                {
                    idList.Add(cid); // Auto-retain critical admin controls
                }
            }
        }

        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;

        bool ok = await _rbacRepo.UpdateRolePermissionsAsync(roleId, idList, currentAdminId);
        if (!ok)
        {
            return (false, "Cập nhật phân quyền thất bại.");
        }

        return (true, $"Đã lưu thành công cấu hình phân quyền ({idList.Count} quyền) cho vai trò '{role.RoleName}'.");
    }

    public async Task<(bool Success, string Message)> ResetRolePermissionsToDefaultAsync(int roleId)
    {
        var role = await _rbacRepo.GetRoleByIdAsync(roleId);
        if (role == null)
        {
            return (false, "Không tìm thấy vai trò cần khôi phục.");
        }

        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;

        bool ok = await _rbacRepo.ResetRolePermissionsToDefaultAsync(roleId, currentAdminId);
        if (!ok)
        {
            return (false, "Khôi phục phân quyền mặc định thất bại.");
        }

        return (true, $"Đã khôi phục phân quyền mặc định thành công cho vai trò '{role.RoleName}'.");
    }

    public Task<List<RbacMatrixRowDto>> GetSidebarMatrixAsync()
        => _rbacRepo.GetSidebarMatrixAsync();

    public async Task<List<RbacMatrixRowDto>> ResetSidebarMatrixToDefaultAsync()
    {
        var defaults = RbacRepository.GetDefaultSidebarMatrix();
        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;
        await _rbacRepo.SaveSidebarMatrixAsync(defaults, currentAdminId);
        return defaults;
    }

    public async Task<(bool Success, string Message)> SaveSidebarMatrixAsync(List<RbacMatrixRowDto> rows, int currentAdminId)
    {
        foreach (var r in rows)
        {
            r.AdminAccess = "Toàn quyền";
        }
        bool ok = await _rbacRepo.SaveSidebarMatrixAsync(rows, currentAdminId);
        return ok
            ? (true, "Đã lưu ma trận phân quyền vào cơ sở dữ liệu. Thay đổi sẽ có hiệu lực ngay khi đăng nhập.")
            : (false, "Lưu ma trận phân quyền thất bại.");
    }

    public async Task<Dictionary<string, string>> GetModuleAccessMapForRoleAsync(string roleCode)
    {
        var rows = await _rbacRepo.GetSidebarMatrixAsync();
        var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var r in rows)
        {
            string val = roleCode switch
            {
                "ROLE_ADMIN" => "Toàn quyền",
                "ROLE_MGR" => r.ManagerAccess,
                "ROLE_AA" => r.AcademicAccess,
                "ROLE_EC" => r.CounselorAccess,
                "ROLE_ACC" => r.AccountantAccess,
                "ROLE_TEA" => r.TeacherAccess,
                _ => "Không có quyền"
            };
            map[r.ModuleKey] = string.IsNullOrWhiteSpace(val) ? "Không có quyền" : val.Trim();
        }

        return map;
    }

    public async Task<HashSet<string>> GetAllowedModuleKeysForRoleAsync(string roleCode)
    {
        var map = await GetModuleAccessMapForRoleAsync(roleCode);
        var allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var kv in map)
        {
            if (!kv.Value.Contains("Không", StringComparison.OrdinalIgnoreCase))
            {
                allowed.Add(kv.Key);
            }
        }
        return allowed;
    }
}
