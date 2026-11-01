using System;

namespace ECMS.Core.Entities;

public class User : BaseEntity
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string PasswordSalt { get; set; } = string.Empty;
    public int? EmployeeId { get; set; }
    public int? TeacherId { get; set; }
    public int? StudentId { get; set; }
    public int? ParentId { get; set; }
    public bool IsActive { get; set; } = true;
    public int FailedLoginAttempts { get; set; } = 0;
    public DateTime? LockoutEnd { get; set; }
}

public class Role
{
    public int RoleId { get; set; }
    public string RoleCode { get; set; } = string.Empty;
    public string RoleName { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class UserRole
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
    public DateTime AssignedDate { get; set; } = DateTime.Now;
}

public class Permission
{
    public int PermissionId { get; set; }
    public string PermissionCode { get; set; } = string.Empty;
    public string PermissionName { get; set; } = string.Empty;
    public string ModuleName { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class RolePermission
{
    public int RoleId { get; set; }
    public int PermissionId { get; set; }
}
