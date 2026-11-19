namespace ECMS.UI.Forms;

partial class ResetPasswordDialog
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
        lblTitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBody = new System.Windows.Forms.Panel();
        cardForm = new ECMS.UI.Controls.AppCard();
        btnGenerate = new ECMS.UI.Controls.AppButton();
        chkUnlockAccount = new System.Windows.Forms.CheckBox();
        chkMustChangePass = new System.Windows.Forms.CheckBox();
        lblNote = new System.Windows.Forms.Label();
        txtTempPassword = new ECMS.UI.Controls.AppTextBox();
        lblTempPassword = new System.Windows.Forms.Label();
        txtTargetAccount = new ECMS.UI.Controls.AppTextBox();
        lblTargetAccount = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardForm.SuspendLayout();
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
        pnlHeader.Size = new System.Drawing.Size(520, 66);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(191, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đặt lại mật khẩu";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnConfirm);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 420);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(520, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnConfirm
        // 
        btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirm.CornerRadius = 5;
        btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirm.FlatAppearance.BorderSize = 0;
        btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnConfirm.ForeColor = System.Drawing.Color.White;
        btnConfirm.Location = new System.Drawing.Point(346, 12);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new System.Drawing.Size(150, 36);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Xác nhận đặt lại";
        btnConfirm.UseVisualStyleBackColor = false;
        btnConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
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
        btnCancel.Location = new System.Drawing.Point(254, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(84, 36);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardForm);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 66);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(520, 354);
        pnlBody.TabIndex = 1;
        // 
        // cardForm
        // 
        cardForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardForm.BorderWidth = 1;
        cardForm.Controls.Add(btnGenerate);
        cardForm.Controls.Add(chkUnlockAccount);
        cardForm.Controls.Add(chkMustChangePass);
        cardForm.Controls.Add(lblNote);
        cardForm.Controls.Add(txtTempPassword);
        cardForm.Controls.Add(lblTempPassword);
        cardForm.Controls.Add(txtTargetAccount);
        cardForm.Controls.Add(lblTargetAccount);
        cardForm.CornerRadius = 6;
        cardForm.Location = new System.Drawing.Point(24, 16);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(20);
        cardForm.Size = new System.Drawing.Size(472, 308);
        cardForm.TabIndex = 0;
        // 
        // btnGenerate
        // 
        btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnGenerate.BackColor = System.Drawing.Color.White;
        btnGenerate.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnGenerate.CornerRadius = 5;
        btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
        btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnGenerate.Location = new System.Drawing.Point(342, 114);
        btnGenerate.Name = "btnGenerate";
        btnGenerate.Size = new System.Drawing.Size(110, 36);
        btnGenerate.TabIndex = 7;
        btnGenerate.Text = "Tạo ngẫu nhiên";
        btnGenerate.UseVisualStyleBackColor = false;
        btnGenerate.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // chkUnlockAccount
        // 
        chkUnlockAccount.AutoSize = true;
        chkUnlockAccount.Checked = true;
        chkUnlockAccount.CheckState = System.Windows.Forms.CheckState.Checked;
        chkUnlockAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        chkUnlockAccount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        chkUnlockAccount.Location = new System.Drawing.Point(20, 260);
        chkUnlockAccount.Name = "chkUnlockAccount";
        chkUnlockAccount.Size = new System.Drawing.Size(299, 24);
        chkUnlockAccount.TabIndex = 6;
        chkUnlockAccount.Text = "Mở khóa tài khoản ngay sau khi đặt lại";
        chkUnlockAccount.UseVisualStyleBackColor = true;
        // 
        // chkMustChangePass
        // 
        chkMustChangePass.AutoSize = true;
        chkMustChangePass.Checked = true;
        chkMustChangePass.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMustChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkMustChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        chkMustChangePass.Location = new System.Drawing.Point(20, 225);
        chkMustChangePass.Name = "chkMustChangePass";
        chkMustChangePass.Size = new System.Drawing.Size(342, 24);
        chkMustChangePass.TabIndex = 5;
        chkMustChangePass.Text = "Bắt buộc đổi mật khẩu trong lần đăng nhập tới";
        chkMustChangePass.UseVisualStyleBackColor = true;
        // 
        // lblNote
        // 
        lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNote.Location = new System.Drawing.Point(20, 160);
        lblNote.Name = "lblNote";
        lblNote.Size = new System.Drawing.Size(432, 45);
        lblNote.TabIndex = 4;
        lblNote.Text = ("Mật khẩu tạm cần được gửi riêng cho người dùng qua kênh an toàn. Hệ thống sẽ ghi " + "nhận nhật ký đổi mật khẩu.");
        // 
        // txtTempPassword
        // 
        txtTempPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtTempPassword.BackColor = System.Drawing.Color.Transparent;
        txtTempPassword.CornerRadius = 5;
        txtTempPassword.ErrorMessage = "";
        txtTempPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        txtTempPassword.HasError = false;
        txtTempPassword.Location = new System.Drawing.Point(20, 114);
        txtTempPassword.Name = "txtTempPassword";
        txtTempPassword.Placeholder = "Nhập mật khẩu tạm mới...";
        txtTempPassword.ReadOnly = false;
        txtTempPassword.Size = new System.Drawing.Size(314, 36);
        txtTempPassword.TabIndex = 3;
        txtTempPassword.UseSystemPasswordChar = false;
        // 
        // lblTempPassword
        // 
        lblTempPassword.AutoSize = true;
        lblTempPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTempPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTempPassword.Location = new System.Drawing.Point(20, 90);
        lblTempPassword.Name = "lblTempPassword";
        lblTempPassword.Size = new System.Drawing.Size(149, 20);
        lblTempPassword.TabIndex = 2;
        lblTempPassword.Text = "Mật khẩu tạm mới *";
        // 
        // txtTargetAccount
        // 
        txtTargetAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtTargetAccount.BackColor = System.Drawing.Color.Transparent;
        txtTargetAccount.CornerRadius = 5;
        txtTargetAccount.ErrorMessage = "";
        txtTargetAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtTargetAccount.HasError = false;
        txtTargetAccount.Location = new System.Drawing.Point(20, 42);
        txtTargetAccount.Name = "txtTargetAccount";
        txtTargetAccount.Placeholder = "";
        txtTargetAccount.ReadOnly = true;
        txtTargetAccount.Size = new System.Drawing.Size(432, 36);
        txtTargetAccount.TabIndex = 1;
        txtTargetAccount.UseSystemPasswordChar = false;
        // 
        // lblTargetAccount
        // 
        lblTargetAccount.AutoSize = true;
        lblTargetAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTargetAccount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTargetAccount.Location = new System.Drawing.Point(20, 18);
        lblTargetAccount.Name = "lblTargetAccount";
        lblTargetAccount.Size = new System.Drawing.Size(157, 20);
        lblTargetAccount.TabIndex = 0;
        lblTargetAccount.Text = "Tài khoản thực hiện *";
        // 
        // ResetPasswordDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(520, 480);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Đặt lại mật khẩu người dùng";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardForm.ResumeLayout(false);
        cardForm.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnConfirm;
    private ECMS.UI.Controls.AppButton btnCancel;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardForm;
    private ECMS.UI.Controls.AppTextBox txtTargetAccount;
    private System.Windows.Forms.Label lblTargetAccount;
    private ECMS.UI.Controls.AppTextBox txtTempPassword;
    private System.Windows.Forms.Label lblTempPassword;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.CheckBox chkMustChangePass;
    private System.Windows.Forms.CheckBox chkUnlockAccount;
    private ECMS.UI.Controls.AppButton btnGenerate;
}
