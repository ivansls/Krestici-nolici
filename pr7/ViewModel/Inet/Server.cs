using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pr7.View;
using System.Security.Cryptography.Pkcs;

namespace pr7.ViewModel.Inet
{
    
    internal class Server
    {
        private Socket socket;
        private List<Socket> clients = new List<Socket>();
       
        public void Create()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            socket.Listen(100);
            ListenToClients();
        }


        private async Task ListenToClients()
        {
            while(true)
            {
                var client = await socket.AcceptAsync();
                clients.Add(client);
                SendMessage(client, client.RemoteEndPoint.ToString());
                ReceiveMessage(client);
            }
        }

        private async Task ReceiveMessage(Socket client)
        {
            Game game = new Game();
            while (true) 
            {
                byte[] bytes = new byte[1024];
                await client.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                game.list.Items.Add(message);
                game.User.Content = message;
                MessageBox.Show(message);
                foreach(var item in clients)
                {
                    SendMessage(item, message);
                }
            }
        }

        private async Task SendMessage(Socket client, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(bytes, SocketFlags.None);
        }

    }
}
