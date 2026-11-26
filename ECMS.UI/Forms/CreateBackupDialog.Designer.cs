namespace ECMS.UI.Forms;

partial class CreateBackupDialog
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
        lblDialogTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        pnlFooter = new System.Windows.Forms.Panel();
        btnConfirmBackup = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        lblCheckStatusVal = new System.Windows.Forms.Label();
        lblCheckStatusKey = new System.Windows.Forms.Label();
        lblSizeVal = new System.Windows.Forms.Label();
        lblSizeKey = new System.Windows.Forms.Label();
        lblScopeVal = new System.Windows.Forms.Label();
        lblScopeKey = new System.Windows.Forms.Label();
        lblTargetVal = new System.Windows.Forms.Label();
        lblTargetKey = new System.Windows.Forms.Label();
        lblSourceVal = new System.Windows.Forms.Label();
        lblSourceKey = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblDialogTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(640, 56);
        pnlHeader.TabIndex = 0;
        // 
        // lblDialogTitle
        // 
        lblDialogTitle.AutoSize = true;
        lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblDialogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDialogTitle.Location = new System.Drawing.Point(24, 16);
        lblDialogTitle.Name = "lblDialogTitle";
        lblDialogTitle.Size = new System.Drawing.Size(261, 28);
        lblDialogTitle.TabIndex = 0;
        lblDialogTitle.Text = "Xác nhận tạo bản sao lưu?";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = System.Drawing.Color.White;
        pnlContent.Controls.Add(lblCheckStatusVal);
        pnlContent.Controls.Add(lblCheckStatusKey);
        pnlContent.Controls.Add(lblSizeVal);
        pnlContent.Controls.Add(lblSizeKey);
        pnlContent.Controls.Add(lblScopeVal);
        pnlContent.Controls.Add(lblScopeKey);
        pnlContent.Controls.Add(lblTargetVal);
        pnlContent.Controls.Add(lblTargetKey);
        pnlContent.Controls.Add(lblSourceVal);
        pnlContent.Controls.Add(lblSourceKey);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 56);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(640, 160);
        pnlContent.TabIndex = 1;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlFooter.Controls.Add(btnConfirmBackup);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 216);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(640, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnConfirmBackup
        // 
        btnConfirmBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnConfirmBackup.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnConfirmBackup.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmBackup.CornerRadius = 5;
        btnConfirmBackup.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmBackup.FlatAppearance.BorderSize = 0;
        btnConfirmBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnConfirmBackup.ForeColor = System.Drawing.Color.White;
        btnConfirmBackup.Location = new System.Drawing.Point(486, 13);
        btnConfirmBackup.Name = "btnConfirmBackup";
        btnConfirmBackup.Size = new System.Drawing.Size(130, 34);
        btnConfirmBackup.TabIndex = 13;
        btnConfirmBackup.Text = "Tạo bản sao lưu";
        btnConfirmBackup.UseVisualStyleBackColor = false;
        btnConfirmBackup.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancel.Location = new System.Drawing.Point(398, 13);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(80, 34);
        btnCancel.TabIndex = 12;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblCheckStatusVal
        // 
        lblCheckStatusVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCheckStatusVal.AutoEllipsis = true;
        lblCheckStatusVal.AutoSize = false;
        lblCheckStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCheckStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCheckStatusVal.Location = new System.Drawing.Point(125, 138);
        lblCheckStatusVal.Name = "lblCheckStatusVal";
        lblCheckStatusVal.Size = new System.Drawing.Size(491, 22);
        lblCheckStatusVal.TabIndex = 9;
        lblCheckStatusVal.Text = "Đang kiểm tra quyền ghi và tính toàn vẹn CSDL...";
        // 
        // lblCheckStatusKey
        // 
        lblCheckStatusKey.AutoSize = true;
        lblCheckStatusKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCheckStatusKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCheckStatusKey.Location = new System.Drawing.Point(24, 138);
        lblCheckStatusKey.Name = "lblCheckStatusKey";
        lblCheckStatusKey.Size = new System.Drawing.Size(65, 20);
        lblCheckStatusKey.TabIndex = 8;
        lblCheckStatusKey.Text = "Kiểm tra";
        // 
        // lblSizeVal
        // 
        lblSizeVal.AutoSize = true;
        lblSizeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSizeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSizeVal.Location = new System.Drawing.Point(125, 108);
        lblSizeVal.Name = "lblSizeVal";
        lblSizeVal.Size = new System.Drawing.Size(62, 20);
        lblSizeVal.TabIndex = 7;
        lblSizeVal.Text = "18,6 MB";
        // 
        // lblSizeKey
        // 
        lblSizeKey.AutoSize = true;
        lblSizeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSizeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSizeKey.Location = new System.Drawing.Point(24, 108);
        lblSizeKey.Name = "lblSizeKey";
        lblSizeKey.Size = new System.Drawing.Size(88, 20);
        lblSizeKey.TabIndex = 6;
        lblSizeKey.Text = "Dung lượng";
        // 
        // lblScopeVal
        // 
        lblScopeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblScopeVal.AutoEllipsis = true;
        lblScopeVal.AutoSize = false;
        lblScopeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblScopeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblScopeVal.Location = new System.Drawing.Point(125, 78);
        lblScopeVal.Name = "lblScopeVal";
        lblScopeVal.Size = new System.Drawing.Size(491, 22);
        lblScopeVal.TabIndex = 5;
        lblScopeVal.Text = "Toàn bộ dữ liệu hệ thống (đào tạo, học phí, tài khoản, cấu hình)";
        // 
        // lblScopeKey
        // 
        lblScopeKey.AutoSize = true;
        lblScopeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblScopeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblScopeKey.Location = new System.Drawing.Point(24, 78);
        lblScopeKey.Name = "lblScopeKey";
        lblScopeKey.Size = new System.Drawing.Size(61, 20);
        lblScopeKey.TabIndex = 4;
        lblScopeKey.Text = "Phạm vi";
        // 
        // lblTargetVal
        // 
        lblTargetVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblTargetVal.AutoEllipsis = true;
        lblTargetVal.AutoSize = false;
        lblTargetVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTargetVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTargetVal.Location = new System.Drawing.Point(125, 48);
        lblTargetVal.Name = "lblTargetVal";
        lblTargetVal.Size = new System.Drawing.Size(491, 22);
        lblTargetVal.TabIndex = 3;
        lblTargetVal.Text = "D:\\ECMS_Backup\\ecms_20261030_1625.db";
        // 
        // lblTargetKey
        // 
        lblTargetKey.AutoSize = true;
        lblTargetKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTargetKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblTargetKey.Location = new System.Drawing.Point(24, 48);
        lblTargetKey.Name = "lblTargetKey";
        lblTargetKey.Size = new System.Drawing.Size(66, 20);
        lblTargetKey.TabIndex = 2;
        lblTargetKey.Text = "Tệp đích";
        // 
        // lblSourceVal
        // 
        lblSourceVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblSourceVal.AutoEllipsis = true;
        lblSourceVal.AutoSize = false;
        lblSourceVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSourceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblSourceVal.Location = new System.Drawing.Point(125, 18);
        lblSourceVal.Name = "lblSourceVal";
        lblSourceVal.Size = new System.Drawing.Size(491, 22);
        lblSourceVal.TabIndex = 1;
        lblSourceVal.Text = "C:\\ECMS\\Data\\ecms.db";
        // 
        // lblSourceKey
        // 
        lblSourceKey.AutoSize = true;
        lblSourceKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSourceKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSourceKey.Location = new System.Drawing.Point(24, 18);
        lblSourceKey.Name = "lblSourceKey";
        lblSourceKey.Size = new System.Drawing.Size(54, 20);
        lblSourceKey.TabIndex = 0;
        lblSourceKey.Text = "Nguồn";
        // 
        // CreateBackupDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(640, 276);
        Controls.Add(pnlContent);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(580, 310);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xác nhận tạo bản sao lưu";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlContent.PerformLayout();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblDialogTitle;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Label lblSourceKey;
    private System.Windows.Forms.Label lblSourceVal;
    private System.Windows.Forms.Label lblTargetKey;
    private System.Windows.Forms.Label lblTargetVal;
    private System.Windows.Forms.Label lblScopeKey;
    private System.Windows.Forms.Label lblScopeVal;
    private System.Windows.Forms.Label lblSizeKey;
    private System.Windows.Forms.Label lblSizeVal;
    private System.Windows.Forms.Label lblCheckStatusKey;
    private System.Windows.Forms.Label lblCheckStatusVal;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnConfirmBackup;
}
