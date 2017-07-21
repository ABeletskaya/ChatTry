using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatTry
{
    class JoinChatControl
    {
        private string _login;
        private string _password;

        public JoinChatControl(string login, string password)
        {
            _login = login;
            _password = password;
        }

        private Dictionary<string, string> users;
        IEnumerable<string[]> query = File.ReadAllLines("loginPassword.txt").Select(f => f.Split(';'));
        public string LoginPasswordCorrect()
        {
            users = new Dictionary<string, string>(query.ToDictionary(k => k[0], v => v[1]));
            string validPassword;
            if (users.TryGetValue(_login, out validPassword))
            {
                if (validPassword == _password)
                    return Responses.AccessGranted;
                else
                    return Responses.InvalidPassword;
            }
            else
                return Responses.InvalidLogin;
        }

        public string Register()
        {
            if ((_login + _password).Contains(';')) // символ ';' - недопустим, т.к. в файле логин и пароль хранятся в виде: логин;пароль
                return Responses.IncorrectCharacters;
            else
            {
                users = new Dictionary<string, string>(query.ToDictionary(k => k[0], v => v[1]));

                if (users.ContainsKey(_login))
                    return Responses.InvalidCheckIn;
                else
                {
                    using (System.IO.StreamWriter file =
                          new System.IO.StreamWriter(@"loginPassword.txt", true))
                    {
                        file.WriteLine($@"{_login};{_password}");
                    }
                }
                return Responses.AccessGranted;
            }
        }
    }
}
