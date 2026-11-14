namespace ECMS.UI.UserControls;

partial class SystemConfigView
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        btnSaveConfigTop = new ECMS.UI.Controls.AppButton();
        btnOpenBackupRestore = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlSubTabs = new System.Windows.Forms.Panel();
        lblTabBackup = new System.Windows.Forms.Label();
        lblTabGrading = new System.Windows.Forms.Label();
        lblTabCenter = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        bannerSavedStatus = new ECMS.UI.Controls.AppBanner();
        cardGradingRules = new ECMS.UI.Controls.AppCard();
        btnSaveRules = new ECMS.UI.Controls.AppButton();
        btnCancelRules = new ECMS.UI.Controls.AppButton();
        chkDebtCertRule = new System.Windows.Forms.CheckBox();
        chkLateCounted = new System.Windows.Forms.CheckBox();
        txtAbsenceAlert = new ECMS.UI.Controls.AppTextBox();
        lblAbsenceAlert = new System.Windows.Forms.Label();
        txtMinAttendance = new ECMS.UI.Controls.AppTextBox();
        lblMinAttendance = new System.Windows.Forms.Label();
        lblTotalWeightValidation = new System.Windows.Forms.Label();
        txtWeightFinal = new ECMS.UI.Controls.AppTextBox();
        lblWeightFinal = new System.Windows.Forms.Label();
        txtWeightMidterm = new ECMS.UI.Controls.AppTextBox();
        lblWeightMidterm = new System.Windows.Forms.Label();
        txtWeightRegular = new ECMS.UI.Controls.AppTextBox();
        lblWeightRegular = new System.Windows.Forms.Label();
        txtPassingScore = new ECMS.UI.Controls.AppTextBox();
        lblPassingScore = new System.Windows.Forms.Label();
        txtScoreScale = new ECMS.UI.Controls.AppTextBox();
        lblScoreScale = new System.Windows.Forms.Label();
        lblGradingRulesTitle = new System.Windows.Forms.Label();
        cardCenterInfo = new ECMS.UI.Controls.AppCard();
        txtStoragePath = new ECMS.UI.Controls.AppTextBox();
        lblStoragePath = new System.Windows.Forms.Label();
        txtDatabasePath = new ECMS.UI.Controls.AppTextBox();
        lblDatabasePath = new System.Windows.Forms.Label();
        txtDirector = new ECMS.UI.Controls.AppTextBox();
        lblDirector = new System.Windows.Forms.Label();
        txtCenterAddress = new ECMS.UI.Controls.AppTextBox();
        lblCenterAddress = new System.Windows.Forms.Label();
        txtCenterPhone = new ECMS.UI.Controls.AppTextBox();
        lblCenterPhone = new System.Windows.Forms.Label();
        txtCenterName = new ECMS.UI.Controls.AppTextBox();
        lblCenterName = new System.Windows.Forms.Label();
        lblCenterInfoTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlSubTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGradingRules.SuspendLayout();
        cardCenterInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnSaveConfigTop);
        pnlHeader.Controls.Add(btnOpenBackupRestore);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnSaveConfigTop
        // 
        btnSaveConfigTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveConfigTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveConfigTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveConfigTop.CornerRadius = 5;
        btnSaveConfigTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveConfigTop.FlatAppearance.BorderSize = 0;
        btnSaveConfigTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveConfigTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveConfigTop.ForeColor = System.Drawing.Color.White;
        btnSaveConfigTop.Location = new System.Drawing.Point(1016, 20);
        btnSaveConfigTop.Name = "btnSaveConfigTop";
        btnSaveConfigTop.Size = new System.Drawing.Size(120, 36);
        btnSaveConfigTop.TabIndex = 4;
        btnSaveConfigTop.Text = "Lưu cấu hình";
        btnSaveConfigTop.UseVisualStyleBackColor = false;
        btnSaveConfigTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnOpenBackupRestore
        // 
        btnOpenBackupRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnOpenBackupRestore.BackColor = System.Drawing.Color.White;
        btnOpenBackupRestore.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenBackupRestore.CornerRadius = 5;
        btnOpenBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenBackupRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnOpenBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenBackupRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnOpenBackupRestore.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnOpenBackupRestore.Location = new System.Drawing.Point(860, 20);
        btnOpenBackupRestore.Name = "btnOpenBackupRestore";
        btnOpenBackupRestore.Size = new System.Drawing.Size(146, 36);
        btnOpenBackupRestore.TabIndex = 3;
        btnOpenBackupRestore.Text = "Sao lưu / Khôi phục";
        btnOpenBackupRestore.UseVisualStyleBackColor = false;
        btnOpenBackupRestore.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(223, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Cấu hình hệ thống";
        // 
        // pnlSubTabs
        // 
        pnlSubTabs.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlSubTabs.Controls.Add(lblTabBackup);
        pnlSubTabs.Controls.Add(lblTabGrading);
        pnlSubTabs.Controls.Add(lblTabCenter);
        pnlSubTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlSubTabs.Location = new System.Drawing.Point(0, 75);
        pnlSubTabs.Name = "pnlSubTabs";
        pnlSubTabs.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlSubTabs.Size = new System.Drawing.Size(1160, 40);
        pnlSubTabs.TabIndex = 1;
        // 
        // lblTabBackup
        // 
        lblTabBackup.AutoSize = true;
        lblTabBackup.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTabBackup.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTabBackup.Location = new System.Drawing.Point(310, 12);
        lblTabBackup.Name = "lblTabBackup";
        lblTabBackup.Size = new System.Drawing.Size(139, 20);
        lblTabBackup.TabIndex = 2;
        lblTabBackup.Text = "Sao lưu / Khôi phục";
        // 
        // lblTabGrading
        // 
        lblTabGrading.AutoSize = true;
        lblTabGrading.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabGrading.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTabGrading.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTabGrading.Location = new System.Drawing.Point(165, 12);
        lblTabGrading.Name = "lblTabGrading";
        lblTabGrading.Size = new System.Drawing.Size(150, 20);
        lblTabGrading.TabIndex = 1;
        lblTabGrading.Text = "Đánh giá & chuyên cần";
        // 
        // lblTabCenter
        // 
        lblTabCenter.AutoSize = true;
        lblTabCenter.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabCenter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTabCenter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblTabCenter.Location = new System.Drawing.Point(24, 12);
        lblTabCenter.Name = "lblTabCenter";
        lblTabCenter.Size = new System.Drawing.Size(148, 20);
        lblTabCenter.TabIndex = 0;
        lblTabCenter.Text = "• Trung tâm & dữ liệu";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(bannerSavedStatus);
        pnlBody.Controls.Add(cardGradingRules);
        pnlBody.Controls.Add(cardCenterInfo);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 115);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 645);
        pnlBody.TabIndex = 2;
        // 
        // bannerSavedStatus
        // 
        bannerSavedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerSavedStatus.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerSavedStatus.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerSavedStatus.Location = new System.Drawing.Point(24, 570);
        bannerSavedStatus.Message = "Phím tắt đề xuất: Ctrl+F tìm, Ctrl+S lưu, Esc hủy, F1 trợ giúp ngoại tuyến.";
        bannerSavedStatus.Name = "bannerSavedStatus";
        bannerSavedStatus.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerSavedStatus.Size = new System.Drawing.Size(1112, 55);
        bannerSavedStatus.TabIndex = 2;
        bannerSavedStatus.Title = "✓ Cấu hình hợp lệ đã lưu lúc 15:42.";
        bannerSavedStatus.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // cardGradingRules
        // 
        cardGradingRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardGradingRules.BackColor = System.Drawing.Color.White;
        cardGradingRules.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGradingRules.BorderWidth = 1;
        cardGradingRules.Controls.Add(btnSaveRules);
        cardGradingRules.Controls.Add(btnCancelRules);
        cardGradingRules.Controls.Add(chkDebtCertRule);
        cardGradingRules.Controls.Add(chkLateCounted);
        cardGradingRules.Controls.Add(txtAbsenceAlert);
        cardGradingRules.Controls.Add(lblAbsenceAlert);
        cardGradingRules.Controls.Add(txtMinAttendance);
        cardGradingRules.Controls.Add(lblMinAttendance);
        cardGradingRules.Controls.Add(lblTotalWeightValidation);
        cardGradingRules.Controls.Add(txtWeightFinal);
        cardGradingRules.Controls.Add(lblWeightFinal);
        cardGradingRules.Controls.Add(txtWeightMidterm);
        cardGradingRules.Controls.Add(lblWeightMidterm);
        cardGradingRules.Controls.Add(txtWeightRegular);
        cardGradingRules.Controls.Add(lblWeightRegular);
        cardGradingRules.Controls.Add(txtPassingScore);
        cardGradingRules.Controls.Add(lblPassingScore);
        cardGradingRules.Controls.Add(txtScoreScale);
        cardGradingRules.Controls.Add(lblScoreScale);
        cardGradingRules.Controls.Add(lblGradingRulesTitle);
        cardGradingRules.CornerRadius = 6;
        cardGradingRules.Location = new System.Drawing.Point(600, 20);
        cardGradingRules.Name = "cardGradingRules";
        cardGradingRules.Padding = new System.Windows.Forms.Padding(20);
        cardGradingRules.Size = new System.Drawing.Size(536, 530);
        cardGradingRules.TabIndex = 1;
        // 
        // btnSaveRules
        // 
        btnSaveRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveRules.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveRules.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveRules.CornerRadius = 5;
        btnSaveRules.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveRules.FlatAppearance.BorderSize = 0;
        btnSaveRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveRules.ForeColor = System.Drawing.Color.White;
        btnSaveRules.Location = new System.Drawing.Point(436, 440);
        btnSaveRules.Name = "btnSaveRules";
        btnSaveRules.Size = new System.Drawing.Size(80, 32);
        btnSaveRules.TabIndex = 19;
        btnSaveRules.Text = "Lưu";
        btnSaveRules.UseVisualStyleBackColor = false;
        btnSaveRules.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelRules
        // 
        btnCancelRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancelRules.BackColor = System.Drawing.Color.White;
        btnCancelRules.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelRules.CornerRadius = 5;
        btnCancelRules.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelRules.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelRules.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelRules.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelRules.Location = new System.Drawing.Point(350, 440);
        btnCancelRules.Name = "btnCancelRules";
        btnCancelRules.Size = new System.Drawing.Size(75, 32);
        btnCancelRules.TabIndex = 18;
        btnCancelRules.Text = "Hủy";
        btnCancelRules.UseVisualStyleBackColor = false;
        btnCancelRules.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // chkDebtCertRule
        // 
        chkDebtCertRule.AutoSize = true;
        chkDebtCertRule.Checked = true;
        chkDebtCertRule.CheckState = System.Windows.Forms.CheckState.Checked;
        chkDebtCertRule.Location = new System.Drawing.Point(20, 410);
        chkDebtCertRule.Name = "chkDebtCertRule";
        chkDebtCertRule.Size = new System.Drawing.Size(255, 24);
        chkDebtCertRule.TabIndex = 17;
        chkDebtCertRule.Text = "Chỉ cấp chứng chỉ khi công nợ = 0";
        chkDebtCertRule.UseVisualStyleBackColor = true;
        // 
        // chkLateCounted
        // 
        chkLateCounted.AutoSize = true;
        chkLateCounted.Checked = true;
        chkLateCounted.CheckState = System.Windows.Forms.CheckState.Checked;
        chkLateCounted.Location = new System.Drawing.Point(20, 380);
        chkLateCounted.Name = "chkLateCounted";
        chkLateCounted.Size = new System.Drawing.Size(193, 24);
        chkLateCounted.TabIndex = 16;
        chkLateCounted.Text = "Đi muộn tính là tham dự";
        chkLateCounted.UseVisualStyleBackColor = true;
        // 
        // txtAbsenceAlert
        // 
        txtAbsenceAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtAbsenceAlert.BackColor = System.Drawing.Color.Transparent;
        txtAbsenceAlert.CornerRadius = 5;
        txtAbsenceAlert.ErrorMessage = "";
        txtAbsenceAlert.HasError = false;
        txtAbsenceAlert.Location = new System.Drawing.Point(20, 335);
        txtAbsenceAlert.Name = "txtAbsenceAlert";
        txtAbsenceAlert.Placeholder = "Trên 3 buổi (từ 4 buổi)";
        txtAbsenceAlert.ReadOnly = false;
        txtAbsenceAlert.Size = new System.Drawing.Size(496, 32);
        txtAbsenceAlert.TabIndex = 15;
        txtAbsenceAlert.UseSystemPasswordChar = false;
        // 
        // lblAbsenceAlert
        // 
        lblAbsenceAlert.AutoSize = true;
        lblAbsenceAlert.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAbsenceAlert.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAbsenceAlert.Location = new System.Drawing.Point(20, 315);
        lblAbsenceAlert.Name = "lblAbsenceAlert";
        lblAbsenceAlert.Size = new System.Drawing.Size(183, 20);
        lblAbsenceAlert.TabIndex = 14;
        lblAbsenceAlert.Text = "Ngưỡng cảnh báo vắng *";
        // 
        // txtMinAttendance
        // 
        txtMinAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtMinAttendance.BackColor = System.Drawing.Color.Transparent;
        txtMinAttendance.CornerRadius = 5;
        txtMinAttendance.ErrorMessage = "";
        txtMinAttendance.HasError = false;
        txtMinAttendance.Location = new System.Drawing.Point(276, 255);
        txtMinAttendance.Name = "txtMinAttendance";
        txtMinAttendance.Placeholder = "80%";
        txtMinAttendance.ReadOnly = false;
        txtMinAttendance.Size = new System.Drawing.Size(240, 32);
        txtMinAttendance.TabIndex = 13;
        txtMinAttendance.UseSystemPasswordChar = false;
        // 
        // lblMinAttendance
        // 
        lblMinAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblMinAttendance.AutoSize = true;
        lblMinAttendance.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblMinAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblMinAttendance.Location = new System.Drawing.Point(276, 235);
        lblMinAttendance.Name = "lblMinAttendance";
        lblMinAttendance.Size = new System.Drawing.Size(163, 20);
        lblMinAttendance.TabIndex = 12;
        lblMinAttendance.Text = "Chuyên cần tối thiểu *";
        // 
        // lblTotalWeightValidation
        // 
        lblTotalWeightValidation.AutoSize = true;
        lblTotalWeightValidation.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTotalWeightValidation.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblTotalWeightValidation.Location = new System.Drawing.Point(20, 292);
        lblTotalWeightValidation.Name = "lblTotalWeightValidation";
        lblTotalWeightValidation.Size = new System.Drawing.Size(183, 20);
        lblTotalWeightValidation.TabIndex = 11;
        lblTotalWeightValidation.Text = "✓ Tổng trọng số = 100%";
        // 
        // txtWeightFinal
        // 
        txtWeightFinal.BackColor = System.Drawing.Color.Transparent;
        txtWeightFinal.CornerRadius = 5;
        txtWeightFinal.ErrorMessage = "";
        txtWeightFinal.HasError = false;
        txtWeightFinal.Location = new System.Drawing.Point(20, 255);
        txtWeightFinal.Name = "txtWeightFinal";
        txtWeightFinal.Placeholder = "50%";
        txtWeightFinal.ReadOnly = false;
        txtWeightFinal.Size = new System.Drawing.Size(240, 32);
        txtWeightFinal.TabIndex = 10;
        txtWeightFinal.UseSystemPasswordChar = false;
        // 
        // lblWeightFinal
        // 
        lblWeightFinal.AutoSize = true;
        lblWeightFinal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblWeightFinal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightFinal.Location = new System.Drawing.Point(20, 235);
        lblWeightFinal.Name = "lblWeightFinal";
        lblWeightFinal.Size = new System.Drawing.Size(89, 20);
        lblWeightFinal.TabIndex = 9;
        lblWeightFinal.Text = "Cuối khóa *";
        // 
        // txtWeightMidterm
        // 
        txtWeightMidterm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtWeightMidterm.BackColor = System.Drawing.Color.Transparent;
        txtWeightMidterm.CornerRadius = 5;
        txtWeightMidterm.ErrorMessage = "";
        txtWeightMidterm.HasError = false;
        txtWeightMidterm.Location = new System.Drawing.Point(276, 188);
        txtWeightMidterm.Name = "txtWeightMidterm";
        txtWeightMidterm.Placeholder = "30%";
        txtWeightMidterm.ReadOnly = false;
        txtWeightMidterm.Size = new System.Drawing.Size(240, 32);
        txtWeightMidterm.TabIndex = 8;
        txtWeightMidterm.UseSystemPasswordChar = false;
        // 
        // lblWeightMidterm
        // 
        lblWeightMidterm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblWeightMidterm.AutoSize = true;
        lblWeightMidterm.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblWeightMidterm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightMidterm.Location = new System.Drawing.Point(276, 168);
        lblWeightMidterm.Name = "lblWeightMidterm";
        lblWeightMidterm.Size = new System.Drawing.Size(91, 20);
        lblWeightMidterm.TabIndex = 7;
        lblWeightMidterm.Text = "Giữa khóa *";
        // 
        // txtWeightRegular
        // 
        txtWeightRegular.BackColor = System.Drawing.Color.Transparent;
        txtWeightRegular.CornerRadius = 5;
        txtWeightRegular.ErrorMessage = "";
        txtWeightRegular.HasError = false;
        txtWeightRegular.Location = new System.Drawing.Point(20, 188);
        txtWeightRegular.Name = "txtWeightRegular";
        txtWeightRegular.Placeholder = "20%";
        txtWeightRegular.ReadOnly = false;
        txtWeightRegular.Size = new System.Drawing.Size(240, 32);
        txtWeightRegular.TabIndex = 6;
        txtWeightRegular.UseSystemPasswordChar = false;
        // 
        // lblWeightRegular
        // 
        lblWeightRegular.AutoSize = true;
        lblWeightRegular.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblWeightRegular.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightRegular.Location = new System.Drawing.Point(20, 168);
        lblWeightRegular.Name = "lblWeightRegular";
        lblWeightRegular.Size = new System.Drawing.Size(121, 20);
        lblWeightRegular.TabIndex = 5;
        lblWeightRegular.Text = "Thường xuyên *";
        // 
        // txtPassingScore
        // 
        txtPassingScore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtPassingScore.BackColor = System.Drawing.Color.Transparent;
        txtPassingScore.CornerRadius = 5;
        txtPassingScore.ErrorMessage = "";
        txtPassingScore.HasError = false;
        txtPassingScore.Location = new System.Drawing.Point(276, 120);
        txtPassingScore.Name = "txtPassingScore";
        txtPassingScore.Placeholder = "6,5";
        txtPassingScore.ReadOnly = false;
        txtPassingScore.Size = new System.Drawing.Size(240, 32);
        txtPassingScore.TabIndex = 4;
        txtPassingScore.UseSystemPasswordChar = false;
        // 
        // lblPassingScore
        // 
        lblPassingScore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPassingScore.AutoSize = true;
        lblPassingScore.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblPassingScore.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblPassingScore.Location = new System.Drawing.Point(276, 100);
        lblPassingScore.Name = "lblPassingScore";
        lblPassingScore.Size = new System.Drawing.Size(84, 20);
        lblPassingScore.TabIndex = 3;
        lblPassingScore.Text = "Điểm đạt *";
        // 
        // txtScoreScale
        // 
        txtScoreScale.BackColor = System.Drawing.Color.Transparent;
        txtScoreScale.CornerRadius = 5;
        txtScoreScale.ErrorMessage = "";
        txtScoreScale.HasError = false;
        txtScoreScale.Location = new System.Drawing.Point(20, 120);
        txtScoreScale.Name = "txtScoreScale";
        txtScoreScale.Placeholder = "0–10";
        txtScoreScale.ReadOnly = false;
        txtScoreScale.Size = new System.Drawing.Size(240, 32);
        txtScoreScale.TabIndex = 2;
        txtScoreScale.UseSystemPasswordChar = false;
        // 
        // lblScoreScale
        // 
        lblScoreScale.AutoSize = true;
        lblScoreScale.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblScoreScale.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblScoreScale.Location = new System.Drawing.Point(20, 100);
        lblScoreScale.Name = "lblScoreScale";
        lblScoreScale.Size = new System.Drawing.Size(103, 20);
        lblScoreScale.TabIndex = 1;
        lblScoreScale.Text = "Thang điểm *";
        // 
        // lblGradingRulesTitle
        // 
        lblGradingRulesTitle.AutoSize = true;
        lblGradingRulesTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblGradingRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblGradingRulesTitle.Location = new System.Drawing.Point(20, 16);
        lblGradingRulesTitle.Name = "lblGradingRulesTitle";
        lblGradingRulesTitle.Size = new System.Drawing.Size(238, 25);
        lblGradingRulesTitle.TabIndex = 0;
        lblGradingRulesTitle.Text = "Quy tắc điểm & chuyên cần";
        // 
        // cardCenterInfo
        // 
        cardCenterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCenterInfo.BackColor = System.Drawing.Color.White;
        cardCenterInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCenterInfo.BorderWidth = 1;
        cardCenterInfo.Controls.Add(txtStoragePath);
        cardCenterInfo.Controls.Add(lblStoragePath);
        cardCenterInfo.Controls.Add(txtDatabasePath);
        cardCenterInfo.Controls.Add(lblDatabasePath);
        cardCenterInfo.Controls.Add(txtDirector);
        cardCenterInfo.Controls.Add(lblDirector);
        cardCenterInfo.Controls.Add(txtCenterAddress);
        cardCenterInfo.Controls.Add(lblCenterAddress);
        cardCenterInfo.Controls.Add(txtCenterPhone);
        cardCenterInfo.Controls.Add(lblCenterPhone);
        cardCenterInfo.Controls.Add(txtCenterName);
        cardCenterInfo.Controls.Add(lblCenterName);
        cardCenterInfo.Controls.Add(lblCenterInfoTitle);
        cardCenterInfo.CornerRadius = 6;
        cardCenterInfo.Location = new System.Drawing.Point(24, 20);
        cardCenterInfo.Name = "cardCenterInfo";
        cardCenterInfo.Padding = new System.Windows.Forms.Padding(20);
        cardCenterInfo.Size = new System.Drawing.Size(550, 530);
        cardCenterInfo.TabIndex = 0;
        // 
        // txtStoragePath
        // 
        txtStoragePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtStoragePath.BackColor = System.Drawing.Color.Transparent;
        txtStoragePath.CornerRadius = 5;
        txtStoragePath.ErrorMessage = "";
        txtStoragePath.HasError = false;
        txtStoragePath.Location = new System.Drawing.Point(20, 385);
        txtStoragePath.Name = "txtStoragePath";
        txtStoragePath.Placeholder = "C:\\ECMS\\TaiLieu\\ / D:\\ECMS_Backup\\";
        txtStoragePath.ReadOnly = false;
        txtStoragePath.Size = new System.Drawing.Size(510, 32);
        txtStoragePath.TabIndex = 12;
        txtStoragePath.UseSystemPasswordChar = false;
        // 
        // lblStoragePath
        // 
        lblStoragePath.AutoSize = true;
        lblStoragePath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStoragePath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStoragePath.Location = new System.Drawing.Point(20, 365);
        lblStoragePath.Name = "lblStoragePath";
        lblStoragePath.Size = new System.Drawing.Size(177, 20);
        lblStoragePath.TabIndex = 11;
        lblStoragePath.Text = "Thư mục tài liệu / sao lưu";
        // 
        // txtDatabasePath
        // 
        txtDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDatabasePath.BackColor = System.Drawing.Color.Transparent;
        txtDatabasePath.CornerRadius = 5;
        txtDatabasePath.ErrorMessage = "";
        txtDatabasePath.HasError = false;
        txtDatabasePath.Location = new System.Drawing.Point(20, 320);
        txtDatabasePath.Name = "txtDatabasePath";
        txtDatabasePath.Placeholder = "C:\\ECMS\\Data\\ecms.db";
        txtDatabasePath.ReadOnly = false;
        txtDatabasePath.Size = new System.Drawing.Size(510, 32);
        txtDatabasePath.TabIndex = 10;
        txtDatabasePath.UseSystemPasswordChar = false;
        // 
        // lblDatabasePath
        // 
        lblDatabasePath.AutoSize = true;
        lblDatabasePath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblDatabasePath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDatabasePath.Location = new System.Drawing.Point(20, 300);
        lblDatabasePath.Name = "lblDatabasePath";
        lblDatabasePath.Size = new System.Drawing.Size(191, 20);
        lblDatabasePath.TabIndex = 9;
        lblDatabasePath.Text = "Vị trí cơ sở dữ liệu (chỉ đọc)";
        // 
        // txtDirector
        // 
        txtDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDirector.BackColor = System.Drawing.Color.Transparent;
        txtDirector.CornerRadius = 5;
        txtDirector.ErrorMessage = "";
        txtDirector.HasError = false;
        txtDirector.Location = new System.Drawing.Point(20, 255);
        txtDirector.Name = "txtDirector";
        txtDirector.Placeholder = "Nguyễn Thành Long";
        txtDirector.ReadOnly = false;
        txtDirector.Size = new System.Drawing.Size(510, 32);
        txtDirector.TabIndex = 8;
        txtDirector.UseSystemPasswordChar = false;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDirector.Location = new System.Drawing.Point(20, 235);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new System.Drawing.Size(162, 20);
        lblDirector.TabIndex = 7;
        lblDirector.Text = "Giám đốc / người ký *";
        // 
        // txtCenterAddress
        // 
        txtCenterAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCenterAddress.BackColor = System.Drawing.Color.Transparent;
        txtCenterAddress.CornerRadius = 5;
        txtCenterAddress.ErrorMessage = "";
        txtCenterAddress.HasError = false;
        txtCenterAddress.Location = new System.Drawing.Point(20, 188);
        txtCenterAddress.Name = "txtCenterAddress";
        txtCenterAddress.Placeholder = "25 Nguyễn Văn Cừ, TP. Hồ Chí Minh";
        txtCenterAddress.ReadOnly = false;
        txtCenterAddress.Size = new System.Drawing.Size(510, 32);
        txtCenterAddress.TabIndex = 6;
        txtCenterAddress.UseSystemPasswordChar = false;
        // 
        // lblCenterAddress
        // 
        lblCenterAddress.AutoSize = true;
        lblCenterAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblCenterAddress.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterAddress.Location = new System.Drawing.Point(20, 168);
        lblCenterAddress.Name = "lblCenterAddress";
        lblCenterAddress.Size = new System.Drawing.Size(67, 20);
        lblCenterAddress.TabIndex = 5;
        lblCenterAddress.Text = "Địa chỉ *";
        // 
        // txtCenterPhone
        // 
        txtCenterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtCenterPhone.BackColor = System.Drawing.Color.Transparent;
        txtCenterPhone.CornerRadius = 5;
        txtCenterPhone.ErrorMessage = "";
        txtCenterPhone.HasError = false;
        txtCenterPhone.Location = new System.Drawing.Point(290, 120);
        txtCenterPhone.Name = "txtCenterPhone";
        txtCenterPhone.Placeholder = "028 3822 6688";
        txtCenterPhone.ReadOnly = false;
        txtCenterPhone.Size = new System.Drawing.Size(240, 32);
        txtCenterPhone.TabIndex = 4;
        txtCenterPhone.UseSystemPasswordChar = false;
        // 
        // lblCenterPhone
        // 
        lblCenterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCenterPhone.AutoSize = true;
        lblCenterPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblCenterPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterPhone.Location = new System.Drawing.Point(290, 100);
        lblCenterPhone.Name = "lblCenterPhone";
        lblCenterPhone.Size = new System.Drawing.Size(92, 20);
        lblCenterPhone.TabIndex = 3;
        lblCenterPhone.Text = "Điện thoại *";
        // 
        // txtCenterName
        // 
        txtCenterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCenterName.BackColor = System.Drawing.Color.Transparent;
        txtCenterName.CornerRadius = 5;
        txtCenterName.ErrorMessage = "";
        txtCenterName.HasError = false;
        txtCenterName.Location = new System.Drawing.Point(20, 120);
        txtCenterName.Name = "txtCenterName";
        txtCenterName.Placeholder = "Trung tâm Anh ngữ Minh Trí";
        txtCenterName.ReadOnly = false;
        txtCenterName.Size = new System.Drawing.Size(250, 32);
        txtCenterName.TabIndex = 2;
        txtCenterName.UseSystemPasswordChar = false;
        // 
        // lblCenterName
        // 
        lblCenterName.AutoSize = true;
        lblCenterName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblCenterName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterName.Location = new System.Drawing.Point(20, 100);
        lblCenterName.Name = "lblCenterName";
        lblCenterName.Size = new System.Drawing.Size(120, 20);
        lblCenterName.TabIndex = 1;
        lblCenterName.Text = "Tên trung tâm *";
        // 
        // lblCenterInfoTitle
        // 
        lblCenterInfoTitle.AutoSize = true;
        lblCenterInfoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblCenterInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCenterInfoTitle.Location = new System.Drawing.Point(20, 16);
        lblCenterInfoTitle.Name = "lblCenterInfoTitle";
        lblCenterInfoTitle.Size = new System.Drawing.Size(194, 25);
        lblCenterInfoTitle.TabIndex = 0;
        lblCenterInfoTitle.Text = "Thông tin trung tâm";
        // 
        // SystemConfigView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlSubTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlSubTabs.ResumeLayout(false);
        pnlSubTabs.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardGradingRules.ResumeLayout(false);
        cardGradingRules.PerformLayout();
        cardCenterInfo.ResumeLayout(false);
        cardCenterInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnSaveConfigTop;
    private ECMS.UI.Controls.AppButton btnOpenBackupRestore;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlSubTabs;
    private System.Windows.Forms.Label lblTabCenter;
    private System.Windows.Forms.Label lblTabGrading;
    private System.Windows.Forms.Label lblTabBackup;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardCenterInfo;
    private System.Windows.Forms.Label lblCenterInfoTitle;
    private System.Windows.Forms.Label lblCenterName;
    private ECMS.UI.Controls.AppTextBox txtCenterName;
    private System.Windows.Forms.Label lblCenterPhone;
    private ECMS.UI.Controls.AppTextBox txtCenterPhone;
    private System.Windows.Forms.Label lblCenterAddress;
    private ECMS.UI.Controls.AppTextBox txtCenterAddress;
    private System.Windows.Forms.Label lblDirector;
    private ECMS.UI.Controls.AppTextBox txtDirector;
    private System.Windows.Forms.Label lblDatabasePath;
    private ECMS.UI.Controls.AppTextBox txtDatabasePath;
    private System.Windows.Forms.Label lblStoragePath;
    private ECMS.UI.Controls.AppTextBox txtStoragePath;
    private ECMS.UI.Controls.AppCard cardGradingRules;
    private System.Windows.Forms.Label lblGradingRulesTitle;
    private System.Windows.Forms.Label lblScoreScale;
    private ECMS.UI.Controls.AppTextBox txtScoreScale;
    private System.Windows.Forms.Label lblPassingScore;
    private ECMS.UI.Controls.AppTextBox txtPassingScore;
    private System.Windows.Forms.Label lblWeightRegular;
    private ECMS.UI.Controls.AppTextBox txtWeightRegular;
    private System.Windows.Forms.Label lblWeightMidterm;
    private ECMS.UI.Controls.AppTextBox txtWeightMidterm;
    private System.Windows.Forms.Label lblWeightFinal;
    private ECMS.UI.Controls.AppTextBox txtWeightFinal;
    private System.Windows.Forms.Label lblTotalWeightValidation;
    private System.Windows.Forms.Label lblMinAttendance;
    private ECMS.UI.Controls.AppTextBox txtMinAttendance;
    private System.Windows.Forms.Label lblAbsenceAlert;
    private ECMS.UI.Controls.AppTextBox txtAbsenceAlert;
    private System.Windows.Forms.CheckBox chkLateCounted;
    private System.Windows.Forms.CheckBox chkDebtCertRule;
    private ECMS.UI.Controls.AppButton btnCancelRules;
    private ECMS.UI.Controls.AppButton btnSaveRules;
    private ECMS.UI.Controls.AppBanner bannerSavedStatus;
}
