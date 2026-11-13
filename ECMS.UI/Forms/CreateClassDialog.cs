using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateClassDialog : Form
{
    public CreateClassDialog()
    {
        InitializeComponent();

        SetupDropdowns();
        WireEvents();
    }

    private void SetupDropdowns()
    {
        cboCourse.Items.Clear();
        cboCourse.Items.AddRange(new object[]
        {
            "IELTS Foundation",
            "IELTS 5.0–6.5",
            "TOEIC 500+",
            "TOEIC 650+",
            "English Communication Basic"
        });
        cboCourse.SelectedIndex = 0;

        cboTeacher.Items.Clear();
        cboTeacher.Items.AddRange(new object[]
        {
            "Nguyễn Hoàng Anh",
            "Trần Minh Tuấn",
            "Lê Thu Hà",
            "Phạm Quốc Hùng"
        });
        cboTeacher.SelectedIndex = 0;

        cboDaysOfWeek.Items.Clear();
        cboDaysOfWeek.Items.AddRange(new object[]
        {
            "Thứ Hai / Thứ Năm",
            "Thứ Ba / Thứ Sáu",
            "Thứ Tư / Thứ Bảy",
            "Thứ Bảy / Chủ Nhật"
        });
        cboDaysOfWeek.SelectedIndex = 0;

        cboTimeSlot.Items.Clear();
        cboTimeSlot.Items.AddRange(new object[]
        {
            "18:00–20:00",
            "19:30–21:30",
            "08:30–10:30",
            "14:00–16:00"
        });
        cboTimeSlot.SelectedIndex = 0;

        cboRoom.Items.Clear();
        cboRoom.Items.AddRange(new object[]
        {
            "P201 · 24 chỗ",
            "P202 · 20 chỗ",
            "P203 · 18 chỗ",
            "P101 · 30 chỗ"
        });
        cboRoom.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Bản nháp",
            "Sắp mở",
            "Đang học"
        });
        cboStatus.SelectedIndex = 0;

        txtClassCode.Text = "IELTS-F04";
        txtCapacity.Text = "20 học viên";
        dtpStartDate.Value = DateTime.Today;
        dtpEndDate.Value = DateTime.Today.AddMonths(3);
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSaveDraft.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtClassCode.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp học.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassCode.Focus();
                return;
            }

            MessageBox.Show($"Đã lưu lớp học '{txtClassCode.Text}' ở trạng thái Bản nháp vào SQLite cục bộ.\nBước tiếp theo: thêm học viên hoặc kiểm tra điều kiện để mở lớp.", "Tạo lớp thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };

        cboTeacher.SelectedIndexChanged += (s, e) =>
        {
            UpdateTeacherInfo(cboTeacher.Text);
        };

        btnViewTeacherProfile.Click += (s, e) =>
        {
            MessageBox.Show($"Xem thông tin chi tiết và lịch giảng dạy của giáo viên {cboTeacher.Text}.", "Hồ sơ giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private void UpdateTeacherInfo(string teacherName)
    {
        if (teacherName.Contains("Tuấn"))
        {
            lblTeacherNameVal.Text = "Trần Minh Tuấn · GV-002";
            lblSpecialtyVal.Text = "TOEIC · Giao tiếp";
            lblCurrentTeachingVal.Text = "TOEIC-T01 · T3 / T6";
            lblFreeScheduleVal.Text = "T2 / T4 · 18:00–20:00";
            lblCurrentHoursVal.Text = "6 giờ / tuần";
        }
        else if (teacherName.Contains("Hà"))
        {
            lblTeacherNameVal.Text = "Lê Thu Hà · GV-003";
            lblSpecialtyVal.Text = "Giao tiếp cơ bản";
            lblCurrentTeachingVal.Text = "COM-B01 · T2 / T4";
            lblFreeScheduleVal.Text = "T3 / T5 · 18:00–20:00";
            lblCurrentHoursVal.Text = "4 giờ / tuần";
        }
        else
        {
            lblTeacherNameVal.Text = "Nguyễn Hoàng Anh · GV-001";
            lblSpecialtyVal.Text = "IELTS · Cơ bản đến 6.5";
            lblCurrentTeachingVal.Text = "IELTS-F01 · T3 / T6";
            lblFreeScheduleVal.Text = "T2 / T5 · 18:00–20:00";
            lblCurrentHoursVal.Text = "4 giờ / tuần";
        }
    }
}
