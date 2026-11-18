using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ScheduleManagementView : UserControl
{
    private class ScheduleItem
    {
        public string CourseName { get; set; } = string.Empty;
        public string ClassCode { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
        public string Teacher { get; set; } = string.Empty;
        public string TimeText { get; set; } = string.Empty;
        public Color BgColor { get; set; }
        public Color BorderColor { get; set; }
        public Color TextColor { get; set; }
    }

    public ScheduleManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupMatrixGrid();
        LoadScheduleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        // 3.1: Học kỳ & Năm học (3 học kỳ / năm)
        cboSemester.Items.Clear();
        cboSemester.Items.AddRange(new object[]
        {
            "Học kỳ 1 (01/2026 – 04/2026) · Năm học 2026 - 2027",
            "Học kỳ 2 (05/2026 – 08/2026) · Năm học 2026 - 2027",
            "Học kỳ 3 (09/2026 – 12/2026) · Năm học 2026 - 2027"
        });
        cboSemester.SelectedIndex = 2; // Kỳ 3 hiện tại

        // 3.2: Đối tượng xem thời khóa biểu
        cboScheduleType.Items.Clear();
        cboScheduleType.Items.AddRange(new object[]
        {
            "Thời khóa biểu tất cả",
            "Thời khóa biểu theo lớp",
            "Thời khóa biểu theo khóa học",
            "Thời khóa biểu theo giảng viên"
        });
        cboScheduleType.SelectedIndex = 0;

        UpdateTargetFilter();

        // 3.3: Ô chọn Tuần trong học kỳ
        cboWeek.Items.Clear();
        cboWeek.Items.AddRange(new object[]
        {
            "Tuần 09 [từ ngày 26/10/2026 đến ngày 01/11/2026]",
            "Tuần 10 [từ ngày 02/11/2026 đến ngày 08/11/2026]",
            "Tuần 11 [từ ngày 09/11/2026 đến ngày 15/11/2026]",
            "Tuần 12 [từ ngày 16/11/2026 đến ngày 22/11/2026]",
            "Tuần 13 [từ ngày 23/11/2026 đến ngày 29/11/2026]"
        });
        cboWeek.SelectedIndex = 2; // Tuần 11
    }

    private void UpdateTargetFilter()
    {
        cboTargetFilter.Items.Clear();
        switch (cboScheduleType.SelectedIndex)
        {
            case 1: // Theo lớp
                cboTargetFilter.Items.AddRange(new object[] { "IELTS-F01", "IELTS-F02", "IELTS-I01", "TOEIC-A01", "COM-B01" });
                cboTargetFilter.Enabled = true;
                cboTargetFilter.SelectedIndex = 0;
                break;
            case 2: // Theo khóa học
                cboTargetFilter.Items.AddRange(new object[] { "IELTS Foundation", "IELTS Intensive", "TOEIC 500+", "Giao tiếp cơ bản" });
                cboTargetFilter.Enabled = true;
                cboTargetFilter.SelectedIndex = 0;
                break;
            case 3: // Theo giảng viên
                cboTargetFilter.Items.AddRange(new object[] { "Nguyễn Hoàng Anh", "Trần Minh Tuấn", "Lê Thu Hà", "Võ Tấn Toàn" });
                cboTargetFilter.Enabled = true;
                cboTargetFilter.SelectedIndex = 0;
                break;
            default: // Tất cả
                cboTargetFilter.Items.Add("-- Xem tất cả thời khóa biểu --");
                cboTargetFilter.SelectedIndex = 0;
                cboTargetFilter.Enabled = false;
                break;
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
        string[] days = { "Thứ 2 (09/11)", "Thứ 3 (10/11)", "Thứ 4 (11/11)", "Thứ 5 (12/11)", "Thứ 6 (13/11)", "Thứ 7 (14/11)", "Chủ Nhật (15/11)" };
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
    }

    private void LoadScheduleData()
    {
        dgvScheduleMatrix.Rows.Clear();

        // 3.4: Trung tâm dạy 3 ca: Sáng (8h-12h), Chiều (13h30-17h30), Tối (18h-21h)
        int rMorning = dgvScheduleMatrix.Rows.Add("Ca Sáng\n08:00 – 12:00", "", "", "", "", "", "", "");
        int rAfternoon = dgvScheduleMatrix.Rows.Add("Ca Chiều\n13:30 – 17:30", "", "", "", "", "", "", "");
        int rEvening = dgvScheduleMatrix.Rows.Add("Ca Tối\n18:00 – 21:00", "", "", "", "", "", "", "");

        // Nạp các lớp mẫu vào các ô (Tag chứa ScheduleItem)
        // Ca Sáng: Thứ 7 & CN có lớp Giao tiếp cơ bản
        SetScheduleCell(rMorning, 6, new ScheduleItem
        {
            CourseName = "Giao tiếp cơ bản",
            ClassCode = "COM-B01",
            Room = "P102",
            Teacher = "Lê Thu Hà",
            TimeText = "08:30 → 11:30",
            BgColor = Color.FromArgb(240, 253, 244), // Xanh lá nhạt
            BorderColor = Color.FromArgb(74, 222, 128),
            TextColor = Color.FromArgb(22, 101, 52)
        });
        SetScheduleCell(rMorning, 7, new ScheduleItem
        {
            CourseName = "Giao tiếp cơ bản",
            ClassCode = "COM-B01",
            Room = "P102",
            Teacher = "Lê Thu Hà",
            TimeText = "08:30 → 11:30",
            BgColor = Color.FromArgb(240, 253, 244),
            BorderColor = Color.FromArgb(74, 222, 128),
            TextColor = Color.FromArgb(22, 101, 52)
        });

        // Ca Chiều: Thứ 4 & Thứ 7
        SetScheduleCell(rAfternoon, 3, new ScheduleItem
        {
            CourseName = "IELTS Intensive",
            ClassCode = "IELTS-I01",
            Room = "P203",
            Teacher = "Trần Minh Tuấn",
            TimeText = "14:00 → 17:00",
            BgColor = Color.FromArgb(224, 242, 254), // Xanh dương nhạt
            BorderColor = Color.FromArgb(56, 189, 248),
            TextColor = Color.FromArgb(3, 105, 161)
        });
        SetScheduleCell(rAfternoon, 6, new ScheduleItem
        {
            CourseName = "IELTS Intensive",
            ClassCode = "IELTS-I01",
            Room = "P203",
            Teacher = "Trần Minh Tuấn",
            TimeText = "14:00 → 17:00",
            BgColor = Color.FromArgb(224, 242, 254),
            BorderColor = Color.FromArgb(56, 189, 248),
            TextColor = Color.FromArgb(3, 105, 161)
        });

        // Ca Tối: Thứ 3 & Thứ 6 (Lớp IELTS-F01 và TOEIC-A01)
        SetScheduleCell(rEvening, 2, new ScheduleItem
        {
            CourseName = "IELTS Foundation",
            ClassCode = "IELTS-F01",
            Room = "P201",
            Teacher = "Nguyễn Hoàng Anh",
            TimeText = "18:00 → 20:00",
            BgColor = Color.FromArgb(255, 228, 230), // Hồng nhạt như mẫu
            BorderColor = Color.FromArgb(251, 113, 133),
            TextColor = Color.FromArgb(159, 18, 57)
        });
        SetScheduleCell(rEvening, 5, new ScheduleItem
        {
            CourseName = "IELTS Foundation",
            ClassCode = "IELTS-F01",
            Room = "P201",
            Teacher = "Nguyễn Hoàng Anh",
            TimeText = "18:00 → 20:00",
            BgColor = Color.FromArgb(255, 228, 230),
            BorderColor = Color.FromArgb(251, 113, 133),
            TextColor = Color.FromArgb(159, 18, 57)
        });

        SetScheduleCell(rEvening, 4, new ScheduleItem
        {
            CourseName = "TOEIC 500+",
            ClassCode = "TOEIC-A01",
            Room = "P202",
            Teacher = "Trần Minh Tuấn",
            TimeText = "18:30 → 20:30",
            BgColor = Color.FromArgb(254, 243, 199), // Vàng cam nhạt
            BorderColor = Color.FromArgb(251, 191, 36),
            TextColor = Color.FromArgb(146, 64, 14)
        });

        AdjustRowHeights();
    }

    private void SetScheduleCell(int row, int col, ScheduleItem item)
    {
        if (row >= 0 && row < dgvScheduleMatrix.RowCount && col >= 1 && col < dgvScheduleMatrix.ColumnCount)
        {
            var cell = dgvScheduleMatrix.Rows[row].Cells[col];
            cell.Value = $"{item.CourseName}\n({item.ClassCode})\nPhòng: {item.Room}\nGV: {item.Teacher}\n{item.TimeText}";
            cell.Tag = item;
        }
    }

    private void DgvScheduleMatrix_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
        {
            e.PaintBackground(e.CellBounds, true);

            var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Tag is ScheduleItem item && e.Graphics != null)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                var cardRect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12);

                using (var path = CreateRoundedRectangle(cardRect, 6))
                using (var brush = new SolidBrush(item.BgColor))
                using (var pen = new Pen(item.BorderColor, 1.5f))
                {
                    g.FillPath(brush, path);
                    g.DrawPath(pen, path);
                }

                using var titleFont = new Font("Segoe UI", 9.2f, FontStyle.Bold);
                using var bodyFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
                using var timeFont = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                using var titleBrush = new SolidBrush(item.TextColor);
                using var textBrush = new SolidBrush(Color.FromArgb(51, 65, 85));

                float x = cardRect.X + 10;
                float y = cardRect.Y + 8;

                // Tên khóa học + Mã lớp
                string header = $"{item.CourseName} ({item.ClassCode})";
                g.DrawString(header, titleFont, titleBrush, new RectangleF(x, y, cardRect.Width - 16, 20));
                y += 22;

                // Phòng
                g.DrawString($"Phòng: {item.Room}", bodyFont, textBrush, x, y);
                y += 18;

                // Giáo viên
                g.DrawString($"GV: {item.Teacher}", bodyFont, textBrush, x, y);
                y += 20;

                // Thời gian (🕒 18:00 → 20:00)
                g.DrawString($"🕒 {item.TimeText}", timeFont, titleBrush, x, y);
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border);
            e.Handled = true;
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
        cboScheduleType.SelectedIndexChanged += (s, e) =>
        {
            UpdateTargetFilter();
            LoadScheduleData();
        };

        cboTargetFilter.SelectedIndexChanged += (s, e) =>
        {
            LoadScheduleData();
        };

        cboSemester.SelectedIndexChanged += (s, e) =>
        {
            LoadScheduleData();
        };

        cboWeek.SelectedIndexChanged += (s, e) =>
        {
            UpdateWeekHeaderDates();
            LoadScheduleData();
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
        };

        btnCreateSession.Click += (s, e) =>
        {
            using var dlg = new CreateScheduleDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadScheduleData();
            }
        };

        dgvScheduleMatrix.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                var cell = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Tag is ScheduleItem item)
                {
                    MessageBox.Show(
                        $"THÔNG TIN BUỔI HỌC:\n\n" +
                        $"• Khóa học: {item.CourseName}\n" +
                        $"• Lớp: {item.ClassCode}\n" +
                        $"• Phòng học: {item.Room}\n" +
                        $"• Giảng viên: {item.Teacher}\n" +
                        $"• Thời gian: {item.TimeText}",
                        "Chi tiết lịch học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        };
    }

    private void UpdateWeekHeaderDates()
    {
        // Điều chỉnh nhãn ngày trên header cột tương ứng theo tuần
        int weekIndex = cboWeek.SelectedIndex;
        DateTime startOfWeek = new DateTime(2026, 11, 9).AddDays((weekIndex - 2) * 7);

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
