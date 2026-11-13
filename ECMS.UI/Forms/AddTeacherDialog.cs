using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class AddTeacherDialog : Form
{
    public AddTeacherDialog()
    {
        InitializeComponent();

        SetupDropdowns();
        WireEvents();
    }

    private void SetupDropdowns()
    {
        txtTeacherCode.Text = "GV-006";

        cboSpecialty.Items.Clear();
        cboSpecialty.Items.AddRange(new object[]
        {
            "IELTS 8.0+",
            "IELTS 7.0–7.5",
            "TOEIC 900+",
            "TOEIC 750–850",
            "Giao tiếp quốc tế",
            "Tiếng Anh trẻ em"
        });
        cboSpecialty.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang giảng dạy",
            "Chờ phân công",
            "Tạm nghỉ"
        });
        cboStatus.SelectedIndex = 0;

        cboPreferredSlot.Items.Clear();
        cboPreferredSlot.Items.AddRange(new object[]
        {
            "Ca tối (18:00–20:00)",
            "Ca chiều (14:00–16:00)",
            "Ca sáng (08:30–10:30)",
            "Linh hoạt mọi ca"
        });
        cboPreferredSlot.SelectedIndex = 0;

        txtMaxHours.Text = "12 giờ / tuần";
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
            if (string.IsNullOrWhiteSpace(txtTeacherCode.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã giáo viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên giáo viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại liên hệ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            MessageBox.Show($"Đã thêm giáo viên '{txtFullName.Text}' ({txtTeacherCode.Text}) thành công vào hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
