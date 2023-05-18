using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pr7.View;

namespace pr7.ViewModel.Logic_Helper
{
    internal class Game_Function : GameViewModel
    {
        Random rnd = new Random();
        public int Random_()
        {
            bool flag = true;
            while (flag)
            {
                int value = rnd.Next(1, 9);
                switch (value)
                {
                    case 1:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "1")
                            {
                                flag = false;
                                Random_();
                            }
                            else 
                            {
                                return value;
                            }
                        }
                        break;
                    case 2:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "2")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 3:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "3")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 4:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "4")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 5:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "5")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;

                    case 6:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "6")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 7:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "7")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 8:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "8")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                    case 9:
                        foreach (string g in id_)
                        {
                            if (g.ToString() == "9")
                            {
                                flag = false;
                                Random_();
                            }
                            else
                            {
                                return value;
                            }
                        }
                        break;
                }
            }
        }


    }
}
