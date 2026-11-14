namespace ECMS.UI.Forms;

partial class ArchiveStudentDialog
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
        lblTitle = new System.Windows.Forms.Label();
        lblStudentInfo = new System.Windows.Forms.Label();
        lblClassInfo = new System.Windows.Forms.Label();
        lblImpactInfo = new System.Windows.Forms.Label();
        lblReason = new System.Windows.Forms.Label();
        txtArchiveReason = new ECMS.UI.Controls.AppTextBox();
        btnCancelArchive = new ECMS.UI.Controls.AppButton();
        btnConfirmArchive = new ECMS.UI.Controls.AppButton();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(23, 21);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(255, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Lưu trữ hồ sơ học viên?";
        // 
        // lblStudentInfo
        // 
        lblStudentInfo.AutoSize = true;
        lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStudentInfo.Location = new System.Drawing.Point(23, 69);
        lblStudentInfo.Name = "lblStudentInfo";
        lblStudentInfo.Size = new System.Drawing.Size(282, 21);
        lblStudentInfo.TabIndex = 2;
        lblStudentInfo.Text = "Học viên:  Nguyễn Minh Anh · HV-0241";
        // 
        // lblClassInfo
        // 
        lblClassInfo.AutoSize = true;
        lblClassInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblClassInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblClassInfo.Location = new System.Drawing.Point(23, 99);
        lblClassInfo.Name = "lblClassInfo";
        lblClassInfo.Size = new System.Drawing.Size(248, 21);
        lblClassInfo.TabIndex = 3;
        lblClassInfo.Text = "Lớp hiện tại:  IELTS-F01 · Đang học";
        // 
        // lblImpactInfo
        // 
        lblImpactInfo.AutoSize = true;
        lblImpactInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblImpactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblImpactInfo.Location = new System.Drawing.Point(23, 129);
        lblImpactInfo.Name = "lblImpactInfo";
        lblImpactInfo.Size = new System.Drawing.Size(286, 21);
        lblImpactInfo.TabIndex = 4;
        lblImpactInfo.Text = "Tác động:  Ẩn khỏi danh sách, giữ lịch sử";
        // 
        // lblReason
        // 
        lblReason.AutoSize = true;
        lblReason.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblReason.Location = new System.Drawing.Point(23, 164);
        lblReason.Name = "lblReason";
        lblReason.Size = new System.Drawing.Size(111, 20);
        lblReason.TabIndex = 5;
        lblReason.Text = "Lý do lưu trữ *";
        // 
        // txtArchiveReason
        // 
        txtArchiveReason.BackColor = System.Drawing.Color.Transparent;
        txtArchiveReason.CornerRadius = 6;
        txtArchiveReason.ErrorMessage = "";
        txtArchiveReason.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtArchiveReason.HasError = false;
        txtArchiveReason.Location = new System.Drawing.Point(23, 187);
        txtArchiveReason.Name = "txtArchiveReason";
        txtArchiveReason.Placeholder = "Theo yêu cầu phụ huynh — chờ xác nhận";
        txtArchiveReason.ReadOnly = false;
        txtArchiveReason.Size = new System.Drawing.Size(460, 32);
        txtArchiveReason.TabIndex = 6;
        txtArchiveReason.UseSystemPasswordChar = false;
        // 
        // btnCancelArchive
        // 
        btnCancelArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelArchive.BackColor = System.Drawing.Color.White;
        btnCancelArchive.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelArchive.CornerRadius = 6;
        btnCancelArchive.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelArchive.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnCancelArchive.Location = new System.Drawing.Point(263, 250);
        btnCancelArchive.Name = "btnCancelArchive";
        btnCancelArchive.Size = new System.Drawing.Size(95, 36);
        btnCancelArchive.TabIndex = 8;
        btnCancelArchive.Text = "Hủy";
        btnCancelArchive.UseVisualStyleBackColor = false;
        btnCancelArchive.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnConfirmArchive
        // 
        btnConfirmArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnConfirmArchive.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnConfirmArchive.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmArchive.CornerRadius = 6;
        btnConfirmArchive.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmArchive.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmArchive.ForeColor = System.Drawing.Color.White;
        btnConfirmArchive.Location = new System.Drawing.Point(366, 250);
        btnConfirmArchive.Name = "btnConfirmArchive";
        btnConfirmArchive.Size = new System.Drawing.Size(120, 36);
        btnConfirmArchive.TabIndex = 9;
        btnConfirmArchive.Text = "Lưu trữ hồ sơ";
        btnConfirmArchive.UseVisualStyleBackColor = false;
        btnConfirmArchive.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // ArchiveStudentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(510, 315);
        Controls.Add(btnConfirmArchive);
        Controls.Add(btnCancelArchive);
        Controls.Add(txtArchiveReason);
        Controls.Add(lblReason);
        Controls.Add(lblImpactInfo);
        Controls.Add(lblClassInfo);
        Controls.Add(lblStudentInfo);
        Controls.Add(lblTitle);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Lưu trữ hồ sơ học viên — ECMS";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblStudentInfo;
    private System.Windows.Forms.Label lblClassInfo;
    private System.Windows.Forms.Label lblImpactInfo;
    private System.Windows.Forms.Label lblReason;
    private ECMS.UI.Controls.AppTextBox txtArchiveReason;
    private ECMS.UI.Controls.AppButton btnCancelArchive;
    private ECMS.UI.Controls.AppButton btnConfirmArchive;
}
