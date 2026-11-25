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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnSaveAllTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        tabMainConfig = new System.Windows.Forms.TabControl();
        tabCenter = new System.Windows.Forms.TabPage();
        pnlTabCenterContent = new System.Windows.Forms.Panel();
        cardDbInfo = new ECMS.UI.Controls.AppCard();
        btnBrowseBackup = new ECMS.UI.Controls.AppButton();
        txtBackupDir = new ECMS.UI.Controls.AppTextBox();
        lblBackupDir = new System.Windows.Forms.Label();
        btnBrowseStorage = new ECMS.UI.Controls.AppButton();
        txtStoragePath = new ECMS.UI.Controls.AppTextBox();
        lblStoragePath = new System.Windows.Forms.Label();
        btnCheckDb = new ECMS.UI.Controls.AppButton();
        btnBrowseDb = new ECMS.UI.Controls.AppButton();
        txtDatabasePath = new ECMS.UI.Controls.AppTextBox();
        lblDatabasePath = new System.Windows.Forms.Label();
        lblDbInfoTitle = new System.Windows.Forms.Label();
        cardCenterInfo = new ECMS.UI.Controls.AppCard();
        btnBrowseLogo = new ECMS.UI.Controls.AppButton();
        picLogoPreview = new System.Windows.Forms.PictureBox();
        lblLogo = new System.Windows.Forms.Label();
        txtShortName = new ECMS.UI.Controls.AppTextBox();
        lblShortName = new System.Windows.Forms.Label();
        txtAppName = new ECMS.UI.Controls.AppTextBox();
        lblAppName = new System.Windows.Forms.Label();
        txtDirectorTitle = new ECMS.UI.Controls.AppTextBox();
        lblDirectorTitle = new System.Windows.Forms.Label();
        txtDirector = new ECMS.UI.Controls.AppTextBox();
        lblDirector = new System.Windows.Forms.Label();
        txtCenterAddress = new ECMS.UI.Controls.AppTextBox();
        lblCenterAddress = new System.Windows.Forms.Label();
        txtCenterWebsite = new ECMS.UI.Controls.AppTextBox();
        lblCenterWebsite = new System.Windows.Forms.Label();
        txtCenterEmail = new ECMS.UI.Controls.AppTextBox();
        lblCenterEmail = new System.Windows.Forms.Label();
        txtCenterPhone = new ECMS.UI.Controls.AppTextBox();
        lblCenterPhone = new System.Windows.Forms.Label();
        txtCenterName = new ECMS.UI.Controls.AppTextBox();
        lblCenterName = new System.Windows.Forms.Label();
        lblCenterInfoSub = new System.Windows.Forms.Label();
        lblCenterInfoTitle = new System.Windows.Forms.Label();
        tabGrading = new System.Windows.Forms.TabPage();
        pnlTabGradingContent = new System.Windows.Forms.Panel();
        cardAttendanceRules = new ECMS.UI.Controls.AppCard();
        txtAbsenceAlert = new ECMS.UI.Controls.AppTextBox();
        lblAbsenceAlert = new System.Windows.Forms.Label();
        txtMinAttendance = new ECMS.UI.Controls.AppTextBox();
        lblMinAttendance = new System.Windows.Forms.Label();
        lblAttendanceSub = new System.Windows.Forms.Label();
        lblAttendanceTitle = new System.Windows.Forms.Label();
        cardGradingRules = new ECMS.UI.Controls.AppCard();
        txtWeightFinal = new ECMS.UI.Controls.AppTextBox();
        lblWeightFinal = new System.Windows.Forms.Label();
        txtWeightMidterm = new ECMS.UI.Controls.AppTextBox();
        lblWeightMidterm = new System.Windows.Forms.Label();
        txtWeightRegular = new ECMS.UI.Controls.AppTextBox();
        lblWeightRegular = new System.Windows.Forms.Label();
        txtPassingScore = new ECMS.UI.Controls.AppTextBox();
        lblPassingScore = new System.Windows.Forms.Label();
        cboScoreScale = new ECMS.UI.Controls.AppComboBox();
        lblScoreScale = new System.Windows.Forms.Label();
        lblGradingRulesSub = new System.Windows.Forms.Label();
        lblGradingRulesTitle = new System.Windows.Forms.Label();
        tabBackup = new System.Windows.Forms.TabPage();
        pnlTabBackupContent = new System.Windows.Forms.Panel();
        cardBackupTable = new ECMS.UI.Controls.AppCard();
        dgvBackups = new ECMS.UI.Controls.AppDataGrid();
        lblBackupListTitle = new System.Windows.Forms.Label();
        cardAutoBackup = new ECMS.UI.Controls.AppCard();
        cboBackupTime = new ECMS.UI.Controls.AppComboBox();
        lblBackupTime = new System.Windows.Forms.Label();
        chkAutoBackup = new System.Windows.Forms.CheckBox();
        lblAutoBackupSub = new System.Windows.Forms.Label();
        lblAutoBackupTitle = new System.Windows.Forms.Label();
        pnlBackupToolbar = new System.Windows.Forms.Panel();
        btnOpenBackupFolder = new ECMS.UI.Controls.AppButton();
        btnRestoreBackup = new ECMS.UI.Controls.AppButton();
        btnCreateBackupNow = new ECMS.UI.Controls.AppButton();
        lblDbInfoSub = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        tabMainConfig.SuspendLayout();
        tabCenter.SuspendLayout();
        pnlTabCenterContent.SuspendLayout();
        cardDbInfo.SuspendLayout();
        cardCenterInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogoPreview).BeginInit();
        tabGrading.SuspendLayout();
        pnlTabGradingContent.SuspendLayout();
        cardAttendanceRules.SuspendLayout();
        cardGradingRules.SuspendLayout();
        tabBackup.SuspendLayout();
        pnlTabBackupContent.SuspendLayout();
        cardBackupTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBackups).BeginInit();
        cardAutoBackup.SuspendLayout();
        pnlBackupToolbar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlHeader.Controls.Add(btnSaveAllTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 12, 24, 0);
        pnlHeader.Size = new System.Drawing.Size(1200, 60);
        pnlHeader.TabIndex = 0;
        // 
        // btnSaveAllTop
        // 
        btnSaveAllTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveAllTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveAllTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAllTop.CornerRadius = 5;
        btnSaveAllTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAllTop.FlatAppearance.BorderSize = 0;
        btnSaveAllTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAllTop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAllTop.ForeColor = System.Drawing.Color.White;
        btnSaveAllTop.Location = new System.Drawing.Point(1006, 12);
        btnSaveAllTop.Name = "btnSaveAllTop";
        btnSaveAllTop.Size = new System.Drawing.Size(170, 36);
        btnSaveAllTop.TabIndex = 4;
        btnSaveAllTop.Text = "Lưu cấu hình";
        btnSaveAllTop.UseVisualStyleBackColor = false;
        btnSaveAllTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(24, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(250, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Cấu hình hệ thống";
        // 
        // tabMainConfig
        // 
        tabMainConfig.Controls.Add(tabCenter);
        tabMainConfig.Controls.Add(tabGrading);
        tabMainConfig.Controls.Add(tabBackup);
        tabMainConfig.Dock = System.Windows.Forms.DockStyle.Fill;
        tabMainConfig.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        tabMainConfig.ItemSize = new System.Drawing.Size(220, 36);
        tabMainConfig.Location = new System.Drawing.Point(0, 60);
        tabMainConfig.Name = "tabMainConfig";
        tabMainConfig.Padding = new System.Drawing.Point(16, 4);
        tabMainConfig.SelectedIndex = 0;
        tabMainConfig.Size = new System.Drawing.Size(1200, 740);
        tabMainConfig.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabMainConfig.TabIndex = 1;
        // 
        // tabCenter
        // 
        tabCenter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabCenter.Controls.Add(pnlTabCenterContent);
        tabCenter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabCenter.Location = new System.Drawing.Point(4, 40);
        tabCenter.Name = "tabCenter";
        tabCenter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabCenter.Size = new System.Drawing.Size(1192, 696);
        tabCenter.TabIndex = 0;
        tabCenter.Text = "🏢 1. Thông tin trung tâm & CSDL";
        // 
        // pnlTabCenterContent
        // 
        pnlTabCenterContent.AutoScroll = true;
        pnlTabCenterContent.Controls.Add(cardDbInfo);
        pnlTabCenterContent.Controls.Add(cardCenterInfo);
        pnlTabCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTabCenterContent.Location = new System.Drawing.Point(16, 12);
        pnlTabCenterContent.Name = "pnlTabCenterContent";
        pnlTabCenterContent.Size = new System.Drawing.Size(1160, 668);
        pnlTabCenterContent.TabIndex = 0;
        // 
        // cardDbInfo
        // 
        cardDbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardDbInfo.BackColor = System.Drawing.Color.White;
        cardDbInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardDbInfo.BorderWidth = 1;
        cardDbInfo.Controls.Add(btnBrowseBackup);
        cardDbInfo.Controls.Add(txtBackupDir);
        cardDbInfo.Controls.Add(lblBackupDir);
        cardDbInfo.Controls.Add(btnBrowseStorage);
        cardDbInfo.Controls.Add(txtStoragePath);
        cardDbInfo.Controls.Add(lblStoragePath);
        cardDbInfo.Controls.Add(btnCheckDb);
        cardDbInfo.Controls.Add(btnBrowseDb);
        cardDbInfo.Controls.Add(txtDatabasePath);
        cardDbInfo.Controls.Add(lblDatabasePath);
        cardDbInfo.Controls.Add(lblDbInfoSub);
        cardDbInfo.Controls.Add(lblDbInfoTitle);
        cardDbInfo.CornerRadius = 6;
        cardDbInfo.Location = new System.Drawing.Point(0, 340);
        cardDbInfo.Name = "cardDbInfo";
        cardDbInfo.Padding = new System.Windows.Forms.Padding(20);
        cardDbInfo.Size = new System.Drawing.Size(1140, 205);
        cardDbInfo.TabIndex = 2;
        // 
        // btnBrowseBackup
        // 
        btnBrowseBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBrowseBackup.BackColor = System.Drawing.Color.White;
        btnBrowseBackup.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseBackup.CornerRadius = 5;
        btnBrowseBackup.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBrowseBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBrowseBackup.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBrowseBackup.Location = new System.Drawing.Point(990, 145);
        btnBrowseBackup.Name = "btnBrowseBackup";
        btnBrowseBackup.Size = new System.Drawing.Size(130, 34);
        btnBrowseBackup.TabIndex = 11;
        btnBrowseBackup.Text = "Chọn thư mục";
        btnBrowseBackup.UseVisualStyleBackColor = false;
        btnBrowseBackup.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtBackupDir
        // 
        txtBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtBackupDir.BackColor = System.Drawing.Color.Transparent;
        txtBackupDir.CornerRadius = 5;
        txtBackupDir.ErrorMessage = "";
        txtBackupDir.HasError = false;
        txtBackupDir.Location = new System.Drawing.Point(20, 145);
        txtBackupDir.Name = "txtBackupDir";
        txtBackupDir.Placeholder = "D:\\ECMS_Backup\\";
        txtBackupDir.ReadOnly = false;
        txtBackupDir.Size = new System.Drawing.Size(950, 34);
        txtBackupDir.TabIndex = 10;
        txtBackupDir.UseSystemPasswordChar = false;
        // 
        // lblBackupDir
        // 
        lblBackupDir.AutoSize = true;
        lblBackupDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBackupDir.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblBackupDir.Location = new System.Drawing.Point(20, 122);
        lblBackupDir.Name = "lblBackupDir";
        lblBackupDir.Size = new System.Drawing.Size(209, 20);
        lblBackupDir.TabIndex = 9;
        lblBackupDir.Text = "Thư mục lưu trữ bản sao lưu";
        // 
        // btnBrowseStorage
        // 
        btnBrowseStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBrowseStorage.BackColor = System.Drawing.Color.White;
        btnBrowseStorage.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseStorage.CornerRadius = 5;
        btnBrowseStorage.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseStorage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBrowseStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseStorage.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBrowseStorage.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBrowseStorage.Location = new System.Drawing.Point(990, 145);
        btnBrowseStorage.Name = "btnBrowseStorage";
        btnBrowseStorage.Size = new System.Drawing.Size(130, 34);
        btnBrowseStorage.TabIndex = 8;
        btnBrowseStorage.Text = "Chọn thư mục";
        btnBrowseStorage.UseVisualStyleBackColor = false;
        btnBrowseStorage.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnBrowseStorage.Visible = false;
        // 
        // txtStoragePath
        // 
        txtStoragePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtStoragePath.BackColor = System.Drawing.Color.Transparent;
        txtStoragePath.CornerRadius = 5;
        txtStoragePath.ErrorMessage = "";
        txtStoragePath.HasError = false;
        txtStoragePath.Location = new System.Drawing.Point(20, 145);
        txtStoragePath.Name = "txtStoragePath";
        txtStoragePath.Placeholder = "C:\\ECMS\\TaiLieu\\";
        txtStoragePath.ReadOnly = false;
        txtStoragePath.Size = new System.Drawing.Size(950, 34);
        txtStoragePath.TabIndex = 7;
        txtStoragePath.UseSystemPasswordChar = false;
        txtStoragePath.Visible = false;
        // 
        // lblStoragePath
        // 
        lblStoragePath.AutoSize = true;
        lblStoragePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStoragePath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStoragePath.Location = new System.Drawing.Point(20, 122);
        lblStoragePath.Name = "lblStoragePath";
        lblStoragePath.Size = new System.Drawing.Size(231, 20);
        lblStoragePath.TabIndex = 6;
        lblStoragePath.Text = "Thư mục lưu trữ tài liệu học tập";
        lblStoragePath.Visible = false;
        // 
        // btnCheckDb
        // 
        btnCheckDb.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCheckDb.BackColor = System.Drawing.Color.White;
        btnCheckDb.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCheckDb.CornerRadius = 5;
        btnCheckDb.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCheckDb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCheckDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCheckDb.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCheckDb.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnCheckDb.Location = new System.Drawing.Point(990, 80);
        btnCheckDb.Name = "btnCheckDb";
        btnCheckDb.Size = new System.Drawing.Size(130, 34);
        btnCheckDb.TabIndex = 5;
        btnCheckDb.Text = "Kiểm tra";
        btnCheckDb.UseVisualStyleBackColor = false;
        btnCheckDb.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnBrowseDb
        // 
        btnBrowseDb.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBrowseDb.BackColor = System.Drawing.Color.White;
        btnBrowseDb.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseDb.CornerRadius = 5;
        btnBrowseDb.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseDb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBrowseDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseDb.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBrowseDb.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBrowseDb.Location = new System.Drawing.Point(870, 80);
        btnBrowseDb.Name = "btnBrowseDb";
        btnBrowseDb.Size = new System.Drawing.Size(110, 34);
        btnBrowseDb.TabIndex = 4;
        btnBrowseDb.Text = "📁 Chọn tệp";
        btnBrowseDb.UseVisualStyleBackColor = false;
        btnBrowseDb.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtDatabasePath
        // 
        txtDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDatabasePath.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        txtDatabasePath.CornerRadius = 5;
        txtDatabasePath.ErrorMessage = "";
        txtDatabasePath.HasError = false;
        txtDatabasePath.Location = new System.Drawing.Point(20, 80);
        txtDatabasePath.Name = "txtDatabasePath";
        txtDatabasePath.Placeholder = "C:\\ECMS\\Data\\ecms.db";
        txtDatabasePath.ReadOnly = true;
        txtDatabasePath.Size = new System.Drawing.Size(830, 34);
        txtDatabasePath.TabIndex = 3;
        txtDatabasePath.UseSystemPasswordChar = false;
        // 
        // lblDatabasePath
        // 
        lblDatabasePath.AutoSize = true;
        lblDatabasePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDatabasePath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDatabasePath.Location = new System.Drawing.Point(20, 58);
        lblDatabasePath.Name = "lblDatabasePath";
        lblDatabasePath.Size = new System.Drawing.Size(187, 20);
        lblDatabasePath.TabIndex = 2;
        lblDatabasePath.Text = "Đường dẫn CSDL SQLite *";
        // 
        // lblDbInfoTitle
        // 
        lblDbInfoTitle.AutoSize = true;
        lblDbInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblDbInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDbInfoTitle.Location = new System.Drawing.Point(20, 10);
        lblDbInfoTitle.Name = "lblDbInfoTitle";
        lblDbInfoTitle.Size = new System.Drawing.Size(145, 28);
        lblDbInfoTitle.TabIndex = 0;
        lblDbInfoTitle.Text = "Cơ sở dữ liệu";
        // 
        // cardCenterInfo
        // 
        cardCenterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCenterInfo.BackColor = System.Drawing.Color.White;
        cardCenterInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCenterInfo.BorderWidth = 1;
        cardCenterInfo.Controls.Add(btnBrowseLogo);
        cardCenterInfo.Controls.Add(picLogoPreview);
        cardCenterInfo.Controls.Add(lblLogo);
        cardCenterInfo.Controls.Add(txtShortName);
        cardCenterInfo.Controls.Add(lblShortName);
        cardCenterInfo.Controls.Add(txtAppName);
        cardCenterInfo.Controls.Add(lblAppName);
        cardCenterInfo.Controls.Add(txtDirectorTitle);
        cardCenterInfo.Controls.Add(lblDirectorTitle);
        cardCenterInfo.Controls.Add(txtDirector);
        cardCenterInfo.Controls.Add(lblDirector);
        cardCenterInfo.Controls.Add(txtCenterAddress);
        cardCenterInfo.Controls.Add(lblCenterAddress);
        cardCenterInfo.Controls.Add(txtCenterWebsite);
        cardCenterInfo.Controls.Add(lblCenterWebsite);
        cardCenterInfo.Controls.Add(txtCenterEmail);
        cardCenterInfo.Controls.Add(lblCenterEmail);
        cardCenterInfo.Controls.Add(txtCenterPhone);
        cardCenterInfo.Controls.Add(lblCenterPhone);
        cardCenterInfo.Controls.Add(txtCenterName);
        cardCenterInfo.Controls.Add(lblCenterName);
        cardCenterInfo.Controls.Add(lblCenterInfoSub);
        cardCenterInfo.Controls.Add(lblCenterInfoTitle);
        cardCenterInfo.CornerRadius = 6;
        cardCenterInfo.Location = new System.Drawing.Point(0, 3);
        cardCenterInfo.Name = "cardCenterInfo";
        cardCenterInfo.Padding = new System.Windows.Forms.Padding(20);
        cardCenterInfo.Size = new System.Drawing.Size(1140, 320);
        cardCenterInfo.TabIndex = 1;
        // 
        // lblAppName
        // 
        lblAppName.AutoSize = true;
        lblAppName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAppName.Location = new System.Drawing.Point(20, 238);
        lblAppName.Name = "lblAppName";
        lblAppName.Size = new System.Drawing.Size(228, 20);
        lblAppName.TabIndex = 16;
        lblAppName.Text = "Tên ứng dụng (Tiêu đề cửa sổ)";
        // 
        // txtAppName
        // 
        txtAppName.BackColor = System.Drawing.Color.Transparent;
        txtAppName.CornerRadius = 5;
        txtAppName.ErrorMessage = "";
        txtAppName.HasError = false;
        txtAppName.Location = new System.Drawing.Point(20, 260);
        txtAppName.Name = "txtAppName";
        txtAppName.Placeholder = "ECMS — Hệ thống quản lý trung tâm Anh ngữ";
        txtAppName.ReadOnly = false;
        txtAppName.Size = new System.Drawing.Size(400, 34);
        txtAppName.TabIndex = 17;
        txtAppName.UseSystemPasswordChar = false;
        // 
        // lblShortName
        // 
        lblShortName.AutoSize = true;
        lblShortName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblShortName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblShortName.Location = new System.Drawing.Point(440, 238);
        lblShortName.Name = "lblShortName";
        lblShortName.Size = new System.Drawing.Size(91, 20);
        lblShortName.TabIndex = 18;
        lblShortName.Text = "Tên viết tắt";
        // 
        // txtShortName
        // 
        txtShortName.BackColor = System.Drawing.Color.Transparent;
        txtShortName.CornerRadius = 5;
        txtShortName.ErrorMessage = "";
        txtShortName.HasError = false;
        txtShortName.Location = new System.Drawing.Point(440, 260);
        txtShortName.Name = "txtShortName";
        txtShortName.Placeholder = "ECMS";
        txtShortName.ReadOnly = false;
        txtShortName.Size = new System.Drawing.Size(130, 34);
        txtShortName.TabIndex = 19;
        txtShortName.UseSystemPasswordChar = false;
        // 
        // lblLogo
        // 
        lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblLogo.AutoSize = true;
        lblLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblLogo.Location = new System.Drawing.Point(590, 238);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new System.Drawing.Size(230, 20);
        lblLogo.TabIndex = 20;
        lblLogo.Text = "Ảnh Logo trung tâm (PNG / JPG)";
        // 
        // picLogoPreview
        // 
        picLogoPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        picLogoPreview.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        picLogoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picLogoPreview.Location = new System.Drawing.Point(590, 258);
        picLogoPreview.Name = "picLogoPreview";
        picLogoPreview.Size = new System.Drawing.Size(40, 40);
        picLogoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picLogoPreview.TabIndex = 21;
        picLogoPreview.TabStop = false;
        // 
        // btnBrowseLogo
        // 
        btnBrowseLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBrowseLogo.BackColor = System.Drawing.Color.White;
        btnBrowseLogo.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseLogo.CornerRadius = 5;
        btnBrowseLogo.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBrowseLogo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnBrowseLogo.Location = new System.Drawing.Point(642, 260);
        btnBrowseLogo.Name = "btnBrowseLogo";
        btnBrowseLogo.Size = new System.Drawing.Size(140, 34);
        btnBrowseLogo.TabIndex = 22;
        btnBrowseLogo.Text = "Chọn ảnh logo";
        btnBrowseLogo.UseVisualStyleBackColor = false;
        btnBrowseLogo.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtDirectorTitle
        // 
        txtDirectorTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtDirectorTitle.BackColor = System.Drawing.Color.Transparent;
        txtDirectorTitle.CornerRadius = 5;
        txtDirectorTitle.ErrorMessage = "";
        txtDirectorTitle.HasError = false;
        txtDirectorTitle.Location = new System.Drawing.Point(590, 241);
        txtDirectorTitle.Name = "txtDirectorTitle";
        txtDirectorTitle.Placeholder = "GIÁM ĐỐC TRUNG TÂM";
        txtDirectorTitle.ReadOnly = false;
        txtDirectorTitle.Size = new System.Drawing.Size(530, 34);
        txtDirectorTitle.TabIndex = 15;
        txtDirectorTitle.UseSystemPasswordChar = false;
        txtDirectorTitle.Visible = false;
        // 
        // lblDirectorTitle
        // 
        lblDirectorTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDirectorTitle.AutoSize = true;
        lblDirectorTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDirectorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDirectorTitle.Location = new System.Drawing.Point(590, 219);
        lblDirectorTitle.Name = "lblDirectorTitle";
        lblDirectorTitle.Size = new System.Drawing.Size(141, 20);
        lblDirectorTitle.TabIndex = 14;
        lblDirectorTitle.Text = "Chức vụ người ký *";
        lblDirectorTitle.Visible = false;
        // 
        // txtDirector
        // 
        txtDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDirector.BackColor = System.Drawing.Color.Transparent;
        txtDirector.CornerRadius = 5;
        txtDirector.ErrorMessage = "";
        txtDirector.HasError = false;
        txtDirector.Location = new System.Drawing.Point(20, 241);
        txtDirector.Name = "txtDirector";
        txtDirector.Placeholder = "Trần Minh Quân";
        txtDirector.ReadOnly = false;
        txtDirector.Size = new System.Drawing.Size(540, 34);
        txtDirector.TabIndex = 13;
        txtDirector.UseSystemPasswordChar = false;
        txtDirector.Visible = false;
        // 
        // lblDirector
        // 
        lblDirector.AutoSize = true;
        lblDirector.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDirector.Location = new System.Drawing.Point(20, 219);
        lblDirector.Name = "lblDirector";
        lblDirector.Size = new System.Drawing.Size(199, 20);
        lblDirector.TabIndex = 12;
        lblDirector.Text = "Người đại diện / Ký duyệt *";
        lblDirector.Visible = false;
        // 
        // txtCenterAddress
        // 
        txtCenterAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtCenterAddress.BackColor = System.Drawing.Color.Transparent;
        txtCenterAddress.CornerRadius = 5;
        txtCenterAddress.ErrorMessage = "";
        txtCenterAddress.HasError = false;
        txtCenterAddress.Location = new System.Drawing.Point(590, 171);
        txtCenterAddress.Name = "txtCenterAddress";
        txtCenterAddress.Placeholder = "25 Nguyễn Văn Cừ, Quận 5, TP.HCM";
        txtCenterAddress.ReadOnly = false;
        txtCenterAddress.Size = new System.Drawing.Size(530, 34);
        txtCenterAddress.TabIndex = 11;
        txtCenterAddress.UseSystemPasswordChar = false;
        // 
        // lblCenterAddress
        // 
        lblCenterAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCenterAddress.AutoSize = true;
        lblCenterAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCenterAddress.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterAddress.Location = new System.Drawing.Point(590, 149);
        lblCenterAddress.Name = "lblCenterAddress";
        lblCenterAddress.Size = new System.Drawing.Size(112, 20);
        lblCenterAddress.TabIndex = 10;
        lblCenterAddress.Text = "Địa chỉ trụ sở *";
        // 
        // txtCenterWebsite
        // 
        txtCenterWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCenterWebsite.BackColor = System.Drawing.Color.Transparent;
        txtCenterWebsite.CornerRadius = 5;
        txtCenterWebsite.ErrorMessage = "";
        txtCenterWebsite.HasError = false;
        txtCenterWebsite.Location = new System.Drawing.Point(20, 171);
        txtCenterWebsite.Name = "txtCenterWebsite";
        txtCenterWebsite.Placeholder = "https://ecms.edu.vn";
        txtCenterWebsite.ReadOnly = false;
        txtCenterWebsite.Size = new System.Drawing.Size(540, 34);
        txtCenterWebsite.TabIndex = 9;
        txtCenterWebsite.UseSystemPasswordChar = false;
        // 
        // lblCenterWebsite
        // 
        lblCenterWebsite.AutoSize = true;
        lblCenterWebsite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCenterWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterWebsite.Location = new System.Drawing.Point(20, 149);
        lblCenterWebsite.Name = "lblCenterWebsite";
        lblCenterWebsite.Size = new System.Drawing.Size(140, 20);
        lblCenterWebsite.TabIndex = 8;
        lblCenterWebsite.Text = "Website / Fanpage";
        // 
        // txtCenterEmail
        // 
        txtCenterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtCenterEmail.BackColor = System.Drawing.Color.Transparent;
        txtCenterEmail.CornerRadius = 5;
        txtCenterEmail.ErrorMessage = "";
        txtCenterEmail.HasError = false;
        txtCenterEmail.Location = new System.Drawing.Point(590, 101);
        txtCenterEmail.Name = "txtCenterEmail";
        txtCenterEmail.Placeholder = "contact@ecms.edu.vn";
        txtCenterEmail.ReadOnly = false;
        txtCenterEmail.Size = new System.Drawing.Size(250, 34);
        txtCenterEmail.TabIndex = 7;
        txtCenterEmail.UseSystemPasswordChar = false;
        // 
        // lblCenterEmail
        // 
        lblCenterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCenterEmail.AutoSize = true;
        lblCenterEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCenterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterEmail.Location = new System.Drawing.Point(590, 79);
        lblCenterEmail.Name = "lblCenterEmail";
        lblCenterEmail.Size = new System.Drawing.Size(97, 20);
        lblCenterEmail.TabIndex = 6;
        lblCenterEmail.Text = "Email liên hệ";
        // 
        // txtCenterPhone
        // 
        txtCenterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtCenterPhone.BackColor = System.Drawing.Color.Transparent;
        txtCenterPhone.CornerRadius = 5;
        txtCenterPhone.ErrorMessage = "";
        txtCenterPhone.HasError = false;
        txtCenterPhone.Location = new System.Drawing.Point(860, 101);
        txtCenterPhone.Name = "txtCenterPhone";
        txtCenterPhone.Placeholder = "028 3822 6688";
        txtCenterPhone.ReadOnly = false;
        txtCenterPhone.Size = new System.Drawing.Size(260, 34);
        txtCenterPhone.TabIndex = 5;
        txtCenterPhone.UseSystemPasswordChar = false;
        // 
        // lblCenterPhone
        // 
        lblCenterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCenterPhone.AutoSize = true;
        lblCenterPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCenterPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterPhone.Location = new System.Drawing.Point(860, 79);
        lblCenterPhone.Name = "lblCenterPhone";
        lblCenterPhone.Size = new System.Drawing.Size(111, 20);
        lblCenterPhone.TabIndex = 4;
        lblCenterPhone.Text = "Số điện thoại *";
        // 
        // txtCenterName
        // 
        txtCenterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCenterName.BackColor = System.Drawing.Color.Transparent;
        txtCenterName.CornerRadius = 5;
        txtCenterName.ErrorMessage = "";
        txtCenterName.HasError = false;
        txtCenterName.Location = new System.Drawing.Point(20, 101);
        txtCenterName.Name = "txtCenterName";
        txtCenterName.Placeholder = "Trung tâm Anh ngữ ECMS";
        txtCenterName.ReadOnly = false;
        txtCenterName.Size = new System.Drawing.Size(540, 34);
        txtCenterName.TabIndex = 3;
        txtCenterName.UseSystemPasswordChar = false;
        // 
        // lblCenterName
        // 
        lblCenterName.AutoSize = true;
        lblCenterName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCenterName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCenterName.Location = new System.Drawing.Point(20, 79);
        lblCenterName.Name = "lblCenterName";
        lblCenterName.Size = new System.Drawing.Size(120, 20);
        lblCenterName.TabIndex = 2;
        lblCenterName.Text = "Tên trung tâm *";
        // 
        // lblCenterInfoSub
        // 
        lblCenterInfoSub.AutoSize = true;
        lblCenterInfoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCenterInfoSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCenterInfoSub.Location = new System.Drawing.Point(20, 36);
        lblCenterInfoSub.Name = "lblCenterInfoSub";
        lblCenterInfoSub.Size = new System.Drawing.Size(536, 20);
        lblCenterInfoSub.TabIndex = 1;
        lblCenterInfoSub.Text = "Thông tin định danh hiển thị trên chứng chỉ đào tạo, biên lai thu tiền và báo cáo";
        // 
        // lblCenterInfoTitle
        // 
        lblCenterInfoTitle.AutoSize = true;
        lblCenterInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCenterInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCenterInfoTitle.Location = new System.Drawing.Point(20, 10);
        lblCenterInfoTitle.Name = "lblCenterInfoTitle";
        lblCenterInfoTitle.Size = new System.Drawing.Size(205, 28);
        lblCenterInfoTitle.TabIndex = 0;
        lblCenterInfoTitle.Text = "Thông tin trung tâm";
        // 
        // tabGrading
        // 
        tabGrading.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabGrading.Controls.Add(pnlTabGradingContent);
        tabGrading.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabGrading.Location = new System.Drawing.Point(4, 40);
        tabGrading.Name = "tabGrading";
        tabGrading.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabGrading.Size = new System.Drawing.Size(1192, 696);
        tabGrading.TabIndex = 1;
        tabGrading.Text = "🎯 2. Quy tắc điểm & Chuyên cần";
        // 
        // pnlTabGradingContent
        // 
        pnlTabGradingContent.AutoScroll = true;
        pnlTabGradingContent.Controls.Add(cardAttendanceRules);
        pnlTabGradingContent.Controls.Add(cardGradingRules);
        pnlTabGradingContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTabGradingContent.Location = new System.Drawing.Point(16, 12);
        pnlTabGradingContent.Name = "pnlTabGradingContent";
        pnlTabGradingContent.Size = new System.Drawing.Size(1160, 668);
        pnlTabGradingContent.TabIndex = 0;
        // 
        // cardAttendanceRules
        // 
        cardAttendanceRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAttendanceRules.BackColor = System.Drawing.Color.White;
        cardAttendanceRules.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAttendanceRules.BorderWidth = 1;
        cardAttendanceRules.Controls.Add(txtAbsenceAlert);
        cardAttendanceRules.Controls.Add(lblAbsenceAlert);
        cardAttendanceRules.Controls.Add(txtMinAttendance);
        cardAttendanceRules.Controls.Add(lblMinAttendance);
        cardAttendanceRules.Controls.Add(lblAttendanceSub);
        cardAttendanceRules.Controls.Add(lblAttendanceTitle);
        cardAttendanceRules.CornerRadius = 6;
        cardAttendanceRules.Location = new System.Drawing.Point(0, 310);
        cardAttendanceRules.Name = "cardAttendanceRules";
        cardAttendanceRules.Padding = new System.Windows.Forms.Padding(20);
        cardAttendanceRules.Size = new System.Drawing.Size(1140, 160);
        cardAttendanceRules.TabIndex = 1;
        // 
        // txtAbsenceAlert
        // 
        txtAbsenceAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtAbsenceAlert.BackColor = System.Drawing.Color.Transparent;
        txtAbsenceAlert.CornerRadius = 5;
        txtAbsenceAlert.ErrorMessage = "";
        txtAbsenceAlert.HasError = false;
        txtAbsenceAlert.Location = new System.Drawing.Point(590, 85);
        txtAbsenceAlert.Name = "txtAbsenceAlert";
        txtAbsenceAlert.Placeholder = "Từ 3 buổi vắng";
        txtAbsenceAlert.ReadOnly = false;
        txtAbsenceAlert.Size = new System.Drawing.Size(530, 34);
        txtAbsenceAlert.TabIndex = 5;
        txtAbsenceAlert.UseSystemPasswordChar = false;
        // 
        // lblAbsenceAlert
        // 
        lblAbsenceAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblAbsenceAlert.AutoSize = true;
        lblAbsenceAlert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAbsenceAlert.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAbsenceAlert.Location = new System.Drawing.Point(590, 62);
        lblAbsenceAlert.Name = "lblAbsenceAlert";
        lblAbsenceAlert.Size = new System.Drawing.Size(245, 20);
        lblAbsenceAlert.TabIndex = 4;
        lblAbsenceAlert.Text = "Ngưỡng cảnh báo vắng học viên *";
        // 
        // txtMinAttendance
        // 
        txtMinAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtMinAttendance.BackColor = System.Drawing.Color.Transparent;
        txtMinAttendance.CornerRadius = 5;
        txtMinAttendance.ErrorMessage = "";
        txtMinAttendance.HasError = false;
        txtMinAttendance.Location = new System.Drawing.Point(20, 85);
        txtMinAttendance.Name = "txtMinAttendance";
        txtMinAttendance.Placeholder = "80%";
        txtMinAttendance.ReadOnly = false;
        txtMinAttendance.Size = new System.Drawing.Size(540, 34);
        txtMinAttendance.TabIndex = 3;
        txtMinAttendance.UseSystemPasswordChar = false;
        // 
        // lblMinAttendance
        // 
        lblMinAttendance.AutoSize = true;
        lblMinAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMinAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblMinAttendance.Location = new System.Drawing.Point(20, 62);
        lblMinAttendance.Name = "lblMinAttendance";
        lblMinAttendance.Size = new System.Drawing.Size(271, 20);
        lblMinAttendance.TabIndex = 2;
        lblMinAttendance.Text = "Tỷ lệ chuyên cần tối thiểu đạt chuẩn *";
        // 
        // lblAttendanceSub
        // 
        lblAttendanceSub.AutoSize = true;
        lblAttendanceSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAttendanceSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAttendanceSub.Location = new System.Drawing.Point(20, 36);
        lblAttendanceSub.Name = "lblAttendanceSub";
        lblAttendanceSub.Size = new System.Drawing.Size(521, 20);
        lblAttendanceSub.TabIndex = 1;
        lblAttendanceSub.Text = "Điều kiện tham dự lớp học và tiêu chuẩn bắt buộc để xét duyệt cấp chứng chỉ";
        // 
        // lblAttendanceTitle
        // 
        lblAttendanceTitle.AutoSize = true;
        lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAttendanceTitle.Location = new System.Drawing.Point(20, 10);
        lblAttendanceTitle.Name = "lblAttendanceTitle";
        lblAttendanceTitle.Size = new System.Drawing.Size(331, 28);
        lblAttendanceTitle.TabIndex = 0;
        lblAttendanceTitle.Text = "Tiêu chuẩn chuyên cần & Điều kiện";
        // 
        // cardGradingRules
        // 
        cardGradingRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardGradingRules.BackColor = System.Drawing.Color.White;
        cardGradingRules.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGradingRules.BorderWidth = 1;
        cardGradingRules.Controls.Add(txtWeightFinal);
        cardGradingRules.Controls.Add(lblWeightFinal);
        cardGradingRules.Controls.Add(txtWeightMidterm);
        cardGradingRules.Controls.Add(lblWeightMidterm);
        cardGradingRules.Controls.Add(txtWeightRegular);
        cardGradingRules.Controls.Add(lblWeightRegular);
        cardGradingRules.Controls.Add(txtPassingScore);
        cardGradingRules.Controls.Add(lblPassingScore);
        cardGradingRules.Controls.Add(cboScoreScale);
        cardGradingRules.Controls.Add(lblScoreScale);
        cardGradingRules.Controls.Add(lblGradingRulesSub);
        cardGradingRules.Controls.Add(lblGradingRulesTitle);
        cardGradingRules.CornerRadius = 6;
        cardGradingRules.Location = new System.Drawing.Point(0, 12);
        cardGradingRules.Name = "cardGradingRules";
        cardGradingRules.Padding = new System.Windows.Forms.Padding(20);
        cardGradingRules.Size = new System.Drawing.Size(1140, 280);
        cardGradingRules.TabIndex = 0;
        // 
        // txtWeightFinal
        // 
        txtWeightFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtWeightFinal.BackColor = System.Drawing.Color.Transparent;
        txtWeightFinal.CornerRadius = 5;
        txtWeightFinal.ErrorMessage = "";
        txtWeightFinal.HasError = false;
        txtWeightFinal.Location = new System.Drawing.Point(780, 185);
        txtWeightFinal.Name = "txtWeightFinal";
        txtWeightFinal.Placeholder = "50%";
        txtWeightFinal.ReadOnly = false;
        txtWeightFinal.Size = new System.Drawing.Size(340, 34);
        txtWeightFinal.TabIndex = 11;
        txtWeightFinal.UseSystemPasswordChar = false;
        // 
        // lblWeightFinal
        // 
        lblWeightFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblWeightFinal.AutoSize = true;
        lblWeightFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblWeightFinal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightFinal.Location = new System.Drawing.Point(780, 162);
        lblWeightFinal.Name = "lblWeightFinal";
        lblWeightFinal.Size = new System.Drawing.Size(202, 20);
        lblWeightFinal.TabIndex = 10;
        lblWeightFinal.Text = "Trọng số bài thi Cuối khóa *";
        // 
        // txtWeightMidterm
        // 
        txtWeightMidterm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtWeightMidterm.BackColor = System.Drawing.Color.Transparent;
        txtWeightMidterm.CornerRadius = 5;
        txtWeightMidterm.ErrorMessage = "";
        txtWeightMidterm.HasError = false;
        txtWeightMidterm.Location = new System.Drawing.Point(400, 185);
        txtWeightMidterm.Name = "txtWeightMidterm";
        txtWeightMidterm.Placeholder = "30%";
        txtWeightMidterm.ReadOnly = false;
        txtWeightMidterm.Size = new System.Drawing.Size(350, 34);
        txtWeightMidterm.TabIndex = 9;
        txtWeightMidterm.UseSystemPasswordChar = false;
        // 
        // lblWeightMidterm
        // 
        lblWeightMidterm.AutoSize = true;
        lblWeightMidterm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblWeightMidterm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightMidterm.Location = new System.Drawing.Point(400, 162);
        lblWeightMidterm.Name = "lblWeightMidterm";
        lblWeightMidterm.Size = new System.Drawing.Size(204, 20);
        lblWeightMidterm.TabIndex = 8;
        lblWeightMidterm.Text = "Trọng số bài thi Giữa khóa *";
        // 
        // txtWeightRegular
        // 
        txtWeightRegular.BackColor = System.Drawing.Color.Transparent;
        txtWeightRegular.CornerRadius = 5;
        txtWeightRegular.ErrorMessage = "";
        txtWeightRegular.HasError = false;
        txtWeightRegular.Location = new System.Drawing.Point(20, 185);
        txtWeightRegular.Name = "txtWeightRegular";
        txtWeightRegular.Placeholder = "20%";
        txtWeightRegular.ReadOnly = false;
        txtWeightRegular.Size = new System.Drawing.Size(350, 34);
        txtWeightRegular.TabIndex = 7;
        txtWeightRegular.UseSystemPasswordChar = false;
        // 
        // lblWeightRegular
        // 
        lblWeightRegular.AutoSize = true;
        lblWeightRegular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblWeightRegular.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeightRegular.Location = new System.Drawing.Point(20, 162);
        lblWeightRegular.Name = "lblWeightRegular";
        lblWeightRegular.Size = new System.Drawing.Size(248, 20);
        lblWeightRegular.TabIndex = 6;
        lblWeightRegular.Text = "Trọng số kiểm tra Thường xuyên *";
        // 
        // txtPassingScore
        // 
        txtPassingScore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtPassingScore.BackColor = System.Drawing.Color.Transparent;
        txtPassingScore.CornerRadius = 5;
        txtPassingScore.ErrorMessage = "";
        txtPassingScore.HasError = false;
        txtPassingScore.Location = new System.Drawing.Point(590, 105);
        txtPassingScore.Name = "txtPassingScore";
        txtPassingScore.Placeholder = "6.5";
        txtPassingScore.ReadOnly = false;
        txtPassingScore.Size = new System.Drawing.Size(530, 34);
        txtPassingScore.TabIndex = 5;
        txtPassingScore.UseSystemPasswordChar = false;
        // 
        // lblPassingScore
        // 
        lblPassingScore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPassingScore.AutoSize = true;
        lblPassingScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPassingScore.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblPassingScore.Location = new System.Drawing.Point(590, 82);
        lblPassingScore.Name = "lblPassingScore";
        lblPassingScore.Size = new System.Drawing.Size(176, 20);
        lblPassingScore.TabIndex = 4;
        lblPassingScore.Text = "Điểm đạt chuẩn (GPA) *";
        // 
        // cboScoreScale
        // 
        cboScoreScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboScoreScale.BackColor = System.Drawing.Color.White;
        cboScoreScale.CornerRadius = 5;
        cboScoreScale.DataSource = null;
        cboScoreScale.DisplayMember = "";
        cboScoreScale.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboScoreScale.Location = new System.Drawing.Point(20, 105);
        cboScoreScale.Name = "cboScoreScale";
        cboScoreScale.SelectedIndex = -1;
        cboScoreScale.SelectedItem = null;
        cboScoreScale.SelectedValue = null;
        cboScoreScale.Size = new System.Drawing.Size(540, 34);
        cboScoreScale.TabIndex = 3;
        cboScoreScale.ValueMember = "";
        // 
        // lblScoreScale
        // 
        lblScoreScale.AutoSize = true;
        lblScoreScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblScoreScale.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblScoreScale.Location = new System.Drawing.Point(20, 82);
        lblScoreScale.Name = "lblScoreScale";
        lblScoreScale.Size = new System.Drawing.Size(164, 20);
        lblScoreScale.TabIndex = 2;
        lblScoreScale.Text = "Thang điểm áp dụng *";
        // 
        // lblGradingRulesSub
        // 
        lblGradingRulesSub.AutoSize = true;
        lblGradingRulesSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGradingRulesSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblGradingRulesSub.Location = new System.Drawing.Point(20, 36);
        lblGradingRulesSub.Name = "lblGradingRulesSub";
        lblGradingRulesSub.Size = new System.Drawing.Size(548, 20);
        lblGradingRulesSub.TabIndex = 1;
        lblGradingRulesSub.Text = "Cấu hình thang điểm và tỷ lệ phần trăm giữa các bài kiểm tra trong suốt khóa học";
        // 
        // lblGradingRulesTitle
        // 
        lblGradingRulesTitle.AutoSize = true;
        lblGradingRulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblGradingRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblGradingRulesTitle.Location = new System.Drawing.Point(20, 10);
        lblGradingRulesTitle.Name = "lblGradingRulesTitle";
        lblGradingRulesTitle.Size = new System.Drawing.Size(263, 28);
        lblGradingRulesTitle.TabIndex = 0;
        lblGradingRulesTitle.Text = "Quy tắc điểm số & Đánh giá";
        // 
        // tabBackup
        // 
        tabBackup.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabBackup.Controls.Add(pnlTabBackupContent);
        tabBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabBackup.Location = new System.Drawing.Point(4, 40);
        tabBackup.Name = "tabBackup";
        tabBackup.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabBackup.Size = new System.Drawing.Size(1192, 696);
        tabBackup.TabIndex = 2;
        tabBackup.Text = "💾 3. Sao lưu & Khôi phục dữ liệu";
        // 
        // pnlTabBackupContent
        // 
        pnlTabBackupContent.Controls.Add(cardBackupTable);
        pnlTabBackupContent.Controls.Add(cardAutoBackup);
        pnlTabBackupContent.Controls.Add(pnlBackupToolbar);
        pnlTabBackupContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTabBackupContent.Location = new System.Drawing.Point(16, 12);
        pnlTabBackupContent.Name = "pnlTabBackupContent";
        pnlTabBackupContent.Size = new System.Drawing.Size(1160, 668);
        pnlTabBackupContent.TabIndex = 0;
        // 
        // cardBackupTable
        // 
        cardBackupTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardBackupTable.BackColor = System.Drawing.Color.White;
        cardBackupTable.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardBackupTable.BorderWidth = 1;
        cardBackupTable.Controls.Add(dgvBackups);
        cardBackupTable.Controls.Add(lblBackupListTitle);
        cardBackupTable.CornerRadius = 6;
        cardBackupTable.Location = new System.Drawing.Point(0, 160);
        cardBackupTable.Name = "cardBackupTable";
        cardBackupTable.Padding = new System.Windows.Forms.Padding(20);
        cardBackupTable.Size = new System.Drawing.Size(1160, 500);
        cardBackupTable.TabIndex = 2;
        // 
        // dgvBackups
        // 
        dgvBackups.AllowUserToAddRows = false;
        dgvBackups.AllowUserToDeleteRows = false;
        dgvBackups.AllowUserToResizeColumns = false;
        dgvBackups.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvBackups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvBackups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvBackups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvBackups.BackgroundColor = System.Drawing.Color.White;
        dgvBackups.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvBackups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvBackups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvBackups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvBackups.DefaultCellStyle = dataGridViewCellStyle3;
        dgvBackups.EnableHeadersVisualStyles = false;
        dgvBackups.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvBackups.Location = new System.Drawing.Point(20, 57);
        dgvBackups.MultiSelect = false;
        dgvBackups.Name = "dgvBackups";
        dgvBackups.ReadOnly = true;
        dgvBackups.RowHeadersVisible = false;
        dgvBackups.RowHeadersWidth = 51;
        dgvBackups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvBackups.Size = new System.Drawing.Size(1120, 423);
        dgvBackups.TabIndex = 2;
        // 
        // lblBackupListTitle
        // 
        lblBackupListTitle.AutoSize = true;
        lblBackupListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblBackupListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblBackupListTitle.Location = new System.Drawing.Point(20, 10);
        lblBackupListTitle.Name = "lblBackupListTitle";
        lblBackupListTitle.Size = new System.Drawing.Size(231, 28);
        lblBackupListTitle.TabIndex = 0;
        lblBackupListTitle.Text = "Lịch sử các bản sao lưu";
        // 
        // cardAutoBackup
        // 
        cardAutoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAutoBackup.BackColor = System.Drawing.Color.White;
        cardAutoBackup.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAutoBackup.BorderWidth = 1;
        cardAutoBackup.Controls.Add(cboBackupTime);
        cardAutoBackup.Controls.Add(lblBackupTime);
        cardAutoBackup.Controls.Add(chkAutoBackup);
        cardAutoBackup.Controls.Add(lblAutoBackupSub);
        cardAutoBackup.Controls.Add(lblAutoBackupTitle);
        cardAutoBackup.CornerRadius = 6;
        cardAutoBackup.Location = new System.Drawing.Point(0, 52);
        cardAutoBackup.Name = "cardAutoBackup";
        cardAutoBackup.Padding = new System.Windows.Forms.Padding(20);
        cardAutoBackup.Size = new System.Drawing.Size(1160, 96);
        cardAutoBackup.TabIndex = 1;
        // 
        // cboBackupTime
        // 
        cboBackupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboBackupTime.BackColor = System.Drawing.Color.White;
        cboBackupTime.CornerRadius = 5;
        cboBackupTime.DataSource = null;
        cboBackupTime.DisplayMember = "";
        cboBackupTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboBackupTime.Location = new System.Drawing.Point(920, 36);
        cboBackupTime.Name = "cboBackupTime";
        cboBackupTime.SelectedIndex = -1;
        cboBackupTime.SelectedItem = null;
        cboBackupTime.SelectedValue = null;
        cboBackupTime.Size = new System.Drawing.Size(220, 34);
        cboBackupTime.TabIndex = 4;
        cboBackupTime.ValueMember = "";
        // 
        // lblBackupTime
        // 
        lblBackupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblBackupTime.AutoSize = true;
        lblBackupTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBackupTime.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblBackupTime.Location = new System.Drawing.Point(920, 14);
        lblBackupTime.Name = "lblBackupTime";
        lblBackupTime.Size = new System.Drawing.Size(134, 20);
        lblBackupTime.TabIndex = 3;
        lblBackupTime.Text = "Thời điểm sao lưu";
        // 
        // chkAutoBackup
        // 
        chkAutoBackup.AutoSize = true;
        chkAutoBackup.Checked = true;
        chkAutoBackup.CheckState = System.Windows.Forms.CheckState.Checked;
        chkAutoBackup.Cursor = System.Windows.Forms.Cursors.Hand;
        chkAutoBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        chkAutoBackup.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)101)), ((int)((byte)52)));
        chkAutoBackup.Location = new System.Drawing.Point(20, 56);
        chkAutoBackup.Name = "chkAutoBackup";
        chkAutoBackup.Size = new System.Drawing.Size(420, 25);
        chkAutoBackup.TabIndex = 2;
        chkAutoBackup.Text = "Bật chế độ tự động sao lưu dự phòng CSDL định kỳ";
        chkAutoBackup.UseVisualStyleBackColor = true;
        // 
        // lblAutoBackupSub
        // 
        lblAutoBackupSub.AutoSize = true;
        lblAutoBackupSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAutoBackupSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAutoBackupSub.Location = new System.Drawing.Point(20, 32);
        lblAutoBackupSub.Name = "lblAutoBackupSub";
        lblAutoBackupSub.Size = new System.Drawing.Size(523, 20);
        lblAutoBackupSub.TabIndex = 1;
        lblAutoBackupSub.Text = "Hệ thống tự động nén và sao chép CSDL vào thư mục sao lưu theo lịch đã đặt";
        // 
        // lblAutoBackupTitle
        // 
        lblAutoBackupTitle.AutoSize = true;
        lblAutoBackupTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblAutoBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAutoBackupTitle.Location = new System.Drawing.Point(20, 8);
        lblAutoBackupTitle.Name = "lblAutoBackupTitle";
        lblAutoBackupTitle.Size = new System.Drawing.Size(195, 25);
        lblAutoBackupTitle.TabIndex = 0;
        lblAutoBackupTitle.Text = "Lịch sao lưu tự động";
        // 
        // pnlBackupToolbar
        // 
        pnlBackupToolbar.Controls.Add(btnOpenBackupFolder);
        pnlBackupToolbar.Controls.Add(btnRestoreBackup);
        pnlBackupToolbar.Controls.Add(btnCreateBackupNow);
        pnlBackupToolbar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlBackupToolbar.Location = new System.Drawing.Point(0, 0);
        pnlBackupToolbar.Name = "pnlBackupToolbar";
        pnlBackupToolbar.Size = new System.Drawing.Size(1160, 46);
        pnlBackupToolbar.TabIndex = 0;
        // 
        // btnOpenBackupFolder
        // 
        btnOpenBackupFolder.BackColor = System.Drawing.Color.White;
        btnOpenBackupFolder.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenBackupFolder.CornerRadius = 5;
        btnOpenBackupFolder.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenBackupFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnOpenBackupFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenBackupFolder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnOpenBackupFolder.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnOpenBackupFolder.Location = new System.Drawing.Point(440, 4);
        btnOpenBackupFolder.Name = "btnOpenBackupFolder";
        btnOpenBackupFolder.Size = new System.Drawing.Size(180, 36);
        btnOpenBackupFolder.TabIndex = 2;
        btnOpenBackupFolder.Text = "📁 Mở thư mục chứa";
        btnOpenBackupFolder.UseVisualStyleBackColor = false;
        btnOpenBackupFolder.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnRestoreBackup
        // 
        btnRestoreBackup.BackColor = System.Drawing.Color.White;
        btnRestoreBackup.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnRestoreBackup.CornerRadius = 5;
        btnRestoreBackup.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRestoreBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRestoreBackup.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnRestoreBackup.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnRestoreBackup.Location = new System.Drawing.Point(230, 4);
        btnRestoreBackup.Name = "btnRestoreBackup";
        btnRestoreBackup.Size = new System.Drawing.Size(200, 36);
        btnRestoreBackup.TabIndex = 1;
        btnRestoreBackup.Text = "🔄 Khôi phục từ tệp (.db)";
        btnRestoreBackup.UseVisualStyleBackColor = false;
        btnRestoreBackup.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnCreateBackupNow
        // 
        btnCreateBackupNow.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnCreateBackupNow.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateBackupNow.CornerRadius = 5;
        btnCreateBackupNow.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateBackupNow.FlatAppearance.BorderSize = 0;
        btnCreateBackupNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateBackupNow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateBackupNow.ForeColor = System.Drawing.Color.White;
        btnCreateBackupNow.Location = new System.Drawing.Point(0, 4);
        btnCreateBackupNow.Name = "btnCreateBackupNow";
        btnCreateBackupNow.Size = new System.Drawing.Size(220, 36);
        btnCreateBackupNow.TabIndex = 0;
        btnCreateBackupNow.Text = "💾 Tạo bản sao lưu ngay";
        btnCreateBackupNow.UseVisualStyleBackColor = false;
        btnCreateBackupNow.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblDbInfoSub
        // 
        lblDbInfoSub.AutoSize = true;
        lblDbInfoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDbInfoSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDbInfoSub.Location = new System.Drawing.Point(20, 36);
        lblDbInfoSub.Name = "lblDbInfoSub";
        lblDbInfoSub.Size = new System.Drawing.Size(502, 20);
        lblDbInfoSub.TabIndex = 1;
        lblDbInfoSub.Text = "Cấu hình vị trí tệp cơ sở dữ liệu SQLite và các thư mục lưu trữ của hệ thống";
        // 
        // SystemConfigView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(tabMainConfig);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1200, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        tabMainConfig.ResumeLayout(false);
        tabCenter.ResumeLayout(false);
        pnlTabCenterContent.ResumeLayout(false);
        cardDbInfo.ResumeLayout(false);
        cardDbInfo.PerformLayout();
        cardCenterInfo.ResumeLayout(false);
        cardCenterInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogoPreview).EndInit();
        tabGrading.ResumeLayout(false);
        pnlTabGradingContent.ResumeLayout(false);
        cardAttendanceRules.ResumeLayout(false);
        cardAttendanceRules.PerformLayout();
        cardGradingRules.ResumeLayout(false);
        cardGradingRules.PerformLayout();
        tabBackup.ResumeLayout(false);
        pnlTabBackupContent.ResumeLayout(false);
        cardBackupTable.ResumeLayout(false);
        cardBackupTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBackups).EndInit();
        cardAutoBackup.ResumeLayout(false);
        cardAutoBackup.PerformLayout();
        pnlBackupToolbar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnSaveAllTop;
    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.TabControl tabMainConfig;
    private System.Windows.Forms.TabPage tabCenter;
    private System.Windows.Forms.TabPage tabGrading;
    private System.Windows.Forms.TabPage tabBackup;

    // Tab 1: Center & DB
    private System.Windows.Forms.Panel pnlTabCenterContent;
    private ECMS.UI.Controls.AppCard cardCenterInfo;
    private System.Windows.Forms.Label lblCenterInfoTitle;
    private System.Windows.Forms.Label lblCenterInfoSub;
    private System.Windows.Forms.Label lblCenterName;
    private ECMS.UI.Controls.AppTextBox txtCenterName;
    private System.Windows.Forms.Label lblCenterPhone;
    private ECMS.UI.Controls.AppTextBox txtCenterPhone;
    private System.Windows.Forms.Label lblCenterEmail;
    private ECMS.UI.Controls.AppTextBox txtCenterEmail;
    private System.Windows.Forms.Label lblCenterWebsite;
    private ECMS.UI.Controls.AppTextBox txtCenterWebsite;
    private System.Windows.Forms.Label lblCenterAddress;
    private ECMS.UI.Controls.AppTextBox txtCenterAddress;
    private System.Windows.Forms.Label lblDirector;
    private ECMS.UI.Controls.AppTextBox txtDirector;
    private System.Windows.Forms.Label lblDirectorTitle;
    private ECMS.UI.Controls.AppTextBox txtDirectorTitle;
    private System.Windows.Forms.Label lblAppName;
    private ECMS.UI.Controls.AppTextBox txtAppName;
    private System.Windows.Forms.Label lblShortName;
    private ECMS.UI.Controls.AppTextBox txtShortName;
    private System.Windows.Forms.Label lblLogo;
    private System.Windows.Forms.PictureBox picLogoPreview;
    private ECMS.UI.Controls.AppButton btnBrowseLogo;

    private ECMS.UI.Controls.AppCard cardDbInfo;
    private System.Windows.Forms.Label lblDbInfoTitle;
    private System.Windows.Forms.Label lblDbInfoSub;
    private System.Windows.Forms.Label lblDatabasePath;
    private ECMS.UI.Controls.AppTextBox txtDatabasePath;
    private ECMS.UI.Controls.AppButton btnBrowseDb;
    private ECMS.UI.Controls.AppButton btnCheckDb;
    private System.Windows.Forms.Label lblStoragePath;
    private ECMS.UI.Controls.AppTextBox txtStoragePath;
    private ECMS.UI.Controls.AppButton btnBrowseStorage;
    private System.Windows.Forms.Label lblBackupDir;
    private ECMS.UI.Controls.AppTextBox txtBackupDir;
    private ECMS.UI.Controls.AppButton btnBrowseBackup;

    // Tab 2: Grading & Attendance
    private System.Windows.Forms.Panel pnlTabGradingContent;
    private ECMS.UI.Controls.AppCard cardGradingRules;
    private System.Windows.Forms.Label lblGradingRulesTitle;
    private System.Windows.Forms.Label lblGradingRulesSub;
    private System.Windows.Forms.Label lblScoreScale;
    private ECMS.UI.Controls.AppComboBox cboScoreScale;
    private System.Windows.Forms.Label lblPassingScore;
    private ECMS.UI.Controls.AppTextBox txtPassingScore;
    private System.Windows.Forms.Label lblWeightRegular;
    private ECMS.UI.Controls.AppTextBox txtWeightRegular;
    private System.Windows.Forms.Label lblWeightMidterm;
    private ECMS.UI.Controls.AppTextBox txtWeightMidterm;
    private System.Windows.Forms.Label lblWeightFinal;
    private ECMS.UI.Controls.AppTextBox txtWeightFinal;

    private ECMS.UI.Controls.AppCard cardAttendanceRules;
    private System.Windows.Forms.Label lblAttendanceTitle;
    private System.Windows.Forms.Label lblAttendanceSub;
    private System.Windows.Forms.Label lblMinAttendance;
    private ECMS.UI.Controls.AppTextBox txtMinAttendance;
    private System.Windows.Forms.Label lblAbsenceAlert;
    private ECMS.UI.Controls.AppTextBox txtAbsenceAlert;

    // Tab 3: Backup & Restore
    private System.Windows.Forms.Panel pnlTabBackupContent;
    private System.Windows.Forms.Panel pnlBackupToolbar;
    private ECMS.UI.Controls.AppButton btnCreateBackupNow;
    private ECMS.UI.Controls.AppButton btnRestoreBackup;
    private ECMS.UI.Controls.AppButton btnOpenBackupFolder;

    private ECMS.UI.Controls.AppCard cardAutoBackup;
    private System.Windows.Forms.Label lblAutoBackupTitle;
    private System.Windows.Forms.Label lblAutoBackupSub;
    private System.Windows.Forms.CheckBox chkAutoBackup;
    private System.Windows.Forms.Label lblBackupTime;
    private ECMS.UI.Controls.AppComboBox cboBackupTime;

    private ECMS.UI.Controls.AppCard cardBackupTable;
    private System.Windows.Forms.Label lblBackupListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvBackups;
}