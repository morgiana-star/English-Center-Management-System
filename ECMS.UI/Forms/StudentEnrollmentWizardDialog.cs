using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    private decimal _courseFee = 6800000;
    private int _selectedClassId = 0;
    private string _selectedClassCode = string.Empty;
    private string _selectedCourseTitle = string.Empty;

    public int SelectedClassId => _selectedClassId;
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
        cboRelationship.Items.AddRange(new object[] { "Phụ huynh (Bố)", "Phụ huynh (Mẹ)", "Người giám hộ", "Khác" });
        cboRelationship.SelectedIndex = 0;

        // Bước 2: Lọc ca học (Sáng / Chiều / Tối kèm giờ) và bỏ ô lọc tình trạng lớp
        cboShiftFilter.Items.Clear();
        cboShiftFilter.Items.AddRange(new object[]
        {
            "Tất cả ca học",
            "Ca sáng (08:00 - 11:30)",
            "Ca chiều (13:30 - 17:00)",
            "Ca tối (18:00 - 21:30)"
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
        dgvOpenClasses.Columns.Clear();
        var colCode = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColClassCode", "Mã lớp ↑")];
        var colStartDate = dgvOpenClasses.Columns[dgvOpenClasses.Columns.Add("ColStartDate", "Khai giảng")];
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

        colCode.FillWeight = 14;
        colStartDate.FillWeight = 14;
        colSchedule.FillWeight = 24;
        colRoom.FillWeight = 10;
        colTeacher.FillWeight = 18;
        colCapacity.FillWeight = 10;
        colAction.FillWeight = 14;
    }

    private void PopulateClassRows(IEnumerable<OpenClassOptionDto> list)
    {
        dgvOpenClasses.Rows.Clear();
        foreach (var c in list)
        {
            int idx = dgvOpenClasses.Rows.Add(c.ClassCode, c.StartDateDisplay, c.ScheduleDisplay, c.RoomName, c.TeacherName, c.CapacityDisplay);
            dgvOpenClasses.Rows[idx].Tag = c;
            bool isSelected = c.ClassId == _selectedClassId;
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
        btnNext.Click += async (s, e) => await HandleNextStepAsync();

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
            dgvOpenClasses.Rows[i].Cells["ColAction"].Value = (i == rowIndex) ? "✓ Đang chọn" : "Chọn lớp";
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
                    1 => hour >= 7 && hour < 12,   // Ca sáng (08:00 - 11:30)
                    2 => hour >= 12 && hour < 17,  // Ca chiều (13:30 - 17:00)
                    3 => hour >= 17,               // Ca tối (18:00 - 21:30)
                    _ => true
                };
            }

            return matchKw && matchShift;
        }).ToList();

        PopulateClassRows(filtered);
    }

    private async Task HandleNextStepAsync()
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
            CreatedParentRelationship = cboRelationship.SelectedItem?.ToString() ?? "Bố";
            CreatedNotes = txtNotes.Text.Trim();

            ShowStep(2);
        }
        else if (_currentStep == 2)
        {
            if (dgvOpenClasses.Rows.Count == 0)
            {
                AppDialog.ShowWarning(this, "Chưa chọn lớp", "Khóa học này hiện không có lớp nào khả dụng. Vui lòng chọn khóa học hoặc xóa bộ lọc.");
                return;
            }

            if (_selectedClassId <= 0 || dgvOpenClasses.CurrentRow == null)
            {
                dgvOpenClasses.Rows[0].Selected = true;
                SelectClassAtRow(0);
            }

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
