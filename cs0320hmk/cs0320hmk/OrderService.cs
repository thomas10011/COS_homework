using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

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

        public string currentMemberNum { set; get; }
        Member currentMember = null;
        public List<Member> members;

        public bool checkMemberNum(string num)//检测当前输入的会员号是否合法
        {
            //采用linq查询语言。
            currentMember = (from m in members where m.memberNum == num select m).FirstOrDefault();//返回一个Member对象
            return currentMember != null;
        }

        public void Export()
        {
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Member>));
                using (FileStream fs = new FileStream("members.xml", FileMode.Create))
                {
                    xmlserializer.Serialize(fs, members);
                }
                Console.WriteLine("订单信息导出成功！");
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Import()
        {
            try
            {
                XmlSerializer xmlseializer = new XmlSerializer(typeof(List<Member>));
                using(FileStream fs = new FileStream("members.xml", FileMode.Open))
                {
                    members.Clear();
                    members = (List<Member>)xmlseializer.Deserialize(fs);
                    /*foreach(Member m in (Member[])xmlseializer.Deserialize(fs))
                    {
                        members.Add(m);
                    }*/
                }
                Console.WriteLine("订单信息导入成功！");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getCurrentMemberName()
        {
            return currentMember.memberName;
        }

        public bool showOrder()
        {
            if (currentMember.anyOrder())
            {
                currentMember.printOrders();//打印订单
                return true;
            }
            else
            {
                Console.WriteLine("您的订单数量为0！");
                return false;
            }

        }


       public void createOrder()//创建新订单
        {
            try
            {
                Console.WriteLine("请输入订单数量，回车键结束：");
                int orderNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < orderNum; i++)
                {
                    Console.WriteLine($"请输入{i + 1}个第订单中的商品数量, 回车键结束：");
                    int ItemNum = Convert.ToInt32(Console.ReadLine());
                    Order newOrder = new Order(ItemNum, currentMember.memberNum, currentMember.points, currentMember.memberName);//创建新订单。
                    currentMember.addOrder(newOrder);
                    Console.WriteLine($"第{i + 1}个订单创建成功。");
                }
                
                Console.WriteLine("所有订单创建成功，将返回系统主界面。");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
