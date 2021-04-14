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
    public partial class UserSettingsForm : Form
    {
        private User user;
        public UserSettingsForm(User user)
        {
            InitializeComponent();
            this.Text = user.login;
            this.textBox1.Text = user.explorer_label;
            this.user = user;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            user.SetExplorerLabel(textBox1.Text);   
        }
    }
}
