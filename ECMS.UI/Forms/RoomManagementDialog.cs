using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RoomManagementDialog : Form
{
    private readonly IClassService _classService = new ClassService();
    private List<ClassRoom> _rooms = new();

    public RoomManagementDialog()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        WireEvents();
        _ = LoadRoomsAsync();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang sử dụng", "Bảo trì", "Ngừng sử dụng" });
        if (cboStatusFilter.Items.Count > 0) cboStatusFilter.SelectedIndex = 0;

        cboCapacityFilter.Items.Clear();
        cboCapacityFilter.Items.AddRange(new object[] { "Tất cả sức chứa", "Dưới 20 chỗ", "20 – 30 chỗ", "Trên 30 chỗ" });
        if (cboCapacityFilter.Items.Count > 0) cboCapacityFilter.SelectedIndex = 0;
    }

    private async Task LoadRoomsAsync()
    {
        try
        {
            string? kw = string.IsNullOrWhiteSpace(txtSearchRoom.Text) ? null : txtSearchRoom.Text.Trim();
            string? status = cboStatusFilter.SelectedItem?.ToString();
            string? cap = cboCapacityFilter.SelectedItem?.ToString();

            _rooms = new List<ClassRoom>(await _classService.GetRoomsAsync(kw, status, cap));
            RenderRooms(_rooms);
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách phòng học", ex.Message);
        }
    }

    private void RenderRooms(List<ClassRoom> rooms)
    {
        dgvRooms.Rows.Clear();
        foreach (var r in rooms)
        {
            string code = $"PH-{r.RoomId:D3}";
            int idx = dgvRooms.Rows.Add(
                code,
                r.RoomName,
                $"{r.Capacity} chỗ",
                string.IsNullOrWhiteSpace(r.Equipment) ? "Tiêu chuẩn" : r.Equipment,
                r.RoomStatus,
                "Sửa"
            );
            dgvRooms.Rows[idx].Tag = r;
        }
        dgvRooms.ClearSelection();
        dgvRooms.CurrentCell = null;
    }

    private void WireEvents()
    {
        btnAddRoom.Click += async (s, e) =>
        {
            using var dlg = new EditRoomDialog(false, 0, "", "", "24", "Đang sử dụng", "Máy chiếu, Bảng từ, Điều hòa");
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadRoomsAsync();
            }
        };

        dgvRooms.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index)
            {
                var row = dgvRooms.Rows[e.RowIndex];
                if (row.Tag is not ClassRoom room) return;

                string code = row.Cells[colCode.Index].Value?.ToString() ?? $"PH-{room.RoomId:D3}";
                using var dlg = new EditRoomDialog(
                    true,
                    room.RoomId,
                    code,
                    room.RoomName,
                    room.Capacity.ToString(),
                    room.RoomStatus,
                    room.Equipment);

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadRoomsAsync();
                }
            }
        };

        txtSearchRoom.TextChanged += async (s, e) => await LoadRoomsAsync();
        cboStatusFilter.SelectedIndexChanged += async (s, e) => await LoadRoomsAsync();
        cboCapacityFilter.SelectedIndexChanged += async (s, e) => await LoadRoomsAsync();
    }
}
