using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ArchiveStudentDialog : Form
{
    public ArchiveStudentDialog()
    {
        InitializeComponent();
        WireUpEvents();
    }

    private void WireUpEvents()
    {
        btnCancelArchive.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnConfirmArchive.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Lưu trữ hồ sơ", "Đã chuyển hồ sơ học viên HV-0241 sang trạng thái 'Đã lưu trữ'. Dữ liệu điểm và học phí được giữ an toàn.");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
