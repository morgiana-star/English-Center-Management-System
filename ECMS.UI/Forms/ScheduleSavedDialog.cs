using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ScheduleSavedDialog : Form
{
    public ScheduleSavedDialog()
    {
        InitializeComponent();

        SetupGrids();
        LoadSampleData();
        WireEvents();
    }

    private void SetupGrids()
    {
        // Checklist Grid
        dgvChecklist.AutoGenerateColumns = false;
        dgvChecklist.Columns.Clear();
        dgvChecklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvChecklist.MultiSelect = false;
        dgvChecklist.ReadOnly = true;
        dgvChecklist.RowHeadersVisible = false;
        dgvChecklist.AllowUserToAddRows = false;

        dgvChecklist.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Criteria",
            HeaderText = "Kiểm tra ↑",
            Width = 140
        });

        dgvChecklist.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Result",
            HeaderText = "Kết quả",
            Width = 370
        });

        // First Sessions Grid
        dgvFirstSessions.AutoGenerateColumns = false;
        dgvFirstSessions.Columns.Clear();
        dgvFirstSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvFirstSessions.MultiSelect = false;
        dgvFirstSessions.ReadOnly = true;
        dgvFirstSessions.RowHeadersVisible = false;
        dgvFirstSessions.AllowUserToAddRows = false;

        dgvFirstSessions.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SessionNo",
            HeaderText = "Buổi ↑",
            Width = 80
        });

        dgvFirstSessions.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Date",
            HeaderText = "Ngày",
            Width = 140
        });

        dgvFirstSessions.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TimeSlot",
            HeaderText = "Giờ",
            Width = 150
        });

        dgvFirstSessions.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Room",
            HeaderText = "Phòng",
            Width = 130
        });
    }

    private void LoadSampleData()
    {
        var checklist = new[]
        {
            new CheckItem { Criteria = "Lịch giáo viên", Result = "✓  Không trùng IELTS-F01" },
            new CheckItem { Criteria = "Lịch phòng", Result = "✓  P201 khả dụng" },
            new CheckItem { Criteria = "Lịch học viên", Result = "✓  Nam không trùng lịch mới" },
            new CheckItem { Criteria = "Sức chứa", Result = "✓  20 ≤ 24 chỗ" }
        };
        dgvChecklist.DataSource = checklist;

        var sessions = new[]
        {
            new SessionItem { SessionNo = "01", Date = "02/11/2026", TimeSlot = "18:00–20:00", Room = "P201" },
            new SessionItem { SessionNo = "02", Date = "05/11/2026", TimeSlot = "18:00–20:00", Room = "P201" },
            new SessionItem { SessionNo = "03", Date = "09/11/2026", TimeSlot = "18:00–20:00", Room = "P201" },
            new SessionItem { SessionNo = "04", Date = "12/11/2026", TimeSlot = "18:00–20:00", Room = "P201" },
        };
        dgvFirstSessions.DataSource = sessions;
    }

    private void WireEvents()
    {
        btnBackToCalendar.Click += (s, e) =>
        {
            DialogResult = DialogResult.OK;
            Close();
        };

        btnViewSessionList.Click += (s, e) =>
        {
            MessageBox.Show("Mở toàn bộ danh sách 24 buổi học của lớp IELTS-F04.", "Danh sách buổi học", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private class CheckItem
    {
        public string Criteria { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }

    private class SessionItem
    {
        public string SessionNo { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string TimeSlot { get; set; } = string.Empty;
        public string Room { get; set; } = string.Empty;
    }
}
