using System;

namespace ECMS.Core.Helpers;

/// <summary>
/// Chuẩn hóa hiển thị trạng thái và ca học đồng nhất trên toàn bộ hệ thống ECMS
/// </summary>
public static class StatusFormatter
{
    public static readonly string[] StandardShifts =
    {
        "Ca Sáng (08:00 - 12:00)",
        "Ca Chiều (13:30 - 17:30)",
        "Ca Tối (18:00 - 21:00)"
    };

    public static readonly string[] TeacherSpecialties =
    {
        "IELTS 8.0+",
        "IELTS 7.0 - 7.5",
        "TOEIC 900+",
        "Tiếng Anh Giao tiếp",
        "Ngữ pháp & Từ vựng"
    };

    public static readonly string[] CourseLevels =
    {
        "Cơ bản",
        "Sơ trung cấp",
        "Trung cấp",
        "Trung cao cấp",
        "Nâng cao"
    };

    public static readonly string[] ClassStatusOptions =
    {
        "Sắp mở",
        "Đang học",
        "Đã kết thúc",
        "Đã hủy"
    };

    public static string FormatCourseLevel(string? rawLevel)
    {
        string val = (rawLevel ?? string.Empty).Trim();
        return val.ToLowerInvariant() switch
        {
            "beginner" or "cơ bản" or "cơ bản (0-4.5)" or "mất gốc" => "Cơ bản",
            "pre-intermediate" or "sơ trung cấp" => "Sơ trung cấp",
            "intermediate" or "trung cấp" or "trung cấp (5.0-6.5)" => "Trung cấp",
            "upper-intermediate" or "trung cao cấp" => "Trung cao cấp",
            "advanced" or "nâng cao" or "nâng cao (7.0+)" => "Nâng cao",
            _ => string.IsNullOrWhiteSpace(val) ? "Cơ bản" : val
        };
    }

    public static string FormatClassStatus(string? rawStatus)
    {
        return (rawStatus ?? string.Empty).Trim() switch
        {
            "Planning" or "OpenForEnrollment" or "Sắp mở" or "Sắp khai giảng" or "Mở tuyển sinh" or "Đang tuyển sinh" => "Sắp mở",
            "InProgress" or "Đang học" or "Đang diễn ra" => "Đang học",
            "Completed" or "Đã kết thúc" or "Hoàn thành" => "Đã kết thúc",
            "Cancelled" or "Đã hủy" => "Đã hủy",
            _ => string.IsNullOrWhiteSpace(rawStatus) ? "Sắp mở" : rawStatus.Trim()
        };
    }

    public static string ToDbClassStatus(string? displayStatus)
    {
        return (displayStatus ?? string.Empty).Trim() switch
        {
            "Sắp mở" or "Sắp khai giảng" or "Planning" or "Đang tuyển sinh" or "Mở tuyển sinh" or "OpenForEnrollment" => "OpenForEnrollment",
            "Đang học" or "Đang diễn ra" or "InProgress" => "InProgress",
            "Đã kết thúc" or "Hoàn thành" or "Completed" => "Completed",
            "Đã hủy" or "Cancelled" => "Cancelled",
            _ => "OpenForEnrollment"
        };
    }

    public static string FormatStudentStatus(string? rawStatus, bool hasClass = true)
    {
        return (rawStatus ?? string.Empty).Trim() switch
        {
            "Active" => hasClass ? "Đang học" : "Chờ xếp lớp",
            "Reserved" or "Bảo lưu" => "Đã lưu trữ",
            "Dropped" or "Nghỉ học" or "Đã lưu trữ" => "Đã lưu trữ",
            "Completed" or "Hoàn thành" => "Hoàn thành",
            _ => hasClass ? "Đang học" : "Chờ xếp lớp"
        };
    }

    public static string FormatInvoiceStatus(string? rawStatus, decimal balanceDue)
    {
        if (string.Equals(rawStatus, "Cancelled", StringComparison.OrdinalIgnoreCase))
            return "Đã hủy";
        if (balanceDue <= 0 || string.Equals(rawStatus, "Paid", StringComparison.OrdinalIgnoreCase))
            return "Đã hoàn thành";
        if (string.Equals(rawStatus, "PartiallyPaid", StringComparison.OrdinalIgnoreCase))
            return "Đang đóng nợ";
        return "Chưa thanh toán";
    }
}

/// <summary>
/// Chuẩn hóa sinh mã tự động đồng nhất (Học viên 4 số: HV-0001..HV-9999; các mã khác 3 số: 001..999)
/// </summary>
public static class CodeFormatHelper
{
    public static string FormatStudentCode(int seq) => $"HV-{Math.Max(1, seq):D4}";
    public static string FormatClassCode(int seq) => $"LH-{Math.Max(1, seq):D3}";
    public static string FormatCourseCode(int seq) => $"KH-{Math.Max(1, seq):D3}";
    public static string FormatTeacherCode(int seq) => $"GV-{Math.Max(1, seq):D3}";
    public static string FormatEmployeeCode(int seq) => $"NV-{Math.Max(1, seq):D3}";
    public static string FormatParentCode(int seq) => $"PH-{Math.Max(1, seq):D4}";
}
