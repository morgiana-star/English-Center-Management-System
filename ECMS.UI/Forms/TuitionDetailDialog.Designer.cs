namespace ECMS.UI.Forms;

partial class TuitionDetailDialog
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
        btnClose = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardInstallments = new ECMS.UI.Controls.AppCard();
        dgvInstallments = new ECMS.UI.Controls.AppDataGrid();
        lblInstallmentsTitle = new System.Windows.Forms.Label();
        cardSummary = new ECMS.UI.Controls.AppCard();
        lblRemainingVal = new System.Windows.Forms.Label();
        lblRemainingTitle = new System.Windows.Forms.Label();
        lblPaidVal = new System.Windows.Forms.Label();
        lblPaidTitle = new System.Windows.Forms.Label();
        lblTotalVal = new System.Windows.Forms.Label();
        lblTotalTitle = new System.Windows.Forms.Label();
        lblDiscountVal = new System.Windows.Forms.Label();
        lblDiscountTitle = new System.Windows.Forms.Label();
        lblOriginalVal = new System.Windows.Forms.Label();
        lblOriginalTitle = new System.Windows.Forms.Label();
        lblClassVal = new System.Windows.Forms.Label();
        lblClassTitle = new System.Windows.Forms.Label();
        lblStudentVal = new System.Windows.Forms.Label();
        lblStudentTitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        btnCollectNow = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardInstallments.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInstallments).BeginInit();
        cardSummary.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnClose);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(860, 68);
        pnlHeader.TabIndex = 0;
        // 
        // btnClose
        // 
        btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnClose.BackColor = System.Drawing.Color.White;
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClose.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnClose.Location = new System.Drawing.Point(745, 15);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(90, 36);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(22, 17);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(390, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Chi tiết học phí học viên · Nguyễn Minh Anh";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        pnlBody.Controls.Add(cardInstallments);
        pnlBody.Controls.Add(cardSummary);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 68);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
        pnlBody.Size = new System.Drawing.Size(860, 482);
        pnlBody.TabIndex = 1;
        // 
        // cardInstallments
        // 
        cardInstallments.BackColor = System.Drawing.Color.White;
        cardInstallments.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardInstallments.BorderWidth = 1;
        cardInstallments.Controls.Add(dgvInstallments);
        cardInstallments.Controls.Add(lblInstallmentsTitle);
        cardInstallments.CornerRadius = 6;
        cardInstallments.Dock = System.Windows.Forms.DockStyle.Fill;
        cardInstallments.Location = new System.Drawing.Point(20, 184);
        cardInstallments.Name = "cardInstallments";
        cardInstallments.Padding = new System.Windows.Forms.Padding(16);
        cardInstallments.Size = new System.Drawing.Size(820, 284);
        cardInstallments.TabIndex = 1;
        // 
        // dgvInstallments
        // 
        dgvInstallments.AllowUserToAddRows = false;
        dgvInstallments.AllowUserToDeleteRows = false;
        dgvInstallments.AllowUserToResizeColumns = false;
        dgvInstallments.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        dgvInstallments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvInstallments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvInstallments.BackgroundColor = System.Drawing.Color.White;
        dgvInstallments.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvInstallments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvInstallments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvInstallments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvInstallments.ColumnHeadersHeight = 36;
        dgvInstallments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvInstallments.DefaultCellStyle = dataGridViewCellStyle3;
        dgvInstallments.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvInstallments.EnableHeadersVisualStyles = false;
        dgvInstallments.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        dgvInstallments.Location = new System.Drawing.Point(16, 42);
        dgvInstallments.MultiSelect = false;
        dgvInstallments.Name = "dgvInstallments";
        dgvInstallments.ReadOnly = true;
        dgvInstallments.RowHeadersVisible = false;
        dgvInstallments.RowHeadersWidth = 51;
        dgvInstallments.RowTemplate.Height = 38;
        dgvInstallments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvInstallments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvInstallments.Size = new System.Drawing.Size(788, 226);
        dgvInstallments.TabIndex = 1;
        // 
        // lblInstallmentsTitle
        // 
        lblInstallmentsTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblInstallmentsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblInstallmentsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblInstallmentsTitle.Location = new System.Drawing.Point(16, 16);
        lblInstallmentsTitle.Name = "lblInstallmentsTitle";
        lblInstallmentsTitle.Size = new System.Drawing.Size(788, 26);
        lblInstallmentsTitle.TabIndex = 0;
        lblInstallmentsTitle.Text = "LỊCH TRÌNH THANH TOÁN THEO ĐỢT & PHIẾU THU";
        // 
        // cardSummary
        // 
        cardSummary.BackColor = System.Drawing.Color.White;
        cardSummary.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardSummary.BorderWidth = 1;
        cardSummary.Controls.Add(lblRemainingVal);
        cardSummary.Controls.Add(lblRemainingTitle);
        cardSummary.Controls.Add(lblPaidVal);
        cardSummary.Controls.Add(lblPaidTitle);
        cardSummary.Controls.Add(lblTotalVal);
        cardSummary.Controls.Add(lblTotalTitle);
        cardSummary.Controls.Add(lblDiscountVal);
        cardSummary.Controls.Add(lblDiscountTitle);
        cardSummary.Controls.Add(lblOriginalVal);
        cardSummary.Controls.Add(lblOriginalTitle);
        cardSummary.Controls.Add(lblClassVal);
        cardSummary.Controls.Add(lblClassTitle);
        cardSummary.Controls.Add(lblStudentVal);
        cardSummary.Controls.Add(lblStudentTitle);
        cardSummary.CornerRadius = 6;
        cardSummary.Dock = System.Windows.Forms.DockStyle.Top;
        cardSummary.Location = new System.Drawing.Point(20, 14);
        cardSummary.Name = "cardSummary";
        cardSummary.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
        cardSummary.Size = new System.Drawing.Size(820, 170);
        cardSummary.TabIndex = 0;
        // 
        // lblRemainingVal
        // 
        lblRemainingVal.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        lblRemainingVal.Location = new System.Drawing.Point(540, 120);
        lblRemainingVal.Name = "lblRemainingVal";
        lblRemainingVal.Size = new System.Drawing.Size(250, 26);
        lblRemainingVal.TabIndex = 13;
        lblRemainingVal.Text = "3.400.000 đ";
        // 
        // lblRemainingTitle
        // 
        lblRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblRemainingTitle.Location = new System.Drawing.Point(400, 124);
        lblRemainingTitle.Name = "lblRemainingTitle";
        lblRemainingTitle.Size = new System.Drawing.Size(130, 20);
        lblRemainingTitle.TabIndex = 12;
        lblRemainingTitle.Text = "Còn phải thu:";
        // 
        // lblPaidVal
        // 
        lblPaidVal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblPaidVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblPaidVal.Location = new System.Drawing.Point(145, 120);
        lblPaidVal.Name = "lblPaidVal";
        lblPaidVal.Size = new System.Drawing.Size(230, 24);
        lblPaidVal.TabIndex = 11;
        lblPaidVal.Text = "2.000.000 đ";
        // 
        // lblPaidTitle
        // 
        lblPaidTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPaidTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblPaidTitle.Location = new System.Drawing.Point(18, 124);
        lblPaidTitle.Name = "lblPaidTitle";
        lblPaidTitle.Size = new System.Drawing.Size(120, 20);
        lblPaidTitle.TabIndex = 10;
        lblPaidTitle.Text = "Đã thanh toán:";
        // 
        // lblTotalVal
        // 
        lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblTotalVal.Location = new System.Drawing.Point(540, 85);
        lblTotalVal.Name = "lblTotalVal";
        lblTotalVal.Size = new System.Drawing.Size(250, 22);
        lblTotalVal.TabIndex = 9;
        lblTotalVal.Text = "5.400.000 đ";
        // 
        // lblTotalTitle
        // 
        lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblTotalTitle.Location = new System.Drawing.Point(400, 87);
        lblTotalTitle.Name = "lblTotalTitle";
        lblTotalTitle.Size = new System.Drawing.Size(130, 20);
        lblTotalTitle.TabIndex = 8;
        lblTotalTitle.Text = "Tổng phải thu:";
        // 
        // lblDiscountVal
        // 
        lblDiscountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
        lblDiscountVal.Location = new System.Drawing.Point(145, 85);
        lblDiscountVal.Name = "lblDiscountVal";
        lblDiscountVal.Size = new System.Drawing.Size(230, 22);
        lblDiscountVal.TabIndex = 7;
        lblDiscountVal.Text = "-600.000 đ (10% đăng ký sớm)";
        // 
        // lblDiscountTitle
        // 
        lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDiscountTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblDiscountTitle.Location = new System.Drawing.Point(18, 87);
        lblDiscountTitle.Name = "lblDiscountTitle";
        lblDiscountTitle.Size = new System.Drawing.Size(120, 20);
        lblDiscountTitle.TabIndex = 6;
        lblDiscountTitle.Text = "Ưu đãi / Giảm:";
        // 
        // lblOriginalVal
        // 
        lblOriginalVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblOriginalVal.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblOriginalVal.Location = new System.Drawing.Point(540, 50);
        lblOriginalVal.Name = "lblOriginalVal";
        lblOriginalVal.Size = new System.Drawing.Size(250, 22);
        lblOriginalVal.TabIndex = 5;
        lblOriginalVal.Text = "6.000.000 đ";
        // 
        // lblOriginalTitle
        // 
        lblOriginalTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblOriginalTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblOriginalTitle.Location = new System.Drawing.Point(400, 52);
        lblOriginalTitle.Name = "lblOriginalTitle";
        lblOriginalTitle.Size = new System.Drawing.Size(130, 20);
        lblOriginalTitle.TabIndex = 4;
        lblOriginalTitle.Text = "Học phí gốc:";
        // 
        // lblClassVal
        // 
        lblClassVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblClassVal.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblClassVal.Location = new System.Drawing.Point(145, 50);
        lblClassVal.Name = "lblClassVal";
        lblClassVal.Size = new System.Drawing.Size(230, 22);
        lblClassVal.TabIndex = 3;
        lblClassVal.Text = "IELTS Foundation · IELTS-F01";
        // 
        // lblClassTitle
        // 
        lblClassTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblClassTitle.Location = new System.Drawing.Point(18, 52);
        lblClassTitle.Name = "lblClassTitle";
        lblClassTitle.Size = new System.Drawing.Size(120, 20);
        lblClassTitle.TabIndex = 2;
        lblClassTitle.Text = "Khóa / Lớp:";
        // 
        // lblStudentVal
        // 
        lblStudentVal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblStudentVal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblStudentVal.Location = new System.Drawing.Point(145, 14);
        lblStudentVal.Name = "lblStudentVal";
        lblStudentVal.Size = new System.Drawing.Size(640, 26);
        lblStudentVal.TabIndex = 1;
        lblStudentVal.Text = "Nguyễn Minh Anh  ·  Mã HV: HV-0241";
        // 
        // lblStudentTitle
        // 
        lblStudentTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStudentTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblStudentTitle.Location = new System.Drawing.Point(18, 18);
        lblStudentTitle.Name = "lblStudentTitle";
        lblStudentTitle.Size = new System.Drawing.Size(120, 20);
        lblStudentTitle.TabIndex = 0;
        lblStudentTitle.Text = "Học viên:";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(btnCollectNow);
        pnlFooter.Controls.Add(btnCancel);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 550);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
        pnlFooter.Size = new System.Drawing.Size(860, 60);
        pnlFooter.TabIndex = 2;
        // 
        // btnCollectNow
        // 
        btnCollectNow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnCollectNow.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCollectNow.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCollectNow.CornerRadius = 5;
        btnCollectNow.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCollectNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCollectNow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnCollectNow.ForeColor = System.Drawing.Color.White;
        btnCollectNow.Location = new System.Drawing.Point(695, 11);
        btnCollectNow.Name = "btnCollectNow";
        btnCollectNow.Size = new System.Drawing.Size(145, 38);
        btnCollectNow.TabIndex = 1;
        btnCollectNow.Text = "💵 Thu học phí";
        btnCollectNow.UseVisualStyleBackColor = false;
        btnCollectNow.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancel.CornerRadius = 5;
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancel.Location = new System.Drawing.Point(595, 11);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 38);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Đóng";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // TuitionDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(860, 610);
        Controls.Add(pnlBody);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TuitionDetailDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết học phí · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardInstallments.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInstallments).EndInit();
        cardSummary.ResumeLayout(false);
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnClose;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardSummary;
    private System.Windows.Forms.Label lblStudentTitle;
    private System.Windows.Forms.Label lblStudentVal;
    private System.Windows.Forms.Label lblClassTitle;
    private System.Windows.Forms.Label lblClassVal;
    private System.Windows.Forms.Label lblOriginalTitle;
    private System.Windows.Forms.Label lblOriginalVal;
    private System.Windows.Forms.Label lblDiscountTitle;
    private System.Windows.Forms.Label lblDiscountVal;
    private System.Windows.Forms.Label lblTotalTitle;
    private System.Windows.Forms.Label lblTotalVal;
    private System.Windows.Forms.Label lblPaidTitle;
    private System.Windows.Forms.Label lblPaidVal;
    private System.Windows.Forms.Label lblRemainingTitle;
    private System.Windows.Forms.Label lblRemainingVal;
    private ECMS.UI.Controls.AppCard cardInstallments;
    private System.Windows.Forms.Label lblInstallmentsTitle;
    private ECMS.UI.Controls.AppDataGrid dgvInstallments;
    private System.Windows.Forms.Panel pnlFooter;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnCollectNow;
}
