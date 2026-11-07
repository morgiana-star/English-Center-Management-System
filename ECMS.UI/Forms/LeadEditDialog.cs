using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class LeadEditDialog : Form
{
    private readonly ILeadService _leadService;
    private readonly int _leadId;
    private LeadCreateOrUpdateDto? _leadData;

    private ModernTextBox txtFullName = null!;
    private ModernTextBox txtPhone = null!;
    private ModernTextBox txtEmail = null!;
    private ComboBox cboSource = null!;
    private ComboBox cboStatus = null!;
    private TextBox txtNotes = null!;

    private CustomButton btnSave = null!;
    private CustomButton btnCancel = null!;

    public LeadEditDialog(int leadId = 0, ILeadService? leadService = null)
    {
        _leadId = leadId;
        _leadService = leadService ?? new LeadService();

        InitializeComponents();
        Load += async (s, e) => await LoadDataAsync();
    }

    private void InitializeComponents()
    {
        Text = _leadId == 0 ? "Tiếp nhận khách hàng tiềm năng mới (Lead)" : $"Chỉnh sửa thông tin khách hàng #{_leadId}";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        ClientSize = new Size(580, 560);
        BackColor = ThemeColors.AppBackground;

        var card = new GlassCard
        {
            Location = new Point(16, 16),
            Size = new Size(548, 528),
            CornerRadius = 14,
            EnableShadow = true,
            Padding = new Padding(20)
        };

        // Header Title
        var lblTitle = new Label
        {
            Text = _leadId == 0 ? "TIẾP NHẬN KHÁCH HÀNG TIỀM NĂNG MỚI" : $"CẬP NHẬT KHÁCH HÀNG #{_leadId}",
            Font = ThemeColors.FontSubHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Ghi nhận thông tin liên hệ, kênh tuyển sinh và nguyện vọng học tập của khách",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(20, 42),
            AutoSize = true
        };

        int currentY = 75;
        int labelWidth = 140;
        int inputWidth = 350;
        int rowSpacing = 48;

        // 1. Họ và tên
        var lblName = new Label
        {
            Text = "Họ và tên khách: *",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtFullName = new ModernTextBox
        {
            Placeholder = "Ví dụ: Nguyễn Thị Thu Hà",
            Location = new Point(165, currentY),
            Size = new Size(inputWidth, 34)
        };

        // 2. Số điện thoại
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
            Placeholder = "Ví dụ: 0905123456",
            Location = new Point(165, currentY),
            Size = new Size(inputWidth, 34)
        };

        // 3. Email
        currentY += rowSpacing;
        var lblEmail = new Label
        {
            Text = "Email liên hệ:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtEmail = new ModernTextBox
        {
            Placeholder = "Ví dụ: thuha@gmail.com",
            Location = new Point(165, currentY),
            Size = new Size(inputWidth, 34)
        };

        // 4. Kênh tiếp nhận (Source)
        currentY += rowSpacing;
        var lblSource = new Label
        {
            Text = "Kênh tiếp nhận:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        cboSource = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(165, currentY + 3),
            Size = new Size(inputWidth, 28)
        };
        cboSource.Items.AddRange(new object[]
        {
            "Trực tiếp tại quầy",
            "Facebook Fanpage",
            "Website đăng ký",
            "Hotline tư vấn",
            "Bạn bè giới thiệu",
            "Khác"
        });
        cboSource.SelectedIndex = 0;

        // 5. Trạng thái (Status)
        currentY += rowSpacing;
        var lblStatus = new Label
        {
            Text = "Trạng thái chăm sóc:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        cboStatus = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(165, currentY + 3),
            Size = new Size(inputWidth, 28)
        };
        cboStatus.Items.AddRange(new object[]
        {
            "New - Mới tiếp nhận",
            "Contacted - Đang tư vấn",
            "TestScheduled - Đã hẹn làm bài Test",
            "Converted - Đã chốt nhập học",
            "Lost - Không có nhu cầu / Hủy"
        });
        cboStatus.SelectedIndex = 0;

        // 6. Nhu cầu / Ghi chú
        currentY += rowSpacing;
        var lblNotes = new Label
        {
            Text = "Nguyện vọng / Ghi chú:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(20, currentY + 6),
            Size = new Size(labelWidth, 24)
        };
        txtNotes = new TextBox
        {
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(165, currentY + 3),
            Size = new Size(inputWidth, 90)
        };

        // Buttons
        currentY += 105;
        btnSave = new CustomButton
        {
            Text = _leadId == 0 ? "TIẾP NHẬN LEAD" : "LƯU THAY ĐỔI",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(165, currentY),
            Size = new Size(160, 40),
            CornerRadius = 8
        };
        btnSave.Click += async (s, e) => await SaveLeadAsync();

        btnCancel = new CustomButton
        {
            Text = "HỦY BỎ",
            NormalColor = Color.FromArgb(148, 163, 184), // Slate-400
            HoverColor = Color.FromArgb(100, 116, 139),
            Location = new Point(340, currentY),
            Size = new Size(110, 40),
            CornerRadius = 8
        };
        btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblSubtitle);
        card.Controls.Add(lblName);
        card.Controls.Add(txtFullName);
        card.Controls.Add(lblPhone);
        card.Controls.Add(txtPhone);
        card.Controls.Add(lblEmail);
        card.Controls.Add(txtEmail);
        card.Controls.Add(lblSource);
        card.Controls.Add(cboSource);
        card.Controls.Add(lblStatus);
        card.Controls.Add(cboStatus);
        card.Controls.Add(lblNotes);
        card.Controls.Add(txtNotes);
        card.Controls.Add(btnSave);
        card.Controls.Add(btnCancel);

        Controls.Add(card);
    }

    private async Task LoadDataAsync()
    {
        if (_leadId <= 0) return;

        try
        {
            _leadData = await _leadService.GetLeadByIdAsync(_leadId);
            if (_leadData != null)
            {
                txtFullName.Text = _leadData.FullName;
                txtPhone.Text = _leadData.Phone;
                txtEmail.Text = _leadData.Email ?? string.Empty;
                txtNotes.Text = _leadData.Notes ?? string.Empty;

                for (int i = 0; i < cboSource.Items.Count; i++)
                {
                    if (string.Equals(cboSource.Items[i]?.ToString(), _leadData.Source, StringComparison.OrdinalIgnoreCase))
                    {
                        cboSource.SelectedIndex = i;
                        break;
                    }
                }

                cboStatus.SelectedIndex = _leadData.Status switch
                {
                    "Contacted" => 1,
                    "TestScheduled" => 2,
                    "Converted" => 3,
                    "Lost" => 4,
                    _ => 0
                };
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi nạp dữ liệu khách hàng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task SaveLeadAsync()
    {
        string fullName = txtFullName.Text.Trim();
        string phone = txtPhone.Text.Trim();
        string email = txtEmail.Text.Trim();
        string source = cboSource.SelectedItem?.ToString() ?? "Trực tiếp tại quầy";
        string notes = txtNotes.Text.Trim();

        string status = cboStatus.SelectedIndex switch
        {
            1 => "Contacted",
            2 => "TestScheduled",
            3 => "Converted",
            4 => "Lost",
            _ => "New"
        };

        var dto = new LeadCreateOrUpdateDto
        {
            LeadId = _leadId,
            FullName = fullName,
            Phone = phone,
            Email = string.IsNullOrWhiteSpace(email) ? null : email,
            Source = source,
            Status = status,
            Notes = string.IsNullOrWhiteSpace(notes) ? null : notes
        };

        try
        {
            btnSave.Enabled = false;

            if (_leadId == 0)
            {
                var (success, message, newId) = await _leadService.CreateLeadAsync(dto);
                if (!success)
                {
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var (success, message) = await _leadService.UpdateLeadAsync(dto);
                if (!success)
                {
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thao tác: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSave.Enabled = true;
        }
    }
}
