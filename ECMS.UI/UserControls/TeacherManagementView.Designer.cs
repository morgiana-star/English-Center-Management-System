namespace ECMS.UI.UserControls;

partial class TeacherManagementView
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
        btnAddTeacher = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardTeacherList = new ECMS.UI.Controls.AppCard();
        dgvTeachers = new ECMS.UI.Controls.AppDataGrid();
        pnlTeacherFilterBar = new System.Windows.Forms.Panel();
        cboSpecialtyFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchTeacher = new ECMS.UI.Controls.AppTextBox();
        lblTeacherListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardTeacherList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
        pnlTeacherFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddTeacher);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddTeacher
        // 
        btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddTeacher.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddTeacher.CornerRadius = 6;
        btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddTeacher.ForeColor = System.Drawing.Color.White;
        btnAddTeacher.Location = new System.Drawing.Point(996, 20);
        btnAddTeacher.Name = "btnAddTeacher";
        btnAddTeacher.Size = new System.Drawing.Size(140, 36);
        btnAddTeacher.TabIndex = 3;
        btnAddTeacher.Text = "+ Thêm giáo viên";
        btnAddTeacher.UseVisualStyleBackColor = false;
        btnAddTeacher.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(134, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Giáo viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlBody.Controls.Add(cardTeacherList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardTeacherList
        // 
        cardTeacherList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardTeacherList.BackColor = System.Drawing.Color.White;
        cardTeacherList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardTeacherList.BorderWidth = 1;
        cardTeacherList.Controls.Add(dgvTeachers);
        cardTeacherList.Controls.Add(pnlTeacherFilterBar);
        cardTeacherList.Controls.Add(lblTeacherListTitle);
        cardTeacherList.CornerRadius = 8;
        cardTeacherList.Location = new System.Drawing.Point(24, 20);
        cardTeacherList.Name = "cardTeacherList";
        cardTeacherList.Padding = new System.Windows.Forms.Padding(16);
        cardTeacherList.Size = new System.Drawing.Size(1112, 680);
        cardTeacherList.TabIndex = 0;
        // 
        // dgvTeachers
        // 
        dgvTeachers.AllowUserToAddRows = false;
        dgvTeachers.AllowUserToDeleteRows = false;
        dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvTeachers.BackgroundColor = System.Drawing.Color.White;
        dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvTeachers.ColumnHeadersHeight = 38;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvTeachers.DefaultCellStyle = dataGridViewCellStyle2;
        dgvTeachers.EnableHeadersVisualStyles = false;
        dgvTeachers.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvTeachers.Location = new System.Drawing.Point(16, 110);
        dgvTeachers.MultiSelect = false;
        dgvTeachers.Name = "dgvTeachers";
        dgvTeachers.ReadOnly = true;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.RowTemplate.Height = 44;
        dgvTeachers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.Size = new System.Drawing.Size(1080, 550);
        dgvTeachers.TabIndex = 2;
        // 
        // pnlTeacherFilterBar
        // 
        pnlTeacherFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        pnlTeacherFilterBar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlTeacherFilterBar.Controls.Add(cboSpecialtyFilter);
        pnlTeacherFilterBar.Controls.Add(cboStatusFilter);
        pnlTeacherFilterBar.Controls.Add(txtSearchTeacher);
        pnlTeacherFilterBar.Location = new System.Drawing.Point(16, 48);
        pnlTeacherFilterBar.Name = "pnlTeacherFilterBar";
        pnlTeacherFilterBar.Size = new System.Drawing.Size(1080, 48);
        pnlTeacherFilterBar.TabIndex = 1;
        // 
        // cboSpecialtyFilter
        // 
        cboSpecialtyFilter.Location = new System.Drawing.Point(595, 6);
        cboSpecialtyFilter.Name = "cboSpecialtyFilter";
        cboSpecialtyFilter.Size = new System.Drawing.Size(220, 36);
        cboSpecialtyFilter.TabIndex = 2;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(395, 6);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(190, 36);
        cboStatusFilter.TabIndex = 1;
        // 
        // txtSearchTeacher
        // 
        txtSearchTeacher.Location = new System.Drawing.Point(10, 6);
        txtSearchTeacher.Name = "txtSearchTeacher";
        txtSearchTeacher.Placeholder = "🔍  Tìm theo mã GV, họ tên, SĐT, chuyên môn...";
        txtSearchTeacher.Size = new System.Drawing.Size(370, 36);
        txtSearchTeacher.TabIndex = 0;
        // 
        // lblTeacherListTitle
        // 
        lblTeacherListTitle.AutoSize = true;
        lblTeacherListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherListTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTeacherListTitle.Location = new System.Drawing.Point(16, 14);
        lblTeacherListTitle.Name = "lblTeacherListTitle";
        lblTeacherListTitle.Size = new System.Drawing.Size(201, 28);
        lblTeacherListTitle.TabIndex = 0;
        lblTeacherListTitle.Text = "Danh sách giáo viên";
        // 
        // TeacherManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "TeacherManagementView";
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardTeacherList.ResumeLayout(false);
        cardTeacherList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
        pnlTeacherFilterBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnAddTeacher;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardTeacherList;
    private System.Windows.Forms.Label lblTeacherListTitle;
    private System.Windows.Forms.Panel pnlTeacherFilterBar;
    private ECMS.UI.Controls.AppTextBox txtSearchTeacher;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboSpecialtyFilter;
    private ECMS.UI.Controls.AppDataGrid dgvTeachers;
}
