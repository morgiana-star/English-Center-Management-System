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

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrid();
        LoadSampleCourses();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Đang sử dụng",
            "Tạm dừng",
            "Tất cả trạng thái"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboLevelFilter.Items.Clear();
        cboLevelFilter.Items.AddRange(new object[]
        {
            "Tất cả trình độ",
            "Cơ bản (0-4.5)",
            "Trung cấp (5.0-6.5)",
            "Nâng cao (7.0+)"
        });
        cboLevelFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
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
            HeaderText = "Mã ↑",
            FillWeight = 10
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Tên khóa học",
            FillWeight = 22
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Đầu vào",
            FillWeight = 14
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Mục tiêu đầu ra",
            FillWeight = 18
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Số buổi",
            FillWeight = 10
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Học phí gốc",
            FillWeight = 14
        });

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Trạng thái",
            FillWeight = 12
        });

        var colAction = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Xem chi tiết",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 12
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvCourses.Columns.Add(colAction);
    }

    private void LoadSampleCourses()
    {
        dgvCourses.Rows.Clear();
        dgvCourses.Rows.Add("CT-001", "IELTS Foundation", "Cơ bản (0-4.5)", "Nền tảng IELTS 4.0-4.5", "24 buổi (120p)", "6.000.000đ", "Đang sử dụng");
        dgvCourses.Rows.Add("CT-002", "IELTS Intensive", "Trung cấp (5.0-5.5)", "Bứt phá IELTS 6.5+", "36 buổi (120p)", "9.500.000đ", "Đang sử dụng");
        dgvCourses.Rows.Add("CT-003", "TOEIC 500+", "Cơ bản (0-350)", "Đạt TOEIC 500-650", "20 buổi (90p)", "4.500.000đ", "Đang sử dụng");
        dgvCourses.Rows.Add("CT-004", "Tiếng Anh Giao tiếp Cơ bản", "Mất gốc", "Giao tiếp tự tin hàng ngày", "24 buổi (90p)", "3.800.000đ", "Đang sử dụng");
        dgvCourses.Rows.Add("CT-005", "IELTS Master 7.5+", "Nâng cao (6.5)", "Chinh phục 7.5 - 8.0+", "30 buổi (120p)", "12.000.000đ", "Tạm dừng");
        dgvCourses.ClearSelection();
        dgvCourses.CurrentCell = null;
    }

    private void WireEvents()
    {
        btnAddCourse.Click += (s, e) =>
        {
            using var dlg = new CourseEditDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadSampleCourses();
            }
        };

        dgvCourses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCourses.Columns.Count - 1)
            {
                var row = dgvCourses.Rows[e.RowIndex];
                string courseCode = row.Cells[0].Value?.ToString() ?? "CT-001";
                string courseName = row.Cells[1].Value?.ToString() ?? "IELTS Foundation";
                string fee = row.Cells[5].Value?.ToString() ?? "6.000.000đ";

                using var detailDlg = new CourseDetailDialog(courseCode, courseName, fee);
                detailDlg.ShowDialog(FindForm());
            }
        };

        txtSearchCourse.TextChanged += (s, e) => FilterCourses();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterCourses();
        cboLevelFilter.SelectedIndexChanged += (s, e) => FilterCourses();
    }

    private void FilterCourses()
    {
        string kw = txtSearchCourse.Text.Trim().ToLowerInvariant();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "";
        string level = cboLevelFilter.SelectedItem?.ToString() ?? "";

        foreach (DataGridViewRow row in dgvCourses.Rows)
        {
            if (row.IsNewRow) continue;
            string code = row.Cells[0].Value?.ToString()?.ToLowerInvariant() ?? "";
            string name = row.Cells[1].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowLevel = row.Cells[2].Value?.ToString() ?? "";
            string rowStatus = row.Cells[6].Value?.ToString() ?? "";

            bool matchKw = string.IsNullOrEmpty(kw) || code.Contains(kw) || name.Contains(kw);
            bool matchStatus = status == "Tất cả trạng thái" || rowStatus == status;
            bool matchLevel = level == "Tất cả trình độ" || rowLevel.Contains(level);

            row.Visible = matchKw && matchStatus && matchLevel;
        }
    }
}
