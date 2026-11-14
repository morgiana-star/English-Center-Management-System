namespace ECMS.UI.Forms;

partial class ReportPreviewExportDialog
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
        btnSaveLocalTop = new ECMS.UI.Controls.AppButton();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        cardReportDocument = new ECMS.UI.Controls.AppCard();
        lblMetaIncludes = new System.Windows.Forms.Label();
        lblMetaAuthor = new System.Windows.Forms.Label();
        lblMetaTime = new System.Windows.Forms.Label();
        lblMetaSource = new System.Windows.Forms.Label();
        gridReportData = new ECMS.UI.Controls.AppDataGrid();
        colCourseGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colPaidInPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colRemainingReceivable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblReportPeriod = new System.Windows.Forms.Label();
        lblReportTitle = new System.Windows.Forms.Label();
        lblOrgName = new System.Windows.Forms.Label();
        cardExportSettings = new ECMS.UI.Controls.AppCard();
        pnlExportActions = new System.Windows.Forms.FlowLayoutPanel();
        btnConfirmSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlFolderBrowse = new System.Windows.Forms.Panel();
        btnBrowseFolder = new ECMS.UI.Controls.AppButton();
        txtFolder = new ECMS.UI.Controls.AppTextBox();
        lblFolderTitle = new System.Windows.Forms.Label();
        txtFileName = new ECMS.UI.Controls.AppTextBox();
        lblFileNameTitle = new System.Windows.Forms.Label();
        cboFormat = new ECMS.UI.Controls.AppComboBox();
        lblFormatTitle = new System.Windows.Forms.Label();
        lblExportTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlBody.SuspendLayout();
        cardReportDocument.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridReportData).BeginInit();
        cardExportSettings.SuspendLayout();
        pnlExportActions.SuspendLayout();
        pnlFolderBrowse.SuspendLayout();
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
        pnlTopActions.Controls.Add(btnSaveLocalTop);
        pnlTopActions.Controls.Add(btnClose);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(870, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnSaveLocalTop
        // 
        btnSaveLocalTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveLocalTop.CornerRadius = 5;
        btnSaveLocalTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveLocalTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveLocalTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveLocalTop.Location = new System.Drawing.Point(157, 3);
        btnSaveLocalTop.Name = "btnSaveLocalTop";
        btnSaveLocalTop.Size = new System.Drawing.Size(140, 38);
        btnSaveLocalTop.TabIndex = 0;
        btnSaveLocalTop.Text = "Lưu tệp cục bộ";
        btnSaveLocalTop.UseVisualStyleBackColor = true;
        btnSaveLocalTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
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
        lblTitle.Size = new System.Drawing.Size(346, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xem trước báo cáo tài chính";
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
        pnlBody.Controls.Add(cardReportDocument, 0, 0);
        pnlBody.Controls.Add(cardExportSettings, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 78);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(1200, 662);
        pnlBody.TabIndex = 1;
        // 
        // cardReportDocument
        // 
        cardReportDocument.BackColor = System.Drawing.Color.White;
        cardReportDocument.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardReportDocument.BorderWidth = 1;
        cardReportDocument.Controls.Add(lblMetaIncludes);
        cardReportDocument.Controls.Add(lblMetaAuthor);
        cardReportDocument.Controls.Add(lblMetaTime);
        cardReportDocument.Controls.Add(lblMetaSource);
        cardReportDocument.Controls.Add(gridReportData);
        cardReportDocument.Controls.Add(lblReportPeriod);
        cardReportDocument.Controls.Add(lblReportTitle);
        cardReportDocument.Controls.Add(lblOrgName);
        cardReportDocument.CornerRadius = 6;
        cardReportDocument.Dock = System.Windows.Forms.DockStyle.Fill;
        cardReportDocument.Location = new System.Drawing.Point(23, 15);
        cardReportDocument.Name = "cardReportDocument";
        cardReportDocument.Padding = new System.Windows.Forms.Padding(24);
        cardReportDocument.Size = new System.Drawing.Size(713, 628);
        cardReportDocument.TabIndex = 0;
        // 
        // lblMetaIncludes
        // 
        lblMetaIncludes.AutoSize = true;
        lblMetaIncludes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMetaIncludes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblMetaIncludes.Location = new System.Drawing.Point(24, 385);
        lblMetaIncludes.Name = "lblMetaIncludes";
        lblMetaIncludes.Size = new System.Drawing.Size(366, 20);
        lblMetaIncludes.TabIndex = 7;
        lblMetaIncludes.Text = "Bao gồm khoản thu:   PT-261030-018 · 1.500.000đ";
        // 
        // lblMetaAuthor
        // 
        lblMetaAuthor.AutoSize = true;
        lblMetaAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMetaAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblMetaAuthor.Location = new System.Drawing.Point(24, 355);
        lblMetaAuthor.Name = "lblMetaAuthor";
        lblMetaAuthor.Size = new System.Drawing.Size(195, 20);
        lblMetaAuthor.TabIndex = 6;
        lblMetaAuthor.Text = "Người lập:   Trần Minh Quân";
        // 
        // lblMetaTime
        // 
        lblMetaTime.AutoSize = true;
        lblMetaTime.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMetaTime.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblMetaTime.Location = new System.Drawing.Point(24, 330);
        lblMetaTime.Name = "lblMetaTime";
        lblMetaTime.Size = new System.Drawing.Size(281, 20);
        lblMetaTime.TabIndex = 5;
        lblMetaTime.Text = "Thời điểm tổng hợp:   30/10/2026 - 16:20";
        // 
        // lblMetaSource
        // 
        lblMetaSource.AutoSize = true;
        lblMetaSource.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMetaSource.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblMetaSource.Location = new System.Drawing.Point(24, 305);
        lblMetaSource.Name = "lblMetaSource";
        lblMetaSource.Size = new System.Drawing.Size(276, 20);
        lblMetaSource.TabIndex = 4;
        lblMetaSource.Text = "Nguồn dữ liệu:   SQLite cục bộ · ecms.db";
        // 
        // gridReportData
        // 
        gridReportData.AllowUserToAddRows = false;
        gridReportData.AllowUserToDeleteRows = false;
        gridReportData.AllowUserToResizeColumns = false;
        gridReportData.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        gridReportData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridReportData.BackgroundColor = System.Drawing.Color.White;
        gridReportData.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridReportData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridReportData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridReportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCourseGroup, colPaidInPeriod, colRemainingReceivable });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridReportData.DefaultCellStyle = dataGridViewCellStyle3;
        gridReportData.EnableHeadersVisualStyles = false;
        gridReportData.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridReportData.Location = new System.Drawing.Point(24, 115);
        gridReportData.MultiSelect = false;
        gridReportData.Name = "gridReportData";
        gridReportData.ReadOnly = true;
        gridReportData.RowHeadersVisible = false;
        gridReportData.RowHeadersWidth = 51;
        gridReportData.ScrollBars = System.Windows.Forms.ScrollBars.None;
        gridReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridReportData.Size = new System.Drawing.Size(665, 170);
        gridReportData.TabIndex = 3;
        // 
        // colCourseGroup
        // 
        colCourseGroup.FillWeight = 40F;
        colCourseGroup.HeaderText = "Nhóm khóa ↑";
        colCourseGroup.MinimumWidth = 6;
        colCourseGroup.Name = "colCourseGroup";
        colCourseGroup.ReadOnly = true;
        // 
        // colPaidInPeriod
        // 
        colPaidInPeriod.FillWeight = 30F;
        colPaidInPeriod.HeaderText = "Đã thu trong kỳ";
        colPaidInPeriod.MinimumWidth = 6;
        colPaidInPeriod.Name = "colPaidInPeriod";
        colPaidInPeriod.ReadOnly = true;
        // 
        // colRemainingReceivable
        // 
        colRemainingReceivable.FillWeight = 30F;
        colRemainingReceivable.HeaderText = "Còn phải thu";
        colRemainingReceivable.MinimumWidth = 6;
        colRemainingReceivable.Name = "colRemainingReceivable";
        colRemainingReceivable.ReadOnly = true;
        // 
        // lblReportPeriod
        // 
        lblReportPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblReportPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblReportPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblReportPeriod.Location = new System.Drawing.Point(24, 80);
        lblReportPeriod.Name = "lblReportPeriod";
        lblReportPeriod.Size = new System.Drawing.Size(665, 20);
        lblReportPeriod.TabIndex = 2;
        lblReportPeriod.Text = "Từ 01/10/2026 đến 30/10/2026 · Tất cả khóa / lớp";
        lblReportPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblReportTitle
        // 
        lblReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblReportTitle.Location = new System.Drawing.Point(24, 45);
        lblReportTitle.Name = "lblReportTitle";
        lblReportTitle.Size = new System.Drawing.Size(665, 30);
        lblReportTitle.TabIndex = 1;
        lblReportTitle.Text = "BÁO CÁO THU HỌC PHÍ & CÔNG NỢ";
        lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblOrgName
        // 
        lblOrgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblOrgName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblOrgName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblOrgName.Location = new System.Drawing.Point(24, 20);
        lblOrgName.Name = "lblOrgName";
        lblOrgName.Size = new System.Drawing.Size(665, 20);
        lblOrgName.TabIndex = 0;
        lblOrgName.Text = "TRUNG TÂM ANH NGỮ MINH TRÍ";
        lblOrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // cardExportSettings
        // 
        cardExportSettings.BackColor = System.Drawing.Color.White;
        cardExportSettings.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardExportSettings.BorderWidth = 1;
        cardExportSettings.Controls.Add(pnlExportActions);
        cardExportSettings.Controls.Add(pnlFolderBrowse);
        cardExportSettings.Controls.Add(lblFolderTitle);
        cardExportSettings.Controls.Add(txtFileName);
        cardExportSettings.Controls.Add(lblFileNameTitle);
        cardExportSettings.Controls.Add(cboFormat);
        cardExportSettings.Controls.Add(lblFormatTitle);
        cardExportSettings.Controls.Add(lblExportTitle);
        cardExportSettings.CornerRadius = 6;
        cardExportSettings.Dock = System.Windows.Forms.DockStyle.Fill;
        cardExportSettings.Location = new System.Drawing.Point(742, 15);
        cardExportSettings.Name = "cardExportSettings";
        cardExportSettings.Padding = new System.Windows.Forms.Padding(20);
        cardExportSettings.Size = new System.Drawing.Size(435, 628);
        cardExportSettings.TabIndex = 1;
        // 
        // pnlExportActions
        // 
        pnlExportActions.Controls.Add(btnConfirmSave);
        pnlExportActions.Controls.Add(btnCancel);
        pnlExportActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlExportActions.Location = new System.Drawing.Point(20, 345);
        pnlExportActions.Name = "pnlExportActions";
        pnlExportActions.Size = new System.Drawing.Size(390, 48);
        pnlExportActions.TabIndex = 8;
        // 
        // btnConfirmSave
        // 
        btnConfirmSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmSave.CornerRadius = 5;
        btnConfirmSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmSave.Location = new System.Drawing.Point(237, 3);
        btnConfirmSave.Name = "btnConfirmSave";
        btnConfirmSave.Size = new System.Drawing.Size(150, 38);
        btnConfirmSave.TabIndex = 0;
        btnConfirmSave.Text = "Xác nhận lưu tệp";
        btnConfirmSave.UseVisualStyleBackColor = true;
        btnConfirmSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(141, 3);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 38);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlFolderBrowse
        // 
        pnlFolderBrowse.Controls.Add(btnBrowseFolder);
        pnlFolderBrowse.Controls.Add(txtFolder);
        pnlFolderBrowse.Location = new System.Drawing.Point(20, 216);
        pnlFolderBrowse.Name = "pnlFolderBrowse";
        pnlFolderBrowse.Size = new System.Drawing.Size(390, 40);
        pnlFolderBrowse.TabIndex = 6;
        // 
        // btnBrowseFolder
        // 
        btnBrowseFolder.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBrowseFolder.CornerRadius = 5;
        btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBrowseFolder.Dock = System.Windows.Forms.DockStyle.Right;
        btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBrowseFolder.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnBrowseFolder.Location = new System.Drawing.Point(275, 0);
        btnBrowseFolder.Name = "btnBrowseFolder";
        btnBrowseFolder.Size = new System.Drawing.Size(115, 40);
        btnBrowseFolder.TabIndex = 1;
        btnBrowseFolder.Text = "Chọn thư mục...";
        btnBrowseFolder.UseVisualStyleBackColor = true;
        btnBrowseFolder.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtFolder
        // 
        txtFolder.BackColor = System.Drawing.Color.Transparent;
        txtFolder.CornerRadius = 5;
        txtFolder.Dock = System.Windows.Forms.DockStyle.Left;
        txtFolder.ErrorMessage = "";
        txtFolder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtFolder.HasError = false;
        txtFolder.Location = new System.Drawing.Point(0, 0);
        txtFolder.Name = "txtFolder";
        txtFolder.Placeholder = "";
        txtFolder.ReadOnly = false;
        txtFolder.Size = new System.Drawing.Size(265, 40);
        txtFolder.TabIndex = 0;
        txtFolder.UseSystemPasswordChar = false;
        // 
        // lblFolderTitle
        // 
        lblFolderTitle.AutoSize = true;
        lblFolderTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFolderTitle.Location = new System.Drawing.Point(20, 196);
        lblFolderTitle.Name = "lblFolderTitle";
        lblFolderTitle.Size = new System.Drawing.Size(82, 20);
        lblFolderTitle.TabIndex = 5;
        lblFolderTitle.Text = "Thư mục *";
        // 
        // txtFileName
        // 
        txtFileName.BackColor = System.Drawing.Color.Transparent;
        txtFileName.CornerRadius = 5;
        txtFileName.ErrorMessage = "";
        txtFileName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtFileName.HasError = false;
        txtFileName.Location = new System.Drawing.Point(20, 146);
        txtFileName.Name = "txtFileName";
        txtFileName.Placeholder = "";
        txtFileName.ReadOnly = false;
        txtFileName.Size = new System.Drawing.Size(390, 36);
        txtFileName.TabIndex = 4;
        txtFileName.UseSystemPasswordChar = false;
        // 
        // lblFileNameTitle
        // 
        lblFileNameTitle.AutoSize = true;
        lblFileNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFileNameTitle.Location = new System.Drawing.Point(20, 126);
        lblFileNameTitle.Name = "lblFileNameTitle";
        lblFileNameTitle.Size = new System.Drawing.Size(72, 20);
        lblFileNameTitle.TabIndex = 3;
        lblFileNameTitle.Text = "Tên tệp *";
        // 
        // cboFormat
        // 
        cboFormat.BackColor = System.Drawing.Color.Transparent;
        cboFormat.CornerRadius = 5;
        cboFormat.DataSource = null;
        cboFormat.DisplayMember = "";
        cboFormat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboFormat.Location = new System.Drawing.Point(20, 76);
        cboFormat.Name = "cboFormat";
        cboFormat.SelectedIndex = -1;
        cboFormat.SelectedItem = null;
        cboFormat.SelectedValue = null;
        cboFormat.Size = new System.Drawing.Size(390, 35);
        cboFormat.TabIndex = 2;
        cboFormat.ValueMember = "";
        // 
        // lblFormatTitle
        // 
        lblFormatTitle.AutoSize = true;
        lblFormatTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFormatTitle.Location = new System.Drawing.Point(20, 56);
        lblFormatTitle.Name = "lblFormatTitle";
        lblFormatTitle.Size = new System.Drawing.Size(81, 20);
        lblFormatTitle.TabIndex = 1;
        lblFormatTitle.Text = "Định dạng";
        // 
        // lblExportTitle
        // 
        lblExportTitle.AutoSize = true;
        lblExportTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblExportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblExportTitle.Location = new System.Drawing.Point(20, 16);
        lblExportTitle.Name = "lblExportTitle";
        lblExportTitle.Size = new System.Drawing.Size(186, 25);
        lblExportTitle.TabIndex = 0;
        lblExportTitle.Text = "Lưu báo cáo cục bộ";
        // 
        // ReportPreviewExportDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xem trước & Xuất báo cáo tài chính · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardReportDocument.ResumeLayout(false);
        cardReportDocument.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridReportData).EndInit();
        cardExportSettings.ResumeLayout(false);
        cardExportSettings.PerformLayout();
        pnlExportActions.ResumeLayout(false);
        pnlFolderBrowse.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnSaveLocalTop;
    private ECMS.UI.Controls.AppButton btnClose;

    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private ECMS.UI.Controls.AppCard cardReportDocument;
    private System.Windows.Forms.Label lblOrgName;
    private System.Windows.Forms.Label lblReportTitle;
    private System.Windows.Forms.Label lblReportPeriod;
    private ECMS.UI.Controls.AppDataGrid gridReportData;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCourseGroup;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPaidInPeriod;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingReceivable;
    private System.Windows.Forms.Label lblMetaSource;
    private System.Windows.Forms.Label lblMetaTime;
    private System.Windows.Forms.Label lblMetaAuthor;
    private System.Windows.Forms.Label lblMetaIncludes;

    private ECMS.UI.Controls.AppCard cardExportSettings;
    private System.Windows.Forms.Label lblExportTitle;
    private System.Windows.Forms.Label lblFormatTitle;
    private ECMS.UI.Controls.AppComboBox cboFormat;
    private System.Windows.Forms.Label lblFileNameTitle;
    private ECMS.UI.Controls.AppTextBox txtFileName;
    private System.Windows.Forms.Label lblFolderTitle;
    private System.Windows.Forms.Panel pnlFolderBrowse;
    private ECMS.UI.Controls.AppTextBox txtFolder;
    private ECMS.UI.Controls.AppButton btnBrowseFolder;
    private System.Windows.Forms.FlowLayoutPanel pnlExportActions;
    private ECMS.UI.Controls.AppButton btnConfirmSave;
    private ECMS.UI.Controls.AppButton btnCancel;
}
