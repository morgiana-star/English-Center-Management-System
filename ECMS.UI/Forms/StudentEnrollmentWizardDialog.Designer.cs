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

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        
        pnlFooter = new System.Windows.Forms.Panel();
        btnPrintReceipt = new ECMS.UI.Controls.AppButton();
        btnRegisterAnother = new ECMS.UI.Controls.AppButton();
        btnBack = new ECMS.UI.Controls.AppButton();
        btnNext = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        
        pnlBodyContainer = new System.Windows.Forms.Panel();
        
        // Step 1
        pnlStep1 = new System.Windows.Forms.Panel();
        cardStep1 = new ECMS.UI.Controls.AppCard();
        lblSec1Title = new System.Windows.Forms.Label();
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
        pnlSecDivider = new System.Windows.Forms.Panel();
        lblSec2Title = new System.Windows.Forms.Label();
        lblParentName = new System.Windows.Forms.Label();
        txtParentName = new ECMS.UI.Controls.AppTextBox();
        lblParentPhone = new System.Windows.Forms.Label();
        txtParentPhone = new ECMS.UI.Controls.AppTextBox();
        lblRelationship = new System.Windows.Forms.Label();
        cboRelationship = new ECMS.UI.Controls.AppComboBox();
        lblNotes = new System.Windows.Forms.Label();
        txtNotes = new ECMS.UI.Controls.AppTextBox();
        
        // Step 2
        pnlStep2 = new System.Windows.Forms.Panel();
        cardStep2 = new ECMS.UI.Controls.AppCard();
        lblSelectCourseTitle = new System.Windows.Forms.Label();
        cboCourse = new ECMS.UI.Controls.AppComboBox();
        pnlTableToolbar = new System.Windows.Forms.Panel();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        cboShiftFilter = new ECMS.UI.Controls.AppComboBox();
        cboAvailabilityFilter = new ECMS.UI.Controls.AppComboBox();
        dgvOpenClasses = new ECMS.UI.Controls.AppDataGrid();
        pnlBottomFeeSummary = new System.Windows.Forms.Panel();
        lblBottomTuitionFee = new System.Windows.Forms.Label();
        
        // Step 3
        pnlStep3 = new System.Windows.Forms.Panel();
        cardStep3 = new ECMS.UI.Controls.AppCard();
        cardSummaryInfo = new ECMS.UI.Controls.AppCard();
        lblSummaryStudent = new System.Windows.Forms.Label();
        lblSummaryClass = new System.Windows.Forms.Label();
        lblSummaryFee = new System.Windows.Forms.Label();
        lblInstallmentTitle = new System.Windows.Forms.Label();
        pnlInstallmentOptions = new System.Windows.Forms.Panel();
        radPayFull = new System.Windows.Forms.RadioButton();
        radPay2Installments = new System.Windows.Forms.RadioButton();
        radPay3Installments = new System.Windows.Forms.RadioButton();
        lblDiscount = new System.Windows.Forms.Label();
        cboDiscount = new ECMS.UI.Controls.AppComboBox();
        lblPaymentMethod = new System.Windows.Forms.Label();
        cboPaymentMethod = new ECMS.UI.Controls.AppComboBox();
        lblInitialPayment = new System.Windows.Forms.Label();
        txtInitialPayment = new ECMS.UI.Controls.AppTextBox();
        lblDebtSummary = new System.Windows.Forms.Label();
        
        // Step 4
        pnlStep4 = new System.Windows.Forms.Panel();
        cardStep4 = new ECMS.UI.Controls.AppCard();
        lblSuccessIcon = new System.Windows.Forms.Label();
        lblSuccessTitle = new System.Windows.Forms.Label();
        lblSuccessSubtitle = new System.Windows.Forms.Label();
        cardAdmissionSlip = new ECMS.UI.Controls.AppCard();
        lblSlipHeader = new System.Windows.Forms.Label();
        lblSlipStudentCode = new System.Windows.Forms.Label();
        lblSlipStudentCodeVal = new System.Windows.Forms.Label();
        lblSlipDetails = new System.Windows.Forms.Label();
        
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBodyContainer.SuspendLayout();
        pnlStep1.SuspendLayout();
        cardStep1.SuspendLayout();
        pnlStep2.SuspendLayout();
        cardStep2.SuspendLayout();
        pnlTableToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).BeginInit();
        pnlBottomFeeSummary.SuspendLayout();
        pnlStep3.SuspendLayout();
        cardStep3.SuspendLayout();
        cardSummaryInfo.SuspendLayout();
        pnlInstallmentOptions.SuspendLayout();
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
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(26, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(332, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đăng ký nhập học & Xếp lớp";

        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(28, 46);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(430, 21);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Bước 1 / 4: Điền thông tin cá nhân và người liên hệ học viên";

        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnPrintReceipt);
        pnlFooter.Controls.Add(btnRegisterAnother);
        pnlFooter.Controls.Add(btnBack);
        pnlFooter.Controls.Add(btnNext);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 680);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(28, 12, 28, 12);
        pnlFooter.Size = new System.Drawing.Size(980, 60);
        pnlFooter.TabIndex = 1;

        // 
        // btnCancel
        // 
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 6;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnCancel.Location = new System.Drawing.Point(28, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 36);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;

        // 
        // btnPrintReceipt
        // 
        btnPrintReceipt.BackColor = System.Drawing.Color.White;
        btnPrintReceipt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnPrintReceipt.CornerRadius = 6;
        btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnPrintReceipt.Location = new System.Drawing.Point(28, 12);
        btnPrintReceipt.Name = "btnPrintReceipt";
        btnPrintReceipt.Size = new System.Drawing.Size(200, 36);
        btnPrintReceipt.TabIndex = 4;
        btnPrintReceipt.Text = "🖨️ In biên lai / Phiếu báo";
        btnPrintReceipt.UseVisualStyleBackColor = false;
        btnPrintReceipt.Visible = false;

        // 
        // btnRegisterAnother
        // 
        btnRegisterAnother.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnRegisterAnother.BackColor = System.Drawing.Color.White;
        btnRegisterAnother.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnRegisterAnother.CornerRadius = 6;
        btnRegisterAnother.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRegisterAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRegisterAnother.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnRegisterAnother.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        btnRegisterAnother.Location = new System.Drawing.Point(575, 12);
        btnRegisterAnother.Name = "btnRegisterAnother";
        btnRegisterAnother.Size = new System.Drawing.Size(200, 36);
        btnRegisterAnother.TabIndex = 3;
        btnRegisterAnother.Text = "+ Đăng ký tiếp";
        btnRegisterAnother.UseVisualStyleBackColor = false;
        btnRegisterAnother.Visible = false;

        // 
        // btnBack
        // 
        btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnBack.BackColor = System.Drawing.Color.White;
        btnBack.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBack.CornerRadius = 6;
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnBack.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnBack.Location = new System.Drawing.Point(675, 12);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(115, 36);
        btnBack.TabIndex = 1;
        btnBack.Text = "← Quay lại";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Visible = false;

        // 
        // btnNext
        // 
        btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnNext.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
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
        btnNext.Text = "Tiếp tục →";
        btnNext.UseVisualStyleBackColor = false;

        // 
        // pnlBodyContainer
        // 
        pnlBodyContainer.Controls.Add(pnlStep1);
        pnlBodyContainer.Controls.Add(pnlStep2);
        pnlBodyContainer.Controls.Add(pnlStep3);
        pnlBodyContainer.Controls.Add(pnlStep4);
        pnlBodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBodyContainer.Location = new System.Drawing.Point(0, 78);
        pnlBodyContainer.Name = "pnlBodyContainer";
        pnlBodyContainer.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
        pnlBodyContainer.Size = new System.Drawing.Size(980, 602);
        pnlBodyContainer.TabIndex = 2;

        // ==================== BƯỚC 1: THÔNG TIN HỌC VIÊN ====================
        pnlStep1.Controls.Add(cardStep1);
        pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep1.Location = new System.Drawing.Point(24, 14);
        pnlStep1.Name = "pnlStep1";
        pnlStep1.Size = new System.Drawing.Size(932, 574);
        pnlStep1.TabIndex = 0;

        cardStep1.BackColor = System.Drawing.Color.White;
        cardStep1.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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

        lblSec1Title.AutoSize = true;
        lblSec1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSec1Title.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblSec1Title.Location = new System.Drawing.Point(24, 16);
        lblSec1Title.Name = "lblSec1Title";
        lblSec1Title.Size = new System.Drawing.Size(273, 25);
        lblSec1Title.TabIndex = 0;
        lblSec1Title.Text = "👤 1. Thông tin cá nhân học viên";

        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblFullName.Location = new System.Drawing.Point(24, 52);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(83, 20);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Họ và tên *";

        txtFullName.Location = new System.Drawing.Point(24, 76);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên học viên...";
        txtFullName.Size = new System.Drawing.Size(380, 36);
        txtFullName.TabIndex = 2;

        lblDob.AutoSize = true;
        lblDob.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDob.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblDob.Location = new System.Drawing.Point(430, 52);
        lblDob.Name = "lblDob";
        lblDob.Size = new System.Drawing.Size(84, 20);
        lblDob.TabIndex = 3;
        lblDob.Text = "Ngày sinh *";

        dtpDob.CustomFormat = "dd/MM/yyyy";
        dtpDob.Font = new System.Drawing.Font("Segoe UI", 10F);
        dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDob.Location = new System.Drawing.Point(430, 79);
        dtpDob.Name = "dtpDob";
        dtpDob.Size = new System.Drawing.Size(190, 30);
        dtpDob.TabIndex = 4;

        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblGender.Location = new System.Drawing.Point(650, 52);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(75, 20);
        lblGender.TabIndex = 5;
        lblGender.Text = "Giới tính *";

        cboGender.Location = new System.Drawing.Point(650, 76);
        cboGender.Name = "cboGender";
        cboGender.Size = new System.Drawing.Size(230, 36);
        cboGender.TabIndex = 6;

        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblPhone.Location = new System.Drawing.Point(24, 122);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(107, 20);
        lblPhone.TabIndex = 7;
        lblPhone.Text = "Số điện thoại *";

        txtPhone.Location = new System.Drawing.Point(24, 146);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "VD: 0908 123 456";
        txtPhone.Size = new System.Drawing.Size(380, 36);
        txtPhone.TabIndex = 8;

        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblEmail.Location = new System.Drawing.Point(430, 122);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(46, 20);
        lblEmail.TabIndex = 9;
        lblEmail.Text = "Email";

        txtEmail.Location = new System.Drawing.Point(430, 146);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "VD: student@email.com";
        txtEmail.Size = new System.Drawing.Size(450, 36);
        txtEmail.TabIndex = 10;

        lblAddress.AutoSize = true;
        lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblAddress.Location = new System.Drawing.Point(24, 192);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(111, 20);
        lblAddress.TabIndex = 11;
        lblAddress.Text = "Địa chỉ liên hệ";

        txtAddress.Location = new System.Drawing.Point(24, 216);
        txtAddress.Name = "txtAddress";
        txtAddress.Placeholder = "Số nhà, tên đường, phường/xã, quận/huyện...";
        txtAddress.Size = new System.Drawing.Size(856, 36);
        txtAddress.TabIndex = 12;

        // Sec Divider
        pnlSecDivider.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        pnlSecDivider.Location = new System.Drawing.Point(24, 268);
        pnlSecDivider.Name = "pnlSecDivider";
        pnlSecDivider.Size = new System.Drawing.Size(856, 1);
        pnlSecDivider.TabIndex = 13;

        // Sec 2
        lblSec2Title.AutoSize = true;
        lblSec2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSec2Title.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblSec2Title.Location = new System.Drawing.Point(24, 280);
        lblSec2Title.Name = "lblSec2Title";
        lblSec2Title.Size = new System.Drawing.Size(452, 25);
        lblSec2Title.TabIndex = 14;
        lblSec2Title.Text = "👨‍👩‍👧 2. Người liên hệ / Phụ huynh (Nếu có bảo lãnh)";

        lblParentName.AutoSize = true;
        lblParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentName.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblParentName.Location = new System.Drawing.Point(24, 314);
        lblParentName.Name = "lblParentName";
        lblParentName.Size = new System.Drawing.Size(157, 20);
        lblParentName.TabIndex = 15;
        lblParentName.Text = "Họ tên người liên hệ";

        txtParentName.Location = new System.Drawing.Point(24, 338);
        txtParentName.Name = "txtParentName";
        txtParentName.Placeholder = "Họ và tên phụ huynh / người giám hộ...";
        txtParentName.Size = new System.Drawing.Size(350, 36);
        txtParentName.TabIndex = 16;

        lblParentPhone.AutoSize = true;
        lblParentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblParentPhone.Location = new System.Drawing.Point(400, 314);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(108, 20);
        lblParentPhone.TabIndex = 17;
        lblParentPhone.Text = "SĐT phụ huynh";

        txtParentPhone.Location = new System.Drawing.Point(400, 338);
        txtParentPhone.Name = "txtParentPhone";
        txtParentPhone.Placeholder = "VD: 0911 556 889";
        txtParentPhone.Size = new System.Drawing.Size(260, 36);
        txtParentPhone.TabIndex = 18;

        lblRelationship.AutoSize = true;
        lblRelationship.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblRelationship.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblRelationship.Location = new System.Drawing.Point(680, 314);
        lblRelationship.Name = "lblRelationship";
        lblRelationship.Size = new System.Drawing.Size(91, 20);
        lblRelationship.TabIndex = 19;
        lblRelationship.Text = "Mối quan hệ";

        cboRelationship.Location = new System.Drawing.Point(680, 338);
        cboRelationship.Name = "cboRelationship";
        cboRelationship.Size = new System.Drawing.Size(200, 36);
        cboRelationship.TabIndex = 20;

        lblNotes.AutoSize = true;
        lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblNotes.Location = new System.Drawing.Point(24, 386);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(141, 20);
        lblNotes.TabIndex = 21;
        lblNotes.Text = "Ghi chú tuyển sinh";

        txtNotes.Location = new System.Drawing.Point(24, 410);
        txtNotes.Name = "txtNotes";
        txtNotes.Placeholder = "Mục tiêu điểm số, ca học mong muốn hoặc ghi chú bảo lãnh...";
        txtNotes.Size = new System.Drawing.Size(856, 52);
        txtNotes.TabIndex = 22;

        // ==================== BƯỚC 2: CHỌN KHÓA & LỚP ====================
        pnlStep2.Controls.Add(cardStep2);
        pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep2.Location = new System.Drawing.Point(24, 14);
        pnlStep2.Name = "pnlStep2";
        pnlStep2.Size = new System.Drawing.Size(932, 574);
        pnlStep2.TabIndex = 1;
        pnlStep2.Visible = false;

        cardStep2.BackColor = System.Drawing.Color.White;
        cardStep2.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
        cardStep2.Size = new System.Drawing.Size(932, 574);
        cardStep2.TabIndex = 0;

        // 1. Khóa học
        lblSelectCourseTitle.AutoSize = true;
        lblSelectCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblSelectCourseTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSelectCourseTitle.Location = new System.Drawing.Point(24, 16);
        lblSelectCourseTitle.Name = "lblSelectCourseTitle";
        lblSelectCourseTitle.Size = new System.Drawing.Size(236, 25);
        lblSelectCourseTitle.TabIndex = 0;
        lblSelectCourseTitle.Text = "Chương trình đào tạo (*):";

        cboCourse.Location = new System.Drawing.Point(24, 44);
        cboCourse.Name = "cboCourse";
        cboCourse.Size = new System.Drawing.Size(500, 36);
        cboCourse.TabIndex = 1;

        // 2. Toolbar trên bảng (Search + 2 Filters)
        pnlTableToolbar.BackColor = System.Drawing.Color.Transparent;
        pnlTableToolbar.Controls.Add(cboAvailabilityFilter);
        pnlTableToolbar.Controls.Add(cboShiftFilter);
        pnlTableToolbar.Controls.Add(txtSearchClass);
        pnlTableToolbar.Location = new System.Drawing.Point(24, 96);
        pnlTableToolbar.Name = "pnlTableToolbar";
        pnlTableToolbar.Size = new System.Drawing.Size(884, 40);
        pnlTableToolbar.TabIndex = 2;

        txtSearchClass.Location = new System.Drawing.Point(0, 0);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍 Tìm nhanh theo mã lớp, giáo viên, phòng học...";
        txtSearchClass.Size = new System.Drawing.Size(420, 36);
        txtSearchClass.TabIndex = 0;

        cboShiftFilter.Location = new System.Drawing.Point(435, 0);
        cboShiftFilter.Name = "cboShiftFilter";
        cboShiftFilter.Size = new System.Drawing.Size(220, 36);
        cboShiftFilter.TabIndex = 1;

        cboAvailabilityFilter.Location = new System.Drawing.Point(670, 0);
        cboAvailabilityFilter.Name = "cboAvailabilityFilter";
        cboAvailabilityFilter.Size = new System.Drawing.Size(214, 36);
        cboAvailabilityFilter.TabIndex = 2;

        // 3. DataGridView bảng lớp học
        dgvOpenClasses.AllowUserToAddRows = false;
        dgvOpenClasses.AllowUserToDeleteRows = false;
        dgvOpenClasses.AllowUserToResizeColumns = false;
        dgvOpenClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dgvOpenClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvOpenClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvOpenClasses.BackgroundColor = System.Drawing.Color.White;
        dgvOpenClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvOpenClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvOpenClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvOpenClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvOpenClasses.ColumnHeadersHeight = 40;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvOpenClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvOpenClasses.EnableHeadersVisualStyles = false;
        dgvOpenClasses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvOpenClasses.Location = new System.Drawing.Point(24, 148);
        dgvOpenClasses.MultiSelect = false;
        dgvOpenClasses.Name = "dgvOpenClasses";
        dgvOpenClasses.ReadOnly = true;
        dgvOpenClasses.RowHeadersVisible = false;
        dgvOpenClasses.RowTemplate.Height = 44;
        dgvOpenClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvOpenClasses.Size = new System.Drawing.Size(884, 300);
        dgvOpenClasses.TabIndex = 3;

        // 4. Panel chân trang: Tổng học phí
        pnlBottomFeeSummary.BackColor = System.Drawing.Color.Transparent;
        pnlBottomFeeSummary.Controls.Add(lblBottomTuitionFee);
        pnlBottomFeeSummary.Location = new System.Drawing.Point(24, 460);
        pnlBottomFeeSummary.Name = "pnlBottomFeeSummary";
        pnlBottomFeeSummary.Size = new System.Drawing.Size(884, 45);
        pnlBottomFeeSummary.TabIndex = 4;

        lblBottomTuitionFee.Dock = System.Windows.Forms.DockStyle.Right;
        lblBottomTuitionFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblBottomTuitionFee.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
        lblBottomTuitionFee.Location = new System.Drawing.Point(400, 0);
        lblBottomTuitionFee.Name = "lblBottomTuitionFee";
        lblBottomTuitionFee.Size = new System.Drawing.Size(484, 45);
        lblBottomTuitionFee.TabIndex = 0;
        lblBottomTuitionFee.Text = "Tổng học phí: 6.800.000 VNĐ";
        lblBottomTuitionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // ==================== BƯỚC 3: THU PHÍ & KẾ HOẠCH ====================
        pnlStep3.Controls.Add(cardStep3);
        pnlStep3.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep3.Location = new System.Drawing.Point(24, 14);
        pnlStep3.Name = "pnlStep3";
        pnlStep3.Size = new System.Drawing.Size(932, 574);
        pnlStep3.TabIndex = 2;
        pnlStep3.Visible = false;

        cardStep3.BackColor = System.Drawing.Color.White;
        cardStep3.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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

        cardSummaryInfo.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        cardSummaryInfo.BorderColor = System.Drawing.Color.FromArgb(191, 219, 254);
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

        lblSummaryStudent.AutoSize = true;
        lblSummaryStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryStudent.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblSummaryStudent.Location = new System.Drawing.Point(16, 12);
        lblSummaryStudent.Name = "lblSummaryStudent";
        lblSummaryStudent.Size = new System.Drawing.Size(402, 25);
        lblSummaryStudent.TabIndex = 0;
        lblSummaryStudent.Text = "Học viên: Nguyễn Minh Anh (0908 123 456)";

        lblSummaryClass.AutoSize = true;
        lblSummaryClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSummaryClass.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSummaryClass.Location = new System.Drawing.Point(16, 44);
        lblSummaryClass.Name = "lblSummaryClass";
        lblSummaryClass.Size = new System.Drawing.Size(536, 21);
        lblSummaryClass.TabIndex = 1;
        lblSummaryClass.Text = "Lớp: IELTS-F01 · IELTS Foundation · Phòng P201 (GV: Nguyễn Hoàng Anh)";

        lblSummaryFee.AutoSize = true;
        lblSummaryFee.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblSummaryFee.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
        lblSummaryFee.Location = new System.Drawing.Point(16, 72);
        lblSummaryFee.Name = "lblSummaryFee";
        lblSummaryFee.Size = new System.Drawing.Size(351, 28);
        lblSummaryFee.TabIndex = 2;
        lblSummaryFee.Text = "Tổng học phí niêm yết: 6.800.000 đ";

        lblInstallmentTitle.AutoSize = true;
        lblInstallmentTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblInstallmentTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblInstallmentTitle.Location = new System.Drawing.Point(24, 138);
        lblInstallmentTitle.Name = "lblInstallmentTitle";
        lblInstallmentTitle.Size = new System.Drawing.Size(457, 25);
        lblInstallmentTitle.TabIndex = 1;
        lblInstallmentTitle.Text = "Kế hoạch đóng học phí (Hỗ trợ tối đa 3 đợt linh hoạt):";

        pnlInstallmentOptions.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlInstallmentOptions.Controls.Add(radPay3Installments);
        pnlInstallmentOptions.Controls.Add(radPay2Installments);
        pnlInstallmentOptions.Controls.Add(radPayFull);
        pnlInstallmentOptions.Location = new System.Drawing.Point(24, 168);
        pnlInstallmentOptions.Name = "pnlInstallmentOptions";
        pnlInstallmentOptions.Size = new System.Drawing.Size(884, 105);
        pnlInstallmentOptions.TabIndex = 2;

        radPayFull.AutoSize = true;
        radPayFull.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPayFull.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPayFull.Location = new System.Drawing.Point(18, 10);
        radPayFull.Name = "radPayFull";
        radPayFull.Size = new System.Drawing.Size(575, 25);
        radPayFull.TabIndex = 0;
        radPayFull.Text = "Đóng trọn gói 1 lần (100% - 6.800.000đ) · Tặng giáo trình + Miễn công nợ";
        radPayFull.UseVisualStyleBackColor = true;

        radPay2Installments.AutoSize = true;
        radPay2Installments.Checked = true;
        radPay2Installments.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPay2Installments.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPay2Installments.Location = new System.Drawing.Point(18, 40);
        radPay2Installments.Name = "radPay2Installments";
        radPay2Installments.Size = new System.Drawing.Size(554, 25);
        radPay2Installments.TabIndex = 1;
        radPay2Installments.TabStop = true;
        radPay2Installments.Text = "Chia làm 2 đợt: Đợt 1 (50% - 3.400.000đ) · Đợt 2 (50% nộp sau 30 ngày)";
        radPay2Installments.UseVisualStyleBackColor = true;

        radPay3Installments.AutoSize = true;
        radPay3Installments.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        radPay3Installments.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        radPay3Installments.Location = new System.Drawing.Point(18, 70);
        radPay3Installments.Name = "radPay3Installments";
        radPay3Installments.Size = new System.Drawing.Size(650, 25);
        radPay3Installments.TabIndex = 2;
        radPay3Installments.Text = "Chia làm 3 đợt: Đợt 1 (40% - 2.720.000đ) · Đợt 2 (2.040.000đ) · Đợt 3 (2.040.000đ)";
        radPay3Installments.UseVisualStyleBackColor = true;

        lblDiscount.AutoSize = true;
        lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDiscount.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblDiscount.Location = new System.Drawing.Point(24, 286);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new System.Drawing.Size(185, 20);
        lblDiscount.TabIndex = 3;
        lblDiscount.Text = "Chính sách ưu đãi / Giảm:";

        cboDiscount.Location = new System.Drawing.Point(24, 310);
        cboDiscount.Name = "cboDiscount";
        cboDiscount.Size = new System.Drawing.Size(420, 36);
        cboDiscount.TabIndex = 4;

        lblPaymentMethod.AutoSize = true;
        lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblPaymentMethod.Location = new System.Drawing.Point(470, 286);
        lblPaymentMethod.Name = "lblPaymentMethod";
        lblPaymentMethod.Size = new System.Drawing.Size(185, 20);
        lblPaymentMethod.TabIndex = 5;
        lblPaymentMethod.Text = "Phương thức thanh toán:";

        cboPaymentMethod.Location = new System.Drawing.Point(470, 310);
        cboPaymentMethod.Name = "cboPaymentMethod";
        cboPaymentMethod.Size = new System.Drawing.Size(438, 36);
        cboPaymentMethod.TabIndex = 6;

        lblInitialPayment.AutoSize = true;
        lblInitialPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInitialPayment.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblInitialPayment.Location = new System.Drawing.Point(24, 360);
        lblInitialPayment.Name = "lblInitialPayment";
        lblInitialPayment.Size = new System.Drawing.Size(207, 20);
        lblInitialPayment.TabIndex = 7;
        lblInitialPayment.Text = "Số tiền thu thực tế đợt 1 (*):";

        txtInitialPayment.Location = new System.Drawing.Point(24, 384);
        txtInitialPayment.Name = "txtInitialPayment";
        txtInitialPayment.Placeholder = "Nhập số tiền thực thu...";
        txtInitialPayment.Size = new System.Drawing.Size(420, 36);
        txtInitialPayment.TabIndex = 8;

        lblDebtSummary.AutoSize = true;
        lblDebtSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblDebtSummary.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
        lblDebtSummary.Location = new System.Drawing.Point(24, 436);
        lblDebtSummary.Name = "lblDebtSummary";
        lblDebtSummary.Size = new System.Drawing.Size(559, 23);
        lblDebtSummary.TabIndex = 9;
        lblDebtSummary.Text = "Công nợ còn lại: 3.400.000 VNĐ · Đợt 2 hẹn thanh toán: 30/11/2026";

        // ==================== BƯỚC 4: HOÀN TẤT ĐĂNG KÝ ====================
        pnlStep4.Controls.Add(cardStep4);
        pnlStep4.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlStep4.Location = new System.Drawing.Point(24, 14);
        pnlStep4.Name = "pnlStep4";
        pnlStep4.Size = new System.Drawing.Size(932, 574);
        pnlStep4.TabIndex = 3;
        pnlStep4.Visible = false;

        cardStep4.BackColor = System.Drawing.Color.White;
        cardStep4.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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

        lblSuccessIcon.Font = new System.Drawing.Font("Segoe UI", 38F);
        lblSuccessIcon.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblSuccessIcon.Location = new System.Drawing.Point(425, 14);
        lblSuccessIcon.Name = "lblSuccessIcon";
        lblSuccessIcon.Size = new System.Drawing.Size(80, 75);
        lblSuccessIcon.TabIndex = 0;
        lblSuccessIcon.Text = "✓";
        lblSuccessIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        lblSuccessTitle.AutoSize = true;
        lblSuccessTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblSuccessTitle.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblSuccessTitle.Location = new System.Drawing.Point(280, 88);
        lblSuccessTitle.Name = "lblSuccessTitle";
        lblSuccessTitle.Size = new System.Drawing.Size(370, 37);
        lblSuccessTitle.TabIndex = 1;
        lblSuccessTitle.Text = "ĐĂNG KÝ HỌC THÀNH CÔNG!";

        lblSuccessSubtitle.AutoSize = true;
        lblSuccessSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSuccessSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSuccessSubtitle.Location = new System.Drawing.Point(265, 130);
        lblSuccessSubtitle.Name = "lblSuccessSubtitle";
        lblSuccessSubtitle.Size = new System.Drawing.Size(400, 23);
        lblSuccessSubtitle.TabIndex = 2;
        lblSuccessSubtitle.Text = "Học viên đã được cấp mã và ghi danh chính thức vào lớp";

        cardAdmissionSlip.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        cardAdmissionSlip.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
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

        lblSlipHeader.AutoSize = true;
        lblSlipHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSlipHeader.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSlipHeader.Location = new System.Drawing.Point(20, 16);
        lblSlipHeader.Name = "lblSlipHeader";
        lblSlipHeader.Size = new System.Drawing.Size(454, 21);
        lblSlipHeader.TabIndex = 0;
        lblSlipHeader.Text = "PHIẾU BÁO NHẬP HỌC ĐIỆN TỬ — TRUNG TÂM ANH NGỮ ECMS";

        lblSlipStudentCode.AutoSize = true;
        lblSlipStudentCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSlipStudentCode.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSlipStudentCode.Location = new System.Drawing.Point(20, 48);
        lblSlipStudentCode.Name = "lblSlipStudentCode";
        lblSlipStudentCode.Size = new System.Drawing.Size(171, 21);
        lblSlipStudentCode.TabIndex = 1;
        lblSlipStudentCode.Text = "Mã học viên chính thức:";

        lblSlipStudentCodeVal.AutoSize = true;
        lblSlipStudentCodeVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblSlipStudentCodeVal.ForeColor = System.Drawing.Color.FromArgb(29, 78, 216);
        lblSlipStudentCodeVal.Location = new System.Drawing.Point(195, 40);
        lblSlipStudentCodeVal.Name = "lblSlipStudentCodeVal";
        lblSlipStudentCodeVal.Size = new System.Drawing.Size(130, 37);
        lblSlipStudentCodeVal.TabIndex = 2;
        lblSlipStudentCodeVal.Text = "HV-0242";

        lblSlipDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSlipDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblSlipDetails.Location = new System.Drawing.Point(20, 88);
        lblSlipDetails.Name = "lblSlipDetails";
        lblSlipDetails.Size = new System.Drawing.Size(710, 165);
        lblSlipDetails.TabIndex = 3;
        lblSlipDetails.Text = "• Họ và tên: Võ Trường Giang (0363833630)\r\n• Lớp ghi danh: IELTS-F01 · IELTS Foundation\r\n• Khai giảng: 01/12/2026 · Phòng P201 (GV: Nguyễn Hoàng Anh)\r\n• Đã thu đợt 1 thành công: 3.400.000 VNĐ (Mã phiếu: PT-20261116-0042)\r\n• Tình trạng công nợ còn lại: 3.400.000 VNĐ (Đợt 2 hẹn thanh toán: 30/11/2026)";

        // 
        // StudentEnrollmentWizardDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(980, 740);
        Controls.Add(pnlBodyContainer);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quy trình đăng ký học & Thanh toán học phí — ECMS";
        
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
        pnlTableToolbar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOpenClasses).EndInit();
        pnlBottomFeeSummary.ResumeLayout(false);
        pnlStep3.ResumeLayout(false);
        cardStep3.ResumeLayout(false);
        cardStep3.PerformLayout();
        cardSummaryInfo.ResumeLayout(false);
        cardSummaryInfo.PerformLayout();
        pnlInstallmentOptions.ResumeLayout(false);
        pnlInstallmentOptions.PerformLayout();
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
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnBack;
    private ECMS.UI.Controls.AppButton btnNext;
    private ECMS.UI.Controls.AppButton btnPrintReceipt;
    private ECMS.UI.Controls.AppButton btnRegisterAnother;
    
    private System.Windows.Forms.Panel pnlBodyContainer;
    
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
