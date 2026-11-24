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

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddStudent = new ECMS.UI.Controls.AppButton();
        btnEditClass = new ECMS.UI.Controls.AppButton();
        btnDeleteClass = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlTabs = new System.Windows.Forms.Panel();
        btnTabGrades = new System.Windows.Forms.Button();
        btnTabAttendance = new System.Windows.Forms.Button();
        btnTabSchedule = new System.Windows.Forms.Button();
        btnTabStudents = new System.Windows.Forms.Button();
        pnlBody = new System.Windows.Forms.Panel();
        cardStudentList = new ECMS.UI.Controls.AppCard();
        pnlGridFooter = new System.Windows.Forms.Panel();
        lblBottomSummary = new System.Windows.Forms.Label();
        dgvClassStudents = new ECMS.UI.Controls.AppDataGrid();
        lblStudentListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlTabs.SuspendLayout();
        pnlBody.SuspendLayout();
        cardStudentList.SuspendLayout();
        pnlGridFooter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddStudent);
        pnlHeader.Controls.Add(btnEditClass);
        pnlHeader.Controls.Add(btnDeleteClass);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1180, 72);
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
        btnAddStudent.Location = new System.Drawing.Point(1005, 18);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new System.Drawing.Size(150, 36);
        btnAddStudent.TabIndex = 4;
        btnAddStudent.Text = "Thêm học viên";
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
        btnEditClass.Location = new System.Drawing.Point(890, 18);
        btnEditClass.Name = "btnEditClass";
        btnEditClass.Size = new System.Drawing.Size(105, 36);
        btnEditClass.TabIndex = 3;
        btnEditClass.Text = "Sửa lớp";
        btnEditClass.UseVisualStyleBackColor = false;
        btnEditClass.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnDeleteClass
        // 
        btnDeleteClass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
        btnDeleteClass.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Danger;
        btnDeleteClass.CornerRadius = 5;
        btnDeleteClass.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnDeleteClass.ForeColor = System.Drawing.Color.White;
        btnDeleteClass.Location = new System.Drawing.Point(765, 18);
        btnDeleteClass.Name = "btnDeleteClass";
        btnDeleteClass.Size = new System.Drawing.Size(115, 36);
        btnDeleteClass.TabIndex = 2;
        btnDeleteClass.Text = "Xóa lớp học";
        btnDeleteClass.UseVisualStyleBackColor = false;
        btnDeleteClass.Variant = ECMS.UI.Controls.ButtonVariant.Danger;
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
        pnlTabs.Size = new System.Drawing.Size(1180, 44);
        pnlTabs.TabIndex = 1;
        // 
        // btnTabGrades
        // 
        btnTabGrades.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabGrades.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabGrades.FlatAppearance.BorderSize = 0;
        btnTabGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabGrades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabGrades.Location = new System.Drawing.Point(354, 0);
        btnTabGrades.Name = "btnTabGrades";
        btnTabGrades.Size = new System.Drawing.Size(110, 44);
        btnTabGrades.TabIndex = 3;
        btnTabGrades.Text = "Điểm số";
        btnTabGrades.UseVisualStyleBackColor = true;
        // 
        // btnTabAttendance
        // 
        btnTabAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabAttendance.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabAttendance.FlatAppearance.BorderSize = 0;
        btnTabAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabAttendance.Location = new System.Drawing.Point(244, 0);
        btnTabAttendance.Name = "btnTabAttendance";
        btnTabAttendance.Size = new System.Drawing.Size(110, 44);
        btnTabAttendance.TabIndex = 2;
        btnTabAttendance.Text = "Điểm danh";
        btnTabAttendance.UseVisualStyleBackColor = true;
        // 
        // btnTabSchedule
        // 
        btnTabSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabSchedule.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabSchedule.FlatAppearance.BorderSize = 0;
        btnTabSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnTabSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)108)), ((int)((byte)117)), ((int)((byte)125)));
        btnTabSchedule.Location = new System.Drawing.Point(134, 0);
        btnTabSchedule.Name = "btnTabSchedule";
        btnTabSchedule.Size = new System.Drawing.Size(110, 44);
        btnTabSchedule.TabIndex = 1;
        btnTabSchedule.Text = "Lịch học";
        btnTabSchedule.UseVisualStyleBackColor = true;
        // 
        // btnTabStudents
        // 
        btnTabStudents.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTabStudents.Dock = System.Windows.Forms.DockStyle.Left;
        btnTabStudents.FlatAppearance.BorderSize = 0;
        btnTabStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTabStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnTabStudents.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnTabStudents.Location = new System.Drawing.Point(24, 0);
        btnTabStudents.Name = "btnTabStudents";
        btnTabStudents.Size = new System.Drawing.Size(110, 44);
        btnTabStudents.TabIndex = 0;
        btnTabStudents.Text = "Học viên";
        btnTabStudents.UseVisualStyleBackColor = true;
        // 
        // pnlBody
        // 
        pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        pnlBody.Controls.Add(cardStudentList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 116);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
        pnlBody.Size = new System.Drawing.Size(1180, 624);
        pnlBody.TabIndex = 2;
        // 
        // cardStudentList
        // 
        cardStudentList.BackColor = System.Drawing.Color.White;
        cardStudentList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardStudentList.BorderWidth = 1;
        cardStudentList.Controls.Add(dgvClassStudents);
        cardStudentList.Controls.Add(pnlGridFooter);
        cardStudentList.Controls.Add(lblStudentListTitle);
        cardStudentList.CornerRadius = 8;
        cardStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardStudentList.Location = new System.Drawing.Point(20, 16);
        cardStudentList.Name = "cardStudentList";
        cardStudentList.Padding = new System.Windows.Forms.Padding(16);
        cardStudentList.Size = new System.Drawing.Size(1140, 588);
        cardStudentList.TabIndex = 0;
        // 
        // lblStudentListTitle
        // 
        lblStudentListTitle.Dock = System.Windows.Forms.DockStyle.Top;
        lblStudentListTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblStudentListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        lblStudentListTitle.Location = new System.Drawing.Point(16, 16);
        lblStudentListTitle.Name = "lblStudentListTitle";
        lblStudentListTitle.Size = new System.Drawing.Size(1108, 34);
        lblStudentListTitle.TabIndex = 0;
        lblStudentListTitle.Text = "DANH SÁCH HỌC VIÊN TRONG LỚP";
        // 
        // pnlGridFooter
        // 
        pnlGridFooter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlGridFooter.Controls.Add(lblBottomSummary);
        pnlGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlGridFooter.Location = new System.Drawing.Point(16, 536);
        pnlGridFooter.Name = "pnlGridFooter";
        pnlGridFooter.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        pnlGridFooter.Size = new System.Drawing.Size(1108, 36);
        pnlGridFooter.TabIndex = 2;
        // 
        // lblBottomSummary
        // 
        lblBottomSummary.Dock = System.Windows.Forms.DockStyle.Fill;
        lblBottomSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBottomSummary.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        lblBottomSummary.Location = new System.Drawing.Point(12, 6);
        lblBottomSummary.Name = "lblBottomSummary";
        lblBottomSummary.Size = new System.Drawing.Size(1084, 24);
        lblBottomSummary.TabIndex = 0;
        lblBottomSummary.Text = "Sĩ số lớp: 0 / 20 học viên";
        lblBottomSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // dgvClassStudents
        // 
        dgvClassStudents.AllowUserToAddRows = false;
        dgvClassStudents.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dgvClassStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvClassStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvClassStudents.BackgroundColor = System.Drawing.Color.White;
        dgvClassStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvClassStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvClassStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dgvClassStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvClassStudents.ColumnHeadersHeight = 38;
        dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        dgvClassStudents.DefaultCellStyle = dataGridViewCellStyle3;
        dgvClassStudents.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvClassStudents.EnableHeadersVisualStyles = false;
        dgvClassStudents.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvClassStudents.Location = new System.Drawing.Point(16, 50);
        dgvClassStudents.MultiSelect = false;
        dgvClassStudents.Name = "dgvClassStudents";
        dgvClassStudents.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dgvClassStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvClassStudents.RowHeadersVisible = false;
        dgvClassStudents.RowTemplate.Height = 42;
        dgvClassStudents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvClassStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClassStudents.Size = new System.Drawing.Size(1108, 486);
        dgvClassStudents.TabIndex = 1;
        // 
        // ClassDetailDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1180, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlTabs);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(1040, 640);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết lớp học - ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTabs.ResumeLayout(false);
        pnlBody.ResumeLayout(false);
        cardStudentList.ResumeLayout(false);
        pnlGridFooter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvClassStudents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnDeleteClass;
    private ECMS.UI.Controls.AppButton btnEditClass;
    private ECMS.UI.Controls.AppButton btnAddStudent;

    private System.Windows.Forms.Panel pnlTabs;
    private System.Windows.Forms.Button btnTabStudents;
    private System.Windows.Forms.Button btnTabSchedule;
    private System.Windows.Forms.Button btnTabAttendance;
    private System.Windows.Forms.Button btnTabGrades;

    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardStudentList;
    private System.Windows.Forms.Label lblStudentListTitle;
    private ECMS.UI.Controls.AppDataGrid dgvClassStudents;
    private System.Windows.Forms.Panel pnlGridFooter;
    private System.Windows.Forms.Label lblBottomSummary;
}
