using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class DashboardView : UserControl
{
    private readonly IFinanceService _financeService = new FinanceService();
    private readonly IAttendanceService _attendanceService = new AttendanceService();

    private Label lblRevenue = null!;
    private Label lblAlertCount = null!;
    private Label lblActiveClassCount = null!;
    private Label lblActiveStudentCount = null!;
    private DataGridView dgvAlerts = null!;

    public DashboardView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadDashboardDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        var lblTitle = new Label
        {
            Text = "BÀN LÀM VIỆC ĐIỀU HÀNH CHIẾN LƯỢC (DIRECTOR DASHBOARD)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Theo dõi doanh thu thực thu, chất lượng đào tạo và cảnh báo học thuật thời gian thực",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardRevenue = CreateStatCard("DOANH THU THỰC THU THÁNG", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(25, 85), out lblRevenue);
        var cardAlert = CreateStatCard("HỌC VIÊN VẮNG >= 3 BUỔI", "Đang tải...", ThemeColors.DangerBg, ThemeColors.DangerText, new Point(295, 85), out lblAlertCount);
        var cardClasses = CreateStatCard("LỚP HỌC ĐANG HOẠT ĐỘNG", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(565, 85), out lblActiveClassCount);
        var cardStudents = CreateStatCard("TỔNG HỌC VIÊN ĐANG HỌC", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(835, 85), out lblActiveStudentCount);

        // Section Action Bar
        var lblSectionAlerts = new Label
        {
            Text = "DANH SÁCH HỌC VIÊN NGUY CƠ (VẮNG >= 3 BUỔI CẦN PHỐI HỢP PHỤ HUYNH)",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.DangerText,
            Location = new Point(25, 235),
            AutoSize = true
        };

        var btnRefresh = new CustomButton
        {
            Text = "LÀM MỚI DỮ LIỆU",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(935, 228),
            Size = new Size(150, 34),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnRefresh.Click += async (s, e) => await LoadDashboardDataAsync();

        dgvAlerts = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvAlerts);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardRevenue);
        Controls.Add(cardAlert);
        Controls.Add(cardClasses);
        Controls.Add(cardStudents);
        Controls.Add(lblSectionAlerts);
        Controls.Add(btnRefresh);
        Controls.Add(dgvAlerts);
    }

    private GlassCard CreateStatCard(string title, string initialValue, Color bg, Color textColor, Point location, out Label valueLabel)
    {
        var card = new GlassCard
        {
            Location = location,
            Size = new Size(250, 125),
            GlassColor = bg,
            BorderGlowColor = ThemeColors.GlassBorder,
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblT = new Label
        {
            Text = title,
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(16, 15),
            AutoSize = true
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = textColor,
            Location = new Point(16, 45),
            Size = new Size(220, 45),
            TextAlign = ContentAlignment.MiddleLeft
        };

        card.Controls.Add(lblT);
        card.Controls.Add(valueLabel);
        return card;
    }

    private async Task LoadDashboardDataAsync()
    {
        try
        {
            decimal revenue = await _financeService.GetTotalRevenueThisMonthAsync();
            lblRevenue.Text = $"{revenue:N0} đ";

            var alerts = await _attendanceService.GetAbsenceAlertListAsync();
            var alertList = System.Linq.Enumerable.ToList(alerts);
            lblAlertCount.Text = $"{alertList.Count} học viên";
            dgvAlerts.DataSource = alertList;

            using var conn = DatabaseConfig.GetConnection();
            int activeClasses = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE Status = 'InProgress';");
            lblActiveClassCount.Text = $"{activeClasses} Lớp học";

            int activeStudents = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Active';");
            lblActiveStudentCount.Text = $"{activeStudents} Học viên";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu Dashboard: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
