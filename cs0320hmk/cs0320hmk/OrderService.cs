using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
    class OrderService
    {
        public OrderService()
        {
            
        }

        private List<Order> orders = new List<Order>();

       public void createOrder()//创建新订单
        {
            Console.WriteLine("请输入订单数量，回车键结束：");
            int orderNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入订单中的商品数量, 回车键结束：");
            int ItemNum = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < orderNum; i++)
            {
                Order newOrder = new Order(ItemNum);//创建新订单。
                orders.Add(newOrder);
            }
            


        }

    }
}
