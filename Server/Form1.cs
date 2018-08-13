using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{

    public partial class Form1 : Form
    {
        public List<SocketT2h> __ClientSockets { get; set; }
        private byte[] _buffer = new byte[1024];
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            __ClientSockets = new List<SocketT2h>();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {

        }

        private void startSrvBtn_Click(object sender, EventArgs e)
        {
            SetupServer();
        }
 
        private void SetupServer()
        {
            statusLbl.Text = "Setting up server . . .";
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 11011));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
            statusLbl.Text = "Server is started";
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = _serverSocket.EndAccept(ar);
            __ClientSockets.Add(new SocketT2h(socket));
            clientsQtyLbl.Text = __ClientSockets.Count.ToString();

            statusLbl.Text = __ClientSockets.Count.ToString() + " client connected. . .";
           // socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

    }
}
