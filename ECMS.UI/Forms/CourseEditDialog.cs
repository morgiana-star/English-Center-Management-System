using System;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseEditDialog : Form
{
    private readonly ICourseService _courseService = new CourseService();
    private readonly bool _isEditMode;
    private readonly string? _courseCode;

    public CourseEditDialog(string? courseCode = null)
    {
        InitializeComponent();

        _courseCode = courseCode;
        _isEditMode = !string.IsNullOrEmpty(courseCode);

        SetupForm();
        WireEvents();
    }

    private void SetupForm()
    {
        cboInputLevel.Items.Clear();
        cboInputLevel.Items.AddRange(new object[]
        {
            "Cơ bản · 0–4,5/10",
            "Trung cấp · 4,5–6,0/10",
            "Nâng cao · 6,0–7,5/10",
            "Chuyên sâu · 7,5+/10"
        });
        cboInputLevel.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang sử dụng",
            "Ngừng sử dụng",
            "Bản nháp"
        });
        cboStatus.SelectedIndex = 0;

        if (_isEditMode)
        {
            Text = "Thông tin khóa học · Đang sửa";
            lblTitle.Text = "Thông tin khóa học";
            
            // Populate sample data for edit
            txtCourseCode.Text = _courseCode ?? "CT-IELTS-F";
            txtCourseName.Text = "IELTS Foundation";
            cboInputLevel.SelectedIndex = 0;
            txtOutputTarget.Text = "Nền tảng IELTS 4.0–4.5";
            txtSessionCount.Text = "24";
            txtSessionDuration.Text = "120 phút";
            txtTuitionFee.Text = "6.000.000đ";
            cboStatus.SelectedIndex = 0;
            txtDescription.Text = "Ngữ pháp cơ bản, từ vựng chủ đề, bốn kỹ năng nghe – nói – đọc – viết.";
        }
        else
        {
            Text = "Thêm khóa học mới";
            lblTitle.Text = "Thêm khóa học";
            
            txtCourseCode.Text = "CT-";
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

        txtTuitionFee.Leave += (s, e) =>
        {
            string raw = txtTuitionFee.Text.Replace("đ", "").Replace(".", "").Replace(",", "").Trim();
            if (decimal.TryParse(raw, out decimal val) && val > 0)
            {
                txtTuitionFee.Text = $"{val:N0} đ";
            }
        };

        btnSave.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text) || txtCourseCode.Text == "CT-")
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập Mã khóa học (bắt đầu bằng CT-).");
                txtCourseCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập Tên khóa học.");
                txtCourseName.Focus();
                return;
            }

            if (!int.TryParse(txtSessionCount.Text.Trim(), out int sessions) || sessions <= 0)
            {
                AppDialog.ShowWarning(this, "Số buổi học không hợp lệ", "Số buổi học phải là số nguyên dương lớn hơn 0 (ví dụ: 24 buổi).");
                txtSessionCount.Focus();
                return;
            }

            if (sessions < 10)
            {
                AppDialog.ShowWarning(this, "Thời lượng khóa học quá ngắn", "Khóa đào tạo phải có thời lượng tối thiểu 10 buổi học tiêu chuẩn.");
                txtSessionCount.Focus();
                return;
            }

            string feeRaw = txtTuitionFee.Text.Replace("đ", "").Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(feeRaw, out decimal fee) || fee <= 0)
            {
                AppDialog.ShowWarning(this, "Học phí không hợp lệ", "Vui lòng nhập mức học phí chuẩn hợp lệ lớn hơn 0 đ (ví dụ: 6.000.000 đ).");
                txtTuitionFee.Focus();
                return;
            }

            if (fee < 500000)
            {
                AppDialog.ShowWarning(this, "Học phí quá thấp", "Mức học phí chuẩn tối thiểu của một khóa học là 500.000 đ. Vui lòng kiểm tra lại!");
                txtTuitionFee.Focus();
                return;
            }

            var newCourse = new Course
            {
                CourseCode = txtCourseCode.Text.Trim(),
                CourseName = txtCourseName.Text.Trim(),
                Level = cboInputLevel.SelectedItem?.ToString() ?? "Cơ bản",
                TotalHours = sessions * 2,
                TotalSessions = sessions,
                BaseTuitionFee = fee,
                PassingScore = 5.0m,
                IsActive = cboStatus.SelectedIndex == 0
            };

            var res = await _courseService.CreateCourseAsync(newCourse);
            if (!res.Success)
            {
                AppDialog.ShowError(this, "Lỗi lưu CSDL", res.Message);
                return;
            }

            AppDialog.ShowSuccess(this, "Lưu khóa học thành công", $"Đã lưu chương trình đào tạo '{newCourse.CourseName}' ({newCourse.CourseCode}) vào CSDL SQLite!");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
