namespace ECMS.UI.Forms;

partial class CreateScheduleDialog
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
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardConflict = new ECMS.UI.Controls.AppCard();
        btnSaveSchedule = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        btnRecheck = new ECMS.UI.Controls.AppButton();
        btnSelectRoom201 = new ECMS.UI.Controls.AppButton();
        btnChangeSchedule = new ECMS.UI.Controls.AppButton();
        bannerConflict = new ECMS.UI.Controls.AppBanner();
        dgvConflicts = new ECMS.UI.Controls.AppDataGrid();
        lblConflictTeacherRoom = new System.Windows.Forms.Label();
        lblConflictProposed = new System.Windows.Forms.Label();
        lblConflictTitle = new System.Windows.Forms.Label();
        cardForm = new ECMS.UI.Controls.AppCard();
        btnCheckAndSave = new ECMS.UI.Controls.AppButton();
        btnCancelForm = new ECMS.UI.Controls.AppButton();
        txtStartTime = new ECMS.UI.Controls.AppTextBox();
        lblStartTime = new System.Windows.Forms.Label();
        dtpStartDate = new System.Windows.Forms.DateTimePicker();
        lblStartDate = new System.Windows.Forms.Label();
        cboRoom = new ECMS.UI.Controls.AppComboBox();
        lblRoom = new System.Windows.Forms.Label();
        cboClass = new ECMS.UI.Controls.AppComboBox();
        lblClass = new System.Windows.Forms.Label();
        lblFormTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardConflict.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConflicts).BeginInit();
        cardForm.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
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
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(232, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Dữ liệu mẫu · Trung tâm Anh ngữ Minh Trí";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(238, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tạo lịch học định kỳ";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(262, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lịch học & Phòng học / Tạo lịch học định kỳ";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardConflict);
        pnlBody.Controls.Add(cardForm);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardConflict
        // 
        cardConflict.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardConflict.BackColor = System.Drawing.Color.White;
        cardConflict.Controls.Add(btnSaveSchedule);
        cardConflict.Controls.Add(btnCancel);
        cardConflict.Controls.Add(btnRecheck);
        cardConflict.Controls.Add(btnSelectRoom201);
        cardConflict.Controls.Add(btnChangeSchedule);
        cardConflict.Controls.Add(bannerConflict);
        cardConflict.Controls.Add(dgvConflicts);
        cardConflict.Controls.Add(lblConflictTeacherRoom);
        cardConflict.Controls.Add(lblConflictProposed);
        cardConflict.Controls.Add(lblConflictTitle);
        cardConflict.Location = new System.Drawing.Point(490, 24);
        cardConflict.Name = "cardConflict";
        cardConflict.Padding = new System.Windows.Forms.Padding(24);
        cardConflict.Size = new System.Drawing.Size(706, 560);
        cardConflict.TabIndex = 1;
        // 
        // btnSaveSchedule
        // 
        btnSaveSchedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSaveSchedule.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnSaveSchedule.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnSaveSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveSchedule.ForeColor = System.Drawing.Color.White;
        btnSaveSchedule.Location = new System.Drawing.Point(576, 500);
        btnSaveSchedule.Name = "btnSaveSchedule";
        btnSaveSchedule.Size = new System.Drawing.Size(106, 36);
        btnSaveSchedule.TabIndex = 9;
        btnSaveSchedule.Text = "Lưu lịch";
        btnSaveSchedule.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancel.Location = new System.Drawing.Point(485, 500);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(85, 36);
        btnCancel.TabIndex = 8;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // btnRecheck
        // 
        btnRecheck.BackColor = System.Drawing.Color.White;
        btnRecheck.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnRecheck.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnRecheck.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnRecheck.Location = new System.Drawing.Point(310, 440);
        btnRecheck.Name = "btnRecheck";
        btnRecheck.Size = new System.Drawing.Size(110, 32);
        btnRecheck.TabIndex = 7;
        btnRecheck.Text = "Kiểm tra lại";
        btnRecheck.UseVisualStyleBackColor = false;
        // 
        // btnSelectRoom201
        // 
        btnSelectRoom201.BackColor = System.Drawing.Color.White;
        btnSelectRoom201.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnSelectRoom201.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnSelectRoom201.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnSelectRoom201.Location = new System.Drawing.Point(145, 440);
        btnSelectRoom201.Name = "btnSelectRoom201";
        btnSelectRoom201.Size = new System.Drawing.Size(155, 32);
        btnSelectRoom201.TabIndex = 6;
        btnSelectRoom201.Text = "Chọn P201 · 24 chỗ";
        btnSelectRoom201.UseVisualStyleBackColor = false;
        // 
        // btnChangeSchedule
        // 
        btnChangeSchedule.BackColor = System.Drawing.Color.White;
        btnChangeSchedule.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnChangeSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnChangeSchedule.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnChangeSchedule.Location = new System.Drawing.Point(24, 440);
        btnChangeSchedule.Name = "btnChangeSchedule";
        btnChangeSchedule.Size = new System.Drawing.Size(115, 32);
        btnChangeSchedule.TabIndex = 5;
        btnChangeSchedule.Text = "Đổi ngày / giờ";
        btnChangeSchedule.UseVisualStyleBackColor = false;
        // 
        // bannerConflict
        // 
        bannerConflict.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerConflict.Variant = ECMS.UI.Controls.BannerVariant.Danger;
        bannerConflict.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerConflict.Location = new System.Drawing.Point(24, 370);
        bannerConflict.Message = "Không bản ghi nào được lưu. Thay đổi lịch và kiểm tra lại trước khi xác nhận.";
        bannerConflict.Name = "bannerConflict";
        bannerConflict.Size = new System.Drawing.Size(658, 48);
        bannerConflict.TabIndex = 4;
        // 
        // dgvConflicts
        // 
        dgvConflicts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvConflicts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvConflicts.Location = new System.Drawing.Point(24, 115);
        dgvConflicts.Name = "dgvConflicts";
        dgvConflicts.Size = new System.Drawing.Size(658, 240);
        dgvConflicts.TabIndex = 3;
        // 
        // lblConflictTeacherRoom
        // 
        lblConflictTeacherRoom.AutoSize = true;
        lblConflictTeacherRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblConflictTeacherRoom.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblConflictTeacherRoom.Location = new System.Drawing.Point(24, 82);
        lblConflictTeacherRoom.Name = "lblConflictTeacherRoom";
        lblConflictTeacherRoom.Size = new System.Drawing.Size(306, 15);
        lblConflictTeacherRoom.TabIndex = 2;
        lblConflictTeacherRoom.Text = "Giáo viên / phòng:  Nguyễn Hoàng Anh / P203 (18 chỗ)";
        // 
        // lblConflictProposed
        // 
        lblConflictProposed.AutoSize = true;
        lblConflictProposed.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblConflictProposed.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblConflictProposed.Location = new System.Drawing.Point(24, 58);
        lblConflictProposed.Name = "lblConflictProposed";
        lblConflictProposed.Size = new System.Drawing.Size(286, 15);
        lblConflictProposed.TabIndex = 1;
        lblConflictProposed.Text = "Lịch đề xuất:  IELTS-F04 · 06/11/2026 · 18:00–20:00";
        // 
        // lblConflictTitle
        // 
        lblConflictTitle.AutoSize = true;
        lblConflictTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblConflictTitle.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        lblConflictTitle.Location = new System.Drawing.Point(24, 20);
        lblConflictTitle.Name = "lblConflictTitle";
        lblConflictTitle.Size = new System.Drawing.Size(360, 21);
        lblConflictTitle.TabIndex = 0;
        lblConflictTitle.Text = "Không thể lưu lịch — cần xử lý 4 xung đột  ✖";
        // 
        // cardForm
        // 
        cardForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.Controls.Add(btnCheckAndSave);
        cardForm.Controls.Add(btnCancelForm);
        cardForm.Controls.Add(txtStartTime);
        cardForm.Controls.Add(lblStartTime);
        cardForm.Controls.Add(dtpStartDate);
        cardForm.Controls.Add(lblStartDate);
        cardForm.Controls.Add(cboRoom);
        cardForm.Controls.Add(lblRoom);
        cardForm.Controls.Add(cboClass);
        cardForm.Controls.Add(lblClass);
        cardForm.Controls.Add(lblFormTitle);
        cardForm.Location = new System.Drawing.Point(24, 24);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(24);
        cardForm.Size = new System.Drawing.Size(445, 560);
        cardForm.TabIndex = 0;
        // 
        // btnCheckAndSave
        // 
        btnCheckAndSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCheckAndSave.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCheckAndSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnCheckAndSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCheckAndSave.ForeColor = System.Drawing.Color.White;
        btnCheckAndSave.Location = new System.Drawing.Point(300, 500);
        btnCheckAndSave.Name = "btnCheckAndSave";
        btnCheckAndSave.Size = new System.Drawing.Size(121, 36);
        btnCheckAndSave.TabIndex = 10;
        btnCheckAndSave.Text = "Kiểm tra & lưu";
        btnCheckAndSave.UseVisualStyleBackColor = false;
        // 
        // btnCancelForm
        // 
        btnCancelForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelForm.BackColor = System.Drawing.Color.White;
        btnCancelForm.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancelForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelForm.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancelForm.Location = new System.Drawing.Point(215, 500);
        btnCancelForm.Name = "btnCancelForm";
        btnCancelForm.Size = new System.Drawing.Size(75, 36);
        btnCancelForm.TabIndex = 9;
        btnCancelForm.Text = "Hủy";
        btnCancelForm.UseVisualStyleBackColor = false;
        // 
        // txtStartTime
        // 
        txtStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtStartTime.Location = new System.Drawing.Point(24, 305);
        txtStartTime.Name = "txtStartTime";
        txtStartTime.Placeholder = "Ví dụ: 18:00";
        txtStartTime.Size = new System.Drawing.Size(397, 35);
        txtStartTime.TabIndex = 8;
        // 
        // lblStartTime
        // 
        lblStartTime.AutoSize = true;
        lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStartTime.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblStartTime.Location = new System.Drawing.Point(24, 285);
        lblStartTime.Name = "lblStartTime";
        lblStartTime.Size = new System.Drawing.Size(81, 15);
        lblStartTime.TabIndex = 7;
        lblStartTime.Text = "Giờ bắt đầu *";
        // 
        // dtpStartDate
        // 
        dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dtpStartDate.CustomFormat = "dd/MM/yyyy";
        dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpStartDate.Location = new System.Drawing.Point(24, 225);
        dtpStartDate.Name = "dtpStartDate";
        dtpStartDate.Size = new System.Drawing.Size(397, 24);
        dtpStartDate.TabIndex = 6;
        // 
        // lblStartDate
        // 
        lblStartDate.AutoSize = true;
        lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStartDate.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblStartDate.Location = new System.Drawing.Point(24, 205);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new System.Drawing.Size(90, 15);
        lblStartDate.TabIndex = 5;
        lblStartDate.Text = "Ngày bắt đầu *";
        // 
        // cboRoom
        // 
        cboRoom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboRoom.Location = new System.Drawing.Point(24, 145);
        cboRoom.Name = "cboRoom";
        cboRoom.Size = new System.Drawing.Size(397, 35);
        cboRoom.TabIndex = 4;
        // 
        // lblRoom
        // 
        lblRoom.AutoSize = true;
        lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoom.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoom.Location = new System.Drawing.Point(24, 125);
        lblRoom.Name = "lblRoom";
        lblRoom.Size = new System.Drawing.Size(77, 15);
        lblRoom.TabIndex = 3;
        lblRoom.Text = "Phòng học *";
        // 
        // cboClass
        // 
        cboClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboClass.Location = new System.Drawing.Point(24, 68);
        cboClass.Name = "cboClass";
        cboClass.Size = new System.Drawing.Size(397, 35);
        cboClass.TabIndex = 2;
        // 
        // lblClass
        // 
        lblClass.AutoSize = true;
        lblClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClass.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblClass.Location = new System.Drawing.Point(24, 48);
        lblClass.Name = "lblClass";
        lblClass.Size = new System.Drawing.Size(61, 15);
        lblClass.TabIndex = 1;
        lblClass.Text = "Lớp học *";
        // 
        // lblFormTitle
        // 
        lblFormTitle.AutoSize = true;
        lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblFormTitle.Location = new System.Drawing.Point(24, 16);
        lblFormTitle.Name = "lblFormTitle";
        lblFormTitle.Size = new System.Drawing.Size(153, 21);
        lblFormTitle.TabIndex = 0;
        lblFormTitle.Text = "Thông tin buổi học";
        // 
        // CreateScheduleDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CreateScheduleDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tạo lịch học định kỳ · Xử lý xung đột";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardConflict.ResumeLayout(false);
        cardConflict.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConflicts).EndInit();
        cardForm.ResumeLayout(false);
        cardForm.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardForm;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblClass;
    private ECMS.UI.Controls.AppComboBox cboClass;
    private System.Windows.Forms.Label lblRoom;
    private ECMS.UI.Controls.AppComboBox cboRoom;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.Label lblStartTime;
    private ECMS.UI.Controls.AppTextBox txtStartTime;
    private ECMS.UI.Controls.AppButton btnCancelForm;
    private ECMS.UI.Controls.AppButton btnCheckAndSave;
    private ECMS.UI.Controls.AppCard cardConflict;
    private System.Windows.Forms.Label lblConflictTitle;
    private System.Windows.Forms.Label lblConflictProposed;
    private System.Windows.Forms.Label lblConflictTeacherRoom;
    private ECMS.UI.Controls.AppDataGrid dgvConflicts;
    private ECMS.UI.Controls.AppBanner bannerConflict;
    private ECMS.UI.Controls.AppButton btnChangeSchedule;
    private ECMS.UI.Controls.AppButton btnSelectRoom201;
    private ECMS.UI.Controls.AppButton btnRecheck;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSaveSchedule;
}
