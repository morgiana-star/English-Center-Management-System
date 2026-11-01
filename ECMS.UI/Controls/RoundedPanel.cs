using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 15;
    public Color BorderColor { get; set; } = Color.FromArgb(220, 224, 230);
    public int BorderWidth { get; set; } = 1;

    public RoundedPanel()
    {
        DoubleBuffered = true;
        BackColor = Color.White;
        Padding = new Padding(10);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = GetRoundedRectanglePath(rect, CornerRadius);

        // Fill background
        using var brush = new SolidBrush(BackColor);
        e.Graphics.FillPath(brush, path);

        // Draw border if needed
        if (BorderWidth > 0 && BorderColor != Color.Transparent)
        {
            using var pen = new Pen(BorderColor, BorderWidth);
            e.Graphics.DrawPath(pen, path);
        }

        // Set control region to clip child controls to rounded corners
        Region = new Region(path);
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
    {
        var path = new GraphicsPath();
        int diameter = radius * 2;
        var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

        // Top-left
        path.AddArc(arc, 180, 90);
        // Top-right
        arc.X = bounds.Right - diameter;
        path.AddArc(arc, 270, 90);
        // Bottom-right
        arc.Y = bounds.Bottom - diameter;
        path.AddArc(arc, 0, 90);
        // Bottom-left
        arc.X = bounds.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
