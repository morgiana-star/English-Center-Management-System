using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RoomManagementDialog : Form
{
    private readonly List<string[]> _rooms = new();

    public RoomManagementDialog()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        LoadSampleRooms();
        WireEvents();
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

    private void LoadSampleRooms()
    {
        _rooms.Clear();
        _rooms.Add(new[] { "P201", "Phòng IELTS Chuyên sâu", "24 chỗ", "Máy chiếu Sony, Bảng từ, Loa Bluetooth", "Đang sử dụng" });
        _rooms.Add(new[] { "P202", "Phòng Giao tiếp & Thảo luận", "20 chỗ", "Màn hình tương tác 65\", Loa âm trần", "Đang sử dụng" });
        _rooms.Add(new[] { "P203", "Phòng Luyện thi TOEIC", "18 chỗ", "Máy chiếu Epson, Bảng kính, 18 tai nghe", "Đang sử dụng" });
        _rooms.Add(new[] { "P101", "Hội trường & Test đầu vào", "35 chỗ", "Máy chiếu công suất lớn, Âm thanh vòm", "Đang sử dụng" });
        _rooms.Add(new[] { "P102", "Phòng học đa năng", "15 chỗ", "Đang nâng cấp hệ thống điều hòa", "Bảo trì" });

        RenderRooms(_rooms);
    }

    private void RenderRooms(List<string[]> rooms)
    {
        dgvRooms.Rows.Clear();
        foreach (var r in rooms)
        {
            dgvRooms.Rows.Add(r[0], r[1], r[2], r[3], r[4], "Sửa");
        }
    }

    private void WireEvents()
    {
        btnAddRoom.Click += (s, e) =>
        {
            using var dlg = new EditRoomDialog(false, "", "", "24", "Đang sử dụng", "");
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                LoadSampleRooms();
            }
        };

        dgvRooms.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index)
            {
                var row = dgvRooms.Rows[e.RowIndex];
                string code = row.Cells[colCode.Index].Value?.ToString() ?? "";
                string name = row.Cells[colName.Index].Value?.ToString() ?? "";
                string cap = row.Cells[colCapacity.Index].Value?.ToString() ?? "20";
                string equip = row.Cells[colEquipment.Index].Value?.ToString() ?? "";
                string status = row.Cells[colStatus.Index].Value?.ToString() ?? "Đang sử dụng";

                using var dlg = new EditRoomDialog(true, code, name, cap, status, equip);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    LoadSampleRooms();
                }
            }
        };

        txtSearchRoom.TextChanged += (s, e) => FilterRooms();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterRooms();
        cboCapacityFilter.SelectedIndexChanged += (s, e) => FilterRooms();
    }

    private void FilterRooms()
    {
        string q = txtSearchRoom.Text.Trim().ToLower();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";

        var filtered = _rooms.FindAll(r =>
        {
            bool matchQ = string.IsNullOrEmpty(q) || r[0].ToLower().Contains(q) || r[1].ToLower().Contains(q);
            bool matchStatus = status == "Tất cả trạng thái" || r[4] == status;
            return matchQ && matchStatus;
        });

        RenderRooms(filtered);
    }
}
