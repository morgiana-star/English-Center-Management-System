using System;

namespace ECMS.Core.Entities;

public class AuditLog
{
    public int LogId { get; set; }
    public int? UserId { get; set; }
    public string ActionName { get; set; } = string.Empty; // INSERT, UPDATE, DELETE, LOGIN
    public string TableName { get; set; } = string.Empty;
    public string? RecordId { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
}

public class SystemConfig
{
    public string ConfigKey { get; set; } = string.Empty;
    public string? ConfigValue { get; set; }
    public string? Description { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public class Notification : BaseEntity
{
    public int NotificationId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string TargetAudience { get; set; } = "All"; // All, Teachers, Staff
    public DateTime PublishDate { get; set; } = DateTime.Now;
    public DateTime? ExpiryDate { get; set; }
}
