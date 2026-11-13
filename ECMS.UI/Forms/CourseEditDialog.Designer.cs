namespace ECMS.UI.Forms;

partial class CourseEditDialog
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
        pnlContent = new System.Windows.Forms.Panel();
        cardRules = new ECMS.UI.Controls.AppCard();
        bannerAuditRule = new ECMS.UI.Controls.AppBanner();
        lblAttendanceVal = new System.Windows.Forms.Label();
        lblAttendanceKey = new System.Windows.Forms.Label();
        lblPassScoreVal = new System.Windows.Forms.Label();
        lblPassScoreKey = new System.Windows.Forms.Label();
        lblTotalWeightVal = new System.Windows.Forms.Label();
        lblTotalWeightKey = new System.Windows.Forms.Label();
        lblFinalWeightVal = new System.Windows.Forms.Label();
        lblFinalWeightKey = new System.Windows.Forms.Label();
        lblMidtermWeightVal = new System.Windows.Forms.Label();
        lblMidtermWeightKey = new System.Windows.Forms.Label();
        lblRegularWeightVal = new System.Windows.Forms.Label();
        lblRegularWeightKey = new System.Windows.Forms.Label();
        lblGradingScaleVal = new System.Windows.Forms.Label();
        lblGradingScaleKey = new System.Windows.Forms.Label();
        lblRulesTitle = new System.Windows.Forms.Label();
        cardProgramInfo = new ECMS.UI.Controls.AppCard();
        bannerSuccess = new ECMS.UI.Controls.AppBanner();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        txtDescription = new ECMS.UI.Controls.AppTextBox();
        lblDescription = new System.Windows.Forms.Label();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        txtTuitionFee = new ECMS.UI.Controls.AppTextBox();
        lblTuitionFee = new System.Windows.Forms.Label();
        txtSessionDuration = new ECMS.UI.Controls.AppTextBox();
        lblSessionDuration = new System.Windows.Forms.Label();
        txtSessionCount = new ECMS.UI.Controls.AppTextBox();
        lblSessionCount = new System.Windows.Forms.Label();
        txtOutputTarget = new ECMS.UI.Controls.AppTextBox();
        lblOutputTarget = new System.Windows.Forms.Label();
        cboInputLevel = new ECMS.UI.Controls.AppComboBox();
        lblInputLevel = new System.Windows.Forms.Label();
        txtCourseName = new ECMS.UI.Controls.AppTextBox();
        lblCourseName = new System.Windows.Forms.Label();
        txtCourseCode = new ECMS.UI.Controls.AppTextBox();
        lblCourseCode = new System.Windows.Forms.Label();
        lblProgramInfoTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        cardRules.SuspendLayout();
        cardProgramInfo.SuspendLayout();
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
        lblSubtitle.Size = new System.Drawing.Size(430, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Đang sửa CT-IELTS-F · Biểu mẫu tạo mới dùng cùng trường thông tin";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(225, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thông tin khóa học";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(210, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Khóa học / Thông tin khóa học";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.Controls.Add(cardRules);
        pnlContent.Controls.Add(cardProgramInfo);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 75);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(1220, 685);
        pnlContent.TabIndex = 1;
        // 
        // cardRules
        // 
        cardRules.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardRules.BackColor = System.Drawing.Color.White;
        cardRules.Controls.Add(bannerAuditRule);
        cardRules.Controls.Add(lblAttendanceVal);
        cardRules.Controls.Add(lblAttendanceKey);
        cardRules.Controls.Add(lblPassScoreVal);
        cardRules.Controls.Add(lblPassScoreKey);
        cardRules.Controls.Add(lblTotalWeightVal);
        cardRules.Controls.Add(lblTotalWeightKey);
        cardRules.Controls.Add(lblFinalWeightVal);
        cardRules.Controls.Add(lblFinalWeightKey);
        cardRules.Controls.Add(lblMidtermWeightVal);
        cardRules.Controls.Add(lblMidtermWeightKey);
        cardRules.Controls.Add(lblRegularWeightVal);
        cardRules.Controls.Add(lblRegularWeightKey);
        cardRules.Controls.Add(lblGradingScaleVal);
        cardRules.Controls.Add(lblGradingScaleKey);
        cardRules.Controls.Add(lblRulesTitle);
        cardRules.Location = new System.Drawing.Point(860, 24);
        cardRules.Name = "cardRules";
        cardRules.Padding = new System.Windows.Forms.Padding(20);
        cardRules.Size = new System.Drawing.Size(336, 440);
        cardRules.TabIndex = 1;
        // 
        // bannerAuditRule
        // 
        bannerAuditRule.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        bannerAuditRule.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerAuditRule.Location = new System.Drawing.Point(20, 320);
        bannerAuditRule.Message = "Ngừng sử dụng khóa học không xóa các lớp và kết quả đã phát sinh.";
        bannerAuditRule.Name = "bannerAuditRule";
        bannerAuditRule.Size = new System.Drawing.Size(296, 60);
        bannerAuditRule.TabIndex = 15;
        // 
        // lblAttendanceVal
        // 
        lblAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblAttendanceVal.Location = new System.Drawing.Point(180, 260);
        lblAttendanceVal.Name = "lblAttendanceVal";
        lblAttendanceVal.Size = new System.Drawing.Size(130, 20);
        lblAttendanceVal.TabIndex = 14;
        lblAttendanceVal.Text = "≥ 80%";
        lblAttendanceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblAttendanceKey
        // 
        lblAttendanceKey.AutoSize = true;
        lblAttendanceKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAttendanceKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblAttendanceKey.Location = new System.Drawing.Point(20, 262);
        lblAttendanceKey.Name = "lblAttendanceKey";
        lblAttendanceKey.Size = new System.Drawing.Size(71, 15);
        lblAttendanceKey.TabIndex = 13;
        lblAttendanceKey.Text = "Chuyên cần";
        // 
        // lblPassScoreVal
        // 
        lblPassScoreVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblPassScoreVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblPassScoreVal.Location = new System.Drawing.Point(180, 225);
        lblPassScoreVal.Name = "lblPassScoreVal";
        lblPassScoreVal.Size = new System.Drawing.Size(130, 20);
        lblPassScoreVal.TabIndex = 12;
        lblPassScoreVal.Text = "≥ 6,5 / 10";
        lblPassScoreVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPassScoreKey
        // 
        lblPassScoreKey.AutoSize = true;
        lblPassScoreKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPassScoreKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPassScoreKey.Location = new System.Drawing.Point(20, 227);
        lblPassScoreKey.Name = "lblPassScoreKey";
        lblPassScoreKey.Size = new System.Drawing.Size(55, 15);
        lblPassScoreKey.TabIndex = 11;
        lblPassScoreKey.Text = "Điểm đạt";
        // 
        // lblTotalWeightVal
        // 
        lblTotalWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblTotalWeightVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTotalWeightVal.Location = new System.Drawing.Point(180, 190);
        lblTotalWeightVal.Name = "lblTotalWeightVal";
        lblTotalWeightVal.Size = new System.Drawing.Size(130, 20);
        lblTotalWeightVal.TabIndex = 10;
        lblTotalWeightVal.Text = "100%";
        lblTotalWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTotalWeightKey
        // 
        lblTotalWeightKey.AutoSize = true;
        lblTotalWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTotalWeightKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTotalWeightKey.Location = new System.Drawing.Point(20, 192);
        lblTotalWeightKey.Name = "lblTotalWeightKey";
        lblTotalWeightKey.Size = new System.Drawing.Size(83, 15);
        lblTotalWeightKey.TabIndex = 9;
        lblTotalWeightKey.Text = "Tổng trọng số";
        // 
        // lblFinalWeightVal
        // 
        lblFinalWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblFinalWeightVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblFinalWeightVal.Location = new System.Drawing.Point(180, 155);
        lblFinalWeightVal.Name = "lblFinalWeightVal";
        lblFinalWeightVal.Size = new System.Drawing.Size(130, 20);
        lblFinalWeightVal.TabIndex = 8;
        lblFinalWeightVal.Text = "50%";
        lblFinalWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblFinalWeightKey
        // 
        lblFinalWeightKey.AutoSize = true;
        lblFinalWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFinalWeightKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblFinalWeightKey.Location = new System.Drawing.Point(20, 157);
        lblFinalWeightKey.Name = "lblFinalWeightKey";
        lblFinalWeightKey.Size = new System.Drawing.Size(60, 15);
        lblFinalWeightKey.TabIndex = 7;
        lblFinalWeightKey.Text = "Cuối khóa";
        // 
        // lblMidtermWeightVal
        // 
        lblMidtermWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblMidtermWeightVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblMidtermWeightVal.Location = new System.Drawing.Point(180, 120);
        lblMidtermWeightVal.Name = "lblMidtermWeightVal";
        lblMidtermWeightVal.Size = new System.Drawing.Size(130, 20);
        lblMidtermWeightVal.TabIndex = 6;
        lblMidtermWeightVal.Text = "30%";
        lblMidtermWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblMidtermWeightKey
        // 
        lblMidtermWeightKey.AutoSize = true;
        lblMidtermWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMidtermWeightKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblMidtermWeightKey.Location = new System.Drawing.Point(20, 122);
        lblMidtermWeightKey.Name = "lblMidtermWeightKey";
        lblMidtermWeightKey.Size = new System.Drawing.Size(65, 15);
        lblMidtermWeightKey.TabIndex = 5;
        lblMidtermWeightKey.Text = "Giữa khóa";
        // 
        // lblRegularWeightVal
        // 
        lblRegularWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblRegularWeightVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblRegularWeightVal.Location = new System.Drawing.Point(180, 85);
        lblRegularWeightVal.Name = "lblRegularWeightVal";
        lblRegularWeightVal.Size = new System.Drawing.Size(130, 20);
        lblRegularWeightVal.TabIndex = 4;
        lblRegularWeightVal.Text = "20%";
        lblRegularWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblRegularWeightKey
        // 
        lblRegularWeightKey.AutoSize = true;
        lblRegularWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblRegularWeightKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblRegularWeightKey.Location = new System.Drawing.Point(20, 87);
        lblRegularWeightKey.Name = "lblRegularWeightKey";
        lblRegularWeightKey.Size = new System.Drawing.Size(78, 15);
        lblRegularWeightKey.TabIndex = 3;
        lblRegularWeightKey.Text = "Thường xuyên";
        // 
        // lblGradingScaleVal
        // 
        lblGradingScaleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblGradingScaleVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblGradingScaleVal.Location = new System.Drawing.Point(180, 50);
        lblGradingScaleVal.Name = "lblGradingScaleVal";
        lblGradingScaleVal.Size = new System.Drawing.Size(130, 20);
        lblGradingScaleVal.TabIndex = 2;
        lblGradingScaleVal.Text = "0–10";
        lblGradingScaleVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGradingScaleKey
        // 
        lblGradingScaleKey.AutoSize = true;
        lblGradingScaleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGradingScaleKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblGradingScaleKey.Location = new System.Drawing.Point(20, 52);
        lblGradingScaleKey.Name = "lblGradingScaleKey";
        lblGradingScaleKey.Size = new System.Drawing.Size(68, 15);
        lblGradingScaleKey.TabIndex = 1;
        lblGradingScaleKey.Text = "Thang điểm";
        // 
        // lblRulesTitle
        // 
        lblRulesTitle.AutoSize = true;
        lblRulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblRulesTitle.Location = new System.Drawing.Point(20, 16);
        lblRulesTitle.Name = "lblRulesTitle";
        lblRulesTitle.Size = new System.Drawing.Size(147, 21);
        lblRulesTitle.TabIndex = 0;
        lblRulesTitle.Text = "Quy tắc mặc định";
        // 
        // cardProgramInfo
        // 
        cardProgramInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardProgramInfo.BackColor = System.Drawing.Color.White;
        cardProgramInfo.Controls.Add(bannerSuccess);
        cardProgramInfo.Controls.Add(btnSave);
        cardProgramInfo.Controls.Add(btnCancel);
        cardProgramInfo.Controls.Add(txtDescription);
        cardProgramInfo.Controls.Add(lblDescription);
        cardProgramInfo.Controls.Add(cboStatus);
        cardProgramInfo.Controls.Add(lblStatus);
        cardProgramInfo.Controls.Add(txtTuitionFee);
        cardProgramInfo.Controls.Add(lblTuitionFee);
        cardProgramInfo.Controls.Add(txtSessionDuration);
        cardProgramInfo.Controls.Add(lblSessionDuration);
        cardProgramInfo.Controls.Add(txtSessionCount);
        cardProgramInfo.Controls.Add(lblSessionCount);
        cardProgramInfo.Controls.Add(txtOutputTarget);
        cardProgramInfo.Controls.Add(lblOutputTarget);
        cardProgramInfo.Controls.Add(cboInputLevel);
        cardProgramInfo.Controls.Add(lblInputLevel);
        cardProgramInfo.Controls.Add(txtCourseName);
        cardProgramInfo.Controls.Add(lblCourseName);
        cardProgramInfo.Controls.Add(txtCourseCode);
        cardProgramInfo.Controls.Add(lblCourseCode);
        cardProgramInfo.Controls.Add(lblProgramInfoTitle);
        cardProgramInfo.Location = new System.Drawing.Point(24, 24);
        cardProgramInfo.Name = "cardProgramInfo";
        cardProgramInfo.Padding = new System.Windows.Forms.Padding(24);
        cardProgramInfo.Size = new System.Drawing.Size(815, 620);
        cardProgramInfo.TabIndex = 0;
        // 
        // bannerSuccess
        // 
        bannerSuccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerSuccess.Location = new System.Drawing.Point(24, 555);
        bannerSuccess.Message = "✓  Đã lưu phiên bản chương trình 1.2. Các khoản thu đã ghi nhận không thay đổi.";
        bannerSuccess.Name = "bannerSuccess";
        bannerSuccess.Size = new System.Drawing.Size(767, 45);
        bannerSuccess.TabIndex = 21;
        // 
        // btnSave
        // 
        btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSave.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(681, 498);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(110, 36);
        btnSave.TabIndex = 20;
        btnSave.Text = "Lưu";
        btnSave.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancel.Location = new System.Drawing.Point(585, 498);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 36);
        btnCancel.TabIndex = 19;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // txtDescription
        // 
        txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtDescription.Location = new System.Drawing.Point(24, 385);
        txtDescription.Name = "txtDescription";
        txtDescription.Placeholder = "Nhập tóm tắt mô tả chương trình học, nội dung cốt lõi...";
        txtDescription.Size = new System.Drawing.Size(767, 75);
        txtDescription.TabIndex = 18;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDescription.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblDescription.Location = new System.Drawing.Point(24, 365);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new System.Drawing.Size(127, 15);
        lblDescription.TabIndex = 17;
        lblDescription.Text = "Mô tả / nội dung học";
        // 
        // cboStatus
        // 
        cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboStatus.Location = new System.Drawing.Point(415, 305);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new System.Drawing.Size(376, 35);
        cboStatus.TabIndex = 16;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblStatus.Location = new System.Drawing.Point(415, 285);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(74, 15);
        lblStatus.TabIndex = 15;
        lblStatus.Text = "Trạng thái *";
        // 
        // txtTuitionFee
        // 
        txtTuitionFee.Location = new System.Drawing.Point(24, 305);
        txtTuitionFee.Name = "txtTuitionFee";
        txtTuitionFee.Placeholder = "Ví dụ: 6.000.000";
        txtTuitionFee.Size = new System.Drawing.Size(370, 35);
        txtTuitionFee.TabIndex = 14;
        // 
        // lblTuitionFee
        // 
        lblTuitionFee.AutoSize = true;
        lblTuitionFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTuitionFee.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblTuitionFee.Location = new System.Drawing.Point(24, 285);
        lblTuitionFee.Name = "lblTuitionFee";
        lblTuitionFee.Size = new System.Drawing.Size(83, 15);
        lblTuitionFee.TabIndex = 13;
        lblTuitionFee.Text = "Học phí gốc *";
        // 
        // txtSessionDuration
        // 
        txtSessionDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtSessionDuration.Location = new System.Drawing.Point(415, 225);
        txtSessionDuration.Name = "txtSessionDuration";
        txtSessionDuration.Placeholder = "Ví dụ: 120 phút";
        txtSessionDuration.Size = new System.Drawing.Size(376, 35);
        txtSessionDuration.TabIndex = 12;
        // 
        // lblSessionDuration
        // 
        lblSessionDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblSessionDuration.AutoSize = true;
        lblSessionDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSessionDuration.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblSessionDuration.Location = new System.Drawing.Point(415, 205);
        lblSessionDuration.Name = "lblSessionDuration";
        lblSessionDuration.Size = new System.Drawing.Size(125, 15);
        lblSessionDuration.TabIndex = 11;
        lblSessionDuration.Text = "Thời lượng / buổi *";
        // 
        // txtSessionCount
        // 
        txtSessionCount.Location = new System.Drawing.Point(24, 225);
        txtSessionCount.Name = "txtSessionCount";
        txtSessionCount.Placeholder = "Ví dụ: 24";
        txtSessionCount.Size = new System.Drawing.Size(370, 35);
        txtSessionCount.TabIndex = 10;
        // 
        // lblSessionCount
        // 
        lblSessionCount.AutoSize = true;
        lblSessionCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSessionCount.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblSessionCount.Location = new System.Drawing.Point(24, 205);
        lblSessionCount.Name = "lblSessionCount";
        lblSessionCount.Size = new System.Drawing.Size(59, 15);
        lblSessionCount.TabIndex = 9;
        lblSessionCount.Text = "Số buổi *";
        // 
        // txtOutputTarget
        // 
        txtOutputTarget.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtOutputTarget.Location = new System.Drawing.Point(415, 145);
        txtOutputTarget.Name = "txtOutputTarget";
        txtOutputTarget.Placeholder = "Ví dụ: Nền tảng IELTS 4.0–4.5";
        txtOutputTarget.Size = new System.Drawing.Size(376, 35);
        txtOutputTarget.TabIndex = 8;
        // 
        // lblOutputTarget
        // 
        lblOutputTarget.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblOutputTarget.AutoSize = true;
        lblOutputTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblOutputTarget.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblOutputTarget.Location = new System.Drawing.Point(415, 125);
        lblOutputTarget.Name = "lblOutputTarget";
        lblOutputTarget.Size = new System.Drawing.Size(113, 15);
        lblOutputTarget.TabIndex = 7;
        lblOutputTarget.Text = "Mục tiêu đầu ra *";
        // 
        // cboInputLevel
        // 
        cboInputLevel.Location = new System.Drawing.Point(24, 145);
        cboInputLevel.Name = "cboInputLevel";
        cboInputLevel.Size = new System.Drawing.Size(370, 35);
        cboInputLevel.TabIndex = 6;
        // 
        // lblInputLevel
        // 
        lblInputLevel.AutoSize = true;
        lblInputLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInputLevel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblInputLevel.Location = new System.Drawing.Point(24, 125);
        lblInputLevel.Name = "lblInputLevel";
        lblInputLevel.Size = new System.Drawing.Size(120, 15);
        lblInputLevel.TabIndex = 5;
        lblInputLevel.Text = "Trình độ đầu vào *";
        // 
        // txtCourseName
        // 
        txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtCourseName.Location = new System.Drawing.Point(415, 68);
        txtCourseName.Name = "txtCourseName";
        txtCourseName.Placeholder = "Ví dụ: IELTS Foundation";
        txtCourseName.Size = new System.Drawing.Size(376, 35);
        txtCourseName.TabIndex = 4;
        // 
        // lblCourseName
        // 
        lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblCourseName.AutoSize = true;
        lblCourseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourseName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblCourseName.Location = new System.Drawing.Point(415, 48);
        lblCourseName.Name = "lblCourseName";
        lblCourseName.Size = new System.Drawing.Size(91, 15);
        lblCourseName.TabIndex = 3;
        lblCourseName.Text = "Tên khóa học *";
        // 
        // txtCourseCode
        // 
        txtCourseCode.Location = new System.Drawing.Point(24, 68);
        txtCourseCode.Name = "txtCourseCode";
        txtCourseCode.Placeholder = "Ví dụ: CT-IELTS-F";
        txtCourseCode.Size = new System.Drawing.Size(370, 35);
        txtCourseCode.TabIndex = 2;
        // 
        // lblCourseCode
        // 
        lblCourseCode.AutoSize = true;
        lblCourseCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourseCode.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblCourseCode.Location = new System.Drawing.Point(24, 48);
        lblCourseCode.Name = "lblCourseCode";
        lblCourseCode.Size = new System.Drawing.Size(88, 15);
        lblCourseCode.TabIndex = 1;
        lblCourseCode.Text = "Mã khóa học *";
        // 
        // lblProgramInfoTitle
        // 
        lblProgramInfoTitle.AutoSize = true;
        lblProgramInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblProgramInfoTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblProgramInfoTitle.Location = new System.Drawing.Point(24, 16);
        lblProgramInfoTitle.Name = "lblProgramInfoTitle";
        lblProgramInfoTitle.Size = new System.Drawing.Size(193, 21);
        lblProgramInfoTitle.TabIndex = 0;
        lblProgramInfoTitle.Text = "Thông tin chương trình";
        // 
        // CourseEditDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CourseEditDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thông tin khóa học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        cardRules.ResumeLayout(false);
        cardRules.PerformLayout();
        cardProgramInfo.ResumeLayout(false);
        cardProgramInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlContent;
    private ECMS.UI.Controls.AppCard cardProgramInfo;
    private System.Windows.Forms.Label lblProgramInfoTitle;
    private System.Windows.Forms.Label lblCourseCode;
    private ECMS.UI.Controls.AppTextBox txtCourseCode;
    private System.Windows.Forms.Label lblCourseName;
    private ECMS.UI.Controls.AppTextBox txtCourseName;
    private System.Windows.Forms.Label lblInputLevel;
    private ECMS.UI.Controls.AppComboBox cboInputLevel;
    private System.Windows.Forms.Label lblOutputTarget;
    private ECMS.UI.Controls.AppTextBox txtOutputTarget;
    private System.Windows.Forms.Label lblSessionCount;
    private ECMS.UI.Controls.AppTextBox txtSessionCount;
    private System.Windows.Forms.Label lblSessionDuration;
    private ECMS.UI.Controls.AppTextBox txtSessionDuration;
    private System.Windows.Forms.Label lblTuitionFee;
    private ECMS.UI.Controls.AppTextBox txtTuitionFee;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private System.Windows.Forms.Label lblDescription;
    private ECMS.UI.Controls.AppTextBox txtDescription;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppBanner bannerSuccess;
    private ECMS.UI.Controls.AppCard cardRules;
    private System.Windows.Forms.Label lblRulesTitle;
    private System.Windows.Forms.Label lblGradingScaleKey;
    private System.Windows.Forms.Label lblGradingScaleVal;
    private System.Windows.Forms.Label lblRegularWeightKey;
    private System.Windows.Forms.Label lblRegularWeightVal;
    private System.Windows.Forms.Label lblMidtermWeightKey;
    private System.Windows.Forms.Label lblMidtermWeightVal;
    private System.Windows.Forms.Label lblFinalWeightKey;
    private System.Windows.Forms.Label lblFinalWeightVal;
    private System.Windows.Forms.Label lblTotalWeightKey;
    private System.Windows.Forms.Label lblTotalWeightVal;
    private System.Windows.Forms.Label lblPassScoreKey;
    private System.Windows.Forms.Label lblPassScoreVal;
    private System.Windows.Forms.Label lblAttendanceKey;
    private System.Windows.Forms.Label lblAttendanceVal;
    private ECMS.UI.Controls.AppBanner bannerAuditRule;
}
