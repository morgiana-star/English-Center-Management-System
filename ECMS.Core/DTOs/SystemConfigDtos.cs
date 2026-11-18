using System;

namespace ECMS.Core.DTOs;

public class CenterConfigDto
{
    public string CenterName { get; set; } = "Trung tâm Anh ngữ ECMS";
    public string CenterPhone { get; set; } = "028 3822 6688";
    public string CenterEmail { get; set; } = "contact@ecms.edu.vn";
    public string CenterWebsite { get; set; } = "https://ecms.edu.vn";
    public string CenterAddress { get; set; } = "25 Nguyễn Văn Cừ, Phường 4, Quận 5, TP. Hồ Chí Minh";
    public string DirectorName { get; set; } = "Trần Minh Quân";
    public string DirectorTitle { get; set; } = "Giám đốc trung tâm";
    public string StoragePath { get; set; } = string.Empty;
    public string BackupDir { get; set; } = string.Empty;
}

public class AcademicRuleConfigDto
{
    public string ScoreScale { get; set; } = "Thang điểm 10 (0.0 - 10.0)";
    public double PassingScore { get; set; } = 6.5;
    public int WeightRegular { get; set; } = 20;
    public int WeightMidterm { get; set; } = 30;
    public int WeightFinal { get; set; } = 50;
    public double MinAttendanceRate { get; set; } = 80.0;
    public int MaxAbsencesAlert { get; set; } = 3;
    public bool IsLateCounted { get; set; } = true;
    public bool IsDebtBlockCert { get; set; } = true;
    public bool IsAutoLockAttendance { get; set; } = true;

    public int TotalWeight => WeightRegular + WeightMidterm + WeightFinal;
    public bool IsWeightValid => TotalWeight == 100;
}

public class BackupScheduleConfigDto
{
    public bool IsAutoBackupEnabled { get; set; } = true;
    public string BackupScheduleTime { get; set; } = "23:00 hàng ngày";
}

public class DatabaseStatusDto
{
    public string DatabasePath { get; set; } = string.Empty;
    public long FileSizeBytes { get; set; }
    public string FileSizeFormatted { get; set; } = "0 MB";
    public string JournalMode { get; set; } = "WAL";
    public string ForeignKeysStatus { get; set; } = "ON";
    public int TotalTablesCount { get; set; }
    public string IntegrityCheckResult { get; set; } = "OK";
}

public class BackupFileDto
{
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public string CreatedAtFormatted => CreatedAt.ToString("dd/MM/yyyy HH:mm");
    public long FileSizeBytes { get; set; }
    public string FileSizeFormatted { get; set; } = "0 MB";
    public string BackupType { get; set; } = "Thủ công"; // Thủ công / Tự động
    public string IntegrityStatus { get; set; } = "✓ Hợp lệ (OK)";
}
