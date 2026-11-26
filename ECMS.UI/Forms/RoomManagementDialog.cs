using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RoomManagementDialog : Form
{
    private List<dynamic> _rooms = new();

    public RoomManagementDialog()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupGrid();
        SetupFilters();
        _ = LoadRoomsDataAsync();
        WireEvents();
    }

    private void SetupGrid()
    {
        if (!dgvRooms.Columns.Contains("colRoomId"))
        {
            dgvRooms.Columns.Insert(0, new DataGridViewTextBoxColumn
            {
                Name = "colRoomId",
                HeaderText = "ID",
                Visible = false
            });
        }

        dgvRooms.CellFormatting += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvRooms.Columns[e.ColumnIndex].Name == colStatus.Name && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val.Contains("Đang sử dụng"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Xanh lá
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (val.Contains("Bảo trì"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9); // Cam
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139); // Xám
                }
            }
        };
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

    private async Task LoadRoomsDataAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();
            var sql = @"
                SELECT RoomId, 
                       COALESCE(RoomCode, 'P' || RoomId) AS RoomCode, 
                       RoomName, 
                       Capacity, 
                       Floor, 
                       COALESCE(Equipment, '') AS Equipment, 
                       COALESCE(Status, CASE WHEN IsActive = 1 THEN 'Đang sử dụng' ELSE 'Ngừng sử dụng' END) AS Status,
                       IsActive
                FROM ClassRooms
                ORDER BY RoomCode ASC;";

            var result = await conn.QueryAsync<dynamic>(sql);
            _rooms = result.ToList();
            FilterRooms();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách phòng học từ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RenderRooms(IEnumerable<dynamic> rooms)
    {
        dgvRooms.Rows.Clear();
        foreach (var r in rooms)
        {
            int roomId = Convert.ToInt32(r.RoomId);
            string code = (string)r.RoomCode;
            string name = (string)r.RoomName;
            int capacity = Convert.ToInt32(r.Capacity);
            string equipment = (string)r.Equipment;
            string status = (string)r.Status;

            dgvRooms.Rows.Add(roomId, code, name, $"{capacity} chỗ", equipment, status, "Sửa");
        }
    }

    private void WireEvents()
    {
        btnAddRoom.Click += async (s, e) =>
        {
            using var dlg = new EditRoomDialog(false, 0, "", "", "20", "Đang sử dụng", "");
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await LoadRoomsDataAsync();
            }
        };

        dgvRooms.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index)
            {
                OpenEditRoom(e.RowIndex);
            }
        };

        dgvRooms.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenEditRoom(e.RowIndex);
            }
        };

        txtSearchRoom.TextChanged += (s, e) => FilterRooms();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterRooms();
        cboCapacityFilter.SelectedIndexChanged += (s, e) => FilterRooms();
    }

    private void OpenEditRoom(int rowIndex)
    {
        var row = dgvRooms.Rows[rowIndex];
        int roomId = 0;
        if (row.Cells["colRoomId"].Value != null)
        {
            int.TryParse(row.Cells["colRoomId"].Value?.ToString(), out roomId);
        }

        string code = row.Cells[colCode.Index].Value?.ToString() ?? "";
        string name = row.Cells[colName.Index].Value?.ToString() ?? "";
        string capText = row.Cells[colCapacity.Index].Value?.ToString() ?? "20";
        string cap = capText.Replace(" chỗ", "").Trim();
        string equip = row.Cells[colEquipment.Index].Value?.ToString() ?? "";
        string status = row.Cells[colStatus.Index].Value?.ToString() ?? "Đang sử dụng";

        using var dlg = new EditRoomDialog(true, roomId, code, name, cap, status, equip);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            _ = LoadRoomsDataAsync();
        }
    }

    private void FilterRooms()
    {
        string q = txtSearchRoom.Text.Trim().ToLower();
        string statusFilter = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";
        string capacityFilter = cboCapacityFilter.SelectedItem?.ToString() ?? "Tất cả sức chứa";

        var filtered = _rooms.Where(r =>
        {
            string code = ((string)r.RoomCode).ToLower();
            string name = ((string)r.RoomName).ToLower();
            string equip = ((string)r.Equipment).ToLower();
            int cap = Convert.ToInt32(r.Capacity);
            string st = (string)r.Status;

            bool matchQ = string.IsNullOrEmpty(q) || code.Contains(q) || name.Contains(q) || equip.Contains(q);
            bool matchStatus = statusFilter == "Tất cả trạng thái" || st == statusFilter;

            bool matchCapacity = true;
            if (capacityFilter == "Dưới 20 chỗ") matchCapacity = cap < 20;
            else if (capacityFilter == "20 – 30 chỗ") matchCapacity = cap >= 20 && cap <= 30;
            else if (capacityFilter == "Trên 30 chỗ") matchCapacity = cap > 30;

            return matchQ && matchStatus && matchCapacity;
        });

        RenderRooms(filtered);
    }
}
