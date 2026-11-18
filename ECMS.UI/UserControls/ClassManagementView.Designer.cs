namespace ECMS.UI.UserControls;

partial class ClassManagementView
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
        btnAddClass = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardClassList = new ECMS.UI.Controls.AppCard();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        pnlClassFilterBar = new System.Windows.Forms.Panel();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        lblClassListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardClassList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        pnlClassFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddClass);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddClass
        // 
        btnAddClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnAddClass.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddClass.CornerRadius = 6;
        btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddClass.ForeColor = System.Drawing.Color.White;
        btnAddClass.Location = new System.Drawing.Point(995, 20);
        btnAddClass.Name = "btnAddClass";
        btnAddClass.Size = new System.Drawing.Size(140, 36);
        btnAddClass.TabIndex = 3;
        btnAddClass.Text = "+ Thêm lớp học";
        btnAddClass.UseVisualStyleBackColor = false;
        btnAddClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(120, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lớp học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlBody.Controls.Add(cardClassList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardClassList
        // 
        cardClassList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassList.BackColor = System.Drawing.Color.White;
        cardClassList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardClassList.BorderWidth = 1;
        cardClassList.Controls.Add(dgvClasses);
        cardClassList.Controls.Add(pnlClassFilterBar);
        cardClassList.Controls.Add(lblClassListTitle);
        cardClassList.CornerRadius = 8;
        cardClassList.Location = new System.Drawing.Point(24, 20);
        cardClassList.Name = "cardClassList";
        cardClassList.Padding = new System.Windows.Forms.Padding(16);
        cardClassList.Size = new System.Drawing.Size(1112, 680);
        cardClassList.TabIndex = 0;
        // 
        // dgvClasses
        // 
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.AllowUserToDeleteRows = false;
        dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClasses.BackgroundColor = System.Drawing.Color.White;
        dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvClasses.ColumnHeadersHeight = 38;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClasses.DefaultCellStyle = dataGridViewCellStyle2;
        dgvClasses.EnableHeadersVisualStyles = false;
        dgvClasses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvClasses.Location = new System.Drawing.Point(16, 110);
        dgvClasses.MultiSelect = false;
        dgvClasses.Name = "dgvClasses";
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.RowTemplate.Height = 44;
        dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.Size = new System.Drawing.Size(1080, 550);
        dgvClasses.TabIndex = 2;
        // 
        // pnlClassFilterBar
        // 
        pnlClassFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        pnlClassFilterBar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlClassFilterBar.Controls.Add(cboStatusFilter);
        pnlClassFilterBar.Controls.Add(cboCourseFilter);
        pnlClassFilterBar.Controls.Add(txtSearchClass);
        pnlClassFilterBar.Location = new System.Drawing.Point(16, 48);
        pnlClassFilterBar.Name = "pnlClassFilterBar";
        pnlClassFilterBar.Size = new System.Drawing.Size(1080, 48);
        pnlClassFilterBar.TabIndex = 1;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(600, 6);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(190, 36);
        cboStatusFilter.TabIndex = 2;
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Location = new System.Drawing.Point(395, 6);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(195, 36);
        cboCourseFilter.TabIndex = 1;
        // 
        // txtSearchClass
        // 
        txtSearchClass.Location = new System.Drawing.Point(10, 6);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍  Tìm theo mã lớp, khóa học, giáo viên, phòng...";
        txtSearchClass.Size = new System.Drawing.Size(370, 36);
        txtSearchClass.TabIndex = 0;
        // 
        // lblClassListTitle
        // 
        lblClassListTitle.AutoSize = true;
        lblClassListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblClassListTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblClassListTitle.Location = new System.Drawing.Point(16, 14);
        lblClassListTitle.Name = "lblClassListTitle";
        lblClassListTitle.Size = new System.Drawing.Size(186, 28);
        lblClassListTitle.TabIndex = 0;
        lblClassListTitle.Text = "Danh sách lớp học";
        // 
        // ClassManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "ClassManagementView";
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardClassList.ResumeLayout(false);
        cardClassList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        pnlClassFilterBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnAddClass;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardClassList;
    private System.Windows.Forms.Label lblClassListTitle;
    private System.Windows.Forms.Panel pnlClassFilterBar;
    private ECMS.UI.Controls.AppTextBox txtSearchClass;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
}
