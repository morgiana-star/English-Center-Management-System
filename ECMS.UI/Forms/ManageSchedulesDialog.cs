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

public partial class ManageSchedulesDialog : Form
{
    private readonly IScheduleService _scheduleService = new ScheduleService();
    private List<ScheduleSummaryItemDto> _allItems = new();
    public bool HasChanged { get; private set; }

    public ManageSchedulesDialog()
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
        AppGridHelper.ApplyStyle(dgvSchedules);
        dgvSchedules.Columns.Clear();
        dgvSchedules.Columns.Add("ColClass", "Mã lớp");
        dgvSchedules.Columns.Add("ColRoom", "Phòng");
        dgvSchedules.Columns.Add("ColTeacher", "Giáo viên");
        dgvSchedules.Columns.Add("ColTime", "Thời gian học");
        dgvSchedules.Columns.Add("ColStart", "Ngày bắt đầu");
        dgvSchedules.Columns.Add("ColEnd", "Ngày kết thúc");
        dgvSchedules.Columns.Add("ColSessions", "Số buổi");

        var colDel = new DataGridViewButtonColumn
        {
            Name = "ColDelete",
            HeaderText = "Thao tác",
            Text = "Xóa lịch",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat
        };
        colDel.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
        dgvSchedules.Columns.Add(colDel);

        dgvSchedules.Columns["ColClass"]!.FillWeight = 11;
        dgvSchedules.Columns["ColRoom"]!.FillWeight = 9;
        dgvSchedules.Columns["ColTeacher"]!.FillWeight = 17;
        dgvSchedules.Columns["ColTime"]!.FillWeight = 23;
        dgvSchedules.Columns["ColStart"]!.FillWeight = 11;
        dgvSchedules.Columns["ColEnd"]!.FillWeight = 11;
        dgvSchedules.Columns["ColSessions"]!.FillWeight = 8;
        dgvSchedules.Columns["ColDelete"]!.FillWeight = 10;
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _allItems = (await _scheduleService.GetClassScheduleSummariesAsync()).ToList();
            FilterAndBind();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách lịch học", ex.Message);
        }
    }

    private void FilterAndBind()
    {
        string kw = txtSearch.Text.Trim().ToLowerInvariant();
        var filtered = _allItems.Where(x =>
            string.IsNullOrEmpty(kw) ||
            x.ClassCode.ToLowerInvariant().Contains(kw) ||
            x.TeacherName.ToLowerInvariant().Contains(kw) ||
            x.RoomName.ToLowerInvariant().Contains(kw) ||
            x.SchedulePattern.ToLowerInvariant().Contains(kw)).ToList();

        dgvSchedules.Rows.Clear();
        foreach (var item in filtered)
        {
            int idx = dgvSchedules.Rows.Add(
                item.ClassCode,
                item.RoomName,
                item.TeacherName,
                item.SchedulePattern,
                item.StartDateDisplay,
                item.EndDateDisplay,
                $"{item.SessionCount} buổi");
            dgvSchedules.Rows[idx].Tag = item;
        }
        dgvSchedules.ClearSelection();
        lblSummary.Text = $"Đang hiển thị: {filtered.Count} / {_allItems.Count} lịch lớp";
    }

    private void WireEvents()
    {
       
        txtSearch.TextChanged += (s, e) => FilterAndBind();

        dgvSchedules.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex < 0 || dgvSchedules.Columns[e.ColumnIndex].Name != "ColDelete") return;
            if (dgvSchedules.Rows[e.RowIndex].Tag is not ScheduleSummaryItemDto item) return;

            if (AppDialog.ShowConfirm(this, "Xác nhận xóa lịch học",
                $"Bạn có chắc chắn muốn xóa toàn bộ {item.SessionCount} buổi học của lớp '{item.ClassCode}' không?\n(Chỉ xóa được khi lớp chưa phát sinh điểm danh.)",
                "Xóa lịch", "Hủy") != DialogResult.OK)
                return;

            var res = await _scheduleService.DeleteClassSchedulesAsync(item.ClassId);
            if (res.Success)
            {
                HasChanged = true;
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                await LoadDataAsync();
            }
            else
            {
                AppDialog.ShowWarning(this, "Không thể xóa lịch học", res.Message);
            }
        };
    }
}
