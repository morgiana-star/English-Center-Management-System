namespace ECMS.Core.DTOs;

public class ClassListItemDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string ScheduleInfo { get; set; } = string.Empty;
    public int CurrentStudents { get; set; }
    public int MaxStudents { get; set; }
    public string Status { get; set; } = string.Empty;
}
