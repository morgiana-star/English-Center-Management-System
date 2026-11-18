using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class GradeEntryDialog : Form
{
    private string _currentClass = "IELTS-F01";
    private bool _isCalculating = false;

    public GradeEntryDialog() : this("IELTS-F01")
    {
    }

    public GradeEntryDialog(string defaultClass = "IELTS-F01")
    {
        InitializeComponent();

        _currentClass = string.IsNullOrEmpty(defaultClass) ? "IELTS-F01" : defaultClass;

        SetupClassSelector();
        SetupGrid();
        LoadClassGrades(_currentClass);
        WireEvents();
    }

    private void SetupClassSelector()
    {
        cboClass.Items.Clear();
        cboClass.Items.AddRange(new object[]
        {
            "IELTS-F01",
            "IELTS-F02",
            "IELTS-I01",
            "TOEIC-A01",
            "COM-B01"
        });

        int idx = cboClass.FindStringExact(_currentClass);
        cboClass.SelectedIndex = idx >= 0 ? idx : 0;
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
            double regular = ParseScore(row.Cells["colRegular"].Value);
            double mid = ParseScore(row.Cells["colMidterm"].Value);
            double final = ParseScore(row.Cells["colFinal"].Value);

            double avg = (regular * 0.2) + (mid * 0.3) + (final * 0.5);
            row.Cells["colAverage"].Value = avg.ToString("0.0", CultureInfo.InvariantCulture);

            if (avg >= 6.5)
            {
                row.Cells["colResult"].Value = avg >= 8.5 ? "✓ Xuất sắc" : "✓ Đạt";
            }
            else
            {
                row.Cells["colResult"].Value = "✕ Chưa đạt";
            }
        }
        finally
        {
            _isCalculating = false;
        }
    }

    private static double ParseScore(object? val)
    {
        if (val == null) return 0;
        string s = val.ToString()?.Trim().Replace(',', '.') ?? "";
        return double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double res) ? Math.Clamp(res, 0, 10) : 0;
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
        }
    }

    private void LoadClassGrades(string classCode)
    {
        _currentClass = classCode;
        lblTitle.Text = $"Sổ điểm lớp học · {_currentClass}";
        lblSub.Text = $"Khóa học: {GetCourseName(_currentClass)} | Giáo viên: {GetTeacherName(_currentClass)} | Sĩ số: 20 học viên";
        lblSaveNotice.Visible = false;

        _isCalculating = true;
        dgvStudentGrades.Rows.Clear();

        dgvStudentGrades.Rows.Add("1", "HV-0241", "Nguyễn Minh Anh", "8.5", "8.0", "9.0", "8.6", "✓ Xuất sắc", "Tiếp thu nhanh, phát âm chuẩn");
        dgvStudentGrades.Rows.Add("2", "HV-0237", "Lê Hoàng Nam", "7.5", "7.0", "7.5", "7.4", "✓ Đạt", "Cần luyện thêm Writing Task 2");
        dgvStudentGrades.Rows.Add("3", "HV-0238", "Phạm Khánh Linh", "9.0", "9.5", "9.0", "9.2", "✓ Xuất sắc", "Kỹ năng Listening xuất sắc");
        dgvStudentGrades.Rows.Add("4", "HV-0240", "Vũ Quang Huy", "6.5", "6.0", "7.0", "6.6", "✓ Đạt", "Ngữ pháp còn hạn chế");
        dgvStudentGrades.Rows.Add("5", "HV-0242", "Đặng Thị Thảo", "5.0", "4.5", "5.0", "4.9", "✕ Chưa đạt", "Vắng nhiều buổi, cần phụ đạo");
        dgvStudentGrades.Rows.Add("6", "HV-0245", "Trần Bảo Long", "8.0", "8.5", "8.0", "8.2", "✓ Đạt", "Tích cực phát biểu");
        dgvStudentGrades.Rows.Add("7", "HV-0246", "Hoàng Ngọc Mai", "7.0", "7.5", "8.0", "7.7", "✓ Đạt", "Nộp bài tập đầy đủ");
        dgvStudentGrades.Rows.Add("8", "HV-0247", "Đỗ Quốc Cường", "6.5", "7.0", "6.5", "6.7", "✓ Đạt", "Cần cải thiện Speaking");

        _isCalculating = false;
    }

    private static string GetCourseName(string classCode) => classCode switch
    {
        "IELTS-F01" or "IELTS-F02" => "IELTS Foundation",
        "IELTS-I01" => "IELTS Intensive",
        "TOEIC-A01" => "TOEIC 500+",
        "COM-B01" => "Giao tiếp cơ bản",
        _ => "IELTS Foundation"
    };

    private static string GetTeacherName(string classCode) => classCode switch
    {
        "IELTS-F01" => "Nguyễn Hoàng Anh",
        "IELTS-F02" or "IELTS-I01" => "Trần Minh Tuấn",
        "TOEIC-A01" or "COM-B01" => "Lê Thu Hà",
        _ => "Nguyễn Hoàng Anh"
    };

    private void WireEvents()
    {
        btnClose.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        cboClass.SelectedIndexChanged += (s, e) =>
        {
            string selected = cboClass.SelectedItem?.ToString() ?? "IELTS-F01";
            LoadClassGrades(selected);
        };

        btnSave.Click += (s, e) =>
        {
            lblSaveNotice.Visible = true;
            MessageBox.Show($"Đã lưu kết quả bảng điểm thành công cho lớp {_currentClass}!", "Lưu bảng điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }
}
