using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddStudentDialog : Form
{
    public AddStudentDialog()
    {
        InitializeComponent();
        SetupDropdowns();
        WireUpEvents();
    }

    private void SetupDropdowns()
    {
        cboGender.Items.AddRange(new object[] { "Nữ", "Nam", "Khác" });
        cboGender.SelectedIndex = 0;
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
            AppDialog.ShowSuccess(this, "Thêm học viên", "Đã lưu học viên HV-0242 vào hệ thống SQLite thành công!");
            DialogResult = DialogResult.OK;
            Close();
        };

        btnFindAdmission.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Tuyển sinh liên quan", "Tìm thấy hồ sơ tiềm năng TN-0112 (Ngô Mai Phương · TOEIC 650+). Bạn có thể liên kết trực tiếp.");
        };
    }
}
