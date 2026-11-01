using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.Entities;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public class StudentListView : UserControl
{
    private readonly IStudentService _studentService = new StudentService();

    private ModernTextBox txtSearch = null!;
    private DataGridView dgvStudents = null!;
    private CustomButton btnAdd = null!;

    public StudentListView()
    {
        InitializeComponents();
        Load += async (s, e) => await LoadStudentsAsync();
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;

        var lblTitle = new Label
        {
            Text = "QUẢN LÝ HỒ SƠ HỌC VIÊN",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var panelSearch = new GlassCard
        {
            Location = new Point(25, 65),
            Size = new Size(1060, 68),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(12)
        };

        txtSearch = new ModernTextBox
        {
            Placeholder = "Nhập mã học viên (HV-2026-...) hoặc họ tên để tìm...",
            Location = new Point(15, 12),
            Size = new Size(450, 42),
            CornerRadius = 6
        };

        var btnSearch = new CustomButton
        {
            Text = "TÌM KIẾM",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(475, 12),
            Size = new Size(110, 42),
            CornerRadius = 6
        };
        btnSearch.Click += async (s, e) => await LoadStudentsAsync();

        btnAdd = new CustomButton
        {
            Text = "+ THÊM HỌC VIÊN",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(880, 12),
            Size = new Size(165, 42),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            CornerRadius = 6
        };
        btnAdd.Click += async (s, e) => await CreateQuickStudentAsync();

        panelSearch.Controls.Add(txtSearch);
        panelSearch.Controls.Add(btnSearch);
        panelSearch.Controls.Add(btnAdd);

        dgvStudents = new DataGridView
        {
            Location = new Point(25, 145),
            Size = new Size(1060, 520),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };
        ModernGridHelper.ApplyStyle(dgvStudents);

        Controls.Add(lblTitle);
        Controls.Add(panelSearch);
        Controls.Add(dgvStudents);
    }

    private async Task LoadStudentsAsync()
    {
        try
        {
            string keyword = txtSearch.Text.Trim();
            var students = await _studentService.SearchStudentsAsync(keyword);
            dgvStudents.DataSource = System.Linq.Enumerable.ToList(students);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách học viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task CreateQuickStudentAsync()
    {
        try
        {
            var newStu = new Student
            {
                FullName = "Học viên Demo " + DateTime.Now.ToString("HH:mm"),
                DateOfBirth = new DateTime(2005, 1, 1),
                Gender = "Nam",
                Phone = "09" + new Random().Next(10000000, 99999999),
                Email = $"demo_{DateTime.Now.Ticks % 10000}@ecms.edu.vn",
                Address = "TP. Hồ Chí Minh"
            };

            await _studentService.CreateStudentAsync(newStu);
            MessageBox.Show($"Đã tạo thành công học viên: {newStu.FullName} (Mã: {newStu.StudentCode})", "Thành công", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadStudentsAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tạo học viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
