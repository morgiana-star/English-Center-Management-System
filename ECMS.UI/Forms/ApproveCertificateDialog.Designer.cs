namespace ECMS.UI.Forms;

partial class ApproveCertificateDialog
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
        pnlHeader = new System.Windows.Forms.Panel();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCertificateDetails = new ECMS.UI.Controls.AppCard();
        txtDecision = new ECMS.UI.Controls.AppTextBox();
        lblDecisionTitle = new System.Windows.Forms.Label();
        cboSigner = new ECMS.UI.Controls.AppComboBox();
        lblSignerTitle = new System.Windows.Forms.Label();
        lblIssueDateVal = new System.Windows.Forms.Label();
        lblIssueDateTitle = new System.Windows.Forms.Label();
        lblCertSerialVal = new System.Windows.Forms.Label();
        lblCertSerialTitle = new System.Windows.Forms.Label();
        lblCard2Title = new System.Windows.Forms.Label();
        cardStudentProfile = new ECMS.UI.Controls.AppCard();
        pnlMetricsBox = new System.Windows.Forms.TableLayoutPanel();
        pnlMetric1 = new System.Windows.Forms.Panel();
        lblM1Val = new System.Windows.Forms.Label();
        lblM1Title = new System.Windows.Forms.Label();
        pnlMetric2 = new System.Windows.Forms.Panel();
        lblM2Val = new System.Windows.Forms.Label();
        lblM2Title = new System.Windows.Forms.Label();
        pnlMetric3 = new System.Windows.Forms.Panel();
        lblM3Val = new System.Windows.Forms.Label();
        lblM3Title = new System.Windows.Forms.Label();
        pnlMetric4 = new System.Windows.Forms.Panel();
        lblM4Val = new System.Windows.Forms.Label();
        lblM4Title = new System.Windows.Forms.Label();
        lblDobVal = new System.Windows.Forms.Label();
        lblDobTitle = new System.Windows.Forms.Label();
        lblStudentCodeVal = new System.Windows.Forms.Label();
        lblStudentCodeTitle = new System.Windows.Forms.Label();
        lblStudentNameVal = new System.Windows.Forms.Label();
        lblStudentNameTitle = new System.Windows.Forms.Label();
        lblCard1Title = new System.Windows.Forms.Label();
        pnlActions = new System.Windows.Forms.FlowLayoutPanel();
        btnConfirmIssue = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCertificateDetails.SuspendLayout();
        cardStudentProfile.SuspendLayout();
        pnlMetricsBox.SuspendLayout();
        pnlMetric1.SuspendLayout();
        pnlMetric2.SuspendLayout();
        pnlMetric3.SuspendLayout();
        pnlMetric4.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 10);
        pnlHeader.Size = new System.Drawing.Size(850, 93);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(26, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(484, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Khóa học: IELTS Foundation · Lớp: IELTS-F02 (Đã hoàn thành 24/24 buổi)";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(447, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Quyết định cấp chứng chỉ tốt nghiệp";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardCertificateDetails);
        pnlBody.Controls.Add(cardStudentProfile);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 93);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 12, 24, 8);
        pnlBody.Size = new System.Drawing.Size(850, 433);
        pnlBody.TabIndex = 1;
        // 
        // cardCertificateDetails
        // 
        cardCertificateDetails.BackColor = System.Drawing.Color.White;
        cardCertificateDetails.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCertificateDetails.BorderWidth = 1;
        cardCertificateDetails.Controls.Add(txtDecision);
        cardCertificateDetails.Controls.Add(lblDecisionTitle);
        cardCertificateDetails.Controls.Add(cboSigner);
        cardCertificateDetails.Controls.Add(lblSignerTitle);
        cardCertificateDetails.Controls.Add(lblIssueDateVal);
        cardCertificateDetails.Controls.Add(lblIssueDateTitle);
        cardCertificateDetails.Controls.Add(lblCertSerialVal);
        cardCertificateDetails.Controls.Add(lblCertSerialTitle);
        cardCertificateDetails.Controls.Add(lblCard2Title);
        cardCertificateDetails.CornerRadius = 6;
        cardCertificateDetails.Dock = System.Windows.Forms.DockStyle.Top;
        cardCertificateDetails.Location = new System.Drawing.Point(24, 172);
        cardCertificateDetails.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
        cardCertificateDetails.Name = "cardCertificateDetails";
        cardCertificateDetails.Padding = new System.Windows.Forms.Padding(16);
        cardCertificateDetails.Size = new System.Drawing.Size(802, 186);
        cardCertificateDetails.TabIndex = 1;
        // 
        // txtDecision
        // 
        txtDecision.BackColor = System.Drawing.Color.Transparent;
        txtDecision.CornerRadius = 5;
        txtDecision.ErrorMessage = "";
        txtDecision.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtDecision.HasError = false;
        txtDecision.Location = new System.Drawing.Point(400, 100);
        txtDecision.Name = "txtDecision";
        txtDecision.Placeholder = "";
        txtDecision.ReadOnly = false;
        txtDecision.Size = new System.Drawing.Size(384, 34);
        txtDecision.TabIndex = 8;
        txtDecision.UseSystemPasswordChar = false;
        // 
        // lblDecisionTitle
        // 
        lblDecisionTitle.AutoSize = true;
        lblDecisionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDecisionTitle.Location = new System.Drawing.Point(400, 80);
        lblDecisionTitle.Name = "lblDecisionTitle";
        lblDecisionTitle.Size = new System.Drawing.Size(124, 20);
        lblDecisionTitle.TabIndex = 7;
        lblDecisionTitle.Text = "Nội dung ghi sổ:";
        // 
        // cboSigner
        // 
        cboSigner.BackColor = System.Drawing.Color.Transparent;
        cboSigner.CornerRadius = 5;
        cboSigner.DataSource = null;
        cboSigner.DisplayMember = "";
        cboSigner.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboSigner.Location = new System.Drawing.Point(16, 100);
        cboSigner.Name = "cboSigner";
        cboSigner.SelectedIndex = -1;
        cboSigner.SelectedItem = null;
        cboSigner.SelectedValue = null;
        cboSigner.Size = new System.Drawing.Size(350, 35);
        cboSigner.TabIndex = 6;
        cboSigner.ValueMember = "";
        // 
        // lblSignerTitle
        // 
        lblSignerTitle.AutoSize = true;
        lblSignerTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSignerTitle.Location = new System.Drawing.Point(16, 80);
        lblSignerTitle.Name = "lblSignerTitle";
        lblSignerTitle.Size = new System.Drawing.Size(84, 20);
        lblSignerTitle.TabIndex = 5;
        lblSignerTitle.Text = "Người ký *";
        // 
        // lblIssueDateVal
        // 
        lblIssueDateVal.AutoSize = true;
        lblIssueDateVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblIssueDateVal.Location = new System.Drawing.Point(475, 42);
        lblIssueDateVal.Name = "lblIssueDateVal";
        lblIssueDateVal.Size = new System.Drawing.Size(96, 21);
        lblIssueDateVal.TabIndex = 4;
        lblIssueDateVal.Text = "30/10/2026";
        // 
        // lblIssueDateTitle
        // 
        lblIssueDateTitle.AutoSize = true;
        lblIssueDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblIssueDateTitle.Location = new System.Drawing.Point(400, 42);
        lblIssueDateTitle.Name = "lblIssueDateTitle";
        lblIssueDateTitle.Size = new System.Drawing.Size(75, 20);
        lblIssueDateTitle.TabIndex = 3;
        lblIssueDateTitle.Text = "Ngày cấp:";
        // 
        // lblCertSerialVal
        // 
        lblCertSerialVal.AutoSize = true;
        lblCertSerialVal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
        lblCertSerialVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblCertSerialVal.Location = new System.Drawing.Point(135, 40);
        lblCertSerialVal.Name = "lblCertSerialVal";
        lblCertSerialVal.Size = new System.Drawing.Size(142, 23);
        lblCertSerialVal.TabIndex = 2;
        lblCertSerialVal.Text = "CC-2026-0042";
        // 
        // lblCertSerialTitle
        // 
        lblCertSerialTitle.AutoSize = true;
        lblCertSerialTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCertSerialTitle.Location = new System.Drawing.Point(16, 42);
        lblCertSerialTitle.Name = "lblCertSerialTitle";
        lblCertSerialTitle.Size = new System.Drawing.Size(133, 20);
        lblCertSerialTitle.TabIndex = 1;
        lblCertSerialTitle.Text = "Số chứng chỉ khóa:";
        // 
        // lblCard2Title
        // 
        lblCard2Title.AutoSize = true;
        lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCard2Title.Location = new System.Drawing.Point(16, 12);
        lblCard2Title.Name = "lblCard2Title";
        lblCard2Title.Size = new System.Drawing.Size(293, 23);
        lblCard2Title.TabIndex = 0;
        lblCard2Title.Text = "THÔNG SỐ VĂN BẰNG & PHÊ DUYỆT";
        // 
        // cardStudentProfile
        // 
        cardStudentProfile.BackColor = System.Drawing.Color.White;
        cardStudentProfile.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentProfile.BorderWidth = 1;
        cardStudentProfile.Controls.Add(pnlMetricsBox);
        cardStudentProfile.Controls.Add(lblDobVal);
        cardStudentProfile.Controls.Add(lblDobTitle);
        cardStudentProfile.Controls.Add(lblStudentCodeVal);
        cardStudentProfile.Controls.Add(lblStudentCodeTitle);
        cardStudentProfile.Controls.Add(lblStudentNameVal);
        cardStudentProfile.Controls.Add(lblStudentNameTitle);
        cardStudentProfile.Controls.Add(lblCard1Title);
        cardStudentProfile.CornerRadius = 6;
        cardStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
        cardStudentProfile.Location = new System.Drawing.Point(24, 12);
        cardStudentProfile.Name = "cardStudentProfile";
        cardStudentProfile.Padding = new System.Windows.Forms.Padding(16);
        cardStudentProfile.Size = new System.Drawing.Size(802, 160);
        cardStudentProfile.TabIndex = 0;
        // 
        // pnlMetricsBox
        // 
        pnlMetricsBox.ColumnCount = 4;
        pnlMetricsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlMetricsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlMetricsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlMetricsBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        pnlMetricsBox.Controls.Add(pnlMetric1, 0, 0);
        pnlMetricsBox.Controls.Add(pnlMetric2, 1, 0);
        pnlMetricsBox.Controls.Add(pnlMetric3, 2, 0);
        pnlMetricsBox.Controls.Add(pnlMetric4, 3, 0);
        pnlMetricsBox.Location = new System.Drawing.Point(16, 68);
        pnlMetricsBox.Name = "pnlMetricsBox";
        pnlMetricsBox.RowCount = 1;
        pnlMetricsBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlMetricsBox.Size = new System.Drawing.Size(768, 72);
        pnlMetricsBox.TabIndex = 7;
        // 
        // pnlMetric1
        // 
        pnlMetric1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMetric1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlMetric1.Controls.Add(lblM1Val);
        pnlMetric1.Controls.Add(lblM1Title);
        pnlMetric1.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMetric1.Location = new System.Drawing.Point(3, 3);
        pnlMetric1.Name = "pnlMetric1";
        pnlMetric1.Padding = new System.Windows.Forms.Padding(8);
        pnlMetric1.Size = new System.Drawing.Size(186, 66);
        pnlMetric1.TabIndex = 0;
        // 
        // lblM1Val
        // 
        lblM1Val.AutoSize = true;
        lblM1Val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblM1Val.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblM1Val.Location = new System.Drawing.Point(6, 28);
        lblM1Val.Name = "lblM1Val";
        lblM1Val.Size = new System.Drawing.Size(86, 28);
        lblM1Val.TabIndex = 1;
        lblM1Val.Text = "8.0 / 10";
        // 
        // lblM1Title
        // 
        lblM1Title.AutoSize = true;
        lblM1Title.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblM1Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblM1Title.Location = new System.Drawing.Point(6, 6);
        lblM1Title.Name = "lblM1Title";
        lblM1Title.Size = new System.Drawing.Size(148, 19);
        lblM1Title.TabIndex = 0;
        lblM1Title.Text = "ĐIỂM THI CUỐI KHÓA";
        // 
        // pnlMetric2
        // 
        pnlMetric2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMetric2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlMetric2.Controls.Add(lblM2Val);
        pnlMetric2.Controls.Add(lblM2Title);
        pnlMetric2.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMetric2.Location = new System.Drawing.Point(195, 3);
        pnlMetric2.Name = "pnlMetric2";
        pnlMetric2.Padding = new System.Windows.Forms.Padding(8);
        pnlMetric2.Size = new System.Drawing.Size(186, 66);
        pnlMetric2.TabIndex = 1;
        // 
        // lblM2Val
        // 
        lblM2Val.AutoSize = true;
        lblM2Val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblM2Val.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblM2Val.Location = new System.Drawing.Point(6, 28);
        lblM2Val.Name = "lblM2Val";
        lblM2Val.Size = new System.Drawing.Size(139, 28);
        lblM2Val.TabIndex = 1;
        lblM2Val.Text = "7.7 · Loại Khá";
        // 
        // lblM2Title
        // 
        lblM2Title.AutoSize = true;
        lblM2Title.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblM2Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblM2Title.Location = new System.Drawing.Point(6, 6);
        lblM2Title.Name = "lblM2Title";
        lblM2Title.Size = new System.Drawing.Size(128, 19);
        lblM2Title.TabIndex = 0;
        lblM2Title.Text = "ĐIỂM TRUNG BÌNH";
        // 
        // pnlMetric3
        // 
        pnlMetric3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMetric3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlMetric3.Controls.Add(lblM3Val);
        pnlMetric3.Controls.Add(lblM3Title);
        pnlMetric3.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMetric3.Location = new System.Drawing.Point(387, 3);
        pnlMetric3.Name = "pnlMetric3";
        pnlMetric3.Padding = new System.Windows.Forms.Padding(8);
        pnlMetric3.Size = new System.Drawing.Size(186, 66);
        pnlMetric3.TabIndex = 2;
        // 
        // lblM3Val
        // 
        lblM3Val.AutoSize = true;
        lblM3Val.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblM3Val.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblM3Val.Location = new System.Drawing.Point(6, 29);
        lblM3Val.Name = "lblM3Val";
        lblM3Val.Size = new System.Drawing.Size(154, 25);
        lblM3Val.TabIndex = 1;
        lblM3Val.Text = "22/24 b (91,7%)";
        // 
        // lblM3Title
        // 
        lblM3Title.AutoSize = true;
        lblM3Title.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblM3Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblM3Title.Location = new System.Drawing.Point(6, 6);
        lblM3Title.Name = "lblM3Title";
        lblM3Title.Size = new System.Drawing.Size(95, 19);
        lblM3Title.TabIndex = 0;
        lblM3Title.Text = "CHUYÊN CẦN";
        // 
        // pnlMetric4
        // 
        pnlMetric4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMetric4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlMetric4.Controls.Add(lblM4Val);
        pnlMetric4.Controls.Add(lblM4Title);
        pnlMetric4.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMetric4.Location = new System.Drawing.Point(579, 3);
        pnlMetric4.Name = "pnlMetric4";
        pnlMetric4.Padding = new System.Windows.Forms.Padding(8);
        pnlMetric4.Size = new System.Drawing.Size(186, 66);
        pnlMetric4.TabIndex = 3;
        // 
        // lblM4Val
        // 
        lblM4Val.AutoSize = true;
        lblM4Val.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblM4Val.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblM4Val.Location = new System.Drawing.Point(6, 29);
        lblM4Val.Name = "lblM4Val";
        lblM4Val.Size = new System.Drawing.Size(158, 25);
        lblM4Val.TabIndex = 1;
        lblM4Val.Text = "0 đ · Đã hoàn tất";
        // 
        // lblM4Title
        // 
        lblM4Title.AutoSize = true;
        lblM4Title.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblM4Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblM4Title.Location = new System.Drawing.Point(6, 6);
        lblM4Title.Name = "lblM4Title";
        lblM4Title.Size = new System.Drawing.Size(157, 19);
        lblM4Title.TabIndex = 0;
        lblM4Title.Text = "TÌNH TRẠNG CÔNG NỢ";
        // 
        // lblDobVal
        // 
        lblDobVal.AutoSize = true;
        lblDobVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDobVal.Location = new System.Drawing.Point(610, 38);
        lblDobVal.Name = "lblDobVal";
        lblDobVal.Size = new System.Drawing.Size(94, 21);
        lblDobVal.TabIndex = 6;
        lblDobVal.Text = "12/03/2007";
        // 
        // lblDobTitle
        // 
        lblDobTitle.AutoSize = true;
        lblDobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDobTitle.Location = new System.Drawing.Point(540, 38);
        lblDobTitle.Name = "lblDobTitle";
        lblDobTitle.Size = new System.Drawing.Size(77, 20);
        lblDobTitle.TabIndex = 5;
        lblDobTitle.Text = "Ngày sinh:";
        // 
        // lblStudentCodeVal
        // 
        lblStudentCodeVal.AutoSize = true;
        lblStudentCodeVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblStudentCodeVal.Location = new System.Drawing.Point(398, 38);
        lblStudentCodeVal.Name = "lblStudentCodeVal";
        lblStudentCodeVal.Size = new System.Drawing.Size(75, 21);
        lblStudentCodeVal.TabIndex = 4;
        lblStudentCodeVal.Text = "HV-0204";
        // 
        // lblStudentCodeTitle
        // 
        lblStudentCodeTitle.AutoSize = true;
        lblStudentCodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentCodeTitle.Location = new System.Drawing.Point(300, 38);
        lblStudentCodeTitle.Name = "lblStudentCodeTitle";
        lblStudentCodeTitle.Size = new System.Drawing.Size(92, 20);
        lblStudentCodeTitle.TabIndex = 3;
        lblStudentCodeTitle.Text = "Mã học viên:";
        // 
        // lblStudentNameVal
        // 
        lblStudentNameVal.AutoSize = true;
        lblStudentNameVal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblStudentNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStudentNameVal.Location = new System.Drawing.Point(83, 36);
        lblStudentNameVal.Name = "lblStudentNameVal";
        lblStudentNameVal.Size = new System.Drawing.Size(143, 25);
        lblStudentNameVal.TabIndex = 2;
        lblStudentNameVal.Text = "TRẦN GIA BẢO";
        // 
        // lblStudentNameTitle
        // 
        lblStudentNameTitle.AutoSize = true;
        lblStudentNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStudentNameTitle.Location = new System.Drawing.Point(16, 38);
        lblStudentNameTitle.Name = "lblStudentNameTitle";
        lblStudentNameTitle.Size = new System.Drawing.Size(76, 20);
        lblStudentNameTitle.TabIndex = 1;
        lblStudentNameTitle.Text = "Họ và tên:";
        // 
        // lblCard1Title
        // 
        lblCard1Title.AutoSize = true;
        lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCard1Title.Location = new System.Drawing.Point(16, 12);
        lblCard1Title.Name = "lblCard1Title";
        lblCard1Title.Size = new System.Drawing.Size(264, 23);
        lblCard1Title.TabIndex = 0;
        lblCard1Title.Text = "HỒ SƠ & THÀNH TÍCH HỌC VIÊN";
        // 
        // pnlActions
        // 
        pnlActions.BackColor = System.Drawing.Color.White;
        pnlActions.Controls.Add(btnConfirmIssue);
        pnlActions.Controls.Add(btnCancel);
        pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlActions.Location = new System.Drawing.Point(0, 526);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new System.Windows.Forms.Padding(24, 8, 24, 8);
        pnlActions.Size = new System.Drawing.Size(850, 54);
        pnlActions.TabIndex = 3;
        // 
        // btnConfirmIssue
        // 
        btnConfirmIssue.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmIssue.CornerRadius = 5;
        btnConfirmIssue.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmIssue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmIssue.Location = new System.Drawing.Point(619, 11);
        btnConfirmIssue.Name = "btnConfirmIssue";
        btnConfirmIssue.Size = new System.Drawing.Size(180, 36);
        btnConfirmIssue.TabIndex = 0;
        btnConfirmIssue.Text = "Xác nhận & Cấp số";
        btnConfirmIssue.UseVisualStyleBackColor = true;
        btnConfirmIssue.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(513, 11);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // ApproveCertificateDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(850, 580);
        Controls.Add(pnlBody);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Duyệt cấp chứng chỉ · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCertificateDetails.ResumeLayout(false);
        cardCertificateDetails.PerformLayout();
        cardStudentProfile.ResumeLayout(false);
        cardStudentProfile.PerformLayout();
        pnlMetricsBox.ResumeLayout(false);
        pnlMetric1.ResumeLayout(false);
        pnlMetric1.PerformLayout();
        pnlMetric2.ResumeLayout(false);
        pnlMetric2.PerformLayout();
        pnlMetric3.ResumeLayout(false);
        pnlMetric3.PerformLayout();
        pnlMetric4.ResumeLayout(false);
        pnlMetric4.PerformLayout();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlBody;

    private ECMS.UI.Controls.AppCard cardStudentProfile;
    private System.Windows.Forms.Label lblCard1Title;
    private System.Windows.Forms.Label lblStudentNameTitle;
    private System.Windows.Forms.Label lblStudentNameVal;
    private System.Windows.Forms.Label lblStudentCodeTitle;
    private System.Windows.Forms.Label lblStudentCodeVal;
    private System.Windows.Forms.Label lblDobTitle;
    private System.Windows.Forms.Label lblDobVal;

    private System.Windows.Forms.TableLayoutPanel pnlMetricsBox;
    private System.Windows.Forms.Panel pnlMetric1;
    private System.Windows.Forms.Label lblM1Title;
    private System.Windows.Forms.Label lblM1Val;
    private System.Windows.Forms.Panel pnlMetric2;
    private System.Windows.Forms.Label lblM2Title;
    private System.Windows.Forms.Label lblM2Val;
    private System.Windows.Forms.Panel pnlMetric3;
    private System.Windows.Forms.Label lblM3Title;
    private System.Windows.Forms.Label lblM3Val;
    private System.Windows.Forms.Panel pnlMetric4;
    private System.Windows.Forms.Label lblM4Title;
    private System.Windows.Forms.Label lblM4Val;

    private ECMS.UI.Controls.AppCard cardCertificateDetails;
    private System.Windows.Forms.Label lblCard2Title;
    private System.Windows.Forms.Label lblCertSerialTitle;
    private System.Windows.Forms.Label lblCertSerialVal;
    private System.Windows.Forms.Label lblIssueDateTitle;
    private System.Windows.Forms.Label lblIssueDateVal;
    private System.Windows.Forms.Label lblSignerTitle;
    private ECMS.UI.Controls.AppComboBox cboSigner;
    private System.Windows.Forms.Label lblDecisionTitle;
    private ECMS.UI.Controls.AppTextBox txtDecision;

    private System.Windows.Forms.FlowLayoutPanel pnlActions;
    private ECMS.UI.Controls.AppButton btnConfirmIssue;
    private ECMS.UI.Controls.AppButton btnCancel;
}
