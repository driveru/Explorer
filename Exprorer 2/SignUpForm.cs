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
    public partial class SignUpForm : Form
    {
        private Users users;
        private string users_data_path;
        public SignUpForm()
        {
            InitializeComponent();
            users_data_path = Directory.GetCurrentDirectory();
            users_data_path = Path.Combine(users_data_path, "users.dat");
            try
            {
                using (var fs = File.OpenRead(users_data_path))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            }
            catch (Exception) { users = new Users(); }
            /*
            if (File.Exists(users_data_path))
                using (var fs = File.OpenRead(users_data_path))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            else
                users = new Users();
            */
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                //регстрация нового юзера
                users.SignUp(LoginTextBox.Text, PasswordTextBox.Text);
                //сохраняем юзеров в файл
                using (var fs = File.OpenWrite(users_data_path))
                    new BinaryFormatter().Serialize(fs, users);

                MessageBox.Show("You signed up successfully. Now you'll try to sign in !");
            }
            else 
            { 
                MessageBox.Show("Passwords don't match !"); 
            }
            this.Dispose();
        }
    }
}
