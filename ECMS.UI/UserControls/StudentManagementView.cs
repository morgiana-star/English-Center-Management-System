using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản lý học viên (Màn hình 1: Danh sách học viên toàn trung tâm)
/// Khi ấn Thêm học viên -> Mở AddStudentDialog (Màn 4)
/// Khi ấn Xem / Sửa -> Mở StudentDetailDialog (Màn 2)
/// Hỗ trợ kéo thả 100% trên WinForms Designer của JetBrains Rider
/// </summary>
public partial class StudentManagementView : UserControl
{
    public StudentManagementView()
    {
        InitializeComponent();
        SetupFilters();
        PopulateMockData();
        WireUpEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.AddRange(new object[] { "Đang học", "Hoàn thành", "Đã lưu trữ", "Tất cả trạng thái" });
        cboStatusFilter.SelectedIndex = 0;

        cboClassFilter.Items.AddRange(new object[] { "Tất cả lớp học", "IELTS-F01", "IELTS-F02", "COM-B01", "TOEIC-A01" });
        cboClassFilter.SelectedIndex = 0;
    }

    private void PopulateMockData()
    {
        AppGridHelper.ApplyStyle(dgvStudents);
        dgvStudents.Columns.Clear();
        dgvStudents.Columns.Add("ColCode", "Mã ↑");
        dgvStudents.Columns.Add("ColName", "Họ và tên");
        dgvStudents.Columns.Add("ColPhone", "Điện thoại");
        dgvStudents.Columns.Add("ColClass", "Lớp");
        dgvStudents.Columns.Add("ColAttendance", "Chuyên cần");
        dgvStudents.Columns.Add("ColDebt", "Công nợ");

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Xem / Sửa",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        colAction.DefaultCellStyle.SelectionForeColor = Color.FromArgb(37, 99, 235);
        dgvStudents.Columns.Add(colAction);

        dgvStudents.Rows.Add("HV-0241", "Nguyễn Minh Anh", "0908 123 456", "IELTS-F01", "87,5%", "1.900.000đ");
        dgvStudents.Rows.Add("HV-0204", "Trần Gia Bảo", "0915 227 330", "IELTS-F02", "91,7%", "0đ");
        dgvStudents.Rows.Add("HV-0237", "Lê Hoàng Nam", "0904 221 678", "IELTS-F01", "50,0%", "0đ");
        dgvStudents.Rows.Add("HV-0238", "Phạm Khánh Linh", "0912 450 678", "IELTS-F01", "100%", "2.400.000đ");
        dgvStudents.Rows.Add("HV-0239", "Đỗ Thanh Tâm", "0935 661 220", "COM-B01", "Chưa học", "3.200.000đ");
    }

    private void WireUpEvents()
    {
        // 1. Thêm học viên -> Mở Dialog Thêm mới (Màn 4)
        btnAddStudent.Click += (s, e) =>
        {
            using var dlg = new AddStudentDialog();
            dlg.ShowDialog(ParentForm);
        };

        // 2. Xuất danh sách
        btnExport.Click += (s, e) => AppDialog.ShowSuccess(ParentForm, "Xuất dữ liệu", "Đã xuất danh sách 348 học viên ra tệp Excel cục bộ thành công.");

        // 3. Xem / Sửa -> Mở Dialog Hồ sơ 360° (Màn 2)
        dgvStudents.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns[e.ColumnIndex].Name == "ColAction")
            {
                using var dlg = new StudentDetailDialog();
                dlg.ShowDialog(ParentForm);
            }
        };
    }
}
