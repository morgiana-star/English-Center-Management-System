namespace ECMS.UI.UserControls;

partial class StaffManagementView
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
        btnCreateStaff = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStaffForm = new ECMS.UI.Controls.AppCard();
        btnSaveStaff = new ECMS.UI.Controls.AppButton();
        btnCancelStaff = new ECMS.UI.Controls.AppButton();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        cboDepartment = new ECMS.UI.Controls.AppComboBox();
        lblDepartment = new System.Windows.Forms.Label();
        dtpHireDate = new System.Windows.Forms.DateTimePicker();
        lblHireDate = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        txtStaffCode = new ECMS.UI.Controls.AppTextBox();
        lblStaffCode = new System.Windows.Forms.Label();
        lblStaffFormTitle = new System.Windows.Forms.Label();
        cardStaffDetail = new ECMS.UI.Controls.AppCard();
        btnOpenLinkedAccount = new ECMS.UI.Controls.AppButton();
        lblPermissionVal = new System.Windows.Forms.Label();
        lblPermissionKey = new System.Windows.Forms.Label();
        lblAssignmentVal = new System.Windows.Forms.Label();
        lblAssignmentKey = new System.Windows.Forms.Label();
        lblLinkedAccountVal = new System.Windows.Forms.Label();
        lblLinkedAccountKey = new System.Windows.Forms.Label();
        lblHireStatusVal = new System.Windows.Forms.Label();
        lblHireStatusKey = new System.Windows.Forms.Label();
        lblContactVal = new System.Windows.Forms.Label();
        lblContactKey = new System.Windows.Forms.Label();
        lblStaffDetailTitle = new System.Windows.Forms.Label();
        cardStaffList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvStaff = new ECMS.UI.Controls.AppDataGrid();
        cboDepartmentFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchStaff = new ECMS.UI.Controls.AppTextBox();
        lblStaffListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStaffForm.SuspendLayout();
        cardStaffDetail.SuspendLayout();
        cardStaffList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateStaff);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateStaff
        // 
        btnCreateStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateStaff.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnCreateStaff.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateStaff.CornerRadius = 5;
        btnCreateStaff.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateStaff.FlatAppearance.BorderSize = 0;
        btnCreateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnCreateStaff.ForeColor = System.Drawing.Color.White;
        btnCreateStaff.Location = new System.Drawing.Point(1006, 20);
        btnCreateStaff.Name = "btnCreateStaff";
        btnCreateStaff.Size = new System.Drawing.Size(130, 36);
        btnCreateStaff.TabIndex = 3;
        btnCreateStaff.Text = "Thêm nhân viên";
        btnCreateStaff.UseVisualStyleBackColor = false;
        btnCreateStaff.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(130, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Nhân viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardStaffForm);
        pnlBody.Controls.Add(cardStaffDetail);
        pnlBody.Controls.Add(cardStaffList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardStaffForm
        // 
        cardStaffForm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardStaffForm.BackColor = System.Drawing.Color.White;
        cardStaffForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStaffForm.BorderWidth = 1;
        cardStaffForm.Controls.Add(btnSaveStaff);
        cardStaffForm.Controls.Add(btnCancelStaff);
        cardStaffForm.Controls.Add(txtEmail);
        cardStaffForm.Controls.Add(lblEmail);
        cardStaffForm.Controls.Add(cboStatus);
        cardStaffForm.Controls.Add(lblStatus);
        cardStaffForm.Controls.Add(cboDepartment);
        cardStaffForm.Controls.Add(lblDepartment);
        cardStaffForm.Controls.Add(dtpHireDate);
        cardStaffForm.Controls.Add(lblHireDate);
        cardStaffForm.Controls.Add(txtPhone);
        cardStaffForm.Controls.Add(lblPhone);
        cardStaffForm.Controls.Add(txtFullName);
        cardStaffForm.Controls.Add(lblFullName);
        cardStaffForm.Controls.Add(txtStaffCode);
        cardStaffForm.Controls.Add(lblStaffCode);
        cardStaffForm.Controls.Add(lblStaffFormTitle);
        cardStaffForm.CornerRadius = 6;
        cardStaffForm.Location = new System.Drawing.Point(680, 20);
        cardStaffForm.Name = "cardStaffForm";
        cardStaffForm.Padding = new System.Windows.Forms.Padding(20);
        cardStaffForm.Size = new System.Drawing.Size(456, 490);
        cardStaffForm.TabIndex = 2;
        // 
        // btnSaveStaff
        // 
        btnSaveStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveStaff.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveStaff.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveStaff.CornerRadius = 5;
        btnSaveStaff.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveStaff.FlatAppearance.BorderSize = 0;
        btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveStaff.ForeColor = System.Drawing.Color.White;
        btnSaveStaff.Location = new System.Drawing.Point(346, 440);
        btnSaveStaff.Name = "btnSaveStaff";
        btnSaveStaff.Size = new System.Drawing.Size(90, 32);
        btnSaveStaff.TabIndex = 16;
        btnSaveStaff.Text = "Lưu";
        btnSaveStaff.UseVisualStyleBackColor = false;
        btnSaveStaff.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelStaff
        // 
        btnCancelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelStaff.BackColor = System.Drawing.Color.White;
        btnCancelStaff.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelStaff.CornerRadius = 5;
        btnCancelStaff.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelStaff.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelStaff.Location = new System.Drawing.Point(256, 440);
        btnCancelStaff.Name = "btnCancelStaff";
        btnCancelStaff.Size = new System.Drawing.Size(80, 32);
        btnCancelStaff.TabIndex = 15;
        btnCancelStaff.Text = "Hủy";
        btnCancelStaff.UseVisualStyleBackColor = false;
        btnCancelStaff.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtEmail
        // 
        txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtEmail.BackColor = System.Drawing.Color.Transparent;
        txtEmail.CornerRadius = 5;
        txtEmail.ErrorMessage = "";
        txtEmail.HasError = false;
        txtEmail.Location = new System.Drawing.Point(20, 260);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "mai@minhtri.local";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(416, 32);
        txtEmail.TabIndex = 14;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblEmail.Location = new System.Drawing.Point(20, 240);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(94, 20);
        lblEmail.TabIndex = 13;
        lblEmail.Text = "Email liên hệ";
        // 
        // cboStatus
        // 
        cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatus.BackColor = System.Drawing.Color.Transparent;
        cboStatus.CornerRadius = 5;
        cboStatus.DataSource = null;
        cboStatus.DisplayMember = "";
        cboStatus.Location = new System.Drawing.Point(236, 195);
        cboStatus.Name = "cboStatus";
        cboStatus.SelectedIndex = -1;
        cboStatus.SelectedItem = null;
        cboStatus.SelectedValue = null;
        cboStatus.Size = new System.Drawing.Size(200, 32);
        cboStatus.TabIndex = 12;
        cboStatus.ValueMember = "";
        // 
        // lblStatus
        // 
        lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStatus.Location = new System.Drawing.Point(236, 175);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(91, 20);
        lblStatus.TabIndex = 11;
        lblStatus.Text = "Trạng thái *";
        // 
        // cboDepartment
        // 
        cboDepartment.BackColor = System.Drawing.Color.Transparent;
        cboDepartment.CornerRadius = 5;
        cboDepartment.DataSource = null;
        cboDepartment.DisplayMember = "";
        cboDepartment.Location = new System.Drawing.Point(20, 195);
        cboDepartment.Name = "cboDepartment";
        cboDepartment.SelectedIndex = -1;
        cboDepartment.SelectedItem = null;
        cboDepartment.SelectedValue = null;
        cboDepartment.Size = new System.Drawing.Size(200, 32);
        cboDepartment.TabIndex = 10;
        cboDepartment.ValueMember = "";
        // 
        // lblDepartment
        // 
        lblDepartment.AutoSize = true;
        lblDepartment.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblDepartment.Location = new System.Drawing.Point(20, 175);
        lblDepartment.Name = "lblDepartment";
        lblDepartment.Size = new System.Drawing.Size(78, 20);
        lblDepartment.TabIndex = 9;
        lblDepartment.Text = "Bộ phận *";
        // 
        // dtpHireDate
        // 
        dtpHireDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        dtpHireDate.CustomFormat = "dd/MM/yyyy";
        dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpHireDate.Location = new System.Drawing.Point(236, 133);
        dtpHireDate.Name = "dtpHireDate";
        dtpHireDate.Size = new System.Drawing.Size(200, 27);
        dtpHireDate.TabIndex = 8;
        // 
        // lblHireDate
        // 
        lblHireDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblHireDate.AutoSize = true;
        lblHireDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblHireDate.Location = new System.Drawing.Point(236, 113);
        lblHireDate.Name = "lblHireDate";
        lblHireDate.Size = new System.Drawing.Size(116, 20);
        lblHireDate.TabIndex = 7;
        lblHireDate.Text = "Ngày vào làm *";
        // 
        // txtPhone
        // 
        txtPhone.BackColor = System.Drawing.Color.Transparent;
        txtPhone.CornerRadius = 5;
        txtPhone.ErrorMessage = "";
        txtPhone.HasError = false;
        txtPhone.Location = new System.Drawing.Point(20, 130);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "0902 552 778";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(200, 32);
        txtPhone.TabIndex = 6;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblPhone.Location = new System.Drawing.Point(20, 110);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(92, 20);
        lblPhone.TabIndex = 5;
        lblPhone.Text = "Điện thoại *";
        // 
        // txtFullName
        // 
        txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(236, 68);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Phạm Ngọc Mai";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(200, 32);
        txtFullName.TabIndex = 4;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblFullName
        // 
        lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblFullName.Location = new System.Drawing.Point(236, 48);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(87, 20);
        lblFullName.TabIndex = 3;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtStaffCode
        // 
        txtStaffCode.BackColor = System.Drawing.Color.Transparent;
        txtStaffCode.CornerRadius = 5;
        txtStaffCode.ErrorMessage = "";
        txtStaffCode.HasError = false;
        txtStaffCode.Location = new System.Drawing.Point(20, 68);
        txtStaffCode.Name = "txtStaffCode";
        txtStaffCode.Placeholder = "NV-002";
        txtStaffCode.ReadOnly = false;
        txtStaffCode.Size = new System.Drawing.Size(200, 32);
        txtStaffCode.TabIndex = 2;
        txtStaffCode.UseSystemPasswordChar = false;
        // 
        // lblStaffCode
        // 
        lblStaffCode.AutoSize = true;
        lblStaffCode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblStaffCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStaffCode.Location = new System.Drawing.Point(20, 48);
        lblStaffCode.Name = "lblStaffCode";
        lblStaffCode.Size = new System.Drawing.Size(114, 20);
        lblStaffCode.TabIndex = 1;
        lblStaffCode.Text = "Mã nhân viên *";
        // 
        // lblStaffFormTitle
        // 
        lblStaffFormTitle.AutoSize = true;
        lblStaffFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblStaffFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblStaffFormTitle.Location = new System.Drawing.Point(20, 16);
        lblStaffFormTitle.Name = "lblStaffFormTitle";
        lblStaffFormTitle.Size = new System.Drawing.Size(202, 25);
        lblStaffFormTitle.TabIndex = 0;
        lblStaffFormTitle.Text = "Thêm / sửa nhân viên";
        // 
        // cardStaffDetail
        // 
        cardStaffDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardStaffDetail.BackColor = System.Drawing.Color.White;
        cardStaffDetail.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStaffDetail.BorderWidth = 1;
        cardStaffDetail.Controls.Add(btnOpenLinkedAccount);
        cardStaffDetail.Controls.Add(lblPermissionVal);
        cardStaffDetail.Controls.Add(lblPermissionKey);
        cardStaffDetail.Controls.Add(lblAssignmentVal);
        cardStaffDetail.Controls.Add(lblAssignmentKey);
        cardStaffDetail.Controls.Add(lblLinkedAccountVal);
        cardStaffDetail.Controls.Add(lblLinkedAccountKey);
        cardStaffDetail.Controls.Add(lblHireStatusVal);
        cardStaffDetail.Controls.Add(lblHireStatusKey);
        cardStaffDetail.Controls.Add(lblContactVal);
        cardStaffDetail.Controls.Add(lblContactKey);
        cardStaffDetail.Controls.Add(lblStaffDetailTitle);
        cardStaffDetail.CornerRadius = 6;
        cardStaffDetail.Location = new System.Drawing.Point(24, 380);
        cardStaffDetail.Name = "cardStaffDetail";
        cardStaffDetail.Padding = new System.Windows.Forms.Padding(20);
        cardStaffDetail.Size = new System.Drawing.Size(636, 175);
        cardStaffDetail.TabIndex = 1;
        // 
        // btnOpenLinkedAccount
        // 
        btnOpenLinkedAccount.BackColor = System.Drawing.Color.White;
        btnOpenLinkedAccount.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenLinkedAccount.CornerRadius = 5;
        btnOpenLinkedAccount.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenLinkedAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnOpenLinkedAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenLinkedAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnOpenLinkedAccount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnOpenLinkedAccount.Location = new System.Drawing.Point(20, 130);
        btnOpenLinkedAccount.Name = "btnOpenLinkedAccount";
        btnOpenLinkedAccount.Size = new System.Drawing.Size(160, 30);
        btnOpenLinkedAccount.TabIndex = 11;
        btnOpenLinkedAccount.Text = "Mở tài khoản liên kết";
        btnOpenLinkedAccount.UseVisualStyleBackColor = false;
        btnOpenLinkedAccount.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblPermissionVal
        // 
        lblPermissionVal.AutoSize = true;
        lblPermissionVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblPermissionVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblPermissionVal.Location = new System.Drawing.Point(140, 105);
        lblPermissionVal.Name = "lblPermissionVal";
        lblPermissionVal.Size = new System.Drawing.Size(212, 20);
        lblPermissionVal.TabIndex = 10;
        lblPermissionVal.Text = "Không được cấu hình hệ thống";
        // 
        // lblPermissionKey
        // 
        lblPermissionKey.AutoSize = true;
        lblPermissionKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblPermissionKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPermissionKey.Location = new System.Drawing.Point(20, 105);
        lblPermissionKey.Name = "lblPermissionKey";
        lblPermissionKey.Size = new System.Drawing.Size(51, 20);
        lblPermissionKey.TabIndex = 9;
        lblPermissionKey.Text = "Quyền";
        // 
        // lblAssignmentVal
        // 
        lblAssignmentVal.AutoSize = true;
        lblAssignmentVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblAssignmentVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAssignmentVal.Location = new System.Drawing.Point(140, 85);
        lblAssignmentVal.Name = "lblAssignmentVal";
        lblAssignmentVal.Size = new System.Drawing.Size(200, 20);
        lblAssignmentVal.TabIndex = 8;
        lblAssignmentVal.Text = "42 khách tiềm năng tháng 10";
        // 
        // lblAssignmentKey
        // 
        lblAssignmentKey.AutoSize = true;
        lblAssignmentKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblAssignmentKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAssignmentKey.Location = new System.Drawing.Point(20, 85);
        lblAssignmentKey.Name = "lblAssignmentKey";
        lblAssignmentKey.Size = new System.Drawing.Size(70, 20);
        lblAssignmentKey.TabIndex = 7;
        lblAssignmentKey.Text = "Phụ trách";
        // 
        // lblLinkedAccountVal
        // 
        lblLinkedAccountVal.AutoSize = true;
        lblLinkedAccountVal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
        lblLinkedAccountVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblLinkedAccountVal.Location = new System.Drawing.Point(140, 65);
        lblLinkedAccountVal.Name = "lblLinkedAccountVal";
        lblLinkedAccountVal.Size = new System.Drawing.Size(219, 20);
        lblLinkedAccountVal.TabIndex = 6;
        lblLinkedAccountVal.Text = "ngocmai.tv · Nhân viên tư vấn";
        // 
        // lblLinkedAccountKey
        // 
        lblLinkedAccountKey.AutoSize = true;
        lblLinkedAccountKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblLinkedAccountKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblLinkedAccountKey.Location = new System.Drawing.Point(20, 65);
        lblLinkedAccountKey.Name = "lblLinkedAccountKey";
        lblLinkedAccountKey.Size = new System.Drawing.Size(123, 20);
        lblLinkedAccountKey.TabIndex = 5;
        lblLinkedAccountKey.Text = "Tài khoản liên kết";
        // 
        // lblHireStatusVal
        // 
        lblHireStatusVal.AutoSize = true;
        lblHireStatusVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblHireStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblHireStatusVal.Location = new System.Drawing.Point(140, 45);
        lblHireStatusVal.Name = "lblHireStatusVal";
        lblHireStatusVal.Size = new System.Drawing.Size(191, 20);
        lblHireStatusVal.TabIndex = 4;
        lblHireStatusVal.Text = "15/03/2025 · Đang làm việc";
        // 
        // lblHireStatusKey
        // 
        lblHireStatusKey.AutoSize = true;
        lblHireStatusKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblHireStatusKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblHireStatusKey.Location = new System.Drawing.Point(20, 45);
        lblHireStatusKey.Name = "lblHireStatusKey";
        lblHireStatusKey.Size = new System.Drawing.Size(141, 20);
        lblHireStatusKey.TabIndex = 3;
        lblHireStatusKey.Text = "Vào làm / trạng thái";
        // 
        // lblContactVal
        // 
        lblContactVal.AutoSize = true;
        lblContactVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblContactVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblContactVal.Location = new System.Drawing.Point(140, 25);
        lblContactVal.Name = "lblContactVal";
        lblContactVal.Size = new System.Drawing.Size(229, 20);
        lblContactVal.TabIndex = 2;
        lblContactVal.Text = "0902 552 778 · mai@minhtri.local";
        // 
        // lblContactKey
        // 
        lblContactKey.AutoSize = true;
        lblContactKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblContactKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblContactKey.Location = new System.Drawing.Point(20, 25);
        lblContactKey.Name = "lblContactKey";
        lblContactKey.Size = new System.Drawing.Size(56, 20);
        lblContactKey.TabIndex = 1;
        lblContactKey.Text = "Liên hệ";
        // 
        // lblStaffDetailTitle
        // 
        lblStaffDetailTitle.AutoSize = true;
        lblStaffDetailTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblStaffDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblStaffDetailTitle.Location = new System.Drawing.Point(20, 3);
        lblStaffDetailTitle.Name = "lblStaffDetailTitle";
        lblStaffDetailTitle.Size = new System.Drawing.Size(230, 25);
        lblStaffDetailTitle.TabIndex = 0;
        lblStaffDetailTitle.Text = "Chi tiết · Phạm Ngọc Mai";
        // 
        // cardStaffList
        // 
        cardStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardStaffList.BackColor = System.Drawing.Color.White;
        cardStaffList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStaffList.BorderWidth = 1;
        cardStaffList.Controls.Add(lblPagingNav);
        cardStaffList.Controls.Add(lblPagingInfo);
        cardStaffList.Controls.Add(dgvStaff);
        cardStaffList.Controls.Add(cboDepartmentFilter);
        cardStaffList.Controls.Add(cboStatusFilter);
        cardStaffList.Controls.Add(txtSearchStaff);
        cardStaffList.Controls.Add(lblStaffListTitle);
        cardStaffList.CornerRadius = 6;
        cardStaffList.Location = new System.Drawing.Point(24, 20);
        cardStaffList.Name = "cardStaffList";
        cardStaffList.Padding = new System.Windows.Forms.Padding(20);
        cardStaffList.Size = new System.Drawing.Size(636, 345);
        cardStaffList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(456, 315);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 315);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(130, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–4 / 12 nhân viên";
        // 
        // dgvStaff
        // 
        dgvStaff.AllowUserToAddRows = false;
        dgvStaff.AllowUserToDeleteRows = false;
        dgvStaff.AllowUserToResizeColumns = false;
        dgvStaff.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvStaff.BackgroundColor = System.Drawing.Color.White;
        dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
        dgvStaff.EnableHeadersVisualStyles = false;
        dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvStaff.Location = new System.Drawing.Point(20, 95);
        dgvStaff.MultiSelect = false;
        dgvStaff.Name = "dgvStaff";
        dgvStaff.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvStaff.RowHeadersVisible = false;
        dgvStaff.RowHeadersWidth = 51;
        dgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvStaff.Size = new System.Drawing.Size(596, 210);
        dgvStaff.TabIndex = 4;
        // 
        // cboDepartmentFilter
        // 
        cboDepartmentFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboDepartmentFilter.BackColor = System.Drawing.Color.Transparent;
        cboDepartmentFilter.CornerRadius = 5;
        cboDepartmentFilter.DataSource = null;
        cboDepartmentFilter.DisplayMember = "";
        cboDepartmentFilter.Location = new System.Drawing.Point(446, 50);
        cboDepartmentFilter.Name = "cboDepartmentFilter";
        cboDepartmentFilter.SelectedIndex = -1;
        cboDepartmentFilter.SelectedItem = null;
        cboDepartmentFilter.SelectedValue = null;
        cboDepartmentFilter.Size = new System.Drawing.Size(170, 32);
        cboDepartmentFilter.TabIndex = 3;
        cboDepartmentFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(286, 50);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(150, 32);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchStaff
        // 
        txtSearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearchStaff.BackColor = System.Drawing.Color.Transparent;
        txtSearchStaff.CornerRadius = 5;
        txtSearchStaff.ErrorMessage = "";
        txtSearchStaff.HasError = false;
        txtSearchStaff.Location = new System.Drawing.Point(20, 50);
        txtSearchStaff.Name = "txtSearchStaff";
        txtSearchStaff.Placeholder = "Tìm mã, tên, điện thoại...";
        txtSearchStaff.ReadOnly = false;
        txtSearchStaff.Size = new System.Drawing.Size(256, 32);
        txtSearchStaff.TabIndex = 1;
        txtSearchStaff.UseSystemPasswordChar = false;
        // 
        // lblStaffListTitle
        // 
        lblStaffListTitle.AutoSize = true;
        lblStaffListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblStaffListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblStaffListTitle.Location = new System.Drawing.Point(20, 16);
        lblStaffListTitle.Name = "lblStaffListTitle";
        lblStaffListTitle.Size = new System.Drawing.Size(194, 25);
        lblStaffListTitle.TabIndex = 0;
        lblStaffListTitle.Text = "Danh sách nhân viên";
        // 
        // StaffManagementView
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
        cardStaffForm.ResumeLayout(false);
        cardStaffForm.PerformLayout();
        cardStaffDetail.ResumeLayout(false);
        cardStaffDetail.PerformLayout();
        cardStaffList.ResumeLayout(false);
        cardStaffList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnCreateStaff;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStaffList;
    private System.Windows.Forms.Label lblStaffListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchStaff;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboDepartmentFilter;
    private ECMS.UI.Controls.AppDataGrid dgvStaff;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppCard cardStaffDetail;
    private System.Windows.Forms.Label lblStaffDetailTitle;
    private System.Windows.Forms.Label lblContactKey;
    private System.Windows.Forms.Label lblContactVal;
    private System.Windows.Forms.Label lblHireStatusKey;
    private System.Windows.Forms.Label lblHireStatusVal;
    private System.Windows.Forms.Label lblLinkedAccountKey;
    private System.Windows.Forms.Label lblLinkedAccountVal;
    private System.Windows.Forms.Label lblAssignmentKey;
    private System.Windows.Forms.Label lblAssignmentVal;
    private System.Windows.Forms.Label lblPermissionKey;
    private System.Windows.Forms.Label lblPermissionVal;
    private ECMS.UI.Controls.AppButton btnOpenLinkedAccount;
    private ECMS.UI.Controls.AppCard cardStaffForm;
    private System.Windows.Forms.Label lblStaffFormTitle;
    private System.Windows.Forms.Label lblStaffCode;
    private ECMS.UI.Controls.AppTextBox txtStaffCode;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblHireDate;
    private System.Windows.Forms.DateTimePicker dtpHireDate;
    private System.Windows.Forms.Label lblDepartment;
    private ECMS.UI.Controls.AppComboBox cboDepartment;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private ECMS.UI.Controls.AppButton btnCancelStaff;
    private ECMS.UI.Controls.AppButton btnSaveStaff;
}
