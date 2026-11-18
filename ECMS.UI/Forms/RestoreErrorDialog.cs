using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class RestoreErrorDialog : Form
{
    public RestoreErrorDialog()
    {
        InitializeComponent();

        btnCloseTop.Click += (s, e) => Close();
        btnClose.Click += (s, e) => Close();

        lblLogVal.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(this, "Xem nhật ký lỗi",
                "Đang mở tệp nhật ký ngoại tuyến:\nC:\\ECMS\\Logs\\restore.log\n\n" +
                "[2026-10-30 16:30:12] ERROR DB-RESTORE-02: SQLite database file header mismatch.\n" +
                "[2026-10-30 16:30:12] PRAGMA integrity_check failed: file is not a database.");
        };

        btnChooseOther.Click += (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp sao lưu SQLite khác",
                Filter = "SQLite Backup (*.db)|*.db|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                Close();
                using var restoreDlg = new RestoreDatabaseDialog
                {
                    SelectedBackupPath = ofd.FileName
                };
                restoreDlg.ShowDialog();
            }
        };
    }
}
