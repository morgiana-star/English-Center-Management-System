using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class RbacRepository : BaseRepository, IRbacRepository
{
    public async Task<IEnumerable<Role>> GetAllRolesAsync()
    {
        using var conn = CreateConnection();
        return await conn.QueryAsync<Role>("SELECT * FROM Roles ORDER BY RoleId ASC;");
    }

    public async Task<Role?> GetRoleByIdAsync(int roleId)
    {
        using var conn = CreateConnection();
        return await conn.QuerySingleOrDefaultAsync<Role>(
            "SELECT * FROM Roles WHERE RoleId = @RoleId;", 
            new { RoleId = roleId });
    }

    public async Task<Role?> GetRoleByCodeAsync(string roleCode)
    {
        using var conn = CreateConnection();
        return await conn.QuerySingleOrDefaultAsync<Role>(
            "SELECT * FROM Roles WHERE RoleCode = @RoleCode;", 
            new { RoleCode = roleCode });
    }

    public async Task<IEnumerable<RolePermissionDto>> GetPermissionsByRoleIdAsync(int roleId)
    {
        using var conn = CreateConnection();
        string sql = @"
            SELECT p.PermissionId,
                   p.PermissionCode,
                   p.PermissionName,
                   p.ModuleName,
                   p.Description,
                   CASE WHEN rp.RoleId IS NOT NULL THEN 1 ELSE 0 END AS IsAssigned
            FROM Permissions p
            LEFT JOIN RolePermissions rp ON p.PermissionId = rp.PermissionId AND rp.RoleId = @RoleId
            ORDER BY p.ModuleName ASC, p.PermissionId ASC;";

        return await conn.QueryAsync<RolePermissionDto>(sql, new { RoleId = roleId });
    }

    public async Task<IEnumerable<string>> GetModulesAsync()
    {
        using var conn = CreateConnection();
        return await conn.QueryAsync<string>("SELECT DISTINCT ModuleName FROM Permissions ORDER BY ModuleName ASC;");
    }

    public async Task<bool> UpdateRolePermissionsAsync(int roleId, IEnumerable<int> permissionIds, int currentAdminId)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var role = await conn.QuerySingleOrDefaultAsync<Role>(
                "SELECT * FROM Roles WHERE RoleId = @RoleId;", 
                new { RoleId = roleId }, 
                transaction: trans);

            if (role == null) return false;

            // 1. Clear old permissions for role
            await conn.ExecuteAsync(
                "DELETE FROM RolePermissions WHERE RoleId = @RoleId;", 
                new { RoleId = roleId }, 
                transaction: trans);

            // 2. Insert new permission mappings
            var idList = permissionIds.Distinct().ToList();
            if (idList.Count > 0)
            {
                var insertParams = idList.Select(pid => new { RoleId = roleId, PermissionId = pid });
                await conn.ExecuteAsync(
                    "INSERT INTO RolePermissions (RoleId, PermissionId) VALUES (@RoleId, @PermissionId);",
                    insertParams,
                    transaction: trans);
            }

            // 3. Write Audit Log
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'UPDATE_ROLE_PERMISSIONS', 'RolePermissions', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = roleId.ToString(),
                    NewValues = $"Admin {currentAdminId} đã cập nhật {idList.Count} quyền hạn cho vai trò '{role.RoleName}' ({role.RoleCode})"
                },
                transaction: trans);

            trans.Commit();
            return true;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    public async Task<bool> ResetRolePermissionsToDefaultAsync(int roleId, int currentAdminId)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var role = await conn.QuerySingleOrDefaultAsync<Role>(
                "SELECT * FROM Roles WHERE RoleId = @RoleId;", 
                new { RoleId = roleId }, 
                transaction: trans);

            if (role == null) return false;

            // 1. Clear old permissions
            await conn.ExecuteAsync(
                "DELETE FROM RolePermissions WHERE RoleId = @RoleId;", 
                new { RoleId = roleId }, 
                transaction: trans);

            // 2. Insert defaults according to role code
            if (role.RoleCode == "ROLE_ADMIN")
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO RolePermissions (RoleId, PermissionId)
                    SELECT @RoleId, PermissionId FROM Permissions;",
                    new { RoleId = roleId },
                    transaction: trans);
            }
            else
            {
                string[] defaultCodes = role.RoleCode switch
                {
                    "ROLE_MGR" => new[] { "REPORT_VIEW", "REPORT_EXPORT", "FINANCE_APPROVE", "USER_VIEW", "STUDENT_VIEW", "CLASS_VIEW", "COURSE_VIEW", "AUDIT_VIEW" },
                    "ROLE_EC" => new[] { "LEAD_VIEW", "LEAD_CREATE", "LEAD_EDIT", "LEAD_CONSULT", "LEAD_TEST", "LEAD_CONVERT", "STUDENT_VIEW", "STUDENT_CREATE", "STUDENT_EDIT", "CLASS_VIEW", "CLASS_ENROLL", "COURSE_VIEW", "ROOM_VIEW", "REPORT_VIEW" },
                    "ROLE_ACC" => new[] { "INVOICE_VIEW", "PAYMENT_CREATE", "DISCOUNT_MANAGE", "STUDENT_VIEW", "CLASS_VIEW", "REPORT_VIEW", "REPORT_EXPORT" },
                    "ROLE_AA" => new[] { "COURSE_VIEW", "COURSE_MANAGE", "ROOM_VIEW", "ROOM_MANAGE", "CLASS_VIEW", "CLASS_MANAGE", "CLASS_SCHEDULE", "CLASS_ENROLL", "ATTENDANCE_VIEW", "EXAM_VIEW", "EXAM_MANAGE", "STUDENT_VIEW", "REPORT_VIEW" },
                    "ROLE_TEA" => new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "ATTENDANCE_TAKE", "EXAM_VIEW", "EXAM_MANAGE", "STUDENT_VIEW" },
                    "ROLE_STU" => new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "EXAM_VIEW", "INVOICE_VIEW" },
                    "ROLE_PAR" => new[] { "CLASS_VIEW", "ATTENDANCE_VIEW", "EXAM_VIEW", "INVOICE_VIEW", "STUDENT_VIEW" },
                    _ => Array.Empty<string>()
                };

                foreach (var code in defaultCodes)
                {
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO RolePermissions (RoleId, PermissionId)
                        SELECT @RoleId, p.PermissionId 
                        FROM Permissions p 
                        WHERE p.PermissionCode = @Code;",
                        new { RoleId = roleId, Code = code },
                        transaction: trans);
                }
            }

            // 3. Write Audit Log
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'RESET_ROLE_PERMISSIONS', 'RolePermissions', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = roleId.ToString(),
                    NewValues = $"Admin {currentAdminId} đã khôi phục phân quyền mặc định cho vai trò '{role.RoleName}' ({role.RoleCode})"
                },
                transaction: trans);

            trans.Commit();
            return true;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }
}
