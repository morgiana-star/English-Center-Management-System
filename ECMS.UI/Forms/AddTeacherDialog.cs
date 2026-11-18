using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddTeacherDialog : Form
{
    public AddTeacherDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupDropdowns();
        WireEvents();
    }

    private void SetupDropdowns()
    {
        cboSpecialty.Items.Clear();
        cboSpecialty.Items.AddRange(new object[]
        {
            "IELTS 8.0+",
            "IELTS 7.0–7.5",
            "TOEIC 900+",
            "Tiếng Anh Giao tiếp",
            "Ngữ pháp & Từ vựng"
        });
        cboSpecialty.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang giảng dạy",
            "Tạm nghỉ",
            "Thử việc"
        });
        cboStatus.SelectedIndex = 0;

        txtTeacherCode.Text = "GV-0025";
        txtMaxHours.Text = "12";
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
            string name = txtFullName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên giáo viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            AppDialog.ShowSuccess(this, "Thêm giáo viên", $"Đã lưu hồ sơ giáo viên {name} và thiết lập lịch rảnh vào SQLite thành công!");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
