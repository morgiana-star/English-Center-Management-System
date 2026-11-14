namespace ECMS.UI.UserControls;

partial class TeacherGradeManagementView
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
        pnlHeader = new System.Windows.Forms.Panel();
        btnCreateAssessmentTop = new ECMS.UI.Controls.AppButton();
        btnEnterGradesTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCreateAssessment = new ECMS.UI.Controls.AppCard();
        btnSaveAssessment = new ECMS.UI.Controls.AppButton();
        btnCancelAssessment = new ECMS.UI.Controls.AppButton();
        txtWeight = new ECMS.UI.Controls.AppTextBox();
        lblWeight = new System.Windows.Forms.Label();
        txtScale = new ECMS.UI.Controls.AppTextBox();
        lblScale = new System.Windows.Forms.Label();
        dtpExamDate = new System.Windows.Forms.DateTimePicker();
        lblExamDate = new System.Windows.Forms.Label();
        cboAssessmentType = new ECMS.UI.Controls.AppComboBox();
        lblAssessmentType = new System.Windows.Forms.Label();
        txtAssessmentName = new ECMS.UI.Controls.AppTextBox();
        lblAssessmentName = new System.Windows.Forms.Label();
        cboAssignedClass = new ECMS.UI.Controls.AppComboBox();
        lblAssignedClass = new System.Windows.Forms.Label();
        lblCreateTitle = new System.Windows.Forms.Label();
        cardAssessmentList = new ECMS.UI.Controls.AppCard();
        lblPassingRule = new System.Windows.Forms.Label();
        lblRankRule = new System.Windows.Forms.Label();
        lblRoundRule = new System.Windows.Forms.Label();
        lblFormulaRule = new System.Windows.Forms.Label();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvAssessments = new ECMS.UI.Controls.AppDataGrid();
        cboTypeFilter = new ECMS.UI.Controls.AppComboBox();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchAssessment = new ECMS.UI.Controls.AppTextBox();
        lblAssessmentListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCreateAssessment.SuspendLayout();
        cardAssessmentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAssessments).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateAssessmentTop);
        pnlHeader.Controls.Add(btnEnterGradesTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateAssessmentTop
        // 
        btnCreateAssessmentTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateAssessmentTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnCreateAssessmentTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateAssessmentTop.CornerRadius = 5;
        btnCreateAssessmentTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateAssessmentTop.FlatAppearance.BorderSize = 0;
        btnCreateAssessmentTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateAssessmentTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnCreateAssessmentTop.ForeColor = System.Drawing.Color.White;
        btnCreateAssessmentTop.Location = new System.Drawing.Point(996, 20);
        btnCreateAssessmentTop.Name = "btnCreateAssessmentTop";
        btnCreateAssessmentTop.Size = new System.Drawing.Size(140, 36);
        btnCreateAssessmentTop.TabIndex = 4;
        btnCreateAssessmentTop.Text = "Tạo bài kiểm tra";
        btnCreateAssessmentTop.UseVisualStyleBackColor = false;
        btnCreateAssessmentTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEnterGradesTop
        // 
        btnEnterGradesTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEnterGradesTop.BackColor = System.Drawing.Color.White;
        btnEnterGradesTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEnterGradesTop.CornerRadius = 5;
        btnEnterGradesTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEnterGradesTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnEnterGradesTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEnterGradesTop.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnEnterGradesTop.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnEnterGradesTop.Location = new System.Drawing.Point(880, 20);
        btnEnterGradesTop.Name = "btnEnterGradesTop";
        btnEnterGradesTop.Size = new System.Drawing.Size(106, 36);
        btnEnterGradesTop.TabIndex = 3;
        btnEnterGradesTop.Text = "Nhập điểm";
        btnEnterGradesTop.UseVisualStyleBackColor = false;
        btnEnterGradesTop.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(218, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Kiểm tra & Điểm số";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardCreateAssessment);
        pnlBody.Controls.Add(cardAssessmentList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardCreateAssessment
        // 
        cardCreateAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardCreateAssessment.BackColor = System.Drawing.Color.White;
        cardCreateAssessment.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCreateAssessment.BorderWidth = 1;
        cardCreateAssessment.Controls.Add(btnSaveAssessment);
        cardCreateAssessment.Controls.Add(btnCancelAssessment);
        cardCreateAssessment.Controls.Add(txtWeight);
        cardCreateAssessment.Controls.Add(lblWeight);
        cardCreateAssessment.Controls.Add(txtScale);
        cardCreateAssessment.Controls.Add(lblScale);
        cardCreateAssessment.Controls.Add(dtpExamDate);
        cardCreateAssessment.Controls.Add(lblExamDate);
        cardCreateAssessment.Controls.Add(cboAssessmentType);
        cardCreateAssessment.Controls.Add(lblAssessmentType);
        cardCreateAssessment.Controls.Add(txtAssessmentName);
        cardCreateAssessment.Controls.Add(lblAssessmentName);
        cardCreateAssessment.Controls.Add(cboAssignedClass);
        cardCreateAssessment.Controls.Add(lblAssignedClass);
        cardCreateAssessment.Controls.Add(lblCreateTitle);
        cardCreateAssessment.CornerRadius = 6;
        cardCreateAssessment.Location = new System.Drawing.Point(740, 20);
        cardCreateAssessment.Name = "cardCreateAssessment";
        cardCreateAssessment.Padding = new System.Windows.Forms.Padding(20);
        cardCreateAssessment.Size = new System.Drawing.Size(396, 520);
        cardCreateAssessment.TabIndex = 1;
        // 
        // btnSaveAssessment
        // 
        btnSaveAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveAssessment.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveAssessment.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAssessment.CornerRadius = 5;
        btnSaveAssessment.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAssessment.FlatAppearance.BorderSize = 0;
        btnSaveAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAssessment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveAssessment.ForeColor = System.Drawing.Color.White;
        btnSaveAssessment.Location = new System.Drawing.Point(236, 465);
        btnSaveAssessment.Name = "btnSaveAssessment";
        btnSaveAssessment.Size = new System.Drawing.Size(140, 34);
        btnSaveAssessment.TabIndex = 15;
        btnSaveAssessment.Text = "Lưu bài kiểm tra";
        btnSaveAssessment.UseVisualStyleBackColor = false;
        btnSaveAssessment.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelAssessment
        // 
        btnCancelAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelAssessment.BackColor = System.Drawing.Color.White;
        btnCancelAssessment.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelAssessment.CornerRadius = 5;
        btnCancelAssessment.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelAssessment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelAssessment.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelAssessment.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelAssessment.Location = new System.Drawing.Point(146, 465);
        btnCancelAssessment.Name = "btnCancelAssessment";
        btnCancelAssessment.Size = new System.Drawing.Size(80, 34);
        btnCancelAssessment.TabIndex = 14;
        btnCancelAssessment.Text = "Hủy";
        btnCancelAssessment.UseVisualStyleBackColor = false;
        btnCancelAssessment.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtWeight
        // 
        txtWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtWeight.BackColor = System.Drawing.Color.Transparent;
        txtWeight.CornerRadius = 5;
        txtWeight.ErrorMessage = "";
        txtWeight.HasError = false;
        txtWeight.Location = new System.Drawing.Point(206, 365);
        txtWeight.Name = "txtWeight";
        txtWeight.Placeholder = "50%";
        txtWeight.ReadOnly = false;
        txtWeight.Size = new System.Drawing.Size(170, 32);
        txtWeight.TabIndex = 12;
        txtWeight.UseSystemPasswordChar = false;
        // 
        // lblWeight
        // 
        lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblWeight.AutoSize = true;
        lblWeight.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblWeight.Location = new System.Drawing.Point(206, 345);
        lblWeight.Name = "lblWeight";
        lblWeight.Size = new System.Drawing.Size(81, 20);
        lblWeight.TabIndex = 11;
        lblWeight.Text = "Trọng số *";
        // 
        // txtScale
        // 
        txtScale.BackColor = System.Drawing.Color.Transparent;
        txtScale.CornerRadius = 5;
        txtScale.ErrorMessage = "";
        txtScale.HasError = false;
        txtScale.Location = new System.Drawing.Point(20, 365);
        txtScale.Name = "txtScale";
        txtScale.Placeholder = "10";
        txtScale.ReadOnly = false;
        txtScale.Size = new System.Drawing.Size(170, 32);
        txtScale.TabIndex = 10;
        txtScale.UseSystemPasswordChar = false;
        // 
        // lblScale
        // 
        lblScale.AutoSize = true;
        lblScale.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblScale.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblScale.Location = new System.Drawing.Point(20, 345);
        lblScale.Name = "lblScale";
        lblScale.Size = new System.Drawing.Size(103, 20);
        lblScale.TabIndex = 9;
        lblScale.Text = "Thang điểm *";
        // 
        // dtpExamDate
        // 
        dtpExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        dtpExamDate.CustomFormat = "dd/MM/yyyy";
        dtpExamDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpExamDate.Location = new System.Drawing.Point(206, 290);
        dtpExamDate.Name = "dtpExamDate";
        dtpExamDate.Size = new System.Drawing.Size(170, 27);
        dtpExamDate.TabIndex = 8;
        // 
        // lblExamDate
        // 
        lblExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblExamDate.AutoSize = true;
        lblExamDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblExamDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblExamDate.Location = new System.Drawing.Point(206, 270);
        lblExamDate.Name = "lblExamDate";
        lblExamDate.Size = new System.Drawing.Size(80, 20);
        lblExamDate.TabIndex = 7;
        lblExamDate.Text = "Ngày thi *";
        // 
        // cboAssessmentType
        // 
        cboAssessmentType.BackColor = System.Drawing.Color.Transparent;
        cboAssessmentType.CornerRadius = 5;
        cboAssessmentType.DataSource = null;
        cboAssessmentType.DisplayMember = "";
        cboAssessmentType.Location = new System.Drawing.Point(20, 285);
        cboAssessmentType.Name = "cboAssessmentType";
        cboAssessmentType.SelectedIndex = -1;
        cboAssessmentType.SelectedItem = null;
        cboAssessmentType.SelectedValue = null;
        cboAssessmentType.Size = new System.Drawing.Size(170, 32);
        cboAssessmentType.TabIndex = 6;
        cboAssessmentType.ValueMember = "";
        // 
        // lblAssessmentType
        // 
        lblAssessmentType.AutoSize = true;
        lblAssessmentType.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAssessmentType.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAssessmentType.Location = new System.Drawing.Point(20, 265);
        lblAssessmentType.Name = "lblAssessmentType";
        lblAssessmentType.Size = new System.Drawing.Size(49, 20);
        lblAssessmentType.TabIndex = 5;
        lblAssessmentType.Text = "Loại *";
        // 
        // txtAssessmentName
        // 
        txtAssessmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtAssessmentName.BackColor = System.Drawing.Color.Transparent;
        txtAssessmentName.CornerRadius = 5;
        txtAssessmentName.ErrorMessage = "";
        txtAssessmentName.HasError = false;
        txtAssessmentName.Location = new System.Drawing.Point(20, 210);
        txtAssessmentName.Name = "txtAssessmentName";
        txtAssessmentName.Placeholder = "Kiểm tra cuối khóa";
        txtAssessmentName.ReadOnly = false;
        txtAssessmentName.Size = new System.Drawing.Size(356, 32);
        txtAssessmentName.TabIndex = 4;
        txtAssessmentName.UseSystemPasswordChar = false;
        // 
        // lblAssessmentName
        // 
        lblAssessmentName.AutoSize = true;
        lblAssessmentName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAssessmentName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAssessmentName.Location = new System.Drawing.Point(20, 190);
        lblAssessmentName.Name = "lblAssessmentName";
        lblAssessmentName.Size = new System.Drawing.Size(70, 20);
        lblAssessmentName.TabIndex = 3;
        lblAssessmentName.Text = "Tên bài *";
        // 
        // cboAssignedClass
        // 
        cboAssignedClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboAssignedClass.BackColor = System.Drawing.Color.Transparent;
        cboAssignedClass.CornerRadius = 5;
        cboAssignedClass.DataSource = null;
        cboAssignedClass.DisplayMember = "";
        cboAssignedClass.Location = new System.Drawing.Point(20, 135);
        cboAssignedClass.Name = "cboAssignedClass";
        cboAssignedClass.SelectedIndex = -1;
        cboAssignedClass.SelectedItem = null;
        cboAssignedClass.SelectedValue = null;
        cboAssignedClass.Size = new System.Drawing.Size(356, 32);
        cboAssignedClass.TabIndex = 2;
        cboAssignedClass.ValueMember = "";
        // 
        // lblAssignedClass
        // 
        lblAssignedClass.AutoSize = true;
        lblAssignedClass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblAssignedClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblAssignedClass.Location = new System.Drawing.Point(20, 115);
        lblAssignedClass.Name = "lblAssignedClass";
        lblAssignedClass.Size = new System.Drawing.Size(75, 20);
        lblAssignedClass.TabIndex = 1;
        lblAssignedClass.Text = "Lớp học *";
        // 
        // lblCreateTitle
        // 
        lblCreateTitle.AutoSize = true;
        lblCreateTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblCreateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCreateTitle.Location = new System.Drawing.Point(20, 16);
        lblCreateTitle.Name = "lblCreateTitle";
        lblCreateTitle.Size = new System.Drawing.Size(204, 25);
        lblCreateTitle.TabIndex = 0;
        lblCreateTitle.Text = "Tạo / sửa bài kiểm tra";
        // 
        // cardAssessmentList
        // 
        cardAssessmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardAssessmentList.BackColor = System.Drawing.Color.White;
        cardAssessmentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardAssessmentList.BorderWidth = 1;
        cardAssessmentList.Controls.Add(lblPassingRule);
        cardAssessmentList.Controls.Add(lblRankRule);
        cardAssessmentList.Controls.Add(lblRoundRule);
        cardAssessmentList.Controls.Add(lblFormulaRule);
        cardAssessmentList.Controls.Add(lblPagingNav);
        cardAssessmentList.Controls.Add(lblPagingInfo);
        cardAssessmentList.Controls.Add(dgvAssessments);
        cardAssessmentList.Controls.Add(cboTypeFilter);
        cardAssessmentList.Controls.Add(cboClassFilter);
        cardAssessmentList.Controls.Add(txtSearchAssessment);
        cardAssessmentList.Controls.Add(lblAssessmentListTitle);
        cardAssessmentList.CornerRadius = 6;
        cardAssessmentList.Location = new System.Drawing.Point(24, 20);
        cardAssessmentList.Name = "cardAssessmentList";
        cardAssessmentList.Padding = new System.Windows.Forms.Padding(20);
        cardAssessmentList.Size = new System.Drawing.Size(696, 520);
        cardAssessmentList.TabIndex = 0;
        // 
        // lblPassingRule
        // 
        lblPassingRule.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPassingRule.AutoSize = true;
        lblPassingRule.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPassingRule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPassingRule.Location = new System.Drawing.Point(20, 485);
        lblPassingRule.Name = "lblPassingRule";
        lblPassingRule.Size = new System.Drawing.Size(241, 20);
        lblPassingRule.TabIndex = 11;
        lblPassingRule.Text = "Đạt khóa học:  Trung bình ≥6,5 / 10";
        // 
        // lblRankRule
        // 
        lblRankRule.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblRankRule.AutoSize = true;
        lblRankRule.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblRankRule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblRankRule.Location = new System.Drawing.Point(20, 465);
        lblRankRule.Name = "lblRankRule";
        lblRankRule.Size = new System.Drawing.Size(341, 20);
        lblRankRule.TabIndex = 10;
        lblRankRule.Text = "Xếp loại:  ≥8 Giỏi; ≥6,5 Khá; ≥5 Trung bình; <5 Yếu";
        // 
        // lblRoundRule
        // 
        lblRoundRule.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblRoundRule.AutoSize = true;
        lblRoundRule.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblRoundRule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblRoundRule.Location = new System.Drawing.Point(20, 445);
        lblRoundRule.Name = "lblRoundRule";
        lblRoundRule.Size = new System.Drawing.Size(295, 20);
        lblRoundRule.TabIndex = 9;
        lblRoundRule.Text = "Làm tròn:  1 chữ số thập phân sau tính tổng";
        // 
        // lblFormulaRule
        // 
        lblFormulaRule.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblFormulaRule.AutoSize = true;
        lblFormulaRule.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblFormulaRule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblFormulaRule.Location = new System.Drawing.Point(20, 425);
        lblFormulaRule.Name = "lblFormulaRule";
        lblFormulaRule.Size = new System.Drawing.Size(340, 20);
        lblFormulaRule.TabIndex = 8;
        lblFormulaRule.Text = "Công thức:  TX × 20% + GK × 30% + CK × 50%";
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(516, 335);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(160, 20);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "< Trước   [1]   2   Sau >";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 335);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(138, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–4 / 4 bài kiểm tra";
        // 
        // dgvAssessments
        // 
        dgvAssessments.AllowUserToAddRows = false;
        dgvAssessments.AllowUserToDeleteRows = false;
        dgvAssessments.AllowUserToResizeColumns = false;
        dgvAssessments.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvAssessments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvAssessments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvAssessments.BackgroundColor = System.Drawing.Color.White;
        dgvAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvAssessments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvAssessments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAssessments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvAssessments.DefaultCellStyle = dataGridViewCellStyle3;
        dgvAssessments.EnableHeadersVisualStyles = false;
        dgvAssessments.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvAssessments.Location = new System.Drawing.Point(20, 95);
        dgvAssessments.MultiSelect = false;
        dgvAssessments.Name = "dgvAssessments";
        dgvAssessments.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvAssessments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvAssessments.RowHeadersVisible = false;
        dgvAssessments.RowHeadersWidth = 51;
        dgvAssessments.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvAssessments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvAssessments.Size = new System.Drawing.Size(656, 230);
        dgvAssessments.TabIndex = 4;
        // 
        // cboTypeFilter
        // 
        cboTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboTypeFilter.BackColor = System.Drawing.Color.Transparent;
        cboTypeFilter.CornerRadius = 5;
        cboTypeFilter.DataSource = null;
        cboTypeFilter.DisplayMember = "";
        cboTypeFilter.Location = new System.Drawing.Point(506, 50);
        cboTypeFilter.Name = "cboTypeFilter";
        cboTypeFilter.SelectedIndex = -1;
        cboTypeFilter.SelectedItem = null;
        cboTypeFilter.SelectedValue = null;
        cboTypeFilter.Size = new System.Drawing.Size(170, 32);
        cboTypeFilter.TabIndex = 3;
        cboTypeFilter.ValueMember = "";
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClassFilter.BackColor = System.Drawing.Color.Transparent;
        cboClassFilter.CornerRadius = 5;
        cboClassFilter.DataSource = null;
        cboClassFilter.DisplayMember = "";
        cboClassFilter.Location = new System.Drawing.Point(346, 50);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.SelectedIndex = -1;
        cboClassFilter.SelectedItem = null;
        cboClassFilter.SelectedValue = null;
        cboClassFilter.Size = new System.Drawing.Size(150, 32);
        cboClassFilter.TabIndex = 2;
        cboClassFilter.ValueMember = "";
        // 
        // txtSearchAssessment
        // 
        txtSearchAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearchAssessment.BackColor = System.Drawing.Color.Transparent;
        txtSearchAssessment.CornerRadius = 5;
        txtSearchAssessment.ErrorMessage = "";
        txtSearchAssessment.HasError = false;
        txtSearchAssessment.Location = new System.Drawing.Point(20, 50);
        txtSearchAssessment.Name = "txtSearchAssessment";
        txtSearchAssessment.Placeholder = "Tìm tên bài kiểm tra...";
        txtSearchAssessment.ReadOnly = false;
        txtSearchAssessment.Size = new System.Drawing.Size(316, 32);
        txtSearchAssessment.TabIndex = 1;
        txtSearchAssessment.UseSystemPasswordChar = false;
        // 
        // lblAssessmentListTitle
        // 
        lblAssessmentListTitle.AutoSize = true;
        lblAssessmentListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblAssessmentListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblAssessmentListTitle.Location = new System.Drawing.Point(20, 16);
        lblAssessmentListTitle.Name = "lblAssessmentListTitle";
        lblAssessmentListTitle.Size = new System.Drawing.Size(212, 25);
        lblAssessmentListTitle.TabIndex = 0;
        lblAssessmentListTitle.Text = "Danh sách bài kiểm tra";
        // 
        // TeacherGradeManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCreateAssessment.ResumeLayout(false);
        cardCreateAssessment.PerformLayout();
        cardAssessmentList.ResumeLayout(false);
        cardAssessmentList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAssessments).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnEnterGradesTop;
    private ECMS.UI.Controls.AppButton btnCreateAssessmentTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardAssessmentList;
    private System.Windows.Forms.Label lblAssessmentListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchAssessment;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private ECMS.UI.Controls.AppComboBox cboTypeFilter;
    private ECMS.UI.Controls.AppDataGrid dgvAssessments;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Label lblFormulaRule;
    private System.Windows.Forms.Label lblRoundRule;
    private System.Windows.Forms.Label lblRankRule;
    private System.Windows.Forms.Label lblPassingRule;
    private ECMS.UI.Controls.AppCard cardCreateAssessment;
    private System.Windows.Forms.Label lblCreateTitle;
    private System.Windows.Forms.Label lblAssignedClass;
    private ECMS.UI.Controls.AppComboBox cboAssignedClass;
    private System.Windows.Forms.Label lblAssessmentName;
    private ECMS.UI.Controls.AppTextBox txtAssessmentName;
    private System.Windows.Forms.Label lblAssessmentType;
    private ECMS.UI.Controls.AppComboBox cboAssessmentType;
    private System.Windows.Forms.Label lblExamDate;
    private System.Windows.Forms.DateTimePicker dtpExamDate;
    private System.Windows.Forms.Label lblScale;
    private ECMS.UI.Controls.AppTextBox txtScale;
    private System.Windows.Forms.Label lblWeight;
    private ECMS.UI.Controls.AppTextBox txtWeight;
    private ECMS.UI.Controls.AppButton btnCancelAssessment;
    private ECMS.UI.Controls.AppButton btnSaveAssessment;
}
