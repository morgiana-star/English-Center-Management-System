namespace ECMS.UI.Forms;

partial class CourseDetailDialog
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
        btnCreateClass = new ECMS.UI.Controls.AppButton();
        btnEditCourse = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardClassList = new ECMS.UI.Controls.AppCard();
        dgvClasses = new ECMS.UI.Controls.AppDataGrid();
        lblClassListTitle = new System.Windows.Forms.Label();
        cardStatClasses = new ECMS.UI.Controls.AppCard();
        lblStatClassesValue = new System.Windows.Forms.Label();
        lblStatClassesTitle = new System.Windows.Forms.Label();
        cardStatTuition = new ECMS.UI.Controls.AppCard();
        lblStatTuitionValue = new System.Windows.Forms.Label();
        lblStatTuitionTitle = new System.Windows.Forms.Label();
        cardStatHours = new ECMS.UI.Controls.AppCard();
        lblStatHoursValue = new System.Windows.Forms.Label();
        lblStatHoursTitle = new System.Windows.Forms.Label();
        cardStatSessions = new ECMS.UI.Controls.AppCard();
        lblStatSessionsValue = new System.Windows.Forms.Label();
        lblStatSessionsTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardClassList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        cardStatClasses.SuspendLayout();
        cardStatTuition.SuspendLayout();
        cardStatHours.SuspendLayout();
        cardStatSessions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateClass);
        pnlHeader.Controls.Add(btnEditCourse);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1100, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateClass
        // 
        btnCreateClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateClass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        btnCreateClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateClass.CornerRadius = 6;
        btnCreateClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateClass.ForeColor = System.Drawing.Color.White;
        btnCreateClass.Location = new System.Drawing.Point(940, 20);
        btnCreateClass.Name = "btnCreateClass";
        btnCreateClass.Size = new System.Drawing.Size(135, 36);
        btnCreateClass.TabIndex = 2;
        btnCreateClass.Text = "+ Tạo lớp học";
        btnCreateClass.UseVisualStyleBackColor = false;
        btnCreateClass.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEditCourse
        // 
        btnEditCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEditCourse.BackColor = System.Drawing.Color.White;
        btnEditCourse.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEditCourse.CornerRadius = 6;
        btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEditCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnEditCourse.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        btnEditCourse.Location = new System.Drawing.Point(800, 20);
        btnEditCourse.Name = "btnEditCourse";
        btnEditCourse.Size = new System.Drawing.Size(125, 36);
        btnEditCourse.TabIndex = 1;
        btnEditCourse.Text = "Sửa khóa học";
        btnEditCourse.UseVisualStyleBackColor = false;
        btnEditCourse.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(320, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "IELTS Foundation · CT-001";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlBody.Controls.Add(cardClassList);
        pnlBody.Controls.Add(cardStatClasses);
        pnlBody.Controls.Add(cardStatTuition);
        pnlBody.Controls.Add(cardStatHours);
        pnlBody.Controls.Add(cardStatSessions);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1100, 645);
        pnlBody.TabIndex = 1;
        // 
        // cardClassList
        // 
        cardClassList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardClassList.BackColor = System.Drawing.Color.White;
        cardClassList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardClassList.BorderWidth = 1;
        cardClassList.Controls.Add(dgvClasses);
        cardClassList.Controls.Add(lblClassListTitle);
        cardClassList.CornerRadius = 8;
        cardClassList.Location = new System.Drawing.Point(24, 115);
        cardClassList.Name = "cardClassList";
        cardClassList.Padding = new System.Windows.Forms.Padding(16);
        cardClassList.Size = new System.Drawing.Size(1052, 503);
        cardClassList.TabIndex = 2;
        // 
        // dgvClasses
        // 
        dgvClasses.AllowUserToAddRows = false;
        dgvClasses.AllowUserToDeleteRows = false;
        dgvClasses.AllowUserToResizeColumns = false;
        dgvClasses.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClasses.BackgroundColor = System.Drawing.Color.White;
        dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClasses.ColumnHeadersHeight = 38;
        dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClasses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClasses.EnableHeadersVisualStyles = false;
        dgvClasses.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvClasses.Location = new System.Drawing.Point(16, 48);
        dgvClasses.MultiSelect = false;
        dgvClasses.Name = "dgvClasses";
        dgvClasses.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvClasses.RowHeadersVisible = false;
        dgvClasses.RowHeadersWidth = 51;
        dgvClasses.RowTemplate.Height = 42;
        dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClasses.Size = new System.Drawing.Size(1020, 438);
        dgvClasses.TabIndex = 1;
        // 
        // lblClassListTitle
        // 
        lblClassListTitle.AutoSize = true;
        lblClassListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblClassListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblClassListTitle.Location = new System.Drawing.Point(16, 14);
        lblClassListTitle.Name = "lblClassListTitle";
        lblClassListTitle.Size = new System.Drawing.Size(255, 25);
        lblClassListTitle.TabIndex = 0;
        lblClassListTitle.Text = "Các lớp thuộc chương trình";
        // 
        // cardStatClasses
        // 
        cardStatClasses.BackColor = System.Drawing.Color.White;
        cardStatClasses.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatClasses.BorderWidth = 1;
        cardStatClasses.Controls.Add(lblStatClassesValue);
        cardStatClasses.Controls.Add(lblStatClassesTitle);
        cardStatClasses.CornerRadius = 8;
        cardStatClasses.Location = new System.Drawing.Point(820, 16);
        cardStatClasses.Name = "cardStatClasses";
        cardStatClasses.Padding = new System.Windows.Forms.Padding(16);
        cardStatClasses.Size = new System.Drawing.Size(256, 85);
        cardStatClasses.TabIndex = 3;
        // 
        // lblStatClassesValue
        // 
        lblStatClassesValue.AutoSize = true;
        lblStatClassesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatClassesValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStatClassesValue.Location = new System.Drawing.Point(14, 30);
        lblStatClassesValue.Name = "lblStatClassesValue";
        lblStatClassesValue.Size = new System.Drawing.Size(90, 41);
        lblStatClassesValue.TabIndex = 1;
        lblStatClassesValue.Text = "4 lớp";
        // 
        // lblStatClassesTitle
        // 
        lblStatClassesTitle.AutoSize = true;
        lblStatClassesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatClassesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatClassesTitle.Location = new System.Drawing.Point(16, 10);
        lblStatClassesTitle.Name = "lblStatClassesTitle";
        lblStatClassesTitle.Size = new System.Drawing.Size(98, 20);
        lblStatClassesTitle.TabIndex = 0;
        lblStatClassesTitle.Text = "Lớp đang mở";
        // 
        // cardStatTuition
        // 
        cardStatTuition.BackColor = System.Drawing.Color.White;
        cardStatTuition.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatTuition.BorderWidth = 1;
        cardStatTuition.Controls.Add(lblStatTuitionValue);
        cardStatTuition.Controls.Add(lblStatTuitionTitle);
        cardStatTuition.CornerRadius = 8;
        cardStatTuition.Location = new System.Drawing.Point(555, 16);
        cardStatTuition.Name = "cardStatTuition";
        cardStatTuition.Padding = new System.Windows.Forms.Padding(16);
        cardStatTuition.Size = new System.Drawing.Size(250, 85);
        cardStatTuition.TabIndex = 2;
        // 
        // lblStatTuitionValue
        // 
        lblStatTuitionValue.AutoSize = true;
        lblStatTuitionValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatTuitionValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatTuitionValue.Location = new System.Drawing.Point(14, 30);
        lblStatTuitionValue.Name = "lblStatTuitionValue";
        lblStatTuitionValue.Size = new System.Drawing.Size(172, 41);
        lblStatTuitionValue.TabIndex = 1;
        lblStatTuitionValue.Text = "6.000.000đ";
        // 
        // lblStatTuitionTitle
        // 
        lblStatTuitionTitle.AutoSize = true;
        lblStatTuitionTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatTuitionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatTuitionTitle.Location = new System.Drawing.Point(16, 10);
        lblStatTuitionTitle.Name = "lblStatTuitionTitle";
        lblStatTuitionTitle.Size = new System.Drawing.Size(90, 20);
        lblStatTuitionTitle.TabIndex = 0;
        lblStatTuitionTitle.Text = "Học phí gốc";
        // 
        // cardStatHours
        // 
        cardStatHours.BackColor = System.Drawing.Color.White;
        cardStatHours.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatHours.BorderWidth = 1;
        cardStatHours.Controls.Add(lblStatHoursValue);
        cardStatHours.Controls.Add(lblStatHoursTitle);
        cardStatHours.CornerRadius = 8;
        cardStatHours.Location = new System.Drawing.Point(290, 16);
        cardStatHours.Name = "cardStatHours";
        cardStatHours.Padding = new System.Windows.Forms.Padding(16);
        cardStatHours.Size = new System.Drawing.Size(250, 85);
        cardStatHours.TabIndex = 1;
        // 
        // lblStatHoursValue
        // 
        lblStatHoursValue.AutoSize = true;
        lblStatHoursValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatHoursValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatHoursValue.Location = new System.Drawing.Point(14, 30);
        lblStatHoursValue.Name = "lblStatHoursValue";
        lblStatHoursValue.Size = new System.Drawing.Size(144, 41);
        lblStatHoursValue.TabIndex = 1;
        lblStatHoursValue.Text = "120 phút";
        // 
        // lblStatHoursTitle
        // 
        lblStatHoursTitle.AutoSize = true;
        lblStatHoursTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatHoursTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatHoursTitle.Location = new System.Drawing.Point(16, 10);
        lblStatHoursTitle.Name = "lblStatHoursTitle";
        lblStatHoursTitle.Size = new System.Drawing.Size(125, 20);
        lblStatHoursTitle.TabIndex = 0;
        lblStatHoursTitle.Text = "Thời lượng / buổi";
        // 
        // cardStatSessions
        // 
        cardStatSessions.BackColor = System.Drawing.Color.White;
        cardStatSessions.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatSessions.BorderWidth = 1;
        cardStatSessions.Controls.Add(lblStatSessionsValue);
        cardStatSessions.Controls.Add(lblStatSessionsTitle);
        cardStatSessions.CornerRadius = 8;
        cardStatSessions.Location = new System.Drawing.Point(24, 16);
        cardStatSessions.Name = "cardStatSessions";
        cardStatSessions.Padding = new System.Windows.Forms.Padding(16);
        cardStatSessions.Size = new System.Drawing.Size(250, 85);
        cardStatSessions.TabIndex = 0;
        // 
        // lblStatSessionsValue
        // 
        lblStatSessionsValue.AutoSize = true;
        lblStatSessionsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatSessionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStatSessionsValue.Location = new System.Drawing.Point(14, 30);
        lblStatSessionsValue.Name = "lblStatSessionsValue";
        lblStatSessionsValue.Size = new System.Drawing.Size(124, 41);
        lblStatSessionsValue.TabIndex = 1;
        lblStatSessionsValue.Text = "24 buổi";
        // 
        // lblStatSessionsTitle
        // 
        lblStatSessionsTitle.AutoSize = true;
        lblStatSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStatSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStatSessionsTitle.Location = new System.Drawing.Point(16, 10);
        lblStatSessionsTitle.Name = "lblStatSessionsTitle";
        lblStatSessionsTitle.Size = new System.Drawing.Size(88, 20);
        lblStatSessionsTitle.TabIndex = 0;
        lblStatSessionsTitle.Text = "Số buổi học";
        // 
        // CourseDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1100, 720);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết khóa học — ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardClassList.ResumeLayout(false);
        cardClassList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        cardStatClasses.ResumeLayout(false);
        cardStatClasses.PerformLayout();
        cardStatTuition.ResumeLayout(false);
        cardStatTuition.PerformLayout();
        cardStatHours.ResumeLayout(false);
        cardStatHours.PerformLayout();
        cardStatSessions.ResumeLayout(false);
        cardStatSessions.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnEditCourse;
    private ECMS.UI.Controls.AppButton btnCreateClass;

    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStatSessions;
    private System.Windows.Forms.Label lblStatSessionsTitle;
    private System.Windows.Forms.Label lblStatSessionsValue;
    private ECMS.UI.Controls.AppCard cardStatHours;
    private System.Windows.Forms.Label lblStatHoursTitle;
    private System.Windows.Forms.Label lblStatHoursValue;
    private ECMS.UI.Controls.AppCard cardStatTuition;
    private System.Windows.Forms.Label lblStatTuitionTitle;
    private System.Windows.Forms.Label lblStatTuitionValue;
    private ECMS.UI.Controls.AppCard cardStatClasses;
    private System.Windows.Forms.Label lblStatClassesTitle;
    private System.Windows.Forms.Label lblStatClassesValue;

    private ECMS.UI.Controls.AppCard cardClassList;
    private System.Windows.Forms.Label lblClassListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClasses;
}
