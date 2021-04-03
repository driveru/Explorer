using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exprorer_2
{
    class ListViewDoubleColumnComparer : ListViewColumnComparer
    {
        public ListViewDoubleColumnComparer(int column_index) : base(column_index) { }
        public override int Compare(object x, object y)
        {
            try
            {
                Regex rg = new Regex(@"(?<=\$)?\d+.?\d+\s?(?=.*)");
                double x_num = double.Parse(rg.Match(((ListViewItem)x).SubItems[column_index].Text).Value);
                double y_num = double.Parse(rg.Match(((ListViewItem)y).SubItems[column_index].Text).Value);
                return x_num.CompareTo(y_num);
            }
            catch (Exception) 
            {
                return 1;  
            }
        }
    }
}
