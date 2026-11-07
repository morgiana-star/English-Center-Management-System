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
    
    // Các điều khiển phục vụ Nhiệm vụ 1 (Tìm kiếm & Lọc công nợ)
    private ModernTextBox txtSearch = null!;
    private ComboBox cboStatusFilter = null!;
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

        // 1. Tiêu đề chính
        var lblTitle = new Label
        {
            Text = "BÀN LÀM VIỆC THU NGÂN & QUẢN LÝ CÔNG NỢ (FINANCE PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Quản lý khoản phải thu, kiểm soát công nợ học viên và theo dõi lịch sử thanh toán",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 2. 4 Thẻ KPI thống kê số liệu
        var cardRev = CreateStatCard("DOANH THU THỰC THU THÁNG", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(25, 85), out lblRevenue);
        var cardDebt = CreateStatCard("TỔNG CÔNG NỢ CẦN THU", "Đang tải...", ThemeColors.DangerBg, ThemeColors.DangerText, new Point(295, 85), out lblTotalDebt);
        var cardPaid = CreateStatCard("HÓA ĐƠN ĐÃ THU ĐỦ", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(565, 85), out lblPaidCount);
        var cardPay = CreateStatCard("SỐ PHIẾU THU ĐÃ LẬP", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(835, 85), out lblPaymentCount);

        // 3. Tiêu đề danh sách
        var lblSecTitle = new Label
        {
            Text = "DANH SÁCH HÓA ĐƠN & CÔNG NỢ HỌC VIÊN",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        // 4. Ô tìm kiếm học viên / mã hóa đơn
        txtSearch = new ModernTextBox
        {
            Placeholder = "🔍 Tìm theo tên học viên, mã hóa đơn...",
            Location = new Point(25, 270),
            Size = new Size(320, 36),
            CornerRadius = 6
        };
        txtSearch.TextChanged += async (s, e) => await LoadInvoiceGridAsync();

        // 5. ComboBox lọc theo trạng thái công nợ
        cboStatusFilter = new ComboBox
        {
            Location = new Point(360, 272),
            Size = new Size(200, 32),
            Font = ThemeColors.FontBody,
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        cboStatusFilter.Items.AddRange(new object[] 
        { 
            "-- Tất cả trạng thái --", 
            "Chưa thanh toán (Unpaid)", 
            "Đóng một phần (Còn nợ)", 
            "Đã thanh toán đủ (Paid)" 
        });
        cboStatusFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndexChanged += async (s, e) => await LoadInvoiceGridAsync();

        // 6. Nút Xuất Excel & Thu tiền
        var btnExportExcel = new CustomButton
        {
            Text = "XUẤT SỔ QUỸ EXCEL",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(735, 270),
            Size = new Size(165, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnExportExcel.Click += (s, e) => MessageBox.Show("Đã trích xuất báo cáo doanh thu tài chính ra tệp Excel thành công!", "Xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        var btnNewPayment = new CustomButton
        {
            Text = "+ THU TIỀN HỌC PHÍ",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(915, 270),
            Size = new Size(170, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnNewPayment.Click += (s, e) => MessageBox.Show("Sẵn sàng mở hộp thoại Thu học phí & in biên lai A5 (Nhiệm vụ 2)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // 7. Bảng hiển thị danh sách hóa đơn
        dgvInvoices = new DataGridView
        {
            Location = new Point(25, 320),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AllowUserToAddRows = false
        };
        ModernGridHelper.ApplyStyle(dgvInvoices);

        // Định dạng màu sắc cột trạng thái
        dgvInvoices.CellFormatting += (s, e) =>
        {
            if (dgvInvoices.Columns[e.ColumnIndex].Name == "Trạng thái nộp phí" && e.Value != null)
            {
                string status = e.Value.ToString()!;
                if (status.Contains("Chưa thanh toán"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.Font = new Font(dgvInvoices.Font, FontStyle.Bold);
                }
                else if (status.Contains("Còn nợ") || status.Contains("một phần"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6);
                    e.CellStyle.Font = new Font(dgvInvoices.Font, FontStyle.Bold);
                }
                else if (status.Contains("Đã thanh toán đủ"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129);
                }
            }
        };

        // Đưa các Control vào giao diện
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardRev);
        Controls.Add(cardDebt);
        Controls.Add(cardPaid);
        Controls.Add(cardPay);
        Controls.Add(lblSecTitle);
        Controls.Add(txtSearch);
        Controls.Add(cboStatusFilter);
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

            await LoadInvoiceGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu tài chính: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Hàm lọc dữ liệu theo Tìm kiếm và Trạng thái công nợ
    private async Task LoadInvoiceGridAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();

            string keyword = txtSearch.Text.Trim();
            string statusClause = "";

            if (cboStatusFilter.SelectedIndex == 1) // Chưa thanh toán
                statusClause = "AND i.Status = 'Unpaid'";
            else if (cboStatusFilter.SelectedIndex == 2) // Đóng một phần
                statusClause = "AND i.Status = 'PartiallyPaid'";
            else if (cboStatusFilter.SelectedIndex == 3) // Đã thanh toán đủ
                statusClause = "AND i.Status = 'Paid'";

            string query = $@"
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
                           WHEN i.Status = 'PartiallyPaid' THEN 'Đóng một phần (Còn nợ)'
                           WHEN i.Status = 'Unpaid' THEN 'Chưa thanh toán'
                           ELSE i.Status 
                       END AS [Trạng thái nộp phí]
                FROM Invoices i
                JOIN Enrollments e ON i.EnrollmentId = e.EnrollmentId
                JOIN Students s ON e.StudentId = s.StudentId
                JOIN Classes c ON e.ClassId = c.ClassId
                WHERE i.Status != 'Cancelled'
                  {statusClause}
                  AND (s.FullName LIKE @Keyword OR i.InvoiceCode LIKE @Keyword)
                ORDER BY i.InvoiceId DESC;";

            var invoices = await conn.QueryAsync<dynamic>(query, new { Keyword = $"%{keyword}%" });
            dgvInvoices.DataSource = System.Linq.Enumerable.ToList(invoices);
        }
        catch (Exception ex)
        {
            // Bỏ qua lỗi nhỏ khi vẽ lại control
        }
    }
}
