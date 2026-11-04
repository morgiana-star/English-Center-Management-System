using System;

namespace ECMS.Core.DTOs;

public class UserListItemDto
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int RoleId { get; set; }
    public string RoleCode { get; set; } = string.Empty;
    public string RoleName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public int FailedLoginAttempts { get; set; }
    public DateTime? LockoutEnd { get; set; }
    public DateTime CreatedAt { get; set; }

    public bool IsLocked => !IsActive || (LockoutEnd.HasValue && LockoutEnd.Value > DateTime.Now) || FailedLoginAttempts >= 5;

    public string StatusText
    {
        get
        {
            if (!IsActive) return "Đã vô hiệu hóa";
            if (LockoutEnd.HasValue && LockoutEnd.Value > DateTime.Now)
            {
                var remainingMinutes = (int)Math.Ceiling((LockoutEnd.Value - DateTime.Now).TotalMinutes);
                return remainingMinutes > 0 ? $"Tạm khóa ({remainingMinutes}p)" : "Tạm khóa 15p";
            }
            if (FailedLoginAttempts >= 5) return "Tạm khóa (5 lần sai)";
            return "Hoạt động";
        }
    }
}

public class CreateUserDto
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int RoleId { get; set; }
    public bool IsActive { get; set; } = true;
}

public class UpdateUserDto
{
    public int UserId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int RoleId { get; set; }
    public bool IsActive { get; set; } = true;
    public string? NewPassword { get; set; }
}

public class AdminTelemetryDto
{
    public int TotalUsers { get; set; }
    public int ActiveUsers { get; set; }
    public int LockedUsers { get; set; }
    public int AuditLogsCount { get; set; }
    public string DatabaseStatus { get; set; } = "WAL Online";
}
