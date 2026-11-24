namespace ECMS.Core.DTOs;

public class TeacherListItemDto
{
    public int TeacherId { get; set; }
    public string TeacherCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Certificate { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string PreferredShifts { get; set; } = string.Empty;
    public string AvailableDays { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public int ActiveClassCount { get; set; }
    public string StatusDisplay => IsActive ? "Đang giảng dạy" : "Tạm nghỉ";
}

public class SaveTeacherDto
{
    public int TeacherId { get; set; }
    public string TeacherCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Certificate { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string PreferredShifts { get; set; } = string.Empty;
    public string AvailableDays { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
