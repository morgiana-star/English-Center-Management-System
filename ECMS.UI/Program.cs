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
            string sampleExcelPath = @"E:\ECMS\DanhSachHocVien_Import.xlsx";
            if (System.IO.Directory.Exists(@"E:\ECMS") && !System.IO.File.Exists(sampleExcelPath))
            {
                var bytes = new ECMS.Business.Services.StudentService().GenerateStudentImportTemplate();
                System.IO.File.WriteAllBytes(sampleExcelPath, bytes);
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(null, "Lỗi hệ thống", $"Lỗi khởi tạo cơ sở dữ liệu SQLite: {ex.Message}");
        }

        Application.Run(new LoginForm());
    }
}
