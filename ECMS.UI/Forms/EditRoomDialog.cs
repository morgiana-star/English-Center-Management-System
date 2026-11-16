using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class EditRoomDialog : Form
{
    private readonly bool _isEditMode;
    private readonly string _roomCode = string.Empty;

    public EditRoomDialog() : this(false, "", "", "24", "Đang sử dụng", "")
    {
    }

    public EditRoomDialog(bool isEditMode, string roomCode, string roomName, string capacity, string status, string notes)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _roomCode = roomCode;

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
            lblTitle.Text = "Chỉnh sửa phòng học";
            lblSubtitle.Text = $"Cập nhật thông tin phòng {roomCode}";
            txtRoomCode.Text = roomCode;
            txtRoomCode.ReadOnly = true;
            txtRoomName.Text = roomName;
            txtCapacity.Text = capacity;
            txtNotes.Text = notes;
            btnSave.Text = "Cập nhật";

            int idx = cboStatus.FindStringExact(status);
            if (idx >= 0) cboStatus.SelectedIndex = idx;
        }
        else
        {
            lblTitle.Text = "Thêm phòng học mới";
            lblSubtitle.Text = "Tạo phòng học mới trong hệ thống cơ sở vật chất";
            txtRoomCode.Text = "P204";
            txtRoomName.Text = "Phòng học mới";
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

        btnSave.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtRoomCode.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomCode.Focus();
                return;
            }

            string actionMsg = _isEditMode ? "cập nhật" : "thêm mới";
            MessageBox.Show($"Đã {actionMsg} phòng học '{txtRoomCode.Text} - {txtRoomName.Text}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
