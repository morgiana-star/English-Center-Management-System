using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

/// <summary>
/// Sổ điểm danh cho 1 buổi học cụ thể.
/// Mở từ AttendanceScheduleView khi giáo viên chọn buổi.
/// </summary>
public partial class AttendanceSheetView : UserControl
{
    // ── Ánh xạ tiếng Việt ↔ enum ────────────────────────────
    private static readonly Dictionary<string, AttendanceStatus> StatusMap = new()
    {
        { "Có mặt",        AttendanceStatus.Present },
        { "Vắng",          AttendanceStatus.Absent  },
        { "Vắng có phép",  AttendanceStatus.Excused },
        { "Muộn",          AttendanceStatus.Late    }
    };
    private static readonly Dictionary<AttendanceStatus, string> StatusMapReverse =
        StatusMap.ToDictionary(kv => kv.Value, kv => kv.Key);

    private readonly int _scheduleId;
    private readonly IAttendanceService _attendanceService = new AttendanceService();
    private DataGridView dgv = null!;
    private Label lblStatus = null!;

    public AttendanceSheetView(int scheduleId, string className)
    {
        _scheduleId = scheduleId;
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        // ── Tiêu đề ──────────────────────────────────────────
        Controls.Add(new Label
        {
            Text = $"SỔ ĐIỂM DANH — {className}",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(20, 16), AutoSize = true
        });

        Controls.Add(new Label
        {
            Text = $"Buổi học ID: {scheduleId}  •  Điền trạng thái cho từng học viên rồi nhấn LƯU",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 48), AutoSize = true
        });

        // ── Nút quay lại ─────────────────────────────────────
        var btnBack = new CustomButton
        {
            Text = "← Quay lại danh sách buổi",
            Location = new Point(20, 76), Size = new Size(200, 30),
            NormalColor = Color.FromArgb(100, 116, 139),
            HoverColor  = Color.FromArgb(71, 85, 105),
            CornerRadius = 6
        };
        btnBack.Click += (s, e) =>
        {
            var mainForm = FindForm() as ECMS.UI.Forms.MainForm;
            mainForm?.ShowUserControl(new AttendanceScheduleView());
        };
        Controls.Add(btnBack);

        // ── Bảng học viên ────────────────────────────────────
        dgv = new DataGridView
        {
            Location = new Point(20, 118),
            Size = new Size(960, 380),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgv);
        dgv.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "StudentId", Visible = false }); // ẩn, dùng khi lưu
        dgv.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "StudentCode", HeaderText = "Mã HV", Width = 105, ReadOnly = true });
        dgv.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "FullName", HeaderText = "Họ và tên", Width = 230, ReadOnly = true });
        dgv.Columns.Add(new DataGridViewComboBoxColumn
        {
            Name = "Status", HeaderText = "Trạng thái", Width = 150,
            DataSource = StatusMap.Keys.ToArray(),
            FlatStyle = FlatStyle.Flat
        });
        dgv.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Note", HeaderText = "Ghi chú", Width = 450 });
        Controls.Add(dgv);
        
        // ── Thanh nút + thông báo kết quả ───────────────────
        var btnMarkAll = new CustomButton
        {
            Text = "✓ Điểm danh tất cả Có mặt",
            Location = new Point(20, 510), Size = new Size(230, 34),
            NormalColor = ThemeColors.SuccessText,
            HoverColor  = Color.FromArgb(16, 185, 129),
            CornerRadius = 6
        };
        btnMarkAll.Click += (s, e) => MarkAllPresent();
        Controls.Add(btnMarkAll);

        var btnSave = new CustomButton
        {
            Text = "💾 LƯU ĐIỂM DANH",
            Location = new Point(262, 510), Size = new Size(180, 34),
            NormalColor = Color.FromArgb(67, 56, 202),
            HoverColor  = Color.FromArgb(79, 70, 229),
            CornerRadius = 6
        };
        btnSave.Click += async (s, e) => await SaveAttendanceAsync();
        Controls.Add(btnSave);

        // TODO: gọi LoadStudentsAsync() khi Load
        // Load += async (s, e) => await LoadStudentsAsync();
        lblStatus = new Label
        {
            Text = "Đang tải danh sách học viên...",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(458, 518), AutoSize = true
        };
        Controls.Add(lblStatus);

        Load += async (s, e) => await LoadStudentsAsync();
    }

    // TODO: điền học viên từ DB vào dgv
    // private async Task LoadStudentsAsync() { ... }
    // ── 1. Nạp học viên + pre-fill dữ liệu điểm danh cũ ────
    private async Task LoadStudentsAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();

    // TODO: đọc từng dòng dgv → tạo AttendanceRecord → upsert DB
    // private async Task SaveAttendanceAsync() { ... }
            var students = await conn.QueryAsync<dynamic>(@"
                SELECT s.StudentId, s.StudentCode, s.FullName
                FROM Enrollments e
                JOIN ClassSchedules cs ON cs.ClassId = e.ClassId
                JOIN Students s        ON s.StudentId = e.StudentId
                WHERE cs.ScheduleId = @ScheduleId
                ORDER BY s.FullName ASC;", new { ScheduleId = _scheduleId });

            var existing = await conn.QueryAsync<dynamic>(@"
                SELECT StudentId, Status, Note
                FROM AttendanceRecords
                WHERE ScheduleId = @ScheduleId;", new { ScheduleId = _scheduleId });

            var existingDict = existing.ToDictionary(
                r => (int)r.StudentId,
                r => (Status: (string)r.Status, Note: (string?)r.Note));

            dgv.Rows.Clear();
            foreach (var s in students)
            {
                int    sid   = (int)s.StudentId;
                string displayStatus = "Có mặt";
                string note  = "";

                if (existingDict.TryGetValue(sid, out var prev))
                {
                    if (Enum.TryParse<AttendanceStatus>(prev.Status, out var parsed)
                        && StatusMapReverse.TryGetValue(parsed, out var vn))
                        displayStatus = vn;
                    note = prev.Note ?? "";
                }

                dgv.Rows.Add(sid, s.StudentCode, s.FullName, displayStatus, note);
            }

            int count = dgv.Rows.Count;
            bool hasPrev = existingDict.Count > 0;
            lblStatus.Text = $"Tổng {count} học viên.{(hasPrev ? " (Đã có dữ liệu điểm danh trước — đang hiển thị)" : "")}";
            lblStatus.ForeColor = ThemeColors.TextSecondary;
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Lỗi tải dữ liệu: " + ex.Message;
            lblStatus.ForeColor = ThemeColors.DangerText;
        }
    }

    // ── 2. Tick tất cả "Có mặt" ─────────────────────────────
    private void MarkAllPresent()
    {
        foreach (DataGridViewRow row in dgv.Rows)
            if (!row.IsNewRow)
                row.Cells["Status"].Value = "Có mặt";
    }

    // ── 3. Lưu toàn bộ bảng vào DB (upsert) ─────────────────
    private async Task SaveAttendanceAsync()
    {
        try
        {
            lblStatus.Text = "Đang lưu...";
            lblStatus.ForeColor = ThemeColors.WarningText;

            var records = new List<(int StudentId, AttendanceStatus Status, string? Note)>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                int    studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                string statusVn  = row.Cells["Status"].Value?.ToString() ?? "Có mặt";
                string? note     = row.Cells["Note"].Value?.ToString();

                AttendanceStatus status = StatusMap.TryGetValue(statusVn, out var s)
                    ? s : AttendanceStatus.Present;

                records.Add((studentId, status, note));
            }

            bool ok = await _attendanceService.SaveAttendanceBatchAsync(_scheduleId, records);

            lblStatus.Text = ok
                ? $"✅ Đã lưu điểm danh cho {records.Count} học viên lúc {DateTime.Now:HH:mm:ss}"
                : "❌ Lưu thất bại — xem lại kết nối DB.";
            lblStatus.ForeColor = ok ? ThemeColors.SuccessText : ThemeColors.DangerText;
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Lỗi: " + ex.Message;
            lblStatus.ForeColor = ThemeColors.DangerText;
        }
    }
}

