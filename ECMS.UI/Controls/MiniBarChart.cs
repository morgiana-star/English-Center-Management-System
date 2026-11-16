using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

public class BarItem
{
    public string Label { get; set; } = string.Empty;
    public double Value { get; set; }
    public string ValueDisplay { get; set; } = string.Empty;
    public bool IsHighlight { get; set; } = false;

    public BarItem()
    {
    }

    public BarItem(string label, double value, string? valueDisplay = null, bool isHighlight = false)
    {
        Label = label;
        Value = value;
        ValueDisplay = valueDisplay ?? value.ToString("G");
        IsHighlight = isHighlight;
    }
}

/// <summary>
/// Biểu đồ cột mini phẳng trực quan theo Image 5 trong Figma
/// </summary>
public class MiniBarChart : Control
{
    private List<BarItem> _items = new();

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public List<BarItem> Items
    {
        get => _items;
        set
        {
            _items = value;
            Invalidate();
        }
    }

    public Color NormalBarColor { get; set; } = ColorTranslator.FromHtml("#93C5FD"); // Blue 300
    public Color HighlightBarColor { get; set; } = FigmaTheme.Primary;              // Blue 600

    public MiniBarChart()
    {
        DoubleBuffered = true;
        BackColor = Color.White;
        Size = new Size(300, 140);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var items = _items;
        if ((items == null || items.Count == 0) && (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime))
        {
            items = new List<BarItem>
            {
                new("T1", 80, "80"),
                new("T2", 120, "120"),
                new("T3", 160, "160", isHighlight: true)
            };
        }

        if (items == null || items.Count == 0) return;

        double maxVal = 0;
        foreach (var it in items)
        {
            if (it.Value > maxVal) maxVal = it.Value;
        }
        if (maxVal <= 0) maxVal = 1;

        int count = items.Count;
        int paddingLeft = 20;
        int paddingRight = 20;
        int paddingTop = 28;
        int paddingBottom = 26;

        int barAreaWidth = Width - (paddingLeft + paddingRight);
        int barAreaHeight = Height - (paddingTop + paddingBottom);
        if (barAreaHeight < 20) barAreaHeight = 20;
        if (barAreaWidth < 20) barAreaWidth = 20;

        int slotWidth = barAreaWidth / count;
        int barWidth = Math.Clamp(slotWidth - 10, 10, 36);

        for (int i = 0; i < count; i++)
        {
            var item = items[i];
            int slotCenterX = paddingLeft + (i * slotWidth) + (slotWidth / 2);
            int barX = slotCenterX - (barWidth / 2);
            barX = Math.Max(paddingLeft / 2, Math.Min(Width - barWidth - (paddingRight / 2), barX));

            int barH = (int)((item.Value / maxVal) * barAreaHeight);
            if (barH < 6) barH = 6;
            int barY = paddingTop + (barAreaHeight - barH);

            var barRect = new Rectangle(barX, barY, barWidth, barH);
            Color c = item.IsHighlight ? HighlightBarColor : NormalBarColor;

            using (var brush = new SolidBrush(c))
            {
                g.FillRectangle(brush, barRect);
            }

            // Giá trị trên đầu cột (đảm bảo không tràn viền trên)
            var topTextRect = new Rectangle(slotCenterX - 35, Math.Max(4, barY - 18), 70, 16);
            TextRenderer.DrawText(
                g,
                item.ValueDisplay,
                FigmaTheme.FontHelper,
                topTextRect,
                item.IsHighlight ? HighlightBarColor : FigmaTheme.TextSecondary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // Nhãn trục X dưới đáy cột (đảm bảo không tràn viền dưới)
            var btmTextRect = new Rectangle(slotCenterX - 35, paddingTop + barAreaHeight + 4, 70, 18);
            TextRenderer.DrawText(
                g,
                item.Label,
                FigmaTheme.FontHelper,
                btmTextRect,
                FigmaTheme.TextSecondary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
