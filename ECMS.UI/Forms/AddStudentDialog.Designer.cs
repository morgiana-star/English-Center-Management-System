namespace ECMS.UI.Forms;

partial class AddStudentDialog
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
        pnlTop = new System.Windows.Forms.Panel();
        lblAddStudentHeader = new System.Windows.Forms.Label();
        cardStudentInfo = new ECMS.UI.Controls.AppCard();
        bannerCheckPhone = new ECMS.UI.Controls.AppBanner();
        btnSaveStudent = new ECMS.UI.Controls.AppButton();
        btnCancelAdd = new ECMS.UI.Controls.AppButton();
        txtNotes = new ECMS.UI.Controls.AppTextBox();
        lblNotes = new System.Windows.Forms.Label();
        txtParentPhone = new ECMS.UI.Controls.AppTextBox();
        lblParentPhone = new System.Windows.Forms.Label();
        txtParentName = new ECMS.UI.Controls.AppTextBox();
        lblParentName = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtAddress = new ECMS.UI.Controls.AppTextBox();
        lblAddress = new System.Windows.Forms.Label();
        cboGender = new ECMS.UI.Controls.AppComboBox();
        lblGender = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        dtpDob = new System.Windows.Forms.DateTimePicker();
        lblDob = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        lblInfoTitle = new System.Windows.Forms.Label();
        cardRules = new ECMS.UI.Controls.AppCard();
        btnFindAdmission = new ECMS.UI.Controls.AppButton();
        lblRuleCourse = new System.Windows.Forms.Label();
        lblRuleCode = new System.Windows.Forms.Label();
        lblRuleState = new System.Windows.Forms.Label();
        lblRuleSource = new System.Windows.Forms.Label();
        lblRulesTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        cardStudentInfo.SuspendLayout();
        cardRules.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblAddStudentHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlTop.Size = new System.Drawing.Size(1200, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblAddStudentHeader
        // 
        lblAddStudentHeader.AutoSize = true;
        lblAddStudentHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblAddStudentHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddStudentHeader.Location = new System.Drawing.Point(22, 14);
        lblAddStudentHeader.Name = "lblAddStudentHeader";
        lblAddStudentHeader.Size = new System.Drawing.Size(188, 35);
        lblAddStudentHeader.TabIndex = 1;
        lblAddStudentHeader.Text = "Thêm học viên";
        // 
        // cardStudentInfo
        // 
        cardStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardStudentInfo.BackColor = System.Drawing.Color.White;
        cardStudentInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentInfo.BorderWidth = 1;
        cardStudentInfo.Controls.Add(bannerCheckPhone);
        cardStudentInfo.Controls.Add(btnSaveStudent);
        cardStudentInfo.Controls.Add(btnCancelAdd);
        cardStudentInfo.Controls.Add(txtNotes);
        cardStudentInfo.Controls.Add(lblNotes);
        cardStudentInfo.Controls.Add(txtParentPhone);
        cardStudentInfo.Controls.Add(lblParentPhone);
        cardStudentInfo.Controls.Add(txtParentName);
        cardStudentInfo.Controls.Add(lblParentName);
        cardStudentInfo.Controls.Add(txtEmail);
        cardStudentInfo.Controls.Add(lblEmail);
        cardStudentInfo.Controls.Add(txtAddress);
        cardStudentInfo.Controls.Add(lblAddress);
        cardStudentInfo.Controls.Add(cboGender);
        cardStudentInfo.Controls.Add(lblGender);
        cardStudentInfo.Controls.Add(txtPhone);
        cardStudentInfo.Controls.Add(lblPhone);
        cardStudentInfo.Controls.Add(dtpDob);
        cardStudentInfo.Controls.Add(lblDob);
        cardStudentInfo.Controls.Add(txtFullName);
        cardStudentInfo.Controls.Add(lblFullName);
        cardStudentInfo.Controls.Add(lblInfoTitle);
        cardStudentInfo.CornerRadius = 8;
        cardStudentInfo.Location = new System.Drawing.Point(24, 95);
        cardStudentInfo.Name = "cardStudentInfo";
        cardStudentInfo.Padding = new System.Windows.Forms.Padding(16);
        cardStudentInfo.Size = new System.Drawing.Size(670, 571);
        cardStudentInfo.TabIndex = 1;
        // 
        // bannerCheckPhone
        // 
        bannerCheckPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerCheckPhone.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerCheckPhone.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerCheckPhone.Location = new System.Drawing.Point(20, 492);
        bannerCheckPhone.Message = ("Số điện thoại chưa trùng hồ sơ hiện có. Khi lưu, sinh mã mới và mở chi tiết học v" + "iên.");
        bannerCheckPhone.Name = "bannerCheckPhone";
        bannerCheckPhone.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerCheckPhone.Size = new System.Drawing.Size(630, 60);
        bannerCheckPhone.TabIndex = 21;
        bannerCheckPhone.Title = "✓ Hợp lệ:";
        bannerCheckPhone.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // btnSaveStudent
        // 
        btnSaveStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveStudent.CornerRadius = 6;
        btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveStudent.ForeColor = System.Drawing.Color.White;
        btnSaveStudent.Location = new System.Drawing.Point(515, 430);
        btnSaveStudent.Name = "btnSaveStudent";
        btnSaveStudent.Size = new System.Drawing.Size(130, 36);
        btnSaveStudent.TabIndex = 20;
        btnSaveStudent.Text = "Lưu học viên";
        btnSaveStudent.UseVisualStyleBackColor = false;
        btnSaveStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelAdd
        // 
        btnCancelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelAdd.BackColor = System.Drawing.Color.White;
        btnCancelAdd.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelAdd.CornerRadius = 6;
        btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelAdd.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnCancelAdd.Location = new System.Drawing.Point(420, 430);
        btnCancelAdd.Name = "btnCancelAdd";
        btnCancelAdd.Size = new System.Drawing.Size(85, 36);
        btnCancelAdd.TabIndex = 19;
        btnCancelAdd.Text = "Hủy";
        btnCancelAdd.UseVisualStyleBackColor = false;
        btnCancelAdd.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtNotes
        // 
        txtNotes.BackColor = System.Drawing.Color.Transparent;
        txtNotes.CornerRadius = 6;
        txtNotes.ErrorMessage = "";
        txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNotes.HasError = false;
        txtNotes.Location = new System.Drawing.Point(20, 365);
        txtNotes.Name = "txtNotes";
        txtNotes.Placeholder = "Quan tâm TOEIC 650+. Chưa ghi danh lớp.";
        txtNotes.ReadOnly = false;
        txtNotes.Size = new System.Drawing.Size(630, 50);
        txtNotes.TabIndex = 18;
        txtNotes.UseSystemPasswordChar = false;
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblNotes.Location = new System.Drawing.Point(20, 342);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(62, 20);
        lblNotes.TabIndex = 17;
        lblNotes.Text = "Ghi chú";
        // 
        // txtParentPhone
        // 
        txtParentPhone.BackColor = System.Drawing.Color.Transparent;
        txtParentPhone.CornerRadius = 6;
        txtParentPhone.ErrorMessage = "";
        txtParentPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtParentPhone.HasError = false;
        txtParentPhone.Location = new System.Drawing.Point(345, 295);
        txtParentPhone.Name = "txtParentPhone";
        txtParentPhone.Placeholder = "0909 770 331";
        txtParentPhone.ReadOnly = false;
        txtParentPhone.Size = new System.Drawing.Size(305, 32);
        txtParentPhone.TabIndex = 16;
        txtParentPhone.UseSystemPasswordChar = false;
        // 
        // lblParentPhone
        // 
        lblParentPhone.AutoSize = true;
        lblParentPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblParentPhone.Location = new System.Drawing.Point(345, 272);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(160, 20);
        lblParentPhone.TabIndex = 15;
        lblParentPhone.Text = "Điện thoại phụ huynh";
        // 
        // txtParentName
        // 
        txtParentName.BackColor = System.Drawing.Color.Transparent;
        txtParentName.CornerRadius = 6;
        txtParentName.ErrorMessage = "";
        txtParentName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtParentName.HasError = false;
        txtParentName.Location = new System.Drawing.Point(20, 295);
        txtParentName.Name = "txtParentName";
        txtParentName.Placeholder = "Ngô Thành Đạt";
        txtParentName.ReadOnly = false;
        txtParentName.Size = new System.Drawing.Size(305, 32);
        txtParentName.TabIndex = 14;
        txtParentName.UseSystemPasswordChar = false;
        // 
        // lblParentName
        // 
        lblParentName.AutoSize = true;
        lblParentName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblParentName.Location = new System.Drawing.Point(20, 272);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new System.Drawing.Size(201, 20);
        lblParentName.TabIndex = 13;
        lblParentName.Text = "Phụ huynh / người giám hộ";
        // 
        // txtEmail
        // 
        txtEmail.BackColor = System.Drawing.Color.Transparent;
        txtEmail.CornerRadius = 6;
        txtEmail.ErrorMessage = "";
        txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEmail.HasError = false;
        txtEmail.Location = new System.Drawing.Point(345, 225);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "maiphuong@example.local";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(305, 32);
        txtEmail.TabIndex = 12;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEmail.Location = new System.Drawing.Point(345, 202);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(97, 20);
        lblEmail.TabIndex = 11;
        lblEmail.Text = "Email liên hệ";
        // 
        // txtAddress
        // 
        txtAddress.BackColor = System.Drawing.Color.Transparent;
        txtAddress.CornerRadius = 6;
        txtAddress.ErrorMessage = "";
        txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddress.HasError = false;
        txtAddress.Location = new System.Drawing.Point(20, 225);
        txtAddress.Name = "txtAddress";
        txtAddress.Placeholder = "18 Lê Hồng Phong, TP. Hồ Chí Minh";
        txtAddress.ReadOnly = false;
        txtAddress.Size = new System.Drawing.Size(305, 32);
        txtAddress.TabIndex = 10;
        txtAddress.UseSystemPasswordChar = false;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddress.Location = new System.Drawing.Point(20, 202);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(67, 20);
        lblAddress.TabIndex = 9;
        lblAddress.Text = "Địa chỉ *";
        // 
        // cboGender
        // 
        cboGender.BackColor = System.Drawing.Color.White;
        cboGender.CornerRadius = 5;
        cboGender.DataSource = null;
        cboGender.DisplayMember = "";
        cboGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboGender.Location = new System.Drawing.Point(345, 155);
        cboGender.Name = "cboGender";
        cboGender.SelectedIndex = -1;
        cboGender.SelectedItem = null;
        cboGender.SelectedValue = null;
        cboGender.Size = new System.Drawing.Size(305, 32);
        cboGender.TabIndex = 8;
        cboGender.ValueMember = "";
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblGender.Location = new System.Drawing.Point(345, 132);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(69, 20);
        lblGender.TabIndex = 7;
        lblGender.Text = "Giới tính";
        // 
        // txtPhone
        // 
        txtPhone.BackColor = System.Drawing.Color.Transparent;
        txtPhone.CornerRadius = 6;
        txtPhone.ErrorMessage = "";
        txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtPhone.HasError = false;
        txtPhone.Location = new System.Drawing.Point(20, 155);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "0917 832 998";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(305, 32);
        txtPhone.TabIndex = 6;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPhone.Location = new System.Drawing.Point(20, 132);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(92, 20);
        lblPhone.TabIndex = 5;
        lblPhone.Text = "Điện thoại *";
        // 
        // dtpDob
        // 
        dtpDob.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpDob.CustomFormat = "dd/MM/yyyy";
        dtpDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDob.Location = new System.Drawing.Point(345, 85);
        dtpDob.Name = "dtpDob";
        dtpDob.Size = new System.Drawing.Size(305, 29);
        dtpDob.TabIndex = 4;
        // 
        // lblDob
        // 
        lblDob.AutoSize = true;
        lblDob.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblDob.Location = new System.Drawing.Point(345, 62);
        lblDob.Name = "lblDob";
        lblDob.Size = new System.Drawing.Size(90, 20);
        lblDob.TabIndex = 3;
        lblDob.Text = "Ngày sinh *";
        // 
        // txtFullName
        // 
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 6;
        txtFullName.ErrorMessage = "";
        txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(20, 85);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập họ và tên...";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(305, 32);
        txtFullName.TabIndex = 2;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblFullName.Location = new System.Drawing.Point(20, 62);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(87, 20);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Họ và tên *";
        // 
        // lblInfoTitle
        // 
        lblInfoTitle.AutoSize = true;
        lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblInfoTitle.Location = new System.Drawing.Point(20, 16);
        lblInfoTitle.Name = "lblInfoTitle";
        lblInfoTitle.Size = new System.Drawing.Size(190, 28);
        lblInfoTitle.TabIndex = 0;
        lblInfoTitle.Text = "Thông tin học viên";
        // 
        // cardRules
        // 
        cardRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardRules.BackColor = System.Drawing.Color.White;
        cardRules.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRules.BorderWidth = 1;
        cardRules.Controls.Add(btnFindAdmission);
        cardRules.Controls.Add(lblRuleCourse);
        cardRules.Controls.Add(lblRuleCode);
        cardRules.Controls.Add(lblRuleState);
        cardRules.Controls.Add(lblRuleSource);
        cardRules.Controls.Add(lblRulesTitle);
        cardRules.CornerRadius = 8;
        cardRules.Location = new System.Drawing.Point(715, 95);
        cardRules.Name = "cardRules";
        cardRules.Padding = new System.Windows.Forms.Padding(16);
        cardRules.Size = new System.Drawing.Size(360, 571);
        cardRules.TabIndex = 2;
        // 
        // btnFindAdmission
        // 
        btnFindAdmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnFindAdmission.BackColor = System.Drawing.Color.White;
        btnFindAdmission.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnFindAdmission.CornerRadius = 6;
        btnFindAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
        btnFindAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnFindAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnFindAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnFindAdmission.Location = new System.Drawing.Point(20, 511);
        btnFindAdmission.Name = "btnFindAdmission";
        btnFindAdmission.Size = new System.Drawing.Size(320, 38);
        btnFindAdmission.TabIndex = 7;
        btnFindAdmission.Text = "Tìm hồ sơ tuyển sinh liên quan";
        btnFindAdmission.UseVisualStyleBackColor = false;
        btnFindAdmission.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblRuleCourse
        // 
        lblRuleCourse.AutoSize = true;
        lblRuleCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRuleCourse.Location = new System.Drawing.Point(20, 185);
        lblRuleCourse.Name = "lblRuleCourse";
        lblRuleCourse.Size = new System.Drawing.Size(209, 21);
        lblRuleCourse.TabIndex = 4;
        lblRuleCourse.Text = "Khóa quan tâm:  TOEIC 650+";
        // 
        // lblRuleCode
        // 
        lblRuleCode.AutoSize = true;
        lblRuleCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRuleCode.Location = new System.Drawing.Point(20, 145);
        lblRuleCode.Name = "lblRuleCode";
        lblRuleCode.Size = new System.Drawing.Size(275, 21);
        lblRuleCode.TabIndex = 3;
        lblRuleCode.Text = "Mã dự kiến:  HV-0242 · cấp sau khi lưu";
        // 
        // lblRuleState
        // 
        lblRuleState.AutoSize = true;
        lblRuleState.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRuleState.Location = new System.Drawing.Point(20, 105);
        lblRuleState.Name = "lblRuleState";
        lblRuleState.Size = new System.Drawing.Size(214, 21);
        lblRuleState.TabIndex = 2;
        lblRuleState.Text = "Trạng thái ban đầu:  Chưa xếp";
        // 
        // lblRuleSource
        // 
        lblRuleSource.AutoSize = true;
        lblRuleSource.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleSource.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRuleSource.Location = new System.Drawing.Point(20, 65);
        lblRuleSource.Name = "lblRuleSource";
        lblRuleSource.Size = new System.Drawing.Size(290, 21);
        lblRuleSource.TabIndex = 1;
        lblRuleSource.Text = "Nguồn tiếp nhận:  Nhập trực tiếp · 30/10";
        // 
        // lblRulesTitle
        // 
        lblRulesTitle.AutoSize = true;
        lblRulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblRulesTitle.Location = new System.Drawing.Point(20, 16);
        lblRulesTitle.Name = "lblRulesTitle";
        lblRulesTitle.Size = new System.Drawing.Size(180, 28);
        lblRulesTitle.TabIndex = 0;
        lblRulesTitle.Text = "Quy tắc tạo hồ sơ";
        // 
        // AddStudentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 750);
        Controls.Add(cardRules);
        Controls.Add(cardStudentInfo);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm học viên — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardStudentInfo.ResumeLayout(false);
        cardStudentInfo.PerformLayout();
        cardRules.ResumeLayout(false);
        cardRules.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblAddStudentHeader;

    private ECMS.UI.Controls.AppCard cardStudentInfo;
    private System.Windows.Forms.Label lblInfoTitle;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblDob;
    private System.Windows.Forms.DateTimePicker dtpDob;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblGender;
    private ECMS.UI.Controls.AppComboBox cboGender;
    private System.Windows.Forms.Label lblAddress;
    private ECMS.UI.Controls.AppTextBox txtAddress;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private System.Windows.Forms.Label lblParentName;
    private ECMS.UI.Controls.AppTextBox txtParentName;
    private System.Windows.Forms.Label lblParentPhone;
    private ECMS.UI.Controls.AppTextBox txtParentPhone;
    private System.Windows.Forms.Label lblNotes;
    private ECMS.UI.Controls.AppTextBox txtNotes;
    private ECMS.UI.Controls.AppButton btnCancelAdd;
    private ECMS.UI.Controls.AppButton btnSaveStudent;
    private ECMS.UI.Controls.AppBanner bannerCheckPhone;

    private ECMS.UI.Controls.AppCard cardRules;
    private System.Windows.Forms.Label lblRulesTitle;
    private System.Windows.Forms.Label lblRuleSource;
    private System.Windows.Forms.Label lblRuleState;
    private System.Windows.Forms.Label lblRuleCode;
    private System.Windows.Forms.Label lblRuleCourse;
    private ECMS.UI.Controls.AppButton btnFindAdmission;
}
