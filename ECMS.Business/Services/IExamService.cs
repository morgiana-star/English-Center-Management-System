using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IExamService
{
    Task<IEnumerable<ExamListItemDto>> GetExamsAsync(int? teacherId = null, int? classId = null, string? examType = null, string? keyword = null);
    Task<int> CreateExamAsync(CreateExamDto dto);
    Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync(int? teacherId = null);
    Task<List<ClassGradeRowDto>> GetClassGradeBookAsync(int classId);
    Task<bool> SaveClassGradeBookAsync(int classId, List<ClassGradeRowDto> rows);
}
