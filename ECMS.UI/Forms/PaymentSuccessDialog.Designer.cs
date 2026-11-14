namespace ECMS.UI.Forms;

partial class PaymentSuccessDialog
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
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnPreviewPrint = new ECMS.UI.Controls.AppButton();
        btnBackToDebt = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        bannerSuccess = new ECMS.UI.Controls.AppBanner();
        pnlStepper = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        cardTransactionDetail = new ECMS.UI.Controls.AppCard();
        lblDetailCardTitle = new System.Windows.Forms.Label();
        btnViewPrintReceipt = new ECMS.UI.Controls.AppButton();
        lblNoteVal = new System.Windows.Forms.Label();
        lblNoteTitle = new System.Windows.Forms.Label();
        lblAmountVal = new System.Windows.Forms.Label();
        lblAmountTitle = new System.Windows.Forms.Label();
        lblMethodVal = new System.Windows.Forms.Label();
        lblMethodTitle = new System.Windows.Forms.Label();
        lblCollectorVal = new System.Windows.Forms.Label();
        lblCollectorTitle = new System.Windows.Forms.Label();
        lblReceiptCodeVal = new System.Windows.Forms.Label();
        lblReceiptCodeTitle = new System.Windows.Forms.Label();
        lblClassVal = new System.Windows.Forms.Label();
        lblClassTitle = new System.Windows.Forms.Label();
        lblStudentVal = new System.Windows.Forms.Label();
        lblStudentTitle = new System.Windows.Forms.Label();
        cardBalanceSummary = new ECMS.UI.Controls.AppCard();
        lblSummaryCardTitle = new System.Windows.Forms.Label();
        btnOpenStudentProfile = new ECMS.UI.Controls.AppButton();
        lblNextDueVal = new System.Windows.Forms.Label();
        lblNextDueTitle = new System.Windows.Forms.Label();
        lblRemainingVal = new System.Windows.Forms.Label();
        lblRemainingTitle = new System.Windows.Forms.Label();
        lblTotalPaidVal = new System.Windows.Forms.Label();
        lblTotalPaidTitle = new System.Windows.Forms.Label();
        lblNewPaidAmtVal = new System.Windows.Forms.Label();
        lblNewPaidAmtTitle = new System.Windows.Forms.Label();
        lblPrevPaidVal = new System.Windows.Forms.Label();
        lblPrevPaidTitle = new System.Windows.Forms.Label();
        lblDiscountVal = new System.Windows.Forms.Label();
        lblDiscountTitle = new System.Windows.Forms.Label();
        lblBaseTuitionVal = new System.Windows.Forms.Label();
        lblBaseTuitionTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlStepper.SuspendLayout();
        pnlBody.SuspendLayout();
        cardTransactionDetail.SuspendLayout();
        cardBalanceSummary.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(1200, 78);
        pnlHeader.TabIndex = 0;
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlTopActions.Controls.Add(btnPreviewPrint);
        pnlTopActions.Controls.Add(btnBackToDebt);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(870, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnPreviewPrint
        // 
        btnPreviewPrint.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPreviewPrint.CornerRadius = 5;
        btnPreviewPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPreviewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPreviewPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPreviewPrint.Location = new System.Drawing.Point(157, 3);
        btnPreviewPrint.Name = "btnPreviewPrint";
        btnPreviewPrint.Size = new System.Drawing.Size(140, 38);
        btnPreviewPrint.TabIndex = 0;
        btnPreviewPrint.Text = "Xem trước khi in";
        btnPreviewPrint.UseVisualStyleBackColor = true;
        btnPreviewPrint.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnBackToDebt
        // 
        btnBackToDebt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToDebt.CornerRadius = 5;
        btnBackToDebt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToDebt.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackToDebt.Location = new System.Drawing.Point(41, 3);
        btnBackToDebt.Name = "btnBackToDebt";
        btnBackToDebt.Size = new System.Drawing.Size(110, 38);
        btnBackToDebt.TabIndex = 1;
        btnBackToDebt.Text = "Về công nợ";
        btnBackToDebt.UseVisualStyleBackColor = true;
        btnBackToDebt.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(281, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Đã ghi nhận khoản thu";
        // 
        // bannerSuccess
        // 
        bannerSuccess.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerSuccess.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerSuccess.Dock = System.Windows.Forms.DockStyle.Top;
        bannerSuccess.Location = new System.Drawing.Point(0, 78);
        bannerSuccess.Message = "Nội dung chi tiết thông báo.";
        bannerSuccess.Name = "bannerSuccess";
        bannerSuccess.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerSuccess.Size = new System.Drawing.Size(1200, 69);
        bannerSuccess.TabIndex = 1;
        bannerSuccess.Text = ("✓ Thu thành công 1.500.000đ. Đã lưu phiếu thu và cập nhật số dư trong SQLite. Chư" + "a in phiếu.");
        bannerSuccess.Title = "Thông báo nghiệp vụ";
        bannerSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // pnlStepper
        // 
        pnlStepper.BackColor = System.Drawing.Color.White;
        pnlStepper.Controls.Add(lblStep4);
        pnlStepper.Controls.Add(lblStep3);
        pnlStepper.Controls.Add(lblStep2);
        pnlStepper.Controls.Add(lblStep1);
        pnlStepper.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStepper.Location = new System.Drawing.Point(0, 147);
        pnlStepper.Name = "pnlStepper";
        pnlStepper.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
        pnlStepper.Size = new System.Drawing.Size(1200, 36);
        pnlStepper.TabIndex = 2;
        // 
        // lblStep4
        // 
        lblStep4.AutoSize = true;
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep4.Location = new System.Drawing.Point(600, 9);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(103, 20);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "• 4. Phiếu thu";
        // 
        // lblStep3
        // 
        lblStep3.AutoSize = true;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep3.Location = new System.Drawing.Point(400, 9);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(161, 20);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "✓ 3. Kiểm tra & xác nhận";
        // 
        // lblStep2
        // 
        lblStep2.AutoSize = true;
        lblStep2.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep2.Location = new System.Drawing.Point(200, 9);
        lblStep2.Name = "lblStep2";
        lblStep2.Size = new System.Drawing.Size(144, 20);
        lblStep2.TabIndex = 1;
        lblStep2.Text = "✓ 2. Nhập khoản thu";
        // 
        // lblStep1
        // 
        lblStep1.AutoSize = true;
        lblStep1.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep1.Location = new System.Drawing.Point(24, 9);
        lblStep1.Name = "lblStep1";
        lblStep1.Size = new System.Drawing.Size(132, 20);
        lblStep1.TabIndex = 0;
        lblStep1.Text = "✓ 1. Chọn học viên";
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
        pnlBody.Controls.Add(cardTransactionDetail, 0, 0);
        pnlBody.Controls.Add(cardBalanceSummary, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 183);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(1200, 557);
        pnlBody.TabIndex = 3;
        // 
        // cardTransactionDetail
        // 
        cardTransactionDetail.BackColor = System.Drawing.Color.White;
        cardTransactionDetail.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTransactionDetail.BorderWidth = 1;
        cardTransactionDetail.Controls.Add(lblDetailCardTitle);
        cardTransactionDetail.Controls.Add(btnViewPrintReceipt);
        cardTransactionDetail.Controls.Add(lblNoteVal);
        cardTransactionDetail.Controls.Add(lblNoteTitle);
        cardTransactionDetail.Controls.Add(lblAmountVal);
        cardTransactionDetail.Controls.Add(lblAmountTitle);
        cardTransactionDetail.Controls.Add(lblMethodVal);
        cardTransactionDetail.Controls.Add(lblMethodTitle);
        cardTransactionDetail.Controls.Add(lblCollectorVal);
        cardTransactionDetail.Controls.Add(lblCollectorTitle);
        cardTransactionDetail.Controls.Add(lblReceiptCodeVal);
        cardTransactionDetail.Controls.Add(lblReceiptCodeTitle);
        cardTransactionDetail.Controls.Add(lblClassVal);
        cardTransactionDetail.Controls.Add(lblClassTitle);
        cardTransactionDetail.Controls.Add(lblStudentVal);
        cardTransactionDetail.Controls.Add(lblStudentTitle);
        cardTransactionDetail.CornerRadius = 6;
        cardTransactionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
        cardTransactionDetail.Location = new System.Drawing.Point(23, 15);
        cardTransactionDetail.Name = "cardTransactionDetail";
        cardTransactionDetail.Padding = new System.Windows.Forms.Padding(20);
        cardTransactionDetail.Size = new System.Drawing.Size(632, 523);
        cardTransactionDetail.TabIndex = 0;
        // 
        // lblDetailCardTitle
        // 
        lblDetailCardTitle.AutoSize = true;
        lblDetailCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblDetailCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDetailCardTitle.Location = new System.Drawing.Point(20, 16);
        lblDetailCardTitle.Name = "lblDetailCardTitle";
        lblDetailCardTitle.Size = new System.Drawing.Size(160, 25);
        lblDetailCardTitle.TabIndex = 16;
        lblDetailCardTitle.Text = "Chi tiết giao dịch";
        // 
        // btnViewPrintReceipt
        // 
        btnViewPrintReceipt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnViewPrintReceipt.CornerRadius = 5;
        btnViewPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewPrintReceipt.Location = new System.Drawing.Point(20, 310);
        btnViewPrintReceipt.Name = "btnViewPrintReceipt";
        btnViewPrintReceipt.Size = new System.Drawing.Size(180, 38);
        btnViewPrintReceipt.TabIndex = 14;
        btnViewPrintReceipt.Text = "Xem bản in phiếu thu";
        btnViewPrintReceipt.UseVisualStyleBackColor = true;
        btnViewPrintReceipt.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblNoteVal
        // 
        lblNoteVal.AutoSize = true;
        lblNoteVal.Location = new System.Drawing.Point(160, 260);
        lblNoteVal.Name = "lblNoteVal";
        lblNoteVal.Size = new System.Drawing.Size(252, 20);
        lblNoteVal.TabIndex = 13;
        lblNoteVal.Text = "Thu học phí IELTS Foundation - đợt 2";
        // 
        // lblNoteTitle
        // 
        lblNoteTitle.AutoSize = true;
        lblNoteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNoteTitle.Location = new System.Drawing.Point(20, 260);
        lblNoteTitle.Name = "lblNoteTitle";
        lblNoteTitle.Size = new System.Drawing.Size(72, 20);
        lblNoteTitle.TabIndex = 12;
        lblNoteTitle.Text = "Diễn giải:";
        // 
        // lblAmountVal
        // 
        lblAmountVal.AutoSize = true;
        lblAmountVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAmountVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblAmountVal.Location = new System.Drawing.Point(160, 222);
        lblAmountVal.Name = "lblAmountVal";
        lblAmountVal.Size = new System.Drawing.Size(125, 28);
        lblAmountVal.TabIndex = 11;
        lblAmountVal.Text = "1.500.000 đ";
        // 
        // lblAmountTitle
        // 
        lblAmountTitle.AutoSize = true;
        lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAmountTitle.Location = new System.Drawing.Point(20, 225);
        lblAmountTitle.Name = "lblAmountTitle";
        lblAmountTitle.Size = new System.Drawing.Size(137, 20);
        lblAmountTitle.TabIndex = 10;
        lblAmountTitle.Text = "Số tiền thu đợt này:";
        // 
        // lblMethodVal
        // 
        lblMethodVal.AutoSize = true;
        lblMethodVal.Location = new System.Drawing.Point(160, 190);
        lblMethodVal.Name = "lblMethodVal";
        lblMethodVal.Size = new System.Drawing.Size(320, 20);
        lblMethodVal.TabIndex = 9;
        lblMethodVal.Text = "Chuyển khoản ghi tay · Tham chiếu CK3010-MA";
        // 
        // lblMethodTitle
        // 
        lblMethodTitle.AutoSize = true;
        lblMethodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblMethodTitle.Location = new System.Drawing.Point(20, 190);
        lblMethodTitle.Name = "lblMethodTitle";
        lblMethodTitle.Size = new System.Drawing.Size(96, 20);
        lblMethodTitle.TabIndex = 8;
        lblMethodTitle.Text = "Phương thức:";
        // 
        // lblCollectorVal
        // 
        lblCollectorVal.AutoSize = true;
        lblCollectorVal.Location = new System.Drawing.Point(160, 155);
        lblCollectorVal.Name = "lblCollectorVal";
        lblCollectorVal.Size = new System.Drawing.Size(203, 20);
        lblCollectorVal.TabIndex = 7;
        lblCollectorVal.Text = "30/10/2026 · Lê Phương Thảo";
        // 
        // lblCollectorTitle
        // 
        lblCollectorTitle.AutoSize = true;
        lblCollectorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCollectorTitle.Location = new System.Drawing.Point(20, 155);
        lblCollectorTitle.Name = "lblCollectorTitle";
        lblCollectorTitle.Size = new System.Drawing.Size(125, 20);
        lblCollectorTitle.TabIndex = 6;
        lblCollectorTitle.Text = "Ngày / người thu:";
        // 
        // lblReceiptCodeVal
        // 
        lblReceiptCodeVal.AutoSize = true;
        lblReceiptCodeVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblReceiptCodeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblReceiptCodeVal.Location = new System.Drawing.Point(160, 120);
        lblReceiptCodeVal.Name = "lblReceiptCodeVal";
        lblReceiptCodeVal.Size = new System.Drawing.Size(122, 21);
        lblReceiptCodeVal.TabIndex = 5;
        lblReceiptCodeVal.Text = "PT-261030-018";
        // 
        // lblReceiptCodeTitle
        // 
        lblReceiptCodeTitle.AutoSize = true;
        lblReceiptCodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblReceiptCodeTitle.Location = new System.Drawing.Point(20, 120);
        lblReceiptCodeTitle.Name = "lblReceiptCodeTitle";
        lblReceiptCodeTitle.Size = new System.Drawing.Size(73, 20);
        lblReceiptCodeTitle.TabIndex = 4;
        lblReceiptCodeTitle.Text = "Phiếu thu:";
        // 
        // lblClassVal
        // 
        lblClassVal.AutoSize = true;
        lblClassVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblClassVal.Location = new System.Drawing.Point(160, 85);
        lblClassVal.Name = "lblClassVal";
        lblClassVal.Size = new System.Drawing.Size(227, 21);
        lblClassVal.TabIndex = 3;
        lblClassVal.Text = "IELTS Foundation / IELTS-F01";
        // 
        // lblClassTitle
        // 
        lblClassTitle.AutoSize = true;
        lblClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblClassTitle.Location = new System.Drawing.Point(20, 85);
        lblClassTitle.Name = "lblClassTitle";
        lblClassTitle.Size = new System.Drawing.Size(82, 20);
        lblClassTitle.TabIndex = 2;
        lblClassTitle.Text = "Khóa / lớp:";
        // 
        // lblStudentVal
        // 
        lblStudentVal.AutoSize = true;
        lblStudentVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentVal.Location = new System.Drawing.Point(160, 50);
        lblStudentVal.Name = "lblStudentVal";
        lblStudentVal.Size = new System.Drawing.Size(227, 21);
        lblStudentVal.TabIndex = 1;
        lblStudentVal.Text = "Nguyễn Minh Anh · HV-0241";
        // 
        // lblStudentTitle
        // 
        lblStudentTitle.AutoSize = true;
        lblStudentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentTitle.Location = new System.Drawing.Point(20, 50);
        lblStudentTitle.Name = "lblStudentTitle";
        lblStudentTitle.Size = new System.Drawing.Size(70, 20);
        lblStudentTitle.TabIndex = 0;
        lblStudentTitle.Text = "Học viên:";
        // 
        // cardBalanceSummary
        // 
        cardBalanceSummary.BackColor = System.Drawing.Color.White;
        cardBalanceSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardBalanceSummary.BorderWidth = 1;
        cardBalanceSummary.Controls.Add(lblSummaryCardTitle);
        cardBalanceSummary.Controls.Add(btnOpenStudentProfile);
        cardBalanceSummary.Controls.Add(lblNextDueVal);
        cardBalanceSummary.Controls.Add(lblNextDueTitle);
        cardBalanceSummary.Controls.Add(lblRemainingVal);
        cardBalanceSummary.Controls.Add(lblRemainingTitle);
        cardBalanceSummary.Controls.Add(lblTotalPaidVal);
        cardBalanceSummary.Controls.Add(lblTotalPaidTitle);
        cardBalanceSummary.Controls.Add(lblNewPaidAmtVal);
        cardBalanceSummary.Controls.Add(lblNewPaidAmtTitle);
        cardBalanceSummary.Controls.Add(lblPrevPaidVal);
        cardBalanceSummary.Controls.Add(lblPrevPaidTitle);
        cardBalanceSummary.Controls.Add(lblDiscountVal);
        cardBalanceSummary.Controls.Add(lblDiscountTitle);
        cardBalanceSummary.Controls.Add(lblBaseTuitionVal);
        cardBalanceSummary.Controls.Add(lblBaseTuitionTitle);
        cardBalanceSummary.CornerRadius = 6;
        cardBalanceSummary.Dock = System.Windows.Forms.DockStyle.Fill;
        cardBalanceSummary.Location = new System.Drawing.Point(661, 15);
        cardBalanceSummary.Name = "cardBalanceSummary";
        cardBalanceSummary.Padding = new System.Windows.Forms.Padding(20);
        cardBalanceSummary.Size = new System.Drawing.Size(516, 523);
        cardBalanceSummary.TabIndex = 1;
        // 
        // lblSummaryCardTitle
        // 
        lblSummaryCardTitle.AutoSize = true;
        lblSummaryCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSummaryCardTitle.Location = new System.Drawing.Point(20, 16);
        lblSummaryCardTitle.Name = "lblSummaryCardTitle";
        lblSummaryCardTitle.Size = new System.Drawing.Size(202, 25);
        lblSummaryCardTitle.TabIndex = 16;
        lblSummaryCardTitle.Text = "Học phí sau giao dịch";
        // 
        // btnOpenStudentProfile
        // 
        btnOpenStudentProfile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenStudentProfile.CornerRadius = 5;
        btnOpenStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenStudentProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnOpenStudentProfile.Location = new System.Drawing.Point(20, 380);
        btnOpenStudentProfile.Name = "btnOpenStudentProfile";
        btnOpenStudentProfile.Size = new System.Drawing.Size(170, 36);
        btnOpenStudentProfile.TabIndex = 15;
        btnOpenStudentProfile.Text = "Mở hồ sơ học viên";
        btnOpenStudentProfile.UseVisualStyleBackColor = true;
        btnOpenStudentProfile.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblNextDueVal
        // 
        lblNextDueVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNextDueVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNextDueVal.Location = new System.Drawing.Point(340, 260);
        lblNextDueVal.Name = "lblNextDueVal";
        lblNextDueVal.Size = new System.Drawing.Size(150, 18);
        lblNextDueVal.TabIndex = 13;
        lblNextDueVal.Text = "15/11/2026";
        lblNextDueVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNextDueTitle
        // 
        lblNextDueTitle.AutoSize = true;
        lblNextDueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNextDueTitle.Location = new System.Drawing.Point(20, 260);
        lblNextDueTitle.Name = "lblNextDueTitle";
        lblNextDueTitle.Size = new System.Drawing.Size(130, 20);
        lblNextDueTitle.TabIndex = 12;
        lblNextDueTitle.Text = "Hạn đợt tiếp theo:";
        // 
        // lblRemainingVal
        // 
        lblRemainingVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblRemainingVal.Location = new System.Drawing.Point(340, 225);
        lblRemainingVal.Name = "lblRemainingVal";
        lblRemainingVal.Size = new System.Drawing.Size(150, 20);
        lblRemainingVal.TabIndex = 11;
        lblRemainingVal.Text = "1.900.000đ";
        lblRemainingVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblRemainingTitle
        // 
        lblRemainingTitle.AutoSize = true;
        lblRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblRemainingTitle.Location = new System.Drawing.Point(20, 225);
        lblRemainingTitle.Name = "lblRemainingTitle";
        lblRemainingTitle.Size = new System.Drawing.Size(108, 21);
        lblRemainingTitle.TabIndex = 10;
        lblRemainingTitle.Text = "Còn phải thu";
        // 
        // lblTotalPaidVal
        // 
        lblTotalPaidVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblTotalPaidVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTotalPaidVal.Location = new System.Drawing.Point(340, 190);
        lblTotalPaidVal.Name = "lblTotalPaidVal";
        lblTotalPaidVal.Size = new System.Drawing.Size(150, 18);
        lblTotalPaidVal.TabIndex = 9;
        lblTotalPaidVal.Text = "3.500.000đ";
        lblTotalPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTotalPaidTitle
        // 
        lblTotalPaidTitle.AutoSize = true;
        lblTotalPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTotalPaidTitle.Location = new System.Drawing.Point(20, 190);
        lblTotalPaidTitle.Name = "lblTotalPaidTitle";
        lblTotalPaidTitle.Size = new System.Drawing.Size(89, 20);
        lblTotalPaidTitle.TabIndex = 8;
        lblTotalPaidTitle.Text = "Tổng đã thu";
        // 
        // lblNewPaidAmtVal
        // 
        lblNewPaidAmtVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNewPaidAmtVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblNewPaidAmtVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblNewPaidAmtVal.Location = new System.Drawing.Point(340, 155);
        lblNewPaidAmtVal.Name = "lblNewPaidAmtVal";
        lblNewPaidAmtVal.Size = new System.Drawing.Size(150, 18);
        lblNewPaidAmtVal.TabIndex = 7;
        lblNewPaidAmtVal.Text = "1.500.000đ";
        lblNewPaidAmtVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNewPaidAmtTitle
        // 
        lblNewPaidAmtTitle.AutoSize = true;
        lblNewPaidAmtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNewPaidAmtTitle.Location = new System.Drawing.Point(20, 155);
        lblNewPaidAmtTitle.Name = "lblNewPaidAmtTitle";
        lblNewPaidAmtTitle.Size = new System.Drawing.Size(63, 20);
        lblNewPaidAmtTitle.TabIndex = 6;
        lblNewPaidAmtTitle.Text = "Thu mới";
        // 
        // lblPrevPaidVal
        // 
        lblPrevPaidVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPrevPaidVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblPrevPaidVal.Location = new System.Drawing.Point(340, 120);
        lblPrevPaidVal.Name = "lblPrevPaidVal";
        lblPrevPaidVal.Size = new System.Drawing.Size(150, 18);
        lblPrevPaidVal.TabIndex = 5;
        lblPrevPaidVal.Text = "2.000.000đ";
        lblPrevPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPrevPaidTitle
        // 
        lblPrevPaidTitle.AutoSize = true;
        lblPrevPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPrevPaidTitle.Location = new System.Drawing.Point(20, 120);
        lblPrevPaidTitle.Name = "lblPrevPaidTitle";
        lblPrevPaidTitle.Size = new System.Drawing.Size(92, 20);
        lblPrevPaidTitle.TabIndex = 4;
        lblPrevPaidTitle.Text = "Đã thu trước";
        // 
        // lblDiscountVal
        // 
        lblDiscountVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDiscountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblDiscountVal.Location = new System.Drawing.Point(320, 85);
        lblDiscountVal.Name = "lblDiscountVal";
        lblDiscountVal.Size = new System.Drawing.Size(170, 18);
        lblDiscountVal.TabIndex = 3;
        lblDiscountVal.Text = "600.000đ / 5.400.000đ";
        lblDiscountVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDiscountTitle
        // 
        lblDiscountTitle.AutoSize = true;
        lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDiscountTitle.Location = new System.Drawing.Point(20, 85);
        lblDiscountTitle.Name = "lblDiscountTitle";
        lblDiscountTitle.Size = new System.Drawing.Size(112, 20);
        lblDiscountTitle.TabIndex = 2;
        lblDiscountTitle.Text = "Giảm / thực thu";
        // 
        // lblBaseTuitionVal
        // 
        lblBaseTuitionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblBaseTuitionVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblBaseTuitionVal.Location = new System.Drawing.Point(340, 50);
        lblBaseTuitionVal.Name = "lblBaseTuitionVal";
        lblBaseTuitionVal.Size = new System.Drawing.Size(150, 18);
        lblBaseTuitionVal.TabIndex = 1;
        lblBaseTuitionVal.Text = "6.000.000đ";
        lblBaseTuitionVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblBaseTuitionTitle
        // 
        lblBaseTuitionTitle.AutoSize = true;
        lblBaseTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblBaseTuitionTitle.Location = new System.Drawing.Point(20, 50);
        lblBaseTuitionTitle.Name = "lblBaseTuitionTitle";
        lblBaseTuitionTitle.Size = new System.Drawing.Size(90, 20);
        lblBaseTuitionTitle.TabIndex = 0;
        lblBaseTuitionTitle.Text = "Học phí gốc";
        // 
        // PaymentSuccessDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlStepper);
        Controls.Add(bannerSuccess);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Hoàn tất thu học phí · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlStepper.ResumeLayout(false);
        pnlStepper.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardTransactionDetail.ResumeLayout(false);
        cardTransactionDetail.PerformLayout();
        cardBalanceSummary.ResumeLayout(false);
        cardBalanceSummary.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnPreviewPrint;
    private ECMS.UI.Controls.AppButton btnBackToDebt;
    private ECMS.UI.Controls.AppBanner bannerSuccess;
    private System.Windows.Forms.Panel pnlStepper;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private ECMS.UI.Controls.AppCard cardTransactionDetail;
    private System.Windows.Forms.Label lblDetailCardTitle;
    private ECMS.UI.Controls.AppCard cardBalanceSummary;
    private System.Windows.Forms.Label lblSummaryCardTitle;

    private System.Windows.Forms.Label lblStudentTitle;
    private System.Windows.Forms.Label lblStudentVal;
    private System.Windows.Forms.Label lblClassTitle;
    private System.Windows.Forms.Label lblClassVal;
    private System.Windows.Forms.Label lblReceiptCodeTitle;
    private System.Windows.Forms.Label lblReceiptCodeVal;
    private System.Windows.Forms.Label lblCollectorTitle;
    private System.Windows.Forms.Label lblCollectorVal;
    private System.Windows.Forms.Label lblMethodTitle;
    private System.Windows.Forms.Label lblMethodVal;
    private System.Windows.Forms.Label lblAmountTitle;
    private System.Windows.Forms.Label lblAmountVal;
    private System.Windows.Forms.Label lblNoteTitle;
    private System.Windows.Forms.Label lblNoteVal;
    private ECMS.UI.Controls.AppButton btnViewPrintReceipt;

    private System.Windows.Forms.Label lblBaseTuitionTitle;
    private System.Windows.Forms.Label lblBaseTuitionVal;
    private System.Windows.Forms.Label lblDiscountTitle;
    private System.Windows.Forms.Label lblDiscountVal;
    private System.Windows.Forms.Label lblPrevPaidTitle;
    private System.Windows.Forms.Label lblPrevPaidVal;
    private System.Windows.Forms.Label lblNewPaidAmtTitle;
    private System.Windows.Forms.Label lblNewPaidAmtVal;
    private System.Windows.Forms.Label lblTotalPaidTitle;
    private System.Windows.Forms.Label lblTotalPaidVal;
    private System.Windows.Forms.Label lblRemainingTitle;
    private System.Windows.Forms.Label lblRemainingVal;
    private System.Windows.Forms.Label lblNextDueTitle;
    private System.Windows.Forms.Label lblNextDueVal;
    private ECMS.UI.Controls.AppButton btnOpenStudentProfile;
}
