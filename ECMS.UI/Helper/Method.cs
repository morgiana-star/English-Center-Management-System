using System.Windows.Forms;
namespace ECMS.UI.Helper;




public partial class Method : UserControl
{
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