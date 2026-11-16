using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class ApproveCertificateDialog : Form
{
    private readonly string _studentName = string.Empty;
    private readonly string _studentCode = string.Empty;
    private readonly string _finalScore = string.Empty;
    private readonly string _avgScore = string.Empty;
    private readonly string _attendance = string.Empty;
    private readonly string _certSerial = string.Empty;

    public ApproveCertificateDialog() : this("Trần Gia Bảo", "HV-0204", "8.0", "7.7", "22/24 · 91,7%", "CC-2026-0042")
    {
    }

    public ApproveCertificateDialog(string studentName, string studentCode, string finalScore, string avgScore, string attendance, string certSerial)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentName = studentName;
        _studentCode = studentCode;
        _finalScore = finalScore;
        _avgScore = avgScore;
        _attendance = attendance;
        _certSerial = certSerial;

        SetupView();
    }

    private void SetupView()
    {
        lblStudentNameVal.Text = _studentName.ToUpper();
        lblStudentCodeVal.Text = _studentCode;
        lblM1Val.Text = $"{_finalScore} / 10";
        lblM2Val.Text = $"{_avgScore} · Loại Khá";
        lblM3Val.Text = _attendance;
        lblCertSerialVal.Text = _certSerial;

        cboSigner.Items.Clear();
        cboSigner.Items.AddRange(new object[]
        {
            "Nguyễn Thành Long · Giám đốc trung tâm",
            "Trần Minh Quân · Quản lý học vụ",
            "Lê Phương Thảo · Kế toán trưởng"
        });
        if (cboSigner.Items.Count > 0)
        {
            cboSigner.SelectedIndex = 0;
        }

        btnCancel.Click += (s, e) => Close();

        btnConfirmIssue.Click += (s, e) =>
        {
            this.Hide();
            using var registryDlg = new CertificateRegistryDialog(_studentName, _studentCode, _certSerial);
            registryDlg.ShowDialog();
            this.Close();
        };
    }
}
