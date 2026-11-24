namespace ECMS.UI.Forms;

partial class EditRoomDialog
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
        pnlFooter = new System.Windows.Forms.Panel();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlBody = new System.Windows.Forms.Panel();
        cardForm = new ECMS.UI.Controls.AppCard();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        txtNotes = new ECMS.UI.Controls.AppTextBox();
        lblNotes = new System.Windows.Forms.Label();
        txtCapacity = new ECMS.UI.Controls.AppTextBox();
        lblCapacity = new System.Windows.Forms.Label();
        txtRoomName = new ECMS.UI.Controls.AppTextBox();
        lblRoomName = new System.Windows.Forms.Label();
        txtRoomCode = new ECMS.UI.Controls.AppTextBox();
        lblRoomCode = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardForm.SuspendLayout();
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
        pnlHeader.Size = new System.Drawing.Size(560, 72);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(243, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Thêm phòng học mới";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnSave);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 480);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(560, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnSave.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSave.CornerRadius = 5;
        btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.Location = new System.Drawing.Point(396, 12);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(140, 36);
        btnSave.TabIndex = 1;
        btnSave.Text = "Lưu phòng";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.Location = new System.Drawing.Point(290, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 36);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardForm);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 72);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlBody.Size = new System.Drawing.Size(560, 408);
        pnlBody.TabIndex = 1;
        // 
        // cardForm
        // 
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardForm.BorderWidth = 1;
        cardForm.Controls.Add(cboStatus);
        cardForm.Controls.Add(lblStatus);
        cardForm.Controls.Add(txtNotes);
        cardForm.Controls.Add(lblNotes);
        cardForm.Controls.Add(txtCapacity);
        cardForm.Controls.Add(lblCapacity);
        cardForm.Controls.Add(txtRoomName);
        cardForm.Controls.Add(lblRoomName);
        cardForm.Controls.Add(txtRoomCode);
        cardForm.Controls.Add(lblRoomCode);
        cardForm.CornerRadius = 6;
        cardForm.Dock = System.Windows.Forms.DockStyle.Fill;
        cardForm.Location = new System.Drawing.Point(24, 16);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(20);
        cardForm.Size = new System.Drawing.Size(512, 376);
        cardForm.TabIndex = 0;
        // 
        // cboStatus
        // 
        cboStatus.BackColor = System.Drawing.Color.Transparent;
        cboStatus.CornerRadius = 5;
        cboStatus.DataSource = null;
        cboStatus.DisplayMember = "";
        cboStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboStatus.Location = new System.Drawing.Point(20, 246);
        cboStatus.Name = "cboStatus";
        cboStatus.SelectedIndex = -1;
        cboStatus.SelectedItem = null;
        cboStatus.SelectedValue = null;
        cboStatus.Size = new System.Drawing.Size(472, 36);
        cboStatus.TabIndex = 4;
        cboStatus.ValueMember = "";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblStatus.Location = new System.Drawing.Point(20, 224);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(91, 20);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Trạng thái *";
        // 
        // txtNotes
        // 
        txtNotes.BackColor = System.Drawing.Color.Transparent;
        txtNotes.CornerRadius = 5;
        txtNotes.ErrorMessage = "";
        txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtNotes.HasError = false;
        txtNotes.Location = new System.Drawing.Point(20, 312);
        txtNotes.Name = "txtNotes";
        txtNotes.Placeholder = "Nhập ghi chú trang thiết bị (Máy chiếu, bảng tương tác, loa...)";
        txtNotes.ReadOnly = false;
        txtNotes.Size = new System.Drawing.Size(472, 36);
        txtNotes.TabIndex = 5;
        txtNotes.UseSystemPasswordChar = false;
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblNotes.Location = new System.Drawing.Point(20, 290);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(127, 20);
        lblNotes.TabIndex = 6;
        lblNotes.Text = "Ghi chú & Thiết bị:";
        // 
        // txtCapacity
        // 
        txtCapacity.BackColor = System.Drawing.Color.Transparent;
        txtCapacity.CornerRadius = 5;
        txtCapacity.ErrorMessage = "";
        txtCapacity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtCapacity.HasError = false;
        txtCapacity.Location = new System.Drawing.Point(20, 180);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Placeholder = "VD: 24";
        txtCapacity.ReadOnly = false;
        txtCapacity.Size = new System.Drawing.Size(472, 36);
        txtCapacity.TabIndex = 3;
        txtCapacity.UseSystemPasswordChar = false;
        // 
        // lblCapacity
        // 
        lblCapacity.AutoSize = true;
        lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblCapacity.Location = new System.Drawing.Point(20, 158);
        lblCapacity.Name = "lblCapacity";
        lblCapacity.Size = new System.Drawing.Size(159, 20);
        lblCapacity.TabIndex = 4;
        lblCapacity.Text = "Sức chứa (chỗ ngồi) *";
        // 
        // txtRoomName
        // 
        txtRoomName.BackColor = System.Drawing.Color.Transparent;
        txtRoomName.CornerRadius = 5;
        txtRoomName.ErrorMessage = "";
        txtRoomName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtRoomName.HasError = false;
        txtRoomName.Location = new System.Drawing.Point(20, 114);
        txtRoomName.Name = "txtRoomName";
        txtRoomName.Placeholder = "VD: Phòng IELTS 201";
        txtRoomName.ReadOnly = false;
        txtRoomName.Size = new System.Drawing.Size(472, 36);
        txtRoomName.TabIndex = 2;
        txtRoomName.UseSystemPasswordChar = false;
        // 
        // lblRoomName
        // 
        lblRoomName.AutoSize = true;
        lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRoomName.Location = new System.Drawing.Point(20, 92);
        lblRoomName.Name = "lblRoomName";
        lblRoomName.Size = new System.Drawing.Size(94, 20);
        lblRoomName.TabIndex = 2;
        lblRoomName.Text = "Tên phòng *";
        // 
        // txtRoomCode
        // 
        txtRoomCode.BackColor = System.Drawing.Color.Transparent;
        txtRoomCode.CornerRadius = 5;
        txtRoomCode.ErrorMessage = "";
        txtRoomCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtRoomCode.HasError = false;
        txtRoomCode.Location = new System.Drawing.Point(20, 48);
        txtRoomCode.Name = "txtRoomCode";
        txtRoomCode.Placeholder = "VD: P201";
        txtRoomCode.ReadOnly = false;
        txtRoomCode.Size = new System.Drawing.Size(472, 36);
        txtRoomCode.TabIndex = 1;
        txtRoomCode.UseSystemPasswordChar = false;
        // 
        // lblRoomCode
        // 
        lblRoomCode.AutoSize = true;
        lblRoomCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblRoomCode.Location = new System.Drawing.Point(20, 26);
        lblRoomCode.Name = "lblRoomCode";
        lblRoomCode.Size = new System.Drawing.Size(91, 20);
        lblRoomCode.TabIndex = 0;
        lblRoomCode.Text = "Mã phòng *";
        // 
        // EditRoomDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(560, 540);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý phòng học · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardForm.ResumeLayout(false);
        cardForm.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardForm;
    private System.Windows.Forms.Label lblRoomCode;
    private ECMS.UI.Controls.AppTextBox txtRoomCode;
    private System.Windows.Forms.Label lblRoomName;
    private ECMS.UI.Controls.AppTextBox txtRoomName;
    private System.Windows.Forms.Label lblCapacity;
    private ECMS.UI.Controls.AppTextBox txtCapacity;
    private System.Windows.Forms.Label lblNotes;
    private ECMS.UI.Controls.AppTextBox txtNotes;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
}
