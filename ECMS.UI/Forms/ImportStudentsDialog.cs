using System;
using System.Collections.Generic;
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

/// <summary>
/// Hộp thoại nhập danh sách học viên hàng loạt từ tệp Excel (.xlsx) hoặc CSV
/// </summary>
public partial class ImportStudentsDialog : Form
{
    private readonly IStudentService _studentService = new StudentService();
    private List<StudentImportRowDto> _rows = new();

    // Controls
    private Panel pnlHeader = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private AppButton btnDownloadTemplate = null!;
    private AppButton btnChooseFile = null!;

    private Panel pnlSummary = null!;
    private Label lblTotalSummary = null!;
    private Label lblValidSummary = null!;
    private Label lblInvalidSummary = null!;
    private Label lblFileNotice = null!;

    private Panel pnlGridContainer = null!;
    private AppCard cardGrid = null!;
    private AppDataGrid dgvPreview = null!;

    private Panel pnlFooter = null!;
    private Label lblFooterNote = null!;
    private AppButton btnCancel = null!;
    private AppButton btnExecuteImport = null!;

    public ImportStudentsDialog()
    {
        InitializeCustomComponents();
        WireEvents();
    }

    private void InitializeCustomComponents()
    {
        Text = "Nhập danh sách học viên từ Excel / CSV - ECMS";
        Size = new Size(1120, 680);
        MinimumSize = new Size(950, 600);
        StartPosition = FormStartPosition.CenterParent;
        BackColor = Color.FromArgb(248, 250, 252);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        // 1. Header Panel
        pnlHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 85,
            BackColor = Color.White,
            Padding = new Padding(24, 14, 24, 14)
        };

        lblTitle = new Label
        {
            Text = "📥 Nhập danh sách học viên từ Excel / CSV",
            Font = new Font("Segoe UI", 13.5F, FontStyle.Bold),
            ForeColor = Color.FromArgb(15, 23, 42),
            Location = new Point(24, 12),
            AutoSize = true
        };

        lblSubtitle = new Label
        {
            Text = "Tải lên tệp Excel (.xlsx) hoặc CSV để ghi nhận hàng loạt học viên vào cơ sở dữ liệu SQLite",
            Font = new Font("Segoe UI", 9F, FontStyle.Regular),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(24, 46),
            AutoSize = true
        };

        btnDownloadTemplate = new AppButton
        {
            Text = "📄 Tải tệp mẫu (.xlsx)",
            Size = new Size(170, 36),
            Location = new Point(720, 24),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 6,
            Cursor = Cursors.Hand
        };

        btnChooseFile = new AppButton
        {
            Text = "📁 Chọn tệp dữ liệu",
            Size = new Size(160, 36),
            Location = new Point(900, 24),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Variant = ButtonVariant.Primary,
            ButtonStyle = AppButtonStyle.Primary,
            CornerRadius = 6,
            Cursor = Cursors.Hand
        };

        pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle, btnDownloadTemplate, btnChooseFile });

        // 2. Summary Toolbar Panel
        pnlSummary = new Panel
        {
            Dock = DockStyle.Top,
            Height = 44,
            BackColor = Color.FromArgb(241, 245, 249),
            Padding = new Padding(24, 8, 24, 8)
        };

        lblTotalSummary = new Label
        {
            Text = "Tổng số: 0 dòng",
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(51, 65, 85),
            Location = new Point(24, 12),
            AutoSize = true
        };

        lblValidSummary = new Label
        {
            Text = "✓ Hợp lệ: 0",
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(22, 101, 52),
            Location = new Point(160, 12),
            AutoSize = true
        };

        lblInvalidSummary = new Label
        {
            Text = "✕ Lỗi: 0",
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(185, 28, 28),
            Location = new Point(270, 12),
            AutoSize = true
        };

        lblFileNotice = new Label
        {
            Text = "Chưa nạp tệp dữ liệu nào.",
            Font = new Font("Segoe UI", 9F, FontStyle.Italic),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(370, 12),
            AutoSize = true
        };

        pnlSummary.Controls.AddRange(new Control[] { lblTotalSummary, lblValidSummary, lblInvalidSummary, lblFileNotice });

        // 3. Footer Action Panel
        pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 65,
            BackColor = Color.White,
            Padding = new Padding(24, 14, 24, 14)
        };

        lblFooterNote = new Label
        {
            Text = "💡 Chỉ các dòng có trạng thái '✓ Hợp lệ' mới được lưu vào CSDL.",
            Font = new Font("Segoe UI", 9F, FontStyle.Regular),
            ForeColor = Color.FromArgb(100, 116, 139),
            Location = new Point(24, 22),
            AutoSize = true
        };

        btnCancel = new AppButton
        {
            Text = "Đóng",
            Size = new Size(110, 36),
            Location = new Point(780, 14),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            Variant = ButtonVariant.Secondary,
            ButtonStyle = AppButtonStyle.Secondary,
            CornerRadius = 6,
            Cursor = Cursors.Hand
        };

        btnExecuteImport = new AppButton
        {
            Text = "✓ Tiến hành nhập (0)",
            Size = new Size(180, 36),
            Location = new Point(900, 14),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            Variant = ButtonVariant.Primary,
            ButtonStyle = AppButtonStyle.Primary,
            CornerRadius = 6,
            Cursor = Cursors.Hand,
            Enabled = false
        };

        pnlFooter.Controls.AddRange(new Control[] { lblFooterNote, btnCancel, btnExecuteImport });

        // 4. Center Grid Panel
        pnlGridContainer = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(20, 14, 20, 14),
            BackColor = Color.FromArgb(248, 250, 252)
        };

        cardGrid = new AppCard
        {
            Dock = DockStyle.Fill,
            BorderColor = Color.FromArgb(226, 232, 240),
            BorderWidth = 1,
            CornerRadius = 8,
            Padding = new Padding(0)
        };

        dgvPreview = new AppDataGrid
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            RowHeadersVisible = false
        };

        cardGrid.Controls.Add(dgvPreview);
        pnlGridContainer.Controls.Add(cardGrid);

        // Add to Form
        Controls.Add(pnlGridContainer);
        Controls.Add(pnlSummary);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);

        SetupGridColumns();
    }

    private void SetupGridColumns()
    {
        AppGridHelper.ApplyStyle(dgvPreview);
        dgvPreview.Columns.Clear();

        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dòng", FillWeight = 8, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", FillWeight = 22, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày sinh", FillWeight = 14, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giới tính", FillWeight = 10, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", FillWeight = 16, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", FillWeight = 20, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phụ huynh", FillWeight = 18, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SĐT Phụ huynh", FillWeight = 16, ReadOnly = true });
        dgvPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái kiểm tra", FillWeight = 24, ReadOnly = true });

        dgvPreview.CellFormatting += (s, e) =>
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPreview.Rows.Count) return;
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                string text = e.Value.ToString() ?? "";
                if (text.StartsWith("✓"))
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(22, 101, 52);
                    e.CellStyle!.Font = new Font(dgvPreview.Font, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.ForeColor = Color.FromArgb(185, 28, 28);
                    e.CellStyle!.Font = new Font(dgvPreview.Font, FontStyle.Bold);
                }
            }
        };
    }

    private void WireEvents()
    {
        btnCancel.Click += (s, e) => Close();

        // 1. Tải tệp mẫu Excel
        btnDownloadTemplate.Click += (s, e) =>
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Chọn nơi lưu tệp mẫu Excel",
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"Mau_DanhSach_HocVien_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    byte[] bytes = _studentService.GenerateStudentImportTemplate();
                    File.WriteAllBytes(sfd.FileName, bytes);

                    if (AppDialog.ShowConfirm(this, "Tải tệp mẫu thành công",
                        $"Đã tạo tệp mẫu Excel tại:\n{sfd.FileName}\n\nBạn có muốn mở tệp ngay không?") == DialogResult.OK)
                    {
                        Process.Start(new ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
                    }
                }
                catch (Exception ex)
                {
                    AppDialog.ShowError(this, "Lỗi tải tệp mẫu", ex.Message);
                }
            }
        };

        // 2. Chọn tệp dữ liệu Excel / CSV
        btnChooseFile.Click += async (s, e) =>
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn tệp danh sách học viên (.xlsx / .csv)",
                Filter = "Tệp Excel / CSV (*.xlsx;*.csv)|*.xlsx;*.csv|Excel Workbook (*.xlsx)|*.xlsx|CSV (*.csv)|*.csv"
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    await using var fs = File.OpenRead(ofd.FileName);
                    _rows = await _studentService.ParseAndValidateStudentFileAsync(fs, ofd.FileName);

                    dgvPreview.Rows.Clear();
                    foreach (var r in _rows)
                    {
                        dgvPreview.Rows.Add(
                            r.RowIndex,
                            r.FullName,
                            r.DateOfBirthDisplay,
                            r.Gender,
                            r.Phone,
                            r.Email ?? "",
                            $"{r.ParentName ?? ""} ({r.ParentRelationship})",
                            r.ParentPhone ?? "",
                            r.ValidationMessage
                        );
                    }

                    int validCount = _rows.Count(x => x.IsValid);
                    int invalidCount = _rows.Count(x => !x.IsValid);

                    lblTotalSummary.Text = $"Tổng số: {_rows.Count} dòng";
                    lblValidSummary.Text = $"✓ Hợp lệ: {validCount}";
                    lblInvalidSummary.Text = $"✕ Lỗi: {invalidCount}";
                    lblFileNotice.Text = $"Tệp: {Path.GetFileName(ofd.FileName)}";

                    btnExecuteImport.Enabled = validCount > 0;
                    btnExecuteImport.Text = $"✓ Tiến hành nhập ({validCount})";

                    if (validCount == 0)
                    {
                        AppDialog.ShowWarning(this, "Không có dòng hợp lệ",
                            "Tất cả các dòng trong tệp đều có lỗi định dạng hoặc trùng lặp số điện thoại. Vui lòng kiểm tra cột trạng thái.");
                    }
                }
                catch (Exception ex)
                {
                    AppDialog.ShowError(this, "Lỗi đọc tệp", $"Không thể đọc tệp dữ liệu: {ex.Message}");
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        };

        // 3. Tiến hành nhập
        btnExecuteImport.Click += async (s, e) =>
        {
            int validCount = _rows.Count(x => x.IsValid);
            if (validCount == 0) return;

            if (AppDialog.ShowConfirm(this, "Xác nhận nhập học viên",
                $"Bạn có chắc chắn muốn nhập {validCount} học viên hợp lệ vào cơ sở dữ liệu SQLite không?\n\nHệ thống sẽ tự động sinh mã học viên và liên kết người thân.") != DialogResult.OK)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            btnExecuteImport.Enabled = false;

            try
            {
                var res = await _studentService.ExecuteImportStudentsAsync(_rows);
                if (res.SuccessCount > 0)
                {
                    string sampleCodes = string.Join(", ", res.InsertedStudentCodes.Take(5));
                    if (res.InsertedStudentCodes.Count > 5)
                        sampleCodes += $", ... và {res.InsertedStudentCodes.Count - 5} học viên khác";

                    AppDialog.ShowSuccess(this, "Nhập học viên thành công",
                        $"🎉 Đã thêm thành công {res.SuccessCount} học viên vào hệ thống SQLite!\n\nCác mã học viên vừa sinh: {sampleCodes}");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string err = res.ErrorMessages.Count > 0 ? string.Join("\n", res.ErrorMessages) : "Không thể nhập học viên.";
                    AppDialog.ShowError(this, "Lỗi nhập học viên", err);
                }
            }
            catch (Exception ex)
            {
                AppDialog.ShowError(this, "Lỗi hệ thống", ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnExecuteImport.Enabled = true;
            }
        };
    }
}
