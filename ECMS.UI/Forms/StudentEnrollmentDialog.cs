using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class StudentEnrollmentDialog : Form
{
    private readonly IEnrollmentService _enrollmentService;
    private readonly LeadListItemDto? _lead;

    private List<ClassLookupDto> _availableClasses = new();

    // Controls
    private ModernTextBox txtFullName = null!;
    private DateTimePicker dtpDob = null!;
    private ComboBox cboGender = null!;
    private ModernTextBox txtPhone = null!;
    private ModernTextBox txtEmail = null!;
    private ModernTextBox txtAddress = null!;

    private ComboBox cboClasses = null!;
    private Label lblClassDetails = null!;
    private Label lblCapacityStatus = null!;
    private CustomButton btnConfirm = null!;
    private CustomButton btnCancel = null!;

    /// <summary>
    /// Parameterless constructor required for Visual Studio Designer support
    /// </summary>
    public StudentEnrollmentDialog() : this(null, null)
    {
    }

    public StudentEnrollmentDialog(LeadListItemDto? lead = null, IEnrollmentService? enrollmentService = null)
    {
        _lead = lead;
        _enrollmentService = enrollmentService ?? new EnrollmentService();

        InitializeComponents();
        Load += async (s, e) =>
        {
            await LoadOpenClassesAsync();
            PrefillLeadData();
        };
    }

    private void InitializeComponents()
    {
        Text = _lead != null ? $"ECMS - Chuyển đổi khách #{_lead.LeadId} & Đăng ký Lớp học" : "ECMS - Tiếp nhận Học viên mới & Đăng ký Lớp học";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(680, 680);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(16, 16),
            Size = new Size(648, 648),
            CornerRadius = 14,
            EnableShadow = true,
            Padding = new Padding(20)
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = _lead != null ? "CHUYỂN ĐỔI LEAD & ĐĂNG KÝ VÀO LỚP HỌC" : "TIẾP NHẬN HỌC VIÊN MỚI & ĐĂNG KÝ LỚP",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Khởi tạo hồ sơ học viên, cấp mã HV-yyyy-xxxx và xếp vào lớp học còn chỗ trống",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 42),
            AutoSize = true
        };

        // Section 1: Thông tin học viên
        var lblSec1 = new Label
        {
            Text = "1. THÔNG TIN HỌC VIÊN",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 75),
            AutoSize = true
        };

        int currentY = 105;
        int labelWidth = 120;
        int inputWidth = 470;
        int rowSpacing = 46;

        // Họ và tên
        var lblName = new Label
        {
            Text = "Họ và tên: *",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtFullName = new ModernTextBox
        {
            Placeholder = "Ví dụ: Nguyễn Văn An",
            Location = new Point(145, currentY),
            Size = new Size(inputWidth, 34)
        };

        // Ngày sinh & Giới tính
        currentY += rowSpacing;
        var lblDob = new Label
        {
            Text = "Ngày sinh:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        dtpDob = new DateTimePicker
        {
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "dd/MM/yyyy",
            Font = new Font("Segoe UI", 9.5f),
            Value = DateTime.Today.AddYears(-18),
            Location = new Point(145, currentY + 3),
            Size = new Size(160, 28)
        };

        var lblGender = new Label
        {
            Text = "Giới tính:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(330, currentY + 6),
            Size = new Size(70, 24)
        };
        cboGender = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(410, currentY + 3),
            Size = new Size(205, 28)
        };
        cboGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
        cboGender.SelectedIndex = 0;

        // Số điện thoại & Email
        currentY += rowSpacing;
        var lblPhone = new Label
        {
            Text = "Số điện thoại: *",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtPhone = new ModernTextBox
        {
            Placeholder = "Ví dụ: 0912345678",
            Location = new Point(145, currentY),
            Size = new Size(160, 34)
        };

        var lblEmail = new Label
        {
            Text = "Email:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(330, currentY + 6),
            Size = new Size(70, 24)
        };
        txtEmail = new ModernTextBox
        {
            Placeholder = "hocvien@gmail.com",
            Location = new Point(410, currentY),
            Size = new Size(205, 34)
        };

        // Địa chỉ
        currentY += rowSpacing;
        var lblAddress = new Label
        {
            Text = "Địa chỉ cư trú:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtAddress = new ModernTextBox
        {
            Placeholder = "Số nhà, tên đường, Quận/Huyện...",
            Location = new Point(145, currentY),
            Size = new Size(inputWidth, 34)
        };

        // Section 2: Chọn lớp học
        currentY += 52;
        var lblSec2 = new Label
        {
            Text = "2. CHỌN LỚP HỌC & KIỂM TRA SĨ SỐ",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, currentY),
            AutoSize = true
        };

        currentY += 30;
        var lblClassSelect = new Label
        {
            Text = "Lớp học mở: *",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };

        cboClasses = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(145, currentY + 3),
            Size = new Size(inputWidth, 28)
        };
        cboClasses.SelectedIndexChanged += CboClasses_SelectedIndexChanged;

        // Panel chi tiết lớp học & Sĩ số
        currentY += 42;
        var pnlClassInfo = new RoundedPanel
        {
            Location = new Point(145, currentY),
            Size = new Size(inputWidth, 120),
            CornerRadius = 8,
            BackColor = Color.FromArgb(248, 250, 252),
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1
        };

        lblClassDetails = new Label
        {
            Text = "Vui lòng chọn một lớp học ở trên để xem chi tiết giảng dạy và sĩ số.",
            Font = new Font("Segoe UI", 9f),
            ForeColor = Color.FromArgb(71, 85, 105),
            Location = new Point(12, 10),
            Size = new Size(445, 65)
        };

        lblCapacityStatus = new Label
        {
            Text = "Trạng thái chỗ trống: Chưa chọn lớp",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(12, 85),
            AutoSize = true
        };

        pnlClassInfo.Controls.Add(lblClassDetails);
        pnlClassInfo.Controls.Add(lblCapacityStatus);

        // Buttons
        currentY += 140;
        btnConfirm = new CustomButton
        {
            Text = "XÁC NHẬN ĐĂNG KÝ LỚP",
            NormalColor = Color.FromArgb(16, 185, 129), // Emerald 600
            HoverColor = Color.FromArgb(5, 150, 105),
            Location = new Point(145, currentY),
            Size = new Size(220, 42),
            CornerRadius = 8
        };
        btnConfirm.Click += async (s, e) => await ConfirmEnrollmentAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184), // Slate 400
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(380, currentY),
            Size = new Size(110, 42),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(lblSec1);
        card.Controls.Add(lblName);
        card.Controls.Add(txtFullName);
        card.Controls.Add(lblDob);
        card.Controls.Add(dtpDob);
        card.Controls.Add(lblGender);
        card.Controls.Add(cboGender);
        card.Controls.Add(lblPhone);
        card.Controls.Add(txtPhone);
        card.Controls.Add(lblEmail);
        card.Controls.Add(txtEmail);
        card.Controls.Add(lblAddress);
        card.Controls.Add(txtAddress);
        card.Controls.Add(lblSec2);
        card.Controls.Add(lblClassSelect);
        card.Controls.Add(cboClasses);
        card.Controls.Add(pnlClassInfo);
        card.Controls.Add(btnConfirm);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private void PrefillLeadData()
    {
        if (_lead == null) return;

        txtFullName.Text = _lead.FullName;
        txtPhone.Text = _lead.Phone;
        txtEmail.Text = _lead.Email ?? string.Empty;
    }

    private async Task LoadOpenClassesAsync()
    {
        try
        {
            _availableClasses = (await _enrollmentService.GetOpenClassesLookupAsync()).ToList();
            cboClasses.Items.Clear();

            if (_availableClasses.Count == 0)
            {
                cboClasses.Items.Add("Hiện không có lớp học nào đang mở tuyển sinh");
                cboClasses.SelectedIndex = 0;
                btnConfirm.Enabled = false;
                return;
            }

            foreach (var c in _availableClasses)
            {
                cboClasses.Items.Add(c.DisplayText);
            }
            cboClasses.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách lớp học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CboClasses_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboClasses.SelectedIndex < 0 || cboClasses.SelectedIndex >= _availableClasses.Count)
        {
            lblClassDetails.Text = "Chưa chọn lớp học.";
            lblCapacityStatus.Text = "Trạng thái: -";
            btnConfirm.Enabled = false;
            return;
        }

        var selectedClass = _availableClasses[cboClasses.SelectedIndex];
        lblClassDetails.Text = $"Khóa học: {selectedClass.CourseName}\n" +
                               $"Giáo viên: {selectedClass.TeacherName} | Phòng học: {selectedClass.RoomName}\n" +
                               $"Học phí chuẩn: {selectedClass.FormattedTuitionFee}";

        if (selectedClass.IsFull)
        {
            lblCapacityStatus.Text = $"⚠️ ĐÃ ĐẦY SĨ SỐ ({selectedClass.CapacityDisplay}) - KHÔNG THỂ ĐĂNG KÝ!";
            lblCapacityStatus.ForeColor = Color.FromArgb(185, 28, 28); // Red
            btnConfirm.Enabled = false;
        }
        else
        {
            int remainingSlots = selectedClass.MaxStudents - selectedClass.CurrentStudents;
            lblCapacityStatus.Text = $"✓ CÒN CHỖ TRỐNG ({selectedClass.CapacityDisplay} - Còn {remainingSlots} suất)";
            lblCapacityStatus.ForeColor = Color.FromArgb(21, 128, 61); // Green
            btnConfirm.Enabled = true;
        }
    }

    private async Task ConfirmEnrollmentAsync()
    {
        if (cboClasses.SelectedIndex < 0 || cboClasses.SelectedIndex >= _availableClasses.Count)
        {
            MessageBox.Show("Vui lòng chọn một lớp học còn chỗ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedClass = _availableClasses[cboClasses.SelectedIndex];
        if (selectedClass.IsFull)
        {
            MessageBox.Show($"Lớp học '{selectedClass.ClassName}' đã đầy sĩ số! Vui lòng chọn lớp học khác.", "Cảnh báo sĩ số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string fullName = txtFullName.Text.Trim();
        string phone = txtPhone.Text.Trim();
        string email = txtEmail.Text.Trim();
        string address = txtAddress.Text.Trim();
        string gender = cboGender.SelectedItem?.ToString() ?? "Nam";
        DateTime dob = dtpDob.Value.Date;

        var dto = new StudentEnrollmentDto
        {
            LeadId = _lead?.LeadId,
            FullName = fullName,
            DateOfBirth = dob,
            Gender = gender,
            Phone = phone,
            Email = string.IsNullOrWhiteSpace(email) ? null : email,
            Address = string.IsNullOrWhiteSpace(address) ? null : address,
            ClassId = selectedClass.ClassId
        };

        try
        {
            btnConfirm.Enabled = false;
            Cursor = Cursors.WaitCursor;

            var (success, message, studentId, studentCode, enrollmentId) = await _enrollmentService.EnrollStudentAsync(dto);
            Cursor = Cursors.Default;

            if (!success)
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConfirm.Enabled = true;
                return;
            }

            MessageBox.Show(
                $"Xếp lớp thành công!\n\n" +
                $"• Mã học viên: {studentCode}\n" +
                $"• Học viên: {fullName}\n" +
                $"• Lớp xếp vào: {selectedClass.ClassName} ({selectedClass.CourseName})\n" +
                $"• Sĩ số mới của lớp: {selectedClass.CurrentStudents + 1}/{selectedClass.MaxStudents}\n\n" +
                $"Hệ thống đã tự động chuyển thông tin sang phân hệ Thu ngân / Kế toán để đối soát học phí.",
                "Đăng Ký Xếp Lớp Thành Công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            Cursor = Cursors.Default;
            btnConfirm.Enabled = true;
            MessageBox.Show("Lỗi thực hiện đăng ký: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
