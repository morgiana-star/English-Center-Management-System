using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class ReportPreviewExportDialog : Form
{
    public ReportPreviewExportDialog()
    {
        InitializeComponent();
        SetupView();
    }

    private void SetupView()
    {
        cboFormat.SelectedIndex = 0;

        gridReportData.Rows.Clear();
        gridReportData.Rows.Add("IELTS", "112.500.000đ", "26.400.000đ");
        gridReportData.Rows.Add("TOEIC", "48.000.000đ", "11.300.000đ");
        gridReportData.Rows.Add("Giao tiếp", "26.000.000đ", "5.200.000đ");
        gridReportData.Rows.Add("TỔNG CỘNG", "186.500.000đ", "42.900.000đ");

        btnClose.Click += (s, e) => Close();
        btnCancel.Click += (s, e) => Close();

        btnBrowseFolder.Click += (s, e) =>
        {
            using var fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn thư mục lưu tệp báo cáo tài chính";
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath.TrimEnd('\\') + "\\";
            }
        };

        btnConfirmSave.Click += (s, e) => ExecuteExport();
        btnSaveLocalTop.Click += (s, e) => ExecuteExport();
    }

    private void ExecuteExport()
    {
        string folder = txtFolder.Text.Trim();
        string filename = txtFileName.Text.Trim();

        if (string.IsNullOrWhiteSpace(filename))
        {
            MessageBox.Show("Vui lòng nhập tên tệp cần lưu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string fullPath = Path.Combine(string.IsNullOrWhiteSpace(folder) ? @"C:\ECMS\BaoCao" : folder, filename);

        try
        {
            string dir = Path.GetDirectoryName(fullPath) ?? @"C:\ECMS\BaoCao";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var sb = new StringBuilder();
            sb.AppendLine("Nhóm khóa,Đã thu trong kỳ,Còn phải thu");
            sb.AppendLine("IELTS,112500000,26400000");
            sb.AppendLine("TOEIC,48000000,11300000");
            sb.AppendLine("Giao tiếp,26000000,5200000");
            sb.AppendLine("TỔNG CỘNG,186500000,42900000");

            File.WriteAllText(fullPath, sb.ToString(), Encoding.UTF8);

            MessageBox.Show(
                $"Đã lưu thành công tệp báo cáo tài chính tại:\n[{fullPath}]\n\nĐịnh dạng: {cboFormat.SelectedItem}\nDữ liệu: Báo cáo thu học phí & công nợ kỳ 10/2026.",
                "Xuất báo cáo thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Không thể lưu tệp vào đường dẫn đã chọn:\n{ex.Message}\n\nVui lòng thử chọn một thư mục khác có quyền ghi.",
                "Lỗi ghi tệp cục bộ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
