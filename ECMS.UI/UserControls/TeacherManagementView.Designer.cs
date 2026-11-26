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
        btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnAddTeacher.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddTeacher.CornerRadius = 6;
        btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddTeacher.ForeColor = System.Drawing.Color.White;
        btnAddTeacher.Location = new System.Drawing.Point(980, 20);
        btnAddTeacher.Name = "btnAddTeacher";
        btnAddTeacher.Size = new System.Drawing.Size(156, 36);
        btnAddTeacher.TabIndex = 3;
        btnAddTeacher.Text = "+ Thêm giáo viên";
        btnAddTeacher.UseVisualStyleBackColor = false;
        btnAddTeacher.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(137, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Giáo viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
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
        cardTeacherList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
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
        dgvTeachers.AllowUserToResizeColumns = false;
        dgvTeachers.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvTeachers.BackgroundColor = System.Drawing.Color.White;
        dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvTeachers.ColumnHeadersHeight = 38;
        dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvTeachers.DefaultCellStyle = dataGridViewCellStyle3;
        dgvTeachers.EnableHeadersVisualStyles = false;
        dgvTeachers.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvTeachers.Location = new System.Drawing.Point(16, 110);
        dgvTeachers.MultiSelect = false;
        dgvTeachers.Name = "dgvTeachers";
        dgvTeachers.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvTeachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.RowHeadersWidth = 51;
        dgvTeachers.RowTemplate.Height = 44;
        dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.Size = new System.Drawing.Size(1080, 550);
        dgvTeachers.TabIndex = 2;
        // 
        // pnlTeacherFilterBar
        // 
        pnlTeacherFilterBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlTeacherFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
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
        cboSpecialtyFilter.BackColor = System.Drawing.Color.Transparent;
        cboSpecialtyFilter.CornerRadius = 5;
        cboSpecialtyFilter.DataSource = null;
        cboSpecialtyFilter.DisplayMember = "";
        cboSpecialtyFilter.Location = new System.Drawing.Point(596, 6);
        cboSpecialtyFilter.Name = "cboSpecialtyFilter";
        cboSpecialtyFilter.SelectedIndex = -1;
        cboSpecialtyFilter.SelectedItem = null;
        cboSpecialtyFilter.SelectedValue = null;
        cboSpecialtyFilter.Size = new System.Drawing.Size(220, 36);
        cboSpecialtyFilter.TabIndex = 2;
        cboSpecialtyFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(400, 6);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(190, 36);
        cboStatusFilter.TabIndex = 1;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchTeacher
        // 
        txtSearchTeacher.BackColor = System.Drawing.Color.Transparent;
        txtSearchTeacher.CornerRadius = 5;
        txtSearchTeacher.ErrorMessage = "";
        txtSearchTeacher.HasError = false;
        txtSearchTeacher.Location = new System.Drawing.Point(10, 6);
        txtSearchTeacher.Name = "txtSearchTeacher";
        txtSearchTeacher.Placeholder = "Tìm theo mã giáo viên, họ tên, số điện thoại";
        txtSearchTeacher.ReadOnly = false;
        txtSearchTeacher.Size = new System.Drawing.Size(370, 36);
        txtSearchTeacher.TabIndex = 0;
        txtSearchTeacher.UseSystemPasswordChar = false;
        // 
        // lblTeacherListTitle
        // 
        lblTeacherListTitle.AutoSize = true;
        lblTeacherListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTeacherListTitle.Location = new System.Drawing.Point(16, 14);
        lblTeacherListTitle.Name = "lblTeacherListTitle";
        lblTeacherListTitle.Size = new System.Drawing.Size(203, 28);
        lblTeacherListTitle.TabIndex = 0;
        lblTeacherListTitle.Text = "Danh sách giáo viên";
        // 
        // TeacherManagementView
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
