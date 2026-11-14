namespace ECMS.UI.Forms;

partial class ClassTransferCompleteDialog
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlStepper = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        pnlTwoCards = new System.Windows.Forms.Panel();
        cardReceipt = new ECMS.UI.Controls.AppCard();
        lblDoneTransferNote = new System.Windows.Forms.Label();
        btnViewStudentHistory = new ECMS.UI.Controls.AppButton();
        btnOpenClassF04 = new ECMS.UI.Controls.AppButton();
        lblConfirmedByVal = new System.Windows.Forms.Label();
        lblConfirmedByKey = new System.Windows.Forms.Label();
        lblFinanceVal = new System.Windows.Forms.Label();
        lblFinanceKey = new System.Windows.Forms.Label();
        lblOldHistoryVal = new System.Windows.Forms.Label();
        lblOldHistoryKey = new System.Windows.Forms.Label();
        lblEffectiveDateVal = new System.Windows.Forms.Label();
        lblEffectiveDateKey = new System.Windows.Forms.Label();
        lblClassPairVal = new System.Windows.Forms.Label();
        lblClassPairKey = new System.Windows.Forms.Label();
        lblReasonVal = new System.Windows.Forms.Label();
        lblReasonKey = new System.Windows.Forms.Label();
        lblStudentNameVal = new System.Windows.Forms.Label();
        lblStudentNameKey = new System.Windows.Forms.Label();
        lblReceiptTitle = new System.Windows.Forms.Label();
        cardPreCheck = new ECMS.UI.Controls.AppCard();
        dgvChecklist = new ECMS.UI.Controls.AppDataGrid();
        lblPreCheckTitle = new System.Windows.Forms.Label();
        cardStatDestStatus = new ECMS.UI.Controls.AppCard();
        lblStatDestStatusVal = new System.Windows.Forms.Label();
        lblStatDestStatusTitle = new System.Windows.Forms.Label();
        cardStatCreatedSessions = new ECMS.UI.Controls.AppCard();
        lblStatCreatedSessionsVal = new System.Windows.Forms.Label();
        lblStatCreatedSessionsTitle = new System.Windows.Forms.Label();
        cardStatDestClass = new ECMS.UI.Controls.AppCard();
        lblStatDestClassVal = new System.Windows.Forms.Label();
        lblStatDestClassTitle = new System.Windows.Forms.Label();
        cardStatSourceClass = new ECMS.UI.Controls.AppCard();
        lblStatSourceClassVal = new System.Windows.Forms.Label();
        lblStatSourceClassTitle = new System.Windows.Forms.Label();
        bannerSuccess = new ECMS.UI.Controls.AppBanner();
        pnlHeader.SuspendLayout();
        pnlStepper.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlTwoCards.SuspendLayout();
        cardReceipt.SuspendLayout();
        cardPreCheck.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChecklist).BeginInit();
        cardStatDestStatus.SuspendLayout();
        cardStatCreatedSessions.SuspendLayout();
        cardStatDestClass.SuspendLayout();
        cardStatSourceClass.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(378, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Mở lớp & hoàn tất chuyển lớp";
        // 
        // pnlStepper
        // 
        pnlStepper.BackColor = System.Drawing.Color.White;
        pnlStepper.Controls.Add(lblStep4);
        pnlStepper.Controls.Add(lblStep3);
        pnlStepper.Controls.Add(lblStep2);
        pnlStepper.Controls.Add(lblStep1);
        pnlStepper.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStepper.Location = new System.Drawing.Point(0, 75);
        pnlStepper.Name = "pnlStepper";
        pnlStepper.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlStepper.Size = new System.Drawing.Size(1220, 40);
        pnlStepper.TabIndex = 1;
        // 
        // lblStep4
        // 
        lblStep4.Dock = System.Windows.Forms.DockStyle.Left;
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblStep4.Location = new System.Drawing.Point(444, 0);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(150, 40);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "4. Chuyển học viên";
        lblStep4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblStep3
        // 
        lblStep3.Dock = System.Windows.Forms.DockStyle.Left;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)167)), ((int)((byte)69)));
        lblStep3.Location = new System.Drawing.Point(304, 0);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(140, 40);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "✓ Mở lớp  ➔";
        lblStep3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblStep2
        // 
        lblStep2.Dock = System.Windows.Forms.DockStyle.Left;
        lblStep2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)167)), ((int)((byte)69)));
        lblStep2.Location = new System.Drawing.Point(144, 0);
        lblStep2.Name = "lblStep2";
        lblStep2.Size = new System.Drawing.Size(160, 40);
        lblStep2.TabIndex = 1;
        lblStep2.Text = "✓ Lập lịch hợp lệ  ➔";
        lblStep2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblStep1
        // 
        lblStep1.Dock = System.Windows.Forms.DockStyle.Left;
        lblStep1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)167)), ((int)((byte)69)));
        lblStep1.Location = new System.Drawing.Point(24, 0);
        lblStep1.Name = "lblStep1";
        lblStep1.Size = new System.Drawing.Size(120, 40);
        lblStep1.TabIndex = 0;
        lblStep1.Text = "✓ Tạo lớp  ➔";
        lblStep1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(pnlTwoCards);
        pnlBody.Controls.Add(cardStatDestStatus);
        pnlBody.Controls.Add(cardStatCreatedSessions);
        pnlBody.Controls.Add(cardStatDestClass);
        pnlBody.Controls.Add(cardStatSourceClass);
        pnlBody.Controls.Add(bannerSuccess);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 115);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 645);
        pnlBody.TabIndex = 2;
        // 
        // pnlTwoCards
        // 
        pnlTwoCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlTwoCards.Controls.Add(cardReceipt);
        pnlTwoCards.Controls.Add(cardPreCheck);
        pnlTwoCards.Location = new System.Drawing.Point(24, 185);
        pnlTwoCards.Name = "pnlTwoCards";
        pnlTwoCards.Size = new System.Drawing.Size(1172, 420);
        pnlTwoCards.TabIndex = 6;
        // 
        // cardReceipt
        // 
        cardReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardReceipt.BackColor = System.Drawing.Color.White;
        cardReceipt.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardReceipt.BorderWidth = 1;
        cardReceipt.Controls.Add(lblDoneTransferNote);
        cardReceipt.Controls.Add(btnViewStudentHistory);
        cardReceipt.Controls.Add(btnOpenClassF04);
        cardReceipt.Controls.Add(lblConfirmedByVal);
        cardReceipt.Controls.Add(lblConfirmedByKey);
        cardReceipt.Controls.Add(lblFinanceVal);
        cardReceipt.Controls.Add(lblFinanceKey);
        cardReceipt.Controls.Add(lblOldHistoryVal);
        cardReceipt.Controls.Add(lblOldHistoryKey);
        cardReceipt.Controls.Add(lblEffectiveDateVal);
        cardReceipt.Controls.Add(lblEffectiveDateKey);
        cardReceipt.Controls.Add(lblClassPairVal);
        cardReceipt.Controls.Add(lblClassPairKey);
        cardReceipt.Controls.Add(lblReasonVal);
        cardReceipt.Controls.Add(lblReasonKey);
        cardReceipt.Controls.Add(lblStudentNameVal);
        cardReceipt.Controls.Add(lblStudentNameKey);
        cardReceipt.Controls.Add(lblReceiptTitle);
        cardReceipt.CornerRadius = 6;
        cardReceipt.Location = new System.Drawing.Point(600, 0);
        cardReceipt.Name = "cardReceipt";
        cardReceipt.Padding = new System.Windows.Forms.Padding(20);
        cardReceipt.Size = new System.Drawing.Size(572, 410);
        cardReceipt.TabIndex = 1;
        // 
        // lblDoneTransferNote
        // 
        lblDoneTransferNote.AutoSize = true;
        lblDoneTransferNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDoneTransferNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)167)), ((int)((byte)69)));
        lblDoneTransferNote.Location = new System.Drawing.Point(20, 368);
        lblDoneTransferNote.Name = "lblDoneTransferNote";
        lblDoneTransferNote.Size = new System.Drawing.Size(166, 20);
        lblDoneTransferNote.TabIndex = 17;
        lblDoneTransferNote.Text = "✓ Hoàn tất chuyển lớp";
        // 
        // btnViewStudentHistory
        // 
        btnViewStudentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnViewStudentHistory.BackColor = System.Drawing.Color.White;
        btnViewStudentHistory.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnViewStudentHistory.CornerRadius = 5;
        btnViewStudentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewStudentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewStudentHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnViewStudentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnViewStudentHistory.Location = new System.Drawing.Point(395, 355);
        btnViewStudentHistory.Name = "btnViewStudentHistory";
        btnViewStudentHistory.Size = new System.Drawing.Size(155, 36);
        btnViewStudentHistory.TabIndex = 16;
        btnViewStudentHistory.Text = "Xem lịch sử học viên";
        btnViewStudentHistory.UseVisualStyleBackColor = false;
        btnViewStudentHistory.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnOpenClassF04
        // 
        btnOpenClassF04.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnOpenClassF04.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnOpenClassF04.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnOpenClassF04.CornerRadius = 5;
        btnOpenClassF04.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenClassF04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenClassF04.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenClassF04.ForeColor = System.Drawing.Color.White;
        btnOpenClassF04.Location = new System.Drawing.Point(235, 355);
        btnOpenClassF04.Name = "btnOpenClassF04";
        btnOpenClassF04.Size = new System.Drawing.Size(150, 36);
        btnOpenClassF04.TabIndex = 15;
        btnOpenClassF04.Text = "Mở lớp IELTS-F04";
        btnOpenClassF04.UseVisualStyleBackColor = false;
        btnOpenClassF04.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblConfirmedByVal
        // 
        lblConfirmedByVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblConfirmedByVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblConfirmedByVal.Location = new System.Drawing.Point(180, 290);
        lblConfirmedByVal.Name = "lblConfirmedByVal";
        lblConfirmedByVal.Size = new System.Drawing.Size(370, 20);
        lblConfirmedByVal.TabIndex = 14;
        lblConfirmedByVal.Text = "Trần Minh Quân";
        lblConfirmedByVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblConfirmedByKey
        // 
        lblConfirmedByKey.AutoSize = true;
        lblConfirmedByKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblConfirmedByKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblConfirmedByKey.Location = new System.Drawing.Point(20, 292);
        lblConfirmedByKey.Name = "lblConfirmedByKey";
        lblConfirmedByKey.Size = new System.Drawing.Size(113, 20);
        lblConfirmedByKey.TabIndex = 13;
        lblConfirmedByKey.Text = "Người xác nhận";
        // 
        // lblFinanceVal
        // 
        lblFinanceVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFinanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblFinanceVal.Location = new System.Drawing.Point(180, 250);
        lblFinanceVal.Name = "lblFinanceVal";
        lblFinanceVal.Size = new System.Drawing.Size(370, 20);
        lblFinanceVal.TabIndex = 12;
        lblFinanceVal.Text = "Không phát sinh thu tiền mới";
        lblFinanceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblFinanceKey
        // 
        lblFinanceKey.AutoSize = true;
        lblFinanceKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFinanceKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblFinanceKey.Location = new System.Drawing.Point(20, 252);
        lblFinanceKey.Name = "lblFinanceKey";
        lblFinanceKey.Size = new System.Drawing.Size(66, 20);
        lblFinanceKey.TabIndex = 11;
        lblFinanceKey.Text = "Tài chính";
        // 
        // lblOldHistoryVal
        // 
        lblOldHistoryVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblOldHistoryVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblOldHistoryVal.Location = new System.Drawing.Point(180, 210);
        lblOldHistoryVal.Name = "lblOldHistoryVal";
        lblOldHistoryVal.Size = new System.Drawing.Size(370, 20);
        lblOldHistoryVal.TabIndex = 10;
        lblOldHistoryVal.Text = "Giữ ở lịch sử IELTS-F01 · 8 buổi";
        lblOldHistoryVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblOldHistoryKey
        // 
        lblOldHistoryKey.AutoSize = true;
        lblOldHistoryKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblOldHistoryKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblOldHistoryKey.Location = new System.Drawing.Point(20, 212);
        lblOldHistoryKey.Name = "lblOldHistoryKey";
        lblOldHistoryKey.Size = new System.Drawing.Size(151, 20);
        lblOldHistoryKey.TabIndex = 9;
        lblOldHistoryKey.Text = "Điểm / chuyên cần cũ";
        // 
        // lblEffectiveDateVal
        // 
        lblEffectiveDateVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEffectiveDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblEffectiveDateVal.Location = new System.Drawing.Point(180, 170);
        lblEffectiveDateVal.Name = "lblEffectiveDateVal";
        lblEffectiveDateVal.Size = new System.Drawing.Size(370, 20);
        lblEffectiveDateVal.TabIndex = 8;
        lblEffectiveDateVal.Text = "02/11/2026";
        lblEffectiveDateVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEffectiveDateKey
        // 
        lblEffectiveDateKey.AutoSize = true;
        lblEffectiveDateKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEffectiveDateKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblEffectiveDateKey.Location = new System.Drawing.Point(20, 172);
        lblEffectiveDateKey.Name = "lblEffectiveDateKey";
        lblEffectiveDateKey.Size = new System.Drawing.Size(100, 20);
        lblEffectiveDateKey.TabIndex = 7;
        lblEffectiveDateKey.Text = "Ngày hiệu lực";
        // 
        // lblClassPairVal
        // 
        lblClassPairVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClassPairVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassPairVal.Location = new System.Drawing.Point(180, 130);
        lblClassPairVal.Name = "lblClassPairVal";
        lblClassPairVal.Size = new System.Drawing.Size(370, 20);
        lblClassPairVal.TabIndex = 6;
        lblClassPairVal.Text = "IELTS-F01 ➔ IELTS-F04";
        lblClassPairVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblClassPairKey
        // 
        lblClassPairKey.AutoSize = true;
        lblClassPairKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassPairKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblClassPairKey.Location = new System.Drawing.Point(20, 132);
        lblClassPairKey.Name = "lblClassPairKey";
        lblClassPairKey.Size = new System.Drawing.Size(131, 20);
        lblClassPairKey.TabIndex = 5;
        lblClassPairKey.Text = "Lớp nguồn ➔ đích";
        // 
        // lblReasonVal
        // 
        lblReasonVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblReasonVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblReasonVal.Location = new System.Drawing.Point(180, 90);
        lblReasonVal.Name = "lblReasonVal";
        lblReasonVal.Size = new System.Drawing.Size(370, 20);
        lblReasonVal.TabIndex = 4;
        lblReasonVal.Text = "Thay đổi lịch học cá nhân";
        lblReasonVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblReasonKey
        // 
        lblReasonKey.AutoSize = true;
        lblReasonKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblReasonKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblReasonKey.Location = new System.Drawing.Point(20, 92);
        lblReasonKey.Name = "lblReasonKey";
        lblReasonKey.Size = new System.Drawing.Size(44, 20);
        lblReasonKey.TabIndex = 3;
        lblReasonKey.Text = "Lý do";
        // 
        // lblStudentNameVal
        // 
        lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblStudentNameVal.Location = new System.Drawing.Point(180, 50);
        lblStudentNameVal.Name = "lblStudentNameVal";
        lblStudentNameVal.Size = new System.Drawing.Size(370, 20);
        lblStudentNameVal.TabIndex = 2;
        lblStudentNameVal.Text = "Lê Hoàng Nam · HV-0237";
        lblStudentNameVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblStudentNameKey
        // 
        lblStudentNameKey.AutoSize = true;
        lblStudentNameKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStudentNameKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStudentNameKey.Location = new System.Drawing.Point(20, 52);
        lblStudentNameKey.Name = "lblStudentNameKey";
        lblStudentNameKey.Size = new System.Drawing.Size(67, 20);
        lblStudentNameKey.TabIndex = 1;
        lblStudentNameKey.Text = "Học viên";
        // 
        // lblReceiptTitle
        // 
        lblReceiptTitle.AutoSize = true;
        lblReceiptTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblReceiptTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblReceiptTitle.Location = new System.Drawing.Point(20, 16);
        lblReceiptTitle.Name = "lblReceiptTitle";
        lblReceiptTitle.Size = new System.Drawing.Size(218, 28);
        lblReceiptTitle.TabIndex = 0;
        lblReceiptTitle.Text = "Biên nhận chuyển lớp";
        // 
        // cardPreCheck
        // 
        cardPreCheck.BackColor = System.Drawing.Color.White;
        cardPreCheck.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPreCheck.BorderWidth = 1;
        cardPreCheck.Controls.Add(dgvChecklist);
        cardPreCheck.Controls.Add(lblPreCheckTitle);
        cardPreCheck.CornerRadius = 6;
        cardPreCheck.Location = new System.Drawing.Point(0, 0);
        cardPreCheck.Name = "cardPreCheck";
        cardPreCheck.Padding = new System.Windows.Forms.Padding(20);
        cardPreCheck.Size = new System.Drawing.Size(572, 410);
        cardPreCheck.TabIndex = 0;
        // 
        // dgvChecklist
        // 
        dgvChecklist.AllowUserToAddRows = false;
        dgvChecklist.AllowUserToDeleteRows = false;
        dgvChecklist.AllowUserToResizeColumns = false;
        dgvChecklist.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvChecklist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvChecklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvChecklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChecklist.BackgroundColor = System.Drawing.Color.White;
        dgvChecklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvChecklist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvChecklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvChecklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvChecklist.DefaultCellStyle = dataGridViewCellStyle3;
        dgvChecklist.EnableHeadersVisualStyles = false;
        dgvChecklist.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvChecklist.Location = new System.Drawing.Point(20, 50);
        dgvChecklist.MultiSelect = false;
        dgvChecklist.Name = "dgvChecklist";
        dgvChecklist.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvChecklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvChecklist.RowHeadersVisible = false;
        dgvChecklist.RowHeadersWidth = 51;
        dgvChecklist.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvChecklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChecklist.Size = new System.Drawing.Size(532, 300);
        dgvChecklist.TabIndex = 1;
        // 
        // lblPreCheckTitle
        // 
        lblPreCheckTitle.AutoSize = true;
        lblPreCheckTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblPreCheckTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblPreCheckTitle.Location = new System.Drawing.Point(20, 16);
        lblPreCheckTitle.Name = "lblPreCheckTitle";
        lblPreCheckTitle.Size = new System.Drawing.Size(260, 28);
        lblPreCheckTitle.TabIndex = 0;
        lblPreCheckTitle.Text = "Kiểm tra trước khi mở lớp";
        // 
        // cardStatDestStatus
        // 
        cardStatDestStatus.BackColor = System.Drawing.Color.White;
        cardStatDestStatus.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatDestStatus.BorderWidth = 1;
        cardStatDestStatus.Controls.Add(lblStatDestStatusVal);
        cardStatDestStatus.Controls.Add(lblStatDestStatusTitle);
        cardStatDestStatus.CornerRadius = 6;
        cardStatDestStatus.Location = new System.Drawing.Point(909, 80);
        cardStatDestStatus.Name = "cardStatDestStatus";
        cardStatDestStatus.Padding = new System.Windows.Forms.Padding(16);
        cardStatDestStatus.Size = new System.Drawing.Size(287, 85);
        cardStatDestStatus.TabIndex = 5;
        // 
        // lblStatDestStatusVal
        // 
        lblStatDestStatusVal.AutoSize = true;
        lblStatDestStatusVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatDestStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblStatDestStatusVal.Location = new System.Drawing.Point(16, 38);
        lblStatDestStatusVal.Name = "lblStatDestStatusVal";
        lblStatDestStatusVal.Size = new System.Drawing.Size(151, 41);
        lblStatDestStatusVal.TabIndex = 1;
        lblStatDestStatusVal.Text = "Đang học";
        // 
        // lblStatDestStatusTitle
        // 
        lblStatDestStatusTitle.AutoSize = true;
        lblStatDestStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatDestStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatDestStatusTitle.Location = new System.Drawing.Point(16, 16);
        lblStatDestStatusTitle.Name = "lblStatDestStatusTitle";
        lblStatDestStatusTitle.Size = new System.Drawing.Size(133, 20);
        lblStatDestStatusTitle.TabIndex = 0;
        lblStatDestStatusTitle.Text = "Trạng thái lớp đích";
        // 
        // cardStatCreatedSessions
        // 
        cardStatCreatedSessions.BackColor = System.Drawing.Color.White;
        cardStatCreatedSessions.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatCreatedSessions.BorderWidth = 1;
        cardStatCreatedSessions.Controls.Add(lblStatCreatedSessionsVal);
        cardStatCreatedSessions.Controls.Add(lblStatCreatedSessionsTitle);
        cardStatCreatedSessions.CornerRadius = 6;
        cardStatCreatedSessions.Location = new System.Drawing.Point(614, 80);
        cardStatCreatedSessions.Name = "cardStatCreatedSessions";
        cardStatCreatedSessions.Padding = new System.Windows.Forms.Padding(16);
        cardStatCreatedSessions.Size = new System.Drawing.Size(287, 85);
        cardStatCreatedSessions.TabIndex = 4;
        // 
        // lblStatCreatedSessionsVal
        // 
        lblStatCreatedSessionsVal.AutoSize = true;
        lblStatCreatedSessionsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatCreatedSessionsVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatCreatedSessionsVal.Location = new System.Drawing.Point(16, 38);
        lblStatCreatedSessionsVal.Name = "lblStatCreatedSessionsVal";
        lblStatCreatedSessionsVal.Size = new System.Drawing.Size(124, 41);
        lblStatCreatedSessionsVal.TabIndex = 1;
        lblStatCreatedSessionsVal.Text = "24 buổi";
        // 
        // lblStatCreatedSessionsTitle
        // 
        lblStatCreatedSessionsTitle.AutoSize = true;
        lblStatCreatedSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatCreatedSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatCreatedSessionsTitle.Location = new System.Drawing.Point(16, 16);
        lblStatCreatedSessionsTitle.Name = "lblStatCreatedSessionsTitle";
        lblStatCreatedSessionsTitle.Size = new System.Drawing.Size(109, 20);
        lblStatCreatedSessionsTitle.TabIndex = 0;
        lblStatCreatedSessionsTitle.Text = "Lịch F04 đã tạo";
        // 
        // cardStatDestClass
        // 
        cardStatDestClass.BackColor = System.Drawing.Color.White;
        cardStatDestClass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatDestClass.BorderWidth = 1;
        cardStatDestClass.Controls.Add(lblStatDestClassVal);
        cardStatDestClass.Controls.Add(lblStatDestClassTitle);
        cardStatDestClass.CornerRadius = 6;
        cardStatDestClass.Location = new System.Drawing.Point(319, 80);
        cardStatDestClass.Name = "cardStatDestClass";
        cardStatDestClass.Padding = new System.Windows.Forms.Padding(16);
        cardStatDestClass.Size = new System.Drawing.Size(287, 85);
        cardStatDestClass.TabIndex = 3;
        // 
        // lblStatDestClassVal
        // 
        lblStatDestClassVal.AutoSize = true;
        lblStatDestClassVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatDestClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatDestClassVal.Location = new System.Drawing.Point(16, 38);
        lblStatDestClassVal.Name = "lblStatDestClassVal";
        lblStatDestClassVal.Size = new System.Drawing.Size(98, 41);
        lblStatDestClassVal.TabIndex = 1;
        lblStatDestClassVal.Text = "1 / 20";
        // 
        // lblStatDestClassTitle
        // 
        lblStatDestClassTitle.AutoSize = true;
        lblStatDestClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatDestClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatDestClassTitle.Location = new System.Drawing.Point(16, 16);
        lblStatDestClassTitle.Name = "lblStatDestClassTitle";
        lblStatDestClassTitle.Size = new System.Drawing.Size(133, 20);
        lblStatDestClassTitle.TabIndex = 0;
        lblStatDestClassTitle.Text = "Lớp đích IELTS-F04";
        // 
        // cardStatSourceClass
        // 
        cardStatSourceClass.BackColor = System.Drawing.Color.White;
        cardStatSourceClass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatSourceClass.BorderWidth = 1;
        cardStatSourceClass.Controls.Add(lblStatSourceClassVal);
        cardStatSourceClass.Controls.Add(lblStatSourceClassTitle);
        cardStatSourceClass.CornerRadius = 6;
        cardStatSourceClass.Location = new System.Drawing.Point(24, 80);
        cardStatSourceClass.Name = "cardStatSourceClass";
        cardStatSourceClass.Padding = new System.Windows.Forms.Padding(16);
        cardStatSourceClass.Size = new System.Drawing.Size(287, 85);
        cardStatSourceClass.TabIndex = 2;
        // 
        // lblStatSourceClassVal
        // 
        lblStatSourceClassVal.AutoSize = true;
        lblStatSourceClassVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatSourceClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatSourceClassVal.Location = new System.Drawing.Point(16, 38);
        lblStatSourceClassVal.Name = "lblStatSourceClassVal";
        lblStatSourceClassVal.Size = new System.Drawing.Size(115, 41);
        lblStatSourceClassVal.TabIndex = 1;
        lblStatSourceClassVal.Text = "17 / 20";
        // 
        // lblStatSourceClassTitle
        // 
        lblStatSourceClassTitle.AutoSize = true;
        lblStatSourceClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatSourceClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatSourceClassTitle.Location = new System.Drawing.Point(16, 16);
        lblStatSourceClassTitle.Name = "lblStatSourceClassTitle";
        lblStatSourceClassTitle.Size = new System.Drawing.Size(147, 20);
        lblStatSourceClassTitle.TabIndex = 0;
        lblStatSourceClassTitle.Text = "Lớp nguồn IELTS-F01";
        // 
        // bannerSuccess
        // 
        bannerSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerSuccess.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerSuccess.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerSuccess.Location = new System.Drawing.Point(24, 16);
        bannerSuccess.Message = ("✓  IELTS-F04 đã được mở sau xác nhận. Đã chuyển Lê Hoàng Nam từ IELTS-F01 sang IE" + "LTS-F04, hiệu lực 02/11/2026.");
        bannerSuccess.Name = "bannerSuccess";
        bannerSuccess.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerSuccess.Size = new System.Drawing.Size(1172, 58);
        bannerSuccess.TabIndex = 0;
        bannerSuccess.Title = "Thông báo nghiệp vụ";
        bannerSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // ClassTransferCompleteDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlStepper);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Mở lớp & hoàn tất chuyển lớp";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlStepper.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        pnlTwoCards.ResumeLayout(false);
        cardReceipt.ResumeLayout(false);
        cardReceipt.PerformLayout();
        cardPreCheck.ResumeLayout(false);
        cardPreCheck.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChecklist).EndInit();
        cardStatDestStatus.ResumeLayout(false);
        cardStatDestStatus.PerformLayout();
        cardStatCreatedSessions.ResumeLayout(false);
        cardStatCreatedSessions.PerformLayout();
        cardStatDestClass.ResumeLayout(false);
        cardStatDestClass.PerformLayout();
        cardStatSourceClass.ResumeLayout(false);
        cardStatSourceClass.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlStepper;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppBanner bannerSuccess;
    private ECMS.UI.Controls.AppCard cardStatSourceClass;
    private System.Windows.Forms.Label lblStatSourceClassTitle;
    private System.Windows.Forms.Label lblStatSourceClassVal;
    private ECMS.UI.Controls.AppCard cardStatDestClass;
    private System.Windows.Forms.Label lblStatDestClassTitle;
    private System.Windows.Forms.Label lblStatDestClassVal;
    private ECMS.UI.Controls.AppCard cardStatCreatedSessions;
    private System.Windows.Forms.Label lblStatCreatedSessionsTitle;
    private System.Windows.Forms.Label lblStatCreatedSessionsVal;
    private ECMS.UI.Controls.AppCard cardStatDestStatus;
    private System.Windows.Forms.Label lblStatDestStatusTitle;
    private System.Windows.Forms.Label lblStatDestStatusVal;
    private System.Windows.Forms.Panel pnlTwoCards;
    private ECMS.UI.Controls.AppCard cardPreCheck;
    private System.Windows.Forms.Label lblPreCheckTitle;
    private ECMS.UI.Controls.AppDataGrid dgvChecklist;
    private ECMS.UI.Controls.AppCard cardReceipt;
    private System.Windows.Forms.Label lblReceiptTitle;
    private System.Windows.Forms.Label lblStudentNameKey;
    private System.Windows.Forms.Label lblStudentNameVal;
    private System.Windows.Forms.Label lblReasonKey;
    private System.Windows.Forms.Label lblReasonVal;
    private System.Windows.Forms.Label lblClassPairKey;
    private System.Windows.Forms.Label lblClassPairVal;
    private System.Windows.Forms.Label lblEffectiveDateKey;
    private System.Windows.Forms.Label lblEffectiveDateVal;
    private System.Windows.Forms.Label lblOldHistoryKey;
    private System.Windows.Forms.Label lblOldHistoryVal;
    private System.Windows.Forms.Label lblFinanceKey;
    private System.Windows.Forms.Label lblFinanceVal;
    private System.Windows.Forms.Label lblConfirmedByKey;
    private System.Windows.Forms.Label lblConfirmedByVal;
    private ECMS.UI.Controls.AppButton btnOpenClassF04;
    private ECMS.UI.Controls.AppButton btnViewStudentHistory;
    private System.Windows.Forms.Label lblDoneTransferNote;
}
