namespace ECMS.UI.UserControls;

partial class TeacherAttendanceCheckView
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
        lblSub = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardClasses = new ECMS.UI.Controls.AppCard();
        dgvAttendanceClasses = new ECMS.UI.Controls.AppDataGrid();
        pnlFilters = new System.Windows.Forms.Panel();
        cboCourseFilter = new System.Windows.Forms.ComboBox();
        cboStatusFilter = new System.Windows.Forms.ComboBox();
        txtSearch = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardClasses.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAttendanceClasses).BeginInit();
        pnlFilters.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSub);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblSub
        // 
        lblSub.AutoSize = true;
        lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSub.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSub.Location = new System.Drawing.Point(24, 46);
        lblSub.Name = "lblSub";
        lblSub.Size = new System.Drawing.Size(515, 20);
        lblSub.TabIndex = 2;
        lblSub.Text = "Theo dõi chuyên cần, tiến độ và thực hiện điểm danh chi tiết theo từng lớp học";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(340, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Quản lý điểm danh lớp học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = false;
        pnlBody.Controls.Add(cardClasses);
        pnlBody.Controls.Add(pnlFilters);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardClasses
        // 
        cardClasses.BackColor = System.Drawing.Color.White;
        cardClasses.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardClasses.BorderWidth = 1;
        cardClasses.Controls.Add(dgvAttendanceClasses);
        cardClasses.CornerRadius = 8;
        cardClasses.Location = new System.Drawing.Point(24, 76);
        cardClasses.Name = "cardClasses";
        cardClasses.Padding = new System.Windows.Forms.Padding(16);
        cardClasses.Size = new System.Drawing.Size(1112, 585);
        cardClasses.TabIndex = 1;
        // 
        // dgvAttendanceClasses
        // 
        dgvAttendanceClasses.AllowUserToAddRows = false;
        dgvAttendanceClasses.AllowUserToDeleteRows = false;
        dgvAttendanceClasses.AllowUserToResizeColumns = false;
        dgvAttendanceClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        dgvAttendanceClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAttendanceClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAttendanceClasses.BackgroundColor = System.Drawing.Color.White;
        dgvAttendanceClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvAttendanceClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAttendanceClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAttendanceClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAttendanceClasses.ColumnHeadersHeight = 38;
        dgvAttendanceClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvAttendanceClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAttendanceClasses.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvAttendanceClasses.EnableHeadersVisualStyles = false;
        dgvAttendanceClasses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvAttendanceClasses.Location = new System.Drawing.Point(16, 16);
        dgvAttendanceClasses.MultiSelect = false;
        dgvAttendanceClasses.Name = "dgvAttendanceClasses";
        dgvAttendanceClasses.ReadOnly = true;
        dgvAttendanceClasses.RowHeadersVisible = false;
        dgvAttendanceClasses.RowHeadersWidth = 51;
        dgvAttendanceClasses.RowTemplate.Height = 42;
        dgvAttendanceClasses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvAttendanceClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAttendanceClasses.Size = new System.Drawing.Size(1080, 553);
        dgvAttendanceClasses.TabIndex = 0;
        // 
        // pnlFilters
        // 
        pnlFilters.BackColor = System.Drawing.Color.White;
        pnlFilters.Controls.Add(cboCourseFilter);
        pnlFilters.Controls.Add(cboStatusFilter);
        pnlFilters.Controls.Add(txtSearch);
        pnlFilters.Controls.Add(lblSearch);
        pnlFilters.Location = new System.Drawing.Point(24, 16);
        pnlFilters.Name = "pnlFilters";
        pnlFilters.Padding = new System.Windows.Forms.Padding(12);
        pnlFilters.Size = new System.Drawing.Size(1112, 48);
        pnlFilters.TabIndex = 0;
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboCourseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboCourseFilter.FormattingEnabled = true;
        cboCourseFilter.Location = new System.Drawing.Point(905, 9);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(195, 29);
        cboCourseFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStatusFilter.FormattingEnabled = true;
        cboStatusFilter.Location = new System.Drawing.Point(715, 9);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(180, 29);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.Location = new System.Drawing.Point(105, 9);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Nhập tên lớp học, khóa học, giảng viên, phòng...";
        txtSearch.Size = new System.Drawing.Size(430, 29);
        txtSearch.TabIndex = 1;
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
        // TeacherAttendanceCheckView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "TeacherAttendanceCheckView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardClasses.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAttendanceClasses).EndInit();
        pnlFilters.ResumeLayout(false);
        pnlFilters.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSub;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardClasses;
    private ECMS.UI.Controls.AppDataGrid dgvAttendanceClasses;
    private System.Windows.Forms.Panel pnlFilters;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.ComboBox cboStatusFilter;
    private System.Windows.Forms.ComboBox cboCourseFilter;
}
