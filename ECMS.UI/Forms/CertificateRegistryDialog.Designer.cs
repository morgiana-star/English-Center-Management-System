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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnPreviewPrint = new ECMS.UI.Controls.AppButton();
        btnExportExcel = new ECMS.UI.Controls.AppButton();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlFilterBar = new System.Windows.Forms.Panel();
        cboYearFilter = new System.Windows.Forms.ComboBox();
        cboCourseFilter = new System.Windows.Forms.ComboBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardRegistryList = new ECMS.UI.Controls.AppCard();
        gridRegistry = new ECMS.UI.Controls.AppDataGrid();
        lblGridFooter = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlFilterBar.SuspendLayout();
        pnlBody.SuspendLayout();
        cardRegistryList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridRegistry).BeginInit();
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
        pnlHeader.Size = new System.Drawing.Size(1260, 75);
        pnlHeader.TabIndex = 0;
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        pnlTopActions.Controls.Add(btnPreviewPrint);
        pnlTopActions.Controls.Add(btnExportExcel);
        pnlTopActions.Controls.Add(btnClose);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(780, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(460, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnPreviewPrint
        // 
        btnPreviewPrint.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnPreviewPrint.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPreviewPrint.CornerRadius = 5;
        btnPreviewPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPreviewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPreviewPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPreviewPrint.ForeColor = System.Drawing.Color.White;
        btnPreviewPrint.Location = new System.Drawing.Point(305, 3);
        btnPreviewPrint.Name = "btnPreviewPrint";
        btnPreviewPrint.Size = new System.Drawing.Size(152, 38);
        btnPreviewPrint.TabIndex = 0;
        btnPreviewPrint.Text = "🖨️ Xem trước khi in";
        btnPreviewPrint.UseVisualStyleBackColor = false;
        btnPreviewPrint.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnExportExcel
        // 
        btnExportExcel.BackColor = System.Drawing.Color.White;
        btnExportExcel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportExcel.CornerRadius = 5;
        btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnExportExcel.Location = new System.Drawing.Point(165, 3);
        btnExportExcel.Name = "btnExportExcel";
        btnExportExcel.Size = new System.Drawing.Size(134, 38);
        btnExportExcel.TabIndex = 1;
        btnExportExcel.Text = "📊 Xuất Excel";
        btnExportExcel.UseVisualStyleBackColor = false;
        btnExportExcel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnClose
        // 
        btnClose.BackColor = System.Drawing.Color.White;
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClose.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnClose.Location = new System.Drawing.Point(59, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(100, 38);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(24, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(360, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Sổ cấp chứng chỉ tốt nghiệp";
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlFilterBar.Controls.Add(cboYearFilter);
        pnlFilterBar.Controls.Add(cboCourseFilter);
        pnlFilterBar.Controls.Add(txtSearch);
        pnlFilterBar.Controls.Add(lblSearch);
        pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilterBar.Location = new System.Drawing.Point(0, 75);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlFilterBar.Size = new System.Drawing.Size(1260, 50);
        pnlFilterBar.TabIndex = 2;
        // 
        // cboYearFilter
        // 
        cboYearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboYearFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboYearFilter.FormattingEnabled = true;
        cboYearFilter.Location = new System.Drawing.Point(1100, 10);
        cboYearFilter.Name = "cboYearFilter";
        cboYearFilter.Size = new System.Drawing.Size(136, 29);
        cboYearFilter.TabIndex = 3;
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboCourseFilter.FormattingEnabled = true;
        cboCourseFilter.Location = new System.Drawing.Point(860, 10);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(225, 29);
        cboCourseFilter.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.Location = new System.Drawing.Point(115, 10);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Tìm theo số chứng chỉ, họ tên học viên, mã học viên, lớp...";
        txtSearch.Size = new System.Drawing.Size(420, 29);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSearch.Location = new System.Drawing.Point(24, 14);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(87, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "🔍 Tìm kiếm:";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        pnlBody.Controls.Add(cardRegistryList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 125);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        pnlBody.Size = new System.Drawing.Size(1260, 615);
        pnlBody.TabIndex = 3;
        // 
        // cardRegistryList
        // 
        cardRegistryList.BackColor = System.Drawing.Color.White;
        cardRegistryList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardRegistryList.BorderWidth = 1;
        cardRegistryList.Controls.Add(gridRegistry);
        cardRegistryList.Controls.Add(lblGridFooter);
        cardRegistryList.CornerRadius = 8;
        cardRegistryList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRegistryList.Location = new System.Drawing.Point(24, 16);
        cardRegistryList.Name = "cardRegistryList";
        cardRegistryList.Padding = new System.Windows.Forms.Padding(16);
        cardRegistryList.Size = new System.Drawing.Size(1212, 579);
        cardRegistryList.TabIndex = 0;
        // 
        // gridRegistry
        // 
        gridRegistry.AllowUserToAddRows = false;
        gridRegistry.AllowUserToDeleteRows = false;
        gridRegistry.AllowUserToResizeColumns = false;
        gridRegistry.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        gridRegistry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridRegistry.BackgroundColor = System.Drawing.Color.White;
        gridRegistry.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridRegistry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridRegistry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridRegistry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridRegistry.ColumnHeadersHeight = 38;
        gridRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridRegistry.DefaultCellStyle = dataGridViewCellStyle3;
        gridRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
        gridRegistry.EnableHeadersVisualStyles = false;
        gridRegistry.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        gridRegistry.Location = new System.Drawing.Point(16, 16);
        gridRegistry.MultiSelect = false;
        gridRegistry.Name = "gridRegistry";
        gridRegistry.ReadOnly = true;
        gridRegistry.RowHeadersVisible = false;
        gridRegistry.RowHeadersWidth = 51;
        gridRegistry.RowTemplate.Height = 42;
        gridRegistry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        gridRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridRegistry.Size = new System.Drawing.Size(1180, 517);
        gridRegistry.TabIndex = 0;
        // 
        // lblGridFooter
        // 
        lblGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblGridFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblGridFooter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblGridFooter.Location = new System.Drawing.Point(16, 533);
        lblGridFooter.Name = "lblGridFooter";
        lblGridFooter.Size = new System.Drawing.Size(1180, 30);
        lblGridFooter.TabIndex = 1;
        lblGridFooter.Text = "📌 Chọn một dòng và ấn 'Xem trước khi in' (hoặc double-click dòng) để mở phôi chứng chỉ in ấn.";
        lblGridFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // CertificateRegistryDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1260, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlFilterBar);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CertificateRegistryDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Sổ chứng chỉ · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlFilterBar.ResumeLayout(false);
        pnlFilterBar.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardRegistryList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridRegistry).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnPreviewPrint;
    private ECMS.UI.Controls.AppButton btnExportExcel;
    private ECMS.UI.Controls.AppButton btnClose;
    private System.Windows.Forms.Panel pnlFilterBar;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cboCourseFilter;
    private System.Windows.Forms.ComboBox cboYearFilter;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardRegistryList;
    private ECMS.UI.Controls.AppDataGrid gridRegistry;
    private System.Windows.Forms.Label lblGridFooter;
}
