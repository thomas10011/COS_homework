﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{

    class Order
    {
        public Order(int ItemNumber)//constructor  ItemNumber表示订单项的数量
        {
            orderPrice = 0; //订单初始总金额为0

            orderTime = DateTime.Now; //初始化当前时间

            Random rand = new Random();
            orderNumber = rand.Next(10000,19999); //初始化订单号

            createOrderItem(ItemNumber);//创建订单
        }

        private double orderPrice;//订单总金额

        private int orderNumber;//订单编号
        private DateTime orderTime;//订单创建时间



       private  List<OrderItem> items = new List<OrderItem>();

        private bool insertItem(string name, double price, int num)
        {
            OrderItem newItem = new OrderItem(name, price, num);
            items.Add(newItem);

            return true;
        }


        private void createOrderItem(int ItemNum)//创建订单函数
        {

            for (int i = 0; i < ItemNum; i++)
            {
                
                Console.WriteLine("请输入商品名称，单价，以及数量，以回车结束");
                 String input = Console.ReadLine();
                string[] temp = input.Split();
                insertItem(temp[0], Convert.ToDouble(temp[1]), Convert.ToInt32(temp[2]));
            }



        }

    }
}