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
        pnlAccountsContainer = new System.Windows.Forms.Panel();
        cardTable = new ECMS.UI.Controls.AppCard();
        dgvAccounts = new ECMS.UI.Controls.AppDataGrid();
        lblListTitle = new System.Windows.Forms.Label();
        pnlToolbarAccounts = new System.Windows.Forms.Panel();
        btnExportAccounts = new ECMS.UI.Controls.AppButton();
        btnAddAccount = new ECMS.UI.Controls.AppButton();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboRoleFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        pnlAccountsFooter = new System.Windows.Forms.Panel();
        lblStatAdmin = new System.Windows.Forms.Label();
        lblStatLocked = new System.Windows.Forms.Label();
        lblStatActive = new System.Windows.Forms.Label();
        lblStatTotal = new System.Windows.Forms.Label();
        tabRoles = new System.Windows.Forms.TabPage();
        cardMatrix = new ECMS.UI.Controls.AppCard();
        btnResetMatrix = new ECMS.UI.Controls.AppButton();
        btnSaveRoles = new ECMS.UI.Controls.AppButton();
        dgvPermissions = new ECMS.UI.Controls.AppDataGrid();
        lblMatrixTitle = new System.Windows.Forms.Label();
        tabProfile = new System.Windows.Forms.TabPage();
        tabProfileSub = new System.Windows.Forms.TabControl();
        tabSubProfileInfo = new System.Windows.Forms.TabPage();
        cardProfileSummary = new ECMS.UI.Controls.AppCard();
        lblSummaryBranch = new System.Windows.Forms.Label();
        lblSummaryPerm = new System.Windows.Forms.Label();
        lblSummaryLastLogin = new System.Windows.Forms.Label();
        lblSummaryCreated = new System.Windows.Forms.Label();
        lblSummaryPhone = new System.Windows.Forms.Label();
        lblSummaryEmail = new System.Windows.Forms.Label();
        pnlSummaryDivider = new System.Windows.Forms.Panel();
        lblSummaryUsername = new System.Windows.Forms.Label();
        lblSummaryRoleBadge = new System.Windows.Forms.Label();
        lblSummaryName = new System.Windows.Forms.Label();
        lblAvatar = new System.Windows.Forms.Label();
        cardProfile = new ECMS.UI.Controls.AppCard();
        lblProfSub = new System.Windows.Forms.Label();
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
        cardPass = new ECMS.UI.Controls.AppCard();
        chkShowPassword = new System.Windows.Forms.CheckBox();
        lblPassSub = new System.Windows.Forms.Label();
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
        pnlAccountsContainer.SuspendLayout();
        cardTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
        pnlToolbarAccounts.SuspendLayout();
        pnlAccountsFooter.SuspendLayout();
        tabRoles.SuspendLayout();
        cardMatrix.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPermissions).BeginInit();
        tabProfile.SuspendLayout();
        tabProfileSub.SuspendLayout();
        tabSubProfileInfo.SuspendLayout();
        cardProfileSummary.SuspendLayout();
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
        pnlHeader.Size = new System.Drawing.Size(1200, 60);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(24, 12);
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
        tabMain.ItemSize = new System.Drawing.Size(190, 36);
        tabMain.Location = new System.Drawing.Point(0, 60);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Drawing.Point(16, 4);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1200, 740);
        tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabMain.TabIndex = 1;
        // 
        // tabAccounts
        // 
        tabAccounts.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabAccounts.Controls.Add(pnlAccountsContainer);
        tabAccounts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabAccounts.Location = new System.Drawing.Point(4, 40);
        tabAccounts.Name = "tabAccounts";
        tabAccounts.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabAccounts.Size = new System.Drawing.Size(1192, 696);
        tabAccounts.TabIndex = 0;
        tabAccounts.Text = "1. Tài khoản người dùng";
        // 
        // pnlAccountsContainer
        // 
        pnlAccountsContainer.Controls.Add(cardTable);
        pnlAccountsContainer.Controls.Add(pnlToolbarAccounts);
        pnlAccountsContainer.Controls.Add(pnlAccountsFooter);
        pnlAccountsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlAccountsContainer.Location = new System.Drawing.Point(16, 12);
        pnlAccountsContainer.Name = "pnlAccountsContainer";
        pnlAccountsContainer.Size = new System.Drawing.Size(1160, 668);
        pnlAccountsContainer.TabIndex = 0;
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
        cardTable.Size = new System.Drawing.Size(1160, 574);
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
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
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
        dgvAccounts.Size = new System.Drawing.Size(1128, 510);
        dgvAccounts.TabIndex = 1;
        // 
        // lblListTitle
        // 
        lblListTitle.AutoSize = true;
        lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblListTitle.Location = new System.Drawing.Point(16, 14);
        lblListTitle.Name = "lblListTitle";
        lblListTitle.Size = new System.Drawing.Size(205, 28);
        lblListTitle.TabIndex = 0;
        lblListTitle.Text = "Danh sách tài khoản";
        // 
        // pnlToolbarAccounts
        // 
        pnlToolbarAccounts.Controls.Add(btnExportAccounts);
        pnlToolbarAccounts.Controls.Add(btnAddAccount);
        pnlToolbarAccounts.Controls.Add(cboStatusFilter);
        pnlToolbarAccounts.Controls.Add(cboRoleFilter);
        pnlToolbarAccounts.Controls.Add(txtSearch);
        pnlToolbarAccounts.Dock = System.Windows.Forms.DockStyle.Top;
        pnlToolbarAccounts.Location = new System.Drawing.Point(0, 0);
        pnlToolbarAccounts.Name = "pnlToolbarAccounts";
        pnlToolbarAccounts.Size = new System.Drawing.Size(1160, 46);
        pnlToolbarAccounts.TabIndex = 0;
        // 
        // btnExportAccounts
        // 
        btnExportAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnExportAccounts.BackColor = System.Drawing.Color.White;
        btnExportAccounts.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportAccounts.CornerRadius = 5;
        btnExportAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportAccounts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnExportAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportAccounts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnExportAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnExportAccounts.Location = new System.Drawing.Point(826, 4);
        btnExportAccounts.Name = "btnExportAccounts";
        btnExportAccounts.Size = new System.Drawing.Size(140, 36);
        btnExportAccounts.TabIndex = 4;
        btnExportAccounts.Text = "Xuất danh sách";
        btnExportAccounts.UseVisualStyleBackColor = false;
        btnExportAccounts.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnAddAccount
        // 
        btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAddAccount.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddAccount.CornerRadius = 5;
        btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddAccount.FlatAppearance.BorderSize = 0;
        btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddAccount.ForeColor = System.Drawing.Color.White;
        btnAddAccount.Location = new System.Drawing.Point(976, 4);
        btnAddAccount.Name = "btnAddAccount";
        btnAddAccount.Size = new System.Drawing.Size(184, 36);
        btnAddAccount.TabIndex = 3;
        btnAddAccount.Text = "+ Thêm tài khoản";
        btnAddAccount.UseVisualStyleBackColor = false;
        btnAddAccount.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStatusFilter.Location = new System.Drawing.Point(478, 7);
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
        cboRoleFilter.Location = new System.Drawing.Point(308, 7);
        cboRoleFilter.Name = "cboRoleFilter";
        cboRoleFilter.SelectedIndex = -1;
        cboRoleFilter.SelectedItem = null;
        cboRoleFilter.SelectedValue = null;
        cboRoleFilter.Size = new System.Drawing.Size(160, 36);
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
        txtSearch.Location = new System.Drawing.Point(16, 7);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "Tìm tên đăng nhập, họ tên, email...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(280, 36);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // pnlAccountsFooter
        // 
        pnlAccountsFooter.Controls.Add(lblStatAdmin);
        pnlAccountsFooter.Controls.Add(lblStatLocked);
        pnlAccountsFooter.Controls.Add(lblStatActive);
        pnlAccountsFooter.Controls.Add(lblStatTotal);
        pnlAccountsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlAccountsFooter.Location = new System.Drawing.Point(0, 632);
        pnlAccountsFooter.Name = "pnlAccountsFooter";
        pnlAccountsFooter.Size = new System.Drawing.Size(1160, 36);
        pnlAccountsFooter.TabIndex = 4;
        // 
        // lblStatAdmin
        // 
        lblStatAdmin.AutoSize = true;
        lblStatAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStatAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatAdmin.Location = new System.Drawing.Point(496, 8);
        lblStatAdmin.Name = "lblStatAdmin";
        lblStatAdmin.Size = new System.Drawing.Size(116, 21);
        lblStatAdmin.TabIndex = 3;
        lblStatAdmin.Text = "Quản trị viên: 1";
        // 
        // lblStatLocked
        // 
        lblStatLocked.AutoSize = true;
        lblStatLocked.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStatLocked.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblStatLocked.Location = new System.Drawing.Point(373, 8);
        lblStatLocked.Name = "lblStatLocked";
        lblStatLocked.Size = new System.Drawing.Size(83, 21);
        lblStatLocked.TabIndex = 2;
        lblStatLocked.Text = "Đã khóa: 1";
        // 
        // lblStatActive
        // 
        lblStatActive.AutoSize = true;
        lblStatActive.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStatActive.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)101)), ((int)((byte)52)));
        lblStatActive.Location = new System.Drawing.Point(203, 8);
        lblStatActive.Name = "lblStatActive";
        lblStatActive.Size = new System.Drawing.Size(138, 21);
        lblStatActive.TabIndex = 1;
        lblStatActive.Text = "Đang hoạt động: 4";
        // 
        // lblStatTotal
        // 
        lblStatTotal.AutoSize = true;
        lblStatTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStatTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatTotal.Location = new System.Drawing.Point(4, 8);
        lblStatTotal.Name = "lblStatTotal";
        lblStatTotal.Size = new System.Drawing.Size(163, 21);
        lblStatTotal.TabIndex = 0;
        lblStatTotal.Text = "Tổng số: 5 tài khoản";
        // 
        // tabRoles
        // 
        tabRoles.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabRoles.Controls.Add(cardMatrix);
        tabRoles.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabRoles.Location = new System.Drawing.Point(4, 40);
        tabRoles.Name = "tabRoles";
        tabRoles.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabRoles.Size = new System.Drawing.Size(1192, 696);
        tabRoles.TabIndex = 1;
        tabRoles.Text = "2. Vai trò & phân quyền";
        // 
        // cardMatrix
        // 
        cardMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardMatrix.BackColor = System.Drawing.Color.White;
        cardMatrix.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardMatrix.BorderWidth = 1;
        cardMatrix.Controls.Add(btnResetMatrix);
        cardMatrix.Controls.Add(btnSaveRoles);
        cardMatrix.Controls.Add(dgvPermissions);
        cardMatrix.Controls.Add(lblMatrixTitle);
        cardMatrix.CornerRadius = 6;
        cardMatrix.Location = new System.Drawing.Point(16, 15);
        cardMatrix.Name = "cardMatrix";
        cardMatrix.Padding = new System.Windows.Forms.Padding(16);
        cardMatrix.Size = new System.Drawing.Size(1160, 660);
        cardMatrix.TabIndex = 1;
        // 
        // btnResetMatrix
        // 
        btnResetMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnResetMatrix.BackColor = System.Drawing.Color.White;
        btnResetMatrix.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnResetMatrix.CornerRadius = 5;
        btnResetMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
        btnResetMatrix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnResetMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnResetMatrix.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnResetMatrix.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnResetMatrix.Location = new System.Drawing.Point(820, 10);
        btnResetMatrix.Name = "btnResetMatrix";
        btnResetMatrix.Size = new System.Drawing.Size(150, 34);
        btnResetMatrix.TabIndex = 4;
        btnResetMatrix.Text = "Khôi phục mặc định";
        btnResetMatrix.UseVisualStyleBackColor = false;
        btnResetMatrix.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnSaveRoles
        // 
        btnSaveRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveRoles.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveRoles.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveRoles.CornerRadius = 5;
        btnSaveRoles.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveRoles.FlatAppearance.BorderSize = 0;
        btnSaveRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveRoles.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveRoles.ForeColor = System.Drawing.Color.White;
        btnSaveRoles.Location = new System.Drawing.Point(980, 10);
        btnSaveRoles.Name = "btnSaveRoles";
        btnSaveRoles.Size = new System.Drawing.Size(164, 34);
        btnSaveRoles.TabIndex = 3;
        btnSaveRoles.Text = "💾 Lưu phân quyền";
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
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvPermissions.DefaultCellStyle = dataGridViewCellStyle6;
        dgvPermissions.EnableHeadersVisualStyles = false;
        dgvPermissions.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvPermissions.Location = new System.Drawing.Point(16, 50);
        dgvPermissions.MultiSelect = false;
        dgvPermissions.Name = "dgvPermissions";
        dgvPermissions.ReadOnly = true;
        dgvPermissions.RowHeadersVisible = false;
        dgvPermissions.RowHeadersWidth = 51;
        dgvPermissions.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dgvPermissions.Size = new System.Drawing.Size(1128, 592);
        dgvPermissions.TabIndex = 2;
        // 
        // lblMatrixTitle
        // 
        lblMatrixTitle.AutoSize = true;
        lblMatrixTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblMatrixTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblMatrixTitle.Location = new System.Drawing.Point(16, 14);
        lblMatrixTitle.Name = "lblMatrixTitle";
        lblMatrixTitle.Size = new System.Drawing.Size(157, 28);
        lblMatrixTitle.TabIndex = 0;
        lblMatrixTitle.Text = "Quyền truy cập";
        // 
        // tabProfile
        // 
        tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabProfile.Controls.Add(tabProfileSub);
        tabProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabProfile.Location = new System.Drawing.Point(4, 40);
        tabProfile.Name = "tabProfile";
        tabProfile.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
        tabProfile.Size = new System.Drawing.Size(1192, 696);
        tabProfile.TabIndex = 2;
        tabProfile.Text = "3. Tài khoản cá nhân";
        // 
        // tabProfileSub
        // 
        tabProfileSub.Controls.Add(tabSubProfileInfo);
        tabProfileSub.Controls.Add(tabSubChangePassword);
        tabProfileSub.Dock = System.Windows.Forms.DockStyle.Fill;
        tabProfileSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        tabProfileSub.ItemSize = new System.Drawing.Size(160, 32);
        tabProfileSub.Location = new System.Drawing.Point(16, 12);
        tabProfileSub.Name = "tabProfileSub";
        tabProfileSub.SelectedIndex = 0;
        tabProfileSub.Size = new System.Drawing.Size(1160, 668);
        tabProfileSub.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabProfileSub.TabIndex = 0;
        // 
        // tabSubProfileInfo
        // 
        tabSubProfileInfo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabSubProfileInfo.Controls.Add(cardProfileSummary);
        tabSubProfileInfo.Controls.Add(cardProfile);
        tabSubProfileInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabSubProfileInfo.Location = new System.Drawing.Point(4, 36);
        tabSubProfileInfo.Name = "tabSubProfileInfo";
        tabSubProfileInfo.Padding = new System.Windows.Forms.Padding(16);
        tabSubProfileInfo.Size = new System.Drawing.Size(1152, 628);
        tabSubProfileInfo.TabIndex = 0;
        tabSubProfileInfo.Text = "Hồ sơ cá nhân";
        // 
        // cardProfileSummary
        // 
        cardProfileSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        cardProfileSummary.BackColor = System.Drawing.Color.White;
        cardProfileSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardProfileSummary.BorderWidth = 1;
        cardProfileSummary.Controls.Add(lblSummaryBranch);
        cardProfileSummary.Controls.Add(lblSummaryPerm);
        cardProfileSummary.Controls.Add(lblSummaryLastLogin);
        cardProfileSummary.Controls.Add(lblSummaryCreated);
        cardProfileSummary.Controls.Add(lblSummaryPhone);
        cardProfileSummary.Controls.Add(lblSummaryEmail);
        cardProfileSummary.Controls.Add(pnlSummaryDivider);
        cardProfileSummary.Controls.Add(lblSummaryUsername);
        cardProfileSummary.Controls.Add(lblSummaryRoleBadge);
        cardProfileSummary.Controls.Add(lblSummaryName);
        cardProfileSummary.Controls.Add(lblAvatar);
        cardProfileSummary.CornerRadius = 6;
        cardProfileSummary.Location = new System.Drawing.Point(16, 16);
        cardProfileSummary.Name = "cardProfileSummary";
        cardProfileSummary.Padding = new System.Windows.Forms.Padding(20);
        cardProfileSummary.Size = new System.Drawing.Size(320, 590);
        cardProfileSummary.TabIndex = 1;
        // 
        // lblSummaryBranch
        // 
        lblSummaryBranch.AutoSize = true;
        lblSummaryBranch.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryBranch.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryBranch.Location = new System.Drawing.Point(20, 380);
        lblSummaryBranch.Name = "lblSummaryBranch";
        lblSummaryBranch.Size = new System.Drawing.Size(193, 20);
        lblSummaryBranch.TabIndex = 10;
        lblSummaryBranch.Text = "🏢 Chi nhánh: Quận 1, HCM";
        // 
        // lblSummaryPerm
        // 
        lblSummaryPerm.AutoSize = true;
        lblSummaryPerm.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryPerm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryPerm.Location = new System.Drawing.Point(20, 345);
        lblSummaryPerm.Name = "lblSummaryPerm";
        lblSummaryPerm.Size = new System.Drawing.Size(214, 20);
        lblSummaryPerm.TabIndex = 9;
        lblSummaryPerm.Text = "🛡️ Quyền: Quản trị toàn quyền";
        // 
        // lblSummaryLastLogin
        // 
        lblSummaryLastLogin.AutoSize = true;
        lblSummaryLastLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryLastLogin.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryLastLogin.Location = new System.Drawing.Point(20, 310);
        lblSummaryLastLogin.Name = "lblSummaryLastLogin";
        lblSummaryLastLogin.Size = new System.Drawing.Size(229, 20);
        lblSummaryLastLogin.TabIndex = 8;
        lblSummaryLastLogin.Text = "🕒 Đăng nhập: 16/11/2026 08:30";
        // 
        // lblSummaryCreated
        // 
        lblSummaryCreated.AutoSize = true;
        lblSummaryCreated.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryCreated.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryCreated.Location = new System.Drawing.Point(20, 275);
        lblSummaryCreated.Name = "lblSummaryCreated";
        lblSummaryCreated.Size = new System.Drawing.Size(178, 20);
        lblSummaryCreated.TabIndex = 7;
        lblSummaryCreated.Text = "📅 Ngày tạo: 01/01/2024";
        // 
        // lblSummaryPhone
        // 
        lblSummaryPhone.AutoSize = true;
        lblSummaryPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryPhone.Location = new System.Drawing.Point(20, 240);
        lblSummaryPhone.Name = "lblSummaryPhone";
        lblSummaryPhone.Size = new System.Drawing.Size(156, 20);
        lblSummaryPhone.TabIndex = 6;
        lblSummaryPhone.Text = "📞 SĐT: 0912 345 678";
        // 
        // lblSummaryEmail
        // 
        lblSummaryEmail.AutoSize = true;
        lblSummaryEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryEmail.Location = new System.Drawing.Point(20, 205);
        lblSummaryEmail.Name = "lblSummaryEmail";
        lblSummaryEmail.Size = new System.Drawing.Size(238, 20);
        lblSummaryEmail.TabIndex = 5;
        lblSummaryEmail.Text = "✉️ Email: minhquan@ecms.edu.vn";
        // 
        // pnlSummaryDivider
        // 
        pnlSummaryDivider.BackColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlSummaryDivider.Location = new System.Drawing.Point(20, 185);
        pnlSummaryDivider.Name = "pnlSummaryDivider";
        pnlSummaryDivider.Size = new System.Drawing.Size(280, 1);
        pnlSummaryDivider.TabIndex = 4;
        // 
        // lblSummaryUsername
        // 
        lblSummaryUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSummaryUsername.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSummaryUsername.Location = new System.Drawing.Point(10, 150);
        lblSummaryUsername.Name = "lblSummaryUsername";
        lblSummaryUsername.Size = new System.Drawing.Size(300, 22);
        lblSummaryUsername.TabIndex = 3;
        lblSummaryUsername.Text = "@minhquan.admin";
        lblSummaryUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblSummaryRoleBadge
        // 
        lblSummaryRoleBadge.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        lblSummaryRoleBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblSummaryRoleBadge.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSummaryRoleBadge.Location = new System.Drawing.Point(75, 120);
        lblSummaryRoleBadge.Name = "lblSummaryRoleBadge";
        lblSummaryRoleBadge.Size = new System.Drawing.Size(170, 24);
        lblSummaryRoleBadge.TabIndex = 2;
        lblSummaryRoleBadge.Text = "ADMINISTRATOR";
        lblSummaryRoleBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblSummaryName
        // 
        lblSummaryName.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblSummaryName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSummaryName.Location = new System.Drawing.Point(10, 88);
        lblSummaryName.Name = "lblSummaryName";
        lblSummaryName.Size = new System.Drawing.Size(300, 28);
        lblSummaryName.TabIndex = 1;
        lblSummaryName.Text = "Trần Minh Quân";
        lblSummaryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblAvatar
        // 
        lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblAvatar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblAvatar.ForeColor = System.Drawing.Color.White;
        lblAvatar.Location = new System.Drawing.Point(125, 16);
        lblAvatar.Name = "lblAvatar";
        lblAvatar.Size = new System.Drawing.Size(68, 68);
        lblAvatar.TabIndex = 0;
        lblAvatar.Text = "TMQ";
        lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cardProfile
        // 
        cardProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardProfile.BackColor = System.Drawing.Color.White;
        cardProfile.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardProfile.BorderWidth = 1;
        cardProfile.Controls.Add(lblProfSub);
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
        cardProfile.Location = new System.Drawing.Point(352, 16);
        cardProfile.Name = "cardProfile";
        cardProfile.Padding = new System.Windows.Forms.Padding(20);
        cardProfile.Size = new System.Drawing.Size(780, 590);
        cardProfile.TabIndex = 0;
        // 
        // lblProfSub
        // 
        lblProfSub.AutoSize = true;
        lblProfSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblProfSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblProfSub.Location = new System.Drawing.Point(20, 48);
        lblProfSub.Name = "lblProfSub";
        lblProfSub.Size = new System.Drawing.Size(462, 20);
        lblProfSub.TabIndex = 13;
        lblProfSub.Text = "Cập nhật thông tin hiển thị và kênh liên lạc trong hệ thống trung tâm";
        // 
        // btnSaveProf
        // 
        btnSaveProf.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveProf.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveProf.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveProf.CornerRadius = 5;
        btnSaveProf.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveProf.FlatAppearance.BorderSize = 0;
        btnSaveProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveProf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveProf.ForeColor = System.Drawing.Color.White;
        btnSaveProf.Location = new System.Drawing.Point(598, 529);
        btnSaveProf.Name = "btnSaveProf";
        btnSaveProf.Size = new System.Drawing.Size(160, 38);
        btnSaveProf.TabIndex = 12;
        btnSaveProf.Text = "Lưu hồ sơ";
        btnSaveProf.UseVisualStyleBackColor = false;
        btnSaveProf.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelProf
        // 
        btnCancelProf.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancelProf.BackColor = System.Drawing.Color.White;
        btnCancelProf.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelProf.CornerRadius = 5;
        btnCancelProf.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelProf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelProf.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelProf.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelProf.Location = new System.Drawing.Point(432, 529);
        btnCancelProf.Name = "btnCancelProf";
        btnCancelProf.Size = new System.Drawing.Size(150, 38);
        btnCancelProf.TabIndex = 11;
        btnCancelProf.Text = "Khôi phục ban đầu";
        btnCancelProf.UseVisualStyleBackColor = false;
        btnCancelProf.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtUserRole
        // 
        txtUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtUserRole.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        txtUserRole.CornerRadius = 5;
        txtUserRole.ErrorMessage = "";
        txtUserRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtUserRole.HasError = false;
        txtUserRole.Location = new System.Drawing.Point(20, 297);
        txtUserRole.Name = "txtUserRole";
        txtUserRole.Placeholder = "";
        txtUserRole.ReadOnly = true;
        txtUserRole.Size = new System.Drawing.Size(738, 36);
        txtUserRole.TabIndex = 10;
        txtUserRole.UseSystemPasswordChar = false;
        // 
        // lblRole
        // 
        lblRole.AutoSize = true;
        lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRole.Location = new System.Drawing.Point(20, 274);
        lblRole.Name = "lblRole";
        lblRole.Size = new System.Drawing.Size(55, 20);
        lblRole.TabIndex = 9;
        lblRole.Text = "Vai trò";
        // 
        // txtJobTitle
        // 
        txtJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtJobTitle.BackColor = System.Drawing.Color.Transparent;
        txtJobTitle.CornerRadius = 5;
        txtJobTitle.ErrorMessage = "";
        txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtJobTitle.HasError = false;
        txtJobTitle.Location = new System.Drawing.Point(400, 207);
        txtJobTitle.Name = "txtJobTitle";
        txtJobTitle.Placeholder = "Nhập chức vụ / chức danh";
        txtJobTitle.ReadOnly = false;
        txtJobTitle.Size = new System.Drawing.Size(358, 36);
        txtJobTitle.TabIndex = 8;
        txtJobTitle.UseSystemPasswordChar = false;
        // 
        // lblJob
        // 
        lblJob.AutoSize = true;
        lblJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblJob.Location = new System.Drawing.Point(400, 184);
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
        txtEmail.Location = new System.Drawing.Point(20, 207);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "name@ecms.edu.vn";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(360, 36);
        txtEmail.TabIndex = 6;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblEmail.Location = new System.Drawing.Point(20, 184);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(97, 20);
        lblEmail.TabIndex = 5;
        lblEmail.Text = "Email liên hệ";
        // 
        // txtPhone
        // 
        txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtPhone.BackColor = System.Drawing.Color.Transparent;
        txtPhone.CornerRadius = 5;
        txtPhone.ErrorMessage = "";
        txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtPhone.HasError = false;
        txtPhone.Location = new System.Drawing.Point(400, 120);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "09xx xxx xxx";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(358, 36);
        txtPhone.TabIndex = 4;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblPhone.Location = new System.Drawing.Point(400, 97);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(111, 20);
        lblPhone.TabIndex = 3;
        lblPhone.Text = "Số điện thoại *";
        // 
        // txtFullName
        // 
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(20, 120);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Họ và tên của bạn";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(360, 36);
        txtFullName.TabIndex = 2;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblName.Location = new System.Drawing.Point(20, 97);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(87, 20);
        lblName.TabIndex = 1;
        lblName.Text = "Họ và tên *";
        // 
        // lblProfTitle
        // 
        lblProfTitle.AutoSize = true;
        lblProfTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblProfTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblProfTitle.Location = new System.Drawing.Point(20, 16);
        lblProfTitle.Name = "lblProfTitle";
        lblProfTitle.Size = new System.Drawing.Size(209, 30);
        lblProfTitle.TabIndex = 0;
        lblProfTitle.Text = "Thông tin tài khoản";
        // 
        // tabSubChangePassword
        // 
        tabSubChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        tabSubChangePassword.Controls.Add(cardPass);
        tabSubChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabSubChangePassword.Location = new System.Drawing.Point(4, 36);
        tabSubChangePassword.Name = "tabSubChangePassword";
        tabSubChangePassword.Padding = new System.Windows.Forms.Padding(16);
        tabSubChangePassword.Size = new System.Drawing.Size(1152, 628);
        tabSubChangePassword.TabIndex = 1;
        tabSubChangePassword.Text = "Đổi mật khẩu";
        // 
        // cardPass
        // 
        cardPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardPass.BackColor = System.Drawing.Color.White;
        cardPass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPass.BorderWidth = 1;
        cardPass.Controls.Add(chkShowPassword);
        cardPass.Controls.Add(lblPassSub);
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
        cardPass.Location = new System.Drawing.Point(16, 16);
        cardPass.Name = "cardPass";
        cardPass.Padding = new System.Windows.Forms.Padding(20);
        cardPass.Size = new System.Drawing.Size(613, 480);
        cardPass.TabIndex = 2;
        // 
        // chkShowPassword
        // 
        chkShowPassword.AutoSize = true;
        chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
        chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        chkShowPassword.Location = new System.Drawing.Point(17, 317);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new System.Drawing.Size(148, 24);
        chkShowPassword.TabIndex = 11;
        chkShowPassword.Text = "Hiển thị mật khẩu";
        chkShowPassword.UseVisualStyleBackColor = true;
        // 
        // lblPassSub
        // 
        lblPassSub.AutoSize = true;
        lblPassSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPassSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPassSub.Location = new System.Drawing.Point(20, 48);
        lblPassSub.Name = "lblPassSub";
        lblPassSub.Size = new System.Drawing.Size(524, 20);
        lblPassSub.TabIndex = 10;
        lblPassSub.Text = "Để bảo mật, vui lòng chọn mật khẩu mạnh có ít nhất 8 ký tự gồm cả chữ và số";
        // 
        // lblPassNote
        // 
        lblPassNote.AutoSize = true;
        lblPassNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPassNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPassNote.Location = new System.Drawing.Point(17, 352);
        lblPassNote.Name = "lblPassNote";
        lblPassNote.Size = new System.Drawing.Size(485, 20);
        lblPassNote.TabIndex = 9;
        lblPassNote.Text = "Lưu ý: Mật khẩu mới không được trùng với mật khẩu hiện tại đang dùng.";
        // 
        // btnSavePass
        // 
        btnSavePass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSavePass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSavePass.CornerRadius = 5;
        btnSavePass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSavePass.FlatAppearance.BorderSize = 0;
        btnSavePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSavePass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSavePass.ForeColor = System.Drawing.Color.White;
        btnSavePass.Location = new System.Drawing.Point(411, 415);
        btnSavePass.Name = "btnSavePass";
        btnSavePass.Size = new System.Drawing.Size(182, 38);
        btnSavePass.TabIndex = 8;
        btnSavePass.Text = "Đổi mật khẩu";
        btnSavePass.UseVisualStyleBackColor = false;
        btnSavePass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelPass
        // 
        btnCancelPass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancelPass.BackColor = System.Drawing.Color.White;
        btnCancelPass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelPass.CornerRadius = 5;
        btnCancelPass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelPass.Location = new System.Drawing.Point(301, 415);
        btnCancelPass.Name = "btnCancelPass";
        btnCancelPass.Size = new System.Drawing.Size(100, 38);
        btnCancelPass.TabIndex = 7;
        btnCancelPass.Text = "Hủy";
        btnCancelPass.UseVisualStyleBackColor = false;
        btnCancelPass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtConfirmPass
        // 
        txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
        txtConfirmPass.CornerRadius = 5;
        txtConfirmPass.ErrorMessage = "";
        txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtConfirmPass.HasError = false;
        txtConfirmPass.Location = new System.Drawing.Point(17, 267);
        txtConfirmPass.Name = "txtConfirmPass";
        txtConfirmPass.Placeholder = "Nhập lại mật khẩu mới để xác nhận";
        txtConfirmPass.ReadOnly = false;
        txtConfirmPass.Size = new System.Drawing.Size(573, 36);
        txtConfirmPass.TabIndex = 6;
        txtConfirmPass.UseSystemPasswordChar = true;
        // 
        // lblConfirmPass
        // 
        lblConfirmPass.AutoSize = true;
        lblConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblConfirmPass.Location = new System.Drawing.Point(17, 244);
        lblConfirmPass.Name = "lblConfirmPass";
        lblConfirmPass.Size = new System.Drawing.Size(179, 20);
        lblConfirmPass.TabIndex = 5;
        lblConfirmPass.Text = "Nhập lại mật khẩu mới *";
        // 
        // txtNewPass
        // 
        txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtNewPass.BackColor = System.Drawing.Color.Transparent;
        txtNewPass.CornerRadius = 5;
        txtNewPass.ErrorMessage = "";
        txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNewPass.HasError = false;
        txtNewPass.Location = new System.Drawing.Point(17, 192);
        txtNewPass.Name = "txtNewPass";
        txtNewPass.Placeholder = "Tối thiểu 8 ký tự (bao gồm chữ và số)";
        txtNewPass.ReadOnly = false;
        txtNewPass.Size = new System.Drawing.Size(573, 36);
        txtNewPass.TabIndex = 4;
        txtNewPass.UseSystemPasswordChar = true;
        // 
        // lblNewPass
        // 
        lblNewPass.AutoSize = true;
        lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblNewPass.Location = new System.Drawing.Point(17, 169);
        lblNewPass.Name = "lblNewPass";
        lblNewPass.Size = new System.Drawing.Size(117, 20);
        lblNewPass.TabIndex = 3;
        lblNewPass.Text = "Mật khẩu mới *";
        // 
        // txtCurrentPass
        // 
        txtCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtCurrentPass.BackColor = System.Drawing.Color.Transparent;
        txtCurrentPass.CornerRadius = 5;
        txtCurrentPass.ErrorMessage = "";
        txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtCurrentPass.HasError = false;
        txtCurrentPass.Location = new System.Drawing.Point(17, 117);
        txtCurrentPass.Name = "txtCurrentPass";
        txtCurrentPass.Placeholder = "Nhập mật khẩu hiện tại của bạn";
        txtCurrentPass.ReadOnly = false;
        txtCurrentPass.Size = new System.Drawing.Size(573, 36);
        txtCurrentPass.TabIndex = 2;
        txtCurrentPass.UseSystemPasswordChar = true;
        // 
        // lblCurPass
        // 
        lblCurPass.AutoSize = true;
        lblCurPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCurPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCurPass.Location = new System.Drawing.Point(17, 94);
        lblCurPass.Name = "lblCurPass";
        lblCurPass.Size = new System.Drawing.Size(142, 20);
        lblCurPass.TabIndex = 1;
        lblCurPass.Text = "Mật khẩu hiện tại *";
        // 
        // lblPassTitle
        // 
        lblPassTitle.AutoSize = true;
        lblPassTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
        lblPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblPassTitle.Location = new System.Drawing.Point(20, 16);
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
        pnlAccountsContainer.ResumeLayout(false);
        cardTable.ResumeLayout(false);
        cardTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
        pnlToolbarAccounts.ResumeLayout(false);
        pnlAccountsFooter.ResumeLayout(false);
        pnlAccountsFooter.PerformLayout();
        tabRoles.ResumeLayout(false);
        cardMatrix.ResumeLayout(false);
        cardMatrix.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPermissions).EndInit();
        tabProfile.ResumeLayout(false);
        tabProfileSub.ResumeLayout(false);
        tabSubProfileInfo.ResumeLayout(false);
        cardProfileSummary.ResumeLayout(false);
        cardProfileSummary.PerformLayout();
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
    private System.Windows.Forms.Panel pnlAccountsContainer;
    private System.Windows.Forms.Panel pnlToolbarAccounts;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private ECMS.UI.Controls.AppComboBox cboRoleFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppButton btnExportAccounts;
    private ECMS.UI.Controls.AppButton btnAddAccount;
    private ECMS.UI.Controls.AppCard cardTable;
    private System.Windows.Forms.Label lblListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvAccounts;
    private System.Windows.Forms.Panel pnlAccountsFooter;
    private System.Windows.Forms.Label lblStatTotal;
    private System.Windows.Forms.Label lblStatActive;
    private System.Windows.Forms.Label lblStatLocked;
    private System.Windows.Forms.Label lblStatAdmin;

    // Tab 2 controls
    private ECMS.UI.Controls.AppCard cardMatrix;
    private System.Windows.Forms.Label lblMatrixTitle;
    private ECMS.UI.Controls.AppDataGrid dgvPermissions;
    private ECMS.UI.Controls.AppButton btnResetMatrix;
    private ECMS.UI.Controls.AppButton btnSaveRoles;

    // Tab 3 controls (Tài khoản cá nhân)
    private System.Windows.Forms.TabControl tabProfileSub;
    private System.Windows.Forms.TabPage tabSubProfileInfo;
    private System.Windows.Forms.TabPage tabSubChangePassword;

    // Sub-tab 1: Hồ sơ cá nhân
    private ECMS.UI.Controls.AppCard cardProfileSummary;
    private System.Windows.Forms.Label lblAvatar;
    private System.Windows.Forms.Label lblSummaryName;
    private System.Windows.Forms.Label lblSummaryRoleBadge;
    private System.Windows.Forms.Label lblSummaryUsername;
    private System.Windows.Forms.Panel pnlSummaryDivider;
    private System.Windows.Forms.Label lblSummaryEmail;
    private System.Windows.Forms.Label lblSummaryPhone;
    private System.Windows.Forms.Label lblSummaryCreated;
    private System.Windows.Forms.Label lblSummaryLastLogin;
    private System.Windows.Forms.Label lblSummaryPerm;
    private System.Windows.Forms.Label lblSummaryBranch;

    private ECMS.UI.Controls.AppCard cardProfile;
    private System.Windows.Forms.Label lblProfTitle;
    private System.Windows.Forms.Label lblProfSub;
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

    // Sub-tab 2: Đổi mật khẩu
    private ECMS.UI.Controls.AppCard cardPass;
    private System.Windows.Forms.Label lblPassTitle;
    private System.Windows.Forms.Label lblPassSub;
    private System.Windows.Forms.Label lblCurPass;
    private ECMS.UI.Controls.AppTextBox txtCurrentPass;
    private System.Windows.Forms.Label lblNewPass;
    private ECMS.UI.Controls.AppTextBox txtNewPass;
    private System.Windows.Forms.Label lblConfirmPass;
    private ECMS.UI.Controls.AppTextBox txtConfirmPass;
    private System.Windows.Forms.CheckBox chkShowPassword;
    private System.Windows.Forms.Label lblPassNote;
    private ECMS.UI.Controls.AppButton btnCancelPass;
    private ECMS.UI.Controls.AppButton btnSavePass;
}