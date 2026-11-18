using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class StudyMaterialView : UserControl
{
    private class MaterialItem
    {
        public string MaterialId { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string LocalPath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string ActionText => Status.Contains("✕") ? "Chọn lại tệp" : "Mở / Sửa";
    }

    private readonly List<MaterialItem> _allMaterials = new();

    public StudyMaterialView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboCourseFilter.Items.Clear();
        cboCourseFilter.Items.AddRange(new object[]
        {
            "IELTS Foundation",
            "TOEIC 450+",
            "Giao tiếp cơ bản",
            "Tất cả khóa học"
        });
        cboCourseFilter.SelectedIndex = 0;

        cboFileTypeFilter.Items.Clear();
        cboFileTypeFilter.Items.AddRange(new object[]
        {
            "Tất cả loại tệp",
            "PDF (.pdf)",
            "Audio (.mp3)",
            "Tài liệu (.docx)"
        });
        cboFileTypeFilter.SelectedIndex = 0;

        cboAssignedCourse.Items.Clear();
        cboAssignedCourse.Items.AddRange(new object[]
        {
            "IELTS Foundation",
            "TOEIC 450+",
            "English Communication Basic"
        });
        cboAssignedCourse.SelectedIndex = 0;

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
            HeaderText = "Tên tài liệu ↑",
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
            if (dgvMaterials.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                var val = e.Value.ToString() ?? "";
                if (val.Contains("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else if (val.Contains("✕"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
        };
    }

    private void LoadSampleData()
    {
        _allMaterials.Clear();
        _allMaterials.Add(new MaterialItem
        {
            MaterialId = "TL-001",
            FileName = "Foundation_Workbook_v1.2.pdf",
            Version = "1.2",
            CourseName = "IELTS Foundation",
            FileSize = "12,8 MB",
            Status = "✓ Tệp khả dụng",
            LocalPath = @"C:\ECMS\TaiLieu\IELTS\Foundation_Workbook_v1.2.pdf",
            FileType = "PDF"
        });

        _allMaterials.Add(new MaterialItem
        {
            MaterialId = "TL-002",
            FileName = "Listening_Practice_01.mp3",
            Version = "1.0",
            CourseName = "IELTS Foundation",
            FileSize = "8,4 MB",
            Status = "✓ Tệp khả dụng",
            LocalPath = @"C:\ECMS\TaiLieu\IELTS\Listening_Practice_01.mp3",
            FileType = "MP3"
        });

        _allMaterials.Add(new MaterialItem
        {
            MaterialId = "TL-003",
            FileName = "Grammar_Review_v1.pdf",
            Version = "1.0",
            CourseName = "IELTS Foundation",
            FileSize = "2,1 MB",
            Status = "✕ Không tìm thấy tệp",
            LocalPath = @"C:\ECMS\TaiLieu\IELTS\Grammar_Review_v1.pdf",
            FileType = "PDF"
        });

        ApplyFilter();

        if (dgvMaterials.Rows.Count > 0)
        {
            dgvMaterials.Rows[0].Selected = true;
            DisplayMaterialDetail(_allMaterials[0]);
        }
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

        var list = filtered.ToList();
        dgvMaterials.DataSource = null;
        dgvMaterials.DataSource = list;

        lblPagingInfo.Text = $"1–{list.Count} / {_allMaterials.Count} tài liệu";
    }

    private void DisplayMaterialDetail(MaterialItem item)
    {
        txtMaterialName.Text = item.FileName.Replace(".pdf", "").Replace(".mp3", "").Replace(".docx", "");
        txtVersion.Text = item.Version;
        cboAssignedCourse.SelectedItem = item.CourseName;
        cboFileType.SelectedItem = item.FileType;
        txtLocalPath.Text = item.LocalPath;

        if (item.Status.Contains("✕"))
        {
            // bannerMissingFile.Title = $"✕ {item.FileName} không còn ở đường dẫn cũ.";
            // bannerMissingFile.Message = "Chọn lại tệp để khôi phục khả năng mở tài liệu.";
            // bannerMissingFile.Visible = true;
            btnRebindMissingFile.Visible = true;
        }
        else
        {
            // bannerMissingFile.Title = "✓ Tài liệu đã liên kết hợp lệ";
            // bannerMissingFile.Message = $"Tệp khả dụng trên máy trạm: {item.FileSize}.";
            // bannerMissingFile.Variant = BannerVariant.Success;
            btnRebindMissingFile.Visible = false;
        }
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
            txtMaterialName.Text = string.Empty;
            txtVersion.Text = "1.0";
            cboAssignedCourse.SelectedIndex = 0;
            cboFileType.SelectedIndex = 0;
            txtLocalPath.Text = string.Empty;
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
                Filter = "Tất cả tệp hỗ trợ (*.pdf;*.mp3;*.docx)|*.pdf;*.mp3;*.docx|PDF Documents (*.pdf)|*.pdf|Audio (*.mp3)|*.mp3|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                txtLocalPath.Text = ofd.FileName;
                txtMaterialName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
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
                    $"✓ Tệp khả dụng trên máy trạm!\n\n" +
                    $"Đường dẫn: {path}\n" +
                    $"Dung lượng: {(fi.Length / (1024.0 * 1024.0)):F1} MB\n" +
                    $"Ngày tạo: {fi.CreationTime:dd/MM/yyyy HH:mm}");
            }
            else
            {
                AppDialog.ShowError(ParentForm, "Tệp không tồn tại",
                    $"✕ Không tìm thấy tệp tại đường dẫn:\n{path}\n\n" +
                    "Vui lòng kiểm tra lại ổ đĩa hoặc tệp có bị di chuyển / đổi tên không.");
            }
        };

        btnSaveMaterial.Click += (s, e) =>
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

            var newItem = new MaterialItem
            {
                MaterialId = $"TL-{( _allMaterials.Count + 1 ):D3}",
                FileName = Path.GetFileName(path) == "" ? $"{txtMaterialName.Text.Trim()}.pdf" : Path.GetFileName(path),
                Version = txtVersion.Text.Trim(),
                CourseName = cboAssignedCourse.SelectedItem?.ToString() ?? "IELTS Foundation",
                FileSize = "10,5 MB",
                Status = "✓ Tệp khả dụng",
                LocalPath = path,
                FileType = cboFileType.SelectedItem?.ToString() ?? "PDF"
            };

            _allMaterials.Add(newItem);
            ApplyFilter();
            AppDialog.ShowSuccess(ParentForm, "Lưu thành công",
                $"Đã lưu thông tin tài liệu '{newItem.FileName}' vào CSDL SQLite.");
        };

        btnRebindMissingFile.Click += (s, e) =>
        {
            btnBrowseLocalFile.PerformClick();
        };

        btnAssignClassDoc.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Gán tài liệu",
                "Đã gán tài liệu của khóa English Communication Basic vào lớp COM-B01 thành công.");
        };
    }
}
