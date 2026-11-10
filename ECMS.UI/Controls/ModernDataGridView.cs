using System.Drawing;
using System.Windows.Forms;

namespace ECMS.UI.Controls;

/// <summary>
/// Bảng dữ liệu DataGridView chuẩn Modern Enterprise (Deep Navy Header, Zebra Striping).
/// Kéo thả từ Toolbox ra giao diện sẽ tự động được làm đẹp ngay lập tức.
/// </summary>
public class ModernDataGridView : DataGridView
{
    public ModernDataGridView()
    {
        Size = new Size(600, 300);
        ModernGridHelper.ApplyStyle(this);
    }
}
