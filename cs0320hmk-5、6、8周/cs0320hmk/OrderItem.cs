using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
  

    class OrderItem
    {
        public string name { get; }//商品名称
        public double price { get; }//商品单价
        public int number { get; }//商品数量
        public double totalPrice
        {
            get { 
                return number * price;
            }
        }
        

        public OrderItem(string name, double price, int num)
        {
            this.name = name;
            this.price = price;
            number = num;
        }

    }
}
