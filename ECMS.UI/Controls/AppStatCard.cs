using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Thẻ thống kê chỉ số KPI theo chuẩn Figma Image 5
/// Hỗ trợ co giãn linh hoạt và hiển thị thông số rõ nét
/// </summary>
public class AppStatCard : AppCard
{
    private readonly Label _lblTitle;
    private readonly Label _lblValue;
    private readonly Label _lblSubtext;

    public string Title
    {
        get => _lblTitle.Text;
        set => _lblTitle.Text = value;
    }

    public string Value
    {
        get => _lblValue.Text;
        set => _lblValue.Text = value;
    }

    public string Subtext
    {
        get => _lblSubtext.Text;
        set => _lblSubtext.Text = value;
    }

    public AppStatCard()
    {
        Size = new Size(185, 95);
        Padding = new Padding(14, 12, 14, 12);

        _lblTitle = new Label
        {
            Text = "TIÊU ĐỀ",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(14, 10),
            AutoSize = true
        };

        _lblValue = new Label
        {
            Text = "0",
            Font = FigmaTheme.FontKpiValue,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(14, 30),
            Size = new Size(155, 34),
            TextAlign = ContentAlignment.MiddleLeft,
            AutoEllipsis = true
        };

        _lblSubtext = new Label
        {
            Text = "Ghi chú phụ",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(14, 66),
            Size = new Size(155, 20),
            TextAlign = ContentAlignment.MiddleLeft,
            AutoEllipsis = true
        };

        Controls.Add(_lblTitle);
        Controls.Add(_lblValue);
        Controls.Add(_lblSubtext);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        int availableW = Math.Max(20, Width - 28);
        if (_lblValue != null) _lblValue.Width = availableW;
        if (_lblSubtext != null) _lblSubtext.Width = availableW;
    }
}
