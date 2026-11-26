using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseEditDialog : Form
{
    private readonly ICourseService _courseService = new CourseService();
    private readonly bool _isEditMode;
    private readonly string? _courseCode;
    private Course? _editingCourse;

    public CourseEditDialog(string? courseCode = null)
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _courseCode = courseCode;
        _isEditMode = !string.IsNullOrEmpty(courseCode);

        SetupDropdowns();
        WireEvents();
        _ = LoadFormDataAsync();
    }

    private void SetupDropdowns()
    {
        cboInputLevel.Items.Clear();
        cboInputLevel.Items.AddRange(StatusFormatter.CourseLevels);
        cboInputLevel.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang sử dụng",
            "Tạm dừng"
        });
        cboStatus.SelectedIndex = 0;
    }

    private async Task LoadFormDataAsync()
    {
        if (_isEditMode && !string.IsNullOrWhiteSpace(_courseCode))
        {
            Text = "Chỉnh sửa khóa học - ECMS";
            lblTitle.Text = "Chỉnh sửa thông tin khóa học";
            txtCourseCode.ReadOnly = true;

            _editingCourse = await _courseService.GetCourseByCodeAsync(_courseCode);
            if (_editingCourse != null)
            {
                txtCourseCode.Text = _editingCourse.CourseCode;
                txtCourseName.Text = _editingCourse.CourseName;

                string formattedLevel = StatusFormatter.FormatCourseLevel(_editingCourse.Level);
                int idx = Array.FindIndex(StatusFormatter.CourseLevels,
                    l => l.Equals(formattedLevel, StringComparison.OrdinalIgnoreCase));
                cboInputLevel.SelectedIndex = idx >= 0 ? idx : 0;

                txtSessionCount.Text = _editingCourse.TotalSessions.ToString();
                txtSessionDuration.Text = "120 phút";
                txtTuitionFee.Text = $"{_editingCourse.BaseTuitionFee:N0}";
                cboStatus.SelectedIndex = _editingCourse.IsActive ? 0 : 1;
            }
        }
        else
        {
            Text = "Thêm khóa học mới - ECMS";
            lblTitle.Text = "Thêm khóa học mới";
            txtCourseCode.Text = await _courseService.GenerateNextCourseCodeAsync();
            txtCourseCode.ReadOnly = false;
            txtCourseName.Text = "";
            txtOutputTarget.Text = "";
            txtSessionCount.Text = "24";
            txtSessionDuration.Text = "120 phút";
            txtTuitionFee.Text = "";
            txtDescription.Text = "";
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập mã khóa học.");
                txtCourseCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập tên khóa học.");
                txtCourseName.Focus();
                return;
            }

            if (!int.TryParse(txtSessionCount.Text.Trim(), out int sessions) || sessions <= 0)
            {
                AppDialog.ShowWarning(this, "Dữ liệu không hợp lệ", "Số buổi học phải là số nguyên dương.");
                txtSessionCount.Focus();
                return;
            }

            string feeRaw = txtTuitionFee.Text.Replace("đ", "").Replace("VNĐ", "").Replace(".", "").Replace(",", "").Replace(" ", "").Trim();
            if (!decimal.TryParse(feeRaw, out decimal fee) || fee < 0)
            {
                AppDialog.ShowWarning(this, "Dữ liệu không hợp lệ", "Học phí gốc không hợp lệ.");
                txtTuitionFee.Focus();
                return;
            }

            string selectedLevel = !string.IsNullOrWhiteSpace(cboInputLevel.Text)
                ? cboInputLevel.Text.Trim()
                : (cboInputLevel.SelectedItem?.ToString() ?? StatusFormatter.CourseLevels[0]);

            var course = new Course
            {
                CourseId = _editingCourse?.CourseId ?? 0,
                CourseCode = txtCourseCode.Text.Trim().ToUpperInvariant(),
                CourseName = txtCourseName.Text.Trim(),
                Level = StatusFormatter.FormatCourseLevel(selectedLevel),
                TotalHours = sessions * 2,
                TotalSessions = sessions,
                BaseTuitionFee = fee,
                PassingScore = _editingCourse?.PassingScore ?? 5.0m,
                IsActive = cboStatus.SelectedIndex == 0
            };

            var res = _isEditMode && _editingCourse != null
                ? await _courseService.UpdateCourseAsync(course)
                : await _courseService.CreateCourseAsync(course);

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
        };
    }
}
