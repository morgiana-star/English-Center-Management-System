using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class TuitionDetailDialog : Form
{
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

    public TuitionDetailDialog() : this("HV-0241", "Nguyễn Minh Anh", "IELTS-F01", "IELTS Foundation", 6000000, 600000, 5400000, 2000000, 3400000, "Đang nợ (Đợt 2)")
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
        LoadInstallments();
        WireEvents();
    }

    private void SetupView()
    {
        lblTitle.Text = $"Chi tiết học phí · {_studentName} ({_studentCode})";
        lblStudentVal.Text = $"{_studentName}  ·  Mã HV: {_studentCode}";
        lblClassVal.Text = $"{_courseName} · Lớp {_className}";
        lblOriginalVal.Text = $"{_originalFee:N0} đ";
        lblDiscountVal.Text = _discount > 0 ? $"-{_discount:N0} đ (Khuyến mãi/Học bổng)" : "0 đ";
        lblTotalVal.Text = $"{_totalFee:N0} đ";
        lblPaidVal.Text = $"{_paid:N0} đ";
        lblRemainingVal.Text = $"{_remaining:N0} đ";

        if (_remaining <= 0)
        {
            lblRemainingVal.ForeColor = Color.FromArgb(22, 163, 74);
            btnCollectNow.Enabled = false;
            btnCollectNow.Text = "✓ Đã tất toán";
            btnCollectNow.BackColor = Color.FromArgb(241, 245, 249);
            btnCollectNow.ForeColor = Color.FromArgb(148, 163, 184);
        }
        else
        {
            lblRemainingVal.ForeColor = Color.FromArgb(220, 38, 38);
            btnCollectNow.Enabled = true;
            btnCollectNow.Text = "💵 Thu học phí";
        }
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
            Width = 90
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAmount",
            HeaderText = "Số tiền",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colDueDate",
            HeaderText = "Hạn nộp",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colPaidDate",
            HeaderText = "Ngày đóng",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colReceipt",
            HeaderText = "Mã phiếu thu",
            Width = 130,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Consolas", 9f, FontStyle.Bold), ForeColor = Color.FromArgb(37, 99, 235) }
        });

        dgvInstallments.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStatus",
            HeaderText = "Trạng thái",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvInstallments.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvInstallments.Rows.Count) return;

            string colName = dgvInstallments.Columns[e.ColumnIndex].Name;
            var val = e.Value?.ToString() ?? "";

            if (colName == "colStatus")
            {
                if (val.Contains("✓"))
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

    private void LoadInstallments()
    {
        dgvInstallments.Rows.Clear();

        if (_paid > 0)
        {
            dgvInstallments.Rows.Add(
                "Đợt 1",
                $"{_paid:N0} đ",
                "01/10/2026",
                "02/10/2026",
                "PT-261002-006",
                "✓ Đã thanh toán"
            );
        }

        if (_remaining > 0)
        {
            dgvInstallments.Rows.Add(
                _paid > 0 ? "Đợt 2" : "Toàn phần",
                $"{_remaining:N0} đ",
                "15/11/2026",
                "--",
                "Chưa lập phiếu",
                "⚠️ Quá hạn thanh toán"
            );
        }
    }

    private void WireEvents()
    {
        
        btnCancel.Click += (s, e) => Close();

        btnCollectNow.Click += (s, e) =>
        {
            if (_remaining <= 0) return;

            using var dlg = new CollectTuitionDialog(_studentName, _className, _remaining);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        };
    }
}
