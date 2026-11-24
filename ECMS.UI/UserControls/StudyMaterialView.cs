using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class StudyMaterialView : UserControl
{
    private class MaterialItem
    {
        public int MaterialId { get; set; }
        public int CourseId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string LocalPath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string ActionText => Status.Contains("Chưa") ? "Chọn tệp" : "Mở / Sửa";
    }

    private readonly ICourseService _courseService = new CourseService();
    private readonly List<MaterialItem> _allMaterials = new();
    private readonly List<Course> _courses = new();
    private int _editingMaterialId = 0;

    public StudyMaterialView()
    {
        InitializeComponent();
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupFilters();
        SetupGrid();
        WireEvents();
        _ = LoadInitialDataAsync();
    }

    private void SetupFilters()
    {
        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.Add("Tất cả khóa học");
        cboCourseFilter.SelectedIndex = 0;

        cboFileTypeFilter.Items.Clear();
        cboFileTypeFilter.Items.AddRange(new object[]
        {
            "Tất cả loại tệp",
            "PDF",
            "MP3",
            "DOCX",
            "ZIP"
        });
        cboFileTypeFilter.SelectedIndex = 0;

        cboAssignedCourse.Items.Clear();

        cboFileType.Items.Clear();
        cboFileType.Items.AddRange(new object[]
        {
            "PDF",
            "MP3",
            "DOCX",
            "ZIP"
        });
        cboFileType.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvMaterials.AutoGenerateColumns = false;
        dgvMaterials.Columns.Clear();
        dgvMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMaterials.MultiSelect = false;
        dgvMaterials.ReadOnly = true;
        dgvMaterials.RowHeadersVisible = false;
        dgvMaterials.AllowUserToAddRows = false;

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FileName",
            HeaderText = "Tên tài liệu",
            Width = 260
        });

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Version",
            HeaderText = "Phiên bản",
            Width = 90
        });

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "CourseName",
            HeaderText = "Khóa học",
            Width = 180
        });

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FileSize",
            HeaderText = "Dung lượng",
            Width = 110
        });

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 160
        });

        dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ActionText",
            HeaderText = "Thao tác",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.FromArgb(37, 99, 235),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });

        dgvMaterials.CellFormatting += (s, e) =>
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (dgvMaterials.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                var val = e.Value.ToString() ?? "";
                if (val.Contains("Khả dụng", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
        };
    }

    private async Task LoadInitialDataAsync()
    {
        try
        {
            _courses.Clear();
            _courses.AddRange(await _courseService.GetCoursesAsync());

            cboCourseFilter.Items.Clear();
            cboCourseFilter.Items.Add("Tất cả khóa học");
            cboAssignedCourse.Items.Clear();

            foreach (var c in _courses.Where(c => c.IsActive))
            {
                cboCourseFilter.Items.Add(c.CourseName);
                cboAssignedCourse.Items.Add(c.CourseName);
            }

            if (cboCourseFilter.Items.Count > 0) cboCourseFilter.SelectedIndex = 0;
            if (cboAssignedCourse.Items.Count > 0) cboAssignedCourse.SelectedIndex = 0;

            await LoadMaterialsFromDbAsync();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi tải dữ liệu tài liệu", ex.Message);
        }
    }

    private async Task LoadMaterialsFromDbAsync()
    {
        try
        {
            var rows = await _courseService.GetStudyMaterialsAsync();
            _allMaterials.Clear();

            foreach (var r in rows)
            {
                bool fileExists = !string.IsNullOrWhiteSpace(r.FilePath) && File.Exists(r.FilePath);
                string sizeText = !string.IsNullOrWhiteSpace(r.FileSize)
                    ? r.FileSize
                    : (fileExists ? FormatFileSize(new FileInfo(r.FilePath).Length) : "—");

                _allMaterials.Add(new MaterialItem
                {
                    MaterialId = r.MaterialId,
                    CourseId = r.CourseId,
                    FileName = r.Title,
                    Version = string.IsNullOrWhiteSpace(r.Version) ? "1.0" : r.Version,
                    CourseName = r.CourseName,
                    FileSize = sizeText,
                    Status = fileExists ? "Khả dụng" : "Chưa có tệp cục bộ",
                    LocalPath = r.FilePath,
                    FileType = string.IsNullOrWhiteSpace(r.FileType) ? "PDF" : r.FileType
                });
            }

            ApplyFilter();

            if (dgvMaterials.Rows.Count > 0 && _allMaterials.Count > 0)
            {
                dgvMaterials.Rows[0].Selected = true;
                if (dgvMaterials.Rows[0].DataBoundItem is MaterialItem firstItem)
                {
                    DisplayMaterialDetail(firstItem);
                }
            }
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(ParentForm, "Lỗi nạp danh sách tài liệu", ex.Message);
        }
    }

    private static string FormatFileSize(long bytes)
    {
        if (bytes >= 1024 * 1024)
            return $"{bytes / (1024.0 * 1024.0):F1} MB";
        if (bytes >= 1024)
            return $"{bytes / 1024.0:F0} KB";
        return $"{bytes} B";
    }

    private void ApplyFilter()
    {
        var filtered = _allMaterials.AsEnumerable();

        var query = txtSearchMaterial.Text?.Trim().ToLowerInvariant();
        if (!string.IsNullOrEmpty(query))
        {
            filtered = filtered.Where(m =>
                m.FileName.ToLowerInvariant().Contains(query) ||
                m.CourseName.ToLowerInvariant().Contains(query) ||
                m.Version.Contains(query));
        }

        var course = cboCourseFilter.SelectedItem?.ToString();
        if (!string.IsNullOrEmpty(course) && course != "Tất cả khóa học")
        {
            filtered = filtered.Where(m => m.CourseName.Equals(course, StringComparison.OrdinalIgnoreCase));
        }

        var fileType = cboFileTypeFilter.SelectedItem?.ToString();
        if (!string.IsNullOrEmpty(fileType) && fileType != "Tất cả loại tệp")
        {
            filtered = filtered.Where(m => m.FileType.Equals(fileType, StringComparison.OrdinalIgnoreCase));
        }

        var list = filtered.ToList();
        dgvMaterials.DataSource = null;
        dgvMaterials.DataSource = list;

        lblPagingInfo.Text = list.Count == 0
            ? "0 tài liệu"
            : $"1–{list.Count} / {_allMaterials.Count} tài liệu";
    }

    private void DisplayMaterialDetail(MaterialItem item)
    {
        _editingMaterialId = item.MaterialId;
        txtMaterialName.Text = item.FileName;
        txtVersion.Text = item.Version;

        int courseIdx = cboAssignedCourse.FindStringExact(item.CourseName);
        if (courseIdx >= 0) cboAssignedCourse.SelectedIndex = courseIdx;

        int typeIdx = cboFileType.FindStringExact(item.FileType);
        if (typeIdx >= 0) cboFileType.SelectedIndex = typeIdx;

        txtLocalPath.Text = item.LocalPath;
        btnRebindMissingFile.Visible = item.Status.Contains("Chưa");
    }

    private void WireEvents()
    {
        dgvMaterials.SelectionChanged += (s, e) =>
        {
            if (dgvMaterials.CurrentRow?.DataBoundItem is MaterialItem item)
            {
                DisplayMaterialDetail(item);
            }
        };

        txtSearchMaterial.TextChanged += (s, e) => ApplyFilter();
        cboCourseFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboFileTypeFilter.SelectedIndexChanged += (s, e) => ApplyFilter();

        btnAddMaterialTop.Click += (s, e) =>
        {
            _editingMaterialId = 0;
            txtMaterialName.Text = string.Empty;
            txtVersion.Text = "1.0";
            if (cboAssignedCourse.Items.Count > 0) cboAssignedCourse.SelectedIndex = 0;
            if (cboFileType.Items.Count > 0) cboFileType.SelectedIndex = 0;
            txtLocalPath.Text = string.Empty;
            btnRebindMissingFile.Visible = false;
            txtMaterialName.Focus();
        };

        btnCancelMaterial.Click += (s, e) =>
        {
            if (dgvMaterials.CurrentRow?.DataBoundItem is MaterialItem item)
            {
                DisplayMaterialDetail(item);
            }
        };

        btnBrowseLocalFile.Click += (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp tài liệu học tập cục bộ",
                Filter = "Tất cả tệp hỗ trợ (*.pdf;*.mp3;*.docx;*.zip)|*.pdf;*.mp3;*.docx;*.zip|PDF Documents (*.pdf)|*.pdf|Audio (*.mp3)|*.mp3|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtLocalPath.Text = ofd.FileName;
                if (string.IsNullOrWhiteSpace(txtMaterialName.Text))
                {
                    txtMaterialName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                }
                var ext = Path.GetExtension(ofd.FileName).ToUpperInvariant().TrimStart('.');
                if (cboFileType.Items.Contains(ext))
                {
                    cboFileType.SelectedItem = ext;
                }
            }
        };

        btnCheckLocalPath.Click += (s, e) =>
        {
            var path = txtLocalPath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                AppDialog.ShowError(ParentForm, "Chưa nhập đường dẫn", "Vui lòng nhập hoặc chọn đường dẫn tệp cục bộ.");
                return;
            }

            if (File.Exists(path))
            {
                var fi = new FileInfo(path);
                AppDialog.ShowSuccess(ParentForm, "Kiểm tra thành công",
                    $"Tệp khả dụng trên máy trạm!\n\n" +
                    $"Đường dẫn: {path}\n" +
                    $"Dung lượng: {FormatFileSize(fi.Length)}\n" +
                    $"Ngày tạo: {fi.CreationTime:dd/MM/yyyy HH:mm}");
            }
            else
            {
                AppDialog.ShowError(ParentForm, "Tệp không tồn tại",
                    $"Không tìm thấy tệp tại đường dẫn:\n{path}\n\n" +
                    "Vui lòng kiểm tra lại ổ đĩa hoặc tệp có bị di chuyển / đổi tên không.");
            }
        };

        btnSaveMaterial.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtMaterialName.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tên tài liệu.");
                txtMaterialName.Focus();
                return;
            }

            var path = txtLocalPath.Text.Trim();
            if (string.IsNullOrWhiteSpace(path))
            {
                AppDialog.ShowError(ParentForm, "Thiếu đường dẫn", "Vui lòng nhập đường dẫn tệp cục bộ.");
                txtLocalPath.Focus();
                return;
            }

            string selectedCourseName = cboAssignedCourse.SelectedItem?.ToString() ?? "";
            var course = _courses.FirstOrDefault(c => c.CourseName == selectedCourseName);
            if (course == null)
            {
                AppDialog.ShowWarning(ParentForm, "Thiếu khóa học", "Vui lòng chọn khóa học áp dụng.");
                return;
            }

            string fileSize = File.Exists(path) ? FormatFileSize(new FileInfo(path).Length) : "—";
            var dto = new StudyMaterialDto
            {
                MaterialId = _editingMaterialId,
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                Title = txtMaterialName.Text.Trim(),
                FilePath = path,
                Version = string.IsNullOrWhiteSpace(txtVersion.Text) ? "1.0" : txtVersion.Text.Trim(),
                FileType = cboFileType.SelectedItem?.ToString() ?? "PDF",
                FileSize = fileSize,
                Description = $"Tài liệu khóa {course.CourseName}"
            };

            var res = await _courseService.SaveStudyMaterialAsync(dto);
            if (!res.Success)
            {
                AppDialog.ShowError(ParentForm, "Lỗi lưu tài liệu", res.Message);
                return;
            }

            await LoadMaterialsFromDbAsync();
            AppDialog.ShowSuccess(ParentForm, "Lưu thành công", res.Message);
        };

        btnRebindMissingFile.Click += (s, e) => btnBrowseLocalFile.PerformClick();

        btnAssignClassDoc.Click += async (s, e) =>
        {
            if (btnSaveMaterial != null)
            {
                btnSaveMaterial.PerformClick();
            }
            await Task.CompletedTask;
        };
    }
}
