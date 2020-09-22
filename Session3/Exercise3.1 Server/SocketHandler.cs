using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Exercise3._1
{
    public class SocketHandler
    {
        private NetworkStream stream;

        public void HandleClient(TcpClient client, List<SocketHandler> clientList)
        {
            stream = client.GetStream();
    
            string s = "";
            while (!s.Equals("exit"))
            {
                //Read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);


                for (int i = 0; i < clientList.Count; i++)
                {
                    //respond
                    byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                    clientList[i].stream.Write(dataToClient, 0 , dataToClient.Length);
                    //stream.Write(dataToClient, 0, dataToClient.Length);
                }
            }

            //close
            client.Close();
        }
    }
}