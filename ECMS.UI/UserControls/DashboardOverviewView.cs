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
    private Label _lblNoScheduleToday = null!;

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

        // Đổi tiêu đề thành "Lịch học hôm nay" và tạo nhãn hiển thị khi hôm nay không có lịch học
        _lblSchedTitle.Text = "Lịch học hôm nay";
        _lblNoScheduleToday = new Label
        {
            Text = "Hôm nay chưa có lịch học nào.",
            Font = new Font("Segoe UI", 10F, FontStyle.Italic),
            ForeColor = Color.FromArgb(100, 116, 139),
            TextAlign = ContentAlignment.MiddleCenter,
            AutoSize = false,
            Visible = false,
            BackColor = Color.White
        };
        _cardSchedule.Controls.Add(_lblNoScheduleToday);
        _lblNoScheduleToday.BringToFront();
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

            // Cập nhật tổng số mục cần xử lý (HV vắng quá buổi + HV công nợ quá hạn)
            var pendingTasks = (await _dashboardService.GetPendingTasksAsync()).ToList();
            var overdueDebts = (await _dashboardService.GetOverdueDebtAlertsAsync()).ToList();
            _btnPendingTasks.Text = $"Danh sách cần xử lý ({pendingTasks.Count + overdueDebts.Count})";

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

            // 5. Nạp Bảng Lịch học hôm nay (lọc đúng ngày hôm nay từ ClassSchedules)
            var schedules = (await _dashboardService.GetTodaySchedulesAsync()).ToList();
            _dgvSchedule.Columns.Clear();
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ học", FillWeight = 18 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 20 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 12 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 24 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 10 });
            _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 16 });
            _dgvSchedule.Rows.Clear();
            foreach (var s in schedules)
            {
                _dgvSchedule.Rows.Add(s.TimeDisplay, s.ClassCode, s.RoomName, s.TeacherName, s.CapacityFormatted, s.StatusText);
            }
            _dgvSchedule.ClearSelection();
            _dgvSchedule.CurrentCell = null;

            bool hasTodaySchedule = schedules.Count > 0;
            _dgvSchedule.Visible = hasTodaySchedule;
            _lblNoScheduleToday.Visible = !hasTodaySchedule;
            if (!hasTodaySchedule) _lblNoScheduleToday.BringToFront();
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

        // 4. Xem chi tiết biểu đồ doanh thu (đơn giản, rõ nghĩa từ Payments & Enrollments)
        _btnRevenueDetail.Click += async (s, e) =>
        {
            try
            {
                var revList = (await _dashboardService.GetMonthlyRevenueTrendAsync(6)).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Chi tiết doanh thu 6 tháng gần nhất",
                    "Dữ liệu thực thu từ các phiếu thu học phí trong từng tháng",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tháng", FillWeight = 30, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số phiếu thu", FillWeight = 30, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng thực thu", FillWeight = 40, ReadOnly = true });

                        foreach (var r in revList)
                        {
                            string monthDisplay = DateTime.TryParseExact(r.YearMonth, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out var dt)
                                ? dt.ToString("MM/yyyy")
                                : r.YearMonth;
                            dgv.Rows.Add(
                                $"Tháng {monthDisplay}",
                                $"{r.PaymentCount} phiếu",
                                $"{r.ActualRevenueAmount:N0} đ");
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết doanh thu", ex.Message);
            }
        };

        // 5. Xem chi tiết biểu đồ tăng trưởng học viên 6 tháng (đơn giản, rõ nghĩa từ Students)
        _btnStudentsDetail.Click += async (s, e) =>
        {
            try
            {
                var stuList = (await _dashboardService.GetMonthlyStudentGrowthAsync(6)).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Chi tiết tăng trưởng học viên 6 tháng gần nhất",
                    "Thống kê hồ sơ học viên mới, tổng tích lũy, đang học và đã lưu trữ theo tháng",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tháng", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên mới", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng tích lũy", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đang học", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đã lưu trữ", FillWeight = 20, ReadOnly = true });

                        foreach (var st in stuList)
                        {
                            string monthDisplay = DateTime.TryParseExact(st.YearMonth, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out var dt)
                                ? dt.ToString("MM/yyyy")
                                : st.YearMonth;
                            dgv.Rows.Add(
                                $"Tháng {monthDisplay}",
                                $"{st.NewStudents}",
                                $"{st.TotalStudents}",
                                $"{st.ActiveCount}",
                                $"{st.ArchivedCount}");
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết học viên", ex.Message);
            }
        };

        // 6. Xem chi tiết chuyên cần lớp học (đơn giản, rõ nghĩa từ Classes & AttendanceRecords)
        _btnAttDetail.Click += async (s, e) =>
        {
            try
            {
                var attList = (await _dashboardService.GetClassAttendanceDetailsAsync()).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    "Chi tiết chuyên cần theo từng lớp học",
                    "Số liệu thực tế từ bảng Lớp học và Chuyên cần",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", FillWeight = 14, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên lớp", FillWeight = 22, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khóa học", FillWeight = 22, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 10, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chuyên cần (%)", FillWeight = 12, ReadOnly = true });

                        foreach (var item in attList)
                        {
                            dgv.Rows.Add(item.ClassCode, item.ClassName, item.CourseName, item.TeacherName, item.CapacityFormatted, item.AttendanceRateFormatted);
                        }

                        dgv.ClearSelection();
                    });
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(ParentForm, "Lỗi tải chi tiết chuyên cần", ex.Message);
            }
        };

        // 7. Xem chi tiết Lịch học hôm nay
        _btnSchedDetail.Click += async (s, e) =>
        {
            try
            {
                var schedList = (await _dashboardService.GetTodaySchedulesAsync()).ToList();
                QuickDetailGridDialog.ShowDialog(
                    ParentForm,
                    $"Chi tiết lịch học hôm nay ({DateTime.Today:dd/MM/yyyy})",
                    "Danh sách các buổi học diễn ra trong ngày hôm nay từ bảng ClassSchedules",
                    dgv =>
                    {
                        dgv.Columns.Clear();
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ học", FillWeight = 16, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", FillWeight = 14, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên lớp", FillWeight = 22, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 10, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 20, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 8, ReadOnly = true });
                        dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 14, ReadOnly = true });

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
            var overdueDebts = (await _dashboardService.GetOverdueDebtAlertsAsync()).ToList();

            using var dlg = new Form
            {
                Text = "Danh sách cần xử lý - ECMS",
                Size = new Size(1120, 660),
                MinimumSize = new Size(860, 500),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(248, 250, 252),
                Font = new Font("Segoe UI", 9F),
                FormBorderStyle = FormBorderStyle.Sizable,
                MaximizeBox = true
            };

            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 64, BackColor = Color.White, Padding = new Padding(20, 14, 20, 10) };
            var lblHead = new Label
            {
                Text = $"Danh sách cần xử lý ({tasks.Count + overdueDebts.Count} mục)",
                Font = new Font("Segoe UI", 13.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                AutoSize = true,
                Location = new Point(20, 16)
            };
            pnlTop.Controls.Add(lblHead);

            var tabs = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 9.5F), Padding = new Point(16, 8) };
            var tabAbsent = new TabPage($"Học viên vắng quá buổi ({tasks.Count})") { Padding = new Padding(14), BackColor = Color.FromArgb(248, 250, 252) };
            var tabDebt = new TabPage($"Công nợ quá hạn thanh toán ({overdueDebts.Count})") { Padding = new Padding(14), BackColor = Color.FromArgb(248, 250, 252) };

            // --- TAB 1: Học viên vắng quá số buổi ---
            var dgvAbsent = new AppDataGrid { Dock = DockStyle.Fill, ReadOnly = false, ScrollBars = ScrollBars.Both, AllowUserToResizeColumns = true };
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStt", HeaderText = "STT", FillWeight = 7, ReadOnly = true });
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã HV", FillWeight = 13, ReadOnly = true });
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColName", HeaderText = "Họ và tên", FillWeight = 22, ReadOnly = true });
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColPhone", HeaderText = "Điện thoại", FillWeight = 14, ReadOnly = true });
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClass", HeaderText = "Lớp học", FillWeight = 13, ReadOnly = true });
            dgvAbsent.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColAbsent", HeaderText = "Số buổi vắng", FillWeight = 14, ReadOnly = true });

            var colStatus = new DataGridViewComboBoxColumn
            {
                Name = "ColStatus",
                HeaderText = "Trạng thái xử lý",
                FillWeight = 16,
                ReadOnly = false,
                FlatStyle = FlatStyle.Flat
            };
            colStatus.Items.AddRange("Chưa xử lý", "Đã xử lý");
            dgvAbsent.Columns.Add(colStatus);

            var colDelete = new DataGridViewButtonColumn
            {
                Name = "ColDelete",
                HeaderText = "Xóa",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                FillWeight = 10,
                FlatStyle = FlatStyle.Flat
            };
            colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
            dgvAbsent.Columns.Add(colDelete);

            foreach (var t in tasks)
            {
                int rowIdx = dgvAbsent.Rows.Add(
                    t.Index.ToString(), t.StudentCode, t.StudentName, t.Phone, t.ClassCode,
                    $"{t.AbsentCount} / {t.MaxAllowedAbsences} buổi",
                    t.HandlingStatus == "Đã xử lý" ? "Đã xử lý" : "Chưa xử lý");
                dgvAbsent.Rows[rowIdx].Tag = t.StudentId;
            }

            dgvAbsent.CurrentCellDirtyStateChanged += (sender, args) =>
            {
                if (dgvAbsent.IsCurrentCellDirty && dgvAbsent.CurrentCell is DataGridViewComboBoxCell)
                    dgvAbsent.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvAbsent.CellValueChanged += async (sender, args) =>
            {
                if (args.RowIndex < 0 || dgvAbsent.Columns[args.ColumnIndex].Name != "ColStatus") return;
                if (dgvAbsent.Rows[args.RowIndex].Tag is int stId)
                {
                    string newStatus = dgvAbsent.Rows[args.RowIndex].Cells["ColStatus"].Value?.ToString() ?? "Chưa xử lý";
                    await _dashboardService.UpdatePendingTaskStatusAsync(stId, newStatus);
                }
            };
            dgvAbsent.CellContentClick += async (sender, args) =>
            {
                if (args.RowIndex < 0 || dgvAbsent.Columns[args.ColumnIndex].Name != "ColDelete") return;
                if (dgvAbsent.Rows[args.RowIndex].Tag is int stId)
                {
                    string stName = dgvAbsent.Rows[args.RowIndex].Cells["ColName"].Value?.ToString() ?? "";
                    if (AppDialog.ShowConfirm(dlg, "Xóa cảnh báo vắng",
                        $"Bạn có chắc muốn xóa cảnh báo vắng của học viên '{stName}' khỏi danh sách cần xử lý không?") == DialogResult.OK)
                    {
                        await _dashboardService.DeletePendingTaskAsync(stId);
                        dgvAbsent.Rows.RemoveAt(args.RowIndex);
                        tabAbsent.Text = $"Học viên vắng quá buổi ({dgvAbsent.Rows.Count})";
                        lblHead.Text = $"Danh sách cần xử lý ({dgvAbsent.Rows.Count + overdueDebts.Count} mục)";
                    }
                }
            };
            tabAbsent.Controls.Add(dgvAbsent);

            // --- TAB 2: Học viên công nợ quá hạn thanh toán ---
            var dgvDebt = new AppDataGrid { Dock = DockStyle.Fill, ReadOnly = true, ScrollBars = ScrollBars.Both, AllowUserToResizeColumns = true };
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", FillWeight = 7, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã HV", FillWeight = 13, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 22, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điện thoại", FillWeight = 14, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp", FillWeight = 12, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số tiền còn nợ", FillWeight = 16, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hạn thanh toán", FillWeight = 14, ReadOnly = true });
            dgvDebt.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quá hạn", FillWeight = 12, ReadOnly = true });

            int dIdx = 1;
            foreach (var d in overdueDebts)
            {
                dgvDebt.Rows.Add(dIdx++, d.StudentCode, d.StudentName, d.Phone, d.ClassCode, $"{d.BalanceDue:N0} đ", d.DueDate, $"{d.DaysOverdue} ngày");
            }
            tabDebt.Controls.Add(dgvDebt);

            tabs.TabPages.Add(tabAbsent);
            tabs.TabPages.Add(tabDebt);

            var pnlContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16, 10, 16, 16) };
            pnlContainer.Controls.Add(tabs);

            dlg.Controls.Add(pnlContainer);
            dlg.Controls.Add(pnlTop);
            dlg.ShowDialog(ParentForm);

            var latestTasks = (await _dashboardService.GetPendingTasksAsync()).ToList();
            var latestDebts = (await _dashboardService.GetOverdueDebtAlertsAsync()).ToList();
            _btnPendingTasks.Text = $"Danh sách cần xử lý ({latestTasks.Count + latestDebts.Count})";
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
            AppDialog.ShowInfo(ParentForm, "Thông báo", "Vui lòng nhập tên hoặc mã học viên, khóa học hoặc lớp học để tìm kiếm nhanh.");
            return;
        }

        Cursor = Cursors.WaitCursor;
        try
        {
            var data = await _dashboardService.QuickSearchCategorizedAsync(kw);
            Cursor = Cursors.Default;

            if (data.TotalCount == 0)
            {
                AppDialog.ShowInfo(ParentForm, "Kết quả tìm kiếm", $"Không tìm thấy học viên, khóa học hoặc lớp học nào khớp với từ khóa '{kw}'.");
                return;
            }

            using var dlg = new Form
            {
                Text = $"Kết quả tìm kiếm cho \"{kw}\" ({data.TotalCount} kết quả)",
                Size = new Size(1100, 620),
                MinimumSize = new Size(820, 480),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(248, 250, 252),
                Font = new Font("Segoe UI", 9F),
                FormBorderStyle = FormBorderStyle.Sizable,
                MaximizeBox = true
            };

            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.White, Padding = new Padding(20, 14, 20, 10) };
            pnlTop.Controls.Add(new Label
            {
                Text = $"Kết quả tìm kiếm cho \"{kw}\" ({data.TotalCount} kết quả)",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                AutoSize = true,
                Location = new Point(20, 16)
            });

            var tabs = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 9.5F), Padding = new Point(16, 8) };

            // Tab 1: Học viên
            var tabStu = new TabPage($"Học viên ({data.Students.Count})") { Padding = new Padding(12), BackColor = Color.FromArgb(248, 250, 252) };
            var dgvStu = new AppDataGrid { Dock = DockStyle.Fill, ScrollBars = ScrollBars.Both, AllowUserToResizeColumns = true };
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã HV", FillWeight = 14 });
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 24 });
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điện thoại", FillWeight = 16 });
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp hiện tại", FillWeight = 16 });
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Công nợ", FillWeight = 15 });
            dgvStu.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 15 });
            foreach (var st in data.Students)
            {
                dgvStu.Rows.Add(st.StudentCode, st.FullName, st.Phone, st.ClassName, st.BalanceDue > 0 ? $"{st.BalanceDue:N0} đ" : "0 đ", st.StatusText);
            }
            tabStu.Controls.Add(dgvStu);

            // Tab 2: Khóa học
            var tabCo = new TabPage($"Khóa học ({data.Courses.Count})") { Padding = new Padding(12), BackColor = Color.FromArgb(248, 250, 252) };
            var dgvCo = new AppDataGrid { Dock = DockStyle.Fill, ScrollBars = ScrollBars.Both, AllowUserToResizeColumns = true };
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã khóa học", FillWeight = 14 });
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên khóa học", FillWeight = 28 });
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trình độ", FillWeight = 16 });
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số buổi", FillWeight = 12 });
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học phí chuẩn", FillWeight = 16 });
            dgvCo.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 14 });
            foreach (var co in data.Courses)
            {
                dgvCo.Rows.Add(co.CourseCode, co.CourseName, co.Level, $"{co.TotalSessions} buổi", $"{co.BaseTuitionFee:N0} đ", co.StatusText);
            }
            tabCo.Controls.Add(dgvCo);

            // Tab 3: Lớp học
            var tabCl = new TabPage($"Lớp học ({data.Classes.Count})") { Padding = new Padding(12), BackColor = Color.FromArgb(248, 250, 252) };
            var dgvCl = new AppDataGrid { Dock = DockStyle.Fill, ScrollBars = ScrollBars.Both, AllowUserToResizeColumns = true };
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", FillWeight = 14 });
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên lớp", FillWeight = 22 });
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khóa học", FillWeight = 20 });
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 18 });
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 10 });
            dgvCl.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 16 });
            foreach (var cl in data.Classes)
            {
                dgvCl.Rows.Add(cl.ClassCode, cl.ClassName, cl.CourseName, cl.TeacherName, cl.CapacityFormatted, cl.StatusText);
            }
            tabCl.Controls.Add(dgvCl);

            tabs.TabPages.AddRange(new[] { tabStu, tabCo, tabCl });
            if (data.Students.Count > 0) tabs.SelectedIndex = 0;
            else if (data.Courses.Count > 0) tabs.SelectedIndex = 1;
            else tabs.SelectedIndex = 2;

            var pnlWrap = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16, 10, 16, 16) };
            pnlWrap.Controls.Add(tabs);

            dlg.Controls.Add(pnlWrap);
            dlg.Controls.Add(pnlTop);
            dlg.ShowDialog(ParentForm);
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

        // 4. Tầng 2: 2 Biểu đồ nằm ngang bằng nhau 50% / 50% (Doanh thu - Tăng trưởng học viên)
        int midY = 244;
        int midH = 250;
        int midGap = 14;
        int halfW = (contentW - midGap) / 2;
        int rightChartW = contentW - midGap - halfW;

        // Card Doanh thu (Trái)
        _cardRevenue.Location = new Point(paddingSide, midY);
        _cardRevenue.Size = new Size(halfW, midH);
        _btnRevenueDetail.Location = new Point(_cardRevenue.Width - _btnRevenueDetail.Width - 14, 12);
        _btnRevenueDetail.BringToFront();
        _chartRevenue.Size = new Size(halfW - 28, midH - 56);

        // Card Tăng trưởng học viên (Phải)
        _cardStudents.Location = new Point(paddingSide + halfW + midGap, midY);
        _cardStudents.Size = new Size(rightChartW, midH);
        _btnStudentsDetail.Location = new Point(_cardStudents.Width - _btnStudentsDetail.Width - 14, 12);
        _btnStudentsDetail.BringToFront();
        _chartStudents.Size = new Size(rightChartW - 28, midH - 56);

        // 5. Tầng 3: Chuyên cần lớp học (Trái 36%) & Lịch học hôm nay (Phải 64%)
        int btmY = 508;
        int btmH = 310;
        int attW = (int)((contentW - midGap) * 0.36);
        int schedW = contentW - midGap - attW;

        // Card Chuyên cần lớp học
        _cardAttendance.Location = new Point(paddingSide, btmY);
        _cardAttendance.Size = new Size(attW, btmH);
        _btnAttDetail.Location = new Point(_cardAttendance.Width - _btnAttDetail.Width - 14, 12);
        _btnAttDetail.BringToFront();
        _dgvRatio.Size = new Size(attW - 28, btmH - 92);

        // Card Lịch học hôm nay
        _cardSchedule.Location = new Point(paddingSide + attW + midGap, btmY);
        _cardSchedule.Size = new Size(schedW, btmH);
        _btnSchedDetail.Location = new Point(_cardSchedule.Width - _btnSchedDetail.Width - 14, 12);
        _btnSchedDetail.BringToFront();
        _dgvSchedule.Size = new Size(schedW - 32, btmH - 60);
        if (_lblNoScheduleToday != null)
        {
            _lblNoScheduleToday.Location = new Point(16, 52);
            _lblNoScheduleToday.Size = new Size(Math.Max(200, schedW - 32), btmH - 68);
        }
    }
}
