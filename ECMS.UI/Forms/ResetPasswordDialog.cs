using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ResetPasswordDialog : Form
{
    public int TargetUserId { get; private set; }
    public string TempPassword => txtTempPassword.Text.Trim();
    public bool MustChangePassword => chkMustChangePass.Checked;

    public ResetPasswordDialog() : this(0, "admin", "Trần Minh Quân")
    {
    }

    public ResetPasswordDialog(string username, string fullName) : this(0, username, fullName)
    {
    }

    public ResetPasswordDialog(int targetUserId, string username, string fullName)
    {
        InitializeComponent();
        TargetUserId = targetUserId;

        txtTargetAccount.Text = $"{username} ({fullName})";

        chkMustChangePass.Checked = true;
        GeneratePassword();

        WireEvents();
    }

    private void GeneratePassword()
    {
        txtTempPassword.Text = "12345678";
    }

    private void WireEvents()
    {


        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnConfirm.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtTempPassword.Text))
            {
                AppDialog.ShowError(this, "Thiếu thông tin", "Vui lòng nhập mật khẩu tạm thời.");
                txtTempPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
