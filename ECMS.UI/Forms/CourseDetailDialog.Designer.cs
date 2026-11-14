namespace ECMS.UI.Forms;

partial class CourseDetailDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        btnCreateClass = new ECMS.UI.Controls.AppButton();
        btnEditCourse = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabRules = new System.Windows.Forms.Button();
        btnTabMaterials = new System.Windows.Forms.Button();
        btnTabClasses = new System.Windows.Forms.Button();
        btnTabOverview = new System.Windows.Forms.Button();
        pnlBody = new System.Windows.Forms.Panel();
        pnlBottomCards = new System.Windows.Forms.Panel();
        cardMaterials = new ECMS.UI.Controls.AppCard();
        btnOpenMaterials = new ECMS.UI.Controls.AppButton();
        lblMaterialFile = new System.Windows.Forms.Label();
        lblMaterialsTitle = new System.Windows.Forms.Label();
        cardGoals = new ECMS.UI.Controls.AppCard();
        lblGoalPassVal = new System.Windows.Forms.Label();
        lblGoalPassKey = new System.Windows.Forms.Label();
        lblGoalOutputVal = new System.Windows.Forms.Label();
        lblGoalOutputKey = new System.Windows.Forms.Label();
        lblGoalInputVal = new System.Windows.Forms.Label();
        lblGoalInputKey = new System.Windows.Forms.Label();
        lblGoalsTitle = new System.Windows.Forms.Label();
        cardClassList = new ECMS.UI.Controls.AppCard();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        lblClassListTitle = new System.Windows.Forms.Label();
        cardStatClasses = new ECMS.UI.Controls.AppCard();
        lblStatClassesValue = new System.Windows.Forms.Label();
        lblStatClassesTitle = new System.Windows.Forms.Label();
        cardStatTuition = new ECMS.UI.Controls.AppCard();
        lblStatTuitionValue = new System.Windows.Forms.Label();
        lblStatTuitionTitle = new System.Windows.Forms.Label();
        cardStatHours = new ECMS.UI.Controls.AppCard();
        lblStatHoursValue = new System.Windows.Forms.Label();
        lblStatHoursTitle = new System.Windows.Forms.Label();
        cardStatSessions = new ECMS.UI.Controls.AppCard();
        lblStatSessionsValue = new System.Windows.Forms.Label();
        lblStatSessionsTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlBottomCards.SuspendLayout();
        cardMaterials.SuspendLayout();
        cardGoals.SuspendLayout();
        cardClassList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        cardStatClasses.SuspendLayout();
        cardStatTuition.SuspendLayout();
        cardStatHours.SuspendLayout();
        cardStatSessions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateClass);
        pnlHeader.Controls.Add(btnEditCourse);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateClass
        // 
        btnCreateClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateClass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnCreateClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateClass.CornerRadius = 5;
        btnCreateClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateClass.ForeColor = System.Drawing.Color.White;
        btnCreateClass.Location = new System.Drawing.Point(1070, 20);
        btnCreateClass.Name = "btnCreateClass";
        btnCreateClass.Size = new System.Drawing.Size(126, 36);
        btnCreateClass.TabIndex = 4;
        btnCreateClass.Text = "+ Tạo lớp học";
        btnCreateClass.UseVisualStyleBackColor = false;
        btnCreateClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEditCourse
        // 
        btnEditCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEditCourse.BackColor = System.Drawing.Color.White;
        btnEditCourse.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEditCourse.CornerRadius = 5;
        btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEditCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnEditCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnEditCourse.Location = new System.Drawing.Point(945, 20);
        btnEditCourse.Name = "btnEditCourse";
        btnEditCourse.Size = new System.Drawing.Size(115, 36);
        btnEditCourse.TabIndex = 3;
        btnEditCourse.Text = "Sửa khóa học";
        btnEditCourse.UseVisualStyleBackColor = false;
        btnEditCourse.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(237, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "IELTS Foundation";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = System.Drawing.Color.White;
        pnlTabs.Controls.Add(btnTabRules);
        pnlTabs.Controls.Add(btnTabMaterials);
        pnlTabs.Controls.Add(btnTabClasses);
        pnlTabs.Controls.Add(btnTabOverview);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(0, 75);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlTabs.Size = new System.Drawing.Size(1220, 42);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabRules
        // 
        btnTabRules.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabRules.FlatAppearance.BorderSize = 0;
        btnTabRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabRules.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabRules.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabRules.Location = new System.Drawing.Point(384, 0);
        btnTabRules.Name = "btnTabRules";
        btnTabRules.Size = new System.Drawing.Size(130, 42);
        btnTabRules.TabIndex = 3;
        btnTabRules.Text = "Quy tắc đánh giá";
        btnTabRules.UseVisualStyleBackColor = true;
        // 
        // btnTabMaterials
        // 
        btnTabMaterials.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabMaterials.FlatAppearance.BorderSize = 0;
        btnTabMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabMaterials.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabMaterials.Location = new System.Drawing.Point(264, 0);
        btnTabMaterials.Name = "btnTabMaterials";
        btnTabMaterials.Size = new System.Drawing.Size(120, 42);
        btnTabMaterials.TabIndex = 2;
        btnTabMaterials.Text = "Tài liệu";
        btnTabMaterials.UseVisualStyleBackColor = true;
        // 
        // btnTabClasses
        // 
        btnTabClasses.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabClasses.FlatAppearance.BorderSize = 0;
        btnTabClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabClasses.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabClasses.Location = new System.Drawing.Point(144, 0);
        btnTabClasses.Name = "btnTabClasses";
        btnTabClasses.Size = new System.Drawing.Size(120, 42);
        btnTabClasses.TabIndex = 1;
        btnTabClasses.Text = "Lớp liên quan";
        btnTabClasses.UseVisualStyleBackColor = true;
        // 
        // btnTabOverview
        // 
        btnTabOverview.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabOverview.FlatAppearance.BorderSize = 0;
        btnTabOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabOverview.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabOverview.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnTabOverview.Location = new System.Drawing.Point(24, 0);
        btnTabOverview.Name = "btnTabOverview";
        btnTabOverview.Size = new System.Drawing.Size(120, 42);
        btnTabOverview.TabIndex = 0;
        btnTabOverview.Text = "▬ Tổng quan";
        btnTabOverview.UseVisualStyleBackColor = true;
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(pnlBottomCards);
        pnlBody.Controls.Add(cardClassList);
        pnlBody.Controls.Add(cardStatClasses);
        pnlBody.Controls.Add(cardStatTuition);
        pnlBody.Controls.Add(cardStatHours);
        pnlBody.Controls.Add(cardStatSessions);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 117);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 643);
        pnlBody.TabIndex = 2;
        // 
        // pnlBottomCards
        // 
        pnlBottomCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlBottomCards.Controls.Add(cardMaterials);
        pnlBottomCards.Controls.Add(cardGoals);
        pnlBottomCards.Location = new System.Drawing.Point(24, 432);
        pnlBottomCards.Name = "pnlBottomCards";
        pnlBottomCards.Size = new System.Drawing.Size(1172, 173);
        pnlBottomCards.TabIndex = 5;
        // 
        // cardMaterials
        // 
        cardMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardMaterials.BackColor = System.Drawing.Color.White;
        cardMaterials.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardMaterials.BorderWidth = 1;
        cardMaterials.Controls.Add(btnOpenMaterials);
        cardMaterials.Controls.Add(lblMaterialFile);
        cardMaterials.Controls.Add(lblMaterialsTitle);
        cardMaterials.CornerRadius = 6;
        cardMaterials.Location = new System.Drawing.Point(603, 3);
        cardMaterials.Name = "cardMaterials";
        cardMaterials.Padding = new System.Windows.Forms.Padding(20);
        cardMaterials.Size = new System.Drawing.Size(572, 166);
        cardMaterials.TabIndex = 1;
        // 
        // btnOpenMaterials
        // 
        btnOpenMaterials.BackColor = System.Drawing.Color.White;
        btnOpenMaterials.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenMaterials.CornerRadius = 5;
        btnOpenMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenMaterials.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnOpenMaterials.Location = new System.Drawing.Point(20, 116);
        btnOpenMaterials.Name = "btnOpenMaterials";
        btnOpenMaterials.Size = new System.Drawing.Size(180, 36);
        btnOpenMaterials.TabIndex = 3;
        btnOpenMaterials.Text = "Mở quản lý tài liệu";
        btnOpenMaterials.UseVisualStyleBackColor = false;
        btnOpenMaterials.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblMaterialFile
        // 
        lblMaterialFile.AutoSize = true;
        lblMaterialFile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblMaterialFile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblMaterialFile.Location = new System.Drawing.Point(20, 58);
        lblMaterialFile.Name = "lblMaterialFile";
        lblMaterialFile.Size = new System.Drawing.Size(402, 21);
        lblMaterialFile.TabIndex = 1;
        lblMaterialFile.Text = "📄  IELTS_Foundation_Complete_V1.2.pdf (14.2 MB)";
        // 
        // lblMaterialsTitle
        // 
        lblMaterialsTitle.AutoSize = true;
        lblMaterialsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblMaterialsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblMaterialsTitle.Location = new System.Drawing.Point(20, 16);
        lblMaterialsTitle.Name = "lblMaterialsTitle";
        lblMaterialsTitle.Size = new System.Drawing.Size(163, 28);
        lblMaterialsTitle.TabIndex = 0;
        lblMaterialsTitle.Text = "Tài liệu áp dụng";
        // 
        // cardGoals
        // 
        cardGoals.BackColor = System.Drawing.Color.White;
        cardGoals.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGoals.BorderWidth = 1;
        cardGoals.Controls.Add(lblGoalPassVal);
        cardGoals.Controls.Add(lblGoalPassKey);
        cardGoals.Controls.Add(lblGoalOutputVal);
        cardGoals.Controls.Add(lblGoalOutputKey);
        cardGoals.Controls.Add(lblGoalInputVal);
        cardGoals.Controls.Add(lblGoalInputKey);
        cardGoals.Controls.Add(lblGoalsTitle);
        cardGoals.CornerRadius = 6;
        cardGoals.Location = new System.Drawing.Point(3, 3);
        cardGoals.Name = "cardGoals";
        cardGoals.Padding = new System.Windows.Forms.Padding(20);
        cardGoals.Size = new System.Drawing.Size(572, 166);
        cardGoals.TabIndex = 0;
        // 
        // lblGoalPassVal
        // 
        lblGoalPassVal.AutoSize = true;
        lblGoalPassVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGoalPassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGoalPassVal.Location = new System.Drawing.Point(140, 125);
        lblGoalPassVal.Name = "lblGoalPassVal";
        lblGoalPassVal.Size = new System.Drawing.Size(308, 20);
        lblGoalPassVal.TabIndex = 6;
        lblGoalPassVal.Text = "Điểm trung bình ≥ 6,5/10 · Chuyên cần ≥ 80%";
        // 
        // lblGoalPassKey
        // 
        lblGoalPassKey.AutoSize = true;
        lblGoalPassKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGoalPassKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblGoalPassKey.Location = new System.Drawing.Point(20, 125);
        lblGoalPassKey.Name = "lblGoalPassKey";
        lblGoalPassKey.Size = new System.Drawing.Size(76, 20);
        lblGoalPassKey.TabIndex = 5;
        lblGoalPassKey.Text = "Chuẩn đạt";
        // 
        // lblGoalOutputVal
        // 
        lblGoalOutputVal.AutoSize = true;
        lblGoalOutputVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblGoalOutputVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGoalOutputVal.Location = new System.Drawing.Point(140, 90);
        lblGoalOutputVal.Name = "lblGoalOutputVal";
        lblGoalOutputVal.Size = new System.Drawing.Size(171, 20);
        lblGoalOutputVal.TabIndex = 4;
        lblGoalOutputVal.Text = "Nền tảng IELTS 4.0–4.5";
        // 
        // lblGoalOutputKey
        // 
        lblGoalOutputKey.AutoSize = true;
        lblGoalOutputKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGoalOutputKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblGoalOutputKey.Location = new System.Drawing.Point(20, 90);
        lblGoalOutputKey.Name = "lblGoalOutputKey";
        lblGoalOutputKey.Size = new System.Drawing.Size(112, 20);
        lblGoalOutputKey.TabIndex = 3;
        lblGoalOutputKey.Text = "Mục tiêu đầu ra";
        // 
        // lblGoalInputVal
        // 
        lblGoalInputVal.AutoSize = true;
        lblGoalInputVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGoalInputVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGoalInputVal.Location = new System.Drawing.Point(140, 55);
        lblGoalInputVal.Name = "lblGoalInputVal";
        lblGoalInputVal.Size = new System.Drawing.Size(124, 20);
        lblGoalInputVal.TabIndex = 2;
        lblGoalInputVal.Text = "Cơ bản · 0–4,5/10";
        // 
        // lblGoalInputKey
        // 
        lblGoalInputKey.AutoSize = true;
        lblGoalInputKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGoalInputKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblGoalInputKey.Location = new System.Drawing.Point(20, 55);
        lblGoalInputKey.Name = "lblGoalInputKey";
        lblGoalInputKey.Size = new System.Drawing.Size(120, 20);
        lblGoalInputKey.TabIndex = 1;
        lblGoalInputKey.Text = "Trình độ đầu vào";
        // 
        // lblGoalsTitle
        // 
        lblGoalsTitle.AutoSize = true;
        lblGoalsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblGoalsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGoalsTitle.Location = new System.Drawing.Point(20, 16);
        lblGoalsTitle.Name = "lblGoalsTitle";
        lblGoalsTitle.Size = new System.Drawing.Size(175, 28);
        lblGoalsTitle.TabIndex = 0;
        lblGoalsTitle.Text = "Mục tiêu đào tạo";
        // 
        // cardClassList
        // 
        cardClassList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassList.BackColor = System.Drawing.Color.White;
        cardClassList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassList.BorderWidth = 1;
        cardClassList.Controls.Add(dgvClasses);
        cardClassList.Controls.Add(lblClassListTitle);
        cardClassList.CornerRadius = 6;
        cardClassList.Location = new System.Drawing.Point(24, 130);
        cardClassList.Name = "cardClassList";
        cardClassList.Padding = new System.Windows.Forms.Padding(20);
        cardClassList.Size = new System.Drawing.Size(1172, 296);
        cardClassList.TabIndex = 4;
        // 
        // dgvClasses
        // 
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.AllowUserToDeleteRows = false;
        dgvClasses.AllowUserToResizeColumns = false;
        dgvClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClasses.BackgroundColor = System.Drawing.Color.White;
        dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClasses.EnableHeadersVisualStyles = false;
        dgvClasses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvClasses.Location = new System.Drawing.Point(20, 50);
        dgvClasses.MultiSelect = false;
        dgvClasses.Name = "dgvClasses";
        dgvClasses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.RowHeadersWidth = 51;
        dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.Size = new System.Drawing.Size(1132, 226);
        dgvClasses.TabIndex = 1;
        // 
        // lblClassListTitle
        // 
        lblClassListTitle.AutoSize = true;
        lblClassListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblClassListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassListTitle.Location = new System.Drawing.Point(20, 16);
        lblClassListTitle.Name = "lblClassListTitle";
        lblClassListTitle.Size = new System.Drawing.Size(272, 28);
        lblClassListTitle.TabIndex = 0;
        lblClassListTitle.Text = "Các lớp thuộc chương trình";
        // 
        // cardStatClasses
        // 
        cardStatClasses.BackColor = System.Drawing.Color.White;
        cardStatClasses.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatClasses.BorderWidth = 1;
        cardStatClasses.Controls.Add(lblStatClassesValue);
        cardStatClasses.Controls.Add(lblStatClassesTitle);
        cardStatClasses.CornerRadius = 6;
        cardStatClasses.Location = new System.Drawing.Point(909, 24);
        cardStatClasses.Name = "cardStatClasses";
        cardStatClasses.Padding = new System.Windows.Forms.Padding(16);
        cardStatClasses.Size = new System.Drawing.Size(287, 85);
        cardStatClasses.TabIndex = 3;
        // 
        // lblStatClassesValue
        // 
        lblStatClassesValue.AutoSize = true;
        lblStatClassesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatClassesValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatClassesValue.Location = new System.Drawing.Point(16, 38);
        lblStatClassesValue.Name = "lblStatClassesValue";
        lblStatClassesValue.Size = new System.Drawing.Size(90, 41);
        lblStatClassesValue.TabIndex = 1;
        lblStatClassesValue.Text = "3 lớp";
        // 
        // lblStatClassesTitle
        // 
        lblStatClassesTitle.AutoSize = true;
        lblStatClassesTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatClassesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatClassesTitle.Location = new System.Drawing.Point(16, 16);
        lblStatClassesTitle.Name = "lblStatClassesTitle";
        lblStatClassesTitle.Size = new System.Drawing.Size(99, 20);
        lblStatClassesTitle.TabIndex = 0;
        lblStatClassesTitle.Text = "Lớp liên quan";
        // 
        // cardStatTuition
        // 
        cardStatTuition.BackColor = System.Drawing.Color.White;
        cardStatTuition.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatTuition.BorderWidth = 1;
        cardStatTuition.Controls.Add(lblStatTuitionValue);
        cardStatTuition.Controls.Add(lblStatTuitionTitle);
        cardStatTuition.CornerRadius = 6;
        cardStatTuition.Location = new System.Drawing.Point(614, 24);
        cardStatTuition.Name = "cardStatTuition";
        cardStatTuition.Padding = new System.Windows.Forms.Padding(16);
        cardStatTuition.Size = new System.Drawing.Size(287, 85);
        cardStatTuition.TabIndex = 2;
        // 
        // lblStatTuitionValue
        // 
        lblStatTuitionValue.AutoSize = true;
        lblStatTuitionValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatTuitionValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatTuitionValue.Location = new System.Drawing.Point(16, 38);
        lblStatTuitionValue.Name = "lblStatTuitionValue";
        lblStatTuitionValue.Size = new System.Drawing.Size(172, 41);
        lblStatTuitionValue.TabIndex = 1;
        lblStatTuitionValue.Text = "6.000.000đ";
        // 
        // lblStatTuitionTitle
        // 
        lblStatTuitionTitle.AutoSize = true;
        lblStatTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatTuitionTitle.Location = new System.Drawing.Point(16, 16);
        lblStatTuitionTitle.Name = "lblStatTuitionTitle";
        lblStatTuitionTitle.Size = new System.Drawing.Size(90, 20);
        lblStatTuitionTitle.TabIndex = 0;
        lblStatTuitionTitle.Text = "Học phí gốc";
        // 
        // cardStatHours
        // 
        cardStatHours.BackColor = System.Drawing.Color.White;
        cardStatHours.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatHours.BorderWidth = 1;
        cardStatHours.Controls.Add(lblStatHoursValue);
        cardStatHours.Controls.Add(lblStatHoursTitle);
        cardStatHours.CornerRadius = 6;
        cardStatHours.Location = new System.Drawing.Point(319, 24);
        cardStatHours.Name = "cardStatHours";
        cardStatHours.Padding = new System.Windows.Forms.Padding(16);
        cardStatHours.Size = new System.Drawing.Size(287, 85);
        cardStatHours.TabIndex = 1;
        // 
        // lblStatHoursValue
        // 
        lblStatHoursValue.AutoSize = true;
        lblStatHoursValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatHoursValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatHoursValue.Location = new System.Drawing.Point(16, 38);
        lblStatHoursValue.Name = "lblStatHoursValue";
        lblStatHoursValue.Size = new System.Drawing.Size(107, 41);
        lblStatHoursValue.TabIndex = 1;
        lblStatHoursValue.Text = "48 giờ";
        // 
        // lblStatHoursTitle
        // 
        lblStatHoursTitle.AutoSize = true;
        lblStatHoursTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatHoursTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatHoursTitle.Location = new System.Drawing.Point(16, 16);
        lblStatHoursTitle.Name = "lblStatHoursTitle";
        lblStatHoursTitle.Size = new System.Drawing.Size(97, 20);
        lblStatHoursTitle.TabIndex = 0;
        lblStatHoursTitle.Text = "Tổng giờ học";
        // 
        // cardStatSessions
        // 
        cardStatSessions.BackColor = System.Drawing.Color.White;
        cardStatSessions.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatSessions.BorderWidth = 1;
        cardStatSessions.Controls.Add(lblStatSessionsValue);
        cardStatSessions.Controls.Add(lblStatSessionsTitle);
        cardStatSessions.CornerRadius = 6;
        cardStatSessions.Location = new System.Drawing.Point(24, 24);
        cardStatSessions.Name = "cardStatSessions";
        cardStatSessions.Padding = new System.Windows.Forms.Padding(16);
        cardStatSessions.Size = new System.Drawing.Size(287, 85);
        cardStatSessions.TabIndex = 0;
        // 
        // lblStatSessionsValue
        // 
        lblStatSessionsValue.AutoSize = true;
        lblStatSessionsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatSessionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatSessionsValue.Location = new System.Drawing.Point(16, 38);
        lblStatSessionsValue.Name = "lblStatSessionsValue";
        lblStatSessionsValue.Size = new System.Drawing.Size(124, 41);
        lblStatSessionsValue.TabIndex = 1;
        lblStatSessionsValue.Text = "24 buổi";
        // 
        // lblStatSessionsTitle
        // 
        lblStatSessionsTitle.AutoSize = true;
        lblStatSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatSessionsTitle.Location = new System.Drawing.Point(16, 16);
        lblStatSessionsTitle.Name = "lblStatSessionsTitle";
        lblStatSessionsTitle.Size = new System.Drawing.Size(81, 20);
        lblStatSessionsTitle.TabIndex = 0;
        lblStatSessionsTitle.Text = "Thời lượng";
        // 
        // CourseDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết khóa học · IELTS Foundation";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        pnlBottomCards.ResumeLayout(false);
        cardMaterials.ResumeLayout(false);
        cardMaterials.PerformLayout();
        cardGoals.ResumeLayout(false);
        cardGoals.PerformLayout();
        cardClassList.ResumeLayout(false);
        cardClassList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        cardStatClasses.ResumeLayout(false);
        cardStatClasses.PerformLayout();
        cardStatTuition.ResumeLayout(false);
        cardStatTuition.PerformLayout();
        cardStatHours.ResumeLayout(false);
        cardStatHours.PerformLayout();
        cardStatSessions.ResumeLayout(false);
        cardStatSessions.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblMaterialFile;

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnEditCourse;
    private ECMS.UI.Controls.AppButton btnCreateClass;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabOverview;
    private System.Windows.Forms.Button btnTabClasses;
    private System.Windows.Forms.Button btnTabMaterials;
    private System.Windows.Forms.Button btnTabRules;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStatSessions;
    private System.Windows.Forms.Label lblStatSessionsTitle;
    private System.Windows.Forms.Label lblStatSessionsValue;
    private ECMS.UI.Controls.AppCard cardStatHours;
    private System.Windows.Forms.Label lblStatHoursTitle;
    private System.Windows.Forms.Label lblStatHoursValue;
    private ECMS.UI.Controls.AppCard cardStatTuition;
    private System.Windows.Forms.Label lblStatTuitionTitle;
    private System.Windows.Forms.Label lblStatTuitionValue;
    private ECMS.UI.Controls.AppCard cardStatClasses;
    private System.Windows.Forms.Label lblStatClassesTitle;
    private System.Windows.Forms.Label lblStatClassesValue;
    private ECMS.UI.Controls.AppCard cardClassList;
    private System.Windows.Forms.Label lblClassListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Panel pnlBottomCards;
    private ECMS.UI.Controls.AppCard cardGoals;
    private System.Windows.Forms.Label lblGoalsTitle;
    private System.Windows.Forms.Label lblGoalInputKey;
    private System.Windows.Forms.Label lblGoalInputVal;
    private System.Windows.Forms.Label lblGoalOutputKey;
    private System.Windows.Forms.Label lblGoalOutputVal;
    private System.Windows.Forms.Label lblGoalPassKey;
    private System.Windows.Forms.Label lblGoalPassVal;
    private ECMS.UI.Controls.AppCard cardMaterials;
    private System.Windows.Forms.Label lblMaterialsTitle;
    private ECMS.UI.Controls.AppButton btnOpenMaterials;
}
