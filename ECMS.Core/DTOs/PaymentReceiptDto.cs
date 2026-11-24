namespace ECMS.Core.DTOs;

public class PaymentReceiptDto
{
    public int PaymentId { get; set; }
    public string ReceiptCode { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Method { get; set; } = string.Empty;
    public string Collector { get; set; } = string.Empty;
}
