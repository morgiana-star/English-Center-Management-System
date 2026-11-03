using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;

namespace ECMS.Data.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public async Task<IEnumerable<UserListItemDto>> GetUsersAsync(string? keyword = null, int? roleId = null, bool? isActive = null)
    {
        using var conn = CreateConnection();

        var sb = new StringBuilder(@"
            SELECT u.UserId,
                   u.Username,
                   COALESCE(e.FullName, t.FullName, s.FullName, p.FullName, 'Quản trị viên') AS FullName,
                   COALESCE(e.Email, t.Email, s.Email, p.Email, '') AS Email,
                   COALESCE(e.Phone, t.Phone, s.Phone, p.Phone, '') AS Phone,
                   COALESCE(r.RoleId, 0) AS RoleId,
                   COALESCE(r.RoleCode, 'ROLE_GUEST') AS RoleCode,
                   COALESCE(r.RoleName, 'Chưa gán') AS RoleName,
                   u.IsActive,
                   u.FailedLoginAttempts,
                   u.LockoutEnd,
                   u.CreatedAt
            FROM Users u
            LEFT JOIN UserRoles ur ON u.UserId = ur.UserId
            LEFT JOIN Roles r ON ur.RoleId = r.RoleId
            LEFT JOIN Employees e ON u.EmployeeId = e.EmployeeId
            LEFT JOIN Teachers t ON u.TeacherId = t.TeacherId
            LEFT JOIN Students s ON u.StudentId = s.StudentId
            LEFT JOIN Parents p ON u.ParentId = p.ParentId
            WHERE 1=1 ");

        var param = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            sb.Append(@" AND (
                u.Username LIKE @Kw 
                OR COALESCE(e.FullName, t.FullName, s.FullName, p.FullName, '') LIKE @Kw
                OR COALESCE(e.Phone, t.Phone, s.Phone, p.Phone, '') LIKE @Kw
                OR COALESCE(e.Email, t.Email, s.Email, p.Email, '') LIKE @Kw
            )");
            param.Add("Kw", $"%{keyword.Trim()}%");
        }

        if (roleId.HasValue && roleId.Value > 0)
        {
            sb.Append(" AND r.RoleId = @RoleId ");
            param.Add("RoleId", roleId.Value);
        }

        if (isActive.HasValue)
        {
            sb.Append(" AND u.IsActive = @IsActive ");
            param.Add("IsActive", isActive.Value ? 1 : 0);
        }

        sb.Append(" ORDER BY u.UserId ASC;");

        return await conn.QueryAsync<UserListItemDto>(sb.ToString(), param);
    }

    public async Task<UserListItemDto?> GetUserByIdAsync(int userId)
    {
        using var conn = CreateConnection();

        string sql = @"
            SELECT u.UserId,
                   u.Username,
                   COALESCE(e.FullName, t.FullName, s.FullName, p.FullName, 'Quản trị viên') AS FullName,
                   COALESCE(e.Email, t.Email, s.Email, p.Email, '') AS Email,
                   COALESCE(e.Phone, t.Phone, s.Phone, p.Phone, '') AS Phone,
                   COALESCE(r.RoleId, 0) AS RoleId,
                   COALESCE(r.RoleCode, 'ROLE_GUEST') AS RoleCode,
                   COALESCE(r.RoleName, 'Chưa gán') AS RoleName,
                   u.IsActive,
                   u.FailedLoginAttempts,
                   u.LockoutEnd,
                   u.CreatedAt
            FROM Users u
            LEFT JOIN UserRoles ur ON u.UserId = ur.UserId
            LEFT JOIN Roles r ON ur.RoleId = r.RoleId
            LEFT JOIN Employees e ON u.EmployeeId = e.EmployeeId
            LEFT JOIN Teachers t ON u.TeacherId = t.TeacherId
            LEFT JOIN Students s ON u.StudentId = s.StudentId
            LEFT JOIN Parents p ON u.ParentId = p.ParentId
            WHERE u.UserId = @UserId;";

        return await conn.QuerySingleOrDefaultAsync<UserListItemDto>(sql, new { UserId = userId });
    }

    public async Task<bool> IsUsernameTakenAsync(string username, int? excludeUserId = null)
    {
        using var conn = CreateConnection();
        string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username COLLATE NOCASE";
        if (excludeUserId.HasValue)
        {
            sql += " AND UserId != @ExcludeUserId";
        }
        sql += ";";

        int count = await conn.ExecuteScalarAsync<int>(sql, new { Username = username.Trim(), ExcludeUserId = excludeUserId });
        return count > 0;
    }

    public async Task<IEnumerable<Role>> GetRolesAsync()
    {
        using var conn = CreateConnection();
        return await conn.QueryAsync<Role>("SELECT * FROM Roles ORDER BY RoleId ASC;");
    }

    public async Task<int> CreateUserWithProfileAsync(CreateUserDto dto, string passwordHash, int currentAdminId)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            // 1. Fetch Role
            var role = await conn.QuerySingleOrDefaultAsync<Role>(
                "SELECT * FROM Roles WHERE RoleId = @RoleId;", 
                new { dto.RoleId }, 
                transaction: trans);

            int? employeeId = null;
            int? teacherId = null;

            if (role != null && role.RoleCode == "ROLE_TEA")
            {
                // Create Teacher profile
                int teacherCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Teachers;", transaction: trans);
                string teacherCode = $"GV-{(teacherCount + 1):D4}";

                string insTeacherSql = @"
                    INSERT INTO Teachers (TeacherCode, FullName, Specialization, Phone, Email, HourlyRate, IsNativeSpeaker, IsActive)
                    VALUES (@Code, @FullName, 'IELTS & Tiếng Anh Giao tiếp', @Phone, @Email, 300000, 0, @IsActive);
                    SELECT last_insert_rowid();";

                teacherId = (int)await conn.ExecuteScalarAsync<long>(insTeacherSql, new
                {
                    Code = teacherCode,
                    FullName = dto.FullName.Trim(),
                    Phone = dto.Phone?.Trim() ?? string.Empty,
                    Email = dto.Email?.Trim(),
                    IsActive = dto.IsActive ? 1 : 0
                }, transaction: trans);
            }
            else
            {
                // Create Employee profile for internal staff
                int empCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Employees;", transaction: trans);
                string empCode = $"NV-{(empCount + 1):D4}";

                string dept = role?.RoleCode switch
                {
                    "ROLE_ADMIN" => "Phòng Kỹ thuật & Hạ tầng",
                    "ROLE_MGR" => "Ban Giám đốc",
                    "ROLE_EC" => "Phòng Tuyển sinh",
                    "ROLE_ACC" => "Phòng Kế toán & Tài chính",
                    "ROLE_AA" => "Phòng Giáo vụ Đào tạo",
                    _ => "Nội bộ trung tâm"
                };

                string insEmpSql = @"
                    INSERT INTO Employees (EmployeeCode, FullName, Department, Phone, Email, IsActive)
                    VALUES (@Code, @FullName, @Dept, @Phone, @Email, @IsActive);
                    SELECT last_insert_rowid();";

                employeeId = (int)await conn.ExecuteScalarAsync<long>(insEmpSql, new
                {
                    Code = empCode,
                    FullName = dto.FullName.Trim(),
                    Dept = dept,
                    Phone = dto.Phone?.Trim() ?? string.Empty,
                    Email = dto.Email?.Trim(),
                    IsActive = dto.IsActive ? 1 : 0
                }, transaction: trans);
            }

            // 2. Insert into Users
            string insUserSql = @"
                INSERT INTO Users (Username, PasswordHash, PasswordSalt, EmployeeId, TeacherId, IsActive, FailedLoginAttempts)
                VALUES (@Username, @PasswordHash, 'salt', @EmployeeId, @TeacherId, @IsActive, 0);
                SELECT last_insert_rowid();";

            int newUserId = (int)await conn.ExecuteScalarAsync<long>(insUserSql, new
            {
                Username = dto.Username.Trim().ToLowerInvariant(),
                PasswordHash = passwordHash,
                EmployeeId = employeeId,
                TeacherId = teacherId,
                IsActive = dto.IsActive ? 1 : 0
            }, transaction: trans);

            // 3. Assign Role in UserRoles
            await conn.ExecuteAsync(@"
                INSERT INTO UserRoles (UserId, RoleId, AssignedDate)
                VALUES (@UserId, @RoleId, CURRENT_TIMESTAMP);",
                new { UserId = newUserId, dto.RoleId },
                transaction: trans);

            // 4. Record Audit Log
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'CREATE_USER', 'Users', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = newUserId.ToString(),
                    NewValues = $"Tạo tài khoản {dto.Username} ({dto.FullName}), Vai trò: {role?.RoleName ?? dto.RoleId.ToString()}"
                },
                transaction: trans);

            trans.Commit();
            return newUserId;
        }
        catch
        {
            trans.Rollback();
            throw;
        }
    }

    public async Task<bool> UpdateUserWithProfileAsync(UpdateUserDto dto, string? newPasswordHash, int currentAdminId)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var user = await conn.QuerySingleOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE UserId = @UserId;",
                new { dto.UserId },
                transaction: trans);

            if (user == null) return false;

            // 1. Update Profile (Employee or Teacher)
            if (user.EmployeeId.HasValue)
            {
                await conn.ExecuteAsync(@"
                    UPDATE Employees 
                    SET FullName = @FullName, 
                        Email = @Email, 
                        Phone = @Phone, 
                        IsActive = @IsActive, 
                        UpdatedAt = CURRENT_TIMESTAMP
                    WHERE EmployeeId = @EmployeeId;",
                    new
                    {
                        FullName = dto.FullName.Trim(),
                        Email = dto.Email?.Trim(),
                        Phone = dto.Phone?.Trim() ?? string.Empty,
                        IsActive = dto.IsActive ? 1 : 0,
                        user.EmployeeId
                    },
                    transaction: trans);
            }
            else if (user.TeacherId.HasValue)
            {
                await conn.ExecuteAsync(@"
                    UPDATE Teachers 
                    SET FullName = @FullName, 
                        Email = @Email, 
                        Phone = @Phone, 
                        IsActive = @IsActive, 
                        UpdatedAt = CURRENT_TIMESTAMP
                    WHERE TeacherId = @TeacherId;",
                    new
                    {
                        FullName = dto.FullName.Trim(),
                        Email = dto.Email?.Trim(),
                        Phone = dto.Phone?.Trim() ?? string.Empty,
                        IsActive = dto.IsActive ? 1 : 0,
                        user.TeacherId
                    },
                    transaction: trans);
            }

            // 2. Update User table
            if (!string.IsNullOrWhiteSpace(newPasswordHash))
            {
                await conn.ExecuteAsync(@"
                    UPDATE Users 
                    SET IsActive = @IsActive, 
                        PasswordHash = @PasswordHash, 
                        UpdatedAt = CURRENT_TIMESTAMP 
                    WHERE UserId = @UserId;",
                    new
                    {
                        IsActive = dto.IsActive ? 1 : 0,
                        PasswordHash = newPasswordHash,
                        dto.UserId
                    },
                    transaction: trans);
            }
            else
            {
                await conn.ExecuteAsync(@"
                    UPDATE Users 
                    SET IsActive = @IsActive, 
                        UpdatedAt = CURRENT_TIMESTAMP 
                    WHERE UserId = @UserId;",
                    new
                    {
                        IsActive = dto.IsActive ? 1 : 0,
                        dto.UserId
                    },
                    transaction: trans);
            }

            // 3. Update UserRoles
            await conn.ExecuteAsync("DELETE FROM UserRoles WHERE UserId = @UserId;", new { dto.UserId }, transaction: trans);
            await conn.ExecuteAsync(@"
                INSERT INTO UserRoles (UserId, RoleId, AssignedDate)
                VALUES (@UserId, @RoleId, CURRENT_TIMESTAMP);",
                new { dto.UserId, dto.RoleId },
                transaction: trans);

            // 4. Record Audit Log
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'UPDATE_USER', 'Users', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = dto.UserId.ToString(),
                    NewValues = $"Cập nhật tài khoản {dto.UserId} ({dto.FullName}), Vai trò ID: {dto.RoleId}, IsActive: {dto.IsActive}"
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

    public async Task<bool> ToggleUserActiveAsync(int userId, bool newStatus, int currentAdminId)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var user = await conn.QuerySingleOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE UserId = @UserId;",
                new { UserId = userId },
                transaction: trans);

            if (user == null) return false;

            int statusInt = newStatus ? 1 : 0;

            await conn.ExecuteAsync(@"
                UPDATE Users 
                SET IsActive = @Status, 
                    UpdatedAt = CURRENT_TIMESTAMP 
                WHERE UserId = @UserId;",
                new { Status = statusInt, UserId = userId },
                transaction: trans);

            if (user.EmployeeId.HasValue)
            {
                await conn.ExecuteAsync(@"
                    UPDATE Employees 
                    SET IsActive = @Status, 
                        UpdatedAt = CURRENT_TIMESTAMP 
                    WHERE EmployeeId = @EmployeeId;",
                    new { Status = statusInt, user.EmployeeId },
                    transaction: trans);
            }
            else if (user.TeacherId.HasValue)
            {
                await conn.ExecuteAsync(@"
                    UPDATE Teachers 
                    SET IsActive = @Status, 
                        UpdatedAt = CURRENT_TIMESTAMP 
                    WHERE TeacherId = @TeacherId;",
                    new { Status = statusInt, user.TeacherId },
                    transaction: trans);
            }

            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'TOGGLE_USER_STATUS', 'Users', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = userId.ToString(),
                    NewValues = $"Chuyển trạng thái hoạt động tài khoản {userId} thành: {(newStatus ? "Kích hoạt" : "Vô hiệu hóa")}"
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

    public async Task<User?> GetUserEntityByIdAsync(int userId)
    {
        using var conn = CreateConnection();
        return await conn.QuerySingleOrDefaultAsync<User>(
            "SELECT * FROM Users WHERE UserId = @UserId;", 
            new { UserId = userId });
    }

    public async Task<bool> ResetPasswordAsync(int targetUserId, string newPasswordHash, int currentAdminId, string reason)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var user = await conn.QuerySingleOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE UserId = @UserId;",
                new { UserId = targetUserId },
                transaction: trans);

            if (user == null) return false;

            await conn.ExecuteAsync(@"
                UPDATE Users 
                SET PasswordHash = @PasswordHash, 
                    FailedLoginAttempts = 0, 
                    LockoutEnd = NULL, 
                    UpdatedAt = CURRENT_TIMESTAMP 
                WHERE UserId = @UserId;",
                new { PasswordHash = newPasswordHash, UserId = targetUserId },
                transaction: trans);

            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@AdminId, 'RESET_PASSWORD', 'Users', @RecordId, @NewValues);",
                new
                {
                    AdminId = currentAdminId,
                    RecordId = targetUserId.ToString(),
                    NewValues = $"Admin {currentAdminId} đã reset mật khẩu tài khoản {targetUserId} ({user.Username}). Lý do: {reason}"
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

    public async Task<bool> ChangePasswordAsync(int userId, string newPasswordHash)
    {
        using var conn = CreateConnection();
        using var trans = conn.BeginTransaction();

        try
        {
            var user = await conn.QuerySingleOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE UserId = @UserId;",
                new { UserId = userId },
                transaction: trans);

            if (user == null) return false;

            await conn.ExecuteAsync(@"
                UPDATE Users 
                SET PasswordHash = @PasswordHash, 
                    FailedLoginAttempts = 0, 
                    LockoutEnd = NULL, 
                    UpdatedAt = CURRENT_TIMESTAMP 
                WHERE UserId = @UserId;",
                new { PasswordHash = newPasswordHash, UserId = userId },
                transaction: trans);

            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues)
                VALUES (@UserId, 'CHANGE_PASSWORD', 'Users', @RecordId, @NewValues);",
                new
                {
                    UserId = userId,
                    RecordId = userId.ToString(),
                    NewValues = $"Người dùng {user.Username} đã tự đổi mật khẩu thành công"
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

    public async Task<AdminTelemetryDto> GetTelemetryAsync()
    {
        using var conn = CreateConnection();

        int totalUsers = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Users;");
        int activeUsers = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Users WHERE IsActive = 1;");
        int lockedUsers = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Users WHERE IsActive = 0 OR (LockoutEnd IS NOT NULL AND LockoutEnd > CURRENT_TIMESTAMP);");
        int auditCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM AuditLogs;");

        return new AdminTelemetryDto
        {
            TotalUsers = totalUsers,
            ActiveUsers = activeUsers,
            LockedUsers = lockedUsers,
            AuditLogsCount = auditCount,
            DatabaseStatus = "WAL Online"
        };
    }
}
