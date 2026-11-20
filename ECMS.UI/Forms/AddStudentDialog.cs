using System;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddStudentDialog : Form
{
    private readonly IStudentService _studentService = new StudentService();
    private readonly bool _isEditMode;
    private readonly string _initialName = string.Empty;
    private readonly StudentDetailDto? _existingDetail;

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

    public AddStudentDialog(StudentDetailDto detail)
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = true;
        _existingDetail = detail;
        _initialName = detail.FullName;

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

            if (_existingDetail != null)
            {
                txtFullName.Text = _existingDetail.FullName;
                txtPhone.Text = _existingDetail.Phone;
                txtEmail.Text = _existingDetail.Email ?? "";
                txtAddress.Text = _existingDetail.Address ?? "";
                txtParentName.Text = _existingDetail.ParentFullName;
                txtParentPhone.Text = _existingDetail.ParentPhone;
                dtpDob.Value = _existingDetail.DateOfBirth > new DateTime(1950, 1, 1)
                    ? _existingDetail.DateOfBirth
                    : new DateTime(2004, 5, 20);

                int gIdx = cboGender.FindStringExact(_existingDetail.Gender);
                if (gIdx >= 0) cboGender.SelectedIndex = gIdx;
            }
            else
            {
                txtFullName.Text = _initialName;
            }
        }
    }

    private void WireUpEvents()
    {
        btnCancelAdd.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSaveStudent.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập họ và tên học viên.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập số điện thoại.");
                txtPhone.Focus();
                return;
            }

            if (_isEditMode && _existingDetail != null)
            {
                btnSaveStudent.Enabled = false;
                try
                {
                    var updateDto = new UpdateStudentProfileDto
                    {
                        StudentId = _existingDetail.StudentId,
                        FullName = txtFullName.Text.Trim(),
                        DateOfBirth = dtpDob.Value,
                        Gender = cboGender.SelectedItem?.ToString() ?? "Nam",
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        ParentFullName = txtParentName.Text.Trim(),
                        ParentPhone = txtParentPhone.Text.Trim(),
                        ParentRelationship = _existingDetail.ParentRelationship
                    };

                    var res = await _studentService.UpdateStudentProfileAsync(updateDto);
                    if (!res.Success)
                    {
                        AppDialog.ShowError(this, "Lỗi cập nhật", res.Message);
                        return;
                    }
                }
                finally
                {
                    btnSaveStudent.Enabled = true;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
