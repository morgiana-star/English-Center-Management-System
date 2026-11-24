using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class CourseManagementView : UserControl
{
    private readonly ICourseService _courseService = new CourseService();
    private List<Course> _allCourses = new();
    private Panel _pnlFooter = null!;
    private Label _lblBottomSummary = null!;

    public CourseManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFooterSummary();
        SetupFilters();
        SetupGrid();
        WireEvents();
        _ = LoadRealCoursesAsync();
    }

    private void SetupFooterSummary()
    {
        btnAddCourse.Text = "Thêm khóa học";

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
            Text = "Đang hiển thị: 0  |  Tổng khóa học: 0  |  Đang sử dụng: 0  |  Tạm dừng: 0"
        };
        _pnlFooter.Controls.Add(_lblBottomSummary);

        dgvCourses.Height = Math.Max(300, cardCourseList.Height - dgvCourses.Top - _pnlFooter.Height - 16);
        cardCourseList.Controls.Add(_pnlFooter);
        _pnlFooter.BringToFront();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Đang sử dụng",
            "Tạm dừng"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboLevelFilter.Items.Clear();
        cboLevelFilter.Items.Add("Tất cả trình độ");
        cboLevelFilter.Items.AddRange(StatusFormatter.CourseLevels);
        cboLevelFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvCourses);
        dgvCourses.AutoGenerateColumns = false;
        dgvCourses.Columns.Clear();
        dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCourses.MultiSelect = false;
        dgvCourses.ReadOnly = true;
        dgvCourses.RowHeadersVisible = false;
        dgvCourses.AllowUserToAddRows = false;

        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã khóa", FillWeight = 13 });
        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColName", HeaderText = "Tên khóa học", FillWeight = 26 });
        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColLevel", HeaderText = "Trình độ", FillWeight = 15 });
        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSessions", HeaderText = "Số buổi", FillWeight = 10 });
        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColFee", HeaderText = "Học phí gốc", FillWeight = 14 });
        dgvCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Trạng thái", FillWeight = 12 });

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Xem chi tiết",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 12
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvCourses.Columns.Add(colAction);
    }

    private async Task LoadRealCoursesAsync()
    {
        try
        {
            _allCourses = (await _courseService.GetCoursesAsync()).ToList();
            FilterCourses();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách khóa học", ex.Message);
        }
    }

    private void WireEvents()
    {
        btnAddCourse.Click += async (s, e) =>
        {
            using var editDlg = new CourseEditDialog();
            if (editDlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadRealCoursesAsync();
            }
        };

        dgvCourses.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvCourses.Columns[e.ColumnIndex].Name == "ColAction")
            {
                await OpenCourseDetailAsync(e.RowIndex);
            }
        };

        dgvCourses.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                await OpenCourseDetailAsync(e.RowIndex);
            }
        };

        txtSearchCourse.TextChanged += (s, e) => FilterCourses();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterCourses();
        cboLevelFilter.SelectedIndexChanged += (s, e) => FilterCourses();
    }

    private async Task OpenCourseDetailAsync(int rowIndex)
    {
        if (dgvCourses.Rows[rowIndex].Tag is not Course course) return;
        using var detailDlg = new CourseDetailDialog(course.CourseCode, course.CourseName, $"{course.BaseTuitionFee:N0} đ");
        detailDlg.ShowDialog(FindForm());
        await LoadRealCoursesAsync();
    }

    private void FilterCourses()
    {
        string kw = txtSearchCourse.Text.Trim().ToLowerInvariant();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";
        string level = cboLevelFilter.SelectedItem?.ToString() ?? "Tất cả trình độ";

        var filtered = _allCourses.Where(c =>
        {
            string formattedLevel = StatusFormatter.FormatCourseLevel(c.Level);
            string statusDisplay = c.IsActive ? "Đang sử dụng" : "Tạm dừng";

            bool matchKw = string.IsNullOrEmpty(kw) ||
                           c.CourseCode.ToLowerInvariant().Contains(kw) ||
                           c.CourseName.ToLowerInvariant().Contains(kw);
            bool matchStatus = status == "Tất cả trạng thái" || statusDisplay == status;
            bool matchLevel = level == "Tất cả trình độ" || formattedLevel.Equals(level, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchStatus && matchLevel;
        }).ToList();

        dgvCourses.Rows.Clear();
        foreach (var c in filtered)
        {
            int idx = dgvCourses.Rows.Add(
                c.CourseCode,
                c.CourseName,
                StatusFormatter.FormatCourseLevel(c.Level),
                $"{c.TotalSessions} buổi",
                $"{c.BaseTuitionFee:N0} đ",
                c.IsActive ? "Đang sử dụng" : "Tạm dừng"
            );
            dgvCourses.Rows[idx].Tag = c;
        }

        dgvCourses.ClearSelection();
        dgvCourses.CurrentCell = null;

        int activeCnt = _allCourses.Count(x => x.IsActive);
        int inactiveCnt = _allCourses.Count - activeCnt;
        _lblBottomSummary.Text =
            $"Đang hiển thị: {filtered.Count}  |  Tổng khóa học: {_allCourses.Count}  |  Đang sử dụng: {activeCnt}  |  Tạm dừng: {inactiveCnt}";
    }
}
