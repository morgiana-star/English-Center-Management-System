using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class CollectTuitionDialog : Form
{
    private readonly decimal _remainingDebt;
    private readonly string _studentName;
    private readonly string _className;

    public CollectTuitionDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 3400000)
    {
    }

    public CollectTuitionDialog(string studentName, string className, decimal remainingDebt)
    {
        InitializeComponent();
        _studentName = studentName;
        _className = className;
        _remainingDebt = remainingDebt;

        SetupDialog();
    }

    private void SetupDialog()
    {
        txtStudentInfo.Text = $"{_studentName} / {_className}";
        lblTitle.Text = $"Thu học phí · {_studentName}";
        cboPaymentType.SelectedIndex = 0;
        cboPaymentMethod.SelectedIndex = 0;

        btnCancel.Click += (s, e) => Close();

        btnFillRemaining.Click += (s, e) =>
        {
            txtAmount.Text = $"{_remainingDebt:N0}";
        };

        txtAmount.TextChanged += (s, e) => ValidateAmount();

        btnContinueConfirm.Click += (s, e) =>
        {
            decimal amount = ParseAmount();
            if (amount <= 0 || amount > _remainingDebt)
            {
                ValidateAmount();
                return;
            }

            using var confirmDlg = new PaymentConfirmDialog(_studentName, _className, amount, _remainingDebt);
            if (confirmDlg.ShowDialog(this) == DialogResult.OK)
            {
                this.Hide();
                using var successDlg = new PaymentSuccessDialog(_studentName, _className, amount, _remainingDebt);
                successDlg.ShowDialog();
                this.Close();
            }
        };

        ValidateAmount();
    }

    private decimal ParseAmount()
    {
        string raw = txtAmount.Text.Replace(".", "").Replace(",", "").Replace("đ", "").Trim();
        if (decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal val))
        {
            return val;
        }
        return 0;
    }

    private void ValidateAmount()
    {
        decimal amount = ParseAmount();
        if (amount <= 0)
        {
            lblAmountError.Text = "Số tiền phải lớn hơn 0đ.";
            lblAmountError.Visible = true;
            btnContinueConfirm.Enabled = false;
        }
        else if (amount > _remainingDebt)
        {
            lblAmountError.Text = $"Vượt số dư {_remainingDebt:N0}đ. Số tiền phải >0 và ≤{_remainingDebt:N0}đ.";
            lblAmountError.Visible = true;
            btnContinueConfirm.Enabled = false;
        }
        else
        {
            lblAmountError.Visible = false;
            btnContinueConfirm.Enabled = true;
        }
    }
}
