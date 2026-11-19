namespace ECMS.UI.UserControls;

partial class TeacherAttendanceSummaryView
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
        btnBackAttendance = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardSummary = new ECMS.UI.Controls.AppCard();
        btnRecordTracking = new ECMS.UI.Controls.AppButton();
        btnExportSummary = new ECMS.UI.Controls.AppButton();
        lblFinalCondition = new System.Windows.Forms.Label();
        lblClassTotal = new System.Windows.Forms.Label();
        dgvSummary = new ECMS.UI.Controls.AppDataGrid();
        lblSummaryTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnBackAttendance);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnBackAttendance
        // 
        btnBackAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBackAttendance.BackColor = System.Drawing.Color.White;
        btnBackAttendance.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackAttendance.CornerRadius = 5;
        btnBackAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBackAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBackAttendance.Location = new System.Drawing.Point(976, 20);
        btnBackAttendance.Name = "btnBackAttendance";
        btnBackAttendance.Size = new System.Drawing.Size(160, 36);
        btnBackAttendance.TabIndex = 3;
        btnBackAttendance.Text = "Quay lại điểm danh";
        btnBackAttendance.UseVisualStyleBackColor = false;
        btnBackAttendance.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(389, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tổng hợp chuyên cần · IELTS-F01";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardSummary);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 2;
        // 
        // cardSummary
        // 
        cardSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardSummary.BackColor = System.Drawing.Color.White;
        cardSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardSummary.BorderWidth = 1;
        cardSummary.Controls.Add(btnRecordTracking);
        cardSummary.Controls.Add(btnExportSummary);
        cardSummary.Controls.Add(lblFinalCondition);
        cardSummary.Controls.Add(lblClassTotal);
        cardSummary.Controls.Add(dgvSummary);
        cardSummary.Controls.Add(lblSummaryTitle);
        cardSummary.CornerRadius = 6;
        cardSummary.Location = new System.Drawing.Point(24, 22);
        cardSummary.Name = "cardSummary";
        cardSummary.Padding = new System.Windows.Forms.Padding(20);
        cardSummary.Size = new System.Drawing.Size(1112, 633);
        cardSummary.TabIndex = 1;
        // 
        // btnRecordTracking
        // 
        btnRecordTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnRecordTracking.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnRecordTracking.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnRecordTracking.CornerRadius = 5;
        btnRecordTracking.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRecordTracking.FlatAppearance.BorderSize = 0;
        btnRecordTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRecordTracking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnRecordTracking.ForeColor = System.Drawing.Color.White;
        btnRecordTracking.Location = new System.Drawing.Point(230, 578);
        btnRecordTracking.Name = "btnRecordTracking";
        btnRecordTracking.Size = new System.Drawing.Size(250, 32);
        btnRecordTracking.TabIndex = 8;
        btnRecordTracking.Text = "Ghi nhận theo dõi học viên vắng";
        btnRecordTracking.UseVisualStyleBackColor = false;
        btnRecordTracking.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnExportSummary
        // 
        btnExportSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnExportSummary.BackColor = System.Drawing.Color.White;
        btnExportSummary.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportSummary.CornerRadius = 5;
        btnExportSummary.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnExportSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExportSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnExportSummary.Location = new System.Drawing.Point(20, 578);
        btnExportSummary.Name = "btnExportSummary";
        btnExportSummary.Size = new System.Drawing.Size(190, 32);
        btnExportSummary.TabIndex = 7;
        btnExportSummary.Text = "Xuất tổng hợp ra tệp cục bộ";
        btnExportSummary.UseVisualStyleBackColor = false;
        btnExportSummary.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblFinalCondition
        // 
        lblFinalCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblFinalCondition.AutoSize = true;
        lblFinalCondition.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblFinalCondition.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFinalCondition.Location = new System.Drawing.Point(20, 548);
        lblFinalCondition.Name = "lblFinalCondition";
        lblFinalCondition.Size = new System.Drawing.Size(273, 19);
        lblFinalCondition.TabIndex = 6;
        lblFinalCondition.Text = "Điều kiện cuối khóa: ≥80% trên đủ 24 buổi";
        // 
        // lblClassTotal
        // 
        lblClassTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblClassTotal.AutoSize = true;
        lblClassTotal.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
        lblClassTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblClassTotal.Location = new System.Drawing.Point(20, 516);
        lblClassTotal.Name = "lblClassTotal";
        lblClassTotal.Size = new System.Drawing.Size(299, 20);
        lblClassTotal.TabIndex = 4;
        lblClassTotal.Text = "Toàn lớp: 130 / 144 lượt tham dự · 90,3%";
        // 
        // dgvSummary
        // 
        dgvSummary.AllowUserToAddRows = false;
        dgvSummary.AllowUserToDeleteRows = false;
        dgvSummary.AllowUserToResizeColumns = false;
        dgvSummary.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSummary.BackgroundColor = System.Drawing.Color.White;
        dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvSummary.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSummary.EnableHeadersVisualStyles = false;
        dgvSummary.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvSummary.Location = new System.Drawing.Point(20, 50);
        dgvSummary.MultiSelect = false;
        dgvSummary.Name = "dgvSummary";
        dgvSummary.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvSummary.RowHeadersVisible = false;
        dgvSummary.RowHeadersWidth = 51;
        dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSummary.Size = new System.Drawing.Size(1072, 433);
        dgvSummary.TabIndex = 1;
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSummaryTitle.Location = new System.Drawing.Point(20, 16);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new System.Drawing.Size(223, 25);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Tổng hợp theo học viên";
        // 
        // TeacherAttendanceSummaryView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardSummary.ResumeLayout(false);
        cardSummary.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnBackAttendance;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardSummary;
    private System.Windows.Forms.Label lblSummaryTitle;
    private ECMS.UI.Controls.AppDataGrid dgvSummary;
    private System.Windows.Forms.Label lblClassTotal;
    private System.Windows.Forms.Label lblFinalCondition;
    private ECMS.UI.Controls.AppButton btnExportSummary;
    private ECMS.UI.Controls.AppButton btnRecordTracking;
}
