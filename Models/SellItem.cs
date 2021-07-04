using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp.Models
{
    class SellItem
    {
        public int SellItemNo { get; set; }
        public string SellItemName { get; set; }
        public int SellItemCount { get; set; } 
        public static int Count { get; set; }

        public SellItem(string sellitemname, int sellitemcount)
        {

            Count++;
            SellItemNo = Count;
            SellItemName = sellitemname;
            SellItemCount = sellitemcount;
        }
        public SellItem(int sellitemno, int sellitemcount)
        {
            SellItemNo = sellitemno;
            SellItemCount = sellitemcount;
        }

        public override string ToString()
        {

            return $"{SellItemName}, {SellItemNo}, {SellItemCount}";

        }

    }
   
}