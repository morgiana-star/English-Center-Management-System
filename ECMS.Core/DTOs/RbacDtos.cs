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

public class RbacMatrixRowDto
{
    public string ModuleKey { get; set; } = string.Empty;
    public string ModuleDisplayName { get; set; } = string.Empty;
    public string AdminAccess { get; set; } = "Toàn quyền";
    public string ManagerAccess { get; set; } = "Không có quyền";
    public string AcademicAccess { get; set; } = "Không có quyền";
    public string CounselorAccess { get; set; } = "Không có quyền";
    public string AccountantAccess { get; set; } = "Không có quyền";
    public string TeacherAccess { get; set; } = "Không có quyền";
}
