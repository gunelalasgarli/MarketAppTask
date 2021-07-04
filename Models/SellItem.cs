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
        public Product SellItemProduct { get; set; }
        public static int SellItemCount { get; set; } 
        public static int Count { get; set; }

        public SellItem(int sellitemno,Product sellitemproduct, int count)
        {
        
            Count++;
            SellItemCount += Count;
        
        }

        public override string ToString()
        {

            return $"{SellItemProduct}, {SellItemNo}, {SellItemCount}";

        }

    }


}
