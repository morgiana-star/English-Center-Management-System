using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại hiển thị dữ liệu chi tiết dạng bảng DataGridView (cuộn lướt xuống mượt mà)
/// Dùng cho các nút Xem chi tiết biểu đồ doanh thu, học viên, chuyên cần, lịch học và danh sách cần xử lý.
/// </summary>
public partial class QuickDetailGridDialog : Form
{
    public QuickDetailGridDialog()
    {
        InitializeComponent();
    }

    public QuickDetailGridDialog(string title, string subtitle) : this()
    {
        lblTitle.Text = title;
        Text = title;
    }

    public void SetGridData(Action<AppDataGrid> configureGrid)
    {
        configureGrid?.Invoke(dgvGrid);
    }

    public static void ShowDialog(IWin32Window? owner, string title, string subtitle, Action<AppDataGrid> configureGrid)
    {
        using var dlg = new QuickDetailGridDialog(title, subtitle);
        dlg.SetGridData(configureGrid);
        dlg.ShowDialog(owner);
    }
}
