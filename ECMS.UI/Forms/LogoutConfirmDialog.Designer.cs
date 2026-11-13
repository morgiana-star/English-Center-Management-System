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

    private void InitializeComponent()
    {
        lblTitle = new System.Windows.Forms.Label();
        lblDesc = new System.Windows.Forms.Label();
        btnStay = new ECMS.UI.Controls.AppButton();
        btnLogout = new ECMS.UI.Controls.AppButton();
        pnlStripe = new System.Windows.Forms.Panel();
        pnlBannerNote = new System.Windows.Forms.Panel();
        lblBannerNote = new System.Windows.Forms.Label();
        pnlBannerNote.SuspendLayout();
        SuspendLayout();
        // 
        // pnlStripe
        // 
        pnlStripe.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
        pnlStripe.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStripe.Location = new System.Drawing.Point(0, 0);
        pnlStripe.Name = "pnlStripe";
        pnlStripe.Size = new System.Drawing.Size(460, 4);
        pnlStripe.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(24, 22);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(227, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xác nhận đăng xuất?";
        // 
        // lblDesc
        // 
        lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDesc.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblDesc.Location = new System.Drawing.Point(24, 58);
        lblDesc.Name = "lblDesc";
        lblDesc.Size = new System.Drawing.Size(412, 50);
        lblDesc.TabIndex = 2;
        lblDesc.Text = "Không còn thay đổi chưa lưu. Phiên làm việc hiện tại sẽ kết thúc, dữ liệu SQLite được giữ nguyên an toàn.";
        // 
        // pnlBannerNote
        // 
        pnlBannerNote.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        pnlBannerNote.Controls.Add(lblBannerNote);
        pnlBannerNote.Location = new System.Drawing.Point(24, 115);
        pnlBannerNote.Name = "pnlBannerNote";
        pnlBannerNote.Size = new System.Drawing.Size(412, 40);
        pnlBannerNote.TabIndex = 3;
        // 
        // lblBannerNote
        // 
        lblBannerNote.AutoSize = true;
        lblBannerNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblBannerNote.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblBannerNote.Location = new System.Drawing.Point(12, 10);
        lblBannerNote.Name = "lblBannerNote";
        lblBannerNote.Size = new System.Drawing.Size(366, 20);
        lblBannerNote.TabIndex = 0;
        lblBannerNote.Text = "Trạng thái sau xác nhận: đã kết thúc phiên → về Đăng nhập.";
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
        btnStay.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnStay.Location = new System.Drawing.Point(215, 172);
        btnStay.Name = "btnStay";
        btnStay.Size = new System.Drawing.Size(95, 36);
        btnStay.TabIndex = 4;
        btnStay.Text = "Ở lại";
        btnStay.UseVisualStyleBackColor = false;
        btnStay.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
        btnLogout.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnLogout.CornerRadius = 5;
        btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnLogout.ForeColor = System.Drawing.Color.White;
        btnLogout.Location = new System.Drawing.Point(320, 172);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(116, 36);
        btnLogout.TabIndex = 5;
        btnLogout.Text = "Đăng xuất";
        btnLogout.UseVisualStyleBackColor = false;
        btnLogout.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // LogoutConfirmDialog
        // 
        AcceptButton = btnLogout;
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        CancelButton = btnStay;
        ClientSize = new System.Drawing.Size(460, 226);
        Controls.Add(btnLogout);
        Controls.Add(btnStay);
        Controls.Add(pnlBannerNote);
        Controls.Add(lblDesc);
        Controls.Add(lblTitle);
        Controls.Add(pnlStripe);
        Font = new System.Drawing.Font("Segoe UI", 9.5F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LogoutConfirmDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xác nhận đăng xuất";
        pnlBannerNote.ResumeLayout(false);
        pnlBannerNote.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel pnlStripe;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Panel pnlBannerNote;
    private System.Windows.Forms.Label lblBannerNote;
    private ECMS.UI.Controls.AppButton btnStay;
    private ECMS.UI.Controls.AppButton btnLogout;
}
