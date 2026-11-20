using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Business.Session;

namespace ECMS.UI.Forms;

public partial class LoginForm : Form
{
    private readonly IAuthService _authService = new AuthService();
    private readonly IUserService _userService = new UserService();

    private static readonly Dictionary<string, string> UsernameAliases = new(StringComparer.OrdinalIgnoreCase)
    {
        ["minhquan.admin"] = "admin",
        ["hoanganh.gv"] = "teacher",
        ["thao.kt"] = "accountant",
        ["academic.aa"] = "academic"
    };

    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        if (txtUsername.Text == "appTextBox1") txtUsername.Text = "";
        if (txtPassword.Text == "appTextBox2") txtPassword.Text = "";
    }

    private void chkShowPass_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            lblError.Text = "* Vui lòng nhập đầy đủ tài khoản và mật khẩu!";
            lblError.Visible = true;
            return;
        }

        btnLogin.Enabled = false;
        Cursor = Cursors.WaitCursor;

        try
        {
            var result = await _authService.LoginAsync(username, password);

            // Hỗ trợ tên đăng nhập tắt quen thuộc nếu tài khoản gõ chưa tồn tại trực tiếp
            if (!result.Success && UsernameAliases.TryGetValue(username, out string? mappedUsername))
            {
                var retryResult = await _authService.LoginAsync(mappedUsername, password);
                if (retryResult.Success || !retryResult.Message.Contains("không chính xác"))
                {
                    result = retryResult;
                }
            }

            if (!result.Success || result.Session == null)
            {
                lblError.Text = $"* {result.Message}";
                lblError.Visible = true;
                txtPassword.Focus();
                txtPassword.SelectAll();
                return;
            }

            var session = result.Session;

            // Đã loại bỏ vai trò Học viên & Phụ huynh khỏi cổng nội bộ
            if (session.RoleCode is "ROLE_STU" or "ROLE_PAR")
            {
                lblError.Text = "* Tài khoản Học viên / Phụ huynh không có quyền truy cập hệ thống quản trị nội bộ!";
                lblError.Visible = true;
                return;
            }

            // Đồng bộ phiên đăng nhập tầng Business và tầng UI
            SessionManager.SetSession(session);

            var detail = await _userService.GetUserByIdAsync(session.UserId);
            string displayName = session.FullName;
            if (string.IsNullOrWhiteSpace(displayName) || displayName.Equals(session.Username, StringComparison.OrdinalIgnoreCase))
            {
                displayName = session.RoleCode == "ROLE_ADMIN"
                    ? "Trần Minh Quân"
                    : (detail?.FullName ?? session.Username);
            }

            AppSession.UserId = session.UserId;
            AppSession.Username = session.Username;
            AppSession.FullName = displayName;
            AppSession.RoleCode = session.RoleCode;
            AppSession.RoleName = detail?.RoleName ?? session.RoleName;
            AppSession.Email = !string.IsNullOrWhiteSpace(detail?.Email) ? detail.Email! : $"{session.Username}@ecms.edu.vn";
            AppSession.Phone = !string.IsNullOrWhiteSpace(detail?.Phone) ? detail.Phone! : "0912 345 678";
            AppSession.SignerTitle = AppSession.GetSignerRoleTitle();
            AppSession.JobTitle = AppSession.RoleName;
            AppSession.CreatedDate = detail?.CreatedAt.ToString("dd/MM/yyyy") ?? DateTime.Now.ToString("dd/MM/yyyy");
            AppSession.LastLogin = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            AppSession.Permissions = session.Permissions;

            lblError.Visible = false;

            Hide();
            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }
        catch (Exception ex)
        {
            lblError.Text = $"* Lỗi kết nối cơ sở dữ liệu: {ex.Message}";
            lblError.Visible = true;
        }
        finally
        {
            Cursor = Cursors.Default;
            btnLogin.Enabled = true;
        }
    }
}
