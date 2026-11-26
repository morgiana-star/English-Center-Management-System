using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ClassManagementView : UserControl
{
    private readonly IClassService _classService = new ClassService();
    private readonly ICourseService _courseService = new CourseService();
    private List<ClassListItemDto> _allClasses = new();
    private Panel _pnlFooter = null!;
    private Label _lblBottomSummary = null!;
    private bool _isLoadingFilter = false;

    public ClassManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFooterSummary();
        SetupGrid();
        WireEvents();
        _ = LoadInitialDataAsync();
    }

    private void SetupFooterSummary()
    {
        btnAddClass.Text = "Tạo lớp học";

        _pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 36,
            BackColor = Color.FromArgb(248, 250, 252),
            Padding = new Padding(12, 6, 12, 6)
        };
        _lblBottomSummary = new Label
        {
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(51, 65, 85),
            TextAlign = ContentAlignment.MiddleRight,
            Text = "Đang hiển thị: 0  |  Tổng lớp học: 0  |  Đang học: 0  |  Sắp mở: 0"
        };
        _pnlFooter.Controls.Add(_lblBottomSummary);

        dgvClasses.Height = Math.Max(300, cardClassList.Height - dgvClasses.Top - _pnlFooter.Height - 16);
        cardClassList.Controls.Add(_pnlFooter);
        _pnlFooter.BringToFront();
    }

    private async Task LoadInitialDataAsync()
    {
        await SetupFiltersFromDbAsync();
        await LoadRealClassesAsync();
    }

    private async Task SetupFiltersFromDbAsync()
    {
        try
        {
            _isLoadingFilter = true;
            cboCourseFilter.Items.Clear();
            cboCourseFilter.Items.Add("Tất cả khóa học");
            var courses = await _courseService.GetCoursesAsync();
            foreach (var c in courses)
            {
                cboCourseFilter.Items.Add(c.CourseName);
            }
            cboCourseFilter.SelectedIndex = 0;

            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("Tất cả trạng thái");
            cboStatusFilter.Items.AddRange(StatusFormatter.ClassStatusOptions);
            cboStatusFilter.SelectedIndex = 0;
        }
        finally
        {
            _isLoadingFilter = false;
        }
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvClasses);
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Columns.Clear();
        dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.MultiSelect = false;
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.AllowUserToAddRows = false;

        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã lớp", FillWeight = 11 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCourse", HeaderText = "Khóa học", FillWeight = 16 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTeacher", HeaderText = "Giáo viên phụ trách", FillWeight = 16 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColRoom", HeaderText = "Phòng", FillWeight = 8 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCapacity", HeaderText = "Sĩ số", FillWeight = 8 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSchedule", HeaderText = "Lịch học & Giờ", FillWeight = 24 });
        dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Trạng thái", FillWeight = 11 });

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Xem chi tiết",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 10
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvClasses.Columns.Add(colAction);
    }

    private async Task LoadRealClassesAsync()
    {
        try
        {
            _allClasses = (await _classService.GetClassesAsync()).ToList();
            FilterClasses();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách lớp học", ex.Message);
        }
    }

    private void WireEvents()
    {
        btnAddClass.Click += async (s, e) =>
        {
            using var createDlg = new CreateClassDialog();
            if (createDlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadRealClassesAsync();
            }
        };

        dgvClasses.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvClasses.Columns[e.ColumnIndex].Name == "ColAction")
            {
                await OpenClassDetailAsync(e.RowIndex);
            }
        };

        dgvClasses.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                await OpenClassDetailAsync(e.RowIndex);
            }
        };

        txtSearchClass.TextChanged += (s, e) => FilterClasses();
        cboCourseFilter.SelectedIndexChanged += (s, e) => { if (!_isLoadingFilter) FilterClasses(); };
        cboStatusFilter.SelectedIndexChanged += (s, e) => { if (!_isLoadingFilter) FilterClasses(); };
    }

    private async Task OpenClassDetailAsync(int rowIndex)
    {
        if (dgvClasses.Rows[rowIndex].Tag is not ClassListItemDto cl) return;
        using var detailDlg = new ClassDetailDialog(cl.ClassId, cl.ClassCode, cl.CourseName, cl.TeacherName, cl.MaxStudents);
        detailDlg.ShowDialog(FindForm());
        await LoadRealClassesAsync();
    }

    private void FilterClasses()
    {
        string kw = txtSearchClass.Text.Trim().ToLowerInvariant();
        string course = cboCourseFilter.SelectedItem?.ToString() ?? "Tất cả khóa học";
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";

        var filtered = _allClasses.Where(cl =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           cl.ClassCode.ToLowerInvariant().Contains(kw) ||
                           cl.CourseName.ToLowerInvariant().Contains(kw) ||
                           cl.TeacherName.ToLowerInvariant().Contains(kw) ||
                           cl.ScheduleInfo.ToLowerInvariant().Contains(kw);
            bool matchCourse = course == "Tất cả khóa học" ||
                               cl.CourseName.Equals(course, StringComparison.OrdinalIgnoreCase);
            bool matchStatus = status == "Tất cả trạng thái" ||
                               cl.Status.Equals(status, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchCourse && matchStatus;
        }).ToList();

        dgvClasses.Rows.Clear();
        foreach (var cl in filtered)
        {
            int idx = dgvClasses.Rows.Add(
                cl.ClassCode,
                cl.CourseName,
                cl.TeacherName,
                cl.RoomName,
                $"{cl.CurrentStudents} / {cl.MaxStudents}",
                cl.ScheduleInfo,
                cl.Status
            );
            dgvClasses.Rows[idx].Tag = cl;
        }

        dgvClasses.ClearSelection();
        dgvClasses.CurrentCell = null;

        int inProgressCnt = _allClasses.Count(x => x.Status == "Đang học");
        int openCnt = _allClasses.Count(x => x.Status == "Sắp mở" || x.Status == "Đang tuyển sinh");
        _lblBottomSummary.Text =
            $"Đang hiển thị: {filtered.Count}  |  Tổng lớp học: {_allClasses.Count}  |  Đang học: {inProgressCnt}  |  Sắp mở: {openCnt}";
    }
}
