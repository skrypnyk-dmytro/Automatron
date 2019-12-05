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
        Server server;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
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
            server = new Server(AppceptCallback);
            statusLbl.Text = "Server is started";
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            //Socket socket = _serverSocket.EndAccept(ar);
            //__ClientSockets.Add(new SocketT2h(socket));
            

           // statusLbl.Text = __ClientSockets.Count.ToString() + " client connected. . .";
           // socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
           // _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);

            server.__ClientSockets.Add(new Server.SocketT2h(server._serverSocket.EndAccept(ar)));
            clientsQtyLbl.Text = server.__ClientSockets.Count.ToString();


        }

    }
}
