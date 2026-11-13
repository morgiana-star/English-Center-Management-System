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

        // Kiểm tra đăng nhập (mẫu)
        if (username == "admin" && password == "admin123")
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
