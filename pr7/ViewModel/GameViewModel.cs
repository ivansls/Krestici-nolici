using pr7.Model;
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
        int c = 0;

        public static int count = 0;  

        public static List<string> id_ = new List<string> { };

        public static string a1 = "";
        public static string a2 = "";
        public static string a3 = "";
        public static string a4 = "";
        public static string a5 = "";
        public static string a6 = "";
        public static string a7 = "";
        public static string a8 = "";
        public static string a9 = "";



        public static List<statistic> st = new List<statistic>();


        public static string ch_val = "false";

        public string ch_us
        {
            get { return ch_val; }
            set
            {
                ch_val = value;
                OnPropertyChenged();
            }
        }

        public string ch_ro
        {
            get { return ch_val; }
            set
            {
                ch_val = value;
                OnPropertyChenged();
            }
        }


        public static string Answer1 = "";

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
            get { return Answer1; }
            set
            {
                Answer1 = value;
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
            User_ = new BindableCommand(_ => Unlock());
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
            Stat = new BindableCommand(_ => Stist());
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

        public ICommand Stat { get; }


        private void Unlock()
        {
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

        private void Lock()
        {
            Enable1 = "False";
            Enable2 = "False";
            Enable3 = "False";
            Enable4 = "False";
            Enable5 = "False";
            Enable6 = "False";
            Enable7 = "False";
            Enable8 = "False";
            Enable9 = "False";
            answer = "";
            answer1 = "";
            answer2 = "";
            answer3 = "";
            answer4 = "";
            answer5 = "";
            answer6 = "";
            answer7 = "";
            answer8 = "";
            a1 = "";
            a2 = "";
            a3 = "";
            a4 = "";
            a5 = "";
            a6 = "";
            a7 = "";
            a8 = "";
            a9 = "";
            ch_us = "false";
            ch_ro = "false";
            
        }
        private void Robot()
        {
            if (c == 0)
            {
                Unlock();
                c++;
            }
            
            Game_Function g = new Game_Function();
            int a = g.Random_();
            if (a == 1)
            {
                Enable1 = "False";
                answer = "0";
                a1 = "0";
                count++;

            }
            else if (a == 2)
            {
                Enable2 = "False";
                answer1 = "0";
                a2 = "0";
                count++;
            }
            else if (a == 3)
            {
                Enable3 = "False";
                answer2 = "0";
                a3 = "0";
                count++;
            }
            else if (a == 4)
            {
                Enable4 = "False";
                answer3 = "0";
                a4 = "0";
                count++;
            }
            else if (a == 5)
            {
                Enable5 = "False";
                answer4 = "0";
                a5 = "0";
                count++;
            }
            else if (a == 6)
            {
                Enable6 = "False";
                answer5 = "0";
                a6 = "0";
                count++;
            }
            else if (a == 7)
            {
                Enable7 = "False";
                answer6 = "0";
                a7 = "0";
                count++;
            }
            else if (a == 8)
            {
                Enable8 = "False";
                answer7 = "0";
                a8 = "0";
                count++;
            }
            else if (a == 9)
            {
                Enable9 = "False";
                answer8 = "0";
                a9 = "0";
                count++;
            }
            int win = g.Win();
            if (win == 0)
            {
                statistic statistic = new statistic()
                {
                    name = "Ничья",
                    GM = 1
                };
                st.Add(statistic);
                MessageBox.Show("Ничья");
                Lock();
            }
            else if (win == 1)
            {
                statistic statistic = new statistic()
                {
                    name = user,
                    GM = 1
                };
                st.Add(statistic);
                MessageBox.Show("Победил: " + user);
                Lock();
            }
            else if (win == 2) 
            {
                statistic statistic = new statistic()
                {
                    name = "Ничья",
                    GM = 1
                };
                st.Add(statistic);
                MessageBox.Show("Победил: Робот");
                Lock();
            }

        }

        private void but1_()
        {
            answer = "X";
            id_.Add("1");
            Enable1 = "false";
            a1 = "X";
            count++;
            Robot();
        }

        private void but2_()
        {
            answer1 = "X";
            id_.Add("2");
            Enable2 = "false";
            a2 = "X";
            count++;
            Robot();
        }

        private void but3_()
        {
            answer2 = "X";
            id_.Add("3");
            Enable3 = "false";
            a3 = "X";
            count++;
            Robot();
        }

        private void but4_()
        {
            answer3 = "X";
            id_.Add("4");
            Enable4 = "false";
            a4 = "X";
            count++;
            Robot();
        }

        private void but5_()
        {
            answer4 = "X";
            id_.Add("5");
            Enable5 = "false";
            a5 = "X";
            count++;
            Robot();
        }

        private void but6_()
        {
            answer5 = "X";
            id_.Add("6");
            Enable6 = "false";
            a6 = "X";
            count++;
            Robot();
        }
        private void but7_()
        {
            answer6 = "X";
            id_.Add("7");
            Enable7 = "false";
            a7 = "X";
            count++;
            Robot();
        }
        private void but8_()
        {
            answer7 = "X";
            id_.Add("8");
            Enable8 = "false";
            a8 = "X";
            count++;
            Robot();
        }

        private void but9_()
        {
            answer8 = "X";
            id_.Add("9");
            Enable9 = "false";
            a9 = "X";
            count++;
            Robot();
        }


        private void Stist()
        {
            Statistic stat = new Statistic();
            stat.Show();
            //Game_Function game = new Game_Function();
            
        }


    }
}
