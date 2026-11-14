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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnViewSessionList = new ECMS.UI.Controls.AppButton();
        btnBackToCalendar = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardFirstSessions = new ECMS.UI.Controls.AppCard();
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
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnViewSessionList
        // 
        btnViewSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnViewSessionList.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnViewSessionList.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnViewSessionList.CornerRadius = 5;
        btnViewSessionList.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewSessionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewSessionList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewSessionList.ForeColor = System.Drawing.Color.White;
        btnViewSessionList.Location = new System.Drawing.Point(1035, 20);
        btnViewSessionList.Name = "btnViewSessionList";
        btnViewSessionList.Size = new System.Drawing.Size(161, 36);
        btnViewSessionList.TabIndex = 4;
        btnViewSessionList.Text = "Xem danh sách buổi";
        btnViewSessionList.UseVisualStyleBackColor = false;
        btnViewSessionList.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnBackToCalendar
        // 
        btnBackToCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBackToCalendar.BackColor = System.Drawing.Color.White;
        btnBackToCalendar.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToCalendar.CornerRadius = 5;
        btnBackToCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToCalendar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnBackToCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnBackToCalendar.Location = new System.Drawing.Point(920, 20);
        btnBackToCalendar.Name = "btnBackToCalendar";
        btnBackToCalendar.Size = new System.Drawing.Size(105, 36);
        btnBackToCalendar.TabIndex = 3;
        btnBackToCalendar.Text = "Về lịch tuần";
        btnBackToCalendar.UseVisualStyleBackColor = false;
        btnBackToCalendar.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(281, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lịch học đã được lưu";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardFirstSessions);
        pnlBody.Controls.Add(cardAdjustedSchedule);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardFirstSessions
        // 
        cardFirstSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardFirstSessions.BackColor = System.Drawing.Color.White;
        cardFirstSessions.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardFirstSessions.BorderWidth = 1;
        cardFirstSessions.Controls.Add(lblPagingNav);
        cardFirstSessions.Controls.Add(lblPagingInfo);
        cardFirstSessions.Controls.Add(dgvFirstSessions);
        cardFirstSessions.Controls.Add(lblSessionsTitle);
        cardFirstSessions.CornerRadius = 6;
        cardFirstSessions.Location = new System.Drawing.Point(620, 27);
        cardFirstSessions.Name = "cardFirstSessions";
        cardFirstSessions.Padding = new System.Windows.Forms.Padding(20);
        cardFirstSessions.Size = new System.Drawing.Size(576, 573);
        cardFirstSessions.TabIndex = 2;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblPagingNav.Location = new System.Drawing.Point(398, 533);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(158, 20);
        lblPagingNav.TabIndex = 3;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 533);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(144, 20);
        lblPagingInfo.TabIndex = 2;
        lblPagingInfo.Text = "1–4 / 24 buổi đã tạo";
        // 
        // dgvFirstSessions
        // 
        dgvFirstSessions.AllowUserToAddRows = false;
        dgvFirstSessions.AllowUserToDeleteRows = false;
        dgvFirstSessions.AllowUserToResizeColumns = false;
        dgvFirstSessions.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvFirstSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvFirstSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvFirstSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvFirstSessions.BackgroundColor = System.Drawing.Color.White;
        dgvFirstSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvFirstSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvFirstSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvFirstSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvFirstSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvFirstSessions.DefaultCellStyle = dataGridViewCellStyle3;
        dgvFirstSessions.EnableHeadersVisualStyles = false;
        dgvFirstSessions.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvFirstSessions.Location = new System.Drawing.Point(20, 55);
        dgvFirstSessions.MultiSelect = false;
        dgvFirstSessions.Name = "dgvFirstSessions";
        dgvFirstSessions.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvFirstSessions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvFirstSessions.RowHeadersVisible = false;
        dgvFirstSessions.RowHeadersWidth = 51;
        dgvFirstSessions.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvFirstSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvFirstSessions.Size = new System.Drawing.Size(536, 475);
        dgvFirstSessions.TabIndex = 1;
        // 
        // lblSessionsTitle
        // 
        lblSessionsTitle.AutoSize = true;
        lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblSessionsTitle.Location = new System.Drawing.Point(20, 16);
        lblSessionsTitle.Name = "lblSessionsTitle";
        lblSessionsTitle.Size = new System.Drawing.Size(218, 28);
        lblSessionsTitle.TabIndex = 0;
        lblSessionsTitle.Text = "Các buổi học đầu tiên";
        // 
        // cardAdjustedSchedule
        // 
        cardAdjustedSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAdjustedSchedule.BackColor = System.Drawing.Color.White;
        cardAdjustedSchedule.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAdjustedSchedule.BorderWidth = 1;
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
        cardAdjustedSchedule.CornerRadius = 6;
        cardAdjustedSchedule.Location = new System.Drawing.Point(24, 27);
        cardAdjustedSchedule.Name = "cardAdjustedSchedule";
        cardAdjustedSchedule.Padding = new System.Windows.Forms.Padding(20);
        cardAdjustedSchedule.Size = new System.Drawing.Size(576, 573);
        cardAdjustedSchedule.TabIndex = 1;
        // 
        // dgvChecklist
        // 
        dgvChecklist.AllowUserToAddRows = false;
        dgvChecklist.AllowUserToDeleteRows = false;
        dgvChecklist.AllowUserToResizeColumns = false;
        dgvChecklist.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvChecklist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        dgvChecklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvChecklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChecklist.BackgroundColor = System.Drawing.Color.White;
        dgvChecklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvChecklist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvChecklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvChecklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvChecklist.DefaultCellStyle = dataGridViewCellStyle7;
        dgvChecklist.EnableHeadersVisualStyles = false;
        dgvChecklist.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvChecklist.Location = new System.Drawing.Point(20, 310);
        dgvChecklist.MultiSelect = false;
        dgvChecklist.Name = "dgvChecklist";
        dgvChecklist.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvChecklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        dgvChecklist.RowHeadersVisible = false;
        dgvChecklist.RowHeadersWidth = 51;
        dgvChecklist.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvChecklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChecklist.Size = new System.Drawing.Size(536, 243);
        dgvChecklist.TabIndex = 15;
        // 
        // lblPendingTransferVal
        // 
        lblPendingTransferVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPendingTransferVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
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
        lblPendingTransferKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPendingTransferKey.Location = new System.Drawing.Point(20, 262);
        lblPendingTransferKey.Name = "lblPendingTransferKey";
        lblPendingTransferKey.Size = new System.Drawing.Size(117, 20);
        lblPendingTransferKey.TabIndex = 13;
        lblPendingTransferKey.Text = "Học viên chuyển";
        // 
        // lblDateRangeVal
        // 
        lblDateRangeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDateRangeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblDateRangeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblDateRangeKey.Location = new System.Drawing.Point(20, 227);
        lblDateRangeKey.Name = "lblDateRangeKey";
        lblDateRangeKey.Size = new System.Drawing.Size(92, 20);
        lblDateRangeKey.TabIndex = 11;
        lblDateRangeKey.Text = "Lập từ – đến";
        // 
        // lblRoomVal
        // 
        lblRoomVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblRoomKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblRoomKey.Location = new System.Drawing.Point(20, 192);
        lblRoomKey.Name = "lblRoomKey";
        lblRoomKey.Size = new System.Drawing.Size(51, 20);
        lblRoomKey.TabIndex = 9;
        lblRoomKey.Text = "Phòng";
        // 
        // lblTimeVal
        // 
        lblTimeVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTimeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblTimeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTimeKey.Location = new System.Drawing.Point(20, 157);
        lblTimeKey.Name = "lblTimeKey";
        lblTimeKey.Size = new System.Drawing.Size(60, 20);
        lblTimeKey.TabIndex = 7;
        lblTimeKey.Text = "Giờ học";
        // 
        // lblDaysVal
        // 
        lblDaysVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDaysVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblDaysKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblDaysKey.Location = new System.Drawing.Point(20, 122);
        lblDaysKey.Name = "lblDaysKey";
        lblDaysKey.Size = new System.Drawing.Size(72, 20);
        lblDaysKey.TabIndex = 5;
        lblDaysKey.Text = "Ngày học";
        // 
        // lblTeacherVal
        // 
        lblTeacherVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTeacherVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
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
        lblTeacherKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTeacherKey.Location = new System.Drawing.Point(20, 87);
        lblTeacherKey.Name = "lblTeacherKey";
        lblTeacherKey.Size = new System.Drawing.Size(71, 20);
        lblTeacherKey.TabIndex = 3;
        lblTeacherKey.Text = "Giáo viên";
        // 
        // lblCourseClassVal
        // 
        lblCourseClassVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCourseClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblCourseClassKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCourseClassKey.Location = new System.Drawing.Point(20, 52);
        lblCourseClassKey.Name = "lblCourseClassKey";
        lblCourseClassKey.Size = new System.Drawing.Size(79, 20);
        lblCourseClassKey.TabIndex = 1;
        lblCourseClassKey.Text = "Khóa / lớp";
        // 
        // lblAdjustedTitle
        // 
        lblAdjustedTitle.AutoSize = true;
        lblAdjustedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAdjustedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblAdjustedTitle.Location = new System.Drawing.Point(20, 16);
        lblAdjustedTitle.Name = "lblAdjustedTitle";
        lblAdjustedTitle.Size = new System.Drawing.Size(194, 28);
        lblAdjustedTitle.TabIndex = 0;
        lblAdjustedTitle.Text = "Lịch sau điều chỉnh";
        // 
        // ScheduleSavedDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
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
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnBackToCalendar;
    private ECMS.UI.Controls.AppButton btnViewSessionList;
    private System.Windows.Forms.Panel pnlBody;
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
}
