using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Business.Services;

public interface IUserService
{
    Task<IEnumerable<UserListItemDto>> GetUsersAsync(string? keyword = null, int? roleId = null, bool? isActive = null);
    Task<UserListItemDto?> GetUserByIdAsync(int userId);
    Task<IEnumerable<Role>> GetRolesAsync();
    Task<(bool Success, string Message, int UserId)> CreateUserAsync(CreateUserDto dto);
    Task<(bool Success, string Message)> UpdateUserAsync(UpdateUserDto dto);
    Task<(bool Success, string Message)> ToggleUserActiveAsync(int userId);
    Task<AdminTelemetryDto> GetTelemetryAsync();
}
