using System;
using System.Windows.Forms;

namespace ECMS.UI.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        // Đảm bảo không bị dính chữ mặc định khi kéo thả
        if (txtUsername.Text == "appTextBox1") txtUsername.Text = "";
        if (txtPassword.Text == "appTextBox2") txtPassword.Text = "";
    }

    private void chkShowPass_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            lblError.Text = "* Vui lòng nhập đầy đủ tài khoản và mật khẩu!";
            lblError.Visible = true;
            return;
        }

        // Kiểm tra đăng nhập (Hỗ trợ Admin, Giáo viên, Học viên, Kế toán, Quản lý, Tư vấn, Phụ huynh)
        bool loginSuccess = false;
        string u = username.ToLowerInvariant();

        if ((u == "admin" || u == "minhquan.admin") && (password == "admin123" || password == "Admin@123"))
        {
            AppSession.Username = "minhquan.admin";
            AppSession.FullName = "Trần Minh Quân";
            AppSession.RoleCode = "ROLE_ADMIN";
            AppSession.RoleName = "Admin";
            AppSession.SignerTitle = "GIÁM ĐỐC TRUNG TÂM";
            AppSession.Email = "minhquan@ecms.edu.vn";
            AppSession.Phone = "0912 345 678";
            loginSuccess = true;
        }
        else if ((u == "teacher" || u == "hoanganh.gv") && (password == "teacher123" || password == "Teacher@123"))
        {
            AppSession.Username = "hoanganh.gv";
            AppSession.FullName = "Nguyễn Hoàng Anh";
            AppSession.RoleCode = "ROLE_TEA";
            AppSession.RoleName = "Giáo viên";
            AppSession.SignerTitle = "GIÁO VIÊN PHỤ TRÁCH";
            AppSession.Email = "hoanganh.gv@ecms.edu.vn";
            AppSession.Phone = "0903 112 233";
            loginSuccess = true;
        }
        else if ((u == "student" || u == "minhanh.hv") && (password == "student123" || password == "Student@123"))
        {
            AppSession.Username = "minhanh.hv";
            AppSession.FullName = "Nguyễn Minh Anh";
            AppSession.RoleCode = "ROLE_STU";
            AppSession.RoleName = "Học viên";
            AppSession.SignerTitle = "HỌC VIÊN";
            AppSession.Email = "minhanh.hv@gmail.com";
            AppSession.Phone = "0934 998 877";
            loginSuccess = true;
        }
        else if ((u == "accountant" || u == "thao.kt") && (password == "accountant123" || password == "Accountant@123"))
        {
            AppSession.Username = "thao.kt";
            AppSession.FullName = "Lê Phương Thảo";
            AppSession.RoleCode = "ROLE_ACC";
            AppSession.RoleName = "Kế toán";
            AppSession.SignerTitle = "KẾ TOÁN TRƯỞNG";
            AppSession.Email = "thao.kt@ecms.edu.vn";
            AppSession.Phone = "0988 556 778";
            loginSuccess = true;
        }
        else if (u == "counselor" && (password == "counselor123" || password == "Counselor@123"))
        {
            AppSession.Username = "counselor";
            AppSession.FullName = "Vũ Mai Phương";
            AppSession.RoleCode = "ROLE_EC";
            AppSession.RoleName = "Tư vấn";
            AppSession.SignerTitle = "TƯ VẤN TUYỂN SINH";
            AppSession.Email = "phuong.tv@ecms.edu.vn";
            AppSession.Phone = "0977 443 322";
            loginSuccess = true;
        }
        else if (u == "manager" && (password == "manager123" || password == "Manager@123"))
        {
            AppSession.Username = "manager";
            AppSession.FullName = "Phạm Thu Trang";
            AppSession.RoleCode = "ROLE_MGR";
            AppSession.RoleName = "Quản lý";
            AppSession.SignerTitle = "QUẢN LÝ ĐIỀU HÀNH";
            AppSession.Email = "manager@ecms.edu.vn";
            AppSession.Phone = "0915 223 344";
            loginSuccess = true;
        }
        else if ((u == "academic" || u == "academic.aa") && (password == "academic123" || password == "Academic@123"))
        {
            AppSession.Username = "academic.aa";
            AppSession.FullName = "Trần Đức Duy";
            AppSession.RoleCode = "ROLE_AA";
            AppSession.RoleName = "Đào tạo";
            AppSession.SignerTitle = "TRƯỞNG BỘ PHẬN ĐÀO TẠO";
            AppSession.Email = "ducduy.aa@ecms.edu.vn";
            AppSession.Phone = "0918 889 900";
            loginSuccess = true;
        }

        if (loginSuccess)
        {
            lblError.Visible = false;

            // Mở MainForm và ẩn LoginForm
            Hide();
            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }
        else
        {
            lblError.Text = "* Tên đăng nhập hoặc mật khẩu không chính xác!";
            lblError.Visible = true;
            txtPassword.Focus();
            txtPassword.SelectAll();
        }
    }
}
