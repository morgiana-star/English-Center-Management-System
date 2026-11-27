using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// Phân hệ Điểm số
/// </summary>
public partial class TeacherGradeManagementView : UserControl
{
    private readonly IClassService _classService = new ClassService();
    private List<ClassListItemDto> _allClasses = new();
    private bool _isLoadingFilters;

    public TeacherGradeManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        ConfigureSimplifiedGradeMode();
        SetupFilters();
        SetupGrid();
        WireEvents();
        _ = LoadDataAsync();
    }

    private void ConfigureSimplifiedGradeMode()
    {
        // Bỏ luồng tạo bài kiểm tra & quản lý lịch thi rườm rà; chỉ giữ Nhập điểm trực tiếp theo Lớp
        btnCreateAssessmentTop.Visible = false;
        cboTypeFilter.Visible = false;
        btnEnterGradesTop.Text = "Nhập điểm theo lớp";
        lblTitle.Text = "Quản lý điểm số";
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustLayout();
    }

    private void AdjustLayout()
    {
        if (pnlBody == null || pnlFilterBar == null || cardAssessmentList == null) return;

        int pad = 24;
        int availWidth = Math.Max(700, pnlBody.ClientSize.Width - pad * 2);
        int topY = 16;

        pnlFilterBar.SetBounds(pad, topY, availWidth, 48);

        int cardY = pnlFilterBar.Bottom + 12;
        int cardHeight = Math.Max(300, pnlBody.ClientSize.Height - cardY - pad);
        cardAssessmentList.SetBounds(pad, cardY, availWidth, cardHeight);
    }

    private void SetupFilters()
    {
        cboClassFilter.Items.Clear();
        cboClassFilter.Items.Add("Tất cả khóa học");
        cboClassFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvAssessments);
        dgvAssessments.AutoGenerateColumns = false;
        dgvAssessments.Columns.Clear();
        dgvAssessments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAssessments.MultiSelect = false;
        dgvAssessments.ReadOnly = true;
        dgvAssessments.RowHeadersVisible = false;
        dgvAssessments.AllowUserToAddRows = false;
        dgvAssessments.AllowUserToDeleteRows = false;

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStt", HeaderText = "STT", FillWeight = 7 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClass", HeaderText = "Mã lớp", FillWeight = 16 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCourse", HeaderText = "Khóa học", FillWeight = 25 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTeacher", HeaderText = "Giáo viên phụ trách", FillWeight = 22 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColRoom", HeaderText = "Phòng", FillWeight = 12 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSize", HeaderText = "Sĩ số", FillWeight = 12 });

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Nhập điểm",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 14
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvAssessments.Columns.Add(colAction);
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _isLoadingFilters = true;
            var list = (await _classService.GetClassesAsync())
                .Where(c => !c.Status.Contains("Sắp mở", StringComparison.OrdinalIgnoreCase) &&
                            !c.Status.Contains("Planning", StringComparison.OrdinalIgnoreCase) &&
                            !c.Status.Contains("OpenForEnrollment", StringComparison.OrdinalIgnoreCase))
                .ToList();

            bool isTeacher = string.Equals(AppSession.RoleCode, "ROLE_TEA", StringComparison.OrdinalIgnoreCase);
            if (isTeacher && !string.IsNullOrWhiteSpace(AppSession.FullName))
            {
                string tName = AppSession.FullName.Trim();
                list = list.Where(c =>
                    !string.IsNullOrWhiteSpace(c.TeacherName) &&
                    (c.TeacherName.Contains(tName, StringComparison.OrdinalIgnoreCase) ||
                     tName.Contains(c.TeacherName, StringComparison.OrdinalIgnoreCase))).ToList();
            }

            _allClasses = list;

            var courseNames = _allClasses
                .Select(c => c.CourseName)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(n => n)
                .ToList();

            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả khóa học");
            foreach (var cn in courseNames)
            {
                cboClassFilter.Items.Add(cn);
            }
            cboClassFilter.SelectedIndex = 0;
            _isLoadingFilters = false;

            FilterAndBind();
        }
        catch (Exception ex)
        {
            _isLoadingFilters = false;
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách lớp học", ex.Message);
        }
    }

    private void FilterAndBind()
    {
        string kw = txtSearchAssessment.Text.Trim().ToLowerInvariant();
        string course = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả khóa học";

        var filtered = _allClasses.Where(c =>
            (course == "Tất cả khóa học" || c.CourseName.Equals(course, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(kw) ||
             c.ClassCode.ToLowerInvariant().Contains(kw) ||
             c.CourseName.ToLowerInvariant().Contains(kw) ||
             c.TeacherName.ToLowerInvariant().Contains(kw))).ToList();

        dgvAssessments.Rows.Clear();
        int stt = 1;
        foreach (var c in filtered)
        {
            int idx = dgvAssessments.Rows.Add(
                stt++,
                c.ClassCode,
                c.CourseName,
                c.TeacherName,
                c.RoomName,
                $"{c.CurrentStudents} / {c.MaxStudents}",
                "Nhập điểm");
            dgvAssessments.Rows[idx].Tag = c;
        }
        dgvAssessments.ClearSelection();
        dgvAssessments.CurrentCell = null;
    }

    private void WireEvents()
    {
        txtSearchAssessment.TextChanged += (s, e) => FilterAndBind();
        cboClassFilter.SelectedIndexChanged += (s, e) => { if (!_isLoadingFilters) FilterAndBind(); };

        btnEnterGradesTop.Click += async (s, e) =>
        {
            string defaultCls = "";
            if (dgvAssessments.CurrentRow?.Tag is ClassListItemDto sel)
                defaultCls = sel.ClassCode;
            using var dlg = new GradeEntryDialog(defaultCls);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        };

        dgvAssessments.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAssessments.Columns[e.ColumnIndex].Name == "ColAction")
            {
                if (dgvAssessments.Rows[e.RowIndex].Tag is ClassListItemDto cls)
                {
                    using var dlg = new GradeEntryDialog(cls.ClassCode);
                    if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                    {
                        await LoadDataAsync();
                    }
                }
            }
        };

        dgvAssessments.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAssessments.Rows[e.RowIndex].Tag is ClassListItemDto cls)
            {
                using var dlg = new GradeEntryDialog(cls.ClassCode);
                if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    await LoadDataAsync();
                }
            }
        };
    }
}
