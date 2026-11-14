namespace ECMS.UI.UserControls;

partial class TeacherAttendanceSummaryView
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

    #region Component Designer generated code

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
        pnlHeader = new System.Windows.Forms.Panel();
        btnBackAttendance = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlWizard = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardAbsenceTracking = new ECMS.UI.Controls.AppCard();
        btnRecordTracking = new ECMS.UI.Controls.AppButton();
        lblInChargeVal = new System.Windows.Forms.Label();
        lblInChargeKey = new System.Windows.Forms.Label();
        lblReasonVal = new System.Windows.Forms.Label();
        lblReasonKey = new System.Windows.Forms.Label();
        lblParentVal = new System.Windows.Forms.Label();
        lblParentKey = new System.Windows.Forms.Label();
        lblPhoneVal = new System.Windows.Forms.Label();
        lblPhoneKey = new System.Windows.Forms.Label();
        lblStudentVal = new System.Windows.Forms.Label();
        lblStudentKey = new System.Windows.Forms.Label();
        bannerTrackingWarning = new ECMS.UI.Controls.AppBanner();
        lblTrackingTitle = new System.Windows.Forms.Label();
        cardSummary = new ECMS.UI.Controls.AppCard();
        btnExportSummary = new ECMS.UI.Controls.AppButton();
        lblFinalCondition = new System.Windows.Forms.Label();
        lblFormula = new System.Windows.Forms.Label();
        lblClassTotal = new System.Windows.Forms.Label();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvSummary = new ECMS.UI.Controls.AppDataGrid();
        lblSummaryTitle = new System.Windows.Forms.Label();
        bannerSuccessSaved = new ECMS.UI.Controls.AppBanner();
        pnlHeader.SuspendLayout();
        pnlWizard.SuspendLayout();
        pnlBody.SuspendLayout();
        cardAbsenceTracking.SuspendLayout();
        cardSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnBackAttendance);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnBackAttendance
        // 
        btnBackAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBackAttendance.BackColor = System.Drawing.Color.White;
        btnBackAttendance.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackAttendance.CornerRadius = 5;
        btnBackAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBackAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBackAttendance.Location = new System.Drawing.Point(976, 20);
        btnBackAttendance.Name = "btnBackAttendance";
        btnBackAttendance.Size = new System.Drawing.Size(160, 36);
        btnBackAttendance.TabIndex = 3;
        btnBackAttendance.Text = "← Quay lại điểm danh";
        btnBackAttendance.UseVisualStyleBackColor = false;
        btnBackAttendance.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(389, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tổng hợp chuyên cần · IELTS-F01";
        // 
        // pnlWizard
        // 
        pnlWizard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlWizard.Controls.Add(lblStep4);
        pnlWizard.Controls.Add(lblStep3);
        pnlWizard.Controls.Add(lblStep2);
        pnlWizard.Controls.Add(lblStep1);
        pnlWizard.Dock = System.Windows.Forms.DockStyle.Top;
        pnlWizard.Location = new System.Drawing.Point(0, 75);
        pnlWizard.Name = "pnlWizard";
        pnlWizard.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlWizard.Size = new System.Drawing.Size(1160, 36);
        pnlWizard.TabIndex = 1;
        // 
        // lblStep4
        // 
        lblStep4.AutoSize = true;
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep4.Location = new System.Drawing.Point(620, 10);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(135, 20);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "• 4. Lưu & tổng hợp";
        // 
        // lblStep3
        // 
        lblStep3.AutoSize = true;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep3.Location = new System.Drawing.Point(440, 10);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(97, 20);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "✓ Điểm danh";
        // 
        // lblStep2
        // 
        lblStep2.AutoSize = true;
        lblStep2.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep2.Location = new System.Drawing.Point(240, 10);
        lblStep2.Name = "lblStep2";
        lblStep2.Size = new System.Drawing.Size(92, 20);
        lblStep2.TabIndex = 1;
        lblStep2.Text = "✓ Chọn buổi";
        // 
        // lblStep1
        // 
        lblStep1.AutoSize = true;
        lblStep1.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep1.Location = new System.Drawing.Point(40, 10);
        lblStep1.Name = "lblStep1";
        lblStep1.Size = new System.Drawing.Size(84, 20);
        lblStep1.TabIndex = 0;
        lblStep1.Text = "✓ Chọn lớp";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardAbsenceTracking);
        pnlBody.Controls.Add(cardSummary);
        pnlBody.Controls.Add(bannerSuccessSaved);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 111);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 649);
        pnlBody.TabIndex = 2;
        // 
        // cardAbsenceTracking
        // 
        cardAbsenceTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardAbsenceTracking.BackColor = System.Drawing.Color.White;
        cardAbsenceTracking.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAbsenceTracking.BorderWidth = 1;
        cardAbsenceTracking.Controls.Add(btnRecordTracking);
        cardAbsenceTracking.Controls.Add(lblInChargeVal);
        cardAbsenceTracking.Controls.Add(lblInChargeKey);
        cardAbsenceTracking.Controls.Add(lblReasonVal);
        cardAbsenceTracking.Controls.Add(lblReasonKey);
        cardAbsenceTracking.Controls.Add(lblParentVal);
        cardAbsenceTracking.Controls.Add(lblParentKey);
        cardAbsenceTracking.Controls.Add(lblPhoneVal);
        cardAbsenceTracking.Controls.Add(lblPhoneKey);
        cardAbsenceTracking.Controls.Add(lblStudentVal);
        cardAbsenceTracking.Controls.Add(lblStudentKey);
        cardAbsenceTracking.Controls.Add(bannerTrackingWarning);
        cardAbsenceTracking.Controls.Add(lblTrackingTitle);
        cardAbsenceTracking.CornerRadius = 6;
        cardAbsenceTracking.Location = new System.Drawing.Point(740, 95);
        cardAbsenceTracking.Name = "cardAbsenceTracking";
        cardAbsenceTracking.Padding = new System.Windows.Forms.Padding(20);
        cardAbsenceTracking.Size = new System.Drawing.Size(396, 450);
        cardAbsenceTracking.TabIndex = 2;
        // 
        // btnRecordTracking
        // 
        btnRecordTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnRecordTracking.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnRecordTracking.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnRecordTracking.CornerRadius = 5;
        btnRecordTracking.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRecordTracking.FlatAppearance.BorderSize = 0;
        btnRecordTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRecordTracking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnRecordTracking.ForeColor = System.Drawing.Color.White;
        btnRecordTracking.Location = new System.Drawing.Point(20, 350);
        btnRecordTracking.Name = "btnRecordTracking";
        btnRecordTracking.Size = new System.Drawing.Size(356, 34);
        btnRecordTracking.TabIndex = 12;
        btnRecordTracking.Text = "Ghi nhận yêu cầu theo dõi";
        btnRecordTracking.UseVisualStyleBackColor = false;
        btnRecordTracking.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblInChargeVal
        // 
        lblInChargeVal.AutoSize = true;
        lblInChargeVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblInChargeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblInChargeVal.Location = new System.Drawing.Point(120, 290);
        lblInChargeVal.Name = "lblInChargeVal";
        lblInChargeVal.Size = new System.Drawing.Size(188, 20);
        lblInChargeVal.TabIndex = 11;
        lblInChargeVal.Text = "Nguyễn Thị Hạnh · Đào tạo";
        // 
        // lblInChargeKey
        // 
        lblInChargeKey.AutoSize = true;
        lblInChargeKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblInChargeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblInChargeKey.Location = new System.Drawing.Point(20, 290);
        lblInChargeKey.Name = "lblInChargeKey";
        lblInChargeKey.Size = new System.Drawing.Size(70, 20);
        lblInChargeKey.TabIndex = 10;
        lblInChargeKey.Text = "Phụ trách";
        // 
        // lblReasonVal
        // 
        lblReasonVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblReasonVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblReasonVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblReasonVal.Location = new System.Drawing.Point(120, 245);
        lblReasonVal.Name = "lblReasonVal";
        lblReasonVal.Size = new System.Drawing.Size(256, 35);
        lblReasonVal.TabIndex = 9;
        lblReasonVal.Text = "Bận lịch cá nhân; đề nghị chuyển lớp";
        // 
        // lblReasonKey
        // 
        lblReasonKey.AutoSize = true;
        lblReasonKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblReasonKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblReasonKey.Location = new System.Drawing.Point(20, 245);
        lblReasonKey.Name = "lblReasonKey";
        lblReasonKey.Size = new System.Drawing.Size(105, 20);
        lblReasonKey.TabIndex = 8;
        lblReasonKey.Text = "Lý do ghi nhận";
        // 
        // lblParentVal
        // 
        lblParentVal.AutoSize = true;
        lblParentVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblParentVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblParentVal.Location = new System.Drawing.Point(120, 215);
        lblParentVal.Name = "lblParentVal";
        lblParentVal.Size = new System.Drawing.Size(203, 20);
        lblParentVal.TabIndex = 7;
        lblParentVal.Text = "Lê Thanh Bình - 0909 552 114";
        // 
        // lblParentKey
        // 
        lblParentKey.AutoSize = true;
        lblParentKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblParentKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblParentKey.Location = new System.Drawing.Point(20, 215);
        lblParentKey.Name = "lblParentKey";
        lblParentKey.Size = new System.Drawing.Size(76, 20);
        lblParentKey.TabIndex = 6;
        lblParentKey.Text = "Phụ huynh";
        // 
        // lblPhoneVal
        // 
        lblPhoneVal.AutoSize = true;
        lblPhoneVal.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblPhoneVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblPhoneVal.Location = new System.Drawing.Point(120, 185);
        lblPhoneVal.Name = "lblPhoneVal";
        lblPhoneVal.Size = new System.Drawing.Size(97, 20);
        lblPhoneVal.TabIndex = 5;
        lblPhoneVal.Text = "0904 221 678";
        // 
        // lblPhoneKey
        // 
        lblPhoneKey.AutoSize = true;
        lblPhoneKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblPhoneKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPhoneKey.Location = new System.Drawing.Point(20, 185);
        lblPhoneKey.Name = "lblPhoneKey";
        lblPhoneKey.Size = new System.Drawing.Size(78, 20);
        lblPhoneKey.TabIndex = 4;
        lblPhoneKey.Text = "Điện thoại";
        // 
        // lblStudentVal
        // 
        lblStudentVal.AutoSize = true;
        lblStudentVal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
        lblStudentVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblStudentVal.Location = new System.Drawing.Point(120, 155);
        lblStudentVal.Name = "lblStudentVal";
        lblStudentVal.Size = new System.Drawing.Size(188, 20);
        lblStudentVal.TabIndex = 3;
        lblStudentVal.Text = "Lê Hoàng Nam · HV-0237";
        // 
        // lblStudentKey
        // 
        lblStudentKey.AutoSize = true;
        lblStudentKey.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblStudentKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentKey.Location = new System.Drawing.Point(20, 155);
        lblStudentKey.Name = "lblStudentKey";
        lblStudentKey.Size = new System.Drawing.Size(67, 20);
        lblStudentKey.TabIndex = 2;
        lblStudentKey.Text = "Học viên";
        // 
        // bannerTrackingWarning
        // 
        bannerTrackingWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerTrackingWarning.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)243)), ((int)((byte)199)));
        bannerTrackingWarning.BannerType = ECMS.UI.Controls.BannerType.Warning;
        bannerTrackingWarning.Location = new System.Drawing.Point(20, 50);
        bannerTrackingWarning.Message = "Chuyển nhân viên đào tạo liên hệ, không chỉ dựa vào màu cảnh báo.";
        bannerTrackingWarning.Name = "bannerTrackingWarning";
        bannerTrackingWarning.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerTrackingWarning.Size = new System.Drawing.Size(356, 85);
        bannerTrackingWarning.TabIndex = 1;
        bannerTrackingWarning.Title = "! Lê Hoàng Nam vắng 4/8 buổi.";
        bannerTrackingWarning.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        // 
        // lblTrackingTitle
        // 
        lblTrackingTitle.AutoSize = true;
        lblTrackingTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTrackingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTrackingTitle.Location = new System.Drawing.Point(20, 16);
        lblTrackingTitle.Name = "lblTrackingTitle";
        lblTrackingTitle.Size = new System.Drawing.Size(241, 25);
        lblTrackingTitle.TabIndex = 0;
        lblTrackingTitle.Text = "Theo dõi vắng hơn 3 buổi";
        // 
        // cardSummary
        // 
        cardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardSummary.BackColor = System.Drawing.Color.White;
        cardSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardSummary.BorderWidth = 1;
        cardSummary.Controls.Add(btnExportSummary);
        cardSummary.Controls.Add(lblFinalCondition);
        cardSummary.Controls.Add(lblFormula);
        cardSummary.Controls.Add(lblClassTotal);
        cardSummary.Controls.Add(lblPagingNav);
        cardSummary.Controls.Add(lblPagingInfo);
        cardSummary.Controls.Add(dgvSummary);
        cardSummary.Controls.Add(lblSummaryTitle);
        cardSummary.CornerRadius = 6;
        cardSummary.Location = new System.Drawing.Point(24, 95);
        cardSummary.Name = "cardSummary";
        cardSummary.Padding = new System.Windows.Forms.Padding(20);
        cardSummary.Size = new System.Drawing.Size(696, 450);
        cardSummary.TabIndex = 1;
        // 
        // btnExportSummary
        // 
        btnExportSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnExportSummary.BackColor = System.Drawing.Color.White;
        btnExportSummary.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportSummary.CornerRadius = 5;
        btnExportSummary.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnExportSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExportSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnExportSummary.Location = new System.Drawing.Point(20, 395);
        btnExportSummary.Name = "btnExportSummary";
        btnExportSummary.Size = new System.Drawing.Size(190, 32);
        btnExportSummary.TabIndex = 7;
        btnExportSummary.Text = "Xuất tổng hợp ra tệp cục bộ";
        btnExportSummary.UseVisualStyleBackColor = false;
        btnExportSummary.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblFinalCondition
        // 
        lblFinalCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblFinalCondition.AutoSize = true;
        lblFinalCondition.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblFinalCondition.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFinalCondition.Location = new System.Drawing.Point(20, 365);
        lblFinalCondition.Name = "lblFinalCondition";
        lblFinalCondition.Size = new System.Drawing.Size(273, 19);
        lblFinalCondition.TabIndex = 6;
        lblFinalCondition.Text = "Điều kiện cuối khóa: ≥80% trên đủ 24 buổi";
        // 
        // lblFormula
        // 
        lblFormula.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblFormula.AutoSize = true;
        lblFormula.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblFormula.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFormula.Location = new System.Drawing.Point(20, 345);
        lblFormula.Name = "lblFormula";
        lblFormula.Size = new System.Drawing.Size(305, 19);
        lblFormula.TabIndex = 5;
        lblFormula.Text = "Công thức: (Có mặt + đi muộn) / số buổi đã học";
        // 
        // lblClassTotal
        // 
        lblClassTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblClassTotal.AutoSize = true;
        lblClassTotal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
        lblClassTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblClassTotal.Location = new System.Drawing.Point(20, 320);
        lblClassTotal.Name = "lblClassTotal";
        lblClassTotal.Size = new System.Drawing.Size(299, 20);
        lblClassTotal.TabIndex = 4;
        lblClassTotal.Text = "Toàn lớp: 130 / 144 lượt tham dự · 90,3%";
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(516, 285);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(160, 20);
        lblPagingNav.TabIndex = 3;
        lblPagingNav.Text = "< Trước   [1]   2   Sau >";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 285);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(122, 20);
        lblPagingInfo.TabIndex = 2;
        lblPagingInfo.Text = "1–4 / 18 học viên";
        // 
        // dgvSummary
        // 
        dgvSummary.AllowUserToAddRows = false;
        dgvSummary.AllowUserToDeleteRows = false;
        dgvSummary.AllowUserToResizeColumns = false;
        dgvSummary.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSummary.BackgroundColor = System.Drawing.Color.White;
        dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvSummary.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSummary.EnableHeadersVisualStyles = false;
        dgvSummary.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvSummary.Location = new System.Drawing.Point(20, 50);
        dgvSummary.MultiSelect = false;
        dgvSummary.Name = "dgvSummary";
        dgvSummary.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvSummary.RowHeadersVisible = false;
        dgvSummary.RowHeadersWidth = 51;
        dgvSummary.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSummary.Size = new System.Drawing.Size(656, 225);
        dgvSummary.TabIndex = 1;
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSummaryTitle.Location = new System.Drawing.Point(20, 16);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new System.Drawing.Size(223, 25);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Tổng hợp theo học viên";
        // 
        // bannerSuccessSaved
        // 
        bannerSuccessSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerSuccessSaved.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerSuccessSaved.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerSuccessSaved.Location = new System.Drawing.Point(24, 20);
        bannerSuccessSaved.Message = "Có mặt 15 + đi muộn 1; vắng 2. Tỷ lệ tham dự buổi: 16/18 = 88,9%.";
        bannerSuccessSaved.Name = "bannerSuccessSaved";
        bannerSuccessSaved.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerSuccessSaved.Size = new System.Drawing.Size(1112, 60);
        bannerSuccessSaved.TabIndex = 0;
        bannerSuccessSaved.Title = "✓ Đã lưu điểm danh buổi 08.";
        bannerSuccessSaved.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // TeacherAttendanceSummaryView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlWizard);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlWizard.ResumeLayout(false);
        pnlWizard.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardAbsenceTracking.ResumeLayout(false);
        cardAbsenceTracking.PerformLayout();
        cardSummary.ResumeLayout(false);
        cardSummary.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnBackAttendance;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlWizard;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppBanner bannerSuccessSaved;
    private ECMS.UI.Controls.AppCard cardSummary;
    private System.Windows.Forms.Label lblSummaryTitle;
    private ECMS.UI.Controls.AppDataGrid dgvSummary;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Label lblClassTotal;
    private System.Windows.Forms.Label lblFormula;
    private System.Windows.Forms.Label lblFinalCondition;
    private ECMS.UI.Controls.AppButton btnExportSummary;
    private ECMS.UI.Controls.AppCard cardAbsenceTracking;
    private System.Windows.Forms.Label lblTrackingTitle;
    private ECMS.UI.Controls.AppBanner bannerTrackingWarning;
    private System.Windows.Forms.Label lblStudentKey;
    private System.Windows.Forms.Label lblStudentVal;
    private System.Windows.Forms.Label lblPhoneKey;
    private System.Windows.Forms.Label lblPhoneVal;
    private System.Windows.Forms.Label lblParentKey;
    private System.Windows.Forms.Label lblParentVal;
    private System.Windows.Forms.Label lblReasonKey;
    private System.Windows.Forms.Label lblReasonVal;
    private System.Windows.Forms.Label lblInChargeKey;
    private System.Windows.Forms.Label lblInChargeVal;
    private ECMS.UI.Controls.AppButton btnRecordTracking;
}
