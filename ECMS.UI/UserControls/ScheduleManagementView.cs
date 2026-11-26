using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ScheduleManagementView : UserControl
{
    private class ScheduleItem
    {
        public int ScheduleId { get; set; }
        public int SessionNumber { get; set; }
        public string Topic { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string ClassCode { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
        public string Teacher { get; set; } = string.Empty;
        public string TimeText { get; set; } = string.Empty;
        public bool IsAttendanceLocked { get; set; }
        public Color BgColor { get; set; }
        public Color BorderColor { get; set; }
        public Color TextColor { get; set; }
    }

    private readonly List<(DateTime Start, DateTime End)> _weeks = new();
    private bool _isInitializing = true;

    public ScheduleManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupMatrixGrid();
        _ = InitializeViewAsync();
        WireEvents();
    }

    private async Task InitializeViewAsync()
    {
        try
        {
            _isInitializing = true;
            await UpdateTargetFilterAsync();
            UpdateWeekHeaderDates();
            await LoadScheduleDataAsync();
        }
        finally
        {
            _isInitializing = false;
        }
    }

    private void SetupFilters()
    {
        // 1. Học kỳ & Năm học (3 học kỳ / năm)
        cboSemester.Items.Clear();
        cboSemester.Items.AddRange(new object[]
        {
            "Học kỳ 1 (01/2026 – 04/2026) · Năm học 2026 - 2027",
            "Học kỳ 2 (05/2026 – 08/2026) · Năm học 2026 - 2027",
            "Học kỳ 3 (09/2026 – 12/2026) · Năm học 2026 - 2027"
        });
        cboSemester.SelectedIndex = 2; // Kỳ 3 hiện tại

        // 2. Đối tượng xem thời khóa biểu
        cboScheduleType.Items.Clear();
        cboScheduleType.Items.AddRange(new object[]
        {
            "Thời khóa biểu tất cả",
            "Thời khóa biểu theo lớp",
            "Thời khóa biểu theo khóa học",
            "Thời khóa biểu theo giảng viên",
            "Thời khóa biểu theo phòng học"
        });

        cboTargetFilter.DropDownStyle = ComboBoxStyle.DropDown;
        cboTargetFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cboTargetFilter.AutoCompleteSource = AutoCompleteSource.ListItems;

        bool isTeacherRole = string.Equals(AppSession.RoleCode, "ROLE_TEA", StringComparison.OrdinalIgnoreCase)
            || (AppSession.RoleName?.Contains("Giáo viên", StringComparison.OrdinalIgnoreCase) ?? false);

        if (isTeacherRole)
        {
            btnManageRooms.Visible = false;
            btnCreateSession.Visible = false;
            cboScheduleType.SelectedIndex = 3; // Mặc định: Thời khóa biểu theo giảng viên
        }
        else
        {
            cboScheduleType.SelectedIndex = 0;
        }

        // 3. Khởi tạo danh sách các tuần cho học kỳ được chọn
        RebuildWeeksForCurrentSemester();
    }

    private void RebuildWeeksForCurrentSemester()
    {
        _weeks.Clear();
        cboWeek.Items.Clear();

        // Xác định thứ 2 đầu tiên của học kỳ
        DateTime firstMonday;
        int semesterIndex = cboSemester.SelectedIndex;
        if (semesterIndex == 0) // Kỳ 1: Tháng 1 đến 4
            firstMonday = new DateTime(2026, 1, 5);
        else if (semesterIndex == 1) // Kỳ 2: Tháng 5 đến 8
            firstMonday = new DateTime(2026, 5, 4);
        else // Kỳ 3: Tháng 9 đến 12
            firstMonday = new DateTime(2026, 9, 7);

        int currentWeekIdx = -1;
        DateTime today = DateTime.Today;

        for (int w = 1; w <= 16; w++)
        {
            DateTime start = firstMonday.AddDays((w - 1) * 7);
            DateTime end = start.AddDays(6);
            _weeks.Add((start, end));
            cboWeek.Items.Add($"Tuần {w:D2} [từ ngày {start:dd/MM/yyyy} đến ngày {end:dd/MM/yyyy}]");
            if (today >= start.Date && today <= end.Date)
            {
                currentWeekIdx = w - 1;
            }
        }

        if (currentWeekIdx >= 0)
        {
            cboWeek.SelectedIndex = currentWeekIdx;
        }
        else if (cboWeek.Items.Count > 9)
        {
            cboWeek.SelectedIndex = 9;
        }
        else if (cboWeek.Items.Count > 0)
        {
            cboWeek.SelectedIndex = 0;
        }
    }

    private async Task UpdateTargetFilterAsync()
    {
        cboTargetFilter.Items.Clear();
        int typeIdx = cboScheduleType.SelectedIndex;

        if (typeIdx == 0) // Tất cả
        {
            cboTargetFilter.Items.Add("-- Xem tất cả thời khóa biểu --");
            cboTargetFilter.SelectedIndex = 0;
            cboTargetFilter.Enabled = false;
            return;
        }

        try
        {
            using var conn = DatabaseConfig.GetConnection();
            List<string> items = new();

            switch (typeIdx)
            {
                case 1: // Theo lớp
                    items = (await conn.QueryAsync<string>(
                        "SELECT ClassCode FROM Classes ORDER BY ClassCode ASC;")).ToList();
                    break;
                case 2: // Theo khóa học
                    items = (await conn.QueryAsync<string>(
                        "SELECT CourseName FROM Courses WHERE IsActive = 1 ORDER BY CourseName ASC;")).ToList();
                    break;
                case 3: // Theo giảng viên
                    items = (await conn.QueryAsync<string>(
                        "SELECT FullName FROM Teachers ORDER BY FullName ASC;")).ToList();
                    break;
                case 4: // Theo phòng học
                    items = (await conn.QueryAsync<string>(
                        "SELECT RoomCode FROM ClassRooms WHERE RoomCode IS NOT NULL ORDER BY RoomCode ASC;")).ToList();
                    break;
            }

            if (items.Count == 0)
            {
                cboTargetFilter.Items.Add("-- Chưa có dữ liệu --");
                cboTargetFilter.SelectedIndex = 0;
                cboTargetFilter.Enabled = false;
            }
            else
            {
                foreach (var it in items)
                {
                    cboTargetFilter.Items.Add(it);
                }

                int defaultIdx = 0;
                if (typeIdx == 3 && !string.IsNullOrWhiteSpace(AppSession.FullName))
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].Contains(AppSession.FullName, StringComparison.OrdinalIgnoreCase) ||
                            AppSession.FullName.Contains(items[i], StringComparison.OrdinalIgnoreCase))
                        {
                            defaultIdx = i;
                            break;
                        }
                    }
                }

                cboTargetFilter.SelectedIndex = defaultIdx;
                cboTargetFilter.Enabled = true;
            }
        }
        catch
        {
            cboTargetFilter.Items.Add("-- Lỗi tải dữ liệu --");
            cboTargetFilter.SelectedIndex = 0;
            cboTargetFilter.Enabled = false;
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

        // Cột Ca học
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

        // 7 ngày trong tuần
        string[] days = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
        for (int i = 0; i < days.Length; i++)
        {
            dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = $"colDay{i}",
                HeaderText = days[i],
                MinimumWidth = 125,
                FillWeight = 12.7F
            });
        }

        dgvScheduleMatrix.CellPainting += DgvScheduleMatrix_CellPainting;

        // Khởi tạo sẵn 3 hàng ca học
        dgvScheduleMatrix.Rows.Clear();
        dgvScheduleMatrix.Rows.Add("Ca Sáng\n08:00 – 12:00", "", "", "", "", "", "", "");
        dgvScheduleMatrix.Rows.Add("Ca Chiều\n13:30 – 17:30", "", "", "", "", "", "", "");
        dgvScheduleMatrix.Rows.Add("Ca Tối\n18:00 – 21:00", "", "", "", "", "", "", "");
    }

    private async Task LoadScheduleDataAsync()
    {
        if (cboWeek.SelectedIndex < 0 || cboWeek.SelectedIndex >= _weeks.Count)
            return;

        // Đảm bảo có đủ 3 hàng
        if (dgvScheduleMatrix.RowCount < 3)
        {
            dgvScheduleMatrix.Rows.Clear();
            dgvScheduleMatrix.Rows.Add("Ca Sáng\n08:00 – 12:00", "", "", "", "", "", "", "");
            dgvScheduleMatrix.Rows.Add("Ca Chiều\n13:30 – 17:30", "", "", "", "", "", "", "");
            dgvScheduleMatrix.Rows.Add("Ca Tối\n18:00 – 21:00", "", "", "", "", "", "", "");
        }

        // Xóa trắng dữ liệu các ô
        for (int r = 0; r < 3; r++)
        {
            for (int c = 1; c <= 7; c++)
            {
                dgvScheduleMatrix.Rows[r].Cells[c].Value = "";
                dgvScheduleMatrix.Rows[r].Cells[c].Tag = null;
            }
        }

        var week = _weeks[cboWeek.SelectedIndex];
        string startStr = week.Start.ToString("yyyy-MM-dd");
        string endStr = week.End.ToString("yyyy-MM-dd");

        try
        {
            using var conn = DatabaseConfig.GetConnection();

            int typeIdx = cboScheduleType.SelectedIndex;
            string selectedTarget = (cboTargetFilter.SelectedItem?.ToString() ?? cboTargetFilter.Text ?? "").Trim();

            string sql = @"
                SELECT 
                    cs.ScheduleId,
                    cs.ClassId,
                    c.ClassCode,
                    co.CourseName,
                    cs.SessionNumber,
                    cs.Date,
                    cs.StartTime,
                    cs.EndTime,
                    COALESCE(cs.Topic, 'Chưa có chủ đề') AS Topic,
                    COALESCE(cr.RoomCode, 'P' || cr.RoomId) AS RoomCode,
                    COALESCE(t.FullName, 'Chưa xếp GV') AS TeacherName,
                    cs.IsAttendanceLocked
                FROM ClassSchedules cs
                JOIN Classes c ON cs.ClassId = c.ClassId
                JOIN Courses co ON c.CourseId = co.CourseId
                LEFT JOIN ClassRooms cr ON cs.RoomId = cr.RoomId
                LEFT JOIN Teachers t ON cs.TeacherId = t.TeacherId
                WHERE cs.Date >= @StartStr AND cs.Date <= @EndStr";

            if (typeIdx == 1 && !string.IsNullOrEmpty(selectedTarget) && !selectedTarget.StartsWith("--"))
            {
                sql += " AND c.ClassCode LIKE '%' || @Target || '%'";
            }
            else if (typeIdx == 2 && !string.IsNullOrEmpty(selectedTarget) && !selectedTarget.StartsWith("--"))
            {
                sql += " AND co.CourseName LIKE '%' || @Target || '%'";
            }
            else if (typeIdx == 3 && !string.IsNullOrEmpty(selectedTarget) && !selectedTarget.StartsWith("--"))
            {
                sql += " AND t.FullName LIKE '%' || @Target || '%'";
            }
            else if (typeIdx == 4 && !string.IsNullOrEmpty(selectedTarget) && !selectedTarget.StartsWith("--"))
            {
                sql += " AND cr.RoomCode LIKE '%' || @Target || '%'";
            }

            sql += " ORDER BY cs.Date ASC, cs.StartTime ASC;";

            var sessions = (await conn.QueryAsync<dynamic>(sql, new
            {
                StartStr = startStr,
                EndStr = endStr,
                Target = selectedTarget
            })).ToList();

            foreach (var s in sessions)
            {
                string dateStr = ((string)s.Date).Split('T')[0];
                if (!DateTime.TryParse(dateStr, out DateTime sessionDate))
                    continue;

                // Xác định cột tương ứng thứ trong tuần (Col 1 = T2 ... Col 7 = CN)
                int colIndex = sessionDate.DayOfWeek switch
                {
                    DayOfWeek.Monday => 1,
                    DayOfWeek.Tuesday => 2,
                    DayOfWeek.Wednesday => 3,
                    DayOfWeek.Thursday => 4,
                    DayOfWeek.Friday => 5,
                    DayOfWeek.Saturday => 6,
                    DayOfWeek.Sunday => 7,
                    _ => 1
                };

                // Xác định hàng tương ứng ca học theo StartTime
                string startTime = (string)s.StartTime;
                string endTime = (string)s.EndTime;

                int rowIndex;
                if (string.Compare(startTime, "12:00", StringComparison.Ordinal) < 0)
                    rowIndex = 0; // Ca Sáng (08:00 - 12:00)
                else if (string.Compare(startTime, "17:30", StringComparison.Ordinal) < 0)
                    rowIndex = 1; // Ca Chiều (13:30 - 17:30)
                else
                    rowIndex = 2; // Ca Tối (18:00 - 21:00)

                string courseName = (string)s.CourseName;
                string classCode = (string)s.ClassCode;
                string room = (string)s.RoomCode;
                string teacher = (string)s.TeacherName;
                string topic = (string)s.Topic;
                int scheduleId = Convert.ToInt32(s.ScheduleId);
                int sessionNum = Convert.ToInt32(s.SessionNumber);
                bool isLocked = Convert.ToInt32(s.IsAttendanceLocked) == 1;

                // Chọn màu sắc nhận diện trực quan theo khóa học
                Color bgColor, borderColor, textColor;
                if (courseName.Contains("IELTS Foundation"))
                {
                    bgColor = Color.FromArgb(255, 228, 230); // Hồng nhạt
                    borderColor = Color.FromArgb(251, 113, 133);
                    textColor = Color.FromArgb(159, 18, 57);
                }
                else if (courseName.Contains("IELTS"))
                {
                    bgColor = Color.FromArgb(224, 242, 254); // Xanh dương nhạt
                    borderColor = Color.FromArgb(56, 189, 248);
                    textColor = Color.FromArgb(3, 105, 161);
                }
                else if (courseName.Contains("TOEIC"))
                {
                    bgColor = Color.FromArgb(254, 243, 199); // Vàng cam nhạt
                    borderColor = Color.FromArgb(251, 191, 36);
                    textColor = Color.FromArgb(146, 64, 14);
                }
                else // Giao tiếp hoặc các khóa khác
                {
                    bgColor = Color.FromArgb(240, 253, 244); // Xanh lá nhạt
                    borderColor = Color.FromArgb(74, 222, 128);
                    textColor = Color.FromArgb(22, 101, 52);
                }

                var item = new ScheduleItem
                {
                    ScheduleId = scheduleId,
                    SessionNumber = sessionNum,
                    Topic = topic,
                    CourseName = courseName,
                    ClassCode = classCode,
                    Room = room,
                    Teacher = teacher,
                    TimeText = $"{startTime} → {endTime}",
                    IsAttendanceLocked = isLocked,
                    BgColor = bgColor,
                    BorderColor = borderColor,
                    TextColor = textColor
                };

                var cell = dgvScheduleMatrix.Rows[rowIndex].Cells[colIndex];
                if (cell.Tag is not List<ScheduleItem> list)
                {
                    list = new List<ScheduleItem>();
                    cell.Tag = list;
                }
                list.Add(item);

                cell.Value = string.Join("\n---\n", list.Select(it =>
                    $"{it.CourseName} ({it.ClassCode})\nPhòng: {it.Room} - GV: {it.Teacher}\n{it.TimeText}"));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải thời khóa biểu từ CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        dgvScheduleMatrix.Invalidate();
        AdjustRowHeights();
    }

    private void DgvScheduleMatrix_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
        {
            e.PaintBackground(e.CellBounds, true);

            var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Tag is List<ScheduleItem> list && list.Count > 0 && e.Graphics != null)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                if (list.Count == 1)
                {
                    // Vẽ 1 thẻ duy nhất phủ đầy ô
                    var item = list[0];
                    var cardRect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12);
                    DrawScheduleCard(g, cardRect, item, isCompact: false);
                }
                else
                {
                    // Có từ 2 lớp trở lên trong cùng 1 ca: chia đều chiều cao để hiển thị cả 2
                    int gap = 4;
                    int cardHeight = Math.Max(40, (e.CellBounds.Height - 12 - gap) / 2);

                    var topRect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, cardHeight);
                    DrawScheduleCard(g, topRect, list[0], isCompact: true);

                    var botRect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6 + cardHeight + gap, e.CellBounds.Width - 12, cardHeight);
                    DrawScheduleCard(g, botRect, list[1], isCompact: true);
                }
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
            e.Handled = true;
        }
    }

    private void DrawScheduleCard(Graphics g, Rectangle cardRect, ScheduleItem item, bool isCompact)
    {
        using (var path = CreateRoundedRectangle(cardRect, 6))
        using (var brush = new SolidBrush(item.BgColor))
        using (var pen = new Pen(item.BorderColor, 1.5f))
        {
            g.FillPath(brush, path);
            g.DrawPath(pen, path);
        }

        using var titleFont = new Font("Segoe UI", isCompact ? 8.5f : 9.2f, FontStyle.Bold);
        using var bodyFont = new Font("Segoe UI", isCompact ? 7.8f : 8.5f, FontStyle.Regular);
        using var timeFont = new Font("Segoe UI", isCompact ? 7.8f : 8.5f, FontStyle.Bold);
        using var titleBrush = new SolidBrush(item.TextColor);
        using var textBrush = new SolidBrush(Color.FromArgb(51, 65, 85));

        float x = cardRect.X + 8;
        float y = cardRect.Y + (isCompact ? 4 : 8);

        // Tên khóa học + Mã lớp
        string header = $"{item.CourseName} ({item.ClassCode})";
        g.DrawString(header, titleFont, titleBrush, new RectangleF(x, y, cardRect.Width - 14, isCompact ? 16 : 20));
        y += isCompact ? 16 : 22;

        if (isCompact)
        {
            // Dạng rút gọn cho 2 lớp: "P201 · Thầy Anh · 🕒 18:00"
            string detail = $"{item.Room} · {item.Teacher} · 🕒 {item.TimeText}";
            g.DrawString(detail, bodyFont, textBrush, new RectangleF(x, y, cardRect.Width - 14, 16));
        }
        else
        {
            // Dạng đầy đủ
            g.DrawString($"Phòng: {item.Room}", bodyFont, textBrush, x, y);
            y += 18;

            g.DrawString($"GV: {item.Teacher}", bodyFont, textBrush, x, y);
            y += 20;

            g.DrawString($"🕒 {item.TimeText}", timeFont, titleBrush, x, y);
        }
    }

    private static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
    {
        var path = new GraphicsPath();
        int d = radius * 2;
        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void WireEvents()
    {
        cboScheduleType.SelectedIndexChanged += async (s, e) =>
        {
            if (_isInitializing) return;
            await UpdateTargetFilterAsync();
            await LoadScheduleDataAsync();
        };

        cboTargetFilter.SelectedIndexChanged += async (s, e) =>
        {
            if (_isInitializing) return;
            await LoadScheduleDataAsync();
        };

        cboTargetFilter.TextUpdate += async (s, e) =>
        {
            if (_isInitializing) return;
            await LoadScheduleDataAsync();
        };

        cboSemester.SelectedIndexChanged += async (s, e) =>
        {
            if (_isInitializing) return;
            RebuildWeeksForCurrentSemester();
            UpdateWeekHeaderDates();
            await LoadScheduleDataAsync();
        };

        cboWeek.SelectedIndexChanged += async (s, e) =>
        {
            if (_isInitializing) return;
            UpdateWeekHeaderDates();
            await LoadScheduleDataAsync();
        };

        btnPrevWeek.Click += (s, e) =>
        {
            if (cboWeek.SelectedIndex > 0)
            {
                cboWeek.SelectedIndex--;
            }
        };

        btnNextWeek.Click += (s, e) =>
        {
            if (cboWeek.SelectedIndex < cboWeek.Items.Count - 1)
            {
                cboWeek.SelectedIndex++;
            }
        };

        btnPrint.Click += (s, e) =>
        {
            MessageBox.Show($"Đã gửi lệnh in cho: {cboWeek.SelectedItem}\n{cboSemester.SelectedItem}", 
                "In thời khóa biểu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnManageRooms.Click += (s, e) =>
        {
            using var dlg = new RoomManagementDialog();
            dlg.ShowDialog(FindForm());
            _ = LoadScheduleDataAsync(); // Cập nhật lại lịch phòng nếu có thay đổi
        };

        btnCreateSession.Click += (s, e) =>
        {
            using var dlg = new CreateScheduleDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                _ = LoadScheduleDataAsync();
            }
        };

        dgvScheduleMatrix.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Tag is List<ScheduleItem> list && list.Count > 0)
                {
                    string info = string.Join("\n\n───────────────────────────────\n\n", list.Select(it =>
                        $"• Khóa học: {it.CourseName}\n" +
                        $"• Lớp: {it.ClassCode} (Buổi {it.SessionNumber})\n" +
                        $"• Phòng học: {it.Room}\n" +
                        $"• Giảng viên: {it.Teacher}\n" +
                        $"• Thời gian: {it.TimeText}\n" +
                        $"• Chủ đề: {it.Topic}\n" +
                        $"• Điểm danh: {(it.IsAttendanceLocked ? "🔒 Đã khóa sổ" : "Chưa khóa")}"));

                    MessageBox.Show(info, "Chi tiết lịch học buổi này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        };
    }

    private void UpdateWeekHeaderDates()
    {
        if (cboWeek.SelectedIndex < 0 || cboWeek.SelectedIndex >= _weeks.Count)
            return;

        DateTime startOfWeek = _weeks[cboWeek.SelectedIndex].Start;
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
