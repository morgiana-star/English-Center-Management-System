namespace ECMS.UI.Forms;

partial class ReceiptPrintPreviewDialog
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
        btnPrintTop = new ECMS.UI.Controls.AppButton();
        btnClosePreview = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        pnlReceiptWrapper = new System.Windows.Forms.Panel();
        pnlA5Sheet = new System.Windows.Forms.Panel();
        lblCollectorSignVal = new System.Windows.Forms.Label();
        lblCollectorSignTitle = new System.Windows.Forms.Label();
        lblPayerSignVal = new System.Windows.Forms.Label();
        lblPayerSignTitle = new System.Windows.Forms.Label();
        lblBalanceVal = new System.Windows.Forms.Label();
        lblBalanceTitle = new System.Windows.Forms.Label();
        lblTransIdVal = new System.Windows.Forms.Label();
        lblTransIdTitle = new System.Windows.Forms.Label();
        lblMethodVal = new System.Windows.Forms.Label();
        lblMethodTitle = new System.Windows.Forms.Label();
        lblWordsVal = new System.Windows.Forms.Label();
        lblWordsTitle = new System.Windows.Forms.Label();
        lblAmountVal = new System.Windows.Forms.Label();
        lblAmountTitle = new System.Windows.Forms.Label();
        lblReasonVal = new System.Windows.Forms.Label();
        lblReasonTitle = new System.Windows.Forms.Label();
        lblCourseVal = new System.Windows.Forms.Label();
        lblCourseTitle = new System.Windows.Forms.Label();
        lblPayerVal = new System.Windows.Forms.Label();
        lblPayerTitle = new System.Windows.Forms.Label();
        lblReceiptDate = new System.Windows.Forms.Label();
        lblReceiptDocTitle = new System.Windows.Forms.Label();
        lblOrgAddress = new System.Windows.Forms.Label();
        lblReceiptNumber = new System.Windows.Forms.Label();
        lblOrgName = new System.Windows.Forms.Label();
        cardPrintSettings = new ECMS.UI.Controls.AppCard();
        lblSettingsCardTitle = new System.Windows.Forms.Label();
        lblSumRemaining = new System.Windows.Forms.Label();
        lblSumTotalPaid = new System.Windows.Forms.Label();
        lblSumReceiptDate = new System.Windows.Forms.Label();
        lblSumTransCode = new System.Windows.Forms.Label();
        btnPrint = new ECMS.UI.Controls.AppButton();
        rbPreviewMode = new System.Windows.Forms.RadioButton();
        rbDirectPrint = new System.Windows.Forms.RadioButton();
        cboPaperSize = new ECMS.UI.Controls.AppComboBox();
        lblPaperSizeTitle = new System.Windows.Forms.Label();
        txtCopies = new ECMS.UI.Controls.AppTextBox();
        lblCopiesTitle = new System.Windows.Forms.Label();
        cboPrinter = new ECMS.UI.Controls.AppComboBox();
        lblPrinterTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlReceiptWrapper.SuspendLayout();
        pnlA5Sheet.SuspendLayout();
        cardPrintSettings.SuspendLayout();
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
        pnlTopActions.Controls.Add(btnPrintTop);
        pnlTopActions.Controls.Add(btnClosePreview);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(870, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnPrintTop
        // 
        btnPrintTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPrintTop.CornerRadius = 5;
        btnPrintTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPrintTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrintTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPrintTop.Location = new System.Drawing.Point(177, 3);
        btnPrintTop.Name = "btnPrintTop";
        btnPrintTop.Size = new System.Drawing.Size(120, 38);
        btnPrintTop.TabIndex = 0;
        btnPrintTop.Text = "In phiếu";
        btnPrintTop.UseVisualStyleBackColor = true;
        btnPrintTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnClosePreview
        // 
        btnClosePreview.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClosePreview.CornerRadius = 5;
        btnClosePreview.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClosePreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClosePreview.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClosePreview.Location = new System.Drawing.Point(41, 3);
        btnClosePreview.Name = "btnClosePreview";
        btnClosePreview.Size = new System.Drawing.Size(130, 38);
        btnClosePreview.TabIndex = 1;
        btnClosePreview.Text = "Đóng xem trước";
        btnClosePreview.UseVisualStyleBackColor = true;
        btnClosePreview.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(409, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xem trước khi in · PT-261030-018";
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
        pnlBody.Controls.Add(pnlReceiptWrapper, 0, 0);
        pnlBody.Controls.Add(cardPrintSettings, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 78);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(1200, 662);
        pnlBody.TabIndex = 1;
        // 
        // pnlReceiptWrapper
        // 
        pnlReceiptWrapper.AutoScroll = true;
        pnlReceiptWrapper.BackColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlReceiptWrapper.Controls.Add(pnlA5Sheet);
        pnlReceiptWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlReceiptWrapper.Location = new System.Drawing.Point(23, 15);
        pnlReceiptWrapper.Name = "pnlReceiptWrapper";
        pnlReceiptWrapper.Padding = new System.Windows.Forms.Padding(24);
        pnlReceiptWrapper.Size = new System.Drawing.Size(736, 628);
        pnlReceiptWrapper.TabIndex = 0;
        // 
        // pnlA5Sheet
        // 
        pnlA5Sheet.Anchor = System.Windows.Forms.AnchorStyles.Top;
        pnlA5Sheet.BackColor = System.Drawing.Color.White;
        pnlA5Sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlA5Sheet.Controls.Add(lblCollectorSignVal);
        pnlA5Sheet.Controls.Add(lblCollectorSignTitle);
        pnlA5Sheet.Controls.Add(lblPayerSignVal);
        pnlA5Sheet.Controls.Add(lblPayerSignTitle);
        pnlA5Sheet.Controls.Add(lblBalanceVal);
        pnlA5Sheet.Controls.Add(lblBalanceTitle);
        pnlA5Sheet.Controls.Add(lblTransIdVal);
        pnlA5Sheet.Controls.Add(lblTransIdTitle);
        pnlA5Sheet.Controls.Add(lblMethodVal);
        pnlA5Sheet.Controls.Add(lblMethodTitle);
        pnlA5Sheet.Controls.Add(lblWordsVal);
        pnlA5Sheet.Controls.Add(lblWordsTitle);
        pnlA5Sheet.Controls.Add(lblAmountVal);
        pnlA5Sheet.Controls.Add(lblAmountTitle);
        pnlA5Sheet.Controls.Add(lblReasonVal);
        pnlA5Sheet.Controls.Add(lblReasonTitle);
        pnlA5Sheet.Controls.Add(lblCourseVal);
        pnlA5Sheet.Controls.Add(lblCourseTitle);
        pnlA5Sheet.Controls.Add(lblPayerVal);
        pnlA5Sheet.Controls.Add(lblPayerTitle);
        pnlA5Sheet.Controls.Add(lblReceiptDate);
        pnlA5Sheet.Controls.Add(lblReceiptDocTitle);
        pnlA5Sheet.Controls.Add(lblOrgAddress);
        pnlA5Sheet.Controls.Add(lblReceiptNumber);
        pnlA5Sheet.Controls.Add(lblOrgName);
        pnlA5Sheet.Location = new System.Drawing.Point(40, 10);
        pnlA5Sheet.Name = "pnlA5Sheet";
        pnlA5Sheet.Padding = new System.Windows.Forms.Padding(24);
        pnlA5Sheet.Size = new System.Drawing.Size(650, 580);
        pnlA5Sheet.TabIndex = 0;
        // 
        // lblCollectorSignVal
        // 
        lblCollectorSignVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCollectorSignVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCollectorSignVal.Location = new System.Drawing.Point(400, 480);
        lblCollectorSignVal.Name = "lblCollectorSignVal";
        lblCollectorSignVal.Size = new System.Drawing.Size(200, 20);
        lblCollectorSignVal.TabIndex = 24;
        lblCollectorSignVal.Text = "Lê Phương Thảo";
        lblCollectorSignVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCollectorSignTitle
        // 
        lblCollectorSignTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCollectorSignTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCollectorSignTitle.Location = new System.Drawing.Point(400, 420);
        lblCollectorSignTitle.Name = "lblCollectorSignTitle";
        lblCollectorSignTitle.Size = new System.Drawing.Size(200, 20);
        lblCollectorSignTitle.TabIndex = 23;
        lblCollectorSignTitle.Text = "Người thu tiền";
        lblCollectorSignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblPayerSignVal
        // 
        lblPayerSignVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPayerSignVal.Location = new System.Drawing.Point(40, 480);
        lblPayerSignVal.Name = "lblPayerSignVal";
        lblPayerSignVal.Size = new System.Drawing.Size(200, 20);
        lblPayerSignVal.TabIndex = 22;
        lblPayerSignVal.Text = "Nguyễn Minh Anh";
        lblPayerSignVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblPayerSignTitle
        // 
        lblPayerSignTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPayerSignTitle.Location = new System.Drawing.Point(40, 420);
        lblPayerSignTitle.Name = "lblPayerSignTitle";
        lblPayerSignTitle.Size = new System.Drawing.Size(200, 20);
        lblPayerSignTitle.TabIndex = 21;
        lblPayerSignTitle.Text = "Người nộp tiền";
        lblPayerSignTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblBalanceVal
        // 
        lblBalanceVal.AutoSize = true;
        lblBalanceVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBalanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblBalanceVal.Location = new System.Drawing.Point(145, 360);
        lblBalanceVal.Name = "lblBalanceVal";
        lblBalanceVal.Size = new System.Drawing.Size(217, 20);
        lblBalanceVal.TabIndex = 20;
        lblBalanceVal.Text = "1.900.000đ · hạn 15/11/2026";
        // 
        // lblBalanceTitle
        // 
        lblBalanceTitle.AutoSize = true;
        lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblBalanceTitle.Location = new System.Drawing.Point(36, 360);
        lblBalanceTitle.Name = "lblBalanceTitle";
        lblBalanceTitle.Size = new System.Drawing.Size(102, 20);
        lblBalanceTitle.TabIndex = 19;
        lblBalanceTitle.Text = "Số dư sau thu:";
        // 
        // lblTransIdVal
        // 
        lblTransIdVal.AutoSize = true;
        lblTransIdVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTransIdVal.Location = new System.Drawing.Point(145, 330);
        lblTransIdVal.Name = "lblTransIdVal";
        lblTransIdVal.Size = new System.Drawing.Size(284, 20);
        lblTransIdVal.TabIndex = 18;
        lblTransIdVal.Text = "GD-261030-018 · Tham chiếu CK3010-MA";
        // 
        // lblTransIdTitle
        // 
        lblTransIdTitle.AutoSize = true;
        lblTransIdTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTransIdTitle.Location = new System.Drawing.Point(36, 330);
        lblTransIdTitle.Name = "lblTransIdTitle";
        lblTransIdTitle.Size = new System.Drawing.Size(99, 20);
        lblTransIdTitle.TabIndex = 17;
        lblTransIdTitle.Text = "Mã giao dịch:";
        // 
        // lblMethodVal
        // 
        lblMethodVal.AutoSize = true;
        lblMethodVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMethodVal.Location = new System.Drawing.Point(145, 300);
        lblMethodVal.Name = "lblMethodVal";
        lblMethodVal.Size = new System.Drawing.Size(234, 20);
        lblMethodVal.TabIndex = 16;
        lblMethodVal.Text = "Chuyển khoản - ghi nhận thủ công";
        // 
        // lblMethodTitle
        // 
        lblMethodTitle.AutoSize = true;
        lblMethodTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMethodTitle.Location = new System.Drawing.Point(36, 300);
        lblMethodTitle.Name = "lblMethodTitle";
        lblMethodTitle.Size = new System.Drawing.Size(96, 20);
        lblMethodTitle.TabIndex = 15;
        lblMethodTitle.Text = "Phương thức:";
        // 
        // lblWordsVal
        // 
        lblWordsVal.AutoSize = true;
        lblWordsVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblWordsVal.Location = new System.Drawing.Point(145, 270);
        lblWordsVal.Name = "lblWordsVal";
        lblWordsVal.Size = new System.Drawing.Size(246, 20);
        lblWordsVal.TabIndex = 14;
        lblWordsVal.Text = "Một triệu năm trăm nghìn đồng chẵn";
        // 
        // lblWordsTitle
        // 
        lblWordsTitle.AutoSize = true;
        lblWordsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblWordsTitle.Location = new System.Drawing.Point(36, 270);
        lblWordsTitle.Name = "lblWordsTitle";
        lblWordsTitle.Size = new System.Drawing.Size(74, 20);
        lblWordsTitle.TabIndex = 13;
        lblWordsTitle.Text = "Bằng chữ:";
        // 
        // lblAmountVal
        // 
        lblAmountVal.AutoSize = true;
        lblAmountVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblAmountVal.Location = new System.Drawing.Point(145, 237);
        lblAmountVal.Name = "lblAmountVal";
        lblAmountVal.Size = new System.Drawing.Size(116, 25);
        lblAmountVal.TabIndex = 12;
        lblAmountVal.Text = "1.500.000 đ";
        // 
        // lblAmountTitle
        // 
        lblAmountTitle.AutoSize = true;
        lblAmountTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAmountTitle.Location = new System.Drawing.Point(36, 240);
        lblAmountTitle.Name = "lblAmountTitle";
        lblAmountTitle.Size = new System.Drawing.Size(58, 20);
        lblAmountTitle.TabIndex = 11;
        lblAmountTitle.Text = "Số tiền:";
        // 
        // lblReasonVal
        // 
        lblReasonVal.AutoSize = true;
        lblReasonVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblReasonVal.Location = new System.Drawing.Point(145, 210);
        lblReasonVal.Name = "lblReasonVal";
        lblReasonVal.Size = new System.Drawing.Size(100, 20);
        lblReasonVal.TabIndex = 10;
        lblReasonVal.Text = "Học phí đợt 2";
        // 
        // lblReasonTitle
        // 
        lblReasonTitle.AutoSize = true;
        lblReasonTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblReasonTitle.Location = new System.Drawing.Point(36, 210);
        lblReasonTitle.Name = "lblReasonTitle";
        lblReasonTitle.Size = new System.Drawing.Size(72, 20);
        lblReasonTitle.TabIndex = 9;
        lblReasonTitle.Text = "Lý do thu:";
        // 
        // lblCourseVal
        // 
        lblCourseVal.AutoSize = true;
        lblCourseVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseVal.Location = new System.Drawing.Point(145, 180);
        lblCourseVal.Name = "lblCourseVal";
        lblCourseVal.Size = new System.Drawing.Size(199, 20);
        lblCourseVal.TabIndex = 8;
        lblCourseVal.Text = "IELTS Foundation / IELTS-F01";
        // 
        // lblCourseTitle
        // 
        lblCourseTitle.AutoSize = true;
        lblCourseTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseTitle.Location = new System.Drawing.Point(36, 180);
        lblCourseTitle.Name = "lblCourseTitle";
        lblCourseTitle.Size = new System.Drawing.Size(82, 20);
        lblCourseTitle.TabIndex = 7;
        lblCourseTitle.Text = "Khóa / lớp:";
        // 
        // lblPayerVal
        // 
        lblPayerVal.AutoSize = true;
        lblPayerVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPayerVal.Location = new System.Drawing.Point(145, 150);
        lblPayerVal.Name = "lblPayerVal";
        lblPayerVal.Size = new System.Drawing.Size(212, 20);
        lblPayerVal.TabIndex = 6;
        lblPayerVal.Text = "Nguyễn Minh Anh · HV-0241";
        // 
        // lblPayerTitle
        // 
        lblPayerTitle.AutoSize = true;
        lblPayerTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPayerTitle.Location = new System.Drawing.Point(36, 150);
        lblPayerTitle.Name = "lblPayerTitle";
        lblPayerTitle.Size = new System.Drawing.Size(113, 20);
        lblPayerTitle.TabIndex = 5;
        lblPayerTitle.Text = "Người nộp tiền:";
        // 
        // lblReceiptDate
        // 
        lblReceiptDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblReceiptDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblReceiptDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblReceiptDate.Location = new System.Drawing.Point(24, 110);
        lblReceiptDate.Name = "lblReceiptDate";
        lblReceiptDate.Size = new System.Drawing.Size(600, 18);
        lblReceiptDate.TabIndex = 4;
        lblReceiptDate.Text = "Ngày 30 tháng 10 năm 2026";
        lblReceiptDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblReceiptDocTitle
        // 
        lblReceiptDocTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblReceiptDocTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblReceiptDocTitle.Location = new System.Drawing.Point(24, 80);
        lblReceiptDocTitle.Name = "lblReceiptDocTitle";
        lblReceiptDocTitle.Size = new System.Drawing.Size(600, 28);
        lblReceiptDocTitle.TabIndex = 3;
        lblReceiptDocTitle.Text = "PHIẾU THU HỌC PHÍ";
        lblReceiptDocTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblOrgAddress
        // 
        lblOrgAddress.AutoSize = true;
        lblOrgAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblOrgAddress.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblOrgAddress.Location = new System.Drawing.Point(24, 42);
        lblOrgAddress.Name = "lblOrgAddress";
        lblOrgAddress.Size = new System.Drawing.Size(242, 20);
        lblOrgAddress.TabIndex = 2;
        lblOrgAddress.Text = "25 Nguyễn Văn Cừ, TP. Hồ Chí Minh";
        // 
        // lblReceiptNumber
        // 
        lblReceiptNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblReceiptNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblReceiptNumber.Location = new System.Drawing.Point(420, 20);
        lblReceiptNumber.Name = "lblReceiptNumber";
        lblReceiptNumber.Size = new System.Drawing.Size(200, 18);
        lblReceiptNumber.TabIndex = 1;
        lblReceiptNumber.Text = "Số: PT-261030-018";
        lblReceiptNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblOrgName
        // 
        lblOrgName.AutoSize = true;
        lblOrgName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblOrgName.Location = new System.Drawing.Point(24, 20);
        lblOrgName.Name = "lblOrgName";
        lblOrgName.Size = new System.Drawing.Size(279, 23);
        lblOrgName.TabIndex = 0;
        lblOrgName.Text = "TRUNG TÂM ANH NGỮ MINH TRÍ";
        // 
        // cardPrintSettings
        // 
        cardPrintSettings.BackColor = System.Drawing.Color.White;
        cardPrintSettings.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPrintSettings.BorderWidth = 1;
        cardPrintSettings.Controls.Add(lblSettingsCardTitle);
        cardPrintSettings.Controls.Add(lblSumRemaining);
        cardPrintSettings.Controls.Add(lblSumTotalPaid);
        cardPrintSettings.Controls.Add(lblSumReceiptDate);
        cardPrintSettings.Controls.Add(lblSumTransCode);
        cardPrintSettings.Controls.Add(btnPrint);
        cardPrintSettings.Controls.Add(rbPreviewMode);
        cardPrintSettings.Controls.Add(rbDirectPrint);
        cardPrintSettings.Controls.Add(cboPaperSize);
        cardPrintSettings.Controls.Add(lblPaperSizeTitle);
        cardPrintSettings.Controls.Add(txtCopies);
        cardPrintSettings.Controls.Add(lblCopiesTitle);
        cardPrintSettings.Controls.Add(cboPrinter);
        cardPrintSettings.Controls.Add(lblPrinterTitle);
        cardPrintSettings.CornerRadius = 6;
        cardPrintSettings.Dock = System.Windows.Forms.DockStyle.Fill;
        cardPrintSettings.Location = new System.Drawing.Point(765, 15);
        cardPrintSettings.Name = "cardPrintSettings";
        cardPrintSettings.Padding = new System.Windows.Forms.Padding(20);
        cardPrintSettings.Size = new System.Drawing.Size(412, 628);
        cardPrintSettings.TabIndex = 1;
        // 
        // lblSettingsCardTitle
        // 
        lblSettingsCardTitle.AutoSize = true;
        lblSettingsCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSettingsCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSettingsCardTitle.Location = new System.Drawing.Point(20, 16);
        lblSettingsCardTitle.Name = "lblSettingsCardTitle";
        lblSettingsCardTitle.Size = new System.Drawing.Size(110, 25);
        lblSettingsCardTitle.TabIndex = 14;
        lblSettingsCardTitle.Text = "Thiết lập in";
        // 
        // lblSumRemaining
        // 
        lblSumRemaining.AutoSize = true;
        lblSumRemaining.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblSumRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSumRemaining.Location = new System.Drawing.Point(20, 470);
        lblSumRemaining.Name = "lblSumRemaining";
        lblSumRemaining.Size = new System.Drawing.Size(194, 20);
        lblSumRemaining.TabIndex = 13;
        lblSumRemaining.Text = "Số dư còn lại:   1.900.000đ";
        // 
        // lblSumTotalPaid
        // 
        lblSumTotalPaid.AutoSize = true;
        lblSumTotalPaid.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSumTotalPaid.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSumTotalPaid.Location = new System.Drawing.Point(20, 440);
        lblSumTotalPaid.Name = "lblSumTotalPaid";
        lblSumTotalPaid.Size = new System.Drawing.Size(175, 20);
        lblSumTotalPaid.TabIndex = 12;
        lblSumTotalPaid.Text = "Tổng đã thu:   3.500.000đ";
        // 
        // lblSumReceiptDate
        // 
        lblSumReceiptDate.AutoSize = true;
        lblSumReceiptDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSumReceiptDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSumReceiptDate.Location = new System.Drawing.Point(20, 410);
        lblSumReceiptDate.Name = "lblSumReceiptDate";
        lblSumReceiptDate.Size = new System.Drawing.Size(176, 20);
        lblSumReceiptDate.TabIndex = 11;
        lblSumReceiptDate.Text = "Ngày phiếu:   30/10/2026";
        // 
        // lblSumTransCode
        // 
        lblSumTransCode.AutoSize = true;
        lblSumTransCode.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSumTransCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSumTransCode.Location = new System.Drawing.Point(20, 380);
        lblSumTransCode.Name = "lblSumTransCode";
        lblSumTransCode.Size = new System.Drawing.Size(216, 20);
        lblSumTransCode.TabIndex = 10;
        lblSumTransCode.Text = "Mã giao dịch:   GD-261030-018";
        // 
        // btnPrint
        // 
        btnPrint.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPrint.CornerRadius = 5;
        btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnPrint.Location = new System.Drawing.Point(20, 310);
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new System.Drawing.Size(370, 40);
        btnPrint.TabIndex = 9;
        btnPrint.Text = "In phiếu";
        btnPrint.UseVisualStyleBackColor = true;
        btnPrint.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // rbPreviewMode
        // 
        rbPreviewMode.AutoSize = true;
        rbPreviewMode.Checked = true;
        rbPreviewMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        rbPreviewMode.Location = new System.Drawing.Point(140, 195);
        rbPreviewMode.Name = "rbPreviewMode";
        rbPreviewMode.Size = new System.Drawing.Size(104, 24);
        rbPreviewMode.TabIndex = 7;
        rbPreviewMode.TabStop = true;
        rbPreviewMode.Text = "Xem trước";
        rbPreviewMode.UseVisualStyleBackColor = true;
        // 
        // rbDirectPrint
        // 
        rbDirectPrint.AutoSize = true;
        rbDirectPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
        rbDirectPrint.Location = new System.Drawing.Point(22, 195);
        rbDirectPrint.Name = "rbDirectPrint";
        rbDirectPrint.Size = new System.Drawing.Size(102, 24);
        rbDirectPrint.TabIndex = 6;
        rbDirectPrint.Text = "In trực tiếp";
        rbDirectPrint.UseVisualStyleBackColor = true;
        // 
        // cboPaperSize
        // 
        cboPaperSize.BackColor = System.Drawing.Color.Transparent;
        cboPaperSize.CornerRadius = 5;
        cboPaperSize.DataSource = null;
        cboPaperSize.DisplayMember = "";
        cboPaperSize.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboPaperSize.Location = new System.Drawing.Point(210, 140);
        cboPaperSize.Name = "cboPaperSize";
        cboPaperSize.SelectedIndex = -1;
        cboPaperSize.SelectedItem = null;
        cboPaperSize.SelectedValue = null;
        cboPaperSize.Size = new System.Drawing.Size(180, 35);
        cboPaperSize.TabIndex = 5;
        cboPaperSize.ValueMember = "";
        // 
        // lblPaperSizeTitle
        // 
        lblPaperSizeTitle.AutoSize = true;
        lblPaperSizeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaperSizeTitle.Location = new System.Drawing.Point(210, 120);
        lblPaperSizeTitle.Name = "lblPaperSizeTitle";
        lblPaperSizeTitle.Size = new System.Drawing.Size(70, 20);
        lblPaperSizeTitle.TabIndex = 4;
        lblPaperSizeTitle.Text = "Khổ giấy";
        // 
        // txtCopies
        // 
        txtCopies.BackColor = System.Drawing.Color.Transparent;
        txtCopies.CornerRadius = 5;
        txtCopies.ErrorMessage = "";
        txtCopies.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtCopies.HasError = false;
        txtCopies.Location = new System.Drawing.Point(20, 140);
        txtCopies.Name = "txtCopies";
        txtCopies.Placeholder = "";
        txtCopies.ReadOnly = false;
        txtCopies.Size = new System.Drawing.Size(160, 36);
        txtCopies.TabIndex = 3;
        txtCopies.UseSystemPasswordChar = false;
        // 
        // lblCopiesTitle
        // 
        lblCopiesTitle.AutoSize = true;
        lblCopiesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCopiesTitle.Location = new System.Drawing.Point(20, 120);
        lblCopiesTitle.Name = "lblCopiesTitle";
        lblCopiesTitle.Size = new System.Drawing.Size(56, 20);
        lblCopiesTitle.TabIndex = 2;
        lblCopiesTitle.Text = "Số bản";
        // 
        // cboPrinter
        // 
        cboPrinter.BackColor = System.Drawing.Color.Transparent;
        cboPrinter.CornerRadius = 5;
        cboPrinter.DataSource = null;
        cboPrinter.DisplayMember = "";
        cboPrinter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboPrinter.Location = new System.Drawing.Point(20, 70);
        cboPrinter.Name = "cboPrinter";
        cboPrinter.SelectedIndex = -1;
        cboPrinter.SelectedItem = null;
        cboPrinter.SelectedValue = null;
        cboPrinter.Size = new System.Drawing.Size(370, 35);
        cboPrinter.TabIndex = 1;
        cboPrinter.ValueMember = "";
        // 
        // lblPrinterTitle
        // 
        lblPrinterTitle.AutoSize = true;
        lblPrinterTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPrinterTitle.Location = new System.Drawing.Point(20, 50);
        lblPrinterTitle.Name = "lblPrinterTitle";
        lblPrinterTitle.Size = new System.Drawing.Size(56, 20);
        lblPrinterTitle.TabIndex = 0;
        lblPrinterTitle.Text = "Máy in";
        // 
        // ReceiptPrintPreviewDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xem trước khi in phiếu thu · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        pnlReceiptWrapper.ResumeLayout(false);
        pnlA5Sheet.ResumeLayout(false);
        pnlA5Sheet.PerformLayout();
        cardPrintSettings.ResumeLayout(false);
        cardPrintSettings.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnPrintTop;
    private ECMS.UI.Controls.AppButton btnClosePreview;

    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private System.Windows.Forms.Panel pnlReceiptWrapper;
    private System.Windows.Forms.Panel pnlA5Sheet;
    private System.Windows.Forms.Label lblOrgName;
    private System.Windows.Forms.Label lblReceiptNumber;
    private System.Windows.Forms.Label lblOrgAddress;
    private System.Windows.Forms.Label lblReceiptDocTitle;
    private System.Windows.Forms.Label lblReceiptDate;

    private System.Windows.Forms.Label lblPayerTitle;
    private System.Windows.Forms.Label lblPayerVal;
    private System.Windows.Forms.Label lblCourseTitle;
    private System.Windows.Forms.Label lblCourseVal;
    private System.Windows.Forms.Label lblReasonTitle;
    private System.Windows.Forms.Label lblReasonVal;
    private System.Windows.Forms.Label lblAmountTitle;
    private System.Windows.Forms.Label lblAmountVal;
    private System.Windows.Forms.Label lblWordsTitle;
    private System.Windows.Forms.Label lblWordsVal;
    private System.Windows.Forms.Label lblMethodTitle;
    private System.Windows.Forms.Label lblMethodVal;
    private System.Windows.Forms.Label lblTransIdTitle;
    private System.Windows.Forms.Label lblTransIdVal;
    private System.Windows.Forms.Label lblBalanceTitle;
    private System.Windows.Forms.Label lblBalanceVal;

    private System.Windows.Forms.Label lblPayerSignTitle;
    private System.Windows.Forms.Label lblPayerSignVal;
    private System.Windows.Forms.Label lblCollectorSignTitle;
    private System.Windows.Forms.Label lblCollectorSignVal;

    private ECMS.UI.Controls.AppCard cardPrintSettings;
    private System.Windows.Forms.Label lblSettingsCardTitle;
    private System.Windows.Forms.Label lblPrinterTitle;
    private ECMS.UI.Controls.AppComboBox cboPrinter;
    private System.Windows.Forms.Label lblCopiesTitle;
    private ECMS.UI.Controls.AppTextBox txtCopies;
    private System.Windows.Forms.Label lblPaperSizeTitle;
    private ECMS.UI.Controls.AppComboBox cboPaperSize;
    private System.Windows.Forms.RadioButton rbDirectPrint;
    private System.Windows.Forms.RadioButton rbPreviewMode;
    private ECMS.UI.Controls.AppButton btnPrint;

    private System.Windows.Forms.Label lblSumTransCode;
    private System.Windows.Forms.Label lblSumReceiptDate;
    private System.Windows.Forms.Label lblSumTotalPaid;
    private System.Windows.Forms.Label lblSumRemaining;
}
