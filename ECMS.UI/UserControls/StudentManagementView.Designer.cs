namespace ECMS.UI.UserControls;

partial class StudentManagementView
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
        btnExport = new ECMS.UI.Controls.AppButton();
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardStatArchived = new ECMS.UI.Controls.AppCard();
        lblStatArchivedValue = new System.Windows.Forms.Label();
        lblStatArchivedTitle = new System.Windows.Forms.Label();
        cardStatCompleted = new ECMS.UI.Controls.AppCard();
        lblStatCompletedValue = new System.Windows.Forms.Label();
        lblStatCompletedTitle = new System.Windows.Forms.Label();
        cardStatStudying = new ECMS.UI.Controls.AppCard();
        lblStatStudyingValue = new System.Windows.Forms.Label();
        lblStatStudyingTitle = new System.Windows.Forms.Label();
        cardStatTotal = new ECMS.UI.Controls.AppCard();
        lblStatTotalValue = new System.Windows.Forms.Label();
        lblStatTotalTitle = new System.Windows.Forms.Label();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        bannerArchiveNote = new ECMS.UI.Controls.AppBanner();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvStudents = new ECMS.UI.Controls.AppDataGrid();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchStudent = new ECMS.UI.Controls.AppTextBox();
        lblStudentListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStatArchived.SuspendLayout();
        cardStatCompleted.SuspendLayout();
        cardStatStudying.SuspendLayout();
        cardStatTotal.SuspendLayout();
        cardStudentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnExport);
        pnlHeader.Controls.Add(btnAddStudent);
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
        // btnExport
        // 
        btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnExport.BackColor = System.Drawing.Color.White;
        btnExport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExport.CornerRadius = 6;
        btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnExport.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        btnExport.Location = new System.Drawing.Point(855, 20);
        btnExport.Name = "btnExport";
        btnExport.Size = new System.Drawing.Size(125, 36);
        btnExport.TabIndex = 4;
        btnExport.Text = "Xuất danh sách";
        btnExport.UseVisualStyleBackColor = false;
        // 
        // btnAddStudent
        // 
        btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddStudent.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddStudent.CornerRadius = 6;
        btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddStudent.ForeColor = System.Drawing.Color.White;
        btnAddStudent.Location = new System.Drawing.Point(990, 20);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new System.Drawing.Size(145, 36);
        btnAddStudent.TabIndex = 3;
        btnAddStudent.Text = "+ Thêm học viên";
        btnAddStudent.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(262, 20);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Dữ liệu mẫu · Trung tâm Anh ngữ Minh Trí";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(129, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Học viên";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 0);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(161, 19);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Học viên / Học viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardStatArchived);
        pnlBody.Controls.Add(cardStatCompleted);
        pnlBody.Controls.Add(cardStatStudying);
        pnlBody.Controls.Add(cardStatTotal);
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 725);
        pnlBody.TabIndex = 1;
        // 
        // cardStatArchived
        // 
        cardStatArchived.BackColor = System.Drawing.Color.White;
        cardStatArchived.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStatArchived.BorderWidth = 1;
        cardStatArchived.Controls.Add(lblStatArchivedValue);
        cardStatArchived.Controls.Add(lblStatArchivedTitle);
        cardStatArchived.CornerRadius = 8;
        cardStatArchived.Location = new System.Drawing.Point(845, 20);
        cardStatArchived.Name = "cardStatArchived";
        cardStatArchived.Padding = new System.Windows.Forms.Padding(16);
        cardStatArchived.Size = new System.Drawing.Size(260, 85);
        cardStatArchived.TabIndex = 8;
        // 
        // lblStatArchivedValue
        // 
        lblStatArchivedValue.AutoSize = true;
        lblStatArchivedValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatArchivedValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStatArchivedValue.Location = new System.Drawing.Point(14, 30);
        lblStatArchivedValue.Name = "lblStatArchivedValue";
        lblStatArchivedValue.Size = new System.Drawing.Size(64, 50);
        lblStatArchivedValue.TabIndex = 1;
        lblStatArchivedValue.Text = "18";
        // 
        // lblStatArchivedTitle
        // 
        lblStatArchivedTitle.AutoSize = true;
        lblStatArchivedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatArchivedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStatArchivedTitle.Location = new System.Drawing.Point(16, 10);
        lblStatArchivedTitle.Name = "lblStatArchivedTitle";
        lblStatArchivedTitle.Size = new System.Drawing.Size(78, 20);
        lblStatArchivedTitle.TabIndex = 0;
        lblStatArchivedTitle.Text = "Đã lưu trữ";
        // 
        // cardStatCompleted
        // 
        cardStatCompleted.BackColor = System.Drawing.Color.White;
        cardStatCompleted.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStatCompleted.BorderWidth = 1;
        cardStatCompleted.Controls.Add(lblStatCompletedValue);
        cardStatCompleted.Controls.Add(lblStatCompletedTitle);
        cardStatCompleted.CornerRadius = 8;
        cardStatCompleted.Location = new System.Drawing.Point(570, 20);
        cardStatCompleted.Name = "cardStatCompleted";
        cardStatCompleted.Padding = new System.Windows.Forms.Padding(16);
        cardStatCompleted.Size = new System.Drawing.Size(260, 85);
        cardStatCompleted.TabIndex = 7;
        // 
        // lblStatCompletedValue
        // 
        lblStatCompletedValue.AutoSize = true;
        lblStatCompletedValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatCompletedValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStatCompletedValue.Location = new System.Drawing.Point(14, 30);
        lblStatCompletedValue.Name = "lblStatCompletedValue";
        lblStatCompletedValue.Size = new System.Drawing.Size(64, 50);
        lblStatCompletedValue.TabIndex = 1;
        lblStatCompletedValue.Text = "62";
        // 
        // lblStatCompletedTitle
        // 
        lblStatCompletedTitle.AutoSize = true;
        lblStatCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatCompletedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStatCompletedTitle.Location = new System.Drawing.Point(16, 10);
        lblStatCompletedTitle.Name = "lblStatCompletedTitle";
        lblStatCompletedTitle.Size = new System.Drawing.Size(86, 20);
        lblStatCompletedTitle.TabIndex = 0;
        lblStatCompletedTitle.Text = "Hoàn thành";
        // 
        // cardStatStudying
        // 
        cardStatStudying.BackColor = System.Drawing.Color.White;
        cardStatStudying.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStatStudying.BorderWidth = 1;
        cardStatStudying.Controls.Add(lblStatStudyingValue);
        cardStatStudying.Controls.Add(lblStatStudyingTitle);
        cardStatStudying.CornerRadius = 8;
        cardStatStudying.Location = new System.Drawing.Point(295, 20);
        cardStatStudying.Name = "cardStatStudying";
        cardStatStudying.Padding = new System.Windows.Forms.Padding(16);
        cardStatStudying.Size = new System.Drawing.Size(260, 85);
        cardStatStudying.TabIndex = 6;
        // 
        // lblStatStudyingValue
        // 
        lblStatStudyingValue.AutoSize = true;
        lblStatStudyingValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatStudyingValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStatStudyingValue.Location = new System.Drawing.Point(14, 30);
        lblStatStudyingValue.Name = "lblStatStudyingValue";
        lblStatStudyingValue.Size = new System.Drawing.Size(86, 50);
        lblStatStudyingValue.TabIndex = 1;
        lblStatStudyingValue.Text = "348";
        // 
        // lblStatStudyingTitle
        // 
        lblStatStudyingTitle.AutoSize = true;
        lblStatStudyingTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatStudyingTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStatStudyingTitle.Location = new System.Drawing.Point(16, 10);
        lblStatStudyingTitle.Name = "lblStatStudyingTitle";
        lblStatStudyingTitle.Size = new System.Drawing.Size(74, 20);
        lblStatStudyingTitle.TabIndex = 0;
        lblStatStudyingTitle.Text = "Đang học";
        // 
        // cardStatTotal
        // 
        cardStatTotal.BackColor = System.Drawing.Color.White;
        cardStatTotal.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStatTotal.BorderWidth = 1;
        cardStatTotal.Controls.Add(lblStatTotalValue);
        cardStatTotal.Controls.Add(lblStatTotalTitle);
        cardStatTotal.CornerRadius = 8;
        cardStatTotal.Location = new System.Drawing.Point(20, 20);
        cardStatTotal.Name = "cardStatTotal";
        cardStatTotal.Padding = new System.Windows.Forms.Padding(16);
        cardStatTotal.Size = new System.Drawing.Size(260, 85);
        cardStatTotal.TabIndex = 5;
        // 
        // lblStatTotalValue
        // 
        lblStatTotalValue.AutoSize = true;
        lblStatTotalValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblStatTotalValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStatTotalValue.Location = new System.Drawing.Point(14, 30);
        lblStatTotalValue.Name = "lblStatTotalValue";
        lblStatTotalValue.Size = new System.Drawing.Size(86, 50);
        lblStatTotalValue.TabIndex = 1;
        lblStatTotalValue.Text = "428";
        // 
        // lblStatTotalTitle
        // 
        lblStatTotalTitle.AutoSize = true;
        lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatTotalTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStatTotalTitle.Location = new System.Drawing.Point(16, 10);
        lblStatTotalTitle.Name = "lblStatTotalTitle";
        lblStatTotalTitle.Size = new System.Drawing.Size(92, 20);
        lblStatTotalTitle.TabIndex = 0;
        lblStatTotalTitle.Text = "Tổng hồ sơ";
        // 
        // cardStudentList
        // 
        cardStudentList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(bannerArchiveNote);
        cardStudentList.Controls.Add(lblPagingNav);
        cardStudentList.Controls.Add(lblPagingInfo);
        cardStudentList.Controls.Add(dgvStudents);
        cardStudentList.Controls.Add(cboClassFilter);
        cardStudentList.Controls.Add(cboStatusFilter);
        cardStudentList.Controls.Add(txtSearchStudent);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.CornerRadius = 8;
        cardStudentList.Location = new System.Drawing.Point(20, 120);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(16);
        cardStudentList.Size = new System.Drawing.Size(1115, 570);
        cardStudentList.TabIndex = 0;
        // 
        // bannerArchiveNote
        // 
        bannerArchiveNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerArchiveNote.BannerType = ECMS.UI.Controls.BannerType.Warning;
        bannerArchiveNote.Location = new System.Drawing.Point(20, 515);
        bannerArchiveNote.Message = "Hồ sơ có lịch sử lớp, điểm hoặc phiếu thu chỉ được lưu trữ, không xóa vĩnh viễn.";
        bannerArchiveNote.Name = "bannerArchiveNote";
        bannerArchiveNote.Size = new System.Drawing.Size(1075, 38);
        bannerArchiveNote.TabIndex = 7;
        bannerArchiveNote.Title = "Quy tắc kiểm toán:";
        bannerArchiveNote.Variant = ECMS.UI.Controls.BannerVariant.Warning;
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
        lblPagingInfo.Size = new System.Drawing.Size(200, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 348 học viên đang học";
        // 
        // dgvStudents
        // 
        dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvStudents.Location = new System.Drawing.Point(20, 95);
        dgvStudents.Name = "dgvStudents";
        dgvStudents.Size = new System.Drawing.Size(1075, 375);
        dgvStudents.TabIndex = 4;
        // 
        // cboClassFilter
        // 
        cboClassFilter.BackColor = System.Drawing.Color.White;
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboClassFilter.Location = new System.Drawing.Point(490, 50);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(160, 32);
        cboClassFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.White;
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboStatusFilter.Location = new System.Drawing.Point(315, 50);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(160, 32);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearchStudent
        // 
        txtSearchStudent.BackColor = System.Drawing.Color.Transparent;
        txtSearchStudent.CornerRadius = 6;
        txtSearchStudent.ErrorMessage = "";
        txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearchStudent.HasError = false;
        txtSearchStudent.Location = new System.Drawing.Point(20, 50);
        txtSearchStudent.Name = "txtSearchStudent";
        txtSearchStudent.Placeholder = "🔍  Tìm mã, họ tên, điện thoại...";
        txtSearchStudent.ReadOnly = false;
        txtSearchStudent.Size = new System.Drawing.Size(280, 32);
        txtSearchStudent.TabIndex = 1;
        txtSearchStudent.UseSystemPasswordChar = false;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.AutoSize = true;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblStudentListTitle.Location = new System.Drawing.Point(20, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(201, 28);
        lblStudentListTitle.TabIndex = 0;
        lblStudentListTitle.Text = "Danh sách học viên";
        // 
        // StudentManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "StudentManagementView";
        Size = new System.Drawing.Size(1160, 800);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardStatArchived.ResumeLayout(false);
        cardStatArchived.PerformLayout();
        cardStatCompleted.ResumeLayout(false);
        cardStatCompleted.PerformLayout();
        cardStatStudying.ResumeLayout(false);
        cardStatStudying.PerformLayout();
        cardStatTotal.ResumeLayout(false);
        cardStatTotal.PerformLayout();
        cardStudentList.ResumeLayout(false);
        cardStudentList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private ECMS.UI.Controls.AppButton btnExport;
    private ECMS.UI.Controls.AppButton btnAddStudent;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStatTotal;
    private System.Windows.Forms.Label lblStatTotalTitle;
    private System.Windows.Forms.Label lblStatTotalValue;
    private ECMS.UI.Controls.AppCard cardStatStudying;
    private System.Windows.Forms.Label lblStatStudyingTitle;
    private System.Windows.Forms.Label lblStatStudyingValue;
    private ECMS.UI.Controls.AppCard cardStatCompleted;
    private System.Windows.Forms.Label lblStatCompletedTitle;
    private System.Windows.Forms.Label lblStatCompletedValue;
    private ECMS.UI.Controls.AppCard cardStatArchived;
    private System.Windows.Forms.Label lblStatArchivedTitle;
    private System.Windows.Forms.Label lblStatArchivedValue;

    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchStudent;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private ECMS.UI.Controls.AppDataGrid dgvStudents;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppBanner bannerArchiveNote;
}
