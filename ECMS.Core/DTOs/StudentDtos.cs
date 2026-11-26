using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

/// <summary>
/// DTO hiển thị danh sách học viên trên bảng DataGridView ở màn hình chính (StudentManagementView)
/// </summary>
public class StudentListItemDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty; // HV-0241
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int? ClassId { get; set; }
    public string ClassName { get; set; } = "Chờ xếp lớp"; // IELTS-F01
    public double? AttendanceRate { get; set; }
    public string AttendanceRateDisplay => AttendanceRate.HasValue ? $"{AttendanceRate.Value:F1}%" : "Chưa có";
    public decimal DebtAmount { get; set; } = 0;
    public string DebtDisplay => DebtAmount > 0 ? $"{DebtAmount:N0}đ" : "0đ";
    public string Status { get; set; } = "Đang học"; // Đang học, Hoàn thành, Đã lưu trữ
}

/// <summary>
/// DTO cho từng dòng lịch sử khóa học trong Tab 2 "Quá trình học tập" của StudentDetailDialog
/// </summary>
public class StudentLearningHistoryItemDto
{
    public string ClassCourseName { get; set; } = string.Empty; // IELTS-F01 · IELTS Foundation
    public string Status { get; set; } = "Đang học";            // Đang học, Hoàn thành
    public string AttendanceProgress { get; set; } = "-";       // 8 / 24
    public string RegularScore { get; set; } = "-";             // 7.0
    public string MidtermScore { get; set; } = "-";             // 8.0
    public string FinalScore { get; set; } = "-";               // 8.5
    public string TuitionStatus { get; set; } = "Đã hoàn thành"; // Còn nợ 1.900.000đ hoặc Đã hoàn thành
}

/// <summary>
/// DTO hồ sơ chi tiết 360° của học viên (StudentDetailDialog - Tab 1 & Tab 2)
/// </summary>
public class StudentDetailDto
{
    // 1. Header & Thông tin chung
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty; // HV-0241
    public string FullName { get; set; } = string.Empty;
    public string StatusText { get; set; } = "Đang học";
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-18);
    public string Gender { get; set; } = "Nam";
    public string ParentFullName { get; set; } = string.Empty;
    public string ParentPhone { get; set; } = string.Empty;
    public string ParentEmail { get; set; } = string.Empty;
    public string ParentRelationship { get; set; } = "Phụ huynh";

    // 2. Tab 1: 4 Thẻ chỉ số tổng quan
    public string CurrentClassName { get; set; } = "Chưa xếp lớp"; // IELTS-F01
    public string LessonsProgressDisplay { get; set; } = "0 / 0";  // 8 / 24
    public string AttendanceRateDisplay { get; set; } = "100%";    // 87,5%
    public decimal RemainingTuition { get; set; } = 0;
    public string RemainingTuitionDisplay => $"{RemainingTuition:N0}đ"; // 1.900.000đ
    public string TuitionDueDateDisplay { get; set; } = string.Empty;  // Hạn thanh toán: 15/11/2026

    // 3. Tab 1: Box "Tóm tắt học tập hiện tại"
    // Cột Thông tin lớp
    public string CourseName { get; set; } = string.Empty;     // IELTS Foundation
    public string TeacherName { get; set; } = string.Empty;    // Nguyễn Hoàng Anh
    public string ScheduleDisplay { get; set; } = string.Empty;// T3 / T6 · 18:00–20:00
    public string RoomName { get; set; } = string.Empty;       // P201

    // Cột Chuyên cần
    public string ProgressDisplay { get; set; } = "0 / 0 buổi"; // 8 / 24 buổi
    public int PresentCount { get; set; } = 0;                  // Có mặt: 6
    public int LateCount { get; set; } = 0;                     // Đi muộn: 1
    public int AbsentCount { get; set; } = 0;                   // Vắng: 1 (có phép)

    // Cột Điểm số
    public string EntranceScore { get; set; } = "—";           // Đầu vào: 4.0 / 10
    public string RegularScore { get; set; } = "—";            // Thường xuyên: 7.0 / 10
    public string MidtermScore { get; set; } = "Chưa kiểm tra";// Giữa khóa
    public string FinalScore { get; set; } = "Chưa kiểm tra";  // Cuối khóa

    // 4. Tab 2: Lịch sử đăng ký & Tiến trình học tập
    public List<StudentLearningHistoryItemDto> LearningHistory { get; set; } = new();
}

/// <summary>
/// DTO cập nhật hồ sơ học viên (Nút "✎ Sửa hồ sơ")
/// </summary>
public class UpdateStudentProfileDto
{
    public int StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; } = "Nam";
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }

    public string ParentFullName { get; set; } = string.Empty;
    public string ParentPhone { get; set; } = string.Empty;
    public string ParentRelationship { get; set; } = "Bố";
}

/// <summary>
/// DTO lưu trữ hồ sơ học viên (Nút "Lưu trữ")
/// </summary>
public class ArchiveStudentDto
{
    public int StudentId { get; set; }
    public string Reason { get; set; } = string.Empty; // Bảo lưu, Bận công việc, Chuyển nơi ở, v.v.
    public string? Notes { get; set; }
}

/// <summary>
/// DTO thống kê nhanh ở header màn hình Học viên
/// </summary>
public class StudentOverviewStatsDto
{
    public int TotalStudents { get; set; } = 0;
    public int StudyingStudents { get; set; } = 0;
    public int WaitingClassStudents { get; set; } = 0;
    public int CompletedStudents { get; set; } = 0;
    public int ArchivedStudents { get; set; } = 0;
    public int DebtStudents { get; set; } = 0;
}

public class ClassFilterItemDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string DisplayText => ClassId <= 0 ? ClassName : $"{ClassCode} - {ClassName}";
}

public class CourseLookupDto
{
    public int CourseId { get; set; }
    public string CourseCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public int TotalSessions { get; set; }
    public decimal BaseTuitionFee { get; set; }
    public string DisplayText => $"{CourseName} ({Level} · {TotalSessions} buổi)";
}

public class OpenClassOptionDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public decimal TuitionFee { get; set; }
    public string StartDateDisplay { get; set; } = string.Empty;
    public string EndDateDisplay { get; set; } = string.Empty;
    public string ScheduleDisplay { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public int CurrentStudents { get; set; }
    public int MaxStudents { get; set; }
    public string CapacityDisplay => $"{CurrentStudents}/{MaxStudents}";
}

/// <summary>
/// DTO tổng hợp toàn bộ thông tin Đăng ký học & Thu phí đợt 1 để ghi Transaction CSDL
/// </summary>
public class StudentEnrollmentWithTuitionDto
{
    // Thông tin học viên
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-18);
    public string Gender { get; set; } = "Nam";
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? Notes { get; set; }

    // Người liên hệ / Phụ huynh
    public string? ParentFullName { get; set; }
    public string? ParentPhone { get; set; }
    public string ParentRelationship { get; set; } = "Phụ huynh";

    // Khóa học & Lớp học
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public decimal TotalTuitionFee { get; set; }
    public int? DiscountId { get; set; }
    public string? DiscountCode { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalTuitionFee => Math.Max(0, TotalTuitionFee - DiscountAmount);
    public bool PayNow { get; set; } = true;

    // Thu phí & Kế hoạch đóng
    public string InstallmentPlan { get; set; } = "100%"; // 100%, 50%, 40%
    public decimal AmountPaidNow { get; set; }
    public decimal RemainingDebt { get; set; }
    public string PaymentMethod { get; set; } = "Chuyển khoản";
    public string ReceiptCode { get; set; } = string.Empty;
    public string? TransactionReference { get; set; }
    public string? PaymentNote { get; set; }
    public int? CashierId { get; set; }
}

/// <summary>
/// DTO đại diện cho 1 dòng dữ liệu đọc từ tệp Excel/CSV nhập học viên hàng loạt
/// </summary>
public class StudentImportRowDto
{
    public int RowIndex { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    public string DateOfBirthDisplay => DateOfBirth.HasValue ? DateOfBirth.Value.ToString("dd/MM/yyyy") : "-";
    public string Gender { get; set; } = "Nam";
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? ParentName { get; set; }
    public string? ParentPhone { get; set; }
    public string? ParentRelationship { get; set; } = "Bố";
    public bool IsValid { get; set; } = true;
    public string ValidationMessage { get; set; } = "Hợp lệ";
}

/// <summary>
/// DTO kết quả thực thi nhập học viên hàng loạt
/// </summary>
public class StudentImportResultDto
{
    public int TotalRows { get; set; }
    public int SuccessCount { get; set; }
    public int ErrorCount { get; set; }
    public List<string> InsertedStudentCodes { get; set; } = new();
    public List<string> ErrorMessages { get; set; } = new();
}
