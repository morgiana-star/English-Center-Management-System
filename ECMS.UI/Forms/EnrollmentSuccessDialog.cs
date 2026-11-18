using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class EnrollmentSuccessDialog : Form
{
    public EnrollmentSuccessDialog()
    {
        InitializeComponent();
        WireUpEvents();
    }

    private void WireUpEvents()
    {
        btnReturnToList.Click += (s, e) =>
        {
            DialogResult = DialogResult.OK;
            Close();
        };

        btnOpenStudentProfile.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Hồ sơ học viên", "Đã mở hồ sơ học viên HV-0241 trong phân hệ Đào tạo.");
            DialogResult = DialogResult.OK;
            Close();
        };

        btnGoToTuition.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Chuyển tiếp thu phí", "Chuyển dữ liệu học viên HV-0241 sang phân hệ Học phí & Thanh toán để tạo phiếu thu.");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
