using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exprorer_2
{
    class ListViewTextColumnComparer : ListViewColumnComparer
    {
        public ListViewTextColumnComparer(int column_index) : base(column_index) { }
        public override int Compare(object x, object y)
        {
            try
            {
                return string.Compare(((ListViewItem)x).SubItems[column_index].Text, ((ListViewItem)y).SubItems[column_index].Text);
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
