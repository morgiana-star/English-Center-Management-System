using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Helper cấu hình chuẩn giao diện bảng dữ liệu phẳng hiện đại cho DataGridView
/// Loại bỏ viền 3D cũ, hỗ trợ Zebra-striping và độ tương phản cao
/// </summary>
public static class ModernGridHelper
{
    public static void ApplyStyle(DataGridView dgv)
    {
        dgv.BackgroundColor = Color.White;
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = Color.FromArgb(241, 245, 249);
        dgv.RowHeadersVisible = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.RowTemplate.Height = 38;

        // Tiêu đề cột (Header)
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersHeight = 44;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.Primary;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = ThemeColors.FontBodyBold;
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 0, 0);

        // Hàng dữ liệu thường
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = ThemeColors.TextPrimary;
        dgv.DefaultCellStyle.Font = ThemeColors.FontBody;
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255); // Indigo 50
        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 46, 129); // Indigo 900
        dgv.DefaultCellStyle.Padding = new Padding(12, 0, 0, 0);

        // Zebra Striping (Hàng xen kẽ)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252); // Slate 50
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = ThemeColors.TextPrimary;
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 46, 129);
    }
    public static class DataGridViewHelper
    {
        public static void AddTextColumn(
            DataGridView dgv,
            string name,
            string header,
            bool readOnly = true)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = readOnly
            });
        }
    }
}
