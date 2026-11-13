namespace ECMS.UI.UserControls;

partial class ScheduleManagementView
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

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        btnCreateSession = new ECMS.UI.Controls.AppButton();
        btnManageRooms = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCalendar = new ECMS.UI.Controls.AppCard();
        lblLegend = new System.Windows.Forms.Label();
        dgvScheduleMatrix = new ECMS.UI.Controls.AppDataGrid();
        lblCalendarSub = new System.Windows.Forms.Label();
        lblCalendarTitle = new System.Windows.Forms.Label();
        pnlFilterBar = new System.Windows.Forms.Panel();
        cboProgramFilter = new ECMS.UI.Controls.AppComboBox();
        cboRoomFilter = new ECMS.UI.Controls.AppComboBox();
        cboTeacherFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        btnToday = new ECMS.UI.Controls.AppButton();
        btnNextWeek = new System.Windows.Forms.Button();
        lblDateRange = new System.Windows.Forms.Label();
        btnPrevWeek = new System.Windows.Forms.Button();
        lblViewMonth = new System.Windows.Forms.Label();
        lblViewWeek = new System.Windows.Forms.Label();
        lblViewDay = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCalendar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvScheduleMatrix).BeginInit();
        pnlFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateSession);
        pnlHeader.Controls.Add(btnManageRooms);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateSession
        // 
        btnCreateSession.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnCreateSession.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCreateSession.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnCreateSession.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateSession.ForeColor = System.Drawing.Color.White;
        btnCreateSession.Location = new System.Drawing.Point(1005, 20);
        btnCreateSession.Name = "btnCreateSession";
        btnCreateSession.Size = new System.Drawing.Size(131, 36);
        btnCreateSession.TabIndex = 4;
        btnCreateSession.Text = "Tạo buổi học";
        btnCreateSession.UseVisualStyleBackColor = false;
        // 
        // btnManageRooms
        // 
        btnManageRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnManageRooms.BackColor = System.Drawing.Color.White;
        btnManageRooms.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnManageRooms.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnManageRooms.Location = new System.Drawing.Point(860, 20);
        btnManageRooms.Name = "btnManageRooms";
        btnManageRooms.Size = new System.Drawing.Size(135, 36);
        btnManageRooms.TabIndex = 3;
        btnManageRooms.Text = "Quản lý phòng";
        btnManageRooms.UseVisualStyleBackColor = false;
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
        lblTitle.Size = new System.Drawing.Size(235, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lịch học & phòng học";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(225, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lịch học & Phòng học / Lịch học & phòng học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardCalendar);
        pnlBody.Controls.Add(pnlFilterBar);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardCalendar
        // 
        cardCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardCalendar.BackColor = System.Drawing.Color.White;
        cardCalendar.Controls.Add(lblLegend);
        cardCalendar.Controls.Add(dgvScheduleMatrix);
        cardCalendar.Controls.Add(lblCalendarSub);
        cardCalendar.Controls.Add(lblCalendarTitle);
        cardCalendar.Location = new System.Drawing.Point(24, 90);
        cardCalendar.Name = "cardCalendar";
        cardCalendar.Padding = new System.Windows.Forms.Padding(20);
        cardCalendar.Size = new System.Drawing.Size(1112, 570);
        cardCalendar.TabIndex = 1;
        // 
        // lblLegend
        // 
        lblLegend.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblLegend.AutoSize = true;
        lblLegend.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblLegend.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblLegend.Location = new System.Drawing.Point(20, 535);
        lblLegend.Name = "lblLegend";
        lblLegend.Size = new System.Drawing.Size(565, 15);
        lblLegend.TabIndex = 3;
        lblLegend.Text = "■ IELTS · 18:00–20:00   ■ TOEIC · 18:00–20:00   Chọn buổi ➔ chi tiết / điểm danh · Không có xung đột đã lưu.";
        // 
        // dgvScheduleMatrix
        // 
        dgvScheduleMatrix.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvScheduleMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvScheduleMatrix.Location = new System.Drawing.Point(20, 50);
        dgvScheduleMatrix.Name = "dgvScheduleMatrix";
        dgvScheduleMatrix.Size = new System.Drawing.Size(1072, 470);
        dgvScheduleMatrix.TabIndex = 2;
        // 
        // lblCalendarSub
        // 
        lblCalendarSub.AutoSize = true;
        lblCalendarSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCalendarSub.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCalendarSub.Location = new System.Drawing.Point(240, 18);
        lblCalendarSub.Name = "lblCalendarSub";
        lblCalendarSub.Size = new System.Drawing.Size(155, 15);
        lblCalendarSub.TabIndex = 1;
        lblCalendarSub.Text = "Lọc lớp / giáo viên / phòng";
        // 
        // lblCalendarTitle
        // 
        lblCalendarTitle.AutoSize = true;
        lblCalendarTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCalendarTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCalendarTitle.Location = new System.Drawing.Point(20, 14);
        lblCalendarTitle.Name = "lblCalendarTitle";
        lblCalendarTitle.Size = new System.Drawing.Size(202, 21);
        lblCalendarTitle.TabIndex = 0;
        lblCalendarTitle.Text = "Tuần 44 · Lịch đã xác nhận";
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pnlFilterBar.BackColor = System.Drawing.Color.White;
        pnlFilterBar.Controls.Add(cboProgramFilter);
        pnlFilterBar.Controls.Add(cboRoomFilter);
        pnlFilterBar.Controls.Add(cboTeacherFilter);
        pnlFilterBar.Controls.Add(txtSearchClass);
        pnlFilterBar.Controls.Add(btnToday);
        pnlFilterBar.Controls.Add(btnNextWeek);
        pnlFilterBar.Controls.Add(lblDateRange);
        pnlFilterBar.Controls.Add(btnPrevWeek);
        pnlFilterBar.Controls.Add(lblViewMonth);
        pnlFilterBar.Controls.Add(lblViewWeek);
        pnlFilterBar.Controls.Add(lblViewDay);
        pnlFilterBar.Location = new System.Drawing.Point(24, 16);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(16);
        pnlFilterBar.Size = new System.Drawing.Size(1112, 60);
        pnlFilterBar.TabIndex = 0;
        // 
        // cboProgramFilter
        // 
        cboProgramFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboProgramFilter.Location = new System.Drawing.Point(965, 12);
        cboProgramFilter.Name = "cboProgramFilter";
        cboProgramFilter.Size = new System.Drawing.Size(130, 35);
        cboProgramFilter.TabIndex = 10;
        // 
        // cboRoomFilter
        // 
        cboRoomFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboRoomFilter.Location = new System.Drawing.Point(825, 12);
        cboRoomFilter.Name = "cboRoomFilter";
        cboRoomFilter.Size = new System.Drawing.Size(130, 35);
        cboRoomFilter.TabIndex = 9;
        // 
        // cboTeacherFilter
        // 
        cboTeacherFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboTeacherFilter.Location = new System.Drawing.Point(680, 12);
        cboTeacherFilter.Name = "cboTeacherFilter";
        cboTeacherFilter.Size = new System.Drawing.Size(135, 35);
        cboTeacherFilter.TabIndex = 8;
        // 
        // txtSearchClass
        // 
        txtSearchClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtSearchClass.Location = new System.Drawing.Point(495, 12);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍  Tìm lớp học...";
        txtSearchClass.Size = new System.Drawing.Size(175, 35);
        txtSearchClass.TabIndex = 7;
        // 
        // btnToday
        // 
        btnToday.BackColor = System.Drawing.Color.White;
        btnToday.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnToday.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnToday.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnToday.Location = new System.Drawing.Point(395, 13);
        btnToday.Name = "btnToday";
        btnToday.Size = new System.Drawing.Size(75, 32);
        btnToday.TabIndex = 6;
        btnToday.Text = "Hôm nay";
        btnToday.UseVisualStyleBackColor = false;
        // 
        // btnNextWeek
        // 
        btnNextWeek.FlatAppearance.BorderSize = 0;
        btnNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNextWeek.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnNextWeek.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        btnNextWeek.Location = new System.Drawing.Point(355, 14);
        btnNextWeek.Name = "btnNextWeek";
        btnNextWeek.Size = new System.Drawing.Size(30, 30);
        btnNextWeek.TabIndex = 5;
        btnNextWeek.Text = "›";
        btnNextWeek.UseVisualStyleBackColor = true;
        // 
        // lblDateRange
        // 
        lblDateRange.AutoSize = true;
        lblDateRange.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblDateRange.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblDateRange.Location = new System.Drawing.Point(215, 20);
        lblDateRange.Name = "lblDateRange";
        lblDateRange.Size = new System.Drawing.Size(134, 17);
        lblDateRange.TabIndex = 4;
        lblDateRange.Text = "26/10–01/11/2026 📅";
        // 
        // btnPrevWeek
        // 
        btnPrevWeek.FlatAppearance.BorderSize = 0;
        btnPrevWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrevWeek.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnPrevWeek.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        btnPrevWeek.Location = new System.Drawing.Point(180, 14);
        btnPrevWeek.Name = "btnPrevWeek";
        btnPrevWeek.Size = new System.Drawing.Size(30, 30);
        btnPrevWeek.TabIndex = 3;
        btnPrevWeek.Text = "‹";
        btnPrevWeek.UseVisualStyleBackColor = true;
        // 
        // lblViewMonth
        // 
        lblViewMonth.AutoSize = true;
        lblViewMonth.Cursor = System.Windows.Forms.Cursors.Hand;
        lblViewMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblViewMonth.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblViewMonth.Location = new System.Drawing.Point(125, 21);
        lblViewMonth.Name = "lblViewMonth";
        lblViewMonth.Size = new System.Drawing.Size(40, 15);
        lblViewMonth.TabIndex = 2;
        lblViewMonth.Text = "Tháng";
        // 
        // lblViewWeek
        // 
        lblViewWeek.AutoSize = true;
        lblViewWeek.Cursor = System.Windows.Forms.Cursors.Hand;
        lblViewWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblViewWeek.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblViewWeek.Location = new System.Drawing.Point(65, 21);
        lblViewWeek.Name = "lblViewWeek";
        lblViewWeek.Size = new System.Drawing.Size(47, 15);
        lblViewWeek.TabIndex = 1;
        lblViewWeek.Text = "▬ Tuần";
        // 
        // lblViewDay
        // 
        lblViewDay.AutoSize = true;
        lblViewDay.Cursor = System.Windows.Forms.Cursors.Hand;
        lblViewDay.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblViewDay.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblViewDay.Location = new System.Drawing.Point(16, 21);
        lblViewDay.Name = "lblViewDay";
        lblViewDay.Size = new System.Drawing.Size(35, 15);
        lblViewDay.TabIndex = 0;
        lblViewDay.Text = "Ngày";
        // 
        // ScheduleManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "ScheduleManagementView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCalendar.ResumeLayout(false);
        cardCalendar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvScheduleMatrix).EndInit();
        pnlFilterBar.ResumeLayout(false);
        pnlFilterBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnManageRooms;
    private ECMS.UI.Controls.AppButton btnCreateSession;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlFilterBar;
    private System.Windows.Forms.Label lblViewDay;
    private System.Windows.Forms.Label lblViewWeek;
    private System.Windows.Forms.Label lblViewMonth;
    private System.Windows.Forms.Button btnPrevWeek;
    private System.Windows.Forms.Label lblDateRange;
    private System.Windows.Forms.Button btnNextWeek;
    private ECMS.UI.Controls.AppButton btnToday;
    private ECMS.UI.Controls.AppTextBox txtSearchClass;
    private ECMS.UI.Controls.AppComboBox cboTeacherFilter;
    private ECMS.UI.Controls.AppComboBox cboRoomFilter;
    private ECMS.UI.Controls.AppComboBox cboProgramFilter;
    private ECMS.UI.Controls.AppCard cardCalendar;
    private System.Windows.Forms.Label lblCalendarTitle;
    private System.Windows.Forms.Label lblCalendarSub;
    private ECMS.UI.Controls.AppDataGrid dgvScheduleMatrix;
    private System.Windows.Forms.Label lblLegend;
}
