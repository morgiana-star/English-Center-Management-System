using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddStudentDialog : Form
{
    private readonly bool _isEditMode;
    private readonly string _initialName = string.Empty;

    public AddStudentDialog() : this(false, string.Empty)
    {
    }

    public AddStudentDialog(bool isEditMode, string studentName = "")
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _initialName = studentName;

        SetupDropdowns();
        ApplyMode();
        WireUpEvents();
    }

    private void SetupDropdowns()
    {
        cboGender.Items.Clear();
        cboGender.Items.AddRange(new object[] { "Nữ", "Nam", "Khác" });
        cboGender.SelectedIndex = 0;
    }

    private void ApplyMode()
    {
        if (_isEditMode)
        {
            lblAddStudentHeader.Text = "Sửa hồ sơ học viên";
            Text = "Sửa học viên — ECMS";
            btnSaveStudent.Text = "Lưu thay đổi";

            txtFullName.Text = string.IsNullOrEmpty(_initialName) ? "Nguyễn Minh Anh" : _initialName;
            txtPhone.Text = "0908 123 456";
            txtEmail.Text = "minhanh.nguyen@email.com";
            txtAddress.Text = "124 Nguyễn Thị Minh Khai, Phường 6, Quận 3, TP.HCM";
            txtParentName.Text = "Nguyễn Thu Hương";
            txtParentPhone.Text = "0911 556 889";
            txtNotes.Text = "Mục tiêu: Đạt IELTS 6.5 trong 6 tháng. Ưu tiên lớp tối T3/T6.";
        }
    }

    private void WireUpEvents()
    {
        btnCancelAdd.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSaveStudent.Click += (s, e) =>
        {
            string actionText = _isEditMode ? "cập nhật" : "lưu mới";
            AppDialog.ShowSuccess(this, "Hồ sơ học viên", $"Đã {actionText} thông tin học viên {txtFullName.Text.Trim()} vào cơ sở dữ liệu SQLite thành công!");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
