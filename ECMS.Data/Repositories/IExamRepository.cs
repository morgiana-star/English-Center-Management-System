using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IExamRepository
{
    Task<IEnumerable<ExamListItemDto>> GetAllExamsAsync();
    Task<(bool Success, string Message)> CreateExamsWithConflictCheckAsync(CreateExamRequestDto req);
    Task<(bool Success, string Message)> DeleteExamAsync(int examId);
    Task<IEnumerable<StudentGradeEntryDto>> GetClassGradeEntriesAsync(int classId);
    Task<(bool Success, string Message)> SaveClassGradeEntriesAsync(int classId, List<StudentGradeEntryDto> entries);
    Task<IEnumerable<ClassExamLookupDto>> GetClassesLookupAsync();
    Task<int> CreateExamAsync(CreateExamDto dto);
    Task<IEnumerable<ClassGradeRowDto>> GetClassGradeBookAsync(int classId);
    Task SaveClassGradeBookAsync(int classId, List<ClassGradeRowDto> rows);
}
