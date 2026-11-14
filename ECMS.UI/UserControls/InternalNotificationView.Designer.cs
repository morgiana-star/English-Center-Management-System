namespace ECMS.UI.UserControls;

partial class InternalNotificationView
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
        btnComposeTop = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCompose = new ECMS.UI.Controls.AppCard();
        btnPublishNotice = new ECMS.UI.Controls.AppButton();
        btnSaveDraft = new ECMS.UI.Controls.AppButton();
        btnCancelCompose = new ECMS.UI.Controls.AppButton();
        txtContent = new System.Windows.Forms.TextBox();
        lblContent = new System.Windows.Forms.Label();
        cboClassScope = new ECMS.UI.Controls.AppComboBox();
        lblClassScope = new System.Windows.Forms.Label();
        pnlRoles = new System.Windows.Forms.Panel();
        chkTraining = new System.Windows.Forms.CheckBox();
        chkAccountant = new System.Windows.Forms.CheckBox();
        chkConsultant = new System.Windows.Forms.CheckBox();
        chkTeacher = new System.Windows.Forms.CheckBox();
        chkParent = new System.Windows.Forms.CheckBox();
        chkStudent = new System.Windows.Forms.CheckBox();
        lblRoles = new System.Windows.Forms.Label();
        txtTitleInput = new ECMS.UI.Controls.AppTextBox();
        lblTitleInput = new System.Windows.Forms.Label();
        lblComposeTitle = new System.Windows.Forms.Label();
        cardNoticePreview = new ECMS.UI.Controls.AppCard();
        lblNoticePreviewBody = new System.Windows.Forms.Label();
        lblNoticePreviewSender = new System.Windows.Forms.Label();
        lblNoticePreviewBadge = new System.Windows.Forms.Label();
        lblNoticePreviewTitle = new System.Windows.Forms.Label();
        cardNoticeList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvNotices = new ECMS.UI.Controls.AppDataGrid();
        cboAudienceFilter = new ECMS.UI.Controls.AppComboBox();
        cboMonthFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchNotice = new ECMS.UI.Controls.AppTextBox();
        lblNoticeListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCompose.SuspendLayout();
        pnlRoles.SuspendLayout();
        cardNoticePreview.SuspendLayout();
        cardNoticeList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvNotices).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnComposeTop);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnComposeTop
        // 
        btnComposeTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnComposeTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnComposeTop.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnComposeTop.CornerRadius = 5;
        btnComposeTop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnComposeTop.FlatAppearance.BorderSize = 0;
        btnComposeTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnComposeTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnComposeTop.ForeColor = System.Drawing.Color.White;
        btnComposeTop.Location = new System.Drawing.Point(1006, 20);
        btnComposeTop.Name = "btnComposeTop";
        btnComposeTop.Size = new System.Drawing.Size(130, 36);
        btnComposeTop.TabIndex = 3;
        btnComposeTop.Text = "Soạn thông báo";
        btnComposeTop.UseVisualStyleBackColor = false;
        btnComposeTop.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
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
        lblTitle.Text = "Thông báo nội bộ";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardCompose);
        pnlBody.Controls.Add(cardNoticePreview);
        pnlBody.Controls.Add(cardNoticeList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardCompose
        // 
        cardCompose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardCompose.BackColor = System.Drawing.Color.White;
        cardCompose.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCompose.BorderWidth = 1;
        cardCompose.Controls.Add(btnPublishNotice);
        cardCompose.Controls.Add(btnSaveDraft);
        cardCompose.Controls.Add(btnCancelCompose);
        cardCompose.Controls.Add(txtContent);
        cardCompose.Controls.Add(lblContent);
        cardCompose.Controls.Add(cboClassScope);
        cardCompose.Controls.Add(lblClassScope);
        cardCompose.Controls.Add(pnlRoles);
        cardCompose.Controls.Add(lblRoles);
        cardCompose.Controls.Add(txtTitleInput);
        cardCompose.Controls.Add(lblTitleInput);
        cardCompose.Controls.Add(lblComposeTitle);
        cardCompose.CornerRadius = 6;
        cardCompose.Location = new System.Drawing.Point(680, 20);
        cardCompose.Name = "cardCompose";
        cardCompose.Padding = new System.Windows.Forms.Padding(20);
        cardCompose.Size = new System.Drawing.Size(456, 520);
        cardCompose.TabIndex = 2;
        // 
        // btnPublishNotice
        // 
        btnPublishNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnPublishNotice.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnPublishNotice.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPublishNotice.CornerRadius = 5;
        btnPublishNotice.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPublishNotice.FlatAppearance.BorderSize = 0;
        btnPublishNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPublishNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPublishNotice.ForeColor = System.Drawing.Color.White;
        btnPublishNotice.Location = new System.Drawing.Point(306, 468);
        btnPublishNotice.Name = "btnPublishNotice";
        btnPublishNotice.Size = new System.Drawing.Size(130, 32);
        btnPublishNotice.TabIndex = 11;
        btnPublishNotice.Text = "Phát hành nội bộ";
        btnPublishNotice.UseVisualStyleBackColor = false;
        btnPublishNotice.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnSaveDraft
        // 
        btnSaveDraft.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveDraft.BackColor = System.Drawing.Color.White;
        btnSaveDraft.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnSaveDraft.CornerRadius = 5;
        btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnSaveDraft.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnSaveDraft.Location = new System.Drawing.Point(206, 468);
        btnSaveDraft.Name = "btnSaveDraft";
        btnSaveDraft.Size = new System.Drawing.Size(90, 32);
        btnSaveDraft.TabIndex = 10;
        btnSaveDraft.Text = "Lưu nháp";
        btnSaveDraft.UseVisualStyleBackColor = false;
        btnSaveDraft.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnCancelCompose
        // 
        btnCancelCompose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelCompose.BackColor = System.Drawing.Color.White;
        btnCancelCompose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelCompose.CornerRadius = 5;
        btnCancelCompose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelCompose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelCompose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelCompose.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelCompose.Location = new System.Drawing.Point(126, 468);
        btnCancelCompose.Name = "btnCancelCompose";
        btnCancelCompose.Size = new System.Drawing.Size(70, 32);
        btnCancelCompose.TabIndex = 9;
        btnCancelCompose.Text = "Hủy";
        btnCancelCompose.UseVisualStyleBackColor = false;
        btnCancelCompose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtContent
        // 
        txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtContent.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtContent.Location = new System.Drawing.Point(20, 280);
        txtContent.Multiline = true;
        txtContent.Name = "txtContent";
        txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtContent.Size = new System.Drawing.Size(416, 100);
        txtContent.TabIndex = 8;
        // 
        // lblContent
        // 
        lblContent.AutoSize = true;
        lblContent.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblContent.Location = new System.Drawing.Point(20, 260);
        lblContent.Name = "lblContent";
        lblContent.Size = new System.Drawing.Size(85, 20);
        lblContent.TabIndex = 7;
        lblContent.Text = "Nội dung *";
        // 
        // cboClassScope
        // 
        cboClassScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboClassScope.BackColor = System.Drawing.Color.Transparent;
        cboClassScope.CornerRadius = 5;
        cboClassScope.DataSource = null;
        cboClassScope.DisplayMember = "";
        cboClassScope.Location = new System.Drawing.Point(20, 215);
        cboClassScope.Name = "cboClassScope";
        cboClassScope.SelectedIndex = -1;
        cboClassScope.SelectedItem = null;
        cboClassScope.SelectedValue = null;
        cboClassScope.Size = new System.Drawing.Size(416, 32);
        cboClassScope.TabIndex = 6;
        cboClassScope.ValueMember = "";
        // 
        // lblClassScope
        // 
        lblClassScope.AutoSize = true;
        lblClassScope.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblClassScope.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblClassScope.Location = new System.Drawing.Point(20, 195);
        lblClassScope.Name = "lblClassScope";
        lblClassScope.Size = new System.Drawing.Size(87, 20);
        lblClassScope.TabIndex = 5;
        lblClassScope.Text = "Phạm vi lớp";
        // 
        // pnlRoles
        // 
        pnlRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlRoles.Controls.Add(chkTraining);
        pnlRoles.Controls.Add(chkAccountant);
        pnlRoles.Controls.Add(chkConsultant);
        pnlRoles.Controls.Add(chkTeacher);
        pnlRoles.Controls.Add(chkParent);
        pnlRoles.Controls.Add(chkStudent);
        pnlRoles.Location = new System.Drawing.Point(20, 130);
        pnlRoles.Name = "pnlRoles";
        pnlRoles.Size = new System.Drawing.Size(416, 55);
        pnlRoles.TabIndex = 4;
        // 
        // chkTraining
        // 
        chkTraining.AutoSize = true;
        chkTraining.Location = new System.Drawing.Point(240, 30);
        chkTraining.Name = "chkTraining";
        chkTraining.Size = new System.Drawing.Size(85, 24);
        chkTraining.TabIndex = 5;
        chkTraining.Text = "Đào tạo";
        chkTraining.UseVisualStyleBackColor = true;
        // 
        // chkAccountant
        // 
        chkAccountant.AutoSize = true;
        chkAccountant.Location = new System.Drawing.Point(120, 30);
        chkAccountant.Name = "chkAccountant";
        chkAccountant.Size = new System.Drawing.Size(82, 24);
        chkAccountant.TabIndex = 4;
        chkAccountant.Text = "Kế toán";
        chkAccountant.UseVisualStyleBackColor = true;
        // 
        // chkConsultant
        // 
        chkConsultant.AutoSize = true;
        chkConsultant.Location = new System.Drawing.Point(5, 30);
        chkConsultant.Name = "chkConsultant";
        chkConsultant.Size = new System.Drawing.Size(75, 24);
        chkConsultant.TabIndex = 3;
        chkConsultant.Text = "Tư vấn";
        chkConsultant.UseVisualStyleBackColor = true;
        // 
        // chkTeacher
        // 
        chkTeacher.AutoSize = true;
        chkTeacher.Location = new System.Drawing.Point(240, 5);
        chkTeacher.Name = "chkTeacher";
        chkTeacher.Size = new System.Drawing.Size(93, 24);
        chkTeacher.TabIndex = 2;
        chkTeacher.Text = "Giáo viên";
        chkTeacher.UseVisualStyleBackColor = true;
        // 
        // chkParent
        // 
        chkParent.AutoSize = true;
        chkParent.Checked = true;
        chkParent.CheckState = System.Windows.Forms.CheckState.Checked;
        chkParent.Location = new System.Drawing.Point(120, 5);
        chkParent.Name = "chkParent";
        chkParent.Size = new System.Drawing.Size(98, 24);
        chkParent.TabIndex = 1;
        chkParent.Text = "Phụ huynh";
        chkParent.UseVisualStyleBackColor = true;
        // 
        // chkStudent
        // 
        chkStudent.AutoSize = true;
        chkStudent.Checked = true;
        chkStudent.CheckState = System.Windows.Forms.CheckState.Checked;
        chkStudent.Location = new System.Drawing.Point(5, 5);
        chkStudent.Name = "chkStudent";
        chkStudent.Size = new System.Drawing.Size(89, 24);
        chkStudent.TabIndex = 0;
        chkStudent.Text = "Học viên";
        chkStudent.UseVisualStyleBackColor = true;
        // 
        // lblRoles
        // 
        lblRoles.AutoSize = true;
        lblRoles.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblRoles.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRoles.Location = new System.Drawing.Point(20, 110);
        lblRoles.Name = "lblRoles";
        lblRoles.Size = new System.Drawing.Size(188, 20);
        lblRoles.TabIndex = 3;
        lblRoles.Text = "Người nhận theo vai trò *";
        // 
        // txtTitleInput
        // 
        txtTitleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtTitleInput.BackColor = System.Drawing.Color.Transparent;
        txtTitleInput.CornerRadius = 5;
        txtTitleInput.ErrorMessage = "";
        txtTitleInput.HasError = false;
        txtTitleInput.Location = new System.Drawing.Point(20, 68);
        txtTitleInput.Name = "txtTitleInput";
        txtTitleInput.Placeholder = "Nhắc hạn học phí tháng 11";
        txtTitleInput.ReadOnly = false;
        txtTitleInput.Size = new System.Drawing.Size(416, 32);
        txtTitleInput.TabIndex = 2;
        txtTitleInput.UseSystemPasswordChar = false;
        // 
        // lblTitleInput
        // 
        lblTitleInput.AutoSize = true;
        lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTitleInput.Location = new System.Drawing.Point(20, 48);
        lblTitleInput.Name = "lblTitleInput";
        lblTitleInput.Size = new System.Drawing.Size(71, 20);
        lblTitleInput.TabIndex = 1;
        lblTitleInput.Text = "Tiêu đề *";
        // 
        // lblComposeTitle
        // 
        lblComposeTitle.AutoSize = true;
        lblComposeTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblComposeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblComposeTitle.Location = new System.Drawing.Point(20, 16);
        lblComposeTitle.Name = "lblComposeTitle";
        lblComposeTitle.Size = new System.Drawing.Size(204, 25);
        lblComposeTitle.TabIndex = 0;
        lblComposeTitle.Text = "Soạn / sửa thông báo";
        // 
        // cardNoticePreview
        // 
        cardNoticePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardNoticePreview.BackColor = System.Drawing.Color.White;
        cardNoticePreview.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardNoticePreview.BorderWidth = 1;
        cardNoticePreview.Controls.Add(lblNoticePreviewBody);
        cardNoticePreview.Controls.Add(lblNoticePreviewSender);
        cardNoticePreview.Controls.Add(lblNoticePreviewBadge);
        cardNoticePreview.Controls.Add(lblNoticePreviewTitle);
        cardNoticePreview.CornerRadius = 6;
        cardNoticePreview.Location = new System.Drawing.Point(24, 370);
        cardNoticePreview.Name = "cardNoticePreview";
        cardNoticePreview.Padding = new System.Windows.Forms.Padding(20);
        cardNoticePreview.Size = new System.Drawing.Size(636, 170);
        cardNoticePreview.TabIndex = 1;
        // 
        // lblNoticePreviewBody
        // 
        lblNoticePreviewBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblNoticePreviewBody.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblNoticePreviewBody.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblNoticePreviewBody.Location = new System.Drawing.Point(20, 75);
        lblNoticePreviewBody.Name = "lblNoticePreviewBody";
        lblNoticePreviewBody.Size = new System.Drawing.Size(596, 55);
        lblNoticePreviewBody.TabIndex = 3;
        lblNoticePreviewBody.Text = ("Kính gửi giáo viên và nhân viên đào tạo, vui lòng kiểm tra điểm cuối khóa, trọng " + "số và chuyên cần của IELTS-F02 trước 16:00 hôm nay để xét chứng chỉ.");
        // 
        // lblNoticePreviewSender
        // 
        lblNoticePreviewSender.AutoSize = true;
        lblNoticePreviewSender.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblNoticePreviewSender.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblNoticePreviewSender.Location = new System.Drawing.Point(20, 50);
        lblNoticePreviewSender.Name = "lblNoticePreviewSender";
        lblNoticePreviewSender.Size = new System.Drawing.Size(327, 20);
        lblNoticePreviewSender.TabIndex = 2;
        lblNoticePreviewSender.Text = "Người gửi: Nguyễn Thị Hạnh · 30/10/2026, 08:30";
        // 
        // lblNoticePreviewBadge
        // 
        lblNoticePreviewBadge.AutoSize = true;
        lblNoticePreviewBadge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
        lblNoticePreviewBadge.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblNoticePreviewBadge.Location = new System.Drawing.Point(20, 32);
        lblNoticePreviewBadge.Name = "lblNoticePreviewBadge";
        lblNoticePreviewBadge.Size = new System.Drawing.Size(155, 19);
        lblNoticePreviewBadge.TabIndex = 1;
        lblNoticePreviewBadge.Text = "Nội bộ · Đã phát hành";
        // 
        // lblNoticePreviewTitle
        // 
        lblNoticePreviewTitle.AutoSize = true;
        lblNoticePreviewTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblNoticePreviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblNoticePreviewTitle.Location = new System.Drawing.Point(20, 8);
        lblNoticePreviewTitle.Name = "lblNoticePreviewTitle";
        lblNoticePreviewTitle.Size = new System.Drawing.Size(242, 25);
        lblNoticePreviewTitle.TabIndex = 0;
        lblNoticePreviewTitle.Text = "Nhắc chốt điểm IELTS-F02";
        // 
        // cardNoticeList
        // 
        cardNoticeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardNoticeList.BackColor = System.Drawing.Color.White;
        cardNoticeList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardNoticeList.BorderWidth = 1;
        cardNoticeList.Controls.Add(lblPagingNav);
        cardNoticeList.Controls.Add(lblPagingInfo);
        cardNoticeList.Controls.Add(dgvNotices);
        cardNoticeList.Controls.Add(cboAudienceFilter);
        cardNoticeList.Controls.Add(cboMonthFilter);
        cardNoticeList.Controls.Add(txtSearchNotice);
        cardNoticeList.Controls.Add(lblNoticeListTitle);
        cardNoticeList.CornerRadius = 6;
        cardNoticeList.Location = new System.Drawing.Point(24, 20);
        cardNoticeList.Name = "cardNoticeList";
        cardNoticeList.Padding = new System.Windows.Forms.Padding(20);
        cardNoticeList.Size = new System.Drawing.Size(636, 335);
        cardNoticeList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(456, 305);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 305);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(136, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–3 / 18 thông báo";
        // 
        // dgvNotices
        // 
        dgvNotices.AllowUserToAddRows = false;
        dgvNotices.AllowUserToDeleteRows = false;
        dgvNotices.AllowUserToResizeColumns = false;
        dgvNotices.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvNotices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvNotices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvNotices.BackgroundColor = System.Drawing.Color.White;
        dgvNotices.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvNotices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvNotices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvNotices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvNotices.DefaultCellStyle = dataGridViewCellStyle3;
        dgvNotices.EnableHeadersVisualStyles = false;
        dgvNotices.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvNotices.Location = new System.Drawing.Point(20, 95);
        dgvNotices.MultiSelect = false;
        dgvNotices.Name = "dgvNotices";
        dgvNotices.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvNotices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvNotices.RowHeadersVisible = false;
        dgvNotices.RowHeadersWidth = 51;
        dgvNotices.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvNotices.Size = new System.Drawing.Size(596, 200);
        dgvNotices.TabIndex = 4;
        // 
        // cboAudienceFilter
        // 
        cboAudienceFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboAudienceFilter.BackColor = System.Drawing.Color.Transparent;
        cboAudienceFilter.CornerRadius = 5;
        cboAudienceFilter.DataSource = null;
        cboAudienceFilter.DisplayMember = "";
        cboAudienceFilter.Location = new System.Drawing.Point(446, 50);
        cboAudienceFilter.Name = "cboAudienceFilter";
        cboAudienceFilter.SelectedIndex = -1;
        cboAudienceFilter.SelectedItem = null;
        cboAudienceFilter.SelectedValue = null;
        cboAudienceFilter.Size = new System.Drawing.Size(170, 32);
        cboAudienceFilter.TabIndex = 3;
        cboAudienceFilter.ValueMember = "";
        // 
        // cboMonthFilter
        // 
        cboMonthFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboMonthFilter.BackColor = System.Drawing.Color.Transparent;
        cboMonthFilter.CornerRadius = 5;
        cboMonthFilter.DataSource = null;
        cboMonthFilter.DisplayMember = "";
        cboMonthFilter.Location = new System.Drawing.Point(286, 50);
        cboMonthFilter.Name = "cboMonthFilter";
        cboMonthFilter.SelectedIndex = -1;
        cboMonthFilter.SelectedItem = null;
        cboMonthFilter.SelectedValue = null;
        cboMonthFilter.Size = new System.Drawing.Size(150, 32);
        cboMonthFilter.TabIndex = 2;
        cboMonthFilter.ValueMember = "";
        // 
        // txtSearchNotice
        // 
        txtSearchNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearchNotice.BackColor = System.Drawing.Color.Transparent;
        txtSearchNotice.CornerRadius = 5;
        txtSearchNotice.ErrorMessage = "";
        txtSearchNotice.HasError = false;
        txtSearchNotice.Location = new System.Drawing.Point(20, 50);
        txtSearchNotice.Name = "txtSearchNotice";
        txtSearchNotice.Placeholder = "Tìm tiêu đề, nội dung...";
        txtSearchNotice.ReadOnly = false;
        txtSearchNotice.Size = new System.Drawing.Size(256, 32);
        txtSearchNotice.TabIndex = 1;
        txtSearchNotice.UseSystemPasswordChar = false;
        // 
        // lblNoticeListTitle
        // 
        lblNoticeListTitle.AutoSize = true;
        lblNoticeListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblNoticeListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblNoticeListTitle.Location = new System.Drawing.Point(20, 16);
        lblNoticeListTitle.Name = "lblNoticeListTitle";
        lblNoticeListTitle.Size = new System.Drawing.Size(200, 25);
        lblNoticeListTitle.TabIndex = 0;
        lblNoticeListTitle.Text = "Danh sách thông báo";
        // 
        // InternalNotificationView
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
        cardCompose.ResumeLayout(false);
        cardCompose.PerformLayout();
        pnlRoles.ResumeLayout(false);
        pnlRoles.PerformLayout();
        cardNoticePreview.ResumeLayout(false);
        cardNoticePreview.PerformLayout();
        cardNoticeList.ResumeLayout(false);
        cardNoticeList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvNotices).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnComposeTop;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardNoticeList;
    private System.Windows.Forms.Label lblNoticeListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchNotice;
    private ECMS.UI.Controls.AppComboBox cboMonthFilter;
    private ECMS.UI.Controls.AppComboBox cboAudienceFilter;
    private ECMS.UI.Controls.AppDataGrid dgvNotices;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppCard cardNoticePreview;
    private System.Windows.Forms.Label lblNoticePreviewTitle;
    private System.Windows.Forms.Label lblNoticePreviewBadge;
    private System.Windows.Forms.Label lblNoticePreviewSender;
    private System.Windows.Forms.Label lblNoticePreviewBody;
    private ECMS.UI.Controls.AppCard cardCompose;
    private System.Windows.Forms.Label lblComposeTitle;
    private System.Windows.Forms.Label lblTitleInput;
    private ECMS.UI.Controls.AppTextBox txtTitleInput;
    private System.Windows.Forms.Label lblRoles;
    private System.Windows.Forms.Panel pnlRoles;
    private System.Windows.Forms.CheckBox chkStudent;
    private System.Windows.Forms.CheckBox chkParent;
    private System.Windows.Forms.CheckBox chkTeacher;
    private System.Windows.Forms.CheckBox chkConsultant;
    private System.Windows.Forms.CheckBox chkAccountant;
    private System.Windows.Forms.CheckBox chkTraining;
    private System.Windows.Forms.Label lblClassScope;
    private ECMS.UI.Controls.AppComboBox cboClassScope;
    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.TextBox txtContent;
    private ECMS.UI.Controls.AppButton btnCancelCompose;
    private ECMS.UI.Controls.AppButton btnSaveDraft;
    private ECMS.UI.Controls.AppButton btnPublishNotice;
}
