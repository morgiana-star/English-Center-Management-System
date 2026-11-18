using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface ILeadRepository
{
    Task<IEnumerable<LeadListItemDto>> GetLeadsAsync(LeadFilterDto filter);
    Task<int> GetTotalCountAsync(LeadFilterDto filter);
    Task<LeadCreateOrUpdateDto?> GetByIdAsync(int leadId);
    Task<int> InsertAsync(LeadCreateOrUpdateDto dto);
    Task<bool> UpdateAsync(LeadCreateOrUpdateDto dto);
    Task<bool> UpdateStatusAsync(int leadId, string status);
    Task<LeadSummaryDto> GetSummaryAsync();
    Task<bool> CheckPhoneExistsAsync(string phone, int? excludeLeadId = null);
    Task<IEnumerable<string>> GetDistinctSourcesAsync();
}
