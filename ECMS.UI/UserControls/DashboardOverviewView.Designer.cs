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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
        _lblKpi1Value = new System.Windows.Forms.Label();
        _lblKpi1Title = new System.Windows.Forms.Label();
        _cardKpi2 = new ECMS.UI.Controls.AppCard();
        _lblKpi2Value = new System.Windows.Forms.Label();
        _lblKpi2Title = new System.Windows.Forms.Label();
        _cardKpi3 = new ECMS.UI.Controls.AppCard();
        _lblKpi3Value = new System.Windows.Forms.Label();
        _lblKpi3Title = new System.Windows.Forms.Label();
        _cardKpi4 = new ECMS.UI.Controls.AppCard();
        _lblKpi4Value = new System.Windows.Forms.Label();
        _lblKpi4Title = new System.Windows.Forms.Label();
        _cardKpi5 = new ECMS.UI.Controls.AppCard();
        _lblKpi5Value = new System.Windows.Forms.Label();
        _lblKpi5Title = new System.Windows.Forms.Label();
        _cardKpi6 = new ECMS.UI.Controls.AppCard();
        _lblKpi6Value = new System.Windows.Forms.Label();
        _lblKpi6Title = new System.Windows.Forms.Label();
        _cardRevenue = new ECMS.UI.Controls.AppCard();
        _btnRevenueDetail = new ECMS.UI.Controls.AppButton();
        _lblRevenueTitle = new System.Windows.Forms.Label();
        _chartRevenue = new ECMS.UI.Controls.MiniBarChart();
        _cardStudents = new ECMS.UI.Controls.AppCard();
        _btnStudentsDetail = new ECMS.UI.Controls.AppButton();
        _lblStudentsTitle = new System.Windows.Forms.Label();
        _chartStudents = new ECMS.UI.Controls.MiniBarChart();
        _cardAttendance = new ECMS.UI.Controls.AppCard();
        _btnAttDetail = new ECMS.UI.Controls.AppButton();
        _dgvRatio = new ECMS.UI.Controls.AppDataGrid();
        _lblAttSub = new System.Windows.Forms.Label();
        _lblAttPercent = new System.Windows.Forms.Label();
        _lblAttTitle = new System.Windows.Forms.Label();
        _cardSchedule = new ECMS.UI.Controls.AppCard();
        _btnSchedDetail = new ECMS.UI.Controls.AppButton();
        _dgvSchedule = new ECMS.UI.Controls.AppDataGrid();
        _lblSchedTitle = new System.Windows.Forms.Label();
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
        _pnlContentWrapper.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
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
        _lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblTitle.Location = new System.Drawing.Point(24, 34);
        _lblTitle.Name = "_lblTitle";
        _lblTitle.Size = new System.Drawing.Size(290, 37);
        _lblTitle.TabIndex = 0;
        _lblTitle.Text = "Tổng quan trung tâm";
        // 
        // _btnPendingTasks
        // 
        _btnPendingTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnPendingTasks.BackColor = System.Drawing.Color.White;
        _btnPendingTasks.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnPendingTasks.CornerRadius = 5;
        _btnPendingTasks.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnPendingTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnPendingTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        _btnPendingTasks.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)217)), ((int)((byte)119)), ((int)((byte)6)));
        _btnPendingTasks.Location = new System.Drawing.Point(852, 34);
        _btnPendingTasks.Name = "_btnPendingTasks";
        _btnPendingTasks.Size = new System.Drawing.Size(188, 36);
        _btnPendingTasks.TabIndex = 1;
        _btnPendingTasks.Text = "Danh sách cần xử lý (6)";
        _btnPendingTasks.UseVisualStyleBackColor = false;
        _btnPendingTasks.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // _btnExport
        // 
        _btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnExport.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
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
        _btnExport.UseVisualStyleBackColor = false;
        _btnExport.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // _pnlFilterToolbar
        // 
        _pnlFilterToolbar.BackColor = System.Drawing.Color.White;
        _pnlFilterToolbar.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _pnlFilterToolbar.BorderWidth = 1;
        _pnlFilterToolbar.Controls.Add(_txtSearch);
        _pnlFilterToolbar.Controls.Add(_btnSearch);
        _pnlFilterToolbar.Controls.Add(_cboMonth);
        _pnlFilterToolbar.Controls.Add(_cboCourse);
        _pnlFilterToolbar.CornerRadius = 6;
        _pnlFilterToolbar.Location = new System.Drawing.Point(24, 88);
        _pnlFilterToolbar.Name = "_pnlFilterToolbar";
        _pnlFilterToolbar.Padding = new System.Windows.Forms.Padding(16);
        _pnlFilterToolbar.Size = new System.Drawing.Size(1152, 50);
        _pnlFilterToolbar.TabIndex = 3;
        // 
        // _txtSearch
        // 
        _txtSearch.BackColor = System.Drawing.Color.Transparent;
        _txtSearch.CornerRadius = 5;
        _txtSearch.ErrorMessage = "";
        _txtSearch.HasError = false;
        _txtSearch.Location = new System.Drawing.Point(12, 8);
        _txtSearch.Name = "_txtSearch";
        _txtSearch.Placeholder = "Tìm nhanh học viên, lớp học, khóa học...";
        _txtSearch.ReadOnly = false;
        _txtSearch.Size = new System.Drawing.Size(360, 34);
        _txtSearch.TabIndex = 0;
        _txtSearch.UseSystemPasswordChar = false;
        // 
        // _btnSearch
        // 
        _btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
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
        _btnSearch.UseVisualStyleBackColor = false;
        _btnSearch.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // _cboMonth
        // 
        _cboMonth.BackColor = System.Drawing.Color.Transparent;
        _cboMonth.CornerRadius = 5;
        _cboMonth.DataSource = null;
        _cboMonth.DisplayMember = "";
        _cboMonth.Location = new System.Drawing.Point(480, 8);
        _cboMonth.Name = "_cboMonth";
        _cboMonth.SelectedIndex = -1;
        _cboMonth.SelectedItem = null;
        _cboMonth.SelectedValue = null;
        _cboMonth.Size = new System.Drawing.Size(150, 34);
        _cboMonth.TabIndex = 2;
        _cboMonth.ValueMember = "";
        // 
        // _cboCourse
        // 
        _cboCourse.BackColor = System.Drawing.Color.Transparent;
        _cboCourse.CornerRadius = 5;
        _cboCourse.DataSource = null;
        _cboCourse.DisplayMember = "";
        _cboCourse.Location = new System.Drawing.Point(640, 8);
        _cboCourse.Name = "_cboCourse";
        _cboCourse.SelectedIndex = -1;
        _cboCourse.SelectedItem = null;
        _cboCourse.SelectedValue = null;
        _cboCourse.Size = new System.Drawing.Size(180, 34);
        _cboCourse.TabIndex = 3;
        _cboCourse.ValueMember = "";
        // 
        // _cardKpi1
        // 
        _cardKpi1.BackColor = System.Drawing.Color.White;
        _cardKpi1.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi1.BorderWidth = 1;
        _cardKpi1.Controls.Add(_lblKpi1Value);
        _cardKpi1.Controls.Add(_lblKpi1Title);
        _cardKpi1.CornerRadius = 6;
        _cardKpi1.Location = new System.Drawing.Point(24, 150);
        _cardKpi1.Name = "_cardKpi1";
        _cardKpi1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi1.Size = new System.Drawing.Size(182, 82);
        _cardKpi1.TabIndex = 4;
        // 
        // _lblKpi1Value
        // 
        _lblKpi1Value.AutoSize = true;
        _lblKpi1Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi1Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi1Value.Name = "_lblKpi1Value";
        _lblKpi1Value.Size = new System.Drawing.Size(69, 41);
        _lblKpi1Value.TabIndex = 1;
        _lblKpi1Value.Text = "428";
        // 
        // _lblKpi1Title
        // 
        _lblKpi1Title.AutoSize = true;
        _lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi1Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi1Title.Name = "_lblKpi1Title";
        _lblKpi1Title.Size = new System.Drawing.Size(115, 19);
        _lblKpi1Title.TabIndex = 0;
        _lblKpi1Title.Text = "TỔNG HỌC VIÊN";
        // 
        // _cardKpi2
        // 
        _cardKpi2.BackColor = System.Drawing.Color.White;
        _cardKpi2.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi2.BorderWidth = 1;
        _cardKpi2.Controls.Add(_lblKpi2Value);
        _cardKpi2.Controls.Add(_lblKpi2Title);
        _cardKpi2.CornerRadius = 6;
        _cardKpi2.Location = new System.Drawing.Point(218, 150);
        _cardKpi2.Name = "_cardKpi2";
        _cardKpi2.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi2.Size = new System.Drawing.Size(182, 82);
        _cardKpi2.TabIndex = 5;
        // 
        // _lblKpi2Value
        // 
        _lblKpi2Value.AutoSize = true;
        _lblKpi2Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi2Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi2Value.Name = "_lblKpi2Value";
        _lblKpi2Value.Size = new System.Drawing.Size(69, 41);
        _lblKpi2Value.TabIndex = 1;
        _lblKpi2Value.Text = "348";
        // 
        // _lblKpi2Title
        // 
        _lblKpi2Title.AutoSize = true;
        _lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi2Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi2Title.Name = "_lblKpi2Title";
        _lblKpi2Title.Size = new System.Drawing.Size(82, 19);
        _lblKpi2Title.TabIndex = 0;
        _lblKpi2Title.Text = "ĐANG HỌC";
        // 
        // _cardKpi3
        // 
        _cardKpi3.BackColor = System.Drawing.Color.White;
        _cardKpi3.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi3.BorderWidth = 1;
        _cardKpi3.Controls.Add(_lblKpi3Value);
        _cardKpi3.Controls.Add(_lblKpi3Title);
        _cardKpi3.CornerRadius = 6;
        _cardKpi3.Location = new System.Drawing.Point(412, 150);
        _cardKpi3.Name = "_cardKpi3";
        _cardKpi3.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi3.Size = new System.Drawing.Size(182, 82);
        _cardKpi3.TabIndex = 6;
        // 
        // _lblKpi3Value
        // 
        _lblKpi3Value.AutoSize = true;
        _lblKpi3Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi3Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi3Value.Name = "_lblKpi3Value";
        _lblKpi3Value.Size = new System.Drawing.Size(52, 41);
        _lblKpi3Value.TabIndex = 1;
        _lblKpi3Value.Text = "18";
        // 
        // _lblKpi3Title
        // 
        _lblKpi3Title.AutoSize = true;
        _lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi3Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi3Title.Name = "_lblKpi3Title";
        _lblKpi3Title.Size = new System.Drawing.Size(121, 19);
        _lblKpi3Title.TabIndex = 0;
        _lblKpi3Title.Text = "LỚP HOẠT ĐỘNG";
        // 
        // _cardKpi4
        // 
        _cardKpi4.BackColor = System.Drawing.Color.White;
        _cardKpi4.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi4.BorderWidth = 1;
        _cardKpi4.Controls.Add(_lblKpi4Value);
        _cardKpi4.Controls.Add(_lblKpi4Title);
        _cardKpi4.CornerRadius = 6;
        _cardKpi4.Location = new System.Drawing.Point(606, 150);
        _cardKpi4.Name = "_cardKpi4";
        _cardKpi4.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi4.Size = new System.Drawing.Size(182, 82);
        _cardKpi4.TabIndex = 7;
        // 
        // _lblKpi4Value
        // 
        _lblKpi4Value.AutoSize = true;
        _lblKpi4Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi4Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi4Value.Name = "_lblKpi4Value";
        _lblKpi4Value.Size = new System.Drawing.Size(52, 41);
        _lblKpi4Value.TabIndex = 1;
        _lblKpi4Value.Text = "24";
        // 
        // _lblKpi4Title
        // 
        _lblKpi4Title.AutoSize = true;
        _lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi4Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi4Title.Name = "_lblKpi4Title";
        _lblKpi4Title.Size = new System.Drawing.Size(77, 19);
        _lblKpi4Title.TabIndex = 0;
        _lblKpi4Title.Text = "GIÁO VIÊN";
        // 
        // _cardKpi5
        // 
        _cardKpi5.BackColor = System.Drawing.Color.White;
        _cardKpi5.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi5.BorderWidth = 1;
        _cardKpi5.Controls.Add(_lblKpi5Value);
        _cardKpi5.Controls.Add(_lblKpi5Title);
        _cardKpi5.CornerRadius = 6;
        _cardKpi5.Location = new System.Drawing.Point(800, 150);
        _cardKpi5.Name = "_cardKpi5";
        _cardKpi5.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi5.Size = new System.Drawing.Size(182, 82);
        _cardKpi5.TabIndex = 8;
        // 
        // _lblKpi5Value
        // 
        _lblKpi5Value.AutoSize = true;
        _lblKpi5Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi5Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi5Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi5Value.Name = "_lblKpi5Value";
        _lblKpi5Value.Size = new System.Drawing.Size(126, 41);
        _lblKpi5Value.TabIndex = 1;
        _lblKpi5Value.Text = "186,5 tr";
        // 
        // _lblKpi5Title
        // 
        _lblKpi5Title.AutoSize = true;
        _lblKpi5Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi5Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi5Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi5Title.Name = "_lblKpi5Title";
        _lblKpi5Title.Size = new System.Drawing.Size(90, 19);
        _lblKpi5Title.TabIndex = 0;
        _lblKpi5Title.Text = "DOANH THU";
        // 
        // _cardKpi6
        // 
        _cardKpi6.BackColor = System.Drawing.Color.White;
        _cardKpi6.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardKpi6.BorderWidth = 1;
        _cardKpi6.Controls.Add(_lblKpi6Value);
        _cardKpi6.Controls.Add(_lblKpi6Title);
        _cardKpi6.CornerRadius = 6;
        _cardKpi6.Location = new System.Drawing.Point(994, 150);
        _cardKpi6.Name = "_cardKpi6";
        _cardKpi6.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        _cardKpi6.Size = new System.Drawing.Size(182, 82);
        _cardKpi6.TabIndex = 9;
        // 
        // _lblKpi6Value
        // 
        _lblKpi6Value.AutoSize = true;
        _lblKpi6Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        _lblKpi6Value.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblKpi6Value.Location = new System.Drawing.Point(10, 32);
        _lblKpi6Value.Name = "_lblKpi6Value";
        _lblKpi6Value.Size = new System.Drawing.Size(109, 41);
        _lblKpi6Value.TabIndex = 1;
        _lblKpi6Value.Text = "42,9 tr";
        // 
        // _lblKpi6Title
        // 
        _lblKpi6Title.AutoSize = true;
        _lblKpi6Title.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblKpi6Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblKpi6Title.Location = new System.Drawing.Point(12, 10);
        _lblKpi6Title.Name = "_lblKpi6Title";
        _lblKpi6Title.Size = new System.Drawing.Size(106, 19);
        _lblKpi6Title.TabIndex = 0;
        _lblKpi6Title.Text = "CÔNG NỢ TỒN";
        // 
        // _cardRevenue
        // 
        _cardRevenue.BackColor = System.Drawing.Color.White;
        _cardRevenue.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardRevenue.BorderWidth = 1;
        _cardRevenue.Controls.Add(_btnRevenueDetail);
        _cardRevenue.Controls.Add(_lblRevenueTitle);
        _cardRevenue.Controls.Add(_chartRevenue);
        _cardRevenue.CornerRadius = 6;
        _cardRevenue.Location = new System.Drawing.Point(24, 244);
        _cardRevenue.Name = "_cardRevenue";
        _cardRevenue.Padding = new System.Windows.Forms.Padding(16);
        _cardRevenue.Size = new System.Drawing.Size(410, 240);
        _cardRevenue.TabIndex = 10;
        // 
        // _btnRevenueDetail
        // 
        _btnRevenueDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnRevenueDetail.BackColor = System.Drawing.Color.White;
        _btnRevenueDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnRevenueDetail.CornerRadius = 4;
        _btnRevenueDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnRevenueDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnRevenueDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnRevenueDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _btnRevenueDetail.Location = new System.Drawing.Point(294, 10);
        _btnRevenueDetail.Name = "_btnRevenueDetail";
        _btnRevenueDetail.Size = new System.Drawing.Size(102, 28);
        _btnRevenueDetail.TabIndex = 1;
        _btnRevenueDetail.Text = "Xem chi tiết";
        _btnRevenueDetail.UseVisualStyleBackColor = false;
        _btnRevenueDetail.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // _lblRevenueTitle
        // 
        _lblRevenueTitle.AutoSize = true;
        _lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblRevenueTitle.Location = new System.Drawing.Point(16, 14);
        _lblRevenueTitle.Name = "_lblRevenueTitle";
        _lblRevenueTitle.Size = new System.Drawing.Size(158, 23);
        _lblRevenueTitle.TabIndex = 0;
        _lblRevenueTitle.Text = "Biểu đồ doanh thu";
        // 
        // _chartRevenue
        // 
        _chartRevenue.BackColor = System.Drawing.Color.White;
        _chartRevenue.HighlightBarColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _chartRevenue.Location = new System.Drawing.Point(14, 46);
        _chartRevenue.Name = "_chartRevenue";
        _chartRevenue.NormalBarColor = System.Drawing.Color.FromArgb(((int)((byte)147)), ((int)((byte)197)), ((int)((byte)253)));
        _chartRevenue.Size = new System.Drawing.Size(382, 180);
        _chartRevenue.TabIndex = 2;
        // 
        // _cardStudents
        // 
        _cardStudents.BackColor = System.Drawing.Color.White;
        _cardStudents.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardStudents.BorderWidth = 1;
        _cardStudents.Controls.Add(_btnStudentsDetail);
        _cardStudents.Controls.Add(_lblStudentsTitle);
        _cardStudents.Controls.Add(_chartStudents);
        _cardStudents.CornerRadius = 6;
        _cardStudents.Location = new System.Drawing.Point(448, 244);
        _cardStudents.Name = "_cardStudents";
        _cardStudents.Padding = new System.Windows.Forms.Padding(16);
        _cardStudents.Size = new System.Drawing.Size(350, 240);
        _cardStudents.TabIndex = 11;
        // 
        // _btnStudentsDetail
        // 
        _btnStudentsDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnStudentsDetail.BackColor = System.Drawing.Color.White;
        _btnStudentsDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnStudentsDetail.CornerRadius = 4;
        _btnStudentsDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnStudentsDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnStudentsDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnStudentsDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _btnStudentsDetail.Location = new System.Drawing.Point(234, 10);
        _btnStudentsDetail.Name = "_btnStudentsDetail";
        _btnStudentsDetail.Size = new System.Drawing.Size(102, 28);
        _btnStudentsDetail.TabIndex = 1;
        _btnStudentsDetail.Text = "Xem chi tiết";
        _btnStudentsDetail.UseVisualStyleBackColor = false;
        _btnStudentsDetail.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // _lblStudentsTitle
        // 
        _lblStudentsTitle.AutoSize = true;
        _lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblStudentsTitle.Location = new System.Drawing.Point(16, 14);
        _lblStudentsTitle.Name = "_lblStudentsTitle";
        _lblStudentsTitle.Size = new System.Drawing.Size(182, 23);
        _lblStudentsTitle.TabIndex = 0;
        _lblStudentsTitle.Text = "Tăng trưởng học viên";
        // 
        // _chartStudents
        // 
        _chartStudents.BackColor = System.Drawing.Color.White;
        _chartStudents.HighlightBarColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _chartStudents.Location = new System.Drawing.Point(14, 46);
        _chartStudents.Name = "_chartStudents";
        _chartStudents.NormalBarColor = System.Drawing.Color.FromArgb(((int)((byte)147)), ((int)((byte)197)), ((int)((byte)253)));
        _chartStudents.Size = new System.Drawing.Size(322, 180);
        _chartStudents.TabIndex = 2;
        // 
        // _cardAttendance
        // 
        _cardAttendance.BackColor = System.Drawing.Color.White;
        _cardAttendance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardAttendance.BorderWidth = 1;
        _cardAttendance.Controls.Add(_btnAttDetail);
        _cardAttendance.Controls.Add(_dgvRatio);
        _cardAttendance.Controls.Add(_lblAttSub);
        _cardAttendance.Controls.Add(_lblAttPercent);
        _cardAttendance.Controls.Add(_lblAttTitle);
        _cardAttendance.CornerRadius = 6;
        _cardAttendance.Location = new System.Drawing.Point(812, 244);
        _cardAttendance.Name = "_cardAttendance";
        _cardAttendance.Padding = new System.Windows.Forms.Padding(16);
        _cardAttendance.Size = new System.Drawing.Size(364, 240);
        _cardAttendance.TabIndex = 12;
        // 
        // _btnAttDetail
        // 
        _btnAttDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnAttDetail.BackColor = System.Drawing.Color.White;
        _btnAttDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnAttDetail.CornerRadius = 4;
        _btnAttDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnAttDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnAttDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnAttDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _btnAttDetail.Location = new System.Drawing.Point(248, 10);
        _btnAttDetail.Name = "_btnAttDetail";
        _btnAttDetail.Size = new System.Drawing.Size(102, 28);
        _btnAttDetail.TabIndex = 1;
        _btnAttDetail.Text = "Xem chi tiết";
        _btnAttDetail.UseVisualStyleBackColor = false;
        _btnAttDetail.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // _dgvRatio
        // 
        _dgvRatio.AllowUserToAddRows = false;
        _dgvRatio.AllowUserToDeleteRows = false;
        _dgvRatio.AllowUserToResizeColumns = false;
        _dgvRatio.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _dgvRatio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        _dgvRatio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        _dgvRatio.BackgroundColor = System.Drawing.Color.White;
        _dgvRatio.BorderStyle = System.Windows.Forms.BorderStyle.None;
        _dgvRatio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        _dgvRatio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        _dgvRatio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        _dgvRatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        _dgvRatio.DefaultCellStyle = dataGridViewCellStyle3;
        _dgvRatio.EnableHeadersVisualStyles = false;
        _dgvRatio.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _dgvRatio.Location = new System.Drawing.Point(14, 76);
        _dgvRatio.MultiSelect = false;
        _dgvRatio.Name = "_dgvRatio";
        _dgvRatio.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        _dgvRatio.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        _dgvRatio.RowHeadersVisible = false;
        _dgvRatio.RowHeadersWidth = 51;
        _dgvRatio.ScrollBars = System.Windows.Forms.ScrollBars.None;
        _dgvRatio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        _dgvRatio.Size = new System.Drawing.Size(336, 150);
        _dgvRatio.TabIndex = 4;
        // 
        // _lblAttSub
        // 
        _lblAttSub.AutoSize = true;
        _lblAttSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        _lblAttSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        _lblAttSub.Location = new System.Drawing.Point(115, 50);
        _lblAttSub.Name = "_lblAttSub";
        _lblAttSub.Size = new System.Drawing.Size(139, 19);
        _lblAttSub.TabIndex = 3;
        _lblAttSub.Text = "Có mặt / buổi đã học";
        // 
        // _lblAttPercent
        // 
        _lblAttPercent.AutoSize = true;
        _lblAttPercent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        _lblAttPercent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _lblAttPercent.Location = new System.Drawing.Point(14, 40);
        _lblAttPercent.Name = "_lblAttPercent";
        _lblAttPercent.Size = new System.Drawing.Size(95, 37);
        _lblAttPercent.TabIndex = 2;
        _lblAttPercent.Text = "92,4%";
        // 
        // _lblAttTitle
        // 
        _lblAttTitle.AutoSize = true;
        _lblAttTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblAttTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblAttTitle.Location = new System.Drawing.Point(16, 14);
        _lblAttTitle.Name = "_lblAttTitle";
        _lblAttTitle.Size = new System.Drawing.Size(166, 23);
        _lblAttTitle.TabIndex = 0;
        _lblAttTitle.Text = "Chuyên cần lớp học";
        // 
        // _cardSchedule
        // 
        _cardSchedule.BackColor = System.Drawing.Color.White;
        _cardSchedule.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _cardSchedule.BorderWidth = 1;
        _cardSchedule.Controls.Add(_btnSchedDetail);
        _cardSchedule.Controls.Add(_dgvSchedule);
        _cardSchedule.Controls.Add(_lblSchedTitle);
        _cardSchedule.CornerRadius = 6;
        _cardSchedule.Location = new System.Drawing.Point(24, 496);
        _cardSchedule.Name = "_cardSchedule";
        _cardSchedule.Padding = new System.Windows.Forms.Padding(16);
        _cardSchedule.Size = new System.Drawing.Size(1152, 300);
        _cardSchedule.TabIndex = 13;
        // 
        // _btnSchedDetail
        // 
        _btnSchedDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        _btnSchedDetail.BackColor = System.Drawing.Color.White;
        _btnSchedDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        _btnSchedDetail.CornerRadius = 4;
        _btnSchedDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        _btnSchedDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        _btnSchedDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        _btnSchedDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _btnSchedDetail.Location = new System.Drawing.Point(1036, 10);
        _btnSchedDetail.Name = "_btnSchedDetail";
        _btnSchedDetail.Size = new System.Drawing.Size(102, 28);
        _btnSchedDetail.TabIndex = 1;
        _btnSchedDetail.Text = "Xem chi tiết";
        _btnSchedDetail.UseVisualStyleBackColor = false;
        _btnSchedDetail.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // _dgvSchedule
        // 
        _dgvSchedule.AllowUserToAddRows = false;
        _dgvSchedule.AllowUserToDeleteRows = false;
        _dgvSchedule.AllowUserToResizeColumns = false;
        _dgvSchedule.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        _dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        _dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        _dgvSchedule.BackgroundColor = System.Drawing.Color.White;
        _dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
        _dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        _dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        _dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        _dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        _dgvSchedule.DefaultCellStyle = dataGridViewCellStyle7;
        _dgvSchedule.EnableHeadersVisualStyles = false;
        _dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        _dgvSchedule.Location = new System.Drawing.Point(16, 46);
        _dgvSchedule.MultiSelect = false;
        _dgvSchedule.Name = "_dgvSchedule";
        _dgvSchedule.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        _dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        _dgvSchedule.RowHeadersVisible = false;
        _dgvSchedule.RowHeadersWidth = 51;
        _dgvSchedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
        _dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        _dgvSchedule.Size = new System.Drawing.Size(1120, 240);
        _dgvSchedule.TabIndex = 2;
        // 
        // _lblSchedTitle
        // 
        _lblSchedTitle.AutoSize = true;
        _lblSchedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        _lblSchedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        _lblSchedTitle.Location = new System.Drawing.Point(16, 14);
        _lblSchedTitle.Name = "_lblSchedTitle";
        _lblSchedTitle.Size = new System.Drawing.Size(279, 23);
        _lblSchedTitle.TabIndex = 0;
        _lblSchedTitle.Text = "Lịch học hôm nay & Sắp khai giảng";
        // 
        // DashboardOverviewView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(_pnlContentWrapper);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
