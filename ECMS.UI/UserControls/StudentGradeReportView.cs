using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class StudentGradeReportView : UserControl
{
    private class StudentAssessmentScore
    {
        public string AssessmentName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string ScoreText { get; set; } = string.Empty;
        public string WeightText { get; set; } = string.Empty;
    }

    private readonly List<StudentAssessmentScore> _scores = new();

    public StudentGradeReportView()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupGrid();
        LoadSampleData();
    }

    private void SetupGrid()
    {
        dgvResults.AutoGenerateColumns = false;
        dgvResults.Columns.Clear();
        dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvResults.MultiSelect = false;
        dgvResults.ReadOnly = true;
        dgvResults.RowHeadersVisible = false;
        dgvResults.AllowUserToAddRows = false;

        dgvResults.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "AssessmentName",
            HeaderText = "Bài đánh giá ↑",
            Width = 190
        });

        dgvResults.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Date",
            HeaderText = "Ngày",
            Width = 120
        });

        dgvResults.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ScoreText",
            HeaderText = "Điểm / 10",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold)
            }
        });

        dgvResults.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "WeightText",
            HeaderText = "Trọng số",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    private void LoadSampleData()
    {
        _scores.Clear();
        _scores.Add(new StudentAssessmentScore { AssessmentName = "Đầu vào", Date = "31/07/2026", ScoreText = "4,5", WeightText = "Không tính" });
        _scores.Add(new StudentAssessmentScore { AssessmentName = "Thường xuyên", Date = "28/08/2026", ScoreText = "7,0", WeightText = "20%" });
        _scores.Add(new StudentAssessmentScore { AssessmentName = "Giữa khóa", Date = "14/09/2026", ScoreText = "7,5", WeightText = "30%" });
        _scores.Add(new StudentAssessmentScore { AssessmentName = "Cuối khóa", Date = "23/10/2026", ScoreText = "8,0", WeightText = "50%" });

        dgvResults.DataSource = null;
        dgvResults.DataSource = _scores;

        // Biểu đồ tiến độ
        chartProgress.Items = new List<BarItem>
        {
            new("Đầu vào", 4.5, "4.5"),
            new("TX", 7.0, "7"),
            new("Giữa khóa", 7.5, "7.5"),
            new("Cuối khóa", 8.0, "8", isHighlight: true)
        };
    }
}
