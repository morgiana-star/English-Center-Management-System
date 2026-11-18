using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class EditAccountDialog : Form
{
    public bool IsCreateMode { get; private set; }
    public string Username => txtUsername.Text.Trim();
    public string FullName => txtFullName.Text.Trim();
    public string Role => cboRole.SelectedItem?.ToString() ?? "Học viên";
    public string Profile => cboProfile.SelectedItem?.ToString() ?? "Không liên kết";
    public bool IsActive => chkActive.Checked;
    public bool RequirePassChange => chkRequirePassChange.Checked;

    public EditAccountDialog() : this(true, "", "", "Học viên", true)
    {
    }

    public EditAccountDialog(string username, string fullName, string role, bool isActive)
        : this(false, username, fullName, role, isActive)
    {
    }

    public EditAccountDialog(bool isCreateMode, string username, string fullName, string role, bool isActive)
    {
        InitializeComponent();
        IsCreateMode = isCreateMode;

        cboRole.Items.Clear();
        cboRole.Items.AddRange(new object[] { "Admin", "Quản lý", "Tư vấn", "Kế toán", "Đào tạo", "Giáo viên", "Học viên" });

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

        chkActive.Checked = isActive;
        chkRequirePassChange.Checked = isCreateMode;

        if (isCreateMode)
        {
            lblTitle.Text = "Thêm tài khoản mới";
            lblSubtitle.Text = "Tạo tài khoản người dùng và thiết lập phân quyền ban đầu";
            btnSave.Text = "Tạo tài khoản";
            txtUsername.ReadOnly = false;
        }
        else
        {
            lblTitle.Text = "Chỉnh sửa tài khoản";
            lblSubtitle.Text = "Cập nhật thông tin vai trò và phân quyền";
            btnSave.Text = "Lưu thay đổi";
            txtUsername.ReadOnly = true;
        }

        WireEvents();
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += (s, e) =>
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

            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
