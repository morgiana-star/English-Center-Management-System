using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class CertificatePrintPreviewDialog : Form
{
    private readonly string _studentName = string.Empty;
    private readonly string _studentCode = string.Empty;
    private readonly string _certSerial = string.Empty;
    private readonly string _courseName = "IELTS Foundation";
    private readonly string _className = "IELTS-F02";
    private readonly string _gradeRank = "Khá";
    private readonly string _scoreText = "7.7 / 10";
    private readonly string _attendanceText = "91,7%";
    private readonly string _signerName = "Trần Minh Quân";
    private readonly string _signerRole = "GIÁM ĐỐC TRUNG TÂM";

    public CertificatePrintPreviewDialog() : this("Trần Gia Bảo", "HV-0204", "CC-2026-0042")
    {
    }

    public CertificatePrintPreviewDialog(string studentName, string studentCode, string certSerial)
        : this(studentName, studentCode, certSerial, "IELTS Foundation", "IELTS-F02", "Khá", "7.7 / 10", "91,7%", AppSession.FullName, AppSession.GetSignerRoleTitle())
    {
    }

    public CertificatePrintPreviewDialog(
        string studentName,
        string studentCode,
        string certSerial,
        string courseName,
        string className,
        string gradeRank,
        string scoreText,
        string attendanceText,
        string signerName,
        string signerRole)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentName = studentName;
        _studentCode = studentCode;
        _certSerial = certSerial;
        _courseName = string.IsNullOrEmpty(courseName) ? "IELTS Foundation" : courseName;
        _className = string.IsNullOrEmpty(className) ? "IELTS-F02" : className;
        _gradeRank = string.IsNullOrEmpty(gradeRank) ? "Khá" : gradeRank;
        _scoreText = string.IsNullOrEmpty(scoreText) ? "8.0 / 10" : scoreText;
        _attendanceText = string.IsNullOrEmpty(attendanceText) ? "95%" : attendanceText;
        _signerName = string.IsNullOrEmpty(signerName) ? AppSession.FullName : signerName;
        _signerRole = string.IsNullOrEmpty(signerRole) ? AppSession.GetSignerRoleTitle() : signerRole;

        SetupView();
    }

    private void SetupView()
    {
        cboPrinter.Items.Clear();
        cboPrinter.Items.AddRange(new object[]
        {
            "Canon LBP2900 (Máy in mặc định)",
            "HP LaserJet Pro M404dn",
            "Epson L3110 Series",
            "Microsoft Print to PDF"
        });
        if (cboPrinter.Items.Count > 0) cboPrinter.SelectedIndex = 0;

        cboPaperSize.Items.Clear();
        cboPaperSize.Items.AddRange(new object[]
        {
            "Khổ A4 ngang · 1 bản",
            "Khổ A4 ngang · 2 bản",
            "Khổ A5 ngang · 1 bản"
        });
        if (cboPaperSize.Items.Count > 0) cboPaperSize.SelectedIndex = 0;

        lblStudentFullName.Text = _studentName.ToUpper();
        lblStudentInfoLine.Text = $"Mã học viên: {_studentCode}  ·  Lớp học: {_className}";
        lblCourseLine.Text = $"Đã hoàn thành xuất sắc khóa đào tạo: {_courseName.ToUpper()}";
        lblDurationLine.Text = "Thời gian đào tạo: 48 giờ / 24 buổi học tiêu chuẩn";
        lblResultLine.Text = $"Kết quả: {_scoreText}  ·  Xếp loại: {_gradeRank}  ·  Chuyên cần: {_attendanceText}";
        lblCertSerialBottom.Text = $"Số chứng chỉ: {_certSerial}";
        lblIssueLocationDate.Text = $"TP. Hồ Chí Minh, ngày {DateTime.Now:dd} tháng {DateTime.Now:MM} năm {DateTime.Now:yyyy}";
        lblDirectorTitle.Text = _signerRole.ToUpper();
        lblDirectorName.Text = _signerName;

        btnClose.Click += (s, e) => Close();

        btnPrintCert.Click += (s, e) =>
        {
            string printer = cboPrinter.SelectedItem?.ToString() ?? "Máy in mặc định";
            MessageBox.Show(
                $"Đã gửi lệnh in 01 bản Chứng chỉ tốt nghiệp {_certSerial} của học viên {_studentName} tới máy in:\n[{printer}]\n\nKhổ giấy: A4 ngang · Độ phân giải 300 DPI · Chữ ký: {_signerName} ({_signerRole}).",
                "In chứng chỉ thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            Close();
        };
    }
}
