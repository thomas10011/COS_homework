using System;

namespace cs0320hmk
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

        }
        Program()
        {
            os = new OrderService;
        }

        private OrderService os;

        public void show()
        {
            Console.WriteLine("欢迎进入订单管理系统！");
            Console.WriteLine("按c查询订单，按n创建新订单，按q退出系统！");
            string instruction = Console.ReadLine();
            switch (instruction)
            {
                case "c":

            }
        }
    }
}
