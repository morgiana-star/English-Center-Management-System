using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class ReceiptPrintPreviewDialog : Form
{
    private readonly decimal _amount;
    private readonly string _studentName;
    private readonly string _className;

    public ReceiptPrintPreviewDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 1500000)
    {
    }

    public ReceiptPrintPreviewDialog(string studentName, string className, decimal amount)
    {
        InitializeComponent();
        _studentName = studentName;
        _className = className;
        _amount = amount;

        SetupView();
    }

    private void SetupView()
    {
        cboPrinter.SelectedIndex = 0;
        cboPaperSize.SelectedIndex = 0;

        lblPayerVal.Text = $"{_studentName} · HV-0241";
        lblCourseVal.Text = $"IELTS Foundation / {_className}";
        lblAmountVal.Text = $"{_amount:N0} đ";
        lblPayerSignVal.Text = _studentName;

        btnClosePreview.Click += (s, e) => Close();

        btnPrintTop.Click += (s, e) => ExecutePrint();
        btnPrint.Click += (s, e) => ExecutePrint();
    }

    private void ExecutePrint()
    {
        string printer = cboPrinter.SelectedItem?.ToString() ?? "Máy in mặc định";
        MessageBox.Show(
            $"Đã gửi lệnh in 01 bản phiếu thu PT-261030-018 tới máy in:\n[{printer}]\n\nTrạng thái in: Đang xử lý cục bộ.",
            "In phiếu thu thành công",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        Close();
    }
}
