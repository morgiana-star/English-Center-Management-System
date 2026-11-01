using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class CustomButton : Button
{
    public int CornerRadius { get; set; } = 8;
    public Color NormalColor { get; set; } = Color.FromArgb(31, 78, 121); // Dark Navy
    public Color HoverColor { get; set; } = Color.FromArgb(47, 85, 151); // Slate Blue
    public Color ClickColor { get; set; } = Color.FromArgb(20, 55, 90);

    private bool _isHovered = false;
    private bool _isPressed = false;

    public CustomButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        Cursor = Cursors.Hand;
        Size = new Size(130, 38);
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
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Color currentColor = NormalColor;
        if (_isPressed) currentColor = ClickColor;
        else if (_isHovered) currentColor = HoverColor;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = GetRoundedRectanglePath(rect, CornerRadius);

        using var brush = new SolidBrush(currentColor);
        pevent.Graphics.FillPath(brush, path);

        TextRenderer.DrawText(
            pevent.Graphics,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
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
