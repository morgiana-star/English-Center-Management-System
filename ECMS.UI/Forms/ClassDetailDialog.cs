using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ClassDetailDialog : Form
{
    private readonly string _classCode = string.Empty;
    private readonly string _courseName = string.Empty;
    private readonly string _teacher = string.Empty;

    public ClassDetailDialog() : this("IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh")
    {
    }

    public ClassDetailDialog(string classCode = "IELTS-F01", string courseName = "IELTS Foundation", string teacher = "")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _classCode = classCode;
        _courseName = courseName;
        _teacher = teacher;

        SetupHeaderAndInfo();
        WireEvents();
        LoadStudentsTab();
    }

    private void SetupHeaderAndInfo()
    {
        Text = $"Chi tiết lớp học · {_classCode}";
        lblTitle.Text = $"{_classCode} · {_courseName}";
    }

    private void WireEvents()
    {
        btnAddStudent.Click += (s, e) =>
        {
            using var dlg = new SelectStudentsForClassDialog(_classCode);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show($"Đã thêm {dlg.SelectedStudentCodes.Count} học viên vào lớp {_classCode}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentsTab();
            }
        };

        btnEditClass.Click += (s, e) =>
        {
            using var editDlg = new CreateClassDialog(isEditMode: true);
            editDlg.ShowDialog(this);
        };

        dgvClassStudents.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClassStudents.Columns[e.ColumnIndex].Name == "colAction")
            {
                var row = dgvClassStudents.Rows[e.RowIndex];
                string studentCode = row.Cells["colCode"].Value?.ToString() ?? "HV-0241";
                string fullName = row.Cells["colName"].Value?.ToString() ?? "Nguyễn Minh Anh";
                using var detailDlg = new StudentDetailDialog(fullName, studentCode);
                detailDlg.ShowDialog(this);
            }
        };

        dgvClassStudents.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClassStudents.Columns.Contains("colCode"))
            {
                var row = dgvClassStudents.Rows[e.RowIndex];
                string studentCode = row.Cells["colCode"].Value?.ToString() ?? "HV-0241";
                string fullName = row.Cells["colName"].Value?.ToString() ?? "Nguyễn Minh Anh";
                using var detailDlg = new StudentDetailDialog(fullName, studentCode);
                detailDlg.ShowDialog(this);
            }
        };

        btnTabStudents.Click += (s, e) => { SwitchTab(btnTabStudents); LoadStudentsTab(); };
        btnTabSchedule.Click += (s, e) => { SwitchTab(btnTabSchedule); LoadScheduleTab(); };
        btnTabAttendance.Click += (s, e) => { SwitchTab(btnTabAttendance); LoadAttendanceTab(); };
        btnTabGrades.Click += (s, e) => { SwitchTab(btnTabGrades); LoadGradesTab(); };
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
                if (!tab.Text.StartsWith("▬ "))
                {
                    tab.Text = "▬ " + tab.Text;
                }
            }
            else
            {
                tab.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                tab.ForeColor = Color.FromArgb(108, 117, 125);
                if (tab.Text.StartsWith("▬ "))
                {
                    tab.Text = tab.Text.Substring(2);
                }
            }
        }
    }

    private void LoadStudentsTab()
    {
        dgvClassStudents.DataSource = null;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.ScrollBars = ScrollBars.Both;

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 6F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", Width = 100, MinimumWidth = 90, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 22F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Số điện thoại", Width = 120, MinimumWidth = 110, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", Width = 110, MinimumWidth = 100, FillWeight = 12F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAttendance", HeaderText = "Chuyên cần", Width = 130, MinimumWidth = 110, FillWeight = 13F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTuition", HeaderText = "Học phí", Width = 150, MinimumWidth = 130, FillWeight = 15F });

        var actionCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "Xem hồ sơ",
            UseColumnTextForButtonValue = true,
            Width = 110,
            MinimumWidth = 100,
            FillWeight = 11F
        };
        dgvClassStudents.Columns.Add(actionCol);

        try
        {
            using var conn = DatabaseConfig.GetConnection();
            var classInfo = conn.QueryFirstOrDefault<dynamic>(@"
                SELECT ClassId, MaxStudents FROM Classes WHERE ClassCode = @ClassCode;", new { ClassCode = _classCode });

            if (classInfo != null)
            {
                int classId = (int)classInfo.ClassId;
                int maxStudents = (int)classInfo.MaxStudents;

                var students = conn.Query<dynamic>(@"
                    SELECT s.StudentCode, s.FullName, s.Phone, s.Status
                    FROM Enrollments e
                    JOIN Students s ON e.StudentId = s.StudentId
                    WHERE e.ClassId = @ClassId
                    ORDER BY s.StudentCode ASC;", new { ClassId = classId }).ToList();

                lblStudentListTitle.Text = $"DANH SÁCH HỌC VIÊN TRONG LỚP ({students.Count}/{maxStudents})";

                int stt = 1;
                foreach (var st in students)
                {
                    string code = (string)st.StudentCode;
                    string name = (string)st.FullName;
                    string phone = (string?)st.Phone ?? "0912 345 678";
                    dgvClassStudents.Rows.Add(stt.ToString(), code, name, phone, "Đang học", "100% (24/24)", "Đã hoàn thành", "Xem hồ sơ");
                    stt++;
                }

                if (students.Count > 0)
                {
                    RefreshGridDisplay();
                    return;
                }
            }
        }
        catch { }

        // Fallback sample
        lblStudentListTitle.Text = "DANH SÁCH HỌC VIÊN TRONG LỚP (20/20)";
        dgvClassStudents.Rows.Add("1", "HV-0241", "Nguyễn Minh Anh", "0908 123 456", "Đang học", "87,5% (21/24)", "Còn nợ 1.900.000đ", "Xem hồ sơ");
        dgvClassStudents.Rows.Add("2", "HV-0237", "Lê Hoàng Nam", "0912 345 678", "Đang học", "91,7% (22/24)", "Đã hoàn thành", "Xem hồ sơ");
        RefreshGridDisplay();
    }

    private void LoadScheduleTab()
    {
        lblStudentListTitle.Text = "KẾ HOẠCH LỊCH HỌC CHI TIẾT (24 BUỔI)";
        dgvClassStudents.DataSource = null;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.ScrollBars = ScrollBars.Both;

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Buổi", Width = 75, MinimumWidth = 65, FillWeight = 8F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày học", Width = 110, MinimumWidth = 95, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thứ", Width = 80, MinimumWidth = 70, FillWeight = 8F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ca / Giờ học", Width = 160, MinimumWidth = 140, FillWeight = 15F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", Width = 85, MinimumWidth = 75, FillWeight = 8F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giảng viên", Width = 160, MinimumWidth = 130, FillWeight = 16F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nội dung bài học", MinimumWidth = 180, FillWeight = 24F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", Width = 120, MinimumWidth = 100, FillWeight = 12F });

        string teacherName = string.IsNullOrEmpty(_teacher) ? "Nguyễn Hoàng Anh" : _teacher;

        dgvClassStudents.Rows.Add("Buổi 1", "06/10/2026", "Thứ 3", "18:00 – 20:00", "P201", teacherName, "Unit 1: Listening & Speaking Foundation", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 2", "09/10/2026", "Thứ 6", "18:00 – 20:00", "P201", teacherName, "Unit 2: Reading Strategies & Vocabulary", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 3", "13/10/2026", "Thứ 3", "18:00 – 20:00", "P201", teacherName, "Unit 3: Grammar in Context & Structures", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 4", "16/10/2026", "Thứ 6", "18:00 – 20:00", "P201", teacherName, "Unit 4: Writing Task 1 Basics & Bar Chart", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 5", "20/10/2026", "Thứ 3", "18:00 – 20:00", "P201", teacherName, "Unit 5: Speaking Part 1 Practice & Fluency", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 6", "23/10/2026", "Thứ 6", "18:00 – 20:00", "P201", teacherName, "Unit 6: Reading Multiple Choice & Matching", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 7", "27/10/2026", "Thứ 3", "18:00 – 20:00", "P201", teacherName, "Unit 7: Listening Section 2 & Note-taking", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 8", "30/10/2026", "Thứ 6", "18:00 – 20:00", "P201", teacherName, "Kiểm tra định kỳ 1 (Mini-Test 1) & Review", "Đã hoàn thành");
        dgvClassStudents.Rows.Add("Buổi 9", "03/11/2026", "Thứ 3", "18:00 – 20:00", "P201", teacherName, "Unit 8: Writing Task 2 Idea Generation", "Sắp diễn ra");
        dgvClassStudents.Rows.Add("Buổi 10", "06/11/2026", "Thứ 6", "18:00 – 20:00", "P201", teacherName, "Unit 9: Speaking Part 2 Long Turn", "Chưa diễn ra");

        RefreshGridDisplay();
    }

    private void LoadAttendanceTab()
    {
        lblStudentListTitle.Text = "TỔNG HỢP ĐIỂM DANH & CHUYÊN CẦN HỌC VIÊN";
        dgvClassStudents.DataSource = null;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.ScrollBars = ScrollBars.Both;

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 6F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã HV", Width = 100, MinimumWidth = 90, FillWeight = 10F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 22F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Có mặt", Width = 95, MinimumWidth = 85, FillWeight = 10F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đi muộn", Width = 90, MinimumWidth = 80, FillWeight = 9F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vắng phép", Width = 105, MinimumWidth = 95, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vắng K.phép", Width = 115, MinimumWidth = 100, FillWeight = 12F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ chuyên cần", Width = 135, MinimumWidth = 120, FillWeight = 14F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đánh giá chuyên cần", Width = 160, MinimumWidth = 140, FillWeight = 16F });

        dgvClassStudents.Rows.Add("1", "HV-0241", "Nguyễn Minh Anh", "7 buổi", "1 buổi", "0 buổi", "0 buổi", "95,8%", "✓ Đạt điều kiện thi");
        dgvClassStudents.Rows.Add("2", "HV-0237", "Lê Hoàng Nam", "8 buổi", "0 buổi", "0 buổi", "0 buổi", "100%", "✓ Đạt điều kiện thi");
        dgvClassStudents.Rows.Add("3", "HV-0238", "Phạm Khánh Linh", "8 buổi", "0 buổi", "0 buổi", "0 buổi", "100%", "✓ Đạt điều kiện thi");
        dgvClassStudents.Rows.Add("4", "HV-0240", "Vũ Quang Huy", "7 buổi", "0 buổi", "1 buổi", "0 buổi", "95,8%", "✓ Đạt điều kiện thi");
        dgvClassStudents.Rows.Add("5", "HV-0242", "Đặng Thị Thảo", "4 buổi", "1 buổi", "2 buổi", "1 buổi", "62,5%", "⚠ Cảnh báo vắng nhiều");

        RefreshGridDisplay();
    }

    private void LoadGradesTab()
    {
        lblStudentListTitle.Text = "BẢNG ĐIỂM ĐÁNH GIÁ ĐỊNH KỲ & KẾT QUẢ";
        dgvClassStudents.DataSource = null;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.ScrollBars = ScrollBars.Both;

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 6F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã HV", Width = 100, MinimumWidth = 90, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 23F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thường xuyên (TX)", Width = 145, MinimumWidth = 130, FillWeight = 15F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giữa khóa (GK)", Width = 135, MinimumWidth = 120, FillWeight = 14F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cuối khóa (CK)", Width = 135, MinimumWidth = 120, FillWeight = 14F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điểm TB", Width = 105, MinimumWidth = 90, FillWeight = 11F });
        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kết quả", Width = 135, MinimumWidth = 120, FillWeight = 14F });

        dgvClassStudents.Rows.Add("1", "HV-0241", "Nguyễn Minh Anh", "8.5 / 10", "8.0 / 10", "Chưa thi", "8.25", "✓ Đạt");
        dgvClassStudents.Rows.Add("2", "HV-0237", "Lê Hoàng Nam", "7.0 / 10", "7.5 / 10", "Chưa thi", "7.25", "✓ Đạt");
        dgvClassStudents.Rows.Add("3", "HV-0238", "Phạm Khánh Linh", "9.0 / 10", "9.5 / 10", "Chưa thi", "9.25", "✓ Xuất sắc");
        dgvClassStudents.Rows.Add("4", "HV-0240", "Vũ Quang Huy", "6.5 / 10", "6.0 / 10", "Chưa thi", "6.25", "✓ Đạt");
        dgvClassStudents.Rows.Add("5", "HV-0242", "Đặng Thị Thảo", "4.0 / 10", "4.5 / 10", "Chưa thi", "4.25", "✕ Không đạt");

        RefreshGridDisplay();
    }

    private void RefreshGridDisplay()
    {
        AdjustContentLayout();
        dgvClassStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClassStudents.PerformLayout();
        dgvClassStudents.Invalidate();
    }

    private void AdjustContentLayout()
    {
        if (cardStudentList == null || dgvClassStudents == null || pnlBody == null) return;

        int margin = 24;
        int availableWidth = Math.Max(400, pnlBody.ClientSize.Width - (margin * 2));
        int cardTop = 16;
        int cardWidth = availableWidth;
        int cardHeight = Math.Max(200, pnlBody.ClientSize.Height - cardTop - margin);
        cardStudentList.SetBounds(margin, cardTop, cardWidth, cardHeight);

        int dgvMarginX = 20;
        int dgvTop = 52;
        int dgvMarginBottom = 16;
        int dgvWidth = Math.Max(200, cardStudentList.ClientSize.Width - (dgvMarginX * 2));
        int dgvHeight = Math.Max(100, cardStudentList.ClientSize.Height - dgvTop - dgvMarginBottom);
        dgvClassStudents.SetBounds(dgvMarginX, dgvTop, dgvWidth, dgvHeight);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustContentLayout();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        RefreshGridDisplay();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustContentLayout();
    }
}
