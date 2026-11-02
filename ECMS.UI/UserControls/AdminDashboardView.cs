using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Core.Entities;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public class AdminDashboardView : UserControl
{
    private readonly IUserService _userService;

    private Label lblUserCount = null!;
    private Label lblDbStatus = null!;
    private Label lblAuditCount = null!;
    private Label lblLockedCount = null!;

    private ModernTextBox txtSearch = null!;
    private ComboBox cboRoleFilter = null!;
    private ComboBox cboStatusFilter = null!;
    private DataGridView dgvUsers = null!;

    private CustomButton btnAddUser = null!;
    private CustomButton btnEditUser = null!;
    private CustomButton btnToggleActive = null!;

    public AdminDashboardView(IUserService? userService = null)
    {
        _userService = userService ?? new UserService();
        InitializeComponents();
        Load += async (s, e) =>
        {
            await LoadFilterRolesAsync();
            await LoadAdminDataAsync();
        };
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        // 1. Page Header
        var lblTitle = new Label
        {
            Text = "BÀN LÀM VIỆC KỸ THUẬT & HẠ TẦNG (ADMINISTRATOR PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Quản trị người dùng nội bộ, phân quyền RBAC, kiểm toán hệ thống và bảo mật CSDL SQLite cục bộ",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 2. 4 Stat KPI Cards
        var cardUsers = CreateStatCard("TÀI KHOẢN NGƯỜI DÙNG", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(25, 85), out lblUserCount);
        var cardDb = CreateStatCard("TRẠNG THÁI CSDL SQLITE", "WAL Online", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblDbStatus);
        var cardAudit = CreateStatCard("NHẬT KÝ AUDIT LOGS", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblAuditCount);
        var cardSec = CreateStatCard("BẢO MẬT BRUTE-FORCE", "0 bị khóa", Color.FromArgb(241, 245, 249), ThemeColors.TextPrimary, new Point(835, 85), out lblLockedCount);

        // 3. Search & Action Toolbar (GlassCard)
        var cardToolbar = new GlassCard
        {
            Location = new Point(25, 225),
            Size = new Size(1060, 68),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(10)
        };

        txtSearch = new ModernTextBox
        {
            Placeholder = "Tìm kiếm theo username, họ tên, SĐT, email...",
            Location = new Point(12, 14),
            Size = new Size(290, 38),
            CornerRadius = 6
        };
        txtSearch.KeyDown += async (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await FilterUsersAsync();
            }
        };

        cboRoleFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(310, 18),
            Size = new Size(160, 32)
        };
        cboRoleFilter.SelectedIndexChanged += async (s, e) => await FilterUsersAsync();

        cboStatusFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(480, 18),
            Size = new Size(140, 32)
        };
        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Đã vô hiệu hóa" });
        cboStatusFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndexChanged += async (s, e) => await FilterUsersAsync();

        var btnSearch = new CustomButton
        {
            Text = "TÌM KIẾM",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(630, 14),
            Size = new Size(95, 38),
            CornerRadius = 6
        };
        btnSearch.Click += async (s, e) => await FilterUsersAsync();

        btnAddUser = new CustomButton
        {
            Text = "+ THÊM MỚI",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(735, 14),
            Size = new Size(110, 38),
            CornerRadius = 6
        };
        btnAddUser.Click += async (s, e) => await OpenCreateUserDialogAsync();

        btnEditUser = new CustomButton
        {
            Text = "CHỈNH SỬA",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(855, 14),
            Size = new Size(100, 38),
            CornerRadius = 6
        };
        btnEditUser.Click += async (s, e) => await OpenEditUserDialogAsync();

        btnToggleActive = new CustomButton
        {
            Text = "KHÓA / MỞ",
            NormalColor = Color.FromArgb(225, 29, 72), // Rose 600
            HoverColor = Color.FromArgb(190, 18, 60),
            Location = new Point(965, 14),
            Size = new Size(100, 38),
            CornerRadius = 6
        };
        btnToggleActive.Click += async (s, e) => await ToggleActiveSelectedUserAsync();

        cardToolbar.Controls.Add(txtSearch);
        cardToolbar.Controls.Add(cboRoleFilter);
        cardToolbar.Controls.Add(cboStatusFilter);
        cardToolbar.Controls.Add(btnSearch);
        cardToolbar.Controls.Add(btnAddUser);
        cardToolbar.Controls.Add(btnEditUser);
        cardToolbar.Controls.Add(btnToggleActive);

        // 4. DataGridView Setup
        dgvUsers = new DataGridView
        {
            Location = new Point(25, 305),
            Size = new Size(1060, 390),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvUsers);

        ConfigureGridColumns();

        dgvUsers.DoubleClick += async (s, e) => await OpenEditUserDialogAsync();
        dgvUsers.CellFormatting += DgvUsers_CellFormatting;

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardUsers);
        Controls.Add(cardDb);
        Controls.Add(cardAudit);
        Controls.Add(cardSec);
        Controls.Add(cardToolbar);
        Controls.Add(dgvUsers);
    }

    private void ConfigureGridColumns()
    {
        dgvUsers.Columns.Clear();

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.UserId),
            HeaderText = "ID",
            Width = 55,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.Username),
            HeaderText = "Tên đăng nhập",
            Width = 140
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.FullName),
            HeaderText = "Họ và tên nhân sự",
            Width = 190
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.RoleName),
            HeaderText = "Vai trò hệ thống",
            Width = 150
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.Email),
            HeaderText = "Email liên hệ",
            Width = 180
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.Phone),
            HeaderText = "Số điện thoại",
            Width = 110
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.StatusText),
            HeaderText = "Trạng thái",
            Width = 130
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.FailedLoginAttempts),
            HeaderText = "Lần sai",
            Width = 75,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.CreatedAt),
            HeaderText = "Ngày tạo",
            Width = 130,
            DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
        });
    }

    private void DgvUsers_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvUsers.Rows.Count) return;

        var row = dgvUsers.Rows[e.RowIndex];
        if (row.DataBoundItem is UserListItemDto user)
        {
            // Format status column (Index 6)
            if (e.ColumnIndex == 6)
            {
                if (!user.IsActive)
                {
                    e.CellStyle!.ForeColor = ThemeColors.DangerText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
                else if (user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.Now)
                {
                    e.CellStyle!.ForeColor = ThemeColors.WarningText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
                else
                {
                    e.CellStyle!.ForeColor = ThemeColors.SuccessText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
            }
        }
    }

    private GlassCard CreateStatCard(string title, string initialValue, Color bg, Color textColor, Point location, out Label valueLabel)
    {
        var card = new GlassCard
        {
            Location = location,
            Size = new Size(250, 125),
            GlassColor = bg,
            BorderGlowColor = ThemeColors.GlassBorder,
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblT = new Label
        {
            Text = title,
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(16, 15),
            AutoSize = true
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = textColor,
            Location = new Point(16, 45),
            Size = new Size(220, 45),
            TextAlign = ContentAlignment.MiddleLeft
        };

        card.Controls.Add(lblT);
        card.Controls.Add(valueLabel);
        return card;
    }

    private async Task LoadFilterRolesAsync()
    {
        try
        {
            var roles = (await _userService.GetRolesAsync()).ToList();
            var filterList = new System.Collections.Generic.List<Role>
            {
                new Role { RoleId = 0, RoleName = "Tất cả vai trò", RoleCode = "" }
            };
            filterList.AddRange(roles);

            cboRoleFilter.DataSource = filterList;
            cboRoleFilter.DisplayMember = "RoleName";
            cboRoleFilter.ValueMember = "RoleId";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh mục vai trò: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task LoadAdminDataAsync()
    {
        try
        {
            // 1. Load Telemetry
            var telemetry = await _userService.GetTelemetryAsync();
            lblUserCount.Text = $"{telemetry.TotalUsers} Tài khoản";
            lblDbStatus.Text = telemetry.DatabaseStatus;
            lblAuditCount.Text = $"{telemetry.AuditLogsCount} Bản ghi";
            lblLockedCount.Text = $"{telemetry.LockedUsers} Bị khóa";

            // 2. Load Users
            await FilterUsersAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu kỹ thuật: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task FilterUsersAsync()
    {
        try
        {
            string keyword = txtSearch.Text.Trim();
            int selectedRoleId = (int)(cboRoleFilter.SelectedValue ?? 0);
            int? roleId = selectedRoleId > 0 ? selectedRoleId : null;

            bool? isActive = cboStatusFilter.SelectedIndex switch
            {
                1 => true,
                2 => false,
                _ => null
            };

            var users = await _userService.GetUsersAsync(keyword, roleId, isActive);
            dgvUsers.DataSource = users.ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi lọc danh sách người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task OpenCreateUserDialogAsync()
    {
        using var dialog = new UserEditDialog(null, _userService);
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            await LoadAdminDataAsync();
        }
    }

    private async Task OpenEditUserDialogAsync()
    {
        if (dgvUsers.CurrentRow?.DataBoundItem is UserListItemDto selectedUser)
        {
            using var dialog = new UserEditDialog(selectedUser.UserId, _userService);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await LoadAdminDataAsync();
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một người dùng trên bảng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async Task ToggleActiveSelectedUserAsync()
    {
        if (dgvUsers.CurrentRow?.DataBoundItem is UserListItemDto selectedUser)
        {
            string actionText = selectedUser.IsActive ? "vô hiệu hóa (khóa)" : "kích hoạt lại";
            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn {actionText} tài khoản '{selectedUser.Username}' ({selectedUser.FullName})?",
                "Xác nhận thay đổi trạng thái",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var (success, message) = await _userService.ToggleUserActiveAsync(selectedUser.UserId);
                if (!success)
                {
                    MessageBox.Show(message, "Cảnh báo bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAdminDataAsync();
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một người dùng trên bảng để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
