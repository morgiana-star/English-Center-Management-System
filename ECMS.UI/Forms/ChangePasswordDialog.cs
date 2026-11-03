using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Business.Session;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class ChangePasswordDialog : Form
{
    private readonly IUserService _userService;

    private ModernTextBox txtOldPassword = null!;
    private ModernTextBox txtNewPassword = null!;
    private ModernTextBox txtConfirmPassword = null!;
    private CheckBox chkShowPassword = null!;
    private Label lblStrength = null!;
    private CustomButton btnSave = null!;
    private CustomButton btnCancel = null!;

    public ChangePasswordDialog(IUserService? userService = null)
    {
        _userService = userService ?? new UserService();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        var currentUser = SessionManager.CurrentUser;

        Text = "ECMS - Đổi mật khẩu cá nhân";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(500, 570);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(15, 15),
            Size = new Size(470, 540),
            CornerRadius = 16,
            EnableShadow = true
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = "ĐỔI MẬT KHẨU CÁ NHÂN",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Cập nhật mật khẩu bảo mật mới cho phiên làm việc của bạn",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // User info summary panel
        var pnlUser = new RoundedPanel
        {
            Location = new Point(20, 68),
            Size = new Size(430, 65),
            CornerRadius = 8,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1,
            BackColor = Color.FromArgb(248, 250, 252)
        };

        var lblUser = new Label
        {
            Text = $"👤 Người dùng: {currentUser?.FullName ?? "N/A"} ({currentUser?.Username ?? "N/A"})",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(12, 12),
            AutoSize = true
        };

        var lblRole = new Label
        {
            Text = $"🏷️ Quyền hạn: {currentUser?.RoleName ?? "Chưa xác định"}",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(12, 36),
            AutoSize = true
        };

        pnlUser.Controls.Add(lblUser);
        pnlUser.Controls.Add(lblRole);

        // Old Password
        var lblOld = new Label
        {
            Text = "Mật khẩu hiện tại *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 145),
            AutoSize = true
        };

        txtOldPassword = new ModernTextBox
        {
            Placeholder = "Nhập mật khẩu bạn đang dùng...",
            UseSystemPasswordChar = true,
            Location = new Point(20, 168),
            Size = new Size(430, 38),
            CornerRadius = 6
        };

        // New Password
        var lblNew = new Label
        {
            Text = "Mật khẩu mới *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 218),
            AutoSize = true
        };

        txtNewPassword = new ModernTextBox
        {
            Placeholder = "Tối thiểu 6 ký tự, nên có cả chữ và số...",
            UseSystemPasswordChar = true,
            Location = new Point(20, 241),
            Size = new Size(430, 38),
            CornerRadius = 6
        };
        txtNewPassword.TextChanged += (s, e) => UpdateStrengthIndicator();

        // Strength label
        lblStrength = new Label
        {
            Text = string.Empty,
            Font = ThemeColors.FontCaption,
            Location = new Point(20, 282),
            Size = new Size(430, 20),
            AutoSize = false
        };

        // Confirm Password
        var lblConfirm = new Label
        {
            Text = "Xác nhận mật khẩu mới *",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 305),
            AutoSize = true
        };

        txtConfirmPassword = new ModernTextBox
        {
            Placeholder = "Nhập lại chính xác mật khẩu mới...",
            UseSystemPasswordChar = true,
            Location = new Point(20, 328),
            Size = new Size(430, 38),
            CornerRadius = 6
        };

        // Show/Hide Password Checkbox
        chkShowPassword = new CheckBox
        {
            Text = "Hiển thị ký tự mật khẩu",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 375),
            Size = new Size(250, 24),
            Cursor = Cursors.Hand
        };
        chkShowPassword.CheckedChanged += (s, e) =>
        {
            bool hide = !chkShowPassword.Checked;
            txtOldPassword.UseSystemPasswordChar = hide;
            txtNewPassword.UseSystemPasswordChar = hide;
            txtConfirmPassword.UseSystemPasswordChar = hide;
        };

        // Policy Note
        var lblPolicy = new Label
        {
            Text = "💡 Yêu cầu an toàn: Mật khẩu mới phải khác mật khẩu hiện tại và dài tối thiểu 6 ký tự. Mọi hành vi đổi mật khẩu đều được ghi vào Audit Log.",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextMuted,
            Location = new Point(20, 410),
            Size = new Size(430, 40)
        };

        // Action Buttons
        btnSave = new CustomButton
        {
            Text = "LƯU MẬT KHẨU",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(180, 465),
            Size = new Size(150, 42),
            CornerRadius = 8
        };
        btnSave.Click += async (s, e) => await ExecuteChangePasswordAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(340, 465),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(pnlUser);
        card.Controls.Add(lblOld);
        card.Controls.Add(txtOldPassword);
        card.Controls.Add(lblNew);
        card.Controls.Add(txtNewPassword);
        card.Controls.Add(lblStrength);
        card.Controls.Add(lblConfirm);
        card.Controls.Add(txtConfirmPassword);
        card.Controls.Add(chkShowPassword);
        card.Controls.Add(lblPolicy);
        card.Controls.Add(btnSave);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private void UpdateStrengthIndicator()
    {
        string p = txtNewPassword.Text;
        if (string.IsNullOrEmpty(p))
        {
            lblStrength.Text = string.Empty;
            return;
        }

        if (p.Length < 6)
        {
            lblStrength.Text = "❌ Độ mạnh: Quá ngắn (Tối thiểu 6 ký tự)";
            lblStrength.ForeColor = ThemeColors.DangerText;
        }
        else
        {
            bool hasUpper = p.Any(char.IsUpper);
            bool hasLower = p.Any(char.IsLower);
            bool hasDigit = p.Any(char.IsDigit);
            bool hasSpecial = p.Any(ch => !char.IsLetterOrDigit(ch));

            int score = (hasUpper ? 1 : 0) + (hasLower ? 1 : 0) + (hasDigit ? 1 : 0) + (hasSpecial ? 1 : 0) + (p.Length >= 8 ? 1 : 0);

            if (score <= 2)
            {
                lblStrength.Text = "⚠️ Độ mạnh: Trung bình (Nên bổ sung chữ hoa, số hoặc ký tự đặc biệt)";
                lblStrength.ForeColor = ThemeColors.WarningText;
            }
            else
            {
                lblStrength.Text = "✅ Độ mạnh: Rất an toàn (Đáp ứng tiêu chuẩn bảo mật cao)";
                lblStrength.ForeColor = ThemeColors.SuccessText;
            }
        }
    }

    private async Task ExecuteChangePasswordAsync()
    {
        var currentUser = SessionManager.CurrentUser;
        if (currentUser == null)
        {
            MessageBox.Show("Phiên đăng nhập đã hết hạn. Vui lòng đăng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string oldPass = txtOldPassword.Text;
        string newPass = txtNewPassword.Text;
        string confirmPass = txtConfirmPassword.Text;

        btnSave.Enabled = false;

        try
        {
            var (success, message) = await _userService.ChangePasswordSelfAsync(currentUser.UserId, oldPass, newPass, confirmPass);
            if (!success)
            {
                MessageBox.Show(message, "Thông báo kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }

            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi trong quá trình đổi mật khẩu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = true;
        }
    }
}
