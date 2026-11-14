namespace ECMS.UI.UserControls;

partial class ReportManagementView
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

    private void InitializeComponent()
    {
        pnlMain = new System.Windows.Forms.Panel();
        pnlHeader = new System.Windows.Forms.Panel();
        lblBreadcrumb = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnExportLocal = new ECMS.UI.Controls.AppButton();
        btnPreview = new ECMS.UI.Controls.AppButton();

        pnlFilter = new System.Windows.Forms.Panel();
        lblFromDate = new System.Windows.Forms.Label();
        txtFromDate = new ECMS.UI.Controls.AppTextBox();
        lblToDate = new System.Windows.Forms.Label();
        txtToDate = new ECMS.UI.Controls.AppTextBox();
        lblCourseFilter = new System.Windows.Forms.Label();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        lblClassFilter = new System.Windows.Forms.Label();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        btnApply = new ECMS.UI.Controls.AppButton();

        pnlTabs = new System.Windows.Forms.Panel();
        btnTabSummary = new System.Windows.Forms.Button();
        btnTabAttendance = new System.Windows.Forms.Button();
        btnTabGrades = new System.Windows.Forms.Button();
        btnTabFinance = new System.Windows.Forms.Button();

        pnlStats = new System.Windows.Forms.TableLayoutPanel();
        statActiveStudents = new ECMS.UI.Controls.AppStatCard();
        statAttendanceRate = new ECMS.UI.Controls.AppStatCard();
        statFinalScore = new ECMS.UI.Controls.AppStatCard();
        statPassRate = new ECMS.UI.Controls.AppStatCard();
        statRevenue = new ECMS.UI.Controls.AppStatCard();
        statDebt = new ECMS.UI.Controls.AppStatCard();

        pnlChartsRow = new System.Windows.Forms.TableLayoutPanel();
        cardRevenueChart = new ECMS.UI.Controls.AppCard();
        lblRevChartTitle = new System.Windows.Forms.Label();
        lblRevChartSub = new System.Windows.Forms.Label();
        chartWeeklyRevenue = new ECMS.UI.Controls.MiniBarChart();

        cardAttendanceChart = new ECMS.UI.Controls.AppCard();
        lblAttChartTitle = new System.Windows.Forms.Label();
        lblAttChartSub = new System.Windows.Forms.Label();
        chartCourseAttendance = new ECMS.UI.Controls.MiniBarChart();

        cardOfflineHelp = new ECMS.UI.Controls.AppCard();
        lblHelpTitle = new System.Windows.Forms.Label();
        lblHelpSubtitle = new System.Windows.Forms.Label();
        lblHelpStep1 = new System.Windows.Forms.Label();
        lblHelpStep2 = new System.Windows.Forms.Label();
        lblHelpStep3 = new System.Windows.Forms.Label();
        lblHelpLink = new System.Windows.Forms.Label();
        lblHelpNote = new System.Windows.Forms.Label();

        cardGrid = new ECMS.UI.Controls.AppCard();
        lblGridTitle = new System.Windows.Forms.Label();
        gridCourseSummary = new ECMS.UI.Controls.AppDataGrid();
        colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colActiveStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAttRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colMonthRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDebtBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();

        pnlMain.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlStats.SuspendLayout();
        pnlChartsRow.SuspendLayout();
        cardRevenueChart.SuspendLayout();
        cardAttendanceChart.SuspendLayout();
        cardOfflineHelp.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridCourseSummary).BeginInit();
        SuspendLayout();

        // pnlMain
        pnlMain.AutoScroll = true;
        pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        pnlMain.Controls.Add(cardGrid);
        pnlMain.Controls.Add(pnlChartsRow);
        pnlMain.Controls.Add(pnlStats);
        pnlMain.Controls.Add(pnlTabs);
        pnlMain.Controls.Add(pnlFilter);
        pnlMain.Controls.Add(pnlHeader);
        pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMain.Location = new System.Drawing.Point(0, 0);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new System.Windows.Forms.Padding(24, 16, 24, 24);
        pnlMain.Size = new System.Drawing.Size(1200, 950);
        pnlMain.TabIndex = 0;

        // pnlHeader
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1152, 70);
        pnlHeader.TabIndex = 0;

        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblBreadcrumb.Location = new System.Drawing.Point(0, 0);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(262, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Báo cáo & Thống kê / Báo cáo & thống kê";

        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(0, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(248, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Báo cáo & thống kê";

        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new System.Drawing.Point(2, 50);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(232, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Dữ liệu mẫu · Trung tâm Anh ngữ Minh Trí";

        pnlTopActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        pnlTopActions.Controls.Add(btnExportLocal);
        pnlTopActions.Controls.Add(btnPreview);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(852, 12);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;

        btnExportLocal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnExportLocal.Location = new System.Drawing.Point(147, 3);
        btnExportLocal.Name = "btnExportLocal";
        btnExportLocal.Size = new System.Drawing.Size(150, 38);
        btnExportLocal.TabIndex = 0;
        btnExportLocal.Text = "Xuất ra tệp cục bộ";
        btnExportLocal.UseVisualStyleBackColor = true;
        btnExportLocal.Variant = ECMS.UI.Controls.ButtonVariant.Primary;

        btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnPreview.Location = new System.Drawing.Point(31, 3);
        btnPreview.Name = "btnPreview";
        btnPreview.Size = new System.Drawing.Size(110, 38);
        btnPreview.TabIndex = 1;
        btnPreview.Text = "Xem trước";
        btnPreview.UseVisualStyleBackColor = true;
        btnPreview.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;

        // pnlFilter
        pnlFilter.BackColor = System.Drawing.Color.White;
        pnlFilter.Controls.Add(btnApply);
        pnlFilter.Controls.Add(cboClassFilter);
        pnlFilter.Controls.Add(lblClassFilter);
        pnlFilter.Controls.Add(cboCourseFilter);
        pnlFilter.Controls.Add(lblCourseFilter);
        pnlFilter.Controls.Add(txtToDate);
        pnlFilter.Controls.Add(lblToDate);
        pnlFilter.Controls.Add(txtFromDate);
        pnlFilter.Controls.Add(lblFromDate);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(24, 86);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        pnlFilter.Size = new System.Drawing.Size(1152, 58);
        pnlFilter.TabIndex = 1;

        lblFromDate.AutoSize = true;
        lblFromDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblFromDate.Location = new System.Drawing.Point(16, 8);
        lblFromDate.Name = "lblFromDate";
        lblFromDate.Size = new System.Drawing.Size(51, 15);
        lblFromDate.TabIndex = 0;
        lblFromDate.Text = "Từ ngày";

        txtFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtFromDate.Location = new System.Drawing.Point(16, 24);
        txtFromDate.Name = "txtFromDate";
        txtFromDate.Size = new System.Drawing.Size(160, 30);
        txtFromDate.TabIndex = 1;
        txtFromDate.Text = "01/10/2026";

        lblToDate.AutoSize = true;
        lblToDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblToDate.Location = new System.Drawing.Point(190, 8);
        lblToDate.Name = "lblToDate";
        lblToDate.Size = new System.Drawing.Size(58, 15);
        lblToDate.TabIndex = 2;
        lblToDate.Text = "Đến ngày";

        txtToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtToDate.Location = new System.Drawing.Point(190, 24);
        txtToDate.Name = "txtToDate";
        txtToDate.Size = new System.Drawing.Size(160, 30);
        txtToDate.TabIndex = 3;
        txtToDate.Text = "30/10/2026";

        lblCourseFilter.AutoSize = true;
        lblCourseFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblCourseFilter.Location = new System.Drawing.Point(365, 8);
        lblCourseFilter.Name = "lblCourseFilter";
        lblCourseFilter.Size = new System.Drawing.Size(57, 15);
        lblCourseFilter.TabIndex = 4;
        lblCourseFilter.Text = "Khóa học";

        cboCourseFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboCourseFilter.Items.AddRange(new object[] { "Tất cả khóa học", "IELTS", "TOEIC", "Giao tiếp" });
        cboCourseFilter.Location = new System.Drawing.Point(365, 24);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(200, 30);
        cboCourseFilter.TabIndex = 5;

        lblClassFilter.AutoSize = true;
        lblClassFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblClassFilter.Location = new System.Drawing.Point(580, 8);
        lblClassFilter.Name = "lblClassFilter";
        lblClassFilter.Size = new System.Drawing.Size(50, 15);
        lblClassFilter.TabIndex = 6;
        lblClassFilter.Text = "Lớp học";

        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboClassFilter.Items.AddRange(new object[] { "Tất cả lớp học", "IELTS-F01", "IELTS-F02", "TOEIC-T01" });
        cboClassFilter.Location = new System.Drawing.Point(580, 24);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(200, 30);
        cboClassFilter.TabIndex = 7;

        btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnApply.Location = new System.Drawing.Point(800, 22);
        btnApply.Name = "btnApply";
        btnApply.Size = new System.Drawing.Size(100, 32);
        btnApply.TabIndex = 8;
        btnApply.Text = "Áp dụng";
        btnApply.UseVisualStyleBackColor = true;
        btnApply.Variant = ECMS.UI.Controls.ButtonVariant.Primary;

        // pnlTabs
        pnlTabs.Controls.Add(btnTabFinance);
        pnlTabs.Controls.Add(btnTabGrades);
        pnlTabs.Controls.Add(btnTabAttendance);
        pnlTabs.Controls.Add(btnTabSummary);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(24, 144);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Size = new System.Drawing.Size(1152, 34);
        pnlTabs.TabIndex = 2;

        btnTabSummary.FlatAppearance.BorderSize = 0;
        btnTabSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabSummary.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnTabSummary.Location = new System.Drawing.Point(0, 4);
        btnTabSummary.Name = "btnTabSummary";
        btnTabSummary.Size = new System.Drawing.Size(100, 26);
        btnTabSummary.TabIndex = 0;
        btnTabSummary.Text = "• Tổng hợp";
        btnTabSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabSummary.UseVisualStyleBackColor = true;

        btnTabAttendance.FlatAppearance.BorderSize = 0;
        btnTabAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabAttendance.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnTabAttendance.Location = new System.Drawing.Point(105, 4);
        btnTabAttendance.Name = "btnTabAttendance";
        btnTabAttendance.Size = new System.Drawing.Size(100, 26);
        btnTabAttendance.TabIndex = 1;
        btnTabAttendance.Text = "Chuyên cần";
        btnTabAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabAttendance.UseVisualStyleBackColor = true;

        btnTabGrades.FlatAppearance.BorderSize = 0;
        btnTabGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabGrades.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnTabGrades.Location = new System.Drawing.Point(210, 4);
        btnTabGrades.Name = "btnTabGrades";
        btnTabGrades.Size = new System.Drawing.Size(120, 26);
        btnTabGrades.TabIndex = 2;
        btnTabGrades.Text = "Kết quả học tập";
        btnTabGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabGrades.UseVisualStyleBackColor = true;

        btnTabFinance.FlatAppearance.BorderSize = 0;
        btnTabFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabFinance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabFinance.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnTabFinance.Location = new System.Drawing.Point(335, 4);
        btnTabFinance.Name = "btnTabFinance";
        btnTabFinance.Size = new System.Drawing.Size(90, 26);
        btnTabFinance.TabIndex = 3;
        btnTabFinance.Text = "Tài chính";
        btnTabFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabFinance.UseVisualStyleBackColor = true;

        // pnlStats (6 KPI Stat cards)
        pnlStats.ColumnCount = 6;
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
        pnlStats.Controls.Add(statActiveStudents, 0, 0);
        pnlStats.Controls.Add(statAttendanceRate, 1, 0);
        pnlStats.Controls.Add(statFinalScore, 2, 0);
        pnlStats.Controls.Add(statPassRate, 3, 0);
        pnlStats.Controls.Add(statRevenue, 4, 0);
        pnlStats.Controls.Add(statDebt, 5, 0);
        pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStats.Location = new System.Drawing.Point(24, 178);
        pnlStats.Name = "pnlStats";
        pnlStats.RowCount = 1;
        pnlStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlStats.Size = new System.Drawing.Size(1152, 90);
        pnlStats.TabIndex = 3;

        statActiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
        statActiveStudents.Title = "Học viên đang học";
        statActiveStudents.Location = new System.Drawing.Point(3, 3);
        statActiveStudents.Name = "statActiveStudents";
        statActiveStudents.Size = new System.Drawing.Size(186, 84);
        statActiveStudents.TabIndex = 0;
        statActiveStudents.Value = "348";

        statAttendanceRate.Dock = System.Windows.Forms.DockStyle.Fill;
        statAttendanceRate.Title = "Chuyên cần toàn TT";
        statAttendanceRate.Location = new System.Drawing.Point(195, 3);
        statAttendanceRate.Name = "statAttendanceRate";
        statAttendanceRate.Size = new System.Drawing.Size(186, 84);
        statAttendanceRate.TabIndex = 1;
        statAttendanceRate.Value = "92,4%";

        statFinalScore.Dock = System.Windows.Forms.DockStyle.Fill;
        statFinalScore.Title = "Điểm TB cuối khóa";
        statFinalScore.Location = new System.Drawing.Point(387, 3);
        statFinalScore.Name = "statFinalScore";
        statFinalScore.Size = new System.Drawing.Size(186, 84);
        statFinalScore.TabIndex = 2;
        statFinalScore.Value = "7,3 / 10";

        statPassRate.Dock = System.Windows.Forms.DockStyle.Fill;
        statPassRate.Title = "Tỷ lệ đạt chuẩn";
        statPassRate.Location = new System.Drawing.Point(579, 3);
        statPassRate.Name = "statPassRate";
        statPassRate.Size = new System.Drawing.Size(186, 84);
        statPassRate.TabIndex = 3;
        statPassRate.Value = "84,0%";

        statRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
        statRevenue.Title = "Thực thu tháng";
        statRevenue.Location = new System.Drawing.Point(771, 3);
        statRevenue.Name = "statRevenue";
        statRevenue.Size = new System.Drawing.Size(186, 84);
        statRevenue.TabIndex = 4;
        statRevenue.Value = "186,5 tr";

        statDebt.Dock = System.Windows.Forms.DockStyle.Fill;
        statDebt.Title = "Công nợ hiện tại";
        statDebt.Location = new System.Drawing.Point(963, 3);
        statDebt.Name = "statDebt";
        statDebt.Size = new System.Drawing.Size(186, 84);
        statDebt.TabIndex = 5;
        statDebt.Value = "42,9 tr";

        // pnlChartsRow (TableLayoutPanel: 35% - 35% - 30%)
        pnlChartsRow.ColumnCount = 3;
        pnlChartsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
        pnlChartsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
        pnlChartsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        pnlChartsRow.Controls.Add(cardRevenueChart, 0, 0);
        pnlChartsRow.Controls.Add(cardAttendanceChart, 1, 0);
        pnlChartsRow.Controls.Add(cardOfflineHelp, 2, 0);
        pnlChartsRow.Dock = System.Windows.Forms.DockStyle.Top;
        pnlChartsRow.Location = new System.Drawing.Point(24, 268);
        pnlChartsRow.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
        pnlChartsRow.Name = "pnlChartsRow";
        pnlChartsRow.RowCount = 1;
        pnlChartsRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlChartsRow.Size = new System.Drawing.Size(1152, 230);
        pnlChartsRow.TabIndex = 4;

        // cardRevenueChart
        cardRevenueChart.BackColor = System.Drawing.Color.White;
        cardRevenueChart.Controls.Add(chartWeeklyRevenue);
        cardRevenueChart.Controls.Add(lblRevChartSub);
        cardRevenueChart.Controls.Add(lblRevChartTitle);
        cardRevenueChart.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRevenueChart.Location = new System.Drawing.Point(3, 3);
        cardRevenueChart.Name = "cardRevenueChart";
        cardRevenueChart.Padding = new System.Windows.Forms.Padding(16);
        cardRevenueChart.Size = new System.Drawing.Size(397, 224);
        cardRevenueChart.TabIndex = 0;

        lblRevChartTitle.AutoSize = true;
        lblRevChartTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblRevChartTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblRevChartTitle.Location = new System.Drawing.Point(16, 12);
        lblRevChartTitle.Name = "lblRevChartTitle";
        lblRevChartTitle.Size = new System.Drawing.Size(130, 19);
        lblRevChartTitle.TabIndex = 0;
        lblRevChartTitle.Text = "Thực thu theo tuần";

        lblRevChartSub.AutoSize = true;
        lblRevChartSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblRevChartSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblRevChartSub.Location = new System.Drawing.Point(150, 15);
        lblRevChartSub.Name = "lblRevChartSub";
        lblRevChartSub.Size = new System.Drawing.Size(68, 15);
        lblRevChartSub.TabIndex = 1;
        lblRevChartSub.Text = "Triệu đồng";

        chartWeeklyRevenue.Dock = System.Windows.Forms.DockStyle.Bottom;
        chartWeeklyRevenue.Location = new System.Drawing.Point(16, 45);
        chartWeeklyRevenue.Name = "chartWeeklyRevenue";
        chartWeeklyRevenue.Size = new System.Drawing.Size(365, 163);
        chartWeeklyRevenue.TabIndex = 2;

        // cardAttendanceChart
        cardAttendanceChart.BackColor = System.Drawing.Color.White;
        cardAttendanceChart.Controls.Add(chartCourseAttendance);
        cardAttendanceChart.Controls.Add(lblAttChartSub);
        cardAttendanceChart.Controls.Add(lblAttChartTitle);
        cardAttendanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
        cardAttendanceChart.Location = new System.Drawing.Point(406, 3);
        cardAttendanceChart.Name = "cardAttendanceChart";
        cardAttendanceChart.Padding = new System.Windows.Forms.Padding(16);
        cardAttendanceChart.Size = new System.Drawing.Size(397, 224);
        cardAttendanceChart.TabIndex = 1;

        lblAttChartTitle.AutoSize = true;
        lblAttChartTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblAttChartTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblAttChartTitle.Location = new System.Drawing.Point(16, 12);
        lblAttChartTitle.Name = "lblAttChartTitle";
        lblAttChartTitle.Size = new System.Drawing.Size(193, 19);
        lblAttChartTitle.TabIndex = 0;
        lblAttChartTitle.Text = "Chuyên cần theo nhóm khóa";

        lblAttChartSub.AutoSize = true;
        lblAttChartSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblAttChartSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblAttChartSub.Location = new System.Drawing.Point(215, 15);
        lblAttChartSub.Name = "lblAttChartSub";
        lblAttChartSub.Size = new System.Drawing.Size(17, 15);
        lblAttChartSub.TabIndex = 1;
        lblAttChartSub.Text = "%";

        chartCourseAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
        chartCourseAttendance.Location = new System.Drawing.Point(16, 45);
        chartCourseAttendance.Name = "chartCourseAttendance";
        chartCourseAttendance.Size = new System.Drawing.Size(365, 163);
        chartCourseAttendance.TabIndex = 2;

        // cardOfflineHelp
        cardOfflineHelp.BackColor = System.Drawing.Color.White;
        cardOfflineHelp.Controls.Add(lblHelpNote);
        cardOfflineHelp.Controls.Add(lblHelpLink);
        cardOfflineHelp.Controls.Add(lblHelpStep3);
        cardOfflineHelp.Controls.Add(lblHelpStep2);
        cardOfflineHelp.Controls.Add(lblHelpStep1);
        cardOfflineHelp.Controls.Add(lblHelpSubtitle);
        cardOfflineHelp.Controls.Add(lblHelpTitle);
        cardOfflineHelp.Dock = System.Windows.Forms.DockStyle.Fill;
        cardOfflineHelp.Location = new System.Drawing.Point(809, 3);
        cardOfflineHelp.Name = "cardOfflineHelp";
        cardOfflineHelp.Padding = new System.Windows.Forms.Padding(16);
        cardOfflineHelp.Size = new System.Drawing.Size(340, 224);
        cardOfflineHelp.TabIndex = 2;

        lblHelpTitle.AutoSize = true;
        lblHelpTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblHelpTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblHelpTitle.Location = new System.Drawing.Point(16, 12);
        lblHelpTitle.Name = "lblHelpTitle";
        lblHelpTitle.Size = new System.Drawing.Size(180, 19);
        lblHelpTitle.TabIndex = 0;
        lblHelpTitle.Text = "Trợ giúp ngoại tuyến · F1";

        lblHelpSubtitle.AutoSize = true;
        lblHelpSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblHelpSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblHelpSubtitle.Location = new System.Drawing.Point(16, 38);
        lblHelpSubtitle.Name = "lblHelpSubtitle";
        lblHelpSubtitle.Size = new System.Drawing.Size(134, 15);
        lblHelpSubtitle.TabIndex = 1;
        lblHelpSubtitle.Text = "Cách tạo báo cáo cục bộ:";

        lblHelpStep1.AutoSize = true;
        lblHelpStep1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblHelpStep1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblHelpStep1.Location = new System.Drawing.Point(16, 60);
        lblHelpStep1.Name = "lblHelpStep1";
        lblHelpStep1.Size = new System.Drawing.Size(182, 15);
        lblHelpStep1.TabIndex = 2;
        lblHelpStep1.Text = "1. Chọn khoảng ngày, khóa và lớp.";

        lblHelpStep2.AutoSize = true;
        lblHelpStep2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblHelpStep2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblHelpStep2.Location = new System.Drawing.Point(16, 80);
        lblHelpStep2.Name = "lblHelpStep2";
        lblHelpStep2.Size = new System.Drawing.Size(206, 15);
        lblHelpStep2.TabIndex = 3;
        lblHelpStep2.Text = "2. Áp dụng để tổng hợp dữ liệu SQLite.";

        lblHelpStep3.AutoSize = true;
        lblHelpStep3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblHelpStep3.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblHelpStep3.Location = new System.Drawing.Point(16, 100);
        lblHelpStep3.Name = "lblHelpStep3";
        lblHelpStep3.Size = new System.Drawing.Size(225, 15);
        lblHelpStep3.TabIndex = 4;
        lblHelpStep3.Text = "3. Xem trước, kiểm tra rồi chọn nơi lưu tệp.";

        lblHelpLink.AutoSize = true;
        lblHelpLink.Cursor = System.Windows.Forms.Cursors.Hand;
        lblHelpLink.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Underline);
        lblHelpLink.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblHelpLink.Location = new System.Drawing.Point(16, 130);
        lblHelpLink.Name = "lblHelpLink";
        lblHelpLink.Size = new System.Drawing.Size(167, 15);
        lblHelpLink.TabIndex = 5;
        lblHelpLink.Text = "C:\\ECMS\\HuongDan\\bao-cao.html";

        lblHelpNote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
        lblHelpNote.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        lblHelpNote.Location = new System.Drawing.Point(16, 155);
        lblHelpNote.Name = "lblHelpNote";
        lblHelpNote.Size = new System.Drawing.Size(300, 36);
        lblHelpNote.TabIndex = 6;
        lblHelpNote.Text = "Mở bằng trình duyệt cục bộ, không cần kết nối Internet.";

        // cardGrid (Bảng tổng hợp theo khóa học)
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.Controls.Add(gridCourseSummary);
        cardGrid.Controls.Add(lblGridTitle);
        cardGrid.Dock = System.Windows.Forms.DockStyle.Top;
        cardGrid.Location = new System.Drawing.Point(24, 508);
        cardGrid.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(16);
        cardGrid.Size = new System.Drawing.Size(1152, 230);
        cardGrid.TabIndex = 5;

        lblGridTitle.AutoSize = true;
        lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblGridTitle.Location = new System.Drawing.Point(16, 12);
        lblGridTitle.Name = "lblGridTitle";
        lblGridTitle.Size = new System.Drawing.Size(193, 20);
        lblGridTitle.TabIndex = 0;
        lblGridTitle.Text = "Tổng hợp theo khóa học";

        gridCourseSummary.AllowUserToAddRows = false;
        gridCourseSummary.AllowUserToDeleteRows = false;
        gridCourseSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridCourseSummary.BackgroundColor = System.Drawing.Color.White;
        gridCourseSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridCourseSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridCourseSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colCourseName, colActiveStudents, colAttRate, colMonthRevenue, colDebtBalance
        });
        gridCourseSummary.Dock = System.Windows.Forms.DockStyle.Top;
        gridCourseSummary.Location = new System.Drawing.Point(16, 40);
        gridCourseSummary.Name = "gridCourseSummary";
        gridCourseSummary.ReadOnly = true;
        gridCourseSummary.RowHeadersVisible = false;
        gridCourseSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridCourseSummary.Size = new System.Drawing.Size(1120, 160);
        gridCourseSummary.TabIndex = 1;

        colCourseName.HeaderText = "Khóa học ↑";
        colCourseName.Name = "colCourseName";
        colCourseName.ReadOnly = true;
        colCourseName.FillWeight = 25F;

        colActiveStudents.HeaderText = "HV đang học";
        colActiveStudents.Name = "colActiveStudents";
        colActiveStudents.ReadOnly = true;
        colActiveStudents.FillWeight = 18F;

        colAttRate.HeaderText = "Chuyên cần";
        colAttRate.Name = "colAttRate";
        colAttRate.ReadOnly = true;
        colAttRate.FillWeight = 18F;

        colMonthRevenue.HeaderText = "Thực thu tháng";
        colMonthRevenue.Name = "colMonthRevenue";
        colMonthRevenue.ReadOnly = true;
        colMonthRevenue.FillWeight = 20F;

        colDebtBalance.HeaderText = "Công nợ";
        colDebtBalance.Name = "colDebtBalance";
        colDebtBalance.ReadOnly = true;
        colDebtBalance.FillWeight = 19F;

        // ReportManagementView
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        Controls.Add(pnlMain);
        Name = "ReportManagementView";
        Size = new System.Drawing.Size(1200, 950);

        pnlMain.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlStats.ResumeLayout(false);
        pnlChartsRow.ResumeLayout(false);
        cardRevenueChart.ResumeLayout(false);
        cardRevenueChart.PerformLayout();
        cardAttendanceChart.ResumeLayout(false);
        cardAttendanceChart.PerformLayout();
        cardOfflineHelp.ResumeLayout(false);
        cardOfflineHelp.PerformLayout();
        cardGrid.ResumeLayout(false);
        cardGrid.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridCourseSummary).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnExportLocal;
    private ECMS.UI.Controls.AppButton btnPreview;

    private System.Windows.Forms.Panel pnlFilter;
    private System.Windows.Forms.Label lblFromDate;
    private ECMS.UI.Controls.AppTextBox txtFromDate;
    private System.Windows.Forms.Label lblToDate;
    private ECMS.UI.Controls.AppTextBox txtToDate;
    private System.Windows.Forms.Label lblCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private System.Windows.Forms.Label lblClassFilter;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private ECMS.UI.Controls.AppButton btnApply;

    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabSummary;
    private System.Windows.Forms.Button btnTabAttendance;
    private System.Windows.Forms.Button btnTabGrades;
    private System.Windows.Forms.Button btnTabFinance;

    private System.Windows.Forms.TableLayoutPanel pnlStats;
    private ECMS.UI.Controls.AppStatCard statActiveStudents;
    private ECMS.UI.Controls.AppStatCard statAttendanceRate;
    private ECMS.UI.Controls.AppStatCard statFinalScore;
    private ECMS.UI.Controls.AppStatCard statPassRate;
    private ECMS.UI.Controls.AppStatCard statRevenue;
    private ECMS.UI.Controls.AppStatCard statDebt;

    private System.Windows.Forms.TableLayoutPanel pnlChartsRow;
    private ECMS.UI.Controls.AppCard cardRevenueChart;
    private System.Windows.Forms.Label lblRevChartTitle;
    private System.Windows.Forms.Label lblRevChartSub;
    private ECMS.UI.Controls.MiniBarChart chartWeeklyRevenue;

    private ECMS.UI.Controls.AppCard cardAttendanceChart;
    private System.Windows.Forms.Label lblAttChartTitle;
    private System.Windows.Forms.Label lblAttChartSub;
    private ECMS.UI.Controls.MiniBarChart chartCourseAttendance;

    private ECMS.UI.Controls.AppCard cardOfflineHelp;
    private System.Windows.Forms.Label lblHelpTitle;
    private System.Windows.Forms.Label lblHelpSubtitle;
    private System.Windows.Forms.Label lblHelpStep1;
    private System.Windows.Forms.Label lblHelpStep2;
    private System.Windows.Forms.Label lblHelpStep3;
    private System.Windows.Forms.Label lblHelpLink;
    private System.Windows.Forms.Label lblHelpNote;

    private ECMS.UI.Controls.AppCard cardGrid;
    private System.Windows.Forms.Label lblGridTitle;
    private ECMS.UI.Controls.AppDataGrid gridCourseSummary;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colActiveStudents;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAttRate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMonthRevenue;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDebtBalance;
}
