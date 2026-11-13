namespace ECMS.UI.Forms;

partial class ArchiveStudentDialog
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
        bannerWarn = new ECMS.UI.Controls.AppBanner();
        lblStudentInfo = new System.Windows.Forms.Label();
        lblClassInfo = new System.Windows.Forms.Label();
        lblImpactInfo = new System.Windows.Forms.Label();
        lblReason = new System.Windows.Forms.Label();
        txtArchiveReason = new ECMS.UI.Controls.AppTextBox();
        lblNote = new System.Windows.Forms.Label();
        btnCancelArchive = new ECMS.UI.Controls.AppButton();
        btnConfirmArchive = new ECMS.UI.Controls.AppButton();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(24, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(252, 30);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Lưu trữ hồ sơ học viên?";
        // 
        // bannerWarn
        // 
        bannerWarn.BannerType = ECMS.UI.Controls.BannerType.Warning;
        bannerWarn.Location = new System.Drawing.Point(24, 60);
        bannerWarn.Message = "Không thể xóa vĩnh viễn: hồ sơ có 2 phiếu thu, 8 buổi điểm danh và kết quả kiểm tra.";
        bannerWarn.Name = "bannerWarn";
        bannerWarn.Size = new System.Drawing.Size(460, 45);
        bannerWarn.TabIndex = 1;
        bannerWarn.Title = "✕ Cảnh báo:";
        bannerWarn.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        // 
        // lblStudentInfo
        // 
        lblStudentInfo.AutoSize = true;
        lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblStudentInfo.Location = new System.Drawing.Point(24, 120);
        lblStudentInfo.Name = "lblStudentInfo";
        lblStudentInfo.Size = new System.Drawing.Size(273, 21);
        lblStudentInfo.TabIndex = 2;
        lblStudentInfo.Text = "Học viên:  Nguyễn Minh Anh · HV-0241";
        // 
        // lblClassInfo
        // 
        lblClassInfo.AutoSize = true;
        lblClassInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblClassInfo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblClassInfo.Location = new System.Drawing.Point(24, 150);
        lblClassInfo.Name = "lblClassInfo";
        lblClassInfo.Size = new System.Drawing.Size(239, 21);
        lblClassInfo.TabIndex = 3;
        lblClassInfo.Text = "Lớp hiện tại:  IELTS-F01 · Đang học";
        // 
        // lblImpactInfo
        // 
        lblImpactInfo.AutoSize = true;
        lblImpactInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblImpactInfo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblImpactInfo.Location = new System.Drawing.Point(24, 180);
        lblImpactInfo.Name = "lblImpactInfo";
        lblImpactInfo.Size = new System.Drawing.Size(286, 21);
        lblImpactInfo.TabIndex = 4;
        lblImpactInfo.Text = "Tác động:  Ẩn khỏi danh sách, giữ lịch sử";
        // 
        // lblReason
        // 
        lblReason.AutoSize = true;
        lblReason.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblReason.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblReason.Location = new System.Drawing.Point(24, 215);
        lblReason.Name = "lblReason";
        lblReason.Size = new System.Drawing.Size(107, 19);
        lblReason.TabIndex = 5;
        lblReason.Text = "Lý do lưu trữ *";
        // 
        // txtArchiveReason
        // 
        txtArchiveReason.BackColor = System.Drawing.Color.Transparent;
        txtArchiveReason.CornerRadius = 6;
        txtArchiveReason.ErrorMessage = "";
        txtArchiveReason.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtArchiveReason.HasError = false;
        txtArchiveReason.Location = new System.Drawing.Point(24, 238);
        txtArchiveReason.Name = "txtArchiveReason";
        txtArchiveReason.Placeholder = "Theo yêu cầu phụ huynh — chờ xác nhận";
        txtArchiveReason.ReadOnly = false;
        txtArchiveReason.Size = new System.Drawing.Size(460, 32);
        txtArchiveReason.TabIndex = 6;
        txtArchiveReason.UseSystemPasswordChar = false;
        // 
        // lblNote
        // 
        lblNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblNote.Location = new System.Drawing.Point(24, 280);
        lblNote.Name = "lblNote";
        lblNote.Size = new System.Drawing.Size(460, 40);
        lblNote.TabIndex = 7;
        lblNote.Text = "Có thể khôi phục từ bộ lọc \"Đã lưu trữ\". Hủy để giữ hồ sơ đang hoạt động.";
        // 
        // btnCancelArchive
        // 
        btnCancelArchive.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelArchive.BackColor = System.Drawing.Color.White;
        btnCancelArchive.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelArchive.CornerRadius = 6;
        btnCancelArchive.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelArchive.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnCancelArchive.Location = new System.Drawing.Point(265, 330);
        btnCancelArchive.Name = "btnCancelArchive";
        btnCancelArchive.Size = new System.Drawing.Size(95, 36);
        btnCancelArchive.TabIndex = 8;
        btnCancelArchive.Text = "Hủy";
        btnCancelArchive.UseVisualStyleBackColor = false;
        // 
        // btnConfirmArchive
        // 
        btnConfirmArchive.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnConfirmArchive.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnConfirmArchive.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmArchive.CornerRadius = 6;
        btnConfirmArchive.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmArchive.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmArchive.ForeColor = System.Drawing.Color.White;
        btnConfirmArchive.Location = new System.Drawing.Point(368, 330);
        btnConfirmArchive.Name = "btnConfirmArchive";
        btnConfirmArchive.Size = new System.Drawing.Size(120, 36);
        btnConfirmArchive.TabIndex = 9;
        btnConfirmArchive.Text = "Lưu trữ hồ sơ";
        btnConfirmArchive.UseVisualStyleBackColor = false;
        // 
        // ArchiveStudentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(510, 385);
        Controls.Add(btnConfirmArchive);
        Controls.Add(btnCancelArchive);
        Controls.Add(lblNote);
        Controls.Add(txtArchiveReason);
        Controls.Add(lblReason);
        Controls.Add(lblImpactInfo);
        Controls.Add(lblClassInfo);
        Controls.Add(lblStudentInfo);
        Controls.Add(bannerWarn);
        Controls.Add(lblTitle);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ArchiveStudentDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Lưu trữ hồ sơ học viên — ECMS";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppBanner bannerWarn;
    private System.Windows.Forms.Label lblStudentInfo;
    private System.Windows.Forms.Label lblClassInfo;
    private System.Windows.Forms.Label lblImpactInfo;
    private System.Windows.Forms.Label lblReason;
    private ECMS.UI.Controls.AppTextBox txtArchiveReason;
    private System.Windows.Forms.Label lblNote;
    private ECMS.UI.Controls.AppButton btnCancelArchive;
    private ECMS.UI.Controls.AppButton btnConfirmArchive;
}
