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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEnrollmentWizardDialog));
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnBack = new ECMS.UI.Controls.AppButton();
        btnSaveWaiting = new ECMS.UI.Controls.AppButton();
        btnConfirmNoPay = new ECMS.UI.Controls.AppButton();
        btnNext = new ECMS.UI.Controls.AppButton();
        tabSteps = new System.Windows.Forms.TabControl();
        tpStep1 = new System.Windows.Forms.TabPage();
        tpStep2 = new System.Windows.Forms.TabPage();
        pnlStep1 = new System.Windows.Forms.Panel();
        cardStep1 = new ECMS.UI.Controls.AppCard();
        txtNotes = new ECMS.UI.Controls.AppTextBox();
        lblNotes = new System.Windows.Forms.Label();
        cboRelationship = new ECMS.UI.Controls.AppComboBox();
        lblRelationship = new System.Windows.Forms.Label();
        txtParentPhone = new ECMS.UI.Controls.AppTextBox();
        lblParentPhone = new System.Windows.Forms.Label();
        txtParentName = new ECMS.UI.Controls.AppTextBox();
        lblParentName = new System.Windows.Forms.Label();
        lblSec2Title = new System.Windows.Forms.Label();
        pnlSecDivider = new System.Windows.Forms.Panel();
        txtAddress = new ECMS.UI.Controls.AppTextBox();
        lblAddress = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        cboGender = new ECMS.UI.Controls.AppComboBox();
        lblGender = new System.Windows.Forms.Label();
        dtpDob = new System.Windows.Forms.DateTimePicker();
        lblDob = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        lblSec1Title = new System.Windows.Forms.Label();
        pnlStep2 = new System.Windows.Forms.Panel();
        cardStep2 = new ECMS.UI.Controls.AppCard();
        pnlBottomFeeSummary = new System.Windows.Forms.Panel();
        lblBottomTuitionFee = new System.Windows.Forms.Label();
        dgvOpenClasses = new ECMS.UI.Controls.AppDataGrid();
        pnlTableToolbar = new System.Windows.Forms.Panel();
        cboAvailabilityFilter = new ECMS.UI.Controls.AppComboBox();
        cboShiftFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        cboCourse = new ECMS.UI.Controls.AppComboBox();
        lblSelectCourseTitle = new System.Windows.Forms.Label();
        pnlStep3 = new System.Windows.Forms.Panel();
        cardStep3 = new ECMS.UI.Controls.AppCard();
        lblDebtSummary = new System.Windows.Forms.Label();
        lblInitialPayment = new System.Windows.Forms.Label();
        txtInitialPayment = new ECMS.UI.Controls.AppTextBox();
        cboPaymentMethod = new ECMS.UI.Controls.AppComboBox();
        lblPaymentMethod = new System.Windows.Forms.Label();
        cboDiscount = new ECMS.UI.Controls.AppComboBox();
        lblDiscount = new System.Windows.Forms.Label();
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
        cardAdmissionSlip = new ECMS.UI.Controls.AppCard();
        lblSlipDetails = new System.Windows.Forms.Label();
        lblSlipStudentCodeVal = new System.Windows.Forms.Label();
        lblSlipStudentCode = new System.Windows.Forms.Label();
        lblSlipHeader = new System.Windows.Forms.Label();
        lblSuccessSubtitle = new System.Windows.Forms.Label();
        lblSuccessTitle = new System.Windows.Forms.Label();
        lblSuccessIcon = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        tabSteps.SuspendLayout();
        tpStep1.SuspendLayout();
        tpStep2.SuspendLayout();
        pnlStep1.SuspendLayout();
        cardStep1.SuspendLayout();
        pnlStep2.SuspendLayout();
        cardStep2.SuspendLayout();
        pnlBottomFeeSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).BeginInit();
        pnlTableToolbar.SuspendLayout();
        pnlStep3.SuspendLayout();
        cardStep3.SuspendLayout();
        pnlInstallmentOptions.SuspendLayout();
        cardSummaryInfo.SuspendLayout();
        pnlStep4.SuspendLayout();
        cardStep4.SuspendLayout();
        cardAdmissionSlip.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(28, 14, 28, 10);
        pnlHeader.Size = new System.Drawing.Size(980, 78);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(28, 46);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(422, 21);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Bước 1 / 4: Điền thông tin cá nhân và người liên hệ học viên";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(26, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(322, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đăng ký nhập học & Xếp lớp";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnBack);
        pnlFooter.Controls.Add(btnSaveWaiting);
        pnlFooter.Controls.Add(btnConfirmNoPay);
        pnlFooter.Controls.Add(btnNext);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 680);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(28, 12, 28, 12);
        pnlFooter.Size = new System.Drawing.Size(980, 60);
        pnlFooter.TabIndex = 1;
        // 
        // btnSaveWaiting
        // 
        btnSaveWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSaveWaiting.BackColor = System.Drawing.Color.White;
        btnSaveWaiting.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnSaveWaiting.CornerRadius = 6;
        btnSaveWaiting.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveWaiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveWaiting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnSaveWaiting.Location = new System.Drawing.Point(605, 12);
        btnSaveWaiting.Name = "btnSaveWaiting";
        btnSaveWaiting.Size = new System.Drawing.Size(185, 36);
        btnSaveWaiting.TabIndex = 4;
        btnSaveWaiting.Text = "Lưu (Chờ xếp lớp)";
        btnSaveWaiting.UseVisualStyleBackColor = false;
        btnSaveWaiting.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnBack
        // 
        btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBack.BackColor = System.Drawing.Color.White;
        btnBack.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBack.CornerRadius = 6;
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnBack.Location = new System.Drawing.Point(470, 12);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(115, 36);
        btnBack.TabIndex = 1;
        btnBack.Text = "Quay lại";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnBack.Visible = false;
        // 
        // btnConfirmNoPay
        // 
        btnConfirmNoPay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnConfirmNoPay.BackColor = System.Drawing.Color.White;
        btnConfirmNoPay.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnConfirmNoPay.CornerRadius = 6;
        btnConfirmNoPay.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmNoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmNoPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnConfirmNoPay.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnConfirmNoPay.Location = new System.Drawing.Point(595, 12);
        btnConfirmNoPay.Name = "btnConfirmNoPay";
        btnConfirmNoPay.Size = new System.Drawing.Size(195, 36);
        btnConfirmNoPay.TabIndex = 3;
        btnConfirmNoPay.Text = "Xác nhận (Chưa thu phí)";
        btnConfirmNoPay.UseVisualStyleBackColor = false;
        btnConfirmNoPay.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnConfirmNoPay.Visible = false;
        // 
        // btnNext
        // 
        btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnNext.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnNext.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnNext.CornerRadius = 6;
        btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNext.FlatAppearance.BorderSize = 0;
        btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnNext.ForeColor = System.Drawing.Color.White;
        btnNext.Location = new System.Drawing.Point(800, 12);
        btnNext.Name = "btnNext";
        btnNext.Size = new System.Drawing.Size(150, 36);
        btnNext.TabIndex = 2;
        btnNext.Text = "Tiếp tục";
        btnNext.UseVisualStyleBackColor = false;
        btnNext.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // tabSteps
        // 
        tabSteps.Controls.Add(tpStep1);
        tabSteps.Controls.Add(tpStep2);
        tabSteps.Dock = System.Windows.Forms.DockStyle.Fill;
        tabSteps.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabSteps.Location = new System.Drawing.Point(0, 78);
        tabSteps.Name = "tabSteps";
        tabSteps.Padding = new System.Drawing.Point(16, 6);
        tabSteps.SelectedIndex = 0;
        tabSteps.Size = new System.Drawing.Size(980, 602);
        tabSteps.TabIndex = 2;
        // 
        // tpStep1
        // 
        tpStep1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        tpStep1.Controls.Add(pnlStep1);
        tpStep1.Location = new System.Drawing.Point(4, 30);
        tpStep1.Name = "tpStep1";
        tpStep1.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
        tpStep1.Size = new System.Drawing.Size(972, 568);
        tpStep1.TabIndex = 0;
        tpStep1.Text = "Bước 1: Thông tin học viên";
        // 
        // tpStep2
        // 
        tpStep2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        tpStep2.Controls.Add(pnlStep2);
        tpStep2.Location = new System.Drawing.Point(4, 30);
        tpStep2.Name = "tpStep2";
        tpStep2.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
        tpStep2.Size = new System.Drawing.Size(972, 568);
        tpStep2.TabIndex = 1;
        tpStep2.Text = "Bước 2: Chọn khóa học & lớp học";
        // 
        // pnlStep1
        // 
        pnlStep1.Controls.Add(cardStep1);
        pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep1.Location = new System.Drawing.Point(24, 14);
        pnlStep1.Name = "pnlStep1";
        pnlStep1.Size = new System.Drawing.Size(932, 574);
        pnlStep1.TabIndex = 0;
        // 
        // cardStep1
        // 
        cardStep1.BackColor = System.Drawing.Color.White;
        cardStep1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStep1.BorderWidth = 1;
        cardStep1.Controls.Add(txtNotes);
        cardStep1.Controls.Add(lblNotes);
        cardStep1.Controls.Add(cboRelationship);
        cardStep1.Controls.Add(lblRelationship);
        cardStep1.Controls.Add(txtParentPhone);
        cardStep1.Controls.Add(lblParentPhone);
        cardStep1.Controls.Add(txtParentName);
        cardStep1.Controls.Add(lblParentName);
        cardStep1.Controls.Add(lblSec2Title);
        cardStep1.Controls.Add(pnlSecDivider);
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
        cardStep1.Controls.Add(lblSec1Title);
        cardStep1.CornerRadius = 8;
        cardStep1.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep1.Location = new System.Drawing.Point(0, 0);
        cardStep1.Name = "cardStep1";
        cardStep1.Padding = new System.Windows.Forms.Padding(24);
        cardStep1.Size = new System.Drawing.Size(932, 574);
        cardStep1.TabIndex = 0;
        // 
        // txtNotes
        // 
        txtNotes.BackColor = System.Drawing.Color.Transparent;
        txtNotes.CornerRadius = 5;
        txtNotes.ErrorMessage = "";
        txtNotes.HasError = false;
        txtNotes.Location = new System.Drawing.Point(24, 410);
        txtNotes.Name = "txtNotes";
        txtNotes.Placeholder = "Mục tiêu điểm số, ca học mong muốn hoặc ghi chú bảo lãnh...";
        txtNotes.ReadOnly = false;
        txtNotes.Size = new System.Drawing.Size(856, 52);
        txtNotes.TabIndex = 22;
        txtNotes.UseSystemPasswordChar = false;
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblNotes.Location = new System.Drawing.Point(24, 386);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(128, 20);
        lblNotes.TabIndex = 21;
        lblNotes.Text = "Ghi chú tuyển sinh";
        // 
        // cboRelationship
        // 
        cboRelationship.BackColor = System.Drawing.Color.Transparent;
        cboRelationship.CornerRadius = 5;
        cboRelationship.DataSource = null;
        cboRelationship.DisplayMember = "";
        cboRelationship.Location = new System.Drawing.Point(680, 338);
        cboRelationship.Name = "cboRelationship";
        cboRelationship.SelectedIndex = -1;
        cboRelationship.SelectedItem = null;
        cboRelationship.SelectedValue = null;
        cboRelationship.Size = new System.Drawing.Size(200, 36);
        cboRelationship.TabIndex = 20;
        cboRelationship.ValueMember = "";
        // 
        // lblRelationship
        // 
        lblRelationship.AutoSize = true;
        lblRelationship.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblRelationship.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblRelationship.Location = new System.Drawing.Point(680, 314);
        lblRelationship.Name = "lblRelationship";
        lblRelationship.Size = new System.Drawing.Size(92, 20);
        lblRelationship.TabIndex = 19;
        lblRelationship.Text = "Mối quan hệ";
        // 
        // txtParentPhone
        // 
        txtParentPhone.BackColor = System.Drawing.Color.Transparent;
        txtParentPhone.CornerRadius = 5;
        txtParentPhone.ErrorMessage = "";
        txtParentPhone.HasError = false;
        txtParentPhone.Location = new System.Drawing.Point(400, 338);
        txtParentPhone.Name = "txtParentPhone";
        txtParentPhone.Placeholder = "VD: 0911 556 889";
        txtParentPhone.ReadOnly = false;
        txtParentPhone.Size = new System.Drawing.Size(260, 36);
        txtParentPhone.TabIndex = 18;
        txtParentPhone.UseSystemPasswordChar = false;
        // 
        // lblParentPhone
        // 
        lblParentPhone.AutoSize = true;
        lblParentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblParentPhone.Location = new System.Drawing.Point(400, 314);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(108, 20);
        lblParentPhone.TabIndex = 17;
        lblParentPhone.Text = "SĐT phụ huynh";
        // 
        // txtParentName
        // 
        txtParentName.BackColor = System.Drawing.Color.Transparent;
        txtParentName.CornerRadius = 5;
        txtParentName.ErrorMessage = "";
        txtParentName.HasError = false;
        txtParentName.Location = new System.Drawing.Point(24, 338);
        txtParentName.Name = "txtParentName";
        txtParentName.Placeholder = "Họ và tên phụ huynh / người giám hộ...";
        txtParentName.ReadOnly = false;
        txtParentName.Size = new System.Drawing.Size(350, 36);
        txtParentName.TabIndex = 16;
        txtParentName.UseSystemPasswordChar = false;
        // 
        // lblParentName
        // 
        lblParentName.AutoSize = true;
        lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblParentName.Location = new System.Drawing.Point(24, 314);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new System.Drawing.Size(145, 20);
        lblParentName.TabIndex = 15;
        lblParentName.Text = "Họ tên người liên hệ";
        // 
        // lblSec2Title
        // 
        lblSec2Title.AutoSize = true;
        lblSec2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSec2Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSec2Title.Location = new System.Drawing.Point(24, 280);
        lblSec2Title.Name = "lblSec2Title";
        lblSec2Title.Size = new System.Drawing.Size(267, 25);
        lblSec2Title.TabIndex = 14;
        lblSec2Title.Text = "‍2. Người liên hệ / Phụ huynh";
        // 
        // pnlSecDivider
        // 
        pnlSecDivider.BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        pnlSecDivider.Location = new System.Drawing.Point(24, 268);
        pnlSecDivider.Name = "pnlSecDivider";
        pnlSecDivider.Size = new System.Drawing.Size(856, 1);
        pnlSecDivider.TabIndex = 13;
        // 
        // txtAddress
        // 
        txtAddress.BackColor = System.Drawing.Color.Transparent;
        txtAddress.CornerRadius = 5;
        txtAddress.ErrorMessage = "";
        txtAddress.HasError = false;
        txtAddress.Location = new System.Drawing.Point(24, 216);
        txtAddress.Name = "txtAddress";
        txtAddress.Placeholder = "Số nhà, tên đường, phường/xã, quận/huyện...";
        txtAddress.ReadOnly = false;
        txtAddress.Size = new System.Drawing.Size(856, 36);
        txtAddress.TabIndex = 12;
        txtAddress.UseSystemPasswordChar = false;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblAddress.Location = new System.Drawing.Point(24, 192);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(103, 20);
        lblAddress.TabIndex = 11;
        lblAddress.Text = "Địa chỉ liên hệ";
        // 
        // txtEmail
        // 
        txtEmail.BackColor = System.Drawing.Color.Transparent;
        txtEmail.CornerRadius = 5;
        txtEmail.ErrorMessage = "";
        txtEmail.HasError = false;
        txtEmail.Location = new System.Drawing.Point(430, 146);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "VD: student@email.com";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(450, 36);
        txtEmail.TabIndex = 10;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblEmail.Location = new System.Drawing.Point(430, 122);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(46, 20);
        lblEmail.TabIndex = 9;
        lblEmail.Text = "Email";
        // 
        // txtPhone
        // 
        txtPhone.BackColor = System.Drawing.Color.Transparent;
        txtPhone.CornerRadius = 5;
        txtPhone.ErrorMessage = "";
        txtPhone.HasError = false;
        txtPhone.Location = new System.Drawing.Point(24, 146);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "VD: 0908 123 456";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(380, 36);
        txtPhone.TabIndex = 8;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblPhone.Location = new System.Drawing.Point(24, 122);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(107, 20);
        lblPhone.TabIndex = 7;
        lblPhone.Text = "Số điện thoại *";
        // 
        // cboGender
        // 
        cboGender.BackColor = System.Drawing.Color.Transparent;
        cboGender.CornerRadius = 5;
        cboGender.DataSource = null;
        cboGender.DisplayMember = "";
        cboGender.Location = new System.Drawing.Point(650, 76);
        cboGender.Name = "cboGender";
        cboGender.SelectedIndex = -1;
        cboGender.SelectedItem = null;
        cboGender.SelectedValue = null;
        cboGender.Size = new System.Drawing.Size(230, 36);
        cboGender.TabIndex = 6;
        cboGender.ValueMember = "";
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblGender.Location = new System.Drawing.Point(650, 52);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(75, 20);
        lblGender.TabIndex = 5;
        lblGender.Text = "Giới tính *";
        // 
        // dtpDob
        // 
        dtpDob.CustomFormat = "dd/MM/yyyy";
        dtpDob.Font = new System.Drawing.Font("Segoe UI", 10F);
        dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDob.Location = new System.Drawing.Point(430, 79);
        dtpDob.Name = "dtpDob";
        dtpDob.Size = new System.Drawing.Size(190, 30);
        dtpDob.TabIndex = 4;
        // 
        // lblDob
        // 
        lblDob.AutoSize = true;
        lblDob.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblDob.Location = new System.Drawing.Point(430, 52);
        lblDob.Name = "lblDob";
        lblDob.Size = new System.Drawing.Size(84, 20);
        lblDob.TabIndex = 3;
        lblDob.Text = "Ngày sinh *";
        // 
        // txtFullName
        // 
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(24, 76);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên học viên...";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(380, 36);
        txtFullName.TabIndex = 2;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblFullName.Location = new System.Drawing.Point(24, 52);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(83, 20);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Họ và tên *";
        // 
        // lblSec1Title
        // 
        lblSec1Title.AutoSize = true;
        lblSec1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSec1Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSec1Title.Location = new System.Drawing.Point(24, 16);
        lblSec1Title.Name = "lblSec1Title";
        lblSec1Title.Size = new System.Drawing.Size(273, 25);
        lblSec1Title.TabIndex = 0;
        lblSec1Title.Text = "1. Thông tin cá nhân học viên";
        // 
        // pnlStep2
        // 
        pnlStep2.Controls.Add(cardStep2);
        pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep2.Location = new System.Drawing.Point(20, 12);
        pnlStep2.Name = "pnlStep2";
        pnlStep2.Size = new System.Drawing.Size(932, 544);
        pnlStep2.TabIndex = 1;
        // 
        // cardStep2
        // 
        cardStep2.BackColor = System.Drawing.Color.White;
        cardStep2.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStep2.BorderWidth = 1;
        cardStep2.Controls.Add(pnlBottomFeeSummary);
        cardStep2.Controls.Add(dgvOpenClasses);
        cardStep2.Controls.Add(pnlTableToolbar);
        cardStep2.Controls.Add(cboCourse);
        cardStep2.Controls.Add(lblSelectCourseTitle);
        cardStep2.CornerRadius = 8;
        cardStep2.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep2.Location = new System.Drawing.Point(0, 0);
        cardStep2.Name = "cardStep2";
        cardStep2.Padding = new System.Windows.Forms.Padding(24);
        cardStep2.Size = new System.Drawing.Size(932, 544);
        cardStep2.TabIndex = 0;
        // 
        // pnlBottomFeeSummary
        // 
        pnlBottomFeeSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        pnlBottomFeeSummary.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        pnlBottomFeeSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlBottomFeeSummary.Controls.Add(lblBottomTuitionFee);
        pnlBottomFeeSummary.Location = new System.Drawing.Point(568, 476);
        pnlBottomFeeSummary.Name = "pnlBottomFeeSummary";
        pnlBottomFeeSummary.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
        pnlBottomFeeSummary.Size = new System.Drawing.Size(340, 46);
        pnlBottomFeeSummary.TabIndex = 4;
        // 
        // lblBottomTuitionFee
        // 
        lblBottomTuitionFee.Dock = System.Windows.Forms.DockStyle.Fill;
        lblBottomTuitionFee.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblBottomTuitionFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblBottomTuitionFee.Location = new System.Drawing.Point(14, 0);
        lblBottomTuitionFee.Name = "lblBottomTuitionFee";
        lblBottomTuitionFee.Size = new System.Drawing.Size(310, 44);
        lblBottomTuitionFee.TabIndex = 0;
        lblBottomTuitionFee.Text = "Tổng học phí: 6.800.000 VNĐ";
        lblBottomTuitionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // dgvOpenClasses
        // 
        dgvOpenClasses.AllowUserToAddRows = false;
        dgvOpenClasses.AllowUserToDeleteRows = false;
        dgvOpenClasses.AllowUserToResizeColumns = false;
        dgvOpenClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvOpenClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvOpenClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvOpenClasses.BackgroundColor = System.Drawing.Color.White;
        dgvOpenClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvOpenClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvOpenClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvOpenClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvOpenClasses.ColumnHeadersHeight = 40;
        dgvOpenClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvOpenClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvOpenClasses.EnableHeadersVisualStyles = false;
        dgvOpenClasses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvOpenClasses.Location = new System.Drawing.Point(24, 148);
        dgvOpenClasses.MultiSelect = false;
        dgvOpenClasses.Name = "dgvOpenClasses";
        dgvOpenClasses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvOpenClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvOpenClasses.RowHeadersVisible = false;
        dgvOpenClasses.RowHeadersWidth = 51;
        dgvOpenClasses.RowTemplate.Height = 44;
        dgvOpenClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvOpenClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvOpenClasses.Size = new System.Drawing.Size(884, 300);
        dgvOpenClasses.TabIndex = 3;
        // 
        // pnlTableToolbar
        // 
        pnlTableToolbar.BackColor = System.Drawing.Color.Transparent;
        pnlTableToolbar.Controls.Add(cboAvailabilityFilter);
        pnlTableToolbar.Controls.Add(cboShiftFilter);
        pnlTableToolbar.Controls.Add(txtSearchClass);
        pnlTableToolbar.Location = new System.Drawing.Point(24, 96);
        pnlTableToolbar.Name = "pnlTableToolbar";
        pnlTableToolbar.Size = new System.Drawing.Size(884, 40);
        pnlTableToolbar.TabIndex = 2;
        // 
        // cboAvailabilityFilter
        // 
        cboAvailabilityFilter.BackColor = System.Drawing.Color.Transparent;
        cboAvailabilityFilter.CornerRadius = 5;
        cboAvailabilityFilter.DataSource = null;
        cboAvailabilityFilter.DisplayMember = "";
        cboAvailabilityFilter.Location = new System.Drawing.Point(670, 0);
        cboAvailabilityFilter.Name = "cboAvailabilityFilter";
        cboAvailabilityFilter.SelectedIndex = -1;
        cboAvailabilityFilter.SelectedItem = null;
        cboAvailabilityFilter.SelectedValue = null;
        cboAvailabilityFilter.Size = new System.Drawing.Size(214, 36);
        cboAvailabilityFilter.TabIndex = 2;
        cboAvailabilityFilter.ValueMember = "";
        // 
        // cboShiftFilter
        // 
        cboShiftFilter.BackColor = System.Drawing.Color.Transparent;
        cboShiftFilter.CornerRadius = 5;
        cboShiftFilter.DataSource = null;
        cboShiftFilter.DisplayMember = "";
        cboShiftFilter.Location = new System.Drawing.Point(435, 0);
        cboShiftFilter.Name = "cboShiftFilter";
        cboShiftFilter.SelectedIndex = -1;
        cboShiftFilter.SelectedItem = null;
        cboShiftFilter.SelectedValue = null;
        cboShiftFilter.Size = new System.Drawing.Size(220, 36);
        cboShiftFilter.TabIndex = 1;
        cboShiftFilter.ValueMember = "";
        // 
        // txtSearchClass
        // 
        txtSearchClass.BackColor = System.Drawing.Color.Transparent;
        txtSearchClass.CornerRadius = 5;
        txtSearchClass.ErrorMessage = "";
        txtSearchClass.HasError = false;
        txtSearchClass.Location = new System.Drawing.Point(0, 0);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍 Tìm nhanh theo mã lớp, giáo viên, phòng học...";
        txtSearchClass.ReadOnly = false;
        txtSearchClass.Size = new System.Drawing.Size(420, 36);
        txtSearchClass.TabIndex = 0;
        txtSearchClass.UseSystemPasswordChar = false;
        // 
        // cboCourse
        // 
        cboCourse.BackColor = System.Drawing.Color.Transparent;
        cboCourse.CornerRadius = 5;
        cboCourse.DataSource = null;
        cboCourse.DisplayMember = "";
        cboCourse.Location = new System.Drawing.Point(24, 44);
        cboCourse.Name = "cboCourse";
        cboCourse.SelectedIndex = -1;
        cboCourse.SelectedItem = null;
        cboCourse.SelectedValue = null;
        cboCourse.Size = new System.Drawing.Size(500, 36);
        cboCourse.TabIndex = 1;
        cboCourse.ValueMember = "";
        // 
        // lblSelectCourseTitle
        // 
        lblSelectCourseTitle.AutoSize = true;
        lblSelectCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblSelectCourseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSelectCourseTitle.Location = new System.Drawing.Point(24, 16);
        lblSelectCourseTitle.Name = "lblSelectCourseTitle";
        lblSelectCourseTitle.Size = new System.Drawing.Size(227, 25);
        lblSelectCourseTitle.TabIndex = 0;
        lblSelectCourseTitle.Text = "Chương trình đào tạo (*):";
        // 
        // pnlStep3
        // 
        pnlStep3.Controls.Add(cardStep3);
        pnlStep3.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep3.Location = new System.Drawing.Point(24, 14);
        pnlStep3.Name = "pnlStep3";
        pnlStep3.Size = new System.Drawing.Size(932, 574);
        pnlStep3.TabIndex = 2;
        pnlStep3.Visible = false;
        // 
        // cardStep3
        // 
        cardStep3.BackColor = System.Drawing.Color.White;
        cardStep3.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStep3.BorderWidth = 1;
        cardStep3.Controls.Add(lblDebtSummary);
        cardStep3.Controls.Add(lblInitialPayment);
        cardStep3.Controls.Add(txtInitialPayment);
        cardStep3.Controls.Add(cboPaymentMethod);
        cardStep3.Controls.Add(lblPaymentMethod);
        cardStep3.Controls.Add(cboDiscount);
        cardStep3.Controls.Add(lblDiscount);
        cardStep3.Controls.Add(pnlInstallmentOptions);
        cardStep3.Controls.Add(lblInstallmentTitle);
        cardStep3.Controls.Add(cardSummaryInfo);
        cardStep3.CornerRadius = 8;
        cardStep3.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep3.Location = new System.Drawing.Point(0, 0);
        cardStep3.Name = "cardStep3";
        cardStep3.Padding = new System.Windows.Forms.Padding(24);
        cardStep3.Size = new System.Drawing.Size(932, 574);
        cardStep3.TabIndex = 0;
        // 
        // lblDebtSummary
        // 
        lblDebtSummary.AutoSize = true;
        lblDebtSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblDebtSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)217)), ((int)((byte)119)), ((int)((byte)6)));
        lblDebtSummary.Location = new System.Drawing.Point(24, 436);
        lblDebtSummary.Name = "lblDebtSummary";
        lblDebtSummary.Size = new System.Drawing.Size(560, 23);
        lblDebtSummary.TabIndex = 9;
        lblDebtSummary.Text = "Công nợ còn lại: 3.400.000 VNĐ · Đợt 2 hẹn thanh toán: 30/11/2026";
        // 
        // lblInitialPayment
        // 
        lblInitialPayment.AutoSize = true;
        lblInitialPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInitialPayment.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblInitialPayment.Location = new System.Drawing.Point(24, 360);
        lblInitialPayment.Name = "lblInitialPayment";
        lblInitialPayment.Size = new System.Drawing.Size(207, 20);
        lblInitialPayment.TabIndex = 7;
        lblInitialPayment.Text = "Số tiền thu thực tế đợt 1 (*):";
        // 
        // txtInitialPayment
        // 
        txtInitialPayment.BackColor = System.Drawing.Color.Transparent;
        txtInitialPayment.CornerRadius = 5;
        txtInitialPayment.ErrorMessage = "";
        txtInitialPayment.HasError = false;
        txtInitialPayment.Location = new System.Drawing.Point(24, 384);
        txtInitialPayment.Name = "txtInitialPayment";
        txtInitialPayment.Placeholder = "Nhập số tiền thực thu...";
        txtInitialPayment.ReadOnly = false;
        txtInitialPayment.Size = new System.Drawing.Size(420, 36);
        txtInitialPayment.TabIndex = 8;
        txtInitialPayment.UseSystemPasswordChar = false;
        // 
        // cboPaymentMethod
        // 
        cboPaymentMethod.BackColor = System.Drawing.Color.Transparent;
        cboPaymentMethod.CornerRadius = 5;
        cboPaymentMethod.DataSource = null;
        cboPaymentMethod.DisplayMember = "";
        cboPaymentMethod.Location = new System.Drawing.Point(470, 310);
        cboPaymentMethod.Name = "cboPaymentMethod";
        cboPaymentMethod.SelectedIndex = -1;
        cboPaymentMethod.SelectedItem = null;
        cboPaymentMethod.SelectedValue = null;
        cboPaymentMethod.Size = new System.Drawing.Size(438, 36);
        cboPaymentMethod.TabIndex = 6;
        cboPaymentMethod.ValueMember = "";
        // 
        // lblPaymentMethod
        // 
        lblPaymentMethod.AutoSize = true;
        lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblPaymentMethod.Location = new System.Drawing.Point(470, 286);
        lblPaymentMethod.Name = "lblPaymentMethod";
        lblPaymentMethod.Size = new System.Drawing.Size(185, 20);
        lblPaymentMethod.TabIndex = 5;
        lblPaymentMethod.Text = "Phương thức thanh toán:";
        // 
        // cboDiscount
        // 
        cboDiscount.BackColor = System.Drawing.Color.Transparent;
        cboDiscount.CornerRadius = 5;
        cboDiscount.DataSource = null;
        cboDiscount.DisplayMember = "";
        cboDiscount.Location = new System.Drawing.Point(24, 310);
        cboDiscount.Name = "cboDiscount";
        cboDiscount.SelectedIndex = -1;
        cboDiscount.SelectedItem = null;
        cboDiscount.SelectedValue = null;
        cboDiscount.Size = new System.Drawing.Size(420, 36);
        cboDiscount.TabIndex = 4;
        cboDiscount.ValueMember = "";
        // 
        // lblDiscount
        // 
        lblDiscount.AutoSize = true;
        lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDiscount.Location = new System.Drawing.Point(24, 286);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new System.Drawing.Size(188, 20);
        lblDiscount.TabIndex = 3;
        lblDiscount.Text = "Chính sách ưu đãi / Giảm:";
        // 
        // pnlInstallmentOptions
        // 
        pnlInstallmentOptions.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlInstallmentOptions.Controls.Add(radPay3Installments);
        pnlInstallmentOptions.Controls.Add(radPay2Installments);
        pnlInstallmentOptions.Controls.Add(radPayFull);
        pnlInstallmentOptions.Location = new System.Drawing.Point(24, 168);
        pnlInstallmentOptions.Name = "pnlInstallmentOptions";
        pnlInstallmentOptions.Size = new System.Drawing.Size(884, 105);
        pnlInstallmentOptions.TabIndex = 2;
        // 
        // radPay3Installments
        // 
        radPay3Installments.AutoSize = true;
        radPay3Installments.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPay3Installments.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        radPay3Installments.Location = new System.Drawing.Point(18, 70);
        radPay3Installments.Name = "radPay3Installments";
        radPay3Installments.Size = new System.Drawing.Size(633, 25);
        radPay3Installments.TabIndex = 2;
        radPay3Installments.Text = ("Chia làm 3 đợt: Đợt 1 (40% - 2.720.000đ) · Đợt 2 (2.040.000đ) · Đợt 3 (2.040.000đ" + ")");
        radPay3Installments.UseVisualStyleBackColor = true;
        // 
        // radPay2Installments
        // 
        radPay2Installments.AutoSize = true;
        radPay2Installments.Checked = true;
        radPay2Installments.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPay2Installments.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        radPay2Installments.Location = new System.Drawing.Point(18, 40);
        radPay2Installments.Name = "radPay2Installments";
        radPay2Installments.Size = new System.Drawing.Size(562, 25);
        radPay2Installments.TabIndex = 1;
        radPay2Installments.TabStop = true;
        radPay2Installments.Text = "Chia làm 2 đợt: Đợt 1 (50% - 3.400.000đ) · Đợt 2 (50% nộp sau 30 ngày)";
        radPay2Installments.UseVisualStyleBackColor = true;
        // 
        // radPayFull
        // 
        radPayFull.AutoSize = true;
        radPayFull.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPayFull.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        radPayFull.Location = new System.Drawing.Point(18, 10);
        radPayFull.Name = "radPayFull";
        radPayFull.Size = new System.Drawing.Size(584, 25);
        radPayFull.TabIndex = 0;
        radPayFull.Text = "Đóng trọn gói 1 lần (100% - 6.800.000đ) · Tặng giáo trình + Miễn công nợ";
        radPayFull.UseVisualStyleBackColor = true;
        // 
        // lblInstallmentTitle
        // 
        lblInstallmentTitle.AutoSize = true;
        lblInstallmentTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblInstallmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblInstallmentTitle.Location = new System.Drawing.Point(24, 138);
        lblInstallmentTitle.Name = "lblInstallmentTitle";
        lblInstallmentTitle.Size = new System.Drawing.Size(471, 25);
        lblInstallmentTitle.TabIndex = 1;
        lblInstallmentTitle.Text = "Kế hoạch đóng học phí (Hỗ trợ tối đa 3 đợt linh hoạt):";
        // 
        // cardSummaryInfo
        // 
        cardSummaryInfo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        cardSummaryInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)191)), ((int)((byte)219)), ((int)((byte)254)));
        cardSummaryInfo.BorderWidth = 1;
        cardSummaryInfo.Controls.Add(lblSummaryFee);
        cardSummaryInfo.Controls.Add(lblSummaryClass);
        cardSummaryInfo.Controls.Add(lblSummaryStudent);
        cardSummaryInfo.CornerRadius = 6;
        cardSummaryInfo.Location = new System.Drawing.Point(24, 16);
        cardSummaryInfo.Name = "cardSummaryInfo";
        cardSummaryInfo.Padding = new System.Windows.Forms.Padding(18, 12, 18, 12);
        cardSummaryInfo.Size = new System.Drawing.Size(884, 110);
        cardSummaryInfo.TabIndex = 0;
        // 
        // lblSummaryFee
        // 
        lblSummaryFee.AutoSize = true;
        lblSummaryFee.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblSummaryFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblSummaryFee.Location = new System.Drawing.Point(16, 72);
        lblSummaryFee.Name = "lblSummaryFee";
        lblSummaryFee.Size = new System.Drawing.Size(349, 28);
        lblSummaryFee.TabIndex = 2;
        lblSummaryFee.Text = "Tổng học phí niêm yết: 6.800.000 đ";
        // 
        // lblSummaryClass
        // 
        lblSummaryClass.AutoSize = true;
        lblSummaryClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSummaryClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSummaryClass.Location = new System.Drawing.Point(16, 44);
        lblSummaryClass.Name = "lblSummaryClass";
        lblSummaryClass.Size = new System.Drawing.Size(517, 21);
        lblSummaryClass.TabIndex = 1;
        lblSummaryClass.Text = "Lớp: IELTS-F01 · IELTS Foundation · Phòng P201 (GV: Nguyễn Hoàng Anh)";
        // 
        // lblSummaryStudent
        // 
        lblSummaryStudent.AutoSize = true;
        lblSummaryStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryStudent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSummaryStudent.Location = new System.Drawing.Point(16, 12);
        lblSummaryStudent.Name = "lblSummaryStudent";
        lblSummaryStudent.Size = new System.Drawing.Size(402, 25);
        lblSummaryStudent.TabIndex = 0;
        lblSummaryStudent.Text = "Học viên: Nguyễn Minh Anh (0908 123 456)";
        // 
        // pnlStep4
        // 
        pnlStep4.Controls.Add(cardStep4);
        pnlStep4.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep4.Location = new System.Drawing.Point(24, 14);
        pnlStep4.Name = "pnlStep4";
        pnlStep4.Size = new System.Drawing.Size(932, 574);
        pnlStep4.TabIndex = 3;
        pnlStep4.Visible = false;
        // 
        // cardStep4
        // 
        cardStep4.BackColor = System.Drawing.Color.White;
        cardStep4.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStep4.BorderWidth = 1;
        cardStep4.Controls.Add(cardAdmissionSlip);
        cardStep4.Controls.Add(lblSuccessSubtitle);
        cardStep4.Controls.Add(lblSuccessTitle);
        cardStep4.Controls.Add(lblSuccessIcon);
        cardStep4.CornerRadius = 8;
        cardStep4.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStep4.Location = new System.Drawing.Point(0, 0);
        cardStep4.Name = "cardStep4";
        cardStep4.Padding = new System.Windows.Forms.Padding(24);
        cardStep4.Size = new System.Drawing.Size(932, 574);
        cardStep4.TabIndex = 0;
        // 
        // cardAdmissionSlip
        // 
        cardAdmissionSlip.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        cardAdmissionSlip.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        cardAdmissionSlip.BorderWidth = 1;
        cardAdmissionSlip.Controls.Add(lblSlipDetails);
        cardAdmissionSlip.Controls.Add(lblSlipStudentCodeVal);
        cardAdmissionSlip.Controls.Add(lblSlipStudentCode);
        cardAdmissionSlip.Controls.Add(lblSlipHeader);
        cardAdmissionSlip.CornerRadius = 8;
        cardAdmissionSlip.Location = new System.Drawing.Point(90, 168);
        cardAdmissionSlip.Name = "cardAdmissionSlip";
        cardAdmissionSlip.Padding = new System.Windows.Forms.Padding(20);
        cardAdmissionSlip.Size = new System.Drawing.Size(750, 270);
        cardAdmissionSlip.TabIndex = 3;
        // 
        // lblSlipDetails
        // 
        lblSlipDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSlipDetails.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSlipDetails.Location = new System.Drawing.Point(20, 88);
        lblSlipDetails.Name = "lblSlipDetails";
        lblSlipDetails.Size = new System.Drawing.Size(710, 165);
        lblSlipDetails.TabIndex = 3;
        lblSlipDetails.Text = resources.GetString("lblSlipDetails.Text");
        // 
        // lblSlipStudentCodeVal
        // 
        lblSlipStudentCodeVal.AutoSize = true;
        lblSlipStudentCodeVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblSlipStudentCodeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblSlipStudentCodeVal.Location = new System.Drawing.Point(195, 40);
        lblSlipStudentCodeVal.Name = "lblSlipStudentCodeVal";
        lblSlipStudentCodeVal.Size = new System.Drawing.Size(131, 37);
        lblSlipStudentCodeVal.TabIndex = 2;
        lblSlipStudentCodeVal.Text = "HV-0242";
        // 
        // lblSlipStudentCode
        // 
        lblSlipStudentCode.AutoSize = true;
        lblSlipStudentCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSlipStudentCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSlipStudentCode.Location = new System.Drawing.Point(20, 48);
        lblSlipStudentCode.Name = "lblSlipStudentCode";
        lblSlipStudentCode.Size = new System.Drawing.Size(173, 21);
        lblSlipStudentCode.TabIndex = 1;
        lblSlipStudentCode.Text = "Mã học viên chính thức:";
        // 
        // lblSlipHeader
        // 
        lblSlipHeader.AutoSize = true;
        lblSlipHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSlipHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSlipHeader.Location = new System.Drawing.Point(20, 16);
        lblSlipHeader.Name = "lblSlipHeader";
        lblSlipHeader.Size = new System.Drawing.Size(497, 21);
        lblSlipHeader.TabIndex = 0;
        lblSlipHeader.Text = "PHIẾU BÁO NHẬP HỌC ĐIỆN TỬ — TRUNG TÂM ANH NGỮ ECMS";
        // 
        // lblSuccessSubtitle
        // 
        lblSuccessSubtitle.AutoSize = true;
        lblSuccessSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSuccessSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSuccessSubtitle.Location = new System.Drawing.Point(265, 130);
        lblSuccessSubtitle.Name = "lblSuccessSubtitle";
        lblSuccessSubtitle.Size = new System.Drawing.Size(446, 23);
        lblSuccessSubtitle.TabIndex = 2;
        lblSuccessSubtitle.Text = "Học viên đã được cấp mã và ghi danh chính thức vào lớp";
        // 
        // lblSuccessTitle
        // 
        lblSuccessTitle.AutoSize = true;
        lblSuccessTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblSuccessTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblSuccessTitle.Location = new System.Drawing.Point(280, 88);
        lblSuccessTitle.Name = "lblSuccessTitle";
        lblSuccessTitle.Size = new System.Drawing.Size(399, 37);
        lblSuccessTitle.TabIndex = 1;
        lblSuccessTitle.Text = "ĐĂNG KÝ HỌC THÀNH CÔNG!";
        // 
        // lblSuccessIcon
        // 
        lblSuccessIcon.Font = new System.Drawing.Font("Segoe UI", 38F);
        lblSuccessIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblSuccessIcon.Location = new System.Drawing.Point(425, 14);
        lblSuccessIcon.Name = "lblSuccessIcon";
        lblSuccessIcon.Size = new System.Drawing.Size(80, 75);
        lblSuccessIcon.TabIndex = 0;
        lblSuccessIcon.Text = "✓";
        lblSuccessIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // StudentEnrollmentWizardDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(980, 740);
        Controls.Add(tabSteps);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(940, 680);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quy trình đăng ký học & Thanh toán học phí — ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        tabSteps.ResumeLayout(false);
        tpStep1.ResumeLayout(false);
        tpStep2.ResumeLayout(false);
        pnlStep1.ResumeLayout(false);
        cardStep1.ResumeLayout(false);
        cardStep1.PerformLayout();
        pnlStep2.ResumeLayout(false);
        cardStep2.ResumeLayout(false);
        cardStep2.PerformLayout();
        pnlBottomFeeSummary.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).EndInit();
        pnlTableToolbar.ResumeLayout(false);
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
        cardAdmissionSlip.ResumeLayout(false);
        cardAdmissionSlip.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnBack;
    private ECMS.UI.Controls.AppButton btnSaveWaiting;
    private ECMS.UI.Controls.AppButton btnConfirmNoPay;
    private ECMS.UI.Controls.AppButton btnNext;

    private System.Windows.Forms.TabControl tabSteps;
    private System.Windows.Forms.TabPage tpStep1;
    private System.Windows.Forms.TabPage tpStep2;
    
    // Step 1
    private System.Windows.Forms.Panel pnlStep1;
    private ECMS.UI.Controls.AppCard cardStep1;
    private System.Windows.Forms.Label lblSec1Title;
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
    private System.Windows.Forms.Panel pnlSecDivider;
    private System.Windows.Forms.Label lblSec2Title;
    private System.Windows.Forms.Label lblParentName;
    private ECMS.UI.Controls.AppTextBox txtParentName;
    private System.Windows.Forms.Label lblParentPhone;
    private ECMS.UI.Controls.AppTextBox txtParentPhone;
    private System.Windows.Forms.Label lblRelationship;
    private ECMS.UI.Controls.AppComboBox cboRelationship;
    private System.Windows.Forms.Label lblNotes;
    private ECMS.UI.Controls.AppTextBox txtNotes;
    
    // Step 2
    private System.Windows.Forms.Panel pnlStep2;
    private ECMS.UI.Controls.AppCard cardStep2;
    private System.Windows.Forms.Label lblSelectCourseTitle;
    private ECMS.UI.Controls.AppComboBox cboCourse;
    private System.Windows.Forms.Panel pnlTableToolbar;
    private ECMS.UI.Controls.AppTextBox txtSearchClass;
    private ECMS.UI.Controls.AppComboBox cboShiftFilter;
    private ECMS.UI.Controls.AppComboBox cboAvailabilityFilter;
    private ECMS.UI.Controls.AppDataGrid dgvOpenClasses;
    private System.Windows.Forms.Panel pnlBottomFeeSummary;
    private System.Windows.Forms.Label lblBottomTuitionFee;
    
    // Step 3
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
    private System.Windows.Forms.Label lblDiscount;
    private ECMS.UI.Controls.AppComboBox cboDiscount;
    private System.Windows.Forms.Label lblPaymentMethod;
    private ECMS.UI.Controls.AppComboBox cboPaymentMethod;
    private System.Windows.Forms.Label lblInitialPayment;
    private ECMS.UI.Controls.AppTextBox txtInitialPayment;
    private System.Windows.Forms.Label lblDebtSummary;
    
    // Step 4
    private System.Windows.Forms.Panel pnlStep4;
    private ECMS.UI.Controls.AppCard cardStep4;
    private System.Windows.Forms.Label lblSuccessIcon;
    private System.Windows.Forms.Label lblSuccessTitle;
    private System.Windows.Forms.Label lblSuccessSubtitle;
    private ECMS.UI.Controls.AppCard cardAdmissionSlip;
    private System.Windows.Forms.Label lblSlipHeader;
    private System.Windows.Forms.Label lblSlipStudentCode;
    private System.Windows.Forms.Label lblSlipStudentCodeVal;
    private System.Windows.Forms.Label lblSlipDetails;
}
