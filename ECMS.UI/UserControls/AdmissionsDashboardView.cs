using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

public class AdmissionsDashboardView : UserControl
{
    private readonly ILeadService _leadService;

    // Stat Labels
    private Label lblTotalLeads = null!;
    private Label lblNewLeads = null!;
    private Label lblContactedLeads = null!;
    private Label lblConvertedLeads = null!;

    // Search & Filter controls
    private ModernTextBox txtSearch = null!;
    private ComboBox cboStatusFilter = null!;
    private ComboBox cboSourceFilter = null!;
    private CustomButton btnSearch = null!;
    private CustomButton btnRefresh = null!;
    private CustomButton btnAddLead = null!;
    private CustomButton btnEditLead = null!;
    private CustomButton btnChangeStatus = null!;

    // Grid & Preview
    private DataGridView dgvLeads = null!;
    private Label lblPreviewTitle = null!;
    private TextBox txtPreviewNotes = null!;

    public AdmissionsDashboardView(ILeadService? leadService = null)
    {
        _leadService = leadService ?? new LeadService();
        InitializeComponents();
        Load += async (s, e) =>
        {
            await LoadSourcesFilterAsync();
            await LoadSummaryAsync();
            await LoadLeadsAsync();
        };
    }

    private void InitializeComponents()
    {
        Dock = DockStyle.Fill;
        BackColor = ThemeColors.AppBackground;
        AutoScroll = true;

        // 1. Header Title
        var lblTitle = new Label
        {
            Text = "CỔNG TƯ VẤN TUYỂN SINH (ADMISSIONS & COUNSELOR PORTAL)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(25, 20),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Tiếp nhận khách hàng tiềm năng, chăm sóc tư vấn, phân loại trạng thái và chuyển đổi nhập học",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(25, 52),
            AutoSize = true
        };

        // 2. 4 Stat KPI Cards
        var cardTotal = CreateStatCard("TỔNG KHÁCH TIỀM NĂNG", "Đang tải...", ThemeColors.InfoBg, ThemeColors.InfoText, new Point(25, 85), out lblTotalLeads);
        var cardNew = CreateStatCard("MỚI TIẾP NHẬN", "Đang tải...", Color.FromArgb(224, 242, 254), Color.FromArgb(3, 105, 161), new Point(295, 85), out lblNewLeads);
        var cardContacted = CreateStatCard("ĐANG TƯ VẤN / HẸN TEST", "Đang tải...", ThemeColors.WarningBg, ThemeColors.WarningText, new Point(565, 85), out lblContactedLeads);
        var cardConverted = CreateStatCard("ĐÃ CHỐT NHẬP HỌC", "Đang tải...", ThemeColors.SuccessBg, ThemeColors.SuccessText, new Point(835, 85), out lblConvertedLeads);

        // 3. Search & Action Toolbar (GlassCard)
        var cardToolbar = new GlassCard
        {
            Location = new Point(25, 225),
            Size = new Size(1060, 68),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(10)
        };

        txtSearch = new ModernTextBox
        {
            Placeholder = "Tìm theo tên, SĐT, email, ghi chú...",
            Location = new Point(12, 14),
            Size = new Size(210, 38),
            CornerRadius = 6
        };
        txtSearch.KeyDown += async (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await LoadLeadsAsync();
            }
        };

        cboStatusFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(230, 18),
            Size = new Size(150, 32)
        };
        cboStatusFilter.Items.AddRange(new object[]
        {
            "Tất cả trạng thái",
            "Mới tiếp nhận (New)",
            "Đang tư vấn (Contacted)",
            "Đã hẹn Test (TestScheduled)",
            "Đã chốt nhập học (Converted)",
            "Không có nhu cầu (Lost)"
        });
        cboStatusFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndexChanged += async (s, e) => await LoadLeadsAsync();

        cboSourceFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            BackColor = Color.White,
            Location = new Point(388, 18),
            Size = new Size(130, 32)
        };
        cboSourceFilter.Items.Add("Tất cả nguồn");
        cboSourceFilter.SelectedIndex = 0;
        cboSourceFilter.SelectedIndexChanged += async (s, e) => await LoadLeadsAsync();

        btnSearch = new CustomButton
        {
            Text = "TÌM",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(526, 14),
            Size = new Size(55, 38),
            CornerRadius = 6
        };
        btnSearch.Click += async (s, e) => await LoadLeadsAsync();

        btnRefresh = new CustomButton
        {
            Text = "LÀM MỚI",
            NormalColor = Color.FromArgb(100, 116, 139), // Slate 500
            HoverColor = Color.FromArgb(71, 85, 105),
            Location = new Point(589, 14),
            Size = new Size(80, 38),
            CornerRadius = 6
        };
        btnRefresh.Click += async (s, e) =>
        {
            txtSearch.Text = string.Empty;
            cboStatusFilter.SelectedIndex = 0;
            cboSourceFilter.SelectedIndex = 0;
            await LoadSummaryAsync();
            await LoadLeadsAsync();
        };

        btnAddLead = new CustomButton
        {
            Text = "+ THÊM KHÁCH",
            NormalColor = ThemeColors.SuccessText,
            HoverColor = Color.FromArgb(16, 185, 129),
            Location = new Point(677, 14),
            Size = new Size(115, 38),
            CornerRadius = 6
        };
        btnAddLead.Click += async (s, e) => await OpenCreateLeadDialogAsync();

        btnEditLead = new CustomButton
        {
            Text = "SỬA",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(800, 14),
            Size = new Size(65, 38),
            CornerRadius = 6
        };
        btnEditLead.Click += async (s, e) => await OpenEditLeadDialogAsync();

        btnChangeStatus = new CustomButton
        {
            Text = "ĐỔI TRẠNG THÁI",
            NormalColor = Color.FromArgb(126, 34, 206), // Purple 700
            HoverColor = Color.FromArgb(107, 33, 168),
            Location = new Point(873, 14),
            Size = new Size(125, 38),
            CornerRadius = 6
        };
        btnChangeStatus.Click += async (s, e) => await QuickChangeStatusAsync();

        cardToolbar.Controls.Add(txtSearch);
        cardToolbar.Controls.Add(cboStatusFilter);
        cardToolbar.Controls.Add(cboSourceFilter);
        cardToolbar.Controls.Add(btnSearch);
        cardToolbar.Controls.Add(btnRefresh);
        cardToolbar.Controls.Add(btnAddLead);
        cardToolbar.Controls.Add(btnEditLead);
        cardToolbar.Controls.Add(btnChangeStatus);

        // 4. DataGridView Setup
        dgvLeads = new DataGridView
        {
            Location = new Point(25, 305),
            Size = new Size(1060, 310),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvLeads);
        ConfigureGridColumns();

        dgvLeads.DoubleClick += async (s, e) => await OpenEditLeadDialogAsync();
        dgvLeads.SelectionChanged += DgvLeads_SelectionChanged;
        dgvLeads.CellFormatting += DgvLeads_CellFormatting;

        // 5. Bottom Detail Preview (GlassCard)
        var cardPreview = new GlassCard
        {
            Location = new Point(25, 625),
            Size = new Size(1060, 95),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(12)
        };

        lblPreviewTitle = new Label
        {
            Text = "GHI CHÚ NGUYỆN VỌNG & LỘ TRÌNH TƯ VẤN (Chọn một khách hàng trên danh sách để xem chi tiết)",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.Primary,
            Location = new Point(14, 8),
            AutoSize = true
        };

        txtPreviewNotes = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = Color.FromArgb(30, 41, 59),
            BackColor = Color.FromArgb(248, 250, 252),
            Location = new Point(14, 28),
            Size = new Size(1030, 55),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };

        cardPreview.Controls.Add(lblPreviewTitle);
        cardPreview.Controls.Add(txtPreviewNotes);

        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(cardTotal);
        Controls.Add(cardNew);
        Controls.Add(cardContacted);
        Controls.Add(cardConverted);
        Controls.Add(cardToolbar);
        Controls.Add(dgvLeads);
        Controls.Add(cardPreview);
    }

    private GlassCard CreateStatCard(string title, string initialValue, Color bg, Color textColor, Point location, out Label valueLabel)
    {
        var card = new GlassCard
        {
            Location = location,
            Size = new Size(250, 125),
            GlassColor = bg,
            BorderGlowColor = ThemeColors.GlassBorder,
            BorderGlowWidth = 1,
            EnableShadow = true
        };

        var lblT = new Label
        {
            Text = title,
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(16, 15),
            AutoSize = true
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            ForeColor = textColor,
            Location = new Point(16, 45),
            Size = new Size(220, 45),
            TextAlign = ContentAlignment.MiddleLeft
        };

        card.Controls.Add(lblT);
        card.Controls.Add(valueLabel);
        return card;
    }

    private void ConfigureGridColumns()
    {
        dgvLeads.Columns.Clear();

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColLeadId",
            HeaderText = "MÃ LEAD",
            DataPropertyName = "LeadId",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColFullName",
            HeaderText = "HỌ VÀ TÊN KHÁCH HÀNG",
            DataPropertyName = "FullName",
            Width = 180
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColPhone",
            HeaderText = "SỐ ĐIỆN THOẠI",
            DataPropertyName = "Phone",
            Width = 125,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColEmail",
            HeaderText = "EMAIL",
            DataPropertyName = "Email",
            Width = 175
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColSource",
            HeaderText = "KÊNH TIẾP NHẬN",
            DataPropertyName = "Source",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColStatus",
            HeaderText = "TRẠNG THÁI",
            DataPropertyName = "StatusText",
            Width = 150,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColCreatedAt",
            HeaderText = "NGÀY TIẾP NHẬN",
            DataPropertyName = "FormattedCreatedAt",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLeads.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColNotes",
            HeaderText = "NGUYỆN VỌNG / GHI CHÚ",
            DataPropertyName = "Notes",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
    }

    private async Task LoadSourcesFilterAsync()
    {
        try
        {
            var sources = (await _leadService.GetDistinctSourcesAsync()).ToList();
            cboSourceFilter.Items.Clear();
            cboSourceFilter.Items.Add("Tất cả nguồn");
            foreach (var s in sources)
            {
                cboSourceFilter.Items.Add(s);
            }
            cboSourceFilter.SelectedIndex = 0;
        }
        catch
        {
            // Ignore minor filter error
        }
    }

    private async Task LoadSummaryAsync()
    {
        try
        {
            var summary = await _leadService.GetSummaryAsync();
            lblTotalLeads.Text = $"{summary.TotalLeads:N0} Khách";
            lblNewLeads.Text = $"{summary.NewLeads:N0} Mới";
            lblContactedLeads.Text = $"{summary.ContactedLeads + summary.TestScheduledLeads:N0} Đang chăm sóc";
            lblConvertedLeads.Text = $"{summary.ConvertedLeads:N0} Đã chốt";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải số liệu tóm tắt: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private LeadFilterDto BuildFilter()
    {
        var filter = new LeadFilterDto
        {
            Keyword = txtSearch.Text.Trim(),
            Limit = 1000,
            Offset = 0
        };

        filter.Status = cboStatusFilter.SelectedIndex switch
        {
            1 => "New",
            2 => "Contacted",
            3 => "TestScheduled",
            4 => "Converted",
            5 => "Lost",
            _ => "ALL"
        };

        if (cboSourceFilter.SelectedIndex > 0)
        {
            filter.Source = cboSourceFilter.SelectedItem?.ToString();
        }

        return filter;
    }

    private async Task LoadLeadsAsync()
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            var filter = BuildFilter();
            var leads = (await _leadService.GetLeadsAsync(filter)).ToList();
            dgvLeads.DataSource = leads;

            if (leads.Count == 0)
            {
                txtPreviewNotes.Text = "Không có khách hàng nào phù hợp với bộ lọc hiện tại.";
                lblPreviewTitle.Text = "DANH SÁCH RỖNG";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private void DgvLeads_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvLeads.CurrentRow?.DataBoundItem is LeadListItemDto lead)
        {
            lblPreviewTitle.Text = $"GHI CHÚ TƯ VẤN - KHÁCH #{lead.LeadId}: {lead.FullName} - SĐT: {lead.Phone} - Nguồn: {lead.Source} - Trạng thái: {lead.StatusText}";
            txtPreviewNotes.Text = string.IsNullOrWhiteSpace(lead.Notes) ? "(Chưa có ghi chú nguyện vọng cụ thể)" : lead.Notes;
        }
    }

    private void DgvLeads_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvLeads.Rows.Count) return;

        if (dgvLeads.Columns[e.ColumnIndex].Name == "ColStatus" && e.Value != null)
        {
            string status = e.Value.ToString() ?? "";
            e.CellStyle!.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);

            if (status == "Mới tiếp nhận")
            {
                e.CellStyle.BackColor = Color.FromArgb(224, 242, 254);
                e.CellStyle.ForeColor = Color.FromArgb(3, 105, 161);
            }
            else if (status == "Đang tư vấn")
            {
                e.CellStyle.BackColor = Color.FromArgb(243, 232, 255);
                e.CellStyle.ForeColor = Color.FromArgb(126, 34, 206);
            }
            else if (status == "Đã hẹn Test")
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);
                e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
            }
            else if (status == "Đã chốt nhập học")
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                e.CellStyle.ForeColor = Color.FromArgb(21, 128, 61);
            }
            else if (status == "Không có nhu cầu")
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(241, 245, 249);
                e.CellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            }
        }
    }

    private async Task OpenCreateLeadDialogAsync()
    {
        using var dialog = new LeadEditDialog(0, _leadService);
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            await LoadSummaryAsync();
            await LoadLeadsAsync();
        }
    }

    private async Task OpenEditLeadDialogAsync()
    {
        if (dgvLeads.CurrentRow?.DataBoundItem is LeadListItemDto selectedLead)
        {
            using var dialog = new LeadEditDialog(selectedLead.LeadId, _leadService);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                await LoadSummaryAsync();
                await LoadLeadsAsync();
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một khách hàng trên danh sách để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async Task QuickChangeStatusAsync()
    {
        if (dgvLeads.CurrentRow?.DataBoundItem is not LeadListItemDto selectedLead)
        {
            MessageBox.Show("Vui lòng chọn một khách hàng trên danh sách để chuyển trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Context menu to quickly select new status
        var menu = new ContextMenuStrip();
        var statuses = new[]
        {
            ("New", "Mới tiếp nhận"),
            ("Contacted", "Đang tư vấn"),
            ("TestScheduled", "Đã hẹn Test"),
            ("Converted", "Đã chốt nhập học"),
            ("Lost", "Không có nhu cầu")
        };

        foreach (var (code, title) in statuses)
        {
            string statusCode = code;
            var item = new ToolStripMenuItem(title)
            {
                Checked = selectedLead.Status == statusCode
            };
            item.Click += async (s, e) =>
            {
                var (success, msg) = await _leadService.UpdateLeadStatusAsync(selectedLead.LeadId, statusCode);
                if (success)
                {
                    await LoadSummaryAsync();
                    await LoadLeadsAsync();
                }
                else
                {
                    MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            menu.Items.Add(item);
        }

        menu.Show(btnChangeStatus, new Point(0, btnChangeStatus.Height));
    }
}
