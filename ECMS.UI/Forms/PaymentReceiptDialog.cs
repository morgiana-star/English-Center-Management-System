using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Business.Session;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class PaymentReceiptDialog : Form
{
    private readonly IFinanceService _financeService = new FinanceService();

    private readonly int _invoiceId;
    private readonly string _invoiceCode;
    private readonly string _studentName;
    private readonly string _className;
    private readonly decimal _originalAmount;
    private decimal _balanceDue;

    // Controls
    private Label lblBalance = null!;
    private RadioButton radFull = null!;
    private RadioButton radPartial = null!;
    private TextBox txtPayAmount = null!;
    private ComboBox cboMethod = null!;
    private TextBox txtNote = null!;
    private CustomButton btnConfirm = null!;
    private CustomButton btnPrint = null!;
    
    private string _latestReceiptCode = string.Empty;
    private decimal _latestPaidAmount = 0;

    public PaymentReceiptDialog(int invoiceId, string invoiceCode, string studentName, string className, decimal originalAmount, decimal balanceDue)
    {
        _invoiceId = invoiceId;
        _invoiceCode = invoiceCode;
        _studentName = studentName;
        _className = className;
        _originalAmount = originalAmount;
        _balanceDue = balanceDue;

        InitializeComponents();
    }

    private void InitializeComponents()
    {
        Text = "Xử lý thu học phí & Phát hành biên lai";
        Size = new Size(620, 680);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        BackColor = Color.FromArgb(248, 250, 252);
        Font = new Font("Segoe UI", 10f);

        // 1. Header
        var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 65, BackColor = Color.FromArgb(30, 41, 59) };
        var lblTitle = new Label
        {
            Text = "XỬ LÝ THU HỌC PHÍ & BIÊN LAI (A5)",
            Font = new Font("Segoe UI", 13f, FontStyle.Bold),
            ForeColor = Color.White,
            Location = new Point(20, 18),
            AutoSize = true
        };
        pnlHeader.Controls.Add(lblTitle);

        // 2. Thông tin hóa đơn (GroupBox 1)
        var grpInfo = new GroupBox
        {
            Text = "1. Thông tin học viên & Hóa đơn",
            Location = new Point(20, 80),
            Size = new Size(560, 140),
            ForeColor = Color.FromArgb(15, 23, 42)
        };
        grpInfo.Controls.Add(new Label { Text = $"Mã hóa đơn: {_invoiceCode}", Location = new Point(20, 30), AutoSize = true, Font = new Font("Segoe UI", 10f, FontStyle.Bold) });
        grpInfo.Controls.Add(new Label { Text = $"Học viên:   {_studentName}", Location = new Point(20, 65), AutoSize = true });
        grpInfo.Controls.Add(new Label { Text = $"Lớp học:    {_className}", Location = new Point(20, 100), AutoSize = true });
        grpInfo.Controls.Add(new Label { Text = $"Học phí gốc: {_originalAmount:N0} đ", Location = new Point(320, 30), AutoSize = true });
        
        lblBalance = new Label 
        { 
            Text = $"CÒN NỢ: {_balanceDue:N0} đ", 
            Location = new Point(320, 65), 
            AutoSize = true, 
            Font = new Font("Segoe UI", 11f, FontStyle.Bold), 
            ForeColor = Color.FromArgb(220, 38, 38) 
        };
        grpInfo.Controls.Add(lblBalance);

        // 3. Chế độ nộp tiền linh hoạt (GroupBox 2)
        var grpPayment = new GroupBox
        {
            Text = "2. Lựa chọn đóng tiền (Đóng 1 lần hoặc Nhiều đợt)",
            Location = new Point(20, 235),
            Size = new Size(560, 150),
            ForeColor = Color.FromArgb(15, 23, 42)
        };

        radFull = new RadioButton
        {
            Text = $"Đóng toàn bộ 100% số tiền còn lại ({_balanceDue:N0} đ)",
            Location = new Point(25, 30),
            Size = new Size(480, 25),
            Checked = true
        };

        radPartial = new RadioButton
        {
            Text = "Đóng nhiều đợt / Đóng một phần (Nhập số tiền nộp đợt này):",
            Location = new Point(25, 65),
            Size = new Size(480, 25)
        };

        txtPayAmount = new TextBox
        {
            Location = new Point(45, 100),
            Size = new Size(250, 28),
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            ForeColor = Color.FromArgb(37, 99, 235),
            Text = _balanceDue.ToString("N0"),
            Enabled = false
        };

        var lblVnd = new Label { Text = "VNĐ", Location = new Point(305, 103), AutoSize = true, Font = new Font("Segoe UI", 10f, FontStyle.Bold) };

        radFull.CheckedChanged += (s, e) =>
        {
            if (radFull.Checked)
            {
                txtPayAmount.Enabled = false;
                txtPayAmount.Text = _balanceDue.ToString("N0");
            }
        };

        radPartial.CheckedChanged += (s, e) =>
        {
            if (radPartial.Checked)
            {
                txtPayAmount.Enabled = true;
                txtPayAmount.Clear();
                txtPayAmount.Focus();
            }
        };

        grpPayment.Controls.AddRange(new Control[] { radFull, radPartial, txtPayAmount, lblVnd });

        // 4. Chi tiết phương thức & Ghi chú (GroupBox 3)
        var grpMethod = new GroupBox
        {
            Text = "3. Phương thức thanh toán & Ghi chú",
            Location = new Point(20, 400),
            Size = new Size(560, 130),
            ForeColor = Color.FromArgb(15, 23, 42)
        };

        grpMethod.Controls.Add(new Label { Text = "Hình thức:", Location = new Point(20, 32), AutoSize = true });
        cboMethod = new ComboBox
        {
            Location = new Point(120, 28),
            Size = new Size(400, 28),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        cboMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "POS" });
        cboMethod.SelectedIndex = 0;

        grpMethod.Controls.Add(new Label { Text = "Ghi chú:", Location = new Point(20, 75), AutoSize = true });
        txtNote = new TextBox
        {
            Location = new Point(120, 72),
            Size = new Size(400, 26),
            PlaceholderText = "Nhập ghi chú nộp tiền (nếu có)..."
        };
        grpMethod.Controls.AddRange(new Control[] { cboMethod, txtNote });

        // 5. Nút bấm Thao tác
        btnConfirm = new CustomButton
        {
            Text = "XÁC NHẬN THU TIỀN",
            NormalColor = Color.FromArgb(16, 185, 129),
            HoverColor = Color.FromArgb(5, 150, 105),
            Location = new Point(100, 560),
            Size = new Size(180, 42),
            CornerRadius = 8
        };
        btnConfirm.Click += async (s, e) => await HandlePaymentAsync();

        btnPrint = new CustomButton
        {
            Text = "IN BIÊN LAI A5",
            NormalColor = Color.FromArgb(37, 99, 235),
            HoverColor = Color.FromArgb(29, 78, 216),
            Location = new Point(295, 560),
            Size = new Size(160, 42),
            CornerRadius = 8,
            Enabled = false // Sáng lên sau khi thu tiền thành công
        };
        btnPrint.Click += (s, e) => PrintReceiptA5();

        var btnCancel = new CustomButton
        {
            Text = "ĐÓNG",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(470, 560),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => Close();

        Controls.AddRange(new Control[] { pnlHeader, grpInfo, grpPayment, grpMethod, btnConfirm, btnPrint, btnCancel });
    }

    private async Task HandlePaymentAsync()
    {
        string rawText = txtPayAmount.Text.Replace(",", "").Replace(".", "").Trim();
        if (!decimal.TryParse(rawText, out decimal payAmount) || payAmount <= 0)
        {
            MessageBox.Show("Vui lòng nhập số tiền thanh toán hợp lệ lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (payAmount > _balanceDue)
        {
            MessageBox.Show($"Số tiền nộp không được vượt quá số tiền còn nợ ({_balanceDue:N0} đ)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int cashierId = SessionManager.CurrentUser?.UserId ?? 1;
            string method = cboMethod.SelectedItem?.ToString() ?? "Tiền mặt";
            string note = txtNote.Text.Trim();

            // Gọi Tầng Business (ECMS.Business) - Tuyệt đối không viết SQL trong Form
            var result = await _financeService.ProcessPaymentAsync(_invoiceId, payAmount, method, cashierId, note);

            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _latestReceiptCode = result.ReceiptCode;
            _latestPaidAmount = payAmount;

            // Cập nhật lại số nợ trên form
            _balanceDue -= payAmount;
            lblBalance.Text = $"CÒN NỢ: {_balanceDue:N0} đ";

            MessageBox.Show($"Thu học phí thành công!\nMã biên lai: {_latestReceiptCode}\nSố tiền: {payAmount:N0} đ", 
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnConfirm.Enabled = false;
            btnPrint.Enabled = true; // Cho phép bấm in biên lai A5
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xử lý thu tiền: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PrintReceiptA5()
    {
        var pd = new PrintDocument();
        pd.DefaultPageSettings.PaperSize = new PaperSize("A5", 583, 827); // Khổ A5 (5.83 x 8.27 inch)
        pd.PrintPage += (s, ev) =>
        {
            var g = ev.Graphics!;
            var fontHeader = new Font("Segoe UI", 16f, FontStyle.Bold);
            var fontSub = new Font("Segoe UI", 10f, FontStyle.Regular);
            var fontBold = new Font("Segoe UI", 11f, FontStyle.Bold);

            int y = 40;
            g.DrawString("TRUNG TÂM ANH NGỮ QUỐC TẾ (ECMS)", fontBold, Brushes.Black, 50, y); y += 25;
            g.DrawString("Địa chỉ: Tầng 3, Tòa nhà Đào tạo | Hotline: 1900 6868", fontSub, Brushes.Gray, 50, y); y += 35;
            g.DrawLine(Pens.Gray, 50, y, 530, y); y += 20;

            g.DrawString("BIÊN LAI THU HỌC PHÍ", fontHeader, Brushes.Navy, 160, y); y += 35;
            g.DrawString($"Số phiếu: {_latestReceiptCode}   |   Ngày lập: {DateTime.Now:dd/MM/yyyy HH:mm}", fontSub, Brushes.Black, 110, y); y += 40;

            g.DrawString($"Họ và tên học viên : {_studentName}", fontSub, Brushes.Black, 60, y); y += 25;
            g.DrawString($"Lớp / Khóa học     : {_className}", fontSub, Brushes.Black, 60, y); y += 25;
            g.DrawString($"Mã hóa đơn liên kết: {_invoiceCode}", fontSub, Brushes.Black, 60, y); y += 30;

            g.DrawString($"SỐ TIỀN THU ĐỢT NÀY: {_latestPaidAmount:N0} VNĐ", fontBold, Brushes.DarkGreen, 60, y); y += 28;
            g.DrawString($"Công nợ còn lại    : {_balanceDue:N0} VNĐ", fontSub, Brushes.Red, 60, y); y += 28;
            g.DrawString($"Hình thức thu      : {cboMethod.SelectedItem}", fontSub, Brushes.Black, 60, y); y += 40;

            g.DrawLine(Pens.LightGray, 50, y, 530, y); y += 25;
            g.DrawString("Người nộp tiền", fontBold, Brushes.Black, 90, y);
            g.DrawString("Người lập phiếu", fontBold, Brushes.Black, 370, y); y += 20;
            g.DrawString("(Ký, ghi rõ họ tên)", fontSub, Brushes.Gray, 80, y);
            g.DrawString("(Ký, ghi rõ họ tên)", fontSub, Brushes.Gray, 360, y);
        };

        var dlg = new PrintPreviewDialog { Document = pd, Width = 800, Height = 650 };
        dlg.ShowDialog();
    }
}
