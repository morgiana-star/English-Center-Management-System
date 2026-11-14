namespace ECMS.UI.Forms;

partial class CertificateRegistryDialog
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnPreviewPrint = new ECMS.UI.Controls.AppButton();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlFilterBar = new System.Windows.Forms.Panel();
        cboYearFilter = new ECMS.UI.Controls.AppComboBox();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        cardRegistryList = new ECMS.UI.Controls.AppCard();
        lblGridFooter = new System.Windows.Forms.Label();
        gridRegistry = new ECMS.UI.Controls.AppDataGrid();
        colCertNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblListTitle = new System.Windows.Forms.Label();
        cardDetail = new ECMS.UI.Controls.AppCard();
        btnViewCertToPrint = new ECMS.UI.Controls.AppButton();
        lblApproverVal = new System.Windows.Forms.Label();
        lblApproverTitle = new System.Windows.Forms.Label();
        lblIssueDateVal = new System.Windows.Forms.Label();
        lblIssueDateTitle = new System.Windows.Forms.Label();
        lblAttVal = new System.Windows.Forms.Label();
        lblAttTitle = new System.Windows.Forms.Label();
        lblAvgVal = new System.Windows.Forms.Label();
        lblAvgTitle = new System.Windows.Forms.Label();
        lblPeriodVal = new System.Windows.Forms.Label();
        lblPeriodTitle = new System.Windows.Forms.Label();
        lblClassVal = new System.Windows.Forms.Label();
        lblClassTitle = new System.Windows.Forms.Label();
        lblCourseVal = new System.Windows.Forms.Label();
        lblCourseTitle = new System.Windows.Forms.Label();
        lblDobVal = new System.Windows.Forms.Label();
        lblDobTitle = new System.Windows.Forms.Label();
        lblStudentVal = new System.Windows.Forms.Label();
        lblStudentTitle = new System.Windows.Forms.Label();
        lblDetailTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlFilterBar.SuspendLayout();
        pnlBody.SuspendLayout();
        cardRegistryList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridRegistry).BeginInit();
        cardDetail.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(1200, 78);
        pnlHeader.TabIndex = 0;
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlTopActions.Controls.Add(btnPreviewPrint);
        pnlTopActions.Controls.Add(btnClose);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(870, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnPreviewPrint
        // 
        btnPreviewPrint.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPreviewPrint.CornerRadius = 5;
        btnPreviewPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPreviewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPreviewPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPreviewPrint.Location = new System.Drawing.Point(157, 3);
        btnPreviewPrint.Name = "btnPreviewPrint";
        btnPreviewPrint.Size = new System.Drawing.Size(140, 38);
        btnPreviewPrint.TabIndex = 0;
        btnPreviewPrint.Text = "Xem trước khi in";
        btnPreviewPrint.UseVisualStyleBackColor = true;
        btnPreviewPrint.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnClose
        // 
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClose.Location = new System.Drawing.Point(51, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(100, 38);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(166, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Sổ chứng chỉ";
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlFilterBar.Controls.Add(cboYearFilter);
        pnlFilterBar.Controls.Add(cboCourseFilter);
        pnlFilterBar.Controls.Add(txtSearch);
        pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilterBar.Location = new System.Drawing.Point(0, 78);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
        pnlFilterBar.Size = new System.Drawing.Size(1200, 46);
        pnlFilterBar.TabIndex = 2;
        // 
        // cboYearFilter
        // 
        cboYearFilter.BackColor = System.Drawing.Color.Transparent;
        cboYearFilter.CornerRadius = 5;
        cboYearFilter.DataSource = null;
        cboYearFilter.DisplayMember = "";
        cboYearFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboYearFilter.Location = new System.Drawing.Point(465, 7);
        cboYearFilter.Name = "cboYearFilter";
        cboYearFilter.SelectedIndex = -1;
        cboYearFilter.SelectedItem = null;
        cboYearFilter.SelectedValue = null;
        cboYearFilter.Size = new System.Drawing.Size(130, 32);
        cboYearFilter.TabIndex = 2;
        cboYearFilter.ValueMember = "";
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.BackColor = System.Drawing.Color.Transparent;
        cboCourseFilter.CornerRadius = 5;
        cboCourseFilter.DataSource = null;
        cboCourseFilter.DisplayMember = "";
        cboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboCourseFilter.Location = new System.Drawing.Point(295, 7);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.SelectedIndex = -1;
        cboCourseFilter.SelectedItem = null;
        cboCourseFilter.SelectedValue = null;
        cboCourseFilter.Size = new System.Drawing.Size(160, 32);
        cboCourseFilter.TabIndex = 1;
        cboCourseFilter.ValueMember = "";
        // 
        // txtSearch
        // 
        txtSearch.BackColor = System.Drawing.Color.Transparent;
        txtSearch.CornerRadius = 5;
        txtSearch.ErrorMessage = "";
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtSearch.HasError = false;
        txtSearch.Location = new System.Drawing.Point(24, 6);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "⌕  Tìm số chứng chỉ, học viên...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(260, 34);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
        pnlBody.Controls.Add(cardRegistryList, 0, 0);
        pnlBody.Controls.Add(cardDetail, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 124);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(1200, 616);
        pnlBody.TabIndex = 3;
        // 
        // cardRegistryList
        // 
        cardRegistryList.BackColor = System.Drawing.Color.White;
        cardRegistryList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRegistryList.BorderWidth = 1;
        cardRegistryList.Controls.Add(lblGridFooter);
        cardRegistryList.Controls.Add(gridRegistry);
        cardRegistryList.Controls.Add(lblListTitle);
        cardRegistryList.CornerRadius = 6;
        cardRegistryList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRegistryList.Location = new System.Drawing.Point(23, 15);
        cardRegistryList.Name = "cardRegistryList";
        cardRegistryList.Padding = new System.Windows.Forms.Padding(16);
        cardRegistryList.Size = new System.Drawing.Size(713, 582);
        cardRegistryList.TabIndex = 0;
        // 
        // lblGridFooter
        // 
        lblGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblGridFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblGridFooter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblGridFooter.Location = new System.Drawing.Point(16, 541);
        lblGridFooter.Name = "lblGridFooter";
        lblGridFooter.Size = new System.Drawing.Size(681, 25);
        lblGridFooter.TabIndex = 2;
        lblGridFooter.Text = ("1–4 / 42 chứng chỉ                                                               " + "                                        ‹ Trước   [1]   2   Sau ›");
        // 
        // gridRegistry
        // 
        gridRegistry.AllowUserToAddRows = false;
        gridRegistry.AllowUserToDeleteRows = false;
        gridRegistry.AllowUserToResizeColumns = false;
        gridRegistry.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        gridRegistry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridRegistry.BackgroundColor = System.Drawing.Color.White;
        gridRegistry.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridRegistry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridRegistry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridRegistry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridRegistry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCertNo, colStudent, colClass, colDate, colStatus });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridRegistry.DefaultCellStyle = dataGridViewCellStyle3;
        gridRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
        gridRegistry.EnableHeadersVisualStyles = false;
        gridRegistry.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridRegistry.Location = new System.Drawing.Point(16, 16);
        gridRegistry.MultiSelect = false;
        gridRegistry.Name = "gridRegistry";
        gridRegistry.ReadOnly = true;
        gridRegistry.RowHeadersVisible = false;
        gridRegistry.RowHeadersWidth = 51;
        gridRegistry.ScrollBars = System.Windows.Forms.ScrollBars.None;
        gridRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridRegistry.Size = new System.Drawing.Size(681, 550);
        gridRegistry.TabIndex = 1;
        // 
        // colCertNo
        // 
        colCertNo.FillWeight = 24F;
        colCertNo.HeaderText = "Số chứng chỉ ↑";
        colCertNo.MinimumWidth = 6;
        colCertNo.Name = "colCertNo";
        colCertNo.ReadOnly = true;
        // 
        // colStudent
        // 
        colStudent.FillWeight = 26F;
        colStudent.HeaderText = "Học viên";
        colStudent.MinimumWidth = 6;
        colStudent.Name = "colStudent";
        colStudent.ReadOnly = true;
        // 
        // colClass
        // 
        colClass.FillWeight = 18F;
        colClass.HeaderText = "Lớp";
        colClass.MinimumWidth = 6;
        colClass.Name = "colClass";
        colClass.ReadOnly = true;
        // 
        // colDate
        // 
        colDate.FillWeight = 16F;
        colDate.HeaderText = "Ngày cấp";
        colDate.MinimumWidth = 6;
        colDate.Name = "colDate";
        colDate.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.FillWeight = 16F;
        colStatus.HeaderText = "Trạng thái";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // lblListTitle
        // 
        lblListTitle.AutoSize = true;
        lblListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblListTitle.Location = new System.Drawing.Point(16, 12);
        lblListTitle.Name = "lblListTitle";
        lblListTitle.Size = new System.Drawing.Size(194, 25);
        lblListTitle.TabIndex = 0;
        lblListTitle.Text = "Danh sách chứng chỉ";
        // 
        // cardDetail
        // 
        cardDetail.BackColor = System.Drawing.Color.White;
        cardDetail.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardDetail.BorderWidth = 1;
        cardDetail.Controls.Add(btnViewCertToPrint);
        cardDetail.Controls.Add(lblApproverVal);
        cardDetail.Controls.Add(lblApproverTitle);
        cardDetail.Controls.Add(lblIssueDateVal);
        cardDetail.Controls.Add(lblIssueDateTitle);
        cardDetail.Controls.Add(lblAttVal);
        cardDetail.Controls.Add(lblAttTitle);
        cardDetail.Controls.Add(lblAvgVal);
        cardDetail.Controls.Add(lblAvgTitle);
        cardDetail.Controls.Add(lblPeriodVal);
        cardDetail.Controls.Add(lblPeriodTitle);
        cardDetail.Controls.Add(lblClassVal);
        cardDetail.Controls.Add(lblClassTitle);
        cardDetail.Controls.Add(lblCourseVal);
        cardDetail.Controls.Add(lblCourseTitle);
        cardDetail.Controls.Add(lblDobVal);
        cardDetail.Controls.Add(lblDobTitle);
        cardDetail.Controls.Add(lblStudentVal);
        cardDetail.Controls.Add(lblStudentTitle);
        cardDetail.Controls.Add(lblDetailTitle);
        cardDetail.CornerRadius = 6;
        cardDetail.Dock = System.Windows.Forms.DockStyle.Fill;
        cardDetail.Location = new System.Drawing.Point(742, 15);
        cardDetail.Name = "cardDetail";
        cardDetail.Padding = new System.Windows.Forms.Padding(20);
        cardDetail.Size = new System.Drawing.Size(435, 582);
        cardDetail.TabIndex = 1;
        // 
        // btnViewCertToPrint
        // 
        btnViewCertToPrint.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnViewCertToPrint.CornerRadius = 5;
        btnViewCertToPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewCertToPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewCertToPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewCertToPrint.Location = new System.Drawing.Point(20, 375);
        btnViewCertToPrint.Name = "btnViewCertToPrint";
        btnViewCertToPrint.Size = new System.Drawing.Size(180, 38);
        btnViewCertToPrint.TabIndex = 19;
        btnViewCertToPrint.Text = "Xem chứng chỉ để in";
        btnViewCertToPrint.UseVisualStyleBackColor = true;
        btnViewCertToPrint.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblApproverVal
        // 
        lblApproverVal.AutoSize = true;
        lblApproverVal.Location = new System.Drawing.Point(135, 328);
        lblApproverVal.Name = "lblApproverVal";
        lblApproverVal.Size = new System.Drawing.Size(113, 20);
        lblApproverVal.TabIndex = 18;
        lblApproverVal.Text = "Trần Minh Quân";
        // 
        // lblApproverTitle
        // 
        lblApproverTitle.AutoSize = true;
        lblApproverTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblApproverTitle.Location = new System.Drawing.Point(20, 328);
        lblApproverTitle.Name = "lblApproverTitle";
        lblApproverTitle.Size = new System.Drawing.Size(124, 20);
        lblApproverTitle.TabIndex = 17;
        lblApproverTitle.Text = "Người phê duyệt:";
        // 
        // lblIssueDateVal
        // 
        lblIssueDateVal.AutoSize = true;
        lblIssueDateVal.Location = new System.Drawing.Point(135, 294);
        lblIssueDateVal.Name = "lblIssueDateVal";
        lblIssueDateVal.Size = new System.Drawing.Size(85, 20);
        lblIssueDateVal.TabIndex = 16;
        lblIssueDateVal.Text = "30/10/2026";
        // 
        // lblIssueDateTitle
        // 
        lblIssueDateTitle.AutoSize = true;
        lblIssueDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblIssueDateTitle.Location = new System.Drawing.Point(20, 294);
        lblIssueDateTitle.Name = "lblIssueDateTitle";
        lblIssueDateTitle.Size = new System.Drawing.Size(75, 20);
        lblIssueDateTitle.TabIndex = 15;
        lblIssueDateTitle.Text = "Ngày cấp:";
        // 
        // lblAttVal
        // 
        lblAttVal.AutoSize = true;
        lblAttVal.Location = new System.Drawing.Point(135, 260);
        lblAttVal.Name = "lblAttVal";
        lblAttVal.Size = new System.Drawing.Size(97, 20);
        lblAttVal.TabIndex = 14;
        lblAttVal.Text = "22/24 · 91,7%";
        // 
        // lblAttTitle
        // 
        lblAttTitle.AutoSize = true;
        lblAttTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAttTitle.Location = new System.Drawing.Point(20, 260);
        lblAttTitle.Name = "lblAttTitle";
        lblAttTitle.Size = new System.Drawing.Size(87, 20);
        lblAttTitle.TabIndex = 13;
        lblAttTitle.Text = "Chuyên cần:";
        // 
        // lblAvgVal
        // 
        lblAvgVal.AutoSize = true;
        lblAvgVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAvgVal.Location = new System.Drawing.Point(135, 226);
        lblAvgVal.Name = "lblAvgVal";
        lblAvgVal.Size = new System.Drawing.Size(142, 21);
        lblAvgVal.TabIndex = 12;
        lblAvgVal.Text = "7,7 / 10 · Loại Khá";
        // 
        // lblAvgTitle
        // 
        lblAvgTitle.AutoSize = true;
        lblAvgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblAvgTitle.Location = new System.Drawing.Point(20, 226);
        lblAvgTitle.Name = "lblAvgTitle";
        lblAvgTitle.Size = new System.Drawing.Size(82, 20);
        lblAvgTitle.TabIndex = 11;
        lblAvgTitle.Text = "Trung bình:";
        // 
        // lblPeriodVal
        // 
        lblPeriodVal.AutoSize = true;
        lblPeriodVal.Location = new System.Drawing.Point(135, 192);
        lblPeriodVal.Name = "lblPeriodVal";
        lblPeriodVal.Size = new System.Drawing.Size(161, 20);
        lblPeriodVal.TabIndex = 10;
        lblPeriodVal.Text = "03/08/26 – 23/10/2026";
        // 
        // lblPeriodTitle
        // 
        lblPeriodTitle.AutoSize = true;
        lblPeriodTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPeriodTitle.Location = new System.Drawing.Point(20, 192);
        lblPeriodTitle.Name = "lblPeriodTitle";
        lblPeriodTitle.Size = new System.Drawing.Size(102, 20);
        lblPeriodTitle.TabIndex = 9;
        lblPeriodTitle.Text = "Thời gian học:";
        // 
        // lblClassVal
        // 
        lblClassVal.AutoSize = true;
        lblClassVal.Location = new System.Drawing.Point(135, 158);
        lblClassVal.Name = "lblClassVal";
        lblClassVal.Size = new System.Drawing.Size(72, 20);
        lblClassVal.TabIndex = 8;
        lblClassVal.Text = "IELTS-F02";
        // 
        // lblClassTitle
        // 
        lblClassTitle.AutoSize = true;
        lblClassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblClassTitle.Location = new System.Drawing.Point(20, 158);
        lblClassTitle.Name = "lblClassTitle";
        lblClassTitle.Size = new System.Drawing.Size(37, 20);
        lblClassTitle.TabIndex = 7;
        lblClassTitle.Text = "Lớp:";
        // 
        // lblCourseVal
        // 
        lblCourseVal.AutoSize = true;
        lblCourseVal.Location = new System.Drawing.Point(135, 124);
        lblCourseVal.Name = "lblCourseVal";
        lblCourseVal.Size = new System.Drawing.Size(122, 20);
        lblCourseVal.TabIndex = 6;
        lblCourseVal.Text = "IELTS Foundation";
        // 
        // lblCourseTitle
        // 
        lblCourseTitle.AutoSize = true;
        lblCourseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCourseTitle.Location = new System.Drawing.Point(20, 124);
        lblCourseTitle.Name = "lblCourseTitle";
        lblCourseTitle.Size = new System.Drawing.Size(74, 20);
        lblCourseTitle.TabIndex = 5;
        lblCourseTitle.Text = "Khóa học:";
        // 
        // lblDobVal
        // 
        lblDobVal.AutoSize = true;
        lblDobVal.Location = new System.Drawing.Point(135, 90);
        lblDobVal.Name = "lblDobVal";
        lblDobVal.Size = new System.Drawing.Size(85, 20);
        lblDobVal.TabIndex = 4;
        lblDobVal.Text = "12/03/2007";
        // 
        // lblDobTitle
        // 
        lblDobTitle.AutoSize = true;
        lblDobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDobTitle.Location = new System.Drawing.Point(20, 90);
        lblDobTitle.Name = "lblDobTitle";
        lblDobTitle.Size = new System.Drawing.Size(77, 20);
        lblDobTitle.TabIndex = 3;
        lblDobTitle.Text = "Ngày sinh:";
        // 
        // lblStudentVal
        // 
        lblStudentVal.AutoSize = true;
        lblStudentVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentVal.Location = new System.Drawing.Point(135, 56);
        lblStudentVal.Name = "lblStudentVal";
        lblStudentVal.Size = new System.Drawing.Size(182, 21);
        lblStudentVal.TabIndex = 2;
        lblStudentVal.Text = "Trần Gia Bảo · HV-0204";
        // 
        // lblStudentTitle
        // 
        lblStudentTitle.AutoSize = true;
        lblStudentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentTitle.Location = new System.Drawing.Point(20, 56);
        lblStudentTitle.Name = "lblStudentTitle";
        lblStudentTitle.Size = new System.Drawing.Size(70, 20);
        lblStudentTitle.TabIndex = 1;
        lblStudentTitle.Text = "Học viên:";
        // 
        // lblDetailTitle
        // 
        lblDetailTitle.AutoSize = true;
        lblDetailTitle.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblDetailTitle.Location = new System.Drawing.Point(20, 16);
        lblDetailTitle.Name = "lblDetailTitle";
        lblDetailTitle.Size = new System.Drawing.Size(168, 28);
        lblDetailTitle.TabIndex = 0;
        lblDetailTitle.Text = "CC-2026-0042";
        // 
        // CertificateRegistryDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlFilterBar);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Sổ chứng chỉ · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlFilterBar.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardRegistryList.ResumeLayout(false);
        cardRegistryList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridRegistry).EndInit();
        cardDetail.ResumeLayout(false);
        cardDetail.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnPreviewPrint;
    private ECMS.UI.Controls.AppButton btnClose;

    private System.Windows.Forms.Panel pnlFilterBar;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboYearFilter;

    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private ECMS.UI.Controls.AppCard cardRegistryList;
    private System.Windows.Forms.Label lblListTitle;
    private ECMS.UI.Controls.AppDataGrid gridRegistry;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCertNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
    private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.Label lblGridFooter;

    private ECMS.UI.Controls.AppCard cardDetail;
    private System.Windows.Forms.Label lblDetailTitle;
    private System.Windows.Forms.Label lblStudentTitle;
    private System.Windows.Forms.Label lblStudentVal;
    private System.Windows.Forms.Label lblDobTitle;
    private System.Windows.Forms.Label lblDobVal;
    private System.Windows.Forms.Label lblCourseTitle;
    private System.Windows.Forms.Label lblCourseVal;
    private System.Windows.Forms.Label lblClassTitle;
    private System.Windows.Forms.Label lblClassVal;
    private System.Windows.Forms.Label lblPeriodTitle;
    private System.Windows.Forms.Label lblPeriodVal;
    private System.Windows.Forms.Label lblAvgTitle;
    private System.Windows.Forms.Label lblAvgVal;
    private System.Windows.Forms.Label lblAttTitle;
    private System.Windows.Forms.Label lblAttVal;
    private System.Windows.Forms.Label lblIssueDateTitle;
    private System.Windows.Forms.Label lblIssueDateVal;
    private System.Windows.Forms.Label lblApproverTitle;
    private System.Windows.Forms.Label lblApproverVal;
    private ECMS.UI.Controls.AppButton btnViewCertToPrint;
}
