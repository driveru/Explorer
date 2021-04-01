using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exprorer_2
{
    public partial class FindBookForm : Form
    {
        public FindBookForm()
        {
            InitializeComponent();
        }
        
        public int GetBooksCnt()
        {
            return int.Parse(BooksCountTextBox.Text);
        }
        public string GetQuery()
        {
            return QueryTextBox.Text;
        }
    }
}
