using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_Forms
{
    public partial class Form1 : Form
    {
        Socket server;
        IPEndPoint point;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
        }

        private void btn_startserver_Click(object sender, EventArgs e)
        {
            if(server == null)
                return;
            server.Bind(point);
            server.Listen(100);
           tmr_refreshConnection.Start();
            
        }

        private void btn_stopserver_Click(object sender, EventArgs e)
        {
           tmr_refreshConnection.Stop();
        }

        private void tmr_refreshConnection_Tick(object sender, EventArgs e)
        {
            try
            {
                server.Bind(point);
                server.Listen(100);
                

                server.BeginAccept(ServerAcceptDelegate, server);

                    /*ArraySegment<byte> buffer = new ArraySegment<byte>();
                    client.SendAsync(buffer, SocketFlags.None);
                    Thread.Sleep(100);*/
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ServerAcceptDelegate(IAsyncResult result)
        {
            if (result != null)
            {
                Socket serv = (Socket)result.AsyncState;
                Socket clientsocket = server.EndAccept(result);
                IAsyncResult updateText = rtb_clients.BeginInvoke(RichTextBoxOutputDelegate, clientsocket.RemoteEndPoint.ToString());
                rtb_clients.EndInvoke(updateText);
                
                clientsocket.Send(Encoding.UTF8.GetBytes("Успешное подключение."));
                clientsocket.Shutdown(SocketShutdown.Send);
                clientsocket.Close();
                serv.BeginAccept(ServerAcceptDelegate, serv);
            }
        }
        void RichTextBoxOutputDelegate(object obj)
        {

        }
    }
}