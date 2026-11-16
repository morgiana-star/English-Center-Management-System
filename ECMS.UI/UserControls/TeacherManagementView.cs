using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherManagementView : UserControl
{
    public TeacherManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrids();
        LoadSampleTeachers();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Đang giảng dạy",
            "Tạm nghỉ",
            "Tất cả trạng thái"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboSpecialtyFilter.Items.Clear();
        cboSpecialtyFilter.Items.AddRange(new object[]
        {
            "Tất cả chuyên môn",
            "IELTS 8.0+",
            "IELTS 7.0–7.5",
            "TOEIC 900+",
            "Giao tiếp"
        });
        cboSpecialtyFilter.SelectedIndex = 0;
    }

    private void SetupGrids()
    {
        dgvTeachers.AutoGenerateColumns = false;
        dgvTeachers.Columns.Clear();
        dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.MultiSelect = false;
        dgvTeachers.ReadOnly = true;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.AllowUserToAddRows = false;

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Mã GV ↑",
            FillWeight = 12
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Họ và tên",
            FillWeight = 24
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Số điện thoại",
            FillWeight = 16
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Chuyên môn",
            FillWeight = 16
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Tải giờ dạy / tuần",
            FillWeight = 18
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Trạng thái",
            FillWeight = 14
        });
    }

    private void LoadSampleTeachers()
    {
        dgvTeachers.Rows.Clear();
        dgvTeachers.Rows.Add("GV-0012", "Nguyễn Hoàng Anh", "0912 334 556", "IELTS 8.0+", "12 / 16 giờ", "Đang giảng dạy");
        dgvTeachers.Rows.Add("GV-0015", "Trần Gia Bảo", "0903 445 667", "IELTS 7.0–7.5", "10 / 14 giờ", "Đang giảng dạy");
        dgvTeachers.Rows.Add("GV-0018", "Lê Hoàng Yến", "0938 556 778", "TOEIC 900+", "8 / 12 giờ", "Đang giảng dạy");
        dgvTeachers.Rows.Add("GV-0021", "Đặng Minh Trí", "0987 112 233", "Giao tiếp", "6 / 10 giờ", "Đang giảng dạy");
        dgvTeachers.Rows.Add("GV-0024", "Phạm Quỳnh Như", "0945 667 889", "IELTS 8.0+", "0 / 16 giờ", "Tạm nghỉ");
        dgvTeachers.ClearSelection();
        dgvTeachers.CurrentCell = null;
    }

    private void WireEvents()
    {
        btnAddTeacher.Click += (s, e) =>
        {
            using var dlg = new AddTeacherDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadSampleTeachers();
            }
        };

        txtSearchTeacher.TextChanged += (s, e) => FilterTeachers();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterTeachers();
        cboSpecialtyFilter.SelectedIndexChanged += (s, e) => FilterTeachers();
    }

    private void FilterTeachers()
    {
        string kw = txtSearchTeacher.Text.Trim().ToLowerInvariant();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "";
        string spec = cboSpecialtyFilter.SelectedItem?.ToString() ?? "";

        foreach (DataGridViewRow row in dgvTeachers.Rows)
        {
            if (row.IsNewRow) continue;
            string code = row.Cells[0].Value?.ToString()?.ToLowerInvariant() ?? "";
            string name = row.Cells[1].Value?.ToString()?.ToLowerInvariant() ?? "";
            string phone = row.Cells[2].Value?.ToString()?.ToLowerInvariant() ?? "";
            string rowSpec = row.Cells[3].Value?.ToString() ?? "";
            string rowStatus = row.Cells[5].Value?.ToString() ?? "";

            bool matchKw = string.IsNullOrEmpty(kw) || code.Contains(kw) || name.Contains(kw) || phone.Contains(kw);
            bool matchStatus = status == "Tất cả trạng thái" || rowStatus == status;
            bool matchSpec = spec == "Tất cả chuyên môn" || rowSpec.Contains(spec);

            row.Visible = matchKw && matchStatus && matchSpec;
        }
    }
}
