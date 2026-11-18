using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CourseDetailDialog : Form
{
    private readonly string _courseCode = string.Empty;
    private readonly string _courseName = string.Empty;
    private readonly string _tuitionFee = string.Empty;

    public CourseDetailDialog() : this("CT-001", "IELTS Foundation", "6.000.000đ")
    {
    }

    public CourseDetailDialog(string courseCode, string courseName, string tuitionFee)
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _courseCode = courseCode;
        _courseName = courseName;
        _tuitionFee = tuitionFee;

        SetupView();
        LoadClasses();
        WireEvents();
    }

    private void SetupView()
    {
        lblTitle.Text = $"{_courseName}  ·  {_courseCode}";
        lblStatTuitionValue.Text = _tuitionFee;
    }

    private void LoadClasses()
    {
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp ↑", FillWeight = 16 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên phụ trách", FillWeight = 26 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lịch học", FillWeight = 24 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 14 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 10 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 16 });

        dgvClasses.Rows.Add("IELTS-F01", "Nguyễn Hoàng Anh", "T3 / T6 · 18:00–20:00", "P201", "20 / 20", "Đang học");
        dgvClasses.Rows.Add("IELTS-F02", "Trần Gia Bảo", "T2 / T5 · 19:30–21:30", "P202", "18 / 20", "Đang học");
        dgvClasses.Rows.Add("IELTS-F03", "Phạm Quỳnh Như", "T4 / T7 · 18:00–20:00", "P203", "19 / 20", "Đang học");
        dgvClasses.Rows.Add("IELTS-F04", "Nguyễn Hoàng Anh", "T7 / CN · 08:30–10:30", "P201", "12 / 20", "Sắp mở");

        dgvClasses.ClearSelection();
        dgvClasses.CurrentCell = null;
    }

    private void WireEvents()
    {
        btnEditCourse.Click += (s, e) =>
        {
            using var editDlg = new CourseEditDialog(_courseCode);
            if (editDlg.ShowDialog(this) == DialogResult.OK)
            {
                SetupView();
            }
        };

        btnCreateClass.Click += (s, e) =>
        {
            using var createClassDlg = new CreateClassDialog();
            createClassDlg.ShowDialog(this);
        };
    }
}
