namespace ECMS.UI.UserControls;

partial class TuitionPaymentView
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuitionPaymentView));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlMain = new System.Windows.Forms.Panel();
        pnlHistoryCard = new ECMS.UI.Controls.AppCard();
        gridHistory = new ECMS.UI.Controls.AppDataGrid();
        colHistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colHistTransCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colHistReceiptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colHistAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colHistMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colHistCollector = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblHistoryCardTitle = new System.Windows.Forms.Label();
        pnlDebtCard = new ECMS.UI.Controls.AppCard();
        lblDebtorsFooter = new System.Windows.Forms.Label();
        gridDebtors = new ECMS.UI.Controls.AppDataGrid();
        colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTotalPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAction = new System.Windows.Forms.DataGridViewButtonColumn();
        lblDebtCardTitle = new System.Windows.Forms.Label();
        pnlStats = new System.Windows.Forms.TableLayoutPanel();
        statTotalDebt = new ECMS.UI.Controls.AppStatCard();
        statDebtorCount = new ECMS.UI.Controls.AppStatCard();
        statDueIn7Days = new ECMS.UI.Controls.AppStatCard();
        statCollectedMonth = new ECMS.UI.Controls.AppStatCard();
        pnlFilter = new System.Windows.Forms.Panel();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        cboDebtFilter = new ECMS.UI.Controls.AppComboBox();
        cboDueDateFilter = new ECMS.UI.Controls.AppComboBox();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabDueDate = new System.Windows.Forms.Button();
        btnTabHistory = new System.Windows.Forms.Button();
        btnTabDebt = new System.Windows.Forms.Button();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnCollectTuition = new ECMS.UI.Controls.AppButton();
        btnExportDebt = new ECMS.UI.Controls.AppButton();
        pnlMain.SuspendLayout();
        pnlHistoryCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
        pnlDebtCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridDebtors).BeginInit();
        pnlStats.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.AutoScroll = true;
        pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMain.Controls.Add(pnlHistoryCard);
        pnlMain.Controls.Add(pnlDebtCard);
        pnlMain.Controls.Add(pnlStats);
        pnlMain.Controls.Add(pnlFilter);
        pnlMain.Controls.Add(pnlTabs);
        pnlMain.Controls.Add(pnlHeader);
        pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMain.Location = new System.Drawing.Point(0, 0);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new System.Windows.Forms.Padding(24, 16, 24, 24);
        pnlMain.Size = new System.Drawing.Size(1200, 900);
        pnlMain.TabIndex = 0;
        // 
        // pnlHistoryCard
        // 
        pnlHistoryCard.BackColor = System.Drawing.Color.White;
        pnlHistoryCard.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlHistoryCard.BorderWidth = 1;
        pnlHistoryCard.Controls.Add(gridHistory);
        pnlHistoryCard.Controls.Add(lblHistoryCardTitle);
        pnlHistoryCard.CornerRadius = 6;
        pnlHistoryCard.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHistoryCard.Location = new System.Drawing.Point(24, 518);
        pnlHistoryCard.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
        pnlHistoryCard.Name = "pnlHistoryCard";
        pnlHistoryCard.Padding = new System.Windows.Forms.Padding(16);
        pnlHistoryCard.Size = new System.Drawing.Size(1152, 364);
        pnlHistoryCard.TabIndex = 5;
        // 
        // gridHistory
        // 
        gridHistory.AllowUserToAddRows = false;
        gridHistory.AllowUserToDeleteRows = false;
        gridHistory.AllowUserToResizeColumns = false;
        gridHistory.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        gridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridHistory.BackgroundColor = System.Drawing.Color.White;
        gridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colHistDate, colHistTransCode, colHistReceiptCode, colHistAmount, colHistMethod, colHistCollector });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridHistory.DefaultCellStyle = dataGridViewCellStyle3;
        gridHistory.Dock = System.Windows.Forms.DockStyle.Top;
        gridHistory.EnableHeadersVisualStyles = false;
        gridHistory.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridHistory.Location = new System.Drawing.Point(16, 16);
        gridHistory.MultiSelect = false;
        gridHistory.Name = "gridHistory";
        gridHistory.ReadOnly = true;
        gridHistory.RowHeadersVisible = false;
        gridHistory.RowHeadersWidth = 51;
        gridHistory.ScrollBars = System.Windows.Forms.ScrollBars.None;
        gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridHistory.Size = new System.Drawing.Size(1120, 329);
        gridHistory.TabIndex = 0;
        // 
        // colHistDate
        // 
        colHistDate.FillWeight = 15F;
        colHistDate.HeaderText = "Ngày ↑";
        colHistDate.MinimumWidth = 6;
        colHistDate.Name = "colHistDate";
        colHistDate.ReadOnly = true;
        // 
        // colHistTransCode
        // 
        colHistTransCode.FillWeight = 20F;
        colHistTransCode.HeaderText = "Mã giao dịch";
        colHistTransCode.MinimumWidth = 6;
        colHistTransCode.Name = "colHistTransCode";
        colHistTransCode.ReadOnly = true;
        // 
        // colHistReceiptCode
        // 
        colHistReceiptCode.FillWeight = 20F;
        colHistReceiptCode.HeaderText = "Phiếu thu";
        colHistReceiptCode.MinimumWidth = 6;
        colHistReceiptCode.Name = "colHistReceiptCode";
        colHistReceiptCode.ReadOnly = true;
        // 
        // colHistAmount
        // 
        colHistAmount.FillWeight = 15F;
        colHistAmount.HeaderText = "Số tiền";
        colHistAmount.MinimumWidth = 6;
        colHistAmount.Name = "colHistAmount";
        colHistAmount.ReadOnly = true;
        // 
        // colHistMethod
        // 
        colHistMethod.FillWeight = 15F;
        colHistMethod.HeaderText = "Phương thức";
        colHistMethod.MinimumWidth = 6;
        colHistMethod.Name = "colHistMethod";
        colHistMethod.ReadOnly = true;
        // 
        // colHistCollector
        // 
        colHistCollector.FillWeight = 15F;
        colHistCollector.HeaderText = "Người thu";
        colHistCollector.MinimumWidth = 6;
        colHistCollector.Name = "colHistCollector";
        colHistCollector.ReadOnly = true;
        // 
        // lblHistoryCardTitle
        // 
        lblHistoryCardTitle.AutoSize = true;
        lblHistoryCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblHistoryCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblHistoryCardTitle.Location = new System.Drawing.Point(16, 12);
        lblHistoryCardTitle.Name = "lblHistoryCardTitle";
        lblHistoryCardTitle.Size = new System.Drawing.Size(356, 25);
        lblHistoryCardTitle.TabIndex = 2;
        lblHistoryCardTitle.Text = "Lịch sử · Nguyễn Minh Anh / IELTS-F01";
        // 
        // pnlDebtCard
        // 
        pnlDebtCard.BackColor = System.Drawing.Color.White;
        pnlDebtCard.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlDebtCard.BorderWidth = 1;
        pnlDebtCard.Controls.Add(lblDebtorsFooter);
        pnlDebtCard.Controls.Add(gridDebtors);
        pnlDebtCard.Controls.Add(lblDebtCardTitle);
        pnlDebtCard.CornerRadius = 6;
        pnlDebtCard.Dock = System.Windows.Forms.DockStyle.Top;
        pnlDebtCard.Location = new System.Drawing.Point(24, 258);
        pnlDebtCard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
        pnlDebtCard.Name = "pnlDebtCard";
        pnlDebtCard.Padding = new System.Windows.Forms.Padding(16);
        pnlDebtCard.Size = new System.Drawing.Size(1152, 260);
        pnlDebtCard.TabIndex = 4;
        // 
        // lblDebtorsFooter
        // 
        lblDebtorsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblDebtorsFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblDebtorsFooter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDebtorsFooter.Location = new System.Drawing.Point(16, 219);
        lblDebtorsFooter.Name = "lblDebtorsFooter";
        lblDebtorsFooter.Size = new System.Drawing.Size(1120, 25);
        lblDebtorsFooter.TabIndex = 1;
        lblDebtorsFooter.Text = resources.GetString("lblDebtorsFooter.Text");
        // 
        // gridDebtors
        // 
        gridDebtors.AllowUserToAddRows = false;
        gridDebtors.AllowUserToDeleteRows = false;
        gridDebtors.AllowUserToResizeColumns = false;
        gridDebtors.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        gridDebtors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        gridDebtors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridDebtors.BackgroundColor = System.Drawing.Color.White;
        gridDebtors.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridDebtors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridDebtors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridDebtors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        gridDebtors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridDebtors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStudent, colClass, colTotalPayable, colPaid, colRemaining, colDueDate, colAction });
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridDebtors.DefaultCellStyle = dataGridViewCellStyle6;
        gridDebtors.Dock = System.Windows.Forms.DockStyle.Top;
        gridDebtors.EnableHeadersVisualStyles = false;
        gridDebtors.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridDebtors.Location = new System.Drawing.Point(16, 16);
        gridDebtors.MultiSelect = false;
        gridDebtors.Name = "gridDebtors";
        gridDebtors.ReadOnly = true;
        gridDebtors.RowHeadersVisible = false;
        gridDebtors.RowHeadersWidth = 51;
        gridDebtors.ScrollBars = System.Windows.Forms.ScrollBars.None;
        gridDebtors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridDebtors.Size = new System.Drawing.Size(1120, 200);
        gridDebtors.TabIndex = 0;
        // 
        // colStudent
        // 
        colStudent.FillWeight = 25F;
        colStudent.HeaderText = "Học viên ↑";
        colStudent.MinimumWidth = 6;
        colStudent.Name = "colStudent";
        colStudent.ReadOnly = true;
        // 
        // colClass
        // 
        colClass.FillWeight = 15F;
        colClass.HeaderText = "Lớp";
        colClass.MinimumWidth = 6;
        colClass.Name = "colClass";
        colClass.ReadOnly = true;
        // 
        // colTotalPayable
        // 
        colTotalPayable.FillWeight = 15F;
        colTotalPayable.HeaderText = "Thực thu";
        colTotalPayable.MinimumWidth = 6;
        colTotalPayable.Name = "colTotalPayable";
        colTotalPayable.ReadOnly = true;
        // 
        // colPaid
        // 
        colPaid.FillWeight = 15F;
        colPaid.HeaderText = "Đã thu";
        colPaid.MinimumWidth = 6;
        colPaid.Name = "colPaid";
        colPaid.ReadOnly = true;
        // 
        // colRemaining
        // 
        colRemaining.FillWeight = 15F;
        colRemaining.HeaderText = "Còn nợ";
        colRemaining.MinimumWidth = 6;
        colRemaining.Name = "colRemaining";
        colRemaining.ReadOnly = true;
        // 
        // colDueDate
        // 
        colDueDate.FillWeight = 15F;
        colDueDate.HeaderText = "Hạn trả";
        colDueDate.MinimumWidth = 6;
        colDueDate.Name = "colDueDate";
        colDueDate.ReadOnly = true;
        // 
        // colAction
        // 
        colAction.FillWeight = 12F;
        colAction.HeaderText = "Thao tác";
        colAction.MinimumWidth = 6;
        colAction.Name = "colAction";
        colAction.ReadOnly = true;
        colAction.Text = "Thu tiền";
        colAction.UseColumnTextForButtonValue = true;
        // 
        // lblDebtCardTitle
        // 
        lblDebtCardTitle.AutoSize = true;
        lblDebtCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblDebtCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDebtCardTitle.Location = new System.Drawing.Point(16, 12);
        lblDebtCardTitle.Name = "lblDebtCardTitle";
        lblDebtCardTitle.Size = new System.Drawing.Size(168, 25);
        lblDebtCardTitle.TabIndex = 2;
        lblDebtCardTitle.Text = "Công nợ học viên";
        // 
        // pnlStats
        // 
        pnlStats.ColumnCount = 4;
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlStats.Controls.Add(statTotalDebt, 0, 0);
        pnlStats.Controls.Add(statDebtorCount, 1, 0);
        pnlStats.Controls.Add(statDueIn7Days, 2, 0);
        pnlStats.Controls.Add(statCollectedMonth, 3, 0);
        pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStats.Location = new System.Drawing.Point(24, 168);
        pnlStats.Name = "pnlStats";
        pnlStats.RowCount = 1;
        pnlStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlStats.Size = new System.Drawing.Size(1152, 90);
        pnlStats.TabIndex = 3;
        // 
        // statTotalDebt
        // 
        statTotalDebt.BackColor = System.Drawing.Color.White;
        statTotalDebt.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statTotalDebt.BorderWidth = 1;
        statTotalDebt.CornerRadius = 6;
        statTotalDebt.Dock = System.Windows.Forms.DockStyle.Fill;
        statTotalDebt.Location = new System.Drawing.Point(3, 3);
        statTotalDebt.Name = "statTotalDebt";
        statTotalDebt.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
        statTotalDebt.Size = new System.Drawing.Size(282, 84);
        statTotalDebt.Subtext = "Ghi chú phụ";
        statTotalDebt.TabIndex = 0;
        statTotalDebt.Title = "Tổng công nợ trước thu";
        statTotalDebt.Value = "44,4 tr";
        // 
        // statDebtorCount
        // 
        statDebtorCount.BackColor = System.Drawing.Color.White;
        statDebtorCount.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statDebtorCount.BorderWidth = 1;
        statDebtorCount.CornerRadius = 6;
        statDebtorCount.Dock = System.Windows.Forms.DockStyle.Fill;
        statDebtorCount.Location = new System.Drawing.Point(291, 3);
        statDebtorCount.Name = "statDebtorCount";
        statDebtorCount.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
        statDebtorCount.Size = new System.Drawing.Size(282, 84);
        statDebtorCount.Subtext = "Ghi chú phụ";
        statDebtorCount.TabIndex = 1;
        statDebtorCount.Title = "Học viên còn nợ";
        statDebtorCount.Value = "27";
        // 
        // statDueIn7Days
        // 
        statDueIn7Days.BackColor = System.Drawing.Color.White;
        statDueIn7Days.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statDueIn7Days.BorderWidth = 1;
        statDueIn7Days.CornerRadius = 6;
        statDueIn7Days.Dock = System.Windows.Forms.DockStyle.Fill;
        statDueIn7Days.Location = new System.Drawing.Point(579, 3);
        statDueIn7Days.Name = "statDueIn7Days";
        statDueIn7Days.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
        statDueIn7Days.Size = new System.Drawing.Size(282, 84);
        statDueIn7Days.Subtext = "Ghi chú phụ";
        statDueIn7Days.TabIndex = 2;
        statDueIn7Days.Title = "Đến hạn trong 7 ngày";
        statDueIn7Days.Value = "12";
        // 
        // statCollectedMonth
        // 
        statCollectedMonth.BackColor = System.Drawing.Color.White;
        statCollectedMonth.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statCollectedMonth.BorderWidth = 1;
        statCollectedMonth.CornerRadius = 6;
        statCollectedMonth.Dock = System.Windows.Forms.DockStyle.Fill;
        statCollectedMonth.Location = new System.Drawing.Point(867, 3);
        statCollectedMonth.Name = "statCollectedMonth";
        statCollectedMonth.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
        statCollectedMonth.Size = new System.Drawing.Size(282, 84);
        statCollectedMonth.Subtext = "Ghi chú phụ";
        statCollectedMonth.TabIndex = 3;
        statCollectedMonth.Title = "Đã thu tháng 10";
        statCollectedMonth.Value = "185 tr";
        // 
        // pnlFilter
        // 
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Controls.Add(cboDebtFilter);
        pnlFilter.Controls.Add(cboDueDateFilter);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(24, 122);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Size = new System.Drawing.Size(1152, 46);
        pnlFilter.TabIndex = 2;
        // 
        // txtSearch
        // 
        txtSearch.BackColor = System.Drawing.Color.Transparent;
        txtSearch.CornerRadius = 5;
        txtSearch.ErrorMessage = "";
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtSearch.HasError = false;
        txtSearch.Location = new System.Drawing.Point(0, 6);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "⌕  Tìm mã, tên học viên, lớp...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(260, 34);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // cboDebtFilter
        // 
        cboDebtFilter.BackColor = System.Drawing.Color.Transparent;
        cboDebtFilter.CornerRadius = 5;
        cboDebtFilter.DataSource = null;
        cboDebtFilter.DisplayMember = "";
        cboDebtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboDebtFilter.Location = new System.Drawing.Point(270, 7);
        cboDebtFilter.Name = "cboDebtFilter";
        cboDebtFilter.SelectedIndex = -1;
        cboDebtFilter.SelectedItem = null;
        cboDebtFilter.SelectedValue = null;
        cboDebtFilter.Size = new System.Drawing.Size(130, 32);
        cboDebtFilter.TabIndex = 1;
        cboDebtFilter.ValueMember = "";
        // 
        // cboDueDateFilter
        // 
        cboDueDateFilter.BackColor = System.Drawing.Color.Transparent;
        cboDueDateFilter.CornerRadius = 5;
        cboDueDateFilter.DataSource = null;
        cboDueDateFilter.DisplayMember = "";
        cboDueDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboDueDateFilter.Location = new System.Drawing.Point(410, 7);
        cboDueDateFilter.Name = "cboDueDateFilter";
        cboDueDateFilter.SelectedIndex = -1;
        cboDueDateFilter.SelectedItem = null;
        cboDueDateFilter.SelectedValue = null;
        cboDueDateFilter.Size = new System.Drawing.Size(160, 32);
        cboDueDateFilter.TabIndex = 2;
        cboDueDateFilter.ValueMember = "";
        // 
        // pnlTabs
        // 
        pnlTabs.Controls.Add(btnTabDueDate);
        pnlTabs.Controls.Add(btnTabHistory);
        pnlTabs.Controls.Add(btnTabDebt);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(24, 86);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Size = new System.Drawing.Size(1152, 36);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabDueDate
        // 
        btnTabDueDate.FlatAppearance.BorderSize = 0;
        btnTabDueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabDueDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnTabDueDate.Location = new System.Drawing.Point(210, 4);
        btnTabDueDate.Name = "btnTabDueDate";
        btnTabDueDate.Size = new System.Drawing.Size(120, 28);
        btnTabDueDate.TabIndex = 2;
        btnTabDueDate.Text = "Hạn thanh toán";
        btnTabDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabDueDate.UseVisualStyleBackColor = true;
        // 
        // btnTabHistory
        // 
        btnTabHistory.FlatAppearance.BorderSize = 0;
        btnTabHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabHistory.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnTabHistory.Location = new System.Drawing.Point(105, 4);
        btnTabHistory.Name = "btnTabHistory";
        btnTabHistory.Size = new System.Drawing.Size(100, 28);
        btnTabHistory.TabIndex = 1;
        btnTabHistory.Text = "Lịch sử thu";
        btnTabHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabHistory.UseVisualStyleBackColor = true;
        // 
        // btnTabDebt
        // 
        btnTabDebt.FlatAppearance.BorderSize = 0;
        btnTabDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabDebt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabDebt.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnTabDebt.Location = new System.Drawing.Point(0, 4);
        btnTabDebt.Name = "btnTabDebt";
        btnTabDebt.Size = new System.Drawing.Size(100, 28);
        btnTabDebt.TabIndex = 0;
        btnTabDebt.Text = "• Công nợ";
        btnTabDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnTabDebt.UseVisualStyleBackColor = true;
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1152, 70);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(0, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(270, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Học phí & thanh toán";
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlTopActions.Controls.Add(btnCollectTuition);
        pnlTopActions.Controls.Add(btnExportDebt);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(852, 12);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnCollectTuition
        // 
        btnCollectTuition.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCollectTuition.CornerRadius = 5;
        btnCollectTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCollectTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCollectTuition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnCollectTuition.Location = new System.Drawing.Point(167, 3);
        btnCollectTuition.Name = "btnCollectTuition";
        btnCollectTuition.Size = new System.Drawing.Size(130, 38);
        btnCollectTuition.TabIndex = 1;
        btnCollectTuition.Text = "Thu học phí";
        btnCollectTuition.UseVisualStyleBackColor = true;
        btnCollectTuition.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnExportDebt
        // 
        btnExportDebt.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnExportDebt.CornerRadius = 5;
        btnExportDebt.Cursor = System.Windows.Forms.Cursors.Hand;
        btnExportDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnExportDebt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnExportDebt.Location = new System.Drawing.Point(15, 3);
        btnExportDebt.Name = "btnExportDebt";
        btnExportDebt.Size = new System.Drawing.Size(146, 38);
        btnExportDebt.TabIndex = 0;
        btnExportDebt.Text = "Xuất công nợ";
        btnExportDebt.UseVisualStyleBackColor = true;
        btnExportDebt.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // TuitionPaymentView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlMain);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1200, 900);
        pnlMain.ResumeLayout(false);
        pnlHistoryCard.ResumeLayout(false);
        pnlHistoryCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
        pnlDebtCard.ResumeLayout(false);
        pnlDebtCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridDebtors).EndInit();
        pnlStats.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlTabs.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnExportDebt;
    private ECMS.UI.Controls.AppButton btnCollectTuition;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabDebt;
    private System.Windows.Forms.Button btnTabHistory;
    private System.Windows.Forms.Button btnTabDueDate;
    private System.Windows.Forms.Panel pnlFilter;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private ECMS.UI.Controls.AppComboBox cboDebtFilter;
    private ECMS.UI.Controls.AppComboBox cboDueDateFilter;
    private System.Windows.Forms.TableLayoutPanel pnlStats;
    private ECMS.UI.Controls.AppStatCard statTotalDebt;
    private ECMS.UI.Controls.AppStatCard statDebtorCount;
    private ECMS.UI.Controls.AppStatCard statDueIn7Days;
    private ECMS.UI.Controls.AppStatCard statCollectedMonth;
    private ECMS.UI.Controls.AppCard pnlDebtCard;
    private System.Windows.Forms.Label lblDebtCardTitle;
    private ECMS.UI.Controls.AppDataGrid gridDebtors;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
    private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPayable;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPaid;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
    private System.Windows.Forms.DataGridViewButtonColumn colAction;
    private System.Windows.Forms.Label lblDebtorsFooter;
    private ECMS.UI.Controls.AppCard pnlHistoryCard;
    private System.Windows.Forms.Label lblHistoryCardTitle;
    private ECMS.UI.Controls.AppDataGrid gridHistory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistTransCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistReceiptCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistAmount;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistMethod;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHistCollector;
}
