using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

    public async Task<DashboardKpiSummaryDto> GetKpiSummaryAsync(string? selectedMonth = null, string? selectedCourse = null)
    {
        string? ym = ParseYearMonth(selectedMonth);
        return await _dashboardRepo.GetKpiSummaryAsync(ym);
    }

    public Task<IEnumerable<MonthlyRevenueBarDto>> GetMonthlyRevenueTrendAsync(int months = 6)
        => _dashboardRepo.GetMonthlyRevenueTrendAsync(months);

    public Task<IEnumerable<MonthlyStudentGrowthBarDto>> GetMonthlyStudentGrowthAsync(int months = 4)
        => _dashboardRepo.GetMonthlyStudentGrowthAsync(months);

    public Task<IEnumerable<CourseAttendanceRatioDto>> GetCourseAttendanceRatiosAsync()
        => _dashboardRepo.GetCourseAttendanceRatiosAsync();

    public Task<IEnumerable<TodayScheduleItemDto>> GetTodayAndUpcomingSchedulesAsync()
        => _dashboardRepo.GetTodayAndUpcomingSchedulesAsync();

    public Task<IEnumerable<PendingTaskItemDto>> GetPendingTasksAsync()
        => _dashboardRepo.GetPendingTasksAsync();

    public Task<DashboardQuickSearchResultDto?> QuickSearchAsync(string keyword)
        => _dashboardRepo.QuickSearchAsync(keyword);

    private static string? ParseYearMonth(string? text)
    {
        if (string.IsNullOrWhiteSpace(text) || text.Contains("Tất cả", StringComparison.OrdinalIgnoreCase))
            return null;

        // Định dạng "Tháng 10/2026" hoặc "10/2026"
        var match = Regex.Match(text, @"(\d{1,2})[/_-](\d{4})");
        if (match.Success)
        {
            int m = int.Parse(match.Groups[1].Value);
            int y = int.Parse(match.Groups[2].Value);
            return $"{y:D4}-{m:D2}";
        }

        return "2026-10";
    }
}
