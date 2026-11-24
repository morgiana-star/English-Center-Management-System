using System;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ForceChangePasswordDialog : Form
{
    private readonly IUserService _userService = new UserService();
    private readonly int _userId;
    private readonly string _currentPassword;

    public ForceChangePasswordDialog() : this(0, "user", "Người dùng", "12345678")
    {
    }

    public ForceChangePasswordDialog(int userId, string username, string fullName, string currentPassword)
    {
        InitializeComponent();
        _userId = userId;
        _currentPassword = currentPassword;

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        lblAccountInfo.Text = $"Tài khoản: {username} ({fullName})";
        WireEvents();
    }

    private void WireEvents()
    {
        chkShowPassword.CheckedChanged += (s, e) =>
        {
            bool show = chkShowPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        };

        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnConfirm.Click += async (s, e) =>
        {
            string newPass = txtNewPassword.Text.Trim();
            string confPass = txtConfirmPassword.Text.Trim();

            if (newPass.Length < 6)
            {
                ShowInlineError("Mật khẩu mới phải có tối thiểu 6 ký tự.");
                txtNewPassword.Focus();
                return;
            }

            if (newPass == _currentPassword)
            {
                ShowInlineError("Mật khẩu mới không được trùng mật khẩu mặc định hiện tại.");
                txtNewPassword.Focus();
                return;
            }

            if (newPass != confPass)
            {
                ShowInlineError("Xác nhận mật khẩu mới không trùng khớp.");
                txtConfirmPassword.Focus();
                return;
            }

            btnConfirm.Enabled = false;
            try
            {
                var res = await _userService.ChangePasswordSelfAsync(_userId, _currentPassword, newPass, confPass);
                if (!res.Success)
                {
                    ShowInlineError(res.Message);
                    return;
                }

                AppDialog.ShowSuccess(this, "Đổi mật khẩu thành công",
                    "Mật khẩu mới đã được cập nhật. Bạn sẽ được chuyển vào hệ thống ngay bây giờ.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowInlineError($"Lỗi cập nhật mật khẩu: {ex.Message}");
            }
            finally
            {
                btnConfirm.Enabled = true;
            }
        };
    }

    private void ShowInlineError(string message)
    {
        lblError.Text = $"* {message}";
        lblError.Visible = true;
    }
}
