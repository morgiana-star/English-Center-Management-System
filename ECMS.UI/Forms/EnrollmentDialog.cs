using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class EnrollmentDialog : Form
{
    public EnrollmentDialog()
    {
        InitializeComponent();
        SetupDropdowns();
        PopulateMockData();
        WireUpEvents();
    }

    private void SetupDropdowns()
    {
        cboSubstituteClass.Items.AddRange(new object[] { "IELTS-F01", "IELTS-F02", "IELTS-F04" });
        cboSubstituteClass.SelectedIndex = 0;
    }

    private void PopulateMockData()
    {
        AppGridHelper.ApplyStyle(dgvClasses);
        dgvClasses.Columns.Clear();
        dgvClasses.Columns.Add("ColSelect", "Chọn");
        dgvClasses.Columns.Add("ColClass", "Lớp học");
        dgvClasses.Columns.Add("ColTeacher", "Giáo viên");
        dgvClasses.Columns.Add("ColSchedule", "Lịch / khai giảng");
        dgvClasses.Columns.Add("ColSize", "Sĩ số");
        dgvClasses.Columns.Add("ColState", "Trạng thái");

        dgvClasses.Columns[0].Width = 50;
        dgvClasses.Columns[1].Width = 100;
        dgvClasses.Columns[2].Width = 130;
        dgvClasses.Columns[3].Width = 140;
        dgvClasses.Columns[4].Width = 80;

        dgvClasses.Rows.Add("○", "IELTS-F03", "Lê Thu Hà", "T2 / T5 · 05/10", "20/20", "✕ Đã đầy");
        dgvClasses.Rows.Add("●", "IELTS-F01", "Nguyễn Hoàng Anh", "T3 / T6 · 06/10", "17/20", "✓ Còn 3 chỗ");
    }

    private void WireUpEvents()
    {
        btnBackToConsult.Click += (s, e) =>
        {
            var owner = this.Owner;
            this.Hide();
            using var consultDlg = new ConsultationDialog();
            consultDlg.ShowDialog(owner);
            this.Close();
        };

        btnConfirmEnroll.Click += (s, e) =>
        {
            var owner = this.Owner;
            this.Hide();
            using var successDlg = new EnrollmentSuccessDialog();
            successDlg.ShowDialog(owner);
            this.Close();
        };
    }
}
