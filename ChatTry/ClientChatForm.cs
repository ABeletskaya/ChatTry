using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTry
{
    public partial class ClientChatForm : Form
    {
        private string _IPAddress;
        private string _login;
        private Client _client;


        public ClientChatForm()
        {
            InitializeComponent();
            _client = new Client();
            _client.MessageReceived += Client_MessageReceived;
            gbSignIn.Enabled = false;
            gbChat.Enabled = false;            
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            string IP = tbIP.Text;
            Regex regex = new Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])\.(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])\.(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])\.(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])$");
            MatchCollection matches = regex.Matches(IP);

            if (matches.Count == 1)
            {
                gbSignIn.Enabled = true;
                gbServerConnect.Enabled = false;
                _IPAddress = IP;
            }
            else
                MessageBox.Show(Responses.IncorrectIP);            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;         
            JoinChatControl control = new JoinChatControl(login, password);

            string response;
            if (chbRegister.Checked)
                response = control.Register();
            else
                response = control.LoginPasswordCorrect();

            if (response == Responses.AccessGranted)
            {
                _login = login;
                _client.Start(IPAddress.Parse(_IPAddress));
                gbChat.Enabled = true;
                gbSignIn.Enabled = false;
            }
            else
                MessageBox.Show(response);            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _client.SendMessage(_login, tbMessage.Text);
        }

        private void Client_MessageReceived(MessageRequest obj)
        {
            string date = DateTime.Now.ToShortDateString().ToString();
            string time = DateTime.Now.ToShortTimeString().ToString();
            // Выполняет указанный делегат асинхронно 
            //с указанными аргументами в потоке, 
            //в котором был создан базовый дескриптор элемента управления.
            BeginInvoke(new Action(() => {
                tbChat.AppendText("\r\n" + obj.User +$" ({date} - {time}) :> " + obj.Message + $@"

");
            }), new object[0]);
        }
    }
}
