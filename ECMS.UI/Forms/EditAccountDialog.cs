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

    public EditAccountDialog(bool isCreateMode, int userId, string username, string fullName, string role, bool isActive)
    {
        InitializeComponent();
        IsCreateMode = isCreateMode;
        UserId = userId;

        // Bỏ Liên kết hồ sơ theo yêu cầu & dồn layout vai trò lên gọn gàng
        lblProfile.Visible = false;
        cboProfile.Visible = false;
        lblRole.Location = new Point(20, 162);
        cboRole.Location = new Point(20, 186);
        chkRequirePassChange.Location = new Point(20, 240);

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
                        Email = $"{Username.ToLowerInvariant()}@ecms.edu.vn",
                        Phone = "0901000000",
                        Password = "User@2026",
                        IsActive = true
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
