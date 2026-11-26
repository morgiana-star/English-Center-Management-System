using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface ISystemConfigService
{
    Task<CenterConfigDto> GetCenterConfigAsync();
    Task<(bool Success, string Message)> SaveCenterConfigAsync(CenterConfigDto dto, int currentUserId);
    Task<AcademicRuleConfigDto> GetAcademicRulesAsync();
    Task<(bool Success, string Message)> SaveAcademicRulesAsync(AcademicRuleConfigDto dto, int currentUserId);
    Task<BackupScheduleConfigDto> GetBackupScheduleConfigAsync();
    Task<(bool Success, string Message)> SaveBackupScheduleConfigAsync(BackupScheduleConfigDto dto, int currentUserId);
    Task<DatabaseStatusDto> GetDatabaseStatusAsync();
    Task<IEnumerable<BackupFileDto>> GetBackupFilesAsync(string backupDir);
    Task<(bool Success, string BackupPath, string Message)> CreateOnlineBackupAsync(string targetDir, string backupType, int currentUserId);
    Task<(bool Success, string Message)> RestoreDatabaseAsync(string backupFilePath, int currentUserId);
    Task<(bool Success, string Message)> DeleteBackupFileAsync(string backupFilePath, int currentUserId);
}
