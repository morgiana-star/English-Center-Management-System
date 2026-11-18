namespace ECMS.UI.Forms;

partial class EnrollmentDialog
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
        lblEnrollSub = new System.Windows.Forms.Label();
        lblEnrollHeader = new System.Windows.Forms.Label();
        cardEnrollSummary = new ECMS.UI.Controls.AppCard();
        lblTransChecked = new System.Windows.Forms.Label();
        lblTransDuration = new System.Windows.Forms.Label();
        lblTransRoom = new System.Windows.Forms.Label();
        lblTransTeacher = new System.Windows.Forms.Label();
        lblTransNetFee = new System.Windows.Forms.Label();
        lblTransCourse = new System.Windows.Forms.Label();
        lblTransScore = new System.Windows.Forms.Label();
        lblTransPhone = new System.Windows.Forms.Label();
        lblTransName = new System.Windows.Forms.Label();
        lblTransferTitle = new System.Windows.Forms.Label();
        cardClassSelect = new ECMS.UI.Controls.AppCard();
        btnConfirmEnroll = new ECMS.UI.Controls.AppButton();
        btnBackToConsult = new ECMS.UI.Controls.AppButton();
        txtEnrollDiscount = new ECMS.UI.Controls.AppTextBox();
        lblEnrollDiscount = new System.Windows.Forms.Label();
        txtEnrollOriginalFee = new ECMS.UI.Controls.AppTextBox();
        lblEnrollOriginalFee = new System.Windows.Forms.Label();
        cboSubstituteClass = new ECMS.UI.Controls.AppComboBox();
        lblSubstituteClass = new System.Windows.Forms.Label();
        dtpEnrollDate = new System.Windows.Forms.DateTimePicker();
        lblEnrollDate = new System.Windows.Forms.Label();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        lblClassSelectTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        cardEnrollSummary.SuspendLayout();
        cardClassSelect.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblEnrollSub);
        pnlTop.Controls.Add(lblEnrollHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1220, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblEnrollSub
        // 
        lblEnrollSub.AutoSize = true;
        lblEnrollSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEnrollSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblEnrollSub.Location = new System.Drawing.Point(27, 45);
        lblEnrollSub.Name = "lblEnrollSub";
        lblEnrollSub.Size = new System.Drawing.Size(406, 20);
        lblEnrollSub.TabIndex = 1;
        lblEnrollSub.Text = "Nguyễn Minh Anh · TN-0108 · IELTS Foundation · 02/10/2026";
        // 
        // lblEnrollHeader
        // 
        lblEnrollHeader.AutoSize = true;
        lblEnrollHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblEnrollHeader.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEnrollHeader.Location = new System.Drawing.Point(22, 10);
        lblEnrollHeader.Name = "lblEnrollHeader";
        lblEnrollHeader.Size = new System.Drawing.Size(224, 35);
        lblEnrollHeader.TabIndex = 0;
        lblEnrollHeader.Text = "Ghi danh & xếp lớp";
        // 
        // cardEnrollSummary
        // 
        cardEnrollSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardEnrollSummary.BackColor = System.Drawing.Color.White;
        cardEnrollSummary.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardEnrollSummary.BorderWidth = 1;
        cardEnrollSummary.Controls.Add(lblTransChecked);
        cardEnrollSummary.Controls.Add(lblTransDuration);
        cardEnrollSummary.Controls.Add(lblTransRoom);
        cardEnrollSummary.Controls.Add(lblTransTeacher);
        cardEnrollSummary.Controls.Add(lblTransNetFee);
        cardEnrollSummary.Controls.Add(lblTransCourse);
        cardEnrollSummary.Controls.Add(lblTransScore);
        cardEnrollSummary.Controls.Add(lblTransPhone);
        cardEnrollSummary.Controls.Add(lblTransName);
        cardEnrollSummary.Controls.Add(lblTransferTitle);
        cardEnrollSummary.CornerRadius = 8;
        cardEnrollSummary.Location = new System.Drawing.Point(797, 95);
        cardEnrollSummary.Name = "cardEnrollSummary";
        cardEnrollSummary.Padding = new System.Windows.Forms.Padding(16);
        cardEnrollSummary.Size = new System.Drawing.Size(400, 560);
        cardEnrollSummary.TabIndex = 2;
        // 
        // lblTransChecked
        // 
        lblTransChecked.AutoSize = true;
        lblTransChecked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTransChecked.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)163)), ((int)((byte)74)));
        lblTransChecked.Location = new System.Drawing.Point(20, 395);
        lblTransChecked.Name = "lblTransChecked";
        lblTransChecked.Size = new System.Drawing.Size(222, 23);
        lblTransChecked.TabIndex = 9;
        lblTransChecked.Text = "✓ Đã kiểm tra trùng hồ sơ";
        // 
        // lblTransDuration
        // 
        lblTransDuration.AutoSize = true;
        lblTransDuration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransDuration.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransDuration.Location = new System.Drawing.Point(20, 340);
        lblTransDuration.Name = "lblTransDuration";
        lblTransDuration.Size = new System.Drawing.Size(247, 21);
        lblTransDuration.TabIndex = 8;
        lblTransDuration.Text = "Thời gian lớp:  06/10–25/12/2026";
        // 
        // lblTransRoom
        // 
        lblTransRoom.AutoSize = true;
        lblTransRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransRoom.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransRoom.Location = new System.Drawing.Point(20, 300);
        lblTransRoom.Name = "lblTransRoom";
        lblTransRoom.Size = new System.Drawing.Size(236, 21);
        lblTransRoom.TabIndex = 7;
        lblTransRoom.Text = "Phòng / giờ:  P201 · 18:00–20:00";
        // 
        // lblTransTeacher
        // 
        lblTransTeacher.AutoSize = true;
        lblTransTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransTeacher.Location = new System.Drawing.Point(20, 260);
        lblTransTeacher.Name = "lblTransTeacher";
        lblTransTeacher.Size = new System.Drawing.Size(223, 21);
        lblTransTeacher.TabIndex = 6;
        lblTransTeacher.Text = "Giáo viên:  Nguyễn Hoàng Anh";
        // 
        // lblTransNetFee
        // 
        lblTransNetFee.AutoSize = true;
        lblTransNetFee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblTransNetFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblTransNetFee.Location = new System.Drawing.Point(20, 215);
        lblTransNetFee.Name = "lblTransNetFee";
        lblTransNetFee.Size = new System.Drawing.Size(244, 25);
        lblTransNetFee.TabIndex = 5;
        lblTransNetFee.Text = "Học phí ròng:  5.400.000đ";
        // 
        // lblTransCourse
        // 
        lblTransCourse.AutoSize = true;
        lblTransCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransCourse.Location = new System.Drawing.Point(20, 175);
        lblTransCourse.Name = "lblTransCourse";
        lblTransCourse.Size = new System.Drawing.Size(204, 21);
        lblTransCourse.TabIndex = 4;
        lblTransCourse.Text = "Khóa học:  IELTS Foundation";
        // 
        // lblTransScore
        // 
        lblTransScore.AutoSize = true;
        lblTransScore.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransScore.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransScore.Location = new System.Drawing.Point(20, 135);
        lblTransScore.Name = "lblTransScore";
        lblTransScore.Size = new System.Drawing.Size(170, 21);
        lblTransScore.TabIndex = 3;
        lblTransScore.Text = "Điểm đầu vào:  4,0 / 10";
        // 
        // lblTransPhone
        // 
        lblTransPhone.AutoSize = true;
        lblTransPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblTransPhone.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblTransPhone.Location = new System.Drawing.Point(20, 95);
        lblTransPhone.Name = "lblTransPhone";
        lblTransPhone.Size = new System.Drawing.Size(190, 21);
        lblTransPhone.TabIndex = 2;
        lblTransPhone.Text = "Điện thoại:  0908 123 456";
        // 
        // lblTransName
        // 
        lblTransName.AutoSize = true;
        lblTransName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTransName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTransName.Location = new System.Drawing.Point(20, 60);
        lblTransName.Name = "lblTransName";
        lblTransName.Size = new System.Drawing.Size(247, 23);
        lblTransName.TabIndex = 1;
        lblTransName.Text = "Họ và tên:  Nguyễn Minh Anh";
        // 
        // lblTransferTitle
        // 
        lblTransferTitle.AutoSize = true;
        lblTransferTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTransferTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTransferTitle.Location = new System.Drawing.Point(20, 16);
        lblTransferTitle.Name = "lblTransferTitle";
        lblTransferTitle.Size = new System.Drawing.Size(276, 28);
        lblTransferTitle.TabIndex = 0;
        lblTransferTitle.Text = "Thông tin được chuyển tiếp";
        // 
        // cardClassSelect
        // 
        cardClassSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassSelect.BackColor = System.Drawing.Color.White;
        cardClassSelect.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassSelect.BorderWidth = 1;
        cardClassSelect.Controls.Add(btnConfirmEnroll);
        cardClassSelect.Controls.Add(btnBackToConsult);
        cardClassSelect.Controls.Add(txtEnrollDiscount);
        cardClassSelect.Controls.Add(lblEnrollDiscount);
        cardClassSelect.Controls.Add(txtEnrollOriginalFee);
        cardClassSelect.Controls.Add(lblEnrollOriginalFee);
        cardClassSelect.Controls.Add(cboSubstituteClass);
        cardClassSelect.Controls.Add(lblSubstituteClass);
        cardClassSelect.Controls.Add(dtpEnrollDate);
        cardClassSelect.Controls.Add(lblEnrollDate);
        cardClassSelect.Controls.Add(dgvClasses);
        cardClassSelect.Controls.Add(lblClassSelectTitle);
        cardClassSelect.CornerRadius = 8;
        cardClassSelect.Location = new System.Drawing.Point(24, 95);
        cardClassSelect.Name = "cardClassSelect";
        cardClassSelect.Padding = new System.Windows.Forms.Padding(16);
        cardClassSelect.Size = new System.Drawing.Size(745, 560);
        cardClassSelect.TabIndex = 1;
        // 
        // btnConfirmEnroll
        // 
        btnConfirmEnroll.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnConfirmEnroll.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnConfirmEnroll.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnConfirmEnroll.CornerRadius = 6;
        btnConfirmEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
        btnConfirmEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnConfirmEnroll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnConfirmEnroll.ForeColor = System.Drawing.Color.White;
        btnConfirmEnroll.Location = new System.Drawing.Point(570, 500);
        btnConfirmEnroll.Name = "btnConfirmEnroll";
        btnConfirmEnroll.Size = new System.Drawing.Size(155, 36);
        btnConfirmEnroll.TabIndex = 13;
        btnConfirmEnroll.Text = "Xác nhận ghi danh";
        btnConfirmEnroll.UseVisualStyleBackColor = false;
        btnConfirmEnroll.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnBackToConsult
        // 
        btnBackToConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnBackToConsult.BackColor = System.Drawing.Color.White;
        btnBackToConsult.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnBackToConsult.CornerRadius = 6;
        btnBackToConsult.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBackToConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBackToConsult.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnBackToConsult.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnBackToConsult.Location = new System.Drawing.Point(435, 500);
        btnBackToConsult.Name = "btnBackToConsult";
        btnBackToConsult.Size = new System.Drawing.Size(125, 36);
        btnBackToConsult.TabIndex = 12;
        btnBackToConsult.Text = "Quay lại tư vấn";
        btnBackToConsult.UseVisualStyleBackColor = false;
        btnBackToConsult.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtEnrollDiscount
        // 
        txtEnrollDiscount.BackColor = System.Drawing.Color.Transparent;
        txtEnrollDiscount.CornerRadius = 6;
        txtEnrollDiscount.ErrorMessage = "";
        txtEnrollDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEnrollDiscount.HasError = false;
        txtEnrollDiscount.Location = new System.Drawing.Point(392, 450);
        txtEnrollDiscount.Name = "txtEnrollDiscount";
        txtEnrollDiscount.Placeholder = "600.000đ";
        txtEnrollDiscount.ReadOnly = true;
        txtEnrollDiscount.Size = new System.Drawing.Size(305, 32);
        txtEnrollDiscount.TabIndex = 10;
        txtEnrollDiscount.UseSystemPasswordChar = false;
        // 
        // lblEnrollDiscount
        // 
        lblEnrollDiscount.AutoSize = true;
        lblEnrollDiscount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEnrollDiscount.Location = new System.Drawing.Point(392, 427);
        lblEnrollDiscount.Name = "lblEnrollDiscount";
        lblEnrollDiscount.Size = new System.Drawing.Size(90, 20);
        lblEnrollDiscount.TabIndex = 9;
        lblEnrollDiscount.Text = "Ưu đãi 10%";
        // 
        // txtEnrollOriginalFee
        // 
        txtEnrollOriginalFee.BackColor = System.Drawing.Color.Transparent;
        txtEnrollOriginalFee.CornerRadius = 6;
        txtEnrollOriginalFee.ErrorMessage = "";
        txtEnrollOriginalFee.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtEnrollOriginalFee.HasError = false;
        txtEnrollOriginalFee.Location = new System.Drawing.Point(19, 450);
        txtEnrollOriginalFee.Name = "txtEnrollOriginalFee";
        txtEnrollOriginalFee.Placeholder = "6.000.000đ";
        txtEnrollOriginalFee.ReadOnly = true;
        txtEnrollOriginalFee.Size = new System.Drawing.Size(300, 32);
        txtEnrollOriginalFee.TabIndex = 8;
        txtEnrollOriginalFee.UseSystemPasswordChar = false;
        // 
        // lblEnrollOriginalFee
        // 
        lblEnrollOriginalFee.AutoSize = true;
        lblEnrollOriginalFee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollOriginalFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEnrollOriginalFee.Location = new System.Drawing.Point(19, 427);
        lblEnrollOriginalFee.Name = "lblEnrollOriginalFee";
        lblEnrollOriginalFee.Size = new System.Drawing.Size(91, 20);
        lblEnrollOriginalFee.TabIndex = 7;
        lblEnrollOriginalFee.Text = "Học phí gốc";
        // 
        // cboSubstituteClass
        // 
        cboSubstituteClass.BackColor = System.Drawing.Color.White;
        cboSubstituteClass.CornerRadius = 5;
        cboSubstituteClass.DataSource = null;
        cboSubstituteClass.DisplayMember = "";
        cboSubstituteClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboSubstituteClass.Location = new System.Drawing.Point(392, 375);
        cboSubstituteClass.Name = "cboSubstituteClass";
        cboSubstituteClass.SelectedIndex = -1;
        cboSubstituteClass.SelectedItem = null;
        cboSubstituteClass.SelectedValue = null;
        cboSubstituteClass.Size = new System.Drawing.Size(305, 32);
        cboSubstituteClass.TabIndex = 6;
        cboSubstituteClass.ValueMember = "";
        // 
        // lblSubstituteClass
        // 
        lblSubstituteClass.AutoSize = true;
        lblSubstituteClass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblSubstituteClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblSubstituteClass.Location = new System.Drawing.Point(392, 352);
        lblSubstituteClass.Name = "lblSubstituteClass";
        lblSubstituteClass.Size = new System.Drawing.Size(108, 20);
        lblSubstituteClass.TabIndex = 5;
        lblSubstituteClass.Text = "Lớp thay thế *";
        // 
        // dtpEnrollDate
        // 
        dtpEnrollDate.CustomFormat = "dd/MM/yyyy";
        dtpEnrollDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEnrollDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEnrollDate.Location = new System.Drawing.Point(19, 375);
        dtpEnrollDate.Name = "dtpEnrollDate";
        dtpEnrollDate.Size = new System.Drawing.Size(300, 29);
        dtpEnrollDate.TabIndex = 4;
        // 
        // lblEnrollDate
        // 
        lblEnrollDate.AutoSize = true;
        lblEnrollDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblEnrollDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblEnrollDate.Location = new System.Drawing.Point(19, 352);
        lblEnrollDate.Name = "lblEnrollDate";
        lblEnrollDate.Size = new System.Drawing.Size(122, 20);
        lblEnrollDate.TabIndex = 3;
        lblEnrollDate.Text = "Ngày ghi danh *";
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
        dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
        dgvClasses.ColumnHeadersHeight = 36;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
        dgvClasses.Location = new System.Drawing.Point(20, 47);
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
        dgvClasses.Size = new System.Drawing.Size(705, 290);
        dgvClasses.TabIndex = 2;
        // 
        // lblClassSelectTitle
        // 
        lblClassSelectTitle.AutoSize = true;
        lblClassSelectTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblClassSelectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblClassSelectTitle.Location = new System.Drawing.Point(20, 16);
        lblClassSelectTitle.Name = "lblClassSelectTitle";
        lblClassSelectTitle.Size = new System.Drawing.Size(202, 28);
        lblClassSelectTitle.TabIndex = 0;
        lblClassSelectTitle.Text = "Chọn lớp học cụ thể";
        // 
        // EnrollmentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(cardEnrollSummary);
        Controls.Add(cardClassSelect);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Ghi danh & xếp lớp — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardEnrollSummary.ResumeLayout(false);
        cardEnrollSummary.PerformLayout();
        cardClassSelect.ResumeLayout(false);
        cardClassSelect.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblEnrollHeader;
    private System.Windows.Forms.Label lblEnrollSub;

    private ECMS.UI.Controls.AppCard cardClassSelect;
    private System.Windows.Forms.Label lblClassSelectTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Label lblEnrollDate;
    private System.Windows.Forms.DateTimePicker dtpEnrollDate;
    private System.Windows.Forms.Label lblSubstituteClass;
    private ECMS.UI.Controls.AppComboBox cboSubstituteClass;
    private System.Windows.Forms.Label lblEnrollOriginalFee;
    private ECMS.UI.Controls.AppTextBox txtEnrollOriginalFee;
    private System.Windows.Forms.Label lblEnrollDiscount;
    private ECMS.UI.Controls.AppTextBox txtEnrollDiscount;
    private ECMS.UI.Controls.AppButton btnBackToConsult;
    private ECMS.UI.Controls.AppButton btnConfirmEnroll;

    private ECMS.UI.Controls.AppCard cardEnrollSummary;
    private System.Windows.Forms.Label lblTransferTitle;
    private System.Windows.Forms.Label lblTransName;
    private System.Windows.Forms.Label lblTransPhone;
    private System.Windows.Forms.Label lblTransScore;
    private System.Windows.Forms.Label lblTransCourse;
    private System.Windows.Forms.Label lblTransNetFee;
    private System.Windows.Forms.Label lblTransTeacher;
    private System.Windows.Forms.Label lblTransRoom;
    private System.Windows.Forms.Label lblTransDuration;
    private System.Windows.Forms.Label lblTransChecked;
}
