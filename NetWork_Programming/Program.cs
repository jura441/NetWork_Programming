﻿using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetWork_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
            DnsEndPoint dnsEndPoint = new DnsEndPoint("www.gogle.com", 80);
            socket.Connect(dnsEndPoint);
            try
            {
                if (socket.Connected)
                {
                    byte[] buffer = new byte[1024];
                    string sender = "GET\r\n";
                    socket.Send(Encoding.ASCII.GetBytes(sender));
                    //int answer = socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    int c;
                    string ans;
                    do
                    {
                        c = socket.Receive(buffer);
                        ans = Encoding.ASCII.GetString(buffer);
                        Console.WriteLine("Подключение было успешным.\n" + ans);
                    }
                    while (c > 0);
                }
            }
            catch(Exception ex)
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