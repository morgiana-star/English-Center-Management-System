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
/// Hộp thoại thông báo / xác nhận chuẩn hệ thống ECMS (hỗ trợ mở trên WinForms Designer).
/// </summary>
public partial class AppDialog : Form
{
    public AppDialog() : this("Thông báo", "Nội dung thông báo chi tiết hiển thị tại đây.", AppDialogType.Info, "Đóng", "Hủy", false)
    {
    }

    public AppDialog(
        string title,
        string message,
        AppDialogType type = AppDialogType.Info,
        string primaryButtonText = "Xác nhận",
        string secondaryButtonText = "Hủy",
        bool showSecondary = true)
    {
        InitializeComponent();

        Text = title;
        lblTitle.Text = title;
        lblMessage.Text = message;

        Color accentColor = type switch
        {
            AppDialogType.Success => FigmaTheme.Success,
            AppDialogType.Warning => FigmaTheme.Warning,
            AppDialogType.Danger => FigmaTheme.Danger,
            _ => FigmaTheme.Info
        };

        pnlTopStripe.BackColor = accentColor;
        picIcon.Image = LoadDialogIcon(type);

        // Tự động căn vị trí lblMessage ngay dưới lblTitle để không bao giờ che phần chân chữ tiêu đề (như chữ g, y, p)
        int messageTop = Math.Max(56, lblTitle.Bottom + 4);
        lblMessage.Location = new Point(lblTitle.Left, messageTop);

        Size measuredMsg = TextRenderer.MeasureText(
            message,
            lblMessage.Font,
            new Size(lblMessage.Width, 600),
            TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl);

        int msgHeight = Math.Max(76, measuredMsg.Height + 12);
        lblMessage.Size = new Size(lblMessage.Width, msgHeight);

        int contentBottom = Math.Max(picIcon.Bottom, messageTop + msgHeight);
        int requiredClientHeight = Math.Max(236, contentBottom + pnlBottom.Height + 18);
        if (ClientSize.Height < requiredClientHeight)
        {
            ClientSize = new Size(ClientSize.Width, requiredClientHeight);
        }

        _btnPrimary.Text = primaryButtonText;
        _btnPrimary.ButtonStyle = type == AppDialogType.Danger ? AppButtonStyle.Danger : AppButtonStyle.Primary;
        _btnPrimary.Variant = type == AppDialogType.Danger ? ButtonVariant.Danger : ButtonVariant.Primary;

        _btnSecondary.Text = secondaryButtonText;
        _btnSecondary.Visible = showSecondary;

        AcceptButton = _btnPrimary;
        CancelButton = showSecondary ? _btnSecondary : _btnPrimary;
    }

    private static Image? LoadDialogIcon(AppDialogType type)
    {
        string fileName = type switch
        {
            AppDialogType.Success => "dialog-success.png",
            AppDialogType.Warning => "dialog-warning.png",
            AppDialogType.Danger => "dialog-error.png",
            _ => "dialog-info.png"
        };

        try
        {
            var asm = typeof(AppDialog).Assembly;
            string resourceName = $"ECMS.UI.Assets.ICON.{fileName}";
            using var stream = asm.GetManifestResourceStream(resourceName);
            if (stream != null)
            {
                using var img = Image.FromStream(stream);
                return new Bitmap(img);
            }

            string diskPath = System.IO.Path.Combine(AppContext.BaseDirectory, "Assets", "ICON", fileName);
            if (System.IO.File.Exists(diskPath))
            {
                using var fs = new System.IO.FileStream(diskPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                using var img = Image.FromStream(fs);
                return new Bitmap(img);
            }
        }
        catch { }

        return null;
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

    public static void ShowWarning(IWin32Window? owner, string title, string message, string closeText = "Đóng")
    {
        using var dlg = new AppDialog(title, message, AppDialogType.Warning, closeText, "", false);
        dlg.ShowDialog(owner);
    }

    public static void ShowInfo(IWin32Window? owner, string title, string message, string closeText = "Đóng")
    {
        using var dlg = new AppDialog(title, message, AppDialogType.Info, closeText, "", false);
        dlg.ShowDialog(owner);
    }

    public static void ShowError(IWin32Window? owner, string title, string message, string closeText = "Đóng")
    {
        using var dlg = new AppDialog(title, message, AppDialogType.Danger, closeText, "", false);
        dlg.ShowDialog(owner);
    }
}
