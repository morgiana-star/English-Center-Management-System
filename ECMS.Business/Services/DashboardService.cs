using System.Collections.Generic;
using System.Threading.Tasks;
using ECMS.Core.DTOs;
using ECMS.Data.Repositories;

namespace ECMS.Business.Services;

public class DashboardService : IDashboardService
{
    private readonly IDashboardRepository _dashboardRepo;

    public DashboardService(IDashboardRepository? dashboardRepo = null)
    {
        _dashboardRepo = dashboardRepo ?? new DashboardRepository();
    }

    public Task<DashboardKpiSummaryDto> GetKpiSummaryAsync()
        => _dashboardRepo.GetKpiSummaryAsync();

    public Task<IEnumerable<MonthlyRevenueBarDto>> GetMonthlyRevenueTrendAsync(int months = 6)
        => _dashboardRepo.GetMonthlyRevenueTrendAsync(months);

    public Task<IEnumerable<MonthlyStudentGrowthBarDto>> GetMonthlyStudentGrowthAsync(int months = 6)
        => _dashboardRepo.GetMonthlyStudentGrowthAsync(months);

    public Task<IEnumerable<CourseAttendanceRatioDto>> GetCourseAttendanceRatiosAsync()
        => _dashboardRepo.GetCourseAttendanceRatiosAsync();

    public Task<IEnumerable<ClassAttendanceDetailDto>> GetClassAttendanceDetailsAsync()
        => _dashboardRepo.GetClassAttendanceDetailsAsync();

    public Task<IEnumerable<TodayScheduleItemDto>> GetTodayAndUpcomingSchedulesAsync()
        => _dashboardRepo.GetTodayAndUpcomingSchedulesAsync();

    public Task<IEnumerable<PendingTaskItemDto>> GetPendingTasksAsync()
        => _dashboardRepo.GetPendingTasksAsync();

    public Task<bool> UpdatePendingTaskStatusAsync(int studentId, string newStatus)
        => _dashboardRepo.UpdatePendingTaskStatusAsync(studentId, newStatus);

    public Task<bool> DeletePendingTaskAsync(int studentId)
        => _dashboardRepo.DeletePendingTaskAsync(studentId);

    public Task<IEnumerable<DashboardQuickSearchResultDto>> QuickSearchListAsync(string keyword)
        => _dashboardRepo.QuickSearchListAsync(keyword);
}
