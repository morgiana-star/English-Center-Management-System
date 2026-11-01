using System;
using ECMS.Core.Enums;

namespace ECMS.Core.Entities;

public class Invoice : BaseEntity
{
    public int InvoiceId { get; set; }
    public string InvoiceCode { get; set; } = string.Empty; // HD-yyyyMM-xxxx
    public int EnrollmentId { get; set; }
    public decimal OriginalAmount { get; set; }
    public decimal DiscountAmount { get; set; } = 0;
    public decimal FinalAmount { get; set; }
    public decimal BalanceDue { get; set; }
    public DateTime DueDate { get; set; }
    public InvoiceStatus Status { get; set; } = InvoiceStatus.Unpaid;
}

public class Payment : BaseEntity
{
    public int PaymentId { get; set; }
    public string PaymentCode { get; set; } = string.Empty; // PT-yyyyMMdd-xxxx
    public int InvoiceId { get; set; }
    public decimal PaidAmount { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.Now;
    public PaymentMethod Method { get; set; } = PaymentMethod.Cash;
    public int CashierId { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Valid;
    public string? Note { get; set; }
}

public class FeeDiscount : BaseEntity
{
    public int DiscountId { get; set; }
    public string DiscountName { get; set; } = string.Empty;
    public decimal Percentage { get; set; } = 0;
    public decimal FixedAmount { get; set; } = 0;
    public string? Description { get; set; }
    public bool RequiresApproval { get; set; } = false;
    public bool IsActive { get; set; } = true;
}
