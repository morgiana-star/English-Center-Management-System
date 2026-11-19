using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

/// <summary>
/// Hộp thoại hiển thị thông tin tra cứu nhanh cho Học viên, Lớp học, Khóa học.
/// Giới hạn ở mức truy xuất dữ liệu chỉ đọc theo yêu cầu 1.2.
/// </summary>
public partial class QuickSearchDetailDialog : Form
{
    public QuickSearchDetailDialog()
    {
        InitializeComponent();
    }

    public static void ShowStudent(IWin32Window? owner, string name, string code, string phone, string email, string className, string attendance, string debt)
    {
        using var dlg = new QuickSearchDetailDialog();
        dlg.lblTitle.Text = $"{name} · {code}";
     
        dlg.SetupPropsGrid();
        dlg.dgvProps.Rows.Add("Mã học viên", code);
        dlg.dgvProps.Rows.Add("Họ và tên", name);
        dlg.dgvProps.Rows.Add("Số điện thoại", phone);
        dlg.dgvProps.Rows.Add("Email", email);
        dlg.dgvProps.Rows.Add("Lớp đang theo học", className);
        dlg.dgvProps.Rows.Add("Tỷ lệ chuyên cần", attendance);
        dlg.dgvProps.Rows.Add("Tình trạng công nợ", debt);
        dlg.dgvProps.Rows.Add("Trạng thái", "Đang học bình thường");
        dlg.dgvProps.ClearSelection();

        dlg.ShowDialog(owner);
    }

    public static void ShowClass(IWin32Window? owner, string classCode, string className, string courseName, string teacher, string room, string schedule, string studentCount, string status)
    {
        using var dlg = new QuickSearchDetailDialog();
        dlg.lblTitle.Text = $"{classCode} · {className}";
     
        dlg.SetupPropsGrid();
        dlg.dgvProps.Rows.Add("Mã lớp", classCode);
        dlg.dgvProps.Rows.Add("Tên lớp học", className);
        dlg.dgvProps.Rows.Add("Khóa học", courseName);
        dlg.dgvProps.Rows.Add("Giáo viên phụ trách", teacher);
        dlg.dgvProps.Rows.Add("Phòng học", room);
        dlg.dgvProps.Rows.Add("Lịch học", schedule);
        dlg.dgvProps.Rows.Add("Sĩ số hiện tại", studentCount);
        dlg.dgvProps.Rows.Add("Tình trạng lớp", status);
        dlg.dgvProps.ClearSelection();

        dlg.ShowDialog(owner);
    }

    public static void ShowCourse(IWin32Window? owner, string courseCode, string courseName, string level, string sessions, string fee, string target)
    {
        using var dlg = new QuickSearchDetailDialog();
        dlg.lblTitle.Text = $"{courseCode} · {courseName}";
   

        dlg.SetupPropsGrid();
        dlg.dgvProps.Rows.Add("Mã khóa học", courseCode);
        dlg.dgvProps.Rows.Add("Tên khóa học", courseName);
        dlg.dgvProps.Rows.Add("Trình độ đầu vào/ra", level);
        dlg.dgvProps.Rows.Add("Thời lượng đào tạo", sessions);
        dlg.dgvProps.Rows.Add("Học phí tiêu chuẩn", fee);
        dlg.dgvProps.Rows.Add("Mục tiêu đầu ra", target);
        dlg.dgvProps.Rows.Add("Trạng thái", "Đang tuyển sinh");
        dlg.dgvProps.ClearSelection();

        dlg.ShowDialog(owner);
    }

    private void SetupPropsGrid()
    {
        dgvProps.Columns.Clear();
        dgvProps.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Thông tin",
            FillWeight = 38,
            ReadOnly = true
        });
        dgvProps.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Chi tiết",
            FillWeight = 62,
            ReadOnly = true
        });
        dgvProps.RowHeadersVisible = false;
        dgvProps.AllowUserToAddRows = false;
        dgvProps.AllowUserToDeleteRows = false;
        dgvProps.ReadOnly = true;
    }
}
