using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ECMS.UI.Controls;

public static class WallpaperHelper
{
    private static Bitmap? _cachedBg;

    public static Bitmap GetAmbientWallpaper()
    {
        if (_cachedBg != null) return _cachedBg;

        string assetsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
        if (!Directory.Exists(assetsDir)) Directory.CreateDirectory(assetsDir);
        string bgPath = Path.Combine(assetsDir, "ambient_glass_bg.jpg");

        if (File.Exists(bgPath))
        {
            try
            {
                using var fs = new FileStream(bgPath, FileMode.Open, FileAccess.Read);
                _cachedBg = new Bitmap(fs);
                return _cachedBg;
            }
            catch { }
        }

        // Generate high-resolution ambient mesh & bokeh image
        int width = 1920;
        int height = 1080;
        var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

        using (var g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // 1. Base smooth diagonal gradient
            using (var baseBrush = new LinearGradientBrush(
                new Rectangle(0, 0, width, height),
                Color.FromArgb(215, 230, 245), // Soft pastel sky blue
                Color.FromArgb(235, 225, 245), // Soft pastel lavender
                45f))
            {
                g.FillRectangle(baseBrush, 0, 0, width, height);
            }

            // 2. Large diffused radial bokeh orbs simulating modern glassmorphism light source
            DrawSoftGlowOrb(g, new Point(width / 6, height / 4), 500, Color.FromArgb(70, 52, 211, 153)); // Mint green
            DrawSoftGlowOrb(g, new Point(width / 2, height / 5), 650, Color.FromArgb(65, 96, 165, 250)); // Sky blue
            DrawSoftGlowOrb(g, new Point(width * 5 / 6, height / 3), 600, Color.FromArgb(60, 167, 139, 250)); // Lavender
            DrawSoftGlowOrb(g, new Point(width / 3, height * 2 / 3), 700, Color.FromArgb(50, 251, 191, 36)); // Warm amber
            DrawSoftGlowOrb(g, new Point(width * 3 / 4, height * 3 / 4), 650, Color.FromArgb(55, 244, 114, 182)); // Rose pink
            DrawSoftGlowOrb(g, new Point(0, height), 600, Color.FromArgb(40, 16, 185, 129)); // Emerald

            // 3. Subtle vignette overlay
            using (var vignette = new LinearGradientBrush(
                new Rectangle(0, height - 300, width, 300),
                Color.Transparent,
                Color.FromArgb(30, 15, 23, 42),
                90f))
            {
                g.FillRectangle(vignette, 0, height - 300, width, 300);
            }
        }

        try
        {
            bmp.Save(bgPath, ImageFormat.Jpeg);
        }
        catch { }

        _cachedBg = bmp;
        return _cachedBg;
    }

    private static void DrawSoftGlowOrb(Graphics g, Point center, int radius, Color glowColor)
    {
        var rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
        using var path = new GraphicsPath();
        path.AddEllipse(rect);

        using var pgb = new PathGradientBrush(path);
        pgb.CenterPoint = center;
        pgb.CenterColor = glowColor;
        pgb.SurroundColors = new[] { Color.Transparent };

        g.FillEllipse(pgb, rect);
    }
}
