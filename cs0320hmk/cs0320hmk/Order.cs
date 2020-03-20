using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{

    class Order
    {
        public Order(int ID, int ItemNumber)//constructor  ItemNumber表示订单项的数量
        {
            orderTime = DateTime.Now; //初始化当前时间
            orderNumber = ID; //初始化订单号
            createOrder(ItemNumber);//创建订单
        }
        private int orderNumber;//订单编号
        private DateTime orderTime;//订单创建时间



        List<OrderItem> items;

        private bool insertItem(string name, double price, int num)
        {
            OrderItem newItem = new OrderItem(name, price, num);
            items.Add(newItem);

            return true;
        }
        private void createOrder(int ItemNum)//创建订单函数
        {
            string name;
            double price;
            int num;

            for (int i = 0; i < ItemNum; i++)
            {
                
                Console.WriteLine("请输入商品名称，以回车结束");
                name = Console.ReadLine();

                Console.WriteLine("请输入商品名称，以回车结束");
                price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("请输入商品名称，以回车结束");
                num = Convert.ToInt32(Console.ReadLine());

            }



        }


    }
}
