namespace ECMS.UI.Forms;

partial class ClassAttendanceDialog
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        lblSub = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabOverview = new System.Windows.Forms.Button();
        btnTabSessions = new System.Windows.Forms.Button();
        pnlBody = new System.Windows.Forms.Panel();
        cardSessionsView = new ECMS.UI.Controls.AppCard();
        pnlSessionsList = new System.Windows.Forms.Panel();
        dgvSessions = new ECMS.UI.Controls.AppDataGrid();
        lblSessionsTitle = new System.Windows.Forms.Label();
        pnlCheckSession = new System.Windows.Forms.Panel();
        dgvStudentCheck = new ECMS.UI.Controls.AppDataGrid();
        pnlCheckFooter = new System.Windows.Forms.Panel();
        lblSaveStatus = new System.Windows.Forms.Label();
        btnSaveAttendance = new ECMS.UI.Controls.AppButton();
        pnlCheckHeader = new System.Windows.Forms.Panel();
        btnMarkAllPresent = new ECMS.UI.Controls.AppButton();
        lblCurrentSessionTitle = new System.Windows.Forms.Label();
        btnBackToSessions = new ECMS.UI.Controls.AppButton();
        cardOverviewView = new ECMS.UI.Controls.AppCard();
        dgvMatrix = new ECMS.UI.Controls.AppDataGrid();
        lblOverviewTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardSessionsView.SuspendLayout();
        pnlSessionsList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
        pnlCheckSession.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStudentCheck).BeginInit();
        pnlCheckFooter.SuspendLayout();
        pnlCheckHeader.SuspendLayout();
        cardOverviewView.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSub);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1200, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblSub
        // 
        lblSub.AutoSize = true;
        lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblSub.Location = new System.Drawing.Point(24, 46);
        lblSub.Name = "lblSub";
        lblSub.Size = new System.Drawing.Size(426, 20);
        lblSub.TabIndex = 1;
        lblSub.Text = "Giáo viên: Nguyễn Hoàng Anh | Phòng: P201 | Sĩ số: 20 học viên";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(349, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "IELTS-F01 · IELTS Foundation";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = System.Drawing.Color.White;
        pnlTabs.Controls.Add(btnTabOverview);
        pnlTabs.Controls.Add(btnTabSessions);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(0, 75);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlTabs.Size = new System.Drawing.Size(1200, 42);
        pnlTabs.TabIndex = 1;
        pnlTabs.Visible = false;
        // 
        // btnTabOverview
        // 
        btnTabOverview.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabOverview.FlatAppearance.BorderSize = 0;
        btnTabOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabOverview.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabOverview.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabOverview.Location = new System.Drawing.Point(234, 0);
        btnTabOverview.Name = "btnTabOverview";
        btnTabOverview.Size = new System.Drawing.Size(250, 42);
        btnTabOverview.TabIndex = 1;
        btnTabOverview.Text = "Tổng quan chuyên cần cả lớp";
        btnTabOverview.UseVisualStyleBackColor = true;
        btnTabOverview.Visible = false;
        // 
        // btnTabSessions
        // 
        btnTabSessions.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabSessions.FlatAppearance.BorderSize = 0;
        btnTabSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabSessions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabSessions.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnTabSessions.Location = new System.Drawing.Point(24, 0);
        btnTabSessions.Name = "btnTabSessions";
        btnTabSessions.Size = new System.Drawing.Size(210, 42);
        btnTabSessions.TabIndex = 0;
        btnTabSessions.Text = "Danh sách buổi học";
        btnTabSessions.UseVisualStyleBackColor = true;
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardSessionsView);
        pnlBody.Controls.Add(cardOverviewView);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 117);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1200, 663);
        pnlBody.TabIndex = 2;
        // 
        // cardSessionsView
        // 
        cardSessionsView.BackColor = System.Drawing.Color.White;
        cardSessionsView.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardSessionsView.BorderWidth = 1;
        cardSessionsView.Controls.Add(pnlSessionsList);
        cardSessionsView.Controls.Add(pnlCheckSession);
        cardSessionsView.CornerRadius = 8;
        cardSessionsView.Location = new System.Drawing.Point(24, 16);
        cardSessionsView.Name = "cardSessionsView";
        cardSessionsView.Padding = new System.Windows.Forms.Padding(16);
        cardSessionsView.Size = new System.Drawing.Size(1149, 635);
        cardSessionsView.TabIndex = 0;
        // 
        // pnlSessionsList
        // 
        pnlSessionsList.Controls.Add(dgvSessions);
        pnlSessionsList.Controls.Add(lblSessionsTitle);
        pnlSessionsList.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlSessionsList.Location = new System.Drawing.Point(16, 16);
        pnlSessionsList.Name = "pnlSessionsList";
        pnlSessionsList.Size = new System.Drawing.Size(1117, 603);
        pnlSessionsList.TabIndex = 0;
        // 
        // dgvSessions
        // 
        dgvSessions.AllowUserToAddRows = false;
        dgvSessions.AllowUserToDeleteRows = false;
        dgvSessions.AllowUserToResizeColumns = false;
        dgvSessions.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvSessions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSessions.BackgroundColor = System.Drawing.Color.White;
        dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSessions.ColumnHeadersHeight = 38;
        dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvSessions.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSessions.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSessions.EnableHeadersVisualStyles = false;
        dgvSessions.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvSessions.Location = new System.Drawing.Point(0, 36);
        dgvSessions.MultiSelect = false;
        dgvSessions.Name = "dgvSessions";
        dgvSessions.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSessions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvSessions.RowHeadersVisible = false;
        dgvSessions.RowHeadersWidth = 51;
        dgvSessions.RowTemplate.Height = 40;
        dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSessions.Size = new System.Drawing.Size(1117, 567);
        dgvSessions.TabIndex = 1;
        // 
        // lblSessionsTitle
        // 
        lblSessionsTitle.AutoSize = true;
        lblSessionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblSessionsTitle.Location = new System.Drawing.Point(0, 0);
        lblSessionsTitle.Name = "lblSessionsTitle";
        lblSessionsTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 11);
        lblSessionsTitle.Size = new System.Drawing.Size(361, 36);
        lblSessionsTitle.TabIndex = 0;
        lblSessionsTitle.Text = "KẾ HOẠCH VÀ TIẾN ĐỘ CÁC BUỔI HỌC";
        // 
        // pnlCheckSession
        // 
        pnlCheckSession.Controls.Add(dgvStudentCheck);
        pnlCheckSession.Controls.Add(pnlCheckFooter);
        pnlCheckSession.Controls.Add(pnlCheckHeader);
        pnlCheckSession.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlCheckSession.Location = new System.Drawing.Point(16, 16);
        pnlCheckSession.Name = "pnlCheckSession";
        pnlCheckSession.Size = new System.Drawing.Size(1117, 603);
        pnlCheckSession.TabIndex = 1;
        pnlCheckSession.Visible = false;
        // 
        // dgvStudentCheck
        // 
        dgvStudentCheck.AllowUserToAddRows = false;
        dgvStudentCheck.AllowUserToDeleteRows = false;
        dgvStudentCheck.AllowUserToResizeColumns = false;
        dgvStudentCheck.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvStudentCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        dgvStudentCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvStudentCheck.BackgroundColor = System.Drawing.Color.White;
        dgvStudentCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvStudentCheck.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvStudentCheck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudentCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvStudentCheck.ColumnHeadersHeight = 38;
        dgvStudentCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvStudentCheck.DefaultCellStyle = dataGridViewCellStyle7;
        dgvStudentCheck.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvStudentCheck.EnableHeadersVisualStyles = false;
        dgvStudentCheck.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvStudentCheck.Location = new System.Drawing.Point(0, 46);
        dgvStudentCheck.MultiSelect = false;
        dgvStudentCheck.Name = "dgvStudentCheck";
        dgvStudentCheck.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvStudentCheck.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        dgvStudentCheck.RowHeadersVisible = false;
        dgvStudentCheck.RowHeadersWidth = 51;
        dgvStudentCheck.RowTemplate.Height = 40;
        dgvStudentCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvStudentCheck.Size = new System.Drawing.Size(1117, 509);
        dgvStudentCheck.TabIndex = 1;
        // 
        // pnlCheckFooter
        // 
        pnlCheckFooter.Controls.Add(lblSaveStatus);
        pnlCheckFooter.Controls.Add(btnSaveAttendance);
        pnlCheckFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlCheckFooter.Location = new System.Drawing.Point(0, 555);
        pnlCheckFooter.Name = "pnlCheckFooter";
        pnlCheckFooter.Size = new System.Drawing.Size(1117, 48);
        pnlCheckFooter.TabIndex = 2;
        // 
        // lblSaveStatus
        // 
        lblSaveStatus.AutoSize = true;
        lblSaveStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblSaveStatus.Location = new System.Drawing.Point(6, 16);
        lblSaveStatus.Name = "lblSaveStatus";
        lblSaveStatus.Size = new System.Drawing.Size(273, 20);
        lblSaveStatus.TabIndex = 1;
        lblSaveStatus.Text = "✓ Đã lưu kết quả điểm danh của buổi!";
        lblSaveStatus.Visible = false;
        // 
        // btnSaveAttendance
        // 
        btnSaveAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSaveAttendance.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAttendance.CornerRadius = 5;
        btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAttendance.ForeColor = System.Drawing.Color.White;
        btnSaveAttendance.Location = new System.Drawing.Point(947, 8);
        btnSaveAttendance.Name = "btnSaveAttendance";
        btnSaveAttendance.Size = new System.Drawing.Size(170, 36);
        btnSaveAttendance.TabIndex = 0;
        btnSaveAttendance.Text = "💾 Lưu điểm danh";
        btnSaveAttendance.UseVisualStyleBackColor = false;
        btnSaveAttendance.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // pnlCheckHeader
        // 
        pnlCheckHeader.Controls.Add(btnMarkAllPresent);
        pnlCheckHeader.Controls.Add(lblCurrentSessionTitle);
        pnlCheckHeader.Controls.Add(btnBackToSessions);
        pnlCheckHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlCheckHeader.Location = new System.Drawing.Point(0, 0);
        pnlCheckHeader.Name = "pnlCheckHeader";
        pnlCheckHeader.Size = new System.Drawing.Size(1117, 46);
        pnlCheckHeader.TabIndex = 0;
        // 
        // btnMarkAllPresent
        // 
        btnMarkAllPresent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnMarkAllPresent.BackColor = System.Drawing.Color.White;
        btnMarkAllPresent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnMarkAllPresent.CornerRadius = 5;
        btnMarkAllPresent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnMarkAllPresent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)34)), ((int)((byte)197)), ((int)((byte)94)));
        btnMarkAllPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMarkAllPresent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnMarkAllPresent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        btnMarkAllPresent.Location = new System.Drawing.Point(917, 6);
        btnMarkAllPresent.Name = "btnMarkAllPresent";
        btnMarkAllPresent.Size = new System.Drawing.Size(200, 34);
        btnMarkAllPresent.TabIndex = 2;
        btnMarkAllPresent.Text = "✓ Đánh dấu tất cả có mặt";
        btnMarkAllPresent.UseVisualStyleBackColor = false;
        btnMarkAllPresent.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblCurrentSessionTitle
        // 
        lblCurrentSessionTitle.AutoSize = true;
        lblCurrentSessionTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblCurrentSessionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblCurrentSessionTitle.Location = new System.Drawing.Point(195, 10);
        lblCurrentSessionTitle.Name = "lblCurrentSessionTitle";
        lblCurrentSessionTitle.Size = new System.Drawing.Size(383, 25);
        lblCurrentSessionTitle.TabIndex = 1;
        lblCurrentSessionTitle.Text = "ĐIỂM DANH BUỔI 08 · 30/10 (18:00 – 20:00)";
        // 
        // btnBackToSessions
        // 
        btnBackToSessions.BackColor = System.Drawing.Color.White;
        btnBackToSessions.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToSessions.CornerRadius = 5;
        btnBackToSessions.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToSessions.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackToSessions.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnBackToSessions.Location = new System.Drawing.Point(0, 6);
        btnBackToSessions.Name = "btnBackToSessions";
        btnBackToSessions.Size = new System.Drawing.Size(185, 34);
        btnBackToSessions.TabIndex = 0;
        btnBackToSessions.Text = "← Danh sách các buổi";
        btnBackToSessions.UseVisualStyleBackColor = false;
        btnBackToSessions.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cardOverviewView
        // 
        cardOverviewView.BackColor = System.Drawing.Color.White;
        cardOverviewView.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardOverviewView.BorderWidth = 1;
        cardOverviewView.Controls.Add(dgvMatrix);
        cardOverviewView.Controls.Add(lblOverviewTitle);
        cardOverviewView.CornerRadius = 8;
        cardOverviewView.Location = new System.Drawing.Point(24, 16);
        cardOverviewView.Name = "cardOverviewView";
        cardOverviewView.Padding = new System.Windows.Forms.Padding(16);
        cardOverviewView.Size = new System.Drawing.Size(1052, 560);
        cardOverviewView.TabIndex = 1;
        cardOverviewView.Visible = false;
        // 
        // dgvMatrix
        // 
        dgvMatrix.AllowUserToAddRows = false;
        dgvMatrix.AllowUserToDeleteRows = false;
        dgvMatrix.AllowUserToResizeColumns = false;
        dgvMatrix.AllowUserToResizeRows = false;
        dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
        dgvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvMatrix.BackgroundColor = System.Drawing.Color.White;
        dgvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(4);
        dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
        dgvMatrix.ColumnHeadersHeight = 38;
        dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
        dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvMatrix.DefaultCellStyle = dataGridViewCellStyle11;
        dgvMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvMatrix.EnableHeadersVisualStyles = false;
        dgvMatrix.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvMatrix.Location = new System.Drawing.Point(16, 49);
        dgvMatrix.MultiSelect = false;
        dgvMatrix.Name = "dgvMatrix";
        dgvMatrix.ReadOnly = true;
        dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
        dgvMatrix.RowHeadersVisible = false;
        dgvMatrix.RowHeadersWidth = 51;
        dgvMatrix.RowTemplate.Height = 38;
        dgvMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMatrix.Size = new System.Drawing.Size(1020, 495);
        dgvMatrix.TabIndex = 1;
        // 
        // lblOverviewTitle
        // 
        lblOverviewTitle.AutoSize = true;
        lblOverviewTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblOverviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblOverviewTitle.Location = new System.Drawing.Point(16, 16);
        lblOverviewTitle.Name = "lblOverviewTitle";
        lblOverviewTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
        lblOverviewTitle.Size = new System.Drawing.Size(429, 33);
        lblOverviewTitle.TabIndex = 0;
        lblOverviewTitle.Text = "MA TRẬN CHUYÊN CẦN TOÀN KHÓA CỦA LỚP";
        // 
        // ClassAttendanceDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1200, 780);
        Controls.Add(pnlBody);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Điểm danh lớp học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardSessionsView.ResumeLayout(false);
        pnlSessionsList.ResumeLayout(false);
        pnlSessionsList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSessions).EndInit();
        pnlCheckSession.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvStudentCheck).EndInit();
        pnlCheckFooter.ResumeLayout(false);
        pnlCheckFooter.PerformLayout();
        pnlCheckHeader.ResumeLayout(false);
        pnlCheckHeader.PerformLayout();
        cardOverviewView.ResumeLayout(false);
        cardOverviewView.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSub;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabSessions;
    private System.Windows.Forms.Button btnTabOverview;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardSessionsView;
    private System.Windows.Forms.Panel pnlSessionsList;
    private System.Windows.Forms.Label lblSessionsTitle;
    private ECMS.UI.Controls.AppDataGrid dgvSessions;
    private System.Windows.Forms.Panel pnlCheckSession;
    private System.Windows.Forms.Panel pnlCheckHeader;
    private ECMS.UI.Controls.AppButton btnBackToSessions;
    private System.Windows.Forms.Label lblCurrentSessionTitle;
    private ECMS.UI.Controls.AppButton btnMarkAllPresent;
    private ECMS.UI.Controls.AppDataGrid dgvStudentCheck;
    private System.Windows.Forms.Panel pnlCheckFooter;
    private ECMS.UI.Controls.AppButton btnSaveAttendance;
    private System.Windows.Forms.Label lblSaveStatus;
    private ECMS.UI.Controls.AppCard cardOverviewView;
    private System.Windows.Forms.Label lblOverviewTitle;
    private ECMS.UI.Controls.AppDataGrid dgvMatrix;
}
