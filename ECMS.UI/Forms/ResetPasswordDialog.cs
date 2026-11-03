using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class ResetPasswordDialog : Form
{
    private readonly UserListItemDto _targetUser;
    private readonly IUserService _userService;

    private RadioButton radDefaultPassword = null!;
    private RadioButton radCustomPassword = null!;
    private ModernTextBox txtCustomPassword = null!;
    private ModernTextBox txtReason = null!;
    private CustomButton btnConfirm = null!;
    private CustomButton btnCancel = null!;

    public const string DefaultSystemPassword = "Ecms@2026";

    public ResetPasswordDialog(UserListItemDto targetUser, IUserService? userService = null)
    {
        _targetUser = targetUser ?? throw new ArgumentNullException(nameof(targetUser));
        _userService = userService ?? new UserService();

        InitializeComponents();
    }

    private void InitializeComponents()
    {
        Text = $"ECMS - Đặt lại mật khẩu cho { _targetUser.Username }";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(520, 570);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(15, 15),
            Size = new Size(490, 540),
            CornerRadius = 16,
            EnableShadow = true
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = "ĐẶT LẠI MẬT KHẨU TÀI KHOẢN (RESET)",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(180, 83, 9), // Amber 700
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Khôi phục quyền truy cập, xóa bộ đếm đăng nhập sai và mở khóa tài khoản",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // User Info Summary Card
        var pnlUserInfo = new RoundedPanel
        {
            Location = new Point(20, 70),
            Size = new Size(450, 85),
            CornerRadius = 8,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1,
            BackColor = Color.FromArgb(248, 250, 252)
        };

        var lblUserHeader = new Label
        {
            Text = $"👤 Tài khoản: {_targetUser.Username}  |  Họ tên: {_targetUser.FullName}",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(12, 12),
            AutoSize = true
        };

        var lblRoleHeader = new Label
        {
            Text = $"🏷️ Vai trò: {_targetUser.RoleName}  |  Trạng thái: {_targetUser.StatusText}",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(12, 36),
            AutoSize = true
        };

        var lblLockoutInfo = new Label
        {
            Text = _targetUser.FailedLoginAttempts > 0 
                ? $"⚠️ Số lần nhập sai: {_targetUser.FailedLoginAttempts} lần (Sẽ được reset về 0)" 
                : "✅ Trạng thái mật khẩu bình thường (Chưa bị khóa brute-force)",
            Font = ThemeColors.FontCaption,
            ForeColor = _targetUser.FailedLoginAttempts > 0 ? ThemeColors.WarningText : ThemeColors.SuccessText,
            Location = new Point(12, 60),
            AutoSize = true
        };

        pnlUserInfo.Controls.Add(lblUserHeader);
        pnlUserInfo.Controls.Add(lblRoleHeader);
        pnlUserInfo.Controls.Add(lblLockoutInfo);

        // Options Radio
        var lblOptionTitle = new Label
        {
            Text = "Chọn phương thức thiết lập mật khẩu mới:",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 170),
            AutoSize = true
        };

        radDefaultPassword = new RadioButton
        {
            Text = $"Đặt về mật khẩu mặc định của hệ thống:  \"{DefaultSystemPassword}\"",
            Checked = true,
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 195),
            Size = new Size(450, 26),
            Cursor = Cursors.Hand
        };
        radDefaultPassword.CheckedChanged += (s, e) =>
        {
            txtCustomPassword.Enabled = !radDefaultPassword.Checked;
            if (radDefaultPassword.Checked)
            {
                txtCustomPassword.Text = string.Empty;
            }
        };

        radCustomPassword = new RadioButton
        {
            Text = "Chỉ định một mật khẩu cụ thể khác:",
            Checked = false,
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 225),
            Size = new Size(450, 26),
            Cursor = Cursors.Hand
        };

        txtCustomPassword = new ModernTextBox
        {
            Placeholder = "Nhập mật khẩu mới (Tối thiểu 6 ký tự)...",
            Location = new Point(40, 255),
            Size = new Size(430, 38),
            CornerRadius = 6,
            UseSystemPasswordChar = true,
            Enabled = false
        };

        // Reason Input
        var lblReason = new Label
        {
            Text = "Lý do đặt lại mật khẩu (Ghi vào nhật ký Audit Log):",
            Font = ThemeColors.FontBodyBold,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, 310),
            AutoSize = true
        };

        txtReason = new ModernTextBox
        {
            Placeholder = "Ví dụ: Nhân viên quên mật khẩu, cấp lại quyền truy cập...",
            Location = new Point(20, 335),
            Size = new Size(450, 38),
            CornerRadius = 6,
            Text = "Yêu cầu cấp lại mật khẩu từ nhân sự"
        };

        // Notice Panel
        var lblNotice = new Label
        {
            Text = "💡 Lưu ý an toàn: Mật khẩu mới sẽ được mã hóa an toàn bằng chuẩn BCrypt. Sau khi reset thành công, bạn nên nhắc người dùng tự đổi lại mật khẩu cá nhân ở lần đăng nhập tiếp theo.",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextMuted,
            Location = new Point(20, 395),
            Size = new Size(450, 50)
        };

        // Action Buttons
        btnConfirm = new CustomButton
        {
            Text = "XÁC NHẬN RESET",
            NormalColor = Color.FromArgb(217, 119, 6), // Amber 600
            HoverColor = Color.FromArgb(180, 83, 9), // Amber 700
            Location = new Point(190, 465),
            Size = new Size(160, 42),
            CornerRadius = 8
        };
        btnConfirm.Click += async (s, e) => await ExecuteResetPasswordAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(360, 465),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(pnlUserInfo);
        card.Controls.Add(lblOptionTitle);
        card.Controls.Add(radDefaultPassword);
        card.Controls.Add(radCustomPassword);
        card.Controls.Add(txtCustomPassword);
        card.Controls.Add(lblReason);
        card.Controls.Add(txtReason);
        card.Controls.Add(lblNotice);
        card.Controls.Add(btnConfirm);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private async Task ExecuteResetPasswordAsync()
    {
        try
        {
            string passwordToSet = radDefaultPassword.Checked
                ? DefaultSystemPassword
                : txtCustomPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(passwordToSet))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới cần thiết lập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordToSet.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có tối thiểu 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = string.IsNullOrWhiteSpace(txtReason.Text) 
                ? "Quản trị viên thiết lập lại mật khẩu" 
                : txtReason.Text.Trim();

            btnConfirm.Enabled = false;

            var (success, message) = await _userService.ResetPasswordByAdminAsync(_targetUser.UserId, passwordToSet, reason);
            if (!success)
            {
                MessageBox.Show(message, "Thông báo kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConfirm.Enabled = true;
                return;
            }

            MessageBox.Show(
                $"{message}\n\nMật khẩu mới: {passwordToSet}\nTài khoản đã được gỡ bỏ khóa và có thể đăng nhập ngay.",
                "Reset mật khẩu thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi trong quá trình reset mật khẩu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnConfirm.Enabled = true;
        }
    }
}
