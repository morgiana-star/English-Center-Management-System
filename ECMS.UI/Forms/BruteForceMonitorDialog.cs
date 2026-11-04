using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class BruteForceMonitorDialog : Form
{
    private readonly IUserService _userService;
    private DataGridView dgvLockedUsers = null!;
    private Label lblLockedCount = null!;
    private Label lblWarningCount = null!;
    private CustomButton btnUnlockSelected = null!;
    private CustomButton btnUnlockAll = null!;
    private CustomButton btnRefresh = null!;

    public BruteForceMonitorDialog(IUserService? userService = null)
    {
        _userService = userService ?? new UserService();
        InitializeComponents();
        Load += async (s, e) => await LoadDataAsync();
    }

    private void InitializeComponents()
    {
        Text = "ECMS - Giám sát bảo mật Brute-force & Mở khóa tài khoản khẩn cấp";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(880, 600);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(15, 15),
            Size = new Size(850, 570),
            CornerRadius = 16,
            EnableShadow = true
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = "TRUNG TÂM GIÁM SÁT BẢO MẬT & MỞ KHÓA BRUTE-FORCE",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Theo dõi các tài khoản nhập sai mật khẩu, tài khoản bị tạm khóa 15 phút và thực thi mở khóa khẩn cấp",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // 2 Mini Stat Cards
        var pnlLocked = new RoundedPanel
        {
            Location = new Point(20, 68),
            Size = new Size(395, 65),
            CornerRadius = 8,
            BorderColor = Color.FromArgb(254, 202, 202),
            BorderWidth = 1,
            BackColor = Color.FromArgb(254, 242, 242)
        };

        var lblLockedTitle = new Label
        {
            Text = "TÀI KHOẢN ĐANG BỊ KHÓA AN TOÀN",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.DangerText,
            Location = new Point(12, 10),
            AutoSize = true
        };

        lblLockedCount = new Label
        {
            Text = "Đang tải...",
            Font = new Font("Segoe UI", 14f, FontStyle.Bold),
            ForeColor = ThemeColors.DangerText,
            Location = new Point(12, 30),
            AutoSize = true
        };

        pnlLocked.Controls.Add(lblLockedTitle);
        pnlLocked.Controls.Add(lblLockedCount);

        var pnlWarning = new RoundedPanel
        {
            Location = new Point(435, 68),
            Size = new Size(395, 65),
            CornerRadius = 8,
            BorderColor = Color.FromArgb(254, 243, 199),
            BorderWidth = 1,
            BackColor = Color.FromArgb(255, 251, 235)
        };

        var lblWarningTitle = new Label
        {
            Text = "CẢNH BÁO NHẬP SAI (CHƯA ĐẠT 5 LẦN)",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.WarningText,
            Location = new Point(12, 10),
            AutoSize = true
        };

        lblWarningCount = new Label
        {
            Text = "Đang tải...",
            Font = new Font("Segoe UI", 14f, FontStyle.Bold),
            ForeColor = ThemeColors.WarningText,
            Location = new Point(12, 30),
            AutoSize = true
        };

        pnlWarning.Controls.Add(lblWarningTitle);
        pnlWarning.Controls.Add(lblWarningCount);

        // DataGridView for Locked / At Risk Users
        dgvLockedUsers = new DataGridView
        {
            Location = new Point(20, 145),
            Size = new Size(810, 350),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvLockedUsers);

        ConfigureGridColumns();
        dgvLockedUsers.CellFormatting += DgvLockedUsers_CellFormatting;

        // Action Buttons
        btnUnlockSelected = new CustomButton
        {
            Text = "MỞ KHÓA ĐÃ CHỌN",
            NormalColor = Color.FromArgb(13, 148, 136), // Teal 600
            HoverColor = Color.FromArgb(15, 118, 110), // Teal 700
            Location = new Point(20, 508),
            Size = new Size(170, 42),
            CornerRadius = 8
        };
        btnUnlockSelected.Click += async (s, e) => await UnlockSelectedAsync();

        btnUnlockAll = new CustomButton
        {
            Text = "MỞ KHÓA TẤT CẢ",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(200, 508),
            Size = new Size(160, 42),
            CornerRadius = 8
        };
        btnUnlockAll.Click += async (s, e) => await UnlockAllAsync();

        btnRefresh = new CustomButton
        {
            Text = "LÀM MỚI",
            NormalColor = Color.FromArgb(100, 116, 139),
            HoverColor = Color.FromArgb(71, 85, 105),
            Location = new Point(370, 508),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnRefresh.Click += async (s, e) => await LoadDataAsync();

        var btnClose = new CustomButton
        {
            Text = "ĐÓNG",
            NormalColor = Color.FromArgb(148, 163, 184),
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(720, 508),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnClose.Click += (s, e) => DialogResult = DialogResult.OK;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(pnlLocked);
        card.Controls.Add(pnlWarning);
        card.Controls.Add(dgvLockedUsers);
        card.Controls.Add(btnUnlockSelected);
        card.Controls.Add(btnUnlockAll);
        card.Controls.Add(btnRefresh);
        card.Controls.Add(btnClose);

        Controls.Add(card);
    }

    private void ConfigureGridColumns()
    {
        dgvLockedUsers.Columns.Clear();

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.UserId),
            HeaderText = "ID",
            Width = 50,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.Username),
            HeaderText = "Tên đăng nhập",
            Width = 130
        });

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.FullName),
            HeaderText = "Họ và tên",
            Width = 170
        });

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.RoleName),
            HeaderText = "Vai trò",
            Width = 130
        });

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.FailedLoginAttempts),
            HeaderText = "Lần nhập sai",
            Width = 100,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLockedUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = nameof(UserListItemDto.StatusText),
            HeaderText = "Trạng thái bảo mật",
            Width = 150
        });
    }

    private void DgvLockedUsers_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvLockedUsers.Rows.Count) return;

        var row = dgvLockedUsers.Rows[e.RowIndex];
        if (row.DataBoundItem is UserListItemDto user)
        {
            if (e.ColumnIndex == 4) // Lần nhập sai
            {
                if (user.FailedLoginAttempts >= 5)
                {
                    e.CellStyle!.ForeColor = ThemeColors.DangerText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
                else if (user.FailedLoginAttempts > 0)
                {
                    e.CellStyle!.ForeColor = ThemeColors.WarningText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
            }
            else if (e.ColumnIndex == 5) // Trạng thái
            {
                if (user.IsLocked)
                {
                    e.CellStyle!.ForeColor = ThemeColors.DangerText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
                else
                {
                    e.CellStyle!.ForeColor = ThemeColors.WarningText;
                    e.CellStyle.Font = ThemeColors.FontBodyBold;
                }
            }
        }
    }

    private async Task LoadDataAsync()
    {
        try
        {
            // Fetch users with onlyLocked = true or failed attempts > 0
            var allUsers = await _userService.GetUsersAsync(null, null, null, onlyLocked: true);
            var list = allUsers.ToList();

            int lockedCount = list.Count(u => u.IsLocked);
            int warningCount = list.Count(u => !u.IsLocked && u.FailedLoginAttempts > 0);

            lblLockedCount.Text = $"{lockedCount} Tài khoản bị khóa";
            lblWarningCount.Text = $"{warningCount} Tài khoản có lần thử sai";

            dgvLockedUsers.DataSource = list;
            btnUnlockSelected.Enabled = list.Count > 0;
            btnUnlockAll.Enabled = list.Count > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách brute-force: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task UnlockSelectedAsync()
    {
        if (dgvLockedUsers.CurrentRow?.DataBoundItem is UserListItemDto selectedUser)
        {
            var confirm = MessageBox.Show(
                $"Xác nhận mở khóa khẩn cấp cho tài khoản '{selectedUser.Username}' ({selectedUser.FullName})?\n\nSố lần nhập sai hiện tại: {selectedUser.FailedLoginAttempts}\nThao tác này sẽ gỡ bỏ thời gian khóa và kích hoạt lại tài khoản.",
                "Xác nhận mở khóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var (success, message) = await _userService.UnlockUserAsync(selectedUser.UserId);
                if (!success)
                {
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async Task UnlockAllAsync()
    {
        if (dgvLockedUsers.DataSource is not System.Collections.Generic.List<UserListItemDto> users || users.Count == 0)
        {
            return;
        }

        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn mở khóa khẩn cấp cho TẤT CẢ {users.Count} tài khoản trong danh sách?",
            "Xác nhận mở khóa hàng loạt",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            int unlockedCount = 0;
            foreach (var u in users)
            {
                var (success, _) = await _userService.UnlockUserAsync(u.UserId);
                if (success) unlockedCount++;
            }

            MessageBox.Show($"Đã mở khóa khẩn cấp thành công {unlockedCount}/{users.Count} tài khoản.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
    }
}
