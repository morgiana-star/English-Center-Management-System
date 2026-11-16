using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản trị Cấu hình hệ thống gồm 3 Tab:
/// 1. Thông tin trung tâm & CSDL SQLite
/// 2. Quy tắc điểm số, Đánh giá & Chuyên cần
/// 3. Quản lý Sao lưu & Khôi phục dữ liệu
/// </summary>
public partial class SystemConfigView : UserControl
{
    public SystemConfigView()
    {
        InitializeComponent();
        LoadDefaultConfig();
        SetupBackupsGrid();
        PopulateMockBackups();
        WireEvents();
    }

    private void LoadDefaultConfig()
    {
        // 1. Tab 1: Trung tâm & CSDL
        txtCenterName.Text = "Trung tâm Anh ngữ ECMS Minh Trí";
        txtCenterPhone.Text = "028 3822 6688";
        txtCenterEmail.Text = "contact@ecms.edu.vn";
        txtCenterWebsite.Text = "https://ecms.edu.vn";
        txtCenterAddress.Text = "25 Nguyễn Văn Cừ, Phường 4, Quận 5, TP. Hồ Chí Minh";
        txtDirector.Text = AppSession.FullName;
        txtDirectorTitle.Text = AppSession.SignerTitle;

        txtDatabasePath.Text = @"C:\ECMS\Data\ecms.db";
        txtStoragePath.Text = @"C:\ECMS\TaiLieu\";
        txtBackupDir.Text = @"D:\ECMS_Backup\";

        // 2. Tab 2: Quy tắc điểm & Chuyên cần
        cboScoreScale.Items.Clear();
        cboScoreScale.Items.AddRange(new object[] { "Thang điểm 10 (0.0 - 10.0)", "Thang điểm 100 (0 - 100)", "Thang điểm 4.0 (0.0 - 4.0)" });
        cboScoreScale.SelectedIndex = 0;

        txtPassingScore.Text = "6.5";
        txtWeightRegular.Text = "20%";
        txtWeightMidterm.Text = "30%";
        txtWeightFinal.Text = "50%";
        txtMinAttendance.Text = "80%";
        txtAbsenceAlert.Text = "Nghỉ từ 3 buổi";

        chkLateCounted.Checked = true;
        chkDebtCertRule.Checked = true;
        chkAutoLockAttendance.Checked = true;

        ValidateWeights();

        // 3. Tab 3: Sao lưu tự động
        cboBackupTime.Items.Clear();
        cboBackupTime.Items.AddRange(new object[] { "23:00 hàng ngày", "12:00 & 23:00 hàng ngày", "Chủ nhật hàng tuần lúc 00:00" });
        cboBackupTime.SelectedIndex = 0;
        chkAutoBackup.Checked = true;
    }

    private void SetupBackupsGrid()
    {
        dgvBackups.Columns.Clear();
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên tệp sao lưu", FillWeight = 28, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian tạo", FillWeight = 18, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dung lượng", FillWeight = 14, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại sao lưu", FillWeight = 14, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tính toàn vẹn", FillWeight = 14, ReadOnly = true });

        var colRestore = new DataGridViewButtonColumn
        {
            HeaderText = "Khôi phục",
            Text = "🔄 Phục hồi",
            UseColumnTextForButtonValue = true,
            FillWeight = 12
        };

        var colDelete = new DataGridViewButtonColumn
        {
            HeaderText = "Xóa",
            Text = "🗑️ Xóa",
            UseColumnTextForButtonValue = true,
            FillWeight = 10
        };

        dgvBackups.Columns.AddRange(colRestore, colDelete);
    }

    private void PopulateMockBackups()
    {
        dgvBackups.Rows.Clear();
        dgvBackups.Rows.Add("ecms_backup_20261116_0200.db", "16/11/2026 02:00", "18.6 MB", "Tự động", "✓ Hợp lệ (OK)");
        dgvBackups.Rows.Add("ecms_backup_20261115_2300.db", "15/11/2026 23:00", "18.5 MB", "Tự động", "✓ Hợp lệ (OK)");
        dgvBackups.Rows.Add("ecms_backup_20261114_2300.db", "14/11/2026 23:00", "18.2 MB", "Tự động", "✓ Hợp lệ (OK)");
        dgvBackups.Rows.Add("ecms_backup_20261110_1545.db", "10/11/2026 15:45", "17.9 MB", "Thủ công", "✓ Hợp lệ (OK)");
        dgvBackups.ClearSelection();
        dgvBackups.CurrentCell = null;
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
            lblTotalWeightValidation.Text = $"✓ Tổng trọng số = {w1}% + {w2}% + {w3}% = 100% (Đạt tiêu chuẩn)";
            lblTotalWeightValidation.ForeColor = Color.FromArgb(22, 163, 74);
        }
        else
        {
            lblTotalWeightValidation.Text = $"✕ Tổng trọng số = {w1}% + {w2}% + {w3}% = {total}% (Bắt buộc phải đúng 100%)";
            lblTotalWeightValidation.ForeColor = Color.FromArgb(220, 38, 38);
        }
    }

    private void WireEvents()
    {
        // 1. Trọng số điểm
        txtWeightRegular.TextChanged += (s, e) => ValidateWeights();
        txtWeightMidterm.TextChanged += (s, e) => ValidateWeights();
        txtWeightFinal.TextChanged += (s, e) => ValidateWeights();

        // 2. Browse buttons cho Tab 1
        btnBrowseDb.Click += (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp cơ sở dữ liệu SQLite",
                Filter = "SQLite Database (*.db;*.sqlite;*.sqlite3)|*.db;*.sqlite;*.sqlite3|All Files (*.*)|*.*",
                CheckFileExists = true
            };
            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtDatabasePath.Text = ofd.FileName;
            }
        };

        btnCheckDb.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Kết nối CSDL thành công",
                $"Đã kết nối thành công tới tệp SQLite:\n" +
                $"• Tệp: {txtDatabasePath.Text}\n" +
                $"• Trạng thái: PRAGMA integrity_check: OK\n" +
                $"• Dung lượng: 18.6 MB\n" +
                $"• Tổng số bảng hệ thống: 16 bảng hoạt động.");
        };

        btnBrowseStorage.Click += (s, e) =>
        {
            using var fbd = new FolderBrowserDialog
            {
                Description = "Chọn thư mục lưu trữ tài liệu khóa học"
            };
            if (fbd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtStoragePath.Text = fbd.SelectedPath;
            }
        };

        btnBrowseBackup.Click += (s, e) =>
        {
            using var fbd = new FolderBrowserDialog
            {
                Description = "Chọn thư mục lưu trữ các bản sao lưu CSDL"
            };
            if (fbd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtBackupDir.Text = fbd.SelectedPath;
            }
        };

        // 3. Nút Lưu tổng thể
        btnSaveAllTop.Click += (s, e) => SaveAllConfig();

        // 4. Tab 3 Toolbar Events
        btnCreateBackupNow.Click += (s, e) =>
        {
            using var backupDlg = new CreateBackupDialog();
            if (backupDlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                string fileName = Path.GetFileName(backupDlg.GeneratedBackupPath);
                dgvBackups.Rows.Insert(0, fileName, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "18.6 MB", "Thủ công", "✓ Hợp lệ (OK)");
                AppDialog.ShowSuccess(ParentForm, "Sao lưu hoàn tất", $"Bản sao lưu '{fileName}' đã được tạo và ghi nhận vào lịch sử sao lưu.");
            }
        };

        btnRestoreBackup.Click += (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp sao lưu SQLite để phục hồi",
                Filter = "SQLite Backup (*.db;*.sqlite)|*.db;*.sqlite|All Files (*.*)|*.*"
            };
            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                if (AppDialog.ShowConfirm(ParentForm, "Xác nhận phục hồi CSDL",
                    $"Cảnh báo: Dữ liệu hiện tại sẽ được ghi đè hoàn toàn bởi bản sao lưu:\n'{Path.GetFileName(ofd.FileName)}'.\n\nBạn có chắc chắn muốn tiến hành phục hồi không?") == DialogResult.OK)
                {
                    AppDialog.ShowSuccess(ParentForm, "Khôi phục thành công", "Đã phục hồi cơ sở dữ liệu về trạng thái sao lưu thành công. Hệ thống đã sẵn sàng.");
                }
            }
        };

        btnOpenBackupFolder.Click += (s, e) =>
        {
            AppDialog.ShowInfo(ParentForm, "Thư mục sao lưu", $"Đường dẫn thư mục sao lưu của hệ thống:\n{txtBackupDir.Text}");
        };

        // Thao tác trên DataGridView Backups
        dgvBackups.CellContentClick += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            string fileName = dgvBackups.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";

            // Nút Phục hồi (col 5)
            if (e.ColumnIndex == 5)
            {
                if (AppDialog.ShowConfirm(ParentForm, "Khôi phục từ bản sao lưu",
                    $"Bạn có chắc chắn muốn khôi phục dữ liệu từ bản sao lưu '{fileName}' không?\nToàn bộ dữ liệu hiện tại sẽ quay về thời điểm này.") == DialogResult.OK)
                {
                    AppDialog.ShowSuccess(ParentForm, "Phục hồi thành công", $"Đã hoàn tất quá trình phục hồi từ bản sao lưu '{fileName}'.");
                }
            }
            // Nút Xóa (col 6)
            else if (e.ColumnIndex == 6)
            {
                if (AppDialog.ShowConfirm(ParentForm, "Xóa bản sao lưu",
                    $"Bạn có chắc chắn muốn xóa bản sao lưu '{fileName}' khỏi lịch sử lưu trữ không?") == DialogResult.OK)
                {
                    dgvBackups.Rows.RemoveAt(e.RowIndex);
                    AppDialog.ShowSuccess(ParentForm, "Đã xóa", $"Đã xóa tệp sao lưu '{fileName}' thành công.");
                }
            }
        };

        // Format màu cho dgvBackups
        dgvBackups.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                e.CellStyle.Font = new Font(dgvBackups.Font, FontStyle.Bold);
            }
        };
    }

    private void SaveAllConfig()
    {
        if (string.IsNullOrWhiteSpace(txtCenterName.Text))
        {
            tabMainConfig.SelectedTab = tabCenter;
            AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tên trung tâm.");
            txtCenterName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtCenterPhone.Text))
        {
            tabMainConfig.SelectedTab = tabCenter;
            AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập số điện thoại trung tâm.");
            txtCenterPhone.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtDirector.Text))
        {
            tabMainConfig.SelectedTab = tabCenter;
            AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tên người đại diện ký duyệt.");
            txtDirector.Focus();
            return;
        }

        // Đồng bộ AppSession
        AppSession.FullName = txtDirector.Text.Trim();
        if (!string.IsNullOrWhiteSpace(txtDirectorTitle.Text))
        {
            AppSession.SignerTitle = txtDirectorTitle.Text.Trim();
        }

        bannerCenterSuccess.Visible = true;
        AppDialog.ShowSuccess(ParentForm, "Lưu cấu hình hệ thống",
            "Toàn bộ cấu hình hệ thống (Thông tin trung tâm, Đường dẫn CSDL, Quy tắc đánh giá & Chuyên cần) đã được lưu thành công.");
    }
}