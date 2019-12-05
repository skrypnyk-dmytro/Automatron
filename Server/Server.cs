using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        public List<SocketT2h> __ClientSockets { get; set; }
        private byte[] _buffer;
        public Socket _serverSocket { get; }
        private AsyncCallback _acceptCalback;

        public Server(AsyncCallback acceptCalback)
        {
            __ClientSockets = new List<SocketT2h>();
             _buffer = new byte[1024];
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _acceptCalback = acceptCalback;
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 11011));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(_acceptCalback, null);
        }

        public class SocketT2h
        {
            public Socket _Socket { get; set; }
            public string _Name { get; set; }
            public SocketT2h(Socket socket)
            {
                this._Socket = socket;
            }
        }
    }
}
