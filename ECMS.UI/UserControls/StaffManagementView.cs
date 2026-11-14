using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class StaffManagementView : UserControl
{
    private class StaffItem
    {
        public string StaffCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string LinkedAccount { get; set; } = string.Empty;
        public string Assignment { get; set; } = string.Empty;
        public string Permission { get; set; } = string.Empty;
        public string ActionText => "Xem / Sửa";
    }

    private readonly List<StaffItem> _allStaff = new();

    public StaffManagementView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboStatusFilter.Items.Clear();
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Đang làm việc",
            "Đã nghỉ việc",
            "Tất cả trạng thái"
        });
        cboStatusFilter.SelectedIndex = 0;

        cboDepartmentFilter.Items.Clear();
        cboDepartmentFilter.Items.AddRange(new object[]
        {
            "Tất cả bộ phận",
            "Quản trị hệ thống",
            "Tư vấn tuyển sinh",
            "Kế toán",
            "Đào tạo"
        });
        cboDepartmentFilter.SelectedIndex = 0;

        cboDepartment.Items.Clear();
        cboDepartment.Items.AddRange(new object[]
        {
            "Tư vấn tuyển sinh",
            "Kế toán",
            "Đào tạo",
            "Quản trị hệ thống"
        });
        cboDepartment.SelectedIndex = 0;

        cboStatus.Items.Clear();
        cboStatus.Items.AddRange(new object[]
        {
            "Đang làm việc",
            "Đã nghỉ việc"
        });
        cboStatus.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvStaff.AutoGenerateColumns = false;
        dgvStaff.Columns.Clear();
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStaff.MultiSelect = false;
        dgvStaff.ReadOnly = true;
        dgvStaff.RowHeadersVisible = false;
        dgvStaff.AllowUserToAddRows = false;

        dgvStaff.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "StaffCode",
            HeaderText = "Mã ↑",
            Width = 90
        });

        dgvStaff.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "FullName",
            HeaderText = "Họ và tên",
            Width = 180
        });

        dgvStaff.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Department",
            HeaderText = "Bộ phận",
            Width = 160
        });

        dgvStaff.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ActionText",
            HeaderText = "Thao tác",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.FromArgb(37, 99, 235),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });
    }

    private void LoadSampleData()
    {
        _allStaff.Clear();
        _allStaff.Add(new StaffItem
        {
            StaffCode = "NV-001",
            FullName = "Trần Minh Quân",
            Department = "Quản trị hệ thống",
            Phone = "0901 123 456",
            Email = "quan.tm@minhtri.local",
            HireDate = new DateTime(2024, 1, 10),
            Status = "Đang làm việc",
            LinkedAccount = "admin · Quản trị viên hệ thống",
            Assignment = "Vận hành hệ thống & CSDL SQLite",
            Permission = "Toàn quyền quản trị hệ thống"
        });

        _allStaff.Add(new StaffItem
        {
            StaffCode = "NV-002",
            FullName = "Phạm Ngọc Mai",
            Department = "Tư vấn tuyển sinh",
            Phone = "0902 552 778",
            Email = "mai@minhtri.local",
            HireDate = new DateTime(2025, 3, 15),
            Status = "Đang làm việc",
            LinkedAccount = "ngocmai.tv · Nhân viên tư vấn",
            Assignment = "42 khách tiềm năng tháng 10",
            Permission = "Không được cấu hình hệ thống"
        });

        _allStaff.Add(new StaffItem
        {
            StaffCode = "NV-003",
            FullName = "Lê Phương Thảo",
            Department = "Kế toán",
            Phone = "0903 889 900",
            Email = "thao.lp@minhtri.local",
            HireDate = new DateTime(2025, 5, 20),
            Status = "Đang làm việc",
            LinkedAccount = "thao.kt · Nhân viên kế toán",
            Assignment = "Thu học phí & phiếu thu tiền mặt",
            Permission = "Thu tiền, xuất phiếu, xem công nợ"
        });

        _allStaff.Add(new StaffItem
        {
            StaffCode = "NV-004",
            FullName = "Nguyễn Thị Hạnh",
            Department = "Đào tạo",
            Phone = "0904 678 123",
            Email = "hanh.nt@minhtri.local",
            HireDate = new DateTime(2024, 8, 1),
            Status = "Đang làm việc",
            LinkedAccount = "hanh.dt · Quản lý đào tạo",
            Assignment = "Quản lý khóa học & xét cấp chứng chỉ",
            Permission = "Điểm số, chứng chỉ, lịch học"
        });

        ApplyFilter();

        if (dgvStaff.Rows.Count > 1)
        {
            dgvStaff.Rows[1].Selected = true;
            DisplayStaffDetail(_allStaff[1]);
        }
    }

    private void ApplyFilter()
    {
        var filtered = _allStaff.AsEnumerable();

        var query = txtSearchStaff.Text?.Trim().ToLowerInvariant();
        if (!string.IsNullOrEmpty(query))
        {
            filtered = filtered.Where(s =>
                s.StaffCode.ToLowerInvariant().Contains(query) ||
                s.FullName.ToLowerInvariant().Contains(query) ||
                s.Phone.Contains(query));
        }

        var status = cboStatusFilter.SelectedItem?.ToString();
        if (!string.IsNullOrEmpty(status) && status != "Tất cả trạng thái")
        {
            filtered = filtered.Where(s => s.Status == status);
        }

        var dept = cboDepartmentFilter.SelectedItem?.ToString();
        if (!string.IsNullOrEmpty(dept) && dept != "Tất cả bộ phận")
        {
            filtered = filtered.Where(s => s.Department == dept);
        }

        var list = filtered.ToList();
        dgvStaff.DataSource = null;
        dgvStaff.DataSource = list;

        lblPagingInfo.Text = $"1–{list.Count} / {_allStaff.Count} nhân viên";
    }

    private void DisplayStaffDetail(StaffItem staff)
    {
        lblStaffDetailTitle.Text = $"Chi tiết · {staff.FullName}";
        lblContactVal.Text = $"{staff.Phone} · {staff.Email}";
        lblHireStatusVal.Text = $"{staff.HireDate:dd/MM/yyyy} · {staff.Status}";
        lblLinkedAccountVal.Text = staff.LinkedAccount;
        lblAssignmentVal.Text = staff.Assignment;
        lblPermissionVal.Text = staff.Permission;

        txtStaffCode.Text = staff.StaffCode;
        txtFullName.Text = staff.FullName;
        txtPhone.Text = staff.Phone;
        dtpHireDate.Value = staff.HireDate;
        cboDepartment.SelectedItem = staff.Department;
        cboStatus.SelectedItem = staff.Status;
        txtEmail.Text = staff.Email;
    }

    private void WireEvents()
    {
        dgvStaff.SelectionChanged += (s, e) =>
        {
            if (dgvStaff.CurrentRow?.DataBoundItem is StaffItem item)
            {
                DisplayStaffDetail(item);
            }
        };

        txtSearchStaff.TextChanged += (s, e) => ApplyFilter();
        cboStatusFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboDepartmentFilter.SelectedIndexChanged += (s, e) => ApplyFilter();

        btnCreateStaff.Click += (s, e) =>
        {
            txtStaffCode.Text = $"NV-{( _allStaff.Count + 1 ):D3}";
            txtFullName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dtpHireDate.Value = DateTime.Today;
            cboDepartment.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtEmail.Text = string.Empty;
            txtFullName.Focus();
        };

        btnCancelStaff.Click += (s, e) =>
        {
            if (dgvStaff.CurrentRow?.DataBoundItem is StaffItem item)
            {
                DisplayStaffDetail(item);
            }
        };

        btnSaveStaff.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập họ và tên nhân viên.");
                txtFullName.Focus();
                return;
            }

            var code = txtStaffCode.Text.Trim();
            var existing = _allStaff.FirstOrDefault(x => x.StaffCode.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.FullName = txtFullName.Text.Trim();
                existing.Phone = txtPhone.Text.Trim();
                existing.HireDate = dtpHireDate.Value;
                existing.Department = cboDepartment.SelectedItem?.ToString() ?? "Tư vấn tuyển sinh";
                existing.Status = cboStatus.SelectedItem?.ToString() ?? "Đang làm việc";
                existing.Email = txtEmail.Text.Trim();
            }
            else
            {
                var newStaff = new StaffItem
                {
                    StaffCode = code,
                    FullName = txtFullName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    HireDate = dtpHireDate.Value,
                    Department = cboDepartment.SelectedItem?.ToString() ?? "Tư vấn tuyển sinh",
                    Status = cboStatus.SelectedItem?.ToString() ?? "Đang làm việc",
                    Email = txtEmail.Text.Trim(),
                    LinkedAccount = $"{code.ToLowerInvariant()} · {cboDepartment.SelectedItem}",
                    Assignment = "Chưa có công việc phân công",
                    Permission = "Theo vai trò bộ phận"
                };
                _allStaff.Add(newStaff);
            }

            ApplyFilter();
            AppDialog.ShowSuccess(ParentForm, "Lưu thành công", $"Đã lưu hồ sơ nhân viên {txtFullName.Text} thành công vào CSDL cục bộ.");
        };

        btnOpenLinkedAccount.Click += (s, e) =>
        {
            AppDialog.ShowSuccess(ParentForm, "Tài khoản liên kết",
                $"Đang mở phân quyền cho tài khoản: {lblLinkedAccountVal.Text}\n" +
                "Bạn có thể đổi mật khẩu và phân quyền chi tiết tại mô-đun Tài khoản & Phân quyền.");
        };
    }
}
