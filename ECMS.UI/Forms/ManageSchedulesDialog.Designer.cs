namespace ECMS.UI.Forms;

partial class ManageSchedulesDialog
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
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        pnlBody = new System.Windows.Forms.Panel();
        cardList = new ECMS.UI.Controls.AppCard();
        dgvSchedules = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        lblSummary = new System.Windows.Forms.Label();
        btnClose = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlBody.SuspendLayout();
        cardList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
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
        pnlHeader.Size = new System.Drawing.Size(1080, 74);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(220, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Quản lý lịch học các lớp";
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
        lblSubtitle.Text = "Danh sách lịch học đã tạo từ cơ sở dữ liệu (chỉ xóa được lịch học chưa phát sinh điểm danh)";
        // 
        // pnlFilter
        // 
        pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(0, 74);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 6);
        pnlFilter.Size = new System.Drawing.Size(1080, 52);
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
        txtSearch.Placeholder = "Tìm theo mã lớp, giáo viên, phòng học, khung giờ...";
        txtSearch.ReadOnly = false;
        txtSearch.Size = new System.Drawing.Size(1040, 34);
        txtSearch.TabIndex = 0;
        txtSearch.UseSystemPasswordChar = false;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 126);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 8, 20, 14);
        pnlBody.Size = new System.Drawing.Size(1080, 454);
        pnlBody.TabIndex = 2;
        // 
        // cardList
        // 
        cardList.BackColor = System.Drawing.Color.White;
        cardList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardList.BorderWidth = 1;
        cardList.Controls.Add(dgvSchedules);
        cardList.CornerRadius = 8;
        cardList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardList.Location = new System.Drawing.Point(20, 8);
        cardList.Name = "cardList";
        cardList.Padding = new System.Windows.Forms.Padding(12);
        cardList.Size = new System.Drawing.Size(1040, 432);
        cardList.TabIndex = 0;
        // 
        // dgvSchedules
        // 
        dgvSchedules.AllowUserToAddRows = false;
        dgvSchedules.AllowUserToDeleteRows = false;
        dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSchedules.BackgroundColor = System.Drawing.Color.White;
        dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSchedules.Location = new System.Drawing.Point(12, 12);
        dgvSchedules.MultiSelect = false;
        dgvSchedules.Name = "dgvSchedules";
        dgvSchedules.ReadOnly = true;
        dgvSchedules.RowHeadersVisible = false;
        dgvSchedules.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSchedules.Size = new System.Drawing.Size(1016, 408);
        dgvSchedules.TabIndex = 0;
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
        pnlFooter.Size = new System.Drawing.Size(1080, 56);
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
        lblSummary.Text = "Tổng số lịch lớp: 0";
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
        btnClose.Location = new System.Drawing.Point(946, 10);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(110, 36);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // ManageSchedulesDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1080, 636);
        Controls.Add(pnlBody);
        Controls.Add(pnlFilter);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(920, 520);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý lịch học - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFilter.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
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
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardList;
    private ECMS.UI.Controls.AppDataGrid dgvSchedules;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Label lblSummary;
    private ECMS.UI.Controls.AppButton btnClose;
}
