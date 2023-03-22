using System.Net;
using System.Net.Sockets;

namespace EXAM_NP_Server
{
    internal class Program
    {
         static void Main(string[] args)
            {
                try
                {
                    IPEndPoint serverPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
                    Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    serverSocket.Bind(serverPoint);
                    serverSocket.Listen(1000);

                    serverSocket.BeginAccept(AcceptConnectionCallback, serverSocket);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }

            static void AcceptConnectionCallback(IAsyncResult result)
            {
                if (result.AsyncState != null)
                {
                    byte[] data = new byte[1024];
                    Socket server = (Socket)result.AsyncState;
                    Socket client = server.EndAccept(result);
                    Console.WriteLine($"Произошло подключение: {client.RemoteEndPoint} в {DateTime.Now}");
                    server.BeginAccept(AcceptConnectionCallback, server);
                }

            }
        }
    }



