using System;
using System.Collections.Generic;

namespace ECMS.Core.DTOs;

public class ExamListItemDto
{
    public int ExamId { get; set; }
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ExamName { get; set; } = string.Empty;
    public string Type { get; set; } = "Midterm";
    public string ExamDate { get; set; } = string.Empty;
    public decimal WeightPercentage { get; set; } = 30.0m;
    public int TotalStudents { get; set; }
    public int GradedStudents { get; set; }

    public string DateDisplay
    {
        get
        {
            if (DateTime.TryParse(ExamDate?.Split('T')[0], out var dt))
                return dt.ToString("dd/MM/yyyy");
            return ExamDate ?? "";
        }
    }

    public string WeightDisplay => $"{WeightPercentage:0}%";

    public string GradedRatioDisplay => $"{GradedStudents}/{TotalStudents}";

    public string StatusDisplay => (GradedStudents >= TotalStudents && TotalStudents > 0)
        ? "✓ Đã có điểm"
        : (GradedStudents > 0 ? "⏳ Đang chấm" : "⏳ Chờ nhập điểm");

    public string TypeDisplay => Type switch
    {
        "Quiz" => "Kiểm tra kỹ năng (Quiz)",
        "Midterm" => "IELTS Mock Test Giữa khóa",
        "Final" => "IELTS Mock Test Cuối khóa",
        "PlacementTest" => "Test 4 kỹ năng đầu vào",
        _ => Type
    };
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

public class CreateExamDto
{
    public int ClassId { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public string Type { get; set; } = "Midterm";
    public string ExamDate { get; set; } = string.Empty;
    public decimal WeightPercentage { get; set; } = 30.0m;
}

public class ClassExamLookupDto
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public decimal PassingScore { get; set; } = 5.0m;
    public int StudentCount { get; set; }
    public string DisplayText => $"{ClassCode} · {CourseName} (GV: {TeacherName})";
}
