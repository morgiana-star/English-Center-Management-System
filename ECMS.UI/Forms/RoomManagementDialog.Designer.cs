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

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddRoom = new ECMS.UI.Controls.AppButton();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardRoomList = new ECMS.UI.Controls.AppCard();
        dgvRooms = new ECMS.UI.Controls.AppDataGrid();
        colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colAction = new System.Windows.Forms.DataGridViewButtonColumn();
        cboCapacityFilter = new ECMS.UI.Controls.AppComboBox();
        cboStatusFilter = new ECMS.UI.Controls.AppComboBox();
        txtSearchRoom = new ECMS.UI.Controls.AppTextBox();
        lblRoomListTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
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
        pnlHeader.Size = new System.Drawing.Size(1000, 75);
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
        btnAddRoom.Location = new System.Drawing.Point(820, 20);
        btnAddRoom.Name = "btnAddRoom";
        btnAddRoom.Size = new System.Drawing.Size(156, 36);
        btnAddRoom.TabIndex = 3;
        btnAddRoom.Text = "+ Thêm phòng học";
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
        pnlBody.Controls.Add(cardRoomList);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 75);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(24);
        pnlBody.Size = new System.Drawing.Size(1000, 585);
        pnlBody.TabIndex = 1;
        // 
        // cardRoomList
        // 
        cardRoomList.BackColor = System.Drawing.Color.White;
        cardRoomList.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardRoomList.BorderWidth = 1;
        cardRoomList.Controls.Add(dgvRooms);
        cardRoomList.Controls.Add(cboCapacityFilter);
        cardRoomList.Controls.Add(cboStatusFilter);
        cardRoomList.Controls.Add(txtSearchRoom);
        cardRoomList.Controls.Add(lblRoomListTitle);
        cardRoomList.CornerRadius = 6;
        cardRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
        cardRoomList.Location = new System.Drawing.Point(24, 24);
        cardRoomList.Name = "cardRoomList";
        cardRoomList.Padding = new System.Windows.Forms.Padding(20);
        cardRoomList.Size = new System.Drawing.Size(952, 537);
        cardRoomList.TabIndex = 0;
        // 
        // dgvRooms
        // 
        dgvRooms.AllowUserToAddRows = false;
        dgvRooms.AllowUserToDeleteRows = false;
        dgvRooms.AllowUserToResizeColumns = false;
        dgvRooms.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
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
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCode, colName, colCapacity, colEquipment, colStatus, colAction });
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)37)), ((int)((byte)41)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
        dgvRooms.EnableHeadersVisualStyles = false;
        dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)((byte)241)), ((int)((byte)245)), ((int)((byte)249)));
        dgvRooms.Location = new System.Drawing.Point(20, 100);
        dgvRooms.MultiSelect = false;
        dgvRooms.Name = "dgvRooms";
        dgvRooms.ReadOnly = true;
        dgvRooms.RowHeadersVisible = false;
        dgvRooms.RowHeadersWidth = 51;
        dgvRooms.RowTemplate.Height = 44;
        dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvRooms.Size = new System.Drawing.Size(912, 415);
        dgvRooms.TabIndex = 4;
        // 
        // colCode
        // 
        colCode.HeaderText = "Mã phòng";
        colCode.Name = "colCode";
        colCode.ReadOnly = true;
        colCode.Width = 110;
        // 
        // colName
        // 
        colName.HeaderText = "Tên phòng";
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.Width = 200;
        // 
        // colCapacity
        // 
        colCapacity.HeaderText = "Sức chứa";
        colCapacity.Name = "colCapacity";
        colCapacity.ReadOnly = true;
        colCapacity.Width = 110;
        // 
        // colEquipment
        // 
        colEquipment.HeaderText = "Trang thiết bị";
        colEquipment.Name = "colEquipment";
        colEquipment.ReadOnly = true;
        colEquipment.Width = 230;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Trạng thái";
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        colStatus.Width = 130;
        // 
        // colAction
        // 
        colAction.HeaderText = "Thao tác";
        colAction.Name = "colAction";
        colAction.ReadOnly = true;
        colAction.Text = "Sửa";
        colAction.UseColumnTextForButtonValue = true;
        colAction.Width = 90;
        // 
        // cboCapacityFilter
        // 
        cboCapacityFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboCapacityFilter.BackColor = System.Drawing.Color.Transparent;
        cboCapacityFilter.CornerRadius = 5;
        cboCapacityFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboCapacityFilter.Location = new System.Drawing.Point(542, 52);
        cboCapacityFilter.Name = "cboCapacityFilter";
        cboCapacityFilter.Size = new System.Drawing.Size(185, 36);
        cboCapacityFilter.TabIndex = 2;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        cboStatusFilter.BackColor = System.Drawing.Color.Transparent;
        cboStatusFilter.CornerRadius = 5;
        cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
        cboStatusFilter.Location = new System.Drawing.Point(747, 52);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(185, 36);
        cboStatusFilter.TabIndex = 3;
        // 
        // txtSearchRoom
        // 
        txtSearchRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearchRoom.BackColor = System.Drawing.Color.Transparent;
        txtSearchRoom.CornerRadius = 5;
        txtSearchRoom.ErrorMessage = "";
        txtSearchRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
        txtSearchRoom.HasError = false;
        txtSearchRoom.Location = new System.Drawing.Point(20, 52);
        txtSearchRoom.Name = "txtSearchRoom";
        txtSearchRoom.Placeholder = "Tìm kiếm theo mã hoặc tên phòng...";
        txtSearchRoom.ReadOnly = false;
        txtSearchRoom.Size = new System.Drawing.Size(506, 36);
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
        lblRoomListTitle.Size = new System.Drawing.Size(206, 28);
        lblRoomListTitle.TabIndex = 0;
        lblRoomListTitle.Text = "Danh sách phòng học";
        // 
        // RoomManagementDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)250)));
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RoomManagementDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Quản lý phòng học · ECMS";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardRoomList.ResumeLayout(false);
        cardRoomList.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private ECMS.UI.Controls.AppButton btnAddRoom;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardRoomList;
    private System.Windows.Forms.Label lblRoomListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchRoom;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboCapacityFilter;
    private ECMS.UI.Controls.AppDataGrid dgvRooms;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewButtonColumn colAction;
}
