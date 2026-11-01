using System;
using ECMS.Core.Enums;

namespace ECMS.Core.Entities;

public class Employee : BaseEntity
{
    public int EmployeeId { get; set; }
    public string EmployeeCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public bool IsActive { get; set; } = true;
}

public class Teacher : BaseEntity
{
    public int TeacherId { get; set; }
    public string TeacherCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public decimal HourlyRate { get; set; } = 0;
    public bool IsNativeSpeaker { get; set; } = false;
    public bool IsActive { get; set; } = true;
}

public class Lead : BaseEntity
{
    public int LeadId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Source { get; set; } = "Trực tiếp";
    public LeadStatus Status { get; set; } = LeadStatus.New;
    public int? AssignedEmployeeId { get; set; }
    public string? Notes { get; set; }
}

public class ConsultationLog : BaseEntity
{
    public int LogId { get; set; }
    public int LeadId { get; set; }
    public int CounselorId { get; set; }
    public DateTime ConsultationDate { get; set; } = DateTime.Now;
    public decimal? EntranceTestScore { get; set; }
    public string? ProposedLevel { get; set; }
    public string? Content { get; set; }
}

public class Student : BaseEntity
{
    public int StudentId { get; set; }
    public string StudentCode { get; set; } = string.Empty; // HV-yyyy-xxxx
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; } = "Nam";
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? AvatarPath { get; set; }
    public StudentStatus Status { get; set; } = StudentStatus.Active;
    public int? LeadId { get; set; }
}

public class Parent : BaseEntity
{
    public int ParentId { get; set; }
    public string ParentCode { get; set; } = string.Empty; // PH-yyyy-xxxx
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Occupation { get; set; }
}

public class StudentParent
{
    public int StudentId { get; set; }
    public int ParentId { get; set; }
    public string RelationshipType { get; set; } = "Bố"; // Bố, Mẹ, Giám hộ
    public bool IsPrimaryContact { get; set; } = false;
}
