namespace ECMS.UI.Forms;

partial class StudentDetailDialog
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
        pnlTop = new System.Windows.Forms.Panel();
        btnEditProfile = new ECMS.UI.Controls.AppButton();
        btnArchive = new ECMS.UI.Controls.AppButton();
        btnDelete = new ECMS.UI.Controls.AppButton();
        lblDetailSub = new System.Windows.Forms.Label();
        lblDetailHeader = new System.Windows.Forms.Label();
        tabMain = new System.Windows.Forms.TabControl();
        tpOverview = new System.Windows.Forms.TabPage();
        pnlOverview = new System.Windows.Forms.Panel();
        cardStatTuition = new ECMS.UI.Controls.AppCard();
        lblStatTuitionSub = new System.Windows.Forms.Label();
        lblStatTuitionVal = new System.Windows.Forms.Label();
        lblStatTuitionTitle = new System.Windows.Forms.Label();
        cardStatAttendance = new ECMS.UI.Controls.AppCard();
        lblStatAttendanceVal = new System.Windows.Forms.Label();
        lblStatAttendanceTitle = new System.Windows.Forms.Label();
        cardStatLessons = new ECMS.UI.Controls.AppCard();
        lblStatLessonsVal = new System.Windows.Forms.Label();
        lblStatLessonsTitle = new System.Windows.Forms.Label();
        cardStatClass = new ECMS.UI.Controls.AppCard();
        lblStatClassVal = new System.Windows.Forms.Label();
        lblStatClassTitle = new System.Windows.Forms.Label();
        cardCurrentAcademic = new ECMS.UI.Controls.AppCard();
        lblCurrentTitle = new System.Windows.Forms.Label();
        pnlColClass = new System.Windows.Forms.Panel();
        lblRoomVal = new System.Windows.Forms.Label();
        lblScheduleVal = new System.Windows.Forms.Label();
        lblTeacherVal = new System.Windows.Forms.Label();
        lblCourseVal = new System.Windows.Forms.Label();
        lblColClassTitle = new System.Windows.Forms.Label();
        pnlDivider1 = new System.Windows.Forms.Panel();
        pnlColAttendance = new System.Windows.Forms.Panel();
        lblAttAbsent = new System.Windows.Forms.Label();
        lblAttLate = new System.Windows.Forms.Label();
        lblAttPresent = new System.Windows.Forms.Label();
        lblAttCountVal = new System.Windows.Forms.Label();
        lblColAttTitle = new System.Windows.Forms.Label();
        pnlDivider2 = new System.Windows.Forms.Panel();
        pnlColGrades = new System.Windows.Forms.Panel();
        lblGradeFinal = new System.Windows.Forms.Label();
        lblGradeMid = new System.Windows.Forms.Label();
        lblGradeRegular = new System.Windows.Forms.Label();
        lblGradeEntry = new System.Windows.Forms.Label();
        lblColGradesTitle = new System.Windows.Forms.Label();
        tpLearningPath = new System.Windows.Forms.TabPage();
        pnlLearningPath = new System.Windows.Forms.Panel();
        cardLearningPath = new ECMS.UI.Controls.AppCard();
        dgvLearningPath = new ECMS.UI.Controls.AppDataGrid();
        colClassCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colGradeRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colGradeMid = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colGradeFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTuitionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        pnlPathHeader = new System.Windows.Forms.Panel();
        lblPathTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        tabMain.SuspendLayout();
        tpOverview.SuspendLayout();
        pnlOverview.SuspendLayout();
        cardStatTuition.SuspendLayout();
        cardStatAttendance.SuspendLayout();
        cardStatLessons.SuspendLayout();
        cardStatClass.SuspendLayout();
        cardCurrentAcademic.SuspendLayout();
        pnlColClass.SuspendLayout();
        pnlColAttendance.SuspendLayout();
        pnlColGrades.SuspendLayout();
        tpLearningPath.SuspendLayout();
        pnlLearningPath.SuspendLayout();
        cardLearningPath.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLearningPath).BeginInit();
        pnlPathHeader.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(btnEditProfile);
        pnlTop.Controls.Add(btnArchive);
        pnlTop.Controls.Add(btnDelete);
        pnlTop.Controls.Add(lblDetailSub);
        pnlTop.Controls.Add(lblDetailHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
        pnlTop.Size = new System.Drawing.Size(1053, 75);
        pnlTop.TabIndex = 0;
        // 
        // btnEditProfile
        // 
        btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnEditProfile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnEditProfile.CornerRadius = 6;
        btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEditProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnEditProfile.ForeColor = System.Drawing.Color.White;
        btnEditProfile.Location = new System.Drawing.Point(918, 18);
        btnEditProfile.Name = "btnEditProfile";
        btnEditProfile.Size = new System.Drawing.Size(115, 38);
        btnEditProfile.TabIndex = 4;
        btnEditProfile.Text = "Sửa hồ sơ";
        btnEditProfile.UseVisualStyleBackColor = false;
        btnEditProfile.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnArchive
        // 
        btnArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnArchive.BackColor = System.Drawing.Color.White;
        btnArchive.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnArchive.CornerRadius = 6;
        btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
        btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnArchive.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnArchive.Location = new System.Drawing.Point(813, 18);
        btnArchive.Name = "btnArchive";
        btnArchive.Size = new System.Drawing.Size(95, 38);
        btnArchive.TabIndex = 3;
        btnArchive.Text = "Lưu trữ";
        btnArchive.UseVisualStyleBackColor = false;
        btnArchive.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnDelete.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnDelete.CornerRadius = 6;
        btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnDelete.ForeColor = System.Drawing.Color.White;
        btnDelete.Location = new System.Drawing.Point(693, 18);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(110, 38);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Xóa học viên";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // lblDetailSub
        // 
        lblDetailSub.AutoSize = true;
        lblDetailSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDetailSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDetailSub.Location = new System.Drawing.Point(26, 44);
        lblDetailSub.Name = "lblDetailSub";
        lblDetailSub.Size = new System.Drawing.Size(506, 20);
        lblDetailSub.TabIndex = 2;
        lblDetailSub.Text = "Đang học  |  0908 123 456  |  Phụ huynh: Nguyễn Thu Hương / 0911 556 889";
        // 
        // lblDetailHeader
        // 
        lblDetailHeader.AutoSize = true;
        lblDetailHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblDetailHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblDetailHeader.Location = new System.Drawing.Point(24, 10);
        lblDetailHeader.Name = "lblDetailHeader";
        lblDetailHeader.Size = new System.Drawing.Size(367, 35);
        lblDetailHeader.TabIndex = 1;
        lblDetailHeader.Text = "Nguyễn Minh Anh  ·  HV-0241";
        // 
        // tabMain
        // 
        tabMain.Controls.Add(tpOverview);
        tabMain.Controls.Add(tpLearningPath);
        tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        tabMain.Location = new System.Drawing.Point(0, 75);
        tabMain.Name = "tabMain";
        tabMain.Padding = new System.Drawing.Point(16, 6);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new System.Drawing.Size(1053, 625);
        tabMain.TabIndex = 1;
        // 
        // tpOverview
        // 
        tpOverview.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        tpOverview.Controls.Add(pnlOverview);
        tpOverview.Location = new System.Drawing.Point(4, 36);
        tpOverview.Name = "tpOverview";
        tpOverview.Padding = new System.Windows.Forms.Padding(20);
        tpOverview.Size = new System.Drawing.Size(1045, 585);
        tpOverview.TabIndex = 0;
        tpOverview.Text = "Tổng quan";
        // 
        // pnlOverview
        // 
        pnlOverview.Controls.Add(cardStatTuition);
        pnlOverview.Controls.Add(cardStatAttendance);
        pnlOverview.Controls.Add(cardStatLessons);
        pnlOverview.Controls.Add(cardStatClass);
        pnlOverview.Controls.Add(cardCurrentAcademic);
        pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlOverview.Location = new System.Drawing.Point(20, 20);
        pnlOverview.Name = "pnlOverview";
        pnlOverview.Size = new System.Drawing.Size(1005, 545);
        pnlOverview.TabIndex = 0;
        // 
        // cardStatTuition
        // 
        cardStatTuition.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardStatTuition.BackColor = System.Drawing.Color.White;
        cardStatTuition.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)202)), ((int)((byte)202)));
        cardStatTuition.BorderWidth = 1;
        cardStatTuition.Controls.Add(lblStatTuitionSub);
        cardStatTuition.Controls.Add(lblStatTuitionVal);
        cardStatTuition.Controls.Add(lblStatTuitionTitle);
        cardStatTuition.CornerRadius = 8;
        cardStatTuition.Location = new System.Drawing.Point(754, 10);
        cardStatTuition.Name = "cardStatTuition";
        cardStatTuition.Padding = new System.Windows.Forms.Padding(16);
        cardStatTuition.Size = new System.Drawing.Size(235, 95);
        cardStatTuition.TabIndex = 4;
        // 
        // lblStatTuitionSub
        // 
        lblStatTuitionSub.AutoSize = true;
        lblStatTuitionSub.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblStatTuitionSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblStatTuitionSub.Location = new System.Drawing.Point(14, 68);
        lblStatTuitionSub.Name = "lblStatTuitionSub";
        lblStatTuitionSub.Size = new System.Drawing.Size(187, 19);
        lblStatTuitionSub.TabIndex = 2;
        lblStatTuitionSub.Text = "Hạn thanh toán: 15/11/2026";
        // 
        // lblStatTuitionVal
        // 
        lblStatTuitionVal.AutoSize = true;
        lblStatTuitionVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblStatTuitionVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblStatTuitionVal.Location = new System.Drawing.Point(14, 30);
        lblStatTuitionVal.Name = "lblStatTuitionVal";
        lblStatTuitionVal.Size = new System.Drawing.Size(160, 37);
        lblStatTuitionVal.TabIndex = 1;
        lblStatTuitionVal.Text = "1.900.000đ";
        // 
        // lblStatTuitionTitle
        // 
        lblStatTuitionTitle.AutoSize = true;
        lblStatTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatTuitionTitle.Location = new System.Drawing.Point(14, 10);
        lblStatTuitionTitle.Name = "lblStatTuitionTitle";
        lblStatTuitionTitle.Size = new System.Drawing.Size(109, 20);
        lblStatTuitionTitle.TabIndex = 0;
        lblStatTuitionTitle.Text = "Học phí còn lại";
        // 
        // cardStatAttendance
        // 
        cardStatAttendance.BackColor = System.Drawing.Color.White;
        cardStatAttendance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatAttendance.BorderWidth = 1;
        cardStatAttendance.Controls.Add(lblStatAttendanceVal);
        cardStatAttendance.Controls.Add(lblStatAttendanceTitle);
        cardStatAttendance.CornerRadius = 8;
        cardStatAttendance.Location = new System.Drawing.Point(502, 10);
        cardStatAttendance.Name = "cardStatAttendance";
        cardStatAttendance.Padding = new System.Windows.Forms.Padding(16);
        cardStatAttendance.Size = new System.Drawing.Size(235, 95);
        cardStatAttendance.TabIndex = 3;
        // 
        // lblStatAttendanceVal
        // 
        lblStatAttendanceVal.AutoSize = true;
        lblStatAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatAttendanceVal.Location = new System.Drawing.Point(14, 34);
        lblStatAttendanceVal.Name = "lblStatAttendanceVal";
        lblStatAttendanceVal.Size = new System.Drawing.Size(103, 41);
        lblStatAttendanceVal.TabIndex = 1;
        lblStatAttendanceVal.Text = "87,5%";
        // 
        // lblStatAttendanceTitle
        // 
        lblStatAttendanceTitle.AutoSize = true;
        lblStatAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatAttendanceTitle.Location = new System.Drawing.Point(14, 10);
        lblStatAttendanceTitle.Name = "lblStatAttendanceTitle";
        lblStatAttendanceTitle.Size = new System.Drawing.Size(84, 20);
        lblStatAttendanceTitle.TabIndex = 0;
        lblStatAttendanceTitle.Text = "Chuyên cần";
        // 
        // cardStatLessons
        // 
        cardStatLessons.BackColor = System.Drawing.Color.White;
        cardStatLessons.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatLessons.BorderWidth = 1;
        cardStatLessons.Controls.Add(lblStatLessonsVal);
        cardStatLessons.Controls.Add(lblStatLessonsTitle);
        cardStatLessons.CornerRadius = 8;
        cardStatLessons.Location = new System.Drawing.Point(252, 10);
        cardStatLessons.Name = "cardStatLessons";
        cardStatLessons.Padding = new System.Windows.Forms.Padding(16);
        cardStatLessons.Size = new System.Drawing.Size(235, 95);
        cardStatLessons.TabIndex = 2;
        // 
        // lblStatLessonsVal
        // 
        lblStatLessonsVal.AutoSize = true;
        lblStatLessonsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatLessonsVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatLessonsVal.Location = new System.Drawing.Point(14, 34);
        lblStatLessonsVal.Name = "lblStatLessonsVal";
        lblStatLessonsVal.Size = new System.Drawing.Size(98, 41);
        lblStatLessonsVal.TabIndex = 1;
        lblStatLessonsVal.Text = "8 / 24";
        // 
        // lblStatLessonsTitle
        // 
        lblStatLessonsTitle.AutoSize = true;
        lblStatLessonsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatLessonsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatLessonsTitle.Location = new System.Drawing.Point(14, 10);
        lblStatLessonsTitle.Name = "lblStatLessonsTitle";
        lblStatLessonsTitle.Size = new System.Drawing.Size(88, 20);
        lblStatLessonsTitle.TabIndex = 0;
        lblStatLessonsTitle.Text = "Buổi đã học";
        // 
        // cardStatClass
        // 
        cardStatClass.BackColor = System.Drawing.Color.White;
        cardStatClass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatClass.BorderWidth = 1;
        cardStatClass.Controls.Add(lblStatClassVal);
        cardStatClass.Controls.Add(lblStatClassTitle);
        cardStatClass.CornerRadius = 8;
        cardStatClass.Location = new System.Drawing.Point(2, 10);
        cardStatClass.Name = "cardStatClass";
        cardStatClass.Padding = new System.Windows.Forms.Padding(16);
        cardStatClass.Size = new System.Drawing.Size(235, 95);
        cardStatClass.TabIndex = 1;
        // 
        // lblStatClassVal
        // 
        lblStatClassVal.AutoSize = true;
        lblStatClassVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStatClassVal.Location = new System.Drawing.Point(14, 34);
        lblStatClassVal.Name = "lblStatClassVal";
        lblStatClassVal.Size = new System.Drawing.Size(154, 41);
        lblStatClassVal.TabIndex = 1;
        lblStatClassVal.Text = "IELTS-F01";
        // 
        // lblStatClassTitle
        // 
        lblStatClassTitle.AutoSize = true;
        lblStatClassTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatClassTitle.Location = new System.Drawing.Point(14, 10);
        lblStatClassTitle.Name = "lblStatClassTitle";
        lblStatClassTitle.Size = new System.Drawing.Size(100, 20);
        lblStatClassTitle.TabIndex = 0;
        lblStatClassTitle.Text = "Lớp đang học";
        // 
        // cardCurrentAcademic
        // 
        cardCurrentAcademic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCurrentAcademic.BackColor = System.Drawing.Color.White;
        cardCurrentAcademic.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCurrentAcademic.BorderWidth = 1;
        cardCurrentAcademic.Controls.Add(lblCurrentTitle);
        cardCurrentAcademic.Controls.Add(pnlColClass);
        cardCurrentAcademic.Controls.Add(pnlDivider1);
        cardCurrentAcademic.Controls.Add(pnlColAttendance);
        cardCurrentAcademic.Controls.Add(pnlDivider2);
        cardCurrentAcademic.Controls.Add(pnlColGrades);
        cardCurrentAcademic.CornerRadius = 8;
        cardCurrentAcademic.Location = new System.Drawing.Point(2, 120);
        cardCurrentAcademic.Name = "cardCurrentAcademic";
        cardCurrentAcademic.Padding = new System.Windows.Forms.Padding(20);
        cardCurrentAcademic.Size = new System.Drawing.Size(998, 380);
        cardCurrentAcademic.TabIndex = 5;
        // 
        // lblCurrentTitle
        // 
        lblCurrentTitle.AutoSize = true;
        lblCurrentTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblCurrentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblCurrentTitle.Location = new System.Drawing.Point(20, 18);
        lblCurrentTitle.Name = "lblCurrentTitle";
        lblCurrentTitle.Size = new System.Drawing.Size(220, 25);
        lblCurrentTitle.TabIndex = 0;
        lblCurrentTitle.Text = "Tóm tắt học tập hiện tại";
        // 
        // pnlColClass
        // 
        pnlColClass.Controls.Add(lblRoomVal);
        pnlColClass.Controls.Add(lblScheduleVal);
        pnlColClass.Controls.Add(lblTeacherVal);
        pnlColClass.Controls.Add(lblCourseVal);
        pnlColClass.Controls.Add(lblColClassTitle);
        pnlColClass.Location = new System.Drawing.Point(20, 60);
        pnlColClass.Name = "pnlColClass";
        pnlColClass.Padding = new System.Windows.Forms.Padding(8);
        pnlColClass.Size = new System.Drawing.Size(300, 290);
        pnlColClass.TabIndex = 1;
        // 
        // lblRoomVal
        // 
        lblRoomVal.AutoSize = true;
        lblRoomVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRoomVal.Location = new System.Drawing.Point(10, 185);
        lblRoomVal.Name = "lblRoomVal";
        lblRoomVal.Size = new System.Drawing.Size(127, 21);
        lblRoomVal.TabIndex = 4;
        lblRoomVal.Text = "Phòng học: P201";
        // 
        // lblScheduleVal
        // 
        lblScheduleVal.AutoSize = true;
        lblScheduleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblScheduleVal.Location = new System.Drawing.Point(10, 140);
        lblScheduleVal.Name = "lblScheduleVal";
        lblScheduleVal.Size = new System.Drawing.Size(219, 21);
        lblScheduleVal.TabIndex = 3;
        lblScheduleVal.Text = "Lịch học: T3 / T6 · 18:00–20:00";
        // 
        // lblTeacherVal
        // 
        lblTeacherVal.AutoSize = true;
        lblTeacherVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTeacherVal.Location = new System.Drawing.Point(10, 95);
        lblTeacherVal.Name = "lblTeacherVal";
        lblTeacherVal.Size = new System.Drawing.Size(219, 21);
        lblTeacherVal.TabIndex = 2;
        lblTeacherVal.Text = "Giáo viên: Nguyễn Hoàng Anh";
        // 
        // lblCourseVal
        // 
        lblCourseVal.AutoSize = true;
        lblCourseVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCourseVal.Location = new System.Drawing.Point(10, 50);
        lblCourseVal.Name = "lblCourseVal";
        lblCourseVal.Size = new System.Drawing.Size(200, 21);
        lblCourseVal.TabIndex = 1;
        lblCourseVal.Text = "Khóa học: IELTS Foundation";
        // 
        // lblColClassTitle
        // 
        lblColClassTitle.AutoSize = true;
        lblColClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblColClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblColClassTitle.Location = new System.Drawing.Point(10, 10);
        lblColClassTitle.Name = "lblColClassTitle";
        lblColClassTitle.Size = new System.Drawing.Size(126, 20);
        lblColClassTitle.TabIndex = 0;
        lblColClassTitle.Text = "THÔNG TIN LỚP";
        // 
        // pnlDivider1
        // 
        pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        pnlDivider1.Location = new System.Drawing.Point(330, 60);
        pnlDivider1.Name = "pnlDivider1";
        pnlDivider1.Size = new System.Drawing.Size(1, 280);
        pnlDivider1.TabIndex = 2;
        // 
        // pnlColAttendance
        // 
        pnlColAttendance.Controls.Add(lblAttAbsent);
        pnlColAttendance.Controls.Add(lblAttLate);
        pnlColAttendance.Controls.Add(lblAttPresent);
        pnlColAttendance.Controls.Add(lblAttCountVal);
        pnlColAttendance.Controls.Add(lblColAttTitle);
        pnlColAttendance.Location = new System.Drawing.Point(345, 60);
        pnlColAttendance.Name = "pnlColAttendance";
        pnlColAttendance.Padding = new System.Windows.Forms.Padding(8);
        pnlColAttendance.Size = new System.Drawing.Size(305, 290);
        pnlColAttendance.TabIndex = 3;
        // 
        // lblAttAbsent
        // 
        lblAttAbsent.AutoSize = true;
        lblAttAbsent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAttAbsent.ForeColor = System.Drawing.SystemColors.ControlText;
        lblAttAbsent.Location = new System.Drawing.Point(10, 185);
        lblAttAbsent.Name = "lblAttAbsent";
        lblAttAbsent.Size = new System.Drawing.Size(131, 21);
        lblAttAbsent.TabIndex = 4;
        lblAttAbsent.Text = "Vắng: 1 (có phép)";
        // 
        // lblAttLate
        // 
        lblAttLate.AutoSize = true;
        lblAttLate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAttLate.ForeColor = System.Drawing.SystemColors.ControlText;
        lblAttLate.Location = new System.Drawing.Point(10, 140);
        lblAttLate.Name = "lblAttLate";
        lblAttLate.Size = new System.Drawing.Size(86, 21);
        lblAttLate.TabIndex = 3;
        lblAttLate.Text = "Đi muộn: 1";
        // 
        // lblAttPresent
        // 
        lblAttPresent.AutoSize = true;
        lblAttPresent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAttPresent.ForeColor = System.Drawing.SystemColors.ControlText;
        lblAttPresent.Location = new System.Drawing.Point(10, 95);
        lblAttPresent.Name = "lblAttPresent";
        lblAttPresent.Size = new System.Drawing.Size(76, 21);
        lblAttPresent.TabIndex = 2;
        lblAttPresent.Text = "Có mặt: 6";
        // 
        // lblAttCountVal
        // 
        lblAttCountVal.AutoSize = true;
        lblAttCountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAttCountVal.ForeColor = System.Drawing.SystemColors.ControlText;
        lblAttCountVal.Location = new System.Drawing.Point(10, 50);
        lblAttCountVal.Name = "lblAttCountVal";
        lblAttCountVal.Size = new System.Drawing.Size(188, 21);
        lblAttCountVal.TabIndex = 1;
        lblAttCountVal.Text = "Tiến độ học: 8 / 24 buổi";
        // 
        // lblColAttTitle
        // 
        lblColAttTitle.AutoSize = true;
        lblColAttTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblColAttTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblColAttTitle.Location = new System.Drawing.Point(10, 10);
        lblColAttTitle.Name = "lblColAttTitle";
        lblColAttTitle.Size = new System.Drawing.Size(105, 20);
        lblColAttTitle.TabIndex = 0;
        lblColAttTitle.Text = "CHUYÊN CẦN";
        // 
        // pnlDivider2
        // 
        pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        pnlDivider2.Location = new System.Drawing.Point(665, 60);
        pnlDivider2.Name = "pnlDivider2";
        pnlDivider2.Size = new System.Drawing.Size(1, 280);
        pnlDivider2.TabIndex = 4;
        // 
        // pnlColGrades
        // 
        pnlColGrades.Controls.Add(lblGradeFinal);
        pnlColGrades.Controls.Add(lblGradeMid);
        pnlColGrades.Controls.Add(lblGradeRegular);
        pnlColGrades.Controls.Add(lblGradeEntry);
        pnlColGrades.Controls.Add(lblColGradesTitle);
        pnlColGrades.Location = new System.Drawing.Point(680, 60);
        pnlColGrades.Name = "pnlColGrades";
        pnlColGrades.Padding = new System.Windows.Forms.Padding(8);
        pnlColGrades.Size = new System.Drawing.Size(290, 290);
        pnlColGrades.TabIndex = 5;
        // 
        // lblGradeFinal
        // 
        lblGradeFinal.AutoSize = true;
        lblGradeFinal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblGradeFinal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblGradeFinal.Location = new System.Drawing.Point(10, 140);
        lblGradeFinal.Name = "lblGradeFinal";
        lblGradeFinal.Size = new System.Drawing.Size(196, 21);
        lblGradeFinal.TabIndex = 4;
        lblGradeFinal.Text = "Cuối khóa:    Chưa kiểm tra";
        // 
        // lblGradeMid
        // 
        lblGradeMid.AutoSize = true;
        lblGradeMid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblGradeMid.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblGradeMid.Location = new System.Drawing.Point(10, 95);
        lblGradeMid.Name = "lblGradeMid";
        lblGradeMid.Size = new System.Drawing.Size(196, 21);
        lblGradeMid.TabIndex = 3;
        lblGradeMid.Text = "Giữa khóa:    Chưa kiểm tra";
        // 
        // lblGradeRegular
        // 
        lblGradeRegular.AutoSize = true;
        lblGradeRegular.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblGradeRegular.Location = new System.Drawing.Point(10, 50);
        lblGradeRegular.Name = "lblGradeRegular";
        lblGradeRegular.Size = new System.Drawing.Size(169, 21);
        lblGradeRegular.TabIndex = 2;
        lblGradeRegular.Text = "Thường xuyên: 7.0 / 10";
        // 
        // lblGradeEntry
        // 
        lblGradeEntry.AutoSize = true;
        lblGradeEntry.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblGradeEntry.Location = new System.Drawing.Point(10, 45);
        lblGradeEntry.Name = "lblGradeEntry";
        lblGradeEntry.Size = new System.Drawing.Size(127, 21);
        lblGradeEntry.TabIndex = 1;
        lblGradeEntry.Text = "Đầu vào: 4.0 / 10";
        lblGradeEntry.Visible = false;
        // 
        // lblColGradesTitle
        // 
        lblColGradesTitle.AutoSize = true;
        lblColGradesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblColGradesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblColGradesTitle.Location = new System.Drawing.Point(10, 10);
        lblColGradesTitle.Name = "lblColGradesTitle";
        lblColGradesTitle.Size = new System.Drawing.Size(70, 20);
        lblColGradesTitle.TabIndex = 0;
        lblColGradesTitle.Text = "ĐIỂM SỐ";
        // 
        // tpLearningPath
        // 
        tpLearningPath.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        tpLearningPath.Controls.Add(pnlLearningPath);
        tpLearningPath.Location = new System.Drawing.Point(4, 36);
        tpLearningPath.Name = "tpLearningPath";
        tpLearningPath.Padding = new System.Windows.Forms.Padding(20);
        tpLearningPath.Size = new System.Drawing.Size(1045, 585);
        tpLearningPath.TabIndex = 1;
        tpLearningPath.Text = "Quá trình học tập";
        // 
        // pnlLearningPath
        // 
        pnlLearningPath.Controls.Add(cardLearningPath);
        pnlLearningPath.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlLearningPath.Location = new System.Drawing.Point(20, 20);
        pnlLearningPath.Name = "pnlLearningPath";
        pnlLearningPath.Size = new System.Drawing.Size(1005, 545);
        pnlLearningPath.TabIndex = 1;
        // 
        // cardLearningPath
        // 
        cardLearningPath.BackColor = System.Drawing.Color.White;
        cardLearningPath.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardLearningPath.BorderWidth = 1;
        cardLearningPath.Controls.Add(dgvLearningPath);
        cardLearningPath.Controls.Add(pnlPathHeader);
        cardLearningPath.CornerRadius = 8;
        cardLearningPath.Dock = System.Windows.Forms.DockStyle.Fill;
        cardLearningPath.Location = new System.Drawing.Point(0, 0);
        cardLearningPath.Name = "cardLearningPath";
        cardLearningPath.Padding = new System.Windows.Forms.Padding(20);
        cardLearningPath.Size = new System.Drawing.Size(1005, 545);
        cardLearningPath.TabIndex = 0;
        // 
        // dgvLearningPath
        // 
        dgvLearningPath.AllowUserToAddRows = false;
        dgvLearningPath.AllowUserToDeleteRows = false;
        dgvLearningPath.AllowUserToResizeColumns = false;
        dgvLearningPath.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvLearningPath.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvLearningPath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLearningPath.BackgroundColor = System.Drawing.Color.White;
        dgvLearningPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvLearningPath.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvLearningPath.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvLearningPath.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvLearningPath.ColumnHeadersHeight = 40;
        dgvLearningPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvLearningPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colClassCourse, colStatus, colAtt, colGradeRegular, colGradeMid, colGradeFinal, colTuitionStatus });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvLearningPath.DefaultCellStyle = dataGridViewCellStyle3;
        dgvLearningPath.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLearningPath.EnableHeadersVisualStyles = false;
        dgvLearningPath.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvLearningPath.Location = new System.Drawing.Point(20, 60);
        dgvLearningPath.MultiSelect = false;
        dgvLearningPath.Name = "dgvLearningPath";
        dgvLearningPath.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvLearningPath.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvLearningPath.RowHeadersVisible = false;
        dgvLearningPath.RowHeadersWidth = 51;
        dgvLearningPath.RowTemplate.Height = 44;
        dgvLearningPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLearningPath.Size = new System.Drawing.Size(965, 465);
        dgvLearningPath.TabIndex = 1;
        // 
        // colClassCourse
        // 
        colClassCourse.FillWeight = 26F;
        colClassCourse.HeaderText = "Lớp học / Khóa";
        colClassCourse.MinimumWidth = 180;
        colClassCourse.Name = "colClassCourse";
        colClassCourse.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.FillWeight = 12F;
        colStatus.HeaderText = "Trạng thái";
        colStatus.MinimumWidth = 85;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // colAtt
        // 
        colAtt.FillWeight = 11F;
        colAtt.HeaderText = "Điểm danh";
        colAtt.MinimumWidth = 75;
        colAtt.Name = "colAtt";
        colAtt.ReadOnly = true;
        // 
        // colGradeRegular
        // 
        colGradeRegular.FillWeight = 11F;
        colGradeRegular.HeaderText = "Thường xuyên";
        colGradeRegular.MinimumWidth = 75;
        colGradeRegular.Name = "colGradeRegular";
        colGradeRegular.ReadOnly = true;
        // 
        // colGradeMid
        // 
        colGradeMid.FillWeight = 11F;
        colGradeMid.HeaderText = "Giữa khóa";
        colGradeMid.MinimumWidth = 75;
        colGradeMid.Name = "colGradeMid";
        colGradeMid.ReadOnly = true;
        // 
        // colGradeFinal
        // 
        colGradeFinal.FillWeight = 11F;
        colGradeFinal.HeaderText = "Cuối khóa";
        colGradeFinal.MinimumWidth = 75;
        colGradeFinal.Name = "colGradeFinal";
        colGradeFinal.ReadOnly = true;
        // 
        // colTuitionStatus
        // 
        colTuitionStatus.FillWeight = 18F;
        colTuitionStatus.HeaderText = "Tình trạng học phí";
        colTuitionStatus.MinimumWidth = 110;
        colTuitionStatus.Name = "colTuitionStatus";
        colTuitionStatus.ReadOnly = true;
        // 
        // pnlPathHeader
        // 
        pnlPathHeader.Controls.Add(lblPathTitle);
        pnlPathHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlPathHeader.Location = new System.Drawing.Point(20, 20);
        pnlPathHeader.Name = "pnlPathHeader";
        pnlPathHeader.Size = new System.Drawing.Size(965, 40);
        pnlPathHeader.TabIndex = 0;
        // 
        // lblPathTitle
        // 
        lblPathTitle.AutoSize = true;
        lblPathTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblPathTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPathTitle.Location = new System.Drawing.Point(0, 5);
        lblPathTitle.Name = "lblPathTitle";
        lblPathTitle.Size = new System.Drawing.Size(169, 25);
        lblPathTitle.TabIndex = 0;
        lblPathTitle.Text = "Tiến trình học tập";
        // 
        // StudentDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1053, 700);
        Controls.Add(tabMain);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(960, 640);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Hồ sơ học viên — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        tabMain.ResumeLayout(false);
        tpOverview.ResumeLayout(false);
        pnlOverview.ResumeLayout(false);
        cardStatTuition.ResumeLayout(false);
        cardStatTuition.PerformLayout();
        cardStatAttendance.ResumeLayout(false);
        cardStatAttendance.PerformLayout();
        cardStatLessons.ResumeLayout(false);
        cardStatLessons.PerformLayout();
        cardStatClass.ResumeLayout(false);
        cardStatClass.PerformLayout();
        cardCurrentAcademic.ResumeLayout(false);
        cardCurrentAcademic.PerformLayout();
        pnlColClass.ResumeLayout(false);
        pnlColClass.PerformLayout();
        pnlColAttendance.ResumeLayout(false);
        pnlColAttendance.PerformLayout();
        pnlColGrades.ResumeLayout(false);
        pnlColGrades.PerformLayout();
        tpLearningPath.ResumeLayout(false);
        pnlLearningPath.ResumeLayout(false);
        cardLearningPath.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvLearningPath).EndInit();
        pnlPathHeader.ResumeLayout(false);
        pnlPathHeader.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblDetailHeader;
    private System.Windows.Forms.Label lblDetailSub;
    private ECMS.UI.Controls.AppButton btnDelete;
    private ECMS.UI.Controls.AppButton btnArchive;
    private ECMS.UI.Controls.AppButton btnEditProfile;

    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tpOverview;
    private System.Windows.Forms.TabPage tpLearningPath;
    private System.Windows.Forms.Panel pnlOverview;
    private ECMS.UI.Controls.AppCard cardStatClass;
    private System.Windows.Forms.Label lblStatClassTitle;
    private System.Windows.Forms.Label lblStatClassVal;
    private ECMS.UI.Controls.AppCard cardStatLessons;
    private System.Windows.Forms.Label lblStatLessonsTitle;
    private System.Windows.Forms.Label lblStatLessonsVal;
    private ECMS.UI.Controls.AppCard cardStatAttendance;
    private System.Windows.Forms.Label lblStatAttendanceTitle;
    private System.Windows.Forms.Label lblStatAttendanceVal;
    private ECMS.UI.Controls.AppCard cardStatTuition;
    private System.Windows.Forms.Label lblStatTuitionTitle;
    private System.Windows.Forms.Label lblStatTuitionVal;
    private System.Windows.Forms.Label lblStatTuitionSub;

    private ECMS.UI.Controls.AppCard cardCurrentAcademic;
    private System.Windows.Forms.Label lblCurrentTitle;
    private System.Windows.Forms.Panel pnlColClass;
    private System.Windows.Forms.Label lblColClassTitle;
    private System.Windows.Forms.Label lblCourseVal;
    private System.Windows.Forms.Label lblTeacherVal;
    private System.Windows.Forms.Label lblScheduleVal;
    private System.Windows.Forms.Label lblRoomVal;
    private System.Windows.Forms.Panel pnlDivider1;
    private System.Windows.Forms.Panel pnlColAttendance;
    private System.Windows.Forms.Label lblColAttTitle;
    private System.Windows.Forms.Label lblAttCountVal;
    private System.Windows.Forms.Label lblAttPresent;
    private System.Windows.Forms.Label lblAttLate;
    private System.Windows.Forms.Label lblAttAbsent;
    private System.Windows.Forms.Panel pnlDivider2;
    private System.Windows.Forms.Panel pnlColGrades;
    private System.Windows.Forms.Label lblColGradesTitle;
    private System.Windows.Forms.Label lblGradeEntry;
    private System.Windows.Forms.Label lblGradeRegular;
    private System.Windows.Forms.Label lblGradeMid;
    private System.Windows.Forms.Label lblGradeFinal;

    private System.Windows.Forms.Panel pnlLearningPath;
    private ECMS.UI.Controls.AppCard cardLearningPath;
    private System.Windows.Forms.Panel pnlPathHeader;
    private System.Windows.Forms.Label lblPathTitle;
    private ECMS.UI.Controls.AppDataGrid dgvLearningPath;
    private System.Windows.Forms.DataGridViewTextBoxColumn colClassCourse;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAtt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGradeRegular;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGradeMid;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGradeFinal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTuitionStatus;
}
