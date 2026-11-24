using System;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class EditRoomDialog : Form
{
    private readonly IClassService _classService = new ClassService();
    private readonly bool _isEditMode;
    private readonly int _roomId;

    public EditRoomDialog() : this(false, 0, "", "", "24", "Đang sử dụng", "")
    {
    }

    public EditRoomDialog(bool isEditMode, int roomId, string roomCode, string roomName, string capacity, string status, string notes)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _roomId = roomId;

        SetupStatusDropdown();
        ApplyData(roomCode, roomName, capacity, status, notes);
        WireEvents();
    }

    private void SetupStatusDropdown()
    {
        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[] { "Đang sử dụng", "Bảo trì", "Ngừng sử dụng" });
        if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
    }

    private void ApplyData(string roomCode, string roomName, string capacity, string status, string notes)
    {
        if (_isEditMode)
        {
            Text = "Chỉnh sửa phòng học - ECMS";
            lblTitle.Text = "Chỉnh sửa phòng học";
            txtRoomCode.Text = roomCode;
            txtRoomCode.ReadOnly = true;
            txtRoomName.Text = roomName;
            txtCapacity.Text = capacity.Replace("chỗ", "", StringComparison.OrdinalIgnoreCase).Trim();
            txtNotes.Text = notes;
            btnSave.Text = "Cập nhật";

            int idx = cboStatus.FindStringExact(status);
            if (idx >= 0) cboStatus.SelectedIndex = idx;
        }
        else
        {
            Text = "Thêm phòng học mới - ECMS";
            lblTitle.Text = "Thêm phòng học mới";
            txtRoomCode.Text = "Tự động";
            txtRoomCode.ReadOnly = true;
            txtRoomName.Text = "";
            txtCapacity.Text = "24";
            txtNotes.Text = "Máy chiếu, Bảng từ, Điều hòa";
            btnSave.Text = "Thêm phòng";
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += async (s, e) =>
        {
            string roomName = txtRoomName.Text.Trim();
            if (string.IsNullOrWhiteSpace(roomName))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập tên phòng học.");
                txtRoomName.Focus();
                return;
            }

            string capRaw = txtCapacity.Text.Replace("chỗ", "", StringComparison.OrdinalIgnoreCase).Trim();
            if (!int.TryParse(capRaw, out int capacity) || capacity <= 0)
            {
                AppDialog.ShowWarning(this, "Dữ liệu không hợp lệ", "Sức chứa phòng phải là số nguyên dương.");
                txtCapacity.Focus();
                return;
            }

            var room = new ClassRoom
            {
                RoomId = _roomId,
                RoomName = roomName,
                Floor = 1,
                Capacity = capacity,
                Equipment = txtNotes.Text.Trim(),
                RoomStatus = cboStatus.SelectedItem?.ToString() ?? "Đang sử dụng"
            };

            btnSave.Enabled = false;
            try
            {
                var res = _isEditMode
                    ? await _classService.UpdateRoomAsync(room)
                    : await _classService.CreateRoomAsync(room);

                if (!res.Success)
                {
                    AppDialog.ShowWarning(this, "Không thể lưu phòng học", res.Message);
                    return;
                }

                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(this, "Lỗi lưu phòng học", ex.Message);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        };
    }
}
