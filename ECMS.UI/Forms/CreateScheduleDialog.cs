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

public partial class CreateScheduleDialog : Form
{
    private readonly IScheduleService _scheduleService = new ScheduleService();
    private List<ClassForScheduleCreateDto> _classes = new();

    private Panel _pnlConfig = null!;
    private DateTimePicker _dtpStartDate = null!;
    private ComboBox _cboTimeSlot = null!;
    private CheckBox[] _chkDays = null!;

    public string SelectedClassCode { get; private set; } = string.Empty;
    public string SelectedCourseName { get; private set; } = string.Empty;
    public DateTime CreatedStartDate { get; private set; } = DateTime.Today;

    public CreateScheduleDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupConfigPanel();
        SetupGrid();
        WireEvents();
        _ = LoadClassesDataAsync();
    }

    private void SetupConfigPanel()
    {
        _pnlConfig = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 92,
            BackColor = Color.FromArgb(248, 250, 252),
            Padding = new Padding(16, 8, 16, 8)
        };

        var lblStart = new Label
        {
            Text = "Ngày bắt đầu:",
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Location = new Point(16, 14)
        };
        _dtpStartDate = new DateTimePicker
        {
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "dd/MM/yyyy",
            Font = new Font("Segoe UI", 9.5F),
            Location = new Point(115, 10),
            Size = new Size(135, 29),
            Value = DateTime.Today
        };

        var lblTime = new Label
        {
            Text = "Khung giờ:",
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Location = new Point(270, 14)
        };
        _cboTimeSlot = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5F),
            Location = new Point(352, 10),
            Size = new Size(210, 29)
        };
        _cboTimeSlot.Items.AddRange(new object[]
        {
            "08:00 - 10:00",
            "09:30 - 11:30",
            "13:30 - 15:30",
            "15:30 - 17:30",
            "18:00 - 20:00",
            "19:00 - 21:00"
        });
        _cboTimeSlot.SelectedIndex = 4;

        var lblDays = new Label
        {
            Text = "Các thứ dạy:",
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Location = new Point(16, 54)
        };

        string[] dayLabels = { "T2", "T3", "T4", "T5", "T6", "T7", "CN" };
        DayOfWeek[] dayValues =
        {
            DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
            DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday
        };
        _chkDays = new CheckBox[7];
        for (int i = 0; i < 7; i++)
        {
            _chkDays[i] = new CheckBox
            {
                Text = dayLabels[i],
                Tag = dayValues[i],
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                Location = new Point(115 + i * 70, 52),
                Checked = (i == 0 || i == 2 || i == 4) // T2, T4, T6 mặc định
            };
            _pnlConfig.Controls.Add(_chkDays[i]);
        }

        _pnlConfig.Controls.AddRange(new Control[] { lblStart, _dtpStartDate, lblTime, _cboTimeSlot, lblDays });

        if (dgvClasses.Parent != null)
        {
            dgvClasses.Parent.Controls.Add(_pnlConfig);
            _pnlConfig.BringToFront();
            dgvClasses.BringToFront();
        }
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvClasses);
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.ScrollBars = ScrollBars.Both;

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", MinimumWidth = 45, FillWeight = 6F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã lớp", MinimumWidth = 95, FillWeight = 13F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Giáo viên phụ trách", MinimumWidth = 140, FillWeight = 20F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSchedule", HeaderText = "Lịch dạy", MinimumWidth = 160, FillWeight = 23F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Phòng", MinimumWidth = 75, FillWeight = 9F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartDate", HeaderText = "Ngày bắt đầu", MinimumWidth = 95, FillWeight = 11F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSessions", HeaderText = "Số buổi", MinimumWidth = 75, FillWeight = 9F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", MinimumWidth = 95, FillWeight = 11F });
    }

    private async Task LoadClassesDataAsync()
    {
        try
        {
            _classes = (await _scheduleService.GetClassesForScheduleCreationAsync()).ToList();
            RenderRows(_classes);
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi nạp danh sách lớp học", ex.Message);
        }
    }

    private void RenderRows(List<ClassForScheduleCreateDto> list)
    {
        dgvClasses.Rows.Clear();
        int stt = 1;
        foreach (var c in list)
        {
            string startDisp = DateTime.TryParse(c.StartDate, out var dt) ? dt.ToString("dd/MM/yyyy") : c.StartDate;
            int idx = dgvClasses.Rows.Add(
                stt++,
                c.ClassCode,
                c.TeacherName,
                c.ScheduleDisplay,
                c.RoomName,
                startDisp,
                $"{c.TotalSessions} buổi",
                c.StatusDisplay);
            dgvClasses.Rows[idx].Tag = c;
        }

        if (dgvClasses.RowCount > 0)
        {
            dgvClasses.Rows[0].Selected = true;
            SyncConfigFromSelectedRow();
        }
    }

    private void SyncConfigFromSelectedRow()
    {
        if (dgvClasses.SelectedRows.Count == 0) return;
        if (dgvClasses.SelectedRows[0].Tag is ClassForScheduleCreateDto c)
        {
            if (DateTime.TryParse(c.StartDate, out var dt))
            {
                _dtpStartDate.Value = dt;
            }
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnCreateSessions.Click += async (s, e) => await ConfirmCreateAsync();

        dgvClasses.SelectionChanged += (s, e) => SyncConfigFromSelectedRow();

        txtSearch.TextChanged += (s, e) =>
        {
            string kw = txtSearch.Text.Trim().ToLowerInvariant();
            var filtered = _classes.Where(c =>
                string.IsNullOrEmpty(kw) ||
                c.ClassCode.ToLowerInvariant().Contains(kw) ||
                c.TeacherName.ToLowerInvariant().Contains(kw) ||
                c.RoomName.ToLowerInvariant().Contains(kw) ||
                c.ScheduleDisplay.ToLowerInvariant().Contains(kw)).ToList();
            RenderRows(filtered);
        };
    }

    private async Task ConfirmCreateAsync()
    {
        if (dgvClasses.SelectedRows.Count == 0 || dgvClasses.SelectedRows[0].Tag is not ClassForScheduleCreateDto cls)
        {
            AppDialog.ShowWarning(this, "Chưa chọn lớp", "Vui lòng chọn một lớp học để tạo lịch.");
            return;
        }

        var selectedDays = _chkDays
            .Where(chk => chk.Checked && chk.Tag is DayOfWeek)
            .Select(chk => (DayOfWeek)chk.Tag!)
            .ToList();

        if (selectedDays.Count == 0)
        {
            AppDialog.ShowWarning(this, "Thiếu thứ dạy", "Vui lòng chọn ít nhất 1 thứ giảng dạy trong tuần.");
            return;
        }

        string slotText = _cboTimeSlot.SelectedItem?.ToString() ?? "18:00 - 20:00";
        var parts = slotText.Split('-');
        string startTime = parts[0].Trim();
        string endTime = parts.Length > 1 ? parts[1].Trim() : "20:00";

        var req = new GenerateClassScheduleRequestDto
        {
            ClassId = cls.ClassId,
            StartDate = _dtpStartDate.Value.Date,
            DaysOfWeek = selectedDays,
            StartTime = startTime,
            EndTime = endTime,
            RoomId = cls.RoomId,
            TeacherId = cls.TeacherId,
            TotalSessions = cls.TotalSessions > 0 ? cls.TotalSessions : 24
        };

        var res = await _scheduleService.GenerateClassSchedulesAsync(req);
        if (!res.Success)
        {
            AppDialog.ShowWarning(this, "Xung đột / Lỗi tạo lịch học", res.Message);
            return;
        }

        SelectedClassCode = cls.ClassCode;
        SelectedCourseName = cls.CourseName;
        CreatedStartDate = req.StartDate;
        AppDialog.ShowSuccess(this, "Tạo buổi học thành công", res.Message);
        DialogResult = DialogResult.OK;
        Close();
    }
}
