using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

/// <summary>
/// Màn hình thông báo chức năng đang phát triển theo lộ trình thiết kế Figma.
/// Cung cấp thông tin nghiệp vụ và cho phép điều hướng an toàn về Tổng quan.
/// </summary>
public class PlaceholderView : UserControl
{
    private readonly Label _lblBreadcrumb;
    private readonly Label _lblTitle;
    private readonly AppBanner _banner;
    private readonly AppCard _cardContent;
    private readonly Label _lblEmptyIcon;
    private readonly Label _lblEmptyTitle;
    private readonly Label _lblEmptyDesc;
    private readonly AppButton _btnBackToHome;
    private Action? _onNavigateHome;

    public PlaceholderView(string moduleGroup, string featureName, string scopeDescription, Action? onNavigateHome = null)
    {
        _onNavigateHome = onNavigateHome;
        Dock = DockStyle.Fill;
        BackColor = FigmaTheme.AppBackground;
        Font = FigmaTheme.Content;
        AutoScroll = true;

        var pnlMain = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = new Padding(24, 20, 24, 24),
            BackColor = FigmaTheme.AppBackground
        };

        // Breadcrumb
        _lblBreadcrumb = new Label
        {
            Text = $"ECMS / {moduleGroup} / {featureName}",
            Font = FigmaTheme.Helper,
            ForeColor = FigmaTheme.TextMuted,
            AutoSize = true,
            Location = new Point(24, 18)
        };
        pnlMain.Controls.Add(_lblBreadcrumb);

        // Header Title
        _lblTitle = new Label
        {
            Text = featureName,
            Font = FigmaTheme.Title,
            ForeColor = FigmaTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(24, 40)
        };
        pnlMain.Controls.Add(_lblTitle);

        // Banner thông báo
        _banner = new AppBanner
        {
            BannerType = BannerType.Info,
            Message = "Chức năng đang được hoàn thiện theo lộ trình thiết kế kỹ thuật Figma. Dữ liệu sẽ lưu trữ cục bộ SQLite ngoại tuyến.",
            Location = new Point(24, 76),
            Size = new Size(1140, 42)
        };
        pnlMain.Controls.Add(_banner);

        // Card chi tiết phạm vi nghiệp vụ
        _cardContent = new AppCard
        {
            Location = new Point(24, 130),
            Size = new Size(1140, 460)
        };

        _lblEmptyIcon = new Label
        {
            Text = "⚙",
            Font = new Font("Segoe UI", 48f, FontStyle.Regular),
            ForeColor = FigmaTheme.Primary,
            TextAlign = ContentAlignment.MiddleCenter,
            Size = new Size(200, 70),
            Location = new Point((1140 - 200) / 2, 70)
        };
        _cardContent.Controls.Add(_lblEmptyIcon);

        _lblEmptyTitle = new Label
        {
            Text = $"{featureName} — Đang phát triển",
            Font = FigmaTheme.Section,
            ForeColor = FigmaTheme.TextPrimary,
            TextAlign = ContentAlignment.MiddleCenter,
            Size = new Size(800, 30),
            Location = new Point((1140 - 800) / 2, 150)
        };
        _cardContent.Controls.Add(_lblEmptyTitle);

        _lblEmptyDesc = new Label
        {
            Text = $"Phạm vi nghiệp vụ (theo tài liệu Figma):\n{scopeDescription}\n\nHệ thống tuân thủ nguyên tắc ngoại tuyến: kiểm tra lỗi tại chỗ, lưu trữ an toàn SQLite và xác nhận trước khi thay đổi dữ liệu.",
            Font = FigmaTheme.Content,
            ForeColor = FigmaTheme.TextSecondary,
            TextAlign = ContentAlignment.MiddleCenter,
            Size = new Size(750, 100),
            Location = new Point((1140 - 750) / 2, 195)
        };
        _cardContent.Controls.Add(_lblEmptyDesc);

        _btnBackToHome = new AppButton
        {
            Text = "Quay về Tổng quan điều hành",
            ButtonStyle = AppButtonStyle.Primary,
            Size = new Size(220, 38),
            Location = new Point((1140 - 220) / 2, 320)
        };
        _btnBackToHome.Click += (s, e) => _onNavigateHome?.Invoke();
        _cardContent.Controls.Add(_btnBackToHome);

        pnlMain.Controls.Add(_cardContent);
        Controls.Add(pnlMain);
    }
}
