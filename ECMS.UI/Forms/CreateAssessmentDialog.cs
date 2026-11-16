using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class CreateAssessmentDialog : Form
{
    public string AssessmentName { get; private set; } = string.Empty;
    public string AssessmentType { get; private set; } = string.Empty;
    public string ExamDate { get; private set; } = string.Empty;
    public string ScoreScale { get; private set; } = "10";
    public string Weight { get; private set; } = "20%";
    public List<string> SelectedClasses { get; private set; } = new();

    public CreateAssessmentDialog(string defaultClass = "IELTS-F01")
    {
        InitializeComponent();

        SetupTypes();
        SetupClasses(defaultClass);
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

    private void SetupClasses(string defaultClass)
    {
        chkListClasses.Items.Clear();
        string[] classes =
        {
            "IELTS-F01 · IELTS Foundation (GV: Nguyễn Hoàng Anh)",
            "IELTS-F02 · IELTS Foundation (GV: Trần Minh Tuấn)",
            "IELTS-I01 · IELTS Intensive (GV: Trần Minh Tuấn)",
            "TOEIC-A01 · TOEIC 500+ (GV: Lê Thu Hà)",
            "COM-B01 · Giao tiếp cơ bản (GV: Lê Thu Hà)",
            "IELTS-F04 · IELTS Foundation (GV: Võ Tấn Toàn)"
        };

        for (int i = 0; i < classes.Length; i++)
        {
            chkListClasses.Items.Add(classes[i]);
            if (!string.IsNullOrEmpty(defaultClass) && classes[i].Contains(defaultClass))
            {
                chkListClasses.SetItemChecked(i, true);
            }
        }

        if (chkListClasses.CheckedItems.Count == 0 && chkListClasses.Items.Count > 0)
        {
            chkListClasses.SetItemChecked(0, true);
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

        btnSave.Click += (s, e) =>
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

            SelectedClasses.Clear();
            foreach (var item in chkListClasses.CheckedItems)
            {
                string text = item.ToString() ?? "";
                string code = text.Split('·')[0].Trim();
                SelectedClasses.Add(code);
            }

            MessageBox.Show($"Đã tạo bài kiểm tra \"{AssessmentName}\" ({AssessmentType}) thành công cho {SelectedClasses.Count} lớp học!",
                "Tạo bài kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        };
    }
}
