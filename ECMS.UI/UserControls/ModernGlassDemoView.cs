using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

/// <summary>
/// Màn hình Demo chuẩn phong cách Modern Enterprise + Glassmorphism (Tương tự ảnh mẫu 2)
/// Bố cục thẻ mờ Acrylic đa tầng, biểu đồ sóng phát sáng, tác vụ nhanh và nhật ký hoạt động
/// </summary>
public class ModernGlassDemoView : UserControl
{
    private Label lblGreeting = null!;
    private Label lblStatStudents = null!;
    private Label lblStatClasses = null!;
    private Label lblStatAlerts = null!;
    private Label lblStatRevenue = null!;
    private FlowLayoutPanel pnlTableRows = null!;

    public ModernGlassDemoView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadDemoDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = Color.Transparent;
        AutoScroll = true;
        Padding = new Padding(0, 0, 20, 20);

        int leftWidth = 720;
        int rightWidth = 320;
        int rightLeft = leftWidth + 20;

        // =========================================================================
        // KHỐI BÊN TRÁI (LEFT COLUMN: HERO, DATA TABLE, PERFORMANCE CHART, BANNER)
        // =========================================================================

        // 1. HERO GREETING GLASS CARD (Khối chào mừng kèm 4 thẻ KPI lồng trong kính)
        var cardHero = new GlassCard
        {
            Location = new Point(0, 0),
            Size = new Size(leftWidth, 230),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(190, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        lblGreeting = new Label
        {
            Text = "Xin chào, Sarah Khan 👋",
            Font = new Font("Segoe UI", 18, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(22, 18),
            AutoSize = true
        };

        var lblHeroSub = new Label
        {
            Text = "Quản lý học viên, theo dõi tiến độ đào tạo và kiểm soát tài chính trung tâm — tất cả trong một.",
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = Color.FromArgb(71, 85, 105),
            Location = new Point(24, 52),
            Size = new Size(460, 36)
        };

        // 4 Mini Embedded Stat Cards
        var miniStat1 = CreateEmbeddedMiniCard(new Point(22, 98), new Size(150, 110), "Tổng Học Viên", "248", "↑ 12%", Color.FromArgb(13, 148, 136), Color.FromArgb(204, 251, 241), out lblStatStudents);
        var miniStat2 = CreateEmbeddedMiniCard(new Point(190, 98), new Size(150, 110), "Lớp Hoạt Động", "18", "↑ 8%", Color.FromArgb(22, 163, 74), Color.FromArgb(220, 252, 231), out lblStatClasses);
        var miniStat3 = CreateEmbeddedMiniCard(new Point(358, 98), new Size(150, 110), "Học Viên Vắng", "3", "Cần nhắc", Color.FromArgb(225, 29, 72), Color.FromArgb(255, 228, 230), out lblStatAlerts);
        var miniStat4 = CreateEmbeddedMiniCard(new Point(526, 98), new Size(165, 110), "Doanh Thu", "5.5M đ", "↑ 15%", Color.FromArgb(124, 58, 237), Color.FromArgb(243, 232, 255), out lblStatRevenue);

        cardHero.Controls.Add(lblGreeting);
        cardHero.Controls.Add(lblHeroSub);
        cardHero.Controls.Add(miniStat1);
        cardHero.Controls.Add(miniStat2);
        cardHero.Controls.Add(miniStat3);
        cardHero.Controls.Add(miniStat4);

        // 2. DATA LISTING GLASS CARD ("Product Listings" style table)
        var cardTable = new GlassCard
        {
            Location = new Point(0, 250),
            Size = new Size(leftWidth, 440),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblTableTitle = new Label
        {
            Text = "Hồ sơ Học viên & Khóa học (Student Listings)",
            Font = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(22, 16),
            AutoSize = true
        };

        var lblTableSub = new Label
        {
            Text = "Danh sách học viên đang theo học, cập nhật sĩ số lớp và tiến độ đóng học phí.",
            Font = new Font("Segoe UI", 8.8f),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(23, 40),
            AutoSize = true
        };

        var btnAddHero = new CustomButton
        {
            Text = "+ Thêm Học Viên",
            NormalColor = Color.FromArgb(79, 70, 229), // Indigo 600
            HoverColor = Color.FromArgb(99, 102, 241),
            Location = new Point(leftWidth - 175, 18),
            Size = new Size(150, 36),
            CornerRadius = 8
        };
        btnAddHero.Click += (s, e) => MessageBox.Show("Khởi tạo hồ sơ học viên mới: Nhập thông tin nhân thân, chọn lớp và sinh mã học viên tự động.", "Thêm học viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Filter Tabs
        var pnlTabs = new Panel
        {
            Location = new Point(22, 70),
            Size = new Size(leftWidth - 44, 30),
            BackColor = Color.Transparent
        };
        CreateFilterTab(pnlTabs, "Tất cả (8)", true, 0);
        CreateFilterTab(pnlTabs, "Đang học (7)", false, 90);
        CreateFilterTab(pnlTabs, "Vắng học (1)", false, 195);
        CreateFilterTab(pnlTabs, "Hoàn tất (0)", false, 295);

        // Sub search bar
        var txtSearch = new ModernTextBox
        {
            Placeholder = "Tìm kiếm theo tên học viên, mã HV, số điện thoại...",
            Location = new Point(22, 108),
            Size = new Size(340, 36),
            CornerRadius = 6
        };

        var btnFilter = new CustomButton
        {
            Text = "Lọc Khóa Học ▾",
            NormalColor = Color.FromArgb(241, 245, 249),
            HoverColor = Color.FromArgb(226, 232, 240),
            ForeColor = Color.FromArgb(51, 65, 85),
            Location = new Point(375, 108),
            Size = new Size(130, 36),
            CornerRadius = 6
        };

        // Table Header
        var pnlTableHeader = new Panel
        {
            Location = new Point(22, 155),
            Size = new Size(leftWidth - 44, 28),
            BackColor = Color.Transparent
        };
        AddHeaderColumn(pnlTableHeader, "Học viên & Mã số", 10, 220);
        AddHeaderColumn(pnlTableHeader, "Khóa / Lớp học", 235, 130);
        AddHeaderColumn(pnlTableHeader, "Chuyên cần", 370, 95);
        AddHeaderColumn(pnlTableHeader, "Trạng thái", 475, 105);
        AddHeaderColumn(pnlTableHeader, "Thao tác", 590, 80);

        // Table Row Container (Flow)
        pnlTableRows = new FlowLayoutPanel
        {
            Location = new Point(22, 185),
            Size = new Size(leftWidth - 44, 240),
            AutoScroll = true,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            BackColor = Color.Transparent
        };

        cardTable.Controls.Add(lblTableTitle);
        cardTable.Controls.Add(lblTableSub);
        cardTable.Controls.Add(btnAddHero);
        cardTable.Controls.Add(pnlTabs);
        cardTable.Controls.Add(txtSearch);
        cardTable.Controls.Add(btnFilter);
        cardTable.Controls.Add(pnlTableHeader);
        cardTable.Controls.Add(pnlTableRows);

        // 3. PERFORMANCE CHART GLASS CARD ("Product Performance" with smooth wave curve)
        var cardChart = new GlassCard
        {
            Location = new Point(0, 705),
            Size = new Size(leftWidth, 260),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblChartTitle = new Label
        {
            Text = "Hiệu suất Đào tạo & Điểm danh (Academic Performance)",
            Font = new Font("Segoe UI", 11.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(22, 16),
            AutoSize = true
        };

        // Chart Paint Canvas (Vẽ đường cong spline mềm mại có phủ gradient tím phía dưới)
        var pnlWaveChart = new Panel
        {
            Location = new Point(22, 50),
            Size = new Size(460, 190),
            BackColor = Color.Transparent
        };
        pnlWaveChart.Paint += (s, e) => DrawSmoothPerformanceWave(e.Graphics, pnlWaveChart.ClientRectangle);

        // Right side stats of the chart
        var lblChartStatTitle = new Label
        {
            Text = "TỔNG GIỜ GIẢNG DẠY",
            Font = new Font("Segoe UI", 8.2f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(505, 55),
            AutoSize = true
        };

        var lblChartStatVal1 = new Label
        {
            Text = "12,482 giờ",
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(505, 75),
            AutoSize = true
        };

        var lblChartBadge1 = new Label
        {
            Text = "↑ 24% so với kỳ trước",
            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(22, 163, 74),
            Location = new Point(507, 108),
            AutoSize = true
        };

        var lblChartStatVal2 = new Label
        {
            Text = "Tỷ lệ đỗ kỳ thi: 96.5%",
            Font = new Font("Segoe UI", 10.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(79, 70, 229),
            Location = new Point(505, 145),
            AutoSize = true
        };

        var btnExportReport = new CustomButton
        {
            Text = "Xuất Báo Cáo Chi Tiết →",
            NormalColor = Color.FromArgb(238, 242, 255),
            HoverColor = Color.FromArgb(224, 231, 255),
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(505, 185),
            Size = new Size(190, 36),
            CornerRadius = 8
        };
        btnExportReport.Click += (s, e) => MessageBox.Show("Đã trích xuất báo cáo chất lượng đào tạo & biểu đồ chuyên cần ra file Excel!", "Báo cáo đào tạo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        cardChart.Controls.Add(lblChartTitle);
        cardChart.Controls.Add(pnlWaveChart);
        cardChart.Controls.Add(lblChartStatTitle);
        cardChart.Controls.Add(lblChartStatVal1);
        cardChart.Controls.Add(lblChartBadge1);
        cardChart.Controls.Add(lblChartStatVal2);
        cardChart.Controls.Add(btnExportReport);

        // 4. BOTTOM PROMO / CALLOUT GLASS BANNER
        var cardBanner = new GlassCard
        {
            Location = new Point(0, 980),
            Size = new Size(leftWidth, 75),
            CornerRadius = 16,
            GlassColor = Color.FromArgb(200, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblBannerText = new Label
        {
            Text = "Cơ sở dữ liệu ECMS đang lưu trữ cục bộ an toàn bằng SQLite (WAL Mode).\nĐược bảo vệ bằng mã hóa BCrypt và kiểm soát phiên làm việc RBAC nghiêm ngặt.",
            Font = new Font("Segoe UI", 9f),
            ForeColor = Color.FromArgb(30, 41, 59),
            Location = new Point(20, 16),
            Size = new Size(520, 42)
        };

        var btnBackupQuick = new CustomButton
        {
            Text = "Sao Lưu Ngay →",
            NormalColor = Color.FromArgb(79, 70, 229),
            HoverColor = Color.FromArgb(99, 102, 241),
            Location = new Point(leftWidth - 165, 18),
            Size = new Size(140, 38),
            CornerRadius = 8
        };
        btnBackupQuick.Click += (s, e) => MessageBox.Show("Đã xuất tệp sao lưu CSDL an toàn vào thư mục Backups!", "Sao lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        cardBanner.Controls.Add(lblBannerText);
        cardBanner.Controls.Add(btnBackupQuick);

        // =========================================================================
        // KHỐI BÊN PHẢI (RIGHT COLUMN: STATUS, QUICK ACTIONS, SALES OVERVIEW, TIMELINE)
        // =========================================================================

        // 1. SYSTEM HEALTH STATUS PILL CARD
        var cardSystemStatus = new GlassCard
        {
            Location = new Point(rightLeft, 0),
            Size = new Size(rightWidth, 54),
            CornerRadius = 14,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true,
            Padding = new Padding(8)
        };

        var lblStatusPulse = new Label
        {
            Text = "🟢 Hệ thống Offline hoạt động ổn định",
            Font = new Font("Segoe UI", 9.2f, FontStyle.Bold),
            ForeColor = Color.FromArgb(21, 128, 61),
            Location = new Point(14, 16),
            AutoSize = true
        };
        cardSystemStatus.Controls.Add(lblStatusPulse);

        // 2. QUICK ACTIONS CARD
        var cardQuickActions = new GlassCard
        {
            Location = new Point(rightLeft, 68),
            Size = new Size(rightWidth, 230),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblQuickTitle = new Label
        {
            Text = "Tác vụ Nhanh (Quick Actions)",
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(16, 15),
            AutoSize = true
        };
        cardQuickActions.Controls.Add(lblQuickTitle);

        CreateQuickActionRow(cardQuickActions, "+ Thêm Học Viên Mới", Color.FromArgb(124, 58, 237), 48, () => MessageBox.Show("Mở form thêm học viên", "Tác vụ"));
        CreateQuickActionRow(cardQuickActions, "📥 Lập Phiếu Thu Tiền", Color.FromArgb(14, 165, 233), 90, () => MessageBox.Show("Mở form lập phiếu thu", "Tác vụ"));
        CreateQuickActionRow(cardQuickActions, "📅 Xếp Thời Khóa Biểu", Color.FromArgb(16, 185, 129), 132, () => MessageBox.Show("Mở thời khóa biểu", "Tác vụ"));
        CreateQuickActionRow(cardQuickActions, "⚙️ Sao Lưu CSDL SQLite", Color.FromArgb(99, 102, 241), 174, () => MessageBox.Show("Sao lưu CSDL", "Tác vụ"));

        // 3. FINANCIAL OVERVIEW WITH SPARKLINE CARD
        var cardSalesOverview = new GlassCard
        {
            Location = new Point(rightLeft, 312),
            Size = new Size(rightWidth, 200),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblSalesTitle = new Label
        {
            Text = "Doanh thu Thực thu (Sales Overview)",
            Font = new Font("Segoe UI", 10.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(16, 14),
            AutoSize = true
        };

        var lblSalesVal = new Label
        {
            Text = "5.500.000 đ",
            Font = new Font("Segoe UI", 17, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(16, 40),
            AutoSize = true
        };

        var lblSalesBadge = new Label
        {
            Text = "↑ 18% so với tuần trước",
            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(22, 163, 74),
            Location = new Point(18, 72),
            AutoSize = true
        };

        var pnlSparkline = new Panel
        {
            Location = new Point(16, 96),
            Size = new Size(rightWidth - 32, 85),
            BackColor = Color.Transparent
        };
        pnlSparkline.Paint += (s, e) => DrawMiniSparkline(e.Graphics, pnlSparkline.ClientRectangle);

        cardSalesOverview.Controls.Add(lblSalesTitle);
        cardSalesOverview.Controls.Add(lblSalesVal);
        cardSalesOverview.Controls.Add(lblSalesBadge);
        cardSalesOverview.Controls.Add(pnlSparkline);

        // 4. RECENT ACTIVITY TIMELINE CARD
        var cardActivity = new GlassCard
        {
            Location = new Point(rightLeft, 526),
            Size = new Size(rightWidth, 310),
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblActTitle = new Label
        {
            Text = "Hoạt động Gần đây (Recent Activity)",
            Font = new Font("Segoe UI", 10.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(16, 14),
            AutoSize = true
        };
        cardActivity.Controls.Add(lblActTitle);

        CreateActivityRow(cardActivity, "🛒 Thu học phí IELTS-K12", "Nguyễn Văn An • 5.500.000 đ", "2 phút trước", Color.FromArgb(16, 185, 129), 45);
        CreateActivityRow(cardActivity, "📚 Điểm danh lớp học", "Lớp K12 có mặt 20/20", "15 phút trước", Color.FromArgb(99, 102, 241), 105);
        CreateActivityRow(cardActivity, "📝 Cập nhật điểm giữa kỳ", "Giảng viên John Smith", "30 phút trước", Color.FromArgb(245, 158, 11), 165);
        CreateActivityRow(cardActivity, "👤 Khách mới đăng ký test", "Lê Thị Thảo tư vấn", "1 giờ trước", Color.FromArgb(236, 72, 153), 225);

        // Gắn tất cả các thẻ kính vào UserControl
        Controls.Add(cardHero);
        Controls.Add(cardTable);
        Controls.Add(cardChart);
        Controls.Add(cardBanner);

        Controls.Add(cardSystemStatus);
        Controls.Add(cardQuickActions);
        Controls.Add(cardSalesOverview);
        Controls.Add(cardActivity);
    }

    private Panel CreateEmbeddedMiniCard(Point loc, Size size, string title, string val, string badge, Color badgeColor, Color badgeBg, out Label valLabel)
    {
        var pnl = new GlassCard
        {
            Location = loc,
            Size = size,
            CornerRadius = 12,
            GlassColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(230, 240, 250),
            BorderGlowWidth = 1,
            EnableShadow = false,
            Padding = new Padding(10)
        };

        var lblT = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 8.2f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(10, 10),
            AutoSize = true
        };

        valLabel = new Label
        {
            Text = val,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(8, 32),
            Size = new Size(130, 35),
            TextAlign = ContentAlignment.MiddleLeft
        };

        var lblBadge = new Label
        {
            Text = " " + badge + " ",
            Font = new Font("Segoe UI", 8.2f, FontStyle.Bold),
            ForeColor = badgeColor,
            BackColor = badgeBg,
            Location = new Point(10, 75),
            AutoSize = true
        };

        pnl.Controls.Add(lblT);
        pnl.Controls.Add(valLabel);
        pnl.Controls.Add(lblBadge);
        return pnl;
    }

    private void CreateFilterTab(Panel container, string text, bool isActive, int left)
    {
        var btn = new Button
        {
            Text = text,
            Font = new Font("Segoe UI", 8.8f, isActive ? FontStyle.Bold : FontStyle.Regular),
            ForeColor = isActive ? Color.FromArgb(79, 70, 229) : Color.FromArgb(100, 116, 139),
            BackColor = isActive ? Color.FromArgb(238, 242, 255) : Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Location = new Point(left, 0),
            Size = new Size(90, 28),
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 0;
        container.Controls.Add(btn);
    }

    private void AddHeaderColumn(Panel container, string title, int left, int width)
    {
        var lbl = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 8.2f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(left, 5),
            Size = new Size(width, 20)
        };
        container.Controls.Add(lbl);
    }

    private void CreateQuickActionRow(GlassCard card, string text, Color iconBg, int top, Action onClick)
    {
        var row = new Panel
        {
            Location = new Point(16, top),
            Size = new Size(card.Width - 32, 36),
            BackColor = Color.FromArgb(245, 255, 255, 255),
            Cursor = Cursors.Hand
        };

        var pnlIcon = new Panel
        {
            Location = new Point(6, 6),
            Size = new Size(24, 24),
            BackColor = iconBg
        };

        var lbl = new Label
        {
            Text = text,
            Font = new Font("Segoe UI", 9.2f, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 41, 59),
            Location = new Point(38, 8),
            AutoSize = true
        };

        row.Controls.Add(pnlIcon);
        row.Controls.Add(lbl);
        row.Click += (s, e) => onClick();
        lbl.Click += (s, e) => onClick();
        card.Controls.Add(row);
    }

    private void CreateActivityRow(GlassCard card, string title, string sub, string time, Color dotColor, int top)
    {
        var pnlDot = new Panel
        {
            Location = new Point(18, top + 6),
            Size = new Size(8, 8),
            BackColor = dotColor
        };

        var lblT = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(34, top),
            Size = new Size(180, 20)
        };

        var lblSub = new Label
        {
            Text = sub,
            Font = new Font("Segoe UI", 8.2f),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(34, top + 20),
            Size = new Size(180, 18)
        };

        var lblTime = new Label
        {
            Text = time,
            Font = new Font("Segoe UI", 7.8f),
            ForeColor = Color.FromArgb(148, 163, 184),
            Location = new Point(card.Width - 85, top),
            Size = new Size(75, 18),
            TextAlign = ContentAlignment.TopRight
        };

        card.Controls.Add(pnlDot);
        card.Controls.Add(lblT);
        card.Controls.Add(lblSub);
        card.Controls.Add(lblTime);
    }

    private void DrawSmoothPerformanceWave(Graphics g, Rectangle bounds)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;

        // Points for the wave chart
        PointF[] pts = new[]
        {
            new PointF(20, bounds.Height - 40),
            new PointF(90, bounds.Height - 65),
            new PointF(160, bounds.Height - 50),
            new PointF(230, bounds.Height - 110),
            new PointF(300, bounds.Height - 80),
            new PointF(370, bounds.Height - 145),
            new PointF(440, bounds.Height - 120)
        };

        // Fill area under the curve with purple gradient
        using var path = new GraphicsPath();
        path.AddCurve(pts, 0.45f);
        path.AddLine(pts[pts.Length - 1].X, bounds.Height - 20, pts[0].X, bounds.Height - 20);
        path.CloseFigure();

        using (var fillBrush = new LinearGradientBrush(
            bounds,
            Color.FromArgb(90, 129, 140, 248), // Indigo gradient
            Color.FromArgb(5, 255, 255, 255),
            LinearGradientMode.Vertical))
        {
            g.FillPath(fillBrush, path);
        }

        // Draw glowing purple line
        using (var linePen = new Pen(Color.FromArgb(99, 102, 241), 3f))
        {
            g.DrawCurve(linePen, pts, 0.45f);
        }

        // Draw key indicator dot
        var peak = pts[3];
        g.FillEllipse(Brushes.White, peak.X - 5, peak.Y - 5, 10, 10);
        using (var ringPen = new Pen(Color.FromArgb(79, 70, 229), 2.5f))
        {
            g.DrawEllipse(ringPen, peak.X - 6, peak.Y - 6, 12, 12);
        }
    }

    private void DrawMiniSparkline(Graphics g, Rectangle bounds)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;

        PointF[] pts = new[]
        {
            new PointF(10, bounds.Height - 15),
            new PointF(50, bounds.Height - 25),
            new PointF(90, bounds.Height - 18),
            new PointF(140, bounds.Height - 45),
            new PointF(190, bounds.Height - 30),
            new PointF(240, bounds.Height - 60),
            new PointF(bounds.Width - 10, bounds.Height - 50)
        };

        using var path = new GraphicsPath();
        path.AddCurve(pts, 0.45f);
        path.AddLine(pts[pts.Length - 1].X, bounds.Height, pts[0].X, bounds.Height);
        path.CloseFigure();

        using (var fillBrush = new LinearGradientBrush(
            bounds,
            Color.FromArgb(70, 168, 85, 247), // Purple/Pink wave
            Color.FromArgb(0, 255, 255, 255),
            LinearGradientMode.Vertical))
        {
            g.FillPath(fillBrush, path);
        }

        using (var linePen = new Pen(Color.FromArgb(168, 85, 247), 2.2f))
        {
            g.DrawCurve(linePen, pts, 0.45f);
        }
    }

    private async Task LoadDemoDataAsync()
    {
        try
        {
            var user = SessionManager.CurrentUser;
            if (user != null)
            {
                lblGreeting.Text = $"Xin chào, {user.FullName} 👋";
            }

            using var conn = DatabaseConfig.GetConnection();

            int stuCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
            lblStatStudents.Text = stuCount.ToString();

            int classCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE Status = 'InProgress';");
            lblStatClasses.Text = classCount.ToString();

            lblStatAlerts.Text = "1";
            lblStatRevenue.Text = "5.5M đ";

            // Load sample rows into flow panel
            var students = await conn.QueryAsync<dynamic>(@"
                SELECT s.StudentId, s.StudentCode, s.FullName, COALESCE(c.ClassCode, 'IELTS-K12') AS ClassCode,
                       COALESCE(e.AttendanceRate, 100) AS AttendanceRate, s.Status
                FROM Students s
                LEFT JOIN Enrollments e ON e.StudentId = s.StudentId
                LEFT JOIN Classes c ON e.ClassId = c.ClassId
                LIMIT 5;");

            pnlTableRows.Controls.Clear();
            foreach (var stu in students)
            {
                var rowPanel = new Panel
                {
                    Size = new Size(pnlTableRows.Width - 25, 42),
                    BackColor = Color.FromArgb(235, 255, 255, 255),
                    Margin = new Padding(0, 2, 0, 4)
                };

                var lblName = new Label
                {
                    Text = $"{stu.FullName}\n{stu.StudentCode}",
                    Font = new Font("Segoe UI", 8.8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(15, 23, 42),
                    Location = new Point(10, 4),
                    Size = new Size(215, 34)
                };

                var lblClass = new Label
                {
                    Text = (string)stu.ClassCode,
                    Font = new Font("Segoe UI", 9f),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Location = new Point(235, 11),
                    Size = new Size(125, 20)
                };

                var lblAtt = new Label
                {
                    Text = $"{stu.AttendanceRate}%",
                    Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(21, 128, 61),
                    Location = new Point(370, 11),
                    Size = new Size(95, 20)
                };

                var badgeStatus = new Label
                {
                    Text = " Đang học ",
                    Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(21, 128, 61),
                    BackColor = Color.FromArgb(220, 252, 231),
                    Location = new Point(475, 10),
                    AutoSize = true
                };

                var btnAction = new Button
                {
                    Text = "👁 ✎",
                    Font = new Font("Segoe UI", 8.5f),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(590, 8),
                    Size = new Size(65, 26),
                    Cursor = Cursors.Hand
                };
                btnAction.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);

                rowPanel.Controls.Add(lblName);
                rowPanel.Controls.Add(lblClass);
                rowPanel.Controls.Add(lblAtt);
                rowPanel.Controls.Add(badgeStatus);
                rowPanel.Controls.Add(btnAction);

                pnlTableRows.Controls.Add(rowPanel);
            }
        }
        catch { }
    }
}
