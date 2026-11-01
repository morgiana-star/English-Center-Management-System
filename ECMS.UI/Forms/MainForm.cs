using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.Business.Session;
using ECMS.UI.Controls;
using ECMS.UI.UserControls;

namespace ECMS.UI.Forms;

public class MainForm : Form
{
    private GlassCard cardSidebar = null!;
    private Panel pnlNavContainer = null!;
    private GlassCard cardHeader = null!;
    private Panel pnlContent = null!;

    private Label lblUserGreeting = null!;
    private Label lblRoleBadge = null!;
    private Label lblPortalType = null!;
    private Label lblSidebarUserName = null!;
    private Label lblSidebarUserRole = null!;

    private Button? _lastActiveButton;

    public MainForm()
    {
        InitializeComponents();
        Load += (s, e) => SetupUserSessionView();
    }

    private void InitializeComponents()
    {
        Text = "ECMS - English Center Management System (Modern Glassmorphism)";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(1360, 840);
        MinimumSize = new Size(1180, 720);
        DoubleBuffered = true;

        // 1. Wallpaper Background (Ảnh nền mờ ambient bokeh đa tầng chuẩn Glassmorphism)
        BackgroundImage = WallpaperHelper.GetAmbientWallpaper();
        BackgroundImageLayout = ImageLayout.Stretch;

        // 2. Floating Left Sidebar (Thẻ kính Acrylic nổi bo góc 18px)
        cardSidebar = new GlassCard
        {
            Location = new Point(16, 16),
            Size = new Size(240, ClientSize.Height - 32),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left,
            CornerRadius = 18,
            GlassColor = Color.FromArgb(195, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(245, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true,
            Padding = new Padding(12)
        };

        // Logo Top
        var pnlLogo = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = Color.Transparent
        };

        var pnlLogoIcon = new Panel
        {
            Location = new Point(8, 12),
            Size = new Size(36, 36),
            BackColor = Color.FromArgb(79, 70, 229)
        };

        var lblLogoIcon = new Label
        {
            Text = "✦",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            ForeColor = Color.White,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        pnlLogoIcon.Controls.Add(lblLogoIcon);

        var lblLogo = new Label
        {
            Text = "ecms",
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(50, 10),
            AutoSize = true
        };

        lblPortalType = new Label
        {
            Text = "ENGLISH CENTER",
            Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(52, 34),
            AutoSize = true
        };

        pnlLogo.Controls.Add(pnlLogoIcon);
        pnlLogo.Controls.Add(lblLogo);
        pnlLogo.Controls.Add(lblPortalType);
        cardSidebar.Controls.Add(pnlLogo);

        // Bottom User Mini Card inside Sidebar
        var cardUserMini = new GlassCard
        {
            Dock = DockStyle.Bottom,
            Height = 65,
            CornerRadius = 12,
            GlassColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(226, 232, 240),
            BorderGlowWidth = 1,
            EnableShadow = false,
            Padding = new Padding(8)
        };

        var pnlAvatar = new Panel
        {
            Location = new Point(8, 12),
            Size = new Size(36, 36),
            BackColor = Color.FromArgb(99, 102, 241)
        };
        var lblAvatar = new Label
        {
            Text = "👤",
            Font = new Font("Segoe UI", 12),
            ForeColor = Color.White,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        pnlAvatar.Controls.Add(lblAvatar);

        lblSidebarUserName = new Label
        {
            Text = "Sarah Khan",
            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(50, 12),
            Size = new Size(130, 18)
        };

        lblSidebarUserRole = new Label
        {
            Text = "Admin",
            Font = new Font("Segoe UI", 7.8f),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(50, 30),
            Size = new Size(130, 16)
        };

        cardUserMini.Controls.Add(pnlAvatar);
        cardUserMini.Controls.Add(lblSidebarUserName);
        cardUserMini.Controls.Add(lblSidebarUserRole);
        cardSidebar.Controls.Add(cardUserMini);

        // Scrollable Nav Container for Sidebar Items
        pnlNavContainer = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = Color.Transparent
        };
        cardSidebar.Controls.Add(pnlNavContainer);

        // 3. Floating Top Header Bar (Thẻ kính Acrylic nổi ngang)
        cardHeader = new GlassCard
        {
            Location = new Point(272, 16),
            Size = new Size(ClientSize.Width - 288, 56),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 16,
            GlassColor = Color.FromArgb(190, 255, 255, 255),
            BorderGlowColor = Color.FromArgb(240, 255, 255, 255),
            BorderGlowWidth = 1,
            EnableShadow = true,
            Padding = new Padding(10)
        };

        var txtSearchGlobal = new ModernTextBox
        {
            Placeholder = "🔍  Tìm kiếm học viên, khóa học, hóa đơn... (Ctrl + K)",
            Location = new Point(14, 8),
            Size = new Size(420, 38),
            CornerRadius = 8,
            BoxBackColor = Color.FromArgb(245, 255, 255, 255)
        };

        lblUserGreeting = new Label
        {
            Text = "Xin chào: ...",
            Font = new Font("Segoe UI", 9.8f, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(460, 18),
            AutoSize = true
        };

        lblRoleBadge = new Label
        {
            Text = "Vai trò",
            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(79, 70, 229),
            BackColor = Color.FromArgb(238, 242, 255),
            Location = new Point(cardHeader.Width - 240, 13),
            Padding = new Padding(10, 5, 10, 5),
            AutoSize = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };

        var btnLogout = new CustomButton
        {
            Text = "Đăng xuất",
            NormalColor = Color.FromArgb(239, 68, 68),
            HoverColor = Color.FromArgb(220, 38, 38),
            Size = new Size(100, 34),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(cardHeader.Width - 118, 11),
            CornerRadius = 8
        };
        btnLogout.Click += (s, e) => HandleLogout();

        cardHeader.Controls.Add(txtSearchGlobal);
        cardHeader.Controls.Add(lblUserGreeting);
        cardHeader.Controls.Add(lblRoleBadge);
        cardHeader.Controls.Add(btnLogout);

        // 4. Floating Main Content Container (Trong suốt, nạp UserControl)
        pnlContent = new Panel
        {
            Location = new Point(272, 86),
            Size = new Size(ClientSize.Width - 288, ClientSize.Height - 102),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            BackColor = Color.Transparent,
            AutoScroll = true
        };

        Controls.Add(pnlContent);
        Controls.Add(cardHeader);
        Controls.Add(cardSidebar);
    }

    private void SetupUserSessionView()
    {
        var user = SessionManager.CurrentUser;
        if (user == null)
        {
            HandleLogout();
            return;
        }

        lblUserGreeting.Text = "Xin chào: " + user.FullName;
        lblSidebarUserName.Text = user.FullName;
        lblSidebarUserRole.Text = user.RoleName;
        lblRoleBadge.Text = user.RoleName;

        switch (user.RoleCode)
        {
            case "ROLE_ADMIN":
                lblPortalType.Text = "ADMIN PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(254, 226, 226);
                lblRoleBadge.ForeColor = Color.FromArgb(185, 28, 28);
                break;
            case "ROLE_MGR":
                lblPortalType.Text = "DIRECTOR PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(243, 232, 255);
                lblRoleBadge.ForeColor = Color.FromArgb(126, 34, 206);
                break;
            case "ROLE_EC":
                lblPortalType.Text = "CONSULTANT PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(224, 242, 254);
                lblRoleBadge.ForeColor = Color.FromArgb(3, 105, 161);
                break;
            case "ROLE_ACC":
                lblPortalType.Text = "FINANCE PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(254, 243, 199);
                lblRoleBadge.ForeColor = Color.FromArgb(180, 83, 9);
                break;
            case "ROLE_AA":
                lblPortalType.Text = "ACADEMIC PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(220, 252, 231);
                lblRoleBadge.ForeColor = Color.FromArgb(21, 128, 61);
                break;
            case "ROLE_TEA":
                lblPortalType.Text = "TEACHER PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(224, 231, 255);
                lblRoleBadge.ForeColor = Color.FromArgb(67, 56, 202);
                break;
            case "ROLE_STU":
                lblPortalType.Text = "STUDENT PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(255, 237, 213);
                lblRoleBadge.ForeColor = Color.FromArgb(194, 65, 12);
                break;
            case "ROLE_PAR":
                lblPortalType.Text = "PARENT PORTAL";
                lblRoleBadge.BackColor = Color.FromArgb(252, 231, 243);
                lblRoleBadge.ForeColor = Color.FromArgb(190, 24, 93);
                break;
        }

        // Build Sidebar Items
        BuildRoleSpecificSidebar(user.RoleCode);

        // MẶC ĐỊNH MỞ NGAY GIAO DIỆN DEMO THEO ĐÚNG ẢNH MẪU 2 ĐỂ USER TRẢI NGHIỆM!
        ShowUserControl(new ModernGlassDemoView());
    }

    private void BuildRoleSpecificSidebar(string roleCode)
    {
        pnlNavContainer.Controls.Clear();
        int top = 5;

        // NÚT DEMO ĐẶC BIỆT NẰM TRÊN CÙNG ĐỂ USER LUÔN CÓ THỂ MỞ LẠI
        AddNavButton("✨ DEMO GLASS (ẢNH 2)", () => ShowUserControl(new ModernGlassDemoView()), ref top, true);

        switch (roleCode)
        {
            case "ROLE_ADMIN":
                AddCategoryHeader("BÀN LÀM VIỆC", ref top);
                AddNavButton("Dashboard Kỹ thuật", () => ShowUserControl(new AdminDashboardView()), ref top, false);

                AddCategoryHeader("TÀI KHOẢN & BẢO MẬT", ref top);
                AddNavButton("Quản lý Người dùng", () => ShowUserControl(new AdminDashboardView()), ref top, false);
                AddNavButton("Phân quyền RBAC", () => ShowMessageBox("Phân quyền chức năng RBAC: Phân quyền chi tiết 23 phân hệ."), ref top, false);
                AddNavButton("Mở khóa Brute-force", () => ShowMessageBox("Mở khóa tài khoản: Quản lý các tài khoản bị khóa do nhập sai pass."), ref top, false);

                AddCategoryHeader("DỮ LIỆU & HẠ TẦNG", ref top);
                AddNavButton("Hồ sơ Học viên", () => ShowUserControl(new StudentListView()), ref top, false);
                AddNavButton("Sao lưu CSDL SQLite", () => ShowMessageBox("Sao lưu CSDL SQLite (Backup): Xuất tệp sao lưu .bak an toàn."), ref top, false);
                AddNavButton("Khôi phục CSDL", () => ShowMessageBox("Khôi phục CSDL (Restore): Kiểm tra tính toàn vẹn integrity_check trước khi nạp."), ref top, false);
                AddNavButton("Phòng học & Cơ sở", () => ShowMessageBox("Quản lý danh mục Phòng học & sức chứa tối đa."), ref top, false);

                AddCategoryHeader("KIỂM TOÁN HỆ THỐNG", ref top);
                AddNavButton("Nhật ký Audit Logs", () => ShowMessageBox("Nhật ký thao tác hệ thống (Audit Logs - Append Only)."), ref top, false);
                break;

            case "ROLE_MGR":
                AddCategoryHeader("BÀN LÀM VIỆC ĐIỀU HÀNH", ref top);
                AddNavButton("Dashboard Giám đốc", () => ShowUserControl(new DashboardView()), ref top, false);

                AddCategoryHeader("BÁO CÁO CHIẾN LƯỢC", ref top);
                AddNavButton("Báo cáo Doanh thu", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                AddNavButton("Công nợ toàn trường", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                AddNavButton("Chất lượng đào tạo", () => ShowUserControl(new DashboardView()), ref top, false);
                break;

            case "ROLE_EC":
                AddCategoryHeader("BÀN LÀM VIỆC TUYỂN SINH", ref top);
                AddNavButton("Dashboard Tuyển sinh", () => ShowUserControl(new AdmissionsDashboardView()), ref top, false);
                AddNavButton("Khách tiềm năng (Leads)", () => ShowUserControl(new AdmissionsDashboardView()), ref top, false);
                AddNavButton("Hồ sơ Học viên", () => ShowUserControl(new StudentListView()), ref top, false);
                AddNavButton("Lớp đang tuyển sinh", () => ShowUserControl(new AcademicDashboardView()), ref top, false);
                break;

            case "ROLE_ACC":
                AddCategoryHeader("BÀN LÀM VIỆC TÀI CHÍNH", ref top);
                AddNavButton("Dashboard Tài chính", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                AddNavButton("Khoản phải thu", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                AddNavButton("Lập phiếu thu tiền", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                AddNavButton("Quản lý Công nợ", () => ShowUserControl(new FinanceDashboardView()), ref top, false);
                break;

            case "ROLE_AA":
                AddCategoryHeader("BÀN LÀM VIỆC ĐÀO TẠO", ref top);
                AddNavButton("Dashboard Giáo vụ", () => ShowUserControl(new AcademicDashboardView()), ref top, false);
                AddNavButton("Quản lý Lớp học", () => ShowUserControl(new AcademicDashboardView()), ref top, false);
                AddNavButton("Hồ sơ Học viên", () => ShowUserControl(new StudentListView()), ref top, false);
                AddNavButton("Sổ điểm danh trường", () => ShowUserControl(new DashboardView()), ref top, false);
                break;

            case "ROLE_TEA":
                AddCategoryHeader("BÀN LÀM VIỆC GIÁO VIÊN", ref top);
                AddNavButton("Dashboard Giảng dạy", () => ShowUserControl(new TeacherPortalView()), ref top, false);
                AddNavButton("Thời khóa biểu của tôi", () => ShowUserControl(new TeacherPortalView()), ref top, false);
                AddNavButton("Lớp học của tôi", () => ShowUserControl(new TeacherPortalView()), ref top, false);
                break;

            case "ROLE_STU":
                AddCategoryHeader("CỔNG HỌC VIÊN", ref top);
                AddNavButton("Trang cá nhân học viên", () => ShowUserControl(new StudentPortalView()), ref top, false);
                AddNavButton("Thời khóa biểu của tôi", () => ShowUserControl(new StudentPortalView()), ref top, false);
                AddNavButton("Bảng điểm & Kết quả", () => ShowUserControl(new StudentPortalView()), ref top, false);
                AddNavButton("Học phí & Lịch sử đóng", () => ShowUserControl(new StudentPortalView()), ref top, false);
                break;

            case "ROLE_PAR":
                AddCategoryHeader("CỔNG PHỤ HUYNH", ref top);
                AddNavButton("Tổng quan con em", () => ShowUserControl(new ParentPortalView()), ref top, false);
                AddNavButton("Lịch học của con", () => ShowUserControl(new ParentPortalView()), ref top, false);
                AddNavButton("Bảng điểm & Nhận xét", () => ShowUserControl(new ParentPortalView()), ref top, false);
                AddNavButton("Học phí các con", () => ShowUserControl(new ParentPortalView()), ref top, false);
                break;
        }
    }

    private void AddCategoryHeader(string text, ref int top)
    {
        var lbl = new Label
        {
            Text = text,
            Font = new Font("Segoe UI", 7.8f, FontStyle.Bold),
            ForeColor = Color.FromArgb(148, 163, 184),
            Location = new Point(14, top),
            Size = new Size(200, 20),
            TextAlign = ContentAlignment.BottomLeft
        };
        pnlNavContainer.Controls.Add(lbl);
        top += 24;
    }

    private void AddNavButton(string text, Action onClick, ref int top, bool isPrimary = false)
    {
        var btn = new Button
        {
            Text = "  " + text,
            Font = new Font("Segoe UI", 9.2f, isPrimary ? FontStyle.Bold : FontStyle.Regular),
            ForeColor = isPrimary ? Color.White : Color.FromArgb(51, 65, 85),
            BackColor = isPrimary ? Color.FromArgb(79, 70, 229) : Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            TextAlign = ContentAlignment.MiddleLeft,
            Location = new Point(6, top),
            Size = new Size(210, 36),
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatAppearance.MouseOverBackColor = isPrimary ? Color.FromArgb(99, 102, 241) : Color.FromArgb(226, 232, 240);

        if (isPrimary) _lastActiveButton = btn;

        btn.Click += (s, e) =>
        {
            if (_lastActiveButton != null && _lastActiveButton != btn)
            {
                _lastActiveButton.BackColor = Color.Transparent;
                _lastActiveButton.ForeColor = Color.FromArgb(51, 65, 85);
                _lastActiveButton.Font = new Font("Segoe UI", 9.2f, FontStyle.Regular);
            }

            btn.BackColor = Color.FromArgb(79, 70, 229);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            _lastActiveButton = btn;

            onClick();
        };

        pnlNavContainer.Controls.Add(btn);
        top += 40;
    }

    private void ShowMessageBox(string message)
    {
        MessageBox.Show(message, "Thông báo chức năng", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowUserControl(UserControl view)
    {
        pnlContent.Controls.Clear();
        view.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(view);
    }

    private void HandleLogout()
    {
        SessionManager.ClearSession();
        Hide();
        using var login = new LoginForm();
        if (login.ShowDialog() == DialogResult.OK)
        {
            Show();
            SetupUserSessionView();
        }
        else
        {
            Close();
        }
    }
}
