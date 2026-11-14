namespace ECMS.UI.Forms;

partial class CollectTuitionDialog
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
        lblTitle = new System.Windows.Forms.Label();
        pnlStepper = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.TableLayoutPanel();
        pnlLeftCard = new ECMS.UI.Controls.AppCard();
        lblLeftCardTitle = new System.Windows.Forms.Label();
        pnlLeftActions = new System.Windows.Forms.FlowLayoutPanel();
        btnContinueConfirm = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        txtNote = new ECMS.UI.Controls.AppTextBox();
        lblNote = new System.Windows.Forms.Label();
        txtReference = new ECMS.UI.Controls.AppTextBox();
        lblReference = new System.Windows.Forms.Label();
        lblAmountError = new System.Windows.Forms.Label();
        txtAmount = new ECMS.UI.Controls.AppTextBox();
        lblAmount = new System.Windows.Forms.Label();
        cboPaymentMethod = new ECMS.UI.Controls.AppComboBox();
        lblPaymentMethod = new System.Windows.Forms.Label();
        cboPaymentType = new ECMS.UI.Controls.AppComboBox();
        lblPaymentType = new System.Windows.Forms.Label();
        txtPaymentDate = new ECMS.UI.Controls.AppTextBox();
        lblPaymentDate = new System.Windows.Forms.Label();
        txtStudentInfo = new ECMS.UI.Controls.AppTextBox();
        lblStudentInfo = new System.Windows.Forms.Label();
        pnlRightCard = new ECMS.UI.Controls.AppCard();
        lblRightCardTitle = new System.Windows.Forms.Label();
        btnFillRemaining = new ECMS.UI.Controls.AppButton();
        lblDueDateVal = new System.Windows.Forms.Label();
        lblDueDateTitle = new System.Windows.Forms.Label();
        lblRemainingVal = new System.Windows.Forms.Label();
        lblRemainingTitle = new System.Windows.Forms.Label();
        lblPaidVal = new System.Windows.Forms.Label();
        lblPaidTitle = new System.Windows.Forms.Label();
        lblNetTuitionVal = new System.Windows.Forms.Label();
        lblNetTuitionTitle = new System.Windows.Forms.Label();
        lblDiscountVal = new System.Windows.Forms.Label();
        lblDiscountTitle = new System.Windows.Forms.Label();
        lblBaseTuitionVal = new System.Windows.Forms.Label();
        lblBaseTuitionTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlStepper.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlLeftCard.SuspendLayout();
        pnlLeftActions.SuspendLayout();
        pnlRightCard.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(1200, 76);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(23, 29);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(390, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thu học phí · Nguyễn Minh Anh";
        // 
        // pnlStepper
        // 
        pnlStepper.BackColor = System.Drawing.Color.White;
        pnlStepper.Controls.Add(lblStep4);
        pnlStepper.Controls.Add(lblStep3);
        pnlStepper.Controls.Add(lblStep2);
        pnlStepper.Controls.Add(lblStep1);
        pnlStepper.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStepper.Location = new System.Drawing.Point(0, 76);
        pnlStepper.Name = "pnlStepper";
        pnlStepper.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
        pnlStepper.Size = new System.Drawing.Size(1200, 38);
        pnlStepper.TabIndex = 1;
        // 
        // lblStep4
        // 
        lblStep4.AutoSize = true;
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblStep4.Location = new System.Drawing.Point(600, 10);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(85, 20);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "4. Phiếu thu";
        // 
        // lblStep3
        // 
        lblStep3.AutoSize = true;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblStep3.Location = new System.Drawing.Point(400, 10);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(146, 20);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "3. Kiểm tra & xác nhận";
        // 
        // lblStep2
        // 
        lblStep2.AutoSize = true;
        lblStep2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep2.Location = new System.Drawing.Point(200, 10);
        lblStep2.Name = "lblStep2";
        lblStep2.Size = new System.Drawing.Size(149, 20);
        lblStep2.TabIndex = 1;
        lblStep2.Text = "• 2. Nhập khoản thu";
        // 
        // lblStep1
        // 
        lblStep1.AutoSize = true;
        lblStep1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep1.Location = new System.Drawing.Point(24, 10);
        lblStep1.Name = "lblStep1";
        lblStep1.Size = new System.Drawing.Size(140, 20);
        lblStep1.TabIndex = 0;
        lblStep1.Text = "✓ 1. Chọn học viên";
        // 
        // pnlBody
        // 
        pnlBody.ColumnCount = 2;
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
        pnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
        pnlBody.Controls.Add(pnlLeftCard, 0, 0);
        pnlBody.Controls.Add(pnlRightCard, 1, 0);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 114);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 16);
        pnlBody.RowCount = 1;
        pnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBody.Size = new System.Drawing.Size(1200, 626);
        pnlBody.TabIndex = 2;
        // 
        // pnlLeftCard
        // 
        pnlLeftCard.BackColor = System.Drawing.Color.White;
        pnlLeftCard.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlLeftCard.BorderWidth = 1;
        pnlLeftCard.Controls.Add(lblLeftCardTitle);
        pnlLeftCard.Controls.Add(pnlLeftActions);
        pnlLeftCard.Controls.Add(txtNote);
        pnlLeftCard.Controls.Add(lblNote);
        pnlLeftCard.Controls.Add(txtReference);
        pnlLeftCard.Controls.Add(lblReference);
        pnlLeftCard.Controls.Add(lblAmountError);
        pnlLeftCard.Controls.Add(txtAmount);
        pnlLeftCard.Controls.Add(lblAmount);
        pnlLeftCard.Controls.Add(cboPaymentMethod);
        pnlLeftCard.Controls.Add(lblPaymentMethod);
        pnlLeftCard.Controls.Add(cboPaymentType);
        pnlLeftCard.Controls.Add(lblPaymentType);
        pnlLeftCard.Controls.Add(txtPaymentDate);
        pnlLeftCard.Controls.Add(lblPaymentDate);
        pnlLeftCard.Controls.Add(txtStudentInfo);
        pnlLeftCard.Controls.Add(lblStudentInfo);
        pnlLeftCard.CornerRadius = 6;
        pnlLeftCard.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlLeftCard.Location = new System.Drawing.Point(23, 15);
        pnlLeftCard.Name = "pnlLeftCard";
        pnlLeftCard.Padding = new System.Windows.Forms.Padding(20);
        pnlLeftCard.Size = new System.Drawing.Size(736, 592);
        pnlLeftCard.TabIndex = 0;
        // 
        // lblLeftCardTitle
        // 
        lblLeftCardTitle.AutoSize = true;
        lblLeftCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblLeftCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblLeftCardTitle.Location = new System.Drawing.Point(20, 16);
        lblLeftCardTitle.Name = "lblLeftCardTitle";
        lblLeftCardTitle.Size = new System.Drawing.Size(143, 25);
        lblLeftCardTitle.TabIndex = 17;
        lblLeftCardTitle.Text = "Khoản thu mới";
        // 
        // pnlLeftActions
        // 
        pnlLeftActions.Controls.Add(btnContinueConfirm);
        pnlLeftActions.Controls.Add(btnCancel);
        pnlLeftActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlLeftActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlLeftActions.Location = new System.Drawing.Point(20, 514);
        pnlLeftActions.Name = "pnlLeftActions";
        pnlLeftActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
        pnlLeftActions.Size = new System.Drawing.Size(696, 58);
        pnlLeftActions.TabIndex = 16;
        // 
        // btnContinueConfirm
        // 
        btnContinueConfirm.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnContinueConfirm.CornerRadius = 5;
        btnContinueConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
        btnContinueConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnContinueConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnContinueConfirm.Location = new System.Drawing.Point(543, 11);
        btnContinueConfirm.Name = "btnContinueConfirm";
        btnContinueConfirm.Size = new System.Drawing.Size(150, 36);
        btnContinueConfirm.TabIndex = 0;
        btnContinueConfirm.Text = "Tiếp tục xác nhận";
        btnContinueConfirm.UseVisualStyleBackColor = true;
        btnContinueConfirm.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(437, 11);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy thu";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtNote
        // 
        txtNote.BackColor = System.Drawing.Color.Transparent;
        txtNote.CornerRadius = 5;
        txtNote.ErrorMessage = "";
        txtNote.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNote.HasError = false;
        txtNote.Location = new System.Drawing.Point(20, 354);
        txtNote.Name = "txtNote";
        txtNote.Placeholder = "";
        txtNote.ReadOnly = false;
        txtNote.Size = new System.Drawing.Size(670, 36);
        txtNote.TabIndex = 14;
        txtNote.UseSystemPasswordChar = false;
        // 
        // lblNote
        // 
        lblNote.AutoSize = true;
        lblNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNote.Location = new System.Drawing.Point(20, 334);
        lblNote.Name = "lblNote";
        lblNote.Size = new System.Drawing.Size(70, 20);
        lblNote.TabIndex = 13;
        lblNote.Text = "Diễn giải";
        // 
        // txtReference
        // 
        txtReference.BackColor = System.Drawing.Color.Transparent;
        txtReference.CornerRadius = 5;
        txtReference.ErrorMessage = "";
        txtReference.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtReference.HasError = false;
        txtReference.Location = new System.Drawing.Point(20, 288);
        txtReference.Name = "txtReference";
        txtReference.Placeholder = "";
        txtReference.ReadOnly = false;
        txtReference.Size = new System.Drawing.Size(670, 36);
        txtReference.TabIndex = 12;
        txtReference.UseSystemPasswordChar = false;
        // 
        // lblReference
        // 
        lblReference.AutoSize = true;
        lblReference.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblReference.Location = new System.Drawing.Point(20, 268);
        lblReference.Name = "lblReference";
        lblReference.Size = new System.Drawing.Size(191, 20);
        lblReference.TabIndex = 11;
        lblReference.Text = "Tham chiếu chuyển khoản";
        // 
        // lblAmountError
        // 
        lblAmountError.AutoSize = true;
        lblAmountError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblAmountError.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblAmountError.Location = new System.Drawing.Point(22, 244);
        lblAmountError.Name = "lblAmountError";
        lblAmountError.Size = new System.Drawing.Size(372, 20);
        lblAmountError.TabIndex = 10;
        lblAmountError.Text = "Vượt số dư 3.400.000đ. Số tiền phải >0 và ≤3.400.000đ.";
        lblAmountError.Visible = false;
        // 
        // txtAmount
        // 
        txtAmount.BackColor = System.Drawing.Color.Transparent;
        txtAmount.CornerRadius = 5;
        txtAmount.ErrorMessage = "";
        txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        txtAmount.HasError = false;
        txtAmount.Location = new System.Drawing.Point(20, 204);
        txtAmount.Name = "txtAmount";
        txtAmount.Placeholder = "";
        txtAmount.ReadOnly = false;
        txtAmount.Size = new System.Drawing.Size(670, 36);
        txtAmount.TabIndex = 9;
        txtAmount.UseSystemPasswordChar = false;
        // 
        // lblAmount
        // 
        lblAmount.AutoSize = true;
        lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAmount.Location = new System.Drawing.Point(20, 184);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new System.Drawing.Size(96, 20);
        lblAmount.TabIndex = 8;
        lblAmount.Text = "Số tiền thu *";
        // 
        // cboPaymentMethod
        // 
        cboPaymentMethod.BackColor = System.Drawing.Color.Transparent;
        cboPaymentMethod.CornerRadius = 5;
        cboPaymentMethod.DataSource = null;
        cboPaymentMethod.DisplayMember = "";
        cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboPaymentMethod.Location = new System.Drawing.Point(370, 136);
        cboPaymentMethod.Name = "cboPaymentMethod";
        cboPaymentMethod.SelectedIndex = -1;
        cboPaymentMethod.SelectedItem = null;
        cboPaymentMethod.SelectedValue = null;
        cboPaymentMethod.Size = new System.Drawing.Size(320, 35);
        cboPaymentMethod.TabIndex = 7;
        cboPaymentMethod.ValueMember = "";
        // 
        // lblPaymentMethod
        // 
        lblPaymentMethod.AutoSize = true;
        lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentMethod.Location = new System.Drawing.Point(370, 116);
        lblPaymentMethod.Name = "lblPaymentMethod";
        lblPaymentMethod.Size = new System.Drawing.Size(89, 20);
        lblPaymentMethod.TabIndex = 6;
        lblPaymentMethod.Text = "Hình thức *";
        // 
        // cboPaymentType
        // 
        cboPaymentType.BackColor = System.Drawing.Color.Transparent;
        cboPaymentType.CornerRadius = 5;
        cboPaymentType.DataSource = null;
        cboPaymentType.DisplayMember = "";
        cboPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboPaymentType.Location = new System.Drawing.Point(20, 136);
        cboPaymentType.Name = "cboPaymentType";
        cboPaymentType.SelectedIndex = -1;
        cboPaymentType.SelectedItem = null;
        cboPaymentType.SelectedValue = null;
        cboPaymentType.Size = new System.Drawing.Size(320, 35);
        cboPaymentType.TabIndex = 5;
        cboPaymentType.ValueMember = "";
        // 
        // lblPaymentType
        // 
        lblPaymentType.AutoSize = true;
        lblPaymentType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentType.Location = new System.Drawing.Point(20, 116);
        lblPaymentType.Name = "lblPaymentType";
        lblPaymentType.Size = new System.Drawing.Size(132, 20);
        lblPaymentType.TabIndex = 4;
        lblPaymentType.Text = "Kiểu thanh toán *";
        // 
        // txtPaymentDate
        // 
        txtPaymentDate.BackColor = System.Drawing.Color.Transparent;
        txtPaymentDate.CornerRadius = 5;
        txtPaymentDate.ErrorMessage = "";
        txtPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtPaymentDate.HasError = false;
        txtPaymentDate.Location = new System.Drawing.Point(370, 68);
        txtPaymentDate.Name = "txtPaymentDate";
        txtPaymentDate.Placeholder = "";
        txtPaymentDate.ReadOnly = false;
        txtPaymentDate.Size = new System.Drawing.Size(320, 36);
        txtPaymentDate.TabIndex = 3;
        txtPaymentDate.UseSystemPasswordChar = false;
        // 
        // lblPaymentDate
        // 
        lblPaymentDate.AutoSize = true;
        lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaymentDate.Location = new System.Drawing.Point(370, 48);
        lblPaymentDate.Name = "lblPaymentDate";
        lblPaymentDate.Size = new System.Drawing.Size(85, 20);
        lblPaymentDate.TabIndex = 2;
        lblPaymentDate.Text = "Ngày thu *";
        // 
        // txtStudentInfo
        // 
        txtStudentInfo.BackColor = System.Drawing.Color.Transparent;
        txtStudentInfo.CornerRadius = 5;
        txtStudentInfo.Enabled = false;
        txtStudentInfo.ErrorMessage = "";
        txtStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtStudentInfo.HasError = false;
        txtStudentInfo.Location = new System.Drawing.Point(20, 68);
        txtStudentInfo.Name = "txtStudentInfo";
        txtStudentInfo.Placeholder = "";
        txtStudentInfo.ReadOnly = false;
        txtStudentInfo.Size = new System.Drawing.Size(320, 36);
        txtStudentInfo.TabIndex = 1;
        txtStudentInfo.UseSystemPasswordChar = false;
        // 
        // lblStudentInfo
        // 
        lblStudentInfo.AutoSize = true;
        lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStudentInfo.Location = new System.Drawing.Point(20, 48);
        lblStudentInfo.Name = "lblStudentInfo";
        lblStudentInfo.Size = new System.Drawing.Size(117, 20);
        lblStudentInfo.TabIndex = 0;
        lblStudentInfo.Text = "Học viên / lớp *";
        // 
        // pnlRightCard
        // 
        pnlRightCard.BackColor = System.Drawing.Color.White;
        pnlRightCard.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlRightCard.BorderWidth = 1;
        pnlRightCard.Controls.Add(lblRightCardTitle);
        pnlRightCard.Controls.Add(btnFillRemaining);
        pnlRightCard.Controls.Add(lblDueDateVal);
        pnlRightCard.Controls.Add(lblDueDateTitle);
        pnlRightCard.Controls.Add(lblRemainingVal);
        pnlRightCard.Controls.Add(lblRemainingTitle);
        pnlRightCard.Controls.Add(lblPaidVal);
        pnlRightCard.Controls.Add(lblPaidTitle);
        pnlRightCard.Controls.Add(lblNetTuitionVal);
        pnlRightCard.Controls.Add(lblNetTuitionTitle);
        pnlRightCard.Controls.Add(lblDiscountVal);
        pnlRightCard.Controls.Add(lblDiscountTitle);
        pnlRightCard.Controls.Add(lblBaseTuitionVal);
        pnlRightCard.Controls.Add(lblBaseTuitionTitle);
        pnlRightCard.CornerRadius = 6;
        pnlRightCard.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlRightCard.Location = new System.Drawing.Point(765, 15);
        pnlRightCard.Name = "pnlRightCard";
        pnlRightCard.Padding = new System.Windows.Forms.Padding(20);
        pnlRightCard.Size = new System.Drawing.Size(412, 592);
        pnlRightCard.TabIndex = 1;
        // 
        // lblRightCardTitle
        // 
        lblRightCardTitle.AutoSize = true;
        lblRightCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblRightCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblRightCardTitle.Location = new System.Drawing.Point(20, 16);
        lblRightCardTitle.Name = "lblRightCardTitle";
        lblRightCardTitle.Size = new System.Drawing.Size(165, 25);
        lblRightCardTitle.TabIndex = 15;
        lblRightCardTitle.Text = "Đối chiếu học phí";
        // 
        // btnFillRemaining
        // 
        btnFillRemaining.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnFillRemaining.CornerRadius = 5;
        btnFillRemaining.Cursor = System.Windows.Forms.Cursors.Hand;
        btnFillRemaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnFillRemaining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnFillRemaining.Location = new System.Drawing.Point(23, 268);
        btnFillRemaining.Name = "btnFillRemaining";
        btnFillRemaining.Size = new System.Drawing.Size(370, 38);
        btnFillRemaining.TabIndex = 13;
        btnFillRemaining.Text = "Điền số tiền còn lại 3.400.000đ";
        btnFillRemaining.UseVisualStyleBackColor = true;
        btnFillRemaining.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblDueDateVal
        // 
        lblDueDateVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDueDateVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDueDateVal.Location = new System.Drawing.Point(240, 225);
        lblDueDateVal.Name = "lblDueDateVal";
        lblDueDateVal.Size = new System.Drawing.Size(150, 18);
        lblDueDateVal.TabIndex = 11;
        lblDueDateVal.Text = "15/11/2026";
        lblDueDateVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDueDateTitle
        // 
        lblDueDateTitle.AutoSize = true;
        lblDueDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDueDateTitle.Location = new System.Drawing.Point(20, 225);
        lblDueDateTitle.Name = "lblDueDateTitle";
        lblDueDateTitle.Size = new System.Drawing.Size(111, 20);
        lblDueDateTitle.TabIndex = 10;
        lblDueDateTitle.Text = "Hạn thanh toán";
        // 
        // lblRemainingVal
        // 
        lblRemainingVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblRemainingVal.Location = new System.Drawing.Point(240, 190);
        lblRemainingVal.Name = "lblRemainingVal";
        lblRemainingVal.Size = new System.Drawing.Size(150, 20);
        lblRemainingVal.TabIndex = 9;
        lblRemainingVal.Text = "3.400.000đ";
        lblRemainingVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblRemainingTitle
        // 
        lblRemainingTitle.AutoSize = true;
        lblRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblRemainingTitle.Location = new System.Drawing.Point(20, 190);
        lblRemainingTitle.Name = "lblRemainingTitle";
        lblRemainingTitle.Size = new System.Drawing.Size(98, 20);
        lblRemainingTitle.TabIndex = 8;
        lblRemainingTitle.Text = "Còn phải thu";
        // 
        // lblPaidVal
        // 
        lblPaidVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblPaidVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblPaidVal.Location = new System.Drawing.Point(240, 155);
        lblPaidVal.Name = "lblPaidVal";
        lblPaidVal.Size = new System.Drawing.Size(150, 18);
        lblPaidVal.TabIndex = 7;
        lblPaidVal.Text = "2.000.000đ";
        lblPaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPaidTitle
        // 
        lblPaidTitle.AutoSize = true;
        lblPaidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblPaidTitle.Location = new System.Drawing.Point(20, 155);
        lblPaidTitle.Name = "lblPaidTitle";
        lblPaidTitle.Size = new System.Drawing.Size(114, 20);
        lblPaidTitle.TabIndex = 6;
        lblPaidTitle.Text = "Đã thu trước đó";
        // 
        // lblNetTuitionVal
        // 
        lblNetTuitionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblNetTuitionVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblNetTuitionVal.Location = new System.Drawing.Point(240, 120);
        lblNetTuitionVal.Name = "lblNetTuitionVal";
        lblNetTuitionVal.Size = new System.Drawing.Size(150, 18);
        lblNetTuitionVal.TabIndex = 5;
        lblNetTuitionVal.Text = "5.400.000đ";
        lblNetTuitionVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNetTuitionTitle
        // 
        lblNetTuitionTitle.AutoSize = true;
        lblNetTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNetTuitionTitle.Location = new System.Drawing.Point(20, 120);
        lblNetTuitionTitle.Name = "lblNetTuitionTitle";
        lblNetTuitionTitle.Size = new System.Drawing.Size(126, 20);
        lblNetTuitionTitle.TabIndex = 4;
        lblNetTuitionTitle.Text = "Học phí thực thu";
        // 
        // lblDiscountVal
        // 
        lblDiscountVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDiscountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblDiscountVal.Location = new System.Drawing.Point(240, 85);
        lblDiscountVal.Name = "lblDiscountVal";
        lblDiscountVal.Size = new System.Drawing.Size(150, 18);
        lblDiscountVal.TabIndex = 3;
        lblDiscountVal.Text = "600.000đ · 10%";
        lblDiscountVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDiscountTitle
        // 
        lblDiscountTitle.AutoSize = true;
        lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDiscountTitle.Location = new System.Drawing.Point(20, 85);
        lblDiscountTitle.Name = "lblDiscountTitle";
        lblDiscountTitle.Size = new System.Drawing.Size(53, 20);
        lblDiscountTitle.TabIndex = 2;
        lblDiscountTitle.Text = "Ưu đãi";
        // 
        // lblBaseTuitionVal
        // 
        lblBaseTuitionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblBaseTuitionVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblBaseTuitionVal.Location = new System.Drawing.Point(240, 50);
        lblBaseTuitionVal.Name = "lblBaseTuitionVal";
        lblBaseTuitionVal.Size = new System.Drawing.Size(150, 18);
        lblBaseTuitionVal.TabIndex = 1;
        lblBaseTuitionVal.Text = "6.000.000đ";
        lblBaseTuitionVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblBaseTuitionTitle
        // 
        lblBaseTuitionTitle.AutoSize = true;
        lblBaseTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblBaseTuitionTitle.Location = new System.Drawing.Point(20, 50);
        lblBaseTuitionTitle.Name = "lblBaseTuitionTitle";
        lblBaseTuitionTitle.Size = new System.Drawing.Size(90, 20);
        lblBaseTuitionTitle.TabIndex = 0;
        lblBaseTuitionTitle.Text = "Học phí gốc";
        // 
        // CollectTuitionDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlStepper);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thu học phí · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlStepper.ResumeLayout(false);
        pnlStepper.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlLeftCard.ResumeLayout(false);
        pnlLeftCard.PerformLayout();
        pnlLeftActions.ResumeLayout(false);
        pnlRightCard.ResumeLayout(false);
        pnlRightCard.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlStepper;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private System.Windows.Forms.TableLayoutPanel pnlBody;
    private ECMS.UI.Controls.AppCard pnlLeftCard;
    private System.Windows.Forms.Label lblLeftCardTitle;
    private ECMS.UI.Controls.AppCard pnlRightCard;
    private System.Windows.Forms.Label lblRightCardTitle;

    private System.Windows.Forms.Label lblStudentInfo;
    private ECMS.UI.Controls.AppTextBox txtStudentInfo;
    private System.Windows.Forms.Label lblPaymentDate;
    private ECMS.UI.Controls.AppTextBox txtPaymentDate;
    private System.Windows.Forms.Label lblPaymentType;
    private ECMS.UI.Controls.AppComboBox cboPaymentType;
    private System.Windows.Forms.Label lblPaymentMethod;
    private ECMS.UI.Controls.AppComboBox cboPaymentMethod;
    private System.Windows.Forms.Label lblAmount;
    private ECMS.UI.Controls.AppTextBox txtAmount;
    private System.Windows.Forms.Label lblAmountError;
    private System.Windows.Forms.Label lblReference;
    private ECMS.UI.Controls.AppTextBox txtReference;
    private System.Windows.Forms.Label lblNote;
    private ECMS.UI.Controls.AppTextBox txtNote;
    private System.Windows.Forms.FlowLayoutPanel pnlLeftActions;
    private ECMS.UI.Controls.AppButton btnContinueConfirm;
    private ECMS.UI.Controls.AppButton btnCancel;

    private System.Windows.Forms.Label lblBaseTuitionTitle;
    private System.Windows.Forms.Label lblBaseTuitionVal;
    private System.Windows.Forms.Label lblDiscountTitle;
    private System.Windows.Forms.Label lblDiscountVal;
    private System.Windows.Forms.Label lblNetTuitionTitle;
    private System.Windows.Forms.Label lblNetTuitionVal;
    private System.Windows.Forms.Label lblPaidTitle;
    private System.Windows.Forms.Label lblPaidVal;
    private System.Windows.Forms.Label lblRemainingTitle;
    private System.Windows.Forms.Label lblRemainingVal;
    private System.Windows.Forms.Label lblDueDateTitle;
    private System.Windows.Forms.Label lblDueDateVal;
    private ECMS.UI.Controls.AppButton btnFillRemaining;
}
