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
        pnlHeader = new System.Windows.Forms.Panel();
        btnAddRoom = new ECMS.UI.Controls.AppButton();
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardEditRoom = new ECMS.UI.Controls.AppCard();
        bannerRoomSuccess = new ECMS.UI.Controls.AppBanner();
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
        bannerRoomWarning = new ECMS.UI.Controls.AppBanner();
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
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1220, 75);
        pnlHeader.TabIndex = 0;
        // 
        // btnAddRoom
        // 
        btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddRoom.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnAddRoom.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnAddRoom.ForeColor = System.Drawing.Color.White;
        btnAddRoom.Location = new System.Drawing.Point(1060, 20);
        btnAddRoom.Name = "btnAddRoom";
        btnAddRoom.Size = new System.Drawing.Size(136, 36);
        btnAddRoom.TabIndex = 3;
        btnAddRoom.Text = "Thêm phòng";
        btnAddRoom.UseVisualStyleBackColor = false;
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
        lblTitle.Size = new System.Drawing.Size(199, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Quản lý phòng học";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(225, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Lịch học & Phòng học / Quản lý phòng học";
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
        cardEditRoom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardEditRoom.BackColor = System.Drawing.Color.White;
        cardEditRoom.Controls.Add(bannerRoomSuccess);
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
        cardEditRoom.Location = new System.Drawing.Point(740, 24);
        cardEditRoom.Name = "cardEditRoom";
        cardEditRoom.Padding = new System.Windows.Forms.Padding(24);
        cardEditRoom.Size = new System.Drawing.Size(456, 560);
        cardEditRoom.TabIndex = 1;
        // 
        // bannerRoomSuccess
        // 
        bannerRoomSuccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerRoomSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        bannerRoomSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerRoomSuccess.Location = new System.Drawing.Point(24, 490);
        bannerRoomSuccess.Message = "✓  Đã lưu thông tin P201. Lịch cũ được giữ nguyên.";
        bannerRoomSuccess.Name = "bannerRoomSuccess";
        bannerRoomSuccess.Size = new System.Drawing.Size(408, 45);
        bannerRoomSuccess.TabIndex = 13;
        // 
        // btnSaveRoom
        // 
        btnSaveRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSaveRoom.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnSaveRoom.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnSaveRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSaveRoom.ForeColor = System.Drawing.Color.White;
        btnSaveRoom.Location = new System.Drawing.Point(342, 435);
        btnSaveRoom.Name = "btnSaveRoom";
        btnSaveRoom.Size = new System.Drawing.Size(90, 36);
        btnSaveRoom.TabIndex = 12;
        btnSaveRoom.Text = "Lưu";
        btnSaveRoom.UseVisualStyleBackColor = false;
        // 
        // btnCancelEdit
        // 
        btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancelEdit.BackColor = System.Drawing.Color.White;
        btnCancelEdit.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancelEdit.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancelEdit.Location = new System.Drawing.Point(252, 435);
        btnCancelEdit.Name = "btnCancelEdit";
        btnCancelEdit.Size = new System.Drawing.Size(80, 36);
        btnCancelEdit.TabIndex = 11;
        btnCancelEdit.Text = "Hủy";
        btnCancelEdit.UseVisualStyleBackColor = false;
        // 
        // txtRoomNotes
        // 
        txtRoomNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtRoomNotes.Location = new System.Drawing.Point(24, 305);
        txtRoomNotes.Name = "txtRoomNotes";
        txtRoomNotes.Placeholder = "Nhập ghi chú trang thiết bị, vị trí...";
        txtRoomNotes.Size = new System.Drawing.Size(408, 35);
        txtRoomNotes.TabIndex = 10;
        // 
        // lblRoomNotes
        // 
        lblRoomNotes.AutoSize = true;
        lblRoomNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomNotes.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoomNotes.Location = new System.Drawing.Point(24, 285);
        lblRoomNotes.Name = "lblRoomNotes";
        lblRoomNotes.Size = new System.Drawing.Size(48, 15);
        lblRoomNotes.TabIndex = 9;
        lblRoomNotes.Text = "Ghi chú";
        // 
        // cboRoomStatus
        // 
        cboRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboRoomStatus.Location = new System.Drawing.Point(24, 225);
        cboRoomStatus.Name = "cboRoomStatus";
        cboRoomStatus.Size = new System.Drawing.Size(408, 35);
        cboRoomStatus.TabIndex = 8;
        // 
        // lblRoomStatus
        // 
        lblRoomStatus.AutoSize = true;
        lblRoomStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomStatus.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoomStatus.Location = new System.Drawing.Point(24, 205);
        lblRoomStatus.Name = "lblRoomStatus";
        lblRoomStatus.Size = new System.Drawing.Size(74, 15);
        lblRoomStatus.TabIndex = 7;
        lblRoomStatus.Text = "Trạng thái *";
        // 
        // txtRoomName
        // 
        txtRoomName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtRoomName.Location = new System.Drawing.Point(24, 145);
        txtRoomName.Name = "txtRoomName";
        txtRoomName.Placeholder = "Ví dụ: Phòng IELTS";
        txtRoomName.Size = new System.Drawing.Size(408, 35);
        txtRoomName.TabIndex = 6;
        // 
        // lblRoomName
        // 
        lblRoomName.AutoSize = true;
        lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoomName.Location = new System.Drawing.Point(24, 125);
        lblRoomName.Name = "lblRoomName";
        lblRoomName.Size = new System.Drawing.Size(76, 15);
        lblRoomName.TabIndex = 5;
        lblRoomName.Text = "Tên phòng *";
        // 
        // txtRoomCapacity
        // 
        txtRoomCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtRoomCapacity.Location = new System.Drawing.Point(240, 68);
        txtRoomCapacity.Name = "txtRoomCapacity";
        txtRoomCapacity.Placeholder = "Ví dụ: 24";
        txtRoomCapacity.Size = new System.Drawing.Size(192, 35);
        txtRoomCapacity.TabIndex = 4;
        // 
        // lblRoomCapacity
        // 
        lblRoomCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblRoomCapacity.AutoSize = true;
        lblRoomCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomCapacity.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoomCapacity.Location = new System.Drawing.Point(240, 48);
        lblRoomCapacity.Name = "lblRoomCapacity";
        lblRoomCapacity.Size = new System.Drawing.Size(65, 15);
        lblRoomCapacity.TabIndex = 3;
        lblRoomCapacity.Text = "Sức chứa *";
        // 
        // txtRoomCode
        // 
        txtRoomCode.Location = new System.Drawing.Point(24, 68);
        txtRoomCode.Name = "txtRoomCode";
        txtRoomCode.Placeholder = "Ví dụ: P201";
        txtRoomCode.Size = new System.Drawing.Size(192, 35);
        txtRoomCode.TabIndex = 2;
        // 
        // lblRoomCode
        // 
        lblRoomCode.AutoSize = true;
        lblRoomCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRoomCode.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblRoomCode.Location = new System.Drawing.Point(24, 48);
        lblRoomCode.Name = "lblRoomCode";
        lblRoomCode.Size = new System.Drawing.Size(73, 15);
        lblRoomCode.TabIndex = 1;
        lblRoomCode.Text = "Mã phòng *";
        // 
        // lblEditRoomTitle
        // 
        lblEditRoomTitle.AutoSize = true;
        lblEditRoomTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblEditRoomTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblEditRoomTitle.Location = new System.Drawing.Point(24, 16);
        lblEditRoomTitle.Name = "lblEditRoomTitle";
        lblEditRoomTitle.Size = new System.Drawing.Size(149, 21);
        lblEditRoomTitle.TabIndex = 0;
        lblEditRoomTitle.Text = "Thêm / sửa phòng";
        // 
        // cardRoomList
        // 
        cardRoomList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardRoomList.BackColor = System.Drawing.Color.White;
        cardRoomList.Controls.Add(bannerRoomWarning);
        cardRoomList.Controls.Add(lblPagingNav);
        cardRoomList.Controls.Add(lblPagingInfo);
        cardRoomList.Controls.Add(dgvRooms);
        cardRoomList.Controls.Add(cboCapacityFilter);
        cardRoomList.Controls.Add(cboStatusFilter);
        cardRoomList.Controls.Add(txtSearchRoom);
        cardRoomList.Controls.Add(lblRoomListTitle);
        cardRoomList.Location = new System.Drawing.Point(24, 24);
        cardRoomList.Name = "cardRoomList";
        cardRoomList.Padding = new System.Windows.Forms.Padding(20);
        cardRoomList.Size = new System.Drawing.Size(696, 560);
        cardRoomList.TabIndex = 0;
        // 
        // bannerRoomWarning
        // 
        bannerRoomWarning.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerRoomWarning.Variant = ECMS.UI.Controls.BannerVariant.Warning;
        bannerRoomWarning.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        bannerRoomWarning.Location = new System.Drawing.Point(20, 490);
        bannerRoomWarning.Message = "Không được xóa phòng có lịch đã phát sinh. Ngừng sử dụng chỉ chặn lịch mới.";
        bannerRoomWarning.Name = "bannerRoomWarning";
        bannerRoomWarning.Size = new System.Drawing.Size(656, 45);
        bannerRoomWarning.TabIndex = 7;
        // 
        // lblPagingNav
        // 
        lblPagingNav.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        lblPagingNav.AutoSize = true;
        lblPagingNav.Cursor = System.Windows.Forms.Cursors.Hand;
        lblPagingNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPagingNav.ForeColor = System.Drawing.Color.FromArgb(24, 119, 242);
        lblPagingNav.Location = new System.Drawing.Point(554, 450);
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
        lblPagingInfo.Location = new System.Drawing.Point(20, 450);
        lblPagingInfo.Name = "lblPagingInfo";
        lblPagingInfo.Size = new System.Drawing.Size(89, 15);
        lblPagingInfo.TabIndex = 5;
        lblPagingInfo.Text = "1–4 / 4 phòng";
        // 
        // dgvRooms
        // 
        dgvRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRooms.Location = new System.Drawing.Point(20, 95);
        dgvRooms.Name = "dgvRooms";
        dgvRooms.Size = new System.Drawing.Size(656, 340);
        dgvRooms.TabIndex = 4;
        // 
        // cboCapacityFilter
        // 
        cboCapacityFilter.Location = new System.Drawing.Point(475, 52);
        cboCapacityFilter.Name = "cboCapacityFilter";
        cboCapacityFilter.Size = new System.Drawing.Size(155, 35);
        cboCapacityFilter.TabIndex = 3;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.Location = new System.Drawing.Point(310, 52);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new System.Drawing.Size(155, 35);
        cboStatusFilter.TabIndex = 2;
        // 
        // txtSearchRoom
        // 
        txtSearchRoom.Location = new System.Drawing.Point(20, 52);
        txtSearchRoom.Name = "txtSearchRoom";
        txtSearchRoom.Placeholder = "🔍  Tìm mã hoặc tên phòng...";
        txtSearchRoom.Size = new System.Drawing.Size(280, 35);
        txtSearchRoom.TabIndex = 1;
        // 
        // lblRoomListTitle
        // 
        lblRoomListTitle.AutoSize = true;
        lblRoomListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRoomListTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblRoomListTitle.Location = new System.Drawing.Point(20, 16);
        lblRoomListTitle.Name = "lblRoomListTitle";
        lblRoomListTitle.Size = new System.Drawing.Size(144, 21);
        lblRoomListTitle.TabIndex = 0;
        lblRoomListTitle.Text = "Danh sách phòng";
        // 
        // RoomManagementDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1220, 760);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RoomManagementDialog";
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
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardRoomList;
    private System.Windows.Forms.Label lblRoomListTitle;
    private ECMS.UI.Controls.AppTextBox txtSearchRoom;
    private ECMS.UI.Controls.AppComboBox cboStatusFilter;
    private ECMS.UI.Controls.AppComboBox cboCapacityFilter;
    private ECMS.UI.Controls.AppDataGrid dgvRooms;
    private System.Windows.Forms.Label lblPagingInfo;
    private System.Windows.Forms.Label lblPagingNav;
    private ECMS.UI.Controls.AppBanner bannerRoomWarning;
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
    private ECMS.UI.Controls.AppBanner bannerRoomSuccess;
}
