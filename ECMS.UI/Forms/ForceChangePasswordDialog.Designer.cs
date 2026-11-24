namespace ECMS.UI.Forms;

partial class ForceChangePasswordDialog
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

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        lblError = new System.Windows.Forms.Label();
        chkShowPassword = new System.Windows.Forms.CheckBox();
        txtConfirmPassword = new ECMS.UI.Controls.AppTextBox();
        lblConfirmPassword = new System.Windows.Forms.Label();
        txtNewPassword = new ECMS.UI.Controls.AppTextBox();
        lblNewPassword = new System.Windows.Forms.Label();
        lblAccountInfo = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(460, 76);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(270, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đổi mật khẩu lần đầu";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(24, 46);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(375, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Tài khoản yêu cầu cập nhật mật khẩu mới trước khi sử dụng";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(lblError);
        pnlBody.Controls.Add(chkShowPassword);
        pnlBody.Controls.Add(txtConfirmPassword);
        pnlBody.Controls.Add(lblConfirmPassword);
        pnlBody.Controls.Add(txtNewPassword);
        pnlBody.Controls.Add(lblNewPassword);
        pnlBody.Controls.Add(lblAccountInfo);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 76);
        pnlBody.Name = "pnlBody";
        pnlBody.Size = new System.Drawing.Size(460, 248);
        pnlBody.TabIndex = 1;
        // 
        // lblAccountInfo
        // 
        lblAccountInfo.AutoSize = true;
        lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblAccountInfo.Location = new System.Drawing.Point(24, 14);
        lblAccountInfo.Name = "lblAccountInfo";
        lblAccountInfo.Size = new System.Drawing.Size(180, 21);
        lblAccountInfo.TabIndex = 0;
        lblAccountInfo.Text = "Tài khoản: user";
        // 
        // lblNewPassword
        // 
        lblNewPassword.AutoSize = true;
        lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblNewPassword.Location = new System.Drawing.Point(24, 48);
        lblNewPassword.Name = "lblNewPassword";
        lblNewPassword.Size = new System.Drawing.Size(130, 20);
        lblNewPassword.TabIndex = 1;
        lblNewPassword.Text = "Mật khẩu mới *";
        // 
        // txtNewPassword
        // 
        txtNewPassword.BackColor = System.Drawing.Color.Transparent;
        txtNewPassword.CornerRadius = 6;
        txtNewPassword.ErrorMessage = "";
        txtNewPassword.HasError = false;
        txtNewPassword.Location = new System.Drawing.Point(24, 72);
        txtNewPassword.Name = "txtNewPassword";
        txtNewPassword.Placeholder = "Nhập mật khẩu mới (tối thiểu 6 ký tự)";
        txtNewPassword.ReadOnly = false;
        txtNewPassword.Size = new System.Drawing.Size(412, 36);
        txtNewPassword.TabIndex = 2;
        txtNewPassword.UseSystemPasswordChar = true;
        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.AutoSize = true;
        lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblConfirmPassword.Location = new System.Drawing.Point(24, 120);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new System.Drawing.Size(165, 20);
        lblConfirmPassword.TabIndex = 3;
        lblConfirmPassword.Text = "Xác nhận mật khẩu mới *";
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
        txtConfirmPassword.CornerRadius = 6;
        txtConfirmPassword.ErrorMessage = "";
        txtConfirmPassword.HasError = false;
        txtConfirmPassword.Location = new System.Drawing.Point(24, 144);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.Placeholder = "Nhập lại mật khẩu mới";
        txtConfirmPassword.ReadOnly = false;
        txtConfirmPassword.Size = new System.Drawing.Size(412, 36);
        txtConfirmPassword.TabIndex = 4;
        txtConfirmPassword.UseSystemPasswordChar = true;
        // 
        // chkShowPassword
        // 
        chkShowPassword.AutoSize = true;
        chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
        chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        chkShowPassword.Location = new System.Drawing.Point(24, 190);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new System.Drawing.Size(145, 24);
        chkShowPassword.TabIndex = 5;
        chkShowPassword.Text = "Hiển thị mật khẩu";
        chkShowPassword.UseVisualStyleBackColor = true;
        // 
        // lblError
        // 
        lblError.AutoSize = false;
        lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblError.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblError.Location = new System.Drawing.Point(24, 218);
        lblError.Name = "lblError";
        lblError.Size = new System.Drawing.Size(442, 42);
        lblError.TabIndex = 6;
        lblError.Visible = false;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnConfirm);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 324);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Size = new System.Drawing.Size(460, 64);
        pnlFooter.TabIndex = 2;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 6;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancel.Location = new System.Drawing.Point(210, 14);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnConfirm
        // 
        btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirm.CornerRadius = 6;
        btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirm.ForeColor = System.Drawing.Color.White;
        btnConfirm.Location = new System.Drawing.Point(320, 14);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new System.Drawing.Size(116, 36);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Cập nhật";
        btnConfirm.UseVisualStyleBackColor = false;
        btnConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // ForceChangePasswordDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(490, 412);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        Name = "ForceChangePasswordDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Đổi mật khẩu lần đầu - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlBody.PerformLayout();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Label lblAccountInfo;
    private System.Windows.Forms.Label lblNewPassword;
    private ECMS.UI.Controls.AppTextBox txtNewPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private ECMS.UI.Controls.AppTextBox txtConfirmPassword;
    private System.Windows.Forms.CheckBox chkShowPassword;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnConfirm;
}
