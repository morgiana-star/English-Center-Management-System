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
    private decimal _currentPassingScore = 5.0m;
    private bool _isCalculating = false;
    private bool _isClassChanging = false;

    public GradeEntryDialog() : this("IELTS-F01")
    {
    }

    public GradeEntryDialog(string defaultClass = "IELTS-F01")
    {
        InitializeComponent();
        _examService = new ExamService();
        _currentClassCode = string.IsNullOrEmpty(defaultClass) ? "IELTS-F01" : defaultClass;

        SetupGrid();
        WireEvents();
    }

    protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        await LoadClassesDataAsync(_currentClassCode);
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

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStt", HeaderText = "STT", Width = 45, MinimumWidth = 40, FillWeight = 4F, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCode", HeaderText = "Mã HV", Width = 95, MinimumWidth = 85, FillWeight = 9F, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9F, FontStyle.Bold) } });
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Họ và tên", MinimumWidth = 160, FillWeight = 20F, ReadOnly = true });

        // 4 Cột chấm điểm chuẩn IELTS
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colListening",
            HeaderText = "Listening (Nghe · 0-9)",
            Width = 135,
            MinimumWidth = 120,
            FillWeight = 13F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colReading",
            HeaderText = "Reading (Đọc · 0-9)",
            Width = 135,
            MinimumWidth = 120,
            FillWeight = 13F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colWriting",
            HeaderText = "Writing (Viết · 0-9)",
            Width = 135,
            MinimumWidth = 120,
            FillWeight = 13F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colSpeaking",
            HeaderText = "Speaking (Nói · 0-9)",
            Width = 135,
            MinimumWidth = 120,
            FillWeight = 13F,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) }
        });

        // Điểm IELTS Overall (Tự động tính theo chuẩn làm tròn IDP/BC)
        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colOverall",
            HeaderText = "IELTS Overall",
            Width = 115,
            MinimumWidth = 105,
            FillWeight = 11F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                BackColor = Color.FromArgb(239, 246, 255),
                ForeColor = Color.FromArgb(29, 78, 216)
            }
        });

        dgvStudentGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colResult",
            HeaderText = "Kết quả đạt chuẩn",
            Width = 145,
            MinimumWidth = 130,
            FillWeight = 14F,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                BackColor = Color.FromArgb(248, 250, 252)
            }
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

            _isClassChanging = true;
            cboClass.Items.Clear();
            int selectedIndex = 0;

            for (int i = 0; i < classes.Count; i++)
            {
                cboClass.Items.Add(classes[i].ClassCode);
                if (classes[i].ClassCode.Equals(defaultClass, StringComparison.OrdinalIgnoreCase))
                {
                    selectedIndex = i;
                }
            }

            if (cboClass.Items.Count > 0)
            {
                cboClass.SelectedIndex = selectedIndex;
                var targetClass = _classList[selectedIndex];
                _isClassChanging = false;
                await LoadClassGradesAsync(targetClass.ClassId, targetClass.ClassCode);
            }
            else
            {
                _isClassChanging = false;
                await LoadClassGradesAsync(1, defaultClass);
            }
        }
        catch (Exception ex)
        {
            _isClassChanging = false;
            MessageBox.Show("Lỗi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadClassGradesAsync(int classId, string classCode)
    {
        _currentClassId = classId;
        _currentClassCode = classCode;

        var cls = _classList.FirstOrDefault(c => c.ClassId == classId || c.ClassCode == classCode);
        _currentPassingScore = cls?.PassingScore ?? 5.0m;

        lblTitle.Text = $"Sổ điểm IELTS 4 Kỹ năng · {_currentClassCode}";
        if (cls != null)
        {
            lblSub.Text = $"Khóa học: {cls.CourseName} | Giáo viên: {cls.TeacherName} | Sĩ số: {cls.StudentCount} học viên | Chuẩn đạt: Overall ≥ {_currentPassingScore:0.0}";
        }
        else
        {
            lblSub.Text = $"Lớp học: {_currentClassCode} | Thang điểm: IELTS Band 0.0 – 9.0";
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
                string lText = r.ListeningScore.HasValue ? r.ListeningScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string rText = r.ReadingScore.HasValue ? r.ReadingScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string wText = r.WritingScore.HasValue ? r.WritingScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string sText = r.SpeakingScore.HasValue ? r.SpeakingScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string overallText = r.OverallScore.HasValue ? r.OverallScore.Value.ToString("0.0", CultureInfo.InvariantCulture) : "";
                string resultText = string.IsNullOrEmpty(r.ResultText) ? "--" : r.ResultText;

                dgvStudentGrades.Rows.Add(
                    r.StudentId,
                    stt.ToString(),
                    r.StudentCode,
                    r.FullName,
                    lText,
                    rText,
                    wText,
                    sText,
                    overallText,
                    resultText
                );
                stt++;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải bảng điểm học viên từ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        if (colName == "colListening" || colName == "colReading" || colName == "colWriting" || colName == "colSpeaking")
        {
            CalculateIeltsRow(e.RowIndex);
        }
    }

    private void CalculateIeltsRow(int rowIndex)
    {
        _isCalculating = true;
        try
        {
            var row = dgvStudentGrades.Rows[rowIndex];
            double? l = ParseIeltsScore(row.Cells["colListening"].Value);
            double? r = ParseIeltsScore(row.Cells["colReading"].Value);
            double? w = ParseIeltsScore(row.Cells["colWriting"].Value);
            double? s = ParseIeltsScore(row.Cells["colSpeaking"].Value);

            var skills = new List<double>();
            if (l.HasValue) skills.Add(l.Value);
            if (r.HasValue) skills.Add(r.Value);
            if (w.HasValue) skills.Add(w.Value);
            if (s.HasValue) skills.Add(s.Value);

            if (skills.Count > 0)
            {
                // Quy tắc làm tròn IELTS chuẩn quốc tế
                double mean = skills.Average();
                double intPart = Math.Floor(mean);
                double frac = mean - intPart;

                double overall;
                if (frac < 0.25)
                    overall = intPart;
                else if (frac < 0.75)
                    overall = intPart + 0.5;
                else
                    overall = intPart + 1.0;

                row.Cells["colOverall"].Value = overall.ToString("0.0", CultureInfo.InvariantCulture);

                if ((decimal)overall >= _currentPassingScore)
                {
                    row.Cells["colResult"].Value = $"✓ Đạt (Band {overall:0.0})";
                }
                else
                {
                    row.Cells["colResult"].Value = $"✕ Chưa đạt ({overall:0.0})";
                }
            }
            else
            {
                row.Cells["colOverall"].Value = "";
                row.Cells["colResult"].Value = "--";
            }
        }
        finally
        {
            _isCalculating = false;
        }
    }

    private static double? ParseIeltsScore(object? val)
    {
        if (val == null) return null;
        string s = val.ToString()?.Trim().Replace(',', '.') ?? "";
        if (string.IsNullOrEmpty(s)) return null;

        if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double res))
        {
            return Math.Clamp(res, 0.0, 9.0);
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
            return Math.Clamp(res, 0m, 9.0m);
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
            if (_isClassChanging) return;
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
                    decimal? lis = ParseNullableDecimal(row.Cells["colListening"].Value);
                    decimal? read = ParseNullableDecimal(row.Cells["colReading"].Value);
                    decimal? writ = ParseNullableDecimal(row.Cells["colWriting"].Value);
                    decimal? spk = ParseNullableDecimal(row.Cells["colSpeaking"].Value);
                    decimal? overall = ParseNullableDecimal(row.Cells["colOverall"].Value);
                    string result = row.Cells["colResult"].Value?.ToString() ?? "";

                    rowsToSave.Add(new ClassGradeRowDto
                    {
                        StudentId = studentId,
                        StudentCode = code,
                        FullName = name,
                        ListeningScore = lis,
                        ReadingScore = read,
                        WritingScore = writ,
                        SpeakingScore = spk,
                        OverallScore = overall,
                        ResultText = result,
                        Comment = null // Xóa hoàn toàn ghi chú học vụ
                    });
                }

                await _examService.SaveClassGradeBookAsync(_currentClassId, rowsToSave);

                lblSaveNotice.Visible = true;
                MessageBox.Show(
                    $"Đã lưu bảng điểm IELTS 4 kỹ năng thành công cho toàn bộ {rowsToSave.Count} học viên lớp {_currentClassCode} vào hệ thống CSDL!",
                    "Lưu bảng điểm IELTS thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
