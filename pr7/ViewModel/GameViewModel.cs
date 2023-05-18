using pr7.View;
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


        public static List<string> id_ = new List<string> { };


        public static string Answer1 = "";
        public static string Answer2 = "";

        public string answer
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer1
        {
            get { return Answer2; }
            set
            {
                Answer2 = value;
                OnPropertyChenged();
            }
        }

        public string answer2
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer3
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer4
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer5
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer6
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer7
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }

        public string answer8
        {
            get { return Answer1; }
            set
            {
                Answer1 = value;
                OnPropertyChenged();
            }
        }


        public static string enable1 = "false";


        public string Enable1
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable2
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }


        public string Enable3
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable4
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable5
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable6
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable7
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable8
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }

        public string Enable9
        {
            get { return enable1; }
            set
            {
                enable1 = value;
                OnPropertyChenged();
            }
        }


        public GameViewModel()
        {
            User_ = new BindableCommand(_ => Connect_());
            Robot_ = new BindableCommand(_ => Robot());
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

        public ICommand Robot_ { get; }
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
           
            //MessageBox.Show("User");
            Enable1 = "true";
            Enable2 = "true";
            Enable3 = "true";
            Enable4 = "true";
            Enable5 = "true";
            Enable6 = "true";
            Enable7 = "true";
            Enable8 = "true";
            Enable9 = "true";
        }

        private void Robot()
        {
            Game_Function g = new Game_Function();
            int a = g.Random_();
            MessageBox.Show(a.ToString());
        }

        private void but1_()
        {
            answer = "X";
            id_.Add("1");
            Enable1 = "false";
            Robot();
        }

        private void but2_()
        {
            answer1 = "X";
            id_.Add("2");
            Enable2 = "false";
        }

        private void but3_()
        {
            answer2 = "X";
            id_.Add("3");
            Enable3 = "false";
        }

        private void but4_()
        {
            answer3 = "X";
            id_.Add("4");
            Enable4 = "false";
        }

        private void but5_()
        {
            answer4 = "X";
            id_.Add("5");
            Enable5 = "false";
        }

        private void but6_()
        {
            answer5 = "X";
            id_.Add("6");
            Enable6 = "false";
        }
        private void but7_()
        {
            answer6 = "X";
            id_.Add("7");
            Enable7 = "false";
        }
        private void but8_()
        {
            answer7 = "X";
            id_.Add("8");
            Enable8 = "false";
        }

        private void but9_()
        {
            answer8 = "X";
            id_.Add("9");
            Enable9 = "false";
        }


        private void start_()
        {
            MessageBox.Show("1");
            //Game_Function game = new Game_Function();
            
        }


    }
}
