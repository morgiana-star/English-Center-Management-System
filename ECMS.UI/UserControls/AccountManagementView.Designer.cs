namespace ECMS.UI.UserControls;

partial class AccountManagementView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        tabMain = new System.Windows.Forms.TabControl();
        tabAccounts = new System.Windows.Forms.TabPage();
        pnlRightAccounts = new System.Windows.Forms.Panel();
        cardReset = new ECMS.UI.Controls.AppCard();
        btnDoReset = new ECMS.UI.Controls.AppButton();
        lblTempPassNote = new System.Windows.Forms.Label();
        txtTempPass = new ECMS.UI.Controls.AppTextBox();
        lblTempPass = new System.Windows.Forms.Label();
        lblResetTitle = new System.Windows.Forms.Label();
        cardEdit = new ECMS.UI.Controls.AppCard();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        chkEditRequirePassChange = new System.Windows.Forms.CheckBox();
        chkEditActive = new System.Windows.Forms.CheckBox();
        cboEditRole = new ECMS.UI.Controls.AppComboBox();
        lblEditRole = new System.Windows.Forms.Label();
        txtEditFullName = new ECMS.UI.Controls.AppTextBox();
        lblEditName = new System.Windows.Forms.Label();
        cboEditProfile = new ECMS.UI.Controls.AppComboBox();
        lblEditProfile = new System.Windows.Forms.Label();
        txtEditUsername = new ECMS.UI.Controls.AppTextBox();
        lblEditUser = new System.Windows.Forms.Label();
        lblEditTitle = new System.Windows.Forms.Label();
        pnlLeftAccounts = new System.Windows.Forms.Panel();
        cardTable = new ECMS.UI.Controls.AppCard();
        dgvAccounts = new ECMS.UI.Controls.AppDataGrid();
        lblListTitle = new System.Windows.Forms.Label();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboRoleFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        tabRoles = new System.Windows.Forms.TabPage();
        cardMatrix = new ECMS.UI.Controls.AppCard();
        btnSaveRoles = new ECMS.UI.Controls.AppButton();
        dgvPermissions = new ECMS.UI.Controls.AppDataGrid();
        lblMatrixSub = new System.Windows.Forms.Label();
        lblMatrixTitle = new System.Windows.Forms.Label();
        tabProfile = new System.Windows.Forms.TabPage();
        btnTopLogout = new ECMS.UI.Controls.AppButton();
        tabProfileSub = new System.Windows.Forms.TabControl();
        tabSubProfileInfo = new System.Windows.Forms.TabPage();
        bannerProfileSuccess = new ECMS.UI.Controls.AppBanner();
        cardProfile = new ECMS.UI.Controls.AppCard();
        btnSaveProf = new ECMS.UI.Controls.AppButton();
        btnCancelProf = new ECMS.UI.Controls.AppButton();
        txtUserRole = new ECMS.UI.Controls.AppTextBox();
        lblRole = new System.Windows.Forms.Label();
        txtJobTitle = new ECMS.UI.Controls.AppTextBox();
        lblJob = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblName = new System.Windows.Forms.Label();
        lblProfTitle = new System.Windows.Forms.Label();
        tabSubChangePassword = new System.Windows.Forms.TabPage();
        bannerPassSuccess = new ECMS.UI.Controls.AppBanner();
        cardPass = new ECMS.UI.Controls.AppCard();
        lblPassNote = new System.Windows.Forms.Label();
        btnSavePass = new ECMS.UI.Controls.AppButton();
        btnCancelPass = new ECMS.UI.Controls.AppButton();
        txtConfirmPass = new ECMS.UI.Controls.AppTextBox();
        lblConfirmPass = new System.Windows.Forms.Label();
        txtNewPass = new ECMS.UI.Controls.AppTextBox();
        lblNewPass = new System.Windows.Forms.Label();
        txtCurrentPass = new ECMS.UI.Controls.AppTextBox();
        lblCurPass = new System.Windows.Forms.Label();
        lblPassTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        tabMain.SuspendLayout();
        tabAccounts.SuspendLayout();
        pnlRightAccounts.SuspendLayout();
        cardReset.SuspendLayout();
        cardEdit.SuspendLayout();
        pnlLeftAccounts.SuspendLayout();
        cardTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
        tabRoles.SuspendLayout();
        cardMatrix.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPermissions).BeginInit();
        tabProfile.SuspendLayout();
        tabProfileSub.SuspendLayout();
        tabSubProfileInfo.SuspendLayout();
        cardProfile.SuspendLayout();
        tabSubChangePassword.SuspendLayout();
        cardPass.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 0);
        pnlHeader.Size = new System.Drawing.Size(1200, 68);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(304, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tài khoản & Phân quyền";
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tabAccounts);
        tabMain.Controls.Add(tabRoles);
        tabMain.Controls.Add(tabProfile);
        tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        tabMain.ItemSize = new System.Drawing.Size(180, 36);
        tabMain.Location = new System.Drawing.Point(0, 68);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Drawing.Point(16, 4);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1200, 732);
        tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabMain.TabIndex = 1;
        // 
        // tabAccounts
        // 
        tabAccounts.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabAccounts.Controls.Add(pnlRightAccounts);
        tabAccounts.Controls.Add(pnlLeftAccounts);
        tabAccounts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabAccounts.Location = new System.Drawing.Point(4, 40);
        tabAccounts.Name = "tabAccounts";
        tabAccounts.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabAccounts.Size = new System.Drawing.Size(1192, 688);
        tabAccounts.TabIndex = 0;
        tabAccounts.Text = "1. Tài khoản người dùng";
        // 
        // pnlRightAccounts
        // 
        pnlRightAccounts.Controls.Add(cardReset);
        pnlRightAccounts.Controls.Add(cardEdit);
        pnlRightAccounts.Dock = System.Windows.Forms.DockStyle.Right;
        pnlRightAccounts.Location = new System.Drawing.Point(746, 12);
        pnlRightAccounts.Name = "pnlRightAccounts";
        pnlRightAccounts.Size = new System.Drawing.Size(430, 660);
        pnlRightAccounts.TabIndex = 1;
        // 
        // cardReset
        // 
        cardReset.BackColor = System.Drawing.Color.White;
        cardReset.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardReset.BorderWidth = 1;
        cardReset.Controls.Add(btnDoReset);
        cardReset.Controls.Add(lblTempPassNote);
        cardReset.Controls.Add(txtTempPass);
        cardReset.Controls.Add(lblTempPass);
        cardReset.Controls.Add(lblResetTitle);
        cardReset.CornerRadius = 6;
        cardReset.Location = new System.Drawing.Point(2, 384);
        cardReset.Name = "cardReset";
        cardReset.Padding = new System.Windows.Forms.Padding(16);
        cardReset.Size = new System.Drawing.Size(425, 257);
        cardReset.TabIndex = 1;
        // 
        // btnDoReset
        // 
        btnDoReset.BackColor = System.Drawing.Color.White;
        btnDoReset.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnDoReset.CornerRadius = 5;
        btnDoReset.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDoReset.FlatAppearance.BorderSize = 0;
        btnDoReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDoReset.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnDoReset.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnDoReset.Location = new System.Drawing.Point(186, 202);
        btnDoReset.Name = "btnDoReset";
        btnDoReset.Size = new System.Drawing.Size(220, 36);
        btnDoReset.TabIndex = 4;
        btnDoReset.Text = "Mở khóa & Đặt lại mật khẩu";
        btnDoReset.UseVisualStyleBackColor = false;
        btnDoReset.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTempPassNote
        // 
        lblTempPassNote.AutoSize = true;
        lblTempPassNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblTempPassNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblTempPassNote.Location = new System.Drawing.Point(16, 122);
        lblTempPassNote.Name = "lblTempPassNote";
        lblTempPassNote.Size = new System.Drawing.Size(115, 20);
        lblTempPassNote.TabIndex = 3;
        lblTempPassNote.Text = "Tối thiểu 8 kí tự.";
        // 
        // txtTempPass
        // 
        txtTempPass.BackColor = System.Drawing.Color.Transparent;
        txtTempPass.CornerRadius = 5;
        txtTempPass.ErrorMessage = "";
        txtTempPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtTempPass.HasError = false;
        txtTempPass.Location = new System.Drawing.Point(16, 82);
        txtTempPass.Name = "txtTempPass";
        txtTempPass.Placeholder = "";
        txtTempPass.ReadOnly = false;
        txtTempPass.Size = new System.Drawing.Size(390, 36);
        txtTempPass.TabIndex = 2;
        txtTempPass.UseSystemPasswordChar = false;
        // 
        // lblTempPass
        // 
        lblTempPass.AutoSize = true;
        lblTempPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTempPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTempPass.Location = new System.Drawing.Point(16, 60);
        lblTempPass.Name = "lblTempPass";
        lblTempPass.Size = new System.Drawing.Size(118, 20);
        lblTempPass.TabIndex = 1;
        lblTempPass.Text = "Mật khẩu tạm *";
        // 
        // lblResetTitle
        // 
        lblResetTitle.AutoSize = true;
        lblResetTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblResetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblResetTitle.Location = new System.Drawing.Point(16, 14);
        lblResetTitle.Name = "lblResetTitle";
        lblResetTitle.Size = new System.Drawing.Size(175, 30);
        lblResetTitle.TabIndex = 0;
        lblResetTitle.Text = "Đặt lại mật khẩu";
        // 
        // cardEdit
        // 
        cardEdit.BackColor = System.Drawing.Color.White;
        cardEdit.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardEdit.BorderWidth = 1;
        cardEdit.Controls.Add(btnSave);
        cardEdit.Controls.Add(btnCancel);
        cardEdit.Controls.Add(chkEditRequirePassChange);
        cardEdit.Controls.Add(chkEditActive);
        cardEdit.Controls.Add(cboEditRole);
        cardEdit.Controls.Add(lblEditRole);
        cardEdit.Controls.Add(txtEditFullName);
        cardEdit.Controls.Add(lblEditName);
        cardEdit.Controls.Add(cboEditProfile);
        cardEdit.Controls.Add(lblEditProfile);
        cardEdit.Controls.Add(txtEditUsername);
        cardEdit.Controls.Add(lblEditUser);
        cardEdit.Controls.Add(lblEditTitle);
        cardEdit.CornerRadius = 6;
        cardEdit.Location = new System.Drawing.Point(2, 3);
        cardEdit.Name = "cardEdit";
        cardEdit.Padding = new System.Windows.Forms.Padding(16);
        cardEdit.Size = new System.Drawing.Size(425, 355);
        cardEdit.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 5;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(272, 300);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(133, 36);
        btnSave.TabIndex = 12;
        btnSave.Text = "Lưu";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnCancel.Location = new System.Drawing.Point(175, 300);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(91, 36);
        btnCancel.TabIndex = 11;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // chkEditRequirePassChange
        // 
        chkEditRequirePassChange.AutoSize = true;
        chkEditRequirePassChange.Checked = true;
        chkEditRequirePassChange.CheckState = System.Windows.Forms.CheckState.Checked;
        chkEditRequirePassChange.Location = new System.Drawing.Point(140, 260);
        chkEditRequirePassChange.Name = "chkEditRequirePassChange";
        chkEditRequirePassChange.Size = new System.Drawing.Size(251, 25);
        chkEditRequirePassChange.TabIndex = 10;
        chkEditRequirePassChange.Text = "Đổi mật khẩu lần đăng nhập tới";
        chkEditRequirePassChange.UseVisualStyleBackColor = true;
        // 
        // chkEditActive
        // 
        chkEditActive.AutoSize = true;
        chkEditActive.Checked = true;
        chkEditActive.CheckState = System.Windows.Forms.CheckState.Checked;
        chkEditActive.Location = new System.Drawing.Point(16, 260);
        chkEditActive.Name = "chkEditActive";
        chkEditActive.Size = new System.Drawing.Size(105, 25);
        chkEditActive.TabIndex = 9;
        chkEditActive.Text = "Hoạt động";
        chkEditActive.UseVisualStyleBackColor = true;
        // 
        // cboEditRole
        // 
        cboEditRole.BackColor = System.Drawing.Color.White;
        cboEditRole.CornerRadius = 5;
        cboEditRole.DataSource = null;
        cboEditRole.DisplayMember = "";
        cboEditRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboEditRole.Location = new System.Drawing.Point(16, 208);
        cboEditRole.Name = "cboEditRole";
        cboEditRole.SelectedIndex = -1;
        cboEditRole.SelectedItem = null;
        cboEditRole.SelectedValue = null;
        cboEditRole.Size = new System.Drawing.Size(390, 36);
        cboEditRole.TabIndex = 8;
        cboEditRole.ValueMember = "";
        // 
        // lblEditRole
        // 
        lblEditRole.AutoSize = true;
        lblEditRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEditRole.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEditRole.Location = new System.Drawing.Point(16, 185);
        lblEditRole.Name = "lblEditRole";
        lblEditRole.Size = new System.Drawing.Size(66, 20);
        lblEditRole.TabIndex = 7;
        lblEditRole.Text = "Vai trò *";
        // 
        // txtEditFullName
        // 
        txtEditFullName.BackColor = System.Drawing.Color.Transparent;
        txtEditFullName.CornerRadius = 5;
        txtEditFullName.ErrorMessage = "";
        txtEditFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEditFullName.HasError = false;
        txtEditFullName.Location = new System.Drawing.Point(16, 138);
        txtEditFullName.Name = "txtEditFullName";
        txtEditFullName.Placeholder = "";
        txtEditFullName.ReadOnly = true;
        txtEditFullName.Size = new System.Drawing.Size(390, 36);
        txtEditFullName.TabIndex = 6;
        txtEditFullName.UseSystemPasswordChar = false;
        // 
        // lblEditName
        // 
        lblEditName.AutoSize = true;
        lblEditName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEditName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEditName.Location = new System.Drawing.Point(16, 116);
        lblEditName.Name = "lblEditName";
        lblEditName.Size = new System.Drawing.Size(76, 20);
        lblEditName.TabIndex = 5;
        lblEditName.Text = "Họ và tên";
        // 
        // cboEditProfile
        // 
        cboEditProfile.BackColor = System.Drawing.Color.White;
        cboEditProfile.CornerRadius = 5;
        cboEditProfile.DataSource = null;
        cboEditProfile.DisplayMember = "";
        cboEditProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboEditProfile.Location = new System.Drawing.Point(215, 68);
        cboEditProfile.Name = "cboEditProfile";
        cboEditProfile.SelectedIndex = -1;
        cboEditProfile.SelectedItem = null;
        cboEditProfile.SelectedValue = null;
        cboEditProfile.Size = new System.Drawing.Size(190, 36);
        cboEditProfile.TabIndex = 4;
        cboEditProfile.ValueMember = "";
        // 
        // lblEditProfile
        // 
        lblEditProfile.AutoSize = true;
        lblEditProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEditProfile.Location = new System.Drawing.Point(215, 46);
        lblEditProfile.Name = "lblEditProfile";
        lblEditProfile.Size = new System.Drawing.Size(117, 20);
        lblEditProfile.TabIndex = 3;
        lblEditProfile.Text = "Liên kết hồ sơ *";
        // 
        // txtEditUsername
        // 
        txtEditUsername.BackColor = System.Drawing.Color.Transparent;
        txtEditUsername.CornerRadius = 5;
        txtEditUsername.ErrorMessage = "";
        txtEditUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEditUsername.HasError = false;
        txtEditUsername.Location = new System.Drawing.Point(16, 68);
        txtEditUsername.Name = "txtEditUsername";
        txtEditUsername.Placeholder = "";
        txtEditUsername.ReadOnly = false;
        txtEditUsername.Size = new System.Drawing.Size(185, 36);
        txtEditUsername.TabIndex = 2;
        txtEditUsername.UseSystemPasswordChar = false;
        // 
        // lblEditUser
        // 
        lblEditUser.AutoSize = true;
        lblEditUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEditUser.Location = new System.Drawing.Point(16, 46);
        lblEditUser.Name = "lblEditUser";
        lblEditUser.Size = new System.Drawing.Size(123, 20);
        lblEditUser.TabIndex = 1;
        lblEditUser.Text = "Tên đăng nhập *";
        // 
        // lblEditTitle
        // 
        lblEditTitle.AutoSize = true;
        lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEditTitle.Location = new System.Drawing.Point(16, 14);
        lblEditTitle.Name = "lblEditTitle";
        lblEditTitle.Size = new System.Drawing.Size(225, 30);
        lblEditTitle.TabIndex = 0;
        lblEditTitle.Text = "Thêm / Sửa tài khoản";
        // 
        // pnlLeftAccounts
        // 
        pnlLeftAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlLeftAccounts.Controls.Add(cardTable);
        pnlLeftAccounts.Controls.Add(cboStatusFilter);
        pnlLeftAccounts.Controls.Add(cboRoleFilter);
        pnlLeftAccounts.Controls.Add(txtSearch);
        pnlLeftAccounts.Location = new System.Drawing.Point(16, 12);
        pnlLeftAccounts.Name = "pnlLeftAccounts";
        pnlLeftAccounts.Size = new System.Drawing.Size(715, 660);
        pnlLeftAccounts.TabIndex = 0;
        // 
        // cardTable
        // 
        cardTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardTable.BackColor = System.Drawing.Color.White;
        cardTable.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTable.BorderWidth = 1;
        cardTable.Controls.Add(dgvAccounts);
        cardTable.Controls.Add(lblListTitle);
        cardTable.CornerRadius = 6;
        cardTable.Location = new System.Drawing.Point(0, 52);
        cardTable.Name = "cardTable";
        cardTable.Padding = new System.Windows.Forms.Padding(16);
        cardTable.Size = new System.Drawing.Size(715, 589);
        cardTable.TabIndex = 3;
        // 
        // dgvAccounts
        // 
        dgvAccounts.AllowUserToAddRows = false;
        dgvAccounts.AllowUserToDeleteRows = false;
        dgvAccounts.AllowUserToResizeColumns = false;
        dgvAccounts.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAccounts.BackgroundColor = System.Drawing.Color.White;
        dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAccounts.EnableHeadersVisualStyles = false;
        dgvAccounts.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvAccounts.Location = new System.Drawing.Point(16, 48);
        dgvAccounts.MultiSelect = false;
        dgvAccounts.Name = "dgvAccounts";
        dgvAccounts.ReadOnly = true;
        dgvAccounts.RowHeadersVisible = false;
        dgvAccounts.RowHeadersWidth = 51;
        dgvAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAccounts.Size = new System.Drawing.Size(683, 469);
        dgvAccounts.TabIndex = 1;
        // 
        // lblListTitle
        // 
        lblListTitle.AutoSize = true;
        lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblListTitle.Location = new System.Drawing.Point(16, 14);
        lblListTitle.Name = "lblListTitle";
        lblListTitle.Size = new System.Drawing.Size(213, 30);
        lblListTitle.TabIndex = 0;
        lblListTitle.Text = "Danh sách tài khoản";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStatusFilter.Location = new System.Drawing.Point(488, 10);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(160, 36);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // cboRoleFilter
        // 
        cboRoleFilter.BackColor = System.Drawing.Color.White;
        cboRoleFilter.CornerRadius = 5;
        cboRoleFilter.DataSource = null;
        cboRoleFilter.DisplayMember = "";
        cboRoleFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboRoleFilter.Location = new System.Drawing.Point(322, 10);
        cboRoleFilter.Name = "cboRoleFilter";
        cboRoleFilter.SelectedIndex = -1;
        cboRoleFilter.SelectedItem = null;
        cboRoleFilter.SelectedValue = null;
        cboRoleFilter.Size = new System.Drawing.Size(150, 36);
        cboRoleFilter.TabIndex = 1;
        cboRoleFilter.ValueMember = "";
        // 
        // txtSearch
        // 
        txtSearch.BackColor = System.Drawing.Color.Transparent;
        txtSearch.CornerRadius = 5;
        txtSearch.ErrorMessage = "";
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.HasError = false;
        txtSearch.Location = new System.Drawing.Point(16, 10);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "Tìm tên đăng nhập, họ tên...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(280, 36);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // tabRoles
        // 
        tabRoles.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabRoles.Controls.Add(cardMatrix);
        tabRoles.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabRoles.Location = new System.Drawing.Point(4, 40);
        tabRoles.Name = "tabRoles";
        tabRoles.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabRoles.Size = new System.Drawing.Size(1192, 688);
        tabRoles.TabIndex = 1;
        tabRoles.Text = "2. Vai trò & phân quyền";
        // 
        // cardMatrix
        // 
        cardMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardMatrix.BackColor = System.Drawing.Color.White;
        cardMatrix.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardMatrix.BorderWidth = 1;
        cardMatrix.Controls.Add(btnSaveRoles);
        cardMatrix.Controls.Add(dgvPermissions);
        cardMatrix.Controls.Add(lblMatrixSub);
        cardMatrix.Controls.Add(lblMatrixTitle);
        cardMatrix.CornerRadius = 6;
        cardMatrix.Location = new System.Drawing.Point(16, 15);
        cardMatrix.Name = "cardMatrix";
        cardMatrix.Padding = new System.Windows.Forms.Padding(16);
        cardMatrix.Size = new System.Drawing.Size(1160, 651);
        cardMatrix.TabIndex = 1;
        // 
        // btnSaveRoles
        // 
        btnSaveRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveRoles.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveRoles.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveRoles.CornerRadius = 5;
        btnSaveRoles.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveRoles.FlatAppearance.BorderSize = 0;
        btnSaveRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveRoles.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveRoles.ForeColor = System.Drawing.Color.White;
        btnSaveRoles.Location = new System.Drawing.Point(963, 595);
        btnSaveRoles.Name = "btnSaveRoles";
        btnSaveRoles.Size = new System.Drawing.Size(182, 36);
        btnSaveRoles.TabIndex = 3;
        btnSaveRoles.Text = "Lưu phân quyền";
        btnSaveRoles.UseVisualStyleBackColor = false;
        btnSaveRoles.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // dgvPermissions
        // 
        dgvPermissions.AllowUserToAddRows = false;
        dgvPermissions.AllowUserToDeleteRows = false;
        dgvPermissions.AllowUserToResizeColumns = false;
        dgvPermissions.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvPermissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvPermissions.BackgroundColor = System.Drawing.Color.White;
        dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvPermissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvPermissions.DefaultCellStyle = dataGridViewCellStyle6;
        dgvPermissions.EnableHeadersVisualStyles = false;
        dgvPermissions.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvPermissions.Location = new System.Drawing.Point(16, 48);
        dgvPermissions.MultiSelect = false;
        dgvPermissions.Name = "dgvPermissions";
        dgvPermissions.ReadOnly = true;
        dgvPermissions.RowHeadersVisible = false;
        dgvPermissions.RowHeadersWidth = 51;
        dgvPermissions.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvPermissions.Size = new System.Drawing.Size(1128, 531);
        dgvPermissions.TabIndex = 2;
        // 
        // lblMatrixSub
        // 
        lblMatrixSub.AutoSize = true;
        lblMatrixSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblMatrixSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblMatrixSub.Location = new System.Drawing.Point(262, 20);
        lblMatrixSub.Name = "lblMatrixSub";
        lblMatrixSub.Size = new System.Drawing.Size(699, 20);
        lblMatrixSub.TabIndex = 1;
        lblMatrixSub.Text = ("Chỉ Admin được thay đổi quyền · Q: quản lý đầy đủ · S: sửa trong phạm vi · X: chỉ" + " xem · —: không truy cập");
        // 
        // lblMatrixTitle
        // 
        lblMatrixTitle.AutoSize = true;
        lblMatrixTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblMatrixTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblMatrixTitle.Location = new System.Drawing.Point(16, 14);
        lblMatrixTitle.Name = "lblMatrixTitle";
        lblMatrixTitle.Size = new System.Drawing.Size(243, 30);
        lblMatrixTitle.TabIndex = 0;
        lblMatrixTitle.Text = "Ma trận quyền truy cập";
        // 
        // tabProfile
        // 
        tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabProfile.Controls.Add(btnTopLogout);
        tabProfile.Controls.Add(tabProfileSub);
        tabProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabProfile.Location = new System.Drawing.Point(4, 40);
        tabProfile.Name = "tabProfile";
        tabProfile.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabProfile.Size = new System.Drawing.Size(1192, 688);
        tabProfile.TabIndex = 2;
        tabProfile.Text = "3. Tài khoản cá nhân";
        // 
        // btnTopLogout
        // 
        btnTopLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnTopLogout.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnTopLogout.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnTopLogout.CornerRadius = 5;
        btnTopLogout.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTopLogout.FlatAppearance.BorderSize = 0;
        btnTopLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTopLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTopLogout.ForeColor = System.Drawing.Color.White;
        btnTopLogout.Location = new System.Drawing.Point(1055, 6);
        btnTopLogout.Name = "btnTopLogout";
        btnTopLogout.Size = new System.Drawing.Size(120, 34);
        btnTopLogout.TabIndex = 1;
        btnTopLogout.Text = "Đăng xuất";
        btnTopLogout.UseVisualStyleBackColor = false;
        btnTopLogout.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // tabProfileSub
        // 
        tabProfileSub.Controls.Add(tabSubProfileInfo);
        tabProfileSub.Controls.Add(tabSubChangePassword);
        tabProfileSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        tabProfileSub.ItemSize = new System.Drawing.Size(160, 32);
        tabProfileSub.Location = new System.Drawing.Point(16, 12);
        tabProfileSub.Name = "tabProfileSub";
        tabProfileSub.SelectedIndex = 0;
        tabProfileSub.Size = new System.Drawing.Size(1160, 636);
        tabProfileSub.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabProfileSub.TabIndex = 0;
        // 
        // tabSubProfileInfo
        // 
        tabSubProfileInfo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabSubProfileInfo.Controls.Add(bannerProfileSuccess);
        tabSubProfileInfo.Controls.Add(cardProfile);
        tabSubProfileInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabSubProfileInfo.Location = new System.Drawing.Point(4, 36);
        tabSubProfileInfo.Name = "tabSubProfileInfo";
        tabSubProfileInfo.Padding = new System.Windows.Forms.Padding(16);
        tabSubProfileInfo.Size = new System.Drawing.Size(1152, 596);
        tabSubProfileInfo.TabIndex = 0;
        tabSubProfileInfo.Text = "Hồ sơ cá nhân";
        // 
        // bannerProfileSuccess
        // 
        bannerProfileSuccess.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerProfileSuccess.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerProfileSuccess.Location = new System.Drawing.Point(16, 385);
        bannerProfileSuccess.Message = "✓ Đã cập nhật thông tin cá nhân lúc 15:42.";
        bannerProfileSuccess.Name = "bannerProfileSuccess";
        bannerProfileSuccess.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerProfileSuccess.Size = new System.Drawing.Size(1117, 81);
        bannerProfileSuccess.TabIndex = 1;
        bannerProfileSuccess.Title = "";
        bannerProfileSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerProfileSuccess.Visible = false;
        // 
        // cardProfile
        // 
        cardProfile.BackColor = System.Drawing.Color.White;
        cardProfile.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardProfile.BorderWidth = 1;
        cardProfile.Controls.Add(btnSaveProf);
        cardProfile.Controls.Add(btnCancelProf);
        cardProfile.Controls.Add(txtUserRole);
        cardProfile.Controls.Add(lblRole);
        cardProfile.Controls.Add(txtJobTitle);
        cardProfile.Controls.Add(lblJob);
        cardProfile.Controls.Add(txtEmail);
        cardProfile.Controls.Add(lblEmail);
        cardProfile.Controls.Add(txtPhone);
        cardProfile.Controls.Add(lblPhone);
        cardProfile.Controls.Add(txtFullName);
        cardProfile.Controls.Add(lblName);
        cardProfile.Controls.Add(lblProfTitle);
        cardProfile.CornerRadius = 6;
        cardProfile.Location = new System.Drawing.Point(16, 19);
        cardProfile.Name = "cardProfile";
        cardProfile.Padding = new System.Windows.Forms.Padding(16);
        cardProfile.Size = new System.Drawing.Size(1117, 350);
        cardProfile.TabIndex = 0;
        // 
        // btnSaveProf
        // 
        btnSaveProf.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveProf.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveProf.CornerRadius = 5;
        btnSaveProf.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveProf.FlatAppearance.BorderSize = 0;
        btnSaveProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveProf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveProf.ForeColor = System.Drawing.Color.White;
        btnSaveProf.Location = new System.Drawing.Point(954, 283);
        btnSaveProf.Name = "btnSaveProf";
        btnSaveProf.Size = new System.Drawing.Size(144, 36);
        btnSaveProf.TabIndex = 12;
        btnSaveProf.Text = "Lưu hồ sơ";
        btnSaveProf.UseVisualStyleBackColor = false;
        btnSaveProf.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelProf
        // 
        btnCancelProf.BackColor = System.Drawing.Color.White;
        btnCancelProf.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelProf.CornerRadius = 5;
        btnCancelProf.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelProf.FlatAppearance.BorderSize = 0;
        btnCancelProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelProf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCancelProf.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnCancelProf.Location = new System.Drawing.Point(843, 283);
        btnCancelProf.Name = "btnCancelProf";
        btnCancelProf.Size = new System.Drawing.Size(105, 36);
        btnCancelProf.TabIndex = 11;
        btnCancelProf.Text = "Hủy";
        btnCancelProf.UseVisualStyleBackColor = false;
        btnCancelProf.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtUserRole
        // 
        txtUserRole.BackColor = System.Drawing.Color.Transparent;
        txtUserRole.CornerRadius = 5;
        txtUserRole.ErrorMessage = "";
        txtUserRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtUserRole.HasError = false;
        txtUserRole.Location = new System.Drawing.Point(16, 212);
        txtUserRole.Name = "txtUserRole";
        txtUserRole.Placeholder = "";
        txtUserRole.ReadOnly = true;
        txtUserRole.Size = new System.Drawing.Size(1082, 36);
        txtUserRole.TabIndex = 10;
        txtUserRole.UseSystemPasswordChar = false;
        // 
        // lblRole
        // 
        lblRole.AutoSize = true;
        lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblRole.Location = new System.Drawing.Point(16, 190);
        lblRole.Name = "lblRole";
        lblRole.Size = new System.Drawing.Size(172, 20);
        lblRole.TabIndex = 9;
        lblRole.Text = "Tên đăng nhập / vai trò";
        // 
        // txtJobTitle
        // 
        txtJobTitle.BackColor = System.Drawing.Color.Transparent;
        txtJobTitle.CornerRadius = 5;
        txtJobTitle.ErrorMessage = "";
        txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtJobTitle.HasError = false;
        txtJobTitle.Location = new System.Drawing.Point(575, 145);
        txtJobTitle.Name = "txtJobTitle";
        txtJobTitle.Placeholder = "";
        txtJobTitle.ReadOnly = false;
        txtJobTitle.Size = new System.Drawing.Size(523, 36);
        txtJobTitle.TabIndex = 8;
        txtJobTitle.UseSystemPasswordChar = false;
        // 
        // lblJob
        // 
        lblJob.AutoSize = true;
        lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblJob.Location = new System.Drawing.Point(575, 123);
        lblJob.Name = "lblJob";
        lblJob.Size = new System.Drawing.Size(83, 20);
        lblJob.TabIndex = 7;
        lblJob.Text = "Chức danh";
        // 
        // txtEmail
        // 
        txtEmail.BackColor = System.Drawing.Color.Transparent;
        txtEmail.CornerRadius = 5;
        txtEmail.ErrorMessage = "";
        txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEmail.HasError = false;
        txtEmail.Location = new System.Drawing.Point(16, 145);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(520, 36);
        txtEmail.TabIndex = 6;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEmail.Location = new System.Drawing.Point(16, 123);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(97, 20);
        lblEmail.TabIndex = 5;
        lblEmail.Text = "Email liên hệ";
        // 
        // txtPhone
        // 
        txtPhone.BackColor = System.Drawing.Color.Transparent;
        txtPhone.CornerRadius = 5;
        txtPhone.ErrorMessage = "";
        txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtPhone.HasError = false;
        txtPhone.Location = new System.Drawing.Point(575, 71);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(523, 36);
        txtPhone.TabIndex = 4;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPhone.Location = new System.Drawing.Point(575, 49);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(92, 20);
        lblPhone.TabIndex = 3;
        lblPhone.Text = "Điện thoại *";
        // 
        // txtFullName
        // 
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(16, 71);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(520, 36);
        txtFullName.TabIndex = 2;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblName.Location = new System.Drawing.Point(16, 49);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(87, 20);
        lblName.TabIndex = 1;
        lblName.Text = "Họ và tên *";
        // 
        // lblProfTitle
        // 
        lblProfTitle.AutoSize = true;
        lblProfTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblProfTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblProfTitle.Location = new System.Drawing.Point(16, 12);
        lblProfTitle.Name = "lblProfTitle";
        lblProfTitle.Size = new System.Drawing.Size(161, 30);
        lblProfTitle.TabIndex = 0;
        lblProfTitle.Text = "Cập nhật hồ sơ";
        // 
        // tabSubChangePassword
        // 
        tabSubChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabSubChangePassword.Controls.Add(bannerPassSuccess);
        tabSubChangePassword.Controls.Add(cardPass);
        tabSubChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabSubChangePassword.Location = new System.Drawing.Point(4, 36);
        tabSubChangePassword.Name = "tabSubChangePassword";
        tabSubChangePassword.Padding = new System.Windows.Forms.Padding(16);
        tabSubChangePassword.Size = new System.Drawing.Size(1152, 596);
        tabSubChangePassword.TabIndex = 1;
        tabSubChangePassword.Text = "Đổi mật khẩu";
        // 
        // bannerPassSuccess
        // 
        bannerPassSuccess.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerPassSuccess.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerPassSuccess.Location = new System.Drawing.Point(16, 363);
        bannerPassSuccess.Message = "✓ Mật khẩu cá nhân đã được đổi thành công.";
        bannerPassSuccess.Name = "bannerPassSuccess";
        bannerPassSuccess.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerPassSuccess.Size = new System.Drawing.Size(1117, 73);
        bannerPassSuccess.TabIndex = 3;
        bannerPassSuccess.Title = "";
        bannerPassSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerPassSuccess.Visible = false;
        // 
        // cardPass
        // 
        cardPass.BackColor = System.Drawing.Color.White;
        cardPass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPass.BorderWidth = 1;
        cardPass.Controls.Add(lblPassNote);
        cardPass.Controls.Add(btnSavePass);
        cardPass.Controls.Add(btnCancelPass);
        cardPass.Controls.Add(txtConfirmPass);
        cardPass.Controls.Add(lblConfirmPass);
        cardPass.Controls.Add(txtNewPass);
        cardPass.Controls.Add(lblNewPass);
        cardPass.Controls.Add(txtCurrentPass);
        cardPass.Controls.Add(lblCurPass);
        cardPass.Controls.Add(lblPassTitle);
        cardPass.CornerRadius = 6;
        cardPass.Location = new System.Drawing.Point(16, 12);
        cardPass.Name = "cardPass";
        cardPass.Padding = new System.Windows.Forms.Padding(16);
        cardPass.Size = new System.Drawing.Size(1117, 345);
        cardPass.TabIndex = 2;
        // 
        // lblPassNote
        // 
        lblPassNote.AutoSize = true;
        lblPassNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPassNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblPassNote.Location = new System.Drawing.Point(16, 253);
        lblPassNote.Name = "lblPassNote";
        lblPassNote.Size = new System.Drawing.Size(323, 20);
        lblPassNote.TabIndex = 9;
        lblPassNote.Text = "Tối thiểu 8 ký tự, không trùng mật khẩu hiện tại.";
        // 
        // btnSavePass
        // 
        btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSavePass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSavePass.CornerRadius = 5;
        btnSavePass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSavePass.FlatAppearance.BorderSize = 0;
        btnSavePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSavePass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSavePass.ForeColor = System.Drawing.Color.White;
        btnSavePass.Location = new System.Drawing.Point(954, 290);
        btnSavePass.Name = "btnSavePass";
        btnSavePass.Size = new System.Drawing.Size(144, 36);
        btnSavePass.TabIndex = 8;
        btnSavePass.Text = "Đổi mật khẩu";
        btnSavePass.UseVisualStyleBackColor = false;
        btnSavePass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelPass
        // 
        btnCancelPass.BackColor = System.Drawing.Color.White;
        btnCancelPass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelPass.CornerRadius = 5;
        btnCancelPass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelPass.FlatAppearance.BorderSize = 0;
        btnCancelPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCancelPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnCancelPass.Location = new System.Drawing.Point(853, 290);
        btnCancelPass.Name = "btnCancelPass";
        btnCancelPass.Size = new System.Drawing.Size(95, 36);
        btnCancelPass.TabIndex = 7;
        btnCancelPass.Text = "Hủy";
        btnCancelPass.UseVisualStyleBackColor = false;
        btnCancelPass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtConfirmPass
        // 
        txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
        txtConfirmPass.CornerRadius = 5;
        txtConfirmPass.ErrorMessage = "";
        txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtConfirmPass.HasError = false;
        txtConfirmPass.Location = new System.Drawing.Point(16, 214);
        txtConfirmPass.Name = "txtConfirmPass";
        txtConfirmPass.Placeholder = "Nhập lại mật khẩu mới";
        txtConfirmPass.ReadOnly = false;
        txtConfirmPass.Size = new System.Drawing.Size(1082, 36);
        txtConfirmPass.TabIndex = 6;
        txtConfirmPass.UseSystemPasswordChar = true;
        // 
        // lblConfirmPass
        // 
        lblConfirmPass.AutoSize = true;
        lblConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblConfirmPass.Location = new System.Drawing.Point(16, 192);
        lblConfirmPass.Name = "lblConfirmPass";
        lblConfirmPass.Size = new System.Drawing.Size(148, 20);
        lblConfirmPass.TabIndex = 5;
        lblConfirmPass.Text = "Nhập lại mật khẩu *";
        // 
        // txtNewPass
        // 
        txtNewPass.BackColor = System.Drawing.Color.Transparent;
        txtNewPass.CornerRadius = 5;
        txtNewPass.ErrorMessage = "";
        txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNewPass.HasError = false;
        txtNewPass.Location = new System.Drawing.Point(16, 143);
        txtNewPass.Name = "txtNewPass";
        txtNewPass.Placeholder = "Tối thiểu 8 ký tự";
        txtNewPass.ReadOnly = false;
        txtNewPass.Size = new System.Drawing.Size(1082, 36);
        txtNewPass.TabIndex = 4;
        txtNewPass.UseSystemPasswordChar = true;
        // 
        // lblNewPass
        // 
        lblNewPass.AutoSize = true;
        lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblNewPass.Location = new System.Drawing.Point(16, 121);
        lblNewPass.Name = "lblNewPass";
        lblNewPass.Size = new System.Drawing.Size(117, 20);
        lblNewPass.TabIndex = 3;
        lblNewPass.Text = "Mật khẩu mới *";
        // 
        // txtCurrentPass
        // 
        txtCurrentPass.BackColor = System.Drawing.Color.Transparent;
        txtCurrentPass.CornerRadius = 5;
        txtCurrentPass.ErrorMessage = "";
        txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtCurrentPass.HasError = false;
        txtCurrentPass.Location = new System.Drawing.Point(16, 75);
        txtCurrentPass.Name = "txtCurrentPass";
        txtCurrentPass.Placeholder = "";
        txtCurrentPass.ReadOnly = false;
        txtCurrentPass.Size = new System.Drawing.Size(1082, 36);
        txtCurrentPass.TabIndex = 2;
        txtCurrentPass.UseSystemPasswordChar = true;
        // 
        // lblCurPass
        // 
        lblCurPass.AutoSize = true;
        lblCurPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCurPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblCurPass.Location = new System.Drawing.Point(16, 53);
        lblCurPass.Name = "lblCurPass";
        lblCurPass.Size = new System.Drawing.Size(142, 20);
        lblCurPass.TabIndex = 1;
        lblCurPass.Text = "Mật khẩu hiện tại *";
        // 
        // lblPassTitle
        // 
        lblPassTitle.AutoSize = true;
        lblPassTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPassTitle.Location = new System.Drawing.Point(16, 14);
        lblPassTitle.Name = "lblPassTitle";
        lblPassTitle.Size = new System.Drawing.Size(146, 30);
        lblPassTitle.TabIndex = 0;
        lblPassTitle.Text = "Đổi mật khẩu";
        // 
        // AccountManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(tabMain);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        Size = new System.Drawing.Size(1200, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        tabMain.ResumeLayout(false);
        tabAccounts.ResumeLayout(false);
        pnlRightAccounts.ResumeLayout(false);
        cardReset.ResumeLayout(false);
        cardReset.PerformLayout();
        cardEdit.ResumeLayout(false);
        cardEdit.PerformLayout();
        pnlLeftAccounts.ResumeLayout(false);
        cardTable.ResumeLayout(false);
        cardTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
        tabRoles.ResumeLayout(false);
        cardMatrix.ResumeLayout(false);
        cardMatrix.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPermissions).EndInit();
        tabProfile.ResumeLayout(false);
        tabProfileSub.ResumeLayout(false);
        tabSubProfileInfo.ResumeLayout(false);
        cardProfile.ResumeLayout(false);
        cardProfile.PerformLayout();
        tabSubChangePassword.ResumeLayout(false);
        cardPass.ResumeLayout(false);
        cardPass.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tabAccounts;
    private System.Windows.Forms.TabPage tabRoles;
    private System.Windows.Forms.TabPage tabProfile;

    // Tab 1 controls
    private System.Windows.Forms.Panel pnlLeftAccounts;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private ECMS.UI.Controls.AppComboBox cboRoleFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppCard cardTable;
    private System.Windows.Forms.Label lblListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvAccounts;
    private System.Windows.Forms.Panel pnlRightAccounts;
    private ECMS.UI.Controls.AppCard cardEdit;
    private System.Windows.Forms.Label lblEditTitle;
    private System.Windows.Forms.Label lblEditUser;
    private ECMS.UI.Controls.AppTextBox txtEditUsername;
    private System.Windows.Forms.Label lblEditProfile;
    private ECMS.UI.Controls.AppComboBox cboEditProfile;
    private System.Windows.Forms.Label lblEditName;
    private ECMS.UI.Controls.AppTextBox txtEditFullName;
    private System.Windows.Forms.Label lblEditRole;
    private ECMS.UI.Controls.AppComboBox cboEditRole;
    private System.Windows.Forms.CheckBox chkEditActive;
    private System.Windows.Forms.CheckBox chkEditRequirePassChange;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppCard cardReset;
    private System.Windows.Forms.Label lblResetTitle;
    private System.Windows.Forms.Label lblTempPass;
    private ECMS.UI.Controls.AppTextBox txtTempPass;
    private System.Windows.Forms.Label lblTempPassNote;
    private ECMS.UI.Controls.AppButton btnDoReset;

    // Tab 2 controls
    private ECMS.UI.Controls.AppCard cardMatrix;
    private System.Windows.Forms.Label lblMatrixTitle;
    private System.Windows.Forms.Label lblMatrixSub;
    private ECMS.UI.Controls.AppDataGrid dgvPermissions;
    private ECMS.UI.Controls.AppButton btnSaveRoles;

    // Tab 3 controls (Tài khoản cá nhân)
    private ECMS.UI.Controls.AppButton btnTopLogout;
    private System.Windows.Forms.TabControl tabProfileSub;
    private System.Windows.Forms.TabPage tabSubProfileInfo;
    private System.Windows.Forms.TabPage tabSubChangePassword;

    // Sub-tab 1: Hồ sơ cá nhân
    private ECMS.UI.Controls.AppCard cardProfile;
    private System.Windows.Forms.Label lblProfTitle;
    private System.Windows.Forms.Label lblName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private System.Windows.Forms.Label lblJob;
    private ECMS.UI.Controls.AppTextBox txtJobTitle;
    private System.Windows.Forms.Label lblRole;
    private ECMS.UI.Controls.AppTextBox txtUserRole;
    private ECMS.UI.Controls.AppButton btnCancelProf;
    private ECMS.UI.Controls.AppButton btnSaveProf;
    private ECMS.UI.Controls.AppBanner bannerProfileSuccess;

    // Sub-tab 2: Đổi mật khẩu
    private ECMS.UI.Controls.AppCard cardPass;
    private System.Windows.Forms.Label lblPassTitle;
    private System.Windows.Forms.Label lblCurPass;
    private ECMS.UI.Controls.AppTextBox txtCurrentPass;
    private System.Windows.Forms.Label lblNewPass;
    private ECMS.UI.Controls.AppTextBox txtNewPass;
    private System.Windows.Forms.Label lblConfirmPass;
    private ECMS.UI.Controls.AppTextBox txtConfirmPass;
    private System.Windows.Forms.Label lblPassNote;
    private ECMS.UI.Controls.AppButton btnCancelPass;
    private ECMS.UI.Controls.AppButton btnSavePass;
    private ECMS.UI.Controls.AppBanner bannerPassSuccess;
}
