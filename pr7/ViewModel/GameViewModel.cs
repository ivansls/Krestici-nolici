using pr7.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace pr7.ViewModel
{


    internal class GameViewModel : BindingHelper
    {
        public static string name,  ip_;
        public static bool isServer;


        public static List<string> users = new List<string>();



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

        public GameViewModel()
        {
            i_ = new BindableCommand(_ => Create_());
            User_ = new BindableCommand(_ => Connect_());
        }

        public ICommand i_ { get; }
        public ICommand User_ { get; }

        private void Create_()
        {
            MessageBox.Show("123");
            foreach (var user in users)
            {
                MessageBox.Show(user);
            }
        }
        private void Connect_()
        {
            MessageBox.Show("1234");
        }




    }
}
