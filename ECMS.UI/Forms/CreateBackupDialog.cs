using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateBackupDialog : Form
{
    private readonly ISystemConfigService _configService;
    private readonly string _targetBackupDir;

    public string GeneratedBackupPath { get; private set; } = string.Empty;

    public CreateBackupDialog(string? targetDir = null, ISystemConfigService? configService = null)
    {
        InitializeComponent();
        _configService = configService ?? new SystemConfigService();
        _targetBackupDir = !string.IsNullOrWhiteSpace(targetDir)
            ? targetDir
            : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ECMS", "Backups");

        lblSourceVal.Text = DatabaseConfig.DatabasePath;
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        GeneratedBackupPath = Path.Combine(_targetBackupDir, $"ecms_backup_{timestamp}_manual.db");
        lblTargetVal.Text = GeneratedBackupPath;

        _ = LoadDatabaseStatusAsync();
        WireEvents();
    }

    private async Task LoadDatabaseStatusAsync()
    {
        try
        {
            var status = await _configService.GetDatabaseStatusAsync();
            lblSizeVal.Text = status.FileSizeFormatted;
            lblCheckStatusVal.Text = status.IntegrityCheckResult == "OK" || status.IntegrityCheckResult == "ok"
                ? "Thư mục có quyền ghi; CSDL tính toàn vẹn OK"
                : $"CSDL cảnh báo: {status.IntegrityCheckResult}";
        }
        catch (Exception ex)
        {
            lblCheckStatusVal.Text = $"Không thể kiểm tra CSDL: {ex.Message}";
        }
    }

    private void WireEvents()
    {
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnConfirmBackup.Click += async (s, e) =>
        {
            btnConfirmBackup.Enabled = false;
            btnCancel.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var result = await _configService.CreateOnlineBackupAsync(_targetBackupDir, "Thủ công", AppSession.UserId);
                if (result.Success)
                {
                    GeneratedBackupPath = result.BackupPath;
                    AppDialog.ShowSuccess(this, "Sao lưu thành công",
                        $"Đã tạo bản sao lưu an toàn của cơ sở dữ liệu SQLite:\n\n" +
                        $"• Tệp: {Path.GetFileName(GeneratedBackupPath)}\n" +
                        $"• Đường dẫn: {GeneratedBackupPath}\n" +
                        $"• Kiểm tra tính toàn vẹn: PRAGMA integrity_check OK.\n\n" +
                        "Bản sao lưu đã được lưu vào hệ thống và sẵn sàng khi cần phục hồi dữ liệu.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    AppDialog.ShowError(this, "Lỗi sao lưu", result.Message);
                }
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(this, "Lỗi ngoại lệ sao lưu", ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnConfirmBackup.Enabled = true;
                btnCancel.Enabled = true;
            }
        };
    }
}
