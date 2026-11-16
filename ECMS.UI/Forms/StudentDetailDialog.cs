using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại xem chi tiết hồ sơ học viên 360°
/// Khớp 100% với giao diện Ảnh 1 (Tab Tổng quan) và Ảnh 2 (Tab Quá trình học tập)
/// </summary>
public partial class StudentDetailDialog : Form
{
    private readonly string _studentName = "Nguyễn Minh Anh";
    private readonly string _studentCode = "HV-0241";

    public StudentDetailDialog() : this("Nguyễn Minh Anh", "HV-0241")
    {
    }

    public StudentDetailDialog(string studentName, string studentCode = "HV-0241")
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentName = string.IsNullOrEmpty(studentName) ? "Nguyễn Minh Anh" : studentName;
        _studentCode = string.IsNullOrEmpty(studentCode) ? "HV-0241" : studentCode;

        lblDetailHeader.Text = $"{_studentName}  ·  {_studentCode}";
        Text = $"Chi tiết học viên — {_studentName} ({_studentCode})";

        SetupNavigation();
        PopulateMockData();
    }

    private void SetupNavigation()
    {
        btnTabOverview.Click += (s, e) => SwitchTab(0);
        btnTabLearningPath.Click += (s, e) => SwitchTab(1);

        // 5.3 Khi ấn Lưu trữ: sẽ xử lý sau
        btnArchive.Click += (s, e) =>
        {
            MessageBox.Show(
                $"Chức năng Lưu trữ hồ sơ học viên {_studentName} ({_studentCode}) sẽ được hoàn thiện trong giai đoạn kế tiếp.",
                "Lưu trữ hồ sơ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        };

        // 5.4 Khi ấn Sửa hồ sơ: Mở Dialog Thêm học viên nhưng ở chế độ Sửa học viên
        btnEditProfile.Click += (s, e) =>
        {
            using var editDlg = new AddStudentDialog(true, _studentName);
            if (editDlg.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Cập nhật thông tin học viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };
    }

    private void SwitchTab(int index)
    {
        Color activeColor = Color.FromArgb(37, 99, 235);
        Color inactiveColor = Color.FromArgb(100, 116, 139);
        var activeFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        var inactiveFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);

        btnTabOverview.ForeColor = index == 0 ? activeColor : inactiveColor;
        btnTabOverview.Font = index == 0 ? activeFont : inactiveFont;

        btnTabLearningPath.ForeColor = index == 1 ? activeColor : inactiveColor;
        btnTabLearningPath.Font = index == 1 ? activeFont : inactiveFont;

        pnlOverview.Visible = (index == 0);
        pnlLearningPath.Visible = (index == 1);

        if (index == 1)
        {
            pnlLearningPath.BringToFront();
            dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLearningPath.PerformLayout();
            dgvLearningPath.Invalidate();
        }
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void PopulateMockData()
    {
        // 5.2.1: Bỏ phần chữ phụ bên dưới (33%, Đầu vào 4.0, Tổng 6.000.000đ)
        // 5.2.2: Tách cột điểm thành: Thường xuyên, Giữa khóa, Cuối khóa
        // 5.2.3: Bỏ cột thao tác
        dgvLearningPath.Rows.Clear();
        dgvLearningPath.Rows.Add(
            "IELTS-F01 · IELTS Foundation",
            "Đang học",
            "8 / 24",
            "7.0 / 10",
            "Chưa kiểm tra",
            "Chưa kiểm tra",
            "Còn nợ 1.900.000đ"
        );
        dgvLearningPath.Rows.Add(
            "ENG-B01 · Tiếng Anh Cơ Bản",
            "Hoàn thành",
            "24 / 24",
            "8.0 / 10",
            "8.0 / 10",
            "8.5 / 10",
            "✓ Đã hoàn thành"
        );

        dgvLearningPath.ClearSelection();
        dgvLearningPath.CurrentCell = null;
    }
}
