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

        List<Order> orders;

       public void createOrder()//创建新订单
        {
            Console.WriteLine("请输入订单中的商品数量, 回车键结束：");
            int ItemNum = Convert.ToInt32(Console.ReadLine());

            Order newOrder = new Order(ItemNum);//创建新订单。
            orders.Add(newOrder);


        }

    }
}
