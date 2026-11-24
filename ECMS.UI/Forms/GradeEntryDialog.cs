using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class GradeEntryDialog : Form
{
    private readonly IExamService _examService = new ExamService();
    private readonly IClassService _classService = new ClassService();
    private List<ClassListItemDto> _classes = new();
    private string _currentClass = "";
    private int _currentClassId = 0;
    private bool _isCalculating = false;

    public GradeEntryDialog() : this("")
    {
    }

    public GradeEntryDialog(string defaultClass = "")
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _currentClass = defaultClass ?? "";
        SetupGrid();
        WireEvents();
        _ = LoadClassesAndGradesAsync();
    }

    private async Task LoadClassesAndGradesAsync()
    {
        try
        {
            _classes = (await _classService.GetClassesAsync()).ToList();
            cboClass.Items.Clear();
            foreach (var c in _classes)
            {
                cboClass.Items.Add(c.ClassCode);
            }

            if (_classes.Count > 0)
            {
                int idx = !string.IsNullOrWhiteSpace(_currentClass)
                    ? _classes.FindIndex(c => c.ClassCode.Equals(_currentClass, StringComparison.OrdinalIgnoreCase))
                    : 0;
                cboClass.SelectedIndex = idx >= 0 ? idx : 0;
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi nạp danh sách lớp học", ex.Message);
        }
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvStudentGrades);
        dgvStudentGrades.AutoGenerateColumns = false;
        dgvStudentGrades.Columns.Clear();
        dgvStudentGrades.SelectionMode = DataGridViewSelectionMode.CellSelect;
        dgvStudentGrades.MultiSelect = false;
        dgvStudentGrades.ReadOnly = false;
        dgvStudentGrades.RowHeadersVisible = false;
        dgvStudentGrades.AllowUserToAddRows = false;
        dgvStudentGrades.ScrollBars = ScrollBars.Both;
        dgvStudentGrades.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        dgvStudentGrades.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dgvStudentGrades.GridColor = Color.FromArgb(203, 213, 225);

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", MinimumWidth = 45, FillWeight = 6F, ReadOnly = true });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", MinimumWidth = 90, FillWeight = 12F, ReadOnly = true });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 170, FillWeight = 24F, ReadOnly = true });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRegular",
            HeaderText = "Thường xuyên (TX - 20%)",
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMidterm",
            HeaderText = "Giữa khóa (GK - 30%)",
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colFinal",
            HeaderText = "Cuối khóa (CK - 50%)",
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAverage",
            HeaderText = "Điểm TB",
            MinimumWidth = 85,
            FillWeight = 9F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colResult",
            HeaderText = "Kết quả",
            MinimumWidth = 100,
            FillWeight = 11F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    private async Task LoadClassGradesAsync(int classId, string classCode)
    {
        _currentClassId = classId;
        _currentClass = classCode;
        Text = $"Nhập bảng điểm lớp {classCode} - ECMS";

        try
        {
            _isCalculating = true;
            dgvStudentGrades.Rows.Clear();
            var items = (await _examService.GetClassGradeEntriesAsync(classId)).ToList();
            int stt = 1;
            foreach (var s in items)
            {
                string reg = s.RegularScore.HasValue ? s.RegularScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string mid = s.MidtermScore.HasValue ? s.MidtermScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string fin = s.FinalScore.HasValue ? s.FinalScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";

                int idx = dgvStudentGrades.Rows.Add(stt++, s.StudentCode, s.FullName, reg, mid, fin, "-", "Chưa đủ điểm");
                dgvStudentGrades.Rows[idx].Tag = s.StudentId;
                RecalculateRow(idx);
            }
            dgvStudentGrades.ClearSelection();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi nạp bảng điểm lớp", ex.Message);
        }
        finally
        {
            _isCalculating = false;
        }
    }

    private void RecalculateRow(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= dgvStudentGrades.Rows.Count) return;
        var row = dgvStudentGrades.Rows[rowIndex];

        bool hasReg = TryParseScore(row.Cells["colRegular"].Value?.ToString(), out double reg);
        bool hasMid = TryParseScore(row.Cells["colMidterm"].Value?.ToString(), out double mid);
        bool hasFin = TryParseScore(row.Cells["colFinal"].Value?.ToString(), out double fin);

        if (hasReg && hasMid && hasFin)
        {
            double avg = Math.Round(reg * 0.2 + mid * 0.3 + fin * 0.5, 1);
            row.Cells["colAverage"].Value = avg.ToString("0.0", CultureInfo.InvariantCulture);
            row.Cells["colResult"].Value = avg >= 5.0 ? "Đạt" : "Chưa đạt";
            row.Cells["colResult"].Style.ForeColor = avg >= 5.0 ? Color.FromArgb(22, 101, 52) : Color.FromArgb(220, 38, 38);
        }
        else
        {
            row.Cells["colAverage"].Value = "-";
            row.Cells["colResult"].Value = "Chưa đủ điểm";
            row.Cells["colResult"].Style.ForeColor = Color.FromArgb(100, 116, 139);
        }
    }

    private static bool TryParseScore(string? raw, out double val)
    {
        val = 0;
        if (string.IsNullOrWhiteSpace(raw)) return false;
        string cleaned = raw.Trim().Replace(',', '.');
        if (!double.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out val)) return false;
        return val >= 0 && val <= 10;
    }

    private void WireEvents()
    {
        cboClass.SelectedIndexChanged += async (s, e) =>
        {
            if (cboClass.SelectedIndex >= 0 && cboClass.SelectedIndex < _classes.Count)
            {
                var cls = _classes[cboClass.SelectedIndex];
                await LoadClassGradesAsync(cls.ClassId, cls.ClassCode);
            }
        };

        dgvStudentGrades.CellValueChanged += (s, e) =>
        {
            if (_isCalculating || e.RowIndex < 0) return;
            string colName = dgvStudentGrades.Columns[e.ColumnIndex].Name;
            if (colName == "colRegular" || colName == "colMidterm" || colName == "colFinal")
            {
                var cell = dgvStudentGrades.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string? raw = cell.Value?.ToString();
                if (!string.IsNullOrWhiteSpace(raw) && !TryParseScore(raw, out _))
                {
                    AppDialog.ShowWarning(this, "Điểm không hợp lệ", "Điểm phải nằm trong khoảng từ 0.0 đến 10.0.");
                    cell.Value = "";
                }
                RecalculateRow(e.RowIndex);
            }
        };

        btnClose.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        btnSave.Click += async (s, e) =>
        {
            if (_currentClassId <= 0) return;

            dgvStudentGrades.EndEdit();
            var entries = new List<StudentGradeEntryDto>();
            foreach (DataGridViewRow row in dgvStudentGrades.Rows)
            {
                if (row.IsNewRow || row.Tag is not int studentId) continue;

                var entry = new StudentGradeEntryDto
                {
                    StudentId = studentId,
                    StudentCode = row.Cells["colCode"].Value?.ToString() ?? "",
                    FullName = row.Cells["colName"].Value?.ToString() ?? ""
                };

                if (TryParseScore(row.Cells["colRegular"].Value?.ToString(), out double r)) entry.RegularScore = r;
                if (TryParseScore(row.Cells["colMidterm"].Value?.ToString(), out double m)) entry.MidtermScore = m;
                if (TryParseScore(row.Cells["colFinal"].Value?.ToString(), out double f)) entry.FinalScore = f;

                entries.Add(entry);
            }

            var res = await _examService.SaveClassGradeEntriesAsync(_currentClassId, entries);
            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Lưu bảng điểm thành công", res.Message);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AppDialog.ShowError(this, "Lỗi lưu bảng điểm", res.Message);
            }
        };
    }
}
