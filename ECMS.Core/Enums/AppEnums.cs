namespace ECMS.Core.Enums;

public enum UserRoleType
{
    Admin,
    CenterManager,
    EducationalConsultant,
    Accountant,
    AcademicAffairs,
    Teacher,
    Student,
    Parent
}

public enum StudentStatus
{
    Active,
    Reserved,
    Completed,
    Dropped
}

public enum AttendanceStatus
{
    Present,
    Absent,
    Excused,
    Late
}

public enum ClassStatus
{
    Planning,
    OpenForEnrollment,
    InProgress,
    Completed,
    Cancelled
}

public enum InvoiceStatus
{
    Unpaid,
    PartiallyPaid,
    Paid,
    Cancelled
}

public enum PaymentStatus
{
    Valid,
    Cancelled
}

public enum LeadStatus
{
    New,
    Contacted,
    TestScheduled,
    Converted,
    Lost
}

public enum ExamType
{
    Midterm,
    Final,
    Quiz,
    PlacementTest
}

public enum PaymentMethod
{
    Cash,
    BankTransfer,
    POS
}
