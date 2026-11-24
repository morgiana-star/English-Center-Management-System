namespace ECMS.UI.Forms;

partial class CreateAssessmentDialog
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
        btnClearClasses = new System.Windows.Forms.Button();
        btnSelectAllClasses = new System.Windows.Forms.Button();
        chkListClasses = new System.Windows.Forms.CheckedListBox();
        lblAssignedClass = new System.Windows.Forms.Label();
        txtWeight = new System.Windows.Forms.TextBox();
        lblWeight = new System.Windows.Forms.Label();
        txtScale = new System.Windows.Forms.TextBox();
        lblScale = new System.Windows.Forms.Label();
        dtpExamDate = new System.Windows.Forms.DateTimePicker();
        lblExamDate = new System.Windows.Forms.Label();
        cboAssessmentType = new System.Windows.Forms.ComboBox();
        lblAssessmentType = new System.Windows.Forms.Label();
        txtAssessmentName = new System.Windows.Forms.TextBox();
        lblAssessmentName = new System.Windows.Forms.Label();
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
        pnlHeader.Size = new System.Drawing.Size(680, 56);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(250, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Tạo bài kiểm tra mới";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnSave);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 575);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(680, 60);
        pnlFooter.TabIndex = 2;
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
        btnSave.Location = new System.Drawing.Point(500, 12);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(156, 36);
        btnSave.TabIndex = 0;
        btnSave.Text = "Lưu bài kiểm tra";
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
        btnCancel.Location = new System.Drawing.Point(395, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(95, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardForm);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 56);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20);
        pnlBody.Size = new System.Drawing.Size(680, 519);
        pnlBody.TabIndex = 1;
        // 
        // cardForm
        // 
        cardForm.BackColor = System.Drawing.Color.White;
        cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardForm.BorderWidth = 1;
        cardForm.Controls.Add(btnClearClasses);
        cardForm.Controls.Add(btnSelectAllClasses);
        cardForm.Controls.Add(chkListClasses);
        cardForm.Controls.Add(lblAssignedClass);
        cardForm.Controls.Add(txtWeight);
        cardForm.Controls.Add(lblWeight);
        cardForm.Controls.Add(txtScale);
        cardForm.Controls.Add(lblScale);
        cardForm.Controls.Add(dtpExamDate);
        cardForm.Controls.Add(lblExamDate);
        cardForm.Controls.Add(cboAssessmentType);
        cardForm.Controls.Add(lblAssessmentType);
        cardForm.Controls.Add(txtAssessmentName);
        cardForm.Controls.Add(lblAssessmentName);
        cardForm.CornerRadius = 8;
        cardForm.Dock = System.Windows.Forms.DockStyle.Fill;
        cardForm.Location = new System.Drawing.Point(20, 20);
        cardForm.Name = "cardForm";
        cardForm.Padding = new System.Windows.Forms.Padding(20);
        cardForm.Size = new System.Drawing.Size(640, 479);
        cardForm.TabIndex = 0;
        // 
        // btnClearClasses
        // 
        btnClearClasses.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        btnClearClasses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnClearClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClearClasses.Font = new System.Drawing.Font("Segoe UI", 8F);
        btnClearClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnClearClasses.Location = new System.Drawing.Point(540, 206);
        btnClearClasses.Name = "btnClearClasses";
        btnClearClasses.Size = new System.Drawing.Size(75, 26);
        btnClearClasses.TabIndex = 13;
        btnClearClasses.Text = "Bỏ chọn";
        btnClearClasses.UseVisualStyleBackColor = false;
        // 
        // btnSelectAllClasses
        // 
        btnSelectAllClasses.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        btnSelectAllClasses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnSelectAllClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSelectAllClasses.Font = new System.Drawing.Font("Segoe UI", 8F);
        btnSelectAllClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        btnSelectAllClasses.Location = new System.Drawing.Point(445, 206);
        btnSelectAllClasses.Name = "btnSelectAllClasses";
        btnSelectAllClasses.Size = new System.Drawing.Size(90, 26);
        btnSelectAllClasses.TabIndex = 12;
        btnSelectAllClasses.Text = "Chọn tất cả";
        btnSelectAllClasses.UseVisualStyleBackColor = false;
        // 
        // chkListClasses
        // 
        chkListClasses.CheckOnClick = true;
        chkListClasses.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkListClasses.FormattingEnabled = true;
        chkListClasses.Location = new System.Drawing.Point(20, 236);
        chkListClasses.Name = "chkListClasses";
        chkListClasses.Size = new System.Drawing.Size(595, 196);
        chkListClasses.TabIndex = 11;
        // 
        // lblAssignedClass
        // 
        lblAssignedClass.AutoSize = true;
        lblAssignedClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAssignedClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAssignedClass.Location = new System.Drawing.Point(20, 209);
        lblAssignedClass.Name = "lblAssignedClass";
        lblAssignedClass.Size = new System.Drawing.Size(308, 20);
        lblAssignedClass.TabIndex = 10;
        lblAssignedClass.Text = "Lớp học áp dụng * (Có thể chọn nhiều lớp):";
        // 
        // txtWeight
        // 
        txtWeight.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtWeight.Location = new System.Drawing.Point(340, 160);
        txtWeight.Name = "txtWeight";
        txtWeight.Size = new System.Drawing.Size(275, 29);
        txtWeight.TabIndex = 9;
        txtWeight.Text = "20%";
        // 
        // lblWeight
        // 
        lblWeight.AutoSize = true;
        lblWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblWeight.Location = new System.Drawing.Point(340, 137);
        lblWeight.Name = "lblWeight";
        lblWeight.Size = new System.Drawing.Size(91, 20);
        lblWeight.TabIndex = 8;
        lblWeight.Text = "Trọng số %:";
        // 
        // txtScale
        // 
        txtScale.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtScale.Location = new System.Drawing.Point(20, 160);
        txtScale.Name = "txtScale";
        txtScale.Size = new System.Drawing.Size(295, 29);
        txtScale.TabIndex = 7;
        txtScale.Text = "10";
        // 
        // lblScale
        // 
        lblScale.AutoSize = true;
        lblScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblScale.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblScale.Location = new System.Drawing.Point(20, 137);
        lblScale.Name = "lblScale";
        lblScale.Size = new System.Drawing.Size(96, 20);
        lblScale.TabIndex = 6;
        lblScale.Text = "Thang điểm:";
        // 
        // dtpExamDate
        // 
        dtpExamDate.CustomFormat = "dd/MM/yyyy";
        dtpExamDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpExamDate.Location = new System.Drawing.Point(340, 96);
        dtpExamDate.Name = "dtpExamDate";
        dtpExamDate.Size = new System.Drawing.Size(275, 29);
        dtpExamDate.TabIndex = 5;
        // 
        // lblExamDate
        // 
        lblExamDate.AutoSize = true;
        lblExamDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblExamDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblExamDate.Location = new System.Drawing.Point(340, 73);
        lblExamDate.Name = "lblExamDate";
        lblExamDate.Size = new System.Drawing.Size(112, 20);
        lblExamDate.TabIndex = 4;
        lblExamDate.Text = "Ngày kiểm tra:";
        // 
        // cboAssessmentType
        // 
        cboAssessmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboAssessmentType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboAssessmentType.FormattingEnabled = true;
        cboAssessmentType.Location = new System.Drawing.Point(20, 96);
        cboAssessmentType.Name = "cboAssessmentType";
        cboAssessmentType.Size = new System.Drawing.Size(295, 29);
        cboAssessmentType.TabIndex = 3;
        // 
        // lblAssessmentType
        // 
        lblAssessmentType.AutoSize = true;
        lblAssessmentType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAssessmentType.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAssessmentType.Location = new System.Drawing.Point(20, 73);
        lblAssessmentType.Name = "lblAssessmentType";
        lblAssessmentType.Size = new System.Drawing.Size(136, 20);
        lblAssessmentType.TabIndex = 2;
        lblAssessmentType.Text = "Loại bài kiểm tra *";
        // 
        // txtAssessmentName
        // 
        txtAssessmentName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtAssessmentName.Location = new System.Drawing.Point(20, 34);
        txtAssessmentName.Name = "txtAssessmentName";
        txtAssessmentName.PlaceholderText = "VD: Mini-Test 1 (Reading & Vocab), Thi giữa khóa...";
        txtAssessmentName.Size = new System.Drawing.Size(595, 29);
        txtAssessmentName.TabIndex = 1;
        // 
        // lblAssessmentName
        // 
        lblAssessmentName.AutoSize = true;
        lblAssessmentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAssessmentName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblAssessmentName.Location = new System.Drawing.Point(20, 11);
        lblAssessmentName.Name = "lblAssessmentName";
        lblAssessmentName.Size = new System.Drawing.Size(132, 20);
        lblAssessmentName.TabIndex = 0;
        lblAssessmentName.Text = "Tên bài kiểm tra *";
        // 
        // CreateAssessmentDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(680, 635);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tạo bài kiểm tra mới";
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
    private System.Windows.Forms.Label lblAssessmentName;
    private System.Windows.Forms.TextBox txtAssessmentName;
    private System.Windows.Forms.Label lblAssessmentType;
    private System.Windows.Forms.ComboBox cboAssessmentType;
    private System.Windows.Forms.Label lblExamDate;
    private System.Windows.Forms.DateTimePicker dtpExamDate;
    private System.Windows.Forms.Label lblScale;
    private System.Windows.Forms.TextBox txtScale;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.Label lblAssignedClass;
    private System.Windows.Forms.CheckedListBox chkListClasses;
    private System.Windows.Forms.Button btnSelectAllClasses;
    private System.Windows.Forms.Button btnClearClasses;
}
