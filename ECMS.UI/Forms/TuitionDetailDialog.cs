using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;

namespace ECMS.UI.Forms;

public partial class TuitionDetailDialog : Form
{
    private readonly IFinanceService _financeService = new FinanceService();
    private readonly string _studentCode = string.Empty;
    private readonly string _studentName = string.Empty;
    private readonly string _className = string.Empty;
    private readonly string _courseName = string.Empty;
    private readonly decimal _originalFee;
    private readonly decimal _discount;
    private readonly decimal _totalFee;
    private readonly decimal _paid;
    private readonly decimal _remaining;
    private readonly string _status = string.Empty;

    public TuitionDetailDialog() : this("HV-0241", "Nguyễn Minh Anh", "IELTS-F01", "IELTS Foundation", 6000000, 600000, 5400000, 2000000, 3400000, "Đang nợ")
    {
    }

    public TuitionDetailDialog(
        string studentCode,
        string studentName,
        string className,
        string courseName,
        decimal originalFee,
        decimal discount,
        decimal totalFee,
        decimal paid,
        decimal remaining,
        string status)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _studentCode = studentCode;
        _studentName = studentName;
        _className = className;
        _courseName = courseName;
        _originalFee = originalFee;
        _discount = discount;
        _totalFee = totalFee;
        _paid = paid;
        _remaining = remaining;
        _status = status;

        SetupView();
        SetupGrid();
        WireEvents();
        _ = LoadInstallmentsFromDbAsync();
    }

    private void SetupView()
    {
        lblTitle.Text = $"Chi tiết học phí - {_studentName} ({_studentCode})";
        lblStudentVal.Text = $"{_studentName}  |  Mã HV: {_studentCode}";
        lblClassVal.Text = $"Lớp {_className}";
        lblOriginalVal.Text = $"{_originalFee:N0} đ";
        lblDiscountVal.Text = _discount > 0 ? $"-{_discount:N0} đ" : "0 đ";
        lblTotalVal.Text = $"{_totalFee:N0} đ";
        lblPaidVal.Text = $"{_paid:N0} đ";
        lblRemainingVal.Text = $"{_remaining:N0} đ";
        lblRemainingVal.ForeColor = _remaining <= 0
            ? Color.FromArgb(22, 163, 74)
            : Color.FromArgb(220, 38, 38);

        // Bỏ nút Thu học phí và nút Đóng ở đáy trong hộp thoại Xem chi tiết (đóng bằng nút X góc trên)
        btnCollectNow.Visible = false;
        btnCancel.Visible = false;
        pnlFooter.Visible = false;
    }

    private void SetupGrid()
    {
        dgvInstallments.AutoGenerateColumns = false;
        dgvInstallments.Columns.Clear();
        dgvInstallments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvInstallments.MultiSelect = false;
        dgvInstallments.ReadOnly = true;
        dgvInstallments.RowHeadersVisible = false;
        dgvInstallments.AllowUserToAddRows = false;
        dgvInstallments.AllowUserToDeleteRows = false;

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colBatch",
            HeaderText = "Đợt thu",
            FillWeight = 14
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAmount",
            HeaderText = "Số tiền",
            FillWeight = 18,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMethod",
            HeaderText = "Phương thức",
            FillWeight = 16,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colPaidDate",
            HeaderText = "Ngày đóng",
            FillWeight = 15,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colReceipt",
            HeaderText = "Mã phiếu thu",
            FillWeight = 19,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Consolas", 9f, FontStyle.Bold), ForeColor = Color.FromArgb(37, 99, 235) }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStatus",
            HeaderText = "Trạng thái",
            FillWeight = 18,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvInstallments.Rows.Count) return;

            string colName = dgvInstallments.Columns[e.ColumnIndex].Name;
            var val = e.Value?.ToString() ?? "";

            if (colName == "colStatus")
            {
                if (val.Contains("Đã thanh toán"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        };
    }

    private async Task LoadInstallmentsFromDbAsync()
    {
        dgvInstallments.Rows.Clear();

        try
        {
            var receipts = (await _financeService.GetPaymentReceiptsAsync(_studentCode))
                .Where(r => r.StudentCode.Equals(_studentCode, StringComparison.OrdinalIgnoreCase))
                .Reverse()
                .ToList();

            int batch = 1;
            foreach (var r in receipts)
            {
                dgvInstallments.Rows.Add(
                    $"Đợt {batch++}",
                    $"{r.Amount:N0} đ",
                    r.Method,
                    r.Date,
                    r.ReceiptCode,
                    "Đã thanh toán"
                );
            }

            if (_remaining > 0)
            {
                dgvInstallments.Rows.Add(
                    batch > 1 ? $"Đợt {batch} (Còn lại)" : "Toàn phần",
                    $"{_remaining:N0} đ",
                    "-",
                    "-",
                    "Chưa lập phiếu",
                    "Chưa thanh toán"
                );
            }
        }
        catch
        {
            if (_remaining > 0)
            {
                dgvInstallments.Rows.Add("Còn lại", $"{_remaining:N0} đ", "-", "-", "Chưa lập phiếu", "Chưa thanh toán");
            }
        }

        dgvInstallments.ClearSelection();
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();
    }
}
