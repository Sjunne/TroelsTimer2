using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Exercise3._1_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client..");
            
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();
            
            Thread thread = new Thread(() => ListenToServer(stream));
            thread.Start();

            string readLine = "";
            while (!readLine.Equals("exit"))
            {
                readLine = Console.ReadLine();

                byte[] dataToServer = Encoding.ASCII.GetBytes(readLine);
                stream.Write(dataToServer, 0, dataToServer.Length);
            }
            stream.Close();
            client.Close();
        }

        private static void ListenToServer(NetworkStream stream)
        {
            while (true)
            {
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);

                Console.WriteLine(response);
            }
        }
    }
}