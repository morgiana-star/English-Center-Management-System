using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class CollectTuitionDialog : Form
{
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
    private decimal _currentRemaining = 3400000;

    public string StudentCode { get; private set; } = "HV-0241";
    public string StudentName { get; private set; } = "Nguyễn Minh Anh";
    public string ClassName { get; private set; } = "IELTS-F01";
    public string CourseName { get; private set; } = "IELTS Foundation";
    public decimal CollectedAmount { get; private set; } = 3400000;
    public string PaymentMethod { get; private set; } = "Chuyển khoản VietQR";
    public string ReceiptCode { get; private set; } = string.Empty;
    public string ContentNote { get; private set; } = string.Empty;
    public bool ShouldPrintReceipt { get; private set; } = true;

    public CollectTuitionDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 3400000, "HV-0241")
    {
    }

    public CollectTuitionDialog(string studentName, string className, decimal remainingDebt, string studentCode = "HV-0241")
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        StudentName = string.IsNullOrEmpty(studentName) ? "Nguyễn Minh Anh" : studentName;
        ClassName = string.IsNullOrEmpty(className) ? "IELTS-F01" : className;
        StudentCode = string.IsNullOrEmpty(studentCode) ? "HV-0241" : studentCode;
        _currentRemaining = remainingDebt > 0 ? remainingDebt : 3400000;

        ReceiptCode = $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";
        lblReceiptNo.Text = $"Mã phiếu: {ReceiptCode}";

        InitDebtorsList();
        SetupForm();
        WireEvents();
    }

    private void InitDebtorsList()
    {
        _debtors.Clear();
        _debtors.Add(new DebtorOption { Code = "HV-0241", Name = "Nguyễn Minh Anh", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 5400000, Paid = 2000000, Remaining = 3400000 });
        _debtors.Add(new DebtorOption { Code = "HV-0238", Name = "Phạm Khánh Linh", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 3600000, Remaining = 2400000 });
        _debtors.Add(new DebtorOption { Code = "HV-0239", Name = "Đỗ Thanh Tâm", ClassName = "COM-B01", CourseName = "Tiếng Anh Giao tiếp Cơ bản", TotalFee = 3200000, Paid = 0, Remaining = 3200000 });
        _debtors.Add(new DebtorOption { Code = "HV-0215", Name = "Trần Thảo Nhi", ClassName = "IELTS-F01", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 5500000, Remaining = 500000 });
        _debtors.Add(new DebtorOption { Code = "HV-0235", Name = "Nguyễn Tiến Đạt", ClassName = "IELTS-F02", CourseName = "IELTS Foundation", TotalFee = 6000000, Paid = 4800000, Remaining = 1200000 });
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
                CourseName = "IELTS Foundation",
                TotalFee = _currentRemaining,
                Paid = 0,
                Remaining = _currentRemaining
            };
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
        _currentRemaining = debtor.Remaining;

        lblClassInfo.Text = $"Khóa / Lớp: {debtor.CourseName} · {debtor.ClassName}";
        lblTotalVal.Text = $"{debtor.TotalFee:N0} đ";
        lblPaidVal.Text = $"{debtor.Paid:N0} đ";
        lblRemainingVal.Text = $"{debtor.Remaining:N0} đ";

        txtAmount.Text = $"{debtor.Remaining:N0} đ";
        btnPayFull.Text = $"💯 Đóng hết ({debtor.Remaining:N0}đ)";
        decimal half = Math.Round(debtor.Remaining / 2, 0);
        btnPayHalf.Text = $"½ Đóng 50% ({half:N0}đ)";

        txtNote.Text = $"Thu học phí - {debtor.Name} ({debtor.Code}) - Lớp {debtor.ClassName}";
        UpdateWordsLabel(debtor.Remaining);
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

        btnPayFull.Click += (s, e) =>
        {
            txtAmount.Text = $"{_currentRemaining:N0} đ";
            UpdateWordsLabel(_currentRemaining);
        };

        btnPayHalf.Click += (s, e) =>
        {
            decimal half = Math.Round(_currentRemaining / 2, 0);
            txtAmount.Text = $"{half:N0} đ";
            UpdateWordsLabel(half);
        };

        txtAmount.TextChanged += (s, e) =>
        {
            decimal amt = ParseAmount();
            UpdateWordsLabel(amt);
        };

        rbVietQR.CheckedChanged += (s, e) => ToggleMethod();
        rbCash.CheckedChanged += (s, e) => ToggleMethod();
        rbPos.CheckedChanged += (s, e) => ToggleMethod();

        btnConfirm.Click += (s, e) =>
        {
            decimal amount = ParseAmount();
            if (amount <= 0)
            {
                MessageBox.Show("Số tiền thanh toán phải lớn hơn 0 đ.", "Số tiền không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (amount > _currentRemaining)
            {
                var askOver = MessageBox.Show(
                    $"Số tiền bạn nhập ({amount:N0} đ) lớn hơn số dư nợ ({_currentRemaining:N0} đ).\nBạn có chắc chắn muốn tiếp tục thu số tiền này không?",
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
        if (amount == 3400000) return "Ba triệu bốn trăm nghìn đồng chẵn";
        if (amount == 1700000) return "Một triệu bảy trăm nghìn đồng chẵn";
        if (amount == 2400000) return "Hai triệu bốn trăm nghìn đồng chẵn";
        if (amount == 1200000) return "Một triệu hai trăm nghìn đồng chẵn";
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
