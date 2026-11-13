using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ClassDetailDialog : Form
{
    private readonly string _classCode;
    private readonly string _courseName;

    public ClassDetailDialog(string classCode = "IELTS-F01", string courseName = "IELTS Foundation")
    {
        InitializeComponent();

        _classCode = classCode;
        _courseName = courseName;

        SetupHeaderAndInfo();
        SetupStudentsGrid();
        LoadSampleStudents();
        WireEvents();
    }

    private void SetupHeaderAndInfo()
    {
        Text = $"Chi tiết lớp học · {_classCode}";
        lblTitle.Text = $"{_classCode} · {_courseName}";
        lblSubtitle.Text = "06/10–25/12/2026 · T3 / T6 18:00–20:00 · P201 · Giáo viên Nguyễn Hoàng Anh";
        lblBreadcrumb.Text = $"ECMS / Lớp học / {_classCode} · {_courseName}";
    }

    private void SetupStudentsGrid()
    {
        dgvClassStudents.AutoGenerateColumns = false;
        dgvClassStudents.Columns.Clear();
        dgvClassStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.MultiSelect = false;
        dgvClassStudents.ReadOnly = true;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.AllowUserToAddRows = false;

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "StudentCode",
            HeaderText = "Mã ↑",
            Width = 110
        });

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Họ và tên",
            Width = 230
        });

        dgvClassStudents.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Attendance",
            HeaderText = "Chuyên cần",
            Width = 120
        });

        var actionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            DataPropertyName = "ActionText",
            UseColumnTextForButtonValue = false,
            Width = 120
        };
        dgvClassStudents.Columns.Add(actionCol);
    }

    private void LoadSampleStudents()
    {
        var students = new[]
        {
            new StudentClassRow { StudentCode = "HV-0241", FullName = "Nguyễn Minh Anh", Attendance = "87,5%", ActionText = "Mở hồ sơ" },
            new StudentClassRow { StudentCode = "HV-0237", FullName = "Lê Hoàng Nam", Attendance = "50,0%", ActionText = "Chuyển lớp" },
            new StudentClassRow { StudentCode = "HV-0238", FullName = "Phạm Khánh Linh", Attendance = "100%", ActionText = "Mở hồ sơ" },
            new StudentClassRow { StudentCode = "HV-0240", FullName = "Vũ Quang Huy", Attendance = "100%", ActionText = "Mở hồ sơ" },
        };

        dgvClassStudents.DataSource = students;
    }

    private void WireEvents()
    {
        btnAddStudent.Click += (s, e) =>
        {
            using var dlg = new AddStudentDialog();
            dlg.ShowDialog(this);
        };

        btnEditClass.Click += (s, e) =>
        {
            MessageBox.Show($"Mở biểu mẫu chỉnh sửa thông tin lớp học {_classCode}.", "Sửa lớp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnCancelTransfer.Click += (s, e) =>
        {
            txtTransferReason.Text = "";
        };

        btnConfirmTransfer.Click += (s, e) =>
        {
            using var dlg = new ClassTransferCompleteDialog();
            dlg.ShowDialog(this);
        };

        dgvClassStudents.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if (dgvClassStudents.Rows[e.RowIndex].DataBoundItem is StudentClassRow student)
                {
                    if (student.ActionText == "Chuyển lớp")
                    {
                        lblStudentTargetVal.Text = $"{student.FullName} · {student.StudentCode}";
                        txtTransferReason.Text = "Thay đổi lịch học cá nhân";
                        txtTransferReason.Focus();
                    }
                    else
                    {
                        using var detailDlg = new StudentDetailDialog(student.StudentCode, student.FullName);
                        detailDlg.ShowDialog(this);
                    }
                }
            }
        };

        btnTabStudents.Click += (s, e) => SwitchTab(btnTabStudents);
        btnTabSchedule.Click += (s, e) => SwitchTab(btnTabSchedule);
        btnTabAttendance.Click += (s, e) => SwitchTab(btnTabAttendance);
        btnTabGrades.Click += (s, e) => SwitchTab(btnTabGrades);
        btnTabHistory.Click += (s, e) => SwitchTab(btnTabHistory);
    }

    private void SwitchTab(Button activeBtn)
    {
        var tabs = new[] { btnTabStudents, btnTabSchedule, btnTabAttendance, btnTabGrades, btnTabHistory };
        foreach (var tab in tabs)
        {
            if (tab == activeBtn)
            {
                tab.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                tab.ForeColor = Color.FromArgb(24, 119, 242);
                if (!tab.Text.StartsWith("▬ "))
                {
                    tab.Text = "▬ " + tab.Text;
                }
            }
            else
            {
                tab.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                tab.ForeColor = Color.FromArgb(108, 117, 125);
                if (tab.Text.StartsWith("▬ "))
                {
                    tab.Text = tab.Text.Substring(2);
                }
            }
        }
    }

    private class StudentClassRow
    {
        public string StudentCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Attendance { get; set; } = string.Empty;
        public string ActionText { get; set; } = string.Empty;
    }
}
