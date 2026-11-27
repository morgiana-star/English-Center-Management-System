using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddTeacherDialog : Form
{
    private readonly ITeacherService _teacherService = new TeacherService();
    private readonly TeacherListItemDto? _editingTeacher;

    public AddTeacherDialog() : this(null)
    {
    }

    public AddTeacherDialog(TeacherListItemDto? editingTeacher)
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _editingTeacher = editingTeacher;
        SetupDropdowns();
        WireEvents();
        _ = LoadInitialDataAsync();
    }

    private void SetupDropdowns()
    {
        cboSpecialty.Items.Clear();
        cboSpecialty.Items.AddRange(StatusFormatter.TeacherSpecialties);
        cboSpecialty.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang giảng dạy",
            "Tạm nghỉ"
        });
        cboStatus.SelectedIndex = 0;
    }

    private async Task LoadInitialDataAsync()
    {
        if (_editingTeacher != null)
        {
            Text = "Chỉnh sửa thông tin giáo viên - ECMS";
            lblTitle.Text = "Chỉnh sửa thông tin giáo viên";
            btnSave.Text = "Lưu thay đổi";

            txtTeacherCode.Text = _editingTeacher.TeacherCode;
            txtTeacherCode.ReadOnly = true;
            txtFullName.Text = _editingTeacher.FullName;
            txtPhone.Text = _editingTeacher.Phone;
            txtEmail.Text = _editingTeacher.Email;
            txtCert.Text = _editingTeacher.Certificate;
            txtBio.Text = _editingTeacher.Notes;

            int specIdx = Array.FindIndex(StatusFormatter.TeacherSpecialties,
                s => s.Equals(_editingTeacher.Specialization, StringComparison.OrdinalIgnoreCase));
            if (specIdx >= 0)
            {
                cboSpecialty.SelectedIndex = specIdx;
            }
            else if (!string.IsNullOrWhiteSpace(_editingTeacher.Specialization))
            {
                cboSpecialty.Text = _editingTeacher.Specialization;
            }

            cboStatus.SelectedIndex = _editingTeacher.IsActive ? 0 : 1;

            string shifts = _editingTeacher.PreferredShifts ?? "";
            if (!string.IsNullOrWhiteSpace(shifts))
            {
                chkMorning.Checked = shifts.Contains("Sáng", StringComparison.OrdinalIgnoreCase);
                chkAfternoon.Checked = shifts.Contains("Chiều", StringComparison.OrdinalIgnoreCase);
                chkEvening.Checked = shifts.Contains("Tối", StringComparison.OrdinalIgnoreCase);
            }

            string days = _editingTeacher.AvailableDays ?? "";
            if (!string.IsNullOrWhiteSpace(days))
            {
                chkMon.Checked = days.Contains("T2");
                chkTue.Checked = days.Contains("T3");
                chkWed.Checked = days.Contains("T4");
                chkThu.Checked = days.Contains("T5");
                chkFri.Checked = days.Contains("T6");
                chkSat.Checked = days.Contains("T7");
                chkSun.Checked = days.Contains("CN");
            }
        }
        else
        {
            Text = "Thêm giáo viên mới - ECMS";
            lblTitle.Text = "Thêm giáo viên mới";
            btnSave.Text = "Lưu giáo viên";
            txtTeacherCode.Text = await _teacherService.GenerateNextTeacherCodeAsync();
            txtTeacherCode.ReadOnly = true;
        }
    }

    private string CollectPreferredShifts()
    {
        var list = new List<string>();
        if (chkMorning.Checked) list.Add("Ca Sáng (08:00 - 12:00)");
        if (chkAfternoon.Checked) list.Add("Ca Chiều (13:30 - 17:30)");
        if (chkEvening.Checked) list.Add("Ca Tối (18:00 - 21:00)");
        return string.Join(", ", list);
    }

    private string CollectAvailableDays()
    {
        var list = new List<string>();
        if (chkMon.Checked) list.Add("T2");
        if (chkTue.Checked) list.Add("T3");
        if (chkWed.Checked) list.Add("T4");
        if (chkThu.Checked) list.Add("T5");
        if (chkFri.Checked) list.Add("T6");
        if (chkSat.Checked) list.Add("T7");
        if (chkSun.Checked) list.Add("CN");
        return string.Join(", ", list);
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
            string availableDays = _editingTeacher?.AvailableDays ?? "";
            if (string.IsNullOrWhiteSpace(availableDays))
                availableDays = "T2, T3, T4, T5, T6, T7, CN";

            string preferredShifts = _editingTeacher?.PreferredShifts ?? "";
            if (string.IsNullOrWhiteSpace(preferredShifts))
                preferredShifts = "Ca Sáng (08:00 - 12:00), Ca Chiều (13:30 - 17:30), Ca Tối (18:00 - 21:00)";

            var dto = new SaveTeacherDto
            {
                TeacherId = _editingTeacher?.TeacherId ?? 0,
                TeacherCode = txtTeacherCode.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Specialization = !string.IsNullOrWhiteSpace(cboSpecialty.Text)
                    ? cboSpecialty.Text.Trim()
                    : (cboSpecialty.SelectedItem?.ToString() ?? StatusFormatter.TeacherSpecialties[0]),
                Certificate = txtCert.Text.Trim(),
                Notes = txtBio.Text.Trim(),
                PreferredShifts = preferredShifts,
                AvailableDays = availableDays,
                IsActive = cboStatus.SelectedIndex == 0
            };

            if (_editingTeacher != null)
            {
                var res = await _teacherService.UpdateTeacherAsync(dto);
                if (!res.Success)
                {
                    AppDialog.ShowWarning(this, "Không thể cập nhật", res.Message);
                    return;
                }
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
            }
            else
            {
                var res = await _teacherService.CreateTeacherAsync(dto);
                if (!res.Success)
                {
                    AppDialog.ShowWarning(this, "Không thể thêm giáo viên", res.Message);
                    return;
                }
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
