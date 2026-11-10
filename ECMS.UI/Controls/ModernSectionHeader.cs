using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Thanh tiêu đề phân mục chuyên nghiệp kèm vạch nhấn màu ở cạnh trái.
/// Rất hữu ích để chia các khu vực chức năng khi kéo thả trên Form Designer.
/// </summary>
public class ModernSectionHeader : UserControl
{
    private readonly Panel _accentBar;
    private readonly Label _lblHeader;
    private readonly Label _lblSubtitle;

    public ModernSectionHeader()
    {
        Size = new Size(500, 48);
        BackColor = Color.Transparent;

        _accentBar = new Panel
        {
            Location = new Point(0, 4),
            Size = new Size(5, 40),
            BackColor = ThemeColors.Primary
        };

        _lblHeader = new Label
        {
            Text = "TIÊU ĐỀ PHÂN MỤC",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(14, 2),
            AutoSize = true
        };

        _lblSubtitle = new Label
        {
            Text = "Mô tả ngắn gọn cho khu vực chức năng này",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(14, 26),
            AutoSize = true
        };

        Controls.Add(_accentBar);
        Controls.Add(_lblHeader);
        Controls.Add(_lblSubtitle);
    }

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string HeaderText
    {
        get => _lblHeader.Text;
        set => _lblHeader.Text = value;
    }

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string SubtitleText
    {
        get => _lblSubtitle.Text;
        set => _lblSubtitle.Text = value;
    }

    [Category("ECMS Modern Design")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color AccentColor
    {
        get => _accentBar.BackColor;
        set => _accentBar.BackColor = value;
    }
}
