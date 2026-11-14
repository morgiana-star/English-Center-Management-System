using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseDetailDialog : Form
{
    private readonly string _courseCode;
    private readonly string _courseName;

    public CourseDetailDialog(string courseCode = "CT-IELTS-F", string courseName = "IELTS Foundation")
    {
        InitializeComponent();

        _courseCode = courseCode;
        _courseName = courseName;

        SetupHeaderAndInfo();
        SetupClassesGrid();
        LoadSampleClasses();
        WireEvents();
    }

    private void SetupHeaderAndInfo()
    {
        Text = $"Chi tiết khóa học · {_courseName}";
        lblTitle.Text = _courseName;
        // lblSubtitle.Text = $"{_courseCode} · Phiên bản 1.2 · Đang sử dụng";
        // lblBreadcrumb.Text = $"ECMS / Khóa học / {_courseName} · {_courseCode}";
    }

    private void SetupClassesGrid()
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
            DataPropertyName = "ClassName",
            HeaderText = "Lớp",
            Width = 140
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Schedule",
            HeaderText = "Thời gian",
            Width = 240
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Teacher",
            HeaderText = "Giáo viên",
            Width = 200
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Enrollment",
            HeaderText = "Sĩ số",
            Width = 110
        });

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 130
        });

        var actionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Mở lớp",
            UseColumnTextForButtonValue = true,
            Width = 100
        };
        dgvClasses.Columns.Add(actionCol);
    }

    private void LoadSampleClasses()
    {
        var classes = new[]
        {
            new ClassItem { ClassName = "IELTS-F01", Schedule = "T3 / T6 · 18:00–20:00", Teacher = "Nguyễn Hoàng Anh", Enrollment = "18 / 20", Status = "Đang học" },
            new ClassItem { ClassName = "IELTS-F02", Schedule = "T2 / T5 · 18:00–20:00", Teacher = "Trần Mai Phương", Enrollment = "16 / 20", Status = "Đang học" },
            new ClassItem { ClassName = "IELTS-F03", Schedule = "T7 / CN · 08:30–10:30", Teacher = "Lê Quốc Hùng", Enrollment = "20 / 20", Status = "Đang học" },
        };

        dgvClasses.DataSource = classes;
    }

    private void WireEvents()
    {
        btnEditCourse.Click += (s, e) =>
        {
            using var dlg = new CourseEditDialog(_courseCode);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                SetupHeaderAndInfo();
            }
        };

        btnCreateClass.Click += (s, e) =>
        {
            MessageBox.Show($"Mở trình tạo Lớp học mới kế thừa từ chương trình {_courseName} ({_courseCode}).", "Tạo lớp học", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnOpenMaterials.Click += (s, e) =>
        {
            MessageBox.Show("Mở màn hình Quản lý tài liệu học tập của khóa học này.", "Tài liệu học tập", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnTabOverview.Click += (s, e) => SwitchTab(btnTabOverview);
        btnTabClasses.Click += (s, e) => SwitchTab(btnTabClasses);
        btnTabMaterials.Click += (s, e) => SwitchTab(btnTabMaterials);
        btnTabRules.Click += (s, e) => SwitchTab(btnTabRules);

        dgvClasses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) // Cột thao tác
            {
                if (dgvClasses.Rows[e.RowIndex].DataBoundItem is ClassItem item)
                {
                    MessageBox.Show($"Mở thông tin chi tiết lớp học {item.ClassName}.", "Mở lớp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        };
    }

    private void SwitchTab(Button activeBtn)
    {
        var tabs = new[] { btnTabOverview, btnTabClasses, btnTabMaterials, btnTabRules };
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

    private class ClassItem
    {
        public string ClassName { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string Teacher { get; set; } = string.Empty;
        public string Enrollment { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
