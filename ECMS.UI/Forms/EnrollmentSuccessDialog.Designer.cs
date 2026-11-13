namespace ECMS.UI.Forms;

partial class EnrollmentSuccessDialog
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
        pnlTop = new System.Windows.Forms.Panel();
        lblDoneSub = new System.Windows.Forms.Label();
        lblDoneHeader = new System.Windows.Forms.Label();
        bannerDoneSuccess = new ECMS.UI.Controls.AppBanner();
        cardDoneRecord = new ECMS.UI.Controls.AppCard();
        btnReturnToList = new ECMS.UI.Controls.AppButton();
        btnOpenStudentProfile = new ECMS.UI.Controls.AppButton();
        lblRecFinalFee = new System.Windows.Forms.Label();
        lblRecDates = new System.Windows.Forms.Label();
        lblRecRoom = new System.Windows.Forms.Label();
        lblRecSchedule = new System.Windows.Forms.Label();
        lblRecTeacher = new System.Windows.Forms.Label();
        lblRecClass = new System.Windows.Forms.Label();
        lblRecCourse = new System.Windows.Forms.Label();
        lblRecStudent = new System.Windows.Forms.Label();
        lblRecordTitle = new System.Windows.Forms.Label();
        cardDoneAccounting = new ECMS.UI.Controls.AppCard();
        lblFlowCompleted = new System.Windows.Forms.Label();
        bannerAccNote = new ECMS.UI.Controls.AppBanner();
        btnGoToTuition = new ECMS.UI.Controls.AppButton();
        lblAccReceiver = new System.Windows.Forms.Label();
        lblAccAction = new System.Windows.Forms.Label();
        lblAccType = new System.Windows.Forms.Label();
        lblAccDue = new System.Windows.Forms.Label();
        lblAccSub = new System.Windows.Forms.Label();
        lblAccTitle = new System.Windows.Forms.Label();
        pnlTop.SuspendLayout();
        cardDoneRecord.SuspendLayout();
        cardDoneAccounting.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = System.Drawing.Color.White;
        pnlTop.Controls.Add(lblDoneSub);
        pnlTop.Controls.Add(lblDoneHeader);
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTop.Location = new System.Drawing.Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
        pnlTop.Size = new System.Drawing.Size(1140, 75);
        pnlTop.TabIndex = 0;
        // 
        // lblDoneSub
        // 
        lblDoneSub.AutoSize = true;
        lblDoneSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblDoneSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblDoneSub.Location = new System.Drawing.Point(24, 45);
        lblDoneSub.Name = "lblDoneSub";
        lblDoneSub.Size = new System.Drawing.Size(325, 20);
        lblDoneSub.TabIndex = 1;
        lblDoneSub.Text = "Nguyễn Minh Anh · Hồ sơ được tạo ngày 02/10/2026";
        // 
        // lblDoneHeader
        // 
        lblDoneHeader.AutoSize = true;
        lblDoneHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        lblDoneHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblDoneHeader.Location = new System.Drawing.Point(22, 10);
        lblDoneHeader.Name = "lblDoneHeader";
        lblDoneHeader.Size = new System.Drawing.Size(262, 35);
        lblDoneHeader.TabIndex = 0;
        lblDoneHeader.Text = "Ghi danh thành công";
        // 
        // bannerDoneSuccess
        // 
        bannerDoneSuccess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerDoneSuccess.BannerType = ECMS.UI.Controls.BannerType.Success;
        bannerDoneSuccess.Location = new System.Drawing.Point(24, 90);
        bannerDoneSuccess.Message = "Đã tạo học viên HV-0241 và xếp vào IELTS-F01. Khách hàng TN-0108 đã chuyển thành học viên.";
        bannerDoneSuccess.Name = "bannerDoneSuccess";
        bannerDoneSuccess.Size = new System.Drawing.Size(1090, 46);
        bannerDoneSuccess.TabIndex = 1;
        bannerDoneSuccess.Title = "✓ Ghi danh thành công:";
        bannerDoneSuccess.Variant = ECMS.UI.Controls.BannerVariant.Success;
        // 
        // cardDoneRecord
        // 
        cardDoneRecord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cardDoneRecord.BackColor = System.Drawing.Color.White;
        cardDoneRecord.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardDoneRecord.BorderWidth = 1;
        cardDoneRecord.Controls.Add(btnReturnToList);
        cardDoneRecord.Controls.Add(btnOpenStudentProfile);
        cardDoneRecord.Controls.Add(lblRecFinalFee);
        cardDoneRecord.Controls.Add(lblRecDates);
        cardDoneRecord.Controls.Add(lblRecRoom);
        cardDoneRecord.Controls.Add(lblRecSchedule);
        cardDoneRecord.Controls.Add(lblRecTeacher);
        cardDoneRecord.Controls.Add(lblRecClass);
        cardDoneRecord.Controls.Add(lblRecCourse);
        cardDoneRecord.Controls.Add(lblRecStudent);
        cardDoneRecord.Controls.Add(lblRecordTitle);
        cardDoneRecord.CornerRadius = 8;
        cardDoneRecord.Location = new System.Drawing.Point(24, 150);
        cardDoneRecord.Name = "cardDoneRecord";
        cardDoneRecord.Padding = new System.Windows.Forms.Padding(16);
        cardDoneRecord.Size = new System.Drawing.Size(650, 490);
        cardDoneRecord.TabIndex = 2;
        // 
        // btnReturnToList
        // 
        btnReturnToList.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnReturnToList.BackColor = System.Drawing.Color.White;
        btnReturnToList.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Secondary;
        btnReturnToList.CornerRadius = 6;
        btnReturnToList.Cursor = System.Windows.Forms.Cursors.Hand;
        btnReturnToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnReturnToList.Font = new System.Drawing.Font("Segoe UI", 9F);
        btnReturnToList.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        btnReturnToList.Location = new System.Drawing.Point(215, 425);
        btnReturnToList.Name = "btnReturnToList";
        btnReturnToList.Size = new System.Drawing.Size(140, 38);
        btnReturnToList.TabIndex = 10;
        btnReturnToList.Text = "Về danh sách";
        btnReturnToList.UseVisualStyleBackColor = false;
        // 
        // btnOpenStudentProfile
        // 
        btnOpenStudentProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        btnOpenStudentProfile.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnOpenStudentProfile.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnOpenStudentProfile.CornerRadius = 6;
        btnOpenStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenStudentProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnOpenStudentProfile.ForeColor = System.Drawing.Color.White;
        btnOpenStudentProfile.Location = new System.Drawing.Point(20, 425);
        btnOpenStudentProfile.Name = "btnOpenStudentProfile";
        btnOpenStudentProfile.Size = new System.Drawing.Size(180, 38);
        btnOpenStudentProfile.TabIndex = 9;
        btnOpenStudentProfile.Text = "Mở hồ sơ học viên";
        btnOpenStudentProfile.UseVisualStyleBackColor = false;
        // 
        // lblRecFinalFee
        // 
        lblRecFinalFee.AutoSize = true;
        lblRecFinalFee.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblRecFinalFee.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblRecFinalFee.Location = new System.Drawing.Point(20, 360);
        lblRecFinalFee.Name = "lblRecFinalFee";
        lblRecFinalFee.Size = new System.Drawing.Size(306, 28);
        lblRecFinalFee.TabIndex = 8;
        lblRecFinalFee.Text = "Học phí sau ưu đãi:  5.400.000đ";
        // 
        // lblRecDates
        // 
        lblRecDates.AutoSize = true;
        lblRecDates.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecDates.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecDates.Location = new System.Drawing.Point(20, 315);
        lblRecDates.Name = "lblRecDates";
        lblRecDates.Size = new System.Drawing.Size(315, 21);
        lblRecDates.TabIndex = 7;
        lblRecDates.Text = "Thời gian:  06/10–25/12/2026 · 24 buổi";
        // 
        // lblRecRoom
        // 
        lblRecRoom.AutoSize = true;
        lblRecRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecRoom.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecRoom.Location = new System.Drawing.Point(20, 275);
        lblRecRoom.Name = "lblRecRoom";
        lblRecRoom.Size = new System.Drawing.Size(182, 21);
        lblRecRoom.TabIndex = 6;
        lblRecRoom.Text = "Phòng:  P201 · 24 chỗ";
        // 
        // lblRecSchedule
        // 
        lblRecSchedule.AutoSize = true;
        lblRecSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecSchedule.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecSchedule.Location = new System.Drawing.Point(20, 235);
        lblRecSchedule.Name = "lblRecSchedule";
        lblRecSchedule.Size = new System.Drawing.Size(342, 21);
        lblRecSchedule.TabIndex = 5;
        lblRecSchedule.Text = "Lịch học:  Thứ Ba / Thứ Sáu · 18:00–20:00";
        // 
        // lblRecTeacher
        // 
        lblRecTeacher.AutoSize = true;
        lblRecTeacher.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecTeacher.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecTeacher.Location = new System.Drawing.Point(20, 195);
        lblRecTeacher.Name = "lblRecTeacher";
        lblRecTeacher.Size = new System.Drawing.Size(232, 21);
        lblRecTeacher.TabIndex = 4;
        lblRecTeacher.Text = "Giáo viên:  Nguyễn Hoàng Anh";
        // 
        // lblRecClass
        // 
        lblRecClass.AutoSize = true;
        lblRecClass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecClass.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecClass.Location = new System.Drawing.Point(20, 155);
        lblRecClass.Name = "lblRecClass";
        lblRecClass.Size = new System.Drawing.Size(193, 21);
        lblRecClass.TabIndex = 3;
        lblRecClass.Text = "Lớp / sĩ số:  IELTS-F01 · 18/20";
        // 
        // lblRecCourse
        // 
        lblRecCourse.AutoSize = true;
        lblRecCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblRecCourse.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblRecCourse.Location = new System.Drawing.Point(20, 115);
        lblRecCourse.Name = "lblRecCourse";
        lblRecCourse.Size = new System.Drawing.Size(325, 21);
        lblRecCourse.TabIndex = 2;
        lblRecCourse.Text = "Khóa học:  IELTS Foundation · CT-IELTS-F";
        // 
        // lblRecStudent
        // 
        lblRecStudent.AutoSize = true;
        lblRecStudent.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        lblRecStudent.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblRecStudent.Location = new System.Drawing.Point(20, 75);
        lblRecStudent.Name = "lblRecStudent";
        lblRecStudent.Size = new System.Drawing.Size(332, 25);
        lblRecStudent.TabIndex = 1;
        lblRecStudent.Text = "Học viên:  Nguyễn Minh Anh · HV-0241";
        // 
        // lblRecordTitle
        // 
        lblRecordTitle.AutoSize = true;
        lblRecordTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblRecordTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblRecordTitle.Location = new System.Drawing.Point(20, 16);
        lblRecordTitle.Name = "lblRecordTitle";
        lblRecordTitle.Size = new System.Drawing.Size(182, 28);
        lblRecordTitle.TabIndex = 0;
        lblRecordTitle.Text = "Hồ sơ đã ghi nhận";
        // 
        // cardDoneAccounting
        // 
        cardDoneAccounting.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        cardDoneAccounting.BackColor = System.Drawing.Color.White;
        cardDoneAccounting.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
        cardDoneAccounting.BorderWidth = 1;
        cardDoneAccounting.Controls.Add(lblFlowCompleted);
        cardDoneAccounting.Controls.Add(bannerAccNote);
        cardDoneAccounting.Controls.Add(btnGoToTuition);
        cardDoneAccounting.Controls.Add(lblAccReceiver);
        cardDoneAccounting.Controls.Add(lblAccAction);
        cardDoneAccounting.Controls.Add(lblAccType);
        cardDoneAccounting.Controls.Add(lblAccDue);
        cardDoneAccounting.Controls.Add(lblAccSub);
        cardDoneAccounting.Controls.Add(lblAccTitle);
        cardDoneAccounting.CornerRadius = 8;
        cardDoneAccounting.Location = new System.Drawing.Point(695, 150);
        cardDoneAccounting.Name = "cardDoneAccounting";
        cardDoneAccounting.Padding = new System.Windows.Forms.Padding(16);
        cardDoneAccounting.Size = new System.Drawing.Size(420, 490);
        cardDoneAccounting.TabIndex = 3;
        // 
        // lblFlowCompleted
        // 
        lblFlowCompleted.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        lblFlowCompleted.AutoSize = true;
        lblFlowCompleted.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        lblFlowCompleted.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
        lblFlowCompleted.Location = new System.Drawing.Point(20, 430);
        lblFlowCompleted.Name = "lblFlowCompleted";
        lblFlowCompleted.Size = new System.Drawing.Size(135, 21);
        lblFlowCompleted.TabIndex = 8;
        lblFlowCompleted.Text = "✓ Hoàn tất luồng 02";
        // 
        // bannerAccNote
        // 
        bannerAccNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        bannerAccNote.BannerType = ECMS.UI.Controls.BannerType.Info;
        bannerAccNote.Location = new System.Drawing.Point(20, 335);
        bannerAccNote.Message = "Dữ liệu mẫu tiếp nối: đợt 1 thu 2.000.000đ ngày 02/10; đợt 2 tại luồng 07 thu 1.500.000đ ngày 30/10.";
        bannerAccNote.Name = "bannerAccNote";
        bannerAccNote.Size = new System.Drawing.Size(380, 65);
        bannerAccNote.TabIndex = 7;
        bannerAccNote.Title = "Kế hoạch thu:";
        bannerAccNote.Variant = ECMS.UI.Controls.BannerVariant.Info;
        // 
        // btnGoToTuition
        // 
        btnGoToTuition.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnGoToTuition.ButtonStyle = ECMS.UI.Controls.AppButtonStyle.Primary;
        btnGoToTuition.CornerRadius = 6;
        btnGoToTuition.Cursor = System.Windows.Forms.Cursors.Hand;
        btnGoToTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGoToTuition.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        btnGoToTuition.ForeColor = System.Drawing.Color.White;
        btnGoToTuition.Location = new System.Drawing.Point(20, 260);
        btnGoToTuition.Name = "btnGoToTuition";
        btnGoToTuition.Size = new System.Drawing.Size(240, 42);
        btnGoToTuition.TabIndex = 6;
        btnGoToTuition.Text = "Chuyển sang thu học phí →";
        btnGoToTuition.UseVisualStyleBackColor = false;
        // 
        // lblAccReceiver
        // 
        lblAccReceiver.AutoSize = true;
        lblAccReceiver.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAccReceiver.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblAccReceiver.Location = new System.Drawing.Point(20, 205);
        lblAccReceiver.Name = "lblAccReceiver";
        lblAccReceiver.Size = new System.Drawing.Size(282, 21);
        lblAccReceiver.TabIndex = 5;
        lblAccReceiver.Text = "Người tiếp nhận:  Lê Phương Thảo · Kế toán";
        // 
        // lblAccAction
        // 
        lblAccAction.AutoSize = true;
        lblAccAction.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAccAction.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblAccAction.Location = new System.Drawing.Point(20, 165);
        lblAccAction.Name = "lblAccAction";
        lblAccAction.Size = new System.Drawing.Size(256, 21);
        lblAccAction.TabIndex = 4;
        lblAccAction.Text = "Hành động:  Mở Học phí & Thanh toán";
        // 
        // lblAccType
        // 
        lblAccType.AutoSize = true;
        lblAccType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lblAccType.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        lblAccType.Location = new System.Drawing.Point(20, 125);
        lblAccType.Name = "lblAccType";
        lblAccType.Size = new System.Drawing.Size(236, 21);
        lblAccType.TabIndex = 3;
        lblAccType.Text = "Hình thức:  Một lần hoặc nhiều đợt";
        // 
        // lblAccDue
        // 
        lblAccDue.AutoSize = true;
        lblAccDue.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
        lblAccDue.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lblAccDue.Location = new System.Drawing.Point(20, 85);
        lblAccDue.Name = "lblAccDue";
        lblAccDue.Size = new System.Drawing.Size(217, 28);
        lblAccDue.TabIndex = 2;
        lblAccDue.Text = "Cần thu:  5.400.000đ";
        // 
        // lblAccSub
        // 
        lblAccSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblAccSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
        lblAccSub.Location = new System.Drawing.Point(20, 48);
        lblAccSub.Name = "lblAccSub";
        lblAccSub.Size = new System.Drawing.Size(380, 30);
        lblAccSub.TabIndex = 1;
        lblAccSub.Text = "Ghi danh đã hoàn tất. Chưa phát sinh phiếu thu ở bước này.";
        // 
        // lblAccTitle
        // 
        lblAccTitle.AutoSize = true;
        lblAccTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblAccTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        lblAccTitle.Location = new System.Drawing.Point(20, 16);
        lblAccTitle.Name = "lblAccTitle";
        lblAccTitle.Size = new System.Drawing.Size(176, 28);
        lblAccTitle.TabIndex = 0;
        lblAccTitle.Text = "Bàn giao kế toán";
        // 
        // EnrollmentSuccessDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        ClientSize = new System.Drawing.Size(1220, 740);
        Controls.Add(cardDoneAccounting);
        Controls.Add(cardDoneRecord);
        Controls.Add(bannerDoneSuccess);
        Controls.Add(pnlTop);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EnrollmentSuccessDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Ghi danh thành công — ECMS";
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cardDoneRecord.ResumeLayout(false);
        cardDoneRecord.PerformLayout();
        cardDoneAccounting.ResumeLayout(false);
        cardDoneAccounting.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Label lblDoneHeader;
    private System.Windows.Forms.Label lblDoneSub;

    private ECMS.UI.Controls.AppBanner bannerDoneSuccess;

    private ECMS.UI.Controls.AppCard cardDoneRecord;
    private System.Windows.Forms.Label lblRecordTitle;
    private System.Windows.Forms.Label lblRecStudent;
    private System.Windows.Forms.Label lblRecCourse;
    private System.Windows.Forms.Label lblRecClass;
    private System.Windows.Forms.Label lblRecTeacher;
    private System.Windows.Forms.Label lblRecSchedule;
    private System.Windows.Forms.Label lblRecRoom;
    private System.Windows.Forms.Label lblRecDates;
    private System.Windows.Forms.Label lblRecFinalFee;
    private ECMS.UI.Controls.AppButton btnOpenStudentProfile;
    private ECMS.UI.Controls.AppButton btnReturnToList;

    private ECMS.UI.Controls.AppCard cardDoneAccounting;
    private System.Windows.Forms.Label lblAccTitle;
    private System.Windows.Forms.Label lblAccSub;
    private System.Windows.Forms.Label lblAccDue;
    private System.Windows.Forms.Label lblAccType;
    private System.Windows.Forms.Label lblAccAction;
    private System.Windows.Forms.Label lblAccReceiver;
    private ECMS.UI.Controls.AppButton btnGoToTuition;
    private ECMS.UI.Controls.AppBanner bannerAccNote;
    private System.Windows.Forms.Label lblFlowCompleted;
}
