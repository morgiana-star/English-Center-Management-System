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

    public static string FormatClassStatus(string? rawStatus)
    {
        return (rawStatus ?? string.Empty).Trim() switch
        {
            "Planning" or "Sắp mở" or "Sắp khai giảng" => "Sắp mở",
            "OpenForEnrollment" or "Mở tuyển sinh" or "Đang tuyển sinh" => "Đang tuyển sinh",
            "InProgress" or "Đang học" or "Đang diễn ra" => "Đang học",
            "Completed" or "Đã kết thúc" or "Hoàn thành" => "Đã kết thúc",
            "Cancelled" or "Đã hủy" => "Đã hủy",
            _ => string.IsNullOrWhiteSpace(rawStatus) ? "Đang tuyển sinh" : rawStatus.Trim()
        };
    }

    public static string ToDbClassStatus(string? displayStatus)
    {
        return (displayStatus ?? string.Empty).Trim() switch
        {
            "Sắp mở" or "Sắp khai giảng" or "Planning" => "Planning",
            "Đang tuyển sinh" or "Mở tuyển sinh" or "OpenForEnrollment" => "OpenForEnrollment",
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
