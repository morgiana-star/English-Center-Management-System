namespace ECMS.UI.UserControls;

partial class ClassManagementView
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

    #region Component Designer generated code

    private void InitializeComponent()
    {
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddClass = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        pnlBottomCards = new System.Windows.Forms.Panel();
        cardEmptyClass = new ECMS.UI.Controls.AppCard();
        lblEmptyClassNote = new System.Windows.Forms.Label();
        btnAddStudentToClass = new ECMS.UI.Controls.AppButton();
        lblEmptyClassDesc = new System.Windows.Forms.Label();
        lblEmptyClassTitle = new System.Windows.Forms.Label();
        cardOpenClass = new ECMS.UI.Controls.AppCard();
        lblOpenClassNote = new System.Windows.Forms.Label();
        btnCheckAndOpenClass = new ECMS.UI.Controls.AppButton();
        lblOpenClassChecks = new System.Windows.Forms.Label();
        lblOpenClassTitle = new System.Windows.Forms.Label();
        cardClassList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        cboCourseFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchClass = new ECMS.UI.Controls.AppTextBox();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlBottomCards.SuspendLayout();
        cardEmptyClass.SuspendLayout();
        cardOpenClass.SuspendLayout();
        cardClassList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddClass);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddClass
        // 
        btnAddClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddClass.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnAddClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnAddClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddClass.ForeColor = System.Drawing.Color.White;
        btnAddClass.Location = new System.Drawing.Point(1005, 20);
        btnAddClass.Name = "btnAddClass";
        btnAddClass.Size = new System.Drawing.Size(131, 36);
        btnAddClass.TabIndex = 3;
        btnAddClass.Text = "+ Thêm lớp học";
        btnAddClass.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(232, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Dữ liệu mẫu · Trung tâm Anh ngữ Minh Trí";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(95, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lớp học";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(130, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lớp học / Lớp học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(pnlBottomCards);
        pnlBody.Controls.Add(cardClassList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // pnlBottomCards
        // 
        pnlBottomCards.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pnlBottomCards.Controls.Add(cardEmptyClass);
        pnlBottomCards.Controls.Add(cardOpenClass);
        pnlBottomCards.Location = new System.Drawing.Point(24, 400);
        pnlBottomCards.Name = "pnlBottomCards";
        pnlBottomCards.Size = new System.Drawing.Size(1112, 180);
        pnlBottomCards.TabIndex = 1;
        // 
        // cardEmptyClass
        // 
        cardEmptyClass.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardEmptyClass.BackColor = System.Drawing.Color.White;
        cardEmptyClass.Controls.Add(lblEmptyClassNote);
        cardEmptyClass.Controls.Add(btnAddStudentToClass);
        cardEmptyClass.Controls.Add(lblEmptyClassDesc);
        cardEmptyClass.Controls.Add(lblEmptyClassTitle);
        cardEmptyClass.Location = new System.Drawing.Point(570, 0);
        cardEmptyClass.Name = "cardEmptyClass";
        cardEmptyClass.Padding = new System.Windows.Forms.Padding(20);
        cardEmptyClass.Size = new System.Drawing.Size(542, 170);
        cardEmptyClass.TabIndex = 1;
        // 
        // lblEmptyClassNote
        // 
        lblEmptyClassNote.AutoSize = true;
        lblEmptyClassNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblEmptyClassNote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblEmptyClassNote.Location = new System.Drawing.Point(20, 132);
        lblEmptyClassNote.Name = "lblEmptyClassNote";
        lblEmptyClassNote.Size = new System.Drawing.Size(306, 15);
        lblEmptyClassNote.TabIndex = 3;
        lblEmptyClassNote.Text = "Trạng thái rỗng thực tế: không hiển thị dòng dữ liệu giả.";
        // 
        // btnAddStudentToClass
        // 
        btnAddStudentToClass.BackColor = System.Drawing.Color.White;
        btnAddStudentToClass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnAddStudentToClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnAddStudentToClass.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnAddStudentToClass.Location = new System.Drawing.Point(20, 85);
        btnAddStudentToClass.Name = "btnAddStudentToClass";
        btnAddStudentToClass.Size = new System.Drawing.Size(160, 36);
        btnAddStudentToClass.TabIndex = 2;
        btnAddStudentToClass.Text = "Thêm học viên vào lớp";
        btnAddStudentToClass.UseVisualStyleBackColor = false;
        // 
        // lblEmptyClassDesc
        // 
        lblEmptyClassDesc.AutoSize = true;
        lblEmptyClassDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmptyClassDesc.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblEmptyClassDesc.Location = new System.Drawing.Point(20, 50);
        lblEmptyClassDesc.Name = "lblEmptyClassDesc";
        lblEmptyClassDesc.Size = new System.Drawing.Size(342, 15);
        lblEmptyClassDesc.TabIndex = 1;
        lblEmptyClassDesc.Text = "IELTS-F04 đang ở bản nháp, chưa có học viên được ghi danh.";
        // 
        // lblEmptyClassTitle
        // 
        lblEmptyClassTitle.AutoSize = true;
        lblEmptyClassTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblEmptyClassTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblEmptyClassTitle.Location = new System.Drawing.Point(20, 16);
        lblEmptyClassTitle.Name = "lblEmptyClassTitle";
        lblEmptyClassTitle.Size = new System.Drawing.Size(160, 21);
        lblEmptyClassTitle.TabIndex = 0;
        lblEmptyClassTitle.Text = "Lớp chưa có học viên";
        // 
        // cardOpenClass
        // 
        cardOpenClass.BackColor = System.Drawing.Color.White;
        cardOpenClass.Controls.Add(lblOpenClassNote);
        cardOpenClass.Controls.Add(btnCheckAndOpenClass);
        cardOpenClass.Controls.Add(lblOpenClassChecks);
        cardOpenClass.Controls.Add(lblOpenClassTitle);
        cardOpenClass.Location = new System.Drawing.Point(0, 0);
        cardOpenClass.Name = "cardOpenClass";
        cardOpenClass.Padding = new System.Windows.Forms.Padding(20);
        cardOpenClass.Size = new System.Drawing.Size(542, 170);
        cardOpenClass.TabIndex = 0;
        // 
        // lblOpenClassNote
        // 
        lblOpenClassNote.AutoSize = true;
        lblOpenClassNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblOpenClassNote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblOpenClassNote.Location = new System.Drawing.Point(20, 132);
        lblOpenClassNote.Name = "lblOpenClassNote";
        lblOpenClassNote.Size = new System.Drawing.Size(327, 15);
        lblOpenClassNote.TabIndex = 3;
        lblOpenClassNote.Text = "Chỉ chuyển sang Đang học sau khi xác nhận và đủ điều kiện.";
        // 
        // btnCheckAndOpenClass
        // 
        btnCheckAndOpenClass.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnCheckAndOpenClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnCheckAndOpenClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCheckAndOpenClass.ForeColor = System.Drawing.Color.White;
        btnCheckAndOpenClass.Location = new System.Drawing.Point(20, 85);
        btnCheckAndOpenClass.Name = "btnCheckAndOpenClass";
        btnCheckAndOpenClass.Size = new System.Drawing.Size(150, 36);
        btnCheckAndOpenClass.TabIndex = 2;
        btnCheckAndOpenClass.Text = "Kiểm tra & mở lớp";
        btnCheckAndOpenClass.UseVisualStyleBackColor = false;
        // 
        // lblOpenClassChecks
        // 
        lblOpenClassChecks.AutoSize = true;
        lblOpenClassChecks.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblOpenClassChecks.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblOpenClassChecks.Location = new System.Drawing.Point(20, 50);
        lblOpenClassChecks.Name = "lblOpenClassChecks";
        lblOpenClassChecks.Size = new System.Drawing.Size(425, 15);
        lblOpenClassChecks.TabIndex = 1;
        lblOpenClassChecks.Text = "✓ Đã phân công Lê Thu Hà · ✓ P203 có 18 chỗ · ✓ 12 học viên · ✓ Lịch không trùng.";
        // 
        // lblOpenClassTitle
        // 
        lblOpenClassTitle.AutoSize = true;
        lblOpenClassTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblOpenClassTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblOpenClassTitle.Location = new System.Drawing.Point(20, 16);
        lblOpenClassTitle.Name = "lblOpenClassTitle";
        lblOpenClassTitle.Size = new System.Drawing.Size(142, 21);
        lblOpenClassTitle.TabIndex = 0;
        lblOpenClassTitle.Text = "Mở lớp COM-B01";
        // 
        // cardClassList
        // 
        cardClassList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardClassList.BackColor = System.Drawing.Color.White;
        cardClassList.Controls.Add(lblPagingNav);
        cardClassList.Controls.Add(lblPagingInfo);
        cardClassList.Controls.Add(dgvClasses);
        cardClassList.Controls.Add(cboStatusFilter);
        cardClassList.Controls.Add(cboCourseFilter);
        cardClassList.Controls.Add(txtSearchClass);
        cardClassList.Location = new System.Drawing.Point(24, 16);
        cardClassList.Name = "cardClassList";
        cardClassList.Padding = new System.Windows.Forms.Padding(20);
        cardClassList.Size = new System.Drawing.Size(1112, 365);
        cardClassList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(970, 330);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(122, 15);
        lblPagingNav.TabIndex = 5;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPagingInfo.Location = new System.Drawing.Point(20, 330);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(89, 15);
        lblPagingInfo.TabIndex = 4;
        lblPagingInfo.Text = "1–5 / 24 lớp học";
        // 
        // dgvClasses
        // 
        dgvClasses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClasses.Location = new System.Drawing.Point(20, 68);
        dgvClasses.Name = "dgvClasses";
        dgvClasses.Size = new System.Drawing.Size(1072, 248);
        dgvClasses.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(505, 18);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(165, 35);
        cboStatusFilter.TabIndex = 2;
        // 
        // cboCourseFilter
        // 
        cboCourseFilter.Location = new System.Drawing.Point(325, 18);
        cboCourseFilter.Name = "cboCourseFilter";
        cboCourseFilter.Size = new System.Drawing.Size(170, 35);
        cboCourseFilter.TabIndex = 1;
        // 
        // txtSearchClass
        // 
        txtSearchClass.Location = new System.Drawing.Point(20, 18);
        txtSearchClass.Name = "txtSearchClass";
        txtSearchClass.Placeholder = "🔍  Tìm mã lớp, khóa học, giáo viên...";
        txtSearchClass.Size = new System.Drawing.Size(295, 35);
        txtSearchClass.TabIndex = 0;
        // 
        // ClassManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "ClassManagementView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlBottomCards.ResumeLayout(false);
        cardEmptyClass.ResumeLayout(false);
        cardEmptyClass.PerformLayout();
        cardOpenClass.ResumeLayout(false);
        cardOpenClass.PerformLayout();
        cardClassList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddClass;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardClassList;
    private ECMS.UI.Controls.AppTextBox txtSearchClass;
    private ECMS.UI.Controls.AppComboBox cboCourseFilter;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Panel pnlBottomCards;
    private ECMS.UI.Controls.AppCard cardOpenClass;
    private System.Windows.Forms.Label lblOpenClassTitle;
    private System.Windows.Forms.Label lblOpenClassChecks;
    private ECMS.UI.Controls.AppButton btnCheckAndOpenClass;
    private System.Windows.Forms.Label lblOpenClassNote;
    private ECMS.UI.Controls.AppCard cardEmptyClass;
    private System.Windows.Forms.Label lblEmptyClassTitle;
    private System.Windows.Forms.Label lblEmptyClassDesc;
    private ECMS.UI.Controls.AppButton btnAddStudentToClass;
    private System.Windows.Forms.Label lblEmptyClassNote;
}
