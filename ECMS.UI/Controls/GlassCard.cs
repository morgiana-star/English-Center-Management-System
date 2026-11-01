using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Thẻ mờ Acrylic Glassmorphism kết hợp đổ bóng phân tán mềm và viền vi tính tinh tế
/// </summary>
public class GlassCard : Panel
{
    public int CornerRadius { get; set; } = 14;
    public Color GlassColor { get; set; } = Color.FromArgb(245, 255, 255, 255); // Trắng mờ 96%
    public Color BorderGlowColor { get; set; } = Color.FromArgb(215, 226, 238); // Viền kính Hairline
    public int BorderGlowWidth { get; set; } = 1;
    public bool EnableShadow { get; set; } = true;

    public GlassCard()
    {
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Padding = new Padding(16);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int shadowPadding = EnableShadow ? 3 : 0;
        var cardRect = new Rectangle(
            shadowPadding,
            shadowPadding,
            Width - 1 - (shadowPadding * 2),
            Height - 1 - (shadowPadding * 2));

        if (cardRect.Width <= 0 || cardRect.Height <= 0) return;

        // 1. Vẽ bóng đổ mềm (Soft Ambient Drop Shadow 3 lớp mờ)
        if (EnableShadow)
        {
            for (int i = 1; i <= 3; i++)
            {
                var shadowRect = new Rectangle(
                    cardRect.X - i,
                    cardRect.Y + 1,
                    cardRect.Width + (i * 2),
                    cardRect.Height + (i * 2));

                using var shadowPath = CreateRoundedPath(shadowRect, CornerRadius + i);
                using var shadowPen = new Pen(Color.FromArgb(10 / i, 15, 23, 42), 1.5f);
                g.DrawPath(shadowPen, shadowPath);
            }
        }

        // 2. Vẽ nền kính mờ Acrylic (Frosted Glass Fill)
        using (var cardPath = CreateRoundedPath(cardRect, CornerRadius))
        {
            using var brush = new SolidBrush(GlassColor);
            g.FillPath(brush, cardPath);

            // 3. Vẽ viền vi tính Hairline tinh tế (1px Border Glow)
            if (BorderGlowWidth > 0)
            {
                using var pen = new Pen(BorderGlowColor, BorderGlowWidth);
                g.DrawPath(pen, cardPath);
            }
        }
    }

    private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int d = radius * 2;
        if (d > rect.Width) d = rect.Width;
        if (d > rect.Height) d = rect.Height;

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
