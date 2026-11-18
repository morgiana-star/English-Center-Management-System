using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class TeacherAttendanceSummaryView : UserControl
{
    private class StudentAttendanceSummary
    {
        public string FullName { get; set; } = string.Empty;
        public int PresentCount { get; set; }
        public int LateCount { get; set; }
        public int ExcusedAbsent { get; set; }
        public int UnexcusedAbsent { get; set; }
        public string AttendanceRate { get; set; } = string.Empty;
    }

    private readonly List<StudentAttendanceSummary> _summaries = new();

    public TeacherAttendanceSummaryView()
    {
        InitializeComponent();

        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupGrid()
    {
        dgvSummary.AutoGenerateColumns = false;
        dgvSummary.Columns.Clear();
        dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSummary.MultiSelect = false;
        dgvSummary.ReadOnly = true;
        dgvSummary.RowHeadersVisible = false;
        dgvSummary.AllowUserToAddRows = false;

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Học viên ↑",
            Width = 180
        });

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "PresentCount",
            HeaderText = "Có mặt",
            Width = 80,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "LateCount",
            HeaderText = "Muộn",
            Width = 70,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ExcusedAbsent",
            HeaderText = "Vắng CP",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "UnexcusedAbsent",
            HeaderText = "Vắng KP",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "AttendanceRate",
            HeaderText = "Tỷ lệ",
            Width = 90,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvSummary.CellFormatting += (s, e) =>
        {
            if (dgvSummary.Columns[e.ColumnIndex].DataPropertyName == "AttendanceRate" && e.Value != null)
            {
                var val = e.Value.ToString() ?? "";
                if (val.Contains("100") || val.Contains("87,5"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
        };
    }

    private void LoadSampleData()
    {
        _summaries.Clear();
        _summaries.Add(new StudentAttendanceSummary
        {
            FullName = "Nguyễn Minh Anh",
            PresentCount = 6,
            LateCount = 1,
            ExcusedAbsent = 1,
            UnexcusedAbsent = 0,
            AttendanceRate = "87,5%"
        });

        _summaries.Add(new StudentAttendanceSummary
        {
            FullName = "Lê Hoàng Nam",
            PresentCount = 4,
            LateCount = 0,
            ExcusedAbsent = 1,
            UnexcusedAbsent = 3,
            AttendanceRate = "50,0%"
        });

        _summaries.Add(new StudentAttendanceSummary
        {
            FullName = "Phạm Khánh Linh",
            PresentCount = 8,
            LateCount = 0,
            ExcusedAbsent = 0,
            UnexcusedAbsent = 0,
            AttendanceRate = "100%"
        });

        _summaries.Add(new StudentAttendanceSummary
        {
            FullName = "Vũ Quang Huy",
            PresentCount = 6,
            LateCount = 2,
            ExcusedAbsent = 0,
            UnexcusedAbsent = 0,
            AttendanceRate = "100%"
        });

        dgvSummary.DataSource = null;
        dgvSummary.DataSource = _summaries;
    }

    private void WireEvents()
    {
        btnBackAttendance.Click += (s, e) =>
        {
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherAttendanceCheckView());
            }
        };

        btnRecordTracking.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Ghi nhận yêu cầu theo dõi",
                "Đã ghi nhận yêu cầu liên hệ học viên Lê Hoàng Nam (vắng 4/8 buổi).\n" +
                "Thông tin đã được chuyển tới nhân viên Đào tạo: Nguyễn Thị Hạnh.");
        };

        btnExportSummary.Click += (s, e) =>
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất tổng hợp chuyên cần ra tệp cục bộ",
                Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*",
                FileName = $"ChuyenCan_IELTS-F01_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (sfd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                AppDialog.ShowSuccess(ParentForm, "Xuất tệp thành công",
                    $"Đã xuất dữ liệu tổng hợp chuyên cần lớp IELTS-F01 ra tệp:\n{sfd.FileName}");
            }
        };
    }
}
