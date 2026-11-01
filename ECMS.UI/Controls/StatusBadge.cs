using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public enum BadgeVariant
{
    Success,
    Warning,
    Danger,
    Info,
    Neutral
}

/// <summary>
/// Huy hiệu trạng thái (Status Badge) dạng viên thuốc (Pill), chuẩn độ tương phản WCAG
/// </summary>
public class StatusBadge : Label
{
    private BadgeVariant _variant = BadgeVariant.Info;

    public BadgeVariant Variant
    {
        get => _variant;
        set
        {
            _variant = value;
            UpdateColors();
            Invalidate();
        }
    }

    public StatusBadge()
    {
        AutoSize = false;
        Font = ThemeColors.FontBadge;
        TextAlign = ContentAlignment.MiddleCenter;
        Size = new Size(110, 26);
        DoubleBuffered = true;
        UpdateColors();
    }

    private void UpdateColors()
    {
        switch (_variant)
        {
            case BadgeVariant.Success:
                BackColor = ThemeColors.SuccessBg;
                ForeColor = ThemeColors.SuccessText;
                break;
            case BadgeVariant.Warning:
                BackColor = ThemeColors.WarningBg;
                ForeColor = ThemeColors.WarningText;
                break;
            case BadgeVariant.Danger:
                BackColor = ThemeColors.DangerBg;
                ForeColor = ThemeColors.DangerText;
                break;
            case BadgeVariant.Info:
                BackColor = ThemeColors.InfoBg;
                ForeColor = ThemeColors.InfoText;
                break;
            default:
                BackColor = Color.FromArgb(241, 245, 249);
                ForeColor = Color.FromArgb(71, 85, 105);
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        int radius = Height / 2; // Pill shape (viên thuốc)

        using var path = CreatePillPath(rect, radius);
        using var brush = new SolidBrush(BackColor);
        g.FillPath(brush, path);

        TextRenderer.DrawText(
            g,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private GraphicsPath CreatePillPath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 90, 180);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
        path.CloseFigure();
        return path;
    }
}
