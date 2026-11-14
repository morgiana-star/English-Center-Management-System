namespace ECMS.UI.Forms;

partial class CertificatePrintPreviewDialog
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
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnPrintCert = new ECMS.UI.Controls.AppButton();
        btnClose = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlSettingsBar = new System.Windows.Forms.Panel();
        cboPaperSize = new ECMS.UI.Controls.AppComboBox();
        lblPaperSizeTitle = new System.Windows.Forms.Label();
        cboPrinter = new ECMS.UI.Controls.AppComboBox();
        lblPrinterTitle = new System.Windows.Forms.Label();
        pnlCanvasWrapper = new System.Windows.Forms.Panel();
        pnlA4Landscape = new System.Windows.Forms.Panel();
        pnlInnerFrame = new System.Windows.Forms.Panel();
        lblDirectorName = new System.Windows.Forms.Label();
        lblDirectorTitle = new System.Windows.Forms.Label();
        lblIssueLocationDate = new System.Windows.Forms.Label();
        lblCertDesignNote = new System.Windows.Forms.Label();
        lblCertSerialBottom = new System.Windows.Forms.Label();
        lblResultLine = new System.Windows.Forms.Label();
        lblDurationLine = new System.Windows.Forms.Label();
        lblCourseLine = new System.Windows.Forms.Label();
        lblStudentInfoLine = new System.Windows.Forms.Label();
        lblStudentFullName = new System.Windows.Forms.Label();
        lblCertDocSubtitle = new System.Windows.Forms.Label();
        lblCertDocTitle = new System.Windows.Forms.Label();
        lblCenterName = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        pnlSettingsBar.SuspendLayout();
        pnlCanvasWrapper.SuspendLayout();
        pnlA4Landscape.SuspendLayout();
        pnlInnerFrame.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(1200, 78);
        pnlHeader.TabIndex = 0;
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlTopActions.Controls.Add(btnPrintCert);
        pnlTopActions.Controls.Add(btnClose);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(870, 14);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(300, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnPrintCert
        // 
        btnPrintCert.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnPrintCert.CornerRadius = 5;
        btnPrintCert.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPrintCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrintCert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPrintCert.Location = new System.Drawing.Point(167, 3);
        btnPrintCert.Name = "btnPrintCert";
        btnPrintCert.Size = new System.Drawing.Size(130, 38);
        btnPrintCert.TabIndex = 0;
        btnPrintCert.Text = "In chứng chỉ";
        btnPrintCert.UseVisualStyleBackColor = true;
        btnPrintCert.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnClose
        // 
        btnClose.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnClose.CornerRadius = 5;
        btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnClose.Location = new System.Drawing.Point(61, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(100, 38);
        btnClose.TabIndex = 1;
        btnClose.Text = "Đóng";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(24, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(262, 35);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xem trước chứng chỉ";
        // 
        // pnlSettingsBar
        // 
        pnlSettingsBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlSettingsBar.Controls.Add(cboPaperSize);
        pnlSettingsBar.Controls.Add(lblPaperSizeTitle);
        pnlSettingsBar.Controls.Add(cboPrinter);
        pnlSettingsBar.Controls.Add(lblPrinterTitle);
        pnlSettingsBar.Dock = System.Windows.Forms.DockStyle.Top;
        pnlSettingsBar.Location = new System.Drawing.Point(0, 78);
        pnlSettingsBar.Name = "pnlSettingsBar";
        pnlSettingsBar.Padding = new System.Windows.Forms.Padding(24, 6, 24, 6);
        pnlSettingsBar.Size = new System.Drawing.Size(1200, 68);
        pnlSettingsBar.TabIndex = 1;
        // 
        // cboPaperSize
        // 
        cboPaperSize.BackColor = System.Drawing.Color.Transparent;
        cboPaperSize.CornerRadius = 5;
        cboPaperSize.DataSource = null;
        cboPaperSize.DisplayMember = "";
        cboPaperSize.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboPaperSize.Location = new System.Drawing.Point(370, 26);
        cboPaperSize.Name = "cboPaperSize";
        cboPaperSize.SelectedIndex = -1;
        cboPaperSize.SelectedItem = null;
        cboPaperSize.SelectedValue = null;
        cboPaperSize.Size = new System.Drawing.Size(240, 32);
        cboPaperSize.TabIndex = 3;
        cboPaperSize.ValueMember = "";
        // 
        // lblPaperSizeTitle
        // 
        lblPaperSizeTitle.AutoSize = true;
        lblPaperSizeTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblPaperSizeTitle.Location = new System.Drawing.Point(370, 8);
        lblPaperSizeTitle.Name = "lblPaperSizeTitle";
        lblPaperSizeTitle.Size = new System.Drawing.Size(131, 20);
        lblPaperSizeTitle.TabIndex = 2;
        lblPaperSizeTitle.Text = "Khổ giấy / số bản";
        // 
        // cboPrinter
        // 
        cboPrinter.BackColor = System.Drawing.Color.Transparent;
        cboPrinter.CornerRadius = 5;
        cboPrinter.DataSource = null;
        cboPrinter.DisplayMember = "";
        cboPrinter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboPrinter.Location = new System.Drawing.Point(24, 26);
        cboPrinter.Name = "cboPrinter";
        cboPrinter.SelectedIndex = -1;
        cboPrinter.SelectedItem = null;
        cboPrinter.SelectedValue = null;
        cboPrinter.Size = new System.Drawing.Size(320, 32);
        cboPrinter.TabIndex = 1;
        cboPrinter.ValueMember = "";
        // 
        // lblPrinterTitle
        // 
        lblPrinterTitle.AutoSize = true;
        lblPrinterTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblPrinterTitle.Location = new System.Drawing.Point(24, 8);
        lblPrinterTitle.Name = "lblPrinterTitle";
        lblPrinterTitle.Size = new System.Drawing.Size(105, 20);
        lblPrinterTitle.TabIndex = 0;
        lblPrinterTitle.Text = "Máy in cục bộ";
        // 
        // pnlCanvasWrapper
        // 
        pnlCanvasWrapper.AutoScroll = true;
        pnlCanvasWrapper.BackColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlCanvasWrapper.Controls.Add(pnlA4Landscape);
        pnlCanvasWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlCanvasWrapper.Location = new System.Drawing.Point(0, 146);
        pnlCanvasWrapper.Name = "pnlCanvasWrapper";
        pnlCanvasWrapper.Padding = new System.Windows.Forms.Padding(24);
        pnlCanvasWrapper.Size = new System.Drawing.Size(1200, 594);
        pnlCanvasWrapper.TabIndex = 2;
        // 
        // pnlA4Landscape
        // 
        pnlA4Landscape.Anchor = System.Windows.Forms.AnchorStyles.Top;
        pnlA4Landscape.BackColor = System.Drawing.Color.White;
        pnlA4Landscape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlA4Landscape.Controls.Add(pnlInnerFrame);
        pnlA4Landscape.Location = new System.Drawing.Point(90, 15);
        pnlA4Landscape.Name = "pnlA4Landscape";
        pnlA4Landscape.Padding = new System.Windows.Forms.Padding(18);
        pnlA4Landscape.Size = new System.Drawing.Size(1020, 510);
        pnlA4Landscape.TabIndex = 0;
        // 
        // pnlInnerFrame
        // 
        pnlInnerFrame.BackColor = System.Drawing.Color.White;
        pnlInnerFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlInnerFrame.Controls.Add(lblDirectorName);
        pnlInnerFrame.Controls.Add(lblDirectorTitle);
        pnlInnerFrame.Controls.Add(lblIssueLocationDate);
        pnlInnerFrame.Controls.Add(lblCertDesignNote);
        pnlInnerFrame.Controls.Add(lblCertSerialBottom);
        pnlInnerFrame.Controls.Add(lblResultLine);
        pnlInnerFrame.Controls.Add(lblDurationLine);
        pnlInnerFrame.Controls.Add(lblCourseLine);
        pnlInnerFrame.Controls.Add(lblStudentInfoLine);
        pnlInnerFrame.Controls.Add(lblStudentFullName);
        pnlInnerFrame.Controls.Add(lblCertDocSubtitle);
        pnlInnerFrame.Controls.Add(lblCertDocTitle);
        pnlInnerFrame.Controls.Add(lblCenterName);
        pnlInnerFrame.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlInnerFrame.Location = new System.Drawing.Point(18, 18);
        pnlInnerFrame.Name = "pnlInnerFrame";
        pnlInnerFrame.Padding = new System.Windows.Forms.Padding(24);
        pnlInnerFrame.Size = new System.Drawing.Size(982, 472);
        pnlInnerFrame.TabIndex = 0;
        // 
        // lblDirectorName
        // 
        lblDirectorName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDirectorName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDirectorName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDirectorName.Location = new System.Drawing.Point(680, 425);
        lblDirectorName.Name = "lblDirectorName";
        lblDirectorName.Size = new System.Drawing.Size(260, 20);
        lblDirectorName.TabIndex = 12;
        lblDirectorName.Text = "Nguyễn Thành Long";
        lblDirectorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDirectorTitle
        // 
        lblDirectorTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblDirectorTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblDirectorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblDirectorTitle.Location = new System.Drawing.Point(680, 355);
        lblDirectorTitle.Name = "lblDirectorTitle";
        lblDirectorTitle.Size = new System.Drawing.Size(260, 20);
        lblDirectorTitle.TabIndex = 11;
        lblDirectorTitle.Text = "GIÁM ĐỐC TRUNG TÂM";
        lblDirectorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblIssueLocationDate
        // 
        lblIssueLocationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblIssueLocationDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblIssueLocationDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblIssueLocationDate.Location = new System.Drawing.Point(680, 330);
        lblIssueLocationDate.Name = "lblIssueLocationDate";
        lblIssueLocationDate.Size = new System.Drawing.Size(260, 20);
        lblIssueLocationDate.TabIndex = 10;
        lblIssueLocationDate.Text = "TP. Hồ Chí Minh, ngày 30 tháng 10 năm 2026";
        lblIssueLocationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCertDesignNote
        // 
        lblCertDesignNote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
        lblCertDesignNote.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)148)), ((int)((byte)163)), ((int)((byte)184)));
        lblCertDesignNote.Location = new System.Drawing.Point(40, 385);
        lblCertDesignNote.Name = "lblCertDesignNote";
        lblCertDesignNote.Size = new System.Drawing.Size(260, 20);
        lblCertDesignNote.TabIndex = 9;
        lblCertDesignNote.Text = "Dữ liệu thiết kế minh họa";
        // 
        // lblCertSerialBottom
        // 
        lblCertSerialBottom.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
        lblCertSerialBottom.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblCertSerialBottom.Location = new System.Drawing.Point(40, 360);
        lblCertSerialBottom.Name = "lblCertSerialBottom";
        lblCertSerialBottom.Size = new System.Drawing.Size(260, 20);
        lblCertSerialBottom.TabIndex = 8;
        lblCertSerialBottom.Text = "Số chứng chỉ: CC-2026-0042";
        // 
        // lblResultLine
        // 
        lblResultLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblResultLine.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblResultLine.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblResultLine.Location = new System.Drawing.Point(24, 260);
        lblResultLine.Name = "lblResultLine";
        lblResultLine.Size = new System.Drawing.Size(932, 24);
        lblResultLine.TabIndex = 7;
        lblResultLine.Text = "Kết quả: 7,7 / 10 · Xếp loại: Khá · Chuyên cần: 91,7%";
        lblResultLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDurationLine
        // 
        lblDurationLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblDurationLine.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblDurationLine.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblDurationLine.Location = new System.Drawing.Point(24, 228);
        lblDurationLine.Name = "lblDurationLine";
        lblDurationLine.Size = new System.Drawing.Size(932, 20);
        lblDurationLine.TabIndex = 6;
        lblDurationLine.Text = "Thời gian: 03/08/2026 – 23/10/2026 · 48 giờ / 24 buổi";
        lblDurationLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCourseLine
        // 
        lblCourseLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCourseLine.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblCourseLine.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCourseLine.Location = new System.Drawing.Point(24, 200);
        lblCourseLine.Name = "lblCourseLine";
        lblCourseLine.Size = new System.Drawing.Size(932, 22);
        lblCourseLine.TabIndex = 5;
        lblCourseLine.Text = "Đã hoàn thành khóa IELTS Foundation · Lớp IELTS-F02";
        lblCourseLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblStudentInfoLine
        // 
        lblStudentInfoLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblStudentInfoLine.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblStudentInfoLine.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)71)), ((int)((byte)85)), ((int)((byte)105)));
        lblStudentInfoLine.Location = new System.Drawing.Point(24, 168);
        lblStudentInfoLine.Name = "lblStudentInfoLine";
        lblStudentInfoLine.Size = new System.Drawing.Size(932, 20);
        lblStudentInfoLine.TabIndex = 4;
        lblStudentInfoLine.Text = "Ngày sinh: 12/03/2007 · Mã học viên: HV-0204";
        lblStudentInfoLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblStudentFullName
        // 
        lblStudentFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblStudentFullName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblStudentFullName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)29)), ((int)((byte)78)), ((int)((byte)216)));
        lblStudentFullName.Location = new System.Drawing.Point(24, 120);
        lblStudentFullName.Name = "lblStudentFullName";
        lblStudentFullName.Size = new System.Drawing.Size(932, 40);
        lblStudentFullName.TabIndex = 3;
        lblStudentFullName.Text = "TRẦN GIA BẢO";
        lblStudentFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCertDocSubtitle
        // 
        lblCertDocSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCertDocSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
        lblCertDocSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblCertDocSubtitle.Location = new System.Drawing.Point(24, 90);
        lblCertDocSubtitle.Name = "lblCertDocSubtitle";
        lblCertDocSubtitle.Size = new System.Drawing.Size(932, 20);
        lblCertDocSubtitle.TabIndex = 2;
        lblCertDocSubtitle.Text = "Chứng nhận học viên";
        lblCertDocSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCertDocTitle
        // 
        lblCertDocTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCertDocTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblCertDocTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblCertDocTitle.Location = new System.Drawing.Point(24, 52);
        lblCertDocTitle.Name = "lblCertDocTitle";
        lblCertDocTitle.Size = new System.Drawing.Size(932, 34);
        lblCertDocTitle.TabIndex = 1;
        lblCertDocTitle.Text = "CHỨNG CHỈ HOÀN THÀNH KHÓA HỌC";
        lblCertDocTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCenterName
        // 
        lblCenterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCenterName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblCenterName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)58)), ((int)((byte)138)));
        lblCenterName.Location = new System.Drawing.Point(24, 20);
        lblCenterName.Name = "lblCenterName";
        lblCenterName.Size = new System.Drawing.Size(932, 22);
        lblCenterName.TabIndex = 0;
        lblCenterName.Text = "TRUNG TÂM ANH NGỮ MINH TRÍ";
        lblCenterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CertificatePrintPreviewDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlCanvasWrapper);
        Controls.Add(pnlSettingsBar);
        Controls.Add(pnlHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Xem trước chứng chỉ hoàn thành · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        pnlSettingsBar.ResumeLayout(false);
        pnlSettingsBar.PerformLayout();
        pnlCanvasWrapper.ResumeLayout(false);
        pnlA4Landscape.ResumeLayout(false);
        pnlInnerFrame.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnPrintCert;
    private ECMS.UI.Controls.AppButton btnClose;

    private System.Windows.Forms.Panel pnlSettingsBar;
    private System.Windows.Forms.Label lblPrinterTitle;
    private ECMS.UI.Controls.AppComboBox cboPrinter;
    private System.Windows.Forms.Label lblPaperSizeTitle;
    private ECMS.UI.Controls.AppComboBox cboPaperSize;

    private System.Windows.Forms.Panel pnlCanvasWrapper;
    private System.Windows.Forms.Panel pnlA4Landscape;
    private System.Windows.Forms.Panel pnlInnerFrame;
    private System.Windows.Forms.Label lblCenterName;
    private System.Windows.Forms.Label lblCertDocTitle;
    private System.Windows.Forms.Label lblCertDocSubtitle;
    private System.Windows.Forms.Label lblStudentFullName;
    private System.Windows.Forms.Label lblStudentInfoLine;
    private System.Windows.Forms.Label lblCourseLine;
    private System.Windows.Forms.Label lblDurationLine;
    private System.Windows.Forms.Label lblResultLine;
    private System.Windows.Forms.Label lblCertSerialBottom;
    private System.Windows.Forms.Label lblCertDesignNote;
    private System.Windows.Forms.Label lblIssueLocationDate;
    private System.Windows.Forms.Label lblDirectorTitle;
    private System.Windows.Forms.Label lblDirectorName;
}
