using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
    [Serializable]
    public class Order
    {
        public Order(int ItemNumber, string memberNum, double points, string memberName)//constructor  ItemNumber表示订单项的数量
        {
            orderPrice = 0; //订单初始总金额为0
            this.memberNum = memberNum;
            this.memberName = memberName;
            orderTime = DateTime.Now; //初始化当前时间
            
            Random rand = new Random();
            orderNumber = rand.Next(10000,19999); //初始化订单号
            orderPrice = 0;
            currentPoints = points;
            createOrderItem(ItemNumber);//创建订单
        }
        public Order() { }

        public string memberNum;
        public string memberName;
        public double orderPrice;//订单总金额
        public double currentPoints;
        public double orderPoints;
        public int orderNumber;//订单编号
        public DateTime orderTime;//订单创建时间


        private  List<OrderItem> items = new List<OrderItem>();

        public void print()
        {
            Console.WriteLine($"订单号：{orderNumber} 日期:{Convert.ToString(orderTime)}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"商品名称  单价  数量  金额");
            int totalNum = 0;//商品总数
            foreach(OrderItem item in items)
            {
                
                totalNum += item.number;
                Console.WriteLine($"{item.name}       {item.price}       {item.number}       {item.totalPrice}");
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"合计数量：{totalNum}");
            Console.WriteLine($"合计金额：{orderPrice}元");
            Console.WriteLine($"会员号：{memberNum} 会员名：{memberName}");
            Console.WriteLine($"积分余额:{currentPoints} 本次积分:{Convert.ToString(orderPoints)}");


        }
        private bool insertItem(string name, double price, int num)
        {
            OrderItem newItem = new OrderItem(name, price, num);
            items.Add(newItem);
            orderPrice += newItem.totalPrice;
            orderPoints += newItem.totalPrice / 10;
            return true;
        }


        private void createOrderItem(int ItemNum)//创建订单项
        {

            for (int i = 0; i < ItemNum; i++)
            {
                
                Console.WriteLine($"请输入第{i+1}个商品的名称，单价，以及数量，以回车结束:");
                String input = Console.ReadLine();
                string[] temp = input.Split();
                insertItem(temp[0], Convert.ToDouble(temp[1]), Convert.ToInt32(temp[2]));
                orderPoints = orderPrice / 10;
            }



        }

        public double getPoints()
        {
            return orderPoints;
        }
    }
}
