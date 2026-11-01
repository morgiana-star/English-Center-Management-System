using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace ECMS.Data.Database;

public static class DatabaseConfig
{
    private static string? _dbPath;

    public static string DatabasePath
    {
        get
        {
            if (string.IsNullOrEmpty(_dbPath))
            {
                // Store in AppData/ECMS to ensure write permissions
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string ecmsDir = Path.Combine(appData, "ECMS");
                if (!Directory.Exists(ecmsDir))
                {
                    Directory.CreateDirectory(ecmsDir);
                }
                _dbPath = Path.Combine(ecmsDir, "ecms_data.db");
            }
            return _dbPath;
        }
        set => _dbPath = value;
    }

    public static string ConnectionString => $"Data Source={DatabasePath};Mode=ReadWriteCreate;Cache=Shared;";

    public static SqliteConnection CreateOpenConnection()
    {
        var conn = new SqliteConnection(ConnectionString);
        conn.Open();
        
        // Enforce SQLite Foreign Keys and WAL Mode for high performance
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "PRAGMA foreign_keys = ON; PRAGMA journal_mode = WAL;";
        cmd.ExecuteNonQuery();

        return conn;
    }

    public static SqliteConnection GetConnection() => CreateOpenConnection();
}
