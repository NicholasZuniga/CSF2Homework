using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        private string _username;
        private string _password;


        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

            public Login() { }

        public override string ToString()
        {
            return string.Format("Username: {0}\nPassword: {1}", UserName, Password);
        }
    }
}
