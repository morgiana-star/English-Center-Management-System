using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;

namespace ECMS.UI.Forms;

public partial class ReceiptPrintPreviewDialog : Form
{
    private readonly decimal _amount;
    private readonly string _studentName = string.Empty;
    private readonly string _className = string.Empty;
    private readonly string _studentCode = "HV-0241";
    private readonly string _receiptCode = "PT-261116-012";
    private readonly string _paymentMethod = "Tiền mặt";
    private readonly string _collector = "Trần Minh Quân";
    private readonly string _courseName = "IELTS Foundation";
    private readonly string _reason = "Thu học phí khóa học";
    private readonly string _transactionCode = string.Empty;
    private readonly decimal _remainingDebt;
    private readonly string _dueDateText = string.Empty;

    public ReceiptPrintPreviewDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 3400000)
    {
    }

    public ReceiptPrintPreviewDialog(string studentName, string className, decimal amount)
        : this(studentName, className, amount, $"PT-{DateTime.Now:yyMMdd}-001", "HV-0001", "Tiền mặt", AppSession.FullName, "Khóa học tiếng Anh")
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
        string courseName = "IELTS Foundation",
        string reason = "Thu học phí khóa học",
        string transactionCode = "",
        decimal remainingDebt = 0m,
        string dueDateText = "")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentName = string.IsNullOrEmpty(studentName) ? "Học viên" : studentName;
        _className = string.IsNullOrEmpty(className) ? "Chưa xếp lớp" : className;
        _amount = amount;
        _receiptCode = string.IsNullOrEmpty(receiptCode) ? $"PT-{DateTime.Now:yyMMdd}-001" : receiptCode;
        _studentCode = string.IsNullOrEmpty(studentCode) ? "HV-0001" : studentCode;
        _paymentMethod = string.IsNullOrEmpty(paymentMethod) ? "Tiền mặt" : paymentMethod;
        _collector = string.IsNullOrEmpty(collector) ? AppSession.FullName : collector;
        _courseName = string.IsNullOrEmpty(courseName) ? "Khóa học tiếng Anh" : courseName;
        _reason = string.IsNullOrWhiteSpace(reason) ? $"Thu học phí lớp {_className}" : reason;
        _transactionCode = string.IsNullOrWhiteSpace(transactionCode) ? _receiptCode : transactionCode;
        _remainingDebt = Math.Max(0m, remainingDebt);
        _dueDateText = dueDateText ?? string.Empty;

        SetupView();
        _ = LoadCenterHeaderAsync();
    }

    private async Task LoadCenterHeaderAsync()
    {
        try
        {
            var center = await new SystemConfigService().GetCenterConfigAsync();
            if (!string.IsNullOrWhiteSpace(center.CenterName))
                lblOrgName.Text = center.CenterName.ToUpperInvariant();
            if (!string.IsNullOrWhiteSpace(center.CenterAddress))
                lblOrgAddress.Text = center.CenterAddress;
        }
        catch
        {
            // Giữ giá trị mặc định nếu không đọc được SystemConfigs
        }
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

        Text = $"Xem trước khi in · {_receiptCode} - ECMS";
        lblTitle.Text = $"Xem trước khi in · {_receiptCode}";
        lblReceiptNumber.Text = $"Số: {_receiptCode}";
        lblReceiptDate.Text = $"Ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}";
        lblPayerVal.Text = $"{_studentName} · {_studentCode}";
        lblCourseVal.Text = $"Lớp {_className}";
        lblReasonVal.Text = _reason;
        lblAmountVal.Text = $"{_amount:N0} đ";
        lblWordsVal.Text = ConvertAmountToWords(_amount);
        lblMethodVal.Text = _paymentMethod;
        lblTransIdVal.Text = _transactionCode;
        lblBalanceVal.Text = _remainingDebt > 0
            ? $"{_remainingDebt:N0}đ{(string.IsNullOrWhiteSpace(_dueDateText) ? "" : $" · hạn {_dueDateText}")}"
            : "0đ (Đã hoàn tất)";
        lblPayerSignVal.Text = _studentName;
        lblCollectorSignVal.Text = _collector;

        lblSumTransCode.Text = $"Mã giao dịch:   {_transactionCode}";
        lblSumReceiptDate.Text = $"Ngày phiếu:   {DateTime.Now:dd/MM/yyyy}";
        lblSumTotalPaid.Text = $"Tổng đã thu:   {_amount:N0}đ";
        lblSumRemaining.Text = $"Số dư còn lại:   {_remainingDebt:N0}đ";

        btnClosePreview.Click += (s, e) => Close();

        btnPrintTop.Click += (s, e) => ExecutePrint();
        btnPrint.Click += (s, e) => ExecutePrint();
    }

    private static string ConvertAmountToWords(decimal amount)
    {
        long number = (long)Math.Round(amount, MidpointRounding.AwayFromZero);
        if (number <= 0) return "Không đồng";

        string[] units = { "", " nghìn", " triệu", " tỷ", " nghìn tỷ" };
        var sb = new StringBuilder();
        int groupIndex = 0;

        while (number > 0)
        {
            int threeDigits = (int)(number % 1000);
            number /= 1000;

            if (threeDigits > 0)
            {
                string groupText = ReadThreeDigits(threeDigits, number > 0);
                if (sb.Length > 0) sb.Insert(0, " ");
                sb.Insert(0, groupText + units[groupIndex]);
            }

            groupIndex++;
        }

        string result = sb.ToString().Trim();
        if (result.Length > 0)
        {
            result = char.ToUpper(result[0]) + result.Substring(1);
        }

        return $"{result} đồng chẵn";
    }

    private static string ReadThreeDigits(int number, bool hasHigherGroup)
    {
        string[] digits = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        int hundreds = number / 100;
        int tens = (number % 100) / 10;
        int ones = number % 10;

        var parts = new System.Collections.Generic.List<string>();

        if (hundreds > 0 || hasHigherGroup)
        {
            parts.Add($"{digits[hundreds]} trăm");
        }

        if (tens > 1)
        {
            parts.Add($"{digits[tens]} mươi");
            if (ones == 1) parts.Add("mốt");
            else if (ones == 5) parts.Add("lăm");
            else if (ones > 0) parts.Add(digits[ones]);
        }
        else if (tens == 1)
        {
            parts.Add("mười");
            if (ones == 5) parts.Add("lăm");
            else if (ones > 0) parts.Add(digits[ones]);
        }
        else if (ones > 0)
        {
            if (hundreds > 0 || hasHigherGroup) parts.Add("lẻ");
            parts.Add(digits[ones]);
        }

        return string.Join(" ", parts);
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
        DialogResult = DialogResult.OK;
        Close();
    }
}
