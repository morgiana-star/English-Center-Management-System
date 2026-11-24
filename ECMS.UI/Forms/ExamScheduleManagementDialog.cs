using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ExamScheduleManagementDialog : Form
{
    private readonly IExamService _examService = new ExamService();
    private List<ExamListItemDto> _allExams = new();
    public bool HasChanged { get; private set; }

    public ExamScheduleManagementDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupGrid();
        WireEvents();
        _ = LoadDataAsync();
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvExamSchedules);
        dgvExamSchedules.Columns.Clear();
        dgvExamSchedules.Columns.Add("ColDate", "Ngày thi");
        dgvExamSchedules.Columns.Add("ColTime", "Giờ thi");
        dgvExamSchedules.Columns.Add("ColRoom", "Phòng thi");
        dgvExamSchedules.Columns.Add("ColClass", "Mã lớp");
        dgvExamSchedules.Columns.Add("ColName", "Tên bài thi");
        dgvExamSchedules.Columns.Add("ColType", "Loại thi");
        dgvExamSchedules.Columns.Add("ColWeight", "Trọng số");

        var colDel = new DataGridViewButtonColumn
        {
            Name = "ColDelete",
            HeaderText = "Thao tác",
            Text = "Xóa",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat
        };
        colDel.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
        dgvExamSchedules.Columns.Add(colDel);

        dgvExamSchedules.Columns["ColDate"]!.FillWeight = 11;
        dgvExamSchedules.Columns["ColTime"]!.FillWeight = 13;
        dgvExamSchedules.Columns["ColRoom"]!.FillWeight = 10;
        dgvExamSchedules.Columns["ColClass"]!.FillWeight = 12;
        dgvExamSchedules.Columns["ColName"]!.FillWeight = 24;
        dgvExamSchedules.Columns["ColType"]!.FillWeight = 14;
        dgvExamSchedules.Columns["ColWeight"]!.FillWeight = 8;
        dgvExamSchedules.Columns["ColDelete"]!.FillWeight = 8;
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _allExams = (await _examService.GetAllExamsAsync()).ToList();

            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả lớp");
            foreach (var cls in _allExams.Select(x => x.ClassCode).Distinct().OrderBy(x => x))
            {
                cboClassFilter.Items.Add(cls);
            }
            cboClassFilter.SelectedIndex = 0;

            FilterAndBind();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách lịch thi", ex.Message);
        }
    }

    private void FilterAndBind()
    {
        string kw = txtSearch.Text.Trim().ToLowerInvariant();
        string cls = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";

        var filtered = _allExams.Where(x =>
            (cls == "Tất cả lớp" || x.ClassCode.Equals(cls, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(kw) ||
             x.ExamName.ToLowerInvariant().Contains(kw) ||
             x.ClassCode.ToLowerInvariant().Contains(kw) ||
             x.RoomName.ToLowerInvariant().Contains(kw) ||
             x.ExamDateDisplay.Contains(kw))).ToList();

        dgvExamSchedules.Rows.Clear();
        foreach (var e in filtered)
        {
            int idx = dgvExamSchedules.Rows.Add(
                e.ExamDateDisplay,
                e.TimeRange,
                e.RoomName,
                e.ClassCode,
                e.ExamName,
                e.TypeDisplay,
                $"{e.WeightPercentage:0}%");
            dgvExamSchedules.Rows[idx].Tag = e;
        }
        dgvExamSchedules.ClearSelection();
        lblSummary.Text = $"Đang hiển thị: {filtered.Count} / {_allExams.Count} lịch thi";
    }

    private void WireEvents()
    {
        btnClose.Click += (s, e) => Close();
        txtSearch.TextChanged += (s, e) => FilterAndBind();
        cboClassFilter.SelectedIndexChanged += (s, e) => FilterAndBind();

        dgvExamSchedules.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex < 0 || dgvExamSchedules.Columns[e.ColumnIndex].Name != "ColDelete") return;
            if (dgvExamSchedules.Rows[e.RowIndex].Tag is not ExamListItemDto exam) return;

            if (AppDialog.ShowConfirm(this, "Xác nhận xóa lịch thi",
                $"Bạn có chắc chắn muốn xóa lịch thi '{exam.ExamName}' của lớp '{exam.ClassCode}' ({exam.ExamDateDisplay} {exam.TimeRange}) không?",
                "Xóa", "Hủy") != DialogResult.OK)
                return;

            var res = await _examService.DeleteExamAsync(exam.ExamId);
            if (res.Success)
            {
                HasChanged = true;
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                await LoadDataAsync();
            }
            else
            {
                AppDialog.ShowWarning(this, "Không thể xóa lịch thi", res.Message);
            }
        };
    }
}
