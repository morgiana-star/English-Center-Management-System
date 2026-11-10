using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Hộp chọn thả xuống (Dropdown) bo góc hiện đại, đồng bộ kích thước và viền với ModernTextBox.
/// </summary>
[DefaultEvent("SelectedIndexChanged")]
public class ModernComboBox : UserControl
{
    private readonly ComboBox _innerCombo;
    private bool _isFocused = false;

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int CornerRadius { get; set; } = 8;

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BorderColor { get; set; } = Color.FromArgb(203, 213, 225);

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color FocusBorderColor { get; set; } = Color.FromArgb(37, 99, 235);

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BoxBackColor { get; set; } = Color.White;

    public event EventHandler? SelectedIndexChanged;

    public ModernComboBox()
    {
        Size = new Size(220, 36);
        BackColor = Color.Transparent;
        DoubleBuffered = true;
        Padding = new Padding(10, 6, 10, 4);

        _innerCombo = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            FlatStyle = FlatStyle.Flat,
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Dock = DockStyle.Fill
        };

        _innerCombo.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);
        _innerCombo.Enter += (s, e) => { _isFocused = true; Invalidate(); };
        _innerCombo.Leave += (s, e) => { _isFocused = false; Invalidate(); };

        Controls.Add(_innerCombo);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ComboBox.ObjectCollection Items => _innerCombo.Items;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex
    {
        get => _innerCombo.SelectedIndex;
        set => _innerCombo.SelectedIndex = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object? SelectedItem
    {
        get => _innerCombo.SelectedItem;
        set => _innerCombo.SelectedItem = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object? SelectedValue
    {
        get => _innerCombo.SelectedValue;
        set
        {
            if (value != null)
                _innerCombo.SelectedValue = value;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object? DataSource
    {
        get => _innerCombo.DataSource;
        set => _innerCombo.DataSource = value;
    }

    [Category("Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string DisplayMember
    {
        get => _innerCombo.DisplayMember;
        set => _innerCombo.DisplayMember = value;
    }

    [Category("Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string ValueMember
    {
        get => _innerCombo.ValueMember;
        set => _innerCombo.ValueMember = value;
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

        Color border = _isFocused ? FocusBorderColor : BorderColor;
        using var pen = new Pen(border, _isFocused ? 1.8f : 1f);
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
