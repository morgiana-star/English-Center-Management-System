using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Ô nhập liệu hiện đại bo góc, hỗ trợ Placeholder và viền phát sáng khi Focus
/// </summary>
public class ModernTextBox : UserControl
{
    private readonly TextBox _innerBox;
    private bool _isFocused = false;
    private string _placeholder = string.Empty;

    public int CornerRadius { get; set; } = 8;
    public Color BorderColor { get; set; } = Color.FromArgb(203, 213, 225); // Slate 300
    public Color FocusBorderColor { get; set; } = Color.FromArgb(37, 99, 235); // Blue 600
    public Color BoxBackColor { get; set; } = Color.White;

    public string Placeholder
    {
        get => _placeholder;
        set
        {
            _placeholder = value;
            Invalidate();
        }
    }

    [System.Diagnostics.CodeAnalysis.AllowNull]
    public override string Text
    {
        get => _innerBox.Text;
        set => _innerBox.Text = value ?? string.Empty;
    }

    public bool UseSystemPasswordChar
    {
        get => _innerBox.UseSystemPasswordChar;
        set => _innerBox.UseSystemPasswordChar = value;
    }

    public bool ReadOnly
    {
        get => _innerBox.ReadOnly;
        set
        {
            _innerBox.ReadOnly = value;
            BoxBackColor = value ? Color.FromArgb(241, 245, 249) : Color.White;
            _innerBox.BackColor = BoxBackColor;
            Invalidate();
        }
    }

    public ModernTextBox()
    {
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Padding = new Padding(12, 8, 12, 8);
        Size = new Size(260, 40);

        _innerBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Font = new Font("Segoe UI", 10f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = BoxBackColor,
            Dock = DockStyle.Fill
        };

        _innerBox.GotFocus += (s, e) => { _isFocused = true; Invalidate(); };
        _innerBox.LostFocus += (s, e) => { _isFocused = false; Invalidate(); };
        _innerBox.TextChanged += (s, e) => { Invalidate(); OnTextChanged(e); };

        Controls.Add(_innerBox);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using var path = CreateRoundedPath(rect, CornerRadius);

        // Nền ô nhập
        using (var brush = new SolidBrush(BoxBackColor))
        {
            g.FillPath(brush, path);
        }

        // Viền vi tính (đổi màu xanh khi focus)
        using (var pen = new Pen(_isFocused ? FocusBorderColor : BorderColor, _isFocused ? 1.8f : 1f))
        {
            g.DrawPath(pen, path);
        }

        // Vẽ Placeholder nếu trống và không focus
        if (string.IsNullOrEmpty(_innerBox.Text) && !string.IsNullOrEmpty(_placeholder) && !_isFocused)
        {
            var textRect = new Rectangle(12, 9, Width - 24, Height - 18);
            TextRenderer.DrawText(
                g,
                _placeholder,
                new Font("Segoe UI", 9.5f, FontStyle.Italic),
                textRect,
                ThemeColors.TextMuted,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }

    private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
