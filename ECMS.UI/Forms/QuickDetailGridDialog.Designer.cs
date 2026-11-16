namespace ECMS.UI.Forms;

partial class QuickDetailGridDialog
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
        lblSubtitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardGrid = new ECMS.UI.Controls.AppCard();
        dgvGrid = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblCount = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGrid).BeginInit();
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
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(820, 72);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(185, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Tiêu đề xem chi tiết";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 42);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(262, 15);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Dữ liệu dạng bảng tra cứu chi tiết toàn trung tâm";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardGrid);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 72);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
        pnlBody.Size = new System.Drawing.Size(820, 418);
        pnlBody.TabIndex = 1;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardGrid.BorderWidth = 1;
        cardGrid.Controls.Add(dgvGrid);
        cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardGrid.Location = new System.Drawing.Point(20, 16);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(12);
        cardGrid.Size = new System.Drawing.Size(780, 390);
        cardGrid.TabIndex = 0;
        // 
        // dgvGrid
        // 
        dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvGrid.Location = new System.Drawing.Point(12, 12);
        dgvGrid.Name = "dgvGrid";
        dgvGrid.Size = new System.Drawing.Size(756, 366);
        dgvGrid.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(lblCount);
        pnlFooter.Controls.Add(btnClose);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 490);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(820, 56);
        pnlFooter.TabIndex = 2;
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
        btnClose.Location = new System.Drawing.Point(702, 11);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(96, 34);
        btnClose.TabIndex = 0;
        btnClose.Text = "Đóng";
        // 
        // lblCount
        // 
        lblCount.AutoSize = true;
        lblCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblCount.Location = new System.Drawing.Point(24, 20);
        lblCount.Name = "lblCount";
        lblCount.Size = new System.Drawing.Size(99, 15);
        lblCount.TabIndex = 1;
        lblCount.Text = "Hiển thị: 0 bản ghi";
        // 
        // QuickDetailGridDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(820, 546);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "QuickDetailGridDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết dữ liệu";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvGrid).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardGrid;
    public ECMS.UI.Controls.AppDataGrid dgvGrid;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnClose;
    private System.Windows.Forms.Label lblCount;
}
