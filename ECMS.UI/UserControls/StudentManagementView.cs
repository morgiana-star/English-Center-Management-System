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
/// UserControl Quản lý học viên (100% Dữ liệu thật SQLite)
/// </summary>
public partial class StudentManagementView : UserControl
{
    private readonly IStudentService _studentService = new StudentService();
    private readonly IEnrollmentService _enrollmentService = new EnrollmentService();
    private List<StudentListItemDto> _allStudents = new();
    private AppButton _btnViewArchived = null!;
    private AppButton _btnImport = null!;

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
        // Bỏ 2 ô lọc trạng thái & lớp học theo yêu cầu mới
        cboStatusFilter.Visible = false;
        cboClassFilter.Visible = false;

        // Thêm nút "Xem hồ sơ lưu trữ" ngay trên thanh toolbar
        _btnViewArchived = new AppButton
        {
            Text = "📁 Xem hồ sơ lưu trữ",
            Size = new Size(190, 34),
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 6,
            Cursor = Cursors.Hand,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(Math.Max(400, pnlStudentFilterBar.Width - 200), 7)
        };
        pnlStudentFilterBar.Controls.Add(_btnViewArchived);

        // Kéo giãn ô tìm kiếm cân đối
        txtSearchStudent.Size = new Size(Math.Max(320, _btnViewArchived.Left - 24), 34);
        pnlStudentFilterBar.Resize += (s, e) =>
        {
            if (_btnViewArchived != null && txtSearchStudent != null)
            {
                _btnViewArchived.Location = new Point(pnlStudentFilterBar.Width - _btnViewArchived.Width - 10, 7);
                txtSearchStudent.Size = new Size(Math.Max(260, _btnViewArchived.Left - 24), 34);
            }
        };

        // Thêm nút "Nhập Excel" ngay cạnh nút Xuất danh sách
        _btnImport = new AppButton
        {
            Text = "📥 Nhập Excel",
            Size = new Size(130, 36),
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 6,
            Cursor = Cursors.Hand,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(btnExport.Left - 142, 20)
        };
        pnlHeader.Controls.Add(_btnImport);
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
            Text = "Xem chi tiết",
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
            FilterStudents();

            var stats = await _studentService.GetStudentStatsAsync();
            lblStatTotalValue.Text = stats.TotalStudents.ToString();
            lblStatStudyingValue.Text = stats.StudyingStudents.ToString();
            lblStatCompletedValue.Text = stats.CompletedStudents.ToString();
            lblStatArchivedValue.Text = stats.ArchivedStudents.ToString();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách học viên", ex.Message);
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

    private void WireUpEvents()
    {
        // 1. Nút "Đăng ký học": Bước 1 (Thông tin) -> Bước 2 (Chọn khóa/lớp thật) -> Thu học phí -> Transaction DB -> In phiếu -> Refresh danh sách
        btnAddStudent.Click += async (s, e) =>
        {
            using var wizard = new StudentEnrollmentWizardDialog();
            if (wizard.ShowDialog(ParentForm) != DialogResult.OK)
                return;

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
                ClassId = wizard.SelectedClassId,
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
            if (!enrollResult.Success)
            {
                AppDialog.ShowError(ParentForm, "Lỗi lưu hồ sơ đăng ký", enrollResult.Message);
                return;
            }

            if (collectDlg.ShouldPrintReceipt)
            {
                using var printDlg = new ReceiptPrintPreviewDialog(
                    wizard.CreatedStudentName,
                    wizard.CreatedClassName,
                    collectDlg.CollectedAmount,
                    enrollResult.ReceiptCode,
                    enrollResult.StudentCode,
                    collectDlg.PaymentMethod,
                    AppSession.FullName,
                    wizard.SelectedCourseTitle,
                    collectDlg.ContentNote,
                    enrollResult.ReceiptCode,
                    collectDlg.RemainingDebt,
                    collectDlg.RemainingDebt > 0 ? DateTime.Today.AddDays(30).ToString("dd/MM/yyyy") : ""
                );

                printDlg.ShowDialog(ParentForm);
            }

            AppDialog.ShowSuccess(ParentForm, "Thành công", $"🎉 Đã thêm học viên {wizard.CreatedStudentName} ({enrollResult.StudentCode}) thành công!");
            await LoadStudentsAsync();
        };

        // 2. Nút "Xem hồ sơ lưu trữ" (kèm chức năng Khôi phục đưa lại vào danh sách chính)
        _btnViewArchived.Click += async (s, e) => await OpenArchivedStudentsDialogAsync();

        // 3. Nút "Xuất danh sách" ra tệp CSV chuẩn UTF-8 BOM (mở được ngay ngoài Excel)
        btnExport.Click += async (s, e) => await ExportStudentsCsvAsync();

        // 3.1 Nút "Nhập Excel" mở hộp thoại import hàng loạt từ Excel / CSV
        _btnImport.Click += async (s, e) =>
        {
            using var importDlg = new ImportStudentsDialog();
            if (importDlg.ShowDialog(ParentForm) == DialogResult.OK)
            {
                await LoadStudentsAsync();
            }
        };

        // 4. Khi ấn "Xem chi tiết" -> Mở StudentDetailDialog 360° từ SQLite
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

        // 5. Tìm kiếm realtime theo Mã HV, Họ tên, SĐT
        txtSearchStudent.TextChanged += (s, e) => FilterStudents();
    }

    private async Task OpenArchivedStudentsDialogAsync()
    {
        try
        {
            var archivedList = (await _studentService.GetStudentListAsync(status: "Archived")).ToList();

            using var dlg = new QuickDetailGridDialog(
                $"Danh sách hồ sơ học viên đã lưu trữ ({archivedList.Count})",
                "Các học viên đang bảo lưu hoặc đã lưu trữ — Có thể bấm Khôi phục để đưa lại về danh sách học viên");

            dlg.SetGridData(dgv =>
            {
                dgv.Columns.Clear();
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCode", HeaderText = "Mã HV", FillWeight = 16, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColName", HeaderText = "Họ và tên", FillWeight = 24, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColPhone", HeaderText = "Điện thoại", FillWeight = 18, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColClass", HeaderText = "Lớp gần nhất", FillWeight = 18, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColDebt", HeaderText = "Công nợ", FillWeight = 16, ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Trạng thái", FillWeight = 16, ReadOnly = true });

                var colRestore = new DataGridViewButtonColumn
                {
                    Name = "ColRestore",
                    HeaderText = "Khôi phục",
                    Text = "🔄 Khôi phục",
                    UseColumnTextForButtonValue = true,
                    FillWeight = 16,
                    FlatStyle = FlatStyle.Flat
                };
                colRestore.DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74);
                dgv.Columns.Add(colRestore);

                foreach (var item in archivedList)
                {
                    int rowIdx = dgv.Rows.Add(item.StudentCode, item.FullName, item.Phone, item.ClassName, item.DebtDisplay, item.Status);
                    dgv.Rows[rowIdx].Tag = item.StudentId;
                }

                dgv.CellContentClick += async (sender, args) =>
                {
                    if (args.RowIndex < 0 || dgv.Columns[args.ColumnIndex].Name != "ColRestore") return;
                    if (dgv.Rows[args.RowIndex].Tag is int stId)
                    {
                        string stName = dgv.Rows[args.RowIndex].Cells["ColName"].Value?.ToString() ?? "";
                        if (AppDialog.ShowConfirm(dlg, "Khôi phục học viên",
                            $"Bạn có muốn đưa học viên '{stName}' quay lại danh sách đang học không?") == DialogResult.OK)
                        {
                            var res = await _studentService.RestoreStudentAsync(stId);
                            if (res.Success)
                            {
                                dgv.Rows.RemoveAt(args.RowIndex);
                                await LoadStudentsAsync();
                                AppDialog.ShowSuccess(dlg, "Thành công", res.Message);
                            }
                            else
                            {
                                AppDialog.ShowError(dlg, "Lỗi khôi phục", res.Message);
                            }
                        }
                    }
                };

                dgv.ClearSelection();
            });

            dlg.ShowDialog(ParentForm);
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi tải hồ sơ lưu trữ", ex.Message);
        }
    }

    private async Task ExportStudentsCsvAsync()
    {
        try
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất danh sách học viên",
                Filter = "Tệp Excel CSV (*.csv)|*.csv",
                FileName = $"DanhSach_HocVien_ECMS_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (sfd.ShowDialog(ParentForm) != DialogResult.OK)
                return;

            var sb = new StringBuilder();
            sb.AppendLine("DANH SÁCH HỌC VIÊN TRUNG TÂM ANH NGỮ ECMS");
            sb.AppendLine($"Ngày xuất,{DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine("Mã học viên,Họ và tên,Điện thoại,Lớp học,Chuyên cần,Công nợ,Trạng thái");

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string c0 = row.Cells[0].Value?.ToString() ?? "";
                string c1 = row.Cells[1].Value?.ToString() ?? "";
                string c2 = row.Cells[2].Value?.ToString() ?? "";
                string c3 = row.Cells[3].Value?.ToString() ?? "";
                string c4 = row.Cells[4].Value?.ToString() ?? "";
                string c5 = row.Cells[5].Value?.ToString() ?? "";
                sb.AppendLine($"\"{c0}\",\"{c1}\",\"{c2}\",\"{c3}\",\"{c4}\",\"{c5}\",\"Đang theo dõi\"");
            }

            await File.WriteAllTextAsync(sfd.FileName, sb.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

            if (AppDialog.ShowConfirm(ParentForm, "Xuất danh sách thành công",
                $"Đã xuất danh sách {_allStudents.Count} học viên ra tệp:\n{sfd.FileName}\n\nBạn có muốn mở tệp ngay bây giờ không?") == DialogResult.OK)
            {
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi xuất danh sách", ex.Message);
        }
    }

    private async void OpenStudentDetail(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= dgvStudents.Rows.Count) return;

        int studentId = dgvStudents.Rows[rowIndex].Tag is int id ? id : 0;
        string name = dgvStudents.Rows[rowIndex].Cells["ColName"].Value?.ToString() ?? "";
        string code = dgvStudents.Rows[rowIndex].Cells["ColCode"].Value?.ToString() ?? "";

        using var dlg = new StudentDetailDialog(studentId, name, code);
        dlg.ShowDialog(ParentForm);
        // Luôn nạp lại từ SQLite để phản ánh ngay nếu người dùng sửa hồ sơ hoặc lưu trữ
        await LoadStudentsAsync();
    }

    private void FilterStudents()
    {
        string kw = txtSearchStudent.Text.Trim().ToLowerInvariant();

        var filtered = _allStudents.Where(s =>
            string.IsNullOrEmpty(kw) ||
            s.StudentCode.ToLowerInvariant().Contains(kw) ||
            s.FullName.ToLowerInvariant().Contains(kw) ||
            (s.Phone != null && s.Phone.ToLowerInvariant().Contains(kw))
        ).ToList();

        PopulateGrid(filtered);
    }
}
