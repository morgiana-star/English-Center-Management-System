namespace ECMS.UI.Forms;

partial class LoginForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        pnlLeft = new System.Windows.Forms.Panel();
        lblCenter = new System.Windows.Forms.Label();
        lblBrand = new System.Windows.Forms.Label();
        picLogo = new System.Windows.Forms.PictureBox();
        pnlRight = new System.Windows.Forms.Panel();
        btnLogin = new ECMS.UI.Controls.AppButton();
        lblError = new System.Windows.Forms.Label();
        chkShowPass = new System.Windows.Forms.CheckBox();
        txtPassword = new ECMS.UI.Controls.AppTextBox();
        lblPass = new System.Windows.Forms.Label();
        txtUsername = new ECMS.UI.Controls.AppTextBox();
        lblUser = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        pnlRight.SuspendLayout();
        SuspendLayout();
        // 
        // pnlLeft
        // 
        pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        pnlLeft.Controls.Add(lblCenter);
        pnlLeft.Controls.Add(lblBrand);
        pnlLeft.Controls.Add(picLogo);
        pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
        pnlLeft.Location = new System.Drawing.Point(0, 0);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new System.Drawing.Size(482, 447);
        pnlLeft.TabIndex = 0;
        // 
        // lblCenter
        // 
        lblCenter.AutoSize = true;
        lblCenter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCenter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblCenter.Location = new System.Drawing.Point(133, 286);
        lblCenter.Name = "lblCenter";
        lblCenter.Size = new System.Drawing.Size(196, 28);
        lblCenter.TabIndex = 2;
        lblCenter.Text = "Trung tâm Anh ngữ";
        // 
        // lblBrand
        // 
        lblBrand.AutoSize = true;
        lblBrand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblBrand.Location = new System.Drawing.Point(177, 224);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new System.Drawing.Size(111, 46);
        lblBrand.TabIndex = 1;
        lblBrand.Text = "ECMS";
        // 
        // picLogo
        // 
        picLogo.Image = ((System.Drawing.Image)resources.GetObject("picLogo.Image"));
        picLogo.Location = new System.Drawing.Point(169, 97);
        picLogo.Name = "picLogo";
        picLogo.Size = new System.Drawing.Size(144, 109);
        picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // pnlRight
        // 
        pnlRight.BackColor = System.Drawing.Color.White;
        pnlRight.Controls.Add(btnLogin);
        pnlRight.Controls.Add(lblError);
        pnlRight.Controls.Add(chkShowPass);
        pnlRight.Controls.Add(txtPassword);
        pnlRight.Controls.Add(lblPass);
        pnlRight.Controls.Add(txtUsername);
        pnlRight.Controls.Add(lblUser);
        pnlRight.Controls.Add(lblTitle);
        pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlRight.Location = new System.Drawing.Point(482, 0);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new System.Drawing.Size(669, 447);
        pnlRight.TabIndex = 1;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnLogin.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnLogin.CornerRadius = 5;
        btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnLogin.ForeColor = System.Drawing.Color.White;
        btnLogin.Location = new System.Drawing.Point(57, 339);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(559, 46);
        btnLogin.TabIndex = 7;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnLogin.Click += btnLogin_Click;
        // 
        // lblError
        // 
        lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblError.ForeColor = System.Drawing.Color.Red;
        lblError.Location = new System.Drawing.Point(57, 294);
        lblError.Name = "lblError";
        lblError.Size = new System.Drawing.Size(544, 28);
        lblError.TabIndex = 6;
        lblError.Text = "* Tên đăng nhập hoặc mật khẩu không đúng!";
        lblError.Visible = false;
        // 
        // chkShowPass
        // 
        chkShowPass.AutoSize = true;
        chkShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
        chkShowPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        chkShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        chkShowPass.Location = new System.Drawing.Point(57, 255);
        chkShowPass.Name = "chkShowPass";
        chkShowPass.Size = new System.Drawing.Size(127, 24);
        chkShowPass.TabIndex = 5;
        chkShowPass.Text = "Hiện mật khẩu";
        chkShowPass.UseVisualStyleBackColor = true;
        chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = System.Drawing.Color.Transparent;
        txtPassword.CornerRadius = 5;
        txtPassword.ErrorMessage = "";
        txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtPassword.HasError = false;
        txtPassword.Location = new System.Drawing.Point(57, 213);
        txtPassword.Name = "txtPassword";
        txtPassword.Placeholder = "Vui lòng nhập mật khẩu";
        txtPassword.ReadOnly = false;
        txtPassword.Size = new System.Drawing.Size(559, 36);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPass
        // 
        lblPass.AutoSize = true;
        lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblPass.Location = new System.Drawing.Point(57, 186);
        lblPass.Name = "lblPass";
        lblPass.Size = new System.Drawing.Size(75, 20);
        lblPass.TabIndex = 3;
        lblPass.Text = "Mật khẩu";
        // 
        // txtUsername
        // 
        txtUsername.BackColor = System.Drawing.Color.Transparent;
        txtUsername.CornerRadius = 5;
        txtUsername.ErrorMessage = "";
        txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtUsername.HasError = false;
        txtUsername.Location = new System.Drawing.Point(57, 135);
        txtUsername.Name = "txtUsername";
        txtUsername.Placeholder = "Vui lòng nhập tên đăng nhập";
        txtUsername.ReadOnly = false;
        txtUsername.Size = new System.Drawing.Size(559, 36);
        txtUsername.TabIndex = 2;
        txtUsername.UseSystemPasswordChar = false;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblUser.Location = new System.Drawing.Point(57, 112);
        lblUser.Name = "lblUser";
        lblUser.Size = new System.Drawing.Size(112, 20);
        lblUser.TabIndex = 1;
        lblUser.Text = "Tên đăng nhập";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(57, 48);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(307, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Đăng nhập hệ thống";
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1151, 447);
        Controls.Add(pnlRight);
        Controls.Add(pnlLeft);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "ECMS — Đăng nhập";
        Load += LoginForm_Load;
        pnlLeft.ResumeLayout(false);
        pnlLeft.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        pnlRight.ResumeLayout(false);
        pnlRight.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.PictureBox picLogo;
    private System.Windows.Forms.Label lblBrand;
    private System.Windows.Forms.Label lblCenter;

    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUser;
    private ECMS.UI.Controls.AppTextBox txtUsername;
    private System.Windows.Forms.Label lblPass;
    private ECMS.UI.Controls.AppTextBox txtPassword;
    private System.Windows.Forms.CheckBox chkShowPass;
    private System.Windows.Forms.Label lblError;
    private ECMS.UI.Controls.AppButton btnLogin;
}
