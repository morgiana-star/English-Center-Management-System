using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class SelectStudentsForClassDialog : Form
{
    private readonly IClassService _classService = new ClassService();
    private readonly int _classId;
    private readonly string _classCode = string.Empty;
    private List<WaitingStudentItemDto> _allStudents = new();

    public List<int> SelectedStudentIds { get; } = new();
    public List<string> SelectedStudentCodes { get; } = new();

    public SelectStudentsForClassDialog() : this(0, "IELTS-F01")
    {
    }

    public SelectStudentsForClassDialog(string classCode) : this(0, classCode)
    {
    }

    public SelectStudentsForClassDialog(int classId, string classCode)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _classId = classId;
        _classCode = classCode;
        Text = $"Thêm học viên chờ xếp lớp vào lớp {_classCode} - ECMS";

        dgvStudents.ReadOnly = false;
        dgvStudents.ScrollBars = ScrollBars.Both;
        colSelect.ReadOnly = false;

        WireEvents();
        _ = LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            _allStudents = (await _classService.GetWaitingStudentsForClassAsync(_classId)).ToList();
            RenderRows(_allStudents);
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách học viên chờ xếp lớp", ex.Message);
        }
    }

    private void RenderRows(List<WaitingStudentItemDto> students)
    {
        dgvStudents.Rows.Clear();
        foreach (var s in students)
        {
            int idx = dgvStudents.Rows.Add(false, s.StudentCode, s.FullName, s.Phone, s.Email, s.StatusDisplay);
            dgvStudents.Rows[idx].Tag = s;
        }
        UpdateSelectionCount();
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) =>
        {
            string q = txtSearch.Text.Trim().ToLowerInvariant();
            if (string.IsNullOrEmpty(q))
            {
                RenderRows(_allStudents);
            }
            else
            {
                var filtered = _allStudents.Where(x =>
                    x.StudentCode.ToLowerInvariant().Contains(q) ||
                    x.FullName.ToLowerInvariant().Contains(q) ||
                    x.Phone.ToLowerInvariant().Contains(q)).ToList();
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
            SelectedStudentIds.Clear();
            SelectedStudentCodes.Clear();
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[colSelect.Index].Value ?? false);
                if (isChecked && row.Tag is WaitingStudentItemDto st)
                {
                    SelectedStudentIds.Add(st.StudentId);
                    SelectedStudentCodes.Add(st.StudentCode);
                }
            }

            if (SelectedStudentIds.Count == 0)
            {
                AppDialog.ShowWarning(this, "Chưa chọn học viên", "Vui lòng tích chọn ít nhất 1 học viên chờ xếp lớp để thêm vào lớp.");
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
                count++;
        }

        btnConfirm.Text = count > 0 ? $"Xác nhận thêm ({count})" : "Xác nhận thêm";
    }
}
