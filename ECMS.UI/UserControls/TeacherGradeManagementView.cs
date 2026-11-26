using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherGradeManagementView : UserControl
{
    private class AssessmentDisplayItem
    {
        public int Stt { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ClassCode { get; set; } = string.Empty;
        public string ClassesDisplay { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string GradedRatio { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    private readonly IExamService _examService;
    private readonly List<AssessmentDisplayItem> _items = new();
    private List<ClassExamLookupDto> _classList = new();

    public TeacherGradeManagementView()
    {
        InitializeComponent();
        _examService = new ExamService();

        SetupGrid();
        _ = InitializeViewAsync();
        WireEvents();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustLayout();
    }

    private void AdjustLayout()
    {
        if (pnlBody == null || pnlFilterBar == null || cardAssessmentList == null) return;

        int pad = 24;
        int availWidth = Math.Max(700, pnlBody.ClientSize.Width - pad * 2);
        int topY = 16;

        pnlFilterBar.SetBounds(pad, topY, availWidth, 48);

        int cardY = pnlFilterBar.Bottom + 12;
        int cardHeight = Math.Max(300, pnlBody.ClientSize.Height - cardY - pad);
        cardAssessmentList.SetBounds(pad, cardY, availWidth, cardHeight);
    }

    private async Task InitializeViewAsync()
    {
        await SetupFiltersAsync();
        await LoadExamsDataAsync();
    }

    private async Task SetupFiltersAsync()
    {
        try
        {
            var classes = (await _examService.GetClassesLookupAsync()).ToList();
            _classList = classes;

            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả lớp");

            foreach (var c in classes)
            {
                cboClassFilter.Items.Add(c.ClassCode);
            }
            cboClassFilter.SelectedIndex = 0;

            cboTypeFilter.Items.Clear();
            cboTypeFilter.Items.AddRange(new object[]
            {
                "Tất cả loại bài thi",
                "Thường xuyên (TX)",
                "Giữa khóa (GK)",
                "Cuối khóa (CK)",
                "Đầu vào"
            });
            cboTypeFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải bộ lọc kỳ thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetupGrid()
    {
        dgvAssessments.AutoGenerateColumns = false;
        dgvAssessments.Columns.Clear();
        dgvAssessments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAssessments.MultiSelect = false;
        dgvAssessments.ReadOnly = true;
        dgvAssessments.RowHeadersVisible = false;
        dgvAssessments.AllowUserToAddRows = false;
        dgvAssessments.AllowUserToDeleteRows = false;

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Stt",
            HeaderText = "STT",
            Width = 50,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Title",
            HeaderText = "Tên bài kiểm tra",
            Width = 240
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ClassesDisplay",
            HeaderText = "Lớp áp dụng",
            Width = 180
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Type",
            HeaderText = "Loại bài thi",
            Width = 140
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Weight",
            HeaderText = "Trọng số",
            Width = 90,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Date",
            HeaderText = "Ngày thi",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "GradedRatio",
            HeaderText = "Tiến độ",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 140
        });

        var btnActionCol = new DataGridViewButtonColumn
        {
            HeaderText = "Thao tác",
            Text = "Nhập điểm",
            UseColumnTextForButtonValue = true,
            Width = 110,
            FlatStyle = FlatStyle.Flat
        };
        dgvAssessments.Columns.Add(btnActionCol);

        dgvAssessments.CellFormatting += (s, e) =>
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvAssessments.Columns.Count &&
                dgvAssessments.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                var val = e.Value.ToString() ?? "";
                if (val.Contains("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
                }
            }
        };

        dgvAssessments.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvAssessments.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                OpenGradeEntryForRow(e.RowIndex);
            }
        };

        dgvAssessments.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenGradeEntryForRow(e.RowIndex);
            }
        };
    }

    private async Task LoadExamsDataAsync()
    {
        try
        {
            var exams = (await _examService.GetExamsAsync()).ToList();

            // Nếu trong CSDL chưa có bài thi nào, tự động tạo mẫu các bài thi chuẩn cho các lớp để người dùng trải nghiệm ngay
            if (exams.Count == 0 && _classList.Count > 0)
            {
                foreach (var cls in _classList.Take(3))
                {
                    await _examService.CreateExamAsync(new CreateExamDto
                    {
                        ClassId = cls.ClassId,
                        ExamName = "Bài kiểm tra thường xuyên số 1",
                        Type = "Quiz",
                        ExamDate = DateTime.Today.AddDays(-20).ToString("yyyy-MM-dd"),
                        WeightPercentage = 20.0m
                    });

                    await _examService.CreateExamAsync(new CreateExamDto
                    {
                        ClassId = cls.ClassId,
                        ExamName = "Kiểm tra Giữa kỳ (Midterm Test)",
                        Type = "Midterm",
                        ExamDate = DateTime.Today.AddDays(-5).ToString("yyyy-MM-dd"),
                        WeightPercentage = 30.0m
                    });

                    await _examService.CreateExamAsync(new CreateExamDto
                    {
                        ClassId = cls.ClassId,
                        ExamName = "Kiểm tra Cuối kỳ (Final Exam)",
                        Type = "Final",
                        ExamDate = DateTime.Today.AddDays(25).ToString("yyyy-MM-dd"),
                        WeightPercentage = 50.0m
                    });
                }

                exams = (await _examService.GetExamsAsync()).ToList();
            }

            _items.Clear();
            int stt = 1;
            foreach (var ex in exams)
            {
                _items.Add(new AssessmentDisplayItem
                {
                    Stt = stt++,
                    ExamId = ex.ExamId,
                    ClassId = ex.ClassId,
                    Title = ex.ExamName,
                    ClassCode = ex.ClassCode,
                    ClassesDisplay = $"{ex.ClassCode} ({ex.CourseName})",
                    Type = ex.TypeDisplay,
                    Date = ex.DateDisplay,
                    Weight = ex.WeightDisplay,
                    GradedRatio = ex.GradedRatioDisplay,
                    Status = ex.StatusDisplay
                });
            }

            ApplyFilter();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách bài kiểm tra từ CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OpenGradeEntryForRow(int rowIndex)
    {
        if (rowIndex >= 0 && rowIndex < dgvAssessments.Rows.Count)
        {
            if (dgvAssessments.Rows[rowIndex].DataBoundItem is AssessmentDisplayItem item)
            {
                using var dlg = new GradeEntryDialog(item.ClassCode);
                if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
                {
                    _ = LoadExamsDataAsync();
                }
                return;
            }
        }

        using var fallbackDlg = new GradeEntryDialog("IELTS-F01");
        if (fallbackDlg.ShowDialog(ParentForm) == DialogResult.OK)
        {
            _ = LoadExamsDataAsync();
        }
    }

    private void WireEvents()
    {
        btnEnterGradesTop.Click += (s, e) =>
        {
            var selectedClass = cboClassFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClass) || selectedClass == "Tất cả lớp")
            {
                selectedClass = _classList.FirstOrDefault()?.ClassCode ?? "IELTS-F01";
            }

            using var dlg = new GradeEntryDialog(selectedClass);
            if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                _ = LoadExamsDataAsync();
            }
        };

        btnCreateAssessmentTop.Click += async (s, e) =>
        {
            var selectedClass = cboClassFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClass) || selectedClass == "Tất cả lớp")
            {
                selectedClass = _classList.FirstOrDefault()?.ClassCode ?? "IELTS-F01";
            }

            using var dlg = new CreateAssessmentDialog(selectedClass);
            if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                await LoadExamsDataAsync();
            }
        };

        txtSearchAssessment.TextChanged += (s, e) => ApplyFilter();
        cboClassFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboTypeFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
    }

    private void ApplyFilter()
    {
        var q = txtSearchAssessment.Text?.Trim().ToLowerInvariant() ?? "";
        var selectedClass = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";
        var selectedType = cboTypeFilter.SelectedItem?.ToString() ?? "Tất cả loại bài thi";

        var filtered = _items.Where(i =>
            (string.IsNullOrEmpty(q) ||
             i.Title.ToLowerInvariant().Contains(q) ||
             i.ClassesDisplay.ToLowerInvariant().Contains(q) ||
             i.Type.ToLowerInvariant().Contains(q)) &&
            (selectedClass == "Tất cả lớp" || i.ClassCode == selectedClass || i.ClassesDisplay.Contains(selectedClass)) &&
            (selectedType == "Tất cả loại bài thi" || i.Type.Contains(selectedType.Replace("Tất cả loại bài thi", "")) || selectedType.Contains(i.Type))
        ).ToList();

        // Cập nhật lại STT sau khi lọc
        for (int i = 0; i < filtered.Count; i++)
        {
            filtered[i].Stt = i + 1;
        }

        dgvAssessments.DataSource = null;
        dgvAssessments.DataSource = filtered;
    }
}
