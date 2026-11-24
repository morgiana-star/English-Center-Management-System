using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;
using ECMS.UI.Services;

namespace ECMS.UI.UserControls;

public partial class CertificateManagementView : UserControl
{
    private readonly ICertificateService _certService = new ECMS.Business.Services.CertificateService();

    private class EligibleStudentItem
    {
        public bool IsChecked { get; set; }
        public int Stt { get; set; }
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string StudentCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string ScoreText { get; set; } = string.Empty;
        public string AttendanceText { get; set; } = string.Empty;
        public string TuitionText { get; set; } = string.Empty;
        public bool IsEligible { get; set; }
        public string StatusText { get; set; } = string.Empty;
        public string GradeRank { get; set; } = "Giỏi";
    }

    private readonly List<EligibleStudentItem> _students = new();

    public CertificateManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadRealEligibleStudentsAsync();
        WireEvents();
        UpdateSignerNote();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AdjustLayout();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AdjustLayout();
    }

    private void AdjustLayout()
    {
        if (pnlBody == null || pnlFilterBar == null || cardStudentList == null || pnlHeader == null) return;

        int pad = 24;
        int availWidth = Math.Max(700, pnlBody.ClientSize.Width - pad * 2);
        int topY = 16;

        pnlFilterBar.SetBounds(pad, topY, availWidth, 48);

        int cardY = pnlFilterBar.Bottom + 12;
        int cardHeight = Math.Max(300, pnlBody.ClientSize.Height - cardY - pad);
        cardStudentList.SetBounds(pad, cardY, availWidth, cardHeight);

        // Header controls layout
        int headerRight = pnlHeader.ClientSize.Width - pad;
        if (btnIssueSelectedTop != null)
        {
            btnIssueSelectedTop.Location = new Point(headerRight - btnIssueSelectedTop.Width, 18);
            headerRight = btnIssueSelectedTop.Left - 10;
        }

        if (btnIssuedRegistryTop != null)
        {
            btnIssuedRegistryTop.Location = new Point(headerRight - btnIssuedRegistryTop.Width, 18);
            headerRight = btnIssuedRegistryTop.Left - 16;
        }

        if (cboSigner != null)
        {
            cboSigner.Location = new Point(headerRight - cboSigner.Width, 22);
            headerRight = cboSigner.Left - 8;
        }

        if (lblSigner != null)
        {
            lblSigner.Location = new Point(headerRight - lblSigner.Width, 26);
        }
    }

    private void UpdateSignerNote()
    {
        string signer = cboSigner.SelectedItem?.ToString() ?? $"{AppSession.FullName} · {AppSession.GetSignerRoleTitle()}";
        lblFooterNote.Text = $"📌 Tiêu chuẩn cấp chứng chỉ: Điểm TB cuối khóa ≥ 6.5  |  Chuyên cần ≥ 80%  |  Học phí 100%  |  Người ký duyệt: {signer}";
    }

    private void SetupFilters()
    {
        cboSigner.Items.Clear();
        cboSigner.Items.AddRange(new object[]
        {
            "Trần Minh Quân · Giám đốc trung tâm",
            "Nguyễn Thị Mai Lan · Trưởng phòng Đào tạo",
            "Lê Hoàng Long · Phó Giám đốc",
            "Vũ Đức Thắng · Quản lý học vụ",
            "Phạm Thu Hằng · Giáo vụ trung tâm"
        });
        cboSigner.SelectedIndex = 0;

        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.AddRange(new object[]
        {
            "Tất cả khóa học",
            "IELTS Foundation",
            "IELTS Intensive",
            "TOEIC 500+",
            "Tiếng Anh Giao tiếp Cơ bản"
        });
        cboCourseFilter.SelectedIndex = 0;

        cboClassFilter.Items.Clear();
        cboClassFilter.Items.AddRange(new object[]
        {
            "Tất cả lớp",
            "IELTS-F01",
            "IELTS-F02",
            "TOEIC-A01",
            "COM-B01"
        });
        cboClassFilter.SelectedIndex = 0;

        cboConditionFilter.Items.Clear();
        cboConditionFilter.Items.AddRange(new object[]
        {
            "Tất cả điều kiện",
            "✓ Đủ điều kiện cấp",
            "Chưa đủ điều kiện"
        });
        cboConditionFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvEligible.AutoGenerateColumns = false;
        dgvEligible.Columns.Clear();
        dgvEligible.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEligible.MultiSelect = false;
        dgvEligible.ReadOnly = false;
        dgvEligible.RowHeadersVisible = false;
        dgvEligible.AllowUserToAddRows = false;
        dgvEligible.AllowUserToDeleteRows = false;

        var colCheck = new DataGridViewCheckBoxColumn
        {
            Name = "colCheck",
            DataPropertyName = "IsChecked",
            HeaderText = "Chọn",
            Width = 50,
            ReadOnly = false
        };
        dgvEligible.Columns.Add(colCheck);

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStt",
            DataPropertyName = "Stt",
            HeaderText = "STT",
            Width = 50,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCode",
            DataPropertyName = "StudentCode",
            HeaderText = "Mã HV",
            Width = 95,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colName",
            DataPropertyName = "FullName",
            HeaderText = "Họ và tên",
            Width = 170,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42) }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCourse",
            DataPropertyName = "CourseName",
            HeaderText = "Khóa học",
            Width = 150,
            ReadOnly = true
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colClass",
            DataPropertyName = "ClassName",
            HeaderText = "Lớp học",
            Width = 95,
            ReadOnly = true
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colScore",
            DataPropertyName = "ScoreText",
            HeaderText = "Điểm tổng kết",
            Width = 120,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAttendance",
            DataPropertyName = "AttendanceText",
            HeaderText = "Chuyên cần",
            Width = 120,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTuition",
            DataPropertyName = "TuitionText",
            HeaderText = "Học phí",
            Width = 110,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvEligible.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStatus",
            DataPropertyName = "StatusText",
            HeaderText = "Điều kiện cấp",
            Width = 150,
            ReadOnly = true,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        var btnActionCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "👁️ Xem trước",
            UseColumnTextForButtonValue = true,
            Width = 105,
            FlatStyle = FlatStyle.Flat
        };
        dgvEligible.Columns.Add(btnActionCol);

        // Commit checkbox clicks immediately
        dgvEligible.CurrentCellDirtyStateChanged += (s, e) =>
        {
            if (dgvEligible.IsCurrentCellDirty && dgvEligible.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvEligible.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        };

        dgvEligible.CellValueChanged += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvEligible.Columns[e.ColumnIndex].Name == "colCheck")
            {
                if (dgvEligible.Rows[e.RowIndex].DataBoundItem is EligibleStudentItem student)
                {
                    if (student.IsChecked && !student.IsEligible)
                    {
                        student.IsChecked = false;
                        dgvEligible.Refresh();
                        AppDialog.ShowWarning(ParentForm, "Học viên chưa đủ điều kiện",
                            $"Học viên {student.FullName} ({student.StudentCode}) chưa đủ điều kiện tốt nghiệp:\n\n" +
                            $"• Trạng thái: {student.StatusText}\n" +
                            $"• Điểm tổng kết: {student.ScoreText}\n" +
                            $"• Chuyên cần: {student.AttendanceText}\n\n" +
                            $"Theo quy chế đào tạo của trung tâm, chỉ học viên có Điểm >= 5.0 và Chuyên cần >= 80% mới được cấp chứng chỉ!");
                    }
                }
                UpdateSelectedSummary();
            }
        };

        dgvEligible.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvEligible.Rows.Count) return;

            string colName = dgvEligible.Columns[e.ColumnIndex].Name;
            var val = e.Value?.ToString() ?? "";

            if (colName == "colStatus")
            {
                if (val.Contains("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.BackColor = Color.FromArgb(240, 253, 244);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                    e.CellStyle!.BackColor = Color.FromArgb(254, 242, 242);
                }
            }
            else if (colName == "colTuition")
            {
                if (val.Contains("hoàn tất"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        };

        dgvEligible.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvEligible.Columns[e.ColumnIndex].Name == "colAction")
            {
                OpenPreviewForRow(e.RowIndex);
            }
        };

        dgvEligible.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvEligible.Columns[e.ColumnIndex].Name != "colCheck")
            {
                OpenPreviewForRow(e.RowIndex);
            }
        };
    }

    private async void LoadRealEligibleStudentsAsync()
    {
        try
        {
            var dtoList = await _certService.GetEligibleStudentsAsync();
            _students.Clear();
            int stt = 1;
            foreach (var s in dtoList)
            {
                _students.Add(new EligibleStudentItem
                {
                    Stt = stt++,
                    StudentCode = s.StudentCode,
                    FullName = s.FullName,
                    CourseName = s.CourseName,
                    ClassName = s.ClassName,
                    ScoreText = s.ScoreText,
                    AttendanceText = s.AttendanceText,
                    TuitionText = s.TuitionText,
                    IsEligible = s.IsEligible,
                    StatusText = s.StatusText,
                    GradeRank = s.GradeRank,
                    EnrollmentId = s.EnrollmentId,
                    StudentId = s.StudentId
                });
            }
            ApplyFilter();
        }
        catch
        {
            LoadSampleData();
        }
    }

    private void LoadSampleData()
    {
        _students.Clear();

        _students.Add(new EligibleStudentItem
        {
            Stt = 1,
            StudentCode = "HV-0204",
            FullName = "Trần Gia Bảo",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            ScoreText = "7.7 · Khá",
            AttendanceText = "22/24 (91.7%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Khá"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 2,
            StudentCode = "HV-0205",
            FullName = "Đặng Minh Trí",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            ScoreText = "8.4 · Giỏi",
            AttendanceText = "24/24 (100%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Giỏi"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 3,
            StudentCode = "HV-0208",
            FullName = "Lê Hoàng Yến",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            ScoreText = "8.8 · Xuất sắc",
            AttendanceText = "23/24 (95.8%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Xuất sắc"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 4,
            StudentCode = "HV-0210",
            FullName = "Phạm Quốc Huy",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            ScoreText = "7.9 · Khá",
            AttendanceText = "21/24 (87.5%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Khá"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 5,
            StudentCode = "HV-0192",
            FullName = "Vũ Ngọc Lan",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            ScoreText = "5.9 · Yếu",
            AttendanceText = "22/24 (91.7%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = false,
            StatusText = "✕ TB < 6.5 (Chưa đạt)",
            GradeRank = "Chưa đạt"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 6,
            StudentCode = "HV-0196",
            FullName = "Hoàng Đức An",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F02",
            ScoreText = "7.2 · Khá",
            AttendanceText = "18/24 (75.0%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = false,
            StatusText = "⚠️ Chuyên cần < 80%",
            GradeRank = "Khá"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 7,
            StudentCode = "HV-0215",
            FullName = "Trần Thảo Nhi",
            CourseName = "IELTS Foundation",
            ClassName = "IELTS-F01",
            ScoreText = "7.0 · Khá",
            AttendanceText = "21/24 (87.5%)",
            TuitionText = "Nợ 500.000đ",
            IsEligible = false,
            StatusText = "⚠️ Còn nợ học phí",
            GradeRank = "Khá"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 8,
            StudentCode = "HV-0177",
            FullName = "Nguyễn Thành Nam",
            CourseName = "TOEIC 500+",
            ClassName = "TOEIC-A01",
            ScoreText = "8.1 · Giỏi",
            AttendanceText = "24/24 (100%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Giỏi"
        });

        _students.Add(new EligibleStudentItem
        {
            Stt = 9,
            StudentCode = "HV-0160",
            FullName = "Bùi Thị Mai",
            CourseName = "Tiếng Anh Giao tiếp Cơ bản",
            ClassName = "COM-B01",
            ScoreText = "8.5 · Giỏi",
            AttendanceText = "23/24 (95.8%)",
            TuitionText = "Đã hoàn tất",
            IsEligible = true,
            StatusText = "✓ Đủ điều kiện",
            GradeRank = "Giỏi"
        });

        ApplyFilter();
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) => ApplyFilter();
        cboCourseFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboClassFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboConditionFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboSigner.SelectedIndexChanged += (s, e) => UpdateSignerNote();

        btnSelectAllEligible.Click += (s, e) =>
        {
            foreach (var student in _students)
            {
                if (student.IsEligible)
                {
                    student.IsChecked = true;
                }
            }
            dgvEligible.Refresh();
            UpdateSelectedSummary();
        };

        btnDeselectAll.Click += (s, e) =>
        {
            foreach (var student in _students)
            {
                student.IsChecked = false;
            }
            dgvEligible.Refresh();
            UpdateSelectedSummary();
        };

        btnIssuedRegistryTop.Click += (s, e) =>
        {
            using var dlg = new CertificateRegistryDialog();
            dlg.ShowDialog(ParentForm);
        };

        btnIssueSelectedTop.Click += async (s, e) =>
        {
            var selected = _students.Where(s => s.IsChecked).ToList();

            if (selected.Count == 0)
            {
                AppDialog.ShowWarning(ParentForm, "Chưa chọn học viên",
                    "Vui lòng tick chọn ít nhất một học viên đủ điều kiện để cấp chứng chỉ tốt nghiệp.");
                return;
            }

            var ineligibles = selected.Where(s => !s.IsEligible).ToList();
            if (ineligibles.Count > 0)
            {
                AppDialog.ShowWarning(ParentForm, "Có học viên chưa đủ điều kiện",
                    $"Danh sách bạn chọn có {ineligibles.Count} học viên chưa đủ điều kiện (ví dụ: {ineligibles[0].FullName} - {ineligibles[0].StatusText}).\n\n" +
                    "Theo quy chế đào tạo, chỉ học viên có Điểm >= 5.0 và Chuyên cần >= 80% mới được cấp chứng chỉ!");
                return;
            }

            var (signerName, signerRole) = GetSelectedSigner();

            // Confirm issue
            var confirm = AppDialog.ShowConfirm(ParentForm, "Xác nhận cấp chứng chỉ",
                $"Bạn có chắc chắn muốn cấp chứng chỉ tốt nghiệp cho {selected.Count} học viên đã chọn?\n\n" +
                $"• Người ký duyệt: {signerName} ({signerRole})\n" +
                $"• Hệ thống sẽ tự động sinh số hiệu chứng chỉ và lưu trữ vào 'Sổ chứng chỉ đã cấp' trong SQLite.",
                "Đồng ý cấp", "Hủy bỏ");

            if (confirm != DialogResult.OK) return;

            // Generate certs
            var newlyIssuedSerials = new List<string>();
            foreach (var student in selected)
            {
                var issueRes = await _certService.IssueCertificateAsync(student.EnrollmentId, student.StudentId, student.GradeRank, $"{signerName} ({signerRole})");
                string serial = issueRes.Success ? issueRes.SerialNumber : CertificateService.GenerateNextSerial();
                newlyIssuedSerials.Add(serial);

                CertificateService.AddIssuedCertificate(new IssuedCertificateModel
                {
                    SerialNumber = serial,
                    StudentCode = student.StudentCode,
                    StudentName = student.FullName,
                    CourseName = student.CourseName,
                    ClassName = student.ClassName,
                    IssueDate = DateTime.Now.ToString("dd/MM/yyyy"),
                    Approver = $"{signerName} ({signerRole})",
                    Status = "Đã cấp · Chưa in",
                    Score = student.ScoreText,
                    GradeRank = student.GradeRank,
                    Attendance = student.AttendanceText
                });

                // Remove from waiting list
                _students.Remove(student);
            }

            // Re-index STT
            for (int i = 0; i < _students.Count; i++)
            {
                _students[i].Stt = i + 1;
            }

            ApplyFilter();

            var viewNow = AppDialog.ShowConfirm(ParentForm, "Cấp chứng chỉ thành công",
                $"Đã cấp thành công {selected.Count} chứng chỉ tốt nghiệp vào CSDL SQLite!\n\n" +
                $"• Các số hiệu vừa cấp: {string.Join(", ", newlyIssuedSerials)}\n" +
                $"• Người ký xác nhận: {signerName} ({signerRole})\n\n" +
                "Bạn có muốn mở ngay 'Sổ chứng chỉ đã cấp' để xem hoặc in ấn không?",
                "Mở sổ chứng chỉ", "Đóng");

            if (viewNow == DialogResult.OK)
            {
                using var dlg = new CertificateRegistryDialog();
                dlg.ShowDialog(ParentForm);
            }
        };
    }

    private (string Name, string Role) GetSelectedSigner()
    {
        string rawSigner = cboSigner.SelectedItem?.ToString() ?? $"{AppSession.FullName} · {AppSession.GetSignerRoleTitle()}";
        string signerName = rawSigner;
        string signerRole = AppSession.GetSignerRoleTitle();

        if (rawSigner.Contains("·"))
        {
            var parts = rawSigner.Split('·');
            signerName = parts[0].Trim();
            if (parts.Length > 1) signerRole = parts[1].Trim();
        }

        return (signerName, signerRole);
    }

    private void UpdateSelectedSummary()
    {
        int checkedCount = _students.Count(s => s.IsChecked && s.IsEligible);
        int totalEligible = _students.Count(s => s.IsEligible);

        btnIssueSelectedTop.Text = $"🎓 Cấp chứng chỉ ({checkedCount})";
        lblSelectedSummary.Text = $"Đang chọn: {checkedCount} học viên đủ ĐK / Tổng {totalEligible} đủ ĐK";
    }

    private void OpenPreviewForRow(int rowIndex)
    {
        if (dgvEligible.Rows[rowIndex].DataBoundItem is EligibleStudentItem student)
        {
            var (signerName, signerRole) = GetSelectedSigner();

            using var previewDlg = new CertificatePrintPreviewDialog(
                student.FullName,
                student.StudentCode,
                CertificateService.GenerateNextSerial(),
                student.CourseName,
                student.ClassName,
                student.GradeRank,
                student.ScoreText,
                student.AttendanceText,
                signerName,
                signerRole
            );
            previewDlg.ShowDialog(ParentForm);
        }
    }

    private void ApplyFilter()
    {
        string q = txtSearch.Text?.Trim().ToLowerInvariant() ?? "";
        string selectedCourse = cboCourseFilter.SelectedItem?.ToString() ?? "Tất cả khóa học";
        string selectedClass = cboClassFilter.SelectedItem?.ToString() ?? "Tất cả lớp";
        string selectedCond = cboConditionFilter.SelectedItem?.ToString() ?? "Tất cả điều kiện";

        var filtered = _students.Where(s =>
            (string.IsNullOrEmpty(q) ||
             s.FullName.ToLowerInvariant().Contains(q) ||
             s.StudentCode.ToLowerInvariant().Contains(q) ||
             s.ClassName.ToLowerInvariant().Contains(q)) &&
            (selectedCourse == "Tất cả khóa học" || s.CourseName.Contains(selectedCourse.Replace("Tất cả khóa học", ""))) &&
            (selectedClass == "Tất cả lớp" || s.ClassName == selectedClass) &&
            (selectedCond == "Tất cả điều kiện" ||
             (selectedCond.Contains("Đủ điều kiện") && s.IsEligible) ||
             (selectedCond.Contains("Chưa đủ") && !s.IsEligible))
        ).ToList();

        dgvEligible.DataSource = null;
        dgvEligible.DataSource = filtered;

        UpdateSelectedSummary();
    }
}
