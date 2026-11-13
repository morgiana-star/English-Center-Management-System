using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

/// <summary>
/// Màn hình Tổng quan điều hành trung tâm (Khớp 100% bản thiết kế Figma Image 2 & 5)
/// Hỗ trợ bố cục co giãn tự động (Responsive Layout) trên mọi độ phân giải.
/// </summary>
public class DashboardOverviewView : UserControl
{
    // 1. Header controls
    private Label _lblBreadcrumb = null!;
    private Label _lblTitle = null!;
    private Label _lblSubtitle = null!;
    private AppButton _btnExport = null!;

    // 2. Toolbar controls
    private AppTextBox _txtSearch = null!;
    private AppComboBox _cboMonth = null!;
    private AppComboBox _cboCourse = null!;

    // 3. 6 KPI Cards
    private readonly AppStatCard[] _kpiCards = new AppStatCard[6];

    // 4. Middle 3 Cards
    private AppCard _cardRevenue = null!;
    private MiniBarChart _chartRevenue = null!;

    private AppCard _cardStudents = null!;
    private MiniBarChart _chartStudents = null!;

    private AppCard _cardAttendance = null!;
    private Label _lblAttTitle = null!;
    private Label _lblAttPercent = null!;
    private Label _lblAttSub = null!;
    private AppDataGrid _dgvRatio = null!;

    // 5. Bottom 2 Cards
    private AppCard _cardSchedule = null!;
    private Label _lblSchedTitle = null!;
    private AppDataGrid _dgvSchedule = null!;
    private Label _lblSchedFooter = null!;

    private AppCard _cardPending = null!;
    private Label _lblPendingTitle = null!;
    private AppDataGrid _dgvPending = null!;
    private Label _lblPendingFooter = null!;

    private Panel _pnlContentWrapper = null!;

    public DashboardOverviewView()
    {
        Dock = DockStyle.Fill;
        BackColor = FigmaTheme.AppBackground;
        AutoScroll = true;

        InitializeComponents();
        PopulateData();
    }

    private void InitializeComponents()
    {
        _pnlContentWrapper = new Panel
        {
            BackColor = FigmaTheme.AppBackground,
            Location = new Point(0, 0),
            Size = new Size(1200, 800)
        };
        Controls.Add(_pnlContentWrapper);

        // --- 1. Breadcrumbs ---
        _lblBreadcrumb = new Label
        {
            Text = "ECMS  /  Tổng quan  /  Tổng quan trung tâm",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(24, 16),
            AutoSize = true
        };
        _pnlContentWrapper.Controls.Add(_lblBreadcrumb);

        // --- 2. Title, Subtitle & Export Button ---
        _lblTitle = new Label
        {
            Text = "Tổng quan trung tâm",
            Font = FigmaTheme.FontPageTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(24, 38),
            AutoSize = true
        };
        _pnlContentWrapper.Controls.Add(_lblTitle);

        _lblSubtitle = new Label
        {
            Text = "Thứ Sáu, 30/10/2026 · Xin chào, Trần Minh Quân · Đăng nhập thành công",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(24, 72),
            AutoSize = true
        };
        _pnlContentWrapper.Controls.Add(_lblSubtitle);

        _btnExport = new AppButton
        {
            Text = "Xuất báo cáo",
            Variant = ButtonVariant.Primary,
            Size = new Size(124, 36)
        };
        _btnExport.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất báo cáo ngoại tuyến", "Báo cáo Tổng quan trung tâm ngày 30/10/2026 đã được xuất ra tệp cục bộ thành công.");
        };
        _pnlContentWrapper.Controls.Add(_btnExport);

        // --- 3. Filter Toolbar ---
        _txtSearch = new AppTextBox
        {
            Placeholder = "🔍  Tìm nhanh học viên, lớp học...",
            Size = new Size(270, 36)
        };
        _pnlContentWrapper.Controls.Add(_txtSearch);

        _cboMonth = new AppComboBox
        {
            Size = new Size(136, 36)
        };
        _cboMonth.Items.AddRange(new object[] { "Tháng 10/2026", "Tháng 09/2026", "Tháng 08/2026" });
        _cboMonth.SelectedIndex = 0;
        _pnlContentWrapper.Controls.Add(_cboMonth);

        _cboCourse = new AppComboBox
        {
            Size = new Size(150, 36)
        };
        _cboCourse.Items.AddRange(new object[] { "Tất cả khóa học", "IELTS Foundation", "IELTS Intensive", "TOEIC 500" });
        _cboCourse.SelectedIndex = 0;
        _pnlContentWrapper.Controls.Add(_cboCourse);

        // --- 4. 6 KPI Cards ---
        var kpiConfigs = new[]
        {
            ("Tổng học viên", "428", "24 hồ sơ mới trong tháng"),
            ("Đang học", "348", "81,3% tổng học viên"),
            ("Lớp đang hoạt động", "18", "4 lớp sắp khai giảng"),
            ("Giáo viên", "24", "20 đang được phân lớp"),
            ("Doanh thu tháng", "186,5 tr", "Tăng 12,3% so với T9"),
            ("Học phí còn nợ", "42,9 tr", "27 học viên cần theo dõi")
        };

        for (int i = 0; i < 6; i++)
        {
            _kpiCards[i] = new AppStatCard
            {
                Title = kpiConfigs[i].Item1,
                Value = kpiConfigs[i].Item2,
                Subtext = kpiConfigs[i].Item3
            };
            _pnlContentWrapper.Controls.Add(_kpiCards[i]);
        }

        // --- 5. Middle 3 Cards ---
        // Mid Card 1: Doanh thu theo tháng
        _cardRevenue = new AppCard();
        var lblRevTitle = new Label
        {
            Text = "Doanh thu theo tháng",
            Font = FigmaTheme.FontSectionTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(16, 14),
            AutoSize = true
        };
        var lblRevUnit = new Label
        {
            Text = "Triệu đồng",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(190, 19),
            AutoSize = true
        };
        _chartRevenue = new MiniBarChart
        {
            Location = new Point(16, 46),
            Items = new List<BarItem>
            {
                new("T5", 112, "112"),
                new("T6", 138, "138"),
                new("T7", 145, "145"),
                new("T8", 154, "154"),
                new("T9", 166, "166"),
                new("T10", 186.5, "186.5", isHighlight: true)
            }
        };
        _cardRevenue.Controls.Add(lblRevTitle);
        _cardRevenue.Controls.Add(lblRevUnit);
        _cardRevenue.Controls.Add(_chartRevenue);
        _pnlContentWrapper.Controls.Add(_cardRevenue);

        // Mid Card 2: Học viên đang học
        _cardStudents = new AppCard();
        var lblStudTitle = new Label
        {
            Text = "Học viên đang học",
            Font = FigmaTheme.FontSectionTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(16, 14),
            AutoSize = true
        };
        _chartStudents = new MiniBarChart
        {
            Location = new Point(16, 46),
            Items = new List<BarItem>
            {
                new("T7", 296, "296"),
                new("T8", 310, "310"),
                new("T9", 326, "326"),
                new("T10", 348, "348", isHighlight: true)
            }
        };
        _cardStudents.Controls.Add(lblStudTitle);
        _cardStudents.Controls.Add(_chartStudents);
        _pnlContentWrapper.Controls.Add(_cardStudents);

        // Mid Card 3: Chuyên cần & lớp học
        _cardAttendance = new AppCard();
        _lblAttTitle = new Label
        {
            Text = "Chuyên cần & lớp học",
            Font = FigmaTheme.FontSectionTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(16, 14),
            AutoSize = true
        };
        _lblAttPercent = new Label
        {
            Text = "92,4%",
            Font = new Font("Segoe UI", 18f, FontStyle.Bold),
            ForeColor = FigmaTheme.Primary,
            Location = new Point(14, 40),
            AutoSize = true
        };
        _lblAttSub = new Label
        {
            Text = "Có mặt / buổi đã học",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextSecondary,
            Location = new Point(125, 48),
            AutoSize = true
        };
        _dgvRatio = new AppDataGrid
        {
            Location = new Point(14, 78)
        };
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nhóm lớp ↑", FillWeight = 42 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lớp", FillWeight = 28 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "HV", FillWeight = 30 });

        _cardAttendance.Controls.Add(_lblAttTitle);
        _cardAttendance.Controls.Add(_lblAttPercent);
        _cardAttendance.Controls.Add(_lblAttSub);
        _cardAttendance.Controls.Add(_dgvRatio);
        _pnlContentWrapper.Controls.Add(_cardAttendance);

        // --- 6. Bottom 2 Cards ---
        // Bottom Card 1: Lịch hôm nay & sắp khai giảng
        _cardSchedule = new AppCard();
        _lblSchedTitle = new Label
        {
            Text = "Lịch hôm nay & sắp khai giảng",
            Font = FigmaTheme.FontSectionTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(16, 14),
            AutoSize = true
        };
        _dgvSchedule = new AppDataGrid
        {
            Location = new Point(14, 44)
        };
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / ngày ↑", FillWeight = 22 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 24 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 30 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng / trạng thái", FillWeight = 24 });

        _lblSchedFooter = new Label
        {
            Text = "Mở lịch học tuần → 04.1 · Quản lý lớp → 03.4",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.Primary,
            AutoSize = true,
            Cursor = Cursors.Hand
        };
        _cardSchedule.Controls.Add(_lblSchedTitle);
        _cardSchedule.Controls.Add(_dgvSchedule);
        _cardSchedule.Controls.Add(_lblSchedFooter);
        _pnlContentWrapper.Controls.Add(_cardSchedule);

        // Bottom Card 2: Cần xử lý
        _cardPending = new AppCard();
        _lblPendingTitle = new Label
        {
            Text = "Cần xử lý",
            Font = FigmaTheme.FontSectionTitle,
            ForeColor = FigmaTheme.TextPrimary,
            Location = new Point(16, 14),
            AutoSize = true
        };
        _dgvPending = new AppDataGrid
        {
            Location = new Point(14, 44)
        };
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên ↑", FillWeight = 32 });
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cảnh báo", FillWeight = 36 });
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Liên hệ / xử lý", FillWeight = 32 });

        _lblPendingFooter = new Label
        {
            Text = "Số dư hiển thị sau giao dịch PT-261030-018.",
            Font = FigmaTheme.FontHelper,
            ForeColor = FigmaTheme.TextMuted,
            AutoSize = true
        };
        _cardPending.Controls.Add(_lblPendingTitle);
        _cardPending.Controls.Add(_dgvPending);
        _cardPending.Controls.Add(_lblPendingFooter);
        _pnlContentWrapper.Controls.Add(_cardPending);
    }

    private void PopulateData()
    {
        // Chuyên cần & lớp học
        _dgvRatio.Rows.Add("IELTS", "10", "204");
        _dgvRatio.Rows.Add("TOEIC", "5", "96");
        _dgvRatio.Rows.Add("Giao tiếp", "3", "48");
        _dgvRatio.ClearSelection();
        _dgvRatio.CurrentCell = null;

        // Lịch hôm nay & sắp khai giảng
        _dgvSchedule.Rows.Add("18:00–20:00", "IELTS-F01", "Nguyễn Hoàng Anh", "P201 · Hôm nay");
        _dgvSchedule.Rows.Add("18:00–20:00", "TOEIC-T01", "Trần Minh Tuấn", "P202 · Hôm nay");
        _dgvSchedule.Rows.Add("02/11/2026", "COM-B01", "Lê Thu Hà", "12/18 · Sắp mở");
        _dgvSchedule.ClearSelection();
        _dgvSchedule.CurrentCell = null;

        // Cần xử lý
        _dgvPending.Rows.Add("Lê Hoàng Nam", "Vắng 4/8 buổi", "0904 221 678");
        _dgvPending.Rows.Add("Phạm Khánh Linh", "Nợ 2.400.000đ", "Hạn 31/10");
        _dgvPending.Rows.Add("Nguyễn Minh Anh", "Nợ 1.900.000đ", "Hạn 15/11");
        _dgvPending.ClearSelection();
        _dgvPending.CurrentCell = null;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        PerformResponsiveLayout();
    }

    private void PerformResponsiveLayout()
    {
        int availableW = Math.Max(1000, ClientSize.Width);
        int paddingSide = 24;
        int contentW = availableW - (paddingSide * 2);

        _pnlContentWrapper.Width = availableW;
        _pnlContentWrapper.Height = 840;

        // 1. Export button align right
        _btnExport.Location = new Point(paddingSide + contentW - _btnExport.Width, 38);

        // 2. Filters
        _txtSearch.Location = new Point(paddingSide, 102);
        _cboMonth.Location = new Point(paddingSide + _txtSearch.Width + 12, 102);
        _cboCourse.Location = new Point(paddingSide + _txtSearch.Width + 12 + _cboMonth.Width + 12, 102);

        // 3. Row of 6 KPI Cards
        int kpiY = 152;
        int kpiH = 95;
        int kpiGap = 14;
        int totalKpiGaps = 5 * kpiGap;
        int kpiW = (contentW - totalKpiGaps) / 6;

        for (int i = 0; i < 6; i++)
        {
            int x = paddingSide + i * (kpiW + kpiGap);
            int w = (i == 5) ? (paddingSide + contentW - x) : kpiW;
            _kpiCards[i].Location = new Point(x, kpiY);
            _kpiCards[i].Size = new Size(w, kpiH);
        }

        // 4. Middle 3 Cards
        int midY = 262;
        int midH = 230;
        int midGap = 16;
        int totalMidGaps = 2 * midGap;
        int remainingMidW = contentW - totalMidGaps;

        int midW1 = (int)(remainingMidW * 0.36); // Doanh thu
        int midW2 = (int)(remainingMidW * 0.30); // Học viên
        int midW3 = remainingMidW - midW1 - midW2; // Chuyên cần

        // Card 1
        _cardRevenue.Location = new Point(paddingSide, midY);
        _cardRevenue.Size = new Size(midW1, midH);
        _chartRevenue.Size = new Size(midW1 - 32, midH - 58);

        // Card 2
        _cardStudents.Location = new Point(paddingSide + midW1 + midGap, midY);
        _cardStudents.Size = new Size(midW2, midH);
        _chartStudents.Size = new Size(midW2 - 32, midH - 58);

        // Card 3
        int midX3 = paddingSide + midW1 + midGap + midW2 + midGap;
        _cardAttendance.Location = new Point(midX3, midY);
        _cardAttendance.Size = new Size(midW3, midH);
        _dgvRatio.Size = new Size(midW3 - 28, midH - 90);

        // 5. Bottom 2 Cards
        int btmY = 508;
        int btmH = 230;
        int btmGap = 16;
        int totalBtmW = contentW - btmGap;

        int btmW1 = (int)(totalBtmW * 0.58); // Lịch hôm nay & sắp khai giảng
        int btmW2 = totalBtmW - btmW1;       // Cần xử lý

        // Bottom Card 1
        _cardSchedule.Location = new Point(paddingSide, btmY);
        _cardSchedule.Size = new Size(btmW1, btmH);
        _dgvSchedule.Size = new Size(btmW1 - 28, 140);
        _lblSchedFooter.Location = new Point(14, 195);

        // Bottom Card 2
        _cardPending.Location = new Point(paddingSide + btmW1 + btmGap, btmY);
        _cardPending.Size = new Size(btmW2, btmH);
        _dgvPending.Size = new Size(btmW2 - 28, 140);
        _lblPendingFooter.Location = new Point(14, 195);
    }
}
