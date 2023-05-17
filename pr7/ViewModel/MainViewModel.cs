using pr7.View;
using pr7.ViewModel.Helpers;
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
            ToGame = new BindableCommand(_ => Create_());
        }

        public ICommand ToGame { get; }

        private void Create_()
        {
            if (UserName == "")
            {
                MessageBox.Show("Веди ip");
            }
            else
            {
                
                GameViewModel.user = UserName;
                Game game = new Game();
                game.Show();

            }
        }

        
    }
}
