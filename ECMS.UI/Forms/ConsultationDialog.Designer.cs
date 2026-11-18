namespace ECMS.UI.Forms;

partial class ConsultationDialog
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
        pnlTop = new System.Windows.Forms.Panel();
        btnNextToEnroll = new ECMS.UI.Controls.AppButton();
        btnEditLeadInfo = new ECMS.UI.Controls.AppButton();
        lblConsultLeadMeta = new System.Windows.Forms.Label();
        lblConsultLeadName = new System.Windows.Forms.Label();
        cardConsultSummary = new ECMS.UI.Controls.AppCard();
        lblSumReady = new System.Windows.Forms.Label();
        lblSumFinalFee = new System.Windows.Forms.Label();
        lblSumDiscount = new System.Windows.Forms.Label();
        lblSumFee = new System.Windows.Forms.Label();
        lblSumDuration = new System.Windows.Forms.Label();
        lblSumProgram = new System.Windows.Forms.Label();
        lblSumPhone = new System.Windows.Forms.Label();
        lblSumParent = new System.Windows.Forms.Label();
        lblSumDob = new System.Windows.Forms.Label();
        lblSumStudent = new System.Windows.Forms.Label();
        lblSummaryTitle = new System.Windows.Forms.Label();
        cardPlacementTest = new ECMS.UI.Controls.AppCard();
        bannerTestRecommend = new ECMS.UI.Controls.AppBanner();
        cboRecommendedCourse = new ECMS.UI.Controls.AppComboBox();
        lblRecommendedCourse = new System.Windows.Forms.Label();
        cboTestEvaluator = new ECMS.UI.Controls.AppComboBox();
        lblTestEvaluator = new System.Windows.Forms.Label();
        txtTestScore = new ECMS.UI.Controls.AppTextBox();
        lblTestScore = new System.Windows.Forms.Label();
        txtTestName = new ECMS.UI.Controls.AppTextBox();
        lblTestName = new System.Windows.Forms.Label();
        lblTestTitle = new System.Windows.Forms.Label();
        cardConsultHistory = new ECMS.UI.Controls.AppCard();
        btnSaveConsult = new ECMS.UI.Controls.AppButton();
        btnCancelConsult = new ECMS.UI.Controls.AppButton();
        txtNewConsult = new ECMS.UI.Controls.AppTextBox();
        lblNewConsult = new System.Windows.Forms.Label();
        dgvConsultHistory = new ECMS.UI.Controls.AppDataGrid();
        lblHistoryTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        cardConsultSummary.SuspendLayout();
        cardPlacementTest.SuspendLayout();
        cardConsultHistory.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConsultHistory).BeginInit();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(btnNextToEnroll);
        pnlTop.Controls.Add(btnEditLeadInfo);
        pnlTop.Controls.Add(lblConsultLeadMeta);
        pnlTop.Controls.Add(lblConsultLeadName);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1220, 75);
        pnlTop.TabIndex = 0;
        // 
        // btnNextToEnroll
        // 
        btnNextToEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnNextToEnroll.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnNextToEnroll.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnNextToEnroll.CornerRadius = 6;
        btnNextToEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNextToEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNextToEnroll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnNextToEnroll.ForeColor = System.Drawing.Color.White;
        btnNextToEnroll.Location = new System.Drawing.Point(1000, 18);
        btnNextToEnroll.Name = "btnNextToEnroll";
        btnNextToEnroll.Size = new System.Drawing.Size(195, 36);
        btnNextToEnroll.TabIndex = 3;
        btnNextToEnroll.Text = "Tiếp tục ghi danh →";
        btnNextToEnroll.UseVisualStyleBackColor = false;
        btnNextToEnroll.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEditLeadInfo
        // 
        btnEditLeadInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEditLeadInfo.BackColor = System.Drawing.Color.White;
        btnEditLeadInfo.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEditLeadInfo.CornerRadius = 6;
        btnEditLeadInfo.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEditLeadInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEditLeadInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnEditLeadInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnEditLeadInfo.Location = new System.Drawing.Point(884, 20);
        btnEditLeadInfo.Name = "btnEditLeadInfo";
        btnEditLeadInfo.Size = new System.Drawing.Size(110, 36);
        btnEditLeadInfo.TabIndex = 2;
        btnEditLeadInfo.Text = "Sửa thông tin";
        btnEditLeadInfo.UseVisualStyleBackColor = false;
        btnEditLeadInfo.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblConsultLeadMeta
        // 
        lblConsultLeadMeta.AutoSize = true;
        lblConsultLeadMeta.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblConsultLeadMeta.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblConsultLeadMeta.Location = new System.Drawing.Point(24, 45);
        lblConsultLeadMeta.Name = "lblConsultLeadMeta";
        lblConsultLeadMeta.Size = new System.Drawing.Size(352, 20);
        lblConsultLeadMeta.TabIndex = 1;
        lblConsultLeadMeta.Text = "0908 123 456 · Tư vấn: Phạm Ngọc Mai · 02/10/2026";
        // 
        // lblConsultLeadName
        // 
        lblConsultLeadName.AutoSize = true;
        lblConsultLeadName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblConsultLeadName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblConsultLeadName.Location = new System.Drawing.Point(22, 10);
        lblConsultLeadName.Name = "lblConsultLeadName";
        lblConsultLeadName.Size = new System.Drawing.Size(352, 35);
        lblConsultLeadName.TabIndex = 0;
        lblConsultLeadName.Text = "Nguyễn Minh Anh · TN-0108";
        // 
        // cardConsultSummary
        // 
        cardConsultSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardConsultSummary.BackColor = System.Drawing.Color.White;
        cardConsultSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardConsultSummary.BorderWidth = 1;
        cardConsultSummary.Controls.Add(lblSumReady);
        cardConsultSummary.Controls.Add(lblSumFinalFee);
        cardConsultSummary.Controls.Add(lblSumDiscount);
        cardConsultSummary.Controls.Add(lblSumFee);
        cardConsultSummary.Controls.Add(lblSumDuration);
        cardConsultSummary.Controls.Add(lblSumProgram);
        cardConsultSummary.Controls.Add(lblSumPhone);
        cardConsultSummary.Controls.Add(lblSumParent);
        cardConsultSummary.Controls.Add(lblSumDob);
        cardConsultSummary.Controls.Add(lblSumStudent);
        cardConsultSummary.Controls.Add(lblSummaryTitle);
        cardConsultSummary.CornerRadius = 8;
        cardConsultSummary.Location = new System.Drawing.Point(795, 95);
        cardConsultSummary.Name = "cardConsultSummary";
        cardConsultSummary.Padding = new System.Windows.Forms.Padding(16);
        cardConsultSummary.Size = new System.Drawing.Size(400, 640);
        cardConsultSummary.TabIndex = 3;
        // 
        // lblSumReady
        // 
        lblSumReady.AutoSize = true;
        lblSumReady.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblSumReady.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblSumReady.Location = new System.Drawing.Point(20, 420);
        lblSumReady.Name = "lblSumReady";
        lblSumReady.Size = new System.Drawing.Size(176, 23);
        lblSumReady.TabIndex = 10;
        lblSumReady.Text = "✓ Sẵn sàng ghi danh";
        // 
        // lblSumFinalFee
        // 
        lblSumFinalFee.AutoSize = true;
        lblSumFinalFee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblSumFinalFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblSumFinalFee.Location = new System.Drawing.Point(20, 365);
        lblSumFinalFee.Name = "lblSumFinalFee";
        lblSumFinalFee.Size = new System.Drawing.Size(275, 25);
        lblSumFinalFee.TabIndex = 9;
        lblSumFinalFee.Text = "Học phí thực thu:  5.400.000đ";
        // 
        // lblSumDiscount
        // 
        lblSumDiscount.AutoSize = true;
        lblSumDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumDiscount.Location = new System.Drawing.Point(20, 330);
        lblSumDiscount.Name = "lblSumDiscount";
        lblSumDiscount.Size = new System.Drawing.Size(229, 21);
        lblSumDiscount.TabIndex = 8;
        lblSumDiscount.Text = "Ưu đãi dự kiến:  600.000đ · 10%";
        // 
        // lblSumFee
        // 
        lblSumFee.AutoSize = true;
        lblSumFee.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumFee.Location = new System.Drawing.Point(20, 295);
        lblSumFee.Name = "lblSumFee";
        lblSumFee.Size = new System.Drawing.Size(181, 21);
        lblSumFee.TabIndex = 7;
        lblSumFee.Text = "Học phí gốc:  6.000.000đ";
        // 
        // lblSumDuration
        // 
        lblSumDuration.AutoSize = true;
        lblSumDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumDuration.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumDuration.Location = new System.Drawing.Point(20, 255);
        lblSumDuration.Name = "lblSumDuration";
        lblSumDuration.Size = new System.Drawing.Size(206, 21);
        lblSumDuration.TabIndex = 6;
        lblSumDuration.Text = "Thời lượng:  24 buổi · 48 giờ";
        // 
        // lblSumProgram
        // 
        lblSumProgram.AutoSize = true;
        lblSumProgram.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumProgram.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumProgram.Location = new System.Drawing.Point(20, 220);
        lblSumProgram.Name = "lblSumProgram";
        lblSumProgram.Size = new System.Drawing.Size(233, 21);
        lblSumProgram.TabIndex = 5;
        lblSumProgram.Text = "Chương trình:  IELTS Foundation";
        // 
        // lblSumPhone
        // 
        lblSumPhone.AutoSize = true;
        lblSumPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumPhone.Location = new System.Drawing.Point(20, 175);
        lblSumPhone.Name = "lblSumPhone";
        lblSumPhone.Size = new System.Drawing.Size(214, 21);
        lblSumPhone.TabIndex = 4;
        lblSumPhone.Text = "Điện thoại PH:  0911 556 889";
        // 
        // lblSumParent
        // 
        lblSumParent.AutoSize = true;
        lblSumParent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumParent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumParent.Location = new System.Drawing.Point(20, 140);
        lblSumParent.Name = "lblSumParent";
        lblSumParent.Size = new System.Drawing.Size(233, 21);
        lblSumParent.TabIndex = 3;
        lblSumParent.Text = "Phụ huynh:  Nguyễn Thu Hương";
        // 
        // lblSumDob
        // 
        lblSumDob.AutoSize = true;
        lblSumDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblSumDob.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSumDob.Location = new System.Drawing.Point(20, 105);
        lblSumDob.Name = "lblSumDob";
        lblSumDob.Size = new System.Drawing.Size(175, 21);
        lblSumDob.TabIndex = 2;
        lblSumDob.Text = "Ngày sinh:  18/06/2008";
        // 
        // lblSumStudent
        // 
        lblSumStudent.AutoSize = true;
        lblSumStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblSumStudent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSumStudent.Location = new System.Drawing.Point(20, 70);
        lblSumStudent.Name = "lblSumStudent";
        lblSumStudent.Size = new System.Drawing.Size(239, 23);
        lblSumStudent.TabIndex = 1;
        lblSumStudent.Text = "Học viên:  Nguyễn Minh Anh";
        // 
        // lblSummaryTitle
        // 
        lblSummaryTitle.AutoSize = true;
        lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSummaryTitle.Location = new System.Drawing.Point(20, 16);
        lblSummaryTitle.Name = "lblSummaryTitle";
        lblSummaryTitle.Size = new System.Drawing.Size(174, 28);
        lblSummaryTitle.TabIndex = 0;
        lblSummaryTitle.Text = "Tóm tắt ghi danh";
        // 
        // cardPlacementTest
        // 
        cardPlacementTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardPlacementTest.BackColor = System.Drawing.Color.White;
        cardPlacementTest.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardPlacementTest.BorderWidth = 1;
        cardPlacementTest.Controls.Add(bannerTestRecommend);
        cardPlacementTest.Controls.Add(cboRecommendedCourse);
        cardPlacementTest.Controls.Add(lblRecommendedCourse);
        cardPlacementTest.Controls.Add(cboTestEvaluator);
        cardPlacementTest.Controls.Add(lblTestEvaluator);
        cardPlacementTest.Controls.Add(txtTestScore);
        cardPlacementTest.Controls.Add(lblTestScore);
        cardPlacementTest.Controls.Add(txtTestName);
        cardPlacementTest.Controls.Add(lblTestName);
        cardPlacementTest.Controls.Add(lblTestTitle);
        cardPlacementTest.CornerRadius = 8;
        cardPlacementTest.Location = new System.Drawing.Point(24, 434);
        cardPlacementTest.Name = "cardPlacementTest";
        cardPlacementTest.Padding = new System.Windows.Forms.Padding(16);
        cardPlacementTest.Size = new System.Drawing.Size(752, 301);
        cardPlacementTest.TabIndex = 2;
        // 
        // bannerTestRecommend
        // 
        bannerTestRecommend.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)252)), ((int)((byte)231)));
        bannerTestRecommend.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerTestRecommend.Location = new System.Drawing.Point(20, 205);
        bannerTestRecommend.Message = "Cần củng cố ngữ pháp và từ vựng. Phù hợp IELTS Foundation (0–4,5/10 đầu vào).";
        bannerTestRecommend.Name = "bannerTestRecommend";
        bannerTestRecommend.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerTestRecommend.Size = new System.Drawing.Size(713, 70);
        bannerTestRecommend.TabIndex = 9;
        bannerTestRecommend.Title = "✓ Khuyến nghị:";
        bannerTestRecommend.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // cboRecommendedCourse
        // 
        cboRecommendedCourse.BackColor = System.Drawing.Color.White;
        cboRecommendedCourse.CornerRadius = 5;
        cboRecommendedCourse.DataSource = null;
        cboRecommendedCourse.DisplayMember = "";
        cboRecommendedCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboRecommendedCourse.Location = new System.Drawing.Point(340, 150);
        cboRecommendedCourse.Name = "cboRecommendedCourse";
        cboRecommendedCourse.SelectedIndex = -1;
        cboRecommendedCourse.SelectedItem = null;
        cboRecommendedCourse.SelectedValue = null;
        cboRecommendedCourse.Size = new System.Drawing.Size(305, 32);
        cboRecommendedCourse.TabIndex = 8;
        cboRecommendedCourse.ValueMember = "";
        // 
        // lblRecommendedCourse
        // 
        lblRecommendedCourse.AutoSize = true;
        lblRecommendedCourse.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblRecommendedCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblRecommendedCourse.Location = new System.Drawing.Point(340, 127);
        lblRecommendedCourse.Name = "lblRecommendedCourse";
        lblRecommendedCourse.Size = new System.Drawing.Size(146, 20);
        lblRecommendedCourse.TabIndex = 7;
        lblRecommendedCourse.Text = "Khóa khuyến nghị *";
        // 
        // cboTestEvaluator
        // 
        cboTestEvaluator.BackColor = System.Drawing.Color.White;
        cboTestEvaluator.CornerRadius = 5;
        cboTestEvaluator.DataSource = null;
        cboTestEvaluator.DisplayMember = "";
        cboTestEvaluator.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboTestEvaluator.Location = new System.Drawing.Point(20, 150);
        cboTestEvaluator.Name = "cboTestEvaluator";
        cboTestEvaluator.SelectedIndex = -1;
        cboTestEvaluator.SelectedItem = null;
        cboTestEvaluator.SelectedValue = null;
        cboTestEvaluator.Size = new System.Drawing.Size(300, 32);
        cboTestEvaluator.TabIndex = 6;
        cboTestEvaluator.ValueMember = "";
        // 
        // lblTestEvaluator
        // 
        lblTestEvaluator.AutoSize = true;
        lblTestEvaluator.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTestEvaluator.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTestEvaluator.Location = new System.Drawing.Point(20, 127);
        lblTestEvaluator.Name = "lblTestEvaluator";
        lblTestEvaluator.Size = new System.Drawing.Size(117, 20);
        lblTestEvaluator.TabIndex = 5;
        lblTestEvaluator.Text = "Người đánh giá";
        // 
        // txtTestScore
        // 
        txtTestScore.BackColor = System.Drawing.Color.Transparent;
        txtTestScore.CornerRadius = 6;
        txtTestScore.ErrorMessage = "";
        txtTestScore.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtTestScore.HasError = false;
        txtTestScore.Location = new System.Drawing.Point(340, 75);
        txtTestScore.Name = "txtTestScore";
        txtTestScore.Placeholder = "4,0 / 10";
        txtTestScore.ReadOnly = false;
        txtTestScore.Size = new System.Drawing.Size(305, 32);
        txtTestScore.TabIndex = 4;
        txtTestScore.UseSystemPasswordChar = false;
        // 
        // lblTestScore
        // 
        lblTestScore.AutoSize = true;
        lblTestScore.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTestScore.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTestScore.Location = new System.Drawing.Point(340, 52);
        lblTestScore.Name = "lblTestScore";
        lblTestScore.Size = new System.Drawing.Size(152, 20);
        lblTestScore.TabIndex = 3;
        lblTestScore.Text = "Điểm / thang điểm *";
        // 
        // txtTestName
        // 
        txtTestName.BackColor = System.Drawing.Color.Transparent;
        txtTestName.CornerRadius = 6;
        txtTestName.ErrorMessage = "";
        txtTestName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtTestName.HasError = false;
        txtTestName.Location = new System.Drawing.Point(20, 75);
        txtTestName.Name = "txtTestName";
        txtTestName.Placeholder = "Đầu vào IELTS · 02/10/2026";
        txtTestName.ReadOnly = false;
        txtTestName.Size = new System.Drawing.Size(300, 32);
        txtTestName.TabIndex = 2;
        txtTestName.UseSystemPasswordChar = false;
        // 
        // lblTestName
        // 
        lblTestName.AutoSize = true;
        lblTestName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTestName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTestName.Location = new System.Drawing.Point(20, 52);
        lblTestName.Name = "lblTestName";
        lblTestName.Size = new System.Drawing.Size(104, 20);
        lblTestName.TabIndex = 1;
        lblTestName.Text = "Bài kiểm tra *";
        // 
        // lblTestTitle
        // 
        lblTestTitle.AutoSize = true;
        lblTestTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblTestTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTestTitle.Location = new System.Drawing.Point(20, 16);
        lblTestTitle.Name = "lblTestTitle";
        lblTestTitle.Size = new System.Drawing.Size(304, 28);
        lblTestTitle.TabIndex = 0;
        lblTestTitle.Text = "Kiểm tra đầu vào & khuyến nghị";
        // 
        // cardConsultHistory
        // 
        cardConsultHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardConsultHistory.BackColor = System.Drawing.Color.White;
        cardConsultHistory.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardConsultHistory.BorderWidth = 1;
        cardConsultHistory.Controls.Add(btnSaveConsult);
        cardConsultHistory.Controls.Add(btnCancelConsult);
        cardConsultHistory.Controls.Add(txtNewConsult);
        cardConsultHistory.Controls.Add(lblNewConsult);
        cardConsultHistory.Controls.Add(dgvConsultHistory);
        cardConsultHistory.Controls.Add(lblHistoryTitle);
        cardConsultHistory.CornerRadius = 8;
        cardConsultHistory.Location = new System.Drawing.Point(24, 95);
        cardConsultHistory.Name = "cardConsultHistory";
        cardConsultHistory.Padding = new System.Windows.Forms.Padding(16);
        cardConsultHistory.Size = new System.Drawing.Size(752, 316);
        cardConsultHistory.TabIndex = 1;
        // 
        // btnSaveConsult
        // 
        btnSaveConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveConsult.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveConsult.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveConsult.CornerRadius = 6;
        btnSaveConsult.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveConsult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveConsult.ForeColor = System.Drawing.Color.White;
        btnSaveConsult.Location = new System.Drawing.Point(627, 268);
        btnSaveConsult.Name = "btnSaveConsult";
        btnSaveConsult.Size = new System.Drawing.Size(105, 32);
        btnSaveConsult.TabIndex = 5;
        btnSaveConsult.Text = "Lưu tư vấn";
        btnSaveConsult.UseVisualStyleBackColor = false;
        btnSaveConsult.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelConsult
        // 
        btnCancelConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelConsult.BackColor = System.Drawing.Color.White;
        btnCancelConsult.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelConsult.CornerRadius = 6;
        btnCancelConsult.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelConsult.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelConsult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnCancelConsult.Location = new System.Drawing.Point(547, 268);
        btnCancelConsult.Name = "btnCancelConsult";
        btnCancelConsult.Size = new System.Drawing.Size(70, 32);
        btnCancelConsult.TabIndex = 4;
        btnCancelConsult.Text = "Hủy";
        btnCancelConsult.UseVisualStyleBackColor = false;
        btnCancelConsult.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtNewConsult
        // 
        txtNewConsult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtNewConsult.BackColor = System.Drawing.Color.Transparent;
        txtNewConsult.CornerRadius = 6;
        txtNewConsult.ErrorMessage = "";
        txtNewConsult.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNewConsult.HasError = false;
        txtNewConsult.Location = new System.Drawing.Point(20, 268);
        txtNewConsult.Name = "txtNewConsult";
        txtNewConsult.Placeholder = "Nhập nội dung trao đổi, kết quả tư vấn mới...";
        txtNewConsult.ReadOnly = false;
        txtNewConsult.Size = new System.Drawing.Size(517, 32);
        txtNewConsult.TabIndex = 3;
        txtNewConsult.UseSystemPasswordChar = false;
        // 
        // lblNewConsult
        // 
        lblNewConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblNewConsult.AutoSize = true;
        lblNewConsult.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblNewConsult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblNewConsult.Location = new System.Drawing.Point(20, 246);
        lblNewConsult.Name = "lblNewConsult";
        lblNewConsult.Size = new System.Drawing.Size(154, 20);
        lblNewConsult.TabIndex = 2;
        lblNewConsult.Text = "Nội dung tư vấn mới";
        // 
        // dgvConsultHistory
        // 
        dgvConsultHistory.AllowUserToAddRows = false;
        dgvConsultHistory.AllowUserToDeleteRows = false;
        dgvConsultHistory.AllowUserToResizeColumns = false;
        dgvConsultHistory.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvConsultHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvConsultHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvConsultHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvConsultHistory.BackgroundColor = System.Drawing.Color.White;
        dgvConsultHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvConsultHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvConsultHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvConsultHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvConsultHistory.ColumnHeadersHeight = 36;
        dgvConsultHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvConsultHistory.DefaultCellStyle = dataGridViewCellStyle3;
        dgvConsultHistory.EnableHeadersVisualStyles = false;
        dgvConsultHistory.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvConsultHistory.Location = new System.Drawing.Point(20, 48);
        dgvConsultHistory.MultiSelect = false;
        dgvConsultHistory.Name = "dgvConsultHistory";
        dgvConsultHistory.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvConsultHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvConsultHistory.RowHeadersVisible = false;
        dgvConsultHistory.RowHeadersWidth = 51;
        dgvConsultHistory.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvConsultHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvConsultHistory.Size = new System.Drawing.Size(712, 186);
        dgvConsultHistory.TabIndex = 1;
        // 
        // lblHistoryTitle
        // 
        lblHistoryTitle.AutoSize = true;
        lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblHistoryTitle.Location = new System.Drawing.Point(20, 16);
        lblHistoryTitle.Name = "lblHistoryTitle";
        lblHistoryTitle.Size = new System.Drawing.Size(145, 28);
        lblHistoryTitle.TabIndex = 0;
        lblHistoryTitle.Text = "Lịch sử tư vấn";
        // 
        // ConsultationDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(cardConsultSummary);
        Controls.Add(cardPlacementTest);
        Controls.Add(cardConsultHistory);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tư vấn & Kiểm tra đầu vào — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardConsultSummary.ResumeLayout(false);
        cardConsultSummary.PerformLayout();
        cardPlacementTest.ResumeLayout(false);
        cardPlacementTest.PerformLayout();
        cardConsultHistory.ResumeLayout(false);
        cardConsultHistory.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvConsultHistory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblConsultLeadName;
    private System.Windows.Forms.Label lblConsultLeadMeta;
    private ECMS.UI.Controls.AppButton btnEditLeadInfo;
    private ECMS.UI.Controls.AppButton btnNextToEnroll;

    private ECMS.UI.Controls.AppCard cardConsultHistory;
    private System.Windows.Forms.Label lblHistoryTitle;
    private ECMS.UI.Controls.AppDataGrid dgvConsultHistory;
    private System.Windows.Forms.Label lblNewConsult;
    private ECMS.UI.Controls.AppTextBox txtNewConsult;
    private ECMS.UI.Controls.AppButton btnCancelConsult;
    private ECMS.UI.Controls.AppButton btnSaveConsult;

    private ECMS.UI.Controls.AppCard cardPlacementTest;
    private System.Windows.Forms.Label lblTestTitle;
    private System.Windows.Forms.Label lblTestName;
    private ECMS.UI.Controls.AppTextBox txtTestName;
    private System.Windows.Forms.Label lblTestScore;
    private ECMS.UI.Controls.AppTextBox txtTestScore;
    private System.Windows.Forms.Label lblTestEvaluator;
    private ECMS.UI.Controls.AppComboBox cboTestEvaluator;
    private System.Windows.Forms.Label lblRecommendedCourse;
    private ECMS.UI.Controls.AppComboBox cboRecommendedCourse;
    private ECMS.UI.Controls.AppBanner bannerTestRecommend;

    private ECMS.UI.Controls.AppCard cardConsultSummary;
    private System.Windows.Forms.Label lblSummaryTitle;
    private System.Windows.Forms.Label lblSumStudent;
    private System.Windows.Forms.Label lblSumDob;
    private System.Windows.Forms.Label lblSumParent;
    private System.Windows.Forms.Label lblSumPhone;
    private System.Windows.Forms.Label lblSumProgram;
    private System.Windows.Forms.Label lblSumDuration;
    private System.Windows.Forms.Label lblSumFee;
    private System.Windows.Forms.Label lblSumDiscount;
    private System.Windows.Forms.Label lblSumFinalFee;
    private System.Windows.Forms.Label lblSumReady;
}
