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
        btnCreateSession = new ECMS.UI.Controls.AppButton();
        btnManageRooms = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCalendar = new ECMS.UI.Controls.AppCard();
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
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateSession
        // 
        btnCreateSession.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateSession.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnCreateSession.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateSession.CornerRadius = 5;
        btnCreateSession.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateSession.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateSession.ForeColor = System.Drawing.Color.White;
        btnCreateSession.Location = new System.Drawing.Point(1005, 20);
        btnCreateSession.Name = "btnCreateSession";
        btnCreateSession.Size = new System.Drawing.Size(131, 36);
        btnCreateSession.TabIndex = 4;
        btnCreateSession.Text = "Tạo buổi học";
        btnCreateSession.UseVisualStyleBackColor = false;
        btnCreateSession.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnManageRooms
        // 
        btnManageRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnManageRooms.BackColor = System.Drawing.Color.White;
        btnManageRooms.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnManageRooms.CornerRadius = 5;
        btnManageRooms.Cursor = System.Windows.Forms.Cursors.Hand;
        btnManageRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnManageRooms.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnManageRooms.Location = new System.Drawing.Point(860, 20);
        btnManageRooms.Name = "btnManageRooms";
        btnManageRooms.Size = new System.Drawing.Size(135, 36);
        btnManageRooms.TabIndex = 3;
        btnManageRooms.Text = "Quản lý phòng";
        btnManageRooms.UseVisualStyleBackColor = false;
        btnManageRooms.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(271, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lịch học & phòng học";
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
        cardCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCalendar.BackColor = System.Drawing.Color.White;
        cardCalendar.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCalendar.BorderWidth = 1;
        cardCalendar.Controls.Add(dgvScheduleMatrix);
        cardCalendar.Controls.Add(lblCalendarSub);
        cardCalendar.Controls.Add(lblCalendarTitle);
        cardCalendar.CornerRadius = 6;
        cardCalendar.Location = new System.Drawing.Point(24, 90);
        cardCalendar.Name = "cardCalendar";
        cardCalendar.Padding = new System.Windows.Forms.Padding(20);
        cardCalendar.Size = new System.Drawing.Size(1112, 570);
        cardCalendar.TabIndex = 1;
        // 
        // dgvScheduleMatrix
        // 
        dgvScheduleMatrix.AllowUserToAddRows = false;
        dgvScheduleMatrix.AllowUserToDeleteRows = false;
        dgvScheduleMatrix.AllowUserToResizeColumns = false;
        dgvScheduleMatrix.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvScheduleMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvScheduleMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvScheduleMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvScheduleMatrix.BackgroundColor = System.Drawing.Color.White;
        dgvScheduleMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvScheduleMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvScheduleMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvScheduleMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvScheduleMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvScheduleMatrix.DefaultCellStyle = dataGridViewCellStyle3;
        dgvScheduleMatrix.EnableHeadersVisualStyles = false;
        dgvScheduleMatrix.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvScheduleMatrix.Location = new System.Drawing.Point(20, 50);
        dgvScheduleMatrix.MultiSelect = false;
        dgvScheduleMatrix.Name = "dgvScheduleMatrix";
        dgvScheduleMatrix.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvScheduleMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvScheduleMatrix.RowHeadersVisible = false;
        dgvScheduleMatrix.RowHeadersWidth = 51;
        dgvScheduleMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvScheduleMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvScheduleMatrix.Size = new System.Drawing.Size(1072, 497);
        dgvScheduleMatrix.TabIndex = 2;
        // 
        // lblCalendarSub
        // 
        lblCalendarSub.AutoSize = true;
        lblCalendarSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCalendarSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCalendarSub.Location = new System.Drawing.Point(290, 21);
        lblCalendarSub.Name = "lblCalendarSub";
        lblCalendarSub.Size = new System.Drawing.Size(190, 20);
        lblCalendarSub.TabIndex = 1;
        lblCalendarSub.Text = "Lọc lớp / giáo viên / phòng";
        // 
        // lblCalendarTitle
        // 
        lblCalendarTitle.AutoSize = true;
        lblCalendarTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCalendarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCalendarTitle.Location = new System.Drawing.Point(20, 14);
        lblCalendarTitle.Name = "lblCalendarTitle";
        lblCalendarTitle.Size = new System.Drawing.Size(264, 28);
        lblCalendarTitle.TabIndex = 0;
        lblCalendarTitle.Text = "Tuần 44 · Lịch đã xác nhận";
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
        cboProgramFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboProgramFilter.BackColor = System.Drawing.Color.Transparent;
        cboProgramFilter.CornerRadius = 5;
        cboProgramFilter.DataSource = null;
        cboProgramFilter.DisplayMember = "";
        cboProgramFilter.Location = new System.Drawing.Point(965, 12);
        cboProgramFilter.Name = "cboProgramFilter";
        cboProgramFilter.SelectedIndex = -1;
        cboProgramFilter.SelectedItem = null;
        cboProgramFilter.SelectedValue = null;
        cboProgramFilter.Size = new System.Drawing.Size(130, 35);
        cboProgramFilter.TabIndex = 10;
        cboProgramFilter.ValueMember = "";
        // 
        // cboRoomFilter
        // 
        cboRoomFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboRoomFilter.BackColor = System.Drawing.Color.Transparent;
        cboRoomFilter.CornerRadius = 5;
        cboRoomFilter.DataSource = null;
        cboRoomFilter.DisplayMember = "";
        cboRoomFilter.Location = new System.Drawing.Point(825, 12);
        cboRoomFilter.Name = "cboRoomFilter";
        cboRoomFilter.SelectedIndex = -1;
        cboRoomFilter.SelectedItem = null;
        cboRoomFilter.SelectedValue = null;
        cboRoomFilter.Size = new System.Drawing.Size(130, 35);
        cboRoomFilter.TabIndex = 9;
        cboRoomFilter.ValueMember = "";
        // 
        // cboTeacherFilter
        // 
        cboTeacherFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboTeacherFilter.BackColor = System.Drawing.Color.Transparent;
        cboTeacherFilter.CornerRadius = 5;
        cboTeacherFilter.DataSource = null;
        cboTeacherFilter.DisplayMember = "";
        cboTeacherFilter.Location = new System.Drawing.Point(680, 12);
        cboTeacherFilter.Name = "cboTeacherFilter";
        cboTeacherFilter.SelectedIndex = -1;
        cboTeacherFilter.SelectedItem = null;
        cboTeacherFilter.SelectedValue = null;
        cboTeacherFilter.Size = new System.Drawing.Size(135, 35);
        cboTeacherFilter.TabIndex = 8;
        cboTeacherFilter.ValueMember = "";
        // 
        // txtSearchClass
        // 
        txtSearchClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtSearchClass.BackColor = System.Drawing.Color.Transparent;
        txtSearchClass.CornerRadius = 5;
        txtSearchClass.ErrorMessage = "";
        txtSearchClass.HasError = false;
        txtSearchClass.Location = new System.Drawing.Point(495, 12);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍  Tìm lớp học...";
        txtSearchClass.ReadOnly = false;
        txtSearchClass.Size = new System.Drawing.Size(175, 35);
        txtSearchClass.TabIndex = 7;
        txtSearchClass.UseSystemPasswordChar = false;
        // 
        // btnToday
        // 
        btnToday.BackColor = System.Drawing.Color.White;
        btnToday.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnToday.CornerRadius = 5;
        btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
        btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnToday.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnToday.Location = new System.Drawing.Point(395, 13);
        btnToday.Name = "btnToday";
        btnToday.Size = new System.Drawing.Size(75, 32);
        btnToday.TabIndex = 6;
        btnToday.Text = "Hôm nay";
        btnToday.UseVisualStyleBackColor = false;
        btnToday.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnNextWeek
        // 
        btnNextWeek.FlatAppearance.BorderSize = 0;
        btnNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNextWeek.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
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
        lblDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblDateRange.Location = new System.Drawing.Point(215, 20);
        lblDateRange.Name = "lblDateRange";
        lblDateRange.Size = new System.Drawing.Size(174, 21);
        lblDateRange.TabIndex = 4;
        lblDateRange.Text = "26/10–01/11/2026 📅";
        // 
        // btnPrevWeek
        // 
        btnPrevWeek.FlatAppearance.BorderSize = 0;
        btnPrevWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrevWeek.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnPrevWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
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
        lblViewMonth.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblViewMonth.Location = new System.Drawing.Point(125, 21);
        lblViewMonth.Name = "lblViewMonth";
        lblViewMonth.Size = new System.Drawing.Size(50, 20);
        lblViewMonth.TabIndex = 2;
        lblViewMonth.Text = "Tháng";
        // 
        // lblViewWeek
        // 
        lblViewWeek.AutoSize = true;
        lblViewWeek.Cursor = System.Windows.Forms.Cursors.Hand;
        lblViewWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblViewWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblViewWeek.Location = new System.Drawing.Point(65, 21);
        lblViewWeek.Name = "lblViewWeek";
        lblViewWeek.Size = new System.Drawing.Size(62, 20);
        lblViewWeek.TabIndex = 1;
        lblViewWeek.Text = "▬ Tuần";
        // 
        // lblViewDay
        // 
        lblViewDay.AutoSize = true;
        lblViewDay.Cursor = System.Windows.Forms.Cursors.Hand;
        lblViewDay.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblViewDay.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblViewDay.Location = new System.Drawing.Point(16, 21);
        lblViewDay.Name = "lblViewDay";
        lblViewDay.Size = new System.Drawing.Size(44, 20);
        lblViewDay.TabIndex = 0;
        lblViewDay.Text = "Ngày";
        // 
        // ScheduleManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    private System.Windows.Forms.Label lblTitle;
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
}
