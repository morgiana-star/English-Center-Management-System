using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public partial class ReportManagementView : UserControl
{
    public ReportManagementView()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupEvents();
        LoadSampleData();
    }

    private void SetupEvents()
    {
        btnPreview.Click += (s, e) => OpenPreviewDialog();
        btnExportLocal.Click += (s, e) => OpenPreviewDialog();

        btnApply.Click += (s, e) =>
        {
            MessageBox.Show(
                $"Đã tổng hợp dữ liệu từ SQLite cục bộ trong khoảng {txtFromDate.Text} - {txtToDate.Text}.\nTổng thực thu: 186.500.000đ | Công nợ: 42.900.000đ.",
                "Tổng hợp báo cáo thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        };

        lblHelpLink.Click += (s, e) =>
        {
            MessageBox.Show("Mở tệp hướng dẫn báo cáo ngoại tuyến tại C:\\ECMS\\HuongDan\\bao-cao.html.", "Hướng dẫn ngoại tuyến · F1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
    }

    private void OpenPreviewDialog()
    {
        using var dialog = new ReportPreviewExportDialog();
        dialog.ShowDialog(this.FindForm());
    }

    private void LoadSampleData()
    {
        cboCourseFilter.SelectedIndex = 0;
        cboClassFilter.SelectedIndex = 0;

        // Populate weekly revenue chart
        chartWeeklyRevenue.Items = new List<BarItem>
        {
            new BarItem("01–07", 42, "42", false),
            new BarItem("08–14", 46, "46", false),
            new BarItem("15–21", 43.5, "43.5", false),
            new BarItem("22–30", 55, "55", true)
        };

        // Populate course attendance chart
        chartCourseAttendance.Items = new List<BarItem>
        {
            new BarItem("IELTS", 93, "93", false),
            new BarItem("TOEIC", 91, "91", false),
            new BarItem("Giao tiếp", 93, "93", true)
        };

        // Populate grid
        gridCourseSummary.Rows.Clear();
        gridCourseSummary.Rows.Add("IELTS", "204", "93,0%", "112.500.000đ", "26.400.000đ");
        gridCourseSummary.Rows.Add("TOEIC", "96", "91,0%", "48.000.000đ", "11.300.000đ");
        gridCourseSummary.Rows.Add("Giao tiếp", "48", "93,0%", "26.000.000đ", "5.200.000đ");
    }
}
