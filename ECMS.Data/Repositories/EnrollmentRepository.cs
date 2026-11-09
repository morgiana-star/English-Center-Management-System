using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class EnrollmentRepository : BaseRepository, IEnrollmentRepository
{
    public async Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync()
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.TuitionFee,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                c.CurrentStudents,
                c.MaxStudents,
                c.Status
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.RoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')
            ORDER BY c.ClassId DESC;";

        return await conn.QueryAsync<ClassLookupDto>(sql);
    }

    public async Task<ClassLookupDto?> GetClassByIdAsync(int classId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.TuitionFee,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                c.CurrentStudents,
                c.MaxStudents,
                c.Status
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.RoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.ClassId = @ClassId;";

        return await conn.QuerySingleOrDefaultAsync<ClassLookupDto>(sql, new { ClassId = classId });
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        using var conn = CreateConnection();
        string yearPrefix = $"HV-{DateTime.Now.Year}-";
        const string sql = "SELECT StudentCode FROM Students WHERE StudentCode LIKE @Pattern ORDER BY StudentId DESC LIMIT 1;";
        string? latestCode = await conn.ExecuteScalarAsync<string>(sql, new { Pattern = yearPrefix + "%" });

        int nextNumber = 1;
        if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Length >= 11)
        {
            string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
            if (int.TryParse(numberPart, out int currentNum))
            {
                nextNumber = currentNum + 1;
            }
        }

        return $"{yearPrefix}{nextNumber:D4}";
    }

    public async Task<int?> FindStudentIdByPhoneAsync(string phone)
    {
        using var conn = CreateConnection();
        const string sql = "SELECT StudentId FROM Students WHERE Phone = @Phone LIMIT 1;";
        return await conn.ExecuteScalarAsync<int?>(sql, new { Phone = phone.Trim() });
    }

    public async Task<bool> CheckStudentEnrolledAsync(int studentId, int classId)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT COUNT(*) 
            FROM Enrollments 
            WHERE StudentId = @StudentId 
              AND ClassId = @ClassId 
              AND Status NOT IN ('Dropped');";
        int count = await conn.ExecuteScalarAsync<int>(sql, new { StudentId = studentId, ClassId = classId });
        return count > 0;
    }

    public async Task<(bool Success, string Message, int StudentId, int EnrollmentId)> ExecuteEnrollmentTransactionAsync(StudentEnrollmentDto dto, string studentCode)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            int studentId = dto.StudentId;

            // 1. Nếu chưa có StudentId -> Tạo mới hồ sơ Học viên
            if (studentId <= 0)
            {
                const string insertStudentSql = @"
                    INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, LeadId, CreatedAt)
                    VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, 'Active', @LeadId, CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();";

                studentId = await conn.ExecuteScalarAsync<int>(insertStudentSql, new
                {
                    StudentCode = studentCode,
                    dto.FullName,
                    DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                    dto.Gender,
                    dto.Phone,
                    dto.Email,
                    dto.Address,
                    dto.LeadId
                }, tran);
            }

            // 2. Lấy học phí gốc của Khóa học mà Lớp thuộc về
            const string getFeeSql = @"
                SELECT co.TuitionFee 
                FROM Classes c 
                JOIN Courses co ON c.CourseId = co.CourseId 
                WHERE c.ClassId = @ClassId;";
            decimal tuitionFee = await conn.ExecuteScalarAsync<decimal>(getFeeSql, new { dto.ClassId }, tran);

            // 3. Insert vào bảng Enrollments
            const string insertEnrollmentSql = @"
                INSERT INTO Enrollments (StudentId, ClassId, EnrollmentDate, Status, FinalFee, CreatedAt)
                VALUES (@StudentId, @ClassId, CURRENT_TIMESTAMP, 'Enrolled', @FinalFee, CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();";

            int enrollmentId = await conn.ExecuteScalarAsync<int>(insertEnrollmentSql, new
            {
                StudentId = studentId,
                dto.ClassId,
                FinalFee = tuitionFee
            }, tran);

            // 4. Tăng sĩ số hiện tại của Lớp học (CurrentStudents = CurrentStudents + 1)
            const string updateClassSql = "UPDATE Classes SET CurrentStudents = CurrentStudents + 1 WHERE ClassId = @ClassId;";
            await conn.ExecuteAsync(updateClassSql, new { dto.ClassId }, tran);

            // 5. Nếu chuyển đổi từ Lead -> Cập nhật Lead thành 'Converted'
            if (dto.LeadId.HasValue && dto.LeadId.Value > 0)
            {
                const string updateLeadSql = "UPDATE Leads SET Status = 'Converted', UpdatedAt = CURRENT_TIMESTAMP WHERE LeadId = @LeadId;";
                await conn.ExecuteAsync(updateLeadSql, new { LeadId = dto.LeadId.Value }, tran);
            }

            tran.Commit();
            return (true, "Đăng ký xếp lớp thành công!", studentId, enrollmentId);
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi giao dịch xếp lớp: " + ex.Message, 0, 0);
        }
    }

    public async Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50)
    {
        using var conn = CreateConnection();
        const string sql = @"
            SELECT 
                e.EnrollmentId,
                e.StudentId,
                s.StudentCode,
                s.FullName AS StudentName,
                s.Phone,
                c.ClassId,
                c.ClassName,
                co.CourseName,
                e.FinalFee,
                e.EnrollmentDate,
                e.Status
            FROM Enrollments e
            JOIN Students s ON e.StudentId = s.StudentId
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            ORDER BY e.EnrollmentId DESC
            LIMIT @Limit;";

        return await conn.QueryAsync<EnrollmentListItemDto>(sql, new { Limit = limit });
    }
}
