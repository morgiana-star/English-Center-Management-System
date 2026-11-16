using System;
using System.Drawing;
using System.Windows.Forms;
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
        LoadClassesData();
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

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 55, MinimumWidth = 50, FillWeight = 6F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã lớp", Width = 105, MinimumWidth = 95, FillWeight = 11F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCourse", HeaderText = "Khóa học", MinimumWidth = 150, FillWeight = 20F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Giáo viên phụ trách", Width = 150, MinimumWidth = 130, FillWeight = 16F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSchedule", HeaderText = "Lịch định kỳ", Width = 120, MinimumWidth = 110, FillWeight = 12F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTime", HeaderText = "Khung giờ", Width = 135, MinimumWidth = 120, FillWeight = 13F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Phòng", Width = 85, MinimumWidth = 75, FillWeight = 8F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartDate", HeaderText = "Khai giảng", Width = 110, MinimumWidth = 100, FillWeight = 11F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSessions", HeaderText = "Số buổi", Width = 85, MinimumWidth = 75, FillWeight = 8F });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Trạng thái", Width = 105, MinimumWidth = 95, FillWeight = 11F });
    }

    private void LoadClassesData()
    {
        dgvClasses.Rows.Clear();

        dgvClasses.Rows.Add("1", "IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh", "T3 / T6", "18:00 – 20:00", "P201", "06/10/2026", "24 buổi", "Đang học");
        dgvClasses.Rows.Add("2", "IELTS-F02", "IELTS Foundation", "Trần Minh Tuấn", "T2 / T5", "18:00 – 20:00", "P202", "12/10/2026", "24 buổi", "Đang học");
        dgvClasses.Rows.Add("3", "IELTS-I01", "IELTS Intensive", "Trần Minh Tuấn", "T4 / T7", "14:00 – 17:00", "P203", "15/10/2026", "30 buổi", "Đang học");
        dgvClasses.Rows.Add("4", "TOEIC-A01", "TOEIC 500+", "Lê Thu Hà", "T3 / T6", "18:30 – 20:30", "P202", "20/10/2026", "20 buổi", "Đang học");
        dgvClasses.Rows.Add("5", "COM-B01", "Giao tiếp cơ bản", "Lê Thu Hà", "T7 / CN", "08:30 – 11:30", "P102", "01/11/2026", "16 buổi", "Đang học");
        dgvClasses.Rows.Add("6", "IELTS-F04", "IELTS Foundation", "Võ Tấn Toàn", "T2 / T5", "18:00 – 20:00", "P201", "20/11/2026", "24 buổi", "Sắp mở");

        if (dgvClasses.RowCount > 0)
        {
            dgvClasses.Rows[0].Selected = true;
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnCreateSessions.Click += (s, e) => ConfirmCreate();

        dgvClasses.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                ConfirmCreate();
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

    private void ConfirmCreate()
    {
        if (dgvClasses.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn 1 lớp học từ danh sách để tạo buổi học!", "Chưa chọn lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var row = dgvClasses.SelectedRows[0];
        string code = row.Cells["colCode"].Value?.ToString() ?? "";
        string course = row.Cells["colCourse"].Value?.ToString() ?? "";
        string teacher = row.Cells["colTeacher"].Value?.ToString() ?? "";
        string schedule = row.Cells["colSchedule"].Value?.ToString() ?? "";
        string time = row.Cells["colTime"].Value?.ToString() ?? "";
        string room = row.Cells["colRoom"].Value?.ToString() ?? "";
        string sessions = row.Cells["colSessions"].Value?.ToString() ?? "";

        SelectedClassCode = code;
        SelectedCourseName = course;

        string message = $"ĐÃ TẠO LỊCH HỌC THÀNH CÔNG!\n\n" +
                         $"• Lớp: {code} ({course})\n" +
                         $"• Giáo viên: {teacher}\n" +
                         $"• Phòng học: {room}\n" +
                         $"• Lịch định kỳ: {schedule} ({time})\n" +
                         $"• Kế hoạch: Đã sinh đầy đủ {sessions} vào Thời khóa biểu trung tâm.";

        MessageBox.Show(message, "Tạo buổi học thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }
}
