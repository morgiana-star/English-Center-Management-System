using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public class StudentRepository : BaseRepository, IStudentRepository
{
    public Task EnsureStudentSeedDataAsync()
    {
        return Task.CompletedTask;
    }

    public async Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        string sql = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName,
                COALESCE(s.Phone, '') AS Phone,
                c.ClassId,
                COALESCE(c.ClassCode, 'Chờ xếp lớp') AS ClassName,
                CASE 
                    WHEN (SELECT COUNT(*) FROM AttendanceRecords ar WHERE ar.StudentId = s.StudentId) > 0 THEN
                        ROUND(
                            (SELECT COUNT(*) FROM AttendanceRecords ar WHERE ar.StudentId = s.StudentId AND ar.Status IN ('Present', 'Late')) * 100.0
                            / (SELECT COUNT(*) FROM AttendanceRecords ar WHERE ar.StudentId = s.StudentId),
                        1)
                    ELSE NULL
                END AS AttendanceRate,
                CAST(COALESCE((SELECT SUM(inv.BalanceDue) FROM Invoices inv INNER JOIN Enrollments e3 ON inv.EnrollmentId = e3.EnrollmentId WHERE e3.StudentId = s.StudentId AND inv.Status != 'Cancelled'), 0.0) AS REAL) AS DebtAmount,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Completed' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    WHEN s.Status = 'Dropped' THEN 'Đã lưu trữ'
                    ELSE 'Đang học'
                END AS Status
            FROM Students s
            LEFT JOIN Enrollments e ON e.EnrollmentId = (
                SELECT e2.EnrollmentId FROM Enrollments e2
                WHERE e2.StudentId = s.StudentId
                ORDER BY e2.EnrollmentId DESC LIMIT 1
            )
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            WHERE 1=1
        ";

        var p = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            sql += " AND (s.FullName LIKE @Pattern OR s.StudentCode LIKE @Pattern OR COALESCE(s.Phone, '') LIKE @Pattern)";
            p.Add("Pattern", "%" + keyword.Trim() + "%");
        }

        if (string.Equals(status, "Archived", StringComparison.OrdinalIgnoreCase))
        {
            sql += " AND s.Status IN ('Reserved', 'Dropped')";
        }
        else if (!string.IsNullOrWhiteSpace(status) && status != "Tất cả trạng thái")
        {
            if (status == "Đang học") sql += " AND s.Status = 'Active'";
            else if (status == "Hoàn thành") sql += " AND s.Status = 'Completed'";
            else if (status == "Đã lưu trữ" || status == "Bảo lưu") sql += " AND s.Status IN ('Reserved', 'Dropped')";
        }
        else
        {
            // Danh sách chính chỉ hiển thị học viên chưa đưa vào lưu trữ
            sql += " AND s.Status IN ('Active', 'Completed')";
        }

        if (classId.HasValue)
        {
            if (classId.Value == -1)
            {
                sql += " AND c.ClassId IS NULL";
            }
            else if (classId.Value > 0)
            {
                sql += " AND c.ClassId = @ClassId";
                p.Add("ClassId", classId.Value);
            }
        }

        sql += " ORDER BY s.StudentId DESC;";

        return await conn.QueryAsync<StudentListItemDto>(sql, p);
    }

    public async Task<IEnumerable<ClassFilterItemDto>> GetClassesForFilterAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        const string sql = @"
            SELECT ClassId, ClassCode, ClassName
            FROM Classes
            WHERE Status != 'Cancelled'
            ORDER BY ClassId DESC;";
        return await conn.QueryAsync<ClassFilterItemDto>(sql);
    }

    public async Task<StudentDetailDto?> GetStudentDetailByIdAsync(int studentId)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        const string sqlStudent = @"
            SELECT 
                s.StudentId,
                s.StudentCode,
                s.FullName,
                COALESCE(s.Phone, '') AS Phone,
                s.Email,
                s.Address,
                s.DateOfBirth,
                s.Gender,
                CASE 
                    WHEN s.Status = 'Active' THEN 'Đang học'
                    WHEN s.Status = 'Completed' THEN 'Hoàn thành'
                    WHEN s.Status = 'Reserved' THEN 'Bảo lưu'
                    ELSE 'Đã lưu trữ'
                END AS StatusText,
                COALESCE(p.FullName, '') AS ParentFullName,
                COALESCE(p.Phone, '') AS ParentPhone,
                COALESCE(p.Email, '') AS ParentEmail,
                COALESCE(sp.RelationshipType, 'Bố') AS ParentRelationship,
                COALESCE(e.EnrollmentId, 0) AS EnrollmentId,
                COALESCE(e.ClassId, 0) AS ClassId,
                COALESCE(c.ClassCode, 'Chưa xếp lớp') AS CurrentClassName,
                COALESCE(co.CourseName, 'Chưa đăng ký') AS CourseName,
                COALESCE(co.TotalSessions, 24) AS TotalSessions,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                e.AttendanceRate,
                CAST(COALESCE(inv.BalanceDue, 0.0) AS REAL) AS RemainingTuition,
                inv.DueDate AS DueDateRaw
            FROM Students s
            LEFT JOIN StudentParents sp ON s.StudentId = sp.StudentId AND sp.IsPrimaryContact = 1
            LEFT JOIN Parents p ON sp.ParentId = p.ParentId
            LEFT JOIN Enrollments e ON e.EnrollmentId = (
                SELECT e2.EnrollmentId FROM Enrollments e2 WHERE e2.StudentId = s.StudentId ORDER BY e2.EnrollmentId DESC LIMIT 1
            )
            LEFT JOIN Classes c ON e.ClassId = c.ClassId
            LEFT JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            WHERE s.StudentId = @StudentId LIMIT 1;
        ";

        var raw = await conn.QuerySingleOrDefaultAsync<dynamic>(sqlStudent, new { StudentId = studentId });
        if (raw == null) return null;

        int currentClassId = (int)(raw.ClassId ?? 0);
        int totalSessions = (int)(raw.TotalSessions ?? 24);

        // Truy vấn lịch học thật của lớp từ ClassSchedules
        string scheduleDisplay = "Chưa xếp lịch";
        if (currentClassId > 0)
        {
            var sch = await conn.QueryFirstOrDefaultAsync<(string Date, string StartTime, string EndTime)?>(
                "SELECT Date, StartTime, EndTime FROM ClassSchedules WHERE ClassId = @ClassId ORDER BY Date DESC LIMIT 1;",
                new { ClassId = currentClassId });
            if (sch.HasValue)
            {
                scheduleDisplay = $"{sch.Value.StartTime}–{sch.Value.EndTime}";
            }
        }

        // Truy vấn số buổi điểm danh thật từ AttendanceRecords của học viên
        var attStats = await conn.QuerySingleOrDefaultAsync<(int PresentCnt, int LateCnt, int AbsentCnt)>(@"
            SELECT 
                COALESCE(SUM(CASE WHEN ar.Status = 'Present' THEN 1 ELSE 0 END), 0) AS PresentCnt,
                COALESCE(SUM(CASE WHEN ar.Status = 'Late' THEN 1 ELSE 0 END), 0) AS LateCnt,
                COALESCE(SUM(CASE WHEN ar.Status IN ('Absent', 'Excused') THEN 1 ELSE 0 END), 0) AS AbsentCnt
            FROM AttendanceRecords ar
            LEFT JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId
            WHERE ar.StudentId = @StudentId
              AND (@ClassId = 0 OR cs.ClassId = @ClassId);",
            new { StudentId = studentId, ClassId = currentClassId });

        int totalRecorded = attStats.PresentCnt + attStats.LateCnt + attStats.AbsentCnt;
        double attRate = totalRecorded > 0
            ? Math.Round((attStats.PresentCnt + attStats.LateCnt) * 100.0 / totalRecorded, 1)
            : 0.0;

        // Truy vấn điểm thật từ bảng ExamScores JOIN Exams
        var scoreRows = (await conn.QueryAsync<(string Type, double ScoreValue)>(@"
            SELECT ex.Type, es.ScoreValue
            FROM ExamScores es
            JOIN Exams ex ON es.ExamId = ex.ExamId
            WHERE es.StudentId = @StudentId
              AND (@ClassId = 0 OR ex.ClassId = @ClassId OR ex.Type = 'Placement');",
            new { StudentId = studentId, ClassId = currentClassId })).ToList();

        string FormatScore(string type)
        {
            var matched = scoreRows.FirstOrDefault(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
            return matched != default ? $"{matched.ScoreValue:0.0}" : "Chưa có điểm";
        }

        var dto = new StudentDetailDto
        {
            StudentId = (int)raw.StudentId,
            StudentCode = raw.StudentCode ?? "",
            FullName = raw.FullName ?? "",
            Phone = raw.Phone ?? "",
            Email = raw.Email,
            Address = raw.Address,
            Gender = raw.Gender ?? "Nam",
            StatusText = raw.StatusText ?? "Đang học",
            ParentFullName = raw.ParentFullName ?? "",
            ParentPhone = raw.ParentPhone ?? "",
            ParentEmail = raw.ParentEmail ?? "",
            ParentRelationship = raw.ParentRelationship ?? "Bố",
            CurrentClassName = raw.CurrentClassName ?? "Chờ xếp lớp",
            CourseName = raw.CourseName ?? "Chưa đăng ký",
            TeacherName = raw.TeacherName ?? "Chưa phân công",
            RoomName = raw.RoomName ?? "Chưa xếp phòng",
            ScheduleDisplay = scheduleDisplay,
            RemainingTuition = (decimal)(raw.RemainingTuition ?? 0m),
            AttendanceRateDisplay = totalRecorded > 0 ? $"{attRate:F1}%" : "Chưa có",
            LessonsProgressDisplay = $"{totalRecorded} / {totalSessions}",
            ProgressDisplay = $"{totalRecorded} / {totalSessions} buổi",
            PresentCount = attStats.PresentCnt,
            LateCount = attStats.LateCnt,
            AbsentCount = attStats.AbsentCnt,
            EntranceScore = FormatScore("Placement"),
            RegularScore = FormatScore("Regular"),
            MidtermScore = FormatScore("Midterm"),
            FinalScore = FormatScore("Final")
        };

        if (DateTime.TryParse((string?)raw.DateOfBirth, out DateTime dob))
        {
            dto.DateOfBirth = dob;
        }

        if (dto.RemainingTuition > 0)
        {
            string dueDateStr = raw.DueDateRaw != null ? Convert.ToString(raw.DueDateRaw) : "30/12/2026";
            dto.TuitionDueDateDisplay = $"Hạn thanh toán: {dueDateStr}";
        }
        else
        {
            dto.TuitionDueDateDisplay = "Đã hoàn thành học phí";
        }

        // Tab 2: Truy vấn TẤT CẢ các Enrollment thật của học viên này trong DB
        const string sqlHistory = @"
            SELECT 
                e.EnrollmentId,
                e.ClassId,
                c.ClassCode,
                co.CourseName,
                co.TotalSessions,
                e.Status AS EnrollStatus,
                COALESCE(inv.BalanceDue, 0) AS BalanceDue,
                (SELECT COUNT(*) FROM AttendanceRecords ar JOIN ClassSchedules cs ON ar.ScheduleId = cs.ScheduleId WHERE ar.StudentId = e.StudentId AND cs.ClassId = e.ClassId) AS RecordedCount,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Regular' LIMIT 1) AS RegularVal,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Midterm' LIMIT 1) AS MidtermVal,
                (SELECT es.ScoreValue FROM ExamScores es JOIN Exams ex ON es.ExamId = ex.ExamId WHERE es.StudentId = e.StudentId AND ex.ClassId = e.ClassId AND ex.Type = 'Final' LIMIT 1) AS FinalVal
            FROM Enrollments e
            JOIN Classes c ON e.ClassId = c.ClassId
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId
            WHERE e.StudentId = @StudentId
            ORDER BY e.EnrollmentId DESC;";

        var historyRows = await conn.QueryAsync<dynamic>(sqlHistory, new { StudentId = studentId });
        foreach (var h in historyRows)
        {
            string enStatus = (string)(h.EnrollStatus ?? "Active");
            string statusVi = enStatus switch
            {
                "Completed" => "Hoàn thành",
                "Reserved" => "Bảo lưu",
                "Dropped" => "Đã nghỉ",
                "Transferred" => "Đã chuyển lớp",
                "PendingPayment" => "Chờ đóng phí",
                _ => "Đang học"
            };

            decimal bal = (decimal)(h.BalanceDue ?? 0m);
            int recCnt = (int)(h.RecordedCount ?? 0);
            int totSess = (int)(h.TotalSessions ?? 24);

            string regStr = h.RegularVal != null ? $"{Convert.ToDouble(h.RegularVal):0.0}" : "-";
            string midStr = h.MidtermVal != null ? $"{Convert.ToDouble(h.MidtermVal):0.0}" : "-";
            string finStr = h.FinalVal != null ? $"{Convert.ToDouble(h.FinalVal):0.0}" : "-";

            dto.LearningHistory.Add(new StudentLearningHistoryItemDto
            {
                ClassCourseName = $"{h.ClassCode} - {h.CourseName}",
                Status = statusVi,
                AttendanceProgress = recCnt > 0 ? $"{recCnt} / {totSess} buổi" : "Chưa điểm danh",
                RegularScore = regStr,
                MidtermScore = midStr,
                FinalScore = finStr,
                TuitionStatus = bal > 0 ? $"Còn nợ {bal:N0}đ" : "Đã hoàn thành"
            });
        }

        return dto;
    }

    public async Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode)
    {
        using var conn = CreateConnection();
        int? id = await conn.ExecuteScalarAsync<int?>("SELECT StudentId FROM Students WHERE StudentCode = @Code LIMIT 1;", new { Code = studentCode });
        if (id.HasValue) return await GetStudentDetailByIdAsync(id.Value);
        return null;
    }

    public async Task<bool> UpdateStudentProfileAsync(UpdateStudentProfileDto dto)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            string updateStudentSql = @"
                UPDATE Students SET 
                    FullName = @FullName,
                    DateOfBirth = @DobStr,
                    Gender = @Gender,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId;";

            await conn.ExecuteAsync(updateStudentSql, new
            {
                dto.FullName,
                DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                dto.Gender,
                dto.Phone,
                dto.Email,
                dto.Address,
                dto.StudentId
            }, tran);

            string rel = NormalizeRelationship(dto.ParentRelationship);
            if (!string.IsNullOrWhiteSpace(dto.ParentFullName))
            {
                int? parentId = await conn.ExecuteScalarAsync<int?>(
                    "SELECT ParentId FROM StudentParents WHERE StudentId = @StudentId AND IsPrimaryContact = 1 LIMIT 1;",
                    new { dto.StudentId }, tran);

                if (parentId.HasValue)
                {
                    await conn.ExecuteAsync(@"
                        UPDATE Parents SET
                            FullName = @ParentFullName,
                            Phone = @ParentPhone,
                            UpdatedAt = CURRENT_TIMESTAMP
                        WHERE ParentId = @ParentId;",
                        new { dto.ParentFullName, dto.ParentPhone, ParentId = parentId.Value }, tran);

                    await conn.ExecuteAsync(@"
                        UPDATE StudentParents SET
                            RelationshipType = @Rel
                        WHERE StudentId = @StudentId AND ParentId = @ParentId;",
                        new { Rel = rel, dto.StudentId, ParentId = parentId.Value }, tran);
                }
                else
                {
                    int newPid = await conn.ExecuteScalarAsync<int>(@"
                        INSERT INTO Parents (ParentCode, FullName, Phone, CreatedAt)
                        VALUES (@PCode, @ParentFullName, @ParentPhone, CURRENT_TIMESTAMP);
                        SELECT last_insert_rowid();",
                        new { PCode = $"PH-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}", dto.ParentFullName, dto.ParentPhone }, tran);

                    await conn.ExecuteAsync(@"
                        INSERT INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                        VALUES (@StudentId, @newPid, @Rel, 1);",
                        new { dto.StudentId, newPid, Rel = rel }, tran);
                }
            }

            tran.Commit();
            return true;
        }
        catch
        {
            tran.Rollback();
            return false;
        }
    }

    public async Task<decimal> GetStudentOutstandingDebtAsync(int studentId)
    {
        using var conn = CreateConnection();
        return await conn.ExecuteScalarAsync<decimal>(@"
            SELECT COALESCE(SUM(inv.BalanceDue), 0)
            FROM Invoices inv
            INNER JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            WHERE e.StudentId = @StudentId AND inv.Status != 'Cancelled';",
            new { StudentId = studentId });
    }

    public async Task<bool> ArchiveStudentAsync(ArchiveStudentDto dto)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            string newStatus = dto.Reason.Contains("Bảo lưu", StringComparison.OrdinalIgnoreCase) ? "Reserved" : "Dropped";
            int rows = await conn.ExecuteAsync(@"
                UPDATE Students SET 
                    Status = @NewStatus,
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId;",
                new { NewStatus = newStatus, dto.StudentId }, tran);

            await conn.ExecuteAsync(@"
                UPDATE Enrollments SET 
                    Status = @NewStatus,
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId AND Status IN ('Active', 'PendingPayment');",
                new { NewStatus = newStatus, dto.StudentId }, tran);

            if (rows > 0)
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                    VALUES ('ARCHIVE_STUDENT', 'Students', @RecordId, @ReasonNote, CURRENT_TIMESTAMP);",
                    new { RecordId = dto.StudentId.ToString(), ReasonNote = $"{dto.Reason} - {dto.Notes}" }, tran);
            }

            tran.Commit();
            return rows > 0;
        }
        catch
        {
            tran.Rollback();
            return false;
        }
    }

    public async Task<(bool Success, string Message)> RestoreStudentAsync(int studentId)
    {
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            int rows = await conn.ExecuteAsync(@"
                UPDATE Students SET 
                    Status = 'Active',
                    UpdatedAt = CURRENT_TIMESTAMP
                WHERE StudentId = @StudentId;", new { StudentId = studentId }, tran);

            if (rows == 0)
            {
                tran.Rollback();
                return (false, "Không tìm thấy hồ sơ học viên cần khôi phục.");
            }

            var latestEnroll = await conn.QueryFirstOrDefaultAsync<(int EnrollmentId, int ClassId, string ClassCode, string ClassStatus, int MaxStudents, int CurrentStudents)?>(@"
                SELECT 
                    e.EnrollmentId,
                    e.ClassId,
                    c.ClassCode,
                    c.Status AS ClassStatus,
                    c.MaxStudents,
                    (SELECT COUNT(*) FROM Enrollments e2 WHERE e2.ClassId = c.ClassId AND e2.Status IN ('Active', 'PendingPayment')) AS CurrentStudents
                FROM Enrollments e
                JOIN Classes c ON e.ClassId = c.ClassId
                WHERE e.StudentId = @StudentId AND e.Status IN ('Reserved', 'Dropped')
                ORDER BY e.EnrollmentId DESC
                LIMIT 1;", new { StudentId = studentId }, tran);

            string restoreMessage = "Đã khôi phục học viên về trạng thái Chờ xếp lớp.";
            if (latestEnroll.HasValue)
            {
                var le = latestEnroll.Value;
                bool classClosed = le.ClassStatus == "Completed" || le.ClassStatus == "Cancelled";
                bool classFull = le.CurrentStudents >= le.MaxStudents;

                if (!classClosed && !classFull)
                {
                    await conn.ExecuteAsync(@"
                        UPDATE Enrollments SET 
                            Status = 'Active',
                            UpdatedAt = CURRENT_TIMESTAMP
                        WHERE EnrollmentId = @EnrollmentId;",
                        new { le.EnrollmentId }, tran);
                    restoreMessage = $"Đã khôi phục học viên và đưa trở lại lớp {le.ClassCode}.";
                }
                else
                {
                    string reason = classClosed ? $"lớp cũ ({le.ClassCode}) đã kết thúc hoặc bị hủy" : $"lớp cũ ({le.ClassCode}) đã đủ sĩ số";
                    restoreMessage = $"Đã khôi phục hồ sơ học viên ở trạng thái Chờ xếp lớp (do {reason}). Vui lòng xếp vào lớp mới.";
                }
            }

            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES ('RESTORE_STUDENT', 'Students', @RecordId, @Msg, CURRENT_TIMESTAMP);",
                new { RecordId = studentId.ToString(), Msg = restoreMessage }, tran);

            tran.Commit();
            return (true, restoreMessage);
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi khôi phục hồ sơ học viên: " + ex.Message);
        }
    }

    public async Task<(bool Success, string Message)> DeleteStudentWithChecksAsync(int studentId)
    {
        using var conn = CreateConnection();

        int paymentCount = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM Payments p
            INNER JOIN Invoices inv ON p.InvoiceId = inv.InvoiceId
            INNER JOIN Enrollments e ON inv.EnrollmentId = e.EnrollmentId
            WHERE e.StudentId = @Id AND p.Status = 'Valid';", new { Id = studentId });
        if (paymentCount > 0)
            return (false, "Không thể xóa học viên đã phát sinh phiếu thu học phí. Vui lòng sử dụng chức năng Lưu trữ.");

        int attendanceCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM AttendanceRecords WHERE StudentId = @Id;", new { Id = studentId });
        if (attendanceCount > 0)
            return (false, "Không thể xóa học viên đã có dữ liệu điểm danh. Vui lòng sử dụng chức năng Lưu trữ.");

        int examCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM ExamScores WHERE StudentId = @Id;", new { Id = studentId });
        if (examCount > 0)
            return (false, "Không thể xóa học viên đã có điểm kiểm tra / thi. Vui lòng sử dụng chức năng Lưu trữ.");

        int certCount = await conn.ExecuteScalarAsync<int>(
            "SELECT COUNT(*) FROM Certificates WHERE StudentId = @Id;", new { Id = studentId });
        if (certCount > 0)
            return (false, "Không thể xóa học viên đã được cấp chứng chỉ. Vui lòng sử dụng chức năng Lưu trữ.");

        using var tran = conn.BeginTransaction();
        try
        {
            await conn.ExecuteAsync(@"
                DELETE FROM Invoices WHERE EnrollmentId IN (SELECT EnrollmentId FROM Enrollments WHERE StudentId = @Id);",
                new { Id = studentId }, tran);
            await conn.ExecuteAsync("DELETE FROM Enrollments WHERE StudentId = @Id;", new { Id = studentId }, tran);
            await conn.ExecuteAsync("DELETE FROM StudentParents WHERE StudentId = @Id;", new { Id = studentId }, tran);
            try { await conn.ExecuteAsync("DELETE FROM AbsenceAlertStates WHERE StudentId = @Id;", new { Id = studentId }, tran); } catch { }
            await conn.ExecuteAsync("DELETE FROM Users WHERE StudentId = @Id;", new { Id = studentId }, tran);
            int deleted = await conn.ExecuteAsync("DELETE FROM Students WHERE StudentId = @Id;", new { Id = studentId }, tran);

            if (deleted > 0)
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                    VALUES ('DELETE_STUDENT', 'Students', @RecordId, 'Xóa vĩnh viễn hồ sơ học viên chưa phát sinh dữ liệu ràng buộc', CURRENT_TIMESTAMP);",
                    new { RecordId = studentId.ToString() }, tran);
            }

            tran.Commit();
            return deleted > 0
                ? (true, "Đã xóa hồ sơ học viên khỏi hệ thống thành công.")
                : (false, "Không tìm thấy học viên cần xóa.");
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi khi xóa hồ sơ học viên: " + ex.Message);
        }
    }

    public async Task<(bool IsDuplicate, string Reason)> CheckDuplicateStudentAsync(string phone, string fullName, DateTime dateOfBirth, int excludeStudentId = 0)
    {
        using var conn = CreateConnection();
        string cleanPhone = (phone ?? "").Replace(" ", "").Trim();
        if (!string.IsNullOrWhiteSpace(cleanPhone))
        {
            var existingByPhone = await conn.QueryFirstOrDefaultAsync<(string StudentCode, string FullName)?>(@"
                SELECT StudentCode, FullName FROM Students
                WHERE REPLACE(COALESCE(Phone, ''), ' ', '') = @Phone
                  AND StudentId != @ExcludeId
                LIMIT 1;", new { Phone = cleanPhone, ExcludeId = excludeStudentId });

            if (existingByPhone.HasValue)
            {
                return (true, $"Số điện thoại '{phone}' đã được sử dụng bởi học viên {existingByPhone.Value.FullName} ({existingByPhone.Value.StudentCode}).");
            }
        }

        return (false, string.Empty);
    }

    public async Task<(bool Success, string Message, int StudentId, string StudentCode)> CreateWaitingStudentAsync(StudentEnrollmentWithTuitionDto dto)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();
        try
        {
            string studentCode = !string.IsNullOrWhiteSpace(dto.StudentCode)
                ? dto.StudentCode
                : await GenerateNextStudentCodeAsync();

            int studentId = await conn.ExecuteScalarAsync<int>(@"
                INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, 'Active', CURRENT_TIMESTAMP);
                SELECT last_insert_rowid();",
                new
                {
                    StudentCode = studentCode,
                    dto.FullName,
                    DobStr = dto.DateOfBirth.ToString("yyyy-MM-dd"),
                    dto.Gender,
                    dto.Phone,
                    dto.Email,
                    dto.Address
                }, tran);

            if (!string.IsNullOrWhiteSpace(dto.ParentFullName))
            {
                int parentId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                    VALUES (@ParentCode, @ParentFullName, @ParentPhone, '', CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new
                    {
                        ParentCode = $"PH-{studentCode.Replace("HV-", "")}",
                        dto.ParentFullName,
                        dto.ParentPhone
                    }, tran);

                string normalizedRel = NormalizeRelationship(dto.ParentRelationship);
                await conn.ExecuteAsync(@"
                    INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                    VALUES (@StudentId, @ParentId, @Rel, 1);",
                    new { StudentId = studentId, ParentId = parentId, Rel = normalizedRel }, tran);
            }

            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES ('CREATE_WAITING_STUDENT', 'Students', @RecordId, @Note, CURRENT_TIMESTAMP);",
                new { RecordId = studentId.ToString(), Note = $"Thêm học viên {dto.FullName} ({studentCode}) ở trạng thái Chờ xếp lớp" }, tran);

            tran.Commit();
            return (true, "Đã lưu hồ sơ học viên ở trạng thái Chờ xếp lớp.", studentId, studentCode);
        }
        catch (Exception ex)
        {
            tran.Rollback();
            return (false, "Lỗi lưu hồ sơ học viên: " + ex.Message, 0, string.Empty);
        }
    }

    public async Task<StudentOverviewStatsDto> GetStudentStatsAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        int total = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
        int studying = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM Students s
            WHERE s.Status = 'Active'
              AND EXISTS (SELECT 1 FROM Enrollments e WHERE e.StudentId = s.StudentId AND e.Status IN ('Active', 'PendingPayment'));");
        int waitingClass = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(*) FROM Students s
            WHERE s.Status = 'Active'
              AND NOT EXISTS (SELECT 1 FROM Enrollments e WHERE e.StudentId = s.StudentId AND e.Status IN ('Active', 'PendingPayment'));");
        int completed = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status = 'Completed';");
        int archived = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students WHERE Status IN ('Reserved', 'Dropped');");
        int debt = await conn.ExecuteScalarAsync<int>(@"
            SELECT COUNT(DISTINCT s.StudentId) 
            FROM Students s 
            JOIN Enrollments e ON s.StudentId = e.StudentId 
            JOIN Invoices inv ON e.EnrollmentId = inv.EnrollmentId 
            WHERE inv.BalanceDue > 0 AND inv.Status != 'Cancelled';");

        return new StudentOverviewStatsDto
        {
            TotalStudents = total,
            StudyingStudents = studying,
            WaitingClassStudents = waitingClass,
            CompletedStudents = completed,
            ArchivedStudents = archived,
            DebtStudents = debt
        };
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        using var conn = CreateConnection();
        string? latestCode = await conn.ExecuteScalarAsync<string>(
            "SELECT StudentCode FROM Students WHERE StudentCode LIKE 'HV-%' ORDER BY StudentId DESC LIMIT 1;");

        int nextNumber = 1;
        if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
        {
            string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
            if (int.TryParse(numberPart, out int currentNum))
            {
                nextNumber = currentNum + 1;
            }
        }
        return $"HV-{nextNumber:D4}";
    }

    public async Task<IEnumerable<CourseLookupDto>> GetActiveCoursesForEnrollmentAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        return await conn.QueryAsync<CourseLookupDto>(@"
            SELECT CourseId, CourseCode, CourseName, Level, TotalSessions, BaseTuitionFee
            FROM Courses
            WHERE IsActive = 1
            ORDER BY CourseId ASC;");
    }

    public async Task<IEnumerable<OpenClassOptionDto>> GetOpenClassesByCourseAsync(int courseId)
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();

        const string sql = @"
            SELECT 
                c.ClassId,
                c.ClassCode,
                c.ClassName,
                c.CourseId,
                co.CourseName,
                co.BaseTuitionFee AS TuitionFee,
                c.StartDate,
                c.EndDate,
                COALESCE(cr.RoomName, 'Chưa xếp phòng') AS RoomName,
                COALESCE(t.FullName, 'Chưa phân công') AS TeacherName,
                (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId = c.ClassId AND e.Status IN ('Active', 'PendingPayment')) AS CurrentStudents,
                c.MaxStudents,
                COALESCE((SELECT cs.StartTime || ' - ' || cs.EndTime FROM ClassSchedules cs WHERE cs.ClassId = c.ClassId ORDER BY cs.Date DESC LIMIT 1), '18:00 - 20:00') AS TimeRange,
                COALESCE((SELECT cs.StartTime FROM ClassSchedules cs WHERE cs.ClassId = c.ClassId ORDER BY cs.Date DESC LIMIT 1), '18:00') AS StartTime
            FROM Classes c
            JOIN Courses co ON c.CourseId = co.CourseId
            LEFT JOIN ClassRooms cr ON c.DefaultRoomId = cr.RoomId
            LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
            WHERE c.CourseId = @CourseId
              AND c.Status IN ('Planning', 'OpenForEnrollment', 'InProgress')
            ORDER BY c.StartDate ASC;";

        var rows = await conn.QueryAsync<dynamic>(sql, new { CourseId = courseId });
        var result = new List<OpenClassOptionDto>();
        foreach (var r in rows)
        {
            string startRaw = r.StartDate ?? "";
            string startDisplay = DateTime.TryParse(startRaw, out DateTime dtStart) ? dtStart.ToString("dd/MM/yyyy") : startRaw;
            string endRaw = r.EndDate ?? "";
            string endDisplay = DateTime.TryParse(endRaw, out DateTime dtEnd) ? dtEnd.ToString("dd/MM/yyyy") : (string.IsNullOrWhiteSpace(endRaw) ? "-" : endRaw);

            result.Add(new OpenClassOptionDto
            {
                ClassId = (int)r.ClassId,
                ClassCode = r.ClassCode ?? "",
                ClassName = r.ClassName ?? "",
                CourseId = (int)r.CourseId,
                CourseName = r.CourseName ?? "",
                TuitionFee = (decimal)(r.TuitionFee ?? 0m),
                StartDateDisplay = startDisplay,
                EndDateDisplay = endDisplay,
                ScheduleDisplay = r.TimeRange ?? "18:00 - 20:00",
                StartTime = r.StartTime ?? "18:00",
                RoomName = r.RoomName ?? "P201",
                TeacherName = r.TeacherName ?? "Chưa phân công",
                CurrentStudents = (int)(r.CurrentStudents ?? 0),
                MaxStudents = (int)(r.MaxStudents ?? 20)
            });
        }
        return result;
    }

    public async Task<HashSet<string>> GetExistingStudentPhonesAsync()
    {
        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        var phones = await conn.QueryAsync<string>("SELECT Phone FROM Students WHERE Phone IS NOT NULL AND Phone != '';");
        return new HashSet<string>(phones, StringComparer.OrdinalIgnoreCase);
    }

    public async Task<StudentImportResultDto> ImportStudentsBatchAsync(List<StudentImportRowDto> validStudents)
    {
        var result = new StudentImportResultDto
        {
            TotalRows = validStudents.Count
        };

        if (validStudents.Count == 0) return result;

        await EnsureStudentSeedDataAsync();
        using var conn = CreateConnection();
        using var tran = conn.BeginTransaction();

        try
        {
            string? latestCode = await conn.ExecuteScalarAsync<string>(
                "SELECT StudentCode FROM Students WHERE StudentCode LIKE 'HV-%' ORDER BY StudentId DESC LIMIT 1;",
                transaction: tran);

            int nextNum = 1;
            if (!string.IsNullOrWhiteSpace(latestCode) && latestCode.Contains('-'))
            {
                string numberPart = latestCode.Substring(latestCode.LastIndexOf('-') + 1);
                if (int.TryParse(numberPart, out int currentNum))
                {
                    nextNum = currentNum + 1;
                }
            }

            foreach (var s in validStudents)
            {
                string studentCode = $"HV-{nextNum:D4}";
                nextNum++;

                string gender = string.Equals(s.Gender?.Trim(), "Nữ", StringComparison.OrdinalIgnoreCase) ? "Nữ" : "Nam";
                string dobStr = s.DateOfBirth?.ToString("yyyy-MM-dd") ?? DateTime.Today.AddYears(-18).ToString("yyyy-MM-dd");

                int studentId = await conn.ExecuteScalarAsync<int>(@"
                    INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status, CreatedAt)
                    VALUES (@Code, @FullName, @Dob, @Gender, @Phone, @Email, @Address, 'Active', CURRENT_TIMESTAMP);
                    SELECT last_insert_rowid();",
                    new
                    {
                        Code = studentCode,
                        FullName = s.FullName.Trim(),
                        Dob = dobStr,
                        Gender = gender,
                        Phone = s.Phone?.Trim() ?? "",
                        Email = s.Email?.Trim() ?? "",
                        Address = s.Address?.Trim() ?? ""
                    }, tran);

                if (!string.IsNullOrWhiteSpace(s.ParentName) || !string.IsNullOrWhiteSpace(s.ParentPhone))
                {
                    string parentCode = $"PH-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}";
                    int parentId = await conn.ExecuteScalarAsync<int>(@"
                        INSERT INTO Parents (ParentCode, FullName, Phone, Email, CreatedAt)
                        VALUES (@PCode, @PName, @PPhone, '', CURRENT_TIMESTAMP);
                        SELECT last_insert_rowid();",
                        new
                        {
                            PCode = parentCode,
                            PName = string.IsNullOrWhiteSpace(s.ParentName) ? "Phụ huynh" : s.ParentName.Trim(),
                            PPhone = s.ParentPhone?.Trim() ?? ""
                        }, tran);

                    string rel = NormalizeRelationship(s.ParentRelationship);
                    await conn.ExecuteAsync(@"
                        INSERT OR IGNORE INTO StudentParents (StudentId, ParentId, RelationshipType, IsPrimaryContact)
                        VALUES (@StudentId, @ParentId, @Rel, 1);",
                        new { StudentId = studentId, ParentId = parentId, Rel = rel }, tran);
                }

                result.InsertedStudentCodes.Add(studentCode);
                result.SuccessCount++;
            }

            // Ghi AuditLog
            await conn.ExecuteAsync(@"
                INSERT INTO AuditLogs (ActionName, TableName, RecordId, NewValues, Timestamp)
                VALUES ('IMPORT_STUDENTS_EXCEL', 'Students', @Count, @Desc, CURRENT_TIMESTAMP);",
                new
                {
                    Count = result.SuccessCount.ToString(),
                    Desc = $"Nhập thành công {result.SuccessCount} học viên mới từ tệp Excel/CSV"
                }, tran);

            tran.Commit();
        }
        catch (Exception ex)
        {
            tran.Rollback();
            result.ErrorCount = validStudents.Count;
            result.SuccessCount = 0;
            result.InsertedStudentCodes.Clear();
            result.ErrorMessages.Add($"Lỗi ghi dữ liệu SQLite: {ex.Message}");
        }

        return result;
    }

    private static string NormalizeRelationship(string? raw)
    {
        if (string.IsNullOrWhiteSpace(raw)) return "Khác";
        if (raw.Contains("Bố", StringComparison.OrdinalIgnoreCase)) return "Bố";
        if (raw.Contains("Mẹ", StringComparison.OrdinalIgnoreCase)) return "Mẹ";
        if (raw.Contains("Giám hộ", StringComparison.OrdinalIgnoreCase)) return "Giám hộ";
        return "Khác";
    }
}
