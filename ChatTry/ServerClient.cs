using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatTry
{
    class ServerClient : ClientBase
    {
        private Server server;

        public ServerClient(Server server, TcpClient client) : base(client)
        {
            this.client = client;
            this.server = server;

            RegisterHandler<MessageRequest>(Requests.Message, ProcessMessage);
        }

        private void ProcessMessage(MessageRequest request)
        {
            foreach (var c in server.Clients)
            {
                c.SendMessage(request.User, request.Message);
            }
        }

        internal void Start()
        {
            new Thread(() => ClientProc(client)).Start();
        }

        private void ClientProc(TcpClient client)
        {
            using (client)
            {
                using (var stream = client.GetStream())
                {
                    reader = new BinaryReader(stream);
                    writer = new BinaryWriter(stream);

                    writer.Write((int)Requests.ConnectionOk);
                    writer.Flush();

                    WorkWithClient();
                }
            }
        }

        private void SendMessage(string login, string message)
        {
            writer.Write((int)Requests.Message);
            writer.Write(login);
            writer.Write(message);
            writer.Flush();
        }
    }
}
