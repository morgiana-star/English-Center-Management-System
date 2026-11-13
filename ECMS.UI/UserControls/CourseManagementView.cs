using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class CourseManagementView : UserControl
{
    public CourseManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupDataGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Đang sử dụng", "Ngừng sử dụng", "Tất cả trạng thái" });
        cboStatusFilter.SelectedIndex = 0;

        cboLevelFilter.Items.Clear();
        cboLevelFilter.Items.AddRange(new object[] { "Tất cả trình độ", "Cơ bản (0 - 4.5)", "Trung cấp (5.0 - 6.5)", "Nâng cao (6.5+)" });
        cboLevelFilter.SelectedIndex = 0;
    }

    private void SetupDataGrid()
    {
        dgvCourses.AutoGenerateColumns = false;
        dgvCourses.Columns.Clear();
        dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCourses.MultiSelect = false;
        dgvCourses.ReadOnly = true;
        dgvCourses.RowHeadersVisible = false;
        dgvCourses.AllowUserToAddRows = false;

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Code",
            HeaderText = "Mã khóa ↑",
            Width = 120
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Name",
            HeaderText = "Tên chương trình",
            Width = 260
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Duration",
            HeaderText = "Thời lượng",
            Width = 110
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Tuition",
            HeaderText = "Học phí gốc",
            Width = 130
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Classes",
            HeaderText = "Lớp liên quan",
            Width = 120
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 130
        });

        var actionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Chi tiết",
            UseColumnTextForButtonValue = true,
            Width = 90
        };
        dgvCourses.Columns.Add(actionCol);
    }

    private void LoadSampleData()
    {
        var courses = new[]
        {
            new CourseItem { Code = "CT-IELTS-F", Name = "IELTS Foundation", Duration = "24 buổi", Tuition = "6.000.000đ", Classes = "3 lớp", Status = "✓ Đang dùng" },
            new CourseItem { Code = "CT-IELTS-65", Name = "IELTS 5.0–6.5", Duration = "36 buổi", Tuition = "9.600.000đ", Classes = "5 lớp", Status = "✓ Đang dùng" },
            new CourseItem { Code = "CT-TOEIC-5", Name = "TOEIC 500+", Duration = "24 buổi", Tuition = "4.800.000đ", Classes = "3 lớp", Status = "✓ Đang dùng" },
            new CourseItem { Code = "CT-TOEIC-65", Name = "TOEIC 650+", Duration = "30 buổi", Tuition = "6.200.000đ", Classes = "2 lớp", Status = "✓ Đang dùng" },
            new CourseItem { Code = "CT-COM-B", Name = "English Communication Basic", Duration = "20 buổi", Tuition = "3.200.000đ", Classes = "3 lớp", Status = "✓ Đang dùng" },
        };

        dgvCourses.DataSource = courses;
    }

    private void WireEvents()
    {
        btnAddCourse.Click += (s, e) =>
        {
            using var dlg = new CourseEditDialog();
            dlg.ShowDialog(FindForm());
        };

        btnOpenCourseDetail.Click += (s, e) =>
        {
            OpenSelectedCourseDetail();
        };

        dgvCourses.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenSelectedCourseDetail();
            }
        };

        dgvCourses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) // Cột thao tác
            {
                OpenSelectedCourseDetail();
            }
        };

        btnViewRelatedClasses.Click += (s, e) =>
        {
            MessageBox.Show("Chuyển tiếp đến danh sách Lớp học thuộc chương trình đào tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private void OpenSelectedCourseDetail()
    {
        string courseCode = "CT-IELTS-F";
        string courseName = "IELTS Foundation";

        if (dgvCourses.CurrentRow?.DataBoundItem is CourseItem item)
        {
            courseCode = item.Code;
            courseName = item.Name;
        }

        using var dlg = new CourseDetailDialog(courseCode, courseName);
        dlg.ShowDialog(FindForm());
    }

    private class CourseItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Tuition { get; set; } = string.Empty;
        public string Classes { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
