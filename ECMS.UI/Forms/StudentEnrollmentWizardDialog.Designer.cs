namespace ECMS.UI.Forms;

partial class StudentEnrollmentWizardDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        lblStepBadge = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnBack = new ECMS.UI.Controls.AppButton();
        btnNext = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBodyContainer = new System.Windows.Forms.Panel();
        pnlStep1 = new System.Windows.Forms.Panel();
        cardStep1 = new ECMS.UI.Controls.AppCard();
        lblInfoTitle = new System.Windows.Forms.Label();
        lblFullName = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblDob = new System.Windows.Forms.Label();
        dtpDob = new System.Windows.Forms.DateTimePicker();
        lblGender = new System.Windows.Forms.Label();
        cboGender = new ECMS.UI.Controls.AppComboBox();
        lblPhone = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblAddress = new System.Windows.Forms.Label();
        txtAddress = new ECMS.UI.Controls.AppTextBox();
        lblParentName = new System.Windows.Forms.Label();
        txtParentName = new ECMS.UI.Controls.AppTextBox();
        lblParentPhone = new System.Windows.Forms.Label();
        txtParentPhone = new ECMS.UI.Controls.AppTextBox();
        lblNotes = new System.Windows.Forms.Label();
        txtNotes = new ECMS.UI.Controls.AppTextBox();
        bannerCheckPhone = new ECMS.UI.Controls.AppBanner();
        pnlStep2 = new System.Windows.Forms.Panel();
        cardStep2 = new ECMS.UI.Controls.AppCard();
        dgvOpenClasses = new ECMS.UI.Controls.AppDataGrid();
        lblSelectClassTitle = new System.Windows.Forms.Label();
        lblCourseFee = new System.Windows.Forms.Label();
        cboCourse = new ECMS.UI.Controls.AppComboBox();
        lblSelectCourseTitle = new System.Windows.Forms.Label();
        pnlStep3 = new System.Windows.Forms.Panel();
        cardStep3 = new ECMS.UI.Controls.AppCard();
        lblDebtSummary = new System.Windows.Forms.Label();
        lblInitialPayment = new System.Windows.Forms.Label();
        txtInitialPayment = new ECMS.UI.Controls.AppTextBox();
        cboPaymentMethod = new ECMS.UI.Controls.AppComboBox();
        lblPaymentMethod = new System.Windows.Forms.Label();
        pnlInstallmentOptions = new System.Windows.Forms.Panel();
        radPay3Installments = new System.Windows.Forms.RadioButton();
        radPay2Installments = new System.Windows.Forms.RadioButton();
        radPayFull = new System.Windows.Forms.RadioButton();
        lblInstallmentTitle = new System.Windows.Forms.Label();
        cardSummaryInfo = new ECMS.UI.Controls.AppCard();
        lblSummaryFee = new System.Windows.Forms.Label();
        lblSummaryClass = new System.Windows.Forms.Label();
        lblSummaryStudent = new System.Windows.Forms.Label();
        pnlStep4 = new System.Windows.Forms.Panel();
        cardStep4 = new ECMS.UI.Controls.AppCard();
        lblSuccessDesc = new System.Windows.Forms.Label();
        lblSuccessTitle = new System.Windows.Forms.Label();
        lblSuccessIcon = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBodyContainer.SuspendLayout();
        pnlStep1.SuspendLayout();
        cardStep1.SuspendLayout();
        pnlStep2.SuspendLayout();
        cardStep2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).BeginInit();
        pnlStep3.SuspendLayout();
        cardStep3.SuspendLayout();
        pnlInstallmentOptions.SuspendLayout();
        cardSummaryInfo.SuspendLayout();
        pnlStep4.SuspendLayout();
        cardStep4.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblStepBadge);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(784, 76);
        pnlHeader.TabIndex = 0;
        // 
        // lblStepBadge
        // 
        lblStepBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        lblStepBadge.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        lblStepBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStepBadge.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblStepBadge.Location = new System.Drawing.Point(540, 18);
        lblStepBadge.Name = "lblStepBadge";
        lblStepBadge.Size = new System.Drawing.Size(220, 28);
        lblStepBadge.TabIndex = 2;
        lblStepBadge.Text = "Bước 1 / 4: Nhập thông tin học viên";
        lblStepBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 45);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(370, 15);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Ghi danh khóa học, chọn lớp và thiết lập kế hoạch đóng học phí linh hoạt";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(185, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đăng ký nhập học mới";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnBack);
        pnlFooter.Controls.Add(btnNext);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 505);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(784, 56);
        pnlFooter.TabIndex = 1;
        // 
        // btnBack
        // 
        btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnBack.BackColor = System.Drawing.Color.White;
        btnBack.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBack.CornerRadius = 5;
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnBack.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnBack.Location = new System.Drawing.Point(520, 11);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(100, 34);
        btnBack.TabIndex = 1;
        btnBack.Text = "← Quay lại";
        btnBack.Visible = false;
        // 
        // btnNext
        // 
        btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnNext.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnNext.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnNext.CornerRadius = 5;
        btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNext.FlatAppearance.BorderSize = 0;
        btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnNext.ForeColor = System.Drawing.Color.White;
        btnNext.Location = new System.Drawing.Point(628, 11);
        btnNext.Name = "btnNext";
        btnNext.Size = new System.Drawing.Size(132, 34);
        btnNext.TabIndex = 0;
        btnNext.Text = "Tiếp tục →";
        // 
        // btnCancel
        // 
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnCancel.Location = new System.Drawing.Point(24, 11);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(84, 34);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Hủy bỏ";
        // 
        // pnlBodyContainer
        // 
        pnlBodyContainer.Controls.Add(pnlStep1);
        pnlBodyContainer.Controls.Add(pnlStep2);
        pnlBodyContainer.Controls.Add(pnlStep3);
        pnlBodyContainer.Controls.Add(pnlStep4);
        pnlBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBodyContainer.Location = new System.Drawing.Point(0, 76);
        pnlBodyContainer.Name = "pnlBodyContainer";
        pnlBodyContainer.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
        pnlBodyContainer.Size = new System.Drawing.Size(784, 429);
        pnlBodyContainer.TabIndex = 2;
        // 
        // pnlStep1
        // 
        pnlStep1.Controls.Add(cardStep1);
        pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep1.Location = new System.Drawing.Point(20, 14);
        pnlStep1.Name = "pnlStep1";
        pnlStep1.Size = new System.Drawing.Size(744, 401);
        pnlStep1.TabIndex = 0;
        // 
        // cardStep1
        // 
        cardStep1.BackColor = System.Drawing.Color.White;
        cardStep1.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStep1.BorderWidth = 1;
        cardStep1.Controls.Add(bannerCheckPhone);
        cardStep1.Controls.Add(txtNotes);
        cardStep1.Controls.Add(lblNotes);
        cardStep1.Controls.Add(txtParentPhone);
        cardStep1.Controls.Add(lblParentPhone);
        cardStep1.Controls.Add(txtParentName);
        cardStep1.Controls.Add(lblParentName);
        cardStep1.Controls.Add(txtAddress);
        cardStep1.Controls.Add(lblAddress);
        cardStep1.Controls.Add(txtEmail);
        cardStep1.Controls.Add(lblEmail);
        cardStep1.Controls.Add(txtPhone);
        cardStep1.Controls.Add(lblPhone);
        cardStep1.Controls.Add(cboGender);
        cardStep1.Controls.Add(lblGender);
        cardStep1.Controls.Add(dtpDob);
        cardStep1.Controls.Add(lblDob);
        cardStep1.Controls.Add(txtFullName);
        cardStep1.Controls.Add(lblFullName);
        cardStep1.Controls.Add(lblInfoTitle);
        cardStep1.CornerRadius = 8;
        cardStep1.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep1.Location = new System.Drawing.Point(0, 0);
        cardStep1.Name = "cardStep1";
        cardStep1.Padding = new System.Windows.Forms.Padding(20);
        cardStep1.Size = new System.Drawing.Size(780, 550);
        cardStep1.TabIndex = 0;
        // 
        // lblInfoTitle
        // 
        lblInfoTitle.AutoSize = true;
        lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblInfoTitle.Location = new System.Drawing.Point(20, 16);
        lblInfoTitle.Name = "lblInfoTitle";
        lblInfoTitle.Size = new System.Drawing.Size(185, 25);
        lblInfoTitle.TabIndex = 0;
        lblInfoTitle.Text = "Thông tin học viên";
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblFullName.Location = new System.Drawing.Point(20, 50);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(86, 20);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtFullName
        // 
        txtFullName.Location = new System.Drawing.Point(20, 74);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên...";
        txtFullName.Size = new System.Drawing.Size(340, 36);
        txtFullName.TabIndex = 2;
        // 
        // lblDob
        // 
        lblDob.AutoSize = true;
        lblDob.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDob.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblDob.Location = new System.Drawing.Point(380, 50);
        lblDob.Name = "lblDob";
        lblDob.Size = new System.Drawing.Size(87, 20);
        lblDob.TabIndex = 3;
        lblDob.Text = "Ngày sinh *";
        // 
        // dtpDob
        // 
        dtpDob.CustomFormat = "dd/MM/yyyy";
        dtpDob.Font = new System.Drawing.Font("Segoe UI", 10F);
        dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDob.Location = new System.Drawing.Point(380, 77);
        dtpDob.Name = "dtpDob";
        dtpDob.Size = new System.Drawing.Size(160, 30);
        dtpDob.TabIndex = 4;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblGender.Location = new System.Drawing.Point(560, 50);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(78, 20);
        lblGender.TabIndex = 5;
        lblGender.Text = "Giới tính *";
        // 
        // cboGender
        // 
        cboGender.Location = new System.Drawing.Point(560, 74);
        cboGender.Name = "cboGender";
        cboGender.Size = new System.Drawing.Size(180, 36);
        cboGender.TabIndex = 6;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblPhone.Location = new System.Drawing.Point(20, 120);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(108, 20);
        lblPhone.TabIndex = 7;
        lblPhone.Text = "Số điện thoại *";
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(20, 144);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "VD: 0908 123 456";
        txtPhone.Size = new System.Drawing.Size(340, 36);
        txtPhone.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblEmail.Location = new System.Drawing.Point(380, 120);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(46, 20);
        lblEmail.TabIndex = 9;
        lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(380, 144);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "VD: student@email.com";
        txtEmail.Size = new System.Drawing.Size(360, 36);
        txtEmail.TabIndex = 10;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblAddress.Location = new System.Drawing.Point(20, 190);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(55, 20);
        lblAddress.TabIndex = 11;
        lblAddress.Text = "Địa chỉ";
        // 
        // txtAddress
        // 
        txtAddress.Location = new System.Drawing.Point(20, 214);
        txtAddress.Name = "txtAddress";
        txtAddress.Placeholder = "Số nhà, tên đường, phường/xã, quận/huyện...";
        txtAddress.Size = new System.Drawing.Size(720, 36);
        txtAddress.TabIndex = 12;
        // 
        // lblParentName
        // 
        lblParentName.AutoSize = true;
        lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentName.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblParentName.Location = new System.Drawing.Point(20, 260);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new System.Drawing.Size(161, 20);
        lblParentName.TabIndex = 13;
        lblParentName.Text = "Họ tên phụ huynh / bảo lãnh";
        // 
        // txtParentName
        // 
        txtParentName.Location = new System.Drawing.Point(20, 284);
        txtParentName.Name = "txtParentName";
        txtParentName.Placeholder = "Họ và tên phụ huynh...";
        txtParentName.Size = new System.Drawing.Size(340, 36);
        txtParentName.TabIndex = 14;
        // 
        // lblParentPhone
        // 
        lblParentPhone.AutoSize = true;
        lblParentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblParentPhone.Location = new System.Drawing.Point(380, 260);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(134, 20);
        lblParentPhone.TabIndex = 15;
        lblParentPhone.Text = "SĐT phụ huynh";
        // 
        // txtParentPhone
        // 
        txtParentPhone.Location = new System.Drawing.Point(380, 284);
        txtParentPhone.Name = "txtParentPhone";
        txtParentPhone.Placeholder = "VD: 0911 556 889";
        txtParentPhone.Size = new System.Drawing.Size(360, 36);
        txtParentPhone.TabIndex = 16;
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblNotes.Location = new System.Drawing.Point(20, 330);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(61, 20);
        lblNotes.TabIndex = 17;
        lblNotes.Text = "Ghi chú";
        // 
        // txtNotes
        // 
        txtNotes.Location = new System.Drawing.Point(20, 354);
        txtNotes.Name = "txtNotes";
        txtNotes.Placeholder = "Mục tiêu học tập, yêu cầu đặc biệt hoặc ghi chú thêm...";
        txtNotes.Size = new System.Drawing.Size(720, 52);
        txtNotes.TabIndex = 18;
        // 
        // bannerCheckPhone
        // 
        bannerCheckPhone.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
        bannerCheckPhone.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerCheckPhone.Location = new System.Drawing.Point(20, 420);
        bannerCheckPhone.Message = "Hồ sơ hợp lệ và sẵn sàng chuyển sang bước chọn khóa & lớp học.";
        bannerCheckPhone.Name = "bannerCheckPhone";
        bannerCheckPhone.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerCheckPhone.Size = new System.Drawing.Size(720, 56);
        bannerCheckPhone.TabIndex = 19;
        bannerCheckPhone.Title = "✓ Hợp lệ:";
        bannerCheckPhone.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // pnlStep2
        // 
        pnlStep2.Controls.Add(cardStep2);
        pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep2.Location = new System.Drawing.Point(20, 14);
        pnlStep2.Name = "pnlStep2";
        pnlStep2.Size = new System.Drawing.Size(744, 401);
        pnlStep2.TabIndex = 1;
        pnlStep2.Visible = false;
        // 
        // cardStep2
        // 
        cardStep2.BackColor = System.Drawing.Color.White;
        cardStep2.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStep2.BorderWidth = 1;
        cardStep2.Controls.Add(dgvOpenClasses);
        cardStep2.Controls.Add(lblSelectClassTitle);
        cardStep2.Controls.Add(lblCourseFee);
        cardStep2.Controls.Add(cboCourse);
        cardStep2.Controls.Add(lblSelectCourseTitle);
        cardStep2.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep2.Location = new System.Drawing.Point(0, 0);
        cardStep2.Name = "cardStep2";
        cardStep2.Padding = new System.Windows.Forms.Padding(18);
        cardStep2.Size = new System.Drawing.Size(744, 401);
        cardStep2.TabIndex = 0;
        // 
        // dgvOpenClasses
        // 
        dgvOpenClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOpenClasses.Location = new System.Drawing.Point(18, 110);
        dgvOpenClasses.Name = "dgvOpenClasses";
        dgvOpenClasses.Size = new System.Drawing.Size(708, 260);
        dgvOpenClasses.TabIndex = 4;
        // 
        // lblSelectClassTitle
        // 
        lblSelectClassTitle.AutoSize = true;
        lblSelectClassTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSelectClassTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSelectClassTitle.Location = new System.Drawing.Point(18, 85);
        lblSelectClassTitle.Name = "lblSelectClassTitle";
        lblSelectClassTitle.Size = new System.Drawing.Size(306, 17);
        lblSelectClassTitle.TabIndex = 3;
        lblSelectClassTitle.Text = "Chọn lớp học đang tuyển sinh (Bấm chọn 1 dòng):";
        // 
        // lblCourseFee
        // 
        lblCourseFee.AutoSize = true;
        lblCourseFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourseFee.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblCourseFee.Location = new System.Drawing.Point(400, 45);
        lblCourseFee.Name = "lblCourseFee";
        lblCourseFee.Size = new System.Drawing.Size(262, 15);
        lblCourseFee.TabIndex = 2;
        lblCourseFee.Text = "Học phí chuẩn: 6.800.000 VNĐ · 24 buổi học";
        // 
        // cboCourse
        // 
        cboCourse.Location = new System.Drawing.Point(18, 38);
        cboCourse.Name = "cboCourse";
        cboCourse.Size = new System.Drawing.Size(360, 34);
        cboCourse.TabIndex = 1;
        // 
        // lblSelectCourseTitle
        // 
        lblSelectCourseTitle.AutoSize = true;
        lblSelectCourseTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSelectCourseTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSelectCourseTitle.Location = new System.Drawing.Point(18, 16);
        lblSelectCourseTitle.Name = "lblSelectCourseTitle";
        lblSelectCourseTitle.Size = new System.Drawing.Size(161, 17);
        lblSelectCourseTitle.TabIndex = 0;
        lblSelectCourseTitle.Text = "Chọn chương trình học (*):";
        // 
        // pnlStep3
        // 
        pnlStep3.Controls.Add(cardStep3);
        pnlStep3.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep3.Location = new System.Drawing.Point(20, 14);
        pnlStep3.Name = "pnlStep3";
        pnlStep3.Size = new System.Drawing.Size(744, 401);
        pnlStep3.TabIndex = 2;
        pnlStep3.Visible = false;
        // 
        // cardStep3
        // 
        cardStep3.BackColor = System.Drawing.Color.White;
        cardStep3.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStep3.BorderWidth = 1;
        cardStep3.Controls.Add(lblDebtSummary);
        cardStep3.Controls.Add(lblInitialPayment);
        cardStep3.Controls.Add(txtInitialPayment);
        cardStep3.Controls.Add(cboPaymentMethod);
        cardStep3.Controls.Add(lblPaymentMethod);
        cardStep3.Controls.Add(pnlInstallmentOptions);
        cardStep3.Controls.Add(lblInstallmentTitle);
        cardStep3.Controls.Add(cardSummaryInfo);
        cardStep3.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep3.Location = new System.Drawing.Point(0, 0);
        cardStep3.Name = "cardStep3";
        cardStep3.Padding = new System.Windows.Forms.Padding(18);
        cardStep3.Size = new System.Drawing.Size(744, 401);
        cardStep3.TabIndex = 0;
        // 
        // lblDebtSummary
        // 
        lblDebtSummary.AutoSize = true;
        lblDebtSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDebtSummary.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
        lblDebtSummary.Location = new System.Drawing.Point(18, 355);
        lblDebtSummary.Name = "lblDebtSummary";
        lblDebtSummary.Size = new System.Drawing.Size(370, 15);
        lblDebtSummary.TabIndex = 7;
        lblDebtSummary.Text = "Công nợ còn lại: 3.400.000 VNĐ · Đợt 2 hẹn thanh toán: 30/11/2026";
        // 
        // lblInitialPayment
        // 
        lblInitialPayment.AutoSize = true;
        lblInitialPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInitialPayment.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblInitialPayment.Location = new System.Drawing.Point(380, 275);
        lblInitialPayment.Name = "lblInitialPayment";
        lblInitialPayment.Size = new System.Drawing.Size(161, 15);
        lblInitialPayment.TabIndex = 6;
        lblInitialPayment.Text = "Số tiền thu thực tế đợt 1 (*):";
        // 
        // txtInitialPayment
        // 
        txtInitialPayment.Location = new System.Drawing.Point(380, 295);
        txtInitialPayment.Name = "txtInitialPayment";
        txtInitialPayment.Placeholder = "Số tiền thu đợt 1";
        txtInitialPayment.Size = new System.Drawing.Size(340, 34);
        txtInitialPayment.TabIndex = 5;
        // 
        // cboPaymentMethod
        // 
        cboPaymentMethod.Location = new System.Drawing.Point(18, 295);
        cboPaymentMethod.Name = "cboPaymentMethod";
        cboPaymentMethod.Size = new System.Drawing.Size(340, 34);
        cboPaymentMethod.TabIndex = 4;
        // 
        // lblPaymentMethod
        // 
        lblPaymentMethod.AutoSize = true;
        lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblPaymentMethod.Location = new System.Drawing.Point(18, 275);
        lblPaymentMethod.Name = "lblPaymentMethod";
        lblPaymentMethod.Size = new System.Drawing.Size(146, 15);
        lblPaymentMethod.TabIndex = 3;
        lblPaymentMethod.Text = "Phương thức thanh toán:";
        // 
        // pnlInstallmentOptions
        // 
        pnlInstallmentOptions.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlInstallmentOptions.Controls.Add(radPay3Installments);
        pnlInstallmentOptions.Controls.Add(radPay2Installments);
        pnlInstallmentOptions.Controls.Add(radPayFull);
        pnlInstallmentOptions.Location = new System.Drawing.Point(18, 175);
        pnlInstallmentOptions.Name = "pnlInstallmentOptions";
        pnlInstallmentOptions.Size = new System.Drawing.Size(702, 85);
        pnlInstallmentOptions.TabIndex = 2;
        // 
        // radPay3Installments
        // 
        radPay3Installments.AutoSize = true;
        radPay3Installments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        radPay3Installments.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPay3Installments.Location = new System.Drawing.Point(16, 56);
        radPay3Installments.Name = "radPay3Installments";
        radPay3Installments.Size = new System.Drawing.Size(465, 19);
        radPay3Installments.TabIndex = 2;
        radPay3Installments.Text = "Chia làm 3 đợt: Đợt 1 (40% - 2.720.000đ) · Đợt 2 (2.040.000đ) · Đợt 3 (2.040.000đ)";
        radPay3Installments.UseVisualStyleBackColor = true;
        // 
        // radPay2Installments
        // 
        radPay2Installments.AutoSize = true;
        radPay2Installments.Checked = true;
        radPay2Installments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        radPay2Installments.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPay2Installments.Location = new System.Drawing.Point(16, 32);
        radPay2Installments.Name = "radPay2Installments";
        radPay2Installments.Size = new System.Drawing.Size(425, 19);
        radPay2Installments.TabIndex = 1;
        radPay2Installments.TabStop = true;
        radPay2Installments.Text = "Chia làm 2 đợt: Đợt 1 (50% - 3.400.000đ) · Đợt 2 (50% nộp sau 30 ngày)";
        radPay2Installments.UseVisualStyleBackColor = true;
        // 
        // radPayFull
        // 
        radPayFull.AutoSize = true;
        radPayFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        radPayFull.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPayFull.Location = new System.Drawing.Point(16, 8);
        radPayFull.Name = "radPayFull";
        radPayFull.Size = new System.Drawing.Size(445, 19);
        radPayFull.TabIndex = 0;
        radPayFull.Text = "Đóng trọn gói 1 lần (100% - 6.800.000đ) · Miễn công nợ & Tặng giáo trình";
        radPayFull.UseVisualStyleBackColor = true;
        // 
        // lblInstallmentTitle
        // 
        lblInstallmentTitle.AutoSize = true;
        lblInstallmentTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblInstallmentTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblInstallmentTitle.Location = new System.Drawing.Point(18, 150);
        lblInstallmentTitle.Name = "lblInstallmentTitle";
        lblInstallmentTitle.Size = new System.Drawing.Size(375, 17);
        lblInstallmentTitle.TabIndex = 1;
        lblInstallmentTitle.Text = "Lựa chọn kế hoạch đóng học phí (Hỗ trợ đóng tối đa 3 đợt):";
        // 
        // cardSummaryInfo
        // 
        cardSummaryInfo.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        cardSummaryInfo.BorderColor = System.Drawing.Color.FromArgb(191, 219, 254);
        cardSummaryInfo.BorderWidth = 1;
        cardSummaryInfo.Controls.Add(lblSummaryFee);
        cardSummaryInfo.Controls.Add(lblSummaryClass);
        cardSummaryInfo.Controls.Add(lblSummaryStudent);
        cardSummaryInfo.Location = new System.Drawing.Point(18, 12);
        cardSummaryInfo.Name = "cardSummaryInfo";
        cardSummaryInfo.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        cardSummaryInfo.Size = new System.Drawing.Size(702, 120);
        cardSummaryInfo.TabIndex = 0;
        // 
        // lblSummaryFee
        // 
        lblSummaryFee.AutoSize = true;
        lblSummaryFee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryFee.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblSummaryFee.Location = new System.Drawing.Point(16, 80);
        lblSummaryFee.Name = "lblSummaryFee";
        lblSummaryFee.Size = new System.Drawing.Size(262, 20);
        lblSummaryFee.TabIndex = 2;
        lblSummaryFee.Text = "Tổng học phí khóa học: 6.800.000 đ";
        // 
        // lblSummaryClass
        // 
        lblSummaryClass.AutoSize = true;
        lblSummaryClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSummaryClass.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSummaryClass.Location = new System.Drawing.Point(16, 46);
        lblSummaryClass.Name = "lblSummaryClass";
        lblSummaryClass.Size = new System.Drawing.Size(438, 17);
        lblSummaryClass.TabIndex = 1;
        lblSummaryClass.Text = "Lớp ghi danh: IELTS-F01 · Phòng P201 (GV: Nguyễn Hoàng Anh · T3 / T6)";
        // 
        // lblSummaryStudent
        // 
        lblSummaryStudent.AutoSize = true;
        lblSummaryStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryStudent.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSummaryStudent.Location = new System.Drawing.Point(16, 14);
        lblSummaryStudent.Name = "lblSummaryStudent";
        lblSummaryStudent.Size = new System.Drawing.Size(326, 20);
        lblSummaryStudent.TabIndex = 0;
        lblSummaryStudent.Text = "Học viên: Nguyễn Minh Anh (0908 123 456)";
        // 
        // pnlStep4
        // 
        pnlStep4.Controls.Add(cardStep4);
        pnlStep4.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep4.Location = new System.Drawing.Point(20, 14);
        pnlStep4.Name = "pnlStep4";
        pnlStep4.Size = new System.Drawing.Size(744, 401);
        pnlStep4.TabIndex = 3;
        pnlStep4.Visible = false;
        // 
        // cardStep4
        // 
        cardStep4.BackColor = System.Drawing.Color.White;
        cardStep4.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStep4.BorderWidth = 1;
        cardStep4.Controls.Add(lblSuccessDesc);
        cardStep4.Controls.Add(lblSuccessTitle);
        cardStep4.Controls.Add(lblSuccessIcon);
        cardStep4.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep4.Location = new System.Drawing.Point(0, 0);
        cardStep4.Name = "cardStep4";
        cardStep4.Padding = new System.Windows.Forms.Padding(20);
        cardStep4.Size = new System.Drawing.Size(744, 401);
        cardStep4.TabIndex = 0;
        // 
        // lblSuccessDesc
        // 
        lblSuccessDesc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
        lblSuccessDesc.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSuccessDesc.Location = new System.Drawing.Point(72, 180);
        lblSuccessDesc.Name = "lblSuccessDesc";
        lblSuccessDesc.Size = new System.Drawing.Size(600, 140);
        lblSuccessDesc.TabIndex = 2;
        lblSuccessDesc.Text = "• Đã cấp mã học viên chính thức: HV-0242\r\n• Đã ghi danh vào lớp: IELTS-F01 (Khai giảng 02/11/2026)\r\n• Đã thu đợt 1 thành công: 3.400.000 VNĐ (Phiếu thu số: PT-261030-025)\r\n• Ghi nhận công nợ đợt 2: 3.400.000 VNĐ (Hạn thanh toán: 30/11/2026)\r\n\r\nHồ sơ đã được đồng bộ vào hệ thống và hiển thị trên danh sách học viên!";
        lblSuccessDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblSuccessTitle
        // 
        lblSuccessTitle.AutoSize = true;
        lblSuccessTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblSuccessTitle.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblSuccessTitle.Location = new System.Drawing.Point(232, 125);
        lblSuccessTitle.Name = "lblSuccessTitle";
        lblSuccessTitle.Size = new System.Drawing.Size(280, 30);
        lblSuccessTitle.TabIndex = 1;
        lblSuccessTitle.Text = "ĐĂNG KÝ HỌC THÀNH CÔNG!";
        // 
        // lblSuccessIcon
        // 
        lblSuccessIcon.Font = new System.Drawing.Font("Segoe UI", 36F);
        lblSuccessIcon.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblSuccessIcon.Location = new System.Drawing.Point(337, 45);
        lblSuccessIcon.Name = "lblSuccessIcon";
        lblSuccessIcon.Size = new System.Drawing.Size(70, 70);
        lblSuccessIcon.TabIndex = 0;
        lblSuccessIcon.Text = "✓";
        lblSuccessIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // StudentEnrollmentWizardDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(820, 710);
        Controls.Add(pnlBodyContainer);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "StudentEnrollmentWizardDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quy trình đăng ký học & Thanh toán học phí";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        pnlBodyContainer.ResumeLayout(false);
        pnlStep1.ResumeLayout(false);
        cardStep1.ResumeLayout(false);
        cardStep1.PerformLayout();
        pnlStep2.ResumeLayout(false);
        cardStep2.ResumeLayout(false);
        cardStep2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).EndInit();
        pnlStep3.ResumeLayout(false);
        cardStep3.ResumeLayout(false);
        cardStep3.PerformLayout();
        pnlInstallmentOptions.ResumeLayout(false);
        pnlInstallmentOptions.PerformLayout();
        cardSummaryInfo.ResumeLayout(false);
        cardSummaryInfo.PerformLayout();
        pnlStep4.ResumeLayout(false);
        cardStep4.ResumeLayout(false);
        cardStep4.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblStepBadge;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnBack;
    private ECMS.UI.Controls.AppButton btnNext;
    private System.Windows.Forms.Panel pnlBodyContainer;
    private System.Windows.Forms.Panel pnlStep1;
    private ECMS.UI.Controls.AppCard cardStep1;
    private System.Windows.Forms.Label lblInfoTitle;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblDob;
    private System.Windows.Forms.DateTimePicker dtpDob;
    private System.Windows.Forms.Label lblGender;
    private ECMS.UI.Controls.AppComboBox cboGender;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private System.Windows.Forms.Label lblAddress;
    private ECMS.UI.Controls.AppTextBox txtAddress;
    private System.Windows.Forms.Label lblParentName;
    private ECMS.UI.Controls.AppTextBox txtParentName;
    private System.Windows.Forms.Label lblParentPhone;
    private ECMS.UI.Controls.AppTextBox txtParentPhone;
    private System.Windows.Forms.Label lblNotes;
    private ECMS.UI.Controls.AppTextBox txtNotes;
    private ECMS.UI.Controls.AppBanner bannerCheckPhone;
    private System.Windows.Forms.Panel pnlStep2;
    private ECMS.UI.Controls.AppCard cardStep2;
    private System.Windows.Forms.Label lblSelectCourseTitle;
    private ECMS.UI.Controls.AppComboBox cboCourse;
    private System.Windows.Forms.Label lblCourseFee;
    private System.Windows.Forms.Label lblSelectClassTitle;
    private ECMS.UI.Controls.AppDataGrid dgvOpenClasses;
    private System.Windows.Forms.Panel pnlStep3;
    private ECMS.UI.Controls.AppCard cardStep3;
    private ECMS.UI.Controls.AppCard cardSummaryInfo;
    private System.Windows.Forms.Label lblSummaryStudent;
    private System.Windows.Forms.Label lblSummaryClass;
    private System.Windows.Forms.Label lblSummaryFee;
    private System.Windows.Forms.Label lblInstallmentTitle;
    private System.Windows.Forms.Panel pnlInstallmentOptions;
    private System.Windows.Forms.RadioButton radPayFull;
    private System.Windows.Forms.RadioButton radPay2Installments;
    private System.Windows.Forms.RadioButton radPay3Installments;
    private System.Windows.Forms.Label lblPaymentMethod;
    private ECMS.UI.Controls.AppComboBox cboPaymentMethod;
    private System.Windows.Forms.Label lblInitialPayment;
    private ECMS.UI.Controls.AppTextBox txtInitialPayment;
    private System.Windows.Forms.Label lblDebtSummary;
    private System.Windows.Forms.Panel pnlStep4;
    private ECMS.UI.Controls.AppCard cardStep4;
    private System.Windows.Forms.Label lblSuccessIcon;
    private System.Windows.Forms.Label lblSuccessTitle;
    private System.Windows.Forms.Label lblSuccessDesc;
}
