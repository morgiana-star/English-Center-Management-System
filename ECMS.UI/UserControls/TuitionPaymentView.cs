using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TuitionPaymentView : UserControl
{
    public TuitionPaymentView()
    {
        InitializeComponent();
        SetupEvents();
        LoadSampleData();
    }

    private void SetupEvents()
    {
        btnCollectTuition.Click += (s, e) => OpenCollectTuitionDialog("Nguyễn Minh Anh", "IELTS-F01", 3400000);
        btnExportDebt.Click += (s, e) => MessageBox.Show("Đã xuất danh sách công nợ ra tệp Excel/CSV cục bộ.", "Xuất công nợ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        gridDebtors.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index)
            {
                var row = gridDebtors.Rows[e.RowIndex];
                string student = row.Cells[0].Value?.ToString() ?? "Học viên";
                string className = row.Cells[1].Value?.ToString() ?? "Lớp học";
                OpenCollectTuitionDialog(student, className, 3400000);
            }
        };

        gridDebtors.SelectionChanged += (s, e) =>
        {
            if (gridDebtors.SelectedRows.Count > 0)
            {
                var row = gridDebtors.SelectedRows[0];
                string student = row.Cells[0].Value?.ToString() ?? "Nguyễn Minh Anh";
                string className = row.Cells[1].Value?.ToString() ?? "IELTS-F01";
                lblHistoryCardTitle.Text = $"Lịch sử · {student} / {className}";
            }
        };
    }

    private void OpenCollectTuitionDialog(string student, string className, decimal remainingDebt)
    {
        using var dialog = new CollectTuitionDialog(student, className, remainingDebt);
        dialog.ShowDialog(this.FindForm());
    }

    private void LoadSampleData()
    {
        cboDebtFilter.SelectedIndex = 0;
        cboDueDateFilter.SelectedIndex = 0;

        gridDebtors.Rows.Clear();
        gridDebtors.Rows.Add("Nguyễn Minh Anh", "IELTS-F01", "5.400.000đ", "2.000.000đ", "3.400.000đ", "15/11/2026", "Thu tiền");
        gridDebtors.Rows.Add("Phạm Khánh Linh", "IELTS-F01", "6.000.000đ", "3.600.000đ", "2.400.000đ", "31/10/2026", "Thu tiền");
        gridDebtors.Rows.Add("Đỗ Thanh Tâm", "COM-B01", "3.200.000đ", "0đ", "3.200.000đ", "02/11/2026", "Thu tiền");

        gridHistory.Rows.Clear();
        gridHistory.Rows.Add("02/10/2026", "GD-261002-006", "PT-261002-006", "2.000.000đ", "Tiền mặt", "Lê Phương Thảo");
    }
}
