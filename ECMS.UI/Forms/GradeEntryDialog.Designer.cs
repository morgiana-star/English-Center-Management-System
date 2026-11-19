namespace ECMS.UI.Forms;

partial class GradeEntryDialog
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnClose = new ECMS.UI.Controls.AppButton();
        cboClass = new System.Windows.Forms.ComboBox();
        lblSwitchClass = new System.Windows.Forms.Label();
        lblSub = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBody = new System.Windows.Forms.Panel();
        cardGrid = new ECMS.UI.Controls.AppCard();
        dgvStudentGrades = new ECMS.UI.Controls.AppDataGrid();
        lblGridTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudentGrades).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnClose);
        pnlHeader.Controls.Add(cboClass);
        pnlHeader.Controls.Add(lblSwitchClass);
        pnlHeader.Controls.Add(lblSub);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1180, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnClose
        // 
        btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnClose.BackColor = System.Drawing.Color.White;
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnClose.Location = new System.Drawing.Point(1075, 18);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(80, 36);
        btnClose.TabIndex = 4;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cboClass
        // 
        cboClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        cboClass.FormattingEnabled = true;
        cboClass.Location = new System.Drawing.Point(831, 20);
        cboClass.Name = "cboClass";
        cboClass.Size = new System.Drawing.Size(238, 29);
        cboClass.TabIndex = 3;
        // 
        // lblSwitchClass
        // 
        lblSwitchClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblSwitchClass.AutoSize = true;
        lblSwitchClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSwitchClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblSwitchClass.Location = new System.Drawing.Point(750, 27);
        lblSwitchClass.Name = "lblSwitchClass";
        lblSwitchClass.Size = new System.Drawing.Size(75, 20);
        lblSwitchClass.TabIndex = 2;
        lblSwitchClass.Text = "Chọn lớp:";
        // 
        // lblSub
        // 
        lblSub.AutoSize = true;
        lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblSub.Location = new System.Drawing.Point(24, 46);
        lblSub.Name = "lblSub";
        lblSub.Size = new System.Drawing.Size(495, 20);
        lblSub.TabIndex = 1;
        lblSub.Text = "Khóa học: IELTS Foundation | Giáo viên: Nguyễn Hoàng Anh | Phòng: P201";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(339, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Sổ điểm lớp học · IELTS-F01";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnSave);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 660);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(1180, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 5;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(995, 12);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(160, 36);
        btnSave.TabIndex = 1;
        btnSave.Text = "Lưu bảng điểm";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancel.Location = new System.Drawing.Point(890, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 36);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardGrid);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlBody.Size = new System.Drawing.Size(1180, 585);
        pnlBody.TabIndex = 1;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGrid.BorderWidth = 1;
        cardGrid.Controls.Add(dgvStudentGrades);
        cardGrid.Controls.Add(lblGridTitle);
        cardGrid.CornerRadius = 8;
        cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardGrid.Location = new System.Drawing.Point(24, 16);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(16);
        cardGrid.Size = new System.Drawing.Size(1132, 553);
        cardGrid.TabIndex = 0;
        // 
        // dgvStudentGrades
        // 
        dgvStudentGrades.AllowUserToAddRows = false;
        dgvStudentGrades.AllowUserToDeleteRows = false;
        dgvStudentGrades.AllowUserToResizeColumns = false;
        dgvStudentGrades.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvStudentGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvStudentGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvStudentGrades.BackgroundColor = System.Drawing.Color.White;
        dgvStudentGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvStudentGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvStudentGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudentGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvStudentGrades.ColumnHeadersHeight = 38;
        dgvStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvStudentGrades.DefaultCellStyle = dataGridViewCellStyle3;
        dgvStudentGrades.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvStudentGrades.EnableHeadersVisualStyles = false;
        dgvStudentGrades.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvStudentGrades.Location = new System.Drawing.Point(16, 48);
        dgvStudentGrades.MultiSelect = false;
        dgvStudentGrades.Name = "dgvStudentGrades";
        dgvStudentGrades.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudentGrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvStudentGrades.RowHeadersVisible = false;
        dgvStudentGrades.RowHeadersWidth = 51;
        dgvStudentGrades.RowTemplate.Height = 40;
        dgvStudentGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dgvStudentGrades.Size = new System.Drawing.Size(1100, 489);
        dgvStudentGrades.TabIndex = 1;
        // 
        // lblGridTitle
        // 
        lblGridTitle.AutoSize = true;
        lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGridTitle.Location = new System.Drawing.Point(16, 16);
        lblGridTitle.Name = "lblGridTitle";
        lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
        lblGridTitle.Size = new System.Drawing.Size(196, 32);
        lblGridTitle.TabIndex = 0;
        lblGridTitle.Text = "BẢNG ĐIỂM HỌC VIÊN ";
        // 
        // GradeEntryDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1180, 720);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Sổ điểm lớp học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        cardGrid.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudentGrades).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSub;
    private System.Windows.Forms.Label lblSwitchClass;
    private System.Windows.Forms.ComboBox cboClass;
    private ECMS.UI.Controls.AppButton btnClose;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardGrid;
    private System.Windows.Forms.Label lblGridTitle;
    private ECMS.UI.Controls.AppDataGrid dgvStudentGrades;
}
