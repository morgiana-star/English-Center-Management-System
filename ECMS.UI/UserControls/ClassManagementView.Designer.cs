namespace ECMS.UI.UserControls;

partial class ClassManagementView
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
        btnAddClass = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        pnlBottomCards = new System.Windows.Forms.Panel();
        cardEmptyClass = new ECMS.UI.Controls.AppCard();
        btnAddStudentToClass = new ECMS.UI.Controls.AppButton();
        lblEmptyClassTitle = new System.Windows.Forms.Label();
        cardOpenClass = new ECMS.UI.Controls.AppCard();
        btnCheckAndOpenClass = new ECMS.UI.Controls.AppButton();
        lblOpenClassChecks = new System.Windows.Forms.Label();
        lblOpenClassTitle = new System.Windows.Forms.Label();
        cardClassList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        lblEmptyClassDesc = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlBottomCards.SuspendLayout();
        cardEmptyClass.SuspendLayout();
        cardOpenClass.SuspendLayout();
        cardClassList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddClass);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddClass
        // 
        btnAddClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnAddClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddClass.CornerRadius = 5;
        btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddClass.ForeColor = System.Drawing.Color.White;
        btnAddClass.Location = new System.Drawing.Point(1005, 20);
        btnAddClass.Name = "btnAddClass";
        btnAddClass.Size = new System.Drawing.Size(131, 36);
        btnAddClass.TabIndex = 3;
        btnAddClass.Text = "+ Thêm lớp học";
        btnAddClass.UseVisualStyleBackColor = false;
        btnAddClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(118, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lớp học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(pnlBottomCards);
        pnlBody.Controls.Add(cardClassList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // pnlBottomCards
        // 
        pnlBottomCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlBottomCards.Controls.Add(cardEmptyClass);
        pnlBottomCards.Controls.Add(cardOpenClass);
        pnlBottomCards.Location = new System.Drawing.Point(22, 478);
        pnlBottomCards.Name = "pnlBottomCards";
        pnlBottomCards.Size = new System.Drawing.Size(1112, 180);
        pnlBottomCards.TabIndex = 1;
        // 
        // cardEmptyClass
        // 
        cardEmptyClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardEmptyClass.BackColor = System.Drawing.Color.White;
        cardEmptyClass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardEmptyClass.BorderWidth = 1;
        cardEmptyClass.Controls.Add(btnAddStudentToClass);
        cardEmptyClass.Controls.Add(lblEmptyClassDesc);
        cardEmptyClass.Controls.Add(lblEmptyClassTitle);
        cardEmptyClass.CornerRadius = 6;
        cardEmptyClass.Location = new System.Drawing.Point(619, 0);
        cardEmptyClass.Name = "cardEmptyClass";
        cardEmptyClass.Padding = new System.Windows.Forms.Padding(20);
        cardEmptyClass.Size = new System.Drawing.Size(493, 170);
        cardEmptyClass.TabIndex = 1;
        // 
        // btnAddStudentToClass
        // 
        btnAddStudentToClass.BackColor = System.Drawing.Color.White;
        btnAddStudentToClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnAddStudentToClass.CornerRadius = 5;
        btnAddStudentToClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddStudentToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddStudentToClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnAddStudentToClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnAddStudentToClass.Location = new System.Drawing.Point(20, 85);
        btnAddStudentToClass.Name = "btnAddStudentToClass";
        btnAddStudentToClass.Size = new System.Drawing.Size(160, 36);
        btnAddStudentToClass.TabIndex = 2;
        btnAddStudentToClass.Text = "Thêm học viên vào lớp";
        btnAddStudentToClass.UseVisualStyleBackColor = false;
        btnAddStudentToClass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblEmptyClassTitle
        // 
        lblEmptyClassTitle.AutoSize = true;
        lblEmptyClassTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblEmptyClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblEmptyClassTitle.Location = new System.Drawing.Point(20, 16);
        lblEmptyClassTitle.Name = "lblEmptyClassTitle";
        lblEmptyClassTitle.Size = new System.Drawing.Size(213, 28);
        lblEmptyClassTitle.TabIndex = 0;
        lblEmptyClassTitle.Text = "Lớp chưa có học viên";
        // 
        // cardOpenClass
        // 
        cardOpenClass.BackColor = System.Drawing.Color.White;
        cardOpenClass.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardOpenClass.BorderWidth = 1;
        cardOpenClass.Controls.Add(btnCheckAndOpenClass);
        cardOpenClass.Controls.Add(lblOpenClassChecks);
        cardOpenClass.Controls.Add(lblOpenClassTitle);
        cardOpenClass.CornerRadius = 6;
        cardOpenClass.Location = new System.Drawing.Point(0, 0);
        cardOpenClass.Name = "cardOpenClass";
        cardOpenClass.Padding = new System.Windows.Forms.Padding(20);
        cardOpenClass.Size = new System.Drawing.Size(587, 170);
        cardOpenClass.TabIndex = 0;
        // 
        // btnCheckAndOpenClass
        // 
        btnCheckAndOpenClass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnCheckAndOpenClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCheckAndOpenClass.CornerRadius = 5;
        btnCheckAndOpenClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCheckAndOpenClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCheckAndOpenClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCheckAndOpenClass.ForeColor = System.Drawing.Color.White;
        btnCheckAndOpenClass.Location = new System.Drawing.Point(20, 85);
        btnCheckAndOpenClass.Name = "btnCheckAndOpenClass";
        btnCheckAndOpenClass.Size = new System.Drawing.Size(150, 36);
        btnCheckAndOpenClass.TabIndex = 2;
        btnCheckAndOpenClass.Text = "Kiểm tra & mở lớp";
        btnCheckAndOpenClass.UseVisualStyleBackColor = false;
        btnCheckAndOpenClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblOpenClassChecks
        // 
        lblOpenClassChecks.AutoSize = true;
        lblOpenClassChecks.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblOpenClassChecks.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblOpenClassChecks.Location = new System.Drawing.Point(20, 50);
        lblOpenClassChecks.Name = "lblOpenClassChecks";
        lblOpenClassChecks.Size = new System.Drawing.Size(553, 20);
        lblOpenClassChecks.TabIndex = 1;
        lblOpenClassChecks.Text = "✓ Đã phân công Lê Thu Hà · ✓ P203 có 18 chỗ · ✓ 12 học viên · ✓ Lịch không trùng.";
        // 
        // lblOpenClassTitle
        // 
        lblOpenClassTitle.AutoSize = true;
        lblOpenClassTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblOpenClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblOpenClassTitle.Location = new System.Drawing.Point(20, 16);
        lblOpenClassTitle.Name = "lblOpenClassTitle";
        lblOpenClassTitle.Size = new System.Drawing.Size(178, 28);
        lblOpenClassTitle.TabIndex = 0;
        lblOpenClassTitle.Text = "Mở lớp COM-B01";
        // 
        // cardClassList
        // 
        cardClassList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassList.BackColor = System.Drawing.Color.White;
        cardClassList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassList.BorderWidth = 1;
        cardClassList.Controls.Add(lblPagingNav);
        cardClassList.Controls.Add(lblPagingInfo);
        cardClassList.Controls.Add(dgvClasses);
        cardClassList.Controls.Add(cboStatusFilter);
        cardClassList.Controls.Add(cboCourseFilter);
        cardClassList.Controls.Add(txtSearchClass);
        cardClassList.CornerRadius = 6;
        cardClassList.Location = new System.Drawing.Point(24, 16);
        cardClassList.Name = "cardClassList";
        cardClassList.Padding = new System.Windows.Forms.Padding(20);
        cardClassList.Size = new System.Drawing.Size(1112, 440);
        cardClassList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblPagingNav.Location = new System.Drawing.Point(934, 405);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(158, 20);
        lblPagingNav.TabIndex = 5;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 405);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(117, 20);
        lblPagingInfo.TabIndex = 4;
        lblPagingInfo.Text = "1–5 / 24 lớp học";
        // 
        // dgvClasses
        // 
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.AllowUserToDeleteRows = false;
        dgvClasses.AllowUserToResizeColumns = false;
        dgvClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClasses.BackgroundColor = System.Drawing.Color.White;
        dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClasses.EnableHeadersVisualStyles = false;
        dgvClasses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvClasses.Location = new System.Drawing.Point(20, 68);
        dgvClasses.MultiSelect = false;
        dgvClasses.Name = "dgvClasses";
        dgvClasses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.RowHeadersWidth = 51;
        dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.Size = new System.Drawing.Size(1072, 323);
        dgvClasses.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(505, 18);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(165, 35);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.BackColor = System.Drawing.Color.Transparent;
        cboCourseFilter.CornerRadius = 5;
        cboCourseFilter.DataSource = null;
        cboCourseFilter.DisplayMember = "";
        cboCourseFilter.Location = new System.Drawing.Point(325, 18);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.SelectedIndex = -1;
        cboCourseFilter.SelectedItem = null;
        cboCourseFilter.SelectedValue = null;
        cboCourseFilter.Size = new System.Drawing.Size(170, 35);
        cboCourseFilter.TabIndex = 1;
        cboCourseFilter.ValueMember = "";
        // 
        // txtSearchClass
        // 
        txtSearchClass.BackColor = System.Drawing.Color.Transparent;
        txtSearchClass.CornerRadius = 5;
        txtSearchClass.ErrorMessage = "";
        txtSearchClass.HasError = false;
        txtSearchClass.Location = new System.Drawing.Point(20, 18);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍  Tìm mã lớp, khóa học, giáo viên...";
        txtSearchClass.ReadOnly = false;
        txtSearchClass.Size = new System.Drawing.Size(295, 35);
        txtSearchClass.TabIndex = 0;
        txtSearchClass.UseSystemPasswordChar = false;
        // 
        // lblEmptyClassDesc
        // 
        lblEmptyClassDesc.AutoSize = true;
        lblEmptyClassDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmptyClassDesc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblEmptyClassDesc.Location = new System.Drawing.Point(20, 50);
        lblEmptyClassDesc.Name = "lblEmptyClassDesc";
        lblEmptyClassDesc.Size = new System.Drawing.Size(410, 20);
        lblEmptyClassDesc.TabIndex = 1;
        lblEmptyClassDesc.Text = "IELTS-F04 đang ở bản nháp, chưa có học viên được ghi danh.";
        // 
        // ClassManagementView
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
        pnlBottomCards.ResumeLayout(false);
        cardEmptyClass.ResumeLayout(false);
        cardEmptyClass.PerformLayout();
        cardOpenClass.ResumeLayout(false);
        cardOpenClass.PerformLayout();
        cardClassList.ResumeLayout(false);
        cardClassList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddClass;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardClassList;
    private ECMS.UI.Controls.AppTextBox txtSearchClass;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Panel pnlBottomCards;
    private ECMS.UI.Controls.AppCard cardOpenClass;
    private System.Windows.Forms.Label lblOpenClassTitle;
    private System.Windows.Forms.Label lblOpenClassChecks;
    private ECMS.UI.Controls.AppButton btnCheckAndOpenClass;
    private ECMS.UI.Controls.AppCard cardEmptyClass;
    private System.Windows.Forms.Label lblEmptyClassTitle;
    private System.Windows.Forms.Label lblEmptyClassDesc;
    private ECMS.UI.Controls.AppButton btnAddStudentToClass;
}
