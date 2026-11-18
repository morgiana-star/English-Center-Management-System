using System;
using System.Drawing;
using System.Windows.Forms;
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
        LoadClassesData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Đang học",
            "Sắp mở",
            "Đã kết thúc"
        });
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

    private void LoadClassesData()
    {
        dgvAttendanceClasses.Rows.Clear();

        dgvAttendanceClasses.Rows.Add("1", "IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh", "T3 / T6 · 18:00–20:00", "P201", "8 / 24 buổi", "90,3% (Tốt)", "Đang học", "Điểm danh");
        dgvAttendanceClasses.Rows.Add("2", "IELTS-F02", "IELTS Foundation", "Trần Minh Tuấn", "T2 / T5 · 18:00–20:00", "P202", "6 / 24 buổi", "95,8% (Tốt)", "Đang học", "Điểm danh");
        dgvAttendanceClasses.Rows.Add("3", "IELTS-I01", "IELTS Intensive", "Trần Minh Tuấn", "T4 / T7 · 14:00–17:00", "P203", "12 / 30 buổi", "86,7% (Khá)", "Đang học", "Điểm danh");
        dgvAttendanceClasses.Rows.Add("4", "TOEIC-A01", "TOEIC 500+", "Lê Thu Hà", "T3 / T6 · 18:30–20:30", "P202", "4 / 20 buổi", "92,5% (Tốt)", "Đang học", "Điểm danh");
        dgvAttendanceClasses.Rows.Add("5", "COM-B01", "Giao tiếp cơ bản", "Lê Thu Hà", "T7 / CN · 08:30–11:30", "P102", "2 / 16 buổi", "100% (Tốt)", "Đang học", "Điểm danh");
        dgvAttendanceClasses.Rows.Add("6", "IELTS-F04", "IELTS Foundation", "Võ Tấn Toàn", "T2 / T5 · 18:00–20:00", "P201", "0 / 24 buổi", "Chưa bắt đầu", "Sắp mở", "Điểm danh");
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
        string classCode = row.Cells["colCode"].Value?.ToString() ?? "IELTS-F01";
        string courseName = row.Cells["colCourse"].Value?.ToString() ?? "IELTS Foundation";
        string teacher = row.Cells["colTeacher"].Value?.ToString() ?? "Nguyễn Hoàng Anh";
        string room = row.Cells["colRoom"].Value?.ToString() ?? "P201";

        using var dlg = new ClassAttendanceDialog(classCode, courseName, teacher, room);
        dlg.ShowDialog(FindForm());
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
