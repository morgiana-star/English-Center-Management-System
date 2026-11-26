namespace ECMS.UI.UserControls;

partial class TeacherGradeManagementView
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
        pnlHeader = new System.Windows.Forms.Panel();
        btnCreateAssessmentTop = new ECMS.UI.Controls.AppButton();
        btnEnterGradesTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardAssessmentList = new ECMS.UI.Controls.AppCard();
        dgvAssessments = new ECMS.UI.Controls.AppDataGrid();
        pnlFilterBar = new System.Windows.Forms.Panel();
        cboClassFilter = new System.Windows.Forms.ComboBox();
        cboTypeFilter = new System.Windows.Forms.ComboBox();
        txtSearchAssessment = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardAssessmentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAssessments).BeginInit();
        pnlFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateAssessmentTop);
        pnlHeader.Controls.Add(btnEnterGradesTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateAssessmentTop
        // 
        btnCreateAssessmentTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnCreateAssessmentTop.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCreateAssessmentTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateAssessmentTop.CornerRadius = 5;
        btnCreateAssessmentTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateAssessmentTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateAssessmentTop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateAssessmentTop.ForeColor = System.Drawing.Color.White;
        btnCreateAssessmentTop.Location = new System.Drawing.Point(985, 18);
        btnCreateAssessmentTop.Name = "btnCreateAssessmentTop";
        btnCreateAssessmentTop.Size = new System.Drawing.Size(150, 36);
        btnCreateAssessmentTop.TabIndex = 4;
        btnCreateAssessmentTop.Text = "+ Tạo bài kiểm tra";
        btnCreateAssessmentTop.UseVisualStyleBackColor = false;
        btnCreateAssessmentTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEnterGradesTop
        // 
        btnEnterGradesTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnEnterGradesTop.BackColor = System.Drawing.Color.White;
        btnEnterGradesTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEnterGradesTop.CornerRadius = 5;
        btnEnterGradesTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEnterGradesTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEnterGradesTop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnEnterGradesTop.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnEnterGradesTop.Location = new System.Drawing.Point(860, 18);
        btnEnterGradesTop.Name = "btnEnterGradesTop";
        btnEnterGradesTop.Size = new System.Drawing.Size(115, 36);
        btnEnterGradesTop.TabIndex = 3;
        btnEnterGradesTop.Text = "Nhập điểm";
        btnEnterGradesTop.UseVisualStyleBackColor = false;
        btnEnterGradesTop.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(251, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Kiểm tra & Điểm số";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = false;
        pnlBody.Controls.Add(cardAssessmentList);
        pnlBody.Controls.Add(pnlFilterBar);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardAssessmentList
        // 
        cardAssessmentList.BackColor = System.Drawing.Color.White;
        cardAssessmentList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardAssessmentList.BorderWidth = 1;
        cardAssessmentList.Controls.Add(dgvAssessments);
        cardAssessmentList.CornerRadius = 8;
        cardAssessmentList.Location = new System.Drawing.Point(24, 76);
        cardAssessmentList.Name = "cardAssessmentList";
        cardAssessmentList.Padding = new System.Windows.Forms.Padding(16);
        cardAssessmentList.Size = new System.Drawing.Size(1112, 585);
        cardAssessmentList.TabIndex = 1;
        // 
        // dgvAssessments
        // 
        dgvAssessments.AllowUserToAddRows = false;
        dgvAssessments.AllowUserToDeleteRows = false;
        dgvAssessments.AllowUserToResizeColumns = false;
        dgvAssessments.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        dgvAssessments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAssessments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAssessments.BackgroundColor = System.Drawing.Color.White;
        dgvAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvAssessments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAssessments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAssessments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAssessments.ColumnHeadersHeight = 38;
        dgvAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvAssessments.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAssessments.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvAssessments.EnableHeadersVisualStyles = false;
        dgvAssessments.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvAssessments.Location = new System.Drawing.Point(16, 16);
        dgvAssessments.MultiSelect = false;
        dgvAssessments.Name = "dgvAssessments";
        dgvAssessments.ReadOnly = true;
        dgvAssessments.RowHeadersVisible = false;
        dgvAssessments.RowHeadersWidth = 51;
        dgvAssessments.RowTemplate.Height = 40;
        dgvAssessments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvAssessments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAssessments.Size = new System.Drawing.Size(1080, 553);
        dgvAssessments.TabIndex = 0;
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.BackColor = System.Drawing.Color.White;
        pnlFilterBar.Controls.Add(cboClassFilter);
        pnlFilterBar.Controls.Add(cboTypeFilter);
        pnlFilterBar.Controls.Add(txtSearchAssessment);
        pnlFilterBar.Controls.Add(lblSearch);
        pnlFilterBar.Location = new System.Drawing.Point(24, 16);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(12);
        pnlFilterBar.Size = new System.Drawing.Size(1112, 48);
        pnlFilterBar.TabIndex = 0;
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboClassFilter.FormattingEnabled = true;
        cboClassFilter.Location = new System.Drawing.Point(920, 9);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(180, 29);
        cboClassFilter.TabIndex = 3;
        // 
        // cboTypeFilter
        // 
        cboTypeFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboTypeFilter.FormattingEnabled = true;
        cboTypeFilter.Location = new System.Drawing.Point(725, 9);
        cboTypeFilter.Name = "cboTypeFilter";
        cboTypeFilter.Size = new System.Drawing.Size(185, 29);
        cboTypeFilter.TabIndex = 2;
        // 
        // txtSearchAssessment
        // 
        txtSearchAssessment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchAssessment.Location = new System.Drawing.Point(105, 9);
        txtSearchAssessment.Name = "txtSearchAssessment";
        txtSearchAssessment.PlaceholderText = "Tìm theo tên bài kiểm tra, lớp học áp dụng, loại bài thi...";
        txtSearchAssessment.Size = new System.Drawing.Size(430, 29);
        txtSearchAssessment.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSearch.Location = new System.Drawing.Point(12, 13);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(87, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "🔍 Tìm kiếm:";
        // 
        // TeacherGradeManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "TeacherGradeManagementView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardAssessmentList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAssessments).EndInit();
        pnlFilterBar.ResumeLayout(false);
        pnlFilterBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnEnterGradesTop;
    private ECMS.UI.Controls.AppButton btnCreateAssessmentTop;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlFilterBar;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearchAssessment;
    private System.Windows.Forms.ComboBox cboTypeFilter;
    private System.Windows.Forms.ComboBox cboClassFilter;
    private ECMS.UI.Controls.AppCard cardAssessmentList;
    private ECMS.UI.Controls.AppDataGrid dgvAssessments;
}
