using System.Drawing;

namespace ECMS.UI.Controls;

/// <summary>
/// Hệ thống Design Tokens (Màu sắc, Typography, WCAG Conformance)
/// Đảm bảo toàn bộ giao diện tuân thủ độ tương phản WCAG 2.1 Level AA (>= 4.5:1)
/// </summary>
public static class ThemeColors
{
    // 1. Nền tổng thể & Thẻ kính Acrylic (Glassmorphism)
    public static readonly Color AppBackground = Color.FromArgb(245, 247, 250); // Nền xám mờ hiện đại
    public static readonly Color SidebarBackground = Color.FromArgb(16, 24, 38); // Deep Navy
    public static readonly Color GlassCardBg = Color.FromArgb(245, 255, 255, 255); // Trắng mờ 96%
    public static readonly Color GlassBorder = Color.FromArgb(200, 226, 232, 240); // Viền hairline kính tinh tế
    public static readonly Color GlassShadow = Color.FromArgb(18, 15, 23, 42); // Bóng đổ phân tán mềm

    // 2. Kiểu chữ văn bản (Typography - Đạt chuẩn WCAG 2.1 Level AA >= 4.5:1)
    public static readonly Color TextPrimary = Color.FromArgb(15, 23, 42); // Slate 900 (~14:1)
    public static readonly Color TextSecondary = Color.FromArgb(71, 85, 105); // Slate 600 (~7.5:1)
    public static readonly Color TextMuted = Color.FromArgb(100, 116, 139); // Slate 500 (~4.8:1)
    public static readonly Color TextOnDark = Color.FromArgb(248, 250, 252); // White/Slate 50 (~15:1)

    // 3. Màu thương hiệu & Nút bấm chính (Brand & Primary Actions)
    public static readonly Color Primary = Color.FromArgb(31, 78, 121); // Executive Deep Blue
    public static readonly Color PrimaryHover = Color.FromArgb(47, 85, 151);
    public static readonly Color PrimaryActive = Color.FromArgb(20, 55, 90);

    // 4. Bảng màu ngữ thái (Semantic WCAG Status Badges - Nền nhạt & Chữ đậm tương phản cao)
    // Thành công / Đang học / Đã thu đủ
    public static readonly Color SuccessBg = Color.FromArgb(220, 252, 231); // Green 100
    public static readonly Color SuccessText = Color.FromArgb(21, 128, 61); // Green 700 (~5.2:1)

    // Cảnh báo / Vắng học / Chờ đóng phí
    public static readonly Color WarningBg = Color.FromArgb(254, 243, 199); // Amber 100
    public static readonly Color WarningText = Color.FromArgb(180, 83, 9); // Amber 700 (~5.0:1)

    // Lỗi / Nguy hiểm / Cấm thi / Khóa tài khoản
    public static readonly Color DangerBg = Color.FromArgb(254, 226, 226); // Red 100
    public static readonly Color DangerText = Color.FromArgb(185, 28, 28); // Red 700 (~5.4:1)

    // Thông tin / Lớp mới / Đang tư vấn
    public static readonly Color InfoBg = Color.FromArgb(224, 242, 254); // Sky 100
    public static readonly Color InfoText = Color.FromArgb(3, 105, 161); // Sky 700 (~5.1:1)

    // 5. Typography Fonts
    public static readonly Font FontHeader = new Font("Segoe UI", 16, FontStyle.Bold);
    public static readonly Font FontSubHeader = new Font("Segoe UI", 11.5f, FontStyle.Bold);
    public static readonly Font FontBody = new Font("Segoe UI", 9.5f, FontStyle.Regular);
    public static readonly Font FontBodyBold = new Font("Segoe UI", 9.5f, FontStyle.Bold);
    public static readonly Font FontCaption = new Font("Segoe UI", 8.2f, FontStyle.Regular);
    public static readonly Font FontBadge = new Font("Segoe UI", 8.5f, FontStyle.Bold);
}
