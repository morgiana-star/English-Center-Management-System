using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public enum BadgeType
{
    Success,
    Warning,
    Danger,
    Neutral,
    Info
}

/// <summary>
/// Huy hiệu trạng thái theo chuẩn Figma (Giai đoạn 2 / 02)
/// </summary>
public class AppBadge : Label
{
    private BadgeType _type = BadgeType.Success;

    public BadgeType Type
    {
        get => _type;
        set
        {
            _type = value;
            UpdateColors();
            Invalidate();
        }
    }

    public AppBadge()
    {
        AutoSize = false;
        Font = FigmaTheme.FontBadge;
        TextAlign = ContentAlignment.MiddleCenter;
        Size = new Size(100, 24);
        DoubleBuffered = true;
        UpdateColors();
    }

    private void UpdateColors()
    {
        switch (_type)
        {
            case BadgeType.Success:
                BackColor = FigmaTheme.SuccessBg;
                ForeColor = FigmaTheme.Success;
                break;
            case BadgeType.Warning:
                BackColor = FigmaTheme.WarningBg;
                ForeColor = ColorTranslator.FromHtml("#B45309"); // Amber 700
                break;
            case BadgeType.Danger:
                BackColor = FigmaTheme.DangerBg;
                ForeColor = FigmaTheme.Danger;
                break;
            case BadgeType.Info:
                BackColor = FigmaTheme.InfoBg;
                ForeColor = ColorTranslator.FromHtml("#0284C7"); // Sky 600
                break;
            default:
                BackColor = FigmaTheme.ReadOnlyBg;
                ForeColor = FigmaTheme.TextSecondary;
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        int radius = 4;

        using var path = CreateRoundedRectangle(rect, radius);
        using (var brush = new SolidBrush(BackColor))
        {
            g.FillPath(brush, path);
        }

        TextRenderer.DrawText(
            g,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
    {
        var path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
