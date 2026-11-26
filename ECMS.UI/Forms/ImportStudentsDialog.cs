using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại nhập danh sách học viên hàng loạt từ tệp Excel (.xlsx) hoặc CSV
/// </summary>
public partial class ImportStudentsDialog : Form
{
    private readonly IStudentService _studentService = new StudentService();
    private List<StudentImportRowDto> _rows = new();

    public ImportStudentsDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupControls();
        WireEvents();
    }

    private void SetupControls()
    {
        cboRowFilter.Items.Clear();
        cboRowFilter.Items.AddRange(new object[] { "Tất cả dòng", "Chỉ dòng hợp lệ", "Chỉ dòng bị lỗi" });
        cboRowFilter.SelectedIndex = 0;

        AppGridHelper.ApplyStyle(dgvPreview);
        dgvPreview.Columns.Clear();
        dgvPreview.Columns.Add("ColRow", "Dòng");
        dgvPreview.Columns.Add("ColName", "Họ và tên");
        dgvPreview.Columns.Add("ColDob", "Ngày sinh");
        dgvPreview.Columns.Add("ColGender", "Giới tính");
        dgvPreview.Columns.Add("ColPhone", "Số điện thoại");
        dgvPreview.Columns.Add("ColEmail", "Email");
        dgvPreview.Columns.Add("ColAddress", "Địa chỉ");
        dgvPreview.Columns.Add("ColParent", "Phụ huynh / SĐT");
        dgvPreview.Columns.Add("ColStatus", "Trạng thái kiểm tra");

        dgvPreview.Columns["ColRow"]!.FillWeight = 6;
        dgvPreview.Columns["ColName"]!.FillWeight = 15;
        dgvPreview.Columns["ColDob"]!.FillWeight = 10;
        dgvPreview.Columns["ColGender"]!.FillWeight = 7;
        dgvPreview.Columns["ColPhone"]!.FillWeight = 11;
        dgvPreview.Columns["ColEmail"]!.FillWeight = 14;
        dgvPreview.Columns["ColAddress"]!.FillWeight = 13;
        dgvPreview.Columns["ColParent"]!.FillWeight = 13;
        dgvPreview.Columns["ColStatus"]!.FillWeight = 21;
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();
        btnDownloadTemplate.Click += (s, e) => DownloadTemplate();
        btnChooseFile.Click += async (s, e) => await ChooseAndParseFileAsync();
        btnExecuteImport.Click += async (s, e) => await ExecuteImportAsync();
        cboRowFilter.SelectedIndexChanged += (s, e) => BindPreviewGrid();
    }

    private void DownloadTemplate()
    {
        try
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Lưu tệp mẫu nhập danh sách học viên",
                Filter = "Tệp Excel (*.xlsx)|*.xlsx",
                FileName = $"Mau_Nhap_HocVien_ECMS_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            byte[] bytes = _studentService.GenerateStudentImportTemplate();
            File.WriteAllBytes(sfd.FileName, bytes);

            if (AppDialog.ShowConfirm(this, "Tải tệp mẫu thành công",
                $"Đã lưu tệp mẫu tại:\n{sfd.FileName}\n\nBạn có muốn mở tệp mẫu ngay bây giờ không?") == DialogResult.OK)
            {
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tạo tệp mẫu", ex.Message);
        }
    }

    private async Task ChooseAndParseFileAsync()
    {
        try
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp Excel hoặc CSV danh sách học viên",
                Filter = "Tệp Excel & CSV (*.xlsx;*.csv)|*.xlsx;*.csv|Tệp Excel (*.xlsx)|*.xlsx|Tệp CSV (*.csv)|*.csv"
            };

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            btnChooseFile.Enabled = false;
            lblFileNotice.Text = "Đang đọc và kiểm tra dữ liệu...";

            using var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _rows = await _studentService.ParseAndValidateStudentFileAsync(fs, ofd.FileName);

            int validCount = _rows.Count(x => x.IsValid);
            int invalidCount = _rows.Count - validCount;

            lblTotalSummary.Text = $"Tổng số: {_rows.Count} dòng";
            lblValidSummary.Text = $"Hợp lệ: {validCount}";
            lblInvalidSummary.Text = $"Lỗi: {invalidCount}";
            lblFileNotice.Text = $"Tệp: {Path.GetFileName(ofd.FileName)}";

            btnExecuteImport.Text = $"Tiến hành nhập ({validCount})";
            btnExecuteImport.Enabled = validCount > 0;

            BindPreviewGrid();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi đọc tệp dữ liệu",
                $"Không thể đọc tệp đã chọn. Hãy đảm bảo tệp không đang bị khóa bởi chương trình khác.\n\nChi tiết: {ex.Message}");
            lblFileNotice.Text = "Lỗi nạp tệp.";
        }
        finally
        {
            btnChooseFile.Enabled = true;
        }
    }

    private void BindPreviewGrid()
    {
        dgvPreview.Rows.Clear();

        IEnumerable<StudentImportRowDto> filtered = cboRowFilter.SelectedIndex switch
        {
            1 => _rows.Where(x => x.IsValid),
            2 => _rows.Where(x => !x.IsValid),
            _ => _rows
        };

        foreach (var item in filtered)
        {
            string parentInfo = string.IsNullOrWhiteSpace(item.ParentName)
                ? "-"
                : $"{item.ParentName} ({item.ParentPhone})";

            int idx = dgvPreview.Rows.Add(
                item.RowIndex,
                item.FullName,
                item.DateOfBirthDisplay,
                item.Gender,
                item.Phone,
                item.Email ?? "",
                item.Address ?? "",
                parentInfo,
                item.ValidationMessage
            );

            var statusCell = dgvPreview.Rows[idx].Cells["ColStatus"];
            if (item.IsValid)
            {
                statusCell.Style.ForeColor = Color.FromArgb(22, 101, 52);
                statusCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            else
            {
                statusCell.Style.ForeColor = Color.FromArgb(185, 28, 28);
                statusCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                dgvPreview.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(254, 242, 242);
            }
        }

        dgvPreview.ClearSelection();
    }

    private async Task ExecuteImportAsync()
    {
        int validCount = _rows.Count(x => x.IsValid);
        if (validCount == 0)
        {
            AppDialog.ShowWarning(this, "Không có dữ liệu hợp lệ", "Không có dòng hợp lệ nào để nhập vào hệ thống.");
            return;
        }

        if (AppDialog.ShowConfirm(this, "Xác nhận nhập học viên",
            $"Bạn có chắc chắn muốn nhập {validCount} học viên hợp lệ vào cơ sở dữ liệu không?",
            "Xác nhận nhập", "Hủy") != DialogResult.OK)
        {
            return;
        }

        try
        {
            btnExecuteImport.Enabled = false;
            var result = await _studentService.ExecuteImportStudentsAsync(_rows);

            if (result.SuccessCount > 0)
            {
                string summary = $"Đã nhập thành công {result.SuccessCount} học viên mới vào hệ thống (trạng thái Chờ xếp lớp).";
                if (result.ErrorCount > 0)
                {
                    summary += $"\nCó {result.ErrorCount} dòng bị bỏ qua do lỗi.";
                }
                AppDialog.ShowSuccess(this, "Nhập dữ liệu thành công", summary);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string errDetail = result.ErrorMessages.Count > 0 ? string.Join("\n", result.ErrorMessages.Take(5)) : "Không có học viên nào được lưu.";
                AppDialog.ShowError(this, "Nhập dữ liệu thất bại", errDetail);
                btnExecuteImport.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi hệ thống", ex.Message);
            btnExecuteImport.Enabled = true;
        }
    }
}
