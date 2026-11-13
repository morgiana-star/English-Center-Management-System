namespace ECMS.UI.Forms;

partial class ScheduleSavedDialog
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
        btnViewSessionList = new ECMS.UI.Controls.AppButton();
        btnBackToCalendar = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardFirstSessions = new ECMS.UI.Controls.AppCard();
        lblFlowNoteSub = new System.Windows.Forms.Label();
        lblFlowNoteTitle = new System.Windows.Forms.Label();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvFirstSessions = new ECMS.UI.Controls.AppDataGrid();
        lblSessionsTitle = new System.Windows.Forms.Label();
        cardAdjustedSchedule = new ECMS.UI.Controls.AppCard();
        dgvChecklist = new ECMS.UI.Controls.AppDataGrid();
        lblPendingTransferVal = new System.Windows.Forms.Label();
        lblPendingTransferKey = new System.Windows.Forms.Label();
        lblDateRangeVal = new System.Windows.Forms.Label();
        lblDateRangeKey = new System.Windows.Forms.Label();
        lblRoomVal = new System.Windows.Forms.Label();
        lblRoomKey = new System.Windows.Forms.Label();
        lblTimeVal = new System.Windows.Forms.Label();
        lblTimeKey = new System.Windows.Forms.Label();
        lblDaysVal = new System.Windows.Forms.Label();
        lblDaysKey = new System.Windows.Forms.Label();
        lblTeacherVal = new System.Windows.Forms.Label();
        lblTeacherKey = new System.Windows.Forms.Label();
        lblCourseClassVal = new System.Windows.Forms.Label();
        lblCourseClassKey = new System.Windows.Forms.Label();
        lblAdjustedTitle = new System.Windows.Forms.Label();
        bannerSavedSuccess = new ECMS.UI.Controls.AppBanner();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardFirstSessions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFirstSessions).BeginInit();
        cardAdjustedSchedule.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChecklist).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnViewSessionList);
        pnlHeader.Controls.Add(btnBackToCalendar);
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
        // btnViewSessionList
        // 
        btnViewSessionList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnViewSessionList.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnViewSessionList.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnViewSessionList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewSessionList.ForeColor = System.Drawing.Color.White;
        btnViewSessionList.Location = new System.Drawing.Point(1035, 20);
        btnViewSessionList.Name = "btnViewSessionList";
        btnViewSessionList.Size = new System.Drawing.Size(161, 36);
        btnViewSessionList.TabIndex = 4;
        btnViewSessionList.Text = "Xem danh sách buổi";
        btnViewSessionList.UseVisualStyleBackColor = false;
        // 
        // btnBackToCalendar
        // 
        btnBackToCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnBackToCalendar.BackColor = System.Drawing.Color.White;
        btnBackToCalendar.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnBackToCalendar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnBackToCalendar.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnBackToCalendar.Location = new System.Drawing.Point(920, 20);
        btnBackToCalendar.Name = "btnBackToCalendar";
        btnBackToCalendar.Size = new System.Drawing.Size(105, 36);
        btnBackToCalendar.TabIndex = 3;
        btnBackToCalendar.Text = "Về lịch tuần";
        btnBackToCalendar.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(325, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "IELTS-F04 · 02/11/2026–21/01/2027 · 24 buổi dự kiến";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(202, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lịch học đã được lưu";
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
        lblBreadcrumb.Text = "ECMS / Lịch học & Phòng học / Lịch học đã được lưu";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardFirstSessions);
        pnlBody.Controls.Add(cardAdjustedSchedule);
        pnlBody.Controls.Add(bannerSavedSuccess);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardFirstSessions
        // 
        cardFirstSessions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardFirstSessions.BackColor = System.Drawing.Color.White;
        cardFirstSessions.Controls.Add(lblFlowNoteSub);
        cardFirstSessions.Controls.Add(lblFlowNoteTitle);
        cardFirstSessions.Controls.Add(lblPagingNav);
        cardFirstSessions.Controls.Add(lblPagingInfo);
        cardFirstSessions.Controls.Add(dgvFirstSessions);
        cardFirstSessions.Controls.Add(lblSessionsTitle);
        cardFirstSessions.Location = new System.Drawing.Point(620, 80);
        cardFirstSessions.Name = "cardFirstSessions";
        cardFirstSessions.Padding = new System.Windows.Forms.Padding(20);
        cardFirstSessions.Size = new System.Drawing.Size(576, 520);
        cardFirstSessions.TabIndex = 2;
        // 
        // lblFlowNoteSub
        // 
        lblFlowNoteSub.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblFlowNoteSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFlowNoteSub.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblFlowNoteSub.Location = new System.Drawing.Point(20, 465);
        lblFlowNoteSub.Name = "lblFlowNoteSub";
        lblFlowNoteSub.Size = new System.Drawing.Size(536, 35);
        lblFlowNoteSub.TabIndex = 5;
        lblFlowNoteSub.Text = "Lớp vẫn ở bản nháp. Quay về 03.4 để ghi danh học viên và mở lớp trước khi điểm danh.";
        // 
        // lblFlowNoteTitle
        // 
        lblFlowNoteTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblFlowNoteTitle.AutoSize = true;
        lblFlowNoteTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblFlowNoteTitle.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
        lblFlowNoteTitle.Location = new System.Drawing.Point(20, 440);
        lblFlowNoteTitle.Name = "lblFlowNoteTitle";
        lblFlowNoteTitle.Size = new System.Drawing.Size(117, 17);
        lblFlowNoteTitle.TabIndex = 4;
        lblFlowNoteTitle.Text = "✓ Hoàn tất luồng 04";
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(434, 395);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 395);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(107, 15);
        lblPagingInfo.TabIndex = 2;
        lblPagingInfo.Text = "1–4 / 24 buổi đã tạo";
        // 
        // dgvFirstSessions
        // 
        dgvFirstSessions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvFirstSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvFirstSessions.Location = new System.Drawing.Point(20, 55);
        dgvFirstSessions.Name = "dgvFirstSessions";
        dgvFirstSessions.Size = new System.Drawing.Size(536, 325);
        dgvFirstSessions.TabIndex = 1;
        // 
        // lblSessionsTitle
        // 
        lblSessionsTitle.AutoSize = true;
        lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblSessionsTitle.Location = new System.Drawing.Point(20, 16);
        lblSessionsTitle.Name = "lblSessionsTitle";
        lblSessionsTitle.Size = new System.Drawing.Size(183, 21);
        lblSessionsTitle.TabIndex = 0;
        lblSessionsTitle.Text = "Các buổi học đầu tiên";
        // 
        // cardAdjustedSchedule
        // 
        cardAdjustedSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardAdjustedSchedule.BackColor = System.Drawing.Color.White;
        cardAdjustedSchedule.Controls.Add(dgvChecklist);
        cardAdjustedSchedule.Controls.Add(lblPendingTransferVal);
        cardAdjustedSchedule.Controls.Add(lblPendingTransferKey);
        cardAdjustedSchedule.Controls.Add(lblDateRangeVal);
        cardAdjustedSchedule.Controls.Add(lblDateRangeKey);
        cardAdjustedSchedule.Controls.Add(lblRoomVal);
        cardAdjustedSchedule.Controls.Add(lblRoomKey);
        cardAdjustedSchedule.Controls.Add(lblTimeVal);
        cardAdjustedSchedule.Controls.Add(lblTimeKey);
        cardAdjustedSchedule.Controls.Add(lblDaysVal);
        cardAdjustedSchedule.Controls.Add(lblDaysKey);
        cardAdjustedSchedule.Controls.Add(lblTeacherVal);
        cardAdjustedSchedule.Controls.Add(lblTeacherKey);
        cardAdjustedSchedule.Controls.Add(lblCourseClassVal);
        cardAdjustedSchedule.Controls.Add(lblCourseClassKey);
        cardAdjustedSchedule.Controls.Add(lblAdjustedTitle);
        cardAdjustedSchedule.Location = new System.Drawing.Point(24, 80);
        cardAdjustedSchedule.Name = "cardAdjustedSchedule";
        cardAdjustedSchedule.Padding = new System.Windows.Forms.Padding(20);
        cardAdjustedSchedule.Size = new System.Drawing.Size(576, 520);
        cardAdjustedSchedule.TabIndex = 1;
        // 
        // dgvChecklist
        // 
        dgvChecklist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChecklist.Location = new System.Drawing.Point(20, 310);
        dgvChecklist.Name = "dgvChecklist";
        dgvChecklist.Size = new System.Drawing.Size(536, 190);
        dgvChecklist.TabIndex = 15;
        // 
        // lblPendingTransferVal
        // 
        lblPendingTransferVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPendingTransferVal.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblPendingTransferVal.Location = new System.Drawing.Point(160, 262);
        lblPendingTransferVal.Name = "lblPendingTransferVal";
        lblPendingTransferVal.Size = new System.Drawing.Size(396, 20);
        lblPendingTransferVal.TabIndex = 14;
        lblPendingTransferVal.Text = "Chưa xác nhận; chờ mở lớp F04";
        // 
        // lblPendingTransferKey
        // 
        lblPendingTransferKey.AutoSize = true;
        lblPendingTransferKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPendingTransferKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPendingTransferKey.Location = new System.Drawing.Point(20, 262);
        lblPendingTransferKey.Name = "lblPendingTransferKey";
        lblPendingTransferKey.Size = new System.Drawing.Size(107, 15);
        lblPendingTransferKey.TabIndex = 13;
        lblPendingTransferKey.Text = "Học viên chuyển";
        // 
        // lblDateRangeVal
        // 
        lblDateRangeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDateRangeVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblDateRangeVal.Location = new System.Drawing.Point(160, 227);
        lblDateRangeVal.Name = "lblDateRangeVal";
        lblDateRangeVal.Size = new System.Drawing.Size(396, 20);
        lblDateRangeVal.TabIndex = 12;
        lblDateRangeVal.Text = "02/11/2026 – 21/01/2027";
        // 
        // lblDateRangeKey
        // 
        lblDateRangeKey.AutoSize = true;
        lblDateRangeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDateRangeKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblDateRangeKey.Location = new System.Drawing.Point(20, 227);
        lblDateRangeKey.Name = "lblDateRangeKey";
        lblDateRangeKey.Size = new System.Drawing.Size(78, 15);
        lblDateRangeKey.TabIndex = 11;
        lblDateRangeKey.Text = "Lập từ – đến";
        // 
        // lblRoomVal
        // 
        lblRoomVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblRoomVal.Location = new System.Drawing.Point(160, 192);
        lblRoomVal.Name = "lblRoomVal";
        lblRoomVal.Size = new System.Drawing.Size(396, 20);
        lblRoomVal.TabIndex = 10;
        lblRoomVal.Text = "P201 · 24 chỗ / lớp tối đa 20";
        // 
        // lblRoomKey
        // 
        lblRoomKey.AutoSize = true;
        lblRoomKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblRoomKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblRoomKey.Location = new System.Drawing.Point(20, 192);
        lblRoomKey.Name = "lblRoomKey";
        lblRoomKey.Size = new System.Drawing.Size(42, 15);
        lblRoomKey.TabIndex = 9;
        lblRoomKey.Text = "Phòng";
        // 
        // lblTimeVal
        // 
        lblTimeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTimeVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTimeVal.Location = new System.Drawing.Point(160, 157);
        lblTimeVal.Name = "lblTimeVal";
        lblTimeVal.Size = new System.Drawing.Size(396, 20);
        lblTimeVal.TabIndex = 8;
        lblTimeVal.Text = "18:00–20:00";
        // 
        // lblTimeKey
        // 
        lblTimeKey.AutoSize = true;
        lblTimeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTimeKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTimeKey.Location = new System.Drawing.Point(20, 157);
        lblTimeKey.Name = "lblTimeKey";
        lblTimeKey.Size = new System.Drawing.Size(51, 15);
        lblTimeKey.TabIndex = 7;
        lblTimeKey.Text = "Giờ học";
        // 
        // lblDaysVal
        // 
        lblDaysVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDaysVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblDaysVal.Location = new System.Drawing.Point(160, 122);
        lblDaysVal.Name = "lblDaysVal";
        lblDaysVal.Size = new System.Drawing.Size(396, 20);
        lblDaysVal.TabIndex = 6;
        lblDaysVal.Text = "Thứ Hai / Thứ Năm";
        // 
        // lblDaysKey
        // 
        lblDaysKey.AutoSize = true;
        lblDaysKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDaysKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblDaysKey.Location = new System.Drawing.Point(20, 122);
        lblDaysKey.Name = "lblDaysKey";
        lblDaysKey.Size = new System.Drawing.Size(58, 15);
        lblDaysKey.TabIndex = 5;
        lblDaysKey.Text = "Ngày học";
        // 
        // lblTeacherVal
        // 
        lblTeacherVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTeacherVal.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblTeacherVal.Location = new System.Drawing.Point(160, 87);
        lblTeacherVal.Name = "lblTeacherVal";
        lblTeacherVal.Size = new System.Drawing.Size(396, 20);
        lblTeacherVal.TabIndex = 4;
        lblTeacherVal.Text = "Nguyễn Hoàng Anh";
        // 
        // lblTeacherKey
        // 
        lblTeacherKey.AutoSize = true;
        lblTeacherKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTeacherKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTeacherKey.Location = new System.Drawing.Point(20, 87);
        lblTeacherKey.Name = "lblTeacherKey";
        lblTeacherKey.Size = new System.Drawing.Size(57, 15);
        lblTeacherKey.TabIndex = 3;
        lblTeacherKey.Text = "Giáo viên";
        // 
        // lblCourseClassVal
        // 
        lblCourseClassVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCourseClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseClassVal.Location = new System.Drawing.Point(160, 52);
        lblCourseClassVal.Name = "lblCourseClassVal";
        lblCourseClassVal.Size = new System.Drawing.Size(396, 20);
        lblCourseClassVal.TabIndex = 2;
        lblCourseClassVal.Text = "IELTS Foundation / IELTS-F04";
        // 
        // lblCourseClassKey
        // 
        lblCourseClassKey.AutoSize = true;
        lblCourseClassKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseClassKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCourseClassKey.Location = new System.Drawing.Point(20, 52);
        lblCourseClassKey.Name = "lblCourseClassKey";
        lblCourseClassKey.Size = new System.Drawing.Size(73, 15);
        lblCourseClassKey.TabIndex = 1;
        lblCourseClassKey.Text = "Khóa / lớp";
        // 
        // lblAdjustedTitle
        // 
        lblAdjustedTitle.AutoSize = true;
        lblAdjustedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAdjustedTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblAdjustedTitle.Location = new System.Drawing.Point(20, 16);
        lblAdjustedTitle.Name = "lblAdjustedTitle";
        lblAdjustedTitle.Size = new System.Drawing.Size(161, 21);
        lblAdjustedTitle.TabIndex = 0;
        lblAdjustedTitle.Text = "Lịch sau điều chỉnh";
        // 
        // bannerSavedSuccess
        // 
        bannerSavedSuccess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerSavedSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerSavedSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerSavedSuccess.Location = new System.Drawing.Point(24, 16);
        bannerSavedSuccess.Message = "✓  Đã kiểm tra lại và lưu 24 buổi học vào SQLite. Không lưu các lịch đề xuất bị xung đột.";
        bannerSavedSuccess.Name = "bannerSavedSuccess";
        bannerSavedSuccess.Size = new System.Drawing.Size(1172, 45);
        bannerSavedSuccess.TabIndex = 0;
        // 
        // ScheduleSavedDialog
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
        Name = "ScheduleSavedDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Lịch học đã được lưu · IELTS-F04";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardFirstSessions.ResumeLayout(false);
        cardFirstSessions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvFirstSessions).EndInit();
        cardAdjustedSchedule.ResumeLayout(false);
        cardAdjustedSchedule.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChecklist).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private ECMS.UI.Controls.AppButton btnBackToCalendar;
    private ECMS.UI.Controls.AppButton btnViewSessionList;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppBanner bannerSavedSuccess;
    private ECMS.UI.Controls.AppCard cardAdjustedSchedule;
    private System.Windows.Forms.Label lblAdjustedTitle;
    private System.Windows.Forms.Label lblCourseClassKey;
    private System.Windows.Forms.Label lblCourseClassVal;
    private System.Windows.Forms.Label lblTeacherKey;
    private System.Windows.Forms.Label lblTeacherVal;
    private System.Windows.Forms.Label lblDaysKey;
    private System.Windows.Forms.Label lblDaysVal;
    private System.Windows.Forms.Label lblTimeKey;
    private System.Windows.Forms.Label lblTimeVal;
    private System.Windows.Forms.Label lblRoomKey;
    private System.Windows.Forms.Label lblRoomVal;
    private System.Windows.Forms.Label lblDateRangeKey;
    private System.Windows.Forms.Label lblDateRangeVal;
    private System.Windows.Forms.Label lblPendingTransferKey;
    private System.Windows.Forms.Label lblPendingTransferVal;
    private ECMS.UI.Controls.AppDataGrid dgvChecklist;
    private ECMS.UI.Controls.AppCard cardFirstSessions;
    private System.Windows.Forms.Label lblSessionsTitle;
    private ECMS.UI.Controls.AppDataGrid dgvFirstSessions;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Label lblFlowNoteTitle;
    private System.Windows.Forms.Label lblFlowNoteSub;
}
