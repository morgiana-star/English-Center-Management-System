using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

/// <summary>
/// Repository quản lý nhật ký kiểm toán hệ thống.
/// Tuân thủ nghiêm ngặt nguyên tắc Append-Only (Chỉ thêm và đọc, KHÔNG sửa, KHÔNG xóa).
/// </summary>
public interface IAuditLogRepository
{
    Task<IEnumerable<AuditLogListItemDto>> GetLogsAsync(AuditLogFilterDto filter);
    Task<int> GetTotalCountAsync(AuditLogFilterDto filter);
    Task<IEnumerable<string>> GetDistinctActionNamesAsync();
    Task<IEnumerable<string>> GetDistinctTableNamesAsync();
    Task<AuditLogSummaryDto> GetSummaryAsync();
    Task<int> LogAsync(int? userId, string actionName, string tableName, string? recordId, string? oldValues, string? newValues);
}
