using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using static ECMS.UI.UserControls.TuitionPaymentView;

namespace ECMS.UI.Services;

public static class ExcelExportService
{
    public static void ExportTuitionDebtReport(string filePath, IEnumerable<TuitionProfileModel> profiles)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("BaoCaoCongNo");

        // 1. Tiêu đề báo cáo
        worksheet.Cell(1, 1).Value = "TRUNG TÂM ANH NGỮ QUỐC TẾ ECMS";
        worksheet.Cell(1, 1).Style.Font.Bold = true;
        worksheet.Cell(1, 1).Style.Font.FontSize = 13;
        worksheet.Cell(1, 1).Style.Font.FontColor = XLColor.FromHtml("#1E3A8A");

        worksheet.Cell(2, 1).Value = "BÁO CÁO THEO DÕI CÔNG NỢ HỌC PHÍ";
        worksheet.Cell(2, 1).Style.Font.Bold = true;
        worksheet.Cell(2, 1).Style.Font.FontSize = 16;
        worksheet.Cell(2, 1).Style.Font.FontColor = XLColor.FromHtml("#2563EB");

        worksheet.Cell(3, 1).Value = $"Ngày xuất báo cáo: {DateTime.Now:dd/MM/yyyy HH:mm} · Người xuất: {AppSession.FullName}";
        worksheet.Cell(3, 1).Style.Font.Italic = true;
        worksheet.Cell(3, 1).Style.Font.FontSize = 10;
        worksheet.Cell(3, 1).Style.Font.FontColor = XLColor.FromHtml("#64748B");

        // 2. Tiêu đề cột
        int headerRow = 5;
        string[] headers = 
        { 
            "STT", "Mã học viên", "Họ và tên", "Khóa học", "Lớp học", 
            "Học phí gốc", "Giảm trừ", "Tổng phải thu", "Đã thanh toán", "Còn nợ", "Hạn nộp", "Trạng thái nợ" 
        };

        for (int i = 0; i < headers.Length; i++)
        {
            var cell = worksheet.Cell(headerRow, i + 1);
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Font.FontColor = XLColor.White;
            cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#2563EB");
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        }

        // 3. Dữ liệu
        int currentRow = 6;
        int stt = 1;
        var list = profiles.ToList();

        foreach (var p in list)
        {
            worksheet.Cell(currentRow, 1).Value = stt++;
            worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 2).Value = p.StudentCode;
            worksheet.Cell(currentRow, 2).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 3).Value = p.StudentName;
            worksheet.Cell(currentRow, 3).Style.Font.Bold = true;

            worksheet.Cell(currentRow, 4).Value = p.CourseName;
            worksheet.Cell(currentRow, 5).Value = p.ClassName;

            worksheet.Cell(currentRow, 6).Value = p.OriginalFee;
            worksheet.Cell(currentRow, 6).Style.NumberFormat.Format = "#,##0 \"đ\"";

            worksheet.Cell(currentRow, 7).Value = p.Discount;
            worksheet.Cell(currentRow, 7).Style.NumberFormat.Format = "#,##0 \"đ\"";

            worksheet.Cell(currentRow, 8).Value = p.TotalFee;
            worksheet.Cell(currentRow, 8).Style.NumberFormat.Format = "#,##0 \"đ\"";

            worksheet.Cell(currentRow, 9).Value = p.Paid;
            worksheet.Cell(currentRow, 9).Style.NumberFormat.Format = "#,##0 \"đ\"";
            worksheet.Cell(currentRow, 9).Style.Font.FontColor = XLColor.FromHtml("#16A34A");

            worksheet.Cell(currentRow, 10).Value = p.Remaining;
            worksheet.Cell(currentRow, 10).Style.NumberFormat.Format = "#,##0 \"đ\"";
            worksheet.Cell(currentRow, 10).Style.Font.Bold = true;
            if (p.Remaining > 0)
            {
                worksheet.Cell(currentRow, 10).Style.Font.FontColor = XLColor.FromHtml("#DC2626");
            }

            worksheet.Cell(currentRow, 11).Value = p.DueDate;
            worksheet.Cell(currentRow, 11).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 12).Value = p.DebtStatus;
            worksheet.Cell(currentRow, 12).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            currentRow++;
        }

        // 4. Dòng tổng cộng
        if (list.Count > 0)
        {
            worksheet.Cell(currentRow, 3).Value = "TỔNG CỘNG";
            worksheet.Cell(currentRow, 3).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

            worksheet.Cell(currentRow, 8).FormulaA1 = $"SUM(H6:H{currentRow - 1})";
            worksheet.Cell(currentRow, 8).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 8).Style.NumberFormat.Format = "#,##0 \"đ\"";

            worksheet.Cell(currentRow, 9).FormulaA1 = $"SUM(I6:I{currentRow - 1})";
            worksheet.Cell(currentRow, 9).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 9).Style.NumberFormat.Format = "#,##0 \"đ\"";
            worksheet.Cell(currentRow, 9).Style.Font.FontColor = XLColor.FromHtml("#16A34A");

            worksheet.Cell(currentRow, 10).FormulaA1 = $"SUM(J6:J{currentRow - 1})";
            worksheet.Cell(currentRow, 10).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 10).Style.NumberFormat.Format = "#,##0 \"đ\"";
            worksheet.Cell(currentRow, 10).Style.Font.FontColor = XLColor.FromHtml("#DC2626");

            worksheet.Range(currentRow, 1, currentRow, headers.Length).Style.Fill.BackgroundColor = XLColor.FromHtml("#F1F5F9");
            worksheet.Range(currentRow, 1, currentRow, headers.Length).Style.Border.TopBorder = XLBorderStyleValues.Thin;
            worksheet.Range(currentRow, 1, currentRow, headers.Length).Style.Border.BottomBorder = XLBorderStyleValues.Double;
        }

        // 5. Viền toàn bảng và tự căn chỉnh độ rộng
        var dataRange = worksheet.Range(headerRow, 1, currentRow, headers.Length);
        dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
    }

    public static void ExportCertificateRegistryReport(string filePath, IEnumerable<IssuedCertificateModel> certs)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("SoChungChi");

        // 1. Tiêu đề
        worksheet.Cell(1, 1).Value = "TRUNG TÂM ANH NGỮ QUỐC TẾ ECMS";
        worksheet.Cell(1, 1).Style.Font.Bold = true;
        worksheet.Cell(1, 1).Style.Font.FontSize = 13;
        worksheet.Cell(1, 1).Style.Font.FontColor = XLColor.FromHtml("#1E3A8A");

        worksheet.Cell(2, 1).Value = "SỔ QUẢN LÝ LƯU TRỮ CHỨNG CHỈ TỐT NGHIỆP";
        worksheet.Cell(2, 1).Style.Font.Bold = true;
        worksheet.Cell(2, 1).Style.Font.FontSize = 16;
        worksheet.Cell(2, 1).Style.Font.FontColor = XLColor.FromHtml("#2563EB");

        worksheet.Cell(3, 1).Value = $"Ngày xuất sổ: {DateTime.Now:dd/MM/yyyy HH:mm} · Người lập: {AppSession.FullName}";
        worksheet.Cell(3, 1).Style.Font.Italic = true;
        worksheet.Cell(3, 1).Style.Font.FontSize = 10;
        worksheet.Cell(3, 1).Style.Font.FontColor = XLColor.FromHtml("#64748B");

        // 2. Tiêu đề cột
        int headerRow = 5;
        string[] headers = 
        { 
            "STT", "Số hiệu chứng chỉ", "Mã học viên", "Họ và tên", "Khóa học", "Lớp học", 
            "Điểm tốt nghiệp", "Xếp loại", "Chuyên cần", "Ngày cấp", "Người ký duyệt", "Trạng thái in" 
        };

        for (int i = 0; i < headers.Length; i++)
        {
            var cell = worksheet.Cell(headerRow, i + 1);
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Font.FontColor = XLColor.White;
            cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#16A34A");
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        }

        // 3. Dữ liệu
        int currentRow = 6;
        int stt = 1;
        var list = certs.ToList();

        foreach (var c in list)
        {
            worksheet.Cell(currentRow, 1).Value = stt++;
            worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 2).Value = c.SerialNumber;
            worksheet.Cell(currentRow, 2).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 2).Style.Font.FontColor = XLColor.FromHtml("#2563EB");
            worksheet.Cell(currentRow, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 3).Value = c.StudentCode;
            worksheet.Cell(currentRow, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 4).Value = c.StudentName;
            worksheet.Cell(currentRow, 4).Style.Font.Bold = true;

            worksheet.Cell(currentRow, 5).Value = c.CourseName;
            worksheet.Cell(currentRow, 6).Value = c.ClassName;

            worksheet.Cell(currentRow, 7).Value = c.Score;
            worksheet.Cell(currentRow, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 8).Value = c.GradeRank;
            worksheet.Cell(currentRow, 8).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            worksheet.Cell(currentRow, 8).Style.Font.Bold = true;

            worksheet.Cell(currentRow, 9).Value = c.Attendance;
            worksheet.Cell(currentRow, 9).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 10).Value = c.IssueDate;
            worksheet.Cell(currentRow, 10).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(currentRow, 11).Value = c.Approver;
            worksheet.Cell(currentRow, 12).Value = c.Status;
            worksheet.Cell(currentRow, 12).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            currentRow++;
        }

        var dataRange = worksheet.Range(headerRow, 1, currentRow - 1, headers.Length);
        dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
    }
}
