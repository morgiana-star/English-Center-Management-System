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
    private readonly System.Windows.Forms.Timer _clockTimer = new() { Interval = 15000 };

    public MainForm()
    {
        InitializeComponent();

        lblStatusRight.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        _clockTimer.Tick += (s, e) => lblStatusRight.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        _clockTimer.Start();

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

        // Tinh chỉnh icon các mục tiêu đề Sidebar (A, B, C, D) cho sắc nét và cân đối (chỉ gọi 1 lần)
        FormatSidebarHeaderIcons();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        // Áp dụng cấu hình thương hiệu (Tên App, Tên viết tắt, Logo) từ SQLite
        await ApplyBrandingAsync();
        // Áp dụng phân quyền hiển thị Sidebar theo vai trò đang đăng nhập từ DB
        await ApplyRoleBasedAccessControlAsync(navigateDefault: true);
    }

    public async Task ApplyBrandingAsync()
    {
        try
        {
            var cfg = await new SystemConfigService().GetCenterConfigAsync();
            string appTitle = string.IsNullOrWhiteSpace(cfg.AppName) ? "ECMS — Hệ thống quản lý trung tâm Anh ngữ" : cfg.AppName.Trim();
            string shortName = string.IsNullOrWhiteSpace(cfg.CenterShortName) ? "ECMS" : cfg.CenterShortName.Trim();
            string fullName = string.IsNullOrWhiteSpace(cfg.CenterName) ? "Trung tâm Anh ngữ" : cfg.CenterName.Trim();

            Text = appTitle;
            lblHeaderBrand.Text = shortName;
            lblHeaderCenter.Text = $"|  {fullName}";
            lblHeaderCenter.Location = new Point(lblHeaderBrand.Right + 10, lblHeaderCenter.Location.Y);

            if (!string.IsNullOrWhiteSpace(cfg.LogoPath) && System.IO.File.Exists(cfg.LogoPath))
            {
                using var fs = new System.IO.FileStream(cfg.LogoPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                using var img = Image.FromStream(fs);
                picHeaderLogo.Image = new Bitmap(img);
                picHeaderLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        catch
        {
            // Giữ thương hiệu mặc định nếu chưa có cấu hình
        }
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
        lblUser.Text = $"{AppSession.FullName} · {AppSession.RoleName}";
        if (lblUser.AutoSize)
        {
            lblUser.Location = new Point(btnLogoutTop.Left - lblUser.Width - 16, lblUser.Location.Y);
        }

        string role = AppSession.RoleCode;
        HashSet<string> allowed;
        try
        {
            var accessMap = await _rbacService.GetModuleAccessMapForRoleAsync(role);
            AppSession.ModuleAccessLevels = accessMap;
            allowed = new HashSet<string>(
                accessMap.Where(kv => !kv.Value.Contains("Không", StringComparison.OrdinalIgnoreCase)).Select(kv => kv.Key),
                StringComparer.OrdinalIgnoreCase);
        }
        catch
        {
            AppSession.ModuleAccessLevels = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
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
            btnNavSchedule, btnNavAttendance, btnNavGrades, btnNavCertificates
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
        LoadView(new DashboardOverviewView(), "Dashboard");
    }

    private void NavigateToAccounts(int tabIndex = 0)
    {
        SetActiveButton(btnNavAccounts);
        var view = new AccountManagementView();
        if (!AppSession.HasFullAccountAccess())
        {
            view.ConfigurePersonalOnlyMode();
        }
        else
        {
            view.SelectTab(tabIndex);
        }
        LoadView(view, "Accounts");
    }

    private void NavigateToStudents()
    {
        SetActiveButton(btnNavStudent);
        LoadView(new StudentManagementView(), "Student");
    }

    private void NavigateToTeachers()
    {
        SetActiveButton(btnNavTeacher);
        LoadView(new TeacherManagementView(), "Teacher");
    }

    private void NavigateToCourse()
    {
        SetActiveButton(btnNavCourse);
        LoadView(new CourseManagementView(), "Course");
    }

    private void NavigateToClasses()
    {
        SetActiveButton(btnNavClass);
        LoadView(new ClassManagementView(), "Class");
    }

    private void NavigateToSchedule()
    {
        SetActiveButton(btnNavSchedule);
        LoadView(new ScheduleManagementView(), "Schedule");
    }

    private void NavigateToAttendance()
    {
        SetActiveButton(btnNavAttendance);
        LoadView(new TeacherAttendanceCheckView(), "Attendance");
    }

    private void NavigateToGrades()
    {
        SetActiveButton(btnNavGrades);
        LoadView(new TeacherGradeManagementView(), "Grades");
    }

    private void NavigateToTuition()
    {
        SetActiveButton(btnNavTuition);
        LoadView(new TuitionPaymentView(), "Tuition");
    }

    private void NavigateToCertificates()
    {
        SetActiveButton(btnNavCertificates);
        LoadView(new CertificateManagementView(), "Certificates");
    }

    private void NavigateToSettings()
    {
        SetActiveButton(btnNavSettings);
        LoadView(new SystemConfigView(), "Settings");
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
    /// Nạp view UserControl vào khu vực pnlContent (và tự áp dụng chế độ Chỉ xem nếu vai trò chỉ có quyền xem)
    /// </summary>
    public void LoadView(UserControl view, string? moduleKey = null)
    {
        pnlContent.SuspendLayout();
        pnlContent.Controls.Clear();
        _currentView?.Dispose();

        _currentView = view;
        _currentView.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(_currentView);

        if (!string.IsNullOrWhiteSpace(moduleKey) && AppSession.IsReadOnlyModule(moduleKey))
        {
            ApplyReadOnlyRestrictions(_currentView);
        }

        pnlContent.ResumeLayout();
    }

    private static void ApplyReadOnlyRestrictions(Control root)
    {
        string[] writeKeywords =
        {
            "thêm", "đăng ký", "tạo", "sửa", "xóa", "lưu", "nhập excel",
            "cấp chứng chỉ", "thu phí", "thu học phí", "phục hồi", "khôi phục",
            "đặt lại", "khóa", "mở lớp", "lưu trữ"
        };

        void Walk(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    string txt = (btn.Text ?? string.Empty).Trim().ToLowerInvariant();
                    if (writeKeywords.Any(k => txt.Contains(k)) && !txt.Contains("xem") && !txt.Contains("tìm") && !txt.Contains("xuất"))
                    {
                        btn.Enabled = false;
                        btn.Visible = false;
                    }
                }
                else if (c is DataGridView dgv)
                {
                    dgv.ReadOnly = true;
                }

                if (c.HasChildren) Walk(c);
            }
        }

        Walk(root);
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
        if (AppSession.HasFullAccountAccess())
        {
            NavigateToAccounts(tabIndex: 2);
        }
        else
        {
            var personalView = new AccountManagementView();
            personalView.ConfigurePersonalOnlyMode();
            LoadView(personalView);
        }
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

    /// <summary>
    /// Tự động chuẩn hóa kích thước icon về 16x16 pixel sắc nét và căn chỉnh chữ cho 4 danh mục Sidebar (A, B, C, D)
    /// </summary>
    private void FormatSidebarHeaderIcons()
    {
        var headers = new (Label? lbl, Image? icon, string text)[]
        {
            (lblGroupA, lblGroupA?.Image, "A · TỔNG QUAN"),
            (lblGroupB, lblGroupB?.Image, "B · ĐÀO TẠO"),
            (lblGroupC, lblGroupC?.Image, "C · TÀI CHÍNH"),
            (lblGroupD, lblGroupD?.Image, "D · HỆ THỐNG")
        };

        foreach (var (lbl, icon, text) in headers)
        {
            if (lbl == null) continue;
            var originalIcon = icon;
            lbl.Text = "";
            lbl.Image = null;
            lbl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                var textColor = Color.FromArgb(100, 116, 139);

                if (originalIcon != null)
                {
                    int iconSize = 16;
                    int iconY = Math.Max(0, (lbl.Height - iconSize) / 2);

                    float r = textColor.R / 255f;
                    float g = textColor.G / 255f;
                    float b = textColor.B / 255f;

                    var colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                    {
                        new float[] { 0, 0, 0, 0, 0 },
                        new float[] { 0, 0, 0, 0, 0 },
                        new float[] { 0, 0, 0, 0, 0 },
                        new float[] { 0, 0, 0, 1, 0 },
                        new float[] { r, g, b, 0, 1 }
                    });

                    using var attr = new System.Drawing.Imaging.ImageAttributes();
                    attr.SetColorMatrix(colorMatrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);

                    e.Graphics.DrawImage(originalIcon, new Rectangle(0, iconY, iconSize, iconSize),
                        0, 0, originalIcon.Width, originalIcon.Height, GraphicsUnit.Pixel, attr);
                }

                using var brush = new SolidBrush(textColor);
                using var sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };
                var textRect = new Rectangle(24, 0, Math.Max(0, lbl.Width - 24), lbl.Height);
                e.Graphics.DrawString(text, lbl.Font, brush, textRect, sf);
            };
            lbl.Invalidate();
        }
    }
}