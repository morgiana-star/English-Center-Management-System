using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class CertificateService : ICertificateService
{
    private readonly ICertificateRepository _repo;
    private static int _serialCounter = 42;

    public CertificateService(ICertificateRepository? repo = null)
    {
        _repo = repo ?? new CertificateRepository();
    }

    public async Task<IEnumerable<EligibleStudentDto>> GetEligibleStudentsAsync(string? keyword = null, string? courseName = null, string? className = null)
    {
        return await _repo.GetEligibleStudentsAsync(keyword, courseName, className);
    }

    public async Task<IEnumerable<IssuedCertificateDto>> GetIssuedCertificatesAsync(string? keyword = null)
    {
        return await _repo.GetIssuedCertificatesAsync(keyword);
    }

    public async Task<(bool Success, string Message, string SerialNumber)> IssueCertificateAsync(
        int enrollmentId, 
        int studentId, 
        string graduationGrade, 
        string approver)
    {
        if (enrollmentId <= 0 || studentId <= 0)
        {
            return (false, "Thông tin học viên hoặc lượt đăng ký không hợp lệ!", string.Empty);
        }

        _serialCounter++;
        string serialNumber = $"CC-{DateTime.Now.Year}-{_serialCounter:D4}";

        return await _repo.IssueCertificateAsync(enrollmentId, studentId, graduationGrade, approver, serialNumber);
    }
}
