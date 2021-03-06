﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatTry
{    
    class Server
    {
        private TcpListener listener;
        private List<ServerClient> clients = new List<ServerClient>();

        public Server()
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
        }

        public IEnumerable<ServerClient> Clients
        {
            get
            {
                return clients;
            }
        }

        public async void Start()
        {
            listener.Start();

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                ServerClient ourClient = new ServerClient(this, client);
                ourClient.Start();
                clients.Add(ourClient);
            }
        }
    }
}
