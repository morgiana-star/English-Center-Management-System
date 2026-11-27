using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CollectTuitionDialog : Form
{
    private readonly IEnrollmentService _enrollmentService = new EnrollmentService();
    private decimal _initialTotalFee = 3400000;
    private decimal _initialPaid = 0;
    private decimal _initialRemaining = 3400000;
    private decimal _effectiveTotalFee = 3400000;
    private decimal _effectiveRemaining = 3400000;
    private int _paidInstallmentCount = 0;

    public string StudentCode { get; private set; } = string.Empty;
    public string StudentName { get; private set; } = string.Empty;
    public string ClassName { get; private set; } = string.Empty;
    public string CourseName { get; private set; } = string.Empty;
    public int? AppliedDiscountId { get; private set; }
    public string AppliedDiscountCode { get; private set; } = string.Empty;
    public decimal DiscountAmount { get; private set; }
    public decimal CollectedAmount { get; private set; }
    public decimal RemainingDebt { get; private set; }
    public string PaymentMethod { get; private set; } = "Chuyển khoản";
    public string ReceiptCode { get; private set; } = string.Empty;
    public string ContentNote { get; private set; } = string.Empty;
    public bool ShouldPrintReceipt { get; private set; } = true;

    public CollectTuitionDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 6800000, "HV-0241")
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
        string courseName = "IELTS Foundation",
        int paidInstallmentCount = 0)
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        StudentName = string.IsNullOrWhiteSpace(studentName) ? "Học viên mới" : studentName.Trim();
        ClassName = string.IsNullOrWhiteSpace(className) ? "IELTS-F01" : className.Trim();
        StudentCode = string.IsNullOrWhiteSpace(studentCode) ? "HV-0001" : studentCode.Trim();
        CourseName = string.IsNullOrWhiteSpace(courseName) ? "IELTS Foundation" : courseName.Trim();

        _initialTotalFee = totalFee > 0 ? totalFee : 3400000;
        _initialRemaining = remainingDebt >= 0 ? remainingDebt : _initialTotalFee;
        _initialPaid = Math.Max(0, _initialTotalFee - _initialRemaining);
        _effectiveTotalFee = _initialTotalFee;
        _effectiveRemaining = _initialRemaining;
        _paidInstallmentCount = Math.Max(0, paidInstallmentCount);
        if (_paidInstallmentCount == 0 && _initialPaid > 0)
        {
            _paidInstallmentCount = 1;
        }

        ReceiptCode = $"PT-{DateTime.Now:yyMMdd}-{new Random().Next(100, 999)}";
        lblReceiptNo.Text = $"Mã phiếu: {ReceiptCode}";

        SetupForm();
        WireEvents();
    }

    private void SetupForm()
    {
        lblStudentDisplay.Text = $"{StudentName}  ·  {StudentCode}";

        cboPaymentType.Items.Clear();
        cboPaymentType.Items.AddRange(new object[]
        {
            "Học phí theo khóa (Chính thức)",
            "Học phí đợt tiếp theo",
            "Lệ phí thi xếp lớp đầu vào",
            "Phí giáo trình & tài liệu",
            "Thu phụ phí khác"
        });
        cboPaymentType.SelectedIndex = _initialPaid > 0 ? 1 : 0;

        // ComboBox kế hoạch đóng học phí động theo số đợt còn lại (tối đa 3 đợt)
        int remainingInstallments = Math.Max(1, 3 - _paidInstallmentCount);
        cboInstallmentPlan.Items.Clear();
        if (remainingInstallments >= 3)
        {
            cboInstallmentPlan.Items.AddRange(new object[]
            {
                "Đóng trọn gói 1 lần (100% số tiền còn lại)",
                "Chia làm 2 đợt (Đợt này 50%)",
                "Chia làm 3 đợt (Đợt này 40%)"
            });
        }
        else if (remainingInstallments == 2)
        {
            cboInstallmentPlan.Items.AddRange(new object[]
            {
                "Đóng hết phần còn lại (100% số dư)",
                "Chia 2 đợt còn lại (Đợt này 50% số dư)"
            });
        }
        else
        {
            cboInstallmentPlan.Items.Add("Đóng tất toán đợt cuối (100% số dư còn lại)");
        }
        cboInstallmentPlan.SelectedIndex = 0;

        lblClassInfo.Text = $"Lớp: {ClassName}";
        lblTotalVal.Text = $"{_effectiveTotalFee:N0} đ";
        txtNote.Text = $"Thu học phí - {StudentName} ({StudentCode}) - Lớp {ClassName}";
        lblDiscountInfo.Text = "";
        lblDiscountInfo.Visible = false;

        ApplyHarmoniousTheme();
        ApplyInstallmentSelection();
    }

    private void ApplyHarmoniousTheme()
    {
        lblSectionStudent.Text = "1. THÔNG TIN HỌC VIÊN";

        Color cardBg = Color.FromArgb(248, 250, 252);
        Color cardBorder = Color.FromArgb(226, 232, 240);
        Color titleColor = Color.FromArgb(100, 116, 139);
        Color valColor = Color.FromArgb(30, 41, 59);

        foreach (var card in new[] { cardTotal, cardPaid, cardRemaining })
        {
            card.BackColor = cardBg;
            card.BorderColor = cardBorder;
        }
        foreach (var lblT in new[] { lblTotalTitle, lblPaidTitle, lblRemainingTitle })
        {
            lblT.ForeColor = titleColor;
        }
        foreach (var lblV in new[] { lblTotalVal, lblPaidVal, lblRemainingVal })
        {
            lblV.ForeColor = valColor;
        }

        txtAmount.ForeColor = Color.FromArgb(37, 99, 235);
    }

    private void ApplyInstallmentSelection()
    {
        decimal baseAmount = _effectiveRemaining > 0 ? _effectiveRemaining : _effectiveTotalFee;
        decimal amountToPay = baseAmount;

        switch (cboInstallmentPlan.SelectedIndex)
        {
            case 0:
                amountToPay = baseAmount;
                break;
            case 1:
                amountToPay = Math.Round(baseAmount * 0.5m, 0);
                break;
            case 2:
                amountToPay = Math.Round(baseAmount * 0.4m, 0);
                break;
        }

        txtAmount.Text = $"{amountToPay:N0} đ";
        UpdateWordsLabel(amountToPay);

        decimal simulatedPaid = _initialPaid + amountToPay;
        decimal simulatedRemaining = Math.Max(0, _effectiveTotalFee - simulatedPaid);

        lblTotalVal.Text = $"{_effectiveTotalFee:N0} đ";
        lblPaidVal.Text = $"{simulatedPaid:N0} đ";
        lblRemainingVal.Text = $"{simulatedRemaining:N0} đ";
        RemainingDebt = simulatedRemaining;
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();

        cboInstallmentPlan.SelectedIndexChanged += (s, e) => ApplyInstallmentSelection();

        btnApplyDiscount.Click += async (s, e) =>
        {
            string code = txtDiscountCode.Text.Trim().ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(code))
            {
                AppliedDiscountId = null;
                AppliedDiscountCode = string.Empty;
                DiscountAmount = 0;
                _effectiveTotalFee = _initialTotalFee;
                _effectiveRemaining = _initialRemaining;
                lblDiscountInfo.Text = "";
                ApplyInstallmentSelection();
                return;
            }

            var discount = await _enrollmentService.GetDiscountByCodeAsync(code);
            if (discount == null)
            {
                lblDiscountInfo.ForeColor = Color.FromArgb(220, 38, 38);
                lblDiscountInfo.Text = "Mã không hợp lệ";
                AppDialog.ShowWarning(this, "Mã giảm giá không hợp lệ", $"Không tìm thấy mã giảm giá '{code}' đang hoạt động.");
                return;
            }

            AppliedDiscountId = discount.DiscountId;
            AppliedDiscountCode = discount.DiscountCode;
            DiscountAmount = discount.CalculateDiscount(_initialTotalFee);
            _effectiveTotalFee = Math.Max(0, _initialTotalFee - DiscountAmount);
            _effectiveRemaining = Math.Max(0, _effectiveTotalFee - _initialPaid);
            lblDiscountInfo.ForeColor = Color.FromArgb(22, 163, 74);
            lblDiscountInfo.Text = $"-{DiscountAmount:N0} đ";
            ApplyInstallmentSelection();
        };

        txtAmount.TextChanged += (s, e) =>
        {
            decimal amt = ParseAmount();
            UpdateWordsLabel(amt);
            decimal simulatedPaid = _initialPaid + amt;
            decimal simulatedRemaining = Math.Max(0, _effectiveTotalFee - simulatedPaid);
            lblPaidVal.Text = $"{simulatedPaid:N0} đ";
            lblRemainingVal.Text = $"{simulatedRemaining:N0} đ";
            RemainingDebt = simulatedRemaining;
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

            if (_effectiveRemaining > 0 && amount > _effectiveRemaining)
            {
                var askOver = AppDialog.ShowConfirm(this, "Cảnh báo thu vượt nợ",
                    $"Số tiền thu ({amount:N0} đ) lớn hơn số dư nợ hiện tại ({_effectiveRemaining:N0} đ).\nBạn có chắc chắn muốn ghi nhận khoản thu vượt nợ này?",
                    "Vẫn thu tiền", "Điều chỉnh lại");
                if (askOver != DialogResult.OK)
                {
                    txtAmount.Text = $"{_effectiveRemaining:N0} đ";
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
            PaymentMethod = rbVietQR.Checked ? "Chuyển khoản" : (rbCash.Checked ? "Tiền mặt" : "POS");
            ContentNote = txtNote.Text.Trim();
            ShouldPrintReceipt = chkPrintReceipt.Checked;
            RemainingDebt = Math.Max(0, _effectiveTotalFee - (_initialPaid + amount));

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
