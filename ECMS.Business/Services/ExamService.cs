using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class ExamService : IExamService
{
    private readonly IExamRepository _repo;

    public ExamService(IExamRepository? repo = null)
    {
        _repo = repo ?? new ExamRepository();
    }

    public Task<IEnumerable<ExamListItemDto>> GetAllExamsAsync() => _repo.GetAllExamsAsync();

    public Task<(bool Success, string Message)> CreateExamsWithConflictCheckAsync(CreateExamRequestDto req)
        => _repo.CreateExamsWithConflictCheckAsync(req);

    public Task<(bool Success, string Message)> DeleteExamAsync(int examId)
        => _repo.DeleteExamAsync(examId);

    public Task<IEnumerable<StudentGradeEntryDto>> GetClassGradeEntriesAsync(int classId)
        => _repo.GetClassGradeEntriesAsync(classId);

    public Task<(bool Success, string Message)> SaveClassGradeEntriesAsync(int classId, List<StudentGradeEntryDto> entries)
        => _repo.SaveClassGradeEntriesAsync(classId, entries);
}
