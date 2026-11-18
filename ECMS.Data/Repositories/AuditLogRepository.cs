using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class AuditLogRepository : BaseRepository, IAuditLogRepository
{
    public async Task<IEnumerable<AuditLogListItemDto>> GetLogsAsync(AuditLogFilterDto filter)
    {
        using var conn = CreateConnection();
        var sql = new StringBuilder(@"
            SELECT 
                a.LogId,
                a.UserId,
                COALESCE(u.Username, 'SYSTEM') AS Username,
                COALESCE(u.FullName, 'Hệ thống') AS ActorName,
                COALESCE(GROUP_CONCAT(r.RoleName, ', '), 'Hệ thống') AS RoleName,
                a.ActionName,
                a.TableName,
                a.RecordId,
                a.OldValues,
                a.NewValues,
                a.Timestamp
            FROM AuditLogs a
            LEFT JOIN Users u ON a.UserId = u.UserId
            LEFT JOIN UserRoles ur ON u.UserId = ur.UserId
            LEFT JOIN Roles r ON ur.RoleId = r.RoleId
            WHERE 1=1 ");

        var parameters = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(filter.ActionName) && filter.ActionName != "ALL")
        {
            sql.Append(" AND a.ActionName = @ActionName ");
            parameters.Add("ActionName", filter.ActionName);
        }

        if (!string.IsNullOrWhiteSpace(filter.TableName) && filter.TableName != "ALL")
        {
            sql.Append(" AND a.TableName = @TableName ");
            parameters.Add("TableName", filter.TableName);
        }

        if (filter.FromDate.HasValue)
        {
            sql.Append(" AND date(datetime(a.Timestamp, 'localtime')) >= date(@FromDate) ");
            parameters.Add("FromDate", filter.FromDate.Value.ToString("yyyy-MM-dd"));
        }

        if (filter.ToDate.HasValue)
        {
            sql.Append(" AND date(datetime(a.Timestamp, 'localtime')) <= date(@ToDate) ");
            parameters.Add("ToDate", filter.ToDate.Value.ToString("yyyy-MM-dd"));
        }

        if (!string.IsNullOrWhiteSpace(filter.Keyword))
        {
            sql.Append(@" AND (
                u.Username LIKE @Kw 
                OR u.FullName LIKE @Kw 
                OR a.ActionName LIKE @Kw 
                OR a.TableName LIKE @Kw 
                OR a.RecordId LIKE @Kw 
                OR a.NewValues LIKE @Kw 
                OR a.OldValues LIKE @Kw
            ) ");
            parameters.Add("Kw", $"%{filter.Keyword.Trim()}%");
        }

        sql.Append(@" 
            GROUP BY a.LogId, a.UserId, u.Username, u.FullName, a.ActionName, a.TableName, a.RecordId, a.OldValues, a.NewValues, a.Timestamp
            ORDER BY a.LogId DESC 
            LIMIT @Limit OFFSET @Offset; ");

        parameters.Add("Limit", filter.Limit <= 0 ? 500 : filter.Limit);
        parameters.Add("Offset", filter.Offset < 0 ? 0 : filter.Offset);

        return await conn.QueryAsync<AuditLogListItemDto>(sql.ToString(), parameters);
    }

    public async Task<int> GetTotalCountAsync(AuditLogFilterDto filter)
    {
        using var conn = CreateConnection();
        var sql = new StringBuilder(@"
            SELECT COUNT(DISTINCT a.LogId)
            FROM AuditLogs a
            LEFT JOIN Users u ON a.UserId = u.UserId
            WHERE 1=1 ");

        var parameters = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(filter.ActionName) && filter.ActionName != "ALL")
        {
            sql.Append(" AND a.ActionName = @ActionName ");
            parameters.Add("ActionName", filter.ActionName);
        }

        if (!string.IsNullOrWhiteSpace(filter.TableName) && filter.TableName != "ALL")
        {
            sql.Append(" AND a.TableName = @TableName ");
            parameters.Add("TableName", filter.TableName);
        }

        if (filter.FromDate.HasValue)
        {
            sql.Append(" AND date(datetime(a.Timestamp, 'localtime')) >= date(@FromDate) ");
            parameters.Add("FromDate", filter.FromDate.Value.ToString("yyyy-MM-dd"));
        }

        if (filter.ToDate.HasValue)
        {
            sql.Append(" AND date(datetime(a.Timestamp, 'localtime')) <= date(@ToDate) ");
            parameters.Add("ToDate", filter.ToDate.Value.ToString("yyyy-MM-dd"));
        }

        if (!string.IsNullOrWhiteSpace(filter.Keyword))
        {
            sql.Append(@" AND (
                u.Username LIKE @Kw 
                OR u.FullName LIKE @Kw 
                OR a.ActionName LIKE @Kw 
                OR a.TableName LIKE @Kw 
                OR a.RecordId LIKE @Kw 
                OR a.NewValues LIKE @Kw 
                OR a.OldValues LIKE @Kw
            ) ");
            parameters.Add("Kw", $"%{filter.Keyword.Trim()}%");
        }

        return await conn.ExecuteScalarAsync<int>(sql.ToString(), parameters);
    }

    public async Task<IEnumerable<string>> GetDistinctActionNamesAsync()
    {
        using var conn = CreateConnection();
        return await conn.QueryAsync<string>("SELECT DISTINCT ActionName FROM AuditLogs ORDER BY ActionName;");
    }

    public async Task<IEnumerable<string>> GetDistinctTableNamesAsync()
    {
        using var conn = CreateConnection();
        return await conn.QueryAsync<string>("SELECT DISTINCT TableName FROM AuditLogs ORDER BY TableName;");
    }

    public async Task<AuditLogSummaryDto> GetSummaryAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                (SELECT COUNT(*) FROM AuditLogs) AS TotalLogs,
                (SELECT COUNT(*) FROM AuditLogs WHERE date(datetime(Timestamp, 'localtime')) = date('now', 'localtime')) AS TodayLogs,
                (SELECT COUNT(DISTINCT UserId) FROM AuditLogs WHERE UserId IS NOT NULL) AS UniqueUsersCount,
                (SELECT COUNT(*) FROM AuditLogs WHERE ActionName IN ('BRUTE_FORCE_LOCKOUT', 'UNLOCK_USER', 'RESET_PASSWORD', 'CHANGE_PASSWORD')) AS SecurityEventsCount;
        ";
        return await conn.QuerySingleOrDefaultAsync<AuditLogSummaryDto>(sql) ?? new AuditLogSummaryDto();
    }

    public async Task<int> LogAsync(int? userId, string actionName, string tableName, string? recordId, string? oldValues, string? newValues)
    {
        using var conn = CreateConnection();
        const string sql = @"
            INSERT INTO AuditLogs (UserId, ActionName, TableName, RecordId, OldValues, NewValues, Timestamp)
            VALUES (@UserId, @ActionName, @TableName, @RecordId, @OldValues, @NewValues, CURRENT_TIMESTAMP);
            SELECT last_insert_rowid();
        ";
        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            UserId = userId,
            ActionName = actionName,
            TableName = tableName,
            RecordId = recordId,
            OldValues = oldValues,
            NewValues = newValues
        });
    }
}
