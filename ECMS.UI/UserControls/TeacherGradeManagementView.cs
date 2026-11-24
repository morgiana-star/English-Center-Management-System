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

public partial class TeacherGradeManagementView : UserControl
{
    private readonly IExamService _examService = new ExamService();
    private readonly IClassService _classService = new ClassService();
    private List<ExamListItemDto> _allExams = new();
    private AppButton _btnManageExamSchedules = null!;
    private bool _isLoadingFilters = false;

    public TeacherGradeManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupHeaderButtons();
        SetupFilters();
        SetupGrid();
        WireEvents();
        _ = LoadDataAsync();
    }

    private void SetupHeaderButtons()
    {
        btnCreateAssessmentTop.Text = "Tạo bài kiểm tra";
        btnEnterGradesTop.Text = "Nhập điểm";

        _btnManageExamSchedules = new AppButton
        {
            Name = "btnManageExamSchedules",
            Text = "Quản lý lịch thi",
            Size = new Size(140, 36),
            Location = new Point(btnEnterGradesTop.Left - 150, btnEnterGradesTop.Top),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 5,
            Cursor = Cursors.Hand
        };
        pnlHeader.Controls.Add(_btnManageExamSchedules);
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
        cboTypeFilter.Items.Clear();
        cboTypeFilter.Items.AddRange(new object[]
        {
            "Tất cả loại bài thi",
            "Thường xuyên (TX)",
            "Giữa khóa (GK)",
            "Cuối khóa (CK)"
        });
        cboTypeFilter.SelectedIndex = 0;
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

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStt", HeaderText = "STT", FillWeight = 5 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTitle", HeaderText = "Tên bài kiểm tra", FillWeight = 22 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClass", HeaderText = "Lớp áp dụng", FillWeight = 11 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColType", HeaderText = "Loại bài thi", FillWeight = 13 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColWeight", HeaderText = "Trọng số", FillWeight = 8 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColDate", HeaderText = "Ngày & Giờ thi", FillWeight = 15 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColRoom", HeaderText = "Phòng thi", FillWeight = 9 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColProgress", HeaderText = "Tiến độ", FillWeight = 8 });
        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Trạng thái", FillWeight = 11 });

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Nhập điểm",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 10
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvAssessments.Columns.Add(colAction);
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _isLoadingFilters = true;
            var classes = (await _classService.GetClassesAsync()).ToList();
            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả lớp");
            foreach (var c in classes)
            {
                cboClassFilter.Items.Add(c.ClassCode);
            }
            cboClassFilter.SelectedIndex = 0;
            _isLoadingFilters = false;

            _allExams = (await _examService.GetAllExamsAsync()).ToList();
            FilterAndBind();
        }
        catch (Exception ex)
        {
            _isLoadingFilters = false;
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách bài kiểm tra", ex.Message);
        }
    }

    private void FilterAndBind()
    {
        string kw = txtSearchAssessment.Text.Trim().ToLowerInvariant();
        string cls = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";
        string type = cboTypeFilter.SelectedItem?.ToString() ?? "Tất cả loại bài thi";

        var filtered = _allExams.Where(x =>
            (cls == "Tất cả lớp" || x.ClassCode.Equals(cls, StringComparison.OrdinalIgnoreCase)) &&
            (type == "Tất cả loại bài thi" || x.TypeDisplay.Equals(type, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(kw) ||
             x.ExamName.ToLowerInvariant().Contains(kw) ||
             x.ClassCode.ToLowerInvariant().Contains(kw) ||
             x.RoomName.ToLowerInvariant().Contains(kw))).ToList();

        dgvAssessments.Rows.Clear();
        int stt = 1;
        foreach (var ex in filtered)
        {
            int idx = dgvAssessments.Rows.Add(
                stt++,
                ex.ExamName,
                ex.ClassCode,
                ex.TypeDisplay,
                $"{ex.WeightPercentage:0}%",
                $"{ex.ExamDateDisplay} ({ex.TimeRange})",
                ex.RoomName,
                ex.GradedRatio,
                ex.StatusDisplay);
            dgvAssessments.Rows[idx].Tag = ex;
        }
        dgvAssessments.ClearSelection();
    }

    private void WireEvents()
    {
        txtSearchAssessment.TextChanged += (s, e) => FilterAndBind();
        cboClassFilter.SelectedIndexChanged += (s, e) => { if (!_isLoadingFilters) FilterAndBind(); };
        cboTypeFilter.SelectedIndexChanged += (s, e) => { if (!_isLoadingFilters) FilterAndBind(); };

        btnCreateAssessmentTop.Click += async (s, e) =>
        {
            string defaultCls = cboClassFilter.SelectedIndex > 0 ? (cboClassFilter.SelectedItem?.ToString() ?? "") : "";
            using var dlg = new CreateAssessmentDialog(defaultCls);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        };

        btnEnterGradesTop.Click += async (s, e) =>
        {
            string defaultCls = cboClassFilter.SelectedIndex > 0 ? (cboClassFilter.SelectedItem?.ToString() ?? "") : "";
            using var dlg = new GradeEntryDialog(defaultCls);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadDataAsync();
            }
        };

        _btnManageExamSchedules.Click += async (s, e) =>
        {
            using var dlg = new ExamScheduleManagementDialog();
            dlg.ShowDialog(FindForm());
            if (dlg.HasChanged)
            {
                await LoadDataAsync();
            }
        };

        dgvAssessments.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAssessments.Columns[e.ColumnIndex].Name == "ColAction")
            {
                if (dgvAssessments.Rows[e.RowIndex].Tag is ExamListItemDto ex)
                {
                    using var dlg = new GradeEntryDialog(ex.ClassCode);
                    if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                    {
                        await LoadDataAsync();
                    }
                }
            }
        };
    }
}
