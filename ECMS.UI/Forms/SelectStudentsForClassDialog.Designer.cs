namespace ECMS.UI.Forms;

partial class SelectStudentsForClassDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlFilter = new System.Windows.Forms.Panel();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        lblSearch = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBody = new System.Windows.Forms.Panel();
        cardGrid = new ECMS.UI.Controls.AppCard();
        dgvStudents = new ECMS.UI.Controls.AppDataGrid();
        colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        pnlHeader.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(860, 72);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(300, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Thêm học viên vào lớp học";
        // 
        // pnlFilter
        // 
        pnlFilter.BackColor = System.Drawing.Color.White;
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Controls.Add(lblSearch);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(0, 72);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new System.Windows.Forms.Padding(24, 8, 24, 12);
        pnlFilter.Size = new System.Drawing.Size(860, 56);
        pnlFilter.TabIndex = 1;
        // 
        // txtSearch
        // 
        txtSearch.BackColor = System.Drawing.Color.Transparent;
        txtSearch.CornerRadius = 5;
        txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
        txtSearch.ErrorMessage = "";
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.HasError = false;
        txtSearch.Location = new System.Drawing.Point(114, 8);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "Nhập mã học viên, họ và tên, hoặc số điện thoại để tìm...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(722, 36);
        txtSearch.TabIndex = 1;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // lblSearch
        // 
        lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSearch.Location = new System.Drawing.Point(24, 8);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(90, 36);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm:";
        lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnConfirm);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 520);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(860, 60);
        pnlFooter.TabIndex = 3;
        // 
        // btnConfirm
        // 
        btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirm.CornerRadius = 5;
        btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirm.Location = new System.Drawing.Point(676, 12);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new System.Drawing.Size(160, 36);
        btnConfirm.TabIndex = 2;
        btnConfirm.Text = "Xác nhận thêm (0)";
        btnConfirm.UseVisualStyleBackColor = true;
        btnConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(570, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardGrid);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 128);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlBody.Size = new System.Drawing.Size(860, 392);
        pnlBody.TabIndex = 2;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGrid.BorderWidth = 1;
        cardGrid.Controls.Add(dgvStudents);
        cardGrid.CornerRadius = 6;
        cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardGrid.Location = new System.Drawing.Point(24, 12);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(1);
        cardGrid.Size = new System.Drawing.Size(812, 368);
        cardGrid.TabIndex = 0;
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
        dgvStudents.ColumnHeadersHeight = 36;
        dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSelect, colCode, colName, colPhone, colEmail, colStatus });
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
        dgvStudents.Location = new System.Drawing.Point(1, 1);
        dgvStudents.MultiSelect = false;
        dgvStudents.Name = "dgvStudents";
        dgvStudents.ReadOnly = true;
        dgvStudents.RowHeadersVisible = false;
        dgvStudents.RowHeadersWidth = 51;
        dgvStudents.RowTemplate.Height = 34;
        dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvStudents.Size = new System.Drawing.Size(810, 366);
        dgvStudents.TabIndex = 0;
        // 
        // colSelect
        // 
        colSelect.HeaderText = "Chọn";
        colSelect.MinimumWidth = 6;
        colSelect.Name = "colSelect";
        colSelect.ReadOnly = true;
        // 
        // colCode
        // 
        colCode.HeaderText = "Mã HV";
        colCode.MinimumWidth = 6;
        colCode.Name = "colCode";
        colCode.ReadOnly = true;
        // 
        // colName
        // 
        colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        colName.HeaderText = "Họ và tên";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colPhone
        // 
        colPhone.HeaderText = "Số điện thoại";
        colPhone.MinimumWidth = 6;
        colPhone.Name = "colPhone";
        colPhone.ReadOnly = true;
        // 
        // colEmail
        // 
        colEmail.HeaderText = "Email";
        colEmail.MinimumWidth = 6;
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Trạng thái";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // SelectStudentsForClassDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(860, 580);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlFilter);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm học viên vào lớp · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFilter.ResumeLayout(false);
        pnlFooter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlFilter;
    private System.Windows.Forms.Label lblSearch;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnConfirm;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardGrid;
    private ECMS.UI.Controls.AppDataGrid dgvStudents;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
}
