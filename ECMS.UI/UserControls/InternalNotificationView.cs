using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.UserControls;

public partial class InternalNotificationView : UserControl
{
    private class NoticeItem
    {
        public string NoticeId { get; set; } = string.Empty;
        public string CreatedDate { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Recipients { get; set; } = string.Empty;
        public string ReadStats { get; set; } = string.Empty;
        public string ClassScope { get; set; } = string.Empty;
    }

    private readonly List<NoticeItem> _allNotices = new();

    public InternalNotificationView()
    {
        InitializeComponent();

        SetupFilters();
        SetupGrid();
        LoadSampleData();
        WireEvents();
    }

    private void SetupFilters()
    {
        cboMonthFilter.Items.Clear();
        cboMonthFilter.Items.AddRange(new object[]
        {
            "Tháng 10/2026",
            "Tháng 09/2026",
            "Tất cả thời gian"
        });
        cboMonthFilter.SelectedIndex = 0;

        cboAudienceFilter.Items.Clear();
        cboAudienceFilter.Items.AddRange(new object[]
        {
            "Tất cả người nhận",
            "Học viên & Phụ huynh",
            "Giáo viên",
            "Tư vấn & Kế toán",
            "Đào tạo"
        });
        cboAudienceFilter.SelectedIndex = 0;

        cboClassScope.Items.Clear();
        cboClassScope.Items.AddRange(new object[]
        {
            "Các lớp còn công nợ",
            "Toàn trung tâm",
            "Lớp IELTS-F01",
            "Lớp IELTS-F02",
            "Lớp TOEIC-T01"
        });
        cboClassScope.SelectedIndex = 0;
    }

    private void SetupGrid()
    {
        dgvNotices.AutoGenerateColumns = false;
        dgvNotices.Columns.Clear();
        dgvNotices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvNotices.MultiSelect = false;
        dgvNotices.ReadOnly = true;
        dgvNotices.RowHeadersVisible = false;
        dgvNotices.AllowUserToAddRows = false;

        dgvNotices.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "CreatedDate",
            HeaderText = "Ngày ↑",
            Width = 100
        });

        dgvNotices.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Title",
            HeaderText = "Tiêu đề",
            Width = 260
        });

        dgvNotices.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Status",
            HeaderText = "Trạng thái",
            Width = 120
        });
    }

    private void LoadSampleData()
    {
        _allNotices.Clear();
        _allNotices.Add(new NoticeItem
        {
            NoticeId = "TB-001",
            CreatedDate = "30/10/2026",
            Title = "Nhắc chốt điểm IELTS-F02",
            Status = "Đã phát hành",
            Sender = "Nguyễn Thị Hạnh · 30/10/2026, 08:30",
            Content = "Kính gửi giáo viên và nhân viên đào tạo, vui lòng kiểm tra điểm cuối khóa, trọng số và chuyên cần của IELTS-F02 trước 16:00 hôm nay để xét chứng chỉ.",
            Recipients = "Giáo viên, Nhân viên đào tạo",
            ReadStats = "Đã đọc 12/16. Thông báo chỉ xuất hiện trong ECMS khi mở ứng dụng.",
            ClassScope = "Lớp IELTS-F02"
        });

        _allNotices.Add(new NoticeItem
        {
            NoticeId = "TB-002",
            CreatedDate = "29/10/2026",
            Title = "Lịch họp giáo viên tháng 11",
            Status = "Đã phát hành",
            Sender = "Trần Minh Quân · 29/10/2026, 14:00",
            Content = "Thân mời toàn thể giáo viên tham dự buổi họp chuyên môn định kỳ tháng 11 vào lúc 14:00 Thứ 4 (04/11) tại phòng P201.",
            Recipients = "Giáo viên",
            ReadStats = "Đã đọc 20/24. Thông báo chỉ xuất hiện trong ECMS khi mở ứng dụng.",
            ClassScope = "Toàn trung tâm"
        });

        _allNotices.Add(new NoticeItem
        {
            NoticeId = "TB-003",
            CreatedDate = "28/10/2026",
            Title = "Nhắc hạn học phí tháng 11",
            Status = "Bản nháp",
            Sender = "Lê Phương Thảo · 28/10/2026, 10:15",
            Content = "Vui lòng kiểm tra số dư và hoàn tất học phí theo hạn trong hồ sơ. Liên hệ kế toán tại văn phòng khi cần đối chiếu.",
            Recipients = "Học viên, Phụ huynh",
            ReadStats = "Chưa phát hành (Bản nháp nội bộ).",
            ClassScope = "Các lớp còn công nợ"
        });

        ApplyFilter();

        if (dgvNotices.Rows.Count > 0)
        {
            dgvNotices.Rows[0].Selected = true;
            DisplayNoticePreview(_allNotices[0]);
        }
    }

    private void ApplyFilter()
    {
        var filtered = _allNotices.AsEnumerable();

        var query = txtSearchNotice.Text?.Trim().ToLowerInvariant();
        if (!string.IsNullOrEmpty(query))
        {
            filtered = filtered.Where(n =>
                n.Title.ToLowerInvariant().Contains(query) ||
                n.Content.ToLowerInvariant().Contains(query));
        }

        var list = filtered.ToList();
        dgvNotices.DataSource = null;
        dgvNotices.DataSource = list;

        lblPagingInfo.Text = $"1–{list.Count} / {_allNotices.Count} thông báo";
    }

    private void DisplayNoticePreview(NoticeItem item)
    {
        lblNoticePreviewTitle.Text = item.Title;
        lblNoticePreviewBadge.Text = $"Nội bộ · {item.Status}";
        lblNoticePreviewBadge.ForeColor = item.Status == "Đã phát hành" ? Color.FromArgb(37, 99, 235) : Color.FromArgb(234, 88, 12);
        lblNoticePreviewSender.Text = $"Người gửi: {item.Sender}";
        lblNoticePreviewBody.Text = item.Content;
        // lblNoticePreviewNote.Text = $"Người nhận: {item.Recipients} · {item.ReadStats}";

        // Đồng bộ form soạn nếu cần
        txtTitleInput.Text = item.Title;
        txtContent.Text = item.Content;
        cboClassScope.SelectedItem = item.ClassScope;
        // bannerOfflineNotice.Message = $"Trạng thái hiện tại: {item.Status}.";
    }

    private void WireEvents()
    {
        dgvNotices.SelectionChanged += (s, e) =>
        {
            if (dgvNotices.CurrentRow?.DataBoundItem is NoticeItem item)
            {
                DisplayNoticePreview(item);
            }
        };

        txtSearchNotice.TextChanged += (s, e) => ApplyFilter();
        cboMonthFilter.SelectedIndexChanged += (s, e) => ApplyFilter();
        cboAudienceFilter.SelectedIndexChanged += (s, e) => ApplyFilter();

        btnComposeTop.Click += (s, e) =>
        {
            txtTitleInput.Text = string.Empty;
            txtContent.Text = string.Empty;
            chkStudent.Checked = true;
            chkParent.Checked = true;
            chkTeacher.Checked = false;
            chkConsultant.Checked = false;
            chkAccountant.Checked = false;
            chkTraining.Checked = false;
            cboClassScope.SelectedIndex = 0;
            // bannerOfflineNotice.Message = "Trạng thái hiện tại: Tạo mới bản nháp.";
            txtTitleInput.Focus();
        };

        btnCancelCompose.Click += (s, e) =>
        {
            if (dgvNotices.CurrentRow?.DataBoundItem is NoticeItem item)
            {
                DisplayNoticePreview(item);
            }
        };

        btnSaveDraft.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtTitleInput.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tiêu đề thông báo.");
                txtTitleInput.Focus();
                return;
            }

            var draft = new NoticeItem
            {
                NoticeId = $"TB-{( _allNotices.Count + 1 ):D3}",
                CreatedDate = DateTime.Today.ToString("dd/MM/yyyy"),
                Title = txtTitleInput.Text.Trim(),
                Status = "Bản nháp",
                Sender = $"Trần Minh Quân · {DateTime.Now:dd/MM/yyyy, HH:mm}",
                Content = txtContent.Text.Trim(),
                Recipients = "Nội bộ được chọn",
                ReadStats = "Chưa phát hành (Bản nháp nội bộ).",
                ClassScope = cboClassScope.SelectedItem?.ToString() ?? "Toàn trung tâm"
            };

            _allNotices.Insert(0, draft);
            ApplyFilter();
            AppDialog.ShowSuccess(ParentForm, "Đã lưu nháp", "Thông báo đã được lưu dưới dạng Bản nháp trong CSDL cục bộ.");
        };

        btnPublishNotice.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtTitleInput.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập tiêu đề thông báo.");
                txtTitleInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                AppDialog.ShowError(ParentForm, "Thiếu thông tin", "Vui lòng nhập nội dung thông báo.");
                txtContent.Focus();
                return;
            }

            var published = new NoticeItem
            {
                NoticeId = $"TB-{( _allNotices.Count + 1 ):D3}",
                CreatedDate = DateTime.Today.ToString("dd/MM/yyyy"),
                Title = txtTitleInput.Text.Trim(),
                Status = "Đã phát hành",
                Sender = $"Trần Minh Quân · {DateTime.Now:dd/MM/yyyy, HH:mm}",
                Content = txtContent.Text.Trim(),
                Recipients = "Học viên, Phụ huynh, Giáo viên",
                ReadStats = "Đã phát hành đến máy trạm cục bộ.",
                ClassScope = cboClassScope.SelectedItem?.ToString() ?? "Toàn trung tâm"
            };

            _allNotices.Insert(0, published);
            ApplyFilter();
            AppDialog.ShowSuccess(ParentForm, "Phát hành thành công",
                $"Thông báo '{published.Title}' đã được phát hành trên bảng tin nội bộ.\n" +
                "Người dùng khi đăng nhập vào hệ thống ECMS sẽ nhìn thấy thông báo này.");
        };
    }
}
