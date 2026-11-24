using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECMS.Business.Services;
using ECMS.Core.DTOs;
using ECMS.UI.Controls;

namespace ECMS.UI.Forms;

public partial class DiscountManagementDialog : Form
{
    private readonly IEnrollmentService _enrollmentService = new EnrollmentService();
    private List<FeeDiscountDto> _discounts = new();
    private int _editingDiscountId = 0;

    public DiscountManagementDialog()
    {
        InitializeComponent();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        SetupGrid();
        WireEvents();
        _ = LoadDiscountsAsync();
    }

    private void SetupGrid()
    {
        AppGridHelper.ApplyStyle(dgvDiscounts);
        dgvDiscounts.Columns.Clear();
        dgvDiscounts.Columns.Add("ColCode", "Mã giảm giá");
        dgvDiscounts.Columns.Add("ColName", "Tên chương trình ưu đãi");
        dgvDiscounts.Columns.Add("ColValue", "Mức giảm");
        dgvDiscounts.Columns.Add("ColDesc", "Mô tả điều kiện");
        dgvDiscounts.Columns.Add("ColStatus", "Trạng thái");

        dgvDiscounts.Columns["ColCode"]!.FillWeight = 15;
        dgvDiscounts.Columns["ColName"]!.FillWeight = 26;
        dgvDiscounts.Columns["ColValue"]!.FillWeight = 16;
        dgvDiscounts.Columns["ColDesc"]!.FillWeight = 30;
        dgvDiscounts.Columns["ColStatus"]!.FillWeight = 13;
    }

    private async Task LoadDiscountsAsync()
    {
        try
        {
            _discounts = (await _enrollmentService.GetAllDiscountsAsync()).ToList();
            dgvDiscounts.Rows.Clear();
            foreach (var d in _discounts)
            {
                int idx = dgvDiscounts.Rows.Add(
                    d.DiscountCode,
                    d.DiscountName,
                    d.ValueDisplay,
                    d.Description ?? "",
                    d.IsActive ? "Đang bật" : "Đã tắt");
                dgvDiscounts.Rows[idx].Tag = d;
            }
            dgvDiscounts.ClearSelection();
        }
        catch (Exception ex)
        {
            AppDialog.ShowError(this, "Lỗi tải danh sách mã giảm giá", ex.Message);
        }
    }

    private void ResetForm()
    {
        _editingDiscountId = 0;
        txtCode.Text = "";
        txtName.Text = "";
        nudPercent.Value = 0;
        nudFixedAmount.Value = 0;
        txtDescription.Text = "";
        chkIsActive.Checked = true;
        btnSave.Text = "Thêm mã";
        btnDelete.Enabled = false;
        dgvDiscounts.ClearSelection();
        txtCode.Focus();
    }

    private void WireEvents()
    {
        btnClose.Click += (s, e) => Close();
        btnNew.Click += (s, e) => ResetForm();

        dgvDiscounts.CellClick += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            if (dgvDiscounts.Rows[e.RowIndex].Tag is FeeDiscountDto d)
            {
                _editingDiscountId = d.DiscountId;
                txtCode.Text = d.DiscountCode;
                txtName.Text = d.DiscountName;
                nudPercent.Value = Math.Clamp((decimal)d.Percentage, 0, 100);
                nudFixedAmount.Value = Math.Clamp(d.FixedAmount, 0, nudFixedAmount.Maximum);
                txtDescription.Text = d.Description ?? "";
                chkIsActive.Checked = d.IsActive;
                btnSave.Text = "Cập nhật";
                btnDelete.Enabled = true;
            }
        };

        btnSave.Click += async (s, e) =>
        {
            var dto = new FeeDiscountDto
            {
                DiscountId = _editingDiscountId,
                DiscountCode = txtCode.Text.Trim().ToUpperInvariant(),
                DiscountName = txtName.Text.Trim(),
                Percentage = (double)nudPercent.Value,
                FixedAmount = nudFixedAmount.Value,
                Description = txtDescription.Text.Trim(),
                IsActive = chkIsActive.Checked
            };

            var res = _editingDiscountId > 0
                ? await _enrollmentService.UpdateDiscountAsync(dto)
                : await _enrollmentService.CreateDiscountAsync(dto);

            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                await LoadDiscountsAsync();
                ResetForm();
            }
            else
            {
                AppDialog.ShowWarning(this, "Thông báo", res.Message);
            }
        };

        btnDelete.Click += async (s, e) =>
        {
            if (_editingDiscountId <= 0) return;
            if (AppDialog.ShowConfirm(this, "Xóa mã giảm giá",
                $"Bạn có chắc chắn muốn xóa mã giảm giá '{txtCode.Text.Trim()}' không?", "Xóa", "Hủy") != DialogResult.OK)
                return;

            var res = await _enrollmentService.DeleteDiscountAsync(_editingDiscountId);
            if (res.Success)
            {
                AppDialog.ShowSuccess(this, "Thành công", res.Message);
                await LoadDiscountsAsync();
                ResetForm();
            }
            else
            {
                AppDialog.ShowWarning(this, "Thông báo", res.Message);
            }
        };
    }
}
