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
    private List<FeeDiscountDto> _availableDiscounts = new();

    // Controls
    private ModernTextBox txtFullName = null!;
    private DateTimePicker dtpDob = null!;
    private ComboBox cboGender = null!;
    private ModernTextBox txtPhone = null!;
    private ModernTextBox txtEmail = null!;
    private ModernTextBox txtAddress = null!;
    private Label lblOldStudentBadge = null!;

    private ComboBox cboClasses = null!;
    private Label lblClassDetails = null!;
    private Label lblCapacityStatus = null!;

    private ComboBox cboDiscounts = null!;
    private Label lblOriginalFee = null!;
    private Label lblDiscountAmount = null!;
    private Label lblFinalFee = null!;

    private CustomButton btnConfirm = null!;
    private CustomButton btnCancel = null!;

    /// <summary>
    /// Parameterless constructor required for Visual Studio / Rider Designer support
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
            await LoadDiscountsAsync();
            await PrefillLeadDataAsync();
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
        ClientSize = new Size(700, 785);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(14, 14),
            Size = new Size(672, 757),
            CornerRadius = 14,
            EnableShadow = true,
            Padding = new Padding(18)
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = _lead != null ? "CHUYỂN ĐỔI LEAD, ÁP DỤNG ƯU ĐÃI & XUẤT HÓA ĐƠN" : "TIẾP NHẬN HỌC VIÊN, ÁP DỤNG ƯU ĐÃI & XUẤT HÓA ĐƠN",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 14),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Cấp mã HV-yyyy-xxxx, xếp lớp còn chỗ, tính ưu đãi (10% HV cũ / Nhóm) và phát hành Hóa đơn Unpaid",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 40),
            AutoSize = true
        };

        // Section 1: Thông tin học viên
        var lblSec1 = new Label
        {
            Text = "1. THÔNG TIN HỌC VIÊN",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 68),
            AutoSize = true
        };

        int currentY = 95;
        int labelWidth = 120;
        int inputWidth = 490;
        int rowSpacing = 42;

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
            Size = new Size(165, 28)
        };

        var lblGender = new Label
        {
            Text = "Giới tính:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(335, currentY + 6),
            Size = new Size(70, 24)
        };
        cboGender = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(415, currentY + 3),
            Size = new Size(220, 28)
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
            Size = new Size(165, 34)
        };
        txtPhone.Leave += async (s, e) => await CheckExistingStudentAsync();

        var lblEmail = new Label
        {
            Text = "Email:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(335, currentY + 6),
            Size = new Size(70, 24)
        };
        txtEmail = new ModernTextBox
        {
            Placeholder = "hocvien@gmail.com",
            Location = new Point(415, currentY),
            Size = new Size(220, 34)
        };

        currentY += 36;
        lblOldStudentBadge = new Label
        {
            Text = "",
            Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(21, 128, 61),
            Location = new Point(145, currentY),
            AutoSize = true
        };

        // Địa chỉ
        currentY += 22;
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
        currentY += 46;
        var lblSec2 = new Label
        {
            Text = "2. CHỌN LỚP HỌC & KIỂM TRA SĨ SỐ",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, currentY),
            AutoSize = true
        };

        currentY += 26;
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
        cboClasses.SelectedIndexChanged += (s, e) => UpdateClassAndFeeSummary();

        // Panel chi tiết lớp học & Sĩ số
        currentY += 36;
        var pnlClassInfo = new RoundedPanel
        {
            Location = new Point(145, currentY),
            Size = new Size(inputWidth, 88),
            CornerRadius = 8,
            BackColor = Color.FromArgb(248, 250, 252),
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1
        };

        lblClassDetails = new Label
        {
            Text = "Vui lòng chọn một lớp học ở trên để xem chi tiết.",
            Font = new Font("Segoe UI", 9f),
            ForeColor = Color.FromArgb(71, 85, 105),
            Location = new Point(12, 8),
            Size = new Size(465, 42)
        };

        lblCapacityStatus = new Label
        {
            Text = "Trạng thái chỗ trống: Chưa chọn lớp",
            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(12, 56),
            AutoSize = true
        };

        pnlClassInfo.Controls.Add(lblClassDetails);
        pnlClassInfo.Controls.Add(lblCapacityStatus);

        // Section 3: Chính sách Ưu đãi & Tính học phí (Ngày 8)
        currentY += 102;
        var lblSec3 = new Label
        {
            Text = "3. CHÍNH SÁCH ƯU ĐÃI & TỔNG HỢP HỌC PHÍ (SINH HÓA ĐƠN TỰ ĐỘNG)",
            Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
            ForeColor = Color.FromArgb(180, 83, 9), // Amber-700
            Location = new Point(20, currentY),
            AutoSize = true
        };

        currentY += 26;
        var lblDiscountTitle = new Label
        {
            Text = "Áp dụng ưu đãi:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };

        cboDiscounts = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(145, currentY + 3),
            Size = new Size(inputWidth, 28)
        };
        cboDiscounts.SelectedIndexChanged += (s, e) => UpdateClassAndFeeSummary();

        // Panel Tổng kết tiền học phí
        currentY += 36;
        var pnlFeeSummary = new RoundedPanel
        {
            Location = new Point(145, currentY),
            Size = new Size(inputWidth, 95),
            CornerRadius = 8,
            BackColor = Color.FromArgb(255, 251, 235), // Amber-50
            BorderColor = Color.FromArgb(253, 230, 138),
            BorderWidth = 1
        };

        var lblOrigTitle = new Label { Text = "Học phí gốc của Khóa học:", Font = ThemeColors.FontBody, ForeColor = ThemeColors.TextSecondary, Location = new Point(14, 10), AutoSize = true };
        lblOriginalFee = new Label { Text = "0 VNĐ", Font = ThemeColors.FontBodyBold, ForeColor = ThemeColors.TextPrimary, Location = new Point(310, 10), Size = new Size(165, 20), TextAlign = ContentAlignment.MiddleRight };

        var lblDiscTitle = new Label { Text = "Giảm giá theo chính sách ưu đãi:", Font = ThemeColors.FontBody, ForeColor = Color.FromArgb(21, 128, 61), Location = new Point(14, 34), AutoSize = true };
        lblDiscountAmount = new Label { Text = "-0 VNĐ", Font = ThemeColors.FontBodyBold, ForeColor = Color.FromArgb(21, 128, 61), Location = new Point(310, 34), Size = new Size(165, 20), TextAlign = ContentAlignment.MiddleRight };

        var lblFinalTitle = new Label { Text = "TỔNG TIỀN CẦN THANH TOÁN:", Font = new Font("Segoe UI", 10f, FontStyle.Bold), ForeColor = Color.FromArgb(185, 28, 28), Location = new Point(14, 62), AutoSize = true };
        lblFinalFee = new Label { Text = "0 VNĐ", Font = new Font("Segoe UI", 12.5f, FontStyle.Bold), ForeColor = Color.FromArgb(185, 28, 28), Location = new Point(275, 58), Size = new Size(200, 26), TextAlign = ContentAlignment.MiddleRight };

        pnlFeeSummary.Controls.Add(lblOrigTitle);
        pnlFeeSummary.Controls.Add(lblOriginalFee);
        pnlFeeSummary.Controls.Add(lblDiscTitle);
        pnlFeeSummary.Controls.Add(lblDiscountAmount);
        pnlFeeSummary.Controls.Add(lblFinalTitle);
        pnlFeeSummary.Controls.Add(lblFinalFee);

        // Buttons
        currentY += 110;
        btnConfirm = new CustomButton
        {
            Text = "XÁC NHẬN XẾP LỚP & XUẤT HÓA ĐƠN",
            NormalColor = Color.FromArgb(16, 185, 129), // Emerald 600
            HoverColor = Color.FromArgb(5, 150, 105),
            Location = new Point(145, currentY),
            Size = new Size(280, 42),
            CornerRadius = 8
        };
        btnConfirm.Click += async (s, e) => await ConfirmEnrollmentAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184), // Slate 400
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(440, currentY),
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
        card.Controls.Add(lblOldStudentBadge);
        card.Controls.Add(lblAddress);
        card.Controls.Add(txtAddress);
        card.Controls.Add(lblSec2);
        card.Controls.Add(lblClassSelect);
        card.Controls.Add(cboClasses);
        card.Controls.Add(pnlClassInfo);
        card.Controls.Add(lblSec3);
        card.Controls.Add(lblDiscountTitle);
        card.Controls.Add(cboDiscounts);
        card.Controls.Add(pnlFeeSummary);
        card.Controls.Add(btnConfirm);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private async Task PrefillLeadDataAsync()
    {
        if (_lead == null) return;

        txtFullName.Text = _lead.FullName;
        txtPhone.Text = _lead.Phone;
        txtEmail.Text = _lead.Email ?? string.Empty;
        await CheckExistingStudentAsync();
    }

    private async Task CheckExistingStudentAsync()
    {
        string phone = txtPhone.Text.Trim();
        if (string.IsNullOrWhiteSpace(phone))
        {
            lblOldStudentBadge.Text = "";
            return;
        }

        try
        {
            bool isOldStudent = await _enrollmentService.IsExistingStudentByPhoneAsync(phone);
            if (isOldStudent)
            {
                lblOldStudentBadge.Text = "✓ Nhận diện: HỌC VIÊN CŨ của trung tâm (Tự động chọn ưu đãi Giảm 10%)";
                // Auto-select 10% old student discount if available
                for (int i = 0; i < _availableDiscounts.Count; i++)
                {
                    if (_availableDiscounts[i].Percentage == 10 || _availableDiscounts[i].DiscountName.Contains("cũ", StringComparison.OrdinalIgnoreCase))
                    {
                        cboDiscounts.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                lblOldStudentBadge.Text = "ℹ Học viên mới lần đầu đăng ký tại ECMS";
                lblOldStudentBadge.ForeColor = ThemeColors.InfoText;
            }
        }
        catch
        {
            // Ignore non-critical check
        }
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

    private async Task LoadDiscountsAsync()
    {
        try
        {
            var dbDiscounts = (await _enrollmentService.GetActiveDiscountsAsync()).ToList();
            _availableDiscounts = new List<FeeDiscountDto>
            {
                new FeeDiscountDto { DiscountId = 0, DiscountName = "Không áp dụng ưu đãi (0%)" }
            };
            _availableDiscounts.AddRange(dbDiscounts);

            cboDiscounts.Items.Clear();
            foreach (var d in _availableDiscounts)
            {
                cboDiscounts.Items.Add(d.DisplayText);
            }
            cboDiscounts.SelectedIndex = 0;
            UpdateClassAndFeeSummary();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh mục ưu đãi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void UpdateClassAndFeeSummary()
    {
        if (cboClasses.SelectedIndex < 0 || cboClasses.SelectedIndex >= _availableClasses.Count)
        {
            lblClassDetails.Text = "Chưa chọn lớp học.";
            lblCapacityStatus.Text = "Trạng thái: -";
            btnConfirm.Enabled = false;
            return;
        }

        var selectedClass = _availableClasses[cboClasses.SelectedIndex];
        lblClassDetails.Text = $"Khóa học: {selectedClass.CourseName}  |  Phòng học: {selectedClass.RoomName}\n" +
                               $"Giáo viên phụ trách: {selectedClass.TeacherName}";

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

        // Calculate tuition fee & discount
        decimal originalAmount = selectedClass.TuitionFee;
        decimal discountAmount = 0;

        if (cboDiscounts.SelectedIndex >= 0 && cboDiscounts.SelectedIndex < _availableDiscounts.Count)
        {
            var selectedDiscount = _availableDiscounts[cboDiscounts.SelectedIndex];
            discountAmount = selectedDiscount.CalculateDiscount(originalAmount);
        }

        decimal finalAmount = Math.Max(0, originalAmount - discountAmount);

        lblOriginalFee.Text = $"{originalAmount:N0} VNĐ";
        lblDiscountAmount.Text = discountAmount > 0 ? $"-{discountAmount:N0} VNĐ" : "0 VNĐ";
        lblFinalFee.Text = $"{finalAmount:N0} VNĐ";
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

        int? discountId = null;
        if (cboDiscounts.SelectedIndex > 0 && cboDiscounts.SelectedIndex < _availableDiscounts.Count)
        {
            discountId = _availableDiscounts[cboDiscounts.SelectedIndex].DiscountId;
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
            ClassId = selectedClass.ClassId,
            DiscountId = discountId
        };

        try
        {
            btnConfirm.Enabled = false;
            Cursor = Cursors.WaitCursor;

            var (success, message, studentId, studentCode, enrollmentId, invoiceCode, finalAmount) =
                await _enrollmentService.EnrollStudentAsync(dto);

            Cursor = Cursors.Default;

            if (!success)
            {
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConfirm.Enabled = true;
                return;
            }

            MessageBox.Show(
                $"Đăng ký lớp & Phát hành hóa đơn thành công!\n\n" +
                $"• Mã học viên: {studentCode}\n" +
                $"• Học viên: {fullName}\n" +
                $"• Lớp xếp vào: {selectedClass.ClassName} ({selectedClass.CourseName})\n" +
                $"• Mã Hóa Đơn (Invoices): {invoiceCode}\n" +
                $"• Số tiền phải thanh toán: {finalAmount:N0} VNĐ (Chờ thu tiền)\n\n" +
                $"👉 Hóa đơn đã được đẩy sang màn hình Kế toán / Thu ngân để thu học phí & in biên lai.",
                "Thành Công",
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
