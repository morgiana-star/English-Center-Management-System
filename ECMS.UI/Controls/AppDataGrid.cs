using System;
using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public static class AppGridHelper
{
    public static void ApplyStyle(DataGridView dgv)
    {
        dgv.BackgroundColor = Color.White;
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = FigmaTheme.Border;
        dgv.RowHeadersVisible = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.RowTemplate.Height = 36;
        dgv.ScrollBars = ScrollBars.None;

        // Tiêu đề cột (Header) - Không bị bôi xanh khi chọn
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersHeight = 36;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8FAFC"); // Slate 50
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = FigmaTheme.TextSecondary;
        dgv.ColumnHeadersDefaultCellStyle.Font = FigmaTheme.FontLabel;
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 0, 0);
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F8FAFC");
        dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = FigmaTheme.TextSecondary;

        // Hàng dữ liệu
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = FigmaTheme.TextPrimary;
        dgv.DefaultCellStyle.Font = FigmaTheme.FontContent;
        dgv.DefaultCellStyle.SelectionBackColor = FigmaTheme.PrimaryLight; // #EFF6FF
        dgv.DefaultCellStyle.SelectionForeColor = FigmaTheme.Primary;      // #2563EB
        dgv.DefaultCellStyle.Padding = new Padding(12, 0, 0, 0);

        // Hàng xen kẽ nhẹ
        dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = FigmaTheme.TextPrimary;
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = FigmaTheme.PrimaryLight;
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = FigmaTheme.Primary;

        // Tránh tự động chọn ô đầu tiên gây viền xanh
        dgv.DataBindingComplete += (s, e) =>
        {
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        };
    }
}

public class AppDataGrid : DataGridView
{
    public AppDataGrid()
    {
        AppGridHelper.ApplyStyle(this);
        DoubleBuffered = true;
    }

    protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
    {
        base.OnRowsAdded(e);
        ClearSelection();
        CurrentCell = null;
    }
}
