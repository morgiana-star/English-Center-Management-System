using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;

namespace ECMS.Business.Services;

public interface IDashboardService
{
    Task<DashboardKpiSummaryDto> GetKpiSummaryAsync();
    Task<IEnumerable<MonthlyRevenueBarDto>> GetMonthlyRevenueTrendAsync(int months = 6);
    Task<IEnumerable<MonthlyStudentGrowthBarDto>> GetMonthlyStudentGrowthAsync(int months = 6);
    Task<IEnumerable<CourseAttendanceRatioDto>> GetCourseAttendanceRatiosAsync();
    Task<IEnumerable<ClassAttendanceDetailDto>> GetClassAttendanceDetailsAsync();
    Task<IEnumerable<TodayScheduleItemDto>> GetTodayAndUpcomingSchedulesAsync();
    Task<IEnumerable<TodayScheduleItemDto>> GetTodaySchedulesAsync();
    Task<IEnumerable<PendingTaskItemDto>> GetPendingTasksAsync();
    Task<IEnumerable<OverdueDebtAlertItemDto>> GetOverdueDebtAlertsAsync();
    Task<bool> UpdatePendingTaskStatusAsync(int studentId, string newStatus);
    Task<bool> DeletePendingTaskAsync(int studentId);
    Task<IEnumerable<DashboardQuickSearchResultDto>> QuickSearchListAsync(string keyword);
    Task<DashboardCategorizedSearchDto> QuickSearchCategorizedAsync(string keyword);
}
