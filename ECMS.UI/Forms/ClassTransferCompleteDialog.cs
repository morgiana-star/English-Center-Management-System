using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class ClassTransferCompleteDialog : Form
{
    public ClassTransferCompleteDialog()
    {
        InitializeComponent();

        SetupChecklistGrid();
        LoadSampleChecklist();
        WireEvents();
    }

    private void SetupChecklistGrid()
    {
        dgvChecklist.AutoGenerateColumns = false;
        dgvChecklist.Columns.Clear();
        dgvChecklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvChecklist.MultiSelect = false;
        dgvChecklist.ReadOnly = true;
        dgvChecklist.RowHeadersVisible = false;
        dgvChecklist.AllowUserToAddRows = false;

        dgvChecklist.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Condition",
            HeaderText = "Điều kiện ↑",
            Width = 140
        });

        dgvChecklist.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Result",
            HeaderText = "Kết quả",
            Width = 370
        });
    }

    private void LoadSampleChecklist()
    {
        var items = new[]
        {
            new ChecklistItem { Condition = "Chương trình", Result = "✓  IELTS Foundation đang sử dụng" },
            new ChecklistItem { Condition = "Giáo viên", Result = "✓  Nguyễn Hoàng Anh đã nhận phân công" },
            new ChecklistItem { Condition = "Lịch / phòng", Result = "✓  T2 / T5 · 18:00–20:00 · P201" },
            new ChecklistItem { Condition = "Sức chứa", Result = "✓  1/20 học viên ≤ 24 chỗ phòng" },
            new ChecklistItem { Condition = "Xung đột", Result = "✓  Không trùng giáo viên, phòng, học viên" },
        };

        dgvChecklist.DataSource = items;
    }

    private void WireEvents()
    {
        btnOpenClassF04.Click += (s, e) =>
        {
            MessageBox.Show("Lớp học IELTS-F04 đã chuyển sang trạng thái Đang học thành công!", "Mở lớp hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        };

        btnViewStudentHistory.Click += (s, e) =>
        {
            using var dlg = new StudentDetailDialog("HV-0237", "Lê Hoàng Nam");
            dlg.ShowDialog(this);
        };
    }

    private class ChecklistItem
    {
        public string Condition { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }
}
