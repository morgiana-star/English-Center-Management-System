namespace ECMS.UI.UserControls;

partial class TuitionPaymentView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnExportDebt = new ECMS.UI.Controls.AppButton();
        btnCollectTuition = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabHistory = new System.Windows.Forms.Button();
        btnTabDebt = new System.Windows.Forms.Button();
        btnTabProfiles = new System.Windows.Forms.Button();
        pnlFilter = new System.Windows.Forms.Panel();
        cboClassFilter = new System.Windows.Forms.ComboBox();
        cboStatusFilter = new System.Windows.Forms.ComboBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardProfiles = new ECMS.UI.Controls.AppCard();
        gridProfiles = new ECMS.UI.Controls.AppDataGrid();
        pnlProfileSummary = new System.Windows.Forms.Panel();
        cardSumRemaining = new ECMS.UI.Controls.AppCard();
        lblSumRemainingVal = new System.Windows.Forms.Label();
        lblSumRemainingTitle = new System.Windows.Forms.Label();
        cardSumPaid = new ECMS.UI.Controls.AppCard();
        lblSumPaidVal = new System.Windows.Forms.Label();
        lblSumPaidTitle = new System.Windows.Forms.Label();
        cardSumTotal = new ECMS.UI.Controls.AppCard();
        lblSumTotalVal = new System.Windows.Forms.Label();
        lblSumTotalTitle = new System.Windows.Forms.Label();
        lblProfilesTitle = new System.Windows.Forms.Label();
        cardDebt = new ECMS.UI.Controls.AppCard();
        lblDebtorsFooter = new System.Windows.Forms.Label();
        gridDebtors = new ECMS.UI.Controls.AppDataGrid();
        lblDebtTitle = new System.Windows.Forms.Label();
        cardHistory = new ECMS.UI.Controls.AppCard();
        lblHistoryFooter = new System.Windows.Forms.Label();
        gridHistory = new ECMS.UI.Controls.AppDataGrid();
        lblHistoryTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardProfiles.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridProfiles).BeginInit();
        pnlProfileSummary.SuspendLayout();
        cardSumRemaining.SuspendLayout();
        cardSumPaid.SuspendLayout();
        cardSumTotal.SuspendLayout();
        cardDebt.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridDebtors).BeginInit();
        cardHistory.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnExportDebt);
        pnlHeader.Controls.Add(btnCollectTuition);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(1200, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnExportDebt
        // 
        btnExportDebt.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnExportDebt.BackColor = System.Drawing.Color.White;
        btnExportDebt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportDebt.CornerRadius = 5;
        btnExportDebt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportDebt.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExportDebt.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnExportDebt.Location = new System.Drawing.Point(920, 18);
        btnExportDebt.Name = "btnExportDebt";
        btnExportDebt.Size = new System.Drawing.Size(120, 38);
        btnExportDebt.TabIndex = 1;
        btnExportDebt.Text = "Xuất báo cáo";
        btnExportDebt.UseVisualStyleBackColor = false;
        btnExportDebt.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnCollectTuition
        // 
        btnCollectTuition.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCollectTuition.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnCollectTuition.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCollectTuition.CornerRadius = 5;
        btnCollectTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCollectTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCollectTuition.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCollectTuition.ForeColor = System.Drawing.Color.White;
        btnCollectTuition.Location = new System.Drawing.Point(1050, 18);
        btnCollectTuition.Name = "btnCollectTuition";
        btnCollectTuition.Size = new System.Drawing.Size(130, 38);
        btnCollectTuition.TabIndex = 2;
        btnCollectTuition.Text = "+ Thu học phí";
        btnCollectTuition.UseVisualStyleBackColor = false;
        btnCollectTuition.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(253, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Học phí & Thanh toán";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = System.Drawing.Color.White;
        pnlTabs.Controls.Add(btnTabHistory);
        pnlTabs.Controls.Add(btnTabDebt);
        pnlTabs.Controls.Add(btnTabProfiles);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(0, 75);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlTabs.Size = new System.Drawing.Size(1200, 44);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabHistory
        // 
        btnTabHistory.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabHistory.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabHistory.FlatAppearance.BorderSize = 0;
        btnTabHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnTabHistory.Location = new System.Drawing.Point(344, 0);
        btnTabHistory.Name = "btnTabHistory";
        btnTabHistory.Size = new System.Drawing.Size(160, 44);
        btnTabHistory.TabIndex = 2;
        btnTabHistory.Text = "3. Lịch sử thu";
        btnTabHistory.UseVisualStyleBackColor = true;
        // 
        // btnTabDebt
        // 
        btnTabDebt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabDebt.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabDebt.FlatAppearance.BorderSize = 0;
        btnTabDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabDebt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabDebt.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnTabDebt.Location = new System.Drawing.Point(184, 0);
        btnTabDebt.Name = "btnTabDebt";
        btnTabDebt.Size = new System.Drawing.Size(160, 44);
        btnTabDebt.TabIndex = 1;
        btnTabDebt.Text = "2. Công nợ";
        btnTabDebt.UseVisualStyleBackColor = true;
        // 
        // btnTabProfiles
        // 
        btnTabProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabProfiles.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabProfiles.FlatAppearance.BorderSize = 0;
        btnTabProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabProfiles.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnTabProfiles.Location = new System.Drawing.Point(24, 0);
        btnTabProfiles.Name = "btnTabProfiles";
        btnTabProfiles.Size = new System.Drawing.Size(160, 44);
        btnTabProfiles.TabIndex = 0;
        btnTabProfiles.Text = "1. Hồ sơ học phí";
        btnTabProfiles.UseVisualStyleBackColor = true;
        // 
        // pnlFilter
        // 
        pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlFilter.Controls.Add(cboClassFilter);
        pnlFilter.Controls.Add(cboStatusFilter);
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Controls.Add(lblSearch);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(0, 119);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlFilter.Size = new System.Drawing.Size(1200, 50);
        pnlFilter.TabIndex = 2;
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboClassFilter.FormattingEnabled = true;
        cboClassFilter.Location = new System.Drawing.Point(1020, 10);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(155, 29);
        cboClassFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStatusFilter.FormattingEnabled = true;
        cboStatusFilter.Location = new System.Drawing.Point(825, 10);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(185, 29);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.Location = new System.Drawing.Point(115, 10);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Tìm theo mã học viên, họ và tên, lớp học...";
        txtSearch.Size = new System.Drawing.Size(430, 29);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSearch.Location = new System.Drawing.Point(24, 14);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(78, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm:";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlBody.Controls.Add(cardProfiles);
        pnlBody.Controls.Add(cardDebt);
        pnlBody.Controls.Add(cardHistory);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 169);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 14, 24, 18);
        pnlBody.Size = new System.Drawing.Size(1200, 631);
        pnlBody.TabIndex = 3;
        // 
        // cardProfiles
        // 
        cardProfiles.BackColor = System.Drawing.Color.White;
        cardProfiles.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardProfiles.BorderWidth = 1;
        cardProfiles.Controls.Add(gridProfiles);
        cardProfiles.Controls.Add(pnlProfileSummary);
        cardProfiles.Controls.Add(lblProfilesTitle);
        cardProfiles.CornerRadius = 8;
        cardProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
        cardProfiles.Location = new System.Drawing.Point(24, 14);
        cardProfiles.Name = "cardProfiles";
        cardProfiles.Padding = new System.Windows.Forms.Padding(16);
        cardProfiles.Size = new System.Drawing.Size(1152, 599);
        cardProfiles.TabIndex = 0;
        // 
        // gridProfiles
        // 
        gridProfiles.AllowUserToAddRows = false;
        gridProfiles.AllowUserToDeleteRows = false;
        gridProfiles.AllowUserToResizeColumns = false;
        gridProfiles.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        gridProfiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridProfiles.BackgroundColor = System.Drawing.Color.White;
        gridProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridProfiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridProfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridProfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridProfiles.ColumnHeadersHeight = 38;
        gridProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridProfiles.DefaultCellStyle = dataGridViewCellStyle3;
        gridProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
        gridProfiles.EnableHeadersVisualStyles = false;
        gridProfiles.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridProfiles.Location = new System.Drawing.Point(16, 44);
        gridProfiles.MultiSelect = false;
        gridProfiles.Name = "gridProfiles";
        gridProfiles.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridProfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        gridProfiles.RowHeadersVisible = false;
        gridProfiles.RowHeadersWidth = 51;
        gridProfiles.RowTemplate.Height = 42;
        gridProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridProfiles.Size = new System.Drawing.Size(1120, 467);
        gridProfiles.TabIndex = 1;
        // 
        // pnlProfileSummary
        // 
        pnlProfileSummary.Controls.Add(cardSumRemaining);
        pnlProfileSummary.Controls.Add(cardSumPaid);
        pnlProfileSummary.Controls.Add(cardSumTotal);
        pnlProfileSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlProfileSummary.Location = new System.Drawing.Point(16, 511);
        pnlProfileSummary.Name = "pnlProfileSummary";
        pnlProfileSummary.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
        pnlProfileSummary.Size = new System.Drawing.Size(1120, 72);
        pnlProfileSummary.TabIndex = 2;
        // 
        // cardSumRemaining
        // 
        cardSumRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardSumRemaining.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)242)), ((int)((byte)242)));
        cardSumRemaining.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)202)), ((int)((byte)202)));
        cardSumRemaining.BorderWidth = 1;
        cardSumRemaining.Controls.Add(lblSumRemainingVal);
        cardSumRemaining.Controls.Add(lblSumRemainingTitle);
        cardSumRemaining.CornerRadius = 6;
        cardSumRemaining.Location = new System.Drawing.Point(755, 10);
        cardSumRemaining.Name = "cardSumRemaining";
        cardSumRemaining.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        cardSumRemaining.Size = new System.Drawing.Size(360, 52);
        cardSumRemaining.TabIndex = 2;
        // 
        // lblSumRemainingVal
        // 
        lblSumRemainingVal.Dock = System.Windows.Forms.DockStyle.Right;
        lblSumRemainingVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSumRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblSumRemainingVal.Location = new System.Drawing.Point(160, 6);
        lblSumRemainingVal.Name = "lblSumRemainingVal";
        lblSumRemainingVal.Size = new System.Drawing.Size(188, 40);
        lblSumRemainingVal.TabIndex = 1;
        lblSumRemainingVal.Text = "10.700.000 đ";
        lblSumRemainingVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSumRemainingTitle
        // 
        lblSumRemainingTitle.Dock = System.Windows.Forms.DockStyle.Left;
        lblSumRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSumRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)153)), ((int)((byte)27)), ((int)((byte)27)));
        lblSumRemainingTitle.Location = new System.Drawing.Point(12, 6);
        lblSumRemainingTitle.Name = "lblSumRemainingTitle";
        lblSumRemainingTitle.Size = new System.Drawing.Size(173, 40);
        lblSumRemainingTitle.TabIndex = 0;
        lblSumRemainingTitle.Text = "Tổng còn phải thu:";
        lblSumRemainingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cardSumPaid
        // 
        cardSumPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardSumPaid.BackColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)253)), ((int)((byte)244)));
        cardSumPaid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)187)), ((int)((byte)247)), ((int)((byte)208)));
        cardSumPaid.BorderWidth = 1;
        cardSumPaid.Controls.Add(lblSumPaidVal);
        cardSumPaid.Controls.Add(lblSumPaidTitle);
        cardSumPaid.CornerRadius = 6;
        cardSumPaid.Location = new System.Drawing.Point(380, 10);
        cardSumPaid.Name = "cardSumPaid";
        cardSumPaid.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        cardSumPaid.Size = new System.Drawing.Size(360, 52);
        cardSumPaid.TabIndex = 1;
        // 
        // lblSumPaidVal
        // 
        lblSumPaidVal.Dock = System.Windows.Forms.DockStyle.Right;
        lblSumPaidVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSumPaidVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblSumPaidVal.Location = new System.Drawing.Point(160, 6);
        lblSumPaidVal.Name = "lblSumPaidVal";
        lblSumPaidVal.Size = new System.Drawing.Size(188, 40);
        lblSumPaidVal.TabIndex = 1;
        lblSumPaidVal.Text = "73.900.000 đ";
        lblSumPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSumPaidTitle
        // 
        lblSumPaidTitle.Dock = System.Windows.Forms.DockStyle.Left;
        lblSumPaidTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSumPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)101)), ((int)((byte)52)));
        lblSumPaidTitle.Location = new System.Drawing.Point(12, 6);
        lblSumPaidTitle.Name = "lblSumPaidTitle";
        lblSumPaidTitle.Size = new System.Drawing.Size(145, 40);
        lblSumPaidTitle.TabIndex = 0;
        lblSumPaidTitle.Text = "Tổng đã thu:";
        lblSumPaidTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cardSumTotal
        // 
        cardSumTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardSumTotal.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        cardSumTotal.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)191)), ((int)((byte)219)), ((int)((byte)254)));
        cardSumTotal.BorderWidth = 1;
        cardSumTotal.Controls.Add(lblSumTotalVal);
        cardSumTotal.Controls.Add(lblSumTotalTitle);
        cardSumTotal.CornerRadius = 6;
        cardSumTotal.Location = new System.Drawing.Point(5, 10);
        cardSumTotal.Name = "cardSumTotal";
        cardSumTotal.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        cardSumTotal.Size = new System.Drawing.Size(360, 52);
        cardSumTotal.TabIndex = 0;
        // 
        // lblSumTotalVal
        // 
        lblSumTotalVal.Dock = System.Windows.Forms.DockStyle.Right;
        lblSumTotalVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSumTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSumTotalVal.Location = new System.Drawing.Point(160, 6);
        lblSumTotalVal.Name = "lblSumTotalVal";
        lblSumTotalVal.Size = new System.Drawing.Size(188, 40);
        lblSumTotalVal.TabIndex = 1;
        lblSumTotalVal.Text = "84.600.000 đ";
        lblSumTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSumTotalTitle
        // 
        lblSumTotalTitle.Dock = System.Windows.Forms.DockStyle.Left;
        lblSumTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSumTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)64)), ((int)((byte)175)));
        lblSumTotalTitle.Location = new System.Drawing.Point(12, 6);
        lblSumTotalTitle.Name = "lblSumTotalTitle";
        lblSumTotalTitle.Size = new System.Drawing.Size(145, 40);
        lblSumTotalTitle.TabIndex = 0;
        lblSumTotalTitle.Text = "Tổng phải thu:";
        lblSumTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblProfilesTitle
        // 
        lblProfilesTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblProfilesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblProfilesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblProfilesTitle.Location = new System.Drawing.Point(16, 16);
        lblProfilesTitle.Name = "lblProfilesTitle";
        lblProfilesTitle.Size = new System.Drawing.Size(1120, 28);
        lblProfilesTitle.TabIndex = 0;
        lblProfilesTitle.Text = "HỒ SƠ HỌC PHÍ HỌC VIÊN TOÀN TRUNG TÂM";
        // 
        // cardDebt
        // 
        cardDebt.BackColor = System.Drawing.Color.White;
        cardDebt.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardDebt.BorderWidth = 1;
        cardDebt.Controls.Add(lblDebtorsFooter);
        cardDebt.Controls.Add(gridDebtors);
        cardDebt.Controls.Add(lblDebtTitle);
        cardDebt.CornerRadius = 8;
        cardDebt.Dock = System.Windows.Forms.DockStyle.Fill;
        cardDebt.Location = new System.Drawing.Point(24, 14);
        cardDebt.Name = "cardDebt";
        cardDebt.Padding = new System.Windows.Forms.Padding(16);
        cardDebt.Size = new System.Drawing.Size(1152, 599);
        cardDebt.TabIndex = 1;
        cardDebt.Visible = false;
        // 
        // lblDebtorsFooter
        // 
        lblDebtorsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblDebtorsFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblDebtorsFooter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDebtorsFooter.Location = new System.Drawing.Point(16, 555);
        lblDebtorsFooter.Name = "lblDebtorsFooter";
        lblDebtorsFooter.Size = new System.Drawing.Size(1120, 28);
        lblDebtorsFooter.TabIndex = 2;
        lblDebtorsFooter.Text = ("📌 Nhấn \'💵 Thu tiền\' tại học viên bất kỳ để mở hộp thoại thu học phí và tự động " + "lập phiếu thu.");
        // 
        // gridDebtors
        // 
        gridDebtors.AllowUserToAddRows = false;
        gridDebtors.AllowUserToDeleteRows = false;
        gridDebtors.AllowUserToResizeColumns = false;
        gridDebtors.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        gridDebtors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        gridDebtors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridDebtors.BackgroundColor = System.Drawing.Color.White;
        gridDebtors.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridDebtors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridDebtors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridDebtors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        gridDebtors.ColumnHeadersHeight = 38;
        gridDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridDebtors.DefaultCellStyle = dataGridViewCellStyle7;
        gridDebtors.Dock = System.Windows.Forms.DockStyle.Fill;
        gridDebtors.EnableHeadersVisualStyles = false;
        gridDebtors.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridDebtors.Location = new System.Drawing.Point(16, 44);
        gridDebtors.MultiSelect = false;
        gridDebtors.Name = "gridDebtors";
        gridDebtors.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridDebtors.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        gridDebtors.RowHeadersVisible = false;
        gridDebtors.RowHeadersWidth = 51;
        gridDebtors.RowTemplate.Height = 42;
        gridDebtors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridDebtors.Size = new System.Drawing.Size(1120, 539);
        gridDebtors.TabIndex = 1;
        // 
        // lblDebtTitle
        // 
        lblDebtTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblDebtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblDebtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblDebtTitle.Location = new System.Drawing.Point(16, 16);
        lblDebtTitle.Name = "lblDebtTitle";
        lblDebtTitle.Size = new System.Drawing.Size(1120, 28);
        lblDebtTitle.TabIndex = 0;
        lblDebtTitle.Text = "DANH SÁCH HỌC VIÊN CÒN KHOẢN PHẢI THANH TOÁN (CÔNG NỢ > 0đ)";
        // 
        // cardHistory
        // 
        cardHistory.BackColor = System.Drawing.Color.White;
        cardHistory.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardHistory.BorderWidth = 1;
        cardHistory.Controls.Add(lblHistoryFooter);
        cardHistory.Controls.Add(gridHistory);
        cardHistory.Controls.Add(lblHistoryTitle);
        cardHistory.CornerRadius = 8;
        cardHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        cardHistory.Location = new System.Drawing.Point(24, 14);
        cardHistory.Name = "cardHistory";
        cardHistory.Padding = new System.Windows.Forms.Padding(16);
        cardHistory.Size = new System.Drawing.Size(1152, 599);
        cardHistory.TabIndex = 2;
        cardHistory.Visible = false;
        // 
        // lblHistoryFooter
        // 
        lblHistoryFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblHistoryFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblHistoryFooter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblHistoryFooter.Location = new System.Drawing.Point(16, 555);
        lblHistoryFooter.Name = "lblHistoryFooter";
        lblHistoryFooter.Size = new System.Drawing.Size(1120, 28);
        lblHistoryFooter.TabIndex = 2;
        lblHistoryFooter.Text = ("📌 Nhấn \'🖨️ In phiếu thu\' để mở phôi biên lai thu tiền chuẩn A5 hai liên và gửi " + "lệnh in.");
        // 
        // gridHistory
        // 
        gridHistory.AllowUserToAddRows = false;
        gridHistory.AllowUserToDeleteRows = false;
        gridHistory.AllowUserToResizeColumns = false;
        gridHistory.AllowUserToResizeRows = false;
        dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        gridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
        gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridHistory.BackgroundColor = System.Drawing.Color.White;
        gridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
        gridHistory.ColumnHeadersHeight = 38;
        gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridHistory.DefaultCellStyle = dataGridViewCellStyle11;
        gridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        gridHistory.EnableHeadersVisualStyles = false;
        gridHistory.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridHistory.Location = new System.Drawing.Point(16, 44);
        gridHistory.MultiSelect = false;
        gridHistory.Name = "gridHistory";
        gridHistory.ReadOnly = true;
        dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
        gridHistory.RowHeadersVisible = false;
        gridHistory.RowHeadersWidth = 51;
        gridHistory.RowTemplate.Height = 42;
        gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridHistory.Size = new System.Drawing.Size(1120, 539);
        gridHistory.TabIndex = 1;
        // 
        // lblHistoryTitle
        // 
        lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblHistoryTitle.Location = new System.Drawing.Point(16, 16);
        lblHistoryTitle.Name = "lblHistoryTitle";
        lblHistoryTitle.Size = new System.Drawing.Size(1120, 28);
        lblHistoryTitle.TabIndex = 0;
        lblHistoryTitle.Text = "NHẬT KÝ TẤT CẢ GIAO DỊCH THU TIỀN CỦA TRUNG TÂM";
        // 
        // TuitionPaymentView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(pnlBody);
        Controls.Add(pnlFilter);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Size = new System.Drawing.Size(1200, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardProfiles.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridProfiles).EndInit();
        pnlProfileSummary.ResumeLayout(false);
        cardSumRemaining.ResumeLayout(false);
        cardSumPaid.ResumeLayout(false);
        cardSumTotal.ResumeLayout(false);
        cardDebt.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridDebtors).EndInit();
        cardHistory.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnCollectTuition;
    private ECMS.UI.Controls.AppButton btnExportDebt;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabProfiles;
    private System.Windows.Forms.Button btnTabDebt;
    private System.Windows.Forms.Button btnTabHistory;
    private System.Windows.Forms.Panel pnlFilter;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cboStatusFilter;
    private System.Windows.Forms.ComboBox cboClassFilter;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardProfiles;
    private System.Windows.Forms.Label lblProfilesTitle;
    private ECMS.UI.Controls.AppDataGrid gridProfiles;
    private System.Windows.Forms.Panel pnlProfileSummary;
    private ECMS.UI.Controls.AppCard cardSumTotal;
    private System.Windows.Forms.Label lblSumTotalTitle;
    private System.Windows.Forms.Label lblSumTotalVal;
    private ECMS.UI.Controls.AppCard cardSumPaid;
    private System.Windows.Forms.Label lblSumPaidTitle;
    private System.Windows.Forms.Label lblSumPaidVal;
    private ECMS.UI.Controls.AppCard cardSumRemaining;
    private System.Windows.Forms.Label lblSumRemainingTitle;
    private System.Windows.Forms.Label lblSumRemainingVal;
    private ECMS.UI.Controls.AppCard cardDebt;
    private System.Windows.Forms.Label lblDebtTitle;
    private ECMS.UI.Controls.AppDataGrid gridDebtors;
    private System.Windows.Forms.Label lblDebtorsFooter;
    private ECMS.UI.Controls.AppCard cardHistory;
    private System.Windows.Forms.Label lblHistoryTitle;
    private ECMS.UI.Controls.AppDataGrid gridHistory;
    private System.Windows.Forms.Label lblHistoryFooter;
}
