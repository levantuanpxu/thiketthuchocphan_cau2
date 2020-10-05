using System;
using System.Collections.Generic;

namespace ThiHocPhanCau2
{
    public class Table:ITable
     {
        public int TableId{get;set;}
        public DateTime StartTime{get;set;}
        public DateTime EndTime{get;set;}
        public long SumTotal{get;set;}
        List<OrderDetail> orderLists = new List<OrderDetail>();
        public  void  ShowInfo(){
            Console.WriteLine("TableId:" + TableId);
            Console.WriteLine("StartTime:" + StartTime);
            Console.WriteLine("EndTime:" + EndTime);
            Console.WriteLine("SumTotal:" + SumTotal);
      }
      public  void  Pay(){
            foreach(OrderDetail item in orderLists)
            {
                SumTotal+= item.Total;
            }
      }
        internal void Display()
        {
        }
    }
}