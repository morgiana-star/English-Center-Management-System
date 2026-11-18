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
        pnlTop.SuspendLayout();
        cardStudentInfo.SuspendLayout();
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
        pnlTop.Size = new System.Drawing.Size(820, 68);
        pnlTop.TabIndex = 0;
        // 
        // lblAddStudentHeader
        // 
        lblAddStudentHeader.AutoSize = true;
        lblAddStudentHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblAddStudentHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddStudentHeader.Location = new System.Drawing.Point(24, 18);
        lblAddStudentHeader.Name = "lblAddStudentHeader";
        lblAddStudentHeader.Size = new System.Drawing.Size(200, 32);
        lblAddStudentHeader.TabIndex = 1;
        lblAddStudentHeader.Text = "Đăng ký học viên";
        // 
        // cardStudentInfo
        // 
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
        cardStudentInfo.Location = new System.Drawing.Point(24, 85);
        cardStudentInfo.Name = "cardStudentInfo";
        cardStudentInfo.Padding = new System.Windows.Forms.Padding(20);
        cardStudentInfo.Size = new System.Drawing.Size(772, 600);
        cardStudentInfo.TabIndex = 1;
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
        txtFullName.Size = new System.Drawing.Size(350, 36);
        txtFullName.TabIndex = 2;
        // 
        // lblDob
        // 
        lblDob.AutoSize = true;
        lblDob.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDob.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblDob.Location = new System.Drawing.Point(390, 50);
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
        dtpDob.Location = new System.Drawing.Point(390, 77);
        dtpDob.Name = "dtpDob";
        dtpDob.Size = new System.Drawing.Size(170, 30);
        dtpDob.TabIndex = 4;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGender.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblGender.Location = new System.Drawing.Point(580, 50);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(78, 20);
        lblGender.TabIndex = 5;
        lblGender.Text = "Giới tính *";
        // 
        // cboGender
        // 
        cboGender.Location = new System.Drawing.Point(580, 74);
        cboGender.Name = "cboGender";
        cboGender.Size = new System.Drawing.Size(170, 36);
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
        txtPhone.Size = new System.Drawing.Size(350, 36);
        txtPhone.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblEmail.Location = new System.Drawing.Point(390, 120);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(46, 20);
        lblEmail.TabIndex = 9;
        lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(390, 144);
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
        txtAddress.Size = new System.Drawing.Size(730, 36);
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
        txtParentName.Size = new System.Drawing.Size(350, 36);
        txtParentName.TabIndex = 14;
        // 
        // lblParentPhone
        // 
        lblParentPhone.AutoSize = true;
        lblParentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblParentPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblParentPhone.Location = new System.Drawing.Point(390, 260);
        lblParentPhone.Name = "lblParentPhone";
        lblParentPhone.Size = new System.Drawing.Size(134, 20);
        lblParentPhone.TabIndex = 15;
        lblParentPhone.Text = "SĐT phụ huynh";
        // 
        // txtParentPhone
        // 
        txtParentPhone.Location = new System.Drawing.Point(390, 284);
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
        txtNotes.Size = new System.Drawing.Size(730, 60);
        txtNotes.TabIndex = 18;
        // 
        // bannerCheckPhone
        // 
        bannerCheckPhone.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
        bannerCheckPhone.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerCheckPhone.Location = new System.Drawing.Point(20, 435);
        bannerCheckPhone.Message = "Số điện thoại hợp lệ. Khi lưu, hồ sơ được ghi nhận trực tiếp vào cơ sở dữ liệu SQLite.";
        bannerCheckPhone.Name = "bannerCheckPhone";
        bannerCheckPhone.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerCheckPhone.Size = new System.Drawing.Size(730, 60);
        bannerCheckPhone.TabIndex = 19;
        bannerCheckPhone.Title = "✓ Hợp lệ:";
        bannerCheckPhone.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // btnCancelAdd
        // 
        btnCancelAdd.BackColor = System.Drawing.Color.White;
        btnCancelAdd.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelAdd.CornerRadius = 6;
        btnCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelAdd.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnCancelAdd.Location = new System.Drawing.Point(490, 520);
        btnCancelAdd.Name = "btnCancelAdd";
        btnCancelAdd.Size = new System.Drawing.Size(110, 42);
        btnCancelAdd.TabIndex = 20;
        btnCancelAdd.Text = "Hủy bỏ";
        btnCancelAdd.UseVisualStyleBackColor = false;
        btnCancelAdd.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnSaveStudent
        // 
        btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnSaveStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveStudent.CornerRadius = 6;
        btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveStudent.ForeColor = System.Drawing.Color.White;
        btnSaveStudent.Location = new System.Drawing.Point(610, 520);
        btnSaveStudent.Name = "btnSaveStudent";
        btnSaveStudent.Size = new System.Drawing.Size(140, 42);
        btnSaveStudent.TabIndex = 21;
        btnSaveStudent.Text = "Lưu học viên";
        btnSaveStudent.UseVisualStyleBackColor = false;
        btnSaveStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // AddStudentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(820, 710);
        Controls.Add(cardStudentInfo);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Đăng ký học viên — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardStudentInfo.ResumeLayout(false);
        cardStudentInfo.PerformLayout();
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
}
