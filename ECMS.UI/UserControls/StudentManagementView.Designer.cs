namespace ECMS.UI.UserControls;

partial class StudentManagementView
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
        btnExport = new ECMS.UI.Controls.AppButton();
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStatArchived = new ECMS.UI.Controls.AppCard();
        lblStatArchivedValue = new System.Windows.Forms.Label();
        lblStatArchivedTitle = new System.Windows.Forms.Label();
        cardStatCompleted = new ECMS.UI.Controls.AppCard();
        lblStatCompletedValue = new System.Windows.Forms.Label();
        lblStatCompletedTitle = new System.Windows.Forms.Label();
        cardStatStudying = new ECMS.UI.Controls.AppCard();
        lblStatStudyingValue = new System.Windows.Forms.Label();
        lblStatStudyingTitle = new System.Windows.Forms.Label();
        cardStatTotal = new ECMS.UI.Controls.AppCard();
        lblStatTotalValue = new System.Windows.Forms.Label();
        lblStatTotalTitle = new System.Windows.Forms.Label();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvStudents = new ECMS.UI.Controls.AppDataGrid();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchStudent = new ECMS.UI.Controls.AppTextBox();
        lblStudentListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStatArchived.SuspendLayout();
        cardStatCompleted.SuspendLayout();
        cardStatStudying.SuspendLayout();
        cardStatTotal.SuspendLayout();
        cardStudentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnExport);
        pnlHeader.Controls.Add(btnAddStudent);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnExport
        // 
        btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnExport.BackColor = System.Drawing.Color.White;
        btnExport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExport.CornerRadius = 6;
        btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnExport.Location = new System.Drawing.Point(855, 20);
        btnExport.Name = "btnExport";
        btnExport.Size = new System.Drawing.Size(125, 36);
        btnExport.TabIndex = 4;
        btnExport.Text = "Xuất danh sách";
        btnExport.UseVisualStyleBackColor = false;
        btnExport.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnAddStudent
        // 
        btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAddStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddStudent.CornerRadius = 6;
        btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddStudent.ForeColor = System.Drawing.Color.White;
        btnAddStudent.Location = new System.Drawing.Point(990, 20);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new System.Drawing.Size(145, 36);
        btnAddStudent.TabIndex = 3;
        btnAddStudent.Text = "+ Thêm học viên";
        btnAddStudent.UseVisualStyleBackColor = false;
        btnAddStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(129, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Học viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardStatArchived);
        pnlBody.Controls.Add(cardStatCompleted);
        pnlBody.Controls.Add(cardStatStudying);
        pnlBody.Controls.Add(cardStatTotal);
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStatArchived
        // 
        cardStatArchived.BackColor = System.Drawing.Color.White;
        cardStatArchived.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatArchived.BorderWidth = 1;
        cardStatArchived.Controls.Add(lblStatArchivedValue);
        cardStatArchived.Controls.Add(lblStatArchivedTitle);
        cardStatArchived.CornerRadius = 8;
        cardStatArchived.Location = new System.Drawing.Point(845, 20);
        cardStatArchived.Name = "cardStatArchived";
        cardStatArchived.Padding = new System.Windows.Forms.Padding(16);
        cardStatArchived.Size = new System.Drawing.Size(260, 85);
        cardStatArchived.TabIndex = 8;
        // 
        // lblStatArchivedValue
        // 
        lblStatArchivedValue.AutoSize = true;
        lblStatArchivedValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatArchivedValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatArchivedValue.Location = new System.Drawing.Point(14, 30);
        lblStatArchivedValue.Name = "lblStatArchivedValue";
        lblStatArchivedValue.Size = new System.Drawing.Size(64, 50);
        lblStatArchivedValue.TabIndex = 1;
        lblStatArchivedValue.Text = "18";
        // 
        // lblStatArchivedTitle
        // 
        lblStatArchivedTitle.AutoSize = true;
        lblStatArchivedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatArchivedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatArchivedTitle.Location = new System.Drawing.Point(16, 10);
        lblStatArchivedTitle.Name = "lblStatArchivedTitle";
        lblStatArchivedTitle.Size = new System.Drawing.Size(76, 20);
        lblStatArchivedTitle.TabIndex = 0;
        lblStatArchivedTitle.Text = "Đã lưu trữ";
        // 
        // cardStatCompleted
        // 
        cardStatCompleted.BackColor = System.Drawing.Color.White;
        cardStatCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatCompleted.BorderWidth = 1;
        cardStatCompleted.Controls.Add(lblStatCompletedValue);
        cardStatCompleted.Controls.Add(lblStatCompletedTitle);
        cardStatCompleted.CornerRadius = 8;
        cardStatCompleted.Location = new System.Drawing.Point(570, 20);
        cardStatCompleted.Name = "cardStatCompleted";
        cardStatCompleted.Padding = new System.Windows.Forms.Padding(16);
        cardStatCompleted.Size = new System.Drawing.Size(260, 85);
        cardStatCompleted.TabIndex = 7;
        // 
        // lblStatCompletedValue
        // 
        lblStatCompletedValue.AutoSize = true;
        lblStatCompletedValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatCompletedValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatCompletedValue.Location = new System.Drawing.Point(14, 30);
        lblStatCompletedValue.Name = "lblStatCompletedValue";
        lblStatCompletedValue.Size = new System.Drawing.Size(64, 50);
        lblStatCompletedValue.TabIndex = 1;
        lblStatCompletedValue.Text = "62";
        // 
        // lblStatCompletedTitle
        // 
        lblStatCompletedTitle.AutoSize = true;
        lblStatCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatCompletedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatCompletedTitle.Location = new System.Drawing.Point(16, 10);
        lblStatCompletedTitle.Name = "lblStatCompletedTitle";
        lblStatCompletedTitle.Size = new System.Drawing.Size(86, 20);
        lblStatCompletedTitle.TabIndex = 0;
        lblStatCompletedTitle.Text = "Hoàn thành";
        // 
        // cardStatStudying
        // 
        cardStatStudying.BackColor = System.Drawing.Color.White;
        cardStatStudying.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatStudying.BorderWidth = 1;
        cardStatStudying.Controls.Add(lblStatStudyingValue);
        cardStatStudying.Controls.Add(lblStatStudyingTitle);
        cardStatStudying.CornerRadius = 8;
        cardStatStudying.Location = new System.Drawing.Point(295, 20);
        cardStatStudying.Name = "cardStatStudying";
        cardStatStudying.Padding = new System.Windows.Forms.Padding(16);
        cardStatStudying.Size = new System.Drawing.Size(260, 85);
        cardStatStudying.TabIndex = 6;
        // 
        // lblStatStudyingValue
        // 
        lblStatStudyingValue.AutoSize = true;
        lblStatStudyingValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatStudyingValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatStudyingValue.Location = new System.Drawing.Point(14, 30);
        lblStatStudyingValue.Name = "lblStatStudyingValue";
        lblStatStudyingValue.Size = new System.Drawing.Size(85, 50);
        lblStatStudyingValue.TabIndex = 1;
        lblStatStudyingValue.Text = "348";
        // 
        // lblStatStudyingTitle
        // 
        lblStatStudyingTitle.AutoSize = true;
        lblStatStudyingTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatStudyingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatStudyingTitle.Location = new System.Drawing.Point(16, 10);
        lblStatStudyingTitle.Name = "lblStatStudyingTitle";
        lblStatStudyingTitle.Size = new System.Drawing.Size(73, 20);
        lblStatStudyingTitle.TabIndex = 0;
        lblStatStudyingTitle.Text = "Đang học";
        // 
        // cardStatTotal
        // 
        cardStatTotal.BackColor = System.Drawing.Color.White;
        cardStatTotal.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatTotal.BorderWidth = 1;
        cardStatTotal.Controls.Add(lblStatTotalValue);
        cardStatTotal.Controls.Add(lblStatTotalTitle);
        cardStatTotal.CornerRadius = 8;
        cardStatTotal.Location = new System.Drawing.Point(20, 20);
        cardStatTotal.Name = "cardStatTotal";
        cardStatTotal.Padding = new System.Windows.Forms.Padding(16);
        cardStatTotal.Size = new System.Drawing.Size(260, 85);
        cardStatTotal.TabIndex = 5;
        // 
        // lblStatTotalValue
        // 
        lblStatTotalValue.AutoSize = true;
        lblStatTotalValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatTotalValue.Location = new System.Drawing.Point(14, 30);
        lblStatTotalValue.Name = "lblStatTotalValue";
        lblStatTotalValue.Size = new System.Drawing.Size(85, 50);
        lblStatTotalValue.TabIndex = 1;
        lblStatTotalValue.Text = "428";
        // 
        // lblStatTotalTitle
        // 
        lblStatTotalTitle.AutoSize = true;
        lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatTotalTitle.Location = new System.Drawing.Point(16, 10);
        lblStatTotalTitle.Name = "lblStatTotalTitle";
        lblStatTotalTitle.Size = new System.Drawing.Size(83, 20);
        lblStatTotalTitle.TabIndex = 0;
        lblStatTotalTitle.Text = "Tổng hồ sơ";
        // 
        // cardStudentList
        // 
        cardStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(lblPagingNav);
        cardStudentList.Controls.Add(lblPagingInfo);
        cardStudentList.Controls.Add(dgvStudents);
        cardStudentList.Controls.Add(cboClassFilter);
        cardStudentList.Controls.Add(cboStatusFilter);
        cardStudentList.Controls.Add(txtSearchStudent);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.CornerRadius = 8;
        cardStudentList.Location = new System.Drawing.Point(20, 120);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(16);
        cardStudentList.Size = new System.Drawing.Size(1115, 570);
        cardStudentList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(930, 525);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(150, 20);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 525);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(196, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 348 học viên đang học";
        // 
        // dgvStudents
        // 
        dgvStudents.AllowUserToAddRows = false;
        dgvStudents.AllowUserToDeleteRows = false;
        dgvStudents.AllowUserToResizeColumns = false;
        dgvStudents.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvStudents.BackgroundColor = System.Drawing.Color.White;
        dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvStudents.ColumnHeadersHeight = 36;
        dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
        dgvStudents.EnableHeadersVisualStyles = false;
        dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvStudents.Location = new System.Drawing.Point(20, 95);
        dgvStudents.MultiSelect = false;
        dgvStudents.Name = "dgvStudents";
        dgvStudents.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvStudents.RowHeadersVisible = false;
        dgvStudents.RowHeadersWidth = 51;
        dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvStudents.Size = new System.Drawing.Size(1075, 416);
        dgvStudents.TabIndex = 4;
        // 
        // cboClassFilter
        // 
        cboClassFilter.BackColor = System.Drawing.Color.White;
        cboClassFilter.CornerRadius = 5;
        cboClassFilter.DataSource = null;
        cboClassFilter.DisplayMember = "";
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboClassFilter.Location = new System.Drawing.Point(550, 50);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.SelectedIndex = -1;
        cboClassFilter.SelectedItem = null;
        cboClassFilter.SelectedValue = null;
        cboClassFilter.Size = new System.Drawing.Size(160, 32);
        cboClassFilter.TabIndex = 3;
        cboClassFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboStatusFilter.Location = new System.Drawing.Point(375, 50);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(160, 32);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchStudent
        // 
        txtSearchStudent.BackColor = System.Drawing.Color.Transparent;
        txtSearchStudent.CornerRadius = 6;
        txtSearchStudent.ErrorMessage = "";
        txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchStudent.HasError = false;
        txtSearchStudent.Location = new System.Drawing.Point(20, 50);
        txtSearchStudent.Name = "txtSearchStudent";
        txtSearchStudent.Placeholder = "🔍  Tìm mã, họ tên, điện thoại...";
        txtSearchStudent.ReadOnly = false;
        txtSearchStudent.Size = new System.Drawing.Size(344, 32);
        txtSearchStudent.TabIndex = 1;
        txtSearchStudent.UseSystemPasswordChar = false;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.AutoSize = true;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStudentListTitle.Location = new System.Drawing.Point(20, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(196, 28);
        lblStudentListTitle.TabIndex = 0;
        lblStudentListTitle.Text = "Danh sách học viên";
        // 
        // StudentManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardStatArchived.ResumeLayout(false);
        cardStatArchived.PerformLayout();
        cardStatCompleted.ResumeLayout(false);
        cardStatCompleted.PerformLayout();
        cardStatStudying.ResumeLayout(false);
        cardStatStudying.PerformLayout();
        cardStatTotal.ResumeLayout(false);
        cardStatTotal.PerformLayout();
        cardStudentList.ResumeLayout(false);
        cardStudentList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnExport;
    private ECMS.UI.Controls.AppButton btnAddStudent;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStatTotal;
    private System.Windows.Forms.Label lblStatTotalTitle;
    private System.Windows.Forms.Label lblStatTotalValue;
    private ECMS.UI.Controls.AppCard cardStatStudying;
    private System.Windows.Forms.Label lblStatStudyingTitle;
    private System.Windows.Forms.Label lblStatStudyingValue;
    private ECMS.UI.Controls.AppCard cardStatCompleted;
    private System.Windows.Forms.Label lblStatCompletedTitle;
    private System.Windows.Forms.Label lblStatCompletedValue;
    private ECMS.UI.Controls.AppCard cardStatArchived;
    private System.Windows.Forms.Label lblStatArchivedTitle;
    private System.Windows.Forms.Label lblStatArchivedValue;

    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchStudent;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private ECMS.UI.Controls.AppDataGrid dgvStudents;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
}
