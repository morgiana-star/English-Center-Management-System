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

        // 1. Tự động khởi tạo CSDL SQLite (tạo 26 bảng & nạp tài khoản admin nếu chưa có)
        try
        {
            DatabaseInitializer.Initialize();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khởi tạo cơ sở dữ liệu SQLite: {ex.Message}", "Lỗi hệ thống", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 2. Mở màn hình đăng nhập trước
        using var loginForm = new LoginForm();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            // Đăng nhập thành công -> Mở MainForm chính
            Application.Run(new MainForm());
        }
    }
}
