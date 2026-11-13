namespace ECMS.UI.Forms;

partial class EnrollmentDialog
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
        pnlTop = new System.Windows.Forms.Panel();
        lblEnrollSub = new System.Windows.Forms.Label();
        lblEnrollHeader = new System.Windows.Forms.Label();
        cardEnrollSummary = new ECMS.UI.Controls.AppCard();
        lblTransNext = new System.Windows.Forms.Label();
        lblTransChecked = new System.Windows.Forms.Label();
        lblTransDuration = new System.Windows.Forms.Label();
        lblTransRoom = new System.Windows.Forms.Label();
        lblTransTeacher = new System.Windows.Forms.Label();
        lblTransNetFee = new System.Windows.Forms.Label();
        lblTransCourse = new System.Windows.Forms.Label();
        lblTransScore = new System.Windows.Forms.Label();
        lblTransPhone = new System.Windows.Forms.Label();
        lblTransName = new System.Windows.Forms.Label();
        lblTransferTitle = new System.Windows.Forms.Label();
        cardClassSelect = new ECMS.UI.Controls.AppCard();
        btnConfirmEnroll = new ECMS.UI.Controls.AppButton();
        btnBackToConsult = new ECMS.UI.Controls.AppButton();
        bannerEnrollPlan = new ECMS.UI.Controls.AppBanner();
        txtEnrollDiscount = new ECMS.UI.Controls.AppTextBox();
        lblEnrollDiscount = new System.Windows.Forms.Label();
        txtEnrollOriginalFee = new ECMS.UI.Controls.AppTextBox();
        lblEnrollOriginalFee = new System.Windows.Forms.Label();
        cboSubstituteClass = new ECMS.UI.Controls.AppComboBox();
        lblSubstituteClass = new System.Windows.Forms.Label();
        dtpEnrollDate = new System.Windows.Forms.DateTimePicker();
        lblEnrollDate = new System.Windows.Forms.Label();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        bannerClassFull = new ECMS.UI.Controls.AppBanner();
        lblClassSelectTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        cardEnrollSummary.SuspendLayout();
        cardClassSelect.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblEnrollSub);
        pnlTop.Controls.Add(lblEnrollHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1140, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblEnrollSub
        // 
        lblEnrollSub.AutoSize = true;
        lblEnrollSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEnrollSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblEnrollSub.Location = new System.Drawing.Point(24, 45);
        lblEnrollSub.Name = "lblEnrollSub";
        lblEnrollSub.Size = new System.Drawing.Size(434, 20);
        lblEnrollSub.TabIndex = 1;
        lblEnrollSub.Text = "Nguyễn Minh Anh · TN-0108 · IELTS Foundation · 02/10/2026";
        // 
        // lblEnrollHeader
        // 
        lblEnrollHeader.AutoSize = true;
        lblEnrollHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblEnrollHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblEnrollHeader.Location = new System.Drawing.Point(22, 10);
        lblEnrollHeader.Name = "lblEnrollHeader";
        lblEnrollHeader.Size = new System.Drawing.Size(242, 35);
        lblEnrollHeader.TabIndex = 0;
        lblEnrollHeader.Text = "Ghi danh & xếp lớp";
        // 
        // cardEnrollSummary
        // 
        cardEnrollSummary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardEnrollSummary.BackColor = System.Drawing.Color.White;
        cardEnrollSummary.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardEnrollSummary.BorderWidth = 1;
        cardEnrollSummary.Controls.Add(lblTransNext);
        cardEnrollSummary.Controls.Add(lblTransChecked);
        cardEnrollSummary.Controls.Add(lblTransDuration);
        cardEnrollSummary.Controls.Add(lblTransRoom);
        cardEnrollSummary.Controls.Add(lblTransTeacher);
        cardEnrollSummary.Controls.Add(lblTransNetFee);
        cardEnrollSummary.Controls.Add(lblTransCourse);
        cardEnrollSummary.Controls.Add(lblTransScore);
        cardEnrollSummary.Controls.Add(lblTransPhone);
        cardEnrollSummary.Controls.Add(lblTransName);
        cardEnrollSummary.Controls.Add(lblTransferTitle);
        cardEnrollSummary.CornerRadius = 8;
        cardEnrollSummary.Location = new System.Drawing.Point(715, 95);
        cardEnrollSummary.Name = "cardEnrollSummary";
        cardEnrollSummary.Padding = new System.Windows.Forms.Padding(16);
        cardEnrollSummary.Size = new System.Drawing.Size(400, 560);
        cardEnrollSummary.TabIndex = 2;
        // 
        // lblTransNext
        // 
        lblTransNext.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblTransNext.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblTransNext.Location = new System.Drawing.Point(20, 440);
        lblTransNext.Name = "lblTransNext";
        lblTransNext.Size = new System.Drawing.Size(360, 55);
        lblTransNext.TabIndex = 10;
        lblTransNext.Text = "Bước kế tiếp: tạo hồ sơ học viên → bàn giao kế toán thu học phí.";
        // 
        // lblTransChecked
        // 
        lblTransChecked.AutoSize = true;
        lblTransChecked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTransChecked.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblTransChecked.Location = new System.Drawing.Point(20, 395);
        lblTransChecked.Name = "lblTransChecked";
        lblTransChecked.Size = new System.Drawing.Size(217, 23);
        lblTransChecked.TabIndex = 9;
        lblTransChecked.Text = "✓ Đã kiểm tra trùng hồ sơ";
        // 
        // lblTransDuration
        // 
        lblTransDuration.AutoSize = true;
        lblTransDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransDuration.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransDuration.Location = new System.Drawing.Point(20, 340);
        lblTransDuration.Name = "lblTransDuration";
        lblTransDuration.Size = new System.Drawing.Size(263, 21);
        lblTransDuration.TabIndex = 8;
        lblTransDuration.Text = "Thời gian lớp:  06/10–25/12/2026";
        // 
        // lblTransRoom
        // 
        lblTransRoom.AutoSize = true;
        lblTransRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransRoom.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransRoom.Location = new System.Drawing.Point(20, 300);
        lblTransRoom.Name = "lblTransRoom";
        lblTransRoom.Size = new System.Drawing.Size(248, 21);
        lblTransRoom.TabIndex = 7;
        lblTransRoom.Text = "Phòng / giờ:  P201 · 18:00–20:00";
        // 
        // lblTransTeacher
        // 
        lblTransTeacher.AutoSize = true;
        lblTransTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransTeacher.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransTeacher.Location = new System.Drawing.Point(20, 260);
        lblTransTeacher.Name = "lblTransTeacher";
        lblTransTeacher.Size = new System.Drawing.Size(232, 21);
        lblTransTeacher.TabIndex = 6;
        lblTransTeacher.Text = "Giáo viên:  Nguyễn Hoàng Anh";
        // 
        // lblTransNetFee
        // 
        lblTransNetFee.AutoSize = true;
        lblTransNetFee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTransNetFee.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblTransNetFee.Location = new System.Drawing.Point(20, 215);
        lblTransNetFee.Name = "lblTransNetFee";
        lblTransNetFee.Size = new System.Drawing.Size(237, 25);
        lblTransNetFee.TabIndex = 5;
        lblTransNetFee.Text = "Học phí ròng:  5.400.000đ";
        // 
        // lblTransCourse
        // 
        lblTransCourse.AutoSize = true;
        lblTransCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransCourse.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransCourse.Location = new System.Drawing.Point(20, 175);
        lblTransCourse.Name = "lblTransCourse";
        lblTransCourse.Size = new System.Drawing.Size(209, 21);
        lblTransCourse.TabIndex = 4;
        lblTransCourse.Text = "Khóa học:  IELTS Foundation";
        // 
        // lblTransScore
        // 
        lblTransScore.AutoSize = true;
        lblTransScore.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransScore.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransScore.Location = new System.Drawing.Point(20, 135);
        lblTransScore.Name = "lblTransScore";
        lblTransScore.Size = new System.Drawing.Size(176, 21);
        lblTransScore.TabIndex = 3;
        lblTransScore.Text = "Điểm đầu vào:  4,0 / 10";
        // 
        // lblTransPhone
        // 
        lblTransPhone.AutoSize = true;
        lblTransPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblTransPhone.Location = new System.Drawing.Point(20, 95);
        lblTransPhone.Name = "lblTransPhone";
        lblTransPhone.Size = new System.Drawing.Size(193, 21);
        lblTransPhone.TabIndex = 2;
        lblTransPhone.Text = "Điện thoại:  0908 123 456";
        // 
        // lblTransName
        // 
        lblTransName.AutoSize = true;
        lblTransName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTransName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTransName.Location = new System.Drawing.Point(20, 60);
        lblTransName.Name = "lblTransName";
        lblTransName.Size = new System.Drawing.Size(226, 23);
        lblTransName.TabIndex = 1;
        lblTransName.Text = "Họ và tên:  Nguyễn Minh Anh";
        // 
        // lblTransferTitle
        // 
        lblTransferTitle.AutoSize = true;
        lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTransferTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTransferTitle.Location = new System.Drawing.Point(20, 16);
        lblTransferTitle.Name = "lblTransferTitle";
        lblTransferTitle.Size = new System.Drawing.Size(268, 28);
        lblTransferTitle.TabIndex = 0;
        lblTransferTitle.Text = "Thông tin được chuyển tiếp";
        // 
        // cardClassSelect
        // 
        cardClassSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardClassSelect.BackColor = System.Drawing.Color.White;
        cardClassSelect.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardClassSelect.BorderWidth = 1;
        cardClassSelect.Controls.Add(btnConfirmEnroll);
        cardClassSelect.Controls.Add(btnBackToConsult);
        cardClassSelect.Controls.Add(bannerEnrollPlan);
        cardClassSelect.Controls.Add(txtEnrollDiscount);
        cardClassSelect.Controls.Add(lblEnrollDiscount);
        cardClassSelect.Controls.Add(txtEnrollOriginalFee);
        cardClassSelect.Controls.Add(lblEnrollOriginalFee);
        cardClassSelect.Controls.Add(cboSubstituteClass);
        cardClassSelect.Controls.Add(lblSubstituteClass);
        cardClassSelect.Controls.Add(dtpEnrollDate);
        cardClassSelect.Controls.Add(lblEnrollDate);
        cardClassSelect.Controls.Add(dgvClasses);
        cardClassSelect.Controls.Add(bannerClassFull);
        cardClassSelect.Controls.Add(lblClassSelectTitle);
        cardClassSelect.CornerRadius = 8;
        cardClassSelect.Location = new System.Drawing.Point(24, 95);
        cardClassSelect.Name = "cardClassSelect";
        cardClassSelect.Padding = new System.Windows.Forms.Padding(16);
        cardClassSelect.Size = new System.Drawing.Size(670, 560);
        cardClassSelect.TabIndex = 1;
        // 
        // btnConfirmEnroll
        // 
        btnConfirmEnroll.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnConfirmEnroll.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnConfirmEnroll.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmEnroll.CornerRadius = 6;
        btnConfirmEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmEnroll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmEnroll.ForeColor = System.Drawing.Color.White;
        btnConfirmEnroll.Location = new System.Drawing.Point(495, 500);
        btnConfirmEnroll.Name = "btnConfirmEnroll";
        btnConfirmEnroll.Size = new System.Drawing.Size(155, 36);
        btnConfirmEnroll.TabIndex = 13;
        btnConfirmEnroll.Text = "Xác nhận ghi danh";
        btnConfirmEnroll.UseVisualStyleBackColor = false;
        // 
        // btnBackToConsult
        // 
        btnBackToConsult.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnBackToConsult.BackColor = System.Drawing.Color.White;
        btnBackToConsult.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToConsult.CornerRadius = 6;
        btnBackToConsult.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToConsult.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackToConsult.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnBackToConsult.Location = new System.Drawing.Point(360, 500);
        btnBackToConsult.Name = "btnBackToConsult";
        btnBackToConsult.Size = new System.Drawing.Size(125, 36);
        btnBackToConsult.TabIndex = 12;
        btnBackToConsult.Text = "Quay lại tư vấn";
        btnBackToConsult.UseVisualStyleBackColor = false;
        // 
        // bannerEnrollPlan
        // 
        bannerEnrollPlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerEnrollPlan.BannerType = ECMS.UI.Controls.BannerType.Info;
        bannerEnrollPlan.Location = new System.Drawing.Point(20, 425);
        bannerEnrollPlan.Message = "Đã chọn phương án thay thế IELTS-F01. Xác nhận để tạo HV-0241 và tăng sĩ số thành 18/20.";
        bannerEnrollPlan.Name = "bannerEnrollPlan";
        bannerEnrollPlan.Size = new System.Drawing.Size(630, 55);
        bannerEnrollPlan.TabIndex = 11;
        bannerEnrollPlan.Title = "Thông báo:";
        bannerEnrollPlan.Variant = ECMS.UI.Controls.BannerVariant.Info;
        // 
        // txtEnrollDiscount
        // 
        txtEnrollDiscount.BackColor = System.Drawing.Color.Transparent;
        txtEnrollDiscount.CornerRadius = 6;
        txtEnrollDiscount.ErrorMessage = "";
        txtEnrollDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEnrollDiscount.HasError = false;
        txtEnrollDiscount.Location = new System.Drawing.Point(340, 365);
        txtEnrollDiscount.Name = "txtEnrollDiscount";
        txtEnrollDiscount.Placeholder = "600.000đ";
        txtEnrollDiscount.ReadOnly = true;
        txtEnrollDiscount.Size = new System.Drawing.Size(305, 32);
        txtEnrollDiscount.TabIndex = 10;
        txtEnrollDiscount.UseSystemPasswordChar = false;
        // 
        // lblEnrollDiscount
        // 
        lblEnrollDiscount.AutoSize = true;
        lblEnrollDiscount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollDiscount.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblEnrollDiscount.Location = new System.Drawing.Point(340, 342);
        lblEnrollDiscount.Name = "lblEnrollDiscount";
        lblEnrollDiscount.Size = new System.Drawing.Size(95, 19);
        lblEnrollDiscount.TabIndex = 9;
        lblEnrollDiscount.Text = "Ưu đãi 10%";
        // 
        // txtEnrollOriginalFee
        // 
        txtEnrollOriginalFee.BackColor = System.Drawing.Color.Transparent;
        txtEnrollOriginalFee.CornerRadius = 6;
        txtEnrollOriginalFee.ErrorMessage = "";
        txtEnrollOriginalFee.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEnrollOriginalFee.HasError = false;
        txtEnrollOriginalFee.Location = new System.Drawing.Point(20, 365);
        txtEnrollOriginalFee.Name = "txtEnrollOriginalFee";
        txtEnrollOriginalFee.Placeholder = "6.000.000đ";
        txtEnrollOriginalFee.ReadOnly = true;
        txtEnrollOriginalFee.Size = new System.Drawing.Size(300, 32);
        txtEnrollOriginalFee.TabIndex = 8;
        txtEnrollOriginalFee.UseSystemPasswordChar = false;
        // 
        // lblEnrollOriginalFee
        // 
        lblEnrollOriginalFee.AutoSize = true;
        lblEnrollOriginalFee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollOriginalFee.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblEnrollOriginalFee.Location = new System.Drawing.Point(20, 342);
        lblEnrollOriginalFee.Name = "lblEnrollOriginalFee";
        lblEnrollOriginalFee.Size = new System.Drawing.Size(92, 19);
        lblEnrollOriginalFee.TabIndex = 7;
        lblEnrollOriginalFee.Text = "Học phí gốc";
        // 
        // cboSubstituteClass
        // 
        cboSubstituteClass.BackColor = System.Drawing.Color.White;
        cboSubstituteClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboSubstituteClass.Location = new System.Drawing.Point(340, 290);
        cboSubstituteClass.Name = "cboSubstituteClass";
        cboSubstituteClass.Size = new System.Drawing.Size(305, 32);
        cboSubstituteClass.TabIndex = 6;
        // 
        // lblSubstituteClass
        // 
        lblSubstituteClass.AutoSize = true;
        lblSubstituteClass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblSubstituteClass.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblSubstituteClass.Location = new System.Drawing.Point(340, 267);
        lblSubstituteClass.Name = "lblSubstituteClass";
        lblSubstituteClass.Size = new System.Drawing.Size(107, 19);
        lblSubstituteClass.TabIndex = 5;
        lblSubstituteClass.Text = "Lớp thay thế *";
        // 
        // dtpEnrollDate
        // 
        dtpEnrollDate.CustomFormat = "dd/MM/yyyy";
        dtpEnrollDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEnrollDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEnrollDate.Location = new System.Drawing.Point(20, 290);
        dtpEnrollDate.Name = "dtpEnrollDate";
        dtpEnrollDate.Size = new System.Drawing.Size(300, 29);
        dtpEnrollDate.TabIndex = 4;
        // 
        // lblEnrollDate
        // 
        lblEnrollDate.AutoSize = true;
        lblEnrollDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollDate.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblEnrollDate.Location = new System.Drawing.Point(20, 267);
        lblEnrollDate.Name = "lblEnrollDate";
        lblEnrollDate.Size = new System.Drawing.Size(117, 19);
        lblEnrollDate.TabIndex = 3;
        lblEnrollDate.Text = "Ngày ghi danh *";
        // 
        // dgvClasses
        // 
        dgvClasses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvClasses.Location = new System.Drawing.Point(20, 115);
        dgvClasses.Name = "dgvClasses";
        dgvClasses.Size = new System.Drawing.Size(630, 135);
        dgvClasses.TabIndex = 2;
        // 
        // bannerClassFull
        // 
        bannerClassFull.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerClassFull.BannerType = ECMS.UI.Controls.BannerType.Danger;
        bannerClassFull.Location = new System.Drawing.Point(20, 50);
        bannerClassFull.Message = "IELTS-F03 đã đủ 20/20 học viên. Không thể ghi danh. Chọn IELTS-F01 còn 3 chỗ.";
        bannerClassFull.Name = "bannerClassFull";
        bannerClassFull.Size = new System.Drawing.Size(630, 50);
        bannerClassFull.TabIndex = 1;
        bannerClassFull.Title = "✕ Lớp đã đầy:";
        bannerClassFull.Variant = ECMS.UI.Controls.BannerVariant.Danger;
        // 
        // lblClassSelectTitle
        // 
        lblClassSelectTitle.AutoSize = true;
        lblClassSelectTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblClassSelectTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblClassSelectTitle.Location = new System.Drawing.Point(20, 16);
        lblClassSelectTitle.Name = "lblClassSelectTitle";
        lblClassSelectTitle.Size = new System.Drawing.Size(193, 28);
        lblClassSelectTitle.TabIndex = 0;
        lblClassSelectTitle.Text = "Chọn lớp học cụ thể";
        // 
        // EnrollmentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(cardEnrollSummary);
        Controls.Add(cardClassSelect);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EnrollmentDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Ghi danh & xếp lớp — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardEnrollSummary.ResumeLayout(false);
        cardEnrollSummary.PerformLayout();
        cardClassSelect.ResumeLayout(false);
        cardClassSelect.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblEnrollHeader;
    private System.Windows.Forms.Label lblEnrollSub;

    private ECMS.UI.Controls.AppCard cardClassSelect;
    private System.Windows.Forms.Label lblClassSelectTitle;
    private ECMS.UI.Controls.AppBanner bannerClassFull;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Label lblEnrollDate;
    private System.Windows.Forms.DateTimePicker dtpEnrollDate;
    private System.Windows.Forms.Label lblSubstituteClass;
    private ECMS.UI.Controls.AppComboBox cboSubstituteClass;
    private System.Windows.Forms.Label lblEnrollOriginalFee;
    private ECMS.UI.Controls.AppTextBox txtEnrollOriginalFee;
    private System.Windows.Forms.Label lblEnrollDiscount;
    private ECMS.UI.Controls.AppTextBox txtEnrollDiscount;
    private ECMS.UI.Controls.AppBanner bannerEnrollPlan;
    private ECMS.UI.Controls.AppButton btnBackToConsult;
    private ECMS.UI.Controls.AppButton btnConfirmEnroll;

    private ECMS.UI.Controls.AppCard cardEnrollSummary;
    private System.Windows.Forms.Label lblTransferTitle;
    private System.Windows.Forms.Label lblTransName;
    private System.Windows.Forms.Label lblTransPhone;
    private System.Windows.Forms.Label lblTransScore;
    private System.Windows.Forms.Label lblTransCourse;
    private System.Windows.Forms.Label lblTransNetFee;
    private System.Windows.Forms.Label lblTransTeacher;
    private System.Windows.Forms.Label lblTransRoom;
    private System.Windows.Forms.Label lblTransDuration;
    private System.Windows.Forms.Label lblTransChecked;
    private System.Windows.Forms.Label lblTransNext;
}
