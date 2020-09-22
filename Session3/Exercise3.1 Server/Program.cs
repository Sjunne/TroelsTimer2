using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Exercise3._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Starting server..");

            IPAddress ip = IPAddress.Parse("192.168.1.141");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();
            
            Console.WriteLine("Server started..");
            List<SocketHandler> clientList = new List<SocketHandler>();
            

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client connected..");
                SocketHandler sh = new SocketHandler();
                clientList.Add(sh);
                Thread thread = new Thread(() => sh.HandleClient(client, clientList));
                
                thread.Start();
            }
            

           
        }

       
    }
}