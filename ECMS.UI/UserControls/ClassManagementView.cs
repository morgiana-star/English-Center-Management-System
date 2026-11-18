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

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrid();
        LoadSampleClasses();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.AddRange(new object[]
        {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS Intensive",
            "TOEIC 500+",
            "Giao tiếp"
        });
        cboCourseFilter.SelectedIndex = 0;

        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Đang học",
            "Sắp mở",
            "Đã kết thúc"
        });
        cboStatusFilter.SelectedIndex = 0;
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

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp ↑", FillWeight = 12 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khóa học", FillWeight = 20 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên phụ trách", FillWeight = 20 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lịch học & Giờ", FillWeight = 20 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 10 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số (HV)", FillWeight = 10 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 12 });

        var colAction = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Xem chi tiết",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 12
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvClasses.Columns.Add(colAction);
    }

    private void LoadSampleClasses()
    {
        dgvClasses.Rows.Clear();
        dgvClasses.Rows.Add("IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh", "T3 / T6 · 18:00–20:00", "P201", "20 / 20", "Đang học");
        dgvClasses.Rows.Add("IELTS-F02", "IELTS Foundation", "Trần Gia Bảo", "T2 / T5 · 19:30–21:30", "P202", "18 / 20", "Đang học");
        dgvClasses.Rows.Add("IELTS-I01", "IELTS Intensive", "Phạm Quỳnh Như", "T4 / T7 · 18:00–20:00", "P203", "16 / 20", "Đang học");
        dgvClasses.Rows.Add("TOEIC-A01", "TOEIC 500+", "Lê Hoàng Yến", "T3 / T5 / T7 · 19:00–20:30", "P101", "15 / 25", "Đang học");
        dgvClasses.Rows.Add("COM-B01", "Giao tiếp Cơ bản", "Đặng Minh Trí", "T2 / T4 · 18:00–19:30", "P102", "12 / 15", "Đang học");
        dgvClasses.Rows.Add("IELTS-F04", "IELTS Foundation", "Nguyễn Hoàng Anh", "T7 / CN · 08:30–10:30", "P201", "8 / 20", "Sắp mở");

        dgvClasses.ClearSelection();
        dgvClasses.CurrentCell = null;
    }

    private void WireEvents()
    {
        btnAddClass.Click += (s, e) =>
        {
            using var createDlg = new CreateClassDialog();
            if (createDlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadSampleClasses();
            }
        };

        dgvClasses.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvClasses.Columns.Count - 1)
            {
                var row = dgvClasses.Rows[e.RowIndex];
                string classCode = row.Cells[0].Value?.ToString() ?? "IELTS-F01";
                string courseName = row.Cells[1].Value?.ToString() ?? "IELTS Foundation";
                string teacher = row.Cells[2].Value?.ToString() ?? "Nguyễn Hoàng Anh";

                using var detailDlg = new ClassDetailDialog(classCode, courseName, teacher);
                detailDlg.ShowDialog(FindForm());
            }
        };

        txtSearchClass.TextChanged += (s, e) => FilterClasses();
        cboCourseFilter.SelectedIndexChanged += (s, e) => FilterClasses();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterClasses();
    }

    private void FilterClasses()
    {
        string kw = txtSearchClass.Text.Trim().ToLowerInvariant();
        string course = cboCourseFilter.SelectedItem?.ToString() ?? "";
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "";

        foreach (DataGridViewRow row in dgvClasses.Rows)
        {
            if (row.IsNewRow) continue;
            string code = row.Cells[0].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowCourse = row.Cells[1].Value?.ToString() ?? "";
            string teacher = row.Cells[2].Value?.ToString()?.ToLowerInvariant() ?? "";
            string room = row.Cells[4].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowStatus = row.Cells[6].Value?.ToString() ?? "";

            bool matchKw = string.IsNullOrEmpty(kw) || code.Contains(kw) || teacher.Contains(kw) || room.Contains(kw);
            bool matchCourse = course == "Tất cả khóa học" || rowCourse.Contains(course);
            bool matchStatus = status == "Tất cả trạng thái" || rowStatus == status;

            row.Visible = matchKw && matchCourse && matchStatus;
        }
    }
}
