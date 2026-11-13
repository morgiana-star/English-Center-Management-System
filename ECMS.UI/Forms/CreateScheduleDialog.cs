using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateScheduleDialog : Form
{
    public CreateScheduleDialog()
    {
        InitializeComponent();

        SetupDropdowns();
        SetupConflictGrid();
        LoadSampleConflicts();
        WireEvents();
    }

    private void SetupDropdowns()
    {
        cboClass.Items.Clear();
        cboClass.Items.AddRange(new object[] { "IELTS-F04", "COM-B01", "TOEIC-T02" });
        cboClass.SelectedIndex = 0;

        cboRoom.Items.Clear();
        cboRoom.Items.AddRange(new object[] { "P203 · 18 chỗ", "P201 · 24 chỗ", "P202 · 24 chỗ" });
        cboRoom.SelectedIndex = 0;

        dtpStartDate.Value = new DateTime(2026, 11, 6);
        txtStartTime.Text = "18:00";
    }

    private void SetupConflictGrid()
    {
        dgvConflicts.AutoGenerateColumns = false;
        dgvConflicts.Columns.Clear();
        dgvConflicts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvConflicts.MultiSelect = false;
        dgvConflicts.ReadOnly = true;
        dgvConflicts.RowHeadersVisible = false;
        dgvConflicts.AllowUserToAddRows = false;

        dgvConflicts.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ErrorType",
            HeaderText = "Loại lỗi ↑",
            Width = 110
        });

        dgvConflicts.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ConflictCause",
            HeaderText = "Trùng với / nguyên nhân",
            Width = 240
        });

        dgvConflicts.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Solution",
            HeaderText = "Cách giải quyết",
            Width = 200
        });
    }

    private void LoadSampleConflicts()
    {
        var conflicts = new[]
        {
            new ConflictRow { ErrorType = "Giáo viên", ConflictCause = "IELTS-F01 · 06/11 · 18–20h", Solution = "Đổi sang T2 / T5" },
            new ConflictRow { ErrorType = "Phòng", ConflictCause = "COM-A02 · P203 · 18–20h", Solution = "Đổi phòng P201" },
            new ConflictRow { ErrorType = "Học viên", ConflictCause = "Lê Hoàng Nam - IELTS-F01", Solution = "Chuyển ngày / chuyển lớp" },
            new ConflictRow { ErrorType = "Sức chứa", ConflictCause = "Lớp 20 HV > P203 18 chỗ", Solution = "Chọn phòng ≥ 20 chỗ" }
        };

        dgvConflicts.DataSource = conflicts;
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        btnCancelForm.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

        btnSelectRoom201.Click += (s, e) =>
        {
            cboRoom.SelectedIndex = 1; // P201 · 24 chỗ
            MessageBox.Show("Đã chuyển phòng sang P201 (24 chỗ). Lỗi sức chứa và trùng phòng P203 đã được giải tỏa!", "Điều chỉnh nhanh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnChangeSchedule.Click += (s, e) =>
        {
            dtpStartDate.Value = new DateTime(2026, 11, 2);
            MessageBox.Show("Đã đổi sang lịch T2 / T5. Lỗi trùng lịch giáo viên và học viên đã được giải tỏa!", "Điều chỉnh nhanh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        btnRecheck.Click += (s, e) =>
        {
            using var savedDlg = new ScheduleSavedDialog();
            savedDlg.ShowDialog(this);
            DialogResult = DialogResult.OK;
            Close();
        };

        btnSaveSchedule.Click += (s, e) =>
        {
            using var savedDlg = new ScheduleSavedDialog();
            savedDlg.ShowDialog(this);
            DialogResult = DialogResult.OK;
            Close();
        };

        btnCheckAndSave.Click += (s, e) =>
        {
            using var savedDlg = new ScheduleSavedDialog();
            savedDlg.ShowDialog(this);
            DialogResult = DialogResult.OK;
            Close();
        };
    }

    private class ConflictRow
    {
        public string ErrorType { get; set; } = string.Empty;
        public string ConflictCause { get; set; } = string.Empty;
        public string Solution { get; set; } = string.Empty;
    }
}
