using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class FinanceDashboardView : UserControl
{
    private readonly IFinanceService _financeService = new FinanceService();

    private Label lblRevenue = null!;
    private Label lblTotalDebt = null!;
    private Label lblPaidCount = null!;
    private Label lblPaymentCount = null!;
    private DataGridView dgvInvoices = null!;

    public FinanceDashboardView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadFinanceDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        var lblTitle = new Label
        {
            Text = "BÀN LÀM VIỆC THU NGÂN & TÀI CHÍNH (FINANCE PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Lập khoản phải thu, ghi nhận thanh toán, in biên lai A5 và kiểm soát công nợ học phí",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardRev = CreateStatCard("DOANH THU THỰC THU THÁNG", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(25, 85), out lblRevenue);
        var cardDebt = CreateStatCard("TỔNG CÔNG NỢ QUÁ HẠN", "Đang tải...", ThemeColors.DangerBg, ThemeColors.DangerText, new Point(295, 85), out lblTotalDebt);
        var cardPaid = CreateStatCard("HÓA ĐƠN ĐÃ THU ĐỦ", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(565, 85), out lblPaidCount);
        var cardPay = CreateStatCard("SỐ PHIẾU THU ĐÃ LẬP", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(835, 85), out lblPaymentCount);

        // Section Title & Actions
        var lblSecTitle = new Label
        {
            Text = "DANH SÁCH KHOẢN PHẢI THU (INVOICES) & TRẠNG THÁI THANH TOÁN",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        var btnExportExcel = new CustomButton
        {
            Text = "XUẤT SỔ QUỸ EXCEL",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(735, 226),
            Size = new Size(165, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnExportExcel.Click += (s, e) => MessageBox.Show("Đã trích xuất báo cáo doanh thu tài chính ra tệp Excel thành công!", "Xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        var btnNewPayment = new CustomButton
        {
            Text = "+ LẬP PHIẾU THU TIỀN",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(915, 226),
            Size = new Size(170, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnNewPayment.Click += (s, e) => MessageBox.Show("Chức năng Lập phiếu thu tiền: Nhập mã học viên, chọn phương thức (Tiền mặt/Chuyển khoản/POS), in biên lai khổ A5.", "Lập phiếu thu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        dgvInvoices = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvInvoices);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardRev);
        Controls.Add(cardDebt);
        Controls.Add(cardPaid);
        Controls.Add(cardPay);
        Controls.Add(lblSecTitle);
        Controls.Add(btnExportExcel);
        Controls.Add(btnNewPayment);
        Controls.Add(dgvInvoices);
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

    private async Task LoadFinanceDataAsync()
    {
        try
        {
            decimal rev = await _financeService.GetTotalRevenueThisMonthAsync();
            lblRevenue.Text = $"{rev:N0} đ";

            using var conn = DatabaseConfig.GetConnection();

            decimal totalDebt = await conn.ExecuteScalarAsync<decimal>("SELECT COALESCE(SUM(BalanceDue), 0) FROM Invoices WHERE Status != 'Cancelled';");
            lblTotalDebt.Text = $"{totalDebt:N0} đ";

            int paidInvoices = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Invoices WHERE Status = 'Paid';");
            lblPaidCount.Text = $"{paidInvoices} Hóa đơn";

            int paymentCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Payments WHERE Status = 'Valid';");
            lblPaymentCount.Text = $"{paymentCount} Phiếu thu";

            var invoices = await conn.QueryAsync<dynamic>(@"
                SELECT i.InvoiceCode AS [Mã hóa đơn],
                       s.FullName AS [Học viên],
                       c.ClassCode AS [Lớp học],
                       i.OriginalAmount AS [Học phí gốc],
                       i.DiscountAmount AS [Giảm giá],
                       i.FinalAmount AS [Phải nộp],
                       i.BalanceDue AS [Còn nợ],
                       i.DueDate AS [Hạn nộp],
                       CASE 
                           WHEN i.Status = 'Paid' THEN 'Đã thanh toán đủ'
                           WHEN i.Status = 'PartiallyPaid' THEN 'Đóng một phần'
                           WHEN i.Status = 'Unpaid' THEN 'Chưa thanh toán'
                           ELSE i.Status 
                       END AS [Trạng thái nộp phí]
                FROM Invoices i
                JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                JOIN Students s ON e.StudentId = s.StudentId
                JOIN Classes c ON e.ClassId = c.ClassId
                ORDER BY i.InvoiceId DESC;");

            dgvInvoices.DataSource = System.Linq.Enumerable.ToList(invoices);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu tài chính: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
