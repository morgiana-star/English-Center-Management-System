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
        btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
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
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(136, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Khóa học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
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
        cardCourseList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
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
        dgvCourses.AllowUserToResizeColumns = false;
        dgvCourses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCourses.BackgroundColor = System.Drawing.Color.White;
        dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvCourses.ColumnHeadersHeight = 38;
        dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvCourses.EnableHeadersVisualStyles = false;
        dgvCourses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvCourses.Location = new System.Drawing.Point(16, 110);
        dgvCourses.MultiSelect = false;
        dgvCourses.Name = "dgvCourses";
        dgvCourses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvCourses.RowHeadersVisible = false;
        dgvCourses.RowHeadersWidth = 51;
        dgvCourses.RowTemplate.Height = 44;
        dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCourses.Size = new System.Drawing.Size(1080, 550);
        dgvCourses.TabIndex = 2;
        // 
        // pnlCourseFilterBar
        // 
        pnlCourseFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlCourseFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
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
        cboLevelFilter.BackColor = System.Drawing.Color.Transparent;
        cboLevelFilter.CornerRadius = 5;
        cboLevelFilter.DataSource = null;
        cboLevelFilter.DisplayMember = "";
        cboLevelFilter.Location = new System.Drawing.Point(595, 6);
        cboLevelFilter.Name = "cboLevelFilter";
        cboLevelFilter.SelectedIndex = -1;
        cboLevelFilter.SelectedItem = null;
        cboLevelFilter.SelectedValue = null;
        cboLevelFilter.Size = new System.Drawing.Size(220, 36);
        cboLevelFilter.TabIndex = 2;
        cboLevelFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(395, 6);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(190, 36);
        cboStatusFilter.TabIndex = 1;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchCourse
        // 
        txtSearchCourse.BackColor = System.Drawing.Color.Transparent;
        txtSearchCourse.CornerRadius = 5;
        txtSearchCourse.ErrorMessage = "";
        txtSearchCourse.HasError = false;
        txtSearchCourse.Location = new System.Drawing.Point(10, 6);
        txtSearchCourse.Name = "txtSearchCourse";
        txtSearchCourse.Placeholder = "Tìm theo mã khóa học, tên khóa học...";
        txtSearchCourse.ReadOnly = false;
        txtSearchCourse.Size = new System.Drawing.Size(370, 36);
        txtSearchCourse.TabIndex = 0;
        txtSearchCourse.UseSystemPasswordChar = false;
        // 
        // lblCourseListTitle
        // 
        lblCourseListTitle.AutoSize = true;
        lblCourseListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCourseListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
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
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
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
