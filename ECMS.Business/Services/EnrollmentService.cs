using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class EnrollmentService : IEnrollmentService
{
    private readonly IEnrollmentRepository _enrollmentRepo;
    private readonly IAuditLogRepository _auditLogRepo;

    public EnrollmentService(IEnrollmentRepository? enrollmentRepo = null, IAuditLogRepository? auditLogRepo = null)
    {
        _enrollmentRepo = enrollmentRepo ?? new EnrollmentRepository();
        _auditLogRepo = auditLogRepo ?? new AuditLogRepository();
    }

    public async Task<IEnumerable<ClassLookupDto>> GetOpenClassesLookupAsync()
    {
        return await _enrollmentRepo.GetOpenClassesLookupAsync();
    }

    public async Task<ClassLookupDto?> GetClassByIdAsync(int classId)
    {
        return await _enrollmentRepo.GetClassByIdAsync(classId);
    }

    public async Task<IEnumerable<FeeDiscountDto>> GetActiveDiscountsAsync()
    {
        return await _enrollmentRepo.GetActiveDiscountsAsync();
    }

    public async Task<bool> IsExistingStudentByPhoneAsync(string phone)
    {
        return await _enrollmentRepo.IsExistingStudentByPhoneAsync(phone);
    }

    public async Task<(bool Success, string Message, int StudentId, string StudentCode, int EnrollmentId, string InvoiceCode, decimal FinalAmount)> EnrollStudentAsync(
        StudentEnrollmentDto dto,
        int? currentUserId = null)
    {
        // 1. Validate Họ và tên
        if (string.IsNullOrWhiteSpace(dto.FullName) || dto.FullName.Trim().Length < 2)
        {
            return (false, "Họ và tên học viên không được để trống và phải có ít nhất 2 ký tự.", 0, string.Empty, 0, string.Empty, 0);
        }

        // 2. Validate Số điện thoại
        string phone = dto.Phone?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, @"^0\d{9,10}$"))
        {
            return (false, "Số điện thoại không hợp lệ (Phải bắt đầu bằng số 0 và có từ 10 đến 11 chữ số).", 0, string.Empty, 0, string.Empty, 0);
        }

        // 3. Validate Lớp học
        if (dto.ClassId <= 0)
        {
            return (false, "Vui lòng chọn một lớp học để đăng ký xếp lớp.", 0, string.Empty, 0, string.Empty, 0);
        }

        var classInfo = await _enrollmentRepo.GetClassByIdAsync(dto.ClassId);
        if (classInfo == null)
        {
            return (false, "Lớp học đã chọn không tồn tại trong hệ thống.", 0, string.Empty, 0, string.Empty, 0);
        }

        // 4. Thuật toán kiểm tra sức chứa lớp (Capacity check)
        if (classInfo.CurrentStudents >= classInfo.MaxStudents)
        {
            return (false, $"Lớp học '{classInfo.ClassName}' đã đủ sĩ số tối đa ({classInfo.CurrentStudents}/{classInfo.MaxStudents} học viên)! Vui lòng chọn lớp học khác.", 0, string.Empty, 0, string.Empty, 0);
        }

        // 5. Kiểm tra học viên đã tồn tại theo số điện thoại chưa
        int targetStudentId = dto.StudentId;
        string finalStudentCode = dto.StudentCode;

        if (targetStudentId <= 0)
        {
            var existingStudentId = await _enrollmentRepo.FindStudentIdByPhoneAsync(phone);
            if (existingStudentId.HasValue && existingStudentId.Value > 0)
            {
                targetStudentId = existingStudentId.Value;
                dto.StudentId = targetStudentId;
                finalStudentCode = $"HV (Đã tồn tại - ID #{targetStudentId})";
            }
            else
            {
                // Sinh mã mới chuẩn HV-yyyy-xxxx
                finalStudentCode = await _enrollmentRepo.GenerateNextStudentCodeAsync();
            }
        }

        // 6. Kiểm tra xem học viên đã ghi danh vào lớp này chưa
        if (targetStudentId > 0)
        {
            bool isAlreadyEnrolled = await _enrollmentRepo.CheckStudentEnrolledAsync(targetStudentId, dto.ClassId);
            if (isAlreadyEnrolled)
            {
                return (false, $"Học viên '{dto.FullName}' ({phone}) đã được xếp vào lớp '{classInfo.ClassName}' trước đó rồi!", 0, string.Empty, 0, string.Empty, 0);
            }
        }

        // 7. Tính toán Học phí & Chính sách Ưu đãi (Ngày 8)
        decimal originalAmount = classInfo.TuitionFee;
        decimal discountAmount = 0;
        string discountNameApplied = "Không có";

        if (dto.DiscountId.HasValue && dto.DiscountId.Value > 0)
        {
            var discount = await _enrollmentRepo.GetDiscountByIdAsync(dto.DiscountId.Value);
            if (discount != null)
            {
                discountAmount = discount.CalculateDiscount(originalAmount);
                discountNameApplied = discount.DisplayText;
            }
        }

        decimal finalAmount = Math.Max(0, originalAmount - discountAmount);

        dto.OriginalAmount = originalAmount;
        dto.DiscountAmount = discountAmount;
        dto.FinalAmount = finalAmount;
        dto.FullName = dto.FullName.Trim();
        dto.Phone = phone;
        dto.Email = string.IsNullOrWhiteSpace(dto.Email) ? null : dto.Email.Trim();
        dto.Address = string.IsNullOrWhiteSpace(dto.Address) ? null : dto.Address.Trim();

        // 8. Sinh mã Hóa đơn chuẩn INV-yyyyMMdd-xxx
        string invoiceCode = await _enrollmentRepo.GenerateNextInvoiceCodeAsync();

        // 9. Thực thi Transaction Đăng ký lớp + Tự động sinh Hóa đơn
        var (success, msg, studentId, enrollmentId, invoiceId, createdInvoiceCode) =
            await _enrollmentRepo.ExecuteEnrollmentTransactionAsync(dto, finalStudentCode, invoiceCode);

        if (!success)
        {
            return (false, msg, 0, string.Empty, 0, string.Empty, 0);
        }

        // 10. Ghi vết Audit Log
        await _auditLogRepo.LogAsync(
            currentUserId,
            "ENROLL_AND_CREATE_INVOICE",
            "Invoices",
            invoiceId.ToString(),
            null,
            $"Đăng ký HV '{dto.FullName}' vào lớp {classInfo.ClassName}. Gốc: {originalAmount:N0}đ | Ưu đãi: {discountNameApplied} (-{discountAmount:N0}đ) | Thực thu: {finalAmount:N0}đ | Mã HĐ: {createdInvoiceCode}");

        return (true,
            $"Đăng ký xếp lớp & Xuất hóa đơn thành công!",
            studentId,
            finalStudentCode,
            enrollmentId,
            createdInvoiceCode,
            finalAmount);
    }

    public async Task<IEnumerable<EnrollmentListItemDto>> GetRecentEnrollmentsAsync(int limit = 50)
    {
        return await _enrollmentRepo.GetRecentEnrollmentsAsync(limit);
    }
}
