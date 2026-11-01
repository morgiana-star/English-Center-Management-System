using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;
using Dapper;

namespace ECMS.Business.Services;

public interface IAuthService
{
    Task<(bool Success, string Message, UserSession? Session)> LoginAsync(string username, string password);
    Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword);
}

public class AuthService : IAuthService
{
    public async Task<(bool Success, string Message, UserSession? Session)> LoginAsync(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return (false, "Tên đăng nhập và mật khẩu không được để trống.", null);
        }

        using var conn = DatabaseConfig.CreateOpenConnection();

        // 1. Fetch user
        var user = await conn.QuerySingleOrDefaultAsync<User>(
            "SELECT * FROM Users WHERE Username = @Username COLLATE NOCASE;", 
            new { Username = username.Trim() });

        if (user == null)
        {
            return (false, "Tài khoản hoặc mật khẩu không chính xác.", null);
        }

        // 2. Check if account is active
        if (!user.IsActive)
        {
            return (false, "Tài khoản của bạn đã bị khóa. Vui lòng liên hệ Quản trị viên.", null);
        }

        // 3. Check lockout
        if (user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.Now)
        {
            var remaining = (user.LockoutEnd.Value - DateTime.Now).Minutes + 1;
            return (false, $"Tài khoản đang bị tạm khóa do nhập sai quá nhiều lần. Vui lòng thử lại sau {remaining} phút.", null);
        }

        // 4. Verify password with BCrypt
        bool passwordMatches = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

        if (!passwordMatches)
        {
            int failedAttempts = user.FailedLoginAttempts + 1;
            DateTime? lockout = null;

            if (failedAttempts >= 5)
            {
                lockout = DateTime.Now.AddMinutes(15);
            }

            await conn.ExecuteAsync(
                "UPDATE Users SET FailedLoginAttempts = @Failed, LockoutEnd = @Lockout WHERE UserId = @Id;",
                new { Failed = failedAttempts, Lockout = lockout, Id = user.UserId });

            if (failedAttempts >= 5)
            {
                return (false, "Bạn đã nhập sai mật khẩu 5 lần. Tài khoản bị tạm khóa 15 phút.", null);
            }

            return (false, $"Mật khẩu không chính xác. Bạn còn {5 - failedAttempts} lần thử.", null);
        }

        // 5. Login success: Reset failed attempts
        await conn.ExecuteAsync(
            "UPDATE Users SET FailedLoginAttempts = 0, LockoutEnd = NULL WHERE UserId = @Id;",
            new { Id = user.UserId });

        // 6. Fetch Roles and Permissions
        var role = await conn.QueryFirstOrDefaultAsync<Role>(@"
            SELECT r.* FROM Roles r
            INNER JOIN UserRoles ur ON r.RoleId = ur.RoleId
            WHERE ur.UserId = @UserId;", new { UserId = user.UserId });

        string roleCode = role?.RoleCode ?? "ROLE_GUEST";
        string roleName = role?.RoleName ?? "Khách";

        var permissions = await conn.QueryAsync<string>(@"
            SELECT p.PermissionCode FROM Permissions p
            INNER JOIN RolePermissions rp ON p.PermissionId = rp.PermissionId
            INNER JOIN UserRoles ur ON rp.RoleId = ur.RoleId
            WHERE ur.UserId = @UserId;", new { UserId = user.UserId });

        // 7. Get full name from Employee, Teacher, Student or Parent
        string fullName = username;
        if (user.EmployeeId.HasValue)
        {
            fullName = await conn.ExecuteScalarAsync<string>(
                "SELECT FullName FROM Employees WHERE EmployeeId = @Id;", new { Id = user.EmployeeId.Value }) ?? username;
        }
        else if (user.TeacherId.HasValue)
        {
            fullName = await conn.ExecuteScalarAsync<string>(
                "SELECT FullName FROM Teachers WHERE TeacherId = @Id;", new { Id = user.TeacherId.Value }) ?? username;
        }
        else if (user.StudentId.HasValue)
        {
            fullName = await conn.ExecuteScalarAsync<string>(
                "SELECT FullName FROM Students WHERE StudentId = @Id;", new { Id = user.StudentId.Value }) ?? username;
        }
        else if (user.ParentId.HasValue)
        {
            fullName = await conn.ExecuteScalarAsync<string>(
                "SELECT FullName FROM Parents WHERE ParentId = @Id;", new { Id = user.ParentId.Value }) ?? username;
        }

        var session = new UserSession
        {
            UserId = user.UserId,
            Username = user.Username,
            FullName = fullName,
            RoleCode = roleCode,
            RoleName = roleName,
            EmployeeId = user.EmployeeId,
            TeacherId = user.TeacherId,
            StudentId = user.StudentId,
            ParentId = user.ParentId,
            Permissions = new HashSet<string>(permissions)
        };

        // Ghi Audit Log đăng nhập
        await conn.ExecuteAsync(
            "INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues) VALUES (@UserId, 'LOGIN', 'Users', @RecordId, 'Đăng nhập thành công');",
            new { UserId = user.UserId, RecordId = user.UserId.ToString() });

        return (true, "Đăng nhập thành công.", session);
    }

    public async Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        var user = await conn.QuerySingleOrDefaultAsync<User>("SELECT * FROM Users WHERE UserId = @Id;", new { Id = userId });
        if (user == null || !BCrypt.Net.BCrypt.Verify(oldPassword, user.PasswordHash))
        {
            return false;
        }

        string newHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
        int rows = await conn.ExecuteAsync(
            "UPDATE Users SET PasswordHash = @Hash, UpdatedAt = CURRENT_TIMESTAMP WHERE UserId = @Id;",
            new { Hash = newHash, Id = userId });

        return rows > 0;
    }
}
