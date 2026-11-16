using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// Màn hình Tổng quan điều hành trung tâm (Dashboard Overview)
/// Hỗ trợ thiết kế kéo thả trực quan 100% trong Visual Studio / Rider Form Designer
/// và bố cục co giãn tự động (Responsive Layout) khi chạy thực tế.
/// </summary>
public partial class DashboardOverviewView : UserControl
{
    public DashboardOverviewView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        Dock = DockStyle.Fill;
        SetupFilters();
        PopulateCharts();
        PopulateData();
        WireEvents();
    }

    private void SetupFilters()
    {
        if (_cboMonth.Items.Count > 0 && _cboMonth.SelectedIndex < 0)
            _cboMonth.SelectedIndex = 0;

        if (_cboCourse.Items.Count > 0 && _cboCourse.SelectedIndex < 0)
            _cboCourse.SelectedIndex = 0;
    }

    private void WireEvents()
    {
        // 7. Nút Xuất báo cáo (xử lý logic sau, hiển thị thông báo tạm)
        _btnExport.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất báo cáo", "Chức năng xuất báo cáo tổng hợp sẽ được hoàn thiện trong giai đoạn kế tiếp.");
        };

        // 6. Nút "Danh sách cần xử lý": Mở DataGridView các việc cần xử lý ngay
        _btnPendingTasks.Click += (s, e) =>
        {
            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                "Danh sách các việc cần xử lý ngay trong ca trực",
                "Phân loại các cảnh báo khẩn về học phí, điểm danh, đề thi, chứng chỉ và cơ sở vật chất",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", FillWeight = 10 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hạng mục cần xử lý ↑", FillWeight = 42 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đối tượng liên quan", FillWeight = 26 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mức độ", FillWeight = 18 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hạn xử lý", FillWeight = 20 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hành động đề xuất", FillWeight = 34 });

                    dgv.Rows.Add("1", "Học phí đến hạn trong tuần", "27 học viên (Tổng: 42,9 tr)", "Khẩn cấp", "31/10/2026", "Gửi SMS & Gọi điện nhắc phí");
                    dgv.Rows.Add("2", "Nghỉ học quá 20% số buổi", "3 học viên (Lớp IELTS-F01 & F02)", "Cảnh báo", "Hôm nay", "Liên hệ trực tiếp phụ huynh");
                    dgv.Rows.Add("3", "Duyệt đề kiểm tra giữa khóa", "4 lớp (IELTS Intensive, TOEIC 500)", "Cần làm", "02/11/2026", "Chuyển Trưởng phòng đào tạo");
                    dgv.Rows.Add("4", "Học viên đủ điều kiện cấp chứng chỉ", "16 học viên lớp IELTS-F02", "Bình thường", "05/11/2026", "In và trình ký chứng chỉ");
                    dgv.Rows.Add("5", "Giáo viên đăng ký nghỉ bù tuần tới", "2 giáo viên (Thầy Hoàng, Cô Yến)", "Cần làm", "01/11/2026", "Sắp xếp giáo viên dạy thay");
                    dgv.Rows.Add("6", "Kiểm tra máy chiếu & âm thanh", "Phòng P102 & P203", "Cảnh báo", "17:00 hôm nay", "Bộ phận kỹ thuật kiểm tra");

                    dgv.ClearSelection();
                });
        };

        // 1.2 Tìm kiếm nhanh học viên, lớp học, khóa học -> Truy xuất thông tin (Chế độ chỉ đọc)
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

        // 3. Xem chi tiết biểu đồ doanh thu dạng DataGridView
        _btnRevenueDetail.Click += (s, e) =>
        {
            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                "Báo cáo chi tiết doanh thu theo tháng (Năm 2026)",
                "Dữ liệu doanh thu thực thu, chỉ tiêu kinh doanh và số học viên mới nhập học",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian ↑", FillWeight = 18 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Doanh thu thực thu", FillWeight = 26 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chỉ tiêu đề ra", FillWeight = 24 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ đạt (%)", FillWeight = 18 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số HV mới", FillWeight = 16 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tăng trưởng MoM", FillWeight = 18 });

                    dgv.Rows.Add("Tháng 05/2026", "112.000.000đ", "110.000.000đ", "101,8%", "28 học viên", "+8,4%");
                    dgv.Rows.Add("Tháng 06/2026", "138.000.000đ", "130.000.000đ", "106,1%", "35 học viên", "+23,2%");
                    dgv.Rows.Add("Tháng 07/2026", "145.000.000đ", "140.000.000đ", "103,5%", "36 học viên", "+5,1%");
                    dgv.Rows.Add("Tháng 08/2026", "154.000.000đ", "150.000.000đ", "102,6%", "39 học viên", "+6,2%");
                    dgv.Rows.Add("Tháng 09/2026", "166.000.000đ", "160.000.000đ", "103,7%", "42 học viên", "+7,8%");
                    dgv.Rows.Add("Tháng 10/2026", "186.500.000đ", "165.000.000đ", "113,0%", "48 học viên", "+12,3% (Kỷ lục)");

                    dgv.ClearSelection();
                });
        };

        // 3. Xem chi tiết biểu đồ tăng trưởng học viên dạng DataGridView
        _btnStudentsDetail.Click += (s, e) =>
        {
            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                "Báo cáo chi tiết tăng trưởng học viên toàn trung tâm",
                "Số lượng học viên đang học, học viên mới và tỷ lệ tái đăng ký theo từng tháng",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian ↑", FillWeight = 20 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng học viên", FillWeight = 22 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đang theo học", FillWeight = 22 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tuyển mới", FillWeight = 18 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tốt nghiệp", FillWeight = 18 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ duy trì", FillWeight = 20 });

                    dgv.Rows.Add("Tháng 07/2026", "380 học viên", "296 học viên", "36 học viên", "24 học viên", "82,5%");
                    dgv.Rows.Add("Tháng 08/2026", "398 học viên", "310 học viên", "39 học viên", "25 học viên", "83,8%");
                    dgv.Rows.Add("Tháng 09/2026", "415 học viên", "326 học viên", "42 học viên", "26 học viên", "84,1%");
                    dgv.Rows.Add("Tháng 10/2026", "428 học viên", "348 học viên", "48 học viên", "26 học viên", "85,6%");

                    dgv.ClearSelection();
                });
        };

        // 4. Xem chi tiết chuyên cần lớp học dạng DataGridView
        _btnAttDetail.Click += (s, e) =>
        {
            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                "Báo cáo chi tiết chuyên cần theo từng lớp học",
                "Theo dõi tỷ lệ đi học, số buổi vắng và học viên cần lưu ý",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp ↑", FillWeight = 20 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khóa học", FillWeight = 28 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 26 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 14 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số buổi", FillWeight = 16 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chuyên cần", FillWeight = 20 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tình trạng", FillWeight = 20 });

                    dgv.Rows.Add("IELTS-F01", "IELTS Foundation", "Nguyễn Hoàng Anh", "18/20", "12/24", "94,5%", "Tốt");
                    dgv.Rows.Add("IELTS-F02", "IELTS Foundation", "Trần Gia Bảo", "16/20", "20/24", "93,2%", "Tốt");
                    dgv.Rows.Add("IELTS-I01", "IELTS Intensive", "Lê Thị Thu", "14/15", "08/30", "95,0%", "Rất tốt");
                    dgv.Rows.Add("TOEIC-500", "TOEIC 500+", "Lê Hoàng Yến", "22/25", "15/20", "91,2%", "Bình thường");
                    dgv.Rows.Add("COM-B01", "Giao tiếp quốc tế", "Đặng Minh Trí", "15/18", "06/16", "89,5%", "Cần nhắc nhở");

                    dgv.ClearSelection();
                });
        };

        // 5. Xem chi tiết Lịch hôm nay & Sắp khai giảng dạng DataGridView
        _btnSchedDetail.Click += (s, e) =>
        {
            QuickDetailGridDialog.ShowDialog(
                ParentForm,
                "Bảng chi tiết lịch học & khai giảng toàn hệ thống",
                "Lịch trình đầy đủ các phòng học, ca học trong ngày và kế hoạch khai giảng tuần tới",
                dgv =>
                {
                    dgv.Columns.Clear();
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / Ngày ↑", FillWeight = 22 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 22 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 14 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 26 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 16 });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", FillWeight = 20 });

                    dgv.Rows.Add("17:30 · Hôm nay", "IELTS-F01", "P201", "Nguyễn Hoàng Anh", "18/20", "Đang học");
                    dgv.Rows.Add("18:00 · Hôm nay", "IELTS-F02", "P202", "Trần Gia Bảo", "16/20", "Đang học");
                    dgv.Rows.Add("19:30 · Hôm nay", "TOEIC-500", "P101", "Lê Hoàng Yến", "22/25", "Đang học");
                    dgv.Rows.Add("19:45 · Hôm nay", "COM-B01", "P102", "Đặng Minh Trí", "15/18", "Đang học");
                    dgv.Rows.Add("02/11 · Sắp mở", "IELTS-I02", "P203", "Chưa phân công", "12/15", "Chờ mở");
                    dgv.Rows.Add("05/11 · Sắp mở", "TOEIC-650", "P103", "Trần Minh Tuấn", "18/20", "Chờ mở");

                    dgv.ClearSelection();
                });
        };
    }

    private void ExecuteQuickSearch()
    {
        string kw = _txtSearch.Text.Trim();
        if (string.IsNullOrEmpty(kw))
        {
            MessageBox.Show("Vui lòng nhập tên hoặc mã học viên, lớp học hoặc khóa học để tìm kiếm nhanh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string upper = kw.ToUpperInvariant();

        // Kiểm tra loại thực thể để mở hộp thoại truy xuất thông tin chi tiết (Chỉ đọc)
        if (upper.StartsWith("HV") || upper.Contains("ANH") || upper.Contains("HỌC VIÊN") || upper.Contains("MINH") || upper.Contains("NAM") || upper.Contains("LINH"))
        {
            QuickSearchDetailDialog.ShowStudent(
                ParentForm,
                "Nguyễn Minh Anh",
                "HV-0241",
                "0987 654 321",
                "minhanh.nguyen@email.com",
                "IELTS-F01 (Phòng P201)",
                "95,8% (23/24 buổi có mặt)",
                "Đã hoàn thành 100% (0đ nợ)");
        }
        else if (upper.StartsWith("LH") || upper.Contains("IELTS-") || upper.Contains("TOEIC-") || upper.Contains("COM-") || upper.Contains("LỚP"))
        {
            QuickSearchDetailDialog.ShowClass(
                ParentForm,
                "IELTS-F01",
                "IELTS Foundation Khóa 24",
                "IELTS Foundation",
                "Nguyễn Hoàng Anh (ThS. Ngôn ngữ Anh)",
                "Phòng P201 · Tầng 2",
                "Thứ 3 - Thứ 6 (18:00 - 20:00)",
                "18 / 20 học viên",
                "Đang học (Buổi 12/24)");
        }
        else if (upper.StartsWith("KH") || upper.Contains("KHÓA") || upper.Contains("FOUNDATION") || upper.Contains("INTENSIVE") || upper.Contains("GIAO TIẾP"))
        {
            QuickSearchDetailDialog.ShowCourse(
                ParentForm,
                "KH-IELTS-F",
                "IELTS Foundation (Nền tảng IELTS)",
                "Đầu vào 3.5+  →  Đầu ra cam kết 5.0 - 5.5",
                "24 buổi (48 giờ học trên lớp + 12 giờ tự học có hướng dẫn)",
                "6.800.000 VNĐ / khóa",
                "Nắm vững 4 kỹ năng Nghe - Nói - Đọc - Viết ở định dạng đề IELTS");
        }
        else
        {
            // Mặc định hiển thị thông tin học viên tìm thấy phù hợp nhất
            QuickSearchDetailDialog.ShowStudent(
                ParentForm,
                kw,
                "HV-0250",
                "0912 345 678",
                "student.ecms@email.com",
                "IELTS-F02 (Phòng P202)",
                "92,0% (Chuyên cần tốt)",
                "Còn nợ đợt 2: 1.200.000đ (Hạn 15/11)");
        }
    }

    private void PopulateCharts()
    {
        // 3. Dữ liệu biểu đồ doanh thu (Các cột nằm trọn trong khung, không tràn mép)
        _chartRevenue.Items = new List<BarItem>
        {
            new("T5", 112, "112"),
            new("T6", 138, "138"),
            new("T7", 145, "145"),
            new("T8", 154, "154"),
            new("T9", 166, "166"),
            new("T10", 186.5, "186.5", isHighlight: true)
        };

        // 3. Dữ liệu biểu đồ học viên
        _chartStudents.Items = new List<BarItem>
        {
            new("T7", 296, "296"),
            new("T8", 310, "310"),
            new("T9", 326, "326"),
            new("T10", 348, "348", isHighlight: true)
        };
    }

    private void PopulateData()
    {
        // 4. Chuyên cần & lớp học (DataGridView)
        _dgvRatio.Columns.Clear();
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nhóm lớp ↑", FillWeight = 42 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lớp", FillWeight = 28 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên", FillWeight = 30 });
        _dgvRatio.Rows.Add("IELTS", "10", "204");
        _dgvRatio.Rows.Add("TOEIC", "5", "96");
        _dgvRatio.Rows.Add("Giao tiếp", "3", "48");
        _dgvRatio.ClearSelection();
        _dgvRatio.CurrentCell = null;

        // 5. Lịch hôm nay & sắp khai giảng (DataGridView toàn chiều rộng)
        _dgvSchedule.Columns.Clear();
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / ngày ↑", FillWeight = 20 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 24 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng", FillWeight = 14 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên phụ trách", FillWeight = 26 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sĩ số", FillWeight = 16 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái lớp", FillWeight = 18 });
        _dgvSchedule.Rows.Add("17:30 · Hôm nay", "IELTS-F01", "P201", "Nguyễn Hoàng Anh", "18/20", "Đang học");
        _dgvSchedule.Rows.Add("18:00 · Hôm nay", "IELTS-F02", "P202", "Trần Gia Bảo", "16/20", "Đang học");
        _dgvSchedule.Rows.Add("19:30 · Hôm nay", "TOEIC-500", "P101", "Lê Hoàng Yến", "22/25", "Đang học");
        _dgvSchedule.Rows.Add("02/11 · Sắp mở", "IELTS-I01", "P203", "Chưa phân công", "12/15", "Chờ mở");
        _dgvSchedule.ClearSelection();
        _dgvSchedule.CurrentCell = null;
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

        // 2. Filter Toolbar Panel
        _pnlFilterToolbar.Location = new Point(paddingSide, 88);
        _pnlFilterToolbar.Size = new Size(contentW, 50);

        // 3. Row of 6 KPI Cards (Được thiết kế kéo thả trực quan)
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

        int midW1 = (int)(remainingMidW * 0.365); // Doanh thu
        int midW2 = (int)(remainingMidW * 0.310); // Học viên
        int midW3 = remainingMidW - midW1 - midW2; // Chuyên cần

        // Card Doanh thu
        _cardRevenue.Location = new Point(paddingSide, midY);
        _cardRevenue.Size = new Size(midW1, midH);
        _btnRevenueDetail.Location = new Point(_cardRevenue.Width - _btnRevenueDetail.Width - 14, 10);
        _chartRevenue.Size = new Size(midW1 - 28, midH - 56);

        // Card Học viên
        _cardStudents.Location = new Point(paddingSide + midW1 + midGap, midY);
        _cardStudents.Size = new Size(midW2, midH);
        _btnStudentsDetail.Location = new Point(_cardStudents.Width - _btnStudentsDetail.Width - 14, 10);
        _chartStudents.Size = new Size(midW2 - 28, midH - 56);

        // Card Chuyên cần
        int midX3 = paddingSide + midW1 + midGap + midW2 + midGap;
        _cardAttendance.Location = new Point(midX3, midY);
        _cardAttendance.Size = new Size(midW3, midH);
        _btnAttDetail.Location = new Point(_cardAttendance.Width - _btnAttDetail.Width - 14, 10);
        _dgvRatio.Size = new Size(midW3 - 28, midH - 86);

        // 5. Bottom Card: Lịch hôm nay & Sắp khai giảng (Chiếm trọn toàn bộ chiều ngang)
        int btmY = 496;
        int btmH = 300;
        _cardSchedule.Location = new Point(paddingSide, btmY);
        _cardSchedule.Size = new Size(contentW, btmH);
        _btnSchedDetail.Location = new Point(_cardSchedule.Width - _btnSchedDetail.Width - 14, 10);
        _dgvSchedule.Size = new Size(contentW - 32, btmH - 60);
    }
}
