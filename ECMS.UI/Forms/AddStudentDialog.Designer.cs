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

    private void InitializeComponent()
    {
        pnlTop = new System.Windows.Forms.Panel();
        lblAddStudentSub = new System.Windows.Forms.Label();
        lblAddStudentHeader = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
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
        bannerRuleLead = new ECMS.UI.Controls.AppBanner();
        lblRuleDesc = new System.Windows.Forms.Label();
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
        pnlTop.Controls.Add(lblAddStudentSub);
        pnlTop.Controls.Add(lblAddStudentHeader);
        pnlTop.Controls.Add(lblBreadcrumb);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlTop.Size = new System.Drawing.Size(1100, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblAddStudentSub
        // 
        lblAddStudentSub.AutoSize = true;
        lblAddStudentSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddStudentSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblAddStudentSub.Location = new System.Drawing.Point(24, 48);
        lblAddStudentSub.Name = "lblAddStudentSub";
        lblAddStudentSub.Size = new System.Drawing.Size(437, 20);
        lblAddStudentSub.TabIndex = 2;
        lblAddStudentSub.Text = "Nhập trực tiếp hoặc nhận dữ liệu từ hồ sơ tuyển sinh · Chưa tạo mã học viên";
        // 
        // lblAddStudentHeader
        // 
        lblAddStudentHeader.AutoSize = true;
        lblAddStudentHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblAddStudentHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddStudentHeader.Location = new System.Drawing.Point(22, 14);
        lblAddStudentHeader.Name = "lblAddStudentHeader";
        lblAddStudentHeader.Size = new System.Drawing.Size(191, 35);
        lblAddStudentHeader.TabIndex = 1;
        lblAddStudentHeader.Text = "Thêm học viên";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 0);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(199, 19);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Học viên / Thêm học viên";
        // 
        // cardStudentInfo
        // 
        cardStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardStudentInfo.BackColor = System.Drawing.Color.White;
        cardStudentInfo.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
        cardStudentInfo.Size = new System.Drawing.Size(670, 545);
        cardStudentInfo.TabIndex = 1;
        // 
        // bannerCheckPhone
        // 
        bannerCheckPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerCheckPhone.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerCheckPhone.Location = new System.Drawing.Point(20, 485);
        bannerCheckPhone.Message = "Số điện thoại chưa trùng hồ sơ hiện có. Khi lưu, sinh mã mới và mở chi tiết học viên.";
        bannerCheckPhone.Name = "bannerCheckPhone";
        bannerCheckPhone.Size = new System.Drawing.Size(630, 42);
        bannerCheckPhone.TabIndex = 21;
        bannerCheckPhone.Title = "✓ Hợp lệ:";
        bannerCheckPhone.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // btnSaveStudent
        // 
        btnSaveStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnSaveStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveStudent.CornerRadius = 6;
        btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveStudent.ForeColor = System.Drawing.Color.White;
        btnSaveStudent.Location = new System.Drawing.Point(520, 435);
        btnSaveStudent.Name = "btnSaveStudent";
        btnSaveStudent.Size = new System.Drawing.Size(130, 36);
        btnSaveStudent.TabIndex = 20;
        btnSaveStudent.Text = "Lưu học viên";
        btnSaveStudent.UseVisualStyleBackColor = false;
        // 
        // btnCancelAdd
        // 
        btnCancelAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelAdd.BackColor = System.Drawing.Color.White;
        btnCancelAdd.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelAdd.CornerRadius = 6;
        btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelAdd.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnCancelAdd.Location = new System.Drawing.Point(425, 435);
        btnCancelAdd.Name = "btnCancelAdd";
        btnCancelAdd.Size = new System.Drawing.Size(85, 36);
        btnCancelAdd.TabIndex = 19;
        btnCancelAdd.Text = "Hủy";
        btnCancelAdd.UseVisualStyleBackColor = false;
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
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblNotes.Location = new System.Drawing.Point(20, 342);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(60, 19);
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
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblParentPhone.Location = new System.Drawing.Point(345, 272);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(161, 19);
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
        lblParentName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblParentName.Location = new System.Drawing.Point(20, 272);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new System.Drawing.Size(188, 19);
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
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblEmail.Location = new System.Drawing.Point(345, 202);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(100, 19);
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
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddress.Location = new System.Drawing.Point(20, 202);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(65, 19);
        lblAddress.TabIndex = 9;
        lblAddress.Text = "Địa chỉ *";
        // 
        // cboGender
        // 
        cboGender.BackColor = System.Drawing.Color.White;
        cboGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboGender.Location = new System.Drawing.Point(345, 155);
        cboGender.Name = "cboGender";
        cboGender.Size = new System.Drawing.Size(305, 32);
        cboGender.TabIndex = 8;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblGender.Location = new System.Drawing.Point(345, 132);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(69, 19);
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
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblPhone.Location = new System.Drawing.Point(20, 132);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(92, 19);
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
        lblDob.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblDob.Location = new System.Drawing.Point(345, 62);
        lblDob.Name = "lblDob";
        lblDob.Size = new System.Drawing.Size(89, 19);
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
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblFullName.Location = new System.Drawing.Point(20, 62);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(86, 19);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Họ và tên *";
        // 
        // lblInfoTitle
        // 
        lblInfoTitle.AutoSize = true;
        lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblInfoTitle.Location = new System.Drawing.Point(20, 16);
        lblInfoTitle.Name = "lblInfoTitle";
        lblInfoTitle.Size = new System.Drawing.Size(193, 28);
        lblInfoTitle.TabIndex = 0;
        lblInfoTitle.Text = "Thông tin học viên";
        // 
        // cardRules
        // 
        cardRules.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardRules.BackColor = System.Drawing.Color.White;
        cardRules.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardRules.BorderWidth = 1;
        cardRules.Controls.Add(btnFindAdmission);
        cardRules.Controls.Add(bannerRuleLead);
        cardRules.Controls.Add(lblRuleDesc);
        cardRules.Controls.Add(lblRuleCourse);
        cardRules.Controls.Add(lblRuleCode);
        cardRules.Controls.Add(lblRuleState);
        cardRules.Controls.Add(lblRuleSource);
        cardRules.Controls.Add(lblRulesTitle);
        cardRules.CornerRadius = 8;
        cardRules.Location = new System.Drawing.Point(715, 95);
        cardRules.Name = "cardRules";
        cardRules.Padding = new System.Windows.Forms.Padding(16);
        cardRules.Size = new System.Drawing.Size(360, 545);
        cardRules.TabIndex = 2;
        // 
        // btnFindAdmission
        // 
        btnFindAdmission.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        btnFindAdmission.BackColor = System.Drawing.Color.White;
        btnFindAdmission.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnFindAdmission.CornerRadius = 6;
        btnFindAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
        btnFindAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnFindAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnFindAdmission.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnFindAdmission.Location = new System.Drawing.Point(20, 485);
        btnFindAdmission.Name = "btnFindAdmission";
        btnFindAdmission.Size = new System.Drawing.Size(320, 38);
        btnFindAdmission.TabIndex = 7;
        btnFindAdmission.Text = "Tìm hồ sơ tuyển sinh liên quan";
        btnFindAdmission.UseVisualStyleBackColor = false;
        // 
        // bannerRuleLead
        // 
        bannerRuleLead.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerRuleLead.BannerType = ECMS.UI.Controls.BannerType.Warning;
        bannerRuleLead.Location = new System.Drawing.Point(20, 395);
        bannerRuleLead.Message = "Nếu nhập từ TN-0112, mở hồ sơ tư vấn để chuyển đổi thay vì tạo một học viên trùng.";
        bannerRuleLead.Name = "bannerRuleLead";
        bannerRuleLead.Size = new System.Drawing.Size(320, 75);
        bannerRuleLead.TabIndex = 6;
        bannerRuleLead.Title = "Lưu ý chuyển đổi:";
        bannerRuleLead.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        // 
        // lblRuleDesc
        // 
        lblRuleDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblRuleDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblRuleDesc.Location = new System.Drawing.Point(20, 240);
        lblRuleDesc.Name = "lblRuleDesc";
        lblRuleDesc.Size = new System.Drawing.Size(320, 80);
        lblRuleDesc.TabIndex = 5;
        lblRuleDesc.Text = "Không tự tạo tài khoản, phiếu thu hoặc lớp học. Chọn Ghi danh trong hồ sơ khi đã có đủ tư vấn và đánh giá đầu vào.";
        // 
        // lblRuleCourse
        // 
        lblRuleCourse.AutoSize = true;
        lblRuleCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleCourse.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRuleCourse.Location = new System.Drawing.Point(20, 185);
        lblRuleCourse.Name = "lblRuleCourse";
        lblRuleCourse.Size = new System.Drawing.Size(189, 21);
        lblRuleCourse.TabIndex = 4;
        lblRuleCourse.Text = "Khóa quan tâm:  TOEIC 650+";
        // 
        // lblRuleCode
        // 
        lblRuleCode.AutoSize = true;
        lblRuleCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleCode.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRuleCode.Location = new System.Drawing.Point(20, 145);
        lblRuleCode.Name = "lblRuleCode";
        lblRuleCode.Size = new System.Drawing.Size(262, 21);
        lblRuleCode.TabIndex = 3;
        lblRuleCode.Text = "Mã dự kiến:  HV-0242 · cấp sau khi lưu";
        // 
        // lblRuleState
        // 
        lblRuleState.AutoSize = true;
        lblRuleState.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleState.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRuleState.Location = new System.Drawing.Point(20, 105);
        lblRuleState.Name = "lblRuleState";
        lblRuleState.Size = new System.Drawing.Size(201, 21);
        lblRuleState.TabIndex = 2;
        lblRuleState.Text = "Trạng thái ban đầu:  Chưa xếp";
        // 
        // lblRuleSource
        // 
        lblRuleSource.AutoSize = true;
        lblRuleSource.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRuleSource.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRuleSource.Location = new System.Drawing.Point(20, 65);
        lblRuleSource.Name = "lblRuleSource";
        lblRuleSource.Size = new System.Drawing.Size(264, 21);
        lblRuleSource.TabIndex = 1;
        lblRuleSource.Text = "Nguồn tiếp nhận:  Nhập trực tiếp · 30/10";
        // 
        // lblRulesTitle
        // 
        lblRulesTitle.AutoSize = true;
        lblRulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblRulesTitle.Location = new System.Drawing.Point(20, 16);
        lblRulesTitle.Name = "lblRulesTitle";
        lblRulesTitle.Size = new System.Drawing.Size(168, 28);
        lblRulesTitle.TabIndex = 0;
        lblRulesTitle.Text = "Quy tắc tạo hồ sơ";
        // 
        // AddStudentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(1200, 750);
        Controls.Add(cardRules);
        Controls.Add(cardStudentInfo);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddStudentDialog";
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
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Label lblAddStudentHeader;
    private System.Windows.Forms.Label lblAddStudentSub;

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
    private System.Windows.Forms.Label lblRuleDesc;
    private ECMS.UI.Controls.AppBanner bannerRuleLead;
    private ECMS.UI.Controls.AppButton btnFindAdmission;
}
