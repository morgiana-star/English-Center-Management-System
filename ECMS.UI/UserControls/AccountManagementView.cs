using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// Code-behind của AccountManagementView (Quản trị 3 Tab: Tài khoản, Phân quyền, Cá nhân)
/// Hỗ trợ kéo thả trực quan trên WinForms Designer của Rider
/// </summary>
public partial class AccountManagementView : UserControl
{
    public AccountManagementView()
    {
        InitializeComponent();
        SetupFilters();
        PopulateMockData();
        WireUpEvents();
    }

    /// <summary>
    /// Cho phép Form chính chỉ định mở thẳng vào Tab nào (0: Tài khoản, 1: Phân quyền, 2: Cá nhân)
    /// </summary>
    public void SelectTab(int index)
    {
        if (index >= 0 && index < tabMain.TabCount)
        {
            tabMain.SelectedIndex = index;
        }
    }

    private void SetupFilters()
    {
        cboRoleFilter.Items.AddRange(new object[] { "Tất cả vai trò", "Admin", "Quản lý", "Tư vấn", "Kế toán", "Đào tạo", "Giáo viên", "Học viên", "Phụ huynh" });
        cboRoleFilter.SelectedIndex = 0;

        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Bị khóa" });
        cboStatusFilter.SelectedIndex = 1;

        cboEditRole.Items.AddRange(new object[] { "Admin", "Quản lý", "Tư vấn", "Kế toán", "Đào tạo", "Giáo viên", "Học viên", "Phụ huynh" });
        cboEditRole.SelectedIndex = 6;

        cboEditProfile.Items.AddRange(new object[] { "HV-0241 (Nguyễn Minh Anh)", "GV-0102 (Lê Thu Hà)", "NV-004 (Lê Phương Thảo)" });
        cboEditProfile.SelectedIndex = 0;
    }

    private void PopulateMockData()
    {
        // 1. Cấu hình & Dữ liệu Tab 1 (Tài khoản người dùng)
        dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập ↑", FillWeight = 26 });
        dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 30 });
        dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vai trò", FillWeight = 22 });
        dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 22 });

        dgvAccounts.Rows.Add("minhquan.admin", "Trần Minh Quân", "Admin", "✓ Hoạt động");
        dgvAccounts.Rows.Add("hoanganh.gv", "Nguyễn Hoàng Anh", "Giáo viên", "✓ Hoạt động");
        dgvAccounts.Rows.Add("thao.kt", "Lê Phương Thảo", "Kế toán", "✓ Hoạt động");
        dgvAccounts.Rows.Add("minhanh.hv", "Nguyễn Minh Anh", "Học viên", "! Bị khóa");
        dgvAccounts.Rows.Add("thuhuong.ph", "Nguyễn Thu Hương", "Phụ huynh", "✓ Hoạt động");
        dgvAccounts.ClearSelection();
        dgvAccounts.CurrentCell = null;

        // 2. Cấu hình & Dữ liệu Tab 2 (Ma trận phân quyền)
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mô-đun ↑", FillWeight = 24 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Admin", FillWeight = 9 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quản lý", FillWeight = 10 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tư vấn", FillWeight = 10 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế toán", FillWeight = 10 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đào tạo", FillWeight = 10 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 12 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên", FillWeight = 12 });
        dgvPermissions.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phụ huynh", FillWeight = 12 });

        dgvPermissions.Rows.Add("Tổng quan / Báo cáo", "Q", "X", "X", "X", "X", "X", "—", "—");
        dgvPermissions.Rows.Add("Tuyển sinh & Tư vấn", "Q", "Q", "Q", "X", "X", "—", "—", "—");
        dgvPermissions.Rows.Add("Học viên / hồ sơ", "Q", "Q", "S", "X", "Q", "X", "X bản thân", "X con");
        dgvPermissions.Rows.Add("Khóa học / Lớp học", "Q", "Q", "X", "X", "Q", "X lớp dạy", "X lớp mình", "X lớp con");
        dgvPermissions.Rows.Add("Giáo viên", "Q", "Q", "X", "—", "Q", "X bản thân", "—", "—");
        dgvPermissions.Rows.Add("Lịch học / Phòng học", "Q", "Q", "X", "X", "Q", "X lớp dạy", "X lịch mình", "X lịch con");
        dgvPermissions.Rows.Add("Điểm danh", "Q", "Q", "X", "—", "Q", "S lớp dạy", "X bản thân", "X con");
        dgvPermissions.Rows.Add("Kiểm tra & Điểm số", "Q", "Q", "X", "X", "Q", "S lớp dạy", "X bản thân", "X con");
        dgvPermissions.Rows.Add("Học phí & Thanh toán", "Q", "Q", "X", "Q", "X", "—", "X bản thân", "X con");
        dgvPermissions.Rows.Add("Tài liệu học tập", "Q", "Q", "X", "—", "Q", "S lớp dạy", "X lớp mình", "X lớp con");
        dgvPermissions.Rows.Add("Chứng chỉ", "Q", "Q", "X", "X", "Q", "X lớp dạy", "X bản thân", "X con");
        dgvPermissions.Rows.Add("Nhân viên", "Q", "Q", "—", "—", "—", "—", "—", "—");
        dgvPermissions.Rows.Add("Thông báo nội bộ", "Q", "Q", "S", "S", "S", "X", "X", "X");
        dgvPermissions.Rows.Add("Tài khoản & Phân quyền", "Q", "X", "—", "—", "—", "—", "—", "—");
        dgvPermissions.Rows.Add("Cấu hình / Sao lưu", "Q", "X", "—", "—", "—", "—", "—", "—");
        dgvPermissions.ClearSelection();
        dgvPermissions.CurrentCell = null;
    }

    private void WireUpEvents()
    {
        // Khi chọn hàng trong bảng tài khoản
        dgvAccounts.SelectionChanged += (s, e) =>
        {
            if (dgvAccounts.CurrentRow != null && dgvAccounts.CurrentRow.Index >= 0)
            {
                txtEditUsername.Text = dgvAccounts.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtEditFullName.Text = dgvAccounts.CurrentRow.Cells[1].Value?.ToString() ?? "";
                string role = dgvAccounts.CurrentRow.Cells[2].Value?.ToString() ?? "";
                string status = dgvAccounts.CurrentRow.Cells[3].Value?.ToString() ?? "";

                int idx = cboEditRole.FindStringExact(role);
                if (idx >= 0) cboEditRole.SelectedIndex = idx;

                chkEditActive.Checked = status.Contains("Hoạt động");
            }
        };

        // Tab 1 Buttons
        btnSave.Click += (s, e) => AppDialog.ShowSuccess(ParentForm, "Cập nhật tài khoản", "Đã lưu thông tin tài khoản vào cơ sở dữ liệu SQLite thành công.");
        btnDoReset.Click += (s, e) =>
        {
            // bannerResetSuccess.Visible = true;
            chkEditActive.Checked = true;
            AppDialog.ShowSuccess(ParentForm, "Đặt lại mật khẩu", "Mật khẩu tạm đã được tạo và lưu cục bộ. Tài khoản đã được mở khóa.");
        };

        // Tab 2 Buttons
        btnSaveRoles.Click += (s, e) => AppDialog.ShowSuccess(ParentForm, "Lưu phân quyền", "Đã lưu ma trận phân quyền vào SQLite thành công.");

        // Tab 3 Buttons
        btnSaveProf.Click += (s, e) =>
        {
            bannerProfileSuccess.Visible = true;
            AppDialog.ShowSuccess(ParentForm, "Cập nhật hồ sơ", "Thông tin cá nhân đã được lưu cục bộ thành công.");
        };
        btnSavePass.Click += (s, e) =>
        {
            bannerPassSuccess.Visible = true;
            AppDialog.ShowSuccess(ParentForm, "Đổi mật khẩu", "Mật khẩu cá nhân đã được thay đổi thành công.");
        };
        btnTopLogout.Click += (s, e) => PerformLogout();
    }

    private void PerformLogout()
    {
        using var dlg = new LogoutConfirmDialog();
        if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
        {
            var parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
                var login = new LoginForm();
                login.FormClosed += (s, e) => parentForm.Close();
                login.Show();
            }
        }
    }
}
