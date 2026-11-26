using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class AppComboBox : UserControl
{
    private readonly ComboBox _inner;
    private readonly Panel _arrowOverlay;
    private bool _isFocused = false;
    private bool _isArrowHovered = false;

    public int CornerRadius { get; set; } = FigmaTheme.DefaultRadius;

    [DefaultValue(true)]
    public bool AllowSearch
    {
        get => _inner.DropDownStyle == ComboBoxStyle.DropDown;
        set
        {
            _inner.DropDownStyle = value ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
            if (value)
            {
                _inner.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                _inner.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                _inner.AutoCompleteMode = AutoCompleteMode.None;
                _inner.AutoCompleteSource = AutoCompleteSource.None;
            }
        }
    }

    public event EventHandler? SelectedIndexChanged;

    public AppComboBox()
    {
        Size = new Size(200, 36);
        BackColor = Color.Transparent;
        DoubleBuffered = true;

        _inner = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDown,
            AutoCompleteMode = AutoCompleteMode.SuggestAppend,
            AutoCompleteSource = AutoCompleteSource.ListItems,
            FlatStyle = FlatStyle.Flat,
            Font = FigmaTheme.FontContent,
            ForeColor = FigmaTheme.TextPrimary,
            BackColor = Color.White,
            Location = new Point(10, 6),
            Size = new Size(Width - 20, 24),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        // Che khung viền xám mặc định quanh mũi tên của WinForms ComboBox và vẽ mũi tên chevron to, căn giữa
        _arrowOverlay = new Panel
        {
            BackColor = Color.White,
            Cursor = Cursors.Hand,
            Width = 28,
            Height = Height - 4,
            Location = new Point(Width - 30, 2),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right
        };

        _arrowOverlay.Paint += (s, e) =>
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int cx = _arrowOverlay.Width / 2;
            int cy = _arrowOverlay.Height / 2;
            var pts = new[]
            {
                new Point(cx - 5, cy - 2),
                new Point(cx, cy + 3),
                new Point(cx + 5, cy - 2)
            };

            Color arrowColor = _isFocused || _isArrowHovered
                ? FigmaTheme.Primary
                : Color.FromArgb(71, 85, 105);

            using var pen = new Pen(arrowColor, 2.0f)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
            g.DrawLines(pen, pts);
        };

        _arrowOverlay.MouseEnter += (s, e) => { _isArrowHovered = true; _arrowOverlay.Invalidate(); };
        _arrowOverlay.MouseLeave += (s, e) => { _isArrowHovered = false; _arrowOverlay.Invalidate(); };
        _arrowOverlay.Click += (s, e) =>
        {
            _inner.Focus();
            _inner.DroppedDown = !_inner.DroppedDown;
        };

        _inner.SelectedIndexChanged += (s, e) => SelectedIndexChanged?.Invoke(this, e);
        _inner.TextChanged += (s, e) => OnTextChanged(e);
        _inner.Enter += (s, e) => { _isFocused = true; Invalidate(); _arrowOverlay.Invalidate(); };
        _inner.Leave += (s, e) => { _isFocused = false; Invalidate(); _arrowOverlay.Invalidate(); };

        Controls.Add(_inner);
        Controls.Add(_arrowOverlay);
        _arrowOverlay.BringToFront();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (_inner != null && _arrowOverlay != null)
        {
            int topY = Math.Max(4, (Height - _inner.Height) / 2);
            _inner.Location = new Point(10, topY);
            _inner.Width = Math.Max(40, Width - 18);
            _arrowOverlay.Location = new Point(Width - _arrowOverlay.Width - 2, 2);
            _arrowOverlay.Height = Math.Max(10, Height - 4);
            _arrowOverlay.BringToFront();
        }
    }

    [System.Diagnostics.CodeAnalysis.AllowNull]
    public override string Text
    {
        get => _inner?.Text ?? string.Empty;
        set
        {
            if (_inner != null) _inner.Text = value ?? string.Empty;
        }
    }

    public ComboBox.ObjectCollection Items => _inner.Items;

    public int SelectedIndex
    {
        get => _inner.SelectedIndex;
        set
        {
            if (value >= 0 && value < _inner.Items.Count)
            {
                _inner.SelectedIndex = value;
            }
            else if (value == -1)
            {
                _inner.SelectedIndex = -1;
            }
        }
    }

    public int FindStringExact(string? s) => _inner.FindStringExact(s);
    public int FindString(string? s) => _inner.FindString(s);

    public object? SelectedItem
    {
        get => _inner.SelectedItem;
        set
        {
            try
            {
                _inner.SelectedItem = value;
            }
            catch
            {
                // Ignore any invalid selection attempts
            }
        }
    }

    public object? SelectedValue
    {
        get => _inner.SelectedValue;
        set
        {
            try
            {
#pragma warning disable CS8601
                _inner.SelectedValue = value;
#pragma warning restore CS8601
            }
            catch
            {
                // Ignore any invalid selection attempts
            }
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
