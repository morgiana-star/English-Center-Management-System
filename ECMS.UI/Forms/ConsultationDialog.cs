using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ConsultationDialog : Form
{
    public ConsultationDialog()
    {
        InitializeComponent();
        SetupDropdowns();
        PopulateMockData();
        WireUpEvents();
    }

    private void SetupDropdowns()
    {
        cboTestEvaluator.Items.AddRange(new object[] { "Nguyễn Hoàng Anh", "Lê Thu Hà", "Trần Minh Quân" });
        cboTestEvaluator.SelectedIndex = 0;

        cboRecommendedCourse.Items.AddRange(new object[] { "IELTS Foundation", "IELTS 5.0–6.5", "TOEIC 500+" });
        cboRecommendedCourse.SelectedIndex = 0;
    }

    private void PopulateMockData()
    {
        AppGridHelper.ApplyStyle(dgvConsultHistory);
        dgvConsultHistory.Columns.Clear();
        dgvConsultHistory.Columns.Add("ColTime", "Thời gian ↑");
        dgvConsultHistory.Columns.Add("ColStaff", "Người tư vấn");
        dgvConsultHistory.Columns.Add("ColContent", "Nội dung / kết quả");

        dgvConsultHistory.Columns[0].Width = 120;
        dgvConsultHistory.Columns[1].Width = 140;

        dgvConsultHistory.Rows.Add("01/10 · 09:30", "Phạm Ngọc Mai", "Tiếp nhận mục tiêu IELTS 5.0; hẹn kiểm tra.");
        dgvConsultHistory.Rows.Add("02/10 · 14:00", "Phạm Ngọc Mai", "Học viên đã làm bài đầu vào 45 phút.");
        dgvConsultHistory.Rows.Add("02/10 · 15:00", "Phạm Ngọc Mai", "Đồng ý IELTS Foundation; ưu tiên T3 / T6.");
    }

    private void WireUpEvents()
    {
        btnEditLeadInfo.Click += (s, e) =>
        {
            using var editDlg = new AddLeadDialog();
            editDlg.ShowDialog(this);
        };

        btnNextToEnroll.Click += (s, e) =>
        {
            var owner = this.Owner;
            this.Hide();
            using var enrollDlg = new EnrollmentDialog();
            enrollDlg.ShowDialog(owner);
            this.Close();
        };

        btnCancelConsult.Click += (s, e) => txtNewConsult.Text = "";

        btnSaveConsult.Click += (s, e) =>
        {
            if (!string.IsNullOrWhiteSpace(txtNewConsult.Text))
            {
                dgvConsultHistory.Rows.Add("Hôm nay · Giờ này", "Phạm Ngọc Mai", txtNewConsult.Text);
                txtNewConsult.Text = "";
                AppDialog.ShowSuccess(this, "Lưu tư vấn", "Đã lưu nội dung tư vấn mới vào lịch sử.");
            }
        };
    }
}
