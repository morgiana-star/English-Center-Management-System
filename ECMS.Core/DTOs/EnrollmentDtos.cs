using System;

namespace ECMS.Core.DTOs;

public class ClassLookupDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public decimal TuitionFee { get; set; }
    public string? RoomName { get; set; }
    public string? TeacherName { get; set; }
    public int CurrentStudents { get; set; }
    public int MaxStudents { get; set; }
    public string Status { get; set; } = "OpenForEnrollment";

    public bool IsFull => CurrentStudents >= MaxStudents;

    public string CapacityDisplay => $"{CurrentStudents}/{MaxStudents} học viên";

    public string FormattedTuitionFee => $"{TuitionFee:N0} VNĐ";

    public string DisplayText => $"{ClassName} ({CourseName}) - Sĩ số: {CapacityDisplay} - Học phí: {FormattedTuitionFee}" + (IsFull ? " [HẾT CHỖ]" : "");
}

public class StudentEnrollmentDto
{
    public int StudentId { get; set; } = 0; // 0 nếu là học viên mới
    public int? LeadId { get; set; } // Null nếu đăng ký vãng lai
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-18);
    public string Gender { get; set; } = "Nam";
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public int ClassId { get; set; }
    public string? Notes { get; set; }
}

public class EnrollmentListItemDto
{
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int ClassId { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public decimal FinalFee { get; set; }
    public string EnrollmentDate { get; set; } = string.Empty;
    public string Status { get; set; } = "Enrolled";

    public string FormattedEnrollmentDate
    {
        get
        {
            if (DateTime.TryParse(EnrollmentDate, out var dt))
            {
                return dt.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
            }
            return EnrollmentDate;
        }
    }

    public string StatusText => Status switch
    {
        "Enrolled" => "Đã xếp lớp",
        "Active" => "Đang theo học",
        "Completed" => "Đã hoàn thành",
        "Dropped" => "Bảo lưu / Thôi học",
        _ => Status
    };
}
