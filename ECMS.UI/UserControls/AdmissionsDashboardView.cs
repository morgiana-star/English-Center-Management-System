using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class AdmissionsDashboardView : UserControl
{
    private Label lblLeadCount = null!;
    private Label lblTestCount = null!;
    private Label lblStudentCount = null!;
    private Label lblOpenClassCount = null!;

    private ModernTextBox txtSearch = null!;
    private DataGridView dgvStudents = null!;

    public AdmissionsDashboardView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        var lblTitle = new Label
        {
            Text = "CỔNG TƯ VẤN TUYỂN SINH (CONSULTANT PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Tiếp nhận khách tiềm năng, ghi nhận tư vấn, xếp lịch Placement Test và tạo hồ sơ nhập học",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardLeads = CreateStatCard("KHÁCH TIỀM NĂNG (LEADS)", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(25, 85), out lblLeadCount);
        var cardTests = CreateStatCard("LỊCH PLACEMENT TEST", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(295, 85), out lblTestCount);
        var cardStudents = CreateStatCard("HỌC VIÊN CHÍNH THỨC", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(565, 85), out lblStudentCount);
        var cardClasses = CreateStatCard("LỚP ĐANG TUYỂN SINH", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(835, 85), out lblOpenClassCount);

        // Search & Action Bar (using GlassCard)
        var cardSearch = new GlassCard
        {
            Location = new Point(25, 225),
            Size = new Size(1060, 68),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(12)
        };

        txtSearch = new ModernTextBox
        {
            Placeholder = "Tìm kiếm theo mã học viên, họ tên hoặc số điện thoại...",
            Location = new Point(15, 12),
            Size = new Size(450, 42),
            CornerRadius = 6
        };

        var btnSearch = new CustomButton
        {
            Text = "TÌM KIẾM",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(475, 12),
            Size = new Size(110, 42),
            CornerRadius = 6
        };
        btnSearch.Click += async (s, e) => await LoadDataAsync();

        var btnAddStudent = new CustomButton
        {
            Text = "+ THÊM HỌC VIÊN MỚI",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(860, 12),
            Size = new Size(185, 42),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnAddStudent.Click += async (s, e) => await CreateQuickStudentAsync();

        cardSearch.Controls.Add(txtSearch);
        cardSearch.Controls.Add(btnSearch);
        cardSearch.Controls.Add(btnAddStudent);

        dgvStudents = new DataGridView
        {
            Location = new Point(25, 305),
            Size = new Size(1060, 330),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvStudents);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardLeads);
        Controls.Add(cardTests);
        Controls.Add(cardStudents);
        Controls.Add(cardClasses);
        Controls.Add(cardSearch);
        Controls.Add(dgvStudents);
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

    private async Task LoadDataAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();

            int stuCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Students;");
            lblStudentCount.Text = $"{stuCount} Học viên";

            int openClasses = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE Status IN ('Planning', 'OpenForEnrollment', 'InProgress');");
            lblOpenClassCount.Text = $"{openClasses} Lớp tuyển sinh";

            lblLeadCount.Text = "5 Khách mới";
            lblTestCount.Text = "2 Lịch test";

            string search = txtSearch.Text.Trim();
            string sql = @"
                SELECT s.StudentCode AS [Mã học viên],
                       s.FullName AS [Họ và tên],
                       s.DateOfBirth AS [Ngày sinh],
                       s.Gender AS [Giới tính],
                       s.Phone AS [Số điện thoại],
                       s.Email AS [Email liên hệ],
                       s.Address AS [Địa chỉ],
                       CASE WHEN s.Status = 'Active' THEN 'Đang theo học' ELSE 'Tạm ngưng' END AS [Trạng thái]
                FROM Students s
                WHERE (@Search = '' OR s.FullName LIKE '%' || @Search || '%' OR s.StudentCode LIKE '%' || @Search || '%' OR s.Phone LIKE '%' || @Search || '%')
                ORDER BY s.StudentId DESC;";

            var students = await conn.QueryAsync<dynamic>(sql, new { Search = search });
            dgvStudents.DataSource = System.Linq.Enumerable.ToList(students);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu tuyển sinh: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task CreateQuickStudentAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();
            int nextId = (await conn.ExecuteScalarAsync<int>("SELECT COALESCE(MAX(StudentId), 0) + 1 FROM Students;"));
            string code = $"HV-2026-{nextId:D4}";

            await conn.ExecuteAsync(@"
                INSERT INTO Students (StudentId, StudentCode, FullName, DateOfBirth, Gender, Phone, Email, Address, Status)
                VALUES (@Id, @Code, @Name, '2006-03-20', 'Nữ', '0988776655', 'hocvien.moi@gmail.com', 'Quận 3, TP.HCM', 'Active');",
                new { Id = nextId, Code = code, Name = $"Học viên Mới ({code})" });

            MessageBox.Show($"Đã tạo hồ sơ học viên thành công!\nMã học viên: {code}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tạo học viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
