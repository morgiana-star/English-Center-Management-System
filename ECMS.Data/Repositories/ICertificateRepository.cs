using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface ICertificateRepository
{
    Task<IEnumerable<EligibleStudentDto>> GetEligibleStudentsAsync(string? keyword = null, string? courseName = null, string? className = null);
    Task<IEnumerable<IssuedCertificateDto>> GetIssuedCertificatesAsync(string? keyword = null);
    Task<(bool Success, string Message, string SerialNumber)> IssueCertificateAsync(int enrollmentId, int studentId, string graduationGrade, string approver, string serialNumber);
}
