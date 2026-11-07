using System;

namespace ECMS.Core.DTOs;

public class LeadListItemDto
{
    public int LeadId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Source { get; set; } = "Trực tiếp";
    public string Status { get; set; } = "New";
    public int? AssignedEmployeeId { get; set; }
    public string? AssignedEmployeeName { get; set; }
    public string? Notes { get; set; }
    public string CreatedAt { get; set; } = string.Empty;

    public string FormattedCreatedAt
    {
        get
        {
            if (DateTime.TryParse(CreatedAt, out var dt))
            {
                return dt.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
            }
            return CreatedAt;
        }
    }

    public string StatusText => Status switch
    {
        "New" => "Mới tiếp nhận",
        "Contacted" => "Đang tư vấn",
        "TestScheduled" => "Đã hẹn Test",
        "Converted" => "Đã chốt nhập học",
        "Lost" => "Không có nhu cầu",
        _ => Status
    };
}

public class LeadCreateOrUpdateDto
{
    public int LeadId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Source { get; set; } = "Trực tiếp";
    public string Status { get; set; } = "New";
    public int? AssignedEmployeeId { get; set; }
    public string? Notes { get; set; }
}

public class LeadFilterDto
{
    public string? Keyword { get; set; }
    public string? Status { get; set; }
    public string? Source { get; set; }
    public int Limit { get; set; } = 500;
    public int Offset { get; set; } = 0;
}

public class LeadSummaryDto
{
    public int TotalLeads { get; set; }
    public int NewLeads { get; set; }
    public int ContactedLeads { get; set; }
    public int TestScheduledLeads { get; set; }
    public int ConvertedLeads { get; set; }
    public int LostLeads { get; set; }
}
