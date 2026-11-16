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

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        cardTeacherInfo = new ECMS.UI.Controls.AppCard();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlScheduleBox = new System.Windows.Forms.Panel();
        chkSun = new System.Windows.Forms.CheckBox();
        chkSat = new System.Windows.Forms.CheckBox();
        chkFri = new System.Windows.Forms.CheckBox();
        chkThu = new System.Windows.Forms.CheckBox();
        chkWed = new System.Windows.Forms.CheckBox();
        chkTue = new System.Windows.Forms.CheckBox();
        chkMon = new System.Windows.Forms.CheckBox();
        lblDaysTitle = new System.Windows.Forms.Label();
        chkEvening = new System.Windows.Forms.CheckBox();
        chkAfternoon = new System.Windows.Forms.CheckBox();
        chkMorning = new System.Windows.Forms.CheckBox();
        lblPreferredSlotTitle = new System.Windows.Forms.Label();
        lblMaxHoursNote = new System.Windows.Forms.Label();
        lblHourUnit = new System.Windows.Forms.Label();
        txtMaxHours = new ECMS.UI.Controls.AppTextBox();
        lblMaxHoursTitle = new System.Windows.Forms.Label();
        lblScheduleBoxTitle = new System.Windows.Forms.Label();
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
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(24, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(236, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thêm giáo viên mới";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
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
        cardTeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        cardTeacherInfo.BackColor = System.Drawing.Color.White;
        cardTeacherInfo.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
        // lblTeacherInfoTitle
        // 
        lblTeacherInfoTitle.AutoSize = true;
        lblTeacherInfoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTeacherInfoTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTeacherInfoTitle.Location = new System.Drawing.Point(16, 16);
        lblTeacherInfoTitle.Name = "lblTeacherInfoTitle";
        lblTeacherInfoTitle.Size = new System.Drawing.Size(185, 25);
        lblTeacherInfoTitle.TabIndex = 0;
        lblTeacherInfoTitle.Text = "Thông tin giáo viên";
        // 
        // lblTeacherCode
        // 
        lblTeacherCode.AutoSize = true;
        lblTeacherCode.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTeacherCode.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblTeacherCode.Location = new System.Drawing.Point(16, 50);
        lblTeacherCode.Name = "lblTeacherCode";
        lblTeacherCode.Size = new System.Drawing.Size(107, 20);
        lblTeacherCode.TabIndex = 1;
        lblTeacherCode.Text = "Mã giáo viên *";
        // 
        // txtTeacherCode
        // 
        txtTeacherCode.Location = new System.Drawing.Point(16, 74);
        txtTeacherCode.Name = "txtTeacherCode";
        txtTeacherCode.Placeholder = "GV-00xx";
        txtTeacherCode.Size = new System.Drawing.Size(160, 36);
        txtTeacherCode.TabIndex = 2;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblFullName.Location = new System.Drawing.Point(195, 50);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(86, 20);
        lblFullName.TabIndex = 3;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtFullName
        // 
        txtFullName.Location = new System.Drawing.Point(195, 74);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên giáo viên...";
        txtFullName.Size = new System.Drawing.Size(340, 36);
        txtFullName.TabIndex = 4;
        // 
        // lblSpecialty
        // 
        lblSpecialty.AutoSize = true;
        lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSpecialty.Location = new System.Drawing.Point(555, 50);
        lblSpecialty.Name = "lblSpecialty";
        lblSpecialty.Size = new System.Drawing.Size(102, 20);
        lblSpecialty.TabIndex = 5;
        lblSpecialty.Text = "Chuyên môn *";
        // 
        // cboSpecialty
        // 
        cboSpecialty.Location = new System.Drawing.Point(555, 74);
        cboSpecialty.Name = "cboSpecialty";
        cboSpecialty.Size = new System.Drawing.Size(235, 36);
        cboSpecialty.TabIndex = 6;
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblPhone.Location = new System.Drawing.Point(16, 120);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(108, 20);
        lblPhone.TabIndex = 7;
        lblPhone.Text = "Số điện thoại *";
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(16, 144);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "VD: 0912 334 556";
        txtPhone.Size = new System.Drawing.Size(240, 36);
        txtPhone.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblEmail.Location = new System.Drawing.Point(275, 120);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(46, 20);
        lblEmail.TabIndex = 9;
        lblEmail.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(275, 144);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "VD: teacher@ecms.edu.vn";
        txtEmail.Size = new System.Drawing.Size(260, 36);
        txtEmail.TabIndex = 10;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStatus.Location = new System.Drawing.Point(555, 120);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(86, 20);
        lblStatus.TabIndex = 11;
        lblStatus.Text = "Trạng thái *";
        // 
        // cboStatus
        // 
        cboStatus.Location = new System.Drawing.Point(555, 144);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new System.Drawing.Size(235, 36);
        cboStatus.TabIndex = 12;
        // 
        // lblCert
        // 
        lblCert.AutoSize = true;
        lblCert.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCert.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblCert.Location = new System.Drawing.Point(16, 190);
        lblCert.Name = "lblCert";
        lblCert.Size = new System.Drawing.Size(147, 20);
        lblCert.TabIndex = 13;
        lblCert.Text = "Bằng cấp / Chứng chỉ";
        // 
        // txtCert
        // 
        txtCert.Location = new System.Drawing.Point(16, 214);
        txtCert.Name = "txtCert";
        txtCert.Placeholder = "VD: IELTS 8.5, Thạc sĩ TESOL ĐH Sư Phạm, Cử nhân Ngôn ngữ Anh...";
        txtCert.Size = new System.Drawing.Size(774, 36);
        txtCert.TabIndex = 14;
        // 
        // lblBio
        // 
        lblBio.AutoSize = true;
        lblBio.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblBio.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBio.Location = new System.Drawing.Point(16, 260);
        lblBio.Name = "lblBio";
        lblBio.Size = new System.Drawing.Size(155, 20);
        lblBio.TabIndex = 15;
        lblBio.Text = "Ghi chú / Kinh nghiệm";
        // 
        // txtBio
        // 
        txtBio.Location = new System.Drawing.Point(16, 284);
        txtBio.Name = "txtBio";
        txtBio.Placeholder = "Kinh nghiệm giảng dạy, phong cách sư phạm...";
        txtBio.Size = new System.Drawing.Size(774, 48);
        txtBio.TabIndex = 16;
        // 
        // pnlScheduleBox
        // 
        pnlScheduleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        pnlScheduleBox.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlScheduleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
        pnlScheduleBox.Controls.Add(lblMaxHoursNote);
        pnlScheduleBox.Controls.Add(lblHourUnit);
        pnlScheduleBox.Controls.Add(txtMaxHours);
        pnlScheduleBox.Controls.Add(lblMaxHoursTitle);
        pnlScheduleBox.Controls.Add(lblScheduleBoxTitle);
        pnlScheduleBox.Location = new System.Drawing.Point(16, 345);
        pnlScheduleBox.Name = "pnlScheduleBox";
        pnlScheduleBox.Padding = new System.Windows.Forms.Padding(16);
        pnlScheduleBox.Size = new System.Drawing.Size(774, 305);
        pnlScheduleBox.TabIndex = 17;
        // 
        // lblScheduleBoxTitle
        // 
        lblScheduleBoxTitle.AutoSize = true;
        lblScheduleBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblScheduleBoxTitle.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblScheduleBoxTitle.Location = new System.Drawing.Point(12, 12);
        lblScheduleBoxTitle.Name = "lblScheduleBoxTitle";
        lblScheduleBoxTitle.Size = new System.Drawing.Size(325, 25);
        lblScheduleBoxTitle.TabIndex = 0;
        lblScheduleBoxTitle.Text = "📅 Thiết lập lịch rảnh & tải công việc";
        // 
        // lblMaxHoursTitle
        // 
        lblMaxHoursTitle.AutoSize = true;
        lblMaxHoursTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMaxHoursTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblMaxHoursTitle.Location = new System.Drawing.Point(14, 45);
        lblMaxHoursTitle.Name = "lblMaxHoursTitle";
        lblMaxHoursTitle.Size = new System.Drawing.Size(142, 20);
        lblMaxHoursTitle.TabIndex = 1;
        lblMaxHoursTitle.Text = "Số giờ dạy tối đa *";
        // 
        // txtMaxHours
        // 
        txtMaxHours.Location = new System.Drawing.Point(14, 68);
        txtMaxHours.Name = "txtMaxHours";
        txtMaxHours.Placeholder = "VD: 12";
        txtMaxHours.Size = new System.Drawing.Size(200, 36);
        txtMaxHours.TabIndex = 2;
        // 
        // lblHourUnit
        // 
        lblHourUnit.AutoSize = true;
        lblHourUnit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblHourUnit.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblHourUnit.Location = new System.Drawing.Point(220, 76);
        lblHourUnit.Name = "lblHourUnit";
        lblHourUnit.Size = new System.Drawing.Size(73, 21);
        lblHourUnit.TabIndex = 3;
        lblHourUnit.Text = "giờ / tuần";
        // 
        // lblMaxHoursNote
        // 
        lblMaxHoursNote.AutoSize = true;
        lblMaxHoursNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
        lblMaxHoursNote.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblMaxHoursNote.Location = new System.Drawing.Point(14, 108);
        lblMaxHoursNote.Name = "lblMaxHoursNote";
        lblMaxHoursNote.Size = new System.Drawing.Size(306, 19);
        lblMaxHoursNote.TabIndex = 4;
        lblMaxHoursNote.Text = "Hệ thống sẽ cảnh báo nếu xếp lịch vượt số giờ này.";
        // 
        // lblPreferredSlotTitle
        // 
        lblPreferredSlotTitle.AutoSize = true;
        lblPreferredSlotTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPreferredSlotTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblPreferredSlotTitle.Location = new System.Drawing.Point(14, 135);
        lblPreferredSlotTitle.Name = "lblPreferredSlotTitle";
        lblPreferredSlotTitle.Size = new System.Drawing.Size(350, 20);
        lblPreferredSlotTitle.TabIndex = 5;
        lblPreferredSlotTitle.Text = "Khung giờ ưu tiên giảng dạy (Có thể chọn nhiều)";
        // 
        // chkMorning
        // 
        chkMorning.AutoSize = true;
        chkMorning.Checked = true;
        chkMorning.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMorning.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkMorning.Location = new System.Drawing.Point(16, 160);
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
        chkAfternoon.Location = new System.Drawing.Point(220, 160);
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
        chkEvening.Location = new System.Drawing.Point(425, 160);
        chkEvening.Name = "chkEvening";
        chkEvening.Size = new System.Drawing.Size(169, 24);
        chkEvening.TabIndex = 8;
        chkEvening.Text = "Ca Tối (18:00 - 21:00)";
        chkEvening.UseVisualStyleBackColor = true;
        // 
        // lblDaysTitle
        // 
        lblDaysTitle.AutoSize = true;
        lblDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDaysTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblDaysTitle.Location = new System.Drawing.Point(14, 195);
        lblDaysTitle.Name = "lblDaysTitle";
        lblDaysTitle.Size = new System.Drawing.Size(187, 20);
        lblDaysTitle.TabIndex = 9;
        lblDaysTitle.Text = "Các ngày có thể giảng dạy *";
        // 
        // chkMon
        // 
        chkMon.AutoSize = true;
        chkMon.Checked = true;
        chkMon.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMon.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkMon.Location = new System.Drawing.Point(16, 222);
        chkMon.Name = "chkMon";
        chkMon.Size = new System.Drawing.Size(85, 24);
        chkMon.TabIndex = 10;
        chkMon.Text = "Thứ Hai";
        chkMon.UseVisualStyleBackColor = true;
        // 
        // chkTue
        // 
        chkTue.AutoSize = true;
        chkTue.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkTue.Location = new System.Drawing.Point(160, 222);
        chkTue.Name = "chkTue";
        chkTue.Size = new System.Drawing.Size(78, 24);
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
        chkWed.Location = new System.Drawing.Point(280, 222);
        chkWed.Name = "chkWed";
        chkWed.Size = new System.Drawing.Size(78, 24);
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
        chkThu.Location = new System.Drawing.Point(400, 222);
        chkThu.Name = "chkThu";
        chkThu.Size = new System.Drawing.Size(94, 24);
        chkThu.TabIndex = 13;
        chkThu.Text = "Thứ Năm";
        chkThu.UseVisualStyleBackColor = true;
        // 
        // chkFri
        // 
        chkFri.AutoSize = true;
        chkFri.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkFri.Location = new System.Drawing.Point(16, 258);
        chkFri.Name = "chkFri";
        chkFri.Size = new System.Drawing.Size(85, 24);
        chkFri.TabIndex = 14;
        chkFri.Text = "Thứ Sáu";
        chkFri.UseVisualStyleBackColor = true;
        // 
        // chkSat
        // 
        chkSat.AutoSize = true;
        chkSat.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkSat.Location = new System.Drawing.Point(160, 258);
        chkSat.Name = "chkSat";
        chkSat.Size = new System.Drawing.Size(83, 24);
        chkSat.TabIndex = 15;
        chkSat.Text = "Thứ Bảy";
        chkSat.UseVisualStyleBackColor = true;
        // 
        // chkSun
        // 
        chkSun.AutoSize = true;
        chkSun.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkSun.Location = new System.Drawing.Point(280, 258);
        chkSun.Name = "chkSun";
        chkSun.Size = new System.Drawing.Size(92, 24);
        chkSun.TabIndex = 16;
        chkSun.Text = "Chủ Nhật";
        chkSun.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 6;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnCancel.Location = new System.Drawing.Point(525, 665);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(115, 42);
        btnCancel.TabIndex = 18;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
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
        // AddTeacherDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(860, 840);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
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
    private System.Windows.Forms.Label lblMaxHoursTitle;
    private ECMS.UI.Controls.AppTextBox txtMaxHours;
    private System.Windows.Forms.Label lblHourUnit;
    private System.Windows.Forms.Label lblMaxHoursNote;
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
