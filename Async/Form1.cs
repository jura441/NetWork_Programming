using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Async
{
    public partial class Клиент : Form
    {
        Socket? client;
        IPEndPoint? point;
        public Клиент()
        {
            InitializeComponent();
        }

       private void btn_connectServer(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
                client.BeginConnect(point, (IAsyncResult result) =>
               {
                   client.EndConnect(result);
               }, client);
                if (client.Connected)
                {
                byte[] buffer = new byte[1024];
                int answerServer = client.Receive(buffer);
                while (answerServer > 0)
                {
                    rtb_Chat.Text += Encoding.UTF8.GetString(buffer);
                    answerServer = client.Receive(buffer);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_SwitchContact_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
        }
    }
}