using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản lý học viên (Danh sách học viên toàn trung tâm)
/// Hỗ trợ:
/// 1. Bộ lọc tập trung trên 1 Panel toolbar
/// 2. Bảng DataGridView cuộn lướt xuống mượt mà (không dùng phân trang cũ)
/// 3. Nút Đăng ký học (Quy trình 4 bước: Thông tin -> Khóa/Lớp -> Kế hoạch đóng tối đa 3 đợt -> Thành học viên)
/// 4. Xem / Sửa hồ sơ chi tiết 360° (StudentDetailDialog)
/// </summary>
public partial class StudentManagementView : UserControl
{
    public StudentManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        PopulateMockData();
        WireUpEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang học", "Hoàn thành", "Đã lưu trữ" });
        cboStatusFilter.SelectedIndex = 0;

        cboClassFilter.Items.Clear();
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
        dgvStudents.Rows.Add("HV-0240", "Võ Hoàng Yến", "0978 112 334", "TOEIC-A01", "95,0%", "0đ");
        dgvStudents.Rows.Add("HV-0235", "Nguyễn Tiến Đạt", "0982 334 556", "IELTS-F02", "88,2%", "1.200.000đ");
        dgvStudents.Rows.Add("HV-0236", "Bùi Mai Phương", "0903 778 990", "COM-B01", "90,5%", "0đ");

        dgvStudents.ClearSelection();
        dgvStudents.CurrentCell = null;
    }

    private void WireUpEvents()
    {
        // 4. Nút "Đăng ký học": Nhập thông tin -> Chọn khóa -> Chọn lớp -> Xác nhận -> Thu phí (tối đa 3 đợt) -> Thành học viên
        btnAddStudent.Click += (s, e) =>
        {
            using var wizard = new StudentEnrollmentWizardDialog();
            if (wizard.ShowDialog(ParentForm) == DialogResult.OK)
            {
                // Thêm học viên mới vừa ghi danh trực tiếp lên đầu bảng danh sách
                dgvStudents.Rows.Insert(0,
                    wizard.CreatedStudentCode,
                    wizard.CreatedStudentName,
                    wizard.CreatedStudentPhone,
                    wizard.CreatedClassName,
                    "100%",
                    wizard.CreatedDebt
                );
                dgvStudents.ClearSelection();
                dgvStudents.Rows[0].Selected = true;

                // Cập nhật số liệu trên thẻ thống kê
                int currentTotal = 428;
                if (int.TryParse(lblStatTotalValue.Text, out int parsed)) currentTotal = parsed;
                lblStatTotalValue.Text = (currentTotal + 1).ToString();

                int currentStudying = 348;
                if (int.TryParse(lblStatStudyingValue.Text, out int parsedStudying)) currentStudying = parsedStudying;
                lblStatStudyingValue.Text = (currentStudying + 1).ToString();
            }
        };

        // 3. Nút Xuất danh sách: sẽ xử lý sau
        btnExport.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất danh sách", "Chức năng xuất danh sách học viên sẽ được hoàn thiện trong giai đoạn kế tiếp.");
        };

        // 5. Khi ấn Xem / Sửa -> Mở StudentDetailDialog (Hồ sơ học viên 360°)
        dgvStudents.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns[e.ColumnIndex].Name == "ColAction")
            {
                OpenStudentDetail(e.RowIndex);
            }
        };

        dgvStudents.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenStudentDetail(e.RowIndex);
            }
        };

        // 1. Tìm kiếm nhanh trong ô tìm kiếm
        txtSearchStudent.TextChanged += (s, e) => FilterStudents();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterStudents();
        cboClassFilter.SelectedIndexChanged += (s, e) => FilterStudents();
    }

    private void OpenStudentDetail(int rowIndex)
    {
        string name = dgvStudents.Rows[rowIndex].Cells["ColName"].Value?.ToString() ?? "Nguyễn Minh Anh";
        string code = dgvStudents.Rows[rowIndex].Cells["ColCode"].Value?.ToString() ?? "HV-0241";

        using var dlg = new StudentDetailDialog(name, code);
        dlg.ShowDialog(ParentForm);
    }

    private void FilterStudents()
    {
        string kw = txtSearchStudent.Text.Trim().ToLowerInvariant();
        string selectedClass = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp học";

        foreach (DataGridViewRow row in dgvStudents.Rows)
        {
            if (row.IsNewRow) continue;

            string code = (row.Cells["ColCode"].Value?.ToString() ?? "").ToLowerInvariant();
            string name = (row.Cells["ColName"].Value?.ToString() ?? "").ToLowerInvariant();
            string phone = (row.Cells["ColPhone"].Value?.ToString() ?? "").ToLowerInvariant();
            string cls = row.Cells["ColClass"].Value?.ToString() ?? "";

            bool matchKeyword = string.IsNullOrEmpty(kw) || code.Contains(kw) || name.Contains(kw) || phone.Contains(kw);
            bool matchClass = selectedClass == "Tất cả lớp học" || cls.Equals(selectedClass, StringComparison.OrdinalIgnoreCase);

            row.Visible = matchKeyword && matchClass;
        }
    }
}
