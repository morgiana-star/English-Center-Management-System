using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Data.Database;
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
    private readonly ISystemConfigService _configService = new SystemConfigService();
    private bool _isLoading = false;
    private string _selectedLogoPath = string.Empty;

    public SystemConfigView()
    {
        InitializeComponent();
        SimplifyLayoutControls();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupBackupsGrid();
        InitComboBoxes();
        WireEvents();
        _ = LoadAllConfigsAsync();
    }

    private void SimplifyLayoutControls()
    {
        btnBrowseLogo.Click += (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh Logo trung tâm",
                Filter = "Ảnh Logo (*.png;*.jpg;*.jpeg;*.ico)|*.png;*.jpg;*.jpeg;*.ico"
            };
            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                _selectedLogoPath = ofd.FileName;
                LoadLogoPreview(_selectedLogoPath);
            }
        };
    }

    private void LoadLogoPreview(string? path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return;
        try
        {
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var img = Image.FromStream(fs);
            picLogoPreview.Image = new Bitmap(img);
        }
        catch { }
    }

    private void InitComboBoxes()
    {
        cboScoreScale.Items.Clear();
        cboScoreScale.Items.AddRange(new object[] { "Thang điểm 10 (0.0 - 10.0)", "Thang điểm 100 (0 - 100)", "Thang điểm 4.0 (0.0 - 4.0)" });
        cboScoreScale.SelectedIndex = 0;

        cboBackupTime.Items.Clear();
        cboBackupTime.Items.AddRange(new object[] { "23:00 hàng ngày", "12:00 & 23:00 hàng ngày", "Chủ nhật hàng tuần lúc 00:00" });
        cboBackupTime.SelectedIndex = 0;
    }

    private async Task LoadAllConfigsAsync()
    {
        _isLoading = true;
        try
        {
            // 1. Nạp cấu hình Trung tâm & CSDL từ SQLite
            var center = await _configService.GetCenterConfigAsync();
            txtAppName.Text = center.AppName;
            txtShortName.Text = center.CenterShortName;
            _selectedLogoPath = center.LogoPath;
            LoadLogoPreview(_selectedLogoPath);
            txtCenterName.Text = center.CenterName;
            txtCenterPhone.Text = center.CenterPhone;
            txtCenterEmail.Text = center.CenterEmail;
            txtCenterWebsite.Text = center.CenterWebsite;
            txtCenterAddress.Text = center.CenterAddress;
            txtDirector.Text = center.DirectorName;
            txtDirectorTitle.Text = center.DirectorTitle;

            txtDatabasePath.Text = DatabaseConfig.DatabasePath;
            txtStoragePath.Text = center.StoragePath;
            txtBackupDir.Text = center.BackupDir;

            // 2. Nạp cấu hình Quy tắc học vụ & Điểm số
            var rules = await _configService.GetAcademicRulesAsync();
            var scaleIdx = cboScoreScale.FindString(rules.ScoreScale);
            cboScoreScale.SelectedIndex = scaleIdx >= 0 ? scaleIdx : 0;

            txtPassingScore.Text = rules.PassingScore.ToString("0.0", CultureInfo.InvariantCulture);
            txtWeightRegular.Text = rules.WeightRegular.ToString();
            txtWeightMidterm.Text = rules.WeightMidterm.ToString();
            txtWeightFinal.Text = rules.WeightFinal.ToString();
            txtMinAttendance.Text = rules.MinAttendanceRate.ToString("0", CultureInfo.InvariantCulture);
            txtAbsenceAlert.Text = rules.MaxAbsencesAlert.ToString();

            ValidateWeights();

            // 3. Nạp cấu hình Lịch sao lưu
            var sched = await _configService.GetBackupScheduleConfigAsync();
            chkAutoBackup.Checked = sched.IsAutoBackupEnabled;
            var schedIdx = cboBackupTime.FindString(sched.BackupScheduleTime);
            cboBackupTime.SelectedIndex = schedIdx >= 0 ? schedIdx : 0;

            // 4. Nạp danh sách bản sao lưu thực tế trên đĩa
            await RefreshBackupsGridAsync();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp cấu hình", $"Không thể nạp dữ liệu cấu hình từ cơ sở dữ liệu: {ex.Message}");
        }
        finally
        {
            _isLoading = false;
        }
    }

    private void SetupBackupsGrid()
    {
        dgvBackups.Columns.Clear();
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên tệp sao lưu", FillWeight = 34, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian tạo", FillWeight = 20, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dung lượng", FillWeight = 14, ReadOnly = true });
        dgvBackups.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại sao lưu", FillWeight = 14, ReadOnly = true });

        var colRestore = new DataGridViewButtonColumn
        {
            HeaderText = "Khôi phục",
            Text = "Phục hồi",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 10
        };
        colRestore.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        colRestore.DefaultCellStyle.SelectionForeColor = Color.FromArgb(37, 99, 235);

        var colDelete = new DataGridViewButtonColumn
        {
            HeaderText = "Xóa",
            Text = "Xóa",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat,
            FillWeight = 8
        };
        colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
        colDelete.DefaultCellStyle.SelectionForeColor = Color.FromArgb(220, 38, 38);

        dgvBackups.Columns.AddRange(colRestore, colDelete);
    }

    private async Task RefreshBackupsGridAsync()
    {
        string dir = string.IsNullOrWhiteSpace(txtBackupDir.Text)
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ECMS", "Backups")
            : txtBackupDir.Text.Trim();

        var backups = (await _configService.GetBackupFilesAsync(dir)).ToList();

        dgvBackups.Rows.Clear();
        foreach (var b in backups)
        {
            int rIdx = dgvBackups.Rows.Add(b.FileName, b.CreatedAtFormatted, b.FileSizeFormatted, b.BackupType);
            dgvBackups.Rows[rIdx].Tag = b.FilePath;
        }

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
            // lblTotalWeightValidation.Text = $"✓ Tổng trọng số = {w1}% + {w2}% + {w3}% = 100% (Đạt tiêu chuẩn)";
            // lblTotalWeightValidation.ForeColor = Color.FromArgb(22, 163, 74);
        }
        else
        {
            // lblTotalWeightValidation.Text = $"✕ Tổng trọng số = {w1}% + {w2}% + {w3}% = {total}% (Bắt buộc phải đúng 100%)";
            // lblTotalWeightValidation.ForeColor = Color.FromArgb(220, 38, 38);
        }
    }

    private void WireEvents()
    {
        // 1. Trọng số điểm validate realtime
        txtWeightRegular.TextChanged += (s, e) => { if (!_isLoading) ValidateWeights(); };
        txtWeightMidterm.TextChanged += (s, e) => { if (!_isLoading) ValidateWeights(); };
        txtWeightFinal.TextChanged += (s, e) => { if (!_isLoading) ValidateWeights(); };

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

        btnCheckDb.Click += async (s, e) =>
        {
            try
            {
                var status = await _configService.GetDatabaseStatusAsync();
                AppDialog.ShowSuccess(ParentForm, "Kết nối CSDL thành công",
                    $"Đã kiểm tra thành công tệp SQLite:\n\n" +
                    $"• Đường dẫn: {status.DatabasePath}\n" +
                    $"• Dung lượng tệp: {status.FileSizeFormatted}\n" +
                    $"• Trạng thái Journal: {status.JournalMode}\n" +
                    $"• Khóa ngoại (Foreign Keys): {status.ForeignKeysStatus}\n" +
                    $"• Tổng số bảng hệ thống: {status.TotalTablesCount} bảng hoạt động\n" +
                    $"• Kiểm tra tính toàn vẹn (PRAGMA integrity_check): {status.IntegrityCheckResult}");
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi kiểm tra CSDL", $"Không thể kết nối hoặc kiểm tra CSDL: {ex.Message}");
            }
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

        btnBrowseBackup.Click += async (s, e) =>
        {
            using var fbd = new FolderBrowserDialog
            {
                Description = "Chọn thư mục lưu trữ các bản sao lưu CSDL"
            };
            if (fbd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtBackupDir.Text = fbd.SelectedPath;
                await RefreshBackupsGridAsync();
            }
        };

        // 3. Nút Lưu tổng thể
        btnSaveAllTop.Click += async (s, e) => await SaveAllConfigAsync();

        // 4. Tab 3 Toolbar Events
        btnCreateBackupNow.Click += async (s, e) =>
        {
            using var backupDlg = new CreateBackupDialog(txtBackupDir.Text.Trim(), _configService);
            if (backupDlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                await RefreshBackupsGridAsync();
            }
        };

        btnRestoreBackup.Click += async (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp sao lưu SQLite để phục hồi",
                Filter = "SQLite Backup (*.db;*.sqlite)|*.db;*.sqlite|All Files (*.*)|*.*",
                InitialDirectory = Directory.Exists(txtBackupDir.Text) ? txtBackupDir.Text : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            };
            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);
                if (AppDialog.ShowConfirm(ParentForm, "Xác nhận phục hồi CSDL",
                    $"CẢNH BÁO: Toàn bộ dữ liệu hiện tại sẽ được thay thế bởi bản sao lưu:\n'{fileName}'.\n\nHệ thống sẽ tự động tạo snapshot dự phòng trước khi ghi đè.\nBạn có chắc chắn muốn tiến hành phục hồi không?") == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        var res = await _configService.RestoreDatabaseAsync(ofd.FileName, AppSession.UserId);
                        if (res.Success)
                        {
                            AppDialog.ShowSuccess(ParentForm, "Khôi phục thành công", res.Message);
                            await LoadAllConfigsAsync();
                        }
                        else
                        {
                            AppDialog.ShowError(ParentForm, "Lỗi khôi phục", res.Message);
                        }
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
        };

        btnOpenBackupFolder.Click += (s, e) =>
        {
            string bDir = string.IsNullOrWhiteSpace(txtBackupDir.Text)
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ECMS", "Backups")
                : txtBackupDir.Text.Trim();

            if (!Directory.Exists(bDir))
            {
                try { Directory.CreateDirectory(bDir); } catch { }
            }

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = bDir,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                AppDialog.ShowInfo(ParentForm, "Thư mục sao lưu", $"Đường dẫn thư mục sao lưu:\n{bDir}\n\nLỗi mở Explorer: {ex.Message}");
            }
        };

        // Thao tác trên DataGridView Backups
        dgvBackups.CellContentClick += async (s, e) =>
        {
            if (e.RowIndex < 0) return;
            string fileName = dgvBackups.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            string filePath = dgvBackups.Rows[e.RowIndex].Tag?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = Path.Combine(txtBackupDir.Text.Trim(), fileName);
            }

            // Nút Phục hồi (col 4)
            if (e.ColumnIndex == 4)
            {
                if (AppDialog.ShowConfirm(ParentForm, "Khôi phục từ bản sao lưu",
                    $"Bạn có chắc chắn muốn khôi phục dữ liệu từ bản sao lưu '{fileName}' không?\nToàn bộ dữ liệu hiện tại sẽ quay về thời điểm này.") == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        var res = await _configService.RestoreDatabaseAsync(filePath, AppSession.UserId);
                        if (res.Success)
                        {
                            AppDialog.ShowSuccess(ParentForm, "Phục hồi thành công", res.Message);
                            await LoadAllConfigsAsync();
                        }
                        else
                        {
                            AppDialog.ShowError(ParentForm, "Lỗi phục hồi", res.Message);
                        }
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
            // Nút Xóa (col 5)
            else if (e.ColumnIndex == 5)
            {
                if (AppDialog.ShowConfirm(ParentForm, "Xóa bản sao lưu",
                    $"Bạn có chắc chắn muốn xóa bản sao lưu '{fileName}' khỏi ổ đĩa không?") == DialogResult.OK)
                {
                    var res = await _configService.DeleteBackupFileAsync(filePath, AppSession.UserId);
                    if (res.Success)
                    {
                        dgvBackups.Rows.RemoveAt(e.RowIndex);
                        AppDialog.ShowSuccess(ParentForm, "Đã xóa", res.Message);
                    }
                    else
                    {
                        AppDialog.ShowError(ParentForm, "Lỗi xóa tệp", res.Message);
                    }
                }
            }
        };
    }

    private async Task SaveAllConfigAsync()
    {
        // 1. Kiểm tra Tab Trung tâm
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

        // 2. Kiểm tra trọng số điểm Tab 2
        int ParseWeight(string text)
        {
            var clean = text.Replace("%", "").Trim();
            return int.TryParse(clean, out var val) ? val : 0;
        }

        var w1 = ParseWeight(txtWeightRegular.Text);
        var w2 = ParseWeight(txtWeightMidterm.Text);
        var w3 = ParseWeight(txtWeightFinal.Text);
        var totalWeight = w1 + w2 + w3;

        if (totalWeight != 100)
        {
            tabMainConfig.SelectedTab = tabGrading;
            AppDialog.ShowError(ParentForm, "Ràng buộc trọng số",
                $"Tổng trọng số điểm ({w1}% + {w2}% + {w3}% = {totalWeight}%) bắt buộc phải đúng 100% trước khi lưu.");
            txtWeightRegular.Focus();
            return;
        }

        // 3. Tiến hành lưu
        Cursor = Cursors.WaitCursor;
        try
        {
            var centerDto = new CenterConfigDto
            {
                AppName = txtAppName.Text.Trim(),
                CenterShortName = txtShortName.Text.Trim(),
                LogoPath = _selectedLogoPath,
                CenterName = txtCenterName.Text.Trim(),
                CenterPhone = txtCenterPhone.Text.Trim(),
                CenterEmail = txtCenterEmail.Text.Trim(),
                CenterWebsite = txtCenterWebsite.Text.Trim(),
                CenterAddress = txtCenterAddress.Text.Trim(),
                DirectorName = txtDirector.Text.Trim(),
                DirectorTitle = txtDirectorTitle.Text.Trim(),
                StoragePath = txtStoragePath.Text.Trim(),
                BackupDir = txtBackupDir.Text.Trim()
            };

            var ruleDto = new AcademicRuleConfigDto
            {
                ScoreScale = cboScoreScale.SelectedItem?.ToString() ?? "Thang điểm 10 (0.0 - 10.0)",
                PassingScore = double.TryParse(txtPassingScore.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out var ps) ? ps : 6.5,
                WeightRegular = w1,
                WeightMidterm = w2,
                WeightFinal = w3,
                MinAttendanceRate = double.TryParse(txtMinAttendance.Text.Trim().Replace("%", ""), NumberStyles.Any, CultureInfo.InvariantCulture, out var ar) ? ar : 80.0,
                MaxAbsencesAlert = int.TryParse(txtAbsenceAlert.Text.Trim().Replace("Nghỉ từ", "").Replace("buổi", "").Trim(), out var ma) ? ma : 3,
                IsLateCounted = true,
                IsDebtBlockCert = true,
                IsAutoLockAttendance = false
            };

            var schedDto = new BackupScheduleConfigDto
            {
                IsAutoBackupEnabled = chkAutoBackup.Checked,
                BackupScheduleTime = cboBackupTime.SelectedItem?.ToString() ?? "23:00 hàng ngày"
            };

            await _configService.SaveCenterConfigAsync(centerDto, AppSession.UserId);
            await _configService.SaveAcademicRulesAsync(ruleDto, AppSession.UserId);
            await _configService.SaveBackupScheduleConfigAsync(schedDto, AppSession.UserId);

            // Cập nhật ngay thương hiệu (Tên App, Tên viết tắt, Logo) lên MainForm
            if (FindForm() is MainForm mf)
            {
                await mf.ApplyBrandingAsync();
            }

            // Đồng bộ AppSession nếu có thông tin người đại diện
            if (!string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                AppSession.FullName = txtDirector.Text.Trim();
            }
            if (!string.IsNullOrWhiteSpace(txtDirectorTitle.Text))
            {
                AppSession.SignerTitle = txtDirectorTitle.Text.Trim();
            }

            // bannerCenterSuccess.Visible = true;
            AppDialog.ShowSuccess(ParentForm, "Lưu cấu hình hệ thống",
                "Toàn bộ cấu hình hệ thống (Thông tin trung tâm, Quy tắc đánh giá & Chuyên cần, Lịch sao lưu) đã được lưu thành công vào CSDL SQLite.");
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi lưu cấu hình", $"Đã xảy ra lỗi khi lưu cấu hình: {ex.Message}");
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }
}
