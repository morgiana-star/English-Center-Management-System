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
        lblDetailSub = new System.Windows.Forms.Label();
        lblDetailHeader = new System.Windows.Forms.Label();
        pnlNavTabs = new System.Windows.Forms.Panel();
        lblNavHistory = new System.Windows.Forms.Label();
        lblNavTuition = new System.Windows.Forms.Label();
        lblNavGrades = new System.Windows.Forms.Label();
        lblNavAttendance = new System.Windows.Forms.Label();
        lblNavClasses = new System.Windows.Forms.Label();
        lblNavOverview = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardAuditLog = new ECMS.UI.Controls.AppCard();
        lblAuditText = new System.Windows.Forms.Label();
        lblAuditTitle = new System.Windows.Forms.Label();
        cardTuitionSummary = new ECMS.UI.Controls.AppCard();
        btnOpenDebt = new ECMS.UI.Controls.AppButton();
        dgvReceipts = new ECMS.UI.Controls.AppDataGrid();
        lblTuitionDue = new System.Windows.Forms.Label();
        lblTuitionPaid = new System.Windows.Forms.Label();
        lblTuitionBase = new System.Windows.Forms.Label();
        lblTuitionTitle = new System.Windows.Forms.Label();
        cardAcademicSummary = new ECMS.UI.Controls.AppCard();
        btnViewAcademicDetail = new ECMS.UI.Controls.AppButton();
        lblCertInfo = new System.Windows.Forms.Label();
        lblTermGrades = new System.Windows.Forms.Label();
        lblEntryGrades = new System.Windows.Forms.Label();
        lblAttendanceDetail = new System.Windows.Forms.Label();
        lblScheduleRoom = new System.Windows.Forms.Label();
        lblTeacher = new System.Windows.Forms.Label();
        lblCourse = new System.Windows.Forms.Label();
        lblAcademicTitle = new System.Windows.Forms.Label();
        cardStatTuitionDue = new ECMS.UI.Controls.AppCard();
        lblStatTuitionDueVal = new System.Windows.Forms.Label();
        lblStatTuitionDueTitle = new System.Windows.Forms.Label();
        cardStatAttendance = new ECMS.UI.Controls.AppCard();
        lblStatAttendanceVal = new System.Windows.Forms.Label();
        lblStatAttendanceTitle = new System.Windows.Forms.Label();
        cardStatLessons = new ECMS.UI.Controls.AppCard();
        lblStatLessonsVal = new System.Windows.Forms.Label();
        lblStatLessonsTitle = new System.Windows.Forms.Label();
        cardStatClass = new ECMS.UI.Controls.AppCard();
        lblStatClassVal = new System.Windows.Forms.Label();
        lblStatClassTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        pnlNavTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardAuditLog.SuspendLayout();
        cardTuitionSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
        cardAcademicSummary.SuspendLayout();
        cardStatTuitionDue.SuspendLayout();
        cardStatAttendance.SuspendLayout();
        cardStatLessons.SuspendLayout();
        cardStatClass.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(btnEditProfile);
        pnlTop.Controls.Add(btnArchive);
        pnlTop.Controls.Add(lblDetailSub);
        pnlTop.Controls.Add(lblDetailHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlTop.Size = new System.Drawing.Size(1220, 75);
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
        btnEditProfile.Location = new System.Drawing.Point(1075, 20);
        btnEditProfile.Name = "btnEditProfile";
        btnEditProfile.Size = new System.Drawing.Size(120, 36);
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
        btnArchive.Location = new System.Drawing.Point(965, 20);
        btnArchive.Name = "btnArchive";
        btnArchive.Size = new System.Drawing.Size(100, 36);
        btnArchive.TabIndex = 3;
        btnArchive.Text = "Lưu trữ";
        btnArchive.UseVisualStyleBackColor = false;
        btnArchive.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblDetailSub
        // 
        lblDetailSub.AutoSize = true;
        lblDetailSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDetailSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDetailSub.Location = new System.Drawing.Point(27, 49);
        lblDetailSub.Name = "lblDetailSub";
        lblDetailSub.Size = new System.Drawing.Size(488, 20);
        lblDetailSub.TabIndex = 2;
        lblDetailSub.Text = "Đang học · 0908 123 456 · Phụ huynh: Nguyễn Thu Hương / 0911 556 889";
        // 
        // lblDetailHeader
        // 
        lblDetailHeader.AutoSize = true;
        lblDetailHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblDetailHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblDetailHeader.Location = new System.Drawing.Point(22, 14);
        lblDetailHeader.Name = "lblDetailHeader";
        lblDetailHeader.Size = new System.Drawing.Size(353, 35);
        lblDetailHeader.TabIndex = 1;
        lblDetailHeader.Text = "Nguyễn Minh Anh · HV-0241";
        // 
        // pnlNavTabs
        // 
        pnlNavTabs.BackColor = System.Drawing.Color.White;
        pnlNavTabs.Controls.Add(lblNavHistory);
        pnlNavTabs.Controls.Add(lblNavTuition);
        pnlNavTabs.Controls.Add(lblNavGrades);
        pnlNavTabs.Controls.Add(lblNavAttendance);
        pnlNavTabs.Controls.Add(lblNavClasses);
        pnlNavTabs.Controls.Add(lblNavOverview);
        pnlNavTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlNavTabs.Location = new System.Drawing.Point(0, 75);
        pnlNavTabs.Name = "pnlNavTabs";
        pnlNavTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlNavTabs.Size = new System.Drawing.Size(1220, 40);
        pnlNavTabs.TabIndex = 1;
        // 
        // lblNavHistory
        // 
        lblNavHistory.AutoSize = true;
        lblNavHistory.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNavHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNavHistory.Location = new System.Drawing.Point(535, 10);
        lblNavHistory.Name = "lblNavHistory";
        lblNavHistory.Size = new System.Drawing.Size(58, 21);
        lblNavHistory.TabIndex = 5;
        lblNavHistory.Text = "Lịch sử";
        // 
        // lblNavTuition
        // 
        lblNavTuition.AutoSize = true;
        lblNavTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavTuition.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNavTuition.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNavTuition.Location = new System.Drawing.Point(445, 10);
        lblNavTuition.Name = "lblNavTuition";
        lblNavTuition.Size = new System.Drawing.Size(63, 21);
        lblNavTuition.TabIndex = 4;
        lblNavTuition.Text = "Học phí";
        // 
        // lblNavGrades
        // 
        lblNavGrades.AutoSize = true;
        lblNavGrades.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNavGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNavGrades.Location = new System.Drawing.Point(355, 10);
        lblNavGrades.Name = "lblNavGrades";
        lblNavGrades.Size = new System.Drawing.Size(67, 21);
        lblNavGrades.TabIndex = 3;
        lblNavGrades.Text = "Điểm số";
        // 
        // lblNavAttendance
        // 
        lblNavAttendance.AutoSize = true;
        lblNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNavAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNavAttendance.Location = new System.Drawing.Point(245, 10);
        lblNavAttendance.Name = "lblNavAttendance";
        lblNavAttendance.Size = new System.Drawing.Size(86, 21);
        lblNavAttendance.TabIndex = 2;
        lblNavAttendance.Text = "Điểm danh";
        // 
        // lblNavClasses
        // 
        lblNavClasses.AutoSize = true;
        lblNavClasses.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavClasses.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblNavClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNavClasses.Location = new System.Drawing.Point(155, 10);
        lblNavClasses.Name = "lblNavClasses";
        lblNavClasses.Size = new System.Drawing.Size(66, 21);
        lblNavClasses.TabIndex = 1;
        lblNavClasses.Text = "Lớp học";
        // 
        // lblNavOverview
        // 
        lblNavOverview.AutoSize = true;
        lblNavOverview.Cursor = System.Windows.Forms.Cursors.Hand;
        lblNavOverview.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblNavOverview.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblNavOverview.Location = new System.Drawing.Point(24, 10);
        lblNavOverview.Name = "lblNavOverview";
        lblNavOverview.Size = new System.Drawing.Size(116, 21);
        lblNavOverview.TabIndex = 0;
        lblNavOverview.Text = "▬  Tổng quan";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardAuditLog);
        pnlBody.Controls.Add(cardTuitionSummary);
        pnlBody.Controls.Add(cardAcademicSummary);
        pnlBody.Controls.Add(cardStatTuitionDue);
        pnlBody.Controls.Add(cardStatAttendance);
        pnlBody.Controls.Add(cardStatLessons);
        pnlBody.Controls.Add(cardStatClass);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 115);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 645);
        pnlBody.TabIndex = 2;
        // 
        // cardAuditLog
        // 
        cardAuditLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAuditLog.BackColor = System.Drawing.Color.White;
        cardAuditLog.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAuditLog.BorderWidth = 1;
        cardAuditLog.Controls.Add(lblAuditText);
        cardAuditLog.Controls.Add(lblAuditTitle);
        cardAuditLog.CornerRadius = 8;
        cardAuditLog.Location = new System.Drawing.Point(20, 480);
        cardAuditLog.Name = "cardAuditLog";
        cardAuditLog.Padding = new System.Windows.Forms.Padding(16);
        cardAuditLog.Size = new System.Drawing.Size(1175, 95);
        cardAuditLog.TabIndex = 13;
        // 
        // lblAuditText
        // 
        lblAuditText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblAuditText.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAuditText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblAuditText.Location = new System.Drawing.Point(20, 45);
        lblAuditText.Name = "lblAuditText";
        lblAuditText.Size = new System.Drawing.Size(1135, 38);
        lblAuditText.TabIndex = 1;
        lblAuditText.Text = ("02/10 · Phạm Ngọc Mai: tạo từ TN-0108, xếp IELTS-F01.   30/10 · Lê Phương Thảo: t" + "hu đợt 2, PT-261030-018.   30/10 · Nguyễn Hoàng Anh: cập nhật điểm danh buổi 8.");
        // 
        // lblAuditTitle
        // 
        lblAuditTitle.AutoSize = true;
        lblAuditTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblAuditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAuditTitle.Location = new System.Drawing.Point(20, 14);
        lblAuditTitle.Name = "lblAuditTitle";
        lblAuditTitle.Size = new System.Drawing.Size(136, 28);
        lblAuditTitle.TabIndex = 0;
        lblAuditTitle.Text = "Lịch sử hồ sơ";
        // 
        // cardTuitionSummary
        // 
        cardTuitionSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardTuitionSummary.BackColor = System.Drawing.Color.White;
        cardTuitionSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTuitionSummary.BorderWidth = 1;
        cardTuitionSummary.Controls.Add(btnOpenDebt);
        cardTuitionSummary.Controls.Add(dgvReceipts);
        cardTuitionSummary.Controls.Add(lblTuitionDue);
        cardTuitionSummary.Controls.Add(lblTuitionPaid);
        cardTuitionSummary.Controls.Add(lblTuitionBase);
        cardTuitionSummary.Controls.Add(lblTuitionTitle);
        cardTuitionSummary.CornerRadius = 8;
        cardTuitionSummary.Location = new System.Drawing.Point(680, 115);
        cardTuitionSummary.Name = "cardTuitionSummary";
        cardTuitionSummary.Padding = new System.Windows.Forms.Padding(16);
        cardTuitionSummary.Size = new System.Drawing.Size(515, 350);
        cardTuitionSummary.TabIndex = 12;
        // 
        // btnOpenDebt
        // 
        btnOpenDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnOpenDebt.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnOpenDebt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnOpenDebt.CornerRadius = 6;
        btnOpenDebt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenDebt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenDebt.ForeColor = System.Drawing.Color.White;
        btnOpenDebt.Location = new System.Drawing.Point(20, 295);
        btnOpenDebt.Name = "btnOpenDebt";
        btnOpenDebt.Size = new System.Drawing.Size(220, 38);
        btnOpenDebt.TabIndex = 5;
        btnOpenDebt.Text = "Mở công nợ / thu đợt tiếp";
        btnOpenDebt.UseVisualStyleBackColor = false;
        btnOpenDebt.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // dgvReceipts
        // 
        dgvReceipts.AllowUserToAddRows = false;
        dgvReceipts.AllowUserToDeleteRows = false;
        dgvReceipts.AllowUserToResizeColumns = false;
        dgvReceipts.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvReceipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvReceipts.BackgroundColor = System.Drawing.Color.White;
        dgvReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvReceipts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvReceipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvReceipts.ColumnHeadersHeight = 36;
        dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvReceipts.DefaultCellStyle = dataGridViewCellStyle3;
        dgvReceipts.EnableHeadersVisualStyles = false;
        dgvReceipts.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvReceipts.Location = new System.Drawing.Point(20, 160);
        dgvReceipts.MultiSelect = false;
        dgvReceipts.Name = "dgvReceipts";
        dgvReceipts.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvReceipts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvReceipts.RowHeadersVisible = false;
        dgvReceipts.RowHeadersWidth = 51;
        dgvReceipts.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvReceipts.Size = new System.Drawing.Size(475, 120);
        dgvReceipts.TabIndex = 4;
        // 
        // lblTuitionDue
        // 
        lblTuitionDue.AutoSize = true;
        lblTuitionDue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblTuitionDue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblTuitionDue.Location = new System.Drawing.Point(20, 125);
        lblTuitionDue.Name = "lblTuitionDue";
        lblTuitionDue.Size = new System.Drawing.Size(346, 21);
        lblTuitionDue.TabIndex = 3;
        lblTuitionDue.Text = "Còn phải thu / hạn:  1.900.000đ / 15/11/2026";
        // 
        // lblTuitionPaid
        // 
        lblTuitionPaid.AutoSize = true;
        lblTuitionPaid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTuitionPaid.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTuitionPaid.Location = new System.Drawing.Point(20, 90);
        lblTuitionPaid.Name = "lblTuitionPaid";
        lblTuitionPaid.Size = new System.Drawing.Size(309, 21);
        lblTuitionPaid.TabIndex = 2;
        lblTuitionPaid.Text = "Thực thu / đã thu:  5.400.000đ / 3.500.000đ";
        // 
        // lblTuitionBase
        // 
        lblTuitionBase.AutoSize = true;
        lblTuitionBase.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTuitionBase.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTuitionBase.Location = new System.Drawing.Point(20, 55);
        lblTuitionBase.Name = "lblTuitionBase";
        lblTuitionBase.Size = new System.Drawing.Size(318, 21);
        lblTuitionBase.TabIndex = 1;
        lblTuitionBase.Text = "Học phí gốc / ưu đãi:  6.000.000đ / 600.000đ";
        // 
        // lblTuitionTitle
        // 
        lblTuitionTitle.AutoSize = true;
        lblTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTuitionTitle.Location = new System.Drawing.Point(20, 16);
        lblTuitionTitle.Name = "lblTuitionTitle";
        lblTuitionTitle.Size = new System.Drawing.Size(197, 28);
        lblTuitionTitle.TabIndex = 0;
        lblTuitionTitle.Text = "Học phí & lịch sử thu";
        // 
        // cardAcademicSummary
        // 
        cardAcademicSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAcademicSummary.BackColor = System.Drawing.Color.White;
        cardAcademicSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAcademicSummary.BorderWidth = 1;
        cardAcademicSummary.Controls.Add(btnViewAcademicDetail);
        cardAcademicSummary.Controls.Add(lblCertInfo);
        cardAcademicSummary.Controls.Add(lblTermGrades);
        cardAcademicSummary.Controls.Add(lblEntryGrades);
        cardAcademicSummary.Controls.Add(lblAttendanceDetail);
        cardAcademicSummary.Controls.Add(lblScheduleRoom);
        cardAcademicSummary.Controls.Add(lblTeacher);
        cardAcademicSummary.Controls.Add(lblCourse);
        cardAcademicSummary.Controls.Add(lblAcademicTitle);
        cardAcademicSummary.CornerRadius = 8;
        cardAcademicSummary.Location = new System.Drawing.Point(20, 115);
        cardAcademicSummary.Name = "cardAcademicSummary";
        cardAcademicSummary.Padding = new System.Windows.Forms.Padding(16);
        cardAcademicSummary.Size = new System.Drawing.Size(640, 350);
        cardAcademicSummary.TabIndex = 11;
        // 
        // btnViewAcademicDetail
        // 
        btnViewAcademicDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnViewAcademicDetail.BackColor = System.Drawing.Color.White;
        btnViewAcademicDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnViewAcademicDetail.CornerRadius = 6;
        btnViewAcademicDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewAcademicDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewAcademicDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnViewAcademicDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnViewAcademicDetail.Location = new System.Drawing.Point(20, 295);
        btnViewAcademicDetail.Name = "btnViewAcademicDetail";
        btnViewAcademicDetail.Size = new System.Drawing.Size(180, 38);
        btnViewAcademicDetail.TabIndex = 8;
        btnViewAcademicDetail.Text = "Xem chi tiết học tập";
        btnViewAcademicDetail.UseVisualStyleBackColor = false;
        btnViewAcademicDetail.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblCertInfo
        // 
        lblCertInfo.AutoSize = true;
        lblCertInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCertInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCertInfo.Location = new System.Drawing.Point(20, 255);
        lblCertInfo.Name = "lblCertInfo";
        lblCertInfo.Size = new System.Drawing.Size(279, 21);
        lblCertInfo.TabIndex = 7;
        lblCertInfo.Text = "Chứng chỉ:  Chưa đủ điều kiện · lớp học";
        // 
        // lblTermGrades
        // 
        lblTermGrades.AutoSize = true;
        lblTermGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTermGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTermGrades.Location = new System.Drawing.Point(20, 220);
        lblTermGrades.Name = "lblTermGrades";
        lblTermGrades.Size = new System.Drawing.Size(319, 21);
        lblTermGrades.TabIndex = 6;
        lblTermGrades.Text = "Giữa khóa / cuối khóa:  Chưa kiểm tra / Chưa";
        // 
        // lblEntryGrades
        // 
        lblEntryGrades.AutoSize = true;
        lblEntryGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblEntryGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblEntryGrades.Location = new System.Drawing.Point(20, 185);
        lblEntryGrades.Name = "lblEntryGrades";
        lblEntryGrades.Size = new System.Drawing.Size(305, 21);
        lblEntryGrades.TabIndex = 5;
        lblEntryGrades.Text = "Đầu vào / thường xuyên:  4,0 / 10 · 7,0 / 10";
        // 
        // lblAttendanceDetail
        // 
        lblAttendanceDetail.AutoSize = true;
        lblAttendanceDetail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAttendanceDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAttendanceDetail.Location = new System.Drawing.Point(20, 150);
        lblAttendanceDetail.Name = "lblAttendanceDetail";
        lblAttendanceDetail.Size = new System.Drawing.Size(356, 21);
        lblAttendanceDetail.TabIndex = 4;
        lblAttendanceDetail.Text = "Điểm danh:  6 có mặt · 1 đi muộn · 1 vắng có phép";
        // 
        // lblScheduleRoom
        // 
        lblScheduleRoom.AutoSize = true;
        lblScheduleRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblScheduleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblScheduleRoom.Location = new System.Drawing.Point(20, 115);
        lblScheduleRoom.Name = "lblScheduleRoom";
        lblScheduleRoom.Size = new System.Drawing.Size(300, 21);
        lblScheduleRoom.TabIndex = 3;
        lblScheduleRoom.Text = "Lịch / phòng:  T3 / T6 · 18:00–20:00 · P201";
        // 
        // lblTeacher
        // 
        lblTeacher.AutoSize = true;
        lblTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTeacher.Location = new System.Drawing.Point(20, 85);
        lblTeacher.Name = "lblTeacher";
        lblTeacher.Size = new System.Drawing.Size(223, 21);
        lblTeacher.TabIndex = 2;
        lblTeacher.Text = "Giáo viên:  Nguyễn Hoàng Anh";
        // 
        // lblCourse
        // 
        lblCourse.AutoSize = true;
        lblCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCourse.Location = new System.Drawing.Point(20, 55);
        lblCourse.Name = "lblCourse";
        lblCourse.Size = new System.Drawing.Size(204, 21);
        lblCourse.TabIndex = 1;
        lblCourse.Text = "Khóa học:  IELTS Foundation";
        // 
        // lblAcademicTitle
        // 
        lblAcademicTitle.AutoSize = true;
        lblAcademicTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAcademicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAcademicTitle.Location = new System.Drawing.Point(20, 16);
        lblAcademicTitle.Name = "lblAcademicTitle";
        lblAcademicTitle.Size = new System.Drawing.Size(162, 28);
        lblAcademicTitle.TabIndex = 0;
        lblAcademicTitle.Text = "Tóm tắt học tập";
        // 
        // cardStatTuitionDue
        // 
        cardStatTuitionDue.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardStatTuitionDue.BackColor = System.Drawing.Color.White;
        cardStatTuitionDue.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatTuitionDue.BorderWidth = 1;
        cardStatTuitionDue.Controls.Add(lblStatTuitionDueVal);
        cardStatTuitionDue.Controls.Add(lblStatTuitionDueTitle);
        cardStatTuitionDue.CornerRadius = 8;
        cardStatTuitionDue.Location = new System.Drawing.Point(920, 20);
        cardStatTuitionDue.Name = "cardStatTuitionDue";
        cardStatTuitionDue.Padding = new System.Windows.Forms.Padding(16);
        cardStatTuitionDue.Size = new System.Drawing.Size(275, 80);
        cardStatTuitionDue.TabIndex = 10;
        // 
        // lblStatTuitionDueVal
        // 
        lblStatTuitionDueVal.AutoSize = true;
        lblStatTuitionDueVal.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
        lblStatTuitionDueVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblStatTuitionDueVal.Location = new System.Drawing.Point(14, 30);
        lblStatTuitionDueVal.Name = "lblStatTuitionDueVal";
        lblStatTuitionDueVal.Size = new System.Drawing.Size(170, 40);
        lblStatTuitionDueVal.TabIndex = 1;
        lblStatTuitionDueVal.Text = "1.900.000đ";
        // 
        // lblStatTuitionDueTitle
        // 
        lblStatTuitionDueTitle.AutoSize = true;
        lblStatTuitionDueTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatTuitionDueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatTuitionDueTitle.Location = new System.Drawing.Point(16, 10);
        lblStatTuitionDueTitle.Name = "lblStatTuitionDueTitle";
        lblStatTuitionDueTitle.Size = new System.Drawing.Size(109, 20);
        lblStatTuitionDueTitle.TabIndex = 0;
        lblStatTuitionDueTitle.Text = "Học phí còn lại";
        // 
        // cardStatAttendance
        // 
        cardStatAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardStatAttendance.BackColor = System.Drawing.Color.White;
        cardStatAttendance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatAttendance.BorderWidth = 1;
        cardStatAttendance.Controls.Add(lblStatAttendanceVal);
        cardStatAttendance.Controls.Add(lblStatAttendanceTitle);
        cardStatAttendance.CornerRadius = 8;
        cardStatAttendance.Location = new System.Drawing.Point(640, 20);
        cardStatAttendance.Name = "cardStatAttendance";
        cardStatAttendance.Padding = new System.Windows.Forms.Padding(16);
        cardStatAttendance.Size = new System.Drawing.Size(265, 80);
        cardStatAttendance.TabIndex = 9;
        // 
        // lblStatAttendanceVal
        // 
        lblStatAttendanceVal.AutoSize = true;
        lblStatAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatAttendanceVal.Location = new System.Drawing.Point(14, 30);
        lblStatAttendanceVal.Name = "lblStatAttendanceVal";
        lblStatAttendanceVal.Size = new System.Drawing.Size(103, 41);
        lblStatAttendanceVal.TabIndex = 1;
        lblStatAttendanceVal.Text = "87,5%";
        // 
        // lblStatAttendanceTitle
        // 
        lblStatAttendanceTitle.AutoSize = true;
        lblStatAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatAttendanceTitle.Location = new System.Drawing.Point(16, 10);
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
        cardStatLessons.Location = new System.Drawing.Point(300, 20);
        cardStatLessons.Name = "cardStatLessons";
        cardStatLessons.Padding = new System.Windows.Forms.Padding(16);
        cardStatLessons.Size = new System.Drawing.Size(265, 80);
        cardStatLessons.TabIndex = 8;
        // 
        // lblStatLessonsVal
        // 
        lblStatLessonsVal.AutoSize = true;
        lblStatLessonsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatLessonsVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatLessonsVal.Location = new System.Drawing.Point(14, 30);
        lblStatLessonsVal.Name = "lblStatLessonsVal";
        lblStatLessonsVal.Size = new System.Drawing.Size(98, 41);
        lblStatLessonsVal.TabIndex = 1;
        lblStatLessonsVal.Text = "8 / 24";
        // 
        // lblStatLessonsTitle
        // 
        lblStatLessonsTitle.AutoSize = true;
        lblStatLessonsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatLessonsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatLessonsTitle.Location = new System.Drawing.Point(16, 10);
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
        cardStatClass.Location = new System.Drawing.Point(20, 20);
        cardStatClass.Name = "cardStatClass";
        cardStatClass.Padding = new System.Windows.Forms.Padding(16);
        cardStatClass.Size = new System.Drawing.Size(265, 80);
        cardStatClass.TabIndex = 7;
        // 
        // lblStatClassVal
        // 
        lblStatClassVal.AutoSize = true;
        lblStatClassVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStatClassVal.Location = new System.Drawing.Point(14, 30);
        lblStatClassVal.Name = "lblStatClassVal";
        lblStatClassVal.Size = new System.Drawing.Size(154, 41);
        lblStatClassVal.TabIndex = 1;
        lblStatClassVal.Text = "IELTS-F01";
        // 
        // lblStatClassTitle
        // 
        lblStatClassTitle.AutoSize = true;
        lblStatClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatClassTitle.Location = new System.Drawing.Point(16, 10);
        lblStatClassTitle.Name = "lblStatClassTitle";
        lblStatClassTitle.Size = new System.Drawing.Size(100, 20);
        lblStatClassTitle.TabIndex = 0;
        lblStatClassTitle.Text = "Lớp đang học";
        // 
        // StudentDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlNavTabs);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Hồ sơ chi tiết học viên — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        pnlNavTabs.ResumeLayout(false);
        pnlNavTabs.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardAuditLog.ResumeLayout(false);
        cardAuditLog.PerformLayout();
        cardTuitionSummary.ResumeLayout(false);
        cardTuitionSummary.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
        cardAcademicSummary.ResumeLayout(false);
        cardAcademicSummary.PerformLayout();
        cardStatTuitionDue.ResumeLayout(false);
        cardStatTuitionDue.PerformLayout();
        cardStatAttendance.ResumeLayout(false);
        cardStatAttendance.PerformLayout();
        cardStatLessons.ResumeLayout(false);
        cardStatLessons.PerformLayout();
        cardStatClass.ResumeLayout(false);
        cardStatClass.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblDetailHeader;
    private System.Windows.Forms.Label lblDetailSub;
    private ECMS.UI.Controls.AppButton btnArchive;
    private ECMS.UI.Controls.AppButton btnEditProfile;

    private System.Windows.Forms.Panel pnlNavTabs;
    private System.Windows.Forms.Label lblNavOverview;
    private System.Windows.Forms.Label lblNavClasses;
    private System.Windows.Forms.Label lblNavAttendance;
    private System.Windows.Forms.Label lblNavGrades;
    private System.Windows.Forms.Label lblNavTuition;
    private System.Windows.Forms.Label lblNavHistory;

    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStatClass;
    private System.Windows.Forms.Label lblStatClassTitle;
    private System.Windows.Forms.Label lblStatClassVal;
    private ECMS.UI.Controls.AppCard cardStatLessons;
    private System.Windows.Forms.Label lblStatLessonsTitle;
    private System.Windows.Forms.Label lblStatLessonsVal;
    private ECMS.UI.Controls.AppCard cardStatAttendance;
    private System.Windows.Forms.Label lblStatAttendanceTitle;
    private System.Windows.Forms.Label lblStatAttendanceVal;
    private ECMS.UI.Controls.AppCard cardStatTuitionDue;
    private System.Windows.Forms.Label lblStatTuitionDueTitle;
    private System.Windows.Forms.Label lblStatTuitionDueVal;

    private ECMS.UI.Controls.AppCard cardAcademicSummary;
    private System.Windows.Forms.Label lblAcademicTitle;
    private System.Windows.Forms.Label lblCourse;
    private System.Windows.Forms.Label lblTeacher;
    private System.Windows.Forms.Label lblScheduleRoom;
    private System.Windows.Forms.Label lblAttendanceDetail;
    private System.Windows.Forms.Label lblEntryGrades;
    private System.Windows.Forms.Label lblTermGrades;
    private System.Windows.Forms.Label lblCertInfo;
    private ECMS.UI.Controls.AppButton btnViewAcademicDetail;

    private ECMS.UI.Controls.AppCard cardTuitionSummary;
    private System.Windows.Forms.Label lblTuitionTitle;
    private System.Windows.Forms.Label lblTuitionBase;
    private System.Windows.Forms.Label lblTuitionPaid;
    private System.Windows.Forms.Label lblTuitionDue;
    private ECMS.UI.Controls.AppDataGrid dgvReceipts;
    private ECMS.UI.Controls.AppButton btnOpenDebt;

    private ECMS.UI.Controls.AppCard cardAuditLog;
    private System.Windows.Forms.Label lblAuditTitle;
    private System.Windows.Forms.Label lblAuditText;
}
