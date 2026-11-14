using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RoomManagementDialog : Form
{
    public RoomManagementDialog()
    {
        InitializeComponent();

        SetupFilters();
        SetupRoomsGrid();
        LoadSampleRooms();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Đang sử dụng", "Bảo trì", "Tất cả trạng thái" });
        cboStatusFilter.SelectedIndex = 0;

        cboCapacityFilter.Items.Clear();
        cboCapacityFilter.Items.AddRange(new object[] { "Tất cả sức chứa", "Dưới 20 chỗ", "20 – 30 chỗ", "Trên 30 chỗ" });
        cboCapacityFilter.SelectedIndex = 0;

        cboRoomStatus.Items.Clear();
        cboRoomStatus.Items.AddRange(new object[] { "Đang sử dụng", "Bảo trì", "Ngừng sử dụng" });
        cboRoomStatus.SelectedIndex = 0;
    }

    private void SetupRoomsGrid()
    {
        dgvRooms.AutoGenerateColumns = false;
        dgvRooms.Columns.Clear();
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRooms.MultiSelect = false;
        dgvRooms.ReadOnly = true;
        dgvRooms.RowHeadersVisible = false;
        dgvRooms.AllowUserToAddRows = false;

        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Code",
            HeaderText = "Mã ↑",
            Width = 90
        });

        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Name",
            HeaderText = "Tên phòng",
            Width = 190
        });

        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Capacity",
            HeaderText = "Sức chứa",
            Width = 110
        });

        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 120
        });

        var actionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Sửa / Xem lịch",
            UseColumnTextForButtonValue = true,
            Width = 130
        };
        dgvRooms.Columns.Add(actionCol);
    }

    private void LoadSampleRooms()
    {
        var rooms = new[]
        {
            new RoomItem { Code = "P201", Name = "Phòng IELTS", Capacity = "24 chỗ", Status = "✓ Sẵn sàng", Notes = "Tầng 2 · có máy chiếu và loa" },
            new RoomItem { Code = "P202", Name = "Phòng TOEIC", Capacity = "24 chỗ", Status = "✓ Sẵn sàng", Notes = "Tầng 2 · bảng từ thông minh" },
            new RoomItem { Code = "P203", Name = "Phòng Giao tiếp", Capacity = "18 chỗ", Status = "✓ Sẵn sàng", Notes = "Tầng 2 · bàn tròn thảo luận nhóm" },
            new RoomItem { Code = "P204", Name = "Phòng dự phòng", Capacity = "20 chỗ", Status = "Bảo trì", Notes = "Đang bảo dưỡng hệ thống điều hòa" },
        };

        dgvRooms.DataSource = rooms;
        DisplayRoom(rooms[0]);
    }

    private void DisplayRoom(RoomItem room)
    {
        txtRoomCode.Text = room.Code;
        txtRoomName.Text = room.Name;
        txtRoomCapacity.Text = room.Capacity.Replace(" chỗ", "").Trim();
        txtRoomNotes.Text = room.Notes;

        if (room.Status.Contains("Sẵn sàng"))
        {
            cboRoomStatus.SelectedIndex = 0; // Đang sử dụng
        }
        else
        {
            cboRoomStatus.SelectedIndex = 1; // Bảo trì
        }
    }

    private void WireEvents()
    {
        btnAddRoom.Click += (s, e) =>
        {
            txtRoomCode.Text = "P" + (dgvRooms.Rows.Count + 201);
            txtRoomName.Text = "";
            txtRoomCapacity.Text = "24";
            txtRoomNotes.Text = "";
            cboRoomStatus.SelectedIndex = 0;
            txtRoomName.Focus();
        };

        dgvRooms.SelectionChanged += (s, e) =>
        {
            if (dgvRooms.CurrentRow?.DataBoundItem is RoomItem room)
            {
                DisplayRoom(room);
            }
        };

        btnCancelEdit.Click += (s, e) =>
        {
            if (dgvRooms.CurrentRow?.DataBoundItem is RoomItem room)
            {
                DisplayRoom(room);
            }
        };

        btnSaveRoom.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtRoomCode.Text) || string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng và Tên phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Đã lưu thông tin phòng {txtRoomCode.Text} ({txtRoomName.Text}) thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private class RoomItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
