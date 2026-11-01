using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Session;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class ParentPortalView : UserControl
{
    private Label lblGreeting = null!;
    private Label lblStudentName = null!;
    private Label lblAttendanceStatus = null!;
    private Label lblAcademicGrade = null!;
    private Label lblTuitionStatus = null!;

    private DataGridView dgvChildSchedule = null!;
    private DataGridView dgvChildGrades = null!;

    public ParentPortalView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadParentDataAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        lblGreeting = new Label
        {
            Text = "CỔNG THÔNG TIN PHỤ HUYNH THEO DÕI CON EM (PARENT PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = Color.FromArgb(190, 24, 93), // Rose 700
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSub = new Label
        {
            Text = "Giám sát lịch học, giờ đưa đón, nhật ký điểm danh và kết quả học tập của con em tại trung tâm",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 4 KPI Cards
        var cardChild = CreateStatCard("CON EM THEO DÕI", "Đang tải...", Color.FromArgb(253, 242, 248), Color.FromArgb(190, 24, 93), new Point(25, 85), out lblStudentName);
        var cardAtt = CreateStatCard("TÌNH TRẠNG ĐIỂM DANH", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(295, 85), out lblAttendanceStatus);
        var cardGrade = CreateStatCard("KẾT QUẢ ĐÀO TẠO", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblAcademicGrade);
        var cardTuition = CreateStatCard("TRẠNG THÁI HỌC PHÍ", "Đang tải...", Color.FromArgb(238, 242, 255), ThemeColors.Primary, new Point(835, 85), out lblTuitionStatus);

        // Section 1: Lịch học & Giờ đưa đón
        var lblSec1 = new Label
        {
            Text = "LỊCH HỌC & GIỜ ĐƯA ĐÓN CỦA CON EM TẠI TRUNG TÂM",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 235),
            AutoSize = true
        };

        dgvChildSchedule = new DataGridView
        {
            Location = new Point(25, 270),
            Size = new Size(1060, 190),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvChildSchedule);

        // Section 2: Điểm số & Nhận xét của giáo viên
        var lblSec2 = new Label
        {
            Text = "KẾT QUẢ HỌC TẬP & NHẬN XÉT CỦA GIÁO VIÊN GỬI PHỤ HUYNH",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 480),
            AutoSize = true
        };

        dgvChildGrades = new DataGridView
        {
            Location = new Point(25, 515),
            Size = new Size(1060, 160),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvChildGrades);

        // Hotlines GlassCard
        var cardHotline = new GlassCard
        {
            Location = new Point(25, 690),
            Size = new Size(1060, 68),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            BorderGlowColor = Color.FromArgb(244, 114, 182),
            GlassColor = Color.FromArgb(253, 242, 248)
        };

        var lblHotlineText = new Label
        {
            Text = "KÊNH LIÊN HỆ HỖ TRỢ KHẨN CẤP:  Hotline trung tâm: 028 1234 5678  |  Phòng Đào tạo (Giáo vụ): 0904 567 890  |  Giảng viên phụ trách: 0905 678 901 (Thầy John Smith)",
            Font = ThemeColors.FontBodyBold,
            ForeColor = Color.FromArgb(157, 23, 77),
            Location = new Point(18, 22),
            AutoSize = true
        };
        cardHotline.Controls.Add(lblHotlineText);

        Controls.Add(lblGreeting);
        Controls.Add(lblSub);
        Controls.Add(cardChild);
        Controls.Add(cardAtt);
        Controls.Add(cardGrade);
        Controls.Add(cardTuition);
        Controls.Add(lblSec1);
        Controls.Add(dgvChildSchedule);
        Controls.Add(lblSec2);
        Controls.Add(dgvChildGrades);
        Controls.Add(cardHotline);
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

    private async Task LoadParentDataAsync()
    {
        try
        {
            var user = SessionManager.CurrentUser;
            int parentId = user?.ParentId ?? 1;

            using var conn = DatabaseConfig.GetConnection();

            var parent = await conn.QueryFirstOrDefaultAsync<dynamic>(
                "SELECT ParentCode, FullName FROM Parents WHERE ParentId = @ParentId;",
                new { ParentId = parentId });

            if (parent != null)
            {
                lblGreeting.Text = $"CỔNG THÔNG TIN PHỤ HUYNH: {parent.FullName} ({parent.ParentCode})";
            }

            var child = await conn.QueryFirstOrDefaultAsync<dynamic>(@"
                SELECT s.StudentId, s.StudentCode, s.FullName, sp.RelationshipType,
                       e.AttendanceRate, e.FinalGPA, c.ClassName, c.ClassCode,
                       i.FinalAmount, i.BalanceDue
                FROM StudentParents sp
                JOIN Students s ON sp.StudentId = s.StudentId
                LEFT JOIN Enrollments e ON e.StudentId = s.StudentId
                LEFT JOIN Classes c ON e.ClassId = c.ClassId
                LEFT JOIN Invoices i ON i.EnrollmentId = e.EnrollmentId
                WHERE sp.ParentId = @ParentId
                LIMIT 1;", new { ParentId = parentId });

            if (child != null)
            {
                int studentId = (int)child.StudentId;
                lblStudentName.Text = $"{child.FullName} ({child.StudentCode})";
                lblAttendanceStatus.Text = $"{child.AttendanceRate:F0}% (0 vắng)";
                lblAcademicGrade.Text = $"{child.FinalGPA:F1} / 10 (Giỏi)";

                decimal due = child.BalanceDue != null ? (decimal)child.BalanceDue : 0m;
                lblTuitionStatus.Text = due == 0m ? "Đã đóng đủ 100%" : $"Nợ: {due:N0} đ";
                if (due == 0m) lblTuitionStatus.ForeColor = ThemeColors.SuccessText;

                var schedules = await conn.QueryAsync<dynamic>(@"
                    SELECT cs.SessionNumber AS [Buổi], cs.Date AS [Ngày học], cs.StartTime || ' - ' || cs.EndTime AS [Giờ đưa đón],
                           cr.RoomName AS [Phòng học], t.FullName AS [Giáo viên], cs.Topic AS [Nội dung giảng dạy],
                           COALESCE(ar.Status, 'Chưa diễn ra') AS [Điểm danh con], COALESCE(ar.Note, '') AS [Ghi chú]
                    FROM ClassSchedules cs
                    JOIN Classes c ON cs.ClassId = c.ClassId
                    JOIN Enrollments e ON e.ClassId = c.ClassId AND e.StudentId = @StudentId
                    LEFT JOIN ClassRooms cr ON cs.RoomId = cr.RoomId
                    LEFT JOIN Teachers t ON cs.TeacherId = t.TeacherId
                    LEFT JOIN AttendanceRecords ar ON ar.ScheduleId = cs.ScheduleId AND ar.StudentId = @StudentId
                    ORDER BY cs.SessionNumber ASC;", new { StudentId = studentId });

                dgvChildSchedule.DataSource = System.Linq.Enumerable.ToList(schedules);

                var scores = await conn.QueryAsync<dynamic>(@"
                    SELECT ex.ExamName AS [Kỳ thi], ex.ExamDate AS [Ngày thi], ex.WeightPercentage || '%' AS [Tỷ trọng],
                           es.ScoreValue AS [Điểm số], es.TeacherComments AS [Đánh giá của giáo viên về con]
                    FROM ExamScores es
                    JOIN Exams ex ON es.ExamId = ex.ExamId
                    WHERE es.StudentId = @StudentId
                    ORDER BY ex.ExamDate ASC;", new { StudentId = studentId });

                dgvChildGrades.DataSource = System.Linq.Enumerable.ToList(scores);
            }
            else
            {
                lblStudentName.Text = "Chưa liên kết con";
                lblAttendanceStatus.Text = "N/A";
                lblAcademicGrade.Text = "N/A";
                lblTuitionStatus.Text = "N/A";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu phụ huynh: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
