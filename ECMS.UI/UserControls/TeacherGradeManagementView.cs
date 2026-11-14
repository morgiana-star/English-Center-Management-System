using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class TeacherGradeManagementView : UserControl
{
    private class AssessmentItem
    {
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
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

    private void SetupFilters()
    {
        cboClassFilter.Items.Clear();
        cboClassFilter.Items.AddRange(new object[]
        {
            "IELTS-F02",
            "IELTS-F01",
            "TOEIC-T01"
        });
        cboClassFilter.SelectedIndex = 0;

        cboTypeFilter.Items.Clear();
        cboTypeFilter.Items.AddRange(new object[]
        {
            "Tất cả loại",
            "Đầu vào",
            "Thường xuyên",
            "Giữa khóa",
            "Cuối khóa"
        });
        cboTypeFilter.SelectedIndex = 0;

        cboAssignedClass.Items.Clear();
        cboAssignedClass.Items.AddRange(new object[]
        {
            "IELTS-F02",
            "IELTS-F01",
            "TOEIC-T01"
        });
        cboAssignedClass.SelectedIndex = 0;

        cboAssessmentType.Items.Clear();
        cboAssessmentType.Items.AddRange(new object[]
        {
            "Cuối khóa",
            "Giữa khóa",
            "Thường xuyên",
            "Đầu vào"
        });
        cboAssessmentType.SelectedIndex = 0;

        dtpExamDate.Value = new DateTime(2026, 10, 23);
        txtScale.Text = "10";
        txtWeight.Text = "50%";
        txtAssessmentName.Text = "Kiểm tra cuối khóa";
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

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Title",
            HeaderText = "Tên bài ↑",
            Width = 190
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Type",
            HeaderText = "Loại",
            Width = 110
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Date",
            HeaderText = "Ngày",
            Width = 100
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Weight",
            HeaderText = "Trọng số",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvAssessments.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 120
        });

        dgvAssessments.CellFormatting += (s, e) =>
        {
            if (dgvAssessments.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                var val = e.Value.ToString() ?? "";
                if (val.Contains("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
                }
            }
        };
    }

    private void LoadSampleData()
    {
        _items.Clear();
        _items.Add(new AssessmentItem { Title = "Xếp lớp đầu vào", Type = "Đầu vào", Date = "31/07/2026", Weight = "0%", Status = "✓ Đã có điểm" });
        _items.Add(new AssessmentItem { Title = "Bài luyện tổng hợp", Type = "Thường xuyên", Date = "28/08/2026", Weight = "20%", Status = "✓ Đã có điểm" });
        _items.Add(new AssessmentItem { Title = "Kiểm tra giữa khóa", Type = "Giữa khóa", Date = "14/09/2026", Weight = "30%", Status = "✓ Đã có điểm" });
        _items.Add(new AssessmentItem { Title = "Kiểm tra cuối khóa", Type = "Cuối khóa", Date = "23/10/2026", Weight = "50%", Status = "Chờ hoàn tất" });

        dgvAssessments.DataSource = null;
        dgvAssessments.DataSource = _items;
    }

    private void WireEvents()
    {
        btnEnterGradesTop.Click += (s, e) =>
        {
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherGradeEntryView());
            }
        };

        dgvAssessments.CellDoubleClick += (s, e) =>
        {
            if (ParentForm is Forms.MainForm main)
            {
                main.LoadView(new TeacherGradeEntryView());
            }
        };

        btnCreateAssessmentTop.Click += (s, e) =>
        {
            txtAssessmentName.Text = string.Empty;
            cboAssessmentType.SelectedIndex = 2; // Thường xuyên
            txtWeight.Text = "20%";
            dtpExamDate.Value = DateTime.Today;
            txtAssessmentName.Focus();
        };

        btnSaveAssessment.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtAssessmentName.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tên bài kiểm tra.");
                txtAssessmentName.Focus();
                return;
            }

            var newItem = new AssessmentItem
            {
                Title = txtAssessmentName.Text.Trim(),
                Type = cboAssessmentType.SelectedItem?.ToString() ?? "Thường xuyên",
                Date = dtpExamDate.Value.ToString("dd/MM/yyyy"),
                Weight = txtWeight.Text.Trim(),
                Status = "Chờ hoàn tất"
            };

            _items.Add(newItem);
            dgvAssessments.DataSource = null;
            dgvAssessments.DataSource = _items;

            AppDialog.ShowSuccess(ParentForm, "Tạo bài kiểm tra",
                $"Đã tạo bài kiểm tra '{newItem.Title}' cho lớp {cboAssignedClass.SelectedItem}.\n" +
                "Bạn có thể bấm 'Nhập điểm' để bắt đầu ghi nhận điểm số học viên.");
        };
    }
}
