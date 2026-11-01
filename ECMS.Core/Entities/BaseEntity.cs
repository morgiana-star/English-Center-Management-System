using System;

namespace ECMS.Core.Entities;

public abstract class BaseEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}
