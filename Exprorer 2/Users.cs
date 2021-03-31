using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
