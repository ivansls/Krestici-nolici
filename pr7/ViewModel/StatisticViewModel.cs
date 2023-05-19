using pr7.Model;
using pr7.View;
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
    internal class StatisticViewModel : BindingHelper
    {
        public static List<statistic> List { get; set; } = new List<statistic> { };

        public string n;

        public static string user;
        public static string robot_st;
        public static string none_st;

        int c_user;
        int c_robot;
        int c_none;

        public List<statistic> list1
        {
            get { return List; }
            set
            {
                List = value;
                OnPropertyChenged();
            }
        }

        public StatisticViewModel()
        {
            Back = new BindableCommand(_ => back());
        }

        public ICommand Back { get; }

        public string user1
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChenged();
            }
        }

        public string robot
        {
            get { return robot_st; }
            set
            {
                robot_st = value;
                OnPropertyChenged();
            }
        }

        public string none
        {
            get { return none_st; }
            set
            {
                none_st = value;
                OnPropertyChenged();
            }
        }


        public void FOr_(List<statistic> list)
        {
            list1 = list;
            foreach (statistic statc in list1)
            {
                if (statc.name == n)
                {
                    c_user++;
                    user1 = n + " - " + c_user.ToString();
                }
                else if (statc.name == "Робот")
                {
                    c_robot++;
                    robot = "Робот - " + c_robot.ToString();
                }
                else if (statc.name == "Ничья")
                {
                    c_none++;
                    none = "Ничья - " + c_none.ToString();
                }
            }
        }

        public void back()
        {
            Statistic win = Application.Current.Windows.OfType<Statistic>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
        }
    }
}
