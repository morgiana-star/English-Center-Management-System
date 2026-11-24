using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại xem chi tiết hồ sơ học viên
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
        tabMain.SelectedIndexChanged += (s, e) =>
        {
            if (tabMain.SelectedTab == tpLearningPath)
            {
                dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLearningPath.PerformLayout();
                dgvLearningPath.Invalidate();
            }
        };

        // Xóa học viên (kiểm tra điều kiện ràng buộc)
        btnDelete.Click += async (s, e) =>
        {
            int targetId = _detail?.StudentId ?? _studentId;
            if (targetId <= 0)
            {
                AppDialog.ShowWarning(this, "Thông báo", "Không xác định được mã học viên cần xóa.");
                return;
            }

            if (AppDialog.ShowConfirm(
                this,
                "Xác nhận xóa học viên",
                $"Bạn có chắc chắn muốn xóa vĩnh viễn hồ sơ học viên {_studentName} ({_studentCode}) không?\n\nLưu ý: Chỉ xóa được học viên chưa phát sinh phiếu thu, điểm danh, điểm thi hoặc chứng chỉ.",
                "Xóa học viên",
                "Hủy") != DialogResult.OK)
            {
                return;
            }

            var res = await _studentService.DeleteStudentAsync(targetId);
            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AppDialog.ShowWarning(this, "Không thể xóa học viên", res.Message);
            }
        };

        // Lưu trữ hồ sơ (kiểm tra công nợ trước khi xác nhận)
        btnArchive.Click += async (s, e) =>
        {
            int targetId = _detail?.StudentId ?? _studentId;
            decimal debt = targetId > 0 ? await _studentService.GetStudentOutstandingDebtAsync(targetId) : 0m;

            string confirmMsg = debt > 0
                ? $"CẢNH BÁO CÔNG NỢ: Học viên {_studentName} ({_studentCode}) hiện còn nợ học phí {debt:N0} đ.\n\nNếu lưu trữ, hồ sơ sẽ chuyển sang trạng thái Bảo lưu và giải phóng chỗ khỏi lớp hiện tại (công nợ vẫn được giữ lại để đối soát).\n\nBạn có chắc chắn vẫn muốn lưu trữ hồ sơ này không?"
                : $"Bạn có chắc chắn muốn lưu trữ/bảo lưu hồ sơ của học viên {_studentName} ({_studentCode}) không?\nSĩ số lớp hiện tại của học viên sẽ được giải phóng.";

            if (AppDialog.ShowConfirm(this, "Xác nhận lưu trữ hồ sơ", confirmMsg, "Lưu trữ", "Hủy") != DialogResult.OK)
                return;

            if (targetId > 0)
            {
                var res = await _studentService.ArchiveStudentAsync(new ArchiveStudentDto
                {
                    StudentId = targetId,
                    Reason = "Bảo lưu theo yêu cầu",
                    Notes = debt > 0 ? $"Lưu trữ khi còn công nợ {debt:N0} đ" : "Thao tác từ màn hình hồ sơ chi tiết"
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
        };

        // Sửa hồ sơ
        btnEditProfile.Click += async (s, e) =>
        {
            using var editDlg = _detail != null
                ? new AddStudentDialog(_detail)
                : new AddStudentDialog(true, _studentName);

            if (editDlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadStudentDataAsync();
                AppDialog.ShowSuccess(this, "Thành công", "Đã cập nhật hồ sơ học viên thành công.");
                DialogResult = DialogResult.OK;
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
                dgvLearningPath.Rows.Clear();
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi nạp hồ sơ học viên", ex.Message);
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
        lblAttPresent.Text = $"Có mặt: {d.PresentCount}";
        lblAttLate.Text = $"Đi muộn: {d.LateCount}";
        lblAttAbsent.Text = $"Vắng: {d.AbsentCount}";

        lblGradeEntry.Text = $"Đầu vào: {d.EntranceScore}";
        lblGradeRegular.Text = $"Thường xuyên: {d.RegularScore}";
        lblGradeMid.Text = $"Giữa khóa: {d.MidtermScore}";
        lblGradeFinal.Text = $"Cuối khóa: {d.FinalScore}";

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

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        dgvLearningPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
}
