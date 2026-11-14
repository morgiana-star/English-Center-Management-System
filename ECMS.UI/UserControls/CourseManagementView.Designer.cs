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
        btnAddCourse = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
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
        cardCourseList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvCourses = new ECMS.UI.Controls.AppDataGrid();
        cboLevelFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchCourse = new ECMS.UI.Controls.AppTextBox();
        lblCourseListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlBottomCards.SuspendLayout();
        cardClassInfo.SuspendLayout();
        cardCourseInfo.SuspendLayout();
        cardCourseList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddCourse);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddCourse
        // 
        btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnAddCourse.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddCourse.CornerRadius = 5;
        btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddCourse.ForeColor = System.Drawing.Color.White;
        btnAddCourse.Location = new System.Drawing.Point(990, 20);
        btnAddCourse.Name = "btnAddCourse";
        btnAddCourse.Size = new System.Drawing.Size(146, 36);
        btnAddCourse.TabIndex = 3;
        btnAddCourse.Text = "+ Thêm khóa học";
        btnAddCourse.UseVisualStyleBackColor = false;
        btnAddCourse.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(433, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Khóa học · Chương trình đào tạo";
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
        // pnlBottomCards
        // 
        pnlBottomCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlBottomCards.Controls.Add(cardClassInfo);
        pnlBottomCards.Controls.Add(cardCourseInfo);
        pnlBottomCards.Location = new System.Drawing.Point(24, 428);
        pnlBottomCards.Name = "pnlBottomCards";
        pnlBottomCards.Size = new System.Drawing.Size(1112, 230);
        pnlBottomCards.TabIndex = 1;
        // 
        // cardClassInfo
        // 
        cardClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardClassInfo.BackColor = System.Drawing.Color.White;
        cardClassInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassInfo.BorderWidth = 1;
        cardClassInfo.Controls.Add(btnViewRelatedClasses);
        cardClassInfo.Controls.Add(lblClassHandoverVal);
        cardClassInfo.Controls.Add(lblClassHandoverKey);
        cardClassInfo.Controls.Add(lblClassMgmtVal);
        cardClassInfo.Controls.Add(lblClassMgmtKey);
        cardClassInfo.Controls.Add(lblClassExampleVal);
        cardClassInfo.Controls.Add(lblClassExampleKey);
        cardClassInfo.Controls.Add(lblClassCardTitle);
        cardClassInfo.CornerRadius = 6;
        cardClassInfo.Location = new System.Drawing.Point(570, 0);
        cardClassInfo.Name = "cardClassInfo";
        cardClassInfo.Padding = new System.Windows.Forms.Padding(20);
        cardClassInfo.Size = new System.Drawing.Size(542, 220);
        cardClassInfo.TabIndex = 1;
        // 
        // btnViewRelatedClasses
        // 
        btnViewRelatedClasses.BackColor = System.Drawing.Color.White;
        btnViewRelatedClasses.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnViewRelatedClasses.CornerRadius = 5;
        btnViewRelatedClasses.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewRelatedClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewRelatedClasses.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnViewRelatedClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnViewRelatedClasses.Location = new System.Drawing.Point(20, 160);
        btnViewRelatedClasses.Name = "btnViewRelatedClasses";
        btnViewRelatedClasses.Size = new System.Drawing.Size(160, 36);
        btnViewRelatedClasses.TabIndex = 7;
        btnViewRelatedClasses.Text = "Xem lớp liên quan";
        btnViewRelatedClasses.UseVisualStyleBackColor = false;
        btnViewRelatedClasses.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblClassHandoverVal
        // 
        lblClassHandoverVal.AutoSize = true;
        lblClassHandoverVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassHandoverVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassHandoverVal.Location = new System.Drawing.Point(120, 115);
        lblClassHandoverVal.Name = "lblClassHandoverVal";
        lblClassHandoverVal.Size = new System.Drawing.Size(279, 20);
        lblClassHandoverVal.TabIndex = 6;
        lblClassHandoverVal.Text = "Mở Lớp học → tạo lớp theo chương trình";
        // 
        // lblClassHandoverKey
        // 
        lblClassHandoverKey.AutoSize = true;
        lblClassHandoverKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassHandoverKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblClassHandoverKey.Location = new System.Drawing.Point(20, 115);
        lblClassHandoverKey.Name = "lblClassHandoverKey";
        lblClassHandoverKey.Size = new System.Drawing.Size(108, 20);
        lblClassHandoverKey.TabIndex = 5;
        lblClassHandoverKey.Text = "Điểm bàn giao";
        // 
        // lblClassMgmtVal
        // 
        lblClassMgmtVal.AutoSize = true;
        lblClassMgmtVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassMgmtVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassMgmtVal.Location = new System.Drawing.Point(120, 80);
        lblClassMgmtVal.Name = "lblClassMgmtVal";
        lblClassMgmtVal.Size = new System.Drawing.Size(265, 20);
        lblClassMgmtVal.TabIndex = 4;
        lblClassMgmtVal.Text = "Giáo viên · lịch · phòng · sĩ số · học viên";
        // 
        // lblClassMgmtKey
        // 
        lblClassMgmtKey.AutoSize = true;
        lblClassMgmtKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassMgmtKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblClassMgmtKey.Location = new System.Drawing.Point(20, 80);
        lblClassMgmtKey.Name = "lblClassMgmtKey";
        lblClassMgmtKey.Size = new System.Drawing.Size(59, 20);
        lblClassMgmtKey.TabIndex = 3;
        lblClassMgmtKey.Text = "Quản lý";
        // 
        // lblClassExampleVal
        // 
        lblClassExampleVal.AutoSize = true;
        lblClassExampleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblClassExampleVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassExampleVal.Location = new System.Drawing.Point(120, 48);
        lblClassExampleVal.Name = "lblClassExampleVal";
        lblClassExampleVal.Size = new System.Drawing.Size(167, 21);
        lblClassExampleVal.TabIndex = 2;
        lblClassExampleVal.Text = "IELTS-F01 / IELTS-F02";
        // 
        // lblClassExampleKey
        // 
        lblClassExampleKey.AutoSize = true;
        lblClassExampleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblClassExampleKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblClassExampleKey.Location = new System.Drawing.Point(20, 48);
        lblClassExampleKey.Name = "lblClassExampleKey";
        lblClassExampleKey.Size = new System.Drawing.Size(43, 20);
        lblClassExampleKey.TabIndex = 1;
        lblClassExampleKey.Text = "Ví dụ";
        // 
        // lblClassCardTitle
        // 
        lblClassCardTitle.AutoSize = true;
        lblClassCardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblClassCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblClassCardTitle.Location = new System.Drawing.Point(20, 16);
        lblClassCardTitle.Name = "lblClassCardTitle";
        lblClassCardTitle.Size = new System.Drawing.Size(95, 30);
        lblClassCardTitle.TabIndex = 0;
        lblClassCardTitle.Text = "Lớp học";
        // 
        // cardCourseInfo
        // 
        cardCourseInfo.BackColor = System.Drawing.Color.White;
        cardCourseInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCourseInfo.BorderWidth = 1;
        cardCourseInfo.Controls.Add(btnOpenCourseDetail);
        cardCourseInfo.Controls.Add(lblCourseChangeVal);
        cardCourseInfo.Controls.Add(lblCourseChangeKey);
        cardCourseInfo.Controls.Add(lblCourseMgmtVal);
        cardCourseInfo.Controls.Add(lblCourseMgmtKey);
        cardCourseInfo.Controls.Add(lblCourseExampleVal);
        cardCourseInfo.Controls.Add(lblCourseExampleKey);
        cardCourseInfo.Controls.Add(lblCourseCardTitle);
        cardCourseInfo.CornerRadius = 6;
        cardCourseInfo.Location = new System.Drawing.Point(0, 0);
        cardCourseInfo.Name = "cardCourseInfo";
        cardCourseInfo.Padding = new System.Windows.Forms.Padding(20);
        cardCourseInfo.Size = new System.Drawing.Size(542, 220);
        cardCourseInfo.TabIndex = 0;
        // 
        // btnOpenCourseDetail
        // 
        btnOpenCourseDetail.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnOpenCourseDetail.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnOpenCourseDetail.CornerRadius = 5;
        btnOpenCourseDetail.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenCourseDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenCourseDetail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenCourseDetail.ForeColor = System.Drawing.Color.White;
        btnOpenCourseDetail.Location = new System.Drawing.Point(20, 160);
        btnOpenCourseDetail.Name = "btnOpenCourseDetail";
        btnOpenCourseDetail.Size = new System.Drawing.Size(185, 36);
        btnOpenCourseDetail.TabIndex = 7;
        btnOpenCourseDetail.Text = "Mở chi tiết chương trình";
        btnOpenCourseDetail.UseVisualStyleBackColor = false;
        btnOpenCourseDetail.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblCourseChangeVal
        // 
        lblCourseChangeVal.AutoSize = true;
        lblCourseChangeVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseChangeVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCourseChangeVal.Location = new System.Drawing.Point(120, 115);
        lblCourseChangeVal.Name = "lblCourseChangeVal";
        lblCourseChangeVal.Size = new System.Drawing.Size(332, 20);
        lblCourseChangeVal.TabIndex = 6;
        lblCourseChangeVal.Text = "Chỉ áp dụng cho lớp mới, không đổi phiếu thu cũ";
        // 
        // lblCourseChangeKey
        // 
        lblCourseChangeKey.AutoSize = true;
        lblCourseChangeKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseChangeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCourseChangeKey.Location = new System.Drawing.Point(20, 115);
        lblCourseChangeKey.Name = "lblCourseChangeKey";
        lblCourseChangeKey.Size = new System.Drawing.Size(66, 20);
        lblCourseChangeKey.TabIndex = 5;
        lblCourseChangeKey.Text = "Thay đổi";
        // 
        // lblCourseMgmtVal
        // 
        lblCourseMgmtVal.AutoSize = true;
        lblCourseMgmtVal.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseMgmtVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCourseMgmtVal.Location = new System.Drawing.Point(120, 80);
        lblCourseMgmtVal.Name = "lblCourseMgmtVal";
        lblCourseMgmtVal.Size = new System.Drawing.Size(260, 20);
        lblCourseMgmtVal.TabIndex = 4;
        lblCourseMgmtVal.Text = "Mục tiêu · giáo trình · học phí · quy tắc";
        // 
        // lblCourseMgmtKey
        // 
        lblCourseMgmtKey.AutoSize = true;
        lblCourseMgmtKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseMgmtKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCourseMgmtKey.Location = new System.Drawing.Point(20, 80);
        lblCourseMgmtKey.Name = "lblCourseMgmtKey";
        lblCourseMgmtKey.Size = new System.Drawing.Size(59, 20);
        lblCourseMgmtKey.TabIndex = 3;
        lblCourseMgmtKey.Text = "Quản lý";
        // 
        // lblCourseExampleVal
        // 
        lblCourseExampleVal.AutoSize = true;
        lblCourseExampleVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblCourseExampleVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCourseExampleVal.Location = new System.Drawing.Point(120, 48);
        lblCourseExampleVal.Name = "lblCourseExampleVal";
        lblCourseExampleVal.Size = new System.Drawing.Size(141, 21);
        lblCourseExampleVal.TabIndex = 2;
        lblCourseExampleVal.Text = "IELTS Foundation";
        // 
        // lblCourseExampleKey
        // 
        lblCourseExampleKey.AutoSize = true;
        lblCourseExampleKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCourseExampleKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCourseExampleKey.Location = new System.Drawing.Point(20, 48);
        lblCourseExampleKey.Name = "lblCourseExampleKey";
        lblCourseExampleKey.Size = new System.Drawing.Size(43, 20);
        lblCourseExampleKey.TabIndex = 1;
        lblCourseExampleKey.Text = "Ví dụ";
        // 
        // lblCourseCardTitle
        // 
        lblCourseCardTitle.AutoSize = true;
        lblCourseCardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblCourseCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCourseCardTitle.Location = new System.Drawing.Point(20, 16);
        lblCourseCardTitle.Name = "lblCourseCardTitle";
        lblCourseCardTitle.Size = new System.Drawing.Size(108, 30);
        lblCourseCardTitle.TabIndex = 0;
        lblCourseCardTitle.Text = "Khóa học";
        // 
        // cardCourseList
        // 
        cardCourseList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardCourseList.BackColor = System.Drawing.Color.White;
        cardCourseList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCourseList.BorderWidth = 1;
        cardCourseList.Controls.Add(lblPagingNav);
        cardCourseList.Controls.Add(lblPagingInfo);
        cardCourseList.Controls.Add(dgvCourses);
        cardCourseList.Controls.Add(cboLevelFilter);
        cardCourseList.Controls.Add(cboStatusFilter);
        cardCourseList.Controls.Add(txtSearchCourse);
        cardCourseList.Controls.Add(lblCourseListTitle);
        cardCourseList.CornerRadius = 6;
        cardCourseList.Location = new System.Drawing.Point(24, 16);
        cardCourseList.Name = "cardCourseList";
        cardCourseList.Padding = new System.Windows.Forms.Padding(20);
        cardCourseList.Size = new System.Drawing.Size(1112, 394);
        cardCourseList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblPagingNav.Location = new System.Drawing.Point(934, 359);
        lblPagingNav.Name = "lblPagingNav";
        lblPagingNav.Size = new System.Drawing.Size(158, 20);
        lblPagingNav.TabIndex = 6;
        lblPagingNav.Text = "‹ Trước   [1]   2   Sau ›";
        // 
        // lblPagingInfo
        // 
        lblPagingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblPagingInfo.AutoSize = true;
        lblPagingInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPagingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPagingInfo.Location = new System.Drawing.Point(20, 359);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(143, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 5 chương trình";
        // 
        // dgvCourses
        // 
        dgvCourses.AllowUserToAddRows = false;
        dgvCourses.AllowUserToDeleteRows = false;
        dgvCourses.AllowUserToResizeColumns = false;
        dgvCourses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCourses.BackgroundColor = System.Drawing.Color.White;
        dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvCourses.EnableHeadersVisualStyles = false;
        dgvCourses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvCourses.Location = new System.Drawing.Point(20, 65);
        dgvCourses.MultiSelect = false;
        dgvCourses.Name = "dgvCourses";
        dgvCourses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvCourses.RowHeadersVisible = false;
        dgvCourses.RowHeadersWidth = 51;
        dgvCourses.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCourses.Size = new System.Drawing.Size(1072, 291);
        dgvCourses.TabIndex = 4;
        // 
        // cboLevelFilter
        // 
        cboLevelFilter.BackColor = System.Drawing.Color.Transparent;
        cboLevelFilter.CornerRadius = 5;
        cboLevelFilter.DataSource = null;
        cboLevelFilter.DisplayMember = "";
        cboLevelFilter.Location = new System.Drawing.Point(490, 18);
        cboLevelFilter.Name = "cboLevelFilter";
        cboLevelFilter.SelectedIndex = -1;
        cboLevelFilter.SelectedItem = null;
        cboLevelFilter.SelectedValue = null;
        cboLevelFilter.Size = new System.Drawing.Size(160, 35);
        cboLevelFilter.TabIndex = 3;
        cboLevelFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(320, 18);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(160, 35);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchCourse
        // 
        txtSearchCourse.BackColor = System.Drawing.Color.Transparent;
        txtSearchCourse.CornerRadius = 5;
        txtSearchCourse.ErrorMessage = "";
        txtSearchCourse.HasError = false;
        txtSearchCourse.Location = new System.Drawing.Point(20, 18);
        txtSearchCourse.Name = "txtSearchCourse";
        txtSearchCourse.Placeholder = "🔍  Tìm mã hoặc tên khóa học...";
        txtSearchCourse.ReadOnly = false;
        txtSearchCourse.Size = new System.Drawing.Size(290, 35);
        txtSearchCourse.TabIndex = 1;
        txtSearchCourse.UseSystemPasswordChar = false;
        // 
        // lblCourseListTitle
        // 
        lblCourseListTitle.AutoSize = true;
        lblCourseListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblCourseListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblCourseListTitle.Location = new System.Drawing.Point(20, 24);
        lblCourseListTitle.Name = "lblCourseListTitle";
        lblCourseListTitle.Size = new System.Drawing.Size(0, 28);
        lblCourseListTitle.TabIndex = 0;
        // 
        // CourseManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlBottomCards.ResumeLayout(false);
        cardClassInfo.ResumeLayout(false);
        cardClassInfo.PerformLayout();
        cardCourseInfo.ResumeLayout(false);
        cardCourseInfo.PerformLayout();
        cardCourseList.ResumeLayout(false);
        cardCourseList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddCourse;
    private System.Windows.Forms.Label lblTitle;
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
