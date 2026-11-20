using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class DashboardKpiSummaryDto
{
    public int TotalStudents { get; set; }
    public int ActiveStudents { get; set; }
    public int ActiveClasses { get; set; }
    public int ActiveTeachers { get; set; }
    public decimal CurrentMonthRevenue { get; set; }
    public string CurrentMonthRevenueFormatted { get; set; } = "0 đ";
    public decimal TotalOutstandingDebt { get; set; }
    public string TotalOutstandingDebtFormatted { get; set; } = "0 đ";
    public double AverageAttendanceRate { get; set; }
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
    public int NewStudents { get; set; }
    public int GraduatedCount { get; set; }
    public string RetentionRate { get; set; } = "100%";
}

public class CourseAttendanceRatioDto
{
    public string CategoryName { get; set; } = string.Empty;
    public int ClassCount { get; set; }
    public int StudentCount { get; set; }
    public double AttendanceRate { get; set; }
    public string AttendanceRateFormatted => $"{AttendanceRate:0.0}%";
}

public class ClassAttendanceDetailDto
{
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public string CapacityFormatted { get; set; } = string.Empty;
    public string LessonsProgress { get; set; } = string.Empty;
    public double AttendanceRate { get; set; }
    public string AttendanceRateFormatted => $"{AttendanceRate:0.0}%";
    public string StatusText { get; set; } = string.Empty;
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
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public int AbsentCount { get; set; }
    public int MaxAllowedAbsences { get; set; }
    public string HandlingStatus { get; set; } = "Chưa xử lý"; // Chưa xử lý / Đã xử lý
    public string SuggestedAction => $"Cảnh báo: Vắng {AbsentCount}/{MaxAllowedAbsences} buổi quy định";
}

public class DashboardQuickSearchResultDto
{
    public string EntityType { get; set; } = "Học viên"; // Học viên, Lớp học, Khóa học
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Extra1 { get; set; } = string.Empty;
    public string Extra2 { get; set; } = string.Empty;
    public string Extra3 { get; set; } = string.Empty;
    public string StatusText { get; set; } = string.Empty;
}
