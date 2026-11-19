namespace ECMS.UI.Forms;

partial class ClassDetailDialog
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
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        btnEditClass = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabGrades = new System.Windows.Forms.Button();
        btnTabAttendance = new System.Windows.Forms.Button();
        btnTabSchedule = new System.Windows.Forms.Button();
        btnTabStudents = new System.Windows.Forms.Button();
        pnlBody = new System.Windows.Forms.Panel();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        dgvClassStudents = new ECMS.UI.Controls.AppDataGrid();
        lblStudentListTitle = new System.Windows.Forms.Label();
        cardStatAttendance = new ECMS.UI.Controls.AppCard();
        lblStatAttendanceVal = new System.Windows.Forms.Label();
        lblStatAttendanceTitle = new System.Windows.Forms.Label();
        cardStatStatus = new ECMS.UI.Controls.AppCard();
        lblStatStatusVal = new System.Windows.Forms.Label();
        lblStatStatusTitle = new System.Windows.Forms.Label();
        cardStatSessions = new ECMS.UI.Controls.AppCard();
        lblStatSessionsVal = new System.Windows.Forms.Label();
        lblStatSessionsTitle = new System.Windows.Forms.Label();
        cardStatEnrollment = new ECMS.UI.Controls.AppCard();
        lblStatEnrollmentVal = new System.Windows.Forms.Label();
        lblStatEnrollmentTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStudentList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).BeginInit();
        cardStatAttendance.SuspendLayout();
        cardStatStatus.SuspendLayout();
        cardStatSessions.SuspendLayout();
        cardStatEnrollment.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddStudent);
        pnlHeader.Controls.Add(btnEditClass);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1100, 72);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddStudent
        // 
        btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnAddStudent.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddStudent.CornerRadius = 5;
        btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddStudent.ForeColor = System.Drawing.Color.White;
        btnAddStudent.Location = new System.Drawing.Point(927, 18);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new System.Drawing.Size(153, 36);
        btnAddStudent.TabIndex = 4;
        btnAddStudent.Text = "+ Thêm học viên";
        btnAddStudent.UseVisualStyleBackColor = false;
        btnAddStudent.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnEditClass
        // 
        btnEditClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnEditClass.BackColor = System.Drawing.Color.White;
        btnEditClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnEditClass.CornerRadius = 5;
        btnEditClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEditClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnEditClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnEditClass.Location = new System.Drawing.Point(816, 18);
        btnEditClass.Name = "btnEditClass";
        btnEditClass.Size = new System.Drawing.Size(105, 36);
        btnEditClass.TabIndex = 3;
        btnEditClass.Text = "Sửa lớp";
        btnEditClass.UseVisualStyleBackColor = false;
        btnEditClass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(381, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "IELTS-F01 · IELTS Foundation";
        // 
        // pnlTabs
        // 
        pnlTabs.BackColor = System.Drawing.Color.White;
        pnlTabs.Controls.Add(btnTabGrades);
        pnlTabs.Controls.Add(btnTabAttendance);
        pnlTabs.Controls.Add(btnTabSchedule);
        pnlTabs.Controls.Add(btnTabStudents);
        pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTabs.Location = new System.Drawing.Point(0, 72);
        pnlTabs.Name = "pnlTabs";
        pnlTabs.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
        pnlTabs.Size = new System.Drawing.Size(1100, 42);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabGrades
        // 
        btnTabGrades.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabGrades.FlatAppearance.BorderSize = 0;
        btnTabGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabGrades.Location = new System.Drawing.Point(344, 0);
        btnTabGrades.Name = "btnTabGrades";
        btnTabGrades.Size = new System.Drawing.Size(100, 42);
        btnTabGrades.TabIndex = 3;
        btnTabGrades.Text = "Điểm số";
        btnTabGrades.UseVisualStyleBackColor = true;
        // 
        // btnTabAttendance
        // 
        btnTabAttendance.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabAttendance.FlatAppearance.BorderSize = 0;
        btnTabAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabAttendance.Location = new System.Drawing.Point(244, 0);
        btnTabAttendance.Name = "btnTabAttendance";
        btnTabAttendance.Size = new System.Drawing.Size(100, 42);
        btnTabAttendance.TabIndex = 2;
        btnTabAttendance.Text = "Điểm danh";
        btnTabAttendance.UseVisualStyleBackColor = true;
        // 
        // btnTabSchedule
        // 
        btnTabSchedule.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabSchedule.FlatAppearance.BorderSize = 0;
        btnTabSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabSchedule.Location = new System.Drawing.Point(134, 0);
        btnTabSchedule.Name = "btnTabSchedule";
        btnTabSchedule.Size = new System.Drawing.Size(110, 42);
        btnTabSchedule.TabIndex = 1;
        btnTabSchedule.Text = "Lịch học";
        btnTabSchedule.UseVisualStyleBackColor = true;
        // 
        // btnTabStudents
        // 
        btnTabStudents.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabStudents.FlatAppearance.BorderSize = 0;
        btnTabStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabStudents.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnTabStudents.Location = new System.Drawing.Point(24, 0);
        btnTabStudents.Name = "btnTabStudents";
        btnTabStudents.Size = new System.Drawing.Size(110, 42);
        btnTabStudents.TabIndex = 0;
        btnTabStudents.Text = "Học viên";
        btnTabStudents.UseVisualStyleBackColor = true;
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Controls.Add(cardStatAttendance);
        pnlBody.Controls.Add(cardStatStatus);
        pnlBody.Controls.Add(cardStatSessions);
        pnlBody.Controls.Add(cardStatEnrollment);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 114);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1100, 606);
        pnlBody.TabIndex = 2;
        // 
        // cardStudentList
        // 
        cardStudentList.Anchor = System.Windows.Forms.AnchorStyles.None;
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(dgvClassStudents);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.CornerRadius = 6;
        cardStudentList.Location = new System.Drawing.Point(24, 115);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(20);
        cardStudentList.Size = new System.Drawing.Size(1052, 470);
        cardStudentList.TabIndex = 4;
        // 
        // dgvClassStudents
        // 
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.AllowUserToDeleteRows = false;
        dgvClassStudents.AllowUserToResizeColumns = false;
        dgvClassStudents.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvClassStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClassStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
        dgvClassStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClassStudents.BackgroundColor = System.Drawing.Color.White;
        dgvClassStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClassStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClassStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClassStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClassStudents.ColumnHeadersHeight = 36;
        dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvClassStudents.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClassStudents.EnableHeadersVisualStyles = false;
        dgvClassStudents.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvClassStudents.Location = new System.Drawing.Point(20, 52);
        dgvClassStudents.MultiSelect = false;
        dgvClassStudents.Name = "dgvClassStudents";
        dgvClassStudents.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvClassStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.RowHeadersWidth = 51;
        dgvClassStudents.RowTemplate.Height = 40;
        dgvClassStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.Size = new System.Drawing.Size(1012, 400);
        dgvClassStudents.TabIndex = 1;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.AutoSize = true;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStudentListTitle.Location = new System.Drawing.Point(20, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(180, 25);
        lblStudentListTitle.TabIndex = 0;
        lblStudentListTitle.Text = "Học viên trong lớp";
        // 
        // cardStatAttendance
        // 
        cardStatAttendance.BackColor = System.Drawing.Color.White;
        cardStatAttendance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatAttendance.BorderWidth = 1;
        cardStatAttendance.Controls.Add(lblStatAttendanceVal);
        cardStatAttendance.Controls.Add(lblStatAttendanceTitle);
        cardStatAttendance.CornerRadius = 6;
        cardStatAttendance.Location = new System.Drawing.Point(828, 16);
        cardStatAttendance.Name = "cardStatAttendance";
        cardStatAttendance.Padding = new System.Windows.Forms.Padding(16);
        cardStatAttendance.Size = new System.Drawing.Size(248, 85);
        cardStatAttendance.TabIndex = 3;
        // 
        // lblStatAttendanceVal
        // 
        lblStatAttendanceVal.AutoSize = true;
        lblStatAttendanceVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatAttendanceVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatAttendanceVal.Location = new System.Drawing.Point(16, 38);
        lblStatAttendanceVal.Name = "lblStatAttendanceVal";
        lblStatAttendanceVal.Size = new System.Drawing.Size(103, 41);
        lblStatAttendanceVal.TabIndex = 1;
        lblStatAttendanceVal.Text = "90,3%";
        // 
        // lblStatAttendanceTitle
        // 
        lblStatAttendanceTitle.AutoSize = true;
        lblStatAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatAttendanceTitle.Location = new System.Drawing.Point(16, 16);
        lblStatAttendanceTitle.Name = "lblStatAttendanceTitle";
        lblStatAttendanceTitle.Size = new System.Drawing.Size(110, 20);
        lblStatAttendanceTitle.TabIndex = 0;
        lblStatAttendanceTitle.Text = "Chuyên cần lớp";
        // 
        // cardStatStatus
        // 
        cardStatStatus.BackColor = System.Drawing.Color.White;
        cardStatStatus.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatStatus.BorderWidth = 1;
        cardStatStatus.Controls.Add(lblStatStatusVal);
        cardStatStatus.Controls.Add(lblStatStatusTitle);
        cardStatStatus.CornerRadius = 6;
        cardStatStatus.Location = new System.Drawing.Point(560, 16);
        cardStatStatus.Name = "cardStatStatus";
        cardStatStatus.Padding = new System.Windows.Forms.Padding(16);
        cardStatStatus.Size = new System.Drawing.Size(248, 85);
        cardStatStatus.TabIndex = 2;
        // 
        // lblStatStatusVal
        // 
        lblStatStatusVal.AutoSize = true;
        lblStatStatusVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatStatusVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatStatusVal.Location = new System.Drawing.Point(16, 38);
        lblStatStatusVal.Name = "lblStatStatusVal";
        lblStatStatusVal.Size = new System.Drawing.Size(151, 41);
        lblStatStatusVal.TabIndex = 1;
        lblStatStatusVal.Text = "Đang học";
        // 
        // lblStatStatusTitle
        // 
        lblStatStatusTitle.AutoSize = true;
        lblStatStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatStatusTitle.Location = new System.Drawing.Point(16, 16);
        lblStatStatusTitle.Name = "lblStatStatusTitle";
        lblStatStatusTitle.Size = new System.Drawing.Size(101, 20);
        lblStatStatusTitle.TabIndex = 0;
        lblStatStatusTitle.Text = "Trạng thái lớp";
        // 
        // cardStatSessions
        // 
        cardStatSessions.BackColor = System.Drawing.Color.White;
        cardStatSessions.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatSessions.BorderWidth = 1;
        cardStatSessions.Controls.Add(lblStatSessionsVal);
        cardStatSessions.Controls.Add(lblStatSessionsTitle);
        cardStatSessions.CornerRadius = 6;
        cardStatSessions.Location = new System.Drawing.Point(292, 16);
        cardStatSessions.Name = "cardStatSessions";
        cardStatSessions.Padding = new System.Windows.Forms.Padding(16);
        cardStatSessions.Size = new System.Drawing.Size(248, 85);
        cardStatSessions.TabIndex = 1;
        // 
        // lblStatSessionsVal
        // 
        lblStatSessionsVal.AutoSize = true;
        lblStatSessionsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatSessionsVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatSessionsVal.Location = new System.Drawing.Point(16, 38);
        lblStatSessionsVal.Name = "lblStatSessionsVal";
        lblStatSessionsVal.Size = new System.Drawing.Size(98, 41);
        lblStatSessionsVal.TabIndex = 1;
        lblStatSessionsVal.Text = "8 / 24";
        // 
        // lblStatSessionsTitle
        // 
        lblStatSessionsTitle.AutoSize = true;
        lblStatSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatSessionsTitle.Location = new System.Drawing.Point(16, 16);
        lblStatSessionsTitle.Name = "lblStatSessionsTitle";
        lblStatSessionsTitle.Size = new System.Drawing.Size(88, 20);
        lblStatSessionsTitle.TabIndex = 0;
        lblStatSessionsTitle.Text = "Buổi đã học";
        // 
        // cardStatEnrollment
        // 
        cardStatEnrollment.BackColor = System.Drawing.Color.White;
        cardStatEnrollment.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStatEnrollment.BorderWidth = 1;
        cardStatEnrollment.Controls.Add(lblStatEnrollmentVal);
        cardStatEnrollment.Controls.Add(lblStatEnrollmentTitle);
        cardStatEnrollment.CornerRadius = 6;
        cardStatEnrollment.Location = new System.Drawing.Point(24, 16);
        cardStatEnrollment.Name = "cardStatEnrollment";
        cardStatEnrollment.Padding = new System.Windows.Forms.Padding(16);
        cardStatEnrollment.Size = new System.Drawing.Size(248, 85);
        cardStatEnrollment.TabIndex = 0;
        // 
        // lblStatEnrollmentVal
        // 
        lblStatEnrollmentVal.AutoSize = true;
        lblStatEnrollmentVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        lblStatEnrollmentVal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblStatEnrollmentVal.Location = new System.Drawing.Point(16, 38);
        lblStatEnrollmentVal.Name = "lblStatEnrollmentVal";
        lblStatEnrollmentVal.Size = new System.Drawing.Size(115, 41);
        lblStatEnrollmentVal.TabIndex = 1;
        lblStatEnrollmentVal.Text = "18 / 20";
        // 
        // lblStatEnrollmentTitle
        // 
        lblStatEnrollmentTitle.AutoSize = true;
        lblStatEnrollmentTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStatEnrollmentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        lblStatEnrollmentTitle.Location = new System.Drawing.Point(16, 16);
        lblStatEnrollmentTitle.Name = "lblStatEnrollmentTitle";
        lblStatEnrollmentTitle.Size = new System.Drawing.Size(93, 20);
        lblStatEnrollmentTitle.TabIndex = 0;
        lblStatEnrollmentTitle.Text = "Sĩ số hiện tại";
        // 
        // ClassDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1100, 720);
        Controls.Add(pnlBody);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết lớp học · IELTS-F01";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardStudentList.ResumeLayout(false);
        cardStudentList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).EndInit();
        cardStatAttendance.ResumeLayout(false);
        cardStatAttendance.PerformLayout();
        cardStatStatus.ResumeLayout(false);
        cardStatStatus.PerformLayout();
        cardStatSessions.ResumeLayout(false);
        cardStatSessions.PerformLayout();
        cardStatEnrollment.ResumeLayout(false);
        cardStatEnrollment.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnEditClass;
    private ECMS.UI.Controls.AppButton btnAddStudent;
    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabStudents;
    private System.Windows.Forms.Button btnTabSchedule;
    private System.Windows.Forms.Button btnTabAttendance;
    private System.Windows.Forms.Button btnTabGrades;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStatEnrollment;
    private System.Windows.Forms.Label lblStatEnrollmentTitle;
    private System.Windows.Forms.Label lblStatEnrollmentVal;
    private ECMS.UI.Controls.AppCard cardStatSessions;
    private System.Windows.Forms.Label lblStatSessionsTitle;
    private System.Windows.Forms.Label lblStatSessionsVal;
    private ECMS.UI.Controls.AppCard cardStatStatus;
    private System.Windows.Forms.Label lblStatStatusTitle;
    private System.Windows.Forms.Label lblStatStatusVal;
    private ECMS.UI.Controls.AppCard cardStatAttendance;
    private System.Windows.Forms.Label lblStatAttendanceTitle;
    private System.Windows.Forms.Label lblStatAttendanceVal;
    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClassStudents;
}
