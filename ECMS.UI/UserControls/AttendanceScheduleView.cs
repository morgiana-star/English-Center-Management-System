using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;
using ECMS.UI.Helper;

namespace ECMS.UI.UserControls;

/// <summary>
/// Danh sách buổi dạy của giáo viên.
/// Giáo viên chọn buổi → bấm nút "📋 Điểm danh" → mở AttendanceSheetView.
/// </summary>
public partial class AttendanceScheduleView : UserControl
{
    private DataGridView dgv = null!;
    private Label lblStatus = null!;

    public AttendanceScheduleView()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        // ── Tiêu đề ──────────────────────────────────────────
        Controls.Add(new Label
        {
            Text = "SỔ ĐIỂM DANH — CHỌN BUỔI HỌC",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(20, 16), AutoSize = true
        });

        Controls.Add(new Label
        {
            Text = "Chọn buổi học muốn điểm danh rồi nhấn nút \"📋 Điểm danh\" ở cột cuối",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 48), AutoSize = true
        });

        // ── Bảng danh sách buổi dạy ──────────────────────────
        dgv = new DataGridView
        {
            Location = new Point(20, 80),
            Size = new Size(1020, 500),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
            ScrollBars = ScrollBars.Both,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        };
        ModernGridHelper.ApplyStyle(dgv);
        dgv.ScrollBars = ScrollBars.Both;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        
        dgv.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "ScheduleId", Visible = false }); // Cột ẩn chứa ID buổi học để mở điểm danh
        Method.DataGridViewHelper.AddTextColumn(dgv, "SessionNum", "Buổi");
        Method.DataGridViewHelper.AddTextColumn(dgv, "ClassCode", "Mã lớp");
        Method.DataGridViewHelper.AddTextColumn(dgv, "Date", "Ngày dạy");
        Method.DataGridViewHelper.AddTextColumn(dgv, "TimeSlot", "Khung giờ");
        Method.DataGridViewHelper.AddTextColumn(dgv, "Room", "Phòng học");
        Method.DataGridViewHelper.AddTextColumn(dgv, "Topic", "Chủ đề bài giảng");
        Method.DataGridViewHelper.AddTextColumn(dgv, "AttendState", "Trạng thái");
        
        dgv.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "BtnAttend",
            HeaderText = "Hành động",
            Text = "📋 Điểm danh",
            UseColumnTextForButtonValue = true,
            Width = 120,
            FlatStyle = FlatStyle.Flat
        });

        dgv.CellClick += OnCellClick;
        Controls.Add(dgv);

        // ── Trạng thái ───────────────────────────────────────
        lblStatus = new Label
        {
            Text = "Đang tải...",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 590), AutoSize = true
        };
        Controls.Add(lblStatus);

        Load += async (s, e) => await LoadSchedulesAsync();
    }

    // ── Nạp danh sách buổi dạy từ DB ────────────────────────
    private async Task LoadSchedulesAsync()
    {
        try
        {
            int teacherId = SessionManager.CurrentUser?.TeacherId ?? 1;
            using var conn = DatabaseConfig.GetConnection();

            var rows = await conn.QueryAsync<dynamic>(@"
                SELECT
                    cs.ScheduleId,
                    cs.SessionNumber,
                    c.ClassCode,
                    cs.Date,
                    cs.StartTime || ' - ' || cs.EndTime AS TimeSlot,
                    COALESCE(cr.RoomName, '—') AS RoomName,
                    COALESCE(cs.Topic, '—')    AS Topic,
                    CASE
                        WHEN cs.IsAttendanceLocked = 1 THEN '🔒 Đã khóa'
                        WHEN EXISTS (
                            SELECT 1 FROM AttendanceRecords ar
                            WHERE ar.ScheduleId = cs.ScheduleId LIMIT 1
                        ) THEN '✅ Đã điểm danh'
                        ELSE '⬜ Chưa điểm danh'
                    END AS AttendState
                FROM ClassSchedules cs
                JOIN Classes c          ON cs.ClassId = c.ClassId
                LEFT JOIN ClassRooms cr ON cs.RoomId  = cr.RoomId
                WHERE cs.TeacherId = @TeacherId
                ORDER BY cs.Date DESC, cs.StartTime ASC;",
                new { TeacherId = teacherId });

            dgv.Rows.Clear();
            int count = 0;
            foreach (var r in rows)
            {
                int idx = dgv.Rows.Add(
                    (int)r.ScheduleId,
                    (int)r.SessionNumber,
                    (string)r.ClassCode,
                    ((string)r.Date).Split('T')[0],
                    (string)r.TimeSlot,
                    (string)r.RoomName,
                    (string)r.Topic,
                    (string)r.AttendState);

                // Tô màu dòng theo trạng thái
                string state = (string)r.AttendState;
                if (state.Contains("Đã khóa"))
                    dgv.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(243, 232, 255);
                else if (state.Contains("Đã điểm danh"))
                    dgv.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(220, 252, 231);

                count++;
            }

            lblStatus.Text = $"Tổng {count} buổi học — nhấn \"📋 Điểm danh\" để mở sổ điểm danh cho từng buổi.";
            lblStatus.ForeColor = ThemeColors.TextSecondary;
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Lỗi tải dữ liệu: " + ex.Message;
            lblStatus.ForeColor = ThemeColors.DangerText;
        }
    }

    // ── Xử lý click nút "📋 Điểm danh" trong từng dòng ──────
    private void OnCellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != dgv.Columns["BtnAttend"]!.Index) return;

        var row       = dgv.Rows[e.RowIndex];
        int scheduleId = Convert.ToInt32(row.Cells["ScheduleId"].Value);
        string classCode = row.Cells["ClassCode"].Value?.ToString() ?? "Lớp";
        string date      = row.Cells["Date"].Value?.ToString() ?? "";

        var mainForm = FindForm() as ECMS.UI.Forms.MainForm;
        mainForm?.ShowUserControl(new AttendanceSheetView(scheduleId, $"{classCode} — {date}"));
    }
}

