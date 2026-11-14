namespace ECMS.UI.UserControls;

partial class StudentGradeReportView
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
        lblUserBadge = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardProgress = new ECMS.UI.Controls.AppCard();
        lblMilestone = new System.Windows.Forms.Label();
        lblTeacherComment = new System.Windows.Forms.Label();
        chartProgress = new ECMS.UI.Controls.MiniBarChart();
        lblProgressTitle = new System.Windows.Forms.Label();
        cardResultDetails = new ECMS.UI.Controls.AppCard();
        lblReadOnlyFootnote = new System.Windows.Forms.Label();
        lblCertificateStatus = new System.Windows.Forms.Label();
        lblFinanceStatus = new System.Windows.Forms.Label();
        lblAttendanceStatus = new System.Windows.Forms.Label();
        dgvResults = new ECMS.UI.Controls.AppDataGrid();
        lblResultTitle = new System.Windows.Forms.Label();
        pnlStats = new System.Windows.Forms.Panel();
        statAverage = new ECMS.UI.Controls.AppStatCard();
        statFinal = new ECMS.UI.Controls.AppStatCard();
        statMidterm = new ECMS.UI.Controls.AppStatCard();
        statRegular = new ECMS.UI.Controls.AppStatCard();
        bannerGradeUpdated = new ECMS.UI.Controls.AppBanner();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardProgress.SuspendLayout();
        cardResultDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
        pnlStats.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblUserBadge);
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
        // lblUserBadge
        // 
        lblUserBadge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblUserBadge.AutoSize = true;
        lblUserBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblUserBadge.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblUserBadge.Location = new System.Drawing.Point(960, 28);
        lblUserBadge.Name = "lblUserBadge";
        lblUserBadge.Size = new System.Drawing.Size(176, 15);
        lblUserBadge.TabIndex = 3;
        lblUserBadge.Text = "GB · Trần Gia Bảo · Học viên";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(24, 49);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(358, 13);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "HV-0204 · IELTS-F02 · IELTS Foundation · Chỉ đọc kết quả của bản thân";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(206, 25);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Sổ điểm · Trần Gia Bảo";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 8);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(288, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Kiểm tra & Điểm số / Sổ điểm · Trần Gia Bảo";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardProgress);
        pnlBody.Controls.Add(cardResultDetails);
        pnlBody.Controls.Add(pnlStats);
        pnlBody.Controls.Add(bannerGradeUpdated);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardProgress
        // 
        cardProgress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardProgress.BackColor = System.Drawing.Color.White;
        cardProgress.Controls.Add(lblMilestone);
        cardProgress.Controls.Add(lblTeacherComment);
        cardProgress.Controls.Add(chartProgress);
        cardProgress.Controls.Add(lblProgressTitle);
        cardProgress.Location = new System.Drawing.Point(720, 185);
        cardProgress.Name = "cardProgress";
        cardProgress.Padding = new System.Windows.Forms.Padding(20);
        cardProgress.Size = new System.Drawing.Size(416, 450);
        cardProgress.TabIndex = 3;
        // 
        // lblMilestone
        // 
        lblMilestone.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblMilestone.AutoSize = true;
        lblMilestone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMilestone.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblMilestone.Location = new System.Drawing.Point(20, 405);
        lblMilestone.Name = "lblMilestone";
        lblMilestone.Size = new System.Drawing.Size(117, 15);
        lblMilestone.TabIndex = 3;
        lblMilestone.Text = "Hoàn tất luồng 06";
        // 
        // lblTeacherComment
        // 
        lblTeacherComment.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        lblTeacherComment.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblTeacherComment.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTeacherComment.Location = new System.Drawing.Point(20, 315);
        lblTeacherComment.Name = "lblTeacherComment";
        lblTeacherComment.Size = new System.Drawing.Size(376, 70);
        lblTeacherComment.TabIndex = 2;
        lblTeacherComment.Text = "Nhận xét của giáo viên: Tiến bộ ổn định; cần duy trì luyện nói theo chủ đề và tăng độ chính xác khi viết.";
        // 
        // chartProgress
        // 
        chartProgress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        chartProgress.BackColor = System.Drawing.Color.White;
        chartProgress.HighlightBarColor = System.Drawing.Color.FromArgb(37, 99, 235);
        chartProgress.Location = new System.Drawing.Point(20, 55);
        chartProgress.Name = "chartProgress";
        chartProgress.NormalBarColor = System.Drawing.Color.FromArgb(147, 197, 253);
        chartProgress.Size = new System.Drawing.Size(376, 245);
        chartProgress.TabIndex = 1;
        chartProgress.Text = "chartProgress";
        // 
        // lblProgressTitle
        // 
        lblProgressTitle.AutoSize = true;
        lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblProgressTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblProgressTitle.Location = new System.Drawing.Point(20, 16);
        lblProgressTitle.Name = "lblProgressTitle";
        lblProgressTitle.Size = new System.Drawing.Size(211, 20);
        lblProgressTitle.TabIndex = 0;
        lblProgressTitle.Text = "Tiến bộ qua các bài đánh giá";
        // 
        // cardResultDetails
        // 
        cardResultDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardResultDetails.BackColor = System.Drawing.Color.White;
        cardResultDetails.Controls.Add(lblReadOnlyFootnote);
        cardResultDetails.Controls.Add(lblCertificateStatus);
        cardResultDetails.Controls.Add(lblFinanceStatus);
        cardResultDetails.Controls.Add(lblAttendanceStatus);
        cardResultDetails.Controls.Add(dgvResults);
        cardResultDetails.Controls.Add(lblResultTitle);
        cardResultDetails.Location = new System.Drawing.Point(24, 185);
        cardResultDetails.Name = "cardResultDetails";
        cardResultDetails.Padding = new System.Windows.Forms.Padding(20);
        cardResultDetails.Size = new System.Drawing.Size(676, 450);
        cardResultDetails.TabIndex = 2;
        // 
        // lblReadOnlyFootnote
        // 
        lblReadOnlyFootnote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblReadOnlyFootnote.AutoSize = true;
        lblReadOnlyFootnote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblReadOnlyFootnote.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblReadOnlyFootnote.Location = new System.Drawing.Point(20, 415);
        lblReadOnlyFootnote.Name = "lblReadOnlyFootnote";
        lblReadOnlyFootnote.Size = new System.Drawing.Size(332, 13);
        lblReadOnlyFootnote.TabIndex = 5;
        lblReadOnlyFootnote.Text = "Không có nút sửa hoặc nhập điểm trong không gian học viên.";
        // 
        // lblCertificateStatus
        // 
        lblCertificateStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblCertificateStatus.AutoSize = true;
        lblCertificateStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblCertificateStatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblCertificateStatus.Location = new System.Drawing.Point(20, 380);
        lblCertificateStatus.Name = "lblCertificateStatus";
        lblCertificateStatus.Size = new System.Drawing.Size(325, 15);
        lblCertificateStatus.TabIndex = 4;
        lblCertificateStatus.Text = "Chứng chỉ:  Đạt điều kiện → chờ duyệt cấp ở luồng 08";
        // 
        // lblFinanceStatus
        // 
        lblFinanceStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblFinanceStatus.AutoSize = true;
        lblFinanceStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblFinanceStatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblFinanceStatus.Location = new System.Drawing.Point(20, 350);
        lblFinanceStatus.Name = "lblFinanceStatus";
        lblFinanceStatus.Size = new System.Drawing.Size(262, 15);
        lblFinanceStatus.TabIndex = 3;
        lblFinanceStatus.Text = "Tài chính:  Đã hoàn tất học phí · Còn nợ 0đ";
        // 
        // lblAttendanceStatus
        // 
        lblAttendanceStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblAttendanceStatus.AutoSize = true;
        lblAttendanceStatus.Font = new System.Drawing.Font("Segoe UI", 8.75F);
        lblAttendanceStatus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblAttendanceStatus.Location = new System.Drawing.Point(20, 320);
        lblAttendanceStatus.Name = "lblAttendanceStatus";
        lblAttendanceStatus.Size = new System.Drawing.Size(235, 15);
        lblAttendanceStatus.TabIndex = 2;
        lblAttendanceStatus.Text = "Chuyên cần:  22 / 24 buổi · 91,7%";
        // 
        // dgvResults
        // 
        dgvResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvResults.BackgroundColor = System.Drawing.Color.White;
        dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvResults.Location = new System.Drawing.Point(20, 50);
        dgvResults.Name = "dgvResults";
        dgvResults.Size = new System.Drawing.Size(636, 250);
        dgvResults.TabIndex = 1;
        // 
        // lblResultTitle
        // 
        lblResultTitle.AutoSize = true;
        lblResultTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblResultTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblResultTitle.Location = new System.Drawing.Point(20, 16);
        lblResultTitle.Name = "lblResultTitle";
        lblResultTitle.Size = new System.Drawing.Size(126, 20);
        lblResultTitle.TabIndex = 0;
        lblResultTitle.Text = "Chi tiết kết quả";
        // 
        // pnlStats
        // 
        pnlStats.Controls.Add(statAverage);
        pnlStats.Controls.Add(statFinal);
        pnlStats.Controls.Add(statMidterm);
        pnlStats.Controls.Add(statRegular);
        pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStats.Location = new System.Drawing.Point(24, 85);
        pnlStats.Name = "pnlStats";
        pnlStats.Size = new System.Drawing.Size(1112, 85);
        pnlStats.TabIndex = 1;
        // 
        // statAverage
        // 
        statAverage.BackColor = System.Drawing.Color.White;
        statAverage.Location = new System.Drawing.Point(834, 0);
        statAverage.Name = "statAverage";
        statAverage.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statAverage.Size = new System.Drawing.Size(260, 75);
        statAverage.TabIndex = 3;
        statAverage.Title = "Trung bình";
        statAverage.Value = "7,7";
        // 
        // statFinal
        // 
        statFinal.BackColor = System.Drawing.Color.White;
        statFinal.Location = new System.Drawing.Point(556, 0);
        statFinal.Name = "statFinal";
        statFinal.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statFinal.Size = new System.Drawing.Size(260, 75);
        statFinal.TabIndex = 2;
        statFinal.Title = "Cuối khóa · 50%";
        statFinal.Value = "8,0";
        // 
        // statMidterm
        // 
        statMidterm.BackColor = System.Drawing.Color.White;
        statMidterm.Location = new System.Drawing.Point(278, 0);
        statMidterm.Name = "statMidterm";
        statMidterm.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statMidterm.Size = new System.Drawing.Size(260, 75);
        statMidterm.TabIndex = 1;
        statMidterm.Title = "Giữa khóa · 30%";
        statMidterm.Value = "7,5";
        // 
        // statRegular
        // 
        statRegular.BackColor = System.Drawing.Color.White;
        statRegular.Location = new System.Drawing.Point(0, 0);
        statRegular.Name = "statRegular";
        statRegular.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statRegular.Size = new System.Drawing.Size(260, 75);
        statRegular.TabIndex = 0;
        statRegular.Title = "Thường xuyên · 20%";
        statRegular.Value = "7,0";
        // 
        // bannerGradeUpdated
        // 
        bannerGradeUpdated.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerGradeUpdated.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerGradeUpdated.Location = new System.Drawing.Point(24, 20);
        bannerGradeUpdated.Message = "Trung bình 7,65 → 7,7 / 10 · Khá · Đạt.";
        bannerGradeUpdated.Name = "bannerGradeUpdated";
        bannerGradeUpdated.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerGradeUpdated.Size = new System.Drawing.Size(1112, 55);
        bannerGradeUpdated.TabIndex = 0;
        bannerGradeUpdated.Title = "✓ Giáo viên đã sửa điểm cuối khóa thành 8,0 và lưu.";
        bannerGradeUpdated.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // StudentGradeReportView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "StudentGradeReportView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardProgress.ResumeLayout(false);
        cardProgress.PerformLayout();
        cardResultDetails.ResumeLayout(false);
        cardResultDetails.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
        pnlStats.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblUserBadge;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppBanner bannerGradeUpdated;
    private System.Windows.Forms.Panel pnlStats;
    private ECMS.UI.Controls.AppStatCard statRegular;
    private ECMS.UI.Controls.AppStatCard statMidterm;
    private ECMS.UI.Controls.AppStatCard statFinal;
    private ECMS.UI.Controls.AppStatCard statAverage;
    private ECMS.UI.Controls.AppCard cardResultDetails;
    private System.Windows.Forms.Label lblResultTitle;
    private ECMS.UI.Controls.AppDataGrid dgvResults;
    private System.Windows.Forms.Label lblAttendanceStatus;
    private System.Windows.Forms.Label lblFinanceStatus;
    private System.Windows.Forms.Label lblCertificateStatus;
    private System.Windows.Forms.Label lblReadOnlyFootnote;
    private ECMS.UI.Controls.AppCard cardProgress;
    private System.Windows.Forms.Label lblProgressTitle;
    private ECMS.UI.Controls.MiniBarChart chartProgress;
    private System.Windows.Forms.Label lblTeacherComment;
    private System.Windows.Forms.Label lblMilestone;
}
