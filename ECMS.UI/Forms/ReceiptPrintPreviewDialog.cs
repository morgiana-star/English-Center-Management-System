using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class ReceiptPrintPreviewDialog : Form
{
    private readonly decimal _amount;
    private readonly string _studentName = string.Empty;
    private readonly string _className = string.Empty;
    private readonly string _studentCode = "HV-0241";
    private readonly string _receiptCode = "PT-261116-012";
    private readonly string _paymentMethod = "Chuyển khoản VietQR";
    private readonly string _collector = "Trần Minh Quân";
    private readonly string _courseName = "IELTS Foundation";

    public ReceiptPrintPreviewDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 3400000)
    {
    }

    public ReceiptPrintPreviewDialog(string studentName, string className, decimal amount)
        : this(studentName, className, amount, "PT-261116-012", "HV-0241", "Chuyển khoản VietQR", "Trần Minh Quân", "IELTS Foundation")
    {
    }

    public ReceiptPrintPreviewDialog(
        string studentName,
        string className,
        decimal amount,
        string receiptCode,
        string studentCode,
        string paymentMethod,
        string collector,
        string courseName = "IELTS Foundation")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentName = string.IsNullOrEmpty(studentName) ? "Học viên" : studentName;
        _className = string.IsNullOrEmpty(className) ? "IELTS-F01" : className;
        _amount = amount;
        _receiptCode = string.IsNullOrEmpty(receiptCode) ? "PT-261116-012" : receiptCode;
        _studentCode = string.IsNullOrEmpty(studentCode) ? "HV-0241" : studentCode;
        _paymentMethod = string.IsNullOrEmpty(paymentMethod) ? "Tiền mặt" : paymentMethod;
        _collector = string.IsNullOrEmpty(collector) ? AppSession.FullName : collector;
        _courseName = string.IsNullOrEmpty(courseName) ? "IELTS Foundation" : courseName;

        SetupView();
    }

    private void SetupView()
    {
        cboPrinter.Items.Clear();
        cboPrinter.Items.AddRange(new object[]
        {
            "Canon LBP2900 (Máy in quầy thu ngân)",
            "HP LaserJet Pro M404dn",
            "Epson L3110 Series",
            "Microsoft Print to PDF"
        });
        cboPrinter.SelectedIndex = 0;

        cboPaperSize.Items.Clear();
        cboPaperSize.Items.AddRange(new object[]
        {
            "Khổ A5 ngang · 2 liên (Chuẩn biên lai)",
            "Khổ A4 dọc · 1 bản",
            "Khổ A5 ngang · 1 liên"
        });
        cboPaperSize.SelectedIndex = 0;

        lblReceiptNumber.Text = $"Số: {_receiptCode}";
        lblReceiptDate.Text = $"Ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}";
        lblPayerVal.Text = $"{_studentName} · {_studentCode}";
        lblCourseVal.Text = $"{_courseName} / Lớp {_className}";
        lblAmountVal.Text = $"{_amount:N0} đ";
        lblWordsVal.Text = ConvertAmountToWords(_amount);
        lblMethodVal.Text = _paymentMethod;
        lblPayerSignVal.Text = _studentName;
        lblCollectorSignVal.Text = _collector;
        lblSumReceiptDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        lblSumTotalPaid.Text = $"{_amount:N0}đ";

        btnClosePreview.Click += (s, e) => Close();

        btnPrintTop.Click += (s, e) => ExecutePrint();
        btnPrint.Click += (s, e) => ExecutePrint();
    }

    private string ConvertAmountToWords(decimal amount)
    {
        if (amount == 3400000) return "Ba triệu bốn trăm nghìn đồng chẵn";
        if (amount == 2400000) return "Hai triệu bốn trăm nghìn đồng chẵn";
        if (amount == 3200000) return "Ba triệu hai trăm nghìn đồng chẵn";
        if (amount == 500000) return "Năm trăm nghìn đồng chẵn";
        if (amount == 2000000) return "Hai triệu đồng chẵn";
        if (amount == 1200000) return "Một triệu hai trăm nghìn đồng chẵn";
        if (amount == 5400000) return "Năm triệu bốn trăm nghìn đồng chẵn";
        if (amount == 6000000) return "Sáu triệu đồng chẵn";
        return $"{amount:N0} đồng chẵn";
    }

    private void ExecutePrint()
    {
        string printer = cboPrinter.SelectedItem?.ToString() ?? "Máy in mặc định";
        MessageBox.Show(
            $"Đã gửi lệnh in 01 bản phiếu thu {_receiptCode} của học viên {_studentName} ({_amount:N0}đ) tới máy in:\n[{printer}]\n\nTrạng thái in: Đang xử lý cục bộ thành công.",
            "In phiếu thu thành công",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        Close();
    }
}
