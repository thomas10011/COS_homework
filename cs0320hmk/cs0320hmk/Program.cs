﻿using System;

namespace cs0320hmk
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Console.WriteLine("欢迎进入订单管理系统！");
            pg.login();
        }
        Program()
        {
            os = new OrderService();
        }

        private OrderService os;

        public void login()//展示会员登陆界面
        {
            Console.WriteLine("请输入您的会员号：");
            string memberNum = Console.ReadLine();
            if (os.checkMemberNum(memberNum))
            {
                Console.WriteLine($"欢迎{memberNum}!");
                showSystem();
            }
            else
            {
                Console.WriteLine("抱歉，您输入的会员号无效！");
                login();
                return;
            }

            
        }

        public void showSystem()//展示系统界面
        {
            Console.WriteLine("按c查询您的订单，按n创建新订单，按q退出系统！");
            string instruction = Console.ReadLine();
            switch (instruction)
            {
                case "c":
                    os.showOrder();
                    showSystem();//打印订单结束后继续展示系统界面
                    break;
                case "n":
                    os.createOrder();
                    showSystem();
                    break;
                case "q":
                    return;
                    break;
                default:
                    Console.WriteLine("输入的按键无效，请重新输入。");
                    showSystem();
                    return;
            }
        }

    }
}
