using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TeacherGradeManagementView : UserControl
{
    private class AssessmentItem
    {
        public int Stt { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ClassesDisplay { get; set; } = string.Empty;
        public List<string> ClassList { get; set; } = new();
        public string Type { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string GradedRatio { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    private readonly List<AssessmentItem> _items = new();

    public TeacherGradeManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadSampleData();
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

    private void SetupFilters()
    {
        cboClassFilter.Items.Clear();
        cboClassFilter.Items.AddRange(new object[]
        {
            "Tất cả lớp",
            "IELTS-F01",
            "IELTS-F02",
            "IELTS-I01",
            "TOEIC-A01",
            "COM-B01"
        });
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

    private void OpenGradeEntryForRow(int rowIndex)
    {
        if (dgvAssessments.Rows[rowIndex].DataBoundItem is AssessmentItem item)
        {
            string targetClass = item.ClassList.FirstOrDefault() ?? "IELTS-F01";
            using var dlg = new GradeEntryDialog(targetClass);
            dlg.ShowDialog(ParentForm);
        }
        else
        {
            using var dlg = new GradeEntryDialog("IELTS-F01");
            dlg.ShowDialog(ParentForm);
        }
    }

    private void LoadSampleData()
    {
        _items.Clear();
        _items.Add(new AssessmentItem
        {
            Stt = 1,
            Title = "Đánh giá xếp lớp đầu vào",
            ClassesDisplay = "IELTS-F01, IELTS-F02",
            ClassList = new List<string> { "IELTS-F01", "IELTS-F02" },
            Type = "Đầu vào",
            Date = "01/08/2026",
            Weight = "0%",
            GradedRatio = "38/38",
            Status = "✓ Đã có điểm"
        });

        _items.Add(new AssessmentItem
        {
            Stt = 2,
            Title = "Bài kiểm tra thường xuyên số 1",
            ClassesDisplay = "IELTS-F01, IELTS-F02",
            ClassList = new List<string> { "IELTS-F01", "IELTS-F02" },
            Type = "Thường xuyên (TX)",
            Date = "25/08/2026",
            Weight = "20%",
            GradedRatio = "38/38",
            Status = "✓ Đã có điểm"
        });

        _items.Add(new AssessmentItem
        {
            Stt = 3,
            Title = "Kiểm tra giữa khóa (Mid-term)",
            ClassesDisplay = "IELTS-F01, IELTS-F02, TOEIC-A01",
            ClassList = new List<string> { "IELTS-F01", "IELTS-F02", "TOEIC-A01" },
            Type = "Giữa khóa (GK)",
            Date = "15/09/2026",
            Weight = "30%",
            GradedRatio = "38/53",
            Status = "✓ Đã có điểm"
        });

        _items.Add(new AssessmentItem
        {
            Stt = 4,
            Title = "Kiểm tra cuối khóa (Final Exam)",
            ClassesDisplay = "IELTS-F01, IELTS-F02",
            ClassList = new List<string> { "IELTS-F01", "IELTS-F02" },
            Type = "Cuối khóa (CK)",
            Date = "20/10/2026",
            Weight = "50%",
            GradedRatio = "0/38",
            Status = "⏳ Chờ nhập điểm"
        });

        _items.Add(new AssessmentItem
        {
            Stt = 5,
            Title = "Mini-test ngữ pháp & từ vựng",
            ClassesDisplay = "COM-B01",
            ClassList = new List<string> { "COM-B01" },
            Type = "Thường xuyên (TX)",
            Date = "05/09/2026",
            Weight = "20%",
            GradedRatio = "12/12",
            Status = "✓ Đã có điểm"
        });

        dgvAssessments.DataSource = null;
        dgvAssessments.DataSource = _items;
    }

    private void WireEvents()
    {
        btnEnterGradesTop.Click += (s, e) =>
        {
            var selectedClass = cboClassFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClass) || selectedClass == "Tất cả lớp")
            {
                selectedClass = "IELTS-F01";
            }
            using var dlg = new GradeEntryDialog(selectedClass);
            dlg.ShowDialog(ParentForm);
        };

        btnCreateAssessmentTop.Click += (s, e) =>
        {
            var selectedClass = cboClassFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClass) || selectedClass == "Tất cả lớp")
            {
                selectedClass = "IELTS-F01";
            }

            using var dlg = new CreateAssessmentDialog(selectedClass);
            if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                var assignedClasses = dlg.SelectedClasses.Count > 0 ? dlg.SelectedClasses : new List<string> { selectedClass };
                var newItem = new AssessmentItem
                {
                    Stt = _items.Count + 1,
                    Title = dlg.AssessmentName,
                    ClassList = assignedClasses,
                    ClassesDisplay = string.Join(", ", assignedClasses),
                    Type = dlg.AssessmentType,
                    Date = dlg.ExamDate,
                    Weight = dlg.Weight,
                    GradedRatio = "0/" + (assignedClasses.Count * 18),
                    Status = "⏳ Chờ nhập điểm"
                };

                _items.Add(newItem);
                ApplyFilter();

                AppDialog.ShowSuccess(ParentForm, "Tạo bài kiểm tra",
                    $"Đã tạo thành công bài kiểm tra '{newItem.Title}' cho {assignedClasses.Count} lớp:\n" +
                    $"{newItem.ClassesDisplay}.\n\n" +
                    "Bạn có thể ấn 'Nhập điểm' trên bảng để ghi nhận điểm số học viên.");
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
            (selectedClass == "Tất cả lớp" || i.ClassList.Contains(selectedClass) || i.ClassesDisplay.Contains(selectedClass)) &&
            (selectedType == "Tất cả loại bài thi" || i.Type.Contains(selectedType.Replace("Tất cả loại bài thi", "")) || selectedType.Contains(i.Type))
        ).ToList();

        dgvAssessments.DataSource = null;
        dgvAssessments.DataSource = filtered;
    }
}
