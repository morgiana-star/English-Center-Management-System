using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class UserSession
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string RoleCode { get; set; } = string.Empty;
    public string RoleName { get; set; } = string.Empty;
    public int? EmployeeId { get; set; }
    public int? TeacherId { get; set; }
    public int? StudentId { get; set; }
    public int? ParentId { get; set; }
    public HashSet<string> Permissions { get; set; } = new();

    public bool HasPermission(string permissionCode)
    {
        if (RoleCode == "ROLE_ADMIN") return true;
        return Permissions.Contains(permissionCode);
    }

    public bool HasRole(params string[] roleCodes)
    {
        foreach (var r in roleCodes)
        {
            if (RoleCode == r) return true;
        }
        return false;
    }
}
