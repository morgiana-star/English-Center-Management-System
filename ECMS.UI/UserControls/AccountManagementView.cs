using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản trị Tài khoản & Phân quyền gồm 3 Tab:
/// 1. Tài khoản người dùng (Danh sách, tìm kiếm, lọc, thêm/sửa/đặt lại MK/khóa)
/// 2. Vai trò & Phân quyền (Ma trận phân quyền trực quan tương tác đổi quyền nhanh)
/// 3. Tài khoản cá nhân (Hồ sơ cá nhân & Đổi mật khẩu)
/// </summary>
public partial class AccountManagementView : UserControl
{
    private class AccountItem
    {
        public string Username { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Role { get; set; } = "Học viên";
        public string ProfileCode { get; set; } = "Không liên kết";
        public bool IsActive { get; set; } = true;
    }

    private readonly List<AccountItem> _accounts = new();
    private bool _isMatrixInitialized = false;

    public AccountManagementView()
    {
        InitializeComponent();
        InitDefaultAccounts();
        SetupFilters();
        SetupAccountsGrid();
        RefreshAccountsGrid();
        SetupPermissionsMatrix();
        LoadUserProfile();
        WireUpEvents();
    }

    /// <summary>
    /// Cho phép Form chính mở thẳng vào Tab nào (0: Tài khoản, 1: Phân quyền, 2: Cá nhân)
    /// </summary>
    public void SelectTab(int index)
    {
        if (index >= 0 && index < tabMain.TabCount)
        {
            tabMain.SelectedIndex = index;
        }
    }

    private void InitDefaultAccounts()
    {
        _accounts.Clear();
        _accounts.Add(new AccountItem
        {
            Username = "minhquan.admin",
            FullName = "Trần Minh Quân",
            Email = "minhquan@ecms.edu.vn",
            Phone = "0912 345 678",
            Role = "Admin",
            ProfileCode = "NV-001",
            IsActive = true
        });
        _accounts.Add(new AccountItem
        {
            Username = "hoanganh.gv",
            FullName = "Nguyễn Hoàng Anh",
            Email = "hoanganh.gv@ecms.edu.vn",
            Phone = "0903 112 233",
            Role = "Giáo viên",
            ProfileCode = "GV-0102",
            IsActive = true
        });
        _accounts.Add(new AccountItem
        {
            Username = "thao.kt",
            FullName = "Lê Phương Thảo",
            Email = "thao.kt@ecms.edu.vn",
            Phone = "0988 556 778",
            Role = "Kế toán",
            ProfileCode = "NV-004",
            IsActive = true
        });
        _accounts.Add(new AccountItem
        {
            Username = "minhanh.hv",
            FullName = "Nguyễn Minh Anh",
            Email = "minhanh.hv@gmail.com",
            Phone = "0934 998 877",
            Role = "Học viên",
            ProfileCode = "HV-0241",
            IsActive = false
        });
        _accounts.Add(new AccountItem
        {
            Username = "phuong.tv",
            FullName = "Vũ Mai Phương",
            Email = "phuong.tv@ecms.edu.vn",
            Phone = "0977 443 322",
            Role = "Tư vấn",
            ProfileCode = "NV-009",
            IsActive = true
        });
    }

    private void SetupFilters()
    {
        cboRoleFilter.Items.Clear();
        cboRoleFilter.Items.AddRange(new object[] { "Tất cả vai trò", "Admin", "Quản lý", "Tư vấn", "Kế toán", "Đào tạo", "Giáo viên", "Học viên" });
        cboRoleFilter.SelectedIndex = 0;

        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Đã khóa" });
        cboStatusFilter.SelectedIndex = 0;
    }

    private void SetupAccountsGrid()
    {
        dgvAccounts.Columns.Clear();

        var colUser = new DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập", FillWeight = 16, ReadOnly = true };
        var colName = new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 20, ReadOnly = true };
        var colContact = new DataGridViewTextBoxColumn { HeaderText = "Email & Số ĐT", FillWeight = 24, ReadOnly = true };
        var colRole = new DataGridViewTextBoxColumn { HeaderText = "Vai trò", FillWeight = 13, ReadOnly = true };
        var colProfile = new DataGridViewTextBoxColumn { HeaderText = "Hồ sơ liên kết", FillWeight = 14, ReadOnly = true };
        var colStatus = new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 14, ReadOnly = true };

        var colEdit = new DataGridViewButtonColumn
        {
            HeaderText = "Sửa",
            Text = "✏️ Sửa",
            UseColumnTextForButtonValue = true,
            FillWeight = 10
        };

        var colReset = new DataGridViewButtonColumn
        {
            HeaderText = "Mật khẩu",
            Text = "🔑 Đặt lại",
            UseColumnTextForButtonValue = true,
            FillWeight = 11
        };

        var colToggle = new DataGridViewButtonColumn
        {
            HeaderText = "Khóa / Mở",
            Text = "Đổi",
            UseColumnTextForButtonValue = false,
            FillWeight = 12
        };

        dgvAccounts.Columns.AddRange(colUser, colName, colContact, colRole, colProfile, colStatus, colEdit, colReset, colToggle);
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
                           a.Email.ToLowerInvariant().Contains(kw) ||
                           a.Phone.Contains(kw) ||
                           a.ProfileCode.ToLowerInvariant().Contains(kw);

            bool matchRole = roleFilter == "Tất cả vai trò" || a.Role == roleFilter;

            bool matchStatus = statusFilter == "Tất cả trạng thái" ||
                               (statusFilter == "Đang hoạt động" && a.IsActive) ||
                               (statusFilter == "Đã khóa" && !a.IsActive);

            return matchKw && matchRole && matchStatus;
        }).ToList();

        foreach (var item in filtered)
        {
            int idx = dgvAccounts.Rows.Add(
                item.Username,
                item.FullName,
                $"{item.Email} | {item.Phone}",
                item.Role,
                item.ProfileCode,
                item.IsActive ? "✓ Hoạt động" : "🔒 Đã khóa",
                "✏️ Sửa",
                "🔑 Đặt lại",
                item.IsActive ? "🔒 Khóa" : "🔓 Mở khóa"
            );
            dgvAccounts.Rows[idx].Tag = item;
        }

        dgvAccounts.ClearSelection();
        dgvAccounts.CurrentCell = null;

        // Cập nhật thống kê
        int total = _accounts.Count;
        int active = _accounts.Count(a => a.IsActive);
        int locked = _accounts.Count(a => !a.IsActive);
        int admins = _accounts.Count(a => a.Role == "Admin");

        lblAccountCountBadge.Text = $"(Hiển thị: {filtered.Count} / {total} tài khoản)";
        lblStatTotal.Text = $"👥 Tổng số: {total} tài khoản";
        lblStatActive.Text = $"🟢 Đang hoạt động: {active}";
        lblStatLocked.Text = $"🔴 Đã khóa: {locked}";
        lblStatAdmin.Text = $"🛡️ Quản trị viên: {admins}";
    }

    private void SetupPermissionsMatrix()
    {
        if (_isMatrixInitialized) return;

        dgvPermissions.Columns.Clear();
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phân hệ / Mô-đun chức năng", FillWeight = 28, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Admin", FillWeight = 10, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quản lý", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đào tạo", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tư vấn", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế toán", FillWeight = 11, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 12, ReadOnly = true });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên", FillWeight = 12, ReadOnly = true });

        LoadDefaultMatrixData();
        _isMatrixInitialized = true;
    }

    private void LoadDefaultMatrixData()
    {
        dgvPermissions.Rows.Clear();
        dgvPermissions.Rows.Add("Tổng quan / Báo cáo", "Q", "Q", "X", "—", "X", "—", "—");
        dgvPermissions.Rows.Add("Học viên / Hồ sơ", "Q", "Q", "Q", "S", "X", "X", "—");
        dgvPermissions.Rows.Add("Giáo viên", "Q", "Q", "Q", "—", "—", "X", "—");
        dgvPermissions.Rows.Add("Khóa học / Lớp học", "Q", "Q", "Q", "X", "X", "X", "X");
        dgvPermissions.Rows.Add("Lịch học / Phòng học", "Q", "Q", "Q", "X", "—", "X", "X");
        dgvPermissions.Rows.Add("Điểm danh chuyên cần", "Q", "Q", "Q", "—", "—", "S", "X");
        dgvPermissions.Rows.Add("Kiểm tra & Điểm số", "Q", "Q", "Q", "—", "—", "S", "X");
        dgvPermissions.Rows.Add("Tài liệu học tập", "Q", "Q", "Q", "—", "—", "S", "X");
        dgvPermissions.Rows.Add("Chứng chỉ & Tra cứu", "Q", "Q", "Q", "—", "—", "X", "X");
        dgvPermissions.Rows.Add("Học phí & Thanh toán", "Q", "Q", "X", "—", "Q", "—", "X");
        dgvPermissions.Rows.Add("Tài khoản & Phân quyền", "Q", "X", "—", "—", "—", "—", "—");
        dgvPermissions.Rows.Add("Cấu hình & Sao lưu", "Q", "—", "—", "—", "—", "—", "—");
        dgvPermissions.ClearSelection();
        dgvPermissions.CurrentCell = null;
    }

    private void LoadUserProfile()
    {
        txtFullName.Text = AppSession.FullName;
        txtPhone.Text = AppSession.Phone;
        txtEmail.Text = AppSession.Email;
        txtJobTitle.Text = AppSession.JobTitle;
        txtUserRole.Text = $"{AppSession.Username} · {AppSession.RoleName} (Quản trị toàn quyền hệ thống)";

        lblSummaryName.Text = AppSession.FullName;
        lblSummaryRoleBadge.Text = AppSession.RoleName.ToUpper();
        lblSummaryUsername.Text = $"@{AppSession.Username}";
        lblSummaryEmail.Text = $"✉️ Email: {AppSession.Email}";
        lblSummaryPhone.Text = $"📞 SĐT: {AppSession.Phone}";
        lblSummaryCreated.Text = $"📅 Ngày tạo: {AppSession.CreatedDate}";
        lblSummaryLastLogin.Text = $"🕒 Đăng nhập: {AppSession.LastLogin}";

        // Lấy chữ cái đầu làm avatar
        var parts = AppSession.FullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length >= 2)
        {
            lblAvatar.Text = string.Concat(parts.Select(p => p[0])).ToUpper();
            if (lblAvatar.Text.Length > 3)
                lblAvatar.Text = lblAvatar.Text.Substring(0, 3);
        }
        else if (parts.Length == 1 && parts[0].Length > 0)
        {
            lblAvatar.Text = parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
        }
        else
        {
            lblAvatar.Text = "AD";
        }
    }

    private void WireUpEvents()
    {
        // 1. Tab 1 Toolbar Events
        txtSearch.TextChanged += (s, e) => RefreshAccountsGrid();
        cboRoleFilter.SelectedIndexChanged += (s, e) => RefreshAccountsGrid();
        cboStatusFilter.SelectedIndexChanged += (s, e) => RefreshAccountsGrid();

        btnAddAccount.Click += (s, e) =>
        {
            using var dlg = new EditAccountDialog(isCreateMode: true, "", "", "Học viên", true);
            if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                if (_accounts.Any(a => a.Username.Equals(dlg.Username, StringComparison.OrdinalIgnoreCase)))
                {
                    AppDialog.ShowError(ParentForm, "Trùng tên đăng nhập", $"Tên đăng nhập '{dlg.Username}' đã tồn tại trong hệ thống. Vui lòng chọn tên khác.");
                    return;
                }

                var newAccount = new AccountItem
                {
                    Username = dlg.Username,
                    FullName = dlg.FullName,
                    Role = dlg.Role,
                    ProfileCode = dlg.Profile,
                    Email = $"{dlg.Username}@ecms.edu.vn",
                    Phone = "09xx xxx xxx",
                    IsActive = dlg.IsActive
                };

                _accounts.Add(newAccount);
                RefreshAccountsGrid();
                AppDialog.ShowSuccess(ParentForm, "Thêm tài khoản thành công", $"Tài khoản '{newAccount.Username}' ({newAccount.FullName}) với vai trò '{newAccount.Role}' đã được tạo thành công.");
            }
        };

        btnExportAccounts.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất danh sách tài khoản", "Đã xuất danh sách tài khoản người dùng ra file Excel (Accounts_Export_20261116.xlsx) thành công.");
        };

        // Click trên DataGridView Tài khoản
        dgvAccounts.CellContentClick += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            var row = dgvAccounts.Rows[e.RowIndex];
            var item = row.Tag as AccountItem;
            if (item == null) return;

            // Nút Sửa (col index 6)
            if (e.ColumnIndex == 6)
            {
                using var dlg = new EditAccountDialog(isCreateMode: false, item.Username, item.FullName, item.Role, item.IsActive);
                if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
                {
                    item.FullName = dlg.FullName;
                    item.Role = dlg.Role;
                    item.ProfileCode = dlg.Profile;
                    item.IsActive = dlg.IsActive;

                    RefreshAccountsGrid();
                    AppDialog.ShowSuccess(ParentForm, "Cập nhật tài khoản", $"Đã cập nhật thông tin tài khoản '{item.Username}' thành công.");
                }
            }
            // Nút Đặt lại MK (col index 7)
            else if (e.ColumnIndex == 7)
            {
                using var dlg = new ResetPasswordDialog(item.Username, item.FullName);
                if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
                {
                    if (dlg.UnlockAccount)
                        item.IsActive = true;

                    RefreshAccountsGrid();
                    AppDialog.ShowSuccess(ParentForm, "Đặt lại mật khẩu", $"Mật khẩu của tài khoản '{item.Username}' đã được đặt lại thành công: {dlg.TempPassword}");
                }
            }
            // Nút Khóa / Mở (col index 8)
            else if (e.ColumnIndex == 8)
            {
                if (item.Username == AppSession.Username)
                {
                    AppDialog.ShowWarning(ParentForm, "Không thể khóa", "Bạn không thể khóa tài khoản của chính mình đang đăng nhập.");
                    return;
                }

                bool nowActive = !item.IsActive;
                item.IsActive = nowActive;
                RefreshAccountsGrid();

                string msg = nowActive ? $"Tài khoản '{item.Username}' đã được mở khóa hoạt động." : $"Tài khoản '{item.Username}' đã bị khóa truy cập.";
                AppDialog.ShowSuccess(ParentForm, "Thay đổi trạng thái", msg);
            }
        };

        // Format màu cho dgvAccounts
        dgvAccounts.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            // Cột Trạng thái (col 5)
            if (e.ColumnIndex == 5 && e.Value != null)
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
            // Cột Vai trò (col 3)
            else if (e.ColumnIndex == 3 && e.Value != null)
            {
                string role = e.Value.ToString() ?? "";
                if (role == "Admin")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235);
                    e.CellStyle.Font = new Font(dgvAccounts.Font, FontStyle.Bold);
                }
            }
        };

        // 2. Tab 2 Events (Ma trận phân quyền)
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

            if (val == "Q" || val.StartsWith("Q"))
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231); // Light green
                e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);   // Dark green
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
            }
            else if (val == "S" || val.StartsWith("S"))
            {
                e.CellStyle.BackColor = Color.FromArgb(219, 234, 254); // Light blue
                e.CellStyle.ForeColor = Color.FromArgb(30, 64, 175);   // Dark blue
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
            }
            else if (val == "X" || val.StartsWith("X"))
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 243, 199); // Light amber
                e.CellStyle.ForeColor = Color.FromArgb(146, 64, 14);   // Dark amber
                e.CellStyle.Font = new Font(dgvPermissions.Font, FontStyle.Bold);
            }
            else if (val == "—")
            {
                e.CellStyle.BackColor = Color.FromArgb(241, 245, 249); // Light slate
                e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184); // Slate
            }
        };

        // Click đổi quyền nhanh trên ô ma trận
        dgvPermissions.CellClick += (s, e) =>
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0) return;

            // Cột 1 là Admin -> luôn Q
            if (e.ColumnIndex == 1)
            {
                AppDialog.ShowInfo(ParentForm, "Quyền Admin cố định", "Vai trò Quản trị viên (Admin) luôn sở hữu toàn quyền quản trị (Q) đối với tất cả phân hệ.");
                return;
            }

            var cell = dgvPermissions.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string cur = cell.Value?.ToString()?.Trim() ?? "—";

            // Chu trình chuyển đổi: Q -> S -> X -> — -> Q
            string nextVal = cur switch
            {
                "Q" => "S",
                "S" => "X",
                "X" => "—",
                _ => "Q"
            };

            cell.Value = nextVal;
        };

        btnResetMatrix.Click += (s, e) =>
        {
            LoadDefaultMatrixData();
            AppDialog.ShowInfo(ParentForm, "Khôi phục phân quyền", "Đã khôi phục ma trận phân quyền về trạng thái mặc định của hệ thống.");
        };

        btnSaveRoles.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Lưu phân quyền thành công", "Đã lưu ma trận phân quyền mới vào cơ sở dữ liệu hệ thống.");
        };

        // 3. Tab 3 Events (Hồ sơ cá nhân & Đổi mật khẩu)
        btnSaveProf.Click += (s, e) =>
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

            AppSession.FullName = txtFullName.Text.Trim();
            AppSession.Phone = txtPhone.Text.Trim();
            AppSession.Email = txtEmail.Text.Trim();
            AppSession.JobTitle = txtJobTitle.Text.Trim();

            LoadUserProfile();
            bannerProfileSuccess.Visible = true;
            AppDialog.ShowSuccess(ParentForm, "Cập nhật hồ sơ", "Thông tin tài khoản cá nhân đã được lưu thành công.");
        };

        btnCancelProf.Click += (s, e) =>
        {
            LoadUserProfile();
            bannerProfileSuccess.Visible = false;
        };

        chkShowPassword.CheckedChanged += (s, e) =>
        {
            bool show = chkShowPassword.Checked;
            txtCurrentPass.UseSystemPasswordChar = !show;
            txtNewPass.UseSystemPasswordChar = !show;
            txtConfirmPass.UseSystemPasswordChar = !show;
        };

        btnSavePass.Click += (s, e) =>
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

            if (newP.Length < 8)
            {
                AppDialog.ShowError(ParentForm, "Mật khẩu yếu", "Mật khẩu mới phải có độ dài tối thiểu 8 ký tự.");
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

            bannerPassSuccess.Visible = true;
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";

            AppDialog.ShowSuccess(ParentForm, "Đổi mật khẩu thành công", "Mật khẩu tài khoản của bạn đã được thay đổi thành công. Hãy sử dụng mật khẩu mới cho lần đăng nhập tiếp theo.");
        };

        btnCancelPass.Click += (s, e) =>
        {
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";
            bannerPassSuccess.Visible = false;
        };
    }
}