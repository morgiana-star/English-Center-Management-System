namespace ECMS.Core.DTOs;

public class EligibleStudentDto
{
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public decimal FinalGPA { get; set; }
    public decimal AttendanceRate { get; set; }
    public decimal BalanceDue { get; set; }
    public bool IsEligible { get; set; }
    public string StatusText { get; set; } = string.Empty;
    public string GradeRank { get; set; } = "Khá";
    public string ScoreText { get; set; } = string.Empty;
    public string AttendanceText { get; set; } = string.Empty;
    public string TuitionText { get; set; } = string.Empty;
}
