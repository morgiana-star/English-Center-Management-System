using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IScheduleService
{
    Task<IEnumerable<WeeklyScheduleSlotDto>> GetSchedulesInRangeAsync(DateTime startDate, DateTime endDate, string? filterType = null, string? filterValue = null);
    Task<IEnumerable<ScheduleSummaryItemDto>> GetClassScheduleSummariesAsync();
    Task<IEnumerable<ClassForScheduleCreateDto>> GetClassesForScheduleCreationAsync();
    Task<(bool Success, string Message)> GenerateClassSchedulesAsync(GenerateClassScheduleRequestDto req);
    Task<(bool Success, string Message)> DeleteClassSchedulesAsync(int classId);
    Task<List<string>> GetFilterTargetsAsync(string filterType);
}
