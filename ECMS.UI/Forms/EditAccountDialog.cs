using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class EditAccountDialog : Form
{
    private readonly IUserService _userService = new UserService();
    private List<Role> _rolesList = new();
    private AppTextBox _txtEmail = null!;
    private AppTextBox _txtPhone = null!;

    public int UserId { get; private set; }
    public bool IsCreateMode { get; private set; }
    public string Username => txtUsername.Text.Trim();
    public string FullName => txtFullName.Text.Trim();
    public string Role => cboRole.SelectedItem?.ToString() ?? "Giáo viên";
    public bool RequirePassChange => chkRequirePassChange.Checked;

    public int SelectedRoleId
    {
        get
        {
            string r = Role;
            var matched = _rolesList.FirstOrDefault(x => x.RoleName.Contains(r, StringComparison.OrdinalIgnoreCase) || x.RoleCode.Contains(r, StringComparison.OrdinalIgnoreCase));
            if (matched != null) return matched.RoleId;

            return r switch
            {
                "Admin" => 1,
                "Quản lý" => 2,
                "Tư vấn" => 3,
                "Kế toán" => 4,
                "Đào tạo" => 5,
                "Giáo viên" => 6,
                _ => 6
            };
        }
    }

    public EditAccountDialog() : this(true, 0, "", "", "Giáo viên", true)
    {
    }

    public EditAccountDialog(string username, string fullName, string role, bool isActive)
        : this(false, 0, username, fullName, role, isActive)
    {
    }

    public EditAccountDialog(int userId, string username, string fullName, string role, bool isActive)
        : this(false, userId, username, fullName, role, isActive)
    {
    }

    public EditAccountDialog(bool isCreateMode, int userId, string username, string fullName, string role, bool isActive, string? email = null, string? phone = null)
    {
        InitializeComponent();
        IsCreateMode = isCreateMode;
        UserId = userId;

        // Bỏ Liên kết hồ sơ & bổ sung Email, Số điện thoại tùy chọn
        lblProfile.Visible = false;
        cboProfile.Visible = false;

        var lblEmail = new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(51, 65, 85),
            Location = new Point(20, 162),
            Text = "Email (tùy chọn)"
        };
        _txtEmail = new AppTextBox
        {
            Location = new Point(20, 186),
            Size = new Size(226, 36),
            CornerRadius = 5,
            Placeholder = "Để trống nếu chưa có",
            Text = email ?? string.Empty
        };

        var lblPhone = new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(51, 65, 85),
            Location = new Point(266, 162),
            Text = "Số điện thoại (tùy chọn)"
        };
        _txtPhone = new AppTextBox
        {
            Location = new Point(266, 186),
            Size = new Size(226, 36),
            CornerRadius = 5,
            Placeholder = "Để trống nếu chưa có",
            Text = phone ?? string.Empty,
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        cardForm.Controls.AddRange(new Control[] { lblEmail, _txtEmail, lblPhone, _txtPhone });

        lblRole.Location = new Point(20, 236);
        cboRole.Location = new Point(20, 260);
        chkRequirePassChange.Location = new Point(20, 310);
        cardForm.Size = new Size(cardForm.Width, 355);
        ClientSize = new Size(ClientSize.Width, 515);

        // Chỉ giữ 6 vai trò nội bộ (bỏ Học viên, Phụ huynh)
        cboRole.Items.Clear();
        cboRole.Items.AddRange(new object[] { "Admin", "Quản lý", "Đào tạo", "Tư vấn", "Kế toán", "Giáo viên" });

        txtUsername.Text = username;
        txtFullName.Text = fullName;

        var roleIdx = cboRole.FindString(role);
        if (roleIdx < 0)
        {
            if (role.Contains("Admin")) roleIdx = 0;
            else if (role.Contains("Quản lý")) roleIdx = 1;
            else if (role.Contains("Đào tạo") || role.Contains("Giáo vụ")) roleIdx = 2;
            else if (role.Contains("Tư vấn")) roleIdx = 3;
            else if (role.Contains("Kế toán")) roleIdx = 4;
            else roleIdx = 5;
        }
        cboRole.SelectedIndex = roleIdx;

        chkRequirePassChange.Checked = isCreateMode;

        if (isCreateMode)
        {
            lblTitle.Text = "Thêm tài khoản mới";
            btnSave.Text = "Tạo tài khoản";
            txtUsername.ReadOnly = false;
        }
        else
        {
            lblTitle.Text = "Chỉnh sửa tài khoản";
            btnSave.Text = "Lưu thay đổi";
            txtUsername.ReadOnly = true;
        }

        _ = LoadRolesFromDbAsync();
        WireEvents();
    }

    private async Task LoadRolesFromDbAsync()
    {
        try
        {
            var roles = await _userService.GetRolesAsync();
            _rolesList = roles.ToList();
        }
        catch
        {
            // Fallback
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                AppDialog.ShowError(this, "Thiếu thông tin", "Vui lòng nhập tên đăng nhập.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                AppDialog.ShowError(this, "Thiếu thông tin", "Vui lòng nhập họ và tên.");
                txtFullName.Focus();
                return;
            }

            btnSave.Enabled = false;
            try
            {
                if (IsCreateMode)
                {
                    var createDto = new CreateUserDto
                    {
                        Username = Username,
                        FullName = FullName,
                        RoleId = SelectedRoleId,
                        Email = _txtEmail.Text.Trim(),
                        Phone = _txtPhone.Text.Trim(),
                        Password = "12345678",
                        IsActive = true,
                        MustChangePassword = RequirePassChange
                    };

                    var res = await _userService.CreateUserAsync(createDto);
                    if (!res.Success)
                    {
                        AppDialog.ShowError(this, "Lỗi tạo tài khoản", res.Message);
                        return;
                    }

                    UserId = res.UserId;
                }
                else
                {
                    var updateDto = new UpdateUserDto
                    {
                        UserId = UserId,
                        FullName = FullName,
                        Email = _txtEmail.Text.Trim(),
                        Phone = _txtPhone.Text.Trim(),
                        RoleId = SelectedRoleId,
                        IsActive = true
                    };

                    var res = await _userService.UpdateUserAsync(updateDto);
                    if (!res.Success)
                    {
                        AppDialog.ShowError(this, "Lỗi cập nhật", res.Message);
                        return;
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            finally
            {
                btnSave.Enabled = true;
            }
        };
    }
}
