namespace ECMS.UI.Forms;

partial class ClassDetailDialog
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
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        btnEditClass = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabHistory = new System.Windows.Forms.Button();
        btnTabGrades = new System.Windows.Forms.Button();
        btnTabAttendance = new System.Windows.Forms.Button();
        btnTabSchedule = new System.Windows.Forms.Button();
        btnTabStudents = new System.Windows.Forms.Button();
        pnlBody = new System.Windows.Forms.Panel();
        cardTransferPreview = new ECMS.UI.Controls.AppCard();
        lblTransferFootnote = new System.Windows.Forms.Label();
        btnConfirmTransfer = new ECMS.UI.Controls.AppButton();
        btnCancelTransfer = new ECMS.UI.Controls.AppButton();
        bannerTransferWarning = new ECMS.UI.Controls.AppBanner();
        dtpEffectiveDate = new System.Windows.Forms.DateTimePicker();
        lblEffectiveDate = new System.Windows.Forms.Label();
        txtTransferReason = new ECMS.UI.Controls.AppTextBox();
        lblTransferReason = new System.Windows.Forms.Label();
        lblDestClassVal = new System.Windows.Forms.Label();
        lblDestClassKey = new System.Windows.Forms.Label();
        lblSourceClassVal = new System.Windows.Forms.Label();
        lblSourceClassKey = new System.Windows.Forms.Label();
        lblStudentTargetVal = new System.Windows.Forms.Label();
        lblStudentTargetKey = new System.Windows.Forms.Label();
        lblTransferTitle = new System.Windows.Forms.Label();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        bannerClassStatus = new ECMS.UI.Controls.AppBanner();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvClassStudents = new ECMS.UI.Controls.AppDataGrid();
        lblStudentListTitle = new System.Windows.Forms.Label();
        cardStatAttendance = new ECMS.UI.Controls.AppCard();
        lblStatAttendanceVal = new System.Windows.Forms.Label();
        lblStatAttendanceTitle = new System.Windows.Forms.Label();
        cardStatStatus = new ECMS.UI.Controls.AppCard();
        lblStatStatusVal = new System.Windows.Forms.Label();
        lblStatStatusTitle = new System.Windows.Forms.Label();
        cardStatSessions = new ECMS.UI.Controls.AppCard();
        lblStatSessionsVal = new System.Windows.Forms.Label();
        lblStatSessionsTitle = new System.Windows.Forms.Label();
        cardStatEnrollment = new ECMS.UI.Controls.AppCard();
        lblStatEnrollmentVal = new System.Windows.Forms.Label();
        lblStatEnrollmentTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardTransferPreview.SuspendLayout();
        cardStudentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).BeginInit();
        cardStatAttendance.SuspendLayout();
        cardStatStatus.SuspendLayout();
        cardStatSessions.SuspendLayout();
        cardStatEnrollment.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddStudent);
        pnlHeader.Controls.Add(btnEditClass);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddStudent
        // 
        btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddStudent.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnAddStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddStudent.ForeColor = System.Drawing.Color.White;
        btnAddStudent.Location = new System.Drawing.Point(1055, 20);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new System.Drawing.Size(141, 36);
        btnAddStudent.TabIndex = 4;
        btnAddStudent.Text = "+ Thêm học viên";
        btnAddStudent.UseVisualStyleBackColor = false;
        // 
        // btnEditClass
        // 
        btnEditClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnEditClass.BackColor = System.Drawing.Color.White;
        btnEditClass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnEditClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnEditClass.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnEditClass.Location = new System.Drawing.Point(950, 20);
        btnEditClass.Name = "btnEditClass";
        btnEditClass.Size = new System.Drawing.Size(95, 36);
        btnEditClass.TabIndex = 3;
        btnEditClass.Text = "Sửa lớp";
        btnEditClass.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(438, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "06/10–25/12/2026 · T3 / T6 18:00–20:00 · P201 · Giáo viên Nguyễn Hoàng Anh";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(315, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "IELTS-F01 · IELTS Foundation";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(232, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lớp học / IELTS-F01 · IELTS Foundation";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = System.Drawing.Color.White;
        pnlTabs.Controls.Add(btnTabHistory);
        pnlTabs.Controls.Add(btnTabGrades);
        pnlTabs.Controls.Add(btnTabAttendance);
        pnlTabs.Controls.Add(btnTabSchedule);
        pnlTabs.Controls.Add(btnTabStudents);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(0, 75);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlTabs.Size = new System.Drawing.Size(1220, 42);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabHistory
        // 
        btnTabHistory.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabHistory.FlatAppearance.BorderSize = 0;
        btnTabHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabHistory.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        btnTabHistory.Location = new System.Drawing.Point(444, 0);
        btnTabHistory.Name = "btnTabHistory";
        btnTabHistory.Size = new System.Drawing.Size(100, 42);
        btnTabHistory.TabIndex = 4;
        btnTabHistory.Text = "Lịch sử";
        btnTabHistory.UseVisualStyleBackColor = true;
        // 
        // btnTabGrades
        // 
        btnTabGrades.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabGrades.FlatAppearance.BorderSize = 0;
        btnTabGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabGrades.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        btnTabGrades.Location = new System.Drawing.Point(344, 0);
        btnTabGrades.Name = "btnTabGrades";
        btnTabGrades.Size = new System.Drawing.Size(100, 42);
        btnTabGrades.TabIndex = 3;
        btnTabGrades.Text = "Điểm số";
        btnTabGrades.UseVisualStyleBackColor = true;
        // 
        // btnTabAttendance
        // 
        btnTabAttendance.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabAttendance.FlatAppearance.BorderSize = 0;
        btnTabAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabAttendance.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        btnTabAttendance.Location = new System.Drawing.Point(244, 0);
        btnTabAttendance.Name = "btnTabAttendance";
        btnTabAttendance.Size = new System.Drawing.Size(100, 42);
        btnTabAttendance.TabIndex = 2;
        btnTabAttendance.Text = "Điểm danh";
        btnTabAttendance.UseVisualStyleBackColor = true;
        // 
        // btnTabSchedule
        // 
        btnTabSchedule.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabSchedule.FlatAppearance.BorderSize = 0;
        btnTabSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabSchedule.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        btnTabSchedule.Location = new System.Drawing.Point(134, 0);
        btnTabSchedule.Name = "btnTabSchedule";
        btnTabSchedule.Size = new System.Drawing.Size(110, 42);
        btnTabSchedule.TabIndex = 1;
        btnTabSchedule.Text = "Lịch học";
        btnTabSchedule.UseVisualStyleBackColor = true;
        // 
        // btnTabStudents
        // 
        btnTabStudents.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabStudents.FlatAppearance.BorderSize = 0;
        btnTabStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabStudents.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnTabStudents.Location = new System.Drawing.Point(24, 0);
        btnTabStudents.Name = "btnTabStudents";
        btnTabStudents.Size = new System.Drawing.Size(110, 42);
        btnTabStudents.TabIndex = 0;
        btnTabStudents.Text = "▬ Học viên";
        btnTabStudents.UseVisualStyleBackColor = true;
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardTransferPreview);
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Controls.Add(cardStatAttendance);
        pnlBody.Controls.Add(cardStatStatus);
        pnlBody.Controls.Add(cardStatSessions);
        pnlBody.Controls.Add(cardStatEnrollment);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 117);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 643);
        pnlBody.TabIndex = 2;
        // 
        // cardTransferPreview
        // 
        cardTransferPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardTransferPreview.BackColor = System.Drawing.Color.White;
        cardTransferPreview.Controls.Add(lblTransferFootnote);
        cardTransferPreview.Controls.Add(btnConfirmTransfer);
        cardTransferPreview.Controls.Add(btnCancelTransfer);
        cardTransferPreview.Controls.Add(bannerTransferWarning);
        cardTransferPreview.Controls.Add(dtpEffectiveDate);
        cardTransferPreview.Controls.Add(lblEffectiveDate);
        cardTransferPreview.Controls.Add(txtTransferReason);
        cardTransferPreview.Controls.Add(lblTransferReason);
        cardTransferPreview.Controls.Add(lblDestClassVal);
        cardTransferPreview.Controls.Add(lblDestClassKey);
        cardTransferPreview.Controls.Add(lblSourceClassVal);
        cardTransferPreview.Controls.Add(lblSourceClassKey);
        cardTransferPreview.Controls.Add(lblStudentTargetVal);
        cardTransferPreview.Controls.Add(lblStudentTargetKey);
        cardTransferPreview.Controls.Add(lblTransferTitle);
        cardTransferPreview.Location = new System.Drawing.Point(820, 130);
        cardTransferPreview.Name = "cardTransferPreview";
        cardTransferPreview.Padding = new System.Windows.Forms.Padding(20);
        cardTransferPreview.Size = new System.Drawing.Size(376, 490);
        cardTransferPreview.TabIndex = 5;
        // 
        // lblTransferFootnote
        // 
        lblTransferFootnote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblTransferFootnote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblTransferFootnote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTransferFootnote.Location = new System.Drawing.Point(20, 440);
        lblTransferFootnote.Name = "lblTransferFootnote";
        lblTransferFootnote.Size = new System.Drawing.Size(336, 35);
        lblTransferFootnote.TabIndex = 14;
        lblTransferFootnote.Text = "Sau chuyển hợp lệ: nguồn 17/20, đích 1/20. Giữ lịch sử điểm và chuyên cần, không tự tạo phiếu thu.";
        // 
        // btnConfirmTransfer
        // 
        btnConfirmTransfer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnConfirmTransfer.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnConfirmTransfer.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnConfirmTransfer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmTransfer.ForeColor = System.Drawing.Color.White;
        btnConfirmTransfer.Location = new System.Drawing.Point(220, 395);
        btnConfirmTransfer.Name = "btnConfirmTransfer";
        btnConfirmTransfer.Size = new System.Drawing.Size(136, 36);
        btnConfirmTransfer.TabIndex = 13;
        btnConfirmTransfer.Text = "Xác nhận chuyển";
        btnConfirmTransfer.UseVisualStyleBackColor = false;
        // 
        // btnCancelTransfer
        // 
        btnCancelTransfer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelTransfer.BackColor = System.Drawing.Color.White;
        btnCancelTransfer.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancelTransfer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelTransfer.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancelTransfer.Location = new System.Drawing.Point(135, 395);
        btnCancelTransfer.Name = "btnCancelTransfer";
        btnCancelTransfer.Size = new System.Drawing.Size(75, 36);
        btnCancelTransfer.TabIndex = 12;
        btnCancelTransfer.Text = "Hủy";
        btnCancelTransfer.UseVisualStyleBackColor = false;
        // 
        // bannerTransferWarning
        // 
        bannerTransferWarning.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        bannerTransferWarning.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        bannerTransferWarning.Location = new System.Drawing.Point(20, 310);
        bannerTransferWarning.Message = "Lớp đích chưa mở. Chưa thể chuyển; mở IELTS-F04 và kiểm tra lịch trước.";
        bannerTransferWarning.Name = "bannerTransferWarning";
        bannerTransferWarning.Size = new System.Drawing.Size(336, 65);
        bannerTransferWarning.TabIndex = 11;
        // 
        // dtpEffectiveDate
        // 
        dtpEffectiveDate.CustomFormat = "dd/MM/yyyy";
        dtpEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEffectiveDate.Location = new System.Drawing.Point(20, 265);
        dtpEffectiveDate.Name = "dtpEffectiveDate";
        dtpEffectiveDate.Size = new System.Drawing.Size(336, 24);
        dtpEffectiveDate.TabIndex = 10;
        // 
        // lblEffectiveDate
        // 
        lblEffectiveDate.AutoSize = true;
        lblEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEffectiveDate.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblEffectiveDate.Location = new System.Drawing.Point(20, 245);
        lblEffectiveDate.Name = "lblEffectiveDate";
        lblEffectiveDate.Size = new System.Drawing.Size(89, 15);
        lblEffectiveDate.TabIndex = 9;
        lblEffectiveDate.Text = "Ngày hiệu lực *";
        // 
        // txtTransferReason
        // 
        txtTransferReason.Location = new System.Drawing.Point(20, 195);
        txtTransferReason.Name = "txtTransferReason";
        txtTransferReason.Placeholder = "Nhập lý do học viên chuyển lớp...";
        txtTransferReason.Size = new System.Drawing.Size(336, 35);
        txtTransferReason.TabIndex = 8;
        // 
        // lblTransferReason
        // 
        lblTransferReason.AutoSize = true;
        lblTransferReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTransferReason.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblTransferReason.Location = new System.Drawing.Point(20, 175);
        lblTransferReason.Name = "lblTransferReason";
        lblTransferReason.Size = new System.Drawing.Size(88, 15);
        lblTransferReason.TabIndex = 7;
        lblTransferReason.Text = "Lý do chuyển *";
        // 
        // lblDestClassVal
        // 
        lblDestClassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDestClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblDestClassVal.Location = new System.Drawing.Point(120, 130);
        lblDestClassVal.Name = "lblDestClassVal";
        lblDestClassVal.Size = new System.Drawing.Size(236, 20);
        lblDestClassVal.TabIndex = 6;
        lblDestClassVal.Text = "IELTS-F04 · 0/20 · Bản nháp";
        lblDestClassVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDestClassKey
        // 
        lblDestClassKey.AutoSize = true;
        lblDestClassKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDestClassKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblDestClassKey.Location = new System.Drawing.Point(20, 132);
        lblDestClassKey.Name = "lblDestClassKey";
        lblDestClassKey.Size = new System.Drawing.Size(53, 15);
        lblDestClassKey.TabIndex = 5;
        lblDestClassKey.Text = "Lớp đích";
        // 
        // lblSourceClassVal
        // 
        lblSourceClassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSourceClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblSourceClassVal.Location = new System.Drawing.Point(120, 90);
        lblSourceClassVal.Name = "lblSourceClassVal";
        lblSourceClassVal.Size = new System.Drawing.Size(236, 20);
        lblSourceClassVal.TabIndex = 4;
        lblSourceClassVal.Text = "IELTS-F01 · 18/20";
        lblSourceClassVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSourceClassKey
        // 
        lblSourceClassKey.AutoSize = true;
        lblSourceClassKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSourceClassKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSourceClassKey.Location = new System.Drawing.Point(20, 92);
        lblSourceClassKey.Name = "lblSourceClassKey";
        lblSourceClassKey.Size = new System.Drawing.Size(68, 15);
        lblSourceClassKey.TabIndex = 3;
        lblSourceClassKey.Text = "Lớp nguồn";
        // 
        // lblStudentTargetVal
        // 
        lblStudentTargetVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentTargetVal.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblStudentTargetVal.Location = new System.Drawing.Point(120, 50);
        lblStudentTargetVal.Name = "lblStudentTargetVal";
        lblStudentTargetVal.Size = new System.Drawing.Size(236, 20);
        lblStudentTargetVal.TabIndex = 2;
        lblStudentTargetVal.Text = "Lê Hoàng Nam · HV-0237";
        lblStudentTargetVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblStudentTargetKey
        // 
        lblStudentTargetKey.AutoSize = true;
        lblStudentTargetKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStudentTargetKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStudentTargetKey.Location = new System.Drawing.Point(20, 52);
        lblStudentTargetKey.Name = "lblStudentTargetKey";
        lblStudentTargetKey.Size = new System.Drawing.Size(55, 15);
        lblStudentTargetKey.TabIndex = 1;
        lblStudentTargetKey.Text = "Học viên";
        // 
        // lblTransferTitle
        // 
        lblTransferTitle.AutoSize = true;
        lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTransferTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTransferTitle.Location = new System.Drawing.Point(20, 16);
        lblTransferTitle.Name = "lblTransferTitle";
        lblTransferTitle.Size = new System.Drawing.Size(183, 21);
        lblTransferTitle.TabIndex = 0;
        lblTransferTitle.Text = "Chuyển lớp · Xem trước";
        // 
        // cardStudentList
        // 
        cardStudentList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.Controls.Add(bannerClassStatus);
        cardStudentList.Controls.Add(lblPagingNav);
        cardStudentList.Controls.Add(lblPagingInfo);
        cardStudentList.Controls.Add(dgvClassStudents);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.Location = new System.Drawing.Point(24, 130);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(20);
        cardStudentList.Size = new System.Drawing.Size(775, 490);
        cardStudentList.TabIndex = 4;
        // 
        // bannerClassStatus
        // 
        bannerClassStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerClassStatus.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerClassStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerClassStatus.Location = new System.Drawing.Point(20, 425);
        bannerClassStatus.Message = "✓  Lớp đã mở ngày 06/10/2026. Đủ giáo viên, phòng và lịch học hợp lệ.";
        bannerClassStatus.Name = "bannerClassStatus";
        bannerClassStatus.Size = new System.Drawing.Size(735, 45);
        bannerClassStatus.TabIndex = 4;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(630, 385);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(122, 15);
        lblPagingNav.TabIndex = 3;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPagingInfo.Location = new System.Drawing.Point(20, 385);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(107, 15);
        lblPagingInfo.TabIndex = 2;
        lblPagingInfo.Text = "1–4 / 18 học viên";
        // 
        // dgvClassStudents
        // 
        dgvClassStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClassStudents.Location = new System.Drawing.Point(20, 50);
        dgvClassStudents.Name = "dgvClassStudents";
        dgvClassStudents.Size = new System.Drawing.Size(735, 320);
        dgvClassStudents.TabIndex = 1;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.AutoSize = true;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStudentListTitle.Location = new System.Drawing.Point(20, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(158, 21);
        lblStudentListTitle.TabIndex = 0;
        lblStudentListTitle.Text = "Học viên trong lớp";
        // 
        // cardStatAttendance
        // 
        cardStatAttendance.BackColor = System.Drawing.Color.White;
        cardStatAttendance.Controls.Add(lblStatAttendanceVal);
        cardStatAttendance.Controls.Add(lblStatAttendanceTitle);
        cardStatAttendance.Location = new System.Drawing.Point(909, 24);
        cardStatAttendance.Name = "cardStatAttendance";
        cardStatAttendance.Padding = new System.Windows.Forms.Padding(16);
        cardStatAttendance.Size = new System.Drawing.Size(287, 85);
        cardStatAttendance.TabIndex = 3;
        // 
        // lblStatAttendanceVal
        // 
        lblStatAttendanceVal.AutoSize = true;
        lblStatAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatAttendanceVal.Location = new System.Drawing.Point(16, 38);
        lblStatAttendanceVal.Name = "lblStatAttendanceVal";
        lblStatAttendanceVal.Size = new System.Drawing.Size(84, 32);
        lblStatAttendanceVal.TabIndex = 1;
        lblStatAttendanceVal.Text = "90,3%";
        // 
        // lblStatAttendanceTitle
        // 
        lblStatAttendanceTitle.AutoSize = true;
        lblStatAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatAttendanceTitle.Location = new System.Drawing.Point(16, 16);
        lblStatAttendanceTitle.Name = "lblStatAttendanceTitle";
        lblStatAttendanceTitle.Size = new System.Drawing.Size(95, 15);
        lblStatAttendanceTitle.TabIndex = 0;
        lblStatAttendanceTitle.Text = "Chuyên cần lớp";
        // 
        // cardStatStatus
        // 
        cardStatStatus.BackColor = System.Drawing.Color.White;
        cardStatStatus.Controls.Add(lblStatStatusVal);
        cardStatStatus.Controls.Add(lblStatStatusTitle);
        cardStatStatus.Location = new System.Drawing.Point(614, 24);
        cardStatStatus.Name = "cardStatStatus";
        cardStatStatus.Padding = new System.Windows.Forms.Padding(16);
        cardStatStatus.Size = new System.Drawing.Size(287, 85);
        cardStatStatus.TabIndex = 2;
        // 
        // lblStatStatusVal
        // 
        lblStatStatusVal.AutoSize = true;
        lblStatStatusVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatStatusVal.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblStatStatusVal.Location = new System.Drawing.Point(16, 38);
        lblStatStatusVal.Name = "lblStatStatusVal";
        lblStatStatusVal.Size = new System.Drawing.Size(124, 32);
        lblStatStatusVal.TabIndex = 1;
        lblStatStatusVal.Text = "Đang học";
        // 
        // lblStatStatusTitle
        // 
        lblStatStatusTitle.AutoSize = true;
        lblStatStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatStatusTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatStatusTitle.Location = new System.Drawing.Point(16, 16);
        lblStatStatusTitle.Name = "lblStatStatusTitle";
        lblStatStatusTitle.Size = new System.Drawing.Size(84, 15);
        lblStatStatusTitle.TabIndex = 0;
        lblStatStatusTitle.Text = "Trạng thái lớp";
        // 
        // cardStatSessions
        // 
        cardStatSessions.BackColor = System.Drawing.Color.White;
        cardStatSessions.Controls.Add(lblStatSessionsVal);
        cardStatSessions.Controls.Add(lblStatSessionsTitle);
        cardStatSessions.Location = new System.Drawing.Point(319, 24);
        cardStatSessions.Name = "cardStatSessions";
        cardStatSessions.Padding = new System.Windows.Forms.Padding(16);
        cardStatSessions.Size = new System.Drawing.Size(287, 85);
        cardStatSessions.TabIndex = 1;
        // 
        // lblStatSessionsVal
        // 
        lblStatSessionsVal.AutoSize = true;
        lblStatSessionsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatSessionsVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatSessionsVal.Location = new System.Drawing.Point(16, 38);
        lblStatSessionsVal.Name = "lblStatSessionsVal";
        lblStatSessionsVal.Size = new System.Drawing.Size(86, 32);
        lblStatSessionsVal.TabIndex = 1;
        lblStatSessionsVal.Text = "8 / 24";
        // 
        // lblStatSessionsTitle
        // 
        lblStatSessionsTitle.AutoSize = true;
        lblStatSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatSessionsTitle.Location = new System.Drawing.Point(16, 16);
        lblStatSessionsTitle.Name = "lblStatSessionsTitle";
        lblStatSessionsTitle.Size = new System.Drawing.Size(73, 15);
        lblStatSessionsTitle.TabIndex = 0;
        lblStatSessionsTitle.Text = "Buổi đã học";
        // 
        // cardStatEnrollment
        // 
        cardStatEnrollment.BackColor = System.Drawing.Color.White;
        cardStatEnrollment.Controls.Add(lblStatEnrollmentVal);
        cardStatEnrollment.Controls.Add(lblStatEnrollmentTitle);
        cardStatEnrollment.Location = new System.Drawing.Point(24, 24);
        cardStatEnrollment.Name = "cardStatEnrollment";
        cardStatEnrollment.Padding = new System.Windows.Forms.Padding(16);
        cardStatEnrollment.Size = new System.Drawing.Size(287, 85);
        cardStatEnrollment.TabIndex = 0;
        // 
        // lblStatEnrollmentVal
        // 
        lblStatEnrollmentVal.AutoSize = true;
        lblStatEnrollmentVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatEnrollmentVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblStatEnrollmentVal.Location = new System.Drawing.Point(16, 38);
        lblStatEnrollmentVal.Name = "lblStatEnrollmentVal";
        lblStatEnrollmentVal.Size = new System.Drawing.Size(94, 32);
        lblStatEnrollmentVal.TabIndex = 1;
        lblStatEnrollmentVal.Text = "18 / 20";
        // 
        // lblStatEnrollmentTitle
        // 
        lblStatEnrollmentTitle.AutoSize = true;
        lblStatEnrollmentTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatEnrollmentTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatEnrollmentTitle.Location = new System.Drawing.Point(16, 16);
        lblStatEnrollmentTitle.Name = "lblStatEnrollmentTitle";
        lblStatEnrollmentTitle.Size = new System.Drawing.Size(86, 15);
        lblStatEnrollmentTitle.TabIndex = 0;
        lblStatEnrollmentTitle.Text = "Sĩ số hiện tại";
        // 
        // ClassDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ClassDetailDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết lớp học · IELTS-F01";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardTransferPreview.ResumeLayout(false);
        cardTransferPreview.PerformLayout();
        cardStudentList.ResumeLayout(false);
        cardStudentList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).EndInit();
        cardStatAttendance.ResumeLayout(false);
        cardStatAttendance.PerformLayout();
        cardStatStatus.ResumeLayout(false);
        cardStatStatus.PerformLayout();
        cardStatSessions.ResumeLayout(false);
        cardStatSessions.PerformLayout();
        cardStatEnrollment.ResumeLayout(false);
        cardStatEnrollment.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private ECMS.UI.Controls.AppButton btnEditClass;
    private ECMS.UI.Controls.AppButton btnAddStudent;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabStudents;
    private System.Windows.Forms.Button btnTabSchedule;
    private System.Windows.Forms.Button btnTabAttendance;
    private System.Windows.Forms.Button btnTabGrades;
    private System.Windows.Forms.Button btnTabHistory;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStatEnrollment;
    private System.Windows.Forms.Label lblStatEnrollmentTitle;
    private System.Windows.Forms.Label lblStatEnrollmentVal;
    private ECMS.UI.Controls.AppCard cardStatSessions;
    private System.Windows.Forms.Label lblStatSessionsTitle;
    private System.Windows.Forms.Label lblStatSessionsVal;
    private ECMS.UI.Controls.AppCard cardStatStatus;
    private System.Windows.Forms.Label lblStatStatusTitle;
    private System.Windows.Forms.Label lblStatStatusVal;
    private ECMS.UI.Controls.AppCard cardStatAttendance;
    private System.Windows.Forms.Label lblStatAttendanceTitle;
    private System.Windows.Forms.Label lblStatAttendanceVal;
    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClassStudents;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppBanner bannerClassStatus;
    private ECMS.UI.Controls.AppCard cardTransferPreview;
    private System.Windows.Forms.Label lblTransferTitle;
    private System.Windows.Forms.Label lblStudentTargetKey;
    private System.Windows.Forms.Label lblStudentTargetVal;
    private System.Windows.Forms.Label lblSourceClassKey;
    private System.Windows.Forms.Label lblSourceClassVal;
    private System.Windows.Forms.Label lblDestClassKey;
    private System.Windows.Forms.Label lblDestClassVal;
    private System.Windows.Forms.Label lblTransferReason;
    private ECMS.UI.Controls.AppTextBox txtTransferReason;
    private System.Windows.Forms.Label lblEffectiveDate;
    private System.Windows.Forms.DateTimePicker dtpEffectiveDate;
    private ECMS.UI.Controls.AppBanner bannerTransferWarning;
    private ECMS.UI.Controls.AppButton btnCancelTransfer;
    private ECMS.UI.Controls.AppButton btnConfirmTransfer;
    private System.Windows.Forms.Label lblTransferFootnote;
}
