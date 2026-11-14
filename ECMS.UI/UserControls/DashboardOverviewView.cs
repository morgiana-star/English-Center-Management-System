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
public partial class DashboardOverviewView : UserControl
{
    private readonly AppStatCard[] _kpiCards = new AppStatCard[6];

    public DashboardOverviewView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        Dock = DockStyle.Fill;
        InitKpiCards();
        PopulateCharts();
        PopulateData();
        WireEvents();
    }

    private void WireEvents()
    {
        _btnExport.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất báo cáo ngoại tuyến", "Báo cáo Tổng quan trung tâm ngày 30/10/2026 đã được xuất ra tệp cục bộ thành công.");
        };
    }

    private void InitKpiCards()
    {
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
    }

    private void PopulateCharts()
    {
        _chartRevenue.Items = new List<BarItem>
        {
            new("T5", 112, "112"),
            new("T6", 138, "138"),
            new("T7", 145, "145"),
            new("T8", 154, "154"),
            new("T9", 166, "166"),
            new("T10", 186.5, "186.5", isHighlight: true)
        };

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
        // Chuyên cần & lớp học
        _dgvRatio.Columns.Clear();
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nhóm lớp ↑", FillWeight = 42 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lớp", FillWeight = 28 });
        _dgvRatio.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "HV", FillWeight = 30 });
        _dgvRatio.Rows.Add("IELTS", "10", "204");
        _dgvRatio.Rows.Add("TOEIC", "5", "96");
        _dgvRatio.Rows.Add("Giao tiếp", "3", "48");
        _dgvRatio.ClearSelection();
        _dgvRatio.CurrentCell = null;

        // Lịch hôm nay & sắp khai giảng
        _dgvSchedule.Columns.Clear();
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giờ / ngày ↑", FillWeight = 22 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp học", FillWeight = 24 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giáo viên", FillWeight = 30 });
        _dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng / trạng thái", FillWeight = 24 });
        _dgvSchedule.Rows.Add("18:00–20:00", "IELTS-F01", "Nguyễn Hoàng Anh", "P201 · Hôm nay");
        _dgvSchedule.Rows.Add("18:00–20:00", "TOEIC-T01", "Trần Minh Tuấn", "P202 · Hôm nay");
        _dgvSchedule.Rows.Add("02/11/2026", "COM-B01", "Lê Thu Hà", "12/18 · Sắp mở");
        _dgvSchedule.ClearSelection();
        _dgvSchedule.CurrentCell = null;

        // Cần xử lý
        _dgvPending.Columns.Clear();
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Học viên ↑", FillWeight = 32 });
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cảnh báo", FillWeight = 36 });
        _dgvPending.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Liên hệ / xử lý", FillWeight = 32 });
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
            if (_kpiCards[i] != null)
            {
                int x = paddingSide + i * (kpiW + kpiGap);
                int w = (i == 5) ? (paddingSide + contentW - x) : kpiW;
                _kpiCards[i].Location = new Point(x, kpiY);
                _kpiCards[i].Size = new Size(w, kpiH);
            }
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
