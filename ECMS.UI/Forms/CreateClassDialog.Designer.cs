namespace ECMS.UI.Forms;

partial class CreateClassDialog
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
        cardTeacherAvailability = new ECMS.UI.Controls.AppCard();
        btnViewTeacherProfile = new ECMS.UI.Controls.AppButton();
        lblCurrentHoursVal = new System.Windows.Forms.Label();
        lblCurrentHoursKey = new System.Windows.Forms.Label();
        lblFreeScheduleVal = new System.Windows.Forms.Label();
        lblFreeScheduleKey = new System.Windows.Forms.Label();
        lblCurrentTeachingVal = new System.Windows.Forms.Label();
        lblCurrentTeachingKey = new System.Windows.Forms.Label();
        lblSpecialtyVal = new System.Windows.Forms.Label();
        lblSpecialtyKey = new System.Windows.Forms.Label();
        lblTeacherNameVal = new System.Windows.Forms.Label();
        lblTeacherNameKey = new System.Windows.Forms.Label();
        lblTeacherAvailTitle = new System.Windows.Forms.Label();
        cardClassInfo = new ECMS.UI.Controls.AppCard();
        btnSaveDraft = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        cboRoom = new ECMS.UI.Controls.AppComboBox();
        lblRoom = new System.Windows.Forms.Label();
        cboTimeSlot = new ECMS.UI.Controls.AppComboBox();
        lblTimeSlot = new System.Windows.Forms.Label();
        cboDaysOfWeek = new ECMS.UI.Controls.AppComboBox();
        lblDaysOfWeek = new System.Windows.Forms.Label();
        cboTeacher = new ECMS.UI.Controls.AppComboBox();
        lblTeacher = new System.Windows.Forms.Label();
        txtCapacity = new ECMS.UI.Controls.AppTextBox();
        lblCapacity = new System.Windows.Forms.Label();
        dtpEndDate = new System.Windows.Forms.DateTimePicker();
        lblEndDate = new System.Windows.Forms.Label();
        dtpStartDate = new System.Windows.Forms.DateTimePicker();
        lblStartDate = new System.Windows.Forms.Label();
        txtClassCode = new ECMS.UI.Controls.AppTextBox();
        lblClassCode = new System.Windows.Forms.Label();
        cboCourse = new ECMS.UI.Controls.AppComboBox();
        lblCourse = new System.Windows.Forms.Label();
        lblClassInfoTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        cardTeacherAvailability.SuspendLayout();
        cardClassInfo.SuspendLayout();
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
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(167, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tạo lớp học";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.Controls.Add(cardTeacherAvailability);
        pnlContent.Controls.Add(cardClassInfo);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 75);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(1220, 685);
        pnlContent.TabIndex = 1;
        // 
        // cardTeacherAvailability
        // 
        cardTeacherAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardTeacherAvailability.BackColor = System.Drawing.Color.White;
        cardTeacherAvailability.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTeacherAvailability.BorderWidth = 1;
        cardTeacherAvailability.Controls.Add(btnViewTeacherProfile);
        cardTeacherAvailability.Controls.Add(lblCurrentHoursVal);
        cardTeacherAvailability.Controls.Add(lblCurrentHoursKey);
        cardTeacherAvailability.Controls.Add(lblFreeScheduleVal);
        cardTeacherAvailability.Controls.Add(lblFreeScheduleKey);
        cardTeacherAvailability.Controls.Add(lblCurrentTeachingVal);
        cardTeacherAvailability.Controls.Add(lblCurrentTeachingKey);
        cardTeacherAvailability.Controls.Add(lblSpecialtyVal);
        cardTeacherAvailability.Controls.Add(lblSpecialtyKey);
        cardTeacherAvailability.Controls.Add(lblTeacherNameVal);
        cardTeacherAvailability.Controls.Add(lblTeacherNameKey);
        cardTeacherAvailability.Controls.Add(lblTeacherAvailTitle);
        cardTeacherAvailability.CornerRadius = 6;
        cardTeacherAvailability.Location = new System.Drawing.Point(850, 24);
        cardTeacherAvailability.Name = "cardTeacherAvailability";
        cardTeacherAvailability.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherAvailability.Size = new System.Drawing.Size(346, 530);
        cardTeacherAvailability.TabIndex = 1;
        // 
        // btnViewTeacherProfile
        // 
        btnViewTeacherProfile.BackColor = System.Drawing.Color.White;
        btnViewTeacherProfile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnViewTeacherProfile.CornerRadius = 5;
        btnViewTeacherProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewTeacherProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewTeacherProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnViewTeacherProfile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnViewTeacherProfile.Location = new System.Drawing.Point(23, 465);
        btnViewTeacherProfile.Name = "btnViewTeacherProfile";
        btnViewTeacherProfile.Size = new System.Drawing.Size(160, 36);
        btnViewTeacherProfile.TabIndex = 13;
        btnViewTeacherProfile.Text = "Xem hồ sơ giáo viên";
        btnViewTeacherProfile.UseVisualStyleBackColor = false;
        btnViewTeacherProfile.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblCurrentHoursVal
        // 
        lblCurrentHoursVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCurrentHoursVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCurrentHoursVal.Location = new System.Drawing.Point(140, 222);
        lblCurrentHoursVal.Name = "lblCurrentHoursVal";
        lblCurrentHoursVal.Size = new System.Drawing.Size(186, 20);
        lblCurrentHoursVal.TabIndex = 10;
        lblCurrentHoursVal.Text = "4 giờ / tuần";
        lblCurrentHoursVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblCurrentHoursKey
        // 
        lblCurrentHoursKey.AutoSize = true;
        lblCurrentHoursKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCurrentHoursKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCurrentHoursKey.Location = new System.Drawing.Point(20, 224);
        lblCurrentHoursKey.Name = "lblCurrentHoursKey";
        lblCurrentHoursKey.Size = new System.Drawing.Size(105, 20);
        lblCurrentHoursKey.TabIndex = 9;
        lblCurrentHoursKey.Text = "Số tiết hiện tại";
        // 
        // lblFreeScheduleVal
        // 
        lblFreeScheduleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblFreeScheduleVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblFreeScheduleVal.Location = new System.Drawing.Point(140, 177);
        lblFreeScheduleVal.Name = "lblFreeScheduleVal";
        lblFreeScheduleVal.Size = new System.Drawing.Size(186, 20);
        lblFreeScheduleVal.TabIndex = 8;
        lblFreeScheduleVal.Text = "T2 / T5 · 18:00–20:00";
        lblFreeScheduleVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblFreeScheduleKey
        // 
        lblFreeScheduleKey.AutoSize = true;
        lblFreeScheduleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFreeScheduleKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblFreeScheduleKey.Location = new System.Drawing.Point(20, 179);
        lblFreeScheduleKey.Name = "lblFreeScheduleKey";
        lblFreeScheduleKey.Size = new System.Drawing.Size(68, 20);
        lblFreeScheduleKey.TabIndex = 7;
        lblFreeScheduleKey.Text = "Lịch rảnh";
        // 
        // lblCurrentTeachingVal
        // 
        lblCurrentTeachingVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCurrentTeachingVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCurrentTeachingVal.Location = new System.Drawing.Point(140, 132);
        lblCurrentTeachingVal.Name = "lblCurrentTeachingVal";
        lblCurrentTeachingVal.Size = new System.Drawing.Size(186, 20);
        lblCurrentTeachingVal.TabIndex = 6;
        lblCurrentTeachingVal.Text = "IELTS-F01 · T3 / T6";
        lblCurrentTeachingVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblCurrentTeachingKey
        // 
        lblCurrentTeachingKey.AutoSize = true;
        lblCurrentTeachingKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCurrentTeachingKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCurrentTeachingKey.Location = new System.Drawing.Point(20, 134);
        lblCurrentTeachingKey.Name = "lblCurrentTeachingKey";
        lblCurrentTeachingKey.Size = new System.Drawing.Size(73, 20);
        lblCurrentTeachingKey.TabIndex = 5;
        lblCurrentTeachingKey.Text = "Đang dạy";
        // 
        // lblSpecialtyVal
        // 
        lblSpecialtyVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSpecialtyVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblSpecialtyVal.Location = new System.Drawing.Point(140, 87);
        lblSpecialtyVal.Name = "lblSpecialtyVal";
        lblSpecialtyVal.Size = new System.Drawing.Size(186, 20);
        lblSpecialtyVal.TabIndex = 4;
        lblSpecialtyVal.Text = "IELTS · Cơ bản đến 6.5";
        lblSpecialtyVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSpecialtyKey
        // 
        lblSpecialtyKey.AutoSize = true;
        lblSpecialtyKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSpecialtyKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblSpecialtyKey.Location = new System.Drawing.Point(20, 89);
        lblSpecialtyKey.Name = "lblSpecialtyKey";
        lblSpecialtyKey.Size = new System.Drawing.Size(91, 20);
        lblSpecialtyKey.TabIndex = 3;
        lblSpecialtyKey.Text = "Chuyên môn";
        // 
        // lblTeacherNameVal
        // 
        lblTeacherNameVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblTeacherNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblTeacherNameVal.Location = new System.Drawing.Point(140, 50);
        lblTeacherNameVal.Name = "lblTeacherNameVal";
        lblTeacherNameVal.Size = new System.Drawing.Size(186, 20);
        lblTeacherNameVal.TabIndex = 2;
        lblTeacherNameVal.Text = "Nguyễn Hoàng Anh · GV-001";
        lblTeacherNameVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTeacherNameKey
        // 
        lblTeacherNameKey.AutoSize = true;
        lblTeacherNameKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTeacherNameKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTeacherNameKey.Location = new System.Drawing.Point(20, 52);
        lblTeacherNameKey.Name = "lblTeacherNameKey";
        lblTeacherNameKey.Size = new System.Drawing.Size(71, 20);
        lblTeacherNameKey.TabIndex = 1;
        lblTeacherNameKey.Text = "Giáo viên";
        // 
        // lblTeacherAvailTitle
        // 
        lblTeacherAvailTitle.AutoSize = true;
        lblTeacherAvailTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherAvailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTeacherAvailTitle.Location = new System.Drawing.Point(20, 16);
        lblTeacherAvailTitle.Name = "lblTeacherAvailTitle";
        lblTeacherAvailTitle.Size = new System.Drawing.Size(195, 28);
        lblTeacherAvailTitle.TabIndex = 0;
        lblTeacherAvailTitle.Text = "Khả dụng giáo viên";
        // 
        // cardClassInfo
        // 
        cardClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassInfo.BackColor = System.Drawing.Color.White;
        cardClassInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassInfo.BorderWidth = 1;
        cardClassInfo.Controls.Add(btnSaveDraft);
        cardClassInfo.Controls.Add(btnCancel);
        cardClassInfo.Controls.Add(cboStatus);
        cardClassInfo.Controls.Add(lblStatus);
        cardClassInfo.Controls.Add(cboRoom);
        cardClassInfo.Controls.Add(lblRoom);
        cardClassInfo.Controls.Add(cboTimeSlot);
        cardClassInfo.Controls.Add(lblTimeSlot);
        cardClassInfo.Controls.Add(cboDaysOfWeek);
        cardClassInfo.Controls.Add(lblDaysOfWeek);
        cardClassInfo.Controls.Add(cboTeacher);
        cardClassInfo.Controls.Add(lblTeacher);
        cardClassInfo.Controls.Add(txtCapacity);
        cardClassInfo.Controls.Add(lblCapacity);
        cardClassInfo.Controls.Add(dtpEndDate);
        cardClassInfo.Controls.Add(lblEndDate);
        cardClassInfo.Controls.Add(dtpStartDate);
        cardClassInfo.Controls.Add(lblStartDate);
        cardClassInfo.Controls.Add(txtClassCode);
        cardClassInfo.Controls.Add(lblClassCode);
        cardClassInfo.Controls.Add(cboCourse);
        cardClassInfo.Controls.Add(lblCourse);
        cardClassInfo.Controls.Add(lblClassInfoTitle);
        cardClassInfo.CornerRadius = 6;
        cardClassInfo.Location = new System.Drawing.Point(24, 24);
        cardClassInfo.Name = "cardClassInfo";
        cardClassInfo.Padding = new System.Windows.Forms.Padding(24);
        cardClassInfo.Size = new System.Drawing.Size(805, 530);
        cardClassInfo.TabIndex = 0;
        // 
        // btnSaveDraft
        // 
        btnSaveDraft.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveDraft.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSaveDraft.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveDraft.CornerRadius = 5;
        btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveDraft.ForeColor = System.Drawing.Color.White;
        btnSaveDraft.Location = new System.Drawing.Point(651, 465);
        btnSaveDraft.Name = "btnSaveDraft";
        btnSaveDraft.Size = new System.Drawing.Size(130, 36);
        btnSaveDraft.TabIndex = 22;
        btnSaveDraft.Text = "Lưu";
        btnSaveDraft.UseVisualStyleBackColor = false;
        btnSaveDraft.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancel.Location = new System.Drawing.Point(555, 465);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 36);
        btnCancel.TabIndex = 21;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cboStatus
        // 
        cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatus.BackColor = System.Drawing.Color.Transparent;
        cboStatus.CornerRadius = 5;
        cboStatus.DataSource = null;
        cboStatus.DisplayMember = "";
        cboStatus.Location = new System.Drawing.Point(415, 385);
        cboStatus.Name = "cboStatus";
        cboStatus.SelectedIndex = -1;
        cboStatus.SelectedItem = null;
        cboStatus.SelectedValue = null;
        cboStatus.Size = new System.Drawing.Size(366, 35);
        cboStatus.TabIndex = 20;
        cboStatus.ValueMember = "";
        // 
        // lblStatus
        // 
        lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblStatus.Location = new System.Drawing.Point(415, 365);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(80, 20);
        lblStatus.TabIndex = 19;
        lblStatus.Text = "Trạng thái";
        // 
        // cboRoom
        // 
        cboRoom.BackColor = System.Drawing.Color.Transparent;
        cboRoom.CornerRadius = 5;
        cboRoom.DataSource = null;
        cboRoom.DisplayMember = "";
        cboRoom.Location = new System.Drawing.Point(24, 385);
        cboRoom.Name = "cboRoom";
        cboRoom.SelectedIndex = -1;
        cboRoom.SelectedItem = null;
        cboRoom.SelectedValue = null;
        cboRoom.Size = new System.Drawing.Size(365, 35);
        cboRoom.TabIndex = 18;
        cboRoom.ValueMember = "";
        // 
        // lblRoom
        // 
        lblRoom.AutoSize = true;
        lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoom.Location = new System.Drawing.Point(24, 365);
        lblRoom.Name = "lblRoom";
        lblRoom.Size = new System.Drawing.Size(150, 20);
        lblRoom.TabIndex = 17;
        lblRoom.Text = "Phòng học dự kiến *";
        // 
        // cboTimeSlot
        // 
        cboTimeSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboTimeSlot.BackColor = System.Drawing.Color.Transparent;
        cboTimeSlot.CornerRadius = 5;
        cboTimeSlot.DataSource = null;
        cboTimeSlot.DisplayMember = "";
        cboTimeSlot.Location = new System.Drawing.Point(415, 305);
        cboTimeSlot.Name = "cboTimeSlot";
        cboTimeSlot.SelectedIndex = -1;
        cboTimeSlot.SelectedItem = null;
        cboTimeSlot.SelectedValue = null;
        cboTimeSlot.Size = new System.Drawing.Size(366, 35);
        cboTimeSlot.TabIndex = 16;
        cboTimeSlot.ValueMember = "";
        // 
        // lblTimeSlot
        // 
        lblTimeSlot.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblTimeSlot.AutoSize = true;
        lblTimeSlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTimeSlot.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblTimeSlot.Location = new System.Drawing.Point(415, 285);
        lblTimeSlot.Name = "lblTimeSlot";
        lblTimeSlot.Size = new System.Drawing.Size(92, 20);
        lblTimeSlot.TabIndex = 15;
        lblTimeSlot.Text = "Khung giờ *";
        // 
        // cboDaysOfWeek
        // 
        cboDaysOfWeek.BackColor = System.Drawing.Color.Transparent;
        cboDaysOfWeek.CornerRadius = 5;
        cboDaysOfWeek.DataSource = null;
        cboDaysOfWeek.DisplayMember = "";
        cboDaysOfWeek.Location = new System.Drawing.Point(24, 305);
        cboDaysOfWeek.Name = "cboDaysOfWeek";
        cboDaysOfWeek.SelectedIndex = -1;
        cboDaysOfWeek.SelectedItem = null;
        cboDaysOfWeek.SelectedValue = null;
        cboDaysOfWeek.Size = new System.Drawing.Size(365, 35);
        cboDaysOfWeek.TabIndex = 14;
        cboDaysOfWeek.ValueMember = "";
        // 
        // lblDaysOfWeek
        // 
        lblDaysOfWeek.AutoSize = true;
        lblDaysOfWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDaysOfWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblDaysOfWeek.Location = new System.Drawing.Point(24, 285);
        lblDaysOfWeek.Name = "lblDaysOfWeek";
        lblDaysOfWeek.Size = new System.Drawing.Size(86, 20);
        lblDaysOfWeek.TabIndex = 13;
        lblDaysOfWeek.Text = "Ngày học *";
        // 
        // cboTeacher
        // 
        cboTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboTeacher.BackColor = System.Drawing.Color.Transparent;
        cboTeacher.CornerRadius = 5;
        cboTeacher.DataSource = null;
        cboTeacher.DisplayMember = "";
        cboTeacher.Location = new System.Drawing.Point(415, 225);
        cboTeacher.Name = "cboTeacher";
        cboTeacher.SelectedIndex = -1;
        cboTeacher.SelectedItem = null;
        cboTeacher.SelectedValue = null;
        cboTeacher.Size = new System.Drawing.Size(366, 35);
        cboTeacher.TabIndex = 12;
        cboTeacher.ValueMember = "";
        // 
        // lblTeacher
        // 
        lblTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblTeacher.AutoSize = true;
        lblTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblTeacher.Location = new System.Drawing.Point(415, 205);
        lblTeacher.Name = "lblTeacher";
        lblTeacher.Size = new System.Drawing.Size(85, 20);
        lblTeacher.TabIndex = 11;
        lblTeacher.Text = "Giáo viên *";
        // 
        // txtCapacity
        // 
        txtCapacity.BackColor = System.Drawing.Color.Transparent;
        txtCapacity.CornerRadius = 5;
        txtCapacity.ErrorMessage = "";
        txtCapacity.HasError = false;
        txtCapacity.Location = new System.Drawing.Point(24, 225);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Placeholder = "Ví dụ: 20 học viên";
        txtCapacity.ReadOnly = false;
        txtCapacity.Size = new System.Drawing.Size(365, 35);
        txtCapacity.TabIndex = 10;
        txtCapacity.UseSystemPasswordChar = false;
        // 
        // lblCapacity
        // 
        lblCapacity.AutoSize = true;
        lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblCapacity.Location = new System.Drawing.Point(24, 205);
        lblCapacity.Name = "lblCapacity";
        lblCapacity.Size = new System.Drawing.Size(109, 20);
        lblCapacity.TabIndex = 9;
        lblCapacity.Text = "Sức chứa lớp *";
        // 
        // dtpEndDate
        // 
        dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        dtpEndDate.CustomFormat = "dd/MM/yyyy";
        dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEndDate.Location = new System.Drawing.Point(415, 145);
        dtpEndDate.Name = "dtpEndDate";
        dtpEndDate.Size = new System.Drawing.Size(366, 29);
        dtpEndDate.TabIndex = 8;
        // 
        // lblEndDate
        // 
        lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblEndDate.AutoSize = true;
        lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblEndDate.Location = new System.Drawing.Point(415, 125);
        lblEndDate.Name = "lblEndDate";
        lblEndDate.Size = new System.Drawing.Size(174, 20);
        lblEndDate.TabIndex = 7;
        lblEndDate.Text = "Ngày kết thúc dự kiến *";
        // 
        // dtpStartDate
        // 
        dtpStartDate.CustomFormat = "dd/MM/yyyy";
        dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpStartDate.Location = new System.Drawing.Point(24, 145);
        dtpStartDate.Name = "dtpStartDate";
        dtpStartDate.Size = new System.Drawing.Size(365, 29);
        dtpStartDate.TabIndex = 6;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblStartDate.Location = new System.Drawing.Point(24, 125);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new System.Drawing.Size(114, 20);
        lblStartDate.TabIndex = 5;
        lblStartDate.Text = "Ngày bắt đầu *";
        // 
        // txtClassCode
        // 
        txtClassCode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtClassCode.BackColor = System.Drawing.Color.Transparent;
        txtClassCode.CornerRadius = 5;
        txtClassCode.ErrorMessage = "";
        txtClassCode.HasError = false;
        txtClassCode.Location = new System.Drawing.Point(415, 68);
        txtClassCode.Name = "txtClassCode";
        txtClassCode.Placeholder = "Ví dụ: IELTS-F04";
        txtClassCode.ReadOnly = false;
        txtClassCode.Size = new System.Drawing.Size(366, 35);
        txtClassCode.TabIndex = 4;
        txtClassCode.UseSystemPasswordChar = false;
        // 
        // lblClassCode
        // 
        lblClassCode.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblClassCode.AutoSize = true;
        lblClassCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClassCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblClassCode.Location = new System.Drawing.Point(415, 48);
        lblClassCode.Name = "lblClassCode";
        lblClassCode.Size = new System.Drawing.Size(68, 20);
        lblClassCode.TabIndex = 3;
        lblClassCode.Text = "Mã lớp *";
        // 
        // cboCourse
        // 
        cboCourse.BackColor = System.Drawing.Color.Transparent;
        cboCourse.CornerRadius = 5;
        cboCourse.DataSource = null;
        cboCourse.DisplayMember = "";
        cboCourse.Location = new System.Drawing.Point(24, 68);
        cboCourse.Name = "cboCourse";
        cboCourse.SelectedIndex = -1;
        cboCourse.SelectedItem = null;
        cboCourse.SelectedValue = null;
        cboCourse.Size = new System.Drawing.Size(365, 35);
        cboCourse.TabIndex = 2;
        cboCourse.ValueMember = "";
        // 
        // lblCourse
        // 
        lblCourse.AutoSize = true;
        lblCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblCourse.Location = new System.Drawing.Point(24, 48);
        lblCourse.Name = "lblCourse";
        lblCourse.Size = new System.Drawing.Size(85, 20);
        lblCourse.TabIndex = 1;
        lblCourse.Text = "Khóa học *";
        // 
        // lblClassInfoTitle
        // 
        lblClassInfoTitle.AutoSize = true;
        lblClassInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblClassInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassInfoTitle.Location = new System.Drawing.Point(24, 16);
        lblClassInfoTitle.Name = "lblClassInfoTitle";
        lblClassInfoTitle.Size = new System.Drawing.Size(181, 28);
        lblClassInfoTitle.TabIndex = 0;
        lblClassInfoTitle.Text = "Thông tin lớp học";
        // 
        // CreateClassDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tạo lớp học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        cardTeacherAvailability.ResumeLayout(false);
        cardTeacherAvailability.PerformLayout();
        cardClassInfo.ResumeLayout(false);
        cardClassInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlContent;
    private ECMS.UI.Controls.AppCard cardClassInfo;
    private System.Windows.Forms.Label lblClassInfoTitle;
    private System.Windows.Forms.Label lblCourse;
    private ECMS.UI.Controls.AppComboBox cboCourse;
    private System.Windows.Forms.Label lblClassCode;
    private ECMS.UI.Controls.AppTextBox txtClassCode;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.Label lblEndDate;
    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.Label lblCapacity;
    private ECMS.UI.Controls.AppTextBox txtCapacity;
    private System.Windows.Forms.Label lblTeacher;
    private ECMS.UI.Controls.AppComboBox cboTeacher;
    private System.Windows.Forms.Label lblDaysOfWeek;
    private ECMS.UI.Controls.AppComboBox cboDaysOfWeek;
    private System.Windows.Forms.Label lblTimeSlot;
    private ECMS.UI.Controls.AppComboBox cboTimeSlot;
    private System.Windows.Forms.Label lblRoom;
    private ECMS.UI.Controls.AppComboBox cboRoom;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSaveDraft;
    private ECMS.UI.Controls.AppCard cardTeacherAvailability;
    private System.Windows.Forms.Label lblTeacherAvailTitle;
    private System.Windows.Forms.Label lblTeacherNameKey;
    private System.Windows.Forms.Label lblTeacherNameVal;
    private System.Windows.Forms.Label lblSpecialtyKey;
    private System.Windows.Forms.Label lblSpecialtyVal;
    private System.Windows.Forms.Label lblCurrentTeachingKey;
    private System.Windows.Forms.Label lblCurrentTeachingVal;
    private System.Windows.Forms.Label lblFreeScheduleKey;
    private System.Windows.Forms.Label lblFreeScheduleVal;
    private System.Windows.Forms.Label lblCurrentHoursKey;
    private System.Windows.Forms.Label lblCurrentHoursVal;
    private ECMS.UI.Controls.AppButton btnViewTeacherProfile;
}
