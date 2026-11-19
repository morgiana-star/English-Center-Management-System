using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại quy trình Đăng ký học & Thanh toán học phí (Hỗ trợ đóng tối đa 3 đợt)
/// Triển khai theo quy trình 4 bước chuẩn hóa:
/// Bước 1: Thông tin học viên & Người liên hệ
/// Bước 2: Chọn chương trình & Lớp học (Bộ lọc, Tìm kiếm, Chọn trực tiếp)
/// Bước 3: Kế hoạch thanh toán & Thu phí
/// Bước 4: Hoàn tất cấp mã & Xuất phiếu báo nhập học
/// </summary>
public partial class StudentEnrollmentWizardDialog : Form
{
    private int _currentStep = 1;
    private decimal _courseFee = 6800000;
    private decimal _discountAmount = 0;
    private string _selectedClassCode = "IELTS-F01";
    private string _selectedClassName = "IELTS Foundation";
    private string _selectedStartDate = "01/12/2026";
    private string _selectedTeacher = "Nguyễn Hoàng Anh";
    private string _selectedSchedule = "T3 / T6 · 18:00 - 20:00";
    private string _selectedRoom = "P201";

    public string CreatedStudentName { get; private set; } = string.Empty;
    public string CreatedStudentCode { get; private set; } = "HV-0242";
    public string CreatedStudentPhone { get; private set; } = string.Empty;
    public string CreatedStudentEmail { get; private set; } = string.Empty;
    public DateTime CreatedStudentDob { get; private set; } = DateTime.Today.AddYears(-18);
    public string CreatedStudentGender { get; private set; } = "Nam";
    public string CreatedStudentAddress { get; private set; } = string.Empty;
    public string CreatedParentName { get; private set; } = string.Empty;
    public string CreatedParentPhone { get; private set; } = string.Empty;
    public string CreatedParentRelationship { get; private set; } = "Phụ huynh";
    public string CreatedNotes { get; private set; } = string.Empty;
    public string CreatedClassName { get; private set; } = string.Empty;
    public string SelectedCourseTitle { get; private set; } = "IELTS Foundation";
    public decimal CourseFee => _courseFee;
    public string CreatedDebt { get; private set; } = "0đ";

    // Danh sách lớp gốc để lọc
    private record ClassRowModel(string Code, string StartDate, string Schedule, string Room, string Teacher, string Capacity);
    private readonly List<ClassRowModel> _allClasses = new()
    {
        new("IELTS-F01", "01/12/2026", "T3 / T6 · 18:00 - 20:00", "P201", "Nguyễn Hoàng Anh", "17/20"),
        new("IELTS-F02", "05/12/2026", "T2 / T5 · 19:30 - 21:30", "P202", "Trần Gia Bảo", "16/20"),
        new("IELTS-F03", "10/12/2026", "T7 / CN · 08:30 - 10:30", "P101", "Lê Thị Thu", "12/20"),
        new("IELTS-F04", "15/12/2026", "T2 / T4 / T6 · 17:30 - 19:00", "P203", "Vũ Mai Phương", "14/20")
    };

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
        // 1. Dữ liệu thông tin học viên & phụ huynh (Bước 1)
        cboGender.Items.Clear();
        cboGender.Items.AddRange(new object[] { "Nữ", "Nam", "Khác" });
        cboGender.SelectedIndex = 0;
        dtpDob.Value = new DateTime(2004, 5, 20);

        cboRelationship.Items.Clear();
        cboRelationship.Items.AddRange(new object[] { "Phụ huynh (Bố)", "Phụ huynh (Mẹ)", "Người giám hộ", "Khác", "Tự đăng ký" });
        cboRelationship.SelectedIndex = 0;

        // 2. Dữ liệu khóa học (Bước 2)
        cboCourse.Items.Clear();
        cboCourse.Items.AddRange(new object[]
        {
            "IELTS Foundation (Nền tảng IELTS · 24 buổi)",
            "IELTS Intensive (Luyện thi chuyên sâu · 30 buổi)",
            "TOEIC 500+ (Luyện thi TOEIC chuẩn · 20 buổi)",
            "Tiếng Anh giao tiếp quốc tế (16 buổi)"
        });
        cboCourse.SelectedIndex = 0;

        // Bộ lọc ca học & tình trạng trên bảng
        cboShiftFilter.Items.Clear();
        cboShiftFilter.Items.AddRange(new object[] { "Tất cả ca học", "Ca tối T3 / T6", "Ca tối T2 / T5", "Cuối tuần T7 / CN" });
        cboShiftFilter.SelectedIndex = 0;

        cboAvailabilityFilter.Items.Clear();
        cboAvailabilityFilter.Items.AddRange(new object[] { "Tất cả tình trạng", "Còn chỗ", "Sắp đầy (>15 HV)" });
        cboAvailabilityFilter.SelectedIndex = 0;

        // Cấu hình bảng lớp học
        SetupClassesGrid();
        PopulateClassRows(_allClasses);

        // 3. Chính sách ưu đãi & Phương thức thanh toán (Bước 3)
        cboDiscount.Items.Clear();
        cboDiscount.Items.AddRange(new object[]
        {
            "Không áp dụng ưu đãi (0%)",
            "Khuyến mãi khai giảng (Giảm 10%)",
            "Voucher tân sinh viên (Giảm 500.000đ)"
        });
        cboDiscount.SelectedIndex = 0;

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

    private void SetupClassesGrid()
    {
        var colCode = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColClassCode", "Mã lớp ↑")];
        var colStartDate = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColStartDate", "Khai giảng")];
        var colSchedule = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColSchedule", "Lịch học")];
        var colRoom = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColRoom", "Phòng")];
        var colTeacher = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColTeacher", "Giáo viên")];
        var colCapacity = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColCapacity", "Sĩ số")];

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Chọn lớp",
            UseColumnTextForButtonValue = false,
            FlatStyle = FlatStyle.Flat
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        colAction.DefaultCellStyle.SelectionForeColor = Color.White;
        colAction.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
        dgvOpenClasses.Columns.Add(colAction);

        colCode.FillWeight = 14;
        colStartDate.FillWeight = 14;
        colSchedule.FillWeight = 26;
        colRoom.FillWeight = 10;
        colTeacher.FillWeight = 18;
        colCapacity.FillWeight = 10;
        colAction.FillWeight = 14;
    }

    private void PopulateClassRows(IEnumerable<ClassRowModel> list)
    {
        dgvOpenClasses.Rows.Clear();
        foreach (var c in list)
        {
            int idx = dgvOpenClasses.Rows.Add(c.Code, c.StartDate, c.Schedule, c.Room, c.Teacher, c.Capacity);
            bool isSelected = c.Code == _selectedClassCode;
            dgvOpenClasses.Rows[idx].Cells["ColAction"].Value = isSelected ? "✓ Đang chọn" : "Chọn lớp";
            if (isSelected)
            {
                dgvOpenClasses.Rows[idx].Selected = true;
            }
        }
        UpdateBottomFeeLabel();
    }

    private void UpdateBottomFeeLabel()
    {
        lblBottomTuitionFee.Text = $"Tổng học phí: {_courseFee:N0} VNĐ";
    }

    private void WireEvents()
    {
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
                    break;
                case 1:
                    _courseFee = 8500000;
                    _selectedClassName = "IELTS Intensive";
                    break;
                case 2:
                    _courseFee = 4800000;
                    _selectedClassName = "TOEIC 500+";
                    break;
                case 3:
                    _courseFee = 3600000;
                    _selectedClassName = "Giao tiếp quốc tế";
                    break;
            }
            UpdateBottomFeeLabel();
            RecalculateInstallments();
        };

        // Lọc tìm kiếm trên bảng lớp
        txtSearchClass.TextChanged += (s, e) => FilterClasses();
        cboShiftFilter.SelectedIndexChanged += (s, e) => FilterClasses();
        cboAvailabilityFilter.SelectedIndexChanged += (s, e) => FilterClasses();

        // Bấm nút "Chọn lớp" trực tiếp trên DataGridView
        dgvOpenClasses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvOpenClasses.Columns[e.ColumnIndex].Name == "ColAction")
            {
                SelectClassAtRow(e.RowIndex);
            }
        };

        dgvOpenClasses.SelectionChanged += (s, e) =>
        {
            if (dgvOpenClasses.CurrentRow != null && dgvOpenClasses.CurrentRow.Index >= 0)
            {
                SelectClassAtRow(dgvOpenClasses.CurrentRow.Index, updateRowSelection: false);
            }
        };

        // Đổi ưu đãi
        cboDiscount.SelectedIndexChanged += (s, e) =>
        {
            switch (cboDiscount.SelectedIndex)
            {
                case 1:
                    _discountAmount = Math.Round(_courseFee * 0.1m, 0);
                    break;
                case 2:
                    _discountAmount = 500000m;
                    break;
                default:
                    _discountAmount = 0;
                    break;
            }
            RecalculateInstallments();
        };

        // Chọn phương án đóng học phí
        radPayFull.CheckedChanged += (s, e) => { if (radPayFull.Checked) RecalculateInstallments(); };
        radPay2Installments.CheckedChanged += (s, e) => { if (radPay2Installments.Checked) RecalculateInstallments(); };
        radPay3Installments.CheckedChanged += (s, e) => { if (radPay3Installments.Checked) RecalculateInstallments(); };
    }

    private void SelectClassAtRow(int rowIndex, bool updateRowSelection = true)
    {
        if (rowIndex < 0 || rowIndex >= dgvOpenClasses.Rows.Count) return;

        var row = dgvOpenClasses.Rows[rowIndex];
        _selectedClassCode = row.Cells["ColClassCode"].Value?.ToString() ?? "IELTS-F01";
        _selectedStartDate = row.Cells["ColStartDate"].Value?.ToString() ?? "01/12/2026";
        _selectedSchedule = row.Cells["ColSchedule"].Value?.ToString() ?? "";
        _selectedRoom = row.Cells["ColRoom"].Value?.ToString() ?? "";
        _selectedTeacher = row.Cells["ColTeacher"].Value?.ToString() ?? "";

        // Cập nhật lại text nút cho tất cả các dòng
        for (int i = 0; i < dgvOpenClasses.Rows.Count; i++)
        {
            dgvOpenClasses.Rows[i].Cells["ColAction"].Value = (i == rowIndex) ? "✓ Đang chọn" : "Chọn lớp";
        }

        if (updateRowSelection)
        {
            dgvOpenClasses.Rows[rowIndex].Selected = true;
        }
    }

    private void FilterClasses()
    {
        string kw = txtSearchClass.Text.Trim().ToLowerInvariant();
        int shiftIdx = cboShiftFilter.SelectedIndex;
        int availIdx = cboAvailabilityFilter.SelectedIndex;

        var filtered = _allClasses.Where(c =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           c.Code.ToLowerInvariant().Contains(kw) ||
                           c.Teacher.ToLowerInvariant().Contains(kw) ||
                           c.Room.ToLowerInvariant().Contains(kw);

            bool matchShift = shiftIdx switch
            {
                1 => c.Schedule.Contains("T3 / T6"),
                2 => c.Schedule.Contains("T2 / T5"),
                3 => c.Schedule.Contains("T7 / CN"),
                _ => true
            };

            bool matchAvail = availIdx switch
            {
                1 => !c.Capacity.StartsWith("20/"),
                2 => c.Capacity.StartsWith("16/") || c.Capacity.StartsWith("17/"),
                _ => true
            };

            return matchKw && matchShift && matchAvail;
        }).ToList();

        PopulateClassRows(filtered);
    }

    private void RecalculateInstallments()
    {
        decimal payableFee = Math.Max(0, _courseFee - _discountAmount);
        string discountNote = _discountAmount > 0 ? $" (Đã giảm {_discountAmount:N0}đ)" : "";

        lblSummaryFee.Text = $"Tổng học phí phải nộp: {payableFee:N0} VNĐ{discountNote}";

        if (radPayFull.Checked)
        {
            txtInitialPayment.Text = $"{payableFee:N0}";
            lblDebtSummary.Text = "Công nợ còn lại: 0 VNĐ (Đã thanh toán đủ 100% học phí · Miễn công nợ)";
            lblDebtSummary.ForeColor = Color.FromArgb(22, 163, 74);
            CreatedDebt = "0đ";
        }
        else if (radPay2Installments.Checked)
        {
            decimal half = Math.Round(payableFee / 2, 0);
            decimal remain = payableFee - half;
            txtInitialPayment.Text = $"{half:N0}";
            lblDebtSummary.Text = $"Công nợ còn lại: {remain:N0} VNĐ · Đợt 2 hẹn thanh toán: 30/12/2026";
            lblDebtSummary.ForeColor = Color.FromArgb(217, 119, 6);
            CreatedDebt = $"{remain:N0}đ";
        }
        else if (radPay3Installments.Checked)
        {
            decimal part1 = Math.Round(payableFee * 0.4m, 0);
            decimal part2 = Math.Round(payableFee * 0.3m, 0);
            decimal part3 = payableFee - part1 - part2;
            txtInitialPayment.Text = $"{part1:N0}";
            decimal remain = part2 + part3;
            lblDebtSummary.Text = $"Công nợ còn lại: {remain:N0} VNĐ · Đợt 2 ({part2:N0}đ - 15/01) · Đợt 3 ({part3:N0}đ - 15/02)";
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
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập họ và tên học viên.");
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập số điện thoại liên hệ của học viên.");
                txtPhone.Focus();
                return;
            }

            CreatedStudentName = txtFullName.Text.Trim();
            CreatedStudentPhone = txtPhone.Text.Trim();
            CreatedStudentEmail = txtEmail.Text.Trim();
            CreatedStudentAddress = txtAddress.Text.Trim();
            CreatedStudentDob = dtpDob.Value;
            CreatedStudentGender = cboGender.SelectedItem?.ToString() ?? "Nam";
            CreatedParentName = txtParentName.Text.Trim();
            CreatedParentPhone = txtParentPhone.Text.Trim();
            CreatedParentRelationship = cboRelationship.SelectedItem?.ToString() ?? "Phụ huynh";
            CreatedNotes = txtNotes.Text.Trim();

            ShowStep(2);
        }
        else if (_currentStep == 2)
        {
            if (dgvOpenClasses.CurrentRow == null && dgvOpenClasses.Rows.Count > 0)
            {
                dgvOpenClasses.Rows[0].Selected = true;
                SelectClassAtRow(0);
            }

            CreatedClassName = _selectedClassCode;
            SelectedCourseTitle = _selectedClassName;

            CreatedStudentCode = $"HV-2026-{new Random().Next(242, 999):D4}";

            // Chuyển sang bước tiếp theo: Đóng wizard với DialogResult.OK để mở thẳng CollectTuitionDialog
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void ShowStep(int step)
    {
        _currentStep = step;
        pnlStep1.Visible = (step == 1);
        pnlStep2.Visible = (step == 2);
        pnlStep3.Visible = false;
        pnlStep4.Visible = false;

        btnBack.Visible = (step > 1);
       

        switch (step)
        {
            case 1:
                lblTitle.Text = "Đăng ký nhập học & Xếp lớp mới";
                lblSubtitle.Text = "Bước 1 / 2: Điền thông tin cá nhân và người liên hệ của học viên";
                btnNext.Text = "Tiếp tục →";
                break;
            case 2:
                lblTitle.Text = "Chọn Khóa học & Lớp học";
                lblSubtitle.Text = "Bước 2 / 2: Chọn chương trình đào tạo và lớp học đang mở tuyển sinh";
                btnNext.Text = "Chuyển sang Thu phí →";
                break;
        }
    }
}
