namespace ECMS.Core.DTOs;

public class AuditLogListItemDto
{
    public int LogId { get; set; }
    public int? UserId { get; set; }
    public string Username { get; set; } = "SYSTEM";
    public string ActorName { get; set; } = "Hệ thống";
    public string RoleName { get; set; } = string.Empty;
    public string ActionName { get; set; } = string.Empty;
    public string TableName { get; set; } = string.Empty;
    public string? RecordId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string Timestamp { get; set; } = string.Empty;

    public string FormattedTimestamp
    {
        get
        {
            if (DateTime.TryParse(Timestamp, out var dt))
            {
                return dt.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss");
            }
            return Timestamp;
        }
    }
}

public class AuditLogFilterDto
{
    public string? Keyword { get; set; }
    public string? ActionName { get; set; }
    public string? TableName { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public int Limit { get; set; } = 500;
    public int Offset { get; set; } = 0;
}

public class AuditLogSummaryDto
{
    public int TotalLogs { get; set; }
    public int TodayLogs { get; set; }
    public int UniqueUsersCount { get; set; }
    public int SecurityEventsCount { get; set; }
}
