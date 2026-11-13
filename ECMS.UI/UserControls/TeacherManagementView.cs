using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherManagementView : UserControl
{
    public TeacherManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrids();
        LoadSampleTeachers();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Đang giảng dạy",
            "Tạm nghỉ",
            "Tất cả trạng thái"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboSpecialtyFilter.Items.Clear();
        cboSpecialtyFilter.Items.AddRange(new object[]
        {
            "Tất cả chuyên môn",
            "IELTS 8.0+",
            "IELTS 7.0–7.5",
            "TOEIC 900+",
            "Giao tiếp"
        });
        cboSpecialtyFilter.SelectedIndex = 0;

        cboAssignClass.Items.Clear();
        cboAssignClass.Items.AddRange(new object[]
        {
            "IELTS-F04",
            "COM-B01",
            "TOEIC-T03"
        });
        cboAssignClass.SelectedIndex = 0;
        dtpEffectiveDate.Value = new DateTime(2026, 11, 2);
    }

    private void SetupGrids()
    {
        // Teachers Grid
        dgvTeachers.AutoGenerateColumns = false;
        dgvTeachers.Columns.Clear();
        dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.MultiSelect = false;
        dgvTeachers.ReadOnly = true;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.AllowUserToAddRows = false;

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TeacherCode",
            HeaderText = "Mã ↑",
            Width = 90
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Họ và tên",
            Width = 190
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Specialty",
            HeaderText = "Chuyên môn",
            Width = 140
        });

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ClassHours",
            HeaderText = "Lớp / tuần",
            Width = 180
        });

        // Schedule Grid
        dgvSchedule.AutoGenerateColumns = false;
        dgvSchedule.Columns.Clear();
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSchedule.MultiSelect = false;
        dgvSchedule.ReadOnly = true;
        dgvSchedule.RowHeadersVisible = false;
        dgvSchedule.AllowUserToAddRows = false;

        dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Days",
            HeaderText = "Ngày ↑",
            Width = 90
        });

        dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "TimeSlotStatus",
            HeaderText = "18:00–20:00",
            Width = 120
        });

        dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Note",
            HeaderText = "Ghi chú",
            Width = 140
        });
    }

    private void LoadSampleTeachers()
    {
        var teachers = new[]
        {
            new TeacherItem { TeacherCode = "GV-001", FullName = "Nguyễn Hoàng Anh", Specialty = "IELTS 8.0", ClassHours = "IELTS-F01 · 4 giờ", Phone = "0907 321 654", Cert = "IELTS 8.0 · 2025", Status = "Đang giảng dạy", CurrentClass = "IELTS-F01 · 18 học viên" },
            new TeacherItem { TeacherCode = "GV-002", FullName = "Trần Minh Tuấn", Specialty = "TOEIC 950", ClassHours = "TOEIC-T01 · 4 giờ", Phone = "0918 234 567", Cert = "TOEIC 990 · 2024", Status = "Đang giảng dạy", CurrentClass = "TOEIC-T01 · 22 học viên" },
            new TeacherItem { TeacherCode = "GV-003", FullName = "Lê Thu Hà", Specialty = "IELTS 7.5", ClassHours = "IELTS-F03 · 4 giờ", Phone = "0933 456 789", Cert = "IELTS 7.5 · 2025", Status = "Đang giảng dạy", CurrentClass = "IELTS-F03 · 20 học viên" },
            new TeacherItem { TeacherCode = "GV-004", FullName = "Đặng Thu Trang", Specialty = "Giao tiếp", ClassHours = "COM-A02 · 4 giờ", Phone = "0987 654 321", Cert = "TESOL Master", Status = "Đang giảng dạy", CurrentClass = "COM-A02 · 15 học viên" },
            new TeacherItem { TeacherCode = "GV-005", FullName = "Nguyễn Quang Vinh", Specialty = "TOEIC 900", ClassHours = "TOEIC-T02 · 4 giờ", Phone = "0909 112 233", Cert = "TOEIC 950 · 2025", Status = "Đang giảng dạy", CurrentClass = "TOEIC-T02 · 18 học viên" },
        };

        dgvTeachers.DataSource = teachers;
        DisplayTeacherDetails(teachers[0]);
    }

    private void DisplayTeacherDetails(TeacherItem teacher)
    {
        lblTeacherDetailTitle.Text = $"{teacher.FullName} · {teacher.TeacherCode}";
        lblPhoneVal.Text = teacher.Phone;
        lblCertVal.Text = teacher.Cert;
        lblStatusVal.Text = teacher.Status;
        lblCurrentClassVal.Text = teacher.CurrentClass;

        var schedule = new[]
        {
            new ScheduleRow { Days = "T2 / T5", TimeSlotStatus = "✓ Khả dụng", Note = "Có thể phân F04" },
            new ScheduleRow { Days = "T3 / T6", TimeSlotStatus = "Đã có lớp", Note = teacher.CurrentClass.Split('·')[0].Trim() },
            new ScheduleRow { Days = "T4 / T7", TimeSlotStatus = "✓ Khả dụng", Note = "Theo đăng ký" }
        };

        dgvSchedule.DataSource = schedule;
    }

    private void WireEvents()
    {
        btnAddTeacher.Click += (s, e) =>
        {
            using var dlg = new AddTeacherDialog();
            dlg.ShowDialog(FindForm());
        };

        dgvTeachers.SelectionChanged += (s, e) =>
        {
            if (dgvTeachers.CurrentRow?.DataBoundItem is TeacherItem teacher)
            {
                DisplayTeacherDetails(teacher);
            }
        };

        btnSaveAssign.Click += (s, e) =>
        {
            MessageBox.Show($"Đã phân công lớp {cboAssignClass.Text} cho giáo viên {lblTeacherDetailTitle.Text} từ ngày {dtpEffectiveDate.Value:dd/MM/yyyy}.", "Phân công thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnCancelAssign.Click += (s, e) =>
        {
            cboAssignClass.SelectedIndex = 0;
        };

        lblTabProfile.Click += (s, e) => SwitchDetailTab(lblTabProfile);
        lblTabAvailability.Click += (s, e) => SwitchDetailTab(lblTabAvailability);
        lblTabAssign.Click += (s, e) => SwitchDetailTab(lblTabAssign);
    }

    private void SwitchDetailTab(Label activeTab)
    {
        var tabs = new[] { lblTabProfile, lblTabAvailability, lblTabAssign };
        foreach (var tab in tabs)
        {
            if (tab == activeTab)
            {
                tab.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                tab.ForeColor = Color.FromArgb(24, 119, 242);
                if (!tab.Text.StartsWith("▬ "))
                {
                    tab.Text = "▬ " + tab.Text;
                }
            }
            else
            {
                tab.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                tab.ForeColor = Color.FromArgb(108, 117, 125);
                if (tab.Text.StartsWith("▬ "))
                {
                    tab.Text = tab.Text.Substring(2);
                }
            }
        }
    }

    private class TeacherItem
    {
        public string TeacherCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string ClassHours { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Cert { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string CurrentClass { get; set; } = string.Empty;
    }

    private class ScheduleRow
    {
        public string Days { get; set; } = string.Empty;
        public string TimeSlotStatus { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
    }
}
