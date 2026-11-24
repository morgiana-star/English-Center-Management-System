using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class LeadRepository : BaseRepository, ILeadRepository
{
    private Task EnsureSeedDataAsync()
    {
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<LeadListItemDto>> GetLeadsAsync(LeadFilterDto filter)
    {
        await EnsureSeedDataAsync();

        using var conn = CreateConnection();
        var sql = new StringBuilder(@"
            SELECT 
                l.LeadId,
                l.FullName,
                l.Phone,
                l.Email,
                l.Source,
                l.Status,
                l.AssignedEmployeeId,
                e.FullName AS AssignedEmployeeName,
                l.Notes,
                l.CreatedAt
            FROM Leads l
            LEFT JOIN Employees e ON l.AssignedEmployeeId = e.EmployeeId
            WHERE 1=1 ");

        var parameters = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(filter.Status) && filter.Status != "ALL")
        {
            sql.Append(" AND l.Status = @Status ");
            parameters.Add("Status", filter.Status);
        }

        if (!string.IsNullOrWhiteSpace(filter.Source) && filter.Source != "ALL")
        {
            sql.Append(" AND l.Source = @Source ");
            parameters.Add("Source", filter.Source);
        }

        if (!string.IsNullOrWhiteSpace(filter.Keyword))
        {
            sql.Append(@" AND (
                l.FullName LIKE @Kw 
                OR l.Phone LIKE @Kw 
                OR l.Email LIKE @Kw 
                OR l.Notes LIKE @Kw
            ) ");
            parameters.Add("Kw", $"%{filter.Keyword.Trim()}%");
        }

        sql.Append(" ORDER BY l.LeadId DESC LIMIT @Limit OFFSET @Offset; ");
        parameters.Add("Limit", filter.Limit <= 0 ? 500 : filter.Limit);
        parameters.Add("Offset", filter.Offset < 0 ? 0 : filter.Offset);

        return await conn.QueryAsync<LeadListItemDto>(sql.ToString(), parameters);
    }

    public async Task<int> GetTotalCountAsync(LeadFilterDto filter)
    {
        await EnsureSeedDataAsync();

        using var conn = CreateConnection();
        var sql = new StringBuilder("SELECT COUNT(*) FROM Leads l WHERE 1=1 ");
        var parameters = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(filter.Status) && filter.Status != "ALL")
        {
            sql.Append(" AND l.Status = @Status ");
            parameters.Add("Status", filter.Status);
        }

        if (!string.IsNullOrWhiteSpace(filter.Source) && filter.Source != "ALL")
        {
            sql.Append(" AND l.Source = @Source ");
            parameters.Add("Source", filter.Source);
        }

        if (!string.IsNullOrWhiteSpace(filter.Keyword))
        {
            sql.Append(@" AND (
                l.FullName LIKE @Kw 
                OR l.Phone LIKE @Kw 
                OR l.Email LIKE @Kw 
                OR l.Notes LIKE @Kw
            ) ");
            parameters.Add("Kw", $"%{filter.Keyword.Trim()}%");
        }

        return await conn.ExecuteScalarAsync<int>(sql.ToString(), parameters);
    }

    public async Task<LeadCreateOrUpdateDto?> GetByIdAsync(int leadId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                LeadId,
                FullName,
                Phone,
                Email,
                Source,
                Status,
                AssignedEmployeeId,
                Notes
            FROM Leads
            WHERE LeadId = @LeadId;";
        return await conn.QuerySingleOrDefaultAsync<LeadCreateOrUpdateDto>(sql, new { LeadId = leadId });
    }

    public async Task<int> InsertAsync(LeadCreateOrUpdateDto dto)
    {
        using var conn = CreateConnection();
        const string sql = @"
            INSERT INTO Leads (FullName, Phone, Email, Source, Status, AssignedEmployeeId, Notes, CreatedAt)
            VALUES (@FullName, @Phone, @Email, @Source, @Status, @AssignedEmployeeId, @Notes, CURRENT_TIMESTAMP);
            SELECT last_insert_rowid();";
        return await conn.ExecuteScalarAsync<int>(sql, dto);
    }

    public async Task<bool> UpdateAsync(LeadCreateOrUpdateDto dto)
    {
        using var conn = CreateConnection();
        const string sql = @"
            UPDATE Leads 
            SET FullName = @FullName,
                Phone = @Phone,
                Email = @Email,
                Source = @Source,
                Status = @Status,
                AssignedEmployeeId = @AssignedEmployeeId,
                Notes = @Notes,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE LeadId = @LeadId;";
        int rows = await conn.ExecuteAsync(sql, dto);
        return rows > 0;
    }

    public async Task<bool> UpdateStatusAsync(int leadId, string status)
    {
        using var conn = CreateConnection();
        const string sql = @"
            UPDATE Leads 
            SET Status = @Status,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE LeadId = @LeadId;";
        int rows = await conn.ExecuteAsync(sql, new { LeadId = leadId, Status = status });
        return rows > 0;
    }

    public async Task<LeadSummaryDto> GetSummaryAsync()
    {
        await EnsureSeedDataAsync();

        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                (SELECT COUNT(*) FROM Leads) AS TotalLeads,
                (SELECT COUNT(*) FROM Leads WHERE Status = 'New') AS NewLeads,
                (SELECT COUNT(*) FROM Leads WHERE Status = 'Contacted') AS ContactedLeads,
                (SELECT COUNT(*) FROM Leads WHERE Status = 'TestScheduled') AS TestScheduledLeads,
                (SELECT COUNT(*) FROM Leads WHERE Status = 'Converted') AS ConvertedLeads,
                (SELECT COUNT(*) FROM Leads WHERE Status = 'Lost') AS LostLeads;";
        return await conn.QuerySingleOrDefaultAsync<LeadSummaryDto>(sql) ?? new LeadSummaryDto();
    }

    public async Task<bool> CheckPhoneExistsAsync(string phone, int? excludeLeadId = null)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT COUNT(*) 
            FROM Leads 
            WHERE Phone = @Phone 
              AND (@ExcludeId IS NULL OR LeadId != @ExcludeId);";
        int count = await conn.ExecuteScalarAsync<int>(sql, new { Phone = phone.Trim(), ExcludeId = excludeLeadId });
        return count > 0;
    }

    public async Task<IEnumerable<string>> GetDistinctSourcesAsync()
    {
        await EnsureSeedDataAsync();

        using var conn = CreateConnection();
        const string sql = "SELECT DISTINCT Source FROM Leads WHERE Source IS NOT NULL AND Source != '' ORDER BY Source;";
        return await conn.QueryAsync<string>(sql);
    }
}
