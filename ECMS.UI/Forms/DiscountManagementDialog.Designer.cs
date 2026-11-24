namespace ECMS.UI.Forms;

partial class DiscountManagementDialog
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

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardForm = new ECMS.UI.Controls.AppCard();
        lblFormTitle = new System.Windows.Forms.Label();
        lblCode = new System.Windows.Forms.Label();
        txtCode = new ECMS.UI.Controls.AppTextBox();
        lblName = new System.Windows.Forms.Label();
        txtName = new ECMS.UI.Controls.AppTextBox();
        lblPercent = new System.Windows.Forms.Label();
        nudPercent = new System.Windows.Forms.NumericUpDown();
        lblFixedAmount = new System.Windows.Forms.Label();
        nudFixedAmount = new System.Windows.Forms.NumericUpDown();
        lblDescription = new System.Windows.Forms.Label();
        txtDescription = new ECMS.UI.Controls.AppTextBox();
        chkIsActive = new System.Windows.Forms.CheckBox();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnNew = new ECMS.UI.Controls.AppButton();
        btnDelete = new ECMS.UI.Controls.AppButton();
        cardList = new ECMS.UI.Controls.AppCard();
        dgvDiscounts = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        btnClose = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudPercent).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudFixedAmount).BeginInit();
        cardList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDiscounts).BeginInit();
        pnlFooter.SuspendLayout();
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
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(960, 74);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(260, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Quản lý mã giảm giá học phí";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(26, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(440, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Thiết lập các mã ưu đãi (học viên cũ, đăng ký nhóm, đăng ký sớm) để áp dụng khi thu phí";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardList);
        pnlBody.Controls.Add(cardForm);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 74);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
        pnlBody.Size = new System.Drawing.Size(960, 506);
        pnlBody.TabIndex = 1;
        // 
        // cardForm
        // 
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardForm.BorderWidth = 1;
        cardForm.Controls.Add(btnDelete);
        cardForm.Controls.Add(btnNew);
        cardForm.Controls.Add(btnSave);
        cardForm.Controls.Add(chkIsActive);
        cardForm.Controls.Add(txtDescription);
        cardForm.Controls.Add(lblDescription);
        cardForm.Controls.Add(nudFixedAmount);
        cardForm.Controls.Add(lblFixedAmount);
        cardForm.Controls.Add(nudPercent);
        cardForm.Controls.Add(lblPercent);
        cardForm.Controls.Add(txtName);
        cardForm.Controls.Add(lblName);
        cardForm.Controls.Add(txtCode);
        cardForm.Controls.Add(lblCode);
        cardForm.Controls.Add(lblFormTitle);
        cardForm.CornerRadius = 8;
        cardForm.Dock = System.Windows.Forms.DockStyle.Top;
        cardForm.Location = new System.Drawing.Point(20, 14);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(16);
        cardForm.Size = new System.Drawing.Size(920, 196);
        cardForm.TabIndex = 0;
        // 
        // lblFormTitle
        // 
        lblFormTitle.AutoSize = true;
        lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblFormTitle.Location = new System.Drawing.Point(16, 12);
        lblFormTitle.Name = "lblFormTitle";
        lblFormTitle.Size = new System.Drawing.Size(180, 23);
        lblFormTitle.TabIndex = 0;
        lblFormTitle.Text = "Thông tin mã giảm giá";
        // 
        // lblCode
        // 
        lblCode.AutoSize = true;
        lblCode.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblCode.Location = new System.Drawing.Point(16, 42);
        lblCode.Name = "lblCode";
        lblCode.Size = new System.Drawing.Size(95, 20);
        lblCode.TabIndex = 1;
        lblCode.Text = "Mã giảm giá *";
        // 
        // txtCode
        // 
        txtCode.BackColor = System.Drawing.Color.White;
        txtCode.CornerRadius = 5;
        txtCode.ErrorMessage = "";
        txtCode.HasError = false;
        txtCode.Location = new System.Drawing.Point(16, 64);
        txtCode.Name = "txtCode";
        txtCode.Placeholder = "VD: HVCU10, NHOM15";
        txtCode.ReadOnly = false;
        txtCode.Size = new System.Drawing.Size(170, 34);
        txtCode.TabIndex = 2;
        txtCode.UseSystemPasswordChar = false;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblName.Location = new System.Drawing.Point(200, 42);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(145, 20);
        lblName.TabIndex = 3;
        lblName.Text = "Tên chương trình ưu đãi *";
        // 
        // txtName
        // 
        txtName.BackColor = System.Drawing.Color.White;
        txtName.CornerRadius = 5;
        txtName.ErrorMessage = "";
        txtName.HasError = false;
        txtName.Location = new System.Drawing.Point(200, 64);
        txtName.Name = "txtName";
        txtName.Placeholder = "VD: Ưu đãi học viên cũ";
        txtName.ReadOnly = false;
        txtName.Size = new System.Drawing.Size(310, 34);
        txtName.TabIndex = 4;
        txtName.UseSystemPasswordChar = false;
        // 
        // lblPercent
        // 
        lblPercent.AutoSize = true;
        lblPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblPercent.Location = new System.Drawing.Point(524, 42);
        lblPercent.Name = "lblPercent";
        lblPercent.Size = new System.Drawing.Size(80, 20);
        lblPercent.TabIndex = 5;
        lblPercent.Text = "Giảm (%)";
        // 
        // nudPercent
        // 
        nudPercent.DecimalPlaces = 1;
        nudPercent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        nudPercent.Location = new System.Drawing.Point(524, 66);
        nudPercent.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        nudPercent.Name = "nudPercent";
        nudPercent.Size = new System.Drawing.Size(105, 29);
        nudPercent.TabIndex = 6;
        // 
        // lblFixedAmount
        // 
        lblFixedAmount.AutoSize = true;
        lblFixedAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblFixedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblFixedAmount.Location = new System.Drawing.Point(642, 42);
        lblFixedAmount.Name = "lblFixedAmount";
        lblFixedAmount.Size = new System.Drawing.Size(120, 20);
        lblFixedAmount.TabIndex = 7;
        lblFixedAmount.Text = "Giảm tiền (VNĐ)";
        // 
        // nudFixedAmount
        // 
        nudFixedAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        nudFixedAmount.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
        nudFixedAmount.Location = new System.Drawing.Point(642, 66);
        nudFixedAmount.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
        nudFixedAmount.Name = "nudFixedAmount";
        nudFixedAmount.Size = new System.Drawing.Size(155, 29);
        nudFixedAmount.TabIndex = 8;
        nudFixedAmount.ThousandsSeparator = true;
        // 
        // chkIsActive
        // 
        chkIsActive.AutoSize = true;
        chkIsActive.Checked = true;
        chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
        chkIsActive.Font = new System.Drawing.Font("Segoe UI", 9F);
        chkIsActive.Location = new System.Drawing.Point(810, 70);
        chkIsActive.Name = "chkIsActive";
        chkIsActive.Size = new System.Drawing.Size(95, 24);
        chkIsActive.TabIndex = 9;
        chkIsActive.Text = "Đang bật";
        chkIsActive.UseVisualStyleBackColor = true;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblDescription.Location = new System.Drawing.Point(16, 108);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new System.Drawing.Size(110, 20);
        lblDescription.TabIndex = 10;
        lblDescription.Text = "Mô tả điều kiện";
        // 
        // txtDescription
        // 
        txtDescription.BackColor = System.Drawing.Color.White;
        txtDescription.CornerRadius = 5;
        txtDescription.ErrorMessage = "";
        txtDescription.HasError = false;
        txtDescription.Location = new System.Drawing.Point(16, 130);
        txtDescription.Name = "txtDescription";
        txtDescription.Placeholder = "Nhập điều kiện áp dụng mã giảm giá...";
        txtDescription.ReadOnly = false;
        txtDescription.Size = new System.Drawing.Size(555, 34);
        txtDescription.TabIndex = 11;
        txtDescription.UseSystemPasswordChar = false;
        // 
        // btnNew
        // 
        btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnNew.BackColor = System.Drawing.Color.White;
        btnNew.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnNew.CornerRadius = 6;
        btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnNew.Location = new System.Drawing.Point(586, 130);
        btnNew.Name = "btnNew";
        btnNew.Size = new System.Drawing.Size(95, 34);
        btnNew.TabIndex = 12;
        btnNew.Text = "Làm mới";
        btnNew.UseVisualStyleBackColor = false;
        btnNew.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnDelete.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnDelete.CornerRadius = 6;
        btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDelete.Enabled = false;
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnDelete.ForeColor = System.Drawing.Color.White;
        btnDelete.Location = new System.Drawing.Point(691, 130);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(85, 34);
        btnDelete.TabIndex = 13;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 6;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(786, 130);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(118, 34);
        btnSave.TabIndex = 14;
        btnSave.Text = "Lưu mã";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // cardList
        // 
        cardList.BackColor = System.Drawing.Color.White;
        cardList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardList.BorderWidth = 1;
        cardList.Controls.Add(dgvDiscounts);
        cardList.CornerRadius = 8;
        cardList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardList.Location = new System.Drawing.Point(20, 210);
        cardList.Name = "cardList";
        cardList.Padding = new System.Windows.Forms.Padding(12);
        cardList.Size = new System.Drawing.Size(920, 282);
        cardList.TabIndex = 1;
        // 
        // dgvDiscounts
        // 
        dgvDiscounts.AllowUserToAddRows = false;
        dgvDiscounts.AllowUserToDeleteRows = false;
        dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvDiscounts.BackgroundColor = System.Drawing.Color.White;
        dgvDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvDiscounts.Location = new System.Drawing.Point(12, 12);
        dgvDiscounts.MultiSelect = false;
        dgvDiscounts.Name = "dgvDiscounts";
        dgvDiscounts.ReadOnly = true;
        dgvDiscounts.RowHeadersVisible = false;
        dgvDiscounts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvDiscounts.Size = new System.Drawing.Size(896, 258);
        dgvDiscounts.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnClose);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 580);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
        pnlFooter.Size = new System.Drawing.Size(960, 56);
        pnlFooter.TabIndex = 2;
        // 
        // btnClose
        // 
        btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnClose.BackColor = System.Drawing.Color.White;
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 6;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnClose.Location = new System.Drawing.Point(830, 10);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(110, 36);
        btnClose.TabIndex = 0;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // DiscountManagementDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(960, 636);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(880, 560);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý mã giảm giá học phí - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardForm.ResumeLayout(false);
        cardForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudPercent).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudFixedAmount).EndInit();
        cardList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDiscounts).EndInit();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardForm;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblCode;
    private ECMS.UI.Controls.AppTextBox txtCode;
    private System.Windows.Forms.Label lblName;
    private ECMS.UI.Controls.AppTextBox txtName;
    private System.Windows.Forms.Label lblPercent;
    private System.Windows.Forms.NumericUpDown nudPercent;
    private System.Windows.Forms.Label lblFixedAmount;
    private System.Windows.Forms.NumericUpDown nudFixedAmount;
    private System.Windows.Forms.Label lblDescription;
    private ECMS.UI.Controls.AppTextBox txtDescription;
    private System.Windows.Forms.CheckBox chkIsActive;
    private ECMS.UI.Controls.AppButton btnNew;
    private ECMS.UI.Controls.AppButton btnDelete;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppCard cardList;
    private ECMS.UI.Controls.AppDataGrid dgvDiscounts;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnClose;
}
