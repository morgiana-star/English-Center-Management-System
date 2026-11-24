using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseDetailDialog : Form
{
    private readonly ICourseService _courseService = new CourseService();
    private readonly IClassService _classService = new ClassService();
    private readonly string _courseCode = string.Empty;
    private string _courseName = string.Empty;
    private string _tuitionFee = string.Empty;
    private Course? _course;
    private AppButton _btnDeleteCourse = null!;

    public CourseDetailDialog() : this("KH-001", "IELTS Foundation", "6.000.000 đ")
    {
    }

    public CourseDetailDialog(string courseCode, string courseName, string tuitionFee)
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _courseCode = courseCode;
        _courseName = courseName;
        _tuitionFee = tuitionFee;

        SetupDeleteButton();
        SetupGridColumns();
        WireEvents();
        _ = LoadCourseAndClassesAsync();
    }

    private void SetupDeleteButton()
    {
        btnCreateClass.Text = "Tạo lớp học";
        btnEditCourse.Text = "Sửa khóa học";

        _btnDeleteCourse = new AppButton
        {
            Name = "btnDeleteCourse",
            Text = "Xóa khóa học",
            Size = new Size(125, 36),
            Location = new Point(btnEditCourse.Left - 135, btnEditCourse.Top),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Variant = ButtonVariant.Danger,
            ButtonStyle = AppButtonStyle.Danger,
            CornerRadius = 6,
            Cursor = Cursors.Hand
        };
        pnlHeader.Controls.Add(_btnDeleteCourse);
    }

    private void SetupGridColumns()
    {
        AppGridHelper.ApplyStyle(dgvClasses);
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", FillWeight = 14 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên phụ trách", FillWeight = 24 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lịch học", FillWeight = 28 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 11 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 10 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 15 });
    }

    private async Task LoadCourseAndClassesAsync()
    {
        try
        {
            _course = await _courseService.GetCourseByCodeAsync(_courseCode);
            if (_course != null)
            {
                _courseName = _course.CourseName;
                _tuitionFee = $"{_course.BaseTuitionFee:N0} đ";
                lblStatSessionsValue.Text = $"{_course.TotalSessions} buổi";
                lblStatHoursValue.Text = $"{_course.TotalHours} giờ";
            }

            lblTitle.Text = $"{_courseName}  ·  {_courseCode}";
            lblStatTuitionValue.Text = _tuitionFee;

            var allClasses = (await _classService.GetClassesAsync()).ToList();
            var matchedClasses = _course != null
                ? allClasses.Where(c => c.CourseName.Equals(_course.CourseName, StringComparison.OrdinalIgnoreCase)).ToList()
                : allClasses.Where(c => c.CourseName.Equals(_courseName, StringComparison.OrdinalIgnoreCase)).ToList();

            lblStatClassesValue.Text = matchedClasses.Count.ToString();

            dgvClasses.Rows.Clear();
            foreach (var cl in matchedClasses)
            {
                dgvClasses.Rows.Add(
                    cl.ClassCode,
                    cl.TeacherName,
                    cl.ScheduleInfo,
                    cl.RoomName,
                    $"{cl.CurrentStudents} / {cl.MaxStudents}",
                    StatusFormatter.FormatClassStatus(cl.Status));
            }
            dgvClasses.ClearSelection();
            dgvClasses.CurrentCell = null;
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải chi tiết khóa học", ex.Message);
        }
    }

    private void WireEvents()
    {
        btnEditCourse.Click += async (s, e) =>
        {
            using var editDlg = new CourseEditDialog(_courseCode);
            if (editDlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCourseAndClassesAsync();
            }
        };

        btnCreateClass.Click += async (s, e) =>
        {
            using var createClassDlg = new CreateClassDialog();
            if (createClassDlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCourseAndClassesAsync();
            }
        };

        _btnDeleteCourse.Click += async (s, e) =>
        {
            if (_course == null)
            {
                AppDialog.ShowWarning(this, "Thông báo", "Không tìm thấy thông tin khóa học trong cơ sở dữ liệu.");
                return;
            }

            if (AppDialog.ShowConfirm(this, "Xác nhận xóa khóa học",
                $"Bạn có chắc chắn muốn xóa khóa học '{_course.CourseName}' ({_course.CourseCode}) không?\nLưu ý: Chỉ xóa được khóa học chưa có lớp học hoặc tài liệu liên kết.",
                "Xóa khóa học", "Hủy") != DialogResult.OK)
                return;

            var res = await _courseService.DeleteCourseAsync(_course.CourseId);
            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AppDialog.ShowWarning(this, "Không thể xóa khóa học", res.Message);
            }
        };
    }
}
