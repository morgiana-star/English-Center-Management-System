namespace ECMS.UI.Forms;

partial class PaymentConfirmDialog
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        cardLeftInfo = new ECMS.UI.Controls.AppCard();
        lblCardLeftTitle = new System.Windows.Forms.Label();
        lblReceiptCodeVal = new System.Windows.Forms.Label();
        lblReceiptCodeTitle = new System.Windows.Forms.Label();
        lblTransCodeVal = new System.Windows.Forms.Label();
        lblTransCodeTitle = new System.Windows.Forms.Label();
        lblMethodVal = new System.Windows.Forms.Label();
        lblMethodTitle = new System.Windows.Forms.Label();
        lblDateVal = new System.Windows.Forms.Label();
        lblDateTitle = new System.Windows.Forms.Label();
        lblClassVal = new System.Windows.Forms.Label();
        lblClassTitle = new System.Windows.Forms.Label();
        lblStudentVal = new System.Windows.Forms.Label();
        lblStudentTitle = new System.Windows.Forms.Label();
        cardRightBalance = new ECMS.UI.Controls.AppCard();
        lblCardRightTitle = new System.Windows.Forms.Label();
        lblNewDebtVal = new System.Windows.Forms.Label();
        lblNewDebtTitle = new System.Windows.Forms.Label();
        lblNewPaidVal = new System.Windows.Forms.Label();
        lblNewPaidTitle = new System.Windows.Forms.Label();
        pnlHighlightAmount = new System.Windows.Forms.Panel();
        lblHighlightVal = new System.Windows.Forms.Label();
        lblHighlightTitle = new System.Windows.Forms.Label();
        lblPrevDebtVal = new System.Windows.Forms.Label();
        lblPrevDebtTitle = new System.Windows.Forms.Label();
        lblPrevPaidVal = new System.Windows.Forms.Label();
        lblPrevPaidTitle = new System.Windows.Forms.Label();
        lblNetTuitionVal = new System.Windows.Forms.Label();
        lblNetTuitionTitle = new System.Windows.Forms.Label();
        pnlCommitment = new System.Windows.Forms.Panel();
        chkCommitment = new System.Windows.Forms.CheckBox();
        pnlActions = new System.Windows.Forms.FlowLayoutPanel();
        btnConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardLeftInfo.SuspendLayout();
        cardRightBalance.SuspendLayout();
        pnlHighlightAmount.SuspendLayout();
        pnlCommitment.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 10);
        pnlHeader.Size = new System.Drawing.Size(840, 85);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(24, 49);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(422, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Kiểm tra đối soát các chỉ số tài chính trước khi thực hiện ghi sổ";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(314, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Xác nhận thu 1.500.000đ?";
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        pnlBody.Controls.Add(cardLeftInfo, 0, 0);
        pnlBody.Controls.Add(cardRightBalance, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 85);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 8);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(840, 365);
        pnlBody.TabIndex = 1;
        // 
        // cardLeftInfo
        // 
        cardLeftInfo.BackColor = System.Drawing.Color.White;
        cardLeftInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardLeftInfo.BorderWidth = 1;
        cardLeftInfo.Controls.Add(lblCardLeftTitle);
        cardLeftInfo.Controls.Add(lblReceiptCodeVal);
        cardLeftInfo.Controls.Add(lblReceiptCodeTitle);
        cardLeftInfo.Controls.Add(lblTransCodeVal);
        cardLeftInfo.Controls.Add(lblTransCodeTitle);
        cardLeftInfo.Controls.Add(lblMethodVal);
        cardLeftInfo.Controls.Add(lblMethodTitle);
        cardLeftInfo.Controls.Add(lblDateVal);
        cardLeftInfo.Controls.Add(lblDateTitle);
        cardLeftInfo.Controls.Add(lblClassVal);
        cardLeftInfo.Controls.Add(lblClassTitle);
        cardLeftInfo.Controls.Add(lblStudentVal);
        cardLeftInfo.Controls.Add(lblStudentTitle);
        cardLeftInfo.CornerRadius = 6;
        cardLeftInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        cardLeftInfo.Location = new System.Drawing.Point(23, 15);
        cardLeftInfo.Name = "cardLeftInfo";
        cardLeftInfo.Padding = new System.Windows.Forms.Padding(16);
        cardLeftInfo.Size = new System.Drawing.Size(394, 339);
        cardLeftInfo.TabIndex = 0;
        // 
        // lblCardLeftTitle
        // 
        lblCardLeftTitle.AutoSize = true;
        lblCardLeftTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblCardLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCardLeftTitle.Location = new System.Drawing.Point(16, 12);
        lblCardLeftTitle.Name = "lblCardLeftTitle";
        lblCardLeftTitle.Size = new System.Drawing.Size(178, 25);
        lblCardLeftTitle.TabIndex = 12;
        lblCardLeftTitle.Text = "Thông tin giao dịch";
        // 
        // lblReceiptCodeVal
        // 
        lblReceiptCodeVal.AutoSize = true;
        lblReceiptCodeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblReceiptCodeVal.Location = new System.Drawing.Point(130, 220);
        lblReceiptCodeVal.Name = "lblReceiptCodeVal";
        lblReceiptCodeVal.Size = new System.Drawing.Size(120, 20);
        lblReceiptCodeVal.TabIndex = 11;
        lblReceiptCodeVal.Text = "PT-261030-018";
        // 
        // lblReceiptCodeTitle
        // 
        lblReceiptCodeTitle.AutoSize = true;
        lblReceiptCodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblReceiptCodeTitle.Location = new System.Drawing.Point(16, 220);
        lblReceiptCodeTitle.Name = "lblReceiptCodeTitle";
        lblReceiptCodeTitle.Size = new System.Drawing.Size(126, 20);
        lblReceiptCodeTitle.TabIndex = 10;
        lblReceiptCodeTitle.Text = "Phiếu thu dự kiến:";
        // 
        // lblTransCodeVal
        // 
        lblTransCodeVal.AutoSize = true;
        lblTransCodeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTransCodeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblTransCodeVal.Location = new System.Drawing.Point(130, 185);
        lblTransCodeVal.Name = "lblTransCodeVal";
        lblTransCodeVal.Size = new System.Drawing.Size(124, 20);
        lblTransCodeVal.TabIndex = 9;
        lblTransCodeVal.Text = "GD-261030-018";
        // 
        // lblTransCodeTitle
        // 
        lblTransCodeTitle.AutoSize = true;
        lblTransCodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTransCodeTitle.Location = new System.Drawing.Point(16, 185);
        lblTransCodeTitle.Name = "lblTransCodeTitle";
        lblTransCodeTitle.Size = new System.Drawing.Size(99, 20);
        lblTransCodeTitle.TabIndex = 8;
        lblTransCodeTitle.Text = "Mã giao dịch:";
        // 
        // lblMethodVal
        // 
        lblMethodVal.AutoSize = true;
        lblMethodVal.Location = new System.Drawing.Point(130, 150);
        lblMethodVal.Name = "lblMethodVal";
        lblMethodVal.Size = new System.Drawing.Size(194, 20);
        lblMethodVal.TabIndex = 7;
        lblMethodVal.Text = "Chuyển khoản (CK3010-MA)";
        // 
        // lblMethodTitle
        // 
        lblMethodTitle.AutoSize = true;
        lblMethodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblMethodTitle.Location = new System.Drawing.Point(16, 150);
        lblMethodTitle.Name = "lblMethodTitle";
        lblMethodTitle.Size = new System.Drawing.Size(76, 20);
        lblMethodTitle.TabIndex = 6;
        lblMethodTitle.Text = "Hình thức:";
        // 
        // lblDateVal
        // 
        lblDateVal.AutoSize = true;
        lblDateVal.Location = new System.Drawing.Point(130, 115);
        lblDateVal.Name = "lblDateVal";
        lblDateVal.Size = new System.Drawing.Size(85, 20);
        lblDateVal.TabIndex = 5;
        lblDateVal.Text = "30/10/2026";
        // 
        // lblDateTitle
        // 
        lblDateTitle.AutoSize = true;
        lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDateTitle.Location = new System.Drawing.Point(16, 115);
        lblDateTitle.Name = "lblDateTitle";
        lblDateTitle.Size = new System.Drawing.Size(72, 20);
        lblDateTitle.TabIndex = 4;
        lblDateTitle.Text = "Ngày thu:";
        // 
        // lblClassVal
        // 
        lblClassVal.AutoSize = true;
        lblClassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClassVal.Location = new System.Drawing.Point(130, 80);
        lblClassVal.Name = "lblClassVal";
        lblClassVal.Size = new System.Drawing.Size(174, 20);
        lblClassVal.TabIndex = 3;
        lblClassVal.Text = "IELTS-F01 (Foundation)";
        // 
        // lblClassTitle
        // 
        lblClassTitle.AutoSize = true;
        lblClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblClassTitle.Location = new System.Drawing.Point(16, 80);
        lblClassTitle.Name = "lblClassTitle";
        lblClassTitle.Size = new System.Drawing.Size(65, 20);
        lblClassTitle.TabIndex = 2;
        lblClassTitle.Text = "Lớp học:";
        // 
        // lblStudentVal
        // 
        lblStudentVal.AutoSize = true;
        lblStudentVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStudentVal.Location = new System.Drawing.Point(130, 45);
        lblStudentVal.Name = "lblStudentVal";
        lblStudentVal.Size = new System.Drawing.Size(212, 20);
        lblStudentVal.TabIndex = 1;
        lblStudentVal.Text = "Nguyễn Minh Anh · HV-0241";
        // 
        // lblStudentTitle
        // 
        lblStudentTitle.AutoSize = true;
        lblStudentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentTitle.Location = new System.Drawing.Point(16, 45);
        lblStudentTitle.Name = "lblStudentTitle";
        lblStudentTitle.Size = new System.Drawing.Size(70, 20);
        lblStudentTitle.TabIndex = 0;
        lblStudentTitle.Text = "Học viên:";
        // 
        // cardRightBalance
        // 
        cardRightBalance.BackColor = System.Drawing.Color.White;
        cardRightBalance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRightBalance.BorderWidth = 1;
        cardRightBalance.Controls.Add(lblCardRightTitle);
        cardRightBalance.Controls.Add(lblNewDebtVal);
        cardRightBalance.Controls.Add(lblNewDebtTitle);
        cardRightBalance.Controls.Add(lblNewPaidVal);
        cardRightBalance.Controls.Add(lblNewPaidTitle);
        cardRightBalance.Controls.Add(pnlHighlightAmount);
        cardRightBalance.Controls.Add(lblPrevDebtVal);
        cardRightBalance.Controls.Add(lblPrevDebtTitle);
        cardRightBalance.Controls.Add(lblPrevPaidVal);
        cardRightBalance.Controls.Add(lblPrevPaidTitle);
        cardRightBalance.Controls.Add(lblNetTuitionVal);
        cardRightBalance.Controls.Add(lblNetTuitionTitle);
        cardRightBalance.CornerRadius = 6;
        cardRightBalance.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRightBalance.Location = new System.Drawing.Point(423, 15);
        cardRightBalance.Name = "cardRightBalance";
        cardRightBalance.Padding = new System.Windows.Forms.Padding(16);
        cardRightBalance.Size = new System.Drawing.Size(394, 339);
        cardRightBalance.TabIndex = 1;
        // 
        // lblCardRightTitle
        // 
        lblCardRightTitle.AutoSize = true;
        lblCardRightTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblCardRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCardRightTitle.Location = new System.Drawing.Point(16, 12);
        lblCardRightTitle.Name = "lblCardRightTitle";
        lblCardRightTitle.Size = new System.Drawing.Size(223, 25);
        lblCardRightTitle.TabIndex = 11;
        lblCardRightTitle.Text = "Đối soát cân đối công nợ";
        // 
        // lblNewDebtVal
        // 
        lblNewDebtVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNewDebtVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblNewDebtVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblNewDebtVal.Location = new System.Drawing.Point(200, 226);
        lblNewDebtVal.Name = "lblNewDebtVal";
        lblNewDebtVal.Size = new System.Drawing.Size(178, 20);
        lblNewDebtVal.TabIndex = 10;
        lblNewDebtVal.Text = "1.900.000đ (15/11)";
        lblNewDebtVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNewDebtTitle
        // 
        lblNewDebtTitle.AutoSize = true;
        lblNewDebtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNewDebtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblNewDebtTitle.Location = new System.Drawing.Point(16, 226);
        lblNewDebtTitle.Name = "lblNewDebtTitle";
        lblNewDebtTitle.Size = new System.Drawing.Size(118, 20);
        lblNewDebtTitle.TabIndex = 9;
        lblNewDebtTitle.Text = "Còn nợ sau thu:";
        // 
        // lblNewPaidVal
        // 
        lblNewPaidVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNewPaidVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblNewPaidVal.Location = new System.Drawing.Point(230, 198);
        lblNewPaidVal.Name = "lblNewPaidVal";
        lblNewPaidVal.Size = new System.Drawing.Size(148, 18);
        lblNewPaidVal.TabIndex = 8;
        lblNewPaidVal.Text = "3.500.000đ";
        lblNewPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNewPaidTitle
        // 
        lblNewPaidTitle.AutoSize = true;
        lblNewPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNewPaidTitle.Location = new System.Drawing.Point(16, 198);
        lblNewPaidTitle.Name = "lblNewPaidTitle";
        lblNewPaidTitle.Size = new System.Drawing.Size(118, 20);
        lblNewPaidTitle.TabIndex = 7;
        lblNewPaidTitle.Text = "Tổng đã thu sau:";
        // 
        // pnlHighlightAmount
        // 
        pnlHighlightAmount.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        pnlHighlightAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlHighlightAmount.Controls.Add(lblHighlightVal);
        pnlHighlightAmount.Controls.Add(lblHighlightTitle);
        pnlHighlightAmount.Location = new System.Drawing.Point(16, 122);
        pnlHighlightAmount.Name = "pnlHighlightAmount";
        pnlHighlightAmount.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
        pnlHighlightAmount.Size = new System.Drawing.Size(362, 64);
        pnlHighlightAmount.TabIndex = 6;
        // 
        // lblHighlightVal
        // 
        lblHighlightVal.Dock = System.Windows.Forms.DockStyle.Fill;
        lblHighlightVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblHighlightVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblHighlightVal.Location = new System.Drawing.Point(12, 24);
        lblHighlightVal.Name = "lblHighlightVal";
        lblHighlightVal.Size = new System.Drawing.Size(336, 30);
        lblHighlightVal.TabIndex = 1;
        lblHighlightVal.Text = "1.500.000 đ";
        lblHighlightVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblHighlightTitle
        // 
        lblHighlightTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblHighlightTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblHighlightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)64)), ((int)((byte)175)));
        lblHighlightTitle.Location = new System.Drawing.Point(12, 8);
        lblHighlightTitle.Name = "lblHighlightTitle";
        lblHighlightTitle.Size = new System.Drawing.Size(336, 16);
        lblHighlightTitle.TabIndex = 0;
        lblHighlightTitle.Text = "SỐ TIỀN THU ĐỢT NÀY";
        // 
        // lblPrevDebtVal
        // 
        lblPrevDebtVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPrevDebtVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPrevDebtVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblPrevDebtVal.Location = new System.Drawing.Point(230, 94);
        lblPrevDebtVal.Name = "lblPrevDebtVal";
        lblPrevDebtVal.Size = new System.Drawing.Size(148, 16);
        lblPrevDebtVal.TabIndex = 5;
        lblPrevDebtVal.Text = "3.400.000đ";
        lblPrevDebtVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPrevDebtTitle
        // 
        lblPrevDebtTitle.AutoSize = true;
        lblPrevDebtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPrevDebtTitle.Location = new System.Drawing.Point(16, 94);
        lblPrevDebtTitle.Name = "lblPrevDebtTitle";
        lblPrevDebtTitle.Size = new System.Drawing.Size(132, 20);
        lblPrevDebtTitle.TabIndex = 4;
        lblPrevDebtTitle.Text = "Công nợ trước thu:";
        // 
        // lblPrevPaidVal
        // 
        lblPrevPaidVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPrevPaidVal.Location = new System.Drawing.Point(230, 68);
        lblPrevPaidVal.Name = "lblPrevPaidVal";
        lblPrevPaidVal.Size = new System.Drawing.Size(148, 16);
        lblPrevPaidVal.TabIndex = 3;
        lblPrevPaidVal.Text = "2.000.000đ";
        lblPrevPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPrevPaidTitle
        // 
        lblPrevPaidTitle.AutoSize = true;
        lblPrevPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPrevPaidTitle.Location = new System.Drawing.Point(16, 68);
        lblPrevPaidTitle.Name = "lblPrevPaidTitle";
        lblPrevPaidTitle.Size = new System.Drawing.Size(95, 20);
        lblPrevPaidTitle.TabIndex = 2;
        lblPrevPaidTitle.Text = "Đã thu trước:";
        // 
        // lblNetTuitionVal
        // 
        lblNetTuitionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNetTuitionVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNetTuitionVal.Location = new System.Drawing.Point(230, 42);
        lblNetTuitionVal.Name = "lblNetTuitionVal";
        lblNetTuitionVal.Size = new System.Drawing.Size(148, 16);
        lblNetTuitionVal.TabIndex = 1;
        lblNetTuitionVal.Text = "5.400.000đ";
        lblNetTuitionVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNetTuitionTitle
        // 
        lblNetTuitionTitle.AutoSize = true;
        lblNetTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNetTuitionTitle.Location = new System.Drawing.Point(16, 42);
        lblNetTuitionTitle.Name = "lblNetTuitionTitle";
        lblNetTuitionTitle.Size = new System.Drawing.Size(122, 20);
        lblNetTuitionTitle.TabIndex = 0;
        lblNetTuitionTitle.Text = "Học phí thực thu:";
        // 
        // pnlCommitment
        // 
        pnlCommitment.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlCommitment.Controls.Add(chkCommitment);
        pnlCommitment.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlCommitment.Location = new System.Drawing.Point(0, 450);
        pnlCommitment.Name = "pnlCommitment";
        pnlCommitment.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
        pnlCommitment.Size = new System.Drawing.Size(840, 48);
        pnlCommitment.TabIndex = 2;
        // 
        // chkCommitment
        // 
        chkCommitment.Dock = System.Windows.Forms.DockStyle.Fill;
        chkCommitment.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        chkCommitment.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        chkCommitment.Location = new System.Drawing.Point(24, 6);
        chkCommitment.Name = "chkCommitment";
        chkCommitment.Size = new System.Drawing.Size(792, 36);
        chkCommitment.TabIndex = 0;
        chkCommitment.Text = ("Tôi đã đối chiếu tiền thực nhận (tiền mặt / sao kê ngân hàng). Xác nhận sẽ ghi gi" + "ao dịch, phiếu thu và cập nhật công nợ cùng lúc.");
        chkCommitment.UseVisualStyleBackColor = true;
        // 
        // pnlActions
        // 
        pnlActions.BackColor = System.Drawing.Color.White;
        pnlActions.Controls.Add(btnConfirm);
        pnlActions.Controls.Add(btnCancel);
        pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlActions.Location = new System.Drawing.Point(0, 498);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlActions.Size = new System.Drawing.Size(840, 52);
        pnlActions.TabIndex = 3;
        // 
        // btnConfirm
        // 
        btnConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirm.CornerRadius = 5;
        btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirm.Location = new System.Drawing.Point(619, 11);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new System.Drawing.Size(170, 34);
        btnConfirm.TabIndex = 0;
        btnConfirm.Text = "Xác nhận & ghi sổ";
        btnConfirm.UseVisualStyleBackColor = true;
        btnConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(513, 11);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 34);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // PaymentConfirmDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(840, 550);
        Controls.Add(pnlBody);
        Controls.Add(pnlCommitment);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xác nhận thu học phí · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardLeftInfo.ResumeLayout(false);
        cardLeftInfo.PerformLayout();
        cardRightBalance.ResumeLayout(false);
        cardRightBalance.PerformLayout();
        pnlHighlightAmount.ResumeLayout(false);
        pnlCommitment.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private ECMS.UI.Controls.AppBanner bannerStatus;
    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private ECMS.UI.Controls.AppCard cardLeftInfo;
    private System.Windows.Forms.Label lblCardLeftTitle;
    private ECMS.UI.Controls.AppCard cardRightBalance;
    private System.Windows.Forms.Label lblCardRightTitle;

    private System.Windows.Forms.Label lblStudentTitle;
    private System.Windows.Forms.Label lblStudentVal;
    private System.Windows.Forms.Label lblClassTitle;
    private System.Windows.Forms.Label lblClassVal;
    private System.Windows.Forms.Label lblDateTitle;
    private System.Windows.Forms.Label lblDateVal;
    private System.Windows.Forms.Label lblMethodTitle;
    private System.Windows.Forms.Label lblMethodVal;
    private System.Windows.Forms.Label lblTransCodeTitle;
    private System.Windows.Forms.Label lblTransCodeVal;
    private System.Windows.Forms.Label lblReceiptCodeTitle;
    private System.Windows.Forms.Label lblReceiptCodeVal;

    private System.Windows.Forms.Label lblNetTuitionTitle;
    private System.Windows.Forms.Label lblNetTuitionVal;
    private System.Windows.Forms.Label lblPrevPaidTitle;
    private System.Windows.Forms.Label lblPrevPaidVal;
    private System.Windows.Forms.Label lblPrevDebtTitle;
    private System.Windows.Forms.Label lblPrevDebtVal;
    private System.Windows.Forms.Panel pnlHighlightAmount;
    private System.Windows.Forms.Label lblHighlightTitle;
    private System.Windows.Forms.Label lblHighlightVal;
    private System.Windows.Forms.Label lblNewPaidTitle;
    private System.Windows.Forms.Label lblNewPaidVal;
    private System.Windows.Forms.Label lblNewDebtTitle;
    private System.Windows.Forms.Label lblNewDebtVal;

    private System.Windows.Forms.Panel pnlCommitment;
    private System.Windows.Forms.CheckBox chkCommitment;
    private System.Windows.Forms.FlowLayoutPanel pnlActions;
    private ECMS.UI.Controls.AppButton btnConfirm;
    private ECMS.UI.Controls.AppButton btnCancel;
}
