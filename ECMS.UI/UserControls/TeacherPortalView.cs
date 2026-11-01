using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class TeacherPortalView : UserControl
{
    private Label lblGreeting = null!;
    private Label lblClassCount = null!;
    private Label lblStudentCount = null!;
    private Label lblWeeklySessions = null!;
    private Label lblHourlyRate = null!;

    private DataGridView dgvTeachingSchedule = null!;
    private DataGridView dgvClassStudents = null!;

    public TeacherPortalView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadTeacherDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        lblGreeting = new Label
        {
            Text = "CỔNG GIẢNG DẠY - GIẢNG VIÊN (TEACHER PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = Color.FromArgb(67, 56, 202), // Indigo 700
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSub = new Label
        {
            Text = "Theo dõi lịch giảng dạy, mở sổ điểm danh buổi học và cập nhật đánh giá tiến độ học sinh",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardClass = CreateStatCard("LỚP ĐƯỢC PHÂN CÔNG", "Đang tải...", Color.FromArgb(238, 242, 255), Color.FromArgb(67, 56, 202), new Point(25, 85), out lblClassCount);
        var cardStudents = CreateStatCard("TỔNG HỌC VIÊN PHỤ TRÁCH", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblStudentCount);
        var cardSessions = CreateStatCard("SỐ CA DẠY TRONG TUẦN", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblWeeklySessions);
        var cardRate = CreateStatCard("MỨC THÙ LAO / GIỜ", "Đang tải...", Color.FromArgb(245, 243, 255), Color.FromArgb(124, 58, 237), new Point(835, 85), out lblHourlyRate);

        // Section 1: Lịch dạy
        var lblSec1 = new Label
        {
            Text = "LỊCH GIẢNG DẠY & PHÒNG HỌC CỦA TÔI",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(25, 235),
            AutoSize = true
        };

        var btnTakeAttendance = new CustomButton
        {
            Text = "MỞ SỔ ĐIỂM DANH",
            NormalColor = Color.FromArgb(67, 56, 202),
            HoverColor = Color.FromArgb(79, 70, 229),
            Location = new Point(915, 226),
            Size = new Size(170, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnTakeAttendance.Click += (s, e) => MessageBox.Show("Sổ điểm danh buổi học hôm nay: Tích chọn Có mặt/Vắng/Muộn và lưu kết quả. Dữ liệu sẽ tự động đồng bộ sang Cổng học viên và Cổng phụ huynh.", "Điểm danh buổi học", MessageBoxButtons.OK, MessageBoxIcon.Information);

        dgvTeachingSchedule = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 190),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvTeachingSchedule);

        // Section 2: Danh sách học viên & Đánh giá
        var lblSec2 = new Label
        {
            Text = "DANH SÁCH HỌC VIÊN & TIẾN ĐỘ HỌC TẬP (LỚP ĐANG DẠY)",
            Font = ThemeColors.FontSubHeader,
            ForeColor = Color.FromArgb(67, 56, 202),
            Location = new Point(25, 480),
            AutoSize = true
        };

        var btnGrade = new CustomButton
        {
            Text = "NHẬP ĐIỂM THI THANG 10",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(885, 471),
            Size = new Size(200, 36),
            CornerRadius = 6,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnGrade.Click += (s, e) => MessageBox.Show("Nhập điểm thi: Nhập điểm Quiz, Giữa kỳ, Cuối kỳ kèm nhận xét chi tiết 4 kỹ năng (Nghe, Nói, Đọc, Viết) cho từng học viên.", "Nhập điểm thi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        dgvClassStudents = new DataGridView
        {
            Location = new Point(25, 515),
            Size = new Size(1060, 210),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvClassStudents);

        Controls.Add(lblGreeting);
        Controls.Add(lblSub);
        Controls.Add(cardClass);
        Controls.Add(cardStudents);
        Controls.Add(cardSessions);
        Controls.Add(cardRate);
        Controls.Add(lblSec1);
        Controls.Add(btnTakeAttendance);
        Controls.Add(dgvTeachingSchedule);
        Controls.Add(lblSec2);
        Controls.Add(btnGrade);
        Controls.Add(dgvClassStudents);
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

    private async Task LoadTeacherDataAsync()
    {
        try
        {
            var user = SessionManager.CurrentUser;
            int teacherId = user?.TeacherId ?? 1;

            using var conn = DatabaseConfig.GetConnection();

            var teacher = await conn.QueryFirstOrDefaultAsync<dynamic>(
                "SELECT TeacherCode, FullName, Specialization, HourlyRate FROM Teachers WHERE TeacherId = @TeacherId;",
                new { TeacherId = teacherId });

            if (teacher != null)
            {
                lblGreeting.Text = $"CỔNG GIẢNG DẠY - GIẢNG VIÊN: {teacher.FullName} ({teacher.TeacherCode} - {teacher.Specialization})";
                decimal rate = (decimal)teacher.HourlyRate;
                lblHourlyRate.Text = $"{rate:N0} đ/giờ";
            }

            int classCount = await conn.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Classes WHERE MainTeacherId = @TeacherId;", new { TeacherId = teacherId });
            lblClassCount.Text = $"{classCount} Lớp phụ trách";

            int stuCount = await conn.ExecuteScalarAsync<int>(@"
                SELECT COUNT(DISTINCT e.StudentId) 
                FROM Enrollments e 
                JOIN Classes c ON e.ClassId = c.ClassId 
                WHERE c.MainTeacherId = @TeacherId;", new { TeacherId = teacherId });
            lblStudentCount.Text = $"{stuCount} Học viên";

            lblWeeklySessions.Text = "3 ca / tuần";

            var schedules = await conn.QueryAsync<dynamic>(@"
                SELECT cs.SessionNumber AS [Buổi], c.ClassCode AS [Mã lớp], cs.Date AS [Ngày dạy],
                       cs.StartTime || ' - ' || cs.EndTime AS [Khung giờ], cr.RoomName AS [Phòng học],
                       cs.Topic AS [Chủ đề bài giảng],
                       CASE WHEN cs.IsAttendanceLocked = 1 THEN 'Đã khóa điểm danh' ELSE 'Chưa điểm danh' END AS [Trạng thái sổ điểm danh]
                FROM ClassSchedules cs
                JOIN Classes c ON cs.ClassId = c.ClassId
                LEFT JOIN ClassRooms cr ON cs.RoomId = cr.RoomId
                WHERE cs.TeacherId = @TeacherId
                ORDER BY cs.Date ASC, cs.StartTime ASC;", new { TeacherId = teacherId });

            dgvTeachingSchedule.DataSource = System.Linq.Enumerable.ToList(schedules);

            var students = await conn.QueryAsync<dynamic>(@"
                SELECT s.StudentCode AS [Mã học viên], s.FullName AS [Họ và tên], s.Gender AS [Giới tính],
                       s.Phone AS [SĐT], c.ClassCode AS [Lớp học],
                       COALESCE(e.AttendanceRate, 100) || '%' AS [Tỷ lệ chuyên cần],
                       COALESCE(e.FinalGPA, 0.0) AS [Điểm GPA],
                       COALESCE(es.ScoreValue, 0.0) AS [Điểm giữa kỳ],
                       COALESCE(es.TeacherComments, 'Chưa có nhận xét') AS [Nhận xét tiến độ]
                FROM Enrollments e
                JOIN Classes c ON e.ClassId = c.ClassId
                JOIN Students s ON e.StudentId = s.StudentId
                LEFT JOIN Exams ex ON ex.ClassId = c.ClassId AND ex.Type = 'Midterm'
                LEFT JOIN ExamScores es ON es.ExamId = ex.ExamId AND es.StudentId = s.StudentId
                WHERE c.MainTeacherId = @TeacherId;", new { TeacherId = teacherId });

            dgvClassStudents.DataSource = System.Linq.Enumerable.ToList(students);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu giáo viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
