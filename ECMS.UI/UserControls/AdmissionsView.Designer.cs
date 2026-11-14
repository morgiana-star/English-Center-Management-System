namespace ECMS.UI.UserControls;

partial class AdmissionsView
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
        btnImport = new ECMS.UI.Controls.AppButton();
        btnAddLeadTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStat4 = new ECMS.UI.Controls.AppCard();
        lblStat4Value = new System.Windows.Forms.Label();
        lblStat4Title = new System.Windows.Forms.Label();
        cardStat3 = new ECMS.UI.Controls.AppCard();
        lblStat3Value = new System.Windows.Forms.Label();
        lblStat3Title = new System.Windows.Forms.Label();
        cardStat2 = new ECMS.UI.Controls.AppCard();
        lblStat2Value = new System.Windows.Forms.Label();
        lblStat2Title = new System.Windows.Forms.Label();
        cardStat1 = new ECMS.UI.Controls.AppCard();
        lblStat1Value = new System.Windows.Forms.Label();
        lblStat1Title = new System.Windows.Forms.Label();
        cardLeadsTable = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvLeads = new ECMS.UI.Controls.AppDataGrid();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboSourceFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchLeads = new ECMS.UI.Controls.AppTextBox();
        lblLeadsTableTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStat4.SuspendLayout();
        cardStat3.SuspendLayout();
        cardStat2.SuspendLayout();
        cardStat1.SuspendLayout();
        cardLeadsTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLeads).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnImport);
        pnlHeader.Controls.Add(btnAddLeadTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnImport
        // 
        btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnImport.BackColor = System.Drawing.Color.White;
        btnImport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnImport.CornerRadius = 6;
        btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnImport.Location = new System.Drawing.Point(845, 21);
        btnImport.Name = "btnImport";
        btnImport.Size = new System.Drawing.Size(115, 36);
        btnImport.TabIndex = 4;
        btnImport.Text = "Nhập từ tệp";
        btnImport.UseVisualStyleBackColor = false;
        btnImport.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnAddLeadTop
        // 
        btnAddLeadTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddLeadTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAddLeadTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddLeadTop.CornerRadius = 6;
        btnAddLeadTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddLeadTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddLeadTop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddLeadTop.ForeColor = System.Drawing.Color.White;
        btnAddLeadTop.Location = new System.Drawing.Point(966, 20);
        btnAddLeadTop.Name = "btnAddLeadTop";
        btnAddLeadTop.Size = new System.Drawing.Size(169, 36);
        btnAddLeadTop.TabIndex = 3;
        btnAddLeadTop.Text = "+ Thêm tiềm năng";
        btnAddLeadTop.UseVisualStyleBackColor = false;
        btnAddLeadTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(20, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(248, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tuyển sinh & tư vấn";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardStat4);
        pnlBody.Controls.Add(cardStat3);
        pnlBody.Controls.Add(cardStat2);
        pnlBody.Controls.Add(cardStat1);
        pnlBody.Controls.Add(cardLeadsTable);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStat4
        // 
        cardStat4.BackColor = System.Drawing.Color.White;
        cardStat4.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStat4.BorderWidth = 1;
        cardStat4.Controls.Add(lblStat4Value);
        cardStat4.Controls.Add(lblStat4Title);
        cardStat4.CornerRadius = 8;
        cardStat4.Location = new System.Drawing.Point(845, 20);
        cardStat4.Name = "cardStat4";
        cardStat4.Padding = new System.Windows.Forms.Padding(16);
        cardStat4.Size = new System.Drawing.Size(260, 85);
        cardStat4.TabIndex = 8;
        // 
        // lblStat4Value
        // 
        lblStat4Value.AutoSize = true;
        lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat4Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStat4Value.Location = new System.Drawing.Point(14, 30);
        lblStat4Value.Name = "lblStat4Value";
        lblStat4Value.Size = new System.Drawing.Size(64, 50);
        lblStat4Value.TabIndex = 1;
        lblStat4Value.Text = "24";
        // 
        // lblStat4Title
        // 
        lblStat4Title.AutoSize = true;
        lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat4Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStat4Title.Location = new System.Drawing.Point(16, 10);
        lblStat4Title.Name = "lblStat4Title";
        lblStat4Title.Size = new System.Drawing.Size(90, 20);
        lblStat4Title.TabIndex = 0;
        lblStat4Title.Text = "Đã ghi danh";
        // 
        // cardStat3
        // 
        cardStat3.BackColor = System.Drawing.Color.White;
        cardStat3.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStat3.BorderWidth = 1;
        cardStat3.Controls.Add(lblStat3Value);
        cardStat3.Controls.Add(lblStat3Title);
        cardStat3.CornerRadius = 8;
        cardStat3.Location = new System.Drawing.Point(570, 20);
        cardStat3.Name = "cardStat3";
        cardStat3.Padding = new System.Windows.Forms.Padding(16);
        cardStat3.Size = new System.Drawing.Size(260, 85);
        cardStat3.TabIndex = 7;
        // 
        // lblStat3Value
        // 
        lblStat3Value.AutoSize = true;
        lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat3Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStat3Value.Location = new System.Drawing.Point(14, 30);
        lblStat3Value.Name = "lblStat3Value";
        lblStat3Value.Size = new System.Drawing.Size(43, 50);
        lblStat3Value.TabIndex = 1;
        lblStat3Value.Text = "8";
        // 
        // lblStat3Title
        // 
        lblStat3Title.AutoSize = true;
        lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStat3Title.Location = new System.Drawing.Point(16, 10);
        lblStat3Title.Name = "lblStat3Title";
        lblStat3Title.Size = new System.Drawing.Size(143, 20);
        lblStat3Title.TabIndex = 0;
        lblStat3Title.Text = "Đã kiểm tra đầu vào";
        // 
        // cardStat2
        // 
        cardStat2.BackColor = System.Drawing.Color.White;
        cardStat2.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStat2.BorderWidth = 1;
        cardStat2.Controls.Add(lblStat2Value);
        cardStat2.Controls.Add(lblStat2Title);
        cardStat2.CornerRadius = 8;
        cardStat2.Location = new System.Drawing.Point(295, 20);
        cardStat2.Name = "cardStat2";
        cardStat2.Padding = new System.Windows.Forms.Padding(16);
        cardStat2.Size = new System.Drawing.Size(260, 85);
        cardStat2.TabIndex = 6;
        // 
        // lblStat2Value
        // 
        lblStat2Value.AutoSize = true;
        lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat2Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStat2Value.Location = new System.Drawing.Point(14, 30);
        lblStat2Value.Name = "lblStat2Value";
        lblStat2Value.Size = new System.Drawing.Size(64, 50);
        lblStat2Value.TabIndex = 1;
        lblStat2Value.Text = "12";
        // 
        // lblStat2Title
        // 
        lblStat2Title.AutoSize = true;
        lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStat2Title.Location = new System.Drawing.Point(16, 10);
        lblStat2Title.Name = "lblStat2Title";
        lblStat2Title.Size = new System.Drawing.Size(80, 20);
        lblStat2Title.TabIndex = 0;
        lblStat2Title.Text = "Chờ tư vấn";
        // 
        // cardStat1
        // 
        cardStat1.BackColor = System.Drawing.Color.White;
        cardStat1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStat1.BorderWidth = 1;
        cardStat1.Controls.Add(lblStat1Value);
        cardStat1.Controls.Add(lblStat1Title);
        cardStat1.CornerRadius = 8;
        cardStat1.Location = new System.Drawing.Point(20, 20);
        cardStat1.Name = "cardStat1";
        cardStat1.Padding = new System.Windows.Forms.Padding(16);
        cardStat1.Size = new System.Drawing.Size(260, 85);
        cardStat1.TabIndex = 5;
        // 
        // lblStat1Value
        // 
        lblStat1Value.AutoSize = true;
        lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat1Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStat1Value.Location = new System.Drawing.Point(14, 30);
        lblStat1Value.Name = "lblStat1Value";
        lblStat1Value.Size = new System.Drawing.Size(64, 50);
        lblStat1Value.TabIndex = 1;
        lblStat1Value.Text = "42";
        // 
        // lblStat1Title
        // 
        lblStat1Title.AutoSize = true;
        lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStat1Title.Location = new System.Drawing.Point(16, 10);
        lblStat1Title.Name = "lblStat1Title";
        lblStat1Title.Size = new System.Drawing.Size(141, 20);
        lblStat1Title.TabIndex = 0;
        lblStat1Title.Text = "Tiềm năng tháng 10";
        // 
        // cardLeadsTable
        // 
        cardLeadsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardLeadsTable.BackColor = System.Drawing.Color.White;
        cardLeadsTable.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardLeadsTable.BorderWidth = 1;
        cardLeadsTable.Controls.Add(lblPagingNav);
        cardLeadsTable.Controls.Add(lblPagingInfo);
        cardLeadsTable.Controls.Add(dgvLeads);
        cardLeadsTable.Controls.Add(cboStatusFilter);
        cardLeadsTable.Controls.Add(cboSourceFilter);
        cardLeadsTable.Controls.Add(txtSearchLeads);
        cardLeadsTable.Controls.Add(lblLeadsTableTitle);
        cardLeadsTable.CornerRadius = 8;
        cardLeadsTable.Location = new System.Drawing.Point(20, 120);
        cardLeadsTable.Name = "cardLeadsTable";
        cardLeadsTable.Padding = new System.Windows.Forms.Padding(16);
        cardLeadsTable.Size = new System.Drawing.Size(1115, 564);
        cardLeadsTable.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(930, 522);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 522);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(213, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 42 khách hàng tiềm năng";
        // 
        // dgvLeads
        // 
        dgvLeads.AllowUserToAddRows = false;
        dgvLeads.AllowUserToDeleteRows = false;
        dgvLeads.AllowUserToResizeColumns = false;
        dgvLeads.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvLeads.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvLeads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvLeads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLeads.BackgroundColor = System.Drawing.Color.White;
        dgvLeads.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvLeads.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvLeads.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvLeads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvLeads.ColumnHeadersHeight = 36;
        dgvLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvLeads.DefaultCellStyle = dataGridViewCellStyle3;
        dgvLeads.EnableHeadersVisualStyles = false;
        dgvLeads.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvLeads.Location = new System.Drawing.Point(20, 95);
        dgvLeads.MultiSelect = false;
        dgvLeads.Name = "dgvLeads";
        dgvLeads.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvLeads.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvLeads.RowHeadersVisible = false;
        dgvLeads.RowHeadersWidth = 51;
        dgvLeads.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvLeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLeads.Size = new System.Drawing.Size(1075, 424);
        dgvLeads.TabIndex = 4;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboStatusFilter.Location = new System.Drawing.Point(581, 50);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(160, 32);
        cboStatusFilter.TabIndex = 3;
        cboStatusFilter.ValueMember = "";
        // 
        // cboSourceFilter
        // 
        cboSourceFilter.BackColor = System.Drawing.Color.White;
        cboSourceFilter.CornerRadius = 5;
        cboSourceFilter.DataSource = null;
        cboSourceFilter.DisplayMember = "";
        cboSourceFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboSourceFilter.Location = new System.Drawing.Point(406, 50);
        cboSourceFilter.Name = "cboSourceFilter";
        cboSourceFilter.SelectedIndex = -1;
        cboSourceFilter.SelectedItem = null;
        cboSourceFilter.SelectedValue = null;
        cboSourceFilter.Size = new System.Drawing.Size(160, 32);
        cboSourceFilter.TabIndex = 2;
        cboSourceFilter.ValueMember = "";
        // 
        // txtSearchLeads
        // 
        txtSearchLeads.BackColor = System.Drawing.Color.Transparent;
        txtSearchLeads.CornerRadius = 6;
        txtSearchLeads.ErrorMessage = "";
        txtSearchLeads.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchLeads.HasError = false;
        txtSearchLeads.Location = new System.Drawing.Point(20, 50);
        txtSearchLeads.Name = "txtSearchLeads";
        txtSearchLeads.Placeholder = "🔍  Tìm tên, điện thoại, mã tiềm năng...";
        txtSearchLeads.ReadOnly = false;
        txtSearchLeads.Size = new System.Drawing.Size(368, 32);
        txtSearchLeads.TabIndex = 1;
        txtSearchLeads.UseSystemPasswordChar = false;
        // 
        // lblLeadsTableTitle
        // 
        lblLeadsTableTitle.AutoSize = true;
        lblLeadsTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblLeadsTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblLeadsTableTitle.Location = new System.Drawing.Point(20, 16);
        lblLeadsTableTitle.Name = "lblLeadsTableTitle";
        lblLeadsTableTitle.Size = new System.Drawing.Size(177, 28);
        lblLeadsTableTitle.TabIndex = 0;
        lblLeadsTableTitle.Text = "Danh sách tư vấn";
        // 
        // AdmissionsView
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
        cardStat4.ResumeLayout(false);
        cardStat4.PerformLayout();
        cardStat3.ResumeLayout(false);
        cardStat3.PerformLayout();
        cardStat2.ResumeLayout(false);
        cardStat2.PerformLayout();
        cardStat1.ResumeLayout(false);
        cardStat1.PerformLayout();
        cardLeadsTable.ResumeLayout(false);
        cardLeadsTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLeads).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnImport;
    private ECMS.UI.Controls.AppButton btnAddLeadTop;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStat1;
    private System.Windows.Forms.Label lblStat1Title;
    private System.Windows.Forms.Label lblStat1Value;
    private ECMS.UI.Controls.AppCard cardStat2;
    private System.Windows.Forms.Label lblStat2Title;
    private System.Windows.Forms.Label lblStat2Value;
    private ECMS.UI.Controls.AppCard cardStat3;
    private System.Windows.Forms.Label lblStat3Title;
    private System.Windows.Forms.Label lblStat3Value;
    private ECMS.UI.Controls.AppCard cardStat4;
    private System.Windows.Forms.Label lblStat4Title;
    private System.Windows.Forms.Label lblStat4Value;

    private ECMS.UI.Controls.AppCard cardLeadsTable;
    private System.Windows.Forms.Label lblLeadsTableTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchLeads;
    private ECMS.UI.Controls.AppComboBox cboSourceFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppDataGrid dgvLeads;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
}
