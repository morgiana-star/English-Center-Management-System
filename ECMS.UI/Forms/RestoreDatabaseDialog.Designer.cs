namespace ECMS.UI.Forms;

partial class RestoreDatabaseDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        btnCloseTop = new System.Windows.Forms.Label();
        lblDialogSubtitle = new System.Windows.Forms.Label();
        lblDialogTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        btnConfirmRestore = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        lblRestoreFootnote = new System.Windows.Forms.Label();
        lblIntegrityVal = new System.Windows.Forms.Label();
        lblIntegrityKey = new System.Windows.Forms.Label();
        lblTargetDbVal = new System.Windows.Forms.Label();
        lblTargetDbKey = new System.Windows.Forms.Label();
        lblPreBackupVal = new System.Windows.Forms.Label();
        lblPreBackupKey = new System.Windows.Forms.Label();
        lblSourceBackupVal = new System.Windows.Forms.Label();
        lblSourceBackupKey = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCloseTop);
        pnlHeader.Controls.Add(lblDialogSubtitle);
        pnlHeader.Controls.Add(lblDialogTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(650, 70);
        pnlHeader.TabIndex = 0;
        // 
        // btnCloseTop
        // 
        btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCloseTop.AutoSize = true;
        btnCloseTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCloseTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCloseTop.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnCloseTop.Location = new System.Drawing.Point(606, 16);
        btnCloseTop.Name = "btnCloseTop";
        btnCloseTop.Size = new System.Drawing.Size(29, 28);
        btnCloseTop.TabIndex = 2;
        btnCloseTop.Text = "✕";
        // 
        // lblDialogSubtitle
        // 
        lblDialogSubtitle.AutoSize = true;
        lblDialogSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblDialogSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDialogSubtitle.Location = new System.Drawing.Point(24, 42);
        lblDialogSubtitle.Name = "lblDialogSubtitle";
        lblDialogSubtitle.Size = new System.Drawing.Size(266, 19);
        lblDialogSubtitle.TabIndex = 1;
        lblDialogSubtitle.Text = "Admin · Khôi phục từ bản sao lưu đã chọn";
        // 
        // lblDialogTitle
        // 
        lblDialogTitle.AutoSize = true;
        lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblDialogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDialogTitle.Location = new System.Drawing.Point(24, 16);
        lblDialogTitle.Name = "lblDialogTitle";
        lblDialogTitle.Size = new System.Drawing.Size(236, 28);
        lblDialogTitle.TabIndex = 0;
        lblDialogTitle.Text = "Khôi phục cơ sở dữ liệu";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = System.Drawing.Color.White;
        pnlContent.Controls.Add(btnConfirmRestore);
        pnlContent.Controls.Add(btnCancel);
        pnlContent.Controls.Add(lblRestoreFootnote);
        pnlContent.Controls.Add(lblIntegrityVal);
        pnlContent.Controls.Add(lblIntegrityKey);
        pnlContent.Controls.Add(lblTargetDbVal);
        pnlContent.Controls.Add(lblTargetDbKey);
        pnlContent.Controls.Add(lblPreBackupVal);
        pnlContent.Controls.Add(lblPreBackupKey);
        pnlContent.Controls.Add(lblSourceBackupVal);
        pnlContent.Controls.Add(lblSourceBackupKey);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 70);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(650, 370);
        pnlContent.TabIndex = 1;
        // 
        // btnConfirmRestore
        // 
        btnConfirmRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnConfirmRestore.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnConfirmRestore.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnConfirmRestore.CornerRadius = 5;
        btnConfirmRestore.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmRestore.FlatAppearance.BorderSize = 0;
        btnConfirmRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmRestore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnConfirmRestore.ForeColor = System.Drawing.Color.White;
        btnConfirmRestore.Location = new System.Drawing.Point(446, 315);
        btnConfirmRestore.Name = "btnConfirmRestore";
        btnConfirmRestore.Size = new System.Drawing.Size(180, 34);
        btnConfirmRestore.TabIndex = 11;
        btnConfirmRestore.Text = "Khôi phục cơ sở dữ liệu";
        btnConfirmRestore.UseVisualStyleBackColor = false;
        btnConfirmRestore.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancel.Location = new System.Drawing.Point(356, 315);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(80, 34);
        btnCancel.TabIndex = 10;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblRestoreFootnote
        // 
        lblRestoreFootnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblRestoreFootnote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblRestoreFootnote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblRestoreFootnote.Location = new System.Drawing.Point(24, 260);
        lblRestoreFootnote.Name = "lblRestoreFootnote";
        lblRestoreFootnote.Size = new System.Drawing.Size(602, 40);
        lblRestoreFootnote.TabIndex = 9;
        lblRestoreFootnote.Text = ("Quá trình khôi phục sẽ đóng tất cả kết nối CSDL hiện tại. ECMS sẽ tải lại toàn bộ" + " giao diện sau khi hoàn tất.");
        // 
        // lblIntegrityVal
        // 
        lblIntegrityVal.AutoSize = true;
        lblIntegrityVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblIntegrityVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblIntegrityVal.Location = new System.Drawing.Point(180, 135);
        lblIntegrityVal.Name = "lblIntegrityVal";
        lblIntegrityVal.Size = new System.Drawing.Size(336, 20);
        lblIntegrityVal.TabIndex = 7;
        lblIntegrityVal.Text = "✓ Tệp tồn tại, kích thước 18,2 MB, hợp lệ SQLite 3";
        // 
        // lblIntegrityKey
        // 
        lblIntegrityKey.AutoSize = true;
        lblIntegrityKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblIntegrityKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblIntegrityKey.Location = new System.Drawing.Point(24, 135);
        lblIntegrityKey.Name = "lblIntegrityKey";
        lblIntegrityKey.Size = new System.Drawing.Size(126, 20);
        lblIntegrityKey.TabIndex = 6;
        lblIntegrityKey.Text = "Kiểm tra toàn vẹn";
        // 
        // lblTargetDbVal
        // 
        lblTargetDbVal.AutoSize = true;
        lblTargetDbVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTargetDbVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTargetDbVal.Location = new System.Drawing.Point(180, 95);
        lblTargetDbVal.Name = "lblTargetDbVal";
        lblTargetDbVal.Size = new System.Drawing.Size(164, 20);
        lblTargetDbVal.TabIndex = 5;
        lblTargetDbVal.Text = "C:\\ECMS\\Data\\ecms.db";
        // 
        // lblTargetDbKey
        // 
        lblTargetDbKey.AutoSize = true;
        lblTargetDbKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTargetDbKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTargetDbKey.Location = new System.Drawing.Point(24, 95);
        lblTargetDbKey.Name = "lblTargetDbKey";
        lblTargetDbKey.Size = new System.Drawing.Size(128, 20);
        lblTargetDbKey.TabIndex = 4;
        lblTargetDbKey.Text = "Cơ sở dữ liệu đích";
        // 
        // lblPreBackupVal
        // 
        lblPreBackupVal.AutoSize = true;
        lblPreBackupVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPreBackupVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblPreBackupVal.Location = new System.Drawing.Point(180, 58);
        lblPreBackupVal.Name = "lblPreBackupVal";
        lblPreBackupVal.Size = new System.Drawing.Size(459, 20);
        lblPreBackupVal.TabIndex = 3;
        lblPreBackupVal.Text = "D:\\ECMS_Backup\\ecms_before_restore_20261030_1630.db (tự động)";
        // 
        // lblPreBackupKey
        // 
        lblPreBackupKey.AutoSize = true;
        lblPreBackupKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPreBackupKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPreBackupKey.Location = new System.Drawing.Point(24, 58);
        lblPreBackupKey.Name = "lblPreBackupKey";
        lblPreBackupKey.Size = new System.Drawing.Size(144, 20);
        lblPreBackupKey.TabIndex = 2;
        lblPreBackupKey.Text = "Sao lưu phòng ngừa";
        // 
        // lblSourceBackupVal
        // 
        lblSourceBackupVal.AutoSize = true;
        lblSourceBackupVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSourceBackupVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSourceBackupVal.Location = new System.Drawing.Point(180, 20);
        lblSourceBackupVal.Name = "lblSourceBackupVal";
        lblSourceBackupVal.Size = new System.Drawing.Size(312, 20);
        lblSourceBackupVal.TabIndex = 1;
        lblSourceBackupVal.Text = "D:\\ECMS_Backup\\ecms_20261028_1800.db";
        // 
        // lblSourceBackupKey
        // 
        lblSourceBackupKey.AutoSize = true;
        lblSourceBackupKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSourceBackupKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSourceBackupKey.Location = new System.Drawing.Point(24, 20);
        lblSourceBackupKey.Name = "lblSourceBackupKey";
        lblSourceBackupKey.Size = new System.Drawing.Size(148, 20);
        lblSourceBackupKey.TabIndex = 0;
        lblSourceBackupKey.Text = "Tệp nguồn khôi phục";
        // 
        // RestoreDatabaseDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(650, 440);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Khôi phục cơ sở dữ liệu";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlContent.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblDialogTitle;
    private System.Windows.Forms.Label lblDialogSubtitle;
    private System.Windows.Forms.Label btnCloseTop;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.Label lblSourceBackupKey;
    private System.Windows.Forms.Label lblSourceBackupVal;
    private System.Windows.Forms.Label lblPreBackupKey;
    private System.Windows.Forms.Label lblPreBackupVal;
    private System.Windows.Forms.Label lblTargetDbKey;
    private System.Windows.Forms.Label lblTargetDbVal;
    private System.Windows.Forms.Label lblIntegrityKey;
    private System.Windows.Forms.Label lblIntegrityVal;
    private System.Windows.Forms.Label lblRestoreFootnote;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnConfirmRestore;
}
