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

        if (_items == null || _items.Count == 0) return;

        double maxVal = 0;
        foreach (var it in _items)
        {
            if (it.Value > maxVal) maxVal = it.Value;
        }
        if (maxVal <= 0) maxVal = 1;

        int count = _items.Count;
        int barAreaWidth = Width - 20;
        int barAreaHeight = Height - 45; // top value label + bottom axis label
        int barWidth = Math.Min(28, (barAreaWidth / count) - 12);
        int slotWidth = barAreaWidth / count;

        for (int i = 0; i < count; i++)
        {
            var item = _items[i];
            int slotCenterX = 10 + (i * slotWidth) + (slotWidth / 2);
            int barX = slotCenterX - (barWidth / 2);

            int barH = (int)((item.Value / maxVal) * barAreaHeight);
            if (barH < 4) barH = 4;
            int barY = 22 + (barAreaHeight - barH);

            var barRect = new Rectangle(barX, barY, barWidth, barH);
            Color c = item.IsHighlight ? HighlightBarColor : NormalBarColor;

            using (var brush = new SolidBrush(c))
            {
                g.FillRectangle(brush, barRect);
            }

            // Giá trị trên đầu cột
            TextRenderer.DrawText(
                g,
                item.ValueDisplay,
                FigmaTheme.FontHelper,
                new Point(slotCenterX, barY - 14),
                FigmaTheme.TextSecondary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom);

            // Nhãn trục X dưới đáy cột
            TextRenderer.DrawText(
                g,
                item.Label,
                FigmaTheme.FontHelper,
                new Point(slotCenterX, Height - 16),
                FigmaTheme.TextSecondary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Top);
        }
    }
}
