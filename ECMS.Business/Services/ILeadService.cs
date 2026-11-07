using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface ILeadService
{
    Task<IEnumerable<LeadListItemDto>> GetLeadsAsync(LeadFilterDto filter);
    Task<int> GetTotalCountAsync(LeadFilterDto filter);
    Task<LeadSummaryDto> GetSummaryAsync();
    Task<LeadCreateOrUpdateDto?> GetLeadByIdAsync(int leadId);
    Task<(bool Success, string Message, int LeadId)> CreateLeadAsync(LeadCreateOrUpdateDto dto, int? currentUserId = null);
    Task<(bool Success, string Message)> UpdateLeadAsync(LeadCreateOrUpdateDto dto, int? currentUserId = null);
    Task<(bool Success, string Message)> UpdateLeadStatusAsync(int leadId, string newStatus, int? currentUserId = null);
    Task<IEnumerable<string>> GetDistinctSourcesAsync();
}
