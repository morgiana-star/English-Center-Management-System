namespace ECMS.UI.Forms;

partial class LogoutConfirmDialog
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
        btnStay = new ECMS.UI.Controls.AppButton();
        btnLogout = new ECMS.UI.Controls.AppButton();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(172, 35);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(227, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xác nhận đăng xuất?";
        // 
        // btnStay
        // 
        btnStay.BackColor = System.Drawing.Color.White;
        btnStay.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnStay.CornerRadius = 5;
        btnStay.Cursor = System.Windows.Forms.Cursors.Hand;
        btnStay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnStay.FlatAppearance.BorderSize = 0;
        btnStay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnStay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnStay.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnStay.Location = new System.Drawing.Point(69, 144);
        btnStay.Name = "btnStay";
        btnStay.Size = new System.Drawing.Size(196, 44);
        btnStay.TabIndex = 4;
        btnStay.Text = "Ở lại";
        btnStay.UseVisualStyleBackColor = false;
        btnStay.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnLogout.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnLogout.CornerRadius = 5;
        btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnLogout.ForeColor = System.Drawing.Color.White;
        btnLogout.Location = new System.Drawing.Point(271, 144);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(281, 44);
        btnLogout.TabIndex = 5;
        btnLogout.Text = "Đăng xuất";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.Gray;
        label1.Location = new System.Drawing.Point(69, 85);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(449, 23);
        label1.TabIndex = 6;
        label1.Text = "Bạn có chắc chắn muốn đăng xuất khỏi hệ thông không?";
        // 
        // LogoutConfirmDialog
        // 
        AcceptButton = btnLogout;
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        CancelButton = btnStay;
        ClientSize = new System.Drawing.Size(606, 227);
        Controls.Add(label1);
        Controls.Add(btnLogout);
        Controls.Add(btnStay);
        Controls.Add(lblTitle);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xác nhận đăng xuất";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    #endregion

    private System.Windows.Forms.Panel pnlStripe;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Panel pnlBannerNote;
    private System.Windows.Forms.Label lblBannerNote;
    private ECMS.UI.Controls.AppButton btnStay;
    private ECMS.UI.Controls.AppButton btnLogout;
}
