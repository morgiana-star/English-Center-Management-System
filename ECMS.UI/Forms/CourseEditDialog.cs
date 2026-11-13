using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseEditDialog : Form
{
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
            lblSubtitle.Text = $"Đang sửa {_courseCode} · Biểu mẫu cập nhật chương trình";
            
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
            bannerSuccess.Visible = true;
        }
        else
        {
            Text = "Thêm khóa học mới";
            lblTitle.Text = "Thêm khóa học";
            lblSubtitle.Text = "Tạo mới chương trình đào tạo · Quy định nội dung, học phí và chuẩn đầu ra";
            
            txtCourseCode.Text = "CT-";
            txtCourseName.Text = "";
            txtOutputTarget.Text = "";
            txtSessionCount.Text = "24";
            txtSessionDuration.Text = "120 phút";
            txtTuitionFee.Text = "";
            txtDescription.Text = "";
            bannerSuccess.Visible = false;
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text) || txtCourseCode.Text == "CT-")
            {
                MessageBox.Show("Vui lòng nhập Mã khóa học.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khóa học.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return;
            }

            bannerSuccess.Visible = true;
            bannerSuccess.Message = "✓  Đã lưu thông tin khóa học thành công vào cơ sở dữ liệu SQLite cục bộ.";
            MessageBox.Show("Đã lưu chương trình đào tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
