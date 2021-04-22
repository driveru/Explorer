using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exprorer_2
{
    public partial class SignInForm : Form
    {
        private Users users;
        private string users_data_path;
        private User authorized_user; 
        public SignInForm()
        {
            InitializeComponent();
            users_data_path = Directory.GetCurrentDirectory();
            users_data_path = Path.Combine(users_data_path, "users.txt");

            if (File.Exists(users_data_path))
                using (var fs = File.OpenRead(users_data_path))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            else
                users = new Users();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                authorized_user = users.SignIn(LoginTextBox.Text, PasswordTextBox.Text);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            Close();
        }
        public User GetUser()
        {
            return authorized_user;
        }
    }
}
