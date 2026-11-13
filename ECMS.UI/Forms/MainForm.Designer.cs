namespace ECMS.UI.Forms;

partial class MainForm
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
        btnLogoutTop = new System.Windows.Forms.Button();
        lblUser = new System.Windows.Forms.Label();
        pnlAvatar = new System.Windows.Forms.Panel();
        lblAvatar = new System.Windows.Forms.Label();
        lblNotification = new System.Windows.Forms.Label();
        lblHeaderCenter = new System.Windows.Forms.Label();
        lblHeaderBrand = new System.Windows.Forms.Label();
        picHeaderLogo = new System.Windows.Forms.PictureBox();
        pnlStatusBar = new System.Windows.Forms.Panel();
        lblStatusRight = new System.Windows.Forms.Label();
        lblStatusLeft = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        pnlContent = new System.Windows.Forms.Panel();
        pnlSidebar = new System.Windows.Forms.Panel();
        pnlSidebarMenu = new System.Windows.Forms.Panel();
        btnNavSettings = new System.Windows.Forms.Button();
        btnNavAccounts = new System.Windows.Forms.Button();
        btnNavReports = new System.Windows.Forms.Button();
        btnNavNotifications = new System.Windows.Forms.Button();
        btnNavStaff = new System.Windows.Forms.Button();
        lblGroupD = new System.Windows.Forms.Label();
        btnNavTuition = new System.Windows.Forms.Button();
        btnNavAdmissions = new System.Windows.Forms.Button();
        lblGroupC = new System.Windows.Forms.Label();
        btnNavCertificates = new System.Windows.Forms.Button();
        btnNavMaterials = new System.Windows.Forms.Button();
        btnNavGrades = new System.Windows.Forms.Button();
        btnNavAttendance = new System.Windows.Forms.Button();
        btnNavSchedule = new System.Windows.Forms.Button();
        btnNavClass = new System.Windows.Forms.Button();
        btnNavCourse = new System.Windows.Forms.Button();
        btnNavTeacher = new System.Windows.Forms.Button();
        btnNavStudent = new System.Windows.Forms.Button();
        lblGroupB = new System.Windows.Forms.Label();
        btnNavDashboard = new System.Windows.Forms.Button();
        lblGroupA = new System.Windows.Forms.Label();
        pnlSidebarBottom = new System.Windows.Forms.Panel();
        lblVersion = new System.Windows.Forms.Label();
        lblF1Help = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlAvatar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picHeaderLogo).BeginInit();
        pnlStatusBar.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlSidebar.SuspendLayout();
        pnlSidebarMenu.SuspendLayout();
        pnlSidebarBottom.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnLogoutTop);
        pnlHeader.Controls.Add(lblUser);
        pnlHeader.Controls.Add(pnlAvatar);
        pnlHeader.Controls.Add(lblNotification);
        pnlHeader.Controls.Add(lblHeaderCenter);
        pnlHeader.Controls.Add(lblHeaderBrand);
        pnlHeader.Controls.Add(picHeaderLogo);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1800, 62);
        pnlHeader.TabIndex = 0;
        // 
        // btnLogoutTop
        // 
        btnLogoutTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnLogoutTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)242)), ((int)((byte)242)));
        btnLogoutTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogoutTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)202)), ((int)((byte)202)));
        btnLogoutTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogoutTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnLogoutTop.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnLogoutTop.Location = new System.Drawing.Point(1665, 14);
        btnLogoutTop.Name = "btnLogoutTop";
        btnLogoutTop.Size = new System.Drawing.Size(119, 36);
        btnLogoutTop.TabIndex = 6;
        btnLogoutTop.Text = "Đăng xuất";
        btnLogoutTop.UseVisualStyleBackColor = false;
        // 
        // lblUser
        // 
        lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblUser.AutoSize = true;
        lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
        lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblUser.Location = new System.Drawing.Point(1405, 20);
        lblUser.Name = "lblUser";
        lblUser.Size = new System.Drawing.Size(214, 21);
        lblUser.TabIndex = 5;
        lblUser.Text = "Trần Minh Quân · Admin ▾";
        // 
        // pnlAvatar
        // 
        pnlAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        pnlAvatar.Controls.Add(lblAvatar);
        pnlAvatar.Location = new System.Drawing.Point(1354, 14);
        pnlAvatar.Name = "pnlAvatar";
        pnlAvatar.Size = new System.Drawing.Size(40, 36);
        pnlAvatar.TabIndex = 4;
        // 
        // lblAvatar
        // 
        lblAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
        lblAvatar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblAvatar.Location = new System.Drawing.Point(0, 0);
        lblAvatar.Name = "lblAvatar";
        lblAvatar.Size = new System.Drawing.Size(40, 36);
        lblAvatar.TabIndex = 0;
        lblAvatar.Text = "MQ";
        lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNotification
        // 
        lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNotification.AutoSize = true;
        lblNotification.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNotification.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNotification.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNotification.Location = new System.Drawing.Point(1126, 20);
        lblNotification.Name = "lblNotification";
        lblNotification.Size = new System.Drawing.Size(185, 21);
        lblNotification.TabIndex = 3;
        lblNotification.Text = "🔔  Thông báo nội bộ (3)";
        // 
        // lblHeaderCenter
        // 
        lblHeaderCenter.AutoSize = true;
        lblHeaderCenter.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblHeaderCenter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblHeaderCenter.Location = new System.Drawing.Point(171, 18);
        lblHeaderCenter.Name = "lblHeaderCenter";
        lblHeaderCenter.Size = new System.Drawing.Size(276, 25);
        lblHeaderCenter.TabIndex = 2;
        lblHeaderCenter.Text = "|   Trung tâm Anh ngữ";
        // 
        // lblHeaderBrand
        // 
        lblHeaderBrand.AutoSize = true;
        lblHeaderBrand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblHeaderBrand.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblHeaderBrand.Location = new System.Drawing.Point(71, 15);
        lblHeaderBrand.Name = "lblHeaderBrand";
        lblHeaderBrand.Size = new System.Drawing.Size(72, 30);
        lblHeaderBrand.TabIndex = 1;
        lblHeaderBrand.Text = "ECMS";
        // 
        // picHeaderLogo
        // 
        picHeaderLogo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        picHeaderLogo.Location = new System.Drawing.Point(22, 14);
        picHeaderLogo.Name = "picHeaderLogo";
        picHeaderLogo.Size = new System.Drawing.Size(40, 36);
        picHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picHeaderLogo.TabIndex = 0;
        picHeaderLogo.TabStop = false;
        // 
        // pnlStatusBar
        // 
        pnlStatusBar.BackColor = System.Drawing.Color.White;
        pnlStatusBar.Controls.Add(lblStatusRight);
        pnlStatusBar.Controls.Add(lblStatusLeft);
        pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlStatusBar.Location = new System.Drawing.Point(0, 911);
        pnlStatusBar.Name = "pnlStatusBar";
        pnlStatusBar.Size = new System.Drawing.Size(1800, 30);
        pnlStatusBar.TabIndex = 1;
        // 
        // lblStatusRight
        // 
        lblStatusRight.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblStatusRight.AutoSize = true;
        lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblStatusRight.Location = new System.Drawing.Point(1519, 5);
        lblStatusRight.Name = "lblStatusRight";
        lblStatusRight.Size = new System.Drawing.Size(234, 20);
        lblStatusRight.TabIndex = 1;
        lblStatusRight.Text = "Đã lưu cục bộ lúc 15:42 · Hôm nay";
        // 
        // lblStatusLeft
        // 
        lblStatusLeft.AutoSize = true;
        lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatusLeft.Location = new System.Drawing.Point(20, 5);
        lblStatusLeft.Name = "lblStatusLeft";
        lblStatusLeft.Size = new System.Drawing.Size(373, 20);
        lblStatusLeft.TabIndex = 0;
        lblStatusLeft.Text = "● Ngoại tuyến | SQLite cục bộ | C:\\ECMS\\Data\\ecms.db";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlBody.Controls.Add(pnlContent);
        pnlBody.Controls.Add(pnlSidebar);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 62);
        pnlBody.Name = "pnlBody";
        pnlBody.Size = new System.Drawing.Size(1800, 849);
        pnlBody.TabIndex = 2;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(279, 0);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new System.Drawing.Size(1521, 849);
        pnlContent.TabIndex = 1;
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = System.Drawing.Color.White;
        pnlSidebar.Controls.Add(pnlSidebarMenu);
        pnlSidebar.Controls.Add(pnlSidebarBottom);
        pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        pnlSidebar.Location = new System.Drawing.Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new System.Drawing.Size(279, 849);
        pnlSidebar.TabIndex = 0;
        // 
        // pnlSidebarMenu
        // 
        pnlSidebarMenu.AutoScroll = true;
        pnlSidebarMenu.BackColor = System.Drawing.Color.White;
        pnlSidebarMenu.Controls.Add(btnNavSettings);
        pnlSidebarMenu.Controls.Add(btnNavAccounts);
        pnlSidebarMenu.Controls.Add(btnNavReports);
        pnlSidebarMenu.Controls.Add(btnNavNotifications);
        pnlSidebarMenu.Controls.Add(btnNavStaff);
        pnlSidebarMenu.Controls.Add(lblGroupD);
        pnlSidebarMenu.Controls.Add(btnNavTuition);
        pnlSidebarMenu.Controls.Add(btnNavAdmissions);
        pnlSidebarMenu.Controls.Add(lblGroupC);
        pnlSidebarMenu.Controls.Add(btnNavCertificates);
        pnlSidebarMenu.Controls.Add(btnNavMaterials);
        pnlSidebarMenu.Controls.Add(btnNavGrades);
        pnlSidebarMenu.Controls.Add(btnNavAttendance);
        pnlSidebarMenu.Controls.Add(btnNavSchedule);
        pnlSidebarMenu.Controls.Add(btnNavClass);
        pnlSidebarMenu.Controls.Add(btnNavCourse);
        pnlSidebarMenu.Controls.Add(btnNavTeacher);
        pnlSidebarMenu.Controls.Add(btnNavStudent);
        pnlSidebarMenu.Controls.Add(lblGroupB);
        pnlSidebarMenu.Controls.Add(btnNavDashboard);
        pnlSidebarMenu.Controls.Add(lblGroupA);
        pnlSidebarMenu.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlSidebarMenu.Location = new System.Drawing.Point(0, 0);
        pnlSidebarMenu.Name = "pnlSidebarMenu";
        pnlSidebarMenu.Padding = new System.Windows.Forms.Padding(0, 8, 0, 18);
        pnlSidebarMenu.Size = new System.Drawing.Size(279, 777);
        pnlSidebarMenu.TabIndex = 0;
        // 
        // btnNavSettings
        // 
        btnNavSettings.BackColor = System.Drawing.Color.White;
        btnNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavSettings.FlatAppearance.BorderSize = 0;
        btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavSettings.Location = new System.Drawing.Point(0, 754);
        btnNavSettings.Name = "btnNavSettings";
        btnNavSettings.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavSettings.Size = new System.Drawing.Size(279, 36);
        btnNavSettings.TabIndex = 20;
        btnNavSettings.Text = "Cấu hình";
        btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavSettings.UseVisualStyleBackColor = true;
        // 
        // btnNavAccounts
        // 
        btnNavAccounts.BackColor = System.Drawing.Color.White;
        btnNavAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavAccounts.FlatAppearance.BorderSize = 0;
        btnNavAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavAccounts.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavAccounts.Location = new System.Drawing.Point(0, 716);
        btnNavAccounts.Name = "btnNavAccounts";
        btnNavAccounts.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavAccounts.Size = new System.Drawing.Size(279, 36);
        btnNavAccounts.TabIndex = 19;
        btnNavAccounts.Text = "Tài khoản & Phân quyền";
        btnNavAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavAccounts.UseVisualStyleBackColor = true;
        // 
        // btnNavReports
        // 
        btnNavReports.BackColor = System.Drawing.Color.White;
        btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavReports.FlatAppearance.BorderSize = 0;
        btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavReports.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavReports.Location = new System.Drawing.Point(0, 679);
        btnNavReports.Name = "btnNavReports";
        btnNavReports.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavReports.Size = new System.Drawing.Size(279, 36);
        btnNavReports.TabIndex = 18;
        btnNavReports.Text = "Báo cáo & Thống kê";
        btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavReports.UseVisualStyleBackColor = true;
        // 
        // btnNavNotifications
        // 
        btnNavNotifications.BackColor = System.Drawing.Color.White;
        btnNavNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavNotifications.FlatAppearance.BorderSize = 0;
        btnNavNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavNotifications.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavNotifications.Location = new System.Drawing.Point(0, 642);
        btnNavNotifications.Name = "btnNavNotifications";
        btnNavNotifications.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavNotifications.Size = new System.Drawing.Size(279, 36);
        btnNavNotifications.TabIndex = 17;
        btnNavNotifications.Text = "Thông báo";
        btnNavNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavNotifications.UseVisualStyleBackColor = true;
        // 
        // btnNavStaff
        // 
        btnNavStaff.BackColor = System.Drawing.Color.White;
        btnNavStaff.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavStaff.FlatAppearance.BorderSize = 0;
        btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavStaff.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavStaff.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavStaff.Location = new System.Drawing.Point(0, 604);
        btnNavStaff.Name = "btnNavStaff";
        btnNavStaff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavStaff.Size = new System.Drawing.Size(279, 36);
        btnNavStaff.TabIndex = 16;
        btnNavStaff.Text = "Nhân viên";
        btnNavStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavStaff.UseVisualStyleBackColor = true;
        // 
        // lblGroupD
        // 
        lblGroupD.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGroupD.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblGroupD.Location = new System.Drawing.Point(22, 573);
        lblGroupD.Name = "lblGroupD";
        lblGroupD.Size = new System.Drawing.Size(234, 26);
        lblGroupD.TabIndex = 15;
        lblGroupD.Text = "D · NHÂN SỰ & HỆ THỐNG";
        lblGroupD.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnNavTuition
        // 
        btnNavTuition.BackColor = System.Drawing.Color.White;
        btnNavTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavTuition.FlatAppearance.BorderSize = 0;
        btnNavTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavTuition.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavTuition.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavTuition.Location = new System.Drawing.Point(0, 529);
        btnNavTuition.Name = "btnNavTuition";
        btnNavTuition.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavTuition.Size = new System.Drawing.Size(279, 36);
        btnNavTuition.TabIndex = 14;
        btnNavTuition.Text = "Học phí & Thanh toán";
        btnNavTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavTuition.UseVisualStyleBackColor = true;
        // 
        // btnNavAdmissions
        // 
        btnNavAdmissions.BackColor = System.Drawing.Color.White;
        btnNavAdmissions.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavAdmissions.FlatAppearance.BorderSize = 0;
        btnNavAdmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavAdmissions.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavAdmissions.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavAdmissions.Location = new System.Drawing.Point(0, 491);
        btnNavAdmissions.Name = "btnNavAdmissions";
        btnNavAdmissions.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavAdmissions.Size = new System.Drawing.Size(279, 36);
        btnNavAdmissions.TabIndex = 13;
        btnNavAdmissions.Text = "Tuyển sinh & Tư vấn";
        btnNavAdmissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavAdmissions.UseVisualStyleBackColor = true;
        // 
        // lblGroupC
        // 
        lblGroupC.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGroupC.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblGroupC.Location = new System.Drawing.Point(22, 461);
        lblGroupC.Name = "lblGroupC";
        lblGroupC.Size = new System.Drawing.Size(234, 26);
        lblGroupC.TabIndex = 12;
        lblGroupC.Text = "C · TUYỂN SINH & TÀI CHÍNH";
        lblGroupC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnNavCertificates
        // 
        btnNavCertificates.BackColor = System.Drawing.Color.White;
        btnNavCertificates.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavCertificates.FlatAppearance.BorderSize = 0;
        btnNavCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavCertificates.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavCertificates.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavCertificates.Location = new System.Drawing.Point(0, 417);
        btnNavCertificates.Name = "btnNavCertificates";
        btnNavCertificates.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavCertificates.Size = new System.Drawing.Size(279, 36);
        btnNavCertificates.TabIndex = 11;
        btnNavCertificates.Text = "Chứng chỉ";
        btnNavCertificates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavCertificates.UseVisualStyleBackColor = true;
        // 
        // btnNavMaterials
        // 
        btnNavMaterials.BackColor = System.Drawing.Color.White;
        btnNavMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavMaterials.FlatAppearance.BorderSize = 0;
        btnNavMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavMaterials.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavMaterials.Location = new System.Drawing.Point(0, 379);
        btnNavMaterials.Name = "btnNavMaterials";
        btnNavMaterials.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavMaterials.Size = new System.Drawing.Size(279, 36);
        btnNavMaterials.TabIndex = 10;
        btnNavMaterials.Text = "Tài liệu học tập";
        btnNavMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavMaterials.UseVisualStyleBackColor = true;
        // 
        // btnNavGrades
        // 
        btnNavGrades.BackColor = System.Drawing.Color.White;
        btnNavGrades.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavGrades.FlatAppearance.BorderSize = 0;
        btnNavGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavGrades.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavGrades.Location = new System.Drawing.Point(0, 342);
        btnNavGrades.Name = "btnNavGrades";
        btnNavGrades.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavGrades.Size = new System.Drawing.Size(279, 36);
        btnNavGrades.TabIndex = 9;
        btnNavGrades.Text = "Kiểm tra & Điểm số";
        btnNavGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavGrades.UseVisualStyleBackColor = true;
        // 
        // btnNavAttendance
        // 
        btnNavAttendance.BackColor = System.Drawing.Color.White;
        btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavAttendance.FlatAppearance.BorderSize = 0;
        btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavAttendance.Location = new System.Drawing.Point(0, 304);
        btnNavAttendance.Name = "btnNavAttendance";
        btnNavAttendance.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavAttendance.Size = new System.Drawing.Size(279, 36);
        btnNavAttendance.TabIndex = 8;
        btnNavAttendance.Text = "Điểm danh";
        btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavAttendance.UseVisualStyleBackColor = true;
        // 
        // btnNavSchedule
        // 
        btnNavSchedule.BackColor = System.Drawing.Color.White;
        btnNavSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavSchedule.FlatAppearance.BorderSize = 0;
        btnNavSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavSchedule.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavSchedule.Location = new System.Drawing.Point(0, 267);
        btnNavSchedule.Name = "btnNavSchedule";
        btnNavSchedule.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavSchedule.Size = new System.Drawing.Size(279, 36);
        btnNavSchedule.TabIndex = 7;
        btnNavSchedule.Text = "Lịch học & Phòng học";
        btnNavSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavSchedule.UseVisualStyleBackColor = true;
        // 
        // btnNavClass
        // 
        btnNavClass.BackColor = System.Drawing.Color.White;
        btnNavClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavClass.FlatAppearance.BorderSize = 0;
        btnNavClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavClass.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavClass.Location = new System.Drawing.Point(0, 229);
        btnNavClass.Name = "btnNavClass";
        btnNavClass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavClass.Size = new System.Drawing.Size(279, 36);
        btnNavClass.TabIndex = 6;
        btnNavClass.Text = "Lớp học";
        btnNavClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavClass.UseVisualStyleBackColor = true;
        // 
        // btnNavCourse
        // 
        btnNavCourse.BackColor = System.Drawing.Color.White;
        btnNavCourse.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavCourse.FlatAppearance.BorderSize = 0;
        btnNavCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavCourse.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavCourse.Location = new System.Drawing.Point(0, 192);
        btnNavCourse.Name = "btnNavCourse";
        btnNavCourse.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavCourse.Size = new System.Drawing.Size(279, 36);
        btnNavCourse.TabIndex = 5;
        btnNavCourse.Text = "Khóa học";
        btnNavCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavCourse.UseVisualStyleBackColor = true;
        // 
        // btnNavTeacher
        // 
        btnNavTeacher.BackColor = System.Drawing.Color.White;
        btnNavTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavTeacher.FlatAppearance.BorderSize = 0;
        btnNavTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavTeacher.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavTeacher.Location = new System.Drawing.Point(0, 154);
        btnNavTeacher.Name = "btnNavTeacher";
        btnNavTeacher.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavTeacher.Size = new System.Drawing.Size(279, 36);
        btnNavTeacher.TabIndex = 4;
        btnNavTeacher.Text = "Giáo viên";
        btnNavTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavTeacher.UseVisualStyleBackColor = true;
        // 
        // btnNavStudent
        // 
        btnNavStudent.BackColor = System.Drawing.Color.White;
        btnNavStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavStudent.FlatAppearance.BorderSize = 0;
        btnNavStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavStudent.Font = new System.Drawing.Font("Segoe UI", 9.25F);
        btnNavStudent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnNavStudent.Location = new System.Drawing.Point(0, 117);
        btnNavStudent.Name = "btnNavStudent";
        btnNavStudent.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavStudent.Size = new System.Drawing.Size(279, 36);
        btnNavStudent.TabIndex = 3;
        btnNavStudent.Text = "Học viên";
        btnNavStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavStudent.UseVisualStyleBackColor = true;
        // 
        // lblGroupB
        // 
        lblGroupB.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGroupB.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblGroupB.Location = new System.Drawing.Point(22, 86);
        lblGroupB.Name = "lblGroupB";
        lblGroupB.Size = new System.Drawing.Size(234, 26);
        lblGroupB.TabIndex = 2;
        lblGroupB.Text = "B · ĐÀO TẠO";
        lblGroupB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
        btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnNavDashboard.Location = new System.Drawing.Point(0, 42);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
        btnNavDashboard.Size = new System.Drawing.Size(279, 36);
        btnNavDashboard.TabIndex = 1;
        btnNavDashboard.Text = "•  Tổng quan";
        btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnNavDashboard.UseVisualStyleBackColor = false;
        // 
        // lblGroupA
        // 
        lblGroupA.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblGroupA.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblGroupA.Location = new System.Drawing.Point(22, 10);
        lblGroupA.Name = "lblGroupA";
        lblGroupA.Size = new System.Drawing.Size(234, 26);
        lblGroupA.TabIndex = 0;
        lblGroupA.Text = "A · TỔNG QUAN";
        lblGroupA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // pnlSidebarBottom
        // 
        pnlSidebarBottom.BackColor = System.Drawing.Color.White;
        pnlSidebarBottom.Controls.Add(lblVersion);
        pnlSidebarBottom.Controls.Add(lblF1Help);
        pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlSidebarBottom.Location = new System.Drawing.Point(0, 777);
        pnlSidebarBottom.Name = "pnlSidebarBottom";
        pnlSidebarBottom.Size = new System.Drawing.Size(279, 72);
        pnlSidebarBottom.TabIndex = 1;
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblVersion.Location = new System.Drawing.Point(20, 40);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new System.Drawing.Size(183, 19);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "ECMS 1.0 · Máy trạm cục bộ";
        // 
        // lblF1Help
        // 
        lblF1Help.AutoSize = true;
        lblF1Help.Cursor = System.Windows.Forms.Cursors.Hand;
        lblF1Help.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblF1Help.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblF1Help.Location = new System.Drawing.Point(20, 14);
        lblF1Help.Name = "lblF1Help";
        lblF1Help.Size = new System.Drawing.Size(203, 20);
        lblF1Help.TabIndex = 0;
        lblF1Help.Text = "? Hướng dẫn ngoại tuyến · F1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1800, 941);
        Controls.Add(pnlBody);
        Controls.Add(pnlStatusBar);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        MinimumSize = new System.Drawing.Size(1200, 750);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "ECMS — Hệ thống quản lý trung tâm Anh ngữ";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        Load += MainForm_Load;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlAvatar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picHeaderLogo).EndInit();
        pnlStatusBar.ResumeLayout(false);
        pnlStatusBar.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlSidebar.ResumeLayout(false);
        pnlSidebarMenu.ResumeLayout(false);
        pnlSidebarBottom.ResumeLayout(false);
        pnlSidebarBottom.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.PictureBox picHeaderLogo;
    private System.Windows.Forms.Label lblHeaderBrand;
    private System.Windows.Forms.Label lblHeaderCenter;
    private System.Windows.Forms.Label lblNotification;
    private System.Windows.Forms.Panel pnlAvatar;
    private System.Windows.Forms.Label lblAvatar;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.Button btnLogoutTop;

    private System.Windows.Forms.Panel pnlStatusBar;
    private System.Windows.Forms.Label lblStatusLeft;
    private System.Windows.Forms.Label lblStatusRight;

    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Panel pnlSidebarMenu;
    private System.Windows.Forms.Panel pnlSidebarBottom;
    private System.Windows.Forms.Label lblF1Help;
    private System.Windows.Forms.Label lblVersion;

    private System.Windows.Forms.Label lblGroupA;
    private System.Windows.Forms.Button btnNavDashboard;
    private System.Windows.Forms.Label lblGroupB;
    private System.Windows.Forms.Button btnNavStudent;
    private System.Windows.Forms.Button btnNavTeacher;
    private System.Windows.Forms.Button btnNavCourse;
    private System.Windows.Forms.Button btnNavClass;
    private System.Windows.Forms.Button btnNavSchedule;
    private System.Windows.Forms.Button btnNavAttendance;
    private System.Windows.Forms.Button btnNavGrades;
    private System.Windows.Forms.Button btnNavMaterials;
    private System.Windows.Forms.Button btnNavCertificates;
    private System.Windows.Forms.Label lblGroupC;
    private System.Windows.Forms.Button btnNavAdmissions;
    private System.Windows.Forms.Button btnNavTuition;
    private System.Windows.Forms.Label lblGroupD;
    private System.Windows.Forms.Button btnNavStaff;
    private System.Windows.Forms.Button btnNavNotifications;
    private System.Windows.Forms.Button btnNavReports;
    private System.Windows.Forms.Button btnNavAccounts;
    private System.Windows.Forms.Button btnNavSettings;

    private System.Windows.Forms.Panel pnlContent;
}
