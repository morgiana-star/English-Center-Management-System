using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Thẻ KPI Thống kê Glassmorphism đóng gói sẵn (Icon Badge + Tiêu đề + Giá trị lớn).
/// Kéo thả trực tiếp từ Toolbox vào Form giống các khối Widget trong PowerPoint.
/// </summary>
public class StatKpiCard : GlassCard
{
    private readonly RoundedPanel _iconBox;
    private readonly Label _lblIcon;
    private readonly Label _lblTitle;
    private readonly Label _lblValue;

    public StatKpiCard()
    {
        Size = new Size(250, 125);
        CornerRadius = 14;
        EnableShadow = true;

        _iconBox = new RoundedPanel
        {
            Location = new Point(18, 16),
            Size = new Size(40, 40),
            CornerRadius = 10,
            BackColor = ThemeColors.InfoBg
        };

        _lblIcon = new Label
        {
            Text = "📊",
            Font = new Font("Segoe UI Emoji", 14f, FontStyle.Regular),
            ForeColor = ThemeColors.InfoText,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        _iconBox.Controls.Add(_lblIcon);

        _lblTitle = new Label
        {
            Text = "TIÊU ĐỀ THỐNG KÊ",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(18, 66),
            AutoSize = true
        };

        _lblValue = new Label
        {
            Text = "0",
            Font = new Font("Segoe UI", 16f, FontStyle.Bold),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(18, 86),
            Size = new Size(214, 30),
            TextAlign = ContentAlignment.MiddleLeft
        };

        Controls.Add(_iconBox);
        Controls.Add(_lblTitle);
        Controls.Add(_lblValue);
    }

    [Category("ECMS Modern Design")]
    [Description("Tiêu đề hiển thị của thẻ KPI (Ví dụ: TỔNG HỌC VIÊN)")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string CardTitle
    {
        get => _lblTitle.Text;
        set => _lblTitle.Text = value;
    }

    [Category("ECMS Modern Design")]
    [Description("Giá trị số liệu lớn hiển thị trên thẻ")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string CardValue
    {
        get => _lblValue.Text;
        set => _lblValue.Text = value;
    }

    [Category("ECMS Modern Design")]
    [Description("Biểu tượng Emoji hiển thị trong ô Icon")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string IconSymbol
    {
        get => _lblIcon.Text;
        set => _lblIcon.Text = value;
    }

    [Category("ECMS Modern Design")]
    [Description("Màu nền của ô Icon")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color AccentBackColor
    {
        get => _iconBox.BackColor;
        set => _iconBox.BackColor = value;
    }

    [Category("ECMS Modern Design")]
    [Description("Màu chữ của số liệu và Icon")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color AccentForeColor
    {
        get => _lblValue.ForeColor;
        set
        {
            _lblValue.ForeColor = value;
            _lblIcon.ForeColor = value;
        }
    }
}
