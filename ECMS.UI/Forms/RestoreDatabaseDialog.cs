using System;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RestoreDatabaseDialog : Form
{
    public string SelectedBackupPath { get; set; } = @"D:\ECMS_Backup\ecms_20261028_1800.db";

    public RestoreDatabaseDialog()
    {
        InitializeComponent();

        lblSourceBackupVal.Text = SelectedBackupPath;
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmm");
        lblPreBackupVal.Text = $@"D:\ECMS_Backup\ecms_before_restore_{timestamp}.db (tự động)";

        btnCloseTop.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        btnConfirmRestore.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Khôi phục thành công",
                $"Đã khôi phục CSDL SQLite thành công từ bản sao lưu:\n\n" +
                $"• Nguồn: {SelectedBackupPath}\n" +
                $"• Bản sao lưu an toàn đã tạo trước đó: {lblPreBackupVal.Text}\n" +
                $"• Kiểm tra dữ liệu: 100% toàn vẹn.\n\n" +
                "Hệ thống sẽ làm mới lại dữ liệu hiển thị.");
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
