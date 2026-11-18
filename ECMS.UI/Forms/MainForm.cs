using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.UserControls;

namespace ECMS.UI.Forms;

public partial class MainForm : Form
{
    private UserControl? _currentView;
    private Button? _activeNavButton;

    public MainForm()
    {
        InitializeComponent();

        // Xử lý phím tắt F1
        KeyPreview = true;
        KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowHelpDialog();
            }
        };

        // Gắn sự kiện click cho các nút Header và Sidebar
        WireUpNavigationEvents();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Áp dụng phân quyền hiển thị Sidebar theo vai trò đang đăng nhập
        ApplyRoleBasedAccessControl();
    }

    /// <summary>
    /// Gắn sự kiện click cho toàn bộ danh mục Menu Sidebar (A, B, C, D) và Header
    /// </summary>
    private void WireUpNavigationEvents()
    {
        // Header
        lblUser.Click += (s, e) => ShowUserProfile();
        btnLogoutTop.Click += (s, e) => HandleLogout();

        // Phân hệ A · TỔNG QUAN
        btnNavDashboard.Click += (s, e) => NavigateToDashboard();

        // Phân hệ B · ĐÀO TẠO
        btnNavStudent.Click += (s, e) => NavigateToStudents();
        btnNavTeacher.Click += (s, e) => NavigateToTeachers();
        btnNavCourse.Click += (s, e) => NavigateToCourse();
        btnNavClass.Click += (s, e) => NavigateToClasses();
        btnNavSchedule.Click += (s, e) => NavigateToSchedule();
        btnNavAttendance.Click += (s, e) => NavigateToAttendance();
        btnNavGrades.Click += (s, e) => NavigateToGrades();
        btnNavMaterials.Click += (s, e) => NavigateToMaterials();
        btnNavCertificates.Click += (s, e) => NavigateToCertificates();

        // Phân hệ C · TÀI CHÍNH
        btnNavTuition.Click += (s, e) => NavigateToTuition();

        // Phân hệ D · HỆ THỐNG
        btnNavAccounts.Click += (s, e) => NavigateToAccounts();
        btnNavSettings.Click += (s, e) => NavigateToSettings();
    }

    /// <summary>
    /// Áp dụng ma trận phân quyền RBAC: Ẩn/Hiện Menu Sidebar tự động theo vai trò người dùng
    /// </summary>
    private void ApplyRoleBasedAccessControl()
    {
        lblUser.Text = $"{AppSession.FullName} · {AppSession.RoleName} ▾";

        string role = AppSession.RoleCode;

        switch (role)
        {
            case "ROLE_ADMIN":
                // 1. Quản trị viên: Toàn quyền tất cả
                SetMenuVisibility(
                    dashboard: true,
                    student: true, teacher: true, course: true, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: true,
                    tuition: true,
                    accounts: true, settings: true
                );
                NavigateToDashboard();
                break;

            case "ROLE_MGR":
                // 2. Quản lý: Xem và duyệt toàn bộ, không sửa cấu hình hệ thống
                SetMenuVisibility(
                    dashboard: true,
                    student: true, teacher: true, course: true, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: true,
                    tuition: true,
                    accounts: true, settings: false
                );
                NavigateToDashboard();
                break;

            case "ROLE_AA":
                // 3. Đào tạo: Trọng tâm phân hệ B (Đào tạo), xem công nợ học phí
                SetMenuVisibility(
                    dashboard: true,
                    student: true, teacher: true, course: true, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: true,
                    tuition: true,
                    accounts: false, settings: false
                );
                NavigateToClasses();
                break;

            case "ROLE_EC":
                // 4. Tư vấn / Tuyển sinh: Hồ sơ học viên, xem khóa/lớp/lịch để tư vấn
                SetMenuVisibility(
                    dashboard: false,
                    student: true, teacher: false, course: true, @class: true,
                    schedule: true, attendance: false, grades: false, materials: false, certificates: false,
                    tuition: false,
                    accounts: false, settings: false
                );
                NavigateToStudents();
                break;

            case "ROLE_ACC":
                // 5. Kế toán: Trọng tâm phân hệ C (Học phí, công nợ, phiếu thu) & đối soát
                SetMenuVisibility(
                    dashboard: true,
                    student: true, teacher: false, course: true, @class: true,
                    schedule: false, attendance: false, grades: false, materials: false, certificates: false,
                    tuition: true,
                    accounts: false, settings: false
                );
                NavigateToTuition();
                break;

            case "ROLE_TEA":
                // 6. Giáo viên: Lớp dạy, Lịch dạy, Điểm danh, Điểm số, Tài liệu
                SetMenuVisibility(
                    dashboard: false,
                    student: false, teacher: false, course: false, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: false,
                    tuition: false,
                    accounts: false, settings: false
                );
                NavigateToSchedule();
                break;

            case "ROLE_STU":
                // 7. Học viên: Cổng thông tin tự phục vụ cá nhân
                SetMenuVisibility(
                    dashboard: false,
                    student: false, teacher: false, course: false, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: true,
                    tuition: true,
                    accounts: false, settings: false
                );
                NavigateToSchedule();
                break;

            default:
                SetMenuVisibility(
                    dashboard: false,
                    student: false, teacher: false, course: false, @class: true,
                    schedule: true, attendance: true, grades: true, materials: true, certificates: false,
                    tuition: false,
                    accounts: false, settings: false
                );
                NavigateToSchedule();
                break;
        }

        LayoutSidebarMenu();
    }

    private void SetMenuVisibility(
        bool dashboard,
        bool student, bool teacher, bool course, bool @class,
        bool schedule, bool attendance, bool grades, bool materials, bool certificates,
        bool tuition,
        bool accounts, bool settings)
    {
        btnNavDashboard.Visible = dashboard;
        btnNavStudent.Visible = student;
        btnNavTeacher.Visible = teacher;
        btnNavCourse.Visible = course;
        btnNavClass.Visible = @class;
        btnNavSchedule.Visible = schedule;
        btnNavAttendance.Visible = attendance;
        btnNavGrades.Visible = grades;
        btnNavMaterials.Visible = materials;
        btnNavCertificates.Visible = certificates;
        btnNavTuition.Visible = tuition;
        btnNavAccounts.Visible = accounts;
        btnNavSettings.Visible = settings;
    }

    /// <summary>
    /// Bố trí các mục Menu hiển thị liền mạch, tự động loại bỏ khoảng trắng khi ẩn mục
    /// </summary>
    private void LayoutSidebarMenu()
    {
        pnlSidebarMenu.SuspendLayout();
        int currentY = 8;

        // Phân hệ A · TỔNG QUAN
        bool hasGroupA = btnNavDashboard.Visible;
        lblGroupA.Visible = hasGroupA;
        if (hasGroupA)
        {
            lblGroupA.Location = new Point(20, currentY);
            lblGroupA.Size = new Size(210, 26);
            currentY += 26;

            btnNavDashboard.Location = new Point(0, currentY);
            btnNavDashboard.Size = new Size(248, 40);
            currentY += 42;
        }

        // Phân hệ B · ĐÀO TẠO
        var groupBControls = new Control[]
        {
            btnNavStudent, btnNavTeacher, btnNavCourse, btnNavClass,
            btnNavSchedule, btnNavAttendance, btnNavGrades, btnNavMaterials, btnNavCertificates
        };
        bool hasGroupB = groupBControls.Any(c => c.Visible);
        lblGroupB.Visible = hasGroupB;
        if (hasGroupB)
        {
            currentY += 8;
            lblGroupB.Location = new Point(20, currentY);
            lblGroupB.Size = new Size(210, 26);
            currentY += 26;
            foreach (var btn in groupBControls)
            {
                if (btn.Visible)
                {
                    btn.Location = new Point(0, currentY);
                    btn.Size = new Size(248, 40);
                    currentY += 42;
                }
            }
        }

        // Phân hệ C · TÀI CHÍNH
        bool hasGroupC = btnNavTuition.Visible;
        lblGroupC.Visible = hasGroupC;
        if (hasGroupC)
        {
            currentY += 8;
            lblGroupC.Location = new Point(20, currentY);
            lblGroupC.Size = new Size(210, 26);
            currentY += 26;
            btnNavTuition.Location = new Point(0, currentY);
            btnNavTuition.Size = new Size(248, 40);
            currentY += 42;
        }

        // Phân hệ D · HỆ THỐNG
        var groupDControls = new Control[] { btnNavAccounts, btnNavSettings };
        bool hasGroupD = groupDControls.Any(c => c.Visible);
        lblGroupD.Visible = hasGroupD;
        if (hasGroupD)
        {
            currentY += 8;
            lblGroupD.Location = new Point(20, currentY);
            lblGroupD.Size = new Size(210, 26);
            currentY += 26;
            foreach (var btn in groupDControls)
            {
                if (btn.Visible)
                {
                    btn.Location = new Point(0, currentY);
                    btn.Size = new Size(248, 40);
                    currentY += 42;
                }
            }
        }
        {
            currentY += 8;
            lblGroupD.Location = new Point(28, currentY);
            currentY += 28;
            foreach (var btn in groupDControls)
            {
                if (btn.Visible)
                {
                    btn.Location = new Point(0, currentY);
                    currentY += 42;
                }
            }
        }

        pnlSidebarMenu.ResumeLayout();
    }

    private void NavigateToDashboard()
    {
        SetActiveButton(btnNavDashboard);
        LoadView(new DashboardOverviewView());
    }

    private void NavigateToAccounts(int tabIndex = 0)
    {
        SetActiveButton(btnNavAccounts);
        var view = new AccountManagementView();
        view.SelectTab(tabIndex);
        LoadView(view);
    }

    private void NavigateToStudents()
    {
        SetActiveButton(btnNavStudent);
        LoadView(new StudentManagementView());
    }

    private void NavigateToTeachers()
    {
        SetActiveButton(btnNavTeacher);
        LoadView(new TeacherManagementView());
    }

    private void NavigateToCourse()
    {
        SetActiveButton(btnNavCourse);
        LoadView(new CourseManagementView());
    }

    private void NavigateToClasses()
    {
        SetActiveButton(btnNavClass);
        LoadView(new ClassManagementView());
    }

    private void NavigateToSchedule()
    {
        SetActiveButton(btnNavSchedule);
        LoadView(new ScheduleManagementView());
    }

    private void NavigateToAttendance()
    {
        SetActiveButton(btnNavAttendance);
        LoadView(new TeacherAttendanceCheckView());
    }

    private void NavigateToGrades()
    {
        SetActiveButton(btnNavGrades);
        LoadView(new TeacherGradeManagementView());
    }

    private void NavigateToTuition()
    {
        SetActiveButton(btnNavTuition);
        LoadView(new TuitionPaymentView());
    }

    private void NavigateToCertificates()
    {
        SetActiveButton(btnNavCertificates);
        LoadView(new CertificateManagementView());
    }

    private void NavigateToMaterials()
    {
        SetActiveButton(btnNavMaterials);
        LoadView(new StudyMaterialView());
    }

    private void NavigateToSettings()
    {
        SetActiveButton(btnNavSettings);
        LoadView(new SystemConfigView());
    }

    /// <summary>
    /// Đổi màu nút Menu đang Active (Nổi bật màu xanh, font đậm)
    /// </summary>
    private void SetActiveButton(Button button)
    {
        if (_activeNavButton != null && _activeNavButton != button)
        {
            _activeNavButton.BackColor = Color.White;
            _activeNavButton.ForeColor = Color.FromArgb(51, 65, 85);
            _activeNavButton.Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
            if (_activeNavButton.Text.StartsWith("•  "))
            {
                _activeNavButton.Text = _activeNavButton.Text[3..];
            }
        }

        _activeNavButton = button;
        _activeNavButton.BackColor = Color.FromArgb(239, 246, 255);
        _activeNavButton.ForeColor = Color.FromArgb(29, 78, 216);
        _activeNavButton.Font = new Font("Segoe UI", 9.25f, FontStyle.Bold);
        if (!_activeNavButton.Text.StartsWith("•  "))
        {
            _activeNavButton.Text = $"•  {_activeNavButton.Text}";
        }
    }

    /// <summary>
    /// Nạp view UserControl vào khu vực pnlContent
    /// </summary>
    public void LoadView(UserControl view)
    {
        pnlContent.SuspendLayout();
        pnlContent.Controls.Clear();
        _currentView?.Dispose();

        _currentView = view;
        _currentView.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(_currentView);
        pnlContent.ResumeLayout();
    }

    private void ShowHelpDialog()
    {
        AppDialog.ShowSuccess(this, "Hướng dẫn ngoại tuyến ECMS (F1)",
            "Hệ thống ECMS hoạt động hoàn toàn ngoại tuyến tại máy trạm.\n\n" +
            "• Phím F1: Mở trợ giúp\n" +
            "• Phím Esc: Hủy thao tác / Đóng hộp thoại\n" +
            "• Phím Enter: Xác nhận form / Lưu nhanh\n" +
            "• Phím Tab: Di chuyển trường nhập liệu tiếp theo\n\n" +
            "Mọi thay đổi được lưu trực tiếp vào cơ sở dữ liệu SQLite cục bộ.");
    }

    private void ShowUserProfile()
    {
        NavigateToAccounts(tabIndex: 2);
    }

    private void ShowNotifications()
    {
        AppDialog.ShowSuccess(this, "Thông báo nội bộ",
            "1. Có 3 học viên chưa đóng học phí khóa IELTS-F01.\n" +
            "2. Lịch học lớp TOEIC-T01 hôm nay lúc 18:00 tại phòng P202.\n" +
            "3. Đã sao lưu dữ liệu SQLite định kỳ thành công.");
    }

    private void HandleLogout()
    {
        using var dlg = new LogoutConfirmDialog();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            Hide();
            var login = new LoginForm();
            login.FormClosed += (sender, args) => Close();
            login.Show();
        }
    }
}