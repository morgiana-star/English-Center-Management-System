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
        public int PaidInstallmentCount { get; set; }
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
        SetupDiscountManagerButton();
        SetupGrids();
        LoadRealTuitionDataAsync();
        WireEvents();
        SelectTab(0);
    }

    private void SetupDiscountManagerButton()
    {
        btnCollectTuition.Visible = false;
        btnManageDiscounts.Click += (s, e) =>
        {
            using var dlg = new DiscountManagementDialog();
            dlg.ShowDialog(ParentForm);
        };
    }

    private void SetupFilters()
    {
        cboClassFilter.Items.Clear();
        cboClassFilter.Items.Add("Tất cả lớp");
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
                "Đã tất toán",
                "Còn nợ học phí"
            });
        }
        else if (tabIndex == 1) // Công nợ
        {
            cboStatusFilter.Items.AddRange(new object[]
            {
                "Tất cả công nợ",
                "Quá hạn",
                "Đến hạn trong 7 ngày",
                "Trong hạn"
            });
        }
        else // Lịch sử thu
        {
            cboStatusFilter.Items.AddRange(new object[]
            {
                "Tất cả phương thức",
                "Chuyển khoản",
                "Tiền mặt",
                "POS"
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

        gridHistory.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridHistory.Rows.Count) return;
            var item = gridHistory.Rows[e.RowIndex].DataBoundItem as ReceiptHistoryModel;
            if (item == null) return;

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
                    DebtStatus = p.DebtStatus,
                    PaidInstallmentCount = p.PaidInstallmentCount
                });
            }

            // Đồng bộ danh sách lớp trong bộ lọc từ dữ liệu thật
            string? prevClass = cboClassFilter.SelectedItem?.ToString();
            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả lớp");
            foreach (var cls in _profiles.Select(x => x.ClassName).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().OrderBy(x => x))
            {
                cboClassFilter.Items.Add(cls);
            }
            int clsIdx = !string.IsNullOrEmpty(prevClass) ? cboClassFilter.Items.IndexOf(prevClass) : 0;
            cboClassFilter.SelectedIndex = clsIdx >= 0 ? clsIdx : 0;

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
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi tải dữ liệu học phí", ex.Message);
        }
    }

    private void WireEvents()
    {
        tabMain.SelectedIndexChanged += (s, e) => SelectTab(tabMain.SelectedIndex);

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
                    OpenCollectDialog(item);
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
                    OpenReceiptPreview(item);
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
        if (tabMain.SelectedIndex != tabIndex && tabIndex >= 0 && tabIndex < tabMain.TabPages.Count)
        {
            tabMain.SelectedIndex = tabIndex;
        }

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

    private async void OpenCollectDialog(TuitionProfileModel item)
    {
        using var dialog = new CollectTuitionDialog(
            item.StudentName,
            item.ClassName,
            item.TotalFee,
            item.Remaining,
            item.StudentCode,
            item.CourseName,
            item.PaidInstallmentCount);

        if (dialog.ShowDialog(ParentForm) == DialogResult.OK)
        {
            decimal paidAmt = dialog.CollectedAmount;
            string targetCode = dialog.StudentCode;
            string targetName = dialog.StudentName;
            string targetClass = dialog.ClassName;
            string method = dialog.PaymentMethod;
            string note = string.IsNullOrEmpty(dialog.ContentNote) ? $"Thu học phí - {targetName} ({targetCode}) - Lớp {targetClass}" : dialog.ContentNote;

            var result = await _financeService.CollectTuitionAsync(targetCode, paidAmt, method, note, AppSession.UserId, dialog.DiscountAmount);
            string finalReceiptCode = !string.IsNullOrEmpty(result.ReceiptCode) ? result.ReceiptCode : dialog.ReceiptCode;
            decimal remainingAfterPay = Math.Max(0m, item.Remaining - dialog.DiscountAmount - paidAmt);

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
                OpenReceiptPreview(receiptModel, remainingAfterPay, item.DueDate);
            }
            else
            {
                AppDialog.ShowSuccess(ParentForm, "Thu học phí thành công",
                    $"Đã thu học phí thành công {paidAmt:N0} đ cho học viên {targetName} ({targetCode}).\nMã phiếu thu: {finalReceiptCode}.");
            }
        }
    }

    private void OpenCollectDialog(string studentName, string className, decimal remainingDebt, string studentCode)
    {
        var matched = _profiles.FirstOrDefault(p => p.StudentCode == studentCode) ?? new TuitionProfileModel
        {
            StudentName = studentName,
            ClassName = className,
            TotalFee = remainingDebt,
            Remaining = remainingDebt,
            StudentCode = studentCode
        };
        OpenCollectDialog(matched);
    }

    private void OpenReceiptPreview(ReceiptHistoryModel receipt, decimal? remainingOverride = null, string? dueDateOverride = null)
    {
        var prof = _profiles.FirstOrDefault(p => p.StudentCode == receipt.StudentCode && (string.IsNullOrEmpty(receipt.ClassName) || p.ClassName == receipt.ClassName))
                   ?? _profiles.FirstOrDefault(p => p.StudentCode == receipt.StudentCode);
        decimal remDebt = remainingOverride ?? prof?.Remaining ?? 0m;
        string dueText = dueDateOverride ?? prof?.DueDate ?? string.Empty;

        using var previewDlg = new ReceiptPrintPreviewDialog(
            receipt.StudentName,
            receipt.ClassName,
            receipt.Amount,
            receipt.ReceiptCode,
            receipt.StudentCode,
            receipt.Method,
            receipt.Collector,
            receipt.CourseName,
            receipt.Content,
            receipt.ReceiptCode,
            remDebt,
            dueText
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
            lblDebtorsFooter.Text = $"Có {filtered.Count} học viên còn nợ  |  Tổng số dư công nợ: {totalDebt:N0} đ";
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
            lblHistoryFooter.Text = $"Đã ghi nhận {filtered.Count} phiếu thu  |  Tổng số tiền đã thu: {totalCollected:N0} đ";
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
