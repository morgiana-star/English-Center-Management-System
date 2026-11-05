using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class RolePermissionDto
{
    public int PermissionId { get; set; }
    public string PermissionCode { get; set; } = string.Empty;
    public string PermissionName { get; set; } = string.Empty;
    public string ModuleName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsAssigned { get; set; }
}

public class ModulePermissionsDto
{
    public string ModuleName { get; set; } = string.Empty;
    public List<RolePermissionDto> Permissions { get; set; } = new();
}

public class UpdateRolePermissionsRequest
{
    public int RoleId { get; set; }
    public List<int> PermissionIds { get; set; } = new();
}
