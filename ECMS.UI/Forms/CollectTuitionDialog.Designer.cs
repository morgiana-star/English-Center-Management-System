namespace ECMS.UI.Forms;

partial class CollectTuitionDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblReceiptNo = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardPaymentDetails = new ECMS.UI.Controls.AppCard();
        txtNote = new System.Windows.Forms.TextBox();
        lblNoteTitle = new System.Windows.Forms.Label();
        txtReference = new System.Windows.Forms.TextBox();
        lblRefTitle = new System.Windows.Forms.Label();
        pnlMethod = new System.Windows.Forms.Panel();
        rbPos = new System.Windows.Forms.RadioButton();
        rbCash = new System.Windows.Forms.RadioButton();
        rbVietQR = new System.Windows.Forms.RadioButton();
        lblMethodTitle = new System.Windows.Forms.Label();
        lblAmountWords = new System.Windows.Forms.Label();
        cboInstallmentPlan = new System.Windows.Forms.ComboBox();
        txtAmount = new System.Windows.Forms.TextBox();
        lblAmountTitle = new System.Windows.Forms.Label();
        dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
        lblPaymentDateTitle = new System.Windows.Forms.Label();
        cboPaymentType = new System.Windows.Forms.ComboBox();
        lblPaymentTypeTitle = new System.Windows.Forms.Label();
        lblSectionDetails = new System.Windows.Forms.Label();
        cardStudentSummary = new ECMS.UI.Controls.AppCard();
        pnlStatsRow = new System.Windows.Forms.TableLayoutPanel();
        cardRemaining = new ECMS.UI.Controls.AppCard();
        lblRemainingVal = new System.Windows.Forms.Label();
        lblRemainingTitle = new System.Windows.Forms.Label();
        cardPaid = new ECMS.UI.Controls.AppCard();
        lblPaidVal = new System.Windows.Forms.Label();
        lblPaidTitle = new System.Windows.Forms.Label();
        cardTotal = new ECMS.UI.Controls.AppCard();
        lblTotalVal = new System.Windows.Forms.Label();
        lblTotalTitle = new System.Windows.Forms.Label();
        lblClassInfo = new System.Windows.Forms.Label();
        cboStudentSelect = new System.Windows.Forms.ComboBox();
        lblStudentTitle = new System.Windows.Forms.Label();
        lblSectionStudent = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        chkPrintReceipt = new System.Windows.Forms.CheckBox();
        btnConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardPaymentDetails.SuspendLayout();
        pnlMethod.SuspendLayout();
        cardStudentSummary.SuspendLayout();
        pnlStatsRow.SuspendLayout();
        cardRemaining.SuspendLayout();
        cardPaid.SuspendLayout();
        cardTotal.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblReceiptNo);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(860, 68);
        pnlHeader.TabIndex = 0;
        // 
        // lblReceiptNo
        // 
        lblReceiptNo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblReceiptNo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
        lblReceiptNo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblReceiptNo.Location = new System.Drawing.Point(540, 22);
        lblReceiptNo.Name = "lblReceiptNo";
        lblReceiptNo.Size = new System.Drawing.Size(296, 26);
        lblReceiptNo.TabIndex = 1;
        lblReceiptNo.Text = "Mã phiếu: PT-261116-015";
        lblReceiptNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(20, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(261, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Lập phiếu thu học phí";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlBody.Controls.Add(cardPaymentDetails);
        pnlBody.Controls.Add(cardStudentSummary);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 68);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
        pnlBody.Size = new System.Drawing.Size(860, 526);
        pnlBody.TabIndex = 1;
        // 
        // cardPaymentDetails
        // 
        cardPaymentDetails.BackColor = System.Drawing.Color.White;
        cardPaymentDetails.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPaymentDetails.BorderWidth = 1;
        cardPaymentDetails.Controls.Add(txtNote);
        cardPaymentDetails.Controls.Add(lblNoteTitle);
        cardPaymentDetails.Controls.Add(txtReference);
        cardPaymentDetails.Controls.Add(lblRefTitle);
        cardPaymentDetails.Controls.Add(pnlMethod);
        cardPaymentDetails.Controls.Add(lblMethodTitle);
        cardPaymentDetails.Controls.Add(lblAmountWords);
        cardPaymentDetails.Controls.Add(cboInstallmentPlan);
        cardPaymentDetails.Controls.Add(txtAmount);
        cardPaymentDetails.Controls.Add(lblAmountTitle);
        cardPaymentDetails.Controls.Add(dtpPaymentDate);
        cardPaymentDetails.Controls.Add(lblPaymentDateTitle);
        cardPaymentDetails.Controls.Add(cboPaymentType);
        cardPaymentDetails.Controls.Add(lblPaymentTypeTitle);
        cardPaymentDetails.Controls.Add(lblSectionDetails);
        cardPaymentDetails.CornerRadius = 6;
        cardPaymentDetails.Dock = System.Windows.Forms.DockStyle.Top;
        cardPaymentDetails.Location = new System.Drawing.Point(20, 184);
        cardPaymentDetails.Name = "cardPaymentDetails";
        cardPaymentDetails.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
        cardPaymentDetails.Size = new System.Drawing.Size(820, 328);
        cardPaymentDetails.TabIndex = 1;
        // 
        // txtNote
        // 
        txtNote.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNote.Location = new System.Drawing.Point(145, 282);
        txtNote.Name = "txtNote";
        txtNote.Size = new System.Drawing.Size(650, 29);
        txtNote.TabIndex = 16;
        txtNote.Text = "Thu học phí đợt 2 - IELTS Foundation";
        // 
        // lblNoteTitle
        // 
        lblNoteTitle.AutoSize = true;
        lblNoteTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNoteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblNoteTitle.Location = new System.Drawing.Point(18, 286);
        lblNoteTitle.Name = "lblNoteTitle";
        lblNoteTitle.Size = new System.Drawing.Size(74, 20);
        lblNoteTitle.TabIndex = 15;
        lblNoteTitle.Text = "Diễn giải:";
        // 
        // txtReference
        // 
        txtReference.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtReference.Location = new System.Drawing.Point(145, 238);
        txtReference.Name = "txtReference";
        txtReference.PlaceholderText = "Nhập mã giao dịch ngân hàng / số biên nhận POS (nếu có)";
        txtReference.Size = new System.Drawing.Size(650, 29);
        txtReference.TabIndex = 14;
        // 
        // lblRefTitle
        // 
        lblRefTitle.AutoSize = true;
        lblRefTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRefTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblRefTitle.Location = new System.Drawing.Point(18, 242);
        lblRefTitle.Name = "lblRefTitle";
        lblRefTitle.Size = new System.Drawing.Size(102, 20);
        lblRefTitle.TabIndex = 13;
        lblRefTitle.Text = "Mã giao dịch:";
        // 
        // pnlMethod
        // 
        pnlMethod.Controls.Add(rbPos);
        pnlMethod.Controls.Add(rbCash);
        pnlMethod.Controls.Add(rbVietQR);
        pnlMethod.Location = new System.Drawing.Point(145, 194);
        pnlMethod.Name = "pnlMethod";
        pnlMethod.Size = new System.Drawing.Size(650, 32);
        pnlMethod.TabIndex = 12;
        // 
        // rbPos
        // 
        rbPos.AutoSize = true;
        rbPos.Cursor = System.Windows.Forms.Cursors.Hand;
        rbPos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        rbPos.Location = new System.Drawing.Point(400, 3);
        rbPos.Name = "rbPos";
        rbPos.Size = new System.Drawing.Size(164, 25);
        rbPos.TabIndex = 2;
        rbPos.Text = "Thẻ POS / Quẹt thẻ";
        rbPos.UseVisualStyleBackColor = true;
        // 
        // rbCash
        // 
        rbCash.AutoSize = true;
        rbCash.Cursor = System.Windows.Forms.Cursors.Hand;
        rbCash.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        rbCash.Location = new System.Drawing.Point(235, 3);
        rbCash.Name = "rbCash";
        rbCash.Size = new System.Drawing.Size(139, 25);
        rbCash.TabIndex = 1;
        rbCash.Text = "Tiền mặt (quầy)";
        rbCash.UseVisualStyleBackColor = true;
        // 
        // rbVietQR
        // 
        rbVietQR.AutoSize = true;
        rbVietQR.Checked = true;
        rbVietQR.Cursor = System.Windows.Forms.Cursors.Hand;
        rbVietQR.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        rbVietQR.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        rbVietQR.Location = new System.Drawing.Point(3, 3);
        rbVietQR.Name = "rbVietQR";
        rbVietQR.Size = new System.Drawing.Size(198, 25);
        rbVietQR.TabIndex = 0;
        rbVietQR.TabStop = true;
        rbVietQR.Text = "Chuyển khoản VietQR";
        rbVietQR.UseVisualStyleBackColor = true;
        // 
        // lblMethodTitle
        // 
        lblMethodTitle.AutoSize = true;
        lblMethodTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMethodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblMethodTitle.Location = new System.Drawing.Point(18, 198);
        lblMethodTitle.Name = "lblMethodTitle";
        lblMethodTitle.Size = new System.Drawing.Size(104, 20);
        lblMethodTitle.TabIndex = 11;
        lblMethodTitle.Text = "Phương thức:";
        // 
        // lblAmountWords
        // 
        lblAmountWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblAmountWords.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblAmountWords.Location = new System.Drawing.Point(145, 160);
        lblAmountWords.Name = "lblAmountWords";
        lblAmountWords.Size = new System.Drawing.Size(650, 22);
        lblAmountWords.TabIndex = 10;
        lblAmountWords.Text = "Bằng chữ: Ba triệu bốn trăm nghìn đồng chẵn";
        // 
        // cboInstallmentPlan
        // 
        cboInstallmentPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboInstallmentPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboInstallmentPlan.FormattingEnabled = true;
        cboInstallmentPlan.Location = new System.Drawing.Point(420, 116);
        cboInstallmentPlan.Name = "cboInstallmentPlan";
        cboInstallmentPlan.Size = new System.Drawing.Size(375, 29);
        cboInstallmentPlan.TabIndex = 8;
        // 
        // txtAmount
        // 
        txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        txtAmount.Location = new System.Drawing.Point(145, 116);
        txtAmount.Name = "txtAmount";
        txtAmount.Size = new System.Drawing.Size(260, 34);
        txtAmount.TabIndex = 7;
        txtAmount.Text = "3.400.000 đ";
        // 
        // lblAmountTitle
        // 
        lblAmountTitle.AutoSize = true;
        lblAmountTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblAmountTitle.Location = new System.Drawing.Point(18, 122);
        lblAmountTitle.Name = "lblAmountTitle";
        lblAmountTitle.Size = new System.Drawing.Size(112, 20);
        lblAmountTitle.TabIndex = 6;
        lblAmountTitle.Text = "Số tiền thu (*):";
        // 
        // dtpPaymentDate
        // 
        dtpPaymentDate.CustomFormat = "dd/MM/yyyy";
        dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpPaymentDate.Location = new System.Drawing.Point(145, 73);
        dtpPaymentDate.Name = "dtpPaymentDate";
        dtpPaymentDate.Size = new System.Drawing.Size(150, 29);
        dtpPaymentDate.TabIndex = 4;
        // 
        // lblPaymentDateTitle
        // 
        lblPaymentDateTitle.AutoSize = true;
        lblPaymentDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblPaymentDateTitle.Location = new System.Drawing.Point(18, 77);
        lblPaymentDateTitle.Name = "lblPaymentDateTitle";
        lblPaymentDateTitle.Size = new System.Drawing.Size(78, 20);
        lblPaymentDateTitle.TabIndex = 3;
        lblPaymentDateTitle.Text = "Ngày thu:";
        // 
        // cboPaymentType
        // 
        cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboPaymentType.FormattingEnabled = true;
        cboPaymentType.Location = new System.Drawing.Point(145, 33);
        cboPaymentType.Name = "cboPaymentType";
        cboPaymentType.Size = new System.Drawing.Size(650, 29);
        cboPaymentType.TabIndex = 2;
        // 
        // lblPaymentTypeTitle
        // 
        lblPaymentTypeTitle.AutoSize = true;
        lblPaymentTypeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblPaymentTypeTitle.Location = new System.Drawing.Point(18, 37);
        lblPaymentTypeTitle.Name = "lblPaymentTypeTitle";
        lblPaymentTypeTitle.Size = new System.Drawing.Size(120, 20);
        lblPaymentTypeTitle.TabIndex = 1;
        lblPaymentTypeTitle.Text = "Khoản mục thu:";
        // 
        // lblSectionDetails
        // 
        lblSectionDetails.AutoSize = true;
        lblSectionDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblSectionDetails.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSectionDetails.Location = new System.Drawing.Point(4, 5);
        lblSectionDetails.Name = "lblSectionDetails";
        lblSectionDetails.Size = new System.Drawing.Size(216, 23);
        lblSectionDetails.TabIndex = 0;
        lblSectionDetails.Text = "2. CHI TIẾT THANH TOÁN";
        // 
        // cardStudentSummary
        // 
        cardStudentSummary.BackColor = System.Drawing.Color.White;
        cardStudentSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentSummary.BorderWidth = 1;
        cardStudentSummary.Controls.Add(pnlStatsRow);
        cardStudentSummary.Controls.Add(lblClassInfo);
        cardStudentSummary.Controls.Add(cboStudentSelect);
        cardStudentSummary.Controls.Add(lblStudentTitle);
        cardStudentSummary.Controls.Add(lblSectionStudent);
        cardStudentSummary.CornerRadius = 6;
        cardStudentSummary.Dock = System.Windows.Forms.DockStyle.Top;
        cardStudentSummary.Location = new System.Drawing.Point(20, 14);
        cardStudentSummary.Name = "cardStudentSummary";
        cardStudentSummary.Padding = new System.Windows.Forms.Padding(18, 12, 18, 14);
        cardStudentSummary.Size = new System.Drawing.Size(820, 170);
        cardStudentSummary.TabIndex = 0;
        // 
        // pnlStatsRow
        // 
        pnlStatsRow.ColumnCount = 3;
        pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        pnlStatsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        pnlStatsRow.Controls.Add(cardRemaining, 2, 0);
        pnlStatsRow.Controls.Add(cardPaid, 1, 0);
        pnlStatsRow.Controls.Add(cardTotal, 0, 0);
        pnlStatsRow.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlStatsRow.Location = new System.Drawing.Point(18, 92);
        pnlStatsRow.Name = "pnlStatsRow";
        pnlStatsRow.RowCount = 1;
        pnlStatsRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlStatsRow.Size = new System.Drawing.Size(784, 64);
        pnlStatsRow.TabIndex = 4;
        // 
        // cardRemaining
        // 
        cardRemaining.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)242)), ((int)((byte)242)));
        cardRemaining.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)202)), ((int)((byte)202)));
        cardRemaining.BorderWidth = 1;
        cardRemaining.Controls.Add(lblRemainingVal);
        cardRemaining.Controls.Add(lblRemainingTitle);
        cardRemaining.CornerRadius = 5;
        cardRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRemaining.Location = new System.Drawing.Point(525, 3);
        cardRemaining.Name = "cardRemaining";
        cardRemaining.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        cardRemaining.Size = new System.Drawing.Size(256, 58);
        cardRemaining.TabIndex = 2;
        // 
        // lblRemainingVal
        // 
        lblRemainingVal.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblRemainingVal.Location = new System.Drawing.Point(10, 27);
        lblRemainingVal.Name = "lblRemainingVal";
        lblRemainingVal.Size = new System.Drawing.Size(236, 25);
        lblRemainingVal.TabIndex = 1;
        lblRemainingVal.Text = "3.400.000 đ";
        lblRemainingVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblRemainingTitle
        // 
        lblRemainingTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        lblRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)185)), ((int)((byte)28)), ((int)((byte)28)));
        lblRemainingTitle.Location = new System.Drawing.Point(10, 6);
        lblRemainingTitle.Name = "lblRemainingTitle";
        lblRemainingTitle.Size = new System.Drawing.Size(236, 20);
        lblRemainingTitle.TabIndex = 0;
        lblRemainingTitle.Text = "SỐ TIỀN CÒN NỢ";
        // 
        // cardPaid
        // 
        cardPaid.BackColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)253)), ((int)((byte)244)));
        cardPaid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)187)), ((int)((byte)247)), ((int)((byte)208)));
        cardPaid.BorderWidth = 1;
        cardPaid.Controls.Add(lblPaidVal);
        cardPaid.Controls.Add(lblPaidTitle);
        cardPaid.CornerRadius = 5;
        cardPaid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardPaid.Location = new System.Drawing.Point(264, 3);
        cardPaid.Name = "cardPaid";
        cardPaid.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        cardPaid.Size = new System.Drawing.Size(255, 58);
        cardPaid.TabIndex = 1;
        // 
        // lblPaidVal
        // 
        lblPaidVal.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblPaidVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblPaidVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblPaidVal.Location = new System.Drawing.Point(10, 27);
        lblPaidVal.Name = "lblPaidVal";
        lblPaidVal.Size = new System.Drawing.Size(235, 25);
        lblPaidVal.TabIndex = 1;
        lblPaidVal.Text = "2.000.000 đ";
        lblPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblPaidTitle
        // 
        lblPaidTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblPaidTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        lblPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)21)), ((int)((byte)128)), ((int)((byte)61)));
        lblPaidTitle.Location = new System.Drawing.Point(10, 6);
        lblPaidTitle.Name = "lblPaidTitle";
        lblPaidTitle.Size = new System.Drawing.Size(235, 20);
        lblPaidTitle.TabIndex = 0;
        lblPaidTitle.Text = "ĐÃ THANH TOÁN";
        // 
        // cardTotal
        // 
        cardTotal.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        cardTotal.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)191)), ((int)((byte)219)), ((int)((byte)254)));
        cardTotal.BorderWidth = 1;
        cardTotal.Controls.Add(lblTotalVal);
        cardTotal.Controls.Add(lblTotalTitle);
        cardTotal.CornerRadius = 5;
        cardTotal.Dock = System.Windows.Forms.DockStyle.Fill;
        cardTotal.Location = new System.Drawing.Point(3, 3);
        cardTotal.Name = "cardTotal";
        cardTotal.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        cardTotal.Size = new System.Drawing.Size(255, 58);
        cardTotal.TabIndex = 0;
        // 
        // lblTotalVal
        // 
        lblTotalVal.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblTotalVal.Location = new System.Drawing.Point(10, 27);
        lblTotalVal.Name = "lblTotalVal";
        lblTotalVal.Size = new System.Drawing.Size(235, 25);
        lblTotalVal.TabIndex = 1;
        lblTotalVal.Text = "5.400.000 đ";
        lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTotalTitle
        // 
        lblTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblTotalTitle.Location = new System.Drawing.Point(10, 6);
        lblTotalTitle.Name = "lblTotalTitle";
        lblTotalTitle.Size = new System.Drawing.Size(235, 20);
        lblTotalTitle.TabIndex = 0;
        lblTotalTitle.Text = "TỔNG HỌC PHÍ";
        // 
        // lblClassInfo
        // 
        lblClassInfo.AutoSize = true;
        lblClassInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblClassInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblClassInfo.Location = new System.Drawing.Point(475, 48);
        lblClassInfo.Name = "lblClassInfo";
        lblClassInfo.Size = new System.Drawing.Size(314, 21);
        lblClassInfo.TabIndex = 3;
        lblClassInfo.Text = "Khóa / Lớp: IELTS Foundation · IELTS-F01";
        // 
        // cboStudentSelect
        // 
        cboStudentSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboStudentSelect.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStudentSelect.FormattingEnabled = true;
        cboStudentSelect.Location = new System.Drawing.Point(145, 44);
        cboStudentSelect.Name = "cboStudentSelect";
        cboStudentSelect.Size = new System.Drawing.Size(315, 29);
        cboStudentSelect.TabIndex = 2;
        // 
        // lblStudentTitle
        // 
        lblStudentTitle.AutoSize = true;
        lblStudentTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStudentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblStudentTitle.Location = new System.Drawing.Point(18, 48);
        lblStudentTitle.Name = "lblStudentTitle";
        lblStudentTitle.Size = new System.Drawing.Size(111, 20);
        lblStudentTitle.TabIndex = 1;
        lblStudentTitle.Text = "Chọn học viên:";
        // 
        // lblSectionStudent
        // 
        lblSectionStudent.AutoSize = true;
        lblSectionStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblSectionStudent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSectionStudent.Location = new System.Drawing.Point(4, 8);
        lblSectionStudent.Name = "lblSectionStudent";
        lblSectionStudent.Size = new System.Drawing.Size(299, 23);
        lblSectionStudent.TabIndex = 0;
        lblSectionStudent.Text = "1. THÔNG TIN HỌC VIÊN & CÔNG NỢ";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(chkPrintReceipt);
        pnlFooter.Controls.Add(btnConfirm);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 594);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
        pnlFooter.Size = new System.Drawing.Size(860, 66);
        pnlFooter.TabIndex = 2;
        // 
        // chkPrintReceipt
        // 
        chkPrintReceipt.AutoSize = true;
        chkPrintReceipt.Checked = true;
        chkPrintReceipt.CheckState = System.Windows.Forms.CheckState.Checked;
        chkPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
        chkPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        chkPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        chkPrintReceipt.Location = new System.Drawing.Point(24, 21);
        chkPrintReceipt.Name = "chkPrintReceipt";
        chkPrintReceipt.Size = new System.Drawing.Size(356, 24);
        chkPrintReceipt.TabIndex = 2;
        chkPrintReceipt.Text = "Mở xem trước và in phiếu thu ngay sau khi lưu";
        chkPrintReceipt.UseVisualStyleBackColor = true;
        // 
        // btnConfirm
        // 
        btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirm.CornerRadius = 5;
        btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirm.ForeColor = System.Drawing.Color.White;
        btnConfirm.Location = new System.Drawing.Point(670, 14);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new System.Drawing.Size(166, 38);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Xác nhận";
        btnConfirm.UseVisualStyleBackColor = false;
        btnConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancel.Location = new System.Drawing.Point(565, 14);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 38);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // CollectTuitionDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(860, 660);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thu học phí · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardPaymentDetails.ResumeLayout(false);
        cardPaymentDetails.PerformLayout();
        pnlMethod.ResumeLayout(false);
        pnlMethod.PerformLayout();
        cardStudentSummary.ResumeLayout(false);
        cardStudentSummary.PerformLayout();
        pnlStatsRow.ResumeLayout(false);
        cardRemaining.ResumeLayout(false);
        cardPaid.ResumeLayout(false);
        cardTotal.ResumeLayout(false);
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblReceiptNo;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStudentSummary;
    private System.Windows.Forms.Label lblSectionStudent;
    private System.Windows.Forms.Label lblStudentTitle;
    private System.Windows.Forms.ComboBox cboStudentSelect;
    private System.Windows.Forms.Label lblClassInfo;
    private System.Windows.Forms.TableLayoutPanel pnlStatsRow;
    private ECMS.UI.Controls.AppCard cardTotal;
    private System.Windows.Forms.Label lblTotalTitle;
    private System.Windows.Forms.Label lblTotalVal;
    private ECMS.UI.Controls.AppCard cardPaid;
    private System.Windows.Forms.Label lblPaidTitle;
    private System.Windows.Forms.Label lblPaidVal;
    private ECMS.UI.Controls.AppCard cardRemaining;
    private System.Windows.Forms.Label lblRemainingTitle;
    private System.Windows.Forms.Label lblRemainingVal;
    private ECMS.UI.Controls.AppCard cardPaymentDetails;
    private System.Windows.Forms.Label lblSectionDetails;
    private System.Windows.Forms.Label lblPaymentTypeTitle;
    private System.Windows.Forms.ComboBox cboPaymentType;
    private System.Windows.Forms.Label lblPaymentDateTitle;
    private System.Windows.Forms.DateTimePicker dtpPaymentDate;
    private System.Windows.Forms.Label lblAmountTitle;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.ComboBox cboInstallmentPlan;
    private System.Windows.Forms.Label lblAmountWords;
    private System.Windows.Forms.Label lblMethodTitle;
    private System.Windows.Forms.Panel pnlMethod;
    private System.Windows.Forms.RadioButton rbVietQR;
    private System.Windows.Forms.RadioButton rbCash;
    private System.Windows.Forms.RadioButton rbPos;
    private System.Windows.Forms.Label lblRefTitle;
    private System.Windows.Forms.TextBox txtReference;
    private System.Windows.Forms.Label lblNoteTitle;
    private System.Windows.Forms.TextBox txtNote;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.CheckBox chkPrintReceipt;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnConfirm;
}
