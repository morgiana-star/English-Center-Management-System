namespace ECMS.UI.UserControls;

partial class CertificateManagementView
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
        cboSigner = new System.Windows.Forms.ComboBox();
        lblSigner = new System.Windows.Forms.Label();
        btnIssueSelectedTop = new ECMS.UI.Controls.AppButton();
        btnIssuedRegistryTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        dgvEligible = new ECMS.UI.Controls.AppDataGrid();
        pnlCardHeader = new System.Windows.Forms.Panel();
        lblSelectedSummary = new System.Windows.Forms.Label();
        lblTableTitle = new System.Windows.Forms.Label();
        pnlFooterNote = new System.Windows.Forms.Panel();
        lblFooterNote = new System.Windows.Forms.Label();
        pnlFilterBar = new System.Windows.Forms.Panel();
        btnDeselectAll = new ECMS.UI.Controls.AppButton();
        btnSelectAllEligible = new ECMS.UI.Controls.AppButton();
        cboConditionFilter = new System.Windows.Forms.ComboBox();
        cboClassFilter = new System.Windows.Forms.ComboBox();
        cboCourseFilter = new System.Windows.Forms.ComboBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStudentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEligible).BeginInit();
        pnlCardHeader.SuspendLayout();
        pnlFooterNote.SuspendLayout();
        pnlFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(cboSigner);
        pnlHeader.Controls.Add(lblSigner);
        pnlHeader.Controls.Add(btnIssueSelectedTop);
        pnlHeader.Controls.Add(btnIssuedRegistryTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1200, 75);
        pnlHeader.TabIndex = 0;
        // 
        // cboSigner
        // 
        cboSigner.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboSigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboSigner.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboSigner.FormattingEnabled = true;
        cboSigner.Location = new System.Drawing.Point(523, 22);
        cboSigner.Name = "cboSigner";
        cboSigner.Size = new System.Drawing.Size(265, 29);
        cboSigner.TabIndex = 4;
        // 
        // lblSigner
        // 
        lblSigner.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblSigner.AutoSize = true;
        lblSigner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSigner.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSigner.Location = new System.Drawing.Point(440, 26);
        lblSigner.Name = "lblSigner";
        lblSigner.Size = new System.Drawing.Size(77, 20);
        lblSigner.TabIndex = 3;
        lblSigner.Text = "Người ký:";
        // 
        // btnIssueSelectedTop
        // 
        btnIssueSelectedTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnIssueSelectedTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnIssueSelectedTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnIssueSelectedTop.CornerRadius = 5;
        btnIssueSelectedTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnIssueSelectedTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnIssueSelectedTop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnIssueSelectedTop.ForeColor = System.Drawing.Color.White;
        btnIssueSelectedTop.Location = new System.Drawing.Point(1005, 18);
        btnIssueSelectedTop.Name = "btnIssueSelectedTop";
        btnIssueSelectedTop.Size = new System.Drawing.Size(170, 38);
        btnIssueSelectedTop.TabIndex = 2;
        btnIssueSelectedTop.Text = "🎓 Cấp chứng chỉ (0)";
        btnIssueSelectedTop.UseVisualStyleBackColor = false;
        btnIssueSelectedTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnIssuedRegistryTop
        // 
        btnIssuedRegistryTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnIssuedRegistryTop.BackColor = System.Drawing.Color.White;
        btnIssuedRegistryTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnIssuedRegistryTop.CornerRadius = 5;
        btnIssuedRegistryTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnIssuedRegistryTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnIssuedRegistryTop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnIssuedRegistryTop.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnIssuedRegistryTop.Location = new System.Drawing.Point(825, 18);
        btnIssuedRegistryTop.Name = "btnIssuedRegistryTop";
        btnIssuedRegistryTop.Size = new System.Drawing.Size(168, 38);
        btnIssuedRegistryTop.TabIndex = 1;
        btnIssuedRegistryTop.Text = "Sổ chứng chỉ đã cấp";
        btnIssuedRegistryTop.UseVisualStyleBackColor = false;
        btnIssuedRegistryTop.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(391, 37);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Quản lý Chứng chỉ tốt nghiệp";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Controls.Add(pnlFilterBar);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1200, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStudentList
        // 
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(dgvEligible);
        cardStudentList.Controls.Add(pnlCardHeader);
        cardStudentList.Controls.Add(pnlFooterNote);
        cardStudentList.CornerRadius = 8;
        cardStudentList.Location = new System.Drawing.Point(24, 76);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(16);
        cardStudentList.Size = new System.Drawing.Size(1152, 625);
        cardStudentList.TabIndex = 1;
        // 
        // dgvEligible
        // 
        dgvEligible.AllowUserToAddRows = false;
        dgvEligible.AllowUserToDeleteRows = false;
        dgvEligible.AllowUserToResizeColumns = false;
        dgvEligible.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvEligible.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvEligible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvEligible.BackgroundColor = System.Drawing.Color.White;
        dgvEligible.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvEligible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvEligible.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvEligible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvEligible.ColumnHeadersHeight = 38;
        dgvEligible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvEligible.DefaultCellStyle = dataGridViewCellStyle3;
        dgvEligible.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvEligible.EnableHeadersVisualStyles = false;
        dgvEligible.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvEligible.Location = new System.Drawing.Point(16, 50);
        dgvEligible.MultiSelect = false;
        dgvEligible.Name = "dgvEligible";
        dgvEligible.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvEligible.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvEligible.RowHeadersVisible = false;
        dgvEligible.RowHeadersWidth = 51;
        dgvEligible.RowTemplate.Height = 42;
        dgvEligible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvEligible.Size = new System.Drawing.Size(1120, 527);
        dgvEligible.TabIndex = 1;
        // 
        // pnlCardHeader
        // 
        pnlCardHeader.Controls.Add(lblSelectedSummary);
        pnlCardHeader.Controls.Add(lblTableTitle);
        pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlCardHeader.Location = new System.Drawing.Point(16, 16);
        pnlCardHeader.Name = "pnlCardHeader";
        pnlCardHeader.Size = new System.Drawing.Size(1120, 34);
        pnlCardHeader.TabIndex = 0;
        // 
        // lblSelectedSummary
        // 
        lblSelectedSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblSelectedSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSelectedSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSelectedSummary.Location = new System.Drawing.Point(740, 6);
        lblSelectedSummary.Name = "lblSelectedSummary";
        lblSelectedSummary.Size = new System.Drawing.Size(370, 20);
        lblSelectedSummary.TabIndex = 1;
        lblSelectedSummary.Text = "Đang chọn: 0 học viên đủ điều kiện";
        lblSelectedSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTableTitle
        // 
        lblTableTitle.AutoSize = true;
        lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTableTitle.Location = new System.Drawing.Point(2, 6);
        lblTableTitle.Name = "lblTableTitle";
        lblTableTitle.Size = new System.Drawing.Size(596, 23);
        lblTableTitle.TabIndex = 0;
        lblTableTitle.Text = "DANH SÁCH HỌC VIÊN HOÀN THÀNH KHÓA HỌC CHỜ CẤP CHỨNG CHỈ";
        // 
        // pnlFooterNote
        // 
        pnlFooterNote.Controls.Add(lblFooterNote);
        pnlFooterNote.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooterNote.Location = new System.Drawing.Point(16, 577);
        pnlFooterNote.Name = "pnlFooterNote";
        pnlFooterNote.Size = new System.Drawing.Size(1120, 32);
        pnlFooterNote.TabIndex = 2;
        // 
        // lblFooterNote
        // 
        lblFooterNote.AutoSize = true;
        lblFooterNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblFooterNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFooterNote.Location = new System.Drawing.Point(4, 7);
        lblFooterNote.Name = "lblFooterNote";
        lblFooterNote.Size = new System.Drawing.Size(676, 20);
        lblFooterNote.TabIndex = 0;
        lblFooterNote.Text = ("Tiêu chuẩn cấp chứng chỉ: Điểm TB cuối khóa ≥ 6.5  |  Chuyên cần ≥ 80%  |  Học ph" + "í hoàn thành 100%");
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.BackColor = System.Drawing.Color.White;
        pnlFilterBar.Controls.Add(btnDeselectAll);
        pnlFilterBar.Controls.Add(btnSelectAllEligible);
        pnlFilterBar.Controls.Add(cboConditionFilter);
        pnlFilterBar.Controls.Add(cboClassFilter);
        pnlFilterBar.Controls.Add(cboCourseFilter);
        pnlFilterBar.Controls.Add(txtSearch);
        pnlFilterBar.Controls.Add(lblSearch);
        pnlFilterBar.Location = new System.Drawing.Point(24, 16);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(12);
        pnlFilterBar.Size = new System.Drawing.Size(1152, 48);
        pnlFilterBar.TabIndex = 0;
        // 
        // btnDeselectAll
        // 
        btnDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDeselectAll.BackColor = System.Drawing.Color.White;
        btnDeselectAll.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnDeselectAll.CornerRadius = 4;
        btnDeselectAll.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDeselectAll.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnDeselectAll.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnDeselectAll.Location = new System.Drawing.Point(1065, 8);
        btnDeselectAll.Name = "btnDeselectAll";
        btnDeselectAll.Size = new System.Drawing.Size(75, 30);
        btnDeselectAll.TabIndex = 6;
        btnDeselectAll.Text = "Bỏ chọn";
        btnDeselectAll.UseVisualStyleBackColor = false;
        btnDeselectAll.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnSelectAllEligible
        // 
        btnSelectAllEligible.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSelectAllEligible.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        btnSelectAllEligible.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnSelectAllEligible.CornerRadius = 4;
        btnSelectAllEligible.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSelectAllEligible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSelectAllEligible.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        btnSelectAllEligible.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSelectAllEligible.Location = new System.Drawing.Point(873, 8);
        btnSelectAllEligible.Name = "btnSelectAllEligible";
        btnSelectAllEligible.Size = new System.Drawing.Size(186, 30);
        btnSelectAllEligible.TabIndex = 5;
        btnSelectAllEligible.Text = "Chọn tất cả đủ điều kiện";
        btnSelectAllEligible.UseVisualStyleBackColor = false;
        btnSelectAllEligible.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cboConditionFilter
        // 
        cboConditionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboConditionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboConditionFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboConditionFilter.FormattingEnabled = true;
        cboConditionFilter.Location = new System.Drawing.Point(690, 9);
        cboConditionFilter.Name = "cboConditionFilter";
        cboConditionFilter.Size = new System.Drawing.Size(160, 29);
        cboConditionFilter.TabIndex = 4;
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboClassFilter.FormattingEnabled = true;
        cboClassFilter.Location = new System.Drawing.Point(565, 9);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(119, 29);
        cboClassFilter.TabIndex = 3;
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboCourseFilter.FormattingEnabled = true;
        cboCourseFilter.Location = new System.Drawing.Point(430, 9);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(129, 29);
        cboCourseFilter.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.Location = new System.Drawing.Point(100, 9);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Tìm theo mã học viên, họ và tên, lớp học...";
        txtSearch.Size = new System.Drawing.Size(315, 29);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSearch.Location = new System.Drawing.Point(12, 13);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(78, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm:";
        // 
        // CertificateManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Size = new System.Drawing.Size(1200, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardStudentList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEligible).EndInit();
        pnlCardHeader.ResumeLayout(false);
        pnlCardHeader.PerformLayout();
        pnlFooterNote.ResumeLayout(false);
        pnlFooterNote.PerformLayout();
        pnlFilterBar.ResumeLayout(false);
        pnlFilterBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSigner;
    private System.Windows.Forms.ComboBox cboSigner;
    private ECMS.UI.Controls.AppButton btnIssuedRegistryTop;
    private ECMS.UI.Controls.AppButton btnIssueSelectedTop;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlFilterBar;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cboCourseFilter;
    private System.Windows.Forms.ComboBox cboClassFilter;
    private System.Windows.Forms.ComboBox cboConditionFilter;
    private ECMS.UI.Controls.AppButton btnSelectAllEligible;
    private ECMS.UI.Controls.AppButton btnDeselectAll;
    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Panel pnlCardHeader;
    private System.Windows.Forms.Label lblTableTitle;
    private System.Windows.Forms.Label lblSelectedSummary;
    private ECMS.UI.Controls.AppDataGrid dgvEligible;
    private System.Windows.Forms.Panel pnlFooterNote;
    private System.Windows.Forms.Label lblFooterNote;
}
