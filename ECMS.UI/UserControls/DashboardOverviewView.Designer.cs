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
        _lblTitle = new System.Windows.Forms.Label();
        _btnPendingTasks = new ECMS.UI.Controls.AppButton();
        _btnExport = new ECMS.UI.Controls.AppButton();
        _pnlFilterToolbar = new ECMS.UI.Controls.AppCard();
        _txtSearch = new ECMS.UI.Controls.AppTextBox();
        _btnSearch = new ECMS.UI.Controls.AppButton();
        _cboMonth = new ECMS.UI.Controls.AppComboBox();
        _cboCourse = new ECMS.UI.Controls.AppComboBox();
        _cardKpi1 = new ECMS.UI.Controls.AppCard();
        _lblKpi1Title = new System.Windows.Forms.Label();
        _lblKpi1Value = new System.Windows.Forms.Label();
        _cardKpi2 = new ECMS.UI.Controls.AppCard();
        _lblKpi2Title = new System.Windows.Forms.Label();
        _lblKpi2Value = new System.Windows.Forms.Label();
        _cardKpi3 = new ECMS.UI.Controls.AppCard();
        _lblKpi3Title = new System.Windows.Forms.Label();
        _lblKpi3Value = new System.Windows.Forms.Label();
        _cardKpi4 = new ECMS.UI.Controls.AppCard();
        _lblKpi4Title = new System.Windows.Forms.Label();
        _lblKpi4Value = new System.Windows.Forms.Label();
        _cardKpi5 = new ECMS.UI.Controls.AppCard();
        _lblKpi5Title = new System.Windows.Forms.Label();
        _lblKpi5Value = new System.Windows.Forms.Label();
        _cardKpi6 = new ECMS.UI.Controls.AppCard();
        _lblKpi6Title = new System.Windows.Forms.Label();
        _lblKpi6Value = new System.Windows.Forms.Label();
        _cardRevenue = new ECMS.UI.Controls.AppCard();
        _lblRevenueTitle = new System.Windows.Forms.Label();
        _btnRevenueDetail = new ECMS.UI.Controls.AppButton();
        _chartRevenue = new ECMS.UI.Controls.MiniBarChart();
        _cardStudents = new ECMS.UI.Controls.AppCard();
        _lblStudentsTitle = new System.Windows.Forms.Label();
        _btnStudentsDetail = new ECMS.UI.Controls.AppButton();
        _chartStudents = new ECMS.UI.Controls.MiniBarChart();
        _cardAttendance = new ECMS.UI.Controls.AppCard();
        _lblAttTitle = new System.Windows.Forms.Label();
        _btnAttDetail = new ECMS.UI.Controls.AppButton();
        _lblAttPercent = new System.Windows.Forms.Label();
        _lblAttSub = new System.Windows.Forms.Label();
        _dgvRatio = new ECMS.UI.Controls.AppDataGrid();
        _cardSchedule = new ECMS.UI.Controls.AppCard();
        _lblSchedTitle = new System.Windows.Forms.Label();
        _btnSchedDetail = new ECMS.UI.Controls.AppButton();
        _dgvSchedule = new ECMS.UI.Controls.AppDataGrid();
        _pnlContentWrapper.SuspendLayout();
        _pnlFilterToolbar.SuspendLayout();
        _cardKpi1.SuspendLayout();
        _cardKpi2.SuspendLayout();
        _cardKpi3.SuspendLayout();
        _cardKpi4.SuspendLayout();
        _cardKpi5.SuspendLayout();
        _cardKpi6.SuspendLayout();
        _cardRevenue.SuspendLayout();
        _cardStudents.SuspendLayout();
        _cardAttendance.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvRatio).BeginInit();
        _cardSchedule.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvSchedule).BeginInit();
        SuspendLayout();
        // 
        // _pnlContentWrapper
        // 
        _pnlContentWrapper.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        _pnlContentWrapper.Controls.Add(_lblTitle);
        _pnlContentWrapper.Controls.Add(_btnPendingTasks);
        _pnlContentWrapper.Controls.Add(_btnExport);
        _pnlContentWrapper.Controls.Add(_pnlFilterToolbar);
        _pnlContentWrapper.Controls.Add(_cardKpi1);
        _pnlContentWrapper.Controls.Add(_cardKpi2);
        _pnlContentWrapper.Controls.Add(_cardKpi3);
        _pnlContentWrapper.Controls.Add(_cardKpi4);
        _pnlContentWrapper.Controls.Add(_cardKpi5);
        _pnlContentWrapper.Controls.Add(_cardKpi6);
        _pnlContentWrapper.Controls.Add(_cardRevenue);
        _pnlContentWrapper.Controls.Add(_cardStudents);
        _pnlContentWrapper.Controls.Add(_cardAttendance);
        _pnlContentWrapper.Controls.Add(_cardSchedule);
        _pnlContentWrapper.Location = new System.Drawing.Point(0, 0);
        _pnlContentWrapper.Name = "_pnlContentWrapper";
        _pnlContentWrapper.Size = new System.Drawing.Size(1200, 840);
        _pnlContentWrapper.TabIndex = 0;
        // 
        // _lblTitle
        // 
        _lblTitle.AutoSize = true;
        _lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        _lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblTitle.Location = new System.Drawing.Point(24, 34);
        _lblTitle.Name = "_lblTitle";
        _lblTitle.Size = new System.Drawing.Size(232, 30);
        _lblTitle.TabIndex = 0;
        _lblTitle.Text = "Tổng quan trung tâm";
        // 
        // _btnPendingTasks
        // 
        _btnPendingTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnPendingTasks.BackColor = System.Drawing.Color.White;
        _btnPendingTasks.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnPendingTasks.CornerRadius = 5;
        _btnPendingTasks.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnPendingTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnPendingTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        _btnPendingTasks.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
        _btnPendingTasks.Location = new System.Drawing.Point(852, 34);
        _btnPendingTasks.Name = "_btnPendingTasks";
        _btnPendingTasks.Size = new System.Drawing.Size(188, 36);
        _btnPendingTasks.TabIndex = 1;
        _btnPendingTasks.Text = "⚠️ Danh sách cần xử lý (6)";
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
        _btnExport.Location = new System.Drawing.Point(1052, 34);
        _btnExport.Name = "_btnExport";
        _btnExport.Size = new System.Drawing.Size(124, 36);
        _btnExport.TabIndex = 2;
        _btnExport.Text = "Xuất báo cáo";
        // 
        // _pnlFilterToolbar
        // 
        _pnlFilterToolbar.BackColor = System.Drawing.Color.White;
        _pnlFilterToolbar.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _pnlFilterToolbar.BorderWidth = 1;
        _pnlFilterToolbar.Controls.Add(_txtSearch);
        _pnlFilterToolbar.Controls.Add(_btnSearch);
        _pnlFilterToolbar.Controls.Add(_cboMonth);
        _pnlFilterToolbar.Controls.Add(_cboCourse);
        _pnlFilterToolbar.Location = new System.Drawing.Point(24, 88);
        _pnlFilterToolbar.Name = "_pnlFilterToolbar";
        _pnlFilterToolbar.Size = new System.Drawing.Size(1152, 50);
        _pnlFilterToolbar.TabIndex = 3;
        // 
        // _txtSearch
        // 
        _txtSearch.Location = new System.Drawing.Point(12, 8);
        _txtSearch.Name = "_txtSearch";
        _txtSearch.Placeholder = "🔍  Tìm nhanh học viên, lớp học, khóa học...";
        _txtSearch.Size = new System.Drawing.Size(360, 34);
        _txtSearch.TabIndex = 0;
        // 
        // _btnSearch
        // 
        _btnSearch.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnSearch.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        _btnSearch.CornerRadius = 5;
        _btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnSearch.FlatAppearance.BorderSize = 0;
        _btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        _btnSearch.ForeColor = System.Drawing.Color.White;
        _btnSearch.Location = new System.Drawing.Point(380, 8);
        _btnSearch.Name = "_btnSearch";
        _btnSearch.Size = new System.Drawing.Size(90, 34);
        _btnSearch.TabIndex = 1;
        _btnSearch.Text = "Tìm kiếm";
        // 
        // _cboMonth
        // 
        _cboMonth.Items.AddRange(new object[] {
            "Tháng 10/2026",
            "Tháng 09/2026",
            "Tháng 08/2026",
            "Tất cả các tháng"});
        _cboMonth.Location = new System.Drawing.Point(480, 8);
        _cboMonth.Name = "_cboMonth";
        _cboMonth.Size = new System.Drawing.Size(150, 34);
        _cboMonth.TabIndex = 2;
        // 
        // _cboCourse
        // 
        _cboCourse.Items.AddRange(new object[] {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS Intensive",
            "TOEIC 500+",
            "Giao tiếp quốc tế"});
        _cboCourse.Location = new System.Drawing.Point(640, 8);
        _cboCourse.Name = "_cboCourse";
        _cboCourse.Size = new System.Drawing.Size(180, 34);
        _cboCourse.TabIndex = 3;
        // 
        // _cardKpi1
        // 
        _cardKpi1.BackColor = System.Drawing.Color.White;
        _cardKpi1.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi1.BorderWidth = 1;
        _cardKpi1.Controls.Add(_lblKpi1Value);
        _cardKpi1.Controls.Add(_lblKpi1Title);
        _cardKpi1.Location = new System.Drawing.Point(24, 150);
        _cardKpi1.Name = "_cardKpi1";
        _cardKpi1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi1.Size = new System.Drawing.Size(182, 82);
        _cardKpi1.TabIndex = 4;
        // 
        // _lblKpi1Title
        // 
        _lblKpi1Title.AutoSize = true;
        _lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi1Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi1Title.Name = "_lblKpi1Title";
        _lblKpi1Title.Size = new System.Drawing.Size(95, 13);
        _lblKpi1Title.TabIndex = 0;
        _lblKpi1Title.Text = "TỔNG HỌC VIÊN";
        // 
        // _lblKpi1Value
        // 
        _lblKpi1Value.AutoSize = true;
        _lblKpi1Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi1Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi1Value.Name = "_lblKpi1Value";
        _lblKpi1Value.Size = new System.Drawing.Size(56, 32);
        _lblKpi1Value.TabIndex = 1;
        _lblKpi1Value.Text = "428";
        // 
        // _cardKpi2
        // 
        _cardKpi2.BackColor = System.Drawing.Color.White;
        _cardKpi2.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi2.BorderWidth = 1;
        _cardKpi2.Controls.Add(_lblKpi2Value);
        _cardKpi2.Controls.Add(_lblKpi2Title);
        _cardKpi2.Location = new System.Drawing.Point(218, 150);
        _cardKpi2.Name = "_cardKpi2";
        _cardKpi2.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi2.Size = new System.Drawing.Size(182, 82);
        _cardKpi2.TabIndex = 5;
        // 
        // _lblKpi2Title
        // 
        _lblKpi2Title.AutoSize = true;
        _lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi2Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi2Title.Name = "_lblKpi2Title";
        _lblKpi2Title.Size = new System.Drawing.Size(65, 13);
        _lblKpi2Title.TabIndex = 0;
        _lblKpi2Title.Text = "ĐANG HỌC";
        // 
        // _lblKpi2Value
        // 
        _lblKpi2Value.AutoSize = true;
        _lblKpi2Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi2Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi2Value.Name = "_lblKpi2Value";
        _lblKpi2Value.Size = new System.Drawing.Size(56, 32);
        _lblKpi2Value.TabIndex = 1;
        _lblKpi2Value.Text = "348";
        // 
        // _cardKpi3
        // 
        _cardKpi3.BackColor = System.Drawing.Color.White;
        _cardKpi3.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi3.BorderWidth = 1;
        _cardKpi3.Controls.Add(_lblKpi3Value);
        _cardKpi3.Controls.Add(_lblKpi3Title);
        _cardKpi3.Location = new System.Drawing.Point(412, 150);
        _cardKpi3.Name = "_cardKpi3";
        _cardKpi3.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi3.Size = new System.Drawing.Size(182, 82);
        _cardKpi3.TabIndex = 6;
        // 
        // _lblKpi3Title
        // 
        _lblKpi3Title.AutoSize = true;
        _lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi3Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi3Title.Name = "_lblKpi3Title";
        _lblKpi3Title.Size = new System.Drawing.Size(94, 13);
        _lblKpi3Title.TabIndex = 0;
        _lblKpi3Title.Text = "LỚP HOẠT ĐỘNG";
        // 
        // _lblKpi3Value
        // 
        _lblKpi3Value.AutoSize = true;
        _lblKpi3Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi3Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi3Value.Name = "_lblKpi3Value";
        _lblKpi3Value.Size = new System.Drawing.Size(42, 32);
        _lblKpi3Value.TabIndex = 1;
        _lblKpi3Value.Text = "18";
        // 
        // _cardKpi4
        // 
        _cardKpi4.BackColor = System.Drawing.Color.White;
        _cardKpi4.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi4.BorderWidth = 1;
        _cardKpi4.Controls.Add(_lblKpi4Value);
        _cardKpi4.Controls.Add(_lblKpi4Title);
        _cardKpi4.Location = new System.Drawing.Point(606, 150);
        _cardKpi4.Name = "_cardKpi4";
        _cardKpi4.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi4.Size = new System.Drawing.Size(182, 82);
        _cardKpi4.TabIndex = 7;
        // 
        // _lblKpi4Title
        // 
        _lblKpi4Title.AutoSize = true;
        _lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi4Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi4Title.Name = "_lblKpi4Title";
        _lblKpi4Title.Size = new System.Drawing.Size(65, 13);
        _lblKpi4Title.TabIndex = 0;
        _lblKpi4Title.Text = "GIÁO VIÊN";
        // 
        // _lblKpi4Value
        // 
        _lblKpi4Value.AutoSize = true;
        _lblKpi4Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi4Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi4Value.Name = "_lblKpi4Value";
        _lblKpi4Value.Size = new System.Drawing.Size(42, 32);
        _lblKpi4Value.TabIndex = 1;
        _lblKpi4Value.Text = "24";
        // 
        // _cardKpi5
        // 
        _cardKpi5.BackColor = System.Drawing.Color.White;
        _cardKpi5.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi5.BorderWidth = 1;
        _cardKpi5.Controls.Add(_lblKpi5Value);
        _cardKpi5.Controls.Add(_lblKpi5Title);
        _cardKpi5.Location = new System.Drawing.Point(800, 150);
        _cardKpi5.Name = "_cardKpi5";
        _cardKpi5.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi5.Size = new System.Drawing.Size(182, 82);
        _cardKpi5.TabIndex = 8;
        // 
        // _lblKpi5Title
        // 
        _lblKpi5Title.AutoSize = true;
        _lblKpi5Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi5Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi5Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi5Title.Name = "_lblKpi5Title";
        _lblKpi5Title.Size = new System.Drawing.Size(95, 13);
        _lblKpi5Title.TabIndex = 0;
        _lblKpi5Title.Text = "DOANH THU T10";
        // 
        // _lblKpi5Value
        // 
        _lblKpi5Value.AutoSize = true;
        _lblKpi5Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi5Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi5Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi5Value.Name = "_lblKpi5Value";
        _lblKpi5Value.Size = new System.Drawing.Size(107, 32);
        _lblKpi5Value.TabIndex = 1;
        _lblKpi5Value.Text = "186,5 tr";
        // 
        // _cardKpi6
        // 
        _cardKpi6.BackColor = System.Drawing.Color.White;
        _cardKpi6.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardKpi6.BorderWidth = 1;
        _cardKpi6.Controls.Add(_lblKpi6Value);
        _cardKpi6.Controls.Add(_lblKpi6Title);
        _cardKpi6.Location = new System.Drawing.Point(994, 150);
        _cardKpi6.Name = "_cardKpi6";
        _cardKpi6.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi6.Size = new System.Drawing.Size(182, 82);
        _cardKpi6.TabIndex = 9;
        // 
        // _lblKpi6Title
        // 
        _lblKpi6Title.AutoSize = true;
        _lblKpi6Title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular);
        _lblKpi6Title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblKpi6Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi6Title.Name = "_lblKpi6Title";
        _lblKpi6Title.Size = new System.Drawing.Size(89, 13);
        _lblKpi6Title.TabIndex = 0;
        _lblKpi6Title.Text = "CÔNG NỢ TỒN";
        // 
        // _lblKpi6Value
        // 
        _lblKpi6Value.AutoSize = true;
        _lblKpi6Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi6Value.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblKpi6Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi6Value.Name = "_lblKpi6Value";
        _lblKpi6Value.Size = new System.Drawing.Size(93, 32);
        _lblKpi6Value.TabIndex = 1;
        _lblKpi6Value.Text = "42,9 tr";
        // 
        // _cardRevenue
        // 
        _cardRevenue.BackColor = System.Drawing.Color.White;
        _cardRevenue.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardRevenue.BorderWidth = 1;
        _cardRevenue.Controls.Add(_btnRevenueDetail);
        _cardRevenue.Controls.Add(_lblRevenueTitle);
        _cardRevenue.Controls.Add(_chartRevenue);
        _cardRevenue.Location = new System.Drawing.Point(24, 244);
        _cardRevenue.Name = "_cardRevenue";
        _cardRevenue.Size = new System.Drawing.Size(410, 240);
        _cardRevenue.TabIndex = 10;
        // 
        // _lblRevenueTitle
        // 
        _lblRevenueTitle.AutoSize = true;
        _lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblRevenueTitle.Location = new System.Drawing.Point(16, 14);
        _lblRevenueTitle.Name = "_lblRevenueTitle";
        _lblRevenueTitle.Size = new System.Drawing.Size(130, 19);
        _lblRevenueTitle.TabIndex = 0;
        _lblRevenueTitle.Text = "Biểu đồ doanh thu";
        // 
        // _btnRevenueDetail
        // 
        _btnRevenueDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnRevenueDetail.BackColor = System.Drawing.Color.White;
        _btnRevenueDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnRevenueDetail.CornerRadius = 4;
        _btnRevenueDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnRevenueDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnRevenueDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnRevenueDetail.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnRevenueDetail.Location = new System.Drawing.Point(294, 10);
        _btnRevenueDetail.Name = "_btnRevenueDetail";
        _btnRevenueDetail.Size = new System.Drawing.Size(102, 28);
        _btnRevenueDetail.TabIndex = 1;
        _btnRevenueDetail.Text = "Xem chi tiết";
        // 
        // _chartRevenue
        // 
        _chartRevenue.BackColor = System.Drawing.Color.White;
        _chartRevenue.Location = new System.Drawing.Point(14, 46);
        _chartRevenue.Name = "_chartRevenue";
        _chartRevenue.Size = new System.Drawing.Size(382, 180);
        _chartRevenue.TabIndex = 2;
        // 
        // _cardStudents
        // 
        _cardStudents.BackColor = System.Drawing.Color.White;
        _cardStudents.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardStudents.BorderWidth = 1;
        _cardStudents.Controls.Add(_btnStudentsDetail);
        _cardStudents.Controls.Add(_lblStudentsTitle);
        _cardStudents.Controls.Add(_chartStudents);
        _cardStudents.Location = new System.Drawing.Point(448, 244);
        _cardStudents.Name = "_cardStudents";
        _cardStudents.Size = new System.Drawing.Size(350, 240);
        _cardStudents.TabIndex = 11;
        // 
        // _lblStudentsTitle
        // 
        _lblStudentsTitle.AutoSize = true;
        _lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblStudentsTitle.Location = new System.Drawing.Point(16, 14);
        _lblStudentsTitle.Name = "_lblStudentsTitle";
        _lblStudentsTitle.Size = new System.Drawing.Size(199, 19);
        _lblStudentsTitle.TabIndex = 0;
        _lblStudentsTitle.Text = "Biểu đồ tăng trưởng học viên";
        // 
        // _btnStudentsDetail
        // 
        _btnStudentsDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnStudentsDetail.BackColor = System.Drawing.Color.White;
        _btnStudentsDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnStudentsDetail.CornerRadius = 4;
        _btnStudentsDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnStudentsDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnStudentsDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnStudentsDetail.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnStudentsDetail.Location = new System.Drawing.Point(234, 10);
        _btnStudentsDetail.Name = "_btnStudentsDetail";
        _btnStudentsDetail.Size = new System.Drawing.Size(102, 28);
        _btnStudentsDetail.TabIndex = 1;
        _btnStudentsDetail.Text = "Xem chi tiết";
        // 
        // _chartStudents
        // 
        _chartStudents.BackColor = System.Drawing.Color.White;
        _chartStudents.Location = new System.Drawing.Point(14, 46);
        _chartStudents.Name = "_chartStudents";
        _chartStudents.Size = new System.Drawing.Size(322, 180);
        _chartStudents.TabIndex = 2;
        // 
        // _cardAttendance
        // 
        _cardAttendance.BackColor = System.Drawing.Color.White;
        _cardAttendance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardAttendance.BorderWidth = 1;
        _cardAttendance.Controls.Add(_btnAttDetail);
        _cardAttendance.Controls.Add(_dgvRatio);
        _cardAttendance.Controls.Add(_lblAttSub);
        _cardAttendance.Controls.Add(_lblAttPercent);
        _cardAttendance.Controls.Add(_lblAttTitle);
        _cardAttendance.Location = new System.Drawing.Point(812, 244);
        _cardAttendance.Name = "_cardAttendance";
        _cardAttendance.Size = new System.Drawing.Size(364, 240);
        _cardAttendance.TabIndex = 12;
        // 
        // _lblAttTitle
        // 
        _lblAttTitle.AutoSize = true;
        _lblAttTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblAttTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblAttTitle.Location = new System.Drawing.Point(16, 14);
        _lblAttTitle.Name = "_lblAttTitle";
        _lblAttTitle.Size = new System.Drawing.Size(142, 19);
        _lblAttTitle.TabIndex = 0;
        _lblAttTitle.Text = "Chuyên cần lớp học";
        // 
        // _btnAttDetail
        // 
        _btnAttDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnAttDetail.BackColor = System.Drawing.Color.White;
        _btnAttDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnAttDetail.CornerRadius = 4;
        _btnAttDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnAttDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnAttDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnAttDetail.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnAttDetail.Location = new System.Drawing.Point(248, 10);
        _btnAttDetail.Name = "_btnAttDetail";
        _btnAttDetail.Size = new System.Drawing.Size(102, 28);
        _btnAttDetail.TabIndex = 1;
        _btnAttDetail.Text = "Xem chi tiết";
        // 
        // _lblAttPercent
        // 
        _lblAttPercent.AutoSize = true;
        _lblAttPercent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        _lblAttPercent.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _lblAttPercent.Location = new System.Drawing.Point(14, 40);
        _lblAttPercent.Name = "_lblAttPercent";
        _lblAttPercent.Size = new System.Drawing.Size(77, 30);
        _lblAttPercent.TabIndex = 2;
        _lblAttPercent.Text = "92,4%";
        // 
        // _lblAttSub
        // 
        _lblAttSub.AutoSize = true;
        _lblAttSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblAttSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        _lblAttSub.Location = new System.Drawing.Point(100, 50);
        _lblAttSub.Name = "_lblAttSub";
        _lblAttSub.Size = new System.Drawing.Size(117, 13);
        _lblAttSub.TabIndex = 3;
        _lblAttSub.Text = "Có mặt / buổi đã học";
        // 
        // _dgvRatio
        // 
        _dgvRatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvRatio.Location = new System.Drawing.Point(14, 76);
        _dgvRatio.Name = "_dgvRatio";
        _dgvRatio.Size = new System.Drawing.Size(336, 150);
        _dgvRatio.TabIndex = 4;
        // 
        // _cardSchedule
        // 
        _cardSchedule.BackColor = System.Drawing.Color.White;
        _cardSchedule.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        _cardSchedule.BorderWidth = 1;
        _cardSchedule.Controls.Add(_btnSchedDetail);
        _cardSchedule.Controls.Add(_dgvSchedule);
        _cardSchedule.Controls.Add(_lblSchedTitle);
        _cardSchedule.Location = new System.Drawing.Point(24, 496);
        _cardSchedule.Name = "_cardSchedule";
        _cardSchedule.Size = new System.Drawing.Size(1152, 300);
        _cardSchedule.TabIndex = 13;
        // 
        // _lblSchedTitle
        // 
        _lblSchedTitle.AutoSize = true;
        _lblSchedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblSchedTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        _lblSchedTitle.Location = new System.Drawing.Point(16, 14);
        _lblSchedTitle.Name = "_lblSchedTitle";
        _lblSchedTitle.Size = new System.Drawing.Size(252, 19);
        _lblSchedTitle.TabIndex = 0;
        _lblSchedTitle.Text = "Lịch học hôm nay & Sắp khai giảng";
        // 
        // _btnSchedDetail
        // 
        _btnSchedDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        _btnSchedDetail.BackColor = System.Drawing.Color.White;
        _btnSchedDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnSchedDetail.CornerRadius = 4;
        _btnSchedDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnSchedDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnSchedDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnSchedDetail.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        _btnSchedDetail.Location = new System.Drawing.Point(1036, 10);
        _btnSchedDetail.Name = "_btnSchedDetail";
        _btnSchedDetail.Size = new System.Drawing.Size(102, 28);
        _btnSchedDetail.TabIndex = 1;
        _btnSchedDetail.Text = "Xem chi tiết";
        // 
        // _dgvSchedule
        // 
        _dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _dgvSchedule.Location = new System.Drawing.Point(16, 46);
        _dgvSchedule.Name = "_dgvSchedule";
        _dgvSchedule.Size = new System.Drawing.Size(1120, 240);
        _dgvSchedule.TabIndex = 2;
        // 
        // DashboardOverviewView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(_pnlContentWrapper);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "DashboardOverviewView";
        Size = new System.Drawing.Size(1200, 840);
        _pnlContentWrapper.ResumeLayout(false);
        _pnlContentWrapper.PerformLayout();
        _pnlFilterToolbar.ResumeLayout(false);
        _cardKpi1.ResumeLayout(false);
        _cardKpi1.PerformLayout();
        _cardKpi2.ResumeLayout(false);
        _cardKpi2.PerformLayout();
        _cardKpi3.ResumeLayout(false);
        _cardKpi3.PerformLayout();
        _cardKpi4.ResumeLayout(false);
        _cardKpi4.PerformLayout();
        _cardKpi5.ResumeLayout(false);
        _cardKpi5.PerformLayout();
        _cardKpi6.ResumeLayout(false);
        _cardKpi6.PerformLayout();
        _cardRevenue.ResumeLayout(false);
        _cardRevenue.PerformLayout();
        _cardStudents.ResumeLayout(false);
        _cardStudents.PerformLayout();
        _cardAttendance.ResumeLayout(false);
        _cardAttendance.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvRatio).EndInit();
        _cardSchedule.ResumeLayout(false);
        _cardSchedule.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dgvSchedule).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel _pnlContentWrapper;
    private System.Windows.Forms.Label _lblTitle;
    private ECMS.UI.Controls.AppButton _btnPendingTasks;
    private ECMS.UI.Controls.AppButton _btnExport;
    private ECMS.UI.Controls.AppCard _pnlFilterToolbar;
    private ECMS.UI.Controls.AppTextBox _txtSearch;
    private ECMS.UI.Controls.AppButton _btnSearch;
    private ECMS.UI.Controls.AppComboBox _cboMonth;
    private ECMS.UI.Controls.AppComboBox _cboCourse;
    private ECMS.UI.Controls.AppCard _cardKpi1;
    private System.Windows.Forms.Label _lblKpi1Title;
    private System.Windows.Forms.Label _lblKpi1Value;
    private ECMS.UI.Controls.AppCard _cardKpi2;
    private System.Windows.Forms.Label _lblKpi2Title;
    private System.Windows.Forms.Label _lblKpi2Value;
    private ECMS.UI.Controls.AppCard _cardKpi3;
    private System.Windows.Forms.Label _lblKpi3Title;
    private System.Windows.Forms.Label _lblKpi3Value;
    private ECMS.UI.Controls.AppCard _cardKpi4;
    private System.Windows.Forms.Label _lblKpi4Title;
    private System.Windows.Forms.Label _lblKpi4Value;
    private ECMS.UI.Controls.AppCard _cardKpi5;
    private System.Windows.Forms.Label _lblKpi5Title;
    private System.Windows.Forms.Label _lblKpi5Value;
    private ECMS.UI.Controls.AppCard _cardKpi6;
    private System.Windows.Forms.Label _lblKpi6Title;
    private System.Windows.Forms.Label _lblKpi6Value;
    private ECMS.UI.Controls.AppCard _cardRevenue;
    private System.Windows.Forms.Label _lblRevenueTitle;
    private ECMS.UI.Controls.AppButton _btnRevenueDetail;
    private ECMS.UI.Controls.MiniBarChart _chartRevenue;
    private ECMS.UI.Controls.AppCard _cardStudents;
    private System.Windows.Forms.Label _lblStudentsTitle;
    private ECMS.UI.Controls.AppButton _btnStudentsDetail;
    private ECMS.UI.Controls.MiniBarChart _chartStudents;
    private ECMS.UI.Controls.AppCard _cardAttendance;
    private System.Windows.Forms.Label _lblAttTitle;
    private ECMS.UI.Controls.AppButton _btnAttDetail;
    private System.Windows.Forms.Label _lblAttPercent;
    private System.Windows.Forms.Label _lblAttSub;
    private ECMS.UI.Controls.AppDataGrid _dgvRatio;
    private ECMS.UI.Controls.AppCard _cardSchedule;
    private System.Windows.Forms.Label _lblSchedTitle;
    private ECMS.UI.Controls.AppButton _btnSchedDetail;
    private ECMS.UI.Controls.AppDataGrid _dgvSchedule;
}
