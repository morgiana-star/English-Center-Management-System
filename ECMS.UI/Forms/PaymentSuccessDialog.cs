using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class PaymentSuccessDialog : Form
{
    private readonly decimal _amount;
    private readonly decimal _prevDebt;
    private readonly string _studentName;
    private readonly string _className;

    public PaymentSuccessDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 1500000, 3400000)
    {
    }

    public PaymentSuccessDialog(string studentName, string className, decimal amount, decimal prevDebt)
    {
        InitializeComponent();
        _studentName = studentName;
        _className = className;
        _amount = amount;
        _prevDebt = prevDebt;

        SetupView();
    }

    private void SetupView()
    {
        bannerSuccess.Text = $"✓ Thu thành công {_amount:N0}đ. Đã lưu phiếu thu và cập nhật số dư trong SQLite. Chưa in phiếu.";

        lblStudentVal.Text = $"{_studentName} · HV-0241";
        lblClassVal.Text = $"{_className} (IELTS Foundation)";
        lblAmountVal.Text = $"{_amount:N0} đ";

        decimal newPaid = 2000000 + _amount;
        decimal newDebt = Math.Max(0, _prevDebt - _amount);

        lblNewPaidAmtVal.Text = $"{_amount:N0}đ";
        lblTotalPaidVal.Text = $"{newPaid:N0}đ";
        lblRemainingVal.Text = $"{newDebt:N0}đ";

        btnBackToDebt.Click += (s, e) => Close();

        btnPreviewPrint.Click += (s, e) => OpenReceiptPreview();
        btnViewPrintReceipt.Click += (s, e) => OpenReceiptPreview();

        btnOpenStudentProfile.Click += (s, e) =>
        {
            using var detailDlg = new StudentDetailDialog("HV-0241", _studentName);
            detailDlg.ShowDialog(this);
        };
    }

    private void OpenReceiptPreview()
    {
        using var previewDlg = new ReceiptPrintPreviewDialog(_studentName, _className, _amount);
        previewDlg.ShowDialog(this);
    }
}
