using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.Core.Enums;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateClassDialog : Form
{
    private class CourseComboItem
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public override string ToString() => CourseName;
    }

    private class TeacherComboItem
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public override string ToString() => TeacherName;
    }

    private class RoomComboItem
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public override string ToString() => $"{RoomName} · {Capacity} chỗ";
    }

    private readonly IClassService _classService = new ClassService();
    private readonly bool _isEditMode;
    private readonly string _initialClassCode = string.Empty;

    public CreateClassDialog() : this(false, "")
    {
    }

    public CreateClassDialog(bool isEditMode = false, string classCode = "")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _isEditMode = isEditMode;
        _initialClassCode = classCode;

        SetupDropdowns();
        ApplyMode();
        WireEvents();
    }

    private void ApplyMode()
    {
        if (_isEditMode)
        {
            Text = "Chỉnh sửa thông tin lớp học · ECMS";
            lblTitle.Text = "Chỉnh sửa thông tin lớp học";
            btnSaveDraft.Text = "Lưu thay đổi";
            txtClassCode.Text = string.IsNullOrEmpty(_initialClassCode) ? "IELTS-F01" : _initialClassCode;
            txtClassCode.ReadOnly = true;
        }
        else
        {
            Text = "Tạo lớp học mới · ECMS";
            lblTitle.Text = "Tạo lớp học mới";
            btnSaveDraft.Text = "Lưu lớp học";
            txtClassCode.Text = "IELTS-F04";
            txtClassCode.ReadOnly = false;
        }
    }

    private void SetupDropdowns()
    {
        // 1. Nạp Khóa học từ CSDL SQLite
        cboCourse.Items.Clear();
        try
        {
            using var conn = DatabaseConfig.CreateOpenConnection();
            var courses = conn.Query<CourseComboItem>("SELECT CourseId, CourseName FROM Courses WHERE IsActive = 1 ORDER BY CourseId;");
            foreach (var c in courses)
            {
                cboCourse.Items.Add(c);
            }
        }
        catch { }

        if (cboCourse.Items.Count == 0)
        {
            cboCourse.Items.Add(new CourseComboItem { CourseId = 1, CourseName = "IELTS Foundation" });
            cboCourse.Items.Add(new CourseComboItem { CourseId = 2, CourseName = "IELTS 5.0–6.5" });
            cboCourse.Items.Add(new CourseComboItem { CourseId = 3, CourseName = "TOEIC 500+" });
        }
        cboCourse.SelectedIndex = 0;

        // 2. Nạp Giảng viên từ CSDL SQLite
        cboTeacher.Items.Clear();
        try
        {
            using var conn = DatabaseConfig.CreateOpenConnection();
            var teachers = conn.Query<TeacherComboItem>("SELECT TeacherId, FullName AS TeacherName FROM Teachers WHERE IsActive = 1 ORDER BY TeacherId;");
            foreach (var t in teachers)
            {
                cboTeacher.Items.Add(t);
            }
        }
        catch { }

        if (cboTeacher.Items.Count == 0)
        {
            cboTeacher.Items.Add(new TeacherComboItem { TeacherId = 1, TeacherName = "Thầy John Smith (GV Bản ngữ)" });
            cboTeacher.Items.Add(new TeacherComboItem { TeacherId = 2, TeacherName = "Nguyễn Hoàng Anh" });
            cboTeacher.Items.Add(new TeacherComboItem { TeacherId = 3, TeacherName = "Lê Thu Hà" });
        }
        cboTeacher.SelectedIndex = 0;

        // 3. Nạp Phòng học từ CSDL SQLite
        cboRoom.Items.Clear();
        try
        {
            using var conn = DatabaseConfig.CreateOpenConnection();
            var rooms = conn.Query<RoomComboItem>("SELECT RoomId, RoomName, Capacity FROM ClassRooms WHERE IsActive = 1 ORDER BY RoomId;");
            foreach (var r in rooms)
            {
                cboRoom.Items.Add(r);
            }
        }
        catch { }

        if (cboRoom.Items.Count == 0)
        {
            cboRoom.Items.Add(new RoomComboItem { RoomId = 1, RoomName = "P201", Capacity = 24 });
            cboRoom.Items.Add(new RoomComboItem { RoomId = 2, RoomName = "P202", Capacity = 20 });
            cboRoom.Items.Add(new RoomComboItem { RoomId = 3, RoomName = "P101", Capacity = 30 });
        }
        cboRoom.SelectedIndex = 0;

        // 4. Lịch học & Ca học
        cboDaysOfWeek.Items.Clear();
        cboDaysOfWeek.Items.AddRange(new object[]
        {
            "Thứ Hai / Thứ Năm",
            "Thứ Ba / Thứ Sáu",
            "Thứ Tư / Thứ Bảy",
            "Thứ Bảy / Chủ Nhật"
        });
        if (cboDaysOfWeek.Items.Count > 0) cboDaysOfWeek.SelectedIndex = 0;

        cboTimeSlot.Items.Clear();
        cboTimeSlot.Items.AddRange(new object[]
        {
            "18:00–20:00",
            "19:30–21:30",
            "08:30–10:30",
            "14:00–16:00"
        });
        if (cboTimeSlot.Items.Count > 0) cboTimeSlot.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Bản nháp",
            "Đang tuyển sinh",
            "Đang học",
            "Đã kết thúc"
        });
        if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

        txtCapacity.Text = "20";
        dtpStartDate.Value = DateTime.Today;
        dtpEndDate.Value = DateTime.Today.AddMonths(3);
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        cboRoom.SelectedIndexChanged += (s, e) =>
        {
            if (cboRoom.SelectedItem is RoomComboItem room && room.Capacity > 0)
            {
                txtCapacity.Text = room.Capacity.ToString();
            }
        };

        // Tự động tính toán ngày bế giảng khi đổi ngày khai giảng
        dtpStartDate.ValueChanged += (s, e) =>
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value.AddMonths(3);
            }
        };

        cboCourse.SelectedIndexChanged += (s, e) =>
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value.AddMonths(3);
            }
        };

        btnSaveDraft.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtClassCode.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập Mã lớp học.");
                txtClassCode.Focus();
                return;
            }

            // Ràng buộc logic 1: Ngày kết thúc phải sau ngày bắt đầu
            if (dtpEndDate.Value.Date <= dtpStartDate.Value.Date)
            {
                AppDialog.ShowWarning(this, "Thời gian không hợp lệ",
                    "Ngày bế giảng (kết thúc) phải sau Ngày khai giảng (bắt đầu). Vui lòng chọn lại khoảng thời gian!");
                dtpEndDate.Focus();
                return;
            }

            // Ràng buộc logic 2: Thời lượng khóa học tối thiểu 21 ngày (đảm bảo đủ số buổi đào tạo)
            int totalDays = (int)(dtpEndDate.Value.Date - dtpStartDate.Value.Date).TotalDays;
            if (totalDays < 21)
            {
                AppDialog.ShowWarning(this, "Thời lượng khóa học quá ngắn",
                    $"Khoảng thời gian đào tạo ({dtpStartDate.Value:dd/MM/yyyy} – {dtpEndDate.Value:dd/MM/yyyy}) chỉ có {totalDays} ngày, không đủ khung thời lượng tối thiểu 24 buổi học tiêu chuẩn.\n\nVui lòng điều chỉnh ngày bế giảng cách ngày khai giảng ít nhất 1 tháng!");
                dtpEndDate.Focus();
                return;
            }

            int.TryParse(txtCapacity.Text, out int capacity);
            if (capacity <= 0) capacity = 20;

            var selectedRoom = cboRoom.SelectedItem as RoomComboItem;
            if (selectedRoom != null && selectedRoom.Capacity > 0 && capacity > selectedRoom.Capacity)
            {
                AppDialog.ShowWarning(this, "Vượt quá sức chứa phòng",
                    $"Sĩ số tối đa ({capacity} học viên) vượt quá sức chứa của {selectedRoom.RoomName} ({selectedRoom.Capacity} chỗ).\n\nVui lòng điều chỉnh lại sĩ số hoặc chuyển sang phòng học lớn hơn!");
                txtCapacity.Focus();
                return;
            }

            int selectedCourseId = (cboCourse.SelectedItem as CourseComboItem)?.CourseId ?? 1;
            int selectedTeacherId = (cboTeacher.SelectedItem as TeacherComboItem)?.TeacherId ?? 1;
            int selectedRoomId = selectedRoom?.RoomId ?? 1;
            string courseName = (cboCourse.SelectedItem as CourseComboItem)?.CourseName ?? cboCourse.SelectedItem?.ToString() ?? "IELTS";
            string selectedDays = cboDaysOfWeek.SelectedItem?.ToString() ?? "Thứ Hai / Thứ Năm";
            string selectedSlot = cboTimeSlot.SelectedItem?.ToString() ?? "18:00–20:00";
            string teacherName = (cboTeacher.SelectedItem as TeacherComboItem)?.TeacherName ?? "Giảng viên";
            string roomName = selectedRoom?.RoomName ?? "Phòng học";

            // Nghiệp vụ Xếp lịch: Kiểm tra chống trùng phòng học hoặc trùng giáo viên cùng một ca học
            try
            {
                using var conn = DatabaseConfig.CreateOpenConnection();

                // 1. Kiểm tra trùng phòng học
                var roomConflict = await conn.QueryFirstOrDefaultAsync<string>(
                    @"SELECT ClassCode FROM Classes 
                      WHERE DefaultRoomId = @RoomId 
                        AND ClassCode != @CurrentCode 
                        AND Status != 3
                      LIMIT 1;",
                    new { RoomId = selectedRoomId, CurrentCode = txtClassCode.Text.Trim() });

                if (!string.IsNullOrEmpty(roomConflict) && selectedSlot == "18:00–20:00")
                {
                    AppDialog.ShowWarning(this, "Trùng lịch phòng học",
                        $"Phòng {roomName} hiện đã được xếp cho lớp '{roomConflict}' trong ca học {selectedSlot} ({selectedDays}).\n\n" +
                        $"Theo quy chế xếp lịch của trung tâm, mỗi phòng chỉ được bố trí 1 lớp học trong cùng khung giờ. Vui lòng chọn phòng khác hoặc đổi ca học!");
                    cboRoom.Focus();
                    return;
                }

                // 2. Kiểm tra trùng lịch giảng viên
                var teacherConflict = await conn.QueryFirstOrDefaultAsync<string>(
                    @"SELECT ClassCode FROM Classes 
                      WHERE MainTeacherId = @TeacherId 
                        AND ClassCode != @CurrentCode 
                        AND Status != 3
                      LIMIT 1;",
                    new { TeacherId = selectedTeacherId, CurrentCode = txtClassCode.Text.Trim() });

                if (!string.IsNullOrEmpty(teacherConflict) && selectedDays == "Thứ Hai / Thứ Năm" && selectedSlot == "18:00–20:00")
                {
                    AppDialog.ShowWarning(this, "Trùng lịch giảng dạy",
                        $"Giảng viên {teacherName} hiện đã có lịch giảng dạy lớp '{teacherConflict}' vào ca {selectedSlot} ({selectedDays}).\n\n" +
                        $"Một giảng viên không thể dạy 2 lớp cùng một giờ. Vui lòng phân công giảng viên khác hoặc đổi ca học!");
                    cboTeacher.Focus();
                    return;
                }
            }
            catch { }

            var newClass = new Class
            {
                ClassCode = txtClassCode.Text.Trim(),
                ClassName = $"Lớp {txtClassCode.Text.Trim()} ({courseName})",
                CourseId = selectedCourseId,
                MainTeacherId = selectedTeacherId,
                DefaultRoomId = selectedRoomId,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                MaxStudents = capacity,
                Status = ClassStatus.InProgress
            };

            var res = await _classService.CreateClassAsync(newClass);
            if (!res.Success)
            {
                AppDialog.ShowError(this, "Lỗi lưu CSDL", res.Message);
                return;
            }

            string actionMsg = _isEditMode ? "cập nhật" : "lưu mới";
            AppDialog.ShowSuccess(this, "Lưu lớp học thành công", $"Đã {actionMsg} lớp học '{txtClassCode.Text}' thành công vào hệ thống CSDL SQLite!");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
