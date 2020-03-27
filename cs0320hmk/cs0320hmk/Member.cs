using System;
using System.Collections.Generic;
using System.Text;

namespace cs0320hmk
{
    class Member
    {
        public string memberNum { get; }
        public string memberName { get; }
        private int points;//会员积分
        private List<Order> orders;//会员名下的订单


        public Member(string memberNum, string memberName)
        {
            this.memberNum = memberNum;
            this.memberName = memberName;
            points = 0;
            orders = new List<Order>();
        }
        
        public bool anyOrder()
        {
            return orders.Count != 0;
        }
    }
}
