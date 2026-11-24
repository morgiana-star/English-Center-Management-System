using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.Data.Database;
using ECMS.Data.Repositories;
using Dapper;

namespace ECMS.Business.Services;

public interface IStudentService
{
    // 1. Nghiệp vụ DTO theo kiến trúc 4 tầng
    Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null);
    Task<IEnumerable<ClassFilterItemDto>> GetClassesForFilterAsync();
    Task<StudentDetailDto?> GetStudentDetailAsync(int studentId);
    Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode);
    Task<(bool Success, string Message)> UpdateStudentProfileAsync(UpdateStudentProfileDto dto);
    Task<decimal> GetStudentOutstandingDebtAsync(int studentId);
    Task<(bool Success, string Message)> ArchiveStudentAsync(ArchiveStudentDto dto);
    Task<(bool Success, string Message)> RestoreStudentAsync(int studentId);
    Task<(bool IsDuplicate, string Reason)> CheckDuplicateStudentAsync(string phone, string fullName, DateTime dateOfBirth, int excludeStudentId = 0);
    Task<(bool Success, string Message, int StudentId, string StudentCode)> CreateWaitingStudentAsync(StudentEnrollmentWithTuitionDto dto);
    Task<StudentOverviewStatsDto> GetStudentStatsAsync();
    Task<string> GenerateNextStudentCodeAsync();
    Task<IEnumerable<CourseLookupDto>> GetActiveCoursesForEnrollmentAsync();
    Task<IEnumerable<OpenClassOptionDto>> GetOpenClassesByCourseAsync(int courseId);
    byte[] GenerateStudentImportTemplate();
    Task<List<StudentImportRowDto>> ParseAndValidateStudentFileAsync(Stream fileStream, string fileName);
    Task<StudentImportResultDto> ExecuteImportStudentsAsync(List<StudentImportRowDto> items);

    // 2. Nghiệp vụ Entity tương thích ngược
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task<IEnumerable<Student>> SearchStudentsAsync(string keyword);
    Task<Student?> GetStudentByIdAsync(int studentId);
    Task<int> CreateStudentAsync(Student student);
    Task<bool> UpdateStudentAsync(Student student);
    Task<(bool Success, string Message)> DeleteStudentAsync(int studentId);
}

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepo;

    public StudentService(IStudentRepository? studentRepo = null)
    {
        _studentRepo = studentRepo ?? new StudentRepository();
    }

    #region Nghiệp vụ DTO (Tầng Business 4 lớp)

    public async Task<IEnumerable<StudentListItemDto>> GetStudentListAsync(string? keyword = null, string? status = null, int? classId = null)
    {
        string? cleanKw = !string.IsNullOrWhiteSpace(keyword) ? keyword.Trim() : null;
        return await _studentRepo.GetStudentListAsync(cleanKw, status, classId);
    }

    public async Task<StudentDetailDto?> GetStudentDetailAsync(int studentId)
    {
        if (studentId <= 0) return null;
        return await _studentRepo.GetStudentDetailByIdAsync(studentId);
    }

    public async Task<StudentDetailDto?> GetStudentDetailByCodeAsync(string studentCode)
    {
        if (string.IsNullOrWhiteSpace(studentCode)) return null;
        return await _studentRepo.GetStudentDetailByCodeAsync(studentCode.Trim());
    }

    public async Task<(bool Success, string Message)> UpdateStudentProfileAsync(UpdateStudentProfileDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.FullName))
            return (false, "Họ và tên học viên không được để trống.");

        if (string.IsNullOrWhiteSpace(dto.Phone))
            return (false, "Số điện thoại học viên không được để trống.");

        bool updated = await _studentRepo.UpdateStudentProfileAsync(dto);
        return updated
            ? (true, "Cập nhật hồ sơ học viên thành công!")
            : (false, "Cập nhật hồ sơ học viên thất bại.");
    }

    public async Task<IEnumerable<ClassFilterItemDto>> GetClassesForFilterAsync()
    {
        return await _studentRepo.GetClassesForFilterAsync();
    }

    public async Task<decimal> GetStudentOutstandingDebtAsync(int studentId)
    {
        if (studentId <= 0) return 0m;
        return await _studentRepo.GetStudentOutstandingDebtAsync(studentId);
    }

    public async Task<(bool Success, string Message)> ArchiveStudentAsync(ArchiveStudentDto dto)
    {
        if (dto.StudentId <= 0)
            return (false, "Mã định danh học viên không hợp lệ.");

        bool archived = await _studentRepo.ArchiveStudentAsync(dto);
        return archived
            ? (true, "Đã lưu trữ hồ sơ học viên thành công.")
            : (false, "Lưu trữ hồ sơ học viên thất bại.");
    }

    public async Task<(bool Success, string Message)> RestoreStudentAsync(int studentId)
    {
        if (studentId <= 0)
            return (false, "Mã học viên không hợp lệ.");

        return await _studentRepo.RestoreStudentAsync(studentId);
    }

    public async Task<(bool IsDuplicate, string Reason)> CheckDuplicateStudentAsync(string phone, string fullName, DateTime dateOfBirth, int excludeStudentId = 0)
    {
        return await _studentRepo.CheckDuplicateStudentAsync(phone, fullName, dateOfBirth, excludeStudentId);
    }

    public async Task<(bool Success, string Message, int StudentId, string StudentCode)> CreateWaitingStudentAsync(StudentEnrollmentWithTuitionDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.FullName))
            return (false, "Họ và tên học viên không được để trống.", 0, string.Empty);
        if (string.IsNullOrWhiteSpace(dto.Phone))
            return (false, "Số điện thoại học viên không được để trống.", 0, string.Empty);

        return await _studentRepo.CreateWaitingStudentAsync(dto);
    }

    public async Task<StudentOverviewStatsDto> GetStudentStatsAsync()
    {
        return await _studentRepo.GetStudentStatsAsync();
    }

    public async Task<string> GenerateNextStudentCodeAsync()
    {
        return await _studentRepo.GenerateNextStudentCodeAsync();
    }

    public Task<IEnumerable<CourseLookupDto>> GetActiveCoursesForEnrollmentAsync()
        => _studentRepo.GetActiveCoursesForEnrollmentAsync();

    public Task<IEnumerable<OpenClassOptionDto>> GetOpenClassesByCourseAsync(int courseId)
        => _studentRepo.GetOpenClassesByCourseAsync(courseId);

    #endregion

    #region Nghiệp vụ Entity (Tương thích ngược)

    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QueryAsync<Student>("SELECT * FROM Students ORDER BY StudentId DESC;");
    }

    public async Task<IEnumerable<Student>> SearchStudentsAsync(string keyword)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await conn.QueryAsync<Student>("SELECT * FROM Students ORDER BY StudentId DESC;");
        }

        string sql = @"
            SELECT * FROM Students 
            WHERE FullName LIKE @Pattern OR StudentCode LIKE @Pattern OR Phone LIKE @Pattern
            ORDER BY StudentId DESC;";
        return await conn.QueryAsync<Student>(sql, new { Pattern = "%" + keyword.Trim() + "%" });
    }

    public async Task<Student?> GetStudentByIdAsync(int studentId)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        return await conn.QuerySingleOrDefaultAsync<Student>("SELECT * FROM Students WHERE StudentId = @Id;", new { Id = studentId });
    }

    public async Task<int> CreateStudentAsync(Student student)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        if (string.IsNullOrWhiteSpace(student.StudentCode))
        {
            student.StudentCode = await GenerateNextStudentCodeAsync();
        }

        string sql = @"
            INSERT INTO Students (StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, AvatarPath, Status, LeadId)
            VALUES (@StudentCode, @FullName, @DobStr, @Gender, @Phone, @Email, @Address, @AvatarPath, @StatusStr, @LeadId);
            SELECT last_insert_rowid();";

        return await conn.ExecuteScalarAsync<int>(sql, new
        {
            student.StudentCode,
            student.FullName,
            DobStr = student.DateOfBirth.ToString("yyyy-MM-dd"),
            student.Gender,
            student.Phone,
            student.Email,
            student.Address,
            student.AvatarPath,
            StatusStr = student.Status.ToString(),
            student.LeadId
        });
    }

    public async Task<bool> UpdateStudentAsync(Student student)
    {
        using var conn = DatabaseConfig.CreateOpenConnection();
        string sql = @"
            UPDATE Students SET
                FullName = @FullName,
                DateOfBirth = @DobStr,
                Gender = @Gender,
                Phone = @Phone,
                Email = @Email,
                Address = @Address,
                AvatarPath = @AvatarPath,
                Status = @StatusStr,
                UpdatedAt = CURRENT_TIMESTAMP
            WHERE StudentId = @StudentId;";

        int rows = await conn.ExecuteAsync(sql, new
        {
            student.FullName,
            DobStr = student.DateOfBirth.ToString("yyyy-MM-dd"),
            student.Gender,
            student.Phone,
            student.Email,
            student.Address,
            student.AvatarPath,
            StatusStr = student.Status.ToString(),
            student.StudentId
        });

        return rows > 0;
    }

    public async Task<(bool Success, string Message)> DeleteStudentAsync(int studentId)
    {
        if (studentId <= 0)
            return (false, "Mã học viên không hợp lệ.");

        return await _studentRepo.DeleteStudentWithChecksAsync(studentId);
    }

    #endregion

    #region Nghiệp vụ Nhập danh sách học viên từ Excel / CSV

    public byte[] GenerateStudentImportTemplate()
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add("DanhSachHocVien");

        string[] headers = new[]
        {
            "STT",
            "Họ và tên (*)",
            "Ngày sinh (dd/MM/yyyy)",
            "Giới tính (Nam/Nữ)",
            "Số điện thoại (*)",
            "Email",
            "Địa chỉ",
            "Họ tên phụ huynh",
            "SĐT phụ huynh",
            "Mối quan hệ (Bố/Mẹ/Giám hộ)"
        };

        for (int i = 0; i < headers.Length; i++)
        {
            var cell = ws.Cell(1, i + 1);
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Font.FontColor = XLColor.White;
            cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#2563EB");
            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        }

        var sampleRows = new List<object[]>
        {
            new object[] { 1, "Trần Văn An", "15/06/2006", "Nam", "0901234567", "an.tran@gmail.com", "123 Lê Lợi, Q.1", "Trần Văn Hùng", "0912345678", "Bố" },
            new object[] { 2, "Nguyễn Thị Mai", "20/09/2005", "Nữ", "0902345678", "mai.nguyen@gmail.com", "456 Nguyễn Huệ, Q.1", "Lê Thị Thảo", "0918765432", "Mẹ" },
            new object[] { 3, "Lê Hoàng Long", "10/02/2007", "Nam", "0903456789", "long.le@gmail.com", "789 CMT8, Q.3", "Lê Văn Tuấn", "0919876543", "Bố" }
        };

        for (int r = 0; r < sampleRows.Count; r++)
        {
            for (int c = 0; c < sampleRows[r].Length; c++)
            {
                var cell = ws.Cell(r + 2, c + 1);
                cell.Value = sampleRows[r][c]?.ToString() ?? "";
                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            }
        }

        ws.Columns().AdjustToContents();

        using var ms = new MemoryStream();
        workbook.SaveAs(ms);
        return ms.ToArray();
    }

    public async Task<List<StudentImportRowDto>> ParseAndValidateStudentFileAsync(Stream fileStream, string fileName)
    {
        var result = new List<StudentImportRowDto>();
        var existingPhones = await _studentRepo.GetExistingStudentPhonesAsync();
        var filePhones = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        bool isCsv = fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase);
        if (isCsv)
        {
            using var reader = new StreamReader(fileStream);
            string? headerLine = await reader.ReadLineAsync();
            int rowIdx = 1;

            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                rowIdx++;

                var parts = line.Split(',');
                if (parts.Length < 2) continue;

                int start = int.TryParse(parts[0].Trim(), out _) ? 1 : 0;
                string fullName = parts.Length > start ? parts[start].Trim().Trim('"') : "";
                string dobRaw = parts.Length > start + 1 ? parts[start + 1].Trim().Trim('"') : "";
                string gender = parts.Length > start + 2 ? parts[start + 2].Trim().Trim('"') : "Nam";
                string phone = parts.Length > start + 3 ? parts[start + 3].Trim().Trim('"') : "";
                string email = parts.Length > start + 4 ? parts[start + 4].Trim().Trim('"') : "";
                string address = parts.Length > start + 5 ? parts[start + 5].Trim().Trim('"') : "";
                string parentName = parts.Length > start + 6 ? parts[start + 6].Trim().Trim('"') : "";
                string parentPhone = parts.Length > start + 7 ? parts[start + 7].Trim().Trim('"') : "";
                string parentRel = parts.Length > start + 8 ? parts[start + 8].Trim().Trim('"') : "Bố";

                var item = ValidateAndCreateRow(rowIdx, fullName, dobRaw, gender, phone, email, address, parentName, parentPhone, parentRel, existingPhones, filePhones);
                result.Add(item);
            }
        }
        else
        {
            using var workbook = new XLWorkbook(fileStream);
            var ws = workbook.Worksheets.FirstOrDefault() ?? workbook.Worksheet(1);
            var lastRow = ws.LastRowUsed()?.RowNumber() ?? 1;

            for (int r = 2; r <= lastRow; r++)
            {
                var row = ws.Row(r);
                if (row.IsEmpty()) continue;

                string col1 = row.Cell(1).GetString().Trim();
                int startCol = 1;
                if (int.TryParse(col1, out _) && ws.Cell(1, 1).GetString().Contains("STT", StringComparison.OrdinalIgnoreCase))
                {
                    startCol = 2;
                }

                string fullName = row.Cell(startCol).GetString().Trim();
                if (string.IsNullOrWhiteSpace(fullName)) continue;

                string dobRaw = row.Cell(startCol + 1).GetString().Trim();
                if (string.IsNullOrWhiteSpace(dobRaw) && row.Cell(startCol + 1).DataType == XLDataType.DateTime)
                {
                    dobRaw = row.Cell(startCol + 1).GetDateTime().ToString("dd/MM/yyyy");
                }

                string gender = row.Cell(startCol + 2).GetString().Trim();
                string phone = row.Cell(startCol + 3).GetString().Trim();
                string email = row.Cell(startCol + 4).GetString().Trim();
                string address = row.Cell(startCol + 5).GetString().Trim();
                string parentName = row.Cell(startCol + 6).GetString().Trim();
                string parentPhone = row.Cell(startCol + 7).GetString().Trim();
                string parentRel = row.Cell(startCol + 8).GetString().Trim();

                var item = ValidateAndCreateRow(r, fullName, dobRaw, gender, phone, email, address, parentName, parentPhone, parentRel, existingPhones, filePhones);
                result.Add(item);
            }
        }

        return result;
    }

    private static StudentImportRowDto ValidateAndCreateRow(
        int rowIdx, string fullName, string dobRaw, string gender, string phone,
        string email, string address, string parentName, string parentPhone, string parentRel,
        HashSet<string> existingPhones, HashSet<string> filePhones)
    {
        var dto = new StudentImportRowDto
        {
            RowIndex = rowIdx,
            FullName = fullName,
            Gender = string.Equals(gender, "Nữ", StringComparison.OrdinalIgnoreCase) ? "Nữ" : "Nam",
            Phone = phone.Replace(" ", "").Replace(".", "").Replace("-", ""),
            Email = email,
            Address = address,
            ParentName = parentName,
            ParentPhone = parentPhone?.Replace(" ", "").Replace(".", "").Replace("-", ""),
            ParentRelationship = string.IsNullOrWhiteSpace(parentRel) ? "Bố" : parentRel
        };

        if (DateTime.TryParseExact(dobRaw, new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd", "dd-MM-yyyy" },
            System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var dob))
        {
            dto.DateOfBirth = dob;
        }
        else if (DateTime.TryParse(dobRaw, out var dobAuto))
        {
            dto.DateOfBirth = dobAuto;
        }

        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(dto.FullName))
        {
            errors.Add("Thiếu họ tên");
        }

        if (!dto.DateOfBirth.HasValue)
        {
            errors.Add("Thiếu hoặc sai định dạng ngày sinh (dd/MM/yyyy)");
        }

        if (string.IsNullOrWhiteSpace(dto.Phone))
        {
            errors.Add("Thiếu số điện thoại");
        }
        else if (!Regex.IsMatch(dto.Phone, @"^0\d{9}$"))
        {
            errors.Add("SĐT không hợp lệ (cần đúng 10 chữ số bắt đầu bằng 0)");
        }
        else if (existingPhones.Contains(dto.Phone))
        {
            errors.Add("SĐT đã tồn tại trong hệ thống");
        }
        else if (!filePhones.Add(dto.Phone))
        {
            errors.Add("SĐT bị trùng lặp trong tệp");
        }

        if (string.IsNullOrWhiteSpace(dto.Email))
        {
            errors.Add("Thiếu email");
        }
        else if (!Regex.IsMatch(dto.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            errors.Add("Email không đúng định dạng");
        }

        if (string.IsNullOrWhiteSpace(dto.Address))
        {
            errors.Add("Thiếu địa chỉ");
        }

        if (string.IsNullOrWhiteSpace(dto.ParentName))
        {
            errors.Add("Thiếu họ tên phụ huynh");
        }

        if (string.IsNullOrWhiteSpace(dto.ParentPhone))
        {
            errors.Add("Thiếu SĐT phụ huynh");
        }
        else if (!Regex.IsMatch(dto.ParentPhone, @"^0\d{9}$"))
        {
            errors.Add("SĐT phụ huynh không hợp lệ (10 chữ số)");
        }

        if (errors.Count > 0)
        {
            dto.IsValid = false;
            dto.ValidationMessage = string.Join("; ", errors);
        }
        else
        {
            dto.IsValid = true;
            dto.ValidationMessage = "Hợp lệ";
        }

        return dto;
    }

    public async Task<StudentImportResultDto> ExecuteImportStudentsAsync(List<StudentImportRowDto> items)
    {
        var validItems = items.Where(x => x.IsValid).ToList();
        return await _studentRepo.ImportStudentsBatchAsync(validItems);
    }

    #endregion
}
