using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class TeacherAttendanceCheckView : UserControl
{
    public class AttendanceRecord
    {
        public string StudentCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Status { get; set; } = "Có mặt";
        public string Note { get; set; } = string.Empty;
    }

    private readonly List<AttendanceRecord> _records = new();

    public TeacherAttendanceCheckView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboClass.Items.Clear();
        cboClass.Items.AddRange(new object[]
        {
            "IELTS-F01",
            "IELTS-F02",
            "TOEIC-T01"
        });
        cboClass.SelectedIndex = 0;

        cboSession.Items.Clear();
        cboSession.Items.AddRange(new object[]
        {
            "Buổi 08 · 30/10",
            "Buổi 07 · 27/10",
            "Buổi 06 · 23/10"
        });
        cboSession.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvAttendance.AutoGenerateColumns = false;
        dgvAttendance.Columns.Clear();
        dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAttendance.MultiSelect = false;
        dgvAttendance.ReadOnly = false;
        dgvAttendance.RowHeadersVisible = false;
        dgvAttendance.AllowUserToAddRows = false;

        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Học viên ↑",
            Width = 220,
            ReadOnly = true
        });

        var colStatus = new DataGridViewComboBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 180,
            FlatStyle = FlatStyle.Flat
        };
        colStatus.Items.AddRange(new object[]
        {
            "Có mặt",
            "Vắng có phép",
            "Vắng không phép",
            "Đi muộn"
        });
        dgvAttendance.Columns.Add(colStatus);

        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Note",
            HeaderText = "Ghi chú",
            Width = 320
        });

        dgvAttendance.CellValueChanged += (s, e) =>
        {
            UpdateStats();
            // bannerUnsaved.Visible = true;
        };
    }

    private void LoadSampleData()
    {
        _records.Clear();
        _records.Add(new AttendanceRecord { StudentCode = "HV-0201", FullName = "Nguyễn Minh Anh", Status = "Vắng có phép", Note = "Phụ huynh báo ốm" });
        _records.Add(new AttendanceRecord { StudentCode = "HV-0202", FullName = "Lê Hoàng Nam", Status = "Có mặt", Note = "Cần liên hệ về 4 buổi vắng trước" });
        _records.Add(new AttendanceRecord { StudentCode = "HV-0203", FullName = "Phạm Khánh Linh", Status = "Có mặt", Note = "—" });
        _records.Add(new AttendanceRecord { StudentCode = "HV-0204", FullName = "Vũ Quang Huy", Status = "Đi muộn", Note = "Đến lúc 18:10" });
        _records.Add(new AttendanceRecord { StudentCode = "HV-0205", FullName = "Đỗ Ngọc Trâm", Status = "Vắng không phép", Note = "Chưa có thông tin" });

        // Add 13 more present students to make 18 students like in the design
        for (int i = 6; i <= 18; i++)
        {
            _records.Add(new AttendanceRecord
            {
                StudentCode = $"HV-02{i:D2}",
                FullName = $"Học viên {i:D2}",
                Status = "Có mặt",
                Note = "—"
            });
        }

        dgvAttendance.DataSource = null;
        dgvAttendance.DataSource = _records;

        UpdateStats();
    }

    private void UpdateStats()
    {
        int total = _records.Count;
        int present = _records.Count(r => r.Status == "Có mặt");
        int late = _records.Count(r => r.Status == "Đi muộn");
        int excused = _records.Count(r => r.Status == "Vắng có phép");
        int unexcused = _records.Count(r => r.Status == "Vắng không phép");

        statTotal.Value = total.ToString();
        statPresent.Value = present.ToString();
        statLate.Value = late.ToString();
        statAbsent.Value = $"{excused} / {unexcused}";

        double attending = present + late;
        double rate = total > 0 ? (attending / total) * 100.0 : 0.0;
        statRate.Value = $"{rate:F1}%";

        lblPagingInfo.Text = $"1–5 / {total} học viên · {total - 5} học viên còn lại: Có mặt";
    }

    private void WireEvents()
    {
        txtSearchStudent.TextChanged += (s, e) =>
        {
            var q = txtSearchStudent.Text?.Trim().ToLowerInvariant() ?? "";
            if (string.IsNullOrEmpty(q))
            {
                dgvAttendance.DataSource = _records;
            }
            else
            {
                dgvAttendance.DataSource = _records.Where(r => r.FullName.ToLowerInvariant().Contains(q)).ToList();
            }
        };

        btnMarkAllPresent.Click += (s, e) =>
        {
            foreach (var r in _records)
            {
                r.Status = "Có mặt";
            }
            dgvAttendance.Refresh();
            UpdateStats();
            // bannerUnsaved.Visible = true;
            AppDialog.ShowSuccess(ParentForm, "Điểm danh nhanh", "Đã đánh dấu tất cả 18 học viên Có mặt.");
        };

        btnCancelChanges.Click += (s, e) =>
        {
            LoadSampleData();
            // bannerUnsaved.Visible = false;
        };

        btnSaveAttendance.Click += (s, e) =>
        {
            // bannerUnsaved.Visible = false;
            AppDialog.ShowSuccess(ParentForm, "Lưu điểm danh thành công",
                $"Đã lưu điểm danh buổi 08 lớp IELTS-F01 vào SQLite.\n" +
                $"• Có mặt: {statPresent.Value}\n" +
                $"• Đi muộn: {statLate.Value}\n" +
                $"• Vắng: {statAbsent.Value}\n" +
                $"• Tỷ lệ tham dự: {statRate.Value}\n\n" +
                "Chuyển tiếp sang bước Tổng hợp chuyên cần.");

            // Navigate to Summary View
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherAttendanceSummaryView());
            }
        };

        btnSummaryView.Click += (s, e) =>
        {
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherAttendanceSummaryView());
            }
        };
    }
}
