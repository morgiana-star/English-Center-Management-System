using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ClassManagementView : UserControl
{
    public ClassManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupDataGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.AddRange(new object[]
        {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS 5.0–6.5",
            "TOEIC 500+",
            "TOEIC 650+",
            "English Communication Basic"
        });
        cboCourseFilter.SelectedIndex = 0;

        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Đang học",
            "Hoàn thành",
            "Sắp mở",
            "Bản nháp"
        });
        cboStatusFilter.SelectedIndex = 0;
    }

    private void SetupDataGrid()
    {
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ClassCode",
            HeaderText = "Lớp ↑",
            Width = 110
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "CourseName",
            HeaderText = "Khóa học",
            Width = 240
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Teacher",
            HeaderText = "Giáo viên",
            Width = 180
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Schedule",
            HeaderText = "Lịch",
            Width = 150
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Capacity",
            HeaderText = "Sĩ số",
            Width = 90
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 140
        });

        var actionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            DataPropertyName = "ActionText",
            UseColumnTextForButtonValue = false,
            Width = 140
        };
        dgvClasses.Columns.Add(actionCol);
    }

    private void LoadSampleData()
    {
        var classes = new[]
        {
            new ClassRowItem { ClassCode = "IELTS-F01", CourseName = "IELTS Foundation", Teacher = "Nguyễn Hoàng Anh", Schedule = "T3/T6 · 18:00", Capacity = "18/20", Status = "✓ Đang học", ActionText = "Xem / Chuyển" },
            new ClassRowItem { ClassCode = "IELTS-F02", CourseName = "IELTS Foundation", Teacher = "Trần Minh Tuấn", Schedule = "T2/T6 · 18:00", Capacity = "20/20", Status = "✓ Hoàn thành", ActionText = "Xem / Chứng chỉ" },
            new ClassRowItem { ClassCode = "TOEIC-T01", CourseName = "TOEIC 500+", Teacher = "Trần Minh Tuấn", Schedule = "T3/T6 · 18:00", Capacity = "22/24", Status = "✓ Đang học", ActionText = "Xem / Sửa" },
            new ClassRowItem { ClassCode = "COM-B01", CourseName = "English Communication Basic", Teacher = "Lê Thu Hà", Schedule = "T2/T4 · 18:00", Capacity = "12/18", Status = "Sắp mở 02/11", ActionText = "Xem / Mở lớp" },
            new ClassRowItem { ClassCode = "IELTS-F04", CourseName = "IELTS Foundation", Teacher = "Nguyễn Hoàng Anh", Schedule = "T2/T5 · 18:00", Capacity = "0/20", Status = "Bản nháp", ActionText = "Xem / Sửa" },
        };

        dgvClasses.DataSource = classes;
    }

    private void WireEvents()
    {
        btnAddClass.Click += (s, e) =>
        {
            using var dlg = new CreateClassDialog();
            dlg.ShowDialog(FindForm());
        };

        btnCheckAndOpenClass.Click += (s, e) =>
        {
            using var dlg = new ClassTransferCompleteDialog();
            dlg.ShowDialog(FindForm());
        };

        btnAddStudentToClass.Click += (s, e) =>
        {
            using var dlg = new AddStudentDialog();
            dlg.ShowDialog(FindForm());
        };

        dgvClasses.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenSelectedClassDetail();
            }
        };

        dgvClasses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                OpenSelectedClassDetail();
            }
        };
    }

    private void OpenSelectedClassDetail()
    {
        string classCode = "IELTS-F01";
        string courseName = "IELTS Foundation";

        if (dgvClasses.CurrentRow?.DataBoundItem is ClassRowItem item)
        {
            classCode = item.ClassCode;
            courseName = item.CourseName;
        }

        using var dlg = new ClassDetailDialog(classCode, courseName);
        dlg.ShowDialog(FindForm());
    }

    private class ClassRowItem
    {
        public string ClassCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Teacher { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string ActionText { get; set; } = string.Empty;
    }
}
