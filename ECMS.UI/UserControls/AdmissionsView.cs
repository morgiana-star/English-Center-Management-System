using System;
using System.Drawing;
using System.Windows.Forms;
using ECMS.UI.Controls;
using ECMS.UI.Forms;

namespace ECMS.UI.UserControls;

/// <summary>
/// UserControl Tuyển sinh & Tư vấn (Màn hình 1 cố định: Danh sách khách hàng tiềm năng)
/// Khi bấm Thêm tiềm năng -> mở AddLeadDialog (Màn 2)
/// Khi bấm Mở hồ sơ -> mở ConsultationDialog (Màn 3) -> EnrollmentDialog (Màn 4) -> EnrollmentSuccessDialog (Màn 5)
/// Hỗ trợ kéo thả trực quan 100% trên WinForms Designer của JetBrains Rider
/// </summary>
public partial class AdmissionsView : UserControl
{
    public AdmissionsView()
    {
        InitializeComponent();
        SetupFilters();
        PopulateMockData();
        WireUpEvents();
    }

    private void SetupFilters()
    {
        cboSourceFilter.Items.AddRange(new object[] { "Tất cả nguồn", "Tư vấn tại trung tâm", "Website / Fanpage", "Người quen giới thiệu", "Hotline" });
        cboSourceFilter.SelectedIndex = 0;

        cboStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Mới tiếp nhận", "Đang tư vấn", "Chờ đầu vào", "Chờ ghi danh", "Đã ghi danh" });
        cboStatusFilter.SelectedIndex = 0;
    }

    private void PopulateMockData()
    {
        AppGridHelper.ApplyStyle(dgvLeads);
        dgvLeads.Columns.Clear();
        dgvLeads.Columns.Add("ColCode", "Mã ↑");
        dgvLeads.Columns.Add("ColName", "Họ và tên");
        dgvLeads.Columns.Add("ColPhone", "Điện thoại");
        dgvLeads.Columns.Add("ColNeed", "Nhu cầu");
        dgvLeads.Columns.Add("ColAppt", "Lần hẹn tiếp");
        dgvLeads.Columns.Add("ColStatus", "Trạng thái");

        var colAction = new DataGridViewButtonColumn
        {
            Name = "ColAction",
            HeaderText = "Thao tác",
            Text = "Mở hồ sơ",
            UseColumnTextForButtonValue = true,
            FlatStyle = FlatStyle.Flat
        };
        colAction.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
        colAction.DefaultCellStyle.SelectionForeColor = Color.FromArgb(37, 99, 235);
        dgvLeads.Columns.Add(colAction);

        dgvLeads.Rows.Add("TN-0108", "Nguyễn Minh Anh", "0908 123 456", "IELTS Foundation", "02/10 · 14:00", "Chờ ghi danh");
        dgvLeads.Rows.Add("TN-0109", "Phạm Khánh Linh", "0912 450 678", "TOEIC 500+", "03/10 · 09:00", "Đang tư vấn");
        dgvLeads.Rows.Add("TN-0110", "Đỗ Thanh Tâm", "0935 661 220", "Giao tiếp cơ bản", "03/10 · 10:30", "Chờ đầu vào");
        dgvLeads.Rows.Add("TN-0111", "Vũ Quang Huy", "0906 332 441", "IELTS 5.0–6.5", "04/10 · 15:00", "Mới tiếp nhận");
        dgvLeads.Rows.Add("TN-0112", "Ngô Mai Phương", "0917 832 998", "TOEIC 650+", "04/10 · 16:00", "Đã liên hệ");
    }

    private void WireUpEvents()
    {
        // 1. Thêm tiềm năng -> Mở Dialog Màn hình 2
        btnAddLeadTop.Click += (s, e) =>
        {
            using var dlg = new AddLeadDialog();
            dlg.ShowDialog(ParentForm);
        };

        // 2. Nhập từ tệp
        btnImport.Click += (s, e) => AppDialog.ShowSuccess(ParentForm, "Nhập từ tệp", "Tính năng nhập danh sách khách hàng từ Excel/CSV cục bộ.");

        // 3. Mở hồ sơ -> Mở Dialog Màn hình 3 (Tư vấn & đầu vào)
        dgvLeads.CellContentClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && dgvLeads.Columns[e.ColumnIndex].Name == "ColAction")
            {
                using var dlg = new ConsultationDialog();
                dlg.ShowDialog(ParentForm);
            }
        };
    }
}
