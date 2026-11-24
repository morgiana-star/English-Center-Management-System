namespace ECMS.UI.Forms;

partial class AddTeacherDialog
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
        lblTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        cardTeacherInfo = new ECMS.UI.Controls.AppCard();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        txtBio = new ECMS.UI.Controls.AppTextBox();
        lblBio = new System.Windows.Forms.Label();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        txtCert = new ECMS.UI.Controls.AppTextBox();
        lblCert = new System.Windows.Forms.Label();
        cboSpecialty = new ECMS.UI.Controls.AppComboBox();
        lblSpecialty = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        txtTeacherCode = new ECMS.UI.Controls.AppTextBox();
        lblTeacherCode = new System.Windows.Forms.Label();
        lblTeacherInfoTitle = new System.Windows.Forms.Label();
        lblScheduleBoxTitle = new System.Windows.Forms.Label();
        lblPreferredSlotTitle = new System.Windows.Forms.Label();
        chkMorning = new System.Windows.Forms.CheckBox();
        chkAfternoon = new System.Windows.Forms.CheckBox();
        chkEvening = new System.Windows.Forms.CheckBox();
        lblDaysTitle = new System.Windows.Forms.Label();
        chkMon = new System.Windows.Forms.CheckBox();
        chkTue = new System.Windows.Forms.CheckBox();
        chkWed = new System.Windows.Forms.CheckBox();
        chkThu = new System.Windows.Forms.CheckBox();
        chkFri = new System.Windows.Forms.CheckBox();
        chkSat = new System.Windows.Forms.CheckBox();
        chkSun = new System.Windows.Forms.CheckBox();
        pnlScheduleBox = new System.Windows.Forms.Panel();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        cardTeacherInfo.SuspendLayout();
        pnlScheduleBox.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(860, 68);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(24, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(240, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thêm giáo viên mới";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlContent.Controls.Add(cardTeacherInfo);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 68);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24, 16, 24, 24);
        pnlContent.Size = new System.Drawing.Size(860, 772);
        pnlContent.TabIndex = 1;
        // 
        // cardTeacherInfo
        // 
        cardTeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardTeacherInfo.BackColor = System.Drawing.Color.White;
        cardTeacherInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTeacherInfo.BorderWidth = 1;
        cardTeacherInfo.Controls.Add(btnSave);
        cardTeacherInfo.Controls.Add(btnCancel);
        cardTeacherInfo.Controls.Add(pnlScheduleBox);
        cardTeacherInfo.Controls.Add(txtBio);
        cardTeacherInfo.Controls.Add(lblBio);
        cardTeacherInfo.Controls.Add(cboStatus);
        cardTeacherInfo.Controls.Add(lblStatus);
        cardTeacherInfo.Controls.Add(txtCert);
        cardTeacherInfo.Controls.Add(lblCert);
        cardTeacherInfo.Controls.Add(cboSpecialty);
        cardTeacherInfo.Controls.Add(lblSpecialty);
        cardTeacherInfo.Controls.Add(txtEmail);
        cardTeacherInfo.Controls.Add(lblEmail);
        cardTeacherInfo.Controls.Add(txtPhone);
        cardTeacherInfo.Controls.Add(lblPhone);
        cardTeacherInfo.Controls.Add(txtFullName);
        cardTeacherInfo.Controls.Add(lblFullName);
        cardTeacherInfo.Controls.Add(txtTeacherCode);
        cardTeacherInfo.Controls.Add(lblTeacherCode);
        cardTeacherInfo.Controls.Add(lblTeacherInfoTitle);
        cardTeacherInfo.CornerRadius = 8;
        cardTeacherInfo.Location = new System.Drawing.Point(24, 16);
        cardTeacherInfo.Name = "cardTeacherInfo";
        cardTeacherInfo.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherInfo.Size = new System.Drawing.Size(812, 730);
        cardTeacherInfo.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 6;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(650, 665);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(140, 42);
        btnSave.TabIndex = 19;
        btnSave.Text = "Lưu giáo viên";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 6;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnCancel.Location = new System.Drawing.Point(525, 665);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(115, 42);
        btnCancel.TabIndex = 18;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtBio
        // 
        txtBio.BackColor = System.Drawing.Color.Transparent;
        txtBio.CornerRadius = 5;
        txtBio.ErrorMessage = "";
        txtBio.HasError = false;
        txtBio.Location = new System.Drawing.Point(16, 284);
        txtBio.Name = "txtBio";
        txtBio.Placeholder = "Kinh nghiệm giảng dạy, phong cách sư phạm...";
        txtBio.ReadOnly = false;
        txtBio.Size = new System.Drawing.Size(774, 48);
        txtBio.TabIndex = 16;
        txtBio.UseSystemPasswordChar = false;
        // 
        // lblBio
        // 
        lblBio.AutoSize = true;
        lblBio.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblBio.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblBio.Location = new System.Drawing.Point(16, 260);
        lblBio.Name = "lblBio";
        lblBio.Size = new System.Drawing.Size(155, 20);
        lblBio.TabIndex = 15;
        lblBio.Text = "Ghi chú / Kinh nghiệm";
        // 
        // cboStatus
        // 
        cboStatus.BackColor = System.Drawing.Color.Transparent;
        cboStatus.CornerRadius = 5;
        cboStatus.DataSource = null;
        cboStatus.DisplayMember = "";
        cboStatus.Location = new System.Drawing.Point(555, 144);
        cboStatus.Name = "cboStatus";
        cboStatus.SelectedIndex = -1;
        cboStatus.SelectedItem = null;
        cboStatus.SelectedValue = null;
        cboStatus.Size = new System.Drawing.Size(235, 36);
        cboStatus.TabIndex = 12;
        cboStatus.ValueMember = "";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatus.Location = new System.Drawing.Point(555, 120);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(85, 20);
        lblStatus.TabIndex = 11;
        lblStatus.Text = "Trạng thái *";
        // 
        // txtCert
        // 
        txtCert.BackColor = System.Drawing.Color.Transparent;
        txtCert.CornerRadius = 5;
        txtCert.ErrorMessage = "";
        txtCert.HasError = false;
        txtCert.Location = new System.Drawing.Point(16, 214);
        txtCert.Name = "txtCert";
        txtCert.Placeholder = "VD: IELTS 8.5, Thạc sĩ TESOL ĐH Sư Phạm, Cử nhân Ngôn ngữ Anh...";
        txtCert.ReadOnly = false;
        txtCert.Size = new System.Drawing.Size(774, 36);
        txtCert.TabIndex = 14;
        txtCert.UseSystemPasswordChar = false;
        // 
        // lblCert
        // 
        lblCert.AutoSize = true;
        lblCert.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCert.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCert.Location = new System.Drawing.Point(16, 190);
        lblCert.Name = "lblCert";
        lblCert.Size = new System.Drawing.Size(151, 20);
        lblCert.TabIndex = 13;
        lblCert.Text = "Bằng cấp / Chứng chỉ";
        // 
        // cboSpecialty
        // 
        cboSpecialty.BackColor = System.Drawing.Color.Transparent;
        cboSpecialty.CornerRadius = 5;
        cboSpecialty.DataSource = null;
        cboSpecialty.DisplayMember = "";
        cboSpecialty.Location = new System.Drawing.Point(555, 74);
        cboSpecialty.Name = "cboSpecialty";
        cboSpecialty.SelectedIndex = -1;
        cboSpecialty.SelectedItem = null;
        cboSpecialty.SelectedValue = null;
        cboSpecialty.Size = new System.Drawing.Size(235, 36);
        cboSpecialty.TabIndex = 6;
        cboSpecialty.ValueMember = "";
        // 
        // lblSpecialty
        // 
        lblSpecialty.AutoSize = true;
        lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSpecialty.Location = new System.Drawing.Point(555, 50);
        lblSpecialty.Name = "lblSpecialty";
        lblSpecialty.Size = new System.Drawing.Size(101, 20);
        lblSpecialty.TabIndex = 5;
        lblSpecialty.Text = "Chuyên môn *";
        // 
        // txtEmail
        // 
        txtEmail.BackColor = System.Drawing.Color.Transparent;
        txtEmail.CornerRadius = 5;
        txtEmail.ErrorMessage = "";
        txtEmail.HasError = false;
        txtEmail.Location = new System.Drawing.Point(275, 144);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "VD: teacher@ecms.edu.vn";
        txtEmail.ReadOnly = false;
        txtEmail.Size = new System.Drawing.Size(260, 36);
        txtEmail.TabIndex = 10;
        txtEmail.UseSystemPasswordChar = false;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblEmail.Location = new System.Drawing.Point(275, 120);
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
        txtPhone.Location = new System.Drawing.Point(16, 144);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "VD: 0912 334 556";
        txtPhone.ReadOnly = false;
        txtPhone.Size = new System.Drawing.Size(240, 36);
        txtPhone.TabIndex = 8;
        txtPhone.UseSystemPasswordChar = false;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPhone.Location = new System.Drawing.Point(16, 120);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(107, 20);
        lblPhone.TabIndex = 7;
        lblPhone.Text = "Số điện thoại *";
        // 
        // txtFullName
        // 
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(195, 74);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên giáo viên...";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(340, 36);
        txtFullName.TabIndex = 4;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFullName.Location = new System.Drawing.Point(195, 50);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(83, 20);
        lblFullName.TabIndex = 3;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtTeacherCode
        // 
        txtTeacherCode.BackColor = System.Drawing.Color.Transparent;
        txtTeacherCode.CornerRadius = 5;
        txtTeacherCode.ErrorMessage = "";
        txtTeacherCode.HasError = false;
        txtTeacherCode.Location = new System.Drawing.Point(16, 74);
        txtTeacherCode.Name = "txtTeacherCode";
        txtTeacherCode.Placeholder = "GV-00xx";
        txtTeacherCode.ReadOnly = false;
        txtTeacherCode.Size = new System.Drawing.Size(160, 36);
        txtTeacherCode.TabIndex = 2;
        txtTeacherCode.UseSystemPasswordChar = false;
        // 
        // lblTeacherCode
        // 
        lblTeacherCode.AutoSize = true;
        lblTeacherCode.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTeacherCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTeacherCode.Location = new System.Drawing.Point(16, 50);
        lblTeacherCode.Name = "lblTeacherCode";
        lblTeacherCode.Size = new System.Drawing.Size(105, 20);
        lblTeacherCode.TabIndex = 1;
        lblTeacherCode.Text = "Mã giáo viên *";
        // 
        // lblTeacherInfoTitle
        // 
        lblTeacherInfoTitle.AutoSize = true;
        lblTeacherInfoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTeacherInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTeacherInfoTitle.Location = new System.Drawing.Point(16, 16);
        lblTeacherInfoTitle.Name = "lblTeacherInfoTitle";
        lblTeacherInfoTitle.Size = new System.Drawing.Size(185, 25);
        lblTeacherInfoTitle.TabIndex = 0;
        lblTeacherInfoTitle.Text = "Thông tin giáo viên";
        // 
        // lblScheduleBoxTitle
        // 
        lblScheduleBoxTitle.AutoSize = true;
        lblScheduleBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblScheduleBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblScheduleBoxTitle.Location = new System.Drawing.Point(12, 12);
        lblScheduleBoxTitle.Name = "lblScheduleBoxTitle";
        lblScheduleBoxTitle.Size = new System.Drawing.Size(167, 25);
        lblScheduleBoxTitle.TabIndex = 0;
        lblScheduleBoxTitle.Text = "Thời gian làm việc";
        // 
        // lblMaxHoursTitle
        // 
        // 
        // lblPreferredSlotTitle
        // 
        lblPreferredSlotTitle.AutoSize = true;
        lblPreferredSlotTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPreferredSlotTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPreferredSlotTitle.Location = new System.Drawing.Point(14, 44);
        lblPreferredSlotTitle.Name = "lblPreferredSlotTitle";
        lblPreferredSlotTitle.Size = new System.Drawing.Size(349, 20);
        lblPreferredSlotTitle.TabIndex = 5;
        lblPreferredSlotTitle.Text = "Khung giờ ưu tiên giảng dạy (Có thể chọn nhiều)";
        // 
        // chkMorning
        // 
        chkMorning.AutoSize = true;
        chkMorning.Checked = true;
        chkMorning.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMorning.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkMorning.Location = new System.Drawing.Point(16, 70);
        chkMorning.Name = "chkMorning";
        chkMorning.Size = new System.Drawing.Size(183, 24);
        chkMorning.TabIndex = 6;
        chkMorning.Text = "Ca Sáng (08:00 - 12:00)";
        chkMorning.UseVisualStyleBackColor = true;
        // 
        // chkAfternoon
        // 
        chkAfternoon.AutoSize = true;
        chkAfternoon.Checked = true;
        chkAfternoon.CheckState = System.Windows.Forms.CheckState.Checked;
        chkAfternoon.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkAfternoon.Location = new System.Drawing.Point(220, 70);
        chkAfternoon.Name = "chkAfternoon";
        chkAfternoon.Size = new System.Drawing.Size(187, 24);
        chkAfternoon.TabIndex = 7;
        chkAfternoon.Text = "Ca Chiều (13:30 - 17:30)";
        chkAfternoon.UseVisualStyleBackColor = true;
        // 
        // chkEvening
        // 
        chkEvening.AutoSize = true;
        chkEvening.Checked = true;
        chkEvening.CheckState = System.Windows.Forms.CheckState.Checked;
        chkEvening.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkEvening.Location = new System.Drawing.Point(425, 70);
        chkEvening.Name = "chkEvening";
        chkEvening.Size = new System.Drawing.Size(171, 24);
        chkEvening.TabIndex = 8;
        chkEvening.Text = "Ca Tối (18:00 - 21:00)";
        chkEvening.UseVisualStyleBackColor = true;
        // 
        // lblDaysTitle
        // 
        lblDaysTitle.AutoSize = true;
        lblDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDaysTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblDaysTitle.Location = new System.Drawing.Point(14, 108);
        lblDaysTitle.Name = "lblDaysTitle";
        lblDaysTitle.Size = new System.Drawing.Size(201, 20);
        lblDaysTitle.TabIndex = 9;
        lblDaysTitle.Text = "Các ngày có thể giảng dạy *";
        // 
        // chkMon
        // 
        chkMon.AutoSize = true;
        chkMon.Checked = true;
        chkMon.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMon.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkMon.Location = new System.Drawing.Point(16, 136);
        chkMon.Name = "chkMon";
        chkMon.Size = new System.Drawing.Size(83, 24);
        chkMon.TabIndex = 10;
        chkMon.Text = "Thứ Hai";
        chkMon.UseVisualStyleBackColor = true;
        // 
        // chkTue
        // 
        chkTue.AutoSize = true;
        chkTue.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkTue.Location = new System.Drawing.Point(160, 136);
        chkTue.Name = "chkTue";
        chkTue.Size = new System.Drawing.Size(77, 24);
        chkTue.TabIndex = 11;
        chkTue.Text = "Thứ Ba";
        chkTue.UseVisualStyleBackColor = true;
        // 
        // chkWed
        // 
        chkWed.AutoSize = true;
        chkWed.Checked = true;
        chkWed.CheckState = System.Windows.Forms.CheckState.Checked;
        chkWed.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkWed.Location = new System.Drawing.Point(280, 136);
        chkWed.Name = "chkWed";
        chkWed.Size = new System.Drawing.Size(77, 24);
        chkWed.TabIndex = 12;
        chkWed.Text = "Thứ Tư";
        chkWed.UseVisualStyleBackColor = true;
        // 
        // chkThu
        // 
        chkThu.AutoSize = true;
        chkThu.Checked = true;
        chkThu.CheckState = System.Windows.Forms.CheckState.Checked;
        chkThu.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkThu.Location = new System.Drawing.Point(400, 136);
        chkThu.Name = "chkThu";
        chkThu.Size = new System.Drawing.Size(92, 24);
        chkThu.TabIndex = 13;
        chkThu.Text = "Thứ Năm";
        chkThu.UseVisualStyleBackColor = true;
        // 
        // chkFri
        // 
        chkFri.AutoSize = true;
        chkFri.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkFri.Location = new System.Drawing.Point(16, 170);
        chkFri.Name = "chkFri";
        chkFri.Size = new System.Drawing.Size(84, 24);
        chkFri.TabIndex = 14;
        chkFri.Text = "Thứ Sáu";
        chkFri.UseVisualStyleBackColor = true;
        // 
        // chkSat
        // 
        chkSat.AutoSize = true;
        chkSat.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkSat.Location = new System.Drawing.Point(160, 170);
        chkSat.Name = "chkSat";
        chkSat.Size = new System.Drawing.Size(84, 24);
        chkSat.TabIndex = 15;
        chkSat.Text = "Thứ Bảy";
        chkSat.UseVisualStyleBackColor = true;
        // 
        // chkSun
        // 
        chkSun.AutoSize = true;
        chkSun.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkSun.Location = new System.Drawing.Point(280, 170);
        chkSun.Name = "chkSun";
        chkSun.Size = new System.Drawing.Size(92, 24);
        chkSun.TabIndex = 16;
        chkSun.Text = "Chủ Nhật";
        chkSun.UseVisualStyleBackColor = true;
        // 
        // pnlScheduleBox
        // 
        pnlScheduleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlScheduleBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlScheduleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        pnlScheduleBox.Controls.Add(chkSun);
        pnlScheduleBox.Controls.Add(chkSat);
        pnlScheduleBox.Controls.Add(chkFri);
        pnlScheduleBox.Controls.Add(chkThu);
        pnlScheduleBox.Controls.Add(chkWed);
        pnlScheduleBox.Controls.Add(chkTue);
        pnlScheduleBox.Controls.Add(chkMon);
        pnlScheduleBox.Controls.Add(lblDaysTitle);
        pnlScheduleBox.Controls.Add(chkEvening);
        pnlScheduleBox.Controls.Add(chkAfternoon);
        pnlScheduleBox.Controls.Add(chkMorning);
        pnlScheduleBox.Controls.Add(lblPreferredSlotTitle);
        pnlScheduleBox.Controls.Add(lblScheduleBoxTitle);
        pnlScheduleBox.Location = new System.Drawing.Point(16, 345);
        pnlScheduleBox.Name = "pnlScheduleBox";
        pnlScheduleBox.Padding = new System.Windows.Forms.Padding(16);
        pnlScheduleBox.Size = new System.Drawing.Size(774, 305);
        pnlScheduleBox.TabIndex = 17;
        // 
        // AddTeacherDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(860, 840);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm giáo viên mới — ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        cardTeacherInfo.ResumeLayout(false);
        cardTeacherInfo.PerformLayout();
        pnlScheduleBox.ResumeLayout(false);
        pnlScheduleBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlContent;

    private ECMS.UI.Controls.AppCard cardTeacherInfo;
    private System.Windows.Forms.Label lblTeacherInfoTitle;
    private System.Windows.Forms.Label lblTeacherCode;
    private ECMS.UI.Controls.AppTextBox txtTeacherCode;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblSpecialty;
    private ECMS.UI.Controls.AppComboBox cboSpecialty;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private System.Windows.Forms.Label lblCert;
    private ECMS.UI.Controls.AppTextBox txtCert;
    private System.Windows.Forms.Label lblBio;
    private ECMS.UI.Controls.AppTextBox txtBio;

    private System.Windows.Forms.Panel pnlScheduleBox;
    private System.Windows.Forms.Label lblScheduleBoxTitle;
    private System.Windows.Forms.Label lblPreferredSlotTitle;
    private System.Windows.Forms.CheckBox chkMorning;
    private System.Windows.Forms.CheckBox chkAfternoon;
    private System.Windows.Forms.CheckBox chkEvening;
    private System.Windows.Forms.Label lblDaysTitle;
    private System.Windows.Forms.CheckBox chkMon;
    private System.Windows.Forms.CheckBox chkTue;
    private System.Windows.Forms.CheckBox chkWed;
    private System.Windows.Forms.CheckBox chkThu;
    private System.Windows.Forms.CheckBox chkFri;
    private System.Windows.Forms.CheckBox chkSat;
    private System.Windows.Forms.CheckBox chkSun;

    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
}
