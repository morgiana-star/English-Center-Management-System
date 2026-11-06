using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public class AuditLogViewerDialog : Form
{
    private readonly IAuditLogService _auditLogService;

    // Controls
    private Label lblTotalCount = null!;
    private Label lblTodayCount = null!;
    private Label lblUserCount = null!;
    private Label lblSecurityCount = null!;

    private DateTimePicker dtpFromDate = null!;
    private DateTimePicker dtpToDate = null!;
    private CheckBox chkEnableDateFilter = null!;
    private ComboBox cboActionFilter = null!;
    private ComboBox cboTableFilter = null!;
    private ModernTextBox txtSearch = null!;
    private CustomButton btnSearch = null!;
    private CustomButton btnReset = null!;
    private CustomButton btnExportExcel = null!;

    private DataGridView dgvLogs = null!;
    private Label lblSelectedLogTitle = null!;
    private TextBox txtOldValues = null!;
    private TextBox txtNewValues = null!;

    public AuditLogViewerDialog(IAuditLogService? auditLogService = null)
    {
        _auditLogService = auditLogService ?? new AuditLogService();
        InitializeComponents();
        Load += async (s, e) =>
        {
            await LoadFilterCombosAsync();
            await LoadSummaryAsync();
            await LoadLogsAsync();
        };
    }

    private void InitializeComponents()
    {
        Text = "ECMS - Nhật ký kiểm toán hệ thống (Audit Trail - Strictly Append Only)";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.Sizable;
        MinimumSize = new Size(1100, 700);
        ClientSize = new Size(1200, 760);
        BackColor = ThemeColors.AppBackground;

        // Container Panel with Dock = Fill
        var mainContainer = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(16),
            BackColor = ThemeColors.AppBackground
        };

        // 1. Header Card (KPIs + Title)
        var cardHeader = new GlassCard
        {
            Location = new Point(16, 16),
            Size = new Size(1168, 120),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 14,
            EnableShadow = true
        };

        var lblTitle = new Label
        {
            Text = "NHẬT KÝ KIỂM TOÁN HỆ THỐNG (AUDIT LOGS - APPEND ONLY)",
            Font = ThemeColors.FontHeader,
            ForeColor = ThemeColors.Primary,
            Location = new Point(18, 14),
            AutoSize = true
        };

        var lblSubtitle = new Label
        {
            Text = "Ghi vết bất biến toàn bộ hoạt động nhạy cảm: Đăng nhập, Tài khoản, Bảo mật Brute-force, Phân quyền RBAC",
            Font = ThemeColors.FontBody,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(18, 40),
            AutoSize = true
        };

        // 4 KPI Badges in Header Card
        int badgeY = 66;
        int badgeWidth = 270;
        int badgeSpacing = 16;
        int badgeX = 18;

        var pnlTotal = CreateKpiBox("TỔNG SỐ BẢN GHI", "Đang tải...", Color.FromArgb(239, 246, 255), Color.FromArgb(29, 78, 216), new Point(badgeX, badgeY), badgeWidth, out lblTotalCount);
        badgeX += badgeWidth + badgeSpacing;

        var pnlToday = CreateKpiBox("GHI NHẬN HÔM NAY", "Đang tải...", Color.FromArgb(240, 253, 244), Color.FromArgb(21, 128, 61), new Point(badgeX, badgeY), badgeWidth, out lblTodayCount);
        badgeX += badgeWidth + badgeSpacing;

        var pnlUsers = CreateKpiBox("TÀI KHOẢN TÁC ĐỘNG", "Đang tải...", Color.FromArgb(245, 243, 255), Color.FromArgb(109, 40, 217), new Point(badgeX, badgeY), badgeWidth, out lblUserCount);
        badgeX += badgeWidth + badgeSpacing;

        var pnlSecurity = CreateKpiBox("SỰ KIỆN BẢO MẬT", "Đang tải...", Color.FromArgb(254, 242, 242), Color.FromArgb(185, 28, 28), new Point(badgeX, badgeY), badgeWidth, out lblSecurityCount);

        cardHeader.Controls.Add(lblTitle);
        cardHeader.Controls.Add(lblSubtitle);
        cardHeader.Controls.Add(pnlTotal);
        cardHeader.Controls.Add(pnlToday);
        cardHeader.Controls.Add(pnlUsers);
        cardHeader.Controls.Add(pnlSecurity);

        // 2. Filter Toolbar Card
        var cardFilter = new GlassCard
        {
            Location = new Point(16, 146),
            Size = new Size(1168, 65),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(10)
        };

        chkEnableDateFilter = new CheckBox
        {
            Text = "Lọc ngày:",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(15, 22),
            AutoSize = true,
            Checked = false
        };
        chkEnableDateFilter.CheckedChanged += (s, e) =>
        {
            dtpFromDate.Enabled = chkEnableDateFilter.Checked;
            dtpToDate.Enabled = chkEnableDateFilter.Checked;
        };

        dtpFromDate = new DateTimePicker
        {
            Format = DateTimePickerFormat.Short,
            Font = new Font("Segoe UI", 9.5f),
            Location = new Point(100, 19),
            Size = new Size(105, 26),
            Value = DateTime.Today.AddDays(-7),
            Enabled = false
        };

        var lblTo = new Label
        {
            Text = "đến",
            Font = ThemeColors.FontCaption,
            ForeColor = ThemeColors.TextSecondary,
            Location = new Point(210, 22),
            AutoSize = true
        };

        dtpToDate = new DateTimePicker
        {
            Format = DateTimePickerFormat.Short,
            Font = new Font("Segoe UI", 9.5f),
            Location = new Point(240, 19),
            Size = new Size(105, 26),
            Value = DateTime.Today,
            Enabled = false
        };

        cboActionFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(360, 19),
            Size = new Size(150, 26)
        };

        cboTableFilter = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = ThemeColors.TextPrimary,
            Location = new Point(520, 19),
            Size = new Size(130, 26)
        };

        txtSearch = new ModernTextBox
        {
            Placeholder = "Từ khóa: Tên, Username, ID, Giá trị...",
            Location = new Point(660, 16),
            Size = new Size(200, 34)
        };
        txtSearch.KeyDown += async (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await LoadLogsAsync();
            }
        };

        btnSearch = new CustomButton
        {
            Text = "TÌM KIẾM",
            NormalColor = ThemeColors.Primary,
            HoverColor = ThemeColors.PrimaryHover,
            Location = new Point(870, 15),
            Size = new Size(90, 36),
            CornerRadius = 6
        };
        btnSearch.Click += async (s, e) => await LoadLogsAsync();

        btnReset = new CustomButton
        {
            Text = "LÀM MỚI",
            NormalColor = Color.FromArgb(100, 116, 139), // Slate 500
            HoverColor = Color.FromArgb(71, 85, 105),
            Location = new Point(965, 15),
            Size = new Size(85, 36),
            CornerRadius = 6
        };
        btnReset.Click += async (s, e) =>
        {
            chkEnableDateFilter.Checked = false;
            if (cboActionFilter.Items.Count > 0) cboActionFilter.SelectedIndex = 0;
            if (cboTableFilter.Items.Count > 0) cboTableFilter.SelectedIndex = 0;
            txtSearch.Text = string.Empty;
            await LoadSummaryAsync();
            await LoadLogsAsync();
        };

        btnExportExcel = new CustomButton
        {
            Text = "XUẤT EXCEL",
            NormalColor = Color.FromArgb(16, 185, 129), // Emerald 600
            HoverColor = Color.FromArgb(5, 150, 105),
            Location = new Point(1055, 15),
            Size = new Size(100, 36),
            CornerRadius = 6
        };
        btnExportExcel.Click += async (s, e) => await ExportToExcelAsync();

        cardFilter.Controls.Add(chkEnableDateFilter);
        cardFilter.Controls.Add(dtpFromDate);
        cardFilter.Controls.Add(lblTo);
        cardFilter.Controls.Add(dtpToDate);
        cardFilter.Controls.Add(cboActionFilter);
        cardFilter.Controls.Add(cboTableFilter);
        cardFilter.Controls.Add(txtSearch);
        cardFilter.Controls.Add(btnSearch);
        cardFilter.Controls.Add(btnReset);
        cardFilter.Controls.Add(btnExportExcel);

        // 3. DataGridView Setup
        dgvLogs = new DataGridView
        {
            Location = new Point(16, 220),
            Size = new Size(1168, 360),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false
        };
        ModernGridHelper.ApplyStyle(dgvLogs);
        ConfigureGridColumns();

        dgvLogs.SelectionChanged += DgvLogs_SelectionChanged;
        dgvLogs.CellFormatting += DgvLogs_CellFormatting;

        // 4. Detail Panel at bottom (GlassCard)
        var cardDetail = new GlassCard
        {
            Location = new Point(16, 590),
            Size = new Size(1168, 150),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            CornerRadius = 10,
            EnableShadow = false,
            Padding = new Padding(12)
        };

        lblSelectedLogTitle = new Label
        {
            Text = "CHI TIẾT THAY ĐỔI DỮ LIỆU (Chọn một bản ghi trên bảng để xem so sánh Old / New values)",
            Font = ThemeColors.FontBadge,
            ForeColor = ThemeColors.Primary,
            Location = new Point(14, 8),
            AutoSize = true
        };

        var lblOldTitle = new Label
        {
            Text = "DỮ LIỆU TRƯỚC SỬA (OLD VALUES):",
            Font = new Font("Segoe UI", 8.25f, FontStyle.Bold),
            ForeColor = Color.FromArgb(185, 28, 28),
            Location = new Point(14, 28),
            AutoSize = true
        };

        txtOldValues = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Font = new Font("Consolas", 9f),
            BackColor = Color.FromArgb(254, 242, 242),
            ForeColor = Color.FromArgb(30, 41, 59),
            Location = new Point(14, 48),
            Size = new Size(560, 90),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left
        };

        var lblNewTitle = new Label
        {
            Text = "DỮ LIỆU SAU SỬA (NEW VALUES / CHI TIẾT):",
            Font = new Font("Segoe UI", 8.25f, FontStyle.Bold),
            ForeColor = Color.FromArgb(21, 128, 61),
            Location = new Point(590, 28),
            AutoSize = true
        };

        txtNewValues = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Font = new Font("Consolas", 9f),
            BackColor = Color.FromArgb(240, 253, 244),
            ForeColor = Color.FromArgb(30, 41, 59),
            Location = new Point(590, 48),
            Size = new Size(560, 90),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
        };

        cardDetail.Controls.Add(lblSelectedLogTitle);
        cardDetail.Controls.Add(lblOldTitle);
        cardDetail.Controls.Add(txtOldValues);
        cardDetail.Controls.Add(lblNewTitle);
        cardDetail.Controls.Add(txtNewValues);

        // Add to main container
        mainContainer.Controls.Add(cardHeader);
        mainContainer.Controls.Add(cardFilter);
        mainContainer.Controls.Add(dgvLogs);
        mainContainer.Controls.Add(cardDetail);

        Controls.Add(mainContainer);
    }

    private static RoundedPanel CreateKpiBox(string title, string initialValue, Color bgColor, Color textColor, Point location, int width, out Label valueLabel)
    {
        var panel = new RoundedPanel
        {
            Location = location,
            Size = new Size(width, 42),
            CornerRadius = 6,
            BackColor = bgColor,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1
        };

        var lblTitle = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
            ForeColor = textColor,
            Location = new Point(10, 4),
            AutoSize = true
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
            ForeColor = textColor,
            Location = new Point(10, 18),
            AutoSize = true
        };

        panel.Controls.Add(lblTitle);
        panel.Controls.Add(valueLabel);
        return panel;
    }

    private void ConfigureGridColumns()
    {
        dgvLogs.Columns.Clear();

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColLogId",
            HeaderText = "MÃ LOG",
            DataPropertyName = "LogId",
            Width = 85,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColTime",
            HeaderText = "THỜI GIAN",
            DataPropertyName = "FormattedTimestamp",
            Width = 145,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColUsername",
            HeaderText = "TÀI KHOẢN",
            DataPropertyName = "Username",
            Width = 110
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColActorName",
            HeaderText = "NGƯỜI THỰC HIỆN",
            DataPropertyName = "ActorName",
            Width = 150
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColRoleName",
            HeaderText = "VAI TRÒ",
            DataPropertyName = "RoleName",
            Width = 130
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColActionName",
            HeaderText = "HÀNH ĐỘNG",
            DataPropertyName = "ActionName",
            Width = 140,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColTableName",
            HeaderText = "BẢNG DỮ LIỆU",
            DataPropertyName = "TableName",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColRecordId",
            HeaderText = "BẢN GHI ID",
            DataPropertyName = "RecordId",
            Width = 95,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });

        dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColNewValues",
            HeaderText = "CHI TIẾT TÁC ĐỘNG / GIÁ TRỊ MỚI",
            DataPropertyName = "NewValues",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
    }

    private async Task LoadFilterCombosAsync()
    {
        try
        {
            // 1. Actions
            var actions = (await _auditLogService.GetDistinctActionNamesAsync()).ToList();
            cboActionFilter.Items.Clear();
            cboActionFilter.Items.Add("Tất cả hành động");
            foreach (var act in actions)
            {
                cboActionFilter.Items.Add(act);
            }
            cboActionFilter.SelectedIndex = 0;

            // 2. Tables
            var tables = (await _auditLogService.GetDistinctTableNamesAsync()).ToList();
            cboTableFilter.Items.Clear();
            cboTableFilter.Items.Add("Tất cả bảng");
            foreach (var tbl in tables)
            {
                cboTableFilter.Items.Add(tbl);
            }
            cboTableFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải bộ lọc nhật ký: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async Task LoadSummaryAsync()
    {
        try
        {
            var summary = await _auditLogService.GetSummaryAsync();
            lblTotalCount.Text = $"{summary.TotalLogs:N0} bản ghi";
            lblTodayCount.Text = $"{summary.TodayLogs:N0} bản ghi";
            lblUserCount.Text = $"{summary.UniqueUsersCount:N0} tài khoản";
            lblSecurityCount.Text = $"{summary.SecurityEventsCount:N0} sự kiện";
        }
        catch
        {
            // Ignore minor summary error
        }
    }

    private AuditLogFilterDto BuildCurrentFilter()
    {
        var filter = new AuditLogFilterDto
        {
            Keyword = txtSearch.Text.Trim(),
            Limit = 1000,
            Offset = 0
        };

        if (cboActionFilter.SelectedIndex > 0)
        {
            filter.ActionName = cboActionFilter.SelectedItem?.ToString();
        }

        if (cboTableFilter.SelectedIndex > 0)
        {
            filter.TableName = cboTableFilter.SelectedItem?.ToString();
        }

        if (chkEnableDateFilter.Checked)
        {
            filter.FromDate = dtpFromDate.Value.Date;
            filter.ToDate = dtpToDate.Value.Date;
        }

        return filter;
    }

    private async Task LoadLogsAsync()
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            var filter = BuildCurrentFilter();
            var logs = (await _auditLogService.GetLogsAsync(filter)).ToList();
            dgvLogs.DataSource = logs;

            if (logs.Count == 0)
            {
                txtOldValues.Text = string.Empty;
                txtNewValues.Text = string.Empty;
                lblSelectedLogTitle.Text = "Không có bản ghi nhật ký nào phù hợp với bộ lọc hiện tại.";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu nhật ký kiểm toán: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private void DgvLogs_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvLogs.CurrentRow?.DataBoundItem is AuditLogListItemDto log)
        {
            lblSelectedLogTitle.Text = $"CHI TIẾT LOG #{log.LogId} - [{log.FormattedTimestamp}] - {log.ActorName} ({log.RoleName}) - Hành động: {log.ActionName} trên bảng {log.TableName} (ID: {log.RecordId ?? "-"})";
            txtOldValues.Text = string.IsNullOrWhiteSpace(log.OldValues) ? "(Không có giá trị cũ - Tác vụ tạo mới hoặc đăng nhập hệ thống)" : log.OldValues;
            txtNewValues.Text = string.IsNullOrWhiteSpace(log.NewValues) ? "(Không có giá trị mới)" : log.NewValues;
        }
    }

    private void DgvLogs_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvLogs.Rows.Count) return;

        // Custom badge rendering for ActionName
        if (dgvLogs.Columns[e.ColumnIndex].Name == "ColActionName" && e.Value != null)
        {
            string action = e.Value.ToString() ?? "";
            e.CellStyle!.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);

            if (action == "LOGIN")
            {
                e.CellStyle.BackColor = Color.FromArgb(224, 242, 254);
                e.CellStyle.ForeColor = Color.FromArgb(3, 105, 161);
            }
            else if (action.StartsWith("CREATE") || action.StartsWith("ADD"))
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                e.CellStyle.ForeColor = Color.FromArgb(21, 128, 61);
            }
            else if (action.StartsWith("UPDATE") || action.Contains("CONFIG"))
            {
                e.CellStyle.BackColor = Color.FromArgb(238, 242, 255);
                e.CellStyle.ForeColor = Color.FromArgb(67, 56, 202);
            }
            else if (action == "TOGGLE_USER_STATUS")
            {
                e.CellStyle.BackColor = Color.FromArgb(243, 232, 255);
                e.CellStyle.ForeColor = Color.FromArgb(126, 34, 206);
            }
            else if (action == "RESET_PASSWORD" || action == "CHANGE_PASSWORD")
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);
                e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
            }
            else if (action == "BRUTE_FORCE_LOCKOUT")
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
            }
            else if (action == "UNLOCK_USER")
            {
                e.CellStyle.BackColor = Color.FromArgb(204, 251, 241);
                e.CellStyle.ForeColor = Color.FromArgb(15, 118, 110);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(241, 245, 249);
                e.CellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            }
        }
    }

    private async Task ExportToExcelAsync()
    {
        try
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"ECMS_AuditLogs_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                Title = "Lưu Báo Cáo Nhật Ký Kiểm Toán Hệ Thống"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            Cursor = Cursors.WaitCursor;
            var filter = BuildCurrentFilter();
            byte[] fileBytes = await _auditLogService.GenerateExcelReportAsync(filter);

            await File.WriteAllBytesAsync(sfd.FileName, fileBytes);
            Cursor = Cursors.Default;

            var result = MessageBox.Show(
                $"Xuất báo cáo kiểm toán thành công!\nĐường dẫn: {sfd.FileName}\n\nBạn có muốn mở file ngay bây giờ không?",
                "Xuất Excel Thành Công",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            Cursor = Cursors.Default;
            MessageBox.Show("Lỗi xuất file Excel: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
