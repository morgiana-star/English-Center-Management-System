using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IAuditLogService
{
    Task<IEnumerable<AuditLogListItemDto>> GetLogsAsync(AuditLogFilterDto filter);
    Task<int> GetTotalCountAsync(AuditLogFilterDto filter);
    Task<IEnumerable<string>> GetDistinctActionNamesAsync();
    Task<IEnumerable<string>> GetDistinctTableNamesAsync();
    Task<AuditLogSummaryDto> GetSummaryAsync();
    Task<byte[]> GenerateExcelReportAsync(AuditLogFilterDto filter);
}
