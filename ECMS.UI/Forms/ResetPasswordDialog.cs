using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ResetPasswordDialog : Form
{
    public string TempPassword => txtTempPassword.Text.Trim();
    public bool MustChangePassword => chkMustChangePass.Checked;
    public bool UnlockAccount => chkUnlockAccount.Checked;

    public ResetPasswordDialog() : this("admin", "Trần Minh Quân")
    {
    }

    public ResetPasswordDialog(string username, string fullName)
    {
        InitializeComponent();

        txtTargetAccount.Text = $"{username} ({fullName})";
        GeneratePassword();

        WireEvents();
    }

    private void GeneratePassword()
    {
        const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
        var rnd = new Random();
        var passChars = new char[8];
        for (int i = 0; i < passChars.Length; i++)
        {
            passChars[i] = chars[rnd.Next(chars.Length)];
        }
        txtTempPassword.Text = new string(passChars) + "@2026";
    }

    private void WireEvents()
    {
        btnGenerate.Click += (s, e) => GeneratePassword();

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
