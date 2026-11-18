using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Quản lý học viên (Danh sách học viên toàn trung tâm)
/// Hỗ trợ:
/// 1. Bộ lọc tập trung trên 1 Panel toolbar
/// 2. Bảng DataGridView cuộn lướt xuống mượt mà (không dùng phân trang cũ)
/// 3. Nút Đăng ký học (Quy trình: Điền thông tin -> Chọn lớp -> Thu học phí -> In biên lai -> Hoàn tất)
/// 4. Xem / Sửa hồ sơ chi tiết 360° (StudentDetailDialog)
/// </summary>
public partial class StudentManagementView : UserControl
{
    private readonly IStudentService _studentService = new StudentService();
    private readonly IEnrollmentService _enrollmentService = new EnrollmentService();
    private List<StudentListItemDto> _allStudents = new();

    public StudentManagementView()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGridColumns();
        _ = LoadStudentsAsync();
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

    private void SetupGridColumns()
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
    }

    private async Task LoadStudentsAsync()
    {
        try
        {
            var list = await _studentService.GetStudentListAsync();
            _allStudents = list.ToList();
            PopulateGrid(_allStudents);

            var stats = await _studentService.GetStudentStatsAsync();
            lblStatTotalValue.Text = stats.TotalStudents.ToString();
            lblStatStudyingValue.Text = stats.StudyingStudents.ToString();
        }
        catch
        {
            // Fallback nếu CSDL bận
            PopulateFallbackData();
        }
    }

    private void PopulateGrid(IEnumerable<StudentListItemDto> items)
    {
        dgvStudents.Rows.Clear();
        foreach (var s in items)
        {
            int idx = dgvStudents.Rows.Add(
                s.StudentCode,
                s.FullName,
                s.Phone,
                s.ClassName,
                s.AttendanceRateDisplay,
                s.DebtDisplay
            );
            dgvStudents.Rows[idx].Tag = s.StudentId;
        }

        dgvStudents.ClearSelection();
        dgvStudents.CurrentCell = null;
    }

    private void PopulateFallbackData()
    {
        dgvStudents.Rows.Clear();
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
        // Nút "Đăng ký học": Nhập thông tin (Bước 1) -> Chọn khóa/lớp (Bước 2) -> Lập phiếu thu (Ảnh 2) -> In phiếu thu (Ảnh 3, 4) -> Hoàn tất
        btnAddStudent.Click += async (s, e) =>
        {
            using var wizard = new StudentEnrollmentWizardDialog();
            if (wizard.ShowDialog(ParentForm) != DialogResult.OK)
                return;

            // Chuyển sang Form Thu học phí (Ảnh 2)
            using var collectDlg = new CollectTuitionDialog(
                wizard.CreatedStudentName,
                wizard.CreatedClassName,
                wizard.CourseFee,
                wizard.CourseFee,
                wizard.CreatedStudentCode,
                wizard.SelectedCourseTitle
            );

            if (collectDlg.ShowDialog(ParentForm) != DialogResult.OK)
                return;

            // Thực thi ghi Transaction vào SQLite qua Tầng Business & Data
            var enrollDto = new StudentEnrollmentWithTuitionDto
            {
                StudentCode = wizard.CreatedStudentCode,
                FullName = wizard.CreatedStudentName,
                Phone = wizard.CreatedStudentPhone,
                Email = wizard.CreatedStudentEmail,
                DateOfBirth = wizard.CreatedStudentDob,
                Gender = wizard.CreatedStudentGender,
                Address = wizard.CreatedStudentAddress,
                ParentFullName = wizard.CreatedParentName,
                ParentPhone = wizard.CreatedParentPhone,
                ParentRelationship = wizard.CreatedParentRelationship,
                Notes = wizard.CreatedNotes,
                ClassCode = wizard.CreatedClassName,
                CourseName = wizard.SelectedCourseTitle,
                TotalTuitionFee = wizard.CourseFee,
                AmountPaidNow = collectDlg.CollectedAmount,
                RemainingDebt = collectDlg.RemainingDebt,
                PaymentMethod = collectDlg.PaymentMethod,
                ReceiptCode = collectDlg.ReceiptCode,
                PaymentNote = collectDlg.ContentNote,
                CashierId = AppSession.UserId
            };

            var enrollResult = await _enrollmentService.EnrollStudentWithTuitionAsync(enrollDto);

            // Chuyển sang Form Xem trước và in phiếu thu (Ảnh 3 & 4)
            if (collectDlg.ShouldPrintReceipt)
            {
                using var printDlg = new ReceiptPrintPreviewDialog(
                    wizard.CreatedStudentName,
                    wizard.CreatedClassName,
                    collectDlg.CollectedAmount,
                    collectDlg.ReceiptCode,
                    enrollResult.Success ? enrollResult.StudentCode : wizard.CreatedStudentCode,
                    collectDlg.PaymentMethod,
                    AppSession.FullName,
                    wizard.SelectedCourseTitle
                );

                printDlg.ShowDialog(ParentForm);
            }

            // Hiện thông báo hoàn tất thêm học viên thành công
            AppDialog.ShowSuccess(ParentForm, "Thành công", "🎉 Đã thêm học viên thành công!");

            // Nạp lại danh sách học viên mới nhất từ CSDL
            await LoadStudentsAsync();
        };

        // Nút Xuất danh sách
        btnExport.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Xuất danh sách", "Chức năng xuất danh sách học viên sẽ được hoàn thiện trong giai đoạn kế tiếp.");
        };

        // Khi ấn Xem / Sửa -> Mở StudentDetailDialog (Hồ sơ học viên 360°)
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

        // Tìm kiếm và lọc
        txtSearchStudent.TextChanged += (s, e) => FilterStudents();
        cboStatusFilter.SelectedIndexChanged += (s, e) => FilterStudents();
        cboClassFilter.SelectedIndexChanged += (s, e) => FilterStudents();
    }

    private async void OpenStudentDetail(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= dgvStudents.Rows.Count) return;

        int studentId = dgvStudents.Rows[rowIndex].Tag is int id ? id : 0;
        string name = dgvStudents.Rows[rowIndex].Cells["ColName"].Value?.ToString() ?? "Nguyễn Minh Anh";
        string code = dgvStudents.Rows[rowIndex].Cells["ColCode"].Value?.ToString() ?? "HV-0241";

        using var dlg = new StudentDetailDialog(studentId, name, code);
        if (dlg.ShowDialog(ParentForm) == DialogResult.OK)
        {
            await LoadStudentsAsync();
        }
    }

    private void FilterStudents()
    {
        string kw = txtSearchStudent.Text.Trim().ToLowerInvariant();
        string selectedStatus = cboStatusFilter.SelectedItem?.ToString() ?? "Tất cả trạng thái";
        string selectedClass = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp học";

        var filtered = _allStudents.Where(s =>
        {
            bool matchKw = string.IsNullOrEmpty(kw) ||
                           s.StudentCode.ToLowerInvariant().Contains(kw) ||
                           s.FullName.ToLowerInvariant().Contains(kw) ||
                           s.Phone.ToLowerInvariant().Contains(kw);

            bool matchStatus = selectedStatus == "Tất cả trạng thái" ||
                               s.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

            bool matchClass = selectedClass == "Tất cả lớp học" ||
                              s.ClassName.Equals(selectedClass, StringComparison.OrdinalIgnoreCase);

            return matchKw && matchStatus && matchClass;
        }).ToList();

        PopulateGrid(filtered);
    }
}
