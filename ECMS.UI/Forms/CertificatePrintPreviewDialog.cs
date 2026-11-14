using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class CertificatePrintPreviewDialog : Form
{
    private readonly string _studentName;
    private readonly string _studentCode;
    private readonly string _certSerial;

    public CertificatePrintPreviewDialog() : this("Trần Gia Bảo", "HV-0204", "CC-2026-0042")
    {
    }

    public CertificatePrintPreviewDialog(string studentName, string studentCode, string certSerial)
    {
        InitializeComponent();
        _studentName = studentName;
        _studentCode = studentCode;
        _certSerial = certSerial;

        SetupView();
    }

    private void SetupView()
    {
        cboPrinter.SelectedIndex = 0;
        cboPaperSize.SelectedIndex = 0;

        lblStudentFullName.Text = _studentName.ToUpper();
        lblStudentInfoLine.Text = $"Ngày sinh: 12/03/2007 · Mã học viên: {_studentCode}";
        lblCertSerialBottom.Text = $"Số chứng chỉ: {_certSerial}";

        btnClose.Click += (s, e) => Close();

        btnPrintCert.Click += (s, e) =>
        {
            string printer = cboPrinter.SelectedItem?.ToString() ?? "Máy in mặc định";
            MessageBox.Show(
                $"Đã gửi lệnh in 01 bản Chứng chỉ tốt nghiệp {_certSerial} tới máy in:\n[{printer}]\n\nKhổ giấy: A4 ngang · Độ phân giải 300 DPI.",
                "In chứng chỉ thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            Close();
        };
    }
}
