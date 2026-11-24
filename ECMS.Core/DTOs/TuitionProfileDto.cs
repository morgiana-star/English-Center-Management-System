namespace ECMS.Core.DTOs;

public class TuitionProfileDto
{
    public int InvoiceId { get; set; }
    public string InvoiceCode { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public decimal OriginalFee { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalFee { get; set; }
    public decimal Paid { get; set; }
    public decimal Remaining { get; set; }
    public string DueDate { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
    public string DebtStatus { get; set; } = string.Empty;
}
