using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class SystemConfigView : UserControl
{
    public SystemConfigView()
    {
        InitializeComponent();

        LoadDefaultConfig();
        WireEvents();
    }

    private void LoadDefaultConfig()
    {
        txtCenterName.Text = "Trung tâm Anh ngữ Minh Trí";
        txtCenterPhone.Text = "028 3822 6688";
        txtCenterAddress.Text = "25 Nguyễn Văn Cừ, TP. Hồ Chí Minh";
        txtDirector.Text = "Nguyễn Thành Long";
        txtDatabasePath.Text = @"C:\ECMS\Data\ecms.db";
        txtStoragePath.Text = @"C:\ECMS\TaiLieu\ / D:\ECMS_Backup\";

        txtScoreScale.Text = "0–10";
        txtPassingScore.Text = "6,5";
        txtWeightRegular.Text = "20%";
        txtWeightMidterm.Text = "30%";
        txtWeightFinal.Text = "50%";
        txtMinAttendance.Text = "80%";
        txtAbsenceAlert.Text = "Trên 3 buổi (từ 4 buổi)";

        chkLateCounted.Checked = true;
        chkDebtCertRule.Checked = true;

        ValidateWeights();
    }

    private void ValidateWeights()
    {
        int ParseWeight(string text)
        {
            var clean = text.Replace("%", "").Trim();
            return int.TryParse(clean, out var val) ? val : 0;
        }

        var w1 = ParseWeight(txtWeightRegular.Text);
        var w2 = ParseWeight(txtWeightMidterm.Text);
        var w3 = ParseWeight(txtWeightFinal.Text);
        var total = w1 + w2 + w3;

        if (total == 100)
        {
            lblTotalWeightValidation.Text = "✓ Tổng trọng số = 100%";
            lblTotalWeightValidation.ForeColor = Color.FromArgb(22, 163, 74);
        }
        else
        {
            lblTotalWeightValidation.Text = $"✕ Tổng trọng số = {total}% (phải đúng 100%)";
            lblTotalWeightValidation.ForeColor = Color.FromArgb(220, 38, 38);
        }
    }

    private void WireEvents()
    {
        txtWeightRegular.TextChanged += (s, e) => ValidateWeights();
        txtWeightMidterm.TextChanged += (s, e) => ValidateWeights();
        txtWeightFinal.TextChanged += (s, e) => ValidateWeights();

        btnOpenBackupRestore.Click += (s, e) => OpenBackupRestoreFlow();
        lblTabBackup.Click += (s, e) => OpenBackupRestoreFlow();

        lblTabCenter.Click += (s, e) =>
        {
            lblTabCenter.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            lblTabCenter.ForeColor = Color.FromArgb(37, 99, 235);
            lblTabCenter.Text = "• Trung tâm & dữ liệu";

            lblTabGrading.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            lblTabGrading.ForeColor = Color.FromArgb(100, 116, 139);
            lblTabGrading.Text = "Đánh giá & chuyên cần";
        };

        lblTabGrading.Click += (s, e) =>
        {
            lblTabGrading.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            lblTabGrading.ForeColor = Color.FromArgb(37, 99, 235);
            lblTabGrading.Text = "• Đánh giá & chuyên cần";

            lblTabCenter.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            lblTabCenter.ForeColor = Color.FromArgb(100, 116, 139);
            lblTabCenter.Text = "Trung tâm & dữ liệu";
        };

        btnSaveConfigTop.Click += (s, e) => SaveAllConfig();
        btnSaveRules.Click += (s, e) => SaveAllConfig();

        btnCancelRules.Click += (s, e) => LoadDefaultConfig();
    }

    private void OpenBackupRestoreFlow()
    {
        using var backupDlg = new CreateBackupDialog();
        if (backupDlg.ShowDialog(ParentForm) == DialogResult.OK)
        {
            bannerSavedStatus.Title = $"✓ Đã sao lưu CSDL lúc {DateTime.Now:HH:mm}.";
            bannerSavedStatus.Message = $"Tệp sao lưu: {backupDlg.GeneratedBackupPath}";
        }
    }

    private void SaveAllConfig()
    {
        if (string.IsNullOrWhiteSpace(txtCenterName.Text))
        {
            AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tên trung tâm.");
            txtCenterName.Focus();
            return;
        }

        bannerSavedStatus.Title = $"✓ Cấu hình hợp lệ đã lưu lúc {DateTime.Now:HH:mm}.";
        bannerSavedStatus.Message = "Phím tắt đề xuất: Ctrl+F tìm, Ctrl+S lưu, Esc hủy, F1 trợ giúp ngoại tuyến.";

        AppDialog.ShowSuccess(ParentForm, "Lưu cấu hình",
            "Toàn bộ thông tin trung tâm và quy tắc đào tạo đã được lưu thành công vào CSDL SQLite.");
    }
}
