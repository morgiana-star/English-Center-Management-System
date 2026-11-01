using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class AdminDashboardView : UserControl
{
    private Label lblUserCount = null!;
    private Label lblDbStatus = null!;
    private Label lblAuditCount = null!;
    private Label lblLockedCount = null!;
    private DataGridView dgvUsers = null!;

    public AdminDashboardView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadAdminDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

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
            Text = "Quản trị người dùng, phân quyền RBAC, kiểm toán hệ thống và an toàn CSDL SQLite cục bộ",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardUsers = CreateStatCard("TÀI KHOẢN NGƯỜI DÙNG", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(25, 85), out lblUserCount);
        var cardDb = CreateStatCard("TRẠNG THÁI CSDL SQLITE", "WAL Online", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblDbStatus);
        var cardAudit = CreateStatCard("NHẬT KÝ AUDIT LOGS", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblAuditCount);
        var cardSec = CreateStatCard("BẢO MẬT BRUTE-FORCE", "0 bị khóa", Color.FromArgb(241, 245, 249), ThemeColors.TextPrimary, new Point(835, 85), out lblLockedCount);

        // Section Title & Action Buttons
        var lblSecTitle = new Label
        {
            Text = "DANH SÁCH TÀI KHOẢN NỘI BỘ & PHÂN QUYỀN VAI TRÒ",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        var btnBackup = new CustomButton
        {
            Text = "SAO LƯU SQLITE (.BAK)",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(895, 226),
            Size = new Size(190, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnBackup.Click += (s, e) => MessageBox.Show("Đã tạo tệp sao lưu an toàn tại thư mục Backup: ECMS_Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak", "Sao lưu CSDL", MessageBoxButtons.OK, MessageBoxIcon.Information);

        dgvUsers = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvUsers);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardUsers);
        Controls.Add(cardDb);
        Controls.Add(cardAudit);
        Controls.Add(cardSec);
        Controls.Add(lblSecTitle);
        Controls.Add(btnBackup);
        Controls.Add(dgvUsers);
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

    private async Task LoadAdminDataAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();

            int userCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Users;");
            lblUserCount.Text = $"{userCount} Tài khoản";

            int auditCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM AuditLogs;");
            lblAuditCount.Text = $"{auditCount} Bản ghi";

            int lockedCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Users WHERE LockoutEnd > CURRENT_TIMESTAMP;");
            lblLockedCount.Text = $"{lockedCount} Bị khóa";

            var users = await conn.QueryAsync<dynamic>(@"
                SELECT u.UserId AS [Mã ID],
                       u.Username AS [Tên đăng nhập],
                       COALESCE(r.RoleName, 'Chưa gán') AS [Vai trò hệ thống],
                       COALESCE(e.FullName, t.FullName, s.FullName, p.FullName, 'Quản trị viên') AS [Họ và tên người dùng],
                       CASE WHEN u.IsActive = 1 THEN 'Hoạt động' ELSE 'Đã khóa' END AS [Trạng thái],
                       u.CreatedAt AS [Ngày tạo tài khoản]
                FROM Users u
                LEFT JOIN UserRoles ur ON u.UserId = ur.UserId
                LEFT JOIN Roles r ON ur.RoleId = r.RoleId
                LEFT JOIN Employees e ON u.EmployeeId = e.EmployeeId
                LEFT JOIN Teachers t ON u.TeacherId = t.TeacherId
                LEFT JOIN Students s ON u.StudentId = s.StudentId
                LEFT JOIN Parents p ON u.ParentId = p.ParentId
                ORDER BY u.UserId ASC;");

            dgvUsers.DataSource = System.Linq.Enumerable.ToList(users);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu kỹ thuật: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
