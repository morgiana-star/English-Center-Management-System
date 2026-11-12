using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class AppDatePicker : UserControl
{
    private readonly DateTimePicker _inner;

    public int CornerRadius { get; set; } = FigmaTheme.DefaultRadius;

    public event EventHandler? ValueChanged;

    public DateTime Value
    {
        get => _inner.Value;
        set => _inner.Value = value;
    }

    public AppDatePicker()
    {
        Size = new Size(160, 36);
        BackColor = Color.Transparent;
        DoubleBuffered = true;

        _inner = new DateTimePicker
        {
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "dd/MM/yyyy",
            Font = FigmaTheme.FontContent,
            CalendarForeColor = FigmaTheme.TextPrimary,
            Location = new Point(8, 7),
            Size = new Size(Width - 16, 22),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        _inner.ValueChanged += (s, e) => ValueChanged?.Invoke(this, e);

        Controls.Add(_inner);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedRectangle(rect, CornerRadius);

        using (var brush = new SolidBrush(Color.White))
        {
            g.FillPath(brush, path);
        }

        using (var pen = new Pen(FigmaTheme.Border, 1f))
        {
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
