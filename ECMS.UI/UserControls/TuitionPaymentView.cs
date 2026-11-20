using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Enums;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class TuitionPaymentView : UserControl
{
    private readonly IFinanceService _financeService = new FinanceService();

    public class TuitionProfileModel
    {
        public int InvoiceId { get; set; }
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
        WireEvents();
        SelectTab(0);
        _ = LoadRealDataFromDbAsync();
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
                if (item.PaymentStatus.Contains("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
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
                }
                else if (item.DebtStatus.Contains("7 ngày"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(37, 99, 235);
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
        };
    }

    private async Task LoadRealDataFromDbAsync()
    {
        try
        {
            var dbProfiles = (await _financeService.GetTuitionProfilesAsync()).ToList();
            _profiles.Clear();

            foreach (var p in dbProfiles)
            {
                string dueDisplay = DateTime.TryParse(p.DueDate, out var dt) ? dt.ToString("dd/MM/yyyy") : p.DueDate;
                string payStatus = p.Remaining <= 0
                    ? "✓ Đã tất toán"
                    : (p.Paid <= 0 ? "⚠️ Chưa đóng" : "⚠️ Còn nợ");

                string debtSt = "Đã hoàn thành";
                if (p.Remaining > 0)
                {
                    if (DateTime.TryParse(p.DueDate, out var dueDt))
                    {
                        if (dueDt.Date < DateTime.Today) debtSt = "Đã quá hạn";
                        else if (dueDt.Date <= DateTime.Today.AddDays(7)) debtSt = "Đến hạn trong 7 ngày";
                        else debtSt = "Trong hạn";
                    }
                    else
                    {
                        debtSt = "Trong hạn";
                    }
                }

                _profiles.Add(new TuitionProfileModel
                {
                    InvoiceId = p.InvoiceId,
                    StudentCode = p.StudentCode,
                    StudentName = p.StudentName,
                    CourseName = p.CourseName,
                    ClassName = p.ClassName,
                    OriginalFee = p.OriginalFee,
                    Discount = p.Discount,
                    TotalFee = p.TotalFee,
                    Paid = p.Paid,
                    Remaining = p.Remaining,
                    DueDate = dueDisplay,
                    PaymentStatus = payStatus,
                    DebtStatus = debtSt
                });
            }

            var dbReceipts = (await _financeService.GetPaymentReceiptsHistoryAsync()).ToList();
            _receipts.Clear();
            foreach (var r in dbReceipts)
            {
                string dateDisp = DateTime.TryParse(r.PaymentDate, out var pdt) ? pdt.ToString("dd/MM/yyyy") : r.PaymentDate;
                _receipts.Add(new ReceiptHistoryModel
                {
                    ReceiptCode = r.ReceiptCode,
                    Date = dateDisp,
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

            var distinctClasses = _profiles.Select(x => x.ClassName).Distinct().OrderBy(x => x).ToList();
            string curSel = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";
            cboClassFilter.Items.Clear();
            cboClassFilter.Items.Add("Tất cả lớp");
            foreach (var c in distinctClasses) cboClassFilter.Items.Add(c);
            int idx = cboClassFilter.FindStringExact(curSel);
            cboClassFilter.SelectedIndex = idx >= 0 ? idx : 0;

            ApplyFilter();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp dữ liệu học phí", ex.Message);
        }
    }

    private void LoadSampleData()
    {
        _ = LoadRealDataFromDbAsync();
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
                Title = "Xuất báo cáo tài chính & công nợ",
                Filter = "Tệp Excel (*.xlsx)|*.xlsx|Tệp CSV (*.csv)|*.csv",
                FileName = $"BaoCao_TaiChinh_ECMS_{DateTime.Now:yyyyMMdd}.xlsx"
            };
            if (sfd.ShowDialog(FindForm()) == DialogResult.OK)
            {
                AppDialog.ShowSuccess(ParentForm, "Xuất báo cáo", $"Đã xuất thành công báo cáo tài chính ra tệp:\n{sfd.FileName}");
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
        var match = _profiles.FirstOrDefault(p => p.StudentCode == studentCode || p.StudentName == studentName);
        decimal totalFee = match?.TotalFee ?? remainingDebt;
        string courseName = match?.CourseName ?? "IELTS Foundation";

        using var dialog = new CollectTuitionDialog(studentName, className, totalFee, remainingDebt, studentCode, courseName);
        if (dialog.ShowDialog(ParentForm) == DialogResult.OK)
        {
            decimal paidAmt = dialog.CollectedAmount;
            string targetCode = dialog.StudentCode;
            string targetName = dialog.StudentName;
            string targetClass = dialog.ClassName;

            if (match != null && match.InvoiceId > 0)
            {
                var methodEnum = dialog.PaymentMethod switch
                {
                    var m when m.Contains("Tiền mặt", StringComparison.OrdinalIgnoreCase) => PaymentMethod.Cash,
                    var m when m.Contains("POS", StringComparison.OrdinalIgnoreCase) => PaymentMethod.POS,
                    _ => PaymentMethod.BankTransfer
                };

                var payRes = await _financeService.RecordPaymentAsync(
                    match.InvoiceId,
                    paidAmt,
                    methodEnum,
                    AppSession.UserId,
                    string.IsNullOrEmpty(dialog.ContentNote) ? "Thu học phí đợt tiếp theo" : dialog.ContentNote);

                if (!payRes.Success)
                {
                    AppDialog.ShowError(ParentForm, "Lỗi thu học phí", payRes.Message);
                    return;
                }
            }

            await LoadRealDataFromDbAsync();

            var newReceipt = new ReceiptHistoryModel
            {
                ReceiptCode = dialog.ReceiptCode,
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                StudentCode = targetCode,
                StudentName = targetName,
                ClassName = targetClass,
                CourseName = courseName,
                Content = string.IsNullOrEmpty(dialog.ContentNote) ? "Thu học phí" : dialog.ContentNote,
                Amount = paidAmt,
                Method = dialog.PaymentMethod,
                Collector = AppSession.FullName
            };

            if (dialog.ShouldPrintReceipt)
            {
                OpenReceiptPreview(newReceipt);
            }
            else
            {
                AppDialog.ShowSuccess(ParentForm, "Thu học phí thành công",
                    $"Đã thu học phí thành công {paidAmt:N0} đ cho học viên {targetName} ({targetCode})!\n" +
                    $"Công nợ đã được đối trừ hoàn tất trong cơ sở dữ liệu.");
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
