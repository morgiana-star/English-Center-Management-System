namespace ECMS.UI.Forms;

partial class EditAccountDialog
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
        pnlFooter = new System.Windows.Forms.Panel();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBody = new System.Windows.Forms.Panel();
        cardForm = new ECMS.UI.Controls.AppCard();
        chkRequirePassChange = new System.Windows.Forms.CheckBox();
        chkActive = new System.Windows.Forms.CheckBox();
        cboRole = new ECMS.UI.Controls.AppComboBox();
        lblRole = new System.Windows.Forms.Label();
        cboProfile = new ECMS.UI.Controls.AppComboBox();
        lblProfile = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        txtUsername = new ECMS.UI.Controls.AppTextBox();
        lblUsername = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardForm.SuspendLayout();
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
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(560, 72);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 42);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(286, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Cập nhật thông tin vai trò và phân quyền";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(24, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(252, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Chỉnh sửa tài khoản";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnSave);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 480);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(560, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnSave
        // 
        btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 5;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(416, 12);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(120, 36);
        btnSave.TabIndex = 1;
        btnSave.Text = "Lưu thay đổi";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        btnCancel.Location = new System.Drawing.Point(324, 12);
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
        pnlBody.Location = new System.Drawing.Point(0, 72);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(560, 408);
        pnlBody.TabIndex = 1;
        // 
        // cardForm
        // 
        cardForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardForm.BorderWidth = 1;
        cardForm.Controls.Add(chkRequirePassChange);
        cardForm.Controls.Add(chkActive);
        cardForm.Controls.Add(cboRole);
        cardForm.Controls.Add(lblRole);
        cardForm.Controls.Add(cboProfile);
        cardForm.Controls.Add(lblProfile);
        cardForm.Controls.Add(txtFullName);
        cardForm.Controls.Add(lblFullName);
        cardForm.Controls.Add(txtUsername);
        cardForm.Controls.Add(lblUsername);
        cardForm.CornerRadius = 6;
        cardForm.Location = new System.Drawing.Point(24, 16);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(20);
        cardForm.Size = new System.Drawing.Size(512, 372);
        cardForm.TabIndex = 0;
        // 
        // chkRequirePassChange
        // 
        chkRequirePassChange.AutoSize = true;
        chkRequirePassChange.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkRequirePassChange.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        chkRequirePassChange.Location = new System.Drawing.Point(240, 320);
        chkRequirePassChange.Name = "chkRequirePassChange";
        chkRequirePassChange.Size = new System.Drawing.Size(242, 24);
        chkRequirePassChange.TabIndex = 9;
        chkRequirePassChange.Text = "Yêu cầu đổi MK khi đăng nhập";
        chkRequirePassChange.UseVisualStyleBackColor = true;
        // 
        // chkActive
        // 
        chkActive.AutoSize = true;
        chkActive.Checked = true;
        chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
        chkActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        chkActive.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        chkActive.Location = new System.Drawing.Point(20, 320);
        chkActive.Name = "chkActive";
        chkActive.Size = new System.Drawing.Size(183, 24);
        chkActive.TabIndex = 8;
        chkActive.Text = "Tài khoản hoạt động";
        chkActive.UseVisualStyleBackColor = true;
        // 
        // cboRole
        // 
        cboRole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboRole.CornerRadius = 5;
        cboRole.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboRole.Location = new System.Drawing.Point(20, 260);
        cboRole.Name = "cboRole";
        cboRole.Size = new System.Drawing.Size(472, 36);
        cboRole.TabIndex = 7;
        // 
        // lblRole
        // 
        lblRole.AutoSize = true;
        lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRole.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRole.Location = new System.Drawing.Point(20, 236);
        lblRole.Name = "lblRole";
        lblRole.Size = new System.Drawing.Size(68, 20);
        lblRole.TabIndex = 6;
        lblRole.Text = "Vai trò *";
        // 
        // cboProfile
        // 
        cboProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboProfile.CornerRadius = 5;
        cboProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboProfile.Location = new System.Drawing.Point(20, 186);
        cboProfile.Name = "cboProfile";
        cboProfile.Size = new System.Drawing.Size(472, 36);
        cboProfile.TabIndex = 5;
        // 
        // lblProfile
        // 
        lblProfile.AutoSize = true;
        lblProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblProfile.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblProfile.Location = new System.Drawing.Point(20, 162);
        lblProfile.Name = "lblProfile";
        lblProfile.Size = new System.Drawing.Size(117, 20);
        lblProfile.TabIndex = 4;
        lblProfile.Text = "Hồ sơ liên kết *";
        // 
        // txtFullName
        // 
        txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtFullName.BackColor = System.Drawing.Color.Transparent;
        txtFullName.CornerRadius = 5;
        txtFullName.ErrorMessage = "";
        txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtFullName.HasError = false;
        txtFullName.Location = new System.Drawing.Point(20, 114);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Họ và tên người dùng";
        txtFullName.ReadOnly = false;
        txtFullName.Size = new System.Drawing.Size(472, 36);
        txtFullName.TabIndex = 3;
        txtFullName.UseSystemPasswordChar = false;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblFullName.Location = new System.Drawing.Point(20, 90);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(90, 20);
        lblFullName.TabIndex = 2;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtUsername
        // 
        txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtUsername.BackColor = System.Drawing.Color.Transparent;
        txtUsername.CornerRadius = 5;
        txtUsername.ErrorMessage = "";
        txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtUsername.HasError = false;
        txtUsername.Location = new System.Drawing.Point(20, 42);
        txtUsername.Name = "txtUsername";
        txtUsername.Placeholder = "Tên đăng nhập";
        txtUsername.ReadOnly = true;
        txtUsername.Size = new System.Drawing.Size(472, 36);
        txtUsername.TabIndex = 1;
        txtUsername.UseSystemPasswordChar = false;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblUsername.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblUsername.Location = new System.Drawing.Point(20, 18);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new System.Drawing.Size(126, 20);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tên đăng nhập *";
        // 
        // EditAccountDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(560, 540);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EditAccountDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chỉnh sửa tài khoản";
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
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppButton btnCancel;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardForm;
    private ECMS.UI.Controls.AppTextBox txtUsername;
    private System.Windows.Forms.Label lblUsername;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppComboBox cboProfile;
    private System.Windows.Forms.Label lblProfile;
    private ECMS.UI.Controls.AppComboBox cboRole;
    private System.Windows.Forms.Label lblRole;
    private System.Windows.Forms.CheckBox chkActive;
    private System.Windows.Forms.CheckBox chkRequirePassChange;
}
