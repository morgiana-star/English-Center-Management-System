using System;
using ECMS.Core.Enums;

namespace ECMS.Core.Entities;

public class Course : BaseEntity
{
    public int CourseId { get; set; }
    public string CourseCode { get; set; } = string.Empty; // KH-xxxx
    public string CourseName { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public int TotalHours { get; set; } = 45;
    public int TotalSessions { get; set; } = 30;
    public decimal BaseTuitionFee { get; set; } = 0;
    public decimal PassingScore { get; set; } = 5.0m;
    public bool IsActive { get; set; } = true;
}

public class ClassRoom : BaseEntity
{
    public int RoomId { get; set; }
    public string RoomName { get; set; } = string.Empty;
    public int Floor { get; set; } = 1;
    public int Capacity { get; set; } = 20;
    public bool HasProjector { get; set; } = true;
    public bool IsActive { get; set; } = true;
}

public class Class : BaseEntity
{
    public int ClassId { get; set; }
    public string ClassCode { get; set; } = string.Empty; // LH-yyyy-xxxx
    public string ClassName { get; set; } = string.Empty;
    public int CourseId { get; set; }
    public int? MainTeacherId { get; set; }
    public int? DefaultRoomId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int MaxStudents { get; set; } = 15;
    public ClassStatus Status { get; set; } = ClassStatus.Planning;
}

public class ClassSchedule : BaseEntity
{
    public int ScheduleId { get; set; }
    public int ClassId { get; set; }
    public int SessionNumber { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int RoomId { get; set; }
    public int TeacherId { get; set; }
    public bool IsAttendanceLocked { get; set; } = false;
    public string? Topic { get; set; }
}

public class Enrollment : BaseEntity
{
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public int ClassId { get; set; }
    public DateTime EnrollDate { get; set; } = DateTime.Now;
    public StudentStatus Status { get; set; } = StudentStatus.Active;
    public decimal? FinalGPA { get; set; }
    public decimal? AttendanceRate { get; set; }
}

public class AttendanceRecord : BaseEntity
{
    public int AttendanceId { get; set; }
    public int ScheduleId { get; set; }
    public int StudentId { get; set; }
    public AttendanceStatus Status { get; set; } = AttendanceStatus.Present;
    public string? Note { get; set; }
    public DateTime RecordedAt { get; set; } = DateTime.Now;
}

public class Exam : BaseEntity
{
    public int ExamId { get; set; }
    public int ClassId { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public ExamType Type { get; set; } = ExamType.Midterm;
    public DateTime ExamDate { get; set; }
    public decimal WeightPercentage { get; set; } = 30.0m;
}

public class ExamScore : BaseEntity
{
    public int ScoreId { get; set; }
    public int ExamId { get; set; }
    public int StudentId { get; set; }
    public decimal ScoreValue { get; set; }
    public string? TeacherComments { get; set; }
}

public class Certificate : BaseEntity
{
    public int CertificateId { get; set; }
    public string CertificateNo { get; set; } = string.Empty; // CC-yyyy-xxxx
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public DateTime IssueDate { get; set; } = DateTime.Now;
    public string GraduationGrade { get; set; } = "Khá";
}

public class StudyMaterial : BaseEntity
{
    public int MaterialId { get; set; }
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? FilePath { get; set; }
    public string? Description { get; set; }
}
