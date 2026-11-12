using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public enum BannerVariant
{
    Success,
    Warning,
    Danger,
    Info
}

public enum BannerType
{
    Success = BannerVariant.Success,
    Warning = BannerVariant.Warning,
    Danger = BannerVariant.Danger,
    Info = BannerVariant.Info
}

/// <summary>
/// Khung banner thông báo phản hồi nghiệp vụ theo chuẩn Figma Image 4
/// Có vạch màu cạnh trái, nền nhạt tương phản cao
/// </summary>
public class AppBanner : Panel
{
    private BannerVariant _variant = BannerVariant.Info;
    private readonly Label _lblTitle;
    private readonly Label _lblMessage;

    public BannerVariant Variant
    {
        get => _variant;
        set
        {
            _variant = value;
            UpdateColors();
            Invalidate();
        }
    }

    public BannerType BannerType
    {
        get => (BannerType)_variant;
        set
        {
            _variant = (BannerVariant)value;
            UpdateColors();
            Invalidate();
        }
    }

    public string Title
    {
        get => _lblTitle.Text;
        set => _lblTitle.Text = value;
    }

    public string Message
    {
        get => _lblMessage.Text;
        set => _lblMessage.Text = value;
    }

    public AppBanner()
    {
        Size = new Size(500, 64);
        Padding = new Padding(16, 10, 16, 10);
        DoubleBuffered = true;

        _lblTitle = new Label
        {
            Text = "Thông báo nghiệp vụ",
            Font = FigmaTheme.FontContentBold,
            Location = new Point(16, 10),
            AutoSize = true
        };

        _lblMessage = new Label
        {
            Text = "Nội dung chi tiết thông báo.",
            Font = FigmaTheme.FontHelper,
            Location = new Point(16, 32),
            Size = new Size(Width - 32, 22),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        Controls.Add(_lblTitle);
        Controls.Add(_lblMessage);

        UpdateColors();
    }

    private void UpdateColors()
    {
        switch (_variant)
        {
            case BannerVariant.Success:
                BackColor = FigmaTheme.SuccessBg;
                _lblTitle.ForeColor = FigmaTheme.Success;
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#14532D"); // Dark green
                break;
            case BannerVariant.Warning:
                BackColor = FigmaTheme.WarningBg;
                _lblTitle.ForeColor = ColorTranslator.FromHtml("#B45309"); // Dark amber
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#78350F");
                break;
            case BannerVariant.Danger:
                BackColor = FigmaTheme.DangerBg;
                _lblTitle.ForeColor = FigmaTheme.Danger;
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#7F1D1D"); // Dark red
                break;
            default:
                BackColor = FigmaTheme.InfoBg;
                _lblTitle.ForeColor = FigmaTheme.Info;
                _lblMessage.ForeColor = ColorTranslator.FromHtml("#0C4A6E"); // Dark sky
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Color stripeColor;
        switch (_variant)
        {
            case BannerVariant.Success: stripeColor = FigmaTheme.Success; break;
            case BannerVariant.Warning: stripeColor = FigmaTheme.Warning; break;
            case BannerVariant.Danger: stripeColor = FigmaTheme.Danger; break;
            default: stripeColor = FigmaTheme.Info; break;
        }

        // Vẽ vạch nhấn bên trái
        using var brush = new SolidBrush(stripeColor);
        g.FillRectangle(brush, 0, 0, 5, Height);

        // Viền bao quanh
        using var pen = new Pen(Color.FromArgb(40, stripeColor), 1f);
        g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
    }
}
