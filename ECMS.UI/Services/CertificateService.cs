using System;
using System.Collections.Generic;

namespace ECMS.UI.Services;

public class IssuedCertificateModel
{
    public string SerialNumber { get; set; } = string.Empty;
    public string StudentCode { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public string IssueDate { get; set; } = string.Empty;
    public string Approver { get; set; } = string.Empty;
    public string Status { get; set; } = "Đã cấp · Chưa in";
    public string Score { get; set; } = "8.0 / 10";
    public string GradeRank { get; set; } = "Giỏi";
    public string Attendance { get; set; } = "95%";
}

public static class CertificateService
{
    private static int _serialCounter = 42;
    private static readonly List<IssuedCertificateModel> _issuedList = new()
    {
        new IssuedCertificateModel
        {
            SerialNumber = "CC-2026-0042",
            StudentCode = "HV-0204",
            StudentName = "Trần Gia Bảo",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            IssueDate = "30/10/2026",
            Approver = "Trần Minh Quân (Admin)",
            Status = "Đã cấp · Chưa in",
            Score = "7.7 / 10",
            GradeRank = "Khá",
            Attendance = "22/24 · 91.7%"
        },
        new IssuedCertificateModel
        {
            SerialNumber = "CC-2026-0041",
            StudentCode = "HV-0188",
            StudentName = "Ngô Bảo Ngọc",
            CourseName = "TOEIC 500+",
            ClassName = "TOEIC-A01",
            IssueDate = "22/10/2026",
            Approver = "Trần Minh Quân (Admin)",
            Status = "Đã cấp · Đã in",
            Score = "8.4 / 10",
            GradeRank = "Giỏi",
            Attendance = "24/24 · 100%"
        },
        new IssuedCertificateModel
        {
            SerialNumber = "CC-2026-0040",
            StudentCode = "HV-0155",
            StudentName = "Trần Hải Yến",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            IssueDate = "19/10/2026",
            Approver = "Trần Minh Quân (Admin)",
            Status = "Đã cấp · Đã in",
            Score = "8.8 / 10",
            GradeRank = "Xuất sắc",
            Attendance = "23/24 · 95.8%"
        },
        new IssuedCertificateModel
        {
            SerialNumber = "CC-2026-0039",
            StudentCode = "HV-0142",
            StudentName = "Nguyễn Đức Duy",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            IssueDate = "19/10/2026",
            Approver = "Trần Minh Quân (Admin)",
            Status = "Đã cấp · Đã in",
            Score = "7.5 / 10",
            GradeRank = "Khá",
            Attendance = "21/24 · 87.5%"
        }
    };

    public static List<IssuedCertificateModel> GetIssuedCertificates()
    {
        return new List<IssuedCertificateModel>(_issuedList);
    }

    public static void AddIssuedCertificate(IssuedCertificateModel cert)
    {
        _issuedList.Insert(0, cert);
    }

    public static string GenerateNextSerial()
    {
        _serialCounter++;
        return $"CC-2026-{_serialCounter:D4}";
    }
}
