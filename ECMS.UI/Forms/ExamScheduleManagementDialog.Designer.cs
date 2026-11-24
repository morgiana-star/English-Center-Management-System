namespace ECMS.UI.Forms;

partial class ExamScheduleManagementDialog
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
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlFilter = new System.Windows.Forms.Panel();
        cboClassFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        pnlBody = new System.Windows.Forms.Panel();
        cardList = new ECMS.UI.Controls.AppCard();
        dgvExamSchedules = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblSummary = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvExamSchedules).BeginInit();
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
        pnlHeader.Size = new System.Drawing.Size(1100, 74);
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
        lblTitle.Text = "Quản lý lịch thi các lớp";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblSubtitle.Location = new System.Drawing.Point(26, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(480, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Theo dõi thời gian thi, phòng thi của từng lớp để tránh trùng lịch (chỉ xóa khi chưa nhập điểm)";
        // 
        // pnlFilter
        // 
        pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlFilter.Controls.Add(cboClassFilter);
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(0, 74);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 6);
        pnlFilter.Size = new System.Drawing.Size(1100, 52);
        pnlFilter.TabIndex = 1;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSearch.BackColor = System.Drawing.Color.White;
        txtSearch.CornerRadius = 6;
        txtSearch.ErrorMessage = "";
        txtSearch.HasError = false;
        txtSearch.Location = new System.Drawing.Point(20, 10);
        txtSearch.Name = "txtSearch";
        txtSearch.Placeholder = "Tìm theo tên bài thi, mã lớp, phòng thi, ngày thi...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(810, 34);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // cboClassFilter
        // 
        cboClassFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboClassFilter.BackColor = System.Drawing.Color.White;
        cboClassFilter.CornerRadius = 5;
        cboClassFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboClassFilter.Location = new System.Drawing.Point(845, 10);
        cboClassFilter.Name = "cboClassFilter";
        cboClassFilter.Size = new System.Drawing.Size(235, 34);
        cboClassFilter.TabIndex = 1;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 126);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 8, 20, 14);
        pnlBody.Size = new System.Drawing.Size(1100, 454);
        pnlBody.TabIndex = 2;
        // 
        // cardList
        // 
        cardList.BackColor = System.Drawing.Color.White;
        cardList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardList.BorderWidth = 1;
        cardList.Controls.Add(dgvExamSchedules);
        cardList.CornerRadius = 8;
        cardList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardList.Location = new System.Drawing.Point(20, 8);
        cardList.Name = "cardList";
        cardList.Padding = new System.Windows.Forms.Padding(12);
        cardList.Size = new System.Drawing.Size(1060, 432);
        cardList.TabIndex = 0;
        // 
        // dgvExamSchedules
        // 
        dgvExamSchedules.AllowUserToAddRows = false;
        dgvExamSchedules.AllowUserToDeleteRows = false;
        dgvExamSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvExamSchedules.BackgroundColor = System.Drawing.Color.White;
        dgvExamSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvExamSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvExamSchedules.Location = new System.Drawing.Point(12, 12);
        dgvExamSchedules.MultiSelect = false;
        dgvExamSchedules.Name = "dgvExamSchedules";
        dgvExamSchedules.ReadOnly = true;
        dgvExamSchedules.RowHeadersVisible = false;
        dgvExamSchedules.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvExamSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvExamSchedules.Size = new System.Drawing.Size(1036, 408);
        dgvExamSchedules.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnClose);
        pnlFooter.Controls.Add(lblSummary);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 580);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
        pnlFooter.Size = new System.Drawing.Size(1100, 56);
        pnlFooter.TabIndex = 3;
        // 
        // lblSummary
        // 
        lblSummary.AutoSize = true;
        lblSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblSummary.Location = new System.Drawing.Point(24, 18);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new System.Drawing.Size(220, 20);
        lblSummary.TabIndex = 0;
        lblSummary.Text = "Tổng số lịch thi: 0";
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
        btnClose.Location = new System.Drawing.Point(966, 10);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(110, 36);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // ExamScheduleManagementDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1100, 636);
        Controls.Add(pnlBody);
        Controls.Add(pnlFilter);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(940, 520);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý lịch thi - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFilter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvExamSchedules).EndInit();
        pnlFooter.ResumeLayout(false);
        pnlFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlFilter;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private ECMS.UI.Controls.AppComboBox cboClassFilter;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardList;
    private ECMS.UI.Controls.AppDataGrid dgvExamSchedules;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Label lblSummary;
    private ECMS.UI.Controls.AppButton btnClose;
}
