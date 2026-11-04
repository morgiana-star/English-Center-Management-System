using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ECMS.Business.Session;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepo;

    public UserService(IUserRepository? userRepo = null)
    {
        _userRepo = userRepo ?? new UserRepository();
    }

    public async Task<IEnumerable<UserListItemDto>> GetUsersAsync(string? keyword = null, int? roleId = null, bool? isActive = null, bool onlyLocked = false)
    {
        return await _userRepo.GetUsersAsync(keyword, roleId, isActive, onlyLocked);
    }

    public async Task<UserListItemDto?> GetUserByIdAsync(int userId)
    {
        return await _userRepo.GetUserByIdAsync(userId);
    }

    public async Task<IEnumerable<Role>> GetRolesAsync()
    {
        return await _userRepo.GetRolesAsync();
    }

    public async Task<(bool Success, string Message, int UserId)> CreateUserAsync(CreateUserDto dto)
    {
        // 1. Validate username
        if (string.IsNullOrWhiteSpace(dto.Username))
        {
            return (false, "Tên đăng nhập không được để trống.", 0);
        }

        string cleanUsername = dto.Username.Trim();
        if (cleanUsername.Length < 3)
        {
            return (false, "Tên đăng nhập tối thiểu phải từ 3 ký tự trở lên.", 0);
        }

        if (cleanUsername.Any(char.IsWhiteSpace))
        {
            return (false, "Tên đăng nhập không được chứa khoảng trắng.", 0);
        }

        if (!Regex.IsMatch(cleanUsername, @"^[a-zA-Z0-9_\.]+$"))
        {
            return (false, "Tên đăng nhập chỉ được chứa chữ cái, số, dấu chấm hoặc gạch dưới.", 0);
        }

        if (await _userRepo.IsUsernameTakenAsync(cleanUsername))
        {
            return (false, $"Tên đăng nhập '{cleanUsername}' đã tồn tại trong hệ thống. Vui lòng chọn tên khác.", 0);
        }

        // 2. Validate FullName
        if (string.IsNullOrWhiteSpace(dto.FullName))
        {
            return (false, "Họ và tên người dùng không được để trống.", 0);
        }

        if (dto.FullName.Trim().Length < 2)
        {
            return (false, "Họ và tên tối thiểu từ 2 ký tự trở lên.", 0);
        }

        // 3. Validate Password
        if (string.IsNullOrWhiteSpace(dto.Password))
        {
            return (false, "Mật khẩu khởi tạo không được để trống.", 0);
        }

        if (dto.Password.Length < 6)
        {
            return (false, "Mật khẩu khởi tạo phải có tối thiểu 6 ký tự để đảm bảo an toàn.", 0);
        }

        // 4. Validate Email
        if (!string.IsNullOrWhiteSpace(dto.Email))
        {
            string email = dto.Email.Trim();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                return (false, "Địa chỉ email không đúng định dạng chuẩn.", 0);
            }
        }

        // 5. Validate Phone
        if (!string.IsNullOrWhiteSpace(dto.Phone))
        {
            string phone = dto.Phone.Trim();
            if (phone.Length < 9 || phone.Length > 12 || !phone.All(char.IsDigit))
            {
                return (false, "Số điện thoại chỉ được chứa các chữ số và độ dài từ 9 đến 12 ký tự.", 0);
            }
        }

        // 6. Validate Role
        if (dto.RoleId <= 0)
        {
            return (false, "Vui lòng chỉ định một vai trò hệ thống hợp lệ.", 0);
        }

        // 7. Hash Password using BCrypt
        string hash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;

        int newUserId = await _userRepo.CreateUserWithProfileAsync(dto, hash, currentAdminId);

        return (true, $"Tài khoản '{cleanUsername}' đã được tạo thành công.", newUserId);
    }

    public async Task<(bool Success, string Message)> UpdateUserAsync(UpdateUserDto dto)
    {
        var existing = await _userRepo.GetUserByIdAsync(dto.UserId);
        if (existing == null)
        {
            return (false, "Không tìm thấy người dùng cần cập nhật.");
        }

        // 1. Validate FullName
        if (string.IsNullOrWhiteSpace(dto.FullName))
        {
            return (false, "Họ và tên không được để trống.");
        }

        // 2. Validate Email
        if (!string.IsNullOrWhiteSpace(dto.Email))
        {
            string email = dto.Email.Trim();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                return (false, "Địa chỉ email không đúng định dạng chuẩn.");
            }
        }

        // 3. Validate Phone
        if (!string.IsNullOrWhiteSpace(dto.Phone))
        {
            string phone = dto.Phone.Trim();
            if (phone.Length < 9 || phone.Length > 12 || !phone.All(char.IsDigit))
            {
                return (false, "Số điện thoại chỉ được chứa các chữ số và độ dài từ 9 đến 12 ký tự.");
            }
        }

        // 4. Validate Role
        if (dto.RoleId <= 0)
        {
            return (false, "Vui lòng chỉ định một vai trò hệ thống hợp lệ.");
        }

        // 5. Hash new password if changed
        string? newHash = null;
        if (!string.IsNullOrWhiteSpace(dto.NewPassword))
        {
            if (dto.NewPassword.Length < 6)
            {
                return (false, "Mật khẩu mới phải có tối thiểu 6 ký tự.");
            }
            newHash = BCrypt.Net.BCrypt.HashPassword(dto.NewPassword);
        }

        // Prevent admin from disabling their own account
        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;
        if (dto.UserId == currentAdminId && !dto.IsActive)
        {
            return (false, "Bạn không thể tự vô hiệu hóa tài khoản quản trị của chính mình.");
        }

        bool ok = await _userRepo.UpdateUserWithProfileAsync(dto, newHash, currentAdminId);
        if (!ok)
        {
            return (false, "Cập nhật tài khoản thất bại.");
        }

        return (true, "Cập nhật thông tin tài khoản thành công.");
    }

    public async Task<(bool Success, string Message)> ToggleUserActiveAsync(int userId)
    {
        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;
        if (userId == currentAdminId)
        {
            return (false, "Bạn không thể tự khóa tài khoản quản trị đang đăng nhập của chính mình.");
        }

        var existing = await _userRepo.GetUserByIdAsync(userId);
        if (existing == null)
        {
            return (false, "Không tìm thấy người dùng.");
        }

        bool newStatus = !existing.IsActive;
        bool ok = await _userRepo.ToggleUserActiveAsync(userId, newStatus, currentAdminId);
        if (!ok)
        {
            return (false, "Thay đổi trạng thái tài khoản thất bại.");
        }

        string msg = newStatus 
            ? $"Đã mở khóa và kích hoạt lại tài khoản '{existing.Username}'." 
            : $"Đã vô hiệu hóa tài khoản '{existing.Username}'.";

        return (true, msg);
    }

    public async Task<(bool Success, string Message)> UnlockUserAsync(int targetUserId)
    {
        var targetUser = await _userRepo.GetUserEntityByIdAsync(targetUserId);
        if (targetUser == null)
        {
            return (false, "Không tìm thấy tài khoản cần mở khóa.");
        }

        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;

        bool ok = await _userRepo.UnlockUserAsync(targetUserId, currentAdminId);
        if (!ok)
        {
            return (false, "Mở khóa tài khoản thất bại.");
        }

        return (true, $"Đã mở khóa khẩn cấp thành công cho tài khoản '{targetUser.Username}'. Số lần nhập sai đã được reset về 0 và tài khoản đã được kích hoạt lại.");
    }

    public async Task<IEnumerable<UserListItemDto>> GetLockedUsersAsync()
    {
        return await _userRepo.GetLockedUsersAsync();
    }

    public async Task<(bool Success, string Message)> ResetPasswordByAdminAsync(int targetUserId, string newPassword, string reason = "Quản trị viên thiết lập lại mật khẩu")
    {
        if (string.IsNullOrWhiteSpace(newPassword))
        {
            return (false, "Mật khẩu mới không được để trống.");
        }

        if (newPassword.Length < 6)
        {
            return (false, "Mật khẩu mới phải có tối thiểu 6 ký tự để đảm bảo an toàn.");
        }

        var targetUser = await _userRepo.GetUserEntityByIdAsync(targetUserId);
        if (targetUser == null)
        {
            return (false, "Không tìm thấy tài khoản cần đặt lại mật khẩu.");
        }

        string hash = BCrypt.Net.BCrypt.HashPassword(newPassword);
        int currentAdminId = SessionManager.CurrentUser?.UserId ?? 1;

        bool ok = await _userRepo.ResetPasswordAsync(targetUserId, hash, currentAdminId, reason);
        if (!ok)
        {
            return (false, "Đặt lại mật khẩu thất bại.");
        }

        return (true, $"Đã đặt lại mật khẩu thành công cho tài khoản '{targetUser.Username}'.");
    }

    public async Task<(bool Success, string Message)> ChangePasswordSelfAsync(int userId, string oldPassword, string newPassword, string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(oldPassword))
        {
            return (false, "Vui lòng nhập mật khẩu hiện tại.");
        }

        if (string.IsNullOrWhiteSpace(newPassword))
        {
            return (false, "Vui lòng nhập mật khẩu mới.");
        }

        if (newPassword.Length < 6)
        {
            return (false, "Mật khẩu mới phải có tối thiểu 6 ký tự.");
        }

        if (newPassword != confirmPassword)
        {
            return (false, "Xác nhận mật khẩu mới không trùng khớp.");
        }

        if (oldPassword == newPassword)
        {
            return (false, "Mật khẩu mới không được trùng với mật khẩu cũ.");
        }

        var user = await _userRepo.GetUserEntityByIdAsync(userId);
        if (user == null)
        {
            return (false, "Tài khoản không tồn tại trên hệ thống.");
        }

        bool isValid = BCrypt.Net.BCrypt.Verify(oldPassword, user.PasswordHash);
        if (!isValid)
        {
            return (false, "Mật khẩu hiện tại không chính xác.");
        }

        string newHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
        bool ok = await _userRepo.ChangePasswordAsync(userId, newHash);
        if (!ok)
        {
            return (false, "Đổi mật khẩu thất bại.");
        }

        return (true, "Đổi mật khẩu thành công. Vui lòng ghi nhớ mật khẩu mới cho các lần đăng nhập sau.");
    }

    public async Task<AdminTelemetryDto> GetTelemetryAsync()
    {
        return await _userRepo.GetTelemetryAsync();
    }
}
