using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using pr7.View;

namespace pr7.ViewModel.Logic_Helper
{
    internal class Game_Function : GameViewModel
    {
        Random rnd = new Random();
        int _answer = 0;
        
        public int Random_()
        {
            bool flag = true;
            while (flag)
            {
                int value = rnd.Next(1, 9);
                switch (value)
                {
                    case 1:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 2:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 3:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 4:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 5:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;

                    case 6:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 7:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 8:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            _answer = value;
                            flag = false;
                        }
                        break;
                    case 9:
                        if (id_.Count != 0)
                        {
                            foreach (string g in id_)
                            {
                                if (g.ToString() == "7")
                                {
                                    flag = false;
                                    Random_();
                                }
                                else
                                {
                                    _answer = value;
                                    flag = false;
                                }
                            }
                        }
                        else
                        {

                            _answer = value;
                            flag = false;
                        }
                        break;
                }
            }
            return _answer;
        }

        public int Win()
        {
            bool us = false;
            bool ro = false;
            int a = -1;
            

            try
            {
                if (a1 == "X" && a2 == "X" && a3 == "X")
                {
                    us = true;
                    throw new Exception("1");

                }
                else if (a4 == "X" && a5 == "X" && a6 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a7 == "X" && a8 == "X" && a9 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a1 == "X" && a4 == "X" && a7 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a2 == "X" && a5 == "X" && a8 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a3 == "X" && a6 == "X" && a9 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a1 == "X" && a5 == "X" && a9 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }
                else if (a3 == "X" && a5 == "X" && a7 == "X")
                {
                    us = true;
                    throw new Exception("1");
                }

                else if (a1 == "0" && a2 == "0" && a3 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a4 == "0" && a5 == "0" && a6 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a7 == "0" && a8 == "0" && a9 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a1 == "0" && a4 == "0" && a7 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a2 == "0" && a5 == "0" && a8 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a3 == "0" && a6 == "0" && a9 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a1 == "0" && a5 == "0" && a9 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else if (a3 == "0" && a5 == "0" && a7 == "0")
                {
                    ro = true;
                    throw new Exception("1");
                }
                else
                {
                    if (count >= 9)
                    {
                        a = 0;
                        throw new Exception("1");

                    }

                }
            }
            catch (Exception e)
            {
                if (us == true)
                {
                    a = 1;
                }
                else if (ro == true)
                {
                    a = 2;
                }
                else
                {
                    a = 0;
                }
            }
            return a;
        }

     


    }
}
