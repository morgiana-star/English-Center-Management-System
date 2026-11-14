using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class CertificateManagementView : UserControl
{
    public CertificateManagementView()
    {
        InitializeComponent();
        SetupEvents();
        LoadSampleData();
    }

    private void SetupEvents()
    {
        btnApproveEligible.Click += (s, e) => OpenApproveDialog("Trần Gia Bảo", "HV-0204", "8.0", "7.7", "22/24 · 91,7%", "CC-2026-0042");
        btnRecheck.Click += (s, e) => MessageBox.Show("Đã quét lại 20 học viên lớp IELTS-F02: 16 đạt, 1 không đạt, 3 chưa đủ điều kiện.", "Kiểm tra điều kiện tốt nghiệp", MessageBoxButtons.OK, MessageBoxIcon.Information);

        gridEligibility.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index)
            {
                var row = gridEligibility.Rows[e.RowIndex];
                string conclusion = row.Cells[colConclusion.Index].Value?.ToString() ?? "";
                if (conclusion.Contains("Đạt"))
                {
                    string student = row.Cells[colStudent.Index].Value?.ToString() ?? "Trần Gia Bảo";
                    string scores = row.Cells[colScores.Index].Value?.ToString() ?? "8,0 / 7,7";
                    string att = row.Cells[colAttendance.Index].Value?.ToString() ?? "22/24 · 91,7%";
                    OpenApproveDialog(student, "HV-0204", "8.0", "7.7", att, "CC-2026-0042");
                }
                else
                {
                    MessageBox.Show("Học viên chưa đạt đủ 4 điều kiện. Vui lòng xử lý lý do bị chặn trước khi cấp bằng.", "Chặn cấp chứng chỉ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        };

        btnOpenGrades.Click += (s, e) => MessageBox.Show("Chuyển đến sổ điểm để xem bài thi bổ sung / phúc khảo.", "Mở sổ điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnOpenAttendance.Click += (s, e) => MessageBox.Show("Chuyển đến bảng điểm danh 24 buổi để đối soát phép.", "Mở điểm danh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnOpenTuition.Click += (s, e) => MessageBox.Show("Chuyển đến sổ công nợ để thu nốt học phí còn thiếu.", "Mở công nợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void OpenApproveDialog(string studentName, string studentCode, string finalScore, string avgScore, string attendance, string certSerial)
    {
        using var dialog = new ApproveCertificateDialog(studentName, studentCode, finalScore, avgScore, attendance, certSerial);
        dialog.ShowDialog(this.FindForm());
    }

    private void LoadSampleData()
    {
        gridEligibility.Rows.Clear();
        gridEligibility.Rows.Add("Trần Gia Bảo", "8,0 / 7,7", "22/24 · 91,7%", "0đ", "✓ Đạt", "Đủ điều kiện cấp", "Cấp bằng");
        gridEligibility.Rows.Add("Đặng Minh Trí", "8,8 / 8,4", "24/24 · 100%", "0đ", "✓ Đạt", "Đủ điều kiện cấp", "Cấp bằng");
        gridEligibility.Rows.Add("Vũ Ngọc Lan", "6,0 / 5,9", "22/24 · 91,7%", "0đ", "✕ Không đạt", "TB < 6,5 → kế hoạch học bổ sung", "Khóa");
        gridEligibility.Rows.Add("Hoàng Đức An", "7,4 / 7,2", "18/24 · 75%", "0đ", "Chưa đủ điều kiện", "Chuyên cần < 80% → xem điểm danh", "Khóa");
        gridEligibility.Rows.Add("Trần Thảo Nhi", "7,0 / 7,0", "21/24 · 87,5%", "500.000đ", "Chưa đủ điều kiện", "Còn nợ → chuyển kế toán", "Khóa");
    }
}
