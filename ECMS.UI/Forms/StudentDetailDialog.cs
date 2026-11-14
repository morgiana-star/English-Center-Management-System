using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class StudentDetailDialog : Form
{
    public StudentDetailDialog()
    {
        InitializeComponent();
        PopulateMockData();
        WireUpEvents();
    }

    public StudentDetailDialog(string studentCode, string fullName) : this()
    {
        lblDetailHeader.Text = $"{fullName} · {studentCode}";
        Text = $"Chi tiết học viên · {fullName}";
    }

    private void PopulateMockData()
    {
        AppGridHelper.ApplyStyle(dgvReceipts);
        dgvReceipts.Columns.Clear();
        dgvReceipts.Columns.Add("ColDate", "Ngày ↑");
        dgvReceipts.Columns.Add("ColReceipt", "Phiếu thu");
        dgvReceipts.Columns.Add("ColAmount", "Số tiền");

        dgvReceipts.Columns[0].Width = 120;
        dgvReceipts.Columns[1].Width = 140;

        dgvReceipts.Rows.Add("02/10/2026", "PT-261002-006", "2.000.000đ");
        dgvReceipts.Rows.Add("30/10/2026", "PT-261030-018", "1.500.000đ");
    }

    private void WireUpEvents()
    {
        // 1. Lưu trữ hồ sơ -> Mở ArchiveStudentDialog (Màn 3)
        btnArchive.Click += (s, e) =>
        {
            using var archiveDlg = new ArchiveStudentDialog();
            if (archiveDlg.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
        };

        // 2. Sửa hồ sơ
        btnEditProfile.Click += (s, e) =>
        {
            using var editDlg = new AddStudentDialog();
            editDlg.ShowDialog(this);
        };

        // 3. Mở công nợ thu đợt tiếp
        btnOpenDebt.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Học phí & Thanh toán", "Chuyển tiếp đến lập phiếu thu công nợ 1.900.000đ cho học viên HV-0241.");
        };

        // 4. Xem chi tiết học tập -> Mở Sổ điểm học viên (Không gian học viên)
        btnViewAcademicDetail.Click += (s, e) =>
        {
            using var dlg = new Form
            {
                Text = "Sổ điểm · Trần Gia Bảo (Không gian học viên)",
                Size = new System.Drawing.Size(1200, 780),
                StartPosition = FormStartPosition.CenterParent
            };
            var view = new UserControls.StudentGradeReportView { Dock = DockStyle.Fill };
            dlg.Controls.Add(view);
            dlg.ShowDialog(this);
        };
    }
}
