using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Ô nhập liệu chuẩn Figma (Bình thường, Đang nhập focus, Chỉ đọc, và Báo lỗi bắt buộc)
/// </summary>
public class AppTextBox : UserControl
{
    private readonly TextBox _innerBox;
    private readonly Label _lblError;
    private bool _isFocused = false;
    private bool _hasError = false;
    private string _placeholder = string.Empty;

    [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    private static extern nint SendMessage(nint hWnd, int msg, nint wParam, string lParam);
    private const int EM_SETCUEBANNER = 0x1501;

    private void UpdateCueBanner()
    {
        if (_innerBox.IsHandleCreated)
        {
            SendMessage(_innerBox.Handle, EM_SETCUEBANNER, (nint)1, _placeholder);
        }
    }

    public int CornerRadius { get; set; } = FigmaTheme.DefaultRadius;

    public string Placeholder
    {
        get => _placeholder;
        set
        {
            _placeholder = value ?? string.Empty;
            UpdateCueBanner();
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
            _innerBox.BackColor = value ? FigmaTheme.ReadOnlyBg : Color.White;
            Invalidate();
        }
    }

    public bool HasError
    {
        get => _hasError;
        set
        {
            _hasError = value;
            _lblError.Visible = value && !string.IsNullOrEmpty(_lblError.Text);
            Invalidate();
        }
    }

    public string ErrorMessage
    {
        get => _lblError.Text;
        set
        {
            _lblError.Text = value;
            _hasError = !string.IsNullOrEmpty(value);
            _lblError.Visible = _hasError;
            Invalidate();
        }
    }

    public AppTextBox()
    {
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Size = new Size(240, 36);

        _innerBox = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Font = FigmaTheme.FontContent,
            ForeColor = FigmaTheme.TextPrimary,
            BackColor = Color.White,
            Location = new Point(10, 8),
            Size = new Size(Width - 20, 20),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        _innerBox.GotFocus += (s, e) => { _isFocused = true; Invalidate(); };
        _innerBox.LostFocus += (s, e) => { _isFocused = false; Invalidate(); };
        _innerBox.TextChanged += (s, e) => Invalidate();
        _innerBox.HandleCreated += (s, e) => UpdateCueBanner();

        _lblError = new Label
        {
            Text = "",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.Danger,
            Location = new Point(4, 38),
            AutoSize = true,
            Visible = false
        };

        Controls.Add(_innerBox);
        Controls.Add(_lblError);
    }

    public void SelectAll()
    {
        _innerBox.SelectAll();
    }

    public void Select(int start, int length)
    {
        _innerBox.Select(start, length);
    }

    public new bool Focus()
    {
        return _innerBox.Focus();
    }

    public void SetError(string message)
    {
        ErrorMessage = message;
        if (!string.IsNullOrEmpty(message) && Height < 56)
        {
            Height = 58;
        }
        else if (string.IsNullOrEmpty(message) && Height >= 56)
        {
            Height = 36;
        }
    }

    public void ClearError()
    {
        SetError(string.Empty);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int boxHeight = 36;
        var rect = new Rectangle(0, 0, Width - 1, boxHeight - 1);
        using var path = CreateRoundedRectangle(rect, CornerRadius);

        Color fillBg = ReadOnly ? FigmaTheme.ReadOnlyBg : Color.White;
        using (var brush = new SolidBrush(fillBg))
        {
            g.FillPath(brush, path);
        }

        Color border;
        float borderWidth = 1f;

        if (_hasError)
        {
            border = FigmaTheme.Danger;
            borderWidth = 1.4f;
        }
        else if (_isFocused)
        {
            border = FigmaTheme.BorderFocus;
            borderWidth = 1.4f;
        }
        else
        {
            border = FigmaTheme.Border;
        }

        using (var pen = new Pen(border, borderWidth))
        {
            g.DrawPath(pen, path);
        }

        if (string.IsNullOrEmpty(_innerBox.Text) && !string.IsNullOrEmpty(_placeholder) && !_isFocused)
        {
            var textRect = new Rectangle(10, 8, Width - 20, 20);
            TextRenderer.DrawText(
                g,
                _placeholder,
                FigmaTheme.FontContent,
                textRect,
                FigmaTheme.TextMuted,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
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
