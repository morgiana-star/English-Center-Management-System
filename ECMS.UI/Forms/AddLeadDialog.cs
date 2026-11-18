using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddLeadDialog : Form
{
    public AddLeadDialog()
    {
        InitializeComponent();
        SetupDropdowns();
        WireUpEvents();
    }

    private void SetupDropdowns()
    {
        cboAddSource.Items.AddRange(new object[] { "Tư vấn tại trung tâm", "Website / Fanpage", "Người quen giới thiệu", "Hotline" });
        cboAddSource.SelectedIndex = 0;

        cboAddCourse.Items.AddRange(new object[] { "IELTS Foundation", "IELTS 5.0–6.5", "TOEIC 500+", "TOEIC 650+", "Tiếng Anh giao tiếp" });
        cboAddCourse.SelectedIndex = 0;

        cboAddStaff.Items.AddRange(new object[] { "Phạm Ngọc Mai", "Trần Minh Quân", "Lê Phương Thảo" });
        cboAddStaff.SelectedIndex = 0;
    }

    private void WireUpEvents()
    {
        btnCancelAdd.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSaveAdd.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Thêm khách hàng", "Đã lưu hồ sơ TN-0108 vào hệ thống SQLite thành công!");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
