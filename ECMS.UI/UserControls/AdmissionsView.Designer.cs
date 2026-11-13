namespace ECMS.UI.UserControls;

partial class AdmissionsView
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

    #region Component Designer generated code

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        btnImport = new ECMS.UI.Controls.AppButton();
        btnAddLeadTop = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStat4 = new ECMS.UI.Controls.AppCard();
        lblStat4Value = new System.Windows.Forms.Label();
        lblStat4Title = new System.Windows.Forms.Label();
        cardStat3 = new ECMS.UI.Controls.AppCard();
        lblStat3Value = new System.Windows.Forms.Label();
        lblStat3Title = new System.Windows.Forms.Label();
        cardStat2 = new ECMS.UI.Controls.AppCard();
        lblStat2Value = new System.Windows.Forms.Label();
        lblStat2Title = new System.Windows.Forms.Label();
        cardStat1 = new ECMS.UI.Controls.AppCard();
        lblStat1Value = new System.Windows.Forms.Label();
        lblStat1Title = new System.Windows.Forms.Label();
        cardLeadsTable = new ECMS.UI.Controls.AppCard();
        bannerLeadsNote = new ECMS.UI.Controls.AppBanner();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvLeads = new ECMS.UI.Controls.AppDataGrid();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboSourceFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchLeads = new ECMS.UI.Controls.AppTextBox();
        lblLeadsTableTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStat4.SuspendLayout();
        cardStat3.SuspendLayout();
        cardStat2.SuspendLayout();
        cardStat1.SuspendLayout();
        cardLeadsTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLeads).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnImport);
        pnlHeader.Controls.Add(btnAddLeadTop);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnImport
        // 
        btnImport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnImport.BackColor = System.Drawing.Color.White;
        btnImport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnImport.CornerRadius = 6;
        btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnImport.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnImport.Location = new System.Drawing.Point(860, 20);
        btnImport.Name = "btnImport";
        btnImport.Size = new System.Drawing.Size(115, 36);
        btnImport.TabIndex = 4;
        btnImport.Text = "Nhập từ tệp";
        btnImport.UseVisualStyleBackColor = false;
        // 
        // btnAddLeadTop
        // 
        btnAddLeadTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddLeadTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddLeadTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddLeadTop.CornerRadius = 6;
        btnAddLeadTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddLeadTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddLeadTop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddLeadTop.ForeColor = System.Drawing.Color.White;
        btnAddLeadTop.Location = new System.Drawing.Point(985, 20);
        btnAddLeadTop.Name = "btnAddLeadTop";
        btnAddLeadTop.Size = new System.Drawing.Size(150, 36);
        btnAddLeadTop.TabIndex = 3;
        btnAddLeadTop.Text = "+ Thêm tiềm năng";
        btnAddLeadTop.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(430, 20);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Ảnh chụp quy trình ngày 02/10/2026 · Nhân viên phụ trách: Phạm Ngọc Mai";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(255, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tuyển sinh & tư vấn";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 0);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(262, 19);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Tuyển sinh & Tư vấn / Tuyển sinh & tư vấn";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardStat4);
        pnlBody.Controls.Add(cardStat3);
        pnlBody.Controls.Add(cardStat2);
        pnlBody.Controls.Add(cardStat1);
        pnlBody.Controls.Add(cardLeadsTable);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStat4
        // 
        cardStat4.BackColor = System.Drawing.Color.White;
        cardStat4.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStat4.BorderWidth = 1;
        cardStat4.Controls.Add(lblStat4Value);
        cardStat4.Controls.Add(lblStat4Title);
        cardStat4.CornerRadius = 8;
        cardStat4.Location = new System.Drawing.Point(845, 20);
        cardStat4.Name = "cardStat4";
        cardStat4.Padding = new System.Windows.Forms.Padding(16);
        cardStat4.Size = new System.Drawing.Size(260, 85);
        cardStat4.TabIndex = 8;
        // 
        // lblStat4Value
        // 
        lblStat4Value.AutoSize = true;
        lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat4Value.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStat4Value.Location = new System.Drawing.Point(14, 30);
        lblStat4Value.Name = "lblStat4Value";
        lblStat4Value.Size = new System.Drawing.Size(64, 50);
        lblStat4Value.TabIndex = 1;
        lblStat4Value.Text = "24";
        // 
        // lblStat4Title
        // 
        lblStat4Title.AutoSize = true;
        lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat4Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStat4Title.Location = new System.Drawing.Point(16, 10);
        lblStat4Title.Name = "lblStat4Title";
        lblStat4Title.Size = new System.Drawing.Size(86, 20);
        lblStat4Title.TabIndex = 0;
        lblStat4Title.Text = "Đã ghi danh";
        // 
        // cardStat3
        // 
        cardStat3.BackColor = System.Drawing.Color.White;
        cardStat3.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStat3.BorderWidth = 1;
        cardStat3.Controls.Add(lblStat3Value);
        cardStat3.Controls.Add(lblStat3Title);
        cardStat3.CornerRadius = 8;
        cardStat3.Location = new System.Drawing.Point(570, 20);
        cardStat3.Name = "cardStat3";
        cardStat3.Padding = new System.Windows.Forms.Padding(16);
        cardStat3.Size = new System.Drawing.Size(260, 85);
        cardStat3.TabIndex = 7;
        // 
        // lblStat3Value
        // 
        lblStat3Value.AutoSize = true;
        lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat3Value.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStat3Value.Location = new System.Drawing.Point(14, 30);
        lblStat3Value.Name = "lblStat3Value";
        lblStat3Value.Size = new System.Drawing.Size(42, 50);
        lblStat3Value.TabIndex = 1;
        lblStat3Value.Text = "8";
        // 
        // lblStat3Title
        // 
        lblStat3Title.AutoSize = true;
        lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStat3Title.Location = new System.Drawing.Point(16, 10);
        lblStat3Title.Name = "lblStat3Title";
        lblStat3Title.Size = new System.Drawing.Size(147, 20);
        lblStat3Title.TabIndex = 0;
        lblStat3Title.Text = "Đã kiểm tra đầu vào";
        // 
        // cardStat2
        // 
        cardStat2.BackColor = System.Drawing.Color.White;
        cardStat2.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStat2.BorderWidth = 1;
        cardStat2.Controls.Add(lblStat2Value);
        cardStat2.Controls.Add(lblStat2Title);
        cardStat2.CornerRadius = 8;
        cardStat2.Location = new System.Drawing.Point(295, 20);
        cardStat2.Name = "cardStat2";
        cardStat2.Padding = new System.Windows.Forms.Padding(16);
        cardStat2.Size = new System.Drawing.Size(260, 85);
        cardStat2.TabIndex = 6;
        // 
        // lblStat2Value
        // 
        lblStat2Value.AutoSize = true;
        lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat2Value.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStat2Value.Location = new System.Drawing.Point(14, 30);
        lblStat2Value.Name = "lblStat2Value";
        lblStat2Value.Size = new System.Drawing.Size(64, 50);
        lblStat2Value.TabIndex = 1;
        lblStat2Value.Text = "12";
        // 
        // lblStat2Title
        // 
        lblStat2Title.AutoSize = true;
        lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStat2Title.Location = new System.Drawing.Point(16, 10);
        lblStat2Title.Name = "lblStat2Title";
        lblStat2Title.Size = new System.Drawing.Size(84, 20);
        lblStat2Title.TabIndex = 0;
        lblStat2Title.Text = "Chờ tư vấn";
        // 
        // cardStat1
        // 
        cardStat1.BackColor = System.Drawing.Color.White;
        cardStat1.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStat1.BorderWidth = 1;
        cardStat1.Controls.Add(lblStat1Value);
        cardStat1.Controls.Add(lblStat1Title);
        cardStat1.CornerRadius = 8;
        cardStat1.Location = new System.Drawing.Point(20, 20);
        cardStat1.Name = "cardStat1";
        cardStat1.Padding = new System.Windows.Forms.Padding(16);
        cardStat1.Size = new System.Drawing.Size(260, 85);
        cardStat1.TabIndex = 5;
        // 
        // lblStat1Value
        // 
        lblStat1Value.AutoSize = true;
        lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStat1Value.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStat1Value.Location = new System.Drawing.Point(14, 30);
        lblStat1Value.Name = "lblStat1Value";
        lblStat1Value.Size = new System.Drawing.Size(64, 50);
        lblStat1Value.TabIndex = 1;
        lblStat1Value.Text = "42";
        // 
        // lblStat1Title
        // 
        lblStat1Title.AutoSize = true;
        lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStat1Title.Location = new System.Drawing.Point(16, 10);
        lblStat1Title.Name = "lblStat1Title";
        lblStat1Title.Size = new System.Drawing.Size(146, 20);
        lblStat1Title.TabIndex = 0;
        lblStat1Title.Text = "Tiềm năng tháng 10";
        // 
        // cardLeadsTable
        // 
        cardLeadsTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardLeadsTable.BackColor = System.Drawing.Color.White;
        cardLeadsTable.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardLeadsTable.BorderWidth = 1;
        cardLeadsTable.Controls.Add(bannerLeadsNote);
        cardLeadsTable.Controls.Add(lblPagingNav);
        cardLeadsTable.Controls.Add(lblPagingInfo);
        cardLeadsTable.Controls.Add(dgvLeads);
        cardLeadsTable.Controls.Add(cboStatusFilter);
        cardLeadsTable.Controls.Add(cboSourceFilter);
        cardLeadsTable.Controls.Add(txtSearchLeads);
        cardLeadsTable.Controls.Add(lblLeadsTableTitle);
        cardLeadsTable.CornerRadius = 8;
        cardLeadsTable.Location = new System.Drawing.Point(20, 120);
        cardLeadsTable.Name = "cardLeadsTable";
        cardLeadsTable.Padding = new System.Windows.Forms.Padding(16);
        cardLeadsTable.Size = new System.Drawing.Size(1115, 570);
        cardLeadsTable.TabIndex = 0;
        // 
        // bannerLeadsNote
        // 
        bannerLeadsNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerLeadsNote.BannerType = ECMS.UI.Controls.BannerType.Info;
        bannerLeadsNote.Location = new System.Drawing.Point(20, 515);
        bannerLeadsNote.Message = "Chọn một hồ sơ để xem lịch sử và tiếp tục tư vấn. Ghi danh sẽ tạo hồ sơ học viên, không yêu cầu nhập lại thông tin.";
        bannerLeadsNote.Name = "bannerLeadsNote";
        bannerLeadsNote.Size = new System.Drawing.Size(1075, 38);
        bannerLeadsNote.TabIndex = 7;
        bannerLeadsNote.Title = "Hướng dẫn:";
        bannerLeadsNote.Variant = ECMS.UI.Controls.BannerVariant.Info;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblPagingNav.Location = new System.Drawing.Point(930, 480);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(164, 20);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblPagingInfo.Location = new System.Drawing.Point(20, 480);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(207, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 42 khách hàng tiềm năng";
        // 
        // dgvLeads
        // 
        dgvLeads.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvLeads.Location = new System.Drawing.Point(20, 95);
        dgvLeads.Name = "dgvLeads";
        dgvLeads.Size = new System.Drawing.Size(1075, 375);
        dgvLeads.TabIndex = 4;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboStatusFilter.Location = new System.Drawing.Point(490, 50);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(160, 32);
        cboStatusFilter.TabIndex = 3;
        // 
        // cboSourceFilter
        // 
        cboSourceFilter.BackColor = System.Drawing.Color.White;
        cboSourceFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboSourceFilter.Location = new System.Drawing.Point(315, 50);
        cboSourceFilter.Name = "cboSourceFilter";
        cboSourceFilter.Size = new System.Drawing.Size(160, 32);
        cboSourceFilter.TabIndex = 2;
        // 
        // txtSearchLeads
        // 
        txtSearchLeads.BackColor = System.Drawing.Color.Transparent;
        txtSearchLeads.CornerRadius = 6;
        txtSearchLeads.ErrorMessage = "";
        txtSearchLeads.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchLeads.HasError = false;
        txtSearchLeads.Location = new System.Drawing.Point(20, 50);
        txtSearchLeads.Name = "txtSearchLeads";
        txtSearchLeads.Placeholder = "🔍  Tìm tên, điện thoại, mã tiềm năng...";
        txtSearchLeads.ReadOnly = false;
        txtSearchLeads.Size = new System.Drawing.Size(280, 32);
        txtSearchLeads.TabIndex = 1;
        txtSearchLeads.UseSystemPasswordChar = false;
        // 
        // lblLeadsTableTitle
        // 
        lblLeadsTableTitle.AutoSize = true;
        lblLeadsTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblLeadsTableTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblLeadsTableTitle.Location = new System.Drawing.Point(20, 16);
        lblLeadsTableTitle.Name = "lblLeadsTableTitle";
        lblLeadsTableTitle.Size = new System.Drawing.Size(182, 28);
        lblLeadsTableTitle.TabIndex = 0;
        lblLeadsTableTitle.Text = "Danh sách tư vấn";
        // 
        // AdmissionsView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "AdmissionsView";
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardStat4.ResumeLayout(false);
        cardStat4.PerformLayout();
        cardStat3.ResumeLayout(false);
        cardStat3.PerformLayout();
        cardStat2.ResumeLayout(false);
        cardStat2.PerformLayout();
        cardStat1.ResumeLayout(false);
        cardStat1.PerformLayout();
        cardLeadsTable.ResumeLayout(false);
        cardLeadsTable.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLeads).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private ECMS.UI.Controls.AppButton btnImport;
    private ECMS.UI.Controls.AppButton btnAddLeadTop;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStat1;
    private System.Windows.Forms.Label lblStat1Title;
    private System.Windows.Forms.Label lblStat1Value;
    private ECMS.UI.Controls.AppCard cardStat2;
    private System.Windows.Forms.Label lblStat2Title;
    private System.Windows.Forms.Label lblStat2Value;
    private ECMS.UI.Controls.AppCard cardStat3;
    private System.Windows.Forms.Label lblStat3Title;
    private System.Windows.Forms.Label lblStat3Value;
    private ECMS.UI.Controls.AppCard cardStat4;
    private System.Windows.Forms.Label lblStat4Title;
    private System.Windows.Forms.Label lblStat4Value;

    private ECMS.UI.Controls.AppCard cardLeadsTable;
    private System.Windows.Forms.Label lblLeadsTableTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchLeads;
    private ECMS.UI.Controls.AppComboBox cboSourceFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppDataGrid dgvLeads;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppBanner bannerLeadsNote;
}
