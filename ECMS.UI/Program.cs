using System;
using System.Windows.Forms;
using ECMS.Data.Database;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI;

static class Program
{
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
            AppDialog.ShowError(null, "Lỗi hệ thống", $"Lỗi khởi tạo cơ sở dữ liệu SQLite: {ex.Message}");
        }

        Application.Run(new LoginForm());
    }
}
