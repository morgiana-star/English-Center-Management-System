using System;

namespace ECMS.Core.DTOs;

public class InvoiceListItemDto
{
    public int InvoiceId { get; set; }
    public string InvoiceCode { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string StudentPhone { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public decimal OriginalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalAmount { get; set; }
    public decimal PaidAmount => FinalAmount - BalanceDue;
    public decimal BalanceDue { get; set; }
    public string DueDate { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}

public class ReceiptPrintDto
{
    public string ReceiptCode { get; set; } = string.Empty;
    public string InvoiceCode { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string StudentPhone { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public decimal FinalAmount { get; set; }
    public decimal AmountPaidThisTime { get; set; }
    public decimal BalanceRemaining { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string PaymentDate { get; set; } = string.Empty;
    public string CashierName { get; set; } = string.Empty;
    public string? Note { get; set; }
}

public class DirectorDashboardSummaryDto
{
    public decimal TotalRevenueThisMonth { get; set; }
    public decimal TotalRevenueLastMonth { get; set; }
    public decimal TotalOutstandingDebt { get; set; }
    public decimal CollectionRate { get; set; }
    public int TotalActiveStudents { get; set; }
    public int TotalActiveClasses { get; set; }
    public int TotalPaidInvoicesCount { get; set; }
    public int TotalPaymentsCount { get; set; }
}

public class DailyPaymentTransactionDto
{
    public int PaymentId { get; set; }
    public string PaymentCode { get; set; } = string.Empty;
    public string InvoiceCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public decimal PaidAmount { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string PaymentTime { get; set; } = string.Empty;
    public string CashierName { get; set; } = string.Empty;
}
