using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class AcademicDashboardView : UserControl
{
    private readonly IAttendanceService _attendanceService = new AttendanceService();

    private Label lblClassCount = null!;
    private Label lblRoomCount = null!;
    private Label lblCourseCount = null!;
    private Label lblAlertCount = null!;
    private DataGridView dgvClasses = null!;

    public AcademicDashboardView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadAcademicDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        var lblTitle = new Label
        {
            Text = "CỔNG VẬN HÀNH ĐÀO TẠO & HỌC THUẬT (ACADEMIC PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Quản lý khóa học, phòng học, mở lớp, xếp thời khóa biểu chống trùng và xét tốt nghiệp",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardClasses = CreateStatCard("LỚP ĐANG HOẠT ĐỘNG", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(25, 85), out lblClassCount);
        var cardRooms = CreateStatCard("PHÒNG HỌC KHẢ DỤNG", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblRoomCount);
        var cardCourses = CreateStatCard("CHƯƠNG TRÌNH KHÓA HỌC", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(565, 85), out lblCourseCount);
        var cardAlerts = CreateStatCard("CẢNH BÁO CHUYÊN CẦN", "Đang tải...", ThemeColors.DangerBg, ThemeColors.DangerText, new Point(835, 85), out lblAlertCount);

        // Section Title & Actions
        var lblSecTitle = new Label
        {
            Text = "DANH SÁCH LỚP HỌC ĐANG VẬN HÀNH & TÌNH TRẠNG SĨ SỐ",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        var btnSchedule = new CustomButton
        {
            Text = "XẾP LỊCH CHỐNG TRÙNG",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(715, 226),
            Size = new Size(185, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnSchedule.Click += (s, e) => MessageBox.Show("Thuật toán xếp lịch chống trùng kiểm tra xung đột thời gian giáo viên và phòng học:\nStartTime < NewEnd AND EndTime > NewStart", "Thời khóa biểu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        var btnNewClass = new CustomButton
        {
            Text = "+ MỞ LỚP HỌC MỚI",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(915, 226),
            Size = new Size(170, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnNewClass.Click += (s, e) => MessageBox.Show("Khởi tạo lớp mới: Chọn khóa học, phân công giáo viên đứng lớp, chọn phòng học mặc định và chỉ tiêu tuyển sinh tối đa.", "Mở lớp học mới", MessageBoxButtons.OK, MessageBoxIcon.Information);

        dgvClasses = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvClasses);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardClasses);
        Controls.Add(cardRooms);
        Controls.Add(cardCourses);
        Controls.Add(cardAlerts);
        Controls.Add(lblSecTitle);
        Controls.Add(btnSchedule);
        Controls.Add(btnNewClass);
        Controls.Add(dgvClasses);
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

    private async Task LoadAcademicDataAsync()
    {
        try
        {
            using var conn = DatabaseConfig.GetConnection();

            int classCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE Status = 'InProgress';");
            lblClassCount.Text = $"{classCount} Lớp đang học";

            int roomCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM ClassRooms WHERE IsActive = 1;");
            lblRoomCount.Text = $"{roomCount} Phòng sẵn sàng";

            int courseCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Courses WHERE IsActive = 1;");
            lblCourseCount.Text = $"{courseCount} Khóa học";

            var alerts = await _attendanceService.GetAbsenceAlertListAsync();
            lblAlertCount.Text = $"{System.Linq.Enumerable.Count(alerts)} Cảnh báo vắng";

            var classes = await conn.QueryAsync<dynamic>(@"
                SELECT c.ClassCode AS [Mã lớp],
                       c.ClassName AS [Tên lớp học],
                       co.CourseName AS [Khóa đào tạo],
                       COALESCE(t.FullName, 'Chưa phân công') AS [Giảng viên chính],
                       COALESCE(r.RoomName, 'Chưa xếp') AS [Phòng học],
                       c.StartDate AS [Ngày khai giảng],
                       c.EndDate AS [Dự kiến kết thúc],
                       COUNT(e.EnrollmentId) || ' / ' || c.MaxStudents AS [Sĩ số hiện tại / Tối đa],
                       CASE 
                           WHEN c.Status = 'InProgress' THEN 'Đang diễn ra'
                           WHEN c.Status = 'Planning' THEN 'Đang lập kế hoạch'
                           ELSE c.Status
                       END AS [Tình trạng lớp]
                FROM Classes c
                JOIN Courses co ON c.CourseId = co.CourseId
                LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
                LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
                LEFT JOIN Enrollments e ON e.ClassId = c.ClassId
                GROUP BY c.ClassId
                ORDER BY c.ClassId DESC;");

            dgvClasses.DataSource = System.Linq.Enumerable.ToList(classes);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu giáo vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
