namespace ECMS.UI.UserControls;

partial class CourseManagementView
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
        btnAddCourse = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCourseList = new ECMS.UI.Controls.AppCard();
        dgvCourses = new ECMS.UI.Controls.AppDataGrid();
        pnlCourseFilterBar = new System.Windows.Forms.Panel();
        cboLevelFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchCourse = new ECMS.UI.Controls.AppTextBox();
        lblCourseListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCourseList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
        pnlCourseFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddCourse);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddCourse
        // 
        btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnAddCourse.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddCourse.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddCourse.CornerRadius = 6;
        btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddCourse.ForeColor = System.Drawing.Color.White;
        btnAddCourse.Location = new System.Drawing.Point(985, 20);
        btnAddCourse.Name = "btnAddCourse";
        btnAddCourse.Size = new System.Drawing.Size(150, 36);
        btnAddCourse.TabIndex = 3;
        btnAddCourse.Text = "+ Thêm khóa học";
        btnAddCourse.UseVisualStyleBackColor = false;
        btnAddCourse.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(133, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Khóa học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlBody.Controls.Add(cardCourseList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardCourseList
        // 
        cardCourseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCourseList.BackColor = System.Drawing.Color.White;
        cardCourseList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardCourseList.BorderWidth = 1;
        cardCourseList.Controls.Add(dgvCourses);
        cardCourseList.Controls.Add(pnlCourseFilterBar);
        cardCourseList.Controls.Add(lblCourseListTitle);
        cardCourseList.CornerRadius = 8;
        cardCourseList.Location = new System.Drawing.Point(24, 20);
        cardCourseList.Name = "cardCourseList";
        cardCourseList.Padding = new System.Windows.Forms.Padding(16);
        cardCourseList.Size = new System.Drawing.Size(1112, 680);
        cardCourseList.TabIndex = 0;
        // 
        // dgvCourses
        // 
        dgvCourses.AllowUserToAddRows = false;
        dgvCourses.AllowUserToDeleteRows = false;
        dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCourses.BackgroundColor = System.Drawing.Color.White;
        dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvCourses.ColumnHeadersHeight = 38;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvCourses.DefaultCellStyle = dataGridViewCellStyle2;
        dgvCourses.EnableHeadersVisualStyles = false;
        dgvCourses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvCourses.Location = new System.Drawing.Point(16, 110);
        dgvCourses.MultiSelect = false;
        dgvCourses.Name = "dgvCourses";
        dgvCourses.ReadOnly = true;
        dgvCourses.RowHeadersVisible = false;
        dgvCourses.RowTemplate.Height = 44;
        dgvCourses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCourses.Size = new System.Drawing.Size(1080, 550);
        dgvCourses.TabIndex = 2;
        // 
        // pnlCourseFilterBar
        // 
        pnlCourseFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        pnlCourseFilterBar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlCourseFilterBar.Controls.Add(cboLevelFilter);
        pnlCourseFilterBar.Controls.Add(cboStatusFilter);
        pnlCourseFilterBar.Controls.Add(txtSearchCourse);
        pnlCourseFilterBar.Location = new System.Drawing.Point(16, 48);
        pnlCourseFilterBar.Name = "pnlCourseFilterBar";
        pnlCourseFilterBar.Size = new System.Drawing.Size(1080, 48);
        pnlCourseFilterBar.TabIndex = 1;
        // 
        // cboLevelFilter
        // 
        cboLevelFilter.Location = new System.Drawing.Point(595, 6);
        cboLevelFilter.Name = "cboLevelFilter";
        cboLevelFilter.Size = new System.Drawing.Size(220, 36);
        cboLevelFilter.TabIndex = 2;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(395, 6);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(190, 36);
        cboStatusFilter.TabIndex = 1;
        // 
        // txtSearchCourse
        // 
        txtSearchCourse.Location = new System.Drawing.Point(10, 6);
        txtSearchCourse.Name = "txtSearchCourse";
        txtSearchCourse.Placeholder = "🔍  Tìm theo mã khóa học, tên khóa học...";
        txtSearchCourse.Size = new System.Drawing.Size(370, 36);
        txtSearchCourse.TabIndex = 0;
        // 
        // lblCourseListTitle
        // 
        lblCourseListTitle.AutoSize = true;
        lblCourseListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCourseListTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblCourseListTitle.Location = new System.Drawing.Point(16, 14);
        lblCourseListTitle.Name = "lblCourseListTitle";
        lblCourseListTitle.Size = new System.Drawing.Size(202, 28);
        lblCourseListTitle.TabIndex = 0;
        lblCourseListTitle.Text = "Danh sách khóa học";
        // 
        // CourseManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "CourseManagementView";
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCourseList.ResumeLayout(false);
        cardCourseList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
        pnlCourseFilterBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnAddCourse;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardCourseList;
    private System.Windows.Forms.Label lblCourseListTitle;
    private System.Windows.Forms.Panel pnlCourseFilterBar;
    private ECMS.UI.Controls.AppTextBox txtSearchCourse;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboLevelFilter;
    private ECMS.UI.Controls.AppDataGrid dgvCourses;
}
