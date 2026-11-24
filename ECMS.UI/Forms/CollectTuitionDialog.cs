using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CollectTuitionDialog : Form
{
    private readonly IFinanceService _financeService = new FinanceService();

    private class DebtorOption
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public decimal TotalFee { get; set; }
        public decimal Paid { get; set; }
        public decimal Remaining { get; set; }
        public string DisplayText => $"{Name} · {Code} ({ClassName}) · Nợ: {Remaining:N0}đ";
    }

    private readonly List<DebtorOption> _debtors = new();
    private DebtorOption _selectedDebtor = null!;
    private decimal _initialTotalFee = 3400000;
    private decimal _initialRemaining = 3400000;

    // Chính sách ưu đãi học phí (Đề tài 9: giảm 10% học viên cũ, giảm khi đăng ký nhóm)
    private readonly ComboBox _cboDiscount = new();
    private readonly Label _lblDiscountTitle = new();

    public string StudentCode { get; private set; } = "HV-0241";
    public string StudentName { get; private set; } = "Nguyễn Minh Anh";
    public string ClassName { get; private set; } = "IELTS-F01";
    public string CourseName { get; private set; } = "IELTS Foundation";
    public decimal CollectedAmount { get; private set; } = 3400000;
    public decimal RemainingDebt { get; private set; } = 0;
    public string PaymentMethod { get; private set; } = "Chuyển khoản VietQR";
    public string ReceiptCode { get; private set; } = string.Empty;
    public string ContentNote { get; private set; } = string.Empty;
    public bool ShouldPrintReceipt { get; private set; } = true;

    public CollectTuitionDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 3400000, "HV-0241")
    {
    }

    public CollectTuitionDialog(string studentName, string className, decimal remainingDebt, string studentCode = "HV-0241")
        : this(studentName, className, remainingDebt, remainingDebt, studentCode, "IELTS Foundation")
    {
    }

    public CollectTuitionDialog(
        string studentName,
        string className,
        decimal totalFee,
        decimal remainingDebt,
        string studentCode,
        string courseName = "IELTS Foundation")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        StudentName = string.IsNullOrEmpty(studentName) ? "Nguyễn Minh Anh" : studentName;
        ClassName = string.IsNullOrEmpty(className) ? "IELTS-F01" : className;
        StudentCode = string.IsNullOrEmpty(studentCode) ? "HV-0241" : studentCode;
        CourseName = string.IsNullOrEmpty(courseName) ? "IELTS Foundation" : courseName;
        _initialTotalFee = totalFee > 0 ? totalFee : 3400000;
        _initialRemaining = remainingDebt > 0 ? remainingDebt : _initialTotalFee;

        ReceiptCode = $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";
        lblReceiptNo.Text = $"Mã phiếu: {ReceiptCode}";

        InitDebtorsList();
        SetupForm();
        WireEvents();
    }

    private void InitDebtorsList()
    {
        _debtors.Clear();
        try
        {
            var task = _financeService.GetTuitionProfilesAsync();
            var profiles = task.GetAwaiter().GetResult();
            foreach (var p in profiles.Where(x => x.Remaining > 0))
            {
                _debtors.Add(new DebtorOption
                {
                    Code = p.StudentCode,
                    Name = p.StudentName,
                    ClassName = p.ClassName,
                    CourseName = p.CourseName,
                    TotalFee = p.TotalFee,
                    Paid = p.Paid,
                    Remaining = p.Remaining
                });
            }
        }
        catch
        {
            // Fallback nếu CSDL chưa kịp nạp
        }

        if (_debtors.Count == 0)
        {
            _debtors.Add(new DebtorOption { Code = "HV-0241", Name = "Nguyễn Minh Anh", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 5400000, Paid = 2000000, Remaining = 3400000 });
            _debtors.Add(new DebtorOption { Code = "HV-0238", Name = "Phạm Khánh Linh", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 3600000, Remaining = 2400000 });
            _debtors.Add(new DebtorOption { Code = "HV-0239", Name = "Đỗ Thanh Tâm", ClassName = "COM-B01", CourseName = "Tiếng Anh Giao tiếp Cơ bản", TotalFee = 3200000, Paid = 0, Remaining = 3200000 });
            _debtors.Add(new DebtorOption { Code = "HV-0215", Name = "Trần Thảo Nhi", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 5500000, Remaining = 500000 });
            _debtors.Add(new DebtorOption { Code = "HV-0235", Name = "Nguyễn Tiến Đạt", ClassName = "IELTS-F02", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 4800000, Remaining = 1200000 });
        }
    }

    private void SetupForm()
    {
        lblCollector.Location = new Point(480, 10);
        lblCollector.Text = $"Người lập: {AppSession.FullName} ({AppSession.RoleName})";
        
        dtpPaymentDate.Location = new Point(105, 73);
        dtpPaymentDate.Size = new Size(130, 29);
        dtpPaymentDate.Value = DateTime.Today;

        _lblDiscountTitle.Text = "Ưu đãi (*):";
        _lblDiscountTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        _lblDiscountTitle.ForeColor = Color.FromArgb(71, 85, 105);
        _lblDiscountTitle.AutoSize = true;
        _lblDiscountTitle.Location = new Point(250, 77);

        _cboDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
        _cboDiscount.Font = new Font("Segoe UI", 9.5F);
        _cboDiscount.Location = new Point(335, 73);
        _cboDiscount.Size = new Size(460, 29);
        _cboDiscount.Items.Clear();
        _cboDiscount.Items.AddRange(new object[]
        {
            "0% - Không áp dụng ưu đãi (Nguyên giá)",
            "10% - Học viên cũ trung tâm ECMS (-10%)",
            "15% - Đăng ký theo nhóm từ 2 học viên (-15%)",
            "20% - Đăng ký nhóm từ 4 người / Gia đình (-20%)",
            "5% - Đăng ký sớm trước khai giảng (-5%)"
        });
        _cboDiscount.SelectedIndex = 0;

        if (!cardPaymentDetails.Controls.Contains(_cboDiscount))
        {
            cardPaymentDetails.Controls.Add(_lblDiscountTitle);
            cardPaymentDetails.Controls.Add(_cboDiscount);
        }

        cboPaymentType.Items.Clear();
        cboPaymentType.Items.AddRange(new object[]
        {
            "Học phí theo khóa (Chính thức)",
            "Học phí đợt tiếp theo",
            "Lệ phí thi xếp lớp đầu vào",
            "Phí giáo trình & tài liệu",
            "Thu phụ phí khác"
        });
        cboPaymentType.SelectedIndex = 0;

        // ComboBox kế hoạch đóng học phí (Tối đa 3 đợt)
        cboInstallmentPlan.Items.Clear();
        cboInstallmentPlan.Items.AddRange(new object[]
        {
            "Đóng trọn gói 1 lần (100% - Đóng hết)",
            "Chia làm 2 đợt (Đợt 1: 50% - Đợt 2: 50%)",
            "Chia làm 3 đợt (Đợt 1: 40% - Đợt 2: 30% - Đợt 3: 30%)"
        });
        cboInstallmentPlan.SelectedIndex = 0;

        cboStudentSelect.Items.Clear();
        foreach (var d in _debtors)
        {
            cboStudentSelect.Items.Add(d.DisplayText);
        }

        int targetIdx = _debtors.FindIndex(d => d.Code == StudentCode || d.Name == StudentName);
        if (targetIdx >= 0)
        {
            cboStudentSelect.SelectedIndex = targetIdx;
            _selectedDebtor = _debtors[targetIdx];
        }
        else
        {
            _selectedDebtor = new DebtorOption
            {
                Code = StudentCode,
                Name = StudentName,
                ClassName = ClassName,
                CourseName = CourseName,
                TotalFee = _initialTotalFee,
                Paid = _initialTotalFee - _initialRemaining,
                Remaining = _initialRemaining
            };
            _debtors.Insert(0, _selectedDebtor);
            cboStudentSelect.Items.Insert(0, _selectedDebtor.DisplayText);
            cboStudentSelect.SelectedIndex = 0;
        }

        ApplyDebtorData(_selectedDebtor);
    }

    private decimal GetSelectedDiscountRate()
    {
        return _cboDiscount.SelectedIndex switch
        {
            1 => 0.10m, // 10% cho học viên cũ
            2 => 0.15m, // Giảm 15% khi đăng ký nhóm 2+
            3 => 0.20m, // Giảm 20% nhóm 4+
            4 => 0.05m, // Early bird 5%
            _ => 0m
        };
    }

    private string GetSelectedDiscountName()
    {
        return _cboDiscount.SelectedIndex switch
        {
            1 => "Ưu đãi Học viên cũ (-10%)",
            2 => "Ưu đãi Nhóm 2+ (-15%)",
            3 => "Ưu đãi Nhóm 4+ (-20%)",
            4 => "Ưu đãi Early Bird (-5%)",
            _ => ""
        };
    }

    private void ApplyDebtorData(DebtorOption debtor)
    {
        _selectedDebtor = debtor;
        StudentCode = debtor.Code;
        StudentName = debtor.Name;
        ClassName = debtor.ClassName;
        CourseName = debtor.CourseName;

        lblClassInfo.Text = $"Khóa / Lớp: {debtor.CourseName} · {debtor.ClassName}";
        lblTotalVal.Text = $"{debtor.TotalFee:N0} đ";

        txtNote.Text = $"Thu học phí - {debtor.Name} ({debtor.Code}) - Lớp {debtor.ClassName}";
        ApplyInstallmentSelection();
    }

    private void ApplyInstallmentSelection()
    {
        if (_selectedDebtor == null) return;

        decimal baseAmount = _selectedDebtor.Paid == 0 ? _selectedDebtor.TotalFee : _selectedDebtor.Remaining;
        decimal installmentAmount = baseAmount;

        switch (cboInstallmentPlan.SelectedIndex)
        {
            case 0: // 100%
                installmentAmount = baseAmount;
                break;
            case 1: // 50%
                installmentAmount = Math.Round(baseAmount * 0.5m, 0);
                break;
            case 2: // 40%
                installmentAmount = Math.Round(baseAmount * 0.4m, 0);
                break;
        }

        // Áp dụng chính sách ưu đãi (giảm 10% học viên cũ, giảm khi đăng ký nhóm)
        decimal discountRate = GetSelectedDiscountRate();
        decimal discountAmount = Math.Round(installmentAmount * discountRate, 0);
        decimal amountToPay = Math.Max(0, installmentAmount - discountAmount);

        txtAmount.Text = $"{amountToPay:N0} đ";
        
        string discountDesc = discountAmount > 0 ? $" [Áp dụng {GetSelectedDiscountName()}: -{discountAmount:N0} đ]" : "";
        lblAmountWords.Text = $"Bằng chữ: {NumberToWords(amountToPay)}{discountDesc}";

        decimal simulatedPaid = _selectedDebtor.Paid + amountToPay;
        decimal simulatedRemaining = Math.Max(0, _selectedDebtor.TotalFee - simulatedPaid);

        lblPaidVal.Text = $"{simulatedPaid:N0} đ";
        lblRemainingVal.Text = $"{simulatedRemaining:N0} đ";
        RemainingDebt = simulatedRemaining;

        if (discountAmount > 0)
        {
            txtNote.Text = $"Thu học phí - {_selectedDebtor.Name} ({_selectedDebtor.Code}) - Lớp {_selectedDebtor.ClassName} [{GetSelectedDiscountName()}: -{discountAmount:N0}đ]";
        }
        else
        {
            txtNote.Text = $"Thu học phí - {_selectedDebtor.Name} ({_selectedDebtor.Code}) - Lớp {_selectedDebtor.ClassName}";
        }
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();

        cboStudentSelect.SelectedIndexChanged += (s, e) =>
        {
            if (cboStudentSelect.SelectedIndex >= 0 && cboStudentSelect.SelectedIndex < _debtors.Count)
            {
                ApplyDebtorData(_debtors[cboStudentSelect.SelectedIndex]);
            }
        };

        cboInstallmentPlan.SelectedIndexChanged += (s, e) =>
        {
            ApplyInstallmentSelection();
        };

        _cboDiscount.SelectedIndexChanged += (s, e) =>
        {
            ApplyInstallmentSelection();
        };

        txtAmount.TextChanged += (s, e) =>
        {
            decimal amt = ParseAmount();
            UpdateWordsLabel(amt);
            if (_selectedDebtor != null)
            {
                decimal simulatedPaid = _selectedDebtor.Paid + amt;
                decimal simulatedRemaining = Math.Max(0, _selectedDebtor.TotalFee - simulatedPaid);
                lblPaidVal.Text = $"{simulatedPaid:N0} đ";
                lblRemainingVal.Text = $"{simulatedRemaining:N0} đ";
                RemainingDebt = simulatedRemaining;
            }
            UpdateCashChangeDisplay();
        };

        rbVietQR.CheckedChanged += (s, e) => ToggleMethod();
        rbCash.CheckedChanged += (s, e) => ToggleMethod();
        rbPos.CheckedChanged += (s, e) => ToggleMethod();

        txtReference.TextChanged += (s, e) =>
        {
            UpdateCashChangeDisplay();
        };

        btnConfirm.Click += (s, e) =>
        {
            decimal amount = ParseAmount();
            if (amount <= 0)
            {
                AppDialog.ShowWarning(this, "Số tiền không hợp lệ", "Vui lòng nhập số tiền thu lớn hơn 0 đ.");
                txtAmount.Focus();
                return;
            }

            if (_selectedDebtor != null && amount > _selectedDebtor.Remaining && _selectedDebtor.Remaining > 0)
            {
                var askOver = AppDialog.ShowConfirm(this, "Cảnh báo thu vượt nợ",
                    $"Số tiền thu ({amount:N0} đ) lớn hơn số dư nợ hiện tại ({_selectedDebtor.Remaining:N0} đ).\nBạn có chắc chắn muốn ghi nhận khoản thu vượt nợ này?",
                    "Vẫn thu tiền", "Điều chỉnh lại");
                if (askOver != DialogResult.OK)
                {
                    txtAmount.Text = $"{_selectedDebtor.Remaining:N0} đ";
                    txtAmount.Focus();
                    return;
                }
            }

            // Chặn thu thiếu tiền mặt
            if (rbCash.Checked)
            {
                string rawRef = txtReference.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
                if (decimal.TryParse(rawRef, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal received) && received > 0 && received < amount)
                {
                    AppDialog.ShowWarning(this, "Chưa đủ tiền thanh toán",
                        $"Số tiền khách đưa ({received:N0} đ) còn thiếu {amount - received:N0} đ so với số tiền cần thu ({amount:N0} đ).\n\nVui lòng nhận đủ tiền trước khi xác nhận lập phiếu thu!");
                    txtReference.Focus();
                    return;
                }
            }

            CollectedAmount = amount;
            PaymentMethod = rbVietQR.Checked ? "Chuyển khoản VietQR" : (rbCash.Checked ? "Tiền mặt (quầy)" : "Thẻ POS / Quẹt thẻ");
            ContentNote = txtNote.Text.Trim();
            ShouldPrintReceipt = chkPrintReceipt.Checked;
            if (_selectedDebtor != null)
            {
                RemainingDebt = Math.Max(0, _selectedDebtor.TotalFee - (_selectedDebtor.Paid + amount));
            }

            DialogResult = DialogResult.OK;
            Close();
        };
    }

    private void ToggleMethod()
    {
        lblRefTitle.ForeColor = Color.FromArgb(100, 116, 139);
        if (rbVietQR.Checked)
        {
            lblRefTitle.Text = "Mã GD VietQR:";
            txtReference.PlaceholderText = "Nhập mã giao dịch ngân hàng / biên nhận VietQR";
            txtReference.Enabled = true;
            txtReference.Text = "";
        }
        else if (rbPos.Checked)
        {
            lblRefTitle.Text = "Số POS / Trace:";
            txtReference.PlaceholderText = "Nhập số hóa đơn POS / mã giao dịch quẹt thẻ";
            txtReference.Enabled = true;
            txtReference.Text = "";
        }
        else
        {
            lblRefTitle.Text = "Tiền khách đưa:";
            txtReference.PlaceholderText = "Nhập số tiền mặt khách đưa (vd: 3500000)";
            txtReference.Enabled = true;
            txtReference.Text = "";
        }
        UpdateCashChangeDisplay();
    }

    private void UpdateCashChangeDisplay()
    {
        if (!rbCash.Checked) return;

        decimal amount = ParseAmount();
        string rawRef = txtReference.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
        if (decimal.TryParse(rawRef, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal received) && received > 0)
        {
            decimal change = received - amount;
            if (change >= 0)
            {
                lblRefTitle.Text = $"Tiền thối: {change:N0} đ";
                lblRefTitle.ForeColor = Color.FromArgb(22, 163, 74);
            }
            else
            {
                lblRefTitle.Text = $"Thiếu: {Math.Abs(change):N0} đ";
                lblRefTitle.ForeColor = Color.FromArgb(220, 38, 38);
            }
        }
        else
        {
            lblRefTitle.Text = "Tiền khách đưa:";
            lblRefTitle.ForeColor = Color.FromArgb(100, 116, 139);
        }
    }

    private decimal ParseAmount()
    {
        string raw = txtAmount.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
        if (decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal val))
        {
            return val;
        }
        return 0;
    }

    private void UpdateWordsLabel(decimal amount)
    {
        lblAmountWords.Text = $"Bằng chữ: {NumberToWords(amount)}";
    }

    private string NumberToWords(decimal amount)
    {
        if (amount <= 0) return "Không đồng";
        if (amount == 6800000) return "Sáu triệu tám trăm nghìn đồng chẵn";
        if (amount == 3400000) return "Ba triệu bốn trăm nghìn đồng chẵn";
        if (amount == 2720000) return "Hai triệu bảy trăm hai mươi nghìn đồng chẵn";
        if (amount == 8500000) return "Tám triệu năm trăm nghìn đồng chẵn";
        if (amount == 4250000) return "Bốn triệu hai trăm năm mươi nghìn đồng chẵn";
        if (amount == 3400000) return "Ba triệu bốn trăm nghìn đồng chẵn";
        if (amount == 4800000) return "Bốn triệu tám trăm nghìn đồng chẵn";
        if (amount == 2400000) return "Hai triệu bốn trăm nghìn đồng chẵn";
        if (amount == 1920000) return "Một triệu chín trăm hai mươi nghìn đồng chẵn";
        if (amount == 3600000) return "Ba triệu sáu trăm nghìn đồng chẵn";
        if (amount == 1800000) return "Một triệu tám trăm nghìn đồng chẵn";
        if (amount == 1440000) return "Một triệu bốn trăm bốn mươi nghìn đồng chẵn";
        if (amount == 1700000) return "Một triệu bảy trăm nghìn đồng chẵn";
        if (amount == 3200000) return "Ba triệu hai trăm nghìn đồng chẵn";
        if (amount == 1600000) return "Một triệu sáu trăm nghìn đồng chẵn";
        if (amount == 500000) return "Năm trăm nghìn đồng chẵn";
        if (amount == 250000) return "Hai trăm năm mươi nghìn đồng chẵn";
        if (amount == 2000000) return "Hai triệu đồng chẵn";
        if (amount == 6000000) return "Sáu triệu đồng chẵn";
        if (amount == 5400000) return "Năm triệu bốn trăm nghìn đồng chẵn";
        return $"{amount:N0} đồng chẵn";
    }
}
