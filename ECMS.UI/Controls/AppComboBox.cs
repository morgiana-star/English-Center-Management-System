using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class AppComboBox : UserControl
{
    private readonly ComboBox _inner;
    private bool _isFocused = false;

    public int CornerRadius { get; set; } = FigmaTheme.DefaultRadius;

    public event EventHandler? SelectedIndexChanged;

    public AppComboBox()
    {
        Size = new Size(200, 36);
        BackColor = Color.Transparent;
        DoubleBuffered = true;

        _inner = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            FlatStyle = FlatStyle.Flat,
            Font = FigmaTheme.FontContent,
            ForeColor = FigmaTheme.TextPrimary,
            BackColor = Color.White,
            Location = new Point(8, 7),
            Size = new Size(Width - 16, 22),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        _inner.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);
        _inner.Enter += (s, e) => { _isFocused = true; Invalidate(); };
        _inner.Leave += (s, e) => { _isFocused = false; Invalidate(); };

        Controls.Add(_inner);
    }

    public ComboBox.ObjectCollection Items => _inner.Items;

    public int SelectedIndex
    {
        get => _inner.SelectedIndex;
        set => _inner.SelectedIndex = value;
    }

    public int FindStringExact(string? s) => _inner.FindStringExact(s);

    public object? SelectedItem
    {
        get => _inner.SelectedItem;
        set => _inner.SelectedItem = value;
    }

    public object? SelectedValue
    {
        get => _inner.SelectedValue;
        set
        {
#pragma warning disable CS8601
            _inner.SelectedValue = value;
#pragma warning restore CS8601
        }
    }

    public object? DataSource
    {
        get => _inner.DataSource;
        set => _inner.DataSource = value;
    }

    public string DisplayMember
    {
        get => _inner.DisplayMember;
        set => _inner.DisplayMember = value;
    }

    public string ValueMember
    {
        get => _inner.ValueMember;
        set => _inner.ValueMember = value;
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

        Color border = _isFocused ? FigmaTheme.BorderFocus : FigmaTheme.Border;
        using (var pen = new Pen(border, _isFocused ? 1.4f : 1f))
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
