using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Exprorer_2
{
    [Serializable]
    public class User : UserSettings
    {
        public string login;
        private string password;

        public User() { }
        public User(string login, string pass)
        {
            this.login = login;
            //this.password = GetHashString(pass);
            this.password = pass;
        }
        public void SetExplorerLabel(string new_label)
        {
            this.explorer_label = new_label;
        }

        public void EncryptPass()
        {
            StringBuilder encrypted = new StringBuilder(this.password.Length);

            foreach (char el in password)
                encrypted.Append((char)(el ^ 120));

            password = encrypted.ToString();
        }

        public void DecryptPass()
        {
            StringBuilder decrypted = new StringBuilder(password.Length);

            foreach (char el in password.ToString())
                decrypted.Append((char)(el ^ 120));

            password = decrypted.ToString();
        }
        public bool CheckPassword(string pass)
        {
            if (pass == password)
            {
                return true;
            }
            return false;
        }
        /*
        public bool CheckPassword(string pass)
        {
            if (GetHashString(pass) == password)
            {
                return true;
            }
            return false;
        }
        
        private string GetHashString(string s)
        {
            //переводим строку в байт-массив  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средств шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
             
            return hash;
        }
        */
    }
}
