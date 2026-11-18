using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class AuditLogService : IAuditLogService
{
    private readonly IAuditLogRepository _auditLogRepo;

    public AuditLogService(IAuditLogRepository? auditLogRepo = null)
    {
        _auditLogRepo = auditLogRepo ?? new AuditLogRepository();
    }

    public async Task<IEnumerable<AuditLogListItemDto>> GetLogsAsync(AuditLogFilterDto filter)
    {
        return await _auditLogRepo.GetLogsAsync(filter);
    }

    public async Task<int> GetTotalCountAsync(AuditLogFilterDto filter)
    {
        return await _auditLogRepo.GetTotalCountAsync(filter);
    }

    public async Task<IEnumerable<string>> GetDistinctActionNamesAsync()
    {
        return await _auditLogRepo.GetDistinctActionNamesAsync();
    }

    public async Task<IEnumerable<string>> GetDistinctTableNamesAsync()
    {
        return await _auditLogRepo.GetDistinctTableNamesAsync();
    }

    public async Task<AuditLogSummaryDto> GetSummaryAsync()
    {
        return await _auditLogRepo.GetSummaryAsync();
    }

    public async Task<byte[]> GenerateExcelReportAsync(AuditLogFilterDto filter)
    {
        // Khi xuất Excel, tăng Limit lên 5000 để xuất trọn vẹn dữ liệu được lọc
        var exportFilter = new AuditLogFilterDto
        {
            Keyword = filter.Keyword,
            ActionName = filter.ActionName,
            TableName = filter.TableName,
            FromDate = filter.FromDate,
            ToDate = filter.ToDate,
            Limit = 5000,
            Offset = 0
        };

        var logs = await _auditLogRepo.GetLogsAsync(exportFilter);

        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("AuditLogs");

        // 1. Tiêu đề chính
        ws.Cell(1, 1).Value = "HỆ THỐNG QUẢN LÝ TRUNG TÂM ANH NGỮ (ECMS)";
        ws.Cell(1, 1).Style.Font.Bold = true;
        ws.Cell(1, 1).Style.Font.FontSize = 14;
        ws.Cell(1, 1).Style.Font.FontColor = XLColor.FromArgb(30, 41, 59);

        ws.Cell(2, 1).Value = "BÁO CÁO NHẬT KÝ KIỂM TOÁN HỆ THỐNG (AUDIT LOG TRAIL - APPEND ONLY)";
        ws.Cell(2, 1).Style.Font.Bold = true;
        ws.Cell(2, 1).Style.Font.FontSize = 16;
        ws.Cell(2, 1).Style.Font.FontColor = XLColor.FromArgb(37, 99, 235);

        // 2. Thông tin thời gian xuất & bộ lọc
        ws.Cell(3, 1).Value = $"Ngày xuất báo cáo: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Người xuất: Quản trị viên (ROLE_ADMIN)";
        ws.Cell(3, 1).Style.Font.Italic = true;
        ws.Cell(3, 1).Style.Font.FontColor = XLColor.DimGray;

        string filterInfo = "Bộ lọc áp dụng: ";
        if (filter.FromDate.HasValue) filterInfo += $"Từ ngày {filter.FromDate.Value:dd/MM/yyyy} ";
        if (filter.ToDate.HasValue) filterInfo += $"Đến ngày {filter.ToDate.Value:dd/MM/yyyy} ";
        if (!string.IsNullOrWhiteSpace(filter.ActionName) && filter.ActionName != "ALL") filterInfo += $"| Hành động: {filter.ActionName} ";
        if (!string.IsNullOrWhiteSpace(filter.TableName) && filter.TableName != "ALL") filterInfo += $"| Bảng: {filter.TableName} ";
        if (!string.IsNullOrWhiteSpace(filter.Keyword)) filterInfo += $"| Từ khóa: '{filter.Keyword}' ";

        ws.Cell(4, 1).Value = filterInfo;
        ws.Cell(4, 1).Style.Font.FontSize = 10;
        ws.Cell(4, 1).Style.Font.FontColor = XLColor.FromArgb(71, 85, 105);

        // 3. Header bảng dữ liệu
        int headerRow = 6;
        string[] headers =
        {
            "STT",
            "Mã Log",
            "Thời Gian",
            "Tài Khoản",
            "Người Thực Hiện",
            "Vai Trò",
            "Hành Động",
            "Bảng Dữ Liệu",
            "Record ID",
            "Dữ Liệu Trước Sửa (Old)",
            "Dữ Liệu Sau Sửa (New)"
        };

        for (int i = 0; i < headers.Length; i++)
        {
            var cell = ws.Cell(headerRow, i + 1);
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Font.FontSize = 11;
            cell.Style.Font.FontColor = XLColor.White;
            cell.Style.Fill.BackgroundColor = XLColor.FromArgb(30, 41, 59); // Slate-800
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        }

        // 4. Đổ dữ liệu
        int currentRow = headerRow + 1;
        int stt = 1;

        foreach (var log in logs)
        {
            ws.Cell(currentRow, 1).Value = stt++;
            ws.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(currentRow, 2).Value = log.LogId;
            ws.Cell(currentRow, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(currentRow, 3).Value = log.FormattedTimestamp;
            ws.Cell(currentRow, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(currentRow, 4).Value = log.Username;
            ws.Cell(currentRow, 5).Value = log.ActorName;
            ws.Cell(currentRow, 6).Value = log.RoleName;

            ws.Cell(currentRow, 7).Value = log.ActionName;
            ws.Cell(currentRow, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell(currentRow, 7).Style.Font.Bold = true;

            ws.Cell(currentRow, 8).Value = log.TableName;
            ws.Cell(currentRow, 8).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(currentRow, 9).Value = log.RecordId ?? "-";
            ws.Cell(currentRow, 9).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(currentRow, 10).Value = log.OldValues ?? "-";
            ws.Cell(currentRow, 11).Value = log.NewValues ?? "-";

            // Zebra striping
            if (stt % 2 == 0)
            {
                ws.Range(currentRow, 1, currentRow, headers.Length).Style.Fill.BackgroundColor = XLColor.FromArgb(248, 250, 252);
            }

            currentRow++;
        }

        // Viền bảng
        if (currentRow > headerRow + 1)
        {
            var dataRange = ws.Range(headerRow, 1, currentRow - 1, headers.Length);
            dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.InsideBorderColor = XLColor.FromArgb(226, 232, 240);
            dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
            dataRange.Style.Border.OutsideBorderColor = XLColor.FromArgb(148, 163, 184);
        }

        ws.Columns(1, 9).AdjustToContents();
        ws.Column(10).Width = 35;
        ws.Column(11).Width = 40;

        using var ms = new MemoryStream();
        workbook.SaveAs(ms);
        return ms.ToArray();
    }
}
