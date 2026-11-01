using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

/// <summary>
/// Sổ điểm danh buổi học — skeleton để viết tiếp.
/// Gọi: new AttendanceSheetView(scheduleId, className)
/// TODO: LoadStudentsAsync(), SaveAttendanceAsync()
/// </summary>
public partial class AttendanceSheetView : UserControl
{
    private readonly int _scheduleId;
    private DataGridView dgv = null!;

    public AttendanceSheetView(int scheduleId, string className)
    {
        _scheduleId = scheduleId;
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        // ── Tiêu đề ──────────────────────────────────────────
        Controls.Add(new Label
        {
            Text = $"SỔ ĐIỂM DANH — {className}  (ScheduleId: {scheduleId})",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(20, 16), AutoSize = true
        });

        // ── Bảng học viên ────────────────────────────────────
        dgv = new DataGridView { Location = new Point(20, 55), Size = new Size(900, 400) };
        ModernGridHelper.ApplyStyle(dgv);
        dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentId",    HeaderText = "ID",       Width = 50,  ReadOnly = true });
        dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentCode",  HeaderText = "Mã HV",    Width = 100, ReadOnly = true });
        dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName",     HeaderText = "Họ và tên",Width = 220, ReadOnly = true });
        dgv.Columns.Add(new DataGridViewComboBoxColumn { Name = "Status", HeaderText = "Trạng thái", Width = 130,
            DataSource = new[] { "Có mặt", "Vắng", "Vắng có phép", "Muộn" } });
        dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Note", HeaderText = "Ghi chú", Width = 260 });
        Controls.Add(dgv);

        // ── Nút Lưu ──────────────────────────────────────────
        var btnSave = new CustomButton
        {
            Text = "LƯU ĐIỂM DANH", Location = new Point(20, 470), Size = new Size(160, 36),
            NormalColor = Color.FromArgb(67, 56, 202), HoverColor = Color.FromArgb(79, 70, 229), CornerRadius = 6
        };
        // TODO: btnSave.Click += async (s,e) => await SaveAttendanceAsync();
        btnSave.Click += (s, e) => MessageBox.Show("TODO: gọi AttendanceService.SaveAsync()", "Stub");
        Controls.Add(btnSave);

        // TODO: gọi LoadStudentsAsync() khi Load
        // Load += async (s, e) => await LoadStudentsAsync();
    }

    // TODO: điền học viên từ DB vào dgv
    // private async Task LoadStudentsAsync() { ... }

    // TODO: đọc từng dòng dgv → tạo AttendanceRecord → upsert DB
    // private async Task SaveAttendanceAsync() { ... }
}
