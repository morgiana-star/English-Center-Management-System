using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateClassDialog : Form
{
    private readonly bool _isEditMode;
    private readonly string _initialClassCode = string.Empty;

    public CreateClassDialog() : this(false, "")
    {
    }

    public CreateClassDialog(bool isEditMode = false, string classCode = "")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _initialClassCode = classCode;

        SetupDropdowns();
        ApplyMode();
        WireEvents();
    }

    private void ApplyMode()
    {
        if (_isEditMode)
        {
            Text = "Chỉnh sửa thông tin lớp học · ECMS";
            lblTitle.Text = "Chỉnh sửa thông tin lớp học";
            btnSaveDraft.Text = "Lưu thay đổi";
            txtClassCode.Text = string.IsNullOrEmpty(_initialClassCode) ? "IELTS-F01" : _initialClassCode;
            txtClassCode.ReadOnly = true;
        }
        else
        {
            Text = "Tạo lớp học mới · ECMS";
            lblTitle.Text = "Tạo lớp học mới";
            btnSaveDraft.Text = "Lưu lớp học";
            txtClassCode.Text = "IELTS-F04";
            txtClassCode.ReadOnly = false;
        }
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
        if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;

        cboTeacher.Items.Clear();
        cboTeacher.Items.AddRange(new object[]
        {
            "Nguyễn Hoàng Anh",
            "Trần Minh Tuấn",
            "Lê Thu Hà",
            "Phạm Quốc Hùng"
        });
        if (cboTeacher.Items.Count > 0) cboTeacher.SelectedIndex = 0;

        cboDaysOfWeek.Items.Clear();
        cboDaysOfWeek.Items.AddRange(new object[]
        {
            "Thứ Hai / Thứ Năm",
            "Thứ Ba / Thứ Sáu",
            "Thứ Tư / Thứ Bảy",
            "Thứ Bảy / Chủ Nhật"
        });
        if (cboDaysOfWeek.Items.Count > 0) cboDaysOfWeek.SelectedIndex = 0;

        cboTimeSlot.Items.Clear();
        cboTimeSlot.Items.AddRange(new object[]
        {
            "18:00–20:00",
            "19:30–21:30",
            "08:30–10:30",
            "14:00–16:00"
        });
        if (cboTimeSlot.Items.Count > 0) cboTimeSlot.SelectedIndex = 0;

        cboRoom.Items.Clear();
        cboRoom.Items.AddRange(new object[]
        {
            "P201 · 24 chỗ",
            "P202 · 20 chỗ",
            "P203 · 18 chỗ",
            "P101 · 30 chỗ"
        });
        if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Bản nháp",
            "Đang tuyển sinh",
            "Đang học",
            "Đã kết thúc"
        });
        if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

        txtCapacity.Text = "20";
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

            string actionMsg = _isEditMode ? "cập nhật" : "lưu mới";
            MessageBox.Show($"Đã {actionMsg} lớp học '{txtClassCode.Text}' thành công vào hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
