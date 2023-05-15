using pr7.View;
using pr7.ViewModel.Helpers;
using pr7.ViewModel.Inet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace pr7.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        private static string UserName;

        private static string ip;

        private static bool IsServer;

        public string _ipAdres
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChenged();
            }
        }

        public string _userName
        {
            get { return UserName; }
            set
            {
                UserName = value;
                OnPropertyChenged();
            }
        }

        public MainViewModel()
        {
            Create_Server = new BindableCommand(_ => Create_());
            Connect_Server = new BindableCommand(_ => Connect_());
        }

        public ICommand Create_Server { get; }
        public ICommand Connect_Server { get; }

        private void Create_()
        {
            if (ip == "")
            {
                MessageBox.Show("Веди ip");
            }
            else
            {
                IsServer = true;
                GameViewModel.name = UserName;
                GameViewModel.ip_ = ip;
                GameViewModel.isServer = IsServer;
                
                Game game = new Game();
                game.Show();

            }
        }

        private void Connect_()
        {
            if (UserName == "")
            {
                MessageBox.Show("Веди имя");
            }
            else
            {
                if (ip == "")
                {
                    MessageBox.Show("Веди ip");
                }
                else
                {
                    IsServer = false;
                    GameViewModel.name = UserName;
                    GameViewModel.ip_ = ip;
                    GameViewModel.isServer = IsServer;
                    //Client client = new Client();
                    Game game = new Game();
                    game.Show();
                   
                    
                }
            }
        }
    }
}
