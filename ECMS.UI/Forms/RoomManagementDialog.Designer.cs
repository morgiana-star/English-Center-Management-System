namespace ECMS.UI.Forms;

partial class RoomManagementDialog
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
        btnAddRoom = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardEditRoom = new ECMS.UI.Controls.AppCard();
        btnSaveRoom = new ECMS.UI.Controls.AppButton();
        btnCancelEdit = new ECMS.UI.Controls.AppButton();
        txtRoomNotes = new ECMS.UI.Controls.AppTextBox();
        lblRoomNotes = new System.Windows.Forms.Label();
        cboRoomStatus = new ECMS.UI.Controls.AppComboBox();
        lblRoomStatus = new System.Windows.Forms.Label();
        txtRoomName = new ECMS.UI.Controls.AppTextBox();
        lblRoomName = new System.Windows.Forms.Label();
        txtRoomCapacity = new ECMS.UI.Controls.AppTextBox();
        lblRoomCapacity = new System.Windows.Forms.Label();
        txtRoomCode = new ECMS.UI.Controls.AppTextBox();
        lblRoomCode = new System.Windows.Forms.Label();
        lblEditRoomTitle = new System.Windows.Forms.Label();
        cardRoomList = new ECMS.UI.Controls.AppCard();
        lblPagingNav = new System.Windows.Forms.Label();
        lblPagingInfo = new System.Windows.Forms.Label();
        dgvRooms = new ECMS.UI.Controls.AppDataGrid();
        cboCapacityFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchRoom = new ECMS.UI.Controls.AppTextBox();
        lblRoomListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardEditRoom.SuspendLayout();
        cardRoomList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(btnAddRoom);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddRoom
        // 
        btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnAddRoom.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnAddRoom.CornerRadius = 5;
        btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddRoom.ForeColor = System.Drawing.Color.White;
        btnAddRoom.Location = new System.Drawing.Point(1060, 20);
        btnAddRoom.Name = "btnAddRoom";
        btnAddRoom.Size = new System.Drawing.Size(136, 36);
        btnAddRoom.TabIndex = 3;
        btnAddRoom.Text = "Thêm phòng";
        btnAddRoom.UseVisualStyleBackColor = false;
        btnAddRoom.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(257, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Quản lý phòng học";
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(cardEditRoom);
        pnlBody.Controls.Add(cardRoomList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1220, 685);
        pnlBody.TabIndex = 1;
        // 
        // cardEditRoom
        // 
        cardEditRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cardEditRoom.BackColor = System.Drawing.Color.White;
        cardEditRoom.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardEditRoom.BorderWidth = 1;
        cardEditRoom.Controls.Add(btnSaveRoom);
        cardEditRoom.Controls.Add(btnCancelEdit);
        cardEditRoom.Controls.Add(txtRoomNotes);
        cardEditRoom.Controls.Add(lblRoomNotes);
        cardEditRoom.Controls.Add(cboRoomStatus);
        cardEditRoom.Controls.Add(lblRoomStatus);
        cardEditRoom.Controls.Add(txtRoomName);
        cardEditRoom.Controls.Add(lblRoomName);
        cardEditRoom.Controls.Add(txtRoomCapacity);
        cardEditRoom.Controls.Add(lblRoomCapacity);
        cardEditRoom.Controls.Add(txtRoomCode);
        cardEditRoom.Controls.Add(lblRoomCode);
        cardEditRoom.Controls.Add(lblEditRoomTitle);
        cardEditRoom.CornerRadius = 6;
        cardEditRoom.Location = new System.Drawing.Point(740, 24);
        cardEditRoom.Name = "cardEditRoom";
        cardEditRoom.Padding = new System.Windows.Forms.Padding(24);
        cardEditRoom.Size = new System.Drawing.Size(456, 560);
        cardEditRoom.TabIndex = 1;
        // 
        // btnSaveRoom
        // 
        btnSaveRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSaveRoom.BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        btnSaveRoom.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnSaveRoom.CornerRadius = 5;
        btnSaveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSaveRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveRoom.ForeColor = System.Drawing.Color.White;
        btnSaveRoom.Location = new System.Drawing.Point(342, 435);
        btnSaveRoom.Name = "btnSaveRoom";
        btnSaveRoom.Size = new System.Drawing.Size(90, 36);
        btnSaveRoom.TabIndex = 12;
        btnSaveRoom.Text = "Lưu";
        btnSaveRoom.UseVisualStyleBackColor = false;
        btnSaveRoom.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        // 
        // btnCancelEdit
        // 
        btnCancelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancelEdit.BackColor = System.Drawing.Color.White;
        btnCancelEdit.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnCancelEdit.CornerRadius = 5;
        btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelEdit.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        btnCancelEdit.Location = new System.Drawing.Point(252, 435);
        btnCancelEdit.Name = "btnCancelEdit";
        btnCancelEdit.Size = new System.Drawing.Size(80, 36);
        btnCancelEdit.TabIndex = 11;
        btnCancelEdit.Text = "Hủy";
        btnCancelEdit.UseVisualStyleBackColor = false;
        btnCancelEdit.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        // 
        // txtRoomNotes
        // 
        txtRoomNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtRoomNotes.BackColor = System.Drawing.Color.Transparent;
        txtRoomNotes.CornerRadius = 5;
        txtRoomNotes.ErrorMessage = "";
        txtRoomNotes.HasError = false;
        txtRoomNotes.Location = new System.Drawing.Point(24, 305);
        txtRoomNotes.Name = "txtRoomNotes";
        txtRoomNotes.Placeholder = "Nhập ghi chú trang thiết bị, vị trí...";
        txtRoomNotes.ReadOnly = false;
        txtRoomNotes.Size = new System.Drawing.Size(408, 35);
        txtRoomNotes.TabIndex = 10;
        txtRoomNotes.UseSystemPasswordChar = false;
        // 
        // lblRoomNotes
        // 
        lblRoomNotes.AutoSize = true;
        lblRoomNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomNotes.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoomNotes.Location = new System.Drawing.Point(24, 285);
        lblRoomNotes.Name = "lblRoomNotes";
        lblRoomNotes.Size = new System.Drawing.Size(62, 20);
        lblRoomNotes.TabIndex = 9;
        lblRoomNotes.Text = "Ghi chú";
        // 
        // cboRoomStatus
        // 
        cboRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cboRoomStatus.BackColor = System.Drawing.Color.Transparent;
        cboRoomStatus.CornerRadius = 5;
        cboRoomStatus.DataSource = null;
        cboRoomStatus.DisplayMember = "";
        cboRoomStatus.Location = new System.Drawing.Point(24, 225);
        cboRoomStatus.Name = "cboRoomStatus";
        cboRoomStatus.SelectedIndex = -1;
        cboRoomStatus.SelectedItem = null;
        cboRoomStatus.SelectedValue = null;
        cboRoomStatus.Size = new System.Drawing.Size(408, 35);
        cboRoomStatus.TabIndex = 8;
        cboRoomStatus.ValueMember = "";
        // 
        // lblRoomStatus
        // 
        lblRoomStatus.AutoSize = true;
        lblRoomStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoomStatus.Location = new System.Drawing.Point(24, 205);
        lblRoomStatus.Name = "lblRoomStatus";
        lblRoomStatus.Size = new System.Drawing.Size(91, 20);
        lblRoomStatus.TabIndex = 7;
        lblRoomStatus.Text = "Trạng thái *";
        // 
        // txtRoomName
        // 
        txtRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtRoomName.BackColor = System.Drawing.Color.Transparent;
        txtRoomName.CornerRadius = 5;
        txtRoomName.ErrorMessage = "";
        txtRoomName.HasError = false;
        txtRoomName.Location = new System.Drawing.Point(24, 145);
        txtRoomName.Name = "txtRoomName";
        txtRoomName.Placeholder = "Ví dụ: Phòng IELTS";
        txtRoomName.ReadOnly = false;
        txtRoomName.Size = new System.Drawing.Size(408, 35);
        txtRoomName.TabIndex = 6;
        txtRoomName.UseSystemPasswordChar = false;
        // 
        // lblRoomName
        // 
        lblRoomName.AutoSize = true;
        lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoomName.Location = new System.Drawing.Point(24, 125);
        lblRoomName.Name = "lblRoomName";
        lblRoomName.Size = new System.Drawing.Size(94, 20);
        lblRoomName.TabIndex = 5;
        lblRoomName.Text = "Tên phòng *";
        // 
        // txtRoomCapacity
        // 
        txtRoomCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        txtRoomCapacity.BackColor = System.Drawing.Color.Transparent;
        txtRoomCapacity.CornerRadius = 5;
        txtRoomCapacity.ErrorMessage = "";
        txtRoomCapacity.HasError = false;
        txtRoomCapacity.Location = new System.Drawing.Point(240, 68);
        txtRoomCapacity.Name = "txtRoomCapacity";
        txtRoomCapacity.Placeholder = "Ví dụ: 24";
        txtRoomCapacity.ReadOnly = false;
        txtRoomCapacity.Size = new System.Drawing.Size(192, 35);
        txtRoomCapacity.TabIndex = 4;
        txtRoomCapacity.UseSystemPasswordChar = false;
        // 
        // lblRoomCapacity
        // 
        lblRoomCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblRoomCapacity.AutoSize = true;
        lblRoomCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoomCapacity.Location = new System.Drawing.Point(240, 48);
        lblRoomCapacity.Name = "lblRoomCapacity";
        lblRoomCapacity.Size = new System.Drawing.Size(83, 20);
        lblRoomCapacity.TabIndex = 3;
        lblRoomCapacity.Text = "Sức chứa *";
        // 
        // txtRoomCode
        // 
        txtRoomCode.BackColor = System.Drawing.Color.Transparent;
        txtRoomCode.CornerRadius = 5;
        txtRoomCode.ErrorMessage = "";
        txtRoomCode.HasError = false;
        txtRoomCode.Location = new System.Drawing.Point(24, 68);
        txtRoomCode.Name = "txtRoomCode";
        txtRoomCode.Placeholder = "Ví dụ: P201";
        txtRoomCode.ReadOnly = false;
        txtRoomCode.Size = new System.Drawing.Size(192, 35);
        txtRoomCode.TabIndex = 2;
        txtRoomCode.UseSystemPasswordChar = false;
        // 
        // lblRoomCode
        // 
        lblRoomCode.AutoSize = true;
        lblRoomCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)73)), ((int)((byte)80)), ((int)((byte)87)));
        lblRoomCode.Location = new System.Drawing.Point(24, 48);
        lblRoomCode.Name = "lblRoomCode";
        lblRoomCode.Size = new System.Drawing.Size(91, 20);
        lblRoomCode.TabIndex = 1;
        lblRoomCode.Text = "Mã phòng *";
        // 
        // lblEditRoomTitle
        // 
        lblEditRoomTitle.AutoSize = true;
        lblEditRoomTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblEditRoomTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblEditRoomTitle.Location = new System.Drawing.Point(24, 16);
        lblEditRoomTitle.Name = "lblEditRoomTitle";
        lblEditRoomTitle.Size = new System.Drawing.Size(185, 28);
        lblEditRoomTitle.TabIndex = 0;
        lblEditRoomTitle.Text = "Thêm / sửa phòng";
        // 
        // cardRoomList
        // 
        cardRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        cardRoomList.BackColor = System.Drawing.Color.White;
        cardRoomList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRoomList.BorderWidth = 1;
        cardRoomList.Controls.Add(lblPagingNav);
        cardRoomList.Controls.Add(lblPagingInfo);
        cardRoomList.Controls.Add(dgvRooms);
        cardRoomList.Controls.Add(cboCapacityFilter);
        cardRoomList.Controls.Add(cboStatusFilter);
        cardRoomList.Controls.Add(txtSearchRoom);
        cardRoomList.Controls.Add(lblRoomListTitle);
        cardRoomList.CornerRadius = 6;
        cardRoomList.Location = new System.Drawing.Point(24, 24);
        cardRoomList.Name = "cardRoomList";
        cardRoomList.Padding = new System.Windows.Forms.Padding(20);
        cardRoomList.Size = new System.Drawing.Size(696, 560);
        cardRoomList.TabIndex = 0;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)119)), ((int)((byte)242)));
        lblPagingNav.Location = new System.Drawing.Point(518, 520);
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
        lblPagingInfo.Location = new System.Drawing.Point(23, 520);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(102, 20);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–4 / 4 phòng";
        // 
        // dgvRooms
        // 
        dgvRooms.AllowUserToAddRows = false;
        dgvRooms.AllowUserToDeleteRows = false;
        dgvRooms.AllowUserToResizeColumns = false;
        dgvRooms.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvRooms.BackgroundColor = System.Drawing.Color.White;
        dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
        dgvRooms.EnableHeadersVisualStyles = false;
        dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvRooms.Location = new System.Drawing.Point(20, 95);
        dgvRooms.MultiSelect = false;
        dgvRooms.Name = "dgvRooms";
        dgvRooms.ReadOnly = true;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvRooms.RowHeadersVisible = false;
        dgvRooms.RowHeadersWidth = 51;
        dgvRooms.ScrollBars = System.Windows.Forms.ScrollBars.None;
        dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvRooms.Size = new System.Drawing.Size(656, 422);
        dgvRooms.TabIndex = 4;
        // 
        // cboCapacityFilter
        // 
        cboCapacityFilter.BackColor = System.Drawing.Color.Transparent;
        cboCapacityFilter.CornerRadius = 5;
        cboCapacityFilter.DataSource = null;
        cboCapacityFilter.DisplayMember = "";
        cboCapacityFilter.Location = new System.Drawing.Point(475, 52);
        cboCapacityFilter.Name = "cboCapacityFilter";
        cboCapacityFilter.SelectedIndex = -1;
        cboCapacityFilter.SelectedItem = null;
        cboCapacityFilter.SelectedValue = null;
        cboCapacityFilter.Size = new System.Drawing.Size(155, 35);
        cboCapacityFilter.TabIndex = 3;
        cboCapacityFilter.ValueMember = "";
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
        // txtSearchRoom
        // 
        txtSearchRoom.BackColor = System.Drawing.Color.Transparent;
        txtSearchRoom.CornerRadius = 5;
        txtSearchRoom.ErrorMessage = "";
        txtSearchRoom.HasError = false;
        txtSearchRoom.Location = new System.Drawing.Point(20, 52);
        txtSearchRoom.Name = "txtSearchRoom";
        txtSearchRoom.Placeholder = "🔍  Tìm mã hoặc tên phòng...";
        txtSearchRoom.ReadOnly = false;
        txtSearchRoom.Size = new System.Drawing.Size(280, 35);
        txtSearchRoom.TabIndex = 1;
        txtSearchRoom.UseSystemPasswordChar = false;
        // 
        // lblRoomListTitle
        // 
        lblRoomListTitle.AutoSize = true;
        lblRoomListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRoomListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        lblRoomListTitle.Location = new System.Drawing.Point(20, 16);
        lblRoomListTitle.Name = "lblRoomListTitle";
        lblRoomListTitle.Size = new System.Drawing.Size(176, 28);
        lblRoomListTitle.TabIndex = 0;
        lblRoomListTitle.Text = "Danh sách phòng";
        // 
        // RoomManagementDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý phòng học";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardEditRoom.ResumeLayout(false);
        cardEditRoom.PerformLayout();
        cardRoomList.ResumeLayout(false);
        cardRoomList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private ECMS.UI.Controls.AppButton btnAddRoom;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardRoomList;
    private System.Windows.Forms.Label lblRoomListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchRoom;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboCapacityFilter;
    private ECMS.UI.Controls.AppDataGrid dgvRooms;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppCard cardEditRoom;
    private System.Windows.Forms.Label lblEditRoomTitle;
    private System.Windows.Forms.Label lblRoomCode;
    private ECMS.UI.Controls.AppTextBox txtRoomCode;
    private System.Windows.Forms.Label lblRoomCapacity;
    private ECMS.UI.Controls.AppTextBox txtRoomCapacity;
    private System.Windows.Forms.Label lblRoomName;
    private ECMS.UI.Controls.AppTextBox txtRoomName;
    private System.Windows.Forms.Label lblRoomStatus;
    private ECMS.UI.Controls.AppComboBox cboRoomStatus;
    private System.Windows.Forms.Label lblRoomNotes;
    private ECMS.UI.Controls.AppTextBox txtRoomNotes;
    private ECMS.UI.Controls.AppButton btnCancelEdit;
    private ECMS.UI.Controls.AppButton btnSaveRoom;
}
