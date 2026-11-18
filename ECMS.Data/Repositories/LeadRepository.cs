using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class LeadRepository : BaseRepository, ILeadRepository
{
    private static bool _isSeedChecked = false;

    private async Task EnsureSeedDataAsync()
    {
        if (_isSeedChecked) return;
        _isSeedChecked = true;

        using var conn = CreateConnection();
        int count = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Leads;");
        if (count == 0)
        {
            await conn.ExecuteAsync(@"
                INSERT INTO Leads (LeadId, FullName, Phone, Email, Source, Status, AssignedEmployeeId, Notes, CreatedAt)
                VALUES 
                (1, 'Nguyễn Thị Thu Hà', '0905123456', 'thuha.nguyen@gmail.com', 'Facebook Fanpage', 'New', 3, 'Quan tâm khóa học IELTS cấp tốc để du học, rảnh tối 2-4-6.', datetime('now', '-2 days')),
                (2, 'Trần Đình Trọng', '0912345678', 'trong.tran@yahoo.com', 'Trực tiếp tại quầy', 'Contacted', 3, 'Muốn nâng điểm TOEIC từ 400 lên 650 để ra trường. Đã tư vấn lộ trình 3 tháng.', datetime('now', '-3 days')),
                (3, 'Lê Hoàng Yến', '0987654321', 'hoangyen.le@outlook.com', 'Website đăng ký', 'TestScheduled', 3, 'Đã hẹn lịch làm bài Placement Test 4 kỹ năng vào 14:00 Thứ 7 tuần này.', datetime('now', '-1 days')),
                (4, 'Phạm Quốc Bảo', '0933112233', 'quocbao.pham@gmail.com', 'Bạn bè giới thiệu', 'Converted', 3, 'Đã làm bài test đạt 5.5, đã đồng ý đăng ký vào lớp IELTS-K26.', datetime('now', '-5 days')),
                (5, 'Võ Minh Khôi', '0944556677', 'khoi.vo@gmail.com', 'Hotline tư vấn', 'Contacted', 3, 'Cần học Giao tiếp phản xạ cho người đi làm. Đang phân vân học phí.', datetime('now', '-4 days')),
                (6, 'Đỗ Mỹ Linh', '0977889900', 'mylinh.do@gmail.com', 'Facebook Fanpage', 'Lost', 3, 'Khách báo bận lịch công tác dài hạn không thể thu xếp học được.', datetime('now', '-7 days'));
            ");
        }
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
