using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface ISystemConfigRepository
{
    Task<Dictionary<string, string>> GetAllConfigsAsync();
    Task<string?> GetConfigValueAsync(string key, string? defaultValue = null);
    Task<bool> SaveConfigsAsync(Dictionary<string, string> configs);
    Task<DatabaseStatusDto> GetDatabaseStatusAsync();
    Task<IEnumerable<BackupFileDto>> GetBackupFilesAsync(string backupDir);
    Task<(bool Success, string BackupPath, string Message)> CreateOnlineBackupAsync(string targetDir, string backupType, int currentUserId);
    Task<(bool Success, string Message)> RestoreDatabaseAsync(string backupFilePath, int currentUserId);
    Task<(bool Success, string Message)> DeleteBackupFileAsync(string backupFilePath, int currentUserId);
}
