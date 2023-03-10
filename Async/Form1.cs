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
                client.BeginConnect(point, (IAsyncResult result) => {
                    Socket clientAsync = (Socket)result.AsyncState;
                    if (clientAsync.Connected)
                    {
                        byte[] buffer = new byte[1024];
                        int answerServer = clientAsync.Receive(buffer);
                        while (answerServer > 0)
                        {
                            rtb_Chat.Text += Encoding.UTF8.GetString(buffer);
                            answerServer = clientAsync.Receive(buffer);
                        }
                    }
                    client.EndConnect(result);

                }, client);

             }
            catch(Exception ex) 
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

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);
            ArraySegment<byte> segment = new ArraySegment<byte>(buffer, 0, buffer.Length);
            client.SendAsync(segment, SocketFlags.None);
        }
    }
}