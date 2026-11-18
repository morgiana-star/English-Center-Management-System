namespace ECMS.UI.Forms;

partial class QuickSearchDetailDialog
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
        lblEntityBadge = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardContent = new ECMS.UI.Controls.AppCard();
        dgvProps = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        lblNote = new System.Windows.Forms.Label();
        btnClose = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardContent.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProps).BeginInit();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblEntityBadge);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(650, 78);
        pnlHeader.TabIndex = 0;
        // 
        // lblEntityBadge
        // 
        lblEntityBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        lblEntityBadge.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        lblEntityBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEntityBadge.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblEntityBadge.Location = new System.Drawing.Point(520, 16);
        lblEntityBadge.Name = "lblEntityBadge";
        lblEntityBadge.Size = new System.Drawing.Size(106, 26);
        lblEntityBadge.TabIndex = 2;
        lblEntityBadge.Text = "HỌC VIÊN";
        lblEntityBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(262, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Nguyễn Minh Anh · HV-0241";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 45);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(260, 15);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Truy xuất thông tin nhanh (Chế độ chỉ đọc dữ liệu)";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardContent);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 78);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
        pnlBody.Size = new System.Drawing.Size(650, 368);
        pnlBody.TabIndex = 1;
        // 
        // cardContent
        // 
        cardContent.BackColor = System.Drawing.Color.White;
        cardContent.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardContent.BorderWidth = 1;
        cardContent.Controls.Add(dgvProps);
        cardContent.Dock = System.Windows.Forms.DockStyle.Fill;
        cardContent.Location = new System.Drawing.Point(20, 16);
        cardContent.Name = "cardContent";
        cardContent.Padding = new System.Windows.Forms.Padding(12);
        cardContent.Size = new System.Drawing.Size(610, 340);
        cardContent.TabIndex = 0;
        // 
        // dgvProps
        // 
        dgvProps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProps.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvProps.Location = new System.Drawing.Point(12, 12);
        dgvProps.Name = "dgvProps";
        dgvProps.Size = new System.Drawing.Size(586, 316);
        dgvProps.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(lblNote);
        pnlFooter.Controls.Add(btnClose);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 446);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(650, 56);
        pnlFooter.TabIndex = 2;
        // 
        // lblNote
        // 
        lblNote.AutoSize = true;
        lblNote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblNote.Location = new System.Drawing.Point(24, 21);
        lblNote.Name = "lblNote";
        lblNote.Size = new System.Drawing.Size(306, 13);
        lblNote.TabIndex = 1;
        lblNote.Text = "ℹ️  Màn hình giới hạn ở mức xem và tra cứu dữ liệu tức thời";
        // 
        // btnClose
        // 
        btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnClose.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnClose.ForeColor = System.Drawing.Color.White;
        btnClose.Location = new System.Drawing.Point(532, 11);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(94, 34);
        btnClose.TabIndex = 0;
        btnClose.Text = "Đóng";
        // 
        // QuickSearchDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(650, 502);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "QuickSearchDetailDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Truy xuất thông tin nhanh";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardContent.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProps).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblEntityBadge;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardContent;
    public ECMS.UI.Controls.AppDataGrid dgvProps;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnClose;
    private System.Windows.Forms.Label lblNote;
}
