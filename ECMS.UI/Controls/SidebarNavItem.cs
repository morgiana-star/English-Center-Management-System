using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Nút điều hướng Sidebar theo phong cách Figma (Active indicator bên trái, hover, màu sắc).
/// </summary>
public class SidebarNavItem : Control
{
    public string Group { get; }
    public string Title { get; }
    public string Scope { get; }

    private bool _isActive;
    public bool IsActive
    {
        get => _isActive;
        set
        {
            _isActive = value;
            Invalidate();
        }
    }

    private bool _isHovered;

    public SidebarNavItem(string group, string title, string scope)
    {
        Group = group;
        Title = title;
        Scope = scope;
        Height = 32;
        Cursor = Cursors.Hand;
        DoubleBuffered = true;

        MouseEnter += (s, e) => { _isHovered = true; Invalidate(); };
        MouseLeave += (s, e) => { _isHovered = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;

        // Background
        if (IsActive)
        {
            using var bgBrush = new SolidBrush(Color.FromArgb(239, 246, 255)); // #EFF6FF
            g.FillRectangle(bgBrush, 0, 0, Width, Height);

            // Left active bar (3px)
            using var activeBarBrush = new SolidBrush(FigmaTheme.Primary);
            g.FillRectangle(activeBarBrush, 0, 0, 3, Height);
        }
        else if (_isHovered)
        {
            using var hoverBrush = new SolidBrush(Color.FromArgb(248, 250, 252));
            g.FillRectangle(hoverBrush, 0, 0, Width, Height);
        }

        // Text & Dot
        Font font = IsActive ? new Font("Segoe UI", 9.2f, FontStyle.Bold) : new Font("Segoe UI", 9.2f, FontStyle.Regular);
        Color textColor = IsActive ? FigmaTheme.Primary : (_isHovered ? FigmaTheme.TextPrimary : FigmaTheme.TextSecondary);

        using var textBrush = new SolidBrush(textColor);
        var stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };

        // If active, draw bullet dot or text
        string displayText = IsActive ? $"•  {Title}" : Title;
        var textRect = new Rectangle(20, 0, Width - 24, Height);
        g.DrawString(displayText, font, textBrush, textRect, stringFormat);
    }
}
