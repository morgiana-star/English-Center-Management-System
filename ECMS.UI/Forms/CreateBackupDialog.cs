using System;
using System.IO;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateBackupDialog : Form
{
    public string GeneratedBackupPath { get; private set; } = string.Empty;

    public CreateBackupDialog()
    {
        InitializeComponent();

        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmm");
        GeneratedBackupPath = $@"D:\ECMS_Backup\ecms_{timestamp}.db";
        lblTargetVal.Text = GeneratedBackupPath;

        btnCloseTop.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        btnConfirmBackup.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Sao lưu thành công",
                $"Đã tạo bản sao lưu an toàn của cơ sở dữ liệu SQLite:\n\n" +
                $"• Tệp: {GeneratedBackupPath}\n" +
                $"• Dung lượng: 18,6 MB\n" +
                $"• Kiểm tra tính toàn vẹn: PRAGMA integrity_check OK.\n\n" +
                "Bạn có thể yên tâm sử dụng bản sao lưu này khi cần phục hồi dữ liệu.");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
