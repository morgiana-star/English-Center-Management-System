namespace ECMS.UI.UserControls;

partial class ScheduleManagementView
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
        btnCreateSession = new ECMS.UI.Controls.AppButton();
        btnManageSchedules = new ECMS.UI.Controls.AppButton();
        btnManageRooms = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardCalendar = new ECMS.UI.Controls.AppCard();
        dgvScheduleMatrix = new ECMS.UI.Controls.AppDataGrid();
        pnlFilterBar = new System.Windows.Forms.Panel();
        cboSemester = new System.Windows.Forms.ComboBox();
        lblScheduleType = new System.Windows.Forms.Label();
        cboScheduleType = new System.Windows.Forms.ComboBox();
        cboTargetFilter = new System.Windows.Forms.ComboBox();
        btnPrevWeek = new System.Windows.Forms.Button();
        cboWeek = new System.Windows.Forms.ComboBox();
        btnNextWeek = new System.Windows.Forms.Button();
        btnPrint = new System.Windows.Forms.Button();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardCalendar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvScheduleMatrix).BeginInit();
        pnlFilterBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnCreateSession);
        pnlHeader.Controls.Add(btnManageSchedules);
        pnlHeader.Controls.Add(btnManageRooms);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1160, 72);
        pnlHeader.TabIndex = 0;
        // 
        // btnCreateSession
        // 
        btnCreateSession.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnCreateSession.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnCreateSession.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnCreateSession.CornerRadius = 5;
        btnCreateSession.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCreateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCreateSession.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnCreateSession.ForeColor = System.Drawing.Color.White;
        btnCreateSession.Location = new System.Drawing.Point(995, 18);
        btnCreateSession.Name = "btnCreateSession";
        btnCreateSession.Size = new System.Drawing.Size(140, 36);
        btnCreateSession.TabIndex = 4;
        btnCreateSession.Text = "Tạo buổi học";
        btnCreateSession.UseVisualStyleBackColor = false;
        btnCreateSession.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnManageSchedules
        // 
        btnManageSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnManageSchedules.BackColor = System.Drawing.Color.White;
        btnManageSchedules.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnManageSchedules.CornerRadius = 5;
        btnManageSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
        btnManageSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnManageSchedules.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnManageSchedules.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnManageSchedules.Location = new System.Drawing.Point(840, 18);
        btnManageSchedules.Name = "btnManageSchedules";
        btnManageSchedules.Size = new System.Drawing.Size(145, 36);
        btnManageSchedules.TabIndex = 5;
        btnManageSchedules.Text = "Quản lý lịch học";
        btnManageSchedules.UseVisualStyleBackColor = false;
        btnManageSchedules.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnManageRooms
        // 
        btnManageRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnManageRooms.BackColor = System.Drawing.Color.White;
        btnManageRooms.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnManageRooms.CornerRadius = 5;
        btnManageRooms.Cursor = System.Windows.Forms.Cursors.Hand;
        btnManageRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnManageRooms.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnManageRooms.Location = new System.Drawing.Point(695, 18);
        btnManageRooms.Name = "btnManageRooms";
        btnManageRooms.Size = new System.Drawing.Size(135, 36);
        btnManageRooms.TabIndex = 3;
        btnManageRooms.Text = "Quản lý phòng";
        btnManageRooms.UseVisualStyleBackColor = false;
        btnManageRooms.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(121, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Lịch học";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardCalendar);
        pnlBody.Controls.Add(pnlFilterBar);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 72);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1160, 688);
        pnlBody.TabIndex = 1;
        // 
        // cardCalendar
        // 
        cardCalendar.BackColor = System.Drawing.Color.White;
        cardCalendar.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardCalendar.BorderWidth = 1;
        cardCalendar.Controls.Add(dgvScheduleMatrix);
        cardCalendar.CornerRadius = 8;
        cardCalendar.Location = new System.Drawing.Point(24, 118);
        cardCalendar.Name = "cardCalendar";
        cardCalendar.Padding = new System.Windows.Forms.Padding(12);
        cardCalendar.Size = new System.Drawing.Size(1112, 546);
        cardCalendar.TabIndex = 1;
        // 
        // dgvScheduleMatrix
        // 
        dgvScheduleMatrix.AllowUserToAddRows = false;
        dgvScheduleMatrix.AllowUserToDeleteRows = false;
        dgvScheduleMatrix.AllowUserToResizeColumns = false;
        dgvScheduleMatrix.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
        dgvScheduleMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvScheduleMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvScheduleMatrix.BackgroundColor = System.Drawing.Color.White;
        dgvScheduleMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvScheduleMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvScheduleMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvScheduleMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvScheduleMatrix.ColumnHeadersHeight = 44;
        dgvScheduleMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvScheduleMatrix.DefaultCellStyle = dataGridViewCellStyle3;
        dgvScheduleMatrix.EnableHeadersVisualStyles = false;
        dgvScheduleMatrix.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvScheduleMatrix.Location = new System.Drawing.Point(12, 12);
        dgvScheduleMatrix.MultiSelect = false;
        dgvScheduleMatrix.Name = "dgvScheduleMatrix";
        dgvScheduleMatrix.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvScheduleMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvScheduleMatrix.RowHeadersVisible = false;
        dgvScheduleMatrix.RowHeadersWidth = 51;
        dgvScheduleMatrix.RowTemplate.Height = 150;
        dgvScheduleMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dgvScheduleMatrix.Size = new System.Drawing.Size(1088, 522);
        dgvScheduleMatrix.TabIndex = 0;
        // 
        // pnlFilterBar
        // 
        pnlFilterBar.BackColor = System.Drawing.Color.White;
        pnlFilterBar.Controls.Add(cboSemester);
        pnlFilterBar.Controls.Add(lblScheduleType);
        pnlFilterBar.Controls.Add(cboScheduleType);
        pnlFilterBar.Controls.Add(cboTargetFilter);
        pnlFilterBar.Controls.Add(btnPrevWeek);
        pnlFilterBar.Controls.Add(cboWeek);
        pnlFilterBar.Controls.Add(btnNextWeek);
        pnlFilterBar.Controls.Add(btnPrint);
        pnlFilterBar.Location = new System.Drawing.Point(24, 16);
        pnlFilterBar.Name = "pnlFilterBar";
        pnlFilterBar.Padding = new System.Windows.Forms.Padding(12);
        pnlFilterBar.Size = new System.Drawing.Size(1112, 90);
        pnlFilterBar.TabIndex = 0;
        // 
        // cboSemester
        // 
        cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboSemester.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboSemester.FormattingEnabled = true;
        cboSemester.Location = new System.Drawing.Point(62, 11);
        cboSemester.Name = "cboSemester";
        cboSemester.Size = new System.Drawing.Size(295, 29);
        cboSemester.TabIndex = 1;
        // 
        // lblScheduleType
        // 
        lblScheduleType.AutoSize = true;
        lblScheduleType.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblScheduleType.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblScheduleType.Location = new System.Drawing.Point(451, 12);
        lblScheduleType.Name = "lblScheduleType";
        lblScheduleType.Size = new System.Drawing.Size(110, 20);
        lblScheduleType.TabIndex = 2;
        lblScheduleType.Text = "Thời khóa biểu:";
        // 
        // cboScheduleType
        // 
        cboScheduleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboScheduleType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboScheduleType.FormattingEnabled = true;
        cboScheduleType.Location = new System.Drawing.Point(566, 8);
        cboScheduleType.Name = "cboScheduleType";
        cboScheduleType.Size = new System.Drawing.Size(230, 29);
        cboScheduleType.TabIndex = 3;
        // 
        // cboTargetFilter
        // 
        cboTargetFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboTargetFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboTargetFilter.FormattingEnabled = true;
        cboTargetFilter.Location = new System.Drawing.Point(811, 8);
        cboTargetFilter.Name = "cboTargetFilter";
        cboTargetFilter.Size = new System.Drawing.Size(275, 29);
        cboTargetFilter.TabIndex = 4;
        // 
        // btnPrevWeek
        // 
        btnPrevWeek.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        btnPrevWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnPrevWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrevWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPrevWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        btnPrevWeek.Location = new System.Drawing.Point(12, 48);
        btnPrevWeek.Name = "btnPrevWeek";
        btnPrevWeek.Size = new System.Drawing.Size(42, 32);
        btnPrevWeek.TabIndex = 5;
        btnPrevWeek.Text = "←";
        btnPrevWeek.UseVisualStyleBackColor = false;
        // 
        // cboWeek
        // 
        cboWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboWeek.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        cboWeek.FormattingEnabled = true;
        cboWeek.Location = new System.Drawing.Point(62, 49);
        cboWeek.Name = "cboWeek";
        cboWeek.Size = new System.Drawing.Size(378, 29);
        cboWeek.TabIndex = 6;
        // 
        // btnNextWeek
        // 
        btnNextWeek.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        btnNextWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)203)), ((int)((byte)213)), ((int)((byte)225)));
        btnNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNextWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnNextWeek.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)51)), ((int)((byte)65)), ((int)((byte)85)));
        btnNextWeek.Location = new System.Drawing.Point(448, 48);
        btnNextWeek.Name = "btnNextWeek";
        btnNextWeek.Size = new System.Drawing.Size(42, 32);
        btnNextWeek.TabIndex = 7;
        btnNextWeek.Text = "→";
        btnNextWeek.UseVisualStyleBackColor = false;
        // 
        // btnPrint
        // 
        btnPrint.BackColor = System.Drawing.Color.White;
        btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)34)), ((int)((byte)197)), ((int)((byte)94)));
        btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        btnPrint.Location = new System.Drawing.Point(510, 48);
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new System.Drawing.Size(95, 32);
        btnPrint.TabIndex = 8;
        btnPrint.Text = "In lịch";
        btnPrint.UseVisualStyleBackColor = false;
        // 
        // ScheduleManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        Size = new System.Drawing.Size(1160, 760);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardCalendar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvScheduleMatrix).EndInit();
        pnlFilterBar.ResumeLayout(false);
        pnlFilterBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnManageRooms;
    private ECMS.UI.Controls.AppButton btnManageSchedules;
    private ECMS.UI.Controls.AppButton btnCreateSession;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Panel pnlFilterBar;
    private System.Windows.Forms.ComboBox cboSemester;
    private System.Windows.Forms.Label lblScheduleType;
    private System.Windows.Forms.ComboBox cboScheduleType;
    private System.Windows.Forms.ComboBox cboTargetFilter;
    private System.Windows.Forms.Button btnPrevWeek;
    private System.Windows.Forms.ComboBox cboWeek;
    private System.Windows.Forms.Button btnNextWeek;
    private System.Windows.Forms.Button btnPrint;
    private ECMS.UI.Controls.AppCard cardCalendar;
    private ECMS.UI.Controls.AppDataGrid dgvScheduleMatrix;
}
