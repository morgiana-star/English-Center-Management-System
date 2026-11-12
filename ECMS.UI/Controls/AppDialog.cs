using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public enum AppDialogType
{
    Info,
    Success,
    Warning,
    Danger
}

/// <summary>
/// Hộp thoại thông báo / xác nhận chuẩn theo Figma Image 4 (Phản hồi & phòng lỗi).
/// </summary>
public class AppDialog : Form
{
    private readonly AppButton _btnPrimary;
    private readonly AppButton _btnSecondary;

    public AppDialog(
        string title,
        string message,
        AppDialogType type = AppDialogType.Info,
        string primaryButtonText = "Xác nhận",
        string secondaryButtonText = "Hủy",
        bool showSecondary = true)
    {
        Text = title;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(480, 220);
        BackColor = Color.White;
        Font = FigmaTheme.Content;

        // Top decorative accent / status bar
        Color accentColor = type switch
        {
            AppDialogType.Success => FigmaTheme.Success,
            AppDialogType.Warning => FigmaTheme.Warning,
            AppDialogType.Danger => FigmaTheme.Danger,
            _ => FigmaTheme.Info
        };

        var pnlTopStripe = new Panel
        {
            Dock = DockStyle.Top,
            Height = 4,
            BackColor = accentColor
        };
        Controls.Add(pnlTopStripe);

        var lblIcon = new Label
        {
            Text = type switch
            {
                AppDialogType.Success => "✓",
                AppDialogType.Warning => "!",
                AppDialogType.Danger => "✕",
                _ => "ℹ"
            },
            Font = new Font("Segoe UI", 20f, FontStyle.Bold),
            ForeColor = accentColor,
            Size = new Size(40, 40),
            Location = new Point(24, 24),
            TextAlign = ContentAlignment.TopCenter
        };
        Controls.Add(lblIcon);

        var lblTitle = new Label
        {
            Text = title,
            Font = FigmaTheme.Section,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(72, 24),
            Size = new Size(380, 26)
        };
        Controls.Add(lblTitle);

        var lblMessage = new Label
        {
            Text = message,
            Font = FigmaTheme.Content,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(72, 54),
            Size = new Size(380, 90)
        };
        Controls.Add(lblMessage);

        // Bottom Action Bar
        var pnlBottom = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = Color.FromArgb(248, 250, 252)
        };

        var pnlDivider = new Panel
        {
            Dock = DockStyle.Top,
            Height = 1,
            BackColor = FigmaTheme.Border
        };
        pnlBottom.Controls.Add(pnlDivider);

        _btnPrimary = new AppButton
        {
            Text = primaryButtonText,
            ButtonStyle = type == AppDialogType.Danger ? AppButtonStyle.Danger : AppButtonStyle.Primary,
            Size = new Size(130, 36),
            Location = new Point(330, 12),
            DialogResult = DialogResult.OK
        };
        pnlBottom.Controls.Add(_btnPrimary);

        _btnSecondary = new AppButton
        {
            Text = secondaryButtonText,
            ButtonStyle = AppButtonStyle.Secondary,
            Size = new Size(100, 36),
            Location = new Point(220, 12),
            Visible = showSecondary,
            DialogResult = DialogResult.Cancel
        };
        pnlBottom.Controls.Add(_btnSecondary);

        AcceptButton = _btnPrimary;
        CancelButton = _btnSecondary;

        Controls.Add(pnlBottom);
    }

    public static DialogResult ShowConfirm(IWin32Window? owner, string title, string message, string confirmText = "Đồng ý", string cancelText = "Hủy", AppDialogType type = AppDialogType.Warning)
    {
        using var dlg = new AppDialog(title, message, type, confirmText, cancelText, true);
        return dlg.ShowDialog(owner);
    }

    public static void ShowSuccess(IWin32Window? owner, string title, string message, string closeText = "Đóng")
    {
        using var dlg = new AppDialog(title, message, AppDialogType.Success, closeText, "", false);
        dlg.ShowDialog(owner);
    }

    public static void ShowError(IWin32Window? owner, string title, string message, string closeText = "Đóng")
    {
        using var dlg = new AppDialog(title, message, AppDialogType.Danger, closeText, "", false);
        dlg.ShowDialog(owner);
    }
}
