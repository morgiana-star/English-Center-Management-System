using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class PaymentConfirmDialog : Form
{
    private readonly decimal _amount;
    private readonly decimal _prevDebt;
    private readonly string _studentName;
    private readonly string _className;

    public PaymentConfirmDialog() : this("Nguyễn Minh Anh", "IELTS-F01", 1500000, 3400000)
    {
    }

    public PaymentConfirmDialog(string studentName, string className, decimal amount, decimal prevDebt)
    {
        InitializeComponent();
        _studentName = studentName;
        _className = className;
        _amount = amount;
        _prevDebt = prevDebt;

        SetupView();
    }

    private void SetupView()
    {
        lblTitle.Text = $"Xác nhận thu {_amount:N0}đ?";
        lblHighlightVal.Text = $"{_amount:N0} đ";

        decimal newDebt = Math.Max(0, _prevDebt - _amount);
        decimal newPaid = 2000000 + _amount;

        lblStudentVal.Text = $"{_studentName} · HV-0241";
        lblClassVal.Text = $"{_className} (Foundation)";
        lblPrevDebtVal.Text = $"{_prevDebt:N0}đ";
        lblNewPaidVal.Text = $"{newPaid:N0}đ";
        lblNewDebtVal.Text = $"{newDebt:N0}đ (15/11)";

        chkCommitment.Checked = true;
        btnConfirm.Enabled = true;

        chkCommitment.CheckedChanged += (s, e) =>
        {
            btnConfirm.Enabled = chkCommitment.Checked;
        };

        btnConfirm.Click += (s, e) =>
        {
            DialogResult = DialogResult.OK;
            Close();
        };

        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };
    }
}
