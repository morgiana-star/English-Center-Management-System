namespace ECMS.UI.UserControls;

partial class StudyMaterialView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddMaterialTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardClassMaterial = new ECMS.UI.Controls.AppCard();
        btnRebindMissingFile = new ECMS.UI.Controls.AppButton();
        btnAssignClassDoc = new ECMS.UI.Controls.AppButton();
        lblClassMaterialDesc = new System.Windows.Forms.Label();
        lblClassMaterialSubtitle = new System.Windows.Forms.Label();
        lblClassMaterialTitle = new System.Windows.Forms.Label();
        cardAddMaterial = new ECMS.UI.Controls.AppCard();
        btnSaveMaterial = new ECMS.UI.Controls.AppButton();
        btnCancelMaterial = new ECMS.UI.Controls.AppButton();
        btnCheckLocalPath = new ECMS.UI.Controls.AppButton();
        btnBrowseLocalFile = new ECMS.UI.Controls.AppButton();
        txtLocalPath = new ECMS.UI.Controls.AppTextBox();
        lblLocalPath = new System.Windows.Forms.Label();
        cboFileType = new ECMS.UI.Controls.AppComboBox();
        lblFileType = new System.Windows.Forms.Label();
        cboAssignedCourse = new ECMS.UI.Controls.AppComboBox();
        lblAssignedCourse = new System.Windows.Forms.Label();
        txtVersion = new ECMS.UI.Controls.AppTextBox();
        lblVersion = new System.Windows.Forms.Label();
        txtMaterialName = new ECMS.UI.Controls.AppTextBox();
        lblMaterialName = new System.Windows.Forms.Label();
        lblAddMaterialTitle = new System.Windows.Forms.Label();
        cardMaterialList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvMaterials = new ECMS.UI.Controls.AppDataGrid();
        cboFileTypeFilter = new ECMS.UI.Controls.AppComboBox();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchMaterial = new ECMS.UI.Controls.AppTextBox();
        lblMaterialListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardClassMaterial.SuspendLayout();
        cardAddMaterial.SuspendLayout();
        cardMaterialList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMaterials).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddMaterialTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddMaterialTop
        // 
        btnAddMaterialTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddMaterialTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAddMaterialTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddMaterialTop.CornerRadius = 5;
        btnAddMaterialTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddMaterialTop.FlatAppearance.BorderSize = 0;
        btnAddMaterialTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddMaterialTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnAddMaterialTop.ForeColor = System.Drawing.Color.White;
        btnAddMaterialTop.Location = new System.Drawing.Point(1016, 20);
        btnAddMaterialTop.Name = "btnAddMaterialTop";
        btnAddMaterialTop.Size = new System.Drawing.Size(120, 36);
        btnAddMaterialTop.TabIndex = 3;
        btnAddMaterialTop.Text = "Thêm tài liệu";
        btnAddMaterialTop.UseVisualStyleBackColor = false;
        btnAddMaterialTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(187, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tài liệu học tập";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardClassMaterial);
        pnlBody.Controls.Add(cardAddMaterial);
        pnlBody.Controls.Add(cardMaterialList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardClassMaterial
        // 
        cardClassMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardClassMaterial.BackColor = System.Drawing.Color.White;
        cardClassMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassMaterial.BorderWidth = 1;
        cardClassMaterial.Controls.Add(btnRebindMissingFile);
        cardClassMaterial.Controls.Add(btnAssignClassDoc);
        cardClassMaterial.Controls.Add(lblClassMaterialDesc);
        cardClassMaterial.Controls.Add(lblClassMaterialSubtitle);
        cardClassMaterial.Controls.Add(lblClassMaterialTitle);
        cardClassMaterial.CornerRadius = 6;
        cardClassMaterial.Location = new System.Drawing.Point(740, 365);
        cardClassMaterial.Name = "cardClassMaterial";
        cardClassMaterial.Padding = new System.Windows.Forms.Padding(20);
        cardClassMaterial.Size = new System.Drawing.Size(396, 320);
        cardClassMaterial.TabIndex = 2;
        // 
        // btnRebindMissingFile
        // 
        btnRebindMissingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnRebindMissingFile.BackColor = System.Drawing.Color.White;
        btnRebindMissingFile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnRebindMissingFile.CornerRadius = 5;
        btnRebindMissingFile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRebindMissingFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnRebindMissingFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRebindMissingFile.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnRebindMissingFile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnRebindMissingFile.Location = new System.Drawing.Point(20, 268);
        btnRebindMissingFile.Name = "btnRebindMissingFile";
        btnRebindMissingFile.Size = new System.Drawing.Size(160, 32);
        btnRebindMissingFile.TabIndex = 5;
        btnRebindMissingFile.Text = "Chọn lại tệp bị thiếu";
        btnRebindMissingFile.UseVisualStyleBackColor = false;
        btnRebindMissingFile.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnAssignClassDoc
        // 
        btnAssignClassDoc.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAssignClassDoc.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAssignClassDoc.CornerRadius = 5;
        btnAssignClassDoc.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAssignClassDoc.FlatAppearance.BorderSize = 0;
        btnAssignClassDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAssignClassDoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnAssignClassDoc.ForeColor = System.Drawing.Color.White;
        btnAssignClassDoc.Location = new System.Drawing.Point(20, 130);
        btnAssignClassDoc.Name = "btnAssignClassDoc";
        btnAssignClassDoc.Size = new System.Drawing.Size(140, 32);
        btnAssignClassDoc.TabIndex = 3;
        btnAssignClassDoc.Text = "Gán tài liệu cục bộ";
        btnAssignClassDoc.UseVisualStyleBackColor = false;
        btnAssignClassDoc.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblClassMaterialDesc
        // 
        lblClassMaterialDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblClassMaterialDesc.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblClassMaterialDesc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblClassMaterialDesc.Location = new System.Drawing.Point(20, 68);
        lblClassMaterialDesc.Name = "lblClassMaterialDesc";
        lblClassMaterialDesc.Size = new System.Drawing.Size(356, 50);
        lblClassMaterialDesc.TabIndex = 2;
        lblClassMaterialDesc.Text = ("Chưa có tài liệu được gán.\r\nChọn tài liệu của English Communication Basic để gán " + "cho lớp sắp mở.");
        // 
        // lblClassMaterialSubtitle
        // 
        lblClassMaterialSubtitle.AutoSize = true;
        lblClassMaterialSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblClassMaterialSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblClassMaterialSubtitle.Location = new System.Drawing.Point(20, 42);
        lblClassMaterialSubtitle.Name = "lblClassMaterialSubtitle";
        lblClassMaterialSubtitle.Size = new System.Drawing.Size(108, 19);
        lblClassMaterialSubtitle.TabIndex = 1;
        lblClassMaterialSubtitle.Text = "Trạng thái trống";
        // 
        // lblClassMaterialTitle
        // 
        lblClassMaterialTitle.AutoSize = true;
        lblClassMaterialTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblClassMaterialTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblClassMaterialTitle.Location = new System.Drawing.Point(20, 16);
        lblClassMaterialTitle.Name = "lblClassMaterialTitle";
        lblClassMaterialTitle.Size = new System.Drawing.Size(208, 25);
        lblClassMaterialTitle.TabIndex = 0;
        lblClassMaterialTitle.Text = "COM-B01 · Tài liệu lớp";
        // 
        // cardAddMaterial
        // 
        cardAddMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAddMaterial.BackColor = System.Drawing.Color.White;
        cardAddMaterial.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAddMaterial.BorderWidth = 1;
        cardAddMaterial.Controls.Add(btnSaveMaterial);
        cardAddMaterial.Controls.Add(btnCancelMaterial);
        cardAddMaterial.Controls.Add(btnCheckLocalPath);
        cardAddMaterial.Controls.Add(btnBrowseLocalFile);
        cardAddMaterial.Controls.Add(txtLocalPath);
        cardAddMaterial.Controls.Add(lblLocalPath);
        cardAddMaterial.Controls.Add(cboFileType);
        cardAddMaterial.Controls.Add(lblFileType);
        cardAddMaterial.Controls.Add(cboAssignedCourse);
        cardAddMaterial.Controls.Add(lblAssignedCourse);
        cardAddMaterial.Controls.Add(txtVersion);
        cardAddMaterial.Controls.Add(lblVersion);
        cardAddMaterial.Controls.Add(txtMaterialName);
        cardAddMaterial.Controls.Add(lblMaterialName);
        cardAddMaterial.Controls.Add(lblAddMaterialTitle);
        cardAddMaterial.CornerRadius = 6;
        cardAddMaterial.Location = new System.Drawing.Point(24, 365);
        cardAddMaterial.Name = "cardAddMaterial";
        cardAddMaterial.Padding = new System.Windows.Forms.Padding(20);
        cardAddMaterial.Size = new System.Drawing.Size(696, 320);
        cardAddMaterial.TabIndex = 1;
        // 
        // btnSaveMaterial
        // 
        btnSaveMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveMaterial.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveMaterial.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveMaterial.CornerRadius = 5;
        btnSaveMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveMaterial.FlatAppearance.BorderSize = 0;
        btnSaveMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveMaterial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveMaterial.ForeColor = System.Drawing.Color.White;
        btnSaveMaterial.Location = new System.Drawing.Point(596, 268);
        btnSaveMaterial.Name = "btnSaveMaterial";
        btnSaveMaterial.Size = new System.Drawing.Size(80, 32);
        btnSaveMaterial.TabIndex = 14;
        btnSaveMaterial.Text = "Lưu";
        btnSaveMaterial.UseVisualStyleBackColor = false;
        btnSaveMaterial.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelMaterial
        // 
        btnCancelMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelMaterial.BackColor = System.Drawing.Color.White;
        btnCancelMaterial.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelMaterial.CornerRadius = 5;
        btnCancelMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelMaterial.Location = new System.Drawing.Point(510, 268);
        btnCancelMaterial.Name = "btnCancelMaterial";
        btnCancelMaterial.Size = new System.Drawing.Size(75, 32);
        btnCancelMaterial.TabIndex = 13;
        btnCancelMaterial.Text = "Hủy";
        btnCancelMaterial.UseVisualStyleBackColor = false;
        btnCancelMaterial.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnCheckLocalPath
        // 
        btnCheckLocalPath.BackColor = System.Drawing.Color.White;
        btnCheckLocalPath.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCheckLocalPath.CornerRadius = 5;
        btnCheckLocalPath.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCheckLocalPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCheckLocalPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCheckLocalPath.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCheckLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCheckLocalPath.Location = new System.Drawing.Point(170, 230);
        btnCheckLocalPath.Name = "btnCheckLocalPath";
        btnCheckLocalPath.Size = new System.Drawing.Size(140, 30);
        btnCheckLocalPath.TabIndex = 12;
        btnCheckLocalPath.Text = "Kiểm tra đường dẫn";
        btnCheckLocalPath.UseVisualStyleBackColor = false;
        btnCheckLocalPath.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnBrowseLocalFile
        // 
        btnBrowseLocalFile.BackColor = System.Drawing.Color.White;
        btnBrowseLocalFile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseLocalFile.CornerRadius = 5;
        btnBrowseLocalFile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseLocalFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBrowseLocalFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseLocalFile.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBrowseLocalFile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBrowseLocalFile.Location = new System.Drawing.Point(20, 230);
        btnBrowseLocalFile.Name = "btnBrowseLocalFile";
        btnBrowseLocalFile.Size = new System.Drawing.Size(140, 30);
        btnBrowseLocalFile.TabIndex = 11;
        btnBrowseLocalFile.Text = "Chọn tệp từ máy...";
        btnBrowseLocalFile.UseVisualStyleBackColor = false;
        btnBrowseLocalFile.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtLocalPath
        // 
        txtLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtLocalPath.BackColor = System.Drawing.Color.Transparent;
        txtLocalPath.CornerRadius = 5;
        txtLocalPath.ErrorMessage = "";
        txtLocalPath.HasError = false;
        txtLocalPath.Location = new System.Drawing.Point(20, 190);
        txtLocalPath.Name = "txtLocalPath";
        txtLocalPath.Placeholder = "C:\\ECMS\\TaiLieu\\IELTS\\Foundation_Workbook_v1.2.pdf";
        txtLocalPath.ReadOnly = false;
        txtLocalPath.Size = new System.Drawing.Size(656, 32);
        txtLocalPath.TabIndex = 10;
        txtLocalPath.UseSystemPasswordChar = false;
        // 
        // lblLocalPath
        // 
        lblLocalPath.AutoSize = true;
        lblLocalPath.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblLocalPath.Location = new System.Drawing.Point(20, 170);
        lblLocalPath.Name = "lblLocalPath";
        lblLocalPath.Size = new System.Drawing.Size(147, 20);
        lblLocalPath.TabIndex = 9;
        lblLocalPath.Text = "Đường dẫn cục bộ *";
        // 
        // cboFileType
        // 
        cboFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboFileType.BackColor = System.Drawing.Color.Transparent;
        cboFileType.CornerRadius = 5;
        cboFileType.DataSource = null;
        cboFileType.DisplayMember = "";
        cboFileType.Location = new System.Drawing.Point(446, 128);
        cboFileType.Name = "cboFileType";
        cboFileType.SelectedIndex = -1;
        cboFileType.SelectedItem = null;
        cboFileType.SelectedValue = null;
        cboFileType.Size = new System.Drawing.Size(230, 32);
        cboFileType.TabIndex = 8;
        cboFileType.ValueMember = "";
        // 
        // lblFileType
        // 
        lblFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblFileType.AutoSize = true;
        lblFileType.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFileType.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblFileType.Location = new System.Drawing.Point(446, 108);
        lblFileType.Name = "lblFileType";
        lblFileType.Size = new System.Drawing.Size(63, 20);
        lblFileType.TabIndex = 7;
        lblFileType.Text = "Loại tệp";
        // 
        // cboAssignedCourse
        // 
        cboAssignedCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboAssignedCourse.BackColor = System.Drawing.Color.Transparent;
        cboAssignedCourse.CornerRadius = 5;
        cboAssignedCourse.DataSource = null;
        cboAssignedCourse.DisplayMember = "";
        cboAssignedCourse.Location = new System.Drawing.Point(20, 128);
        cboAssignedCourse.Name = "cboAssignedCourse";
        cboAssignedCourse.SelectedIndex = -1;
        cboAssignedCourse.SelectedItem = null;
        cboAssignedCourse.SelectedValue = null;
        cboAssignedCourse.Size = new System.Drawing.Size(410, 32);
        cboAssignedCourse.TabIndex = 6;
        cboAssignedCourse.ValueMember = "";
        // 
        // lblAssignedCourse
        // 
        lblAssignedCourse.AutoSize = true;
        lblAssignedCourse.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAssignedCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAssignedCourse.Location = new System.Drawing.Point(20, 108);
        lblAssignedCourse.Name = "lblAssignedCourse";
        lblAssignedCourse.Size = new System.Drawing.Size(154, 20);
        lblAssignedCourse.TabIndex = 5;
        lblAssignedCourse.Text = "Khóa học được gán *";
        // 
        // txtVersion
        // 
        txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtVersion.BackColor = System.Drawing.Color.Transparent;
        txtVersion.CornerRadius = 5;
        txtVersion.ErrorMessage = "";
        txtVersion.HasError = false;
        txtVersion.Location = new System.Drawing.Point(446, 68);
        txtVersion.Name = "txtVersion";
        txtVersion.Placeholder = "1.2";
        txtVersion.ReadOnly = false;
        txtVersion.Size = new System.Drawing.Size(230, 32);
        txtVersion.TabIndex = 4;
        txtVersion.UseSystemPasswordChar = false;
        // 
        // lblVersion
        // 
        lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblVersion.AutoSize = true;
        lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblVersion.Location = new System.Drawing.Point(446, 48);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new System.Drawing.Size(89, 20);
        lblVersion.TabIndex = 3;
        lblVersion.Text = "Phiên bản *";
        // 
        // txtMaterialName
        // 
        txtMaterialName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtMaterialName.BackColor = System.Drawing.Color.Transparent;
        txtMaterialName.CornerRadius = 5;
        txtMaterialName.ErrorMessage = "";
        txtMaterialName.HasError = false;
        txtMaterialName.Location = new System.Drawing.Point(20, 68);
        txtMaterialName.Name = "txtMaterialName";
        txtMaterialName.Placeholder = "Foundation Workbook";
        txtMaterialName.ReadOnly = false;
        txtMaterialName.Size = new System.Drawing.Size(410, 32);
        txtMaterialName.TabIndex = 2;
        txtMaterialName.UseSystemPasswordChar = false;
        // 
        // lblMaterialName
        // 
        lblMaterialName.AutoSize = true;
        lblMaterialName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblMaterialName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblMaterialName.Location = new System.Drawing.Point(20, 48);
        lblMaterialName.Name = "lblMaterialName";
        lblMaterialName.Size = new System.Drawing.Size(96, 20);
        lblMaterialName.TabIndex = 1;
        lblMaterialName.Text = "Tên tài liệu *";
        // 
        // lblAddMaterialTitle
        // 
        lblAddMaterialTitle.AutoSize = true;
        lblAddMaterialTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblAddMaterialTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAddMaterialTitle.Location = new System.Drawing.Point(20, 16);
        lblAddMaterialTitle.Name = "lblAddMaterialTitle";
        lblAddMaterialTitle.Size = new System.Drawing.Size(174, 25);
        lblAddMaterialTitle.TabIndex = 0;
        lblAddMaterialTitle.Text = "Thêm / sửa tài liệu";
        // 
        // cardMaterialList
        // 
        cardMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardMaterialList.BackColor = System.Drawing.Color.White;
        cardMaterialList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardMaterialList.BorderWidth = 1;
        cardMaterialList.Controls.Add(lblPagingNav);
        cardMaterialList.Controls.Add(lblPagingInfo);
        cardMaterialList.Controls.Add(dgvMaterials);
        cardMaterialList.Controls.Add(cboFileTypeFilter);
        cardMaterialList.Controls.Add(cboCourseFilter);
        cardMaterialList.Controls.Add(txtSearchMaterial);
        cardMaterialList.Controls.Add(lblMaterialListTitle);
        cardMaterialList.CornerRadius = 6;
        cardMaterialList.Location = new System.Drawing.Point(24, 20);
        cardMaterialList.Name = "cardMaterialList";
        cardMaterialList.Padding = new System.Windows.Forms.Padding(20);
        cardMaterialList.Size = new System.Drawing.Size(1112, 330);
        cardMaterialList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(932, 300);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(160, 20);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "< Trước   [1]   2   Sau >";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 300);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(112, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–3 / 12 tài liệu";
        // 
        // dgvMaterials
        // 
        dgvMaterials.AllowUserToAddRows = false;
        dgvMaterials.AllowUserToDeleteRows = false;
        dgvMaterials.AllowUserToResizeColumns = false;
        dgvMaterials.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvMaterials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMaterials.BackgroundColor = System.Drawing.Color.White;
        dgvMaterials.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvMaterials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvMaterials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvMaterials.DefaultCellStyle = dataGridViewCellStyle3;
        dgvMaterials.EnableHeadersVisualStyles = false;
        dgvMaterials.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvMaterials.Location = new System.Drawing.Point(20, 95);
        dgvMaterials.MultiSelect = false;
        dgvMaterials.Name = "dgvMaterials";
        dgvMaterials.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvMaterials.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvMaterials.RowHeadersVisible = false;
        dgvMaterials.RowHeadersWidth = 51;
        dgvMaterials.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMaterials.Size = new System.Drawing.Size(1072, 195);
        dgvMaterials.TabIndex = 4;
        // 
        // cboFileTypeFilter
        // 
        cboFileTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboFileTypeFilter.BackColor = System.Drawing.Color.Transparent;
        cboFileTypeFilter.CornerRadius = 5;
        cboFileTypeFilter.DataSource = null;
        cboFileTypeFilter.DisplayMember = "";
        cboFileTypeFilter.Location = new System.Drawing.Point(922, 50);
        cboFileTypeFilter.Name = "cboFileTypeFilter";
        cboFileTypeFilter.SelectedIndex = -1;
        cboFileTypeFilter.SelectedItem = null;
        cboFileTypeFilter.SelectedValue = null;
        cboFileTypeFilter.Size = new System.Drawing.Size(170, 32);
        cboFileTypeFilter.TabIndex = 3;
        cboFileTypeFilter.ValueMember = "";
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboCourseFilter.BackColor = System.Drawing.Color.Transparent;
        cboCourseFilter.CornerRadius = 5;
        cboCourseFilter.DataSource = null;
        cboCourseFilter.DisplayMember = "";
        cboCourseFilter.Location = new System.Drawing.Point(732, 50);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.SelectedIndex = -1;
        cboCourseFilter.SelectedItem = null;
        cboCourseFilter.SelectedValue = null;
        cboCourseFilter.Size = new System.Drawing.Size(180, 32);
        cboCourseFilter.TabIndex = 2;
        cboCourseFilter.ValueMember = "";
        // 
        // txtSearchMaterial
        // 
        txtSearchMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearchMaterial.BackColor = System.Drawing.Color.Transparent;
        txtSearchMaterial.CornerRadius = 5;
        txtSearchMaterial.ErrorMessage = "";
        txtSearchMaterial.HasError = false;
        txtSearchMaterial.Location = new System.Drawing.Point(20, 50);
        txtSearchMaterial.Name = "txtSearchMaterial";
        txtSearchMaterial.Placeholder = "Tìm tên tệp, khóa học, phiên bản...";
        txtSearchMaterial.ReadOnly = false;
        txtSearchMaterial.Size = new System.Drawing.Size(702, 32);
        txtSearchMaterial.TabIndex = 1;
        txtSearchMaterial.UseSystemPasswordChar = false;
        // 
        // lblMaterialListTitle
        // 
        lblMaterialListTitle.AutoSize = true;
        lblMaterialListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblMaterialListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblMaterialListTitle.Location = new System.Drawing.Point(20, 16);
        lblMaterialListTitle.Name = "lblMaterialListTitle";
        lblMaterialListTitle.Size = new System.Drawing.Size(200, 25);
        lblMaterialListTitle.TabIndex = 0;
        lblMaterialListTitle.Text = "Danh sách tệp cục bộ";
        // 
        // StudyMaterialView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardClassMaterial.ResumeLayout(false);
        cardClassMaterial.PerformLayout();
        cardAddMaterial.ResumeLayout(false);
        cardAddMaterial.PerformLayout();
        cardMaterialList.ResumeLayout(false);
        cardMaterialList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMaterials).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddMaterialTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardMaterialList;
    private System.Windows.Forms.Label lblMaterialListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchMaterial;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboFileTypeFilter;
    private ECMS.UI.Controls.AppDataGrid dgvMaterials;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppCard cardAddMaterial;
    private System.Windows.Forms.Label lblAddMaterialTitle;
    private System.Windows.Forms.Label lblMaterialName;
    private ECMS.UI.Controls.AppTextBox txtMaterialName;
    private System.Windows.Forms.Label lblVersion;
    private ECMS.UI.Controls.AppTextBox txtVersion;
    private System.Windows.Forms.Label lblAssignedCourse;
    private ECMS.UI.Controls.AppComboBox cboAssignedCourse;
    private System.Windows.Forms.Label lblFileType;
    private ECMS.UI.Controls.AppComboBox cboFileType;
    private System.Windows.Forms.Label lblLocalPath;
    private ECMS.UI.Controls.AppTextBox txtLocalPath;
    private ECMS.UI.Controls.AppButton btnBrowseLocalFile;
    private ECMS.UI.Controls.AppButton btnCheckLocalPath;
    private ECMS.UI.Controls.AppButton btnCancelMaterial;
    private ECMS.UI.Controls.AppButton btnSaveMaterial;
    private ECMS.UI.Controls.AppCard cardClassMaterial;
    private System.Windows.Forms.Label lblClassMaterialTitle;
    private System.Windows.Forms.Label lblClassMaterialSubtitle;
    private System.Windows.Forms.Label lblClassMaterialDesc;
    private ECMS.UI.Controls.AppButton btnAssignClassDoc;
    private ECMS.UI.Controls.AppButton btnRebindMissingFile;
}
