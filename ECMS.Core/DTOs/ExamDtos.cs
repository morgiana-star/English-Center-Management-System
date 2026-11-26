using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class ExamListItemDto
{
    public int ExamId { get; set; }
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ExamName { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string TypeDisplay => Type switch
    {
        "Regular" => "Thường xuyên (TX)",
        "Midterm" => "Giữa khóa (GK)",
        "Final" => "Cuối khóa (CK)",
        _ => Type
    };
    public string ExamDate { get; set; } = string.Empty;
    public string ExamDateDisplay => DateTime.TryParse(ExamDate, out var dt) ? dt.ToString("dd/MM/yyyy") : ExamDate;
    public string StartTime { get; set; } = "18:00";
    public string EndTime { get; set; } = "19:30";
    public string TimeRange => $"{StartTime} - {EndTime}";
    public int? RoomId { get; set; }
    public string RoomName { get; set; } = "Chưa xếp phòng";
    public double WeightPercentage { get; set; }
    public int TotalStudents { get; set; }
    public int GradedCount { get; set; }
    public string GradedRatio => $"{GradedCount} / {TotalStudents}";
    public string DateDisplay => ExamDateDisplay;
    public string WeightDisplay => $"{WeightPercentage:0.#}%";
    public string GradedRatioDisplay => GradedRatio;
    public string StatusDisplay => TotalStudents > 0 && GradedCount >= TotalStudents ? "✓ Đã hoàn tất" : (GradedCount > 0 ? "⏳ Đang nhập điểm" : "⏳ Chưa nhập điểm");
}

public class ClassExamLookupDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public int StudentCount { get; set; }
    public decimal PassingScore { get; set; } = 5.0m;
    public string DisplayText => $"{ClassCode} — {CourseName} ({StudentCount} HV)";
}

public class CreateExamDto
{
    public int ClassId { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public string Type { get; set; } = "Regular";
    public string ExamDate { get; set; } = string.Empty;
    public decimal WeightPercentage { get; set; } = 20m;
}

public class ClassGradeRowDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public decimal? ListeningScore { get; set; }
    public decimal? ReadingScore { get; set; }
    public decimal? WritingScore { get; set; }
    public decimal? SpeakingScore { get; set; }
    public decimal? OverallScore { get; set; }
    public string ResultText { get; set; } = string.Empty;
    public string? Comment { get; set; }
}

public class CreateExamRequestDto
{
    public string ExamName { get; set; } = string.Empty;
    public string Type { get; set; } = "Regular";
    public DateTime ExamDate { get; set; }
    public string StartTime { get; set; } = "18:00";
    public string EndTime { get; set; } = "19:30";
    public int? RoomId { get; set; }
    public double WeightPercentage { get; set; } = 20;
    public List<int> ClassIds { get; set; } = new();
}

public class StudentGradeEntryDto
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public double? RegularScore { get; set; }
    public double? MidtermScore { get; set; }
    public double? FinalScore { get; set; }
}
