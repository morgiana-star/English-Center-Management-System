namespace ECMS.UI.UserControls;

partial class CourseManagementView
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
        btnAddCourse = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCourseList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvCourses = new ECMS.UI.Controls.AppDataGrid();
        cboLevelFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchCourse = new ECMS.UI.Controls.AppTextBox();
        lblCourseListTitle = new System.Windows.Forms.Label();
        pnlBottomCards = new System.Windows.Forms.Panel();
        cardClassInfo = new ECMS.UI.Controls.AppCard();
        btnViewRelatedClasses = new ECMS.UI.Controls.AppButton();
        lblClassHandoverVal = new System.Windows.Forms.Label();
        lblClassHandoverKey = new System.Windows.Forms.Label();
        lblClassMgmtVal = new System.Windows.Forms.Label();
        lblClassMgmtKey = new System.Windows.Forms.Label();
        lblClassExampleVal = new System.Windows.Forms.Label();
        lblClassExampleKey = new System.Windows.Forms.Label();
        lblClassCardTitle = new System.Windows.Forms.Label();
        cardCourseInfo = new ECMS.UI.Controls.AppCard();
        btnOpenCourseDetail = new ECMS.UI.Controls.AppButton();
        lblCourseChangeVal = new System.Windows.Forms.Label();
        lblCourseChangeKey = new System.Windows.Forms.Label();
        lblCourseMgmtVal = new System.Windows.Forms.Label();
        lblCourseMgmtKey = new System.Windows.Forms.Label();
        lblCourseExampleVal = new System.Windows.Forms.Label();
        lblCourseExampleKey = new System.Windows.Forms.Label();
        lblCourseCardTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCourseList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
        pnlBottomCards.SuspendLayout();
        cardClassInfo.SuspendLayout();
        cardCourseInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddCourse);
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
        // btnAddCourse
        // 
        btnAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddCourse.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnAddCourse.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddCourse.ForeColor = System.Drawing.Color.White;
        btnAddCourse.Location = new System.Drawing.Point(990, 20);
        btnAddCourse.Name = "btnAddCourse";
        btnAddCourse.Size = new System.Drawing.Size(146, 36);
        btnAddCourse.TabIndex = 3;
        btnAddCourse.Text = "+ Thêm khóa học";
        btnAddCourse.UseVisualStyleBackColor = false;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(560, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Khóa học quy định nội dung, thời lượng và học phí; không phải một lớp học cụ thể.";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(360, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Khóa học · Chương trình đào tạo";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(262, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Khóa học / Khóa học · Chương trình đào tạo";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(pnlBottomCards);
        pnlBody.Controls.Add(cardCourseList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardCourseList
        // 
        cardCourseList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardCourseList.BackColor = System.Drawing.Color.White;
        cardCourseList.Controls.Add(lblPagingNav);
        cardCourseList.Controls.Add(lblPagingInfo);
        cardCourseList.Controls.Add(dgvCourses);
        cardCourseList.Controls.Add(cboLevelFilter);
        cardCourseList.Controls.Add(cboStatusFilter);
        cardCourseList.Controls.Add(txtSearchCourse);
        cardCourseList.Controls.Add(lblCourseListTitle);
        cardCourseList.Location = new System.Drawing.Point(24, 16);
        cardCourseList.Name = "cardCourseList";
        cardCourseList.Padding = new System.Windows.Forms.Padding(20);
        cardCourseList.Size = new System.Drawing.Size(1112, 360);
        cardCourseList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(970, 325);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(122, 15);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPagingInfo.Location = new System.Drawing.Point(20, 325);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(130, 15);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 5 chương trình";
        // 
        // dgvCourses
        // 
        dgvCourses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCourses.Location = new System.Drawing.Point(20, 65);
        dgvCourses.Name = "dgvCourses";
        dgvCourses.Size = new System.Drawing.Size(1072, 245);
        dgvCourses.TabIndex = 4;
        // 
        // cboLevelFilter
        // 
        cboLevelFilter.Location = new System.Drawing.Point(490, 18);
        cboLevelFilter.Name = "cboLevelFilter";
        cboLevelFilter.Size = new System.Drawing.Size(160, 35);
        cboLevelFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(320, 18);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(160, 35);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearchCourse
        // 
        txtSearchCourse.Location = new System.Drawing.Point(20, 18);
        txtSearchCourse.Name = "txtSearchCourse";
        txtSearchCourse.Placeholder = "🔍  Tìm mã hoặc tên khóa học...";
        txtSearchCourse.Size = new System.Drawing.Size(290, 35);
        txtSearchCourse.TabIndex = 1;
        // 
        // lblCourseListTitle
        // 
        lblCourseListTitle.AutoSize = true;
        lblCourseListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCourseListTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseListTitle.Location = new System.Drawing.Point(20, 24);
        lblCourseListTitle.Name = "lblCourseListTitle";
        lblCourseListTitle.Size = new System.Drawing.Size(0, 21);
        lblCourseListTitle.TabIndex = 0;
        // 
        // pnlBottomCards
        // 
        pnlBottomCards.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pnlBottomCards.Controls.Add(cardClassInfo);
        pnlBottomCards.Controls.Add(cardCourseInfo);
        pnlBottomCards.Location = new System.Drawing.Point(24, 390);
        pnlBottomCards.Name = "pnlBottomCards";
        pnlBottomCards.Size = new System.Drawing.Size(1112, 230);
        pnlBottomCards.TabIndex = 1;
        // 
        // cardClassInfo
        // 
        cardClassInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardClassInfo.BackColor = System.Drawing.Color.White;
        cardClassInfo.Controls.Add(btnViewRelatedClasses);
        cardClassInfo.Controls.Add(lblClassHandoverVal);
        cardClassInfo.Controls.Add(lblClassHandoverKey);
        cardClassInfo.Controls.Add(lblClassMgmtVal);
        cardClassInfo.Controls.Add(lblClassMgmtKey);
        cardClassInfo.Controls.Add(lblClassExampleVal);
        cardClassInfo.Controls.Add(lblClassExampleKey);
        cardClassInfo.Controls.Add(lblClassCardTitle);
        cardClassInfo.Location = new System.Drawing.Point(570, 0);
        cardClassInfo.Name = "cardClassInfo";
        cardClassInfo.Padding = new System.Windows.Forms.Padding(20);
        cardClassInfo.Size = new System.Drawing.Size(542, 220);
        cardClassInfo.TabIndex = 1;
        // 
        // btnViewRelatedClasses
        // 
        btnViewRelatedClasses.BackColor = System.Drawing.Color.White;
        btnViewRelatedClasses.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnViewRelatedClasses.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewRelatedClasses.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnViewRelatedClasses.Location = new System.Drawing.Point(20, 160);
        btnViewRelatedClasses.Name = "btnViewRelatedClasses";
        btnViewRelatedClasses.Size = new System.Drawing.Size(160, 36);
        btnViewRelatedClasses.TabIndex = 7;
        btnViewRelatedClasses.Text = "Xem lớp liên quan";
        btnViewRelatedClasses.UseVisualStyleBackColor = false;
        // 
        // lblClassHandoverVal
        // 
        lblClassHandoverVal.AutoSize = true;
        lblClassHandoverVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassHandoverVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblClassHandoverVal.Location = new System.Drawing.Point(120, 115);
        lblClassHandoverVal.Name = "lblClassHandoverVal";
        lblClassHandoverVal.Size = new System.Drawing.Size(262, 15);
        lblClassHandoverVal.TabIndex = 6;
        lblClassHandoverVal.Text = "Mở Lớp học → tạo lớp theo chương trình";
        // 
        // lblClassHandoverKey
        // 
        lblClassHandoverKey.AutoSize = true;
        lblClassHandoverKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassHandoverKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblClassHandoverKey.Location = new System.Drawing.Point(20, 115);
        lblClassHandoverKey.Name = "lblClassHandoverKey";
        lblClassHandoverKey.Size = new System.Drawing.Size(89, 15);
        lblClassHandoverKey.TabIndex = 5;
        lblClassHandoverKey.Text = "Điểm bàn giao";
        // 
        // lblClassMgmtVal
        // 
        lblClassMgmtVal.AutoSize = true;
        lblClassMgmtVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassMgmtVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblClassMgmtVal.Location = new System.Drawing.Point(120, 80);
        lblClassMgmtVal.Name = "lblClassMgmtVal";
        lblClassMgmtVal.Size = new System.Drawing.Size(273, 15);
        lblClassMgmtVal.TabIndex = 4;
        lblClassMgmtVal.Text = "Giáo viên · lịch · phòng · sĩ số · học viên";
        // 
        // lblClassMgmtKey
        // 
        lblClassMgmtKey.AutoSize = true;
        lblClassMgmtKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassMgmtKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblClassMgmtKey.Location = new System.Drawing.Point(20, 80);
        lblClassMgmtKey.Name = "lblClassMgmtKey";
        lblClassMgmtKey.Size = new System.Drawing.Size(51, 15);
        lblClassMgmtKey.TabIndex = 3;
        lblClassMgmtKey.Text = "Quản lý";
        // 
        // lblClassExampleVal
        // 
        lblClassExampleVal.AutoSize = true;
        lblClassExampleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblClassExampleVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblClassExampleVal.Location = new System.Drawing.Point(120, 48);
        lblClassExampleVal.Name = "lblClassExampleVal";
        lblClassExampleVal.Size = new System.Drawing.Size(155, 17);
        lblClassExampleVal.TabIndex = 2;
        lblClassExampleVal.Text = "IELTS-F01 / IELTS-F02";
        // 
        // lblClassExampleKey
        // 
        lblClassExampleKey.AutoSize = true;
        lblClassExampleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassExampleKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblClassExampleKey.Location = new System.Drawing.Point(20, 48);
        lblClassExampleKey.Name = "lblClassExampleKey";
        lblClassExampleKey.Size = new System.Drawing.Size(35, 15);
        lblClassExampleKey.TabIndex = 1;
        lblClassExampleKey.Text = "Ví dụ";
        // 
        // lblClassCardTitle
        // 
        lblClassCardTitle.AutoSize = true;
        lblClassCardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblClassCardTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblClassCardTitle.Location = new System.Drawing.Point(20, 16);
        lblClassCardTitle.Name = "lblClassCardTitle";
        lblClassCardTitle.Size = new System.Drawing.Size(81, 25);
        lblClassCardTitle.TabIndex = 0;
        lblClassCardTitle.Text = "Lớp học";
        // 
        // cardCourseInfo
        // 
        cardCourseInfo.BackColor = System.Drawing.Color.White;
        cardCourseInfo.Controls.Add(btnOpenCourseDetail);
        cardCourseInfo.Controls.Add(lblCourseChangeVal);
        cardCourseInfo.Controls.Add(lblCourseChangeKey);
        cardCourseInfo.Controls.Add(lblCourseMgmtVal);
        cardCourseInfo.Controls.Add(lblCourseMgmtKey);
        cardCourseInfo.Controls.Add(lblCourseExampleVal);
        cardCourseInfo.Controls.Add(lblCourseExampleKey);
        cardCourseInfo.Controls.Add(lblCourseCardTitle);
        cardCourseInfo.Location = new System.Drawing.Point(0, 0);
        cardCourseInfo.Name = "cardCourseInfo";
        cardCourseInfo.Padding = new System.Windows.Forms.Padding(20);
        cardCourseInfo.Size = new System.Drawing.Size(542, 220);
        cardCourseInfo.TabIndex = 0;
        // 
        // btnOpenCourseDetail
        // 
        btnOpenCourseDetail.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnOpenCourseDetail.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnOpenCourseDetail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenCourseDetail.ForeColor = System.Drawing.Color.White;
        btnOpenCourseDetail.Location = new System.Drawing.Point(20, 160);
        btnOpenCourseDetail.Name = "btnOpenCourseDetail";
        btnOpenCourseDetail.Size = new System.Drawing.Size(185, 36);
        btnOpenCourseDetail.TabIndex = 7;
        btnOpenCourseDetail.Text = "Mở chi tiết chương trình";
        btnOpenCourseDetail.UseVisualStyleBackColor = false;
        // 
        // lblCourseChangeVal
        // 
        lblCourseChangeVal.AutoSize = true;
        lblCourseChangeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseChangeVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseChangeVal.Location = new System.Drawing.Point(120, 115);
        lblCourseChangeVal.Name = "lblCourseChangeVal";
        lblCourseChangeVal.Size = new System.Drawing.Size(288, 15);
        lblCourseChangeVal.TabIndex = 6;
        lblCourseChangeVal.Text = "Chỉ áp dụng cho lớp mới, không đổi phiếu thu cũ";
        // 
        // lblCourseChangeKey
        // 
        lblCourseChangeKey.AutoSize = true;
        lblCourseChangeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseChangeKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCourseChangeKey.Location = new System.Drawing.Point(20, 115);
        lblCourseChangeKey.Name = "lblCourseChangeKey";
        lblCourseChangeKey.Size = new System.Drawing.Size(53, 15);
        lblCourseChangeKey.TabIndex = 5;
        lblCourseChangeKey.Text = "Thay đổi";
        // 
        // lblCourseMgmtVal
        // 
        lblCourseMgmtVal.AutoSize = true;
        lblCourseMgmtVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseMgmtVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseMgmtVal.Location = new System.Drawing.Point(120, 80);
        lblCourseMgmtVal.Name = "lblCourseMgmtVal";
        lblCourseMgmtVal.Size = new System.Drawing.Size(285, 15);
        lblCourseMgmtVal.TabIndex = 4;
        lblCourseMgmtVal.Text = "Mục tiêu · giáo trình · học phí · quy tắc";
        // 
        // lblCourseMgmtKey
        // 
        lblCourseMgmtKey.AutoSize = true;
        lblCourseMgmtKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseMgmtKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCourseMgmtKey.Location = new System.Drawing.Point(20, 80);
        lblCourseMgmtKey.Name = "lblCourseMgmtKey";
        lblCourseMgmtKey.Size = new System.Drawing.Size(51, 15);
        lblCourseMgmtKey.TabIndex = 3;
        lblCourseMgmtKey.Text = "Quản lý";
        // 
        // lblCourseExampleVal
        // 
        lblCourseExampleVal.AutoSize = true;
        lblCourseExampleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCourseExampleVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseExampleVal.Location = new System.Drawing.Point(120, 48);
        lblCourseExampleVal.Name = "lblCourseExampleVal";
        lblCourseExampleVal.Size = new System.Drawing.Size(117, 17);
        lblCourseExampleVal.TabIndex = 2;
        lblCourseExampleVal.Text = "IELTS Foundation";
        // 
        // lblCourseExampleKey
        // 
        lblCourseExampleKey.AutoSize = true;
        lblCourseExampleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseExampleKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCourseExampleKey.Location = new System.Drawing.Point(20, 48);
        lblCourseExampleKey.Name = "lblCourseExampleKey";
        lblCourseExampleKey.Size = new System.Drawing.Size(35, 15);
        lblCourseExampleKey.TabIndex = 1;
        lblCourseExampleKey.Text = "Ví dụ";
        // 
        // lblCourseCardTitle
        // 
        lblCourseCardTitle.AutoSize = true;
        lblCourseCardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblCourseCardTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCourseCardTitle.Location = new System.Drawing.Point(20, 16);
        lblCourseCardTitle.Name = "lblCourseCardTitle";
        lblCourseCardTitle.Size = new System.Drawing.Size(91, 25);
        lblCourseCardTitle.TabIndex = 0;
        lblCourseCardTitle.Text = "Khóa học";
        // 
        // CourseManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "CourseManagementView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCourseList.ResumeLayout(false);
        cardCourseList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
        pnlBottomCards.ResumeLayout(false);
        cardClassInfo.ResumeLayout(false);
        cardClassInfo.PerformLayout();
        cardCourseInfo.ResumeLayout(false);
        cardCourseInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddCourse;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardCourseList;
    private System.Windows.Forms.Label lblCourseListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchCourse;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboLevelFilter;
    private ECMS.UI.Controls.AppDataGrid dgvCourses;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private System.Windows.Forms.Panel pnlBottomCards;
    private ECMS.UI.Controls.AppCard cardCourseInfo;
    private System.Windows.Forms.Label lblCourseCardTitle;
    private System.Windows.Forms.Label lblCourseExampleKey;
    private System.Windows.Forms.Label lblCourseExampleVal;
    private System.Windows.Forms.Label lblCourseMgmtKey;
    private System.Windows.Forms.Label lblCourseMgmtVal;
    private System.Windows.Forms.Label lblCourseChangeKey;
    private System.Windows.Forms.Label lblCourseChangeVal;
    private ECMS.UI.Controls.AppButton btnOpenCourseDetail;
    private ECMS.UI.Controls.AppCard cardClassInfo;
    private System.Windows.Forms.Label lblClassCardTitle;
    private System.Windows.Forms.Label lblClassExampleKey;
    private System.Windows.Forms.Label lblClassExampleVal;
    private System.Windows.Forms.Label lblClassMgmtKey;
    private System.Windows.Forms.Label lblClassMgmtVal;
    private System.Windows.Forms.Label lblClassHandoverKey;
    private System.Windows.Forms.Label lblClassHandoverVal;
    private ECMS.UI.Controls.AppButton btnViewRelatedClasses;
}
