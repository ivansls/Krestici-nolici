using pr7.ViewModel.Helpers;
using pr7.ViewModel.Logic_Helper;
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
        
        public static string user { get; set; } = "";

        public static string Answer = "";
        public static string Answer1 = "";
        public static string Answer2 = "";
        public static string Answer3 = "";
        public static string Answer4 = "";
        public static string Answer5 = "";
        public static string Answer6 = "";
        public static string Answer7 = "";
        public static string Answer8 = "";

        public string answer
        {
            get { return Answer; }
            set
            {
                Answer = value;
                OnPropertyChenged();
            }
        }

        public string answer1
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer2
        {
            get { return Answer2; }
            set
            {
                Answer2 = value;
                OnPropertyChenged();
            }
        }

        public string answer3
        {
            get { return Answer3; }
            set
            {
                Answer3 = value;
                OnPropertyChenged();
            }
        }

        public string answer4
        {
            get { return Answer4; }
            set
            {
                Answer4 = value;
                OnPropertyChenged();
            }
        }

        public string answer5
        {
            get { return Answer5; }
            set
            {
                Answer5 = value;
                OnPropertyChenged();
            }
        }

        public string answer6
        {
            get { return Answer6; }
            set
            {
                Answer6 = value;
                OnPropertyChenged();
            }
        }

        public string answer7
        {
            get { return Answer7; }
            set
            {
                Answer7 = value;
                OnPropertyChenged();
            }
        }

        public string answer8
        {
            get { return Answer8; }
            set
            {
                Answer8 = value;
                OnPropertyChenged();
            }
        }



        public GameViewModel()
        {
            User_ = new BindableCommand(_ => Connect_());
            but1 = new BindableCommand(_ => but1_());
            but2 = new BindableCommand(_ => but2_());
            but3 = new BindableCommand(_ => but3_());
            but4 = new BindableCommand(_ => but4_());
            but5 = new BindableCommand(_ => but5_());
            but6 = new BindableCommand(_ => but6_());
            but7 = new BindableCommand(_ => but7_());
            but8 = new BindableCommand(_ => but8_());
            but9 = new BindableCommand(_ => but9_());
            start = new BindableCommand(_ => start_());

        }

        public ICommand User_ { get; }
        public ICommand but1 { get; }

        public ICommand but2 { get; }

        public ICommand but3 { get; }

        public ICommand but4 { get; }

        public ICommand but5 { get; }

        public ICommand but6 { get; }

        public ICommand but7 { get; }

        public ICommand but8 { get; }
        public ICommand but9 { get; }

        public ICommand start { get; }

        private void Connect_()
        {
            
        }

        private void but1_()
        {
            answer = "X";
        }

        private void but2_()
        {
            answer1 = "X";
        }

        private void but3_()
        {
            answer2 = "X";
        }

        private void but4_()
        {
            answer3 = "X";
        }

        private void but5_()
        {
            answer4 = "X";
        }

        private void but6_()
        {
            answer5 = "X";
        }
        private void but7_()
        {
            answer6 = "X";
        }
        private void but8_()
        {
            answer7 = "X";
        }

        private void but9_()
        {
            answer8 = "X";
        }


        private void start_()
        {
            MessageBox.Show("1");
            Game_Function game = new Game_Function();
            game.sstart();
        }


    }
}
