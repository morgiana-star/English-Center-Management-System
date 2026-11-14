using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class CertificateRegistryDialog : Form
{
    private readonly string _studentName;
    private readonly string _studentCode;
    private readonly string _certSerial;

    public CertificateRegistryDialog() : this("Trần Gia Bảo", "HV-0204", "CC-2026-0042")
    {
    }

    public CertificateRegistryDialog(string studentName, string studentCode, string certSerial)
    {
        InitializeComponent();
        _studentName = studentName;
        _studentCode = studentCode;
        _certSerial = certSerial;

        SetupView();
    }

    private void SetupView()
    {
        lblDetailTitle.Text = _certSerial;
        lblStudentVal.Text = $"{_studentName} · {_studentCode}";

        cboCourseFilter.SelectedIndex = 0;
        cboYearFilter.SelectedIndex = 0;

        gridRegistry.Rows.Clear();
        gridRegistry.Rows.Add(_certSerial, _studentName, "IELTS-F02", "30/10/2026", "Đã cấp · Chưa in");
        gridRegistry.Rows.Add("CC-2026-0041", "Ngô Bảo Ngọc", "TOEIC-T00", "22/10/2026", "Đã cấp");
        gridRegistry.Rows.Add("CC-2026-0040", "Trần Hải Yến", "COM-A01", "19/10/2026", "Đã cấp");
        gridRegistry.Rows.Add("CC-2026-0039", "Nguyễn Đức Duy", "COM-A01", "19/10/2026", "Đã cấp");

        gridRegistry.SelectionChanged += (s, e) =>
        {
            if (gridRegistry.SelectedRows.Count > 0)
            {
                var row = gridRegistry.SelectedRows[0];
                string serial = row.Cells[0].Value?.ToString() ?? "CC-2026-0042";
                string student = row.Cells[1].Value?.ToString() ?? "Trần Gia Bảo";
                string className = row.Cells[2].Value?.ToString() ?? "IELTS-F02";
                string date = row.Cells[3].Value?.ToString() ?? "30/10/2026";

                lblDetailTitle.Text = serial;
                lblStudentVal.Text = $"{student} · HV-0204";
                lblClassVal.Text = className;
                lblIssueDateVal.Text = date;
            }
        };

        btnClose.Click += (s, e) => Close();

        btnPreviewPrint.Click += (s, e) => OpenCertPrintPreview();
        btnViewCertToPrint.Click += (s, e) => OpenCertPrintPreview();
    }

    private void OpenCertPrintPreview()
    {
        using var previewDlg = new CertificatePrintPreviewDialog(_studentName, _studentCode, _certSerial);
        previewDlg.ShowDialog(this);
    }
}
