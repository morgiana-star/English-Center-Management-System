using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class ScheduleService : IScheduleService
{
    private readonly IScheduleRepository _repo;

    public ScheduleService(IScheduleRepository? repo = null)
    {
        _repo = repo ?? new ScheduleRepository();
    }

    public Task<IEnumerable<WeeklyScheduleSlotDto>> GetSchedulesInRangeAsync(DateTime startDate, DateTime endDate, string? filterType = null, string? filterValue = null)
        => _repo.GetSchedulesInRangeAsync(startDate, endDate, filterType, filterValue);

    public Task<IEnumerable<ScheduleSummaryItemDto>> GetClassScheduleSummariesAsync()
        => _repo.GetClassScheduleSummariesAsync();

    public Task<IEnumerable<ClassForScheduleCreateDto>> GetClassesForScheduleCreationAsync()
        => _repo.GetClassesForScheduleCreationAsync();

    public Task<(bool Success, string Message)> GenerateClassSchedulesAsync(GenerateClassScheduleRequestDto req)
        => _repo.GenerateClassSchedulesAsync(req);

    public Task<(bool Success, string Message)> DeleteClassSchedulesAsync(int classId)
        => _repo.DeleteClassSchedulesAsync(classId);

    public Task<List<string>> GetFilterTargetsAsync(string filterType)
        => _repo.GetFilterTargetsAsync(filterType);
}
