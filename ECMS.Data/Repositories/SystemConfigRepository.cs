using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Data.Database;
using Microsoft.Data.Sqlite;

namespace ECMS.Data.Repositories;

public class SystemConfigRepository : ISystemConfigRepository
{
    public async Task<Dictionary<string, string>> GetAllConfigsAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        var rows = await conn.QueryAsync<(string ConfigKey, string? ConfigValue)>("SELECT ConfigKey, ConfigValue FROM SystemConfigs;");
        var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var r in rows)
        {
            dict[r.ConfigKey] = r.ConfigValue ?? string.Empty;
        }
        return dict;
    }

    public async Task<string?> GetConfigValueAsync(string key, string? defaultValue = null)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        var val = await conn.QueryFirstOrDefaultAsync<string?>(
            "SELECT ConfigValue FROM SystemConfigs WHERE ConfigKey = @key;", new { key });
        return val ?? defaultValue;
    }

    public async Task<bool> SaveConfigsAsync(Dictionary<string, string> configs)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            const string sql = @"
                INSERT INTO SystemConfigs (ConfigKey, ConfigValue, UpdatedAt)
                VALUES (@Key, @Value, CURRENT_TIMESTAMP)
                ON CONFLICT(ConfigKey) DO UPDATE SET 
                    ConfigValue = @Value,
                    UpdatedAt = CURRENT_TIMESTAMP;";

            foreach (var kvp in configs)
            {
                await conn.ExecuteAsync(sql, new { Key = kvp.Key, Value = kvp.Value }, tran);
            }

            tran.Commit();
            return true;
        }
        catch
        {
            tran.Rollback();
            throw;
        }
    }

    public async Task<DatabaseStatusDto> GetDatabaseStatusAsync()
    {
        var dto = new DatabaseStatusDto
        {
            DatabasePath = DatabaseConfig.DatabasePath
        };

        if (File.Exists(dto.DatabasePath))
        {
            var fi = new FileInfo(dto.DatabasePath);
            dto.FileSizeBytes = fi.Length;
            dto.FileSizeFormatted = FormatBytes(fi.Length);
        }

        using var conn = DatabaseConfig.CreateOpenConnection();
        dto.IntegrityCheckResult = (await conn.QueryFirstOrDefaultAsync<string>("PRAGMA integrity_check;")) ?? "OK";
        dto.JournalMode = (await conn.QueryFirstOrDefaultAsync<string>("PRAGMA journal_mode;"))?.ToUpperInvariant() ?? "WAL";
        var fk = await conn.QueryFirstOrDefaultAsync<int>("PRAGMA foreign_keys;");
        dto.ForeignKeysStatus = fk == 1 ? "ON" : "OFF";
        dto.TotalTablesCount = await conn.QueryFirstOrDefaultAsync<int>("SELECT COUNT(*) FROM sqlite_master WHERE type='table';");

        return dto;
    }

    public Task<IEnumerable<BackupFileDto>> GetBackupFilesAsync(string backupDir)
    {
        var list = new List<BackupFileDto>();
        if (!Directory.Exists(backupDir))
        {
            return Task.FromResult<IEnumerable<BackupFileDto>>(list);
        }

        var dirInfo = new DirectoryInfo(backupDir);
        var files = dirInfo.GetFiles("*.db", SearchOption.TopDirectoryOnly)
                           .OrderByDescending(f => f.CreationTime);

        foreach (var f in files)
        {
            string bType = f.Name.Contains("auto", StringComparison.OrdinalIgnoreCase) ? "Tự động" : "Thủ công";
            list.Add(new BackupFileDto
            {
                FileName = f.Name,
                FilePath = f.FullName,
                CreatedAt = f.CreationTime,
                FileSizeBytes = f.Length,
                FileSizeFormatted = FormatBytes(f.Length),
                BackupType = bType,
                IntegrityStatus = "✓ Hợp lệ (OK)"
            });
        }

        return Task.FromResult<IEnumerable<BackupFileDto>>(list);
    }

    public async Task<(bool Success, string BackupPath, string Message)> CreateOnlineBackupAsync(string targetDir, string backupType, int currentUserId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(targetDir))
            {
                targetDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ECMS", "Backups");
            }

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            string typeTag = backupType.Contains("Tự động", StringComparison.OrdinalIgnoreCase) ? "auto" : "manual";
            string fileName = $"ecms_backup_{DateTime.Now:yyyyMMdd_HHmmss}_{typeTag}.db";
            string backupPath = Path.Combine(targetDir, fileName);

            // 1. Online Backup bằng SQLite Backup API
            using (var srcConn = DatabaseConfig.CreateOpenConnection())
            {
                using var walCmd = srcConn.CreateCommand();
                walCmd.CommandText = "PRAGMA wal_checkpoint(TRUNCATE);";
                walCmd.ExecuteNonQuery();

                using (var destConn = new SqliteConnection($"Data Source={backupPath};Mode=ReadWriteCreate;"))
                {
                    destConn.Open();
                    srcConn.BackupDatabase(destConn);
                }
            }

            // 2. Kiểm tra tính toàn vẹn của tệp sao lưu mới
            using (var verifyConn = new SqliteConnection($"Data Source={backupPath};Mode=ReadOnly;"))
            {
                verifyConn.Open();
                using var chkCmd = verifyConn.CreateCommand();
                chkCmd.CommandText = "PRAGMA integrity_check;";
                var integrity = chkCmd.ExecuteScalar()?.ToString() ?? "ok";
                if (!string.Equals(integrity, "ok", StringComparison.OrdinalIgnoreCase))
                {
                    if (File.Exists(backupPath)) File.Delete(backupPath);
                    return (false, "", $"Tệp sao lưu không vượt qua kiểm tra tính toàn vẹn ({integrity}).");
                }
            }

            // 3. Ghi vết AuditLogs
            using (var auditConn = DatabaseConfig.CreateOpenConnection())
            {
                await auditConn.ExecuteAsync(@"
                    INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues, Timestamp)
                    VALUES (@UserId, 'BACKUP_DATABASE', 'SystemConfigs', @RecordId, @NewValues, CURRENT_TIMESTAMP);",
                    new
                    {
                        UserId = currentUserId > 0 ? (int?)currentUserId : null,
                        RecordId = fileName,
                        NewValues = $"Đã tạo bản sao lưu thành công: {backupPath}"
                    });
            }

            return (true, backupPath, $"Bản sao lưu '{fileName}' đã được tạo thành công.");
        }
        catch (Exception ex)
        {
            return (false, "", $"Lỗi khi tạo bản sao lưu: {ex.Message}");
        }
    }

    public async Task<(bool Success, string Message)> RestoreDatabaseAsync(string backupFilePath, int currentUserId)
    {
        if (!File.Exists(backupFilePath))
        {
            return (false, "Tệp sao lưu không tồn tại trên hệ thống đĩa.");
        }

        // 1. Kiểm tra tính toàn vẹn của file backup trước khi phục hồi
        try
        {
            using var chkConn = new SqliteConnection($"Data Source={backupFilePath};Mode=ReadOnly;");
            chkConn.Open();
            using var cmd = chkConn.CreateCommand();
            cmd.CommandText = "PRAGMA integrity_check;";
            var res = cmd.ExecuteScalar()?.ToString() ?? "ok";
            if (!string.Equals(res, "ok", StringComparison.OrdinalIgnoreCase))
            {
                return (false, $"Tệp sao lưu bị lỗi cấu trúc ({res}), không thể khôi phục.");
            }
        }
        catch (Exception ex)
        {
            return (false, $"Không thể đọc tệp sao lưu: {ex.Message}");
        }

        string activeDbPath = DatabaseConfig.DatabasePath;
        string safetySnapshot = activeDbPath + $".safety_{DateTime.Now:yyyyMMdd_HHmmss}";

        try
        {
            // 2. Đóng toàn bộ kết nối đến active database
            SqliteConnection.ClearAllPools();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // 3. Tạo snapshot dự phòng của CSDL hiện tại
            if (File.Exists(activeDbPath))
            {
                File.Copy(activeDbPath, safetySnapshot, true);
            }

            // 4. Xóa tệp phụ WAL/SHM nếu có
            string walPath = activeDbPath + "-wal";
            string shmPath = activeDbPath + "-shm";
            if (File.Exists(walPath)) File.Delete(walPath);
            if (File.Exists(shmPath)) File.Delete(shmPath);

            // 5. Ghi đè file backup vào active database
            File.Copy(backupFilePath, activeDbPath, true);

            // 6. Mở lại kết nối kiểm tra
            using (var testConn = DatabaseConfig.CreateOpenConnection())
            {
                await testConn.ExecuteAsync(@"
                    INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues, Timestamp)
                    VALUES (@UserId, 'RESTORE_DATABASE', 'SystemConfigs', @RecordId, @NewValues, CURRENT_TIMESTAMP);",
                    new
                    {
                        UserId = currentUserId > 0 ? (int?)currentUserId : null,
                        RecordId = Path.GetFileName(backupFilePath),
                        NewValues = $"Đã phục hồi CSDL từ bản sao lưu: {Path.GetFileName(backupFilePath)}"
                    });
            }

            // Xóa snapshot an toàn tạm nếu thành công
            if (File.Exists(safetySnapshot))
            {
                try { File.Delete(safetySnapshot); } catch { }
            }

            return (true, $"Đã phục hồi cơ sở dữ liệu về bản sao lưu '{Path.GetFileName(backupFilePath)}' thành công.");
        }
        catch (Exception ex)
        {
            // Rollback về snapshot an toàn nếu khôi phục thất bại
            if (File.Exists(safetySnapshot))
            {
                try
                {
                    SqliteConnection.ClearAllPools();
                    File.Copy(safetySnapshot, activeDbPath, true);
                }
                catch { }
            }
            return (false, $"Quá trình phục hồi CSDL thất bại: {ex.Message}");
        }
    }

    public async Task<(bool Success, string Message)> DeleteBackupFileAsync(string backupFilePath, int currentUserId)
    {
        try
        {
            if (!File.Exists(backupFilePath))
            {
                return (false, "Tệp sao lưu không tồn tại.");
            }

            string fileName = Path.GetFileName(backupFilePath);
            File.Delete(backupFilePath);

            using var conn = DatabaseConfig.CreateOpenConnection();
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES (@UserId, 'DELETE_BACKUP', 'SystemConfigs', @RecordId, @NewValues, CURRENT_TIMESTAMP);",
                new
                {
                    UserId = currentUserId > 0 ? (int?)currentUserId : null,
                    RecordId = fileName,
                    NewValues = $"Đã xóa tệp sao lưu: {fileName}"
                });

            return (true, $"Đã xóa tệp sao lưu '{fileName}' thành công.");
        }
        catch (Exception ex)
        {
            return (false, $"Lỗi khi xóa tệp sao lưu: {ex.Message}");
        }
    }

    private static string FormatBytes(long bytes)
    {
        if (bytes < 1024) return $"{bytes} B";
        if (bytes < 1024 * 1024) return $"{(bytes / 1024.0):0.0} KB";
        return $"{(bytes / (1024.0 * 1024.0)):0.0} MB";
    }
}
