using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exprorer_2
{
    [Serializable]
    class Users : List<User>
    {
        public User SignIn(string login, string password)
        {
            //ищем юзера по логину
            var user = this.FirstOrDefault(u => u.login == login);
            if (user == null) throw new Exception("User login is unknown.");

            //проверяем пароль
            if (!user.CheckPassword(password)) throw new Exception("User password is incorrect.");

            return user;
        }
        public void SignUp(string login, string password)
        {
            //проверяем, нет ли такого пользователя
            if (this.Any(u => u.login == login))
                throw new Exception("User with same name already exists.");

            Add(new User(login, password));
        }
        static public void SaveUsers(Users users)
        {
            string users_data_path = Directory.GetCurrentDirectory();
            users_data_path = Path.Combine(users_data_path, "users.txt");
            using (var fs = File.OpenWrite(users_data_path))
                new BinaryFormatter().Serialize(fs, users);
        }
        
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            foreach (User user in this)
                user.EncryptPass();
        }

        [OnSerialized]
        private void PrintSuccessMessage(StreamingContext context)
        {
            MessageBox.Show("You signed up successfully. Now you'll try to sign in !");
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (User user in this)
                user.DecryptPass();
        }
        
    }
}
