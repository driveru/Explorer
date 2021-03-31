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
    public partial class InputNewName : Form
    {
        public InputNewName(string text)
        {
            InitializeComponent();
            Label.Text = text;
        }
        public string GetNewName()
        {
            return NewNameTextBox.Text;
        }
    }
}
