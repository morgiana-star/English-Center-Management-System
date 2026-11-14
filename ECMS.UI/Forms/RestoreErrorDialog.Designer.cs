namespace ECMS.UI.Forms;

partial class RestoreErrorDialog
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
        lblDialogTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        btnChooseOther = new ECMS.UI.Controls.AppButton();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblRecommendation = new System.Windows.Forms.Label();
        lblLogVal = new System.Windows.Forms.Label();
        lblLogKey = new System.Windows.Forms.Label();
        lblDetailVal = new System.Windows.Forms.Label();
        lblDetailKey = new System.Windows.Forms.Label();
        lblFileVal = new System.Windows.Forms.Label();
        lblFileKey = new System.Windows.Forms.Label();
        bannerError = new ECMS.UI.Controls.AppBanner();
        lblDialogSubtitle = new System.Windows.Forms.Label();
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
        pnlHeader.Size = new System.Drawing.Size(620, 70);
        pnlHeader.TabIndex = 0;
        // 
        // btnCloseTop
        // 
        btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCloseTop.AutoSize = true;
        btnCloseTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCloseTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCloseTop.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnCloseTop.Location = new System.Drawing.Point(576, 16);
        btnCloseTop.Name = "btnCloseTop";
        btnCloseTop.Size = new System.Drawing.Size(29, 28);
        btnCloseTop.TabIndex = 2;
        btnCloseTop.Text = "✕";
        // 
        // lblDialogTitle
        // 
        lblDialogTitle.AutoSize = true;
        lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblDialogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblDialogTitle.Location = new System.Drawing.Point(24, 16);
        lblDialogTitle.Name = "lblDialogTitle";
        lblDialogTitle.Size = new System.Drawing.Size(224, 28);
        lblDialogTitle.TabIndex = 0;
        lblDialogTitle.Text = "Lỗi kiểm tra khôi phục";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = System.Drawing.Color.White;
        pnlContent.Controls.Add(btnChooseOther);
        pnlContent.Controls.Add(btnClose);
        pnlContent.Controls.Add(lblRecommendation);
        pnlContent.Controls.Add(lblLogVal);
        pnlContent.Controls.Add(lblLogKey);
        pnlContent.Controls.Add(lblDetailVal);
        pnlContent.Controls.Add(lblDetailKey);
        pnlContent.Controls.Add(lblFileVal);
        pnlContent.Controls.Add(lblFileKey);
        pnlContent.Controls.Add(bannerError);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 70);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(620, 350);
        pnlContent.TabIndex = 1;
        // 
        // btnChooseOther
        // 
        btnChooseOther.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnChooseOther.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnChooseOther.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnChooseOther.CornerRadius = 5;
        btnChooseOther.Cursor = System.Windows.Forms.Cursors.Hand;
        btnChooseOther.FlatAppearance.BorderSize = 0;
        btnChooseOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnChooseOther.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnChooseOther.ForeColor = System.Drawing.Color.White;
        btnChooseOther.Location = new System.Drawing.Point(456, 295);
        btnChooseOther.Name = "btnChooseOther";
        btnChooseOther.Size = new System.Drawing.Size(140, 34);
        btnChooseOther.TabIndex = 9;
        btnChooseOther.Text = "Chọn tệp khác...";
        btnChooseOther.UseVisualStyleBackColor = false;
        btnChooseOther.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnClose
        // 
        btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnClose.BackColor = System.Drawing.Color.White;
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnClose.Location = new System.Drawing.Point(366, 295);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(80, 34);
        btnClose.TabIndex = 8;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblRecommendation
        // 
        lblRecommendation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblRecommendation.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblRecommendation.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblRecommendation.Location = new System.Drawing.Point(24, 245);
        lblRecommendation.Name = "lblRecommendation";
        lblRecommendation.Size = new System.Drawing.Size(572, 35);
        lblRecommendation.TabIndex = 7;
        lblRecommendation.Text = ("Vui lòng chọn một bản sao lưu khác hoặc kiểm tra lại ổ cứng lưu trữ. Dữ liệu hiện" + " tại chưa bị thay đổi.");
        // 
        // lblLogVal
        // 
        lblLogVal.AutoSize = true;
        lblLogVal.Cursor = System.Windows.Forms.Cursors.Hand;
        lblLogVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
        lblLogVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblLogVal.Location = new System.Drawing.Point(140, 195);
        lblLogVal.Name = "lblLogVal";
        lblLogVal.Size = new System.Drawing.Size(179, 20);
        lblLogVal.TabIndex = 6;
        lblLogVal.Text = "C:\\ECMS\\Logs\\restore.log";
        // 
        // lblLogKey
        // 
        lblLogKey.AutoSize = true;
        lblLogKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblLogKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblLogKey.Location = new System.Drawing.Point(24, 195);
        lblLogKey.Name = "lblLogKey";
        lblLogKey.Size = new System.Drawing.Size(94, 20);
        lblLogKey.TabIndex = 5;
        lblLogKey.Text = "Nhật ký xử lý";
        // 
        // lblDetailVal
        // 
        lblDetailVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblDetailVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDetailVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDetailVal.Location = new System.Drawing.Point(140, 140);
        lblDetailVal.Name = "lblDetailVal";
        lblDetailVal.Size = new System.Drawing.Size(456, 45);
        lblDetailVal.TabIndex = 4;
        lblDetailVal.Text = ("PRAGMA integrity_check trả về kết quả lỗi hoặc header tệp không khớp chuẩn SQLite" + " 3.");
        // 
        // lblDetailKey
        // 
        lblDetailKey.AutoSize = true;
        lblDetailKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDetailKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDetailKey.Location = new System.Drawing.Point(24, 140);
        lblDetailKey.Name = "lblDetailKey";
        lblDetailKey.Size = new System.Drawing.Size(112, 20);
        lblDetailKey.TabIndex = 3;
        lblDetailKey.Text = "Chi tiết kỹ thuật";
        // 
        // lblFileVal
        // 
        lblFileVal.AutoSize = true;
        lblFileVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFileVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblFileVal.Location = new System.Drawing.Point(140, 105);
        lblFileVal.Name = "lblFileVal";
        lblFileVal.Size = new System.Drawing.Size(305, 20);
        lblFileVal.TabIndex = 2;
        lblFileVal.Text = "D:\\ECMS_Backup\\corrupted_backup_2026.db";
        // 
        // lblFileKey
        // 
        lblFileKey.AutoSize = true;
        lblFileKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFileKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblFileKey.Location = new System.Drawing.Point(24, 105);
        lblFileKey.Name = "lblFileKey";
        lblFileKey.Size = new System.Drawing.Size(92, 20);
        lblFileKey.TabIndex = 1;
        lblFileKey.Text = "Tệp kiểm tra";
        // 
        // bannerError
        // 
        bannerError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerError.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)226)), ((int)((byte)226)));
        bannerError.BannerType = ECMS.UI.Controls.BannerType.Danger;
        bannerError.Location = new System.Drawing.Point(24, 20);
        bannerError.Message = "Tệp không phải CSDL SQLite hợp lệ hoặc đã bị hỏng.";
        bannerError.Name = "bannerError";
        bannerError.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerError.Size = new System.Drawing.Size(572, 65);
        bannerError.TabIndex = 0;
        bannerError.Title = "Mã lỗi: DB-RESTORE-02";
        bannerError.Variant = ECMS.UI.Controls.BannerVariant.Danger;
        // 
        // lblDialogSubtitle
        // 
        lblDialogSubtitle.AutoSize = true;
        lblDialogSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblDialogSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDialogSubtitle.Location = new System.Drawing.Point(24, 42);
        lblDialogSubtitle.Name = "lblDialogSubtitle";
        lblDialogSubtitle.Size = new System.Drawing.Size(271, 19);
        lblDialogSubtitle.TabIndex = 1;
        lblDialogSubtitle.Text = "Không thể áp dụng bản sao lưu được chọn";
        // 
        // RestoreErrorDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(620, 420);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Lỗi kiểm tra khôi phục";
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
    private ECMS.UI.Controls.AppBanner bannerError;
    private System.Windows.Forms.Label lblFileKey;
    private System.Windows.Forms.Label lblFileVal;
    private System.Windows.Forms.Label lblDetailKey;
    private System.Windows.Forms.Label lblDetailVal;
    private System.Windows.Forms.Label lblLogKey;
    private System.Windows.Forms.Label lblLogVal;
    private System.Windows.Forms.Label lblRecommendation;
    private ECMS.UI.Controls.AppButton btnClose;
    private ECMS.UI.Controls.AppButton btnChooseOther;
}
