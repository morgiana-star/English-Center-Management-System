using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ECMS.Business.Services;

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
        lblCollector.Text = $"Người lập: {AppSession.FullName} ({AppSession.RoleName})";
        dtpPaymentDate.Value = DateTime.Today;

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
        decimal amountToPay = baseAmount;

        switch (cboInstallmentPlan.SelectedIndex)
        {
            case 0: // 100%
                amountToPay = baseAmount;
                break;
            case 1: // 50%
                amountToPay = Math.Round(baseAmount * 0.5m, 0);
                break;
            case 2: // 40%
                amountToPay = Math.Round(baseAmount * 0.4m, 0);
                break;
        }

        txtAmount.Text = $"{amountToPay:N0} đ";
        UpdateWordsLabel(amountToPay);

        decimal simulatedPaid = _selectedDebtor.Paid + amountToPay;
        decimal simulatedRemaining = Math.Max(0, _selectedDebtor.TotalFee - simulatedPaid);

        lblPaidVal.Text = $"{simulatedPaid:N0} đ";
        lblRemainingVal.Text = $"{simulatedRemaining:N0} đ";
        RemainingDebt = simulatedRemaining;
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
        };

        rbVietQR.CheckedChanged += (s, e) => ToggleMethod();
        rbCash.CheckedChanged += (s, e) => ToggleMethod();
        rbPos.CheckedChanged += (s, e) => ToggleMethod();

        btnConfirm.Click += (s, e) =>
        {
            decimal amount = ParseAmount();
            if (amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền thu hợp lệ lớn hơn 0đ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (_selectedDebtor != null && amount > _selectedDebtor.Remaining && _selectedDebtor.Remaining > 0)
            {
                var askOver = MessageBox.Show(
                    $"Số tiền thu ({amount:N0}đ) lớn hơn số dư nợ hiện tại ({_selectedDebtor.Remaining:N0}đ).\nBạn có chắc chắn muốn tiếp tục ghi nhận dư tiền?",
                    "Cảnh báo số tiền vượt nợ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (askOver != DialogResult.Yes) return;
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
        if (rbVietQR.Checked)
        {
            lblRefTitle.Text = "Mã GD VietQR:";
            txtReference.PlaceholderText = "Nhập mã giao dịch ngân hàng / biên nhận VietQR";
            txtReference.Enabled = true;
        }
        else if (rbPos.Checked)
        {
            lblRefTitle.Text = "Số POS / Trace:";
            txtReference.PlaceholderText = "Nhập số hóa đơn POS / mã giao dịch quẹt thẻ";
            txtReference.Enabled = true;
        }
        else
        {
            lblRefTitle.Text = "Mã tham chiếu:";
            txtReference.PlaceholderText = "Ghi chú thu tiền mặt tại quầy (tùy chọn)";
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
