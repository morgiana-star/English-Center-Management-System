namespace ECMS.UI.UserControls;

partial class TeacherManagementView
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
        btnAddTeacher = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardTeacherDetail = new ECMS.UI.Controls.AppCard();
        btnSaveAssign = new ECMS.UI.Controls.AppButton();
        btnCancelAssign = new ECMS.UI.Controls.AppButton();
        dtpEffectiveDate = new System.Windows.Forms.DateTimePicker();
        lblEffectiveDate = new System.Windows.Forms.Label();
        cboAssignClass = new ECMS.UI.Controls.AppComboBox();
        lblAssignClass = new System.Windows.Forms.Label();
        dgvSchedule = new ECMS.UI.Controls.AppDataGrid();
        lblCurrentClassVal = new System.Windows.Forms.Label();
        lblCurrentClassKey = new System.Windows.Forms.Label();
        lblStatusVal = new System.Windows.Forms.Label();
        lblStatusKey = new System.Windows.Forms.Label();
        lblCertVal = new System.Windows.Forms.Label();
        lblCertKey = new System.Windows.Forms.Label();
        lblPhoneVal = new System.Windows.Forms.Label();
        lblPhoneKey = new System.Windows.Forms.Label();
        pnlDetailTabs = new System.Windows.Forms.Panel();
        lblTabAssign = new System.Windows.Forms.Label();
        lblTabAvailability = new System.Windows.Forms.Label();
        lblTabProfile = new System.Windows.Forms.Label();
        lblTeacherDetailTitle = new System.Windows.Forms.Label();
        cardTeacherList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvTeachers = new ECMS.UI.Controls.AppDataGrid();
        cboSpecialtyFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchTeacher = new ECMS.UI.Controls.AppTextBox();
        lblTeacherListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardTeacherDetail.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
        pnlDetailTabs.SuspendLayout();
        cardTeacherList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddTeacher);
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
        // btnAddTeacher
        // 
        btnAddTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnAddTeacher.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddTeacher.ForeColor = System.Drawing.Color.White;
        btnAddTeacher.Location = new System.Drawing.Point(996, 20);
        btnAddTeacher.Name = "btnAddTeacher";
        btnAddTeacher.Size = new System.Drawing.Size(140, 36);
        btnAddTeacher.TabIndex = 3;
        btnAddTeacher.Text = "Thêm giáo viên";
        btnAddTeacher.UseVisualStyleBackColor = false;
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
        lblTitle.Size = new System.Drawing.Size(107, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Giáo viên";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(145, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Giáo viên / Giáo viên";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardTeacherDetail);
        pnlBody.Controls.Add(cardTeacherList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardTeacherDetail
        // 
        cardTeacherDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardTeacherDetail.BackColor = System.Drawing.Color.White;
        cardTeacherDetail.Controls.Add(btnSaveAssign);
        cardTeacherDetail.Controls.Add(btnCancelAssign);
        cardTeacherDetail.Controls.Add(dtpEffectiveDate);
        cardTeacherDetail.Controls.Add(lblEffectiveDate);
        cardTeacherDetail.Controls.Add(cboAssignClass);
        cardTeacherDetail.Controls.Add(lblAssignClass);
        cardTeacherDetail.Controls.Add(dgvSchedule);
        cardTeacherDetail.Controls.Add(lblCurrentClassVal);
        cardTeacherDetail.Controls.Add(lblCurrentClassKey);
        cardTeacherDetail.Controls.Add(lblStatusVal);
        cardTeacherDetail.Controls.Add(lblStatusKey);
        cardTeacherDetail.Controls.Add(lblCertVal);
        cardTeacherDetail.Controls.Add(lblCertKey);
        cardTeacherDetail.Controls.Add(lblPhoneVal);
        cardTeacherDetail.Controls.Add(lblPhoneKey);
        cardTeacherDetail.Controls.Add(pnlDetailTabs);
        cardTeacherDetail.Controls.Add(lblTeacherDetailTitle);
        cardTeacherDetail.Location = new System.Drawing.Point(740, 16);
        cardTeacherDetail.Name = "cardTeacherDetail";
        cardTeacherDetail.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherDetail.Size = new System.Drawing.Size(396, 615);
        cardTeacherDetail.TabIndex = 1;
        // 
        // btnSaveAssign
        // 
        btnSaveAssign.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSaveAssign.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnSaveAssign.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnSaveAssign.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAssign.ForeColor = System.Drawing.Color.White;
        btnSaveAssign.Location = new System.Drawing.Point(260, 560);
        btnSaveAssign.Name = "btnSaveAssign";
        btnSaveAssign.Size = new System.Drawing.Size(116, 36);
        btnSaveAssign.TabIndex = 16;
        btnSaveAssign.Text = "Lưu phân công";
        btnSaveAssign.UseVisualStyleBackColor = false;
        // 
        // btnCancelAssign
        // 
        btnCancelAssign.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelAssign.BackColor = System.Drawing.Color.White;
        btnCancelAssign.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancelAssign.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelAssign.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancelAssign.Location = new System.Drawing.Point(185, 560);
        btnCancelAssign.Name = "btnCancelAssign";
        btnCancelAssign.Size = new System.Drawing.Size(65, 36);
        btnCancelAssign.TabIndex = 15;
        btnCancelAssign.Text = "Hủy";
        btnCancelAssign.UseVisualStyleBackColor = false;
        // 
        // dtpEffectiveDate
        // 
        dtpEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        dtpEffectiveDate.CustomFormat = "dd/MM/yyyy";
        dtpEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEffectiveDate.Location = new System.Drawing.Point(205, 508);
        dtpEffectiveDate.Name = "dtpEffectiveDate";
        dtpEffectiveDate.Size = new System.Drawing.Size(171, 24);
        dtpEffectiveDate.TabIndex = 14;
        // 
        // lblEffectiveDate
        // 
        lblEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblEffectiveDate.AutoSize = true;
        lblEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEffectiveDate.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblEffectiveDate.Location = new System.Drawing.Point(205, 488);
        lblEffectiveDate.Name = "lblEffectiveDate";
        lblEffectiveDate.Size = new System.Drawing.Size(51, 15);
        lblEffectiveDate.TabIndex = 13;
        lblEffectiveDate.Text = "Từ ngày";
        // 
        // cboAssignClass
        // 
        cboAssignClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        cboAssignClass.Location = new System.Drawing.Point(20, 505);
        cboAssignClass.Name = "cboAssignClass";
        cboAssignClass.Size = new System.Drawing.Size(170, 35);
        cboAssignClass.TabIndex = 12;
        // 
        // lblAssignClass
        // 
        lblAssignClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblAssignClass.AutoSize = true;
        lblAssignClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAssignClass.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblAssignClass.Location = new System.Drawing.Point(20, 488);
        lblAssignClass.Name = "lblAssignClass";
        lblAssignClass.Size = new System.Drawing.Size(89, 15);
        lblAssignClass.TabIndex = 11;
        lblAssignClass.Text = "Phân công lớp";
        // 
        // dgvSchedule
        // 
        dgvSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSchedule.Location = new System.Drawing.Point(20, 245);
        dgvSchedule.Name = "dgvSchedule";
        dgvSchedule.Size = new System.Drawing.Size(356, 225);
        dgvSchedule.TabIndex = 10;
        // 
        // lblCurrentClassVal
        // 
        lblCurrentClassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCurrentClassVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCurrentClassVal.Location = new System.Drawing.Point(120, 202);
        lblCurrentClassVal.Name = "lblCurrentClassVal";
        lblCurrentClassVal.Size = new System.Drawing.Size(256, 18);
        lblCurrentClassVal.TabIndex = 9;
        lblCurrentClassVal.Text = "IELTS-F01 · 18 học viên";
        lblCurrentClassVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblCurrentClassKey
        // 
        lblCurrentClassKey.AutoSize = true;
        lblCurrentClassKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCurrentClassKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCurrentClassKey.Location = new System.Drawing.Point(20, 204);
        lblCurrentClassKey.Name = "lblCurrentClassKey";
        lblCurrentClassKey.Size = new System.Drawing.Size(73, 15);
        lblCurrentClassKey.TabIndex = 8;
        lblCurrentClassKey.Text = "Lớp hiện tại";
        // 
        // lblStatusVal
        // 
        lblStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatusVal.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
        lblStatusVal.Location = new System.Drawing.Point(120, 168);
        lblStatusVal.Name = "lblStatusVal";
        lblStatusVal.Size = new System.Drawing.Size(256, 18);
        lblStatusVal.TabIndex = 7;
        lblStatusVal.Text = "Đang giảng dạy";
        lblStatusVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblStatusKey
        // 
        lblStatusKey.AutoSize = true;
        lblStatusKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatusKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStatusKey.Location = new System.Drawing.Point(20, 170);
        lblStatusKey.Name = "lblStatusKey";
        lblStatusKey.Size = new System.Drawing.Size(61, 15);
        lblStatusKey.TabIndex = 6;
        lblStatusKey.Text = "Trạng thái";
        // 
        // lblCertVal
        // 
        lblCertVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCertVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblCertVal.Location = new System.Drawing.Point(120, 134);
        lblCertVal.Name = "lblCertVal";
        lblCertVal.Size = new System.Drawing.Size(256, 18);
        lblCertVal.TabIndex = 5;
        lblCertVal.Text = "IELTS 8.0 · 2025";
        lblCertVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblCertKey
        // 
        lblCertKey.AutoSize = true;
        lblCertKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblCertKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblCertKey.Location = new System.Drawing.Point(20, 136);
        lblCertKey.Name = "lblCertKey";
        lblCertKey.Size = new System.Drawing.Size(71, 15);
        lblCertKey.TabIndex = 4;
        lblCertKey.Text = "Chứng nhận";
        // 
        // lblPhoneVal
        // 
        lblPhoneVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPhoneVal.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblPhoneVal.Location = new System.Drawing.Point(120, 100);
        lblPhoneVal.Name = "lblPhoneVal";
        lblPhoneVal.Size = new System.Drawing.Size(256, 18);
        lblPhoneVal.TabIndex = 3;
        lblPhoneVal.Text = "0907 321 654";
        lblPhoneVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPhoneKey
        // 
        lblPhoneKey.AutoSize = true;
        lblPhoneKey.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhoneKey.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblPhoneKey.Location = new System.Drawing.Point(20, 102);
        lblPhoneKey.Name = "lblPhoneKey";
        lblPhoneKey.Size = new System.Drawing.Size(61, 15);
        lblPhoneKey.TabIndex = 2;
        lblPhoneKey.Text = "Điện thoại";
        // 
        // pnlDetailTabs
        // 
        pnlDetailTabs.Controls.Add(lblTabAssign);
        pnlDetailTabs.Controls.Add(lblTabAvailability);
        pnlDetailTabs.Controls.Add(lblTabProfile);
        pnlDetailTabs.Location = new System.Drawing.Point(20, 52);
        pnlDetailTabs.Name = "pnlDetailTabs";
        pnlDetailTabs.Size = new System.Drawing.Size(356, 30);
        pnlDetailTabs.TabIndex = 1;
        // 
        // lblTabAssign
        // 
        lblTabAssign.AutoSize = true;
        lblTabAssign.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabAssign.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTabAssign.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTabAssign.Location = new System.Drawing.Point(155, 6);
        lblTabAssign.Name = "lblTabAssign";
        lblTabAssign.Size = new System.Drawing.Size(66, 15);
        lblTabAssign.TabIndex = 2;
        lblTabAssign.Text = "Phân công";
        // 
        // lblTabAvailability
        // 
        lblTabAvailability.AutoSize = true;
        lblTabAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTabAvailability.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblTabAvailability.Location = new System.Drawing.Point(75, 6);
        lblTabAvailability.Name = "lblTabAvailability";
        lblTabAvailability.Size = new System.Drawing.Size(58, 15);
        lblTabAvailability.TabIndex = 1;
        lblTabAvailability.Text = "Khả dụng";
        // 
        // lblTabProfile
        // 
        lblTabProfile.AutoSize = true;
        lblTabProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTabProfile.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblTabProfile.Location = new System.Drawing.Point(0, 6);
        lblTabProfile.Name = "lblTabProfile";
        lblTabProfile.Size = new System.Drawing.Size(53, 15);
        lblTabProfile.TabIndex = 0;
        lblTabProfile.Text = "▬ Hồ sơ";
        // 
        // lblTeacherDetailTitle
        // 
        lblTeacherDetailTitle.AutoSize = true;
        lblTeacherDetailTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTeacherDetailTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTeacherDetailTitle.Location = new System.Drawing.Point(20, 16);
        lblTeacherDetailTitle.Name = "lblTeacherDetailTitle";
        lblTeacherDetailTitle.Size = new System.Drawing.Size(262, 25);
        lblTeacherDetailTitle.TabIndex = 0;
        lblTeacherDetailTitle.Text = "Nguyễn Hoàng Anh · GV-001";
        // 
        // cardTeacherList
        // 
        cardTeacherList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardTeacherList.BackColor = System.Drawing.Color.White;
        cardTeacherList.Controls.Add(lblPagingNav);
        cardTeacherList.Controls.Add(lblPagingInfo);
        cardTeacherList.Controls.Add(dgvTeachers);
        cardTeacherList.Controls.Add(cboSpecialtyFilter);
        cardTeacherList.Controls.Add(cboStatusFilter);
        cardTeacherList.Controls.Add(txtSearchTeacher);
        cardTeacherList.Controls.Add(lblTeacherListTitle);
        cardTeacherList.Location = new System.Drawing.Point(24, 16);
        cardTeacherList.Name = "cardTeacherList";
        cardTeacherList.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherList.Size = new System.Drawing.Size(696, 615);
        cardTeacherList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(554, 575);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 575);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(103, 15);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 24 giáo viên";
        // 
        // dgvTeachers
        // 
        dgvTeachers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTeachers.Location = new System.Drawing.Point(20, 95);
        dgvTeachers.Name = "dgvTeachers";
        dgvTeachers.Size = new System.Drawing.Size(656, 465);
        dgvTeachers.TabIndex = 4;
        // 
        // cboSpecialtyFilter
        // 
        cboSpecialtyFilter.Location = new System.Drawing.Point(475, 52);
        cboSpecialtyFilter.Name = "cboSpecialtyFilter";
        cboSpecialtyFilter.Size = new System.Drawing.Size(155, 35);
        cboSpecialtyFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(310, 52);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(155, 35);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearchTeacher
        // 
        txtSearchTeacher.Location = new System.Drawing.Point(20, 52);
        txtSearchTeacher.Name = "txtSearchTeacher";
        txtSearchTeacher.Placeholder = "🔍  Tìm mã, tên, chuyên môn...";
        txtSearchTeacher.Size = new System.Drawing.Size(280, 35);
        txtSearchTeacher.TabIndex = 1;
        // 
        // lblTeacherListTitle
        // 
        lblTeacherListTitle.AutoSize = true;
        lblTeacherListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherListTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTeacherListTitle.Location = new System.Drawing.Point(20, 16);
        lblTeacherListTitle.Name = "lblTeacherListTitle";
        lblTeacherListTitle.Size = new System.Drawing.Size(167, 21);
        lblTeacherListTitle.TabIndex = 0;
        lblTeacherListTitle.Text = "Danh sách giáo viên";
        // 
        // TeacherManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Name = "TeacherManagementView";
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardTeacherDetail.ResumeLayout(false);
        cardTeacherDetail.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
        pnlDetailTabs.ResumeLayout(false);
        pnlDetailTabs.PerformLayout();
        cardTeacherList.ResumeLayout(false);
        cardTeacherList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddTeacher;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardTeacherList;
    private System.Windows.Forms.Label lblTeacherListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchTeacher;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboSpecialtyFilter;
    private ECMS.UI.Controls.AppDataGrid dgvTeachers;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppCard cardTeacherDetail;
    private System.Windows.Forms.Label lblTeacherDetailTitle;
    private System.Windows.Forms.Panel pnlDetailTabs;
    private System.Windows.Forms.Label lblTabProfile;
    private System.Windows.Forms.Label lblTabAvailability;
    private System.Windows.Forms.Label lblTabAssign;
    private System.Windows.Forms.Label lblPhoneKey;
    private System.Windows.Forms.Label lblPhoneVal;
    private System.Windows.Forms.Label lblCertKey;
    private System.Windows.Forms.Label lblCertVal;
    private System.Windows.Forms.Label lblStatusKey;
    private System.Windows.Forms.Label lblStatusVal;
    private System.Windows.Forms.Label lblCurrentClassKey;
    private System.Windows.Forms.Label lblCurrentClassVal;
    private ECMS.UI.Controls.AppDataGrid dgvSchedule;
    private System.Windows.Forms.Label lblAssignClass;
    private ECMS.UI.Controls.AppComboBox cboAssignClass;
    private System.Windows.Forms.Label lblEffectiveDate;
    private System.Windows.Forms.DateTimePicker dtpEffectiveDate;
    private ECMS.UI.Controls.AppButton btnCancelAssign;
    private ECMS.UI.Controls.AppButton btnSaveAssign;
}
