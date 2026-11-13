namespace ECMS.UI.Forms;

partial class AddLeadDialog
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
        cardAddCheck = new ECMS.UI.Controls.AppCard();
        lblAddMeta = new System.Windows.Forms.Label();
        lblAddRules = new System.Windows.Forms.Label();
        bannerAddWarn = new ECMS.UI.Controls.AppBanner();
        lblAddCheckTitle = new System.Windows.Forms.Label();
        cardAddForm = new ECMS.UI.Controls.AppCard();
        btnSaveAdd = new ECMS.UI.Controls.AppButton();
        btnCancelAdd = new ECMS.UI.Controls.AppButton();
        txtAddNotes = new ECMS.UI.Controls.AppTextBox();
        lblAddNotes = new System.Windows.Forms.Label();
        txtAddAppt = new ECMS.UI.Controls.AppTextBox();
        lblAddAppt = new System.Windows.Forms.Label();
        cboAddStaff = new ECMS.UI.Controls.AppComboBox();
        lblAddStaff = new System.Windows.Forms.Label();
        cboAddCourse = new ECMS.UI.Controls.AppComboBox();
        lblAddCourse = new System.Windows.Forms.Label();
        cboAddSource = new ECMS.UI.Controls.AppComboBox();
        lblAddSource = new System.Windows.Forms.Label();
        txtAddEmail = new ECMS.UI.Controls.AppTextBox();
        lblAddEmail = new System.Windows.Forms.Label();
        lblAddPhoneError = new System.Windows.Forms.Label();
        txtAddPhone = new ECMS.UI.Controls.AppTextBox();
        lblAddPhone = new System.Windows.Forms.Label();
        dtpAddDob = new System.Windows.Forms.DateTimePicker();
        lblAddDob = new System.Windows.Forms.Label();
        txtAddName = new ECMS.UI.Controls.AppTextBox();
        lblAddName = new System.Windows.Forms.Label();
        lblAddFormTitle = new System.Windows.Forms.Label();
        lblAddStep = new System.Windows.Forms.Label();
        lblAddLeadSub = new System.Windows.Forms.Label();
        lblAddLeadHeader = new System.Windows.Forms.Label();
        pnlTop = new System.Windows.Forms.Panel();
        cardAddCheck.SuspendLayout();
        cardAddForm.SuspendLayout();
        pnlTop.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblAddStep);
        pnlTop.Controls.Add(lblAddLeadSub);
        pnlTop.Controls.Add(lblAddLeadHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1100, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblAddStep
        // 
        lblAddStep.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblAddStep.AutoSize = true;
        lblAddStep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAddStep.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblAddStep.Location = new System.Drawing.Point(980, 20);
        lblAddStep.Name = "lblAddStep";
        lblAddStep.Size = new System.Drawing.Size(89, 20);
        lblAddStep.TabIndex = 2;
        lblAddStep.Text = "02 / Bước 1";
        // 
        // lblAddLeadSub
        // 
        lblAddLeadSub.AutoSize = true;
        lblAddLeadSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddLeadSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblAddLeadSub.Location = new System.Drawing.Point(24, 45);
        lblAddLeadSub.Name = "lblAddLeadSub";
        lblAddLeadSub.Size = new System.Drawing.Size(262, 20);
        lblAddLeadSub.TabIndex = 1;
        lblAddLeadSub.Text = "Dữ liệu mẫu · Trung tâm Anh ngữ Minh Trí";
        // 
        // lblAddLeadHeader
        // 
        lblAddLeadHeader.AutoSize = true;
        lblAddLeadHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblAddLeadHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddLeadHeader.Location = new System.Drawing.Point(22, 10);
        lblAddLeadHeader.Name = "lblAddLeadHeader";
        lblAddLeadHeader.Size = new System.Drawing.Size(359, 35);
        lblAddLeadHeader.TabIndex = 0;
        lblAddLeadHeader.Text = "Thêm khách hàng tiềm năng";
        // 
        // cardAddCheck
        // 
        cardAddCheck.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardAddCheck.BackColor = System.Drawing.Color.White;
        cardAddCheck.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardAddCheck.BorderWidth = 1;
        cardAddCheck.Controls.Add(lblAddMeta);
        cardAddCheck.Controls.Add(lblAddRules);
        cardAddCheck.Controls.Add(bannerAddWarn);
        cardAddCheck.Controls.Add(lblAddCheckTitle);
        cardAddCheck.CornerRadius = 8;
        cardAddCheck.Location = new System.Drawing.Point(705, 95);
        cardAddCheck.Name = "cardAddCheck";
        cardAddCheck.Padding = new System.Windows.Forms.Padding(16);
        cardAddCheck.Size = new System.Drawing.Size(370, 530);
        cardAddCheck.TabIndex = 2;
        // 
        // lblAddMeta
        // 
        lblAddMeta.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddMeta.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblAddMeta.Location = new System.Drawing.Point(20, 240);
        lblAddMeta.Name = "lblAddMeta";
        lblAddMeta.Size = new System.Drawing.Size(330, 160);
        lblAddMeta.TabIndex = 3;
        lblAddMeta.Text = "Mã tự sinh:  TN-0108 sau khi lưu\r\n\r\nBước tiếp theo:  Mở hồ sơ tư vấn 02.3\r\n\r\nSửa lỗi mẫu:  Nhập 0908 123 456 → Lưu\r\n\r\nTrạng thái:  đang nhập";
        // 
        // lblAddRules
        // 
        lblAddRules.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAddRules.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblAddRules.Location = new System.Drawing.Point(20, 140);
        lblAddRules.Name = "lblAddRules";
        lblAddRules.Size = new System.Drawing.Size(330, 80);
        lblAddRules.TabIndex = 2;
        lblAddRules.Text = "• Dấu *: trường bắt buộc.\r\n• Trùng số điện thoại: đề nghị mở hồ sơ đã có.\r\n• Không mất thông tin đang nhập khi sửa lỗi.";
        // 
        // bannerAddWarn
        // 
        bannerAddWarn.BannerType = ECMS.UI.Controls.BannerType.Danger;
        bannerAddWarn.Location = new System.Drawing.Point(20, 55);
        bannerAddWarn.Message = "Cần bổ sung điện thoại để tránh trùng hồ sơ.";
        bannerAddWarn.Name = "bannerAddWarn";
        bannerAddWarn.Size = new System.Drawing.Size(330, 65);
        bannerAddWarn.TabIndex = 1;
        bannerAddWarn.Title = "✕ Chưa thể lưu";
        bannerAddWarn.Variant = ECMS.UI.Controls.BannerVariant.Danger;
        // 
        // lblAddCheckTitle
        // 
        lblAddCheckTitle.AutoSize = true;
        lblAddCheckTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblAddCheckTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddCheckTitle.Location = new System.Drawing.Point(20, 16);
        lblAddCheckTitle.Name = "lblAddCheckTitle";
        lblAddCheckTitle.Size = new System.Drawing.Size(217, 28);
        lblAddCheckTitle.TabIndex = 0;
        lblAddCheckTitle.Text = "Kiểm tra trước khi lưu";
        // 
        // cardAddForm
        // 
        cardAddForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardAddForm.BackColor = System.Drawing.Color.White;
        cardAddForm.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardAddForm.BorderWidth = 1;
        cardAddForm.Controls.Add(btnSaveAdd);
        cardAddForm.Controls.Add(btnCancelAdd);
        cardAddForm.Controls.Add(txtAddNotes);
        cardAddForm.Controls.Add(lblAddNotes);
        cardAddForm.Controls.Add(txtAddAppt);
        cardAddForm.Controls.Add(lblAddAppt);
        cardAddForm.Controls.Add(cboAddStaff);
        cardAddForm.Controls.Add(lblAddStaff);
        cardAddForm.Controls.Add(cboAddCourse);
        cardAddForm.Controls.Add(lblAddCourse);
        cardAddForm.Controls.Add(cboAddSource);
        cardAddForm.Controls.Add(lblAddSource);
        cardAddForm.Controls.Add(txtAddEmail);
        cardAddForm.Controls.Add(lblAddEmail);
        cardAddForm.Controls.Add(lblAddPhoneError);
        cardAddForm.Controls.Add(txtAddPhone);
        cardAddForm.Controls.Add(lblAddPhone);
        cardAddForm.Controls.Add(dtpAddDob);
        cardAddForm.Controls.Add(lblAddDob);
        cardAddForm.Controls.Add(txtAddName);
        cardAddForm.Controls.Add(lblAddName);
        cardAddForm.Controls.Add(lblAddFormTitle);
        cardAddForm.CornerRadius = 8;
        cardAddForm.Location = new System.Drawing.Point(24, 95);
        cardAddForm.Name = "cardAddForm";
        cardAddForm.Padding = new System.Windows.Forms.Padding(16);
        cardAddForm.Size = new System.Drawing.Size(660, 530);
        cardAddForm.TabIndex = 1;
        // 
        // btnSaveAdd
        // 
        btnSaveAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSaveAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnSaveAdd.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAdd.CornerRadius = 6;
        btnSaveAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAdd.ForeColor = System.Drawing.Color.White;
        btnSaveAdd.Location = new System.Drawing.Point(505, 475);
        btnSaveAdd.Name = "btnSaveAdd";
        btnSaveAdd.Size = new System.Drawing.Size(135, 36);
        btnSaveAdd.TabIndex = 21;
        btnSaveAdd.Text = "Lưu tiềm năng";
        btnSaveAdd.UseVisualStyleBackColor = false;
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
        btnCancelAdd.Location = new System.Drawing.Point(405, 475);
        btnCancelAdd.Name = "btnCancelAdd";
        btnCancelAdd.Size = new System.Drawing.Size(90, 36);
        btnCancelAdd.TabIndex = 20;
        btnCancelAdd.Text = "Hủy";
        btnCancelAdd.UseVisualStyleBackColor = false;
        // 
        // txtAddNotes
        // 
        txtAddNotes.BackColor = System.Drawing.Color.Transparent;
        txtAddNotes.CornerRadius = 6;
        txtAddNotes.ErrorMessage = "";
        txtAddNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddNotes.HasError = false;
        txtAddNotes.Location = new System.Drawing.Point(20, 400);
        txtAddNotes.Name = "txtAddNotes";
        txtAddNotes.Placeholder = "Nhập mục tiêu học tập, mong muốn...";
        txtAddNotes.ReadOnly = false;
        txtAddNotes.Size = new System.Drawing.Size(620, 55);
        txtAddNotes.TabIndex = 19;
        txtAddNotes.UseSystemPasswordChar = false;
        // 
        // lblAddNotes
        // 
        lblAddNotes.AutoSize = true;
        lblAddNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddNotes.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddNotes.Location = new System.Drawing.Point(20, 377);
        lblAddNotes.Name = "lblAddNotes";
        lblAddNotes.Size = new System.Drawing.Size(129, 19);
        lblAddNotes.TabIndex = 18;
        lblAddNotes.Text = "Mục tiêu / ghi chú";
        // 
        // txtAddAppt
        // 
        txtAddAppt.BackColor = System.Drawing.Color.Transparent;
        txtAddAppt.CornerRadius = 6;
        txtAddAppt.ErrorMessage = "";
        txtAddAppt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddAppt.HasError = false;
        txtAddAppt.Location = new System.Drawing.Point(340, 330);
        txtAddAppt.Name = "txtAddAppt";
        txtAddAppt.Placeholder = "02/10/2026 · 14:00";
        txtAddAppt.ReadOnly = false;
        txtAddAppt.Size = new System.Drawing.Size(300, 32);
        txtAddAppt.TabIndex = 17;
        txtAddAppt.UseSystemPasswordChar = false;
        // 
        // lblAddAppt
        // 
        lblAddAppt.AutoSize = true;
        lblAddAppt.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddAppt.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddAppt.Location = new System.Drawing.Point(340, 307);
        lblAddAppt.Name = "lblAddAppt";
        lblAddAppt.Size = new System.Drawing.Size(73, 19);
        lblAddAppt.TabIndex = 16;
        lblAddAppt.Text = "Ngày hẹn";
        // 
        // cboAddStaff
        // 
        cboAddStaff.BackColor = System.Drawing.Color.White;
        cboAddStaff.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddStaff.Location = new System.Drawing.Point(20, 330);
        cboAddStaff.Name = "cboAddStaff";
        cboAddStaff.Size = new System.Drawing.Size(300, 32);
        cboAddStaff.TabIndex = 15;
        // 
        // lblAddStaff
        // 
        lblAddStaff.AutoSize = true;
        lblAddStaff.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddStaff.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddStaff.Location = new System.Drawing.Point(20, 307);
        lblAddStaff.Name = "lblAddStaff";
        lblAddStaff.Size = new System.Drawing.Size(137, 19);
        lblAddStaff.TabIndex = 14;
        lblAddStaff.Text = "Phụ trách tư vấn *";
        // 
        // cboAddCourse
        // 
        cboAddCourse.BackColor = System.Drawing.Color.White;
        cboAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddCourse.Location = new System.Drawing.Point(340, 255);
        cboAddCourse.Name = "cboAddCourse";
        cboAddCourse.Size = new System.Drawing.Size(300, 32);
        cboAddCourse.TabIndex = 13;
        // 
        // lblAddCourse
        // 
        lblAddCourse.AutoSize = true;
        lblAddCourse.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddCourse.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddCourse.Location = new System.Drawing.Point(340, 232);
        lblAddCourse.Name = "lblAddCourse";
        lblAddCourse.Size = new System.Drawing.Size(124, 19);
        lblAddCourse.TabIndex = 12;
        lblAddCourse.Text = "Khóa quan tâm *";
        // 
        // cboAddSource
        // 
        cboAddSource.BackColor = System.Drawing.Color.White;
        cboAddSource.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddSource.Location = new System.Drawing.Point(20, 255);
        cboAddSource.Name = "cboAddSource";
        cboAddSource.Size = new System.Drawing.Size(300, 32);
        cboAddSource.TabIndex = 11;
        // 
        // lblAddSource
        // 
        lblAddSource.AutoSize = true;
        lblAddSource.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddSource.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddSource.Location = new System.Drawing.Point(20, 232);
        lblAddSource.Name = "lblAddSource";
        lblAddSource.Size = new System.Drawing.Size(133, 19);
        lblAddSource.TabIndex = 10;
        lblAddSource.Text = "Nguồn tiếp nhận *";
        // 
        // txtAddEmail
        // 
        txtAddEmail.BackColor = System.Drawing.Color.Transparent;
        txtAddEmail.CornerRadius = 6;
        txtAddEmail.ErrorMessage = "";
        txtAddEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddEmail.HasError = false;
        txtAddEmail.Location = new System.Drawing.Point(340, 175);
        txtAddEmail.Name = "txtAddEmail";
        txtAddEmail.Placeholder = "minhanh@example.local";
        txtAddEmail.ReadOnly = false;
        txtAddEmail.Size = new System.Drawing.Size(300, 32);
        txtAddEmail.TabIndex = 9;
        txtAddEmail.UseSystemPasswordChar = false;
        // 
        // lblAddEmail
        // 
        lblAddEmail.AutoSize = true;
        lblAddEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddEmail.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddEmail.Location = new System.Drawing.Point(340, 152);
        lblAddEmail.Name = "lblAddEmail";
        lblAddEmail.Size = new System.Drawing.Size(100, 19);
        lblAddEmail.TabIndex = 8;
        lblAddEmail.Text = "Email liên hệ";
        // 
        // lblAddPhoneError
        // 
        lblAddPhoneError.AutoSize = true;
        lblAddPhoneError.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblAddPhoneError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        lblAddPhoneError.Location = new System.Drawing.Point(20, 210);
        lblAddPhoneError.Name = "lblAddPhoneError";
        lblAddPhoneError.Size = new System.Drawing.Size(232, 19);
        lblAddPhoneError.TabIndex = 7;
        lblAddPhoneError.Text = "Vui lòng nhập số điện thoại 10 chữ số.";
        // 
        // txtAddPhone
        // 
        txtAddPhone.BackColor = System.Drawing.Color.Transparent;
        txtAddPhone.CornerRadius = 6;
        txtAddPhone.ErrorMessage = "";
        txtAddPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddPhone.HasError = true;
        txtAddPhone.Location = new System.Drawing.Point(20, 175);
        txtAddPhone.Name = "txtAddPhone";
        txtAddPhone.Placeholder = "0908 123 456";
        txtAddPhone.ReadOnly = false;
        txtAddPhone.Size = new System.Drawing.Size(300, 32);
        txtAddPhone.TabIndex = 6;
        txtAddPhone.UseSystemPasswordChar = false;
        // 
        // lblAddPhone
        // 
        lblAddPhone.AutoSize = true;
        lblAddPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddPhone.Location = new System.Drawing.Point(20, 152);
        lblAddPhone.Name = "lblAddPhone";
        lblAddPhone.Size = new System.Drawing.Size(92, 19);
        lblAddPhone.TabIndex = 5;
        lblAddPhone.Text = "Điện thoại *";
        // 
        // dtpAddDob
        // 
        dtpAddDob.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpAddDob.CustomFormat = "dd/MM/yyyy";
        dtpAddDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpAddDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpAddDob.Location = new System.Drawing.Point(340, 95);
        dtpAddDob.Name = "dtpAddDob";
        dtpAddDob.Size = new System.Drawing.Size(300, 29);
        dtpAddDob.TabIndex = 4;
        // 
        // lblAddDob
        // 
        lblAddDob.AutoSize = true;
        lblAddDob.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddDob.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddDob.Location = new System.Drawing.Point(340, 72);
        lblAddDob.Name = "lblAddDob";
        lblAddDob.Size = new System.Drawing.Size(76, 19);
        lblAddDob.TabIndex = 3;
        lblAddDob.Text = "Ngày sinh";
        // 
        // txtAddName
        // 
        txtAddName.BackColor = System.Drawing.Color.Transparent;
        txtAddName.CornerRadius = 6;
        txtAddName.ErrorMessage = "";
        txtAddName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAddName.HasError = false;
        txtAddName.Location = new System.Drawing.Point(20, 95);
        txtAddName.Name = "txtAddName";
        txtAddName.Placeholder = "Nhập họ và tên...";
        txtAddName.ReadOnly = false;
        txtAddName.Size = new System.Drawing.Size(300, 32);
        txtAddName.TabIndex = 2;
        txtAddName.UseSystemPasswordChar = false;
        // 
        // lblAddName
        // 
        lblAddName.AutoSize = true;
        lblAddName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddName.Location = new System.Drawing.Point(20, 72);
        lblAddName.Name = "lblAddName";
        lblAddName.Size = new System.Drawing.Size(86, 19);
        lblAddName.TabIndex = 1;
        lblAddName.Text = "Họ và tên *";
        // 
        // lblAddFormTitle
        // 
        lblAddFormTitle.AutoSize = true;
        lblAddFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblAddFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAddFormTitle.Location = new System.Drawing.Point(20, 16);
        lblAddFormTitle.Name = "lblAddFormTitle";
        lblAddFormTitle.Size = new System.Drawing.Size(199, 28);
        lblAddFormTitle.TabIndex = 0;
        lblAddFormTitle.Text = "Thông tin tiếp nhận";
        // 
        // AddLeadDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(cardAddCheck);
        Controls.Add(cardAddForm);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddLeadDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm khách hàng tiềm năng — ECMS";
        cardAddCheck.ResumeLayout(false);
        cardAddCheck.PerformLayout();
        cardAddForm.ResumeLayout(false);
        cardAddForm.PerformLayout();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblAddLeadHeader;
    private System.Windows.Forms.Label lblAddLeadSub;
    private System.Windows.Forms.Label lblAddStep;

    private ECMS.UI.Controls.AppCard cardAddForm;
    private System.Windows.Forms.Label lblAddFormTitle;
    private System.Windows.Forms.Label lblAddName;
    private ECMS.UI.Controls.AppTextBox txtAddName;
    private System.Windows.Forms.Label lblAddDob;
    private System.Windows.Forms.DateTimePicker dtpAddDob;
    private System.Windows.Forms.Label lblAddPhone;
    private ECMS.UI.Controls.AppTextBox txtAddPhone;
    private System.Windows.Forms.Label lblAddPhoneError;
    private System.Windows.Forms.Label lblAddEmail;
    private ECMS.UI.Controls.AppTextBox txtAddEmail;
    private System.Windows.Forms.Label lblAddSource;
    private ECMS.UI.Controls.AppComboBox cboAddSource;
    private System.Windows.Forms.Label lblAddCourse;
    private ECMS.UI.Controls.AppComboBox cboAddCourse;
    private System.Windows.Forms.Label lblAddStaff;
    private ECMS.UI.Controls.AppComboBox cboAddStaff;
    private System.Windows.Forms.Label lblAddAppt;
    private ECMS.UI.Controls.AppTextBox txtAddAppt;
    private System.Windows.Forms.Label lblAddNotes;
    private ECMS.UI.Controls.AppTextBox txtAddNotes;
    private ECMS.UI.Controls.AppButton btnCancelAdd;
    private ECMS.UI.Controls.AppButton btnSaveAdd;

    private ECMS.UI.Controls.AppCard cardAddCheck;
    private System.Windows.Forms.Label lblAddCheckTitle;
    private ECMS.UI.Controls.AppBanner bannerAddWarn;
    private System.Windows.Forms.Label lblAddRules;
    private System.Windows.Forms.Label lblAddMeta;
}
