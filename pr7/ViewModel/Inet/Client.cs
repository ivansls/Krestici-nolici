using pr7.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace pr7.ViewModel.Inet
{
    internal class Client
    {
        private Socket socket;


        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.ConnectAsync("127.0.0.1", 8888);

            SendMessage(socket, "xuuuuu");
            ReceiveMessage(socket);
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
                MessageBox.Show(message);
            }
        }


        private async Task SendMessage(Socket client, string message)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(bytes, SocketFlags.None);
        }


    }
}
