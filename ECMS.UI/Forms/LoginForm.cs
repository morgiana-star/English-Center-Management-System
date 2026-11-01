using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Business.Session;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class LoginForm : Form
{
    private readonly IAuthService _authService = new AuthService();

    private ModernTextBox txtUsername = null!;
    private ModernTextBox txtPassword = null!;
    private CustomButton btnLogin = null!;
    private Label lblError = null!;

    public LoginForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        Text = "ECMS - Đăng nhập hệ thống";
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ClientSize = new Size(440, 520);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(30, 25),
            Size = new Size(380, 465),
            CornerRadius = 16,
            EnableShadow = true
        };

        var lblLogo = new Label
        {
            Text = "ECMS",
            Font = new Font("Segoe UI", 24, FontStyle.Bold),
            ForeColor = ThemeColors.Primary,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 45
        };

        var lblSubtitle = new Label
        {
            Text = "ENGLISH CENTER MANAGEMENT SYSTEM\nĐăng nhập hệ thống quản lý nội bộ",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextMuted,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(15, 55),
            Size = new Size(350, 36)
        };

        var lblUser = new Label
        {
            Text = "Tên đăng nhập:",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 105),
            AutoSize = true
        };

        txtUsername = new ModernTextBox
        {
            Placeholder = "Nhập tên đăng nhập...",
            Location = new Point(25, 130),
            Size = new Size(330, 42),
            CornerRadius = 8,
            Text = "admin"
        };

        var lblPass = new Label
        {
            Text = "Mật khẩu:",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 185),
            AutoSize = true
        };

        txtPassword = new ModernTextBox
        {
            Placeholder = "Nhập mật khẩu...",
            UseSystemPasswordChar = true,
            Location = new Point(25, 210),
            Size = new Size(330, 42),
            CornerRadius = 8,
            Text = "Admin@123"
        };

        lblError = new Label
        {
            Text = "",
            Font = new Font("Segoe UI", 9f),
            ForeColor = ThemeColors.DangerText,
            Location = new Point(25, 260),
            Size = new Size(330, 35),
            TextAlign = ContentAlignment.MiddleLeft
        };

        btnLogin = new CustomButton
        {
            Text = "ĐĂNG NHẬP HỆ THỐNG",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(25, 305),
            Size = new Size(330, 44),
            CornerRadius = 8
        };
        btnLogin.Click += async (s, e) => await HandleLoginAsync();

        var lblHint = new Label
        {
            Text = "Gợi ý: admin | manager | counselor | accountant\nacademic | teacher | student | parent\n(Mật khẩu mặc định: [Tên]@123)",
            Font = new Font("Segoe UI", 8.2f, FontStyle.Italic),
            ForeColor = ThemeColors.TextMuted,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(15, 365),
            Size = new Size(350, 55)
        };

        card.Controls.Add(lblLogo);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(lblUser);
        card.Controls.Add(txtUsername);
        card.Controls.Add(lblPass);
        card.Controls.Add(txtPassword);
        card.Controls.Add(lblError);
        card.Controls.Add(btnLogin);
        card.Controls.Add(lblHint);

        Controls.Add(card);

        AcceptButton = btnLogin;
    }

    private async Task HandleLoginAsync()
    {
        lblError.Text = "Đang kiểm tra thông tin đăng nhập...";
        lblError.ForeColor = ThemeColors.Primary;
        btnLogin.Enabled = false;

        try
        {
            var result = await _authService.LoginAsync(txtUsername.Text, txtPassword.Text);
            if (result.Success && result.Session != null)
            {
                SessionManager.SetSession(result.Session);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                lblError.ForeColor = ThemeColors.DangerText;
                lblError.Text = result.Message;
                txtPassword.Focus();
            }
        }
        catch (Exception ex)
        {
            lblError.ForeColor = ThemeColors.DangerText;
            lblError.Text = "Lỗi kết nối: " + ex.Message;
        }
        finally
        {
            btnLogin.Enabled = true;
        }
    }
}
