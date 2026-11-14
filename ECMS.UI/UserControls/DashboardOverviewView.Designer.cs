namespace ECMS.UI.UserControls;

partial class DashboardOverviewView
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _pnlContentWrapper = new System.Windows.Forms.Panel();
        _lblBreadcrumb = new System.Windows.Forms.Label();
        _lblTitle = new System.Windows.Forms.Label();
        _lblSubtitle = new System.Windows.Forms.Label();
        _btnExport = new ECMS.UI.Controls.AppButton();
        _txtSearch = new ECMS.UI.Controls.AppTextBox();
        _cboMonth = new ECMS.UI.Controls.AppComboBox();
        _cboCourse = new ECMS.UI.Controls.AppComboBox();
        _cardRevenue = new ECMS.UI.Controls.AppCard();
        _chartRevenue = new ECMS.UI.Controls.MiniBarChart();
        _cardStudents = new ECMS.UI.Controls.AppCard();
        _chartStudents = new ECMS.UI.Controls.MiniBarChart();
        _cardAttendance = new ECMS.UI.Controls.AppCard();
        _lblAttTitle = new System.Windows.Forms.Label();
        _lblAttPercent = new System.Windows.Forms.Label();
        _lblAttSub = new System.Windows.Forms.Label();
        _dgvRatio = new ECMS.UI.Controls.AppDataGrid();
        _cardSchedule = new ECMS.UI.Controls.AppCard();
        _lblSchedTitle = new System.Windows.Forms.Label();
        _dgvSchedule = new ECMS.UI.Controls.AppDataGrid();
        _lblSchedFooter = new System.Windows.Forms.Label();
        _cardPending = new ECMS.UI.Controls.AppCard();
        _lblPendingTitle = new System.Windows.Forms.Label();
        _dgvPending = new ECMS.UI.Controls.AppDataGrid();
        _lblPendingFooter = new System.Windows.Forms.Label();
        _pnlContentWrapper.SuspendLayout();
        _cardRevenue.SuspendLayout();
        _cardStudents.SuspendLayout();
        _cardAttendance.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvRatio).BeginInit();
        _cardSchedule.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvSchedule).BeginInit();
        _cardPending.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvPending).BeginInit();
        SuspendLayout();
        // 
        // _pnlContentWrapper
        // 
        _pnlContentWrapper.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        _pnlContentWrapper.Controls.Add(_lblBreadcrumb);
        _pnlContentWrapper.Controls.Add(_lblTitle);
        _pnlContentWrapper.Controls.Add(_lblSubtitle);
        _pnlContentWrapper.Controls.Add(_btnExport);
        _pnlContentWrapper.Controls.Add(_txtSearch);
        _pnlContentWrapper.Controls.Add(_cboMonth);
        _pnlContentWrapper.Controls.Add(_cboCourse);
        _pnlContentWrapper.Controls.Add(_cardRevenue);
        _pnlContentWrapper.Controls.Add(_cardStudents);
        _pnlContentWrapper.Controls.Add(_cardAttendance);
        _pnlContentWrapper.Controls.Add(_cardSchedule);
        _pnlContentWrapper.Controls.Add(_cardPending);
        _pnlContentWrapper.Location = new System.Drawing.Point(0, 0);
        _pnlContentWrapper.Name = "_pnlContentWrapper";
        _pnlContentWrapper.Size = new System.Drawing.Size(1200, 840);
        _pnlContentWrapper.TabIndex = 0;
        // 
        // _lblBreadcrumb
        // 
        _lblBreadcrumb.AutoSize = true;
        _lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblBreadcrumb.Location = new System.Drawing.Point(24, 16);
        _lblBreadcrumb.Name = "_lblBreadcrumb";
        _lblBreadcrumb.Size = new System.Drawing.Size(225, 13);
        _lblBreadcrumb.TabIndex = 0;
        _lblBreadcrumb.Text = "ECMS  /  Tổng quan  /  Tổng quan trung tâm";
        // 
        // _lblTitle
        // 
        _lblTitle.AutoSize = true;
        _lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        _lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblTitle.Location = new System.Drawing.Point(24, 38);
        _lblTitle.Name = "_lblTitle";
        _lblTitle.Size = new System.Drawing.Size(226, 30);
        _lblTitle.TabIndex = 1;
        _lblTitle.Text = "Tổng quan trung tâm";
        // 
        // _lblSubtitle
        // 
        _lblSubtitle.AutoSize = true;
        _lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblSubtitle.Location = new System.Drawing.Point(24, 72);
        _lblSubtitle.Name = "_lblSubtitle";
        _lblSubtitle.Size = new System.Drawing.Size(378, 13);
        _lblSubtitle.TabIndex = 2;
        _lblSubtitle.Text = "Thứ Sáu, 30/10/2026 · Xin chào, Trần Minh Quân · Đăng nhập thành công";
        // 
        // _btnExport
        // 
        _btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnExport.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnExport.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        _btnExport.CornerRadius = 5;
        _btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnExport.FlatAppearance.BorderSize = 0;
        _btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        _btnExport.ForeColor = System.Drawing.Color.White;
        _btnExport.Location = new System.Drawing.Point(1052, 38);
        _btnExport.Name = "_btnExport";
        _btnExport.Size = new System.Drawing.Size(124, 36);
        _btnExport.TabIndex = 3;
        _btnExport.Text = "Xuất báo cáo";
        // 
        // _txtSearch
        // 
        _txtSearch.Location = new System.Drawing.Point(24, 102);
        _txtSearch.Name = "_txtSearch";
        _txtSearch.Placeholder = "🔍  Tìm nhanh học viên, lớp học...";
        _txtSearch.Size = new System.Drawing.Size(270, 36);
        _txtSearch.TabIndex = 4;
        // 
        // _cboMonth
        // 
        _cboMonth.Items.AddRange(new object[] {
            "Tháng 10/2026",
            "Tháng 09/2026",
            "Tháng 08/2026"});
        _cboMonth.Location = new Point(306, 102);
        _cboMonth.Name = "_cboMonth";
        _cboMonth.Size = new Size(136, 36);
        _cboMonth.TabIndex = 5;
        // 
        // _cboCourse
        // 
        _cboCourse.Items.AddRange(new object[] {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS Intensive",
            "TOEIC 500"});
        _cboCourse.Location = new Point(454, 102);
        _cboCourse.Name = "_cboCourse";
        _cboCourse.Size = new Size(150, 36);
        _cboCourse.TabIndex = 6;
        // 
        // _cardRevenue
        // 
        _cardRevenue.BackColor = System.Drawing.Color.White;
        _cardRevenue.Controls.Add(_chartRevenue);
        _cardRevenue.Location = new System.Drawing.Point(24, 262);
        _cardRevenue.Name = "_cardRevenue";
        _cardRevenue.Size = new System.Drawing.Size(400, 230);
        _cardRevenue.TabIndex = 7;
        // 
        // _chartRevenue
        // 
        _chartRevenue.Location = new System.Drawing.Point(16, 46);
        _chartRevenue.Name = "_chartRevenue";
        _chartRevenue.Size = new System.Drawing.Size(368, 172);
        _chartRevenue.TabIndex = 0;
        // 
        // _cardStudents
        // 
        _cardStudents.BackColor = System.Drawing.Color.White;
        _cardStudents.Controls.Add(_chartStudents);
        _cardStudents.Location = new System.Drawing.Point(440, 262);
        _cardStudents.Name = "_cardStudents";
        _cardStudents.Size = new System.Drawing.Size(340, 230);
        _cardStudents.TabIndex = 8;
        // 
        // _chartStudents
        // 
        _chartStudents.Location = new System.Drawing.Point(16, 46);
        _chartStudents.Name = "_chartStudents";
        _chartStudents.Size = new System.Drawing.Size(308, 172);
        _chartStudents.TabIndex = 0;
        // 
        // _cardAttendance
        // 
        _cardAttendance.BackColor = System.Drawing.Color.White;
        _cardAttendance.Controls.Add(_dgvRatio);
        _cardAttendance.Controls.Add(_lblAttSub);
        _cardAttendance.Controls.Add(_lblAttPercent);
        _cardAttendance.Controls.Add(_lblAttTitle);
        _cardAttendance.Location = new System.Drawing.Point(796, 262);
        _cardAttendance.Name = "_cardAttendance";
        _cardAttendance.Size = new System.Drawing.Size(380, 230);
        _cardAttendance.TabIndex = 9;
        // 
        // _lblAttTitle
        // 
        _lblAttTitle.AutoSize = true;
        _lblAttTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblAttTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblAttTitle.Location = new System.Drawing.Point(16, 14);
        _lblAttTitle.Name = "_lblAttTitle";
        _lblAttTitle.Size = new System.Drawing.Size(155, 19);
        _lblAttTitle.TabIndex = 0;
        _lblAttTitle.Text = "Chuyên cần & lớp học";
        // 
        // _lblAttPercent
        // 
        _lblAttPercent.AutoSize = true;
        _lblAttPercent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblAttPercent.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _lblAttPercent.Location = new System.Drawing.Point(14, 40);
        _lblAttPercent.Name = "_lblAttPercent";
        _lblAttPercent.Size = new System.Drawing.Size(86, 32);
        _lblAttPercent.TabIndex = 1;
        _lblAttPercent.Text = "92,4%";
        // 
        // _lblAttSub
        // 
        _lblAttSub.AutoSize = true;
        _lblAttSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblAttSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblAttSub.Location = new System.Drawing.Point(125, 48);
        _lblAttSub.Name = "_lblAttSub";
        _lblAttSub.Size = new System.Drawing.Size(117, 13);
        _lblAttSub.TabIndex = 2;
        _lblAttSub.Text = "Có mặt / buổi đã học";
        // 
        // _dgvRatio
        // 
        _dgvRatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvRatio.Location = new System.Drawing.Point(14, 78);
        _dgvRatio.Name = "_dgvRatio";
        _dgvRatio.Size = new System.Drawing.Size(352, 140);
        _dgvRatio.TabIndex = 3;
        // 
        // _cardSchedule
        // 
        _cardSchedule.BackColor = System.Drawing.Color.White;
        _cardSchedule.Controls.Add(_lblSchedFooter);
        _cardSchedule.Controls.Add(_dgvSchedule);
        _cardSchedule.Controls.Add(_lblSchedTitle);
        _cardSchedule.Location = new System.Drawing.Point(24, 508);
        _cardSchedule.Name = "_cardSchedule";
        _cardSchedule.Size = new System.Drawing.Size(650, 230);
        _cardSchedule.TabIndex = 10;
        // 
        // _lblSchedTitle
        // 
        _lblSchedTitle.AutoSize = true;
        _lblSchedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblSchedTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblSchedTitle.Location = new System.Drawing.Point(16, 14);
        _lblSchedTitle.Name = "_lblSchedTitle";
        _lblSchedTitle.Size = new System.Drawing.Size(206, 19);
        _lblSchedTitle.TabIndex = 0;
        _lblSchedTitle.Text = "Lịch hôm nay & sắp khai giảng";
        // 
        // _dgvSchedule
        // 
        _dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvSchedule.Location = new System.Drawing.Point(14, 44);
        _dgvSchedule.Name = "_dgvSchedule";
        _dgvSchedule.Size = new System.Drawing.Size(622, 140);
        _dgvSchedule.TabIndex = 1;
        // 
        // _lblSchedFooter
        // 
        _lblSchedFooter.AutoSize = true;
        _lblSchedFooter.Cursor = System.Windows.Forms.Cursors.Hand;
        _lblSchedFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblSchedFooter.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _lblSchedFooter.Location = new System.Drawing.Point(14, 195);
        _lblSchedFooter.Name = "_lblSchedFooter";
        _lblSchedFooter.Size = new System.Drawing.Size(250, 13);
        _lblSchedFooter.TabIndex = 2;
        _lblSchedFooter.Text = "Mở lịch học tuần → 04.1 · Quản lý lớp → 03.4";
        // 
        // _cardPending
        // 
        _cardPending.BackColor = System.Drawing.Color.White;
        _cardPending.Controls.Add(_lblPendingFooter);
        _cardPending.Controls.Add(_dgvPending);
        _cardPending.Controls.Add(_lblPendingTitle);
        _cardPending.Location = new System.Drawing.Point(690, 508);
        _cardPending.Name = "_cardPending";
        _cardPending.Size = new System.Drawing.Size(486, 230);
        _cardPending.TabIndex = 11;
        // 
        // _lblPendingTitle
        // 
        _lblPendingTitle.AutoSize = true;
        _lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblPendingTitle.Location = new System.Drawing.Point(16, 14);
        _lblPendingTitle.Name = "_lblPendingTitle";
        _lblPendingTitle.Size = new System.Drawing.Size(73, 19);
        _lblPendingTitle.TabIndex = 0;
        _lblPendingTitle.Text = "Cần xử lý";
        // 
        // _dgvPending
        // 
        _dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvPending.Location = new System.Drawing.Point(14, 44);
        _dgvPending.Name = "_dgvPending";
        _dgvPending.Size = new System.Drawing.Size(458, 140);
        _dgvPending.TabIndex = 1;
        // 
        // _lblPendingFooter
        // 
        _lblPendingFooter.AutoSize = true;
        _lblPendingFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblPendingFooter.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        _lblPendingFooter.Location = new System.Drawing.Point(14, 195);
        _lblPendingFooter.Name = "_lblPendingFooter";
        _lblPendingFooter.Size = new System.Drawing.Size(255, 13);
        _lblPendingFooter.TabIndex = 2;
        _lblPendingFooter.Text = "Số dư hiển thị sau giao dịch PT-261030-018.";
        // 
        // DashboardOverviewView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(_pnlContentWrapper);
        Name = "DashboardOverviewView";
        Size = new System.Drawing.Size(1200, 840);
        _pnlContentWrapper.ResumeLayout(false);
        _pnlContentWrapper.PerformLayout();
        _cardRevenue.ResumeLayout(false);
        _cardStudents.ResumeLayout(false);
        _cardAttendance.ResumeLayout(false);
        _cardAttendance.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvRatio).EndInit();
        _cardSchedule.ResumeLayout(false);
        _cardSchedule.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvSchedule).EndInit();
        _cardPending.ResumeLayout(false);
        _cardPending.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvPending).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel _pnlContentWrapper;
    private System.Windows.Forms.Label _lblBreadcrumb;
    private System.Windows.Forms.Label _lblTitle;
    private System.Windows.Forms.Label _lblSubtitle;
    private ECMS.UI.Controls.AppButton _btnExport;
    private ECMS.UI.Controls.AppTextBox _txtSearch;
    private ECMS.UI.Controls.AppComboBox _cboMonth;
    private ECMS.UI.Controls.AppComboBox _cboCourse;
    private ECMS.UI.Controls.AppCard _cardRevenue;
    private ECMS.UI.Controls.MiniBarChart _chartRevenue;
    private ECMS.UI.Controls.AppCard _cardStudents;
    private ECMS.UI.Controls.MiniBarChart _chartStudents;
    private ECMS.UI.Controls.AppCard _cardAttendance;
    private System.Windows.Forms.Label _lblAttTitle;
    private System.Windows.Forms.Label _lblAttPercent;
    private System.Windows.Forms.Label _lblAttSub;
    private ECMS.UI.Controls.AppDataGrid _dgvRatio;
    private ECMS.UI.Controls.AppCard _cardSchedule;
    private System.Windows.Forms.Label _lblSchedTitle;
    private ECMS.UI.Controls.AppDataGrid _dgvSchedule;
    private System.Windows.Forms.Label _lblSchedFooter;
    private ECMS.UI.Controls.AppCard _cardPending;
    private System.Windows.Forms.Label _lblPendingTitle;
    private ECMS.UI.Controls.AppDataGrid _dgvPending;
    private System.Windows.Forms.Label _lblPendingFooter;
}
