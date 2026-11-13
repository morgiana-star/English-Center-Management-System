namespace ECMS.UI.Forms;

partial class AddTeacherDialog
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
        lblSubtitle = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblBreadcrumb = new System.Windows.Forms.Label();
        pnlContent = new System.Windows.Forms.Panel();
        cardScheduleSetup = new ECMS.UI.Controls.AppCard();
        lblStorageNote = new System.Windows.Forms.Label();
        bannerScheduleInfo = new ECMS.UI.Controls.AppBanner();
        chkWeekend = new System.Windows.Forms.CheckBox();
        chkWedSat = new System.Windows.Forms.CheckBox();
        chkTueFri = new System.Windows.Forms.CheckBox();
        chkMonThu = new System.Windows.Forms.CheckBox();
        lblAvailableDays = new System.Windows.Forms.Label();
        cboPreferredSlot = new ECMS.UI.Controls.AppComboBox();
        lblPreferredSlot = new System.Windows.Forms.Label();
        txtMaxHours = new ECMS.UI.Controls.AppTextBox();
        lblMaxHours = new System.Windows.Forms.Label();
        lblScheduleSetupTitle = new System.Windows.Forms.Label();
        cardTeacherInfo = new ECMS.UI.Controls.AppCard();
        btnSave = new ECMS.UI.Controls.AppButton();
        btnCancel = new ECMS.UI.Controls.AppButton();
        txtBio = new ECMS.UI.Controls.AppTextBox();
        lblBio = new System.Windows.Forms.Label();
        cboStatus = new ECMS.UI.Controls.AppComboBox();
        lblStatus = new System.Windows.Forms.Label();
        txtCert = new ECMS.UI.Controls.AppTextBox();
        lblCert = new System.Windows.Forms.Label();
        cboSpecialty = new ECMS.UI.Controls.AppComboBox();
        lblSpecialty = new System.Windows.Forms.Label();
        txtEmail = new ECMS.UI.Controls.AppTextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtPhone = new ECMS.UI.Controls.AppTextBox();
        lblPhone = new System.Windows.Forms.Label();
        txtFullName = new ECMS.UI.Controls.AppTextBox();
        lblFullName = new System.Windows.Forms.Label();
        txtTeacherCode = new ECMS.UI.Controls.AppTextBox();
        lblTeacherCode = new System.Windows.Forms.Label();
        lblTeacherInfoTitle = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        cardScheduleSetup.SuspendLayout();
        cardTeacherInfo.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblBreadcrumb);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlHeader.Size = new System.Drawing.Size(1200, 75);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblSubtitle.Location = new System.Drawing.Point(24, 48);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(438, 15);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Hồ sơ giáo viên · Chuyên môn, bằng cấp và thiết lập lịch rảnh ban đầu";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTitle.Location = new System.Drawing.Point(22, 18);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(210, 30);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Thêm giáo viên mới";
        // 
        // lblBreadcrumb
        // 
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F);
        lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblBreadcrumb.Location = new System.Drawing.Point(24, 5);
        lblBreadcrumb.Name = "lblBreadcrumb";
        lblBreadcrumb.Size = new System.Drawing.Size(176, 13);
        lblBreadcrumb.TabIndex = 0;
        lblBreadcrumb.Text = "ECMS / Giáo viên / Thêm giáo viên";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.Controls.Add(cardScheduleSetup);
        pnlContent.Controls.Add(cardTeacherInfo);
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 75);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(24);
        pnlContent.Size = new System.Drawing.Size(1200, 675);
        pnlContent.TabIndex = 1;
        // 
        // cardScheduleSetup
        // 
        cardScheduleSetup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardScheduleSetup.BackColor = System.Drawing.Color.White;
        cardScheduleSetup.Controls.Add(lblStorageNote);
        cardScheduleSetup.Controls.Add(bannerScheduleInfo);
        cardScheduleSetup.Controls.Add(chkWeekend);
        cardScheduleSetup.Controls.Add(chkWedSat);
        cardScheduleSetup.Controls.Add(chkTueFri);
        cardScheduleSetup.Controls.Add(chkMonThu);
        cardScheduleSetup.Controls.Add(lblAvailableDays);
        cardScheduleSetup.Controls.Add(cboPreferredSlot);
        cardScheduleSetup.Controls.Add(lblPreferredSlot);
        cardScheduleSetup.Controls.Add(txtMaxHours);
        cardScheduleSetup.Controls.Add(lblMaxHours);
        cardScheduleSetup.Controls.Add(lblScheduleSetupTitle);
        cardScheduleSetup.Location = new System.Drawing.Point(790, 24);
        cardScheduleSetup.Name = "cardScheduleSetup";
        cardScheduleSetup.Padding = new System.Windows.Forms.Padding(24);
        cardScheduleSetup.Size = new System.Drawing.Size(386, 520);
        cardScheduleSetup.TabIndex = 1;
        // 
        // lblStorageNote
        // 
        lblStorageNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblStorageNote.AutoSize = true;
        lblStorageNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        lblStorageNote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
        lblStorageNote.Location = new System.Drawing.Point(24, 475);
        lblStorageNote.Name = "lblStorageNote";
        lblStorageNote.Size = new System.Drawing.Size(325, 15);
        lblStorageNote.TabIndex = 11;
        lblStorageNote.Text = "Dữ liệu được lưu trữ an toàn trong SQLite trên máy trạm cục bộ.";
        // 
        // bannerScheduleInfo
        // 
        bannerScheduleInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerScheduleInfo.Variant = ECMS.UI.Controls.BannerVariant.Info;
        bannerScheduleInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        bannerScheduleInfo.Location = new System.Drawing.Point(24, 375);
        bannerScheduleInfo.Message = "✓  Lịch rảnh sẽ tự động đồng bộ vào ma trận khả dụng khi phân công lớp học.";
        bannerScheduleInfo.Name = "bannerScheduleInfo";
        bannerScheduleInfo.Size = new System.Drawing.Size(338, 70);
        bannerScheduleInfo.TabIndex = 10;
        // 
        // chkWeekend
        // 
        chkWeekend.AutoSize = true;
        chkWeekend.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkWeekend.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        chkWeekend.Location = new System.Drawing.Point(24, 325);
        chkWeekend.Name = "chkWeekend";
        chkWeekend.Size = new System.Drawing.Size(193, 21);
        chkWeekend.TabIndex = 9;
        chkWeekend.Text = "Cuối tuần (Thứ 7 / Chủ Nhật)";
        chkWeekend.UseVisualStyleBackColor = true;
        // 
        // chkWedSat
        // 
        chkWedSat.AutoSize = true;
        chkWedSat.Checked = true;
        chkWedSat.CheckState = System.Windows.Forms.CheckState.Checked;
        chkWedSat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkWedSat.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        chkWedSat.Location = new System.Drawing.Point(24, 290);
        chkWedSat.Name = "chkWedSat";
        chkWedSat.Size = new System.Drawing.Size(147, 21);
        chkWedSat.TabIndex = 8;
        chkWedSat.Text = "Thứ Tư / Thứ Bảy";
        chkWedSat.UseVisualStyleBackColor = true;
        // 
        // chkTueFri
        // 
        chkTueFri.AutoSize = true;
        chkTueFri.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkTueFri.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        chkTueFri.Location = new System.Drawing.Point(24, 255);
        chkTueFri.Name = "chkTueFri";
        chkTueFri.Size = new System.Drawing.Size(143, 21);
        chkTueFri.TabIndex = 7;
        chkTueFri.Text = "Thứ Ba / Thứ Sáu";
        chkTueFri.UseVisualStyleBackColor = true;
        // 
        // chkMonThu
        // 
        chkMonThu.AutoSize = true;
        chkMonThu.Checked = true;
        chkMonThu.CheckState = System.Windows.Forms.CheckState.Checked;
        chkMonThu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkMonThu.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        chkMonThu.Location = new System.Drawing.Point(24, 220);
        chkMonThu.Name = "chkMonThu";
        chkMonThu.Size = new System.Drawing.Size(146, 21);
        chkMonThu.TabIndex = 6;
        chkMonThu.Text = "Thứ Hai / Thứ Năm";
        chkMonThu.UseVisualStyleBackColor = true;
        // 
        // lblAvailableDays
        // 
        lblAvailableDays.AutoSize = true;
        lblAvailableDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblAvailableDays.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblAvailableDays.Location = new System.Drawing.Point(24, 195);
        lblAvailableDays.Name = "lblAvailableDays";
        lblAvailableDays.Size = new System.Drawing.Size(155, 15);
        lblAvailableDays.TabIndex = 5;
        lblAvailableDays.Text = "Các ngày có thể giảng dạy";
        // 
        // cboPreferredSlot
        // 
        cboPreferredSlot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboPreferredSlot.Location = new System.Drawing.Point(24, 145);
        cboPreferredSlot.Name = "cboPreferredSlot";
        cboPreferredSlot.Size = new System.Drawing.Size(338, 35);
        cboPreferredSlot.TabIndex = 4;
        // 
        // lblPreferredSlot
        // 
        lblPreferredSlot.AutoSize = true;
        lblPreferredSlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPreferredSlot.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblPreferredSlot.Location = new System.Drawing.Point(24, 125);
        lblPreferredSlot.Name = "lblPreferredSlot";
        lblPreferredSlot.Size = new System.Drawing.Size(123, 15);
        lblPreferredSlot.TabIndex = 3;
        lblPreferredSlot.Text = "Khung giờ ưu tiên *";
        // 
        // txtMaxHours
        // 
        txtMaxHours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtMaxHours.Location = new System.Drawing.Point(24, 68);
        txtMaxHours.Name = "txtMaxHours";
        txtMaxHours.Placeholder = "Ví dụ: 12 giờ / tuần";
        txtMaxHours.Size = new System.Drawing.Size(338, 35);
        txtMaxHours.TabIndex = 2;
        // 
        // lblMaxHours
        // 
        lblMaxHours.AutoSize = true;
        lblMaxHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblMaxHours.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblMaxHours.Location = new System.Drawing.Point(24, 48);
        lblMaxHours.Name = "lblMaxHours";
        lblMaxHours.Size = new System.Drawing.Size(161, 15);
        lblMaxHours.TabIndex = 1;
        lblMaxHours.Text = "Số giờ dạy tối đa / tuần *";
        // 
        // lblScheduleSetupTitle
        // 
        lblScheduleSetupTitle.AutoSize = true;
        lblScheduleSetupTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblScheduleSetupTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblScheduleSetupTitle.Location = new System.Drawing.Point(24, 16);
        lblScheduleSetupTitle.Name = "lblScheduleSetupTitle";
        lblScheduleSetupTitle.Size = new System.Drawing.Size(209, 21);
        lblScheduleSetupTitle.TabIndex = 0;
        lblScheduleSetupTitle.Text = "Thiết lập lịch rảnh & số giờ";
        // 
        // cardTeacherInfo
        // 
        cardTeacherInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardTeacherInfo.BackColor = System.Drawing.Color.White;
        cardTeacherInfo.Controls.Add(btnSave);
        cardTeacherInfo.Controls.Add(btnCancel);
        cardTeacherInfo.Controls.Add(txtBio);
        cardTeacherInfo.Controls.Add(lblBio);
        cardTeacherInfo.Controls.Add(cboStatus);
        cardTeacherInfo.Controls.Add(lblStatus);
        cardTeacherInfo.Controls.Add(txtCert);
        cardTeacherInfo.Controls.Add(lblCert);
        cardTeacherInfo.Controls.Add(cboSpecialty);
        cardTeacherInfo.Controls.Add(lblSpecialty);
        cardTeacherInfo.Controls.Add(txtEmail);
        cardTeacherInfo.Controls.Add(lblEmail);
        cardTeacherInfo.Controls.Add(txtPhone);
        cardTeacherInfo.Controls.Add(lblPhone);
        cardTeacherInfo.Controls.Add(txtFullName);
        cardTeacherInfo.Controls.Add(lblFullName);
        cardTeacherInfo.Controls.Add(txtTeacherCode);
        cardTeacherInfo.Controls.Add(lblTeacherCode);
        cardTeacherInfo.Controls.Add(lblTeacherInfoTitle);
        cardTeacherInfo.Location = new System.Drawing.Point(24, 24);
        cardTeacherInfo.Name = "cardTeacherInfo";
        cardTeacherInfo.Padding = new System.Windows.Forms.Padding(24);
        cardTeacherInfo.Size = new System.Drawing.Size(745, 520);
        cardTeacherInfo.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnSave.BackColor = System.Drawing.Color.FromArgb(24, 119, 242);
        btnSave.Variant = ECMS.UI.Controls.ButtonVariant.Primary;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.Location = new System.Drawing.Point(595, 460);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(126, 36);
        btnSave.TabIndex = 18;
        btnSave.Text = "Lưu giáo viên";
        btnSave.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnCancel.BackColor = System.Drawing.Color.White;
        btnCancel.Variant = ECMS.UI.Controls.ButtonVariant.Secondary;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        btnCancel.Location = new System.Drawing.Point(505, 460);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(80, 36);
        btnCancel.TabIndex = 17;
        btnCancel.Text = "Hủy";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // txtBio
        // 
        txtBio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtBio.Location = new System.Drawing.Point(24, 385);
        txtBio.Name = "txtBio";
        txtBio.Placeholder = "Kinh nghiệm giảng dạy, ghi chú bổ sung...";
        txtBio.Size = new System.Drawing.Size(697, 50);
        txtBio.TabIndex = 16;
        // 
        // lblBio
        // 
        lblBio.AutoSize = true;
        lblBio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblBio.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblBio.Location = new System.Drawing.Point(24, 365);
        lblBio.Name = "lblBio";
        lblBio.Size = new System.Drawing.Size(128, 15);
        lblBio.TabIndex = 15;
        lblBio.Text = "Ghi chú / Kinh nghiệm";
        // 
        // cboStatus
        // 
        cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboStatus.Location = new System.Drawing.Point(385, 305);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new System.Drawing.Size(336, 35);
        cboStatus.TabIndex = 14;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblStatus.AutoSize = true;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblStatus.Location = new System.Drawing.Point(385, 285);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(74, 15);
        lblStatus.TabIndex = 13;
        lblStatus.Text = "Trạng thái *";
        // 
        // txtCert
        // 
        txtCert.Location = new System.Drawing.Point(24, 305);
        txtCert.Name = "txtCert";
        txtCert.Placeholder = "Ví dụ: IELTS 8.5 · Cử nhân Sư phạm";
        txtCert.Size = new System.Drawing.Size(336, 35);
        txtCert.TabIndex = 12;
        // 
        // lblCert
        // 
        lblCert.AutoSize = true;
        lblCert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblCert.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblCert.Location = new System.Drawing.Point(24, 285);
        lblCert.Name = "lblCert";
        lblCert.Size = new System.Drawing.Size(133, 15);
        lblCert.TabIndex = 11;
        lblCert.Text = "Chứng chỉ / Bằng cấp *";
        // 
        // cboSpecialty
        // 
        cboSpecialty.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cboSpecialty.Location = new System.Drawing.Point(385, 225);
        cboSpecialty.Name = "cboSpecialty";
        cboSpecialty.Size = new System.Drawing.Size(336, 35);
        cboSpecialty.TabIndex = 10;
        // 
        // lblSpecialty
        // 
        lblSpecialty.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblSpecialty.AutoSize = true;
        lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblSpecialty.Location = new System.Drawing.Point(385, 205);
        lblSpecialty.Name = "lblSpecialty";
        lblSpecialty.Size = new System.Drawing.Size(117, 15);
        lblSpecialty.TabIndex = 9;
        lblSpecialty.Text = "Chuyên môn chính *";
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(24, 225);
        txtEmail.Name = "txtEmail";
        txtEmail.Placeholder = "Ví dụ: gv.an@example.local";
        txtEmail.Size = new System.Drawing.Size(336, 35);
        txtEmail.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblEmail.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblEmail.Location = new System.Drawing.Point(24, 205);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(91, 15);
        lblEmail.TabIndex = 7;
        lblEmail.Text = "Email liên hệ *";
        // 
        // txtPhone
        // 
        txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtPhone.Location = new System.Drawing.Point(385, 145);
        txtPhone.Name = "txtPhone";
        txtPhone.Placeholder = "Ví dụ: 0912 345 678";
        txtPhone.Size = new System.Drawing.Size(336, 35);
        txtPhone.TabIndex = 6;
        // 
        // lblPhone
        // 
        lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblPhone.AutoSize = true;
        lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPhone.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblPhone.Location = new System.Drawing.Point(385, 125);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(90, 15);
        lblPhone.TabIndex = 5;
        lblPhone.Text = "Số điện thoại *";
        // 
        // txtFullName
        // 
        txtFullName.Location = new System.Drawing.Point(24, 145);
        txtFullName.Name = "txtFullName";
        txtFullName.Placeholder = "Nhập đầy đủ họ và tên giáo viên...";
        txtFullName.Size = new System.Drawing.Size(336, 35);
        txtFullName.TabIndex = 4;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblFullName.Location = new System.Drawing.Point(24, 125);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(68, 15);
        lblFullName.TabIndex = 3;
        lblFullName.Text = "Họ và tên *";
        // 
        // txtTeacherCode
        // 
        txtTeacherCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        txtTeacherCode.Location = new System.Drawing.Point(385, 68);
        txtTeacherCode.Name = "txtTeacherCode";
        txtTeacherCode.Placeholder = "Ví dụ: GV-006";
        txtTeacherCode.Size = new System.Drawing.Size(336, 35);
        txtTeacherCode.TabIndex = 2;
        // 
        // lblTeacherCode
        // 
        lblTeacherCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblTeacherCode.AutoSize = true;
        lblTeacherCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblTeacherCode.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
        lblTeacherCode.Location = new System.Drawing.Point(385, 48);
        lblTeacherCode.Name = "lblTeacherCode";
        lblTeacherCode.Size = new System.Drawing.Size(90, 15);
        lblTeacherCode.TabIndex = 1;
        lblTeacherCode.Text = "Mã giáo viên *";
        // 
        // lblTeacherInfoTitle
        // 
        lblTeacherInfoTitle.AutoSize = true;
        lblTeacherInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTeacherInfoTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
        lblTeacherInfoTitle.Location = new System.Drawing.Point(24, 16);
        lblTeacherInfoTitle.Name = "lblTeacherInfoTitle";
        lblTeacherInfoTitle.Size = new System.Drawing.Size(262, 21);
        lblTeacherInfoTitle.TabIndex = 0;
        lblTeacherInfoTitle.Text = "Thông tin cá nhân & Chuyên môn";
        // 
        // AddTeacherDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        ClientSize = new System.Drawing.Size(1200, 740);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddTeacherDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm giáo viên mới";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        cardScheduleSetup.ResumeLayout(false);
        cardScheduleSetup.PerformLayout();
        cardTeacherInfo.ResumeLayout(false);
        cardTeacherInfo.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblBreadcrumb;
    private System.Windows.Forms.Panel pnlContent;
    private ECMS.UI.Controls.AppCard cardTeacherInfo;
    private System.Windows.Forms.Label lblTeacherInfoTitle;
    private System.Windows.Forms.Label lblTeacherCode;
    private ECMS.UI.Controls.AppTextBox txtTeacherCode;
    private System.Windows.Forms.Label lblFullName;
    private ECMS.UI.Controls.AppTextBox txtFullName;
    private System.Windows.Forms.Label lblPhone;
    private ECMS.UI.Controls.AppTextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private ECMS.UI.Controls.AppTextBox txtEmail;
    private System.Windows.Forms.Label lblSpecialty;
    private ECMS.UI.Controls.AppComboBox cboSpecialty;
    private System.Windows.Forms.Label lblCert;
    private ECMS.UI.Controls.AppTextBox txtCert;
    private System.Windows.Forms.Label lblStatus;
    private ECMS.UI.Controls.AppComboBox cboStatus;
    private System.Windows.Forms.Label lblBio;
    private ECMS.UI.Controls.AppTextBox txtBio;
    private ECMS.UI.Controls.AppButton btnCancel;
    private ECMS.UI.Controls.AppButton btnSave;
    private ECMS.UI.Controls.AppCard cardScheduleSetup;
    private System.Windows.Forms.Label lblScheduleSetupTitle;
    private System.Windows.Forms.Label lblMaxHours;
    private ECMS.UI.Controls.AppTextBox txtMaxHours;
    private System.Windows.Forms.Label lblPreferredSlot;
    private ECMS.UI.Controls.AppComboBox cboPreferredSlot;
    private System.Windows.Forms.Label lblAvailableDays;
    private System.Windows.Forms.CheckBox chkMonThu;
    private System.Windows.Forms.CheckBox chkTueFri;
    private System.Windows.Forms.CheckBox chkWedSat;
    private System.Windows.Forms.CheckBox chkWeekend;
    private ECMS.UI.Controls.AppBanner bannerScheduleInfo;
    private System.Windows.Forms.Label lblStorageNote;
}
