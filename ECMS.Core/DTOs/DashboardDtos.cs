using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class DashboardKpiSummaryDto
{
    public int TotalStudents { get; set; } = 428;
    public int ActiveStudents { get; set; } = 348;
    public int ActiveClasses { get; set; } = 18;
    public int ActiveTeachers { get; set; } = 24;
    public decimal CurrentMonthRevenue { get; set; } = 186500000m;
    public string CurrentMonthRevenueFormatted { get; set; } = "186,5 tr";
    public decimal TotalOutstandingDebt { get; set; } = 42900000m;
    public string TotalOutstandingDebtFormatted { get; set; } = "42,9 tr";
}

public class MonthlyRevenueBarDto
{
    public string MonthLabel { get; set; } = string.Empty;
    public string YearMonth { get; set; } = string.Empty;
    public double RevenueMillion { get; set; }
    public string DisplayLabel { get; set; } = string.Empty;
    public bool IsHighlight { get; set; }
    public decimal TargetAmount { get; set; }
    public string GrowthRateMoM { get; set; } = string.Empty;
    public int NewStudentsCount { get; set; }
}

public class MonthlyStudentGrowthBarDto
{
    public string MonthLabel { get; set; } = string.Empty;
    public string YearMonth { get; set; } = string.Empty;
    public double StudentCount { get; set; }
    public string DisplayLabel { get; set; } = string.Empty;
    public bool IsHighlight { get; set; }
    public int TotalStudents { get; set; }
    public int GraduatedCount { get; set; }
    public string RetentionRate { get; set; } = "85%";
}

public class CourseAttendanceRatioDto
{
    public string CategoryName { get; set; } = string.Empty;
    public int ClassCount { get; set; }
    public int StudentCount { get; set; }
    public double AttendanceRate { get; set; }
    public string AttendanceRateFormatted => $"{AttendanceRate:0.0}%";
}

public class TodayScheduleItemDto
{
    public string TimeDisplay { get; set; } = string.Empty;
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public int CurrentEnrollment { get; set; }
    public int MaxCapacity { get; set; } = 20;
    public string CapacityFormatted => $"{CurrentEnrollment}/{MaxCapacity}";
    public string StatusText { get; set; } = "Đang học";
}

public class PendingTaskItemDto
{
    public int Index { get; set; }
    public string Title { get; set; } = string.Empty;
    public string RelatedTarget { get; set; } = string.Empty;
    public string Severity { get; set; } = "Cần làm"; // Khẩn cấp, Cảnh báo, Cần làm, Bình thường
    public string DueDate { get; set; } = string.Empty;
    public string SuggestedAction { get; set; } = string.Empty;
}

public class DashboardQuickSearchResultDto
{
    public string EntityType { get; set; } = "Student"; // Student, Class, Course
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Extra1 { get; set; } = string.Empty;
    public string Extra2 { get; set; } = string.Empty;
    public string Extra3 { get; set; } = string.Empty;
}
