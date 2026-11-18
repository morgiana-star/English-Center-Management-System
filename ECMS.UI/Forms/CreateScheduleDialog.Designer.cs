namespace ECMS.UI.Forms;

partial class CreateScheduleDialog
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        lblSub = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardClasses = new ECMS.UI.Controls.AppCard();
        pnlFilter = new System.Windows.Forms.Panel();
        txtSearch = new System.Windows.Forms.TextBox();
        lblSearch = new System.Windows.Forms.Label();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        btnCancel = new ECMS.UI.Controls.AppButton();
        btnCreateSessions = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardClasses.SuspendLayout();
        pnlFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSub);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1080, 80);
        pnlHeader.TabIndex = 0;
        // 
        // lblSub
        // 
        lblSub.AutoSize = true;
        lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSub.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSub.Location = new System.Drawing.Point(24, 48);
        lblSub.Name = "lblSub";
        lblSub.Size = new System.Drawing.Size(564, 20);
        lblSub.TabIndex = 2;
        lblSub.Text = "Chọn 1 lớp học từ danh sách để tự động phát sinh các buổi học theo kế hoạch đào tạo.";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(437, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Tạo buổi học · Phát sinh lịch theo lớp";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = false;
        pnlBody.Controls.Add(cardClasses);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 80);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlBody.Size = new System.Drawing.Size(1080, 520);
        pnlBody.TabIndex = 1;
        // 
        // cardClasses
        // 
        cardClasses.BackColor = System.Drawing.Color.White;
        cardClasses.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardClasses.BorderWidth = 1;
        cardClasses.Controls.Add(dgvClasses);
        cardClasses.Controls.Add(pnlFilter);
        cardClasses.CornerRadius = 8;
        cardClasses.Dock = System.Windows.Forms.DockStyle.Fill;
        cardClasses.Location = new System.Drawing.Point(24, 16);
        cardClasses.Name = "cardClasses";
        cardClasses.Padding = new System.Windows.Forms.Padding(16);
        cardClasses.Size = new System.Drawing.Size(1032, 488);
        cardClasses.TabIndex = 0;
        // 
        // pnlFilter
        // 
        pnlFilter.Controls.Add(txtSearch);
        pnlFilter.Controls.Add(lblSearch);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.Location = new System.Drawing.Point(16, 16);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Size = new System.Drawing.Size(1000, 44);
        pnlFilter.TabIndex = 0;
        // 
        // txtSearch
        // 
        txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        txtSearch.Location = new System.Drawing.Point(115, 6);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Nhập mã lớp, khóa học, giáo viên hoặc phòng học để tìm nhanh...";
        txtSearch.Size = new System.Drawing.Size(460, 29);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSearch.Location = new System.Drawing.Point(6, 11);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new System.Drawing.Size(102, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "🔍 Tìm nhanh:";
        // 
        // dgvClasses
        // 
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.AllowUserToDeleteRows = false;
        dgvClasses.AllowUserToResizeColumns = false;
        dgvClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClasses.BackgroundColor = System.Drawing.Color.White;
        dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClasses.ColumnHeadersHeight = 38;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvClasses.EnableHeadersVisualStyles = false;
        dgvClasses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvClasses.Location = new System.Drawing.Point(16, 60);
        dgvClasses.MultiSelect = false;
        dgvClasses.Name = "dgvClasses";
        dgvClasses.ReadOnly = true;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.RowHeadersWidth = 51;
        dgvClasses.RowTemplate.Height = 40;
        dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.Size = new System.Drawing.Size(1000, 412);
        dgvClasses.TabIndex = 1;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Controls.Add(btnCreateSessions);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 600);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
        pnlFooter.Size = new System.Drawing.Size(1080, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancel.Location = new System.Drawing.Point(750, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Hủy bỏ";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnCreateSessions
        // 
        btnCreateSessions.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCreateSessions.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCreateSessions.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateSessions.CornerRadius = 5;
        btnCreateSessions.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateSessions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateSessions.ForeColor = System.Drawing.Color.White;
        btnCreateSessions.Location = new System.Drawing.Point(860, 12);
        btnCreateSessions.Name = "btnCreateSessions";
        btnCreateSessions.Size = new System.Drawing.Size(196, 36);
        btnCreateSessions.TabIndex = 0;
        btnCreateSessions.Text = "+ Tạo buổi học cho lớp";
        btnCreateSessions.UseVisualStyleBackColor = false;
        btnCreateSessions.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // CreateScheduleDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1080, 660);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CreateScheduleDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Tạo buổi học · Phát sinh lịch học theo lớp";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardClasses.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSub;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardClasses;
    private System.Windows.Forms.Panel pnlFilter;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnCreateSessions;
}
