using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateScheduleDialog : Form
{
    public string SelectedClassCode { get; private set; } = string.Empty;
    public string SelectedCourseName { get; private set; } = string.Empty;

    public CreateScheduleDialog()
    {
        InitializeComponent();

        SetupGrid();
        _ = LoadClassesDataAsync();
        WireEvents();
    }

    private void SetupGrid()
    {
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.ScrollBars = ScrollBars.Both;

        // Cột ẩn chứa thông tin kỹ thuật
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClassId", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotalSessions", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colExistingSessions", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoomId", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacherId", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSchedulePattern", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartTime", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEndTime", Visible = false });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartDateRaw", Visible = false });

        // Cột hiển thị
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 50, MinimumWidth = 45, FillWeight = 5F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã lớp", Width = 100, MinimumWidth = 90, FillWeight = 11F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCourse", HeaderText = "Khóa học", MinimumWidth = 140, FillWeight = 19F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Giáo viên phụ trách", Width = 145, MinimumWidth = 130, FillWeight = 15F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSchedule", HeaderText = "Lịch định kỳ", Width = 115, MinimumWidth = 105, FillWeight = 12F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTime", HeaderText = "Khung giờ", Width = 130, MinimumWidth = 115, FillWeight = 13F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Phòng", Width = 80, MinimumWidth = 70, FillWeight = 8F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartDate", HeaderText = "Khai giảng", Width = 105, MinimumWidth = 95, FillWeight = 10F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSessions", HeaderText = "Số buổi", Width = 115, MinimumWidth = 105, FillWeight = 12F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", Width = 105, MinimumWidth = 95, FillWeight = 10F });

        dgvClasses.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClasses.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val.Contains("Đang học"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Xanh lá
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (val.Contains("tuyển sinh") || val.Contains("Sắp mở"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235); // Xanh dương
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139);
                }
            }
        };
    }

    private async Task LoadClassesDataAsync()
    {
        try
        {
            dgvClasses.Rows.Clear();
            using var conn = DatabaseConfig.GetConnection();

            string sql = @"
                SELECT 
                    c.ClassId,
                    c.ClassCode,
                    c.ClassName,
                    co.CourseName,
                    COALESCE(co.TotalSessions, 24) AS TotalSessions,
                    COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                    COALESCE(c.MainTeacherId, 1) AS TeacherId,
                    COALESCE(c.SchedulePattern, 'T3,T6') AS SchedulePattern,
                    COALESCE(c.StartTime, '18:00') AS StartTime,
                    COALESCE(c.EndTime, '20:00') AS EndTime,
                    COALESCE(cr.RoomCode, 'P' || cr.RoomId) AS RoomCode,
                    COALESCE(c.DefaultRoomId, 1) AS RoomId,
                    c.StartDate,
                    c.Status,
                    COUNT(cs.ScheduleId) AS ExistingSessionsCount
                FROM Classes c
                JOIN Courses co ON c.CourseId = co.CourseId
                LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
                LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
                LEFT JOIN ClassSchedules cs ON c.ClassId = cs.ClassId
                GROUP BY c.ClassId
                ORDER BY c.ClassId ASC;";

            var classes = (await conn.QueryAsync<dynamic>(sql)).ToList();

            int stt = 1;
            foreach (var c in classes)
            {
                int classId = Convert.ToInt32(c.ClassId);
                string code = (string)c.ClassCode;
                string course = (string)c.CourseName;
                string teacher = (string)c.TeacherName;
                int teacherId = Convert.ToInt32(c.TeacherId);
                string pattern = (string)c.SchedulePattern;
                string startTime = (string)c.StartTime;
                string endTime = (string)c.EndTime;
                string room = (string)c.RoomCode;
                int roomId = Convert.ToInt32(c.RoomId);
                string startDateRaw = (string)c.StartDate;
                int totalSessions = Convert.ToInt32(c.TotalSessions);
                int existingCount = Convert.ToInt32(c.ExistingSessionsCount);
                string rawStatus = (string)c.Status;

                // Format ngày hiển thị
                string startDateDisplay = startDateRaw.Split('T')[0];
                if (DateTime.TryParse(startDateDisplay, out var dt))
                {
                    startDateDisplay = dt.ToString("dd/MM/yyyy");
                }

                // Format lịch định kỳ: T3,T6 -> T3 / T6
                string scheduleDisplay = pattern.Replace(",", " / ");
                string timeDisplay = $"{startTime} – {endTime}";

                // Format số buổi
                string sessionsDisplay = existingCount == 0 
                    ? $"{totalSessions} buổi (Chưa xếp)" 
                    : $"{totalSessions} buổi ({existingCount}/{totalSessions})";

                // Format trạng thái
                string statusDisplay = rawStatus switch
                {
                    "InProgress" => "Đang học",
                    "OpenForEnrollment" => "Đang tuyển sinh",
                    "Planning" => "Sắp mở",
                    "Completed" => "Đã kết thúc",
                    _ => rawStatus
                };

                dgvClasses.Rows.Add(
                    classId.ToString(),
                    totalSessions.ToString(),
                    existingCount.ToString(),
                    roomId.ToString(),
                    teacherId.ToString(),
                    pattern,
                    startTime,
                    endTime,
                    startDateRaw,
                    stt.ToString(),
                    code,
                    course,
                    teacher,
                    scheduleDisplay,
                    timeDisplay,
                    room,
                    startDateDisplay,
                    sessionsDisplay,
                    statusDisplay
                );
                stt++;
            }

            if (dgvClasses.RowCount > 0)
            {
                dgvClasses.Rows[0].Selected = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        dgvClasses.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                await ConfirmCreateAsync();
            }
        };

        rbAutoStandard.CheckedChanged += (s, e) =>
        {
            if (rbAutoStandard.Checked)
            {
                nudExtraCount.Enabled = false;
                txtExtraTopic.Enabled = false;
                btnCreateSessions.Text = "+ Tạo buổi học cho lớp";
            }
        };

        rbExtraSessions.CheckedChanged += (s, e) =>
        {
            if (rbExtraSessions.Checked)
            {
                nudExtraCount.Enabled = true;
                txtExtraTopic.Enabled = true;
                nudExtraCount.Focus();
                btnCreateSessions.Text = "+ Thêm buổi phát sinh";
            }
        };

        dgvClasses.SelectionChanged += (s, e) =>
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                var row = dgvClasses.SelectedRows[0];
                int existing = 0;
                int total = 0;
                if (int.TryParse(row.Cells["colExistingSessions"].Value?.ToString(), out int exVal)) existing = exVal;
                if (int.TryParse(row.Cells["colTotalSessions"].Value?.ToString(), out int totVal)) total = totVal;

                if (existing >= total && total > 0)
                {
                    rbExtraSessions.Checked = true;
                }
            }
        };

        txtSearch.TextChanged += (s, e) =>
        {
            string kw = txtSearch.Text.Trim().ToLowerInvariant();
            foreach (DataGridViewRow row in dgvClasses.Rows)
            {
                if (row.IsNewRow) continue;
                string code = row.Cells["colCode"].Value?.ToString()?.ToLowerInvariant() ?? "";
                string course = row.Cells["colCourse"].Value?.ToString()?.ToLowerInvariant() ?? "";
                string teacher = row.Cells["colTeacher"].Value?.ToString()?.ToLowerInvariant() ?? "";
                string room = row.Cells["colRoom"].Value?.ToString()?.ToLowerInvariant() ?? "";

                bool match = string.IsNullOrEmpty(kw) || code.Contains(kw) || course.Contains(kw) || teacher.Contains(kw) || room.Contains(kw);
                row.Visible = match;
            }
        };
    }

    private async Task ConfirmCreateAsync()
    {
        if (dgvClasses.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn 1 lớp học từ danh sách để tạo buổi học!", "Chưa chọn lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var row = dgvClasses.SelectedRows[0];
        int classId = Convert.ToInt32(row.Cells["colClassId"].Value);
        string code = row.Cells["colCode"].Value?.ToString() ?? "";
        string course = row.Cells["colCourse"].Value?.ToString() ?? "";
        string teacher = row.Cells["colTeacher"].Value?.ToString() ?? "";
        int teacherId = Convert.ToInt32(row.Cells["colTeacherId"].Value);
        string room = row.Cells["colRoom"].Value?.ToString() ?? "";
        int roomId = Convert.ToInt32(row.Cells["colRoomId"].Value);
        string pattern = row.Cells["colSchedulePattern"].Value?.ToString() ?? "T3,T6";
        string startTime = row.Cells["colStartTime"].Value?.ToString() ?? "18:00";
        string endTime = row.Cells["colEndTime"].Value?.ToString() ?? "20:00";
        string startDateRaw = row.Cells["colStartDateRaw"].Value?.ToString() ?? "2026-11-01";
        int totalSessions = Convert.ToInt32(row.Cells["colTotalSessions"].Value);
        int existingCount = Convert.ToInt32(row.Cells["colExistingSessions"].Value);

        SelectedClassCode = code;
        SelectedCourseName = course;

        // Phân tích các thứ trong tuần được chọn
        var targetDays = ParseDaysOfWeek(pattern);
        if (targetDays.Count == 0)
        {
            targetDays = new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday };
        }

        DateTime startDate;
        if (!DateTime.TryParse(startDateRaw.Split('T')[0], out startDate))
        {
            startDate = DateTime.Today;
        }

        try
        {
            using var conn = DatabaseConfig.GetConnection();

            if (rbExtraSessions.Checked)
            {
                // ==================== CHẾ ĐỘ BUỔI PHÁT SINH / BỔ SUNG ====================
                int extraCount = (int)nudExtraCount.Value;
                if (extraCount <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số buổi muốn bổ sung lớn hơn 0!", "Số buổi không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string customTopic = string.IsNullOrWhiteSpace(txtExtraTopic.Text)
                    ? "Bổ trợ kiến thức & ôn tập chuyên đề"
                    : txtExtraTopic.Text.Trim();

                // Lấy số thứ tự buổi học lớn nhất và ngày của buổi học cuối cùng
                int maxSessionNum = await conn.ExecuteScalarAsync<int>(
                    "SELECT COALESCE(MAX(SessionNumber), 0) FROM ClassSchedules WHERE ClassId = @ClassId;",
                    new { ClassId = classId });

                string? lastDateStr = await conn.ExecuteScalarAsync<string?>(
                    "SELECT MAX(Date) FROM ClassSchedules WHERE ClassId = @ClassId;",
                    new { ClassId = classId });

                DateTime currentScanDate;
                if (!string.IsNullOrEmpty(lastDateStr) && DateTime.TryParse(lastDateStr.Split('T')[0], out var lastDate))
                {
                    currentScanDate = lastDate.AddDays(1);
                }
                else
                {
                    currentScanDate = startDate;
                }

                var newExtraSessions = new List<(int SessionNum, string Date, string Topic)>();
                DateTime lastCreatedDate = currentScanDate;
                int generated = 0;

                while (generated < extraCount)
                {
                    if (targetDays.Contains(currentScanDate.DayOfWeek))
                    {
                        int sNum = maxSessionNum + generated + 1;
                        string topic = $"Buổi {sNum} (Phát sinh): {customTopic}";
                        newExtraSessions.Add((sNum, currentScanDate.ToString("yyyy-MM-dd"), topic));
                        lastCreatedDate = currentScanDate;
                        generated++;
                    }
                    currentScanDate = currentScanDate.AddDays(1);
                }

                string firstDateStr = newExtraSessions.Count > 0 ? DateTime.Parse(newExtraSessions[0].Date).ToString("dd/MM/yyyy") : "";
                string lastDateDisplay = lastCreatedDate.ToString("dd/MM/yyyy");

                var askConfirm = MessageBox.Show(
                    $"XÁC NHẬN TẠO BUỔI HỌC PHÁT SINH CHO LỚP {code}:\n\n" +
                    $"• Khóa học: {course}\n" +
                    $"• Số buổi bổ sung: {extraCount} buổi (Từ Buổi {maxSessionNum + 1} đến Buổi {maxSessionNum + extraCount})\n" +
                    $"• Thời gian diễn ra: Từ {firstDateStr} đến {lastDateDisplay}\n" +
                    $"• Lịch định kỳ: {pattern.Replace(",", " / ")} ({startTime} – {endTime})\n" +
                    $"• Phòng học: {room} | Giáo viên: {teacher}\n" +
                    $"• Nội dung/Chủ đề: {customTopic}\n\n" +
                    "Bạn có muốn tiến hành tạo lịch học phát sinh này?",
                    "Xác nhận tạo buổi học phát sinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (askConfirm != DialogResult.Yes) return;

                btnCreateSessions.Enabled = false;

                using var trans = conn.BeginTransaction();
                try
                {
                    foreach (var s in newExtraSessions)
                    {
                        await conn.ExecuteAsync(@"
                            INSERT INTO ClassSchedules (ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, IsAttendanceLocked, Topic)
                            VALUES (@ClassId, @SessionNum, @Date, @StartTime, @EndTime, @RoomId, @TeacherId, 0, @Topic);",
                            new
                            {
                                ClassId = classId,
                                SessionNum = s.SessionNum,
                                Date = s.Date,
                                StartTime = startTime,
                                EndTime = endTime,
                                RoomId = roomId,
                                TeacherId = teacherId,
                                Topic = s.Topic
                            }, trans);
                    }

                    // Cập nhật EndDate của lớp nếu ngày cuối cùng vượt quá EndDate hiện tại
                    await conn.ExecuteAsync(@"
                        UPDATE Classes 
                        SET EndDate = CASE WHEN EndDate IS NULL OR @EndDate > EndDate THEN @EndDate ELSE EndDate END,
                            UpdatedAt = CURRENT_TIMESTAMP 
                        WHERE ClassId = @ClassId;",
                        new { EndDate = lastCreatedDate.ToString("yyyy-MM-dd"), ClassId = classId }, trans);

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }

                string successMsg = $"ĐÃ TẠO THÀNH CÔNG {extraCount} BUỔI HỌC PHÁT SINH!\n\n" +
                                   $"• Lớp: {code} ({course})\n" +
                                   $"• Tổng số buổi sau bổ sung: {maxSessionNum + extraCount} buổi\n" +
                                   $"• Các buổi mới: Buổi {maxSessionNum + 1} ➔ Buổi {maxSessionNum + extraCount}\n" +
                                   $"• Thời gian diễn ra: Từ {firstDateStr} đến {lastDateDisplay}\n" +
                                   $"• Giảng viên: {teacher} | Phòng: {room}";

                MessageBox.Show(successMsg, "Tạo buổi học phát sinh thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            // ==================== CHẾ ĐỘ THEO KHUNG CHUẨN KHÓA HỌC ====================
            int startSessionNum = 1;
            DateTime currentScanDateStd = startDate;

            if (existingCount >= totalSessions)
            {
                var ask = MessageBox.Show(
                    $"Lớp '{code}' hiện đã có đủ {existingCount}/{totalSessions} buổi học theo khung chuẩn.\n\n" +
                    "• Để thêm các buổi học ngoài khung (học bù, bổ trợ chuyên đề), vui lòng chọn chế độ 'Buổi học phát sinh / bổ sung' ở góc dưới và nhập số buổi muốn bổ sung.\n\n" +
                    "• Bạn có muốn XÓA TOÀN BỘ các buổi học chưa khóa và sinh lại từ ngày khai giảng không?",
                    "Lớp đã có đủ lịch học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask != DialogResult.Yes)
                {
                    rbExtraSessions.Checked = true;
                    nudExtraCount.Focus();
                    return;
                }

                // Xóa các buổi học chưa khóa sổ
                await conn.ExecuteAsync(
                    "DELETE FROM ClassSchedules WHERE ClassId = @ClassId AND IsAttendanceLocked = 0;",
                    new { ClassId = classId });

                existingCount = await conn.ExecuteScalarAsync<int>(
                    "SELECT COUNT(*) FROM ClassSchedules WHERE ClassId = @ClassId;",
                    new { ClassId = classId });

                startSessionNum = existingCount + 1;
            }
            else if (existingCount > 0)
            {
                var ask = MessageBox.Show(
                    $"Lớp '{code}' hiện đã có {existingCount} buổi học.\n\n" +
                    $"Hệ thống sẽ tiếp tục sinh thêm {totalSessions - existingCount} buổi còn lại để đạt đủ {totalSessions} buổi.\n" +
                    "Bạn có muốn tiếp tục?",
                    "Tiếp tục sinh lịch học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask != DialogResult.Yes) return;

                startSessionNum = existingCount + 1;

                // Tìm ngày của buổi học cuối cùng hiện có để sinh tiếp từ ngày sau đó
                string? lastDateStr = await conn.ExecuteScalarAsync<string?>(
                    "SELECT MAX(Date) FROM ClassSchedules WHERE ClassId = @ClassId;",
                    new { ClassId = classId });

                if (!string.IsNullOrEmpty(lastDateStr) && DateTime.TryParse(lastDateStr.Split('T')[0], out var lastDate))
                {
                    currentScanDateStd = lastDate.AddDays(1);
                }
            }

            // Sinh các buổi học chuẩn
            btnCreateSessions.Enabled = false;
            var newSessions = new List<(int SessionNum, string Date, string Topic)>();
            DateTime lastCreatedDateStd = currentScanDateStd;

            while (startSessionNum <= totalSessions)
            {
                if (targetDays.Contains(currentScanDateStd.DayOfWeek))
                {
                    string topic = $"Buổi {startSessionNum}: Bài học chương trình {course}";
                    newSessions.Add((startSessionNum, currentScanDateStd.ToString("yyyy-MM-dd"), topic));
                    lastCreatedDateStd = currentScanDateStd;
                    startSessionNum++;
                }
                currentScanDateStd = currentScanDateStd.AddDays(1);
            }

            // Thực hiện ghi vào CSDL trong Transaction
            using var transStd = conn.BeginTransaction();
            try
            {
                foreach (var s in newSessions)
                {
                    await conn.ExecuteAsync(@"
                        INSERT INTO ClassSchedules (ClassId, SessionNumber, Date, StartTime, EndTime, RoomId, TeacherId, IsAttendanceLocked, Topic)
                        VALUES (@ClassId, @SessionNum, @Date, @StartTime, @EndTime, @RoomId, @TeacherId, 0, @Topic);",
                        new
                        {
                            ClassId = classId,
                            SessionNum = s.SessionNum,
                            Date = s.Date,
                            StartTime = startTime,
                            EndTime = endTime,
                            RoomId = roomId,
                            TeacherId = teacherId,
                            Topic = s.Topic
                        }, transStd);
                }

                // Cập nhật ngày kết thúc dự kiến của lớp
                await conn.ExecuteAsync(
                    "UPDATE Classes SET EndDate = @EndDate, UpdatedAt = CURRENT_TIMESTAMP WHERE ClassId = @ClassId;",
                    new { EndDate = lastCreatedDateStd.ToString("yyyy-MM-dd"), ClassId = classId }, transStd);

                transStd.Commit();
            }
            catch
            {
                transStd.Rollback();
                throw;
            }

            string firstDateStrStd = newSessions.Count > 0 ? DateTime.Parse(newSessions[0].Date).ToString("dd/MM/yyyy") : "";
            string lastDateDisplayStd = lastCreatedDateStd.ToString("dd/MM/yyyy");

            string message = $"ĐÃ TẠO LỊCH HỌC THÀNH CÔNG!\n\n" +
                             $"• Lớp: {code} ({course})\n" +
                             $"• Giáo viên: {teacher}\n" +
                             $"• Phòng học: {room}\n" +
                             $"• Lịch định kỳ: {pattern.Replace(",", " / ")} ({startTime} – {endTime})\n" +
                             $"• Số buổi đã tạo: {newSessions.Count} buổi học\n" +
                             $"• Thời gian diễn ra: Từ {firstDateStrStd} đến {lastDateDisplayStd}";

            MessageBox.Show(message, "Tạo buổi học thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tạo buổi học vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnCreateSessions.Enabled = true;
        }
    }

    private static List<DayOfWeek> ParseDaysOfWeek(string pattern)
    {
        var result = new List<DayOfWeek>();
        var tokens = pattern.ToUpper().Split(new[] { ',', '/', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var t in tokens)
        {
            switch (t.Trim())
            {
                case "T2":
                case "THU2":
                    result.Add(DayOfWeek.Monday);
                    break;
                case "T3":
                case "THU3":
                    result.Add(DayOfWeek.Tuesday);
                    break;
                case "T4":
                case "THU4":
                    result.Add(DayOfWeek.Wednesday);
                    break;
                case "T5":
                case "THU5":
                    result.Add(DayOfWeek.Thursday);
                    break;
                case "T6":
                case "THU6":
                    result.Add(DayOfWeek.Friday);
                    break;
                case "T7":
                case "THU7":
                    result.Add(DayOfWeek.Saturday);
                    break;
                case "CN":
                case "CHUNHAT":
                    result.Add(DayOfWeek.Sunday);
                    break;
            }
        }

        return result;
    }
}
