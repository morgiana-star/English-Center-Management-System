using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Services;

namespace ECMS.UI.Forms;

public partial class CertificateRegistryDialog : Form
{
    private IssuedCertificateModel? _selectedCert;
    private readonly ICertificateService _certService = new ECMS.Business.Services.CertificateService();
    private List<IssuedCertificateModel> _loadedCerts = new();

    public CertificateRegistryDialog()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrid();
        LoadCertificates();
        WireEvents();
    }

    public CertificateRegistryDialog(string studentName, string studentCode, string certSerial) : this()
    {
        var certs = ECMS.UI.Services.CertificateService.GetIssuedCertificates();
        var match = certs.FirstOrDefault(c => c.SerialNumber == certSerial || c.StudentCode == studentCode);
        if (match != null)
        {
            _selectedCert = match;
            HighlightCertificate(match.SerialNumber);
        }
    }

    private void SetupFilters()
    {
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

        cboYearFilter.Items.Clear();
        cboYearFilter.Items.AddRange(new object[]
        {
            "Tất cả các năm",
            "Năm 2026",
            "Năm 2025"
        });
        cboYearFilter.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        gridRegistry.AutoGenerateColumns = false;
        gridRegistry.Columns.Clear();
        gridRegistry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridRegistry.MultiSelect = false;
        gridRegistry.ReadOnly = true;
        gridRegistry.RowHeadersVisible = false;
        gridRegistry.AllowUserToAddRows = false;
        gridRegistry.AllowUserToDeleteRows = false;

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStt",
            DataPropertyName = "Stt",
            HeaderText = "STT",
            Width = 45,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCertNo",
            DataPropertyName = "SerialNumber",
            HeaderText = "Số chứng chỉ",
            Width = 125,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Consolas", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(37, 99, 235) }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCode",
            DataPropertyName = "StudentCode",
            HeaderText = "Mã HV",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStudent",
            DataPropertyName = "StudentName",
            HeaderText = "Họ và tên",
            Width = 160,
            DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42) }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCourse",
            DataPropertyName = "CourseName",
            HeaderText = "Khóa học",
            Width = 150
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colClass",
            DataPropertyName = "ClassName",
            HeaderText = "Lớp",
            Width = 90
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colScore",
            DataPropertyName = "Score",
            HeaderText = "Điểm / Xếp loại",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9f, FontStyle.Bold) }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colAttendance",
            DataPropertyName = "Attendance",
            HeaderText = "Chuyên cần",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colDate",
            DataPropertyName = "IssueDate",
            HeaderText = "Ngày cấp",
            Width = 95,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colApprover",
            DataPropertyName = "Approver",
            HeaderText = "Người ký duyệt",
            Width = 160
        });

        gridRegistry.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStatus",
            DataPropertyName = "Status",
            HeaderText = "Trạng thái in",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        var btnActionCol = new DataGridViewButtonColumn
        {
            Name = "colAction",
            HeaderText = "Thao tác",
            Text = "🖨️ Xem & In",
            UseColumnTextForButtonValue = true,
            Width = 110,
            FlatStyle = FlatStyle.Flat
        };
        gridRegistry.Columns.Add(btnActionCol);

        gridRegistry.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridRegistry.Rows.Count) return;

            string colName = gridRegistry.Columns[e.ColumnIndex].Name;
            var val = e.Value?.ToString() ?? "";

            if (colName == "colStatus")
            {
                if (val.Contains("Đã in"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                    e.CellStyle!.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(234, 88, 12);
                }
            }
        };

        gridRegistry.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && gridRegistry.Columns[e.ColumnIndex].Name == "colAction")
            {
                OpenPreviewForRow(e.RowIndex);
            }
        };

        gridRegistry.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0)
            {
                OpenPreviewForRow(e.RowIndex);
            }
        };
    }

    private void WireEvents()
    {
        txtSearch.TextChanged += (s, e) => LoadCertificates();
        cboCourseFilter.SelectedIndexChanged += (s, e) => LoadCertificates();
        cboYearFilter.SelectedIndexChanged += (s, e) => LoadCertificates();


        btnExportExcel.Click += async (s, e) =>
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất sổ cấp chứng chỉ tốt nghiệp ra Excel",
                Filter = "Tệp Excel (*.xlsx)|*.xlsx",
                FileName = $"So_ChungChi_ECMS_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    List<IssuedCertificateModel> certsToExport;
                    if (_loadedCerts.Count > 0)
                    {
                        certsToExport = _loadedCerts;
                    }
                    else
                    {
                        var dbCerts = await _certService.GetIssuedCertificatesAsync();
                        certsToExport = dbCerts.Select(c => new IssuedCertificateModel
                        {
                            SerialNumber = c.SerialNumber,
                            StudentCode = c.StudentCode,
                            StudentName = c.StudentName,
                            CourseName = c.CourseName,
                            ClassName = c.ClassName,
                            IssueDate = c.IssueDate,
                            Approver = c.Approver,
                            Status = c.Status,
                            Score = c.Score,
                            GradeRank = c.GradeRank,
                            Attendance = c.Attendance
                        }).ToList();
                        if (certsToExport.Count == 0)
                            certsToExport = ECMS.UI.Services.CertificateService.GetIssuedCertificates();
                    }

                    ExcelExportService.ExportCertificateRegistryReport(sfd.FileName, certsToExport);
                    AppDialog.ShowSuccess(this, "Xuất sổ chứng chỉ thành công",
                        $"Đã xuất thành công {certsToExport.Count} bản ghi sổ chứng chỉ ra tệp Excel:\n{sfd.FileName}");
                }
                catch (Exception ex)
                {
                    AppDialog.ShowError(this, "Lỗi xuất Excel", $"Không thể xuất tệp Excel: {ex.Message}");
                }
            }
        };

        btnPreviewPrint.Click += (s, e) =>
        {
            if (gridRegistry.CurrentRow != null && gridRegistry.CurrentRow.Index >= 0)
            {
                OpenPreviewForRow(gridRegistry.CurrentRow.Index);
            }
            else
            {
                AppDialog.ShowInfo(this, "Thông báo", "Vui lòng chọn một chứng chỉ từ bảng để xem trước hoặc in.");
            }
        };
    }

    private class RegistryDisplayRow
    {
        public int Stt { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public string StudentCode { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;
        public string Attendance { get; set; } = string.Empty;
        public string IssueDate { get; set; } = string.Empty;
        public string Approver { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public IssuedCertificateModel OriginalCert { get; set; } = null!;
    }

    private async void LoadCertificates()
    {
        string q = txtSearch.Text?.Trim().ToLowerInvariant() ?? "";
        string selectedCourse = cboCourseFilter.SelectedItem?.ToString() ?? "Tất cả khóa học";
        string selectedYear = cboYearFilter.SelectedItem?.ToString() ?? "Tất cả các năm";

        List<IssuedCertificateModel> certs = new();
        try
        {
            var dbCerts = await _certService.GetIssuedCertificatesAsync();
            foreach (var c in dbCerts)
            {
                certs.Add(new IssuedCertificateModel
                {
                    SerialNumber = c.SerialNumber,
                    StudentCode = c.StudentCode,
                    StudentName = c.StudentName,
                    CourseName = c.CourseName,
                    ClassName = c.ClassName,
                    IssueDate = c.IssueDate,
                    Approver = c.Approver,
                    Status = c.Status,
                    Score = c.Score,
                    GradeRank = c.GradeRank,
                    Attendance = c.Attendance
                });
            }
        }
        catch
        {
            certs = ECMS.UI.Services.CertificateService.GetIssuedCertificates();
        }

        if (certs.Count == 0)
        {
            certs = ECMS.UI.Services.CertificateService.GetIssuedCertificates();
        }

        var filtered = certs.Where(c =>
            (string.IsNullOrEmpty(q) ||
             c.SerialNumber.ToLowerInvariant().Contains(q) ||
             c.StudentName.ToLowerInvariant().Contains(q) ||
             c.StudentCode.ToLowerInvariant().Contains(q) ||
             c.ClassName.ToLowerInvariant().Contains(q)) &&
            (selectedCourse == "Tất cả khóa học" || c.CourseName.Contains(selectedCourse.Replace("Tất cả khóa học", ""))) &&
            (selectedYear == "Tất cả các năm" || c.IssueDate.Contains(selectedYear.Replace("Năm ", "")))
        ).ToList();

        _loadedCerts = filtered;

        var displayList = filtered.Select((c, idx) => new RegistryDisplayRow
        {
            Stt = idx + 1,
            SerialNumber = c.SerialNumber,
            StudentCode = c.StudentCode,
            StudentName = c.StudentName,
            CourseName = c.CourseName,
            ClassName = c.ClassName,
            Score = $"{c.Score} ({c.GradeRank})",
            Attendance = c.Attendance,
            IssueDate = c.IssueDate,
            Approver = c.Approver,
            Status = c.Status,
            OriginalCert = c
        }).ToList();

        gridRegistry.DataSource = null;
        gridRegistry.DataSource = displayList;
    }

    private void HighlightCertificate(string serial)
    {
        for (int i = 0; i < gridRegistry.Rows.Count; i++)
        {
            if (gridRegistry.Rows[i].DataBoundItem is RegistryDisplayRow row && row.SerialNumber == serial)
            {
                gridRegistry.Rows[i].Selected = true;
                gridRegistry.CurrentCell = gridRegistry.Rows[i].Cells[0];
                break;
            }
        }
    }

    private void OpenPreviewForRow(int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= gridRegistry.Rows.Count) return;

        if (gridRegistry.Rows[rowIndex].DataBoundItem is RegistryDisplayRow row)
        {
            var cert = row.OriginalCert;
            string signerName = cert.Approver;
            string signerRole = "GIÁM ĐỐC TRUNG TÂM";

            if (signerName.Contains("·"))
            {
                var parts = signerName.Split('·');
                signerName = parts[0].Trim();
                if (parts.Length > 1) signerRole = parts[1].Trim();
            }
            else if (signerName.Contains("("))
            {
                int openParen = signerName.IndexOf('(');
                int closeParen = signerName.IndexOf(')');
                if (openParen > 0 && closeParen > openParen)
                {
                    signerRole = signerName.Substring(openParen + 1, closeParen - openParen - 1);
                    signerName = signerName.Substring(0, openParen).Trim();
                }
            }

            using var previewDlg = new CertificatePrintPreviewDialog(
                cert.StudentName,
                cert.StudentCode,
                cert.SerialNumber,
                cert.CourseName,
                cert.ClassName,
                cert.GradeRank,
                cert.Score,
                cert.Attendance,
                signerName,
                signerRole
            );
            previewDlg.ShowDialog(this);
        }
    }
}
