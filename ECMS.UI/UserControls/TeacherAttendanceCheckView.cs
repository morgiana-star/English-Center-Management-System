using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherAttendanceCheckView : UserControl
{
    public TeacherAttendanceCheckView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        _ = LoadClassesDataAsync();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.Add("Tất cả trạng thái");
        cboStatusFilter.Items.AddRange(ECMS.Core.Helpers.StatusFormatter.ClassStatusOptions);
        cboStatusFilter.SelectedIndex = 0;

        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.AddRange(new object[]
        {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS Intensive",
            "TOEIC 500+",
            "Giao tiếp cơ bản"
        });
        cboCourseFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvAttendanceClasses.AutoGenerateColumns = false;
        dgvAttendanceClasses.Columns.Clear();
        dgvAttendanceClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAttendanceClasses.MultiSelect = false;
        dgvAttendanceClasses.ReadOnly = true;
        dgvAttendanceClasses.RowHeadersVisible = false;
        dgvAttendanceClasses.AllowUserToAddRows = false;
        dgvAttendanceClasses.ScrollBars = ScrollBars.Both;

        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClassId", Visible = false });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 5F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã lớp", Width = 105, MinimumWidth = 95, FillWeight = 10F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCourse", HeaderText = "Khóa học", MinimumWidth = 150, FillWeight = 18F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Giáo viên phụ trách", Width = 150, MinimumWidth = 130, FillWeight = 15F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSchedule", HeaderText = "Lịch học & Giờ", Width = 160, MinimumWidth = 140, FillWeight = 16F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Phòng", Width = 85, MinimumWidth = 75, FillWeight = 8F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProgress", HeaderText = "Tiến độ", Width = 110, MinimumWidth = 95, FillWeight = 11F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRate", HeaderText = "Chuyên cần", Width = 135, MinimumWidth = 115, FillWeight = 13F });
        dgvAttendanceClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", Width = 100, MinimumWidth = 90, FillWeight = 10F });

        var actionCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "Điểm danh",
            UseColumnTextForButtonValue = true,
            Width = 110,
            MinimumWidth = 100,
            FillWeight = 11F
        };
        dgvAttendanceClasses.Columns.Add(actionCol);

        dgvAttendanceClasses.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAttendanceClasses.Columns[e.ColumnIndex].Name == "colRate" && e.Value != null)
            {
                string rateStr = e.Value.ToString() ?? "";
                if (rateStr.Contains("9") || rateStr.Contains("100%"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Xanh lá đậm
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else if (rateStr.Contains("8"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9); // Cam đậm
                }
                else if (rateStr.Contains("6") || rateStr.Contains("7"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Đỏ cảnh báo
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        };
    }

    private async Task LoadClassesDataAsync()
    {
        try
        {
            dgvAttendanceClasses.Rows.Clear();

            int? teacherId = SessionManager.CurrentUser?.TeacherId;
            string roleCode = SessionManager.CurrentUser?.RoleCode ?? "";

            // Nếu là Admin / Quản lý / Giáo vụ thì cho xem tất cả lớp, còn Giáo viên chỉ xem lớp mình phụ trách
            bool filterByTeacher = roleCode == "ROLE_TEA" || teacherId.HasValue;

            using var conn = DatabaseConfig.GetConnection();

            var query = @"
                SELECT 
                    c.ClassId,
                    c.ClassCode,
                    co.CourseName,
                    COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                    COALESCE(r.RoomName, '—') AS RoomName,
                    c.Status,
                    co.TotalSessions,
                    COUNT(DISTINCT cs.ScheduleId) AS ScheduledSessions,
                    COUNT(DISTINCT CASE WHEN cs.IsAttendanceLocked = 1 OR EXISTS (SELECT 1 FROM AttendanceRecords ar WHERE ar.ScheduleId = cs.ScheduleId) THEN cs.ScheduleId END) AS DoneSessions,
                    COUNT(DISTINCT e.StudentId) AS StudentCount
                FROM Classes c
                JOIN Courses co ON c.CourseId = co.CourseId
                LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
                LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
                LEFT JOIN ClassSchedules cs ON cs.ClassId = c.ClassId
                LEFT JOIN Enrollments e ON e.ClassId = c.ClassId
                WHERE (@FilterByTeacher = 0 OR c.MainTeacherId = @TeacherId)
                GROUP BY c.ClassId
                ORDER BY c.ClassId DESC;";

            var classes = (await conn.QueryAsync<dynamic>(query, new 
            { 
                FilterByTeacher = filterByTeacher ? 1 : 0, 
                TeacherId = teacherId ?? 1 
            })).ToList();

            // Nếu CSDL chưa có lớp nào cho GV, thử lấy tất cả lớp để không bị rỗng giao diện
            if (classes.Count == 0 && filterByTeacher)
            {
                classes = (await conn.QueryAsync<dynamic>(query, new { FilterByTeacher = 0, TeacherId = 0 })).ToList();
            }

            int stt = 1;
            foreach (var cls in classes)
            {
                int classId = (int)cls.ClassId;
                string classCode = (string)cls.ClassCode;
                string courseName = (string)cls.CourseName;
                string teacherName = (string)cls.TeacherName;
                string roomName = (string)cls.RoomName;
                string rawStatus = (string)cls.Status;

                // Lấy thông tin lịch học tóm tắt từ ClassSchedules
                var scheduleSummary = await conn.QueryFirstOrDefaultAsync<string>(@"
                    SELECT cs.StartTime || ' - ' || cs.EndTime
                    FROM ClassSchedules cs
                    WHERE cs.ClassId = @ClassId
                    ORDER BY cs.ScheduleId ASC LIMIT 1;", new { ClassId = classId }) ?? "Chưa xếp lịch";

                int total = cls.TotalSessions != null ? (int)cls.TotalSessions : 24;
                int done = Convert.ToInt32(cls.DoneSessions);
                string progress = $"{done} / {total} buổi";

                // Tính tỷ lệ chuyên cần trung bình thực tế từ AttendanceRecords của lớp
                var attStats = await conn.QueryFirstOrDefaultAsync<(long PresentCount, long TotalCount)?>(@"
                    SELECT 
                        COUNT(CASE WHEN ar.Status IN ('Present', 'Late') THEN 1 END) AS PresentCount,
                        COUNT(ar.AttendanceId) AS TotalCount
                    FROM AttendanceRecords ar
                    JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
                    WHERE cs.ClassId = @ClassId;", new { ClassId = classId });

                string rateStr = "Chưa có";
                if (attStats.HasValue && attStats.Value.TotalCount > 0)
                {
                    double percent = (attStats.Value.PresentCount * 100.0) / attStats.Value.TotalCount;
                    rateStr = $"{percent:0.0}%";
                }
                else if (done == 0)
                {
                    rateStr = "Chưa diễn ra";
                }

                // Dịch trạng thái hiển thị
                string displayStatus = ECMS.Core.Helpers.StatusFormatter.FormatClassStatus(rawStatus);

                dgvAttendanceClasses.Rows.Add(
                    classId.ToString(),
                    stt.ToString(),
                    classCode,
                    courseName,
                    teacherName,
                    scheduleSummary,
                    roomName,
                    progress,
                    rateStr,
                    displayStatus,
                    "Điểm danh"
                );

                stt++;
            }

            // Đồng bộ bộ lọc Khóa học từ CSDL
            UpdateCourseFilterOptions();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp danh sách lớp học từ CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void UpdateCourseFilterOptions()
    {
        var current = cboCourseFilter.SelectedItem?.ToString();
        var courses = new System.Collections.Generic.HashSet<string>();

        foreach (DataGridViewRow row in dgvAttendanceClasses.Rows)
        {
            if (row.IsNewRow) continue;
            string c = row.Cells["colCourse"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(c)) courses.Add(c);
        }

        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.Add("Tất cả khóa học");
        foreach (var c in courses)
        {
            cboCourseFilter.Items.Add(c);
        }

        cboCourseFilter.SelectedIndex = 0;
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) => FilterClasses();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterClasses();
        cboCourseFilter.SelectedIndexChanged += (s, e) => FilterClasses();

        dgvAttendanceClasses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAttendanceClasses.Columns[e.ColumnIndex].Name == "colAction")
            {
                OpenClassAttendance(e.RowIndex);
            }
        };

        dgvAttendanceClasses.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenClassAttendance(e.RowIndex);
            }
        };
    }

    private void OpenClassAttendance(int rowIndex)
    {
        var row = dgvAttendanceClasses.Rows[rowIndex];
        int classId = 1;
        string? classIdRaw = row.Cells["colClassId"].Value?.ToString();
        if (!string.IsNullOrEmpty(classIdRaw))
        {
            _ = int.TryParse(classIdRaw, out classId);
        }
        string classCode = row.Cells["colCode"].Value?.ToString() ?? "IELTS-2026-K12";
        string courseName = row.Cells["colCourse"].Value?.ToString() ?? "IELTS Foundation";
        string teacher = row.Cells["colTeacher"].Value?.ToString() ?? "Thầy John Smith";
        string room = row.Cells["colRoom"].Value?.ToString() ?? "P.201";

        using var dlg = new ClassAttendanceDialog(classId, classCode, courseName, teacher, room);
        dlg.ShowDialog(FindForm());
        _ = LoadClassesDataAsync(); // Cập nhật lại số liệu sau khi đóng dialog
    }

    private void FilterClasses()
    {
        string kw = txtSearch.Text.Trim().ToLowerInvariant();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";
        string course = cboCourseFilter.SelectedItem?.ToString() ?? "Tất cả khóa học";

        foreach (DataGridViewRow row in dgvAttendanceClasses.Rows)
        {
            if (row.IsNewRow) continue;
            string code = row.Cells["colCode"].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowCourse = row.Cells["colCourse"].Value?.ToString() ?? "";
            string teacher = row.Cells["colTeacher"].Value?.ToString()?.ToLowerInvariant() ?? "";
            string room = row.Cells["colRoom"].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowStatus = row.Cells["colStatus"].Value?.ToString() ?? "";

            bool matchKw = string.IsNullOrEmpty(kw) || code.Contains(kw) || rowCourse.ToLowerInvariant().Contains(kw) || teacher.Contains(kw) || room.Contains(kw);
            bool matchStatus = status == "Tất cả trạng thái" || rowStatus == status;
            bool matchCourse = course == "Tất cả khóa học" || rowCourse.Contains(course);

            row.Visible = matchKw && matchStatus && matchCourse;
        }
    }

    private void AdjustLayout()
    {
        if (pnlBody == null || cardClasses == null || dgvAttendanceClasses == null || pnlFilters == null) return;

        int margin = 24;
        pnlFilters.SetBounds(margin, 16, Math.Max(500, pnlBody.ClientSize.Width - (margin * 2)), 48);

        int cardTop = 76;
        int cardWidth = Math.Max(500, pnlBody.ClientSize.Width - (margin * 2));
        int cardHeight = Math.Max(250, pnlBody.ClientSize.Height - cardTop - margin);
        cardClasses.SetBounds(margin, cardTop, cardWidth, cardHeight);

        dgvAttendanceClasses.SetBounds(16, 16, cardClasses.ClientSize.Width - 32, cardClasses.ClientSize.Height - 32);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustLayout();
    }
}
