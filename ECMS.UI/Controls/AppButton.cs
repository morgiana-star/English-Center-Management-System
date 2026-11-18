using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public enum ButtonVariant
{
    Primary,
    Secondary,
    Danger,
    Success
}

public enum AppButtonStyle
{
    Primary = ButtonVariant.Primary,
    Secondary = ButtonVariant.Secondary,
    Danger = ButtonVariant.Danger,
    Success = ButtonVariant.Success
}

/// <summary>
/// Nút lệnh theo quy chuẩn thiết kế Figma (Giai đoạn 2 / 01)
/// Bo góc 5px, phẳng, hỗ trợ trạng thái Hover, Focus và Disabled
/// </summary>
public class AppButton : Button
{
    private ButtonVariant _variant = ButtonVariant.Primary;
    private bool _isHovered = false;
    private bool _isPressed = false;

    public ButtonVariant Variant
    {
        get => _variant;
        set
        {
            _variant = value;
            Invalidate();
        }
    }

    public AppButtonStyle ButtonStyle
    {
        get => (AppButtonStyle)_variant;
        set
        {
            _variant = (ButtonVariant)value;
            Invalidate();
        }
    }

    public int CornerRadius { get; set; } = FigmaTheme.DefaultRadius;

    public AppButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Font = FigmaTheme.FontContentBold;
        Cursor = Cursors.Hand;
        Size = new Size(110, 36);
        DoubleBuffered = true;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _isHovered = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _isHovered = false;
        _isPressed = false;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        base.OnMouseDown(mevent);
        _isPressed = true;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        base.OnMouseUp(mevent);
        _isPressed = false;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        var g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Color bg;
        Color fg;
        Color border;

        if (!Enabled)
        {
            bg = FigmaTheme.ReadOnlyBg;
            fg = FigmaTheme.TextMuted;
            border = FigmaTheme.Border;
        }
        else
        {
            switch (_variant)
            {
                case ButtonVariant.Secondary:
                    bg = _isPressed ? FigmaTheme.ReadOnlyBg : (_isHovered ? Color.FromArgb(248, 250, 252) : Color.White);
                    fg = FigmaTheme.TextSecondary;
                    border = FigmaTheme.Border;
                    break;
                case ButtonVariant.Danger:
                    bg = _isPressed ? Color.FromArgb(185, 28, 28) : (_isHovered ? Color.FromArgb(220, 38, 38) : FigmaTheme.Danger);
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
                case ButtonVariant.Success:
                    bg = _isPressed ? Color.FromArgb(21, 128, 61) : (_isHovered ? Color.FromArgb(22, 163, 74) : FigmaTheme.Success);
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
                default: // Primary
                    bg = _isPressed ? FigmaTheme.PrimaryActive : (_isHovered ? FigmaTheme.PrimaryHover : FigmaTheme.Primary);
                    fg = Color.White;
                    border = Color.Transparent;
                    break;
            }
        }

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedRectangle(rect, CornerRadius);

        using (var brush = new SolidBrush(bg))
        {
            g.FillPath(brush, path);
        }

        if (border != Color.Transparent)
        {
            using var pen = new Pen(border, 1f);
            g.DrawPath(pen, path);
        }

        // Vẽ tiêu điểm bàn phím nếu đang Focused
        if (Focused && Enabled)
        {
            using var focusPen = new Pen(FigmaTheme.Primary, 1.5f);
            focusPen.DashStyle = DashStyle.Dot;
            var focusRect = new Rectangle(2, 2, Width - 5, Height - 5);
            using var focusPath = CreateRoundedRectangle(focusRect, CornerRadius);
            g.DrawPath(focusPen, focusPath);
        }

        TextRenderer.DrawText(
            g,
            Text,
            Font,
            rect,
            fg,
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
