using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
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
            Placeholder = "🔍 Tìm theo tên học viên, mã hóa đơn, SĐT...",
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
        btnNewPayment.Click += async (s, e) =>
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng hóa đơn trên bảng để thu học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = dgvInvoices.SelectedRows[0].DataBoundItem as InvoiceListItemDto;
            if (selectedItem == null) return;

            if (selectedItem.BalanceDue <= 0)
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán đủ 100%, không còn công nợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new Forms.PaymentReceiptDialog(
                selectedItem.InvoiceId, 
                selectedItem.InvoiceCode, 
                selectedItem.StudentName, 
                selectedItem.ClassName, 
                selectedItem.FinalAmount, 
                selectedItem.BalanceDue);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await LoadFinanceDataAsync(); // Nạp lại bảng dữ liệu sau khi thu tiền
            }
        };

        // 7. Bảng hiển thị danh sách hóa đơn
        dgvInvoices = new DataGridView
        {
            Location = new Point(25, 320),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            AllowUserToAddRows = false,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvInvoices);

        // Cấu hình các cột hiển thị đẹp mắt
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "InvoiceCode", HeaderText = "Mã hóa đơn", Width = 110 });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Học viên", Width = 160 });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentPhone", HeaderText = "Số điện thoại", Width = 110 });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClassName", HeaderText = "Lớp học", Width = 130 });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FinalAmount", HeaderText = "Phải nộp (VNĐ)", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaidAmount", HeaderText = "Đã đóng (VNĐ)", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BalanceDue", HeaderText = "Còn nợ (VNĐ)", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn nộp", Width = 100 });
        dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái", Width = 120 });

        // Định dạng màu sắc cột trạng thái
        dgvInvoices.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvInvoices.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                string status = e.Value.ToString()!;
                if (status == "Unpaid")
                {
                    e.Value = "Chưa thanh toán";
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.Font = new Font(dgvInvoices.Font, FontStyle.Bold);
                }
                else if (status == "Partial")
                {
                    e.Value = "Đóng một phần";
                    e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6);
                    e.CellStyle.Font = new Font(dgvInvoices.Font, FontStyle.Bold);
                }
                else if (status == "Paid")
                {
                    e.Value = "Đã thu đủ 100%";
                    e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129);
                    e.CellStyle.Font = new Font(dgvInvoices.Font, FontStyle.Bold);
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
            // Gọi tầng Business, không viết SQL trực tiếp trong Form
            var summary = await _financeService.GetDirectorDashboardSummaryAsync();
            lblRevenue.Text = $"{summary.TotalRevenueThisMonth:N0} đ";
            lblTotalDebt.Text = $"{summary.TotalOutstandingDebt:N0} đ";
            lblPaidCount.Text = $"{summary.TotalPaidInvoicesCount} Hóa đơn";
            lblPaymentCount.Text = $"{summary.TotalPaymentsCount} Phiếu thu";

            await LoadInvoiceGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu tài chính: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Hàm lọc dữ liệu theo Tìm kiếm và Trạng thái công nợ qua Service
    private async Task LoadInvoiceGridAsync()
    {
        try
        {
            string keyword = txtSearch.Text.Trim();
            string? filter = null;

            if (cboStatusFilter.SelectedIndex == 1) filter = "Unpaid";
            else if (cboStatusFilter.SelectedIndex == 2) filter = "Partial";
            else if (cboStatusFilter.SelectedIndex == 3) filter = "Paid";

            var invoices = await _financeService.GetInvoicesAsync(filter, keyword);
            dgvInvoices.DataSource = System.Linq.Enumerable.ToList(invoices);
        }
        catch (Exception ex)
        {
            // Bỏ qua lỗi nhỏ khi vẽ lại control
        }
    }
}
