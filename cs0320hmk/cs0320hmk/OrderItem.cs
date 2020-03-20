using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
  

    class OrderItem
    {
        private  string name;//商品名称

        private double price;//商品单价
        private double totalPrice;

        private int number;//商品数量

        public string getName()
        {
            return name;
        }
        public double getPice()
        {
            return price;
        }
        public double getTotalPrice()
        {
            return number * price;
        }
        public int getNum()
        {
            return number;
        }

        OrderItem(string name, double price, int num)
        {
            this.name = name;
            this.price = price;
            number = num;
        }

    }
}
