using System.Collections;
using System.Windows.Forms;

namespace Exprorer_2
{
    abstract class ListViewColumnComparer : IComparer
    {
        protected int column_index;
        public ListViewColumnComparer(int column_index)
        {
            this.column_index = column_index;
        }
        abstract public int Compare(object x, object y);
    }
}
