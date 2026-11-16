using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại quy trình Đăng ký học & Thanh toán học phí (Hỗ trợ đóng tối đa 3 đợt)
/// Triển khai theo nghiệp vụ Mục 4:
/// Nhập thông tin học viên -> Chọn khóa học -> Chọn lớp học -> Xác nhận -> Thanh toán học phí (tối đa 3 đợt) -> Trở thành học viên
/// </summary>
public partial class StudentEnrollmentWizardDialog : Form
{
    private int _currentStep = 1;
    private decimal _courseFee = 6800000;
    private string _selectedClassCode = "IELTS-F01";
    private string _selectedClassName = "IELTS Foundation";
    private string _selectedTeacher = "Nguyễn Hoàng Anh";
    private string _selectedSchedule = "T3 / T6 · 18:00 - 20:00";
    private string _selectedRoom = "P201";

    public string CreatedStudentName { get; private set; } = string.Empty;
    public string CreatedStudentCode { get; private set; } = "HV-0242";
    public string CreatedStudentPhone { get; private set; } = string.Empty;
    public string CreatedClassName { get; private set; } = string.Empty;
    public string CreatedDebt { get; private set; } = "0đ";

    public StudentEnrollmentWizardDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupData();
        WireEvents();
        ShowStep(1);
    }

    private void SetupData()
    {
        // 0. Dữ liệu thông tin học viên (Bước 1 theo Ảnh 3)
        cboGender.Items.Clear();
        cboGender.Items.AddRange(new object[] { "Nữ", "Nam", "Khác" });
        cboGender.SelectedIndex = 0;
        dtpDob.Value = new DateTime(2004, 5, 20);

        // 1. Dữ liệu khóa học
        cboCourse.Items.Clear();
        cboCourse.Items.AddRange(new object[]
        {
            "IELTS Foundation (Nền tảng IELTS · 24 buổi · 6.800.000đ)",
            "IELTS Intensive (Luyện thi chuyên sâu · 30 buổi · 8.500.000đ)",
            "TOEIC 500+ (Luyện thi TOEIC chuẩn · 20 buổi · 4.800.000đ)",
            "Tiếng Anh giao tiếp quốc tế (16 buổi · 3.600.000đ)"
        });
        cboCourse.SelectedIndex = 0;

        // 2. Dữ liệu lớp học mở tuyển sinh
        dgvOpenClasses.Columns.Clear();
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp ↑", FillWeight = 18 });
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lịch học", FillWeight = 26 });
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 12 });
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 22 });
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 14 });
        dgvOpenClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 16 });

        dgvOpenClasses.Rows.Add("IELTS-F01", "T3 / T6 · 18:00 - 20:00", "P201", "Nguyễn Hoàng Anh", "17/20", "Còn 3 chỗ");
        dgvOpenClasses.Rows.Add("IELTS-F02", "T2 / T5 · 19:30 - 21:30", "P202", "Trần Gia Bảo", "16/20", "Còn 4 chỗ");
        dgvOpenClasses.Rows.Add("IELTS-F03", "T7 / CN · 08:30 - 10:30", "P101", "Lê Thị Thu", "12/20", "Còn 8 chỗ");
        dgvOpenClasses.ClearSelection();

        // 3. Hình thức thanh toán
        cboPaymentMethod.Items.Clear();
        cboPaymentMethod.Items.AddRange(new object[]
        {
            "Chuyển khoản ngân hàng (Mã QR tức thời)",
            "Tiền mặt (Thu tại quầy tiếp tân)",
            "Quẹt thẻ POS ngân hàng"
        });
        cboPaymentMethod.SelectedIndex = 0;

        txtInitialPayment.Text = "3.400.000";
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();
        btnBack.Click += (s, e) => ShowStep(_currentStep - 1);
        btnNext.Click += (s, e) => HandleNextStep();

        // Đổi khóa học
        cboCourse.SelectedIndexChanged += (s, e) =>
        {
            switch (cboCourse.SelectedIndex)
            {
                case 0:
                    _courseFee = 6800000;
                    _selectedClassName = "IELTS Foundation";
                    lblCourseFee.Text = "Học phí chuẩn: 6.800.000 VNĐ · 24 buổi học";
                    break;
                case 1:
                    _courseFee = 8500000;
                    _selectedClassName = "IELTS Intensive";
                    lblCourseFee.Text = "Học phí chuẩn: 8.500.000 VNĐ · 30 buổi học";
                    break;
                case 2:
                    _courseFee = 4800000;
                    _selectedClassName = "TOEIC 500+";
                    lblCourseFee.Text = "Học phí chuẩn: 4.800.000 VNĐ · 20 buổi học";
                    break;
                case 3:
                    _courseFee = 3600000;
                    _selectedClassName = "Giao tiếp quốc tế";
                    lblCourseFee.Text = "Học phí chuẩn: 3.600.000 VNĐ · 16 buổi học";
                    break;
            }
            RecalculateInstallments();
        };

        // Chọn lớp học trong DataGridView
        dgvOpenClasses.SelectionChanged += (s, e) =>
        {
            if (dgvOpenClasses.CurrentRow != null && dgvOpenClasses.CurrentRow.Index >= 0)
            {
                var row = dgvOpenClasses.CurrentRow;
                _selectedClassCode = row.Cells[0].Value?.ToString() ?? "IELTS-F01";
                _selectedSchedule = row.Cells[1].Value?.ToString() ?? "";
                _selectedRoom = row.Cells[2].Value?.ToString() ?? "";
                _selectedTeacher = row.Cells[3].Value?.ToString() ?? "";
            }
        };

        // Chọn phương án đóng học phí
        radPayFull.CheckedChanged += (s, e) => { if (radPayFull.Checked) RecalculateInstallments(); };
        radPay2Installments.CheckedChanged += (s, e) => { if (radPay2Installments.Checked) RecalculateInstallments(); };
        radPay3Installments.CheckedChanged += (s, e) => { if (radPay3Installments.Checked) RecalculateInstallments(); };
    }

    private void RecalculateInstallments()
    {
        if (radPayFull.Checked)
        {
            txtInitialPayment.Text = $"{_courseFee:N0}";
            lblDebtSummary.Text = "Công nợ còn lại: 0 VNĐ (Đã thanh toán đủ 100% học phí)";
            lblDebtSummary.ForeColor = Color.FromArgb(22, 163, 74);
            CreatedDebt = "0đ";
        }
        else if (radPay2Installments.Checked)
        {
            decimal half = _courseFee / 2;
            txtInitialPayment.Text = $"{half:N0}";
            lblDebtSummary.Text = $"Công nợ còn lại: {half:N0} VNĐ · Đợt 2 hẹn thanh toán: 30/11/2026";
            lblDebtSummary.ForeColor = Color.FromArgb(217, 119, 6);
            CreatedDebt = $"{half:N0}đ";
        }
        else if (radPay3Installments.Checked)
        {
            decimal part1 = Math.Round(_courseFee * 0.4m, 0);
            decimal part2 = Math.Round(_courseFee * 0.3m, 0);
            decimal part3 = _courseFee - part1 - part2;
            txtInitialPayment.Text = $"{part1:N0}";
            decimal remain = part2 + part3;
            lblDebtSummary.Text = $"Công nợ còn lại: {remain:N0} VNĐ · Đợt 2 ({part2:N0}đ - 15/11) · Đợt 3 ({part3:N0}đ - 15/12)";
            lblDebtSummary.ForeColor = Color.FromArgb(217, 119, 6);
            CreatedDebt = $"{remain:N0}đ";
        }
    }

    private void HandleNextStep()
    {
        if (_currentStep == 1)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên học viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại học viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            CreatedStudentName = txtFullName.Text.Trim();
            CreatedStudentPhone = txtPhone.Text.Trim();
            ShowStep(2);
        }
        else if (_currentStep == 2)
        {
            if (dgvOpenClasses.CurrentRow == null)
            {
                dgvOpenClasses.Rows[0].Selected = true;
            }
            CreatedClassName = _selectedClassCode;

            // Cập nhật thông tin sang Bước 3
            lblSummaryStudent.Text = $"Học viên: {CreatedStudentName} ({CreatedStudentPhone})";
            lblSummaryClass.Text = $"Lớp ghi danh: {_selectedClassCode} · {_selectedClassName} · Phòng {_selectedRoom} ({_selectedTeacher})";
            lblSummaryFee.Text = $"Tổng học phí khóa học: {_courseFee:N0} đ";

            RecalculateInstallments();
            ShowStep(3);
        }
        else if (_currentStep == 3)
        {
            // Xác nhận thanh toán & chuyển thành học viên chính thức
            lblSuccessDesc.Text =
                $"• Đã cấp mã học viên chính thức: {CreatedStudentCode}\r\n" +
                $"• Họ và tên: {CreatedStudentName} ({CreatedStudentPhone})\r\n" +
                $"• Đã ghi danh vào lớp: {_selectedClassCode} · {_selectedClassName}\r\n" +
                $"• Đã thu đợt 1 thành công: {txtInitialPayment.Text} VNĐ\r\n" +
                $"• Tình trạng công nợ: {CreatedDebt}\r\n\r\n" +
                $"Hồ sơ đã được lưu trữ vào hệ thống và hiển thị trên danh sách học viên!";

            ShowStep(4);
        }
        else if (_currentStep == 4)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void ShowStep(int step)
    {
        _currentStep = step;
        pnlStep1.Visible = (step == 1);
        pnlStep2.Visible = (step == 2);
        pnlStep3.Visible = (step == 3);
        pnlStep4.Visible = (step == 4);

        btnBack.Visible = (step > 1 && step < 4);

        switch (step)
        {
            case 1:
                lblTitle.Text = "Đăng ký nhập học mới";
                lblStepBadge.Text = "Bước 1 / 4: Thông tin học viên";
                btnNext.Text = "Tiếp tục →";
                break;
            case 2:
                lblTitle.Text = "Chọn Khóa học & Lớp học";
                lblStepBadge.Text = "Bước 2 / 4: Chọn khóa & lớp";
                btnNext.Text = "Tiếp tục →";
                break;
            case 3:
                lblTitle.Text = "Kế hoạch thanh toán học phí";
                lblStepBadge.Text = "Bước 3 / 4: Thu phí (Tối đa 3 đợt)";
                btnNext.Text = "Xác nhận & Thu phí";
                break;
            case 4:
                lblTitle.Text = "Hoàn tất đăng ký học";
                lblStepBadge.Text = "Bước 4 / 4: Đã là học viên";
                btnNext.Text = "Hoàn tất & Đóng";
                btnCancel.Visible = false;
                break;
        }
    }
}
