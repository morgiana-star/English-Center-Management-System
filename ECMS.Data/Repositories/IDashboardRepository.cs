using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Data.Repositories;

public interface IDashboardRepository
{
    Task<DashboardKpiSummaryDto> GetKpiSummaryAsync(string? yearMonth = null, int? courseId = null);
    Task<IEnumerable<MonthlyRevenueBarDto>> GetMonthlyRevenueTrendAsync(int months = 6);
    Task<IEnumerable<MonthlyStudentGrowthBarDto>> GetMonthlyStudentGrowthAsync(int months = 4);
    Task<IEnumerable<CourseAttendanceRatioDto>> GetCourseAttendanceRatiosAsync();
    Task<IEnumerable<TodayScheduleItemDto>> GetTodayAndUpcomingSchedulesAsync();
    Task<IEnumerable<PendingTaskItemDto>> GetPendingTasksAsync();
    Task<DashboardQuickSearchResultDto?> QuickSearchAsync(string keyword);
}
