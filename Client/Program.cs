using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;

namespace Client
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            
        }
    class MyClass
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        IPEndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
        int _counter = 0;

        public MyClass(Socket socket, IPEndPoint point, int counter)
        {
            _counter = counter;
        }
    }

        private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            try
            {

                socket.Connect(point);
                byte[] buffer = new byte[1024];
                int c;
                do
                {
                    c = socket.Receive(buffer);
                    Console.WriteLine(Encoding.UTF8.GetString(buffer));
                }
                while (c > 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }


}