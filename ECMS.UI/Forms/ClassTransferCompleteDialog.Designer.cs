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

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
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
        lblCheckFooterNote = new System.Windows.Forms.Label();
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
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(325, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Trạng thái tiếp nối ngày 02/11/2026 · Sau bước lập lịch 04.3";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(306, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Mở lớp & hoàn tất chuyển lớp";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(232, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lớp học / Mở lớp & hoàn tất chuyển lớp";
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
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
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
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
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
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
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
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
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
        pnlTwoCards.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pnlTwoCards.Controls.Add(cardReceipt);
        pnlTwoCards.Controls.Add(cardPreCheck);
        pnlTwoCards.Location = new System.Drawing.Point(24, 185);
        pnlTwoCards.Name = "pnlTwoCards";
        pnlTwoCards.Size = new System.Drawing.Size(1172, 420);
        pnlTwoCards.TabIndex = 6;
        // 
        // cardReceipt
        // 
        cardReceipt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardReceipt.BackColor = System.Drawing.Color.White;
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
        lblDoneTransferNote.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
        lblDoneTransferNote.Location = new System.Drawing.Point(20, 368);
        lblDoneTransferNote.Name = "lblDoneTransferNote";
        lblDoneTransferNote.Size = new System.Drawing.Size(134, 15);
        lblDoneTransferNote.TabIndex = 17;
        lblDoneTransferNote.Text = "✓ Hoàn tất chuyển lớp";
        // 
        // btnViewStudentHistory
        // 
        btnViewStudentHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnViewStudentHistory.BackColor = System.Drawing.Color.White;
        btnViewStudentHistory.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnViewStudentHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnViewStudentHistory.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnViewStudentHistory.Location = new System.Drawing.Point(395, 355);
        btnViewStudentHistory.Name = "btnViewStudentHistory";
        btnViewStudentHistory.Size = new System.Drawing.Size(155, 36);
        btnViewStudentHistory.TabIndex = 16;
        btnViewStudentHistory.Text = "Xem lịch sử học viên";
        btnViewStudentHistory.UseVisualStyleBackColor = false;
        // 
        // btnOpenClassF04
        // 
        btnOpenClassF04.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnOpenClassF04.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnOpenClassF04.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnOpenClassF04.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenClassF04.ForeColor = System.Drawing.Color.White;
        btnOpenClassF04.Location = new System.Drawing.Point(235, 355);
        btnOpenClassF04.Name = "btnOpenClassF04";
        btnOpenClassF04.Size = new System.Drawing.Size(150, 36);
        btnOpenClassF04.TabIndex = 15;
        btnOpenClassF04.Text = "Mở lớp IELTS-F04";
        btnOpenClassF04.UseVisualStyleBackColor = false;
        // 
        // lblConfirmedByVal
        // 
        lblConfirmedByVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblConfirmedByVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblConfirmedByKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblConfirmedByKey.Location = new System.Drawing.Point(20, 292);
        lblConfirmedByKey.Name = "lblConfirmedByKey";
        lblConfirmedByKey.Size = new System.Drawing.Size(91, 15);
        lblConfirmedByKey.TabIndex = 13;
        lblConfirmedByKey.Text = "Người xác nhận";
        // 
        // lblFinanceVal
        // 
        lblFinanceVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFinanceVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblFinanceKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblFinanceKey.Location = new System.Drawing.Point(20, 252);
        lblFinanceKey.Name = "lblFinanceKey";
        lblFinanceKey.Size = new System.Drawing.Size(53, 15);
        lblFinanceKey.TabIndex = 11;
        lblFinanceKey.Text = "Tài chính";
        // 
        // lblOldHistoryVal
        // 
        lblOldHistoryVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblOldHistoryVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblOldHistoryKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblOldHistoryKey.Location = new System.Drawing.Point(20, 212);
        lblOldHistoryKey.Name = "lblOldHistoryKey";
        lblOldHistoryKey.Size = new System.Drawing.Size(126, 15);
        lblOldHistoryKey.TabIndex = 9;
        lblOldHistoryKey.Text = "Điểm / chuyên cần cũ";
        // 
        // lblEffectiveDateVal
        // 
        lblEffectiveDateVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEffectiveDateVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblEffectiveDateKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblEffectiveDateKey.Location = new System.Drawing.Point(20, 172);
        lblEffectiveDateKey.Name = "lblEffectiveDateKey";
        lblEffectiveDateKey.Size = new System.Drawing.Size(81, 15);
        lblEffectiveDateKey.TabIndex = 7;
        lblEffectiveDateKey.Text = "Ngày hiệu lực";
        // 
        // lblClassPairVal
        // 
        lblClassPairVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClassPairVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblClassPairKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblClassPairKey.Location = new System.Drawing.Point(20, 132);
        lblClassPairKey.Name = "lblClassPairKey";
        lblClassPairKey.Size = new System.Drawing.Size(107, 15);
        lblClassPairKey.TabIndex = 5;
        lblClassPairKey.Text = "Lớp nguồn ➔ đích";
        // 
        // lblReasonVal
        // 
        lblReasonVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblReasonVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
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
        lblReasonKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblReasonKey.Location = new System.Drawing.Point(20, 92);
        lblReasonKey.Name = "lblReasonKey";
        lblReasonKey.Size = new System.Drawing.Size(36, 15);
        lblReasonKey.TabIndex = 3;
        lblReasonKey.Text = "Lý do";
        // 
        // lblStudentNameVal
        // 
        lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentNameVal.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
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
        lblStudentNameKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStudentNameKey.Location = new System.Drawing.Point(20, 52);
        lblStudentNameKey.Name = "lblStudentNameKey";
        lblStudentNameKey.Size = new System.Drawing.Size(55, 15);
        lblStudentNameKey.TabIndex = 1;
        lblStudentNameKey.Text = "Học viên";
        // 
        // lblReceiptTitle
        // 
        lblReceiptTitle.AutoSize = true;
        lblReceiptTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblReceiptTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblReceiptTitle.Location = new System.Drawing.Point(20, 16);
        lblReceiptTitle.Name = "lblReceiptTitle";
        lblReceiptTitle.Size = new System.Drawing.Size(175, 21);
        lblReceiptTitle.TabIndex = 0;
        lblReceiptTitle.Text = "Biên nhận chuyển lớp";
        // 
        // cardPreCheck
        // 
        cardPreCheck.BackColor = System.Drawing.Color.White;
        cardPreCheck.Controls.Add(lblCheckFooterNote);
        cardPreCheck.Controls.Add(dgvChecklist);
        cardPreCheck.Controls.Add(lblPreCheckTitle);
        cardPreCheck.Location = new System.Drawing.Point(0, 0);
        cardPreCheck.Name = "cardPreCheck";
        cardPreCheck.Padding = new System.Windows.Forms.Padding(20);
        cardPreCheck.Size = new System.Drawing.Size(572, 410);
        cardPreCheck.TabIndex = 0;
        // 
        // lblCheckFooterNote
        // 
        lblCheckFooterNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblCheckFooterNote.AutoSize = true;
        lblCheckFooterNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblCheckFooterNote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCheckFooterNote.Location = new System.Drawing.Point(20, 368);
        lblCheckFooterNote.Name = "lblCheckFooterNote";
        lblCheckFooterNote.Size = new System.Drawing.Size(434, 15);
        lblCheckFooterNote.TabIndex = 2;
        lblCheckFooterNote.Text = "Đã xác nhận mở lớp lúc 09:05. Không yêu cầu sĩ số tối thiểu trong dữ liệu mẫu.";
        // 
        // dgvChecklist
        // 
        dgvChecklist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChecklist.Location = new System.Drawing.Point(20, 50);
        dgvChecklist.Name = "dgvChecklist";
        dgvChecklist.Size = new System.Drawing.Size(532, 300);
        dgvChecklist.TabIndex = 1;
        // 
        // lblPreCheckTitle
        // 
        lblPreCheckTitle.AutoSize = true;
        lblPreCheckTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblPreCheckTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblPreCheckTitle.Location = new System.Drawing.Point(20, 16);
        lblPreCheckTitle.Name = "lblPreCheckTitle";
        lblPreCheckTitle.Size = new System.Drawing.Size(200, 21);
        lblPreCheckTitle.TabIndex = 0;
        lblPreCheckTitle.Text = "Kiểm tra trước khi mở lớp";
        // 
        // cardStatDestStatus
        // 
        cardStatDestStatus.BackColor = System.Drawing.Color.White;
        cardStatDestStatus.Controls.Add(lblStatDestStatusVal);
        cardStatDestStatus.Controls.Add(lblStatDestStatusTitle);
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
        lblStatDestStatusVal.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblStatDestStatusVal.Location = new System.Drawing.Point(16, 38);
        lblStatDestStatusVal.Name = "lblStatDestStatusVal";
        lblStatDestStatusVal.Size = new System.Drawing.Size(124, 32);
        lblStatDestStatusVal.TabIndex = 1;
        lblStatDestStatusVal.Text = "Đang học";
        // 
        // lblStatDestStatusTitle
        // 
        lblStatDestStatusTitle.AutoSize = true;
        lblStatDestStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatDestStatusTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatDestStatusTitle.Location = new System.Drawing.Point(16, 16);
        lblStatDestStatusTitle.Name = "lblStatDestStatusTitle";
        lblStatDestStatusTitle.Size = new System.Drawing.Size(107, 15);
        lblStatDestStatusTitle.TabIndex = 0;
        lblStatDestStatusTitle.Text = "Trạng thái lớp đích";
        // 
        // cardStatCreatedSessions
        // 
        cardStatCreatedSessions.BackColor = System.Drawing.Color.White;
        cardStatCreatedSessions.Controls.Add(lblStatCreatedSessionsVal);
        cardStatCreatedSessions.Controls.Add(lblStatCreatedSessionsTitle);
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
        lblStatCreatedSessionsVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatCreatedSessionsVal.Location = new System.Drawing.Point(16, 38);
        lblStatCreatedSessionsVal.Name = "lblStatCreatedSessionsVal";
        lblStatCreatedSessionsVal.Size = new System.Drawing.Size(100, 32);
        lblStatCreatedSessionsVal.TabIndex = 1;
        lblStatCreatedSessionsVal.Text = "24 buổi";
        // 
        // lblStatCreatedSessionsTitle
        // 
        lblStatCreatedSessionsTitle.AutoSize = true;
        lblStatCreatedSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatCreatedSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatCreatedSessionsTitle.Location = new System.Drawing.Point(16, 16);
        lblStatCreatedSessionsTitle.Name = "lblStatCreatedSessionsTitle";
        lblStatCreatedSessionsTitle.Size = new System.Drawing.Size(95, 15);
        lblStatCreatedSessionsTitle.TabIndex = 0;
        lblStatCreatedSessionsTitle.Text = "Lịch F04 đã tạo";
        // 
        // cardStatDestClass
        // 
        cardStatDestClass.BackColor = System.Drawing.Color.White;
        cardStatDestClass.Controls.Add(lblStatDestClassVal);
        cardStatDestClass.Controls.Add(lblStatDestClassTitle);
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
        lblStatDestClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatDestClassVal.Location = new System.Drawing.Point(16, 38);
        lblStatDestClassVal.Name = "lblStatDestClassVal";
        lblStatDestClassVal.Size = new System.Drawing.Size(80, 32);
        lblStatDestClassVal.TabIndex = 1;
        lblStatDestClassVal.Text = "1 / 20";
        // 
        // lblStatDestClassTitle
        // 
        lblStatDestClassTitle.AutoSize = true;
        lblStatDestClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatDestClassTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatDestClassTitle.Location = new System.Drawing.Point(16, 16);
        lblStatDestClassTitle.Name = "lblStatDestClassTitle";
        lblStatDestClassTitle.Size = new System.Drawing.Size(107, 15);
        lblStatDestClassTitle.TabIndex = 0;
        lblStatDestClassTitle.Text = "Lớp đích IELTS-F04";
        // 
        // cardStatSourceClass
        // 
        cardStatSourceClass.BackColor = System.Drawing.Color.White;
        cardStatSourceClass.Controls.Add(lblStatSourceClassVal);
        cardStatSourceClass.Controls.Add(lblStatSourceClassTitle);
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
        lblStatSourceClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatSourceClassVal.Location = new System.Drawing.Point(16, 38);
        lblStatSourceClassVal.Name = "lblStatSourceClassVal";
        lblStatSourceClassVal.Size = new System.Drawing.Size(94, 32);
        lblStatSourceClassVal.TabIndex = 1;
        lblStatSourceClassVal.Text = "17 / 20";
        // 
        // lblStatSourceClassTitle
        // 
        lblStatSourceClassTitle.AutoSize = true;
        lblStatSourceClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatSourceClassTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatSourceClassTitle.Location = new System.Drawing.Point(16, 16);
        lblStatSourceClassTitle.Name = "lblStatSourceClassTitle";
        lblStatSourceClassTitle.Size = new System.Drawing.Size(117, 15);
        lblStatSourceClassTitle.TabIndex = 0;
        lblStatSourceClassTitle.Text = "Lớp nguồn IELTS-F01";
        // 
        // bannerSuccess
        // 
        bannerSuccess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerSuccess.Location = new System.Drawing.Point(24, 16);
        bannerSuccess.Message = "✓  IELTS-F04 đã được mở sau xác nhận. Đã chuyển Lê Hoàng Nam từ IELTS-F01 sang IELTS-F04, hiệu lực 02/11/2026.";
        bannerSuccess.Name = "bannerSuccess";
        bannerSuccess.Size = new System.Drawing.Size(1172, 45);
        bannerSuccess.TabIndex = 0;
        // 
        // ClassTransferCompleteDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlStepper);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ClassTransferCompleteDialog";
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
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
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
    private System.Windows.Forms.Label lblCheckFooterNote;
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
