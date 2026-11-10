using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Hộp chọn ngày tháng định dạng dd/MM/yyyy bo góc hiện đại, đồng bộ với ModernTextBox.
/// </summary>
[DefaultEvent("ValueChanged")]
public class ModernDatePicker : UserControl
{
    private readonly DateTimePicker _innerPicker;

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int CornerRadius { get; set; } = 8;

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BorderColor { get; set; } = Color.FromArgb(203, 213, 225);

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BoxBackColor { get; set; } = Color.White;

    public event EventHandler? ValueChanged;

    public ModernDatePicker()
    {
        Size = new Size(180, 36);
        BackColor = Color.Transparent;
        DoubleBuffered = true;
        Padding = new Padding(8, 6, 8, 4);

        _innerPicker = new DateTimePicker
        {
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "dd/MM/yyyy",
            Font = ThemeColors.FontBody,
            Dock = DockStyle.Fill,
            Value = DateTime.Today
        };
        _innerPicker.ValueChanged += (s, e) => ValueChanged?.Invoke(this, e);

        Controls.Add(_innerPicker);
    }

    [Category("Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public DateTime Value
    {
        get => _innerPicker.Value;
        set => _innerPicker.Value = value;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedPath(rect, CornerRadius);
        using var bgBrush = new SolidBrush(Enabled ? BoxBackColor : Color.FromArgb(241, 245, 249));
        g.FillPath(bgBrush, path);

        using var pen = new Pen(BorderColor, 1f);
        g.DrawPath(pen, path);
    }

    private static GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
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
