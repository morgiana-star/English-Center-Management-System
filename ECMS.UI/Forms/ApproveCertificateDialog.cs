using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class ApproveCertificateDialog : Form
{
    private readonly string _studentName;
    private readonly string _studentCode;
    private readonly string _finalScore;
    private readonly string _avgScore;
    private readonly string _attendance;
    private readonly string _certSerial;

    public ApproveCertificateDialog() : this("Trần Gia Bảo", "HV-0204", "8.0", "7.7", "22/24 · 91,7%", "CC-2026-0042")
    {
    }

    public ApproveCertificateDialog(string studentName, string studentCode, string finalScore, string avgScore, string attendance, string certSerial)
    {
        InitializeComponent();
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

        cboSigner.SelectedIndex = 0;

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
