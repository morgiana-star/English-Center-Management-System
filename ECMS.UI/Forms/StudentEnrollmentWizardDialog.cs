using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại quy trình Đăng ký học & Xếp lớp (100% Khóa học & Lớp học thật từ SQLite)
/// </summary>
public partial class StudentEnrollmentWizardDialog : Form
{
    private readonly IStudentService _studentService = new StudentService();
    private List<CourseLookupDto> _courses = new();
    private List<OpenClassOptionDto> _currentCourseClasses = new();

    private int _currentStep = 1;
    private bool _step1Validated = false;
    private bool _isProgrammaticTabSwitch = false;
    private decimal _courseFee = 0;
    private int _selectedClassId = 0;
    private string _selectedClassCode = string.Empty;
    private string _selectedCourseTitle = string.Empty;

    public int SelectedClassId => _selectedClassId;
    public bool SaveWaitingOnly { get; private set; } = false;
    public bool ShouldCollectTuition { get; private set; } = true;
    public string CreatedStudentName { get; private set; } = string.Empty;
    public string CreatedStudentCode { get; private set; } = string.Empty;
    public string CreatedStudentPhone { get; private set; } = string.Empty;
    public string CreatedStudentEmail { get; private set; } = string.Empty;
    public DateTime CreatedStudentDob { get; private set; } = DateTime.Today.AddYears(-18);
    public string CreatedStudentGender { get; private set; } = "Nam";
    public string CreatedStudentAddress { get; private set; } = string.Empty;
    public string CreatedParentName { get; private set; } = string.Empty;
    public string CreatedParentPhone { get; private set; } = string.Empty;
    public string CreatedParentRelationship { get; private set; } = "Bố";
    public string CreatedNotes { get; private set; } = string.Empty;
    public string CreatedClassName { get; private set; } = string.Empty;
    public string SelectedCourseTitle { get; private set; } = string.Empty;
    public decimal CourseFee => _courseFee;

    public StudentEnrollmentWizardDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupInitialUi();
        WireEvents();
        ShowStep(1);
        _ = LoadCoursesFromDbAsync();
    }

    private void SetupInitialUi()
    {
        // Bước 1: Thông tin học viên & người liên hệ
        cboGender.Items.Clear();
        cboGender.Items.AddRange(new object[] { "Nữ", "Nam", "Khác" });
        cboGender.SelectedIndex = 0;
        dtpDob.Value = new DateTime(2004, 5, 20);

        cboRelationship.Items.Clear();
        cboRelationship.Items.AddRange(new object[] { "Bố", "Mẹ", "Giám hộ", "Khác" });
        cboRelationship.SelectedIndex = 0;

        // Bước 2: Lọc ca học theo 3 khung giờ chuẩn
        cboShiftFilter.Items.Clear();
        cboShiftFilter.Items.AddRange(new object[]
        {
            "Tất cả ca học",
            "Ca sáng (08:00 - 12:00)",
            "Ca chiều (13:30 - 17:30)",
            "Ca tối (18:00 - 21:00)"
        });
        cboShiftFilter.SelectedIndex = 0;
        cboShiftFilter.Width = 230;
        cboAvailabilityFilter.Visible = false;

        SetupClassesGrid();
    }

    private async Task LoadCoursesFromDbAsync()
    {
        try
        {
            _courses = (await _studentService.GetActiveCoursesForEnrollmentAsync()).ToList();
            cboCourse.Items.Clear();
            foreach (var c in _courses)
            {
                cboCourse.Items.Add(c.DisplayText);
            }

            if (_courses.Count > 0)
            {
                cboCourse.SelectedIndex = 0;
                await LoadClassesForSelectedCourseAsync();
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi nạp danh sách khóa học", ex.Message);
        }
    }

    private async Task LoadClassesForSelectedCourseAsync()
    {
        int idx = cboCourse.SelectedIndex;
        if (idx < 0 || idx >= _courses.Count) return;

        var selectedCourse = _courses[idx];
        _courseFee = selectedCourse.BaseTuitionFee;
        _selectedCourseTitle = selectedCourse.CourseName;
        UpdateBottomFeeLabel();

        _currentCourseClasses = (await _studentService.GetOpenClassesByCourseAsync(selectedCourse.CourseId)).ToList();
        _selectedClassId = _currentCourseClasses.FirstOrDefault()?.ClassId ?? 0;
        _selectedClassCode = _currentCourseClasses.FirstOrDefault()?.ClassCode ?? "";

        FilterClasses();
    }

    private void SetupClassesGrid()
    {
        AppGridHelper.ApplyStyle(dgvOpenClasses);
        dgvOpenClasses.Columns.Clear();
        var colCode = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColClassCode", "Mã lớp")];
        var colStartDate = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColStartDate", "Ngày bắt đầu")];
        var colEndDate = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColEndDate", "Ngày kết thúc")];
        var colSchedule = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColSchedule", "Giờ học")];
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

        colCode.FillWeight = 12;
        colStartDate.FillWeight = 13;
        colEndDate.FillWeight = 13;
        colSchedule.FillWeight = 16;
        colRoom.FillWeight = 9;
        colTeacher.FillWeight = 16;
        colCapacity.FillWeight = 9;
        colAction.FillWeight = 12;
    }

    private void PopulateClassRows(IEnumerable<OpenClassOptionDto> list)
    {
        dgvOpenClasses.Rows.Clear();
        foreach (var c in list)
        {
            int idx = dgvOpenClasses.Rows.Add(
                c.ClassCode,
                c.StartDateDisplay,
                c.EndDateDisplay,
                c.ScheduleDisplay,
                c.RoomName,
                c.TeacherName,
                c.CapacityDisplay);
            dgvOpenClasses.Rows[idx].Tag = c;
            bool isSelected = c.ClassId == _selectedClassId;
            dgvOpenClasses.Rows[idx].Cells["ColAction"].Value = isSelected ? "Đang chọn" : "Chọn lớp";
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
        btnBack.Click += (s, e) => ShowStep(1);
        btnSaveWaiting.Click += async (s, e) => await HandleSaveWaitingOnlyAsync();
        btnNext.Click += async (s, e) => await HandleNextStepAsync(collectTuition: true);
        btnConfirmNoPay.Click += async (s, e) => await HandleNextStepAsync(collectTuition: false);

        tabSteps.Selecting += (s, e) =>
        {
            if (_isProgrammaticTabSwitch) return;
            if (e.TabPage == tpStep2 && !_step1Validated)
            {
                e.Cancel = true;
                AppDialog.ShowWarning(this, "Chưa hoàn tất Bước 1", "Vui lòng nhập đầy đủ thông tin ở Bước 1 và bấm 'Tiếp tục' để kiểm tra trước khi sang Bước 2.");
            }
            else if (e.TabPage == tpStep1)
            {
                _currentStep = 1;
                UpdateFooterForStep(1);
            }
            else if (e.TabPage == tpStep2)
            {
                _currentStep = 2;
                UpdateFooterForStep(2);
            }
        };

        cboCourse.SelectedIndexChanged += async (s, e) => await LoadClassesForSelectedCourseAsync();
        txtSearchClass.TextChanged += (s, e) => FilterClasses();
        cboShiftFilter.SelectedIndexChanged += (s, e) => FilterClasses();

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
    }

    private void SelectClassAtRow(int rowIndex, bool updateRowSelection = true)
    {
        if (rowIndex < 0 || rowIndex >= dgvOpenClasses.Rows.Count) return;

        var row = dgvOpenClasses.Rows[rowIndex];
        if (row.Tag is OpenClassOptionDto cls)
        {
            _selectedClassId = cls.ClassId;
            _selectedClassCode = cls.ClassCode;
            _courseFee = cls.TuitionFee;
            _selectedCourseTitle = cls.CourseName;
        }
        else
        {
            _selectedClassCode = row.Cells["ColClassCode"].Value?.ToString() ?? "";
        }

        for (int i = 0; i < dgvOpenClasses.Rows.Count; i++)
        {
            dgvOpenClasses.Rows[i].Cells["ColAction"].Value = (i == rowIndex) ? "Đang chọn" : "Chọn lớp";
        }

        if (updateRowSelection)
        {
            dgvOpenClasses.Rows[rowIndex].Selected = true;
        }
        UpdateBottomFeeLabel();
    }

    private void FilterClasses()
    {
        string kw = txtSearchClass.Text.Trim().ToLowerInvariant();
        int shiftIdx = cboShiftFilter.SelectedIndex;

        var filtered = _currentCourseClasses.Where(c =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           c.ClassCode.ToLowerInvariant().Contains(kw) ||
                           c.ClassName.ToLowerInvariant().Contains(kw) ||
                           c.TeacherName.ToLowerInvariant().Contains(kw) ||
                           c.RoomName.ToLowerInvariant().Contains(kw);

            bool matchShift = true;
            if (shiftIdx > 0)
            {
                int hour = 18;
                if (TimeSpan.TryParse(c.StartTime, out var ts))
                {
                    hour = ts.Hours;
                }

                matchShift = shiftIdx switch
                {
                    1 => hour >= 7 && hour < 12,   // Ca sáng (08:00 - 12:00)
                    2 => hour >= 12 && hour < 17,  // Ca chiều (13:30 - 17:30)
                    3 => hour >= 17,               // Ca tối (18:00 - 21:00)
                    _ => true
                };
            }

            return matchKw && matchShift;
        }).ToList();

        PopulateClassRows(filtered);
    }

    private async Task<bool> ValidateStep1Async()
    {
        string fullName = txtFullName.Text.Trim();
        string phone = txtPhone.Text.Trim().Replace(" ", "");
        string email = txtEmail.Text.Trim();
        string address = txtAddress.Text.Trim();
        string parentName = txtParentName.Text.Trim();
        string parentPhone = txtParentPhone.Text.Trim().Replace(" ", "");

        if (string.IsNullOrWhiteSpace(fullName) || fullName.Length < 2)
        {
            AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập đầy đủ họ và tên học viên.");
            txtFullName.Focus();
            return false;
        }

        if (dtpDob.Value.Date >= DateTime.Today.AddYears(-3))
        {
            AppDialog.ShowWarning(this, "Ngày sinh không hợp lệ", "Ngày sinh học viên phải nhỏ hơn ngày hiện tại ít nhất 3 năm.");
            dtpDob.Focus();
            return false;
        }

        if (cboGender.SelectedIndex < 0)
        {
            AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng chọn giới tính học viên.");
            cboGender.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, @"^0\d{9}$"))
        {
            AppDialog.ShowWarning(this, "Số điện thoại không hợp lệ", "Vui lòng nhập số điện thoại học viên gồm đúng 10 chữ số, bắt đầu bằng số 0.");
            txtPhone.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            AppDialog.ShowWarning(this, "Email không hợp lệ", "Vui lòng nhập địa chỉ email học viên đúng định dạng (vd: ten@domain.com).");
            txtEmail.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(address))
        {
            AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập địa chỉ liên hệ của học viên.");
            txtAddress.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(parentName))
        {
            AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập họ và tên phụ huynh / người liên hệ.");
            txtParentName.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(parentPhone) || !Regex.IsMatch(parentPhone, @"^0\d{9}$"))
        {
            AppDialog.ShowWarning(this, "Số điện thoại phụ huynh không hợp lệ", "Vui lòng nhập số điện thoại phụ huynh gồm đúng 10 chữ số, bắt đầu bằng số 0.");
            txtParentPhone.Focus();
            return false;
        }

        if (cboRelationship.SelectedIndex < 0)
        {
            AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng chọn mối quan hệ với học viên.");
            cboRelationship.Focus();
            return false;
        }

        // Kiểm tra trùng học viên trong SQLite
        var dup = await _studentService.CheckDuplicateStudentAsync(phone, fullName, dtpDob.Value);
        if (dup.IsDuplicate)
        {
            AppDialog.ShowWarning(this, "Học viên đã tồn tại", dup.Reason);
            txtPhone.Focus();
            return false;
        }

        CreatedStudentName = fullName;
        CreatedStudentPhone = phone;
        CreatedStudentEmail = email;
        CreatedStudentAddress = address;
        CreatedStudentDob = dtpDob.Value;
        CreatedStudentGender = cboGender.SelectedItem?.ToString() ?? "Nam";
        CreatedParentName = parentName;
        CreatedParentPhone = parentPhone;
        CreatedParentRelationship = cboRelationship.SelectedItem?.ToString() ?? "Bố";
        CreatedNotes = txtNotes.Text.Trim();
        _step1Validated = true;
        return true;
    }

    private async Task HandleSaveWaitingOnlyAsync()
    {
        if (!await ValidateStep1Async()) return;

        SaveWaitingOnly = true;
        ShouldCollectTuition = false;
        CreatedClassName = "Chờ xếp lớp";
        SelectedCourseTitle = string.Empty;
        CreatedStudentCode = await _studentService.GenerateNextStudentCodeAsync();

        DialogResult = DialogResult.OK;
        Close();
    }

    private async Task HandleNextStepAsync(bool collectTuition)
    {
        if (_currentStep == 1)
        {
            if (!await ValidateStep1Async()) return;
            ShowStep(2);
        }
        else if (_currentStep == 2)
        {
            if (dgvOpenClasses.Rows.Count == 0)
            {
                AppDialog.ShowWarning(this, "Chưa chọn lớp", "Khóa học này hiện không có lớp nào khả dụng. Vui lòng chọn khóa học khác hoặc xóa bộ lọc.");
                return;
            }

            if (_selectedClassId <= 0 || dgvOpenClasses.CurrentRow == null)
            {
                dgvOpenClasses.Rows[0].Selected = true;
                SelectClassAtRow(0);
            }

            if (dgvOpenClasses.CurrentRow?.Tag is OpenClassOptionDto chosen && chosen.CurrentStudents >= chosen.MaxStudents)
            {
                AppDialog.ShowWarning(this, "Lớp đã đủ sĩ số", $"Lớp {chosen.ClassCode} đã đủ sĩ số ({chosen.CurrentStudents}/{chosen.MaxStudents}). Vui lòng chọn lớp khác.");
                return;
            }

            ShouldCollectTuition = collectTuition;
            CreatedClassName = _selectedClassCode;
            SelectedCourseTitle = _selectedCourseTitle;
            CreatedStudentCode = await _studentService.GenerateNextStudentCodeAsync();

            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void ShowStep(int step)
    {
        _currentStep = step;
        _isProgrammaticTabSwitch = true;
        try
        {
            tabSteps.SelectedIndex = step == 1 ? 0 : 1;
        }
        finally
        {
            _isProgrammaticTabSwitch = false;
        }
        UpdateFooterForStep(step);
    }

    private void UpdateFooterForStep(int step)
    {
        btnSaveWaiting.Visible = (step == 1);
        btnBack.Visible = (step == 2);
        btnConfirmNoPay.Visible = (step == 2);

        if (step == 1)
        {
            lblTitle.Text = "Đăng ký nhập học & Xếp lớp mới";
            lblSubtitle.Text = "Bước 1 / 2: Điền đầy đủ thông tin cá nhân và người liên hệ của học viên (trừ Ghi chú)";
            btnNext.Text = "Tiếp tục";
        }
        else
        {
            lblTitle.Text = "Chọn Khóa học & Lớp học";
            lblSubtitle.Text = "Bước 2 / 2: Chọn chương trình đào tạo và lớp học đang mở tuyển sinh";
            btnNext.Text = "Thu phí";
        }
    }
}
