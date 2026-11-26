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
    private readonly IExamService _examService;
    private List<ClassExamLookupDto> _classList = new();
    private int _currentClassId = 1;
    private string _currentClassCode = "IELTS-F01";
    private bool _isCalculating = false;

    public GradeEntryDialog() : this("IELTS-F01")
    {
    }

    public GradeEntryDialog(string defaultClass = "IELTS-F01")
    {
        InitializeComponent();
        _examService = new ExamService();
        _currentClassCode = string.IsNullOrEmpty(defaultClass) ? "IELTS-F01" : defaultClass;

        SetupGrid();
        _ = LoadClassesDataAsync(_currentClassCode);
        WireEvents();
    }

    private void SetupGrid()
    {
        dgvStudentGrades.AutoGenerateColumns = false;
        dgvStudentGrades.Columns.Clear();
        dgvStudentGrades.SelectionMode = DataGridViewSelectionMode.CellSelect;
        dgvStudentGrades.MultiSelect = false;
        dgvStudentGrades.ReadOnly = false;
        dgvStudentGrades.RowHeadersVisible = false;
        dgvStudentGrades.AllowUserToAddRows = false;
        dgvStudentGrades.ScrollBars = ScrollBars.Both;

        // Cột ẩn StudentId
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudentId", Visible = false });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 50, MinimumWidth = 45, FillWeight = 4F, ReadOnly = true });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", Width = 100, MinimumWidth = 90, FillWeight = 9F, ReadOnly = true });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 19F, ReadOnly = true });

        // 3 Cột điểm có thể nhập trực tiếp
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRegular",
            HeaderText = "Thường xuyên (TX · 20%)",
            Width = 145,
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMidterm",
            HeaderText = "Giữa khóa (GK · 30%)",
            Width = 145,
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colFinal",
            HeaderText = "Cuối khóa (CK · 50%)",
            Width = 145,
            MinimumWidth = 130,
            FillWeight = 14F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        // Điểm TB và Kết quả (Tự động tính)
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAverage",
            HeaderText = "Điểm TB",
            Width = 95,
            MinimumWidth = 85,
            FillWeight = 9F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), BackColor = Color.FromArgb(248, 250, 252) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colResult",
            HeaderText = "Kết quả",
            Width = 120,
            MinimumWidth = 110,
            FillWeight = 11F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), BackColor = Color.FromArgb(248, 250, 252) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colComment",
            HeaderText = "Ghi chú học vụ",
            MinimumWidth = 160,
            FillWeight = 20F
        });

        dgvStudentGrades.CellValueChanged += DgvStudentGrades_CellValueChanged;
        dgvStudentGrades.CellFormatting += DgvStudentGrades_CellFormatting;
    }

    private async Task LoadClassesDataAsync(string defaultClass)
    {
        try
        {
            var classes = (await _examService.GetClassesLookupAsync()).ToList();
            _classList = classes;

            cboClass.Items.Clear();
            int selectedIndex = 0;

            for (int i = 0; i < classes.Count; i++)
            {
                cboClass.Items.Add(classes[i].ClassCode);
                if (classes[i].ClassCode == defaultClass)
                {
                    selectedIndex = i;
                }
            }

            if (cboClass.Items.Count > 0)
            {
                cboClass.SelectedIndex = selectedIndex;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadClassGradesAsync(int classId, string classCode)
    {
        _currentClassId = classId;
        _currentClassCode = classCode;

        var cls = _classList.FirstOrDefault(c => c.ClassId == classId);
        lblTitle.Text = $"Sổ điểm lớp học · {_currentClassCode}";
        if (cls != null)
        {
            lblSub.Text = $"Khóa học: {cls.CourseName} | Giáo viên: {cls.TeacherName} | Sĩ số: {cls.StudentCount} học viên";
        }
        lblSaveNotice.Visible = false;

        _isCalculating = true;
        try
        {
            dgvStudentGrades.Rows.Clear();
            var rows = await _examService.GetClassGradeBookAsync(classId);

            int stt = 1;
            foreach (var r in rows)
            {
                string regText = r.RegularScore.HasValue ? r.RegularScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string midText = r.MidtermScore.HasValue ? r.MidtermScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string finText = r.FinalScore.HasValue ? r.FinalScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string avgText = r.AverageScore.HasValue ? r.AverageScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string resultText = string.IsNullOrEmpty(r.ResultText) ? "--" : r.ResultText;

                dgvStudentGrades.Rows.Add(
                    r.StudentId,
                    stt.ToString(),
                    r.StudentCode,
                    r.FullName,
                    regText,
                    midText,
                    finText,
                    avgText,
                    resultText,
                    r.Comment ?? ""
                );
                stt++;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải điểm học viên từ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isCalculating = false;
        }
    }

    private void DgvStudentGrades_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (_isCalculating || e.RowIndex < 0) return;

        string colName = dgvStudentGrades.Columns[e.ColumnIndex].Name;
        if (colName == "colRegular" || colName == "colMidterm" || colName == "colFinal")
        {
            CalculateRowAverage(e.RowIndex);
        }
    }

    private void CalculateRowAverage(int rowIndex)
    {
        _isCalculating = true;
        try
        {
            var row = dgvStudentGrades.Rows[rowIndex];
            double? regular = ParseNullableScore(row.Cells["colRegular"].Value);
            double? mid = ParseNullableScore(row.Cells["colMidterm"].Value);
            double? final = ParseNullableScore(row.Cells["colFinal"].Value);

            if (regular.HasValue || mid.HasValue || final.HasValue)
            {
                double rVal = regular ?? 0;
                double mVal = mid ?? 0;
                double fVal = final ?? 0;

                double avg = (rVal * 0.2) + (mVal * 0.3) + (fVal * 0.5);
                row.Cells["colAverage"].Value = avg.ToString("0.0", CultureInfo.InvariantCulture);

                if (avg >= 8.5)
                {
                    row.Cells["colResult"].Value = "✓ Xuất sắc";
                }
                else if (avg >= 6.5)
                {
                    row.Cells["colResult"].Value = "✓ Đạt";
                }
                else
                {
                    row.Cells["colResult"].Value = "✕ Chưa đạt";
                }
            }
            else
            {
                row.Cells["colAverage"].Value = "";
                row.Cells["colResult"].Value = "--";
            }
        }
        finally
        {
            _isCalculating = false;
        }
    }

    private static double? ParseNullableScore(object? val)
    {
        if (val == null) return null;
        string s = val.ToString()?.Trim().Replace(',', '.') ?? "";
        if (string.IsNullOrEmpty(s)) return null;

        if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double res))
        {
            return Math.Clamp(res, 0, 10);
        }
        return null;
    }

    private static decimal? ParseNullableDecimal(object? val)
    {
        if (val == null) return null;
        string s = val.ToString()?.Trim().Replace(',', '.') ?? "";
        if (string.IsNullOrEmpty(s)) return null;

        if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal res))
        {
            return Math.Clamp(res, 0m, 10m);
        }
        return null;
    }

    private void DgvStudentGrades_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvStudentGrades.Columns[e.ColumnIndex].Name == "colResult" && e.Value != null)
        {
            string res = e.Value.ToString() ?? "";
            if (res.Contains("✓"))
            {
                e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52); // Xanh lá
            }
            else if (res.Contains("✕"))
            {
                e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Đỏ
            }
            else
            {
                e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            }
        }
    }

    private void WireEvents()
    {
        btnClose.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        cboClass.SelectedIndexChanged += async (s, e) =>
        {
            string selected = cboClass.SelectedItem?.ToString() ?? "IELTS-F01";
            var cls = _classList.FirstOrDefault(c => c.ClassCode == selected);
            if (cls != null)
            {
                await LoadClassGradesAsync(cls.ClassId, cls.ClassCode);
            }
        };

        btnSave.Click += async (s, e) =>
        {
            btnSave.Enabled = false;
            try
            {
                var rowsToSave = new List<ClassGradeRowDto>();
                foreach (DataGridViewRow row in dgvStudentGrades.Rows)
                {
                    if (row.IsNewRow) continue;

                    int studentId = Convert.ToInt32(row.Cells["colStudentId"].Value);
                    string code = row.Cells["colCode"].Value?.ToString() ?? "";
                    string name = row.Cells["colName"].Value?.ToString() ?? "";
                    decimal? reg = ParseNullableDecimal(row.Cells["colRegular"].Value);
                    decimal? mid = ParseNullableDecimal(row.Cells["colMidterm"].Value);
                    decimal? fin = ParseNullableDecimal(row.Cells["colFinal"].Value);
                    decimal? avg = ParseNullableDecimal(row.Cells["colAverage"].Value);
                    string result = row.Cells["colResult"].Value?.ToString() ?? "";
                    string comment = row.Cells["colComment"].Value?.ToString() ?? "";

                    rowsToSave.Add(new ClassGradeRowDto
                    {
                        StudentId = studentId,
                        StudentCode = code,
                        FullName = name,
                        RegularScore = reg,
                        MidtermScore = mid,
                        FinalScore = fin,
                        AverageScore = avg,
                        ResultText = result,
                        Comment = comment
                    });
                }

                await _examService.SaveClassGradeBookAsync(_currentClassId, rowsToSave);

                lblSaveNotice.Visible = true;
                MessageBox.Show(
                    $"Đã lưu bảng điểm thành công cho toàn bộ {rowsToSave.Count} học viên lớp {_currentClassCode} vào hệ thống CSDL!",
                    "Lưu bảng điểm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu bảng điểm vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        };
    }
}
