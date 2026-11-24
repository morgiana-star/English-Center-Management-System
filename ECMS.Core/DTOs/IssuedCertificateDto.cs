namespace ECMS.Core.DTOs;

public class IssuedCertificateDto
{
    public int CertificateId { get; set; }
    public string SerialNumber { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string IssueDate { get; set; } = string.Empty;
    public string Approver { get; set; } = string.Empty;
    public string Status { get; set; } = "Đã cấp · Chưa in";
    public string Score { get; set; } = "8.0 / 10";
    public string GradeRank { get; set; } = "Giỏi";
    public string Attendance { get; set; } = "95%";
}
