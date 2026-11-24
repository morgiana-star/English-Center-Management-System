using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;
using ECMS.Core.Helpers;

namespace ECMS.Data.Repositories;

public class TeacherRepository : BaseRepository, ITeacherRepository
{
    public async Task<IEnumerable<TeacherListItemDto>> GetAllTeachersAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                t.TeacherId,
                t.TeacherCode,
                t.FullName,
                t.Specialization,
                COALESCE(t.Phone, '') AS Phone,
                COALESCE(t.Email, '') AS Email,
                COALESCE(t.Certificate, '') AS Certificate,
                COALESCE(t.Notes, '') AS Notes,
                COALESCE(t.PreferredShifts, '') AS PreferredShifts,
                COALESCE(t.AvailableDays, '') AS AvailableDays,
                t.IsActive,
                (SELECT COUNT(*) FROM Classes c WHERE c.MainTeacherId = t.TeacherId AND c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')) AS ActiveClassCount
            FROM Teachers t
            ORDER BY t.TeacherId DESC;";
        return await conn.QueryAsync<TeacherListItemDto>(sql);
    }

    public async Task<TeacherListItemDto?> GetTeacherByIdAsync(int teacherId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT
                t.TeacherId,
                t.TeacherCode,
                t.FullName,
                t.Specialization,
                COALESCE(t.Phone, '') AS Phone,
                COALESCE(t.Email, '') AS Email,
                COALESCE(t.Certificate, '') AS Certificate,
                COALESCE(t.Notes, '') AS Notes,
                COALESCE(t.PreferredShifts, '') AS PreferredShifts,
                COALESCE(t.AvailableDays, '') AS AvailableDays,
                t.IsActive,
                (SELECT COUNT(*) FROM Classes c WHERE c.MainTeacherId = t.TeacherId AND c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')) AS ActiveClassCount
            FROM Teachers t
            WHERE t.TeacherId = @TeacherId
            LIMIT 1;";
        return await conn.QuerySingleOrDefaultAsync<TeacherListItemDto>(sql, new { TeacherId = teacherId });
    }

    public async Task<string> GenerateNextTeacherCodeAsync()
    {
        using var conn = CreateConnection();
        var codes = await conn.QueryAsync<string>("SELECT TeacherCode FROM Teachers WHERE TeacherCode LIKE 'GV-%';");
        int maxNum = 0;
        foreach (var code in codes)
        {
            if (string.IsNullOrWhiteSpace(code) || !code.Contains('-')) continue;
            string tail = code.Substring(code.LastIndexOf('-') + 1);
            if (int.TryParse(tail, out int n) && n > maxNum) maxNum = n;
        }
        return CodeFormatHelper.FormatTeacherCode(maxNum + 1);
    }

    public async Task<(bool Success, string Message, int TeacherId)> CreateTeacherAsync(SaveTeacherDto dto)
    {
        using var conn = CreateConnection();
        string code = string.IsNullOrWhiteSpace(dto.TeacherCode)
            ? await GenerateNextTeacherCodeAsync()
            : dto.TeacherCode.Trim().ToUpperInvariant();

        int dupCode = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Teachers WHERE UPPER(TRIM(TeacherCode)) = @Code;", new { Code = code });
        if (dupCode > 0)
            return (false, $"Mã giáo viên '{code}' đã tồn tại trong hệ thống.", 0);

        string cleanPhone = (dto.Phone ?? "").Replace(" ", "").Trim();
        int dupPhone = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Teachers WHERE REPLACE(COALESCE(Phone, ''), ' ', '') = @Phone;", new { Phone = cleanPhone });
        if (dupPhone > 0)
            return (false, $"Số điện thoại '{dto.Phone}' đã được sử dụng bởi giáo viên khác.", 0);

        int id = await conn.ExecuteScalarAsync<int>(@"
            INSERT INTO Teachers (TeacherCode, FullName, Specialization, Phone, Email, Certificate, Notes, PreferredShifts, AvailableDays, IsActive, CreatedAt)
            VALUES (@Code, @FullName, @Specialization, @Phone, @Email, @Certificate, @Notes, @PreferredShifts, @AvailableDays, @IsActive, CURRENT_TIMESTAMP);
            SELECT last_insert_rowid();",
            new
            {
                Code = code,
                FullName = dto.FullName.Trim(),
                Specialization = dto.Specialization.Trim(),
                Phone = cleanPhone,
                Email = dto.Email?.Trim() ?? "",
                Certificate = dto.Certificate?.Trim() ?? "",
                Notes = dto.Notes?.Trim() ?? "",
                PreferredShifts = dto.PreferredShifts?.Trim() ?? "",
                AvailableDays = dto.AvailableDays?.Trim() ?? "",
                IsActive = dto.IsActive ? 1 : 0
            });

        return (true, $"Đã thêm giáo viên {dto.FullName.Trim()} ({code}) thành công.", id);
    }

    public async Task<(bool Success, string Message)> UpdateTeacherAsync(SaveTeacherDto dto)
    {
        using var conn = CreateConnection();
        string cleanPhone = (dto.Phone ?? "").Replace(" ", "").Trim();
        int dupPhone = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Teachers WHERE REPLACE(COALESCE(Phone, ''), ' ', '') = @Phone AND TeacherId != @Id;",
            new { Phone = cleanPhone, Id = dto.TeacherId });
        if (dupPhone > 0)
            return (false, $"Số điện thoại '{dto.Phone}' đã được sử dụng bởi giáo viên khác.");

        int rows = await conn.ExecuteAsync(@"
            UPDATE Teachers SET
                FullName = @FullName,
                Specialization = @Specialization,
                Phone = @Phone,
                Email = @Email,
                Certificate = @Certificate,
                Notes = @Notes,
                PreferredShifts = @PreferredShifts,
                AvailableDays = @AvailableDays,
                IsActive = @IsActive,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE TeacherId = @TeacherId;",
            new
            {
                FullName = dto.FullName.Trim(),
                Specialization = dto.Specialization.Trim(),
                Phone = cleanPhone,
                Email = dto.Email?.Trim() ?? "",
                Certificate = dto.Certificate?.Trim() ?? "",
                Notes = dto.Notes?.Trim() ?? "",
                PreferredShifts = dto.PreferredShifts?.Trim() ?? "",
                AvailableDays = dto.AvailableDays?.Trim() ?? "",
                IsActive = dto.IsActive ? 1 : 0,
                dto.TeacherId
            });

        return rows > 0
            ? (true, "Đã cập nhật hồ sơ giáo viên thành công.")
            : (false, "Không tìm thấy giáo viên cần cập nhật.");
    }

    public async Task<(bool Success, string Message)> DeleteTeacherAsync(int teacherId)
    {
        using var conn = CreateConnection();

        int classCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Classes WHERE MainTeacherId = @Id;", new { Id = teacherId });
        if (classCnt > 0)
            return (false, $"Không thể xóa giáo viên đang phụ trách {classCnt} lớp học. Vui lòng chuyển sang trạng thái Tạm nghỉ.");

        int scheduleCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ClassSchedules WHERE TeacherId = @Id;", new { Id = teacherId });
        if (scheduleCnt > 0)
            return (false, $"Không thể xóa giáo viên đang có {scheduleCnt} buổi dạy trong lịch học. Vui lòng chuyển sang trạng thái Tạm nghỉ.");

        int userCnt = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Users WHERE TeacherId = @Id;", new { Id = teacherId });
        if (userCnt > 0)
            return (false, "Không thể xóa giáo viên đang liên kết với tài khoản đăng nhập. Vui lòng xóa tài khoản hoặc chuyển giáo viên sang Tạm nghỉ.");

        int rows = await conn.ExecuteAsync("DELETE FROM Teachers WHERE TeacherId = @Id;", new { Id = teacherId });
        return rows > 0
            ? (true, "Đã xóa hồ sơ giáo viên thành công.")
            : (false, "Không tìm thấy giáo viên cần xóa.");
    }
}
