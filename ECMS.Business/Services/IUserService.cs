using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface IUserService
{
    Task<IEnumerable<UserListItemDto>> GetUsersAsync(string? keyword = null, int? roleId = null, bool? isActive = null, bool onlyLocked = false);
    Task<UserListItemDto?> GetUserByIdAsync(int userId);
    Task<IEnumerable<Role>> GetRolesAsync();
    Task<(bool Success, string Message, int UserId)> CreateUserAsync(CreateUserDto dto);
    Task<(bool Success, string Message)> UpdateUserAsync(UpdateUserDto dto);
    Task<(bool Success, string Message)> ToggleUserActiveAsync(int userId);
    Task<(bool Success, string Message)> UnlockUserAsync(int targetUserId);
    Task<IEnumerable<UserListItemDto>> GetLockedUsersAsync();
    Task<(bool Success, string Message)> ResetPasswordByAdminAsync(int targetUserId, string newPassword, string reason = "Quản trị viên thiết lập lại mật khẩu");
    Task<(bool Success, string Message)> ChangePasswordSelfAsync(int userId, string oldPassword, string newPassword, string confirmPassword);
    Task<AdminTelemetryDto> GetTelemetryAsync();
}
