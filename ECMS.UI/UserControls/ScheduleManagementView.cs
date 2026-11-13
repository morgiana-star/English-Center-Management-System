using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ScheduleManagementView : UserControl
{
    public ScheduleManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupMatrixGrid();
        LoadSampleSchedule();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboTeacherFilter.Items.Clear();
        cboTeacherFilter.Items.AddRange(new object[] { "Tất cả giáo viên", "Nguyễn Hoàng Anh", "Trần Minh Tuấn", "Lê Thu Hà" });
        cboTeacherFilter.SelectedIndex = 0;

        cboRoomFilter.Items.Clear();
        cboRoomFilter.Items.AddRange(new object[] { "Tất cả phòng", "P201 · 24 chỗ", "P202 · 24 chỗ", "P203 · 18 chỗ" });
        cboRoomFilter.SelectedIndex = 0;

        cboProgramFilter.Items.Clear();
        cboProgramFilter.Items.AddRange(new object[] { "IELTS / TOEIC", "IELTS Foundation", "TOEIC 500+", "Giao tiếp cơ bản" });
        cboProgramFilter.SelectedIndex = 0;
    }

    private void SetupMatrixGrid()
    {
        dgvScheduleMatrix.AutoGenerateColumns = false;
        dgvScheduleMatrix.Columns.Clear();
        dgvScheduleMatrix.ReadOnly = true;
        dgvScheduleMatrix.RowHeadersVisible = false;
        dgvScheduleMatrix.AllowUserToAddRows = false;
        dgvScheduleMatrix.RowTemplate.Height = 90;

        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTime", HeaderText = "Giờ", Width = 80 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColMon", HeaderText = "T2 · 26/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTue", HeaderText = "T3 · 27/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColWed", HeaderText = "T4 · 28/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColThu", HeaderText = "T5 · 29/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColFri", HeaderText = "T6 · 30/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSat", HeaderText = "T7 · 31/10", Width = 140 });
        dgvScheduleMatrix.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSun", HeaderText = "CN · 01/11", Width = 140 });

        dgvScheduleMatrix.CellFormatting += (s, e) =>
        {
            if (e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val.Contains("IELTS-F01"))
                {
                    e.CellStyle.BackColor = Color.FromArgb(235, 245, 255);
                    e.CellStyle.ForeColor = Color.FromArgb(24, 119, 242);
                    e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (val.Contains("TOEIC-T01"))
                {
                    e.CellStyle.BackColor = Color.FromArgb(235, 250, 240);
                    e.CellStyle.ForeColor = Color.FromArgb(40, 167, 69);
                    e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (val.Contains("Họp giáo viên"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(24, 119, 242);
                    e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(170, 180, 190);
                }
            }
        };
    }

    private void LoadSampleSchedule()
    {
        dgvScheduleMatrix.Rows.Clear();

        dgvScheduleMatrix.Rows.Add("08:00", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch");
        dgvScheduleMatrix.Rows.Add("14:00", "Còn trống", "Còn trống", "Họp giáo viên", "Còn trống", "Còn trống", "Còn trống", "Còn trống");
        dgvScheduleMatrix.Rows.Add("18:00", "Còn trống", "IELTS-F01 (P201)\nTOEIC-T01 (P202)", "Còn trống", "Còn trống", "IELTS-F01 (P201)\nTOEIC-T01 (P202)", "Còn trống", "Còn trống");
        dgvScheduleMatrix.Rows.Add("20:00", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch", "Không có lịch");
    }

    private void WireEvents()
    {
        btnManageRooms.Click += (s, e) =>
        {
            using var dlg = new RoomManagementDialog();
            dlg.ShowDialog(FindForm());
        };

        btnCreateSession.Click += (s, e) =>
        {
            using var dlg = new CreateScheduleDialog();
            dlg.ShowDialog(FindForm());
        };

        dgvScheduleMatrix.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                var val = dgvScheduleMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                if (val.Contains("IELTS") || val.Contains("TOEIC"))
                {
                    using var dlg = new ScheduleSavedDialog();
                    dlg.ShowDialog(FindForm());
                }
            }
        };

        lblViewDay.Click += (s, e) => SwitchCalendarView(lblViewDay);
        lblViewWeek.Click += (s, e) => SwitchCalendarView(lblViewWeek);
        lblViewMonth.Click += (s, e) => SwitchCalendarView(lblViewMonth);
    }

    private void SwitchCalendarView(Label activeLabel)
    {
        var views = new[] { lblViewDay, lblViewWeek, lblViewMonth };
        foreach (var view in views)
        {
            if (view == activeLabel)
            {
                view.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                view.ForeColor = Color.FromArgb(24, 119, 242);
                if (!view.Text.StartsWith("▬ "))
                {
                    view.Text = "▬ " + view.Text;
                }
            }
            else
            {
                view.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                view.ForeColor = Color.FromArgb(108, 117, 125);
                if (view.Text.StartsWith("▬ "))
                {
                    view.Text = view.Text.Substring(2);
                }
            }
        }
    }
}
