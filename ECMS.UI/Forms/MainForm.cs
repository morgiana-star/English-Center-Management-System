using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.UI.Controls;
using ECMS.UI.UserControls;

namespace ECMS.UI.Forms;

public partial class MainForm : Form
{
    private readonly IRbacService _rbacService = new RbacService();
    private UserControl? _currentView;
    private Button? _activeNavButton;

    public MainForm()
    {
        InitializeComponent();

        // Thêm đường viền mảnh 1px ở runtime để Rider Designer mở được bình thường
        var pnlHeaderBorder = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 1,
            BackColor = Color.FromArgb(226, 232, 240)
        };
        pnlHeader.Controls.Add(pnlHeaderBorder);

        var pnlSidebarBorder = new Panel
        {
            Dock = DockStyle.Right,
            Width = 1,
            BackColor = Color.FromArgb(226, 232, 240)
        };
        pnlSidebar.Controls.Add(pnlSidebarBorder);

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

    private async void MainForm_Load(object sender, EventArgs e)
    {
        // Áp dụng phân quyền hiển thị Sidebar theo vai trò đang đăng nhập từ DB
        await ApplyRoleBasedAccessControlAsync(navigateDefault: true);
    }

    public Task RefreshSidebarPermissionsAsync() => ApplyRoleBasedAccessControlAsync(navigateDefault: false);

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
    /// Áp dụng ma trận phân quyền RBAC từ CSDL: Ẩn/Hiện Menu Sidebar tự động theo vai trò người dùng
    /// </summary>
    private async Task ApplyRoleBasedAccessControlAsync(bool navigateDefault = true)
    {
        lblUser.Text = $"{AppSession.FullName} · {AppSession.RoleName} ▾";

        string role = AppSession.RoleCode;
        HashSet<string> allowed;
        try
        {
            allowed = await _rbacService.GetAllowedModuleKeysForRoleAsync(role);
        }
        catch
        {
            allowed = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        if (role == "ROLE_ADMIN" || allowed.Count == 0)
        {
            // Fallback chuẩn nếu chưa đọc được hoặc là Admin
            if (role == "ROLE_ADMIN")
            {
                SetMenuVisibility(true, true, true, true, true, true, true, true, true, true, true, true, true);
            }
            else if (role == "ROLE_MGR")
            {
                SetMenuVisibility(true, true, true, true, true, true, true, true, true, true, true, true, false);
            }
            else if (role == "ROLE_AA")
            {
                SetMenuVisibility(true, true, true, true, true, true, true, true, true, true, true, false, false);
            }
            else if (role == "ROLE_EC")
            {
                SetMenuVisibility(false, true, false, true, true, true, false, false, false, false, false, false, false);
            }
            else if (role == "ROLE_ACC")
            {
                SetMenuVisibility(true, true, false, true, true, false, false, false, false, false, true, false, false);
            }
            else
            {
                SetMenuVisibility(false, false, false, false, true, true, true, true, true, false, false, false, false);
            }
        }
        else
        {
            SetMenuVisibility(
                dashboard: allowed.Contains("Dashboard"),
                student: allowed.Contains("Student"),
                teacher: allowed.Contains("Teacher"),
                course: allowed.Contains("Course"),
                @class: allowed.Contains("Class"),
                schedule: allowed.Contains("Schedule"),
                attendance: allowed.Contains("Attendance"),
                grades: allowed.Contains("Grades"),
                materials: allowed.Contains("Materials"),
                certificates: allowed.Contains("Certificates"),
                tuition: allowed.Contains("Tuition"),
                accounts: allowed.Contains("Accounts"),
                settings: allowed.Contains("Settings")
            );
        }

        LayoutSidebarMenu();

        if (navigateDefault)
        {
            if (role == "ROLE_EC" && btnNavStudent.Visible) NavigateToStudents();
            else if (role == "ROLE_ACC" && btnNavTuition.Visible) NavigateToTuition();
            else if (role == "ROLE_TEA" && btnNavSchedule.Visible) NavigateToSchedule();
            else if (role == "ROLE_AA" && btnNavClass.Visible) NavigateToClasses();
            else if (btnNavDashboard.Visible) NavigateToDashboard();
            else if (btnNavStudent.Visible) NavigateToStudents();
            else if (btnNavClass.Visible) NavigateToClasses();
            else if (btnNavSchedule.Visible) NavigateToSchedule();
            else if (btnNavTuition.Visible) NavigateToTuition();
            else if (btnNavAccounts.Visible) NavigateToAccounts();
        }
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
            _activeNavButton.ForeColor = Color.FromArgb(100, 116, 139);
            _activeNavButton.Font = new Font("Segoe UI", 9.25f, FontStyle.Regular);
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