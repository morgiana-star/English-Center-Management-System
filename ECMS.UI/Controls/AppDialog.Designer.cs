namespace ECMS.UI.Controls;

partial class AppDialog
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
        pnlTopStripe = new System.Windows.Forms.Panel();
        lblIcon = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblMessage = new System.Windows.Forms.Label();
        pnlBottom = new System.Windows.Forms.Panel();
        pnlDivider = new System.Windows.Forms.Panel();
        _btnPrimary = new ECMS.UI.Controls.AppButton();
        _btnSecondary = new ECMS.UI.Controls.AppButton();
        pnlBottom.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTopStripe
        // 
        pnlTopStripe.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        pnlTopStripe.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTopStripe.Location = new System.Drawing.Point(0, 0);
        pnlTopStripe.Name = "pnlTopStripe";
        pnlTopStripe.Size = new System.Drawing.Size(480, 4);
        pnlTopStripe.TabIndex = 0;
        // 
        // lblIcon
        // 
        lblIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblIcon.Location = new System.Drawing.Point(22, 20);
        lblIcon.Name = "lblIcon";
        lblIcon.Size = new System.Drawing.Size(42, 42);
        lblIcon.TabIndex = 1;
        lblIcon.Text = "✓";
        lblIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(72, 20);
        lblTitle.MaximumSize = new System.Drawing.Size(384, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
        lblTitle.Size = new System.Drawing.Size(119, 32);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "Thành công";
        // 
        // lblMessage
        // 
        lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblMessage.Location = new System.Drawing.Point(72, 58);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new System.Drawing.Size(384, 92);
        lblMessage.TabIndex = 3;
        lblMessage.Text = "Nội dung thông báo chi tiết hiển thị tại đây.";
        // 
        // pnlBottom
        // 
        pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBottom.Controls.Add(_btnPrimary);
        pnlBottom.Controls.Add(_btnSecondary);
        pnlBottom.Controls.Add(pnlDivider);
        pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlBottom.Location = new System.Drawing.Point(0, 166);
        pnlBottom.Name = "pnlBottom";
        pnlBottom.Size = new System.Drawing.Size(480, 60);
        pnlBottom.TabIndex = 4;
        // 
        // pnlDivider
        // 
        pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
        pnlDivider.Location = new System.Drawing.Point(0, 0);
        pnlDivider.Name = "pnlDivider";
        pnlDivider.Size = new System.Drawing.Size(480, 1);
        pnlDivider.TabIndex = 0;
        // 
        // _btnPrimary
        // 
        _btnPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnPrimary.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _btnPrimary.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        _btnPrimary.CornerRadius = 6;
        _btnPrimary.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnPrimary.DialogResult = System.Windows.Forms.DialogResult.OK;
        _btnPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnPrimary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        _btnPrimary.ForeColor = System.Drawing.Color.White;
        _btnPrimary.Location = new System.Drawing.Point(330, 12);
        _btnPrimary.Name = "_btnPrimary";
        _btnPrimary.Size = new System.Drawing.Size(130, 36);
        _btnPrimary.TabIndex = 1;
        _btnPrimary.Text = "Xác nhận";
        _btnPrimary.UseVisualStyleBackColor = false;
        _btnPrimary.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // _btnSecondary
        // 
        _btnSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnSecondary.BackColor = System.Drawing.Color.White;
        _btnSecondary.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnSecondary.CornerRadius = 6;
        _btnSecondary.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnSecondary.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        _btnSecondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnSecondary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        _btnSecondary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        _btnSecondary.Location = new System.Drawing.Point(220, 12);
        _btnSecondary.Name = "_btnSecondary";
        _btnSecondary.Size = new System.Drawing.Size(100, 36);
        _btnSecondary.TabIndex = 2;
        _btnSecondary.Text = "Hủy";
        _btnSecondary.UseVisualStyleBackColor = false;
        _btnSecondary.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // AppDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(480, 226);
        Controls.Add(lblMessage);
        Controls.Add(lblTitle);
        Controls.Add(lblIcon);
        Controls.Add(pnlBottom);
        Controls.Add(pnlTopStripe);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AppDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thông báo";
        pnlBottom.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel pnlTopStripe;
    private System.Windows.Forms.Label lblIcon;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.Panel pnlDivider;
    private ECMS.UI.Controls.AppButton _btnPrimary;
    private ECMS.UI.Controls.AppButton _btnSecondary;
}
