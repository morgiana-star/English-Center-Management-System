namespace ECMS.UI.UserControls;

partial class TeacherGradeEntryView
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
        btnBackToList = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardGradeGrid = new ECMS.UI.Controls.AppCard();
        pnlEditStudentScore = new System.Windows.Forms.Panel();
        btnSaveGrades = new ECMS.UI.Controls.AppButton();
        btnCancelEdit = new ECMS.UI.Controls.AppButton();
        txtComment = new ECMS.UI.Controls.AppTextBox();
        lblComment = new System.Windows.Forms.Label();
        lblScoreError = new System.Windows.Forms.Label();
        txtCurrentScore = new ECMS.UI.Controls.AppTextBox();
        lblCurrentStudentTitle = new System.Windows.Forms.Label();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvGrades = new ECMS.UI.Controls.AppDataGrid();
        lblGridTitle = new System.Windows.Forms.Label();
        pnlStats = new System.Windows.Forms.Panel();
        statTotalWeight = new ECMS.UI.Controls.AppStatCard();
        statNeedsFix = new ECMS.UI.Controls.AppStatCard();
        statValid = new ECMS.UI.Controls.AppStatCard();
        statEntered = new ECMS.UI.Controls.AppStatCard();
        bannerError = new ECMS.UI.Controls.AppBanner();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGradeGrid.SuspendLayout();
        pnlEditStudentScore.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
        pnlStats.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnBackToList);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnBackToList
        // 
        btnBackToList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnBackToList.BackColor = System.Drawing.Color.White;
        btnBackToList.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToList.CornerRadius = 5;
        btnBackToList.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnBackToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToList.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackToList.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnBackToList.Location = new System.Drawing.Point(976, 20);
        btnBackToList.Name = "btnBackToList";
        btnBackToList.Size = new System.Drawing.Size(160, 36);
        btnBackToList.TabIndex = 3;
        btnBackToList.Text = "← Danh sách bài thi";
        btnBackToList.UseVisualStyleBackColor = false;
        btnBackToList.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(386, 32);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Nhập điểm cuối khóa · IELTS-F02";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardGradeGrid);
        pnlBody.Controls.Add(pnlStats);
        pnlBody.Controls.Add(bannerError);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardGradeGrid
        // 
        cardGradeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardGradeGrid.BackColor = System.Drawing.Color.White;
        cardGradeGrid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGradeGrid.BorderWidth = 1;
        cardGradeGrid.Controls.Add(pnlEditStudentScore);
        cardGradeGrid.Controls.Add(lblPagingNav);
        cardGradeGrid.Controls.Add(lblPagingInfo);
        cardGradeGrid.Controls.Add(dgvGrades);
        cardGradeGrid.Controls.Add(lblGridTitle);
        cardGradeGrid.CornerRadius = 6;
        cardGradeGrid.Location = new System.Drawing.Point(24, 146);
        cardGradeGrid.Name = "cardGradeGrid";
        cardGradeGrid.Padding = new System.Windows.Forms.Padding(20);
        cardGradeGrid.Size = new System.Drawing.Size(1112, 519);
        cardGradeGrid.TabIndex = 2;
        // 
        // pnlEditStudentScore
        // 
        pnlEditStudentScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlEditStudentScore.Controls.Add(btnSaveGrades);
        pnlEditStudentScore.Controls.Add(btnCancelEdit);
        pnlEditStudentScore.Controls.Add(txtComment);
        pnlEditStudentScore.Controls.Add(lblComment);
        pnlEditStudentScore.Controls.Add(lblScoreError);
        pnlEditStudentScore.Controls.Add(txtCurrentScore);
        pnlEditStudentScore.Controls.Add(lblCurrentStudentTitle);
        pnlEditStudentScore.Location = new System.Drawing.Point(20, 399);
        pnlEditStudentScore.Name = "pnlEditStudentScore";
        pnlEditStudentScore.Size = new System.Drawing.Size(1072, 100);
        pnlEditStudentScore.TabIndex = 4;
        // 
        // btnSaveGrades
        // 
        btnSaveGrades.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveGrades.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSaveGrades.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveGrades.CornerRadius = 5;
        btnSaveGrades.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveGrades.FlatAppearance.BorderSize = 0;
        btnSaveGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSaveGrades.ForeColor = System.Drawing.Color.White;
        btnSaveGrades.Location = new System.Drawing.Point(952, 60);
        btnSaveGrades.Name = "btnSaveGrades";
        btnSaveGrades.Size = new System.Drawing.Size(110, 34);
        btnSaveGrades.TabIndex = 6;
        btnSaveGrades.Text = "Lưu điểm";
        btnSaveGrades.UseVisualStyleBackColor = false;
        btnSaveGrades.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelEdit
        // 
        btnCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelEdit.BackColor = System.Drawing.Color.White;
        btnCancelEdit.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelEdit.CornerRadius = 5;
        btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancelEdit.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnCancelEdit.Location = new System.Drawing.Point(842, 60);
        btnCancelEdit.Name = "btnCancelEdit";
        btnCancelEdit.Size = new System.Drawing.Size(100, 34);
        btnCancelEdit.TabIndex = 5;
        btnCancelEdit.Text = "Hủy thay đổi";
        btnCancelEdit.UseVisualStyleBackColor = false;
        btnCancelEdit.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtComment
        // 
        txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtComment.BackColor = System.Drawing.Color.Transparent;
        txtComment.CornerRadius = 5;
        txtComment.ErrorMessage = "";
        txtComment.HasError = false;
        txtComment.Location = new System.Drawing.Point(400, 24);
        txtComment.Name = "txtComment";
        txtComment.Placeholder = "Hoàn thành tốt phần đọc và viết.";
        txtComment.ReadOnly = false;
        txtComment.Size = new System.Drawing.Size(662, 32);
        txtComment.TabIndex = 4;
        txtComment.UseSystemPasswordChar = false;
        // 
        // lblComment
        // 
        lblComment.AutoSize = true;
        lblComment.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblComment.Location = new System.Drawing.Point(400, 4);
        lblComment.Name = "lblComment";
        lblComment.Size = new System.Drawing.Size(73, 20);
        lblComment.TabIndex = 3;
        lblComment.Text = "Nhận xét";
        // 
        // lblScoreError
        // 
        lblScoreError.AutoSize = true;
        lblScoreError.Font = new System.Drawing.Font("Segoe UI", 8F);
        lblScoreError.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        lblScoreError.Location = new System.Drawing.Point(0, 60);
        lblScoreError.Name = "lblScoreError";
        lblScoreError.Size = new System.Drawing.Size(227, 19);
        lblScoreError.TabIndex = 2;
        lblScoreError.Text = "Chỉ nhận 0–10. Nhập 8,0 để sửa lỗi.";
        // 
        // txtCurrentScore
        // 
        txtCurrentScore.BackColor = System.Drawing.Color.Transparent;
        txtCurrentScore.CornerRadius = 5;
        txtCurrentScore.ErrorMessage = "";
        txtCurrentScore.HasError = false;
        txtCurrentScore.Location = new System.Drawing.Point(0, 24);
        txtCurrentScore.Name = "txtCurrentScore";
        txtCurrentScore.Placeholder = "11";
        txtCurrentScore.ReadOnly = false;
        txtCurrentScore.Size = new System.Drawing.Size(360, 32);
        txtCurrentScore.TabIndex = 1;
        txtCurrentScore.UseSystemPasswordChar = false;
        // 
        // lblCurrentStudentTitle
        // 
        lblCurrentStudentTitle.AutoSize = true;
        lblCurrentStudentTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblCurrentStudentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCurrentStudentTitle.Location = new System.Drawing.Point(0, 4);
        lblCurrentStudentTitle.Name = "lblCurrentStudentTitle";
        lblCurrentStudentTitle.Size = new System.Drawing.Size(225, 20);
        lblCurrentStudentTitle.TabIndex = 0;
        lblCurrentStudentTitle.Text = "Điểm đang nhập · Trần Gia Bảo";
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblPagingNav.Location = new System.Drawing.Point(934, 369);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(160, 20);
        lblPagingNav.TabIndex = 3;
        lblPagingNav.Text = "< Trước   [1]   2   Sau >";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 369);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(122, 20);
        lblPagingInfo.TabIndex = 2;
        lblPagingInfo.Text = "1–5 / 20 học viên";
        // 
        // dgvGrades
        // 
        dgvGrades.AllowUserToAddRows = false;
        dgvGrades.AllowUserToDeleteRows = false;
        dgvGrades.AllowUserToResizeColumns = false;
        dgvGrades.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvGrades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvGrades.BackgroundColor = System.Drawing.Color.White;
        dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvGrades.DefaultCellStyle = dataGridViewCellStyle3;
        dgvGrades.EnableHeadersVisualStyles = false;
        dgvGrades.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvGrades.Location = new System.Drawing.Point(20, 50);
        dgvGrades.MultiSelect = false;
        dgvGrades.Name = "dgvGrades";
        dgvGrades.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvGrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvGrades.RowHeadersVisible = false;
        dgvGrades.RowHeadersWidth = 51;
        dgvGrades.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvGrades.Size = new System.Drawing.Size(1072, 309);
        dgvGrades.TabIndex = 1;
        // 
        // lblGridTitle
        // 
        lblGridTitle.AutoSize = true;
        lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblGridTitle.Location = new System.Drawing.Point(20, 16);
        lblGridTitle.Name = "lblGridTitle";
        lblGridTitle.Size = new System.Drawing.Size(151, 25);
        lblGridTitle.TabIndex = 0;
        lblGridTitle.Text = "Lưới nhập điểm";
        // 
        // pnlStats
        // 
        pnlStats.Controls.Add(statTotalWeight);
        pnlStats.Controls.Add(statNeedsFix);
        pnlStats.Controls.Add(statValid);
        pnlStats.Controls.Add(statEntered);
        pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStats.Location = new System.Drawing.Point(24, 24);
        pnlStats.Name = "pnlStats";
        pnlStats.Size = new System.Drawing.Size(1112, 101);
        pnlStats.TabIndex = 1;
        // 
        // statTotalWeight
        // 
        statTotalWeight.BackColor = System.Drawing.Color.White;
        statTotalWeight.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statTotalWeight.BorderWidth = 1;
        statTotalWeight.CornerRadius = 6;
        statTotalWeight.Location = new System.Drawing.Point(834, 0);
        statTotalWeight.Name = "statTotalWeight";
        statTotalWeight.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statTotalWeight.Size = new System.Drawing.Size(260, 98);
        statTotalWeight.Subtext = "Ghi chú phụ";
        statTotalWeight.TabIndex = 3;
        statTotalWeight.Title = "Tổng trọng số";
        statTotalWeight.Value = "100%";
        // 
        // statNeedsFix
        // 
        statNeedsFix.BackColor = System.Drawing.Color.White;
        statNeedsFix.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statNeedsFix.BorderWidth = 1;
        statNeedsFix.CornerRadius = 6;
        statNeedsFix.Location = new System.Drawing.Point(556, 0);
        statNeedsFix.Name = "statNeedsFix";
        statNeedsFix.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statNeedsFix.Size = new System.Drawing.Size(260, 98);
        statNeedsFix.Subtext = "Ghi chú phụ";
        statNeedsFix.TabIndex = 2;
        statNeedsFix.Title = "Cần sửa";
        statNeedsFix.Value = "1";
        // 
        // statValid
        // 
        statValid.BackColor = System.Drawing.Color.White;
        statValid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statValid.BorderWidth = 1;
        statValid.CornerRadius = 6;
        statValid.Location = new System.Drawing.Point(278, 0);
        statValid.Name = "statValid";
        statValid.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statValid.Size = new System.Drawing.Size(260, 98);
        statValid.Subtext = "Ghi chú phụ";
        statValid.TabIndex = 1;
        statValid.Title = "Điểm hợp lệ";
        statValid.Value = "19";
        // 
        // statEntered
        // 
        statEntered.BackColor = System.Drawing.Color.White;
        statEntered.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        statEntered.BorderWidth = 1;
        statEntered.CornerRadius = 6;
        statEntered.Location = new System.Drawing.Point(0, 0);
        statEntered.Name = "statEntered";
        statEntered.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        statEntered.Size = new System.Drawing.Size(260, 98);
        statEntered.Subtext = "Ghi chú phụ";
        statEntered.TabIndex = 0;
        statEntered.Title = "Đã nhập";
        statEntered.Value = "20 / 20";
        // 
        // bannerError
        // 
        bannerError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        bannerError.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)226)), ((int)((byte)226)));
        bannerError.BannerType = ECMS.UI.Controls.BannerType.Danger;
        bannerError.Location = new System.Drawing.Point(24, 20);
        bannerError.Message = "Nút Lưu bị khóa; các điểm hợp lệ vẫn được giữ.";
        bannerError.Name = "bannerError";
        bannerError.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
        bannerError.Size = new System.Drawing.Size(1112, 55);
        bannerError.TabIndex = 0;
        bannerError.Title = "✕ Trần Gia Bảo: điểm 11 vượt thang 0–10.";
        bannerError.Variant = ECMS.UI.Controls.BannerVariant.Danger;
        // 
        // TeacherGradeEntryView
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
        cardGradeGrid.ResumeLayout(false);
        cardGradeGrid.PerformLayout();
        pnlEditStudentScore.ResumeLayout(false);
        pnlEditStudentScore.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
        pnlStats.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnBackToList;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppBanner bannerError;
    private System.Windows.Forms.Panel pnlStats;
    private ECMS.UI.Controls.AppStatCard statEntered;
    private ECMS.UI.Controls.AppStatCard statValid;
    private ECMS.UI.Controls.AppStatCard statNeedsFix;
    private ECMS.UI.Controls.AppStatCard statTotalWeight;
    private ECMS.UI.Controls.AppCard cardGradeGrid;
    private System.Windows.Forms.Label lblGridTitle;
    private ECMS.UI.Controls.AppDataGrid dgvGrades;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Panel pnlEditStudentScore;
    private System.Windows.Forms.Label lblCurrentStudentTitle;
    private ECMS.UI.Controls.AppTextBox txtCurrentScore;
    private System.Windows.Forms.Label lblScoreError;
    private System.Windows.Forms.Label lblComment;
    private ECMS.UI.Controls.AppTextBox txtComment;
    private ECMS.UI.Controls.AppButton btnCancelEdit;
    private ECMS.UI.Controls.AppButton btnSaveGrades;
}
