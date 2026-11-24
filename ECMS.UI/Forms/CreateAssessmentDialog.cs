using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.Data.Database;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateAssessmentDialog : Form
{
    private readonly IExamService _examService = new ExamService();
    private readonly IClassService _classService = new ClassService();
    private readonly string _defaultClass = string.Empty;
    private List<ClassListItemDto> _classes = new();
    private List<(int RoomId, string RoomName)> _rooms = new();

    private ComboBox _cboExamTime = null!;
    private ComboBox _cboExamRoom = null!;

    public string AssessmentName { get; private set; } = string.Empty;
    public string AssessmentType { get; private set; } = string.Empty;
    public string ExamDate { get; private set; } = string.Empty;
    public string ScoreScale { get; private set; } = "10";
    public string Weight { get; private set; } = "20%";
    public List<string> SelectedClasses { get; private set; } = new();

    public CreateAssessmentDialog(string defaultClass = "")
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        _defaultClass = defaultClass;
        SetupExtraExamScheduleControls();
        SetupTypes();
        WireEvents();
        _ = LoadLookupDataAsync();
    }

    private void SetupExtraExamScheduleControls()
    {
        // Bổ sung chọn Giờ thi & Phòng thi ngay trong form tạo bài kiểm tra để kiểm tra trùng lịch
        var pnlExtra = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 46,
            BackColor = Color.FromArgb(248, 250, 252),
            Padding = new Padding(12, 8, 12, 8)
        };

        var lblTime = new Label
        {
            Text = "Giờ thi:",
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Location = new Point(12, 13)
        };
        _cboExamTime = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9F),
            Location = new Point(72, 9),
            Size = new Size(165, 28)
        };
        _cboExamTime.Items.AddRange(new object[]
        {
            "08:00 - 09:30",
            "10:00 - 11:30",
            "13:30 - 15:00",
            "15:30 - 17:00",
            "18:00 - 19:30",
            "19:30 - 21:00"
        });
        _cboExamTime.SelectedIndex = 4;

        var lblRoom = new Label
        {
            Text = "Phòng thi:",
            AutoSize = true,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            Location = new Point(255, 13)
        };
        _cboExamRoom = new ComboBox
        {
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9F),
            Location = new Point(332, 9),
            Size = new Size(210, 28)
        };

        pnlExtra.Controls.AddRange(new Control[] { lblTime, _cboExamTime, lblRoom, _cboExamRoom });
        if (chkListClasses.Parent != null)
        {
            chkListClasses.Parent.Controls.Add(pnlExtra);
            pnlExtra.BringToFront();
        }
    }

    private void SetupTypes()
    {
        cboAssessmentType.Items.Clear();
        cboAssessmentType.Items.AddRange(new object[]
        {
            "Thường xuyên (TX)",
            "Giữa khóa (GK)",
            "Cuối khóa (CK)"
        });
        cboAssessmentType.SelectedIndex = 0;

        cboAssessmentType.SelectedIndexChanged += (s, e) =>
        {
            txtWeight.Text = cboAssessmentType.SelectedIndex switch
            {
                0 => "20%",
                1 => "30%",
                2 => "50%",
                _ => "20%"
            };
        };

        dtpExamDate.Value = DateTime.Today.AddDays(7);
        txtScale.Text = "10";
        txtWeight.Text = "20%";
    }

    private async Task LoadLookupDataAsync()
    {
        try
        {
            _classes = (await _classService.GetClassesAsync()).ToList();
            chkListClasses.Items.Clear();
            for (int i = 0; i < _classes.Count; i++)
            {
                var c = _classes[i];
                chkListClasses.Items.Add($"{c.ClassCode} - {c.CourseName} (GV: {c.TeacherName})");
                if (!string.IsNullOrEmpty(_defaultClass) && c.ClassCode.Equals(_defaultClass, StringComparison.OrdinalIgnoreCase))
                {
                    chkListClasses.SetItemChecked(i, true);
                }
            }
            if (chkListClasses.CheckedItems.Count == 0 && chkListClasses.Items.Count > 0)
            {
                chkListClasses.SetItemChecked(0, true);
            }

            using var conn = DatabaseConfig.CreateOpenConnection();
            _rooms = (await conn.QueryAsync<(int RoomId, string RoomName)>(
                "SELECT RoomId, RoomName FROM ClassRooms WHERE IsActive = 1 ORDER BY RoomName;")).ToList();

            _cboExamRoom.Items.Clear();
            _cboExamRoom.Items.Add("Theo phòng mặc định của lớp");
            foreach (var r in _rooms)
            {
                _cboExamRoom.Items.Add(r.RoomName);
            }
            _cboExamRoom.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách lớp / phòng thi", ex.Message);
        }
    }

    private void WireEvents()
    {
        btnSelectAllClasses.Click += (s, e) =>
        {
            for (int i = 0; i < chkListClasses.Items.Count; i++)
                chkListClasses.SetItemChecked(i, true);
        };

        btnClearClasses.Click += (s, e) =>
        {
            for (int i = 0; i < chkListClasses.Items.Count; i++)
                chkListClasses.SetItemChecked(i, false);
        };

        btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        btnSave.Click += async (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtAssessmentName.Text))
            {
                AppDialog.ShowWarning(this, "Thiếu thông tin", "Vui lòng nhập tên bài kiểm tra / kỳ thi.");
                txtAssessmentName.Focus();
                return;
            }

            var selectedClassIds = new List<int>();
            SelectedClasses.Clear();
            foreach (int idx in chkListClasses.CheckedIndices)
            {
                if (idx >= 0 && idx < _classes.Count)
                {
                    selectedClassIds.Add(_classes[idx].ClassId);
                    SelectedClasses.Add(_classes[idx].ClassCode);
                }
            }

            if (selectedClassIds.Count == 0)
            {
                AppDialog.ShowWarning(this, "Chưa chọn lớp", "Vui lòng tích chọn ít nhất 1 lớp học để áp dụng bài kiểm tra.");
                return;
            }

            string dbType = cboAssessmentType.SelectedIndex switch
            {
                0 => "Regular",
                1 => "Midterm",
                2 => "Final",
                _ => "Regular"
            };

            string weightRaw = txtWeight.Text.Replace("%", "").Trim();
            double.TryParse(weightRaw, out double weightVal);
            if (weightVal <= 0) weightVal = 20;

            string timeSlot = _cboExamTime.SelectedItem?.ToString() ?? "18:00 - 19:30";
            var parts = timeSlot.Split('-');
            string startTime = parts[0].Trim();
            string endTime = parts.Length > 1 ? parts[1].Trim() : "19:30";

            int? roomId = null;
            if (_cboExamRoom.SelectedIndex > 0 && _cboExamRoom.SelectedIndex - 1 < _rooms.Count)
            {
                roomId = _rooms[_cboExamRoom.SelectedIndex - 1].RoomId;
            }

            var req = new CreateExamRequestDto
            {
                ExamName = txtAssessmentName.Text.Trim(),
                Type = dbType,
                ExamDate = dtpExamDate.Value.Date,
                StartTime = startTime,
                EndTime = endTime,
                RoomId = roomId,
                WeightPercentage = weightVal,
                ClassIds = selectedClassIds
            };

            var res = await _examService.CreateExamsWithConflictCheckAsync(req);
            if (!res.Success)
            {
                AppDialog.ShowWarning(this, "Trùng lịch / Lỗi xếp lịch thi", res.Message);
                return;
            }

            AssessmentName = req.ExamName;
            AssessmentType = cboAssessmentType.SelectedItem?.ToString() ?? "Thường xuyên (TX)";
            ExamDate = dtpExamDate.Value.ToString("dd/MM/yyyy");
            ScoreScale = string.IsNullOrWhiteSpace(txtScale.Text) ? "10" : txtScale.Text.Trim();
            Weight = $"{weightVal:0}%";

            AppDialog.ShowSuccess(this, "Thành công", res.Message);
            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
