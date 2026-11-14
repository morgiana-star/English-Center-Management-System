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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddTeacher = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
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
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddTeacher
        // 
        btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnAddTeacher.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddTeacher.CornerRadius = 5;
        btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddTeacher.ForeColor = System.Drawing.Color.White;
        btnAddTeacher.Location = new System.Drawing.Point(996, 20);
        btnAddTeacher.Name = "btnAddTeacher";
        btnAddTeacher.Size = new System.Drawing.Size(140, 36);
        btnAddTeacher.TabIndex = 3;
        btnAddTeacher.Text = "Thêm giáo viên";
        btnAddTeacher.UseVisualStyleBackColor = false;
        btnAddTeacher.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(137, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Giáo viên";
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
        cardTeacherDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardTeacherDetail.BackColor = System.Drawing.Color.White;
        cardTeacherDetail.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTeacherDetail.BorderWidth = 1;
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
        cardTeacherDetail.CornerRadius = 6;
        cardTeacherDetail.Location = new System.Drawing.Point(740, 16);
        cardTeacherDetail.Name = "cardTeacherDetail";
        cardTeacherDetail.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherDetail.Size = new System.Drawing.Size(396, 615);
        cardTeacherDetail.TabIndex = 1;
        // 
        // btnSaveAssign
        // 
        btnSaveAssign.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveAssign.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSaveAssign.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveAssign.CornerRadius = 5;
        btnSaveAssign.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveAssign.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveAssign.ForeColor = System.Drawing.Color.White;
        btnSaveAssign.Location = new System.Drawing.Point(260, 560);
        btnSaveAssign.Name = "btnSaveAssign";
        btnSaveAssign.Size = new System.Drawing.Size(116, 36);
        btnSaveAssign.TabIndex = 16;
        btnSaveAssign.Text = "Lưu phân công";
        btnSaveAssign.UseVisualStyleBackColor = false;
        btnSaveAssign.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelAssign
        // 
        btnCancelAssign.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelAssign.BackColor = System.Drawing.Color.White;
        btnCancelAssign.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelAssign.CornerRadius = 5;
        btnCancelAssign.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelAssign.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelAssign.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancelAssign.Location = new System.Drawing.Point(185, 560);
        btnCancelAssign.Name = "btnCancelAssign";
        btnCancelAssign.Size = new System.Drawing.Size(65, 36);
        btnCancelAssign.TabIndex = 15;
        btnCancelAssign.Text = "Hủy";
        btnCancelAssign.UseVisualStyleBackColor = false;
        btnCancelAssign.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // dtpEffectiveDate
        // 
        dtpEffectiveDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        dtpEffectiveDate.CustomFormat = "dd/MM/yyyy";
        dtpEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpEffectiveDate.Location = new System.Drawing.Point(205, 508);
        dtpEffectiveDate.Name = "dtpEffectiveDate";
        dtpEffectiveDate.Size = new System.Drawing.Size(171, 29);
        dtpEffectiveDate.TabIndex = 14;
        // 
        // lblEffectiveDate
        // 
        lblEffectiveDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblEffectiveDate.AutoSize = true;
        lblEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEffectiveDate.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblEffectiveDate.Location = new System.Drawing.Point(205, 482);
        lblEffectiveDate.Name = "lblEffectiveDate";
        lblEffectiveDate.Size = new System.Drawing.Size(66, 20);
        lblEffectiveDate.TabIndex = 13;
        lblEffectiveDate.Text = "Từ ngày";
        // 
        // cboAssignClass
        // 
        cboAssignClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        cboAssignClass.BackColor = System.Drawing.Color.Transparent;
        cboAssignClass.CornerRadius = 5;
        cboAssignClass.DataSource = null;
        cboAssignClass.DisplayMember = "";
        cboAssignClass.Location = new System.Drawing.Point(20, 505);
        cboAssignClass.Name = "cboAssignClass";
        cboAssignClass.SelectedIndex = -1;
        cboAssignClass.SelectedItem = null;
        cboAssignClass.SelectedValue = null;
        cboAssignClass.Size = new System.Drawing.Size(170, 35);
        cboAssignClass.TabIndex = 12;
        cboAssignClass.ValueMember = "";
        // 
        // lblAssignClass
        // 
        lblAssignClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblAssignClass.AutoSize = true;
        lblAssignClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAssignClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblAssignClass.Location = new System.Drawing.Point(20, 482);
        lblAssignClass.Name = "lblAssignClass";
        lblAssignClass.Size = new System.Drawing.Size(108, 20);
        lblAssignClass.TabIndex = 11;
        lblAssignClass.Text = "Phân công lớp";
        // 
        // dgvSchedule
        // 
        dgvSchedule.AllowUserToAddRows = false;
        dgvSchedule.AllowUserToDeleteRows = false;
        dgvSchedule.AllowUserToResizeColumns = false;
        dgvSchedule.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSchedule.BackgroundColor = System.Drawing.Color.White;
        dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvSchedule.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSchedule.EnableHeadersVisualStyles = false;
        dgvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvSchedule.Location = new System.Drawing.Point(20, 227);
        dgvSchedule.MultiSelect = false;
        dgvSchedule.Name = "dgvSchedule";
        dgvSchedule.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvSchedule.RowHeadersVisible = false;
        dgvSchedule.RowHeadersWidth = 51;
        dgvSchedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSchedule.Size = new System.Drawing.Size(356, 243);
        dgvSchedule.TabIndex = 10;
        // 
        // lblCurrentClassVal
        // 
        lblCurrentClassVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCurrentClassVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblCurrentClassKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCurrentClassKey.Location = new System.Drawing.Point(20, 204);
        lblCurrentClassKey.Name = "lblCurrentClassKey";
        lblCurrentClassKey.Size = new System.Drawing.Size(87, 20);
        lblCurrentClassKey.TabIndex = 8;
        lblCurrentClassKey.Text = "Lớp hiện tại";
        // 
        // lblStatusVal
        // 
        lblStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)167)), ((int)((byte)69)));
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
        lblStatusKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatusKey.Location = new System.Drawing.Point(20, 170);
        lblStatusKey.Name = "lblStatusKey";
        lblStatusKey.Size = new System.Drawing.Size(75, 20);
        lblStatusKey.TabIndex = 6;
        lblStatusKey.Text = "Trạng thái";
        // 
        // lblCertVal
        // 
        lblCertVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCertVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblCertKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblCertKey.Location = new System.Drawing.Point(20, 136);
        lblCertKey.Name = "lblCertKey";
        lblCertKey.Size = new System.Drawing.Size(88, 20);
        lblCertKey.TabIndex = 4;
        lblCertKey.Text = "Chứng nhận";
        // 
        // lblPhoneVal
        // 
        lblPhoneVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPhoneVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
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
        lblPhoneKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblPhoneKey.Location = new System.Drawing.Point(20, 102);
        lblPhoneKey.Name = "lblPhoneKey";
        lblPhoneKey.Size = new System.Drawing.Size(78, 20);
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
        lblTabAssign.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTabAssign.Location = new System.Drawing.Point(155, 6);
        lblTabAssign.Name = "lblTabAssign";
        lblTabAssign.Size = new System.Drawing.Size(78, 20);
        lblTabAssign.TabIndex = 2;
        lblTabAssign.Text = "Phân công";
        // 
        // lblTabAvailability
        // 
        lblTabAvailability.AutoSize = true;
        lblTabAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblTabAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblTabAvailability.Location = new System.Drawing.Point(75, 6);
        lblTabAvailability.Name = "lblTabAvailability";
        lblTabAvailability.Size = new System.Drawing.Size(72, 20);
        lblTabAvailability.TabIndex = 1;
        lblTabAvailability.Text = "Khả dụng";
        // 
        // lblTabProfile
        // 
        lblTabProfile.AutoSize = true;
        lblTabProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        lblTabProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTabProfile.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblTabProfile.Location = new System.Drawing.Point(0, 6);
        lblTabProfile.Name = "lblTabProfile";
        lblTabProfile.Size = new System.Drawing.Size(68, 20);
        lblTabProfile.TabIndex = 0;
        lblTabProfile.Text = "▬ Hồ sơ";
        // 
        // lblTeacherDetailTitle
        // 
        lblTeacherDetailTitle.AutoSize = true;
        lblTeacherDetailTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblTeacherDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTeacherDetailTitle.Location = new System.Drawing.Point(20, 16);
        lblTeacherDetailTitle.Name = "lblTeacherDetailTitle";
        lblTeacherDetailTitle.Size = new System.Drawing.Size(313, 30);
        lblTeacherDetailTitle.TabIndex = 0;
        lblTeacherDetailTitle.Text = "Nguyễn Hoàng Anh · GV-001";
        // 
        // cardTeacherList
        // 
        cardTeacherList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardTeacherList.BackColor = System.Drawing.Color.White;
        cardTeacherList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardTeacherList.BorderWidth = 1;
        cardTeacherList.Controls.Add(lblPagingNav);
        cardTeacherList.Controls.Add(lblPagingInfo);
        cardTeacherList.Controls.Add(dgvTeachers);
        cardTeacherList.Controls.Add(cboSpecialtyFilter);
        cardTeacherList.Controls.Add(cboStatusFilter);
        cardTeacherList.Controls.Add(txtSearchTeacher);
        cardTeacherList.Controls.Add(lblTeacherListTitle);
        cardTeacherList.CornerRadius = 6;
        cardTeacherList.Location = new System.Drawing.Point(24, 16);
        cardTeacherList.Name = "cardTeacherList";
        cardTeacherList.Padding = new System.Windows.Forms.Padding(20);
        cardTeacherList.Size = new System.Drawing.Size(696, 615);
        cardTeacherList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblPagingNav.Location = new System.Drawing.Point(518, 575);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 575);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(128, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–5 / 24 giáo viên";
        // 
        // dgvTeachers
        // 
        dgvTeachers.AllowUserToAddRows = false;
        dgvTeachers.AllowUserToDeleteRows = false;
        dgvTeachers.AllowUserToResizeColumns = false;
        dgvTeachers.AllowUserToResizeRows = false;
        dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
        dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvTeachers.BackgroundColor = System.Drawing.Color.White;
        dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvTeachers.DefaultCellStyle = dataGridViewCellStyle7;
        dgvTeachers.EnableHeadersVisualStyles = false;
        dgvTeachers.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvTeachers.Location = new System.Drawing.Point(20, 95);
        dgvTeachers.MultiSelect = false;
        dgvTeachers.Name = "dgvTeachers";
        dgvTeachers.ReadOnly = true;
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvTeachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
        dgvTeachers.RowHeadersVisible = false;
        dgvTeachers.RowHeadersWidth = 51;
        dgvTeachers.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvTeachers.Size = new System.Drawing.Size(656, 465);
        dgvTeachers.TabIndex = 4;
        // 
        // cboSpecialtyFilter
        // 
        cboSpecialtyFilter.BackColor = System.Drawing.Color.Transparent;
        cboSpecialtyFilter.CornerRadius = 5;
        cboSpecialtyFilter.DataSource = null;
        cboSpecialtyFilter.DisplayMember = "";
        cboSpecialtyFilter.Location = new System.Drawing.Point(475, 52);
        cboSpecialtyFilter.Name = "cboSpecialtyFilter";
        cboSpecialtyFilter.SelectedIndex = -1;
        cboSpecialtyFilter.SelectedItem = null;
        cboSpecialtyFilter.SelectedValue = null;
        cboSpecialtyFilter.Size = new System.Drawing.Size(155, 35);
        cboSpecialtyFilter.TabIndex = 3;
        cboSpecialtyFilter.ValueMember = "";
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.DataSource = null;
        cboStatusFilter.DisplayMember = "";
        cboStatusFilter.Location = new System.Drawing.Point(310, 52);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.SelectedIndex = -1;
        cboStatusFilter.SelectedItem = null;
        cboStatusFilter.SelectedValue = null;
        cboStatusFilter.Size = new System.Drawing.Size(155, 35);
        cboStatusFilter.TabIndex = 2;
        cboStatusFilter.ValueMember = "";
        // 
        // txtSearchTeacher
        // 
        txtSearchTeacher.BackColor = System.Drawing.Color.Transparent;
        txtSearchTeacher.CornerRadius = 5;
        txtSearchTeacher.ErrorMessage = "";
        txtSearchTeacher.HasError = false;
        txtSearchTeacher.Location = new System.Drawing.Point(20, 52);
        txtSearchTeacher.Name = "txtSearchTeacher";
        txtSearchTeacher.Placeholder = "🔍  Tìm mã, tên, chuyên môn...";
        txtSearchTeacher.ReadOnly = false;
        txtSearchTeacher.Size = new System.Drawing.Size(280, 35);
        txtSearchTeacher.TabIndex = 1;
        txtSearchTeacher.UseSystemPasswordChar = false;
        // 
        // lblTeacherListTitle
        // 
        lblTeacherListTitle.AutoSize = true;
        lblTeacherListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTeacherListTitle.Location = new System.Drawing.Point(20, 16);
        lblTeacherListTitle.Name = "lblTeacherListTitle";
        lblTeacherListTitle.Size = new System.Drawing.Size(203, 28);
        lblTeacherListTitle.TabIndex = 0;
        lblTeacherListTitle.Text = "Danh sách giáo viên";
        // 
        // TeacherManagementView
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
    private System.Windows.Forms.Label lblTitle;
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
