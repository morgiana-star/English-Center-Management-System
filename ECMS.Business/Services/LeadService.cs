using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class LeadService : ILeadService
{
    private readonly ILeadRepository _leadRepo;
    private readonly IAuditLogRepository _auditLogRepo;

    public LeadService(ILeadRepository? leadRepo = null, IAuditLogRepository? auditLogRepo = null)
    {
        _leadRepo = leadRepo ?? new LeadRepository();
        _auditLogRepo = auditLogRepo ?? new AuditLogRepository();
    }

    public async Task<IEnumerable<LeadListItemDto>> GetLeadsAsync(LeadFilterDto filter)
    {
        return await _leadRepo.GetLeadsAsync(filter);
    }

    public async Task<int> GetTotalCountAsync(LeadFilterDto filter)
    {
        return await _leadRepo.GetTotalCountAsync(filter);
    }

    public async Task<LeadSummaryDto> GetSummaryAsync()
    {
        return await _leadRepo.GetSummaryAsync();
    }

    public async Task<LeadCreateOrUpdateDto?> GetLeadByIdAsync(int leadId)
    {
        return await _leadRepo.GetByIdAsync(leadId);
    }

    public async Task<(bool Success, string Message, int LeadId)> CreateLeadAsync(LeadCreateOrUpdateDto dto, int? currentUserId = null)
    {
        // 1. Validate FullName
        if (string.IsNullOrWhiteSpace(dto.FullName) || dto.FullName.Trim().Length < 2)
        {
            return (false, "Họ và tên khách hàng không được để trống và phải có ít nhất 2 ký tự.", 0);
        }

        // 2. Validate Phone
        string phone = dto.Phone?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(phone))
        {
            return (false, "Số điện thoại liên hệ là bắt buộc.", 0);
        }

        if (!Regex.IsMatch(phone, @"^0\d{9,10}$"))
        {
            return (false, "Số điện thoại không hợp lệ (Phải bắt đầu bằng số 0 và có từ 10 đến 11 chữ số).", 0);
        }

        // 3. Check duplicate phone
        bool isDuplicate = await _leadRepo.CheckPhoneExistsAsync(phone);
        if (isDuplicate)
        {
            return (false, $"Số điện thoại '{phone}' đã tồn tại trong danh sách tiếp nhận! Vui lòng kiểm tra lại để tránh trùng khách hàng.", 0);
        }

        // 4. Default values
        dto.FullName = dto.FullName.Trim();
        dto.Phone = phone;
        dto.Email = string.IsNullOrWhiteSpace(dto.Email) ? null : dto.Email.Trim();
        dto.Source = string.IsNullOrWhiteSpace(dto.Source) ? "Trực tiếp" : dto.Source.Trim();
        dto.Status = string.IsNullOrWhiteSpace(dto.Status) ? "New" : dto.Status.Trim();
        dto.Notes = string.IsNullOrWhiteSpace(dto.Notes) ? null : dto.Notes.Trim();

        // 5. Insert
        int newId = await _leadRepo.InsertAsync(dto);
        if (newId > 0)
        {
            await _auditLogRepo.LogAsync(
                currentUserId,
                "CREATE_LEAD",
                "Leads",
                newId.ToString(),
                null,
                $"Tiếp nhận khách tiềm năng: {dto.FullName} ({dto.Phone}) - Nguồn: {dto.Source}");

            return (true, $"Tiếp nhận khách hàng '{dto.FullName}' thành công!", newId);
        }

        return (false, "Không thể lưu thông tin khách hàng vào cơ sở dữ liệu.", 0);
    }

    public async Task<(bool Success, string Message)> UpdateLeadAsync(LeadCreateOrUpdateDto dto, int? currentUserId = null)
    {
        if (dto.LeadId <= 0)
        {
            return (false, "Mã khách hàng không hợp lệ.");
        }

        var existing = await _leadRepo.GetByIdAsync(dto.LeadId);
        if (existing == null)
        {
            return (false, "Không tìm thấy thông tin khách hàng cần cập nhật.");
        }

        // Validate FullName
        if (string.IsNullOrWhiteSpace(dto.FullName) || dto.FullName.Trim().Length < 2)
        {
            return (false, "Họ và tên khách hàng không được để trống.");
        }

        // Validate Phone
        string phone = dto.Phone?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, @"^0\d{9,10}$"))
        {
            return (false, "Số điện thoại không hợp lệ (Phải bắt đầu bằng số 0 và có từ 10 đến 11 số).");
        }

        // Check duplicate phone for other leads
        bool isDuplicate = await _leadRepo.CheckPhoneExistsAsync(phone, dto.LeadId);
        if (isDuplicate)
        {
            return (false, $"Số điện thoại '{phone}' đã được sử dụng bởi một khách hàng khác.");
        }

        dto.FullName = dto.FullName.Trim();
        dto.Phone = phone;
        dto.Email = string.IsNullOrWhiteSpace(dto.Email) ? null : dto.Email.Trim();
        dto.Source = string.IsNullOrWhiteSpace(dto.Source) ? "Trực tiếp" : dto.Source.Trim();
        dto.Notes = string.IsNullOrWhiteSpace(dto.Notes) ? null : dto.Notes.Trim();

        bool ok = await _leadRepo.UpdateAsync(dto);
        if (ok)
        {
            await _auditLogRepo.LogAsync(
                currentUserId,
                "UPDATE_LEAD",
                "Leads",
                dto.LeadId.ToString(),
                $"Status: {existing.Status}, Phone: {existing.Phone}",
                $"Status: {dto.Status}, Phone: {dto.Phone}, Notes: {dto.Notes}");

            return (true, "Cập nhật thông tin khách hàng thành công!");
        }

        return (false, "Cập nhật dữ liệu thất bại.");
    }

    public async Task<(bool Success, string Message)> UpdateLeadStatusAsync(int leadId, string newStatus, int? currentUserId = null)
    {
        var existing = await _leadRepo.GetByIdAsync(leadId);
        if (existing == null)
        {
            return (false, "Không tìm thấy thông tin khách hàng.");
        }

        bool ok = await _leadRepo.UpdateStatusAsync(leadId, newStatus);
        if (ok)
        {
            await _auditLogRepo.LogAsync(
                currentUserId,
                "UPDATE_LEAD_STATUS",
                "Leads",
                leadId.ToString(),
                $"Trạng thái cũ: {existing.Status}",
                $"Trạng thái mới: {newStatus}");

            return (true, $"Đã cập nhật trạng thái khách hàng thành công!");
        }

        return (false, "Không thể cập nhật trạng thái khách hàng.");
    }

    public async Task<IEnumerable<string>> GetDistinctSourcesAsync()
    {
        return await _leadRepo.GetDistinctSourcesAsync();
    }
}
