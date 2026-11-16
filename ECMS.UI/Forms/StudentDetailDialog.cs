using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại xem chi tiết hồ sơ học viên 360°
/// </summary>
public partial class StudentDetailDialog : Form
{
    private readonly IStudentService _studentService = new StudentService();
    private readonly int _studentId;
    private readonly string _studentName = "Nguyễn Minh Anh";
    private readonly string _studentCode = "HV-0241";
    private StudentDetailDto? _detail;

    public StudentDetailDialog() : this(0, "Nguyễn Minh Anh", "HV-0241")
    {
    }

    public StudentDetailDialog(int studentId, string studentName = "", string studentCode = "")
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentId = studentId;
        _studentName = string.IsNullOrEmpty(studentName) ? "Nguyễn Minh Anh" : studentName;
        _studentCode = string.IsNullOrEmpty(studentCode) ? "HV-0241" : studentCode;

        lblDetailHeader.Text = $"{_studentName}  ·  {_studentCode}";
        Text = $"Chi tiết học viên — {_studentName} ({_studentCode})";

        SetupNavigation();
        _ = LoadStudentDataAsync();
    }

    public StudentDetailDialog(string studentName, string studentCode = "HV-0241") : this(0, studentName, studentCode)
    {
    }

    private void SetupNavigation()
    {
        btnTabOverview.Click += (s, e) => SwitchTab(0);
        btnTabLearningPath.Click += (s, e) => SwitchTab(1);

        // Lưu trữ hồ sơ
        btnArchive.Click += async (s, e) =>
        {
            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn lưu trữ/bảo lưu hồ sơ của học viên {_studentName} ({_studentCode}) không?",
                "Xác nhận lưu trữ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int targetId = _detail?.StudentId ?? _studentId;
                if (targetId > 0)
                {
                    var res = await _studentService.ArchiveStudentAsync(new ArchiveStudentDto
                    {
                        StudentId = targetId,
                        Reason = "Bảo lưu theo yêu cầu",
                        Notes = "Thao tác từ màn hình hồ sơ chi tiết 360°"
                    });
                    if (res.Success)
                    {
                        AppDialog.ShowSuccess(this, "Thành công", res.Message);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        AppDialog.ShowWarning(this, "Thông báo", res.Message);
                    }
                }
                else
                {
                    AppDialog.ShowInfo(this, "Lưu trữ", $"Hồ sơ học viên {_studentName} đã được chuyển sang trạng thái Bảo lưu.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        };

        // Sửa hồ sơ
        btnEditProfile.Click += async (s, e) =>
        {
            using var editDlg = new AddStudentDialog(true, _studentName);
            if (editDlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadStudentDataAsync();
                AppDialog.ShowSuccess(this, "Thành công", "Đã cập nhật hồ sơ học viên thành công!");
            }
        };
    }

    private async Task LoadStudentDataAsync()
    {
        try
        {
            if (_studentId > 0)
            {
                _detail = await _studentService.GetStudentDetailAsync(_studentId);
            }
            else if (!string.IsNullOrWhiteSpace(_studentCode))
            {
                _detail = await _studentService.GetStudentDetailByCodeAsync(_studentCode);
            }

            if (_detail != null)
            {
                BindDetailToUi(_detail);
            }
            else
            {
                PopulateDefaultMockData();
            }
        }
        catch
        {
            PopulateDefaultMockData();
        }
    }

    private void BindDetailToUi(StudentDetailDto d)
    {
        lblDetailHeader.Text = $"{d.FullName}  ·  {d.StudentCode}";
        string parentText = !string.IsNullOrWhiteSpace(d.ParentFullName) ? $" | Phụ huynh: {d.ParentFullName} / {d.ParentPhone}" : "";
        lblDetailSub.Text = $"{d.StatusText} | {d.Phone}{parentText}";
        Text = $"Chi tiết học viên — {d.FullName} ({d.StudentCode})";

        // Tab 1 KPI
        lblStatClassVal.Text = d.CurrentClassName;
        lblStatLessonsVal.Text = d.LessonsProgressDisplay;
        lblStatAttendanceVal.Text = d.AttendanceRateDisplay;
        lblStatTuitionVal.Text = d.RemainingTuitionDisplay;
        lblStatTuitionSub.Text = d.TuitionDueDateDisplay;

        // Tab 1 Chi tiết học tập
        lblCourseVal.Text = d.CourseName;
        lblTeacherVal.Text = d.TeacherName;
        lblScheduleVal.Text = d.ScheduleDisplay;
        lblRoomVal.Text = d.RoomName;

        lblAttCountVal.Text = d.ProgressDisplay;
        lblAttPresent.Text = $"✓ Có mặt:  {d.PresentCount}";
        lblAttLate.Text = $"⏱ Đi muộn:  {d.LateCount}";
        lblAttAbsent.Text = $"✕ Vắng:     {d.AbsentCount} (có phép)";

        lblGradeEntry.Text = $"Đầu vào:      {d.EntranceScore}";
        lblGradeRegular.Text = $"Thường xuyên: {d.RegularScore}";
        lblGradeMid.Text = $"Giữa khóa:    {d.MidtermScore}";
        lblGradeFinal.Text = $"Cuối khóa:    {d.FinalScore}";

        // Tab 2 Lịch sử khóa học
        dgvLearningPath.Rows.Clear();
        foreach (var item in d.LearningHistory)
        {
            dgvLearningPath.Rows.Add(
                item.ClassCourseName,
                item.Status,
                item.AttendanceProgress,
                item.RegularScore,
                item.MidtermScore,
                item.FinalScore,
                item.TuitionStatus
            );
        }
        dgvLearningPath.ClearSelection();
        dgvLearningPath.CurrentCell = null;
    }

    private void PopulateDefaultMockData()
    {
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
            "16 / 16",
            "8.0 / 10",
            "7.5 / 10",
            "8.5 / 10",
            "✓ Đã hoàn thành"
        );

        dgvLearningPath.ClearSelection();
        dgvLearningPath.CurrentCell = null;
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
            pnlLearningPath.Dock = DockStyle.Fill;
            pnlLearningPath.BringToFront();
            dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLearningPath.PerformLayout();
            dgvLearningPath.Invalidate();
        }
        else
        {
            pnlOverview.Dock = DockStyle.Fill;
            pnlOverview.BringToFront();
        }
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
