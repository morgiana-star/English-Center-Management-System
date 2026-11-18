using System;
using System.Windows.Forms;
using ECMS.Data.Database;
using ECMS.UI.Forms;

namespace ECMS.UI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        try
        {
            DatabaseInitializer.Initialize();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khởi tạo cơ sở dữ liệu SQLite: {ex.Message}", "Lỗi hệ thống", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 2. Chạy ứng dụng từ MainForm
        Application.Run(new LoginForm());
    }
}
