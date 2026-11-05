using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class RbacMatrixDialog : Form
{
    private readonly IRbacService _rbacService;
    private List<Role> _roles = new();
    private Role? _selectedRole;
    private List<RolePermissionDto> _currentPermissions = new();

    private ListBox lstRoles = null!;
    private Label lblSelectedRoleTitle = null!;
    private Label lblSelectedRoleDesc = null!;
    private Label lblRolePill = null!;
    private ModernTextBox txtSearchPerm = null!;
    private DataGridView dgvPermissions = null!;
    private CustomButton btnSave = null!;
    private CustomButton btnResetDefault = null!;
    private CustomButton btnSelectAll = null!;
    private CustomButton btnDeselectAll = null!;
    private CustomButton btnClose = null!;

    public RbacMatrixDialog(IRbacService? rbacService = null)
    {
        _rbacService = rbacService ?? new RbacService();
        InitializeComponents();
        Load += async (s, e) => await LoadInitialDataAsync();
    }

    private void InitializeComponents()
    {
        Text = "ECMS - Cấu hình ma trận phân quyền động (RBAC)";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(1000, 670);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(15, 15),
            Size = new Size(970, 640),
            CornerRadius = 16,
            EnableShadow = true
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = "MA TRẬN PHÂN QUYỀN CHỨC NĂNG HỆ THỐNG (RBAC MANAGEMENT)",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Cấu hình phân quyền chi tiết động theo từng vai trò trên các phân hệ nghiệp vụ",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // Left Panel: Roles List
        var pnlLeft = new RoundedPanel
        {
            Location = new Point(20, 70),
            Size = new Size(240, 500),
            CornerRadius = 10,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1,
            BackColor = Color.White
        };

        var lblRoleListHeader = new Label
        {
            Text = "DANH MỤC VAI TRÒ",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(12, 10),
            AutoSize = true
        };

        lstRoles = new ListBox
        {
            Location = new Point(10, 35),
            Size = new Size(220, 450),
            BorderStyle = BorderStyle.None,
            Font = new Font("Segoe UI", 10f),
            ForeColor = ThemeColors.TextPrimary,
            ItemHeight = 28
        };
        lstRoles.SelectedIndexChanged += async (s, e) => await OnRoleSelectedAsync();

        pnlLeft.Controls.Add(lblRoleListHeader);
        pnlLeft.Controls.Add(lstRoles);

        // Right Panel: Role Detail & Permission Matrix
        var pnlRight = new RoundedPanel
        {
            Location = new Point(275, 70),
            Size = new Size(675, 500),
            CornerRadius = 10,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1,
            BackColor = Color.White
        };

        // Role header inside right panel
        lblSelectedRoleTitle = new Label
        {
            Text = "Đang tải vai trò...",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(15, 12),
            AutoSize = true
        };

        lblRolePill = new Label
        {
            Text = "ROLE",
            Font = ThemeColors.FontBadge,
            ForeColor = Color.FromArgb(79, 70, 229),
            BackColor = Color.FromArgb(238, 242, 255),
            Location = new Point(540, 12),
            Padding = new Padding(8, 4, 8, 4),
            AutoSize = true
        };

        lblSelectedRoleDesc = new Label
        {
            Text = "Mô tả vai trò",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(15, 38),
            Size = new Size(640, 20),
            AutoSize = false
        };

        // Search & Quick Action Toolbar
        txtSearchPerm = new ModernTextBox
        {
            Placeholder = "🔍 Lọc quyền theo mã, tên hoặc phân hệ...",
            Location = new Point(15, 65),
            Size = new Size(270, 34),
            CornerRadius = 6
        };
        txtSearchPerm.TextChanged += (s, e) => FilterPermissionGrid();

        btnSelectAll = new CustomButton
        {
            Text = "Chọn hết",
            NormalColor = Color.FromArgb(241, 245, 249),
            HoverColor = Color.FromArgb(226, 232, 240),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(295, 65),
            Size = new Size(80, 34),
            CornerRadius = 6,
            Font = ThemeColors.FontCaption
        };
        btnSelectAll.Click += (s, e) => SetAllPermissionsChecked(true);

        btnDeselectAll = new CustomButton
        {
            Text = "Bỏ hết",
            NormalColor = Color.FromArgb(241, 245, 249),
            HoverColor = Color.FromArgb(226, 232, 240),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(382, 65),
            Size = new Size(70, 34),
            CornerRadius = 6,
            Font = ThemeColors.FontCaption
        };
        btnDeselectAll.Click += (s, e) => SetAllPermissionsChecked(false);

        btnResetDefault = new CustomButton
        {
            Text = "Khôi phục chuẩn",
            NormalColor = Color.FromArgb(254, 243, 199),
            HoverColor = Color.FromArgb(253, 230, 138),
            ForeColor = Color.FromArgb(180, 83, 9),
            Location = new Point(460, 65),
            Size = new Size(130, 34),
            CornerRadius = 6,
            Font = ThemeColors.FontCaption
        };
        btnResetDefault.Click += async (s, e) => await ResetCurrentRoleToDefaultAsync();

        // DataGridView for Permissions
        dgvPermissions = new DataGridView
        {
            Location = new Point(15, 110),
            Size = new Size(645, 375),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvPermissions);
        dgvPermissions.ReadOnly = false; // Allow checkbox toggle

        ConfigurePermissionColumns();

        pnlRight.Controls.Add(lblSelectedRoleTitle);
        pnlRight.Controls.Add(lblRolePill);
        pnlRight.Controls.Add(lblSelectedRoleDesc);
        pnlRight.Controls.Add(txtSearchPerm);
        pnlRight.Controls.Add(btnSelectAll);
        pnlRight.Controls.Add(btnDeselectAll);
        pnlRight.Controls.Add(btnResetDefault);
        pnlRight.Controls.Add(dgvPermissions);

        // Bottom Action Buttons
        btnSave = new CustomButton
        {
            Text = "LƯU CẤU HÌNH PHÂN QUYỀN",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(620, 580),
            Size = new Size(210, 42),
            CornerRadius = 8
        };
        btnSave.Click += async (s, e) => await SaveRolePermissionsAsync();

        btnClose = new CustomButton
        {
            Text = "ĐÓNG",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(840, 580),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnClose.Click += (s, e) => DialogResult = DialogResult.OK;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(pnlLeft);
        card.Controls.Add(pnlRight);
        card.Controls.Add(btnSave);
        card.Controls.Add(btnClose);

        Controls.Add(card);
    }

    private void ConfigurePermissionColumns()
    {
        dgvPermissions.Columns.Clear();

        var colCheck = new DataGridViewCheckBoxColumn
        {
            DataPropertyName = nameof(RolePermissionDto.IsAssigned),
            HeaderText = "Bật",
            Width = 50,
            ReadOnly = false
        };
        dgvPermissions.Columns.Add(colCheck);

        var colModule = new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(RolePermissionDto.ModuleName),
            HeaderText = "Phân hệ chức năng",
            Width = 175,
            ReadOnly = true
        };
        dgvPermissions.Columns.Add(colModule);

        var colCode = new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(RolePermissionDto.PermissionCode),
            HeaderText = "Mã quyền",
            Width = 135,
            ReadOnly = true
        };
        dgvPermissions.Columns.Add(colCode);

        var colName = new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(RolePermissionDto.PermissionName),
            HeaderText = "Tên quyền hạn",
            Width = 200,
            ReadOnly = true
        };
        dgvPermissions.Columns.Add(colName);

        var colDesc = new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(RolePermissionDto.Description),
            HeaderText = "Mô tả chi tiết",
            Width = 220,
            ReadOnly = true
        };
        dgvPermissions.Columns.Add(colDesc);
    }

    private async Task LoadInitialDataAsync()
    {
        try
        {
            _roles = (await _rbacService.GetAllRolesAsync()).ToList();

            lstRoles.DataSource = _roles;
            lstRoles.DisplayMember = "RoleName";
            lstRoles.ValueMember = "RoleId";

            if (_roles.Count > 0)
            {
                lstRoles.SelectedIndex = 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh mục vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task OnRoleSelectedAsync()
    {
        if (lstRoles.SelectedItem is Role role)
        {
            _selectedRole = role;
            lblSelectedRoleTitle.Text = role.RoleName;
            lblSelectedRoleDesc.Text = role.Description ?? "Không có mô tả chi tiết";
            lblRolePill.Text = role.RoleCode;

            await LoadPermissionsForRoleAsync(role.RoleId);
        }
    }

    private async Task LoadPermissionsForRoleAsync(int roleId)
    {
        try
        {
            var perms = await _rbacService.GetPermissionsByRoleIdAsync(roleId);
            _currentPermissions = perms.ToList();
            FilterPermissionGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách quyền của vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FilterPermissionGrid()
    {
        string kw = txtSearchPerm.Text.Trim().ToLowerInvariant();
        if (string.IsNullOrWhiteSpace(kw))
        {
            dgvPermissions.DataSource = _currentPermissions.ToList();
        }
        else
        {
            var filtered = _currentPermissions
                .Where(p => p.PermissionCode.ToLowerInvariant().Contains(kw) 
                         || p.PermissionName.ToLowerInvariant().Contains(kw) 
                         || p.ModuleName.ToLowerInvariant().Contains(kw))
                .ToList();

            dgvPermissions.DataSource = filtered;
        }
    }

    private void SetAllPermissionsChecked(bool isChecked)
    {
        foreach (var p in _currentPermissions)
        {
            p.IsAssigned = isChecked;
        }
        dgvPermissions.Refresh();
    }

    private async Task ResetCurrentRoleToDefaultAsync()
    {
        if (_selectedRole == null) return;

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn khôi phục toàn bộ phân quyền của vai trò '{_selectedRole.RoleName}' về mặc định chuẩn của hệ thống?",
            "Xác nhận khôi phục mặc định",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            var (success, message) = await _rbacService.ResetRolePermissionsToDefaultAsync(_selectedRole.RoleId);
            if (!success)
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadPermissionsForRoleAsync(_selectedRole.RoleId);
        }
    }

    private async Task SaveRolePermissionsAsync()
    {
        if (_selectedRole == null) return;

        dgvPermissions.EndEdit();

        btnSave.Enabled = false;

        try
        {
            var assignedIds = _currentPermissions
                .Where(p => p.IsAssigned)
                .Select(p => p.PermissionId)
                .ToList();

            var (success, message) = await _rbacService.UpdateRolePermissionsAsync(_selectedRole.RoleId, assignedIds);
            if (!success)
            {
                MessageBox.Show(message, "Thông báo kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }

            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadPermissionsForRoleAsync(_selectedRole.RoleId);
            btnSave.Enabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi trong quá trình lưu phân quyền: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = true;
        }
    }
}
