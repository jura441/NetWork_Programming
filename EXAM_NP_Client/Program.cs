using System.Net.Sockets;
using System.Net;
using System.Text;

namespace EXAM_NP_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            try
            {
                Console.WriteLine("Добро пожаловать" );
                Console.WriteLine("Введите Поехали! для подключения к серверу.");
                command = Console.ReadLine();
                if (command == "Поехали!")
                {
                    IPEndPoint serverPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
                    Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    clientSocket.Connect(serverPoint);
                    while (true)
                    {
                        if (clientSocket.Connected)
                        {
                           
                            string message = Console.ReadLine();
                           
                           
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}