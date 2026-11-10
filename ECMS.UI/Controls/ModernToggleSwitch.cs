using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Công tắc bật/tắt (Toggle Switch) hiện đại dạng viên thuốc mượt mà.
/// Có thể kéo thả thay cho CheckBox truyền thống.
/// </summary>
public class ModernToggleSwitch : CheckBox
{
    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color OnBackColor { get; set; } = Color.FromArgb(16, 185, 129); // Emerald 500

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color OffBackColor { get; set; } = Color.FromArgb(203, 213, 225); // Slate 300

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color KnobColor { get; set; } = Color.White;

    public ModernToggleSwitch()
    {
        AutoSize = false;
        Size = new Size(200, 28);
        Font = ThemeColors.FontBodyBold;
        ForeColor = ThemeColors.TextPrimary;
        Cursor = Cursors.Hand;
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        var g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent?.BackColor ?? BackColor);

        int toggleWidth = 42;
        int toggleHeight = 22;
        int toggleY = (Height - toggleHeight) / 2;

        var trackRect = new Rectangle(2, toggleY, toggleWidth, toggleHeight);
        using var trackPath = CreateCapsulePath(trackRect);
        using var trackBrush = new SolidBrush(Checked ? OnBackColor : OffBackColor);
        g.FillPath(trackBrush, trackPath);

        int knobSize = toggleHeight - 4;
        int knobX = Checked ? (trackRect.Right - knobSize - 2) : (trackRect.X + 2);
        var knobRect = new Rectangle(knobX, trackRect.Y + 2, knobSize, knobSize);

        using var knobBrush = new SolidBrush(KnobColor);
        g.FillEllipse(knobBrush, knobRect);

        // Text bên phải công tắc
        if (!string.IsNullOrEmpty(Text))
        {
            var textRect = new Rectangle(toggleWidth + 10, 0, Width - toggleWidth - 12, Height);
            TextRenderer.DrawText(g, Text, Font, textRect, ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
    }

    private static GraphicsPath CreateCapsulePath(Rectangle rect)
    {
        var path = new GraphicsPath();
        int r = rect.Height;
        path.AddArc(rect.X, rect.Y, r, r, 90, 180);
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 180);
        path.CloseFigure();
        return path;
    }
}
