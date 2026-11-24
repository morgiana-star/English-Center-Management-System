using System;

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

public class ClassStudentItemDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string StatusDisplay { get; set; } = string.Empty;
    public string AttendanceDisplay { get; set; } = "Chưa có";
    public string TuitionDisplay { get; set; } = "Đã hoàn thành";
}

public class ClassScheduleItemDto
{
    public int ScheduleId { get; set; }
    public int SessionNumber { get; set; }
    public string DateDisplay { get; set; } = string.Empty;
    public string TimeRange { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
}

public class ClassAttendanceSummaryDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public int PresentCount { get; set; }
    public int LateCount { get; set; }
    public int AbsentCount { get; set; }
    public int TotalRecorded { get; set; }
    public string RateDisplay => TotalRecorded > 0 ? $"{Math.Round((PresentCount + LateCount) * 100.0 / TotalRecorded, 1):F1}%" : "Chưa có";
}

public class ClassGradeItemDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string RegularScore { get; set; } = "-";
    public string MidtermScore { get; set; } = "-";
    public string FinalScore { get; set; } = "-";
    public string AverageScore { get; set; } = "-";
}

public class WaitingStudentItemDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string StatusDisplay { get; set; } = "Chờ xếp lớp";
}
