using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ClassAttendanceDialog : Form
{
    private readonly int _classId = 1;
    private readonly string _classCode = "IELTS-2026-K12";
    private readonly string _courseName = "IELTS Foundation";
    private readonly string _teacher = "Thầy John Smith";
    private readonly string _room = "Phòng P.201";
    private int _currentScheduleId = 0;

    public ClassAttendanceDialog() : this(1, "IELTS-2026-K12", "IELTS Foundation", "Thầy John Smith", "Phòng P.201")
    {
    }

    public ClassAttendanceDialog(string classCode, string courseName, string teacher, string room) 
        : this(1, classCode, courseName, teacher, room)
    {
    }

    public ClassAttendanceDialog(int classId, string classCode, string courseName, string teacher, string room)
    {
        InitializeComponent();

        _classId = classId > 0 ? classId : 1;
        _classCode = string.IsNullOrEmpty(classCode) ? "IELTS-2026-K12" : classCode;
        _courseName = string.IsNullOrEmpty(courseName) ? "IELTS Foundation" : courseName;
        _teacher = string.IsNullOrEmpty(teacher) ? "Thầy John Smith" : teacher;
        _room = string.IsNullOrEmpty(room) ? "Phòng P.201" : room;

        SetupHeader();
        SetupSessionsGrid();
        SetupStudentCheckGrid();
        SetupMatrixGrid();

        _ = LoadSessionsDataAsync();
        LoadMatrixData();

        WireEvents();
        SwitchMainTab(0);
    }

    private void SetupHeader()
    {
        Text = $"Điểm danh lớp · {_classCode}";
        lblTitle.Text = $"{_classCode} · {_courseName}";
        lblSub.Text = $"Giáo viên: {_teacher} | Phòng: {_room} | Sĩ số: 20 học viên";
    }

    private void SetupSessionsGrid()
    {
        dgvSessions.AutoGenerateColumns = false;
        dgvSessions.Columns.Clear();
        dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSessions.MultiSelect = false;
        dgvSessions.ReadOnly = true;
        dgvSessions.RowHeadersVisible = false;
        dgvSessions.AllowUserToAddRows = false;
        dgvSessions.ScrollBars = ScrollBars.Both;

        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colScheduleId", Visible = false });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSessionNum", HeaderText = "Buổi", Width = 80, MinimumWidth = 70, FillWeight = 8F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Ngày học", Width = 110, MinimumWidth = 100, FillWeight = 11F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDayTime", HeaderText = "Thứ & Giờ", Width = 150, MinimumWidth = 135, FillWeight = 15F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTopic", HeaderText = "Chủ đề bài học", MinimumWidth = 170, FillWeight = 24F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPresent", HeaderText = "Có mặt / Sĩ số", Width = 125, MinimumWidth = 110, FillWeight = 12F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRate", HeaderText = "Chuyên cần", Width = 110, MinimumWidth = 95, FillWeight = 11F });
        dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", Width = 125, MinimumWidth = 110, FillWeight = 12F });

        var btnCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "Điểm danh / Sửa",
            UseColumnTextForButtonValue = true,
            Width = 135,
            MinimumWidth = 120,
            FillWeight = 13F
        };
        dgvSessions.Columns.Add(btnCol);

        dgvSessions.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvSessions.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val.Contains("Đã điểm danh"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Xanh lá
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139); // Xám
                }
            }
        };
    }

    private void SetupStudentCheckGrid()
    {
        dgvStudentCheck.AutoGenerateColumns = false;
        dgvStudentCheck.Columns.Clear();
        dgvStudentCheck.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStudentCheck.MultiSelect = false;
        dgvStudentCheck.ReadOnly = false;
        dgvStudentCheck.RowHeadersVisible = false;
        dgvStudentCheck.AllowUserToAddRows = false;
        dgvStudentCheck.ScrollBars = ScrollBars.Both;

        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudentId", Visible = false });
        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 5F, ReadOnly = true });
        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", Width = 105, MinimumWidth = 95, FillWeight = 11F, ReadOnly = true });
        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 180, FillWeight = 25F, ReadOnly = true });
        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Số điện thoại", Width = 125, MinimumWidth = 115, FillWeight = 13F, ReadOnly = true });

        var cboCol = new DataGridViewComboBoxColumn
        {
            Name = "colStatus",
            HeaderText = "Trạng thái điểm danh",
            Width = 180,
            MinimumWidth = 160,
            FillWeight = 19F,
            FlatStyle = FlatStyle.Flat
        };
        cboCol.Items.AddRange(new object[] { "Có mặt", "Vắng có phép", "Vắng không phép" });
        dgvStudentCheck.Columns.Add(cboCol);

        dgvStudentCheck.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colNote",
            HeaderText = "Ghi chú học vụ",
            MinimumWidth = 180,
            FillWeight = 27F
        });

        dgvStudentCheck.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvStudentCheck.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "Có mặt")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else if (val == "Vắng có phép")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else if (val == "Vắng không phép")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        };
    }

    private void SetupMatrixGrid()
    {
        dgvMatrix.AutoGenerateColumns = false;
        dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        dgvMatrix.Columns.Clear();
        dgvMatrix.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMatrix.MultiSelect = false;
        dgvMatrix.ReadOnly = true;
        dgvMatrix.RowHeadersVisible = false;
        dgvMatrix.AllowUserToAddRows = false;
        dgvMatrix.ScrollBars = ScrollBars.Both;

        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatStt", HeaderText = "STT", Width = 45, Frozen = true });
        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatCode", HeaderText = "Mã HV", Width = 90, Frozen = true });
        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatName", HeaderText = "Họ và tên", Width = 165, Frozen = true });

        // 24 Buổi học
        for (int i = 1; i <= 24; i++)
        {
            dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = $"colB{i}",
                HeaderText = $"B{i}",
                Width = 38
            });
        }

        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPresentCount", HeaderText = "Có mặt", Width = 75 });
        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAbsentCount", HeaderText = "Vắng", Width = 65 });
        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatRate", HeaderText = "Tỷ lệ", Width = 80 });
        dgvMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatEval", HeaderText = "Đánh giá chuyên cần", Width = 150 });

        dgvMatrix.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "✓")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (val == "P")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (val == "K")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        };
    }

    private async Task LoadSessionsDataAsync()
    {
        try
        {
            dgvSessions.Rows.Clear();

            using var conn = DatabaseConfig.GetConnection();

            // Lấy sĩ số thực tế của lớp
            int totalStudents = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(*) FROM Enrollments WHERE ClassId = @ClassId;", new { ClassId = _classId });
            if (totalStudents == 0) totalStudents = 20; // fallback mặc định nếu lớp mới tạo chưa có HV

            lblSub.Text = $"Giáo viên: {_teacher} | Phòng: {_room} | Sĩ số: {totalStudents} học viên";

            // Lấy danh sách các buổi học thật của lớp
            var query = @"
                SELECT 
                    cs.ScheduleId,
                    cs.SessionNumber,
                    cs.Date,
                    cs.StartTime,
                    cs.EndTime,
                    COALESCE(cs.Topic, 'Chưa có chủ đề') AS Topic,
                    cs.IsAttendanceLocked,
                    COUNT(DISTINCT ar.AttendanceId) AS TotalAttRecords,
                    COUNT(DISTINCT CASE WHEN ar.Status = 'Present' THEN ar.AttendanceId END) AS PresentCount
                FROM ClassSchedules cs
                LEFT JOIN AttendanceRecords ar ON cs.ScheduleId = ar.ScheduleId
                WHERE cs.ClassId = @ClassId
                GROUP BY cs.ScheduleId
                ORDER BY cs.SessionNumber ASC;";

            var sessions = (await conn.QueryAsync<dynamic>(query, new { ClassId = _classId })).ToList();

            if (sessions.Count == 0)
            {
                // Nếu chưa có lịch trong CSDL, thông báo hoặc để trống
                return;
            }

            foreach (var s in sessions)
            {
                int scheduleId = (int)s.ScheduleId;
                int sessionNum = (int)s.SessionNumber;
                string dateStr = ((string)s.Date).Split('T')[0];

                // Xác định thứ trong tuần
                string dayOfWeek = "";
                if (DateTime.TryParse(dateStr, out var parsedDate))
                {
                    dayOfWeek = parsedDate.DayOfWeek switch
                    {
                        DayOfWeek.Monday => "Thứ 2",
                        DayOfWeek.Tuesday => "Thứ 3",
                        DayOfWeek.Wednesday => "Thứ 4",
                        DayOfWeek.Thursday => "Thứ 5",
                        DayOfWeek.Friday => "Thứ 6",
                        DayOfWeek.Saturday => "Thứ 7",
                        DayOfWeek.Sunday => "Chủ nhật",
                        _ => ""
                    };
                    dateStr = parsedDate.ToString("dd/MM/yyyy");
                }

                string dayTime = $"{dayOfWeek} · {s.StartTime}–{s.EndTime}".Trim(' ', '·');
                string topic = (string)s.Topic;

                int totalAtt = Convert.ToInt32(s.TotalAttRecords);
                int present = Convert.ToInt32(s.PresentCount);
                bool isLocked = Convert.ToInt32(s.IsAttendanceLocked) == 1;

                string presentRatio = totalAtt > 0 ? $"{present} / {totalStudents}" : $"-- / {totalStudents}";
                string rateStr = "--";
                string statusStr = "Chưa điểm danh";

                if (totalAtt > 0 || isLocked)
                {
                    double rate = totalStudents > 0 ? (present * 100.0 / totalStudents) : 0;
                    rateStr = $"{rate:0.#}%";
                    statusStr = isLocked ? "🔒 Đã khóa sổ" : "Đã điểm danh";
                }

                dgvSessions.Rows.Add(
                    scheduleId.ToString(),
                    $"Buổi {sessionNum}",
                    dateStr,
                    dayTime,
                    topic,
                    presentRatio,
                    rateStr,
                    statusStr,
                    "Điểm danh / Sửa"
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải lịch học từ CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task LoadStudentCheckDataAsync(int scheduleId, string sessionNum, string sessionDate)
    {
        lblCurrentSessionTitle.Text = $"ĐIỂM DANH {sessionNum.ToUpper()} · {sessionDate}";
        lblSaveStatus.Visible = false;
        dgvStudentCheck.Rows.Clear();

        try
        {
            using var conn = DatabaseConfig.GetConnection();

            // Lấy danh sách học viên đã đăng ký lớp này
            var students = (await conn.QueryAsync<dynamic>(@"
                SELECT s.StudentId, s.StudentCode, s.FullName, s.Phone
                FROM Enrollments e
                JOIN Students s ON e.StudentId = s.StudentId
                WHERE e.ClassId = @ClassId
                ORDER BY s.FullName ASC;", new { ClassId = _classId })).ToList();

            // Lấy dữ liệu điểm danh đã có cho buổi này
            var existingRecords = (await conn.QueryAsync<dynamic>(@"
                SELECT StudentId, Status, Note
                FROM AttendanceRecords
                WHERE ScheduleId = @ScheduleId;", new { ScheduleId = scheduleId })).ToList();

            // Tạo dict tra cứu nhanh theo StudentId
            var existingDict = existingRecords.ToDictionary(
                r => (int)r.StudentId,
                r => new { Status = (string)r.Status, Note = (string?)r.Note });

            int stt = 1;
            foreach (var student in students)
            {
                int sid = (int)student.StudentId;
                string code = (string)student.StudentCode;
                string name = (string)student.FullName;
                string phone = (string?)student.Phone ?? "";

                string displayStatus = "Có mặt"; // mặc định
                string? note = null;

                if (existingDict.TryGetValue(sid, out var rec))
                {
                    displayStatus = rec.Status switch
                    {
                        "Present" => "Có mặt",
                        "Excused" => "Vắng có phép",
                        "Absent"  => "Vắng không phép",
                        _         => "Có mặt"
                    };
                    note = rec.Note;
                }

                dgvStudentCheck.Rows.Add(sid.ToString(), stt.ToString(), code, name, phone, displayStatus, note ?? "");
                stt++;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách học viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void LoadMatrixData()
    {
        dgvMatrix.Rows.Clear();

        AddMatrixRow("1", "HV-0241", "Nguyễn Minh Anh", new[] { "✓", "✓", "✓", "✓", "✓", "✓", "✓", "✓" }, 8, 0, "100%", "✓ Đủ ĐK thi");
        AddMatrixRow("2", "HV-0237", "Lê Hoàng Nam", new[] { "✓", "✓", "✓", "✓", "✓", "✓", "✓", "✓" }, 8, 0, "100%", "✓ Đủ ĐK thi");
        AddMatrixRow("3", "HV-0238", "Phạm Khánh Linh", new[] { "✓", "✓", "✓", "✓", "✓", "✓", "✓", "✓" }, 8, 0, "100%", "✓ Đủ ĐK thi");
        AddMatrixRow("4", "HV-0240", "Vũ Quang Huy", new[] { "✓", "✓", "✓", "P", "✓", "✓", "✓", "P" }, 6, 2, "75,0%", "✓ Đạt yêu cầu");
        AddMatrixRow("5", "HV-0242", "Đặng Thị Thảo", new[] { "✓", "P", "K", "P", "✓", "K", "✓", "K" }, 4, 4, "50,0%", "⚠ Cảnh báo vắng 4 buổi");
        AddMatrixRow("6", "HV-0245", "Trần Bảo Long", new[] { "✓", "✓", "✓", "✓", "✓", "✓", "✓", "✓" }, 8, 0, "100%", "✓ Đủ ĐK thi");
        AddMatrixRow("7", "HV-0246", "Hoàng Ngọc Mai", new[] { "✓", "✓", "P", "✓", "✓", "✓", "✓", "✓" }, 7, 1, "87,5%", "✓ Đạt yêu cầu");
        AddMatrixRow("8", "HV-0247", "Đỗ Quốc Cường", new[] { "✓", "✓", "✓", "✓", "✓", "P", "✓", "✓" }, 7, 1, "87,5%", "✓ Đạt yêu cầu");
    }

    private void AddMatrixRow(string stt, string code, string name, string[] pastSessions, int present, int absent, string rate, string eval)
    {
        var rowData = new object[31];
        rowData[0] = stt;
        rowData[1] = code;
        rowData[2] = name;

        // B1 -> B8
        for (int i = 0; i < 8; i++)
        {
            rowData[3 + i] = (i < pastSessions.Length) ? pastSessions[i] : "-";
        }
        // B9 -> B24 (chưa diễn ra)
        for (int i = 8; i < 24; i++)
        {
            rowData[3 + i] = "-";
        }

        rowData[27] = $"{present} buổi";
        rowData[28] = $"{absent} buổi";
        rowData[29] = rate;
        rowData[30] = eval;

        dgvMatrix.Rows.Add(rowData);
    }

    private void WireEvents()
    {
        btnClose.Click += (s, e) => Close();

        btnTabSessions.Click += (s, e) => SwitchMainTab(0);
        btnTabOverview.Click += (s, e) => SwitchMainTab(1);

        dgvSessions.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvSessions.Columns[e.ColumnIndex].Name == "colAction")
            {
                OpenSessionCheck(e.RowIndex);
            }
        };

        dgvSessions.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenSessionCheck(e.RowIndex);
            }
        };

        btnBackToSessions.Click += (s, e) =>
        {
            pnlCheckSession.Visible = false;
            pnlSessionsList.Visible = true;
            dgvSessions.PerformLayout();
        };

        btnMarkAllPresent.Click += (s, e) =>
        {
            foreach (DataGridViewRow row in dgvStudentCheck.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["colStatus"].Value = "Có mặt";
            }
        };

        btnSaveAttendance.Click += async (s, e) =>
        {
            if (_currentScheduleId <= 0)
            {
                MessageBox.Show("Vui lòng chọn một buổi học hợp lệ trước khi lưu điểm danh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var records = new List<(int StudentId, AttendanceStatus Status, string? Note)>();
            foreach (DataGridViewRow row in dgvStudentCheck.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colStudentId"].Value == null) continue;

                if (!int.TryParse(row.Cells["colStudentId"].Value.ToString(), out int studentId))
                    continue;

                string statusVn = row.Cells["colStatus"].Value?.ToString() ?? "Có mặt";
                string? note = row.Cells["colNote"].Value?.ToString()?.Trim();
                if (string.IsNullOrWhiteSpace(note)) note = null;

                AttendanceStatus status = statusVn switch
                {
                    "Có mặt" => AttendanceStatus.Present,
                    "Vắng có phép" => AttendanceStatus.Excused,
                    "Vắng không phép" => AttendanceStatus.Absent,
                    _ => AttendanceStatus.Present
                };

                records.Add((studentId, status, note));
            }

            if (records.Count == 0)
            {
                MessageBox.Show("Không có học viên nào để lưu điểm danh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnSaveAttendance.Enabled = false;
                var service = new AttendanceService();
                bool ok = await service.SaveAttendanceBatchAsync(_currentScheduleId, records);

                if (ok)
                {
                    lblSaveStatus.Text = "✓ Đã lưu thay đổi";
                    lblSaveStatus.Visible = true;
                    MessageBox.Show($"Đã lưu kết quả điểm danh cho {records.Count} học viên thành công!", "Lưu điểm danh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadSessionsDataAsync();
                }
                else
                {
                    MessageBox.Show("Không thể lưu điểm danh vào cơ sở dữ liệu. Vui lòng thử lại.", "Lỗi lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu điểm danh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSaveAttendance.Enabled = true;
            }
        };
    }

    private void OpenSessionCheck(int rowIndex)
    {
        var row = dgvSessions.Rows[rowIndex];
        int scheduleId = 1;
        if (row.Cells["colScheduleId"].Value != null)
        {
            int.TryParse(row.Cells["colScheduleId"].Value.ToString(), out scheduleId);
        }
        _currentScheduleId = scheduleId;

        string sessionNum = row.Cells["colSessionNum"].Value?.ToString() ?? "Buổi 1";
        string sessionDate = row.Cells["colDate"].Value?.ToString() ?? "";

        _ = LoadStudentCheckDataAsync(scheduleId, sessionNum, sessionDate);

        pnlSessionsList.Visible = false;
        pnlCheckSession.Visible = true;
        pnlCheckSession.BringToFront();
        dgvStudentCheck.PerformLayout();
    }

    private void SwitchMainTab(int index)
    {
        btnTabSessions.Font = index == 0 ? new Font("Segoe UI", 9.5F, FontStyle.Bold) : new Font("Segoe UI", 9.5F);
        btnTabSessions.ForeColor = index == 0 ? Color.FromArgb(24, 119, 242) : Color.FromArgb(108, 117, 125);
        btnTabSessions.Text = index == 0 ? "▬ Danh sách buổi học" : "Danh sách buổi học";

        btnTabOverview.Font = index == 1 ? new Font("Segoe UI", 9.5F, FontStyle.Bold) : new Font("Segoe UI", 9.5F);
        btnTabOverview.ForeColor = index == 1 ? Color.FromArgb(24, 119, 242) : Color.FromArgb(108, 117, 125);
        btnTabOverview.Text = index == 1 ? "▬ Tổng quan chuyên cần cả lớp" : "Tổng quan chuyên cần cả lớp";

        cardSessionsView.Visible = (index == 0);
        cardOverviewView.Visible = (index == 1);

        if (index == 0)
        {
            cardSessionsView.BringToFront();
            pnlSessionsList.Visible = true;
            pnlCheckSession.Visible = false;
            dgvSessions.PerformLayout();
        }
        else
        {
            cardOverviewView.BringToFront();
            dgvMatrix.PerformLayout();
        }

        AdjustDialogLayout();
    }

    private void AdjustDialogLayout()
    {
        if (pnlBody == null || cardSessionsView == null || cardOverviewView == null) return;

        int margin = 24;
        int cardWidth = Math.Max(500, pnlBody.ClientSize.Width - (margin * 2));
        int cardHeight = Math.Max(250, pnlBody.ClientSize.Height - (margin * 2));

        cardSessionsView.SetBounds(margin, margin, cardWidth, cardHeight);
        cardOverviewView.SetBounds(margin, margin, cardWidth, cardHeight);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustDialogLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustDialogLayout();
    }
}
