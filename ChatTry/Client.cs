using System;
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
    class Client : ClientBase
    {
        public Client()
        :base(new TcpClient())
        {
            RegisterHandler<MessageRequest>(Requests.Message, m => MessageReceived?.Invoke(m));
            RegisterHandler<ConnectionOkRequest>(Requests.ConnectionOk, c => ConnectingAccess?.Invoke(c));
        }

        public bool Start (IPAddress address)
        {
            client.Connect(address, 8080);
            var stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);
           
            new Thread(WorkWithClient).Start();
            return (Requests)reader.ReadInt32() == Requests.ConnectionOk;           
        }

        public void SendMessage (string user, string message)
        {
            writer.Write((int)Requests.Message);
            writer.Write(user);
            writer.Write(message);            
            writer.Flush();
        }

        public event Action<MessageRequest> MessageReceived;

        public event Action<ConnectionOkRequest> ConnectingAccess;
    }
}
