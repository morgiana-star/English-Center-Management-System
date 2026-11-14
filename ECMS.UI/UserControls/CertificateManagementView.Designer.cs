namespace ECMS.UI.UserControls;

partial class CertificateManagementView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlMain = new System.Windows.Forms.Panel();
        pnlBottomInfo = new System.Windows.Forms.TableLayoutPanel();
        cardBlockedInfo = new ECMS.UI.Controls.AppCard();
        pnlShortcutActions = new System.Windows.Forms.FlowLayoutPanel();
        btnOpenGrades = new ECMS.UI.Controls.AppButton();
        btnOpenAttendance = new ECMS.UI.Controls.AppButton();
        btnOpenTuition = new ECMS.UI.Controls.AppButton();
        cardActiveCourseNote = new ECMS.UI.Controls.AppCard();
        lblActiveCourseDesc = new System.Windows.Forms.Label();
        lblActiveCourseBadge = new System.Windows.Forms.Label();
        lblActiveCourseTitle = new System.Windows.Forms.Label();
        pnlGridCard = new ECMS.UI.Controls.AppCard();
        lblGridFooter = new System.Windows.Forms.Label();
        gridEligibility = new ECMS.UI.Controls.AppDataGrid();
        colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAction = new System.Windows.Forms.DataGridViewButtonColumn();
        lblGridCardTitle = new System.Windows.Forms.Label();
        pnlStepper = new System.Windows.Forms.Panel();
        lblStep4 = new System.Windows.Forms.Label();
        lblStep3 = new System.Windows.Forms.Label();
        lblStep2 = new System.Windows.Forms.Label();
        lblStep1 = new System.Windows.Forms.Label();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
        btnApproveEligible = new ECMS.UI.Controls.AppButton();
        btnRecheck = new ECMS.UI.Controls.AppButton();
        pnlMain.SuspendLayout();
        pnlBottomInfo.SuspendLayout();
        cardBlockedInfo.SuspendLayout();
        pnlShortcutActions.SuspendLayout();
        cardActiveCourseNote.SuspendLayout();
        pnlGridCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridEligibility).BeginInit();
        pnlStepper.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTopActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.AutoScroll = true;
        pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        pnlMain.Controls.Add(pnlBottomInfo);
        pnlMain.Controls.Add(pnlGridCard);
        pnlMain.Controls.Add(pnlStepper);
        pnlMain.Controls.Add(pnlHeader);
        pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMain.Location = new System.Drawing.Point(0, 0);
        pnlMain.Name = "pnlMain";
        pnlMain.Padding = new System.Windows.Forms.Padding(24, 16, 24, 24);
        pnlMain.Size = new System.Drawing.Size(1200, 900);
        pnlMain.TabIndex = 0;
        // 
        // pnlBottomInfo
        // 
        pnlBottomInfo.ColumnCount = 2;
        pnlBottomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
        pnlBottomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
        pnlBottomInfo.Controls.Add(cardBlockedInfo, 0, 0);
        pnlBottomInfo.Controls.Add(cardActiveCourseNote, 1, 0);
        pnlBottomInfo.Dock = System.Windows.Forms.DockStyle.Top;
        pnlBottomInfo.Location = new System.Drawing.Point(24, 454);
        pnlBottomInfo.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
        pnlBottomInfo.Name = "pnlBottomInfo";
        pnlBottomInfo.RowCount = 1;
        pnlBottomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        pnlBottomInfo.Size = new System.Drawing.Size(1152, 170);
        pnlBottomInfo.TabIndex = 4;
        // 
        // cardBlockedInfo
        // 
        cardBlockedInfo.BackColor = System.Drawing.Color.White;
        cardBlockedInfo.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardBlockedInfo.BorderWidth = 1;
        cardBlockedInfo.Controls.Add(pnlShortcutActions);
        cardBlockedInfo.CornerRadius = 6;
        cardBlockedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        cardBlockedInfo.Location = new System.Drawing.Point(3, 3);
        cardBlockedInfo.Name = "cardBlockedInfo";
        cardBlockedInfo.Padding = new System.Windows.Forms.Padding(16);
        cardBlockedInfo.Size = new System.Drawing.Size(627, 164);
        cardBlockedInfo.TabIndex = 0;
        // 
        // pnlShortcutActions
        // 
        pnlShortcutActions.Controls.Add(btnOpenGrades);
        pnlShortcutActions.Controls.Add(btnOpenAttendance);
        pnlShortcutActions.Controls.Add(btnOpenTuition);
        pnlShortcutActions.Location = new System.Drawing.Point(16, 85);
        pnlShortcutActions.Name = "pnlShortcutActions";
        pnlShortcutActions.Size = new System.Drawing.Size(590, 48);
        pnlShortcutActions.TabIndex = 2;
        // 
        // btnOpenGrades
        // 
        btnOpenGrades.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenGrades.CornerRadius = 5;
        btnOpenGrades.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenGrades.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnOpenGrades.Location = new System.Drawing.Point(3, 3);
        btnOpenGrades.Name = "btnOpenGrades";
        btnOpenGrades.Size = new System.Drawing.Size(110, 34);
        btnOpenGrades.TabIndex = 0;
        btnOpenGrades.Text = "Mở điểm số";
        btnOpenGrades.UseVisualStyleBackColor = true;
        btnOpenGrades.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnOpenAttendance
        // 
        btnOpenAttendance.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenAttendance.CornerRadius = 5;
        btnOpenAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenAttendance.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnOpenAttendance.Location = new System.Drawing.Point(119, 3);
        btnOpenAttendance.Name = "btnOpenAttendance";
        btnOpenAttendance.Size = new System.Drawing.Size(110, 34);
        btnOpenAttendance.TabIndex = 1;
        btnOpenAttendance.Text = "Mở điểm danh";
        btnOpenAttendance.UseVisualStyleBackColor = true;
        btnOpenAttendance.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // btnOpenTuition
        // 
        btnOpenTuition.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnOpenTuition.CornerRadius = 5;
        btnOpenTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenTuition.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        btnOpenTuition.Location = new System.Drawing.Point(235, 3);
        btnOpenTuition.Name = "btnOpenTuition";
        btnOpenTuition.Size = new System.Drawing.Size(110, 34);
        btnOpenTuition.TabIndex = 2;
        btnOpenTuition.Text = "Mở công nợ";
        btnOpenTuition.UseVisualStyleBackColor = true;
        btnOpenTuition.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // cardActiveCourseNote
        // 
        cardActiveCourseNote.BackColor = System.Drawing.Color.White;
        cardActiveCourseNote.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardActiveCourseNote.BorderWidth = 1;
        cardActiveCourseNote.Controls.Add(lblActiveCourseDesc);
        cardActiveCourseNote.Controls.Add(lblActiveCourseBadge);
        cardActiveCourseNote.Controls.Add(lblActiveCourseTitle);
        cardActiveCourseNote.CornerRadius = 6;
        cardActiveCourseNote.Dock = System.Windows.Forms.DockStyle.Fill;
        cardActiveCourseNote.Location = new System.Drawing.Point(636, 3);
        cardActiveCourseNote.Name = "cardActiveCourseNote";
        cardActiveCourseNote.Padding = new System.Windows.Forms.Padding(16);
        cardActiveCourseNote.Size = new System.Drawing.Size(513, 164);
        cardActiveCourseNote.TabIndex = 1;
        // 
        // lblActiveCourseDesc
        // 
        lblActiveCourseDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblActiveCourseDesc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblActiveCourseDesc.Location = new System.Drawing.Point(16, 68);
        lblActiveCourseDesc.Name = "lblActiveCourseDesc";
        lblActiveCourseDesc.Size = new System.Drawing.Size(480, 50);
        lblActiveCourseDesc.TabIndex = 2;
        lblActiveCourseDesc.Text = ("Nguyễn Minh Anh mới học 8/24 buổi, chưa có điểm cuối khóa. Không đưa vào danh sác" + "h cấp của IELTS-F02.");
        // 
        // lblActiveCourseBadge
        // 
        lblActiveCourseBadge.AutoSize = true;
        lblActiveCourseBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblActiveCourseBadge.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
        lblActiveCourseBadge.Location = new System.Drawing.Point(16, 42);
        lblActiveCourseBadge.Name = "lblActiveCourseBadge";
        lblActiveCourseBadge.Size = new System.Drawing.Size(215, 20);
        lblActiveCourseBadge.TabIndex = 1;
        lblActiveCourseBadge.Text = "IELTS-F01 · Chưa đủ điều kiện";
        // 
        // lblActiveCourseTitle
        // 
        lblActiveCourseTitle.AutoSize = true;
        lblActiveCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblActiveCourseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblActiveCourseTitle.Location = new System.Drawing.Point(16, 12);
        lblActiveCourseTitle.Name = "lblActiveCourseTitle";
        lblActiveCourseTitle.Size = new System.Drawing.Size(269, 25);
        lblActiveCourseTitle.TabIndex = 0;
        lblActiveCourseTitle.Text = "Lớp đang học không được cấp";
        // 
        // pnlGridCard
        // 
        pnlGridCard.BackColor = System.Drawing.Color.White;
        pnlGridCard.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        pnlGridCard.BorderWidth = 1;
        pnlGridCard.Controls.Add(lblGridFooter);
        pnlGridCard.Controls.Add(gridEligibility);
        pnlGridCard.Controls.Add(lblGridCardTitle);
        pnlGridCard.CornerRadius = 6;
        pnlGridCard.Dock = System.Windows.Forms.DockStyle.Top;
        pnlGridCard.Location = new System.Drawing.Point(24, 124);
        pnlGridCard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
        pnlGridCard.Name = "pnlGridCard";
        pnlGridCard.Padding = new System.Windows.Forms.Padding(16);
        pnlGridCard.Size = new System.Drawing.Size(1152, 330);
        pnlGridCard.TabIndex = 3;
        // 
        // lblGridFooter
        // 
        lblGridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        lblGridFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblGridFooter.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblGridFooter.Location = new System.Drawing.Point(16, 289);
        lblGridFooter.Name = "lblGridFooter";
        lblGridFooter.Size = new System.Drawing.Size(1120, 25);
        lblGridFooter.TabIndex = 2;
        lblGridFooter.Text = ("1–5 / 20 học viên · 16 đạt, 1 không đạt, 3 chưa đủ điều kiện                     " + "                                                                                " + "           ‹ Trước   [1]   2   Sau ›");
        // 
        // gridEligibility
        // 
        gridEligibility.AllowUserToAddRows = false;
        gridEligibility.AllowUserToDeleteRows = false;
        gridEligibility.AllowUserToResizeColumns = false;
        gridEligibility.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        gridEligibility.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        gridEligibility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        gridEligibility.BackgroundColor = System.Drawing.Color.White;
        gridEligibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
        gridEligibility.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        gridEligibility.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        gridEligibility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        gridEligibility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridEligibility.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStudent, colScores, colAttendance, colDebt, colConclusion, colReason, colAction });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        gridEligibility.DefaultCellStyle = dataGridViewCellStyle3;
        gridEligibility.Dock = System.Windows.Forms.DockStyle.Top;
        gridEligibility.EnableHeadersVisualStyles = false;
        gridEligibility.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        gridEligibility.Location = new System.Drawing.Point(16, 16);
        gridEligibility.MultiSelect = false;
        gridEligibility.Name = "gridEligibility";
        gridEligibility.ReadOnly = true;
        gridEligibility.RowHeadersVisible = false;
        gridEligibility.RowHeadersWidth = 51;
        gridEligibility.ScrollBars = System.Windows.Forms.ScrollBars.None;
        gridEligibility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridEligibility.Size = new System.Drawing.Size(1120, 256);
        gridEligibility.TabIndex = 1;
        // 
        // colStudent
        // 
        colStudent.FillWeight = 20F;
        colStudent.HeaderText = "Học viên ↑";
        colStudent.MinimumWidth = 6;
        colStudent.Name = "colStudent";
        colStudent.ReadOnly = true;
        // 
        // colScores
        // 
        colScores.FillWeight = 14F;
        colScores.HeaderText = "Điểm cuối / TB";
        colScores.MinimumWidth = 6;
        colScores.Name = "colScores";
        colScores.ReadOnly = true;
        // 
        // colAttendance
        // 
        colAttendance.FillWeight = 16F;
        colAttendance.HeaderText = "Tham dự";
        colAttendance.MinimumWidth = 6;
        colAttendance.Name = "colAttendance";
        colAttendance.ReadOnly = true;
        // 
        // colDebt
        // 
        colDebt.FillWeight = 12F;
        colDebt.HeaderText = "Còn nợ";
        colDebt.MinimumWidth = 6;
        colDebt.Name = "colDebt";
        colDebt.ReadOnly = true;
        // 
        // colConclusion
        // 
        colConclusion.FillWeight = 14F;
        colConclusion.HeaderText = "Kết luận";
        colConclusion.MinimumWidth = 6;
        colConclusion.Name = "colConclusion";
        colConclusion.ReadOnly = true;
        // 
        // colReason
        // 
        colReason.FillWeight = 24F;
        colReason.HeaderText = "Lý do / sửa ở đâu";
        colReason.MinimumWidth = 6;
        colReason.Name = "colReason";
        colReason.ReadOnly = true;
        // 
        // colAction
        // 
        colAction.FillWeight = 12F;
        colAction.HeaderText = "Thao tác";
        colAction.MinimumWidth = 6;
        colAction.Name = "colAction";
        colAction.ReadOnly = true;
        colAction.Text = "Cấp bằng";
        colAction.UseColumnTextForButtonValue = true;
        // 
        // lblGridCardTitle
        // 
        lblGridCardTitle.AutoSize = true;
        lblGridCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblGridCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblGridCardTitle.Location = new System.Drawing.Point(16, 12);
        lblGridCardTitle.Name = "lblGridCardTitle";
        lblGridCardTitle.Size = new System.Drawing.Size(200, 25);
        lblGridCardTitle.TabIndex = 0;
        lblGridCardTitle.Text = "Kết quả xét điều kiện";
        // 
        // pnlStepper
        // 
        pnlStepper.BackColor = System.Drawing.Color.White;
        pnlStepper.Controls.Add(lblStep4);
        pnlStepper.Controls.Add(lblStep3);
        pnlStepper.Controls.Add(lblStep2);
        pnlStepper.Controls.Add(lblStep1);
        pnlStepper.Dock = System.Windows.Forms.DockStyle.Top;
        pnlStepper.Location = new System.Drawing.Point(24, 86);
        pnlStepper.Name = "pnlStepper";
        pnlStepper.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        pnlStepper.Size = new System.Drawing.Size(1152, 38);
        pnlStepper.TabIndex = 1;
        // 
        // lblStep4
        // 
        lblStep4.AutoSize = true;
        lblStep4.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStep4.Location = new System.Drawing.Point(640, 10);
        lblStep4.Name = "lblStep4";
        lblStep4.Size = new System.Drawing.Size(109, 20);
        lblStep4.TabIndex = 3;
        lblStep4.Text = "4. Xem trước in";
        // 
        // lblStep3
        // 
        lblStep3.AutoSize = true;
        lblStep3.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStep3.Location = new System.Drawing.Point(440, 10);
        lblStep3.Name = "lblStep3";
        lblStep3.Size = new System.Drawing.Size(109, 20);
        lblStep3.TabIndex = 2;
        lblStep3.Text = "3. Sổ chứng chỉ";
        // 
        // lblStep2
        // 
        lblStep2.AutoSize = true;
        lblStep2.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        lblStep2.Location = new System.Drawing.Point(240, 10);
        lblStep2.Name = "lblStep2";
        lblStep2.Size = new System.Drawing.Size(91, 20);
        lblStep2.TabIndex = 1;
        lblStep2.Text = "2. Duyệt cấp";
        // 
        // lblStep1
        // 
        lblStep1.AutoSize = true;
        lblStep1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        lblStep1.Location = new System.Drawing.Point(16, 10);
        lblStep1.Name = "lblStep1";
        lblStep1.Size = new System.Drawing.Size(163, 20);
        lblStep1.TabIndex = 0;
        lblStep1.Text = "• 1. Kiểm tra điều kiện";
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(pnlTopActions);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1152, 70);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(0, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(357, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Xét hoàn thành · IELTS-F02";
        // 
        // pnlTopActions
        // 
        pnlTopActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        pnlTopActions.Controls.Add(btnApproveEligible);
        pnlTopActions.Controls.Add(btnRecheck);
        pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        pnlTopActions.Location = new System.Drawing.Point(822, 12);
        pnlTopActions.Name = "pnlTopActions";
        pnlTopActions.Size = new System.Drawing.Size(330, 48);
        pnlTopActions.TabIndex = 3;
        // 
        // btnApproveEligible
        // 
        btnApproveEligible.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnApproveEligible.CornerRadius = 5;
        btnApproveEligible.Cursor = System.Windows.Forms.Cursors.Hand;
        btnApproveEligible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnApproveEligible.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnApproveEligible.Location = new System.Drawing.Point(167, 3);
        btnApproveEligible.Name = "btnApproveEligible";
        btnApproveEligible.Size = new System.Drawing.Size(160, 38);
        btnApproveEligible.TabIndex = 0;
        btnApproveEligible.Text = "Duyệt học viên đạt";
        btnApproveEligible.UseVisualStyleBackColor = true;
        btnApproveEligible.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnRecheck
        // 
        btnRecheck.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnRecheck.CornerRadius = 5;
        btnRecheck.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRecheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRecheck.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnRecheck.Location = new System.Drawing.Point(41, 3);
        btnRecheck.Name = "btnRecheck";
        btnRecheck.Size = new System.Drawing.Size(120, 38);
        btnRecheck.TabIndex = 1;
        btnRecheck.Text = "Kiểm tra lại";
        btnRecheck.UseVisualStyleBackColor = true;
        btnRecheck.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // CertificateManagementView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        Controls.Add(pnlMain);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Size = new System.Drawing.Size(1200, 900);
        pnlMain.ResumeLayout(false);
        pnlBottomInfo.ResumeLayout(false);
        cardBlockedInfo.ResumeLayout(false);
        pnlShortcutActions.ResumeLayout(false);
        cardActiveCourseNote.ResumeLayout(false);
        cardActiveCourseNote.PerformLayout();
        pnlGridCard.ResumeLayout(false);
        pnlGridCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridEligibility).EndInit();
        pnlStepper.ResumeLayout(false);
        pnlStepper.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTopActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
    private ECMS.UI.Controls.AppButton btnApproveEligible;
    private ECMS.UI.Controls.AppButton btnRecheck;
    private System.Windows.Forms.Panel pnlStepper;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblStep3;
    private System.Windows.Forms.Label lblStep4;
    private ECMS.UI.Controls.AppCard pnlGridCard;
    private System.Windows.Forms.Label lblGridCardTitle;
    private ECMS.UI.Controls.AppDataGrid gridEligibility;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
    private System.Windows.Forms.DataGridViewTextBoxColumn colScores;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAttendance;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDebt;
    private System.Windows.Forms.DataGridViewTextBoxColumn colConclusion;
    private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
    private System.Windows.Forms.DataGridViewButtonColumn colAction;
    private System.Windows.Forms.Label lblGridFooter;
    private System.Windows.Forms.TableLayoutPanel pnlBottomInfo;
    private ECMS.UI.Controls.AppCard cardBlockedInfo;
    private System.Windows.Forms.FlowLayoutPanel pnlShortcutActions;
    private ECMS.UI.Controls.AppButton btnOpenGrades;
    private ECMS.UI.Controls.AppButton btnOpenAttendance;
    private ECMS.UI.Controls.AppButton btnOpenTuition;
    private ECMS.UI.Controls.AppCard cardActiveCourseNote;
    private System.Windows.Forms.Label lblActiveCourseTitle;
    private System.Windows.Forms.Label lblActiveCourseBadge;
    private System.Windows.Forms.Label lblActiveCourseDesc;
}
