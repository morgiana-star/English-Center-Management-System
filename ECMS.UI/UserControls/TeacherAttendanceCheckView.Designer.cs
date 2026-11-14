namespace ECMS.UI.UserControls;

partial class TeacherAttendanceCheckView
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
        btnSummaryView = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlWizard = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardAttendance = new ECMS.UI.Controls.AppCard();
        pnlBottomActions = new System.Windows.Forms.Panel();
        btnSaveAttendance = new ECMS.UI.Controls.AppButton();
        btnCancelChanges = new ECMS.UI.Controls.AppButton();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvAttendance = new ECMS.UI.Controls.AppDataGrid();
        lblAttendanceSubtitle = new System.Windows.Forms.Label();
        lblAttendanceTitle = new System.Windows.Forms.Label();
        pnlStats = new System.Windows.Forms.Panel();
        statRate = new ECMS.UI.Controls.AppStatCard();
        statAbsent = new ECMS.UI.Controls.AppStatCard();
        statLate = new ECMS.UI.Controls.AppStatCard();
        statPresent = new ECMS.UI.Controls.AppStatCard();
        statTotal = new ECMS.UI.Controls.AppStatCard();
        pnlFilters = new System.Windows.Forms.Panel();
        btnMarkAllPresent = new ECMS.UI.Controls.AppButton();
        cboSession = new ECMS.UI.Controls.AppComboBox();
        cboClass = new ECMS.UI.Controls.AppComboBox();
        txtSearchStudent = new ECMS.UI.Controls.AppTextBox();
        pnlHeader.SuspendLayout();
        pnlWizard.SuspendLayout();
        pnlBody.SuspendLayout();
        cardAttendance.SuspendLayout();
        pnlBottomActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
        pnlStats.SuspendLayout();
        pnlFilters.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnSummaryView);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnSummaryView
        // 
        btnSummaryView.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSummaryView.BackColor = System.Drawing.Color.White;
        btnSummaryView.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnSummaryView.CornerRadius = 5;
        btnSummaryView.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSummaryView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnSummaryView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSummaryView.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnSummaryView.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnSummaryView.Location = new System.Drawing.Point(1006, 20);
        btnSummaryView.Name = "btnSummaryView";
        btnSummaryView.Size = new System.Drawing.Size(130, 36);
        btnSummaryView.TabIndex = 3;
        btnSummaryView.Text = "Xem tổng hợp";
        btnSummaryView.UseVisualStyleBackColor = false;
        btnSummaryView.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(267, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Điểm danh · IELTS-F01";
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
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStep4.Location = new System.Drawing.Point(620, 10);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(117, 20);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "4. Lưu & tổng hợp";
        // 
        // lblStep3
        // 
        lblStep3.AutoSize = true;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep3.Location = new System.Drawing.Point(440, 10);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(112, 20);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "• 3. Điểm danh";
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
        pnlBody.Controls.Add(cardAttendance);
        pnlBody.Controls.Add(pnlStats);
        pnlBody.Controls.Add(pnlFilters);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 111);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 649);
        pnlBody.TabIndex = 2;
        // 
        // cardAttendance
        // 
        cardAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAttendance.BackColor = System.Drawing.Color.White;
        cardAttendance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAttendance.BorderWidth = 1;
        cardAttendance.Controls.Add(pnlBottomActions);
        cardAttendance.Controls.Add(lblPagingNav);
        cardAttendance.Controls.Add(lblPagingInfo);
        cardAttendance.Controls.Add(dgvAttendance);
        cardAttendance.Controls.Add(lblAttendanceSubtitle);
        cardAttendance.Controls.Add(lblAttendanceTitle);
        cardAttendance.CornerRadius = 6;
        cardAttendance.Location = new System.Drawing.Point(24, 184);
        cardAttendance.Name = "cardAttendance";
        cardAttendance.Padding = new System.Windows.Forms.Padding(20);
        cardAttendance.Size = new System.Drawing.Size(1112, 441);
        cardAttendance.TabIndex = 2;
        // 
        // pnlBottomActions
        // 
        pnlBottomActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        pnlBottomActions.Controls.Add(btnSaveAttendance);
        pnlBottomActions.Controls.Add(btnCancelChanges);
        pnlBottomActions.Location = new System.Drawing.Point(846, 391);
        pnlBottomActions.Name = "pnlBottomActions";
        pnlBottomActions.Size = new System.Drawing.Size(246, 40);
        pnlBottomActions.TabIndex = 6;
        // 
        // btnSaveAttendance
        // 
        btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveAttendance.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAttendance.CornerRadius = 5;
        btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAttendance.FlatAppearance.BorderSize = 0;
        btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveAttendance.ForeColor = System.Drawing.Color.White;
        btnSaveAttendance.Location = new System.Drawing.Point(120, 4);
        btnSaveAttendance.Name = "btnSaveAttendance";
        btnSaveAttendance.Size = new System.Drawing.Size(120, 32);
        btnSaveAttendance.TabIndex = 1;
        btnSaveAttendance.Text = "Lưu điểm danh";
        btnSaveAttendance.UseVisualStyleBackColor = false;
        btnSaveAttendance.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelChanges
        // 
        btnCancelChanges.BackColor = System.Drawing.Color.White;
        btnCancelChanges.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelChanges.CornerRadius = 5;
        btnCancelChanges.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelChanges.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelChanges.Location = new System.Drawing.Point(10, 4);
        btnCancelChanges.Name = "btnCancelChanges";
        btnCancelChanges.Size = new System.Drawing.Size(100, 32);
        btnCancelChanges.TabIndex = 0;
        btnCancelChanges.Text = "Hủy thay đổi";
        btnCancelChanges.UseVisualStyleBackColor = false;
        btnCancelChanges.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(922, 296);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(160, 20);
        lblPagingNav.TabIndex = 4;
        lblPagingNav.Text = "< Trước   [1]   2   Sau >";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 296);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(311, 20);
        lblPagingInfo.TabIndex = 3;
        lblPagingInfo.Text = "1–5 / 18 học viên · 13 học viên còn lại: Có mặt";
        // 
        // dgvAttendance
        // 
        dgvAttendance.AllowUserToAddRows = false;
        dgvAttendance.AllowUserToDeleteRows = false;
        dgvAttendance.AllowUserToResizeColumns = false;
        dgvAttendance.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAttendance.BackgroundColor = System.Drawing.Color.White;
        dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAttendance.EnableHeadersVisualStyles = false;
        dgvAttendance.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvAttendance.Location = new System.Drawing.Point(20, 52);
        dgvAttendance.MultiSelect = false;
        dgvAttendance.Name = "dgvAttendance";
        dgvAttendance.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvAttendance.RowHeadersVisible = false;
        dgvAttendance.RowHeadersWidth = 51;
        dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAttendance.Size = new System.Drawing.Size(1072, 231);
        dgvAttendance.TabIndex = 2;
        // 
        // lblAttendanceSubtitle
        // 
        lblAttendanceSubtitle.AutoSize = true;
        lblAttendanceSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblAttendanceSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAttendanceSubtitle.Location = new System.Drawing.Point(270, 18);
        lblAttendanceSubtitle.Name = "lblAttendanceSubtitle";
        lblAttendanceSubtitle.Size = new System.Drawing.Size(195, 19);
        lblAttendanceSubtitle.TabIndex = 1;
        lblAttendanceSubtitle.Text = "Có mặt + Đi muộn = tham dự";
        // 
        // lblAttendanceTitle
        // 
        lblAttendanceTitle.AutoSize = true;
        lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAttendanceTitle.Location = new System.Drawing.Point(20, 14);
        lblAttendanceTitle.Name = "lblAttendanceTitle";
        lblAttendanceTitle.Size = new System.Drawing.Size(357, 25);
        lblAttendanceTitle.TabIndex = 0;
        lblAttendanceTitle.Text = "Chọn một trạng thái cho từng học viên";
        // 
        // pnlStats
        // 
        pnlStats.Controls.Add(statRate);
        pnlStats.Controls.Add(statAbsent);
        pnlStats.Controls.Add(statLate);
        pnlStats.Controls.Add(statPresent);
        pnlStats.Controls.Add(statTotal);
        pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStats.Location = new System.Drawing.Point(24, 60);
        pnlStats.Name = "pnlStats";
        pnlStats.Size = new System.Drawing.Size(1112, 97);
        pnlStats.TabIndex = 1;
        // 
        // statRate
        // 
        statRate.BackColor = System.Drawing.Color.White;
        statRate.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statRate.BorderWidth = 1;
        statRate.CornerRadius = 6;
        statRate.Location = new System.Drawing.Point(880, 0);
        statRate.Name = "statRate";
        statRate.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statRate.Size = new System.Drawing.Size(210, 89);
        statRate.Subtext = "Ghi chú phụ";
        statRate.TabIndex = 4;
        statRate.Title = "Tỷ lệ dự kiến";
        statRate.Value = "88,9%";
        // 
        // statAbsent
        // 
        statAbsent.BackColor = System.Drawing.Color.White;
        statAbsent.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statAbsent.BorderWidth = 1;
        statAbsent.CornerRadius = 6;
        statAbsent.Location = new System.Drawing.Point(660, 0);
        statAbsent.Name = "statAbsent";
        statAbsent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statAbsent.Size = new System.Drawing.Size(205, 89);
        statAbsent.Subtext = "Ghi chú phụ";
        statAbsent.TabIndex = 3;
        statAbsent.Title = "Vắng có / không phép";
        statAbsent.Value = "1 / 1";
        // 
        // statLate
        // 
        statLate.BackColor = System.Drawing.Color.White;
        statLate.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statLate.BorderWidth = 1;
        statLate.CornerRadius = 6;
        statLate.Location = new System.Drawing.Point(440, 0);
        statLate.Name = "statLate";
        statLate.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statLate.Size = new System.Drawing.Size(205, 89);
        statLate.Subtext = "Ghi chú phụ";
        statLate.TabIndex = 2;
        statLate.Title = "Đi muộn";
        statLate.Value = "1";
        // 
        // statPresent
        // 
        statPresent.BackColor = System.Drawing.Color.White;
        statPresent.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statPresent.BorderWidth = 1;
        statPresent.CornerRadius = 6;
        statPresent.Location = new System.Drawing.Point(220, 0);
        statPresent.Name = "statPresent";
        statPresent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statPresent.Size = new System.Drawing.Size(205, 89);
        statPresent.Subtext = "Ghi chú phụ";
        statPresent.TabIndex = 1;
        statPresent.Title = "Có mặt";
        statPresent.Value = "15";
        // 
        // statTotal
        // 
        statTotal.BackColor = System.Drawing.Color.White;
        statTotal.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statTotal.BorderWidth = 1;
        statTotal.CornerRadius = 6;
        statTotal.Location = new System.Drawing.Point(0, 0);
        statTotal.Name = "statTotal";
        statTotal.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statTotal.Size = new System.Drawing.Size(205, 89);
        statTotal.Subtext = "Ghi chú phụ";
        statTotal.TabIndex = 0;
        statTotal.Title = "Tổng học viên";
        statTotal.Value = "18";
        // 
        // pnlFilters
        // 
        pnlFilters.Controls.Add(btnMarkAllPresent);
        pnlFilters.Controls.Add(cboSession);
        pnlFilters.Controls.Add(cboClass);
        pnlFilters.Controls.Add(txtSearchStudent);
        pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilters.Location = new System.Drawing.Point(24, 24);
        pnlFilters.Name = "pnlFilters";
        pnlFilters.Size = new System.Drawing.Size(1112, 36);
        pnlFilters.TabIndex = 0;
        // 
        // btnMarkAllPresent
        // 
        btnMarkAllPresent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnMarkAllPresent.BackColor = System.Drawing.Color.White;
        btnMarkAllPresent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnMarkAllPresent.CornerRadius = 5;
        btnMarkAllPresent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnMarkAllPresent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnMarkAllPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMarkAllPresent.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnMarkAllPresent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnMarkAllPresent.Location = new System.Drawing.Point(922, 1);
        btnMarkAllPresent.Name = "btnMarkAllPresent";
        btnMarkAllPresent.Size = new System.Drawing.Size(190, 34);
        btnMarkAllPresent.TabIndex = 3;
        btnMarkAllPresent.Text = "Đánh dấu tất cả Có mặt";
        btnMarkAllPresent.UseVisualStyleBackColor = false;
        btnMarkAllPresent.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cboSession
        // 
        cboSession.BackColor = System.Drawing.Color.Transparent;
        cboSession.CornerRadius = 5;
        cboSession.DataSource = null;
        cboSession.DisplayMember = "";
        cboSession.Location = new System.Drawing.Point(470, 1);
        cboSession.Name = "cboSession";
        cboSession.SelectedIndex = -1;
        cboSession.SelectedItem = null;
        cboSession.SelectedValue = null;
        cboSession.Size = new System.Drawing.Size(160, 34);
        cboSession.TabIndex = 2;
        cboSession.ValueMember = "";
        // 
        // cboClass
        // 
        cboClass.BackColor = System.Drawing.Color.Transparent;
        cboClass.CornerRadius = 5;
        cboClass.DataSource = null;
        cboClass.DisplayMember = "";
        cboClass.Location = new System.Drawing.Point(320, 1);
        cboClass.Name = "cboClass";
        cboClass.SelectedIndex = -1;
        cboClass.SelectedItem = null;
        cboClass.SelectedValue = null;
        cboClass.Size = new System.Drawing.Size(140, 34);
        cboClass.TabIndex = 1;
        cboClass.ValueMember = "";
        // 
        // txtSearchStudent
        // 
        txtSearchStudent.BackColor = System.Drawing.Color.Transparent;
        txtSearchStudent.CornerRadius = 5;
        txtSearchStudent.ErrorMessage = "";
        txtSearchStudent.HasError = false;
        txtSearchStudent.Location = new System.Drawing.Point(0, 1);
        txtSearchStudent.Name = "txtSearchStudent";
        txtSearchStudent.Placeholder = "Tìm học viên trong lớp...";
        txtSearchStudent.ReadOnly = false;
        txtSearchStudent.Size = new System.Drawing.Size(300, 34);
        txtSearchStudent.TabIndex = 0;
        txtSearchStudent.UseSystemPasswordChar = false;
        // 
        // TeacherAttendanceCheckView
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
        cardAttendance.ResumeLayout(false);
        cardAttendance.PerformLayout();
        pnlBottomActions.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
        pnlStats.ResumeLayout(false);
        pnlFilters.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnSummaryView;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlWizard;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlFilters;
    private ECMS.UI.Controls.AppTextBox txtSearchStudent;
    private ECMS.UI.Controls.AppComboBox cboClass;
    private ECMS.UI.Controls.AppComboBox cboSession;
    private ECMS.UI.Controls.AppButton btnMarkAllPresent;
    private System.Windows.Forms.Panel pnlStats;
    private ECMS.UI.Controls.AppStatCard statTotal;
    private ECMS.UI.Controls.AppStatCard statPresent;
    private ECMS.UI.Controls.AppStatCard statLate;
    private ECMS.UI.Controls.AppStatCard statAbsent;
    private ECMS.UI.Controls.AppStatCard statRate;
    private ECMS.UI.Controls.AppCard cardAttendance;
    private System.Windows.Forms.Label lblAttendanceTitle;
    private System.Windows.Forms.Label lblAttendanceSubtitle;
    private ECMS.UI.Controls.AppDataGrid dgvAttendance;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Panel pnlBottomActions;
    private ECMS.UI.Controls.AppButton btnCancelChanges;
    private ECMS.UI.Controls.AppButton btnSaveAttendance;
}
