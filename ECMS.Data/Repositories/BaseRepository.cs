using System.Data;
using ECMS.Data.Database;
using Microsoft.Data.Sqlite;

namespace ECMS.Data.Repositories;

public abstract class BaseRepository
{
    protected SqliteConnection CreateConnection()
    {
        return DatabaseConfig.CreateOpenConnection();
    }
}
