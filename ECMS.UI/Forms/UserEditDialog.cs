using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class UserEditDialog : Form
{
    private readonly IUserService _userService;
    private readonly int? _userId;
    private UserListItemDto? _currentUser;

    private ModernTextBox txtUsername = null!;
    private ModernTextBox txtFullName = null!;
    private ModernTextBox txtEmail = null!;
    private ModernTextBox txtPhone = null!;
    private ModernTextBox txtPassword = null!;
    private ComboBox cboRole = null!;
    private CheckBox chkIsActive = null!;
    private Label lblPassHint = null!;
    private CustomButton btnSave = null!;
    private CustomButton btnCancel = null!;

    public UserEditDialog(int? userId = null, IUserService? userService = null)
    {
        _userId = userId;
        _userService = userService ?? new UserService();

        InitializeComponents();
        Load += async (s, e) => await LoadFormDataAsync();
    }

    private void InitializeComponents()
    {
        bool isEditMode = _userId.HasValue;

        Text = isEditMode ? "ECMS - Chỉnh sửa thông tin tài khoản" : "ECMS - Thêm mới tài khoản người dùng";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(540, 680);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(20, 15),
            Size = new Size(500, 645),
            CornerRadius = 16,
            EnableShadow = true
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = isEditMode ? "CHỈNH SỬA TÀI KHOẢN NGƯỜI DÙNG" : "THÊM TÀI KHOẢN NỘI BỘ MỚI",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Thiết lập định danh nhân sự, phân bổ vai trò quyền hạn (RBAC) và an toàn mật khẩu",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // Username
        var lblUsername = new Label
        {
            Text = "Tên đăng nhập (Username) *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 75),
            AutoSize = true
        };

        txtUsername = new ModernTextBox
        {
            Placeholder = "Ví dụ: counselor02, teacher_lan...",
            Location = new Point(20, 98),
            Size = new Size(460, 38),
            CornerRadius = 6
        };
        if (isEditMode)
        {
            txtUsername.ReadOnly = true;
        }

        // Full Name
        var lblFullName = new Label
        {
            Text = "Họ và tên nhân sự *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 145),
            AutoSize = true
        };

        txtFullName = new ModernTextBox
        {
            Placeholder = "Ví dụ: Nguyễn Văn An, Lê Thị Mai...",
            Location = new Point(20, 168),
            Size = new Size(460, 38),
            CornerRadius = 6
        };

        // Role Dropdown
        var lblRole = new Label
        {
            Text = "Vai trò hệ thống (Role) *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 215),
            AutoSize = true
        };

        cboRole = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 10f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(20, 238),
            Size = new Size(460, 38)
        };

        // Email
        var lblEmail = new Label
        {
            Text = "Địa chỉ Email:",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 285),
            AutoSize = true
        };

        txtEmail = new ModernTextBox
        {
            Placeholder = "Ví dụ: nhansu@ecms.edu.vn",
            Location = new Point(20, 308),
            Size = new Size(460, 38),
            CornerRadius = 6
        };

        // Phone
        var lblPhone = new Label
        {
            Text = "Số điện thoại liên hệ:",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 355),
            AutoSize = true
        };

        txtPhone = new ModernTextBox
        {
            Placeholder = "Ví dụ: 0901234567",
            Location = new Point(20, 378),
            Size = new Size(460, 38),
            CornerRadius = 6
        };

        // Password
        var lblPassword = new Label
        {
            Text = isEditMode ? "Mật khẩu mới (Tùy chọn):" : "Mật khẩu khởi tạo *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 425),
            AutoSize = true
        };

        txtPassword = new ModernTextBox
        {
            Placeholder = isEditMode ? "Nhập mật khẩu mới nếu muốn thay đổi..." : "Tối thiểu 6 ký tự...",
            UseSystemPasswordChar = true,
            Location = new Point(20, 448),
            Size = new Size(460, 38),
            CornerRadius = 6
        };

        lblPassHint = new Label
        {
            Text = isEditMode ? "💡 Để trống ô này nếu bạn không muốn thay đổi mật khẩu hiện tại của người dùng." : "💡 Mật khẩu sẽ được mã hóa an toàn qua thuật toán BCrypt trước khi lưu vào SQLite.",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextMuted,
            Location = new Point(20, 490),
            Size = new Size(460, 32)
        };

        // Checkbox IsActive
        chkIsActive = new CheckBox
        {
            Text = "Kích hoạt trạng thái tài khoản (Cho phép đăng nhập ngay)",
            Checked = true,
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 530),
            Size = new Size(460, 26),
            Cursor = Cursors.Hand
        };

        // Buttons
        btnSave = new CustomButton
        {
            Text = isEditMode ? "LƯU CẬP NHẬT" : "TẠO TÀI KHOẢN",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(200, 580),
            Size = new Size(150, 42),
            CornerRadius = 8
        };
        btnSave.Click += async (s, e) => await SaveUserAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(360, 580),
            Size = new Size(120, 42),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(lblUsername);
        card.Controls.Add(txtUsername);
        card.Controls.Add(lblFullName);
        card.Controls.Add(txtFullName);
        card.Controls.Add(lblRole);
        card.Controls.Add(cboRole);
        card.Controls.Add(lblEmail);
        card.Controls.Add(txtEmail);
        card.Controls.Add(lblPhone);
        card.Controls.Add(txtPhone);
        card.Controls.Add(lblPassword);
        card.Controls.Add(txtPassword);
        card.Controls.Add(lblPassHint);
        card.Controls.Add(chkIsActive);
        card.Controls.Add(btnSave);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private async Task LoadFormDataAsync()
    {
        try
        {
            // Load roles
            var roles = await _userService.GetRolesAsync();
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleId";

            if (_userId.HasValue)
            {
                _currentUser = await _userService.GetUserByIdAsync(_userId.Value);
                if (_currentUser != null)
                {
                    txtUsername.Text = _currentUser.Username;
                    txtFullName.Text = _currentUser.FullName;
                    txtEmail.Text = _currentUser.Email ?? string.Empty;
                    txtPhone.Text = _currentUser.Phone ?? string.Empty;
                    cboRole.SelectedValue = _currentUser.RoleId;
                    chkIsActive.Checked = _currentUser.IsActive;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tải thông tin tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task SaveUserAsync()
    {
        try
        {
            btnSave.Enabled = false;

            int selectedRoleId = (int)(cboRole.SelectedValue ?? 0);

            if (_userId.HasValue)
            {
                // Update mode
                var updateDto = new UpdateUserDto
                {
                    UserId = _userId.Value,
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    RoleId = selectedRoleId,
                    IsActive = chkIsActive.Checked,
                    NewPassword = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text.Trim()
                };

                var (success, message) = await _userService.UpdateUserAsync(updateDto);
                if (!success)
                {
                    MessageBox.Show(message, "Thông báo kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Create mode
                var createDto = new CreateUserDto
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    RoleId = selectedRoleId,
                    IsActive = chkIsActive.Checked
                };

                var (success, message, newId) = await _userService.CreateUserAsync(createDto);
                if (!success)
                {
                    MessageBox.Show(message, "Thông báo kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = true;
        }
    }
}
