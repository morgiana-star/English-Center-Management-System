using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class TeacherGradeEntryView : UserControl
{
    private class StudentGradeRow
    {
        public string StudentCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public double RegularScore { get; set; }
        public double MidtermScore { get; set; }
        public string FinalScoreText { get; set; } = string.Empty;
        public double? FinalScore { get; set; }
        public string AverageText { get; set; } = string.Empty;
        public string ResultText { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }

    private readonly List<StudentGradeRow> _rows = new();
    private StudentGradeRow? _selectedRow;

    public TeacherGradeEntryView()
    {
        InitializeComponent();

        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupGrid()
    {
        dgvGrades.AutoGenerateColumns = false;
        dgvGrades.Columns.Clear();
        dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvGrades.MultiSelect = false;
        dgvGrades.ReadOnly = true;
        dgvGrades.RowHeadersVisible = false;
        dgvGrades.AllowUserToAddRows = false;

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "StudentCode",
            HeaderText = "Mã học viên ↑",
            Width = 120
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Họ và tên",
            Width = 180
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "RegularScore",
            HeaderText = "TX · 20%",
            Width = 95,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "N1" }
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MidtermScore",
            HeaderText = "GK · 30%",
            Width = 95,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "N1" }
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FinalScoreText",
            HeaderText = "CK · 50%",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "AverageText",
            HeaderText = "Trung bình",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ResultText",
            HeaderText = "Kết quả",
            Width = 130,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvGrades.CellFormatting += (s, e) =>
        {
            var colName = dgvGrades.Columns[e.ColumnIndex].DataPropertyName;
            if (e.Value == null) return;

            var val = e.Value.ToString() ?? "";
            if (colName == "FinalScoreText" && val.Contains("cần sửa"))
            {
                e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            }
            else if (colName == "ResultText")
            {
                if (val.Contains("✓ Đạt"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (val.Contains("✕ Không đạt") || val.Contains("Chưa hợp lệ"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
        };
    }

    private void LoadSampleData()
    {
        _rows.Clear();
        _rows.Add(new StudentGradeRow
        {
            StudentCode = "HV-0204",
            FullName = "Trần Gia Bảo",
            RegularScore = 7.0,
            MidtermScore = 7.5,
            FinalScoreText = "✕ 11 - cần sửa",
            FinalScore = 11.0,
            AverageText = "—",
            ResultText = "Chưa hợp lệ",
            Comment = "Hoàn thành tốt phần đọc và viết."
        });

        _rows.Add(new StudentGradeRow
        {
            StudentCode = "HV-0205",
            FullName = "Đặng Minh Trí",
            RegularScore = 8.0,
            MidtermScore = 8.0,
            FinalScoreText = "8,8",
            FinalScore = 8.8,
            AverageText = "8,4",
            ResultText = "✓ Đạt",
            Comment = "Tiếp thu nhanh, phát âm chuẩn."
        });

        _rows.Add(new StudentGradeRow
        {
            StudentCode = "HV-0206",
            FullName = "Vũ Ngọc Lan",
            RegularScore = 6.0,
            MidtermScore = 5.5,
            FinalScoreText = "6,0",
            FinalScore = 6.0,
            AverageText = "5,9",
            ResultText = "✕ Không đạt",
            Comment = "Cần củng cố ngữ pháp và từ vựng."
        });

        _rows.Add(new StudentGradeRow
        {
            StudentCode = "HV-0207",
            FullName = "Hoàng Đức An",
            RegularScore = 7.0,
            MidtermScore = 7.0,
            FinalScoreText = "7,4",
            FinalScore = 7.4,
            AverageText = "7,2",
            ResultText = "✓ Đạt",
            Comment = "Nỗ lực tiến bộ rõ rệt."
        });

        _rows.Add(new StudentGradeRow
        {
            StudentCode = "HV-0208",
            FullName = "Trần Thảo Nhi",
            RegularScore = 7.0,
            MidtermScore = 7.0,
            FinalScoreText = "7,0",
            FinalScore = 7.0,
            AverageText = "7,0",
            ResultText = "✓ Đạt",
            Comment = "Đi học chăm chỉ, bài tập đầy đủ."
        });

        dgvGrades.DataSource = null;
        dgvGrades.DataSource = _rows;

        if (_rows.Count > 0)
        {
            dgvGrades.Rows[0].Selected = true;
            SelectStudent(_rows[0]);
        }

        UpdateGlobalStats();
    }

    private void SelectStudent(StudentGradeRow row)
    {
        _selectedRow = row;
        lblCurrentStudentTitle.Text = $"Điểm đang nhập · {row.FullName}";
        txtCurrentScore.Text = row.FinalScore.HasValue ? row.FinalScore.Value.ToString("0.#") : "";
        txtComment.Text = row.Comment;

        ValidateCurrentInput();
    }

    private void ValidateCurrentInput()
    {
        var text = txtCurrentScore.Text.Replace(",", ".").Trim();
        bool isValid = double.TryParse(text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var score)
                       && score >= 0.0 && score <= 10.0;

        if (!isValid)
        {
            lblScoreError.Visible = true;
            lblScoreError.Text = "Chỉ nhận 0–10. Nhập 8,0 để sửa lỗi.";
            lblScoreError.ForeColor = Color.FromArgb(220, 38, 38);
        }
        else
        {
            lblScoreError.Visible = false;
        }

        UpdateGlobalStats();
    }

    private void UpdateGlobalStats()
    {
        int invalidCount = _rows.Count(r => !r.FinalScore.HasValue || r.FinalScore.Value < 0 || r.FinalScore.Value > 10);
        int validCount = _rows.Count - invalidCount;

        statEntered.Value = $"{_rows.Count} / {_rows.Count}";
        statValid.Value = validCount.ToString();
        statNeedsFix.Value = invalidCount.ToString();
        statTotalWeight.Value = "100%";

        if (invalidCount > 0)
        {
            bannerError.Variant = BannerVariant.Danger;
            bannerError.Title = "✕ Trần Gia Bảo: điểm 11 vượt thang 0–10.";
            bannerError.Message = "Nút Lưu bị khóa; các điểm hợp lệ vẫn được giữ.";
            btnSaveGrades.Enabled = false;
        }
        else
        {
            bannerError.Variant = BannerVariant.Success;
            bannerError.Title = "✓ Tất cả 20 điểm số đều hợp lệ.";
            bannerError.Message = "Điểm trung bình và kết quả đạt/không đạt đã được tính tự động.";
            btnSaveGrades.Enabled = true;
        }
    }

    private void WireEvents()
    {
        dgvGrades.SelectionChanged += (s, e) =>
        {
            if (dgvGrades.CurrentRow?.DataBoundItem is StudentGradeRow row)
            {
                SelectStudent(row);
            }
        };

        txtCurrentScore.TextChanged += (s, e) =>
        {
            if (_selectedRow != null)
            {
                var text = txtCurrentScore.Text.Replace(",", ".").Trim();
                if (double.TryParse(text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var score))
                {
                    _selectedRow.FinalScore = score;
                    if (score >= 0 && score <= 10)
                    {
                        _selectedRow.FinalScoreText = score.ToString("0.0");
                        double avg = (_selectedRow.RegularScore * 0.2) + (_selectedRow.MidtermScore * 0.3) + (score * 0.5);
                        _selectedRow.AverageText = avg.ToString("0.0");
                        _selectedRow.ResultText = avg >= 6.5 ? "✓ Đạt" : "✕ Không đạt";
                    }
                    else
                    {
                        _selectedRow.FinalScoreText = $"✕ {score} - cần sửa";
                        _selectedRow.AverageText = "—";
                        _selectedRow.ResultText = "Chưa hợp lệ";
                    }
                }
                else
                {
                    _selectedRow.FinalScore = null;
                    _selectedRow.FinalScoreText = "—";
                    _selectedRow.AverageText = "—";
                    _selectedRow.ResultText = "Chưa hợp lệ";
                }

                dgvGrades.Refresh();
                ValidateCurrentInput();
            }
        };

        txtComment.TextChanged += (s, e) =>
        {
            if (_selectedRow != null)
            {
                _selectedRow.Comment = txtComment.Text.Trim();
            }
        };

        btnCancelEdit.Click += (s, e) =>
        {
            LoadSampleData();
        };

        btnSaveGrades.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Lưu điểm thành công",
                "Đã lưu bảng điểm bài thi cuối khóa lớp IELTS-F02 vào SQLite cục bộ.\n" +
                "Kết quả điểm số đã sẵn sàng cho quy trình xét cấp chứng chỉ.");
        };

        btnBackToList.Click += (s, e) =>
        {
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherGradeManagementView());
            }
        };
    }
}
