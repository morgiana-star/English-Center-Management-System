using System.Drawing;

namespace ECMS.UI.Controls;

/// <summary>
/// Hệ thống Design Tokens trích xuất trực tiếp từ bản thiết kế Figma (Giai đoạn 2 / 01)
/// </summary>
public static class FigmaTheme
{
    // 1. Màu sắc có ngữ nghĩa (Semantic Palette)
    public static readonly Color Primary = ColorTranslator.FromHtml("#2563EB");       // Chính (Blue 600)
    public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#1D4ED8");  // Rê chuột (Blue 700)
    public static readonly Color PrimaryActive = ColorTranslator.FromHtml("#1E40AF"); // Bấm (Blue 800)
    public static readonly Color PrimaryLight = ColorTranslator.FromHtml("#EFF6FF");  // Nền xanh nhạt (Blue 50)

    public static readonly Color AppBackground = ColorTranslator.FromHtml("#F5F7FA");  // Nền ứng dụng
    public static readonly Color CardBackground = Color.White;                         // Nền thẻ Card
    public static readonly Color SidebarBackground = Color.White;                      // Nền Sidebar

    public static readonly Color TextPrimary = ColorTranslator.FromHtml("#1E293B");    // Chữ chính (Slate 800)
    public static readonly Color TextSecondary = ColorTranslator.FromHtml("#64748B");  // Chữ phụ (Slate 500)
    public static readonly Color TextMuted = ColorTranslator.FromHtml("#94A3B8");      // Chữ mờ (Slate 400)
    public static readonly Color TextWhite = Color.White;

    public static readonly Color Border = ColorTranslator.FromHtml("#E2E8F0");         // Viền (Slate 200)
    public static readonly Color BorderFocus = ColorTranslator.FromHtml("#2563EB");    // Viền khi Focus
    public static readonly Color ReadOnlyBg = ColorTranslator.FromHtml("#F1F5F9");     // Nền ô chỉ đọc (Slate 100)

    public static readonly Color Success = ColorTranslator.FromHtml("#16A34A");       // Đạt (Green 600)
    public static readonly Color SuccessBg = ColorTranslator.FromHtml("#DCFCE7");     // Nền đạt (Green 100)

    public static readonly Color Warning = ColorTranslator.FromHtml("#F59E0B");       // Chú ý (Amber 500)
    public static readonly Color WarningBg = ColorTranslator.FromHtml("#FEF3C7");     // Nền chú ý (Amber 100)

    public static readonly Color Danger = ColorTranslator.FromHtml("#DC2626");        // Lỗi (Red 600)
    public static readonly Color DangerBg = ColorTranslator.FromHtml("#FEE2E2");      // Nền lỗi (Red 100)

    public static readonly Color Info = ColorTranslator.FromHtml("#0EA5E9");          // Tin tức (Sky 500)
    public static readonly Color InfoBg = ColorTranslator.FromHtml("#E0F2FE");        // Nền tin tức (Sky 100)

    // 2. Hệ thống Typography (Segoe UI - theo chỉ đạo của người dùng)
    public static readonly Font FontPageTitle = new Font("Segoe UI", 16f, FontStyle.Bold);     // Tiêu đề trang · 24px (WinForms ~16pt)
    public static readonly Font FontSectionTitle = new Font("Segoe UI", 12.5f, FontStyle.Bold); // Tiêu đề mục · 18px (WinForms ~12.5pt)
    public static readonly Font FontContent = new Font("Segoe UI", 9.5f, FontStyle.Regular);    // Nội dung · 14px (WinForms ~9.5pt)
    public static readonly Font FontContentBold = new Font("Segoe UI", 9.5f, FontStyle.Bold);  // Nội dung đậm
    public static readonly Font FontLabel = new Font("Segoe UI", 9f, FontStyle.Bold);          // Nhãn · 13px (WinForms ~9pt Bold)
    public static readonly Font FontHelper = new Font("Segoe UI", 8.5f, FontStyle.Regular);    // Trợ giúp / Chú thích · 12px (~8.5pt)
    public static readonly Font FontBadge = new Font("Segoe UI", 8.5f, FontStyle.Bold);        // Nhãn Badge
    public static readonly Font FontKpiValue = new Font("Segoe UI", 18f, FontStyle.Bold);      // Chỉ số lớn trên KPI

    // Shorthand aliases
    public static Font Title => FontPageTitle;
    public static Font Section => FontSectionTitle;
    public static Font Content => FontContent;
    public static Font ContentBold => FontContentBold;
    public static Font Label => FontLabel;
    public static Font Helper => FontHelper;
    public static Font Badge => FontBadge;
    public static Font KpiValue => FontKpiValue;

    // 3. Quy chuẩn Bo góc (Corner Radius) theo Figma: 4 - 6 px
    public const int DefaultRadius = 5;
    public const int CardRadius = 6;
}
