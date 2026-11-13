using System;
using System.Drawing;
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

        // Gắn sự kiện cho Header & Footer
        lblF1Help.Click += (s, e) => ShowHelpDialog();
        lblUser.Click += (s, e) => ShowUserProfile();
        lblAvatar.Click += (s, e) => ShowUserProfile();
        pnlAvatar.Click += (s, e) => ShowUserProfile();
        lblNotification.Click += (s, e) => ShowNotifications();
        btnLogoutTop.Click += (s, e) => HandleLogout();

        // Gắn sự kiện điều hướng cho 17 mục Sidebar
        WireUpNavigationEvents();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Mặc định chọn màn hình Tổng quan
        NavigateToDashboard();
    }

    /// <summary>
    /// Gắn sự kiện click cho toàn bộ danh mục Menu Sidebar (A, B, C, D)
    /// </summary>
    private void WireUpNavigationEvents()
    {
        // Phân hệ A · TỔNG QUAN
        btnNavDashboard.Click += (s, e) => NavigateToDashboard();

        // Phân hệ B · ĐÀO TẠO
        btnNavStudent.Click += (s, e) => NavigateToStudents();
        btnNavTeacher.Click += (s, e) => NavigateToTeachers();
        btnNavCourse.Click += (s, e) => NavigateToCourse();
        btnNavClass.Click += (s, e) => NavigateToClasses();
        btnNavSchedule.Click += (s, e) => NavigateToSchedule();
        btnNavAttendance.Click += (s, e) => NavigateToFeature(btnNavAttendance, "B · Đào tạo", "Điểm danh", "Từng buổi · tổng hợp · liên hệ");
        btnNavGrades.Click += (s, e) => NavigateToFeature(btnNavGrades, "B · Đào tạo", "Kiểm tra & Điểm số", "Bài kiểm tra · trọng số · xếp loại");
        btnNavMaterials.Click += (s, e) => NavigateToFeature(btnNavMaterials, "B · Đào tạo", "Tài liệu học tập", "Tệp cục bộ · phiên bản · khóa học");
        btnNavCertificates.Click += (s, e) => NavigateToFeature(btnNavCertificates, "B · Đào tạo", "Chứng chỉ", "Điều kiện · duyệt cấp · số cấp");

        // Phân hệ C · TUYỂN SINH & TÀI CHÍNH
        btnNavAdmissions.Click += (s, e) => NavigateToAdmissions();
        btnNavTuition.Click += (s, e) => NavigateToFeature(btnNavTuition, "C · Tuyển sinh & Tài chính", "Học phí & Thanh toán", "Học phí gốc → ưu đãi → thu tiền → phiếu thu → dư nợ. Ghi nhận chuyển khoản thủ công.");

        // Phân hệ D · NHÂN SỰ & HỆ THỐNG
        btnNavStaff.Click += (s, e) => NavigateToFeature(btnNavStaff, "D · Nhân sự & Hệ thống", "Nhân viên", "Danh bạ · thêm / sửa · trạng thái");
        btnNavNotifications.Click += (s, e) => NavigateToFeature(btnNavNotifications, "D · Nhân sự & Hệ thống", "Thông báo", "Soạn · người nhận theo vai trò · đã đọc");
        btnNavReports.Click += (s, e) => NavigateToFeature(btnNavReports, "D · Nhân sự & Hệ thống", "Báo cáo & Thống kê", "Học tập · chuyên cần · tài chính · tệp cục bộ");
        btnNavAccounts.Click += (s, e) => NavigateToAccounts();
        btnNavSettings.Click += (s, e) => NavigateToFeature(btnNavSettings, "D · Nhân sự & Hệ thống", "Cấu hình", "Trung tâm · dữ liệu · sao lưu · quy tắc");
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

    private void NavigateToAdmissions()
    {
        SetActiveButton(btnNavAdmissions);
        LoadView(new AdmissionsView());
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

    private void NavigateToFeature(Button button, string group, string title, string scope)
    {
        SetActiveButton(button);
        LoadView(new PlaceholderView(group, title, scope, () => NavigateToDashboard()));
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
        _activeNavButton.ForeColor = Color.FromArgb(37, 99, 235);
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
