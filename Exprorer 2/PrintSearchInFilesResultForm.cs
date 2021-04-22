using System;
using System.Collections.Concurrent;
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
    public partial class PrintSearchInFilesResultForm : Form
    {
        public PrintSearchInFilesResultForm(ConcurrentBag<string> to_print)
        {
            InitializeComponent();

            foreach (string s in to_print)
                richTextBox1.Text += s + '\n';               
        }
    }
}
