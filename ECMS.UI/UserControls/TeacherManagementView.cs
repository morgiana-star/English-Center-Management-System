using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherManagementView : UserControl
{
    private readonly ITeacherService _teacherService = new TeacherService();
    private List<TeacherListItemDto> _allTeachers = new();
    private Panel _pnlFooter = null!;
    private Label _lblBottomSummary = null!;

    public TeacherManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFooterSummary();
        SetupFilters();
        SetupGrids();
        WireEvents();
        _ = LoadTeachersAsync();
    }

    private void SetupFooterSummary()
    {
        btnAddTeacher.Text = "Thêm giáo viên";

        _pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 36,
            BackColor = Color.FromArgb(248, 250, 252),
            Padding = new Padding(12, 6, 12, 6)
        };
        _lblBottomSummary = new Label
        {
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(51, 65, 85),
            TextAlign = ContentAlignment.MiddleRight,
            Text = "Đang hiển thị: 0  |  Tổng giáo viên: 0  |  Đang giảng dạy: 0  |  Tạm nghỉ: 0"
        };
        _pnlFooter.Controls.Add(_lblBottomSummary);

        dgvTeachers.Height = Math.Max(300, cardTeacherList.Height - dgvTeachers.Top - _pnlFooter.Height - 16);
        cardTeacherList.Controls.Add(_pnlFooter);
        _pnlFooter.BringToFront();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Đang giảng dạy",
            "Tạm nghỉ"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboSpecialtyFilter.Items.Clear();
        cboSpecialtyFilter.Items.Add("Tất cả chuyên môn");
        cboSpecialtyFilter.Items.AddRange(StatusFormatter.TeacherSpecialties);
        cboSpecialtyFilter.SelectedIndex = 0;
    }

    private void SetupGrids()
    {
        AppGridHelper.ApplyStyle(dgvTeachers);
        dgvTeachers.AutoGenerateColumns = false;
        dgvTeachers.Columns.Clear();
        dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.MultiSelect = false;
        dgvTeachers.ReadOnly = true;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.AllowUserToAddRows = false;

        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã GV", FillWeight = 9 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColName", HeaderText = "Họ và tên", FillWeight = 19 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColPhone", HeaderText = "Số điện thoại", FillWeight = 12 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColEmail", HeaderText = "Email", FillWeight = 18 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSpec", HeaderText = "Chuyên môn", FillWeight = 14 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClasses", HeaderText = "Lớp phụ trách", FillWeight = 9 });
        dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Trạng thái", FillWeight = 11 });

        var colEdit = new DataGridViewButtonColumn
        {
            Name = "ColEdit",
            HeaderText = "Sửa",
            Text = "Sửa",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 7
        };
        colEdit.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        dgvTeachers.Columns.Add(colEdit);

        var colDelete = new DataGridViewButtonColumn
        {
            Name = "ColDelete",
            HeaderText = "Xóa",
            Text = "Xóa",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 7
        };
        colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
        dgvTeachers.Columns.Add(colDelete);
    }

    private async Task LoadTeachersAsync()
    {
        try
        {
            _allTeachers = (await _teacherService.GetAllTeachersAsync()).ToList();
            FilterTeachers();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách giáo viên", ex.Message);
        }
    }

    private void WireEvents()
    {
        btnAddTeacher.Click += async (s, e) =>
        {
            using var dlg = new AddTeacherDialog();
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadTeachersAsync();
            }
        };

        dgvTeachers.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (dgvTeachers.Rows[e.RowIndex].Tag is not TeacherListItemDto teacher) return;

            string colName = dgvTeachers.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                using var dlg = new AddTeacherDialog(teacher);
                if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    await LoadTeachersAsync();
                }
            }
            else if (colName == "ColDelete")
            {
                if (AppDialog.ShowConfirm(ParentForm, "Xác nhận xóa giáo viên",
                    $"Bạn có chắc chắn muốn xóa giáo viên '{teacher.FullName}' ({teacher.TeacherCode}) không?",
                    "Xóa", "Hủy") != DialogResult.OK)
                    return;

                var res = await _teacherService.DeleteTeacherAsync(teacher.TeacherId);
                if (res.Success)
                {
                    AppDialog.ShowSuccess(ParentForm, "Thành công", res.Message);
                    await LoadTeachersAsync();
                }
                else
                {
                    AppDialog.ShowWarning(ParentForm, "Không thể xóa giáo viên", res.Message);
                }
            }
        };

        dgvTeachers.CellDoubleClick += async (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (dgvTeachers.Rows[e.RowIndex].Tag is not TeacherListItemDto teacher) return;

            using var dlg = new AddTeacherDialog(teacher);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
            {
                await LoadTeachersAsync();
            }
        };

        txtSearchTeacher.TextChanged += (s, e) => FilterTeachers();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterTeachers();
        cboSpecialtyFilter.SelectedIndexChanged += (s, e) => FilterTeachers();
    }

    private void FilterTeachers()
    {
        string kw = txtSearchTeacher.Text.Trim().ToLowerInvariant();
        string status = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";
        string spec = cboSpecialtyFilter.SelectedItem?.ToString() ?? "Tất cả chuyên môn";

        var filtered = _allTeachers.Where(t =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           t.TeacherCode.ToLowerInvariant().Contains(kw) ||
                           t.FullName.ToLowerInvariant().Contains(kw) ||
                           t.Phone.ToLowerInvariant().Contains(kw) ||
                           t.Email.ToLowerInvariant().Contains(kw);

            bool matchStatus = status == "Tất cả trạng thái" || t.StatusDisplay == status;
            bool matchSpec = spec == "Tất cả chuyên môn" ||
                             t.Specialization.Contains(spec, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchStatus && matchSpec;
        }).ToList();

        dgvTeachers.Rows.Clear();
        foreach (var t in filtered)
        {
            int idx = dgvTeachers.Rows.Add(
                t.TeacherCode,
                t.FullName,
                t.Phone,
                t.Email,
                t.Specialization,
                $"{t.ActiveClassCount} lớp",
                t.StatusDisplay);
            dgvTeachers.Rows[idx].Tag = t;
        }

        dgvTeachers.ClearSelection();
        dgvTeachers.CurrentCell = null;

        int activeCnt = _allTeachers.Count(x => x.IsActive);
        int inactiveCnt = _allTeachers.Count - activeCnt;
        _lblBottomSummary.Text =
            $"Đang hiển thị: {filtered.Count}  |  Tổng giáo viên: {_allTeachers.Count}  |  Đang giảng dạy: {activeCnt}  |  Tạm nghỉ: {inactiveCnt}";
    }
}
