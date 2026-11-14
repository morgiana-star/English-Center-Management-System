namespace ECMS.UI.Forms;

partial class CourseEditDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        cardRules = new ECMS.UI.Controls.AppCard();
        lblAttendanceVal = new System.Windows.Forms.Label();
        lblAttendanceKey = new System.Windows.Forms.Label();
        lblPassScoreVal = new System.Windows.Forms.Label();
        lblPassScoreKey = new System.Windows.Forms.Label();
        lblTotalWeightVal = new System.Windows.Forms.Label();
        lblTotalWeightKey = new System.Windows.Forms.Label();
        lblFinalWeightVal = new System.Windows.Forms.Label();
        lblFinalWeightKey = new System.Windows.Forms.Label();
        lblMidtermWeightVal = new System.Windows.Forms.Label();
        lblMidtermWeightKey = new System.Windows.Forms.Label();
        lblRegularWeightVal = new System.Windows.Forms.Label();
        lblRegularWeightKey = new System.Windows.Forms.Label();
        lblGradingScaleVal = new System.Windows.Forms.Label();
        lblGradingScaleKey = new System.Windows.Forms.Label();
        lblRulesTitle = new System.Windows.Forms.Label();
        cardProgramInfo = new ECMS.UI.Controls.AppCard();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        txtDescription = new ECMS.UI.Controls.AppTextBox();
        lblDescription = new System.Windows.Forms.Label();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        txtTuitionFee = new ECMS.UI.Controls.AppTextBox();
        lblTuitionFee = new System.Windows.Forms.Label();
        txtSessionDuration = new ECMS.UI.Controls.AppTextBox();
        lblSessionDuration = new System.Windows.Forms.Label();
        txtSessionCount = new ECMS.UI.Controls.AppTextBox();
        lblSessionCount = new System.Windows.Forms.Label();
        txtOutputTarget = new ECMS.UI.Controls.AppTextBox();
        lblOutputTarget = new System.Windows.Forms.Label();
        cboInputLevel = new ECMS.UI.Controls.AppComboBox();
        lblInputLevel = new System.Windows.Forms.Label();
        txtCourseName = new ECMS.UI.Controls.AppTextBox();
        lblCourseName = new System.Windows.Forms.Label();
        txtCourseCode = new ECMS.UI.Controls.AppTextBox();
        lblCourseCode = new System.Windows.Forms.Label();
        lblProgramInfoTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        cardRules.SuspendLayout();
        cardProgramInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(264, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thông tin khóa học";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.Controls.Add(cardRules);
        pnlContent.Controls.Add(cardProgramInfo);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 75);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(1220, 685);
        pnlContent.TabIndex = 1;
        // 
        // cardRules
        // 
        cardRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardRules.BackColor = System.Drawing.Color.White;
        cardRules.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRules.BorderWidth = 1;
        cardRules.Controls.Add(lblAttendanceVal);
        cardRules.Controls.Add(lblAttendanceKey);
        cardRules.Controls.Add(lblPassScoreVal);
        cardRules.Controls.Add(lblPassScoreKey);
        cardRules.Controls.Add(lblTotalWeightVal);
        cardRules.Controls.Add(lblTotalWeightKey);
        cardRules.Controls.Add(lblFinalWeightVal);
        cardRules.Controls.Add(lblFinalWeightKey);
        cardRules.Controls.Add(lblMidtermWeightVal);
        cardRules.Controls.Add(lblMidtermWeightKey);
        cardRules.Controls.Add(lblRegularWeightVal);
        cardRules.Controls.Add(lblRegularWeightKey);
        cardRules.Controls.Add(lblGradingScaleVal);
        cardRules.Controls.Add(lblGradingScaleKey);
        cardRules.Controls.Add(lblRulesTitle);
        cardRules.CornerRadius = 6;
        cardRules.Location = new System.Drawing.Point(860, 24);
        cardRules.Name = "cardRules";
        cardRules.Padding = new System.Windows.Forms.Padding(20);
        cardRules.Size = new System.Drawing.Size(336, 440);
        cardRules.TabIndex = 1;
        // 
        // lblAttendanceVal
        // 
        lblAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblAttendanceVal.Location = new System.Drawing.Point(180, 260);
        lblAttendanceVal.Name = "lblAttendanceVal";
        lblAttendanceVal.Size = new System.Drawing.Size(130, 20);
        lblAttendanceVal.TabIndex = 14;
        lblAttendanceVal.Text = "≥ 80%";
        lblAttendanceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblAttendanceKey
        // 
        lblAttendanceKey.AutoSize = true;
        lblAttendanceKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAttendanceKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblAttendanceKey.Location = new System.Drawing.Point(20, 262);
        lblAttendanceKey.Name = "lblAttendanceKey";
        lblAttendanceKey.Size = new System.Drawing.Size(84, 20);
        lblAttendanceKey.TabIndex = 13;
        lblAttendanceKey.Text = "Chuyên cần";
        // 
        // lblPassScoreVal
        // 
        lblPassScoreVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblPassScoreVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblPassScoreVal.Location = new System.Drawing.Point(180, 225);
        lblPassScoreVal.Name = "lblPassScoreVal";
        lblPassScoreVal.Size = new System.Drawing.Size(130, 20);
        lblPassScoreVal.TabIndex = 12;
        lblPassScoreVal.Text = "≥ 6,5 / 10";
        lblPassScoreVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPassScoreKey
        // 
        lblPassScoreKey.AutoSize = true;
        lblPassScoreKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPassScoreKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPassScoreKey.Location = new System.Drawing.Point(20, 227);
        lblPassScoreKey.Name = "lblPassScoreKey";
        lblPassScoreKey.Size = new System.Drawing.Size(71, 20);
        lblPassScoreKey.TabIndex = 11;
        lblPassScoreKey.Text = "Điểm đạt";
        // 
        // lblTotalWeightVal
        // 
        lblTotalWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblTotalWeightVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTotalWeightVal.Location = new System.Drawing.Point(180, 190);
        lblTotalWeightVal.Name = "lblTotalWeightVal";
        lblTotalWeightVal.Size = new System.Drawing.Size(130, 20);
        lblTotalWeightVal.TabIndex = 10;
        lblTotalWeightVal.Text = "100%";
        lblTotalWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTotalWeightKey
        // 
        lblTotalWeightKey.AutoSize = true;
        lblTotalWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTotalWeightKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTotalWeightKey.Location = new System.Drawing.Point(20, 192);
        lblTotalWeightKey.Name = "lblTotalWeightKey";
        lblTotalWeightKey.Size = new System.Drawing.Size(102, 20);
        lblTotalWeightKey.TabIndex = 9;
        lblTotalWeightKey.Text = "Tổng trọng số";
        // 
        // lblFinalWeightVal
        // 
        lblFinalWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblFinalWeightVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblFinalWeightVal.Location = new System.Drawing.Point(180, 155);
        lblFinalWeightVal.Name = "lblFinalWeightVal";
        lblFinalWeightVal.Size = new System.Drawing.Size(130, 20);
        lblFinalWeightVal.TabIndex = 8;
        lblFinalWeightVal.Text = "50%";
        lblFinalWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblFinalWeightKey
        // 
        lblFinalWeightKey.AutoSize = true;
        lblFinalWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFinalWeightKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblFinalWeightKey.Location = new System.Drawing.Point(20, 157);
        lblFinalWeightKey.Name = "lblFinalWeightKey";
        lblFinalWeightKey.Size = new System.Drawing.Size(75, 20);
        lblFinalWeightKey.TabIndex = 7;
        lblFinalWeightKey.Text = "Cuối khóa";
        // 
        // lblMidtermWeightVal
        // 
        lblMidtermWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblMidtermWeightVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblMidtermWeightVal.Location = new System.Drawing.Point(180, 120);
        lblMidtermWeightVal.Name = "lblMidtermWeightVal";
        lblMidtermWeightVal.Size = new System.Drawing.Size(130, 20);
        lblMidtermWeightVal.TabIndex = 6;
        lblMidtermWeightVal.Text = "30%";
        lblMidtermWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblMidtermWeightKey
        // 
        lblMidtermWeightKey.AutoSize = true;
        lblMidtermWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblMidtermWeightKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblMidtermWeightKey.Location = new System.Drawing.Point(20, 122);
        lblMidtermWeightKey.Name = "lblMidtermWeightKey";
        lblMidtermWeightKey.Size = new System.Drawing.Size(76, 20);
        lblMidtermWeightKey.TabIndex = 5;
        lblMidtermWeightKey.Text = "Giữa khóa";
        // 
        // lblRegularWeightVal
        // 
        lblRegularWeightVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblRegularWeightVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblRegularWeightVal.Location = new System.Drawing.Point(180, 85);
        lblRegularWeightVal.Name = "lblRegularWeightVal";
        lblRegularWeightVal.Size = new System.Drawing.Size(130, 20);
        lblRegularWeightVal.TabIndex = 4;
        lblRegularWeightVal.Text = "20%";
        lblRegularWeightVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblRegularWeightKey
        // 
        lblRegularWeightKey.AutoSize = true;
        lblRegularWeightKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblRegularWeightKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblRegularWeightKey.Location = new System.Drawing.Point(20, 87);
        lblRegularWeightKey.Name = "lblRegularWeightKey";
        lblRegularWeightKey.Size = new System.Drawing.Size(102, 20);
        lblRegularWeightKey.TabIndex = 3;
        lblRegularWeightKey.Text = "Thường xuyên";
        // 
        // lblGradingScaleVal
        // 
        lblGradingScaleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblGradingScaleVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblGradingScaleVal.Location = new System.Drawing.Point(180, 50);
        lblGradingScaleVal.Name = "lblGradingScaleVal";
        lblGradingScaleVal.Size = new System.Drawing.Size(130, 20);
        lblGradingScaleVal.TabIndex = 2;
        lblGradingScaleVal.Text = "0–10";
        lblGradingScaleVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGradingScaleKey
        // 
        lblGradingScaleKey.AutoSize = true;
        lblGradingScaleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblGradingScaleKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblGradingScaleKey.Location = new System.Drawing.Point(20, 52);
        lblGradingScaleKey.Name = "lblGradingScaleKey";
        lblGradingScaleKey.Size = new System.Drawing.Size(88, 20);
        lblGradingScaleKey.TabIndex = 1;
        lblGradingScaleKey.Text = "Thang điểm";
        // 
        // lblRulesTitle
        // 
        lblRulesTitle.AutoSize = true;
        lblRulesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblRulesTitle.Location = new System.Drawing.Point(20, 16);
        lblRulesTitle.Name = "lblRulesTitle";
        lblRulesTitle.Size = new System.Drawing.Size(179, 28);
        lblRulesTitle.TabIndex = 0;
        lblRulesTitle.Text = "Quy tắc mặc định";
        // 
        // cardProgramInfo
        // 
        cardProgramInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardProgramInfo.BackColor = System.Drawing.Color.White;
        cardProgramInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardProgramInfo.BorderWidth = 1;
        cardProgramInfo.Controls.Add(btnSave);
        cardProgramInfo.Controls.Add(btnCancel);
        cardProgramInfo.Controls.Add(txtDescription);
        cardProgramInfo.Controls.Add(lblDescription);
        cardProgramInfo.Controls.Add(cboStatus);
        cardProgramInfo.Controls.Add(lblStatus);
        cardProgramInfo.Controls.Add(txtTuitionFee);
        cardProgramInfo.Controls.Add(lblTuitionFee);
        cardProgramInfo.Controls.Add(txtSessionDuration);
        cardProgramInfo.Controls.Add(lblSessionDuration);
        cardProgramInfo.Controls.Add(txtSessionCount);
        cardProgramInfo.Controls.Add(lblSessionCount);
        cardProgramInfo.Controls.Add(txtOutputTarget);
        cardProgramInfo.Controls.Add(lblOutputTarget);
        cardProgramInfo.Controls.Add(cboInputLevel);
        cardProgramInfo.Controls.Add(lblInputLevel);
        cardProgramInfo.Controls.Add(txtCourseName);
        cardProgramInfo.Controls.Add(lblCourseName);
        cardProgramInfo.Controls.Add(txtCourseCode);
        cardProgramInfo.Controls.Add(lblCourseCode);
        cardProgramInfo.Controls.Add(lblProgramInfoTitle);
        cardProgramInfo.CornerRadius = 6;
        cardProgramInfo.Location = new System.Drawing.Point(24, 24);
        cardProgramInfo.Name = "cardProgramInfo";
        cardProgramInfo.Padding = new System.Windows.Forms.Padding(24);
        cardProgramInfo.Size = new System.Drawing.Size(815, 620);
        cardProgramInfo.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 5;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(681, 557);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(110, 36);
        btnSave.TabIndex = 20;
        btnSave.Text = "Lưu";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancel.Location = new System.Drawing.Point(585, 557);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 36);
        btnCancel.TabIndex = 19;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtDescription
        // 
        txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDescription.BackColor = System.Drawing.Color.Transparent;
        txtDescription.CornerRadius = 5;
        txtDescription.ErrorMessage = "";
        txtDescription.HasError = false;
        txtDescription.Location = new System.Drawing.Point(24, 385);
        txtDescription.Name = "txtDescription";
        txtDescription.Placeholder = "Nhập tóm tắt mô tả chương trình học, nội dung cốt lõi...";
        txtDescription.ReadOnly = false;
        txtDescription.Size = new System.Drawing.Size(767, 75);
        txtDescription.TabIndex = 18;
        txtDescription.UseSystemPasswordChar = false;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblDescription.Location = new System.Drawing.Point(24, 365);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new System.Drawing.Size(156, 20);
        lblDescription.TabIndex = 17;
        lblDescription.Text = "Mô tả / nội dung học";
        // 
        // cboStatus
        // 
        cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatus.BackColor = System.Drawing.Color.Transparent;
        cboStatus.CornerRadius = 5;
        cboStatus.DataSource = null;
        cboStatus.DisplayMember = "";
        cboStatus.Location = new System.Drawing.Point(415, 305);
        cboStatus.Name = "cboStatus";
        cboStatus.SelectedIndex = -1;
        cboStatus.SelectedItem = null;
        cboStatus.SelectedValue = null;
        cboStatus.Size = new System.Drawing.Size(376, 35);
        cboStatus.TabIndex = 16;
        cboStatus.ValueMember = "";
        // 
        // lblStatus
        // 
        lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblStatus.Location = new System.Drawing.Point(415, 285);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(91, 20);
        lblStatus.TabIndex = 15;
        lblStatus.Text = "Trạng thái *";
        // 
        // txtTuitionFee
        // 
        txtTuitionFee.BackColor = System.Drawing.Color.Transparent;
        txtTuitionFee.CornerRadius = 5;
        txtTuitionFee.ErrorMessage = "";
        txtTuitionFee.HasError = false;
        txtTuitionFee.Location = new System.Drawing.Point(24, 305);
        txtTuitionFee.Name = "txtTuitionFee";
        txtTuitionFee.Placeholder = "Ví dụ: 6.000.000";
        txtTuitionFee.ReadOnly = false;
        txtTuitionFee.Size = new System.Drawing.Size(370, 35);
        txtTuitionFee.TabIndex = 14;
        txtTuitionFee.UseSystemPasswordChar = false;
        // 
        // lblTuitionFee
        // 
        lblTuitionFee.AutoSize = true;
        lblTuitionFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTuitionFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblTuitionFee.Location = new System.Drawing.Point(24, 285);
        lblTuitionFee.Name = "lblTuitionFee";
        lblTuitionFee.Size = new System.Drawing.Size(102, 20);
        lblTuitionFee.TabIndex = 13;
        lblTuitionFee.Text = "Học phí gốc *";
        // 
        // txtSessionDuration
        // 
        txtSessionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtSessionDuration.BackColor = System.Drawing.Color.Transparent;
        txtSessionDuration.CornerRadius = 5;
        txtSessionDuration.ErrorMessage = "";
        txtSessionDuration.HasError = false;
        txtSessionDuration.Location = new System.Drawing.Point(415, 225);
        txtSessionDuration.Name = "txtSessionDuration";
        txtSessionDuration.Placeholder = "Ví dụ: 120 phút";
        txtSessionDuration.ReadOnly = false;
        txtSessionDuration.Size = new System.Drawing.Size(376, 35);
        txtSessionDuration.TabIndex = 12;
        txtSessionDuration.UseSystemPasswordChar = false;
        // 
        // lblSessionDuration
        // 
        lblSessionDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblSessionDuration.AutoSize = true;
        lblSessionDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSessionDuration.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblSessionDuration.Location = new System.Drawing.Point(415, 205);
        lblSessionDuration.Name = "lblSessionDuration";
        lblSessionDuration.Size = new System.Drawing.Size(142, 20);
        lblSessionDuration.TabIndex = 11;
        lblSessionDuration.Text = "Thời lượng / buổi *";
        // 
        // txtSessionCount
        // 
        txtSessionCount.BackColor = System.Drawing.Color.Transparent;
        txtSessionCount.CornerRadius = 5;
        txtSessionCount.ErrorMessage = "";
        txtSessionCount.HasError = false;
        txtSessionCount.Location = new System.Drawing.Point(24, 225);
        txtSessionCount.Name = "txtSessionCount";
        txtSessionCount.Placeholder = "Ví dụ: 24";
        txtSessionCount.ReadOnly = false;
        txtSessionCount.Size = new System.Drawing.Size(370, 35);
        txtSessionCount.TabIndex = 10;
        txtSessionCount.UseSystemPasswordChar = false;
        // 
        // lblSessionCount
        // 
        lblSessionCount.AutoSize = true;
        lblSessionCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSessionCount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblSessionCount.Location = new System.Drawing.Point(24, 205);
        lblSessionCount.Name = "lblSessionCount";
        lblSessionCount.Size = new System.Drawing.Size(72, 20);
        lblSessionCount.TabIndex = 9;
        lblSessionCount.Text = "Số buổi *";
        // 
        // txtOutputTarget
        // 
        txtOutputTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtOutputTarget.BackColor = System.Drawing.Color.Transparent;
        txtOutputTarget.CornerRadius = 5;
        txtOutputTarget.ErrorMessage = "";
        txtOutputTarget.HasError = false;
        txtOutputTarget.Location = new System.Drawing.Point(415, 145);
        txtOutputTarget.Name = "txtOutputTarget";
        txtOutputTarget.Placeholder = "Ví dụ: Nền tảng IELTS 4.0–4.5";
        txtOutputTarget.ReadOnly = false;
        txtOutputTarget.Size = new System.Drawing.Size(376, 35);
        txtOutputTarget.TabIndex = 8;
        txtOutputTarget.UseSystemPasswordChar = false;
        // 
        // lblOutputTarget
        // 
        lblOutputTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblOutputTarget.AutoSize = true;
        lblOutputTarget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblOutputTarget.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblOutputTarget.Location = new System.Drawing.Point(415, 125);
        lblOutputTarget.Name = "lblOutputTarget";
        lblOutputTarget.Size = new System.Drawing.Size(129, 20);
        lblOutputTarget.TabIndex = 7;
        lblOutputTarget.Text = "Mục tiêu đầu ra *";
        // 
        // cboInputLevel
        // 
        cboInputLevel.BackColor = System.Drawing.Color.Transparent;
        cboInputLevel.CornerRadius = 5;
        cboInputLevel.DataSource = null;
        cboInputLevel.DisplayMember = "";
        cboInputLevel.Location = new System.Drawing.Point(24, 145);
        cboInputLevel.Name = "cboInputLevel";
        cboInputLevel.SelectedIndex = -1;
        cboInputLevel.SelectedItem = null;
        cboInputLevel.SelectedValue = null;
        cboInputLevel.Size = new System.Drawing.Size(370, 35);
        cboInputLevel.TabIndex = 6;
        cboInputLevel.ValueMember = "";
        // 
        // lblInputLevel
        // 
        lblInputLevel.AutoSize = true;
        lblInputLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblInputLevel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblInputLevel.Location = new System.Drawing.Point(24, 125);
        lblInputLevel.Name = "lblInputLevel";
        lblInputLevel.Size = new System.Drawing.Size(137, 20);
        lblInputLevel.TabIndex = 5;
        lblInputLevel.Text = "Trình độ đầu vào *";
        // 
        // txtCourseName
        // 
        txtCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtCourseName.BackColor = System.Drawing.Color.Transparent;
        txtCourseName.CornerRadius = 5;
        txtCourseName.ErrorMessage = "";
        txtCourseName.HasError = false;
        txtCourseName.Location = new System.Drawing.Point(415, 68);
        txtCourseName.Name = "txtCourseName";
        txtCourseName.Placeholder = "Ví dụ: IELTS Foundation";
        txtCourseName.ReadOnly = false;
        txtCourseName.Size = new System.Drawing.Size(376, 35);
        txtCourseName.TabIndex = 4;
        txtCourseName.UseSystemPasswordChar = false;
        // 
        // lblCourseName
        // 
        lblCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblCourseName.AutoSize = true;
        lblCourseName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblCourseName.Location = new System.Drawing.Point(415, 48);
        lblCourseName.Name = "lblCourseName";
        lblCourseName.Size = new System.Drawing.Size(112, 20);
        lblCourseName.TabIndex = 3;
        lblCourseName.Text = "Tên khóa học *";
        // 
        // txtCourseCode
        // 
        txtCourseCode.BackColor = System.Drawing.Color.Transparent;
        txtCourseCode.CornerRadius = 5;
        txtCourseCode.ErrorMessage = "";
        txtCourseCode.HasError = false;
        txtCourseCode.Location = new System.Drawing.Point(24, 68);
        txtCourseCode.Name = "txtCourseCode";
        txtCourseCode.Placeholder = "Ví dụ: CT-IELTS-F";
        txtCourseCode.ReadOnly = false;
        txtCourseCode.Size = new System.Drawing.Size(370, 35);
        txtCourseCode.TabIndex = 2;
        txtCourseCode.UseSystemPasswordChar = false;
        // 
        // lblCourseCode
        // 
        lblCourseCode.AutoSize = true;
        lblCourseCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblCourseCode.Location = new System.Drawing.Point(24, 48);
        lblCourseCode.Name = "lblCourseCode";
        lblCourseCode.Size = new System.Drawing.Size(109, 20);
        lblCourseCode.TabIndex = 1;
        lblCourseCode.Text = "Mã khóa học *";
        // 
        // lblProgramInfoTitle
        // 
        lblProgramInfoTitle.AutoSize = true;
        lblProgramInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblProgramInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblProgramInfoTitle.Location = new System.Drawing.Point(24, 16);
        lblProgramInfoTitle.Name = "lblProgramInfoTitle";
        lblProgramInfoTitle.Size = new System.Drawing.Size(234, 28);
        lblProgramInfoTitle.TabIndex = 0;
        lblProgramInfoTitle.Text = "Thông tin chương trình";
        // 
        // CourseEditDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thông tin khóa học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        cardRules.ResumeLayout(false);
        cardRules.PerformLayout();
        cardProgramInfo.ResumeLayout(false);
        cardProgramInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlContent;
    private ECMS.UI.Controls.AppCard cardProgramInfo;
    private System.Windows.Forms.Label lblProgramInfoTitle;
    private System.Windows.Forms.Label lblCourseCode;
    private ECMS.UI.Controls.AppTextBox txtCourseCode;
    private System.Windows.Forms.Label lblCourseName;
    private ECMS.UI.Controls.AppTextBox txtCourseName;
    private System.Windows.Forms.Label lblInputLevel;
    private ECMS.UI.Controls.AppComboBox cboInputLevel;
    private System.Windows.Forms.Label lblOutputTarget;
    private ECMS.UI.Controls.AppTextBox txtOutputTarget;
    private System.Windows.Forms.Label lblSessionCount;
    private ECMS.UI.Controls.AppTextBox txtSessionCount;
    private System.Windows.Forms.Label lblSessionDuration;
    private ECMS.UI.Controls.AppTextBox txtSessionDuration;
    private System.Windows.Forms.Label lblTuitionFee;
    private ECMS.UI.Controls.AppTextBox txtTuitionFee;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private System.Windows.Forms.Label lblDescription;
    private ECMS.UI.Controls.AppTextBox txtDescription;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppCard cardRules;
    private System.Windows.Forms.Label lblRulesTitle;
    private System.Windows.Forms.Label lblGradingScaleKey;
    private System.Windows.Forms.Label lblGradingScaleVal;
    private System.Windows.Forms.Label lblRegularWeightKey;
    private System.Windows.Forms.Label lblRegularWeightVal;
    private System.Windows.Forms.Label lblMidtermWeightKey;
    private System.Windows.Forms.Label lblMidtermWeightVal;
    private System.Windows.Forms.Label lblFinalWeightKey;
    private System.Windows.Forms.Label lblFinalWeightVal;
    private System.Windows.Forms.Label lblTotalWeightKey;
    private System.Windows.Forms.Label lblTotalWeightVal;
    private System.Windows.Forms.Label lblPassScoreKey;
    private System.Windows.Forms.Label lblPassScoreVal;
    private System.Windows.Forms.Label lblAttendanceKey;
    private System.Windows.Forms.Label lblAttendanceVal;
}
