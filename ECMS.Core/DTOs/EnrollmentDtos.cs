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

public class FeeDiscountDto
{
    public int DiscountId { get; set; }
    public string DiscountName { get; set; } = string.Empty;
    public double Percentage { get; set; }
    public decimal FixedAmount { get; set; }
    public string? Description { get; set; }
    public bool RequiresApproval { get; set; }

    public string DisplayText
    {
        get
        {
            if (DiscountId == 0) return "Không áp dụng ưu đãi (0%)";
            if (Percentage > 0 && FixedAmount > 0)
                return $"{DiscountName} (Giảm {Percentage}% + {FixedAmount:N0}đ)";
            if (Percentage > 0)
                return $"{DiscountName} (Giảm {Percentage}%)";
            if (FixedAmount > 0)
                return $"{DiscountName} (Giảm {FixedAmount:N0} VNĐ)";
            return DiscountName;
        }
    }

    public decimal CalculateDiscount(decimal originalAmount)
    {
        if (originalAmount <= 0 || DiscountId <= 0) return 0;

        decimal percentDiscount = originalAmount * (decimal)Percentage / 100m;
        decimal totalDiscount = percentDiscount + FixedAmount;
        return Math.Min(originalAmount, Math.Round(totalDiscount, 0));
    }
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

    // Thông tin Ưu đãi & Hóa đơn (Ngày 8)
    public int? DiscountId { get; set; }
    public decimal OriginalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalAmount { get; set; }
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
    public string EnrollDate { get; set; } = string.Empty;
    public string Status { get; set; } = "PendingPayment";

    public string InvoiceCode { get; set; } = string.Empty;
    public decimal OriginalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalAmount { get; set; }
    public string InvoiceStatus { get; set; } = "Unpaid";

    public string FormattedEnrollDate
    {
        get
        {
            if (DateTime.TryParse(EnrollDate, out var dt))
            {
                return dt.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
            }
            return EnrollDate;
        }
    }

    public string StatusText => Status switch
    {
        "PendingPayment" => "Chờ nộp học phí",
        "Active" => "Đang theo học",
        "Completed" => "Đã hoàn thành",
        "Dropped" => "Bảo lưu / Thôi học",
        "Transferred" => "Đã chuyển lớp",
        "Reserved" => "Đang bảo lưu",
        _ => Status
    };
}
