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

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnViewArchived = new ECMS.UI.Controls.AppButton();
        btnImport = new ECMS.UI.Controls.AppButton();
        btnExport = new ECMS.UI.Controls.AppButton();
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        pnlGridFooter = new System.Windows.Forms.Panel();
        lblBottomSummary = new System.Windows.Forms.Label();
        dgvStudents = new ECMS.UI.Controls.AppDataGrid();
        pnlStudentFilterBar = new System.Windows.Forms.Panel();
        lblClassFilter = new System.Windows.Forms.Label();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchStudent = new ECMS.UI.Controls.AppTextBox();
        lblStudentListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStudentList.SuspendLayout();
        pnlGridFooter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        pnlStudentFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnViewArchived);
        pnlHeader.Controls.Add(btnImport);
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
        // btnViewArchived
        // 
        btnViewArchived.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnViewArchived.BackColor = System.Drawing.Color.White;
        btnViewArchived.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnViewArchived.CornerRadius = 6;
        btnViewArchived.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewArchived.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnViewArchived.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnViewArchived.Location = new System.Drawing.Point(555, 20);
        btnViewArchived.Name = "btnViewArchived";
        btnViewArchived.Size = new System.Drawing.Size(155, 36);
        btnViewArchived.TabIndex = 6;
        btnViewArchived.Text = "Xem hồ sơ lưu trữ";
        btnViewArchived.UseVisualStyleBackColor = false;
        btnViewArchived.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
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
        btnImport.Location = new System.Drawing.Point(720, 20);
        btnImport.Name = "btnImport";
        btnImport.Size = new System.Drawing.Size(125, 36);
        btnImport.TabIndex = 5;
        btnImport.Text = "Nhập Excel";
        btnImport.UseVisualStyleBackColor = false;
        btnImport.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
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
        btnAddStudent.Text = "Đăng ký học";
        btnAddStudent.UseVisualStyleBackColor = false;
        btnAddStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(129, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Học viên";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStudentList
        // 
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(dgvStudents);
        cardStudentList.Controls.Add(pnlGridFooter);
        cardStudentList.Controls.Add(pnlStudentFilterBar);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.CornerRadius = 8;
        cardStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStudentList.Location = new System.Drawing.Point(20, 16);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(16);
        cardStudentList.Size = new System.Drawing.Size(1120, 689);
        cardStudentList.TabIndex = 0;
        // 
        // pnlGridFooter
        // 
        pnlGridFooter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlGridFooter.Controls.Add(lblBottomSummary);
        pnlGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlGridFooter.Location = new System.Drawing.Point(16, 637);
        pnlGridFooter.Name = "pnlGridFooter";
        pnlGridFooter.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
        pnlGridFooter.Size = new System.Drawing.Size(1088, 36);
        pnlGridFooter.TabIndex = 3;
        // 
        // lblBottomSummary
        // 
        lblBottomSummary.Dock = System.Windows.Forms.DockStyle.Fill;
        lblBottomSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBottomSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblBottomSummary.Location = new System.Drawing.Point(12, 8);
        lblBottomSummary.Name = "lblBottomSummary";
        lblBottomSummary.Size = new System.Drawing.Size(1064, 20);
        lblBottomSummary.TabIndex = 0;
        lblBottomSummary.Text = "Tổng: 0 học viên  |  Đang học: 0  |  Chờ xếp lớp: 0  |  Đã lưu trữ: 0";
        lblBottomSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
        dgvStudents.ColumnHeadersHeight = 38;
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
        dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvStudents.EnableHeadersVisualStyles = false;
        dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvStudents.Location = new System.Drawing.Point(16, 102);
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
        dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvStudents.Size = new System.Drawing.Size(1088, 535);
        dgvStudents.TabIndex = 2;
        // 
        // pnlStudentFilterBar
        // 
        pnlStudentFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlStudentFilterBar.Controls.Add(lblClassFilter);
        pnlStudentFilterBar.Controls.Add(cboClassFilter);
        pnlStudentFilterBar.Controls.Add(txtSearchStudent);
        pnlStudentFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStudentFilterBar.Location = new System.Drawing.Point(16, 48);
        pnlStudentFilterBar.Name = "pnlStudentFilterBar";
        pnlStudentFilterBar.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        pnlStudentFilterBar.Size = new System.Drawing.Size(1088, 54);
        pnlStudentFilterBar.TabIndex = 1;
        // 
        // lblClassFilter
        // 
        lblClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblClassFilter.AutoSize = true;
        lblClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblClassFilter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblClassFilter.Location = new System.Drawing.Point(750, 17);
        lblClassFilter.Name = "lblClassFilter";
        lblClassFilter.Size = new System.Drawing.Size(68, 20);
        lblClassFilter.TabIndex = 3;
        lblClassFilter.Text = "Lọc lớp:";
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClassFilter.BackColor = System.Drawing.Color.White;
        cboClassFilter.CornerRadius = 5;
        cboClassFilter.DataSource = null;
        cboClassFilter.DisplayMember = "";
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboClassFilter.Location = new System.Drawing.Point(825, 10);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.SelectedIndex = -1;
        cboClassFilter.SelectedItem = null;
        cboClassFilter.SelectedValue = null;
        cboClassFilter.Size = new System.Drawing.Size(250, 34);
        cboClassFilter.TabIndex = 2;
        cboClassFilter.ValueMember = "";
        // 
        // txtSearchStudent
        // 
        txtSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearchStudent.BackColor = System.Drawing.Color.White;
        txtSearchStudent.CornerRadius = 6;
        txtSearchStudent.ErrorMessage = "";
        txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchStudent.HasError = false;
        txtSearchStudent.Location = new System.Drawing.Point(10, 10);
        txtSearchStudent.Name = "txtSearchStudent";
        txtSearchStudent.Placeholder = "Tìm theo mã học viên, họ tên, số điện thoại...";
        txtSearchStudent.ReadOnly = false;
        txtSearchStudent.Size = new System.Drawing.Size(720, 34);
        txtSearchStudent.TabIndex = 0;
        txtSearchStudent.UseSystemPasswordChar = false;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStudentListTitle.Location = new System.Drawing.Point(16, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(1088, 32);
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
        cardStudentList.ResumeLayout(false);
        pnlGridFooter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        pnlStudentFilterBar.ResumeLayout(false);
        pnlStudentFilterBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnViewArchived;
    private ECMS.UI.Controls.AppButton btnImport;
    private ECMS.UI.Controls.AppButton btnExport;
    private ECMS.UI.Controls.AppButton btnAddStudent;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private System.Windows.Forms.Panel pnlStudentFilterBar;
    private ECMS.UI.Controls.AppTextBox txtSearchStudent;
    private System.Windows.Forms.Label lblClassFilter;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private ECMS.UI.Controls.AppDataGrid dgvStudents;
    private System.Windows.Forms.Panel pnlGridFooter;
    private System.Windows.Forms.Label lblBottomSummary;
}
