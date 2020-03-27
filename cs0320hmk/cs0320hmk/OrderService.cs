using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cs0320hmk
{
    class OrderService
    {
        public OrderService()
        {
            members = new List<Member>(){
                new Member("2018302110296", "thomas"),
                new Member("2018302110300", "wzy")

            };
        }

        string currentMemberNum { set; get; }
        Member currentMember = null;
        private List<Order> orders = new List<Order>();
        private List<Member> members;

        public bool checkMemberNum(string num)//检测当前输入的会员号是否合法
        {
            //采用linq查询语言。
            currentMember = (from m in members where m.memberNum == num select m).FirstOrDefault();
            return currentMember != null;
        }


        public bool showOrder()
        {
            if (currentMember.anyOrder())
            {
                return true;
            }
            else
            {
                Console.WriteLine("当前订单系统中订单为0！");
                return false;
            }

        }


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
