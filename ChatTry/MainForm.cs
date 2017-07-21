using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChatTry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClientChatForm chat = new ClientChatForm();
            chat.ShowDialog();
            Close(); 
        }
       
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            Server server = new Server();
            server.Start();
        }
    }
}
