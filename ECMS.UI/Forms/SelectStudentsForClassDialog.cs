using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class SelectStudentsForClassDialog : Form
{
    private readonly string _classCode = string.Empty;
    private readonly List<string[]> _allStudents = new();

    public List<string> SelectedStudentCodes { get; } = new();

    public SelectStudentsForClassDialog() : this("IELTS-F01")
    {
    }

    public SelectStudentsForClassDialog(string classCode)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _classCode = classCode;

        LoadData();
        WireEvents();
    }

    private void LoadData()
    {
        _allStudents.Clear();
        _allStudents.Add(new[] { "HV-0245", "Lê Thanh Hằng", "0901234567", "thanhhang@gmail.com", "Chờ xếp lớp" });
        _allStudents.Add(new[] { "HV-0246", "Phạm Quốc Bảo", "0912345678", "quocbao.p@gmail.com", "Chờ xếp lớp" });
        _allStudents.Add(new[] { "HV-0247", "Đỗ Quỳnh Chi", "0934567890", "quynhchi.do@gmail.com", "Chờ xếp lớp" });
        _allStudents.Add(new[] { "HV-0248", "Vũ Hoàng Nam", "0987654321", "nam.vh@gmail.com", "Chờ xếp lớp" });
        _allStudents.Add(new[] { "HV-0249", "Bùi Thị Mai", "0945678901", "maibui@gmail.com", "Đang học (Lớp khác)" });
        _allStudents.Add(new[] { "HV-0250", "Nguyễn Tuấn Kiệt", "0976543210", "tuankiet.ng@gmail.com", "Chờ xếp lớp" });

        RenderRows(_allStudents);
    }

    private void RenderRows(List<string[]> students)
    {
        dgvStudents.Rows.Clear();
        foreach (var s in students)
        {
            dgvStudents.Rows.Add(false, s[0], s[1], s[2], s[3], s[4]);
        }
        UpdateSelectionCount();
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) =>
        {
            string q = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(q))
            {
                RenderRows(_allStudents);
            }
            else
            {
                var filtered = _allStudents.FindAll(x =>
                    x[0].ToLower().Contains(q) ||
                    x[1].ToLower().Contains(q) ||
                    x[2].ToLower().Contains(q));
                RenderRows(filtered);
            }
        };

        dgvStudents.CellValueChanged += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colSelect.Index)
            {
                UpdateSelectionCount();
            }
        };

        dgvStudents.CurrentCellDirtyStateChanged += (s, e) =>
        {
            if (dgvStudents.IsCurrentCellDirty && dgvStudents.CurrentCell?.ColumnIndex == colSelect.Index)
            {
                dgvStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        };

        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnConfirm.Click += (s, e) =>
        {
            SelectedStudentCodes.Clear();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[colSelect.Index].Value ?? false);
                if (isChecked)
                {
                    string code = row.Cells[colCode.Index].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(code))
                    {
                        SelectedStudentCodes.Add(code);
                    }
                }
            }

            if (SelectedStudentCodes.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất 1 học viên để thêm vào lớp.", "Chưa chọn học viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        };
    }

    private void UpdateSelectionCount()
    {
        int count = 0;
        foreach (DataGridViewRow row in dgvStudents.Rows)
        {
            if (Convert.ToBoolean(row.Cells[colSelect.Index].Value ?? false))
            {
                count++;
            }
        }
        btnConfirm.Text = $"Xác nhận thêm ({count})";
        btnConfirm.Enabled = count > 0;
    }
}
