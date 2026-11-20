using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// Màn hình Tổng quan điều hành trung tâm (Dashboard Overview) - 100% dữ liệu SQLite
/// </summary>
public partial class DashboardOverviewView : UserControl
{
    private readonly IDashboardService _dashboardService = new DashboardService();
    private bool _isLoading = false;

    public DashboardOverviewView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        Dock = DockStyle.Fill;
        SetupFilters();
        WireEvents();
        _ = LoadDashboardDataAsync();
    }

    private void SetupFilters()
    {
        // Xóa 2 ô lọc tháng và khóa học theo thiết kế mới (biểu đồ đã hiển thị theo tháng)
        _cboMonth.Visible = false;
        _cboCourse.Visible = false;

        // Dùng định vị thủ công trong PerformResponsiveLayout để các nút "Xem chi tiết" luôn nằm đúng góc trên phải
        _btnRevenueDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        _btnStudentsDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        _btnAttDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        _btnSchedDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (!DesignMode && System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
        {
            PerformResponsiveLayout();
        }
    }

    private async Task LoadDashboardDataAsync()
    {
        if (_isLoading) return;
        _isLoading = true;

        try
        {
            // 1. Nạp 6 chỉ số KPI điều hành + chuyên cần trung bình thật từ SQLite
            var kpi = await _dashboardService.GetKpiSummaryAsync();
            _lblKpi1Value.Text = kpi.TotalStudents.ToString();
            _lblKpi2Value.Text = kpi.ActiveStudents.ToString();
            _lblKpi3Value.Text = kpi.ActiveClasses.ToString();
            _lblKpi4Value.Text = kpi.ActiveTeachers.ToString();
            _lblKpi5Title.Text = $"DOANH THU T{DateTime.Today.Month}";
            _lblKpi5Value.Text = kpi.CurrentMonthRevenueFormatted;
            _lblKpi6Value.Text = kpi.TotalOutstandingDebtFormatted;
            _lblAttPercent.Text = $"{kpi.AverageAttendanceRate:0.0}%";

            // Cập nhật số lượng học viên vắng cần xử lý trên nút
            var pendingTasks = (await _dashboardService.GetPendingTasksAsync()).ToList();
            _btnPendingTasks.Text = $"Danh sách cần xử lý ({pendingTasks.Count})";

            // 2. Nạp Biểu đồ doanh thu 6 tháng
            var revTrend = (await _dashboardService.GetMonthlyRevenueTrendAsync(6)).ToList();
            _chartRevenue.Items = revTrend.Select(x => new BarItem(x.MonthLabel, x.RevenueMillion, x.DisplayLabel, x.IsHighlight)).ToList();

            // 3. Nạp Biểu đồ tăng trưởng học viên 6 tháng (số cột bằng nhau với biểu đồ doanh thu)
            var stGrowth = (await _dashboardService.GetMonthlyStudentGrowthAsync(6)).ToList();
            _chartStudents.Items = stGrowth.Select(x => new BarItem(x.MonthLabel, x.StudentCount, x.DisplayLabel, x.IsHighlight)).ToList();

            // 4. Nạp Bảng Chuyên cần theo nhóm lớp
            var ratios = (await _dashboardService.GetCourseAttendanceRatiosAsync()).ToList();
            _dgvRatio.Columns.Clear();
            _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nhóm lớp ↑", FillWeight = 46 });
            _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lớp", FillWeight = 24 });
            _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên", FillWeight = 30 });
            _dgvRatio.Rows.Clear();
            foreach (var r in ratios)
            {
                _dgvRatio.Rows.Add(r.CategoryName, r.ClassCount.ToString(), r.StudentCount.ToString());
            }
            _dgvRatio.ClearSelection();
            _dgvRatio.CurrentCell = null;

            // 5. Nạp Bảng Lịch học hôm nay & Sắp khai giảng
            var schedules = (await _dashboardService.GetTodayAndUpcomingSchedulesAsync()).ToList();
            _dgvSchedule.Columns.Clear();
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / ngày ↑", FillWeight = 22 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 20 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 14 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên phụ trách", FillWeight = 26 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 14 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái lớp", FillWeight = 18 });
            _dgvSchedule.Rows.Clear();
            foreach (var s in schedules)
            {
                _dgvSchedule.Rows.Add(s.TimeDisplay, s.ClassCode, s.RoomName, s.TeacherName, s.CapacityFormatted, s.StatusText);
            }
            _dgvSchedule.ClearSelection();
            _dgvSchedule.CurrentCell = null;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"[Dashboard] Lỗi tải số liệu: {ex.Message}");
        }
        finally
        {
            _isLoading = false;
        }
    }

    private void WireEvents()
    {
        // 1. Nút Xuất báo cáo tổng quan ra file CSV (mở bằng Excel bên ngoài)
        _btnExport.Click += async (s, e) => await ExportDashboardReportAsync();

        // 2. Nút "Danh sách cần xử lý": Học viên vắng quá số buổi quy định (có sửa trạng thái + Xóa)
        _btnPendingTasks.Click += async (s, e) => await OpenAbsenceAlertsDialogAsync();

        // 3. Tìm kiếm nhanh -> Hiển thị tất cả kết quả liên quan dạng DataGridView
        _btnSearch.Click += (s, e) => ExecuteQuickSearch();
        _txtSearch.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ExecuteQuickSearch();
            }
        };

        // 4. Xem chi tiết biểu đồ doanh thu dạng DataGridView
        _btnRevenueDetail.Click += async (s, e) =>
        {
            try
            {
                var revList = (await _dashboardService.GetMonthlyRevenueTrendAsync(6)).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Báo cáo chi tiết doanh thu 6 tháng gần nhất",
                    "Dữ liệu doanh thu thực thu từ bảng Payments và số học viên mới nhập học",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian ↑", FillWeight = 18, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Doanh thu thực thu", FillWeight = 26, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chỉ tiêu ước tính", FillWeight = 24, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ đạt (%)", FillWeight = 18, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số HV mới", FillWeight = 16, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tăng trưởng MoM", FillWeight = 18, ReadOnly = true });

                        foreach (var r in revList)
                        {
                            decimal act = (decimal)(r.RevenueMillion * 1000000);
                            double pct = r.TargetAmount > 0 ? (double)(act / r.TargetAmount * 100) : 0.0;
                            string monthDisplay = DateTime.TryParseExact(r.YearMonth, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out var dt)
                                ? dt.ToString("MM/yyyy")
                                : r.YearMonth;
                            dgv.Rows.Add(
                                $"Tháng {monthDisplay}",
                                $"{act:N0} đ",
                                $"{r.TargetAmount:N0} đ",
                                $"{pct:0.0}%",
                                $"{r.NewStudentsCount} học viên",
                                r.GrowthRateMoM);
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết doanh thu", ex.Message);
            }
        };

        // 5. Xem chi tiết biểu đồ tăng trưởng học viên 6 tháng dạng DataGridView
        _btnStudentsDetail.Click += async (s, e) =>
        {
            try
            {
                var stuList = (await _dashboardService.GetMonthlyStudentGrowthAsync(6)).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Báo cáo chi tiết tăng trưởng học viên 6 tháng gần nhất",
                    "Số lượng học viên lũy kế, học viên mới và tỷ lệ duy trì theo từng tháng",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian ↑", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng học viên", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tuyển mới trong tháng", FillWeight = 22, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đã hoàn thành", FillWeight = 18, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ duy trì", FillWeight = 20, ReadOnly = true });

                        foreach (var st in stuList)
                        {
                            string monthDisplay = DateTime.TryParseExact(st.YearMonth, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out var dt)
                                ? dt.ToString("MM/yyyy")
                                : st.YearMonth;
                            dgv.Rows.Add(
                                $"Tháng {monthDisplay}",
                                $"{st.TotalStudents} học viên",
                                $"{st.NewStudents} học viên",
                                $"{st.GraduatedCount} học viên",
                                st.RetentionRate);
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết học viên", ex.Message);
            }
        };

        // 6. Xem chi tiết chuyên cần từng lớp học thật từ Database
        _btnAttDetail.Click += async (s, e) =>
        {
            try
            {
                var attList = (await _dashboardService.GetClassAttendanceDetailsAsync()).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Báo cáo chi tiết chuyên cần theo từng lớp học",
                    "Số liệu thực tế từ bảng Lớp học, Lịch học và Chuyên cần",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp ↑", FillWeight = 18, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khóa học", FillWeight = 28, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 24, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 14, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số buổi đã xếp", FillWeight = 16, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chuyên cần", FillWeight = 16, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đánh giá", FillWeight = 18, ReadOnly = true });

                        foreach (var item in attList)
                        {
                            dgv.Rows.Add(item.ClassCode, item.CourseName, item.TeacherName, item.CapacityFormatted, item.LessonsProgress, item.AttendanceRateFormatted, item.StatusText);
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết chuyên cần", ex.Message);
            }
        };

        // 7. Xem chi tiết Lịch hôm nay & Sắp khai giảng dạng DataGridView
        _btnSchedDetail.Click += async (s, e) =>
        {
            try
            {
                var schedList = (await _dashboardService.GetTodayAndUpcomingSchedulesAsync()).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Bảng chi tiết lịch học & khai giảng toàn hệ thống",
                    "Lịch trình các lớp học và ca học từ bảng ClassSchedules",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / Ngày ↑", FillWeight = 22, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", FillWeight = 18, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên lớp", FillWeight = 24, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 12, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 24, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 12, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 18, ReadOnly = true });

                        foreach (var sc in schedList)
                        {
                            dgv.Rows.Add(sc.TimeDisplay, sc.ClassCode, sc.ClassName, sc.RoomName, sc.TeacherName, sc.CapacityFormatted, sc.StatusText);
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải lịch học", ex.Message);
            }
        };
    }

    private async Task OpenAbsenceAlertsDialogAsync()
    {
        try
        {
            var tasks = (await _dashboardService.GetPendingTasksAsync()).ToList();

            using var dlg = new QuickDetailGridDialog(
                "Danh sách học viên vắng quá số buổi quy định",
                "Tham chiếu ngưỡng cảnh báo vắng từ Cấu hình hệ thống — Cho phép đổi trạng thái xử lý hoặc xóa");

            dlg.SetGridData(dgv =>
            {
                dgv.ReadOnly = false;
                dgv.Columns.Clear();
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStt", HeaderText = "STT", FillWeight = 8, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã HV", FillWeight = 15, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColName", HeaderText = "Họ và tên", FillWeight = 22, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColPhone", HeaderText = "Điện thoại", FillWeight = 16, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClass", HeaderText = "Lớp học", FillWeight = 15, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColAbsent", HeaderText = "Số buổi vắng", FillWeight = 16, ReadOnly = true });

                var colStatus = new DataGridViewComboBoxColumn
                {
                    Name = "ColStatus",
                    HeaderText = "Trạng thái xử lý",
                    FillWeight = 18,
                    ReadOnly = false,
                    FlatStyle = FlatStyle.Flat
                };
                colStatus.Items.AddRange("Chưa xử lý", "Đã xử lý");
                dgv.Columns.Add(colStatus);

                var colDelete = new DataGridViewButtonColumn
                {
                    Name = "ColDelete",
                    HeaderText = "Xóa",
                    Text = "🗑️ Xóa",
                    UseColumnTextForButtonValue = true,
                    FillWeight = 12,
                    FlatStyle = FlatStyle.Flat
                };
                colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                dgv.Columns.Add(colDelete);

                foreach (var t in tasks)
                {
                    int rowIdx = dgv.Rows.Add(
                        t.Index.ToString(),
                        t.StudentCode,
                        t.StudentName,
                        t.Phone,
                        t.ClassCode,
                        $"{t.AbsentCount} / {t.MaxAllowedAbsences} buổi",
                        t.HandlingStatus == "Đã xử lý" ? "Đã xử lý" : "Chưa xử lý"
                    );
                    dgv.Rows[rowIdx].Tag = t.StudentId;
                }

                // Cho phép đổi trạng thái ComboBox kích hoạt lưu tức thì xuống SQLite
                dgv.CurrentCellDirtyStateChanged += (sender, args) =>
                {
                    if (dgv.IsCurrentCellDirty && dgv.CurrentCell is DataGridViewComboBoxCell)
                    {
                        dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    }
                };

                dgv.CellValueChanged += async (sender, args) =>
                {
                    if (args.RowIndex < 0 || dgv.Columns[args.ColumnIndex].Name != "ColStatus") return;
                    if (dgv.Rows[args.RowIndex].Tag is int stId)
                    {
                        string newStatus = dgv.Rows[args.RowIndex].Cells["ColStatus"].Value?.ToString() ?? "Chưa xử lý";
                        await _dashboardService.UpdatePendingTaskStatusAsync(stId, newStatus);
                    }
                };

                dgv.CellContentClick += async (sender, args) =>
                {
                    if (args.RowIndex < 0 || dgv.Columns[args.ColumnIndex].Name != "ColDelete") return;
                    if (dgv.Rows[args.RowIndex].Tag is int stId)
                    {
                        string stName = dgv.Rows[args.RowIndex].Cells["ColName"].Value?.ToString() ?? "";
                        if (AppDialog.ShowConfirm(dlg, "Xóa cảnh báo vắng",
                            $"Bạn có chắc muốn xóa cảnh báo vắng của học viên '{stName}' khỏi danh sách cần xử lý không?") == DialogResult.OK)
                        {
                            await _dashboardService.DeletePendingTaskAsync(stId);
                            dgv.Rows.RemoveAt(args.RowIndex);
                            _btnPendingTasks.Text = $"Danh sách cần xử lý ({dgv.Rows.Count})";
                        }
                    }
                };

                dgv.ClearSelection();
            });

            dlg.ShowDialog(ParentForm);
            var latestTasks = (await _dashboardService.GetPendingTasksAsync()).ToList();
            _btnPendingTasks.Text = $"Danh sách cần xử lý ({latestTasks.Count})";
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi tải danh sách cần xử lý", ex.Message);
        }
    }

    private async Task ExportDashboardReportAsync()
    {
        try
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất báo cáo tổng quan trung tâm",
                Filter = "Tệp Excel CSV (*.csv)|*.csv",
                FileName = $"BaoCao_TongQuan_ECMS_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (sfd.ShowDialog(ParentForm) != DialogResult.OK)
                return;

            Cursor = Cursors.WaitCursor;
            var kpi = await _dashboardService.GetKpiSummaryAsync();
            var rev = (await _dashboardService.GetMonthlyRevenueTrendAsync(6)).ToList();
            var stu = (await _dashboardService.GetMonthlyStudentGrowthAsync(6)).ToList();
            var ratios = (await _dashboardService.GetCourseAttendanceRatiosAsync()).ToList();
            var schedules = (await _dashboardService.GetTodayAndUpcomingSchedulesAsync()).ToList();

            var sb = new StringBuilder();
            sb.AppendLine("BÁO CÁO TỔNG QUAN ĐIỀU HÀNH TRUNG TÂM ANH NGỮ ECMS");
            sb.AppendLine($"Ngày xuất,{DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine();
            sb.AppendLine("I. CHỈ SỐ ĐIỀU HÀNH TỔNG HỢP (KPI)");
            sb.AppendLine("Chỉ tiêu,Giá trị");
            sb.AppendLine($"Tổng số học viên,{kpi.TotalStudents}");
            sb.AppendLine($"Học viên đang học,{kpi.ActiveStudents}");
            sb.AppendLine($"Lớp đang hoạt động,{kpi.ActiveClasses}");
            sb.AppendLine($"Giáo viên hoạt động,{kpi.ActiveTeachers}");
            sb.AppendLine($"Doanh thu tháng {DateTime.Today.Month},{kpi.CurrentMonthRevenue:0}");
            sb.AppendLine($"Tổng công nợ học phí tồn,{kpi.TotalOutstandingDebt:0}");
            sb.AppendLine($"Tỷ lệ chuyên cần trung bình,{kpi.AverageAttendanceRate:0.0}%");
            sb.AppendLine();

            sb.AppendLine("II. DOANH THU & TĂNG TRƯỞNG HỌC VIÊN 6 THÁNG");
            sb.AppendLine("Tháng,Doanh thu (VNĐ),Tăng trưởng MoM,Tổng học viên lũy kế,Học viên mới trong tháng");
            for (int i = 0; i < rev.Count; i++)
            {
                var r = rev[i];
                var sItem = i < stu.Count ? stu[i] : null;
                decimal revVnd = (decimal)(r.RevenueMillion * 1000000);
                sb.AppendLine($"{r.YearMonth},{revVnd:0},{r.GrowthRateMoM},{sItem?.TotalStudents ?? 0},{sItem?.NewStudents ?? 0}");
            }
            sb.AppendLine();

            sb.AppendLine("III. THỐNG KÊ THEO CHƯƠNG TRÌNH ĐÀO TẠO");
            sb.AppendLine("Khóa học,Số lớp,Số học viên,Chuyên cần TB");
            foreach (var item in ratios)
            {
                sb.AppendLine($"\"{item.CategoryName}\",{item.ClassCount},{item.StudentCount},{item.AttendanceRateFormatted}");
            }
            sb.AppendLine();

            sb.AppendLine("IV. LỊCH HỌC & KHAI GIẢNG");
            sb.AppendLine("Giờ / Ngày,Mã lớp,Tên lớp,Phòng,Giáo viên,Sĩ số,Trạng thái");
            foreach (var sc in schedules)
            {
                sb.AppendLine($"\"{sc.TimeDisplay}\",\"{sc.ClassCode}\",\"{sc.ClassName}\",\"{sc.RoomName}\",\"{sc.TeacherName}\",\"{sc.CapacityFormatted}\",\"{sc.StatusText}\"");
            }

            await File.WriteAllTextAsync(sfd.FileName, sb.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

            Cursor = Cursors.Default;
            if (AppDialog.ShowConfirm(ParentForm, "Xuất báo cáo thành công",
                $"Đã xuất báo cáo tổng quan ra tệp:\n{sfd.FileName}\n\nBạn có muốn mở tệp báo cáo ngay bây giờ không?") == DialogResult.OK)
            {
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            Cursor = Cursors.Default;
            AppDialog.ShowError(ParentForm, "Lỗi xuất báo cáo", ex.Message);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private async void ExecuteQuickSearch()
    {
        string kw = _txtSearch.Text.Trim();
        if (string.IsNullOrEmpty(kw))
        {
            AppDialog.ShowInfo(ParentForm, "Thông báo", "Vui lòng nhập tên hoặc mã học viên, lớp học hoặc khóa học để tìm kiếm nhanh.");
            return;
        }

        Cursor = Cursors.WaitCursor;
        try
        {
            var results = (await _dashboardService.QuickSearchListAsync(kw)).ToList();
            Cursor = Cursors.Default;

            if (results.Count == 0)
            {
                AppDialog.ShowInfo(ParentForm, "Kết quả tìm kiếm", $"Không tìm thấy học viên, lớp học hoặc khóa học nào khớp với từ khóa '{kw}'.");
                return;
            }

            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                $"Kết quả tìm kiếm cho \"{kw}\" ({results.Count} kết quả)",
                "Danh sách học viên, lớp học và khóa học khớp với từ khóa tìm kiếm",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phân loại", FillWeight = 14, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã", FillWeight = 16, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên / Tiêu đề", FillWeight = 24, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Liên hệ / GV / Trình độ", FillWeight = 20, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp / Phòng / Thời lượng", FillWeight = 20, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chi tiết / Học phí", FillWeight = 22, ReadOnly = true });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 14, ReadOnly = true });

                    foreach (var r in results)
                    {
                        string contactOrExtra = !string.IsNullOrWhiteSpace(r.Phone) && r.EntityType == "Học viên"
                            ? $"{r.Phone} · {r.Extra1}"
                            : r.Extra1;
                        dgv.Rows.Add(r.EntityType, r.Code, r.Name, contactOrExtra, r.Extra2, r.Extra3, r.StatusText);
                    }

                    dgv.ClearSelection();
                });
        }
        catch (Exception ex)
        {
            Cursor = Cursors.Default;
            AppDialog.ShowError(ParentForm, "Lỗi tìm kiếm", ex.Message);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        PerformResponsiveLayout();
    }

    private void PerformResponsiveLayout()
    {
        if (_pnlContentWrapper == null || _btnExport == null || _btnPendingTasks == null || _pnlFilterToolbar == null || _cardRevenue == null || _cardSchedule == null)
            return;

        int availableW = Math.Max(1000, ClientSize.Width);
        int paddingSide = 24;
        int contentW = availableW - (paddingSide * 2);

        _pnlContentWrapper.Width = availableW;
        _pnlContentWrapper.Height = 840;

        // 1. Header Buttons
        _btnExport.Location = new Point(paddingSide + contentW - _btnExport.Width, 34);
        _btnPendingTasks.Location = new Point(_btnExport.Left - _btnPendingTasks.Width - 12, 34);

        // 2. Filter Toolbar Panel (Chỉ còn ô tìm kiếm & nút tìm kiếm, kéo giãn cân đối)
        _pnlFilterToolbar.Location = new Point(paddingSide, 88);
        _pnlFilterToolbar.Size = new Size(contentW, 50);
        if (_btnSearch != null && _txtSearch != null)
        {
            _btnSearch.Location = new Point(_pnlFilterToolbar.Width - _btnSearch.Width - 12, 8);
            _txtSearch.Location = new Point(12, 8);
            _txtSearch.Size = new Size(Math.Max(280, _btnSearch.Left - 24), 34);
        }

        // 3. Row of 6 KPI Cards
        int kpiY = 150;
        int kpiH = 82;
        int kpiGap = 12;
        int totalKpiGaps = 5 * kpiGap;
        int kpiW = (contentW - totalKpiGaps) / 6;

        AppCard[] kpiCards = { _cardKpi1, _cardKpi2, _cardKpi3, _cardKpi4, _cardKpi5, _cardKpi6 };
        for (int i = 0; i < 6; i++)
        {
            if (kpiCards[i] != null)
            {
                int x = paddingSide + i * (kpiW + kpiGap);
                int w = (i == 5) ? (paddingSide + contentW - x) : kpiW;
                kpiCards[i].Location = new Point(x, kpiY);
                kpiCards[i].Size = new Size(w, kpiH);
            }
        }

        // 4. Middle 3 Cards (Doanh thu - Học viên - Chuyên cần)
        int midY = 244;
        int midH = 240;
        int midGap = 14;
        int totalMidGaps = 2 * midGap;
        int remainingMidW = contentW - totalMidGaps;

        int midW1 = (int)(remainingMidW * 0.365);
        int midW2 = (int)(remainingMidW * 0.310);
        int midW3 = remainingMidW - midW1 - midW2;

        // Card Doanh thu
        _cardRevenue.Location = new Point(paddingSide, midY);
        _cardRevenue.Size = new Size(midW1, midH);
        _btnRevenueDetail.Location = new Point(_cardRevenue.Width - _btnRevenueDetail.Width - 14, 12);
        _btnRevenueDetail.BringToFront();
        _chartRevenue.Size = new Size(midW1 - 28, midH - 56);

        // Card Học viên
        _cardStudents.Location = new Point(paddingSide + midW1 + midGap, midY);
        _cardStudents.Size = new Size(midW2, midH);
        _btnStudentsDetail.Location = new Point(_cardStudents.Width - _btnStudentsDetail.Width - 14, 12);
        _btnStudentsDetail.BringToFront();
        _chartStudents.Size = new Size(midW2 - 28, midH - 56);

        // Card Chuyên cần
        int midX3 = paddingSide + midW1 + midGap + midW2 + midGap;
        _cardAttendance.Location = new Point(midX3, midY);
        _cardAttendance.Size = new Size(midW3, midH);
        _btnAttDetail.Location = new Point(_cardAttendance.Width - _btnAttDetail.Width - 14, 12);
        _btnAttDetail.BringToFront();
        _dgvRatio.Size = new Size(midW3 - 28, midH - 86);

        // 5. Bottom Card: Lịch hôm nay & Sắp khai giảng
        int btmY = 496;
        int btmH = 300;
        _cardSchedule.Location = new Point(paddingSide, btmY);
        _cardSchedule.Size = new Size(contentW, btmH);
        _btnSchedDetail.Location = new Point(_cardSchedule.Width - _btnSchedDetail.Width - 14, 12);
        _btnSchedDetail.BringToFront();
        _dgvSchedule.Size = new Size(contentW - 32, btmH - 60);
    }
}
