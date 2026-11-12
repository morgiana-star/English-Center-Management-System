using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class DashboardView : UserControl
{
    private readonly IFinanceService _financeService = new FinanceService();
    private readonly IAttendanceService _attendanceService = new AttendanceService();

    private Label lblRevenue = null!;
    private Label lblTotalDebt = null!;
    private Label lblActiveClassCount = null!;
    private Label lblActiveStudentCount = null!;
    private DataGridView dgvTodayPayments = null!;
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
            Text = "Theo dõi doanh thu thực thu, kiểm soát công nợ, sĩ số và nhật ký giao dịch trong ngày",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards chuẩn Giám đốc
        var cardRevenue = CreateStatCard("DOANH THU THỰC THU THÁNG", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(25, 85), out lblRevenue);
        var cardDebt = CreateStatCard("TỔNG CÔNG NỢ TRUNG TÂM", "Đang tải...", ThemeColors.DangerBg, ThemeColors.DangerText, new Point(295, 85), out lblTotalDebt);
        var cardStudents = CreateStatCard("HỌC VIÊN ĐANG THEO HỌC", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblActiveStudentCount);
        var cardClasses = CreateStatCard("LỚP ĐANG HOẠT ĐỘNG", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(835, 85), out lblActiveClassCount);

        // Section 1: Nhật ký thu tiền hôm nay
        var lblSecPayments = new Label
        {
            Text = "NHẬT KÝ GIAO DỊCH THU TIỀN HÔM NAY",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
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

        dgvTodayPayments = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 200),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AllowUserToAddRows = false,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvTodayPayments);

        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaymentCode", HeaderText = "Mã phiếu thu", Width = 140 });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "InvoiceCode", HeaderText = "Mã hóa đơn", Width = 120 });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Học viên", Width = 180 });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClassName", HeaderText = "Lớp học", Width = 150 });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaidAmount", HeaderText = "Số tiền thu (VNĐ)", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaymentMethod", HeaderText = "Phương thức", Width = 120 });
        dgvTodayPayments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaymentTime", HeaderText = "Thời gian thu", Width = 160 });

        // Section 2: Cảnh báo học viên vắng >= 3 buổi
        var lblSecAlerts = new Label
        {
            Text = "CẢNH BÁO CHUYÊN CẦN NGUY CƠ (VẮNG >= 3 BUỔI CẦN PHỐI HỢP)",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.DangerText,
            Location = new Point(25, 490),
            AutoSize = true
        };

        dgvAlerts = new DataGridView
        {
            Location = new Point(25, 525),
            Size = new Size(1060, 180),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AllowUserToAddRows = false
        };
        ModernGridHelper.ApplyStyle(dgvAlerts);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardRevenue);
        Controls.Add(cardDebt);
        Controls.Add(cardStudents);
        Controls.Add(cardClasses);
        Controls.Add(lblSecPayments);
        Controls.Add(btnRefresh);
        Controls.Add(dgvTodayPayments);
        Controls.Add(lblSecAlerts);
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
            // Gọi tầng Business, hoàn toàn không có câu lệnh SQL nào trong Form
            var summary = await _financeService.GetDirectorDashboardSummaryAsync();
            lblRevenue.Text = $"{summary.TotalRevenueThisMonth:N0} đ";
            lblTotalDebt.Text = $"{summary.TotalOutstandingDebt:N0} đ";
            lblActiveStudentCount.Text = $"{summary.TotalActiveStudents} Học viên";
            lblActiveClassCount.Text = $"{summary.TotalActiveClasses} Lớp học";

            var todayPayments = await _financeService.GetTodayTransactionsAsync();
            dgvTodayPayments.DataSource = System.Linq.Enumerable.ToList(todayPayments);

            var alerts = await _attendanceService.GetAbsenceAlertListAsync();
            dgvAlerts.DataSource = System.Linq.Enumerable.ToList(alerts);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu Dashboard: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
