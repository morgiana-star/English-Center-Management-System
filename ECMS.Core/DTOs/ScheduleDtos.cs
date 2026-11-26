using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class WeeklyScheduleSlotDto
{
    public int ScheduleId { get; set; }
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string EndTime { get; set; } = string.Empty;
    public int SessionNumber { get; set; }
}

public class ScheduleSummaryItemDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public string SchedulePattern { get; set; } = string.Empty;
    public string StartDateDisplay { get; set; } = string.Empty;
    public string EndDateDisplay { get; set; } = string.Empty;
    public int SessionCount { get; set; }
    public int AttendanceCount { get; set; }
}

public class ClassForScheduleCreateDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public int TeacherId { get; set; }
    public string TeacherName { get; set; } = string.Empty;
    public int RoomId { get; set; }
    public string RoomName { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public int TotalSessions { get; set; }
    public int ExistingSessions { get; set; }
    public string ScheduleDisplay { get; set; } = string.Empty;
    public string StatusDisplay { get; set; } = string.Empty;
}

public class GenerateClassScheduleRequestDto
{
    public int ClassId { get; set; }
    public DateTime StartDate { get; set; }
    public List<DayOfWeek> DaysOfWeek { get; set; } = new();
    public string StartTime { get; set; } = "18:00";
    public string EndTime { get; set; } = "20:00";
    public int RoomId { get; set; }
    public int TeacherId { get; set; }
    public int TotalSessions { get; set; } = 24;
}
