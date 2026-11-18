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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
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
        lblAddLeadHeader = new System.Windows.Forms.Label();
        pnlTop = new System.Windows.Forms.Panel();
        cardAddForm.SuspendLayout();
        pnlTop.SuspendLayout();
        SuspendLayout();
        // 
        // cardAddForm
        // 
        cardAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAddForm.BackColor = System.Drawing.Color.White;
        cardAddForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
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
        cardAddForm.Location = new System.Drawing.Point(22, 80);
        cardAddForm.Name = "cardAddForm";
        cardAddForm.Padding = new System.Windows.Forms.Padding(16);
        cardAddForm.Size = new System.Drawing.Size(1153, 530);
        cardAddForm.TabIndex = 1;
        // 
        // btnSaveAdd
        // 
        btnSaveAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveAdd.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveAdd.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAdd.CornerRadius = 6;
        btnSaveAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAdd.ForeColor = System.Drawing.Color.White;
        btnSaveAdd.Location = new System.Drawing.Point(998, 475);
        btnSaveAdd.Name = "btnSaveAdd";
        btnSaveAdd.Size = new System.Drawing.Size(135, 36);
        btnSaveAdd.TabIndex = 21;
        btnSaveAdd.Text = "Lưu tiềm năng";
        btnSaveAdd.UseVisualStyleBackColor = false;
        btnSaveAdd.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
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
        btnCancelAdd.Location = new System.Drawing.Point(898, 475);
        btnCancelAdd.Name = "btnCancelAdd";
        btnCancelAdd.Size = new System.Drawing.Size(90, 36);
        btnCancelAdd.TabIndex = 20;
        btnCancelAdd.Text = "Hủy";
        btnCancelAdd.UseVisualStyleBackColor = false;
        btnCancelAdd.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
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
        txtAddNotes.Size = new System.Drawing.Size(950, 55);
        txtAddNotes.TabIndex = 19;
        txtAddNotes.UseSystemPasswordChar = false;
        // 
        // lblAddNotes
        // 
        lblAddNotes.AutoSize = true;
        lblAddNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddNotes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddNotes.Location = new System.Drawing.Point(20, 377);
        lblAddNotes.Name = "lblAddNotes";
        lblAddNotes.Size = new System.Drawing.Size(136, 20);
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
        txtAddAppt.Location = new System.Drawing.Point(536, 330);
        txtAddAppt.Name = "txtAddAppt";
        txtAddAppt.Placeholder = "02/10/2026 · 14:00";
        txtAddAppt.ReadOnly = false;
        txtAddAppt.Size = new System.Drawing.Size(434, 32);
        txtAddAppt.TabIndex = 17;
        txtAddAppt.UseSystemPasswordChar = false;
        // 
        // lblAddAppt
        // 
        lblAddAppt.AutoSize = true;
        lblAddAppt.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddAppt.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddAppt.Location = new System.Drawing.Point(536, 307);
        lblAddAppt.Name = "lblAddAppt";
        lblAddAppt.Size = new System.Drawing.Size(76, 20);
        lblAddAppt.TabIndex = 16;
        lblAddAppt.Text = "Ngày hẹn";
        // 
        // cboAddStaff
        // 
        cboAddStaff.BackColor = System.Drawing.Color.White;
        cboAddStaff.CornerRadius = 5;
        cboAddStaff.DataSource = null;
        cboAddStaff.DisplayMember = "";
        cboAddStaff.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddStaff.Location = new System.Drawing.Point(20, 330);
        cboAddStaff.Name = "cboAddStaff";
        cboAddStaff.SelectedIndex = -1;
        cboAddStaff.SelectedItem = null;
        cboAddStaff.SelectedValue = null;
        cboAddStaff.Size = new System.Drawing.Size(434, 32);
        cboAddStaff.TabIndex = 15;
        cboAddStaff.ValueMember = "";
        // 
        // lblAddStaff
        // 
        lblAddStaff.AutoSize = true;
        lblAddStaff.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddStaff.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddStaff.Location = new System.Drawing.Point(20, 307);
        lblAddStaff.Name = "lblAddStaff";
        lblAddStaff.Size = new System.Drawing.Size(136, 20);
        lblAddStaff.TabIndex = 14;
        lblAddStaff.Text = "Phụ trách tư vấn *";
        // 
        // cboAddCourse
        // 
        cboAddCourse.BackColor = System.Drawing.Color.White;
        cboAddCourse.CornerRadius = 5;
        cboAddCourse.DataSource = null;
        cboAddCourse.DisplayMember = "";
        cboAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddCourse.Location = new System.Drawing.Point(536, 255);
        cboAddCourse.Name = "cboAddCourse";
        cboAddCourse.SelectedIndex = -1;
        cboAddCourse.SelectedItem = null;
        cboAddCourse.SelectedValue = null;
        cboAddCourse.Size = new System.Drawing.Size(434, 32);
        cboAddCourse.TabIndex = 13;
        cboAddCourse.ValueMember = "";
        // 
        // lblAddCourse
        // 
        lblAddCourse.AutoSize = true;
        lblAddCourse.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddCourse.Location = new System.Drawing.Point(536, 232);
        lblAddCourse.Name = "lblAddCourse";
        lblAddCourse.Size = new System.Drawing.Size(127, 20);
        lblAddCourse.TabIndex = 12;
        lblAddCourse.Text = "Khóa quan tâm *";
        // 
        // cboAddSource
        // 
        cboAddSource.BackColor = System.Drawing.Color.White;
        cboAddSource.CornerRadius = 5;
        cboAddSource.DataSource = null;
        cboAddSource.DisplayMember = "";
        cboAddSource.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAddSource.Location = new System.Drawing.Point(20, 255);
        cboAddSource.Name = "cboAddSource";
        cboAddSource.SelectedIndex = -1;
        cboAddSource.SelectedItem = null;
        cboAddSource.SelectedValue = null;
        cboAddSource.Size = new System.Drawing.Size(434, 32);
        cboAddSource.TabIndex = 11;
        cboAddSource.ValueMember = "";
        // 
        // lblAddSource
        // 
        lblAddSource.AutoSize = true;
        lblAddSource.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddSource.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddSource.Location = new System.Drawing.Point(20, 232);
        lblAddSource.Name = "lblAddSource";
        lblAddSource.Size = new System.Drawing.Size(138, 20);
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
        txtAddEmail.Location = new System.Drawing.Point(536, 175);
        txtAddEmail.Name = "txtAddEmail";
        txtAddEmail.Placeholder = "minhanh@example.local";
        txtAddEmail.ReadOnly = false;
        txtAddEmail.Size = new System.Drawing.Size(434, 32);
        txtAddEmail.TabIndex = 9;
        txtAddEmail.UseSystemPasswordChar = false;
        // 
        // lblAddEmail
        // 
        lblAddEmail.AutoSize = true;
        lblAddEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddEmail.Location = new System.Drawing.Point(536, 152);
        lblAddEmail.Name = "lblAddEmail";
        lblAddEmail.Size = new System.Drawing.Size(97, 20);
        lblAddEmail.TabIndex = 8;
        lblAddEmail.Text = "Email liên hệ";
        // 
        // lblAddPhoneError
        // 
        lblAddPhoneError.AutoSize = true;
        lblAddPhoneError.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblAddPhoneError.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblAddPhoneError.Location = new System.Drawing.Point(20, 210);
        lblAddPhoneError.Name = "lblAddPhoneError";
        lblAddPhoneError.Size = new System.Drawing.Size(245, 19);
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
        txtAddPhone.Size = new System.Drawing.Size(434, 32);
        txtAddPhone.TabIndex = 6;
        txtAddPhone.UseSystemPasswordChar = false;
        // 
        // lblAddPhone
        // 
        lblAddPhone.AutoSize = true;
        lblAddPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddPhone.Location = new System.Drawing.Point(20, 152);
        lblAddPhone.Name = "lblAddPhone";
        lblAddPhone.Size = new System.Drawing.Size(92, 20);
        lblAddPhone.TabIndex = 5;
        lblAddPhone.Text = "Điện thoại *";
        // 
        // dtpAddDob
        // 
        dtpAddDob.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpAddDob.CustomFormat = "dd/MM/yyyy";
        dtpAddDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpAddDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpAddDob.Location = new System.Drawing.Point(536, 95);
        dtpAddDob.Name = "dtpAddDob";
        dtpAddDob.Size = new System.Drawing.Size(434, 29);
        dtpAddDob.TabIndex = 4;
        // 
        // lblAddDob
        // 
        lblAddDob.AutoSize = true;
        lblAddDob.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddDob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddDob.Location = new System.Drawing.Point(536, 72);
        lblAddDob.Name = "lblAddDob";
        lblAddDob.Size = new System.Drawing.Size(79, 20);
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
        txtAddName.Size = new System.Drawing.Size(434, 32);
        txtAddName.TabIndex = 2;
        txtAddName.UseSystemPasswordChar = false;
        // 
        // lblAddName
        // 
        lblAddName.AutoSize = true;
        lblAddName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAddName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddName.Location = new System.Drawing.Point(20, 72);
        lblAddName.Name = "lblAddName";
        lblAddName.Size = new System.Drawing.Size(87, 20);
        lblAddName.TabIndex = 1;
        lblAddName.Text = "Họ và tên *";
        // 
        // lblAddFormTitle
        // 
        lblAddFormTitle.AutoSize = true;
        lblAddFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblAddFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddFormTitle.Location = new System.Drawing.Point(20, 16);
        lblAddFormTitle.Name = "lblAddFormTitle";
        lblAddFormTitle.Size = new System.Drawing.Size(200, 28);
        lblAddFormTitle.TabIndex = 0;
        lblAddFormTitle.Text = "Thông tin tiếp nhận";
        // 
        // lblAddLeadHeader
        // 
        lblAddLeadHeader.AutoSize = true;
        lblAddLeadHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblAddLeadHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAddLeadHeader.Location = new System.Drawing.Point(22, 10);
        lblAddLeadHeader.Name = "lblAddLeadHeader";
        lblAddLeadHeader.Size = new System.Drawing.Size(349, 35);
        lblAddLeadHeader.TabIndex = 0;
        lblAddLeadHeader.Text = "Thêm khách hàng tiềm năng";
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblAddLeadHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1200, 59);
        pnlTop.TabIndex = 0;
        // 
        // AddLeadDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(cardAddForm);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm khách hàng tiềm năng — ECMS";
        cardAddForm.ResumeLayout(false);
        cardAddForm.PerformLayout();
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblAddLeadHeader;

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
}
