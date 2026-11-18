using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Database;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class SystemConfigService : ISystemConfigService
{
    private readonly ISystemConfigRepository _configRepo;

    public SystemConfigService(ISystemConfigRepository? configRepo = null)
    {
        _configRepo = configRepo ?? new SystemConfigRepository();
    }

    public async Task<CenterConfigDto> GetCenterConfigAsync()
    {
        var configs = await _configRepo.GetAllConfigsAsync();
        string defaultAppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ECMS");

        var dto = new CenterConfigDto
        {
            CenterName = configs.GetValueOrDefault("CenterName", "Trung tâm Anh ngữ ECMS Minh Trí"),
            CenterPhone = configs.GetValueOrDefault("CenterPhone", "028 3822 6688"),
            CenterEmail = configs.GetValueOrDefault("CenterEmail", "contact@ecms.edu.vn"),
            CenterWebsite = configs.GetValueOrDefault("CenterWebsite", "https://ecms.edu.vn"),
            CenterAddress = configs.GetValueOrDefault("CenterAddress", "25 Nguyễn Văn Cừ, Phường 4, Quận 5, TP. Hồ Chí Minh"),
            DirectorName = configs.GetValueOrDefault("DirectorName", "Trần Minh Quân"),
            DirectorTitle = configs.GetValueOrDefault("DirectorTitle", "Giám đốc trung tâm"),
            StoragePath = configs.GetValueOrDefault("StoragePath", Path.Combine(defaultAppDir, "TaiLieu")),
            BackupDir = configs.GetValueOrDefault("BackupDir", Path.Combine(defaultAppDir, "Backups"))
        };

        // Đảm bảo thư mục tồn tại
        if (!Directory.Exists(dto.StoragePath))
        {
            try { Directory.CreateDirectory(dto.StoragePath); } catch { }
        }
        if (!Directory.Exists(dto.BackupDir))
        {
            try { Directory.CreateDirectory(dto.BackupDir); } catch { }
        }

        return dto;
    }

    public async Task<(bool Success, string Message)> SaveCenterConfigAsync(CenterConfigDto dto, int currentUserId)
    {
        if (string.IsNullOrWhiteSpace(dto.CenterName))
            return (false, "Tên trung tâm không được để trống.");

        if (string.IsNullOrWhiteSpace(dto.CenterPhone))
            return (false, "Số điện thoại trung tâm không được để trống.");

        if (string.IsNullOrWhiteSpace(dto.DirectorName))
            return (false, "Tên người đại diện ký duyệt không được để trống.");

        var dict = new Dictionary<string, string>
        {
            ["CenterName"] = dto.CenterName.Trim(),
            ["CenterPhone"] = dto.CenterPhone.Trim(),
            ["CenterEmail"] = dto.CenterEmail.Trim(),
            ["CenterWebsite"] = dto.CenterWebsite.Trim(),
            ["CenterAddress"] = dto.CenterAddress.Trim(),
            ["DirectorName"] = dto.DirectorName.Trim(),
            ["DirectorTitle"] = string.IsNullOrWhiteSpace(dto.DirectorTitle) ? "Giám đốc trung tâm" : dto.DirectorTitle.Trim(),
            ["StoragePath"] = dto.StoragePath.Trim(),
            ["BackupDir"] = dto.BackupDir.Trim()
        };

        await _configRepo.SaveConfigsAsync(dict);
        return (true, "Lưu thông tin trung tâm và cấu hình thư mục thành công.");
    }

    public async Task<AcademicRuleConfigDto> GetAcademicRulesAsync()
    {
        var configs = await _configRepo.GetAllConfigsAsync();

        var dto = new AcademicRuleConfigDto
        {
            ScoreScale = configs.GetValueOrDefault("ScoreScale", "Thang điểm 10 (0.0 - 10.0)"),
            PassingScore = double.TryParse(configs.GetValueOrDefault("MinPassingGPA", "6.5"), NumberStyles.Any, CultureInfo.InvariantCulture, out var ps) ? ps : 6.5,
            WeightRegular = int.TryParse(configs.GetValueOrDefault("WeightRegular", "20"), out var wr) ? wr : 20,
            WeightMidterm = int.TryParse(configs.GetValueOrDefault("WeightMidterm", "30"), out var wm) ? wm : 30,
            WeightFinal = int.TryParse(configs.GetValueOrDefault("WeightFinal", "50"), out var wf) ? wf : 50,
            MinAttendanceRate = double.TryParse(configs.GetValueOrDefault("MinAttendanceRate", "80.0"), NumberStyles.Any, CultureInfo.InvariantCulture, out var ar) ? ar : 80.0,
            MaxAbsencesAlert = int.TryParse(configs.GetValueOrDefault("MaxAbsencesAlert", "3"), out var ma) ? ma : 3,
            IsLateCounted = configs.GetValueOrDefault("IsLateCounted", "True").Equals("True", StringComparison.OrdinalIgnoreCase),
            IsDebtBlockCert = configs.GetValueOrDefault("IsDebtBlockCert", "True").Equals("True", StringComparison.OrdinalIgnoreCase),
            IsAutoLockAttendance = configs.GetValueOrDefault("IsAutoLockAttendance", "True").Equals("True", StringComparison.OrdinalIgnoreCase)
        };

        return dto;
    }

    public async Task<(bool Success, string Message)> SaveAcademicRulesAsync(AcademicRuleConfigDto dto, int currentUserId)
    {
        if (!dto.IsWeightValid)
        {
            return (false, $"Tổng trọng số đánh giá ({dto.WeightRegular}% + {dto.WeightMidterm}% + {dto.WeightFinal}% = {dto.TotalWeight}%) bắt buộc phải bằng đúng 100%.");
        }

        if (dto.PassingScore < 0)
            return (false, "Điểm đạt tối thiểu không hợp lệ.");

        if (dto.MinAttendanceRate < 0 || dto.MinAttendanceRate > 100)
            return (false, "Tỷ lệ chuyên cần tối thiểu phải nằm trong khoảng từ 0% đến 100%.");

        if (dto.MaxAbsencesAlert <= 0)
            return (false, "Số buổi vắng tối đa kích hoạt cảnh báo phải lớn hơn 0.");

        var dict = new Dictionary<string, string>
        {
            ["ScoreScale"] = dto.ScoreScale,
            ["MinPassingGPA"] = dto.PassingScore.ToString(CultureInfo.InvariantCulture),
            ["WeightRegular"] = dto.WeightRegular.ToString(),
            ["WeightMidterm"] = dto.WeightMidterm.ToString(),
            ["WeightFinal"] = dto.WeightFinal.ToString(),
            ["MinAttendanceRate"] = dto.MinAttendanceRate.ToString(CultureInfo.InvariantCulture),
            ["MaxAbsencesAlert"] = dto.MaxAbsencesAlert.ToString(),
            ["IsLateCounted"] = dto.IsLateCounted.ToString(),
            ["IsDebtBlockCert"] = dto.IsDebtBlockCert.ToString(),
            ["IsAutoLockAttendance"] = dto.IsAutoLockAttendance.ToString()
        };

        await _configRepo.SaveConfigsAsync(dict);
        return (true, "Lưu quy tắc điểm số và chuyên cần thành công.");
    }

    public async Task<BackupScheduleConfigDto> GetBackupScheduleConfigAsync()
    {
        var configs = await _configRepo.GetAllConfigsAsync();
        return new BackupScheduleConfigDto
        {
            IsAutoBackupEnabled = configs.GetValueOrDefault("AutoBackupEnabled", "True").Equals("True", StringComparison.OrdinalIgnoreCase),
            BackupScheduleTime = configs.GetValueOrDefault("BackupScheduleTime", "23:00 hàng ngày")
        };
    }

    public async Task<(bool Success, string Message)> SaveBackupScheduleConfigAsync(BackupScheduleConfigDto dto, int currentUserId)
    {
        var dict = new Dictionary<string, string>
        {
            ["AutoBackupEnabled"] = dto.IsAutoBackupEnabled.ToString(),
            ["BackupScheduleTime"] = dto.BackupScheduleTime
        };

        await _configRepo.SaveConfigsAsync(dict);
        return (true, "Lưu cấu hình lịch sao lưu tự động thành công.");
    }

    public Task<DatabaseStatusDto> GetDatabaseStatusAsync() => _configRepo.GetDatabaseStatusAsync();

    public Task<IEnumerable<BackupFileDto>> GetBackupFilesAsync(string backupDir) => _configRepo.GetBackupFilesAsync(backupDir);

    public Task<(bool Success, string BackupPath, string Message)> CreateOnlineBackupAsync(string targetDir, string backupType, int currentUserId)
        => _configRepo.CreateOnlineBackupAsync(targetDir, backupType, currentUserId);

    public Task<(bool Success, string Message)> RestoreDatabaseAsync(string backupFilePath, int currentUserId)
        => _configRepo.RestoreDatabaseAsync(backupFilePath, currentUserId);

    public Task<(bool Success, string Message)> DeleteBackupFileAsync(string backupFilePath, int currentUserId)
        => _configRepo.DeleteBackupFileAsync(backupFilePath, currentUserId);
}
