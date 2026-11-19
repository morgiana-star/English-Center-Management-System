using System;
using System.Collections.Generic;
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
    public string Role => cboRole.SelectedItem?.ToString() ?? "Học viên";
    public string Profile => cboProfile.SelectedItem?.ToString() ?? "Không liên kết";
    public bool RequirePassChange => chkRequirePassChange.Checked;

    public int SelectedRoleId
    {
        get
        {
            string r = Role;
            var matched = _rolesList.FirstOrDefault(x => x.RoleName.Contains(r) || x.RoleCode.Contains(r));
            if (matched != null) return matched.RoleId;

            return r switch
            {
                "Admin" => 1,
                "Quản lý" => 2,
                "Tư vấn" => 3,
                "Kế toán" => 4,
                "Đào tạo" => 5,
                "Giáo viên" => 6,
                "Học viên" => 7,
                "Phụ huynh" => 8,
                _ => 7
            };
        }
    }

    public EditAccountDialog() : this(true, 0, "", "", "Học viên", true)
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

        cboRole.Items.Clear();
        cboRole.Items.AddRange(new object[] { "Admin", "Quản lý", "Tư vấn", "Kế toán", "Đào tạo", "Giáo viên", "Học viên", "Phụ huynh" });

        cboProfile.Items.Clear();
        cboProfile.Items.AddRange(new object[] { 
            "NV-001 (Trần Minh Quân)", 
            "GV-0102 (Nguyễn Hoàng Anh)", 
            "NV-004 (Lê Phương Thảo)", 
            "HV-0241 (Nguyễn Minh Anh)", 
            "PH-0089 (Nguyễn Thu Hương)", 
            "Không liên kết" 
        });
        cboProfile.SelectedIndex = 0;

        txtUsername.Text = username;
        txtFullName.Text = fullName;

        var roleIdx = cboRole.FindStringExact(role);
        cboRole.SelectedIndex = roleIdx >= 0 ? roleIdx : 0;

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

        _ = LoadRolesFromDbAsync(role);
        WireEvents();
    }

    private async Task LoadRolesFromDbAsync(string initialRole)
    {
        try
        {
            var roles = await _userService.GetRolesAsync();
            _rolesList = roles.ToList();
        }
        catch
        {
            // Sử dụng danh sách tĩnh mặc định
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

            if (IsCreateMode)
            {
                var createDto = new CreateUserDto
                {
                    Username = Username,
                    FullName = FullName,
                    RoleId = SelectedRoleId,
                    Email = $"{Username}@ecms.edu.vn",
                    Phone = "0901 000 000",
                    Password = "User@2026",
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
        };
    }
}
