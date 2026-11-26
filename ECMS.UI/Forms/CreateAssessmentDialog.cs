using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateAssessmentDialog : Form
{
    private readonly IExamService _examService;
    private List<ClassExamLookupDto> _availableClasses = new();

    public string AssessmentName { get; private set; } = string.Empty;
    public string AssessmentType { get; private set; } = string.Empty;
    public string ExamDate { get; private set; } = string.Empty;
    public string ScoreScale { get; private set; } = "10";
    public string Weight { get; private set; } = "20%";
    public List<string> SelectedClasses { get; private set; } = new();

    public CreateAssessmentDialog(string defaultClass = "IELTS-F01")
    {
        InitializeComponent();
        _examService = new ExamService();

        SetupTypes();
        _ = SetupClassesAsync(defaultClass);
        WireEvents();
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
            switch (cboAssessmentType.SelectedIndex)
            {
                case 0:
                    txtWeight.Text = "20%";
                    break;
                case 1:
                    txtWeight.Text = "30%";
                    break;
                case 2:
                    txtWeight.Text = "50%";
                    break;
            }
        };

        dtpExamDate.Value = DateTime.Today.AddDays(7);
        txtScale.Text = "10";
        txtWeight.Text = "20%";
    }

    private async Task SetupClassesAsync(string defaultClass)
    {
        try
        {
            chkListClasses.Items.Clear();
            var classes = (await _examService.GetClassesLookupAsync()).ToList();
            _availableClasses = classes;

            for (int i = 0; i < classes.Count; i++)
            {
                var c = classes[i];
                chkListClasses.Items.Add(c.DisplayText);
                if (!string.IsNullOrEmpty(defaultClass) && (c.ClassCode == defaultClass || c.DisplayText.Contains(defaultClass)))
                {
                    chkListClasses.SetItemChecked(i, true);
                }
            }

            if (chkListClasses.CheckedItems.Count == 0 && chkListClasses.Items.Count > 0)
            {
                chkListClasses.SetItemChecked(0, true);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void WireEvents()
    {
        btnSelectAllClasses.Click += (s, e) =>
        {
            for (int i = 0; i < chkListClasses.Items.Count; i++)
            {
                chkListClasses.SetItemChecked(i, true);
            }
        };

        btnClearClasses.Click += (s, e) =>
        {
            for (int i = 0; i < chkListClasses.Items.Count; i++)
            {
                chkListClasses.SetItemChecked(i, false);
            }
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
                MessageBox.Show("Vui lòng nhập tên bài kiểm tra!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAssessmentName.Focus();
                return;
            }

            if (chkListClasses.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất 1 lớp học để áp dụng bài kiểm tra!", "Chưa chọn lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AssessmentName = txtAssessmentName.Text.Trim();
            AssessmentType = cboAssessmentType.SelectedItem?.ToString() ?? "Thường xuyên (TX)";
            ExamDate = dtpExamDate.Value.ToString("dd/MM/yyyy");
            ScoreScale = string.IsNullOrWhiteSpace(txtScale.Text) ? "10" : txtScale.Text.Trim();
            Weight = string.IsNullOrWhiteSpace(txtWeight.Text) ? "20%" : txtWeight.Text.Trim();

            decimal weightVal = 20.0m;
            if (decimal.TryParse(Weight.Replace("%", "").Trim(), out var parsedWeight))
            {
                weightVal = parsedWeight;
            }

            btnSave.Enabled = false;
            try
            {
                SelectedClasses.Clear();
                foreach (int index in chkListClasses.CheckedIndices)
                {
                    if (index >= 0 && index < _availableClasses.Count)
                    {
                        var cls = _availableClasses[index];
                        await _examService.CreateExamAsync(new CreateExamDto
                        {
                            ClassId = cls.ClassId,
                            ExamName = AssessmentName,
                            Type = AssessmentType,
                            ExamDate = dtpExamDate.Value.ToString("yyyy-MM-dd"),
                            WeightPercentage = weightVal
                        });
                        SelectedClasses.Add(cls.ClassCode);
                    }
                }

                MessageBox.Show(
                    $"Đã tạo thành công bài kiểm tra \"{AssessmentName}\" ({AssessmentType}) cho {SelectedClasses.Count} lớp học:\n" +
                    $"{string.Join(", ", SelectedClasses)}\n\n" +
                    "Bài kiểm tra đã được lưu vào hệ thống cơ sở dữ liệu.",
                    "Tạo bài kiểm tra thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu bài kiểm tra vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        };
    }
}
