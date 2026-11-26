using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Khung chứa thẻ trắng viền mảnh chuẩn Figma (Giai đoạn 2 / 01)
/// </summary>
public class AppCard : Panel
{
    public int CornerRadius { get; set; } = FigmaTheme.CardRadius;
    public Color BorderColor { get; set; } = FigmaTheme.Border;
    public int BorderWidth { get; set; } = 1;

    public AppCard()
    {
        BackColor = FigmaTheme.CardBackground;
        Padding = new Padding(16);
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedRectangle(rect, CornerRadius);

        using (var brush = new SolidBrush(BackColor))
        {
            g.FillPath(brush, path);
        }

        if (BorderWidth > 0 && BorderColor != Color.Transparent)
        {
            using var pen = new Pen(BorderColor, BorderWidth);
            g.DrawPath(pen, path);
        }
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
