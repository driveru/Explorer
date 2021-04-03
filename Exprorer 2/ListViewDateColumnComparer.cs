using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exprorer_2
{
    class ListViewDateColumnComparer : ListViewColumnComparer
    {
        public ListViewDateColumnComparer(int column_index) : base(column_index) { }
        public override int Compare(object x, object y)
        {
            try
            {
                string[] x_date = ((ListViewItem)x).SubItems[column_index].Text.Split('.');
                if (x_date.Length < 3) { x_date = new[] { "1", x_date[0], x_date[1]  }; }
                DateTime x_dateTime = new DateTime(int.Parse(x_date[2]), int.Parse(x_date[1]), int.Parse(x_date[0]));

                string[] y_date = ((ListViewItem)y).SubItems[column_index].Text.Split('.');
                if (y_date.Length < 3) { y_date = new[] { "1", y_date[0], y_date[1] }; }
                DateTime y_dateTime = new DateTime(int.Parse(y_date[2]), int.Parse(y_date[1]), int.Parse(y_date[0]));

                return DateTime.Compare(x_dateTime, y_dateTime);
            }
            catch (Exception) { return -1; }
        }
    }
}
