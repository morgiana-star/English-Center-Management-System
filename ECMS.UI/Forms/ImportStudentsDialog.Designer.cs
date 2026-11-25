namespace ECMS.UI.Forms;

partial class ImportStudentsDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        btnChooseFile = new ECMS.UI.Controls.AppButton();
        btnDownloadTemplate = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlSummary = new System.Windows.Forms.Panel();
        cboRowFilter = new ECMS.UI.Controls.AppComboBox();
        lblFilterLabel = new System.Windows.Forms.Label();
        lblFileNotice = new System.Windows.Forms.Label();
        lblInvalidSummary = new System.Windows.Forms.Label();
        lblValidSummary = new System.Windows.Forms.Label();
        lblTotalSummary = new System.Windows.Forms.Label();
        pnlGridContainer = new System.Windows.Forms.Panel();
        cardGrid = new ECMS.UI.Controls.AppCard();
        dgvPreview = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        btnExecuteImport = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlSummary.SuspendLayout();
        pnlGridContainer.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnChooseFile);
        pnlHeader.Controls.Add(btnDownloadTemplate);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
        pnlHeader.Size = new System.Drawing.Size(1120, 84);
        pnlHeader.TabIndex = 0;
        // 
        // btnChooseFile
        // 
        btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnChooseFile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnChooseFile.CornerRadius = 6;
        btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnChooseFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnChooseFile.ForeColor = System.Drawing.Color.White;
        btnChooseFile.Location = new System.Drawing.Point(930, 24);
        btnChooseFile.Name = "btnChooseFile";
        btnChooseFile.Size = new System.Drawing.Size(165, 36);
        btnChooseFile.TabIndex = 3;
        btnChooseFile.Text = "Chọn tệp dữ liệu";
        btnChooseFile.UseVisualStyleBackColor = false;
        btnChooseFile.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnDownloadTemplate
        // 
        btnDownloadTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDownloadTemplate.BackColor = System.Drawing.Color.White;
        btnDownloadTemplate.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnDownloadTemplate.CornerRadius = 6;
        btnDownloadTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDownloadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDownloadTemplate.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnDownloadTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnDownloadTemplate.Location = new System.Drawing.Point(755, 24);
        btnDownloadTemplate.Name = "btnDownloadTemplate";
        btnDownloadTemplate.Size = new System.Drawing.Size(165, 36);
        btnDownloadTemplate.TabIndex = 2;
        btnDownloadTemplate.Text = "Tải tệp mẫu (.xlsx)";
        btnDownloadTemplate.UseVisualStyleBackColor = false;
        btnDownloadTemplate.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 24);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(436, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Nhập danh sách học viên từ Excel / CSV";
        // 
        // pnlSummary
        // 
        pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        pnlSummary.Controls.Add(cboRowFilter);
        pnlSummary.Controls.Add(lblFilterLabel);
        pnlSummary.Controls.Add(lblFileNotice);
        pnlSummary.Controls.Add(lblInvalidSummary);
        pnlSummary.Controls.Add(lblValidSummary);
        pnlSummary.Controls.Add(lblTotalSummary);
        pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
        pnlSummary.Location = new System.Drawing.Point(0, 84);
        pnlSummary.Name = "pnlSummary";
        pnlSummary.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlSummary.Size = new System.Drawing.Size(1120, 48);
        pnlSummary.TabIndex = 1;
        // 
        // cboRowFilter
        // 
        cboRowFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboRowFilter.BackColor = System.Drawing.Color.White;
        cboRowFilter.CornerRadius = 5;
        cboRowFilter.DataSource = null;
        cboRowFilter.DisplayMember = "";
        cboRowFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboRowFilter.Location = new System.Drawing.Point(915, 7);
        cboRowFilter.Name = "cboRowFilter";
        cboRowFilter.SelectedIndex = -1;
        cboRowFilter.SelectedItem = null;
        cboRowFilter.SelectedValue = null;
        cboRowFilter.Size = new System.Drawing.Size(180, 34);
        cboRowFilter.TabIndex = 5;
        cboRowFilter.ValueMember = "";
        // 
        // lblFilterLabel
        // 
        lblFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblFilterLabel.AutoSize = true;
        lblFilterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblFilterLabel.Location = new System.Drawing.Point(845, 14);
        lblFilterLabel.Name = "lblFilterLabel";
        lblFilterLabel.Size = new System.Drawing.Size(68, 20);
        lblFilterLabel.TabIndex = 4;
        lblFilterLabel.Text = "Hiển thị:";
        // 
        // lblFileNotice
        // 
        lblFileNotice.AutoSize = true;
        lblFileNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblFileNotice.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFileNotice.Location = new System.Drawing.Point(345, 14);
        lblFileNotice.Name = "lblFileNotice";
        lblFileNotice.Size = new System.Drawing.Size(175, 20);
        lblFileNotice.TabIndex = 3;
        lblFileNotice.Text = "Chưa nạp tệp dữ liệu nào.";
        // 
        // lblInvalidSummary
        // 
        lblInvalidSummary.AutoSize = true;
        lblInvalidSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInvalidSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)185)), ((int)((byte)28)), ((int)((byte)28)));
        lblInvalidSummary.Location = new System.Drawing.Point(260, 14);
        lblInvalidSummary.Name = "lblInvalidSummary";
        lblInvalidSummary.Size = new System.Drawing.Size(47, 20);
        lblInvalidSummary.TabIndex = 2;
        lblInvalidSummary.Text = "Lỗi: 0";
        // 
        // lblValidSummary
        // 
        lblValidSummary.AutoSize = true;
        lblValidSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblValidSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)101)), ((int)((byte)52)));
        lblValidSummary.Location = new System.Drawing.Point(160, 14);
        lblValidSummary.Name = "lblValidSummary";
        lblValidSummary.Size = new System.Drawing.Size(71, 20);
        lblValidSummary.TabIndex = 1;
        lblValidSummary.Text = "Hợp lệ: 0";
        // 
        // lblTotalSummary
        // 
        lblTotalSummary.AutoSize = true;
        lblTotalSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTotalSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTotalSummary.Location = new System.Drawing.Point(24, 14);
        lblTotalSummary.Name = "lblTotalSummary";
        lblTotalSummary.Size = new System.Drawing.Size(122, 20);
        lblTotalSummary.TabIndex = 0;
        lblTotalSummary.Text = "Tổng số: 0 dòng";
        // 
        // pnlGridContainer
        // 
        pnlGridContainer.Controls.Add(cardGrid);
        pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlGridContainer.Location = new System.Drawing.Point(0, 132);
        pnlGridContainer.Name = "pnlGridContainer";
        pnlGridContainer.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
        pnlGridContainer.Size = new System.Drawing.Size(1120, 483);
        pnlGridContainer.TabIndex = 2;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGrid.BorderWidth = 1;
        cardGrid.Controls.Add(dgvPreview);
        cardGrid.CornerRadius = 8;
        cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardGrid.Location = new System.Drawing.Point(20, 12);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(10);
        cardGrid.Size = new System.Drawing.Size(1080, 459);
        cardGrid.TabIndex = 0;
        // 
        // dgvPreview
        // 
        dgvPreview.AllowUserToAddRows = false;
        dgvPreview.AllowUserToDeleteRows = false;
        dgvPreview.AllowUserToResizeColumns = false;
        dgvPreview.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvPreview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvPreview.BackgroundColor = System.Drawing.Color.White;
        dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvPreview.ColumnHeadersHeight = 36;
        dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvPreview.DefaultCellStyle = dataGridViewCellStyle3;
        dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvPreview.EnableHeadersVisualStyles = false;
        dgvPreview.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvPreview.Location = new System.Drawing.Point(10, 10);
        dgvPreview.MultiSelect = false;
        dgvPreview.Name = "dgvPreview";
        dgvPreview.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvPreview.RowHeadersVisible = false;
        dgvPreview.RowHeadersWidth = 51;
        dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvPreview.Size = new System.Drawing.Size(1060, 439);
        dgvPreview.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnExecuteImport);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 615);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
        pnlFooter.Size = new System.Drawing.Size(1120, 65);
        pnlFooter.TabIndex = 3;
        // 
        // btnExecuteImport
        // 
        btnExecuteImport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnExecuteImport.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnExecuteImport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnExecuteImport.CornerRadius = 6;
        btnExecuteImport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExecuteImport.Enabled = false;
        btnExecuteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExecuteImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnExecuteImport.ForeColor = System.Drawing.Color.White;
        btnExecuteImport.Location = new System.Drawing.Point(905, 14);
        btnExecuteImport.Name = "btnExecuteImport";
        btnExecuteImport.Size = new System.Drawing.Size(190, 36);
        btnExecuteImport.TabIndex = 2;
        btnExecuteImport.Text = "Tiến hành nhập (0)";
        btnExecuteImport.UseVisualStyleBackColor = false;
        btnExecuteImport.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 6;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnCancel.Location = new System.Drawing.Point(785, 14);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(110, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Đóng";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // ImportStudentsDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1120, 680);
        Controls.Add(pnlGridContainer);
        Controls.Add(pnlSummary);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(960, 580);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Nhập danh sách học viên từ Excel / CSV - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlSummary.ResumeLayout(false);
        pnlSummary.PerformLayout();
        pnlGridContainer.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnDownloadTemplate;
    private ECMS.UI.Controls.AppButton btnChooseFile;
    private System.Windows.Forms.Panel pnlSummary;
    private System.Windows.Forms.Label lblTotalSummary;
    private System.Windows.Forms.Label lblValidSummary;
    private System.Windows.Forms.Label lblInvalidSummary;
    private System.Windows.Forms.Label lblFileNotice;
    private System.Windows.Forms.Label lblFilterLabel;
    private ECMS.UI.Controls.AppComboBox cboRowFilter;
    private System.Windows.Forms.Panel pnlGridContainer;
    private ECMS.UI.Controls.AppCard cardGrid;
    private ECMS.UI.Controls.AppDataGrid dgvPreview;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnExecuteImport;
}
