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
        lblTitle = new System.Windows.Forms.Label();
        pnlFilter = new System.Windows.Forms.Panel();
        txtSearch = new ECMS.UI.Controls.AppTextBox();
        pnlBody = new System.Windows.Forms.Panel();
        cardList = new ECMS.UI.Controls.AppCard();
        dgvSchedules = new ECMS.UI.Controls.AppDataGrid();
        pnlFooter = new System.Windows.Forms.Panel();
        lblSummary = new System.Windows.Forms.Label();
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
        lblTitle.Location = new System.Drawing.Point(20, 19);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(285, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Quản lý lịch học các lớp";
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
        txtSearch.Placeholder = "Tìm theo mã lớp, giáo viên, phòng học, khung giờ";
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
        dgvSchedules.AllowUserToResizeColumns = false;
        dgvSchedules.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvSchedules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSchedules.BackgroundColor = System.Drawing.Color.White;
        dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSchedules.ColumnHeadersHeight = 36;
        dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvSchedules.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSchedules.EnableHeadersVisualStyles = false;
        dgvSchedules.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvSchedules.Location = new System.Drawing.Point(12, 12);
        dgvSchedules.MultiSelect = false;
        dgvSchedules.Name = "dgvSchedules";
        dgvSchedules.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvSchedules.RowHeadersVisible = false;
        dgvSchedules.RowHeadersWidth = 51;
        dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSchedules.Size = new System.Drawing.Size(1016, 408);
        dgvSchedules.TabIndex = 0;
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
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
        lblSummary.Size = new System.Drawing.Size(136, 20);
        lblSummary.TabIndex = 0;
        lblSummary.Text = "Tổng số lịch lớp: 0";
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
    private System.Windows.Forms.Panel pnlFilter;
    private ECMS.UI.Controls.AppTextBox txtSearch;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardList;
    private ECMS.UI.Controls.AppDataGrid dgvSchedules;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Label lblSummary;
}
