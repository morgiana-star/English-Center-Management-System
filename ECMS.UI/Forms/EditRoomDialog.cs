using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;

namespace ECMS.UI.Forms;

public partial class EditRoomDialog : Form
{
    private readonly bool _isEditMode;
    private readonly int _roomId;
    private readonly string _roomCode = string.Empty;

    public EditRoomDialog() : this(false, 0, "", "", "24", "Đang sử dụng", "")
    {
    } 

    public EditRoomDialog(bool isEditMode, string roomCode, string roomName, string capacity, string status, string notes)
        : this(isEditMode, 0, roomCode, roomName, capacity, status, notes)
    {
    }

    public EditRoomDialog(bool isEditMode, int roomId, string roomCode, string roomName, string capacity, string status, string notes)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _roomId = roomId;
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
            txtNotes.Text = "Máy chiếu Sony, Bảng từ, Loa Bluetooth";
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
            string code = txtRoomCode.Text.Trim();
            string name = txtRoomName.Text.Trim();
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập Tên phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomName.Focus();
                return;
            }

            if (!int.TryParse(txtCapacity.Text.Trim(), out int cap) || cap <= 0)
            {
                MessageBox.Show("Sức chứa phải là số nguyên dương lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacity.Focus();
                return;
            }

            string status = cboStatus.SelectedItem?.ToString() ?? "Đang sử dụng";
            string notes = txtNotes.Text.Trim();
            int isActive = status == "Đang sử dụng" ? 1 : 0;

            try
            {
                btnSave.Enabled = false;
                using var conn = DatabaseConfig.GetConnection();

                if (!_isEditMode)
                {
                    int exists = await conn.ExecuteScalarAsync<int>(
                        "SELECT COUNT(*) FROM ClassRooms WHERE RoomCode = @Code;", new { Code = code });
                    if (exists > 0)
                    {
                        MessageBox.Show($"Mã phòng '{code}' đã tồn tại trong hệ thống. Vui lòng chọn mã khác.", "Trùng mã phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int floor = 1;
                    foreach (char c in code)
                    {
                        if (char.IsDigit(c))
                        {
                            floor = Math.Max(1, c - '0');
                            break;
                        }
                    }

                    await conn.ExecuteAsync(@"
                        INSERT INTO ClassRooms (RoomCode, RoomName, Floor, Capacity, Equipment, Status, HasProjector, IsActive)
                        VALUES (@Code, @Name, @Floor, @Capacity, @Equipment, @Status, 1, @IsActive);",
                        new { Code = code, Name = name, Floor = floor, Capacity = cap, Equipment = notes, Status = status, IsActive = isActive });

                    MessageBox.Show($"Đã thêm phòng học '{code} - {name}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await conn.ExecuteAsync(@"
                        UPDATE ClassRooms 
                        SET RoomName = @Name, Capacity = @Capacity, Equipment = @Equipment, 
                            Status = @Status, IsActive = @IsActive, UpdatedAt = CURRENT_TIMESTAMP
                        WHERE RoomId = @RoomId OR RoomCode = @Code;",
                        new { RoomId = _roomId, Code = _roomCode, Name = name, Capacity = cap, Equipment = notes, Status = status, IsActive = isActive });

                    MessageBox.Show($"Đã cập nhật phòng học '{code} - {name}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu thông tin phòng học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        };
    }
}
