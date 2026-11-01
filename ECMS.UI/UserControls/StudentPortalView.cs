using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class StudentPortalView : UserControl
{
    private Label lblGreeting = null!;
    private Label lblClass = null!;
    private Label lblAttendanceRate = null!;
    private Label lblMidtermScore = null!;
    private Label lblBalanceDue = null!;

    private DataGridView dgvSchedule = null!;
    private DataGridView dgvScores = null!;

    public StudentPortalView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadStudentDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        lblGreeting = new Label
        {
            Text = "CỔNG TRA CỨU HỌC TẬP - HỌC VIÊN (STUDENT PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = Color.FromArgb(194, 65, 12), // Orange 700
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSub = new Label
        {
            Text = "Tra cứu thời khóa biểu, lịch sử điểm danh, bảng điểm kiểm tra và tình trạng hoàn tất học phí",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardClass = CreateStatCard("LỚP ĐANG HỌC", "Đang tải...", Color.FromArgb(255, 247, 237), Color.FromArgb(194, 65, 12), new Point(25, 85), out lblClass);
        var cardAtt = CreateStatCard("TỶ LỆ CHUYÊN CẦN", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblAttendanceRate);
        var cardScore = CreateStatCard("ĐIỂM GIỮA KỲ (GPA)", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblMidtermScore);
        var cardTuition = CreateStatCard("HỌC PHÍ CÒN NỢ", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(835, 85), out lblBalanceDue);

        // Section 1: Thời khóa biểu
        var lblSec1 = new Label
        {
            Text = "THỜI KHÓA BIỂU & NỘI DUNG BÀI HỌC TỪNG BUỔI",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        dgvSchedule = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 200),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvSchedule);

        // Section 2: Bảng điểm & Nhận xét
        var lblSec2 = new Label
        {
            Text = "BẢNG ĐIỂM KIỂM TRA & NHẬN XÉT CỦA GIÁO VIÊN",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 490),
            AutoSize = true
        };

        dgvScores = new DataGridView
        {
            Location = new Point(25, 525),
            Size = new Size(1060, 190),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvScores);

        Controls.Add(lblGreeting);
        Controls.Add(lblSub);
        Controls.Add(cardClass);
        Controls.Add(cardAtt);
        Controls.Add(cardScore);
        Controls.Add(cardTuition);
        Controls.Add(lblSec1);
        Controls.Add(dgvSchedule);
        Controls.Add(lblSec2);
        Controls.Add(dgvScores);
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

    private async Task LoadStudentDataAsync()
    {
        try
        {
            var user = SessionManager.CurrentUser;
            int studentId = user?.StudentId ?? 1;

            using var conn = DatabaseConfig.GetConnection();

            var student = await conn.QueryFirstOrDefaultAsync<dynamic>(
                "SELECT StudentCode, FullName FROM Students WHERE StudentId = @StudentId;",
                new { StudentId = studentId });

            if (student != null)
            {
                lblGreeting.Text = $"CỔNG TRA CỨU HỌC TẬP - HỌC VIÊN: {student.FullName} ({student.StudentCode})";
            }

            var enrollment = await conn.QueryFirstOrDefaultAsync<dynamic>(@"
                SELECT e.EnrollmentId, e.AttendanceRate, e.FinalGPA, c.ClassName, c.ClassCode, r.RoomName, t.FullName AS TeacherName,
                       i.FinalAmount, i.BalanceDue, i.Status AS InvoiceStatus
                FROM Enrollments e
                JOIN Classes c ON e.ClassId = c.ClassId
                LEFT JOIN ClassRooms r ON c.DefaultRoomId = r.RoomId
                LEFT JOIN Teachers t ON c.MainTeacherId = t.TeacherId
                LEFT JOIN Invoices i ON i.EnrollmentId = e.EnrollmentId
                WHERE e.StudentId = @StudentId
                ORDER BY e.EnrollmentId DESC LIMIT 1;", new { StudentId = studentId });

            if (enrollment != null)
            {
                lblClass.Text = $"{enrollment.ClassCode}";
                lblAttendanceRate.Text = $"{enrollment.AttendanceRate:F0}%";
                lblMidtermScore.Text = $"{enrollment.FinalGPA:F1} / 10.0";
                decimal due = enrollment.BalanceDue != null ? (decimal)enrollment.BalanceDue : 0m;
                lblBalanceDue.Text = due == 0m ? "Đã xong 100%" : $"{due:N0} đ";
                if (due == 0m) lblBalanceDue.ForeColor = ThemeColors.SuccessText;
            }
            else
            {
                lblClass.Text = "Chưa xếp lớp";
                lblAttendanceRate.Text = "100%";
                lblMidtermScore.Text = "N/A";
                lblBalanceDue.Text = "0 đ";
            }

            var schedules = await conn.QueryAsync<dynamic>(@"
                SELECT cs.SessionNumber AS [Buổi], cs.Date AS [Ngày học], cs.StartTime || ' - ' || cs.EndTime AS [Khung giờ],
                       cr.RoomName AS [Phòng học], t.FullName AS [Giảng viên], cs.Topic AS [Chủ đề bài học],
                       COALESCE(ar.Status, 'Chưa diễn ra') AS [Điểm danh], COALESCE(ar.Note, '') AS [Nhận xét chuyên cần]
                FROM ClassSchedules cs
                JOIN Classes c ON cs.ClassId = c.ClassId
                JOIN Enrollments e ON e.ClassId = c.ClassId AND e.StudentId = @StudentId
                LEFT JOIN ClassRooms cr ON cs.RoomId = cr.RoomId
                LEFT JOIN Teachers t ON cs.TeacherId = t.TeacherId
                LEFT JOIN AttendanceRecords ar ON ar.ScheduleId = cs.ScheduleId AND ar.StudentId = @StudentId
                ORDER BY cs.SessionNumber ASC;", new { StudentId = studentId });

            dgvSchedule.DataSource = System.Linq.Enumerable.ToList(schedules);

            var scores = await conn.QueryAsync<dynamic>(@"
                SELECT ex.ExamName AS [Kỳ kiểm tra], ex.Type AS [Loại bài thi], ex.ExamDate AS [Ngày thi],
                       ex.WeightPercentage || '%' AS [Tỷ trọng], es.ScoreValue AS [Điểm số (thang 10)],
                       es.TeacherComments AS [Nhận xét & Đánh giá chi tiết của thầy cô]
                FROM ExamScores es
                JOIN Exams ex ON es.ExamId = ex.ExamId
                WHERE es.StudentId = @StudentId
                ORDER BY ex.ExamDate ASC;", new { StudentId = studentId });

            dgvScores.DataSource = System.Linq.Enumerable.ToList(scores);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu học viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
