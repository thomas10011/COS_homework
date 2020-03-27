using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
    [Serializable]
    public class Member
    {
        public string memberNum { get; }
        public string memberName { get; }
        public double points { get; }//会员积分
        public List<Order> orders;//会员名下的订单


        public Member(string memberNum, string memberName)
        {
            this.memberNum = memberNum;
            this.memberName = memberName;
            points = 0;
            orders = new List<Order>();


        }
        public Member() { }

        public void printOrders()//打印订单
        {
            foreach(Order order in orders)
            {
                order.print();
                
                Console.WriteLine();
            }
            
        }
        
        public void addOrder(Order order)
        {
            orders.Add(order);//添加订单
        }

        public bool anyOrder()
        {
            return orders.Count != 0;
        }
    }
}
