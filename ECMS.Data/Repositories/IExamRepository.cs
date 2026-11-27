using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;

namespace ECMS.Data.Repositories;

public interface IExamRepository
{
    Task<IEnumerable<ExamListItemDto>> GetExamsAsync(int? teacherId = null, int? classId = null, string? examType = null, string? keyword = null);
    Task<Exam?> GetExamByIdAsync(int examId);
    Task<int> CreateExamAsync(Exam exam);
    Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync(int? teacherId = null);
    Task<List<ClassGradeRowDto>> GetClassGradeRowsAsync(int classId);
    Task<bool> SaveClassGradeRowsAsync(int classId, List<ClassGradeRowDto> rows);
}
