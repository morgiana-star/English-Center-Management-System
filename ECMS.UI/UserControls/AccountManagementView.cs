using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản trị Tài khoản & Phân quyền gồm 3 Tab (100% SQLite):
/// 1. Tài khoản người dùng (Danh sách nội bộ, bỏ Học viên/Phụ huynh, bỏ Xuất danh sách)
/// 2. Vai trò & Phân quyền (Ma trận trực quan đồng bộ thẳng với Sidebar MainForm)
/// 3. Tài khoản cá nhân (Hồ sơ thật từ SQLite & Đổi mật khẩu bảo mật)
/// </summary>
public partial class AccountManagementView : UserControl
{
    private readonly IUserService _userService = new UserService();
    private readonly IRbacService _rbacService = new RbacService();
    private List<UserListItemDto> _accounts = new();
    private List<RbacMatrixRowDto> _matrixRows = new();
    private bool _isMatrixInitialized = false;

    public AccountManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupAccountsGrid();
        SetupPermissionsMatrix();
        ConfigurePersonalTabUi();

        _ = LoadAccountsAsync();
        _ = LoadMatrixFromDbAsync();
        _ = LoadUserProfileAsync();

        WireUpEvents();
    }

    public void SelectTab(int index)
    {
        if (index >= 0 && index < tabMain.TabCount)
        {
            tabMain.SelectedIndex = index;
        }
    }

    /// <summary>
    /// Chế độ chỉ xem/sửa Tài khoản cá nhân dành cho các vai trò không có quyền Quản trị tài khoản
    /// </summary>
    public void ConfigurePersonalOnlyMode()
    {
        lblTitle.Text = "Tài khoản cá nhân";
        tabProfile.Text = "Tài khoản cá nhân";
        if (tabMain.TabPages.Contains(tabAccounts)) tabMain.TabPages.Remove(tabAccounts);
        if (tabMain.TabPages.Contains(tabRoles)) tabMain.TabPages.Remove(tabRoles);
        if (tabMain.TabCount > 0) tabMain.SelectedIndex = 0;
    }

    private void SetupFilters()
    {
        // Bỏ nút Xuất danh sách & dồn nút Thêm tài khoản gọn sang phải
        btnExportAccounts.Visible = false;
        btnAddAccount.Location = new Point(pnlToolbarAccounts.Width - btnAddAccount.Width - 10, 4);
        pnlToolbarAccounts.Resize += (s, e) =>
        {
            if (btnAddAccount != null && pnlToolbarAccounts != null)
            {
                btnAddAccount.Location = new Point(pnlToolbarAccounts.Width - btnAddAccount.Width - 10, 4);
            }
        };

        // Bỏ Học viên, Phụ huynh khỏi bộ lọc
        cboRoleFilter.Items.Clear();
        cboRoleFilter.Items.AddRange(new object[]
        {
            "Tất cả vai trò",
            "Admin",
            "Quản lý",
            "Đào tạo",
            "Tư vấn",
            "Kế toán",
            "Giáo viên"
        });
        cboRoleFilter.SelectedIndex = 0;

        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Đã khóa" });
        cboStatusFilter.SelectedIndex = 0;
    }

    private void ConfigurePersonalTabUi()
    {
        // Tab 3.1: Bỏ dòng Quyền và Chi nhánh bên panel trái; đổi nhãn thành "Vai trò"
        lblSummaryPerm.Visible = false;
        lblSummaryBranch.Visible = false;
        lblRole.Text = "Vai trò";
    }

    private void SetupAccountsGrid()
    {
        dgvAccounts.Columns.Clear();

        var colUser = new DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập", FillWeight = 14, ReadOnly = true };
        var colName = new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 18, ReadOnly = true };
        var colEmail = new DataGridViewTextBoxColumn { HeaderText = "Email", FillWeight = 18, ReadOnly = true };
        var colPhone = new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", FillWeight = 13, ReadOnly = true };
        var colRole = new DataGridViewTextBoxColumn { HeaderText = "Vai trò", FillWeight = 14, ReadOnly = true };
        var colCode = new DataGridViewTextBoxColumn { HeaderText = "Mã vai trò", FillWeight = 11, ReadOnly = true };
        var colStatus = new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 12, ReadOnly = true };

        var colEdit = new DataGridViewButtonColumn
        {
            HeaderText = "Sửa",
            Text = "✏️ Sửa",
            UseColumnTextForButtonValue = true,
            FillWeight = 9
        };

        var colReset = new DataGridViewButtonColumn
        {
            HeaderText = "Mật khẩu",
            Text = "🔑 Đặt lại",
            UseColumnTextForButtonValue = true,
            FillWeight = 10
        };

        var colToggle = new DataGridViewButtonColumn
        {
            HeaderText = "Khóa / Mở",
            Text = "Đổi",
            UseColumnTextForButtonValue = false,
            FillWeight = 10
        };

        var colDelete = new DataGridViewButtonColumn
        {
            HeaderText = "Xóa",
            Text = "🗑️ Xóa",
            UseColumnTextForButtonValue = true,
            FillWeight = 9
        };

        dgvAccounts.Columns.AddRange(colUser, colName, colEmail, colPhone, colRole, colCode, colStatus, colEdit, colReset, colToggle, colDelete);
    }

    private async Task LoadAccountsAsync()
    {
        try
        {
            var list = await _userService.GetUsersAsync();
            _accounts = list.ToList();
            RefreshAccountsGrid();

            var telemetry = await _userService.GetTelemetryAsync();
            int admins = _accounts.Count(a => a.RoleCode == "ROLE_ADMIN");

            lblStatTotal.Text = $"👥 Tổng số: {telemetry.TotalUsers} tài khoản";
            lblStatActive.Text = $"🟢 Đang hoạt động: {telemetry.ActiveUsers}";
            lblStatLocked.Text = $"🔴 Đã khóa: {telemetry.LockedUsers}";
            lblStatAdmin.Text = $"🛡️ Quản trị viên: {admins}";
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách tài khoản", ex.Message);
        }
    }

    private void RefreshAccountsGrid()
    {
        dgvAccounts.Rows.Clear();

        string kw = txtSearch.Text.Trim().ToLowerInvariant();
        string roleFilter = cboRoleFilter.SelectedItem?.ToString() ?? "Tất cả vai trò";
        string statusFilter = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";

        var filtered = _accounts.Where(a =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           a.Username.ToLowerInvariant().Contains(kw) ||
                           a.FullName.ToLowerInvariant().Contains(kw) ||
                           (a.Email != null && a.Email.ToLowerInvariant().Contains(kw)) ||
                           (a.Phone != null && a.Phone.ToLowerInvariant().Contains(kw));

            bool matchRole = roleFilter == "Tất cả vai trò" ||
                             a.RoleName.Contains(roleFilter, StringComparison.OrdinalIgnoreCase) ||
                             (roleFilter == "Đào tạo" && a.RoleCode == "ROLE_AA");

            bool matchStatus = statusFilter == "Tất cả trạng thái" ||
                               (statusFilter == "Đang hoạt động" && a.IsActive && !a.IsLocked) ||
                               (statusFilter == "Đã khóa" && (!a.IsActive || a.IsLocked));

            return matchKw && matchRole && matchStatus;
        }).ToList();

        foreach (var item in filtered)
        {
            int idx = dgvAccounts.Rows.Add(
                item.Username,
                item.FullName,
                item.Email ?? string.Empty,
                item.Phone ?? string.Empty,
                item.RoleName,
                item.RoleCode,
                item.StatusText,
                "✏️ Sửa",
                "🔑 Đặt lại",
                item.IsActive ? "🔒 Khóa" : "🔓 Mở khóa",
                "🗑️ Xóa"
            );
            dgvAccounts.Rows[idx].Tag = item;
        }

        dgvAccounts.ClearSelection();
        dgvAccounts.CurrentCell = null;
    }

    private void SetupPermissionsMatrix()
    {
        if (_isMatrixInitialized) return;

        // Bỏ cột Học viên & Phụ huynh; chuẩn hóa tên cột & phân hệ rõ ràng dễ hiểu
        dgvPermissions.Columns.Clear();
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phân hệ chức năng (Menu Sidebar)", FillWeight = 32, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Admin", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quản lý", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đào tạo", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tư vấn", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế toán", FillWeight = 12, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 12, ReadOnly = true });

        _isMatrixInitialized = true;
    }

    private async Task LoadMatrixFromDbAsync()
    {
        try
        {
            _matrixRows = await _rbacService.GetSidebarMatrixAsync();
            BindMatrixGrid();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp ma trận phân quyền", ex.Message);
        }
    }

    private void BindMatrixGrid()
    {
        dgvPermissions.Rows.Clear();
        foreach (var r in _matrixRows)
        {
            int idx = dgvPermissions.Rows.Add(
                r.ModuleDisplayName,
                r.AdminAccess,
                r.ManagerAccess,
                r.AcademicAccess,
                r.CounselorAccess,
                r.AccountantAccess,
                r.TeacherAccess
            );
            dgvPermissions.Rows[idx].Tag = r;
        }
        dgvPermissions.ClearSelection();
        dgvPermissions.CurrentCell = null;
    }

    private async Task LoadUserProfileAsync()
    {
        try
        {
            var userDetail = await _userService.GetUserByIdAsync(AppSession.UserId);
            if (userDetail != null)
            {
                if (!string.IsNullOrWhiteSpace(userDetail.FullName) && !userDetail.FullName.Equals("Quản trị viên", StringComparison.OrdinalIgnoreCase))
                {
                    AppSession.FullName = userDetail.FullName;
                }
                AppSession.Email = userDetail.Email?.Trim() ?? string.Empty;
                AppSession.Phone = userDetail.Phone?.Trim() ?? string.Empty;
                AppSession.RoleName = userDetail.RoleName;
                AppSession.CreatedDate = userDetail.CreatedAt.ToString("dd/MM/yyyy");
            }
        }
        catch
        {
            // Giữ AppSession hiện tại nếu bận
        }

        BindUserProfileToUi();
    }

    private void BindUserProfileToUi()
    {
        txtFullName.Text = AppSession.FullName;
        txtEmail.Text = AppSession.Email;
        txtPhone.Text = AppSession.Phone;
        txtJobTitle.Text = string.IsNullOrWhiteSpace(AppSession.JobTitle) ? AppSession.RoleName : AppSession.JobTitle;
        txtUserRole.Text = AppSession.RoleName;

        lblSummaryName.Text = AppSession.FullName;
        lblSummaryUsername.Text = $"@{AppSession.Username}";
        lblSummaryRoleBadge.Text = AppSession.RoleName;
        lblSummaryEmail.Text = $"✉️ Email: {(string.IsNullOrWhiteSpace(AppSession.Email) ? "Chưa cập nhật" : AppSession.Email)}";
        lblSummaryPhone.Text = $"📞 Điện thoại: {(string.IsNullOrWhiteSpace(AppSession.Phone) ? "Chưa cập nhật" : AppSession.Phone)}";
        lblSummaryCreated.Text = $"📅 Ngày tạo: {AppSession.CreatedDate}";
        lblSummaryLastLogin.Text = $"🕒 Lần đăng nhập cuối: {AppSession.LastLogin}";
    }

    private void WireUpEvents()
    {
        // 1. Tab 1 Events (Tìm kiếm realtime, Lọc, Thêm, Sửa, Đặt lại MK, Khóa/Mở)
        txtSearch.TextChanged += (s, e) => RefreshAccountsGrid();
        cboRoleFilter.SelectedIndexChanged += (s, e) => RefreshAccountsGrid();
        cboStatusFilter.SelectedIndexChanged += (s, e) => RefreshAccountsGrid();

        btnAddAccount.Click += async (s, e) =>
        {
            using var dlg = new EditAccountDialog(isCreateMode: true, 0, "", "", "Giáo viên", true);
            if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                await LoadAccountsAsync();
                AppDialog.ShowSuccess(ParentForm, "Thêm tài khoản thành công",
                    $"Tài khoản '{dlg.Username}' ({dlg.FullName}) với vai trò '{dlg.Role}' đã được tạo thành công (Mật khẩu mặc định: 12345678).");
            }
        };

        dgvAccounts.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex < 0) return;
            var row = dgvAccounts.Rows[e.RowIndex];
            var item = row.Tag as UserListItemDto;
            if (item == null) return;

            // Nút Sửa (col 7)
            if (e.ColumnIndex == 7)
            {
                using var dlg = new EditAccountDialog(isCreateMode: false, item.UserId, item.Username, item.FullName, item.RoleName, item.IsActive, item.Email, item.Phone);
                if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
                {
                    await LoadAccountsAsync();
                    AppDialog.ShowSuccess(ParentForm, "Cập nhật tài khoản", $"Đã cập nhật thông tin tài khoản '{item.Username}' thành công.");
                }
            }
            // Nút Đặt lại MK (col 8)
            else if (e.ColumnIndex == 8)
            {
                using var dlg = new ResetPasswordDialog(item.UserId, item.Username, item.FullName);
                if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
                {
                    var resetRes = await _userService.ResetPasswordByAdminAsync(
                        item.UserId,
                        dlg.TempPassword,
                        "Quản trị viên đặt lại mật khẩu",
                        dlg.MustChangePassword);
                    if (!resetRes.Success)
                    {
                        AppDialog.ShowError(ParentForm, "Lỗi đặt lại mật khẩu", resetRes.Message);
                        return;
                    }

                    await LoadAccountsAsync();
                    AppDialog.ShowSuccess(ParentForm, "Đặt lại mật khẩu", $"Mật khẩu của tài khoản '{item.Username}' đã được đặt lại thành công: {dlg.TempPassword}");
                }
            }
            // Nút Khóa / Mở (col 9)
            else if (e.ColumnIndex == 9)
            {
                if (item.UserId == AppSession.UserId || item.Username == AppSession.Username)
                {
                    AppDialog.ShowWarning(ParentForm, "Không thể khóa", "Bạn không thể khóa tài khoản của chính mình đang đăng nhập.");
                    return;
                }

                var toggleRes = await _userService.ToggleUserActiveAsync(item.UserId);
                if (toggleRes.Success)
                {
                    await LoadAccountsAsync();
                    AppDialog.ShowSuccess(ParentForm, "Thay đổi trạng thái", toggleRes.Message);
                }
                else
                {
                    AppDialog.ShowError(ParentForm, "Lỗi thay đổi trạng thái", toggleRes.Message);
                }
            }
            // Nút Xóa tài khoản (col 10)
            else if (e.ColumnIndex == 10)
            {
                if (item.UserId == AppSession.UserId || item.Username == AppSession.Username)
                {
                    AppDialog.ShowWarning(ParentForm, "Không thể xóa", "Bạn không thể xóa tài khoản đang đăng nhập.");
                    return;
                }

                if (AppDialog.ShowConfirm(ParentForm, "Xác nhận xóa tài khoản",
                    $"Bạn có chắc chắn muốn xóa vĩnh viễn tài khoản '{item.Username}' ({item.FullName}) khỏi hệ thống không?") == DialogResult.OK)
                {
                    var delRes = await _userService.DeleteUserAsync(item.UserId);
                    if (delRes.Success)
                    {
                        await LoadAccountsAsync();
                        AppDialog.ShowSuccess(ParentForm, "Đã xóa tài khoản", delRes.Message);
                    }
                    else
                    {
                        AppDialog.ShowWarning(ParentForm, "Không thể xóa tài khoản", delRes.Message);
                    }
                }
            }
        };

        dgvAccounts.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                string text = e.Value.ToString() ?? "";
                if (text.Contains("Hoạt động"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    e.CellStyle.Font = new Font(dgvAccounts.Font, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.Font = new Font(dgvAccounts.Font, FontStyle.Bold);
                }
            }
            else if (e.ColumnIndex == 4 && e.Value != null)
            {
                string role = e.Value.ToString() ?? "";
                if (role.Contains("Admin"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235);
                    e.CellStyle.Font = new Font(dgvAccounts.Font, FontStyle.Bold);
                }
            }
        };

        // 2. Tab 2 Events (Ma trận phân quyền lưu SQLite & áp dụng lên MainForm Sidebar)
        dgvPermissions.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
                e.CellStyle.Padding = new Padding(12, 0, 0, 0);
                return;
            }

            if (e.Value == null) return;
            string val = e.Value.ToString()?.Trim() ?? "";

            if (val.Contains("Toàn quyền"))
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
            }
            else if (val.Contains("Chỉ xem"))
            {
                e.CellStyle.BackColor = Color.FromArgb(219, 234, 254);
                e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(241, 245, 249);
                e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            }
        };

        dgvPermissions.CellClick += (s, e) =>
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0) return;

            if (e.ColumnIndex == 1)
            {
                AppDialog.ShowInfo(ParentForm, "Quyền Admin cố định", "Vai trò Admin luôn có Toàn quyền trên toàn bộ các phân hệ của hệ thống.");
                return;
            }

            var cell = dgvPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string cur = cell.Value?.ToString()?.Trim() ?? "Không có quyền";

            string nextVal = cur switch
            {
                "Toàn quyền" => "Chỉ xem",
                "Chỉ xem" => "Không có quyền",
                _ => "Toàn quyền"
            };

            cell.Value = nextVal;

            if (dgvPermissions.Rows[e.RowIndex].Tag is RbacMatrixRowDto model)
            {
                switch (e.ColumnIndex)
                {
                    case 2: model.ManagerAccess = nextVal; break;
                    case 3: model.AcademicAccess = nextVal; break;
                    case 4: model.CounselorAccess = nextVal; break;
                    case 5: model.AccountantAccess = nextVal; break;
                    case 6: model.TeacherAccess = nextVal; break;
                }
            }
        };

        btnResetMatrix.Click += async (s, e) =>
        {
            _matrixRows = await _rbacService.ResetSidebarMatrixToDefaultAsync();
            BindMatrixGrid();
            if (FindForm() is MainForm mf)
            {
                await mf.RefreshSidebarPermissionsAsync();
            }
            AppDialog.ShowInfo(ParentForm, "Khôi phục phân quyền", "Đã khôi phục ma trận phân quyền về mặc định trong cơ sở dữ liệu.");
        };

        btnSaveRoles.Click += async (s, e) =>
        {
            var res = await _rbacService.SaveSidebarMatrixAsync(_matrixRows, AppSession.UserId);
            if (res.Success)
            {
                if (FindForm() is MainForm mf)
                {
                    await mf.RefreshSidebarPermissionsAsync();
                }
                AppDialog.ShowSuccess(ParentForm, "Lưu phân quyền thành công", res.Message);
            }
            else
            {
                AppDialog.ShowError(ParentForm, "Lỗi lưu phân quyền", res.Message);
            }
        };

        // 3. Tab 3 Events (Cập nhật hồ sơ cá nhân xuống SQLite & Đổi mật khẩu DB thật)
        btnSaveProf.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập họ và tên.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập số điện thoại.");
                txtPhone.Focus();
                return;
            }

            var res = await _userService.UpdateOwnProfileAsync(
                AppSession.UserId,
                txtFullName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPhone.Text.Trim());

            if (!res.Success)
            {
                AppDialog.ShowError(ParentForm, "Lỗi cập nhật hồ sơ", res.Message);
                return;
            }

            AppSession.FullName = txtFullName.Text.Trim();
            AppSession.Phone = txtPhone.Text.Trim();
            AppSession.Email = txtEmail.Text.Trim();
            AppSession.JobTitle = txtJobTitle.Text.Trim();

            BindUserProfileToUi();
            AppDialog.ShowSuccess(ParentForm, "Cập nhật hồ sơ", res.Message);
        };

        btnCancelProf.Click += (s, e) =>
        {
            BindUserProfileToUi();

        };

        chkShowPassword.CheckedChanged += (s, e) =>
        {
            bool show = chkShowPassword.Checked;
            txtCurrentPass.UseSystemPasswordChar = !show;
            txtNewPass.UseSystemPasswordChar = !show;
            txtConfirmPass.UseSystemPasswordChar = !show;
        };

        btnSavePass.Click += async (s, e) =>
        {
            string cur = txtCurrentPass.Text.Trim();
            string newP = txtNewPass.Text.Trim();
            string conf = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(cur))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập mật khẩu hiện tại.");
                txtCurrentPass.Focus();
                return;
            }

            if (newP.Length < 6)
            {
                AppDialog.ShowError(ParentForm, "Mật khẩu yếu", "Mật khẩu mới phải có độ dài tối thiểu 6 ký tự.");
                txtNewPass.Focus();
                return;
            }

            if (newP == cur)
            {
                AppDialog.ShowError(ParentForm, "Mật khẩu trùng lặp", "Mật khẩu mới không được trùng với mật khẩu hiện tại.");
                txtNewPass.Focus();
                return;
            }

            if (newP != conf)
            {
                AppDialog.ShowError(ParentForm, "Xác nhận không khớp", "Mật khẩu xác nhận không trùng khớp với mật khẩu mới.");
                txtConfirmPass.Focus();
                return;
            }

            var res = await _userService.ChangePasswordSelfAsync(AppSession.UserId, cur, newP, conf);
            if (res.Success)
            {
                txtCurrentPass.Text = "";
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
                AppDialog.ShowSuccess(ParentForm, "Đổi mật khẩu thành công", res.Message);
            }
            else
            {
                AppDialog.ShowError(ParentForm, "Đổi mật khẩu thất bại", res.Message);
            }
        };

        btnCancelPass.Click += (s, e) =>
        {
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";
        };
    }
}
