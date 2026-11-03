using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserListItemDto>> GetUsersAsync(string? keyword = null, int? roleId = null, bool? isActive = null);
    Task<UserListItemDto?> GetUserByIdAsync(int userId);
    Task<User?> GetUserEntityByIdAsync(int userId);
    Task<bool> IsUsernameTakenAsync(string username, int? excludeUserId = null);
    Task<IEnumerable<Role>> GetRolesAsync();
    Task<int> CreateUserWithProfileAsync(CreateUserDto dto, string passwordHash, int currentAdminId);
    Task<bool> UpdateUserWithProfileAsync(UpdateUserDto dto, string? newPasswordHash, int currentAdminId);
    Task<bool> ToggleUserActiveAsync(int userId, bool newStatus, int currentAdminId);
    Task<bool> ResetPasswordAsync(int targetUserId, string newPasswordHash, int currentAdminId, string reason);
    Task<bool> ChangePasswordAsync(int userId, string newPasswordHash);
    Task<AdminTelemetryDto> GetTelemetryAsync();
}
