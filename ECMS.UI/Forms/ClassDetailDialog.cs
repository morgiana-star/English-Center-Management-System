using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ClassDetailDialog : Form
{
    private readonly IClassService _classService = new ClassService();
    private int _classId;
    private readonly string _classCode = string.Empty;
    private readonly string _courseName = string.Empty;
    private readonly string _teacher = string.Empty;
    private int _maxStudents = 20;

    public ClassDetailDialog() : this(0, "IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh", 20)
    {
    }

    public ClassDetailDialog(string classCode = "IELTS-F01", string courseName = "IELTS Foundation", string teacher = "")
        : this(0, classCode, courseName, teacher, 20)
    {
    }

    public ClassDetailDialog(int classId, string classCode, string courseName, string teacher, int maxStudents = 20)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _classId = classId;
        _classCode = classCode;
        _courseName = courseName;
        _teacher = teacher;
        _maxStudents = maxStudents > 0 ? maxStudents : 20;

        SetupHeaderAndInfo();
        WireEvents();
        _ = InitAndLoadStudentsTabAsync();
    }

    private void SetupHeaderAndInfo()
    {
        Text = $"Chi tiết lớp học - {_classCode}";
        lblTitle.Text = $"{_classCode} - {_courseName}";
    }

    private async Task InitAndLoadStudentsTabAsync()
    {
        if (_classId <= 0 && !string.IsNullOrWhiteSpace(_classCode))
        {
            var cls = await _classService.GetClassByCodeAsync(_classCode);
            if (cls != null)
            {
                _classId = cls.ClassId;
                _maxStudents = cls.MaxStudents > 0 ? cls.MaxStudents : _maxStudents;
            }
        }
        SwitchTab(btnTabStudents);
        await LoadStudentsTabAsync();
    }

    private void WireEvents()
    {
        btnAddStudent.Click += async (s, e) =>
        {
            if (_classId <= 0)
            {
                AppDialog.ShowWarning(this, "Thông báo", "Không xác định được mã lớp học trong cơ sở dữ liệu.");
                return;
            }

            using var dlg = new SelectStudentsForClassDialog(_classId, _classCode);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.SelectedStudentIds.Count > 0)
            {
                var res = await _classService.EnrollWaitingStudentsToClassAsync(_classId, dlg.SelectedStudentIds);
                if (res.Success)
                {
                    AppDialog.ShowSuccess(this, "Thành công", res.Message);
                    await LoadStudentsTabAsync();
                }
                else
                {
                    AppDialog.ShowWarning(this, "Không thể thêm học viên", res.Message);
                }
            }
        };

        btnEditClass.Click += (s, e) =>
        {
            using var editDlg = new CreateClassDialog(isEditMode: true, classCode: _classCode);
            editDlg.ShowDialog(this);
        };

        btnDeleteClass.Click += async (s, e) =>
        {
            if (_classId <= 0)
            {
                AppDialog.ShowWarning(this, "Thông báo", "Không xác định được mã lớp học cần xóa.");
                return;
            }

            if (AppDialog.ShowConfirm(this, "Xác nhận xóa lớp học",
                $"Bạn có chắc chắn muốn xóa lớp học '{_classCode}' không?\nLưu ý: Chỉ xóa được lớp chưa có học viên ghi danh, chưa có điểm danh và chưa có kỳ thi.",
                "Xóa lớp học", "Hủy") != DialogResult.OK)
                return;

            var res = await _classService.DeleteClassAsync(_classId);
            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AppDialog.ShowWarning(this, "Không thể xóa lớp học", res.Message);
            }
        };

        dgvClassStudents.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClassStudents.Columns[e.ColumnIndex].Name == "colAction")
            {
                await OpenStudentFromRowAsync(e.RowIndex);
            }
        };

        dgvClassStudents.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClassStudents.Columns.Contains("colCode"))
            {
                await OpenStudentFromRowAsync(e.RowIndex);
            }
        };

        btnTabStudents.Click += async (s, e) => { SwitchTab(btnTabStudents); await LoadStudentsTabAsync(); };
        btnTabSchedule.Click += async (s, e) => { SwitchTab(btnTabSchedule); await LoadScheduleTabAsync(); };
        btnTabAttendance.Click += async (s, e) => { SwitchTab(btnTabAttendance); await LoadAttendanceTabAsync(); };
        btnTabGrades.Click += async (s, e) => { SwitchTab(btnTabGrades); await LoadGradesTabAsync(); };
    }

    private async Task OpenStudentFromRowAsync(int rowIndex)
    {
        var row = dgvClassStudents.Rows[rowIndex];
        int studentId = row.Tag is int id ? id : 0;
        string studentCode = row.Cells["colCode"].Value?.ToString() ?? "";
        string fullName = row.Cells["colName"].Value?.ToString() ?? "";
        using var detailDlg = new StudentDetailDialog(studentId, fullName, studentCode);
        detailDlg.ShowDialog(this);
        await LoadStudentsTabAsync();
    }

    private void SwitchTab(Button activeBtn)
    {
        var tabs = new[] { btnTabStudents, btnTabSchedule, btnTabAttendance, btnTabGrades };
        foreach (var tab in tabs)
        {
            if (tab == activeBtn)
            {
                tab.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                tab.ForeColor = Color.FromArgb(24, 119, 242);
            }
            else
            {
                tab.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                tab.ForeColor = Color.FromArgb(108, 117, 125);
            }
        }
    }

    private async Task LoadStudentsTabAsync()
    {
        lblStudentListTitle.Text = "DANH SÁCH HỌC VIÊN TRONG LỚP";
        ResetGridBase();

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", MinimumWidth = 50, FillWeight = 6F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", MinimumWidth = 90, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 22F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Số điện thoại", MinimumWidth = 110, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", MinimumWidth = 100, FillWeight = 12F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAttendance", HeaderText = "Chuyên cần", MinimumWidth = 110, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTuition", HeaderText = "Học phí", MinimumWidth = 130, FillWeight = 15F });

        var actionCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "Xem hồ sơ",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            MinimumWidth = 95,
            FillWeight = 11F
        };
        actionCol.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvClassStudents.Columns.Add(actionCol);

        var items = (await _classService.GetClassStudentsAsync(_classId)).ToList();
        int stt = 1;
        foreach (var s in items)
        {
            int idx = dgvClassStudents.Rows.Add(stt++, s.StudentCode, s.FullName, s.Phone, s.StatusDisplay, s.AttendanceDisplay, s.TuitionDisplay);
            dgvClassStudents.Rows[idx].Tag = s.StudentId;
        }

        lblBottomSummary.Text = $"Sĩ số lớp: {items.Count} / {_maxStudents} học viên";
        RefreshGridDisplay();
    }

    private async Task LoadScheduleTabAsync()
    {
        lblStudentListTitle.Text = "LỊCH HỌC CỦA LỚP";
        ResetGridBase();

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSession", HeaderText = "Buổi", MinimumWidth = 70, FillWeight = 10F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Ngày học", MinimumWidth = 120, FillWeight = 20F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTime", HeaderText = "Giờ học", MinimumWidth = 130, FillWeight = 22F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Phòng học", MinimumWidth = 100, FillWeight = 18F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Giáo viên", MinimumWidth = 160, FillWeight = 30F });

        var items = (await _classService.GetClassSchedulesAsync(_classId)).ToList();
        foreach (var s in items)
        {
            dgvClassStudents.Rows.Add($"Buổi {s.SessionNumber}", s.DateDisplay, s.TimeRange, s.RoomName, s.TeacherName);
        }

        lblBottomSummary.Text = $"Tổng số buổi đã xếp lịch: {items.Count} buổi";
        RefreshGridDisplay();
    }

    private async Task LoadAttendanceTabAsync()
    {
        lblStudentListTitle.Text = "TỔNG HỢP ĐIỂM DANH LỚP HỌC";
        ResetGridBase();

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", MinimumWidth = 50, FillWeight = 7F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", MinimumWidth = 95, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 180, FillWeight = 28F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPresent", HeaderText = "Có mặt", MinimumWidth = 85, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLate", HeaderText = "Đi muộn", MinimumWidth = 85, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAbsent", HeaderText = "Vắng", MinimumWidth = 85, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Tổng buổi", MinimumWidth = 90, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRate", HeaderText = "Tỷ lệ chuyên cần", MinimumWidth = 120, FillWeight = 15F });

        var items = (await _classService.GetClassAttendanceSummaryAsync(_classId)).ToList();
        int stt = 1;
        foreach (var a in items)
        {
            int idx = dgvClassStudents.Rows.Add(stt++, a.StudentCode, a.FullName, a.PresentCount, a.LateCount, a.AbsentCount, a.TotalRecorded, a.RateDisplay);
            dgvClassStudents.Rows[idx].Tag = a.StudentId;
        }

        lblBottomSummary.Text = $"Tổng số học viên theo dõi điểm danh: {items.Count} học viên";
        RefreshGridDisplay();
    }

    private async Task LoadGradesTabAsync()
    {
        lblStudentListTitle.Text = "BẢNG ĐIỂM LỚP HỌC";
        ResetGridBase();

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", MinimumWidth = 50, FillWeight = 7F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", MinimumWidth = 95, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 180, FillWeight = 28F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colReg", HeaderText = "Thường xuyên", MinimumWidth = 100, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMid", HeaderText = "Giữa khóa", MinimumWidth = 100, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFinal", HeaderText = "Cuối khóa", MinimumWidth = 100, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAvg", HeaderText = "Trung bình", MinimumWidth = 100, FillWeight = 13F });

        var items = (await _classService.GetClassGradesAsync(_classId)).ToList();
        int stt = 1;
        foreach (var g in items)
        {
            int idx = dgvClassStudents.Rows.Add(stt++, g.StudentCode, g.FullName, g.RegularScore, g.MidtermScore, g.FinalScore, g.AverageScore);
            dgvClassStudents.Rows[idx].Tag = g.StudentId;
        }

        lblBottomSummary.Text = $"Tổng số học viên trong bảng điểm: {items.Count} học viên";
        RefreshGridDisplay();
    }

    private void ResetGridBase()
    {
        AppGridHelper.ApplyStyle(dgvClassStudents);
        dgvClassStudents.DataSource = null;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.ScrollBars = ScrollBars.Both;
    }

    private void RefreshGridDisplay()
    {
        dgvClassStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClassStudents.ClearSelection();
        dgvClassStudents.CurrentCell = null;
    }
}
