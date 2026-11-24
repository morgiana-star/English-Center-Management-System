using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ScheduleManagementView : UserControl
{
    private readonly IScheduleService _scheduleService = new ScheduleService();
    private AppButton _btnManageSchedules = null!;
    private bool _isUpdatingFilters = false;

    private record SemesterOption(string Display, DateTime StartDate, DateTime EndDate);
    private record WeekOption(int WeekNumber, DateTime Monday, DateTime Sunday)
    {
        public string Display => $"Tuần {WeekNumber:D2} [{Monday:dd/MM/yyyy} - {Sunday:dd/MM/yyyy}]";
    }

    private readonly List<SemesterOption> _semesters = new()
    {
        new("Học kỳ 1 - Năm học 2025 - 2026", new DateTime(2025, 9, 1), new DateTime(2025, 12, 31)),
        new("Học kỳ 2 - Năm học 2025 - 2026", new DateTime(2026, 1, 5), new DateTime(2026, 4, 30)),
        new("Học kỳ 3 - Năm học 2025 - 2026", new DateTime(2026, 5, 4), new DateTime(2026, 8, 31)),
        new("Học kỳ 1 - Năm học 2026 - 2027", new DateTime(2026, 9, 7), new DateTime(2026, 12, 31)),
        new("Học kỳ 2 - Năm học 2026 - 2027", new DateTime(2027, 1, 4), new DateTime(2027, 4, 30)),
        new("Học kỳ 3 - Năm học 2026 - 2027", new DateTime(2027, 5, 3), new DateTime(2027, 8, 31))
    };

    private List<WeekOption> _currentWeeks = new();

    private class ScheduleCellData
    {
        public WeeklyScheduleSlotDto Primary { get; set; } = null!;
        public List<WeeklyScheduleSlotDto> AllInSlot { get; set; } = new();
        public Color BgColor { get; set; }
        public Color BorderColor { get; set; }
        public Color TextColor { get; set; }
    }

    public ScheduleManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupManageSchedulesButton();
        SetupFilters();
        SetupMatrixGrid();
        WireEvents();
        _ = RefreshScheduleAsync();
    }

    private void SetupManageSchedulesButton()
    {
        btnCreateSession.Text = "Tạo buổi học";
        btnManageRooms.Text = "Quản lý phòng";

        // Đặt nút "Quản lý lịch học" ở giữa "Quản lý phòng" và "Tạo buổi học"
        _btnManageSchedules = new AppButton
        {
            Name = "btnManageSchedules",
            Text = "Quản lý lịch học",
            Size = new Size(145, 36),
            Location = new Point(btnCreateSession.Left - 155, btnCreateSession.Top),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 5,
            Cursor = Cursors.Hand
        };
        btnManageRooms.Location = new Point(_btnManageSchedules.Left - btnManageRooms.Width - 10, btnManageRooms.Top);
        pnlHeader.Controls.Add(_btnManageSchedules);
    }

    private void SetupFilters()
    {
        _isUpdatingFilters = true;
        try
        {
            cboSemester.Items.Clear();
            foreach (var sem in _semesters)
            {
                cboSemester.Items.Add(sem.Display);
            }

            int defaultSemIdx = _semesters.FindIndex(s => DateTime.Today >= s.StartDate && DateTime.Today <= s.EndDate);
            cboSemester.SelectedIndex = defaultSemIdx >= 0 ? defaultSemIdx : 3;

            cboScheduleType.Items.Clear();
            cboScheduleType.Items.AddRange(new object[]
            {
                "Thời khóa biểu tất cả",
                "Thời khóa biểu theo lớp",
                "Thời khóa biểu theo khóa học",
                "Thời khóa biểu theo giảng viên"
            });
            cboScheduleType.SelectedIndex = 0;

            cboTargetFilter.Items.Clear();
            cboTargetFilter.Items.Add("-- Xem tất cả thời khóa biểu --");
            cboTargetFilter.SelectedIndex = 0;
            cboTargetFilter.Enabled = false;

            PopulateWeeksForSelectedSemester();
        }
        finally
        {
            _isUpdatingFilters = false;
        }
    }

    private void PopulateWeeksForSelectedSemester()
    {
        int semIdx = Math.Clamp(cboSemester.SelectedIndex, 0, _semesters.Count - 1);
        var sem = _semesters[semIdx];

        // Tìm thứ 2 đầu tiên <= StartDate
        DateTime monday = sem.StartDate.Date;
        while (monday.DayOfWeek != DayOfWeek.Monday)
        {
            monday = monday.AddDays(-1);
        }

        _currentWeeks.Clear();
        int weekNo = 1;
        while (monday <= sem.EndDate)
        {
            _currentWeeks.Add(new WeekOption(weekNo++, monday, monday.AddDays(6)));
            monday = monday.AddDays(7);
        }

        cboWeek.Items.Clear();
        foreach (var w in _currentWeeks)
        {
            cboWeek.Items.Add(w.Display);
        }

        int todayWeekIdx = _currentWeeks.FindIndex(w => DateTime.Today >= w.Monday && DateTime.Today <= w.Sunday);
        if (cboWeek.Items.Count > 0)
        {
            cboWeek.SelectedIndex = todayWeekIdx >= 0 ? todayWeekIdx : 0;
        }
    }

    private async Task UpdateTargetFilterAsync()
    {
        _isUpdatingFilters = true;
        try
        {
            cboTargetFilter.Items.Clear();
            string filterType = cboScheduleType.SelectedIndex switch
            {
                1 => "Class",
                2 => "Course",
                3 => "Teacher",
                _ => "All"
            };

            if (filterType == "All")
            {
                cboTargetFilter.Items.Add("-- Xem tất cả thời khóa biểu --");
                cboTargetFilter.SelectedIndex = 0;
                cboTargetFilter.Enabled = false;
                return;
            }

            var targets = await _scheduleService.GetFilterTargetsAsync(filterType);
            foreach (var t in targets)
            {
                cboTargetFilter.Items.Add(t);
            }
            cboTargetFilter.Enabled = targets.Count > 0;
            if (cboTargetFilter.Items.Count > 0) cboTargetFilter.SelectedIndex = 0;
        }
        finally
        {
            _isUpdatingFilters = false;
        }
    }

    private void SetupMatrixGrid()
    {
        dgvScheduleMatrix.AutoGenerateColumns = false;
        dgvScheduleMatrix.Columns.Clear();
        dgvScheduleMatrix.ReadOnly = true;
        dgvScheduleMatrix.RowHeadersVisible = false;
        dgvScheduleMatrix.AllowUserToAddRows = false;
        dgvScheduleMatrix.AllowUserToResizeRows = false;
        dgvScheduleMatrix.AllowUserToResizeColumns = false;
        dgvScheduleMatrix.SelectionMode = DataGridViewSelectionMode.CellSelect;
        dgvScheduleMatrix.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colShift",
            HeaderText = "Ca học / Giờ",
            Width = 140,
            MinimumWidth = 120,
            FillWeight = 11F,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(248, 250, 252),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            }
        });

        for (int i = 0; i < 7; i++)
        {
            dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = $"colDay{i}",
                HeaderText = $"Ngày {i + 1}",
                MinimumWidth = 125,
                FillWeight = 12.7F
            });
        }

        dgvScheduleMatrix.CellPainting += DgvScheduleMatrix_CellPainting;
    }

    private async Task RefreshScheduleAsync()
    {
        if (_currentWeeks.Count == 0 || cboWeek.SelectedIndex < 0) return;
        var week = _currentWeeks[cboWeek.SelectedIndex];
        UpdateWeekHeaderDates(week.Monday);

        string filterType = cboScheduleType.SelectedIndex switch
        {
            1 => "Class",
            2 => "Course",
            3 => "Teacher",
            _ => "All"
        };
        string? filterVal = filterType == "All" ? null : cboTargetFilter.SelectedItem?.ToString();

        try
        {
            var slots = (await _scheduleService.GetSchedulesInRangeAsync(week.Monday, week.Sunday, filterType, filterVal)).ToList();

            dgvScheduleMatrix.Rows.Clear();
            int rMorning = dgvScheduleMatrix.Rows.Add("Ca Sáng\n08:00 - 12:00", "", "", "", "", "", "", "");
            int rAfternoon = dgvScheduleMatrix.Rows.Add("Ca Chiều\n13:30 - 17:30", "", "", "", "", "", "", "");
            int rEvening = dgvScheduleMatrix.Rows.Add("Ca Tối\n18:00 - 21:00", "", "", "", "", "", "", "");

            var grouped = slots
                .Where(s => DateTime.TryParse(s.Date, out _))
                .GroupBy(s =>
                {
                    DateTime dt = DateTime.Parse(s.Date);
                    int colIdx = dt.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)dt.DayOfWeek;
                    int hour = TimeSpan.TryParse(s.StartTime, out var ts) ? ts.Hours : 18;
                    int rowIdx = hour < 12 ? rMorning : (hour < 17 ? rAfternoon : rEvening);
                    return (rowIdx, colIdx);
                });

            foreach (var g in grouped)
            {
                var allInSlot = g.ToList();
                var primary = allInSlot[0]; // Hiển thị lớp đầu tiên theo yêu cầu

                var (bg, border, text) = g.Key.rowIdx switch
                {
                    0 => (Color.FromArgb(240, 253, 244), Color.FromArgb(34, 197, 94), Color.FromArgb(21, 128, 61)),
                    1 => (Color.FromArgb(255, 247, 237), Color.FromArgb(249, 115, 22), Color.FromArgb(194, 65, 12)),
                    _ => (Color.FromArgb(239, 246, 255), Color.FromArgb(59, 130, 246), Color.FromArgb(29, 78, 216))
                };

                dgvScheduleMatrix.Rows[g.Key.rowIdx].Cells[g.Key.colIdx].Tag = new ScheduleCellData
                {
                    Primary = primary,
                    AllInSlot = allInSlot,
                    BgColor = bg,
                    BorderColor = border,
                    TextColor = text
                };
            }

            AdjustRowHeights();
            dgvScheduleMatrix.ClearSelection();
            dgvScheduleMatrix.Invalidate();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp thời khóa biểu", ex.Message);
        }
    }

    private void DgvScheduleMatrix_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 1) return;

        e.PaintBackground(e.ClipBounds, false);
        e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
        var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
        if (cell.Tag is ScheduleCellData data)
        {
            var g = e.Graphics!;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + 4, e.CellBounds.Width - 9, e.CellBounds.Height - 9);
            using var bgBrush = new SolidBrush(data.BgColor);
            using var borderPen = new Pen(data.BorderColor, 1f);

            g.FillRectangle(bgBrush, rect);
            g.DrawRectangle(borderPen, rect);

            int textX = rect.X + 8;
            int textW = Math.Max(40, rect.Width - 12);
            using var fBold = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            using var fNorm = new Font("Segoe UI", 8F);
            using var tBrush = new SolidBrush(data.TextColor);
            using var sBrush = new SolidBrush(Color.FromArgb(51, 65, 85));

            var p = data.Primary;
            string extra = data.AllInSlot.Count > 1 ? $" (+{data.AllInSlot.Count - 1})" : "";
            g.DrawString($"{p.ClassCode}{extra}", fBold, tBrush, new RectangleF(textX, rect.Y + 6, textW, 20));
            g.DrawString(p.CourseName, fNorm, sBrush, new RectangleF(textX, rect.Y + 25, textW, 17));
            g.DrawString($"Phòng: {p.RoomName}", fNorm, sBrush, new RectangleF(textX, rect.Y + 42, textW, 17));
            g.DrawString($"GV: {p.TeacherName}", fNorm, sBrush, new RectangleF(textX, rect.Y + 59, textW, 17));
            g.DrawString($"{p.StartTime} - {p.EndTime}", fNorm, tBrush, new RectangleF(textX, rect.Y + 76, textW, 17));
        }

        e.Handled = true;
    }

    private void WireEvents()
    {
        cboSemester.SelectedIndexChanged += async (s, e) =>
        {
            if (_isUpdatingFilters) return;
            _isUpdatingFilters = true;
            PopulateWeeksForSelectedSemester();
            _isUpdatingFilters = false;
            await RefreshScheduleAsync();
        };

        cboScheduleType.SelectedIndexChanged += async (s, e) =>
        {
            if (_isUpdatingFilters) return;
            await UpdateTargetFilterAsync();
            await RefreshScheduleAsync();
        };

        cboTargetFilter.SelectedIndexChanged += async (s, e) =>
        {
            if (!_isUpdatingFilters) await RefreshScheduleAsync();
        };

        cboWeek.SelectedIndexChanged += async (s, e) =>
        {
            if (!_isUpdatingFilters) await RefreshScheduleAsync();
        };

        btnPrevWeek.Click += (s, e) =>
        {
            if (cboWeek.SelectedIndex > 0) cboWeek.SelectedIndex--;
        };

        btnNextWeek.Click += (s, e) =>
        {
            if (cboWeek.SelectedIndex < cboWeek.Items.Count - 1) cboWeek.SelectedIndex++;
        };

        btnPrint.Click += (s, e) =>
        {
            AppDialog.ShowInfo(ParentForm, "In thời khóa biểu",
                $"Đã chuẩn bị bản in thời khóa biểu cho:\n{cboSemester.SelectedItem}\n{cboWeek.SelectedItem}");
        };

        btnManageRooms.Click += (s, e) =>
        {
            using var dlg = new RoomManagementDialog();
            dlg.ShowDialog(FindForm());
        };

        _btnManageSchedules.Click += async (s, e) =>
        {
            using var dlg = new ManageSchedulesDialog();
            dlg.ShowDialog(FindForm());
            if (dlg.HasChanged)
            {
                await RefreshScheduleAsync();
            }
        };

        btnCreateSession.Click += async (s, e) =>
        {
            using var dlg = new CreateScheduleDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                _isUpdatingFilters = true;
                cboScheduleType.SelectedIndex = 0;
                _isUpdatingFilters = false;
                await UpdateTargetFilterAsync();
                JumpToDateOnCalendar(dlg.CreatedStartDate);
                await RefreshScheduleAsync();
            }
        };

        dgvScheduleMatrix.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Tag is ScheduleCellData data)
                {
                    var lines = data.AllInSlot.Select((item, i) =>
                        $"{i + 1}. Lớp {item.ClassCode} ({item.CourseName})\n" +
                        $"   Phòng: {item.RoomName}  |  GV: {item.TeacherName}  |  Giờ: {item.StartTime} - {item.EndTime}");
                    AppDialog.ShowInfo(ParentForm, "Chi tiết lịch học trong ca", string.Join("\n\n", lines));
                }
            }
        };
    }

    private void JumpToDateOnCalendar(DateTime targetDate)
    {
        _isUpdatingFilters = true;
        try
        {
            int semIdx = _semesters.FindIndex(s => targetDate.Date >= s.StartDate && targetDate.Date <= s.EndDate);
            if (semIdx >= 0 && cboSemester.SelectedIndex != semIdx)
            {
                cboSemester.SelectedIndex = semIdx;
                PopulateWeeksForSelectedSemester();
            }

            int weekIdx = _currentWeeks.FindIndex(w => targetDate.Date >= w.Monday && targetDate.Date <= w.Sunday);
            if (weekIdx >= 0)
            {
                cboWeek.SelectedIndex = weekIdx;
            }
        }
        finally
        {
            _isUpdatingFilters = false;
        }
    }

    private void UpdateWeekHeaderDates(DateTime startOfWeek)
    {
        string[] dayNames = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
        for (int i = 0; i < 7; i++)
        {
            DateTime currentDay = startOfWeek.AddDays(i);
            dgvScheduleMatrix.Columns[i + 1].HeaderText = $"{dayNames[i]} ({currentDay:dd/MM})";
        }
    }

    private void AdjustCalendarLayout()
    {
        if (pnlBody == null || cardCalendar == null || dgvScheduleMatrix == null || pnlFilterBar == null) return;

        int margin = 24;
        int filterBarHeight = 90;
        pnlFilterBar.SetBounds(margin, 16, Math.Max(500, pnlBody.ClientSize.Width - (margin * 2)), filterBarHeight);

        int cardTop = 16 + filterBarHeight + 12;
        int cardWidth = Math.Max(500, pnlBody.ClientSize.Width - (margin * 2));
        int cardHeight = Math.Max(250, pnlBody.ClientSize.Height - cardTop - margin);
        cardCalendar.SetBounds(margin, cardTop, cardWidth, cardHeight);

        dgvScheduleMatrix.SetBounds(12, 12, cardCalendar.ClientSize.Width - 24, cardCalendar.ClientSize.Height - 24);
        AdjustRowHeights();
    }

    private void AdjustRowHeights()
    {
        if (dgvScheduleMatrix.RowCount == 3)
        {
            int availableHeight = dgvScheduleMatrix.ClientSize.Height - dgvScheduleMatrix.ColumnHeadersHeight - 4;
            int rowHeight = Math.Max(110, availableHeight / 3);
            for (int i = 0; i < 3; i++)
            {
                dgvScheduleMatrix.Rows[i].Height = rowHeight;
            }
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustCalendarLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustCalendarLayout();
    }
}
