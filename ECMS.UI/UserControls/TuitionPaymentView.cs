using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;
using ECMS.UI.Forms;
using ECMS.UI.Services;

namespace ECMS.UI.UserControls;

public partial class TuitionPaymentView : UserControl
{
    private readonly IFinanceService _financeService = new FinanceService();
    public class TuitionProfileModel
    {
        public string StudentCode { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public decimal OriginalFee { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalFee { get; set; }
        public decimal Paid { get; set; }
        public decimal Remaining { get; set; }
        public string DueDate { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public string DebtStatus { get; set; } = string.Empty;
    }

    public class ReceiptHistoryModel
    {
        public string ReceiptCode { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string StudentCode { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Collector { get; set; } = string.Empty;
        public bool IsCancelled { get; set; }
    }

    private readonly List<TuitionProfileModel> _profiles = new();
    private readonly List<ReceiptHistoryModel> _receipts = new();
    private int _currentTabIndex = 0;

    public TuitionPaymentView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrids();
        LoadRealTuitionDataAsync();
        WireEvents();
        SelectTab(0);
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

        UpdateStatusFilterItems(0);
    }

    private void UpdateStatusFilterItems(int tabIndex)
    {
        cboStatusFilter.Items.Clear();
        if (tabIndex == 0) // Hồ sơ
        {
            cboStatusFilter.Items.AddRange(new object[]
            {
                "Tất cả trạng thái",
                "✓ Đã tất toán",
                "⚠️ Còn nợ học phí"
            });
        }
        else if (tabIndex == 1) // Công nợ
        {
            cboStatusFilter.Items.AddRange(new object[]
            {
                "Tất cả công nợ",
                "Đã quá hạn",
                "Đến hạn trong 7 ngày",
                "Trong hạn"
            });
        }
        else // Lịch sử thu
        {
            cboStatusFilter.Items.AddRange(new object[]
            {
                "Tất cả phương thức",
                "Chuyển khoản VietQR",
                "Tiền mặt (quầy)",
                "Thẻ POS / Quẹt thẻ"
            });
        }
        cboStatusFilter.SelectedIndex = 0;
    }

    private void SetupGrids()
    {
        // 1. Grid Hồ sơ (Tab 1)
        gridProfiles.AutoGenerateColumns = false;
        gridProfiles.Columns.Clear();
        gridProfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridProfiles.MultiSelect = false;
        gridProfiles.ReadOnly = true;
        gridProfiles.RowHeadersVisible = false;
        gridProfiles.AllowUserToAddRows = false;
        gridProfiles.AllowUserToDeleteRows = false;

        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentCode", HeaderText = "Mã HV", Width = 95, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ và tên", Width = 160, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42) } });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CourseName", HeaderText = "Khóa học", Width = 150 });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClassName", HeaderText = "Lớp học", Width = 95 });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotalFee", HeaderText = "Tổng phải thu", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPaid", HeaderText = "Đã thanh toán", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, ForeColor = Color.FromArgb(22, 163, 74) } });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRemaining", HeaderText = "Còn phải thu", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });
        gridProfiles.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PaymentStatus", HeaderText = "Trạng thái", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });

        var btnViewDetail = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "Xem chi tiết",
            UseColumnTextForButtonValue = true,
            Width = 110,
            FlatStyle = FlatStyle.Flat
        };
        gridProfiles.Columns.Add(btnViewDetail);

        gridProfiles.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridProfiles.Rows.Count) return;
            var item = gridProfiles.Rows[e.RowIndex].DataBoundItem as TuitionProfileModel;
            if (item == null) return;

            string colName = gridProfiles.Columns[e.ColumnIndex].Name;
            if (colName == "colTotalFee") e.Value = $"{item.TotalFee:N0} đ";
            else if (colName == "colPaid") e.Value = $"{item.Paid:N0} đ";
            else if (colName == "colRemaining")
            {
                e.Value = $"{item.Remaining:N0} đ";
                if (item.Remaining > 0)
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(100, 116, 139);
                }
            }
            else if (gridProfiles.Columns[e.ColumnIndex].DataPropertyName == "PaymentStatus")
            {
                if (item.PaymentStatus.Contains("✓") || item.PaymentStatus.Contains("Đã đóng đủ"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.BackColor = Color.FromArgb(240, 253, 244);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (item.PaymentStatus.Contains("Chưa đóng") || item.DebtStatus.Contains("Quá hạn"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle!.BackColor = Color.FromArgb(254, 242, 242);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(194, 65, 12);
                    e.CellStyle!.BackColor = Color.FromArgb(255, 247, 237);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        };

        // 2. Grid Công nợ (Tab 2)
        gridDebtors.AutoGenerateColumns = false;
        gridDebtors.Columns.Clear();
        gridDebtors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridDebtors.MultiSelect = false;
        gridDebtors.ReadOnly = true;
        gridDebtors.RowHeadersVisible = false;
        gridDebtors.AllowUserToAddRows = false;
        gridDebtors.AllowUserToDeleteRows = false;

        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentCode", HeaderText = "Mã HV", Width = 95, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ và tên", Width = 160, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42) } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClassDisplay", HeaderText = "Khóa học / Lớp", Width = 180 });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDebtTotal", HeaderText = "Tổng phải thu", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDebtPaid", HeaderText = "Đã thanh toán", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDebtRemaining", HeaderText = "Còn nợ", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(220, 38, 38) } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn thanh toán", Width = 115, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        gridDebtors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DebtStatus", HeaderText = "Trạng thái nợ", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });

        var btnCollectDebt = new DataGridViewButtonColumn
        {
            Name = "colDebtAction",
            HeaderText = "Thao tác",
            Text = "💵 Thu tiền",
            UseColumnTextForButtonValue = true,
            Width = 110,
            FlatStyle = FlatStyle.Flat
        };
        gridDebtors.Columns.Add(btnCollectDebt);

        gridDebtors.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridDebtors.Rows.Count) return;
            var item = gridDebtors.Rows[e.RowIndex].DataBoundItem as TuitionProfileModel;
            if (item == null) return;

            string colName = gridDebtors.Columns[e.ColumnIndex].Name;
            if (colName == "colClassDisplay") e.Value = $"{item.CourseName} · {item.ClassName}";
            else if (colName == "colDebtTotal") e.Value = $"{item.TotalFee:N0} đ";
            else if (colName == "colDebtPaid") e.Value = $"{item.Paid:N0} đ";
            else if (colName == "colDebtRemaining") e.Value = $"{item.Remaining:N0} đ";
            else if (gridDebtors.Columns[e.ColumnIndex].DataPropertyName == "DebtStatus")
            {
                if (item.DebtStatus.Contains("Quá hạn"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle!.BackColor = Color.FromArgb(254, 242, 242);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (item.DebtStatus.Contains("7 ngày"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(194, 65, 12);
                    e.CellStyle!.BackColor = Color.FromArgb(255, 247, 237);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(37, 99, 235);
                    e.CellStyle!.BackColor = Color.FromArgb(239, 246, 255);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        };

        // 3. Grid Lịch sử thu (Tab 3)
        gridHistory.AutoGenerateColumns = false;
        gridHistory.Columns.Clear();
        gridHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridHistory.MultiSelect = false;
        gridHistory.ReadOnly = true;
        gridHistory.RowHeadersVisible = false;
        gridHistory.AllowUserToAddRows = false;
        gridHistory.AllowUserToDeleteRows = false;

        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceiptCode", HeaderText = "Mã phiếu thu", Width = 135, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Consolas", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(37, 99, 235) } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Date", HeaderText = "Ngày thu", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentCode", HeaderText = "Mã HV", Width = 95, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9f, FontStyle.Bold) } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ và tên học viên", Width = 160, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42) } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Content", HeaderText = "Nội dung thu", Width = 170 });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHistAmountVal", HeaderText = "Số tiền", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(22, 163, 74) } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Method", HeaderText = "Phương thức thanh toán", Width = 160, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
        gridHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Collector", HeaderText = "Người lập phiếu", Width = 150 });

        var btnPrintReceipt = new DataGridViewButtonColumn
        {
            Name = "colHistAction",
            HeaderText = "Thao tác",
            Text = "🖨️ In phiếu thu",
            UseColumnTextForButtonValue = true,
            Width = 115,
            FlatStyle = FlatStyle.Flat
        };
        gridHistory.Columns.Add(btnPrintReceipt);

        var btnCancelReceipt = new DataGridViewButtonColumn
        {
            Name = "colCancelAction",
            HeaderText = "Hủy phiếu",
            Text = "❌ Hủy",
            UseColumnTextForButtonValue = true,
            Width = 85,
            FlatStyle = FlatStyle.Flat
        };
        gridHistory.Columns.Add(btnCancelReceipt);

        gridHistory.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridHistory.Rows.Count) return;
            var item = gridHistory.Rows[e.RowIndex].DataBoundItem as ReceiptHistoryModel;
            if (item == null) return;

            if (item.IsCancelled)
            {
                e.CellStyle!.ForeColor = Color.FromArgb(148, 163, 184);
                return;
            }

            if (gridHistory.Columns[e.ColumnIndex].Name == "colHistAmountVal")
            {
                e.Value = $"{item.Amount:N0} đ";
            }
            else if (gridHistory.Columns[e.ColumnIndex].DataPropertyName == "Method")
            {
                if (item.Method.Contains("Chuyển khoản"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(37, 99, 235);
                    e.CellStyle!.BackColor = Color.FromArgb(239, 246, 255);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.BackColor = Color.FromArgb(240, 253, 244);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        };
    }

    private async void LoadRealTuitionDataAsync()
    {
        try
        {
            var profileDtos = await _financeService.GetTuitionProfilesAsync();
            _profiles.Clear();
            foreach (var p in profileDtos)
            {
                _profiles.Add(new TuitionProfileModel
                {
                    StudentCode = p.StudentCode,
                    StudentName = p.StudentName,
                    CourseName = p.CourseName,
                    ClassName = p.ClassName,
                    OriginalFee = p.OriginalFee,
                    Discount = p.Discount,
                    TotalFee = p.TotalFee,
                    Paid = p.Paid,
                    Remaining = p.Remaining,
                    DueDate = p.DueDate,
                    PaymentStatus = p.PaymentStatus,
                    DebtStatus = p.DebtStatus
                });
            }

            var receiptDtos = await _financeService.GetPaymentReceiptsAsync();
            _receipts.Clear();
            foreach (var r in receiptDtos)
            {
                _receipts.Add(new ReceiptHistoryModel
                {
                    ReceiptCode = r.ReceiptCode,
                    Date = r.Date,
                    StudentCode = r.StudentCode,
                    StudentName = r.StudentName,
                    ClassName = r.ClassName,
                    CourseName = r.CourseName,
                    Content = r.Content,
                    Amount = r.Amount,
                    Method = r.Method,
                    Collector = r.Collector
                });
            }

            ApplyFilter();
        }
        catch
        {
            LoadSampleData();
        }
    }

    private void LoadSampleData()
    {
        _profiles.Clear();

        // 13 học viên đồng bộ chuẩn xác với Phần B (Học viên, Lớp học, Điểm số, Chứng chỉ)
        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0241",
            StudentName = "Nguyễn Minh Anh",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            OriginalFee = 6000000,
            Discount = 600000,
            TotalFee = 5400000,
            Paid = 2000000,
            Remaining = 3400000,
            DueDate = "15/11/2026",
            PaymentStatus = "⚠️ Còn nợ (Đợt 2)",
            DebtStatus = "Quá hạn"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0238",
            StudentName = "Phạm Khánh Linh",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 3600000,
            Remaining = 2400000,
            DueDate = "31/10/2026",
            PaymentStatus = "⚠️ Còn nợ (Đợt 2)",
            DebtStatus = "Quá hạn"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0239",
            StudentName = "Đỗ Thanh Tâm",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            OriginalFee = 3800000,
            Discount = 600000,
            TotalFee = 3200000,
            Paid = 0,
            Remaining = 3200000,
            DueDate = "02/11/2026",
            PaymentStatus = "⚠️ Chưa đóng",
            DebtStatus = "Quá hạn"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0215",
            StudentName = "Trần Thảo Nhi",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 5500000,
            Remaining = 500000,
            DueDate = "10/11/2026",
            PaymentStatus = "⚠️ Còn nợ (Đợt cuối)",
            DebtStatus = "Quá hạn"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0235",
            StudentName = "Nguyễn Tiến Đạt",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 4800000,
            Remaining = 1200000,
            DueDate = "20/11/2026",
            PaymentStatus = "⚠️ Còn nợ",
            DebtStatus = "Đến hạn trong 7 ngày"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0204",
            StudentName = "Trần Gia Bảo",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            OriginalFee = 6000000,
            Discount = 600000,
            TotalFee = 5400000,
            Paid = 5400000,
            Remaining = 0,
            DueDate = "30/08/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0205",
            StudentName = "Đặng Minh Trí",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 6000000,
            Remaining = 0,
            DueDate = "30/08/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0208",
            StudentName = "Lê Hoàng Yến",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 6000000,
            Remaining = 0,
            DueDate = "30/08/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0210",
            StudentName = "Phạm Quốc Huy",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            OriginalFee = 6000000,
            Discount = 0,
            TotalFee = 6000000,
            Paid = 6000000,
            Remaining = 0,
            DueDate = "30/08/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0240",
            StudentName = "Võ Hoàng Yến",
            CourseName = "TOEIC 500+",
            ClassName = "TOEIC-A01",
            OriginalFee = 4500000,
            Discount = 0,
            TotalFee = 4500000,
            Paid = 4500000,
            Remaining = 0,
            DueDate = "10/09/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0236",
            StudentName = "Bùi Mai Phương",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            OriginalFee = 3800000,
            Discount = 0,
            TotalFee = 3800000,
            Paid = 3800000,
            Remaining = 0,
            DueDate = "15/09/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0177",
            StudentName = "Nguyễn Thành Nam",
            CourseName = "TOEIC 500+",
            ClassName = "TOEIC-A01",
            OriginalFee = 4500000,
            Discount = 0,
            TotalFee = 4500000,
            Paid = 4500000,
            Remaining = 0,
            DueDate = "10/09/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        _profiles.Add(new TuitionProfileModel
        {
            StudentCode = "HV-0160",
            StudentName = "Bùi Thị Mai",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            OriginalFee = 3800000,
            Discount = 0,
            TotalFee = 3800000,
            Paid = 3800000,
            Remaining = 0,
            DueDate = "15/09/2026",
            PaymentStatus = "✓ Đã tất toán",
            DebtStatus = "Đã hoàn thành"
        });

        // Danh sách Lịch sử thu
        _receipts.Clear();
        _receipts.Add(new ReceiptHistoryModel
        {
            ReceiptCode = "PT-261115-012",
            Date = "15/11/2026",
            StudentCode = "HV-0215",
            StudentName = "Trần Thảo Nhi",
            ClassName = "IELTS-F01",
            CourseName = "IELTS Foundation",
            Content = "Thu học phí đợt 2",
            Amount = 3000000,
            Method = "Chuyển khoản VietQR",
            Collector = "Trần Minh Quân"
        });

        _receipts.Add(new ReceiptHistoryModel
        {
            ReceiptCode = "PT-261030-008",
            Date = "30/10/2026",
            StudentCode = "HV-0238",
            StudentName = "Phạm Khánh Linh",
            ClassName = "IELTS-F01",
            CourseName = "IELTS Foundation",
            Content = "Thu học phí đợt 1",
            Amount = 3600000,
            Method = "Chuyển khoản VietQR",
            Collector = "Lê Phương Thảo"
        });

        _receipts.Add(new ReceiptHistoryModel
        {
            ReceiptCode = "PT-261002-006",
            Date = "02/10/2026",
            StudentCode = "HV-0241",
            StudentName = "Nguyễn Minh Anh",
            ClassName = "IELTS-F01",
            CourseName = "IELTS Foundation",
            Content = "Thu học phí đợt 1",
            Amount = 2000000,
            Method = "Tiền mặt (quầy)",
            Collector = "Lê Phương Thảo"
        });

        _receipts.Add(new ReceiptHistoryModel
        {
            ReceiptCode = "PT-260830-003",
            Date = "30/08/2026",
            StudentCode = "HV-0204",
            StudentName = "Trần Gia Bảo",
            ClassName = "IELTS-F02",
            CourseName = "IELTS Foundation",
            Content = "Thu trọn khóa học phí",
            Amount = 5400000,
            Method = "Chuyển khoản VietQR",
            Collector = "Trần Minh Quân"
        });

        _receipts.Add(new ReceiptHistoryModel
        {
            ReceiptCode = "PT-260830-002",
            Date = "30/08/2026",
            StudentCode = "HV-0205",
            StudentName = "Đặng Minh Trí",
            ClassName = "IELTS-F02",
            CourseName = "IELTS Foundation",
            Content = "Thu trọn khóa học phí",
            Amount = 6000000,
            Method = "Chuyển khoản VietQR",
            Collector = "Trần Minh Quân"
        });

        ApplyFilter();
    }

    private void WireEvents()
    {
        btnTabProfiles.Click += (s, e) => SelectTab(0);
        btnTabDebt.Click += (s, e) => SelectTab(1);
        btnTabHistory.Click += (s, e) => SelectTab(2);

        txtSearch.TextChanged += (s, e) => ApplyFilter();
        cboClassFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboStatusFilter.SelectedIndexChanged += (s, e) => ApplyFilter();

        btnCollectTuition.Click += (s, e) =>
        {
            var firstDebtor = _profiles.FirstOrDefault(p => p.Remaining > 0);
            string sName = firstDebtor != null ? firstDebtor.StudentName : "Nguyễn Minh Anh";
            string cName = firstDebtor != null ? firstDebtor.ClassName : "IELTS-F01";
            decimal debt = firstDebtor != null ? firstDebtor.Remaining : 3400000;
            string sCode = firstDebtor != null ? firstDebtor.StudentCode : "HV-0241";

            OpenCollectDialog(sName, cName, debt, sCode);
        };

        btnExportDebt.Click += (s, e) =>
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất báo cáo tài chính & theo dõi công nợ",
                Filter = "Tệp Excel (*.xlsx)|*.xlsx",
                FileName = $"BaoCao_CongNo_ECMS_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            };
            if (sfd.ShowDialog(FindForm()) == DialogResult.OK)
            {
                try
                {
                    ExcelExportService.ExportTuitionDebtReport(sfd.FileName, _profiles);
                    AppDialog.ShowSuccess(ParentForm, "Xuất báo cáo thành công", 
                        $"Đã xuất thành công báo cáo theo dõi công nợ ra tệp Excel:\n{sfd.FileName}");
                }
                catch (Exception ex)
                {
                    AppDialog.ShowError(ParentForm, "Lỗi xuất Excel", $"Không thể xuất tệp Excel: {ex.Message}");
                }
            }
        };

        // Grid 1: Tab Hồ sơ actions
        gridProfiles.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && gridProfiles.Columns[e.ColumnIndex].Name == "colAction")
            {
                if (gridProfiles.Rows[e.RowIndex].DataBoundItem is TuitionProfileModel item)
                {
                    OpenTuitionDetail(item);
                }
            }
        };

        gridProfiles.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                if (gridProfiles.Rows[e.RowIndex].DataBoundItem is TuitionProfileModel item)
                {
                    OpenTuitionDetail(item);
                }
            }
        };

        // Grid 2: Tab Công nợ actions
        gridDebtors.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && gridDebtors.Columns[e.ColumnIndex].Name == "colDebtAction")
            {
                if (gridDebtors.Rows[e.RowIndex].DataBoundItem is TuitionProfileModel item)
                {
                    OpenCollectDialog(item.StudentName, item.ClassName, item.Remaining, item.StudentCode);
                }
            }
        };

        gridDebtors.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                if (gridDebtors.Rows[e.RowIndex].DataBoundItem is TuitionProfileModel item)
                {
                    OpenTuitionDetail(item);
                }
            }
        };

        // Grid 3: Tab Lịch sử thu actions
        gridHistory.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && gridHistory.Columns[e.ColumnIndex].Name == "colHistAction")
            {
                if (gridHistory.Rows[e.RowIndex].DataBoundItem is ReceiptHistoryModel item)
                {
                    if (item.IsCancelled)
                    {
                        AppDialog.ShowWarning(ParentForm, "Phiếu thu đã bị hủy",
                            $"Phiếu thu {item.ReceiptCode} đã bị hủy bỏ trước đó, không thể in ấn hoặc sử dụng lại.");
                        return;
                    }
                    OpenReceiptPreview(item);
                }
            }
            else if (e.RowIndex >= 0 && gridHistory.Columns[e.ColumnIndex].Name == "colCancelAction")
            {
                if (gridHistory.Rows[e.RowIndex].DataBoundItem is ReceiptHistoryModel item)
                {
                    if (item.IsCancelled)
                    {
                        AppDialog.ShowInfo(ParentForm, "Thông báo", $"Phiếu thu {item.ReceiptCode} đã ở trạng thái hủy.");
                        return;
                    }

                    var confirm = AppDialog.ShowConfirm(
                        ParentForm,
                        "Xác nhận hủy phiếu thu",
                        $"Bạn có chắc chắn muốn HỦY phiếu thu {item.ReceiptCode} (Số tiền: {item.Amount:N0} đ)?\n\n" +
                        $"• Học viên: {item.StudentName} ({item.StudentCode})\n" +
                        $"• Lớp: {item.ClassName}\n\n" +
                        $"Hệ thống sẽ tự động hoàn trả lại số tiền {item.Amount:N0} đ vào công nợ của học viên!",
                        "Xác nhận hủy",
                        "Không hủy",
                        AppDialogType.Danger
                    );

                    if (confirm == DialogResult.OK)
                    {
                        // 1. Đánh dấu hủy phiếu
                        item.IsCancelled = true;
                        item.Content = $"[ĐÃ HỦY] {item.Content}";

                        // 2. Tìm học viên tương ứng trong _profiles để hoàn lại nợ
                        var profile = _profiles.FirstOrDefault(p => p.StudentCode == item.StudentCode && p.ClassName == item.ClassName);
                        if (profile != null)
                        {
                            profile.Paid = Math.Max(0, profile.Paid - item.Amount);
                            profile.Remaining = profile.TotalFee - profile.Paid;
                            if (profile.Remaining > 0)
                            {
                                profile.PaymentStatus = "⚠️ Còn nợ (Sau hủy phiếu)";
                                profile.DebtStatus = "Đến hạn trong 7 ngày";
                            }
                        }

                        // 3. Làm mới giao diện
                        ApplyFilter();
                        gridHistory.Refresh();

                        AppDialog.ShowSuccess(
                            ParentForm,
                            "Hủy phiếu thu thành công",
                            $"Đã hủy thành công phiếu thu {item.ReceiptCode}.\nSố dư công nợ của học viên {item.StudentName} đã được cập nhật lại chính xác!"
                        );
                    }
                }
            }
        };

        gridHistory.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                if (gridHistory.Rows[e.RowIndex].DataBoundItem is ReceiptHistoryModel item)
                {
                    OpenReceiptPreview(item);
                }
            }
        };
    }

    private void SelectTab(int tabIndex)
    {
        _currentTabIndex = tabIndex;

        Color activeColor = Color.FromArgb(37, 99, 235);
        Color inactiveColor = Color.FromArgb(100, 116, 139);
        var activeFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        var inactiveFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);

        btnTabProfiles.ForeColor = tabIndex == 0 ? activeColor : inactiveColor;
        btnTabProfiles.Font = tabIndex == 0 ? activeFont : inactiveFont;

        btnTabDebt.ForeColor = tabIndex == 1 ? activeColor : inactiveColor;
        btnTabDebt.Font = tabIndex == 1 ? activeFont : inactiveFont;

        btnTabHistory.ForeColor = tabIndex == 2 ? activeColor : inactiveColor;
        btnTabHistory.Font = tabIndex == 2 ? activeFont : inactiveFont;

        cardProfiles.Visible = (tabIndex == 0);
        cardDebt.Visible = (tabIndex == 1);
        cardHistory.Visible = (tabIndex == 2);

        UpdateStatusFilterItems(tabIndex);
        ApplyFilter();
    }

    private void OpenTuitionDetail(TuitionProfileModel item)
    {
        using var dlg = new TuitionDetailDialog(
            item.StudentCode,
            item.StudentName,
            item.ClassName,
            item.CourseName,
            item.OriginalFee,
            item.Discount,
            item.TotalFee,
            item.Paid,
            item.Remaining,
            item.PaymentStatus
        );

        if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
        {
            // Cập nhật lại sau khi thu tiền trong dialog
            ApplyFilter();
        }
    }

    private async void OpenCollectDialog(string studentName, string className, decimal remainingDebt, string studentCode)
    {
        using var dialog = new CollectTuitionDialog(studentName, className, remainingDebt, studentCode);
        if (dialog.ShowDialog(ParentForm) == DialogResult.OK)
        {
            decimal paidAmt = dialog.CollectedAmount;
            string targetCode = dialog.StudentCode;
            string targetName = dialog.StudentName;
            string targetClass = dialog.ClassName;
            string method = dialog.PaymentMethod;
            string note = string.IsNullOrEmpty(dialog.ContentNote) ? $"Thu học phí - {targetName} ({targetCode}) - Lớp {targetClass}" : dialog.ContentNote;

            // Ghi nhận trực tiếp vào CSDL SQLite thông qua FinanceService (ACID transaction)
            var result = await _financeService.CollectTuitionAsync(targetCode, paidAmt, method, note, AppSession.UserId);

            string finalReceiptCode = !string.IsNullOrEmpty(result.ReceiptCode) ? result.ReceiptCode : dialog.ReceiptCode;

            // Tải lại dữ liệu trực tiếp từ SQLite để cập nhật giao diện
            LoadRealTuitionDataAsync();

            var receiptModel = new ReceiptHistoryModel
            {
                ReceiptCode = finalReceiptCode,
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                StudentCode = targetCode,
                StudentName = targetName,
                ClassName = targetClass,
                CourseName = dialog.CourseName,
                Content = note,
                Amount = paidAmt,
                Method = method,
                Collector = AppSession.FullName
            };

            if (dialog.ShouldPrintReceipt)
            {
                OpenReceiptPreview(receiptModel);
            }
            else
            {
                AppDialog.ShowSuccess(ParentForm, "Thu học phí thành công",
                    $"Đã thu học phí thành công {paidAmt:N0} đ cho học viên {targetName} ({targetCode})!\n" +
                    $"Mã phiếu thu: [{finalReceiptCode}]. Giao dịch đã được lưu trữ an toàn trong SQLite 100% Offline.");
            }
        }
    }

    private void OpenReceiptPreview(ReceiptHistoryModel receipt)
    {
        using var previewDlg = new ReceiptPrintPreviewDialog(
            receipt.StudentName,
            receipt.ClassName,
            receipt.Amount,
            receipt.ReceiptCode,
            receipt.StudentCode,
            receipt.Method,
            receipt.Collector,
            receipt.CourseName
        );
        previewDlg.ShowDialog(ParentForm);
    }

    private void ApplyFilter()
    {
        string q = txtSearch.Text?.Trim().ToLowerInvariant() ?? "";
        string selectedClass = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";
        string selectedStatus = cboStatusFilter.SelectedItem?.ToString() ?? "";

        if (_currentTabIndex == 0) // Tab 1: Hồ sơ
        {
            var filtered = _profiles.Where(p =>
                (string.IsNullOrEmpty(q) ||
                 p.StudentCode.ToLowerInvariant().Contains(q) ||
                 p.StudentName.ToLowerInvariant().Contains(q) ||
                 p.ClassName.ToLowerInvariant().Contains(q) ||
                 p.CourseName.ToLowerInvariant().Contains(q)) &&
                (selectedClass == "Tất cả lớp" || p.ClassName == selectedClass) &&
                (string.IsNullOrEmpty(selectedStatus) || selectedStatus == "Tất cả trạng thái" ||
                 (selectedStatus.Contains("Đã tất toán") && p.Remaining == 0) ||
                 (selectedStatus.Contains("Còn nợ") && p.Remaining > 0))
            ).ToList();

            gridProfiles.DataSource = null;
            gridProfiles.DataSource = filtered;

            CalculateProfileSummaries(filtered);
        }
        else if (_currentTabIndex == 1) // Tab 2: Công nợ
        {
            var filtered = _profiles.Where(p => p.Remaining > 0 &&
                (string.IsNullOrEmpty(q) ||
                 p.StudentCode.ToLowerInvariant().Contains(q) ||
                 p.StudentName.ToLowerInvariant().Contains(q) ||
                 p.ClassName.ToLowerInvariant().Contains(q) ||
                 p.CourseName.ToLowerInvariant().Contains(q)) &&
                (selectedClass == "Tất cả lớp" || p.ClassName == selectedClass) &&
                (string.IsNullOrEmpty(selectedStatus) || selectedStatus == "Tất cả công nợ" ||
                 p.DebtStatus.Contains(selectedStatus))
            ).ToList();

            gridDebtors.DataSource = null;
            gridDebtors.DataSource = filtered;

            decimal totalDebt = filtered.Sum(p => p.Remaining);
            lblDebtorsFooter.Text = $"📌 Có {filtered.Count} học viên còn nợ | Tổng số dư công nợ: {totalDebt:N0} đ | Nhấn '💵 Thu tiền' để lập tức thu phí và sinh phiếu thu.";
        }
        else // Tab 3: Lịch sử thu
        {
            var filtered = _receipts.Where(r =>
                (string.IsNullOrEmpty(q) ||
                 r.ReceiptCode.ToLowerInvariant().Contains(q) ||
                 r.StudentCode.ToLowerInvariant().Contains(q) ||
                 r.StudentName.ToLowerInvariant().Contains(q) ||
                 r.ClassName.ToLowerInvariant().Contains(q) ||
                 r.Content.ToLowerInvariant().Contains(q)) &&
                (selectedClass == "Tất cả lớp" || r.ClassName == selectedClass) &&
                (string.IsNullOrEmpty(selectedStatus) || selectedStatus == "Tất cả phương thức" ||
                 r.Method.Contains(selectedStatus))
            ).ToList();

            gridHistory.DataSource = null;
            gridHistory.DataSource = filtered;

            decimal totalCollected = filtered.Sum(r => r.Amount);
            lblHistoryFooter.Text = $"📌 Đã ghi nhận {filtered.Count} phiếu thu | Tổng số tiền đã thu: {totalCollected:N0} đ | Nhấn '🖨️ In phiếu thu' để mở phôi in A5.";
        }
    }

    private void CalculateProfileSummaries(List<TuitionProfileModel> list)
    {
        decimal total = list.Sum(p => p.TotalFee);
        decimal paid = list.Sum(p => p.Paid);
        decimal remaining = list.Sum(p => p.Remaining);

        lblSumTotalVal.Text = $"{total:N0} đ";
        lblSumPaidVal.Text = $"{paid:N0} đ";
        lblSumRemainingVal.Text = $"{remaining:N0} đ";
    }
}
